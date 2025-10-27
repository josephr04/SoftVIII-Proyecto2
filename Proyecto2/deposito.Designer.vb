<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deposito
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label4 = New Label()
        TextBox1 = New TextBox()
        btnregistrardeposito = New Button()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(52, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(295, 31)
        Label1.TabIndex = 0
        Label1.Text = " Registrar Nuevo Depósito"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label2.Location = New Point(71, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 25)
        Label2.TabIndex = 1
        Label2.Text = "Tipo de Depósito:"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(71, 117)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(160, 28)
        ComboBox1.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label3.Location = New Point(71, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 25)
        Label3.TabIndex = 3
        Label3.Text = "Fecha del Depósito:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(71, 199)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(295, 27)
        DateTimePicker1.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label4.Location = New Point(71, 248)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 25)
        Label4.TabIndex = 5
        Label4.Text = "Monto ($):"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(179), CByte(196), CByte(214))
        TextBox1.Location = New Point(71, 276)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 6
        ' 
        ' btnregistrardeposito
        ' 
        btnregistrardeposito.BackColor = Color.FromArgb(CByte(15), CByte(131), CByte(229))
        btnregistrardeposito.Cursor = Cursors.Hand
        btnregistrardeposito.FlatAppearance.BorderSize = 0
        btnregistrardeposito.FlatStyle = FlatStyle.Flat
        btnregistrardeposito.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        btnregistrardeposito.ForeColor = Color.White
        btnregistrardeposito.Location = New Point(270, 276)
        btnregistrardeposito.Name = "btnregistrardeposito"
        btnregistrardeposito.Size = New Size(117, 39)
        btnregistrardeposito.TabIndex = 8
        btnregistrardeposito.Text = "Registrar"
        btnregistrardeposito.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label5.Location = New Point(685, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(252, 31)
        Label5.TabIndex = 9
        Label5.Text = "Historial de Depósitos"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Teal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3})
        DataGridView1.Location = New Point(606, 89)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 34
        DataGridView1.Size = New Size(416, 226)
        DataGridView1.TabIndex = 10
        ' 
        ' Column1
        ' 
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Column1.DefaultCellStyle = DataGridViewCellStyle2
        Column1.HeaderText = "Fecha"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 130
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Tipo"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Monto"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' deposito
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1170, 689)
        Controls.Add(DataGridView1)
        Controls.Add(Label5)
        Controls.Add(btnregistrardeposito)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "deposito"
        Text = "deposito"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnregistrardeposito As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
