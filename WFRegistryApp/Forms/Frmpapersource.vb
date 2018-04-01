Imports DBRegistryDLL
Imports Telerik.WinControls.UI
Public Class Frmpapersource
    Private _FrmRegistry As FrmRegistry
    Public Property FrmRegistry() As FrmRegistry
        Get
            Return _FrmRegistry
        End Get
        Set(ByVal value As FrmRegistry)
            _FrmRegistry = value
        End Set
    End Property

    Private _FrmRegistry204 As FrmRegistry204
    Public Property FrmRegistry204() As FrmRegistry204
        Get
            Return _FrmRegistry204
        End Get
        Set(ByVal value As FrmRegistry204)
            _FrmRegistry204 = value
        End Set
    End Property
    Private _lstinsertupdatepapersource As List(Of papersource)
    Public Property lstinsertupdatepapersource() As List(Of papersource)
        Get
            Return _lstinsertupdatepapersource
        End Get
        Set(ByVal value As List(Of papersource))
            _lstinsertupdatepapersource = value
        End Set
    End Property

    Private _lstselectedpapersource As List(Of papersource)
    Public Property lstselectedpapersource() As List(Of papersource)
        Get
            Return _lstselectedpapersource
        End Get
        Set(ByVal value As List(Of papersource))
            _lstselectedpapersource = value
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

    Private Sub Frmpapersource_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim lstInsertedData As New List(Of papersource)
        Dim Insertquery = From p In lstselectedpapersource Where p.Rowaction = 1 Or p.Rowaction = 2 Or p.Rowaction = 3
        lstInsertedData = Insertquery.ToList()
        If lstInsertedData.Count <> 0 Then
            If MessageBox.Show("You will lose changes!!!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                e.Cancel = True

            End If
        End If
    End Sub
    Private Sub Frmpapersource_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdpapersource.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        DBProvider = New DBFunctions
        _bluserinfos = BLUserInfo.getInstance()
        If _bluserinfos.UserInfo.isAdmin = False Then
            Dim _ReadOnly As UserPrivilege
            Dim insertquery = From p In _bluserinfos.UserInfo.UserPrivileges
                                Where p.FormName = Me.Name
                                Select p
            _ReadOnly = insertquery.FirstOrDefault()
            If _ReadOnly.UserPrivilegeReadOnly = True Then
                grdpapersource.AllowAddNewRow = False
                grdpapersource.AllowEditRow = False
            ElseIf _ReadOnly.isEditable = True And _ReadOnly.canCreate = True Then
                grdpapersource.AllowAddNewRow = True
                grdpapersource.AllowEditRow = True
            ElseIf _ReadOnly.isEditable = True Then
                grdpapersource.AllowEditRow = True
                grdpapersource.AllowAddNewRow = False
            ElseIf _ReadOnly.canCreate = True Then
                grdpapersource.AllowAddNewRow = True
                grdpapersource.AllowEditRow = False
            End If
        Else
            grdpapersource.AllowAddNewRow = True
            grdpapersource.AllowEditRow = True
        End If
     
        LoadpapersourceDetails()
    End Sub
    Sub LoadpapersourceDetails()
        lstselectedpapersource = New List(Of papersource)
        lstselectedpapersource = DBProvider.GetAllpapersource

        grdpapersource.DataSource = lstselectedpapersource
    End Sub
#Region "Grid Functions"

    Private Sub grdpapersource_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles grdpapersource.CellBeginEdit
        'If e.Row IsNot Nothing Then
        '    If e.Row.Cells("Rowaction").Value IsNot Nothing Then
        '        If e.ColumnIndex = 1 And e.RowIndex <> -1 And e.Row.Cells("Rowaction").Value <> 1 Then
        '            e.Cancel = True
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub grdpapersource_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles grdpapersource.CellValueChanged
        If e.Row IsNot Nothing Then
            'If e.ColumnIndex = 2 Then
            '    Dim query = From p In bindinglstofItems Where p.Item_Cd = e.Row.Cells("Item_Cd").Value
            '    e.Row.Cells("Item_UnitOfMeasure").Value = query.FirstOrDefault().Item_UnitOfMeasure
            'End If
            If e.RowIndex <> -1 Then

                If e.Row.Cells("Rowaction").Value <> 3 And e.Row.Cells("Rowaction").Value <> 1 Then

                    e.Row.Cells("Rowaction").Value = 2

                End If
            End If

        End If
    End Sub

  

    Private Sub grdpapersource_ContextMenuOpening(sender As Object, e As ContextMenuOpeningEventArgs) Handles grdpapersource.ContextMenuOpening
        'e.Cancel = True
    End Sub

    Private Sub grdpapersource_KeyUp(sender As Object, e As KeyEventArgs) Handles grdpapersource.KeyUp
        If e.KeyCode = Keys.Enter Then
            If ValidateData() Then
                SavepapersourceData(False)
            End If
        End If
    End Sub

    Private Sub grdpapersource_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grdpapersource.UserAddedRow
        e.Row.Cells("Rowaction").Value = 1
        If ValidateData() Then
            SavepapersourceData(False)
        End If
        'e.Row.Cells("image").Value = "C:\PROJECTS\RegistryProject\RegistryProject\WFRegistryApp\images\add.png"
    End Sub
#End Region
#Region "Business Functions"
    Function SavepapersourceData(ByVal _DeletedRow As Boolean) As Boolean
        Try

            If _DeletedRow = False Then
                lstinsertupdatepapersource = New List(Of papersource)
                Dim Insertquery = From p In lstselectedpapersource Where p.Rowaction = 1
                lstinsertupdatepapersource = Insertquery.ToList()
                If lstinsertupdatepapersource.Count > 0 Then
                    DBProvider.SavepapersourceData(lstinsertupdatepapersource)
                End If

                lstinsertupdatepapersource = New List(Of papersource)
                Dim Updatequery = From p In lstselectedpapersource Where p.Rowaction = 2
                lstinsertupdatepapersource = Updatequery.ToList()
                If lstinsertupdatepapersource.Count > 0 Then
                    DBProvider.UpdatePaperSourceData(lstinsertupdatepapersource)
                End If
                LoadpapersourceDetails()
            Else

                Dim query = From p In lstselectedpapersource Where p.Rowaction = 3
                lstinsertupdatepapersource = query.ToList()

                If lstinsertupdatepapersource.Count > 0 Then
                    DBProvider.DeletePaperSourceData(lstinsertupdatepapersource)
                End If
                LoadpapersourceDetails()
            End If


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function
    Function ValidateData() As Boolean
        lstinsertupdatepapersource = New List(Of papersource)
        Dim scodeequipments As String = String.Empty

        Dim query = From p In lstselectedpapersource Where p.Rowaction = 1 Or p.Rowaction = 2
        lstinsertupdatepapersource = query.ToList()

        'If lstinsertupdatepapersource.Count = 0 Then
        '    MessageBox.Show("No changes has been detected")
        '    Return False
        'End If

        For i As Integer = 0 To lstinsertupdatepapersource.Count - 1
            If lstinsertupdatepapersource(i).PaperSourceDescription Is Nothing AndAlso lstinsertupdatepapersource(i).PaperSourceDescription = "" Then
                MessageBox.Show("الرجاء تعبئة مصدر الاوراق ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            'scodeequipments = lstinsertupdatepapersource(i).PaperSourceDescription
            'Dim queryduplicate = From p In lstselectedpapersource Where p.PaperSourceDescription = scodeequipments
            'If queryduplicate.Count > 1 Then
            '    MessageBox.Show("مصدر الاوراق موجود " + scodeequipments.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return False
            'End If
        Next
        Return True
    End Function
#End Region

    Private Sub btndelete_Click(sender As Object, e As EventArgs)
        If grdpapersource.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row")
            Exit Sub
        End If
        If MessageBox.Show("are you sure you want to delete?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            If grdpapersource.SelectedRows.Count <> 0 Then
                For i As Integer = 0 To grdpapersource.SelectedRows.Count - 1
                    grdpapersource.SelectedRows(i).Cells("Rowaction").Value = 3
                    If SavepapersourceData(True) = False Then
                        grdpapersource.SelectedRows(i).Cells("Rowaction").Value = 0

                    End If
                Next
                LoadpapersourceDetails()
            End If

        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs)
        If ValidateData() Then
            SavepapersourceData(False)
        End If
    End Sub
End Class