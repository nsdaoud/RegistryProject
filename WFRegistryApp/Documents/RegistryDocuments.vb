Imports DBRegistryDLL
Imports System.Configuration

Public Class RegistryDocuments
    Implements IDocuments

    Private _TempDirectoryPath As String
    Public Property TempDirectoryPath() As String
        Get
            Return _TempDirectoryPath
        End Get
        Set(ByVal value As String)
            _TempDirectoryPath = value
        End Set
    End Property

    Private _SourceFilePath As String
    Public Property SourceFilePath() As String
        Get
            Return _SourceFilePath
        End Get
        Set(ByVal value As String)
            _SourceFilePath = value
        End Set
    End Property

    Private _DestinationFilePath As String
    Public Property DestinationFilePath() As String
        Get
            Return _DestinationFilePath
        End Get
        Set(ByVal value As String)
            _DestinationFilePath = value
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

    Private _SeqNumber As Integer
    Public Property SeqNumber() As Integer
        Get
            Return _SeqNumber
        End Get
        Set(ByVal value As Integer)
            _SeqNumber = value
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






    Private _DBDocuments As Documents
    Public Property DBDocuments() As Documents
        Get
            Return _DBDocuments
        End Get
        Set(ByVal value As Documents)
            _DBDocuments = value
        End Set
    End Property

    Private _destinationFilename As String
    Public Property destinationFilename() As String
        Get
            Return _destinationFilename
        End Get
        Set(ByVal value As String)
            _destinationFilename = value
        End Set
    End Property


    Private _SelectedFileName As String
    Public Property SelectedFileName() As String
        Get
            Return _SelectedFileName
        End Get
        Set(ByVal value As String)
            _SelectedFileName = value
        End Set
    End Property
    Private _Updatethefile As Boolean
    Public Property Updatethefile() As Boolean
        Get
            Return _Updatethefile
        End Get
        Set(ByVal value As Boolean)
            _Updatethefile = value
        End Set
    End Property


    Sub New(ByVal TypeOfRegisty As String)
        DestinationFilePath = ConfigurationManager.AppSettings(TypeOfRegisty)

    End Sub


    Public Function checkifDirectoryExist() As Boolean Implements IDocuments.checkifDirectoryExist
        If System.IO.Directory.Exists(TempDirectoryPath) = False Then
            System.IO.Directory.CreateDirectory(TempDirectoryPath)
        End If
        Return True
    End Function

    Public Function checkifFileExist() As Boolean Implements IDocuments.checkifFileExist
        If System.IO.File.Exists(DestinationFilePath + "\" + DBDocuments.fileName) = False Then
            Return False

        End If
        Return True
    End Function

    Public Function DownloadFile() As Boolean Implements IDocuments.DownloadFile
        Updatethefile = False
        If TypeFileIsWordExcel() Then
            If MessageBox.Show("هل تريد تحديث الملف", "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Updatethefile = True
                My.Computer.FileSystem.CopyFile(SourceFilePath + "\" + DBDocuments.fileName, TempDirectoryPath + "\" + DBDocuments.fileName, True)
                System.Diagnostics.Process.Start(TempDirectoryPath + "\" + DBDocuments.fileName)
            Else
                Dim SaveFileDialog1 As New SaveFileDialog()
                SaveFileDialog1.Filter = "All files (*.*)|*.*"
                SaveFileDialog1.Title = "Save File"
                SaveFileDialog1.FileName = DBDocuments.fileName
                SaveFileDialog1.ShowDialog()

                ' If the file name is not an empty string open it for saving.  
                If SaveFileDialog1.FileName <> "" Then
                    My.Computer.FileSystem.CopyFile(SourceFilePath + "\" + DBDocuments.fileName, SaveFileDialog1.FileName, True)
                End If
            End If

        Else
            Dim SaveFileDialog1 As New SaveFileDialog()
            SaveFileDialog1.Filter = "All files (*.*)|*.*"
            SaveFileDialog1.Title = "Save File"
            SaveFileDialog1.FileName = DBDocuments.fileName
            SaveFileDialog1.ShowDialog()

            ' If the file name is not an empty string open it for saving.  
            If SaveFileDialog1.FileName <> "" Then
                My.Computer.FileSystem.CopyFile(SourceFilePath + "\" + DBDocuments.fileName, SaveFileDialog1.FileName, True)
            End If


        End If
    End Function

    Public Function TypeFileIsWordExcel() As Boolean Implements IDocuments.TypeFileIsWordExcel
        Dim FileName As String()
        FileName = Split(SelectedFileName, ".")
        If FileName(1) = "xls" Or FileName(1) = "xlsx" Or FileName(1) = "docx" Then
            Return True
        End If
        Return False
    End Function

    Public Function UploadFile() As Boolean Implements IDocuments.UploadFile
        Try
            Dim fullFilename As String

            Using ofd As New OpenFileDialog

                ' Give the user some info: 
                ofd.Title = "Select file to copy"
                ' Set the file filter, it looks bad if it is empty. 
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
                If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
                    fullFilename = ofd.FileName

                Else
                    ' User cancelled. 
                    Return False
                    Exit Function
                End If
            End Using

            destinationFilename = IO.Path.GetExtension(fullFilename)
            destinationFilename = TypeOfRegisty.ToString.Trim() + "_" + Registry_Year + "_reg" + SeqNumber.ToString().Trim + "_sec" + DBDocuments.SeqDocument.ToString().Trim + destinationFilename


            If My.Computer.FileSystem.FileExists(DestinationFilePath + "\" + destinationFilename) = True Then
                If MessageBox.Show("Document already Exist do you want to continue", "", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then
                    Exit Function
                Else

                    System.IO.File.Copy(fullFilename, DestinationFilePath + "\" + destinationFilename, True)
                    System.IO.File.Delete(fullFilename)

                End If

            Else
                'MessageBox.Show(fullFilename)
                System.IO.File.Copy(fullFilename, DestinationFilePath + "\" + destinationFilename, True)
                System.IO.File.Delete(fullFilename)
            End If
            Return True
        Catch ex As Exception

        End Try
        

    End Function
End Class
