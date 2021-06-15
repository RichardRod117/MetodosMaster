Imports info.lundin.math

Public Class CuadraturaGauss

    Dim i, k, n, cifras, redon, nFila As Integer
    Dim a, b, h, suma, ec, err(500), integral(500), j, xk, yk, ck As Single
    Dim g As Graphics

    Dim ExcelTab = New Microsoft.Office.Interop.Excel.Application
    Dim path As String = Environment.CurrentDirectory + "\" + "Tabla Cuadratura"
    Dim libro = ExcelTab.Workbooks.Open(Filename:=path)

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        g = CreateGraphics()
        j = a - 1
        Do While j <= b + 1
            If j = 0 Then
                j = 0.1
            End If
            If j < b And j > a Then
                chartSalida.Series(0).Points.AddXY(Math.Round(j, 2), f(j))
            End If
            chartSalida.Series(1).Points.AddXY(Math.Round(j, 2), f(j))
            j = j + 0.1
        Loop
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        a = txtA.Text
        b = txtB.Text
        n = 1
        i = 0
        cifras = txtCifras.Text
        redon = cifras + 2
        ec = 0.5 * 10 ^ (-cifras)
        suma = 0

        For Each celda In libro.Sheets(1).Range("a2:a37")
            If celda.value = n Then
                nFila = celda.row
            End If
        Next

        For k = 1 To n
            xk = libro.sheets(1).cells(nFila + k - 1, 3).value
            ck = libro.sheets(1).cells(nFila + k - 1, 4).value
            suma = suma + ck * f((b + a) / 2 + (b - a) / 2 * xk)
        Next

        integral(i) = ((b - a) / 2) * suma

        err(i) = 1
        dgvSalida.Rows.Add(n, Math.Round(integral(i), redon), "---")

        Do While err(i) > ec

            n = n + 1
            i = i + 1
            suma = 0

            For Each celda In libro.Sheets(1).Range("a2:a37")
                If celda.value = n Then
                    nFila = celda.row
                End If
            Next

            For k = 1 To n
                xk = libro.sheets(1).cells(nFila + k - 1, 3).value
                ck = libro.sheets(1).cells(nFila + k - 1, 4).value
                suma = suma + ck * f((b + a) / 2 + (b - a) / 2 * xk)
            Next

            integral(i) = ((b - a) / 2) * suma

            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))
            dgvSalida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))

        Loop
        TextBox1.Text = Math.Round(integral(i), redon)

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtFuncion.Clear()
        txtA.Clear()
        txtB.Clear()
        txtCifras.Clear()
        dgvSalida.Rows.Clear()
        TextBox1.Clear()
        chartSalida.Series.Clear()

    End Sub

    Function f(x As Single) As Single
        'Librería para aceptar una función
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("e", 2.7183)
        parser.Values.Add("pi", 3.1416)
        Return parser.Parse(txtFuncion.Text)
    End Function

End Class
