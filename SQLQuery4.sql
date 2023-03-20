--=================SQL day 4. Mar 4th 23===================--
use EYDatabase

--cross join- cartesian product
select * from employee cross join customer
select * from customer cross join employee

--===============Transactions==============--

create table product
(
product_id int primary key,
product_name varchar(40),
price int,
quantity int
)

insert into product values(100,'camera',899,5),(101,'hand bag',580,6),
(102,'watch',2500,4),(103,'dress',1600,6),(104,'laptop',75000,3)

select * from product

--start a new transaction
begin transaction
--sql statements
insert into product values(106,'shoes',800,3)
update product set price=4500 where product_id=100
--commit changes
commit transaction

--for rollback
--start new transaction
begin transaction
--sql statement
update product set price=5000 where product_id=103
delete from product where product_id=106
--undo changes
rollback transaction

--error checking-insert------
begin transaction
insert into product values(107,'book',600,2)
--check for error
if(@@ERROR>0)
begin
	rollback transaction
end
else
begin
	commit transaction
end

-----delete----
begin transaction
delete from product where product_id=107 
--check for error
if(@@ERROR>0)
begin
	rollback transaction
end
else
begin
	commit transaction
end

-----update------
begin transaction
update product set quantity=3 where product_name='sunglasses'
--check for error
if(@@ERROR>0)
begin
	rollback transaction
end
else
begin
	commit transaction
end

--auto rollback transaction--
begin transaction
insert into product values(107,'chair',6000,1)
update product set quantity='ten' where product_id=106
select * from product
commit transaction  --doesnt get executed as there is error in the code.

--savepoint--
begin transaction
insert into product values(107,'headphone',2500,2)
save transaction InsertStatement1
delete from product where product_id=106
select * from product
rollback transaction InsertStatement1 --rollback and reach to previous savepoint(InsertStatement1)
commit 
select* from product

--implicit transaction--
set implicit_transactions on
update product set quantity=10 where product_id=103
--delete from product where product_id=103
select 
	iif(@@options & 2 = 2,
	'implicit transaction mode on',
	'implicit transaction mode off'
	) as 'Transaction Mode'
select @@TRANCOUNT as OpenTrans
commit transaction
select @@TRANCOUNT as OpenTrans

--TranCount--
print @@trancount
--begin tran statement will increment the
--transaction count by 1.
begin tran
	print @@trancount
	begin tran
		print @@trancount
--commit statement will decrement the count by 1.
	commit
	print @@trancount
commit
print @@trancount

--named transaction--
begin transaction AddProduct
insert into product values(108,'bottle',200,4)
update product set product_name='pen drive' where product_id=107
commit transaction AddProduct
--
begin transaction delProduct
delete from product where product_id=108
commit transaction delProduct

select* from product

----
create table testTrans(
ID int, InsertDate datetime);

begin transaction outerTran
insert into testTrans values(1,getdate())
begin transaction innertran
insert into testTrans values(2,getdate())
commit transaction innertran
rollback transaction outerTran

select * from testTrans

--===============Built in functions==============--
select * from product

select sin(0.2),cos(0.3),tan(0.5)
select asin(0.6),acos(0.2),atan(0.2),cot(0.2)
select exp(2),log10(0.2),log(0.5)
select pi(),power(2,3),sqrt(64)
select round(26548.5342,2)

--=============string functions==============--
select ascii('A')
select REPLICATE('india',10)
select replace('india is a country','india','US')
select left('india is a country',5)
select right('india is a country',7)
select reverse('india is a country')
select ltrim('      india'),rtrim('india       ')
select substring('my country is india',4,12)
select lower('HELLO WORLD')
select upper('incredible india')
select value from string_split('india is a country',' ');
select value from string_split('india/is/a/country','/');

--datetime functions--
select DATEADD(year,2,'2023/03/06')
select DATEADD(month,2,'2023/03/06')
select DATEADD(day,2,'2023/03/06')

select datepart(year,'2017/08/25')
select datepart(month,'2017/08/25')
select datepart(day,'2017/08/25')

select datediff(year, '02/03/2023','4/3/2023')
select datediff(month, '02/03/2023','4/3/2023')
select datediff(day, '02/03/2023','4/3/2023')

select datediff(year, '02/03/2023',getdate())
select datediff(month, '02/03/2023',getdate())
select datediff(day, '02/03/2023',getdate())

select DATENAME(year,getdate())
select DATENAME(month,getdate())
select DATENAME(day,getdate())

select GETDATE()
