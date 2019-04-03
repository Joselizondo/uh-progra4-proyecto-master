Public Class ServicioRoles
    Public DB As New OleDb.OleDbConnection
    Friend Sub CONECTAR()
        Dim RUTA As String
        RUTA = "File name= " & Application.StartupPath & "\CONECTAR.UDL"
        DB.ConnectionString = RUTA
        DB.Open()
    End Sub
    Friend Sub DESCONECTAR()
        DB.Close()
    End Sub
    Friend Sub CARGAR_TABLA(ByRef T As DataSet, ByVal SQL As String)
        CONECTAR()
        Dim CONSULTA As New OleDb.OleDbDataAdapter(SQL, DB)
        CONSULTA.Fill(T)
        DESCONECTAR()

    End Sub

    Friend Sub EJECUTAR(ByVal SQL As String)
        CONECTAR()
        Dim COMANDO As New OleDb.OleDbCommand(SQL, DB)
        COMANDO.ExecuteNonQuery()
        DESCONECTAR()

    End Sub

    Public Function Listar() As List(Of Rol)
        Dim T As New DataSet
        Dim SQL As String
        Dim i As Integer
        ' tabla temporal, se cambiara luego
        SQL = "SELECT * FROM Roles"
        CARGAR_TABLA(T, Sql)

        Dim resultado As New List(Of Rol)()
        'El siguente código comentado es en caso que no se tenga una DB y se quieran simular datos para probar las funciones realizadas
        'resultado.Add((New Rol With {.Cedula = 234,
        '                          .Nombre = "Kevin",
        '                          .Apellidos = "Garro",
        '                          .Rol = "Loquesea"}))

        'resultado.Add((New Rol With {.Cedula = 12356,
        '                          .Nombre = "Domingo",
        '                          .Apellidos = "Mora",
        '                          .Rol = "Basico"}))

        For i = 0 To T.Tables(0).Rows.Count - 1
            resultado.Add(New Rol With {.Cedula = T.Tables(0).Rows(i).Item(0),
                                  .Nombre = T.Tables(0).Rows(i).Item(1),
                                  .Apellidos = T.Tables(0).Rows(i).Item(2),
                                  .Rol = T.Tables(0).Rows(i).Item(3)})
        Next

        Return resultado
    End Function
    Public Function Buscar(ByVal usuario As String)

        Dim T As New DataSet
        Dim SQL As String
        Dim i As Integer
        SQL = "SELECT * FROM Roles WHERE USUARIO LIKE '" & usuario & "%'" 'Esta linea se debe de cambiar por la tabla correcta que se vaya a usar en la DB oficial
        CARGAR_TABLA(T, SQL)
        Dim resultado As New List(Of Rol)()
        For i = 0 To T.Tables(0).Rows.Count - 1
            resultado.Add(New Rol With {.Cedula = T.Tables(0).Rows(i).Item(0),
                                  .Nombre = T.Tables(0).Rows(i).Item(1),
                                  .Apellidos = T.Tables(0).Rows(i).Item(2),
                                  .Rol = T.Tables(0).Rows(i).Item(3),
                                  .Usuario = T.Tables(0).Rows(i).Item(4)})

        Next


        Return resultado
    End Function
    Public Function Seleccionar(ByVal id)
        Dim T As New DataSet
        Dim SQL As String
        SQL = " SELECT * FROM Roles WHERE ID = " & id & " "
        CARGAR_TABLA(T, SQL)
        Dim resultado As New List(Of Rol)()
        For i = 0 To T.Tables(0).Rows.Count - 1
            resultado.Add(New Rol With {.Cedula = T.Tables(0).Rows(i).Item(0),
                                  .Nombre = T.Tables(0).Rows(i).Item(1),
                                  .Apellidos = T.Tables(0).Rows(i).Item(2),
                                  .Rol = T.Tables(0).Rows(i).Item(3),
                                  .Usuario = T.Tables(0).Rows(i).Item(4)})

        Next


        Return resultado
    End Function

    Public Sub Actualizar(ByVal cedula As Integer, ByVal rol As String)
        Dim SQL As String
        SQL = " UPDATE Roles SET Rol = '" & rol & "' where id = " & cedula & "" 'Esta linea se debe de cambiar por la tabla correcta que se vaya a usar en la DB oficial
        EJECUTAR(Sql)
    End Sub
End Class
