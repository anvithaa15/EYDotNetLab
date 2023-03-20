--=======================sql day 6-9th march 2023======================--

use EYDatabase
--table 1
create table Salesman2
(salesman_id int primary key,
name varchar(100),city varchar(100),commission float)

insert into Salesman2 values(5001,'jameshoog','newyork',0.15),
(5002,'nail knite','paris',0.13),
(5005,'pit alex','london',0.11),(5006,'mc lyon','paris',0.14),
(5007,'paul adam','rome',0.13),(5003,'lausen hen','san jose',0.12)

select * from Salesman2

--table 2
create table customerss
(customer_id int primary key, 
cust_name varchar(60),
city varchar(50),
grade int,salesman_id int,
foreign key(salesman_id) references salesman2(salesman_id)
)

insert into customerss values(3002,'nick rimando','newyork',100,5001),
(3007,'brad davis','newyork',200,5001),(3005,'graham susi','california',200,5002),
(3008,'julian green','london',300,5002),(3004,'fabian jhonson','paris',300,5006)
,(3009,'geoff cameron','berlin',100,5003),(3003,'jozy altidor','moscow',200,5007),
(3001,'brad guzan','london',100,5005)

select * from customerss

--exercises/queries--
select * from Salesman2 where city like 'l%'

select * from Salesman2 where commission<0.15

select * from Salesman2 where salesman_id between 5001 and 5005

select * from Salesman2 where not city='london'

select * from Salesman2 order by name desc

select * from customerss order by city asc

select * from customerss

select * from customerss where cust_name like 'n%'

select * from customerss where cust_name like '%s'

select * from Salesman2 s inner join customerss c on c.salesman_id=s.salesman_id

select customerss.cust_name, salesman2.name from salesman2, customerss 
where salesman2.city= customerss.city

select customerss.cust_name, salesman2.name from salesman2, customerss
where salesman2.city= customerss.city and grade between 100 and 400

select distinct(city) from customerss

select salesman_id from customerss where city='london'
and grade between 100 and 200

select count(salesman_id) from salesman2 group by city having city='london'

select max(name) from salesman2 group by city having city='london'

select * from Salesman2 order by name asc,commission desc

select max(name),commission from salesman2 
where city='london' group by commission,name  
order by name asc, commission desc--where,groupby,order by

select name,city from Salesman2 
group by name,city having city='paris'
order by name asc,city desc --groupby,having,order by

select city,count(city) from salesman2
where city='london' 
group by city --where,groupby

select name,city,count(city) from salesman2
where city='london' group by city,name 
having name='nail knite' --where,group by,having

select name from Salesman2
where city=any(select city from Salesman2 where city='london')--any

select * from customerss where city in('london','paris')--in

select name,city 
from Salesman2
where commission>all(select commission from Salesman2 where commission=0.12)--all
--------------

create table employeee
(
empid int identity(1,1) primary key,
empname varchar(60),
gross_salary int,
bonus int unique,
city varchar(60),
address varchar(60) unique
)

insert into employeee values('anvitha',80000,35000,'bangalore','indiranagar'),
('bhoomika',60000,30000,'bangalore','kr puram'),
('yuktha',65000,40000,'mysore','kuvempu nagar')

select * from employeee

create table companyy1
(company_id int identity(1,1) primary key,
company_name varchar(60),
cid int foreign key references employeee(empid)
)

select * from companyy1

insert into companyy1 values ('hcl',1),('ey',2),('pwc',3),('deloitte',4)
