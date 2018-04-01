Imports DBRegistryDLL
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls
Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports Telerik.WinControls.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Configuration

Public Class FrmRegistry204
    Dim col As New CustomColumn("MutiSelect column")
    Dim dtbindinglstofDeliveredFor As DataTable
    Dim bindinglstofSubjectSentFor As DataTable

    Dim _DeliveredFor As New GridViewMultiComboBoxColumn("id_DeliveredFor", "id_DeliveredFor")

    Private _Form204Disabled As Boolean
    Public Property Form204Disabled As Boolean
        Get
            Return _Form204Disabled
        End Get
        Set(ByVal value As Boolean)
            _Form204Disabled = value
        End Set
    End Property

    Private _idCompleteRegistry As Integer
    Public Property idCompleteRegistry() As Integer
        Get
            Return _idCompleteRegistry
        End Get
        Set(ByVal value As Integer)
            _idCompleteRegistry = value
        End Set
    End Property

    Private _idgrdindex As Integer
    Public Property idgrdindex() As Integer
        Get
            Return _idgrdindex
        End Get
        Set(ByVal value As Integer)
            _idgrdindex = value
        End Set
    End Property



    Private _Type204 As String
    Public Property Type204() As String
        Get
            Return _Type204
        End Get
        Set(ByVal value As String)
            _Type204 = value
        End Set
    End Property

    Private _EngType204 As String
    Public Property EngType204() As String
        Get
            Return _EngType204
        End Get
        Set(ByVal value As String)
            _EngType204 = value
        End Set
    End Property

    Private _FrmRegistry204 As FrmRegistry
    Public Property FrmRegistry204() As FrmRegistry
        Get
            Return _FrmRegistry204
        End Get
        Set(ByVal value As FrmRegistry)
            _FrmRegistry204 = value
        End Set
    End Property


    Private _Frmpapersource204 As Frmpapersource
    Public Property Frmpapersource204() As Frmpapersource
        Get
            Return _Frmpapersource204
        End Get
        Set(ByVal value As Frmpapersource)
            _Frmpapersource204 = value
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

    Private _lstinsertupdateRegistry As List(Of Registry204)
    Public Property lstinsertupdateRegistry() As List(Of Registry204)
        Get
            Return _lstinsertupdateRegistry
        End Get
        Set(ByVal value As List(Of Registry204))
            _lstinsertupdateRegistry = value
        End Set
    End Property

    Private _lstselectedRegistry As List(Of Registry204)
    Public Property lstselectedRegistry() As List(Of Registry204)
        Get
            Return _lstselectedRegistry
        End Get
        Set(ByVal value As List(Of Registry204))
            _lstselectedRegistry = value
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
    Private Sub FrmRegistry204_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdregistry204.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grdregistry204.TableElement.RowHeight = 75
        'grdregistry.EnableCustomFiltering = True

        'grdregistry.MasterTemplate.AddNewBoundRowBeforeEdit = True
        'grdregistry.BestFitColumns()
        DBProvider = New DBFunctions
        _bluserinfos = BLUserInfo.getInstance()


        If Form204Disabled = False Then
            If _bluserinfos.UserInfo.isAdmin = False Then
                Dim _ReadOnly As UserPrivilege
                For i As Integer = 0 To _bluserinfos.UserInfo.UserPrivileges.Count - 1

                    Select Case _bluserinfos.UserInfo.UserPrivileges(i).toolbarname
                        Case "tbrpapersource"
                            If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type204 Then
                                tbr204.Buttons("tbrpapersource").Enabled = True
                            End If


                        Case "tbrreport"
                            If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type204 Then
                                tbr204.Buttons("tbreport").Enabled = True
                            End If

                        Case "tbrexporttoexcel"
                            If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type204 Then
                                tbr204.Buttons("tbrexporttoexcel").Enabled = True
                            End If
                        Case "tbdelete204"
                            If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type204 Then
                                tbr204.Buttons("tbdelete204").Enabled = True
                            End If

                            'Case "tbr204"
                            '    tbr204.Buttons("tbr204").Enabled = True

                    End Select
                Next

                Dim insertquery = From p In _bluserinfos.UserInfo.UserPrivileges
                                  Where p.FormName = Me.Name
                                  Select p
                '_ReadOnly = insertquery.FirstOrDefault()

                For i As Integer = 0 To insertquery.Count - 1
                    If insertquery(i).UserPrivilegeReadOnly = True And insertquery(i).RegistryType = Type204 Then
                        grdregistry204.AllowAddNewRow = False
                        grdregistry204.AllowEditRow = False
                    ElseIf insertquery(i).isEditable = True And insertquery(i).canCreate = True And insertquery(i).RegistryType = Type204 Then
                        grdregistry204.AllowAddNewRow = True
                        grdregistry204.AllowEditRow = True
                    ElseIf insertquery(i).isEditable = True And insertquery(i).RegistryType = Type204 Then
                        grdregistry204.AllowEditRow = True
                        grdregistry204.AllowAddNewRow = False
                    ElseIf insertquery(i).canCreate = True And insertquery(i).RegistryType = Type204 Then
                        grdregistry204.AllowAddNewRow = True
                        grdregistry204.AllowEditRow = False
                    End If
                Next

            Else
                tbr204.Buttons("tbrpapersource").Enabled = True
                tbr204.Buttons("tbreport").Enabled = True
                tbr204.Buttons("tbrexporttoexcel").Enabled = True
                tbr204.Buttons("tbdelete204").Enabled = True
                'tbr204.Buttons("tbr204").Enabled = True
            End If
        Else
            tbr204.Buttons("tbrpapersource").Enabled = False
            tbr204.Buttons("tbreport").Enabled = False
            tbr204.Buttons("tbrexporttoexcel").Enabled = False
            tbr204.Buttons("tbdelete204").Enabled = False

            grdregistry204.AllowAddNewRow = False
            grdregistry204.AllowEditRow = False
        End If


        dtbindinglstofDeliveredFor = New DataTable("id_DeliveredFor")

        Dim _SubjectSentFor As New GridViewMultiComboBoxColumn("SubjectSentFor", "SubjectSentFor")

        dtbindinglstofDeliveredFor = DBProvider.GetDTAllDeliveredFor()
        'bindinglstofSubjectSentFor = DBProvider.GetAllRegistrySubjectSentFor()

        'col.DataSource = dtbindinglstofDeliveredFor
        'col.DisplayMember = "DeliveredForDescription"
        'col.ValueMember = "id_DeliveredFor"
        'col.FieldName = "id_DeliveredFor"
        'col.Width = 100
        'col.HeaderText = "المقام المرسل اليه"
        'col.WrapText = True
        'col.AutoCompleteMode = AutoCompleteMode.Append
        'col.AllowFiltering = True
        'col.ExcelExportType = DisplayFormatType.None

        '_DeliveredFor.FieldName = "id_DeliveredFor"        
        'grdregistry204.Columns.Add(col)

        _DeliveredFor.FieldName = "id_DeliveredFor"
        grdregistry204.Columns.Add(_DeliveredFor)
        _DeliveredFor.DataSource = dtbindinglstofDeliveredFor
        _DeliveredFor.Width = 90
        _DeliveredFor.DisplayMember = "DeliveredForDescription"
        _DeliveredFor.ValueMember = "id_DeliveredFor"
        _DeliveredFor.HeaderText = "المقام المرسل اليه"
        _DeliveredFor.WrapText = True
        _DeliveredFor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        grdregistry204.Columns().Move(15, 8)

        '_DeliveredFor.FieldName = "id_DeliveredFor"
        'grdregistry204.Columns.Add(_DeliveredFor)
        '_DeliveredFor.DataSource = dtbindinglstofDeliveredFor
        '_DeliveredFor.Width = 90
        '_DeliveredFor.DisplayMember = "DeliveredForDescription"
        '_DeliveredFor.ValueMember = "id_DeliveredFor"
        '_DeliveredFor.HeaderText = "المقام المرسل اليه"
        '_DeliveredFor.WrapText = True
        ''_colDeliveredFor.AutoCompleteMode = AutoCompleteMode.Suggest
        '_DeliveredFor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        'grdregistry204.Columns().Move(15, 8)

        'grdregistry204.Columns.Add(_SubjectSentFor)
        '_SubjectSentFor.DataSource = bindinglstofSubjectSentFor
        '_SubjectSentFor.Width = 150
        '_SubjectSentFor.DisplayMember = "SubjectSentFor"
        '_SubjectSentFor.ValueMember = "SubjectSentFor"
        '_SubjectSentFor.HeaderText = "موضوع الاحالة"
        '_SubjectSentFor.WrapText = True
        ''_SubjectSentFor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '_SubjectSentFor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        'grdregistry204.Columns().Move(11, 5)
        LoadRegistry()
    End Sub

    Sub LoadRegistry()
        'grdregistry.ClearSelection()
        'grdregistry.Refresh()
        'grdregistry.DataSource = Nothing

        grdregistry204.ClearSelection()
        grdregistry204.Refresh()
        lstselectedRegistry = New List(Of Registry204)
        lstselectedRegistry = DBProvider.GetAll204Registry(Type204)

        grdregistry204.DataSource = lstselectedRegistry


        'If _bluserinfos.UserInfo.isAdmin = False And _bluserinfos.UserInfo.isUser = False Then

        '    btnpapersource.Visible = False
        '    btnsave.Visible = False
        '    'btnreport.Visible = False
        '    btnexporttoexcel.Visible = False
        '    grdregistry204.AllowAddNewRow = False
        '    grdregistry204.AllowEditRow = False

        'End If

        'grdregistry.Gr.ScrollToRow(1)
        'Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)
        ''If e.Row.Cells("Registry_Description").Value IsNot Nothing Then
        'bindinglstofRegistryDescription = New DataTable("Registry_Description")
        'bindinglstofRegistryDescription = DBProvider.GetAllRegistryDescription()

        'mccbEditor.DataSource = bindinglstofRegistryDescription
    End Sub

    Private Sub grdregistry204_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles grdregistry204.CellBeginEdit
        If e.Row IsNot Nothing Then
            If e.Row.Cells("Rowaction").Value IsNot Nothing Then
                If e.ColumnIndex = 1 And e.RowIndex <> -1 And e.Row.Cells("Rowaction").Value <> 1 Then
                    e.Cancel = True
                End If
            End If
            'If e.Row.Cells("id_Registry206").Value IsNot Nothing Then
            '    If e.Row.Cells("id_Registry206").Value <> 0 Then
            '        e.Cancel = True
            '    End If
            'End If


        End If
    End Sub

    Private Sub grdregistry204_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles grdregistry204.CellEditorInitialized
        If e.Column.FieldName = "id_DeliveredFor" Then
            Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)


            If mccbEditor IsNot Nothing Then
                Dim descriptor As New FilterDescriptor("DeliveredForDescription", FilterOperator.Contains, Nothing)
                mccbEditor.EditorControl.FilterDescriptors.Add(descriptor)
            End If
            mccbEditor.AutoSizeDropDownToBestFit = True
        End If
    End Sub



    Private Sub grdregistry204_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles grdregistry204.CellValueChanged
        If e.Row IsNot Nothing Then
            'If e.ColumnIndex = 2 Then
            '    Dim query = From p In bindinglstofItems Where p.Item_Cd = e.Row.Cells("Item_Cd").Value
            '    e.Row.Cells("Item_UnitOfMeasure").Value = query.FirstOrDefault().Item_UnitOfMeasure
            'End If
            If e.RowIndex <> -1 Then

                If e.Row.Cells("Rowaction").Value <> 3 And e.Row.Cells("Rowaction").Value <> 1 Then
                    '            If e.Column.Name = "Registry_Date" Or e.Column.Name = "Registry_Seq" Or e.Column.Name = "Papernumber" _
                    'Or e.Column.Name = "id_PaperSource" Or e.Column.Name = "PaperDate" Or e.Column.Name = "Registry_Description" _
                    'Or e.Column.Name = "UserLogin" Or e.Column.Name = "Registry_Description" Or e.Column.Name = "Comments" Or e.Column.Name = "RegistryType" Or e.Column.Name = "RegistrydueDate" Or e.Column.Name = "Registry_Submitted" Then
                    'e.Row.Cells("id_User").Value = _bluserinfos.UserInfo.id_User
                    'Else
                    e.Row.Cells("id_User2").Value = _bluserinfos.UserInfo.id_User
                    'End If

                    e.Row.Cells("Rowaction").Value = 2

                End If
            End If



        End If
    End Sub

    Private Sub grdregistry204_EditorRequired(sender As Object, e As EditorRequiredEventArgs) Handles grdregistry204.EditorRequired
        If e.EditorType = GetType(RadMultiColumnComboBoxElement) Then

            e.EditorType = GetType(CustomRadMultiColumnComboBoxElement)
        End If
    End Sub

    Private Sub grdregistry204_KeyDown(sender As Object, e As KeyEventArgs) Handles grdregistry204.KeyDown
        If grdregistry204.CurrentRow IsNot Nothing Then

            If e.KeyCode = Keys.Enter Then
                Dim _indexrow As Integer = grdregistry204.Rows.IndexOf(grdregistry204.CurrentRow)
                SaveregistryData(False)
                grdregistry204.CurrentRow = grdregistry204.Rows(_indexrow)
            End If
        End If
    End Sub

    Private Sub grdregistry204_KeyUp(sender As Object, e As KeyEventArgs) Handles grdregistry204.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim _indexrow As Integer = grdregistry204.Rows.IndexOf(grdregistry204.CurrentRow)
            SaveregistryData(False)
            grdregistry204.CurrentRow = grdregistry204.Rows(_indexrow)
        End If
    End Sub

    Private Sub grdregistry204_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles grdregistry204.MouseDoubleClick
        If FrmRegistry204 IsNot Nothing Then
            If grdregistry204.SelectedRows.Count = 0 Then
                MessageBox.Show("Please Select a Row")
                Exit Sub
            End If
            Dim idRegistry204 As Integer = 0
            idRegistry204 = grdregistry204.SelectedRows(0).Cells("id_204Registry").Value
            DBProvider.Update204RegistryData(idRegistry204, idCompleteRegistry, bluserinfos.UserInfo.id_User)
            FrmRegistry204.LoadRegistry()
            FrmRegistry204.grdregistry.CurrentRow = FrmRegistry204.grdregistry.Rows(idgrdindex)
            Me.Close()
        End If


    End Sub

    Private Sub grdregistry204_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grdregistry204.UserAddedRow

        e.Row.Cells("Rowaction").Value = 1
        e.Row.Cells("Registry_204Date").Value = DateTime.Now
        If e.Row.Cells("IncomingDate").Value Is DBNull.Value Or e.Row.Cells("IncomingDate").Value Is Nothing Then
            e.Row.Cells("IncomingDate").Value = DateTime.Now
        End If
        e.Row.Cells("id_User").Value = _bluserinfos.UserInfo.id_User
        e.Row.Cells("id_User2").Value = _bluserinfos.UserInfo.id_User
        e.Row.Cells("RegistryType").Value = 204
        e.Row.Cells("type204").Value = Type204
        SaveregistryData(False)
    End Sub
#Region "Business Functions"
    Function ValidateData() As Boolean

        lstinsertupdateRegistry = New List(Of Registry204)
        Dim scodeequipments As String = String.Empty

        Dim query = From p In lstselectedRegistry Where p.Rowaction = 1 Or p.Rowaction = 2
        lstinsertupdateRegistry = query.ToList()

        If lstinsertupdateRegistry.Count = 0 Then
            MessageBox.Show("No changes has been detected")
            Return False
        End If

        For i As Integer = 0 To lstinsertupdateRegistry.Count - 1
            'If lstinsertupdateRegistry(i).Papernumber Is Nothing AndAlso lstinsertupdateRegistry(i).Papernumber = "" Then
            '    MessageBox.Show("الرجاء تعبئة مصدر الأوراق", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return False
            'End If
            'If lstinsertupdateUsers(i).UserLastName Is Nothing AndAlso lstinsertupdateUsers(i).UserLastName = "" Then
            '    MessageBox.Show("الرجاء تعبئة العائلة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return False
            'End If

            'If lstinsertupdateUsers(i).UserLogin Is Nothing Then
            '    MessageBox.Show("الرجاء تعبئة المستخدم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return False
            'End If

            'If lstinsertupdateUsers(i).UserPassword Is Nothing AndAlso lstinsertupdateUsers(i).UserPassword = "" Then
            '    MessageBox.Show("الرجاء تعبئة كلمة السر", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return False
            'End If


            'scodeequipments = lstinsertupdateDrivers(i).equipmentco
            'Dim queryduplicate = From p In lstselectedDrivers Where p.equipmentcode = scodeequipments
            'If queryduplicate.Count > 1 Then
            '    MessageBox.Show("Code " + scodeequipments.ToString() + " already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return False
            'End If
        Next
        Return True

    End Function

    Function SaveregistryData(ByVal _DeletedRow As Boolean) As Boolean
        Try

            If _DeletedRow = False Then
                lstinsertupdateRegistry = New List(Of Registry204)
                Dim Insertquery = From p In lstselectedRegistry Where p.Rowaction = 1
                lstinsertupdateRegistry = Insertquery.ToList()
                If lstinsertupdateRegistry.Count > 0 Then

                    DBProvider.Save204RegistryData(lstinsertupdateRegistry)
                End If

                lstinsertupdateRegistry = New List(Of Registry204)
                Dim Updatequery = From p In lstselectedRegistry Where p.Rowaction = 2
                lstinsertupdateRegistry = Updatequery.ToList()
                If lstinsertupdateRegistry.Count > 0 Then
                    DBProvider.Update204RegistryData(lstinsertupdateRegistry)
                End If
                LoadRegistry()
            Else

                'Dim query = From p In lstselectedRegistry Where p.Rowaction = 3
                'lstinsertupdateRegistry = query.ToList()

                'If lstinsertupdateRegistry.Count > 0 Then
                '    DBProvider.Delete204RegistryData(lstinsertupdateRegistry)
                'End If
            End If


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function
#End Region

    Private Sub btnpapersource_Click(sender As Object, e As EventArgs) Handles btnpapersource.Click
        If Frmpapersource204 Is Nothing Then
            Frmpapersource204 = New Frmpapersource
            Frmpapersource204.FrmRegistry204 = Me
            Frmpapersource204.Show()
        End If
    End Sub



    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        SaveregistryData(False)

        dtbindinglstofDeliveredFor = New DataTable
        dtbindinglstofDeliveredFor = DBProvider.GetDTAllDeliveredFor()

        col.DataSource = dtbindinglstofDeliveredFor
    End Sub

    Private Sub btnexporttoexcel_Click(sender As Object, e As EventArgs) Handles btnexporttoexcel.Click
        Try
            Dim saveFileDialog1 As New SaveFileDialog
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim strFileName As String = saveFileDialog1.FileName

                'export to Excel
                Dim exporter As ExportToExcelML = New ExportToExcelML(Me.grdregistry204)

                Dim fileName As String = strFileName
                exporter.RunExport(fileName)
            End If
            'grdregistry204.Columns("id_DeliveredFor").IsVisible = False
            'grdregistry204.Columns("DeliveredForDescription").IsVisible = True
            'grdregistry204.Refresh()
            'Dim exporter As ExportToExcelML = New ExportToExcelML(grdregistry204)
            'exporter.ExportVisualSettings = True
            'exporter.HiddenColumnOption = HiddenOption.DoNotExport

            'Dim tempPath As String = Path.GetTempPath()
            'tempPath &= "tempgrid204" & Date.Now.Second & ".xls"
            'exporter.RunExport(tempPath)

            'Dim app As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()

            'If app Is Nothing Then
            '    Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.")
            '    Return
            'End If

            'app.Visible = False
            'app.Interactive = False

            'Dim wb As Microsoft.Office.Interop.Excel.Workbook = app.Workbooks.Open(tempPath)

            'Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            'Dim s As String = DateTime.Now.Date.ToString("ddMMyyyy")
            'desktopPath &= "\Sijjel204" & DateTime.Now.Date.ToString("ddMMyyyy") & ".xlsx"

            'wb.SaveAs(desktopPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault)
            'wb.Close()
            'app.Quit()

            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(app)


            'grdregistry204.Columns("id_DeliveredFor").IsVisible = True
            'grdregistry204.Columns("DeliveredForDescription").IsVisible = False
            'grdregistry204.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Dim reportDocument As New ReportDocument()

        Dim paramFields As New ParameterFields()

        Dim paramField As New ParameterField()

        Dim paramDiscreteValue As New ParameterDiscreteValue()


        paramField.Name = "@Type204"
        paramDiscreteValue.Value = Type204
        paramField.CurrentValues.Add(paramDiscreteValue)



        paramFields.Add(paramField)


        Dim s As New FrmReportViewer

        s.CrystalReportViewer1.ParameterFieldInfo = paramFields

        Dim reportPath As String = "D:\RegistryProject\WFRegistryApp\Reports\rptListOfRegistry204.rpt"
        Dim appPath As String = Application.StartupPath()

        reportDocument.Load(reportPath)


        s.CrystalReportViewer1.ReportSource = reportDocument
        s.CrystalReportViewer1.Refresh()
        s.Show()
    End Sub

    Private Sub tbr204_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs) Handles tbr204.ButtonClick
        Select Case tbr204.Buttons.IndexOf(e.Button)
            Case 0
                If Frmpapersource204 Is Nothing Then
                    Frmpapersource204 = New Frmpapersource
                    Frmpapersource204.FrmRegistry204 = Me
                    Frmpapersource204.Show()
                End If

            Case 2
                Dim saveFileDialog1 As New SaveFileDialog
                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"

                If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                    Dim strFileName As String = saveFileDialog1.FileName

                    'export to Excel
                    Dim exporter As ExportToExcelML = New ExportToExcelML(Me.grdregistry204)

                    Dim fileName As String = strFileName
                    exporter.RunExport(fileName)
                End If
            Case 4
                Dim reportDocument As New ReportDocument()

                Dim paramFields As New ParameterFields()

                Dim paramField As New ParameterField()

                Dim paramDiscreteValue As New ParameterDiscreteValue()

                Dim crtableLogoninfos As New TableLogOnInfos()
                Dim crtableLogoninfo As New TableLogOnInfo()
                Dim crConnectionInfo As New ConnectionInfo()
                Dim CrTables As Tables


                paramField.Name = "@Type204"
                paramDiscreteValue.Value = Type204
                paramField.CurrentValues.Add(paramDiscreteValue)



                paramFields.Add(paramField)


                Dim s As New FrmReportViewer

                s.CrystalReportViewer1.ParameterFieldInfo = paramFields

                Dim connectionString As String = ConfigurationManager.ConnectionStrings("ConString").ConnectionString
                Dim connstring As String()
                connstring = connectionString.Split(";")




                'Dim reportPath As String = "C:\Projects\RegistryProject\WFRegistryApp\Reports\rptListOfRegistry204.rpt"
                Dim reportPath As String = "D:\RegistryProject\WFRegistryApp\Reports\rptListOfRegistry204.rpt"
                Dim appPath As String = Application.StartupPath()

                reportDocument.Load(reportPath)

                crConnectionInfo.ServerName = "daoudpc"
                crConnectionInfo.DatabaseName = "Sijjel09022018"
                crConnectionInfo.UserID = "sa"
                crConnectionInfo.Password = "najidaoud"
                CrTables = reportDocument.Database.Tables

                For Each ctable As Table In CrTables
                    crtableLogoninfo = ctable.LogOnInfo
                    crtableLogoninfo.ConnectionInfo = crConnectionInfo
                    ctable.ApplyLogOnInfo(crtableLogoninfo)
                Next


                s.CrystalReportViewer1.ReportSource = reportDocument
                s.CrystalReportViewer1.Refresh()
                s.Show()
            Case 6
                If grdregistry204.SelectedRows.Count = 0 Then
                    MessageBox.Show("Please Select a Row")
                    Exit Sub
                Else
                    If (MessageBox.Show("Are your sure you want to delete 204", "", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel) Then
                        Exit Sub
                    End If

                End If
                Dim _id204Registry As Integer
                _id204Registry = grdregistry204.SelectedRows(0).Cells("id_204Registry").Value
                DBProvider.Delete204RegistryData(_id204Registry)
                LoadRegistry()


        End Select
    End Sub


End Class