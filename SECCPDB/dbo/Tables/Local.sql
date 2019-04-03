create table Local(
	id_local int identity(1,1) not null primary key,
	nombre_local varchar(200) not null,
	ciudad_local varchar(50) not null,
	estado_local varchar(50) not null,
	pais_local varchar(50) not null,
);