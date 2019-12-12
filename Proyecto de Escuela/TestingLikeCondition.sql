use master
go

use TestCheck
go

create database TestCheck

create table Test
(
	dato varchar(max)
)

create table Estudiante
(
	Estudiante_ID int constraint PK_Estudiante_ID primary key identity(5,100),

	Matricula varchar(9) constraint Matricula_Rule unique check(len(Matricula) = 9 and Matricula like '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]' 
	and Matricula like concat('%', datepart(year, Getdate()), '%') and Matricula like concat('%', format(Getdate(), 'dd'), '%')) 
	
	not null
	default concat( datepart(Year, Getdate()), '-', format(getdate(), 'dd'), CONVERT(int, rand()*(99-10) )),

	Nombre varchar(max),
	Apellido varchar(max),
	Fecha_Ingreso datetime not null Default Getdate(),
	Carrera_ID varchar(4) constraint FK_Carrera_ID check(len(Carrera_ID) = 4 and Carrera_ID not like '%[0-9]%')
)

create table Estudiante2
(
	Matricula varchar(9) constraint Matricula_Rule2 unique check(len(Matricula) = 9 and 
	
	Matricula like concat(datepart(year, Getdate()),'-', format(Getdate(), 'dd', '__')) )

	not null
	default concat( datepart(Year, Getdate()), '-', format(getdate(), 'dd'), CONVERT(int, rand()*(99-10) ))
)


insert into Test (dato)
values(concat( datepart(Year, Getdate()), '-', datepart(day, Getdate()), datepart(hour, Getdate()) ))

insert into Test (dato)
values(concat( datepart(Year, Getdate()), '-', format(Getdate(), 'dd'), CONVERT(int, rand()*(99-10) )))

select format(getdate(), 'dd')
select datepart(SECOND, Getdate())
select format(GETDATE(), 'yyy')

select DATEPART(year, Fecha_Ingreso) from Estudiante

select * from Estudiante where Matricula like concat('%', datepart(year, Getdate()), '%') and Matricula like concat('%', format(Getdate(), 'dd'), '%')

select * from Estudiante where Matricula like Matricula

select * from Test where dato like concat('%', datepart(year, Getdate()), '%') and dato like concat('%', format(Getdate(), 'dd'), '%')

select * from Test where len(dato) = 9

insert into Test (dato)
values(concat( CONVERT(int, rand()*(999-100) ), '-', CONVERT(int, rand()*(999-100) )))