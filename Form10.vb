Imports MySql.Data.MySqlClient

Public Class FormCadastro

    ' Função para recuperar dados do banco de dados e retorná-los como uma lista de strings
    Public Function RecuperarDadosDoBanco() As List(Of String)
        Dim connectionStr As String = "Server=localhost;Database=Restaurante;Uid=root;Pwd=1234;"
        Dim dados As New List(Of String)

        Using connection As New MySqlConnection(connectionStr)
            connection.Open()

            Dim query As String = "SELECT * FROM cadastro"
            Using command As New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Adicionar cada dado à lista de strings
                        dados.Add(reader.GetString(0))
                    End While
                End Using
            End Using
        End Using

        Return dados
    End Function

    ' Propriedade para armazenar os dados preenchidos
    Public Property DadosPreenchidos As String
    ' Certifique-se de ter configurado a conexão com o banco de dados
    Dim connectionString As String = "Server=localhost;Database=Restaurante;Uid=root;Pwd=1234;"
    Dim conexao As MySqlConnection = New MySqlConnection(connectionString)

    Private Sub cmd_salvar_Click(sender As Object, e As EventArgs) Handles cmd_salvar.Click
        If String.IsNullOrWhiteSpace(txtnome.Text) OrElse
           String.IsNullOrWhiteSpace(TxtRua.Text) OrElse
           String.IsNullOrWhiteSpace(TxtNumero.Text) OrElse
           String.IsNullOrWhiteSpace(TxtEmail.Text) OrElse
            String.IsNullOrWhiteSpace(TxtCidade.Text) OrElse
           String.IsNullOrWhiteSpace(TxtTelefone.Text) OrElse
           String.IsNullOrWhiteSpace(TxtContribuinte.Text) OrElse
           String.IsNullOrWhiteSpace(TxtUsuario.Text) OrElse
           String.IsNullOrWhiteSpace(TxtSenha.Text) Then
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return ' Saia da função sem executar a inserção
        End If


        Try
            ' Verifique  se a conexão está fechada e abra-a, se necessário
            If conexao.State = ConnectionState.Closed Then
                conexao.Open()
            End If

            ' Crie um comando SQL para inserir os dados na tabela
            Dim comando As MySqlCommand = New MySqlCommand("INSERT INTO cadastro (Nome, rua, numero, complemento,cidade, email, telefone, Contribuinte, usuario, senha) VALUES (@Nome, @rua, @numero, @complemento,@cidade, @email, @telefone, @Contribuinte, @usuario, @senha)", conexao)

            ' Substitua os valores dos parâmetros pelos valores dos TextBox ou controles equivalentes no seu formulário
            comando.Parameters.AddWithValue("@Nome", txtnome.Text)
            comando.Parameters.AddWithValue("@rua", TxtRua.Text)
            comando.Parameters.AddWithValue("@numero", Integer.Parse(TxtNumero.Text))
            comando.Parameters.AddWithValue("@complemento", TxtComplemento.Text)
            comando.Parameters.AddWithValue("@email", TxtEmail.Text)
            comando.Parameters.AddWithValue("@cidade", TxtCidade.Text)
            comando.Parameters.AddWithValue("@telefone", TxtTelefone.Text)
            comando.Parameters.AddWithValue("@Contribuinte", TxtContribuinte.Text)
            comando.Parameters.AddWithValue("@usuario", TxtUsuario.Text)
            comando.Parameters.AddWithValue("@senha", TxtSenha.Text)

            ' Execute o comando SQL para inserir os dados
            comando.ExecuteNonQuery()

            ' Feche a conexão com o banco de dados
            conexao.Close()

            ' Exiba uma mensagem de sucesso
            MessageBox.Show("Cadastro realizado com sucesso!")
        Catch ex As Exception
            ' Em caso de erro, exiba uma mensagem de erro
            MessageBox.Show("Ocorreu um erro ao cadastrar: " & ex.Message)
        End Try
        Dim loginForm1 As New LoginForm1()
        Me.Hide()
        loginForm1.ShowDialog()
        loginForm1.Dispose()
    End Sub

    Private Sub tela_inicial_Click(sender As Object, e As EventArgs) Handles Tela_inicial.Click
        ' Volte para a tela inicial ou faça outra ação necessária
        Dim form8 As New Form8()
        Me.Hide()
        form8.ShowDialog()
        form8.Dispose()
    End Sub


End Class