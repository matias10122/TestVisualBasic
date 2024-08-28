Imports Microsoft.Office.Interop

Public Class ConsultarExel

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim searchText As String = TextBox1.Text.Trim().ToLower()
        Dim filePath As String = "C:\Users\alumnos.republica\Desktop\Maestra.xlsx"

        If String.IsNullOrEmpty(searchText) Then
            MessageBox.Show("Por favor ingrese un RUT o nombre para consultar.")
            Return
        End If

        Dim excelApp As New Excel.Application()
        Dim workbook As Excel.Workbook = Nothing
        Dim worksheet As Excel.Worksheet = Nothing

        Try
            workbook = excelApp.Workbooks.Open(filePath)
            worksheet = workbook.Sheets(1) ' Selecciona la primera hoja

            Dim found As Boolean = False
            Dim lastRow As Integer = worksheet.Cells(worksheet.Rows.Count, 1).End(Excel.XlDirection.xlUp).Row

            For i As Integer = 1 To lastRow
                Dim rutValue As String = worksheet.Cells(i, 1).Value ' Supone que el RUT está en la primera columna
                Dim nameValue As String = worksheet.Cells(i, 2).Value ' Supone que el nombre está en la segunda columna

                ' Compara con el RUT
                If rutValue IsNot Nothing AndAlso rutValue.Trim().ToLower() = searchText Then
                    Label3.Text = rutValue
                    Label5.Text = nameValue
                    found = True
                    Exit For
                End If

                ' Compara con el nombre
                If nameValue IsNot Nothing AndAlso nameValue.Trim().ToLower() = searchText Then
                    Label3.Text = rutValue
                    Label5.Text = nameValue
                    found = True
                    Exit For
                End If
            Next

            If Not found Then
                Label3.Text = "RUT no encontrado."
                Label5.Text = "Nombre no encontrado."
            End If

        Catch ex As Exception
            MessageBox.Show("Ocurrió un error: " & ex.Message)
        Finally
            CloseExcelWorkbook(workbook)
            QuitExcelApp(excelApp)
        End Try
    End Sub

    Private Sub CloseExcelWorkbook(ByRef workbook As Excel.Workbook)
        If workbook IsNot Nothing Then
            workbook.Close(False)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            workbook = Nothing
        End If
    End Sub

    Private Sub QuitExcelApp(ByRef excelApp As Excel.Application)
        If excelApp IsNot Nothing Then
            excelApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
            excelApp = Nothing
        End If
    End Sub

End Class
