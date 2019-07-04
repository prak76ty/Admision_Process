Imports System.Data.OleDb
Imports System.Data
Public Class LEAVING_MASTER

    Dim ss As String
    Dim com As OleDbCommand
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer
    Private Sub Btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_print.Click
        frmrptLeavingMaster.Show()
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub Btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancle.Click
        TXTLEAVINGNO.Text = ""
        CMBSTUDID.Text = ""
        TXTSTUNAME.Text = ""
        TXTFATHERNAME.Text = ""
        TXTMOTHERNAME.Text = ""
        TXTGARDIANNAME.Text = ""
        txtDOB.Text = ""
        txtCast.Text = ""
        txtRel.Text = ""
        'TXTPRIVISTAND.Text = ""
        txtCauurentStd.Text = ""
        cmbProgress.Text = ""
        Txt_LcFee.Text = ""
        TXTREMA.Text = ""
        Txt_Reason.Text = ""
        Cmb_ChkBy.Text = ""

        Btn_add.Enabled = True
        btn_exit.Enabled = True
        Btn_print.Enabled = True
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max (LeavingNo) from Leaving_Master", Conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If


        TXTLEAVINGNO.Text = temp.ToString
        CMBSTUDID.Text = ""
        TXTSTUNAME.Text = ""
        TXTFATHERNAME.Text = ""
        TXTMOTHERNAME.Text = ""
        TXTGARDIANNAME.Text = ""
        txtDOB.Text = ""
        txtCast.Text = ""
        txtRel.Text = ""
        'TXTPRIVISTAND.Text = ""
        txtCauurentStd.Text = ""
        cmbProgress.Text = ""
        Txt_LcFee.Text = ""
        TXTREMA.Text = ""
        Txt_Reason.Text = ""
        Cmb_ChkBy.Text = ""

        Btn_add.Enabled = False
        btn_exit.Enabled = False
        Btn_print.Enabled = False

        btn_save.Enabled = True
        Btn_cancle.Enabled = True
    End Sub

    Private Sub LEAVING_MASTER_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        Btn_add.Enabled = True
        btn_exit.Enabled = True
        Btn_print.Enabled = True
        btn_save.Enabled = False
        Btn_cancle.Enabled = False

        ss = "select distinct(Student_Id)from Admission_Master"
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        CMBSTUDID.Items.Clear()
        While rdr.Read()
            CMBSTUDID.Items.Add(rdr.Item(0))
        End While
        CMBSTUDID.Sorted = True

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If CMBSTUDID.Text = "" Then
            MessageBox.Show("fill the stud id")
            Exit Sub
        End If

        If TXTSTUNAME.Text = "" Then
            MessageBox.Show("fill the stud name")
            Exit Sub
        End If
        If TXTFATHERNAME.Text = "" Then
            MessageBox.Show("fill the stud father name")
            Exit Sub
        End If
        If TXTMOTHERNAME.Text = "" Then
            MessageBox.Show("fill the stud mother name")
            Exit Sub
        End If
        If TXTGARDIANNAME.Text = "" Then
            MessageBox.Show("fill the stud guardian name")
            Exit Sub
        End If
        If txtDOB.Text = "" Then
            MessageBox.Show("fill the stud DOB")
            Exit Sub
        End If
        If txtCast.Text = "" Then
            MessageBox.Show("fill the stud cast")
            Exit Sub
        End If
        If txtRel.Text = "" Then
            MessageBox.Show("fill the stud religion")
            Exit Sub
        End If
        If txtCauurentStd.Text = "" Then
            MessageBox.Show("fill the stud currunt std")
            Exit Sub
        End If
        If cmbProgress.Text = "" Then
            MessageBox.Show("fill the stud progress")
            Exit Sub
        End If
        If Txt_LcFee.Text = "" Then
            MessageBox.Show("fill the lc fee")
            Exit Sub
        End If
        If TXTREMA.Text = "" Then
            MessageBox.Show("fill the remark")
            Exit Sub
        End If
        If Txt_Reason.Text = "" Then
            MessageBox.Show("fill the reason")
            Exit Sub
        End If
        If Cmb_ChkBy.Text = "" Then
            MessageBox.Show("select checked by")
            Exit Sub
        End If



        cmd = New OleDbCommand("insert into Leaving_Master values(" & TXTLEAVINGNO.Text & ",'" & DTPISSUEDATE.Value & "', " & CMBSTUDID.Text & ",'" & TXTSTUNAME.Text & "','" & TXTFATHERNAME.Text & "','" & TXTMOTHERNAME.Text & "','" & TXTGARDIANNAME.Text & "','" & txtDOB.Text & "','" & txtCast.Text & "','" & txtRel.Text & "'," & txtCauurentStd.Text & ",'" & Dtp_SchLeaveDate.Value & "', '" & cmbProgress.Text & "'," & Txt_LcFee.Text & ",'" & TXTREMA.Text & "','" & Txt_Reason.Text & "','" & Cmb_ChkBy.Text & "')", Conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        LEAVING_MASTER_Load(sender, e)

        Btn_add.Enabled = True
        btn_exit.Enabled = True
        Btn_print.Enabled = True
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
    End Sub

    Private Sub CMBSTUDID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBSTUDID.SelectedIndexChanged
        ss = "select Student_Name, Father_Name, Mother_Name, Gardian_Name, Student_DateOfBirth, Student_Cast, Student_Categiree, Student_Class from Admission_Master where Student_Id = '" & CMBSTUDID.Text & "'"
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()

        If rdr.Read() Then
            TXTSTUNAME.Text = rdr.Item(0).ToString
            TXTFATHERNAME.Text = rdr.Item(1).ToString
            TXTMOTHERNAME.Text = rdr.Item(2).ToString
            TXTGARDIANNAME.Text = rdr.Item(3).ToString
            txtDOB.Text = rdr.Item(4).ToString
            txtCast.Text = rdr.Item(5).ToString
            txtRel.Text = rdr.Item(6).ToString
            txtCauurentStd.Text = rdr.Item(7).ToString
        End If
    End Sub
End Class