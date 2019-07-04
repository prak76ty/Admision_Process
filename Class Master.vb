Imports System.Data.OleDb
Imports System.Data


Public Class Class_Master
    Dim ss As String
    Dim com As OleDbCommand
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer
    Private Sub Class_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
        da = New OleDbDataAdapter("select * from Class_master", Conn)
        ds = New DataSet
        da.Fill(ds, "Class_Master")


        ss = "select distinct(Tcr_Id) from Teacher_Master"
        CmbTeacherid.Items.Clear()
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        While rdr.Read()
            CmbTeacherid.Sorted = True
            CmbTeacherid.Items.Add(rdr.Item(0))
        End While
    End Sub
    Private Sub nav()
        txt_tcid.Text = ds.Tables("Class_Master").Rows(recno).Item(0)
        txtclassname.Text = ds.Tables("Class_Master").Rows(recno).Item(1)
        CmbTeacherid.Text = ds.Tables("Class_Master").Rows(recno).Item(2)
        txtTecherName.Text = ds.Tables("Class_Master").Rows(recno).Item(3)
        cmbDiv.Text = ds.Tables("Class_Master").Rows(recno).Item(4)

        txtIntact.Text = ds.Tables("Class_Master").Rows(recno).Item(5)
        cmbMarathi.Text = ds.Tables("Class_Master").Rows(recno).Item(6)

        cmbHindi.Text = ds.Tables("Class_Master").Rows(recno).Item(7)
        cmbEnglish.Text = ds.Tables("Class_Master").Rows(recno).Item(8)
        cmbScience.Text = ds.Tables("Class_Master").Rows(recno).Item(9)
        cmbGeo.Text = ds.Tables("Class_Master").Rows(recno).Item(10)
        cmbMath.Text = ds.Tables("Class_Master").Rows(recno).Item(11)
        cmbHist.Text = ds.Tables("Class_Master").Rows(recno).Item(12)
        cmbPT.Text = ds.Tables("Class_Master").Rows(recno).Item(13)


    End Sub

    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max (Class_Id) from Class_master", Conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1

        End If
        txt_tcid.Text = temp.ToString
        txtclassname.Text = ""
        CmbTeacherid.Text = ""
        txtTecherName.Text = ""
        cmbDiv.Text = ""

        txtIntact.Text = ""
        cmbMarathi.Text = ""
        cmbHindi.Text = ""
        cmbEnglish.Text = ""
        cmbScience.Text = ""
        cmbGeo.Text = ""
        cmbMath.Text = ""
        cmbHist.Text = ""
        cmbPT.Text = ""

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
        If txt_tcid.Text = "" Then
            MessageBox.Show("fill the Class id")
            Exit Sub
        End If
        If txtclassname.Text = "" Then
            MessageBox.Show("fill the class name")
            Exit Sub
        End If
        If CmbTeacherid.Text = "" Then
            MessageBox.Show("fill the teacher id")
            Exit Sub
        End If
        If txtIntact.Text = "" Then
            MessageBox.Show("fill the intact")
            Exit Sub
        End If
        
        cmd = New OleDbCommand("insert into Class_Master values(" & txt_tcid.Text & ",'" & txtclassname.Text & "','" & CmbTeacherid.Text & "','" & txtTecherName.Text & "','" & cmbDiv.Text & "','" & txtIntact.Text & "','" & cmbMarathi.Text & "','" & cmbHindi.Text & "','" & cmbEnglish.Text & "','" & cmbScience.Text & "','" & cmbGeo.Text & "','" & cmbMath.Text & "','" & cmbHist.Text & "','" & cmbPT.Text & "')", Conn)

        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        Class_Master_Load(sender, e)

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
        txt_tcid.Text = ""
        'Txt_city.Text = ""
        txtclassname.Text = ""
        CmbTeacherid.Text = ""
        txtTecherName.Text = ""
        cmbDiv.Text = ""
        txtIntact.Text = ""
        cmbMarathi.Text = ""
        cmbHindi.Text = ""
        cmbEnglish.Text = ""
        cmbScience.Text = ""
        cmbGeo.Text = ""
        cmbMath.Text = ""
        cmbHist.Text = ""
        cmbPT.Text = ""


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

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            recno = ds.Tables("Class_master").Rows.Count - 1
            nav()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_next.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("Class_Master").Rows.Count) Then
            nav()
        Else

            MessageBox.Show("Last Record")
        End If
    End Sub

    Private Sub Btn_preiouse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_preiouse.Click
        recno = recno - 1
        If (recno >= 0 And recno < ds.Tables("Class_master").Rows.Count) Then
            nav()
        Else
            MessageBox.Show("First Record")
        End If
    End Sub

    Private Sub Btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Delete.Click
        Try
            ss = "delete from Class_Master where Class_Id=" & txt_tcid.Text & ""
            com = New OleDbCommand(ss, Conn)

            com.ExecuteNonQuery()
            MsgBox("Record Deleted Sucessfully!!!")
            opendb()
            Class_Master_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_update.Click
        Try
            ss = "update Class_Master set Class_Name= '" & txtclassname.Text & "' ,Tcr_Id=" & CmbTeacherid.Text & ",techerName='" & txtTecherName.Text & "', division= '" & cmbDiv.Text & "', Intac= " & txtIntact.Text & ",Marathi= '" & cmbMarathi.Text & "',Hindi= '" & cmbHindi.Text & "',English= '" & cmbEnglish.Text & "',Science= '" & cmbScience.Text & "',Gography= '" & cmbGeo.Text & "',Mathematics= '" & cmbMath.Text & "',History= '" & cmbHist.Text & "',PT_Softskill= '" & cmbPT.Text & "' WHERE Class_Id= " & txt_tcid.Text & ""
            com = New OleDbCommand(ss, Conn)
            com.ExecuteNonQuery()
            MsgBox("Record Updated Sucessfully!!!")
            Class_Master_Load(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub

    Private Sub CmbTeacherid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTeacherid.SelectedIndexChanged
        ss = "select Tcr_Name from Teacher_Master where Tcr_Id = " & CmbTeacherid.Text & ""
        com = New OleDbCommand(ss, Conn)
        rdr = com.ExecuteReader()
        If rdr.Read() Then
            txtTecherName.Text = rdr.Item(0)

        End If
    End Sub

    Private Sub txtTecherName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTecherName.TextChanged

    End Sub
End Class