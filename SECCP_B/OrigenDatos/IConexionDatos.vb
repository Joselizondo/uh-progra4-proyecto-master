Public Interface IConexionDatos
    Sub Conectar()
    Sub Desconectar()
    Sub Ejecutar(ByVal criterios As String)
    Sub LLenarTabla(ByRef tabla As DataSet, ByVal criterios As String)
End Interface
