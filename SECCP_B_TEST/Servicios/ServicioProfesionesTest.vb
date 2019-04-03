Imports SECCP_B

<TestClass()> Public Class ServicioProfesionesTest
    Protected conexion As IConexionDatos = New ConexionSQLServer("File Name=..\..\..\SECCP_B\bin\Debug\CONECTAR.udl")
    Private servicio As ServicioProfesiones = New ServicioProfesiones(conexion)

    <TestMethod()> Public Sub ProbarEliminacion()
        Dim repoProfesion = New RepositorioProfesiones(conexion)

        ' Creando una profesión de prueba
        Dim profesion = repoProfesion.InsertarYRecuperar(New Profesion With {
            .Nombre = "Astronauta supervisor"
        })
        ' Creando un par de personas que usan la profesión que acabo de crear

        Dim repoPersonas = New RepositorioPersona(conexion)
        repoPersonas.Insertar(New Persona With {
                .Cedula = 11111111,
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
                .Profesion = profesion
            })
        repoPersonas.Insertar(New Persona With {
                .Cedula = 2222222,
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
                .Profesion = profesion
            })
        Dim persona1 = repoPersonas.ObtenerPorID(11111111)
        Dim persona2 = repoPersonas.ObtenerPorID(2222222)
        Assert.AreEqual(profesion.ID, persona1.Profesion.ID)
        Assert.AreEqual(profesion.ID, persona2.Profesion.ID)

        servicio.Eliminar(profesion)
        persona1 = repoPersonas.ObtenerPorID(11111111)
        persona2 = repoPersonas.ObtenerPorID(2222222)

        Assert.AreNotEqual(profesion.ID, persona1.Profesion.ID)
        Assert.AreNotEqual(profesion.ID, persona2.Profesion.ID)
        Assert.IsNull(repoProfesion.ObtenerPorID(profesion.ID))

        ' limpieza
        repoPersonas.Eliminar(persona1)
        repoPersonas.Eliminar(persona2)
    End Sub

    <TestMethod()> Public Sub ProbarGuardado()
        servicio.Guardar(New Profesion With {
            .Nombre = "Una profesión"
        })
        servicio.Guardar(New Profesion With {
            .Nombre = "Una profesión"
        })
        servicio.Guardar(New Profesion With {
            .Nombre = "Una profesión"
        })

        Dim profesiones = servicio.Repositorio.BuscarPorNombre("Una profesión", True)

        Assert.AreEqual(3, profesiones.Count)
        Assert.IsTrue(profesiones.Any(Function(p) p.Nombre = "Una profesión"))
        Assert.IsTrue(profesiones.Any(Function(p) p.Nombre = "Una profesión (2)"))
        Assert.IsTrue(profesiones.Any(Function(p) p.Nombre = "Una profesión (3)"))

        ' Limpieza
        servicio.Eliminar(profesiones(0))
        servicio.Eliminar(profesiones(1))
        servicio.Eliminar(profesiones(2))
    End Sub

End Class