<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form4))
        RichTextBox1 = New RichTextBox()
        tela_inicial = New Button()
        Apresentacao = New Button()
        Cadrastro = New Button()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        RichTextBox1.BackColor = SystemColors.ButtonHighlight
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Leelawadee", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(12, 12)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(698, 325)
        RichTextBox1.TabIndex = 1
        RichTextBox1.TabStop = False
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' tela_inicial
        ' 
        tela_inicial.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        tela_inicial.Location = New Point(44, 318)
        tela_inicial.Name = "tela_inicial"
        tela_inicial.Size = New Size(184, 32)
        tela_inicial.TabIndex = 5
        tela_inicial.Text = "TELA INICIAL"
        tela_inicial.UseVisualStyleBackColor = True
        ' 
        ' Apresentacao
        ' 
        Apresentacao.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Apresentacao.Location = New Point(266, 318)
        Apresentacao.Name = "Apresentacao"
        Apresentacao.Size = New Size(161, 32)
        Apresentacao.TabIndex = 6
        Apresentacao.Text = "APRESENTAÇÃO"
        Apresentacao.UseVisualStyleBackColor = True
        ' 
        ' Cadrastro
        ' 
        Cadrastro.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Cadrastro.Location = New Point(496, 318)
        Cadrastro.Name = "Cadrastro"
        Cadrastro.Size = New Size(161, 32)
        Cadrastro.TabIndex = 7
        Cadrastro.Text = "CADASTRO"
        Cadrastro.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(722, 500)
        Controls.Add(Cadrastro)
        Controls.Add(Apresentacao)
        Controls.Add(tela_inicial)
        Controls.Add(RichTextBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        ImeMode = ImeMode.HangulFull
        Name = "Form4"
        Text = "Restaurante ""Gustavo Savory"""
        ResumeLayout(False)
    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents tela_inicial As Button
    Friend WithEvents Apresentacao As Button
    Friend WithEvents Cadrastro As Button
End Class
