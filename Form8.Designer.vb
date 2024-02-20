<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form8))
        PictureBox1 = New PictureBox()
        Apresentacao = New Button()
        Sobre_o_mestre = New Button()
        Cadastro = New Button()
        carta = New Button()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-6, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(682, 403)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' Apresentacao
        ' 
        Apresentacao.Font = New Font("Leelawadee", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Apresentacao.Location = New Point(3, 409)
        Apresentacao.Name = "Apresentacao"
        Apresentacao.Size = New Size(131, 37)
        Apresentacao.TabIndex = 1
        Apresentacao.Text = "APRESENTAÇÃO"
        Apresentacao.UseVisualStyleBackColor = True
        ' 
        ' Sobre_o_mestre
        ' 
        Sobre_o_mestre.Font = New Font("Leelawadee", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Sobre_o_mestre.Location = New Point(140, 409)
        Sobre_o_mestre.Name = "Sobre_o_mestre"
        Sobre_o_mestre.Size = New Size(161, 37)
        Sobre_o_mestre.TabIndex = 2
        Sobre_o_mestre.Text = "SOBRE O MESTRE"
        Sobre_o_mestre.UseVisualStyleBackColor = True
        ' 
        ' Cadastro
        ' 
        Cadastro.Font = New Font("Leelawadee", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Cadastro.Location = New Point(544, 409)
        Cadastro.Name = "Cadastro"
        Cadastro.Size = New Size(132, 37)
        Cadastro.TabIndex = 3
        Cadastro.Text = "CADRASTRO"
        Cadastro.UseVisualStyleBackColor = True
        ' 
        ' carta
        ' 
        carta.Font = New Font("Leelawadee", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        carta.Location = New Point(307, 409)
        carta.Name = "carta"
        carta.Size = New Size(113, 37)
        carta.TabIndex = 4
        carta.Text = "MENU"
        carta.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Leelawadee", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(426, 409)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 37)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(677, 450)
        Controls.Add(Button1)
        Controls.Add(carta)
        Controls.Add(Cadastro)
        Controls.Add(Sobre_o_mestre)
        Controls.Add(Apresentacao)
        Controls.Add(PictureBox1)
        Name = "Form8"
        Text = "Form8"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Apresentacao As Button
    Friend WithEvents Sobre_o_mestre As Button
    Friend WithEvents Cadastro As Button
    Friend WithEvents carta As Button
    Friend WithEvents Button1 As Button
End Class
