Public Class WelcomePage
    Private Sub enterBtn_Click(sender As Object, e As EventArgs) Handles enterBtn.Click
        Me.Hide()
        MainMenu.Show()
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class