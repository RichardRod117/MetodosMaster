Public Class Gauss_Seidel

    Dim i, j, c, redon As Integer
    Dim x(50), y(50), z(50), ex(50), ey(50), ez(50), ec, a(3, 3), b(3) As Single

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCifras.Clear()
        dgvSalida.Rows.Clear()

        txt1.Visible = False
        txt2.Visible = False
        txt3.Visible = False
        txt4.Visible = False
        txt5.Visible = False
        txt6.Visible = False
        txt7.Visible = False
        txt8.Visible = False
        txt9.Visible = False
        txt10.Visible = False
        txt11.Visible = False
        txt12.Visible = False

        lbl1.Visible = False
        lbl2.Visible = False
        lbl3.Visible = False
        lbl4.Visible = False
        lbl5.Visible = False
        lbl6.Visible = False
        lbl7.Visible = False
        lbl8.Visible = False
        lbl9.Visible = False

        txtSalidaX.Visible = False
        txtSalidaY.Visible = False
        txtSalidaZ.Visible = False
        lblSalidaX.Visible = False
        lblSalidaY.Visible = False
        lblSalidaZ.Visible = False

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        c = txtCifras.Text
        redon = c + 2
        ec = 0.5 * 10 ^ (-c)

        i = 0
        x(i) = 0
        y(i) = 0
        z(i) = 0
        ex(i) = 1
        ey(i) = 1
        ez(i) = 1

        dgvSalida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon), "---", "---", "---")

        Do While ex(i) > ec Or ey(i) > ec Or ez(i) > ec
            i = i + 1

            'Jacobi
            'x(i) = (b(1) - a(1, 2) * y(i - 1) - a(1, 3) * z(i - 1)) / a(1, 1)
            'y(i) = (b(2) - a(2, 1) * x(i - 1) - a(2, 3) * z(i - 1)) / a(2, 2)
            'z(i) = (b(3) - a(3, 1) * x(i - 1) - a(3, 2) * y(i - 1)) / a(3, 3)

            'Gauss-Eidel
            x(i) = (b(1) - a(1, 2) * y(i - 1) - a(1, 3) * z(i - 1)) / a(1, 1)
            y(i) = (b(2) - a(2, 1) * x(i) - a(2, 3) * z(i - 1)) / a(2, 2)
            z(i) = (b(3) - a(3, 1) * x(i) - a(3, 2) * y(i)) / a(3, 3)

            ex(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            ey(i) = Math.Abs((y(i) - y(i - 1)) / y(i))
            ez(i) = Math.Abs((z(i) - z(i - 1)) / z(i))

            dgvSalida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon), Math.Round(ex(i), redon), Math.Round(ey(i), redon), Math.Round(ez(i), redon))
        Loop

        txtSalidaX.Visible = True
        txtSalidaY.Visible = True
        txtSalidaZ.Visible = True
        lblSalidaX.Visible = True
        lblSalidaY.Visible = True
        lblSalidaZ.Visible = True

        txtSalidaX.Text = Math.Round(x(i), redon)
        txtSalidaY.Text = Math.Round(y(i), redon)
        txtSalidaZ.Text = Math.Round(z(i), redon)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Main.Show()
    End Sub
    Private Sub btnCoeficientes_Click(sender As Object, e As EventArgs) Handles btnCoeficientes.Click
        For i = 1 To 3
            For j = 1 To 3
                a(i, j) = InputBox("a(" & i & "," & j & ")=")
            Next
        Next
        For i = 1 To 3
            b(i) = InputBox("b(" & i & ")=")
        Next
        txt1.Text = a(1, 1)
        txt2.Text = a(1, 2)
        txt3.Text = a(1, 3)
        txt4.Text = a(2, 1)
        txt5.Text = a(2, 2)
        txt6.Text = a(2, 3)
        txt7.Text = a(3, 1)
        txt8.Text = a(3, 2)
        txt9.Text = a(3, 3)
        txt10.Text = b(1)
        txt11.Text = b(2)
        txt12.Text = b(3)

        txt1.Visible = True
        txt2.Visible = True
        txt3.Visible = True
        txt4.Visible = True
        txt5.Visible = True
        txt6.Visible = True
        txt7.Visible = True
        txt8.Visible = True
        txt9.Visible = True
        txt10.Visible = True
        txt11.Visible = True
        txt12.Visible = True

        lbl1.Visible = True
        lbl2.Visible = True
        lbl3.Visible = True
        lbl4.Visible = True
        lbl5.Visible = True
        lbl6.Visible = True
        lbl7.Visible = True
        lbl8.Visible = True
        lbl9.Visible = True

    End Sub
End Class