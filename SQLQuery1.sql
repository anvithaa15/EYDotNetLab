--================SQL day-1 started on 1st march 2023==================--

--to create database
--create database EYDatabase

--use EYDatabase (already at use)
--create table customer(custid int,custname varchar(50),custsalary int)
--create table student(studid int,studname varchar(50))

--to drop a database or table
--drop table student

--to show all databases
--select name from master.sys.databases order by name

--to drop database if it exists (NA on table)
--create database apple
--drop database if exists apple

--alter
--alter table customer add custorder varchar(50)
--alters the datatype value(varchar50->100 here)
--alter table customer alter column custname varchar(100) 

--primary key constraint
--create table persons
--(
--	ID int not null,
--	lastNamne varchar(255) not null,
--	firstName varchar(255),
--	age int,
--	primary key(ID)
--)

--not null constraint
--create table persons1
--(
--	ID int not null,
--	lastNamne varchar(255) not null,
--	firstName varchar(255) not null,
--	age int,
--	primary key(ID)
--)

--default constraint (NA for primary key and default value is added automatically)
--create table persons3
--(
--	ID int not null,
--	lastNamne varchar(255) not null,
--	firstName varchar(255) not null,
--	age int,
--	city varchar(255) DEFAULT 'mysore'
--)
--select * from persons3

--check constraint
--create table persons4
--(
--	ID int not null,
--	lastNamne varchar(255) not null,
--	firstName varchar(255) not null,
--	age int,
--	check (age>=18)
--)

--unique constraint (accepts only one null value,lil diff from primary key)
--create table persons5
--(
--	ID int not null unique,
--	lastNamne varchar(255) not null,
--	firstName varchar(255),
--	age int
--)	

--creating primary and foreign key ref for old table(persons)
--create table  orders
--(
--	orderid int not null primary key,
--	ordernumber int not null,
--	personsID int foreign key references persons(ID)
--)