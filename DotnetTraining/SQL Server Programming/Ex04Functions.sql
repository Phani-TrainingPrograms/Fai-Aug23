Create Function getEmpCount()
RETURNS INTEGER
AS
BEGIN
DECLARE @count int
Set @count = (Select Count(*) From EmpTable)
RETURN @count
END

Select dbo.getEmpCount() as EmpCount

Create Function getDeptName(@id int)
RETURNS NVARCHAR(50)
AS
BEGIN
 DECLARE @deptName NVARCHAR(50)
 Set @deptName = (Select DeptName from DeptTable Where DeptId = @id)
 RETURN @deptName
END

Select dbo.getDeptName(2);

Select EmpName, dbo.getDeptName(Emptable.DeptId) as Department from Emptable


----------------------Working with Date-Time Functions of SQL server------------
PRINT GETDATE() -- Gets the server data and time. 

Create Function CreateDate(@date date)
RETURNS VARCHAR(50)
AS
BEGIN
DECLARE @retVal varchar(50)
Set @retVal = '' + CAST(DAY(@date) as varchar(5)) + '/' + CAST(MONTH(@date) as varchar(20)) + '/' + CAST(YEAR(@date) as varchar(4))
RETURN @retVal
END

PRINT dbo.createDate(GETDATE())

--Todo: create a function to get the age given the date of birth
Create Function getAge(@dob Date)
RETURNS int
AS
BEGIN
DECLARE @age int = 0
Set @age = DATEDIFF(year, @dob, GETDATE())
RETURN @age
END

PRINT dbo.getAge('1976/12/01')


--------------------Table value functions----------
Create Function getAllEmployees()
RETURNS TABLE
AS
RETURN (SELECT * FROM EMPTABLE)


Select EmpName from dbo.getAllEmployees();








