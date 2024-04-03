Imports System.Configuration
Imports System.Data.SqlClient

Public Class ModiClientes
    Private valorCeldaID As Object = Nothing
    Private vengoDeGuardar As Boolean = 0
    ' Constructor que recibe el ID del cliente como parámetro
    Public Sub New(idCliente As Object)
        InitializeComponent()
        valorCeldaID = idCliente ' Asignar el ID del cliente recibido al campo valorCeldaID
    End Sub

    Private Sub Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Dim query = "SELECT * FROM clientes WHERE ID=@ID"

        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                ' Crear un comando SQL con parámetros para evitar la concatenación directa en la consulta
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@ID", valorCeldaID)

                    ' Ejecutar la consulta y obtener los datos
                    Dim reader = command.ExecuteReader()

                    ' Verificar si se leyeron datos
                    If reader.HasRows Then
                        ' Leer los datos y asignarlos a un objeto Cliente
                        While reader.Read()
                            Dim cliente As New Cliente()
                            cliente.Nombre = reader("cliente").ToString()
                            cliente.Telefono = reader("telefono").ToString()
                            cliente.Mail = reader("correo").ToString()
                            RellenarCasillas(cliente)
                        End While
                    Else
                        MessageBox.Show("No se encontraron datos para el ID especificado.")
                    End If

                    reader.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al cargar datos: " & ex.Message)
            End Try
        End Using

    End Sub

    Private Sub RellenarCasillas(cliente As Cliente)
        If cliente IsNot Nothing Then
            TextBoxNombre.Text = cliente.Nombre
            TextBoxTelefono.Text = cliente.Telefono
            TextBoxCorreo.Text = cliente.Mail
            ' Puedes seguir agregando más líneas para llenar otros TextBox con más propiedades del objeto Cliente si es necesario
        End If
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abre la conexión
                connection.Open()
                Dim sqlQuery = "update clientes set cliente=@cliente, telefono=@telefono, correo=@correo where ID=@ID"

                ' Crea un comando SQL utilizando la consulta y la conexión
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@cliente", TextBoxNombre.Text)
                    command.Parameters.AddWithValue("@telefono", TextBoxTelefono.Text)
                    command.Parameters.AddWithValue("@correo", TextBoxCorreo.Text)
                    command.Parameters.AddWithValue("@ID", valorCeldaID)
                    ' Ejecuta el comando
                    Dim rowsAffected = command.ExecuteNonQuery

                    ' Verifica si se actualizaron filas y muestra un mensaje
                    If rowsAffected > 0 Then
                        MessageBox.Show("Modi exitosa.")
                        vengoDeGuardar = 1
                        CerrarVentana()
                    Else
                        MessageBox.Show("No se realizó ninguna Modificacion.")
                    End If
                End Using
            Catch ex As Exception
                ' Maneja cualquier error que pueda ocurrir durante la conexión o la consulta
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
        ' Cadena de conexión a la base de datos
    End Sub
    Private Sub CerrarVentana()
        ' Cierra el formulario actual
        Me.Close()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

        Using connection As New SqlConnection(connectionString)
            Try

                connection.Open()

                Dim sqlQuery = "DELETE FROM clientes WHERE ID=@ID"

                Using command As New SqlCommand(sqlQuery, connection)

                    command.Parameters.AddWithValue("@ID", valorCeldaID.ToString())
                    ' Ejecuta el comando
                    Dim rowsAffected = command.ExecuteNonQuery

                    ' Verifica si se actualizaron filas y muestra un mensaje
                    If rowsAffected > 0 Then
                        MessageBox.Show("Baja exitosa.")
                        vengoDeGuardar = 1
                        CerrarVentana()
                    Else
                        MessageBox.Show("No se dio de baja a ningun cliente.")
                    End If
                End Using
            Catch ex As Exception
                ' Maneja cualquier error que pueda ocurrir durante la conexión o la consulta
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

    End Sub
    Private Sub ModiClientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If vengoDeGuardar = 0 Then
            ' Mostrar mensaje de confirmación al cerrar el formulario
            Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                e.Cancel = True ' Cancelar el cierre del formulario
            End If
        End If
    End Sub
End Class