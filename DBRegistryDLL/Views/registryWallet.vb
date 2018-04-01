Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class registryWallet
    Private _idRegistryWallet As Integer
    Public Property id_RegistryWallet() As Integer
        Get
            Return _idRegistryWallet
        End Get
        Set(ByVal value As Integer)
            _idRegistryWallet = value
        End Set
    End Property

    Private _RegistryWalletSeq As Integer
    Public Property RegistryWalletSeq() As Integer
        Get
            Return _RegistryWalletSeq
        End Get
        Set(ByVal value As Integer)
            _RegistryWalletSeq = value
        End Set
    End Property


    Private _RegistryWalletDate As Nullable(Of DateTime)
    Public Property RegistryWalletDate() As Nullable(Of DateTime)
        Get
            Return _RegistryWalletDate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _RegistryWalletDate = value
        End Set
    End Property

    Private _RWPapernumber As String
    Public Property RWPapernumber() As String
        Get
            Return _RWPapernumber
        End Get
        Set(ByVal value As String)
            _RWPapernumber = value
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

    Private _RWSubject As String
    Public Property RWSubject() As String
        Get
            Return _RWSubject
        End Get
        Set(ByVal value As String)
            _RWSubject = value
        End Set
    End Property

    Private _RWComments As String
    Public Property RWComments() As String
        Get
            Return _RWComments
        End Get
        Set(ByVal value As String)
            _RWComments = value
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

    Private _RWYear As String
    Public Property RWYear() As String
        Get
            Return _RWYear
        End Get
        Set(ByVal value As String)
            _RWYear = value
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

    Private _RWPaperdate As Nullable(Of DateTime)
    Public Property RWPaperdate() As Nullable(Of DateTime)
        Get
            Return _RWPaperdate
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _RWPaperdate = value
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


End Class
