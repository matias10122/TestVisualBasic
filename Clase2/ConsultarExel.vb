Imports Microsoft.Office.Interop

Public Class ConsultarExel

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rut As String = TextBox1.Text.Trim().ToLower()
        Dim filePath As String = "C:\Users\alumnos.republica\Desktop\Maestra.xlsx"

        If String.IsNullOrEmpty(rut) Then
            MessageBox.Show("Por favor ingrese un RUT para consultar.")
            Return
        End If

        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            workbook = excelApp.Workbooks.Open(filePath)
            worksheet = workbook.Sheets(1) ' Selecciona la primera hoja '

            Dim found As Boolean = False
            Dim lastRow As Integer = worksheet.Cells(worksheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row

            For i As Integer = 1 To lastRow
                Dim cellValue As String = worksheet.Cells(i, 1).Value ' Supone que el RUT está en la primera columna

                If cellValue IsNot Nothing AndAlso cellValue.Trim().ToLower() = rut Then
                    Dim name As String = worksheet.Cells(i, 2).Value ' Supone que el nombre está en la segunda columna
                    Label3.Text = name
                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                Label3.Text = "RUT no encontrado."
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        Finally
            If workbook IsNot Nothing Then
                workbook.Close(False)
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            End If

            excelApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        End Try
    End Sub

End Class
