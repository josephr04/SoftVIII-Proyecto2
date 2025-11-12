<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conciliacion
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        lblSaldoConciliado = New Label()
        txtSaldoLibro = New TextBox()
        txtDepositos = New TextBox()
        lblSaldoLibro = New Label()
        lblPeriodo = New Label()
        txtChequesAnulados = New TextBox()
        txtDepositos2 = New TextBox()
        txtSubtotal = New TextBox()
        txtChequesGirados = New TextBox()
        txtChequesGirados2 = New TextBox()
        txtSaldoConciliadoLibro = New TextBox()
        lblSaldoBanco = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        lblConciliadoBanco = New Label()
        txtSaldoBanco = New TextBox()
        txtDepositosTransito = New TextBox()
        txtChequesCirculacion = New TextBox()
        txtChequesCirculacion2 = New TextBox()
        txtSaldoConciliadoBanco = New TextBox()
        cboMes = New ComboBox()
        Label18 = New Label()
        Label19 = New Label()
        cboAnio = New ComboBox()
        btnCalcular = New Button()
        btnLimpiarConciliacion = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(563, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 28)
        Label1.TabIndex = 0
        Label1.Text = "EMPRESA XYZ"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(504, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 28)
        Label2.TabIndex = 1
        Label2.Text = "CONCILIACIÓN BANCARIA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(300, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 23)
        Label3.TabIndex = 2
        Label3.Text = "Más:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(350, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 23)
        Label4.TabIndex = 3
        Label4.Text = "Depósito"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(350, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 23)
        Label5.TabIndex = 4
        Label5.Text = "Cheques Anulados"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(272, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 20)
        Label6.TabIndex = 5
        Label6.Text = "SUBTOTAL"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(279, 309)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 23)
        Label7.TabIndex = 6
        Label7.Text = "Menos:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.Location = New Point(350, 310)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 23)
        Label8.TabIndex = 7
        Label8.Text = "Cheques Girados"
        ' 
        ' lblSaldoConciliado
        ' 
        lblSaldoConciliado.AutoSize = True
        lblSaldoConciliado.Font = New Font("Segoe UI", 12.5F, FontStyle.Bold)
        lblSaldoConciliado.Location = New Point(263, 383)
        lblSaldoConciliado.Name = "lblSaldoConciliado"
        lblSaldoConciliado.Size = New Size(405, 30)
        lblSaldoConciliado.TabIndex = 8
        lblSaldoConciliado.Text = "SALDO CONCILIADO SEGÚN LIBROS AL"
        ' 
        ' txtSaldoLibro
        ' 
        txtSaldoLibro.Location = New Point(900, 140)
        txtSaldoLibro.Name = "txtSaldoLibro"
        txtSaldoLibro.Size = New Size(125, 27)
        txtSaldoLibro.TabIndex = 9
        ' 
        ' txtDepositos
        ' 
        txtDepositos.Location = New Point(769, 175)
        txtDepositos.Name = "txtDepositos"
        txtDepositos.ReadOnly = True
        txtDepositos.Size = New Size(125, 27)
        txtDepositos.TabIndex = 10
        ' 
        ' lblSaldoLibro
        ' 
        lblSaldoLibro.AutoSize = True
        lblSaldoLibro.Font = New Font("Segoe UI", 12.2F, FontStyle.Bold)
        lblSaldoLibro.Location = New Point(263, 137)
        lblSaldoLibro.Name = "lblSaldoLibro"
        lblSaldoLibro.Size = New Size(257, 30)
        lblSaldoLibro.TabIndex = 11
        lblSaldoLibro.Text = "SALDO SEGÚN LIBRO AL"
        ' 
        ' lblPeriodo
        ' 
        lblPeriodo.AutoSize = True
        lblPeriodo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPeriodo.Location = New Point(411, 89)
        lblPeriodo.Name = "lblPeriodo"
        lblPeriodo.Size = New Size(264, 28)
        lblPeriodo.TabIndex = 12
        lblPeriodo.Text = "Correspondiente al mes de"
        ' 
        ' txtChequesAnulados
        ' 
        txtChequesAnulados.Location = New Point(769, 208)
        txtChequesAnulados.Name = "txtChequesAnulados"
        txtChequesAnulados.ReadOnly = True
        txtChequesAnulados.Size = New Size(125, 27)
        txtChequesAnulados.TabIndex = 14
        ' 
        ' txtDepositos2
        ' 
        txtDepositos2.Location = New Point(900, 247)
        txtDepositos2.Name = "txtDepositos2"
        txtDepositos2.ReadOnly = True
        txtDepositos2.Size = New Size(125, 27)
        txtDepositos2.TabIndex = 15
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(900, 283)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(125, 27)
        txtSubtotal.TabIndex = 16
        ' 
        ' txtChequesGirados
        ' 
        txtChequesGirados.Location = New Point(769, 316)
        txtChequesGirados.Name = "txtChequesGirados"
        txtChequesGirados.ReadOnly = True
        txtChequesGirados.Size = New Size(125, 27)
        txtChequesGirados.TabIndex = 17
        ' 
        ' txtChequesGirados2
        ' 
        txtChequesGirados2.Location = New Point(900, 349)
        txtChequesGirados2.Name = "txtChequesGirados2"
        txtChequesGirados2.ReadOnly = True
        txtChequesGirados2.Size = New Size(125, 27)
        txtChequesGirados2.TabIndex = 18
        ' 
        ' txtSaldoConciliadoLibro
        ' 
        txtSaldoConciliadoLibro.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        txtSaldoConciliadoLibro.Location = New Point(900, 382)
        txtSaldoConciliadoLibro.Name = "txtSaldoConciliadoLibro"
        txtSaldoConciliadoLibro.ReadOnly = True
        txtSaldoConciliadoLibro.Size = New Size(125, 27)
        txtSaldoConciliadoLibro.TabIndex = 19
        ' 
        ' lblSaldoBanco
        ' 
        lblSaldoBanco.AutoSize = True
        lblSaldoBanco.Font = New Font("Segoe UI", 12.5F, FontStyle.Bold)
        lblSaldoBanco.Location = New Point(263, 434)
        lblSaldoBanco.Name = "lblSaldoBanco"
        lblSaldoBanco.Size = New Size(228, 30)
        lblSaldoBanco.TabIndex = 20
        lblSaldoBanco.Text = "SALDO EN BANCO AL"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10F)
        Label13.Location = New Point(298, 476)
        Label13.Name = "Label13"
        Label13.Size = New Size(50, 23)
        Label13.TabIndex = 21
        Label13.Text = "Más: "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10F)
        Label14.Location = New Point(343, 476)
        Label14.Name = "Label14"
        Label14.Size = New Size(179, 23)
        Label14.TabIndex = 22
        Label14.Text = " Depósitos en Transito"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10F)
        Label15.Location = New Point(277, 506)
        Label15.Name = "Label15"
        Label15.Size = New Size(65, 23)
        Label15.TabIndex = 23
        Label15.Text = "Menos:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10F)
        Label16.Location = New Point(348, 506)
        Label16.Name = "Label16"
        Label16.Size = New Size(189, 23)
        Label16.TabIndex = 24
        Label16.Text = "Cheques en Circulación"
        ' 
        ' lblConciliadoBanco
        ' 
        lblConciliadoBanco.AutoSize = True
        lblConciliadoBanco.Font = New Font("Segoe UI", 12.5F, FontStyle.Bold)
        lblConciliadoBanco.Location = New Point(263, 576)
        lblConciliadoBanco.Name = "lblConciliadoBanco"
        lblConciliadoBanco.Size = New Size(388, 30)
        lblConciliadoBanco.TabIndex = 25
        lblConciliadoBanco.Text = "SALDO CONCILIADO IGUAL A BANCO"
        ' 
        ' txtSaldoBanco
        ' 
        txtSaldoBanco.Location = New Point(900, 433)
        txtSaldoBanco.Name = "txtSaldoBanco"
        txtSaldoBanco.Size = New Size(125, 27)
        txtSaldoBanco.TabIndex = 26
        ' 
        ' txtDepositosTransito
        ' 
        txtDepositosTransito.Location = New Point(769, 471)
        txtDepositosTransito.Name = "txtDepositosTransito"
        txtDepositosTransito.ReadOnly = True
        txtDepositosTransito.Size = New Size(125, 27)
        txtDepositosTransito.TabIndex = 27
        ' 
        ' txtChequesCirculacion
        ' 
        txtChequesCirculacion.Location = New Point(769, 503)
        txtChequesCirculacion.Name = "txtChequesCirculacion"
        txtChequesCirculacion.ReadOnly = True
        txtChequesCirculacion.Size = New Size(125, 27)
        txtChequesCirculacion.TabIndex = 28
        ' 
        ' txtChequesCirculacion2
        ' 
        txtChequesCirculacion2.Location = New Point(900, 545)
        txtChequesCirculacion2.Name = "txtChequesCirculacion2"
        txtChequesCirculacion2.ReadOnly = True
        txtChequesCirculacion2.Size = New Size(125, 27)
        txtChequesCirculacion2.TabIndex = 29
        ' 
        ' txtSaldoConciliadoBanco
        ' 
        txtSaldoConciliadoBanco.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        txtSaldoConciliadoBanco.Location = New Point(900, 578)
        txtSaldoConciliadoBanco.Name = "txtSaldoConciliadoBanco"
        txtSaldoConciliadoBanco.ReadOnly = True
        txtSaldoConciliadoBanco.Size = New Size(125, 27)
        txtSaldoConciliadoBanco.TabIndex = 30
        ' 
        ' cboMes
        ' 
        cboMes.DropDownStyle = ComboBoxStyle.DropDownList
        cboMes.FormattingEnabled = True
        cboMes.Location = New Point(67, 105)
        cboMes.Name = "cboMes"
        cboMes.Size = New Size(151, 28)
        cboMes.TabIndex = 31
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 10F)
        Label18.Location = New Point(67, 79)
        Label18.Name = "Label18"
        Label18.Size = New Size(109, 23)
        Label18.TabIndex = 32
        Label18.Text = "Escoger mes:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 10F)
        Label19.Location = New Point(67, 151)
        Label19.Name = "Label19"
        Label19.Size = New Size(107, 23)
        Label19.TabIndex = 34
        Label19.Text = "Escoger año:"
        ' 
        ' cboAnio
        ' 
        cboAnio.DropDownStyle = ComboBoxStyle.DropDownList
        cboAnio.FormattingEnabled = True
        cboAnio.Location = New Point(67, 177)
        cboAnio.Name = "cboAnio"
        cboAnio.Size = New Size(151, 28)
        cboAnio.TabIndex = 33
        ' 
        ' btnCalcular
        ' 
        btnCalcular.BackColor = Color.FromArgb(CByte(15), CByte(131), CByte(229))
        btnCalcular.Cursor = Cursors.Hand
        btnCalcular.FlatAppearance.BorderSize = 0
        btnCalcular.FlatStyle = FlatStyle.Flat
        btnCalcular.Font = New Font("Segoe UI", 12F)
        btnCalcular.ForeColor = Color.White
        btnCalcular.Location = New Point(67, 226)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(104, 39)
        btnCalcular.TabIndex = 39
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiarConciliacion
        ' 
        btnLimpiarConciliacion.BackColor = SystemColors.ScrollBar
        btnLimpiarConciliacion.Cursor = Cursors.Hand
        btnLimpiarConciliacion.FlatAppearance.BorderSize = 0
        btnLimpiarConciliacion.FlatStyle = FlatStyle.Flat
        btnLimpiarConciliacion.Font = New Font("Segoe UI", 12F)
        btnLimpiarConciliacion.ForeColor = SystemColors.ControlText
        btnLimpiarConciliacion.Location = New Point(67, 274)
        btnLimpiarConciliacion.Name = "btnLimpiarConciliacion"
        btnLimpiarConciliacion.Size = New Size(104, 39)
        btnLimpiarConciliacion.TabIndex = 40
        btnLimpiarConciliacion.Text = "Limpiar"
        btnLimpiarConciliacion.UseVisualStyleBackColor = False
        ' 
        ' conciliacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1160, 636)
        Controls.Add(btnLimpiarConciliacion)
        Controls.Add(btnCalcular)
        Controls.Add(Label19)
        Controls.Add(cboAnio)
        Controls.Add(Label18)
        Controls.Add(cboMes)
        Controls.Add(txtSaldoConciliadoBanco)
        Controls.Add(txtChequesCirculacion2)
        Controls.Add(txtChequesCirculacion)
        Controls.Add(txtDepositosTransito)
        Controls.Add(txtSaldoBanco)
        Controls.Add(lblConciliadoBanco)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(lblSaldoBanco)
        Controls.Add(txtSaldoConciliadoLibro)
        Controls.Add(txtChequesGirados2)
        Controls.Add(txtChequesGirados)
        Controls.Add(txtSubtotal)
        Controls.Add(txtDepositos2)
        Controls.Add(txtChequesAnulados)
        Controls.Add(lblPeriodo)
        Controls.Add(lblSaldoLibro)
        Controls.Add(txtDepositos)
        Controls.Add(txtSaldoLibro)
        Controls.Add(lblSaldoConciliado)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "conciliacion"
        Text = "conciliacion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSaldoConciliado As Label
    Friend WithEvents txtSaldoLibro As TextBox
    Friend WithEvents txtDepositos As TextBox
    Friend WithEvents lblSaldoLibro As Label
    Friend WithEvents lblPeriodo As Label
    Friend WithEvents txtChequesAnulados As TextBox
    Friend WithEvents txtDepositos2 As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents txtChequesGirados As TextBox
    Friend WithEvents txtChequesGirados2 As TextBox
    Friend WithEvents txtSaldoConciliadoLibro As TextBox
    Friend WithEvents lblSaldoBanco As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblConciliadoBanco As Label
    Friend WithEvents txtSaldoBanco As TextBox
    Friend WithEvents txtDepositosTransito As TextBox
    Friend WithEvents txtChequesCirculacion As TextBox
    Friend WithEvents txtChequesCirculacion2 As TextBox
    Friend WithEvents txtSaldoConciliadoBanco As TextBox
    Friend WithEvents cboMes As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cboAnio As ComboBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiarConciliacion As Button
End Class
