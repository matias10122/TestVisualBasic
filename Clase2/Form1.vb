Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = TextBox1.Text

    End Sub

    Private Sub calculo_Click(sender As Object, e As EventArgs) Handles calculo.Click
        Dim calculoForm As New FormCalculo()
        calculoForm.Show()
    End Sub
End Class