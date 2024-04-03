

Public Class Cliente
    Private _ID As Integer
    Private _nombre As String
    Private _telefono As String
    Private _mail As String

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Mail As String
        Get
            Return _mail
        End Get
        Set(value As String)
            _mail = value
        End Set
    End Property
End Class