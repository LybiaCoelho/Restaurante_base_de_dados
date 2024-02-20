Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles Menu.Click
        Dim form7 As New Form7()
        Me.Hide()
        form7.ShowDialog()
        form7.Dispose()
    End Sub

    Private Sub Sair_Click(sender As Object, e As EventArgs) Handles Sair.Click
        End
    End Sub

    Private Sub FinalizarCompraButton_Click(sender As Object, e As EventArgs) Handles FinalizarCompraButton.Click
        Dim form12 As New Form12()


        form12.TextBox2.Text = Me.TextBox2.Text
        form12.TextBox1.Text = Me.TextBox1.Text
        form12.TextBox3.Text = Me.TextBox3.Text
        form12.TextBox4.Text = Me.TextBox4.Text




        Me.Hide()
        form12.ShowDialog()
        form12.Dispose()
    End Sub
End Class