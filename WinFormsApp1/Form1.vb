Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports WinFormsApp1.Cliente
Imports WinFormsApp1.Producto

Public Class Form1
    Dim treeIndex As Integer
    Private connection As SqlConnection
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatosDataGridView()
    End Sub
    Private Sub AltaClientes()

    End Sub
    Private Sub BajaClientes()

    End Sub
    Private Sub ModiClientes()

    End Sub
    'Manejo del tree-------------------------------------------->
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode IsNot Nothing Then
            treeIndex = TreeView1.Nodes.IndexOf(TreeView1.SelectedNode)
        End If
        CargarDatosDataGridView()
    End Sub
    'Boton para agregar un nuevo cliente----------------------------------->
    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox2.Click
        If treeIndex = 0 Then
            Dim alta As New AltaClientes()
            alta.StartPosition = FormStartPosition.CenterScreen
            alta.ShowDialog()
            CargarDatosDataGridView()
        ElseIf treeIndex = 1 Then
            MessageBox.Show("Alta a productos.")
            '  Dim alta As New AltaProductos()
            'alta.StartPosition = FormStartPosition.CenterScreen
            ' Mostrar el formulario
            ' alta.Show()
        End If
    End Sub
    'Boton para eliminar un cliente seleccionado----------------------------------------->
    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub
    'Muestra la lista de clientes ----------------------------------------------------------->
    Private Sub CargarDatosDataGridView()
        Dim query As String = ""
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            If treeIndex = 0 Then
                query = "SELECT * FROM clientes WHERE (@valor = '' OR @elemento = @valor)"
            ElseIf treeIndex = 1 Then
                query = "SELECT * FROM Productos"
            End If
            MessageBox.Show(ComboBox1.Text)
            Dim command As New SqlCommand(query, connection)

            If treeIndex = 0 Then
                command.Parameters.AddWithValue("@elemento", ComboBox1.Text) ' Cambia "cliente" por el campo real que deseas filtrar
                command.Parameters.AddWithValue("@valor", TextBox1.Text) ' Suponiendo que el valor viene de un TextBox
            End If

            Dim reader As SqlDataReader = command.ExecuteReader

            If treeIndex = 0 Then
                Dim listaDatos As New List(Of Cliente)

                While reader.Read
                    Dim cliente As New Cliente
                    cliente.ID = reader("ID")
                    cliente.Nombre = reader("cliente").ToString
                    cliente.Telefono = reader("telefono").ToString
                    cliente.Mail = reader("correo").ToString
                    listaDatos.Add(cliente)
                End While

                DataGridView1.DataSource = listaDatos
                DataGridView1.Columns(0).Width = 40
            ElseIf treeIndex = 1 Then
                ' Código para cargar datos de productos en el DataGridView
            End If

            reader.Close()
            connection.Close()
        End Using

    End Sub
    'Selecciona toda la fila en vez de un elemento----------------------------------------->
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = DataGridView1.SelectedCells(0)
            DataGridView1.Rows(selectedCell.RowIndex).Selected = True
        End If
    End Sub
    'Evento que se dispara al hacer doble click en una fila --------------------------------------------->
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        If e.RowIndex >= 0 Then
            Dim idCliente As Object = DataGridView1.Rows(e.RowIndex).Cells("ID").Value
            Dim modi As New ModiClientes(idCliente)
            modi.StartPosition = FormStartPosition.CenterScreen
            modi.ShowDialog()
            CargarDatosDataGridView()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            CargarDatosDataGridView()
        End If
    End Sub

    Private Sub BuscarProducto()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
