Public Class Login
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Enter Username and Password")
        ElseIf UsernameTextBox.Text = "Admin" And PasswordTextBox.Text = "admin1" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong Username Or Password, Please Try Again")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If
    End Sub

    Private Sub CashierLabel_Click(sender As Object, e As EventArgs) Handles CashierLabel.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub CloseBox_Click(sender As Object, e As EventArgs) Handles CloseBox.Click
        Application.Exit()
    End Sub
End Class
