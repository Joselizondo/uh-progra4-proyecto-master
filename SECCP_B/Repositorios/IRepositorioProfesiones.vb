Public Interface IRepositorioProfesiones
    Inherits IRepositorio(Of Profesion, Integer)
    Function BuscarPorNombre(nombre As String, aproximado As Boolean) As List(Of Profesion)
    Function InsertarYRecuperar(entidad As Profesion) As Profesion
End Interface
