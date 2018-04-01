Imports System
Imports Telerik.WinControls.UI

Public Class CustomRadMultiColumnComboBoxElement
    Inherits RadMultiColumnComboBoxElement

    Private _listOfRegistryDescription As List(Of String)
    Public Property listOfRegistryDescription() As List(Of String)
        Get
            Return _listOfRegistryDescription
        End Get
        Set(ByVal value As List(Of String))
            _listOfRegistryDescription = value
        End Set
    End Property

    Public Sub New()
        Me.AutoFilter = True
        listOfRegistryDescription = New List(Of String)
    End Sub

    Protected Overrides ReadOnly Property ThemeEffectiveType() As Type
        Get
            Return GetType(RadMultiColumnComboBoxElement)
        End Get
    End Property

   


    Private Sub ProcessReturnKey(e As System.Windows.Forms.KeyEventArgs)
        Dim text As String = Me.Text

        If Not String.IsNullOrEmpty(text) Then
            Dim newCurrentRow As GridViewRowInfo = TryCast(Me.FindItemExact(text), GridViewRowInfo)

            If newCurrentRow Is Nothing Then
                Me.AddTextAsRow(text)
            End If
        End If

        MyBase.ProcessReturnKey(e)
    End Sub

    Public Overrides Property Value() As Object
        Get
            Me.AddTextAsRow(Me.Text)
            Return MyBase.Value
        End Get
        Set(value As Object)
            MyBase.Value = value
        End Set
    End Property


    Private Sub AddTextAsRow(text As String)
        Try

            If String.IsNullOrEmpty(text) Then
                Exit Sub
            End If
            'Dim newCurrentRow As GridViewRowInfo = TryCast(Me.FindItemExact(text), GridViewRowInfo)
            'For i As Integer = 0 To EditorControl.Rows.Count - 1
            '    If EditorControl.Rows(i).Cells(0).Value = text Then

            '    End If

            'Next i


            'EditorControl.Rows(i).Cells(0).Value()

            'End If


            For i As Integer = 0 To EditorControl.Rows.Count - 1
                If EditorControl.Rows(i).Cells(0).Value IsNot DBNull.Value Then
                    If EditorControl.Rows(i).Cells(0).Value = text Then
                        Exit Sub
                    End If

                End If

            Next i

            'If listOfRegistryDescription.Contains(text) Then
            '    Exit Sub
            'End If
            Me.EditorControl.Rows.Add(text)

            'Me.EditorControl.Rows.Add(text)
        Catch ex As Exception

        End Try
      
    End Sub



End Class
