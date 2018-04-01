Imports DBRegistryDLL
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data

Public Class FrmUserPrivilege

    Dim _Menu As New GridViewComboBoxColumn("id_Menu", "id_Menu")
    Dim _Form As New GridViewMultiComboBoxColumn("id_ParentFormName", "id_ParentFormName")
    Dim dtbindinglstofMenus As DataTable
    Dim dtbindinglstofForms As DataTable

    Private _lstinsertupdateUserPrivilege As List(Of UserPrivilege)
    Public Property lstinsertupdateUserPrivilege() As List(Of UserPrivilege)
        Get
            Return _lstinsertupdateUserPrivilege
        End Get
        Set(ByVal value As List(Of UserPrivilege))
            _lstinsertupdateUserPrivilege = value
        End Set
    End Property

    Private _lstselectedUserPrivilege As List(Of UserPrivilege)
    Public Property lstselectedUserPrivilege() As List(Of UserPrivilege)
        Get
            Return _lstselectedUserPrivilege
        End Get
        Set(ByVal value As List(Of UserPrivilege))
            _lstselectedUserPrivilege = value
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
    Private bluserinfos As BLUserInfo
    Public Property _bluserinfos() As BLUserInfo

        Get
            Return bluserinfos
        End Get
        Set(ByVal value As BLUserInfo)
            bluserinfos = value
        End Set
    End Property

    Private _idUser As Integer
    Public Property idUser() As Integer
        Get
            Return _idUser
        End Get
        Set(ByVal value As Integer)
            _idUser = value
        End Set
    End Property


    Private Sub FrmUserPrivilege_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim lstInsertedData As New List(Of UserPrivilege)
        Dim Insertquery = From p In lstselectedUserPrivilege Where p.Rowaction = 1 Or p.Rowaction = 2 Or p.Rowaction = 3
        lstInsertedData = Insertquery.ToList()
        If lstInsertedData.Count <> 0 Then
            If MessageBox.Show("You will lose changes!!!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                e.Cancel = True

            End If
        End If
    End Sub

    Private Sub FrmUserPrivilege_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grduserprivilege.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grduserprivilege.TableElement.RowHeight = 75

        DBProvider = New DBFunctions
        _bluserinfos = BLUserInfo.getInstance()

        dtbindinglstofMenus = DBProvider.GetDTAllMenus()
        dtbindinglstofForms = DBProvider.GetDTAllParentForm()

        _Form.FieldName = "id_ParentFormName"
        grduserprivilege.Columns.Add(_Form)
        _Form.DataSource = dtbindinglstofForms
        _Form.Width = 80
        _Form.DisplayMember = "ArabicParentFormName"
        _Form.ValueMember = "id_ParentFormName"
        _Form.HeaderText = "Parent Form Name"
        '_papersource.AllowFiltering = True
        '_Menu.WrapText = True
        '_papersource.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        _Form.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        grduserprivilege.Columns().Move(6, 2)

        _Menu.FieldName = "id_Menu"
        grduserprivilege.Columns.Add(_Menu)
        _Menu.DataSource = dtbindinglstofMenus
        _Menu.Width = 80
        _Menu.DisplayMember = "MenuName"
        _Menu.ValueMember = "id_Menu"
        _Menu.HeaderText = "Menu Name"
        '_papersource.AllowFiltering = True
        '_Menu.WrapText = True
        '_papersource.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        _Menu.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        grduserprivilege.Columns().Move(7, 3)
        Loaduserprivilege()

    End Sub
    Private Sub grduserprivilege_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles grduserprivilege.CellEditorInitialized
        If e.Column.FieldName = "id_Menu" Then
            'Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)


            'If mccbEditor IsNot Nothing Thens
            '    Dim descriptor As New FilterDescriptor("MenuName", FilterOperator.Contains, Nothing)
            '    mccbEditor.EditorControl.FilterDescriptors.Add(descriptor)
            'End If
            'mccbEditor.AutoSizeDropDownToBestFit = True

            If Me.grduserprivilege.CurrentRow.Cells("id_ParentFormName").Value IsNot DBNull.Value AndAlso Me.grduserprivilege.CurrentRow.Cells("id_ParentFormName").Value IsNot Nothing Then
                Dim editor As RadDropDownListEditor = DirectCast(Me.grduserprivilege.ActiveEditor, RadDropDownListEditor)
                Dim editorElement As RadDropDownListEditorElement = DirectCast(editor.EditorElement, RadDropDownListEditorElement)
                dtbindinglstofMenus = DBProvider.GetDTMenusbyForm(Integer.Parse(Me.grduserprivilege.CurrentRow.Cells("id_ParentFormName").Value.ToString()))

                editorElement.DataSource = dtbindinglstofMenus


                editorElement.SelectedValue = Nothing
                editorElement.SelectedValue = Me.grduserprivilege.CurrentCell.Value
            End If


        End If
        If e.Column.FieldName = "id_ParentFormName" Then
            Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)


            If mccbEditor IsNot Nothing Then
                Dim descriptor As New FilterDescriptor("ArabicParentFormName", FilterOperator.Contains, Nothing)
                mccbEditor.EditorControl.FilterDescriptors.Add(descriptor)
            End If
            mccbEditor.AutoSizeDropDownToBestFit = True


        End If

     
    End Sub
    Sub Loaduserprivilege()
        lstselectedUserPrivilege = New List(Of UserPrivilege)
        lstselectedUserPrivilege = DBProvider.GetUsersPrivilege(idUser)

        grduserprivilege.DataSource = lstselectedUserPrivilege
    End Sub

    Private Sub grduserprivilege_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles grduserprivilege.CellValueChanged
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
                    'e.Row.Cells("id_User2").Value = _bluserinfos.UserInfo.id_User
                    'End If

                    e.Row.Cells("Rowaction").Value = 2

                End If
            End If
        End If
    End Sub

    Private Sub grduserprivilege_EditorRequired(sender As Object, e As EditorRequiredEventArgs) Handles grduserprivilege.EditorRequired
        If e.EditorType = GetType(RadMultiColumnComboBoxElement) Then

            e.EditorType = GetType(CustomRadMultiColumnComboBoxElement)
        End If

    End Sub

    Private Sub grduserprivilege_KeyUp(sender As Object, e As KeyEventArgs) Handles grduserprivilege.KeyUp
        If e.KeyCode = Keys.Enter Then
            SaveMenuUserPrivileges(False)
        End If
    End Sub

    Private Sub grduserprivilege_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grduserprivilege.UserAddedRow
        e.Row.Cells("Rowaction").Value = 1
      
        e.Row.Cells("id_User").Value = idUser
       
        SaveMenuUserPrivileges(False)
    End Sub

    Function SaveMenuUserPrivileges(ByVal _DeletedRow As Boolean) As Boolean
        Try

            If _DeletedRow = False Then
                lstinsertupdateUserPrivilege = New List(Of UserPrivilege)
                Dim Insertquery = From p In lstselectedUserPrivilege Where p.Rowaction = 1
                lstinsertupdateUserPrivilege = Insertquery.ToList()
                If lstinsertupdateUserPrivilege.Count > 0 Then

                    DBProvider.SaveMenuUserPrivileges(lstinsertupdateUserPrivilege)
                End If

                lstinsertupdateUserPrivilege = New List(Of UserPrivilege)
                Dim Updatequery = From p In lstselectedUserPrivilege Where p.Rowaction = 2
                lstinsertupdateUserPrivilege = Updatequery.ToList()
                If lstinsertupdateUserPrivilege.Count > 0 Then
                    DBProvider.UpdateMenuUserPrivileges(lstinsertupdateUserPrivilege)
                End If
            Else
                lstinsertupdateUserPrivilege = New List(Of UserPrivilege)
                Dim Insertquery = From p In lstselectedUserPrivilege Where p.Rowaction = 3
                lstinsertupdateUserPrivilege = Insertquery.ToList()
                If lstinsertupdateUserPrivilege.Count > 0 Then

                    DBProvider.DeleteUserPrivilegeData(lstinsertupdateUserPrivilege)
                End If

            End If
            Loaduserprivilege()


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If grduserprivilege.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row")
            Exit Sub
        End If
        If MessageBox.Show("are you sure you want to delete?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            If grduserprivilege.SelectedRows.Count <> 0 Then
                For i As Integer = 0 To grduserprivilege.SelectedRows.Count - 1
                    grduserprivilege.SelectedRows(i).Cells("Rowaction").Value = 3
                    If SaveMenuUserPrivileges(True) = False Then
                        grduserprivilege.SelectedRows(i).Cells("Rowaction").Value = 0

                    End If
                Next
                Loaduserprivilege()
            End If

        End If
    End Sub
End Class