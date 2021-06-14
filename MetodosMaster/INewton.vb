Public Class INewton

    Dim i, j, k, c, redon As Integer
    Dim n, vx, vy, ib, m, s, x(), y(), cf(), fact, sum, dk() As Single

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCifras.Clear()
        txtIb.Clear()
        txtInter.Clear()
        txtM.Clear()
        txtS.Clear()
        txtValorInter.Clear()
        Grafica.Series.Clear()
        dgvSal1.Rows.Clear()
        dgvSal2.Rows.Clear()

    End Sub

    Dim g As Graphics

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        g = CreateGraphics() 'definir variable
        For i = 0 To n - 1
            Grafica.Series(0).Points.AddXY(Math.Round(x(i), 2), y(i))
        Next
        Grafica.Series(1).Points.AddXY(Math.Round(vx, 2), vy)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        c = txtCifras.Text
        n = txtPar.Text
        vx = txtValorInter.Text
        redon = c + 2
        ReDim x(0 To n), y(0 To n)

        For i = 0 To n - 1
            x(i) = InputBox("x(" & i & ") = ")
            y(i) = InputBox("y(" & i & ") = ")
            dgvSal1.Rows.Add(i, x(i), y(i))
            dgvSal1.Rows.Add("", "")
        Next
        i = 0
        Do While vx > x(i)
            i += 1
        Loop
        ib = i - 1
        txtIb.Text = ib

        m = n - (ib + 1)
        s = (vx - x(ib)) / (x(ib + 1) - x(ib))
        txtM.Text = m
        txtS.Text = s

        ReDim cf(0 To m), dk(0 To m)
        k = 0
        dk(k) = y(ib)
        cf(k) = 1
        vy = cf(0) * dk(0)
        dgvSal2.Rows.Add(cf(0), Math.Round(dk(0), redon))
        'aux = 1
        For k = 1 To m
            fact = 1
            For i = 1 To k
                fact = fact * (s - (i - 1)) / i
            Next
            cf(k) = fact

            'Revisar desde aqui
            sum = 0
            For j = 0 To k 'Para la sumatoria

                fact = 1
                For i = 1 To j ' Para el factorial
                    fact = fact * (k - (i - 1)) / i
                Next

                sum = sum + (((-1) ^ j) * fact * y(ib + k - j))

            Next

            dk(k) = sum
            dgvSal2.Rows.Add(cf(k), Math.Round(dk(k), redon))
            dgvSal1.Rows((2 * ib + k)).Cells((k + 2)).Value = dk(k)
            'dgvSal1.Rows((2 * ib + aux)).Cells(aux + 2).Value = dk(k)
            'aux = aux + 1

            vy = vy + cf(k) * dk(k)
        Next

        txtInter.Text = Math.Round(vy, redon)

    End Sub
End Class