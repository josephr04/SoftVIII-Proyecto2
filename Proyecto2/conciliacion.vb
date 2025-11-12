Imports System.IO
Imports MySql.Data.MySqlClient

Public Class conciliacion
    Private mesSeleccionado As Integer
    Private anioSeleccionado As Integer

    Private Sub conciliacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txtSaldoLibro.TextChanged, AddressOf SoloDineroTextBox_Normal
        AddHandler txtSaldoBanco.TextChanged, AddressOf SoloDineroTextBox_Normal

        cboMes.Items.Clear()
        cboMes.Items.AddRange({"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                               "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        cboMes.SelectedIndex = DateTime.Now.Month - 1

        cboAnio.Items.Clear()
        For i As Integer = 2020 To DateTime.Now.Year
            cboAnio.Items.Add(i)
        Next
        cboAnio.SelectedItem = DateTime.Now.Year

        ActualizarLabelPeriodo()
    End Sub

    Private Sub cboMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMes.SelectedIndexChanged
        ActualizarLabelPeriodo()
    End Sub

    Private Sub cboAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAnio.SelectedIndexChanged
        ActualizarLabelPeriodo()
    End Sub

    Private Sub ActualizarLabelPeriodo()
        If cboMes.SelectedIndex >= 0 And cboAnio.SelectedItem IsNot Nothing Then
            mesSeleccionado = cboMes.SelectedIndex + 1
            anioSeleccionado = CInt(cboAnio.SelectedItem)

            ' Calcular el último día del mes ANTERIOR
            Dim primerDiaMesActual As New Date(anioSeleccionado, mesSeleccionado, 1)
            Dim ultimoDiaMesActual As Date = primerDiaMesActual.AddMonths(1).AddDays(-1)
            Dim ultimoDiaMesAnterior As Date = primerDiaMesActual.AddDays(-1)

            Dim nombreMesAnterior As String = ObtenerNombreMes(ultimoDiaMesAnterior.Month)
            Dim nombreMesActual As String = ObtenerNombreMes(ultimoDiaMesActual.Month)

            lblPeriodo.Text = $"Correspondiente al mes de {cboMes.Text} de {anioSeleccionado}"
            lblSaldoLibro.Text = $"SALDO SEGÚN LIBRO AL {ultimoDiaMesAnterior.Day} DE {nombreMesAnterior.ToUpper()} DE {ultimoDiaMesAnterior.Year}"
            lblSaldoConciliado.Text = $"SALDO CONCILIADO SEGÚN LIBROS AL {ultimoDiaMesActual.Day} DE {nombreMesActual.ToUpper()} DE {ultimoDiaMesActual.Year}"
            lblSaldoBanco.Text = $"SALDO EN BANCO AL {ultimoDiaMesActual.Day} DE {nombreMesActual.ToUpper()} DE {ultimoDiaMesActual.Year}"
            lblConciliadoBanco.Text = $"SALDO CONCILIADO IGUAL A BANCO {ultimoDiaMesActual.Day} DE {nombreMesActual.ToUpper()} DE {ultimoDiaMesActual.Year}"
        End If
    End Sub

    Private Function ObtenerNombreMes(numeroMes As Integer) As String
        Dim meses() As String = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
        Return meses(numeroMes - 1)
    End Function

    ' ============================================================
    ' BOTÓN PRINCIPAL: CALCULAR CONCILIACIÓN
    ' ============================================================
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        ' Validaciones
        If cboMes.SelectedIndex = -1 Or cboAnio.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor seleccione mes y año.", "Validación",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtSaldoLibro.Text) Then
            MessageBox.Show("Por favor ingrese el Saldo según Libro.", "Validación",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSaldoLibro.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(txtSaldoBanco.Text) Then
            MessageBox.Show("Por favor ingrese el Saldo en Banco.", "Validación",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSaldoBanco.Focus()
            Return
        End If

        Try
            CalcularConciliacion()
        Catch ex As Exception
            MessageBox.Show("Error al calcular conciliación: " & ex.Message, "Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' LÓGICA PRINCIPAL DE CONCILIACIÓN
    ' ============================================================
    Private Sub CalcularConciliacion()
        Dim saldoLibroInicial As Decimal = Convert.ToDecimal(txtSaldoLibro.Text)
        Dim saldoBancoInicial As Decimal = Convert.ToDecimal(txtSaldoBanco.Text)

        ' OBTENER DATOS DEL MES
        Dim totalDepositos As Decimal = ObtenerTotalDepositos()
        Dim totalChequesAnulados As Decimal = ObtenerTotalChequesAnulados()
        Dim totalChequesGirados As Decimal = ObtenerTotalChequesGirados()
        Dim depositosTransito As Decimal = ObtenerDepositosEnTransito()
        Dim chequesCirculacion As Decimal = ObtenerTotalChequesGirados()

        ' ═══════════════════════════════════════════════════════
        ' CALCULAR SALDO SEGÚN LIBROS
        ' ═══════════════════════════════════════════════════════
        Dim subtotalLibro As Decimal = saldoLibroInicial + totalDepositos - totalChequesAnulados
        Dim saldoConciliadoLibro As Decimal = subtotalLibro - totalChequesGirados

        ' ═══════════════════════════════════════════════════════
        ' CALCULAR SALDO SEGÚN BANCO
        ' ═══════════════════════════════════════════════════════
        Dim saldoConciliadoBanco As Decimal = saldoBancoInicial + depositosTransito - chequesCirculacion

        ' ═══════════════════════════════════════════════════════
        ' VALIDAR SI CUADRA
        ' ═══════════════════════════════════════════════════════
        Dim cuadra As Boolean = (Math.Round(saldoConciliadoLibro, 2) = Math.Round(saldoConciliadoBanco, 2))
        Dim diferencia As Decimal = saldoConciliadoLibro - saldoConciliadoBanco

        txtDepositos.Text = totalDepositos.ToString("N2")
        txtChequesAnulados.Text = totalChequesAnulados.ToString("N2")
        txtDepositos2.Text = totalDepositos.ToString("N2")
        txtSubtotal.Text = subtotalLibro.ToString("N2")
        txtChequesGirados.Text = totalChequesGirados.ToString("N2")
        txtChequesGirados2.Text = totalChequesGirados.ToString("N2")
        txtSaldoConciliadoLibro.Text = saldoConciliadoLibro.ToString("N2")
        txtDepositosTransito.Text = depositosTransito.ToString("N2")
        txtChequesCirculacion.Text = totalChequesGirados.ToString("N2")
        txtChequesCirculacion2.Text = totalChequesGirados.ToString("N2")
        txtSaldoConciliadoBanco.Text = saldoConciliadoBanco.ToString("N2")

    End Sub

    ' ============================================================
    ' FUNCIONES PARA OBTENER DATOS DE LA BASE DE DATOS
    ' ============================================================

    Private Function ObtenerTotalDepositos() As Decimal
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()
                Dim query As String = "SELECT COALESCE(SUM(monto), 0) FROM depositos 
                                      WHERE MONTH(fecha_deposito) = @mes AND YEAR(fecha_deposito) = @anio"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@mes", mesSeleccionado)
                    cmd.Parameters.AddWithValue("@anio", anioSeleccionado)
                    Return Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener depósitos: " & ex.Message)
            Return 0
        End Try
    End Function

    Private Function ObtenerTotalChequesAnulados() As Decimal
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()
                ' Cheques anulados EN EL MES de conciliación
                Dim query As String = "SELECT COALESCE(SUM(monto_numerico), 0) FROM cheques 
                                      WHERE anulado = 1 
                                      AND MONTH(fecha_anulacion) = @mes 
                                      AND YEAR(fecha_anulacion) = @anio"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@mes", mesSeleccionado)
                    cmd.Parameters.AddWithValue("@anio", anioSeleccionado)
                    Return Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener cheques anulados: " & ex.Message)
            Return 0
        End Try
    End Function

    Private Function ObtenerTotalChequesGirados() As Decimal
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()
                ' Cheques girados en el mes que NO están anulados
                Dim query As String = "SELECT COALESCE(SUM(monto_numerico), 0) FROM cheques 
                                      WHERE anulado = 0 
                                      AND MONTH(fecha) = @mes 
                                      AND YEAR(fecha) = @anio"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@mes", mesSeleccionado)
                    cmd.Parameters.AddWithValue("@anio", anioSeleccionado)
                    Return Convert.ToDecimal(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener cheques girados: " & ex.Message)
            Return 0
        End Try
    End Function

    Private Function ObtenerDepositosEnTransito() As Decimal
        Return 0

        'Try
        '    Dim total As Decimal = 0

        '    If dgvDepositosTransito IsNot Nothing Then
        '        dgvDepositosTransito.Rows.Clear()
        '    End If

        '    Using conn As MySqlConnection = ObtenerConexion()
        '        conn.Open()
        '        Depósitos del mes que NO están registrados en banco
        '        Dim query As String = "SELECT numero, fecha, concepto, monto FROM depositos 
        '                              WHERE MONTH(fecha) = @mes 
        '                              AND YEAR(fecha) = @anio
        '                              AND (registrado_banco IS NULL OR registrado_banco = 0)"
        '        Using cmd As New MySqlCommand(query, conn)
        '            cmd.Parameters.AddWithValue("@mes", mesSeleccionado)
        '            cmd.Parameters.AddWithValue("@anio", anioSeleccionado)
        '            Using reader As MySqlDataReader = cmd.ExecuteReader()
        '                While reader.Read()
        '                    Dim monto As Decimal = Convert.ToDecimal(reader("monto"))
        '                    total += monto

        '                    If dgvDepositosTransito IsNot Nothing Then
        '                        dgvDepositosTransito.Rows.Add(
        '                            reader("numero").ToString(),
        '                            Convert.ToDateTime(reader("fecha")).ToString("dd/MM/yyyy"),
        '                            reader("concepto").ToString(),
        '                            monto
        '                        )
        '                    End If
        '                End While
        '            End Using
        '        End Using
        '    End Using

        '    Return total
        'Catch ex As Exception
        '    MessageBox.Show("Error al obtener depósitos en tránsito: " & ex.Message)
        '    Return 0
        'End Try
    End Function

    Private Function ObtenerChequesEnCirculacion() As Decimal
        Try
            Dim total As Decimal = 0

            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()
                ' Cheques girados que NO han sido cambiados
                Dim query As String = "SELECT c.numero, c.fecha, p.nombre, c.monto_numerico 
                                      FROM cheques c
                                      LEFT JOIN proveedores p ON c.cod_proveedor = p.codigo
                                      WHERE c.anulado = 0 
                                      AND MONTH(c.fecha) = @mes 
                                      AND YEAR(c.fecha) = @anio
                                      AND (c.fecha_cambio IS NULL)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@mes", mesSeleccionado)
                    cmd.Parameters.AddWithValue("@anio", anioSeleccionado)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim monto As Decimal = Convert.ToDecimal(reader("monto_numerico"))
                            total += monto

                            'If dgvChequesCirculacion IsNot Nothing Then
                            '    dgvChequesCirculacion.Rows.Add(
                            '        reader("numero").ToString(),
                            '        Convert.ToDateTime(reader("fecha")).ToString("dd/MM/yyyy"),
                            '        reader("nombre").ToString(),
                            '        monto
                            '    )
                            'End If
                        End While
                    End Using
                End Using
            End Using

            Return total
        Catch ex As Exception
            MessageBox.Show("Error al obtener cheques en circulación: " & ex.Message)
            Return 0
        End Try
    End Function

    Private Sub btnLimpiarConciliacion_Click(sender As Object, e As EventArgs) Handles btnLimpiarConciliacion.Click
        ' Limpia todos los TextBox relacionados con la conciliación
        txtSaldoLibro.Clear()
        txtSaldoBanco.Clear()
        txtDepositos.Clear()
        txtChequesAnulados.Clear()
        txtDepositos2.Clear()
        txtSubtotal.Clear()
        txtChequesGirados.Clear()
        txtChequesGirados2.Clear()
        txtSaldoConciliadoLibro.Clear()
        txtDepositosTransito.Clear()
        txtChequesCirculacion.Clear()
        txtChequesCirculacion2.Clear()
        txtSaldoConciliadoBanco.Clear()
    End Sub

End Class