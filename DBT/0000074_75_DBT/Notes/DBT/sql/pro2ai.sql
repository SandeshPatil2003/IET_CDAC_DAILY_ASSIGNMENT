
/* pro2ai.sql */


drop procedure if exists place_order;

delimiter $

CREATE procedure place_order (
    p_customer_id INT, 
    p_product_id INT, 
    p_qty INT
)
BEGIN

-- Declare variables to fetch data and store calculated values
DECLARE v_stk INT DEFAULT 0;
DECLARE v_unit_price DECIMAL(10, 2) DEFAULT 0.0;
DECLARE v_discount_rate DECIMAL(5, 2) DEFAULT 0.0;
DECLARE v_final_price_per_unit DECIMAL(10, 2) DEFAULT 0.0;
DECLARE v_total_cost DECIMAL(10, 2) DEFAULT 0.0;
DECLARE v_cashback DECIMAL(10, 2) DEFAULT 0.0;

-- Declare a handler to manage "no product found" condition gracefully
DECLARE CONTINUE HANDLER FOR NOT FOUND
BEGIN
    SELECT "Product doesn't exist!" AS ERROR_MESSAGE;
    -- Note: This handler stops the SELECT INTO error, but the IF logic below manages the exit
END;

-- Main handler for general SQL exceptions (rolls back transaction)
DECLARE EXIT HANDLER FOR SQLEXCEPTION
BEGIN
    ROLLBACK;
    SELECT "An unexpected error occurred; transaction rolled back" AS ERROR_MESSAGE;
END;

START TRANSACTION;

-- Fetch price, stock, and the existing discount rate in one go
SELECT price, stock, discount_percent 
INTO v_unit_price, v_stk, v_discount_rate
FROM products2 
WHERE product_id = p_product_id;


-- Check if the previous select found anything (if v_unit_price is 0.0 and no product found handler was hit)
IF v_unit_price = 0.0 THEN
    -- The handler above displayed the error message, we just exit the block/transaction
    COMMIT; -- Nothing to commit/rollback, end the transaction
ELSE
    -- Product exists, proceed with checks
    IF p_qty <= 0 THEN
         SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Quantity must be positive!';

    ELSEIF p_qty <= v_stk THEN
        -- Sufficient stock, proceed with calculation and update
        
        -- 1. Apply Discount
        -- Calculate the price after the assigned discount
        SET v_final_price_per_unit = v_unit_price * (1 - (v_discount_rate / 100));
        SET v_total_cost = v_final_price_per_unit * p_qty;

        -- 2. Assign Random Cashback (0 to ₹100)
        -- RAND() gives a value between 0 and 1. Multiply by 100 and truncate/round.
        SET v_cashback = FLOOR(RAND() * 101); 

        -- Update stock
        UPDATE products2 SET stock = stock - p_qty WHERE product_id = p_product_id;

        -- Insert into orders2, including the calculated total and cashback
        -- Ensure your INSERT matches your actual column names/order
        INSERT INTO orders2 (customer_id, product_id, quantity, total_price, cashback_amount, order_date)
        VALUES (p_customer_id, p_product_id, p_qty, v_total_cost, v_cashback, NOW());

        -- Show success message and final bill (applying 18% tax as you had it previously)
        SELECT CONCAT(
            "Order placed successfully. Total Cost (incl. 18% tax) is ₹", 
            ROUND(v_total_cost * 1.18, 2), 
            "! You earned ₹",
            v_cashback,
            " cashback."
        ) AS BILL;
        
        COMMIT; -- Commit the successful transaction

    ELSE
        -- Insufficient stock
        SELECT "Ordered quantity is not available!" AS ERROR_MESSAGE;
        ROLLBACK; -- Rollback changes since order can't be fulfilled
    END IF;
END IF;

END$

delimiter ;