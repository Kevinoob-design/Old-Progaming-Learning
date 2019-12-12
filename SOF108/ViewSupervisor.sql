create view Supervisores AS
select ID_EMPLEADO, NOMBRE, APELLIDO from EMPLEADOS
where ID_EMPLEADO in (select ID_SUPERVISOR from EMPLEADOS)

select * from Supervisores