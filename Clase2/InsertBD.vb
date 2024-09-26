Imports MySql.Data.MySqlClient

Public Class InsertBD
    ' Configura tu cadena de conexión
    Private Const connectionString As String = "Server=localhost;Database=registropersonas;Uid=root;Pwd=;"

    ' Variable para rastrear el estado de los campos (bloqueados/desbloqueados)
    Private camposDesbloqueados As Boolean = False

    Private Sub InsertBD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Bloquear los controles inicialmente
        BloquearCampos()

        ' Ocultar los botones de editar y eliminar al inicio
        Button3.Visible = False
        Button4.Visible = False

        ' Establecer el texto inicial del botón de edición
        Button3.Text = "Editar"

        Button4.Text = "Eliminar"

        ' Configurar la conexión a la base de datos
        Using connection As New MySqlConnection(connectionString)
            Try
                ' Abrir la conexión
                connection.Open()

                ' Crear la consulta para obtener los nombres de las comunas
                Dim query As String = "SELECT NombreComuna FROM comuna"
                Using command As New MySqlCommand(query, connection)
                    ' Ejecutar la consulta y llenar el ComboBox con los resultados
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim comunas As New List(Of String)
                        comunas.Add("(Seleccione una comuna)") ' Mensaje inicial
                        While reader.Read()
                            comunas.Add(reader("NombreComuna").ToString())
                        End While
                        ComboBox1.DataSource = comunas
                    End Using
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Error al cargar las comunas: " & ex.Message)
            Finally
                ' Cerrar la conexión
                connection.Close()
            End Try
        End Using

        ' Seleccionar por defecto el mensaje inicial
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub BloquearCampos()
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        CheckBox3.Enabled = False
        TextBox5.Enabled = False
        ComboBox1.Enabled = False
        TextBox4.Enabled = False
        camposDesbloqueados = False ' Indicar que los campos están bloqueados
    End Sub

    Private Sub DesbloquearCampos()
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        TextBox5.Enabled = True
        ComboBox1.Enabled = True
        TextBox4.Enabled = True
        camposDesbloqueados = True ' Indicar que los campos están desbloqueados
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Obtener el RUT a buscar
        Dim rut As String = TextBox1.Text

        ' Verificar que el RUT no esté vacío
        If String.IsNullOrEmpty(rut) Then
            MessageBox.Show("Por favor ingrese un RUT.")
            Exit Sub
        End If

        ' Crear la consulta SQL para buscar el registro
        Dim query As String = "SELECT Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion FROM personas WHERE RUT = @rut"

        ' Ejecutar la consulta
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@rut", rut)

                Try
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Si se encuentra el registro, llenar los campos con los datos
                            TextBox2.Text = reader("Nombre").ToString()
                            TextBox3.Text = reader("Apellido").ToString()

                            Dim sexo As String = reader("Sexo").ToString()
                            CheckBox1.Checked = (sexo = "Masculino")
                            CheckBox2.Checked = (sexo = "Femenino")
                            CheckBox3.Checked = (sexo = "No Identifica")

                            ComboBox1.SelectedItem = reader("Comuna").ToString()
                            TextBox5.Text = reader("Ciudad").ToString()
                            TextBox4.Text = reader("Observacion").ToString()

                            ' Hacer visibles los botones de edición y eliminación
                            Button3.Visible = True
                            Button4.Visible = True

                            ' Asegurar que Button3 diga "Editar"
                            Button3.Text = "Editar"

                        Else
                            ' Si no se encuentra el registro, mostrar un mensaje de confirmación
                            Dim result As DialogResult = MessageBox.Show("El RUT no se encuentra, ¿desea crear un nuevo usuario?", "Crear Nuevo Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If result = DialogResult.Yes Then
                                ' Limpiar los campos y desbloquear para un nuevo ingreso
                                LimpiarCampos()
                                DesbloquearCampos()

                                ' Ocultar el Button4 ya que no se necesita para la creación
                                Button4.Visible = False
                                ' Mostrar el Button3 para la acción de guardar
                                Button3.Visible = False
                                Button1.Visible = True


                            Else
                                ' Si el usuario elige no crear un nuevo usuario, bloquear los campos
                                BloquearCampos()
                                LimpiarCampos()
                                ' Ocultar los botones de edición y eliminación
                                Button3.Visible = False
                                Button4.Visible = False
                            End If
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    ' Método para limpiar los campos
    Private Sub LimpiarCampos()
        TextBox2.Clear()
        TextBox3.Clear()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        ComboBox1.SelectedIndex = 0
        TextBox5.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Recolectar datos del formulario
        Dim rut As String = TextBox1.Text

        ' Verificar si el RUT ya existe en la base de datos antes de guardar
        Dim queryCheck As String = "SELECT COUNT(*) FROM personas WHERE RUT = @rut"

        Using connection As New MySqlConnection(connectionString)
            Using commandCheck As New MySqlCommand(queryCheck, connection)
                commandCheck.Parameters.AddWithValue("@rut", rut)

                Try
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(commandCheck.ExecuteScalar())

                    If count > 0 Then
                        ' Si el RUT ya existe, mostrar un mensaje de error
                        MessageBox.Show("El RUT ya existe. No puedes guardar un usuario ya creado. Puedes editarlo o eliminarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Error al verificar el RUT: " & ex.Message)
                    Exit Sub
                Finally
                    connection.Close()
                End Try
            End Using
        End Using

        ' Continuar con el guardado del nuevo usuario si el RUT no existe
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

        ' Crear la consulta SQL para insertar
        Dim query As String = "INSERT INTO personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) VALUES (@rut, @nombre, @apellido, @sexo, @comuna, @ciudad, @observacion)"

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

                Try
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Datos insertados correctamente")
                    LimpiarCampos()
                    BloquearCampos()

                    ' Colocar el foco en TextBox1
                    TextBox1.Focus()

                    ' Mover el cursor del mouse a TextBox1
                    Dim textBoxLocation As Point = Me.PointToScreen(TextBox1.Location)
                    Cursor.Position = New Point(textBoxLocation.X + (TextBox1.Width / 2), textBoxLocation.Y + (TextBox1.Height / 2))

                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If camposDesbloqueados Then
            ' Confirmación para guardar cambios cuando los campos están desbloqueados
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea guardar los cambios?", "Confirmar Edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
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

                ' Crear la consulta SQL para actualizar
                Dim query As String = "UPDATE personas SET Nombre = @nombre, Apellido = @apellido, Sexo = @sexo, Comuna = @comuna, Ciudad = @ciudad, Observacion = @observacion WHERE RUT = @rut"

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

                        Try
                            connection.Open()
                            command.ExecuteNonQuery()
                            MessageBox.Show("Datos actualizados correctamente")
                        Catch ex As MySqlException
                            MessageBox.Show("Error: " & ex.Message)
                        Finally
                            connection.Close()
                        End Try
                    End Using
                End Using

                ' Bloquear los campos nuevamente después de la actualización
                BloquearCampos()

                ' Rehabilitar Button1 y Button4
                Button1.Enabled = True
                Button4.Enabled = True

                ' Cambiar el texto del botón a "Editar"
                Button3.Text = "Editar"
            End If
        Else
            ' Desbloquear campos y cambiar el texto del botón a "Modo Edición"
            DesbloquearCampos()

            ' Deshabilitar Button1 y Button4 mientras está en modo edición
            Button1.Enabled = False
            Button4.Enabled = False

            Button3.Text = "Confirmar"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Preguntar si el usuario está seguro de eliminar
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.No Then
            Exit Sub
        End If

        ' Obtener el RUT del registro a eliminar
        Dim rut As String = TextBox1.Text

        ' Crear la consulta SQL para eliminar
        Dim query As String = "DELETE FROM personas WHERE RUT = @rut"

        ' Ejecutar la consulta
        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                ' Agregar parámetro
                command.Parameters.AddWithValue("@rut", rut)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Registro eliminado correctamente")
                    Else
                        MessageBox.Show("No se encontró el RUT especificado")
                    End If
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    connection.Close()
                End Try
            End Using
        End Using
    End Sub
End Class