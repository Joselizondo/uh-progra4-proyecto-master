<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginView
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserField = New System.Windows.Forms.TextBox()
        Me.PasswordField = New System.Windows.Forms.TextBox()
        Me.IniciarSesionBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inicio de Sesión"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(161, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Número de Cédula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'UserField
        '
        Me.UserField.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserField.Location = New System.Drawing.Point(123, 168)
        Me.UserField.Name = "UserField"
        Me.UserField.Size = New System.Drawing.Size(244, 29)
        Me.UserField.TabIndex = 3
        '
        'PasswordField
        '
        Me.PasswordField.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordField.Location = New System.Drawing.Point(123, 298)
        Me.PasswordField.Name = "PasswordField"
        Me.PasswordField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordField.Size = New System.Drawing.Size(244, 29)
        Me.PasswordField.TabIndex = 4
        '
        'IniciarSesionBTN
        '
        Me.IniciarSesionBTN.BackColor = System.Drawing.Color.SteelBlue
        Me.IniciarSesionBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IniciarSesionBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IniciarSesionBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IniciarSesionBTN.ForeColor = System.Drawing.Color.White
        Me.IniciarSesionBTN.Image = Global.SECCP_B.My.Resources.Resources.Mano
        Me.IniciarSesionBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IniciarSesionBTN.Location = New System.Drawing.Point(123, 333)
        Me.IniciarSesionBTN.Name = "IniciarSesionBTN"
        Me.IniciarSesionBTN.Size = New System.Drawing.Size(244, 89)
        Me.IniciarSesionBTN.TabIndex = 5
        Me.IniciarSesionBTN.Text = "Iniciar Sesión"
        Me.IniciarSesionBTN.UseVisualStyleBackColor = False
        '
        'LoginView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(768, 472)
        Me.Controls.Add(Me.IniciarSesionBTN)
        Me.Controls.Add(Me.PasswordField)
        Me.Controls.Add(Me.UserField)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginView"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents UserField As TextBox
    Friend WithEvents PasswordField As TextBox
    Friend WithEvents IniciarSesionBTN As Button
End Class
