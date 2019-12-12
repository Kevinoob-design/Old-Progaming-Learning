--Store Procedure

use master
go

create database LearningSP

use LearningSP
go

alter proc spFirstTry

	@Nombre nvarchar(max),
	@Edad int
	--@OutPut int out
	with encryption

AS

Begin
	if exists(select * from TableName)
	begin
		drop table TableName
		print '@Table has been removed'
	end
	create table TableName
	(
		Nombre varchar(max),
		Edad int
		
	)
	insert into TableName(Nombre, Edad) values (@Nombre, @Edad)

	--select @OutPut = count(*) from TableName
	return (select count(*) from TableName)
End

declare @ExpectedOut int
exec spFirstTry 'Hector', 24, @OutPut = @ExpectedOut out
print @ExpectedOut

declare @ExpectedReturn int
exec @ExpectedReturn = spFirstTry 'Hector', 24
print @ExpectedReturn

sp_helptext spFirstTry