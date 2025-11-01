Imports MySql.Data.MySqlClient

Public Class deposito

    Private Sub deposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler txtmontodep.TextChanged, AddressOf SoloDineroTextBox
        CargarDepositos()
    End Sub

    Private Sub CargarDepositos()
        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()

                ' Traer todos los depósitos
                Dim query As String = "SELECT tipo_deposito, fecha_deposito, monto FROM depositos ORDER BY fecha_deposito DESC"

                Using cmd As New MySqlCommand(query, conn)
                    Dim da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable
                    da.Fill(dt)

                    DataGridViewdep.AutoGenerateColumns = False
                    DataGridViewdep.DataSource = dt

                    DataGridViewdep.Columns("fecha").DataPropertyName = "fecha_deposito"
                    DataGridViewdep.Columns("tipo").DataPropertyName = "tipo_deposito"
                    DataGridViewdep.Columns("monto").DataPropertyName = "monto"
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los depósitos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnregistrardeposito_Click(sender As Object, e As EventArgs) Handles btnregistrardeposito.Click
        If String.IsNullOrWhiteSpace(txtmontodep.Text) OrElse
           cbotiposdeposito.SelectedValue Is Nothing Then
            MessageBox.Show("Por favor complete todos los campos antes de registrar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = ObtenerConexion()
                conn.Open()
                Dim query As String = "INSERT INTO depositos (tipo_deposito, fecha_deposito, monto)
                                      VALUES (@tipo_deposito, @fecha_deposito, @monto)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@tipo_deposito", cbotiposdeposito.SelectedItem)
                    cmd.Parameters.AddWithValue("@fecha_deposito", PoisonDateTimeDeposito.Value)
                    cmd.Parameters.AddWithValue("@monto", Convert.ToDecimal(txtmontodep.Text))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Cheque registrado exitosamente.")

            LimpiarCampos()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al registrar el cheque: " & ex.Message)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        txtmontodep.Text = ""
        txtmontodep.Text = ""
        PoisonDateTimeDeposito.Value = DateTime.Now
        cbotiposdeposito.SelectedIndex = -1
    End Sub

    Private Sub btncancelardep_Click(sender As Object, e As EventArgs) Handles btncancelardep.Click
        LimpiarCampos()
    End Sub
End Class