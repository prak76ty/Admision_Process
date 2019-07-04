
Imports System.Data.OleDb
Imports System.Data
Public Class Fee_Receipt_Master
    Dim ss As String
    Dim com As OleDbCommand
    Dim cmd As OleDbCommand
    Dim rdr As OleDbDataReader
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim recno As Integer

    Private Sub Fee_Receipt_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opendb()
        btn_save.Enabled = False
        Btn_cancle.Enabled = False
        da = New OleDbDataAdapter("select * from FeesReceit ", Conn)
        ds = New DataSet
        da.Fill(ds, "FeesReceit")

        cmd = New OleDbCommand("select Student_Id from Admission_Master", Conn)
        rdr = cmd.ExecuteReader
        combstudid.Items.Clear()
        While rdr.Read
            combstudid.Items.Add(rdr.Item(0))
        End While

    End Sub
    Private Sub nav()
        txtFeeReceiptNo.Text = ds.Tables("FeesReceit").Rows(recno).Item(0)
        DTPFeeReceiDate.Value = ds.Tables("FeesReceit").Rows(recno).Item(1)
        combstudid.Text = ds.Tables("FeesReceit").Rows(recno).Item(2)
        txtstudName.Text = ds.Tables("FeesReceit").Rows(recno).Item(3)
        txtstudclass.Text = ds.Tables("FeesReceit").Rows(recno).Item(4)
        txtamt.Text = ds.Tables("FeesReceit").Rows(recno).Item(5)
        txtRemark.Text = ds.Tables("FeesReceit").Rows(recno).Item(6)
        
    End Sub



    Private Sub Btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_add.Click
        Dim temp As Integer
        cmd = New OleDbCommand("select max (Receit_No) from  FeesReceit ", Conn)
        rdr = cmd.ExecuteReader()
        rdr.Read()
        If (rdr.Item(0) IsNot DBNull.Value) Then
            temp = rdr.Item(0) + 1
        Else
            temp = 1
        End If
        txtFeeReceiptNo.Text = temp.ToString
        'DTPFeeReceiDate.Value = ""
        combstudid.Text = ""
        txtstudName.Text = ""
        'Txt_city.Text = ""
        txtstudclass.Text = ""
        'txt_joiningdate.Text =
        txtamt.Text = ""
        txtRemark.Text = ""
        

        Btn_add.Enabled = False
        btn_save.Enabled = True
        Btn_cancle.Enabled = True
       
        Btn_first.Enabled = False
        Btn_preiouse.Enabled = False
        btn_exit.Enabled = False
        Btn_next.Enabled = False
        btn_last.Enabled = False
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If txtFeeReceiptNo.Text = "" Then
            MessageBox.Show("fill the FeeReceiptNo")
            Exit Sub
        End If

        If combstudid.Text = "" Then
            MessageBox.Show("fill the studid ")
            Exit Sub
        End If

        If txtstudName.Text = "" Then
            MessageBox.Show("fill the studName ")
            Exit Sub
        End If
        If txtstudclass.Text = "" Then
            MessageBox.Show("fill the studclass")
            Exit Sub
        End If
        If txtamt.Text = "" Then
            MessageBox.Show("fill the amt")
            Exit Sub
        End If
        If txtRemark.Text = "" Then
            MessageBox.Show("fill the Remark ")
            Exit Sub
        End If

        cmd = New OleDbCommand("insert into FeesReceit values(" & txtFeeReceiptNo.Text & ",'" & DTPFeeReceiDate.Value & "','" & combstudid.Text & "','" & txtstudName.Text & "','" & txtstudclass.Text & "','" & txtamt.Text & "','" & txtRemark.Text & "')", Conn)
        cmd.ExecuteNonQuery()
        MessageBox.Show("saved successfully")
        Fee_Receipt_Master_Load(sender, e)

        Btn_add.Enabled = True
        Btn_cancle.Enabled = False

        btn_exit.Enabled = True
        Btn_first.Enabled = True
        btn_last.Enabled = True
        Btn_next.Enabled = True
        Btn_preiouse.Enabled = True
        btn_save.Enabled = False

    End Sub
   
    Private Sub Btn_cancle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancle.Click
        txtFeeReceiptNo.Text = ""
        'Txt_city.Text = ""
        DTPFeeReceiDate.Text = ""
        combstudid.Text = ""
        txtstudName.Text = ""
        txtstudclass.Text = ""
        txtamt.Text = ""
        txtRemark.Text = ""

        Btn_add.Enabled = True
        Btn_cancle.Enabled = False

        btn_exit.Enabled = True
        Btn_first.Enabled = True
        btn_last.Enabled = True
        Btn_next.Enabled = True
        Btn_preiouse.Enabled = True
        btn_save.Enabled = False

    End Sub

    Private Sub btn_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_exit.Click
        Me.Close()
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
        If (recno >= 0 And recno < ds.Tables("FeesReceit").Rows.Count) Then
            nav()
        Else
            MessageBox.Show("First Record")
        End If
    End Sub

    Private Sub Btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_next.Click
        recno = recno + 1
        If (recno >= 0 And recno < ds.Tables("FeesReceit").Rows.Count) Then
            nav()
        Else

            MessageBox.Show("Last Record")
        End If
    End Sub

    Private Sub btn_last_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_last.Click
        Try
            recno = ds.Tables("FeesReceit").Rows.Count - 1
            nav()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub combstudid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combstudid.SelectedIndexChanged
        cmd = New OleDbCommand("select Student_Name,Student_Class from Admission_Master where Student_Id='" & combstudid.Text & "'", Conn)
        rdr = cmd.ExecuteReader
        If rdr.Read Then
            txtstudName.Text = rdr.Item(0)
            txtstudclass.Text = rdr.Item(1)
        End If
    End Sub
End Class