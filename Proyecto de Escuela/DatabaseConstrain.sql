--create database SchoolDB

-- Escuela se relacionara con Sector (invivienda, almarosa, hainamosa).

-- EL sector se relacionara con Continentes
-- El continente se relacionara con paises
-- El pais se relacionara con Ciudad

-- La escuela se relacion con su personal, profesores, estudiantes, Aulas

-- El personal se relacion con Puestos

--El aula se relaciona con la Seccion

-- La seccion con la materia

-- Estudiantes se relaciona con materia

-- El profesor se relaciona con materia

--Escuela
--Sector
--Continente
--Paises
--Ciudad
--Personal
--Puestos
--Profesores
--Estudiantes
--Aulas
--Materias
--Seccion
--Carreras

use SchoolDB
go

create table Continentes
(
	Continente_ID varchar(20) primary key,
	Nombre_Continente varchar(50)
)
create table Paises
(
	Pais_ID varchar(20) primary key,
	Nombre_Pais varchar(50),
	Continente_ID varchar(20)

	foreign key(Continente_ID) references Continentes(Continente_ID)
)
create table Ciudad
(
	Ciudad_ID varchar(20) primary key,
	Nombre_Ciudad varchar(50),
	Pais_ID varchar(20),

	foreign key(Pais_ID) references Paises(Pais_ID)
)
create table Sector
(
	Sector_ID int primary key identity(10,5),

	Nombre_Sector varchar(50),
	Ciudad_ID varchar(20),

	foreign key(Ciudad_ID) references Ciudad(Ciudad_ID)
)
Create table Puestos
(
	Puesto_ID varchar(20) primary key,
	Nombre_Puesto varchar(20),
	Salario_Max int,
	Salario_Min int
)

create table Personal
(
	Personal_ID int primary key identity(100111, 1),

	Nombre varchar(25),
	Apellido varchar(30),
	Sueldo int,
	Fecha_Contrato datetime,
	Puesto_ID varchar(20),

	Foreign key(Puesto_ID) references Puestos(Puesto_ID)
)

Create table Profesores
(
	Profesor_ID int primary key identity(200111, 1),
	Nombre varchar(25),
	Apellido varchar(30),
	Sueldo int,
	Fecha_Contrato datetime,

)
create table Estudiante
(
	Estudiante_ID int primary key identity(000101, 1),
	Nombre varchar(25),
	Apellido varchar(20),
	Fecha_Ingreso datetime,
	Carrera_ID varchar(10)
)

create table Materias
(
	Materia_ID varchar(10) primary key,
	Titulo_Materia varchar(50),
	Credito int,
	Carrera_ID varchar(10)
)
create table Carreras
(
	Carrera_ID varchar(10) primary key,
	Nombre_Carrera varchar(25),
	Materia_ID varchar(10)

)
create table Escuela
(
	Distrito int identity(100, 10) primary key,

	Nombre_Escuela varchar(50),
	Cantidad_Aulas int,

	Sector_ID int,

	foreign key(Sector_ID) references Sector(Sector_ID),
)
create table Miembros
(
	Personal_ID int,
	Profesor_ID int,
	Estudiante_ID int,
	Distrito_ID int,

	foreign key(Distrito_ID) references Escuela(Distrito)
)
create table Aulas
(
	Aula_ID int primary key identity(1,1),

	Capacidad_Est int,
	Distrito int,

	foreign key(Distrito) references Escuela(Distrito)
)
create table Seccion
(
	Seccion_ID int primary key identity(1001, 1),
	Profesor_ID int,
	Estudiante_ID int,
	Aula_ID int,
	Materia_ID varchar(10)

	foreign key(Profesor_ID) references Profesores(Profesor_ID),
	foreign key(Estudiante_ID) references Estudiante(Estudiante_ID),
	foreign key(Aula_ID) references Aulas(Aula_ID),
	foreign key(Materia_ID) references Materias(Materia_ID)
)