Imports DBRegistryDLL
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls
Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports Telerik.WinControls.Data

Public Class frmregistrywallet

    Dim bindinglstofpapersource As List(Of papersource)
    Dim dtbindinglstofpapersource As DataTable

    Dim _papersource As New GridViewMultiComboBoxColumn("id_PaperSource", "id_PaperSource")

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

    Private _lstinsertupdateRegistryWallet As List(Of registryWallet)
    Public Property lstinsertupdateRegistryWallet() As List(Of registryWallet)
        Get
            Return _lstinsertupdateRegistryWallet
        End Get
        Set(ByVal value As List(Of registryWallet))
            _lstinsertupdateRegistryWallet = value
        End Set
    End Property

    Private _lstselectedRegistryWallet As List(Of registryWallet)
    Public Property lstselectedRegistryWallet() As List(Of registryWallet)
        Get
            Return _lstselectedRegistryWallet
        End Get
        Set(ByVal value As List(Of registryWallet))
            _lstselectedRegistryWallet = value
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

    Private Sub frmregistrywallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdregistrywallet.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grdregistrywallet.TableElement.RowHeight = 75
        'grdregistry.EnableCustomFiltering = True

        Dim _ReadOnly As UserPrivilege

        'grdregistry.MasterTemplate.AddNewBoundRowBeforeEdit = True
        'grdregistry.BestFitColumns()
        DBProvider = New DBFunctions
        _bluserinfos = BLUserInfo.getInstance()

        If _bluserinfos.UserInfo.isAdmin = False Then
            Dim insertquery = From p In _bluserinfos.UserInfo.UserPrivileges
                         Where p.FormName = Me.Name
                         Select p
            '_ReadOnly = insertquery.FirstOrDefault()

            For i As Integer = 0 To insertquery.Count - 1
                If insertquery(i).UserPrivilegeReadOnly = True Then
                    grdregistrywallet.AllowAddNewRow = False
                    grdregistrywallet.AllowEditRow = False
                ElseIf insertquery(i).isEditable = True And insertquery(i).canCreate = True Then
                    grdregistrywallet.AllowAddNewRow = True
                    grdregistrywallet.AllowEditRow = True
                ElseIf insertquery(i).isEditable = True Then
                    grdregistrywallet.AllowEditRow = True
                    grdregistrywallet.AllowAddNewRow = False
                ElseIf insertquery(i).canCreate = True Then
                    grdregistrywallet.AllowAddNewRow = True
                    grdregistrywallet.AllowEditRow = False
                End If
            Next


        End If


        bindinglstofpapersource = New List(Of papersource)
        dtbindinglstofpapersource = DBProvider.GetAllDtpapersource()

        _papersource.FieldName = "id_PaperSource"
        grdregistrywallet.Columns.Add(_papersource)
        _papersource.DataSource = dtbindinglstofpapersource
        _papersource.Width = 50
        _papersource.DisplayMember = "PaperSourceDescription"
        _papersource.ValueMember = "id_PaperSource"
        _papersource.HeaderText = "مصدر الاوراق"
        _papersource.WrapText = True
        _papersource.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        grdregistrywallet.Columns().Move(9, 4)
        LoadRegistryWallet()
    End Sub

    Sub LoadRegistryWallet()
        lstselectedRegistryWallet = New List(Of registryWallet)
        lstselectedRegistryWallet = DBProvider.GetAllRegistryWallet()

        grdregistrywallet.DataSource = lstselectedRegistryWallet
    End Sub


#Region "Grid Functions"
    Private Sub grdregistrywallet_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles grdregistrywallet.CellBeginEdit
        If e.Row IsNot Nothing Then
            If e.Row.Cells("Rowaction").Value IsNot Nothing Then
                If e.ColumnIndex = 1 And e.RowIndex <> -1 And e.Row.Cells("Rowaction").Value <> 1 Then
                    e.Cancel = True
                End If
            End If


        End If

    End Sub
    Private Sub grdregistrywallet_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grdregistrywallet.UserAddedRow

        e.Row.Cells("Rowaction").Value = 1
        e.Row.Cells("RegistryWalletDate").Value = DateTime.Now
        e.Row.Cells("id_User").Value = _bluserinfos.UserInfo.id_User
        SaveregistryWalletData(False)

    End Sub
    Private Sub grdregistrywallet_KeyDown(sender As Object, e As KeyEventArgs) Handles grdregistrywallet.KeyDown


        If grdregistrywallet.CurrentRow IsNot Nothing Then

            If e.KeyCode = Keys.Enter Then
                SaveregistryWalletData(False)
            End If
        End If

    End Sub



    Private Sub grdregistrywallet_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles grdregistrywallet.CellEditorInitialized



        If e.Column.FieldName = "id_PaperSource" Then
            Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)


            If mccbEditor IsNot Nothing Then
                Dim descriptor As New FilterDescriptor("PaperSourceDescription", FilterOperator.Contains, Nothing)
                mccbEditor.EditorControl.FilterDescriptors.Add(descriptor)
            End If
            mccbEditor.AutoSizeDropDownToBestFit = True
        End If



        'End If

    End Sub

    Private Sub grdregistrywallet_EditorRequired(sender As Object, e As EditorRequiredEventArgs) Handles grdregistrywallet.EditorRequired
        If e.EditorType = GetType(RadMultiColumnComboBoxElement) Then

            e.EditorType = GetType(CustomRadMultiColumnComboBoxElement)
        End If

    End Sub

    Private Sub grdregistrywallet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles grdregistrywallet.KeyPress

    End Sub

    Private Sub grdregistrywallet_KeyUp(sender As Object, e As KeyEventArgs) Handles grdregistrywallet.KeyUp
        If e.KeyCode = Keys.Enter Then
            SaveregistryWalletData(False)
        End If
    End Sub
#End Region

#Region "Business Functions"
    Function SaveregistryWalletData(ByVal _DeletedRow As Boolean) As Boolean
        Try

            If _DeletedRow = False Then
                lstinsertupdateRegistryWallet = New List(Of registryWallet)
                Dim Insertquery = From p In lstselectedRegistryWallet Where p.Rowaction = 1
                lstinsertupdateRegistryWallet = Insertquery.ToList()
                If lstinsertupdateRegistryWallet.Count > 0 Then

                    DBProvider.SaveRegistryWalletData(lstinsertupdateRegistryWallet)
                End If

                lstinsertupdateRegistryWallet = New List(Of registryWallet)
                Dim Updatequery = From p In lstselectedRegistryWallet Where p.Rowaction = 2
                lstinsertupdateRegistryWallet = Updatequery.ToList()
                If lstinsertupdateRegistryWallet.Count > 0 Then
                    DBProvider.UpdateRegistryWalletData(lstinsertupdateRegistryWallet)
                End If
                LoadRegistryWallet()

            End If


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function
#End Region

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        LoadRegistryWallet()
    End Sub

    Private Sub btnexporttoexcel_Click(sender As Object, e As EventArgs) Handles btnexporttoexcel.Click
        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim strFileName As String = saveFileDialog1.FileName

            'export to Excel
            Dim exporter As ExportToExcelML = New ExportToExcelML(Me.grdregistrywallet)

            Dim fileName As String = strFileName
            exporter.RunExport(fileName)
        End If
    End Sub

    Private Sub tbrregister206_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs) Handles tbrregister206.ButtonClick
        Select Case tbrregister206.Buttons.IndexOf(e.Button)
            Case 0
                Dim frm As New FrmrptLstOfRegistry
                frm.FrmName = Me.Name
                frm.Show()
            Case 2
                Dim saveFileDialog1 As New SaveFileDialog
                saveFileDialog1.Filter = "Excel files (*.xls)|*.xls|All files (*.*)|*.*"

                If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                    Dim strFileName As String = saveFileDialog1.FileName

                    'export to Excel
                    Dim exporter As ExportToExcelML = New ExportToExcelML(Me.grdregistrywallet)

                    Dim fileName As String = strFileName
                    exporter.RunExport(fileName)
                End If
        End Select
    End Sub


    Private Sub grdregistrywallet_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles grdregistrywallet.CellValueChanged
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
                    e.Row.Cells("id_User").Value = _bluserinfos.UserInfo.id_User
                    'End If

                    e.Row.Cells("Rowaction").Value = 2

                End If
            End If



        End If
    End Sub

    
 
End Class