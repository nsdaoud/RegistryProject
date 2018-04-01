<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmscanfile
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
        Me.picScan = New System.Windows.Forms.PictureBox()
        Me.pbWaiting = New System.Windows.Forms.ProgressBar()
        Me.label2 = New System.Windows.Forms.Label()
        Me.nudTime = New System.Windows.Forms.NumericUpDown()
        Me.txtWT = New System.Windows.Forms.TextBox()
        Me.btnStopScan = New System.Windows.Forms.Button()
        Me.btnStartScan = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnSelectPath = New System.Windows.Forms.Button()
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
        CType(Me.picScan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeightInch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWidthInch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bgwScan
        '
        Me.bgwScan.WorkerReportsProgress = True
        Me.bgwScan.WorkerSupportsCancellation = True
        '
        'picScan
        '
        Me.picScan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picScan.Location = New System.Drawing.Point(380, 118)
        Me.picScan.Name = "picScan"
        Me.picScan.Size = New System.Drawing.Size(308, 423)
        Me.picScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScan.TabIndex = 5
        Me.picScan.TabStop = False
        '
        'pbWaiting
        '
        Me.pbWaiting.Location = New System.Drawing.Point(12, 248)
        Me.pbWaiting.Name = "pbWaiting"
        Me.pbWaiting.Size = New System.Drawing.Size(262, 25)
        Me.pbWaiting.TabIndex = 16
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(287, 222)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(68, 13)
        Me.label2.TabIndex = 21
        Me.label2.Text = "Waiting Sec."
        '
        'nudTime
        '
        Me.nudTime.Location = New System.Drawing.Point(295, 251)
        Me.nudTime.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nudTime.Name = "nudTime"
        Me.nudTime.Size = New System.Drawing.Size(49, 20)
        Me.nudTime.TabIndex = 20
        Me.nudTime.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'txtWT
        '
        Me.txtWT.BackColor = System.Drawing.Color.Black
        Me.txtWT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtWT.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWT.ForeColor = System.Drawing.Color.Chartreuse
        Me.txtWT.Location = New System.Drawing.Point(14, 279)
        Me.txtWT.Name = "txtWT"
        Me.txtWT.Size = New System.Drawing.Size(260, 29)
        Me.txtWT.TabIndex = 28
        Me.txtWT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnStopScan
        '
        Me.btnStopScan.Enabled = False
        Me.btnStopScan.Location = New System.Drawing.Point(191, 55)
        Me.btnStopScan.Name = "btnStopScan"
        Me.btnStopScan.Size = New System.Drawing.Size(75, 23)
        Me.btnStopScan.TabIndex = 32
        Me.btnStopScan.Text = "Stop"
        Me.btnStopScan.UseVisualStyleBackColor = True
        '
        'btnStartScan
        '
        Me.btnStartScan.Location = New System.Drawing.Point(103, 55)
        Me.btnStartScan.Name = "btnStartScan"
        Me.btnStartScan.Size = New System.Drawing.Size(75, 23)
        Me.btnStartScan.TabIndex = 31
        Me.btnStartScan.Text = "Start"
        Me.btnStartScan.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(14, 12)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(174, 20)
        Me.txtPath.TabIndex = 30
        '
        'btnSelectPath
        '
        Me.btnSelectPath.Location = New System.Drawing.Point(194, 7)
        Me.btnSelectPath.Name = "btnSelectPath"
        Me.btnSelectPath.Size = New System.Drawing.Size(72, 29)
        Me.btnSelectPath.TabIndex = 29
        Me.btnSelectPath.Text = "Select Path"
        Me.btnSelectPath.UseVisualStyleBackColor = True
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(362, 37)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(61, 13)
        Me.label7.TabIndex = 45
        Me.label7.Text = "Color Mode"
        '
        'cmbColorMode
        '
        Me.cmbColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColorMode.FormattingEnabled = True
        Me.cmbColorMode.Items.AddRange(New Object() {"Black and White", "Color", "Gray Scale"})
        Me.cmbColorMode.Location = New System.Drawing.Point(328, 11)
        Me.cmbColorMode.Name = "cmbColorMode"
        Me.cmbColorMode.Size = New System.Drawing.Size(133, 21)
        Me.cmbColorMode.TabIndex = 44
        '
        'cbxCustomPixel
        '
        Me.cbxCustomPixel.AutoSize = True
        Me.cbxCustomPixel.Location = New System.Drawing.Point(425, 76)
        Me.cbxCustomPixel.Name = "cbxCustomPixel"
        Me.cbxCustomPixel.Size = New System.Drawing.Size(113, 17)
        Me.cbxCustomPixel.TabIndex = 43
        Me.cbxCustomPixel.Text = "Custom Pixel Units"
        Me.cbxCustomPixel.UseVisualStyleBackColor = True
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(622, 102)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(63, 13)
        Me.label6.TabIndex = 42
        Me.label6.Text = "Pixel Height"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(551, 102)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(60, 13)
        Me.label5.TabIndex = 41
        Me.label5.Text = "Pixel Width"
        '
        'nudHeightInch
        '
        Me.nudHeightInch.Location = New System.Drawing.Point(550, 13)
        Me.nudHeightInch.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudHeightInch.Name = "nudHeightInch"
        Me.nudHeightInch.Size = New System.Drawing.Size(65, 20)
        Me.nudHeightInch.TabIndex = 40
        Me.nudHeightInch.Value = New Decimal(New Integer() {11, 0, 0, 0})
        '
        'nudWidthInch
        '
        Me.nudWidthInch.Location = New System.Drawing.Point(473, 13)
        Me.nudWidthInch.Maximum = New Decimal(New Integer() {18, 0, 0, 0})
        Me.nudWidthInch.Name = "nudWidthInch"
        Me.nudWidthInch.Size = New System.Drawing.Size(65, 20)
        Me.nudWidthInch.TabIndex = 39
        Me.nudWidthInch.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(629, 37)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 13)
        Me.label1.TabIndex = 38
        Me.label1.Text = "Resolution"
        '
        'nudRes
        '
        Me.nudRes.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.nudRes.Location = New System.Drawing.Point(625, 13)
        Me.nudRes.Maximum = New Decimal(New Integer() {1200, 0, 0, 0})
        Me.nudRes.Minimum = New Decimal(New Integer() {75, 0, 0, 0})
        Me.nudRes.Name = "nudRes"
        Me.nudRes.Size = New System.Drawing.Size(65, 20)
        Me.nudRes.TabIndex = 37
        Me.nudRes.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(558, 37)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(38, 13)
        Me.label4.TabIndex = 36
        Me.label4.Text = "Height"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(481, 37)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(35, 13)
        Me.label3.TabIndex = 35
        Me.label3.Text = "Width"
        '
        'nudHeight
        '
        Me.nudHeight.Location = New System.Drawing.Point(621, 73)
        Me.nudHeight.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudHeight.Name = "nudHeight"
        Me.nudHeight.ReadOnly = True
        Me.nudHeight.Size = New System.Drawing.Size(65, 20)
        Me.nudHeight.TabIndex = 34
        Me.nudHeight.Value = New Decimal(New Integer() {1700, 0, 0, 0})
        '
        'nudWidth
        '
        Me.nudWidth.Location = New System.Drawing.Point(550, 73)
        Me.nudWidth.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudWidth.Name = "nudWidth"
        Me.nudWidth.ReadOnly = True
        Me.nudWidth.Size = New System.Drawing.Size(65, 20)
        Me.nudWidth.TabIndex = 33
        Me.nudWidth.Value = New Decimal(New Integer() {1250, 0, 0, 0})
        '
        'Frmscanfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 553)
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
        Me.Controls.Add(Me.txtWT)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.nudTime)
        Me.Controls.Add(Me.pbWaiting)
        Me.Controls.Add(Me.picScan)
        Me.Name = "Frmscanfile"
        Me.Text = "Form3"
        CType(Me.picScan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeightInch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWidthInch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bgwScan As System.ComponentModel.BackgroundWorker
    Private WithEvents picScan As System.Windows.Forms.PictureBox
    Private WithEvents pbWaiting As System.Windows.Forms.ProgressBar
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents nudTime As System.Windows.Forms.NumericUpDown
    Private WithEvents txtWT As System.Windows.Forms.TextBox
    Private WithEvents btnStopScan As System.Windows.Forms.Button
    Private WithEvents btnStartScan As System.Windows.Forms.Button
    Private WithEvents txtPath As System.Windows.Forms.TextBox
    Private WithEvents btnSelectPath As System.Windows.Forms.Button
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
End Class
