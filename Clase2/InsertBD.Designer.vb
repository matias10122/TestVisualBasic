<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsertBD
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Panel1 = New Panel()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Label7 = New Label()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 0
        Label1.Text = "Rut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(245, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 15)
        Label2.TabIndex = 2
        Label2.Text = "rut(ejemplo): 12345678-9"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 3
        Label3.Text = "Nombre"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(89, 109)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(213, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(89, 44)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(138, 23)
        TextBox1.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 6
        Label4.Text = "Apellido"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(89, 182)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(213, 23)
        TextBox3.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(CheckBox3)
        Panel1.Controls.Add(CheckBox2)
        Panel1.Controls.Add(CheckBox1)
        Panel1.Location = New Point(12, 253)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(371, 58)
        Panel1.TabIndex = 8
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(263, 19)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(89, 19)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "No definido"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(130, 19)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(79, 19)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Femenino"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(15, 19)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(81, 19)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Masculino"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 235)
        Label5.Name = "Label5"
        Label5.Size = New Size(32, 15)
        Label5.TabIndex = 9
        Label5.Text = "Sexo"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 374)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 15)
        Label6.TabIndex = 10
        Label6.Text = "Comuna"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(89, 374)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(213, 23)
        ComboBox1.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(10, 428)
        Label7.Name = "Label7"
        Label7.Size = New Size(73, 15)
        Label7.TabIndex = 12
        Label7.Text = "Observacion"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(89, 425)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(213, 23)
        TextBox4.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Location = New Point(142, 463)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 14
        Button1.Text = "Guardar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(27, 326)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 15)
        Label8.TabIndex = 15
        Label8.Text = "Ciudad"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(89, 326)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(213, 23)
        TextBox5.TabIndex = 16
        ' 
        ' InsertBD
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.white
        ClientSize = New Size(395, 527)
        Controls.Add(TextBox5)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(TextBox4)
        Controls.Add(Label7)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "InsertBD"
        Text = "InsertBD"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
End Class
