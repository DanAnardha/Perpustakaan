Public Class LaporanPengembalian

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CrystalReportViewer1.SelectionFormula = "{TBL_PENGEMBALIAN.TanggalKembali} in date ( '" & DateTimePicker3.Value & "') to date ( '" & DateTimePicker4.Value & "')"
        CrystalReportViewer1.ReportSource = "LaporanPengembalianPeriodik.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.SelectionFormula = "month({TBL_PENGEMBALIAN.TanggalKembali}) = (" & Month(DateTimePicker1.Value) & ") and year({TBL_PENGEMBALIAN.TanggalKembali}) = (" & Year(DateTimePicker1.Value) & ")"
        CrystalReportViewer1.ReportSource = "LaporanPengembalianBulanan.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        CrystalReportViewer1.SelectionFormula = "year({TBL_PENGEMBALIAN.TanggalKembali}) = (" & Year(DateTimePicker2.Value) & ")"
        CrystalReportViewer1.ReportSource = "LaporanPengembalianTahunan.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub LaporanPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CrystalReportViewer1.ReportSource = "GrafikPengembalian.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class