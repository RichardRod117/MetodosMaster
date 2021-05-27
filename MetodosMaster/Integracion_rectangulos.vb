Imports info.lundin.math
Public Class Integracion_rectangulos

    Dim i, k, n, cifras, redon As Integer
    Dim g As Graphics

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtA.Clear()
        txtB.Clear()
        txtCifras.Clear()
        txtFuncion.Clear()
        txtNum.Clear()
        dgvSalida.Rows.Clear()
        Grafica.Series.Clear()
    End Sub

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        g = CreateGraphics()
        j = a - 1
        Do While j <= b + 1
            If j < b And j > a Then
                Grafica.Series(1).Points.AddXY(Math.Round(j, 2), Math.Round(f(j), 2))
            End If
            Grafica.Series(0).Points.AddXY(Math.Round(j, 2), Math.Round(f(j), 2))
            j = j + 0.1
        Loop
        '9-x^2
    End Sub

    Dim a, b, h, suma, ec, err(500), integral(500), j As Single
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Function f(x As Single) As Single
        'Librería para aceptar una función
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("e", 2.7182)
        parser.Values.Add("pi", 3.1416)
        Return parser.Parse(txtFuncion.Text)
    End Function

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        a = txtA.Text
        b = txtB.Text
        n = 100
        i = 0
        cifras = txtCifras.Text
        redon = cifras + 2
        ec = 0.5 * 10 ^ (-cifras)
        h = (b - a) / n

        suma = 0

        For k = 0 To n - 1
            suma = suma + h * f(a + k * h)
        Next

        integral(i) = suma
        err(i) = 1
        dgvSalida.Rows.Add(n, Math.Round(integral(i), redon), "---")

        Do While err(i) > ec
            n += 100
            i += 1
            suma = 0
            h = (b - a) / n

            For k = 0 To n - 1
                suma = suma + h * f(a + k * h)
            Next

            integral(i) = suma
            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))

            dgvSalida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))

        Loop


    End Sub


End Class