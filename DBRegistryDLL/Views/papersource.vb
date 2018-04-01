Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class papersource
    Private _idPaperSource As Integer
    Public Property id_PaperSource() As Integer
        Get
            Return _idPaperSource
        End Get
        Set(ByVal value As Integer)
            _idPaperSource = value
        End Set
    End Property

    Private _PaperSourceDescription As String
    Public Property PaperSourceDescription() As String
        Get
            Return _PaperSourceDescription
        End Get
        Set(ByVal value As String)
            _PaperSourceDescription = value
        End Set
    End Property
    Private _Selected As Boolean
    Public Property Selected() As Boolean
        Get
            Return _Selected
        End Get
        Set(ByVal value As Boolean)
            _Selected = value
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
