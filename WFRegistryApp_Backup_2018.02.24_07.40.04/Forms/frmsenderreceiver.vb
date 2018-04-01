Imports DBRegistryDLL
Imports Telerik.WinControls.UI
Public Class frmsenderreceiver
    Private _FrmRegistry As FrmRegistry
    Public Property FrmRegistry() As FrmRegistry
        Get
            Return _FrmRegistry
        End Get
        Set(ByVal value As FrmRegistry)
            _FrmRegistry = value
        End Set
    End Property
    Private _lstinsertupdateDeliveredFor As List(Of DeliveredFor)
    Public Property lstinsertupdateDeliveredFor() As List(Of DeliveredFor)
        Get
            Return _lstinsertupdateDeliveredFor
        End Get
        Set(ByVal value As List(Of DeliveredFor))
            _lstinsertupdateDeliveredFor = value
        End Set
    End Property

    Private _lstselectedDeliveredFor As List(Of DeliveredFor)
    Public Property lstselectedDeliveredFor() As List(Of DeliveredFor)
        Get
            Return _lstselectedDeliveredFor
        End Get
        Set(ByVal value As List(Of DeliveredFor))
            _lstselectedDeliveredFor = value
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

    Private Sub frmsenderreceiver_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim lstInsertedData As New List(Of DeliveredFor)
        Dim Insertquery = From p In lstselectedDeliveredFor Where p.Rowaction = 1 Or p.Rowaction = 2 Or p.Rowaction = 3
        lstInsertedData = Insertquery.ToList()
        If lstInsertedData.Count <> 0 Then
            If MessageBox.Show("You will lose changes!!!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.No Then
                e.Cancel = True

            End If
        End If

    End Sub
    Private Sub frmsenderreceiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdsendreceiver.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        DBProvider = New DBFunctions
        LoadDeliveredForDetails()
    End Sub
    Sub LoadDeliveredForDetails()
        lstselectedDeliveredFor = DBProvider.GetAllDeliveredFor

        grdsendreceiver.DataSource = lstselectedDeliveredFor
    End Sub
#Region "Grid Functions"
    Private Sub grdsendreceiver_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles grdsendreceiver.CellBeginEdit
        'If e.Row IsNot Nothing Then

        '    If e.RowIndex <> -1 Then
        '        e.Cancel = True
        '    End If

        'End If
    End Sub

    Private Sub grdsendreceiver_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles grdsendreceiver.CellDoubleClick
        If FrmRegistry IsNot Nothing Then
            If grdsendreceiver.SelectedRows.Count = 1 Then
                Dim sDeliveredForDescription As String
                Dim id_DeliveredFor As Integer = 0
                If grdsendreceiver.SelectedRows(0).Cells("DeliveredForDescription").Value IsNot DBNull.Value Then
                    sDeliveredForDescription = grdsendreceiver.SelectedRows(0).Cells("DeliveredForDescription").Value
                    id_DeliveredFor = grdsendreceiver.SelectedRows(0).Cells("id_DeliveredFor").Value
                    FrmRegistry.grdregistry.CurrentRow.Cells("DeliveredForDescription").Value = sDeliveredForDescription
                    FrmRegistry.grdregistry.CurrentRow.Cells("id_DeliveredFor").Value = id_DeliveredFor
                End If
                If FrmRegistry.grdregistry.CurrentRow.Cells("Registry_Seq").Value Is Nothing Then
                    FrmRegistry.grdregistry.CurrentRow.Cells("Rowaction").Value = 1
                Else
                    If FrmRegistry.grdregistry.CurrentRow.Cells("Registry_Seq").Value = 0 Then
                        FrmRegistry.grdregistry.CurrentRow.Cells("Rowaction").Value = 1
                    Else
                        FrmRegistry.grdregistry.CurrentRow.Cells("Rowaction").Value = 2
                    End If

                End If
                Me.Close()
            End If
        End If

    End Sub
    Private Sub grdsendreceiver_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles grdsendreceiver.CellValueChanged
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
    Private Sub grdsendreceiver_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grdsendreceiver.UserAddedRow
        e.Row.Cells("Rowaction").Value = 1
        e.Row.Cells("Rowaction").Value = 1
    End Sub


    Private Sub grdsendreceiver_UserDeletingRow(sender As Object, e As GridViewRowCancelEventArgs) Handles grdsendreceiver.UserDeletingRow

    End Sub
#End Region
#Region "Business Functions"
    Function SaveDeliveredForData(ByVal _DeletedRow As Boolean) As Boolean
        Try

            If _DeletedRow = False Then
                lstinsertupdateDeliveredFor = New List(Of DeliveredFor)
                Dim Insertquery = From p In lstselectedDeliveredFor Where p.Rowaction = 1
                lstinsertupdateDeliveredFor = Insertquery.ToList()
                If lstinsertupdateDeliveredFor.Count > 0 Then
                    DBProvider.SaveDeliveredForData(lstinsertupdateDeliveredFor)
                End If

                lstinsertupdateDeliveredFor = New List(Of DeliveredFor)
                Dim Updatequery = From p In lstselectedDeliveredFor Where p.Rowaction = 2
                lstinsertupdateDeliveredFor = Updatequery.ToList()
                If lstinsertupdateDeliveredFor.Count > 0 Then
                    DBProvider.UpdateDeliveredForData(lstinsertupdateDeliveredFor)
                End If
                LoadDeliveredForDetails()
            Else

                Dim query = From p In lstselectedDeliveredFor Where p.Rowaction = 3
                lstinsertupdateDeliveredFor = query.ToList()

                If lstinsertupdateDeliveredFor.Count > 0 Then
                    DBProvider.DeleteDeliveredForData(lstinsertupdateDeliveredFor)
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
            SaveDeliveredForData(False)
        End If
    End Sub
    Function ValidateData() As Boolean
        lstinsertupdateDeliveredFor = New List(Of DeliveredFor)
        Dim scodeequipments As String = String.Empty

        Dim query = From p In lstselectedDeliveredFor Where p.Rowaction = 1 Or p.Rowaction = 2
        lstinsertupdateDeliveredFor = query.ToList()

        If lstinsertupdateDeliveredFor.Count = 0 Then
            MessageBox.Show("No changes has been detected")
            Return False
        End If

        For i As Integer = 0 To lstinsertupdateDeliveredFor.Count - 1
            If lstinsertupdateDeliveredFor(i).DeliveredForDescription Is Nothing AndAlso lstinsertupdateDeliveredFor(i).DeliveredForDescription = "" Then
                MessageBox.Show("الرجاء تعبئة المصدر / المقام المرسل اليه ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If grdsendreceiver.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row")
            Exit Sub
        End If
        If MessageBox.Show("are you sure you want to delete?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            If grdsendreceiver.SelectedRows.Count <> 0 Then
                For i As Integer = 0 To grdsendreceiver.SelectedRows.Count - 1
                    grdsendreceiver.SelectedRows(i).Cells("Rowaction").Value = 3
                    If SaveDeliveredForData(True) = False Then
                        grdsendreceiver.SelectedRows(i).Cells("Rowaction").Value = 0

                    End If
                Next
                LoadDeliveredForDetails()
            End If

        End If
    End Sub
End Class