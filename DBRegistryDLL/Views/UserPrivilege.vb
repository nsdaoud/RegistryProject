Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Public Class UserPrivilege
    Private _idMenuUserPrivileges As Integer
    Public Property id_MenuUserPrivileges() As Integer
        Get
            Return _idMenuUserPrivileges
        End Get
        Set(ByVal value As Integer)
            _idMenuUserPrivileges = value
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

    Private _idForm As Integer
    Public Property id_Form() As Integer
        Get
            Return _idForm
        End Get
        Set(ByVal value As Integer)
            _idForm = value
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

    Private _FormName As String
    Public Property FormName() As String
        Get
            Return _FormName
        End Get
        Set(ByVal value As String)
            _FormName = value
        End Set
    End Property

    Private _idParentForm As Integer
    Public Property id_ParentFormName() As Integer
        Get
            Return _idParentForm
        End Get
        Set(ByVal value As Integer)
            _idParentForm = value
        End Set
    End Property

    Private _ParentFormName As String
    Public Property ParentFormName() As String
        Get
            Return _ParentFormName
        End Get
        Set(ByVal value As String)
            _ParentFormName = value
        End Set
    End Property

    Private _ArabicParentFormName As String
    Public Property ArabicParentFormName() As String
        Get
            Return _ArabicParentFormName
        End Get
        Set(ByVal value As String)
            _ArabicParentFormName = value
        End Set
    End Property

    Private _ArabicFormName As String
    Public Property ArabicFormName() As String
        Get
            Return _ArabicFormName
        End Get
        Set(ByVal value As String)
            _ArabicFormName = value
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


    Private _MenuName As String
    Public Property MenuName() As String
        Get
            Return _MenuName
        End Get
        Set(ByVal value As String)
            _MenuName = value
        End Set
    End Property

    Private _UserPrivilege As String
    Public Property UserPrivilege() As String
        Get
            Return _UserPrivilege
        End Get
        Set(ByVal value As String)
            _UserPrivilege = value
        End Set
    End Property


    Private _UserPrivilegeReadOnly As Boolean
    Public Property UserPrivilegeReadOnly() As Boolean
        Get
            Return _UserPrivilegeReadOnly
        End Get
        Set(ByVal value As Boolean)
            _UserPrivilegeReadOnly = value
        End Set
    End Property

    Private _isReadOnly As Boolean

    Public Property isReadOnly() As Boolean
        Get
            Return _isReadOnly
        End Get
        Set(ByVal value As Boolean)
            _isReadOnly = value
        End Set
    End Property

    Private _isEditable As Boolean

    Public Property isEditable() As Boolean
        Get
            Return _isEditable
        End Get
        Set(ByVal value As Boolean)
            _isEditable = value
        End Set
    End Property

    Private _canCreate As Boolean

    Public Property canCreate() As Boolean
        Get
            Return _canCreate
        End Get
        Set(ByVal value As Boolean)
            _canCreate = value
        End Set
    End Property


    Private _Rowaction As Integer
    Public Property Rowaction() As Integer
        Get
            Return _Rowaction
        End Get
        Set(ByVal value As Integer)
            _Rowaction = value
        End Set
    End Property

    Private _toolbarname As String
    Public Property toolbarname() As String
        Get
            Return _toolbarname
        End Get
        Set(ByVal value As String)
            _toolbarname = value
        End Set
    End Property
End Class
