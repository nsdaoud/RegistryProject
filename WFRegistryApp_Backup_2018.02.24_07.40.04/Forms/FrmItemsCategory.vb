Imports DBRegistryDLL
Imports Telerik.WinControls.UI

Public Class FrmItemsCategory

    Private _lstinsertupdateItemCategory As List(Of ItemCategory)
    Public Property lstinsertupdateItemCategory() As List(Of ItemCategory)
        Get
            Return _lstinsertupdateItemCategory
        End Get
        Set(ByVal value As List(Of ItemCategory))
            _lstinsertupdateItemCategory = value
        End Set
    End Property

    Private _lstselectedItemCategory As List(Of ItemCategory)
    Public Property lstselectedItemCategory() As List(Of ItemCategory)
        Get
            Return _lstselectedItemCategory
        End Get
        Set(ByVal value As List(Of ItemCategory))
            _lstselectedItemCategory = value
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



    Private Sub FrmItemsCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grditemcategory.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        DBProvider = New DBFunctions
        _bluserinfos = BLUserInfo.getInstance()
        If _bluserinfos.UserInfo.isAdmin = False Then
            Dim _ReadOnly As UserPrivilege
            Dim insertquery = From p In _bluserinfos.UserInfo.UserPrivileges
                                Where p.FormName = Me.Name
                                Select p
            _ReadOnly = insertquery.FirstOrDefault()
            If _ReadOnly.UserPrivilegeReadOnly = True Then
                grditemcategory.AllowAddNewRow = False
                grditemcategory.AllowEditRow = False
            ElseIf _ReadOnly.isEditable = True And _ReadOnly.canCreate = True Then
                grditemcategory.AllowAddNewRow = True
                grditemcategory.AllowEditRow = True
            ElseIf _ReadOnly.isEditable = True Then
                grditemcategory.AllowEditRow = True
                grditemcategory.AllowAddNewRow = False
            ElseIf _ReadOnly.canCreate = True Then
                grditemcategory.AllowAddNewRow = True
                grditemcategory.AllowEditRow = False
            End If
        Else
            grditemcategory.AllowAddNewRow = True
            grditemcategory.AllowEditRow = True
        End If

        LoadItemCategoryDetails()
    End Sub

    Private Sub grditemcategory_KeyUp(sender As Object, e As KeyEventArgs) Handles grditemcategory.KeyUp
        If e.KeyCode = Keys.Enter Then
            If ValidateData() Then
                SaveItemCategoryData(False)
            End If
        End If
    End Sub

    Sub LoadItemCategoryDetails()
        lstselectedItemCategory = New List(Of ItemCategory)
        lstselectedItemCategory = DBProvider.GetAllItemsCategory

        grditemcategory.DataSource = lstselectedItemCategory
    End Sub

#Region "Business Functions"
    Function SaveItemCategoryData(ByVal _DeletedRow As Boolean) As Boolean
        Try

            If _DeletedRow = False Then
                lstinsertupdateItemCategory = New List(Of ItemCategory)
                Dim Insertquery = From p In lstselectedItemCategory Where p.Rowaction = 1
                lstinsertupdateItemCategory = Insertquery.ToList()
                If lstinsertupdateItemCategory.Count > 0 Then
                    DBProvider.SaveItemCategoryData(lstinsertupdateItemCategory)
                End If

                lstinsertupdateItemCategory = New List(Of ItemCategory)
                Dim Updatequery = From p In lstselectedItemCategory Where p.Rowaction = 2
                lstinsertupdateItemCategory = Updatequery.ToList()
                If lstinsertupdateItemCategory.Count > 0 Then
                    DBProvider.UpdateItemCategoryData(lstinsertupdateItemCategory)
                End If
                LoadItemCategoryDetails()
            Else

                Dim query = From p In lstselectedItemCategory Where p.Rowaction = 3
                lstinsertupdateItemCategory = query.ToList()

                If lstinsertupdateItemCategory.Count > 0 Then
                    DBProvider.DeleteItemsCategoryData(lstinsertupdateItemCategory)
                End If
                LoadItemCategoryDetails()
            End If


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function
    Function ValidateData() As Boolean
        lstinsertupdateItemCategory = New List(Of ItemCategory)
        Dim scodeequipments As String = String.Empty

        Dim query = From p In lstselectedItemCategory Where p.Rowaction = 1 Or p.Rowaction = 2
        lstinsertupdateItemCategory = query.ToList()

        'If lstinsertupdatepapersource.Count = 0 Then
        '    MessageBox.Show("No changes has been detected")
        '    Return False
        'End If

        For i As Integer = 0 To lstinsertupdateItemCategory.Count - 1
            If lstinsertupdateItemCategory(i).descriptionItemCategory Is Nothing AndAlso lstinsertupdateItemCategory(i).descriptionItemCategory = "" Then
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

  
    Private Sub grditemcategory_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grditemcategory.UserAddedRow
        e.Row.Cells("Rowaction").Value = 1
        If ValidateData() Then
            SaveItemCategoryData(False)
        End If
    End Sub

    Private Sub btnitems_Click(sender As Object, e As EventArgs) Handles btnitems.Click

    End Sub
End Class