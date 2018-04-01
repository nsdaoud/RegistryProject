<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemsCategory
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
        Me.grditemcategory = New Telerik.WinControls.UI.RadGridView()
        Me.btnitems = New System.Windows.Forms.Button()
        CType(Me.grditemcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grditemcategory.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grditemcategory
        '
        Me.grditemcategory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grditemcategory.Location = New System.Drawing.Point(12, 35)
        '
        'grditemcategory
        '
        Me.grditemcategory.MasterTemplate.AllowCellContextMenu = False
        Me.grditemcategory.MasterTemplate.AllowDeleteRow = False
        GridViewTextBoxColumn1.FieldName = "id_ItemCategory"
        GridViewTextBoxColumn1.HeaderText = "id_PaperSource"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "id_ItemCategory"
        GridViewTextBoxColumn2.FieldName = "descriptionItemCategory"
        GridViewTextBoxColumn2.HeaderText = "نوع المواد"
        GridViewTextBoxColumn2.Name = "descriptionItemCategory"
        GridViewTextBoxColumn3.FieldName = "Rowaction"
        GridViewTextBoxColumn3.HeaderText = "Rowaction"
        GridViewTextBoxColumn3.IsVisible = False
        GridViewTextBoxColumn3.Name = "Rowaction"
        Me.grditemcategory.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
        Me.grditemcategory.MasterTemplate.EnableFiltering = True
        Me.grditemcategory.Name = "grditemcategory"
        Me.grditemcategory.Size = New System.Drawing.Size(723, 413)
        Me.grditemcategory.TabIndex = 6
        Me.grditemcategory.Text = "RadGridView1"
        '
        'btnitems
        '
        Me.btnitems.Location = New System.Drawing.Point(12, 6)
        Me.btnitems.Name = "btnitems"
        Me.btnitems.Size = New System.Drawing.Size(116, 23)
        Me.btnitems.TabIndex = 7
        Me.btnitems.Text = "البضاعة"
        Me.btnitems.UseVisualStyleBackColor = True
        '
        'FrmItemsCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 460)
        Me.Controls.Add(Me.btnitems)
        Me.Controls.Add(Me.grditemcategory)
        Me.Name = "FrmItemsCategory"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "Items Category"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grditemcategory.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grditemcategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grditemcategory As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnitems As System.Windows.Forms.Button
End Class
