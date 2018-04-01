Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls

Public Class CustomDropDownListEditor
    Inherits RadDropDownListEditor

    Public Overrides Property Value() As Object
        Get
            Dim editorElement As CustomEditorElement = TryCast(Me.EditorElement, CustomEditorElement)
            If editorElement IsNot Nothing Then
                Dim selected As New List(Of Integer)()
                For Each item As RadListDataItem In editorElement.ListElement.SelectedItems
                    selected.Add(CInt(item.Value))
                Next
                Return selected.ToArray()
            End If
            Return MyBase.Value
        End Get
        Set(value As Object)
            Dim editorElement As CustomEditorElement = TryCast(Me.EditorElement, CustomEditorElement)
            If editorElement IsNot Nothing Then
                Dim names As Integer() = TryCast(value, Integer())
                If names IsNot Nothing Then
                    For Each val As Integer In names
                        Dim item As RadListDataItem = FindByValue(val)
                        If item IsNot Nothing Then
                            item.Selected = True
                        End If
                    Next
                End If
                editorElement.CallTextChanged()
            End If
        End Set
    End Property

    Private Function FindByValue(value As Object) As RadListDataItem
        Dim editorElement As CustomEditorElement = TryCast(Me.EditorElement, CustomEditorElement)
        For Each item As RadListDataItem In editorElement.Items
            If value.Equals(item.Value) Then
                Return item
            End If
        Next
        Return Nothing
    End Function

    Protected Overrides Function CreateEditorElement() As RadElement
        Return New CustomEditorElement()
    End Function

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by NRefactory.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================

End Class
