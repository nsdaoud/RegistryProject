Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class Registry204
    Private _id204Registry As Integer
    Public Property id_204Registry() As Integer
        Get
            Return _id204Registry
        End Get
        Set(ByVal value As Integer)
            _id204Registry = value
        End Set
    End Property

    Private _idRegistry206 As Integer
    Public Property id_Registry206() As Integer
        Get
            Return _idRegistry206
        End Get
        Set(ByVal value As Integer)
            _idRegistry206 = value
        End Set
    End Property
    Private _Registry204Seq As Integer
    Public Property Registry_204Seq() As Integer
        Get
            Return _Registry204Seq
        End Get
        Set(ByVal value As Integer)
            _Registry204Seq = value
        End Set
    End Property
    Private _Registry204Year As String
    Public Property Registry_204Year() As String
        Get
            Return _Registry204Year
        End Get
        Set(ByVal value As String)
            _Registry204Year = value
        End Set
    End Property

    Private _Registry204Date As Nullable(Of DateTime)
    Public Property Registry_204Date() As Nullable(Of DateTime)
        Get
            Return _Registry204Date
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _Registry204Date = value
        End Set
    End Property

    Private _RegistryDescription As String
    Public Property Registry_Description() As String
        Get
            Return _RegistryDescription
        End Get
        Set(ByVal value As String)
            _RegistryDescription = value
        End Set
    End Property

    Private _IncomingNumber As String
    Public Property IncomingNumber() As String
        Get
            Return _IncomingNumber
        End Get
        Set(ByVal value As String)
            _IncomingNumber = value
        End Set
    End Property

    Private _IncomingDate As Nullable(Of DateTime)
    Public Property IncomingDate() As Nullable(Of DateTime)
        Get
            Return _IncomingDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _IncomingDate = value
        End Set
    End Property

    Private _idUser As Integer
    Public Property id_User() As Integer
        Get
            Return _idUser
        End Get
        Set(ByVal value As Integer)
            _idUser = value
        End Set
    End Property

    Private _UserLogin As String
    Public Property UserLogin() As String
        Get
            Return _UserLogin
        End Get
        Set(ByVal value As String)
            _UserLogin = value
        End Set
    End Property


    Private _idUser2 As Integer
    Public Property id_User2() As Integer
        Get
            Return _idUser2
        End Get
        Set(ByVal value As Integer)
            _idUser2 = value
        End Set
    End Property

    Private _UserLogin2 As String
    Public Property UserLogin2() As String
        Get
            Return _UserLogin2
        End Get
        Set(ByVal value As String)
            _UserLogin2 = value
        End Set
    End Property

    Private _idDeliveredFor As Integer
    Public Property id_DeliveredFor() As Integer
        Get
            Return _idDeliveredFor
        End Get
        Set(ByVal value As Integer)
            _idDeliveredFor = value
        End Set
    End Property

    Private _DeliveredFor As List(Of DeliveredFor)
    Public Property _DeliveredForObjet() As List(Of DeliveredFor)
        Get
            Return _DeliveredFor
        End Get
        Set(ByVal value As List(Of DeliveredFor))
            _DeliveredFor = value
        End Set
    End Property

    Private _DeliveredForDescription As String
    Public Property DeliveredForDescription() As String
        Get
            Return _DeliveredForDescription
        End Get
        Set(ByVal value As String)
            _DeliveredForDescription = value
        End Set
    End Property

    Private _RegistryType As String
    Public Property RegistryType() As String
        Get
            Return _RegistryType
        End Get
        Set(ByVal value As String)
            _RegistryType = value
        End Set
    End Property

    Private _rowaction As Integer
    Public Property Rowaction() As Integer
        Get
            Return _rowaction
        End Get
        Set(ByVal value As Integer)
            _rowaction = value
        End Set
    End Property

    Private _type204 As String
    Public Property Type204() As String
        Get
            Return _type204
        End Get
        Set(ByVal value As String)
            _type204 = value
        End Set
    End Property

End Class
