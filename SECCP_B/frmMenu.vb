
Public Class frmMenu

    Private Sub frmMenu__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frmPanelCentral As New frmMenu
        Me.PanelCentral.Controls.Clear()
        Dim frmPanel As New LoginView ' Primero haces un objeto de tipo frm que quieras llamar
        frmPanel.MdiParent = Me 'Le indicas que es un padre
        Me.PanelCentral.Controls.Add(frmPanel) 'la ubicas o asignas el panel donde va a estar
        frmPanel.Show() ' la muestras
    End Sub

    Public Sub definirUsuarioLogueado(ByVal texto As String)
        usuariologeado.Text = texto
    End Sub

    'Evento para ocultar elpanel ezquierdo'
    Private Sub BtnOcultar_Click(sender As Object, e As EventArgs) Handles BtnOcultar.Click
        If PanelLateral.Width = (197) Then

            PanelLateral.Width = (80)
        Else

            PanelLateral.Width = (197)

        End If
    End Sub
    'Evento del boton para cerrar el programa'
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub
    'Evento con funcion de maximizar'
    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click

        WindowState = FormWindowState.Maximized
        BtnAjustar.Visible = True
        BtnMaximizar.Visible = False




    End Sub
    'Evento con funcion de ajustar ventana'
    Private Sub BtnAjustar_Click(sender As Object, e As EventArgs) Handles BtnAjustar.Click

        WindowState = FormWindowState.Normal
        BtnAjustar.Visible = False
        BtnMaximizar.Visible = True


    End Sub
    'Evento para minimizar ventana'
    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles BtnMinimizar.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub PanelSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseDown


    End Sub

    'Metodo de llamada de form ajustable en el panel del Menu Principal'
    Public Sub AbrirFormEnPanel(ByVal Formhijo As Object)

        If Me.PanelCentral.Controls.Count > 0 Then
            Me.PanelCentral.Controls.RemoveAt(0)
        End If

        Dim fh As Form = TryCast(Formhijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelCentral.Controls.Add(fh)
        Me.PanelCentral.Tag = fh
        fh.Show()

    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click

        AbrirFormEnPanel(New Opciones_Usuario)

    End Sub



    Private Sub btnlogin_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlogin.MouseEnter
        Me.btnlogin.Image = My.Resources.salir
    End Sub


    Private Sub btnlogin_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnlogin.MouseLeave
        Me.btnlogin.Image = My.Resources.Login

    End Sub

    Private Sub BtnCitas_Click(sender As Object, e As EventArgs) Handles BtnCitas.Click
        Me.PanelCentral.Controls.Clear()
        Dim frmPanelCentral As New Menu_Datos ' Primero haces un objeto de tipo frm que quieras llamar
        frmPanelCentral.MdiParent = Me 'Le indicas que es un padre
        Me.PanelCentral.Controls.Add(frmPanelCentral) 'la ubicas o asignas el panel donde va a estar
        frmPanelCentral.Show() ' la muestras
    End Sub

    Private Sub PanelCentral_Paint(sender As Object, e As PaintEventArgs) Handles PanelCentral.Paint
        Dim nada As String
        nada = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.PanelCentral.Controls.Clear()
        Dim frmPanelCentral As New LoginView ' Primero haces un objeto de tipo frm que quieras llamar
        frmPanelCentral.MdiParent = Me 'Le indicas que es un padre
        Me.PanelCentral.Controls.Add(frmPanelCentral) 'la ubicas o asignas el panel donde va a estar
        frmPanelCentral.Show() ' la muestras
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Me.PanelCentral.Controls.Clear()
        Dim frmPanelCentral As New LoginView ' Primero haces un objeto de tipo frm que quieras llamar
        frmPanelCentral.MdiParent = Me 'Le indicas que es un padre
        Me.PanelCentral.Controls.Add(frmPanelCentral) 'la ubicas o asignas el panel donde va a estar
        frmPanelCentral.Show() ' la muestras
    End Sub

    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint

    End Sub
End Class


