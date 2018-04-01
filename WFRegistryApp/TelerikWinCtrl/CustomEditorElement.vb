Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports Telerik.WinControls.Layouts

Public Class CustomEditorElement
    Inherits RadDropDownListEditorElement

    Private customText As LightVisualElement
    Private closeButton As RadButtonElement
    Private textChanged As Boolean

    Public Sub New()
        closeButton = New RadButtonElement("Close")
        closeButton.SetValue(DockLayoutPanel.DockProperty, Dock.Bottom)
        AddHandler closeButton.Click, AddressOf closeButton_Click
        Me.Popup.SizingGripDockLayout.Children.Insert(1, closeButton)

        Me.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple

        AddHandler Me.PopupClosing, AddressOf CustomEditorElement_PopupClosing
        AddHandler Me.CreatingVisualItem, AddressOf CustomEditorElement_CreatingVisualItem
        AddHandler Me.ListElement.ItemDataBinding, AddressOf Me.CustomEditorElement_ItemDataBinding
    End Sub

    Private Sub closeButton_Click(sender As Object, e As EventArgs)
        ClosePopup()
        Dim cell As GridDataCellElement = TryCast(Me.Parent, GridDataCellElement)
        If cell IsNot Nothing Then
            cell.GridViewElement.EndEdit()
        End If
    End Sub

    Private Sub CustomEditorElement_ItemDataBinding(sender As Object, args As ListItemDataBindingEventArgs)
        args.NewItem = New CustomListDataItem()
    End Sub

    Private Sub CustomEditorElement_CreatingVisualItem(sender As Object, args As CreatingVisualListItemEventArgs)
        args.VisualItem = New CustomListVisualItem()
    End Sub

    Private Sub CustomEditorElement_PopupClosing(sender As Object, args As RadPopupClosingEventArgs)
        Dim editor As CustomEditorElement = DirectCast(sender, CustomEditorElement)
        If args.CloseReason = RadPopupCloseReason.Mouse Then
            If editor.PopupForm.Bounds.Contains(Control.MousePosition) Then
                args.Cancel = True
            End If
        End If
    End Sub

    Protected Overrides Sub CreateChildElements()
        MyBase.CreateChildElements()

        customText = New LightVisualElement()
        customText.DrawBorder = False
        customText.DrawFill = True
        customText.GradientStyle = GradientStyles.Solid
        customText.BackColor = Color.White
        customText.TextAlignment = ContentAlignment.MiddleLeft
        Me.EditableElement.Children.Add(customText)
    End Sub

    Public Overrides Sub ShowPopup()
        Dim selected As Boolean() = New Boolean(Me.Items.Count - 1) {}
        For i As Integer = 0 To selected.Length - 1
            selected(i) = Me.Items(i).Selected
        Next
        MyBase.ShowPopup()
        For i As Integer = 0 To selected.Length - 1
            Me.Items(i).Selected = selected(i)
        Next
    End Sub


    Public Sub CallTextChanged()
        OnTextChanged(EventArgs.Empty)
    End Sub

    Protected Overrides Sub OnTextChanged(e As EventArgs)
        If textChanged Then
            Return
        End If
        textChanged = True
        Dim text As String = ""
        For Each item As RadListDataItem In Me.ListElement.SelectedItems
            text += item.Text + "; "
        Next
        customText.Text = text
        textChanged = False
    End Sub

    '=======================================================
    'Service provided by Telerik (www.telerik.com)
    'Conversion powered by NRefactory.
    'Twitter: @telerik
    'Facebook: facebook.com/telerik
    '=======================================================

End Class
