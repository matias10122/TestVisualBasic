Public Class ConsultaProducto

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Cambiar el color del botón a verde y deshabilitarlo
        Button1.BackColor = Color.Green
        Button1.Enabled = False

        ' Crear una nueva instancia de la aplicación Excel
        Dim excelApp As New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing

        Try
            workbook = excelApp.Workbooks.Open("C:\Users\alumnos.republica\Desktop\Lista.xls")
            worksheet = CType(workbook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

            ' Limpiar el ComboBox antes de agregar nuevos ítems
            ComboBox1.Items.Clear()

            ' Obtener la última fila con datos en la columna A (IdProducto)
            Dim lastRow As Integer = worksheet.Cells(worksheet.Rows.Count, 1).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Row

            ' Agregar cada IdProducto al ComboBox
            For i As Integer = 2 To lastRow ' Asumiendo que la primera fila contiene encabezados
                Dim idProducto As String = worksheet.Cells(i, 1).Value.ToString()
                ComboBox1.Items.Add(idProducto)
            Next

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            ' Cerrar el libro y la aplicación Excel
            If workbook IsNot Nothing Then workbook.Close(False)
            excelApp.Quit()

            ' Liberar recursos
            ReleaseObject(worksheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Crear una nueva instancia de la aplicación Excel
        Dim excelApp As New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = Nothing
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = Nothing

        Try
            workbook = excelApp.Workbooks.Open("C:\Users\alumnos.republica\Desktop\Lista.xls")
            worksheet = CType(workbook.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet)

            ' Obtener la IdProducto seleccionada en el ComboBox
            Dim selectedIdProducto As String = ComboBox1.SelectedItem.ToString()

            ' Obtener la última fila con datos en la columna A (IdProducto)
            Dim lastRow As Integer = worksheet.Cells(worksheet.Rows.Count, 1).End(Microsoft.Office.Interop.Excel.XlDirection.xlUp).Row

            ' Buscar la fila donde se encuentra el IdProducto seleccionado
            For i As Integer = 2 To lastRow ' Asumiendo que la primera fila contiene encabezados
                If worksheet.Cells(i, 1).Value.ToString() = selectedIdProducto Then
                    ' Mostrar los valores asociados en los labels
                    Label7.Text = worksheet.Cells(i, 2).Value.ToString() ' NombreProducto
                    Label8.Text = worksheet.Cells(i, 6).Value.ToString() ' PrecioUnidad
                    Label9.Text = worksheet.Cells(i, 7).Value.ToString() ' UnidadesEnExistencia
                    Exit For
                End If
            Next

        Catch ex As Exception
            MessageBox.Show("Error al cargar los datos: " & ex.Message)
        Finally
            ' Cerrar el libro y la aplicación Excel
            If workbook IsNot Nothing Then workbook.Close(False)
            excelApp.Quit()

            ' Liberar recursos
            ReleaseObject(worksheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)
        End Try
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            If obj IsNot Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
                obj = Nothing
            End If
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ConsultaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
