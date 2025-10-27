<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        PictureBox1 = New PictureBox()
        txtusuario = New TextBox()
        txtcontraseña = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        btniniciarsesion = New Button()
        btnsalir = New Button()
        pbcontraseña = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbcontraseña, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(207, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' txtusuario
        ' 
        txtusuario.BackColor = Color.FromArgb(CByte(179), CByte(196), CByte(214))
        txtusuario.BorderStyle = BorderStyle.None
        txtusuario.Location = New Point(179, 264)
        txtusuario.Multiline = True
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(202, 33)
        txtusuario.TabIndex = 1
        ' 
        ' txtcontraseña
        ' 
        txtcontraseña.BackColor = Color.FromArgb(CByte(179), CByte(196), CByte(214))
        txtcontraseña.BorderStyle = BorderStyle.None
        txtcontraseña.Location = New Point(179, 346)
        txtcontraseña.Multiline = True
        txtcontraseña.Name = "txtcontraseña"
        txtcontraseña.PasswordChar = "*"c
        txtcontraseña.Size = New Size(202, 33)
        txtcontraseña.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(179, 231)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 30)
        Label2.TabIndex = 3
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(179, 313)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 30)
        Label3.TabIndex = 4
        Label3.Text = "Contraseña"
        ' 
        ' btniniciarsesion
        ' 
        btniniciarsesion.BackColor = Color.FromArgb(CByte(137), CByte(27), CByte(227))
        btniniciarsesion.Cursor = Cursors.Hand
        btniniciarsesion.FlatAppearance.BorderSize = 0
        btniniciarsesion.FlatStyle = FlatStyle.Flat
        btniniciarsesion.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btniniciarsesion.ForeColor = Color.White
        btniniciarsesion.Location = New Point(179, 414)
        btniniciarsesion.Name = "btniniciarsesion"
        btniniciarsesion.Size = New Size(202, 39)
        btniniciarsesion.TabIndex = 5
        btniniciarsesion.Text = "Iniciar Sesión"
        btniniciarsesion.UseVisualStyleBackColor = False
        ' 
        ' btnsalir
        ' 
        btnsalir.BackColor = Color.White
        btnsalir.FlatStyle = FlatStyle.Flat
        btnsalir.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnsalir.ForeColor = Color.Black
        btnsalir.Image = CType(resources.GetObject("btnsalir.Image"), Image)
        btnsalir.Location = New Point(12, 12)
        btnsalir.Name = "btnsalir"
        btnsalir.Size = New Size(52, 42)
        btnsalir.TabIndex = 6
        btnsalir.UseVisualStyleBackColor = False
        ' 
        ' pbcontraseña
        ' 
        pbcontraseña.Image = My.Resources.Resources.show
        pbcontraseña.Location = New Point(387, 346)
        pbcontraseña.Name = "pbcontraseña"
        pbcontraseña.Size = New Size(40, 33)
        pbcontraseña.SizeMode = PictureBoxSizeMode.Zoom
        pbcontraseña.TabIndex = 7
        pbcontraseña.TabStop = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(569, 616)
        Controls.Add(pbcontraseña)
        Controls.Add(btnsalir)
        Controls.Add(btniniciarsesion)
        Controls.Add(Label3)
        Controls.Add(txtcontraseña)
        Controls.Add(Label2)
        Controls.Add(txtusuario)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbcontraseña, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub




    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btniniciarsesion As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents pbcontraseña As PictureBox

End Class
