Public Class LaporanPeminjaman
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CrystalReportViewer1.SelectionFormula = "{TBL_PEMINJAMAN.TanggalPinjam} in date ( '" & DateTimePicker3.Value & "') to date ( '" & DateTimePicker4.Value & "')"
        CrystalReportViewer1.ReportSource = "LaporanPeminjamanPeriodik.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.SelectionFormula = "month({TBL_PEMINJAMAN.TanggalPinjam}) = (" & Month(DateTimePicker1.Value) & ") and year({TBL_PEMINJAMAN.TanggalPinjam}) = (" & Year(DateTimePicker1.Value) & ")"
        CrystalReportViewer1.ReportSource = "LaporanPeminjamanBulanan.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CrystalReportViewer1.ReportSource = "GrafikPeminjaman.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub LaporanPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CrystalReportViewer1.SelectionFormula = "year({TBL_PEMINJAMAN.TanggalPinjam}) = (" & Year(DateTimePicker2.Value) & ")"
        CrystalReportViewer1.ReportSource = "LaporanPeminjamanTahunan.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class