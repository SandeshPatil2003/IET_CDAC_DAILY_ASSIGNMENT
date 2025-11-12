


drop procedure if exists transfer_funds ;

delimiter $
create procedure transfer_funds(p_from_acc int, p_to_acc int, p_amount int)
BEGIN
declare bal int default 0;
declare acc1exists bool default false;
declare acc2exists bool default false;

declare EXIT handler FOR sqlexception 

BEGIN
rollback;

SELECT 'An error occurred. Transaction rolled back.' AS Error;
END;
start TRANSACTION;


select balance into bal from accounts where acc_no=p_from_acc;

select true into acc1exists from accounts where acc_no=p_from_acc;
select true into acc2exists from accounts where acc_no=p_to_acc;





if acc1exists and acc2exists

then

if p_amount>bal

then 

select "insufficient balance" as Warning;

ELSE

update accounts set balance = balance - p_amount where acc_no=p_from_acc;
update accounts set balance = balance + p_amount where acc_no=p_to_acc;

COMMIT;
SELECT 'Funds transferred successfully.' AS Success;

end if;


ELSE

select "One or More Accounts don't exist" as Error ;

end if;

END$

Delimiter ;





