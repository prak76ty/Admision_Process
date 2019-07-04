<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnQuiryMaster
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
        Me.txtpreviresult = New System.Windows.Forms.TextBox
        Me.Txtenquiryno = New System.Windows.Forms.TextBox
        Me.LblparentContactNo = New System.Windows.Forms.Label
        Me.LblparentCity = New System.Windows.Forms.Label
        Me.Lblparent = New System.Windows.Forms.Label
        Me.Cmbstudentgrnder = New System.Windows.Forms.ComboBox
        Me.txtprevistanderd = New System.Windows.Forms.TextBox
        Me.lblparentname = New System.Windows.Forms.Label
        Me.Eqno = New System.Windows.Forms.Label
        Me.Lblpschool = New System.Windows.Forms.Label
        Me.txtstudentname = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btn_exit = New System.Windows.Forms.Button
        Me.Btn_add = New System.Windows.Forms.Button
        Me.Btn_cancle = New System.Windows.Forms.Button
        Me.Btn_preiouse = New System.Windows.Forms.Button
        Me.Btn_update = New System.Windows.Forms.Button
        Me.Btn_next = New System.Windows.Forms.Button
        Me.Btn_Delete = New System.Windows.Forms.Button
        Me.btn_last = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.Btn_first = New System.Windows.Forms.Button
        Me.Lblpreviousestandard = New System.Windows.Forms.Label
        Me.Lblpreviouseresult = New System.Windows.Forms.Label
        Me.lblstudentgender = New System.Windows.Forms.Label
        Me.Lblstudentdob = New System.Windows.Forms.Label
        Me.txtprevischool = New System.Windows.Forms.TextBox
        Me.lblstudentname = New System.Windows.Forms.Label
        Me.txtparentname = New System.Windows.Forms.TextBox
        Me.Txtparentcno = New System.Windows.Forms.TextBox
        Me.Txtremark = New System.Windows.Forms.TextBox
        Me.Lblparentremark = New System.Windows.Forms.Label
        Me.txtparentcity = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtparentaddress = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblenqdate = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DTP_DOB = New System.Windows.Forms.DateTimePicker
        Me.DTP_EDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtpreviresult
        '
        Me.txtpreviresult.Location = New System.Drawing.Point(143, 19)
        Me.txtpreviresult.Name = "txtpreviresult"
        Me.txtpreviresult.Size = New System.Drawing.Size(139, 20)
        Me.txtpreviresult.TabIndex = 20
        '
        'Txtenquiryno
        '
        Me.Txtenquiryno.Location = New System.Drawing.Point(120, 15)
        Me.Txtenquiryno.Name = "Txtenquiryno"
        Me.Txtenquiryno.ReadOnly = True
        Me.Txtenquiryno.Size = New System.Drawing.Size(151, 20)
        Me.Txtenquiryno.TabIndex = 22
        '
        'LblparentContactNo
        '
        Me.LblparentContactNo.AutoSize = True
        Me.LblparentContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblparentContactNo.ForeColor = System.Drawing.Color.Yellow
        Me.LblparentContactNo.Location = New System.Drawing.Point(14, 213)
        Me.LblparentContactNo.Name = "LblparentContactNo"
        Me.LblparentContactNo.Size = New System.Drawing.Size(84, 15)
        Me.LblparentContactNo.TabIndex = 13
        Me.LblparentContactNo.Text = "Parent CNo:"
        '
        'LblparentCity
        '
        Me.LblparentCity.AutoSize = True
        Me.LblparentCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblparentCity.ForeColor = System.Drawing.Color.Yellow
        Me.LblparentCity.Location = New System.Drawing.Point(14, 179)
        Me.LblparentCity.Name = "LblparentCity"
        Me.LblparentCity.Size = New System.Drawing.Size(80, 15)
        Me.LblparentCity.TabIndex = 12
        Me.LblparentCity.Text = "Parent City:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lblparent
        '
        Me.Lblparent.AutoSize = True
        Me.Lblparent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblparent.ForeColor = System.Drawing.Color.Yellow
        Me.Lblparent.Location = New System.Drawing.Point(14, 140)
        Me.Lblparent.Name = "Lblparent"
        Me.Lblparent.Size = New System.Drawing.Size(108, 15)
        Me.Lblparent.TabIndex = 10
        Me.Lblparent.Text = "Parent Address:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Cmbstudentgrnder
        '
        Me.Cmbstudentgrnder.FormattingEnabled = True
        Me.Cmbstudentgrnder.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.Cmbstudentgrnder.Location = New System.Drawing.Point(122, 180)
        Me.Cmbstudentgrnder.Name = "Cmbstudentgrnder"
        Me.Cmbstudentgrnder.Size = New System.Drawing.Size(149, 21)
        Me.Cmbstudentgrnder.TabIndex = 20
        '
        'txtprevistanderd
        '
        Me.txtprevistanderd.Location = New System.Drawing.Point(120, 218)
        Me.txtprevistanderd.Name = "txtprevistanderd"
        Me.txtprevistanderd.Size = New System.Drawing.Size(151, 20)
        Me.txtprevistanderd.TabIndex = 19
        '
        'lblparentname
        '
        Me.lblparentname.AutoSize = True
        Me.lblparentname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblparentname.ForeColor = System.Drawing.Color.Yellow
        Me.lblparentname.Location = New System.Drawing.Point(14, 102)
        Me.lblparentname.Name = "lblparentname"
        Me.lblparentname.Size = New System.Drawing.Size(95, 15)
        Me.lblparentname.TabIndex = 8
        Me.lblparentname.Text = "Parent Name:"
        '
        'Eqno
        '
        Me.Eqno.AutoSize = True
        Me.Eqno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eqno.ForeColor = System.Drawing.Color.Yellow
        Me.Eqno.Location = New System.Drawing.Point(9, 20)
        Me.Eqno.Name = "Eqno"
        Me.Eqno.Size = New System.Drawing.Size(81, 15)
        Me.Eqno.TabIndex = 21
        Me.Eqno.Text = "Enquiry No:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lblpschool
        '
        Me.Lblpschool.AutoSize = True
        Me.Lblpschool.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpschool.ForeColor = System.Drawing.Color.Yellow
        Me.Lblpschool.Location = New System.Drawing.Point(14, 61)
        Me.Lblpschool.Name = "Lblpschool"
        Me.Lblpschool.Size = New System.Drawing.Size(122, 15)
        Me.Lblpschool.TabIndex = 7
        Me.Lblpschool.Text = "Previouse School:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtstudentname
        '
        Me.txtstudentname.Location = New System.Drawing.Point(120, 88)
        Me.txtstudentname.Name = "txtstudentname"
        Me.txtstudentname.Size = New System.Drawing.Size(151, 20)
        Me.txtstudentname.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Purple
        Me.Panel3.Controls.Add(Me.btn_exit)
        Me.Panel3.Controls.Add(Me.Btn_add)
        Me.Panel3.Controls.Add(Me.Btn_cancle)
        Me.Panel3.Controls.Add(Me.Btn_preiouse)
        Me.Panel3.Controls.Add(Me.Btn_update)
        Me.Panel3.Controls.Add(Me.Btn_next)
        Me.Panel3.Controls.Add(Me.Btn_Delete)
        Me.Panel3.Controls.Add(Me.btn_last)
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Controls.Add(Me.Btn_first)
        Me.Panel3.Location = New System.Drawing.Point(45, 405)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(618, 126)
        Me.Panel3.TabIndex = 51
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Indigo
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Yellow
        Me.btn_exit.Location = New System.Drawing.Point(281, 68)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(94, 40)
        Me.btn_exit.TabIndex = 50
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Btn_add
        '
        Me.Btn_add.BackColor = System.Drawing.Color.Indigo
        Me.Btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_add.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_add.Location = New System.Drawing.Point(49, 12)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.Size = New System.Drawing.Size(94, 40)
        Me.Btn_add.TabIndex = 49
        Me.Btn_add.Text = "ADDNEW"
        Me.Btn_add.UseVisualStyleBackColor = False
        '
        'Btn_cancle
        '
        Me.Btn_cancle.BackColor = System.Drawing.Color.Indigo
        Me.Btn_cancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancle.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_cancle.Location = New System.Drawing.Point(281, 12)
        Me.Btn_cancle.Name = "Btn_cancle"
        Me.Btn_cancle.Size = New System.Drawing.Size(94, 40)
        Me.Btn_cancle.TabIndex = 48
        Me.Btn_cancle.Text = "CANCLE"
        Me.Btn_cancle.UseVisualStyleBackColor = False
        '
        'Btn_preiouse
        '
        Me.Btn_preiouse.BackColor = System.Drawing.Color.Indigo
        Me.Btn_preiouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_preiouse.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_preiouse.Location = New System.Drawing.Point(174, 68)
        Me.Btn_preiouse.Name = "Btn_preiouse"
        Me.Btn_preiouse.Size = New System.Drawing.Size(94, 40)
        Me.Btn_preiouse.TabIndex = 47
        Me.Btn_preiouse.Text = "PREVIOUS"
        Me.Btn_preiouse.UseVisualStyleBackColor = False
        '
        'Btn_update
        '
        Me.Btn_update.BackColor = System.Drawing.Color.Indigo
        Me.Btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_update.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_update.Location = New System.Drawing.Point(492, 12)
        Me.Btn_update.Name = "Btn_update"
        Me.Btn_update.Size = New System.Drawing.Size(94, 40)
        Me.Btn_update.TabIndex = 46
        Me.Btn_update.Text = "UPDATE"
        Me.Btn_update.UseVisualStyleBackColor = False
        '
        'Btn_next
        '
        Me.Btn_next.BackColor = System.Drawing.Color.Indigo
        Me.Btn_next.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_next.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_next.Location = New System.Drawing.Point(387, 67)
        Me.Btn_next.Name = "Btn_next"
        Me.Btn_next.Size = New System.Drawing.Size(94, 40)
        Me.Btn_next.TabIndex = 45
        Me.Btn_next.Text = "NEXT"
        Me.Btn_next.UseVisualStyleBackColor = False
        '
        'Btn_Delete
        '
        Me.Btn_Delete.BackColor = System.Drawing.Color.Indigo
        Me.Btn_Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delete.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_Delete.Location = New System.Drawing.Point(387, 12)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(94, 40)
        Me.Btn_Delete.TabIndex = 44
        Me.Btn_Delete.Text = "DELETE"
        Me.Btn_Delete.UseVisualStyleBackColor = False
        '
        'btn_last
        '
        Me.btn_last.BackColor = System.Drawing.Color.Indigo
        Me.btn_last.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_last.ForeColor = System.Drawing.Color.Yellow
        Me.btn_last.Location = New System.Drawing.Point(492, 67)
        Me.btn_last.Name = "btn_last"
        Me.btn_last.Size = New System.Drawing.Size(94, 40)
        Me.btn_last.TabIndex = 42
        Me.btn_last.Text = "LAST"
        Me.btn_last.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Indigo
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Yellow
        Me.btn_save.Location = New System.Drawing.Point(174, 12)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 40)
        Me.btn_save.TabIndex = 43
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Btn_first
        '
        Me.Btn_first.BackColor = System.Drawing.Color.Indigo
        Me.Btn_first.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_first.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_first.Location = New System.Drawing.Point(49, 67)
        Me.Btn_first.Name = "Btn_first"
        Me.Btn_first.Size = New System.Drawing.Size(94, 40)
        Me.Btn_first.TabIndex = 41
        Me.Btn_first.Text = "FIRST"
        Me.Btn_first.UseVisualStyleBackColor = False
        '
        'Lblpreviousestandard
        '
        Me.Lblpreviousestandard.AutoSize = True
        Me.Lblpreviousestandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpreviousestandard.ForeColor = System.Drawing.Color.Yellow
        Me.Lblpreviousestandard.Location = New System.Drawing.Point(9, 214)
        Me.Lblpreviousestandard.Name = "Lblpreviousestandard"
        Me.Lblpreviousestandard.Size = New System.Drawing.Size(105, 15)
        Me.Lblpreviousestandard.TabIndex = 11
        Me.Lblpreviousestandard.Text = "Previ Standard:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Lblpreviouseresult
        '
        Me.Lblpreviouseresult.AutoSize = True
        Me.Lblpreviouseresult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpreviouseresult.ForeColor = System.Drawing.Color.Yellow
        Me.Lblpreviouseresult.Location = New System.Drawing.Point(14, 24)
        Me.Lblpreviouseresult.Name = "Lblpreviouseresult"
        Me.Lblpreviouseresult.Size = New System.Drawing.Size(119, 15)
        Me.Lblpreviouseresult.TabIndex = 6
        Me.Lblpreviouseresult.Text = "Previouse Result:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblstudentgender
        '
        Me.lblstudentgender.AutoSize = True
        Me.lblstudentgender.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudentgender.ForeColor = System.Drawing.Color.Yellow
        Me.lblstudentgender.Location = New System.Drawing.Point(9, 180)
        Me.lblstudentgender.Name = "lblstudentgender"
        Me.lblstudentgender.Size = New System.Drawing.Size(83, 15)
        Me.lblstudentgender.TabIndex = 5
        Me.lblstudentgender.Text = "Stu Gender:"
        '
        'Lblstudentdob
        '
        Me.Lblstudentdob.AutoSize = True
        Me.Lblstudentdob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblstudentdob.ForeColor = System.Drawing.Color.Yellow
        Me.Lblstudentdob.Location = New System.Drawing.Point(9, 136)
        Me.Lblstudentdob.Name = "Lblstudentdob"
        Me.Lblstudentdob.Size = New System.Drawing.Size(65, 30)
        Me.Lblstudentdob.TabIndex = 4
        Me.Lblstudentdob.Text = "Stu DOB:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtprevischool
        '
        Me.txtprevischool.Location = New System.Drawing.Point(143, 60)
        Me.txtprevischool.Name = "txtprevischool"
        Me.txtprevischool.Size = New System.Drawing.Size(135, 20)
        Me.txtprevischool.TabIndex = 21
        '
        'lblstudentname
        '
        Me.lblstudentname.AutoSize = True
        Me.lblstudentname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudentname.ForeColor = System.Drawing.Color.Yellow
        Me.lblstudentname.Location = New System.Drawing.Point(5, 88)
        Me.lblstudentname.Name = "lblstudentname"
        Me.lblstudentname.Size = New System.Drawing.Size(74, 30)
        Me.lblstudentname.TabIndex = 3
        Me.lblstudentname.Text = "Stu Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtparentname
        '
        Me.txtparentname.Location = New System.Drawing.Point(143, 100)
        Me.txtparentname.Name = "txtparentname"
        Me.txtparentname.Size = New System.Drawing.Size(138, 20)
        Me.txtparentname.TabIndex = 22
        '
        'Txtparentcno
        '
        Me.Txtparentcno.Location = New System.Drawing.Point(147, 217)
        Me.Txtparentcno.Name = "Txtparentcno"
        Me.Txtparentcno.Size = New System.Drawing.Size(136, 20)
        Me.Txtparentcno.TabIndex = 26
        '
        'Txtremark
        '
        Me.Txtremark.Location = New System.Drawing.Point(147, 249)
        Me.Txtremark.Name = "Txtremark"
        Me.Txtremark.Size = New System.Drawing.Size(135, 20)
        Me.Txtremark.TabIndex = 28
        '
        'Lblparentremark
        '
        Me.Lblparentremark.AutoSize = True
        Me.Lblparentremark.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblparentremark.ForeColor = System.Drawing.Color.Yellow
        Me.Lblparentremark.Location = New System.Drawing.Point(14, 250)
        Me.Lblparentremark.Name = "Lblparentremark"
        Me.Lblparentremark.Size = New System.Drawing.Size(61, 15)
        Me.Lblparentremark.TabIndex = 27
        Me.Lblparentremark.Text = "Remark:"
        '
        'txtparentcity
        '
        Me.txtparentcity.Location = New System.Drawing.Point(146, 182)
        Me.txtparentcity.Name = "txtparentcity"
        Me.txtparentcity.Size = New System.Drawing.Size(137, 20)
        Me.txtparentcity.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Purple
        Me.Panel2.Controls.Add(Me.Txtremark)
        Me.Panel2.Controls.Add(Me.Lblparentremark)
        Me.Panel2.Controls.Add(Me.Txtparentcno)
        Me.Panel2.Controls.Add(Me.txtparentcity)
        Me.Panel2.Controls.Add(Me.txtparentaddress)
        Me.Panel2.Controls.Add(Me.txtparentname)
        Me.Panel2.Controls.Add(Me.txtprevischool)
        Me.Panel2.Controls.Add(Me.txtpreviresult)
        Me.Panel2.Controls.Add(Me.LblparentContactNo)
        Me.Panel2.Controls.Add(Me.LblparentCity)
        Me.Panel2.Controls.Add(Me.Lblparent)
        Me.Panel2.Controls.Add(Me.lblparentname)
        Me.Panel2.Controls.Add(Me.Lblpschool)
        Me.Panel2.Controls.Add(Me.Lblpreviouseresult)
        Me.Panel2.Location = New System.Drawing.Point(360, 107)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(303, 292)
        Me.Panel2.TabIndex = 50
        '
        'txtparentaddress
        '
        Me.txtparentaddress.Location = New System.Drawing.Point(145, 135)
        Me.txtparentaddress.Multiline = True
        Me.txtparentaddress.Name = "txtparentaddress"
        Me.txtparentaddress.Size = New System.Drawing.Size(138, 38)
        Me.txtparentaddress.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Purple
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Yellow
        Me.Label9.Location = New System.Drawing.Point(248, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(221, 34)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "ENQUIRY MASTER"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblenqdate
        '
        Me.lblenqdate.AutoSize = True
        Me.lblenqdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblenqdate.ForeColor = System.Drawing.Color.Yellow
        Me.lblenqdate.Location = New System.Drawing.Point(9, 52)
        Me.lblenqdate.Name = "lblenqdate"
        Me.lblenqdate.Size = New System.Drawing.Size(70, 15)
        Me.lblenqdate.TabIndex = 2
        Me.lblenqdate.Text = "Enq Date:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.DTP_DOB)
        Me.Panel1.Controls.Add(Me.DTP_EDate)
        Me.Panel1.Controls.Add(Me.Txtenquiryno)
        Me.Panel1.Controls.Add(Me.Eqno)
        Me.Panel1.Controls.Add(Me.Cmbstudentgrnder)
        Me.Panel1.Controls.Add(Me.txtprevistanderd)
        Me.Panel1.Controls.Add(Me.txtstudentname)
        Me.Panel1.Controls.Add(Me.Lblpreviousestandard)
        Me.Panel1.Controls.Add(Me.lblstudentgender)
        Me.Panel1.Controls.Add(Me.Lblstudentdob)
        Me.Panel1.Controls.Add(Me.lblstudentname)
        Me.Panel1.Controls.Add(Me.lblenqdate)
        Me.Panel1.Location = New System.Drawing.Point(45, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 293)
        Me.Panel1.TabIndex = 49
        '
        'DTP_DOB
        '
        Me.DTP_DOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_DOB.Location = New System.Drawing.Point(120, 132)
        Me.DTP_DOB.Name = "DTP_DOB"
        Me.DTP_DOB.Size = New System.Drawing.Size(137, 22)
        Me.DTP_DOB.TabIndex = 24
        '
        'DTP_EDate
        '
        Me.DTP_EDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_EDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_EDate.Location = New System.Drawing.Point(120, 55)
        Me.DTP_EDate.Name = "DTP_EDate"
        Me.DTP_EDate.Size = New System.Drawing.Size(137, 22)
        Me.DTP_EDate.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Purple
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(88, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 38)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Mithabai Madhyamik Kanya Vidyalay"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnQuiryMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(711, 537)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EnQuiryMaster"
        Me.Text = "EnQuiryMaster"
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtpreviresult As System.Windows.Forms.TextBox
    Friend WithEvents Txtenquiryno As System.Windows.Forms.TextBox
    Friend WithEvents LblparentContactNo As System.Windows.Forms.Label
    Friend WithEvents LblparentCity As System.Windows.Forms.Label
    Friend WithEvents Lblparent As System.Windows.Forms.Label
    Friend WithEvents Cmbstudentgrnder As System.Windows.Forms.ComboBox
    Friend WithEvents txtprevistanderd As System.Windows.Forms.TextBox
    Friend WithEvents lblparentname As System.Windows.Forms.Label
    Friend WithEvents Eqno As System.Windows.Forms.Label
    Friend WithEvents Lblpschool As System.Windows.Forms.Label
    Friend WithEvents txtstudentname As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Lblpreviousestandard As System.Windows.Forms.Label
    Friend WithEvents Lblpreviouseresult As System.Windows.Forms.Label
    Friend WithEvents lblstudentgender As System.Windows.Forms.Label
    Friend WithEvents Lblstudentdob As System.Windows.Forms.Label
    Friend WithEvents txtprevischool As System.Windows.Forms.TextBox
    Friend WithEvents lblstudentname As System.Windows.Forms.Label
    Friend WithEvents txtparentname As System.Windows.Forms.TextBox
    Friend WithEvents Txtparentcno As System.Windows.Forms.TextBox
    Friend WithEvents Txtremark As System.Windows.Forms.TextBox
    Friend WithEvents Lblparentremark As System.Windows.Forms.Label
    Friend WithEvents txtparentcity As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtparentaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblenqdate As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DTP_DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_EDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents Btn_add As System.Windows.Forms.Button
    Friend WithEvents Btn_cancle As System.Windows.Forms.Button
    Friend WithEvents Btn_preiouse As System.Windows.Forms.Button
    Friend WithEvents Btn_update As System.Windows.Forms.Button
    Friend WithEvents Btn_next As System.Windows.Forms.Button
    Friend WithEvents Btn_Delete As System.Windows.Forms.Button
    Friend WithEvents btn_last As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Btn_first As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
