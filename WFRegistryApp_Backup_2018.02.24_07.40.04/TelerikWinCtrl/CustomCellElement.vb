Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI

Public Class CustomCellElement
    Inherits GridDataCellElement

    Public Sub New(column As GridViewColumn, row As GridRowElement)
        MyBase.New(column, row)
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(GridDataCellElement)
        End Get
    End Property

    Public Overrides Sub SetContent()
        Dim values As Integer() = TryCast(Me.Value, Integer())
        If values Is Nothing Then
            Me.Text = ""
        Else
            Dim text As String = ""

            Dim col As CustomColumn = TryCast(Me.ColumnInfo, CustomColumn)
            If col IsNot Nothing Then
                For Each i As Integer In values
                    col.UseGetLookupValue = True
                    Dim val As Object = col.GetLookupValue(i)
                    col.UseGetLookupValue = False
                    If val IsNot Nothing Then
                        text += val.ToString() + "; "
                    End If
                Next
            End If
            Me.Text = text
        End If
    End Sub
End Class
