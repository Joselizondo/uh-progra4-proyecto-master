Imports SECCP_B

<TestClass()> Public Class RepositorioPersonaTest
    Inherits BaseRepositoriosTest(Of Persona, Integer)

    <TestInitialize()> Public Overrides Sub Inicializar()
        repo = New RepositorioPersona(conexion)
    End Sub

    <TestMethod()> Public Sub ProbarInsercion()
        Dim idProfesion = _tratarCrearPersona()

        Dim personaDesdeBD = repo.ObtenerPorID(12345678)
        Assert.IsNotNull(personaDesdeBD)
        Assert.AreEqual(12345678, personaDesdeBD.Cedula)
        Assert.AreEqual("Persona", personaDesdeBD.PrimerNombre)
        Assert.AreEqual("De", personaDesdeBD.SegundoNombre)
        Assert.AreEqual("Prueba", personaDesdeBD.PrimerApellido)
        Assert.AreEqual("Mora", personaDesdeBD.SegundoApellido)
        Assert.AreEqual("31/01/2000", personaDesdeBD.FechaNacimiento.ToShortDateString)
        Assert.AreEqual("M", personaDesdeBD.Genero)
        Assert.AreEqual("persona@prueba.com", personaDesdeBD.Correo)
        Assert.AreEqual("88888888", personaDesdeBD.TelefonoCelular)
        Assert.AreEqual("55555555", personaDesdeBD.TelefonoFijo)
        Assert.AreEqual("Diagonal al Banco Diagonal", personaDesdeBD.Direccion)
        Assert.AreEqual(1, personaDesdeBD.CantidadAbortos)
        Assert.AreEqual(2, personaDesdeBD.CantidadHijosVivos)
        Assert.AreEqual(3, personaDesdeBD.CantidadHijosFallecidos)
        Assert.AreEqual(4, personaDesdeBD.CantidadHijosPrematuros)
        Assert.AreEqual(5, personaDesdeBD.NumeroHermanos)
        Assert.AreEqual("CR", personaDesdeBD.Pais)
        Assert.AreEqual("Soltero", personaDesdeBD.EstadoCivil)
        Assert.AreEqual("Secundaria", personaDesdeBD.Escolaridad)
        Assert.AreEqual(idProfesion, personaDesdeBD.Profesion.ID)
    End Sub

    <TestMethod()> Public Sub ProbarActualizacion()
        Dim personaDesdeBD = repo.ObtenerPorID(12345678)
        Dim idProfesion2 = personaDesdeBD.Profesion.ID + 1
        personaDesdeBD.PrimerNombre = "Persona modificada"
        personaDesdeBD.SegundoNombre = "De modificada"
        personaDesdeBD.PrimerApellido = "Prueba modificada"
        personaDesdeBD.SegundoApellido = "Mora modificada"
        personaDesdeBD.FechaNacimiento = "1999-03-30"
        personaDesdeBD.Genero = "F"
        personaDesdeBD.Correo = "persona2@prueba2.com"
        personaDesdeBD.TelefonoCelular = "99999999"
        personaDesdeBD.TelefonoFijo = "44444444"
        personaDesdeBD.Direccion = "Diagonal al Banco Modificado"
        personaDesdeBD.CantidadAbortos = 5
        personaDesdeBD.CantidadHijosVivos = 4
        personaDesdeBD.CantidadHijosFallecidos = 9
        personaDesdeBD.CantidadHijosPrematuros = 3
        personaDesdeBD.NumeroHermanos = 2
        personaDesdeBD.Pais = "NI"
        personaDesdeBD.EstadoCivil = "Divorciado"
        personaDesdeBD.Escolaridad = "Universitaria"
        personaDesdeBD.Profesion = New Profesion With {.ID = idProfesion2}

        repo.Actualizar(personaDesdeBD)
        personaDesdeBD = repo.ObtenerPorID(12345678)
        Assert.IsNotNull(personaDesdeBD)
        Assert.AreEqual(12345678, personaDesdeBD.Cedula)
        Assert.AreEqual("Persona modificada", personaDesdeBD.PrimerNombre)
        Assert.AreEqual("De modificada", personaDesdeBD.SegundoNombre)
        Assert.AreEqual("Prueba modificada", personaDesdeBD.PrimerApellido)
        Assert.AreEqual("Mora modificada", personaDesdeBD.SegundoApellido)
        Assert.AreEqual("30/03/1999", personaDesdeBD.FechaNacimiento.ToShortDateString)
        Assert.AreEqual("F", personaDesdeBD.Genero)
        Assert.AreEqual("persona2@prueba2.com", personaDesdeBD.Correo)
        Assert.AreEqual("99999999", personaDesdeBD.TelefonoCelular)
        Assert.AreEqual("44444444", personaDesdeBD.TelefonoFijo)
        Assert.AreEqual("Diagonal al Banco Modificado", personaDesdeBD.Direccion)
        Assert.AreEqual(5, personaDesdeBD.CantidadAbortos)
        Assert.AreEqual(4, personaDesdeBD.CantidadHijosVivos)
        Assert.AreEqual(9, personaDesdeBD.CantidadHijosFallecidos)
        Assert.AreEqual(3, personaDesdeBD.CantidadHijosPrematuros)
        Assert.AreEqual(2, personaDesdeBD.NumeroHermanos)
        Assert.AreEqual("NI", personaDesdeBD.Pais)
        Assert.AreEqual("Divorciado", personaDesdeBD.EstadoCivil)
        Assert.AreEqual("Universitaria", personaDesdeBD.Escolaridad)

        Assert.AreEqual(idProfesion2, personaDesdeBD.Profesion.ID)
    End Sub

    <TestMethod()> Public Sub ProbarEliminacion()
        _tratarCrearPersona()

        Dim personaDesdeBD = repo.ObtenerPorID(12345678)
        Assert.IsNotNull(personaDesdeBD)

        repo.Eliminar(personaDesdeBD)
        personaDesdeBD = repo.ObtenerPorID(12345678)
        Assert.IsNull(personaDesdeBD)
        conexion.Ejecutar("DELETE FROM dbo.PROFESION WHERE nombre_Profesion LIKE 'Profesion De Prueba%'")
    End Sub

    Private Function _tratarCrearPersona() As Integer
        conexion.Ejecutar("DELETE FROM dbo.PROFESION WHERE nombre_Profesion LIKE 'Profesion De Prueba%'")
        conexion.Ejecutar("INSERT INTO dbo.PROFESION(nombre_Profesion) VALUES('Profesion De Prueba')")
        conexion.Ejecutar("INSERT INTO dbo.PROFESION(nombre_Profesion) VALUES('Profesion De Prueba2')")

        Dim tablaSet As New DataSet
        conexion.LLenarTabla(tablaSet, "SELECT id_Profesion FROM PROFESION WHERE nombre_Profesion = 'Profesion De Prueba'")
        Dim idProfesion As Integer = tablaSet.Tables(0).Rows(0).Item(0)
        Dim personaDesdeBD = repo.ObtenerPorID(12345678)

        If personaDesdeBD Is Nothing Then

            ' Creación objeto prueba
            Dim personaPrueba = New Persona With {
                .Cedula = 12345678,
                .PrimerNombre = "Persona",
                .SegundoNombre = "De",
                .PrimerApellido = "Prueba",
                .SegundoApellido = "Mora",
                .FechaNacimiento = Date.Parse("2000-01-31"),
                .Genero = "M",
                .Correo = "persona@prueba.com",
                .TelefonoCelular = "88888888",
                .TelefonoFijo = "55555555",
                .Direccion = "Diagonal al Banco Diagonal",
                .CantidadAbortos = 1,
                .CantidadHijosVivos = 2,
                .CantidadHijosFallecidos = 3,
                .CantidadHijosPrematuros = 4,
                .NumeroHermanos = 5,
                .Pais = "CR",
                .EstadoCivil = "Soltero",
                .Escolaridad = "Secundaria",
                .Profesion = New Profesion With {
                    .ID = idProfesion
                }
            }

            repo.Insertar(personaPrueba)
        End If
        Return idProfesion
    End Function
End Class