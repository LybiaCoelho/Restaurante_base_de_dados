Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private precoDosPratos As New Dictionary(Of String, Double)
    Private precoDasBebidas As New Dictionary(Of String, Double)
    Private mensagemCalculo As String = ""
    Private itensDoPedido As New List(Of String)


    Public Sub New()
        InitializeComponent()

        precoDosPratos.Add("Massas Italianas", 10.0)
        precoDosPratos.Add("Lasanha", 12.0)
        precoDosPratos.Add("Espaguete à bolonhesa", 8.0)
        precoDosPratos.Add("Bife de contrafilé", 16.0)
        precoDosPratos.Add("Costelas grelhadas", 13.0)
        precoDosPratos.Add("Picanha", 19.0)
        precoDosPratos.Add("Frutos do Mar", 25.0)
        precoDosPratos.Add("Camarão grelhado", 20.0)
        precoDosPratos.Add("lagosta com manteiga", 35.0)
        precoDosPratos.Add("Hambúrguer vegano", 13.0)
        precoDosPratos.Add("Curry de grão-de-bico", 11.0)
        precoDosPratos.Add("Salada caprese", 17.0)
        precoDosPratos.Add("Sushi e sashimi variados", 22.0)
        precoDosPratos.Add("Tempurá de legumes e camarão", 23.0)
        precoDosPratos.Add("Yakisoba", 16.0)
        precoDosPratos.Add("Bacalhau à Brás", 22.0)
        precoDosPratos.Add("Tripas a moda do Porto", 23.0)
        precoDosPratos.Add("Francesinha", 16.0)
        precoDasBebidas.Add("Água", 2.0)
        precoDasBebidas.Add("Refrigerante", 3.5)
        precoDasBebidas.Add("Suco Natural", 5.0)
        precoDasBebidas.Add("Cerveja", 4.0)
        precoDasBebidas.Add("Vinho Tinto", 12.0)


    End Sub

    Private Sub Bt_MenuDoDia_Click(sender As Object, e As EventArgs) Handles Bt_MenuDoDia.Click
        Dim thisDate As Date
        Dim diasem As Integer
        diasem = Weekday(thisDate)
        thisDate = Today
        ComboBox_Pratos.Items.Clear()
        ListBox_Pedidos.Items.Clear()

        If diasem = 1 Then
            MessageBox.Show("Estimado cliente, lamentamos informar que neste dia encontramo-nos encerrados." & vbCrLf & "Com os melhores cumprimentos." & vbCrLf & "A Gerência", "Restaurante Gustavo Savory")
        ElseIf diasem = 2 Then
            ComboBox_Pratos.Items.AddRange({"Massas Italianas", "Lasanha", "Espaguete à bolonhesa"})
            ComboBox_Bebidas.Items.AddRange({"Água", "Refrigerante", "Suco Natural", "Cerveja", "Vinho Tinto"})
        ElseIf diasem = 3 Then
            ComboBox_Pratos.Items.AddRange({"Bife de contrafilé", "Costelas grelhadas", "Picanha"})
            ComboBox_Bebidas.Items.AddRange({"Água", "Refrigerante", "Suco Natural", "Cerveja", "Vinho Tinto"})
        ElseIf diasem = 4 Then
            ComboBox_Pratos.Items.AddRange({"Frutos do Mar", "Camarão grelhado", "lagosta com manteiga"})
            ComboBox_Bebidas.Items.AddRange({"Água", "Refrigerante", "Suco Natural", "Cerveja", "Vinho Tinto"})
        ElseIf diasem = 5 Then
            ComboBox_Pratos.Items.AddRange({"Hambúrguer vegano", "Curry de grão-de-bico", "Salada caprese"})
            ComboBox_Bebidas.Items.AddRange({"Água", "Refrigerante", "Suco Natural", "Cerveja", "Vinho Tinto"})
        ElseIf diasem = 6 Then
            ComboBox_Pratos.Items.AddRange({"Sushi e sashimi variados", "Tempurá de legumes e camarão", "Yakisoba"})
            ComboBox_Bebidas.Items.AddRange({"Água", "Refrigerante", "Suco Natural", "Cerveja", "Vinho Tinto"})
        ElseIf diasem = 7 Then
            ComboBox_Pratos.Items.AddRange({"Bacalhau à Brás", "Tripas à Moda do Porto", "Francesinha"})
            ComboBox_Bebidas.Items.AddRange({"Água", "Refrigerante", "Suco Natural", "Cerveja", "Vinho Tinto"})
        Else
            MessageBox.Show("Selecione um dia da semana válido.", "Restaurante Gustavo Savory")
        End If

        Label5.Show()
        ComboBox_Pratos.Show()
        Label4.Show()
        ComboBox_Bebidas.Show()
        Label6.Show()
        QuantidadeTextBox.Show()
        Label8.Show()
        QuantidadeBebidaTextBox.Show()
        AdicionarPratoButton.Show()
        AdicionarBebidaButton.Show()
        Label7.Show()
        ListBox_Pedidos.Show()
        CalcularButton.Show()
        ComboBox_FormaPagamento.Show()
        Label9.Show()


    End Sub

    Private Sub CalcularButton_Click(sender As Object, e As EventArgs) Handles CalcularButton.Click
        Dim totalGeral As Double = 0.0


        For i As Integer = 0 To ListBox_Pedidos.Items.Count - 1
            Dim item As String = ListBox_Pedidos.Items(i).ToString()
            Dim partes() As String = item.Split(" - ")
            Dim nomeItem As String = partes(0)
            Dim quantidade As Integer = CInt(partes(1))

            If precoDosPratos.ContainsKey(nomeItem) Then
                Dim precoItem As Double = precoDosPratos(nomeItem)
                Dim precoTotalItem As Double = precoItem * quantidade
                totalGeral += precoTotalItem

            ElseIf precoDasBebidas.ContainsKey(nomeItem) Then
                Dim precoItem As Double = precoDasBebidas(nomeItem)
                Dim precoTotalItem As Double = precoItem * quantidade
                totalGeral += precoTotalItem
            End If
        Next

        mensagemCalculo = $"Total a pagar: R$ {totalGeral:F2}"

        ' Passar a mensagem para o Form9
        Dim form9 As New Form9()
        form9.MensagemDoForm2 = mensagemCalculo
        form9.ItensDoPedido = ListBox_Pedidos.Items.Cast(Of String)().ToList()

        ' Configure a forma de pagamento antes de mostrar o Form9
        form9.FormaPagamentoDoForm2 = ComboBox_FormaPagamento.SelectedItem.ToString()
        form9.Label_HorarioEscolhido.Text = Me.ComboBox1.Text

        form9.ShowDialog()



        ' Limpar a lista de pedidos após a conclusão do pedido
        ListBox_Pedidos.Items.Clear()
        ComboBox_Pratos.SelectedIndex = -1
        QuantidadeTextBox.Text = ""
        ComboBox_Bebidas.SelectedIndex = -1
        QuantidadeBebidaTextBox.Text = ""
        Me.Hide()

    End Sub

    Private Sub AdicionarPratoButton_Click(sender As Object, e As EventArgs) Handles AdicionarPratoButton.Click
        Dim itemSelecionado As String = ComboBox_Pratos.SelectedItem.ToString()
        Dim quantidade As Integer = CInt(QuantidadeTextBox.Text)

        ListBox_Pedidos.Items.Add($"{itemSelecionado} - {quantidade}")
    End Sub


    Private Sub AdicionarBebidaButton_Click(sender As Object, e As EventArgs) Handles AdicionarBebidaButton.Click
        Dim bebidaSelecionada As String = ComboBox_Bebidas.SelectedItem.ToString()
        Dim quantidade As Integer = CInt(QuantidadeBebidaTextBox.Text)

        ListBox_Pedidos.Items.Add($"{bebidaSelecionada} - {quantidade}")

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



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_FormaPagamento.Items.Add("Cartão de Crédito")
        ComboBox_FormaPagamento.Items.Add("Dinheiro")
        ComboBox_FormaPagamento.Items.Add("Vale Refeição")
        ComboBox_FormaPagamento.Items.Add("Outro")
        ComboBox_FormaPagamento.SelectedIndex = 0




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form1 As New Form1()
        Me.Hide()
        form1.ShowDialog()
        form1.Dispose()
    End Sub


End Class
