Public Class LaporanPengembalian

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim tgl1 As String
        Dim tgl2 As String

        tgl1 = Format(DateTimePicker1.Value, "yyyy,MM,dd")
        tgl2 = Format(DateTimePicker2.Value, "yyyy,MM,dd")


        With AxCrystalReport1
            .SelectionFormula = "{tb_pengembalian.tgl_transaksi} >= date(" & tgl1 & ") and {tb_pengembalian.tgl_transaksi} <= date (" & tgl2 & ")"
            .ReportFileName = "laporan_pengembalian.rpt"
            .DiscardSavedData = True
            .WindowHeight = 770
            .WindowWidth = 1367
            .WindowTop = 0
            .WindowLeft = 0
            .Action = 1
        End With
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class