Imports System.Data.OleDb
Imports System.Data
Public Class EnQuiryMaster
    Dim ss As String
    Dim com As OleDbCommand
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer

    Private Sub EnQuiryMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        btn_save.Enabled = False
        Btn_cancle.Enabled = False


        da = New OleDbDataAdapter("select * from Enqury_Master", Conn)
        ds = New DataSet
        da.Fill(ds, "Enqury_Master")
    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max (En_No) from Enqury_Master", Conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        Txtenquiryno.Text = temp.ToString
        txtstudentname.Text = ""
        Cmbstudentgrnder.Text = ""
        txtprevistanderd.Text = ""
        txtpreviresult.Text = ""
        txtprevischool.Text = ""
        txtparentname.Text = ""
        txtparentaddress.Text = ""
        txtparentcity.Text = ""
        Txtparentcno.Text = ""
        Txtremark.Text = ""

        Btn_add.Enabled = False
        btn_save.Enabled = True
        Btn_cancle.Enabled = True
        Btn_Delete.Enabled = False
        Btn_update.Enabled = False

        Btn_first.Enabled = False
        Btn_preiouse.Enabled = False
        btn_exit.Enabled = False
        Btn_next.Enabled = False
        btn_last.Enabled = False
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txtstudentname.Text = "" Then
            MessageBox.Show("fill the name")
            Exit Sub
        End If
        If Cmbstudentgrnder.Text = "" Then
            MessageBox.Show("fill the Gender")
            Exit Sub
        End If
        If txtprevistanderd.Text = "" Then
            MessageBox.Show("fill the previous standard")
            Exit Sub
        End If
        If txtpreviresult.Text = "" Then
            MessageBox.Show("fill the previous result")
            Exit Sub
        End If

        If txtprevischool.Text = "" Then
            MessageBox.Show("fill the previous school")
            Exit Sub
        End If
        If txtparentname.Text = "" Then
            MessageBox.Show("fill the parent name")
            Exit Sub
        End If
        If txtparentaddress.Text = "" Then
            MessageBox.Show("fill the parent address")
            Exit Sub
        End If
        If txtparentcity.Text = "" Then
            MessageBox.Show("fill the parent city")
            Exit Sub
        End If
        If Txtparentcno.Text = "" Then
            MessageBox.Show("fill the parent contact number")
            Exit Sub
        End If
        If Txtremark.Text = "" Then
            Txtremark.Text = "Nil"
        End If
        'cmd = New OleDbCommand("insert into Enqury_Master values('" & Txtenquiryno.Text & "','" & DTP_EDate.Value & "','" & txtstudentname.Text & "','" & DTP_DOB.Value & "','" & Cmbstudentgrnder.Text & "','" & txtprevistanderd.Text & "','" & txtpreviresult.Text & "','" & txtprevischool.Text & "','" & txtparentname.Text & "','" & txtparentaddress.Text & "','" & txtparentcity.Text & "')", Conn)
        cmd = New OleDbCommand("insert into Enqury_Master values('" & Txtenquiryno.Text & "','" & DTP_EDate.Value & "','" & txtstudentname.Text & "','" & DTP_DOB.Value & "','" & Cmbstudentgrnder.Text & "','" & txtprevistanderd.Text & "','" & txtpreviresult.Text & "','" & txtprevischool.Text & "','" & txtparentname.Text & "','" & txtparentaddress.Text & "','" & txtparentcity.Text & "','" & Txtparentcno.Text & "','" & Txtremark.Text & "')", Conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        EnQuiryMaster_Load(sender, e)

        Btn_add.Enabled = True
        Btn_cancle.Enabled = False
        Btn_Delete.Enabled = True
        btn_exit.Enabled = True
        Btn_first.Enabled = True
        btn_last.Enabled = True
        Btn_next.Enabled = True
        Btn_preiouse.Enabled = True
        btn_save.Enabled = False
        Btn_update.Enabled = True
    End Sub

    Private Sub Btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancle.Click
        Txtenquiryno.Text = ""
        txtstudentname.Text = ""
        Cmbstudentgrnder.Text = ""
        txtprevistanderd.Text = ""
        txtpreviresult.Text = ""
        txtprevischool.Text = ""
        txtparentname.Text = ""
        txtparentaddress.Text = ""
        txtparentcity.Text = ""
        Txtparentcno.Text = ""
        Txtremark.Text = ""

        Btn_add.Enabled = True
        Btn_cancle.Enabled = False
        Btn_Delete.Enabled = True
        btn_exit.Enabled = True
        Btn_first.Enabled = True
        btn_last.Enabled = True
        Btn_next.Enabled = True
        Btn_preiouse.Enabled = True
        btn_save.Enabled = False
        Btn_update.Enabled = True
    End Sub

    Private Sub Btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_first.Click
        Try
            recno = 0
            nav()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btn_preiouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_preiouse.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("Enqury_Master").Rows.Count) Then
            nav()
        Else
            MessageBox.Show("First Record")
        End If
    End Sub

    Private Sub Btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_next.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("Enqury_Master").Rows.Count) Then
            nav()
        Else

            MessageBox.Show("Last Record")
        End If
    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            recno = ds.Tables("Enqury_Master").Rows.Count - 1
            nav()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub nav()
        Txtenquiryno.Text = ds.Tables("Enqury_Master").Rows(recno).Item(0)
        DTP_EDate.Value = ds.Tables("Enqury_Master").Rows(recno).Item(1)
        txtstudentname.Text = ds.Tables("Enqury_Master").Rows(recno).Item(2)
        DTP_DOB.Value = ds.Tables("Enqury_Master").Rows(recno).Item(3)
        Cmbstudentgrnder.Text = ds.Tables("Enqury_Master").Rows(recno).Item(4)
        txtprevistanderd.Text = ds.Tables("Enqury_Master").Rows(recno).Item(5)
        txtpreviresult.Text = ds.Tables("Enqury_Master").Rows(recno).Item(6)
        txtprevischool.Text = ds.Tables("Enqury_Master").Rows(recno).Item(7)
        txtparentname.Text = ds.Tables("Enqury_Master").Rows(recno).Item(8)
        txtparentaddress.Text = ds.Tables("Enqury_Master").Rows(recno).Item(9)
        txtparentcity.Text = ds.Tables("Enqury_Master").Rows(recno).Item(10)
        Txtparentcno.Text = ds.Tables("Enqury_Master").Rows(recno).Item(11)
        Txtremark.Text = ds.Tables("Enqury_Master").Rows(recno).Item(12)

    End Sub

    Private Sub Btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_update.Click
        Try
            ss = "update Enquiry_Master set En_No='" & Txtenquiryno.Text & "',Enqury_Date='" & DTP_EDate.Text & "',Stu_Name='" & txtstudentname.Text & "',Stu_DateOfBirth='" & DTP_DOB.Text & "',Stu_Gender='" & Cmbstudentgrnder.Text & "',Stu_preiouse_Standared='" & Cmbstudentgrnder.Text & "',Preiouse_Result='" & txtpreviresult.Text & "',Preiouse_School='" & txtprevischool.Text & "',Parent_Name='" & txtparentname.Text & "',Parent_Address='" & txtparentcity.Text & "' Where En_No=" & Txtenquiryno.Text & ""
            com = New OleDbCommand(ss, Conn)
            com.ExecuteNonQuery()
            MsgBox("Record Updated Sucessfully!!!")
            EnQuiryMaster_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Delete.Click
        Try
            ss = "delete from Enquiry_Master where En_No=" & Txtenquiryno.Text & ""
            com = New OleDbCommand(ss, Conn)

            com.ExecuteNonQuery()
            MsgBox("Record Deleted Sucessfully!!!")
            opendb()
            EnQuiryMaster_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub
End Class