Public Class Form2
    Dim a(4) As String
    Dim b As String
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        a(1) = "Queen"
        a(2) = "Rook"
        a(3) = "Knight"
        a(4) = "Bishop"
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        For i = 1 To 4
            ComboBox1.Items.Add(a(i))
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Queen" Then
            b = "P=Queen"
        End If
        If ComboBox1.SelectedItem = "Rook" Then
            b = "P=Rook"
        End If
        If ComboBox1.SelectedItem = "Knight" Then
            b = "P=Knight"
        End If
        If ComboBox1.SelectedItem = "Bishop" Then
            b = "P=Bishop"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = b
        Select Case Form1.q
            Case 1
                If b = "P=Queen" And Form1.q = 1 Then
                    Form1.PBlack(Form1.q) = "P=Queen"
                    Form1.PawnBlack1.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Rook" And Form1.q = 1 Then
                    Form1.PBlack(Form1.q) = "P=Rook"
                    Form1.PawnBlack1.Image = Global.WindowsApplication1.My.Resources.Rook_removeback
                    Me.Hide()
                ElseIf b = "P=Knight" And Form1.q = 1 Then
                    Form1.PBlack(Form1.q) = "P=Knight"
                    Form1.PawnBlack1.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Bishop" And Form1.q = 1 Then
                    Form1.PBlack(Form1.q) = "P=Bishop"
                    Form1.PawnBlack1.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                Else
                    MsgBox("Please, select one of them")
                End If

            Case 2
                If b = "P=Queen" And Form1.q = 2 Then
                    Form1.PBlack(Form1.q) = "P=Queen2"
                    Form1.PawnBlack2.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Rook" And Form1.q = 2 Then
                    Form1.PBlack(Form1.q) = "P=Rook2"
                    Form1.PawnBlack2.Image = Global.WindowsApplication1.My.Resources.Rook_removeback
                    Me.Hide()
                ElseIf b = "P=Knight" And Form1.q = 2 Then
                    Form1.PBlack(Form1.q) = "P=Knight2"
                    Form1.PawnBlack2.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Bishop" And Form1.q = 2 Then
                    Form1.PBlack(Form1.q) = "P=Bishop2"
                    Form1.PawnBlack2.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                Else
                    MsgBox("Please, select one of them")
                End If
            Case 3
                If b = "P=Queen" And Form1.q = 3 Then
                    Form1.PBlack(Form1.q) = "P=Queen3"
                    Form1.PawnBlack3.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Rook" And Form1.q = 3 Then
                    Form1.PBlack(Form1.q) = "P=Rook3"
                    Form1.PawnBlack3.Image = Global.WindowsApplication1.My.Resources.Rook_removeback
                    Me.Hide()
                ElseIf b = "P=Knight" And Form1.q = 3 Then
                    Form1.PBlack(Form1.q) = "P=Knight3"
                    Form1.PawnBlack3.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Bishop" And Form1.q = 3 Then
                    Form1.PBlack(Form1.q) = "P=Bishop3"
                    Form1.PawnBlack3.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                Else
                    MsgBox("Please, select one of them")
                End If
            Case 4
                If b = "P=Queen" And Form1.q = 4 Then
                    Form1.PBlack(Form1.q) = "P=Queen4"
                    Form1.PawnBlack4.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Rook" And Form1.q = 4 Then
                    Form1.PBlack(Form1.q) = "P=Rook4"
                    Form1.PawnBlack4.Image = Global.WindowsApplication1.My.Resources.Rook_removeback
                    Me.Hide()
                ElseIf b = "P=Knight" And Form1.q = 4 Then
                    Form1.PBlack(Form1.q) = "P=Knight4"
                    Form1.PawnBlack4.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Bishop" And Form1.q = 4 Then
                    Form1.PBlack(Form1.q) = "P=Bishop4"
                    Form1.PawnBlack4.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                Else
                    MsgBox("Please, select one of them")
                End If
            Case 5
                If b = "P=Queen" And Form1.q = 5 Then
                    Form1.PBlack(Form1.q) = "P=Queen5"
                    Form1.PawnBlack5.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Rook" And Form1.q = 5 Then
                    Form1.PBlack(Form1.q) = "P=Rook5"
                    Form1.PawnBlack5.Image = Global.WindowsApplication1.My.Resources.Rook_removeback
                    Me.Hide()
                ElseIf b = "P=Knight" And Form1.q = 5 Then
                    Form1.PBlack(Form1.q) = "P=Knight5"
                    Form1.PawnBlack5.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Bishop" And Form1.q = 5 Then
                    Form1.PBlack(Form1.q) = "P=Bishop5"
                    Form1.PawnBlack5.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                Else
                    MsgBox("Please, select one of them")
                End If
            Case 6
                If b = "P=Queen" And Form1.q = 6 Then
                    Form1.PBlack(Form1.q) = "P=Queen6"
                    Form1.PawnBlack6.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Rook" And Form1.q = 6 Then
                    Form1.PBlack(Form1.q) = "P=Rook6"
                    Form1.PawnBlack6.Image = Global.WindowsApplication1.My.Resources.Rook_removeback
                    Me.Hide()
                ElseIf b = "P=Knight" And Form1.q = 6 Then
                    Form1.PBlack(Form1.q) = "P=Knight6"
                    Form1.PawnBlack6.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Bishop" And Form1.q = 6 Then
                    Form1.PBlack(Form1.q) = "P=Bishop6"
                    Form1.PawnBlack6.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                Else
                    MsgBox("Please, select one of them")
                End If
            Case 7
                If b = "P=Queen" And Form1.q = 7 Then
                    Form1.PBlack(Form1.q) = "P=Queen7"
                    Form1.PawnBlack7.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Rook" And Form1.q = 7 Then
                    Form1.PBlack(Form1.q) = "P=Rook7"
                    Form1.PawnBlack7.Image = Global.WindowsApplication1.My.Resources.Rook_removeback
                    Me.Hide()
                ElseIf b = "P=Knight" And Form1.q = 7 Then
                    Form1.PBlack(Form1.q) = "P=Knight7"
                    Form1.PawnBlack7.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Bishop" And Form1.q = 7 Then
                    Form1.PBlack(Form1.q) = "P=Bishop7"
                    Form1.PawnBlack7.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                Else
                    MsgBox("Please, select one of them")
                End If
            Case 8
                If b = "P=Queen" And Form1.q = 8 Then
                    Form1.PBlack(Form1.q) = "P=Queen8"
                    Form1.PawnBlack8.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Rook" And Form1.q = 8 Then
                    Form1.PBlack(Form1.q) = "P=Rook8"
                    Form1.PawnBlack8.Image = Global.WindowsApplication1.My.Resources.Rook_removeback
                    Me.Hide()
                ElseIf b = "P=Knight" And Form1.q = 8 Then
                    Form1.PBlack(Form1.q) = "P=Knight8"
                    Form1.PawnBlack8.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                ElseIf b = "P=Bishop" And Form1.q = 8 Then
                    Form1.PBlack(Form1.q) = "P=Bishop8"
                    Form1.PawnBlack8.Image = Global.WindowsApplication1.My.Resources.Chess_table
                    Me.Hide()
                Else
                    MsgBox("Please, select one of them")
                End If
        End Select
    End Sub
End Class