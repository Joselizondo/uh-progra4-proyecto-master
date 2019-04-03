Public MustInherit Class ServicioBase
    Protected conexion As IConexionDatos

    Protected Sub New(ByRef conexionDatos As IConexionDatos)
        conexion = conexionDatos
    End Sub
End Class
