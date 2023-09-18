Public Class LaporanPeminjaman

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tgl1 As String
        Dim tgl2 As String

        tgl1 = Format(DateTimePicker1.Value, "yyyy,MM,dd")
        tgl2 = Format(DateTimePicker2.Value, "yyyy,MM,dd")


        With AxCrystalReport1
            .SelectionFormula = "{tb_peminjaman.tgl_pinjam} >= date(" & tgl1 & ") and {tb_peminjaman.tgl_pinjam} <= date (" & tgl2 & ")"
            .ReportFileName = "laporan_peminjaman.rpt"
            .Action = 0
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub LaporanPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class