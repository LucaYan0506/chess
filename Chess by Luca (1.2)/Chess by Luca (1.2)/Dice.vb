Public Class Dice
    Dim dado1, dado2, c As Integer
    Dim random As Random
    Dim player1, player2 As String
    Private Sub RollCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RollCmd.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        random = New Random
        ProgressBar1.Increment(5)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            ProgressBar1.Value = 0
            If dado1 > dado2 Then
                MsgBox(player1 & " wins")
                form1.White = player1
                form1.Black = player2
                form1.Player1ToolStripMenuItem.Text = form1.White & " (White)"
                form1.Player2ToolStripMenuItem.Text = form1.Black & " (Black)"
                If form1.Turn = "White" Then
                    form1.Label1.Text = form1.White & " (White) Turn"
                Else
                    form1.Label1.Text = form1.Black & " (Black)Turn"
                End If
                Me.Close()
            ElseIf dado1 < dado2 Then
                MsgBox(player2 & " wins")
                form1.White = player2
                form1.Black = player1
                form1.Player1ToolStripMenuItem.Text = form1.White & " (White)"
                form1.Player2ToolStripMenuItem.Text = form1.Black & " (Black)"
                If form1.Turn = "White" Then
                    form1.Label1.Text = form1.White & " (White) Turn"
                Else
                    form1.Label1.Text = form1.Black & " (Black)Turn"
                End If
                Me.Close()
            ElseIf dado1 < dado2 Then
            Else
                MsgBox("Pareggio")
            End If
        Else
            dado1 = random.Next(1, 6)
            dado2 = random.Next(1, 6)

            Select Case dado1
                Case 1
                    PictureBox1.Image = My.Resources.Dice_1
                Case 2
                    PictureBox1.Image = My.Resources.Dice_2
                Case 3
                    PictureBox1.Image = My.Resources.Dice_3
                Case 4
                    PictureBox1.Image = My.Resources.Dice_4
                Case 5
                    PictureBox1.Image = My.Resources.Dice_5
                Case 6
                    PictureBox1.Image = My.Resources.Dice_6
            End Select
            Select Case dado2
                Case 1
                    PictureBox2.Image = My.Resources.Dice_1
                Case 2
                    PictureBox2.Image = My.Resources.Dice_2
                Case 3
                    PictureBox2.Image = My.Resources.Dice_3
                Case 4
                    PictureBox2.Image = My.Resources.Dice_4
                Case 5
                    PictureBox2.Image = My.Resources.Dice_5
                Case 6
                    PictureBox2.Image = My.Resources.Dice_6
            End Select
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = My.Resources.Dice_6
        PictureBox2.Image = My.Resources.Dice_6
        player1 = InputBox("Who's the first player")
        player2 = InputBox("Who's the second player")
        Label1.Text = player1
        Label2.Text = player2
    End Sub
End Class