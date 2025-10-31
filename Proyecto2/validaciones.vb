Imports ReaLTaiizor.Controls

Module validaciones

    Public Sub SoloLetrasTextBox(sender As Object, e As EventArgs)
        Dim tb As ReaLTaiizor.Controls.AloneTextBox = CType(sender, ReaLTaiizor.Controls.AloneTextBox)
        Dim txt = tb.Text
        Dim nuevoTexto = ""
        For Each c As Char In txt
            If Char.IsLetter(c) OrElse Char.IsWhiteSpace(c) OrElse "áéíóúÁÉÍÓÚñÑ".Contains(c) Then
                nuevoTexto &= c
            End If
        Next
        If nuevoTexto <> txt Then
            tb.Text = nuevoTexto
        End If
    End Sub

    Public Sub SoloNumerosTextBox(sender As Object, e As EventArgs)
        Dim tb As ReaLTaiizor.Controls.AloneTextBox = CType(sender, ReaLTaiizor.Controls.AloneTextBox)
        Dim txt = tb.Text
        Dim nuevoTexto = ""

        For Each c As Char In txt
            If Char.IsDigit(c) Then
                nuevoTexto &= c
            End If
        Next

        If nuevoTexto <> txt Then
            tb.Text = nuevoTexto
        End If
    End Sub

    Public Sub SoloDineroTextBox(sender As Object, e As EventArgs)
        Dim tb As ReaLTaiizor.Controls.AloneTextBox = CType(sender, ReaLTaiizor.Controls.AloneTextBox)
        Dim txt = tb.Text
        Dim nuevoTexto = ""
        Dim tienePunto As Boolean = False
        Dim posicionPunto As Integer = -1

        For i As Integer = 0 To txt.Length - 1
            Dim c As Char = txt(i)

            ' Permitir solo números y un punto decimal
            If Char.IsDigit(c) Then
                ' Si ya hay un punto, verificar que no se excedan 2 decimales
                If tienePunto Then
                    If (i - posicionPunto) <= 2 Then
                        nuevoTexto &= c
                    End If
                Else
                    nuevoTexto &= c
                End If
            ElseIf c = "." AndAlso Not tienePunto Then
                ' Solo permitir un punto
                tienePunto = True
                posicionPunto = nuevoTexto.Length
                nuevoTexto &= c
            End If
        Next

        If nuevoTexto <> txt Then
            tb.Text = nuevoTexto
        End If
    End Sub

    Public Function NumeroALetras(numero As Decimal) As String
        If numero = 0 Then Return "cero"

        Dim parteEntera As Long = Math.Floor(numero)
        Dim parteDecimal As Integer = Math.Round((numero - parteEntera) * 100)

        Dim resultado As String = ConvertirEnteroALetras(parteEntera)

        If parteDecimal > 0 Then
            resultado &= " con " & parteDecimal.ToString() & "/100 centavos"
        End If

        Return resultado
    End Function

    Private Function ConvertirEnteroALetras(numero As Long) As String
        If numero = 0 Then Return "cero"

        Dim unidades() As String = {"", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve"}
        Dim especiales() As String = {"diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve"}
        Dim decenas() As String = {"", "", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"}
        Dim centenas() As String = {"", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos"}

        If numero < 10 Then
            Return unidades(numero)
        ElseIf numero < 20 Then
            Return especiales(numero - 10)
        ElseIf numero < 30 Then
            If numero = 20 Then
                Return "veinte"
            Else
                Return "veinti" & unidades(numero Mod 10)
            End If
        ElseIf numero < 100 Then
            Dim dec = numero \ 10
            Dim uni = numero Mod 10
            If uni = 0 Then
                Return decenas(dec)
            Else
                Return decenas(dec) & " y " & unidades(uni)
            End If
        ElseIf numero < 1000 Then
            Dim cen = numero \ 100
            Dim resto = numero Mod 100
            Dim resultado = ""
            If numero = 100 Then
                Return "cien"
            Else
                resultado = centenas(cen)
            End If
            If resto > 0 Then
                resultado &= " " & ConvertirEnteroALetras(resto)
            End If
            Return resultado
        ElseIf numero < 1000000 Then
            Dim miles = numero \ 1000
            Dim resto = numero Mod 1000
            Dim resultado = ""
            If miles = 1 Then
                resultado = "mil"
            Else
                resultado = ConvertirEnteroALetras(miles) & " mil"
            End If
            If resto > 0 Then
                resultado &= " " & ConvertirEnteroALetras(resto)
            End If
            Return resultado
        ElseIf numero < 1000000000 Then
            Dim millones = numero \ 1000000
            Dim resto = numero Mod 1000000
            Dim resultado = ""
            If millones = 1 Then
                resultado = "un millón"
            Else
                resultado = ConvertirEnteroALetras(millones) & " millones"
            End If
            If resto > 0 Then
                resultado &= " " & ConvertirEnteroALetras(resto)
            End If
            Return resultado
        Else
            Return "número demasiado grande"
        End If
    End Function

End Module
