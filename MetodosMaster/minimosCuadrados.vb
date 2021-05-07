Public Class minimosCuadrados
    Dim i, c, redon, ib, grado As Integer
    Dim g As Graphics

    Private Sub graficar_Click(sender As Object, e As EventArgs) Handles graficar.Click
        g = CreateGraphics()

        For i = 1 To n
            Gráfica.Series(0).Points.AddXY(x(i), y(i))
        Next
        Gráfica.Series(1).Points.AddXY(vx, vy)
        Gráfica.Series(2).Points.AddXY(x(1), a + b * x(1))
        Gráfica.Series(2).Points.AddXY(x(n), a + b * x(n))

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        xmedia = sx / n
        ymedia = sy / n
        b = (sxy - n * (xmedia * ymedia)) / (scx - n * (xmedia) ^ 2)
        a = (ymedia - b * (xmedia))
        vy = a + b * vx
        TextBox1.Text = "Y(" & vx & ")=" & vy
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Main.Show()
    End Sub

    Dim n, vx, vy, x(), y(), sx, sy, scx, sxy, a, b, xmedia, ymedia As Single
    Private Sub btnParejas_Click(sender As Object, e As EventArgs) Handles btnParejas.Click
        c = tc.Text
        n = tn.Text
        vx = tvx.Text
        redon = c + 2
        ReDim x(0 To n), y(0 To n)

        For i = 1 To n
            x(i) = InputBox("x(" & i & ") = ")
            y(i) = InputBox("y(" & i & ") = ")
            dgvSalida.Rows.Add(i, x(i), y(i))
            sx = sx + x(i)
            sy = sy + y(i)
            sxy = sxy + x(i) * y(i)
            scx = scx + x(i) ^ 2
        Next
    End Sub
End Class