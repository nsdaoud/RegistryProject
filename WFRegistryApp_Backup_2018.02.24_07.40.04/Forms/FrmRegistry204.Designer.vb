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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
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
        GridViewTextBoxColumn1.FieldName = "Rowaction"
        GridViewTextBoxColumn1.HeaderText = "Rowaction"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "Rowaction"
        GridViewTextBoxColumn2.FieldName = "id_204Registry"
        GridViewTextBoxColumn2.HeaderText = "id_204Registry"
        GridViewTextBoxColumn2.IsVisible = False
        GridViewTextBoxColumn2.Name = "id_204Registry"
        GridViewTextBoxColumn3.FieldName = "Registry_204Seq"
        GridViewTextBoxColumn3.HeaderText = "رقم المتسلسل"
        GridViewTextBoxColumn3.Name = "Registry_204Seq"
        GridViewTextBoxColumn3.ReadOnly = True
        GridViewDateTimeColumn1.CustomFormat = "dd/MM/yyyy"
        GridViewDateTimeColumn1.ExcelExportFormatString = "dd/MM/yyyy"
        GridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Custom
        GridViewDateTimeColumn1.FieldName = "Registry_204Date"
        GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        GridViewDateTimeColumn1.FormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn1.HeaderText = "تاريخ التسجيل"
        GridViewDateTimeColumn1.Name = "Registry_204Date"
        GridViewDateTimeColumn1.ReadOnly = True
        GridViewTextBoxColumn4.FieldName = "Registry_Description"
        GridViewTextBoxColumn4.HeaderText = "الموضوع"
        GridViewTextBoxColumn4.Name = "Registry_Description"
        GridViewTextBoxColumn4.WrapText = True
        GridViewTextBoxColumn5.FieldName = "DeliveredForDescription"
        GridViewTextBoxColumn5.HeaderText = "المقام المرسل اليه"
        GridViewTextBoxColumn5.IsVisible = False
        GridViewTextBoxColumn5.Name = "DeliveredForDescription"
        GridViewTextBoxColumn6.FieldName = "IncomingNumber"
        GridViewTextBoxColumn6.HeaderText = "رقم الوارد"
        GridViewTextBoxColumn6.Name = "IncomingNumber"
        GridViewDateTimeColumn2.CustomFormat = "dd/MM/yyyy"
        GridViewDateTimeColumn2.ExcelExportFormatString = "dd/MM/yyyy"
        GridViewDateTimeColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Custom
        GridViewDateTimeColumn2.FieldName = "IncomingDate"
        GridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        GridViewDateTimeColumn2.FormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn2.HeaderText = "تاريخ الورود"
        GridViewDateTimeColumn2.Name = "IncomingDate"
        GridViewTextBoxColumn7.FieldName = "id_User"
        GridViewTextBoxColumn7.HeaderText = "id_User"
        GridViewTextBoxColumn7.IsVisible = False
        GridViewTextBoxColumn7.Name = "id_User"
        GridViewTextBoxColumn8.FieldName = "UserLogin"
        GridViewTextBoxColumn8.HeaderText = "المستخدم"
        GridViewTextBoxColumn8.Name = "UserLogin"
        GridViewTextBoxColumn8.ReadOnly = True
        GridViewTextBoxColumn9.FieldName = "id_User2"
        GridViewTextBoxColumn9.HeaderText = "id_User2"
        GridViewTextBoxColumn9.IsVisible = False
        GridViewTextBoxColumn9.Name = "id_User2"
        GridViewTextBoxColumn10.FieldName = "UserLogin2"
        GridViewTextBoxColumn10.HeaderText = "المستخدم"
        GridViewTextBoxColumn10.Name = "UserLogin2"
        GridViewTextBoxColumn10.ReadOnly = True
        GridViewTextBoxColumn11.FieldName = "RegistryType"
        GridViewTextBoxColumn11.HeaderText = "RegistryType"
        GridViewTextBoxColumn11.IsVisible = False
        GridViewTextBoxColumn11.Name = "RegistryType"
        GridViewTextBoxColumn12.FieldName = "id_Registry206"
        GridViewTextBoxColumn12.HeaderText = "id_Registry206"
        GridViewTextBoxColumn12.IsVisible = False
        GridViewTextBoxColumn12.Name = "id_Registry206"
        GridViewTextBoxColumn13.FieldName = "type204"
        GridViewTextBoxColumn13.HeaderText = "type204"
        GridViewTextBoxColumn13.IsVisible = False
        GridViewTextBoxColumn13.Name = "type204"
        Me.grdregistry204.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDateTimeColumn1, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewDateTimeColumn2, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewTextBoxColumn12, GridViewTextBoxColumn13})
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
