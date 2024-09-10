Imports MySql.Data.MySqlClient

Public Class InsertBD
    ' Configura tu cadena de conexión
    Private Const connectionString As String = "Server=localhost;Database=personas_bd;Uid=root;Pwd=;"

    Private Sub InsertBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Lista de comunas de Santiago
        Dim comunas As New List(Of String) From {
            "Santiago", "Providencia", "Las Condes", "Ñuñoa", "Macul", "La Reina", "Peñalolén",
            "San Miguel", "San Joaquín", "Cerro Navia"
        }

        ' Agregar las comunas al ComboBox1
        ComboBox1.DataSource = comunas
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Recolectar datos del formulario
        Dim rut As String = TextBox1.Text
        Dim nombre As String = TextBox2.Text
        Dim apellido As String = TextBox3.Text
        Dim sexo As String = ""
        If CheckBox1.Checked Then
            sexo = "Masculino"
        ElseIf CheckBox2.Checked Then
            sexo = "Femenino"
        ElseIf CheckBox3.Checked Then
            sexo = "No Identifica"
        End If
        Dim comuna As String = If(ComboBox1.SelectedItem Is Nothing, "", ComboBox1.SelectedItem.ToString())
        Dim ciudad As String = TextBox5.Text
        Dim observacion As String = TextBox4.Text

        ' Crear la consulta SQL
        Dim query As String = "INSERT INTO personas (rut, nombre, apellido, sexo, comuna, ciudad, observacion) VALUES (@rut, @nombre, @apellido, @sexo, @comuna, @ciudad, @observacion)"

        ' Ejecutar la consulta
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Agregar parámetros
                command.Parameters.AddWithValue("@rut", rut)
                command.Parameters.AddWithValue("@nombre", nombre)
                command.Parameters.AddWithValue("@apellido", apellido)
                command.Parameters.AddWithValue("@sexo", sexo)
                command.Parameters.AddWithValue("@comuna", comuna)
                command.Parameters.AddWithValue("@ciudad", ciudad)
                command.Parameters.AddWithValue("@observacion", observacion)

                ' Abrir la conexión, ejecutar el comando y cerrar la conexión
                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Datos insertados correctamente")
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox2.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox1.Checked = False
            CheckBox3.Checked = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            CheckBox1.Checked = False
            CheckBox2.Checked = False
        End If
    End Sub
End Class
