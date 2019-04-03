create table Diagnostico(
	id_Diagnostico int identity(1,1) not null primary key,
	nombre_Diagnostico varchar(100) not null,
	descripcion_diagnostico text
);