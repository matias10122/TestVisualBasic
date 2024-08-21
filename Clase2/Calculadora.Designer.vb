<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        ButtonCero = New Button()
        ButtonPunt = New Button()
        ButtonResultado = New Button()
        ButtonMas = New Button()
        ButtonDividir = New Button()
        ButtonMultiplicar = New Button()
        ButtonRestar = New Button()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        ButtonClear = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(24, 122)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(105, 122)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 2
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(186, 122)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 3
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(24, 93)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 4
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(105, 93)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 5
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(186, 93)
        Button6.Name = "Button6"
        Button6.Size = New Size(75, 23)
        Button6.TabIndex = 6
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(24, 64)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 23)
        Button7.TabIndex = 7
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(105, 64)
        Button8.Name = "Button8"
        Button8.Size = New Size(75, 23)
        Button8.TabIndex = 8
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(186, 64)
        Button9.Name = "Button9"
        Button9.Size = New Size(75, 23)
        Button9.TabIndex = 9
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' ButtonCero
        ' 
        ButtonCero.Location = New Point(24, 151)
        ButtonCero.Name = "ButtonCero"
        ButtonCero.Size = New Size(75, 23)
        ButtonCero.TabIndex = 10
        ButtonCero.Text = "0"
        ButtonCero.UseVisualStyleBackColor = True
        ' 
        ' ButtonPunt
        ' 
        ButtonPunt.Location = New Point(105, 151)
        ButtonPunt.Name = "ButtonPunt"
        ButtonPunt.Size = New Size(75, 23)
        ButtonPunt.TabIndex = 11
        ButtonPunt.Text = "."
        ButtonPunt.UseVisualStyleBackColor = True
        ' 
        ' ButtonResultado
        ' 
        ButtonResultado.Location = New Point(186, 151)
        ButtonResultado.Name = "ButtonResultado"
        ButtonResultado.Size = New Size(75, 23)
        ButtonResultado.TabIndex = 12
        ButtonResultado.Text = "="
        ButtonResultado.UseVisualStyleBackColor = True
        ' 
        ' ButtonMas
        ' 
        ButtonMas.Location = New Point(267, 151)
        ButtonMas.Name = "ButtonMas"
        ButtonMas.Size = New Size(75, 23)
        ButtonMas.TabIndex = 13
        ButtonMas.Text = "+"
        ButtonMas.UseVisualStyleBackColor = True
        ' 
        ' ButtonDividir
        ' 
        ButtonDividir.Location = New Point(267, 64)
        ButtonDividir.Name = "ButtonDividir"
        ButtonDividir.Size = New Size(75, 23)
        ButtonDividir.TabIndex = 14
        ButtonDividir.Text = "/"
        ButtonDividir.UseVisualStyleBackColor = True
        ' 
        ' ButtonMultiplicar
        ' 
        ButtonMultiplicar.Location = New Point(267, 93)
        ButtonMultiplicar.Name = "ButtonMultiplicar"
        ButtonMultiplicar.Size = New Size(75, 23)
        ButtonMultiplicar.TabIndex = 15
        ButtonMultiplicar.Text = "*"
        ButtonMultiplicar.UseVisualStyleBackColor = True
        ' 
        ' ButtonRestar
        ' 
        ButtonRestar.Location = New Point(267, 122)
        ButtonRestar.Name = "ButtonRestar"
        ButtonRestar.Size = New Size(75, 23)
        ButtonRestar.TabIndex = 16
        ButtonRestar.Text = "-"
        ButtonRestar.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(24, 35)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(318, 23)
        TextBox1.TabIndex = 17
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.AppWorkspace
        Panel1.Controls.Add(ButtonClear)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ButtonRestar)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(ButtonMultiplicar)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(ButtonDividir)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(ButtonMas)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(ButtonResultado)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(ButtonPunt)
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(ButtonCero)
        Panel1.Controls.Add(Button9)
        Panel1.Location = New Point(117, 110)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(366, 233)
        Panel1.TabIndex = 18
        ' 
        ' ButtonClear
        ' 
        ButtonClear.Location = New Point(24, 180)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(75, 23)
        ButtonClear.TabIndex = 18
        ButtonClear.Text = "C"
        ButtonClear.UseVisualStyleBackColor = True
        ' 
        ' Calculadora
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(594, 450)
        Controls.Add(Panel1)
        Name = "Calculadora"
        Text = "Calculadora"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ButtonCero As Button
    Friend WithEvents ButtonPunt As Button
    Friend WithEvents ButtonResultado As Button
    Friend WithEvents ButtonMas As Button
    Friend WithEvents ButtonDividir As Button
    Friend WithEvents ButtonMultiplicar As Button
    Friend WithEvents ButtonRestar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonClear As Button
End Class
