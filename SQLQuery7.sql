--=================sql day-7 march 10th 2023===============--
use EYDatabase

create table student1
(
studid int primary key,
name varchar(60),
city varchar(60),
mobile int,
course_id int,
)

select * from student1
alter table student1 add foreign key(course_id) references subjectt(course_id)

insert into student1 values(1,'anvitha','mysore',886159484,100),(2,'bhoomika','bangalore',0097612352,100),
(3,'rachana','mysore',886152384,101),(4,'pavan','bangalore',889081284,101),
(5,'nidhi','pune',886129045,102),(6,'lekhana','chennai',907293445,102),
(7,'uditha','bihar',973299045,103),(8,'harsha','delhi',881119045,103),
(9,'sharath','mumbai',886111133,104),(10,'madhu','delhi',636395411,104)


create table subjectt
(
course_id int primary key,
course_name varchar(60),
marks int
)

insert into subjectt values(100,'science',75),(101,'math',85),
(102,'social science',95),(103,'chemistry',80),(104,'english',96)

select* from subjectt

--queries--
select * from student1 s1 left join subjectt s2
on s1.studid=s2.course_id

select * from student1 s1 left join subjectt s2
on s1.course_id=s2.course_id

select * from student1 s1 right join subjectt s2
on s1.course_id=s2.course_id

select * from student1 s1 right join subjectt s2
on s1.course_id<=s2.course_id

select * from student1 s1 full join subjectt s2
on s1.course_id=s2.course_id

select * from student1 s1 join student1 s2
on s1.course_id=s1.course_id

--=============user defined functions===============--
--3 types---table valued, scalar valued,user defined

--table valued function example-
create function func1(
@students varchar(60)
)
returns table
as 
return
select studid, city,mobile from student1 where name=@students;

select * from func1('anvitha') --to call or execute the function

----scalar valued function example-----
create function hola(@temp int)
returns int
as
begin
declare @y int
select @y=count(*) from student1 where studid>=@temp
return @y
end --call function

select dbo.hola(5)  --to call or execute the function

--another example to return table
create function fun2()
returns table
as return(
select course_id,course_name,marks from subjectt);
go

select * from fun2() --to call the function

--insert,delete and update operations--