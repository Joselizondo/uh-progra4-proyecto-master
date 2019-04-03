create table UsuarioTipoUsuario(
	id_usuario int not null,
	id_TipoUsuario int not null,

	FOREIGN KEY (id_usuario) REFERENCES Usuario(num_cedula),
	FOREIGN KEY (id_TipoUsuario) REFERENCES TipoUsuario(id_TipoUsuario)
);