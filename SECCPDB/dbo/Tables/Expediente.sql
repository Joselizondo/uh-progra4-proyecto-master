create table Expediente(
	id_expediente varchar(50) not null primary key,
	id_persona int not null,

	FOREIGN KEY (id_persona) REFERENCES Persona(num_cedula)
);