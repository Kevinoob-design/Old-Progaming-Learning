use SchoolDB
go

select 

Escuela.Distrito, Escuela.Nombre_Escuela as 'Escuela',

Sector.Nombre_Sector as 'Sector', 
Ciudad.Nombre_Ciudad as 'Ciudad',
Paises.Nombre_Pais as 'Pais',
Continentes.Nombre_Continente as 'Continente',

Personal.Personal_ID as 'ID Empleado', Personal.Nombre, Personal.Apellido, 
Puestos.Nombre_Puesto as 'Puesto',
Personal.Sueldo, Personal.Fecha_Contrato as 'Fecha de contratacion',

Profesores.Profesor_ID as 'ID Empleado', Profesores.Nombre, Profesores.Apellido,
Seccion.Seccion_ID as 'Seccion',
Materias.Titulo_Materia as 'Materia',
Profesores.Sueldo, Profesores.Fecha_Contrato as 'Fecha de contratacion',

Estudiante.Estudiante_ID as 'Matricula', Estudiante.Nombre, Estudiante.Apellido,
Carreras.Carrera_ID as 'ID Carrera', Estudiante.Fecha_Ingreso, Seccion.Seccion_ID as 'Seccion',
Materias.Titulo_Materia as 'Materia', Materias.Credito,  Carreras.Nombre_Carrera 'Carrera',
Estudiante.Fecha_Ingreso as 'Fecha de ingreso',

Aulas.Aula_ID as 'Curso'

from Escuela

inner join Miembros on Miembros.Distrito_ID = Escuela.Distrito
inner join Sector on Escuela.Sector_ID = Sector.Sector_ID
inner join Ciudad on Ciudad.Ciudad_ID = Sector.Ciudad_ID
inner join Paises on Paises.Pais_ID = Ciudad.Pais_ID
inner join Continentes on Continentes.Continente_ID = Paises.Continente_ID

inner join Personal on Miembros.Personal_ID = Personal.Personal_ID
inner join Puestos on Puestos.Puesto_ID = Personal.Puesto_ID

inner join Profesores on Profesores.Profesor_ID = Miembros.Profesor_ID

inner join Seccion on Seccion.Profesor_ID = Profesores.Profesor_ID
inner join Estudiante on Seccion.Estudiante_ID = Estudiante.Estudiante_ID
inner join Materias on Seccion.Materia_ID = Materias.Materia_ID
inner join Carreras on Carreras.Carrera_ID = Materias.Carrera_ID
inner join Aulas on Seccion.Aula_ID = Aulas.Aula_ID