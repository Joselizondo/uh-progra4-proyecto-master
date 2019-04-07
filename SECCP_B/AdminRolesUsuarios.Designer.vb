<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Roles))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LISTA = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_BUSCAR = New System.Windows.Forms.TextBox()
        Me.ASIGROLES = New System.Windows.Forms.GroupBox()
        Me.CB_ROL = New System.Windows.Forms.ComboBox()
        Me.Rol = New System.Windows.Forms.Label()
        Me.LB_USER = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTN_REGRESAR = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.BTN_ACTUALIZAR = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.ASIGROLES.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LISTA)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_BUSCAR)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(53, 78)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(764, 244)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda de usuario"
        '
        'LISTA
        '
        Me.LISTA.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.LISTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LISTA.FullRowSelect = True
        Me.LISTA.GridLines = True
        Me.LISTA.Location = New System.Drawing.Point(27, 79)
        Me.LISTA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LISTA.Name = "LISTA"
        Me.LISTA.Size = New System.Drawing.Size(717, 143)
        Me.LISTA.TabIndex = 2
        Me.LISTA.UseCompatibleStateImageBehavior = False
        Me.LISTA.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cédula"
        Me.ColumnHeader1.Width = 88
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre"
        Me.ColumnHeader2.Width = 121
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Apellidos"
        Me.ColumnHeader3.Width = 172
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Rol"
        Me.ColumnHeader4.Width = 153
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'TXT_BUSCAR
        '
        Me.TXT_BUSCAR.Location = New System.Drawing.Point(89, 42)
        Me.TXT_BUSCAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TXT_BUSCAR.Name = "TXT_BUSCAR"
        Me.TXT_BUSCAR.Size = New System.Drawing.Size(377, 23)
        Me.TXT_BUSCAR.TabIndex = 0
        '
        'ASIGROLES
        '
        Me.ASIGROLES.Controls.Add(Me.CB_ROL)
        Me.ASIGROLES.Controls.Add(Me.Rol)
        Me.ASIGROLES.Controls.Add(Me.LB_USER)
        Me.ASIGROLES.Controls.Add(Me.Label2)
        Me.ASIGROLES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ASIGROLES.Location = New System.Drawing.Point(64, 338)
        Me.ASIGROLES.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ASIGROLES.Name = "ASIGROLES"
        Me.ASIGROLES.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ASIGROLES.Size = New System.Drawing.Size(753, 124)
        Me.ASIGROLES.TabIndex = 2
        Me.ASIGROLES.TabStop = False
        Me.ASIGROLES.Text = "Asignacion de roles"
        '
        'CB_ROL
        '
        Me.CB_ROL.Enabled = False
        Me.CB_ROL.FormattingEnabled = True
        Me.CB_ROL.Items.AddRange(New Object() {"Archivo", "Administrador", "Enfermera", "Médico", "Médico Internista", "Médico Especialista", "Psicólogo", "Terapista", "Coordinador de terapias", "Enfermera de Internamiento", "Director"})
        Me.CB_ROL.Location = New System.Drawing.Point(332, 32)
        Me.CB_ROL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CB_ROL.Name = "CB_ROL"
        Me.CB_ROL.Size = New System.Drawing.Size(219, 24)
        Me.CB_ROL.TabIndex = 6
        '
        'Rol
        '
        Me.Rol.AutoSize = True
        Me.Rol.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rol.Location = New System.Drawing.Point(293, 36)
        Me.Rol.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Rol.Name = "Rol"
        Me.Rol.Size = New System.Drawing.Size(29, 17)
        Me.Rol.TabIndex = 5
        Me.Rol.Text = "Rol"
        '
        'LB_USER
        '
        Me.LB_USER.AutoSize = True
        Me.LB_USER.Location = New System.Drawing.Point(79, 36)
        Me.LB_USER.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_USER.Name = "LB_USER"
        Me.LB_USER.Size = New System.Drawing.Size(92, 17)
        Me.LB_USER.TabIndex = 4
        Me.LB_USER.Text = "Sin registro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario:"
        '
        'BTN_REGRESAR
        '
        Me.BTN_REGRESAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_REGRESAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_REGRESAR.FlatAppearance.BorderSize = 0
        Me.BTN_REGRESAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_REGRESAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BTN_REGRESAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_REGRESAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_REGRESAR.Image = Global.SECCP_B.My.Resources.Resources.Cancelar2
        Me.BTN_REGRESAR.Location = New System.Drawing.Point(699, 470)
        Me.BTN_REGRESAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_REGRESAR.Name = "BTN_REGRESAR"
        Me.BTN_REGRESAR.Size = New System.Drawing.Size(155, 50)
        Me.BTN_REGRESAR.TabIndex = 7
        Me.BTN_REGRESAR.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(895, 15)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(36, 36)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.TabStop = False
        '
        'BTN_ACTUALIZAR
        '
        Me.BTN_ACTUALIZAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ACTUALIZAR.Enabled = False
        Me.BTN_ACTUALIZAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_ACTUALIZAR.FlatAppearance.BorderSize = 0
        Me.BTN_ACTUALIZAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_ACTUALIZAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BTN_ACTUALIZAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_ACTUALIZAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACTUALIZAR.Image = Global.SECCP_B.My.Resources.Resources.actualizar
        Me.BTN_ACTUALIZAR.Location = New System.Drawing.Point(507, 470)
        Me.BTN_ACTUALIZAR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BTN_ACTUALIZAR.Name = "BTN_ACTUALIZAR"
        Me.BTN_ACTUALIZAR.Size = New System.Drawing.Size(155, 50)
        Me.BTN_ACTUALIZAR.TabIndex = 1
        Me.BTN_ACTUALIZAR.UseVisualStyleBackColor = True
        '
        'Roles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 629)
        Me.Controls.Add(Me.BTN_REGRESAR)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.ASIGROLES)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_ACTUALIZAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Roles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roles de usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ASIGROLES.ResumeLayout(False)
        Me.ASIGROLES.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LISTA As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_BUSCAR As TextBox
    Friend WithEvents BTN_ACTUALIZAR As Button
    Friend WithEvents ASIGROLES As GroupBox
    Friend WithEvents BTN_REGRESAR As Button
    Friend WithEvents CB_ROL As ComboBox
    Friend WithEvents Rol As Label
    Friend WithEvents LB_USER As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents BtnCerrar As PictureBox
End Class
