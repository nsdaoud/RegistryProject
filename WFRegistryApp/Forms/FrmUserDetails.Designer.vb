<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserDetails
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
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCheckBoxColumn2 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCheckBoxColumn3 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewCheckBoxColumn4 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn17 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn18 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCheckBoxColumn5 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewMaskBoxColumn1 As Telerik.WinControls.UI.GridViewMaskBoxColumn = New Telerik.WinControls.UI.GridViewMaskBoxColumn()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnuserprivilege = New System.Windows.Forms.Button()
        Me.RadGridView1 = New Telerik.WinControls.UI.MasterGridViewTemplate()
        Me.grduserinformation = New Telerik.WinControls.UI.MasterGridViewTemplate()
        Me.grduserdetails = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grduserinformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grduserdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grduserdetails.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(93, 12)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "حفظ"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(12, 12)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "حذف"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnuserprivilege
        '
        Me.btnuserprivilege.Location = New System.Drawing.Point(174, 12)
        Me.btnuserprivilege.Name = "btnuserprivilege"
        Me.btnuserprivilege.Size = New System.Drawing.Size(124, 23)
        Me.btnuserprivilege.TabIndex = 3
        Me.btnuserprivilege.Text = "User Privileges"
        Me.btnuserprivilege.UseVisualStyleBackColor = True
        '
        'RadGridView1
        '
        GridViewTextBoxColumn1.FieldName = "id_User"
        GridViewTextBoxColumn1.HeaderText = "id_User"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "id_User"
        GridViewTextBoxColumn2.FieldName = "UserName"
        GridViewTextBoxColumn2.HeaderText = "UserName"
        GridViewTextBoxColumn2.Name = "UserName"
        GridViewTextBoxColumn3.FieldName = "UserLastName"
        GridViewTextBoxColumn3.HeaderText = "UserLastName"
        GridViewTextBoxColumn3.Name = "UserLastName"
        GridViewTextBoxColumn4.FieldName = "UserLogin"
        GridViewTextBoxColumn4.HeaderText = "UserLogin"
        GridViewTextBoxColumn4.Name = "UserLogin"
        GridViewTextBoxColumn5.FieldName = "UserPassword"
        GridViewTextBoxColumn5.HeaderText = "UserPassword"
        GridViewTextBoxColumn5.Name = "UserPassword"
        GridViewCheckBoxColumn1.FieldName = "isAdmin"
        GridViewCheckBoxColumn1.HeaderText = "مشرف"
        GridViewCheckBoxColumn1.Name = "isAdmin"
        GridViewTextBoxColumn6.FieldName = "Rowaction"
        GridViewTextBoxColumn6.HeaderText = "Rowaction"
        GridViewTextBoxColumn6.IsVisible = False
        GridViewTextBoxColumn6.Name = "Rowaction"
        Me.RadGridView1.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewCheckBoxColumn1, GridViewTextBoxColumn6})
        Me.RadGridView1.EnableFiltering = True
        '
        'grduserinformation
        '
        Me.grduserinformation.AllowCellContextMenu = False
        Me.grduserinformation.AllowDeleteRow = False
        GridViewTextBoxColumn7.FieldName = "id_User"
        GridViewTextBoxColumn7.HeaderText = "id_User"
        GridViewTextBoxColumn7.IsVisible = False
        GridViewTextBoxColumn7.Name = "id_User"
        GridViewTextBoxColumn8.FieldName = "UserName"
        GridViewTextBoxColumn8.HeaderText = "الاسم"
        GridViewTextBoxColumn8.Name = "UserName"
        GridViewTextBoxColumn9.FieldName = "UserLastName"
        GridViewTextBoxColumn9.HeaderText = "العائلة"
        GridViewTextBoxColumn9.Name = "UserLastName"
        GridViewTextBoxColumn10.FieldName = "UserLogin"
        GridViewTextBoxColumn10.HeaderText = "المستخدم"
        GridViewTextBoxColumn10.Name = "UserLogin"
        GridViewTextBoxColumn11.FieldName = "UserPassword"
        GridViewTextBoxColumn11.FormatString = "*****"
        GridViewTextBoxColumn11.HeaderText = "كلمة السر"
        GridViewTextBoxColumn11.Name = "UserPassword"
        GridViewCheckBoxColumn2.FieldName = "isAdmin"
        GridViewCheckBoxColumn2.HeaderText = "مشرف"
        GridViewCheckBoxColumn2.Name = "isAdmin"
        GridViewTextBoxColumn12.FieldName = "Rowaction"
        GridViewTextBoxColumn12.HeaderText = "Rowaction"
        GridViewTextBoxColumn12.IsVisible = False
        GridViewTextBoxColumn12.Name = "Rowaction"
        GridViewCheckBoxColumn3.FieldName = "isVisitor"
        GridViewCheckBoxColumn3.HeaderText = "يقرأ فقط"
        GridViewCheckBoxColumn3.Name = "isVisitor"
        GridViewCheckBoxColumn4.FieldName = "isUser"
        GridViewCheckBoxColumn4.HeaderText = "موظف"
        GridViewCheckBoxColumn4.Name = "isUser"
        Me.grduserinformation.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewCheckBoxColumn2, GridViewTextBoxColumn12, GridViewCheckBoxColumn3, GridViewCheckBoxColumn4})
        Me.grduserinformation.EnableCustomFiltering = True
        Me.grduserinformation.EnableFiltering = True
        Me.grduserinformation.EnableGrouping = False
        Me.grduserinformation.EnableSorting = False
        '
        'grduserdetails
        '
        Me.grduserdetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grduserdetails.Location = New System.Drawing.Point(12, 41)
        '
        'grduserdetails
        '
        Me.grduserdetails.MasterTemplate.AllowCellContextMenu = False
        Me.grduserdetails.MasterTemplate.AllowDeleteRow = False
        GridViewTextBoxColumn13.FieldName = "Rowaction"
        GridViewTextBoxColumn13.HeaderText = "Rowaction"
        GridViewTextBoxColumn13.IsVisible = False
        GridViewTextBoxColumn13.Name = "Rowaction"
        GridViewTextBoxColumn14.FieldName = "id_User"
        GridViewTextBoxColumn14.HeaderText = "id_User"
        GridViewTextBoxColumn14.IsVisible = False
        GridViewTextBoxColumn14.Name = "id_User"
        GridViewTextBoxColumn15.FieldName = "UserName"
        GridViewTextBoxColumn15.HeaderText = "الاسم"
        GridViewTextBoxColumn15.Name = "UserName"
        GridViewTextBoxColumn16.FieldName = "UserLastName"
        GridViewTextBoxColumn16.HeaderText = "الشهرة"
        GridViewTextBoxColumn16.Name = "UserLastName"
        GridViewTextBoxColumn17.FieldName = "UserLogin"
        GridViewTextBoxColumn17.HeaderText = "المستخدم"
        GridViewTextBoxColumn17.Name = "UserLogin"
        GridViewTextBoxColumn18.FieldName = "UserPassword"
        GridViewTextBoxColumn18.FormatString = "*****"
        GridViewTextBoxColumn18.HeaderText = "كلمة السر"
        GridViewTextBoxColumn18.Name = "UserPassword"
        GridViewCheckBoxColumn5.FieldName = "isAdmin"
        GridViewCheckBoxColumn5.HeaderText = "مشرف"
        GridViewCheckBoxColumn5.Name = "isAdmin"
        GridViewMaskBoxColumn1.HeaderText = "column1"
        GridViewMaskBoxColumn1.Name = "column1"
        Me.grduserdetails.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn13, GridViewTextBoxColumn14, GridViewTextBoxColumn15, GridViewTextBoxColumn16, GridViewTextBoxColumn17, GridViewTextBoxColumn18, GridViewCheckBoxColumn5, GridViewMaskBoxColumn1})
        Me.grduserdetails.MasterTemplate.EnableFiltering = True
        Me.grduserdetails.Name = "grduserdetails"
        Me.grduserdetails.Size = New System.Drawing.Size(752, 409)
        Me.grduserdetails.TabIndex = 6
        Me.grduserdetails.Text = "RadGridView1"
        '
        'FrmUserDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 462)
        Me.Controls.Add(Me.grduserdetails)
        Me.Controls.Add(Me.btnuserprivilege)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Name = "FrmUserDetails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "المستخدم"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grduserinformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grduserdetails.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grduserdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnuserprivilege As System.Windows.Forms.Button
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.MasterGridViewTemplate
    Friend WithEvents grduserinformation As Telerik.WinControls.UI.MasterGridViewTemplate
    Friend WithEvents grduserdetails As Telerik.WinControls.UI.RadGridView

End Class
