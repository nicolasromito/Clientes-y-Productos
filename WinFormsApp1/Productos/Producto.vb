

Public Class Producto
    Private _IDProducto As Integer
    Private _producto As String
    Private _precio As String
    Private _categoria As String

    Public Property ID As Integer
        Get
            Return _IDProducto
        End Get
        Set(value As Integer)
            _IDProducto = value
        End Set
    End Property
    Public Property Producto As String
        Get
            Return _producto
        End Get
        Set(value As String)
            _producto = value
        End Set
    End Property

    Public Property Precio As String
        Get
            Return _precio
        End Get
        Set(value As String)
            _precio = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
End Class