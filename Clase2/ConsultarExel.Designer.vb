<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarExel
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
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(343, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 15)
        Label1.TabIndex = 0
        Label1.Text = "Consultar Rut"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(279, 117)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(198, 23)
        TextBox1.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(343, 165)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 2
        Button1.Text = "Consultar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(127, 241)
        Label2.Name = "Label2"
        Label2.Size = New Size(28, 15)
        Label2.TabIndex = 3
        Label2.Text = "Rut:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(196, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 15)
        Label3.TabIndex = 4
        Label3.Text = "ej: 12312312-1"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(127, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 15)
        Label4.TabIndex = 5
        Label4.Text = "Nombre:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(196, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 15)
        Label5.TabIndex = 6
        Label5.Text = "ej: Juan Perez"
        ' 
        ' ConsultarExel
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "ConsultarExel"
        Text = "ConsultarExel"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
