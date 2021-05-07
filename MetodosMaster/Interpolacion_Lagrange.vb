Public Class Interpolacion_Lagrange

    'primer grado
    'yx = ((vx - xi(ib + 1)) / (xi(ib) - xi(ib + 1)) * yi(ib)) + ((vx - xi(ib)) / (xi(ib + 1) - xi(ib)) * yi(ib + 1))

    'segundo
    'vy = ((vx - x(ib + 1)) * (vx - x(ib + 2))) / ((x(ib) - x(ib + 1)) * (x(ib) - x(ib + 2))) * y(ib) + ((vx - x(ib)) * (vx - x(ib + 2))) / ((x(ib + 1) - x(ib)) * (x(ib + 1) - x(ib + 2))) * y(ib + 1) + ((vx - x(ib)) * (vx - x(ib + 1))) / ((x(ib + 2) - x(ib)) * (x(ib + 2) - x(ib + 1))) * y(ib + 2)

    Dim i, c, redon, ib, grado As Integer

    Private Sub btnGraficar_Click(sender As Object, e As EventArgs) Handles btnGraficar.Click
        g = CreateGraphics() 'definir variable
        For i = 0 To n - 1
            Grafica.Series(0).Points.AddXY(Math.Round(x(i), 2), y(i))
        Next
        Grafica.Series(1).Points.AddXY(Math.Round(vx, 2), vy)
    End Sub

    Dim n, vx, vy, x(), y() As Single
    Dim g As Graphics

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        Main.Show()
    End Sub

    Private Sub cmbGrado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGrado.SelectedIndexChanged
        grado = cmbGrado.SelectedIndex
        If grado Then
            vy = ((vx - x(ib + 1)) * (vx - x(ib + 2))) / ((x(ib) - x(ib + 1)) * (x(ib) - x(ib + 2))) * y(ib) + ((vx - x(ib)) * (vx - x(ib + 2))) / ((x(ib + 1) - x(ib)) * (x(ib + 1) - x(ib + 2))) * y(ib + 1) + ((vx - x(ib)) * (vx - x(ib + 1))) / ((x(ib + 2) - x(ib)) * (x(ib + 2) - x(ib + 1))) * y(ib + 2)
        Else
            vy = ((vx - x(ib + 1)) / (x(ib) - x(ib + 1)) * y(ib)) + ((vx - x(ib)) / (x(ib + 1) - x(ib)) * y(ib + 1))
        End If
        txtInterpolacion.Text = "f( " & vx & " ) = " & vy
    End Sub

    Private Sub btnParejas_Click(sender As Object, e As EventArgs) Handles btnParejas.Click
        c = txtCifras.Text
        n = txtParejas.Text
        vx = txtNum.Text
        redon = c + 2
        ReDim x(0 To n), y(0 To n)

        For i = 0 To n - 1
            x(i) = InputBox("x(" & i & ") = ")
            y(i) = InputBox("y(" & i & ") = ")
            dgvSalida.Rows.Add(i, x(i), y(i))
        Next
        i = 0
        Do While vx > x(i)
            i += 1
        Loop
        ib = i - 1
        txtIb.Text = ib
    End Sub


End Class