Imports SECCP_B

<TestClass()> Public Class ConexionSQLServerTest
    Private conexion As IConexionDatos

    <TestInitialize> Public Sub Inicializar()
        conexion = New ConexionSQLServer("File Name=..\..\..\SECCP_B\bin\Debug\CONECTAR.udl")

        'Limpieza
        conexion.Ejecutar("DELETE per FROM PERSONA per INNER JOIN PROFESION prof ON prof.id_Profesion=per.id_Profesion WHERE prof.nombre_Profesion LIKE 'Profesion De Prueba%'")
        conexion.Ejecutar("DELETE FROM dbo.PROFESION WHERE nombre_Profesion LIKE 'Profesion De Prueba%'")
    End Sub

    <TestMethod()> Public Sub ProbarLlenado()
        Dim tabla As DataSet = New DataSet()
        Dim SQL = "SELECT TOP 1 * FROM dbo.PROFESION WHERE nombre_Profesion='Profesion De Prueba'"
        conexion.LLenarTabla(tabla, SQL)
        Assert.AreEqual(0, tabla.Tables(0).Rows.Count)

        conexion.Ejecutar("INSERT INTO PROFESION(nombre_Profesion) VALUES('Profesion De Prueba')")
        tabla.Clear()

        conexion.LLenarTabla(tabla, SQL)
        Assert.AreEqual(1, tabla.Tables(0).Rows.Count)
        Assert.AreEqual("Profesion De Prueba", tabla.Tables(0).Rows(0).Item(1))
    End Sub

End Class