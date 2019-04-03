Imports SECCP_B

Friend Class FabricaRepositorios
    Friend Shared Function ObtenerRepoProfesiones(ByRef conexionDatos As IConexionDatos) As IRepositorioProfesiones
        Return New RepositorioProfesiones(conexionDatos)
    End Function

    Friend Shared Function ObtenerRepoPersonas(conexion As IConexionDatos) As IRepositorio(Of Persona, Integer)
        Return New RepositorioPersona(conexion)
    End Function
End Class
