Use DataExamenFinal
go

Create proc EjecutarAgregar

	@Cedula int,
	@Nombre varchar(50),
	@Apellido varchar(50),
	@NumeroTell bigint
	
AS

insert into DataTable
(
	Cedula, Nombre, Apellido, NumeroTell
)
values
(
	@Cedula, @Nombre, @Apellido, @NumeroTell
)
