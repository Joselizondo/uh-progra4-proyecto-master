

Public Class Menu_Datos



    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndgenerales.Click

        Dim frmPanelCentral As New frmMenu
        frmMenu.PanelCentral.Controls.Clear()
        Dim frmPanel As New Datos_Generales ' Primero haces un objeto de tipo frm que quieras llamar
        frmPanel.MdiParent = frmMenu 'Le indicas que es un padre
        frmMenu.PanelCentral.Controls.Add(frmPanel) 'la ubicas o asignas el panel donde va a estar
        frmPanel.Show() ' la muestras

    End Sub

    Private Sub Menu_Datos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class