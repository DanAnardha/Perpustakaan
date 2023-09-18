Public Class FrmKelompokBuku
    Dim kode_buku As Integer
    Dim kelompok_buku As String
    Public Sub kode_otomatis()
        cmdperpus = New OleDb.OleDbCommand _
        ("select * from nomor", conperpus)
        dtrperpus = cmdperpus.ExecuteReader

        While dtrperpus.Read
            kode_buku = dtrperpus("kode") + 1
        End While

        kelompok_buku = Strings.Left(ComboBox1.Text, 4)
        kelompok_buku.ToString()
        FrmBuku.txtkodebuku.Text = kelompok_buku & "-" & Format(kode_buku, "0000")
        FrmBuku.cmbJenisBuku.Text = ComboBox1.Text
        
        FrmBuku.ShowDialog()
        
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("Pilih dulu kelompok buku..", MsgBoxStyle.Exclamation, "kelompok buku")
            ComboBox1.Focus()
        Else
            kode_otomatis()

        End If

    End Sub
    Private Sub FrmKelompokBuku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        cmdperpus = New OleDb.OleDbCommand _
        ("select * from kelompok_buku", conperpus)
        dtrperpus = cmdperpus.ExecuteReader

        While dtrperpus.Read
            ComboBox1.Items.Add(dtrperpus("kelompok_buku"))
        End While
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class