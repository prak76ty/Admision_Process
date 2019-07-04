<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_exit = New System.Windows.Forms.Button
        Me.lblAdd = New System.Windows.Forms.Label
        Me.lblAdmission = New System.Windows.Forms.Label
        Me.cmbDiv = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblClassName = New System.Windows.Forms.Label
        Me.cmbClass = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTeacherName = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(842, 287)
        Me.DataGridView1.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Status"
        Me.Column1.Name = "Column1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(675, 106)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(116, 22)
        Me.DateTimePicker1.TabIndex = 4
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.Indigo
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.Yellow
        Me.btn_save.Location = New System.Drawing.Point(340, 444)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(90, 40)
        Me.btn_save.TabIndex = 44
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.Indigo
        Me.btn_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Yellow
        Me.btn_exit.Location = New System.Drawing.Point(451, 444)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 40)
        Me.btn_exit.TabIndex = 46
        Me.btn_exit.Text = "EXIT"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.ForeColor = System.Drawing.Color.Gold
        Me.lblAdd.Location = New System.Drawing.Point(620, 109)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(49, 16)
        Me.lblAdd.TabIndex = 47
        Me.lblAdd.Text = "DATE"
        '
        'lblAdmission
        '
        Me.lblAdmission.BackColor = System.Drawing.Color.Purple
        Me.lblAdmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmission.ForeColor = System.Drawing.Color.Yellow
        Me.lblAdmission.Location = New System.Drawing.Point(46, 71)
        Me.lblAdmission.Name = "lblAdmission"
        Me.lblAdmission.Size = New System.Drawing.Size(822, 24)
        Me.lblAdmission.TabIndex = 48
        Me.lblAdmission.Text = "ATTENDANCE ENTRY FORM"
        Me.lblAdmission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbDiv
        '
        Me.cmbDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDiv.FormattingEnabled = True
        Me.cmbDiv.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F"})
        Me.cmbDiv.Location = New System.Drawing.Point(209, 104)
        Me.cmbDiv.Name = "cmbDiv"
        Me.cmbDiv.Size = New System.Drawing.Size(60, 24)
        Me.cmbDiv.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(142, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Division:"
        '
        'lblClassName
        '
        Me.lblClassName.AutoSize = True
        Me.lblClassName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassName.ForeColor = System.Drawing.Color.Gold
        Me.lblClassName.Location = New System.Drawing.Point(23, 106)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(47, 16)
        Me.lblClassName.TabIndex = 49
        Me.lblClassName.Text = "Class"
        '
        'cmbClass
        '
        Me.cmbClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Items.AddRange(New Object() {"A", "B", "C", "D", "E", "F"})
        Me.cmbClass.Location = New System.Drawing.Point(76, 103)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(60, 24)
        Me.cmbClass.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(275, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Teacher Name"
        '
        'txtTeacherName
        '
        Me.txtTeacherName.AcceptsTab = True
        Me.txtTeacherName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeacherName.Location = New System.Drawing.Point(392, 106)
        Me.txtTeacherName.Name = "txtTeacherName"
        Me.txtTeacherName.Size = New System.Drawing.Size(210, 22)
        Me.txtTeacherName.TabIndex = 54
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Indigo
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(810, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 40)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Purple
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(175, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(527, 38)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Mithabai Madhyamik Kanya Vidyalay"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(896, 504)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtTeacherName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.cmbDiv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblClassName)
        Me.Controls.Add(Me.lblAdmission)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblAdmission As System.Windows.Forms.Label
    Friend WithEvents cmbDiv As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblClassName As System.Windows.Forms.Label
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTeacherName As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
