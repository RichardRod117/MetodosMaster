Public Class Main

    Private Sub Impares_Click(sender As Object, e As EventArgs) Handles Impares.Click
        Me.Hide()
        Imp.Show()
    End Sub

    Private Sub Raiz_Click(sender As Object, e As EventArgs) Handles Raiz.Click
        Me.Hide()
        RaizC2.Show()
    End Sub

    Private Sub Btn_Biseccion_Click(sender As Object, e As EventArgs) Handles Btn_Biseccion.Click
        Me.Hide()
        Biseccion.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        JACOBI.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Interpolacion_Lagrange.Show()
    End Sub

    Private Sub raizOrioginal_Click(sender As Object, e As EventArgs) Handles raizOrioginal.Click
        Me.Hide()
        RaizOriginal.Show()
    End Sub

    Private Sub btnReglaF_Click(sender As Object, e As EventArgs) Handles btnReglaF.Click
        Me.Hide()
        ReglaFalsa.Show()
    End Sub

    Private Sub GE_Click(sender As Object, e As EventArgs) Handles GE.Click
        Me.Hide()
        Gauss_Eidel.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        minimosCuadrados.Show()
    End Sub
End Class
