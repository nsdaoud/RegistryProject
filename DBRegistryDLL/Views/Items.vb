Imports System.Collections.Generic
Imports System.Linq
Imports System.Text


Public Class Items

    Private _idItems As Integer
    Public Property id_Items() As Integer
        Get
            Return _idItems
        End Get
        Set(ByVal value As Integer)
            _idItems = value
        End Set
    End Property

    Private _idItemCategory As Integer
    Public Property id_ItemCategory() As Integer
        Get
            Return _idItemCategory
        End Get
        Set(ByVal value As Integer)
            _idItemCategory = value
        End Set
    End Property

    Private _descriptionItemCategory As String
    Public Property descriptionItemCategory() As String
        Get
            Return _descriptionItemCategory
        End Get
        Set(ByVal value As String)
            _descriptionItemCategory = value
        End Set
    End Property

    Private _idUnit As Integer
    Public Property id_Unite() As Integer
        Get
            Return _idUnit
        End Get
        Set(ByVal value As Integer)
            _idUnit = value
        End Set
    End Property

    Private _UnitCode As String
    Public Property UnitCode() As String
        Get
            Return _UnitCode
        End Get
        Set(ByVal value As String)
            _UnitCode = value
        End Set
    End Property



    Private _ItemsDescription As String
    Public Property ItemsDescription() As String
        Get
            Return _ItemsDescription
        End Get
        Set(ByVal value As String)
            _ItemsDescription = value
        End Set
    End Property

    Private _ItemPrice As Double
    Public Property ItemPrice() As Double
        Get
            Return _ItemPrice
        End Get
        Set(ByVal value As Double)
            _ItemPrice = value
        End Set
    End Property

    Private _idCurrency As Integer
    Public Property id_Currency() As Integer
        Get
            Return _idCurrency
        End Get
        Set(ByVal value As Integer)
            _idCurrency = value
        End Set
    End Property

    Private _CurrencyCode As String
    Public Property CurrencyCode() As String
        Get
            Return _CurrencyCode
        End Get
        Set(ByVal value As String)
            _CurrencyCode = value
        End Set
    End Property




End Class
