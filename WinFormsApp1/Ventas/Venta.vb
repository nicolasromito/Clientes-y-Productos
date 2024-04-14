

Public Class Venta
    Private _IDVenta As Integer
    Private __IDCliente As String
    Private _fecha As String
    Private _total As String

    Public Property ID As Integer
        Get
            Return _IDVenta
        End Get
        Set(value As Integer)
            _IDVenta = value
        End Set
    End Property
    Public Property Cliente As String
        Get
            Return __IDCliente
        End Get
        Set(value As String)
            __IDCliente = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property Total As String
        Get
            Return _total
        End Get
        Set(value As String)
            _total = value
        End Set
    End Property
End Class