--DDL Trigger

use master
go

create database DDLTrigger

use DDLTrigger
go

alter trigger CreatingDatabase
on Database
for Create_table, Alter_table, Drop_Table
AS
Begin
	Rollback
	print 'New table created'
End

create trigger CreatingDatabaseForAll
on all server
for Create_table, Alter_table, Drop_Table
AS
Begin
	Rollback
	print 'New something'
End

create table Test (Id int)
drop table Test

Disable trigger CreatingDatabase on database
Enable trigger CreatingDatabase on database

create trigger RenameTable
on Database
for Rename
AS
Begin
	Rollback
	print 'Your rename has been aplied'
End

sp_rename 'Test', 'NewTest'