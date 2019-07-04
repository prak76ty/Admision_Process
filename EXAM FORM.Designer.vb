<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EXAM_FORM
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
        Me.TXTSRNO = New System.Windows.Forms.TextBox
        Me.btn_exit = New System.Windows.Forms.Button
        Me.TXTPTSOFTSKILL = New System.Windows.Forms.TextBox
        Me.TXTHISTORY = New System.Windows.Forms.TextBox
        Me.TXTGEO = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Btn_add = New System.Windows.Forms.Button
        Me.Btn_cancle = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.TXTMATH = New System.Windows.Forms.TextBox
        Me.CMBSTUDENTID = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbTeacherid = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXTTOTALMARKS = New System.Windows.Forms.TextBox
        Me.TXTTEACNAME = New System.Windows.Forms.TextBox
        Me.TXTREMARK = New System.Windows.Forms.TextBox
        Me.TXTGREAD = New System.Windows.Forms.TextBox
        Me.TXTPER = New System.Windows.Forms.TextBox
        Me.LBLREMARK = New System.Windows.Forms.Label
        Me.lbLGERAD = New System.Windows.Forms.Label
        Me.LBLPER = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.TXTSCINCE = New System.Windows.Forms.TextBox
        Me.TXTHINDI = New System.Windows.Forms.TextBox
        Me.TXTMARATHI = New System.Windows.Forms.TextBox
        Me.LBLMATH = New System.Windows.Forms.Label
        Me.lblGEO = New System.Windows.Forms.Label
        Me.TXTENGLISH = New System.Windows.Forms.TextBox
        Me.LBLSCINCE = New System.Windows.Forms.Label
        Me.lblENGLISH = New System.Windows.Forms.Label
        Me.LBLHINDI = New System.Windows.Forms.Label
        Me.LBLMARATHI = New System.Windows.Forms.Label
        Me.LBLHISTORY = New System.Windows.Forms.Label
        Me.LBLPTSOFTSKILL = New System.Windows.Forms.Label
        Me.LBLSRNO = New System.Windows.Forms.Label
        Me.LBLTOTALMARKS = New System.Windows.Forms.Label
        Me.LBLTEACID = New System.Windows.Forms.Label
        Me.TXTSTUCLASS = New System.Windows.Forms.TextBox
        Me.TXTSTUDENTNAME = New System.Windows.Forms.TextBox
        Me.lblTEACNAME = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LBLSTUDCLASS = New System.Windows.Forms.Label
        Me.LBLSTUDNAME = New System.Windows.Forms.Label
        Me.LBLSTUDID = New System.Windows.Forms.Label
        Me.LBLEXAMFROM = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTSRNO
        '
        Me.TXTSRNO.Location = New System.Drawing.Point(88, 20)
        Me.TXTSRNO.Name = "TXTSRNO"
        Me.TXTSRNO.ReadOnly = True
        Me.TXTSRNO.Size = New System.Drawing.Size(62, 21)
        Me.TXTSRNO.TabIndex = 55
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Indigo
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Yellow
        Me.btn_exit.Location = New System.Drawing.Point(564, 37)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(94, 32)
        Me.btn_exit.TabIndex = 40
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'TXTPTSOFTSKILL
        '
        Me.TXTPTSOFTSKILL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPTSOFTSKILL.Location = New System.Drawing.Point(439, 123)
        Me.TXTPTSOFTSKILL.MaxLength = 2
        Me.TXTPTSOFTSKILL.Name = "TXTPTSOFTSKILL"
        Me.TXTPTSOFTSKILL.Size = New System.Drawing.Size(84, 22)
        Me.TXTPTSOFTSKILL.TabIndex = 50
        '
        'TXTHISTORY
        '
        Me.TXTHISTORY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHISTORY.Location = New System.Drawing.Point(181, 123)
        Me.TXTHISTORY.MaxLength = 2
        Me.TXTHISTORY.Name = "TXTHISTORY"
        Me.TXTHISTORY.Size = New System.Drawing.Size(84, 22)
        Me.TXTHISTORY.TabIndex = 49
        '
        'TXTGEO
        '
        Me.TXTGEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGEO.Location = New System.Drawing.Point(181, 86)
        Me.TXTGEO.MaxLength = 2
        Me.TXTGEO.Name = "TXTGEO"
        Me.TXTGEO.Size = New System.Drawing.Size(84, 22)
        Me.TXTGEO.TabIndex = 47
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Purple
        Me.Panel3.Controls.Add(Me.btn_exit)
        Me.Panel3.Controls.Add(Me.Btn_add)
        Me.Panel3.Controls.Add(Me.Btn_cancle)
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Location = New System.Drawing.Point(11, 531)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(817, 100)
        Me.Panel3.TabIndex = 49
        '
        'Btn_add
        '
        Me.Btn_add.BackColor = System.Drawing.Color.Indigo
        Me.Btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_add.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_add.Location = New System.Drawing.Point(150, 37)
        Me.Btn_add.Name = "Btn_add"
        Me.Btn_add.Size = New System.Drawing.Size(94, 32)
        Me.Btn_add.TabIndex = 39
        Me.Btn_add.Text = "ADDNEW"
        Me.Btn_add.UseVisualStyleBackColor = False
        '
        'Btn_cancle
        '
        Me.Btn_cancle.BackColor = System.Drawing.Color.Indigo
        Me.Btn_cancle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancle.ForeColor = System.Drawing.Color.Yellow
        Me.Btn_cancle.Location = New System.Drawing.Point(434, 37)
        Me.Btn_cancle.Name = "Btn_cancle"
        Me.Btn_cancle.Size = New System.Drawing.Size(94, 32)
        Me.Btn_cancle.TabIndex = 36
        Me.Btn_cancle.Text = "CANCLE"
        Me.Btn_cancle.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Indigo
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Yellow
        Me.btn_save.Location = New System.Drawing.Point(292, 37)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(94, 32)
        Me.btn_save.TabIndex = 30
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'TXTMATH
        '
        Me.TXTMATH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMATH.Location = New System.Drawing.Point(439, 86)
        Me.TXTMATH.MaxLength = 2
        Me.TXTMATH.Name = "TXTMATH"
        Me.TXTMATH.Size = New System.Drawing.Size(84, 22)
        Me.TXTMATH.TabIndex = 48
        '
        'CMBSTUDENTID
        '
        Me.CMBSTUDENTID.FormattingEnabled = True
        Me.CMBSTUDENTID.Location = New System.Drawing.Point(259, 19)
        Me.CMBSTUDENTID.Name = "CMBSTUDENTID"
        Me.CMBSTUDENTID.Size = New System.Drawing.Size(86, 23)
        Me.CMBSTUDENTID.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Purple
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CmbTeacherid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TXTTOTALMARKS)
        Me.Panel1.Controls.Add(Me.TXTTEACNAME)
        Me.Panel1.Controls.Add(Me.TXTREMARK)
        Me.Panel1.Controls.Add(Me.TXTGREAD)
        Me.Panel1.Controls.Add(Me.TXTPER)
        Me.Panel1.Controls.Add(Me.LBLREMARK)
        Me.Panel1.Controls.Add(Me.lbLGERAD)
        Me.Panel1.Controls.Add(Me.LBLPER)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.TXTSRNO)
        Me.Panel1.Controls.Add(Me.CMBSTUDENTID)
        Me.Panel1.Controls.Add(Me.LBLSRNO)
        Me.Panel1.Controls.Add(Me.LBLTOTALMARKS)
        Me.Panel1.Controls.Add(Me.LBLTEACID)
        Me.Panel1.Controls.Add(Me.TXTSTUCLASS)
        Me.Panel1.Controls.Add(Me.TXTSTUDENTNAME)
        Me.Panel1.Controls.Add(Me.lblTEACNAME)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.LBLSTUDCLASS)
        Me.Panel1.Controls.Add(Me.LBLSTUDNAME)
        Me.Panel1.Controls.Add(Me.LBLSTUDID)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(10, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 402)
        Me.Panel1.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(645, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 15)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "%"
        '
        'CmbTeacherid
        '
        Me.CmbTeacherid.FormattingEnabled = True
        Me.CmbTeacherid.Location = New System.Drawing.Point(387, 73)
        Me.CmbTeacherid.Name = "CmbTeacherid"
        Me.CmbTeacherid.Size = New System.Drawing.Size(108, 23)
        Me.CmbTeacherid.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AccessibleName = "S"
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(350, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Marks Obtained"
        '
        'TXTTOTALMARKS
        '
        Me.TXTTOTALMARKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALMARKS.Location = New System.Drawing.Point(291, 321)
        Me.TXTTOTALMARKS.Name = "TXTTOTALMARKS"
        Me.TXTTOTALMARKS.ReadOnly = True
        Me.TXTTOTALMARKS.Size = New System.Drawing.Size(87, 22)
        Me.TXTTOTALMARKS.TabIndex = 65
        '
        'TXTTEACNAME
        '
        Me.TXTTEACNAME.Location = New System.Drawing.Point(643, 73)
        Me.TXTTEACNAME.Name = "TXTTEACNAME"
        Me.TXTTEACNAME.ReadOnly = True
        Me.TXTTEACNAME.Size = New System.Drawing.Size(165, 21)
        Me.TXTTEACNAME.TabIndex = 63
        '
        'TXTREMARK
        '
        Me.TXTREMARK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTREMARK.Location = New System.Drawing.Point(552, 353)
        Me.TXTREMARK.Name = "TXTREMARK"
        Me.TXTREMARK.Size = New System.Drawing.Size(87, 22)
        Me.TXTREMARK.TabIndex = 62
        '
        'TXTGREAD
        '
        Me.TXTGREAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGREAD.Location = New System.Drawing.Point(291, 356)
        Me.TXTGREAD.Name = "TXTGREAD"
        Me.TXTGREAD.Size = New System.Drawing.Size(87, 22)
        Me.TXTGREAD.TabIndex = 61
        '
        'TXTPER
        '
        Me.TXTPER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPER.Location = New System.Drawing.Point(552, 319)
        Me.TXTPER.Name = "TXTPER"
        Me.TXTPER.ReadOnly = True
        Me.TXTPER.Size = New System.Drawing.Size(87, 22)
        Me.TXTPER.TabIndex = 60
        '
        'LBLREMARK
        '
        Me.LBLREMARK.AutoSize = True
        Me.LBLREMARK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLREMARK.ForeColor = System.Drawing.Color.Gold
        Me.LBLREMARK.Location = New System.Drawing.Point(458, 356)
        Me.LBLREMARK.Name = "LBLREMARK"
        Me.LBLREMARK.Size = New System.Drawing.Size(69, 15)
        Me.LBLREMARK.TabIndex = 59
        Me.LBLREMARK.Text = "REMARK:"
        '
        'lbLGERAD
        '
        Me.lbLGERAD.AutoSize = True
        Me.lbLGERAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbLGERAD.ForeColor = System.Drawing.Color.Gold
        Me.lbLGERAD.Location = New System.Drawing.Point(202, 359)
        Me.lbLGERAD.Name = "lbLGERAD"
        Me.lbLGERAD.Size = New System.Drawing.Size(58, 15)
        Me.lbLGERAD.TabIndex = 58
        Me.lbLGERAD.Text = "GRADE:"
        '
        'LBLPER
        '
        Me.LBLPER.AutoSize = True
        Me.LBLPER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPER.ForeColor = System.Drawing.Color.Gold
        Me.LBLPER.Location = New System.Drawing.Point(424, 326)
        Me.LBLPER.Name = "LBLPER"
        Me.LBLPER.Size = New System.Drawing.Size(102, 15)
        Me.LBLPER.TabIndex = 57
        Me.LBLPER.Text = "PERCENTAGE:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TXTSCINCE)
        Me.Panel2.Controls.Add(Me.TXTHINDI)
        Me.Panel2.Controls.Add(Me.TXTMARATHI)
        Me.Panel2.Controls.Add(Me.TXTMATH)
        Me.Panel2.Controls.Add(Me.TXTGEO)
        Me.Panel2.Controls.Add(Me.LBLMATH)
        Me.Panel2.Controls.Add(Me.TXTPTSOFTSKILL)
        Me.Panel2.Controls.Add(Me.lblGEO)
        Me.Panel2.Controls.Add(Me.TXTHISTORY)
        Me.Panel2.Controls.Add(Me.TXTENGLISH)
        Me.Panel2.Controls.Add(Me.LBLSCINCE)
        Me.Panel2.Controls.Add(Me.lblENGLISH)
        Me.Panel2.Controls.Add(Me.LBLHINDI)
        Me.Panel2.Controls.Add(Me.LBLMARATHI)
        Me.Panel2.Controls.Add(Me.LBLHISTORY)
        Me.Panel2.Controls.Add(Me.LBLPTSOFTSKILL)
        Me.Panel2.Location = New System.Drawing.Point(109, 136)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(611, 160)
        Me.Panel2.TabIndex = 56
        '
        'TXTSCINCE
        '
        Me.TXTSCINCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSCINCE.Location = New System.Drawing.Point(439, 49)
        Me.TXTSCINCE.MaxLength = 2
        Me.TXTSCINCE.Name = "TXTSCINCE"
        Me.TXTSCINCE.Size = New System.Drawing.Size(84, 22)
        Me.TXTSCINCE.TabIndex = 53
        '
        'TXTHINDI
        '
        Me.TXTHINDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHINDI.Location = New System.Drawing.Point(439, 12)
        Me.TXTHINDI.MaxLength = 2
        Me.TXTHINDI.Name = "TXTHINDI"
        Me.TXTHINDI.Size = New System.Drawing.Size(84, 22)
        Me.TXTHINDI.TabIndex = 52
        '
        'TXTMARATHI
        '
        Me.TXTMARATHI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMARATHI.Location = New System.Drawing.Point(181, 12)
        Me.TXTMARATHI.MaxLength = 2
        Me.TXTMARATHI.Name = "TXTMARATHI"
        Me.TXTMARATHI.Size = New System.Drawing.Size(84, 22)
        Me.TXTMARATHI.TabIndex = 51
        '
        'LBLMATH
        '
        Me.LBLMATH.AutoSize = True
        Me.LBLMATH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMATH.ForeColor = System.Drawing.Color.Gold
        Me.LBLMATH.Location = New System.Drawing.Point(368, 89)
        Me.LBLMATH.Name = "LBLMATH"
        Me.LBLMATH.Size = New System.Drawing.Size(49, 15)
        Me.LBLMATH.TabIndex = 27
        Me.LBLMATH.Text = "MATH:"
        '
        'lblGEO
        '
        Me.lblGEO.AutoSize = True
        Me.lblGEO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGEO.ForeColor = System.Drawing.Color.Gold
        Me.lblGEO.Location = New System.Drawing.Point(59, 89)
        Me.lblGEO.Name = "lblGEO"
        Me.lblGEO.Size = New System.Drawing.Size(95, 15)
        Me.lblGEO.TabIndex = 26
        Me.lblGEO.Text = "GEOGRAPHY:"
        '
        'TXTENGLISH
        '
        Me.TXTENGLISH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTENGLISH.Location = New System.Drawing.Point(181, 49)
        Me.TXTENGLISH.MaxLength = 2
        Me.TXTENGLISH.Name = "TXTENGLISH"
        Me.TXTENGLISH.Size = New System.Drawing.Size(84, 22)
        Me.TXTENGLISH.TabIndex = 22
        '
        'LBLSCINCE
        '
        Me.LBLSCINCE.AutoSize = True
        Me.LBLSCINCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSCINCE.ForeColor = System.Drawing.Color.Gold
        Me.LBLSCINCE.Location = New System.Drawing.Point(356, 52)
        Me.LBLSCINCE.Name = "LBLSCINCE"
        Me.LBLSCINCE.Size = New System.Drawing.Size(61, 15)
        Me.LBLSCINCE.TabIndex = 10
        Me.LBLSCINCE.Text = "SCINCE:"
        '
        'lblENGLISH
        '
        Me.lblENGLISH.AutoSize = True
        Me.lblENGLISH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblENGLISH.ForeColor = System.Drawing.Color.Gold
        Me.lblENGLISH.Location = New System.Drawing.Point(83, 52)
        Me.lblENGLISH.Name = "lblENGLISH"
        Me.lblENGLISH.Size = New System.Drawing.Size(71, 15)
        Me.lblENGLISH.TabIndex = 8
        Me.lblENGLISH.Text = "ENGLISH:"
        '
        'LBLHINDI
        '
        Me.LBLHINDI.AutoSize = True
        Me.LBLHINDI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHINDI.ForeColor = System.Drawing.Color.Gold
        Me.LBLHINDI.Location = New System.Drawing.Point(368, 15)
        Me.LBLHINDI.Name = "LBLHINDI"
        Me.LBLHINDI.Size = New System.Drawing.Size(49, 15)
        Me.LBLHINDI.TabIndex = 7
        Me.LBLHINDI.Text = "HINDI:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LBLMARATHI
        '
        Me.LBLMARATHI.AutoSize = True
        Me.LBLMARATHI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMARATHI.ForeColor = System.Drawing.Color.Gold
        Me.LBLMARATHI.Location = New System.Drawing.Point(83, 15)
        Me.LBLMARATHI.Name = "LBLMARATHI"
        Me.LBLMARATHI.Size = New System.Drawing.Size(71, 15)
        Me.LBLMARATHI.TabIndex = 6
        Me.LBLMARATHI.Text = "MARATHI:"
        '
        'LBLHISTORY
        '
        Me.LBLHISTORY.AutoSize = True
        Me.LBLHISTORY.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHISTORY.ForeColor = System.Drawing.Color.Gold
        Me.LBLHISTORY.Location = New System.Drawing.Point(84, 126)
        Me.LBLHISTORY.Name = "LBLHISTORY"
        Me.LBLHISTORY.Size = New System.Drawing.Size(70, 15)
        Me.LBLHISTORY.TabIndex = 28
        Me.LBLHISTORY.Text = "HISTORY:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LBLPTSOFTSKILL
        '
        Me.LBLPTSOFTSKILL.AutoSize = True
        Me.LBLPTSOFTSKILL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPTSOFTSKILL.ForeColor = System.Drawing.Color.Gold
        Me.LBLPTSOFTSKILL.Location = New System.Drawing.Point(312, 126)
        Me.LBLPTSOFTSKILL.Name = "LBLPTSOFTSKILL"
        Me.LBLPTSOFTSKILL.Size = New System.Drawing.Size(105, 15)
        Me.LBLPTSOFTSKILL.TabIndex = 29
        Me.LBLPTSOFTSKILL.Text = "PT SOFTSKILL:"
        '
        'LBLSRNO
        '
        Me.LBLSRNO.AccessibleDescription = "l"
        Me.LBLSRNO.AutoSize = True
        Me.LBLSRNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSRNO.ForeColor = System.Drawing.Color.Gold
        Me.LBLSRNO.Location = New System.Drawing.Point(28, 23)
        Me.LBLSRNO.Name = "LBLSRNO"
        Me.LBLSRNO.Size = New System.Drawing.Size(54, 15)
        Me.LBLSRNO.TabIndex = 34
        Me.LBLSRNO.Text = "SR NO:"
        '
        'LBLTOTALMARKS
        '
        Me.LBLTOTALMARKS.AutoSize = True
        Me.LBLTOTALMARKS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOTALMARKS.ForeColor = System.Drawing.Color.Gold
        Me.LBLTOTALMARKS.Location = New System.Drawing.Point(160, 326)
        Me.LBLTOTALMARKS.Name = "LBLTOTALMARKS"
        Me.LBLTOTALMARKS.Size = New System.Drawing.Size(105, 15)
        Me.LBLTOTALMARKS.TabIndex = 30
        Me.LBLTOTALMARKS.Text = "TOTAL MARKS:"
        '
        'LBLTEACID
        '
        Me.LBLTEACID.AutoSize = True
        Me.LBLTEACID.Location = New System.Drawing.Point(279, 76)
        Me.LBLTEACID.Name = "LBLTEACID"
        Me.LBLTEACID.Size = New System.Drawing.Size(92, 15)
        Me.LBLTEACID.TabIndex = 20
        Me.LBLTEACID.Text = "TEACHER ID:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TXTSTUCLASS
        '
        Me.TXTSTUCLASS.Location = New System.Drawing.Point(151, 73)
        Me.TXTSTUCLASS.Name = "TXTSTUCLASS"
        Me.TXTSTUCLASS.ReadOnly = True
        Me.TXTSTUCLASS.Size = New System.Drawing.Size(112, 21)
        Me.TXTSTUCLASS.TabIndex = 17
        '
        'TXTSTUDENTNAME
        '
        Me.TXTSTUDENTNAME.Location = New System.Drawing.Point(482, 20)
        Me.TXTSTUDENTNAME.Name = "TXTSTUDENTNAME"
        Me.TXTSTUDENTNAME.ReadOnly = True
        Me.TXTSTUDENTNAME.Size = New System.Drawing.Size(309, 21)
        Me.TXTSTUDENTNAME.TabIndex = 14
        '
        'lblTEACNAME
        '
        Me.lblTEACNAME.AutoSize = True
        Me.lblTEACNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTEACNAME.ForeColor = System.Drawing.Color.Gold
        Me.lblTEACNAME.Location = New System.Drawing.Point(520, 76)
        Me.lblTEACNAME.Name = "lblTEACNAME"
        Me.lblTEACNAME.Size = New System.Drawing.Size(117, 15)
        Me.lblTEACNAME.TabIndex = 11
        Me.lblTEACNAME.Text = "TEACHER NAME:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(43, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 15)
        Me.Label4.TabIndex = 4
        '
        'LBLSTUDCLASS
        '
        Me.LBLSTUDCLASS.AccessibleName = "S"
        Me.LBLSTUDCLASS.AutoSize = True
        Me.LBLSTUDCLASS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSTUDCLASS.ForeColor = System.Drawing.Color.Gold
        Me.LBLSTUDCLASS.Location = New System.Drawing.Point(16, 76)
        Me.LBLSTUDCLASS.Name = "LBLSTUDCLASS"
        Me.LBLSTUDCLASS.Size = New System.Drawing.Size(122, 30)
        Me.LBLSTUDCLASS.TabIndex = 3
        Me.LBLSTUDCLASS.Text = "STUDENT CLASS:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'LBLSTUDNAME
        '
        Me.LBLSTUDNAME.AutoSize = True
        Me.LBLSTUDNAME.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSTUDNAME.ForeColor = System.Drawing.Color.Gold
        Me.LBLSTUDNAME.Location = New System.Drawing.Point(351, 23)
        Me.LBLSTUDNAME.Name = "LBLSTUDNAME"
        Me.LBLSTUDNAME.Size = New System.Drawing.Size(118, 15)
        Me.LBLSTUDNAME.TabIndex = 2
        Me.LBLSTUDNAME.Text = "STUDENT NAME:"
        '
        'LBLSTUDID
        '
        Me.LBLSTUDID.AutoSize = True
        Me.LBLSTUDID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSTUDID.ForeColor = System.Drawing.Color.Gold
        Me.LBLSTUDID.Location = New System.Drawing.Point(160, 23)
        Me.LBLSTUDID.Name = "LBLSTUDID"
        Me.LBLSTUDID.Size = New System.Drawing.Size(93, 15)
        Me.LBLSTUDID.TabIndex = 1
        Me.LBLSTUDID.Text = "STUDENT ID:"
        '
        'LBLEXAMFROM
        '
        Me.LBLEXAMFROM.BackColor = System.Drawing.Color.Purple
        Me.LBLEXAMFROM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEXAMFROM.ForeColor = System.Drawing.Color.Yellow
        Me.LBLEXAMFROM.Location = New System.Drawing.Point(283, 77)
        Me.LBLEXAMFROM.Name = "LBLEXAMFROM"
        Me.LBLEXAMFROM.Size = New System.Drawing.Size(305, 33)
        Me.LBLEXAMFROM.TabIndex = 47
        Me.LBLEXAMFROM.Text = "EXAM MARKS ENTRY FORM"
        Me.LBLEXAMFROM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Purple
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(155, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(527, 38)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Mithabai Madhyamik Kanya Vidyalay"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EXAM_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(842, 636)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LBLEXAMFROM)
        Me.Name = "EXAM_FORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXAM_FORM"
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TXTSRNO As System.Windows.Forms.TextBox
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents TXTPTSOFTSKILL As System.Windows.Forms.TextBox
    Friend WithEvents TXTHISTORY As System.Windows.Forms.TextBox
    Friend WithEvents TXTGEO As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_add As System.Windows.Forms.Button
    Friend WithEvents Btn_cancle As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents TXTMATH As System.Windows.Forms.TextBox
    Friend WithEvents CMBSTUDENTID As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LBLSRNO As System.Windows.Forms.Label
    Friend WithEvents LBLTOTALMARKS As System.Windows.Forms.Label
    Friend WithEvents LBLPTSOFTSKILL As System.Windows.Forms.Label
    Friend WithEvents LBLHISTORY As System.Windows.Forms.Label
    Friend WithEvents LBLMATH As System.Windows.Forms.Label
    Friend WithEvents lblGEO As System.Windows.Forms.Label
    Friend WithEvents LBLTEACID As System.Windows.Forms.Label
    Friend WithEvents TXTSTUCLASS As System.Windows.Forms.TextBox
    Friend WithEvents TXTENGLISH As System.Windows.Forms.TextBox
    Friend WithEvents LBLSCINCE As System.Windows.Forms.Label
    Friend WithEvents TXTSTUDENTNAME As System.Windows.Forms.TextBox
    Friend WithEvents lblENGLISH As System.Windows.Forms.Label
    Friend WithEvents lblTEACNAME As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LBLHINDI As System.Windows.Forms.Label
    Friend WithEvents LBLSTUDCLASS As System.Windows.Forms.Label
    Friend WithEvents LBLSTUDNAME As System.Windows.Forms.Label
    Friend WithEvents LBLSTUDID As System.Windows.Forms.Label
    Friend WithEvents LBLMARATHI As System.Windows.Forms.Label
    Friend WithEvents LBLEXAMFROM As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TXTREMARK As System.Windows.Forms.TextBox
    Friend WithEvents TXTGREAD As System.Windows.Forms.TextBox
    Friend WithEvents TXTPER As System.Windows.Forms.TextBox
    Friend WithEvents LBLREMARK As System.Windows.Forms.Label
    Friend WithEvents lbLGERAD As System.Windows.Forms.Label
    Friend WithEvents LBLPER As System.Windows.Forms.Label
    Friend WithEvents TXTTOTALMARKS As System.Windows.Forms.TextBox
    Friend WithEvents TXTTEACNAME As System.Windows.Forms.TextBox
    Friend WithEvents TXTMARATHI As System.Windows.Forms.TextBox
    Friend WithEvents TXTSCINCE As System.Windows.Forms.TextBox
    Friend WithEvents TXTHINDI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbTeacherid As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
