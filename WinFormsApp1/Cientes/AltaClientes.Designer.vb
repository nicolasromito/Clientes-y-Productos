Imports System.Reflection.Emit

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AltaClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        TextBoxNombre = New TextBox()
        TextBoxTelefono = New TextBox()
        TextBoxCorreo = New TextBox()
        MenuStrip1 = New MenuStrip()
        GuardarToolStripMenuItem = New ToolStripMenuItem()
        GuardarYSeguirToolStripMenuItem = New ToolStripMenuItem()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBoxNombre
        ' 
        TextBoxNombre.Location = New Point(103, 39)
        TextBoxNombre.Name = "TextBoxNombre"
        TextBoxNombre.Size = New Size(300, 27)
        TextBoxNombre.TabIndex = 6
        ' 
        ' TextBoxTelefono
        ' 
        TextBoxTelefono.Location = New Point(103, 79)
        TextBoxTelefono.Name = "TextBoxTelefono"
        TextBoxTelefono.Size = New Size(300, 27)
        TextBoxTelefono.TabIndex = 7
        ' 
        ' TextBoxCorreo
        ' 
        TextBoxCorreo.Location = New Point(103, 120)
        TextBoxCorreo.Name = "TextBoxCorreo"
        TextBoxCorreo.Size = New Size(300, 27)
        TextBoxCorreo.TabIndex = 8
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {GuardarToolStripMenuItem, GuardarYSeguirToolStripMenuItem})
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
        ' GuardarYSeguirToolStripMenuItem
        ' 
        GuardarYSeguirToolStripMenuItem.Name = "GuardarYSeguirToolStripMenuItem"
        GuardarYSeguirToolStripMenuItem.Size = New Size(198, 24)
        GuardarYSeguirToolStripMenuItem.Text = "Guardar y seguir cargando"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 10
        Label1.Text = "Cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 11
        Label2.Text = "Telefono:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 12
        Label3.Text = "Mail:"
        ' 
        ' AltaClientes
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(429, 174)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBoxCorreo)
        Controls.Add(TextBoxTelefono)
        Controls.Add(TextBoxNombre)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "AltaClientes"
        Text = "Alta"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Define los controles del formulario

    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarYSeguirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
