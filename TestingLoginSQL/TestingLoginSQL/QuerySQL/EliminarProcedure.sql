use LoginWebsite
go

create proc EliminarDatos

	@ID int
AS

delete from Validacion
where ID = @ID