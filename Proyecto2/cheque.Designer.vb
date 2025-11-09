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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblcheck = New Label()
        PoisonDateTimeCheque = New ReaLTaiizor.Controls.PoisonDateTime()
        Label1 = New Label()
        Label2 = New Label()
        cboproveedor = New ReaLTaiizor.Controls.AloneComboBox()
        Label3 = New Label()
        Label4 = New Label()
        cbogasto = New ReaLTaiizor.Controls.AloneComboBox()
        Label5 = New Label()
        DataGridViewChk = New DataGridView()
        btncancelarchk = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Panel1 = New Panel()
        btnregistrarchk = New Button()
        txtmontoltr = New ReaLTaiizor.Controls.AloneTextBox()
        txtmontonum = New ReaLTaiizor.Controls.AloneTextBox()
        txtnumerochk = New ReaLTaiizor.Controls.AloneTextBox()
        txtdetallechk = New TextBox()
        numerochk = New DataGridViewTextBoxColumn()
        fechachk = New DataGridViewTextBoxColumn()
        proveedor = New DataGridViewTextBoxColumn()
        montonum = New DataGridViewTextBoxColumn()
        montoltr = New DataGridViewTextBoxColumn()
        detalle = New DataGridViewTextBoxColumn()
        objgasto = New DataGridViewTextBoxColumn()
        anulado = New DataGridViewTextBoxColumn()
        fecha_anulacion = New DataGridViewTextBoxColumn()
        CType(DataGridViewChk, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblcheck
        ' 
        lblcheck.AutoSize = True
        lblcheck.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblcheck.ForeColor = SystemColors.ControlText
        lblcheck.Location = New Point(13, 54)
        lblcheck.Name = "lblcheck"
        lblcheck.Size = New Size(185, 25)
        lblcheck.TabIndex = 0
        lblcheck.Text = "Número de Cheque"
        ' 
        ' PoisonDateTimeCheque
        ' 
        PoisonDateTimeCheque.CalendarFont = New Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PoisonDateTimeCheque.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium
        PoisonDateTimeCheque.Location = New Point(318, 82)
        PoisonDateTimeCheque.MinimumSize = New Size(0, 30)
        PoisonDateTimeCheque.Name = "PoisonDateTimeCheque"
        PoisonDateTimeCheque.Size = New Size(218, 30)
        PoisonDateTimeCheque.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(318, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 25)
        Label1.TabIndex = 3
        Label1.Text = "Fecha de Cheque"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(318, 216)
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
        cboproveedor.Location = New Point(318, 256)
        cboproveedor.Name = "cboproveedor"
        cboproveedor.Size = New Size(288, 26)
        cboproveedor.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(13, 131)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 25)
        Label3.TabIndex = 10
        Label3.Text = "Monto numérico"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(13, 307)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 25)
        Label4.TabIndex = 12
        Label4.Text = "Detalle"
        ' 
        ' cbogasto
        ' 
        cbogasto.BackColor = Color.FromArgb(CByte(179), CByte(196), CByte(214))
        cbogasto.DrawMode = DrawMode.OwnerDrawFixed
        cbogasto.DropDownStyle = ComboBoxStyle.DropDownList
        cbogasto.EnabledCalc = True
        cbogasto.FormattingEnabled = True
        cbogasto.ItemHeight = 20
        cbogasto.Location = New Point(13, 256)
        cbogasto.Name = "cbogasto"
        cbogasto.Size = New Size(273, 26)
        cbogasto.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(13, 216)
        Label5.Name = "Label5"
        Label5.Size = New Size(155, 25)
        Label5.TabIndex = 15
        Label5.Text = "Objeto de Gasto"
        ' 
        ' DataGridViewChk
        ' 
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = Color.Black
        DataGridViewChk.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewChk.BackgroundColor = Color.Teal
        DataGridViewChk.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 11F)
        DataGridViewCellStyle2.ForeColor = Color.Black
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridViewChk.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewChk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewChk.Columns.AddRange(New DataGridViewColumn() {numerochk, fechachk, proveedor, montonum, montoltr, detalle, objgasto, anulado, fecha_anulacion})
        DataGridViewChk.GridColor = Color.FromArgb(CByte(195), CByte(157), CByte(230))
        DataGridViewChk.Location = New Point(41, 61)
        DataGridViewChk.Name = "DataGridViewChk"
        DataGridViewChk.RowHeadersWidth = 51
        DataGridViewChk.Size = New Size(1019, 245)
        DataGridViewChk.TabIndex = 17
        ' 
        ' btncancelarchk
        ' 
        btncancelarchk.BackColor = SystemColors.ScrollBar
        btncancelarchk.Cursor = Cursors.Hand
        btncancelarchk.FlatAppearance.BorderSize = 0
        btncancelarchk.FlatStyle = FlatStyle.Flat
        btncancelarchk.Font = New Font("Segoe UI", 12F)
        btncancelarchk.ForeColor = SystemColors.ControlText
        btncancelarchk.Location = New Point(560, 361)
        btncancelarchk.Name = "btncancelarchk"
        btncancelarchk.Size = New Size(138, 39)
        btncancelarchk.TabIndex = 18
        btncancelarchk.Text = "Cancelar"
        btncancelarchk.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label6.Location = New Point(426, 15)
        Label6.Name = "Label6"
        Label6.Size = New Size(204, 32)
        Label6.TabIndex = 19
        Label6.Text = "Lista de Cheques"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(13, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(231, 31)
        Label7.TabIndex = 20
        Label7.Text = "Registro de Cheques"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(318, 131)
        Label8.Name = "Label8"
        Label8.Size = New Size(153, 25)
        Label8.TabIndex = 22
        Label8.Text = "Monto en letras"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btnregistrarchk)
        Panel1.Controls.Add(btncancelarchk)
        Panel1.Controls.Add(txtmontoltr)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txtmontonum)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(cboproveedor)
        Panel1.Controls.Add(cbogasto)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtnumerochk)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblcheck)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PoisonDateTimeCheque)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtdetallechk)
        Panel1.ForeColor = SystemColors.ControlText
        Panel1.Location = New Point(111, 328)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(871, 433)
        Panel1.TabIndex = 23
        ' 
        ' btnregistrarchk
        ' 
        btnregistrarchk.BackColor = Color.FromArgb(CByte(15), CByte(131), CByte(229))
        btnregistrarchk.Cursor = Cursors.Hand
        btnregistrarchk.FlatAppearance.BorderSize = 0
        btnregistrarchk.FlatStyle = FlatStyle.Flat
        btnregistrarchk.Font = New Font("Segoe UI", 12F)
        btnregistrarchk.ForeColor = Color.White
        btnregistrarchk.Location = New Point(718, 361)
        btnregistrarchk.Name = "btnregistrarchk"
        btnregistrarchk.Size = New Size(138, 39)
        btnregistrarchk.TabIndex = 26
        btnregistrarchk.Text = "Registrar"
        btnregistrarchk.UseVisualStyleBackColor = False
        ' 
        ' txtmontoltr
        ' 
        txtmontoltr.BackColor = Color.Transparent
        txtmontoltr.EnabledCalc = True
        txtmontoltr.Font = New Font("Segoe UI", 9F)
        txtmontoltr.ForeColor = Color.FromArgb(CByte(124), CByte(133), CByte(142))
        txtmontoltr.Location = New Point(318, 159)
        txtmontoltr.MaxLength = 32767
        txtmontoltr.MultiLine = False
        txtmontoltr.Name = "txtmontoltr"
        txtmontoltr.ReadOnly = False
        txtmontoltr.Size = New Size(288, 36)
        txtmontoltr.TabIndex = 23
        txtmontoltr.TextAlign = HorizontalAlignment.Left
        txtmontoltr.UseSystemPasswordChar = False
        ' 
        ' txtmontonum
        ' 
        txtmontonum.BackColor = Color.Transparent
        txtmontonum.EnabledCalc = True
        txtmontonum.Font = New Font("Segoe UI", 9F)
        txtmontonum.ForeColor = Color.FromArgb(CByte(124), CByte(133), CByte(142))
        txtmontonum.Location = New Point(13, 159)
        txtmontonum.MaxLength = 32767
        txtmontonum.MultiLine = False
        txtmontonum.Name = "txtmontonum"
        txtmontonum.ReadOnly = False
        txtmontonum.Size = New Size(273, 36)
        txtmontonum.TabIndex = 22
        txtmontonum.TextAlign = HorizontalAlignment.Left
        txtmontonum.UseSystemPasswordChar = False
        ' 
        ' txtnumerochk
        ' 
        txtnumerochk.BackColor = Color.Transparent
        txtnumerochk.EnabledCalc = True
        txtnumerochk.Font = New Font("Segoe UI", 9F)
        txtnumerochk.ForeColor = Color.FromArgb(CByte(124), CByte(133), CByte(142))
        txtnumerochk.Location = New Point(13, 82)
        txtnumerochk.MaxLength = 32767
        txtnumerochk.MultiLine = False
        txtnumerochk.Name = "txtnumerochk"
        txtnumerochk.ReadOnly = False
        txtnumerochk.Size = New Size(218, 36)
        txtnumerochk.TabIndex = 21
        txtnumerochk.TextAlign = HorizontalAlignment.Left
        txtnumerochk.UseSystemPasswordChar = False
        ' 
        ' txtdetallechk
        ' 
        txtdetallechk.Location = New Point(13, 343)
        txtdetallechk.Multiline = True
        txtdetallechk.Name = "txtdetallechk"
        txtdetallechk.PlaceholderText = "Ingrese el detalle del cheque..."
        txtdetallechk.Size = New Size(523, 74)
        txtdetallechk.TabIndex = 27
        ' 
        ' numerochk
        ' 
        numerochk.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        numerochk.HeaderText = "Número de Cheque"
        numerochk.MinimumWidth = 6
        numerochk.Name = "numerochk"
        numerochk.ReadOnly = True
        numerochk.Width = 140
        ' 
        ' fechachk
        ' 
        fechachk.HeaderText = "Fecha de Cheque"
        fechachk.MinimumWidth = 6
        fechachk.Name = "fechachk"
        fechachk.ReadOnly = True
        fechachk.Width = 125
        ' 
        ' proveedor
        ' 
        proveedor.HeaderText = "Proveedor"
        proveedor.MinimumWidth = 6
        proveedor.Name = "proveedor"
        proveedor.ReadOnly = True
        proveedor.Width = 125
        ' 
        ' montonum
        ' 
        montonum.HeaderText = "Monto Numérico"
        montonum.MinimumWidth = 6
        montonum.Name = "montonum"
        montonum.ReadOnly = True
        montonum.Width = 125
        ' 
        ' montoltr
        ' 
        montoltr.HeaderText = "Monto en Letras"
        montoltr.MinimumWidth = 6
        montoltr.Name = "montoltr"
        montoltr.ReadOnly = True
        montoltr.Width = 125
        ' 
        ' detalle
        ' 
        detalle.HeaderText = "Detalle"
        detalle.MinimumWidth = 6
        detalle.Name = "detalle"
        detalle.ReadOnly = True
        detalle.Width = 125
        ' 
        ' objgasto
        ' 
        objgasto.HeaderText = "Objeto de Gasto"
        objgasto.MinimumWidth = 6
        objgasto.Name = "objgasto"
        objgasto.ReadOnly = True
        objgasto.Width = 125
        ' 
        ' anulado
        ' 
        anulado.HeaderText = "Estado"
        anulado.MinimumWidth = 6
        anulado.Name = "anulado"
        anulado.ReadOnly = True
        anulado.Resizable = DataGridViewTriState.True
        anulado.Width = 125
        ' 
        ' fecha_anulacion
        ' 
        fecha_anulacion.HeaderText = "Fecha de Anulación"
        fecha_anulacion.MinimumWidth = 6
        fecha_anulacion.Name = "fecha_anulacion"
        fecha_anulacion.ReadOnly = True
        fecha_anulacion.Width = 125
        ' 
        ' btnregistrar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1183, 805)
        Controls.Add(Label6)
        Controls.Add(DataGridViewChk)
        Controls.Add(Panel1)
        Name = "btnregistrar"
        Text = "cheque"
        CType(DataGridViewChk, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblcheck As Label
    Public Property TxtBox1 As TextBox
    Public Property Txteditarcheque As TextBox
    Friend WithEvents PoisonDateTimeCheque As ReaLTaiizor.Controls.PoisonDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private cboproveedor As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents AloneComboBox1 As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbogasto As ReaLTaiizor.Controls.AloneComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridViewChk As DataGridView
    Friend WithEvents btncancelarchk As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtnumerochk As ReaLTaiizor.Controls.AloneTextBox
    Friend WithEvents txtmontonum As ReaLTaiizor.Controls.AloneTextBox
    Friend WithEvents txtmontoltr As ReaLTaiizor.Controls.AloneTextBox
    Friend WithEvents btnregistrarchk As Button
    Friend WithEvents txtdetallechk As TextBox
    Friend WithEvents numerochk As DataGridViewTextBoxColumn
    Friend WithEvents fechachk As DataGridViewTextBoxColumn
    Friend WithEvents proveedor As DataGridViewTextBoxColumn
    Friend WithEvents montonum As DataGridViewTextBoxColumn
    Friend WithEvents montoltr As DataGridViewTextBoxColumn
    Friend WithEvents detalle As DataGridViewTextBoxColumn
    Friend WithEvents objgasto As DataGridViewTextBoxColumn
    Friend WithEvents anulado As DataGridViewTextBoxColumn
    Friend WithEvents fecha_anulacion As DataGridViewTextBoxColumn
End Class









