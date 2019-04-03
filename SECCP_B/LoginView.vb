Public Class LoginView
    Private Sub IniciarSesionBTN_Click(sender As Object, e As EventArgs) Handles IniciarSesionBTN.Click
        Dim User = UserField.Text
        Dim Password = PasswordField.Text

        Dim login As New ServicioLogin

        If login.iniciar_sesion(User, Password) = True Then
            Dim formPadre = DirectCast(ParentForm, frmMenu)
            formPadre.definirUsuarioLogueado(String.Format("{0} {1}", login.Persona.PrimerNombre, login.Persona.PrimerApellido))
            Hide()
        Else
            Dim tituloAlerta = "Error en Inicio de sesión"
            For Each mensajeError As String In login.Errores
                Select Case mensajeError
                    Case "Contraseña ingresada no es válida"
                        MsgBox(mensajeError, MsgBoxStyle.Exclamation, tituloAlerta)
                    Case "Usuario ingresado no existe dentro del Sistema, por favor valide su información"
                        MsgBox(mensajeError, MsgBoxStyle.Critical, tituloAlerta)
                End Select
            Next
        End If
    End Sub
End Class