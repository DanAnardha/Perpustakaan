Public Class NotaPeminjaman

    Private Sub NotaPeminjaman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        CrystalReportViewer1.SelectionFormula = "Totext ({TBL_PEMINJAMAN.NoPinjam})='" & FormTransaksiPeminjaman.LBLNoPinjam.Text & "'"
        CrystalReportViewer1.ReportSource = "NotaPeminjaman.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class