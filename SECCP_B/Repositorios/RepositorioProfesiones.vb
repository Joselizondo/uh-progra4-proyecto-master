Imports SECCP_B

Public Class RepositorioProfesiones
    Inherits RepositorioBase(Of Profesion, Integer)
    Implements IRepositorioProfesiones

    Public Sub New(ByRef conexionDatos As IConexionDatos)
        MyBase.New(conexionDatos)
    End Sub

    Public Overrides Sub Actualizar(entidad As Profesion)
        conexion.Ejecutar(String.Format("UPDATE PROFESION SET nombre_Profesion='{0}' WHERE id_Profesion={1}", entidad.Nombre, entidad.ID))
    End Sub

    Public Overrides Sub Eliminar(entidad As Profesion)
        conexion.Ejecutar(String.Format("DELETE FROM PROFESION WHERE id_Profesion={0}", entidad.ID))
    End Sub

    Public Overrides Sub Insertar(entidad As Profesion)
        conexion.Ejecutar(String.Format("INSERT INTO PROFESION(nombre_Profesion) VALUES('{0}')", entidad.Nombre))
    End Sub

    Public Overrides Function BuscarPor(criterios As String) As List(Of Profesion)
        Return _recuperarPorConsulta(String.Format("SELECT * FROM PROFESION WHERE {0}", criterios))
    End Function

    Public Function BuscarPorNombre(nombre As String, aproximado As Boolean) As List(Of Profesion) Implements IRepositorioProfesiones.BuscarPorNombre
        If aproximado = True Then
            Return BuscarPor(String.Format("nombre_Profesion LIKE '{0}%'", nombre))
        End If
        Return BuscarPor(String.Format("nombre_Profesion='{0}'", nombre))
    End Function

    Public Overrides Function Listar() As List(Of Profesion)
        Return _recuperarPorConsulta("SELECT * FROM PROFESION")
    End Function

    Public Overrides Function ObtenerPorID(id As Integer) As Profesion
        Return _recuperarPorConsulta(String.Format("SELECT * FROM PROFESION WHERE id_Profesion={0}", id)).FirstOrDefault
    End Function

    Public Function InsertarYRecuperar(entidad As Profesion) As Profesion Implements IRepositorioProfesiones.InsertarYRecuperar
        Insertar(entidad)
        Return BuscarPorNombre(entidad.Nombre, False).FirstOrDefault
    End Function

    Protected Overrides Function _convertir(dataRow As DataRow) As Profesion
        Return New Profesion With {
            .ID = dataRow.Item("id_Profesion"),
            .Nombre = dataRow.Item("nombre_Profesion")
         }
    End Function
End Class
