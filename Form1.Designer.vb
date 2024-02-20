<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Menu = New Button()
        ReservaPedido = New Button()
        Button_Delivery = New Button()
        Button_TakeAway = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(-8, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(636, 449)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' Menu
        ' 
        Menu.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Menu.Location = New Point(51, 301)
        Menu.Name = "Menu"
        Menu.Size = New Size(238, 40)
        Menu.TabIndex = 1
        Menu.Text = "MENU"
        Menu.UseVisualStyleBackColor = True
        ' 
        ' ReservaPedido
        ' 
        ReservaPedido.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        ReservaPedido.Location = New Point(51, 371)
        ReservaPedido.Name = "ReservaPedido"
        ReservaPedido.Size = New Size(238, 40)
        ReservaPedido.TabIndex = 2
        ReservaPedido.Text = "RESERVA"
        ReservaPedido.UseVisualStyleBackColor = True
        ' 
        ' Button_Delivery
        ' 
        Button_Delivery.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button_Delivery.Location = New Point(331, 301)
        Button_Delivery.Name = "Button_Delivery"
        Button_Delivery.Size = New Size(238, 40)
        Button_Delivery.TabIndex = 3
        Button_Delivery.Text = "DELIVERY"
        Button_Delivery.UseVisualStyleBackColor = True
        ' 
        ' Button_TakeAway
        ' 
        Button_TakeAway.Font = New Font("Leelawadee", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button_TakeAway.Location = New Point(331, 371)
        Button_TakeAway.Name = "Button_TakeAway"
        Button_TakeAway.Size = New Size(238, 40)
        Button_TakeAway.TabIndex = 4
        Button_TakeAway.Text = "TAKEAWAY"
        Button_TakeAway.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(624, 450)
        Controls.Add(Button_TakeAway)
        Controls.Add(Button_Delivery)
        Controls.Add(ReservaPedido)
        Controls.Add(Menu)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Menu As Button
    Friend WithEvents ReservaPedido As Button
    Friend WithEvents Button_Delivery As Button
    Friend WithEvents Button_TakeAway As Button
End Class
