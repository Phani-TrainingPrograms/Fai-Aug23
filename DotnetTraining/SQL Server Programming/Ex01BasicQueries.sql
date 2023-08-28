--SQL Server is a Database server provided by MS for developing backend databases for our Applications.
--SQL server is available in 2 editions: Professional or EXPRESS Edition. Express edition will have free version with all the infrastructure required. 
-- Once SQL server is installed, U can connect with the server using an IDE called SSMS(SQL server Management Studio). The SSMS is an IDE for interacting with SQL server database. 
--SQL Server database is available only on Windows OS. However, U can install the server in docker on other platforms. 
--Connecting to the SQL server can be in 2 ways: Windows Authentication or SQL server authentication. We use SQL server authentication if we have multiple users in the same Database server. 
-- A DB server can have multiple users and multiple databases in it.
--Databases in the Server can be created either using the GUI Features of SSMS or using a language called T-SQL(Transact-SQL). 
--SQL statements are written on any text editor and saved with extension .sql.
-- SQL Database can also be configured inside MS Visual Studio. But it is not that featured as SSMS.
-- SQL Server gives a set of predefined functions and procedures to get information about the server, database and other objects of the database. The objects of the database include Tables, Stored Procedures, Functions, Triggers, Indexes and many more. 
--To create the database, we use create command. But to create new Database, U should start from the Master db which is the main database for managing the databases of the server. 
----------------Creating and Deleting databases in SQL Server---------
create database SampleDB
use SampleDB
use master
Drop database SampleDB
--To see the list of the databases in UR server: sp_databases
sp_databases -- Its a stored proc to get all the databases of the Server. 
--------------------Adding Tables to the SQL server-----------------
create table Emptable
(
	empId int primary key identity(1000, 1),
	empName nvarchar(50) NOT NULL, 
	empAddress nvarchar(200) NOT NULL, 
	empSalary money NOT NULL
)

Insert into Emptable values('Phaniraj', 'Bangalore', 56000)

Select EmpName, EMPADDRESS  from Emptable
Select * from Emptable

sp_tables --gives the tables of the selected database
sp_columns EmpTable --gives the schema info of the selected table in the database. 

--Create a table called DeptTable which has 2 columns: DeptId, DeptName with DeptID as primary autogenerating column

Create table DeptTable
(
DeptId int primary key identity(1,1),
DeptName nvarchar(50) NOT NULL
)

--Add a new column to the existing table...
Alter table EmpTable
Add DeptId int null 
REFERENCES DeptTable(DeptId)

Insert into DeptTable values('Development')
Insert into DeptTable values('Admin')
Insert into DeptTable values('Sales')
Insert into DeptTable values('AfterSales')

Insert into Emptable values('Banu Prakash','Mysore', 40000, 2)
Insert into Emptable values('Vinod Kumar','Shimoga', 44000, 1)
Insert into Emptable values('Ramesh','Mangalore', 35000, 1)
Insert into Emptable values('Sowjanya','Hubli', 33000, 3)
Insert into Emptable values('Sireesha','Chennai', 66000, 1)

