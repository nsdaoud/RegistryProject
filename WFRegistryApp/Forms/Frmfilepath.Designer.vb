<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmfilepath
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmfilepath))
        Me.grdfilepath = New Telerik.WinControls.UI.RadGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnfilelocation = New System.Windows.Forms.Button()
        Me.txtfilelocation = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtfiletype = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.grdfilepath, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdfilepath.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdfilepath
        '
        Me.grdfilepath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdfilepath.Location = New System.Drawing.Point(12, 42)
        '
        'grdfilepath
        '
        GridViewTextBoxColumn1.FieldName = "key"
        GridViewTextBoxColumn1.HeaderText = "File Type"
        GridViewTextBoxColumn1.Name = "key"
        GridViewTextBoxColumn1.ReadOnly = True
        GridViewTextBoxColumn2.FieldName = "value"
        GridViewTextBoxColumn2.HeaderText = "File Location"
        GridViewTextBoxColumn2.Name = "value"
        GridViewTextBoxColumn2.ReadOnly = True
        Me.grdfilepath.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2})
        Me.grdfilepath.Name = "grdfilepath"
        Me.grdfilepath.Size = New System.Drawing.Size(651, 304)
        Me.grdfilepath.TabIndex = 0
        Me.grdfilepath.Text = "RadGridView1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnfilelocation)
        Me.GroupBox1.Controls.Add(Me.txtfilelocation)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtfiletype)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 133)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnfilelocation
        '
        Me.btnfilelocation.Location = New System.Drawing.Point(430, 70)
        Me.btnfilelocation.Name = "btnfilelocation"
        Me.btnfilelocation.Size = New System.Drawing.Size(75, 23)
        Me.btnfilelocation.TabIndex = 4
        Me.btnfilelocation.Text = "File Location"
        Me.btnfilelocation.UseVisualStyleBackColor = True
        '
        'txtfilelocation
        '
        Me.txtfilelocation.Location = New System.Drawing.Point(79, 72)
        Me.txtfilelocation.Multiline = True
        Me.txtfilelocation.Name = "txtfilelocation"
        Me.txtfilelocation.Size = New System.Drawing.Size(345, 44)
        Me.txtfilelocation.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "File Location"
        '
        'txtfiletype
        '
        Me.txtfiletype.Enabled = False
        Me.txtfiletype.Location = New System.Drawing.Point(79, 26)
        Me.txtfiletype.Name = "txtfiletype"
        Me.txtfiletype.Size = New System.Drawing.Size(345, 20)
        Me.txtfiletype.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "File Type"
        '
        'btnsave
        '
        Me.btnsave.ImageIndex = 10
        Me.btnsave.ImageList = Me.ImageList
        Me.btnsave.Location = New System.Drawing.Point(12, 12)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(40, 23)
        Me.btnsave.TabIndex = 5
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        Me.ImageList.Images.SetKeyName(9, "")
        Me.ImageList.Images.SetKeyName(10, "")
        Me.ImageList.Images.SetKeyName(11, "")
        Me.ImageList.Images.SetKeyName(12, "")
        Me.ImageList.Images.SetKeyName(13, "")
        Me.ImageList.Images.SetKeyName(14, "")
        Me.ImageList.Images.SetKeyName(15, "")
        Me.ImageList.Images.SetKeyName(16, "")
        Me.ImageList.Images.SetKeyName(17, "")
        Me.ImageList.Images.SetKeyName(18, "")
        Me.ImageList.Images.SetKeyName(19, "")
        Me.ImageList.Images.SetKeyName(20, "")
        Me.ImageList.Images.SetKeyName(21, "")
        Me.ImageList.Images.SetKeyName(22, "")
        Me.ImageList.Images.SetKeyName(23, "index.jpg")
        Me.ImageList.Images.SetKeyName(24, "glasses2.gif")
        Me.ImageList.Images.SetKeyName(25, "clear.jpg")
        '
        'Frmfilepath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 492)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdfilepath)
        Me.Name = "Frmfilepath"
        Me.Text = "موقع الملفات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdfilepath.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdfilepath, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdfilepath As Telerik.WinControls.UI.RadGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtfilelocation As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfiletype As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnfilelocation As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
End Class
