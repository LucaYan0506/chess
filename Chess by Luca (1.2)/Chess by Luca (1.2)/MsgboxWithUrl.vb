Public Class MsgboxWithUrl
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start("chrome.exe", "https://en.wikipedia.org/wiki/Rules_of_chess")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Dim dice As New Dice
        dice.ShowDialog()
    End Sub

End Class