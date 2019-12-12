--Triggers

--There are 3 tipes of Triggers: DML, DDL, Logon Trigger.

--The DML triggers are use to respond to DML Querys. 
--Afer trigger (FORtrigger) will be fire after the triggering action.
--Instead of triggers.

use master
go

Create database Triggerss

use Triggerss
go

CREATE TABLE tblEmployee
(
  Id int Primary Key,
  Name nvarchar(30),
  Salary int,
  Gender nvarchar(10),
  DepartmentId int
)

Insert into tblEmployee values (1,'John', 5000, 'Male', 3)
Insert into tblEmployee values (2,'Mike', 3400, 'Male', 2)
Insert into tblEmployee values (3,'Pam', 6000, 'Female', 1) 

CREATE TABLE tblEmployeeAudit
(
  Id int identity(1,1) primary key,
  AuditData nvarchar(1000)
)

alter TRIGGER tr_tblEMployee_ForInsert
ON tblEmployee
FOR Insert, Delete, Update
AS
BEGIN
 Declare @NewId int
 Select @NewId = Id from inserted
 
 insert into tblEmployeeAudit 
 values('New employee with Id  = ' + Cast(@NewId as nvarchar(5)) + ' is added at ' + cast(Getdate() as nvarchar(20)))
END

BEGIN
 Declare @DelId int
 Select @DelId = Id from deleted
 
 insert into tblEmployeeAudit 
 values('Old employee with Id  = ' + Cast(@DelId as nvarchar(5)) + ' was deleted at ' + cast(Getdate() as nvarchar(20)))
END

BEGIN
      -- Declare variables to hold old and updated data
      Declare @Id int
      Declare @OldName nvarchar(20), @NewName nvarchar(20)
      Declare @OldSalary int, @NewSalary int
      Declare @OldGender nvarchar(20), @NewGender nvarchar(20)
      Declare @OldDeptId int, @NewDeptId int
     
      -- Variable to build the audit string
      Declare @AuditString nvarchar(1000)
      
      -- Load the updated records into temporary table
      Select *
      into #TempTable
      from inserted
     
      -- Loop thru the records in temp table
      While(Exists(Select Id from #TempTable))
      Begin
            --Initialize the audit string to empty string
            Set @AuditString = ''
           
            -- Select first row data from temp table
            Select Top 1 @Id = Id, @NewName = Name, 
            @NewGender = Gender, @NewSalary = Salary,
            @NewDeptId = DepartmentId
            from #TempTable
           
            -- Select the corresponding row from deleted table
            Select @OldName = Name, @OldGender = Gender, 
            @OldSalary = Salary, @OldDeptId = DepartmentId
            from deleted where Id = @Id
   
     -- Build the audit string dynamically           
            Set @AuditString = 'Employee with Id = ' + Cast(@Id as nvarchar(4)) + ' changed'
            if(@OldName <> @NewName)
                  Set @AuditString = @AuditString + ' NAME from ' + @OldName + ' to ' + @NewName
                 
            if(@OldGender <> @NewGender)
                  Set @AuditString = @AuditString + ' GENDER from ' + @OldGender + ' to ' + @NewGender
                 
            if(@OldSalary <> @NewSalary)
                  Set @AuditString = @AuditString + ' SALARY from ' + Cast(@OldSalary as nvarchar(10))+ ' to ' + Cast(@NewSalary as nvarchar(10))
                  
     if(@OldDeptId <> @NewDeptId)
                  Set @AuditString = @AuditString + ' DepartmentId from ' + Cast(@OldDeptId as nvarchar(10))+ ' to ' + Cast(@NewDeptId as nvarchar(10))
           
            insert into tblEmployeeAudit values(@AuditString)
            
            -- Delete the row from temp table, so we can move to the next row
            Delete from #TempTable where Id = @Id
      End
End

Insert into tblEmployee values (4,'Hector', 6000, 'Boy', 0) 

select * from tblEmployeeAudit 
select * from tblEmployee

update tblEmployee set [Name] = 'Junior' where [Name] like 'Hector'
delete from tblEmployee where [Name] like 'Hector'
delete from tblEmployee where [Name] like 'Junior'
delete from tblEmployeeAudit where AuditData is null