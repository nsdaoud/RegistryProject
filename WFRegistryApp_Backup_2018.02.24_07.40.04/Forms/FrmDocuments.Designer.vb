<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocuments
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
        Me.components = New System.ComponentModel.Container()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn2 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn12 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn13 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn14 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn15 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewImageColumn2 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
        Dim GridViewTextBoxColumn16 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.grddocuments = New Telerik.WinControls.UI.RadGridView()
        Me.btnloadfile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btndownload = New System.Windows.Forms.Button()
        Me.txtseqnumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnscan = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grddocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grddocuments.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grddocuments
        '
        Me.grddocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grddocuments.Location = New System.Drawing.Point(12, 95)
        '
        'grddocuments
        '
        GridViewTextBoxColumn9.FieldName = "id_Document"
        GridViewTextBoxColumn9.HeaderText = "id_Document"
        GridViewTextBoxColumn9.IsVisible = False
        GridViewTextBoxColumn9.Name = "id_Document"
        GridViewTextBoxColumn10.FieldName = "id_Registry"
        GridViewTextBoxColumn10.HeaderText = "id_Registry"
        GridViewTextBoxColumn10.IsVisible = False
        GridViewTextBoxColumn10.Name = "id_Registry"
        GridViewTextBoxColumn11.FieldName = "RegistryType"
        GridViewTextBoxColumn11.HeaderText = "RegistryType"
        GridViewTextBoxColumn11.IsVisible = False
        GridViewTextBoxColumn11.Name = "RegistryType"
        GridViewDateTimeColumn2.CustomFormat = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn2.DataEditFormatString = ""
        GridViewDateTimeColumn2.ExcelExportFormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn2.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Custom
        GridViewDateTimeColumn2.FieldName = "CreationDate"
        GridViewDateTimeColumn2.FormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn2.HeaderText = "تاريخ الملف"
        GridViewDateTimeColumn2.Name = "CreationDate"
        GridViewDateTimeColumn2.ReadOnly = True
        GridViewTextBoxColumn12.FieldName = "DocumentName"
        GridViewTextBoxColumn12.HeaderText = "الملف"
        GridViewTextBoxColumn12.Name = "DocumentName"
        GridViewTextBoxColumn13.FieldName = "DocumentDescription"
        GridViewTextBoxColumn13.HeaderText = "الملاحظات"
        GridViewTextBoxColumn13.Name = "DocumentDescription"
        GridViewTextBoxColumn14.FieldName = "Rowaction"
        GridViewTextBoxColumn14.HeaderText = "Rowaction"
        GridViewTextBoxColumn14.IsVisible = False
        GridViewTextBoxColumn14.Name = "Rowaction"
        GridViewTextBoxColumn15.FieldName = "fileName"
        GridViewTextBoxColumn15.HeaderText = "fileextensionName"
        GridViewTextBoxColumn15.IsVisible = False
        GridViewTextBoxColumn15.Name = "fileName"
        GridViewImageColumn2.FieldName = "attach"
        GridViewImageColumn2.HeaderText = ""
        GridViewImageColumn2.Name = "attach"
        GridViewTextBoxColumn16.FieldName = "SeqDocument"
        GridViewTextBoxColumn16.HeaderText = "SeqDocument"
        GridViewTextBoxColumn16.IsVisible = False
        GridViewTextBoxColumn16.Name = "SeqDocument"
        Me.grddocuments.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewTextBoxColumn11, GridViewDateTimeColumn2, GridViewTextBoxColumn12, GridViewTextBoxColumn13, GridViewTextBoxColumn14, GridViewTextBoxColumn15, GridViewImageColumn2, GridViewTextBoxColumn16})
        Me.grddocuments.MasterTemplate.EnableFiltering = True
        Me.grddocuments.Name = "grddocuments"
        Me.grddocuments.Size = New System.Drawing.Size(689, 360)
        Me.grddocuments.TabIndex = 0
        Me.grddocuments.Text = "RadGridView1"
        '
        'btnloadfile
        '
        Me.btnloadfile.Location = New System.Drawing.Point(202, 41)
        Me.btnloadfile.Name = "btnloadfile"
        Me.btnloadfile.Size = New System.Drawing.Size(89, 23)
        Me.btnloadfile.TabIndex = 1
        Me.btnloadfile.Text = "تحميل الملف"
        Me.btnloadfile.UseVisualStyleBackColor = True
        Me.btnloadfile.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btndownload
        '
        Me.btndownload.Location = New System.Drawing.Point(107, 12)
        Me.btndownload.Name = "btndownload"
        Me.btndownload.Size = New System.Drawing.Size(89, 23)
        Me.btndownload.TabIndex = 2
        Me.btndownload.Text = "تنزيل الملف"
        Me.btndownload.UseVisualStyleBackColor = True
        '
        'txtseqnumber
        '
        Me.txtseqnumber.Enabled = False
        Me.txtseqnumber.Location = New System.Drawing.Point(329, 14)
        Me.txtseqnumber.Name = "txtseqnumber"
        Me.txtseqnumber.Size = New System.Drawing.Size(287, 20)
        Me.txtseqnumber.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(622, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "رقم المتسلسل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnscan
        '
        Me.btnscan.Location = New System.Drawing.Point(202, 11)
        Me.btnscan.Name = "btnscan"
        Me.btnscan.Size = New System.Drawing.Size(89, 23)
        Me.btnscan.TabIndex = 5
        Me.btnscan.Text = "scan"
        Me.btnscan.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "تحميل الملف"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 467)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnscan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtseqnumber)
        Me.Controls.Add(Me.btndownload)
        Me.Controls.Add(Me.btnloadfile)
        Me.Controls.Add(Me.grddocuments)
        Me.Name = "FrmDocuments"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "الملفات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grddocuments.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grddocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grddocuments As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btnloadfile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btndownload As System.Windows.Forms.Button
    Friend WithEvents txtseqnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnscan As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
