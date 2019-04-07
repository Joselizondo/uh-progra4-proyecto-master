Public Class Roles
    Private Sub Roles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'REFRESCAR()'
    End Sub

    Friend Sub REFRESCAR()
        Dim servicio As New ServicioRoles()
        Dim listaRoles = servicio.Listar()
        LISTA.Items.Clear()

        For i = 0 To listaRoles.Count - 1
            LISTA.Items.Add(listaRoles(i).Cedula)
            LISTA.Items(LISTA.Items.Count - 1).SubItems.Add(listaRoles(i).Nombre)
            LISTA.Items(LISTA.Items.Count - 1).SubItems.Add(listaRoles(i).Apellidos)
            LISTA.Items(LISTA.Items.Count - 1).SubItems.Add(listaRoles(i).Rol)
        Next

    End Sub
    Friend Sub REFRESCAR2()
        Dim servicio As New ServicioRoles()
        Dim listaRoles = servicio.Buscar(TXT_BUSCAR.Text)
        LISTA.Items.Clear()
        For i = 0 To listaRoles.Count - 1
            LISTA.Items.Add(listaRoles(i).Cedula)
            LISTA.Items(LISTA.Items.Count - 1).SubItems.Add(listaRoles(i).Nombre)
            LISTA.Items(LISTA.Items.Count - 1).SubItems.Add(listaRoles(i).Apellidos)
            LISTA.Items(LISTA.Items.Count - 1).SubItems.Add(listaRoles(i).Rol)
        Next

    End Sub

    Private Sub TXT_BUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXT_BUSCAR.TextChanged
        REFRESCAR2()

    End Sub

    Private Sub LISTA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LISTA.SelectedIndexChanged
        If LISTA.SelectedItems.Count <> 0 Then
            Dim servicio As New ServicioRoles()
            Dim listaRoles = servicio.Seleccionar(LISTA.SelectedItems(0).SubItems(0).Text)
            LB_USER.Text = listaRoles(0).Usuario
            CB_ROL.Text = listaRoles(0).Rol
            BTN_ACTUALIZAR.Enabled = True
            CB_ROL.Enabled = True

        End If
    End Sub

    Private Sub CB_ROL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_ROL.SelectedIndexChanged
        BTN_ACTUALIZAR.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_ACTUALIZAR.Click
        If CB_ROL.Text <> "" Then
            Dim servicio As New ServicioRoles()
            servicio.Actualizar(LISTA.SelectedItems(0).SubItems(0).Text, CB_ROL.Text)
            MsgBox("Los datos han sido actualizados satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Actualización")
            LIMPIAR()
            REFRESCAR()
        End If
    End Sub
    Friend Sub LIMPIAR()
        LB_USER.Text = "Sin registro"
        CB_ROL.Text = ""
        BTN_ACTUALIZAR.Enabled = False
        CB_ROL.Enabled = False
    End Sub

    Private Sub BTN_REGRESAR_Click(sender As Object, e As EventArgs) Handles BTN_REGRESAR.Click
        Dim frmPanelCentral As New frmMenu
        frmMenu.PanelCentral.Controls.Clear()
        Dim frmPanel As New Opciones_Usuario ' Primero haces un objeto de tipo frm que quieras llamar
        frmPanel.MdiParent = frmMenu 'Le indicas que es un padre
        frmMenu.PanelCentral.Controls.Add(frmPanel) 'la ubicas o asignas el panel donde va a estar
        frmPanel.Show() ' la muestras
        'este boton futuramente puede regresar a un menpu principal de administración
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
