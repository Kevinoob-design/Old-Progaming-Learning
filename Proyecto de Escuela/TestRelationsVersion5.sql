--Example of a composite PK an Conjuction relation ship
use master
go

drop database TestManytoManyR
go

create database TestManytoManyR
go

use TestManytoManyR
go

create table Escuela
(
	Escuela_ID int constraint PK_Escuela_ID primary key identity(1,5),
	Distrito varchar(5) constraint Distrito_Rule unique check(len(Distrito) = 5 and Distrito like '%[0-9][0-9]-[0-9][0-9]%') not null,
	Nombre_Escuela varchar(max),
	Fecha_Apertura datetime not null Default Getdate()
)
create table Puestos
(
	Puesto_ID int constraint PK_Puesto_ID primary key identity(1,1),
	Codigo_Puesto varchar(4) constraint Codigo_Puesto_Rule unique check(len(Codigo_Puesto) = 4 and Codigo_Puesto not like '%[0-9]%') not null,
	Nombre_Puesto varchar(max),
	Descripcion_Puesto varchar(max) not null
)



--create table PersonalAdministrativo
--(
--	Personal_Administrativo_ID int constraint PK_Personal_Administrativo_ID primary key identity(5,200),
--	No_Empleado_ID varchar(7) constraint Empleado_ID_Rule unique check(len(No_Empleado_ID) = 7 and No_Empleado_ID like '%[0-9][0-9][0-9]-[0-9][0-9][0-9]%') not null,
--	Nombre varchar(max),
--	Apellido varchar(max),
--	Fecha_Ingreso datetime not null Default Getdate(),
--	Codigo_Puesto varchar(3) constraint FK_Codigo_Puesto references Puestos(Codigo_Puesto) not null
--) 
--create table PersonalEducativo
--(
--	Personal_ID int constraint PK_Profesor_ID primary key identity(5, 300),
--	No_Empleado_ID varchar(7) constraint Empleado_ID_Rule2 unique check(len(No_Empleado_ID) = 7 and No_Empleado_ID like '%[0-9][0-9][0-9]-[0-9][0-9][0-9]%') not null,
--	Nombre varchar(max),
--	Apellido varchar(max),
--	Fecha_Ingreso datetime not null Default Getdate(), 
--	Codigo_Puesto varchar(3) constraint FK_Codigo_Puesto2 references Puestos(Codigo_Puesto) not null
--)
create table Personal
(
	--Puesto_ID int references Puestos(Puesto_ID),
	--Personal_Educativo_ID int references PersonalEducativo(Personal_Educativo_ID), 
	--Personal_Administrativo_ID int references PersonalAdministrativo(Personal_Administrativo_ID),

	--constraint PK_Personal_Administrativo_ID_Personal_Educativo_ID primary key(Personal_Educativo_ID, Personal_Administrativo_ID),

	--Personal_ID int constraint PK_Personal_ID identity(5, 300) unique not null,
	Escuela_ID int constraint FK_Personal_Escuela_ID foreign key references Escuela(Escuela_ID),

	No_Empleado_ID varchar(7) constraint Empleado_ID_Rule2 unique check(len(No_Empleado_ID) = 7 and No_Empleado_ID like '%[0-9][0-9][0-9]-[0-9][0-9][0-9]%') not null,

	constraint Composite_PK_Personal_ID_Ecuela_ID primary key(No_Empleado_ID, Escuela_ID),

	Nombre varchar(max) not null,
	Nombre_Sec varchar(max),
	Apellido varchar(max) not null,
	Apellido_Materno varchar(max),
	Fecha_Ingreso datetime not null Default Getdate(), 
	Numero_Contacto varchar(11),
	Codigo_Puesto varchar(4) constraint FK_Codigo_Puesto2 references Puestos(Codigo_Puesto) not null
)



create table Estudiante
(
	--Estudiante_ID int constraint PK_Estudiante_ID identity(5,100) not null,
	Escuela_ID int constraint FK_Estudiante_Escuela_ID foreign key references Escuela(Escuela_ID),

	Matricula varchar(9) constraint Matricula_Rule unique check(len(Matricula) = 9 and Matricula like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]' 
	and Matricula like concat('%', datepart(year, Getdate()), '%') and Matricula like concat('%', format(Getdate(), 'dd'), '%')) 
	
	not null
	default concat( datepart(Year, Getdate()), '-', format(getdate(), 'dd'), CONVERT(int, rand()*(99-10) )),

	constraint Composite_PK_Matricula_Ecuela_ID primary key(Matricula, Escuela_ID),

	Nombre varchar(max) not null,
	Nombre_Sec varchar(max),
	Apellido varchar(max) not null,
	Apellido_Materno varchar(max),
	Fecha_Ingreso datetime not null Default Getdate(), 
	Numero_Contacto varchar(11),
	Carrera_ID varchar(4) constraint FK_Carrera_ID check(len(Carrera_ID) = 4 and Carrera_ID not like '%[0-9]%')
)

--create table Miembros
--(	
--	Escuela_ID int references Escuela(Escuela_ID),
--	Matricula varchar(9), --references Estudiante(Matricula, Escuela_ID),
--	No_Empleado_ID varchar(7), --references Personal(No_Empleado_ID, Escuela_ID),

--	constraint FK_Escuela_ID_Estudiante_ID foreign key (Matricula, Escuela_ID) references Estudiante(Matricula, Escuela_ID),
--	constraint FK_Personal_ID_Estudiante_ID foreign key(No_Empleado_ID, Escuela_ID) references Personal(No_Empleado_ID, Escuela_ID),

--	--constraint FK_Puesto_ID_Personal_Educativo_ID_Personal_Administrativo_ID foreign key (Personal_Educativo_ID, Personal_Administrativo_ID)
--	--references Personal(Personal_Educativo_ID, Personal_Administrativo_ID),

--	--constraint PK_EscuelaID_PersonalID_EstudianteID primary key (Escuela_ID, Estudiante_ID, Personal_ID)
--)















--From here i will enter the data for testing
