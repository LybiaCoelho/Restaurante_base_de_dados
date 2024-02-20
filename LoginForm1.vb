Imports MySql.Data.MySqlClient
Public Class LoginForm1
    Private nomeUsuarioLogado As String = ""
    Dim connectionString As String = "Server=localhost;Database=Restaurante;Uid=root;Pwd=1234;"
    Dim conexao As MySqlConnection = New MySqlConnection(connectionString)
    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome de exibição etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim usuario As String = TxtUsuario.Text
        Dim senha As String = TxtSenha.Text
        ' Verifique se o nome de usuário e a senha estão corretos
        If VerificarCredenciais(TxtUsuario.Text, TxtSenha.Text) Then
            ' Se as credenciais estiverem corretas, atribua o nome de usuário à variável nomeUsuarioLogado
            ModuloConfig.NomeUsuarioLogado = TxtUsuario.Text

            ' Oculte o formulário de login e mostre o próximo formulário (por exemplo, Form7)
            Dim formBemVindo As New Form1()
            Me.Hide()
            formBemVindo.ShowDialog()
            formBemVindo.Dispose()
        Else
            ' Exiba uma mensagem de erro caso as credenciais estejam incorretas
            MessageBox.Show("Credenciais incorretas. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Função para verificar as credenciais (substitua isso pela verificação real)
    Private Function VerificarCredenciais(usuario As String, senha As String) As Boolean
        Try
            conexao.Open()

            ' Consulta SQL para verificar as credenciais
            Dim query As String = "SELECT COUNT(*) FROM cadastro WHERE usuario = @Usuario AND senha = @Senha"
            Using cmd As New MySqlCommand(query, conexao)
                cmd.Parameters.AddWithValue("@Usuario", usuario)
                cmd.Parameters.AddWithValue("@Senha", senha)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                ' Se o resultado da consulta for maior que 0, as credenciais são válidas
                Return count > 0
            End Using
        Catch ex As Exception
            ' Lida com exceções de banco de dados
            MessageBox.Show("Erro ao verificar as credenciais: " & ex.Message, "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            conexao.Close()
        End Try
    End Function


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
