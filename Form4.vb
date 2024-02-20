Imports System.Windows

Public Class Form4
    Private Sub tela_inicial_Click(sender As Object, e As EventArgs) Handles tela_inicial.Click
        Dim form8 As New Form8()
        Me.Hide()
        Form8.ShowDialog()
        Form8.Dispose()
    End Sub

    Private Sub Apresentacao_Click(sender As Object, e As EventArgs) Handles Apresentacao.Click
        Dim form3 As New Form3()
        Me.Hide()
        Form3.ShowDialog()
        Form3.Dispose()
    End Sub


    Private Sub Cadrastro_Click(sender As Object, e As EventArgs) Handles Cadrastro.Click
        Dim formCadastro As New FormCadastro()
        Me.Hide()
        formCadastro.ShowDialog()
        formCadastro.Dispose()
    End Sub
End Class