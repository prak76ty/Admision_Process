<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdi))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.TeacherMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnquiryMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TeacherMasterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AdmissionProssesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnquiryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EntryFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FeesReciptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamMarksEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LeavingEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClassMasterReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TeacherMasterReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentMasterReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EnquiryReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttendanceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FeesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttendanceReportToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExamReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LeavingReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherMasterToolStripMenuItem, Me.AdmissionProssesToolStripMenuItem, Me.EntryFormToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(774, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TeacherMasterToolStripMenuItem
        '
        Me.TeacherMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnquiryMasterToolStripMenuItem, Me.TeacherMasterToolStripMenuItem1})
        Me.TeacherMasterToolStripMenuItem.Name = "TeacherMasterToolStripMenuItem"
        Me.TeacherMasterToolStripMenuItem.Size = New System.Drawing.Size(98, 21)
        Me.TeacherMasterToolStripMenuItem.Text = "Master Form"
        '
        'EnquiryMasterToolStripMenuItem
        '
        Me.EnquiryMasterToolStripMenuItem.Name = "EnquiryMasterToolStripMenuItem"
        Me.EnquiryMasterToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EnquiryMasterToolStripMenuItem.Text = "Class Master"
        '
        'TeacherMasterToolStripMenuItem1
        '
        Me.TeacherMasterToolStripMenuItem1.Name = "TeacherMasterToolStripMenuItem1"
        Me.TeacherMasterToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.TeacherMasterToolStripMenuItem1.Text = "Teacher Master"
        '
        'AdmissionProssesToolStripMenuItem
        '
        Me.AdmissionProssesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnquiryToolStripMenuItem, Me.AdmissionToolStripMenuItem, Me.StudentMasterToolStripMenuItem})
        Me.AdmissionProssesToolStripMenuItem.Name = "AdmissionProssesToolStripMenuItem"
        Me.AdmissionProssesToolStripMenuItem.Size = New System.Drawing.Size(135, 21)
        Me.AdmissionProssesToolStripMenuItem.Text = "Admission Prosses"
        '
        'EnquiryToolStripMenuItem
        '
        Me.EnquiryToolStripMenuItem.Name = "EnquiryToolStripMenuItem"
        Me.EnquiryToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.EnquiryToolStripMenuItem.Text = "Enquiry"
        '
        'AdmissionToolStripMenuItem
        '
        Me.AdmissionToolStripMenuItem.Name = "AdmissionToolStripMenuItem"
        Me.AdmissionToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AdmissionToolStripMenuItem.Text = "Admission"
        '
        'StudentMasterToolStripMenuItem
        '
        Me.StudentMasterToolStripMenuItem.Name = "StudentMasterToolStripMenuItem"
        Me.StudentMasterToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.StudentMasterToolStripMenuItem.Text = "Student Master"
        '
        'EntryFormToolStripMenuItem
        '
        Me.EntryFormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttendanceToolStripMenuItem, Me.FeesReciptToolStripMenuItem, Me.ExamMarksEntryToolStripMenuItem, Me.LeavingEntryToolStripMenuItem})
        Me.EntryFormToolStripMenuItem.Name = "EntryFormToolStripMenuItem"
        Me.EntryFormToolStripMenuItem.Size = New System.Drawing.Size(88, 21)
        Me.EntryFormToolStripMenuItem.Text = "Entry Form"
        '
        'AttendanceToolStripMenuItem
        '
        Me.AttendanceToolStripMenuItem.Name = "AttendanceToolStripMenuItem"
        Me.AttendanceToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AttendanceToolStripMenuItem.Text = "Attendance"
        '
        'FeesReciptToolStripMenuItem
        '
        Me.FeesReciptToolStripMenuItem.Name = "FeesReciptToolStripMenuItem"
        Me.FeesReciptToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.FeesReciptToolStripMenuItem.Text = "Fees Recipt"
        '
        'ExamMarksEntryToolStripMenuItem
        '
        Me.ExamMarksEntryToolStripMenuItem.Name = "ExamMarksEntryToolStripMenuItem"
        Me.ExamMarksEntryToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExamMarksEntryToolStripMenuItem.Text = "Exam Marks Entry"
        '
        'LeavingEntryToolStripMenuItem
        '
        Me.LeavingEntryToolStripMenuItem.Name = "LeavingEntryToolStripMenuItem"
        Me.LeavingEntryToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.LeavingEntryToolStripMenuItem.Text = "Leaving Entry"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassMasterReportToolStripMenuItem, Me.TeacherMasterReportToolStripMenuItem, Me.StudentMasterReportToolStripMenuItem, Me.EnquiryReportToolStripMenuItem, Me.AttendanceReportToolStripMenuItem, Me.FeesReportToolStripMenuItem, Me.AttendanceReportToolStripMenuItem1, Me.ExamReportToolStripMenuItem, Me.LeavingReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(67, 21)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ClassMasterReportToolStripMenuItem
        '
        Me.ClassMasterReportToolStripMenuItem.Name = "ClassMasterReportToolStripMenuItem"
        Me.ClassMasterReportToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ClassMasterReportToolStripMenuItem.Text = "Class Master Report"
        '
        'TeacherMasterReportToolStripMenuItem
        '
        Me.TeacherMasterReportToolStripMenuItem.Name = "TeacherMasterReportToolStripMenuItem"
        Me.TeacherMasterReportToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.TeacherMasterReportToolStripMenuItem.Text = "Teacher Master Report"
        '
        'StudentMasterReportToolStripMenuItem
        '
        Me.StudentMasterReportToolStripMenuItem.Name = "StudentMasterReportToolStripMenuItem"
        Me.StudentMasterReportToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.StudentMasterReportToolStripMenuItem.Text = "Student Master Report"
        '
        'EnquiryReportToolStripMenuItem
        '
        Me.EnquiryReportToolStripMenuItem.Name = "EnquiryReportToolStripMenuItem"
        Me.EnquiryReportToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.EnquiryReportToolStripMenuItem.Text = "Enquiry Report"
        '
        'AttendanceReportToolStripMenuItem
        '
        Me.AttendanceReportToolStripMenuItem.Name = "AttendanceReportToolStripMenuItem"
        Me.AttendanceReportToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AttendanceReportToolStripMenuItem.Text = "Admission Report"
        '
        'FeesReportToolStripMenuItem
        '
        Me.FeesReportToolStripMenuItem.Name = "FeesReportToolStripMenuItem"
        Me.FeesReportToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.FeesReportToolStripMenuItem.Text = "Fees Report"
        '
        'AttendanceReportToolStripMenuItem1
        '
        Me.AttendanceReportToolStripMenuItem1.Name = "AttendanceReportToolStripMenuItem1"
        Me.AttendanceReportToolStripMenuItem1.Size = New System.Drawing.Size(215, 22)
        Me.AttendanceReportToolStripMenuItem1.Text = "Attendance Report"
        '
        'ExamReportToolStripMenuItem
        '
        Me.ExamReportToolStripMenuItem.Name = "ExamReportToolStripMenuItem"
        Me.ExamReportToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.ExamReportToolStripMenuItem.Text = "Exam Report"
        '
        'LeavingReportToolStripMenuItem
        '
        Me.LeavingReportToolStripMenuItem.Name = "LeavingReportToolStripMenuItem"
        Me.LeavingReportToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.LeavingReportToolStripMenuItem.Text = "Leaving Report"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YESToolStripMenuItem, Me.NOToolStripMenuItem})
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(43, 21)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'YESToolStripMenuItem
        '
        Me.YESToolStripMenuItem.Name = "YESToolStripMenuItem"
        Me.YESToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.YESToolStripMenuItem.Text = "YES"
        '
        'NOToolStripMenuItem
        '
        Me.NOToolStripMenuItem.Name = "NOToolStripMenuItem"
        Me.NOToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NOToolStripMenuItem.Text = "NO"
        '
        'mdi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(774, 361)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "mdi"
        Me.Text = "Mithabai Madhyamik Kanya Vidyalay"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TeacherMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnquiryMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeacherMasterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdmissionProssesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnquiryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdmissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EntryFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesReciptToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamMarksEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeavingEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassMasterReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TeacherMasterReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentMasterReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnquiryReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttendanceReportToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeavingReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
