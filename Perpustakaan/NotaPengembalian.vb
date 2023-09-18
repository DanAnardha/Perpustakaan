Public Class NotaPengembalian

    Private Sub NotaPengembalian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        CrystalReportViewer1.SelectionFormula = "Totext ({TBL_PENGEMBALIAN.NoKembali})='" & FormTransaksiPengembalian.LBLNoPengembalian.Text & "'"
        CrystalReportViewer1.ReportSource = "NotaPengembalian.rpt"
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class