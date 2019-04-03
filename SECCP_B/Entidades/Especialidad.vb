Imports SECCP_B

Public Class Especialidad
    Private idEspecialidad As Integer

    Public Property ID() As Integer
        Get
            Return idEspecialidad
        End Get
        Set(ByVal value As Integer)
            idEspecialidad = value
        End Set
    End Property

    Private nombreEspecialidad As String
    Public Property Nombre() As String
        Get
            Return nombreEspecialidad
        End Get
        Set(ByVal value As String)
            nombreEspecialidad = value
        End Set
    End Property

End Class
