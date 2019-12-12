Use DataExamenFinal
go

Create proc EjecutarEliminar

	@Cedula int
	
AS

delete from DataTable
where Cedula = @Cedula