Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports WIA
Imports System.IO
Imports System.Threading
Imports System.ComponentModel
Imports System.Diagnostics
Imports scanner

Public Class Frmscanfile
    Dim newDoc As Integer = 0
    Dim cmbCMIndex = 0
    Dim sw As New Stopwatch()


    Private Sub Frmscanfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPath.Text = Path.GetTempPath()
        nudHeightInch.Value = 11
        nudWidthInch.Value = 8
        cmbColorMode.SelectedIndex = 1
    End Sub

    Private Sub btnSelectPath_Click(sender As Object, e As EventArgs) Handles btnSelectPath.Click
        Dim folderDlg = New FolderBrowserDialog()
        folderDlg.ShowNewFolderButton = True
        Dim result = folderDlg.ShowDialog()
        If result = DialogResult.OK Then
            txtPath.Text = folderDlg.SelectedPath
        End If
           
    End Sub

    Private Sub btnStartScan_Click(sender As Object, e As EventArgs) Handles btnStartScan.Click



        bgwScan.RunWorkerAsync(5000)
        btnStartScan.Enabled = False
        btnStopScan.Enabled = True
        cmbColorMode.Enabled = False
        nudWidthInch.Enabled = False
        nudHeightInch.Enabled = False
        nudRes.Enabled = False
        cbxCustomPixel.Enabled = False
        nudHeight.Enabled = False
        nudWidth.Enabled = False

        cmbCMIndex = cmbColorMode.SelectedIndex
    End Sub

    Private Sub btnStopScan_Click(sender As Object, e As EventArgs) Handles btnStopScan.Click
        bgwScan.CancelAsync()
        btnStartScan.Enabled = True
        btnStopScan.Enabled = False
        cmbColorMode.Enabled = True


        btnStartScan.Enabled = True
        btnStopScan.Enabled = False
        cmbColorMode.Enabled = True
        nudWidthInch.Enabled = True
        nudHeightInch.Enabled = True
        nudRes.Enabled = True
        cbxCustomPixel.Enabled = True
        If cbxCustomPixel.Checked = True Then
            nudHeight.Enabled = True
            nudWidth.Enabled = True
        End If
         

        sw.Reset()
        sw.Stop()
    End Sub

    Private Sub bgwScan_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwScan.DoWork
        While Not bgwScan.CancellationPending
            If newDoc = 0 Then
                newDoc = 1

                ScanDoc()
            End If

            For k As Integer = 1 To 10 * CInt(nudTime.Value)

                Thread.Sleep(100)

                bgwScan.ReportProgress(CInt(k \ CInt(nudTime.Value)))
                If k = 10 * CInt(nudTime.Value) Then
                    newDoc = 0
                End If
            Next
        End While
    End Sub


    Private Sub ScanDoc()
        Try
            'Dim MyDialog As New WIA.CommonDialogClass
            'Dim commonDialogClass As New CommonDialogClass()
            'Dim scannerDevice As Device = commonDialogClass.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, False, False)
            'If scannerDevice IsNot Nothing Then
            '    Dim scannnerItem As Item = scannerDevice.Items(1)
            '    AdjustScannerSettings(scannnerItem, CInt(nudRes.Value), 0, 0, CInt(nudWidth.Value), CInt(nudHeight.Value), _
            '        0, 0, cmbCMIndex)

            '    Dim scanResult As Object = commonDialogClass.ShowTransfer(scannnerItem, WIA.FormatID.wiaFormatTIFF, False)
            '    'picScan.Image = (System.Drawing.Image)scanResult;
            '    If scanResult IsNot Nothing Then
            '        Dim image As ImageFile = DirectCast(scanResult, ImageFile)
            '        Dim fileName As String = ""

            '        Dim files = Directory.GetFiles(txtPath.Text, "*.tiff")

            '        Try
            '            Dim f As String = ((files.Max(Function(p1) Int32.Parse(Path.GetFileNameWithoutExtension(p1)))) + 1).ToString()
            '            fileName = (Convert.ToString(txtPath.Text + "\") & f) + ".tiff"
            '        Catch ex As Exception
            '            fileName = txtPath.Text + "\" + "1.tiff"
            '        End Try
            '        SaveImageToTiff(image, fileName)
            '        picScan.ImageLocation = fileName
            '    End If
            'End If
        Catch err As Exception
            MessageBox.Show("Check the Device Connection " & vbLf & " or " & vbLf & " Change the Scanner Device", "Devic Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Shared Sub AdjustScannerSettings(scannnerItem As IItem, scanResolutionDPI As Integer, scanStartLeftPixel As Integer, scanStartTopPixel As Integer, scanWidthPixels As Integer, scanHeightPixels As Integer, _
    brightnessPercents As Integer, contrastPercents As Integer, colorMode As Integer)
        Const WIA_SCAN_COLOR_MODE As String = "6146"
        Const WIA_HORIZONTAL_SCAN_RESOLUTION_DPI As String = "6147"
        Const WIA_VERTICAL_SCAN_RESOLUTION_DPI As String = "6148"
        Const WIA_HORIZONTAL_SCAN_START_PIXEL As String = "6149"
        Const WIA_VERTICAL_SCAN_START_PIXEL As String = "6150"
        Const WIA_HORIZONTAL_SCAN_SIZE_PIXELS As String = "6151"
        Const WIA_VERTICAL_SCAN_SIZE_PIXELS As String = "6152"
        Const WIA_SCAN_BRIGHTNESS_PERCENTS As String = "6154"
        Const WIA_SCAN_CONTRAST_PERCENTS As String = "6155"
        SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_RESOLUTION_DPI, scanResolutionDPI)
        SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_RESOLUTION_DPI, scanResolutionDPI)
        SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_START_PIXEL, scanStartLeftPixel)
        SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_START_PIXEL, scanStartTopPixel)
        SetWIAProperty(scannnerItem.Properties, WIA_HORIZONTAL_SCAN_SIZE_PIXELS, scanWidthPixels)
        SetWIAProperty(scannnerItem.Properties, WIA_VERTICAL_SCAN_SIZE_PIXELS, scanHeightPixels)
        SetWIAProperty(scannnerItem.Properties, WIA_SCAN_BRIGHTNESS_PERCENTS, brightnessPercents)
        SetWIAProperty(scannnerItem.Properties, WIA_SCAN_CONTRAST_PERCENTS, contrastPercents)
        SetWIAProperty(scannnerItem.Properties, WIA_SCAN_COLOR_MODE, colorMode)



    End Sub

    Private Shared Sub SetWIAProperty(properties As IProperties, propName As Object, propValue As Object)
        Dim prop As [Property] = properties.get_Item(propName)
        prop.set_Value(propValue)
    End Sub

    Private Shared Sub SaveImageToTiff(image As ImageFile, fileName As String)
        Dim imgProcess As New ImageProcess()
        Dim convertFilter As Object = "Convert"
        Dim convertFilterID As String = imgProcess.FilterInfos.get_Item(convertFilter).FilterID
        imgProcess.Filters.Add(convertFilterID, 0)
        SetWIAProperty(imgProcess.Filters(imgProcess.Filters.Count).Properties, "FormatID", WIA.FormatID.wiaFormatTIFF)
        image = imgProcess.Apply(image)
        image.SaveFile(fileName)
    End Sub


    Private Sub nudWidthInch_ValueChanged(sender As Object, e As EventArgs)
        nudWidth.Value = nudRes.Value * nudWidthInch.Value
    End Sub

    Private Sub nudHeightInch_ValueChanged(sender As Object, e As EventArgs)
        nudHeight.Value = nudRes.Value * nudHeightInch.Value
    End Sub

    Private Sub nudRes_ValueChanged(sender As Object, e As EventArgs)
        nudWidth.Value = nudRes.Value * nudWidthInch.Value

        nudHeight.Value = nudRes.Value * nudHeightInch.Value
    End Sub

    Private Sub cbxCustomPixel_CheckedChanged(sender As Object, e As EventArgs)
        If cbxCustomPixel.Checked = True Then
            nudWidth.[ReadOnly] = False
            nudHeight.[ReadOnly] = False
        Else
            nudWidth.[ReadOnly] = True
            nudHeight.[ReadOnly] = True
        End If
    End Sub

    Private Sub bgwScan_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgwScan.ProgressChanged
        pbWaiting.Value = CInt(e.ProgressPercentage) * 10
        sw.Start()
        Dim i As Integer = (CInt(nudTime.Value) - CInt(sw.ElapsedMilliseconds / 1000))
        txtWT.Text = i.ToString() + " Secs. Remaining"

        If pbWaiting.Value = 100 Then
            pbWaiting.Value = 0
            txtWT.Text = "Proccessing"
            sw.Reset()
            sw.[Stop]()
        End If
    End Sub

    Private Sub bgwScan_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwScan.RunWorkerCompleted
        If e.Cancelled Then
            MessageBox.Show("Operation was canceled")
        ElseIf e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
        End If

    End Sub
End Class