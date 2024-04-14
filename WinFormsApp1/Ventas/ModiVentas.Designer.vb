<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModiVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBoxCliente = New TextBox()
        TextBoxFecha = New TextBox()
        TextBoxTotal = New TextBox()
        MenuStrip1 = New MenuStrip()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        EliminarToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 20)
        Label1.TabIndex = 3
        Label1.Text = "Cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 4
        Label2.Text = "Fecha:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 20)
        Label3.TabIndex = 5
        Label3.Text = "Total:"
        ' 
        ' TextBoxCliente
        ' 
        TextBoxCliente.Location = New Point(103, 39)
        TextBoxCliente.Name = "TextBoxCliente"
        TextBoxCliente.Size = New Size(300, 27)
        TextBoxCliente.TabIndex = 6
        ' 
        ' TextBoxFecha
        ' 
        TextBoxFecha.Location = New Point(103, 79)
        TextBoxFecha.Name = "TextBoxFecha"
        TextBoxFecha.Size = New Size(300, 27)
        TextBoxFecha.TabIndex = 7
        ' 
        ' TextBoxTotal
        ' 
        TextBoxTotal.Location = New Point(103, 120)
        TextBoxTotal.Name = "TextBoxTotal"
        TextBoxTotal.Size = New Size(300, 27)
        TextBoxTotal.TabIndex = 8
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {GuardarToolStripMenuItem, EliminarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(429, 28)
        MenuStrip1.TabIndex = 9
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GuardarToolStripMenuItem
        ' 
        GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        GuardarToolStripMenuItem.Size = New Size(76, 24)
        GuardarToolStripMenuItem.Text = "Guardar"
        ' 
        ' EliminarToolStripMenuItem
        ' 
        EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        EliminarToolStripMenuItem.Size = New Size(77, 24)
        EliminarToolStripMenuItem.Text = "Eliminar"
        ' 
        ' ModiProductos
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 174)
        Controls.Add(TextBoxTotal)
        Controls.Add(TextBoxFecha)
        Controls.Add(TextBoxCliente)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "ModiVentas"
        Text = "Modi"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents TextBoxFecha As TextBox
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
