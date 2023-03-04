--================SQL day-2 march 2nd 2023==================--
--SELECT * FROM Customers;

--/////////////////DML///////////////////

--======insert==============
--insert into customers(customer_id,first_name,last_name,age,country) values(101,'anvitha','a',23,'UK')
--insert into customers(customer_id,first_name,last_name,age,country) values(102,'momo','s',23,'US'),(99,'vini','a',18,'US')
--insert into customers(customer_id,first_name,last_name,age,country) values(103,'vini','a',18,'US')

--=========update===========
--update customers set first_name='madhu' where customer_id=5
--update customers set first_name='madhu',last_name='anvi',age=26 where customer_id=5
--update customers set first_name='mochu' where age=23 and last_name='s'

--==========delete============
--delete from customers where customer_id=99

--==========select===========
--select *from customers where customer_id=2 and last_name='Doe' or age=31

--///////////clauses////////////
--where--

--not--
--select *from customers where first_name is null
--select *from customers where first_name is null and customer_id is null

--between--
--select *from customers where customer_id between 1 and 5
--select *from customers where customer_id between 101 and 103

--not between--
--select * from customers where age not between 20 and 25

--order by--
--select * from customers order by age asc, first_name
--select * from customers order by customer_id desc

--like operator--
--select * from customers where first_name like 'm%'
--select * from customers where last_name like '%a'
--select * from customers where first_name like 'ma%'

--group by--
--select first_name,sum(customer_id) from customers group by first_name

--having--
--select first_name,max(age) from customers group by first_name having first_name='anvitha'

--distinct--
--select distinct(first_name)from customers

--top--
--select top(3) first_name from customers

--in--
--select * from customers where customer_id in(3,4,5)

--not in--
--select * from customers where customer_id not in(3,4,5)

--any--
--select * from customers where customer_id <=any(select customer_id from customers where customer_id<=3)

--all--


--/////////aggregate functions//////--
--sum--
--select sum(customer_id) 'sum of customer ids' from customers

--avg--
--select avg(age) 'average of customer ages' from customers

--count--
--select count(age) 'count of customer ages' from customers

--min--
--select min(age) 'min of customer ages' from customers

--max--
--select max(age) 'max of customer ages' from customers

--/////operators/////--
--set
--union-
--union all
--intersect
--except