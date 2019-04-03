create table Cita(
	id_cita int identity(1,1) not null,
	id_paciente int not null,
	id_doctor int not null,
	fechaCita date not null,
	HoraAtencion varchar(10) not null,
	cie text,
	cif text,
	causa text,
	id_local int not null,
	id_TipoCita int not null,
	id_expediente varchar(50),

	FOREIGN KEY (id_paciente) REFERENCES Persona(num_cedula),
	FOREIGN KEY (id_doctor) REFERENCES Usuario(num_cedula),
	FOREIGN KEY (id_local) REFERENCES Local(id_local),
	FOREIGN KEY (id_TipoCita) REFERENCES TipoCita(id_TipoCita),
	FOREIGN KEY (id_expediente) REFERENCES Expediente(id_expediente)	
);