
/*pro2.sql*/

drop procedure if exists place_order ;

delimiter $


CREATE procedure place_order (p_customer_id int , p_product_id int, p_qty int)
BEGIN

declare stk int default 0;
declare prodexists bool default false;
declare cprice int default 0;

declare exit handler for sqlexception

BEGIN
rollback;

select "an error transaction rolled back" as ERROR;
END;

start transaction;

select price*p_qty into cprice from products2 where product_id=p_product_id;
select true into prodexists from products2 where product_id=p_product_id;
select stock into stk from products2 where product_id=p_product_id;

if prodexists THEN

if p_qty<=stk THEN

update products2 set stock=stock-p_qty where product_id=p_product_id;

insert into orders2 values(default,p_customer_id,p_product_id,p_qty,cprice,default);


select concat("Total Cost is",(cprice*1.18),"!") as BILL;

commit;
ELSE

select "Ordered quantity is not available!" as ERROR;

end if;

ELSE

select "Product doesn't exist!" as error;

end if;

end$

delimiter ;

