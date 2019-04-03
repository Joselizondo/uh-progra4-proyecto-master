Public Class Persona
    Private cedulaPersona As Integer
    Public Property Cedula() As Integer
        Get
            Return cedulaPersona
        End Get
        Set(ByVal value As Integer)
            cedulaPersona = value
        End Set
    End Property

    Private nombrePersona As String
    Public Property PrimerNombre() As String
        Get
            Return nombrePersona
        End Get
        Set(ByVal value As String)
            nombrePersona = value
        End Set
    End Property

    Private nombre2Persona As String
    Public Property SegundoNombre() As String
        Get
            Return nombre2Persona
        End Get
        Set(ByVal value As String)
            nombre2Persona = value
        End Set
    End Property

    Private primerApellidoPersona As String
    Public Property PrimerApellido() As String
        Get
            Return primerApellidoPersona
        End Get
        Set(ByVal value As String)
            primerApellidoPersona = value
        End Set
    End Property

    Private segundoApellidoPersona As String
    Public Property SegundoApellido() As String
        Get
            Return segundoApellidoPersona
        End Get
        Set(ByVal value As String)
            segundoApellidoPersona = value
        End Set
    End Property

    Private fechaNacPersona As Date
    Public Property FechaNacimiento() As Date
        Get
            Return fechaNacPersona
        End Get
        Set(ByVal value As Date)
            fechaNacPersona = value
        End Set
    End Property

    Private generoPersona As String
    Public Property Genero() As String
        Get
            Return generoPersona
        End Get
        Set(ByVal value As String)
            generoPersona = value
        End Set
    End Property

    Private correoPersona As String
    Public Property Correo() As String
        Get
            Return correoPersona
        End Get
        Set(ByVal value As String)
            correoPersona = value
        End Set
    End Property

    Private telCelularPersona As String
    Public Property TelefonoCelular() As String
        Get
            Return telCelularPersona
        End Get
        Set(ByVal value As String)
            telCelularPersona = value
        End Set
    End Property

    Private telFijoPersona As String
    Public Property TelefonoFijo() As String
        Get
            Return telFijoPersona
        End Get
        Set(ByVal value As String)
            telFijoPersona = value
        End Set
    End Property

    Private direccionPersona As String
    Public Property Direccion() As String
        Get
            Return direccionPersona
        End Get
        Set(ByVal value As String)
            direccionPersona = value
        End Set
    End Property

    Private cantAbortosPersona As Integer
    Public Property CantidadAbortos() As Integer
        Get
            Return cantAbortosPersona
        End Get
        Set(ByVal value As Integer)
            cantAbortosPersona = value
        End Set
    End Property

    Private cantHijosVivosPersona As Integer
    Public Property CantidadHijosVivos() As Integer
        Get
            Return cantHijosVivosPersona
        End Get
        Set(ByVal value As Integer)
            cantHijosVivosPersona = value
        End Set
    End Property

    Private cantHijosFallecidosPersona As Integer
    Public Property CantidadHijosFallecidos() As Integer
        Get
            Return cantHijosFallecidosPersona
        End Get
        Set(ByVal value As Integer)
            cantHijosFallecidosPersona = value
        End Set
    End Property

    Private cantHijosPrematurosPersona As Integer
    Public Property CantidadHijosPrematuros() As Integer
        Get
            Return cantHijosPrematurosPersona
        End Get
        Set(ByVal value As Integer)
            cantHijosPrematurosPersona = value
        End Set
    End Property

    Private numHermanosPersona As Integer
    Public Property NumeroHermanos() As Integer
        Get
            Return numHermanosPersona
        End Get
        Set(ByVal value As Integer)
            numHermanosPersona = value
        End Set
    End Property

    Private paisPersona As String
    Public Property Pais() As String
        Get
            Return paisPersona
        End Get
        Set(ByVal value As String)
            paisPersona = value
        End Set
    End Property

    Private estCivilPersona As String
    Public Property EstadoCivil() As String
        Get
            Return estCivilPersona
        End Get
        Set(ByVal value As String)
            estCivilPersona = value
        End Set
    End Property

    Private escolaridadPersona As String
    Public Property Escolaridad() As String
        Get
            Return escolaridadPersona
        End Get
        Set(ByVal value As String)
            escolaridadPersona = value
        End Set
    End Property

    Private profesionPersona As Profesion
    Public Property Profesion() As Profesion
        Get
            Return profesionPersona
        End Get
        Set(ByVal value As Profesion)
            profesionPersona = value
        End Set
    End Property

End Class
