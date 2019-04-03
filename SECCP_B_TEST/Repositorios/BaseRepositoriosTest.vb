Imports SECCP_B

<TestClass()> Public MustInherit Class BaseRepositoriosTest(Of T, I)
    Protected conexion As IConexionDatos = New ConexionSQLServer("File Name=..\..\..\SECCP_B\bin\Debug\CONECTAR.udl")
    Protected repo As IRepositorio(Of T, I)

    <TestInitialize()> Public MustOverride Sub Inicializar()
End Class