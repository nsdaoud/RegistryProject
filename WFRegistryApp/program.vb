Class program
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Dim loginData As String = ""
        Dim l As Frmlogin = New Frmlogin
        l.ShowDialog()
        If l.UsersInfo IsNot Nothing Then
            'code returns form login (if you want you can get some data from there and pass it further:
            'loginData = l.MYPROPERTY
            Application.Run(New Form1())
        End If

    End Sub
End Class
