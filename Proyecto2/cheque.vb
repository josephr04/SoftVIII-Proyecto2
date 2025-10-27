Imports System.IO
Imports MySql.Data.MySqlClient

Public Class btnregistrar

    Private Sub cheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarGastos()
        CargarProveedor()
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

End Class
