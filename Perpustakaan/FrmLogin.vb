Public Class FrmLogin
    Dim a As Integer
    Private Sub txtusername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtusername.GotFocus
        txtusername.Clear()
    End Sub
    Private Sub txtpassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpassword.GotFocus
        txtpassword.Clear()
        txtpassword.PasswordChar = "*"
    End Sub
    Private Sub FrmLogin_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If a = 0 Then
            End
        End If
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBoxX1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxX1.CheckedChanged
        If CheckBoxX1.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        a = 1
        If Trim(txtusername.Text) = "" Then
            ErrorProvider1.SetError(txtusername, "Username Harus Diisi")
        ElseIf Trim(txtpassword.Text) = "" Then
            ErrorProvider1.SetError(txtpassword, "Password Harus Diisi")
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("select * from tb_login where usernm='" & txtusername.Text & "' and passwd='" & txtpassword.Text & "'", conperpus)
            dtrperpus = cmdperpus.ExecuteReader
            If dtrperpus.HasRows Then
                While dtrperpus.Read
                    MenuUtama.lblnamaop.Text = "Nama : " + dtrperpus("nm_lengkap")
                    MenuUtama.lblkodelogin.Text = dtrperpus("kode_login")
                    MenuUtama.lbllevel.Text = dtrperpus("level")
                    'MsgBox("Selamat Datang " + dtrperpus("nm_lengkap"), MsgBoxStyle.Information, "Berhasil Login")
                    Close()
                End While
            Else
                gagal_login()
            End If
        End If
    End Sub
    Public Sub gagal_login()
        MsgBox("Username atau password salah", MsgBoxStyle.Critical, "Gagal Login")
        txtusername.Clear()
        txtpassword.Clear()
        txtusername.Focus()
    End Sub

    Private Sub txtusername_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtusername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtpassword.Focus()
        End If
    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonX1_Click(sender, AcceptButton)
        End If
    End Sub

    Private Sub txtpassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = 1
        If Trim(txtusername.Text) = "" Then
            ErrorProvider1.SetError(txtusername, "Username Harus Diisi")
        ElseIf Trim(txtpassword.Text) = "" Then
            ErrorProvider1.SetError(txtpassword, "Password Harus Diisi")
        Else
            cmdperpus = New OleDb.OleDbCommand _
                ("select * from tb_login where usernm='" & txtusername.Text & "' and passwd='" & txtpassword.Text & "'", conperpus)
            dtrperpus = cmdperpus.ExecuteReader
            If dtrperpus.HasRows Then
                While dtrperpus.Read
                    MenuUtama.lblnamaop.Text = "Nama : " + dtrperpus("nm_lengkap")
                    MenuUtama.lblkodelogin.Text = dtrperpus("kode_login")
                    MenuUtama.lbllevel.Text = dtrperpus("level")
                    'MsgBox("Selamat Datang " + dtrperpus("nm_lengkap"), MsgBoxStyle.Information, "Berhasil Login")
                    Close()
                End While
            Else
                gagal_login()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Apakah Anda Akan Menutup Program?", MsgBoxStyle.Exclamation + _
            MsgBoxStyle.OkCancel, "Tutup Program") = _
            MsgBoxResult.Ok Then
            End
        End If
    End Sub
End Class