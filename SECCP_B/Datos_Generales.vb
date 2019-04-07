Public Class Datos_Generales

    Private CONEXION = New ConexionSQLServer("File Name=..\..\..\SECCP_B\bin\Debug\CONECTAR.udl")

    Sub CARGAR_PROFESIONES()
        Dim T As New DataSet
        Dim SQL As String

        SQL = "SELECT NOMBRE_PROFESION FROM DBO.PROFESION"
        CONEXION.LLenarTabla(T, SQL)

        For I = 0 To T.Tables(0).Rows.Count - 1
            PROFESION.Items.Add(T.Tables(0).Rows(I).Item(0))
        Next
    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles FechaNacimiento.ValueChanged

        Dim edad As Integer = DateTime.Today.AddTicks(-FechaNacimiento.Value.Ticks).Year - 1
        AÑOS.Text = edad & " Años"

    End Sub

    Private Sub Datos_Generales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FechaNacimiento.MaxDate = DateTime.Today
        CARGAR_PROFESIONES()

    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        Dim T As New DataSet
        Dim SQL As String
        Dim GEN As String
        Dim FECHA As Date
        Dim PROF As Integer

        If MASCULINO.Checked = True Then
            GEN = "M"
        Else
            If FEMENINO.Checked = True Then
                GEN = "F"
            End If
        End If

        If PRIMERNOMBRE.Text = "" Then
            MsgBox("Debe indicar el primer nombre!", vbInformation, "Espacio obligatorio")
        Else
            If PRIMERAPELLIDO.Text = "" Then
                MsgBox("Debe indicar el primer apellido!", vbInformation, "Espacio obligatorio")
            Else
                If FechaNacimiento.Value.Date = Date.Today Then
                    MsgBox("Debe indicar la fecha de nacimiento!", vbInformation, "Espacio obligatorio")
                Else
                    If GEN = "" Then
                        MsgBox("Debe indicar el genero!", vbInformation, "Espacio obligatorio")
                    Else
                        If DIRECCION.Text = "" Then
                            MsgBox("Debe indicar la direccion!", vbInformation, "Espacio obligatorio")
                        Else
                            If PAIS.Text = "" Then
                                MsgBox("Debe indicar el pais!", vbInformation, "Espacio obligatorio")
                            Else
                                If ESTADOCIV.Text = "" Then
                                    MsgBox("Debe indicar el estado civil!", vbInformation, "Espacio obligatorio")
                                Else
                                    If ESCOLARIDAD.Text = "" Then
                                        MsgBox("Debe indicar nivel de escolaridad!", vbInformation, "Espacio obligatorio")
                                    Else
                                        If PROFESION.Text = "" Then
                                            MsgBox("Debe indicar la profesion!", vbInformation, "Espacio obligatorio")
                                        Else
                                            If IDENTIFICACION.Text = "" Then
                                                MsgBox("Debe indicar el numero de identificacion!", vbInformation, "Espacio obligatorio")
                                            Else
                                                FECHA = Convert.ToDateTime(FechaNacimiento.Value.Date)

                                                SQL = "SELECT ID_PROFESION FROM DBO.PROFESION WHERE NOMBRE_PROFESION = '" & PROFESION.Text & "' "
                                                CONEXION.LLenarTabla(T, SQL)

                                                PROF = T.Tables(0).Rows(0).Item(0)

                                                SQL = "INSERT INTO dbo.Persona (num_cedula, primer_nombre, segundo_nombre, primer_apellido, segundo_apellido, fecha_nacimiento, genero, correo_electronico, telefono_celular, telefono_fijo, direccion, abortos, vivos, fallecidos, prematuros, num_hermanos, id_pais, id_estadocivil, id_escolaridad, id_profesion) values(" & IDENTIFICACION.Text & ", '" & PRIMERNOMBRE.Text & "', '" & SEGUNDONOMBRE.Text & "', '" & PRIMERAPELLIDO.Text & "', '" & SEGUNDOAPELLIDO.Text & "', '" & FECHA & "', '" & GEN & "', '" & CORREO.Text & "', '" & TELCEL.Text & "', '" & TELCASA.Text & "', '" & DIRECCION.Text & "', " & ABORTO.Text & ", " & VIVO.Text & ", " & FALLECIDO.Text & ", " & PREMATURO.Text & ", " & HERMANOS.Text & ", '" & PAIS.Text & "', '" & ESTADOCIV.Text & "', '" & ESCOLARIDAD.Text & "', " & PROF & ")"
                                                CONEXION.Ejecutar(SQL)

                                                MsgBox("Informacion Almacenada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Guardado")
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub
End Class