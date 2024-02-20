<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        RichTextBox1 = New RichTextBox()
        tela_inicial = New Button()
        sobre_o_mestre = New Button()
        Cadastro = New Button()
        SuspendLayout()
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = SystemColors.ButtonHighlight
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.CausesValidation = False
        RichTextBox1.Font = New Font("Leelawadee", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        RichTextBox1.Location = New Point(12, -4)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ScrollBars = RichTextBoxScrollBars.ForcedHorizontal
        RichTextBox1.Size = New Size(539, 325)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        RichTextBox1.UseWaitCursor = True
        ' 
        ' tela_inicial
        ' 
        tela_inicial.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        tela_inicial.Location = New Point(12, 415)
        tela_inicial.Name = "tela_inicial"
        tela_inicial.Size = New Size(159, 32)
        tela_inicial.TabIndex = 2
        tela_inicial.Text = "TELA INICIAL"
        tela_inicial.UseVisualStyleBackColor = True
        ' 
        ' sobre_o_mestre
        ' 
        sobre_o_mestre.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        sobre_o_mestre.Location = New Point(194, 415)
        sobre_o_mestre.Name = "sobre_o_mestre"
        sobre_o_mestre.Size = New Size(163, 32)
        sobre_o_mestre.TabIndex = 3
        sobre_o_mestre.Text = "SOBRE O MESTRE"
        sobre_o_mestre.UseVisualStyleBackColor = True
        ' 
        ' Cadastro
        ' 
        Cadastro.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Cadastro.Location = New Point(388, 415)
        Cadastro.Name = "Cadastro"
        Cadastro.Size = New Size(163, 32)
        Cadastro.TabIndex = 4
        Cadastro.Text = "CADASTRO"
        Cadastro.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonShadow
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(563, 450)
        Controls.Add(Cadastro)
        Controls.Add(sobre_o_mestre)
        Controls.Add(tela_inicial)
        Controls.Add(RichTextBox1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sobre_o_mestre"
        ResumeLayout(False)
    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents tela_inicial As Button
    Friend WithEvents sobre_o_mestre As Button
    Friend WithEvents Cadastro As Button
End Class
