Imports System
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading.Tasks
Imports WIA
Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Path
Imports DBRegistryDLL
Imports System.ComponentModel

Public Class frmscanfiles

    Private _FrmDocuments As FrmDocuments
    Public Property FrmDocuments As FrmDocuments
        Get
            Return _FrmDocuments
        End Get
        Set(ByVal value As FrmDocuments)
            _FrmDocuments = value
        End Set
    End Property

    Private _DocumentName As String
    Public Property DocumentName() As String
        Get
            Return _DocumentName
        End Get
        Set(ByVal value As String)
            _DocumentName = value
        End Set
    End Property

    Private newPropertyValue As Integer
    Public Property NewProperty() As Integer
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As Integer)
            newPropertyValue = value
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

    Private _Documentid As Integer
    Public Property DocumentID() As Integer
        Get
            Return _Documentid
        End Get
        Set(ByVal value As Integer)
            _Documentid = value
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
    Sub New()
        DBProvider = New DBFunctions
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmscanfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListScanners()
        TextBox2.Text = DestinationFilePath + "\" + DocumentName

        'ComboBox1.Items.Add("PNG")
        ComboBox1.Items.Add("JPEG")
        ComboBox1.SelectedIndex = 0
        'ComboBox1.Items.Add("TIFF")
    End Sub

    Private Sub ListScanners()
        ListBox1.Items.Clear()
        Dim dev As New DeviceManager



        For devicecount As Integer = 0 To dev.DeviceInfos.Count - 1
            If dev.DeviceInfos(1).Type <> WiaDeviceType.ScannerDeviceType Then
                Continue For
            End If
            ListBox1.Items.Add(New scanner(dev.DeviceInfos(1)))

        Next

    End Sub

    Private Sub TriggerScan()
        Console.WriteLine("Image succesfully scanned")
        MessageBox.Show("Image succesfully scanned")
        DBProvider.UpdateDocumentNameData(DocumentID, DocumentName + ".jpeg")
    End Sub

    'Public Sub StartScanning()
    '    Dim device As scanner = Nothing
    '    Me.Invoke(New MethodInvoker(Function()
    '                                    device = TryCast(ListBox1.SelectedItem, scanner)
    '                                End Function))
    '    If device Is Nothing Then
    '        MessageBox.Show("You need to select first an scanner device from the list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return
    '    ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
    '        MessageBox.Show("Provide a filename", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return
    '    End If

    '    Dim image As ImageFile = New ImageFile()
    '    Dim imageExtension As String = ""
    '    Me.Invoke(New MethodInvoker(Function()
    '                                    Select Case ComboBox1.SelectedIndex
    '                                        Case 0
    '                                            image = device.ScanPNG()
    '                                            imageExtension = ".png"
    '                                        Case 1
    '                                            image = device.ScanJPEG()
    '                                            imageExtension = ".jpeg"
    '                                        Case 2
    '                                            image = device.ScanTIFF()
    '                                            imageExtension = ".tiff"
    '                                    End Select
    '                                End Function))
    '    Dim path = path.Combine(TextBox1.Text, TextBox2.Text & imageExtension)
    '    If File.Exists(path) Then
    '        File.Delete(path)
    '    End If

    '    image.SaveFile(path)
    '    PictureBox1.Image = New Bitmap(path)
    'End Sub

    Private Sub btnscan_Click(sender As Object, e As EventArgs) Handles btnscan.Click
        Task.Factory.StartNew(Sub() StartScanning()
                                  ).ContinueWith(Sub() TriggerScan())
    End Sub


    Public Sub StartScanning()
        Try
            Dim device As scanner = Nothing
            Me.Invoke(New MethodInvoker(Function()
                                            device = TryCast(ListBox1.SelectedItem, scanner)
                                        End Function))
            If device Is Nothing Then
                MessageBox.Show("You need to select first an scanner device from the list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
                MessageBox.Show("Provide a filename", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim image As ImageFile = New ImageFile()
            Dim imageExtension As String = ""
            Me.Invoke(New MethodInvoker(Function()
                                            Select Case NewProperty
                                                Case 0
                                                    image = device.ScanJPEG()
                                                    imageExtension = ".jpeg"
                                                Case 1
                                                    image = device.ScanPNG()
                                                    imageExtension = ".png"
                                                Case 2
                                                    image = device.ScanTIFF()
                                                    imageExtension = ".tiff"
                                            End Select
                                        End Function))
            Dim subdirectory1 As String = System.IO.Path.Combine("MyApp1", "SubDir1")

            Dim path As String = TextBox2.Text + imageExtension
            Dim destpath As String = TextBox2.Text
            If File.Exists(path) Then
                File.Delete(path)
            End If

            image.SaveFile(path)
            PictureBox1.Image = New Bitmap(path)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnfilelocation_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        NewProperty = ComboBox1.SelectedIndex

    End Sub

    Private Sub frmscanfiles_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub frmscanfiles_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FrmDocuments.LoadDocuments()
        FrmDocuments = Nothing

    End Sub
End Class