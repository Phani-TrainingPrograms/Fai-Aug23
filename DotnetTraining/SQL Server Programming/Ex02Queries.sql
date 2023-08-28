--Queries in SQL Server
use FaiTraining
Select * from Emptable
Select * from DeptTable
Select * from empTable where empId >= 1004 order by empId desc

--Use the Functions of SQL server to get aggregate values from the table. 
Select MAX(EmpSalary) as MaxSalary, MIN(EmpSalary) as MinSalary , Avg(EmpSalary) as AvgSalary from Emptable

Select EmpName from Emptable where empAddress = 'Mysore'

Select EmpName, empSalary from EmpTable where empAddress ='Mysore' and empSalary > 50000

Select * from Emptable where EMpName like 'A%' --records with name starting from A....

Select EmpName, COALESCE(DeptId, 0) from EmpTable
--use Coalesce to replace the value based on the truthness of the condition. Coalese method is available from SQL Server 2008. Earlier we were using ISNULL. 
Select EmpName, ISNULL(DeptId, 0) as DeptInfo from EmpTable

Select TOP(10) EmpName, EmpSalary from EmpTable where EMpAddress = 'Bangalore'  ORDER BY empSalary DESC
Select TOP 50 PERCENT * from Emptable
--TODO: Get the bottom 50 % from the EmpTable. 
---------------JOINS--------------------------
Select EmpName, DeptName from empTable join DeptTable on Emptable.DeptId = DeptTable.DeptId

--This is called as Equi-join that allows to get the common data from both the tables on the matching condition. 

--Left Joins that get all the records from the left table and matching records from the right table. 
Select Emptable.*, DeptTable.DeptName from Emptable LEFT JOIN DeptTable on Emptable.DeptId = DeptTable.DeptId

Update Emptable set deptId = NULL where DeptId = 4
--Right Join is the opposite of the left join. 

Select Emptable.*, DeptTable.DeptName from Emptable RIGHT JOIN DeptTable on Emptable.DeptId = DeptTable.DeptId

------------group by----
--I want all the employees grouped by cities

Select EmpAddress, Count(EmpName) as Employees 
from Emptable group by empAddress order by empAddress desc
--Get the EmpNames grouped by City. 

Select EmpName, EmpAddress  from emptable group by empName, empAddress order by empAddress. 

--Distribution of salaries in each city.Get the count of employees in each city and the avg salary in each city using group by clause. 
Select Count(EmpName) as EmpCount, Avg(EmpSalary) as AvgSalary, EmpAddress from emptable
group by empAddress order by EmpCount
--When used in a group by clause, the expression must be either a part of the group by or should be scalar function(Aggregate Functions)



