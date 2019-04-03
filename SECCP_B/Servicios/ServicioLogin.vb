Imports System.Security.Cryptography
Imports System.Text
Imports SECCP_B

Public Class ServicioLogin

    Private Ruta = "File name= " & Application.StartupPath & "\CONECTAR.UDL"
    Private con As ConexionSQLServer

    Private listaErrores As List(Of String)
    Public Property Errores() As List(Of String)
        Get
            Return listaErrores
        End Get
        Private Set(ByVal value As List(Of String))
            listaErrores = value
        End Set
    End Property

    Private personaLogueada As Persona

    Public Property Persona As Persona
        Get
            Return personaLogueada
        End Get
        Private Set(ByVal value As Persona)
            personaLogueada = value
        End Set
    End Property

    Public Sub New()
        con = New ConexionSQLServer(Ruta)
    End Sub

    Function iniciar_sesion(ByVal Usuario, ByVal Contraseña) As Boolean
        Errores = New List(Of String)

        Using md5Hash As MD5 = MD5.Create()
            'Contraseña guardada en la base de datos'
            Dim contraseña_guardada As String
            Dim t As New DataSet
            Dim MENSAJE_USUARIO_NO_EXISTE = "Usuario ingresado no existe dentro del Sistema, por favor valide su información"

            Try
                con.LLenarTabla(t, "select contrasena from Usuario where num_cedula = '" & Usuario & "'")
                If t.Tables(0).Rows.Count > 0 Then
                    contraseña_guardada = t.Tables(0).Rows(0)("contrasena")

                    'Aqui la contraseña se encripta'
                    Dim hash As String = GetMd5Hash(md5Hash, Contraseña)

                    If VerifyMd5Hash(md5Hash, contraseña_guardada, hash) Then
                        Persona = obtenerPersonaLogueada(Usuario)
                        Return True
                    Else
                        Errores.Add("Contraseña ingresada no es válida")
                    End If
                Else
                    Errores.Add(MENSAJE_USUARIO_NO_EXISTE)
                End If
            Catch ex As Exception
                Errores.Add(MENSAJE_USUARIO_NO_EXISTE)
            End Try
        End Using

        Return False
    End Function

    Private Function obtenerPersonaLogueada(ByVal numeroCedula) As Persona
        Dim repo = New RepositorioPersona(con)
        Return repo.ObtenerPorID(numeroCedula)
    End Function


    ' Método realizado para el registro de los usuarios dentro del sistema
    ' Este método registrara al usuario teniendo un numero de cedula o persona que ya esté en el sistema

    Sub Registrar_Usuario(ByVal Usuario, ByVal Contrasena)
        Dim t As New DataSet
        Dim con As New ConexionSQLServer(Ruta)

        Using md5Hash As MD5 = MD5.Create()
            Contrasena = GetMd5Hash(md5Hash, Contrasena)

            con.Ejecutar("insert into Usuario (num_cedula,contrasena) values (" & Usuario & ",'" & Contrasena & "')")

            MsgBox("Usuario agregado correctamente!")

            ' Campo de numero de Cedula
            'MainMenu.UserField.Clear()

            ' Campo de contraseña 
            'MainMenu.PassField.Clear()

        End Using
    End Sub

    ' Encripta la contraseña ya sea si se esta iniciando sesion o se  está realizando el registro de un usuario
    Shared Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function 'GetMd5Hash


    ' Verifica que la contraseña guardada y la introducida por el usuario sean iguales
    Shared Function VerifyMd5Hash(ByVal md5Hash As MD5, ByVal ContrasenaDesdeDB As String, ByVal ContrasenaIngresada As String) As Boolean
        ' Hash the input.
        'Dim hashOfInput As String = GetMd5Hash(md5Hash, input)

        ' Create a StringComparer an compare the hashes.
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase

        If 0 = comparer.Compare(ContrasenaDesdeDB, ContrasenaIngresada) Then
            Return True
        Else
            Return False
        End If

    End Function 'VerifyMd5Hash
End Class
