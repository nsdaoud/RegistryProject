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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn = New Telerik.WinControls.UI.GridViewDateTimeColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewImageColumn1 As Telerik.WinControls.UI.GridViewImageColumn = New Telerik.WinControls.UI.GridViewImageColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Me.grddocuments = New Telerik.WinControls.UI.RadGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btndownload = New System.Windows.Forms.Button()
        Me.txtseqnumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnscan = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnloadfile = New System.Windows.Forms.Button()
        Me.btnloadfile2 = New System.Windows.Forms.Button()
        CType(Me.grddocuments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grddocuments.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grddocuments.SuspendLayout()
        Me.SuspendLayout()
        '
        'grddocuments
        '
        Me.grddocuments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grddocuments.Controls.Add(Me.btnloadfile2)
        Me.grddocuments.Location = New System.Drawing.Point(16, 51)
        Me.grddocuments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'grddocuments
        '
        GridViewTextBoxColumn1.FieldName = "id_Document"
        GridViewTextBoxColumn1.HeaderText = "id_Document"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "id_Document"
        GridViewTextBoxColumn2.FieldName = "id_Registry"
        GridViewTextBoxColumn2.HeaderText = "id_Registry"
        GridViewTextBoxColumn2.IsVisible = False
        GridViewTextBoxColumn2.Name = "id_Registry"
        GridViewTextBoxColumn3.FieldName = "RegistryType"
        GridViewTextBoxColumn3.HeaderText = "RegistryType"
        GridViewTextBoxColumn3.IsVisible = False
        GridViewTextBoxColumn3.Name = "RegistryType"
        GridViewDateTimeColumn1.CustomFormat = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn1.ExcelExportFormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn1.ExcelExportType = Telerik.WinControls.UI.Export.DisplayFormatType.Custom
        GridViewDateTimeColumn1.FieldName = "CreationDate"
        GridViewDateTimeColumn1.FormatString = "{0:dd/MM/yyyy}"
        GridViewDateTimeColumn1.HeaderText = "تاريخ الملف"
        GridViewDateTimeColumn1.Name = "CreationDate"
        GridViewDateTimeColumn1.ReadOnly = True
        GridViewTextBoxColumn4.FieldName = "DocumentName"
        GridViewTextBoxColumn4.HeaderText = "الملف"
        GridViewTextBoxColumn4.Name = "DocumentName"
        GridViewTextBoxColumn5.FieldName = "DocumentDescription"
        GridViewTextBoxColumn5.HeaderText = "الملاحظات"
        GridViewTextBoxColumn5.Name = "DocumentDescription"
        GridViewTextBoxColumn6.FieldName = "Rowaction"
        GridViewTextBoxColumn6.HeaderText = "Rowaction"
        GridViewTextBoxColumn6.IsVisible = False
        GridViewTextBoxColumn6.Name = "Rowaction"
        GridViewTextBoxColumn7.FieldName = "fileName"
        GridViewTextBoxColumn7.HeaderText = "fileextensionName"
        GridViewTextBoxColumn7.IsVisible = False
        GridViewTextBoxColumn7.Name = "fileName"
        GridViewImageColumn1.FieldName = "attach"
        GridViewImageColumn1.HeaderText = ""
        GridViewImageColumn1.Name = "attach"
        GridViewTextBoxColumn8.FieldName = "SeqDocument"
        GridViewTextBoxColumn8.HeaderText = "SeqDocument"
        GridViewTextBoxColumn8.IsVisible = False
        GridViewTextBoxColumn8.Name = "SeqDocument"
        Me.grddocuments.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewDateTimeColumn1, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewImageColumn1, GridViewTextBoxColumn8})
        Me.grddocuments.MasterTemplate.EnableFiltering = True
        Me.grddocuments.Name = "grddocuments"
        Me.grddocuments.Size = New System.Drawing.Size(919, 509)
        Me.grddocuments.TabIndex = 0
        Me.grddocuments.Text = "RadGridView1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btndownload
        '
        Me.btndownload.Location = New System.Drawing.Point(143, 15)
        Me.btndownload.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btndownload.Name = "btndownload"
        Me.btndownload.Size = New System.Drawing.Size(119, 28)
        Me.btndownload.TabIndex = 2
        Me.btndownload.Text = "تنزيل الملف"
        Me.btndownload.UseVisualStyleBackColor = True
        '
        'txtseqnumber
        '
        Me.txtseqnumber.Enabled = False
        Me.txtseqnumber.Location = New System.Drawing.Point(439, 17)
        Me.txtseqnumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtseqnumber.Name = "txtseqnumber"
        Me.txtseqnumber.Size = New System.Drawing.Size(381, 22)
        Me.txtseqnumber.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(829, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "رقم المتسلسل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnscan
        '
        Me.btnscan.Location = New System.Drawing.Point(269, 14)
        Me.btnscan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnscan.Name = "btnscan"
        Me.btnscan.Size = New System.Drawing.Size(119, 28)
        Me.btnscan.TabIndex = 5
        Me.btnscan.Text = "scan"
        Me.btnscan.UseVisualStyleBackColor = True
        '
        'btnloadfile
        '
        Me.btnloadfile.Location = New System.Drawing.Point(16, 15)
        Me.btnloadfile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnloadfile.Name = "btnloadfile"
        Me.btnloadfile.Size = New System.Drawing.Size(119, 28)
        Me.btnloadfile.TabIndex = 6
        Me.btnloadfile.Text = "تحميل الملف"
        Me.btnloadfile.UseVisualStyleBackColor = True
        '
        'btnloadfile2
        '
        Me.btnloadfile2.Location = New System.Drawing.Point(531, 268)
        Me.btnloadfile2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnloadfile2.Name = "btnloadfile2"
        Me.btnloadfile2.Size = New System.Drawing.Size(119, 28)
        Me.btnloadfile2.TabIndex = 1
        Me.btnloadfile2.Text = "تحميل الملف"
        Me.btnloadfile2.UseVisualStyleBackColor = True
        Me.btnloadfile2.Visible = False
        '
        'FrmDocuments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 575)
        Me.Controls.Add(Me.btnloadfile)
        Me.Controls.Add(Me.btnscan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtseqnumber)
        Me.Controls.Add(Me.btndownload)
        Me.Controls.Add(Me.grddocuments)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmDocuments"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "الملفات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grddocuments.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grddocuments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grddocuments.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grddocuments As Telerik.WinControls.UI.RadGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btndownload As System.Windows.Forms.Button
    Friend WithEvents txtseqnumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnscan As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnloadfile As System.Windows.Forms.Button
    Friend WithEvents btnloadfile2 As Button
End Class
