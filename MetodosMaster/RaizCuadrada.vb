Imports info.lundin.math
Public Class RaizC2
    Dim i As Integer
    Dim c As Integer
    Dim x(50) As Single
    Dim ec As Single
    Dim err(50) As Single
    Dim redon As Integer
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Hide()
        Main.Show()
    End Sub

    Function f(x As Single) As Single
        'Librería para aceptar una función
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tf.Text)
    End Function

    Function fd(x As Single) As Single
        'Librería para aceptar una función
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        Return parser.Parse(tfd.Text)
    End Function


    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        x(i) = Ti.Text
        c = Tc.Text
        ec = 0.5 * 10 ^ (-c)
        err(i) = 1
        redon = c + 2
        Salida.Rows.Add(i, Math.Round(x(i), redon), "- - - -")
        Do While err(i) > ec

            i = i + 1
            'x(i) = 0.5 * (x(i - 1) + 2 / x(i - 1))
            x(i) = x(i - 1) - f(x(i - 1)) / fd(x(i - 1))
            err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon))
        Loop
    End Sub
End Class