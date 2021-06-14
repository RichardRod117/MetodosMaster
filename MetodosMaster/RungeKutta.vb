Imports info.lundin.math
Public Class RungeKutta
    Dim x(500), y(500), h, xf, j, A As Double
    Dim k1(500), k2(500), k3(500), k4(500) As Single

    Private Sub fRungeKutta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tx.Clear()
        ty.Clear()
        txf.Clear()
        tf.Clear()
        tc.Clear()
        th.Clear()
        dgvSalida.Rows.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Main.Show()
    End Sub

    Dim i, c, redon As Integer

    Function f(x As Single, y As Single) As Single
        'Librería para aceptar una función
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("y", y)
        parser.Values.Add("xy", x * y)
        parser.Values.Add("yx", y * x)
        Return parser.Parse(tf.Text)
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = 0
        y(i) = ty.Text
        x(i) = tx.Text
        c = tc.Text
        redon = c + 2
        h = th.Text
        xf = txf.Text

        dgvSalida.Rows.Add(i, x(0), y(0))
        'i = 1
        j = x(i)

        Do While xf > j
            x(i + 1) = x(i) + h

            k1(i) = f(x(i), y(i))
            k2(i) = f(x(i) + (h / 2), y(i) + (h / 2) * k1(i))
            k3(i) = f(x(i) + (h / 2), y(i) + (h / 2) * k2(i))
            k4(i) = f(x(i + 1), y(i) + h * k3(i))

            y(i + 1) = y(i) + (h / 6) * (k1(i) + 2 * k2(i) + 2 * k3(i) + k4(i))
            dgvSalida.Rows.Add(i + 1, Math.Round(x(i + 1), redon), Math.Round(y(i + 1), redon))
            i = i + 1
            j = j + h
        Loop
        txtResult.Text = Math.Round(y(i), redon)

    End Sub
End Class