Imports System.Data.OleDb
Imports System.Data

Public Class Form3
    Dim ss As String
    Dim com As OleDbCommand
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
        da = New OleDbDataAdapter("select * from Teacher_master", Conn)
        ds = New DataSet
        da.Fill(ds, "Teacher_Master")
    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max (Tcr_Id) from teacher_master", Conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txt_tid.Text = temp.ToString
        Txt_name.Text = ""
        txt_qua.Text = ""
        txt_add.Text = ""
        'Txt_city.Text = ""
        txt_cno.Text = ""
        'txt_joiningdate.Text =
        txt_experiance.Text = ""
        txt_salary.Text = ""
        txt_remark.Text = ""
        'txt_dob.Text = ""
        'Txt_possition.Text = ""

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


        If txt_tid.Text = "" Then
            MessageBox.Show("fill the name")
            Exit Sub
        End If
        If txt_tid.Text = "" Then
            MessageBox.Show("fill the tid")
            Exit Sub
        End If
        If txt_tid.Text = "" Then
            MessageBox.Show("fill the tid")
            Exit Sub
        End If
        If Txt_name.Text = "" Then
            MessageBox.Show("fill the name")
            Exit Sub
        End If
        If txt_qua.Text Then
            MessageBox.Show("fill the qualification")
            Exit Sub
        End If
        If txt_add.Text = "" Then
            MessageBox.Show("fill the address")
            Exit Sub
        End If
        'If Txt_city.Text = "" Then
        '    MessageBox.Show("fill the city")
        '    Exit Sub
        'End If
        If txt_cno.Text = "" Then
            MessageBox.Show("fill the contact no")
            Exit Sub
        End If
        If txt_experiance.Text = "" Then
            MessageBox.Show("fill the experiance")
            Exit Sub
        End If
        If txt_salary.Text = "" Then
            MessageBox.Show("fill the salary")
            Exit Sub
        End If
        If txt_remark.Text = "" Then
            MessageBox.Show("fill the remark")
            Exit Sub

        End If
        cmd = New OleDbCommand("insert into Teacher_master values('" & txt_tid.Text & "','" & Txt_name.Text & "','" & txt_qua.Text & "','" & txt_add.Text & "','" & txt_cno.Text & "','" & DateTimePicker1.Value & "','" & txt_experiance.Text & "','" & txt_salary.Text & "','" & txt_remark.Text & "','" & DateTimePicker2.Value & "','" & Combpossition.Text & "')", Conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        Form3_Load(sender, e)

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
        txt_add.Text = ""
        'Txt_city.Text = ""
        txt_cno.Text = ""
        txt_experiance.Text = ""
        Txt_name.Text = ""
        txt_qua.Text = ""
        txt_remark.Text = ""
        txt_salary.Text = ""
        txt_tid.Text = ""

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
    Private Sub nav()
        txt_tid.Text = ds.Tables("teacher_master").Rows(recno).Item(0)
        Txt_name.Text = ds.Tables("teacher_master").Rows(recno).Item(1)
        txt_qua.Text = ds.Tables("teacher_master").Rows(recno).Item(2)
        txt_add.Text = ds.Tables("teacher_master").Rows(recno).Item(3)
        txt_cno.Text = ds.Tables("teacher_master").Rows(recno).Item(4)
        DateTimePicker1.Value = ds.Tables("teacher_master").Rows(recno).Item(5)
        txt_experiance.Text = ds.Tables("teacher_master").Rows(recno).Item(6)
        txt_salary.Text = ds.Tables("teacher_master").Rows(recno).Item(7)
        txt_remark.Text = ds.Tables("teacher_master").Rows(recno).Item(8)
        DateTimePicker2.Value = ds.Tables("teacher_master").Rows(recno).Item(9)
        Combpossition.Text = ds.Tables("teacher_master").Rows(recno).Item(10)

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
        If (recno >= 0 And recno < ds.Tables("teacher_master").Rows.Count) Then
            nav()
        Else
            MessageBox.Show("First Record")
        End If

    End Sub

    Private Sub Btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_next.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("teacher_master").Rows.Count) Then
            nav()
        Else

            MessageBox.Show("Last Record")
        End If
    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            recno = ds.Tables("Teacher_master").Rows.Count - 1
            nav()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub Btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Delete.Click
        Try
            ss = "delete from Teacher_Master where Tcr_Id=" & txt_tid.Text & ""
            com = New OleDbCommand(ss, Conn)

            com.ExecuteNonQuery()
            MsgBox("Record Deleted Sucessfully!!!")
            opendb()
            Form3_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_update.Click
        Try
            ss = "update Teacher_Master set Tcr_Name='" & Txt_name.Text & "',Tcr_Qualification='" & txt_qua.Text & "',Tcr_Address='" & txt_add.Text & "',Tcr_ContactNo='" & txt_cno.Text & "',Tcr_JoiningDate='" & DateTimePicker1.Value & "',Tcr_Experance='" & txt_experiance.Text & "',Tcr_Salary='" & txt_salary.Text & "',Tcr_Remark='" & txt_remark.Text & "',Tcr_Date_Of_Birth='" & DateTimePicker2.Value & "',Tcr_Possition='" & Combpossition.Text & "'"
            com = New OleDbCommand(ss, Conn)
            com.ExecuteNonQuery()
            MsgBox("Record Updated Sucessfully!!!")
            Form3_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class