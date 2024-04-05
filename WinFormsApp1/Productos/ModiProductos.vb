Imports System.Configuration
Imports System.Data.SqlClient

Public Class ModiProductos
    Private valorCeldaID As Object = Nothing
    Private vengoDeGuardar As Boolean = 0
    Public Sub New(ProductoID As Object)
        InitializeComponent()
        valorCeldaID = ProductoID
    End Sub

    Private Sub Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub CargarDatos()
        Dim query = "SELECT * FROM productos WHERE ID=@ID"

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
                            Dim producto As New Producto()
                            producto.Producto = reader("nombre").ToString()
                            producto.Precio = reader("precio").ToString()
                            producto.Categoria = reader("categoria").ToString()
                            RellenarCasillas(producto)
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

    Private Sub RellenarCasillas(producto As Producto)
        If producto IsNot Nothing Then
            TextBoxProducto.Text = producto.Producto
            TextBoxPrecio.Text = producto.Precio
            TextBoxCategoria.Text = producto.Categoria
        End If
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
        Using connection As New SqlConnection(connectionString)
            Try
                ' Abre la conexión
                connection.Open()
                Dim sqlQuery = "update productos set nombre=@producto, precio=@precio, categoria=@categoria where ID=@ID"

                ' Crea un comando SQL utilizando la consulta y la conexión
                Using command As New SqlCommand(sqlQuery, connection)
                    command.Parameters.AddWithValue("@producto", TextBoxProducto.Text)
                    command.Parameters.AddWithValue("@precio", TextBoxPrecio.Text)
                    command.Parameters.AddWithValue("@categoria", TextBoxCategoria.Text)
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
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea borrar el producto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If
        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

        Using connection As New SqlConnection(connectionString)
            Try

                connection.Open()

                Dim sqlQuery = "DELETE FROM productos WHERE ID=@ID"

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