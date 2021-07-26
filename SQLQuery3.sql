drop table Donacion;
drop table Usuario;
drop table Genero;
drop table Tipo;


CREATE TABLE Tipo(
	id_tipo int primary key identity,
	tipo_donacion varchar(30) not null
);

CREATE TABLE Genero(
	id_genero int primary key identity,
	tipo_genero varchar(30) NOT NULL
);

CREATE TABLE Usuario (
	id_usuario int primary key identity,
	username varchar(50) NOT NULL unique,
	mail varchar(50) NOT NULL unique,
	telefono varchar(50) NOT NULL unique,
	password varchar(50) NOT NULL,
	rut varchar(20) NOT NULL unique,
	nombre varchar(25) NOT NULL,
	apellido varchar(25) NOT NULL,
	edad int NOT NULL,
	genero_fk int NOT NULL,
	constraint FK_genero foreign key (genero_fk) references Genero(id_genero) ON DELETE CASCADE ON UPDATE CASCADE,
);

CREATE TABLE Donacion(
	id_donacion int primary key identity,
	nomb_donacion varchar(50) NOT NULL,
	descripcion varchar(100) NOT NULL,
	fecha_publicacion date NOT NULL,
	fecha_limite date NOT NULL,
	publico int DEFAULT 1,
	tipo int NOT NULL,
	usuario_fk int NOT NULL,
	constraint FK_tipoDonacion foreign key (tipo) references Tipo(id_tipo) ON DELETE CASCADE ON UPDATE CASCADE,
	constraint FK_usuario foreign key (usuario_fk) references Usuario(id_usuario) ON DELETE CASCADE ON UPDATE CASCADE
);