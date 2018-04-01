Imports DBRegistryDLL
Imports Telerik.WinControls.UI
Public Class Frmlogin
    Private _UserInfo As BLUserInfo
    Public Property UserInfo() As BLUserInfo
        Get
            Return _UserInfo
        End Get
        Set(ByVal value As BLUserInfo)
            _UserInfo = value
        End Set
    End Property

    Private _UsersInfo As Users
    Public Property UsersInfo() As Users
        Get
            Return _UsersInfo
        End Get
        Set(ByVal value As Users)
            _UsersInfo = value
        End Set
    End Property

   

    Private _DBProvider As DBFunctions
    Public Property DBProvider() As DBFunctions
        Get
            Return _DBProvider
        End Get
        Set(ByVal value As DBFunctions)
            _DBProvider = value
        End Set
    End Property
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        DBProvider = New DBFunctions
        'UserInfo = BLUserInfo.getInstance(txtuserlogin.Text, txtpassword.Text)
        UsersInfo = New Users

        If txtuserlogin.Text = "" Then
            MessageBox.Show(" يرجى ادخال المستخدم")
            Exit Sub
        End If
        If txtpassword.Text = "" Then
            MessageBox.Show(" يرجى ادخال كلمة السر")
            Exit Sub
        End If
        UserInfo = BLUserInfo.getInstance()

        'UserInfo = DBProvider.GetUserInfo(txtuserlogin.Text, txtpassword.Text)
        If UserInfo.checkifUserexist(txtuserlogin.Text, txtpassword.Text) = False Then
            MessageBox.Show(" المستخدم غير موجود")
            Exit Sub
        Else
            Me.Close()
            'Dim frm As New Form1

            'frm.ShowDialog()
            'frm.Frmlogin = Me
        End If
    End Sub

    Private Sub btnchange_Click(sender As Object, e As EventArgs) Handles btnchange.Click
        DBProvider = New DBFunctions
        UsersInfo = New Users
        If txtlogin.Text = "" Then
            MessageBox.Show(" يرجى ادخال المستخدم")
            Exit Sub
        End If
        If txtoldpassword.Text = "" Then
            MessageBox.Show("  يرجى ادخال كلمة السر القديمة")
            Exit Sub
        End If
        If txtnewpassword.Text = "" Then
            MessageBox.Show("  يرجى ادخال كلمة السر الجديدة")
            Exit Sub
        End If
        UserInfo = BLUserInfo.getInstance()
        'UsersInfo = DBProvider.GetUserInfo(txtlogin.Text, txtoldpassword.Text)
        If UserInfo.checkifUserexist(txtlogin.Text, txtoldpassword.Text) = False Then
            MessageBox.Show(" المستخدم غير موجود")
            Exit Sub
        Else

            UserInfo.UserInfo.UserPassword = txtnewpassword.Text
            DBProvider.UpdateUserPasswordData(UserInfo.UserInfo)
            txtlogin.Text = ""
            txtnewpassword.Text = ""
            txtoldpassword.Text = ""
        End If
    End Sub
End Class