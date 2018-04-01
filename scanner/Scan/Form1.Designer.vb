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
        Me.picScan = New System.Windows.Forms.PictureBox()
        Me.btnStopScan = New System.Windows.Forms.Button()
        Me.btnStartScan = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnSelectPath = New System.Windows.Forms.Button()
        CType(Me.picScan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picScan
        '
        Me.picScan.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picScan.Location = New System.Drawing.Point(357, 36)
        Me.picScan.Name = "picScan"
        Me.picScan.Size = New System.Drawing.Size(308, 423)
        Me.picScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScan.TabIndex = 6
        Me.picScan.TabStop = False
        '
        'btnStopScan
        '
        Me.btnStopScan.Enabled = False
        Me.btnStopScan.Location = New System.Drawing.Point(224, 60)
        Me.btnStopScan.Name = "btnStopScan"
        Me.btnStopScan.Size = New System.Drawing.Size(75, 23)
        Me.btnStopScan.TabIndex = 36
        Me.btnStopScan.Text = "Stop"
        Me.btnStopScan.UseVisualStyleBackColor = True
        '
        'btnStartScan
        '
        Me.btnStartScan.Location = New System.Drawing.Point(136, 60)
        Me.btnStartScan.Name = "btnStartScan"
        Me.btnStartScan.Size = New System.Drawing.Size(75, 23)
        Me.btnStartScan.TabIndex = 35
        Me.btnStartScan.Text = "Start"
        Me.btnStartScan.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(47, 17)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(174, 20)
        Me.txtPath.TabIndex = 34
        '
        'btnSelectPath
        '
        Me.btnSelectPath.Location = New System.Drawing.Point(227, 12)
        Me.btnSelectPath.Name = "btnSelectPath"
        Me.btnSelectPath.Size = New System.Drawing.Size(72, 29)
        Me.btnSelectPath.TabIndex = 33
        Me.btnSelectPath.Text = "Select Path"
        Me.btnSelectPath.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 568)
        Me.Controls.Add(Me.btnStopScan)
        Me.Controls.Add(Me.btnStartScan)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.btnSelectPath)
        Me.Controls.Add(Me.picScan)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picScan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents picScan As System.Windows.Forms.PictureBox
    Private WithEvents btnStopScan As System.Windows.Forms.Button
    Private WithEvents btnStartScan As System.Windows.Forms.Button
    Private WithEvents txtPath As System.Windows.Forms.TextBox
    Private WithEvents btnSelectPath As System.Windows.Forms.Button
End Class
