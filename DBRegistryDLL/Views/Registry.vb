Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class Registry

    Private _idCompleteRegistry As Integer
    Public Property id_CompleteRegistry() As Integer
        Get
            Return _idCompleteRegistry
        End Get
        Set(ByVal value As Integer)
            _idCompleteRegistry = value
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
    Private _RegistrySeq As Integer
    Public Property Registry_Seq() As Integer
        Get
            Return _RegistrySeq
        End Get
        Set(ByVal value As Integer)
            _RegistrySeq = value
        End Set
    End Property
    Private _RegistryYear As String
    Public Property Registry_Year() As String
        Get
            Return _RegistryYear
        End Get
        Set(ByVal value As String)
            _RegistryYear = value
        End Set
    End Property

    Private _RegistryDate As Nullable(Of DateTime)
    Public Property Registry_Date() As Nullable(Of DateTime)
        Get
            Return _RegistryDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _RegistryDate = value
        End Set
    End Property

    Private _RegistrySubmitted As String
    Public Property Registry_Submitted() As String
        Get
            Return _RegistrySubmitted
        End Get
        Set(ByVal value As String)
            _RegistrySubmitted = value
        End Set
    End Property

    Private _Papernumber As String
    Public Property Papernumber() As String
        Get
            Return _Papernumber
        End Get
        Set(ByVal value As String)
            _Papernumber = value
        End Set
    End Property

    Private _PaperDate As Nullable(Of DateTime)
    Public Property PaperDate() As Nullable(Of DateTime)
        Get
            Return _PaperDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _PaperDate = value
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

    Private _DeliveredFromduedate As Nullable(Of DateTime)
    Public Property DeliveredFrom_duedate() As Nullable(Of DateTime)
        Get
            Return _DeliveredFromduedate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _DeliveredFromduedate = value
        End Set
    End Property

    Private _DeliveredToduedate As Nullable(Of DateTime)
    Public Property DeliveredTo_duedate() As Nullable(Of DateTime)
        Get
            Return _DeliveredToduedate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _DeliveredToduedate = value
        End Set
    End Property

    Private _SubmissionDate As Nullable(Of DateTime)
    Public Property SubmissionDate() As Nullable(Of DateTime)
        Get
            Return _SubmissionDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _SubmissionDate = value
        End Set
    End Property

    Private _SubjectSentFor As String
    Public Property SubjectSentFor() As String
        Get
            Return _SubjectSentFor
        End Get
        Set(ByVal value As String)
            _SubjectSentFor = value
        End Set
    End Property

    Private _DateOfRegistration As Nullable(Of DateTime)
    Public Property DateOfRegistration() As Nullable(Of DateTime)
        Get
            Return _DateOfRegistration
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _DateOfRegistration = value
        End Set
    End Property


    Private _RegistryBackSide As String
    Public Property Registry_BackSide() As String
        Get
            Return _RegistryBackSide
        End Get
        Set(ByVal value As String)
            _RegistryBackSide = value
        End Set
    End Property

    Private _idPaperSource As Integer
    Public Property id_PaperSource() As Integer
        Get
            Return _idPaperSource
        End Get
        Set(ByVal value As Integer)
            _idPaperSource = value
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

    Private _lstidDeliveredFor As List(Of Integer)
    Public Property lstid_DeliveredFor() As List(Of Integer)
        Get
            Return _lstidDeliveredFor
        End Get
        Set(ByVal value As List(Of Integer))
            _lstidDeliveredFor = value
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
    Private _PaperSourceDescription As String
    Public Property PaperSourceDescription() As String
        Get
            Return _PaperSourceDescription
        End Get
        Set(ByVal value As String)
            _PaperSourceDescription = value
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
    Private _rowaction As Integer
    Public Property Rowaction() As Integer
        Get
            Return _rowaction
        End Get
        Set(ByVal value As Integer)
            _rowaction = value
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

    Private _Comments As String
    Public Property Comments() As String
        Get
            Return _Comments
        End Get
        Set(ByVal value As String)
            _Comments = value
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

    Private _RegistrySubmittedyear As Nullable(Of DateTime)
    Public Property RegistrySubmittedyear() As Nullable(Of DateTime)
        Get
            Return _RegistrySubmittedyear
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _RegistrySubmittedyear = value
        End Set
    End Property


    Private _RegistrydueDate As Nullable(Of DateTime)
    Public Property RegistrydueDate() As Nullable(Of DateTime)
        Get
            Return _RegistrydueDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _RegistrydueDate = value
        End Set
    End Property

    Private _Values204 As String
    Public Property Values204() As String
        Get
            Return _Values204
        End Get
        Set(ByVal value As String)
            _Values204 = value
        End Set
    End Property

    Private _OldValues204 As String
    Public Property OldValues204() As String
        Get
            Return _OldValues204
        End Get
        Set(ByVal value As String)
            _OldValues204 = value
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

    Private _DeliveredFor As List(Of DeliveredFor)
    Public Property _DeliveredForObjet() As List(Of DeliveredFor)
        Get
            Return _DeliveredFor
        End Get
        Set(ByVal value As List(Of DeliveredFor))
            _DeliveredFor = value
        End Set
    End Property

    Private _type206 As String
    Public Property type206() As String
        Get
            Return _type206
        End Get
        Set(ByVal value As String)
            _type206 = value
        End Set
    End Property

    Private _id204Registry As Integer
    Public Property id204Registry() As Integer
        Get
            Return _id204Registry
        End Get
        Set(ByVal value As Integer)
            _id204Registry = value
        End Set
    End Property

    Private _Values204in206 As String
    Public Property Values204in206() As String
        Get
            Return _Values204in206
        End Get
        Set(ByVal value As String)
            _Values204in206 = value
        End Set
    End Property

    Private idUserTransactions As Integer
    Public Property id_UserTransactions() As Integer
        Get
            Return idUserTransactions
        End Get
        Set(ByVal value As Integer)
            idUserTransactions = value
        End Set
    End Property

    Private _UserTransactions As String
    Public Property UserTransactions() As String
        Get
            Return _UserTransactions
        End Get
        Set(ByVal value As String)
            _UserTransactions = value
        End Set
    End Property



End Class
