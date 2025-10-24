Public Class Form1

    ' --- Método para cargar formularios hijos ---
    Sub childform(ByVal frm As Form)
        ParrotWidgetPanel1.Controls.Clear()
        frm.TopLevel = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        ParrotWidgetPanel1.Controls.Add(frm)
        frm.Show()
    End Sub

    ' --- Resalta el botón activo ---
    Private Sub HighlightButton(btn As Button)
        ' Restaurar estilo de todos
        For Each b As Button In {Button1, Button4, Button5}
            b.FlatStyle = FlatStyle.Flat
            b.FlatAppearance.BorderSize = 1
            b.FlatAppearance.BorderColor = Color.Gray
            b.BackColor = Color.FromArgb(35, 35, 35)
            b.ForeColor = Color.White
        Next

        ' Efecto de iluminación del botón activo
        btn.FlatAppearance.BorderColor = Color.DarkSalmon
        btn.FlatAppearance.BorderSize = 2
        btn.BackColor = Color.FromArgb(0, 60, 120)
    End Sub

    ' --- Botones ---
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        childform(New cheque)
        HighlightButton(Button4)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        childform(New deposito)
        HighlightButton(Button5)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        childform(New conciliacion)
        HighlightButton(Button1)
    End Sub

End Class
