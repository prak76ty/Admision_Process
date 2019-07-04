
Public Class Form1


    Private Sub Btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ok.Click
        If (Txtun.Text = "1" And Txtpw.Text = "1") Then
            mdi.Show()
            Me.Hide()
        Else
            MessageBox.Show("login failed")
        End If

    End Sub

    Private Sub Btn_ccle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ccle.Click
        End
    End Sub
End Class
