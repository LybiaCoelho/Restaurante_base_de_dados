Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Public Class Form9
    Public Property idUsuario As Integer ' Declare a propriedade
    Public Property ItensDoPedido As List(Of String)
    Public Property FormaPagamentoDoForm2 As String
    Public Property HorarioEscolhido As String
        Get
            Return Label_HorarioEscolhido.Text
        End Get
        Set(value As String)
            Label_HorarioEscolhido.Text = value
        End Set
    End Property


    ' Propriedade para armazenar os dados do pedido
    Public Property DadosDoPedido As String ' Obter os dados preenchidos do Form10
        Get
            Return Label_Mensagem.Text
        End Get
        Set(value As String)
            Label_Mensagem.Text = value
        End Set
    End Property


    Public Property MensagemDoForm2 As String
        Get
            Return Label_Mensagem.Text
        End Get
        Set(value As String)
            ' Define o texto da Label com a mensagem
            Label_Mensagem.Text = value
        End Set
    End Property



    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Nome de usuário do cliente logado (você deve obtê-lo após o login)
        Dim nomeUsuarioLogado As String = ModuloConfig.NomeUsuarioLogado

        ' Configurar a string de conexão ao banco de dados
        Dim connectionString As String = "Server=localhost;Database=Restaurante;Uid=root;Pwd=1234;"

        ' Criar uma conexão com o banco de dados
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Consulta SQL para buscar informações do cliente com base no nome de usuário
            Dim query As String = "SELECT * FROM cadastro WHERE usuario = @usuario"

            ' Criar um comando SQL com a consulta e a conexão
            Using command As New MySqlCommand(query, connection)
                ' Adicionar o parâmetro @Usuario com o valor do nome de usuário do cliente logado
                command.Parameters.AddWithValue("@usuario", nomeUsuarioLogado)


                ' Executar o comando SQL e obter um leitor de dados
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Verificar se há dados e preencher as informações do cliente
                If reader.Read() Then
                    Dim nome As String = reader("Nome").ToString()
                    Dim rua As String = reader("rua").ToString()
                    Dim numero As String = reader("numero").ToString()
                    Dim cidade As String = reader("cidade").ToString()
                    Dim complemento As String = reader("complemento").ToString()
                    Dim contribuinte As String = reader("contribuinte").ToString()
                    Dim email As String = reader("email").ToString()
                    Dim telefone As String = reader("telefone").ToString()
                    LabelNome.Text = nome
                    LabelRua.Text = rua
                    LabelNumero.Text = numero
                    LabelLocalidade.Text = cidade
                    LabelComplemento.Text = complemento
                    LabelContribuinte.Text = contribuinte
                    LabelEmail.Text = email
                    LabelTelefone.Text = telefone


                    reader.Close()
                End If
            End Using
        End Using


        If ItensDoPedido IsNot Nothing AndAlso ItensDoPedido.Count > 0 Then
            ' Adicione os itens à ListBox_PedidosForm9
            ListBox_PedidosForm9.Items.AddRange(ItensDoPedido.ToArray())
        End If
        Label_FormaPagamento.Text = $"Forma de Pagamento: {FormaPagamentoDoForm2}"




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExecutarEntrega.Click
        MessageBox.Show("Seu pedido foi realizado com sucesso! O Restaurante Gustavo Savory agradece a preferência.", "Pedido Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Fechar o Form9 após exibir a mensagem
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form2 As New Form2()
        Me.Hide()
        Form2.ShowDialog()
        Form2.Dispose()
    End Sub

End Class