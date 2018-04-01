<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsenderreceiver
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
        Me.grdsendreceiver = New Telerik.WinControls.UI.RadGridView()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        CType(Me.grdsendreceiver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdsendreceiver.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdsendreceiver
        '
        Me.grdsendreceiver.Location = New System.Drawing.Point(19, 47)
        '
        'grdsendreceiver
        '
        GridViewTextBoxColumn1.FieldName = "id_DeliveredFor"
        GridViewTextBoxColumn1.HeaderText = "id_DeliveredFor"
        GridViewTextBoxColumn1.IsVisible = False
        GridViewTextBoxColumn1.Name = "id_DeliveredFor"
        GridViewTextBoxColumn2.FieldName = "DeliveredForDescription"
        GridViewTextBoxColumn2.HeaderText = "المصدر / المقام المرسل اليه "
        GridViewTextBoxColumn2.Name = "DeliveredForDescription"
        GridViewTextBoxColumn3.FieldName = "Rowaction"
        GridViewTextBoxColumn3.HeaderText = "Rowaction"
        GridViewTextBoxColumn3.IsVisible = False
        GridViewTextBoxColumn3.Name = "Rowaction"
        Me.grdsendreceiver.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3})
        Me.grdsendreceiver.Name = "grdsendreceiver"
        Me.grdsendreceiver.Size = New System.Drawing.Size(752, 415)
        Me.grdsendreceiver.TabIndex = 1
        Me.grdsendreceiver.Text = "RadGridView1"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(19, 12)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 5
        Me.btndelete.Text = "حذف"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(100, 12)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 4
        Me.btnsave.Text = "حفظ"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'frmsenderreceiver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 474)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.grdsendreceiver)
        Me.Name = "frmsenderreceiver"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "المصدر / المقام المرسل اليه "
        CType(Me.grdsendreceiver.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdsendreceiver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdsendreceiver As Telerik.WinControls.UI.RadGridView
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
End Class
