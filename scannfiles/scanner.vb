Imports System.Text
Imports System.Threading.Tasks
Imports WIA
Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public Class scanner

    Private ReadOnly _deviceInfo As DeviceInfo

    Private resolution As Integer = 150

    Private width_pixel As Integer = 1250

    Private height_pixel As Integer = 1700

    Private color_mode As Integer = 1

    Sub New(ByVal deviceInfo As DeviceInfo)
        Me._deviceInfo = deviceInfo
    End Sub

    Public Function ScanPNG() As ImageFile
        Dim device = Me._deviceInfo.Connect()
        Dim dlg As New CommonDialogClass()
        Dim item = device.Items(1)
        Try
            AdjustScannerSettings(item, resolution, 0, 0, width_pixel, height_pixel, 0, 0, color_mode)
            Dim scanResult As Object = dlg.ShowTransfer(item, WIA.FormatID.wiaFormatPNG, True)
            If scanResult IsNot Nothing Then
                Dim imageFile = CType(scanResult, ImageFile)
                Return imageFile
            End If
        Catch e As COMException
            Console.WriteLine(e.ToString())
            Dim errorCode As UInteger = CUInt(e.ErrorCode)
            If errorCode = 2149646342UI Then
                MessageBox.Show("The scanner is busy or isn't ready")
            ElseIf errorCode = 2149646436UI Then
                MessageBox.Show("The scanning process has been cancelled.")
            Else
                MessageBox.Show("A non catched error occurred, check the console", "Error", MessageBoxButtons.OK)
            End If

        End Try

        Return New ImageFile()
    End Function

    Public Function ScanJPEG() As ImageFile
        Dim device = Me._deviceInfo.Connect()
        Dim dlg As CommonDialogClass = New CommonDialogClass()
        Dim item = device.Items(1)
        Try
            AdjustScannerSettings(item, resolution, 0, 0, width_pixel, height_pixel, 0, 0, color_mode)
            Dim scanResult As Object = dlg.ShowTransfer(item, WIA.FormatID.wiaFormatJPEG, True)
            If scanResult IsNot Nothing Then
                Dim imageFile = CType(scanResult, ImageFile)
                Return imageFile
            End If
        Catch e As COMException
            Console.WriteLine(e.ToString())
            Dim errorCode As UInteger = CUInt(e.ErrorCode)
            If errorCode = 2149646342UI Then
                MessageBox.Show("The scanner is busy or isn't ready")
            ElseIf errorCode = 2149646436UI Then
                MessageBox.Show("The scanning process has been cancelled.")
            Else
                MessageBox.Show("A non catched error occurred, check the console", "Error", MessageBoxButtons.OK)
            End If

        End Try

        Return New ImageFile()
    End Function

    Public Function ScanTIFF() As ImageFile
        Dim device = Me._deviceInfo.Connect()
        Dim dlg As CommonDialogClass = New CommonDialogClass()
        Dim item = device.Items(1)
        Try
            AdjustScannerSettings(item, resolution, 0, 0, width_pixel, height_pixel, 0, 0, color_mode)
            Dim scanResult As Object = dlg.ShowTransfer(item, WIA.FormatID.wiaFormatTIFF, True)
            If scanResult IsNot Nothing Then
                Dim imageFile = CType(scanResult, ImageFile)
                Return imageFile
            End If
        Catch e As COMException
            Console.WriteLine(e.ToString())
            Dim errorCode As UInteger = CUInt(e.ErrorCode)
            If errorCode = 2149646342UI Then
                MessageBox.Show("The scanner is busy or isn't ready")
            ElseIf errorCode = 2149646436UI Then
                MessageBox.Show("The scanning process has been cancelled.")
            Else
                MessageBox.Show("A non catched error occurred, check the console", "Error", MessageBoxButtons.OK)
            End If

        End Try

        Return New ImageFile()
    End Function

    Private Shared Sub AdjustScannerSettings(ByVal scannnerItem As IItem, ByVal scanResolutionDPI As Integer, ByVal scanStartLeftPixel As Integer, ByVal scanStartTopPixel As Integer, ByVal scanWidthPixels As Integer, ByVal scanHeightPixels As Integer, ByVal brightnessPercents As Integer, ByVal contrastPercents As Integer, ByVal colorMode As Integer)
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


    Private Shared Sub SetWIAProperty(ByVal properties As IProperties, ByVal propName As Object, ByVal propValue As Object)
        Dim prop As [Property] = properties.Item(propName)
        prop.Value = propValue
    End Sub

    Public Overrides Function ToString() As String
        Return CStr(Me._deviceInfo.Properties("Name").Value)
    End Function

End Class
