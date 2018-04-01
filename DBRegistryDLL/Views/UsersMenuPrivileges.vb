Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Public Class UsersMenuPrivileges
    Private idUsersMenuPrivileges As Integer
    Public Property id_UsersMenuPrivileges() As Integer
        Get
            Return idUsersMenuPrivileges
        End Get
        Set(ByVal value As Integer)
            idUsersMenuPrivileges = value
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

    Private _idMenu As Integer
    Public Property id_Menu() As Integer
        Get
            Return _idMenu
        End Get
        Set(ByVal value As Integer)
            _idMenu = value
        End Set
    End Property

    Private _MenuName As String
    Public Property MenuName() As String
        Get
            Return _MenuName
        End Get
        Set(ByVal value As String)
            _MenuName = value
        End Set
    End Property


End Class
