Imports System.Data.OleDb
Public Class FormLogin

    Private Sub FormLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TextBox1.Text = "PTG001"
        'TextBox2.Text = "ADMIN"
        'TextBox2.PasswordChar = "X"
        Call KondisiAwal()
    End Sub
    Sub KondisiAwal()
        'TextBox1.Text = "PTG001"
        'TextBox2.Text = "ADMIN"
        TextBox2.PasswordChar = "X"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New OleDbCommand("Select * from TBL_PETUGAS where KodePetugas='" & TextBox1.Text & "' and PasswordPetugas='" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Visible = False
            Call BukaKunci()
            HalamanUtama.STLabel2.Text = Rd.Item("KodePetugas")
            HalamanUtama.STLabel4.Text = Rd.Item("NamaPetugas")
            HalamanUtama.STLabel6.Text = Rd.Item("LevelPetugas")
            'MsgBox("Anda Berhasil Login!")
            HalamanUtama.ShowDialog()
            Call KondisiAwal()
            'If Not HalamanUtama.STLabel6.Text = "ADMIN" Then
            '    HalamanUtama.Button1.Visible = False
            '    HalamanUtama.Button2.Visible = False
            '    HalamanUtama.Button3.Visible = False
            '    HalamanUtama.Button5.Visible = False
            '    HalamanUtama.Button6.Visible = False
            'End If
        Else
            MsgBox("Kode Petugas atau Password Salah")
        End If
    End Sub
    Sub BukaKunci()
        HalamanUtama.Button1.Enabled = True
        HalamanUtama.Button2.Enabled = True
        HalamanUtama.Button3.Enabled = True
        HalamanUtama.Button4.Enabled = True
        HalamanUtama.Button5.Enabled = True
        HalamanUtama.Button6.Enabled = True
        HalamanUtama.Button7.Enabled = True
        HalamanUtama.Button8.Enabled = True
        HalamanUtama.Button9.Enabled = True
        HalamanUtama.Button10.Enabled = True
        HalamanUtama.Button11.Enabled = True
        HalamanUtama.Button12.Enabled = True
        HalamanUtama.Button13.Enabled = True
        HalamanUtama.Button14.Enabled = True
        HalamanUtama.Button17.Enabled = True
        HalamanUtama.Button17.Text = "Logout"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.PasswordChar = ""
        Else
            TextBox2.PasswordChar = "X"
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, AcceptButton)
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(sender, AcceptButton)
        End If
    End Sub
End Class