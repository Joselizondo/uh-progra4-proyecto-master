Public Class ConexionSQLServer
    Implements IConexionDatos

    Private conexion As OleDb.OleDbConnection

    Private listaErrores As List(Of String)
    Public Property Errores() As List(Of String)
        Get
            Return listaErrores
        End Get
        Private Set(ByVal value As List(Of String))
            listaErrores = value
        End Set
    End Property

    Public Sub New(conexionstring As String)
        conexion = New OleDb.OleDbConnection With {
            .ConnectionString = conexionstring
        }
        Errores = New List(Of String)
    End Sub

    Public Sub Conectar() Implements IConexionDatos.Conectar
        Try
            conexion.Open()
        Catch ex As Exception
            Errores.Add(ex.Message)
        End Try
    End Sub

    Public Sub Desconectar() Implements IConexionDatos.Desconectar
        conexion.Close()
    End Sub

    Public Sub Ejecutar(criterios As String) Implements IConexionDatos.Ejecutar
        Conectar()
        Dim ejecutor As New OleDb.OleDbCommand(criterios, conexion)
        Try
            ejecutor.ExecuteNonQuery()
        Catch ex As Exception
            Errores.Add(ex.Message)
        End Try
        Desconectar()
    End Sub

    Public Sub LLenarTabla(ByRef tabla As DataSet, criterios As String) Implements IConexionDatos.LLenarTabla
        Conectar()
        Dim adaptador As New OleDb.OleDbDataAdapter(criterios, conexion)
        Try
            adaptador.Fill(tabla)
        Catch ex As Exception
            Errores.Add(ex.Message)
            tabla.Clear()
            tabla.Tables.Add()
        End Try
        Desconectar()
    End Sub
End Class
