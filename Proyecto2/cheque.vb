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
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los cheques: " & ex.Message)
        End Try
    End Sub

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