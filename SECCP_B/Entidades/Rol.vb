Public Class Rol
    Private numeroCedula As Integer
    Public Property Cedula() As Integer
        Get
            Return numeroCedula
        End Get
        Set(ByVal value As Integer)
            numeroCedula = value
        End Set
    End Property

    Private nombrePersona As String
    Public Property Nombre() As String
        Get
            Return nombrePersona
        End Get
        Set(ByVal value As String)
            nombrePersona = value
        End Set
    End Property

    Private apellidosPersona As String
    Public Property Apellidos() As String
        Get
            Return apellidosPersona
        End Get
        Set(ByVal value As String)
            apellidosPersona = value
        End Set
    End Property

    Private rolPersona As String
    Public Property Rol() As String
        Get
            Return rolPersona
        End Get
        Set(ByVal value As String)
            rolPersona = value
        End Set
    End Property
    Private usuarioPersona As String
    Public Property Usuario() As String
        Get
            Return usuarioPersona
        End Get
        Set(ByVal value As String)
            usuarioPersona = value
        End Set
    End Property

End Class
