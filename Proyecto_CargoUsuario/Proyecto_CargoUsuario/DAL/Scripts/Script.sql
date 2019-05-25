create database CargoUsuarioDb
go

use CargoUsuarioDb
go

create table Usuarios
(
	UsuarioId int primary key identity, 
	Nombres varchar(50), 
	Email varchar(80), 
	NivelUsuario int, 
	Usuario varchar(50), 
	Clave varchar (50), 
	FechaIngreso datetime
)
go

create table Cargos
(
	CargoId int primary key identity,
	Descripcion varchar(120)
)
go

drop database CargoUsuarioDb
go


delete from Cargos

select * from Usuarios
select * from Cargos