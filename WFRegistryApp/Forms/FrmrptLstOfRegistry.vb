Imports System.Configuration
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports DBRegistryDLL

Public Class FrmrptLstOfRegistry
    Dim bindinglstofpapersource As List(Of DBRegistryDLL.papersource)
    Dim bindinglstofDeliveredFor As List(Of DeliveredFor)
    Dim bindinglstofUsers As List(Of DBRegistryDLL.papersource)

    Private _DBProvider As DBFunctions
    Public Property DBProvider() As DBFunctions
        Get
            Return _DBProvider
        End Get
        Set(ByVal value As DBFunctions)
            _DBProvider = value
        End Set
    End Property

    Private _Type206 As String
    Public Property Type206() As String
        Get
            Return _Type206
        End Get
        Set(ByVal value As String)
            _Type206 = value
        End Set
    End Property

    Private _FrmName As String
    Public Property FrmName() As String
        Get
            Return _FrmName
        End Get
        Set(ByVal value As String)
            _FrmName = value
        End Set
    End Property

    Private _SelectedUsers As List(Of DBRegistryDLL.papersource)
    Public Property SelectedUsers() As List(Of DBRegistryDLL.papersource)
        Get
            Return _SelectedUsers
        End Get
        Set(ByVal value As List(Of DBRegistryDLL.papersource))
            _SelectedUsers = value
        End Set
    End Property


    Private _SelectedDeliveredFor As List(Of DBRegistryDLL.DeliveredFor)
    Public Property SelectedDeliveredFor() As List(Of DBRegistryDLL.DeliveredFor)
        Get
            Return _SelectedDeliveredFor
        End Get
        Set(ByVal value As List(Of DBRegistryDLL.DeliveredFor))
            _SelectedDeliveredFor = value
        End Set
    End Property


    Private _Selectedpapersource As List(Of DBRegistryDLL.papersource)
    Public Property Selectedpapersource() As List(Of DBRegistryDLL.papersource)
        Get
            Return _Selectedpapersource
        End Get
        Set(ByVal value As List(Of DBRegistryDLL.papersource))
            _Selectedpapersource = value
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

    Private _idUser As Integer

    Public Property id_User() As Integer
        Get
            Return _idUser
        End Get
        Set(ByVal value As Integer)
            _idUser = value
        End Set
    End Property



    Private Sub btngenerate_Click(sender As Object, e As EventArgs) Handles btngenerate.Click
        Try
            Dim reportDocument As New ReportDocument()

            Dim crtableLogoninfos As New TableLogOnInfos()
            Dim crtableLogoninfo As New TableLogOnInfo()
            Dim crConnectionInfo As New ConnectionInfo()
            Dim CrTables As Tables


            If FrmName = "frmregistrywallet" Then
                Dim paramFields As New ParameterFields()

                Dim paramField3 As New ParameterField()
                Dim paramField1 As New ParameterField()
                Dim paramField2 As New ParameterField()


                Dim paramDiscreteValue1 As New ParameterDiscreteValue()
                Dim paramDiscreteValue2 As New ParameterDiscreteValue()
                Dim paramDiscreteValue3 As New ParameterDiscreteValue()






                If chkRegistryDate.Checked = False Then
                    paramField1.Name = "@dateFrom"
                    paramDiscreteValue1.Value = Nothing
                    paramField1.CurrentValues.Add(paramDiscreteValue1)

                    paramField2.Name = "@dateTo"
                    paramDiscreteValue2.Value = Nothing
                    paramField2.CurrentValues.Add(paramDiscreteValue2)
                Else
                    paramField1.Name = "@dateFrom"
                    paramDiscreteValue1.Value = dtFrom.Value
                    paramField1.CurrentValues.Add(paramDiscreteValue1)

                    paramField2.Name = "@dateTo"
                    paramDiscreteValue2.Value = dtin.Value
                    paramField2.CurrentValues.Add(paramDiscreteValue2)
                End If




                paramField3.Name = "@id_PaperSource"
                paramDiscreteValue3.Value = id_PaperSource
                paramField3.CurrentValues.Add(paramDiscreteValue2)

                paramFields.Add(paramField3)
                paramFields.Add(paramField1)
                paramFields.Add(paramField2)


                'Add the paramField to paramFields

                Dim s As New FrmReportViewer

                s.CrystalReportViewer1.ParameterFieldInfo = paramFields

                'Dim reportPath As String = "C:\PROJECTS\Reports\rptListOfRegistry.rpt"
                Dim reportPath As String = "C:\Projects\RegistryProject\WFRegistryApp\Reports\rptListOfRegistryWallet.rpt"
                Dim appPath As String = Application.StartupPath()

                Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConString").ConnectionString
                Dim connstring As String()
                connstring = connectionString.Split(";")


                'Dim reportPath As String = appPath + "\Updates\CarRental\Reports\rptFrameAgreementInfo.rpt"

                reportDocument.Load(reportPath)
                crConnectionInfo.ServerName = "idere"
                crConnectionInfo.DatabaseName = "Sijjel"
                crConnectionInfo.UserID = "sa"
                crConnectionInfo.Password = "naji"
                CrTables = reportDocument.Database.Tables

                For Each ctable As Table In CrTables
                    crtableLogoninfo = ctable.LogOnInfo
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo
                    ctable.ApplyLogOnInfo(crtableLogoninfo)
                Next

                'reportDocument.SetDatabaseLogon("sa", "naji",
                '                                 "NAJI-FBC", "OpticDB");   

                'Load the report by setting the report source
                s.CrystalReportViewer1.ReportSource = reportDocument
                s.CrystalReportViewer1.Refresh()
                s.Show()
            Else

                Dim paramFields As New ParameterFields()

                Dim paramField As New ParameterField()
                Dim paramField1 As New ParameterField()
                Dim paramField2 As New ParameterField()
                Dim paramField3 As New ParameterField()
                Dim paramField4 As New ParameterField()
                Dim paramField5 As New ParameterField()
                Dim paramField6 As New ParameterField()
                Dim paramField7 As New ParameterField()

                Dim paramField8 As New ParameterField()
                Dim paramField9 As New ParameterField()
                Dim paramField10 As New ParameterField()
                Dim paramField11 As New ParameterField()
                Dim paramField12 As New ParameterField()

                Dim paramField13 As New ParameterField()
                Dim paramField14 As New ParameterField()
                Dim paramField15 As New ParameterField()
                Dim paramField16 As New ParameterField()


                Dim paramDiscreteValue As New ParameterDiscreteValue()
                Dim paramDiscreteValue1 As New ParameterDiscreteValue()
                Dim paramDiscreteValue2 As New ParameterDiscreteValue()
                Dim paramDiscreteValue3 As New ParameterDiscreteValue()
                Dim paramDiscreteValue4 As New ParameterDiscreteValue()
                Dim paramDiscreteValue5 As New ParameterDiscreteValue()
                Dim paramDiscreteValue6 As New ParameterDiscreteValue()
                Dim paramDiscreteValue7 As New ParameterDiscreteValue()

                Dim paramDiscreteValue8 As New ParameterDiscreteValue()
                Dim paramDiscreteValue9 As New ParameterDiscreteValue()
                Dim paramDiscreteValue10 As New ParameterDiscreteValue()
                Dim paramDiscreteValue11 As New ParameterDiscreteValue()
                Dim paramDiscreteValue12 As New ParameterDiscreteValue()

                Dim paramDiscreteValue13 As New ParameterDiscreteValue()
                Dim paramDiscreteValue14 As New ParameterDiscreteValue()
                Dim paramDiscreteValue15 As New ParameterDiscreteValue()
                Dim paramDiscreteValue16 As New ParameterDiscreteValue()



                paramField.Name = "@id_Registry"
                paramDiscreteValue.Value = Nothing
                paramField.CurrentValues.Add(paramDiscreteValue)

                If chkRegistryDate.Checked = False Then
                    paramField1.Name = "@dateFrom"
                    paramDiscreteValue1.Value = Nothing
                    paramField1.CurrentValues.Add(paramDiscreteValue1)

                    paramField2.Name = "@dateTo"
                    paramDiscreteValue2.Value = Nothing
                    paramField2.CurrentValues.Add(paramDiscreteValue2)
                Else
                    paramField1.Name = "@dateFrom"
                    paramDiscreteValue1.Value = dtFrom.Value
                    paramField1.CurrentValues.Add(paramDiscreteValue1)

                    paramField2.Name = "@dateTo"
                    paramDiscreteValue2.Value = dtin.Value
                    paramField2.CurrentValues.Add(paramDiscreteValue2)
                End If

                If ckduedate.Checked = False Then
                    paramField3.Name = "@duedateFrom"
                    paramDiscreteValue3.Value = Nothing
                    paramField3.CurrentValues.Add(paramDiscreteValue3)

                    paramField4.Name = "@duedateTo"
                    paramDiscreteValue4.Value = Nothing
                    paramField4.CurrentValues.Add(paramDiscreteValue4)

                Else
                    paramField3.Name = "@duedateFrom"
                    paramDiscreteValue3.Value = duedtfrom.Value
                    paramField3.CurrentValues.Add(paramDiscreteValue3)

                    paramField4.Name = "@duedateTo"
                    paramDiscreteValue4.Value = duedtto.Value
                    paramField4.CurrentValues.Add(paramDiscreteValue4)

                End If


                If chkdelfor.Checked = True Then
                    paramField5.Name = "@id_DeliveredFor"
                    paramDiscreteValue5.Value = id_DeliveredFor
                    paramField5.CurrentValues.Add(paramDiscreteValue5)
                Else
                    paramField5.Name = "@id_DeliveredFor"
                    paramDiscreteValue5.Value = 0
                    paramField5.CurrentValues.Add(paramDiscreteValue5)
                End If

                If chkpapersource.Checked = True Then
                    paramField6.Name = "@id_PaperSource"
                    paramDiscreteValue6.Value = id_PaperSource
                    paramField6.CurrentValues.Add(paramDiscreteValue6)
                Else
                    paramField6.Name = "@id_PaperSource"
                    paramDiscreteValue6.Value = 0
                    paramField6.CurrentValues.Add(paramDiscreteValue6)
                End If


                paramField7.Name = "@Type206"
                paramDiscreteValue7.Value = Type206
                paramField7.CurrentValues.Add(paramDiscreteValue7)

                paramField8.Name = "@submitregister"
                paramDiscreteValue8.Value = txtRegistrySubmitted.Text
                paramField8.CurrentValues.Add(paramDiscreteValue8)

                paramField9.Name = "@subject"
                paramDiscreteValue9.Value = txtsubject.Text
                paramField9.CurrentValues.Add(paramDiscreteValue9)

                paramField10.Name = "@RegistryDescription"
                paramDiscreteValue10.Value = txtregistrydescription.Text
                paramField10.CurrentValues.Add(paramDiscreteValue10)

                If chkisnull.Checked = False Then
                    paramField11.Name = "@isnullduedate"
                    paramDiscreteValue11.Value = Nothing
                    paramField11.CurrentValues.Add(paramDiscreteValue11)


                Else
                    paramField11.Name = "@isnullduedate"
                    paramDiscreteValue11.Value = "yes"
                    paramField11.CurrentValues.Add(paramDiscreteValue11)



                End If

                If chknotnullvalues.Checked = False Then
                    paramField12.Name = "@isnotnullduedate"
                    paramDiscreteValue12.Value = Nothing
                    paramField12.CurrentValues.Add(paramDiscreteValue12)


                Else
                    paramField12.Name = "@isnotnullduedate"
                    paramDiscreteValue12.Value = "yes"
                    paramField12.CurrentValues.Add(paramDiscreteValue12)



                End If



                If chuser.Checked = True Then
                    paramField13.Name = "@id_User"
                    paramDiscreteValue13.Value = id_User
                    paramField13.CurrentValues.Add(paramDiscreteValue13)
                Else
                    paramField13.Name = "@id_User"
                    paramDiscreteValue13.Value = 0
                    paramField13.CurrentValues.Add(paramDiscreteValue13)
                End If


                If chksubmissiondate.Checked = False Then
                    paramField14.Name = "@submisiondateFrom"
                    paramDiscreteValue14.Value = Nothing
                    paramField14.CurrentValues.Add(paramDiscreteValue14)

                    paramField15.Name = "@submisiondateTo"
                    paramDiscreteValue15.Value = Nothing
                    paramField15.CurrentValues.Add(paramDiscreteValue15)

                Else

                    paramField14.Name = "@submisiondateFrom"
                    paramDiscreteValue14.Value = dtfromsubmissiondate.Value
                    paramField14.CurrentValues.Add(paramDiscreteValue14)

                    paramField15.Name = "@submisiondateTo"
                    paramDiscreteValue15.Value = dttosubmissiondate.Value
                    paramField15.CurrentValues.Add(paramDiscreteValue15)




                End If

                If chksoudourisnull.Checked = False Then
                    paramField16.Name = "@isnulldate"
                    paramDiscreteValue16.Value = Nothing
                    paramField16.CurrentValues.Add(paramDiscreteValue16)


                Else
                    paramField16.Name = "@isnulldate"
                    paramDiscreteValue16.Value = "yes"
                    paramField16.CurrentValues.Add(paramDiscreteValue16)



                End If


                paramFields.Add(paramField)
                paramFields.Add(paramField1)
                paramFields.Add(paramField2)
                paramFields.Add(paramField3)
                paramFields.Add(paramField4)
                paramFields.Add(paramField5)
                paramFields.Add(paramField6)
                paramFields.Add(paramField7)

                paramFields.Add(paramField8)
                paramFields.Add(paramField9)
                paramFields.Add(paramField10)
                paramFields.Add(paramField11)
                paramFields.Add(paramField12)


                paramFields.Add(paramField13)
                paramFields.Add(paramField14)
                paramFields.Add(paramField15)
                paramFields.Add(paramField16)

                'Add the paramField to paramFields

                Dim s As New FrmReportViewer

                s.CrystalReportViewer1.ParameterFieldInfo = paramFields

                'Dim reportPath As String = "C:\PROJECTS\Reports\rptListOfRegistry.rpt"
                'Dim reportPath As String = "C:\Projects\RegistryProject\WFRegistryApp\Reports\rptListOfRegistry.rpt"
                Dim reportPath As String = "D:\Projects\RegistryProject\WFRegistryApp\Reports\rptListOfRegistry.rpt"
                Dim appPath As String = Application.StartupPath()
                'Dim reportPath As String = appPath + "\Updates\CarRental\Reports\rptFrameAgreementInfo.rpt"

                reportDocument.Load(reportPath)


                crConnectionInfo.ServerName = "daoudpc"
                crConnectionInfo.DatabaseName = "Sijjel09022018"
                crConnectionInfo.UserID = "sa"
                crConnectionInfo.Password = "najidaoud"
                CrTables = reportDocument.Database.Tables

                'crConnectionInfo.ServerName = "idere"
                'crConnectionInfo.DatabaseName = "Sijjel"
                'crConnectionInfo.UserID = "sa"
                'crConnectionInfo.Password = "naji"
                'CrTables = reportDocument.Database.Tables

                For Each ctable As Table In CrTables
                    crtableLogoninfo = ctable.LogOnInfo
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo
                    ctable.ApplyLogOnInfo(crtableLogoninfo)
                Next

                'reportDocument.SetDatabaseLogon("sa", "naji",
                '                                 "NAJI-FBC", "OpticDB");   

                'Load the report by setting the report source
                s.CrystalReportViewer1.ReportSource = reportDocument
                s.CrystalReportViewer1.Refresh()
                s.Show()
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub FrmrptLstOfRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bindinglstofpapersource = New List(Of DBRegistryDLL.papersource)
        bindinglstofDeliveredFor = New List(Of DBRegistryDLL.DeliveredFor)
        bindinglstofUsers = New List(Of DBRegistryDLL.papersource)

        DBProvider = New DBFunctions

        bindinglstofpapersource = DBProvider.GetAllpapersource
        bindinglstofDeliveredFor = DBProvider.GetAllDeliveredFor()
        bindinglstofUsers = DBProvider.GetAllpapersource


        LoadCmb()

        If FrmName = "frmregistrywallet" Then
            cmbDeliveredFor.Visible = False

            ckduedate.Visible = False
            grbduedate.Visible = False
        End If

        grbduedate.Enabled = False
        grbsubmissiondate.Enabled = False

        'cmbDeliveredFor.AutoCompleteMode = AutoCompleteMode.Append
        'cmbPaperSource.AutoCompleteMode = AutoCompleteMode.Append

    End Sub

    Sub LoadCmb()
        For i As Integer = 0 To bindinglstofpapersource.Count - 1
            cmbPaperSource.Items.Add(bindinglstofpapersource(i).PaperSourceDescription)
        Next

        For i As Integer = 0 To bindinglstofDeliveredFor.Count - 1
            cmbDeliveredFor.Items.Add(bindinglstofDeliveredFor(i).DeliveredForDescription)
        Next

        For i As Integer = 0 To bindinglstofUsers.Count - 1
            cmbuser.Items.Add(bindinglstofUsers(i).PaperSourceDescription)
        Next
    End Sub

    Private Sub cmbDeliveredFor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeliveredFor.SelectedIndexChanged

        Dim query = From p In bindinglstofDeliveredFor
                    Where p.DeliveredForDescription = cmbDeliveredFor.SelectedItem
                    Select p
        SelectedDeliveredFor = query.ToList()

        id_DeliveredFor = SelectedDeliveredFor(0).id_DeliveredFor
    End Sub



    Private Sub chksubmissiondate_CheckedChanged(sender As Object, e As EventArgs) Handles chkRegistryDate.CheckedChanged
        grbsubmissiondate.Enabled = False
        If chkRegistryDate.Checked = True Then
            grbsubmissiondate.Enabled = True
        End If
    End Sub

    Private Sub ckduedate_CheckedChanged(sender As Object, e As EventArgs) Handles ckduedate.CheckedChanged
        grbduedate.Enabled = False
        If ckduedate.Checked = True Then
            grbduedate.Enabled = True
        End If
    End Sub

    Private Sub chkpapersource_CheckedChanged(sender As Object, e As EventArgs) Handles chkpapersource.CheckedChanged
        cmbPaperSource.Enabled = False
        If chkpapersource.Checked = True Then
            cmbPaperSource.Enabled = True

        End If
    End Sub

    Private Sub chkdelfor_CheckedChanged(sender As Object, e As EventArgs) Handles chkdelfor.CheckedChanged
        cmbDeliveredFor.Enabled = False
        If chkdelfor.Checked = True Then
            cmbDeliveredFor.Enabled = True

        End If
    End Sub

    Private Sub cmbPaperSource_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbPaperSource.SelectedIndexChanged
        Dim query = From p In bindinglstofpapersource
                    Where p.PaperSourceDescription = cmbPaperSource.SelectedItem
                    Select p
        Selectedpapersource = query.ToList()

        id_PaperSource = Selectedpapersource(0).id_PaperSource
    End Sub

    Private Sub chknotnullvalues_CheckedChanged(sender As Object, e As EventArgs) Handles chknotnullvalues.CheckedChanged
        'chkisnull.Checked = False
        'If chknotnullvalues.Checked = True Then
        '    chknotnullvalues.Checked = True
        'End If

    End Sub

    Private Sub chkisnull_CheckedChanged(sender As Object, e As EventArgs) Handles chkisnull.CheckedChanged
        'chknotnullvalues.Checked = False
        'If chkisnull.Checked = True Then
        '    chkisnull.Checked = True
        'End If
    End Sub

    Private Sub chknotnullvalues_CheckStateChanged(sender As Object, e As EventArgs) Handles chknotnullvalues.CheckStateChanged

        If chknotnullvalues.Checked = True Then
            chkisnull.Checked = False
            chknotnullvalues.Checked = True
        End If
    End Sub

    Private Sub chkisnull_CheckStateChanged(sender As Object, e As EventArgs) Handles chkisnull.CheckStateChanged

        If chkisnull.Checked = True Then
            chknotnullvalues.Checked = False
            chkisnull.Checked = True
        End If
    End Sub

    Private Sub cmbuser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbuser.SelectedIndexChanged
        Dim query = From p In bindinglstofUsers
                    Where p.PaperSourceDescription = cmbuser.SelectedItem
                    Select p
        SelectedUsers = query.ToList()

        id_User = SelectedUsers(0).id_PaperSource
    End Sub

    Private Sub chuser_CheckedChanged(sender As Object, e As EventArgs) Handles chuser.CheckedChanged
        cmbuser.Enabled = False
        If chuser.Checked = True Then
            cmbuser.Enabled = True

        End If
    End Sub


End Class