Public Class Form8
    Public Property Origem As String = ""

    Private Sub APRESENTAÇÃO_Click(sender As Object, e As EventArgs) Handles Apresentacao.Click
        Dim form3 As New Form3()
        Me.Hide()
        form3.ShowDialog()
        form3.Dispose()
    End Sub

    Private Sub Sobre_o_mestre_Click(sender As Object, e As EventArgs) Handles Sobre_o_mestre.Click
        Dim form4 As New Form4()
        Me.Hide()
        form4.ShowDialog()
        form4.Dispose()
    End Sub

    Private Sub Cadastro_Click(sender As Object, e As EventArgs) Handles Cadastro.Click
        Dim formCadastro As New FormCadastro()
        Me.Hide()
        formCadastro.ShowDialog()
        formCadastro.Dispose()
    End Sub

    Private Sub carta_Click(sender As Object, e As EventArgs) Handles carta.Click
        Dim form7 As New Form7()
        Me.Hide()
        form7.ShowDialog()
        form7.Dispose()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim loginForm1 As New LoginForm1()
        Me.Hide()
        loginForm1.ShowDialog()
        loginForm1.Dispose()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class