--Triggers are events that are automatically initiated when an action like insert, delete or update happens to an object within the database. Triggers happen only when U have a DML operation within the object.
--For auditing purpose,a table has been created to make an entry on the Customer when he/she is added/ updated or removed from the Customer table. 
Create table CstTable
(
 CstId int primary key identity(1,1),
 CstName varchar(50) NOT NULL, 
 CstAddress varchar(50) NOT NULL, 
 BillDate Date Default GETDATE(),
 BillAmount money
)

Create table Customer_Audit
(
	id int primary key identity(1,1),
	details varchar(200) NOT NULL
)

--Insertion Trigger
ALTER trigger OnInsertCustomer
ON CstTable
FOR INSERT
AS
BEGIN
DECLARE @id int
Select @id = CstId from inserted
DECLARE @name varchar(50)
Select @name = CstName from inserted
Insert into Customer_Audit values('Customer with Id ' + CAST(@id as varchar) + ' and name ' + @name + ' is inserted into the Datebase on ' + CAST(GETDATE() as varchar(50)))
END

Insert into CstTable(CstName, CstAddress, BillAmount) values('John', 'New york', '4000') 


Select * from Customer_Audit
Select * from CstTable

Create trigger OnUpdateCustomer
ON CSTTABLE
AFTER UPDATE
AS
BEGIN
DECLARE @id int
DECLARE @oldName varchar(50)
DECLARE @newName varchar(50)
Select @id = CstId from inserted
Select @oldName = CstName from deleted
Select @newName = CstName from inserted
Insert into Customer_Audit Values('The Customer with Id ' + CAST(@id as VARCHAR(5)) + ' has been updated with ' + @newName + ' and his old name ' + @oldName + ' has been removed on ' + CAST(GETDATE() as varchar))
END

Update CstTable
Set CstName = 'John Adams' Where CstId = 3 

--ToDO: Create a delete trigger to audit the cstTable when a customer is removed from the database


Select * from Customer_Audit Where details like '%updated%'