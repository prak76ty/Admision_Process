Public Class mdi

    
    Private Sub EnquiryMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnquiryMasterToolStripMenuItem.Click
        Class_Master.MdiParent = Me
        Class_Master.Show()
    End Sub

    Private Sub TeacherMasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherMasterToolStripMenuItem1.Click
        Form3.MdiParent = Me
        Form3.Show()
    End Sub

    Private Sub EnquiryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnquiryToolStripMenuItem.Click
        EnQuiryMaster.MdiParent = Me
        EnQuiryMaster.Show()
    End Sub

    Private Sub AdmissionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdmissionToolStripMenuItem.Click
        Admission_Master.MdiParent = Me
        Admission_Master.Show()
    End Sub

    Private Sub StudentMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentMasterToolStripMenuItem.Click
        Student_Master.MdiParent = Me
        Student_Master.Show()
    End Sub

    Private Sub AttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceToolStripMenuItem.Click
        Attendance.MdiParent = Me
        Attendance.Show()
    End Sub

    Private Sub FeesReciptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesReciptToolStripMenuItem.Click
        Fee_Receipt_Master.MdiParent = Me
        Fee_Receipt_Master.Show()
    End Sub

    Private Sub ExamMarksEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamMarksEntryToolStripMenuItem.Click
        EXAM_FORM.MdiParent = Me
        EXAM_FORM.Show()
    End Sub

    Private Sub LeavingEntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeavingEntryToolStripMenuItem.Click
        LEAVING_MASTER.MdiParent = Me
        LEAVING_MASTER.Show()
    End Sub

   Private Sub ClassMasterReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClassMasterReportToolStripMenuItem.Click
        frmrptClassMaster.MdiParent = Me
        frmrptClassMaster.Show()
    End Sub
    Private Sub StudentMasterReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentMasterReportToolStripMenuItem.Click
        frmrptStuMaster.MdiParent = Me
        frmrptStuMaster.Show()
    End Sub

    Private Sub EnquiryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnquiryReportToolStripMenuItem.Click
        frmrptEnquiryMaster.MdiParent = Me
        frmrptEnquiryMaster.Show()
    End Sub

    Private Sub AttendanceReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceReportToolStripMenuItem.Click
        frmRptAdmission.MdiParent = Me
        frmRptAdmission.Show()

    End Sub

    Private Sub FeesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeesReportToolStripMenuItem.Click
        frmrptFeesMaster.MdiParent = Me
        frmrptFeesMaster.Show()
    End Sub
    Private Sub TeacherMasterReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TeacherMasterReportToolStripMenuItem.Click
        frmrptTeacherMaster.MdiParent = Me
        frmrptTeacherMaster.Show()
    End Sub


    Private Sub LeavingReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeavingReportToolStripMenuItem.Click
        frmrptLeavingMaster.MdiParent = Me
        frmrptLeavingMaster.Show()
    End Sub

    Private Sub AttendanceReportToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttendanceReportToolStripMenuItem1.Click
        frmrptAttendance.MdiParent = Me
        frmrptAttendance.Show()
    End Sub

    Private Sub ExamReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamReportToolStripMenuItem.Click
        frmrptExam.MdiParent = Me
        frmrptExam.Show()
    End Sub

    Private Sub YESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YESToolStripMenuItem.Click
        End
    End Sub
End Class