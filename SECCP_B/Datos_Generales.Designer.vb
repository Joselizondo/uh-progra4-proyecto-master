<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Datos_Generales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Datos_Generales))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DIRECCION = New System.Windows.Forms.TextBox()
        Me.CORREO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AÑOS = New System.Windows.Forms.Label()
        Me.FechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TELCEL = New System.Windows.Forms.MaskedTextBox()
        Me.TELCASA = New System.Windows.Forms.MaskedTextBox()
        Me.FEMENINO = New System.Windows.Forms.RadioButton()
        Me.MASCULINO = New System.Windows.Forms.RadioButton()
        Me.SEGUNDOAPELLIDO = New System.Windows.Forms.TextBox()
        Me.PRIMERAPELLIDO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SEGUNDONOMBRE = New System.Windows.Forms.TextBox()
        Me.PRIMERNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PROFESION = New System.Windows.Forms.ComboBox()
        Me.ESCOLARIDAD = New System.Windows.Forms.ComboBox()
        Me.ESTADOCIV = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PAIS = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GUARDAR = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ABORTO = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.HERMANOS = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.FALLECIDO = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PREMATURO = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.VIVO = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.IDENTIFICACION = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.DIRECCION)
        Me.GroupBox1.Controls.Add(Me.CORREO)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.AÑOS)
        Me.GroupBox1.Controls.Add(Me.FechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.TELCEL)
        Me.GroupBox1.Controls.Add(Me.TELCASA)
        Me.GroupBox1.Controls.Add(Me.FEMENINO)
        Me.GroupBox1.Controls.Add(Me.MASCULINO)
        Me.GroupBox1.Controls.Add(Me.SEGUNDOAPELLIDO)
        Me.GroupBox1.Controls.Add(Me.PRIMERAPELLIDO)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.SEGUNDONOMBRE)
        Me.GroupBox1.Controls.Add(Me.PRIMERNOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1029, 365)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos generales del paciente"
        '
        'DIRECCION
        '
        Me.DIRECCION.Location = New System.Drawing.Point(113, 283)
        Me.DIRECCION.Multiline = True
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.Size = New System.Drawing.Size(862, 61)
        Me.DIRECCION.TabIndex = 11
        '
        'CORREO
        '
        Me.CORREO.Location = New System.Drawing.Point(689, 225)
        Me.CORREO.Name = "CORREO"
        Me.CORREO.Size = New System.Drawing.Size(286, 23)
        Me.CORREO.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(559, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Correo electronico"
        '
        'AÑOS
        '
        Me.AÑOS.AutoSize = True
        Me.AÑOS.Location = New System.Drawing.Point(432, 175)
        Me.AÑOS.Name = "AÑOS"
        Me.AÑOS.Size = New System.Drawing.Size(44, 17)
        Me.AÑOS.TabIndex = 20
        Me.AÑOS.Text = "Años"
        '
        'FechaNacimiento
        '
        Me.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaNacimiento.Location = New System.Drawing.Point(179, 170)
        Me.FechaNacimiento.Margin = New System.Windows.Forms.Padding(4)
        Me.FechaNacimiento.Name = "FechaNacimiento"
        Me.FechaNacimiento.Size = New System.Drawing.Size(123, 23)
        Me.FechaNacimiento.TabIndex = 7
        '
        'TELCEL
        '
        Me.TELCEL.Location = New System.Drawing.Point(397, 228)
        Me.TELCEL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TELCEL.Mask = "99999999"
        Me.TELCEL.Name = "TELCEL"
        Me.TELCEL.Size = New System.Drawing.Size(89, 23)
        Me.TELCEL.TabIndex = 9
        '
        'TELCASA
        '
        Me.TELCASA.Location = New System.Drawing.Point(113, 228)
        Me.TELCASA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TELCASA.Mask = "99999999"
        Me.TELCASA.Name = "TELCASA"
        Me.TELCASA.Size = New System.Drawing.Size(89, 23)
        Me.TELCASA.TabIndex = 8
        '
        'FEMENINO
        '
        Me.FEMENINO.AutoSize = True
        Me.FEMENINO.Location = New System.Drawing.Point(876, 72)
        Me.FEMENINO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FEMENINO.Name = "FEMENINO"
        Me.FEMENINO.Size = New System.Drawing.Size(99, 21)
        Me.FEMENINO.TabIndex = 6
        Me.FEMENINO.TabStop = True
        Me.FEMENINO.Text = "Femenino"
        Me.FEMENINO.UseVisualStyleBackColor = True
        '
        'MASCULINO
        '
        Me.MASCULINO.AutoSize = True
        Me.MASCULINO.Location = New System.Drawing.Point(753, 72)
        Me.MASCULINO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MASCULINO.Name = "MASCULINO"
        Me.MASCULINO.Size = New System.Drawing.Size(101, 21)
        Me.MASCULINO.TabIndex = 5
        Me.MASCULINO.TabStop = True
        Me.MASCULINO.Text = "Masculino"
        Me.MASCULINO.UseVisualStyleBackColor = True
        '
        'SEGUNDOAPELLIDO
        '
        Me.SEGUNDOAPELLIDO.Location = New System.Drawing.Point(484, 106)
        Me.SEGUNDOAPELLIDO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SEGUNDOAPELLIDO.Name = "SEGUNDOAPELLIDO"
        Me.SEGUNDOAPELLIDO.Size = New System.Drawing.Size(220, 23)
        Me.SEGUNDOAPELLIDO.TabIndex = 4
        '
        'PRIMERAPELLIDO
        '
        Me.PRIMERAPELLIDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRIMERAPELLIDO.Location = New System.Drawing.Point(113, 106)
        Me.PRIMERAPELLIDO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PRIMERAPELLIDO.Name = "PRIMERAPELLIDO"
        Me.PRIMERAPELLIDO.Size = New System.Drawing.Size(220, 22)
        Me.PRIMERAPELLIDO.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(7, 303)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Direccion"
        '
        'SEGUNDONOMBRE
        '
        Me.SEGUNDONOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEGUNDONOMBRE.Location = New System.Drawing.Point(484, 36)
        Me.SEGUNDONOMBRE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SEGUNDONOMBRE.Name = "SEGUNDONOMBRE"
        Me.SEGUNDONOMBRE.Size = New System.Drawing.Size(220, 22)
        Me.SEGUNDONOMBRE.TabIndex = 2
        '
        'PRIMERNOMBRE
        '
        Me.PRIMERNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRIMERNOMBRE.Location = New System.Drawing.Point(113, 39)
        Me.PRIMERNOMBRE.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PRIMERNOMBRE.Name = "PRIMERNOMBRE"
        Me.PRIMERNOMBRE.Size = New System.Drawing.Size(220, 22)
        Me.PRIMERNOMBRE.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(750, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Genero"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(275, 231)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Telefono celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Telefono casa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(361, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Edad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha de nacimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Segundo apellido"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(361, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Segundo nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Primer apellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Primer nombre"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.IDENTIFICACION)
        Me.GroupBox2.Controls.Add(Me.PROFESION)
        Me.GroupBox2.Controls.Add(Me.ESCOLARIDAD)
        Me.GroupBox2.Controls.Add(Me.ESTADOCIV)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.PAIS)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 437)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1029, 149)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documentos de indentidad"
        '
        'PROFESION
        '
        Me.PROFESION.FormattingEnabled = True
        Me.PROFESION.Location = New System.Drawing.Point(457, 92)
        Me.PROFESION.Name = "PROFESION"
        Me.PROFESION.Size = New System.Drawing.Size(205, 24)
        Me.PROFESION.TabIndex = 27
        '
        'ESCOLARIDAD
        '
        Me.ESCOLARIDAD.FormattingEnabled = True
        Me.ESCOLARIDAD.Items.AddRange(New Object() {"Primaria", "Secundaria", "Universitario", "Tecnico", "Ninguno"})
        Me.ESCOLARIDAD.Location = New System.Drawing.Point(141, 92)
        Me.ESCOLARIDAD.Name = "ESCOLARIDAD"
        Me.ESCOLARIDAD.Size = New System.Drawing.Size(163, 24)
        Me.ESCOLARIDAD.TabIndex = 15
        '
        'ESTADOCIV
        '
        Me.ESTADOCIV.FormattingEnabled = True
        Me.ESTADOCIV.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Union libre"})
        Me.ESTADOCIV.Location = New System.Drawing.Point(771, 31)
        Me.ESTADOCIV.Name = "ESTADOCIV"
        Me.ESTADOCIV.Size = New System.Drawing.Size(204, 24)
        Me.ESTADOCIV.TabIndex = 14
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(360, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 17)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Profesion"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(18, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 17)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Nivel escolaridad"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(686, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 17)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Estado civil"
        '
        'PAIS
        '
        Me.PAIS.FormattingEnabled = True
        Me.PAIS.Items.AddRange(New Object() {"Afganistán", "Albania", "Alemania", "Andorra", "Angola", "Antigua y Barbuda", "Arabia Saudita", "Argelia", "Argentina", "Armenia", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bangladés", "Barbados", "Baréin", "Bélgica", "Belice", "Benín", "Bielorrusia", "Birmania", "Bolivia", "Bosnia y Herzegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Catar", "Chad", "Chile", "China", "Chipre", "Ciudad del Vaticano", "Colombia", "Comoras", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Georgia", "Ghana", "Granada", "Grecia", "Guatemala", "Guyana", "Guinea", "Guinea ecuatorial", "Guinea-Bisáu", "Haití", "Honduras", "Hungría", "India", "Indonesia", "Irak", "Irán", "Irlanda", "Islandia", "Islas Marshall", "Islas Salomón", "Israel", "Italia", "Jamaica", "Japón", "Jordania", "Kazajistán", "Kenia", "Kirguistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Marruecos", "Mauricio", "Mauritania", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montenegro", "Mozambique", "Namibia", "Nauru", "Nepal", "Nicaragua", "Níger", "Nigeria", "Noruega", "Nueva Zelanda", "Omán", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa Nueva Guinea", "Paraguay", "Perú", "Polonia", "Portugal", "Reino Unido", "República Centroafricana", "República Checa", "República de Macedonia", "República del Congo", "República Democrática del Congo", "República Dominicana", "República Sudafricana", "Ruanda", "Rumanía", "Rusia", "Samoa", "San Cristóbal y Nieves", "San Marino", "San Vicente y las Granadinas", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Serbia", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Sri Lanka", "Suazilandia", "Sudán", "Sudán del Sur", "Suecia", "Suiza", "Surinam", "Tailandia", "Tanzania", "Tayikistán", "Timor Oriental", "Togo", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Yemen", "Yibuti", "Zambia", "Zimbabue"})
        Me.PAIS.Location = New System.Drawing.Point(121, 29)
        Me.PAIS.Name = "PAIS"
        Me.PAIS.Size = New System.Drawing.Size(183, 24)
        Me.PAIS.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 17)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Pais"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(361, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Identificación"
        '
        'GUARDAR
        '
        Me.GUARDAR.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.GUARDAR.FlatAppearance.BorderSize = 0
        Me.GUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.GUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.GUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GUARDAR.ForeColor = System.Drawing.Color.White
        Me.GUARDAR.Image = Global.SECCP_B.My.Resources.Resources.guardar1
        Me.GUARDAR.Location = New System.Drawing.Point(878, 720)
        Me.GUARDAR.Margin = New System.Windows.Forms.Padding(4)
        Me.GUARDAR.Name = "GUARDAR"
        Me.GUARDAR.Size = New System.Drawing.Size(172, 54)
        Me.GUARDAR.TabIndex = 9
        Me.GUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GUARDAR.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(1015, 15)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(36, 36)
        Me.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnCerrar.TabIndex = 6
        Me.BtnCerrar.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ABORTO)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.HERMANOS)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.FALLECIDO)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.PREMATURO)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.VIVO)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 604)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1030, 109)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial de familia"
        '
        'ABORTO
        '
        Me.ABORTO.Location = New System.Drawing.Point(544, 68)
        Me.ABORTO.Name = "ABORTO"
        Me.ABORTO.Size = New System.Drawing.Size(45, 22)
        Me.ABORTO.TabIndex = 20
        Me.ABORTO.Text = "0"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label22.Location = New System.Drawing.Point(481, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(57, 17)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Abortos"
        '
        'HERMANOS
        '
        Me.HERMANOS.Location = New System.Drawing.Point(927, 28)
        Me.HERMANOS.Name = "HERMANOS"
        Me.HERMANOS.Size = New System.Drawing.Size(48, 22)
        Me.HERMANOS.TabIndex = 21
        Me.HERMANOS.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(750, 33)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(171, 17)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Cantidad de hermanos"
        '
        'FALLECIDO
        '
        Me.FALLECIDO.Location = New System.Drawing.Point(406, 68)
        Me.FALLECIDO.Name = "FALLECIDO"
        Me.FALLECIDO.Size = New System.Drawing.Size(45, 22)
        Me.FALLECIDO.TabIndex = 19
        Me.FALLECIDO.Text = "0"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label20.Location = New System.Drawing.Point(154, 70)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 17)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Prematuros"
        '
        'PREMATURO
        '
        Me.PREMATURO.Location = New System.Drawing.Point(241, 68)
        Me.PREMATURO.Name = "PREMATURO"
        Me.PREMATURO.Size = New System.Drawing.Size(45, 22)
        Me.PREMATURO.TabIndex = 18
        Me.PREMATURO.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label19.Location = New System.Drawing.Point(331, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 17)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Fallecidos"
        '
        'VIVO
        '
        Me.VIVO.Location = New System.Drawing.Point(80, 68)
        Me.VIVO.Name = "VIVO"
        Me.VIVO.Size = New System.Drawing.Size(45, 22)
        Me.VIVO.TabIndex = 17
        Me.VIVO.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(32, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(42, 17)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Vivos"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(238, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 17)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Cantidad de hijos"
        '
        'IDENTIFICACION
        '
        Me.IDENTIFICACION.Location = New System.Drawing.Point(460, 33)
        Me.IDENTIFICACION.Mask = "999999999"
        Me.IDENTIFICACION.Name = "IDENTIFICACION"
        Me.IDENTIFICACION.Size = New System.Drawing.Size(202, 23)
        Me.IDENTIFICACION.TabIndex = 28
        '
        'Datos_Generales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1067, 787)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GUARDAR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Datos_Generales"
        Me.Text = "Datos_Generales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BtnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents SEGUNDONOMBRE As TextBox
    Friend WithEvents PRIMERNOMBRE As TextBox
    Friend WithEvents TELCEL As MaskedTextBox
    Friend WithEvents TELCASA As MaskedTextBox
    Friend WithEvents FEMENINO As RadioButton
    Friend WithEvents MASCULINO As RadioButton
    Friend WithEvents SEGUNDOAPELLIDO As TextBox
    Friend WithEvents PRIMERAPELLIDO As TextBox
    Friend WithEvents FechaNacimiento As DateTimePicker
    Friend WithEvents AÑOS As Label
    Friend WithEvents GUARDAR As Button
    Friend WithEvents DIRECCION As TextBox
    Friend WithEvents CORREO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ESCOLARIDAD As ComboBox
    Friend WithEvents ESTADOCIV As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PAIS As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents FALLECIDO As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents PREMATURO As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents VIVO As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ABORTO As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents HERMANOS As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents PROFESION As ComboBox
    Friend WithEvents IDENTIFICACION As MaskedTextBox
End Class
