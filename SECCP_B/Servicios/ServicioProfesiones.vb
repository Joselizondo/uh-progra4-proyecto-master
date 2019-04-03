Public Class ServicioProfesiones
    Inherits ServicioBase

    Private PROFESION_POR_DEFECTO = "Sin profesión"
    Private repoProfesiones As IRepositorioProfesiones

    Public ReadOnly Property Repositorio() As IRepositorioProfesiones
        Get
            Return repoProfesiones
        End Get
    End Property

    Public Sub New(ByRef conexionDatos As IConexionDatos)
        MyBase.New(conexionDatos)
        repoProfesiones = FabricaRepositorios.ObtenerRepoProfesiones(conexion)
    End Sub

    Public Sub Eliminar(ByRef profesion As Profesion)
        ' Antes de eliminar una profesión, hay que asegurar que si está siendo referenciada en personas,
        ' dicha referencia se elimine primero, luego se procede con la eliminación de la profesión como tal
        Dim repoPersonas = FabricaRepositorios.ObtenerRepoPersonas(conexion)

        Dim personasDependientes = repoPersonas.BuscarPor(String.Format("id_Profesion = {0}", profesion.ID))
        Dim profesionPorDefecto = repoProfesiones.BuscarPorNombre(PROFESION_POR_DEFECTO, False).FirstOrDefault

        If profesionPorDefecto Is Nothing Then
            profesionPorDefecto = _crearProfesionPorDefecto()
        End If

        For Each persona As Persona In personasDependientes
            persona.Profesion = profesionPorDefecto
            repoPersonas.Actualizar(persona)
        Next

        repoProfesiones.Eliminar(profesion)
    End Sub

    Public Sub Guardar(ByRef profesion As Profesion)
        ' La responsabilidad de este sub es garantizar que no se guarden dos profesiones con el mismo nombre. De haber colisión
        ' modificará el nombre para que sea único

        Dim profesionesMismoNombre = repoProfesiones.BuscarPorNombre(profesion.Nombre.Trim.ToLowerInvariant, True)
        Dim nuevoNumero = profesionesMismoNombre.Count + 1

        While profesionesMismoNombre.Any(Function(n) n.Nombre.Contains(String.Format(" ({0})", nuevoNumero)))
            nuevoNumero = nuevoNumero + 1
        End While

        If nuevoNumero > 1 Then
            profesion.Nombre = String.Format("{0} ({1})", profesion.Nombre, nuevoNumero)
        End If

        ' insertar o actualizar, dependiendo del caso
        If profesion.ID < 1 OrElse repoProfesiones.ObtenerPorID(profesion.ID) Is Nothing Then
            repoProfesiones.Insertar(profesion)
        Else
            repoProfesiones.Actualizar(profesion)
        End If
    End Sub

    Private Function _crearProfesionPorDefecto() As Profesion
        repoProfesiones.Insertar(New Profesion With {
            .Nombre = PROFESION_POR_DEFECTO
        })

        Return repoProfesiones.BuscarPorNombre(PROFESION_POR_DEFECTO, False).FirstOrDefault
    End Function
End Class
