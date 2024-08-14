Public Class FormCalculo

    Private Sub FormCalculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura el formulario para que se muestre en el centro de la pantalla
        Me.StartPosition = FormStartPosition.CenterScreen
        ' Configura el texto inicial del Label2
        Label2.Text = ""
    End Sub

    Private Sub ingresar_Click(sender As Object, e As EventArgs) Handles ingresar.Click
        Dim numero1 As Double
        Dim numero2 As Double
        Dim resultado As Double
        Dim operacion As String = comboBoxOperaciones.SelectedItem?.ToString()

        ' Intentar convertir el texto de los TextBox a números
        If Double.TryParse(TextBox1.Text, numero1) AndAlso Double.TryParse(TextBox2.Text, numero2) Then
            ' Realizar la operación seleccionada
            Select Case operacion
                Case "+"
                    resultado = numero1 + numero2
                Case "-"
                    resultado = numero1 - numero2
                Case "*"
                    resultado = numero1 * numero2
                Case "/"
                    If numero2 <> 0 Then
                        resultado = numero1 / numero2
                    Else
                        labelResultado.Text = "No se puede dividir por cero."
                        Exit Sub
                    End If
                Case Else
                    labelResultado.Text = "Operación no válida."
                    Exit Sub
            End Select

            ' Mostrar el resultado en LabelResultado
            labelResultado.Text = "Resultado: " & resultado.ToString()
        Else
            ' Mostrar un mensaje de error si la conversión falla
            labelResultado.Text = "Por favor, ingrese números válidos."
        End If
    End Sub

    Private Sub comboBoxOperaciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxOperaciones.SelectedIndexChanged
        ' Obtener la operación seleccionada y mostrarla en Label2
        Label2.Text = comboBoxOperaciones.SelectedItem?.ToString()
    End Sub

End Class
