Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports DBRegistryDLL
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports Telerik.WinControls

Imports System.Threading
Imports System.IO
Imports System.Configuration
Imports System.Net

Public Class FrmDocuments

    Private idRegister As Integer
    Public Property id_Register() As Integer
        Get
            Return idRegister
        End Get
        Set(ByVal value As Integer)
            idRegister = value
        End Set
    End Property

    Private _registryType As String
    Public Property registryType() As String
        Get
            Return _registryType
        End Get
        Set(ByVal value As String)
            _registryType = value
        End Set
    End Property

    Private _TypeOfRegisty As String
    Public Property TypeOfRegisty() As String
        Get
            Return _TypeOfRegisty
        End Get
        Set(ByVal value As String)
            _TypeOfRegisty = value
        End Set
    End Property


    Private _SeqNumber As String
    Public Property SeqNumber() As String
        Get
            Return _SeqNumber
        End Get
        Set(ByVal value As String)
            _SeqNumber = value
        End Set
    End Property

    Private _RegistryYear As String
    Public Property Registry_Year() As String
        Get
            Return _RegistryYear
        End Get
        Set(ByVal value As String)
            _RegistryYear = value
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

    Private _DBProvider As DBFunctions
    Public Property DBProvider() As DBFunctions
        Get
            Return _DBProvider
        End Get
        Set(ByVal value As DBFunctions)
            _DBProvider = value
        End Set
    End Property

    Private _lstinsertupdateDocuments As List(Of Documents)
    Public Property lstinsertupdateDocuments() As List(Of Documents)
        Get
            Return _lstinsertupdateDocuments
        End Get
        Set(ByVal value As List(Of Documents))
            _lstinsertupdateDocuments = value
        End Set
    End Property

    Private _lstselectedDocuments As List(Of Documents)
    Public Property lstselectedDocuments() As List(Of Documents)
        Get
            Return _lstselectedDocuments
        End Get
        Set(ByVal value As List(Of Documents))
            _lstselectedDocuments = value
        End Set
    End Property

    Private Sub FrmDocuments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grddocuments.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
        grddocuments.TableElement.RowHeight = 75
        'grdregistry.EnableCustomFiltering = True

        'grdregistry.MasterTemplate.AddNewBoundRowBeforeEdit = True
        'grdregistry.BestFitColumns()
        DBProvider = New DBFunctions
        DBProvider.filepathString = ConfigurationManager.AppSettings(TypeOfRegisty)
        _bluserinfos = BLUserInfo.getInstance()


        If _bluserinfos.UserInfo.isAdmin = False Then
            Dim _ReadOnly As UserPrivilege
            Dim insertquery = From p In _bluserinfos.UserInfo.UserPrivileges
                              Where p.FormName = Me.Name
                              Select p
            _ReadOnly = insertquery.FirstOrDefault()
            If _ReadOnly.UserPrivilegeReadOnly = True Then
                grddocuments.AllowAddNewRow = False
                grddocuments.AllowEditRow = False
                btndownload.Visible = False
                btnloadfile.Visible = False
            ElseIf _ReadOnly.isEditable = True And _ReadOnly.canCreate = True Then
                grddocuments.AllowAddNewRow = True
                grddocuments.AllowEditRow = True
                btndownload.Visible = True
                btnloadfile.Visible = True
            ElseIf _ReadOnly.isEditable = True Then
                grddocuments.AllowEditRow = True
                grddocuments.AllowAddNewRow = False
                btndownload.Visible = True
                btnloadfile.Visible = True
            ElseIf _ReadOnly.canCreate = True Then
                grddocuments.AllowAddNewRow = True
                grddocuments.AllowEditRow = False
                btndownload.Visible = True
                btnloadfile.Visible = True
            End If
        Else
            grddocuments.AllowAddNewRow = True
            grddocuments.AllowEditRow = True
            btndownload.Visible = True
            btnloadfile.Visible = True
        End If

        txtseqnumber.Text = SeqNumber + "/" + Registry_Year
        LoadDocuments()
    End Sub

    Sub LoadDocuments()
        lstselectedDocuments = New List(Of Documents)
        lstselectedDocuments = DBProvider.GetAllDocuments(id_Register, registryType)

        grddocuments.DataSource = lstselectedDocuments
        'btnpapersource.Visible = False
        If _bluserinfos.UserInfo.isAdmin = False And _bluserinfos.UserInfo.isUser = False Then


            'btnsave.Visible = False
            'btnreport.Visible = False
            'btnexporttoexcel.Visible = False
            'grdregistry.AllowAddNewRow = False
            'grdregistry.AllowEditRow = False
        ElseIf bluserinfos.UserInfo.isAdmin = True Then

            'btnpapersource.Visible = True

        End If

        'Dim myAssembly As System.Reflection.Assembly = _ System.Reflection.Assembly.GetExecutingAssembly()
        'Dim myStream As Stream = _Assembly.GetManifestResourceStream("EmbeddingExample.image1.bmp")
        'Dim image As New Bitmap(myStream)

        'Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath)

        'Dim startupPath As String = System.Environment.getf

        'Dim directory As String =Path.Combine(Path.GetParentDirectory(GetType(MyClass).Assembly.Location), "Images\image.jpg")
        For i As Integer = 0 To grddocuments.Rows.Count - 1
            If grddocuments.Rows(i).Cells("fileName").Value IsNot Nothing Then

                grddocuments.Rows(i).Cells("attach").Value = My.Resources.Attachment1
            End If

        Next

    End Sub

    Function SaveDocumentData(ByVal _DeletedRow As Boolean) As Boolean
        Try
            lstinsertupdateDocuments = New List(Of Documents)
            Dim Insertquery = From p In lstselectedDocuments Where p.Rowaction = 1
            lstinsertupdateDocuments = Insertquery.ToList()
            If lstinsertupdateDocuments.Count > 0 Then

                DBProvider.SaveDocumentsData(lstinsertupdateDocuments)
            End If

            lstinsertupdateDocuments = New List(Of Documents)
            Dim Updatequery = From p In lstselectedDocuments Where p.Rowaction = 2
            lstinsertupdateDocuments = Updatequery.ToList()
            If lstinsertupdateDocuments.Count > 0 Then
                DBProvider.UpdateDocumentsData(lstinsertupdateDocuments)
            End If
            LoadDocuments()
        Catch ex As Exception

        End Try

    End Function

    Private Sub btnloadfile_Click(sender As Object, e As EventArgs) Handles btnloadfile2.Click
        Try

            If grddocuments.SelectedRows.Count = 0 Then
                MessageBox.Show("Please Select A row")
                Exit Sub
            End If
            If grddocuments.SelectedRows(0).Cells("Rowaction").Value = 2 _
            Or grddocuments.SelectedRows(0).Cells("Rowaction").Value = 1 Then
                MessageBox.Show("Please Save Before")
                Exit Sub
            End If

            Dim fullFilename As String
            Dim Documentid As Integer
            Dim DocumentSeq As Integer

            Using ofd As New OpenFileDialog

                ' Give the user some info: 
                ofd.Title = "Select file to copy"
                ' Set the file filter, it looks bad if it is empty. 
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    fullFilename = ofd.FileName

                Else
                    ' User cancelled. 
                    Exit Sub
                End If
            End Using
            ' We now have the filename + path. 
            ' get just the filename, get rid of the path: 

            'MessageBox.Show(fullFilename)
            Documentid = grddocuments.SelectedRows(0).Cells("id_Document").Value
            DocumentSeq = grddocuments.SelectedRows(0).Cells("SeqDocument").Value
            Dim destinationFilename As String = IO.Path.GetExtension(fullFilename)
            destinationFilename = TypeOfRegisty.ToString.Trim() + "_" + Registry_Year + "_reg" + SeqNumber.ToString().Trim + "_sec" + DocumentSeq.ToString().Trim + destinationFilename

            If My.Computer.FileSystem.FileExists(DBProvider.filepathString + "\" + destinationFilename) = True Then
                If MessageBox.Show("Document already Exist do you want to continue", "", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then
                    Exit Sub
                Else

                    My.Computer.FileSystem.CopyFile(fullFilename, DBProvider.filepathString + "\" + destinationFilename, True)
                    My.Computer.FileSystem.DeleteFile(fullFilename)

                End If

            Else
                'MessageBox.Show(fullFilename)
                My.Computer.FileSystem.CopyFile(fullFilename, DBProvider.filepathString + "\" + destinationFilename, True)
                My.Computer.FileSystem.DeleteFile(fullFilename)
            End If

            DBProvider.UpdateDocumentNameData(Documentid, destinationFilename)
            LoadDocuments()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FtpUploadFile(ByVal filetoupload As String, ByVal ftpuri As String, ByVal ftpusername As String, ByVal ftppassword As String)
        ' Create a web request that will be used to talk with the server and set the request method to upload a file by ftp.


        Try

            Dim uri As String = "ftp://192.168.88.14/abniadoc/" + filetoupload
            Dim reqFTP As FtpWebRequest

            ' Create FtpWebRequest object from the Uri provided


            reqFTP = DirectCast(FtpWebRequest.Create(New Uri(uri)), FtpWebRequest)
            Dim ftpRequest As FtpWebRequest = FtpWebRequest.Create(ftpuri)
            ftpRequest.Method = WebRequestMethods.Ftp.UploadFile
            MessageBox.Show(filetoupload + "Method")
            ' Confirm the Network credentials based on the user name and password passed in.
            ftpRequest.Credentials = New NetworkCredential(ftpusername, ftppassword)
            '  ftpRequest.
            ' Read into a Byte array the contents of the file to be uploaded 
            Dim bytes() As Byte = System.IO.File.ReadAllBytes(filetoupload)
            MessageBox.Show(filetoupload + "bytes")
            ' Transfer the byte array contents into the request stream, write and then close when done.
            ftpRequest.ContentLength = bytes.Length
            Using UploadStream As Stream = ftpRequest.GetRequestStream()
                UploadStream.Write(bytes, 0, bytes.Length)
                UploadStream.Close()
            End Using
            MessageBox.Show(filetoupload + "end")
        Catch ex As Exception
            'MessageBox.Show(fullFilename)
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show("Process Complete")
    End Sub

    Private Sub btndownload_Click(sender As Object, e As EventArgs) Handles btndownload.Click
        Try
            'Dim fileStream As New FileStream("C:\Users\d.abiyaghi\Desktop\ZEINA CV\path.txt", FileMode.Open)
            If grddocuments.SelectedRows.Count = 0 Then
                MessageBox.Show("Please Select A row")
                Exit Sub
            End If
            If grddocuments.SelectedRows(0).Cells("Rowaction").Value = 2 _
            Or grddocuments.SelectedRows(0).Cells("Rowaction").Value = 1 Then
                MessageBox.Show("Please Save Before")
                Exit Sub
            End If


            'Dim _indexrow As Integer = grddocuments.Rows.IndexOf(grddocuments.CurrentRow)
            'LoadDocuments()
            'grddocuments.CurrentRow = grddocuments.Rows(_indexrow)

            Dim tempfilepath As String
            tempfilepath = ConfigurationManager.AppSettings("temp")

            If System.IO.Directory.Exists(tempfilepath) = False Then
                System.IO.Directory.CreateDirectory(tempfilepath)
            End If

            Dim _filename As String = grddocuments.SelectedRows(0).Cells("fileName").Value
            Dim fi As New FileInfo(DBProvider.filepathString + "\" + _filename)
            If fi.Exists Then

                Dim Documentid As Integer
                Dim DocumentSelected As Documents
                Documentid = grddocuments.SelectedRows(0).Cells("id_Document").Value
                Dim _selectedDoc = From p In lstselectedDocuments Where p.id_Document = Documentid
                DocumentSelected = _selectedDoc.FirstOrDefault()

                Dim s As New RegistryDocuments(TypeOfRegisty)
                s.SourceFilePath = DBProvider.filepathString
                s.SelectedFileName = _filename
                s.TempDirectoryPath = tempfilepath
                s.DBDocuments = DocumentSelected
                s.DownloadFile()


                If s.TypeFileIsWordExcel = True And s.Updatethefile = True Then
                    Dim bfilelocked As Boolean = True
                    While bfilelocked = True

                        Try
                            bfilelocked = False
                            Dim fs As FileStream = File.Open(tempfilepath + "\" + _filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None)
                            fs.Close()
                            My.Computer.FileSystem.CopyFile(tempfilepath + "\" + _filename, DBProvider.filepathString + "\" + _filename, True)
                            File.Delete(tempfilepath + "\" + _filename)
                            'MessageBox.Show("File doesn't exist")

                        Catch ex As Exception
                            bfilelocked = True
                        End Try


                        'My.Computer.FileSystem.CopyFile(tempfilepath + "\" + _filename, DBProvider.filepathString + "\" + _filename, True)
                    End While
                End If


                'MessageBox.Show(s.Count)
                'End If

            Else
                MessageBox.Show("File doesn't exist")

            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Function IsFileLocked(ByVal filename As String) As Boolean
        Dim Locked As Boolean = False
        Try
            Dim fs As FileStream = File.Open(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None)
            fs.Close()


        Catch ex As Exception
            Locked = True
        End Try
        Return Locked
    End Function

    Private Sub grddocuments_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles grddocuments.CellBeginEdit

    End Sub

    Private Sub grddocuments_CellValueChanged(sender As Object, e As GridViewCellEventArgs) Handles grddocuments.CellValueChanged
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
                    If e.Column.Name <> "attach" Then
                        e.Row.Cells("Rowaction").Value = 2
                    End If


                End If
            End If
        End If
    End Sub

    Private Sub grddocuments_KeyUp(sender As Object, e As KeyEventArgs) Handles grddocuments.KeyUp
        If e.KeyCode = Keys.Enter Then
            SaveDocumentData(False)
        End If
    End Sub


    Private Sub grddocuments_UserAddedRow(sender As Object, e As GridViewRowEventArgs) Handles grddocuments.UserAddedRow
        e.Row.Cells("Rowaction").Value = 1
        e.Row.Cells("id_Registry").Value = id_Register
        e.Row.Cells("RegistryType").Value = registryType
        e.Row.Cells("CreationDate").Value = DateTime.Now
        SaveDocumentData(False)
        LoadDocuments()
    End Sub

    Private Sub btnscan_Click(sender As Object, e As EventArgs) Handles btnscan.Click
        If grddocuments.SelectedRows.Count = 0 Then
            MessageBox.Show("Please Select A row")
            Exit Sub
        End If
        If grddocuments.SelectedRows(0).Cells("Rowaction").Value = 2 _
        Or grddocuments.SelectedRows(0).Cells("Rowaction").Value = 1 Then
            MessageBox.Show("Please Save Before")
            Exit Sub
        End If

        Dim Documentid As Integer
        Dim DocumentSelected As Documents
        Documentid = grddocuments.SelectedRows(0).Cells("id_Document").Value
        Dim _selectedDoc = From p In lstselectedDocuments Where p.id_Document = Documentid
        DocumentSelected = _selectedDoc.FirstOrDefault()

        Dim _DocumentToUpload As RegistryDocuments
        _DocumentToUpload = New RegistryDocuments(TypeOfRegisty)
        _DocumentToUpload.DBDocuments = DocumentSelected
        _DocumentToUpload.Registry_Year = Registry_Year
        _DocumentToUpload.TypeOfRegisty = TypeOfRegisty
        _DocumentToUpload.SeqNumber = SeqNumber


        Dim frmscan As New frmscanfiles()
        frmscan.FrmDocuments = Me
        frmscan.DocumentName = TypeOfRegisty.ToString.Trim() + "_" + Registry_Year + "_reg" + SeqNumber.ToString().Trim + "_sec" + SeqNumber.ToString().Trim
        frmscan.DocumentID = Documentid
        frmscan.DestinationFilePath = _DocumentToUpload.DestinationFilePath
        frmscan.Show()

        'Dim CD As New WIA.CommonDialog
        'Dim F As WIA.ImageFile = CD.ShowAcquireImage(WIA.WiaDeviceType.ScannerDeviceType)
        'F.SaveFile("C:\Temp\WIA." + F.FileExtension)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnloadfile.Click
        If grddocuments.SelectedRows.Count = 0 Then
            MessageBox.Show("Please Select A row")
            Exit Sub
        End If
        If grddocuments.SelectedRows(0).Cells("Rowaction").Value = 2 _
        Or grddocuments.SelectedRows(0).Cells("Rowaction").Value = 1 Then
            MessageBox.Show("Please Save Before")
            Exit Sub
        End If

        'Dim _indexrow As Integer = grddocuments.Rows.IndexOf(grddocuments.CurrentRow)
        'LoadDocuments()
        'grddocuments.CurrentRow = grddocuments.Rows(_indexrow)

        Dim Documentid As Integer
        Dim DocumentSelected As Documents
        Documentid = grddocuments.SelectedRows(0).Cells("id_Document").Value
        Dim _selectedDoc = From p In lstselectedDocuments Where p.id_Document = Documentid
        DocumentSelected = _selectedDoc.FirstOrDefault()

        Dim _DocumentToUpload As RegistryDocuments
        _DocumentToUpload = New RegistryDocuments(TypeOfRegisty)
        _DocumentToUpload.DBDocuments = DocumentSelected
        _DocumentToUpload.Registry_Year = Registry_Year
        _DocumentToUpload.TypeOfRegisty = TypeOfRegisty
        _DocumentToUpload.SeqNumber = SeqNumber

        If _DocumentToUpload.UploadFile() = True Then
            DBProvider.UpdateDocumentNameData(Documentid, _DocumentToUpload.destinationFilename)
            LoadDocuments()

        End If


    End Sub


End Class