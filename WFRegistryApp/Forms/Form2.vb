Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Public Class Form2
    Public Sub New()
        InitializeComponent()

        For i As Integer = 0 To 4
            Me.radGridView1.Columns.Add("Column " & i)
        Next i

        For i As Integer = 0 To 9
            Me.radGridView1.Rows.Add(i, i, i, i, i)
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim exporter As ExportToExcelML = New ExportToExcelML(Me.radGridView1)
        exporter.ExportVisualSettings = True

        Dim tempPath As String = Path.GetTempPath()
        tempPath &= "tempgrid.xls"
        exporter.RunExport(tempPath)

        Dim app As Microsoft.Office.Interop.Excel.Application = New Microsoft.Office.Interop.Excel.Application()

        If app Is Nothing Then
            Console.WriteLine("EXCEL could not be started. Check that your office installation and project references are correct.")
            Return
        End If

        app.Visible = False
        app.Interactive = False

        Dim wb As Microsoft.Office.Interop.Excel.Workbook = app.Workbooks.Open(tempPath)

        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        desktopPath &= "\grid.xlsx"

        wb.SaveAs(desktopPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault)
        wb.Close()
        app.Quit()

        Marshal.ReleaseComObject(wb)
        Marshal.ReleaseComObject(app)

    End Sub
End Class