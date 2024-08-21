Public Class Calculadora

    Private primerNumero As Double
    Private digitoOperador As String
    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Añadir numero al TextBox1 Si el boton se presiona se agrega al TextBox1 un dato string(texto) con &=
    Private Sub ButtonCero_Click(sender As Object, e As EventArgs) Handles ButtonCero.Click
        TextBox1.Text &= "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text &= "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text &= "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text &= "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text &= "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text &= "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text &= "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text &= "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text &= "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text &= "9"
    End Sub

    ' Botones de operaciones
    ' Guarda el primer número y la operación de suma, luego limpia el TextBox
    Private Sub ButtonMas_Click(sender As Object, e As EventArgs) Handles ButtonMas.Click
        primerNumero = Convert.ToDouble(TextBox1.Text)
        digitoOperador = "+"
        TextBox1.Clear()
    End Sub

    Private Sub ButtonRestar_Click(sender As Object, e As EventArgs) Handles ButtonRestar.Click
        primerNumero = Convert.ToDouble(TextBox1.Text)
        digitoOperador = "-"

    End Sub

    Private Sub ButtonMultiplicar_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicar.Click
        primerNumero = Convert.ToDouble(TextBox1.Text)
        digitoOperador = "*"
        TextBox1.Clear()
    End Sub

    Private Sub ButtonDividir_Click(sender As Object, e As EventArgs) Handles ButtonDividir.Click
        primerNumero = Convert.ToDouble(TextBox1.Text)
        digitoOperador = "/"
        TextBox1.Clear()
    End Sub

    'Boton Resultado de la operacion
    Private Sub ButtonResultado_Click(sender As Object, e As EventArgs) Handles ButtonResultado.Click
        Dim segundoNumero As Double = Convert.ToDouble(TextBox1.Text)
        Dim resultado As Double

        Select Case digitoOperador
            Case "+"
                resultado = primerNumero + segundoNumero
            Case "-"
                resultado = primerNumero - segundoNumero
            Case "*"
                resultado = primerNumero * segundoNumero
            Case "/"
                resultado = primerNumero / segundoNumero
        End Select

        TextBox1.Text = resultado.ToString()
    End Sub

    Private Sub ButtonPunt_Click(sender As Object, e As EventArgs) Handles ButtonPunt.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBox1.Clear()
        primerNumero = 0
        digitoOperador = ""
    End Sub
End Class