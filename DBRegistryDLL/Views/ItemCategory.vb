Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class ItemCategory
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
