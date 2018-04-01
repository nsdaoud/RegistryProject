<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmregistrywallet
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
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.btnexporttoexcel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.tbrregister206 = New System.Windows.Forms.ToolBar()
        Me.tbrreport = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.tbrexporttoexcel = New System.Windows.Forms.ToolBarButton()
        Me.grdregistrywallet = New Telerik.WinControls.UI.RadGridView()
        CType(Me.grdregistrywallet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdregistrywallet.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnexporttoexcel
        '
        Me.btnexporttoexcel.Location = New System.Drawing.Point(172, 57)
        Me.btnexporttoexcel.Name = "btnexporttoexcel"
        Me.btnexporttoexcel.Size = New System.Drawing.Size(154, 23)
        Me.btnexporttoexcel.TabIndex = 13
        Me.btnexporttoexcel.Text = "Export To Excel"
        Me.btnexporttoexcel.UseVisualStyleBackColor = True
        Me.btnexporttoexcel.Visible = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(12, 57)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(154, 23)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "حفظ \ تحديث البيانات"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'tbrregister206
        '
        Me.tbrregister206.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbrreport, Me.ToolBarButton2, Me.tbrexporttoexcel})
        Me.tbrregister206.ButtonSize = New System.Drawing.Size(126, 40)
        Me.tbrregister206.DropDownArrows = True
        Me.tbrregister206.Location = New System.Drawing.Point(0, 0)
        Me.tbrregister206.Name = "tbrregister206"
        Me.tbrregister206.ShowToolTips = True
        Me.tbrregister206.Size = New System.Drawing.Size(719, 42)
        Me.tbrregister206.TabIndex = 15
        '
        'tbrreport
        '
        Me.tbrreport.Name = "tbrreport"
        Me.tbrreport.Text = "تقرير المحفظة"
        Me.tbrreport.ToolTipText = "تقرير 206"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbrexporttoexcel
        '
        Me.tbrexporttoexcel.Name = "tbrexporttoexcel"
        Me.tbrexporttoexcel.Text = "Export To Excel"
        Me.tbrexporttoexcel.ToolTipText = "Export To Excel"
        '
        'grdregistrywallet
        '
        Me.grdregistrywallet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdregistrywallet.Location = New System.Drawing.Point(15, 86)
        '
        'grdregistrywallet
        '
        GridViewTextBoxColumn1.FieldName = "Rowaction"
        GridViewTextBoxColumn1.HeaderText = "Rowaction"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "Rowaction"
        GridViewDateTimeColumn1.CustomFormat = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn1.ExcelExportFormatString = "dd/MM/yyyy"
        GridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Custom
        GridViewDateTimeColumn1.FieldName = "RegistryWalletDate"
        GridViewDateTimeColumn1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        GridViewDateTimeColumn1.FormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn1.HeaderText = "التاريخ"
        GridViewDateTimeColumn1.Name = "RegistryWalletDate"
        GridViewTextBoxColumn2.FieldName = "RegistryWalletSeq"
        GridViewTextBoxColumn2.HeaderText = "الرقم متسلسل"
        GridViewTextBoxColumn2.Name = "RegistryWalletSeq"
        GridViewTextBoxColumn2.ReadOnly = True
        GridViewTextBoxColumn3.FieldName = "RWPapernumber"
        GridViewTextBoxColumn3.HeaderText = "رقم الاوراق"
        GridViewTextBoxColumn3.Name = "RWPapernumber"
        GridViewTextBoxColumn3.WrapText = True
        GridViewDateTimeColumn2.CustomFormat = "dd/MM/yyyy"
        GridViewDateTimeColumn2.ExcelExportFormatString = "dd/MM/yyyy"
        GridViewDateTimeColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Custom
        GridViewDateTimeColumn2.FieldName = "RWPaperdate"
        GridViewDateTimeColumn2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        GridViewDateTimeColumn2.FormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn2.HeaderText = "تاريخ الاوراق"
        GridViewDateTimeColumn2.Name = "RWPaperdate"
        GridViewTextBoxColumn4.FieldName = "RWSubject"
        GridViewTextBoxColumn4.HeaderText = "الموضوع"
        GridViewTextBoxColumn4.Name = "RWSubject"
        GridViewTextBoxColumn4.WrapText = True
        GridViewTextBoxColumn5.FieldName = "RWComments"
        GridViewTextBoxColumn5.HeaderText = "ملاحظات"
        GridViewTextBoxColumn5.Name = "RWComments"
        GridViewTextBoxColumn5.WrapText = True
        GridViewTextBoxColumn6.FieldName = "UserLogin"
        GridViewTextBoxColumn6.HeaderText = "المستخدم"
        GridViewTextBoxColumn6.Name = "UserLogin"
        GridViewTextBoxColumn6.ReadOnly = True
        GridViewTextBoxColumn7.FieldName = "id_User"
        GridViewTextBoxColumn7.HeaderText = "id_User"
        GridViewTextBoxColumn7.IsVisible = False
        GridViewTextBoxColumn7.Name = "id_User"
        Me.grdregistrywallet.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewDateTimeColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDateTimeColumn2, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7})
        Me.grdregistrywallet.MasterTemplate.EnableFiltering = True
        Me.grdregistrywallet.Name = "grdregistrywallet"
        Me.grdregistrywallet.Size = New System.Drawing.Size(689, 375)
        Me.grdregistrywallet.TabIndex = 17
        Me.grdregistrywallet.Text = "RadGridView1"
        '
        'frmregistrywallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 473)
        Me.Controls.Add(Me.grdregistrywallet)
        Me.Controls.Add(Me.tbrregister206)
        Me.Controls.Add(Me.btnexporttoexcel)
        Me.Controls.Add(Me.btnsave)
        Me.Name = "frmregistrywallet"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "المحفظة"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdregistrywallet.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdregistrywallet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnexporttoexcel As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents tbrregister206 As System.Windows.Forms.ToolBar
    Friend WithEvents tbrreport As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbrexporttoexcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents grdregistrywallet As Telerik.WinControls.UI.RadGridView
End Class
