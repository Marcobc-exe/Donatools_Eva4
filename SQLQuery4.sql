CREATE TABLE tipo(
	id_tipo int primary key identity,
	tipo_donacion varchar(30) not null
);

CREATE TABLE genero(
	id_genero int primary key identity,
	genero varchar(30) NOT NULL
);

CREATE TABLE persona (
	id_persona int primary key identity,
	rut varchar(10) NOT NULL,
	nombre varchar(25) NOT NULL,
	apellido varchar(25) NOT NULL,
	edad int NOT NULL,
	genero int NOT NULL,
	constraint FK_genero foreign key (genero) references genero(id_genero) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE usuario (
	id_usuario int primary key identity,
	username varchar(50) NOT NULL,
	usuario_ref int NOT NULL,
	mail varchar(50) NOT NULL,
	telefono int NOT NULL,
	password varchar(50) NOT NULL,
	constraint FK_usuarioref foreign key (usuario_ref) references persona(id_persona) ON DELETE CASCADE ON UPDATE CASCADE,
	
);

CREATE TABLE donacion(
	id_donacion int primary key identity,
	nomb_donacion varchar(50) NOT NULL,
	descripcion varchar(100) NOT NULL,
	fecha_publicacion date NOT NULL,
	fecha_limite date NOT NULL,
	publico int DEFAULT 1,
	tipo int NOT NULL,
	usuario int NOT NULL,
	constraint FK_tipoDonacion foreign key (tipo) references tipo(id_tipo) ON DELETE CASCADE ON UPDATE CASCADE,
	constraint FK_usuario foreign key (usuario) references usuario(id_usuario) ON DELETE CASCADE ON UPDATE CASCADE
);