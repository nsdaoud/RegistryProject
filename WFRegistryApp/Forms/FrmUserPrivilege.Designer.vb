<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserPrivilege
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
        Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCheckBoxColumn2 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewCheckBoxColumn3 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Me.grduserprivilege = New Telerik.WinControls.UI.RadGridView()
        Me.btndelete = New System.Windows.Forms.Button()
        CType(Me.grduserprivilege, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grduserprivilege.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grduserprivilege
        '
        Me.grduserprivilege.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grduserprivilege.EnableCustomFiltering = True
        Me.grduserprivilege.EnableGestures = False
        Me.grduserprivilege.EnableHotTracking = False
        Me.grduserprivilege.EnableTheming = False
        Me.grduserprivilege.Location = New System.Drawing.Point(18, 41)
        '
        'grduserprivilege
        '
        Me.grduserprivilege.MasterTemplate.AllowCellContextMenu = False
        Me.grduserprivilege.MasterTemplate.AllowDeleteRow = False
        GridViewTextBoxColumn1.FieldName = "Rowaction"
        GridViewTextBoxColumn1.HeaderText = "Rowaction"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "Rowaction"
        GridViewTextBoxColumn2.FieldName = "id_MenuUserPrivileges"
        GridViewTextBoxColumn2.HeaderText = "id_MenuUserPrivileges"
        GridViewTextBoxColumn2.IsVisible = False
        GridViewTextBoxColumn2.Name = "id_MenuUserPrivileges"
        GridViewCheckBoxColumn1.FieldName = "UserPrivilegeReadOnly"
        GridViewCheckBoxColumn1.HeaderText = "ReadOnly"
        GridViewCheckBoxColumn1.Name = "UserPrivilegeReadOnly"
        GridViewTextBoxColumn3.FieldName = "id_User"
        GridViewTextBoxColumn3.HeaderText = "id_User"
        GridViewTextBoxColumn3.IsVisible = False
        GridViewTextBoxColumn3.Name = "id_User"
        GridViewCheckBoxColumn2.FieldName = "isEditable"
        GridViewCheckBoxColumn2.HeaderText = "Can Modify"
        GridViewCheckBoxColumn2.Name = "isEditable"
        GridViewCheckBoxColumn3.FieldName = "canCreate"
        GridViewCheckBoxColumn3.HeaderText = "Can Create"
        GridViewCheckBoxColumn3.Name = "canCreate"
        Me.grduserprivilege.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewCheckBoxColumn1, GridViewTextBoxColumn3, GridViewCheckBoxColumn2, GridViewCheckBoxColumn3})
        Me.grduserprivilege.MasterTemplate.EnableCustomFiltering = True
        Me.grduserprivilege.MasterTemplate.EnableFiltering = True
        Me.grduserprivilege.MasterTemplate.EnableGrouping = False
        Me.grduserprivilege.MasterTemplate.EnableSorting = False
        Me.grduserprivilege.Name = "grduserprivilege"
        Me.grduserprivilege.ShowItemToolTips = False
        Me.grduserprivilege.Size = New System.Drawing.Size(658, 454)
        Me.grduserprivilege.TabIndex = 1
        Me.grduserprivilege.Text = "RadGridView1"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(18, 12)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 3
        Me.btndelete.Text = "حذف"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'FrmUserPrivilege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 507)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.grduserprivilege)
        Me.Name = "FrmUserPrivilege"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "امتياز المستخدم"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grduserprivilege.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grduserprivilege, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grduserprivilege As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btndelete As System.Windows.Forms.Button
End Class
