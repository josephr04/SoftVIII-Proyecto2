Public Class login
    Private showPassword As Boolean = False

    Private Sub pbcontraseña_Click(sender As Object, e As EventArgs) Handles pbcontraseña.Click
        showPassword = Not showPassword
        If showPassword Then
            ' Estado: MOSTRAR Contraseña (showPassword = True)
            txtcontraseña.PasswordChar = ""
            pbcontraseña.Image = My.Resources.hide
        Else
            ' Estado: OCULTAR Contraseña (showPassword = False)
            txtcontraseña.PasswordChar = "*"
            pbcontraseña.Image = My.Resources.show
        End If
    End Sub

    Private Sub btniniciarsesion_Click(sender As Object, e As EventArgs) Handles btniniciarsesion.Click
        If String.IsNullOrWhiteSpace(txtusuario.Text) OrElse
           String.IsNullOrWhiteSpace(txtcontraseña.Text) Then
            MessageBox.Show("Por favor complete todos los campos
        .", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim usuario As String = txtusuario.Text.Trim()
        Dim contraseña As String = txtcontraseña.Text

        If usuario = "usuario" And contraseña = "123" Then

            Dim formularioPrincipal As New Form1()
            formularioPrincipal.Show()
            Me.Hide()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Error de acceso",
                          MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtcontraseña.Text = ""
            txtusuario.Focus()
        End If

        Dim formularioPrincipal As New Form1()
        formularioPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        Application.Exit()
    End Sub
End Class