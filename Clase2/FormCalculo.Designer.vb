<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculo
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        labelResultado = New Label()
        ingresar = New Button()
        comboBoxOperaciones = New ComboBox()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(60, 72)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(66, 23)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(218, 72)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(72, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(163, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(15, 15)
        Label2.TabIndex = 3
        Label2.Text = "+"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(62, 15)
        Label3.TabIndex = 4
        Label3.Text = "Resultado:"
        ' 
        ' labelResultado
        ' 
        labelResultado.AutoSize = True
        labelResultado.Location = New Point(99, 174)
        labelResultado.Name = "labelResultado"
        labelResultado.Size = New Size(160, 15)
        labelResultado.TabIndex = 5
        labelResultado.Text = "Aqui se mostrara el resultado"
        ' 
        ' ingresar
        ' 
        ingresar.Location = New Point(129, 122)
        ingresar.Name = "ingresar"
        ingresar.Size = New Size(75, 23)
        ingresar.TabIndex = 6
        ingresar.Text = "Button1"
        ingresar.UseVisualStyleBackColor = True
        ' 
        ' comboBoxOperaciones
        ' 
        comboBoxOperaciones.FormattingEnabled = True
        comboBoxOperaciones.Items.AddRange(New Object() {"+", "-", "/", "*"})
        comboBoxOperaciones.Location = New Point(112, 21)
        comboBoxOperaciones.Name = "comboBoxOperaciones"
        comboBoxOperaciones.Size = New Size(121, 23)
        comboBoxOperaciones.TabIndex = 7
        ' 
        ' FormCalculo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(348, 263)
        Controls.Add(comboBoxOperaciones)
        Controls.Add(ingresar)
        Controls.Add(labelResultado)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "FormCalculo"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormCalculo"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents labelResultado As Label
    Friend WithEvents ingresar As Button
    Friend WithEvents comboBoxOperaciones As ComboBox
End Class
