Public MustInherit Class RepositorioBase(Of T, I)
    Implements IRepositorio(Of T, I)
    Protected conexion As IConexionDatos

    Protected Sub New(ByRef conexionDatos As IConexionDatos)
        conexion = conexionDatos
    End Sub

    Public MustOverride Sub Actualizar(entidad As T) Implements IRepositorio(Of T, I).Actualizar

    Public MustOverride Sub Eliminar(entidad As T) Implements IRepositorio(Of T, I).Eliminar

    Public MustOverride Sub Insertar(entidad As T) Implements IRepositorio(Of T, I).Insertar

    Public MustOverride Function BuscarPor(criterios As String) As List(Of T) Implements IRepositorio(Of T, I).BuscarPor

    Public MustOverride Function Listar() As List(Of T) Implements IRepositorio(Of T, I).Listar

    Public MustOverride Function ObtenerPorID(id As I) As T Implements IRepositorio(Of T, I).ObtenerPorID

    Protected Function _recuperarPorConsulta(SQL As String) As List(Of T)
        Dim setTablas As New DataSet
        conexion.LLenarTabla(setTablas, SQL)
        Dim resultados As New List(Of T)

        For i = 0 To setTablas.Tables(0).Rows.Count - 1
            resultados.Add(_convertir(setTablas.Tables(0).Rows(i)))
        Next
        Return resultados
    End Function

    Protected MustOverride Function _convertir(dataRow As DataRow) As T
End Class
