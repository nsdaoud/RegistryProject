Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI
Public Class CustomColumn
    Inherits GridViewComboBoxColumn

    Public Sub New(ByVal name As String)

        MyBase.New(name)
    End Sub

    Public Overrides Property DataType() As Type
        Get
            If UseGetLookupValue Then
                Return GetType(Integer)
            End If
            Return GetType(Integer())
        End Get
        Set(value As Type)
        End Set
    End Property

    Public UseGetLookupValue As Boolean = False

    Public Overrides Function GetDefaultEditorType() As Type
        Return GetType(CustomDropDownListEditor)
    End Function

    Public Overrides Function GetCellType(row As GridViewRowInfo) As Type
        If TypeOf row Is GridViewDataRowInfo OrElse TypeOf row Is GridViewNewRowInfo Then
            Return GetType(CustomCellElement)
        End If
        Return MyBase.GetCellType(row)
    End Function

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by NRefactory.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================


End Class
