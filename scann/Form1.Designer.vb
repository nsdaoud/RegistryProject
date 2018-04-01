<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bgwScan = New System.ComponentModel.BackgroundWorker()
        Me.label7 = New System.Windows.Forms.Label()
        Me.cmbColorMode = New System.Windows.Forms.ComboBox()
        Me.cbxCustomPixel = New System.Windows.Forms.CheckBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.nudHeightInch = New System.Windows.Forms.NumericUpDown()
        Me.nudWidthInch = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.nudRes = New System.Windows.Forms.NumericUpDown()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.nudHeight = New System.Windows.Forms.NumericUpDown()
        Me.nudWidth = New System.Windows.Forms.NumericUpDown()
        Me.btnStopScan = New System.Windows.Forms.Button()
        Me.btnStartScan = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnSelectPath = New System.Windows.Forms.Button()
        Me.txtWT = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.nudTime = New System.Windows.Forms.NumericUpDown()
        Me.pbWaiting = New System.Windows.Forms.ProgressBar()
        Me.picScan = New System.Windows.Forms.PictureBox()
        CType(Me.nudHeightInch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWidthInch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgwScan
        '
        Me.bgwScan.WorkerReportsProgress = True
        Me.bgwScan.WorkerSupportsCancellation = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(363, 42)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(61, 13)
        Me.label7.TabIndex = 62
        Me.label7.Text = "Color Mode"
        '
        'cmbColorMode
        '
        Me.cmbColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColorMode.FormattingEnabled = True
        Me.cmbColorMode.Items.AddRange(New Object() {"Black and White", "Color", "Gray Scale"})
        Me.cmbColorMode.Location = New System.Drawing.Point(329, 16)
        Me.cmbColorMode.Name = "cmbColorMode"
        Me.cmbColorMode.Size = New System.Drawing.Size(133, 21)
        Me.cmbColorMode.TabIndex = 61
        '
        'cbxCustomPixel
        '
        Me.cbxCustomPixel.AutoSize = True
        Me.cbxCustomPixel.Location = New System.Drawing.Point(426, 81)
        Me.cbxCustomPixel.Name = "cbxCustomPixel"
        Me.cbxCustomPixel.Size = New System.Drawing.Size(113, 17)
        Me.cbxCustomPixel.TabIndex = 60
        Me.cbxCustomPixel.Text = "Custom Pixel Units"
        Me.cbxCustomPixel.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(623, 107)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(63, 13)
        Me.label6.TabIndex = 59
        Me.label6.Text = "Pixel Height"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(552, 107)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 13)
        Me.label5.TabIndex = 58
        Me.label5.Text = "Pixel Width"
        '
        'nudHeightInch
        '
        Me.nudHeightInch.Location = New System.Drawing.Point(551, 18)
        Me.nudHeightInch.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudHeightInch.Name = "nudHeightInch"
        Me.nudHeightInch.Size = New System.Drawing.Size(65, 20)
        Me.nudHeightInch.TabIndex = 57
        Me.nudHeightInch.Value = New Decimal(New Integer() {11, 0, 0, 0})
        '
        'nudWidthInch
        '
        Me.nudWidthInch.Location = New System.Drawing.Point(474, 18)
        Me.nudWidthInch.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudWidthInch.Name = "nudWidthInch"
        Me.nudWidthInch.Size = New System.Drawing.Size(65, 20)
        Me.nudWidthInch.TabIndex = 56
        Me.nudWidthInch.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(630, 42)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 13)
        Me.label1.TabIndex = 55
        Me.label1.Text = "Resolution"
        '
        'nudRes
        '
        Me.nudRes.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudRes.Location = New System.Drawing.Point(626, 18)
        Me.nudRes.Maximum = New Decimal(New Integer() {1200, 0, 0, 0})
        Me.nudRes.Minimum = New Decimal(New Integer() {75, 0, 0, 0})
        Me.nudRes.Name = "nudRes"
        Me.nudRes.Size = New System.Drawing.Size(65, 20)
        Me.nudRes.TabIndex = 54
        Me.nudRes.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(559, 42)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(38, 13)
        Me.label4.TabIndex = 53
        Me.label4.Text = "Height"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(482, 42)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(35, 13)
        Me.label3.TabIndex = 52
        Me.label3.Text = "Width"
        '
        'nudHeight
        '
        Me.nudHeight.Location = New System.Drawing.Point(622, 78)
        Me.nudHeight.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudHeight.Name = "nudHeight"
        Me.nudHeight.ReadOnly = True
        Me.nudHeight.Size = New System.Drawing.Size(65, 20)
        Me.nudHeight.TabIndex = 51
        Me.nudHeight.Value = New Decimal(New Integer() {1700, 0, 0, 0})
        '
        'nudWidth
        '
        Me.nudWidth.Location = New System.Drawing.Point(551, 78)
        Me.nudWidth.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudWidth.Name = "nudWidth"
        Me.nudWidth.ReadOnly = True
        Me.nudWidth.Size = New System.Drawing.Size(65, 20)
        Me.nudWidth.TabIndex = 50
        Me.nudWidth.Value = New Decimal(New Integer() {1250, 0, 0, 0})
        '
        'btnStopScan
        '
        Me.btnStopScan.Enabled = False
        Me.btnStopScan.Location = New System.Drawing.Point(192, 60)
        Me.btnStopScan.Name = "btnStopScan"
        Me.btnStopScan.Size = New System.Drawing.Size(75, 23)
        Me.btnStopScan.TabIndex = 49
        Me.btnStopScan.Text = "Stop"
        Me.btnStopScan.UseVisualStyleBackColor = True
        '
        'btnStartScan
        '
        Me.btnStartScan.Location = New System.Drawing.Point(104, 60)
        Me.btnStartScan.Name = "btnStartScan"
        Me.btnStartScan.Size = New System.Drawing.Size(75, 23)
        Me.btnStartScan.TabIndex = 48
        Me.btnStartScan.Text = "Start"
        Me.btnStartScan.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(15, 17)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(174, 20)
        Me.txtPath.TabIndex = 47
        '
        'btnSelectPath
        '
        Me.btnSelectPath.Location = New System.Drawing.Point(195, 12)
        Me.btnSelectPath.Name = "btnSelectPath"
        Me.btnSelectPath.Size = New System.Drawing.Size(72, 29)
        Me.btnSelectPath.TabIndex = 46
        Me.btnSelectPath.Text = "Select Path"
        Me.btnSelectPath.UseVisualStyleBackColor = True
        '
        'txtWT
        '
        Me.txtWT.BackColor = System.Drawing.Color.Black
        Me.txtWT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWT.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWT.ForeColor = System.Drawing.Color.Chartreuse
        Me.txtWT.Location = New System.Drawing.Point(17, 204)
        Me.txtWT.Name = "txtWT"
        Me.txtWT.Size = New System.Drawing.Size(260, 29)
        Me.txtWT.TabIndex = 67
        Me.txtWT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(290, 147)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(68, 13)
        Me.label2.TabIndex = 66
        Me.label2.Text = "Waiting Sec."
        '
        'nudTime
        '
        Me.nudTime.Location = New System.Drawing.Point(298, 176)
        Me.nudTime.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudTime.Name = "nudTime"
        Me.nudTime.Size = New System.Drawing.Size(49, 20)
        Me.nudTime.TabIndex = 65
        Me.nudTime.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'pbWaiting
        '
        Me.pbWaiting.Location = New System.Drawing.Point(15, 173)
        Me.pbWaiting.Name = "pbWaiting"
        Me.pbWaiting.Size = New System.Drawing.Size(262, 25)
        Me.pbWaiting.TabIndex = 64
        '
        'picScan
        '
        Me.picScan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picScan.Location = New System.Drawing.Point(383, 137)
        Me.picScan.Name = "picScan"
        Me.picScan.Size = New System.Drawing.Size(308, 324)
        Me.picScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScan.TabIndex = 63
        Me.picScan.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 493)
        Me.Controls.Add(Me.txtWT)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.nudTime)
        Me.Controls.Add(Me.pbWaiting)
        Me.Controls.Add(Me.picScan)
        Me.Controls.Add(Me.label7)
        Me.Controls.Add(Me.cmbColorMode)
        Me.Controls.Add(Me.cbxCustomPixel)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.nudHeightInch)
        Me.Controls.Add(Me.nudWidthInch)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.nudRes)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.nudHeight)
        Me.Controls.Add(Me.nudWidth)
        Me.Controls.Add(Me.btnStopScan)
        Me.Controls.Add(Me.btnStartScan)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnSelectPath)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.nudHeightInch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWidthInch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bgwScan As System.ComponentModel.BackgroundWorker
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents cmbColorMode As System.Windows.Forms.ComboBox
    Private WithEvents cbxCustomPixel As System.Windows.Forms.CheckBox
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents nudHeightInch As System.Windows.Forms.NumericUpDown
    Private WithEvents nudWidthInch As System.Windows.Forms.NumericUpDown
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents nudRes As System.Windows.Forms.NumericUpDown
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents nudHeight As System.Windows.Forms.NumericUpDown
    Private WithEvents nudWidth As System.Windows.Forms.NumericUpDown
    Private WithEvents btnStopScan As System.Windows.Forms.Button
    Private WithEvents btnStartScan As System.Windows.Forms.Button
    Private WithEvents txtPath As System.Windows.Forms.TextBox
    Private WithEvents btnSelectPath As System.Windows.Forms.Button
    Private WithEvents txtWT As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents nudTime As System.Windows.Forms.NumericUpDown
    Private WithEvents pbWaiting As System.Windows.Forms.ProgressBar
    Private WithEvents picScan As System.Windows.Forms.PictureBox
End Class
