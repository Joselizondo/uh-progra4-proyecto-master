Public Class Profesion
    Private idProfesion As Integer
    Public Property ID() As Integer
        Get
            Return idProfesion
        End Get
        Set(ByVal value As Integer)
            idProfesion = value
        End Set
    End Property

    Private nombreProfesion As String
    Public Property Nombre() As String
        Get
            Return nombreProfesion
        End Get
        Set(ByVal value As String)
            nombreProfesion = value
        End Set
    End Property
End Class
