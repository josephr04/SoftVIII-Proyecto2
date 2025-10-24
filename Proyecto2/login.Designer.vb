<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        Label1.Location = New Point(244, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(149, 30)
        Label1.TabIndex = 0
        Label1.Text = "Iniciar Sesión"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(254, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(140, 84)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(223, 226)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(202, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label2.Location = New Point(223, 200)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 23)
        Label2.TabIndex = 3
        Label2.Text = "Usuario"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label3.Location = New Point(223, 277)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 23)
        Label3.TabIndex = 5
        Label3.Text = "Contraseña"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(223, 300)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(202, 27)
        TextBox2.TabIndex = 4
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(667, 463)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        Text = "login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
