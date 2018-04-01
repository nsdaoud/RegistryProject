Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class Users
    Private _idUser As Integer
    Public Property id_User() As Integer
        Get
            Return _idUser
        End Get
        Set(ByVal value As Integer)
            _idUser = value
        End Set
    End Property

    Private _UserName As String
    Public Property UserName() As String
        Get
            Return _UserName
        End Get
        Set(ByVal value As String)
            _UserName = value
        End Set
    End Property

    Private _UserLastName As String
    Public Property UserLastName() As String
        Get
            Return _UserLastName
        End Get
        Set(ByVal value As String)
            _UserLastName = value
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

    Private _UserPassword As String
    Public Property UserPassword() As String
        Get
            Return _UserPassword
        End Get
        Set(ByVal value As String)
            _UserPassword = value
        End Set
    End Property

    Private _isAdmin As Boolean
    Public Property isAdmin() As Boolean
        Get
            Return _isAdmin
        End Get
        Set(ByVal value As Boolean)
            _isAdmin = value
        End Set
    End Property

    Private _isVisitor As Boolean
    Public Property isVisitor() As Boolean
        Get
            Return _isVisitor
        End Get
        Set(ByVal value As Boolean)
            _isVisitor = value
        End Set
    End Property

    Private _isUser As Boolean
    Public Property isUser() As Boolean
        Get
            Return _isUser
        End Get
        Set(ByVal value As Boolean)
            _isUser = value
        End Set
    End Property

    Private _UserPrivilege As List(Of UserPrivilege)
    Public Property UserPrivileges() As List(Of UserPrivilege)
        Get
            Return _UserPrivilege
        End Get
        Set(ByVal value As List(Of UserPrivilege))
            _UserPrivilege = value
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
