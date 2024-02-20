Public Class Form1
    Public Property Origem As String = ""
    Public Property ExibirBotaoLoginCadastro As Boolean
    Private escolhaCliente As String = ""
    Private form2 As Form2

    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles Menu.Click
        ModuloConfig.Origem = "Form1"
        ModuloConfig.ExibirBotaoLoginCadastro = False
        ModuloConfig.ExibirBotaoVoltar = True

        Dim form7 As New Form7()
        Me.Hide()
        form7.ShowDialog()
        Me.Show()
    End Sub

    Private Sub DeliveryPedido_Click(sender As Object, e As EventArgs) Handles Button_Delivery.Click
        Dim form2 As New Form2()

        escolhaCliente = "Delivery"

        ' Executa a lógica relacionada ao "Delivery" imediatamente
        ' Exemplo: Exibe o Form2 sem a opção de horário


        form2.ShowDialog()
        form2.Dispose()


    End Sub

    Private Sub ReservaPedido_Click(sender As Object, e As EventArgs) Handles ReservaPedido.Click
        Dim form5 As New Form5()
        Me.Hide()
        form5.ShowDialog()
        form5.Dispose()
    End Sub

    Private Sub TakeWayPedido_Click(sender As Object, e As EventArgs) Handles Button_TakeAway.Click
        form2 = New Form2()
        escolhaCliente = "TakeAway"

        ' Executa a lógica relacionada ao "TakeAway" imediatamente
        ' Exemplo: Exibe o Form2 com a opção de horário


        ' Exibe o Form2 e aguarda até que ele seja fechado
        form2.ShowDialog()

        ' Após o Form2 ser fechado, você pode acessar HorarioEscolhido:

        Form9.ShowDialog()

        ' Certifique-se de liberar recursos após o uso
        form2.Dispose()
        form9.Dispose()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class