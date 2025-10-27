Public Class login
    Private showPassword As Boolean = False

    Private Sub pbcontraseña_Click(sender As Object, e As EventArgs) Handles pbcontraseña.Click

        ' 1. Cambia el estado (de verdadero a falso, o viceversa)
        showPassword = Not showPassword

        ' 2. Verifica el nuevo estado y aplica los cambios apropiados
        If showPassword Then
            ' Estado: MOSTRAR Contraseña (showPassword = True)

            ' La contraseña ahora se muestra (carácter vacío)
            txtcontraseña.PasswordChar = ""

            ' El botón ahora debe ofrecer la opción de OCULTAR (ícono "hide")
            pbcontraseña.Image = My.Resources.hide
        Else
            ' Estado: OCULTAR Contraseña (showPassword = False)

            ' La contraseña ahora se oculta (carácter '*')
            txtcontraseña.PasswordChar = "*"

            ' El botón ahora debe ofrecer la opción de MOSTRAR (ícono "show")
            pbcontraseña.Image = My.Resources.show
        End If
    End Sub


End Class