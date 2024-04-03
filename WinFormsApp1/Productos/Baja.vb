'Imports System.Configuration
'Imports System.Data.SqlClient
'Imports System.Net
'Imports System.Runtime.InteropServices.JavaScript.JSType

'Public Class BajaClientes
'    Private Sub ButtonBaja_Click(sender As Object, e As EventArgs) Handles ButtonBaja.Click
'        If ListBox1.SelectedItems.Count > 0 Then
'            ' Obtener el primer elemento seleccionado (para selección simple)
'            Dim elementoSeleccionado As Object = ListBox1.SelectedItem

'            Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

'            ' Crear una nueva conexión SQL
'            Using connection As New SqlConnection(connectionString)
'                Try
'                    ' Abre la conexión
'                    connection.Open()

'                    ' Define la consulta SQL que deseas ejecutar (por ejemplo, un SELECT)
'                    'Dim sqlQuery As String = "SELECT * FROM clientes"

'                    ' Obtén el valor del Label que contiene los datos que quieres actualizar
'                    'Dim nuevoValor As String = TextCliente.Text ' Suponiendo que Label1 contiene el nuevo valor a actualizar

'                    ' Define la consulta SQL para realizar el UPDATE
'                    'Dim sqlQuery As String = "INSERT INTO clientes SET Telefono = @NuevoValor WHERE ID = 1"
'                    Dim sqlQuery = "DELETE FROM clientes WHERE cliente=@cliente"

'                    ' Crea un comando SQL utilizando la consulta y la conexión
'                    Using command As New SqlCommand(sqlQuery, connection)

'                        command.Parameters.AddWithValue("@cliente", elementoSeleccionado.ToString())
'                        ' Ejecuta el comando
'                        Dim rowsAffected = command.ExecuteNonQuery

'                        ' Verifica si se actualizaron filas y muestra un mensaje
'                        If rowsAffected > 0 Then
'                            MessageBox.Show("Baja exitosa.")
'                        Else
'                            MessageBox.Show("No se dio de baja a ningun cliente.")
'                        End If
'                    End Using
'                Catch ex As Exception
'                    ' Maneja cualquier error que pueda ocurrir durante la conexión o la consulta
'                    MessageBox.Show("Error: " & ex.Message)
'                End Try
'            End Using
'        Else
'            ' Mostrar un mensaje si no hay elementos seleccionados
'            MessageBox.Show("No se ha seleccionado ningún elemento.")
'        End If

'        ListBox1_SelectedIndexChanged(ListBox1, EventArgs.Empty)
'    End Sub

'    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MyBase.Load
'        Dim query As String = "SELECT * FROM clientes"

'        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
'        Dim connection As New SqlConnection(connectionString)
'        Dim command As New SqlCommand(query, connection)

'        ' Abrir la conexión
'        connection.Open()

'        ' Ejecutar la consulta y obtener los datos
'        Dim reader As SqlDataReader = command.ExecuteReader()

'        ' Crear una lista para almacenar los resultados
'        Dim listaDatos As New List(Of String)()

'        ' Leer los datos y agregarlos a la lista
'        While reader.Read()
'            listaDatos.Add(reader("cliente").ToString()) ' Reemplaza "Nombre" con el nombre de la columna que deseas mostrar en el ListBox
'        End While

'        ' Cerrar el DataReader y la conexión
'        reader.Close()
'        connection.Close()

'        ListBox1.DataSource = listaDatos
'    End Sub

'End Class