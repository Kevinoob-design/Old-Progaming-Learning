Use DataExamenFinal
go

Create proc EjecutarEditar

	@Cedula int,
	@Nombre varchar(50),
	@Apellido varchar(50),
	@NumeroTell bigint
	
AS

update DataTable
set

	Nombre = @Nombre, 
	Apellido = @Apellido, 
	NumeroTell = @NumeroTell

where Cedula = @Cedula