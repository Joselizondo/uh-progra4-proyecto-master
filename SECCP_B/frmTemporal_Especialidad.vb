Public Class frmTemporal_Especialidad
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim se As New ServicioEspecialidad
        Dim nombre = txtNombre.Text
        se.Registrar(nombre)
        REFRESCAR()
        Limpiar()
    End Sub

    Sub Limpiar()
        txtNombre.Clear()
        ID.Text = "ID Autogenerado"
    End Sub

    Friend Sub REFRESCAR()
        Dim servicio As New ServicioEspecialidad()
        Dim listaEsp = servicio.Listar()
        Lista.Items.Clear()

        For i = 0 To listaEsp.Count - 1
            Lista.Items.Add(listaEsp(i).ID)
            Lista.Items(Lista.Items.Count - 1).SubItems.Add(listaEsp(i).Nombre)
        Next

    End Sub

    Private Sub frmTemporal_Especialidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        REFRESCAR()
    End Sub

    Friend Sub REFRESCAR_PARAMETROS()
        Dim servicio As New ServicioEspecialidad()
        Dim Esp = servicio.Buscar(BUSCAR.Text)
        Lista.Items.Clear()
        For i = 0 To Esp.Count - 1
            Lista.Items.Add(Esp(i).ID)
            Lista.Items(Lista.Items.Count - 1).SubItems.Add(Esp(i).Nombre)
        Next

    End Sub

    Private Sub BUSCAR_TextChanged(sender As Object, e As EventArgs) Handles BUSCAR.TextChanged
        REFRESCAR_PARAMETROS()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lista.SelectedIndexChanged
        If Lista.SelectedItems.Count <> 0 Then
            Dim servicio As New ServicioEspecialidad()
            Dim Esp = servicio.Seleccionar(Lista.SelectedItems(0).SubItems(0).Text)
            ID.Text = Esp(0).ID
            txtNombre.Text = Esp(0).Nombre
            BACTUALIZAR.Enabled = True
            BELIMINAR.Enabled = True
        End If
    End Sub

    Private Sub BACTUALIZAR_Click(sender As Object, e As EventArgs) Handles BACTUALIZAR.Click
        If txtNombre.Text <> "" Then
            Dim esp As New ServicioEspecialidad()
            esp.Actualizar(Lista.SelectedItems(0).SubItems(0).Text, txtNombre.Text)
            MsgBox("Los datos han sido actualizados satisfactoriamente", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Actualización")
            Limpiar()
            REFRESCAR()
        End If
    End Sub

    Private Sub BELIMINAR_Click(sender As Object, e As EventArgs) Handles BELIMINAR.Click
        If MsgBox("Desea eliminar esta especialidad" & txtNombre.Text, MsgBoxStyle.Question + MsgBoxStyle.YesNo, txtNombre.Text) = MsgBoxResult.Yes Then
            Dim esp As New ServicioEspecialidad()
            esp.Eliminar(Lista.SelectedItems(0).SubItems(0).Text)
            MsgBox("La especialidad ha sido eliminado", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Eliminado")
            Limpiar()
            REFRESCAR()
        End If

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class