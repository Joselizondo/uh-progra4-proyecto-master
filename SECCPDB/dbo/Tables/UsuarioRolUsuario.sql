create table UsuarioRolUsuario(
	id_usuario int not null,
	id_RolUsuario int not null,

	FOREIGN KEY (id_usuario) REFERENCES Usuario(num_cedula),
	FOREIGN KEY (id_RolUsuario) REFERENCES RolUsuario(id_RolUsuario)	
);