Public Class ServicioEspecialidad
    Dim Ruta = "File name= " & Application.StartupPath & "\CONECTAR.UDL"
    Dim conx As New ConexionSQLServer(Ruta)

    Public Sub Registrar(ByVal nom As String)
        Dim T, T2 As New DataSet
        Dim SQL As String
        Dim ID As Integer

        SQL = "SELECT ID_ESPECIALIDAD FROM ESPECIALIDAD"

        conx.LLenarTabla(T, SQL)

        If T.Tables(0).Rows.Count = 0 Then
            ID = 1
        Else
            SQL = "SELECT MAX(ID_ESPECIALIDAD) FROM ESPECIALIDAD"
            conx.LLenarTabla(T2, SQL)
            ID = T2.Tables(0).Rows(0).Item(0) + 1

        End If

        SQL = "Insert into especialidad (nombre_Especialidad) values('" & nom & "')"

        conx.Ejecutar(SQL)
        MsgBox("Informacion Almacenada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Almacenado")
    End Sub

    Public Function Listar() As List(Of Especialidad)
        Dim T As New DataSet
        Dim SQL As String
        Dim i As Integer
        ' tabla temporal, se cambiara luego
        SQL = "SELECT * FROM ESPECIALIDAD"
        conx.LLenarTabla(T, SQL)

        Dim resultado As New List(Of Especialidad)()


        For i = 0 To T.Tables(0).Rows.Count - 1
            resultado.Add(New Especialidad With {.ID = T.Tables(0).Rows(i).Item(0),
                                  .Nombre = T.Tables(0).Rows(i).Item(1)})
        Next

        Return resultado
    End Function

    Public Function Buscar(ByVal nombreEsp As String)

        Dim T As New DataSet
        Dim SQL As String
        Dim i As Integer
        SQL = "SELECT * FROM ESPECIALIDAD WHERE NOMBRE_ESPECIALIDAD LIKE '" & nombreEsp & "%'"
        conx.LLenarTabla(T, SQL)
        Dim resultado As New List(Of Especialidad)()
        For i = 0 To T.Tables(0).Rows.Count - 1
            resultado.Add(New Especialidad With {.ID = T.Tables(0).Rows(i).Item(0),
                                  .Nombre = T.Tables(0).Rows(i).Item(1)})
        Next
        Return resultado
    End Function

    Public Function Seleccionar(ByVal id)
        Dim T As New DataSet
        Dim SQL As String
        SQL = " SELECT * FROM ESPECIALIDAD WHERE ID_ESPECIALIDAD = " & id & ";"
        conx.LLenarTabla(T, SQL)
        Dim resultado As New List(Of Especialidad)()
        For i = 0 To T.Tables(0).Rows.Count - 1
            resultado.Add(New Especialidad With {.ID = T.Tables(0).Rows(i).Item(0),
                                  .Nombre = T.Tables(0).Rows(i).Item(1)})

        Next


        Return resultado
    End Function

    Public Sub Actualizar(ByVal id As Integer, ByVal esp As String)
        Dim SQL As String
        SQL = " UPDATE ESPECIALIDAD SET NOMBRE_ESPECIALIDAD = '" & esp & "' WHERE ID_ESPECIALIDAD = " & id & ""
        conx.Ejecutar(SQL)
    End Sub

    Public Sub Eliminar(ByVal id As Integer)
        Dim SQL As String
        SQL = "DELETE FROM ESPECIALIDAD WHERE ID_ESPECIALIDAD =  " & id & ""
        conx.Ejecutar(SQL)
    End Sub


End Class
