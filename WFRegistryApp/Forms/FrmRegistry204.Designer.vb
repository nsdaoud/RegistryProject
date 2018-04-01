<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistry204
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
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn3 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn17 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn18 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn19 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn4 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn20 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn21 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn22 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn23 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn24 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn25 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn26 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.btnexporttoexcel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnpapersource = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.tbr204 = New System.Windows.Forms.ToolBar()
        Me.tbrpapersource = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.tbrexporttoexcel = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.tbreport = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.tbdelete204 = New System.Windows.Forms.ToolBarButton()
        Me.RadGridView1 = New Telerik.WinControls.UI.MasterGridViewTemplate()
        Me.grdregistry204 = New Telerik.WinControls.UI.RadGridView()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdregistry204, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdregistry204.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnexporttoexcel
        '
        Me.btnexporttoexcel.Location = New System.Drawing.Point(448, 74)
        Me.btnexporttoexcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexporttoexcel.Name = "btnexporttoexcel"
        Me.btnexporttoexcel.Size = New System.Drawing.Size(205, 28)
        Me.btnexporttoexcel.TabIndex = 15
        Me.btnexporttoexcel.Text = "Export To Excel"
        Me.btnexporttoexcel.UseVisualStyleBackColor = True
        Me.btnexporttoexcel.Visible = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(16, 74)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(205, 28)
        Me.btnsave.TabIndex = 14
        Me.btnsave.Text = "حفظ \ تحديث البيانات"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnpapersource
        '
        Me.btnpapersource.Location = New System.Drawing.Point(229, 74)
        Me.btnpapersource.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpapersource.Name = "btnpapersource"
        Me.btnpapersource.Size = New System.Drawing.Size(205, 28)
        Me.btnpapersource.TabIndex = 12
        Me.btnpapersource.Text = "المصدر / المقام المرسل اليه"
        Me.btnpapersource.UseVisualStyleBackColor = True
        Me.btnpapersource.Visible = False
        '
        'btnreport
        '
        Me.btnreport.Location = New System.Drawing.Point(661, 74)
        Me.btnreport.Margin = New System.Windows.Forms.Padding(4)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(205, 28)
        Me.btnreport.TabIndex = 16
        Me.btnreport.Text = "تقرير"
        Me.btnreport.UseVisualStyleBackColor = True
        Me.btnreport.Visible = False
        '
        'tbr204
        '
        Me.tbr204.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbrpapersource, Me.ToolBarButton1, Me.tbrexporttoexcel, Me.ToolBarButton2, Me.tbreport, Me.ToolBarButton3, Me.tbdelete204})
        Me.tbr204.ButtonSize = New System.Drawing.Size(126, 40)
        Me.tbr204.DropDownArrows = True
        Me.tbr204.Location = New System.Drawing.Point(0, 0)
        Me.tbr204.Margin = New System.Windows.Forms.Padding(4)
        Me.tbr204.Name = "tbr204"
        Me.tbr204.ShowToolTips = True
        Me.tbr204.Size = New System.Drawing.Size(1023, 45)
        Me.tbr204.TabIndex = 17
        '
        'tbrpapersource
        '
        Me.tbrpapersource.Enabled = False
        Me.tbrpapersource.Name = "tbrpapersource"
        Me.tbrpapersource.Text = "المصدر / المقام المرسل اليه"
        Me.tbrpapersource.ToolTipText = "المصدر / المقام المرسل اليه"
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbrexporttoexcel
        '
        Me.tbrexporttoexcel.Enabled = False
        Me.tbrexporttoexcel.Name = "tbrexporttoexcel"
        Me.tbrexporttoexcel.Text = "Export To Excel"
        Me.tbrexporttoexcel.ToolTipText = "Export To Excel"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbreport
        '
        Me.tbreport.Enabled = False
        Me.tbreport.Name = "tbreport"
        Me.tbreport.Text = "تقرير"
        Me.tbreport.ToolTipText = "تقرير"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbdelete204
        '
        Me.tbdelete204.Enabled = False
        Me.tbdelete204.Name = "tbdelete204"
        Me.tbdelete204.Text = "Delete 204"
        Me.tbdelete204.ToolTipText = "Delete 204"
        Me.tbdelete204.Visible = False
        '
        'grdregistry204
        '
        Me.grdregistry204.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdregistry204.Location = New System.Drawing.Point(16, 110)
        Me.grdregistry204.Margin = New System.Windows.Forms.Padding(4)
        '
        'grdregistry204
        '
        GridViewTextBoxColumn14.FieldName = "Rowaction"
        GridViewTextBoxColumn14.HeaderText = "Rowaction"
        GridViewTextBoxColumn14.IsVisible = False
        GridViewTextBoxColumn14.Name = "Rowaction"
        GridViewTextBoxColumn15.FieldName = "id_204Registry"
        GridViewTextBoxColumn15.HeaderText = "id_204Registry"
        GridViewTextBoxColumn15.IsVisible = False
        GridViewTextBoxColumn15.Name = "id_204Registry"
        GridViewTextBoxColumn16.FieldName = "Registry_204Seq"
        GridViewTextBoxColumn16.HeaderText = "رقم المتسلسل"
        GridViewTextBoxColumn16.Name = "Registry_204Seq"
        GridViewTextBoxColumn16.ReadOnly = True
        GridViewDateTimeColumn3.CustomFormat = "dd/MM/yyyy"
        GridViewDateTimeColumn3.ExcelExportFormatString = "dd/MM/yyyy"
        GridViewDateTimeColumn3.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Custom
        GridViewDateTimeColumn3.FieldName = "Registry_204Date"
        GridViewDateTimeColumn3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        GridViewDateTimeColumn3.FormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn3.HeaderText = "تاريخ التسجيل"
        GridViewDateTimeColumn3.Name = "Registry_204Date"
        GridViewDateTimeColumn3.ReadOnly = True
        GridViewTextBoxColumn17.FieldName = "Registry_Description"
        GridViewTextBoxColumn17.HeaderText = "الموضوع"
        GridViewTextBoxColumn17.Name = "Registry_Description"
        GridViewTextBoxColumn17.WrapText = True
        GridViewTextBoxColumn18.FieldName = "DeliveredForDescription"
        GridViewTextBoxColumn18.HeaderText = "المقام المرسل اليه"
        GridViewTextBoxColumn18.IsVisible = False
        GridViewTextBoxColumn18.Name = "DeliveredForDescription"
        GridViewTextBoxColumn19.FieldName = "IncomingNumber"
        GridViewTextBoxColumn19.HeaderText = "رقم الوارد"
        GridViewTextBoxColumn19.Name = "IncomingNumber"
        GridViewDateTimeColumn4.CustomFormat = "dd/MM/yyyy"
        GridViewDateTimeColumn4.ExcelExportFormatString = "dd/MM/yyyy"
        GridViewDateTimeColumn4.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Custom
        GridViewDateTimeColumn4.FieldName = "IncomingDate"
        GridViewDateTimeColumn4.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        GridViewDateTimeColumn4.FormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn4.HeaderText = "تاريخ الورود"
        GridViewDateTimeColumn4.Name = "IncomingDate"
        GridViewTextBoxColumn20.FieldName = "id_User"
        GridViewTextBoxColumn20.HeaderText = "id_User"
        GridViewTextBoxColumn20.IsVisible = False
        GridViewTextBoxColumn20.Name = "id_User"
        GridViewTextBoxColumn21.FieldName = "UserLogin"
        GridViewTextBoxColumn21.HeaderText = "المستخدم"
        GridViewTextBoxColumn21.Name = "UserLogin"
        GridViewTextBoxColumn21.ReadOnly = True
        GridViewTextBoxColumn22.FieldName = "id_User2"
        GridViewTextBoxColumn22.HeaderText = "id_User2"
        GridViewTextBoxColumn22.IsVisible = False
        GridViewTextBoxColumn22.Name = "id_User2"
        GridViewTextBoxColumn23.FieldName = "UserLogin2"
        GridViewTextBoxColumn23.HeaderText = "المستخدم"
        GridViewTextBoxColumn23.Name = "UserLogin2"
        GridViewTextBoxColumn23.ReadOnly = True
        GridViewTextBoxColumn24.FieldName = "RegistryType"
        GridViewTextBoxColumn24.HeaderText = "RegistryType"
        GridViewTextBoxColumn24.IsVisible = False
        GridViewTextBoxColumn24.Name = "RegistryType"
        GridViewTextBoxColumn25.FieldName = "id_Registry206"
        GridViewTextBoxColumn25.HeaderText = "id_Registry206"
        GridViewTextBoxColumn25.IsVisible = False
        GridViewTextBoxColumn25.Name = "id_Registry206"
        GridViewTextBoxColumn26.FieldName = "type204"
        GridViewTextBoxColumn26.HeaderText = "type204"
        GridViewTextBoxColumn26.IsVisible = False
        GridViewTextBoxColumn26.Name = "type204"
        Me.grdregistry204.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn14, GridViewTextBoxColumn15, GridViewTextBoxColumn16, GridViewDateTimeColumn3, GridViewTextBoxColumn17, GridViewTextBoxColumn18, GridViewTextBoxColumn19, GridViewDateTimeColumn4, GridViewTextBoxColumn20, GridViewTextBoxColumn21, GridViewTextBoxColumn22, GridViewTextBoxColumn23, GridViewTextBoxColumn24, GridViewTextBoxColumn25, GridViewTextBoxColumn26})
        Me.grdregistry204.MasterTemplate.EnableFiltering = True
        Me.grdregistry204.Name = "grdregistry204"
        Me.grdregistry204.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.grdregistry204.Size = New System.Drawing.Size(991, 537)
        Me.grdregistry204.TabIndex = 18
        Me.grdregistry204.Text = "RadGridView2"
        '
        'FrmRegistry204
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 661)
        Me.Controls.Add(Me.grdregistry204)
        Me.Controls.Add(Me.tbr204)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnexporttoexcel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnpapersource)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmRegistry204"
        Me.Text = "السجل 204"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdregistry204.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdregistry204, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexporttoexcel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnpapersource As System.Windows.Forms.Button
    Friend WithEvents btnreport As System.Windows.Forms.Button
    Friend WithEvents tbr204 As System.Windows.Forms.ToolBar
    Friend WithEvents tbrpapersource As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrexporttoexcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbreport As System.Windows.Forms.ToolBarButton
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.MasterGridViewTemplate
    Friend WithEvents grdregistry204 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbdelete204 As System.Windows.Forms.ToolBarButton
End Class
