Public Class Imp
    Dim fin As Integer
    Dim k As Integer
    Dim impar As Integer
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Try
            fin = Tn.Text
            For k = 1 To fin
                impar = 2 * k - 1
                Salida.Rows.Add(k, impar)

            Next
        Catch ex As Exception


        End Try
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Imp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class