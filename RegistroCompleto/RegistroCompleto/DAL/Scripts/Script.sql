create database RegistroCompleto_db
go

use RegistroCompleto_db
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

delete from Usuarios where x

select * from Usuarios