<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RadPdfViewer1 = New Telerik.WinControls.UI.RadPdfViewer()
        CType(Me.RadPdfViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPdfViewer1
        '
        Me.RadPdfViewer1.Location = New System.Drawing.Point(12, 12)
        Me.RadPdfViewer1.Name = "RadPdfViewer1"
        Me.RadPdfViewer1.Size = New System.Drawing.Size(260, 238)
        Me.RadPdfViewer1.TabIndex = 0
        Me.RadPdfViewer1.Text = "RadPdfViewer1"
        Me.RadPdfViewer1.ThumbnailsScaleFactor = 0.15!
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.RadPdfViewer1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.RadPdfViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadPdfViewer1 As Telerik.WinControls.UI.RadPdfViewer
End Class
