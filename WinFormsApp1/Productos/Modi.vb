'Imports System.Configuration
'Imports System.Data.SqlClient

'Public Class ModiClientes
'    Private valorCeldaSeleccionada As Object = Nothing
'    Private numCelda As Integer
'    Private valorCeldaID As Object = Nothing

'    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
'        ' Verificar si se hizo clic en una celda válida
'        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
'            ' Mostrar el valor de la celda en un MessageBox (puedes ajustarlo según tus necesidades)
'            valorCeldaID = DataGridView1.Rows(e.RowIndex).Cells("Nombre").Value
'        End If
'    End Sub

'    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
'        ' Verificar si se hizo clic en una celda válida
'        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
'            ' Mostrar el valor de la celda en un MessageBox (puedes ajustarlo según tus necesidades)
'            valorCeldaSeleccionada = DataGridView1.CurrentCell.Value
'            numCelda = e.ColumnIndex
'        End If
'    End Sub
'    Private Sub ButtonAlta_Click_1(sender As Object, e As EventArgs) Handles ButtonModi.Click
'        Dim connectionString = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
'        If valorCeldaSeleccionada IsNot Nothing Then
'            ' Crear una nueva conexión SQL
'            Using connection As New SqlConnection(connectionString)
'                Try
'                    ' Abre la conexión
'                    connection.Open()

'                    Dim sqlQuery
'                    Select Case numCelda
'                        Case 0
'                            ' Código a ejecutar si variable es igual a 0
'                            sqlQuery = "update clientes set cliente=@variable where cliente=@ID"
'                        Case 1
'                            ' Código a ejecutar si variable es igual a 1
'                            sqlQuery = "update clientes set telefono=@variable where cliente=@ID"
'                        Case 2
'                            ' Código a ejecutar si variable es igual a 2
'                            sqlQuery = "update clientes set correo=@variable where cliente=@ID"
'                        Case Else
'                            Return
'                    End Select

'                    ' Crea un comando SQL utilizando la consulta y la conexión
'                    Using command As New SqlCommand(sqlQuery, connection)

'                        command.Parameters.AddWithValue("@variable", valorCeldaSeleccionada)
'                        command.Parameters.AddWithValue("@ID", valorCeldaID)
'                        ' Ejecuta el comando
'                        Dim rowsAffected = command.ExecuteNonQuery

'                        ' Verifica si se actualizaron filas y muestra un mensaje
'                        If rowsAffected > 0 Then
'                            MessageBox.Show("Modi exitosa.")
'                        Else
'                            MessageBox.Show("No se realizó ningun Modificacion.")
'                        End If
'                    End Using
'                Catch ex As Exception
'                    ' Maneja cualquier error que pueda ocurrir durante la conexión o la consulta
'                    MessageBox.Show("Error: " & ex.Message)
'                End Try
'            End Using
'        Else
'            MessageBox.Show("No se ha seleccionado ninguna celda.")
'        End If
'        ' Cadena de conexión a la base de datos

'        CargarDatosDataGridView()
'    End Sub

'    Private Sub Alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        ' Llamamos al método para cargar los datos en el DataGridView al cargar el formulario
'        CargarDatosDataGridView()
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

'End Class