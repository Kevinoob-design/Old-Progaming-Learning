alter table Estudiante add Carrera_ID varchar(10)

create table Miembros
(
	Personal_ID int,
	Profesor_ID int,
	Estudiante_ID int,
	Distrito_ID int,

	foreign key(Distrito_ID) references Escuela(Distrito)
)
