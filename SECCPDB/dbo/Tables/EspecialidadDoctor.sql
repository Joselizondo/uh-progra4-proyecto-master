create table EspecialidadDoctor(
	id_Especialidad int not null,
	id_usuario int not null,

	FOREIGN KEY (id_usuario) REFERENCES Usuario(num_cedula),
	FOREIGN KEY (id_Especialidad) REFERENCES Especialidad(id_Especialidad)
);