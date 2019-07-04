
Imports System.Data.OleDb
Imports System.Data

Public Class Admission_Master
    Dim ss As String
    Dim com As OleDbCommand
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer

    Private Sub Admission_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
        da = New OleDbDataAdapter("select * from Admission_Master", Conn)
        ds = New DataSet
        da.Fill(ds, "Admission_Master")


        ss = "select distinct(En_No) from Enqury_Master"
        ComboBox1.Items.Clear()
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        While rdr.Read()
            ComboBox1.Sorted = True
            ComboBox1.Items.Add(rdr.Item(0))
        End While

        ss = "select distinct(Tcr_Id) from Teacher_Master"
        cmbClassTeacherid.Items.Clear()
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        While rdr.Read()
            cmbClassTeacherid.Sorted = True
            cmbClassTeacherid.Items.Add(rdr.Item(0))
        End While

    End Sub
    Private Sub nav()
        txtaddNo.Text = ds.Tables("Admission_Master").Rows(recno).Item(0)
        DateTimePicker2.Value = ds.Tables("Admission_Master").Rows(recno).Item(1)
        ComboBox1.Text = ds.Tables("Admission_Master").Rows(recno).Item(2)
        txtStuName.Text = ds.Tables("Admission_Master").Rows(recno).Item(3)
        DateTimePicker3.Value = ds.Tables("Admission_Master").Rows(recno).Item(4)
        cmbStudGender.Text = ds.Tables("Admission_Master").Rows(recno).Item(5)
        cmbStudCate.Text = ds.Tables("Admission_Master").Rows(recno).Item(6)
        txtStudCast.Text = ds.Tables("Admission_Master").Rows(recno).Item(7)
        cmbPriviStan.Text = ds.Tables("Admission_Master").Rows(recno).Item(8)
        txtpriviResult.Text = ds.Tables("Admission_Master").Rows(recno).Item(9)
        txtpriviSchool.Text = ds.Tables("Admission_Master").Rows(recno).Item(10)
        txtFathername.Text = ds.Tables("Admission_Master").Rows(recno).Item(11)
        txtMotherName.Text = ds.Tables("Admission_Master").Rows(recno).Item(12)
        txtGrarName.Text = ds.Tables("Admission_Master").Rows(recno).Item(13)
        txtAdd.Text = ds.Tables("Admission_Master").Rows(recno).Item(14)
        txtCity.Text = ds.Tables("Admission_Master").Rows(recno).Item(15)
        txtContactNo.Text = ds.Tables("Admission_Master").Rows(recno).Item(16)
        TtxtStudid.Text = ds.Tables("Admission_Master").Rows(recno).Item(17)
        cmbStudClass.Text = ds.Tables("Admission_Master").Rows(recno).Item(18)
        cmbClassTeacherid.Text = ds.Tables("Admission_Master").Rows(recno).Item(19)
        cmbD1.Text = ds.Tables("Admission_Master").Rows(recno).Item(20)
        cmbD2.Text = ds.Tables("Admission_Master").Rows(recno).Item(21)
        txtFee.Text = ds.Tables("Admission_Master").Rows(recno).Item(22)
    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max (Admission_No) from Admission_Master ", Conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If
        txtaddNo.Text = temp.ToString
        DateTimePicker2.Text = ""
        ComboBox1.Text = ""
        txtStuName.Text = ""
        'Txt_city.Text = ""
        DateTimePicker3.Text = ""
        'txt_joiningdate.Text =
        cmbStudGender.Text = ""
        cmbStudCate.Text = ""
        txtStudCast.Text = ""
        cmbPriviStan.Text = ""
        txtpriviResult.Text = ""
        txtpriviSchool.Text = ""
        txtFathername.Text = ""
        txtMotherName.Text = ""
        txtGrarName.Text = ""
        txtAdd.Text = ""
        txtCity.Text = ""
        txtContactNo.Text = ""
        TtxtStudid.Text = ""
        cmbStudClass.Text = ""
        cmbClassTeacherid.Text = ""
        cmbD1.Text = ""
        cmbD2.Text = ""
        txtFee.Text = ""
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
        If txtaddNo.Text = "" Then
            MessageBox.Show("fill the AdmissionNo")
            Exit Sub
        End If

        If ComboBox1.Text = "" Then
            MessageBox.Show("fill the Enquiry No")
            Exit Sub
        End If
        If txtStuName.Text = "" Then
            MessageBox.Show("fill the Student Name")
            Exit Sub
        End If

        If cmbStudGender.Text = "" Then
            MessageBox.Show("fill the Student Gender ")
            Exit Sub
        End If
        If cmbStudCate.Text = "" Then
            MessageBox.Show("fill the Student Categeries")
            Exit Sub
        End If
        If txtStudCast.Text = "" Then
            MessageBox.Show("fill the Student Cast")
            Exit Sub
        End If
        If cmbPriviStan.Text = "" Then
            MessageBox.Show("fill the priviouse standered")
            Exit Sub
        End If
        If txtpriviResult.Text = "" Then
            MessageBox.Show("fill the priviouse result")
            Exit Sub
        End If
        If txtpriviSchool.Text = "" Then
            MessageBox.Show("fill the address")
            Exit Sub
        End If
        'If Txt_city.Text = "" Then
        '    MessageBox.Show("fill the city")
        '    Exit Sub
        'End If
        If txtFathername.Text = "" Then
            MessageBox.Show("fill the Father Name")
            Exit Sub
        End If
        If txtMotherName.Text = "" Then
            MessageBox.Show("fill the Mother Name")
            Exit Sub
        End If
        If txtGrarName.Text = "" Then
            MessageBox.Show("fill the Gardian Name")
            Exit Sub
        End If
        If txtAdd.Text = "" Then
            MessageBox.Show("fill the Address")
            Exit Sub
        End If
        If txtCity.Text = "" Then
            MessageBox.Show("fill the City")
            Exit Sub
        End If
        If txtContactNo.Text = "" Then
            MessageBox.Show("fill the Contact No")
            Exit Sub
        End If
        If cmbStudClass.Text = "" Then
            MessageBox.Show("fill the Student Class")
            Exit Sub
        End If
        If cmbClassTeacherid.Text = "" Then
            MessageBox.Show("fill the Class Teacher id")
            Exit Sub
        End If
        If cmbD1.Text = "" Then
            MessageBox.Show("fill the Document 1")
            Exit Sub
        End If
        If cmbD2.Text = "" Then
            MessageBox.Show("fill the Document 2")
            Exit Sub
        End If
        If txtFee.Text = "" Then
            MessageBox.Show("fill the Fee")
            Exit Sub
        End If
        TtxtStudid.Text = "S :" + txtaddNo.Text

        cmd = New OleDbCommand("insert into Admission_Master values(" & txtaddNo.Text & ",'" & DateTimePicker2.Value & "','" & ComboBox1.Text & "','" & txtStuName.Text & "','" & DateTimePicker3.Text & "','" & cmbStudGender.Text & "','" & cmbStudCate.Text & "','" & txtStudCast.Text & "','" & cmbPriviStan.Text & "','" & txtpriviResult.Text & "','" & txtpriviSchool.Text & "','" & txtFathername.Text & "','" & txtMotherName.Text & "','" & txtGrarName.Text & "','" & txtAdd.Text & "','" & txtCity.Text & "','" & txtContactNo.Text & "','" & TtxtStudid.Text & "','" & cmbStudClass.Text & "','" & cmbClassTeacherid.Text & "','" & cmbD1.Text & "','" & cmbD2.Text & "'," & txtFee.Text & ")", Conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        Admission_Master_Load(sender, e)

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
        txtaddNo.Text = ""
        'Txt_city.Text = ""
        DateTimePicker2.Text = ""
        ComboBox1.Text = ""
        txtStuName.Text = ""
        DateTimePicker3.Text = ""
        cmbStudGender.Text = ""
        cmbStudCate.Text = ""
        txtStudCast.Text = ""
        cmbPriviStan.Text = ""
        txtpriviResult.Text = ""
        txtpriviSchool.Text = ""
        txtFathername.Text = ""
        txtMotherName.Text = ""
        txtGrarName.Text = ""
        txtAdd.Text = ""
        txtCity.Text = ""
        txtContactNo.Text = ""
        TtxtStudid.Text = ""
        cmbStudClass.Text = ""
        cmbClassTeacherid.Text = ""
        cmbD1.Text = ""
        cmbD2.Text = ""
        txtFee.Text = ""
        

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

    Private Sub Btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Delete.Click
        Try
            ss = "delete from Admission_Master where Admission_No=" & txtaddNo.Text & ""
            com = New OleDbCommand(ss, Conn)

            com.ExecuteNonQuery()
            MsgBox("Record Deleted Sucessfully!!!")
            opendb()
            Admission_Master_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_update.Click
        Try
            ss = "update Admission_Master set Admission_Date='" & DateTimePicker2.Text & "',Enqury_No=" & ComboBox1.Text & ",Student_Name='" & txtStuName.Text & "',Student_DateOfBirth='" & DateTimePicker3.Text & "',Student_Gender='" & cmbStudGender.Text & "',Student_Categiree='" & cmbStudCate.Text & "',Student_Cast='" & txtStudCast.Text & "',Preiouse_Standerd='" & cmbPriviStan.Text & "',Preiouse_Result='" & txtpriviResult.Text & "', preiouse_school='" & txtpriviSchool.Text & "', Father_Name='" & txtFathername.Text & "',Mother_Name='" & txtMotherName.Text & "',Gardian_Name='" & txtGrarName.Text & "',Address='" & txtAdd.Text & "', City='" & txtCity.Text & "',ContactNo='" & txtContactNo.Text & "',Student_Id='" & TtxtStudid.Text & "',Student_Class='" & cmbStudClass.Text & "',ClassTeacher_Id='" & cmbClassTeacherid.Text & "',Document_1='" & cmbD1.Text & "',Document_2='" & cmbD2.Text & "', Fees= " & txtFee.Text & " where Admission_No = " & txtaddNo.Text & ""
            com = New OleDbCommand(ss, Conn)
            com.ExecuteNonQuery()
            MsgBox("Record Updated SucessfullY!!")
            Admission_Master_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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
        If (recno >= 0 And recno < ds.Tables("Admission_Master").Rows.Count) Then
            nav()
        Else
            MessageBox.Show("First Record")
        End If
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub

    Private Sub Btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_next.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("Admission_Master").Rows.Count) Then
            nav()
        Else

            MessageBox.Show("Last Record")
        End If
    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            recno = ds.Tables("Admission_Master").Rows.Count - 1
            nav()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        ss = "select Stu_Name,Stu_DateOfBirth,Stu_Gender,Stu_preiouse_Standared,Preiouse_Result,Preiouse_School,Parent_Name,Parent_Address,Parent_City,Parent_ContactNo from Enqury_Master where En_No = " & ComboBox1.Text & ""
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        If rdr.Read() Then
            txtStuName.Text = rdr.Item(0)
            DateTimePicker3.Text = rdr.Item(1)
            cmbStudGender.Text = rdr.Item(2)
            cmbPriviStan.Text = rdr.Item(3)
            txtpriviResult.Text = rdr.Item(4)
            txtpriviSchool.Text = rdr.Item(5)
            txtFathername.Text = rdr.Item(6)
            txtGrarName.Text = rdr.Item(6)
            txtAdd.Text = rdr.Item(7)
            txtCity.Text = rdr.Item(8)
            txtContactNo.Text = rdr.Item(9)
        End If
    End Sub
End Class