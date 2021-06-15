Imports info.lundin.math
Public Class Euler
    Dim x(500), y(500), h, xf, j As Single

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tx.Clear()
        ty.Clear()
        txf.Clear()
        th.Clear()
        tf.Clear()
        tc.Clear()
        txtResult.Clear()
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
        i = 1
        j = x(0)

        Do While xf >= j And Not AreSingleEquals(xf, j)
            x(i) = x(i - 1) + h
            y(i) = y(i - 1) + h * f(x(i - 1), y(i - 1)) 'A=y(i - 1) + h * f(x(i - 1), y(i - 1))
            'y(i)=y(i-1) +(h/2)*(f(x(i - 1), y(i - 1))+f(x(i - 1)+h, A)) USAR DOBLE PARA QUE NO SE PASE
            dgvSalida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon))
            txtResult.Text = Math.Round(y(i), redon)
            i += 1
            j = j + h

        Loop
    End Sub

    Function AreSingleEquals(n1 As Single, n2 As Single) As Boolean
        Dim acceptableDifference As Double = 0.000001
        Dim absoluteDifference As Double = Math.Abs(n1 - n2)
        Return absoluteDifference <= acceptableDifference
    End Function
End Class