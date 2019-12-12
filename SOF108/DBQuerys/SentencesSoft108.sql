use SOF108
go
	
/* 

The LIKE operator is used in a WHERE clause to search for a specified pattern in a column.

There are two wildcards used in conjunction with the LIKE operator:

% - The percent sign represents zero, one, or multiple characters
_ - The underscore represents a single character

LIKE Operator	Description
WHERE CustomerName LIKE 'a%'	Finds any values that start with "a"
WHERE CustomerName LIKE '%a'	Finds any values that end with "a"
WHERE CustomerName LIKE '%or%'	Finds any values that have "or" in any position
WHERE CustomerName LIKE '_r%'	Finds any values that have "r" in the second position
WHERE CustomerName LIKE 'a_%_%'	Finds any values that start with "a" and are at least 3 characters in length
WHERE ContactName LIKE 'a%o'	Finds any values that start with "a" and ends with "o"

*/

select * from EMPLEADOS where NOMBRE like '%s_%_'

/*

(INNER) JOIN: Returns records that have matching values in both tables
LEFT (OUTER) JOIN: Return all records from the left table, and the matched records from the right table
RIGHT (OUTER) JOIN: Return all records from the right table, and the matched records from the left table
FULL (OUTER) JOIN: Return all records when there is a match in either left or right table

The SQL CROSS JOIN produces a result set which is the number of rows in the first table multiplied by the number of rows in the second table 
if no WHERE clause is used along with CROSS JOIN.
This kind of result is called as Cartesian Product.
If WHERE clause is used with CROSS JOIN, it functions like an INNER JOIN.
An alternative way of achieving the same result is to use column names separated by commas 
after SELECT and mentioning the table names involved, after a FROM clause.

*/

select * from EMPLEADOS join PUESTOS on EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO
select * from EMPLEADOS inner join PUESTOS on EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO

select * from EMPLEADOS left join PUESTOS on EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO
select * from EMPLEADOS left outer join PUESTOS on EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO


select * from EMPLEADOS right join PUESTOS on EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO
select * from EMPLEADOS right outer join PUESTOS on EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO

select * from EMPLEADOS full join PUESTOS on EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO
select * from EMPLEADOS full outer join PUESTOS on EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO 

select * from EMPLEADOS cross join PUESTOS

select * from PUESTOS cross join EMPLEADOS

select * from EMPLEADOS, PUESTOS where EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO --This is a Equi Join
--select * from EMPLEADOS natural join PUESTOS --This is a Natural Join

-- Desde aqui creamos la relacion de la tabla Empleados y sus derivados.

select 

EMPLEADOS.ID_EMPLEADO, EMPLEADOS.NOMBRE, EMPLEADOS.APELLIDO, EMPLEADOS.EMAIL, EMPLEADOS.NUMERO_TELEFONO, 
EMPLEADOS.FECHA_CONTRATO, EMPLEADOS.SALARIO,

DEPARTAMENTOS.NOMBRE_DEPARTAMENTO, 

PUESTOS.TITULO_PUESTO, 

LOCACIONES.DIRECCION, LOCACIONES.CIUDAD, LOCACIONES.PROVINCIA, LOCACIONES.CODIGO_POSTAL, 

PAISES.NOMBRE_PAIS,

REGIONES.NOMBRE_REGION

from EMPLEADOS 

inner join DEPARTAMENTOS on EMPLEADOS.ID_DEPARTAMENTO = DEPARTAMENTOS.ID_DEPARTAMENTO 
inner join PUESTOS on EMPLEADOS.ID_PUESTO = PUESTOS.ID_PUESTO
inner join LOCACIONES on DEPARTAMENTOS.ID_LOCACION = LOCACIONES.ID_LOCACION
inner join PAISES on LOCACIONES.ID_PAIS = PAISES.ID_PAIS
inner join REGIONES on PAISES.ID_REGION = REGIONES.ID_REGION

-- Desde aqui empezamos a crear la relacion de la tabla Historico.

select 
EMPLEADOS.ID_EMPLEADO, EMPLEADOS.NOMBRE, EMPLEADOS.APELLIDO, EMPLEADOS.EMAIL, EMPLEADOS.NUMERO_TELEFONO, 
EMPLEADOS.FECHA_CONTRATO, EMPLEADOS.SALARIO,

DEPARTAMENTOS.NOMBRE_DEPARTAMENTO,

PUESTOS.TITULO_PUESTO,

HISTORICO.FECHA_INICIO, HISTORICO.FECHA_FIN

from HISTORICO

inner join EMPLEADOS on HISTORICO.ID_EMPLEADO = EMPLEADOS.ID_EMPLEADO
inner join DEPARTAMENTOS on HISTORICO.ID_DEPARTAMENTO = DEPARTAMENTOS.ID_DEPARTAMENTO
inner join PUESTOS on HISTORICO.ID_PUESTO = PUESTOS.ID_PUESTO

--execute SOF108.dbo.BringEmpleados
--select * from SOF108.dbo.EMPLEADOS
