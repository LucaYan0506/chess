Public Class Form2
    Dim a(4) As String
    Public Shared b As String
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'init combobox
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
        'set type of the piece 
        b = ComboBox1.Text
    End Sub

 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class