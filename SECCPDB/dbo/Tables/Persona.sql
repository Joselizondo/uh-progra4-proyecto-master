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
	abortos tinyint,
	vivos tinyint,
	fallecidos tinyint,
	prematuros tinyint,
	num_hermanos tinyint,
	id_pais varchar(50) not null,
	id_EstadoCivil varchar(50) not null,
	id_Escolaridad varchar(50) not null,
	id_Profesion int not null,

	FOREIGN KEY (id_Profesion) REFERENCES Profesion(id_Profesion)
);