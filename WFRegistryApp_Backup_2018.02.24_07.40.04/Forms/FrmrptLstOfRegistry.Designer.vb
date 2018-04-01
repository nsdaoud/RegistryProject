<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmrptLstOfRegistry
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chksubmissiondate = New System.Windows.Forms.CheckBox()
        Me.ckduedate = New System.Windows.Forms.CheckBox()
        Me.grbduedate = New System.Windows.Forms.GroupBox()
        Me.duedtfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.duedtto = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDeliveredFor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbPaperSource = New System.Windows.Forms.ComboBox()
        Me.grbsubmissiondate = New System.Windows.Forms.GroupBox()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtin = New System.Windows.Forms.DateTimePicker()
        Me.btngenerate = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.txtRegistrySubmitted = New System.Windows.Forms.TextBox()
        Me.txtregistrydescription = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grbduedate.SuspendLayout()
        Me.grbsubmissiondate.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtregistrydescription)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtRegistrySubmitted)
        Me.GroupBox1.Controls.Add(Me.txtsubject)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chksubmissiondate)
        Me.GroupBox1.Controls.Add(Me.ckduedate)
        Me.GroupBox1.Controls.Add(Me.grbduedate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbDeliveredFor)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbPaperSource)
        Me.GroupBox1.Controls.Add(Me.grbsubmissiondate)
        Me.GroupBox1.Controls.Add(Me.btngenerate)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(752, 308)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chksubmissiondate
        '
        Me.chksubmissiondate.AutoSize = True
        Me.chksubmissiondate.Location = New System.Drawing.Point(602, 19)
        Me.chksubmissiondate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chksubmissiondate.Name = "chksubmissiondate"
        Me.chksubmissiondate.Size = New System.Drawing.Size(93, 21)
        Me.chksubmissiondate.TabIndex = 10
        Me.chksubmissiondate.Text = "تاريخ التسجيل"
        Me.chksubmissiondate.UseVisualStyleBackColor = True
        '
        'ckduedate
        '
        Me.ckduedate.AutoSize = True
        Me.ckduedate.Location = New System.Drawing.Point(632, 150)
        Me.ckduedate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ckduedate.Name = "ckduedate"
        Me.ckduedate.Size = New System.Drawing.Size(76, 21)
        Me.ckduedate.TabIndex = 5
        Me.ckduedate.Text = "ذات موعد"
        Me.ckduedate.UseVisualStyleBackColor = True
        '
        'grbduedate
        '
        Me.grbduedate.Controls.Add(Me.duedtfrom)
        Me.grbduedate.Controls.Add(Me.Label5)
        Me.grbduedate.Controls.Add(Me.Label6)
        Me.grbduedate.Controls.Add(Me.duedtto)
        Me.grbduedate.Location = New System.Drawing.Point(376, 166)
        Me.grbduedate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbduedate.Name = "grbduedate"
        Me.grbduedate.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbduedate.Size = New System.Drawing.Size(355, 95)
        Me.grbduedate.TabIndex = 9
        Me.grbduedate.TabStop = False
        '
        'duedtfrom
        '
        Me.duedtfrom.Location = New System.Drawing.Point(45, 23)
        Me.duedtfrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.duedtfrom.Name = "duedtfrom"
        Me.duedtfrom.Size = New System.Drawing.Size(265, 22)
        Me.duedtfrom.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(320, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "الى"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 31)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "من"
        '
        'duedtto
        '
        Me.duedtto.Location = New System.Drawing.Point(45, 55)
        Me.duedtto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.duedtto.Name = "duedtto"
        Me.duedtto.Size = New System.Drawing.Size(265, 22)
        Me.duedtto.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 51)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "المقام المرسل اليه"
        '
        'cmbDeliveredFor
        '
        Me.cmbDeliveredFor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeliveredFor.FormattingEnabled = True
        Me.cmbDeliveredFor.Location = New System.Drawing.Point(10, 48)
        Me.cmbDeliveredFor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbDeliveredFor.Name = "cmbDeliveredFor"
        Me.cmbDeliveredFor.Size = New System.Drawing.Size(235, 24)
        Me.cmbDeliveredFor.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(274, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "مصدر الاوراق"
        '
        'cmbPaperSource
        '
        Me.cmbPaperSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPaperSource.FormattingEnabled = True
        Me.cmbPaperSource.Location = New System.Drawing.Point(10, 15)
        Me.cmbPaperSource.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbPaperSource.Name = "cmbPaperSource"
        Me.cmbPaperSource.Size = New System.Drawing.Size(235, 24)
        Me.cmbPaperSource.TabIndex = 6
        '
        'grbsubmissiondate
        '
        Me.grbsubmissiondate.Controls.Add(Me.dtFrom)
        Me.grbsubmissiondate.Controls.Add(Me.Label2)
        Me.grbsubmissiondate.Controls.Add(Me.Label1)
        Me.grbsubmissiondate.Controls.Add(Me.dtin)
        Me.grbsubmissiondate.Location = New System.Drawing.Point(369, 47)
        Me.grbsubmissiondate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbsubmissiondate.Name = "grbsubmissiondate"
        Me.grbsubmissiondate.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbsubmissiondate.Size = New System.Drawing.Size(355, 95)
        Me.grbsubmissiondate.TabIndex = 5
        Me.grbsubmissiondate.TabStop = False
        '
        'dtFrom
        '
        Me.dtFrom.Location = New System.Drawing.Point(45, 23)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(265, 22)
        Me.dtFrom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "الى"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "من"
        '
        'dtin
        '
        Me.dtin.Location = New System.Drawing.Point(45, 55)
        Me.dtin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtin.Name = "dtin"
        Me.dtin.Size = New System.Drawing.Size(265, 22)
        Me.dtin.TabIndex = 3
        '
        'btngenerate
        '
        Me.btngenerate.Location = New System.Drawing.Point(10, 270)
        Me.btngenerate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(116, 28)
        Me.btngenerate.TabIndex = 0
        Me.btngenerate.Text = "اصدار"
        Me.btngenerate.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(271, 114)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "موضوع الإحالة"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(323, 87)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "مقدم"
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(10, 111)
        Me.txtsubject.Multiline = True
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(235, 60)
        Me.txtsubject.TabIndex = 14
        '
        'txtRegistrySubmitted
        '
        Me.txtRegistrySubmitted.Location = New System.Drawing.Point(10, 79)
        Me.txtRegistrySubmitted.Name = "txtRegistrySubmitted"
        Me.txtRegistrySubmitted.Size = New System.Drawing.Size(235, 22)
        Me.txtRegistrySubmitted.TabIndex = 15
        '
        'txtregistrydescription
        '
        Me.txtregistrydescription.Location = New System.Drawing.Point(10, 177)
        Me.txtregistrydescription.Multiline = True
        Me.txtregistrydescription.Name = "txtregistrydescription"
        Me.txtregistrydescription.Size = New System.Drawing.Size(235, 60)
        Me.txtregistrydescription.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(294, 180)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "موضوع "
        '
        'FrmrptLstOfRegistry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 337)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmrptLstOfRegistry"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "التقرير"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbduedate.ResumeLayout(False)
        Me.grbduedate.PerformLayout()
        Me.grbsubmissiondate.ResumeLayout(False)
        Me.grbsubmissiondate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents btngenerate As System.Windows.Forms.Button
    Friend WithEvents grbsubmissiondate As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPaperSource As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbDeliveredFor As System.Windows.Forms.ComboBox
    Friend WithEvents grbduedate As System.Windows.Forms.GroupBox
    Friend WithEvents ckduedate As System.Windows.Forms.CheckBox
    Friend WithEvents duedtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents duedtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents chksubmissiondate As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRegistrySubmitted As TextBox
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents txtregistrydescription As TextBox
    Friend WithEvents Label9 As Label
End Class
