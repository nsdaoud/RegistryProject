<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmwaredfax304
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
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.grdwaredfax304 = New Telerik.WinControls.UI.RadGridView()
        CType(Me.grdwaredfax304, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdwaredfax304.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdwaredfax304
        '
        Me.grdwaredfax304.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdwaredfax304.Location = New System.Drawing.Point(9, 56)
        Me.grdwaredfax304.Margin = New System.Windows.Forms.Padding(4)
        '
        'grdwaredfax304
        '
        GridViewTextBoxColumn1.FieldName = "id_304waredfax"
        GridViewTextBoxColumn1.HeaderText = "id_304waredfax"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "id_304waredfax"
        GridViewTextBoxColumn2.FieldName = "waredfax304_seq"
        GridViewTextBoxColumn2.HeaderText = "الرقم المتسلسل"
        GridViewTextBoxColumn2.Name = "waredfax304_seq"
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn3.FieldName = "waredfax304Destination"
        GridViewTextBoxColumn3.HeaderText = "محل إيداع الأوراق"
        GridViewTextBoxColumn3.Name = "waredfax304Destination"
        GridViewDateTimeColumn1.FieldName = "waredfax304_Date"
        GridViewDateTimeColumn1.HeaderText = "تاريخها"
        GridViewDateTimeColumn1.Name = "waredfax304_Date"
        GridViewTextBoxColumn4.FieldName = "waredfax304_Number"
        GridViewTextBoxColumn4.HeaderText = "رقمها"
        GridViewTextBoxColumn4.Name = "waredfax304_Number"
        GridViewTextBoxColumn5.FieldName = "marboutatnumber"
        GridViewTextBoxColumn5.HeaderText = "عدد المربوطات"
        GridViewTextBoxColumn5.Name = "marboutatnumber"
        GridViewTextBoxColumn6.FieldName = "waredfax304_Note"
        GridViewTextBoxColumn6.HeaderText = "ملاحظات"
        GridViewTextBoxColumn6.Name = "waredfax304_Note"
        GridViewTextBoxColumn6.WrapText = True
        GridViewTextBoxColumn7.FieldName = "CreationUser"
        GridViewTextBoxColumn7.HeaderText = "Created By"
        GridViewTextBoxColumn7.Name = "CreationUser"
        GridViewTextBoxColumn7.ReadOnly = True
        GridViewTextBoxColumn8.FieldName = "UpdateUser"
        GridViewTextBoxColumn8.HeaderText = "Updated By"
        GridViewTextBoxColumn8.Name = "UpdateUser"
        GridViewTextBoxColumn8.ReadOnly = True
        Me.grdwaredfax304.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDateTimeColumn1, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8})
        Me.grdwaredfax304.MasterTemplate.EnableFiltering = True
        Me.grdwaredfax304.Name = "grdwaredfax304"
        Me.grdwaredfax304.Size = New System.Drawing.Size(919, 557)
        Me.grdwaredfax304.TabIndex = 1
        Me.grdwaredfax304.Text = "RadGridView1"
        '
        'Frmwaredfax304
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 626)
        Me.Controls.Add(Me.grdwaredfax304)
        Me.Name = "Frmwaredfax304"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "وارد فاكس 304 "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdwaredfax304.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdwaredfax304, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdwaredfax304 As Telerik.WinControls.UI.RadGridView
End Class
