Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class Documents
    Private _idDocument As Integer
    Public Property id_Document() As Integer
        Get
            Return _idDocument
        End Get
        Set(ByVal value As Integer)
            _idDocument = value
        End Set
    End Property

    Private _idRegistry As Integer
    Public Property id_Registry() As Integer
        Get
            Return _idRegistry
        End Get
        Set(ByVal value As Integer)
            _idRegistry = value
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
    Private _DocumentName As String
    Public Property DocumentName() As String
        Get
            Return _DocumentName
        End Get
        Set(ByVal value As String)
            _DocumentName = value
        End Set
    End Property

    Private _DocumentDescription As String
    Public Property DocumentDescription() As String
        Get
            Return _DocumentDescription
        End Get
        Set(ByVal value As String)
            _DocumentDescription = value
        End Set
    End Property

    Private _fileName As String
    Public Property fileName() As String
        Get
            Return _fileName
        End Get
        Set(ByVal value As String)
            _fileName = value
        End Set
    End Property

    Private _CreationDate As DateTime
    Public Property CreationDate() As DateTime
        Get
            Return _CreationDate
        End Get
        Set(ByVal value As DateTime)
            _CreationDate = value
        End Set
    End Property

    Private _SeqDocument As String
    Public Property SeqDocument() As String
        Get
            Return _SeqDocument
        End Get
        Set(ByVal value As String)
            _SeqDocument = value
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
