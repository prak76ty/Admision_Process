Imports System.Data.OleDb
Imports System.Data
Public Class EXAM_FORM
    Dim ss As String
    Dim com As OleDbCommand
    Dim cmd, cmdTemp As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer
    Dim temp, i As Integer


    Private Sub EXAM_FORM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        ss = "select distinct(Student_Id)from Admission_Master"
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        CMBSTUDENTID.Items.Clear()
        While rdr.Read()
            CMBSTUDENTID.Items.Add(rdr.Item(0))
        End While
        CMBSTUDENTID.Sorted = True

        ss = "select distinct(Tcr_Id) from Teacher_Master"
        CmbTeacherid.Items.Clear()
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        While rdr.Read()
            CmbTeacherid.Sorted = True
            CmbTeacherid.Items.Add(rdr.Item(0))
        End While

        Btn_add.Enabled = True
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
        btn_exit.Enabled = True
    End Sub

    Private Sub CMBSTUDENTID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBSTUDENTID.SelectedIndexChanged
        ss = "select Student_Name, Student_Class from Admission_Master where Student_Id = '" & CMBSTUDENTID.Text & "'"
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()

        If rdr.Read() Then
            TXTSTUDENTNAME.Text = rdr.Item(0).ToString
            TXTSTUCLASS.Text = rdr.Item(1).ToString
        End If
    End Sub

    Private Sub clear()
        TXTMARATHI.Text = ""
        TXTHINDI.Text = ""
        TXTENGLISH.Text = ""
        TXTSCINCE.Text = ""
        TXTGEO.Text = ""
        TXTMATH.Text = ""
        TXTHISTORY.Text = ""
        TXTPTSOFTSKILL.Text = ""

    End Sub
    Private Sub TXTSTUCLASS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTSTUCLASS.TextChanged
        ss = "select Marathi, Hindi, English, Science, Gography, Mathematics, History, PT_Softskill from Class_Master where Class_Name = '" & TXTSTUCLASS.Text & "'"
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()

        If rdr.Read() Then
            If (rdr.Item(0).ToString) = "NO" Then
                TXTMARATHI.Enabled = False
            Else
                TXTMARATHI.Enabled = True
            End If
            If (rdr.Item(1).ToString) = "NO" Then
                TXTHINDI.Enabled = False
            Else
                TXTHINDI.Enabled = True
            End If
            If (rdr.Item(2).ToString) = "NO" Then
                TXTENGLISH.Enabled = False
            Else
                TXTENGLISH.Enabled = True
            End If
            If (rdr.Item(3).ToString) = "NO" Then
                TXTSCINCE.Enabled = False
            Else
                TXTSCINCE.Enabled = True
            End If
            If (rdr.Item(4).ToString) = "NO" Then
                TXTGEO.Enabled = False
            Else
                TXTGEO.Enabled = True
            End If
            If (rdr.Item(5).ToString) = "NO" Then
                TXTMATH.Enabled = False
            Else
                TXTMATH.Enabled = True
            End If
            If (rdr.Item(6).ToString) = "NO" Then
                TXTHISTORY.Enabled = False
            Else
                TXTHISTORY.Enabled = True
            End If
            If (rdr.Item(7).ToString) = "NO" Then
                TXTPTSOFTSKILL.Enabled = False
            Else
                TXTPTSOFTSKILL.Enabled = True
            End If
        End If

    End Sub

    Private Sub TXTMARATHI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTMARATHI.TextChanged
        TXTTOTALMARKS.Text = Val(TXTMARATHI.Text) + Val(TXTHINDI.Text) + Val(TXTENGLISH.Text) + Val(TXTSCINCE.Text) + Val(TXTGEO.Text) + Val(TXTMATH.Text) + Val(TXTHISTORY.Text) + Val(TXTPTSOFTSKILL.Text)
    End Sub

    Private Sub TXTTOTALMARKS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTTOTALMARKS.TextChanged
        i = 0
        If TXTMARATHI.Enabled = True Then
            i = i + 1
        End If
        If TXTHINDI.Enabled = True Then
            i = i + 1
        End If
        If TXTENGLISH.Enabled = True Then
            i = i + 1
        End If
        If TXTSCINCE.Enabled = True Then
            i = i + 1
        End If
        If TXTGEO.Enabled = True Then
            i = i + 1
        End If
        If TXTMATH.Enabled = True Then
            i = i + 1
        End If
        If TXTHISTORY.Enabled = True Then
            i = i + 1
        End If
        If TXTPTSOFTSKILL.Enabled = True Then
            i = i + 1
        End If

        TXTPER.Text = ((Val(TXTTOTALMARKS.Text) / i)).ToString
    End Sub

    Private Sub TXTHINDI_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTHINDI.TextChanged
        TXTTOTALMARKS.Text = Val(TXTMARATHI.Text) + Val(TXTHINDI.Text) + Val(TXTENGLISH.Text) + Val(TXTSCINCE.Text) + Val(TXTGEO.Text) + Val(TXTMATH.Text) + Val(TXTHISTORY.Text) + Val(TXTPTSOFTSKILL.Text)
    End Sub

    Private Sub TXTENGLISH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTENGLISH.TextChanged
        TXTTOTALMARKS.Text = Val(TXTMARATHI.Text) + Val(TXTHINDI.Text) + Val(TXTENGLISH.Text) + Val(TXTSCINCE.Text) + Val(TXTGEO.Text) + Val(TXTMATH.Text) + Val(TXTHISTORY.Text) + Val(TXTPTSOFTSKILL.Text)
    End Sub

    Private Sub TXTSCINCE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTSCINCE.TextChanged
        TXTTOTALMARKS.Text = Val(TXTMARATHI.Text) + Val(TXTHINDI.Text) + Val(TXTENGLISH.Text) + Val(TXTSCINCE.Text) + Val(TXTGEO.Text) + Val(TXTMATH.Text) + Val(TXTHISTORY.Text) + Val(TXTPTSOFTSKILL.Text)
    End Sub

    Private Sub TXTGEO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTGEO.TextChanged
        TXTTOTALMARKS.Text = Val(TXTMARATHI.Text) + Val(TXTHINDI.Text) + Val(TXTENGLISH.Text) + Val(TXTSCINCE.Text) + Val(TXTGEO.Text) + Val(TXTMATH.Text) + Val(TXTHISTORY.Text) + Val(TXTPTSOFTSKILL.Text)
    End Sub

    Private Sub TXTMATH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTMATH.TextChanged
        TXTTOTALMARKS.Text = Val(TXTMARATHI.Text) + Val(TXTHINDI.Text) + Val(TXTENGLISH.Text) + Val(TXTSCINCE.Text) + Val(TXTGEO.Text) + Val(TXTMATH.Text) + Val(TXTHISTORY.Text) + Val(TXTPTSOFTSKILL.Text)
    End Sub

    Private Sub TXTHISTORY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTHISTORY.TextChanged
        TXTTOTALMARKS.Text = Val(TXTMARATHI.Text) + Val(TXTHINDI.Text) + Val(TXTENGLISH.Text) + Val(TXTSCINCE.Text) + Val(TXTGEO.Text) + Val(TXTMATH.Text) + Val(TXTHISTORY.Text) + Val(TXTPTSOFTSKILL.Text)
    End Sub

    Private Sub TXTPTSOFTSKILL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTPTSOFTSKILL.TextChanged
        TXTTOTALMARKS.Text = Val(TXTMARATHI.Text) + Val(TXTHINDI.Text) + Val(TXTENGLISH.Text) + Val(TXTSCINCE.Text) + Val(TXTGEO.Text) + Val(TXTMATH.Text) + Val(TXTHISTORY.Text) + Val(TXTPTSOFTSKILL.Text)
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub

    Private Sub CmbTeacherid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTeacherid.SelectedIndexChanged
        ss = "select Tcr_Name from Teacher_Master where Tcr_Id = " & CmbTeacherid.Text & ""
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        If rdr.Read() Then
            TXTTEACNAME.Text = rdr.Item(0)

        End If
    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max (SrNo) from Exam", Conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If

        TXTSRNO.Text = temp.ToString
        CMBSTUDENTID.Text = ""
        TXTSTUDENTNAME.Text = ""
        TXTSTUCLASS.Text = ""
        CmbTeacherid.Text = ""
        TXTTEACNAME.Text = ""
        TXTMARATHI.Text = ""
        TXTHINDI.Text = ""
        TXTENGLISH.Text = ""
        TXTSCINCE.Text = ""
        TXTGEO.Text = ""
        TXTMATH.Text = ""
        TXTHISTORY.Text = ""
        TXTPTSOFTSKILL.Text = ""
        TXTTOTALMARKS.Text = ""
        TXTPER.Text = ""
        TXTGREAD.Text = ""
        TXTREMARK.Text = ""

        Btn_add.Enabled = False
        btn_save.Enabled = True
        Btn_cancle.Enabled = True
        btn_exit.Enabled = False
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If CMBSTUDENTID.Text = "" Then
            MessageBox.Show("Select Student ID")
            Exit Sub
        End If
        If CmbTeacherid.Text = "" Then
            MessageBox.Show("Select Teacher ID")
            Exit Sub
        End If

        If TXTMARATHI.Text = "" Then
            TXTMARATHI.Text = "0"
        End If
        If TXTHINDI.Text = "" Then
            TXTHINDI.Text = "0"
        End If
        If TXTENGLISH.Text = "" Then
            TXTENGLISH.Text = "0"
        End If
        If TXTSCINCE.Text = "" Then
            TXTSCINCE.Text = "0"
        End If
        If TXTGEO.Text = "" Then
            TXTGEO.Text = "0"
        End If
        If TXTMATH.Text = "" Then
            TXTMATH.Text = "0"
        End If
        If TXTHISTORY.Text = "" Then
            TXTHISTORY.Text = "0"
        End If
        If TXTPTSOFTSKILL.Text = "" Then
            TXTPTSOFTSKILL.Text = "0"
        End If

        If TXTREMARK.Text = "" Then
            TXTREMARK.Text = "Nil"
        End If

        cmd = New OleDbCommand("insert into Exam values(" & TXTSRNO.Text & ",'" & CMBSTUDENTID.Text & "','" & TXTSTUDENTNAME.Text & "','" & TXTSTUCLASS.Text & "'," & CmbTeacherid.Text & ",'" & TXTTEACNAME.Text & "'," & TXTMARATHI.Text & "," & TXTHINDI.Text & "," & TXTENGLISH.Text & "," & TXTSCINCE.Text & "," & TXTGEO.Text & "," & TXTMATH.Text & "," & TXTHISTORY.Text & "," & TXTPTSOFTSKILL.Text & "," & TXTTOTALMARKS.Text & "," & TXTPER.Text & ",'" & TXTGREAD.Text & "','" & TXTREMARK.Text & "')", Conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        EXAM_FORM_Load(sender, e)


        Btn_add.Enabled = True
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
        btn_exit.Enabled = True
    End Sub

    Private Sub Btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancle.Click
        TXTSRNO.Text = ""
        CMBSTUDENTID.Text = ""
        TXTSTUDENTNAME.Text = ""
        TXTSTUCLASS.Text = ""
        CmbTeacherid.Text = ""
        TXTTEACNAME.Text = ""
        TXTMARATHI.Text = ""
        TXTHINDI.Text = ""
        TXTENGLISH.Text = ""
        TXTSCINCE.Text = ""
        TXTGEO.Text = ""
        TXTMATH.Text = ""
        TXTHISTORY.Text = ""
        TXTPTSOFTSKILL.Text = ""
        TXTTOTALMARKS.Text = ""
        TXTPER.Text = ""
        TXTGREAD.Text = ""
        TXTREMARK.Text = ""

        Btn_add.Enabled = True
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
        btn_exit.Enabled = True
    End Sub
End Class