use LoginWebsite
go

create table Validacion(

	ID int not null,
	Usuario varchar(50) not null,
	Pass int not null
)

alter table Validacion add User_Name varchar(50);

alter table Validacion drop column User_Name;

alter table Validacion alter column Usuario varchar(50) not null;	
alter table Validacion alter column Pass int not null;

ALTER TABLE Validacion
ADD PRIMARY KEY (Usuario);

ALTER TABLE Validacion
ADD CONSTRAINT PK_Primary PRIMARY KEY (Usuario);

alter table Validacion drop constraint PK_Validacion;

alter table Validacion drop column ID;
