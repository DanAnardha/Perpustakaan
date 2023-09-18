Public Class FrmGantiPassword

    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.LostFocus
        If Trim(TextBox2.Text) <> Trim(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox2, "Konfirmasi password tidak sama")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) = "" Then
            ErrorProvider1.SetError(TextBox1, "Isi password baru")
        ElseIf Trim(TextBox2.Text) = "" Then
            ErrorProvider1.SetError(TextBox2, "Isi konfirmasi passsword baru")
        ElseIf Trim(TextBox2.Text) <> Trim(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox2, "Konfirmasi password tidak sama")
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("update tb_login set passwd='" & TextBox2.Text & "' where kode_login=" & MenuUtama.lblkodelogin.Text & "", conperpus)
            cmdperpus.ExecuteNonQuery()
            MsgBox("Password anda berhasil diubah", MsgBoxStyle.Information, "password")
            TextBox1.Clear()
            TextBox2.Clear()
            Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class