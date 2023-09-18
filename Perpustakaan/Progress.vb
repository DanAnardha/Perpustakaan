Public Class Progress
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 1
            If ProgressBar1.Value = 100 Then
                Timer1.Stop()
                Me.Visible = False
                FormLogin.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Progress_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class