Public Class Form3

    Private Sub tela_inicial_Click(sender As Object, e As EventArgs) Handles tela_inicial.Click
        Dim form8 As New Form8()
        Me.Hide()
        Form8.ShowDialog()
        Form8.Dispose()

    End Sub

    Private Sub sobre_o_mestre_Click(sender As Object, e As EventArgs) Handles sobre_o_mestre.Click
        Dim form4 As New Form4()
        Me.Hide()
        Form4.ShowDialog()
        Form4.Dispose()
    End Sub

    Private Sub Cadastro_Click(sender As Object, e As EventArgs) Handles Cadastro.Click
        Dim formCadastro As New FormCadastro()
        Me.Hide()
        formCadastro.ShowDialog()
        formCadastro.Dispose()
    End Sub
End Class