Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class DeliveredFor
    'Public Sub New(ByVal id_DeliveredFor As Integer)
    '    id_DeliveredFor = id_DeliveredFor

    'End Sub

    'Private idUserTransactions As Integer
    'Public Property id_UserTransactions() As Integer
    '    Get
    '        Return idUserTransactions
    '    End Get
    '    Set(ByVal value As Integer)
    '        idUserTransactions = value
    '    End Set
    'End Property


    Private _idDeliveredFor As Integer
    Public Property id_DeliveredFor() As Integer
        Get
            Return _idDeliveredFor
        End Get
        Set(ByVal value As Integer)
            _idDeliveredFor = value
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


    'Private _UserTransactions As String
    'Public Property UserTransactions() As String
    '    Get
    '        Return _UserTransactions
    '    End Get
    '    Set(ByVal value As String)
    '        _UserTransactions = value
    '    End Set
    'End Property


    Private _rowaction As Integer
    Public Property Rowaction() As Integer
        Get
            Return _rowaction
        End Get
        Set(ByVal value As Integer)
            _rowaction = value
        End Set
    End Property

End Class
