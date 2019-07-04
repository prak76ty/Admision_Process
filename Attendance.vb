Imports System.Data.OleDb
Imports System.Data
Public Class Attendance
    Dim ss As String
    Dim com As OleDbCommand
    Dim cmd, cmdTemp As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer
    Dim temp As Integer
    Public Event CurrentCellDirtyStateChanged As EventHandler
    Private Sub Attendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        ss = "select distinct(sclass)from stud_master"
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        cmbClass.Items.Clear()
        While rdr.Read()
            cmbClass.Items.Add(rdr.Item(0))
        End While
        cmbClass.Sorted = True

        ss = "select distinct(division) from stud_master"
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        cmbDiv.Items.Clear()
        While rdr.Read()
            cmbDiv.Items.Add(rdr.Item(0))
        End While
        cmbDiv.Sorted = True
    End Sub


    Private Sub cmbDiv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDiv.SelectedIndexChanged
        ss = "select techer_name from stud_master where sclass = '" & cmbClass.Text & "' and division= '" & cmbDiv.Text & "'"
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()

        If rdr.Read() Then
            txtTeacherName.Text = rdr.Item(0).ToString
        End If
    End Sub

    Private Sub cmbClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClass.SelectedIndexChanged
        ss = "select techer_name from stud_master where sclass = '" & cmbClass.Text & "' and division= '" & cmbDiv.Text & "'"
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()

        If rdr.Read() Then
            txtTeacherName.Text = rdr.Item(0).ToString
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        da = New OleDbDataAdapter("select sid as [Student ID],rollno as [Roll No] ,sname as [Student Name],sclass as [Class],division as [Division],techer_name AS [Class Teacher] from stud_master where sclass = '" & cmbClass.Text & "' and division= '" & cmbDiv.Text & "'", Conn)
        ds = New DataSet
        da.Fill(ds, "stud_master")
        DataGridView1.DataSource = ds.Tables("stud_master")
        DataGridView1.CommitEdit(0)
        DataGridView1.Refresh()
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim strStatus As String
        Dim rows As DataGridViewRow
        cmd = New OleDbCommand

        cmd.CommandText = "INSERT INTO Attendance_Master (srno,sid,rollNo,Student_Name,Student_class,stud_div,techer,Attendance_Date,Status) VALUES (@srno,@sid,@rollNo,@Student_Name,@Student_class,@stud_div,@techer,@Attendance_Date,@Status)"

        cmd.Parameters.AddWithValue("@srno", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@sid", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@rollNo", OleDbType.Numeric)
        cmd.Parameters.AddWithValue("@Student_Name", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@Student_class", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@stud_div", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@techer", OleDbType.VarChar)
        cmd.Parameters.AddWithValue("@Attendance_Date", OleDbType.DBDate)
        cmd.Parameters.AddWithValue("@Status", OleDbType.VarChar)

        cmd.Connection = Conn

        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            rows = DataGridView1.Rows(i)
            If Convert.ToBoolean(DirectCast(rows.Cells(0), DataGridViewCheckBoxCell).Value) = True Then
                strStatus = "Present"
            Else
                strStatus = "Absent"
            End If

            Dim cmdTemp = New OleDbCommand("select max (srno) from Attendance_Master", Conn)
            rdr = cmdTemp.ExecuteReader()
            rdr.Read()

            If (rdr.Item(0) IsNot DBNull.Value) Then
                temp = rdr.Item(0) + 1
            Else
                temp = 1
            End If

            cmd.Parameters(0).Value = temp
            cmd.Parameters(1).Value = DataGridView1.Rows(i).Cells(1).Value
            cmd.Parameters(2).Value = DataGridView1.Rows(i).Cells(2).Value
            cmd.Parameters(3).Value = DataGridView1.Rows(i).Cells(3).Value
            cmd.Parameters(4).Value = DataGridView1.Rows(i).Cells(4).Value
            cmd.Parameters(5).Value = DataGridView1.Rows(i).Cells(5).Value
            cmd.Parameters(6).Value = DataGridView1.Rows(i).Cells(6).Value
            cmd.Parameters(7).Value = DateTimePicker1.Value.Date
            cmd.Parameters(8).Value = strStatus

            cmd.ExecuteNonQuery()
        Next
        MessageBox.Show("Attendance Entered for the Date : " & DateTimePicker1.Value.Date & " of the Class " & cmbClass.Text & " and Division " & cmbDiv.Text & " Successfully")
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

End Class