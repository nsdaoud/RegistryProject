Imports DBRegistryDLL
Imports Telerik.WinControls.UI
Public Class FrmUserDetails

    Private _lstinsertupdateUsers As List(Of Users)
    Public Property lstinsertupdateUsers() As List(Of Users)
        Get
            Return _lstinsertupdateUsers
        End Get
        Set(ByVal value As List(Of Users))
            _lstinsertupdateUsers = value
        End Set
    End Property

    Private _lstselectedUsers As List(Of Users)
    Public Property lstselectedUsers() As List(Of Users)
        Get
            Return _lstselectedUsers
        End Get
        Set(ByVal value As List(Of Users))
            _lstselectedUsers = value
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

    Private Sub FrmUserDetails_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim lstInsertedData As New List(Of Users)
        Dim Insertquery = From p In lstselectedUsers Where p.Rowaction = 1 Or p.Rowaction = 2 Or p.Rowaction = 3
        lstInsertedData = Insertquery.ToList()
        If lstInsertedData.Count <> 0 Then
            If MessageBox.Show("You will lose changes!!!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                e.Cancel = True

            End If
        End If
    End Sub

    Private Sub FrmUserDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grduserdetails.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        DBProvider = New DBFunctions
        LoadUserDetails()
    End Sub
    Sub LoadUserDetails()
        lstselectedUsers = DBProvider.GetAllUsers()

        grduserdetails.DataSource = lstselectedUsers
    End Sub




#Region "Business Functions"
    Function SaveUsersData(ByVal _DeletedRow As Boolean) As Boolean
        Try

            If _DeletedRow = False Then
                lstinsertupdateUsers = New List(Of Users)
                Dim Insertquery = From p In lstselectedUsers Where p.Rowaction = 1
                lstinsertupdateUsers = Insertquery.ToList()
                If lstinsertupdateUsers.Count > 0 Then
                    DBProvider.SaveUsersData(lstinsertupdateUsers)
                End If

                lstinsertupdateUsers = New List(Of Users)
                Dim Updatequery = From p In lstselectedUsers Where p.Rowaction = 2
                lstinsertupdateUsers = Updatequery.ToList()
                If lstinsertupdateUsers.Count > 0 Then
                    DBProvider.UpdateUserData(lstinsertupdateUsers)
                End If
                LoadUserDetails()
            Else

                Dim query = From p In lstselectedUsers Where p.Rowaction = 3
                lstinsertupdateUsers = query.ToList()

                If lstinsertupdateUsers.Count > 0 Then
                    DBProvider.DeleteUserData(lstinsertupdateUsers)
                End If
            End If


        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function
#End Region


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If ValidateData() = True Then
            SaveUsersData(False)
        End If

    End Sub
    Function ValidateData() As Boolean

        lstinsertupdateUsers = New List(Of Users)
        Dim scodeequipments As String = String.Empty

        Dim query = From p In lstselectedUsers Where p.Rowaction = 1 Or p.Rowaction = 2
        lstinsertupdateUsers = query.ToList()

        If lstinsertupdateUsers.Count = 0 Then
            MessageBox.Show("No changes has been detected")
            Return False
        End If

        For i As Integer = 0 To lstinsertupdateUsers.Count - 1
            If lstinsertupdateUsers(i).UserName Is Nothing AndAlso lstinsertupdateUsers(i).UserName = "" Then
                MessageBox.Show("الرجاء تعبئة الاسم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
            If lstinsertupdateUsers(i).UserLastName Is Nothing AndAlso lstinsertupdateUsers(i).UserLastName = "" Then
                MessageBox.Show("الرجاء تعبئة العائلة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If lstinsertupdateUsers(i).UserLogin Is Nothing Then
                MessageBox.Show("الرجاء تعبئة المستخدم", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If lstinsertupdateUsers(i).UserPassword Is Nothing AndAlso lstinsertupdateUsers(i).UserPassword = "" Then
                MessageBox.Show("الرجاء تعبئة كلمة السر", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If


            'scodeequipments = lstinsertupdateDrivers(i).equipmentco
            'Dim queryduplicate = From p In lstselectedDrivers Where p.equipmentcode = scodeequipments
            'If queryduplicate.Count > 1 Then
            '    MessageBox.Show("Code " + scodeequipments.ToString() + " already exist", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            '    Return False
            'End If
        Next
        Return True

    End Function


    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If grduserdetails.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row")
            Exit Sub
        End If
        If MessageBox.Show("are you sure you want to delete?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            If grduserdetails.SelectedRows.Count <> 0 Then
                For i As Integer = 0 To grduserdetails.SelectedRows.Count - 1
                    grduserdetails.SelectedRows(i).Cells("Rowaction").Value = 3
                    If SaveUsersData(True) = False Then
                        grduserdetails.SelectedRows(i).Cells("Rowaction").Value = 0

                    End If
                Next
                LoadUserDetails()
            End If

        End If
    End Sub

    Private Sub btnuserprivilege_Click(sender As Object, e As EventArgs) Handles btnuserprivilege.Click
        If grduserdetails.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row")
            Exit Sub
        End If

        Dim frm As New FrmUserPrivilege
        frm.idUser = Integer.Parse(grduserdetails.SelectedRows(0).Cells("id_User").Value)
        frm.ShowDialog()

    End Sub

    Private Sub grduserdetails_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles grduserdetails.CellBeginEdit
        If e.Row IsNot Nothing Then
            If e.Row.Cells("Rowaction").Value IsNot Nothing Then
                If e.ColumnIndex = 1 And e.RowIndex <> -1 And e.Row.Cells("Rowaction").Value <> 1 Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub
#Region "Grid Functions"
    Private Sub grduserdetails_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles grduserdetails.CellValueChanged
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
    Private Sub grduserdetails_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grduserdetails.UserAddedRow
        e.Row.Cells("Rowaction").Value = 1
    End Sub
    Private Sub grduserdetails_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles grduserdetails.UserDeletingRow
        If MessageBox.Show("are you sure you want to delete?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            If grduserdetails.SelectedRows.Count <> 0 Then
                For i As Integer = 0 To grduserdetails.SelectedRows.Count - 1
                    grduserdetails.SelectedRows(i).Cells(0).Value = 3
                    If SaveUsersData(True) = False Then
                        grduserdetails.SelectedRows(i).Cells(0).Value = 0
                        e.Cancel = True
                    End If
                Next

            End If

        End If
    End Sub
#End Region





End Class
