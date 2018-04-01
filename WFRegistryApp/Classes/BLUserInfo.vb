Imports System
Imports System.Text
Imports DBRegistryDLL


Public NotInheritable Class BLUserInfo
    Private _DBProvider As DBFunctions
    Public Property DBProvider() As DBFunctions
        Get
            Return _DBProvider
        End Get
        Set(ByVal value As DBFunctions)
            _DBProvider = value
        End Set
    End Property

    Private id_User As Integer
    Public ReadOnly Property _idUser() As Integer
        Get
            Return id_User
        End Get

    End Property

    Private userlogin As String
    Public Property _userlogin() As String
        Get
            Return userlogin
        End Get
        Set(ByVal value As String)
            userlogin = value
        End Set
    End Property

    Private userpassword As String
    Public Property _userpassword() As String
        Get
            Return userpassword
        End Get
        Set(ByVal value As String)
            userpassword = value
        End Set
    End Property

    Private _UserInfo As Users
    Public  Property UserInfo() As Users
        Get
            Return _UserInfo
        End Get
        Set(ByVal value As Users)
            _UserInfo = value
        End Set
    End Property


    Private Shared _instance As New BLUserInfo()

    Private Sub New()
        DBProvider = New DBFunctions

    End Sub

    Public Function checkifUserexist(ByVal userlogin As String, ByVal userpassword As String) As Boolean
        _userlogin = userlogin
        _userpassword = userpassword
        UserInfo = DBProvider.GetUserInfo(_userlogin, _userpassword)

        If UserInfo.id_User = 0 Then
            Return False
        Else
            UserInfo.UserPrivileges = DBProvider.GetUsersPrivilege(UserInfo.id_User)
            Return True

        End If
    End Function

    Public Shared Function getInstance() As BLUserInfo

        If (_instance Is Nothing) Then

            _instance = New BLUserInfo()

        End If
        Return _instance

    End Function
End Class


