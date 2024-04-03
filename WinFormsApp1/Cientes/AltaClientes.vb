Imports System.Configuration
Imports System.Data.SqlClient

Public Class AltaClientes
    Private vengoDeGuardar As Boolean = 0
    Private connection As SqlConnection
    Dim cliente As New Cliente
    Private Function Guardar() As Boolean
        cliente.Nombre = TextBoxNombre.Text
        cliente.Telefono = TextBoxTelefono.Text
        cliente.Mail = TextBoxCorreo.Text
        If Not ValidarDatos() Then
            Return False
        End If
        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        connection = New SqlConnection(connectionString) ' Inicializar la conexión
        Try
            connection.Open()
            Dim sqlQuery = "INSERT INTO clientes values(@cliente,@telefono,@mail)"
            Using command As New SqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@cliente", cliente.Nombre)
                command.Parameters.AddWithValue("@telefono", cliente.Telefono)
                command.Parameters.AddWithValue("@mail", cliente.Mail)
                Dim rowsAffected = command.ExecuteNonQuery
                If rowsAffected > 0 Then
                    MessageBox.Show("Alta exitosa.")
                Else
                    MessageBox.Show("No se realizó ninguna alta.")
                End If
            End Using
        Catch ex As Exception
            ' Maneja cualquier error que pueda ocurrir durante la conexión o la consulta
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close() ' Cierra la conexión aquí
            End If
        End Try
        Return True
    End Function
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If Guardar() Then
            vengoDeGuardar = 1
            Me.Close()
        Else
            MessageBox.Show("Error al guardar")
        End If
    End Sub

    Private Function ValidarDatos() As Boolean
        If cliente.Nombre = "" Then
            MessageBox.Show("El nombre es necesario.")
            Return False
        End If
        If cliente.Telefono = "" Then
            MessageBox.Show("El telefono es necesario.")
            Return False
        End If
        If cliente.Mail = "" Then
            MessageBox.Show("El mail es necesario.")
            Return False
        End If
        Return True
    End Function

    Private Sub GuardarYSeguir_Click(sender As Object, e As EventArgs) Handles GuardarYSeguirToolStripMenuItem.Click
        If Guardar() Then
            vengoDeGuardar = 0
            TextBoxNombre.Text = ""
            TextBoxTelefono.Text = ""
            TextBoxCorreo.Text = ""
        Else
            MessageBox.Show("Error al guardar")
        End If
    End Sub

    Private Sub AltaClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If vengoDeGuardar = 0 Then
            ' Mostrar mensaje de confirmación al cerrar el formulario
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                e.Cancel = True ' Cancelar el cierre del formulario
            End If
        End If
    End Sub
End Class