--Stored procedures are sp statements that are precreated and parsed, so that they are ready to be used directly from the front end without a need to parse the statements repeatedly. When ever a SQL statement is executed, it will be parsed and if is successfull then the exection will happen. 
-- With frequently used statements, we can make it as a Stored Procedure and invoke them frequently and the need of parsing will not arise. This is an optmized way of using SQL statements that are executed frequently. 

Create Procedure CreateEmployee
(
  @empName nvarchar(50),
  @empAddress nvarchar(50),
  @empSalary money,
  @deptId int,
  @empId int output
)
AS
INSERT INTO EMPTABLE VALUES(@empName, @empAddress, @empSalary, @deptId)
SET @empId = @@IDENTITY
--@@IDENTITY is the id generated after the successfull insertion of the record, this value will be applicable only for identity columns. 

truncate table EmpTable

------------------Create the Stored proc for update

Create Procedure updateEmployee
(
@empName nvarchar(50),
  @empAddress nvarchar(50),
  @empSalary money,
  @deptId int,
  @empId int
)
AS
	Update Emptable Set EmpName = @empName, empAddress = @empAddress, empSalary = @empSalary, DeptId = @deptId where empId = @empId



----------Calling stored proc
EXEC	[dbo].[updateEmployee]
		@empName = N'Phani Raj B.N.',
		@empAddress = N'Bengaluru',
		@empSalary = 65000,
		@deptId = 1,
		@empId = 1000

GO
