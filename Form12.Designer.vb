<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form12))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Button1 = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label_HorarioEscolhido = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        LabelTelefone = New Label()
        LabelRua = New Label()
        LabelNumero = New Label()
        LabelComplemento = New Label()
        LabelLocalidade = New Label()
        LabelContribuinte = New Label()
        LabelEmail = New Label()
        LabelNome = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(720, 241)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 27.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(164, 229)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 46)
        Label1.TabIndex = 1
        Label1.Text = "RESERVA"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(164, 422)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 36)
        Button1.TabIndex = 3
        Button1.Text = "Executar Reserva"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox4.Location = New Point(325, 405)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(187, 27)
        TextBox4.TabIndex = 147
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox3.Location = New Point(325, 363)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(187, 27)
        TextBox3.TabIndex = 146
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(325, 278)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(187, 27)
        TextBox2.TabIndex = 144
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Leelawadee", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(325, 317)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(187, 27)
        TextBox1.TabIndex = 143
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label_HorarioEscolhido
        ' 
        Label_HorarioEscolhido.AutoSize = True
        Label_HorarioEscolhido.Location = New Point(418, 264)
        Label_HorarioEscolhido.Name = "Label_HorarioEscolhido"
        Label_HorarioEscolhido.Size = New Size(41, 15)
        Label_HorarioEscolhido.TabIndex = 162
        Label_HorarioEscolhido.Text = "Label5"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(-33, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 161
        Label4.Text = "Label4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(-33, 217)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 160
        Label3.Text = "Label3"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(-33, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 159
        Label2.Text = "Nome:"
        ' 
        ' LabelTelefone
        ' 
        LabelTelefone.AutoSize = True
        LabelTelefone.Location = New Point(181, 253)
        LabelTelefone.Name = "LabelTelefone"
        LabelTelefone.Size = New Size(66, 15)
        LabelTelefone.TabIndex = 155
        LabelTelefone.Text = "Labelnome"
        ' 
        ' LabelRua
        ' 
        LabelRua.AutoSize = True
        LabelRua.Location = New Point(109, 278)
        LabelRua.Name = "LabelRua"
        LabelRua.Size = New Size(66, 15)
        LabelRua.TabIndex = 154
        LabelRua.Text = "Labelnome"
        ' 
        ' LabelNumero
        ' 
        LabelNumero.AutoSize = True
        LabelNumero.Location = New Point(109, 253)
        LabelNumero.Name = "LabelNumero"
        LabelNumero.Size = New Size(66, 15)
        LabelNumero.TabIndex = 153
        LabelNumero.Text = "Labelnome"
        ' 
        ' LabelComplemento
        ' 
        LabelComplemento.AutoSize = True
        LabelComplemento.Location = New Point(181, 278)
        LabelComplemento.Name = "LabelComplemento"
        LabelComplemento.Size = New Size(66, 15)
        LabelComplemento.TabIndex = 152
        LabelComplemento.Text = "Labelnome"
        ' 
        ' LabelLocalidade
        ' 
        LabelLocalidade.AutoSize = True
        LabelLocalidade.Location = New Point(109, 238)
        LabelLocalidade.Name = "LabelLocalidade"
        LabelLocalidade.Size = New Size(66, 15)
        LabelLocalidade.TabIndex = 151
        LabelLocalidade.Text = "Labelnome"
        ' 
        ' LabelContribuinte
        ' 
        LabelContribuinte.AutoSize = True
        LabelContribuinte.Location = New Point(181, 307)
        LabelContribuinte.Name = "LabelContribuinte"
        LabelContribuinte.Size = New Size(66, 15)
        LabelContribuinte.TabIndex = 150
        LabelContribuinte.Text = "Labelnome"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.Location = New Point(109, 307)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(66, 15)
        LabelEmail.TabIndex = 149
        LabelEmail.Text = "Labelnome"
        ' 
        ' LabelNome
        ' 
        LabelNome.AllowDrop = True
        LabelNome.AutoEllipsis = True
        LabelNome.AutoSize = True
        LabelNome.Location = New Point(146, 217)
        LabelNome.Name = "LabelNome"
        LabelNome.Size = New Size(65, 21)
        LabelNome.TabIndex = 148
        LabelNome.Text = "Labelnome"
        LabelNome.UseCompatibleTextRendering = True
        ' 
        ' Form12
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(731, 470)
        Controls.Add(Label_HorarioEscolhido)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(LabelTelefone)
        Controls.Add(LabelRua)
        Controls.Add(LabelNumero)
        Controls.Add(LabelComplemento)
        Controls.Add(LabelLocalidade)
        Controls.Add(LabelContribuinte)
        Controls.Add(LabelEmail)
        Controls.Add(LabelNome)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form12"
        Text = "Form12"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label_HorarioEscolhido As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelTelefone As Label
    Friend WithEvents LabelRua As Label
    Friend WithEvents LabelNumero As Label
    Friend WithEvents LabelComplemento As Label
    Friend WithEvents LabelLocalidade As Label
    Friend WithEvents LabelContribuinte As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelNome As Label
End Class
