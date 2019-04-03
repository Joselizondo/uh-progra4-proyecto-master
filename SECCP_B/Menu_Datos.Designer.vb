<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Datos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu_Datos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btncperdidas = New System.Windows.Forms.Button()
        Me.btndgenerales = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Datos Generales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(380, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Citas Perdidas"
        '
        'btncperdidas
        '
        Me.btncperdidas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncperdidas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncperdidas.FlatAppearance.BorderSize = 0
        Me.btncperdidas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btncperdidas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btncperdidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncperdidas.ForeColor = System.Drawing.Color.White
        Me.btncperdidas.Image = Global.SECCP_B.My.Resources.Resources.Calendario_Perdidas
        Me.btncperdidas.Location = New System.Drawing.Point(384, 150)
        Me.btncperdidas.Name = "btncperdidas"
        Me.btncperdidas.Size = New System.Drawing.Size(144, 131)
        Me.btncperdidas.TabIndex = 10
        Me.btncperdidas.UseVisualStyleBackColor = True
        '
        'btndgenerales
        '
        Me.btndgenerales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndgenerales.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btndgenerales.FlatAppearance.BorderSize = 0
        Me.btndgenerales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btndgenerales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btndgenerales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndgenerales.ForeColor = System.Drawing.Color.White
        Me.btndgenerales.Image = Global.SECCP_B.My.Resources.Resources.Calendario_Citas_300x300
        Me.btndgenerales.Location = New System.Drawing.Point(144, 150)
        Me.btndgenerales.Name = "btndgenerales"
        Me.btndgenerales.Size = New System.Drawing.Size(144, 131)
        Me.btndgenerales.TabIndex = 8
        Me.btndgenerales.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(745, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(27, 29)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 7
        Me.BtnCerrar.TabStop = False
        '
        'Menu_Datos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btncperdidas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btndgenerales)
        Me.Controls.Add(Me.BtnCerrar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Menu_Datos"
        Me.Text = "Menu_Datos"
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents btndgenerales As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btncperdidas As Button
End Class
