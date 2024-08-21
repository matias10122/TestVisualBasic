Imports System.Linq.Expressions

Public Class SearchArchive
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rutaArchivo As String = "C:\Users\alumnos.republica\Desktop\encuentrame.txt"

        Try
            ' Verificar si el archivo existe
            If My.Computer.FileSystem.FileExists(rutaArchivo) Then
                ' Leer todo el contenido del archivo
                Dim contenido As String = My.Computer.FileSystem.ReadAllText(rutaArchivo)
                ' Muestra el estado y el contenido
                LabelStatus.Text = "Archivo encontrado."
                LabelContenido.Text = contenido
            Else
                LabelStatus.Text = "Archivo no encontrado."
                LabelContenido.Text = String.Empty
            End If

        Catch ex As Exception
            LabelStatus.Text = "Error al cargar el archivo: " & ex.Message
            LabelContenido.Text = String.Empty
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub LabelContenido_Click(sender As Object, e As EventArgs) Handles LabelContenido.Click

    End Sub
End Class
