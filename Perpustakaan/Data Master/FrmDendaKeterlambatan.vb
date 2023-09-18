Public Class FrmDendaKeterlambatan
    Dim nominaldenda, hari As Integer
    Private Sub ButtonX5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub
    Public Sub tampil_denda()
        cmdperpus = New OleDb.OleDbCommand _
            ("select * from denda", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            While dtrperpus.Read
                nominaldenda = dtrperpus("nominal")
            End While
            Label3.Text = "Rp " & Format(nominaldenda, "##,##0") & "/H"
        End If
    End Sub
    Public Sub tampil_keterlambatan()
        cmdperpus = New OleDb.OleDbCommand _
          ("select * from keterlambatan", conperpus)
        dtrperpus = cmdperpus.ExecuteReader
        If dtrperpus.HasRows Then
            While dtrperpus.Read
                hari = dtrperpus("hari")
            End While
            Label4.Text = Format(hari) & " Hari"
        End If
    End Sub

    Private Sub FrmDendaKeterlambatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil_denda()
        tampil_keterlambatan()
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        If Trim(txtnominal.Text) = "" Then
            ErrorProvider1.SetError(txtnominal, "Nominal kosong")
        Else
            cmdperpus = New OleDb.OleDbCommand _
            ("update denda set nominal='" & txtnominal.Text & "'", conperpus)
            cmdperpus.ExecuteNonQuery()
            MsgBox("Data denda telah diupdate", MsgBoxStyle.Information, "update")
            txtnominal.Clear()
            tampil_denda()
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If Trim(txtketerlambatan.Text) = "" Then
            ErrorProvider1.SetError(txtketerlambatan, "Hari Kosong")
        Else
            cmdperpus = New OleDb.OleDbCommand _
            ("update keterlambatan set hari='" & txtketerlambatan.Text & "'", conperpus)
            cmdperpus.ExecuteNonQuery()
            MsgBox("Data keterlambatan telah diupdate", MsgBoxStyle.Information, "update")
            txtketerlambatan.Clear()
            tampil_keterlambatan()
        End If
    End Sub

    Private Sub txtnominal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnominal.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub txtketerlambatan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtketerlambatan.TextChanged
        ErrorProvider1.Clear()
    End Sub

    Private Sub PanelEx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanelEx1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class