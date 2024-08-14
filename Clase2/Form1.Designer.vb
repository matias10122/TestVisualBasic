<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox1 = New TextBox()
        titulo = New Label()
        Button1 = New Button()
        Label3 = New Label()
        calculo = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre Completo:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(47, 90)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 1
        ' 
        ' titulo
        ' 
        titulo.AutoSize = True
        titulo.Location = New Point(47, 40)
        titulo.Name = "titulo"
        titulo.Size = New Size(157, 15)
        titulo.TabIndex = 2
        titulo.Text = "Escribe tu nombre completo"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(220, 91)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 3
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(163, 196)
        Label3.Name = "Label3"
        Label3.Size = New Size(202, 15)
        Label3.TabIndex = 4
        Label3.Text = "Tu nombre completo aparecera aqui!"
        ' 
        ' calculo
        ' 
        calculo.Location = New Point(410, 257)
        calculo.Name = "calculo"
        calculo.Size = New Size(75, 23)
        calculo.TabIndex = 5
        calculo.Text = "     Calculadora"
        calculo.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(928, 561)
        Controls.Add(calculo)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(titulo)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents titulo As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents calculo As Button

End Class
