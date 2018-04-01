<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmpapersource
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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.grdpapersource = New Telerik.WinControls.UI.RadGridView()
        CType(Me.grdpapersource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdpapersource.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdpapersource
        '
        Me.grdpapersource.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdpapersource.Location = New System.Drawing.Point(12, 41)
        '
        'grdpapersource
        '
        Me.grdpapersource.MasterTemplate.AllowCellContextMenu = False
        Me.grdpapersource.MasterTemplate.AllowDeleteRow = False
        GridViewTextBoxColumn1.FieldName = "id_PaperSource"
        GridViewTextBoxColumn1.HeaderText = "id_PaperSource"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "id_PaperSource"
        GridViewTextBoxColumn2.FieldName = "PaperSourceDescription"
        GridViewTextBoxColumn2.HeaderText = "مصدر الاوراق / المقام المرسل اليه"
        GridViewTextBoxColumn2.Name = "PaperSourceDescription"
        GridViewTextBoxColumn3.FieldName = "Rowaction"
        GridViewTextBoxColumn3.HeaderText = "Rowaction"
        GridViewTextBoxColumn3.IsVisible = False
        GridViewTextBoxColumn3.Name = "Rowaction"
        Me.grdpapersource.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
        Me.grdpapersource.MasterTemplate.EnableFiltering = True
        Me.grdpapersource.Name = "grdpapersource"
        Me.grdpapersource.Size = New System.Drawing.Size(769, 438)
        Me.grdpapersource.TabIndex = 5
        Me.grdpapersource.Text = "RadGridView1"
        '
        'Frmpapersource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 491)
        Me.Controls.Add(Me.grdpapersource)
        Me.Name = "Frmpapersource"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "مصدر الاوراق / المقام المرسل اليه"
        CType(Me.grdpapersource.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdpapersource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdpapersource As Telerik.WinControls.UI.RadGridView
End Class
