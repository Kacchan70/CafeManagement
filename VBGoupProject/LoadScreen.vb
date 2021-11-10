Public Class LoadScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.loadbar.Value = loadbar.Value + 1
        If loadbar.Value >= 100 Then
            Timer1.Stop()
            Login.Show()
            Me.Hide()
        End If
    End Sub
End Class