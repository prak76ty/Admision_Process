<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fee_Receipt_Master
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
        Me.Btn_add = New System.Windows.Forms.Button
        Me.Btn_cancle = New System.Windows.Forms.Button
        Me.Lblstunasme = New System.Windows.Forms.Label
        Me.Btn_preiouse = New System.Windows.Forms.Button
        Me.lblstudid = New System.Windows.Forms.Label
        Me.Btn_next = New System.Windows.Forms.Button
        Me.btn_exit = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtstudclass = New System.Windows.Forms.TextBox
        Me.txtstudName = New System.Windows.Forms.TextBox
        Me.combstudid = New System.Windows.Forms.ComboBox
        Me.DTPFeeReceiDate = New System.Windows.Forms.DateTimePicker
        Me.txtFeeReceiptNo = New System.Windows.Forms.TextBox
        Me.FeeReciptsNo = New System.Windows.Forms.Label
        Me.txtamt = New System.Windows.Forms.TextBox
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.lblamt = New System.Windows.Forms.Label
        Me.lblstudclass = New System.Windows.Forms.Label
        Me.lblfeereceidate = New System.Windows.Forms.Label
        Me.lblRemark = New System.Windows.Forms.Label
        Me.lblfeesReceiMast = New System.Windows.Forms.Label
        Me.btn_last = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.Btn_first = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_add
        '
        Me.Btn_add.BackColor = System.Drawing.Color.Indigo
        Me.Btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_add.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_add.Location = New System.Drawing.Point(63, 22)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.Size = New System.Drawing.Size(115, 36)
        Me.Btn_add.TabIndex = 49
        Me.Btn_add.Text = "ADDNEW"
        Me.Btn_add.UseVisualStyleBackColor = False
        '
        'Btn_cancle
        '
        Me.Btn_cancle.BackColor = System.Drawing.Color.Indigo
        Me.Btn_cancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancle.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_cancle.Location = New System.Drawing.Point(309, 22)
        Me.Btn_cancle.Name = "Btn_cancle"
        Me.Btn_cancle.Size = New System.Drawing.Size(115, 36)
        Me.Btn_cancle.TabIndex = 48
        Me.Btn_cancle.Text = "CANCLE"
        Me.Btn_cancle.UseVisualStyleBackColor = False
        '
        'Lblstunasme
        '
        Me.Lblstunasme.AutoSize = True
        Me.Lblstunasme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblstunasme.ForeColor = System.Drawing.Color.Yellow
        Me.Lblstunasme.Location = New System.Drawing.Point(132, 138)
        Me.Lblstunasme.Name = "Lblstunasme"
        Me.Lblstunasme.Size = New System.Drawing.Size(98, 15)
        Me.Lblstunasme.TabIndex = 4
        Me.Lblstunasme.Text = "Student Name"
        '
        'Btn_preiouse
        '
        Me.Btn_preiouse.BackColor = System.Drawing.Color.Indigo
        Me.Btn_preiouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_preiouse.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_preiouse.Location = New System.Drawing.Point(186, 78)
        Me.Btn_preiouse.Name = "Btn_preiouse"
        Me.Btn_preiouse.Size = New System.Drawing.Size(115, 36)
        Me.Btn_preiouse.TabIndex = 47
        Me.Btn_preiouse.Text = "PREVIOUS"
        Me.Btn_preiouse.UseVisualStyleBackColor = False
        '
        'lblstudid
        '
        Me.lblstudid.AutoSize = True
        Me.lblstudid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudid.ForeColor = System.Drawing.Color.Yellow
        Me.lblstudid.Location = New System.Drawing.Point(132, 100)
        Me.lblstudid.Name = "lblstudid"
        Me.lblstudid.Size = New System.Drawing.Size(54, 15)
        Me.lblstudid.TabIndex = 3
        Me.lblstudid.Text = "Stud ID"
        '
        'Btn_next
        '
        Me.Btn_next.BackColor = System.Drawing.Color.Indigo
        Me.Btn_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_next.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_next.Location = New System.Drawing.Point(309, 78)
        Me.Btn_next.Name = "Btn_next"
        Me.Btn_next.Size = New System.Drawing.Size(115, 36)
        Me.Btn_next.TabIndex = 45
        Me.Btn_next.Text = "NEXT"
        Me.Btn_next.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Indigo
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Yellow
        Me.btn_exit.Location = New System.Drawing.Point(432, 22)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(115, 36)
        Me.btn_exit.TabIndex = 50
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.txtstudclass)
        Me.Panel1.Controls.Add(Me.txtstudName)
        Me.Panel1.Controls.Add(Me.combstudid)
        Me.Panel1.Controls.Add(Me.DTPFeeReceiDate)
        Me.Panel1.Controls.Add(Me.txtFeeReceiptNo)
        Me.Panel1.Controls.Add(Me.FeeReciptsNo)
        Me.Panel1.Controls.Add(Me.txtamt)
        Me.Panel1.Controls.Add(Me.txtRemark)
        Me.Panel1.Controls.Add(Me.lblamt)
        Me.Panel1.Controls.Add(Me.lblstudclass)
        Me.Panel1.Controls.Add(Me.Lblstunasme)
        Me.Panel1.Controls.Add(Me.lblstudid)
        Me.Panel1.Controls.Add(Me.lblfeereceidate)
        Me.Panel1.Controls.Add(Me.lblRemark)
        Me.Panel1.Location = New System.Drawing.Point(34, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(618, 293)
        Me.Panel1.TabIndex = 53
        '
        'txtstudclass
        '
        Me.txtstudclass.BackColor = System.Drawing.Color.White
        Me.txtstudclass.Location = New System.Drawing.Point(298, 176)
        Me.txtstudclass.Name = "txtstudclass"
        Me.txtstudclass.ReadOnly = True
        Me.txtstudclass.Size = New System.Drawing.Size(151, 20)
        Me.txtstudclass.TabIndex = 26
        '
        'txtstudName
        '
        Me.txtstudName.BackColor = System.Drawing.Color.White
        Me.txtstudName.Location = New System.Drawing.Point(298, 138)
        Me.txtstudName.Name = "txtstudName"
        Me.txtstudName.ReadOnly = True
        Me.txtstudName.Size = New System.Drawing.Size(151, 20)
        Me.txtstudName.TabIndex = 25
        '
        'combstudid
        '
        Me.combstudid.BackColor = System.Drawing.Color.White
        Me.combstudid.FormattingEnabled = True
        Me.combstudid.Location = New System.Drawing.Point(298, 99)
        Me.combstudid.Name = "combstudid"
        Me.combstudid.Size = New System.Drawing.Size(121, 21)
        Me.combstudid.TabIndex = 24
        '
        'DTPFeeReceiDate
        '
        Me.DTPFeeReceiDate.CalendarTitleBackColor = System.Drawing.Color.Purple
        Me.DTPFeeReceiDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFeeReceiDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFeeReceiDate.Location = New System.Drawing.Point(299, 59)
        Me.DTPFeeReceiDate.Name = "DTPFeeReceiDate"
        Me.DTPFeeReceiDate.Size = New System.Drawing.Size(137, 22)
        Me.DTPFeeReceiDate.TabIndex = 23
        '
        'txtFeeReceiptNo
        '
        Me.txtFeeReceiptNo.BackColor = System.Drawing.Color.White
        Me.txtFeeReceiptNo.Location = New System.Drawing.Point(299, 21)
        Me.txtFeeReceiptNo.Name = "txtFeeReceiptNo"
        Me.txtFeeReceiptNo.ReadOnly = True
        Me.txtFeeReceiptNo.Size = New System.Drawing.Size(94, 20)
        Me.txtFeeReceiptNo.TabIndex = 22
        '
        'FeeReciptsNo
        '
        Me.FeeReciptsNo.AutoSize = True
        Me.FeeReciptsNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FeeReciptsNo.ForeColor = System.Drawing.Color.Yellow
        Me.FeeReciptsNo.Location = New System.Drawing.Point(132, 26)
        Me.FeeReciptsNo.Name = "FeeReciptsNo"
        Me.FeeReciptsNo.Size = New System.Drawing.Size(117, 15)
        Me.FeeReciptsNo.TabIndex = 21
        Me.FeeReciptsNo.Text = "Fees Receipt No:"
        '
        'txtamt
        '
        Me.txtamt.BackColor = System.Drawing.Color.White
        Me.txtamt.Location = New System.Drawing.Point(298, 214)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(151, 20)
        Me.txtamt.TabIndex = 19
        '
        'txtRemark
        '
        Me.txtRemark.BackColor = System.Drawing.Color.White
        Me.txtRemark.Location = New System.Drawing.Point(298, 252)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(139, 20)
        Me.txtRemark.TabIndex = 20
        '
        'lblamt
        '
        Me.lblamt.AutoSize = True
        Me.lblamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamt.ForeColor = System.Drawing.Color.Yellow
        Me.lblamt.Location = New System.Drawing.Point(132, 214)
        Me.lblamt.Name = "lblamt"
        Me.lblamt.Size = New System.Drawing.Size(55, 15)
        Me.lblamt.TabIndex = 11
        Me.lblamt.Text = "Amount"
        '
        'lblstudclass
        '
        Me.lblstudclass.AutoSize = True
        Me.lblstudclass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudclass.ForeColor = System.Drawing.Color.Yellow
        Me.lblstudclass.Location = New System.Drawing.Point(132, 177)
        Me.lblstudclass.Name = "lblstudclass"
        Me.lblstudclass.Size = New System.Drawing.Size(42, 15)
        Me.lblstudclass.TabIndex = 5
        Me.lblstudclass.Text = "Class"
        '
        'lblfeereceidate
        '
        Me.lblfeereceidate.AutoSize = True
        Me.lblfeereceidate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfeereceidate.ForeColor = System.Drawing.Color.Yellow
        Me.lblfeereceidate.Location = New System.Drawing.Point(132, 59)
        Me.lblfeereceidate.Name = "lblfeereceidate"
        Me.lblfeereceidate.Size = New System.Drawing.Size(122, 15)
        Me.lblfeereceidate.TabIndex = 2
        Me.lblfeereceidate.Text = "Fee Receipt Date:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemark.ForeColor = System.Drawing.Color.Yellow
        Me.lblRemark.Location = New System.Drawing.Point(132, 257)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(61, 15)
        Me.lblRemark.TabIndex = 6
        Me.lblRemark.Text = "Remark:"
        '
        'lblfeesReceiMast
        '
        Me.lblfeesReceiMast.BackColor = System.Drawing.Color.Purple
        Me.lblfeesReceiMast.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfeesReceiMast.ForeColor = System.Drawing.Color.Yellow
        Me.lblfeesReceiMast.Location = New System.Drawing.Point(145, 9)
        Me.lblfeesReceiMast.Name = "lblfeesReceiMast"
        Me.lblfeesReceiMast.Size = New System.Drawing.Size(408, 52)
        Me.lblfeesReceiMast.TabIndex = 52
        Me.lblfeesReceiMast.Text = "FEE RECEIPT ENTRY"
        Me.lblfeesReceiMast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_last
        '
        Me.btn_last.BackColor = System.Drawing.Color.Indigo
        Me.btn_last.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.ForeColor = System.Drawing.Color.Yellow
        Me.btn_last.Location = New System.Drawing.Point(432, 78)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(115, 36)
        Me.btn_last.TabIndex = 42
        Me.btn_last.Text = "LAST"
        Me.btn_last.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Indigo
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Yellow
        Me.btn_save.Location = New System.Drawing.Point(186, 22)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(115, 36)
        Me.btn_save.TabIndex = 43
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Btn_first
        '
        Me.Btn_first.BackColor = System.Drawing.Color.Indigo
        Me.Btn_first.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_first.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_first.Location = New System.Drawing.Point(63, 78)
        Me.Btn_first.Name = "Btn_first"
        Me.Btn_first.Size = New System.Drawing.Size(115, 36)
        Me.Btn_first.TabIndex = 41
        Me.Btn_first.Text = "FIRST"
        Me.Btn_first.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Purple
        Me.Panel3.Controls.Add(Me.btn_exit)
        Me.Panel3.Controls.Add(Me.Btn_add)
        Me.Panel3.Controls.Add(Me.Btn_cancle)
        Me.Panel3.Controls.Add(Me.Btn_preiouse)
        Me.Panel3.Controls.Add(Me.Btn_next)
        Me.Panel3.Controls.Add(Me.btn_last)
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Controls.Add(Me.Btn_first)
        Me.Panel3.Location = New System.Drawing.Point(34, 363)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(618, 157)
        Me.Panel3.TabIndex = 55
        '
        'Fee_Receipt_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(686, 573)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblfeesReceiMast)
        Me.Controls.Add(Me.Panel3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Fee_Receipt_Master"
        Me.Text = "Fee_Receipt_Master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_add As System.Windows.Forms.Button
    Friend WithEvents Btn_cancle As System.Windows.Forms.Button
    Friend WithEvents Lblstunasme As System.Windows.Forms.Label
    Friend WithEvents Btn_preiouse As System.Windows.Forms.Button
    Friend WithEvents lblstudid As System.Windows.Forms.Label
    Friend WithEvents Btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DTPFeeReceiDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFeeReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents FeeReciptsNo As System.Windows.Forms.Label
    Friend WithEvents txtamt As System.Windows.Forms.TextBox
    Friend WithEvents lblamt As System.Windows.Forms.Label
    Friend WithEvents lblstudclass As System.Windows.Forms.Label
    Friend WithEvents lblfeereceidate As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents lblfeesReceiMast As System.Windows.Forms.Label
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Btn_first As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtstudclass As System.Windows.Forms.TextBox
    Friend WithEvents txtstudName As System.Windows.Forms.TextBox
    Friend WithEvents combstudid As System.Windows.Forms.ComboBox
End Class
