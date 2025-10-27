<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btnregistrar
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
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblcheck = New Label()
        PoisonDateTimeCheque = New ReaLTaiizor.Controls.PoisonDateTime()
        Label1 = New Label()
        Label2 = New Label()
        cboproveedor = New ReaLTaiizor.Controls.AloneComboBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox4 = New TextBox()
        cbogasto = New ReaLTaiizor.Controls.AloneComboBox()
        Label5 = New Label()
        txtnumerochk = New TextBox()
        DataGridView1 = New DataGridView()
        numerochk = New DataGridViewTextBoxColumn()
        fechachk = New DataGridViewTextBoxColumn()
        proveedor = New DataGridViewTextBoxColumn()
        monto = New DataGridViewTextBoxColumn()
        detalle = New DataGridViewTextBoxColumn()
        objgasto = New DataGridViewTextBoxColumn()
        acciones = New DataGridViewTextBoxColumn()
        btniniciarsesion = New Button()
        Label6 = New Label()
        Label7 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblcheck
        ' 
        lblcheck.AutoSize = True
        lblcheck.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblcheck.Location = New Point(265, 384)
        lblcheck.Name = "lblcheck"
        lblcheck.Size = New Size(185, 25)
        lblcheck.TabIndex = 0
        lblcheck.Text = "Número de Cheque"
        ' 
        ' PoisonDateTimeCheque
        ' 
        PoisonDateTimeCheque.CalendarFont = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PoisonDateTimeCheque.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        PoisonDateTimeCheque.Location = New Point(511, 412)
        PoisonDateTimeCheque.MinimumSize = New Size(0, 30)
        PoisonDateTimeCheque.Name = "PoisonDateTimeCheque"
        PoisonDateTimeCheque.Size = New Size(245, 30)
        PoisonDateTimeCheque.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label1.Location = New Point(551, 384)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 25)
        Label1.TabIndex = 3
        Label1.Text = "Fecha de Cheque"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label2.Location = New Point(654, 594)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 25)
        Label2.TabIndex = 4
        Label2.Text = "Proveedor"
        ' 
        ' cboproveedor
        ' 
        cboproveedor.DrawMode = DrawMode.OwnerDrawFixed
        cboproveedor.DropDownStyle = ComboBoxStyle.DropDownList
        cboproveedor.EnabledCalc = True
        cboproveedor.FormattingEnabled = True
        cboproveedor.ItemHeight = 20
        cboproveedor.Location = New Point(596, 622)
        cboproveedor.Name = "cboproveedor"
        cboproveedor.Size = New Size(245, 26)
        cboproveedor.TabIndex = 8
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(179), CByte(196), CByte(214))
        TextBox2.BorderStyle = BorderStyle.None
        TextBox2.Location = New Point(259, 489)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(181, 30)
        TextBox2.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label3.Location = New Point(311, 461)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 25)
        Label3.TabIndex = 10
        Label3.Text = "Monto "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label4.Location = New Point(311, 579)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 25)
        Label4.TabIndex = 12
        Label4.Text = "Detalle"
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.FromArgb(CByte(179), CByte(196), CByte(214))
        TextBox4.BorderStyle = BorderStyle.None
        TextBox4.Location = New Point(246, 607)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Ingrese el detalle del cheque..."
        TextBox4.Size = New Size(211, 66)
        TextBox4.TabIndex = 13
        ' 
        ' cbogasto
        ' 
        cbogasto.BackColor = Color.FromArgb(CByte(179), CByte(196), CByte(214))
        cbogasto.DrawMode = DrawMode.OwnerDrawFixed
        cbogasto.DropDownStyle = ComboBoxStyle.DropDownList
        cbogasto.EnabledCalc = True
        cbogasto.FormattingEnabled = True
        cbogasto.ItemHeight = 20
        cbogasto.Location = New Point(596, 517)
        cbogasto.Name = "cbogasto"
        cbogasto.Size = New Size(245, 26)
        cbogasto.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        Label5.Location = New Point(636, 485)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 25)
        Label5.TabIndex = 15
        Label5.Text = "Objeto de Gasto"
        ' 
        ' txtnumerochk
        ' 
        txtnumerochk.BackColor = Color.FromArgb(CByte(179), CByte(196), CByte(214))
        txtnumerochk.BorderStyle = BorderStyle.None
        txtnumerochk.Location = New Point(265, 412)
        txtnumerochk.Multiline = True
        txtnumerochk.Name = "txtnumerochk"
        txtnumerochk.ReadOnly = True
        txtnumerochk.Size = New Size(181, 30)
        txtnumerochk.TabIndex = 16
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = Color.Black
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.BackgroundColor = Color.Teal
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 11.0F)
        DataGridViewCellStyle4.ForeColor = Color.Black
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {numerochk, fechachk, proveedor, monto, detalle, objgasto, acciones})
        DataGridView1.GridColor = Color.FromArgb(CByte(195), CByte(157), CByte(230))
        DataGridView1.Location = New Point(156, 74)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(874, 245)
        DataGridView1.TabIndex = 17
        ' 
        ' numerochk
        ' 
        numerochk.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        numerochk.HeaderText = "Número de Cheque"
        numerochk.MinimumWidth = 6
        numerochk.Name = "numerochk"
        numerochk.Width = 140
        ' 
        ' fechachk
        ' 
        fechachk.HeaderText = "Fecha de Cheque"
        fechachk.MinimumWidth = 6
        fechachk.Name = "fechachk"
        fechachk.Width = 125
        ' 
        ' proveedor
        ' 
        proveedor.HeaderText = "Proveedor"
        proveedor.MinimumWidth = 6
        proveedor.Name = "proveedor"
        proveedor.Width = 125
        ' 
        ' monto
        ' 
        monto.HeaderText = "Monto"
        monto.MinimumWidth = 6
        monto.Name = "monto"
        monto.Width = 90
        ' 
        ' detalle
        ' 
        detalle.HeaderText = "Detalle"
        detalle.MinimumWidth = 6
        detalle.Name = "detalle"
        detalle.Width = 125
        ' 
        ' objgasto
        ' 
        objgasto.HeaderText = "Objeto de Gasto"
        objgasto.MinimumWidth = 6
        objgasto.Name = "objgasto"
        objgasto.Width = 125
        ' 
        ' acciones
        ' 
        acciones.HeaderText = "Acciones"
        acciones.MinimumWidth = 6
        acciones.Name = "acciones"
        acciones.Width = 90
        ' 
        ' btniniciarsesion
        ' 
        btniniciarsesion.BackColor = Color.FromArgb(CByte(15), CByte(131), CByte(229))
        btniniciarsesion.Cursor = Cursors.Hand
        btniniciarsesion.FlatAppearance.BorderSize = 0
        btniniciarsesion.FlatStyle = FlatStyle.Flat
        btniniciarsesion.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btniniciarsesion.ForeColor = Color.White
        btniniciarsesion.Location = New Point(808, 407)
        btniniciarsesion.Name = "btniniciarsesion"
        btniniciarsesion.Size = New Size(138, 39)
        btniniciarsesion.TabIndex = 18
        btniniciarsesion.Text = "   Registrar"
        btniniciarsesion.TextAlign = ContentAlignment.MiddleLeft
        btniniciarsesion.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Label6.Location = New Point(486, 28)
        Label6.Name = "Label6"
        Label6.Size = New Size(204, 32)
        Label6.TabIndex = 19
        Label6.Text = "Lista de Cheques"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(429, 342)
        Label7.Name = "Label7"
        Label7.Size = New Size(231, 31)
        Label7.TabIndex = 20
        Label7.Text = "Registro de Cheques"
        ' 
        ' btnregistrar
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1183, 805)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(btniniciarsesion)
        Controls.Add(DataGridView1)
        Controls.Add(txtnumerochk)
        Controls.Add(Label5)
        Controls.Add(cbogasto)
        Controls.Add(TextBox4)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(cboproveedor)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PoisonDateTimeCheque)
        Controls.Add(lblcheck)
        Name = "btnregistrar"
        Text = "cheque"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblcheck As Label
    Public Property TxtBox1 As TextBox
    Public Property Txteditarcheque As TextBox
    Friend WithEvents txtnumerochk As TextBox
    Friend WithEvents PoisonDateTimeCheque As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private cboproveedor As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents AloneComboBox1 As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents cbogasto As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btniniciarsesion As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents numerochk As DataGridViewTextBoxColumn
    Friend WithEvents fechachk As DataGridViewTextBoxColumn
    Friend WithEvents proveedor As DataGridViewTextBoxColumn
    Friend WithEvents monto As DataGridViewTextBoxColumn
    Friend WithEvents detalle As DataGridViewTextBoxColumn
    Friend WithEvents objgasto As DataGridViewTextBoxColumn
    Friend WithEvents acciones As DataGridViewTextBoxColumn
End Class









