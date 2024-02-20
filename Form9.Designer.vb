<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form9))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ExecutarEntrega = New Button()
        LabelNome = New Label()
        LabelEmail = New Label()
        LabelContribuinte = New Label()
        LabelLocalidade = New Label()
        LabelComplemento = New Label()
        LabelNumero = New Label()
        LabelRua = New Label()
        LabelTelefone = New Label()
        ListBox_PedidosForm9 = New ListBox()
        Label_Mensagem = New Label()
        Label_FormaPagamento = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label_HorarioEscolhido = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-3, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(674, 222)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 20.25F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(12, 215)
        Label1.Name = "Label1"
        Label1.Size = New Size(169, 38)
        Label1.TabIndex = 1
        Label1.Text = "DELIVERY"
        ' 
        ' ExecutarEntrega
        ' 
        ExecutarEntrega.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ExecutarEntrega.Location = New Point(226, 459)
        ExecutarEntrega.Name = "ExecutarEntrega"
        ExecutarEntrega.Size = New Size(159, 35)
        ExecutarEntrega.TabIndex = 3
        ExecutarEntrega.Text = "Executar Entrega"
        ExecutarEntrega.UseVisualStyleBackColor = True
        ' 
        ' LabelNome
        ' 
        LabelNome.AllowDrop = True
        LabelNome.AutoEllipsis = True
        LabelNome.AutoSize = True
        LabelNome.Location = New Point(191, 324)
        LabelNome.Name = "LabelNome"
        LabelNome.Size = New Size(65, 21)
        LabelNome.TabIndex = 91
        LabelNome.Text = "Labelnome"
        LabelNome.UseCompatibleTextRendering = True
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(154, 414)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(66, 15)
        LabelEmail.TabIndex = 92
        LabelEmail.Text = "Labelnome"
        ' 
        ' LabelContribuinte
        ' 
        LabelContribuinte.AutoSize = True
        LabelContribuinte.Location = New Point(226, 414)
        LabelContribuinte.Name = "LabelContribuinte"
        LabelContribuinte.Size = New Size(66, 15)
        LabelContribuinte.TabIndex = 93
        LabelContribuinte.Text = "Labelnome"
        ' 
        ' LabelLocalidade
        ' 
        LabelLocalidade.AutoSize = True
        LabelLocalidade.Location = New Point(154, 345)
        LabelLocalidade.Name = "LabelLocalidade"
        LabelLocalidade.Size = New Size(66, 15)
        LabelLocalidade.TabIndex = 94
        LabelLocalidade.Text = "Labelnome"
        ' 
        ' LabelComplemento
        ' 
        LabelComplemento.AutoSize = True
        LabelComplemento.Location = New Point(226, 385)
        LabelComplemento.Name = "LabelComplemento"
        LabelComplemento.Size = New Size(66, 15)
        LabelComplemento.TabIndex = 95
        LabelComplemento.Text = "Labelnome"
        ' 
        ' LabelNumero
        ' 
        LabelNumero.AutoSize = True
        LabelNumero.Location = New Point(154, 360)
        LabelNumero.Name = "LabelNumero"
        LabelNumero.Size = New Size(66, 15)
        LabelNumero.TabIndex = 96
        LabelNumero.Text = "Labelnome"
        ' 
        ' LabelRua
        ' 
        LabelRua.AutoSize = True
        LabelRua.Location = New Point(154, 385)
        LabelRua.Name = "LabelRua"
        LabelRua.Size = New Size(66, 15)
        LabelRua.TabIndex = 97
        LabelRua.Text = "Labelnome"
        ' 
        ' LabelTelefone
        ' 
        LabelTelefone.AutoSize = True
        LabelTelefone.Location = New Point(226, 360)
        LabelTelefone.Name = "LabelTelefone"
        LabelTelefone.Size = New Size(66, 15)
        LabelTelefone.TabIndex = 98
        LabelTelefone.Text = "Labelnome"
        ' 
        ' ListBox_PedidosForm9
        ' 
        ListBox_PedidosForm9.FormattingEnabled = True
        ListBox_PedidosForm9.ItemHeight = 15
        ListBox_PedidosForm9.Location = New Point(378, 255)
        ListBox_PedidosForm9.Name = "ListBox_PedidosForm9"
        ListBox_PedidosForm9.Size = New Size(225, 64)
        ListBox_PedidosForm9.TabIndex = 99
        ' 
        ' Label_Mensagem
        ' 
        Label_Mensagem.AutoSize = True
        Label_Mensagem.Location = New Point(463, 345)
        Label_Mensagem.Name = "Label_Mensagem"
        Label_Mensagem.Size = New Size(41, 15)
        Label_Mensagem.TabIndex = 100
        Label_Mensagem.Text = "Label2"
        ' 
        ' Label_FormaPagamento
        ' 
        Label_FormaPagamento.AutoSize = True
        Label_FormaPagamento.Location = New Point(463, 396)
        Label_FormaPagamento.Name = "Label_FormaPagamento"
        Label_FormaPagamento.Size = New Size(41, 15)
        Label_FormaPagamento.TabIndex = 101
        Label_FormaPagamento.Text = "Label2"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(128, 459)
        Button1.Name = "Button1"
        Button1.Size = New Size(92, 35)
        Button1.TabIndex = 102
        Button1.Text = "VOLTAR"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 285)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 103
        Label2.Text = "Nome:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 324)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 104
        Label3.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 360)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 105
        Label4.Text = "Label4"
        ' 
        ' Label_HorarioEscolhido
        ' 
        Label_HorarioEscolhido.AutoSize = True
        Label_HorarioEscolhido.Location = New Point(463, 371)
        Label_HorarioEscolhido.Name = "Label_HorarioEscolhido"
        Label_HorarioEscolhido.Size = New Size(41, 15)
        Label_HorarioEscolhido.TabIndex = 106
        Label_HorarioEscolhido.Text = "Label5"
        ' 
        ' Form9
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(671, 506)
        Controls.Add(Label_HorarioEscolhido)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label_FormaPagamento)
        Controls.Add(Label_Mensagem)
        Controls.Add(ListBox_PedidosForm9)
        Controls.Add(LabelTelefone)
        Controls.Add(LabelRua)
        Controls.Add(LabelNumero)
        Controls.Add(LabelComplemento)
        Controls.Add(LabelLocalidade)
        Controls.Add(LabelContribuinte)
        Controls.Add(LabelEmail)
        Controls.Add(LabelNome)
        Controls.Add(ExecutarEntrega)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form9"
        Text = "FormPedidos"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ExecutarEntrega As Button
    Friend WithEvents LabelNome As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelContribuinte As Label
    Friend WithEvents LabelLocalidade As Label
    Friend WithEvents LabelComplemento As Label
    Friend WithEvents LabelNumero As Label
    Friend WithEvents LabelRua As Label
    Friend WithEvents LabelTelefone As Label
    Friend WithEvents ListBox_PedidosForm9 As ListBox
    Friend WithEvents Label_Mensagem As Label
    Friend WithEvents Label_FormaPagamento As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_HorarioEscolhido As Label
End Class
