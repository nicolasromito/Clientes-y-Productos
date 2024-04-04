﻿Imports System.ComponentModel.Design.ObjectSelectorEditor
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
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim id As Object = DataGridView1.Rows(DataGridView1.SelectedCells(0).RowIndex).Cells("ID").Value
            EliminarCliente(id.ToString())
            CargarDatosDataGridView()
        End If
    End Sub
    Private Sub EliminarCliente(idCliente As String)
        Dim query As String = ""
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            query = "DELETE FROM clientes WHERE ID = @valor"

            Dim command As New SqlCommand(query, connection)

            command.Parameters.AddWithValue("@valor", idCliente)

            Dim reader As SqlDataReader = command.ExecuteReader

            reader.Close()
            connection.Close()
        End Using
    End Sub
    'Muestra la lista de clientes ----------------------------------------------------------->
    Private Sub CargarDatosDataGridView()
        Dim query As String = ""
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            If treeIndex = 0 Then
                ' Construir la consulta SQL según la opción seleccionada en el ComboBox
                Dim elemento As String = ""
                Select Case ComboBox1.SelectedIndex
                    Case 0
                        elemento = "ID"
                    Case 1
                        elemento = "cliente"
                    Case 2
                        elemento = "telefono"
                    Case 3
                        elemento = "correo"
                    Case Else
                        elemento = "cliente" ' Valor predeterminado si no se selecciona ninguna opción válida
                End Select

                query = "SELECT * FROM clientes WHERE (@valor = '' OR " & elemento & " LIKE @valor)"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@valor", "%" & TextBox1.Text & "%") ' Filtrar por el valor ingresado en TextBox1

                Dim reader As SqlDataReader = command.ExecuteReader

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

                reader.Close()
            ElseIf treeIndex = 1 Then
                query = "SELECT * FROM Productos"
                ' Código para cargar datos de productos en el DataGridView
            End If

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

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            CargarDatosDataGridView()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CargarDatosDataGridView()
    End Sub
End Class
