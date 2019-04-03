Imports SECCP_B

<TestClass()> Public Class IConexionDatosTest
    Class TestConexionDatos
        Implements IConexionDatos

        Private conectado As Boolean = False
        Private comando As String = ""

        Public Property UltimoComando() As String
            Get
                Return comando
            End Get
            Private Set(ByVal value As String)
                comando = value
            End Set
        End Property

        Public Sub Conectar() Implements IConexionDatos.Conectar
            Console.WriteLine("Conectando")
            conectado = True
        End Sub

        Public Sub Desconectar() Implements IConexionDatos.Desconectar
            Console.WriteLine("Desconectando")
            comando = ""
            conectado = False
        End Sub

        Public Sub Ejecutar(criterios As String) Implements IConexionDatos.Ejecutar
            Console.WriteLine("Ejecutando")
            If conectado = False Then
                comando = ""
            Else
                comando = criterios
            End If
        End Sub

        Public Sub LLenar(ByRef setTablas As DataSet, criterios As String) Implements IConexionDatos.LLenarTabla
            If conectado = False Then
                Return
            End If
            Dim tabla As DataTable = New DataTable("tabla1")
            tabla.Columns.Add("ID", GetType(Integer))
            tabla.Columns.Add("NOMBRE", GetType(String))
            tabla.Columns.Add("APELLIDO", GetType(String))
            tabla.Columns.Add("MODIFICADO", GetType(DateTime))

            tabla.Rows.Add(1, "Fulano", "DeTal", DateTime.Now)
            tabla.Rows.Add(2, "Zutano", "DeTal", DateTime.Parse("2018-02-02 12:56:00"))
            tabla.Rows.Add(3, "Mengano", "DeTal", DateTime.UtcNow)

            setTablas.Tables.Add(tabla)
        End Sub
    End Class

    <TestMethod()> Public Sub TestInterfazConectada()
        Dim conexion As New TestConexionDatos()
        conexion.Conectar()
        conexion.Ejecutar("INSERT THIS INSERT THAT")
        Assert.AreEqual("INSERT THIS INSERT THAT", conexion.UltimoComando)

        Dim setTablas As New DataSet
        conexion.LLenar(setTablas, "SELECT THIS SELECT THAT")
        Assert.AreEqual(1, setTablas.Tables.Count)
        Assert.AreEqual(4, setTablas.Tables(0).Columns.Count)
        Assert.AreEqual(3, setTablas.Tables(0).Rows.Count)

        Assert.AreEqual(2, setTablas.Tables(0).Rows(1).Item(0))
        Assert.AreEqual("Mengano", setTablas.Tables(0).Rows(2).Item(1))
        Assert.IsTrue(setTablas.Tables(0).Rows(0).Item(3) < DateTime.Now)

        conexion.Desconectar()
        Assert.AreEqual("", conexion.UltimoComando)
    End Sub

    <TestMethod()> Public Sub TestInterfazDesconectada()
        Dim conexion As New TestConexionDatos()
        conexion.Ejecutar("INSERT THIS INSERT THAT")
        Assert.AreEqual("", conexion.UltimoComando)

        Dim setTablas As New DataSet
        conexion.LLenar(setTablas, "SELECT THIS SELECT THAT")
        Assert.AreEqual(0, setTablas.Tables.Count)
    End Sub
End Class