Imports WIA

Public Class Form1

    Private Sub btnStartScan_Click(sender As Object, e As EventArgs) Handles btnStartScan.Click
        Dim commonDialogClass As New CommonDialogClass()
        Dim scannerDevice As Device = commonDialogClass.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, False, False)

    End Sub
End Class