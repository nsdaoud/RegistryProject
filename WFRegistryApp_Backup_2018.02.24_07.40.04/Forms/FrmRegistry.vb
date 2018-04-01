Imports DBRegistryDLL
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls
Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports Telerik.WinControls.Data




Public Class FrmRegistry

    Dim bindinglstofpapersource As List(Of papersource)
    Dim bindinglstofDeliveredFor As List(Of DeliveredFor)
    Dim dtbindinglstofDeliveredFor As DataTable
    Dim dtbindinglstofpapersource As DataTable

    Dim dtUserTransactions As DataTable
    'Dim bindinglstofRegistryDescription As DataTable
    Dim bindinglstofSubjectSentFor As DataTable

    Dim _papersource As New GridViewMultiComboBoxColumn("id_PaperSource", "id_PaperSource")
    Dim _DeliveredFor As New GridViewMultiComboBoxColumn("id_DeliveredFor", "id_DeliveredFor")
    Dim _UserTransActions As New GridViewMultiComboBoxColumn("id_UserTransactions", "id_UserTransactions")

    Private _registryYear As String
    Public Property registryYear() As String
        Get
            Return _registryYear
        End Get
        Set(ByVal value As String)
            _registryYear = value
        End Set
    End Property
    'Dim col As New CustomColumn("MutiSelect column")
    'Dim _DeliveredFor As New GridViewComboBoxColumn()

    Private _UserPrivilege As Boolean
    Public Property UserPrivilege() As Boolean
        Get
            Return _UserPrivilege
        End Get
        Set(ByVal value As Boolean)
            _UserPrivilege = value
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

    Private _type206 As String
    Public Property Type206() As String
        Get
            Return _type206
        End Get
        Set(ByVal value As String)
            _type206 = value
        End Set
    End Property

    Private _EngType206 As String
    Public Property EngType206() As String
        Get
            Return _EngType206
        End Get
        Set(ByVal value As String)
            _EngType206 = value
        End Set
    End Property


    Private _iInt As Integer
    Public Property iInt() As String
        Get
            Return _iInt
        End Get
        Set(ByVal value As String)
            _iInt = value
        End Set
    End Property

    Private _lstinsertupdateRegistry204 As List(Of Registry204)
    Public Property lstinsertupdateRegistry204() As List(Of Registry204)
        Get
            Return _lstinsertupdateRegistry204
        End Get
        Set(ByVal value As List(Of Registry204))
            _lstinsertupdateRegistry204 = value
        End Set
    End Property

    Private _lstinsertupdateRegistry As List(Of Registry)
    Public Property lstinsertupdateRegistry() As List(Of Registry)
        Get
            Return _lstinsertupdateRegistry
        End Get
        Set(ByVal value As List(Of Registry))
            _lstinsertupdateRegistry = value
        End Set
    End Property

    Private _lstselectedRegistry As List(Of Registry)
    Public Property lstselectedRegistry() As List(Of Registry)
        Get
            Return _lstselectedRegistry
        End Get
        Set(ByVal value As List(Of Registry))
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

    Private _Frmpapersource206 As Frmpapersource
    Public Property Frmpapersource206() As Frmpapersource
        Get
            Return _Frmpapersource206
        End Get
        Set(ByVal value As Frmpapersource)
            _Frmpapersource206 = value
        End Set
    End Property

    Private _frmsenderreceiver As frmsenderreceiver
    Public Property frmsenderreceiver() As frmsenderreceiver
        Get
            Return _frmsenderreceiver
        End Get
        Set(ByVal value As frmsenderreceiver)
            _frmsenderreceiver = value
        End Set
    End Property

    Private Sub FrmRegistry_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim lstInsertedData As New List(Of Registry)
        Dim Insertquery = From p In lstselectedRegistry Where p.Rowaction = 1 Or p.Rowaction = 2 Or p.Rowaction = 3
        lstInsertedData = Insertquery.ToList()
        If lstInsertedData.Count <> 0 Then
            If MessageBox.Show("You will lose changes!!!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                e.Cancel = True

            End If
        End If
    End Sub


    Private Sub FrmRegistry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdregistry.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grdregistry.TableElement.RowHeight = 75
        'grdregistry.EnableCustomFiltering = True

        Dim _ReadOnly As UserPrivilege

        'grdregistry.MasterTemplate.AddNewBoundRowBeforeEdit = True
        'grdregistry.BestFitColumns()
        DBProvider = New DBFunctions
        _bluserinfos = BLUserInfo.getInstance()

        If _bluserinfos.UserInfo.isAdmin = False Then
            For i As Integer = 0 To _bluserinfos.UserInfo.UserPrivileges.Count - 1

                Select Case _bluserinfos.UserInfo.UserPrivileges(i).toolbarname
                    Case "tbrpapersource"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type206 Then
                            tbrregister206.Buttons("tbrpapersource").Enabled = True
                        End If


                    Case "tbrreport"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type206 Then
                            tbrregister206.Buttons("tbrreport").Enabled = True
                        End If

                    Case "tbrexporttoexcel"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type206 Then
                            tbrregister206.Buttons("tbrexporttoexcel").Enabled = True
                        End If

                    Case "tbr204"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type206 Then
                            tbrregister206.Buttons("tbr204").Enabled = True
                        End If

                    Case "tbrdocument"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type206 Then
                            tbrregister206.Buttons("tbrdocument").Enabled = True
                        End If

                    Case "tbrsendto"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type206 Then
                            tbrregister206.Buttons("tbrsendto").Enabled = True
                        End If

                    Case "tbrselect204"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type206 Then
                            tbrregister206.Buttons("tbrselect204").Enabled = True
                        End If
                    Case "tbrdelete206"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type206 Then
                            tbrregister206.Buttons("tbrdelete206").Enabled = True
                        End If
                    Case "tbrclear204"
                        If _bluserinfos.UserInfo.UserPrivileges(i).ParentFormName = Me.Name And _bluserinfos.UserInfo.UserPrivileges(i).RegistryType = Type206 Then
                            tbrregister206.Buttons("tbrclear204").Enabled = True
                        End If


                End Select
            Next

            Dim insertquery = From p In _bluserinfos.UserInfo.UserPrivileges
                              Where p.FormName = Me.Name
                              Select p

            For i As Integer = 0 To insertquery.Count - 1
                '_ReadOnly = insertquery.FirstOrDefault()
                If insertquery(i).UserPrivilegeReadOnly = True And insertquery(i).RegistryType = Type206 Then
                    grdregistry.AllowAddNewRow = False
                    grdregistry.AllowEditRow = False
                    grdregistry.ContextMenuStrip.Enabled = False
                ElseIf insertquery(i).isEditable = True And insertquery(i).canCreate = True And insertquery(i).RegistryType = Type206 Then
                    grdregistry.AllowAddNewRow = True
                    grdregistry.AllowEditRow = True
                ElseIf insertquery(i).isEditable = True And insertquery(i).RegistryType = Type206 Then
                    grdregistry.AllowEditRow = True
                    grdregistry.AllowAddNewRow = False
                    grdregistry.ContextMenuStrip.Enabled = False

                ElseIf insertquery(i).canCreate = True And insertquery(i).RegistryType = Type206 Then
                    grdregistry.AllowAddNewRow = True
                    grdregistry.AllowEditRow = False
                End If
            Next

        Else
            'grdregistry.ContextMenuStrip.Enabled = False

            tbrregister206.Buttons("tbrpapersource").Enabled = True
            tbrregister206.Buttons("tbrreport").Enabled = True
            tbrregister206.Buttons("tbrexporttoexcel").Enabled = True
            tbrregister206.Buttons("tbr204").Enabled = True
            tbrregister206.Buttons("tbrdocument").Enabled = True
            tbrregister206.Buttons("tbrselect204").Enabled = True
            tbrregister206.Buttons("tbrsendto").Enabled = True
            tbrregister206.Buttons("tbrdelete206").Enabled = True
            tbrregister206.Buttons("tbrclear204").Enabled = True
        End If
     

     
       

        'Dim _colpapersource As New GridViewMultiComboBoxColumn("id_PaperSource", "id_PaperSource")

        'Dim _SubjectSentFor As New GridViewMultiComboBoxColumn("SubjectSentFor", "SubjectSentFor")

        bindinglstofpapersource = New List(Of papersource)
        bindinglstofDeliveredFor = New List(Of DeliveredFor)

        dtbindinglstofDeliveredFor = New DataTable("id_DeliveredFor")
        'bindinglstofSubjectSentFor = New DataTable("SubjectSentFor")
        dtbindinglstofpapersource = New DataTable("PaperSourceDescription")
        dtUserTransactions = New DataTable("id_UserTransactions")

        dtbindinglstofpapersource = DBProvider.GetAllDtpapersource()
        'bindinglstofpapersource = DBProvider.GetAllpapersource
        'bindinglstofDeliveredFor = DBProvider.GetAllDeliveredFor()
        dtbindinglstofDeliveredFor = DBProvider.GetDTAllDeliveredFor()
        dtUserTransactions = DBProvider.GetDTAllUserTransActions()
        'bindinglstofRegistryDescription = DBProvider.GetAllRegistryDescription()
        'bindinglstofSubjectSentFor = DBProvider.GetAllRegistrySubjectSentFor()


        _papersource.FieldName = "id_PaperSource"
        grdregistry.Columns.Add(_papersource)
        _papersource.DataSource = dtbindinglstofpapersource
        _papersource.Width = 120
        _papersource.DisplayMember = "PaperSourceDescription"
        _papersource.ValueMember = "id_PaperSource"
        _papersource.HeaderText = "مصدر الاوراق"
        '_papersource.AllowFiltering = True
        _papersource.WrapText = True
        '_papersource.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        _papersource.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        grdregistry.Columns().Move(26, 6)



        _DeliveredFor.FieldName = "id_DeliveredFor"
        grdregistry.Columns.Add(_DeliveredFor)
        _DeliveredFor.DataSource = dtbindinglstofDeliveredFor
        _DeliveredFor.Width = 90
        _DeliveredFor.DisplayMember = "DeliveredForDescription"
        _DeliveredFor.ValueMember = "id_DeliveredFor"
        _DeliveredFor.HeaderText = "المقام المرسل اليه"
        _DeliveredFor.WrapText = True
        '_colDeliveredFor.AutoCompleteMode = AutoCompleteMode.Suggest
        _DeliveredFor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        grdregistry.Columns().Move(27, 13)

        _UserTransActions.FieldName = "id_UserTransactions"
        grdregistry.Columns.Add(_UserTransActions)
        _UserTransActions.DataSource = dtUserTransactions
        _UserTransActions.Width = 90
        _UserTransActions.DisplayMember = "UserTransactions"
        _UserTransActions.ValueMember = "id_UserTransactions"
        _UserTransActions.HeaderText = "معالج المعاملة"
        _UserTransActions.WrapText = True
        '_colDeliveredFor.AutoCompleteMode = AutoCompleteMode.Suggest
        _UserTransActions.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        grdregistry.Columns().Move(28, 14)

        'Dim commandColumn3 As New GridViewCommandColumn()
        'commandColumn3.Name = "CmddDeliveredFor"
        'commandColumn3.UseDefaultText = True
        'commandColumn3.DefaultText = "المقام المرسل اليه"
        'commandColumn3.FieldName = "DeliveredFor"
        'commandColumn3.HeaderText = ""
        'grdregistry.MasterTemplate.Columns.Add(commandColumn3)
        'grdregistry.Columns().Move(23, 14)

        '_SubjectSentFor.FieldName = "SubjectSentFor"
        'grdregistry.Columns.Add(_SubjectSentFor)
        '_SubjectSentFor.DataSource = bindinglstofSubjectSentFor
        '_SubjectSentFor.Width = 150
        '_SubjectSentFor.DisplayMember = "SubjectSentFor"
        '_SubjectSentFor.ValueMember = "SubjectSentFor"
        '_SubjectSentFor.HeaderText = "موضوع الاحالة"
        '_SubjectSentFor.WrapText = True
        ''_SubjectSentFor.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        '_SubjectSentFor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown

        'grdregistry.Columns().Move(23, 14)



        'Dim commandColumn3 As New GridViewCommandColumn()
        'commandColumn3.Name = "Commandsave"
        'commandColumn3.UseDefaultText = True
        'commandColumn3.DefaultText = "حفظ"
        'commandColumn3.FieldName = "save"
        'commandColumn3.HeaderText = ""
        'grdregistry.MasterTemplate.Columns.Add(commandColumn3)
        'grdregistry.Columns().Move(17, 6)

        'Dim commandColumn4 As New GridViewCommandColumn()
        'commandColumn4.Name = "Commanddelete"
        'commandColumn4.UseDefaultText = True
        'commandColumn4.DefaultText = "حذف"
        'commandColumn4.FieldName = "delete"
        'commandColumn4.HeaderText = ""
        'grdregistry.MasterTemplate.Columns.Add(commandColumn4)

        Dim Dtregistryyear As New DataTable
        Dtregistryyear = DBProvider.GetRegistryyears(Type206)
        cmbyear.Items.Clear()
        For icount As Integer = 0 To Dtregistryyear.Rows.Count - 1
            cmbyear.Items.Add(Dtregistryyear.Rows(icount).Item(0))
        Next
        cmbyear.Items.Add("All")
        cmbyear.SelectedIndex = 0
        registryYear = cmbyear.SelectedItem

        'grdregistry.Columns().Move(18, 12)
        LoadRegistry()
    End Sub




    Private Sub grdregistry_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles grdregistry.CellEditorInitialized
        'If e.Column.FieldName = "Registry_Description" Then
        '    Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)


        '    If mccbEditor IsNot Nothing Then
        '        Dim descriptor As New FilterDescriptor("Registry_Description", FilterOperator.Contains, Nothing)
        '        mccbEditor.EditorControl.FilterDescriptors.Add(descriptor)
        '    End If
        '    mccbEditor.AutoSizeDropDownToBestFit = True



        'Else
        If e.Column.FieldName = "id_UserTransactions" Then
            Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)


            If mccbEditor IsNot Nothing Then
                Dim descriptor As New FilterDescriptor("UserTransactions", FilterOperator.Contains, Nothing)
                mccbEditor.EditorControl.FilterDescriptors.Add(descriptor)
            End If
            mccbEditor.AutoSizeDropDownToBestFit = True
        End If

        If e.Column.FieldName = "id_PaperSource" Then
            Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)


            If mccbEditor IsNot Nothing Then
                Dim descriptor As New FilterDescriptor("PaperSourceDescription", FilterOperator.Contains, Nothing)
                mccbEditor.EditorControl.FilterDescriptors.Add(descriptor)
            End If
            mccbEditor.AutoSizeDropDownToBestFit = True
        End If

        If e.Column.FieldName = "id_DeliveredFor" Then
            Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)


            If mccbEditor IsNot Nothing Then
                Dim descriptor As New FilterDescriptor("DeliveredForDescription", FilterOperator.Contains, Nothing)
                mccbEditor.EditorControl.FilterDescriptors.Add(descriptor)
            End If
            mccbEditor.AutoSizeDropDownToBestFit = True
        End If




        'End If

    End Sub




    Private Sub grdregistry_CommandCellClick(sender As Object, e As EventArgs) Handles grdregistry.CommandCellClick
        'LoadRegistry()
        If (grdregistry.CurrentCell.ColumnInfo.Name = "Commandsave") Then
            'If ValidateData() = True Then
            SaveregistryData(False)
            'End If
            'Frmpapersource = New Frmpapersource
            'Frmpapersource.FrmRegistry = Me
            'Frmpapersource.Show()
        ElseIf (grdregistry.CurrentCell.ColumnInfo.Name = "CmddDeliveredFor") Then
            Dim frm As New FrmRegisterpapersource


            frm.FrmRegistry = Me
            frm.Show()
        ElseIf (grdregistry.CurrentCell.ColumnInfo.Name = "Commanddelete") Then
            If grdregistry.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a row")
                Exit Sub
            End If
            If MessageBox.Show("are you sure you want to delete?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Exit Sub
            Else
                If grdregistry.SelectedRows.Count <> 0 Then
                    For i As Integer = 0 To grdregistry.SelectedRows.Count - 1
                        grdregistry.SelectedRows(i).Cells("Rowaction").Value = 3
                        If SaveregistryData(True) = False Then
                            grdregistry.SelectedRows(i).Cells("Rowaction").Value = 0

                        End If
                    Next

                End If
                LoadRegistry()
            End If
            'frmsenderreceiver = New frmsenderreceiver
            'frmsenderreceiver.FrmRegistry = Me
            'frmsenderreceiver.Show()
        End If
    End Sub

    Sub LoadRegistry()
        'grdregistry.ClearSelection()
        'grdregistry.Refresh()
        'grdregistry.DataSource = Nothing



        lstselectedRegistry = New List(Of Registry)
        lstselectedRegistry = DBProvider.GetAllRegistry(Type206, registryYear)

        grdregistry.DataSource = lstselectedRegistry


        'btnpapersource.Visible = False
        'If _bluserinfos.UserInfo.isAdmin = False And _bluserinfos.UserInfo.isUser = False Then


        '    btnsave.Visible = False
        '    btnreport.Visible = False
        '    btnexporttoexcel.Visible = False
        '    btndoc.Visible = False
        '    grdregistry.AllowAddNewRow = False
        '    grdregistry.AllowEditRow = False
        'ElseIf bluserinfos.UserInfo.isAdmin = True Then
        '    btnpapersource.Visible = True
        '    'btndoc.Visible = True
        '    'btn204.Visible = True
        'End If

        'grdregistry.Gr.ScrollToRow(1)
        'Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)
        ''If e.Row.Cells("Registry_Description").Value IsNot Nothing Then
        'bindinglstofRegistryDescription = New DataTable("Registry_Description")
        'bindinglstofRegistryDescription = DBProvider.GetAllRegistryDescription()

        'mccbEditor.DataSource = bindinglstofRegistryDescription
    End Sub
#Region "Grid Functions"
    Private Sub grdregistry_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles grdregistry.CellBeginEdit
        If e.Row IsNot Nothing Then
            If e.Row.Cells("Rowaction").Value IsNot Nothing Then
                If e.ColumnIndex = 1 And e.RowIndex <> -1 And e.Row.Cells("Rowaction").Value <> 1 Then
                    e.Cancel = True
                End If
            End If


        End If
        'If TypeOf grdregistry.CurrentColumn Is GridViewMultiComboBoxColumn Then

        '        Dim editor As RadMultiColumnComboBoxElement = CType(grdregistry.ActiveEditor, RadMultiColumnComboBoxElement)
        '    'editor.EditorControl.MasterTemplate.AutoGenerateColumns = False
        '    'editor.EditorControl.Columns.Add(New GridViewTextBoxColumn("OrderID"))
        '    'editor.EditorControl.Columns.Add(New GridViewTextBoxColumn("Quantity"))
        '        editor.AutoSizeDropDownToBestFit = True

        'End If
    End Sub
    Private Sub grdregistry_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles grdregistry.CellValueChanged
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
    Private Sub grdregistry_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grdregistry.UserAddedRow

        e.Row.Cells("Rowaction").Value = 1
        e.Row.Cells("Registry_Date").Value = DateTime.Now
        If e.Row.Cells("PaperDate").Value Is DBNull.Value Or e.Row.Cells("PaperDate").Value Is Nothing Then
            e.Row.Cells("PaperDate").Value = DateTime.Now
        End If
        e.Row.Cells("id_User").Value = _bluserinfos.UserInfo.id_User
        e.Row.Cells("id_User2").Value = _bluserinfos.UserInfo.id_User
        e.Row.Cells("RegistryType").Value = 206
        e.Row.Cells("type206").Value = Type206
        SaveregistryData(False)

    End Sub

#End Region
#Region "Business Functions"
    Function SaveregistryData(ByVal _DeletedRow As Boolean) As Boolean
        Try

            If _DeletedRow = False Then
                lstinsertupdateRegistry = New List(Of Registry)
                Dim Insertquery = From p In lstselectedRegistry Where p.Rowaction = 1
                lstinsertupdateRegistry = Insertquery.ToList()
                If lstinsertupdateRegistry.Count > 0 Then

                    DBProvider.SaveRegistryData(lstinsertupdateRegistry)
                End If

                lstinsertupdateRegistry = New List(Of Registry)
                Dim Updatequery = From p In lstselectedRegistry Where p.Rowaction = 2
                lstinsertupdateRegistry = Updatequery.ToList()
                If lstinsertupdateRegistry.Count > 0 Then
                    DBProvider.UpdateRegistryData(lstinsertupdateRegistry)
                End If
                LoadRegistry()
            Else

                Dim query = From p In lstselectedRegistry Where p.Rowaction = 3
                lstinsertupdateRegistry = query.ToList()

                If lstinsertupdateRegistry.Count > 0 Then
                    DBProvider.DeleteRegistryData(lstinsertupdateRegistry)
                End If
            End If


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function
#End Region


    Function ValidateData() As Boolean

        lstinsertupdateRegistry = New List(Of Registry)
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

    Private Sub btndelete_Click(sender As Object, e As EventArgs)
        If grdregistry.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row")
            Exit Sub
        End If
        If MessageBox.Show("are you sure you want to delete?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            If grdregistry.SelectedRows.Count <> 0 Then
                For i As Integer = 0 To grdregistry.SelectedRows.Count - 1
                    grdregistry.SelectedRows(i).Cells("Rowaction").Value = 3
                    If SaveregistryData(True) = False Then
                        grdregistry.SelectedRows(i).Cells("Rowaction").Value = 0

                    End If
                Next

            End If
            LoadRegistry()
        End If
    End Sub

    Private Sub btnpapersource_Click(sender As Object, e As EventArgs) Handles btnpapersource.Click
        If Frmpapersource206 Is Nothing Then
            Frmpapersource206 = New Frmpapersource
            Frmpapersource206.FrmRegistry = Me
            Frmpapersource206.Show()
        End If

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Dim frm As New FrmrptLstOfRegistry
        frm.Type206 = Type206
        frm.Show()
    End Sub


    Private Sub grdregistry_KeyDown(sender As Object, e As KeyEventArgs) Handles grdregistry.KeyDown
        If grdregistry.CurrentColumn.FieldName = "DeliveredForDescription" Then
            If e.KeyCode = Keys.F8 Then
                If grdregistry.SelectedRows.Count = 0 Then
                    MessageBox.Show("لا يمكن اختيار المرسل اليه")
                    Exit Sub
                Else
                    Dim frm As New FrmRegisterpapersource
                    Dim i As Integer = 0
                    i = grdregistry.SelectedRows(0).Cells("id_Registry").Value
                    frm.idRegister = i
                    frm.FrmRegistry = Me
                    frm.Show()
                End If

            End If
        End If

        If grdregistry.CurrentRow IsNot Nothing Then

            If e.KeyCode = Keys.Enter Then
                Dim _indexrow As Integer = grdregistry.Rows.IndexOf(grdregistry.CurrentRow)
                SaveregistryData(False)
                grdregistry.CurrentRow = grdregistry.Rows(_indexrow)
            End If
        End If

    End Sub

    Private Sub grdregistry_KeyUp(sender As Object, e As KeyEventArgs) Handles grdregistry.KeyUp
        'If grdregistry.CurrentCell.Name = "DeliveredForDescription" Then
        '    If e.KeyCode = Keys.F8 Then
        '        Dim frm As New FrmRegisterpapersource
        '        frm.FrmRegistry = Me
        '        frm.Show()
        '    End If
        'End If

        If e.KeyCode = Keys.Enter Then
            Dim _indexrow As Integer = grdregistry.Rows.IndexOf(grdregistry.CurrentRow)
            SaveregistryData(False)
            grdregistry.CurrentRow = grdregistry.Rows(_indexrow)
        End If
    End Sub


    Private Sub menu_Click(sender As Object, e As EventArgs) Handles menu.Click
        If createrow.Name = "createrow" Then
            Dim lstofRegistrytocopy As New List(Of Registry)

            Dim query = From p In lstselectedRegistry Where p.id_Registry = grdregistry.SelectedRows(0).Cells("id_Registry").Value
            lstofRegistrytocopy = query.ToList()


            Dim dataRowInfo As GridViewRowInfo = grdregistry.Rows.AddNew()
            dataRowInfo.Cells("Registry_Date").Value = DateTime.Now
            dataRowInfo.Cells("RegistryType").Value = 206
            dataRowInfo.Cells("Papernumber").Value = lstofRegistrytocopy(0).Papernumber
            If lstofRegistrytocopy(0).PaperDate Is Nothing Then
                dataRowInfo.Cells("PaperDate").Value = DBNull.Value
            Else
                dataRowInfo.Cells("PaperDate").Value = lstofRegistrytocopy(0).PaperDate
            End If

            dataRowInfo.Cells("Registry_Submitted").Value = lstofRegistrytocopy(0).Registry_Submitted

            If lstofRegistrytocopy(0).SubmissionDate Is Nothing Then
                dataRowInfo.Cells("SubmissionDate").Value = DBNull.Value
            Else
                dataRowInfo.Cells("SubmissionDate").Value = lstofRegistrytocopy(0).SubmissionDate
            End If
            If lstofRegistrytocopy(0).DeliveredTo_duedate Is Nothing Then
                dataRowInfo.Cells("DeliveredTo_duedate").Value = DBNull.Value
            Else
                dataRowInfo.Cells("DeliveredTo_duedate").Value = lstofRegistrytocopy(0).DeliveredTo_duedate
            End If
            If lstofRegistrytocopy(0).Registry_Description Is Nothing Then
                dataRowInfo.Cells("Registry_Description").Value = DBNull.Value
            Else
                dataRowInfo.Cells("Registry_Description").Value = lstofRegistrytocopy(0).Registry_Description
            End If
            If lstofRegistrytocopy(0).SubjectSentFor Is Nothing Then
                dataRowInfo.Cells("SubjectSentFor").Value = DBNull.Value
            Else
                dataRowInfo.Cells("SubjectSentFor").Value = lstofRegistrytocopy(0).SubjectSentFor
            End If

            dataRowInfo.Cells("id_PaperSource").Value = lstofRegistrytocopy(0).id_PaperSource


            dataRowInfo.Cells("id_DeliveredFor").Value = lstofRegistrytocopy(0).id_DeliveredFor
            dataRowInfo.Cells("id_User").Value = _bluserinfos.UserInfo.id_User
            dataRowInfo.Cells("id_User2").Value = _bluserinfos.UserInfo.id_User
            dataRowInfo.Cells("type206").Value = Type206

            dataRowInfo.Cells("Rowaction").Value = 1
            SaveregistryData(False)

            'grdregistry.Rows.Add(dataRowInfo)
        End If
    End Sub


    Private Sub menu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles menu.Opening

    End Sub


    Private Sub grdregistry_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs)
        'e.Cancel = True
    End Sub



    Private Sub grdregistry_CellFormatting(sender As Object, e As CellFormattingEventArgs) Handles grdregistry.CellFormatting
        e.CellElement.ForeColor = Color.Black
        e.CellElement.GradientStyle = Telerik.WinControls.GradientStyles.Solid
        If e.Column.Name = "Registry_Date" Or e.Column.Name = "Registry_Seq" Or e.Column.Name = "Papernumber" _
            Or e.Column.Name = "id_PaperSource" Or e.Column.Name = "PaperDate" Or e.Column.Name = "Registry_Description" _
             Or e.Column.Name = "Registry_Description" Or e.Column.Name = "RegistryType" Or e.Column.Name = "RegistrydueDate" _
            Or e.Column.Name = "Registry_Submitted" Or e.Column.Name = "RegistrySubmittedyear" Then
            e.CellElement.BackColor = Color.LightBlue
        Else
            e.CellElement.BackColor = Color.LightGreen
        End If

        e.CellElement.Font = New Font(e.CellElement.Font, FontStyle.Bold)
        e.CellElement.DrawFill = True

    End Sub

    Private Sub grdregistry_EditorRequired(sender As Object, e As EditorRequiredEventArgs) Handles grdregistry.EditorRequired
        If e.EditorType = GetType(RadMultiColumnComboBoxElement) Then

            e.EditorType = GetType(CustomRadMultiColumnComboBoxElement)
        End If

       
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        SaveregistryData(False)

        'grdregistry.Rows(10).IsSelected = True

        bindinglstofpapersource = New List(Of papersource)
        bindinglstofDeliveredFor = New List(Of DeliveredFor)
        bindinglstofpapersource = DBProvider.GetAllpapersource()
        bindinglstofDeliveredFor = DBProvider.GetAllDeliveredFor()

        _papersource.DataSource = bindinglstofpapersource
        _DeliveredFor.DataSource = bindinglstofDeliveredFor
    End Sub



    'Private Sub btnexportexcel_Click(sender As Object, e As EventArgs) Handles btnexportexcel.Click
    '    Try
    '        Dim excel As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
    '        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
    '        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing

    '        Try

    '            worksheet = workbook.ActiveSheet

    '            worksheet.Name = "ExportedFromDatGrid"

    '            Dim cellRowIndex As Integer = 1
    '            Dim cellColumnIndex As Integer = 1
    '            grdregistry.ShowFilteringRow = True

    '            'Loop through each row and read value from each column. 
    '            For i As Integer = 0 To grdregistry.Rows.Count - 2
    '                For j As Integer = 0 To grdregistry.Columns.Count - 1
    '                    ' Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
    '                    If grdregistry.Columns(j).HeaderText <> "id_Registry" And grdregistry.Columns(j).HeaderText <> "RegistryType" _
    '                        And grdregistry.Columns(j).HeaderText <> "Rowaction" And grdregistry.Columns(j).HeaderText <> "id_User" _
    '                        And grdregistry.Columns(j).HeaderText <> "id_User2" And grdregistry.Columns(j).FieldName <> "UserLogin2" _
    '                        And grdregistry.Columns(j).FieldName <> "id_DeliveredFor" And grdregistry.Columns(j).FieldName <> "id_PaperSource" Then
    '                        If cellRowIndex = 1 Then
    '                            worksheet.Cells(cellRowIndex, cellColumnIndex) = grdregistry.Columns(j).HeaderText
    '                        Else
    '                            If grdregistry.Rows(i).Cells(j).Value IsNot Nothing And grdregistry.Rows(i).Cells(j).Value IsNot DBNull.Value Then
    '                                worksheet.Cells(cellRowIndex, cellColumnIndex) = grdregistry.Rows(i).Cells(j).Value.ToString()
    '                            Else
    '                                worksheet.Cells(cellRowIndex, cellColumnIndex) = Nothing
    '                            End If

    '                        End If
    '                        cellColumnIndex += 1
    '                    End If


    '                Next
    '                cellColumnIndex = 1
    '                cellRowIndex += 1
    '            Next

    '            'Getting the location and file name of the excel to save from user. 
    '            Dim saveDialog As New SaveFileDialog()
    '            saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
    '            saveDialog.FilterIndex = 2

    '            If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
    '                workbook.SaveAs(saveDialog.FileName)
    '                MessageBox.Show("Export Successful")
    '            End If
    '        Catch ex As System.Exception
    '            MessageBox.Show(ex.Message)
    '        Finally
    '            excel.Quit()
    '            workbook = Nothing
    '            excel = Nothing
    '        End Try

    '        'Dim exporter As ExportToExcelML = New ExportToExcelML(grdregistry)
    '        'exporter.ExportVisualSettings = True


    '        'Dim tempPath As String = Path.GetTempPath()
    '        'tempPath &= "tempgrid.xls"
    '        'exporter.RunExport(tempPath)

    '        'Dim app As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()

    '        'If app Is Nothing Then
    '        '    Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.")
    '        '    Return
    '        'End If

    '        'app.Visible = False
    '        'app.Interactive = False

    '        'Dim wb As Microsoft.Office.Interop.Excel.Workbook = app.Workbooks.Open(tempPath)

    '        'Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    '        'desktopPath &= "\Sijjel" & Format(DateTime.Now.Date, "ddmmyyyy") & ".xlsx"

    '        'wb.SaveAs(desktopPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault)
    '        'wb.Close()
    '        'app.Quit()

    '        'Marshal.ReleaseComObject(wb)
    '        'Marshal.ReleaseComObject(app)
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim f As New Form2
        f.Show()
    End Sub

    Private Sub btnexporttoexcel_Click(sender As Object, e As EventArgs) Handles btnexporttoexcel.Click
        Try
            Dim saveFileDialog1 As New SaveFileDialog
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim strFileName As String = saveFileDialog1.FileName

                'export to Excel
                Dim exporter As ExportToExcelML = New ExportToExcelML(Me.grdregistry)

                Dim fileName As String = strFileName
                exporter.RunExport(fileName)
            End If
            'grdregistry.Columns("id_DeliveredFor").IsVisible = False
            'grdregistry.Columns("DeliveredForDescription").IsVisible = True
            'grdregistry.Refresh()
            'Dim exporter As ExportToExcelML = New ExportToExcelML(grdregistry)
            'exporter.ExportVisualSettings = True
            'exporter.HiddenColumnOption = HiddenOption.DoNotExport

            'Dim tempPath As String = Path.GetTempPath()
            'tempPath &= "tempgrid206" & Date.Now.Second & ".xls"
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
            'desktopPath &= "\Sijjel206" & DateTime.Now.Date.ToString("ddMMyyyy") & ".xlsx"

            'wb.SaveAs(desktopPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault)
            'wb.Close()
            'app.Quit()

            'Marshal.ReleaseComObject(wb)
            'Marshal.ReleaseComObject(app)


            'grdregistry.Columns("id_DeliveredFor").IsVisible = True
            'grdregistry.Columns("DeliveredForDescription").IsVisible = False
            'grdregistry.Refresh()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn204_Click(sender As Object, e As EventArgs) Handles btn204.Click
        If grdregistry.SelectedRows.Count = 0 Then
            MessageBox.Show("Please Select a Row")
            Exit Sub
        End If
        Dim _idRegister206 As Integer = 0
        _idRegister206 = grdregistry.SelectedRows(0).Cells("id_Registry").Value
        lstinsertupdateRegistry = New List(Of Registry)
        lstinsertupdateRegistry204 = New List(Of Registry204)
        Dim Updatequery = From p In lstselectedRegistry Where p.id_Registry = _idRegister206
        lstinsertupdateRegistry = Updatequery.ToList()


        Dim _Registry204 As New Registry204
        If lstinsertupdateRegistry(0).id204Registry <> 0 Then
            _Registry204.id_204Registry = lstinsertupdateRegistry(0).id204Registry
        Else
            _Registry204.id_204Registry = 0
        End If

        _Registry204.Registry_204Date = DateTime.Now
        _Registry204.id_Registry206 = lstinsertupdateRegistry(0).id_Registry
        _Registry204.id_DeliveredFor = lstinsertupdateRegistry(0).id_DeliveredFor
        If lstinsertupdateRegistry(0).SubmissionDate IsNot Nothing Then
            _Registry204.IncomingDate = lstinsertupdateRegistry(0).Registry_Date
        Else
            _Registry204.IncomingDate = Nothing
        End If

        _Registry204.IncomingNumber = lstinsertupdateRegistry(0).Registry_Seq
        If lstinsertupdateRegistry(0).Registry_Description IsNot Nothing Then
            _Registry204.Registry_Description = lstinsertupdateRegistry(0).Registry_Description
        Else
            _Registry204.Registry_Description = Nothing
        End If

        _Registry204.id_User = _bluserinfos.UserInfo.id_User
        _Registry204.RegistryType = 204

        '_Registry204.id_DeliveredFor = lstinsertupdateRegistry(0).id_DeliveredFor
        _Registry204.Type204 = lstinsertupdateRegistry(0).type206
        lstinsertupdateRegistry204.Add(_Registry204)
        If _Registry204.id_204Registry = 0 Then
            DBProvider.Save204RegistryData(lstinsertupdateRegistry204)
        Else
            DBProvider.Update204RegistryData(lstinsertupdateRegistry204)
        End If

        LoadRegistry()

    End Sub

    Private Sub grdregistry_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grdregistry.KeyPress
        If grdregistry.CurrentCell.Name = "DeliveredForDescription" Then
            'If e.KeyChar = Keys.F8 Then
            '    Dim frm As New FrmRegisterpapersource


            '    frm.FrmRegistry = Me
            '    frm.Show()
            'End If
        End If
    End Sub


    Private Sub btndoc_Click(sender As Object, e As EventArgs) Handles btndoc.Click

    End Sub

    Private Sub tbrregister206_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs) Handles tbrregister206.ButtonClick
        Select Case tbrregister206.Buttons.IndexOf(e.Button)
            Case 0
                If Frmpapersource206 Is Nothing Then
                    Frmpapersource206 = New Frmpapersource
                    Frmpapersource206.FrmRegistry = Me
                    Frmpapersource206.Show()
                End If


            Case 2
                Dim frm As New FrmrptLstOfRegistry
                frm.Type206 = Type206
                frm.FrmName = Me.Name
                frm.Show()
            Case 4
                Dim saveFileDialog1 As New SaveFileDialog
                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"

                If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                    Try

                        Dim exportFile As String = "..\..\exportedData.xlsx"
                        Using ms As New System.IO.MemoryStream()
                            Dim exporter As New Telerik.WinControls.Export.GridViewSpreadExport(Me.grdregistry)
                            Dim renderer As New Telerik.WinControls.Export.SpreadExportRenderer()
                            exporter.RunExport(ms, renderer)

                            Using fileStream As New System.IO.FileStream(exportFile, FileMode.Create, FileAccess.Write)
                                ms.WriteTo(fileStream)
                            End Using
                        End Using

                        Dim strFileName As String = saveFileDialog1.FileName

                        'export to Excel
                        Dim exporter As ExportToExcelML = New ExportToExcelML(Me.grdregistry)

                        Dim fileName As String = strFileName
                        exporter.RunExport(fileName)
                    Catch ex As Exception

                    End Try

                End If
            Case 6

                If grdregistry.SelectedRows.Count = 0 Then
                    MessageBox.Show("Please Select a Row")
                    Exit Sub
                End If
                Dim _indexrow As Integer = grdregistry.Rows.IndexOf(grdregistry.CurrentRow)
                Dim _idRegister206 As Integer = 0
                _idRegister206 = grdregistry.SelectedRows(0).Cells("id_Registry").Value
                Dim _idCompleteRegistry As Integer = 0
                _idCompleteRegistry = grdregistry.SelectedRows(0).Cells("id_CompleteRegistry").Value
                lstinsertupdateRegistry = New List(Of Registry)
                lstinsertupdateRegistry204 = New List(Of Registry204)
                Dim Updatequery = From p In lstselectedRegistry Where p.id_Registry = _idRegister206 And p.id_CompleteRegistry = _idCompleteRegistry
                lstinsertupdateRegistry = Updatequery.ToList()


                Dim _Registry204 As New Registry204
                If lstinsertupdateRegistry(0).id204Registry <> 0 Then
                    _Registry204.id_204Registry = lstinsertupdateRegistry(0).id204Registry
                Else
                    _Registry204.id_204Registry = 0
                End If

                _Registry204.Registry_204Date = DateTime.Now
                _Registry204.id_Registry206 = lstinsertupdateRegistry(0).id_Registry
                _Registry204.id_DeliveredFor = lstinsertupdateRegistry(0).id_DeliveredFor
                If lstinsertupdateRegistry(0).Registry_Date IsNot Nothing Then
                    _Registry204.IncomingDate = lstinsertupdateRegistry(0).Registry_Date
                Else
                    _Registry204.IncomingDate = Nothing
                End If

                _Registry204.IncomingNumber = lstinsertupdateRegistry(0).Registry_Seq
                If lstinsertupdateRegistry(0).Registry_Description IsNot Nothing Then
                    _Registry204.Registry_Description = lstinsertupdateRegistry(0).Registry_Description
                Else
                    _Registry204.Registry_Description = Nothing
                End If

                _Registry204.id_User = _bluserinfos.UserInfo.id_User
                _Registry204.RegistryType = 204

                '_Registry204.id_DeliveredFor = lstinsertupdateRegistry(0).id_DeliveredFor
                _Registry204.Type204 = lstinsertupdateRegistry(0).type206
                lstinsertupdateRegistry204.Add(_Registry204)
                If lstinsertupdateRegistry(0).Values204 Is Nothing Then
                    DBProvider.Create204RegistryData(lstinsertupdateRegistry204, lstinsertupdateRegistry(0).id_CompleteRegistry, _bluserinfos.UserInfo.id_User)
                    'DBProvider.Save204RegistryData(lstinsertupdateRegistry204)
                Else
                    DBProvider.Update204RegistryData(lstinsertupdateRegistry204)
                End If

                LoadRegistry()
                grdregistry.CurrentRow = grdregistry.Rows(_indexrow)

            Case 8
                If grdregistry.SelectedRows.Count = 0 Then
                    MessageBox.Show("Please Select a Row")
                    Exit Sub
                End If
                'Dim _indexrow As Integer = grdregistry.Rows.IndexOf(grdregistry.CurrentRow)

                lstinsertupdateRegistry = New List(Of Registry)
                lstinsertupdateRegistry204 = New List(Of Registry204)
                Dim Updatequery = From p In lstselectedRegistry Where p.id_Registry = grdregistry.SelectedRows(0).Cells("id_Registry").Value
                lstinsertupdateRegistry = Updatequery.ToList()
                Dim frm As New FrmDocuments
                frm.id_Register = lstinsertupdateRegistry(0).id_Registry
                frm.SeqNumber = lstinsertupdateRegistry(0).Registry_Seq
                frm.Registry_Year = lstinsertupdateRegistry(0).Registry_Year
                frm.registryType = Trim(lstinsertupdateRegistry(0).RegistryType)
                frm.TypeOfRegisty = EngType206 'lstinsertupdateRegistry(0).type206
                frm.Show()
            Case 10
                If grdregistry.SelectedRows.Count = 0 Then
                    MessageBox.Show("Please Select a Row")
                    Exit Sub
                End If
                Dim _indexrow As Integer = grdregistry.Rows.IndexOf(grdregistry.CurrentRow)

                Dim Updatequery = From p In lstselectedRegistry Where p.id_Registry = grdregistry.SelectedRows(0).Cells("id_Registry").Value And p.id_CompleteRegistry = grdregistry.SelectedRows(0).Cells("id_CompleteRegistry").Value
                lstinsertupdateRegistry = Updatequery.ToList()
                DBProvider.InsertCompleteRegistryData(lstinsertupdateRegistry(0), _bluserinfos.UserInfo.id_User)
                LoadRegistry()
                grdregistry.CurrentRow = grdregistry.Rows(_indexrow)
            Case 12
                If grdregistry.SelectedRows.Count = 0 Then
                    MessageBox.Show("Please Select a Row")
                    Exit Sub
                End If
                Dim _indexrow As Integer = grdregistry.Rows.IndexOf(grdregistry.CurrentRow)

                Dim frm As New FrmRegistry204
                frm.Form204Disabled = True
                frm.idgrdindex = _indexrow
                frm.FrmRegistry204 = Me
                frm.Type204 = Type206
                frm.idCompleteRegistry = grdregistry.SelectedRows(0).Cells("id_CompleteRegistry").Value
                frm.Show()
                'LoadRegistry()
            Case 14
                If grdregistry.SelectedRows.Count = 0 Then
                    MessageBox.Show("Please Select a Row")
                    Exit Sub
                Else
                    If (MessageBox.Show("Are your sure you want to delete 206", "", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel) Then
                        Exit Sub
                    End If

                End If
                Dim _completeregistry As Integer
                Dim _idregistry204 As Integer
                _completeregistry = grdregistry.SelectedRows(0).Cells("id_CompleteRegistry").Value
                If grdregistry.SelectedRows(0).Cells("id_204Registry").Value Is Nothing Then
                    _idregistry204 = 0
                Else
                    _idregistry204 = Integer.Parse(grdregistry.SelectedRows(0).Cells("id_204Registry").Value)
                End If

                DBProvider.DeleteCompleteRegistryData(_completeregistry, _idregistry204)
                LoadRegistry()
            Case 16
                If grdregistry.SelectedRows.Count = 0 Then
                    MessageBox.Show("Please Select a Row")
                    Exit Sub
                Else
                    If (MessageBox.Show("Are your sure you want to clear 204", "", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel) Then
                        Exit Sub
                    End If

                End If
                Dim _indexrow As Integer = grdregistry.Rows.IndexOf(grdregistry.CurrentRow)

                Dim _completeregistry As Integer
                _completeregistry = grdregistry.SelectedRows(0).Cells("id_CompleteRegistry").Value
              

                DBProvider.ClearRegistryData(_completeregistry)
                LoadRegistry()
                grdregistry.CurrentRow = grdregistry.Rows(_indexrow)

        End Select
    End Sub

    Private Sub cmbyear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbyear.SelectedIndexChanged
        registryYear = cmbyear.SelectedItem
        LoadRegistry()

    End Sub


End Class