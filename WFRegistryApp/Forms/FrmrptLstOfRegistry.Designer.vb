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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtfromsubmissiondate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dttosubmissiondate = New System.Windows.Forms.DateTimePicker()
        Me.cmbuser = New System.Windows.Forms.ComboBox()
        Me.chuser = New System.Windows.Forms.CheckBox()
        Me.chknotnullvalues = New System.Windows.Forms.CheckBox()
        Me.cmbPaperSource = New System.Windows.Forms.ComboBox()
        Me.chkdelfor = New System.Windows.Forms.CheckBox()
        Me.chkpapersource = New System.Windows.Forms.CheckBox()
        Me.chkisnull = New System.Windows.Forms.CheckBox()
        Me.txtregistrydescription = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRegistrySubmitted = New System.Windows.Forms.TextBox()
        Me.txtsubject = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chkRegistryDate = New System.Windows.Forms.CheckBox()
        Me.ckduedate = New System.Windows.Forms.CheckBox()
        Me.grbduedate = New System.Windows.Forms.GroupBox()
        Me.duedtfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.duedtto = New System.Windows.Forms.DateTimePicker()
        Me.cmbDeliveredFor = New System.Windows.Forms.ComboBox()
        Me.grbsubmissiondate = New System.Windows.Forms.GroupBox()
        Me.dtFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtin = New System.Windows.Forms.DateTimePicker()
        Me.btngenerate = New System.Windows.Forms.Button()
        Me.chksoudourisnull = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grbduedate.SuspendLayout()
        Me.grbsubmissiondate.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chksoudourisnull)
        Me.GroupBox1.Controls.Add(Me.chksubmissiondate)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cmbuser)
        Me.GroupBox1.Controls.Add(Me.chuser)
        Me.GroupBox1.Controls.Add(Me.chknotnullvalues)
        Me.GroupBox1.Controls.Add(Me.cmbPaperSource)
        Me.GroupBox1.Controls.Add(Me.chkdelfor)
        Me.GroupBox1.Controls.Add(Me.chkpapersource)
        Me.GroupBox1.Controls.Add(Me.chkisnull)
        Me.GroupBox1.Controls.Add(Me.txtregistrydescription)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtRegistrySubmitted)
        Me.GroupBox1.Controls.Add(Me.txtsubject)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.chkRegistryDate)
        Me.GroupBox1.Controls.Add(Me.ckduedate)
        Me.GroupBox1.Controls.Add(Me.grbduedate)
        Me.GroupBox1.Controls.Add(Me.cmbDeliveredFor)
        Me.GroupBox1.Controls.Add(Me.grbsubmissiondate)
        Me.GroupBox1.Controls.Add(Me.btngenerate)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(752, 468)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chksubmissiondate
        '
        Me.chksubmissiondate.AutoSize = True
        Me.chksubmissiondate.Location = New System.Drawing.Point(609, 298)
        Me.chksubmissiondate.Margin = New System.Windows.Forms.Padding(4)
        Me.chksubmissiondate.Name = "chksubmissiondate"
        Me.chksubmissiondate.Size = New System.Drawing.Size(94, 21)
        Me.chksubmissiondate.TabIndex = 12
        Me.chksubmissiondate.Text = "تاريخ الصدور"
        Me.chksubmissiondate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtfromsubmissiondate)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dttosubmissiondate)
        Me.GroupBox2.Location = New System.Drawing.Point(413, 319)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(318, 94)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'dtfromsubmissiondate
        '
        Me.dtfromsubmissiondate.Location = New System.Drawing.Point(4, 19)
        Me.dtfromsubmissiondate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtfromsubmissiondate.Name = "dtfromsubmissiondate"
        Me.dtfromsubmissiondate.Size = New System.Drawing.Size(265, 22)
        Me.dtfromsubmissiondate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(279, 59)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "الى"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(279, 27)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "من"
        '
        'dttosubmissiondate
        '
        Me.dttosubmissiondate.Location = New System.Drawing.Point(4, 51)
        Me.dttosubmissiondate.Margin = New System.Windows.Forms.Padding(4)
        Me.dttosubmissiondate.Name = "dttosubmissiondate"
        Me.dttosubmissiondate.Size = New System.Drawing.Size(265, 22)
        Me.dttosubmissiondate.TabIndex = 7
        '
        'cmbuser
        '
        Me.cmbuser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbuser.Enabled = False
        Me.cmbuser.FormattingEnabled = True
        Me.cmbuser.Location = New System.Drawing.Point(7, 266)
        Me.cmbuser.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbuser.Name = "cmbuser"
        Me.cmbuser.Size = New System.Drawing.Size(235, 24)
        Me.cmbuser.TabIndex = 24
        '
        'chuser
        '
        Me.chuser.AutoSize = True
        Me.chuser.Location = New System.Drawing.Point(263, 269)
        Me.chuser.Name = "chuser"
        Me.chuser.Size = New System.Drawing.Size(90, 21)
        Me.chuser.TabIndex = 23
        Me.chuser.Text = "معالج المعاملة"
        Me.chuser.UseVisualStyleBackColor = True
        '
        'chknotnullvalues
        '
        Me.chknotnullvalues.AutoSize = True
        Me.chknotnullvalues.Location = New System.Drawing.Point(329, 150)
        Me.chknotnullvalues.Margin = New System.Windows.Forms.Padding(4)
        Me.chknotnullvalues.Name = "chknotnullvalues"
        Me.chknotnullvalues.Size = New System.Drawing.Size(153, 21)
        Me.chknotnullvalues.TabIndex = 22
        Me.chknotnullvalues.Text = "Without Null Values"
        Me.chknotnullvalues.UseVisualStyleBackColor = True
        '
        'cmbPaperSource
        '
        Me.cmbPaperSource.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPaperSource.Enabled = False
        Me.cmbPaperSource.FormattingEnabled = True
        Me.cmbPaperSource.Location = New System.Drawing.Point(8, 15)
        Me.cmbPaperSource.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPaperSource.Name = "cmbPaperSource"
        Me.cmbPaperSource.Size = New System.Drawing.Size(235, 24)
        Me.cmbPaperSource.TabIndex = 21
        '
        'chkdelfor
        '
        Me.chkdelfor.AutoSize = True
        Me.chkdelfor.Location = New System.Drawing.Point(254, 51)
        Me.chkdelfor.Name = "chkdelfor"
        Me.chkdelfor.Size = New System.Drawing.Size(108, 21)
        Me.chkdelfor.TabIndex = 20
        Me.chkdelfor.Text = "المقام المرسل اليه"
        Me.chkdelfor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.chkdelfor.UseVisualStyleBackColor = True
        '
        'chkpapersource
        '
        Me.chkpapersource.AutoSize = True
        Me.chkpapersource.Location = New System.Drawing.Point(264, 18)
        Me.chkpapersource.Name = "chkpapersource"
        Me.chkpapersource.Size = New System.Drawing.Size(98, 21)
        Me.chkpapersource.TabIndex = 19
        Me.chkpapersource.Text = "مصدر الاوراق"
        Me.chkpapersource.UseVisualStyleBackColor = True
        '
        'chkisnull
        '
        Me.chkisnull.AutoSize = True
        Me.chkisnull.Location = New System.Drawing.Point(490, 150)
        Me.chkisnull.Margin = New System.Windows.Forms.Padding(4)
        Me.chkisnull.Name = "chkisnull"
        Me.chkisnull.Size = New System.Drawing.Size(134, 21)
        Me.chkisnull.TabIndex = 18
        Me.chkisnull.Text = "Only Null Values"
        Me.chkisnull.UseVisualStyleBackColor = True
        '
        'txtregistrydescription
        '
        Me.txtregistrydescription.Location = New System.Drawing.Point(7, 180)
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
        'txtRegistrySubmitted
        '
        Me.txtRegistrySubmitted.Location = New System.Drawing.Point(10, 79)
        Me.txtRegistrySubmitted.Name = "txtRegistrySubmitted"
        Me.txtRegistrySubmitted.Size = New System.Drawing.Size(235, 22)
        Me.txtRegistrySubmitted.TabIndex = 15
        '
        'txtsubject
        '
        Me.txtsubject.Location = New System.Drawing.Point(10, 111)
        Me.txtsubject.Multiline = True
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(235, 60)
        Me.txtsubject.TabIndex = 14
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
        'chkRegistryDate
        '
        Me.chkRegistryDate.AutoSize = True
        Me.chkRegistryDate.Location = New System.Drawing.Point(602, 19)
        Me.chkRegistryDate.Margin = New System.Windows.Forms.Padding(4)
        Me.chkRegistryDate.Name = "chkRegistryDate"
        Me.chkRegistryDate.Size = New System.Drawing.Size(93, 21)
        Me.chkRegistryDate.TabIndex = 10
        Me.chkRegistryDate.Text = "تاريخ التسجيل"
        Me.chkRegistryDate.UseVisualStyleBackColor = True
        '
        'ckduedate
        '
        Me.ckduedate.AutoSize = True
        Me.ckduedate.Location = New System.Drawing.Point(632, 150)
        Me.ckduedate.Margin = New System.Windows.Forms.Padding(4)
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
        Me.grbduedate.Location = New System.Drawing.Point(378, 177)
        Me.grbduedate.Margin = New System.Windows.Forms.Padding(4)
        Me.grbduedate.Name = "grbduedate"
        Me.grbduedate.Padding = New System.Windows.Forms.Padding(4)
        Me.grbduedate.Size = New System.Drawing.Size(353, 113)
        Me.grbduedate.TabIndex = 9
        Me.grbduedate.TabStop = False
        '
        'duedtfrom
        '
        Me.duedtfrom.Location = New System.Drawing.Point(45, 23)
        Me.duedtfrom.Margin = New System.Windows.Forms.Padding(4)
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
        Me.duedtto.Margin = New System.Windows.Forms.Padding(4)
        Me.duedtto.Name = "duedtto"
        Me.duedtto.Size = New System.Drawing.Size(265, 22)
        Me.duedtto.TabIndex = 3
        '
        'cmbDeliveredFor
        '
        Me.cmbDeliveredFor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDeliveredFor.Enabled = False
        Me.cmbDeliveredFor.FormattingEnabled = True
        Me.cmbDeliveredFor.Location = New System.Drawing.Point(10, 48)
        Me.cmbDeliveredFor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDeliveredFor.Name = "cmbDeliveredFor"
        Me.cmbDeliveredFor.Size = New System.Drawing.Size(235, 24)
        Me.cmbDeliveredFor.TabIndex = 8
        '
        'grbsubmissiondate
        '
        Me.grbsubmissiondate.Controls.Add(Me.dtFrom)
        Me.grbsubmissiondate.Controls.Add(Me.Label2)
        Me.grbsubmissiondate.Controls.Add(Me.Label1)
        Me.grbsubmissiondate.Controls.Add(Me.dtin)
        Me.grbsubmissiondate.Location = New System.Drawing.Point(406, 40)
        Me.grbsubmissiondate.Margin = New System.Windows.Forms.Padding(4)
        Me.grbsubmissiondate.Name = "grbsubmissiondate"
        Me.grbsubmissiondate.Padding = New System.Windows.Forms.Padding(4)
        Me.grbsubmissiondate.Size = New System.Drawing.Size(318, 94)
        Me.grbsubmissiondate.TabIndex = 5
        Me.grbsubmissiondate.TabStop = False
        '
        'dtFrom
        '
        Me.dtFrom.Location = New System.Drawing.Point(4, 19)
        Me.dtFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.dtFrom.Name = "dtFrom"
        Me.dtFrom.Size = New System.Drawing.Size(265, 22)
        Me.dtFrom.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "الى"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(279, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "من"
        '
        'dtin
        '
        Me.dtin.Location = New System.Drawing.Point(4, 51)
        Me.dtin.Margin = New System.Windows.Forms.Padding(4)
        Me.dtin.Name = "dtin"
        Me.dtin.Size = New System.Drawing.Size(265, 22)
        Me.dtin.TabIndex = 7
        '
        'btngenerate
        '
        Me.btngenerate.Location = New System.Drawing.Point(23, 411)
        Me.btngenerate.Margin = New System.Windows.Forms.Padding(4)
        Me.btngenerate.Name = "btngenerate"
        Me.btngenerate.Size = New System.Drawing.Size(116, 28)
        Me.btngenerate.TabIndex = 0
        Me.btngenerate.Text = "اصدار"
        Me.btngenerate.UseVisualStyleBackColor = True
        '
        'chksoudourisnull
        '
        Me.chksoudourisnull.AutoSize = True
        Me.chksoudourisnull.Location = New System.Drawing.Point(467, 298)
        Me.chksoudourisnull.Margin = New System.Windows.Forms.Padding(4)
        Me.chksoudourisnull.Name = "chksoudourisnull"
        Me.chksoudourisnull.Size = New System.Drawing.Size(134, 21)
        Me.chksoudourisnull.TabIndex = 25
        Me.chksoudourisnull.Text = "Only Null Values"
        Me.chksoudourisnull.UseVisualStyleBackColor = True
        '
        'FrmrptLstOfRegistry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 498)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmrptLstOfRegistry"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "التقرير"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grbduedate.ResumeLayout(False)
        Me.grbduedate.PerformLayout()
        Me.grbsubmissiondate.ResumeLayout(False)
        Me.grbsubmissiondate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btngenerate As System.Windows.Forms.Button
    Friend WithEvents grbsubmissiondate As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDeliveredFor As System.Windows.Forms.ComboBox
    Friend WithEvents grbduedate As System.Windows.Forms.GroupBox
    Friend WithEvents ckduedate As System.Windows.Forms.CheckBox
    Friend WithEvents duedtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents duedtto As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkRegistryDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtRegistrySubmitted As TextBox
    Friend WithEvents txtsubject As TextBox
    Friend WithEvents txtregistrydescription As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents chkisnull As CheckBox
    Friend WithEvents chkdelfor As CheckBox
    Friend WithEvents dtFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtin As DateTimePicker
    Friend WithEvents chknotnullvalues As CheckBox
    Friend WithEvents cmbPaperSource As ComboBox
    Friend WithEvents chkpapersource As CheckBox
    Friend WithEvents cmbuser As ComboBox
    Friend WithEvents chuser As CheckBox
    Friend WithEvents chksubmissiondate As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtfromsubmissiondate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dttosubmissiondate As DateTimePicker
    Friend WithEvents chksoudourisnull As CheckBox
End Class
