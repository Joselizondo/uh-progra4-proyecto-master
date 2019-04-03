create database uh_program4_stagging_1;

go
use uh_program4_stagging_1;

go
create table TipoUsuario(
	id_TipoUsuario int identity(1,1) not null primary key,
	nombre_TipoUsuario varchar(200) not null	
);

create table RolUsuario(
	id_RolUsuario int identity(1,1) not null primary key,
	nombre_RolUsuario varchar(100) not null
);

create table Diagnostico(
	id_Diagnostico int identity(1,1) not null primary key,
	nombre_Diagnostico varchar(100) not null,
	descripcion_diagnostico text
);

create table EstadoCivil(
	id_EstadoCivil int identity(1,1) not null primary key,
	nombre_estadoCivil varchar(100) not null
);

create table Escolaridad(
	id_Escolaridad int identity(1,1) not null primary key,
	nombre_Escolaridad varchar(100) not null
);

create table Profesion(
	id_Profesion int identity(1,1) not null primary key,
	nombre_Profesion varchar(100) not null
);

create table Pais(
	id_pais int identity(1,1) not null primary key,
	nombre_pais varchar(150) not null
);

create table Estado(
	id_Estado int identity(1,1) not null primary key,
	nombre_Estado varchar(100) not null,
	id_pais int not null,

	FOREIGN KEY (id_pais) REFERENCES Pais(id_pais)
);

create table Ciudad(
	id_Ciudad int identity(1,1) not null primary key,
	nombre_Ciudad varchar(100) not null,
	id_Estado int not null,

	FOREIGN KEY (id_Estado) REFERENCES Estado(id_Estado)
);

create table Especialidad(
	id_Especialidad int identity(1,1) not null primary key,
	nombre_Especialidad varchar(100) not null
);

create table TipoCita(
	id_TipoCita int identity(1,1) not null primary key,
	nombre_TipoCita varchar(100) not null
);

create table Local(
	id_local int identity(1,1) not null primary key,
	nombre_local varchar(200) not null,
	id_ciudad int not null,

	FOREIGN KEY (id_ciudad) REFERENCES Ciudad(id_Ciudad)
);

create table HoraAtencion(
	id_HoraAtencion int identity(1,1) not null primary key,
	nombre_HoraAtencion varchar(10) not null
)

create table Persona(
	num_cedula int not null primary key,
	primer_nombre varchar(70) not null,
	segundo_nombre varchar(70),
	primer_apellido varchar(70) not null,
	segundo_apellido varchar(70),
	fecha_nacimiento date not null,
	genero char(3) not null,
	correo_electronico varchar(100),
	telefono_celular varchar(8),
	telefono_fijo varchar(8),
	direccion text not null,
	id_ciudad int not null,
	abortos tinyint,
	vivos tinyint,
	fallecidos tinyint,
	prematuros tinyint,
	num_hermanos tinyint,
	id_pais int not null,
	id_EstadoCivil int not null,
	id_Escolaridad int not null,
	id_Profesion int not null,

	FOREIGN KEY (id_ciudad) REFERENCES Ciudad(id_Ciudad),
	FOREIGN KEY (id_pais) REFERENCES Pais(id_pais),
	FOREIGN KEY (id_EstadoCivil) REFERENCES EstadoCivil(id_EstadoCivil),
	FOREIGN KEY (id_Escolaridad) REFERENCES Escolaridad(id_Escolaridad),
	FOREIGN KEY (id_Profesion) REFERENCES Profesion(id_Profesion)
);

create table Usuario(
	num_cedula int not null primary key,
	contrasena varchar(200),

	FOREIGN KEY (num_cedula) REFERENCES Persona(num_cedula),

);

create table UsuarioTipoUsuario(
	id_usuario int not null,
	id_TipoUsuario int not null,

	FOREIGN KEY (id_usuario) REFERENCES Usuario(num_cedula),
	FOREIGN KEY (id_TipoUsuario) REFERENCES TipoUsuario(id_TipoUsuario)
);
create table EspecialidadDoctor(
	id_Especialidad int not null,
	id_usuario int not null,

	FOREIGN KEY (id_usuario) REFERENCES Usuario(num_cedula),
	FOREIGN KEY (id_Especialidad) REFERENCES Especialidad(id_Especialidad)
);
create table UsuarioRolUsuario(
	id_usuario int not null,
	id_RolUsuario int not null,

	FOREIGN KEY (id_usuario) REFERENCES Usuario(num_cedula),
	FOREIGN KEY (id_RolUsuario) REFERENCES RolUsuario(id_RolUsuario)	
);
create table Expediente(
	id_expediente varchar(50) not null primary key,
	id_persona int not null,

	FOREIGN KEY (id_persona) REFERENCES Persona(num_cedula)
);
create table Cita(
	id_cita int identity(1,1) not null,
	id_paciente int not null,
	id_doctor int not null,
	fechaCita date not null,
	id_HoraAtencion int not null,
	cie text,
	cif text,
	causa text,
	id_local int not null,
	id_TipoCita int not null,
	id_expediente varchar(50),

	FOREIGN KEY (id_paciente) REFERENCES Persona(num_cedula),
	FOREIGN KEY (id_doctor) REFERENCES Usuario(num_cedula),
	FOREIGN KEY (id_HoraAtencion) REFERENCES HoraAtencion(id_HoraAtencion),
	FOREIGN KEY (id_local) REFERENCES Local(id_local),
	FOREIGN KEY (id_TipoCita) REFERENCES TipoCita(id_TipoCita),
	FOREIGN KEY (id_expediente) REFERENCES Expediente(id_expediente)	
);
