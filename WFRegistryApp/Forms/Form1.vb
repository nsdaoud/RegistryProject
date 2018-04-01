Public Class Form1
    Private _Frmlogin As Frmlogin
    Public Property Frmlogin() As Frmlogin
        Get
            Return _Frmlogin
        End Get
        Set(ByVal value As Frmlogin)
            _Frmlogin = value
        End Set
    End Property

    Private bluserinfos As BLUserInfo
    Public Property _bluserinfos() As BLUserInfo

        Get
            Return bluserinfos
        End Get
        Set(ByVal value As BLUserInfo)
            bluserinfos = value
        End Set
    End Property

    Private _frm206Dourous As FrmRegistry
    Public Property frm206Dourous() As FrmRegistry
        Get
            Return _frm206Dourous
        End Get
        Set(ByVal value As FrmRegistry)
            _frm206Dourous = value
        End Set
    End Property

    Private _frm206Idere As FrmRegistry
    Public Property frm206Idere() As FrmRegistry
        Get
            Return _frm206Idere
        End Get
        Set(ByVal value As FrmRegistry)
            _frm206Idere = value
        End Set
    End Property

    Private _frm206telzime As FrmRegistry
    Public Property frm206telzime() As FrmRegistry
        Get
            Return _frm206telzime
        End Get
        Set(ByVal value As FrmRegistry)
            _frm206telzime = value
        End Set
    End Property

    Private _frm206mouchtarayat As FrmRegistry
    Public Property frm206mouchtarayat() As FrmRegistry
        Get
            Return _frm206mouchtarayat
        End Get
        Set(ByVal value As FrmRegistry)
            _frm206mouchtarayat = value
        End Set
    End Property

    Private _frm206siyana As FrmRegistry
    Public Property frm206siyana() As FrmRegistry
        Get
            Return _frm206siyana
        End Get
        Set(ByVal value As FrmRegistry)
            _frm206siyana = value
        End Set
    End Property

    Private _frm206estilam As FrmRegistry
    Public Property frm206estilam() As FrmRegistry
        Get
            Return _frm206estilam
        End Get
        Set(ByVal value As FrmRegistry)
            _frm206estilam = value
        End Set
    End Property

    Private _Frm206mestawda3 As FrmRegistry
    Public Property Frm206mestawda3() As FrmRegistry
        Get
            Return _Frm206mestawda3
        End Get
        Set(ByVal value As FrmRegistry)
            _Frm206mestawda3 = value
        End Set
    End Property

    Private _frm2063adid As FrmRegistry
    Public Property frm2063adid() As FrmRegistry
        Get
            Return _frm2063adid
        End Get
        Set(ByVal value As FrmRegistry)
            _frm2063adid = value
        End Set
    End Property

    Private _frmidere207 As FrmRegistry
    Public Property frmidere207() As FrmRegistry
        Get
            Return _frmidere207
        End Get
        Set(ByVal value As FrmRegistry)
            _frmidere207 = value
        End Set
    End Property

    Private _frm3adid207 As FrmRegistry
    Public Property frm3adid207() As FrmRegistry
        Get
            Return _frm3adid207
        End Get
        Set(ByVal value As FrmRegistry)
            _frm3adid207 = value
        End Set
    End Property



    Private _FrmUserDetails As FrmUserDetails
    Public Property FrmUserDetails() As FrmUserDetails
        Get
            Return _FrmUserDetails
        End Get
        Set(ByVal value As FrmUserDetails)
            _FrmUserDetails = value
        End Set
    End Property


    Private _Frmpapersource As Frmpapersource
    Public Property Frmpapersource() As Frmpapersource
        Get
            Return _Frmpapersource
        End Get
        Set(ByVal value As Frmpapersource)
            _Frmpapersource = value
        End Set
    End Property

    Private _Frm204Dourous As FrmRegistry204
    Public Property Frm204Dourous() As FrmRegistry204
        Get
            Return _Frm204Dourous
        End Get
        Set(ByVal value As FrmRegistry204)
            _Frm204Dourous = value
        End Set
    End Property

    Private _Frm204Idere As FrmRegistry204
    Public Property Frm204Idere() As FrmRegistry204
        Get
            Return _Frm204Idere
        End Get
        Set(ByVal value As FrmRegistry204)
            _Frm204Idere = value
        End Set
    End Property

    Private _Frm204Telzim As FrmRegistry204
    Public Property Frm204Telzim() As FrmRegistry204
        Get
            Return _Frm204Telzim
        End Get
        Set(ByVal value As FrmRegistry204)
            _Frm204Telzim = value
        End Set
    End Property

    Private _Frm204Mouchtarayat As FrmRegistry204
    Public Property Frm204Mouchtarayat() As FrmRegistry204
        Get
            Return _Frm204Mouchtarayat
        End Get
        Set(ByVal value As FrmRegistry204)
            _Frm204Mouchtarayat = value
        End Set
    End Property

    Private _Frm204Siyane As FrmRegistry204
    Public Property Frm204Siyane() As FrmRegistry204
        Get
            Return _Frm204Siyane
        End Get
        Set(ByVal value As FrmRegistry204)
            _Frm204Siyane = value
        End Set
    End Property

    Private _Frm204mestawda3at As FrmRegistry204
    Public Property Frm204mestawda3at() As FrmRegistry204
        Get
            Return _Frm204mestawda3at
        End Get
        Set(ByVal value As FrmRegistry204)
            _Frm204mestawda3at = value
        End Set
    End Property

    Private _Frm204estilem As FrmRegistry204
    Public Property Frm204estilem() As FrmRegistry204
        Get
            Return _Frm204estilem
        End Get
        Set(ByVal value As FrmRegistry204)
            _Frm204estilem = value
        End Set
    End Property


    Private _frmregistrywallet As frmregistrywallet
    Public Property frmregistrywallet() As frmregistrywallet
        Get
            Return _frmregistrywallet
        End Get
        Set(ByVal value As frmregistrywallet)
            _frmregistrywallet = value
        End Set
    End Property


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New FrmRegistry
        frm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm As New Frmpapersource
        frm.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As New frmsenderreceiver
        frm.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm As New FrmUserDetails
        frm.ShowDialog()
    End Sub


    Private Sub tbrmenu_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs) Handles tbrmenu.ButtonClick
        'Select Case tbrmenu.Buttons.IndexOf(e.Button)
        '    Case 0
        '        If _bluserinfos.UserInfo.isAdmin = True Then
        '            'If FrmUserDetails Is Nothing Then
        '            '    FrmUserDetails = New FrmUserDetails
        '            '    FrmUserDetails.MdiParent = Me
        '            '    FrmUserDetails.Show()
        '            '    FrmUserDetails.Focus()
        '            'Else
        '            '    FrmUserDetails.Show()
        '            '    FrmUserDetails.Focus()
        '            'End If
        '            Dim frm As New FrmUserDetails
        '            frm.Text = ""
        '            frm.Show()
        '            frm.Focus()

        '        Else
        '            MessageBox.Show("ممنوع الدخول")
        '            Exit Sub
        '        End If

        '    Case 2
        '        If _bluserinfos.UserInfo.isAdmin = True Then
        '            'If Frmpapersource Is Nothing Then
        '            '    Frmpapersource = New Frmpapersource
        '            '    Frmpapersource.MdiParent = Me
        '            '    Frmpapersource.Show()
        '            '    Frmpapersource.Focus()
        '            'Else
        '            '    Frmpapersource.Show()
        '            '    Frmpapersource.Focus()
        '            'End If

        '            Dim frm As New Frmpapersource
        '            frm.Show()
        '            frm.Focus()

        '        Else
        '            MessageBox.Show("ممنوع الدخول")
        '            Exit Sub
        '        End If
        '    Case 4
        '        'If _bluserinfos.UserInfo.isAdmin = True Or _bluserinfos.UserInfo.isUser = True Then
        '        'If frm206Idere Is Nothing Then
        '        '    frm206Idere = New FrmRegistry
        '        '    frm206Idere.Type206 = "اداري"
        '        '    frm206Idere.Text = "اداري 206"
        '        '    frm206Idere.EngType206 = "206Idere"
        '        '    'frm206Idere.Dock = DockStyle.Top


        '        '    frm206Idere.MdiParent = Me
        '        '    frm206Idere.Show()
        '        'Else
        '        '    frm206Idere.Focus()
        '        '    frm206Idere.Show()
        '        'End If

        '        Dim frm As New FrmRegistry
        '        frm.Type206 = "اداري"
        '        frm.Text = "اداري 206"
        '        frm.EngType206 = "206Idere"
        '        frm.Show()
        '        frm.Focus()




        '        'Else
        '        'MessageBox.Show("ممنوع الدخول")
        '        'Exit Sub
        '        'End If
        '    Case 6
        '        'If Frm204Idere Is Nothing Then
        '        '    Frm204Idere = New FrmRegistry204
        '        '    Frm204Idere.Type204 = "اداري"
        '        '    Frm204Idere.MdiParent = Me
        '        '    Frm204Idere.Form204Disabled = False
        '        '    'frm.EngType204 = "Idere"
        '        '    Frm204Idere.Show()
        '        '    Frm204Idere.Focus()
        '        'Else
        '        '    Frm204Idere.Show()
        '        '    Frm204Idere.Focus()
        '        'End If
        '        Dim frm As New FrmRegistry204
        '        frm.Type204 = "اداري"
        '        frm.Text = "اداري 204"
        '        frm.Show()
        '        frm.Focus()

        '    Case 8
        '        'If _bluserinfos.UserInfo.isAdmin = True Or _bluserinfos.UserInfo.isUser = True Then
        '        'If frm206Dourous Is Nothing Then
        '        '    frm206Dourous = New FrmRegistry
        '        '    frm206Dourous.Type206 = "دروس"
        '        '    frm206Dourous.Text = "206 دروس"
        '        '    frm206Dourous.MdiParent = Me
        '        '    frm206Dourous.EngType206 = "206Dourous"
        '        '    frm206Dourous.Show()
        '        'Else
        '        '    frm206Dourous.Focus()
        '        '    frm206Dourous.Show()
        '        'End If
        '        Dim frm As New FrmRegistry
        '        frm.Type206 = "دروس"
        '        frm.Text = "206 دروس"
        '        frm.EngType206 = "206Dourous"
        '        frm.Show()
        '        frm.Focus()


        '    Case 10
        '        'If Frm204Dourous Is Nothing Then
        '        '    Frm204Dourous = New FrmRegistry204
        '        '    Frm204Dourous.Type204 = "دروس"
        '        '    Frm204Dourous.Form204Disabled = False
        '        '    Frm204Dourous.MdiParent = Me
        '        '    'frm.EngType204 = "Dourous"
        '        '    Frm204Dourous.Show()
        '        '    Frm204Dourous.Focus()

        '        'Else
        '        '    Frm204Dourous.Show()
        '        '    Frm204Dourous.Focus()
        '        'End If

        '        Dim frm As New FrmRegistry204
        '        frm.Type204 = "دروس"
        '        frm.Form204Disabled = False
        '        frm.Text = "204 دروس"
        '        frm.Show()
        '        frm.Focus()

        '    Case 12

        '        'If Frm204Telzim Is Nothing Then
        '        '    Frm204Telzim = New FrmRegistry204
        '        '    Frm204Telzim.Type204 = "تلزيم"
        '        '    Frm204Telzim.Form204Disabled = False
        '        '    Frm204Telzim.MdiParent = Me
        '        '    'frm.EngType204 = "Telzim"
        '        '    Frm204Dourous.Show()
        '        '    Frm204Dourous.Focus()
        '        'Else
        '        '    Frm204Dourous.Show()
        '        '    Frm204Dourous.Focus()

        '        'End If

        '        Dim frm As New FrmRegistry204
        '        frm.Type204 = "تلزيم"
        '        frm.Form204Disabled = False
        '        frm.Text = "204 تلزيم"
        '        frm.Show()
        '        frm.Focus()


        '    Case 14
        '        'If Frm204Mouchtarayat Is Nothing Then
        '        '    Frm204Mouchtarayat = New FrmRegistry204
        '        '    Frm204Mouchtarayat.Type204 = "مشتريات"
        '        '    Frm204Mouchtarayat.Form204Disabled = False
        '        '    Frm204Mouchtarayat.MdiParent = Me
        '        '    'frm.EngType204 = "Mouchtarayat"
        '        '    Frm204Mouchtarayat.Show()
        '        '    Frm204Mouchtarayat.Focus()

        '        'Else
        '        '    Frm204Mouchtarayat.Show()
        '        '    Frm204Mouchtarayat.Focus()
        '        'End If

        '        Dim frm As New FrmRegistry204
        '        frm.Type204 = "مشتريات"
        '        frm.Form204Disabled = False
        '        frm.Text = "204 مشتريات"
        '        frm.Show()
        '        frm.Focus()

        '    Case 16
        '        'If Frm204Siyane Is Nothing Then
        '        '    Frm204Siyane = New FrmRegistry204
        '        '    Frm204Siyane.Type204 = "صيانة"
        '        '    Frm204Siyane.Form204Disabled = False
        '        '    Frm204Siyane.MdiParent = Me
        '        '    'frm.EngType204 = "Siayana"
        '        '    Frm204Siyane.Show()
        '        '    Frm204Siyane.Focus()
        '        'Else
        '        '    Frm204Siyane.Show()
        '        '    Frm204Siyane.Focus()
        '        'End If

        '        Dim frm As New FrmRegistry204
        '        frm.Type204 = "صيانة"
        '        frm.Form204Disabled = False
        '        frm.Text = "204 صيانة"
        '        frm.Show()
        '        frm.Focus()

        '    Case 18
        '        'If Frm204estilem Is Nothing Then
        '        '    Frm204estilem = New FrmRegistry204
        '        '    Frm204estilem.Type204 = "استلام"
        '        '    Frm204estilem.Form204Disabled = False
        '        '    'frm.EngType204 = "Estilam"
        '        '    Frm204estilem.MdiParent = Me
        '        '    Frm204estilem.Show()
        '        '    Frm204estilem.Focus()
        '        'Else
        '        '    Frm204estilem.Show()
        '        '    Frm204estilem.Focus()
        '        'End If

        '        Dim frm As New FrmRegistry204
        '        frm.Type204 = "استلام"
        '        frm.Form204Disabled = False
        '        frm.Text = "204 استلام"
        '        frm.Show()
        '        frm.Focus()

        '    Case 20

        '        'If Frm204mestawda3at Is Nothing Then
        '        '    Frm204mestawda3at = New FrmRegistry204
        '        '    Frm204mestawda3at.Type204 = "مستودعات"
        '        '    Frm204mestawda3at.Form204Disabled = False
        '        '    Frm204mestawda3at.MdiParent = Me
        '        '    'frm.EngType204 = "Mestawda3"
        '        '    Frm204mestawda3at.Show()
        '        '    Frm204mestawda3at.Focus()
        '        'Else
        '        '    Frm204mestawda3at.Show()
        '        '    Frm204mestawda3at.Focus()
        '        'End If

        '        Dim frm As New FrmRegistry204
        '        frm.Type204 = "مستودعات"
        '        frm.Form204Disabled = False
        '        frm.Text = "204 مستودعات"
        '        frm.Show()
        '        frm.Focus()

        '    Case 22

        '        'If frm206telzime Is Nothing Then
        '        '    frm206telzime = New FrmRegistry
        '        '    frm206telzime.Type206 = "تلزيم"
        '        '    frm206telzime.Text = "تلزيم 206"
        '        '    'frm.EngType206 = "Telzim"
        '        '    frm206telzime.MdiParent = Me
        '        '    frm206telzime.Show()
        '        'Else
        '        '    frm206telzime.Focus()
        '        '    frm206telzime.Show()

        '        'End If

        '        Dim frm As New FrmRegistry
        '        frm.Type206 = "تلزيم"
        '        frm.Text = "206 تلزيم"
        '        frm.Show()
        '        frm.Focus()




        '    Case 24

        '        'If frm206mouchtarayat Is Nothing Then
        '        '    frm206mouchtarayat = New FrmRegistry
        '        '    frm206mouchtarayat.Type206 = "مشتريات"
        '        '    frm206mouchtarayat.MdiParent = Me
        '        '    frm206mouchtarayat.Text = "206 مشتريات"
        '        '    'frm.EngType206 = "Mouchtarayat"
        '        '    frm206mouchtarayat.Show()
        '        '    frm206mouchtarayat.Focus()
        '        'Else
        '        '    frm206mouchtarayat.Show()
        '        '    frm206mouchtarayat.Focus()
        '        'End If

        '        Dim frm As New FrmRegistry
        '        frm.Type206 = "مشتريات"
        '        frm.Text = "206 مشتريات"
        '        frm.Show()
        '        frm.Focus()




        '    Case 26


        '        'If frm206siyana Is Nothing Then
        '        '    frm206siyana = New FrmRegistry
        '        '    frm206siyana.Type206 = "صيانة"
        '        '    frm206siyana.Text = "206 صيانة"
        '        '    frm206siyana.MdiParent = Me
        '        '    'frm.EngType206 = "Siayana"
        '        '    frm206siyana.Show()
        '        '    frm206siyana.Focus()
        '        'Else
        '        '    frm206siyana.Show()
        '        '    frm206siyana.Focus()
        '        '    'frm206siyana.MinimizeBox = False 
        '        'End If


        '        Dim frm As New FrmRegistry
        '        frm.Type206 = "صيانة"
        '        frm.Text = "206 صيانة"
        '        frm.Show()
        '        frm.Focus()


        '    Case 28

        '        'If frm206estilam Is Nothing Then
        '        '    frm206estilam = New FrmRegistry
        '        '    frm206estilam.Type206 = "استلام"
        '        '    frm206estilam.Text = "استلام206"
        '        '    'frm206estilam.MdiParent = Me
        '        '    frm206estilam.EngType206 = "Estilam"
        '        '    frm206estilam.Show()
        '        '    frm206estilam.Focus()
        '        'Else
        '        '    frm206estilam.Show()
        '        '    frm206estilam.Focus()
        '        'End If

        '        Dim frm As New FrmRegistry
        '        frm.Type206 = "استلام"
        '        frm.Text = "206 استلام"
        '        frm.EngType206 = "Estilam"
        '        frm.Show()
        '        frm.Focus()


        '    Case 30
        '        'If Frm206mestawda3 Is Nothing Then
        '        '    Frm206mestawda3 = New FrmRegistry
        '        '    Frm206mestawda3.MdiParent = Me
        '        '    Frm206mestawda3.Type206 = "مستودعات"
        '        '    Frm206mestawda3.Text = "مستودعات 206"
        '        '    'frm.EngType206 = "Mestawda3"
        '        '    Frm206mestawda3.Show()
        '        '    Frm206mestawda3.Focus()
        '        'Else
        '        '    Frm206mestawda3.Show()
        '        '    Frm206mestawda3.Focus()
        '        'End If

        '        Dim frm As New FrmRegistry
        '        frm.Type206 = "مستودعات"
        '        frm.Text = "206 مستودعات"
        '        frm.Show()
        '        frm.Focus()

        '    Case 32
        '        'If frmidere207 Is Nothing Then
        '        '    frmidere207 = New FrmRegistry
        '        '    frmidere207.MdiParent = Me
        '        '    frmidere207.Type206 = "207اداري"
        '        '    frmidere207.EngType206 = "207Idere"
        '        '    frmidere207.Text = "207اداري"
        '        '    frmidere207.Show()
        '        '    frmidere207.Focus()
        '        'Else
        '        '    frmidere207.Show()
        '        '    frmidere207.Focus()
        '        'End If

        '        Dim frm As New FrmRegistry
        '        frm.Type206 = "207اداري"
        '        frm.Text = "207 اداري"
        '        frm.Show()
        '        frm.Focus()

        '    Case 34

        '        If frm2063adid Is Nothing Then
        '            frm2063adid = New FrmRegistry
        '            frm2063adid.MdiParent = Me
        '            frm2063adid.Type206 = "206عديد"
        '            frm2063adid.Text = "206عديد"
        '            'frm.EngType206 = "3adid206"
        '            frm2063adid.Show()
        '            frm2063adid.Focus()
        '        Else

        '            frm2063adid.Show()
        '            frm2063adid.Focus()
        '        End If


        '    Case 36
        '        If frmregistrywallet Is Nothing Then
        '            frmregistrywallet = New frmregistrywallet

        '            frmregistrywallet.Show()
        '            frmregistrywallet.Focus()
        '        Else
        '            frmregistrywallet.Show()
        '            frmregistrywallet.Focus()
        '        End If

        '    Case 38

        '        Dim frm As New FrmItemsCategory

        '        frm.ShowDialog()
        '    Case 40

        '        Dim frm As New Frmfilepath

        '        frm.ShowDialog()

        '    Case Else
        '        Dim frm As New FrmRegistry
        '        frm.ShowDialog()
        'End Select

        Select Case tbrmenu.Buttons.IndexOf(e.Button)
            Case 0
                If _bluserinfos.UserInfo.isAdmin = True Then
                    Dim frm As New FrmUserDetails
                    frm.ShowDialog()
                Else
                    MessageBox.Show("ممنوع الدخول")
                    Exit Sub
                End If

            Case 2
                If _bluserinfos.UserInfo.isAdmin = True Then
                    Dim frm As New Frmpapersource
                    frm.ShowDialog()
                Else
                    MessageBox.Show("ممنوع الدخول")
                    Exit Sub
                End If
            Case 4
                'If _bluserinfos.UserInfo.isAdmin = True Or _bluserinfos.UserInfo.isUser = True Then
                Dim frm As New FrmRegistry
                frm.Type206 = "اداري"
                frm.EngType206 = "206Idere"
                frm.ShowDialog()
                'Else
                'MessageBox.Show("ممنوع الدخول")
                'Exit Sub
                'End If
            Case 6

                Dim frm As New FrmRegistry204
                frm.Type204 = "اداري"
                'frm.EngType204 = "Idere"
                frm.ShowDialog()

            Case 8
                'If _bluserinfos.UserInfo.isAdmin = True Or _bluserinfos.UserInfo.isUser = True Then
                Dim frm As New FrmRegistry
                frm.Type206 = "دروس"
                frm.EngType206 = "206Dourous"
                frm.ShowDialog()

            Case 10

                Dim frm As New FrmRegistry204
                frm.Type204 = "دروس"
                'frm.EngType204 = "Dourous"
                frm.ShowDialog()
            Case 12

                Dim frm As New FrmRegistry204
                frm.Type204 = "تلزيم"
                'frm.EngType204 = "Telzim"
                frm.ShowDialog()

            Case 14

                Dim frm As New FrmRegistry204
                frm.Type204 = "مشتريات"
                'frm.EngType204 = "Mouchtarayat"
                frm.ShowDialog()

            Case 16

                Dim frm As New FrmRegistry204
                frm.Type204 = "صيانة"
                'frm.EngType204 = "Siayana"
                frm.ShowDialog()
            Case 18

                Dim frm As New FrmRegistry204
                frm.Type204 = "استلام"
                'frm.EngType204 = "Estilam"
                frm.ShowDialog()
            Case 20

                Dim frm As New FrmRegistry204
                frm.Type204 = "مستودعات"
                'frm.EngType204 = "Mestawda3"
                frm.ShowDialog()


            Case 22

                Dim frm As New FrmRegistry
                frm.Type206 = "تلزيم"
                'frm.EngType206 = "Telzim"
                frm.ShowDialog()

            Case 24

                Dim frm As New FrmRegistry
                frm.Type206 = "مشتريات"
                'frm.EngType206 = "Mouchtarayat"
                frm.ShowDialog()

            Case 26

                Dim frm As New FrmRegistry
                frm.Type206 = "صيانة"
                'frm.EngType206 = "Siayana"
                frm.ShowDialog()
            Case 28

                Dim frm As New FrmRegistry
                frm.Type206 = "استلام"
                frm.EngType206 = "Estilam"
                frm.ShowDialog()
            Case 30

                Dim frm As New FrmRegistry
                frm.Type206 = "مستودعات"
                'frm.EngType206 = "Mestawda3"
                frm.ShowDialog()
            Case 32

                Dim frm As New FrmRegistry
                frm.Type206 = "207اداري"
                frm.EngType206 = "207Idere"
                frm.ShowDialog()
            Case 34

                Dim frm As New FrmRegistry
                frm.Type206 = "206عديد"
                'frm.EngType206 = "3adid206"
                frm.ShowDialog()

            Case 36

                Dim frm As New frmregistrywallet

                frm.ShowDialog()
            Case 38

                Dim frm As New FrmItemsCategory

                frm.ShowDialog()
            Case 40

                Dim frm As New Frmfilepath

                frm.ShowDialog()
            Case 42

                Dim frm As New Frmwaredfax304

                frm.ShowDialog()

            Case Else
                Dim frm As New FrmRegistry
                frm.ShowDialog()
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Frmlogin.Close()

        _bluserinfos = BLUserInfo.getInstance()
        If _bluserinfos.UserInfo.isAdmin = False Then
            For i As Integer = 0 To _bluserinfos.UserInfo.UserPrivileges.Count - 1

                Select Case _bluserinfos.UserInfo.UserPrivileges(i).toolbarname
                    Case "tbrregister"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbrregister").Enabled = True
                        End If


                    Case "tbregister206"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister206").Enabled = True
                        End If


                    Case "tbregister204"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204").Enabled = True
                        End If

                    Case "tbregister204talzim"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204talzim").Enabled = True
                        End If


                    Case "tbregister204dourous"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204dourous").Enabled = True
                        End If


                    Case "tbrusers"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbrusers").Enabled = True
                        End If

                    Case "tbrpapersource"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbrpapersource").Enabled = True
                        End If

                    Case "tbregister204talzim"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204talzim").Enabled = True
                        End If

                    Case "tbregister204Mouchtarayat"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204Mouchtarayat").Enabled = True
                        End If

                    Case "tbregister204siyane"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204siyane").Enabled = True
                        End If

                    Case "tbregister204estilam"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204estilam").Enabled = True
                        End If

                    Case "tbregister204siyane"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204siyane").Enabled = True
                        End If

                    Case "tbregister204estilam"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204estilam").Enabled = True
                        End If

                    Case "tbregister204mestawdaa"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204mestawdaa").Enabled = True
                        End If

                    Case "tbregister204talzim"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister204talzim").Enabled = True
                        End If

                    Case "tbregister206talzim"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister206talzim").Enabled = True
                        End If

                    Case "tbregister206Mouchtarayat"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister206Mouchtarayat").Enabled = True
                        End If

                    Case "tbregister206siyane"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister206siyane").Enabled = True
                        End If

                    Case "tbregister206estilam"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister206estilam").Enabled = True
                        End If

                    Case "tbregister206mestawdaa"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister206mestawdaa").Enabled = True
                        End If

                    Case "tbregister207idere"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister207idere").Enabled = True
                        End If

                    Case "tbregister2063adid"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregister2063adid").Enabled = True
                        End If
                    Case "tbregisterwallet"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name Then
                            tbrmenu.Buttons("tbregisterwallet").Enabled = True
                        End If

                End Select
            Next
        Else
            tbrmenu.Buttons("tbrregister").Enabled = True
            tbrmenu.Buttons("tbregister206").Enabled = True
            tbrmenu.Buttons("tbregister204").Enabled = True
            tbrmenu.Buttons("tbregister204dourous").Enabled = True
            tbrmenu.Buttons("tbrpapersource").Enabled = True
            tbrmenu.Buttons("tbrusers").Enabled = True
            tbrmenu.Buttons("tbregister204talzim").Enabled = True
            tbrmenu.Buttons("tbregister204Mouchtarayat").Enabled = True
            tbrmenu.Buttons("tbregister204siyane").Enabled = True
            tbrmenu.Buttons("tbregister204estilam").Enabled = True
            tbrmenu.Buttons("tbregister204mestawdaa").Enabled = True
            tbrmenu.Buttons("tbregister204talzim").Enabled = True
            tbrmenu.Buttons("tbregister206talzim").Enabled = True
            tbrmenu.Buttons("tbregister206Mouchtarayat").Enabled = True
            tbrmenu.Buttons("tbregister206siyane").Enabled = True
            tbrmenu.Buttons("tbregister206estilam").Enabled = True
            tbrmenu.Buttons("tbregister206mestawdaa").Enabled = True
            tbrmenu.Buttons("tbregister207idere").Enabled = True
            tbrmenu.Buttons("tbregister2063adid").Enabled = True

            tbrmenu.Buttons("tbregisterwallet").Enabled = True
            tbrmenu.Buttons("tbfilepath").Enabled = True




        End If




    End Sub
End Class