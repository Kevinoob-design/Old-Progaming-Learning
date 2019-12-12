use LoginWebsite
go

create proc EditarDatos
	@ID int,
	@Usuario varchar(50),
	@Pass int
AS

update Validacion
set Usuario = @Usuario, Pass = @Pass
where ID = @ID