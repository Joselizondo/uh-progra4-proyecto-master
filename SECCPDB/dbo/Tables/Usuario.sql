create table Usuario(
	num_cedula int not null primary key,
	contrasena varchar(200),

	FOREIGN KEY (num_cedula) REFERENCES Persona(num_cedula),

);