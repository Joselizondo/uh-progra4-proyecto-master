Public Interface IRepositorio(Of T, I)
    Function BuscarPor(ByVal criterios As String) As List(Of T)
    Function Listar() As List(Of T)
    Function ObtenerPorID(ByVal id As I) As T

    Sub Actualizar(ByVal entidad As T)
    Sub Eliminar(ByVal entidad As T)
    Sub Insertar(ByVal entidad As T)
End Interface
