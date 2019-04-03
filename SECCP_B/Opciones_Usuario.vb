Public Class Opciones_Usuario
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frmPanelCentral As New frmMenu
        frmMenu.PanelCentral.Controls.Clear()
        Dim frmPanel As New Roles ' Primero haces un objeto de tipo frm que quieras llamar
        frmPanel.MdiParent = frmMenu 'Le indicas que es un padre
        frmMenu.PanelCentral.Controls.Add(frmPanel) 'la ubicas o asignas el panel donde va a estar
        frmPanel.Show() ' la muestras
    End Sub
End Class