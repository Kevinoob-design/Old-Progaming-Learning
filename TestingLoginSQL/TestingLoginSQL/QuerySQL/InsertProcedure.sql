use LoginWebsite
go

create proc InsertarDatos

	@ID int,
	@Usuario varchar(50),
	@Pass int
AS

insert into Validacion(
	
	ID, Usuario, Pass
)
values(
	
	@ID, @Usuario, @Pass
)