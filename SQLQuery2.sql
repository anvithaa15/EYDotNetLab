--================SQL day-3 march 3rd 2023==================--
use EYDatabase

--select * from employee
--order by for more than one column
--select * from employee order by empid desc,empsalary asc

--///////JOINS///////--

--inner join--
--select * from employee e inner join customer c
--on e.empid=c.custid

--select * from employee e inner join customer c
--on e.empid>=c.custid

--select * from employee e inner join customer c
--on e.empid<=c.custid

--left join/left outer join--
--select * from customer c left join employee e
--on c.custid=e.empid

--select * from customer c left join employee e
--on c.custid<=e.empid

--select * from customer c left join employee e
--on c.custid>=e.empid

--right join/right outer join--
--select * from customer c right join employee e
--on c.custid=e.empid

--select * from customer c right join employee e
--on c.custid<=e.empid

--select * from customer c right join employee e
--on c.custid>=e.empid

--full join/full outer join--
--select * from customer c full join employee e
--on c.custid=e.empid

--select * from customer c full join employee e
--on c.custid<=e.empid

--select * from customer c full join employee e
--on c.custid>=e.empid

--self join--
--select * from customer c1 join customer c2
--on c1.custid=c2.custid

--select * from customer c1 join customer c2
--on c1.custid<c2.custid

--select * from customer c1 join customer c2
--on c1.custid>c2.custid

--select * from customer c1 left join customer c2
--on c1.custid=c2.custid

--select * from customer c1 left join customer c2
--on c1.custid<c2.custid

--select * from customer c1 left join customer c2
--on c1.custid<c2.custid

--select * from customer c1 left join customer c2
--on c1.custid>c2.custid

--select * from employee
--select * from customer

--except example
--select empname from employee except select custname from customer

--select * from customer except select * from employee

--///////Stored Procedures///////--
--without parameters-1)
create proc displayrecs
as
begin
select * from employee
end

exec displayrecs  --to display or execute
--2)
create proc displayrecords
as
begin
select * from employee
select * from employee where empid<6
select distinct(empid) from employee
select * from employee where empid between 2 and 6
end

exec displayrecords
--3)
create proc displayr
as
begin
insert into employee(empid,empname,empsalary) values(100,'charitha',38000)
end

exec displayr

--4)
create proc pro1
as
begin
delete from employee where empid=100
end

exec pro1

--with parameters 1)--
create proc withparameters
(@eid int, @ename varchar(50),@esal int)
as
begin
insert into employee(empid,empname,empsalary) values(@eid,@ename,@esal)
end

exec withparameters 101,shamika,20000

--2)
create proc delpro
(@eid int)
as
begin
delete from employee where empid=@eid
end

exec delpro 101

--3)mis
--alter proc update_val
--(@ename varchar(50))
--as
--begin
--alter table employee where empname=@ename
--end

--exec update_val 'anvi'

--4)
create proc update_val
(@eid int,@ename varchar(50))
as
begin
update employee set empid=@eid where empname=@ename
end

exec update_val 1,'anvi'

select * from employee
select * from customer 

sp_helptext delpro--to get details of that procedure
--drop proc delpro //to delete a stored procedure

--///////Sub queries///////--
--outer query to inner query--
select *from customer where custid in(select empid from employee where empid>5)

--insert with subquery--
insert into employee
select * from employee where empid in (select custid from customer)

--update with subquery--
update employee set empname='sonali' where empid in(select custid from customer where 
custid >4)

--delete from subquery--
delete from customer where custid in(select empid from employee
where empid=5)

