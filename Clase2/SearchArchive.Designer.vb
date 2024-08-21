<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchArchive
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
        Panel1 = New Panel()
        Label2 = New Label()
        LabelContenido = New Label()
        LabelStatus = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.GradientActiveCaption
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LabelContenido)
        Panel1.Controls.Add(LabelStatus)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(742, 426)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 224)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 15)
        Label2.TabIndex = 4
        Label2.Text = "Contenido del archivo:"
        ' 
        ' LabelContenido
        ' 
        LabelContenido.AutoSize = True
        LabelContenido.Location = New Point(154, 224)
        LabelContenido.Name = "LabelContenido"
        LabelContenido.Size = New Size(61, 15)
        LabelContenido.TabIndex = 3
        LabelContenido.Text = "contenido"
        ' 
        ' LabelStatus
        ' 
        LabelStatus.AutoSize = True
        LabelStatus.Location = New Point(299, 144)
        LabelStatus.Name = "LabelStatus"
        LabelStatus.Size = New Size(106, 15)
        LabelStatus.TabIndex = 2
        LabelStatus.Text = "Estado del archivo:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(206, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 32)
        Label1.TabIndex = 1
        Label1.Text = "Busca tu archivo de texto"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(315, 101)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' SearchArchive
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(766, 450)
        Controls.Add(Panel1)
        Name = "SearchArchive"
        Text = "SearchArchive"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelStatus As Label
    Friend WithEvents LabelContenido As Label
    Friend WithEvents Label2 As Label
End Class
