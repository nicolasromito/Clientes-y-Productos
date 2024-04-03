'Imports System.Configuration
'Imports System.Data.SqlClient

'Public Class AltaClientes
'    Private Sub ButtonAlta_Click_1(sender As Object, e As EventArgs) Handles ButtonAlta.Click

'        Dim cliente As New Cliente

'        Dim Nombre = TextCliente.Text
'        Dim telefono = TextTelefono.Text
'        Dim mail = TextMail.Text

'        ' Cadena de conexión a la base de datos
'        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

'        ' Crear una nueva conexión SQL
'        Using connection As New SqlConnection(connectionString)
'            Try
'                ' Abre la conexión
'                connection.Open()

'                ' Define la consulta SQL que deseas ejecutar (por ejemplo, un SELECT)
'                'Dim sqlQuery As String = "SELECT * FROM clientes"

'                ' Obtén el valor del Label que contiene los datos que quieres actualizar
'                'Dim nuevoValor As String = TextCliente.Text ' Suponiendo que Label1 contiene el nuevo valor a actualizar

'                ' Define la consulta SQL para realizar el UPDATE
'                'Dim sqlQuery As String = "INSERT INTO clientes SET Telefono = @NuevoValor WHERE ID = 1"
'                Dim sqlQuery = "INSERT INTO clientes values(@cliente,@telefono,@mail)"

'                ' Crea un comando SQL utilizando la consulta y la conexión
'                Using command As New SqlCommand(sqlQuery, connection)

'                    command.Parameters.AddWithValue("@cliente", Nombre)
'                    command.Parameters.AddWithValue("@telefono", telefono)
'                    command.Parameters.AddWithValue("@mail", mail)
'                    ' Ejecuta el comando
'                    Dim rowsAffected = command.ExecuteNonQuery

'                    ' Verifica si se actualizaron filas y muestra un mensaje
'                    If rowsAffected > 0 Then
'                        MessageBox.Show("Alta exitosa.")
'                    Else
'                        MessageBox.Show("No se realizó ningun alta.")
'                    End If
'                End Using
'            Catch ex As Exception
'                ' Maneja cualquier error que pueda ocurrir durante la conexión o la consulta
'                MessageBox.Show("Error: " & ex.Message)
'            End Try
'        End Using
'        CargarDatosDataGridView()
'    End Sub

'    Private Sub Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Llamamos al método para cargar los datos en el DataGridView al cargar el formulario
'        CargarDatosDataGridView()
'        For Each columna As DataGridViewColumn In DataGridView1.Columns
'            columna.ReadOnly = True
'        Next
'    End Sub

'    Private Sub CargarDatosDataGridView()
'        Dim query = "SELECT * FROM clientes"

'        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
'        Dim connection As New SqlConnection(connectionString)
'        Dim command As New SqlCommand(query, connection)

'        ' Abrir la conexión
'        connection.Open()

'        ' Ejecutar la consulta y obtener los datos
'        Dim reader = command.ExecuteReader

'        ' Crear una lista para almacenar los resultados
'        Dim listaDatos As New List(Of Cliente)

'        ' Leer los datos y agregarlos a la lista
'        While reader.Read
'            Dim cliente As New Cliente
'            cliente.Nombre = reader("cliente").ToString
'            cliente.Telefono = reader("telefono").ToString
'            cliente.Mail = reader("correo").ToString
'            listaDatos.Add(cliente)
'        End While

'        ' Cerrar el DataReader y la conexión
'        reader.Close()
'        connection.Close()

'        DataGridView1.DataSource = listaDatos
'    End Sub

'    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

'    End Sub
'End Class