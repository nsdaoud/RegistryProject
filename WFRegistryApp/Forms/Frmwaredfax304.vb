Imports DBRegistryDLL
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class Frmwaredfax304

    Dim dtbindinglstofpapersource As DataTable
    Dim _papersource As New GridViewMultiComboBoxColumn("id_WFDestination", "id_WFDestination")

    Private _DataTable As DataTable
    Public Property waredfax304Table() As DataTable
        Get
            Return _DataTable
        End Get
        Set(ByVal value As DataTable)
            _DataTable = value
        End Set
    End Property
    Private _DBProvider As WaredFaxManager
    Public Property DBProvider() As WaredFaxManager
        Get
            Return _DBProvider
        End Get
        Set(ByVal value As WaredFaxManager)
            _DBProvider = value
        End Set
    End Property

    Private _Waredfax304 As Waredfax304
    Public Property Waredfax304info() As Waredfax304
        Get
            Return _Waredfax304
        End Get
        Set(ByVal value As Waredfax304)
            _Waredfax304 = value
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
    Private _OLDDBProvider As DBFunctions

    Public Property OLDDBProvider() As DBFunctions
        Get
            Return _OLDDBProvider
        End Get
        Set(ByVal value As DBFunctions)
            _OLDDBProvider = value
        End Set
    End Property
    Private Sub Frmwaredfax304_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBProvider = New WaredFaxManager
        OLDDBProvider = New DBFunctions
        _bluserinfos = BLUserInfo.getInstance()
        grdwaredfax304.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grdwaredfax304.TableElement.RowHeight = 75

        dtbindinglstofpapersource = New DataTable("WFDestination")
        dtbindinglstofpapersource = OLDDBProvider.GetAll304Dtpapersource()

        _papersource.FieldName = "id_WFDestination"
        grdwaredfax304.Columns.Add(_papersource)
        _papersource.DataSource = dtbindinglstofpapersource
        _papersource.Width = 120
        _papersource.DisplayMember = "WFDestination"
        _papersource.ValueMember = "id_WFDestination"
        _papersource.HeaderText = "بيان الأشياء او الأشخاص أو الأدوات الأدوات المرفقة "
        '_papersource.AllowFiltering = True
        _papersource.WrapText = True
        '_papersource.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        _papersource.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDown
        grdwaredfax304.Columns().Move(9, 5)

        Loadwaredfax304()
    End Sub
    Function SaveWaredFax304Data(ByVal _UpdateRow As Boolean, ByVal _gridViewRowInfo As GridViewRowInfo) As Boolean
        Try
            Dim lstofWaredfax304 As New List(Of Waredfax304)

            If _UpdateRow = False Then
                Waredfax304info = New Waredfax304


                If _gridViewRowInfo.Cells("waredfax304Destination").Value Is DBNull.Value Then
                    Waredfax304info.waredfax304Destination = Nothing
                Else
                    Waredfax304info.waredfax304Destination = (_gridViewRowInfo.Cells("waredfax304Destination").Value)
                End If
                Waredfax304info.waredfax304Date = DateTime.Now
                If _gridViewRowInfo.Cells("waredfax304_Number").Value Is DBNull.Value Then
                    Waredfax304info.waredfax304_Number = Nothing
                Else
                    Waredfax304info.waredfax304_Number = (_gridViewRowInfo.Cells("waredfax304_Number").Value)
                End If
                If _gridViewRowInfo.Cells("marboutatnumber").Value Is DBNull.Value Then
                    Waredfax304info.marboutatnumber = Nothing
                Else
                    Waredfax304info.marboutatnumber = (_gridViewRowInfo.Cells("marboutatnumber").Value)
                End If
                If _gridViewRowInfo.Cells("id_WFDestination").Value Is DBNull.Value Then
                    Waredfax304info.id_WFDestination = 0
                Else
                    Waredfax304info.id_WFDestination = (_gridViewRowInfo.Cells("id_WFDestination").Value)
                End If
                If _gridViewRowInfo.Cells("waredfax304_Note").Value Is DBNull.Value Then
                    Waredfax304info.waredfax304Note = Nothing
                Else
                    Waredfax304info.waredfax304Note = (_gridViewRowInfo.Cells("waredfax304_Note").Value)
                End If




                'Waredfax304info.waredfax304Destination = (_gridViewRowInfo.Cells("waredfax304Destination").Value)
                '
                'Waredfax304info.waredfax304_Number = (_gridViewRowInfo.Cells("waredfax304_Number").Value)
                'Waredfax304info.marboutatnumber = (_gridViewRowInfo.Cells("marboutatnumber").Value)
                'Waredfax304info.waredfax304Desc = (_gridViewRowInfo.Cells("waredfax304Desc").Value)
                'Waredfax304info.waredfax304Note = _gridViewRowInfo.Cells("waredfax304Note").Value
                Waredfax304info.id_CreationUser = _bluserinfos._idUser
                lstofWaredfax304.Add(Waredfax304info)

                DBProvider.insertWaredFax304Data(lstofWaredfax304)



            Else
                Waredfax304info = New Waredfax304
                Waredfax304info.id_304waredfax = Integer.Parse(_gridViewRowInfo.Cells("id_304waredfax").Value)

                If _gridViewRowInfo.Cells("waredfax304Destination").Value Is DBNull.Value Then
                    Waredfax304info.waredfax304Destination = Nothing
                Else
                    Waredfax304info.waredfax304Destination = (_gridViewRowInfo.Cells("waredfax304Destination").Value)
                End If

                If _gridViewRowInfo.Cells("waredfax304_Number").Value Is DBNull.Value Then
                    Waredfax304info.waredfax304_Number = Nothing
                Else
                    Waredfax304info.waredfax304_Number = (_gridViewRowInfo.Cells("waredfax304_Number").Value)
                End If
                If _gridViewRowInfo.Cells("marboutatnumber").Value Is DBNull.Value Then
                    Waredfax304info.marboutatnumber = Nothing
                Else
                    Waredfax304info.marboutatnumber = (_gridViewRowInfo.Cells("marboutatnumber").Value)
                End If
                If _gridViewRowInfo.Cells("id_WFDestination").Value Is DBNull.Value Then
                    Waredfax304info.id_WFDestination = 0
                Else
                    Waredfax304info.id_WFDestination = (_gridViewRowInfo.Cells("id_WFDestination").Value)
                End If
                If _gridViewRowInfo.Cells("waredfax304_Note").Value Is DBNull.Value Then
                    Waredfax304info.waredfax304Note = Nothing
                Else
                    Waredfax304info.waredfax304Note = (_gridViewRowInfo.Cells("waredfax304_Note").Value)
                End If


                Waredfax304info.id_UpdateUser = _bluserinfos._idUser
                lstofWaredfax304.Add(Waredfax304info)

                DBProvider.UpdateWaredFax304Data(lstofWaredfax304)
            End If

            Loadwaredfax304()

        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Sub Loadwaredfax304()


        waredfax304Table = DBProvider.GetWaredFax304Data()
        grdwaredfax304.DataSource = waredfax304Table
    End Sub

    Private Sub grdwaredfax304_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grdwaredfax304.UserAddedRow
        SaveWaredFax304Data(False, e.Row)
    End Sub

    Private Sub grdwaredfax304_KeyUp(sender As Object, e As KeyEventArgs) Handles grdwaredfax304.KeyUp
        If e.KeyCode = Keys.Enter Then
            Dim _indexrow As Integer = grdwaredfax304.Rows.IndexOf(grdwaredfax304.CurrentRow)
            SaveWaredFax304Data(True, grdwaredfax304.Rows(_indexrow))
            grdwaredfax304.CurrentRow = grdwaredfax304.Rows(_indexrow)
        End If
    End Sub

    Private Sub grdwaredfax304_CellEditorInitialized(sender As Object, e As GridViewCellEventArgs) Handles grdwaredfax304.CellEditorInitialized
        If e.Column.FieldName = "id_WFDestination" Then
            Dim mccbEditor As RadMultiColumnComboBoxElement = TryCast(e.ActiveEditor, RadMultiColumnComboBoxElement)


            If mccbEditor IsNot Nothing Then
                Dim descriptor As New FilterDescriptor("WFDestination", FilterOperator.Contains, Nothing)
                mccbEditor.EditorControl.FilterDescriptors.Add(descriptor)
            End If
            mccbEditor.AutoSizeDropDownToBestFit = True
        End If
    End Sub
End Class