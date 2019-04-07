<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnlogin = New System.Windows.Forms.PictureBox()
        Me.usuariologeado = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.BtnMaximizar = New System.Windows.Forms.PictureBox()
        Me.BtnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BtnOcultar = New System.Windows.Forms.PictureBox()
        Me.BtnAjustar = New System.Windows.Forms.PictureBox()
        Me.PanelCentral = New System.Windows.Forms.Panel()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.BtnContraseña = New System.Windows.Forms.Button()
        Me.BtnCitas = New System.Windows.Forms.Button()
        Me.BtnBusqueda = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelSuperior.SuspendLayout()
        CType(Me.btnlogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnOcultar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAjustar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLateral.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.White
        Me.PanelSuperior.Controls.Add(Me.btnlogin)
        Me.PanelSuperior.Controls.Add(Me.usuariologeado)
        Me.PanelSuperior.Controls.Add(Me.BtnCerrar)
        Me.PanelSuperior.Controls.Add(Me.BtnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.BtnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.BtnOcultar)
        Me.PanelSuperior.Controls.Add(Me.BtnAjustar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(263, 0)
        Me.PanelSuperior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1070, 145)
        Me.PanelSuperior.TabIndex = 1
        '
        'btnlogin
        '
        Me.btnlogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.Image = Global.SECCP_B.My.Resources.Resources.Login
        Me.btnlogin.Location = New System.Drawing.Point(651, 50)
        Me.btnlogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(52, 43)
        Me.btnlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnlogin.TabIndex = 6
        Me.btnlogin.TabStop = False
        '
        'usuariologeado
        '
        Me.usuariologeado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usuariologeado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usuariologeado.Location = New System.Drawing.Point(711, 66)
        Me.usuariologeado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.usuariologeado.Name = "usuariologeado"
        Me.usuariologeado.Size = New System.Drawing.Size(220, 27)
        Me.usuariologeado.TabIndex = 5
        Me.usuariologeado.Text = "No logueado"
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(1018, 50)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(36, 36)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.TabStop = False
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.Image = CType(resources.GetObject("BtnMaximizar.Image"), System.Drawing.Image)
        Me.BtnMaximizar.Location = New System.Drawing.Point(974, 50)
        Me.BtnMaximizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(36, 36)
        Me.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMaximizar.TabIndex = 3
        Me.BtnMaximizar.TabStop = False
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.Image = CType(resources.GetObject("BtnMinimizar.Image"), System.Drawing.Image)
        Me.BtnMinimizar.Location = New System.Drawing.Point(930, 50)
        Me.BtnMinimizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(36, 36)
        Me.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMinimizar.TabIndex = 1
        Me.BtnMinimizar.TabStop = False
        '
        'BtnOcultar
        '
        Me.BtnOcultar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOcultar.Image = CType(resources.GetObject("BtnOcultar.Image"), System.Drawing.Image)
        Me.BtnOcultar.Location = New System.Drawing.Point(39, 50)
        Me.BtnOcultar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnOcultar.Name = "BtnOcultar"
        Me.BtnOcultar.Size = New System.Drawing.Size(44, 36)
        Me.BtnOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnOcultar.TabIndex = 0
        Me.BtnOcultar.TabStop = False
        '
        'BtnAjustar
        '
        Me.BtnAjustar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAjustar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAjustar.Image = CType(resources.GetObject("BtnAjustar.Image"), System.Drawing.Image)
        Me.BtnAjustar.Location = New System.Drawing.Point(974, 50)
        Me.BtnAjustar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnAjustar.Name = "BtnAjustar"
        Me.BtnAjustar.Size = New System.Drawing.Size(36, 36)
        Me.BtnAjustar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnAjustar.TabIndex = 2
        Me.BtnAjustar.TabStop = False
        Me.BtnAjustar.Visible = False
        '
        'PanelCentral
        '
        Me.PanelCentral.BackColor = System.Drawing.Color.White
        Me.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelCentral.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.PanelCentral.Location = New System.Drawing.Point(263, 145)
        Me.PanelCentral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCentral.Name = "PanelCentral"
        Me.PanelCentral.Size = New System.Drawing.Size(1070, 717)
        Me.PanelCentral.TabIndex = 0
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.White
        Me.PanelLateral.BackgroundImage = CType(resources.GetObject("PanelLateral.BackgroundImage"), System.Drawing.Image)
        Me.PanelLateral.Controls.Add(Me.Button1)
        Me.PanelLateral.Controls.Add(Me.BtnUsuarios)
        Me.PanelLateral.Controls.Add(Me.BtnContraseña)
        Me.PanelLateral.Controls.Add(Me.BtnCitas)
        Me.PanelLateral.Controls.Add(Me.BtnBusqueda)
        Me.PanelLateral.Controls.Add(Me.PictureBox1)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 0)
        Me.PanelLateral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(263, 862)
        Me.PanelLateral.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(27, 625)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(236, 113)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "                            LOG-OUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnUsuarios.Image = CType(resources.GetObject("BtnUsuarios.Image"), System.Drawing.Image)
        Me.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarios.Location = New System.Drawing.Point(27, 384)
        Me.BtnUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(236, 113)
        Me.BtnUsuarios.TabIndex = 7
        Me.BtnUsuarios.Text = "               ""USUARIOS"""
        Me.BtnUsuarios.UseVisualStyleBackColor = False
        '
        'BtnContraseña
        '
        Me.BtnContraseña.BackColor = System.Drawing.Color.Transparent
        Me.BtnContraseña.FlatAppearance.BorderSize = 0
        Me.BtnContraseña.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContraseña.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContraseña.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnContraseña.Image = CType(resources.GetObject("BtnContraseña.Image"), System.Drawing.Image)
        Me.BtnContraseña.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnContraseña.Location = New System.Drawing.Point(27, 505)
        Me.BtnContraseña.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnContraseña.Name = "BtnContraseña"
        Me.BtnContraseña.Size = New System.Drawing.Size(236, 113)
        Me.BtnContraseña.TabIndex = 8
        Me.BtnContraseña.Text = "                        CAMBIAR                        CONTRASEÑA"
        Me.BtnContraseña.UseVisualStyleBackColor = False
        '
        'BtnCitas
        '
        Me.BtnCitas.BackColor = System.Drawing.Color.Transparent
        Me.BtnCitas.FlatAppearance.BorderSize = 0
        Me.BtnCitas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCitas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCitas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnCitas.Image = CType(resources.GetObject("BtnCitas.Image"), System.Drawing.Image)
        Me.BtnCitas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCitas.Location = New System.Drawing.Point(27, 263)
        Me.BtnCitas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCitas.Name = "BtnCitas"
        Me.BtnCitas.Size = New System.Drawing.Size(236, 113)
        Me.BtnCitas.TabIndex = 6
        Me.BtnCitas.Text = "               ASIGNAR CITAS"
        Me.BtnCitas.UseVisualStyleBackColor = False
        '
        'BtnBusqueda
        '
        Me.BtnBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.BtnBusqueda.FlatAppearance.BorderSize = 0
        Me.BtnBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BtnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBusqueda.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.BtnBusqueda.Image = CType(resources.GetObject("BtnBusqueda.Image"), System.Drawing.Image)
        Me.BtnBusqueda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBusqueda.Location = New System.Drawing.Point(27, 143)
        Me.BtnBusqueda.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnBusqueda.Name = "BtnBusqueda"
        Me.BtnBusqueda.Size = New System.Drawing.Size(236, 113)
        Me.BtnBusqueda.TabIndex = 5
        Me.BtnBusqueda.Text = "               BUSQUEDAS"
        Me.BtnBusqueda.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(79, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1333, 862)
        Me.Controls.Add(Me.PanelCentral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.Controls.Add(Me.PanelLateral)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelSuperior.ResumeLayout(False)
        CType(Me.btnlogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnOcultar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAjustar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLateral.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelCentral As Panel
    Friend WithEvents BtnOcultar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents BtnMaximizar As PictureBox
    Friend WithEvents BtnAjustar As PictureBox
    Friend WithEvents BtnMinimizar As PictureBox
    Friend WithEvents BtnBusqueda As Button
    Friend WithEvents BtnContraseña As Button
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents BtnCitas As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents usuariologeado As Label
    Friend WithEvents btnlogin As PictureBox
End Class
