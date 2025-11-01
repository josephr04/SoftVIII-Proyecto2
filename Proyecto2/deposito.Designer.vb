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
        cbotiposdeposito = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        btnregistrardeposito = New Button()
        Label5 = New Label()
        DataGridViewdep = New DataGridView()
        fecha = New DataGridViewTextBoxColumn()
        tipo = New DataGridViewTextBoxColumn()
        monto = New DataGridViewTextBoxColumn()
        txtmontodep = New ReaLTaiizor.Controls.AloneTextBox()
        Panel1 = New Panel()
        btncancelardep = New Button()
        PoisonDateTimeDeposito = New ReaLTaiizor.Controls.PoisonDateTime()
        CType(DataGridViewdep, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(284, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(295, 31)
        Label1.TabIndex = 0
        Label1.Text = " Registrar Nuevo Depósito"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label2.Location = New Point(303, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 25)
        Label2.TabIndex = 1
        Label2.Text = "Tipo de Depósito:"
        ' 
        ' cbotiposdeposito
        ' 
        cbotiposdeposito.DropDownStyle = ComboBoxStyle.DropDownList
        cbotiposdeposito.FormattingEnabled = True
        cbotiposdeposito.Items.AddRange(New Object() {"Transferencia", "Depósito Directo"})
        cbotiposdeposito.Location = New Point(303, 158)
        cbotiposdeposito.Name = "cbotiposdeposito"
        cbotiposdeposito.Size = New Size(200, 28)
        cbotiposdeposito.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label3.Location = New Point(303, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 25)
        Label3.TabIndex = 3
        Label3.Text = "Fecha del Depósito:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label4.Location = New Point(303, 289)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 25)
        Label4.TabIndex = 5
        Label4.Text = "Monto ($):"
        ' 
        ' btnregistrardeposito
        ' 
        btnregistrardeposito.BackColor = Color.FromArgb(CByte(15), CByte(131), CByte(229))
        btnregistrardeposito.Cursor = Cursors.Hand
        btnregistrardeposito.FlatAppearance.BorderSize = 0
        btnregistrardeposito.FlatStyle = FlatStyle.Flat
        btnregistrardeposito.Font = New Font("Segoe UI", 12F)
        btnregistrardeposito.ForeColor = Color.White
        btnregistrardeposito.Location = New Point(408, 263)
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
        Label5.Location = New Point(405, 422)
        Label5.Name = "Label5"
        Label5.Size = New Size(252, 31)
        Label5.TabIndex = 9
        Label5.Text = "Historial de Depósitos"
        ' 
        ' DataGridViewdep
        ' 
        DataGridViewdep.BackgroundColor = Color.Teal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridViewdep.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewdep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewdep.Columns.AddRange(New DataGridViewColumn() {fecha, tipo, monto})
        DataGridViewdep.Location = New Point(320, 456)
        DataGridViewdep.Name = "DataGridViewdep"
        DataGridViewdep.RowHeadersWidth = 34
        DataGridViewdep.Size = New Size(416, 226)
        DataGridViewdep.TabIndex = 10
        ' 
        ' fecha
        ' 
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fecha.DefaultCellStyle = DataGridViewCellStyle2
        fecha.HeaderText = "Fecha"
        fecha.MinimumWidth = 6
        fecha.Name = "fecha"
        fecha.Width = 130
        ' 
        ' tipo
        ' 
        tipo.HeaderText = "Tipo"
        tipo.MinimumWidth = 6
        tipo.Name = "tipo"
        tipo.Width = 125
        ' 
        ' monto
        ' 
        monto.HeaderText = "Monto"
        monto.MinimumWidth = 6
        monto.Name = "monto"
        monto.Width = 125
        ' 
        ' txtmontodep
        ' 
        txtmontodep.BackColor = Color.Transparent
        txtmontodep.EnabledCalc = True
        txtmontodep.Font = New Font("Segoe UI", 9F)
        txtmontodep.ForeColor = Color.FromArgb(CByte(124), CByte(133), CByte(142))
        txtmontodep.Location = New Point(303, 320)
        txtmontodep.MaxLength = 32767
        txtmontodep.MultiLine = False
        txtmontodep.Name = "txtmontodep"
        txtmontodep.ReadOnly = False
        txtmontodep.Size = New Size(200, 36)
        txtmontodep.TabIndex = 22
        txtmontodep.TextAlign = HorizontalAlignment.Left
        txtmontodep.UseSystemPasswordChar = False
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btncancelardep)
        Panel1.Controls.Add(PoisonDateTimeDeposito)
        Panel1.Controls.Add(btnregistrardeposito)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(266, 53)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(543, 328)
        Panel1.TabIndex = 24
        ' 
        ' btncancelardep
        ' 
        btncancelardep.BackColor = SystemColors.ScrollBar
        btncancelardep.Cursor = Cursors.Hand
        btncancelardep.FlatAppearance.BorderSize = 0
        btncancelardep.FlatStyle = FlatStyle.Flat
        btncancelardep.Font = New Font("Segoe UI", 12F)
        btncancelardep.ForeColor = SystemColors.ControlText
        btncancelardep.Location = New Point(255, 263)
        btncancelardep.Name = "btncancelardep"
        btncancelardep.Size = New Size(138, 39)
        btncancelardep.TabIndex = 26
        btncancelardep.Text = "Cancelar"
        btncancelardep.UseVisualStyleBackColor = False
        ' 
        ' PoisonDateTimeDeposito
        ' 
        PoisonDateTimeDeposito.CalendarFont = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PoisonDateTimeDeposito.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        PoisonDateTimeDeposito.Location = New Point(36, 186)
        PoisonDateTimeDeposito.MinimumSize = New Size(0, 30)
        PoisonDateTimeDeposito.Name = "PoisonDateTimeDeposito"
        PoisonDateTimeDeposito.Size = New Size(200, 30)
        PoisonDateTimeDeposito.TabIndex = 25
        ' 
        ' deposito
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1170, 689)
        Controls.Add(txtmontodep)
        Controls.Add(DataGridViewdep)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(cbotiposdeposito)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "deposito"
        Text = "deposito"
        CType(DataGridViewdep, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbotiposdeposito As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnregistrardeposito As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridViewdep As DataGridView
    Friend WithEvents txtmontodep As ReaLTaiizor.Controls.AloneTextBox
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents tipo As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PoisonDateTimeDeposito As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents btncancelardep As Button
End Class
