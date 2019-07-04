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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Btn_ok = New System.Windows.Forms.Button
        Me.Btn_ccle = New System.Windows.Forms.Button
        Me.Lblpw = New System.Windows.Forms.Label
        Me.Txtun = New System.Windows.Forms.TextBox
        Me.Txtpw = New System.Windows.Forms.TextBox
        Me.lblun = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Btn_ok
        '
        Me.Btn_ok.BackColor = System.Drawing.Color.White
        Me.Btn_ok.CausesValidation = False
        Me.Btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ok.Location = New System.Drawing.Point(467, 234)
        Me.Btn_ok.Name = "Btn_ok"
        Me.Btn_ok.Size = New System.Drawing.Size(88, 38)
        Me.Btn_ok.TabIndex = 0
        Me.Btn_ok.Text = "Login"
        Me.Btn_ok.UseVisualStyleBackColor = False
        '
        'Btn_ccle
        '
        Me.Btn_ccle.BackColor = System.Drawing.Color.White
        Me.Btn_ccle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ccle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ccle.Location = New System.Drawing.Point(571, 232)
        Me.Btn_ccle.Name = "Btn_ccle"
        Me.Btn_ccle.Size = New System.Drawing.Size(88, 38)
        Me.Btn_ccle.TabIndex = 1
        Me.Btn_ccle.Text = "Cancle"
        Me.Btn_ccle.UseVisualStyleBackColor = False
        '
        'Lblpw
        '
        Me.Lblpw.AutoSize = True
        Me.Lblpw.BackColor = System.Drawing.Color.Transparent
        Me.Lblpw.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpw.ForeColor = System.Drawing.Color.Yellow
        Me.Lblpw.Location = New System.Drawing.Point(354, 194)
        Me.Lblpw.Name = "Lblpw"
        Me.Lblpw.Size = New System.Drawing.Size(86, 20)
        Me.Lblpw.TabIndex = 3
        Me.Lblpw.Text = "Password"
        '
        'Txtun
        '
        Me.Txtun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtun.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtun.Location = New System.Drawing.Point(467, 165)
        Me.Txtun.Name = "Txtun"
        Me.Txtun.Size = New System.Drawing.Size(194, 23)
        Me.Txtun.TabIndex = 5
        Me.Txtun.TabStop = False
        '
        'Txtpw
        '
        Me.Txtpw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpw.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtpw.Location = New System.Drawing.Point(467, 193)
        Me.Txtpw.Name = "Txtpw"
        Me.Txtpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.Txtpw.Size = New System.Drawing.Size(194, 23)
        Me.Txtpw.TabIndex = 6
        '
        'lblun
        '
        Me.lblun.AutoSize = True
        Me.lblun.BackColor = System.Drawing.Color.Transparent
        Me.lblun.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblun.ForeColor = System.Drawing.Color.Yellow
        Me.lblun.Location = New System.Drawing.Point(354, 168)
        Me.lblun.Name = "lblun"
        Me.lblun.Size = New System.Drawing.Size(93, 20)
        Me.lblun.TabIndex = 7
        Me.lblun.Text = "UserName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(26, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Designed && Developed By"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(26, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(239, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "JADHAV DNYANESHWAR SUNIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(26, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "BCA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(23, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(699, 32)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "  COMPUTERIZED SCHOOL ADMISSION SYSTEM "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Bookman Old Style", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(106, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(535, 32)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Mithabai Madhyamik Kanya Vidyalay"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(747, 323)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblun)
        Me.Controls.Add(Me.Txtpw)
        Me.Controls.Add(Me.Txtun)
        Me.Controls.Add(Me.Lblpw)
        Me.Controls.Add(Me.Btn_ccle)
        Me.Controls.Add(Me.Btn_ok)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_ok As System.Windows.Forms.Button
    Friend WithEvents Btn_ccle As System.Windows.Forms.Button
    Friend WithEvents Lblpw As System.Windows.Forms.Label
    Friend WithEvents Txtun As System.Windows.Forms.TextBox
    Friend WithEvents Txtpw As System.Windows.Forms.TextBox
    Friend WithEvents lblun As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
