<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Menu = New Button()
        Sair = New Button()
        ListBox_Pedidos = New ListBox()
        Label8 = New Label()
        Label4 = New Label()
        QuantidadeBebidaTextBox = New TextBox()
        ComboBox_Bebidas = New ComboBox()
        AdicionarBebidaButton = New Button()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        ComboBox_Pratos = New ComboBox()
        AdicionarPratoButton = New Button()
        QuantidadeTextBox = New TextBox()
        CalcularButton = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Bt_MenuDoDia = New Button()
        Label9 = New Label()
        ComboBox_FormaPagamento = New ComboBox()
        Button1 = New Button()
        LabelHorario = New Label()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Menu
        ' 
        Menu.BackColor = SystemColors.ButtonHighlight
        Menu.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Menu.ForeColor = SystemColors.ControlText
        Menu.Location = New Point(489, 446)
        Menu.Name = "Menu"
        Menu.Size = New Size(101, 36)
        Menu.TabIndex = 97
        Menu.Text = "Menu"
        Menu.UseVisualStyleBackColor = True
        ' 
        ' Sair
        ' 
        Sair.BackColor = SystemColors.ButtonHighlight
        Sair.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Sair.ForeColor = SystemColors.ControlText
        Sair.Location = New Point(596, 446)
        Sair.Name = "Sair"
        Sair.Size = New Size(63, 36)
        Sair.TabIndex = 96
        Sair.Text = "Sair"
        Sair.UseVisualStyleBackColor = True
        ' 
        ' ListBox_Pedidos
        ' 
        ListBox_Pedidos.Font = New Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ListBox_Pedidos.FormattingEnabled = True
        ListBox_Pedidos.ItemHeight = 14
        ListBox_Pedidos.Location = New Point(11, 380)
        ListBox_Pedidos.Name = "ListBox_Pedidos"
        ListBox_Pedidos.Size = New Size(648, 60)
        ListBox_Pedidos.TabIndex = 84
        ListBox_Pedidos.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(403, 238)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 15)
        Label8.TabIndex = 94
        Label8.Text = "QUANTIDADE"
        Label8.Visible = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Leelawadee", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(359, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 14)
        Label4.TabIndex = 93
        Label4.Text = "SELECIONE A BEBIDA"
        Label4.Visible = False
        ' 
        ' QuantidadeBebidaTextBox
        ' 
        QuantidadeBebidaTextBox.Font = New Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point)
        QuantidadeBebidaTextBox.Location = New Point(545, 238)
        QuantidadeBebidaTextBox.Name = "QuantidadeBebidaTextBox"
        QuantidadeBebidaTextBox.Size = New Size(56, 22)
        QuantidadeBebidaTextBox.TabIndex = 92
        QuantidadeBebidaTextBox.TextAlign = HorizontalAlignment.Center
        QuantidadeBebidaTextBox.Visible = False
        ' 
        ' ComboBox_Bebidas
        ' 
        ComboBox_Bebidas.Font = New Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Bebidas.FormattingEnabled = True
        ComboBox_Bebidas.Location = New Point(494, 201)
        ComboBox_Bebidas.Name = "ComboBox_Bebidas"
        ComboBox_Bebidas.Size = New Size(165, 22)
        ComboBox_Bebidas.TabIndex = 91
        ComboBox_Bebidas.Visible = False
        ' 
        ' AdicionarBebidaButton
        ' 
        AdicionarBebidaButton.Font = New Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AdicionarBebidaButton.Location = New Point(459, 268)
        AdicionarBebidaButton.Name = "AdicionarBebidaButton"
        AdicionarBebidaButton.Size = New Size(175, 36)
        AdicionarBebidaButton.TabIndex = 90
        AdicionarBebidaButton.Text = "Adicionar bebida"
        AdicionarBebidaButton.UseVisualStyleBackColor = True
        AdicionarBebidaButton.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Leelawadee", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(2, 340)
        Label7.Name = "Label7"
        Label7.Size = New Size(170, 32)
        Label7.TabIndex = 88
        Label7.Text = "SEU PEDIDO"
        Label7.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(54, 231)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 87
        Label6.Text = "QUANTIDADE"
        Label6.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Leelawadee", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(23, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 14)
        Label5.TabIndex = 86
        Label5.Text = "SELECIONE O PRATO"
        Label5.Visible = False
        ' 
        ' ComboBox_Pratos
        ' 
        ComboBox_Pratos.Font = New Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox_Pratos.FormattingEnabled = True
        ComboBox_Pratos.Location = New Point(150, 201)
        ComboBox_Pratos.Name = "ComboBox_Pratos"
        ComboBox_Pratos.Size = New Size(191, 22)
        ComboBox_Pratos.TabIndex = 85
        ComboBox_Pratos.Visible = False
        ' 
        ' AdicionarPratoButton
        ' 
        AdicionarPratoButton.Font = New Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point)
        AdicionarPratoButton.Location = New Point(125, 268)
        AdicionarPratoButton.Name = "AdicionarPratoButton"
        AdicionarPratoButton.Size = New Size(155, 36)
        AdicionarPratoButton.TabIndex = 83
        AdicionarPratoButton.Text = "Adicionar prato"
        AdicionarPratoButton.UseVisualStyleBackColor = True
        AdicionarPratoButton.Visible = False
        ' 
        ' QuantidadeTextBox
        ' 
        QuantidadeTextBox.Font = New Font("Leelawadee", 9F, FontStyle.Regular, GraphicsUnit.Point)
        QuantidadeTextBox.Location = New Point(188, 231)
        QuantidadeTextBox.Name = "QuantidadeTextBox"
        QuantidadeTextBox.Size = New Size(67, 22)
        QuantidadeTextBox.TabIndex = 82
        QuantidadeTextBox.TextAlign = HorizontalAlignment.Center
        QuantidadeTextBox.Visible = False
        ' 
        ' CalcularButton
        ' 
        CalcularButton.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CalcularButton.Location = New Point(82, 446)
        CalcularButton.Name = "CalcularButton"
        CalcularButton.Size = New Size(212, 36)
        CalcularButton.TabIndex = 81
        CalcularButton.Text = "FINALIZAR COMPRA"
        CalcularButton.UseVisualStyleBackColor = True
        CalcularButton.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(298, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(373, 60)
        Label1.TabIndex = 80
        Label1.Text = "GASTRONOMIA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Showcard Gothic", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Label2.Location = New Point(45, -3)
        Label2.Name = "Label2"
        Label2.Size = New Size(589, 79)
        Label2.TabIndex = 79
        Label2.Text = "GUSTAVO SAVORY"
        ' 
        ' Bt_MenuDoDia
        ' 
        Bt_MenuDoDia.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Bt_MenuDoDia.Location = New Point(23, 140)
        Bt_MenuDoDia.Name = "Bt_MenuDoDia"
        Bt_MenuDoDia.Size = New Size(648, 36)
        Bt_MenuDoDia.TabIndex = 78
        Bt_MenuDoDia.Text = "Pressine para realizar o seu pedido"
        Bt_MenuDoDia.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(203, 328)
        Label9.Name = "Label9"
        Label9.Size = New Size(138, 15)
        Label9.TabIndex = 98
        Label9.Text = "FORMA DE PAGAMENTO"
        Label9.Visible = False
        ' 
        ' ComboBox_FormaPagamento
        ' 
        ComboBox_FormaPagamento.FormattingEnabled = True
        ComboBox_FormaPagamento.Location = New Point(391, 325)
        ComboBox_FormaPagamento.Name = "ComboBox_FormaPagamento"
        ComboBox_FormaPagamento.Size = New Size(186, 23)
        ComboBox_FormaPagamento.TabIndex = 99
        ComboBox_FormaPagamento.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonHighlight
        Button1.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(339, 446)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 38)
        Button1.TabIndex = 100
        Button1.Text = "MENU ESCOLHA"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' LabelHorario
        ' 
        LabelHorario.AutoSize = True
        LabelHorario.Location = New Point(203, 354)
        LabelHorario.Name = "LabelHorario"
        LabelHorario.Size = New Size(176, 15)
        LabelHorario.TabIndex = 101
        LabelHorario.Text = "DIGITE O HORARIO DA RESERVA"
        LabelHorario.Visible = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"19:30", "20:00"})
        ComboBox1.Location = New Point(385, 354)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(205, 23)
        ComboBox1.TabIndex = 102
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(673, 502)
        Controls.Add(ComboBox1)
        Controls.Add(LabelHorario)
        Controls.Add(Button1)
        Controls.Add(ComboBox_FormaPagamento)
        Controls.Add(Label9)
        Controls.Add(Menu)
        Controls.Add(Sair)
        Controls.Add(ListBox_Pedidos)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(QuantidadeBebidaTextBox)
        Controls.Add(ComboBox_Bebidas)
        Controls.Add(AdicionarBebidaButton)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(ComboBox_Pratos)
        Controls.Add(AdicionarPratoButton)
        Controls.Add(QuantidadeTextBox)
        Controls.Add(CalcularButton)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(Bt_MenuDoDia)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Menu As Button
    Friend WithEvents Sair As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents QuantidadeBebidaTextBox As TextBox
    Friend WithEvents ComboBox_Bebidas As ComboBox
    Friend WithEvents AdicionarBebidaButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_Pratos As ComboBox
    Friend WithEvents AdicionarPratoButton As Button
    Friend WithEvents QuantidadeTextBox As TextBox
    Friend WithEvents CalcularButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Bt_MenuDoDia As Button
    Public WithEvents ListBox_Pedidos As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox_FormaPagamento As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelHorario As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
