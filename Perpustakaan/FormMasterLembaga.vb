Imports System.Data.OleDb
Public Class FormMasterLembaga
    Sub KondisiAwal()
        Call Koneksi()
        Cmd = New OleDbCommand("select * from TBL_LEMBAGA", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            TextBox1.Text = Rd.Item("KodeLembaga")
            TextBox2.Text = Rd.Item("NamaLembaga")
            TextBox3.Text = Rd.Item("AlamatLembaga")
            TextBox4.Text = Rd.Item("TeleponLembaga")
            TextBox5.Text = Rd.Item("EmailLembaga")
            TextBox6.Text = Rd.Item("WebsiteLembaga")
        Else
            TextBox1.Text = Rd.Item("KodeLembaga")
            TextBox2.Text = Rd.Item("NamaLembaga")
            TextBox3.Text = Rd.Item("AlamatLembaga")
            TextBox4.Text = Rd.Item("TeleponLembaga")
            TextBox5.Text = Rd.Item("EmailLembaga")
            TextBox6.Text = Rd.Item("WebsiteLembaga")
        End If
        TextBox1.Enabled = False
        TextBox1.Text = "01"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub FormMasterLembaga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Pastikan Anda Mengisi Semua Field")
        Else
            Call Koneksi()
            Dim EditData As String = "update TBL_LEMBAGA set KodeLembaga='" & TextBox1.Text & "',NamaLembaga='" & TextBox2.Text & "', AlamatLembaga='" & TextBox3.Text & "',TeleponLembaga='" & TextBox4.Text & "', EmailLembaga='" & TextBox5.Text & "', WebsiteLembaga='" & TextBox6.Text & "'"
            Cmd = New OleDbCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil Disimpan!")
            Me.Close()
        End If
    End Sub
End Class