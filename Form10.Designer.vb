<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCadastro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(FormCadastro))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        txtnome = New TextBox()
        TxtRua = New TextBox()
        TxtComplemento = New TextBox()
        TxtNumero = New TextBox()
        TxtUsuario = New TextBox()
        TxtCidade = New TextBox()
        TxtContribuinte = New TextBox()
        TxtSenha = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        TxtEmail = New TextBox()
        TxtTelefone = New TextBox()
        cmd_salvar = New Button()
        Tela_inicial = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(707, 183)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(14, 201)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 1
        Label1.Text = "NOME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(14, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 2
        Label2.Text = "RUA:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(273, 320)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 3
        Label3.Text = "NIF:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(12, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 4
        Label4.Text = "NÚMERO:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(273, 281)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 20)
        Label5.TabIndex = 5
        Label5.Text = "COMPLEMENTO:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(12, 393)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 20)
        Label6.TabIndex = 6
        Label6.Text = "USUÁRIO:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(289, 396)
        Label7.Name = "Label7"
        Label7.Size = New Size(79, 20)
        Label7.TabIndex = 7
        Label7.Text = "SENHA:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(14, 316)
        Label8.Name = "Label8"
        Label8.Size = New Size(87, 20)
        Label8.TabIndex = 8
        Label8.Text = "CIDADE:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(80, 423)
        Label9.Name = "Label9"
        Label9.Size = New Size(119, 15)
        Label9.TabIndex = 9
        Label9.Text = "Máximo 10 caracteres"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(324, 423)
        Label10.Name = "Label10"
        Label10.Size = New Size(359, 15)
        Label10.TabIndex = 10
        Label10.Text = "A senha tem que conter uma letra maiúscula e  máximo 8 caracteres"
        ' 
        ' txtnome
        ' 
        txtnome.Location = New Point(90, 201)
        txtnome.Name = "txtnome"
        txtnome.Size = New Size(593, 23)
        txtnome.TabIndex = 11
        ' 
        ' TxtRua
        ' 
        TxtRua.Location = New Point(90, 247)
        TxtRua.Name = "TxtRua"
        TxtRua.Size = New Size(593, 23)
        TxtRua.TabIndex = 12
        ' 
        ' TxtComplemento
        ' 
        TxtComplemento.Location = New Point(437, 282)
        TxtComplemento.Name = "TxtComplemento"
        TxtComplemento.Size = New Size(246, 23)
        TxtComplemento.TabIndex = 13
        ' 
        ' TxtNumero
        ' 
        TxtNumero.Location = New Point(115, 278)
        TxtNumero.Name = "TxtNumero"
        TxtNumero.Size = New Size(152, 23)
        TxtNumero.TabIndex = 14
        ' 
        ' TxtUsuario
        ' 
        TxtUsuario.Location = New Point(118, 393)
        TxtUsuario.Name = "TxtUsuario"
        TxtUsuario.Size = New Size(163, 23)
        TxtUsuario.TabIndex = 15
        ' 
        ' TxtCidade
        ' 
        TxtCidade.Location = New Point(104, 317)
        TxtCidade.Name = "TxtCidade"
        TxtCidade.Size = New Size(163, 23)
        TxtCidade.TabIndex = 16
        ' 
        ' TxtContribuinte
        ' 
        TxtContribuinte.Location = New Point(332, 321)
        TxtContribuinte.Name = "TxtContribuinte"
        TxtContribuinte.Size = New Size(354, 23)
        TxtContribuinte.TabIndex = 17
        ' 
        ' TxtSenha
        ' 
        TxtSenha.Location = New Point(371, 397)
        TxtSenha.Name = "TxtSenha"
        TxtSenha.Size = New Size(312, 23)
        TxtSenha.TabIndex = 18
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(14, 357)
        Label11.Name = "Label11"
        Label11.Size = New Size(82, 20)
        Label11.TabIndex = 19
        Label11.Text = "E-MAIL:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(389, 361)
        Label12.Name = "Label12"
        Label12.Size = New Size(116, 20)
        Label12.TabIndex = 20
        Label12.Text = "TELEFONE:"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(102, 358)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(281, 23)
        TxtEmail.TabIndex = 21
        ' 
        ' TxtTelefone
        ' 
        TxtTelefone.Location = New Point(516, 358)
        TxtTelefone.Name = "TxtTelefone"
        TxtTelefone.Size = New Size(170, 23)
        TxtTelefone.TabIndex = 22
        ' 
        ' cmd_salvar
        ' 
        cmd_salvar.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        cmd_salvar.Location = New Point(406, 456)
        cmd_salvar.Name = "cmd_salvar"
        cmd_salvar.Size = New Size(137, 27)
        cmd_salvar.TabIndex = 23
        cmd_salvar.Text = "SALVAR"
        cmd_salvar.UseVisualStyleBackColor = True
        ' 
        ' Tela_inicial
        ' 
        Tela_inicial.Font = New Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Tela_inicial.Location = New Point(210, 456)
        Tela_inicial.Name = "Tela_inicial"
        Tela_inicial.Size = New Size(137, 27)
        Tela_inicial.TabIndex = 24
        Tela_inicial.Text = "TELA INICIAL"
        Tela_inicial.UseVisualStyleBackColor = True
        ' 
        ' FormCadastro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(709, 495)
        Controls.Add(Tela_inicial)
        Controls.Add(cmd_salvar)
        Controls.Add(TxtTelefone)
        Controls.Add(TxtEmail)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(TxtSenha)
        Controls.Add(TxtContribuinte)
        Controls.Add(TxtCidade)
        Controls.Add(TxtUsuario)
        Controls.Add(TxtNumero)
        Controls.Add(TxtComplemento)
        Controls.Add(TxtRua)
        Controls.Add(txtnome)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "FormCadastro"
        Text = "Form10"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtnome As TextBox
    Friend WithEvents TxtRua As TextBox
    Friend WithEvents TxtComplemento As TextBox
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtCidade As TextBox
    Friend WithEvents TxtContribuinte As TextBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelefone As TextBox
    Friend WithEvents cmd_salvar As Button
    Friend WithEvents Tela_inicial As Button
End Class
