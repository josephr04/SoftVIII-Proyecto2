<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cheque
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
        lblcheck = New Label()
        Me.PoisonDateTimeCheque = New TextBox()
        PoisonDateTimeCheque = New ReaLTaiizor.Controls.PoisonDateTime()
        Label1 = New Label()
        Label2 = New Label()
        AloneComboBox1 = New ReaLTaiizor.Controls.AloneComboBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        AloneComboBox2 = New ReaLTaiizor.Controls.AloneComboBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' lblcheck
        ' 
        lblcheck.AutoSize = True
        lblcheck.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblcheck.Location = New Point(62, 26)
        lblcheck.Name = "lblcheck"
        lblcheck.Size = New Size(170, 23)
        lblcheck.TabIndex = 0
        lblcheck.Text = "Número de Cheque:"
        ' 
        ' Txteditarcheque
        ' 
        Me.Txteditarcheque.Location = New Point(65, 52)
        Me.Txteditarcheque.Multiline = True
        Me.Txteditarcheque.Name = "Txteditarcheque"
        Me.Txteditarcheque.Size = New Size(181, 30)
        Me.Txteditarcheque.TabIndex = 1
        ' 
        ' PoisonDateTimeCheque
        ' 
        PoisonDateTimeCheque.CalendarFont = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PoisonDateTimeCheque.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        PoisonDateTimeCheque.Location = New Point(62, 128)
        PoisonDateTimeCheque.MinimumSize = New Size(0, 30)
        PoisonDateTimeCheque.Name = "PoisonDateTimeCheque"
        PoisonDateTimeCheque.Size = New Size(256, 30)
        PoisonDateTimeCheque.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label1.Location = New Point(65, 102)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 23)
        Label1.TabIndex = 3
        Label1.Text = "Fecha de Cheque:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.Location = New Point(65, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 23)
        Label2.TabIndex = 4
        Label2.Text = "Proveedor"
        ' 
        ' AloneComboBox1
        ' 
        AloneComboBox1.DrawMode = DrawMode.OwnerDrawFixed
        AloneComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        AloneComboBox1.EnabledCalc = True
        AloneComboBox1.FormattingEnabled = True
        AloneComboBox1.ItemHeight = 20
        AloneComboBox1.Location = New Point(62, 203)
        AloneComboBox1.Name = "AloneComboBox1"
        AloneComboBox1.Size = New Size(170, 26)
        AloneComboBox1.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(65, 276)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(181, 30)
        TextBox2.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.Location = New Point(65, 250)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 23)
        Label3.TabIndex = 10
        Label3.Text = "Monto Númerico"
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Window
        TextBox3.Location = New Point(65, 329)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(181, 30)
        TextBox3.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label4.Location = New Point(381, 31)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 23)
        Label4.TabIndex = 12
        Label4.Text = "Detalle"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(360, 74)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(298, 84)
        TextBox4.TabIndex = 13
        ' 
        ' AloneComboBox2
        ' 
        AloneComboBox2.DrawMode = DrawMode.OwnerDrawFixed
        AloneComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        AloneComboBox2.EnabledCalc = True
        AloneComboBox2.FormattingEnabled = True
        AloneComboBox2.ItemHeight = 20
        AloneComboBox2.Location = New Point(360, 225)
        AloneComboBox2.Name = "AloneComboBox2"
        AloneComboBox2.Size = New Size(170, 26)
        AloneComboBox2.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label5.Location = New Point(360, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 23)
        Label5.TabIndex = 15
        Label5.Text = "Objeto de Gasto"
        ' 
        ' cheque
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 526)
        Controls.Add(Label5)
        Controls.Add(AloneComboBox2)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(AloneComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PoisonDateTimeCheque)
        Controls.Add(Me.Txteditarcheque)
        Controls.Add(lblcheck)
        Name = "cheque"
        Text = "cheque"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblcheck As Label
    Public Property TxtBox1 As TextBox
    Public Property Txteditarcheque As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PoisonDateTimeCheque As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AloneComboBox1 As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents AloneComboBox2 As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents Label5 As Label
End Class
