Imports System.Globalization

Public Class RepositorioPersona
    Inherits RepositorioBase(Of Persona, Integer)

    Public Sub New(ByRef conexionDatos As IConexionDatos)
        MyBase.New(conexionDatos)
    End Sub

    Public Overrides Sub Actualizar(entidad As Persona)
        Dim SQL = String.Format("UPDATE PERSONA SET primer_nombre='{0}',segundo_nombre='{1}',primer_apellido='{2}',segundo_apellido='{3}'," _
                  & "fecha_nacimiento='{4}',genero='{5}',correo_electronico='{6}',telefono_celular='{7}',telefono_fijo='{8}',direccion='{9}'," _
                  & "abortos={10},vivos={11},fallecidos={12},prematuros={13},num_hermanos={14},id_pais='{15}',id_EstadoCivil='{16}'," _
                  & "id_Escolaridad='{17}',id_Profesion={18} WHERE num_cedula={19}",
                  entidad.PrimerNombre, entidad.SegundoNombre, entidad.PrimerApellido, entidad.SegundoApellido, entidad.FechaNacimiento.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                  entidad.Genero, entidad.Correo, entidad.TelefonoCelular, entidad.TelefonoFijo, entidad.Direccion, entidad.CantidadAbortos,
                  entidad.CantidadHijosVivos, entidad.CantidadHijosFallecidos, entidad.CantidadHijosPrematuros, entidad.NumeroHermanos,
                  entidad.Pais, entidad.EstadoCivil, entidad.Escolaridad, entidad.Profesion.ID, entidad.Cedula)
        conexion.Ejecutar(SQL)
    End Sub

    Public Overrides Sub Eliminar(entidad As Persona)
        conexion.Ejecutar(String.Format("DELETE FROM PERSONA WHERE num_cedula={0}", entidad.Cedula))
    End Sub

    Public Overrides Sub Insertar(entidad As Persona)
        Dim SQL = String.Format("INSERT INTO PERSONA(num_cedula,primer_nombre,segundo_nombre,primer_apellido,segundo_apellido," _
                  & "fecha_nacimiento,genero,correo_electronico,telefono_celular,telefono_fijo,direccion,abortos,vivos,fallecidos," _
                  & "prematuros,num_hermanos,id_pais,id_EstadoCivil,id_Escolaridad,id_Profesion)" _
                  & " VALUES({0},'{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',{11},{12},{13},{14},{15},'{16}','{17}','{18}',{19})",
                  entidad.Cedula, entidad.PrimerNombre, entidad.SegundoNombre, entidad.PrimerApellido, entidad.SegundoApellido, entidad.FechaNacimiento.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                  entidad.Genero, entidad.Correo, entidad.TelefonoCelular, entidad.TelefonoFijo, entidad.Direccion, entidad.CantidadAbortos,
                  entidad.CantidadHijosVivos, entidad.CantidadHijosFallecidos, entidad.CantidadHijosPrematuros, entidad.NumeroHermanos,
                  entidad.Pais, entidad.EstadoCivil, entidad.Escolaridad, entidad.Profesion.ID)
        conexion.Ejecutar(SQL)
    End Sub

    Public Overrides Function BuscarPor(criterios As String) As List(Of Persona)
        Return _recuperarPorConsulta(String.Format("SELECT * FROM PERSONA WHERE {0}", criterios))
    End Function

    Public Overrides Function Listar() As List(Of Persona)
        Return _recuperarPorConsulta("SELECT * FROM PERSONA")
    End Function

    Public Overrides Function ObtenerPorID(id As Integer) As Persona
        Return _recuperarPorConsulta(String.Format("SELECT * FROM PERSONA WHERE num_cedula={0}", id)).FirstOrDefault
    End Function

    Protected Overrides Function _convertir(dataRow As DataRow) As Persona
        Return New Persona With {
            .Cedula = dataRow.Item("num_cedula"),
            .PrimerNombre = dataRow.Item("primer_nombre"),
            .SegundoNombre = dataRow.Item("segundo_nombre"),
            .PrimerApellido = dataRow.Item("primer_apellido"),
            .SegundoApellido = dataRow.Item("segundo_apellido"),
            .FechaNacimiento = Date.Parse(dataRow.Item("fecha_nacimiento")),
            .Genero = Convert.ToString(dataRow.Item("genero")).Trim,
            .Correo = dataRow.Item("correo_electronico"),
            .TelefonoCelular = dataRow.Item("telefono_celular"),
            .TelefonoFijo = dataRow.Item("telefono_fijo"),
            .Direccion = dataRow.Item("direccion"),
            .CantidadAbortos = dataRow.Item("abortos"),
            .CantidadHijosVivos = dataRow.Item("vivos"),
            .CantidadHijosFallecidos = dataRow.Item("fallecidos"),
            .CantidadHijosPrematuros = dataRow.Item("prematuros"),
            .NumeroHermanos = dataRow.Item("num_hermanos"),
            .Pais = dataRow.Item("id_pais"),
            .EstadoCivil = dataRow.Item("id_EstadoCivil"),
            .Escolaridad = dataRow.Item("id_Escolaridad"),
            .Profesion = New Profesion With {
                .ID = dataRow.Item("id_Profesion")
            }
         }
    End Function
End Class
