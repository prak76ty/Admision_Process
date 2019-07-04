
Imports System.Data.OleDb
Imports System.Data
Public Class Student_Master
    Dim ss As String
    Dim com As OleDbCommand
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer
    Private Sub Student_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
        da = New OleDbDataAdapter("select * from stud_master", Conn)
        ds = New DataSet
        da.Fill(ds, "stud_master")
    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max (srno) from stud_master", Conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        TXTSRNO.Text = temp.ToString
        CMBSID.Text = ""
        TXTROLLNO.Text = ""
        TXTSTUDNAME.Text = ""
        TXTCLASSTEACNAME.Text = ""
        CMBDIVI.Text = ""
        CMBCLASSTEACID.Text = ""
        TXTCLASSTEACNAME.Text = ""
        'txt_dob.Text = ""
        'Txt_possition.Text = ""

        Btn_add.Enabled = False
        btn_save.Enabled = True
        Btn_cancle.Enabled = True
        'Btn_Delete.Enabled = False
        'Btn_update.Enabled = False

        Btn_first.Enabled = False
        Btn_preiouse.Enabled = False
        btn_exit.Enabled = False
        Btn_next.Enabled = False
        btn_last.Enabled = False
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click


        If TXTSRNO.Text = "" Then
            MessageBox.Show("fill the srno")
            Exit Sub
        End If
        If CMBSID.Text = "" Then
            MessageBox.Show("fill the sid")
            Exit Sub
        End If
        If TXTROLLNO.Text = "" Then
            MessageBox.Show("fill the roll no")
            Exit Sub
        End If
        If TXTSTUDNAME.Text = "" Then
            MessageBox.Show("fill the student name")
            Exit Sub
        End If

        If CMBDIVI.Text = "" Then
            MessageBox.Show("fill the division")
            Exit Sub
        End If
        If CMBCLASSTEACID.Text = "" Then
            MessageBox.Show("fill the class teacher id")
            Exit Sub
        End If
        If TXTCLASSTEACNAME.Text = "" Then
            MessageBox.Show("fill the class teacher name")
            Exit Sub

        End If
        cmd = New OleDbCommand("insert into stud_master values( " & TXTSRNO.Text & ",'" & CMBSID.Text & "'," & TXTROLLNO.Text & ",'" & TXTSTUDNAME.Text & "','" & TXTSTUDCLASS.Text & "','" & CMBDIVI.Text & "','" & CMBCLASSTEACID.Text & "','" & TXTCLASSTEACNAME.Text & "')", Conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        Student_Master_Load(sender, e)

        Btn_add.Enabled = True
        Btn_cancle.Enabled = False
        'Btn_Delete.Enabled = True
        btn_exit.Enabled = True
        Btn_first.Enabled = True
        btn_last.Enabled = True
        Btn_next.Enabled = True
        Btn_preiouse.Enabled = True
        btn_save.Enabled = False
        'Btn_update.Enabled = True



    End Sub

    Private Sub Btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancle.Click
        TXTSRNO.Text = ""
        'Txt_city.Text = ""
        CMBSID.Text = ""
        TXTROLLNO.Text = ""
        TXTSTUDNAME.Text = ""
        TXTSTUDCLASS.Text = ""
        CMBDIVI.Text = ""
        CMBCLASSTEACID.Text = ""
        TXTCLASSTEACNAME.Text = ""

         Btn_add.Enabled = True
        Btn_cancle.Enabled = False
        'Btn_Delete.Enabled = True
        btn_exit.Enabled = True
        Btn_first.Enabled = True
        btn_last.Enabled = True
        Btn_next.Enabled = True
        Btn_preiouse.Enabled = True
        btn_save.Enabled = False
        'Btn_update.Enabled = True


    End Sub
    Private Sub nav()
        TXTSRNO.Text = ds.Tables("stud_master").Rows(recno).Item(0)
        CMBSID.Text = ds.Tables("stud_master").Rows(recno).Item(1)
        TXTROLLNO.Text = ds.Tables("stud_master").Rows(recno).Item(2)
        TXTSTUDNAME.Text = ds.Tables("stud_master").Rows(recno).Item(3)
        TXTSTUDCLASS.Text = ds.Tables("stud_master").Rows(recno).Item(4)
        CMBDIVI.Text = ds.Tables("stud_master").Rows(recno).Item(5)
        CMBCLASSTEACID.Text = ds.Tables("stud_master").Rows(recno).Item(6)
        TXTCLASSTEACNAME.Text = ds.Tables("stud_master").Rows(recno).Item(7)


    End Sub


    Private Sub Btn_first_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_first.Click
        Try
            recno = 0
            nav()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            recno = ds.Tables("stud_master").Rows.Count - 1
            nav()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_next.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("stud_master").Rows.Count) Then
            nav()
        Else

            MessageBox.Show("Last Record")
        End If
    End Sub

    Private Sub Btn_preiouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_preiouse.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("stud_master").Rows.Count) Then
            nav()
        Else
            MessageBox.Show("First Record")
        End If
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class