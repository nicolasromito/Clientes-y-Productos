Imports System.Configuration
Imports System.Data.SqlClient

Public Class AltaVentas
    Private vengoDeGuardar As Boolean = 0
    Private connection As SqlConnection
    Dim producto As New Producto
    Private Function Guardar() As Boolean
        producto.Producto = TextBoxProducto.Text
        producto.Precio = TextBoxPrecio.Text
        producto.Categoria = TextBoxCategoria.Text
        If Not ValidarDatos() Then
            Return False
        End If
        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        connection = New SqlConnection(connectionString) ' Inicializar la conexión
        Try
            connection.Open()
            Dim sqlQuery = "INSERT INTO productos values(@producto,@precio,@categoria)"
            Using command As New SqlCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@producto", producto.Producto)
                command.Parameters.AddWithValue("@precio", producto.Precio)
                command.Parameters.AddWithValue("@categoria", producto.Categoria)
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
        If producto.Producto = "" Then
            MessageBox.Show("El nombre es necesario.")
            Return False
        End If
        If producto.Precio = "" Then
            MessageBox.Show("El telefono es necesario.")
            Return False
        End If
        If producto.Categoria = "" Then
            MessageBox.Show("El mail es necesario.")
            Return False
        End If
        Return True
    End Function

    Private Sub GuardarYSeguir_Click(sender As Object, e As EventArgs) Handles GuardarYSeguirToolStripMenuItem.Click
        If Guardar() Then
            vengoDeGuardar = 0
            TextBoxProducto.Text = ""
            TextBoxPrecio.Text = ""
            TextBoxCategoria.Text = ""
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