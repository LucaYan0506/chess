Public Class form1
    Public Shared White As String = "White"
    Public Shared Black As String = "Black"
    Dim Finish As Boolean
    Dim CurrentPiece As Object
    Dim CurrentPieceLocation As String
    Dim ButtonOnTheLocation(10) As Object
    Dim IndexForButtonOnTheLocation As Integer
    Dim UselessVariable As Object
    Dim LocationForKilledPiece As Object
    Dim FreeLocationForKilledPieceBlack As Integer = 1
    Dim FreeLocationForKilledPieceWHite As Integer = 17
    Public Shared Turn As String
    Dim GameOver As Boolean
    Dim Check As Boolean
    Dim A(8) As String
    Dim B(8) As String
    Dim C(8) As String
    Dim D(8) As String
    Dim E(8) As String
    Dim F(8) As String
    Dim G(8) As String
    Dim H(8) As String
    Dim first As Boolean

    Private Sub Change_image(ByVal t As String, ByVal color As String)
        Select Case t
            Case "Rook"
                If color = "White" Then
                    CurrentPiece.Image = New Bitmap(Application.StartupPath & "\Resources\Rook_White.png")
                Else
                    CurrentPiece.Image = New Bitmap(Application.StartupPath & "\Resources\Rook_Black.png")
                End If
            Case ("Queen")
                If color = "White" Then
                    CurrentPiece.Image = New Bitmap(Application.StartupPath & "\Resources\Queen_White.png")
                Else
                    CurrentPiece.Image = New Bitmap(Application.StartupPath & "\Resources\Queen_Black2.png")
                End If
            Case "Knight"
                If color = "White" Then
                    CurrentPiece.Image = New Bitmap(Application.StartupPath & "\Resources\Knight_White.png")
                Else
                    CurrentPiece.Image = New Bitmap(Application.StartupPath & "\Resources\Knight_Black.png")
                End If
            Case "Bishop"
                If color = "White" Then
                    CurrentPiece.Image = New Bitmap(Application.StartupPath & "\Resources\Bishop_White.png")
                Else
                    CurrentPiece.Image = New Bitmap(Application.StartupPath & "\Resources\Bishop_Black 4.png")
                End If
        End Select
    End Sub

    Private Sub CheckKillablePiece(ByVal Nbutton As Object, ByVal clr As String)
        IndexForButtonOnTheLocation += 1
        CheckCurrentLocationData(Nbutton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
        If Check = True Then
            If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = clr Then
                Check = False
                ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                IndexForButtonOnTheLocation -= 1
            Else
                ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
            End If
        Else
            IndexForButtonOnTheLocation -= 1
        End If
    End Sub

    Private Sub DeleteAllPiecesPosition()
        For i = 1 To 8
            A(i) = Nothing
            B(i) = Nothing
            C(i) = Nothing
            D(i) = Nothing
            E(i) = Nothing
            F(i) = Nothing
            G(i) = Nothing
            H(i) = Nothing
        Next
    End Sub
    Private Sub GetLocation(ByVal int As Integer, ByRef obj As Object)
        Select Case int
            Case 1
                obj = Button1
            Case 2
                obj = Button2
            Case 3
                obj = Button3
            Case 4
                obj = Button4
            Case 5
                obj = Button5
            Case 6
                obj = Button6
            Case 7
                obj = Button7
            Case 8
                obj = Button8
            Case 9
                obj = Button9
            Case 10
                obj = Button10
            Case 11
                obj = Button11
            Case 12
                obj = Button12
            Case 13
                obj = Button13
            Case 14
                obj = Button14
            Case 15
                obj = Button15
            Case 16
                obj = Button16
            Case 17
                obj = Button17
            Case 18
                obj = Button18
            Case 19
                obj = Button19
            Case 20
                obj = Button20
            Case 21
                obj = Button21
            Case 22
                obj = Button22
            Case 23
                obj = Button23
            Case 24
                obj = Button24
            Case 25
                obj = Button25
            Case 26
                obj = Button26
            Case 27
                obj = Button27
            Case 28
                obj = Button28
            Case 29
                obj = Button29
            Case 30
                obj = Button30
            Case 31
                obj = Button31
            Case 32
                obj = Button32

        End Select
    End Sub

    Private Sub GetButton(ByVal check As String, ByRef currentb As Object)
        Select Case check
            Case "RookBlack1"
                currentb = RookBlack1
            Case "RookWhite1"
                currentb = RookWhite1
            Case "KnightBlack1"
                currentb = KnightBlack1
            Case "KnightWhite1"
                currentb = KnightWhite1
            Case "BishopWhite1"
                currentb = BishopWhite1
            Case "BishopBlack1"
                currentb = BishopBlack1
            Case "RookBlack2"
                currentb = RookBlack2
            Case "RookWhite2"
                currentb = RookWhite2
            Case "KnightBlack2"
                currentb = KnightBlack2
            Case "KnightWhite2"
                currentb = KnightWhite2
            Case "BishopWhite2"
                currentb = BishopWhite2
            Case "BishopBlack2"
                currentb = BishopBlack2
            Case "PawnBlack1"
                currentb = PawnBlack1
            Case "PawnWhite1"
                currentb = PawnWhite1
            Case "PawnBlack2"
                currentb = PawnBlack2
            Case "PawnWhite2"
                currentb = PawnWhite2
            Case "PawnBlack3"
                currentb = PawnBlack3
            Case "PawnWhite3"
                currentb = PawnWhite3
            Case "PawnBlack4"
                currentb = PawnBlack4
            Case "PawnWhite4"
                currentb = PawnWhite4
            Case "PawnBlack5"
                currentb = PawnBlack5
            Case "PawnWhite5"
                currentb = PawnWhite5
            Case "PawnBlack6"
                currentb = PawnBlack6
            Case "PawnWhite6"
                currentb = PawnWhite6
            Case "PawnBlack7"
                currentb = PawnBlack7
            Case "PawnWhite7"
                currentb = PawnWhite7
            Case "PawnBlack8"
                currentb = PawnBlack8
            Case "PawnWhite8"
                currentb = PawnWhite8
            Case "KingBlack1"
                currentb = KingBlack1
            Case "QueenBlack1"
                currentb = QueenBlack1
            Case "KingWhite1"
                currentb = KingWhite1
            Case "KingBlack1"
                currentb = KingBlack1
            Case "QueenWhite1"
                currentb = QueenWhite1

        End Select
    End Sub
    Private Sub RelocateAllPieces()
        RookWhite1.PerformClick()
        RookWhite2.PerformClick()
        RookBlack1.PerformClick()
        RookBlack2.PerformClick()
        KnightBlack1.PerformClick()
        KnightBlack2.PerformClick()
        KnightWhite1.PerformClick()
        KnightWhite2.PerformClick()
        BishopBlack1.PerformClick()
        BishopBlack2.PerformClick()
        BishopWhite1.PerformClick()
        BishopWhite2.PerformClick()
        KingBlack1.PerformClick()
        KingWhite1.PerformClick()
        QueenBlack1.PerformClick()
        QueenWhite1.PerformClick()
        PawnBlack1.PerformClick()
        PawnBlack2.PerformClick()
        PawnBlack3.PerformClick()
        PawnBlack4.PerformClick()
        PawnBlack5.PerformClick()
        PawnBlack6.PerformClick()
        PawnBlack7.PerformClick()
        PawnBlack8.PerformClick()
        PawnWhite1.PerformClick()
        PawnWhite2.PerformClick()
        PawnWhite3.PerformClick()
        PawnWhite4.PerformClick()
        PawnWhite5.PerformClick()
        PawnWhite6.PerformClick()
        PawnWhite7.PerformClick()
        PawnWhite8.PerformClick()
    End Sub
    Private Sub CurrentPieceBackGround(ByVal a As Object)
        Select Case a.location
            Case A1.Location, A3.Location, A5.Location, A7.Location, C1.Location, E1.Location, G1.Location, C3.Location, E3.Location, G3.Location, C5.Location, E5.Location, G5.Location, C7.Location, E7.Location, G7.Location, B2.Location, D2.Location, F2.Location, H2.Location, B4.Location, D4.Location, F4.Location, H4.Location, B6.Location, D6.Location, F6.Location, H6.Location, B8.Location, D8.Location, F8.Location, H8.Location
                a.BackgroundImage = Global.Chess_by_Luca__1._2_.My.Resources.Resources.BROWN
            Case A2.Location, C2.Location, E2.Location, G2.Location, A4.Location, C4.Location, E4.Location, G4.Location, A6.Location, C6.Location, E6.Location, G6.Location, A8.Location, C8.Location, E8.Location, G8.Location, B1.Location, D1.Location, F1.Location, H1.Location, B3.Location, D3.Location, F3.Location, H3.Location, B5.Location, D5.Location, F5.Location, H5.Location, B7.Location, D7.Location, F7.Location, H7.Location
                a.BackgroundImage = Global.Chess_by_Luca__1._2_.My.Resources.Resources.LightBrown
        End Select
    End Sub

    Private Sub DisableAllMovement()
        A1.Visible = False
        B1.Visible = False
        C1.Visible = False
        D1.Visible = False
        E1.Visible = False
        F1.Visible = False
        G1.Visible = False
        H1.Visible = False
        A2.Visible = False
        B2.Visible = False
        C2.Visible = False
        D2.Visible = False
        E2.Visible = False
        F2.Visible = False
        G2.Visible = False
        H2.Visible = False
        A3.Visible = False
        B3.Visible = False
        C3.Visible = False
        D3.Visible = False
        E3.Visible = False
        F3.Visible = False
        G3.Visible = False
        H3.Visible = False
        A4.Visible = False
        B4.Visible = False
        C4.Visible = False
        D4.Visible = False
        E4.Visible = False
        F4.Visible = False
        G4.Visible = False
        H4.Visible = False
        A5.Visible = False
        B5.Visible = False
        C5.Visible = False
        D5.Visible = False
        E5.Visible = False
        F5.Visible = False
        G5.Visible = False
        H5.Visible = False
        A6.Visible = False
        B6.Visible = False
        C6.Visible = False
        D6.Visible = False
        E6.Visible = False
        F6.Visible = False
        G6.Visible = False
        H6.Visible = False
        A7.Visible = False
        B7.Visible = False
        C7.Visible = False
        D7.Visible = False
        E7.Visible = False
        F7.Visible = False
        G7.Visible = False
        H7.Visible = False
        A8.Visible = False
        B8.Visible = False
        C8.Visible = False
        D8.Visible = False
        E8.Visible = False
        F8.Visible = False
        G8.Visible = False
        H8.Visible = False

    End Sub

    Private Sub IdentifyCurrentChessType(ByRef T As String)
        Dim a As String
        a = Mid(CurrentPiece.name.ToString, 1, 4)
        If a = "Pawn" Then
            T = "Pawn"
        ElseIf a = "Rook" Then
            T = "Rook"
        ElseIf a = "King" Then
            T = "King"
        End If

        a = Mid(CurrentPiece.name.ToString, 1, 5)
        If a = "Queen" Then
            T = "Queen"
        End If

        a = Mid(CurrentPiece.name.ToString, 1, 6)
        If a = "Knight" Then
            T = "Knight"
        ElseIf a = "Bishop" Then
            T = "Bishop"
        End If

    End Sub

    Private Sub AbleButton(ByVal a As String)
        Select Case a
            Case "A1"
                A1.Visible = True
            Case "A2"
                A2.Visible = True
            Case "A3"
                A3.Visible = True
            Case "A4"
                A4.Visible = True
            Case "A5"
                A5.Visible = True
            Case "A6"
                A6.Visible = True
            Case "A7"
                A7.Visible = True
            Case "A8"
                A8.Visible = True
            Case "B1"
                B1.Visible = True
            Case "C1"
                C1.Visible = True
            Case "D1"
                D1.Visible = True
            Case "E1"
                E1.Visible = True
            Case "F1"
                F1.Visible = True
            Case "G1"
                G1.Visible = True
            Case "H1"
                H1.Visible = True
            Case "B2"
                B2.Visible = True
            Case "C2"
                C2.Visible = True
            Case "D2"
                D2.Visible = True
            Case "E2"
                E2.Visible = True
            Case "F2"
                F2.Visible = True
            Case "G2"
                G2.Visible = True
            Case "H2"
                H2.Visible = True
            Case "B3"
                B3.Visible = True
            Case "C3"
                C3.Visible = True
            Case "D3"
                D3.Visible = True
            Case "E3"
                E3.Visible = True
            Case "F3"
                F3.Visible = True
            Case "G3"
                G3.Visible = True
            Case "H3"
                H3.Visible = True
            Case "B4"
                B4.Visible = True
            Case "C4"
                C4.Visible = True
            Case "D4"
                D4.Visible = True
            Case "E4"
                E4.Visible = True
            Case "F4"
                F4.Visible = True
            Case "G4"
                G4.Visible = True
            Case "H4"
                H4.Visible = True
            Case "B5"
                B5.Visible = True
            Case "C5"
                C5.Visible = True
            Case "D5"
                D5.Visible = True
            Case "E5"
                E5.Visible = True
            Case "F5"
                F5.Visible = True
            Case "G5"
                G5.Visible = True
            Case "H5"
                H5.Visible = True
            Case "B6"
                B6.Visible = True
            Case "C6"
                C6.Visible = True
            Case "D6"
                D6.Visible = True
            Case "E6"
                E6.Visible = True
            Case "F6"
                F6.Visible = True
            Case "G6"
                G6.Visible = True
            Case "H6"
                H6.Visible = True
            Case "B7"
                B7.Visible = True
            Case "C7"
                C7.Visible = True
            Case "D7"
                D7.Visible = True
            Case "E7"
                E7.Visible = True
            Case "F7"
                F7.Visible = True
            Case "G7"
                G7.Visible = True
            Case "H7"
                H7.Visible = True
            Case "B8"
                B8.Visible = True
            Case "C8"
                C8.Visible = True
            Case "D8"
                D8.Visible = True
            Case "E8"
                E8.Visible = True
            Case "F8"
                F8.Visible = True
            Case "G8"
                G8.Visible = True
            Case "H8"
                H8.Visible = True

        End Select
    End Sub

    Private Sub IdentifyCurrentChessLocation(ByVal a As Object)
        Select Case a.location
            Case A1.Location
                CurrentPieceLocation = "A1"
            Case B1.Location
                CurrentPieceLocation = "B1"
            Case C1.Location
                CurrentPieceLocation = "C1"
            Case D1.Location
                CurrentPieceLocation = "D1"
            Case E1.Location
                CurrentPieceLocation = "E1"
            Case F1.Location
                CurrentPieceLocation = "F1"
            Case G1.Location
                CurrentPieceLocation = "G1"
            Case H1.Location
                CurrentPieceLocation = "H1"
            Case A2.Location
                CurrentPieceLocation = "A2"
            Case B2.Location
                CurrentPieceLocation = "B2"
            Case C2.Location
                CurrentPieceLocation = "C2"
            Case D2.Location
                CurrentPieceLocation = "D2"
            Case E2.Location
                CurrentPieceLocation = "E2"
            Case F2.Location
                CurrentPieceLocation = "F2"
            Case G2.Location
                CurrentPieceLocation = "G2"
            Case H2.Location
                CurrentPieceLocation = "H2"
            Case A3.Location
                CurrentPieceLocation = "A3"
            Case B3.Location
                CurrentPieceLocation = "B3"
            Case C3.Location
                CurrentPieceLocation = "C3"
            Case D3.Location
                CurrentPieceLocation = "D3"
            Case E3.Location
                CurrentPieceLocation = "E3"
            Case F3.Location
                CurrentPieceLocation = "F3"
            Case G3.Location
                CurrentPieceLocation = "G3"
            Case H3.Location
                CurrentPieceLocation = "H3"
            Case A4.Location
                CurrentPieceLocation = "A4"
            Case B4.Location
                CurrentPieceLocation = "B4"
            Case C4.Location
                CurrentPieceLocation = "C4"
            Case D4.Location
                CurrentPieceLocation = "D4"
            Case E4.Location
                CurrentPieceLocation = "E4"
            Case F4.Location
                CurrentPieceLocation = "F4"
            Case G4.Location
                CurrentPieceLocation = "G4"
            Case H4.Location
                CurrentPieceLocation = "H4"
            Case A5.Location
                CurrentPieceLocation = "A5"
            Case B5.Location
                CurrentPieceLocation = "B5"
            Case C5.Location
                CurrentPieceLocation = "C5"
            Case D5.Location
                CurrentPieceLocation = "D5"
            Case E5.Location
                CurrentPieceLocation = "E5"
            Case F5.Location
                CurrentPieceLocation = "F5"
            Case G5.Location
                CurrentPieceLocation = "G5"
            Case H5.Location
                CurrentPieceLocation = "H5"
            Case A6.Location
                CurrentPieceLocation = "A6"
            Case B6.Location
                CurrentPieceLocation = "B6"
            Case C6.Location
                CurrentPieceLocation = "C6"
            Case D6.Location
                CurrentPieceLocation = "D6"
            Case E6.Location
                CurrentPieceLocation = "E6"
            Case F6.Location
                CurrentPieceLocation = "F6"
            Case G6.Location
                CurrentPieceLocation = "G6"
            Case H6.Location
                CurrentPieceLocation = "H6"
            Case A7.Location
                CurrentPieceLocation = "A7"
            Case B7.Location
                CurrentPieceLocation = "B7"
            Case C7.Location
                CurrentPieceLocation = "C7"
            Case D7.Location
                CurrentPieceLocation = "D7"
            Case E7.Location
                CurrentPieceLocation = "E7"
            Case F7.Location
                CurrentPieceLocation = "F7"
            Case G7.Location
                CurrentPieceLocation = "G7"
            Case H7.Location
                CurrentPieceLocation = "H7"
            Case A8.Location
                CurrentPieceLocation = "A8"
            Case B8.Location
                CurrentPieceLocation = "B8"
            Case C8.Location
                CurrentPieceLocation = "C8"
            Case D8.Location
                CurrentPieceLocation = "D8"
            Case E8.Location
                CurrentPieceLocation = "E8"
            Case F8.Location
                CurrentPieceLocation = "F8"
            Case G8.Location
                CurrentPieceLocation = "G8"
            Case H8.Location
                CurrentPieceLocation = "H8"
            Case Else
                CurrentPieceLocation = "Out"
        End Select
    End Sub

    Private Sub DeleteCurrentLocationData()
        Select Case CurrentPieceLocation
            Case "A1"
                A(1) = ""
            Case "B1"
                B(1) = ""
            Case "C1"
                C(1) = ""
            Case "D1"
                D(1) = ""
            Case "E1"
                E(1) = ""
            Case "F1"
                F(1) = ""
            Case "G1"
                G(1) = ""
            Case "H1"
                H(1) = ""
            Case "A2"
                A(2) = ""
            Case "B2"
                B(2) = ""
            Case "C2"
                C(2) = ""
            Case "D2"
                D(2) = ""
            Case "E2"
                E(2) = ""
            Case "F2"
                F(2) = ""
            Case "G2"
                G(2) = ""
            Case "H2"
                H(2) = ""
            Case "A3"
                A(3) = ""
            Case "B3"
                B(3) = ""
            Case "C3"
                C(3) = ""
            Case "D3"
                D(3) = ""
            Case "E3"
                E(3) = ""
            Case "F3"
                F(3) = ""
            Case "G3"
                G(3) = ""
            Case "H3"
                H(3) = ""
            Case "A4"
                A(4) = ""
            Case "B4"
                B(4) = ""
            Case "C4"
                C(4) = ""
            Case "D4"
                D(4) = ""
            Case "E4"
                E(4) = ""
            Case "F4"
                F(4) = ""
            Case "G4"
                G(4) = ""
            Case "H4"
                H(4) = ""
            Case "A5"
                A(5) = ""
            Case "B5"
                B(5) = ""
            Case "C5"
                C(5) = ""
            Case "D5"
                D(5) = ""
            Case "E5"
                E(5) = ""
            Case "F5"
                F(5) = ""
            Case "G5"
                G(5) = ""
            Case "H5"
                H(5) = ""
            Case "A6"
                A(6) = ""
            Case "B6"
                B(6) = ""
            Case "C6"
                C(6) = ""
            Case "D6"
                D(6) = ""
            Case "E6"
                E(6) = ""
            Case "F6"
                F(6) = ""
            Case "G6"
                G(6) = ""
            Case "H6"
                H(6) = ""
            Case "A7"
                A(7) = ""
            Case "B7"
                B(7) = ""
            Case "C7"
                C(7) = ""
            Case "D7"
                D(7) = ""
            Case "E7"
                E(7) = ""
            Case "F7"
                F(7) = ""
            Case "G7"
                G(7) = ""
            Case "H7"
                H(7) = ""
            Case "A8"
                A(8) = ""
            Case "B8"
                B(8) = ""
            Case "C8"
                C(8) = ""
            Case "D8"
                D(8) = ""
            Case "E8"
                E(8) = ""
            Case "F8"
                F(8) = ""
            Case "G8"
                G(8) = ""
            Case "H8"
                H(8) = ""

        End Select
    End Sub

    Private Sub InsertCurrentLocationData(ByVal Sender As Object)
        Select Case CurrentPieceLocation
            Case "A1"
                A(1) = Sender.Name.ToString.ToString
            Case "B1"
                B(1) = Sender.Name.ToString.ToString
            Case "C1"
                C(1) = Sender.Name.ToString.ToString
            Case "D1"
                D(1) = Sender.Name.ToString.ToString
            Case "E1"
                E(1) = Sender.Name.ToString.ToString
            Case "F1"
                F(1) = Sender.Name.ToString.ToString
            Case "G1"
                G(1) = Sender.Name.ToString.ToString
            Case "H1"
                H(1) = Sender.Name.ToString.ToString
            Case "A2"
                A(2) = Sender.Name.ToString.ToString
            Case "B2"
                B(2) = Sender.Name.ToString.ToString
            Case "C2"
                C(2) = Sender.Name.ToString.ToString
            Case "D2"
                D(2) = Sender.Name.ToString.ToString
            Case "E2"
                E(2) = Sender.Name.ToString.ToString
            Case "F2"
                F(2) = Sender.Name.ToString.ToString
            Case "G2"
                G(2) = Sender.Name.ToString.ToString
            Case "H2"
                H(2) = Sender.Name.ToString.ToString
            Case "A3"
                A(3) = Sender.Name.ToString.ToString
            Case "B3"
                B(3) = Sender.Name.ToString.ToString
            Case "C3"
                C(3) = Sender.Name.ToString.ToString
            Case "D3"
                D(3) = Sender.Name.ToString.ToString
            Case "E3"
                E(3) = Sender.Name.ToString.ToString
            Case "F3"
                F(3) = Sender.Name.ToString.ToString
            Case "G3"
                G(3) = Sender.Name.ToString.ToString
            Case "H3"
                H(3) = Sender.Name.ToString.ToString
            Case "A4"
                A(4) = Sender.Name.ToString.ToString
            Case "B4"
                B(4) = Sender.Name.ToString.ToString
            Case "C4"
                C(4) = Sender.Name.ToString.ToString
            Case "D4"
                D(4) = Sender.Name.ToString.ToString
            Case "E4"
                E(4) = Sender.Name.ToString.ToString
            Case "F4"
                F(4) = Sender.Name.ToString.ToString
            Case "G4"
                G(4) = Sender.Name.ToString.ToString
            Case "H4"
                H(4) = Sender.Name.ToString.ToString
            Case "A5"
                A(5) = Sender.Name.ToString.ToString
            Case "B5"
                B(5) = Sender.Name.ToString.ToString
            Case "C5"
                C(5) = Sender.Name.ToString.ToString
            Case "D5"
                D(5) = Sender.Name.ToString.ToString
            Case "E5"
                E(5) = Sender.Name.ToString.ToString
            Case "F5"
                F(5) = Sender.Name.ToString.ToString
            Case "G5"
                G(5) = Sender.Name.ToString.ToString
            Case "H5"
                H(5) = Sender.Name.ToString.ToString
            Case "A6"
                A(6) = Sender.Name.ToString.ToString
            Case "B6"
                B(6) = Sender.Name.ToString.ToString
            Case "C6"
                C(6) = Sender.Name.ToString.ToString
            Case "D6"
                D(6) = Sender.Name.ToString.ToString
            Case "E6"
                E(6) = Sender.Name.ToString.ToString
            Case "F6"
                F(6) = Sender.Name.ToString.ToString
            Case "G6"
                G(6) = Sender.Name.ToString.ToString
            Case "H6"
                H(6) = Sender.Name.ToString.ToString
            Case "A7"
                A(7) = Sender.Name.ToString.ToString
            Case "B7"
                B(7) = Sender.Name.ToString.ToString
            Case "C7"
                C(7) = Sender.Name.ToString.ToString
            Case "D7"
                D(7) = Sender.Name.ToString.ToString
            Case "E7"
                E(7) = Sender.Name.ToString.ToString
            Case "F7"
                F(7) = Sender.Name.ToString.ToString
            Case "G7"
                G(7) = Sender.Name.ToString.ToString
            Case "H7"
                H(7) = Sender.Name.ToString.ToString
            Case "A8"
                A(8) = Sender.Name.ToString.ToString
            Case "B8"
                B(8) = Sender.Name.ToString.ToString
            Case "C8"
                C(8) = Sender.Name.ToString.ToString
            Case "D8"
                D(8) = Sender.Name.ToString.ToString
            Case "E8"
                E(8) = Sender.Name.ToString.ToString
            Case "F8"
                F(8) = Sender.Name.ToString.ToString
            Case "G8"
                G(8) = Sender.Name.ToString.ToString
            Case "H8"
                H(8) = Sender.Name.ToString.ToString
            Case "Out"
                Sender.Enabled = False
        End Select
    End Sub

    Private Sub CheckCurrentLocationData(ByVal check As String, ByRef result As Boolean, ByRef CurrentB As Object)
        result = False
        Select Case check
            Case "A1"
                If A(1) <> "" Then
                    result = True
                    GetButton(A(1), CurrentB)
                    Exit Select
                End If
            Case "B1"
                If B(1) <> "" Then
                    result = True
                    GetButton(B(1), CurrentB)
                    Exit Select
                End If
            Case "C1"
                If C(1) <> "" Then
                    result = True
                    GetButton(C(1), CurrentB)
                    Exit Select
                End If
            Case "D1"
                If D(1) <> "" Then
                    result = True
                    GetButton(D(1), CurrentB)
                    Exit Select
                End If
            Case "E1"
                If E(1) <> "" Then
                    result = True
                    GetButton(E(1), CurrentB)
                    Exit Select
                End If
            Case "F1"
                If F(1) <> "" Then
                    result = True
                    GetButton(F(1), CurrentB)
                    Exit Select
                End If
            Case "G1"
                If G(1) <> "" Then
                    result = True
                    GetButton(G(1), CurrentB)
                    Exit Select
                End If
            Case "H1"
                If H(1) <> "" Then
                    result = True
                    GetButton(H(1), CurrentB)
                    Exit Select
                End If
            Case "A2"
                If A(2) <> "" Then
                    result = True
                    GetButton(A(2), CurrentB)
                    Exit Select
                End If
            Case "B2"
                If B(2) <> "" Then
                    result = True
                    GetButton(B(2), CurrentB)
                    Exit Select
                End If
            Case "C2"
                If C(2) <> "" Then
                    result = True
                    GetButton(C(2), CurrentB)
                    Exit Select
                End If
            Case "D2"
                If D(2) <> "" Then
                    result = True
                    GetButton(D(2), CurrentB)
                    Exit Select
                End If
            Case "E2"
                If E(2) <> "" Then
                    result = True
                    GetButton(E(2), CurrentB)
                    Exit Select
                End If
            Case "F2"
                If F(2) <> "" Then
                    result = True
                    GetButton(F(2), CurrentB)
                    Exit Select
                End If
            Case "G2"
                If G(2) <> "" Then
                    result = True
                    GetButton(G(2), CurrentB)
                    Exit Select
                End If
            Case "H2"
                If H(2) <> "" Then
                    result = True
                    GetButton(H(2), CurrentB)
                    Exit Select
                End If
            Case "A3"
                If A(3) <> "" Then
                    result = True
                    GetButton(A(3), CurrentB)
                    Exit Select
                End If
            Case "B3"
                If B(3) <> "" Then
                    result = True
                    GetButton(B(3), CurrentB)
                    Exit Select
                End If
            Case "C3"
                If C(3) <> "" Then
                    result = True
                    GetButton(C(3), CurrentB)
                    Exit Select
                End If
            Case "D3"
                If D(3) <> "" Then
                    result = True
                    GetButton(D(3), CurrentB)
                    Exit Select
                End If
            Case "E3"
                If E(3) <> "" Then
                    result = True
                    GetButton(E(3), CurrentB)
                    Exit Select
                End If
            Case "F3"
                If F(3) <> "" Then
                    result = True
                    GetButton(F(3), CurrentB)
                    Exit Select
                End If
            Case "G3"
                If G(3) <> "" Then
                    result = True
                    GetButton(G(3), CurrentB)
                    Exit Select
                End If
            Case "H3"
                If H(3) <> "" Then
                    result = True
                    GetButton(H(3), CurrentB)
                    Exit Select
                End If
            Case "A4"
                If A(4) <> "" Then
                    result = True
                    GetButton(A(4), CurrentB)
                    Exit Select
                End If
            Case "B4"
                If B(4) <> "" Then
                    result = True
                    GetButton(B(4), CurrentB)
                    Exit Select
                End If
            Case "C4"
                If C(4) <> "" Then
                    result = True
                    GetButton(C(4), CurrentB)
                    Exit Select
                End If
            Case "D4"
                If D(4) <> "" Then
                    result = True
                    GetButton(D(4), CurrentB)
                    Exit Select
                End If
            Case "E4"
                If E(4) <> "" Then
                    result = True
                    GetButton(E(4), CurrentB)
                    Exit Select
                End If
            Case "F4"
                If F(4) <> "" Then
                    result = True
                    GetButton(F(4), CurrentB)
                    Exit Select
                End If
            Case "G4"
                If G(4) <> "" Then
                    result = True
                    GetButton(G(4), CurrentB)
                    Exit Select
                End If
            Case "H4"
                If H(4) <> "" Then
                    result = True
                    GetButton(H(4), CurrentB)
                    Exit Select
                End If
            Case "A5"
                If A(5) <> "" Then
                    result = True
                    GetButton(A(5), CurrentB)
                    Exit Select
                End If
            Case "B5"
                If B(5) <> "" Then
                    result = True
                    GetButton(B(5), CurrentB)
                    Exit Select
                End If
            Case "C5"
                If C(5) <> "" Then
                    result = True
                    GetButton(C(5), CurrentB)
                    Exit Select
                End If
            Case "D5"
                If D(5) <> "" Then
                    result = True
                    GetButton(D(5), CurrentB)
                    Exit Select
                End If
            Case "E5"
                If E(5) <> "" Then
                    result = True
                    GetButton(E(5), CurrentB)
                    Exit Select
                End If
            Case "F5"
                If F(5) <> "" Then
                    result = True
                    GetButton(F(5), CurrentB)
                    Exit Select
                End If
            Case "G5"
                If G(5) <> "" Then
                    result = True
                    GetButton(G(5), CurrentB)
                    Exit Select
                End If
            Case "H5"
                If H(5) <> "" Then
                    result = True
                    GetButton(H(5), CurrentB)
                    Exit Select
                End If
            Case "A6"
                If A(6) <> "" Then
                    result = True
                    GetButton(A(6), CurrentB)
                    Exit Select
                End If
            Case "B6"
                If B(6) <> "" Then
                    result = True
                    GetButton(B(6), CurrentB)
                    Exit Select
                End If
            Case "C6"
                If C(6) <> "" Then
                    result = True
                    GetButton(C(6), CurrentB)
                    Exit Select
                End If
            Case "D6"
                If D(6) <> "" Then
                    result = True
                    GetButton(D(6), CurrentB)
                    Exit Select
                End If
            Case "E6"
                If E(6) <> "" Then
                    result = True
                    GetButton(E(6), CurrentB)
                    Exit Select
                End If
            Case "F6"
                If F(6) <> "" Then
                    result = True
                    GetButton(F(6), CurrentB)
                    Exit Select
                End If
            Case "G6"
                If G(6) <> "" Then
                    result = True
                    GetButton(G(6), CurrentB)
                    Exit Select
                End If
            Case "H6"
                If H(6) <> "" Then
                    result = True
                    GetButton(H(6), CurrentB)
                    Exit Select
                End If
            Case "A7"
                If A(7) <> "" Then
                    result = True
                    GetButton(A(7), CurrentB)
                    Exit Select
                End If
            Case "B7"
                If B(7) <> "" Then
                    result = True
                    GetButton(B(7), CurrentB)
                    Exit Select
                End If
            Case "C7"
                If C(7) <> "" Then
                    result = True
                    GetButton(C(7), CurrentB)
                    Exit Select
                End If
            Case "D7"
                If D(7) <> "" Then
                    result = True
                    GetButton(D(7), CurrentB)
                    Exit Select
                End If
            Case "E7"
                If E(7) <> "" Then
                    result = True
                    GetButton(E(7), CurrentB)
                    Exit Select
                End If
            Case "F7"
                If F(7) <> "" Then
                    result = True
                    GetButton(F(7), CurrentB)
                    Exit Select
                End If
            Case "G7"
                If G(7) <> "" Then
                    result = True
                    GetButton(G(7), CurrentB)
                    Exit Select
                End If
            Case "H7"
                If H(7) <> "" Then
                    result = True
                    GetButton(H(7), CurrentB)
                    Exit Select
                End If
            Case "A8"
                If A(8) <> "" Then
                    result = True
                    GetButton(A(8), CurrentB)
                    Exit Select
                End If
            Case "B8"
                If B(8) <> "" Then
                    result = True
                    GetButton(B(8), CurrentB)
                    Exit Select
                End If
            Case "C8"
                If C(8) <> "" Then
                    result = True
                    GetButton(C(8), CurrentB)
                    Exit Select
                End If
            Case "D8"
                If D(8) <> "" Then
                    result = True
                    GetButton(D(8), CurrentB)
                    Exit Select
                End If
            Case "E8"
                If E(8) <> "" Then
                    result = True
                    GetButton(E(8), CurrentB)
                    Exit Select
                End If
            Case "F8"
                If F(8) <> "" Then
                    result = True
                    GetButton(F(8), CurrentB)
                    Exit Select
                End If
            Case "G8"
                If G(8) <> "" Then
                    result = True
                    GetButton(G(8), CurrentB)
                    Exit Select
                End If
            Case "H8"
                If H(8) <> "" Then
                    result = True
                    GetButton(H(8), CurrentB)
                    Exit Select
                End If

        End Select
    End Sub
    Private Sub AbleLocation(ByVal PType As String, ByVal PColor As String)
        For i = 1 To 10
            ButtonOnTheLocation(i) = Nothing
        Next
        IndexForButtonOnTheLocation = 0
        Dim NextButton, LetterIndex As String
        Dim index As Integer
        Select Case PType
            Case "Pawn"
                If PColor = "Black" Then
                    If CurrentPiece.location.y = A7.Location.Y Then
                        NextButton = Mid(CurrentPieceLocation, 1, 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) - 1
                        CheckCurrentLocationData(NextButton, Check, UselessVariable)
                        If Check = False Then
                            AbleButton(NextButton)
                            NextButton = Mid(CurrentPieceLocation, 1, 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) - 2
                            CheckCurrentLocationData(NextButton, Check, UselessVariable)
                            If Check = False Then
                                AbleButton(NextButton)
                            End If
                        End If
                    Else
                        NextButton = Mid(CurrentPieceLocation, 1, 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) - 1
                        CheckCurrentLocationData(NextButton, Check, UselessVariable)
                        If Check = False Then
                            AbleButton(NextButton)
                        End If
                    End If
                ElseIf PColor = "White" Then
                    If CurrentPiece.location.y = A2.Location.Y Then
                        NextButton = Mid(CurrentPieceLocation, 1, 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) + 1
                        CheckCurrentLocationData(NextButton, Check, UselessVariable)
                        If Check = False Then
                            AbleButton(NextButton)
                            NextButton = Mid(CurrentPieceLocation, 1, 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) + 2
                            CheckCurrentLocationData(NextButton, Check, UselessVariable)
                            If Check = False Then
                                AbleButton(NextButton)
                            End If
                        End If
                    Else
                        NextButton = Mid(CurrentPieceLocation, 1, 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) + 1
                        CheckCurrentLocationData(NextButton, Check, UselessVariable)
                        If Check = False Then
                            AbleButton(NextButton)
                        End If
                    End If
                End If

                If PColor = "Black" Then
                    NextButton = Chr(Asc(Mid(CurrentPieceLocation, 1, 1)) - 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) - 1
                    CheckKillablePiece(NextButton, PColor)
                    NextButton = Chr(Asc(Mid(CurrentPieceLocation, 1, 1)) + 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) - 1
                    CheckKillablePiece(NextButton, PColor)
                ElseIf PColor = "White" Then
                    NextButton = Chr(Asc(Mid(CurrentPieceLocation, 1, 1)) + 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) + 1
                    CheckKillablePiece(NextButton, PColor)
                    NextButton = Chr(Asc(Mid(CurrentPieceLocation, 1, 1)) - 1) & CInt(Mid(CurrentPieceLocation, 2, 1)) + 1
                    CheckKillablePiece(NextButton, PColor)
                End If
            Case "Rook"
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                Do While index < 8
                    index += 1
                    NextButton = Mid(CurrentPieceLocation, 1, 1) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                Do While index > 1
                    index -= 1
                    NextButton = Mid(CurrentPieceLocation, 1, 1) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                Do While LetterIndex < 72
                    LetterIndex += 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop

                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                Do While LetterIndex > 65
                    LetterIndex -= 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop
            Case "King"
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index < 8 Then
                    index += 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index > 1 Then
                    index -= 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If LetterIndex < 72 Then
                    LetterIndex += 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If LetterIndex > 65 Then
                    LetterIndex -= 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If LetterIndex > 65 And index > 1 Then
                    LetterIndex -= 1
                    index -= 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If LetterIndex > 65 And index < 8 Then
                    LetterIndex -= 1
                    index += 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If LetterIndex < 72 And index < 8 Then
                    LetterIndex += 1
                    index += 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If LetterIndex < 72 And index > 1 Then
                    LetterIndex += 1
                    index -= 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If
            Case "Queen"
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                Do While index < 8
                    index += 1
                    NextButton = Mid(CurrentPieceLocation, 1, 1) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                Do While index > 1
                    index -= 1
                    NextButton = Mid(CurrentPieceLocation, 1, 1) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                Do While LetterIndex < 72
                    LetterIndex += 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop

                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                Do While LetterIndex > 65
                    LetterIndex -= 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                Do While index < 72 And index < 8
                    LetterIndex += 1
                    index += 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                Do While index < 72 And index > 1
                    LetterIndex += 1
                    index -= 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                Do While LetterIndex > 65 And index < 8
                    LetterIndex -= 1
                    index += 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                Do While LetterIndex > 65 And index > 1
                    LetterIndex -= 1
                    index -= 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop



            Case "Knight"
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index + 2 < 9 And LetterIndex + 1 < 73 Then
                    index += 2
                    LetterIndex += 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index + 1 < 9 And LetterIndex + 2 < 73 Then
                    index += 1
                    LetterIndex += 2
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index - 2 > 0 And LetterIndex + 1 < 73 Then
                    index -= 2
                    LetterIndex += 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index - 1 > 0 And LetterIndex + 2 < 73 Then
                    index -= 1
                    LetterIndex += 2
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If


                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index - 2 > 0 And LetterIndex - 1 > 64 Then
                    index -= 2
                    LetterIndex -= 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index - 1 > 0 And LetterIndex - 2 > 64 Then
                    index -= 1
                    LetterIndex -= 2
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index + 1 < 9 And LetterIndex - 2 > 64 Then
                    index += 1
                    LetterIndex -= 2
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                If index + 2 < 9 And LetterIndex - 1 > 64 Then
                    index += 2
                    LetterIndex -= 1
                    NextButton = Chr(LetterIndex) & index
                    CheckKillablePiece(NextButton, PColor)
                    AbleButton(NextButton)
                End If
            Case "Bishop"
                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                Do While index < 72 And index < 8
                    LetterIndex += 1
                    index += 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                Do While index < 72 And index > 1
                    LetterIndex += 1
                    index -= 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                Do While LetterIndex > 65 And index < 8
                    LetterIndex -= 1
                    index += 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop

                index = CInt(Mid(CurrentPieceLocation, 2, 1))
                LetterIndex = CInt(Asc(Mid(CurrentPieceLocation, 1, 1)))
                Do While LetterIndex > 65 And index > 1
                    LetterIndex -= 1
                    index -= 1
                    NextButton = Chr(LetterIndex) & index
                    IndexForButtonOnTheLocation += 1
                    CheckCurrentLocationData(NextButton, Check, ButtonOnTheLocation(IndexForButtonOnTheLocation))
                    If Check = True Then
                        If Mid(ButtonOnTheLocation(IndexForButtonOnTheLocation).name, ButtonOnTheLocation(IndexForButtonOnTheLocation).name.Length - 5, 5) = PColor Then
                            Check = False
                            ButtonOnTheLocation(IndexForButtonOnTheLocation) = Nothing
                            IndexForButtonOnTheLocation -= 1
                            Exit Do
                        Else
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackgroundImage = Nothing
                            ButtonOnTheLocation(IndexForButtonOnTheLocation).BackColor = Color.LightSteelBlue
                            Exit Do
                        End If
                    Else
                        IndexForButtonOnTheLocation -= 1
                    End If
                    AbleButton(NextButton)
                Loop
        End Select
    End Sub
    Private Sub Piece_Click(sender As Object, e As EventArgs) Handles RookBlack1.Click, RookBlack2.Click, RookWhite1.Click, RookWhite2.Click, KnightBlack1.Click, KnightBlack2.Click, KnightWhite1.Click, KnightWhite2.Click, BishopBlack1.Click, BishopBlack2.Click, BishopWhite1.Click, BishopWhite2.Click, KingBlack1.Click, KingWhite1.Click, QueenBlack1.Click, QueenWhite1.Click, PawnBlack1.Click, PawnWhite1.Click, PawnBlack2.Click, PawnWhite2.Click, PawnBlack3.Click, PawnWhite3.Click, PawnBlack4.Click, PawnWhite4.Click, PawnBlack5.Click, PawnWhite5.Click, PawnBlack6.Click, PawnWhite6.Click, PawnBlack7.Click, PawnWhite7.Click, PawnBlack8.Click, PawnWhite8.Click
        If GameOver = False Then
            If Finish = False Then
                If Mid(sender.name, sender.name.Length - 5, 5) = Turn Then
                    For i = 1 To 8
                        If ButtonOnTheLocation(i) IsNot Nothing Then
                            CurrentPieceBackGround(ButtonOnTheLocation(i))
                        End If
                    Next
                    DisableAllMovement()
                    Dim CurrentPieceColor As String
                    Dim PieceType As String
                    CurrentPiece = sender
                    CurrentPieceColor = Mid(CurrentPiece.name, CurrentPiece.name.Length - 5, 5)
                    IdentifyCurrentChessType(PieceType)
                    IdentifyCurrentChessLocation(CurrentPiece)
                    InsertCurrentLocationData(CurrentPiece)
                    AbleLocation(PieceType, CurrentPieceColor)
                Else
                    If ButtonOnTheLocation(1) IsNot Nothing Then
                        If ButtonOnTheLocation(1) Is sender Or ButtonOnTheLocation(2) Is sender Or ButtonOnTheLocation(3) Is sender Or ButtonOnTheLocation(4) Is sender Or ButtonOnTheLocation(5) Is sender Or ButtonOnTheLocation(6) Is sender Or ButtonOnTheLocation(7) Is sender Or ButtonOnTheLocation(8) Is sender Or ButtonOnTheLocation(9) Is sender Or ButtonOnTheLocation(10) Is sender Then
                            IdentifyCurrentChessLocation(CurrentPiece)
                            DisableAllMovement()
                            DeleteCurrentLocationData()
                            CurrentPiece.location = sender.location
                            If Mid(sender.name, sender.name.Length - 5, 5) = "White" Then
                                GetLocation(FreeLocationForKilledPieceWHite, LocationForKilledPiece)
                                FreeLocationForKilledPieceWHite += 1
                            Else
                                GetLocation(FreeLocationForKilledPieceBlack, LocationForKilledPiece)
                                FreeLocationForKilledPieceBlack += 1
                            End If
                            sender.location = LocationForKilledPiece.location
                            IdentifyCurrentChessLocation(CurrentPiece)
                            CurrentPieceBackGround(CurrentPiece)
                            InsertCurrentLocationData(CurrentPiece)
                            IdentifyCurrentChessLocation(sender)
                            CurrentPieceBackGround(sender)
                            InsertCurrentLocationData(sender)
                            For i = 1 To 8
                                If ButtonOnTheLocation(i) IsNot Nothing Then
                                    CurrentPieceBackGround(ButtonOnTheLocation(i))
                                    ButtonOnTheLocation(i) = Nothing
                                End If
                            Next


                            'check if it's pawn and it need to trasform
                            Dim type As String
                            IdentifyCurrentChessType(type)
                            If type = "Pawn" Then
                                IdentifyCurrentChessLocation(CurrentPiece)
                                If Mid(CurrentPieceLocation, 2, 1) = "8" Or Mid(CurrentPieceLocation, 2, 1) = "1" Then
                                    Dim a As New Form2
                                    'call choose form
                                    a.ShowDialog()
                                    'transform the type of the piece
                                    Dim l As Integer = Form2.b.Length + 1
                                    CurrentPiece.name = Form2.b & Mid(CurrentPiece.Name, l, CurrentPiece.Name.Length - l) & "1"
                                    Change_image(Form2.b, Mid(CurrentPiece.name, CurrentPiece.name.Length - 5, 5))
                                End If
                            End If


                            CurrentPiece = Nothing
                            If Turn = "White" Then
                                Turn = "Black"
                            Else
                                Turn = "White"
                            End If
                            If Turn = "White" Then
                                Label1.Text = White & " (White) Turn"
                            Else
                                Label1.Text = Black & " (Black)Turn"
                            End If

                        End If
                    Else
                        If first = False Then
                            MsgBox("It isn't your turn")
                        End If
                    End If


                    End If
                    If first = True Then
                        DisableAllMovement()
                        Dim CurrentPieceColor As String
                        Dim PieceType As String
                        CurrentPiece = sender
                        CurrentPieceColor = Mid(CurrentPiece.name, CurrentPiece.name.Length - 5, 5)
                        IdentifyCurrentChessType(PieceType)
                        IdentifyCurrentChessLocation(CurrentPiece)
                        InsertCurrentLocationData(CurrentPiece)
                    End If
                    IdentifyCurrentChessLocation(KingBlack1)
                    InsertCurrentLocationData(KingBlack1)
            End If
        Else
            MsgBox("The game is over, pls start a new game")
        End If
    End Sub

    Private Sub Move_Click(sender As Object, e As EventArgs) Handles A1.Click, A2.Click, A3.Click, A4.Click, A5.Click, A1.Click, A6.Click, A7.Click, A8.Click, B1.Click, B2.Click, B3.Click, B4.Click, B5.Click, B1.Click, B6.Click, B7.Click, B8.Click, C1.Click, C2.Click, C3.Click, C4.Click, C5.Click, C6.Click, C7.Click, C8.Click, D1.Click, D2.Click, D3.Click, D4.Click, D5.Click, D6.Click, D7.Click, D8.Click, E1.Click, E2.Click, E3.Click, E4.Click, E5.Click, E6.Click, E7.Click, E8.Click, F1.Click, F2.Click, F3.Click, F4.Click, F5.Click, F6.Click, F7.Click, F8.Click, G1.Click, G2.Click, G3.Click, G4.Click, G5.Click, G6.Click, G7.Click, G8.Click, H1.Click, H2.Click, H3.Click, H4.Click, H5.Click, H6.Click, H7.Click, H8.Click
        IdentifyCurrentChessLocation(CurrentPiece)
        DisableAllMovement()
        DeleteCurrentLocationData()
        CurrentPiece.location = sender.location
        IdentifyCurrentChessLocation(CurrentPiece)
        CurrentPieceBackGround(CurrentPiece)
        InsertCurrentLocationData(CurrentPiece)
        For i = 1 To 8
            If ButtonOnTheLocation(i) IsNot Nothing Then
                CurrentPieceBackGround(ButtonOnTheLocation(i))
                ButtonOnTheLocation(i) = Nothing
            End If
        Next
        CurrentPiece = Nothing
        If Turn = "White" Then
            Turn = "Black"
        Else
            Turn = "White"
        End If
        If Turn = "White" Then
            Label1.Text = White & " (White) Turn"
        Else
            Label1.Text = Black & " (Black) Turn"
        End If

    End Sub

    Private Sub KingKIlled(sender As Object, e As EventArgs) Handles KingBlack1.Click, KingWhite1.Click
        For i = 1 To 32
            GetLocation(i, LocationForKilledPiece)
            If sender.location = LocationForKilledPiece.location Then
                If i <= 16 Then
                    MsgBox(White & " wins")
                    GameOver = True
                    Point1Lbl.Text += 1
                Else
                    MsgBox(Black & " wins")
                    GameOver = True
                    Point2Lbl.Text += 1
                End If
            End If
        Next
    End Sub
    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        first = True
        RelocateAllPieces()
        CurrentPiece = Nothing
        first = False
        Turn = "White"
        If Turn = "White" Then
            Label1.Text = White & " (White) Turn"
        Else
            Label1.Text = Black & " (Black) Turn"
        End If

        DisableAllMovement()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        GameOver = False

        Finish = False
        RookWhite1.Location = A1.Location
        CurrentPieceBackGround(RookWhite1)
        RookWhite1.Enabled = True

        KnightWhite1.Location = B1.Location
        CurrentPieceBackGround(KnightWhite1)
        KnightWhite1.Enabled = True

        BishopWhite1.Location = C1.Location
        CurrentPieceBackGround(BishopWhite1)
        BishopWhite1.Enabled = True

        KingWhite1.Location = D1.Location
        CurrentPieceBackGround(KingWhite1)
        KingWhite1.Enabled = True

        QueenWhite1.Location = E1.Location
        CurrentPieceBackGround(QueenWhite1)
        QueenWhite1.Enabled = True

        BishopWhite2.Location = F1.Location
        CurrentPieceBackGround(BishopWhite2)
        BishopWhite2.Enabled = True

        KnightWhite2.Location = G1.Location
        CurrentPieceBackGround(KnightWhite2)
        KnightWhite2.Enabled = True

        RookWhite2.Location = H1.Location
        CurrentPieceBackGround(RookWhite2)
        RookWhite2.Enabled = True

        PawnWhite1.Location = A2.Location
        CurrentPieceBackGround(PawnWhite1)
        PawnWhite1.Enabled = True
        PawnWhite2.Location = B2.Location
        CurrentPieceBackGround(PawnWhite2)
        PawnWhite2.Enabled = True
        PawnWhite3.Location = C2.Location
        CurrentPieceBackGround(PawnWhite3)
        PawnWhite3.Enabled = True
        PawnWhite4.Location = D2.Location
        CurrentPieceBackGround(PawnWhite4)
        PawnWhite4.Enabled = True
        PawnWhite5.Location = E2.Location
        CurrentPieceBackGround(PawnWhite5)
        PawnWhite5.Enabled = True
        PawnWhite6.Location = F2.Location
        CurrentPieceBackGround(PawnWhite6)
        PawnWhite6.Enabled = True
        PawnWhite7.Location = G2.Location
        CurrentPieceBackGround(PawnWhite7)
        PawnWhite7.Enabled = True
        PawnWhite8.Location = H2.Location
        CurrentPieceBackGround(PawnWhite8)
        PawnWhite8.Enabled = True

        PawnBlack1.Location = A7.Location
        CurrentPieceBackGround(PawnBlack1)
        PawnBlack1.Enabled = True
        PawnBlack2.Location = B7.Location
        CurrentPieceBackGround(PawnBlack2)
        PawnBlack2.Enabled = True
        PawnBlack3.Location = C7.Location
        CurrentPieceBackGround(PawnBlack3)
        PawnBlack3.Enabled = True
        PawnBlack4.Location = D7.Location
        CurrentPieceBackGround(PawnBlack4)
        PawnBlack4.Enabled = True
        PawnBlack5.Location = E7.Location
        CurrentPieceBackGround(PawnBlack5)
        PawnBlack5.Enabled = True
        PawnBlack6.Location = F7.Location
        CurrentPieceBackGround(PawnBlack6)
        PawnBlack6.Enabled = True
        PawnBlack7.Location = G7.Location
        CurrentPieceBackGround(PawnBlack7)
        PawnBlack7.Enabled = True
        PawnBlack8.Location = H7.Location
        CurrentPieceBackGround(PawnBlack8)
        PawnBlack8.Enabled = True


        RookBlack1.Location = A8.Location
        CurrentPieceBackGround(RookBlack1)
        RookBlack1.Enabled = True

        KnightBlack1.Location = B8.Location
        CurrentPieceBackGround(KnightBlack1)
        KnightBlack1.Enabled = True

        BishopBlack1.Location = C8.Location
        CurrentPieceBackGround(BishopBlack1)
        BishopBlack1.Enabled = True

        KingBlack1.Location = D8.Location
        CurrentPieceBackGround(KingBlack1)
        KingBlack1.Enabled = True

        QueenBlack1.Location = E8.Location
        CurrentPieceBackGround(QueenBlack1)
        QueenBlack1.Enabled = True

        BishopBlack2.Location = F8.Location
        CurrentPieceBackGround(BishopBlack2)
        BishopBlack2.Enabled = True

        KnightBlack2.Location = G8.Location
        CurrentPieceBackGround(KnightBlack2)
        KnightBlack2.Enabled = True

        RookBlack2.Location = H8.Location
        CurrentPieceBackGround(RookBlack2)
        RookBlack2.Enabled = True

        DeleteAllPiecesPosition()
        first = True
        RelocateAllPieces()
        CurrentPiece = Nothing
        first = False
        DisableAllMovement()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox("Made By Luca Yan", MsgBoxStyle.Information, "Info")
    End Sub

    Private Sub RegolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegolaToolStripMenuItem.Click
        Dim MessageWithUrl As New MsgboxWithUrl
        MessageWithUrl.ShowDialog()
    End Sub

    Private Sub Player1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Player1ToolStripMenuItem.Click
        White = InputBox("Insert the name of the first player")
        Player1ToolStripMenuItem.Text = White & " (White)"
        If Turn = "White" Then
            Label1.Text = White & " (White) Turn"
        Else
            Label1.Text = Black & " (Black) Turn"
        End If
        WhiteLbl.Text = White
    End Sub

    Private Sub Player2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Player2ToolStripMenuItem.Click
        Black = InputBox("Insert the name of the first player")
        Player1ToolStripMenuItem.Text = Black & " (Black)"
        If Turn = "White" Then
            Label1.Text = White & " (White) Turn"
        Else
            Label1.Text = Black & " (Black) Turn"
        End If
        BlackLbl.Text = Black
    End Sub

    Private Sub DatoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatoToolStripMenuItem.Click
        Dim dice As New Dice
        dice.ShowDialog()
    End Sub

    Private Sub ChangePiceType(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A8.Click, B8.Click, C8.Click, D8.Click, E8.Click, F8.Click, G8.Click, H8.Click, A1.Click, B1.Click, C1.Click, D1.Click, E1.Click, F1.Click, G1.Click, H1.Click
        Dim type As String
        IdentifyCurrentChessType(type)

        'check if the piece is pawn
        If type = "Pawn" Then
            Dim a As New Form2
            a.ShowDialog()
            'transform the type of the piece
            Dim l As Integer = Form2.b.Length + 1
            CurrentPiece.name = Form2.b & Mid(CurrentPiece.Name, l, CurrentPiece.Name.Length - l) & "1"
            Change_image(Form2.b, Mid(CurrentPiece.name, CurrentPiece.name.Length - 5, 5))
        End If
    End Sub
End Class