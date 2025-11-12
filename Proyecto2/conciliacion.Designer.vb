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
        saldoLibroInicial = New TextBox()
        TextBox2 = New TextBox()
        lblSaldoLibro = New Label()
        lblPeriodo = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        lblSaldoBanco = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        lblConciliadoBanco = New Label()
        saldoBancoInicial = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        TextBox13 = New TextBox()
        cboMes = New ComboBox()
        Label18 = New Label()
        Label19 = New Label()
        cboAnio = New ComboBox()
        btnCalcular = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(583, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 28)
        Label1.TabIndex = 0
        Label1.Text = "EMPRESA XYZ"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.Location = New Point(524, 61)
        Label2.Name = "Label2"
        Label2.Size = New Size(260, 28)
        Label2.TabIndex = 1
        Label2.Text = "CONCILIACIÓN BANCARIA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(320, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 23)
        Label3.TabIndex = 2
        Label3.Text = "Más:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(370, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(78, 23)
        Label4.TabIndex = 3
        Label4.Text = "Depósito"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(370, 209)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 23)
        Label5.TabIndex = 4
        Label5.Text = "Cheques Anulados"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(292, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 20)
        Label6.TabIndex = 5
        Label6.Text = "SUBTOTAL"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(299, 309)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 23)
        Label7.TabIndex = 6
        Label7.Text = "Menos:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.Location = New Point(370, 310)
        Label8.Name = "Label8"
        Label8.Size = New Size(139, 23)
        Label8.TabIndex = 7
        Label8.Text = "Cheques Girados"
        ' 
        ' lblSaldoConciliado
        ' 
        lblSaldoConciliado.AutoSize = True
        lblSaldoConciliado.Font = New Font("Segoe UI", 12.5F, FontStyle.Bold)
        lblSaldoConciliado.Location = New Point(283, 383)
        lblSaldoConciliado.Name = "lblSaldoConciliado"
        lblSaldoConciliado.Size = New Size(405, 30)
        lblSaldoConciliado.TabIndex = 8
        lblSaldoConciliado.Text = "SALDO CONCILIADO SEGÚN LIBROS AL"
        ' 
        ' saldoLibroInicial
        ' 
        saldoLibroInicial.Location = New Point(920, 140)
        saldoLibroInicial.Name = "saldoLibroInicial"
        saldoLibroInicial.Size = New Size(125, 27)
        saldoLibroInicial.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(789, 175)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 10
        ' 
        ' lblSaldoLibro
        ' 
        lblSaldoLibro.AutoSize = True
        lblSaldoLibro.Font = New Font("Segoe UI", 12.2F, FontStyle.Bold)
        lblSaldoLibro.Location = New Point(283, 137)
        lblSaldoLibro.Name = "lblSaldoLibro"
        lblSaldoLibro.Size = New Size(257, 30)
        lblSaldoLibro.TabIndex = 11
        lblSaldoLibro.Text = "SALDO SEGÚN LIBRO AL"
        ' 
        ' lblPeriodo
        ' 
        lblPeriodo.AutoSize = True
        lblPeriodo.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPeriodo.Location = New Point(431, 89)
        lblPeriodo.Name = "lblPeriodo"
        lblPeriodo.Size = New Size(264, 28)
        lblPeriodo.TabIndex = 12
        lblPeriodo.Text = "Correspondiente al mes de"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(789, 208)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 14
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(920, 247)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 15
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(920, 283)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 16
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(789, 316)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 27)
        TextBox6.TabIndex = 17
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(920, 349)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(125, 27)
        TextBox7.TabIndex = 18
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(920, 382)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(125, 27)
        TextBox8.TabIndex = 19
        ' 
        ' lblSaldoBanco
        ' 
        lblSaldoBanco.AutoSize = True
        lblSaldoBanco.Font = New Font("Segoe UI", 12.5F, FontStyle.Bold)
        lblSaldoBanco.Location = New Point(283, 434)
        lblSaldoBanco.Name = "lblSaldoBanco"
        lblSaldoBanco.Size = New Size(228, 30)
        lblSaldoBanco.TabIndex = 20
        lblSaldoBanco.Text = "SALDO EN BANCO AL"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10F)
        Label13.Location = New Point(318, 476)
        Label13.Name = "Label13"
        Label13.Size = New Size(50, 23)
        Label13.TabIndex = 21
        Label13.Text = "Más: "
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10F)
        Label14.Location = New Point(363, 476)
        Label14.Name = "Label14"
        Label14.Size = New Size(179, 23)
        Label14.TabIndex = 22
        Label14.Text = " Depósitos en Transito"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10F)
        Label15.Location = New Point(297, 506)
        Label15.Name = "Label15"
        Label15.Size = New Size(65, 23)
        Label15.TabIndex = 23
        Label15.Text = "Menos:"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI", 10F)
        Label16.Location = New Point(368, 506)
        Label16.Name = "Label16"
        Label16.Size = New Size(189, 23)
        Label16.TabIndex = 24
        Label16.Text = "Cheques en Circulación"
        ' 
        ' lblConciliadoBanco
        ' 
        lblConciliadoBanco.AutoSize = True
        lblConciliadoBanco.Font = New Font("Segoe UI", 12.5F, FontStyle.Bold)
        lblConciliadoBanco.Location = New Point(283, 576)
        lblConciliadoBanco.Name = "lblConciliadoBanco"
        lblConciliadoBanco.Size = New Size(388, 30)
        lblConciliadoBanco.TabIndex = 25
        lblConciliadoBanco.Text = "SALDO CONCILIADO IGUAL A BANCO"
        ' 
        ' saldoBancoInicial
        ' 
        saldoBancoInicial.Location = New Point(920, 433)
        saldoBancoInicial.Name = "saldoBancoInicial"
        saldoBancoInicial.Size = New Size(125, 27)
        saldoBancoInicial.TabIndex = 26
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(789, 471)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(125, 27)
        TextBox10.TabIndex = 27
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(789, 503)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(125, 27)
        TextBox11.TabIndex = 28
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(920, 545)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(125, 27)
        TextBox12.TabIndex = 29
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(920, 578)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(125, 27)
        TextBox13.TabIndex = 30
        ' 
        ' cboMes
        ' 
        cboMes.DropDownStyle = ComboBoxStyle.DropDownList
        cboMes.FormattingEnabled = True
        cboMes.Location = New Point(97, 105)
        cboMes.Name = "cboMes"
        cboMes.Size = New Size(151, 28)
        cboMes.TabIndex = 31
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI", 10F)
        Label18.Location = New Point(97, 79)
        Label18.Name = "Label18"
        Label18.Size = New Size(109, 23)
        Label18.TabIndex = 32
        Label18.Text = "Escoger mes:"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI", 10F)
        Label19.Location = New Point(97, 151)
        Label19.Name = "Label19"
        Label19.Size = New Size(107, 23)
        Label19.TabIndex = 34
        Label19.Text = "Escoger año:"
        ' 
        ' cboAnio
        ' 
        cboAnio.DropDownStyle = ComboBoxStyle.DropDownList
        cboAnio.FormattingEnabled = True
        cboAnio.Location = New Point(97, 177)
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
        btnCalcular.Location = New Point(97, 226)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(104, 39)
        btnCalcular.TabIndex = 39
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = False
        ' 
        ' conciliacion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1160, 636)
        Controls.Add(btnCalcular)
        Controls.Add(Label19)
        Controls.Add(cboAnio)
        Controls.Add(Label18)
        Controls.Add(cboMes)
        Controls.Add(TextBox13)
        Controls.Add(TextBox12)
        Controls.Add(TextBox11)
        Controls.Add(TextBox10)
        Controls.Add(saldoBancoInicial)
        Controls.Add(lblConciliadoBanco)
        Controls.Add(Label16)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(lblSaldoBanco)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(lblPeriodo)
        Controls.Add(lblSaldoLibro)
        Controls.Add(TextBox2)
        Controls.Add(saldoLibroInicial)
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
    Friend WithEvents saldoLibroInicial As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblSaldoLibro As Label
    Friend WithEvents lblPeriodo As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents lblSaldoBanco As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblConciliadoBanco As Label
    Friend WithEvents saldoBancoInicial As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents cboMes As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cboAnio As ComboBox
    Friend WithEvents btnCalcular As Button
End Class
