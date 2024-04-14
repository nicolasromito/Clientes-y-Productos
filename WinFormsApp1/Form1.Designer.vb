
Imports System.Data.SqlClient ' Importa el espacio de nombres para acceder a SQL Server

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> ' Indica que el formulario fue diseñado usando el diseñador
Partial Class Form1
    Inherits System.Windows.Forms.Form ' Form1 hereda de la clase Form de Windows Forms

    ' Sobrescribe el método Dispose para limpiar recursos
    <System.Diagnostics.DebuggerNonUserCode()> ' Atributo que indica código no generado por el usuario
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose() ' Libera los componentes si existen
            End If
        Finally
            MyBase.Dispose(disposing) ' Llama al método Dispose de la clase base
        End Try
    End Sub

    ' Requerido por el diseñador de formularios de Windows
    Private components As System.ComponentModel.IContainer ' Contenedor para los componentes del formulario

    ' Procedimiento generado por el diseñador de formularios para inicializar componentes
    <System.Diagnostics.DebuggerStepThrough()> ' Atributo que indica código no generado por el usuario
    Private Sub InitializeComponent()
        Dim TreeNode1 As TreeNode = New TreeNode("Clientes")
        Dim TreeNode2 As TreeNode = New TreeNode("Productos")
        Dim TreeNode3 As TreeNode = New TreeNode("Ventas")
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        TreeView1 = New TreeView()
        MenuStrip1 = New MenuStrip()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStripTextBox2 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        Button2 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        MenuStrip1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TreeView1
        ' 
        TreeView1.Location = New Point(0, 31)
        TreeView1.Name = "TreeView1"
        TreeNode1.BackColor = Color.White
        TreeNode1.Name = "Clientes"
        TreeNode1.Text = "Clientes"
        TreeNode2.Name = "Productos"
        TreeNode2.Text = "Productos"
        TreeNode3.Name = "Ventas"
        TreeNode3.Text = "Ventas"
        TreeView1.Nodes.AddRange(New TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        TreeView1.Size = New Size(151, 378)
        TreeView1.TabIndex = 12
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ToolStripTextBox1, ToolStripTextBox2, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(929, 31)
        MenuStrip1.TabIndex = 13
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(140, 27)
        ToolStripTextBox1.Text = "Nicolas Romito"
        ' 
        ' ToolStripTextBox2
        ' 
        ToolStripTextBox2.Name = "ToolStripTextBox2"
        ToolStripTextBox2.Size = New Size(66, 27)
        ToolStripTextBox2.Text = "Nuevo"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(77, 27)
        ToolStripMenuItem1.Text = "Eliminar"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(869, 60)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 29)
        Button2.TabIndex = 15
        Button2.Text = ">"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(284, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 16
        Label1.Text = "Cliente"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(284, 61)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(586, 27)
        TextBox1.TabIndex = 17
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.LightBlue
        DataGridViewCellStyle1.Font = New Font("Arial", 10.0F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeight = 29
        DataGridView1.Location = New Point(175, 106)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(724, 291)
        DataGridView1.TabIndex = 18
        ' 
        ' Clientes
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.ImeMode = ImeMode.NoControl
        ComboBox1.Items.AddRange(New Object() {"ID", "Cliente", "Telefono", "Correo"})
        ComboBox1.Location = New Point(175, 60)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(103, 28)
        ComboBox1.TabIndex = 19
        ' 
        ' Productos
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.ImeMode = ImeMode.NoControl
        ComboBox2.Items.AddRange(New Object() {"ID", "Nombre", "Precio", "Categoria"})
        ComboBox2.Location = New Point(175, 60)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(103, 28)
        ComboBox2.TabIndex = 19
        ' 
        ' Ventas
        ' 
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.FormattingEnabled = True
        ComboBox3.ImeMode = ImeMode.NoControl
        ComboBox3.Items.AddRange(New Object() {"ID", "Cliente", "Fecha"})
        ComboBox3.Location = New Point(175, 60)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(103, 28)
        ComboBox3.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(929, 409)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(TreeView1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Clientes"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Private Sub DataGridView1_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridView1.CellPainting
        ' Verificar si la celda que se está pintando es un encabezado de columna
        If e.RowIndex = -1 AndAlso e.ColumnIndex > -1 Then
            ' Establecer el color de fondo para el encabezado de columna
            e.CellStyle.BackColor = Color.LightBlue
            e.CellStyle.ForeColor = Color.Black ' Opcional: cambiar el color de texto
            e.Paint(e.CellBounds, DataGridViewPaintParts.Background Or DataGridViewPaintParts.ContentForeground Or DataGridViewPaintParts.Border)
            e.Handled = True ' Indicar que el evento ha sido manejado
        End If
    End Sub
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripTextBox2 As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
End Class
