Public Class Datos_Generales

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub labelanos_Click(sender As Object, e As EventArgs) Handles labelanos.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles FechaNacimiento.ValueChanged

        Dim edad As Integer = DateTime.Today.AddTicks(-FechaNacimiento.Value.Ticks).Year - 1
        labelanos.Text = edad & " Años"

    End Sub

    Private Sub Datos_Generales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaNacimiento.MaxDate = DateTime.Today
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class