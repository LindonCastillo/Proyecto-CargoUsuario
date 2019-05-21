create database RegistroCompleto
go

use RegistroCompleto
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