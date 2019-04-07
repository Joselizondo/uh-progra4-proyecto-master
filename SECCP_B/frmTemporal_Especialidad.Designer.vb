<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemporal_Especialidad
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BUSCAR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BACTUALIZAR = New System.Windows.Forms.Button()
        Me.BELIMINAR = New System.Windows.Forms.Button()
        Me.Lista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BGuardar)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(200, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de Datos"
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(43, 155)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(100, 23)
        Me.BGuardar.TabIndex = 1
        Me.BGuardar.Text = "GUARDAR"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(40, 31)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(142, 17)
        Me.ID.TabIndex = 3
        Me.ID.Text = """ID Autogenerado"""
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(35, 100)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(124, 22)
        Me.txtNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre de Especialidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.BUSCAR)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.BACTUALIZAR)
        Me.GroupBox2.Controls.Add(Me.BELIMINAR)
        Me.GroupBox2.Controls.Add(Me.Lista)
        Me.GroupBox2.Location = New System.Drawing.Point(228, 14)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(512, 249)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mantenimiento"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(304, 135)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "SALIR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BUSCAR
        '
        Me.BUSCAR.Location = New System.Drawing.Point(121, 22)
        Me.BUSCAR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BUSCAR.Name = "BUSCAR"
        Me.BUSCAR.Size = New System.Drawing.Size(143, 22)
        Me.BUSCAR.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Especialidad"
        '
        'BACTUALIZAR
        '
        Me.BACTUALIZAR.Enabled = False
        Me.BACTUALIZAR.Location = New System.Drawing.Point(304, 90)
        Me.BACTUALIZAR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BACTUALIZAR.Name = "BACTUALIZAR"
        Me.BACTUALIZAR.Size = New System.Drawing.Size(116, 23)
        Me.BACTUALIZAR.TabIndex = 2
        Me.BACTUALIZAR.Text = "ACTUALIZAR"
        Me.BACTUALIZAR.UseVisualStyleBackColor = True
        '
        'BELIMINAR
        '
        Me.BELIMINAR.Enabled = False
        Me.BELIMINAR.Location = New System.Drawing.Point(304, 52)
        Me.BELIMINAR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BELIMINAR.Name = "BELIMINAR"
        Me.BELIMINAR.Size = New System.Drawing.Size(116, 23)
        Me.BELIMINAR.TabIndex = 1
        Me.BELIMINAR.Text = "ELIMINAR"
        Me.BELIMINAR.UseVisualStyleBackColor = True
        '
        'Lista
        '
        Me.Lista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.Lista.FullRowSelect = True
        Me.Lista.GridLines = True
        Me.Lista.Location = New System.Drawing.Point(29, 52)
        Me.Lista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(235, 165)
        Me.Lista.TabIndex = 0
        Me.Lista.UseCompatibleStateImageBehavior = False
        Me.Lista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 33
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Especialidad"
        Me.ColumnHeader2.Width = 201
        '
        'frmTemporal_Especialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 283)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmTemporal_Especialidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmTemporal_Especialidad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BGuardar As Button
    Friend WithEvents ID As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lista As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents BUSCAR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BACTUALIZAR As Button
    Friend WithEvents BELIMINAR As Button
End Class
