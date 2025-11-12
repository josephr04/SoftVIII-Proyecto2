Imports System.IO
Imports MySql.Data.MySqlClient

Public Class conciliacion
    Private Sub conciliacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Dim mesSeleccionado As Integer = cboMes.SelectedIndex + 1
            Dim anioSeleccionado As Integer = CInt(cboAnio.SelectedItem)

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
End Class