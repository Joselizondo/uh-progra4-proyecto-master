Imports SECCP_B

<TestClass()> Public Class RepositorioProfesionesTest
    Inherits BaseRepositoriosTest(Of Profesion, Integer)
    Private ReadOnly NOMBRE_PROFESION = "Profesión de prueba"

    <TestInitialize()> Public Overrides Sub Inicializar()
        repo = New RepositorioProfesiones(conexion)
    End Sub

    <TestMethod()> Public Sub ProbarInsercion()
        _tratarCrearProfesion()

        Dim profesionDesdeBD = _obtenerProfesion().First()
        Assert.IsNotNull(profesionDesdeBD)
        Assert.IsTrue(profesionDesdeBD.ID > 0)
        Assert.AreEqual("Profesión de prueba", profesionDesdeBD.Nombre)
    End Sub

    <TestMethod()> Public Sub ProbarActualizacion()
        _tratarCrearProfesion()

        Dim profesionDesdeBD = _obtenerProfesion().First()
        profesionDesdeBD.Nombre = "Profesión de prueba modificada"
        repo.Actualizar(profesionDesdeBD)

        profesionDesdeBD = repo.ObtenerPorID(profesionDesdeBD.ID)
        Assert.IsNotNull(profesionDesdeBD)
        Assert.IsTrue(profesionDesdeBD.ID > 0)
        Assert.AreEqual("Profesión de prueba modificada", profesionDesdeBD.Nombre)

        profesionDesdeBD.Nombre = NOMBRE_PROFESION
        repo.Actualizar(profesionDesdeBD)
    End Sub

    <TestMethod()> Public Sub ProbarEliminacion()
        _tratarCrearProfesion()

        Dim profesionDesdeBD = _obtenerProfesion().First()
        Assert.IsNotNull(profesionDesdeBD)

        Dim profesionID = profesionDesdeBD.ID
        repo.Eliminar(profesionDesdeBD)
        profesionDesdeBD = repo.ObtenerPorID(profesionID)

        Assert.IsNull(profesionDesdeBD)
    End Sub

    Private Sub _tratarCrearProfesion()
        Dim profesionDesdeBD = _obtenerProfesion().FirstOrDefault()

        If profesionDesdeBD Is Nothing Then
            repo.Insertar(New Profesion With {
                            .Nombre = NOMBRE_PROFESION
                          })
        End If
    End Sub

    Private Function _obtenerCriterioSQL() As String
        Return String.Format("nombre_Profesion='{0}'", NOMBRE_PROFESION)
    End Function

    Private Function _obtenerProfesion() As List(Of Profesion)
        Return repo.BuscarPor(_obtenerCriterioSQL())
    End Function
End Class