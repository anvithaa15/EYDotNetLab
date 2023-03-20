use EYDatabase
select * from product

--loop and conditional statements--

declare @a int
set @a=0
while @a<=10
begin
if @a=2
goto tech
set @a=@a+1
end
tech:
print 'welcome to EY'
--------

declare @x int
if @x=1
print 'Hello World'
else
print 'Bye'
---------
declare @y int
set @y=1
while @y<=10
begin 
print @y
set @y=@y+1
end
--------

declare @m int
if @m=1
print 'Hello World'
else if @m<=5
print 'Welcome to India'
else
print 'Welcome to Australia'

--sp with values---
create procedure getcountofemps
as
declare @emprow as int
select @emprow=count(*)from employee
return @emprow
go
--====executing the stored procedure
declare @return_val int
exec @return_val=getcountofemps
select 'Return Value'=@return_val
go
