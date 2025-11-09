Imports System.IO
Imports MySql.Data.MySqlClient

Public Class btnregistrar
    Private Sub btnregistrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtmontoltr.ReadOnly = True

        AddHandler txtmontonum.TextChanged, AddressOf SoloDineroTextBox
        AddHandler txtmontonum.TextChanged, AddressOf ActualizarMontoEnLetras
        AddHandler txtnumerochk.TextChanged, AddressOf SoloNumerosTextBox
    End Sub

    Private Sub cheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGastos()
        CargarProveedor()
        CargarCheques()
    End Sub

    Private Sub CargarGastos()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()

                Dim query As String = "SELECT codigo, detalle FROM objeto_gasto"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)

                        cbogasto.DataSource = dt
                        cbogasto.DisplayMember = "detalle"
                        cbogasto.ValueMember = "codigo"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los gastos: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarProveedor()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()

                Dim query As String = "SELECT codigo, nombre FROM proveedores"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)

                        cboproveedor.DataSource = dt
                        cboproveedor.DisplayMember = "nombre"
                        cboproveedor.ValueMember = "codigo"
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los proveedores: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarCheques()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()

                ' Query con JOIN para traer los nombres
                Dim query As String = "SELECT 
                    c.numero, 
                    c.fecha, 
                    c.cod_proveedor,
                    p.nombre AS nombre_proveedor, 
                    c.monto_numerico, 
                    c.monto_letras, 
                    c.detalle, 
                    c.cod_objetogasto,
                    c.anulado,
                    CASE 
                        WHEN c.anulado = 1 THEN 'Anulado'
                        ELSE 'Activo'
                    END AS estado,
                    CASE 
                        WHEN c.fecha_anulacion IS NULL OR c.fecha_anulacion = '' THEN '-'
                        ELSE DATE_FORMAT(c.fecha_anulacion, '%d/%m/%Y')
                    END AS fecha_anulacion,
                    o.detalle AS nombre_objetogasto
                FROM cheques c
                LEFT JOIN proveedores p ON c.cod_proveedor = p.codigo
                LEFT JOIN objeto_gasto o ON c.cod_objetogasto = o.codigo"

                Using cmd As New MySqlCommand(query, conn)
                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    DataGridViewChk.AutoGenerateColumns = False
                    DataGridViewChk.DataSource = dt

                    DataGridViewChk.Columns("numerochk").DataPropertyName = "numero"
                    DataGridViewChk.Columns("fechachk").DataPropertyName = "fecha"
                    DataGridViewChk.Columns("proveedor").DataPropertyName = "nombre_proveedor"
                    DataGridViewChk.Columns("montonum").DataPropertyName = "monto_numerico"
                    DataGridViewChk.Columns("montoltr").DataPropertyName = "monto_letras"
                    DataGridViewChk.Columns("detalle").DataPropertyName = "detalle"
                    DataGridViewChk.Columns("objgasto").DataPropertyName = "nombre_objetogasto"
                    DataGridViewChk.Columns("anulado").DataPropertyName = "estado"
                    DataGridViewChk.Columns("fecha_anulacion").DataPropertyName = "fecha_anulacion"

                    If Not DataGridViewChk.Columns.Contains("btnAnular") Then
                        Dim btnCol As New DataGridViewButtonColumn()
                        btnCol.Name = "btnAnular"
                        btnCol.HeaderText = "Acciones"
                        btnCol.Text = "Anular"
                        btnCol.UseColumnTextForButtonValue = True
                        btnCol.Width = 80
                        DataGridViewChk.Columns.Add(btnCol)
                    End If

                End Using

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los cheques: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridViewChk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewChk.CellClick

        If e.ColumnIndex = DataGridViewChk.Columns("btnAnular").Index AndAlso e.RowIndex >= 0 Then
            ' Obtener el estado del cheque
            Dim estado As String = DataGridViewChk.Rows(e.RowIndex).Cells("anulado").Value?.ToString()

            ' Verificar si ya está anulado
            If estado = "Anulado" Then
                MessageBox.Show("Este cheque ya está anulado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            ' Confirmar la anulación
            Dim resultado = MessageBox.Show("¿Está seguro de que desea anular este cheque?" & vbCrLf & vbCrLf &
                                       "Número: " & DataGridViewChk.Rows(e.RowIndex).Cells("numerochk").Value.ToString() & vbCrLf &
                                       "Proveedor: " & DataGridViewChk.Rows(e.RowIndex).Cells("proveedor").Value.ToString() & vbCrLf &
                                       "Monto: " & DataGridViewChk.Rows(e.RowIndex).Cells("montonum").Value.ToString(),
                                       "Confirmar Anulación",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question)

            If resultado = DialogResult.Yes Then
                Dim numeroCheque As String = DataGridViewChk.Rows(e.RowIndex).Cells("numerochk").Value.ToString()

                If AnularCheque(numeroCheque) Then
                    MessageBox.Show("Cheque anulado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarCheques()
                Else
                    MessageBox.Show("Error al anular el cheque.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Function AnularCheque(numeroCheque As String) As Boolean
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()

                Dim query As String = "UPDATE cheques 
                                  SET anulado = 1, 
                                      fecha_anulacion = CURDATE() 
                                  WHERE numero = @numero"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@numero", numeroCheque)

                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    Return filasAfectadas > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al anular el cheque: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub btnregistrarchk_Click(sender As Object, e As EventArgs) Handles btnregistrarchk.Click
        If String.IsNullOrWhiteSpace(txtnumerochk.Text) OrElse
           String.IsNullOrWhiteSpace(txtmontonum.Text) OrElse
           String.IsNullOrWhiteSpace(txtmontoltr.Text) OrElse
           String.IsNullOrWhiteSpace(txtdetallechk.Text) OrElse
           cboproveedor.SelectedValue Is Nothing OrElse
           cbogasto.SelectedValue Is Nothing Then
            MessageBox.Show("Por favor complete todos los campos antes de registrar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtnumerochk.Text.Length <> 7 OrElse Not IsNumeric(txtnumerochk.Text) Then
            MessageBox.Show("El número de cheque debe tener exactamente 7 dígitos numéricos.", "Número inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtnumerochk.Focus()
            Return
        End If

        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()
                Dim query As String = "INSERT INTO cheques (numero, fecha, monto_numerico, monto_letras, detalle, cod_proveedor, cod_objetogasto) " &
                                      "VALUES (@numero, @fecha, @monto_numerico, @monto_letras, @detalle, @cod_proveedor, @cod_objetogasto)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@numero", txtnumerochk.Text)
                    cmd.Parameters.AddWithValue("@fecha", PoisonDateTimeCheque.Value)
                    cmd.Parameters.AddWithValue("@monto_numerico", Convert.ToDecimal(txtmontonum.Text))
                    cmd.Parameters.AddWithValue("@monto_letras", txtmontoltr.Text)
                    cmd.Parameters.AddWithValue("@detalle", txtdetallechk.Text)
                    cmd.Parameters.AddWithValue("@cod_proveedor", cboproveedor.SelectedValue)
                    cmd.Parameters.AddWithValue("@cod_objetogasto", cbogasto.SelectedValue)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Cheque registrado exitosamente.")

            CargarCheques()
            LimpiarCampos()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al registrar el cheque: " & ex.Message)
        End Try
    End Sub

    Private Sub ActualizarMontoEnLetras(sender As Object, e As EventArgs)
        ' Primero validar el campo de dinero
        validaciones.SoloDineroTextBox(sender, e)

        ' Luego convertir a letras
        Dim txtMonto As ReaLTaiizor.Controls.AloneTextBox = CType(sender, ReaLTaiizor.Controls.AloneTextBox)

        If String.IsNullOrWhiteSpace(txtMonto.Text) Then
            txtmontoltr.Text = ""
            Return
        End If

        Dim monto As Decimal
        If Decimal.TryParse(txtMonto.Text, monto) Then
            txtmontoltr.Text = validaciones.NumeroALetras(monto)
        Else
            txtmontoltr.Text = ""
        End If
    End Sub

    Private Sub LimpiarCampos()
        txtnumerochk.Text = ""
        txtmontonum.Text = ""
        txtmontoltr.Text = ""
        txtdetallechk.Text = ""
        PoisonDateTimeCheque.Value = DateTime.Now
        cbogasto.SelectedIndex = 0
        cboproveedor.SelectedIndex = 0
    End Sub

    Private Sub btncancelarchk_Click(sender As Object, e As EventArgs) Handles btncancelarchk.Click
        LimpiarCampos()
    End Sub
End Class