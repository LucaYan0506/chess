Public Class Form1
    '0 = False
    '1 = True
    Dim ChessPiece, Check, ChessPiece2, Check2, ChessPiece3 As String
    Dim t, l, c, o, m, u, p, f, k, n, o2, m2, n2, u2, nu As Integer
    Dim b(8) As Integer
    Dim PositionA(20) As String
    Dim PositionB(20) As String
    Dim PositionC(20) As String
    Dim PositionD(20) As String
    Dim PositionE(20) As String
    Dim PositionF(20) As String
    Dim PositionG(20) As String
    Dim PositionH(20) As String
    Dim buttonA(20) As Integer
    Dim buttonB(20) As Integer
    Dim buttonC(20) As Integer
    Dim buttonD(20) As Integer
    Dim buttonE(20) As Integer
    Dim buttonF(20) As Integer
    Dim buttonG(20) As Integer
    Dim buttonH(20) As Integer
    Dim PositionTop(20) As Integer
    Dim PositionLeft(20) As Integer
    Dim PositionTop2(20) As Integer
    Dim PositionLeft2(20) As Integer
    Dim KillA(20) As String
    Dim KillB(20) As String
    Dim KillC(20) As String
    Dim KillD(20) As String
    Dim KillE(20) As String
    Dim KillF(20) As String
    Dim KillG(20) As String
    Dim KillH(20) As String
    Public PBlack(8) As String
    Public q As Integer
    Dim combobox As New Form2
    Dim w, e As Integer
    Dim Brown As Boolean
    Dim LightBrown As Boolean
    Private Sub SetBackGround()
        LightBrown = False
        Brown = False
        Do
            w = e + 1
            e = w + 1
            If PositionA(w) = ChessPiece Then
                LightBrown = True
            End If
            If PositionA(e) = ChessPiece Then
                Brown = True
            End If

            If PositionB(e) = ChessPiece Then
                LightBrown = True
            End If
            If PositionB(w) = ChessPiece Then
                Brown = True
            End If

            If PositionC(w) = ChessPiece Then
                LightBrown = True
            End If
            If PositionC(e) = ChessPiece Then
                Brown = True
            End If

            If PositionD(w) = ChessPiece Then
                Brown = True
            End If
            If PositionD(e) = ChessPiece Then
                LightBrown = True
            End If

            If PositionE(w) = ChessPiece Then
                LightBrown = True
            End If
            If PositionE(e) = ChessPiece Then
                Brown = True
            End If

            If PositionF(e) = ChessPiece Then
                LightBrown = True
            End If
            If PositionF(w) = ChessPiece Then
                Brown = True
            End If

            If PositionG(w) = ChessPiece Then
                LightBrown = True
            End If
            If PositionG(e) = ChessPiece Then
                Brown = True
            End If

            If PositionH(w) = ChessPiece Then
                Brown = True
            End If
            If PositionH(e) = ChessPiece Then
                LightBrown = True
            End If
        Loop Until e = 8
        w = 0
        e = 0
        Select Case ChessPiece
            Case "RookBlack1"
                If Brown = True Then
                    Me.RookBlack1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.RookBlack1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "RookBlack2"
                If Brown = True Then
                    Me.RookBlack2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.RookBlack2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "KnightBlack1"
                If Brown = True Then
                    Me.KnightBlack1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.KnightBlack1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "KnightBlack2"
                If Brown = True Then
                    Me.KnightBlack2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.KnightBlack2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "BishopBlack1"
                If Brown = True Then
                    Me.BishopBlack1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.BishopBlack1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "BishopBlack2"
                If Brown = True Then
                    Me.BishopBlack2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.BishopBlack2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "QueenBlack"
                If Brown = True Then
                    Me.QueenBlack.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.QueenBlack.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "KingBlack"
                If Brown = True Then
                    Me.KingBlack.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.KingBlack.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case PBlack(1)
                If Brown = True Then
                    Me.PawnBlack1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnBlack1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case PBlack(2)
                If Brown = True Then
                    Me.PawnBlack2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnBlack2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case PBlack(3)
                If Brown = True Then
                    Me.PawnBlack3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnBlack3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case PBlack(4)
                If Brown = True Then
                    Me.PawnBlack4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnBlack4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case PBlack(5)
                If Brown = True Then
                    Me.PawnBlack5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnBlack5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case PBlack(6)
                If Brown = True Then
                    Me.PawnBlack6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnBlack6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case PBlack(7)
                If Brown = True Then
                    Me.PawnBlack7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnBlack7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case PBlack(8)
                If Brown = True Then
                    Me.PawnBlack8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnBlack8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
        End Select
    End Sub
    Private Sub SetBackGround2()
        LightBrown = False
        Brown = False
        Do
            w = e + 1
            e = w + 1
            If PositionA(w) = ChessPiece3 Then
                LightBrown = True
            End If
            If PositionA(e) = ChessPiece3 Then
                Brown = True
            End If

            If PositionB(e) = ChessPiece3 Then
                LightBrown = True
            End If
            If PositionB(w) = ChessPiece3 Then
                Brown = True
            End If

            If PositionC(w) = ChessPiece3 Then
                LightBrown = True
            End If
            If PositionC(e) = ChessPiece3 Then
                Brown = True
            End If

            If PositionD(w) = ChessPiece3 Then
                Brown = True
            End If
            If PositionD(e) = ChessPiece3 Then
                LightBrown = True
            End If

            If PositionE(w) = ChessPiece3 Then
                LightBrown = True
            End If
            If PositionE(e) = ChessPiece3 Then
                Brown = True
            End If

            If PositionF(e) = ChessPiece3 Then
                LightBrown = True
            End If
            If PositionF(w) = ChessPiece3 Then
                Brown = True
            End If

            If PositionG(w) = ChessPiece3 Then
                LightBrown = True
            End If
            If PositionG(e) = ChessPiece3 Then
                Brown = True
            End If

            If PositionH(w) = ChessPiece3 Then
                Brown = True
            End If
            If PositionH(e) = ChessPiece3 Then
                LightBrown = True
            End If
        Loop Until e = 8
        w = 0
        e = 0
        Select Case ChessPiece3
            Case "RookWhite1"
                If Brown = True Then
                    Me.RookWhite1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.RookWhite1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "RookWhite2"
                If Brown = True Then
                    Me.RookWhite2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.RookWhite2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "KnightWhite1"
                If Brown = True Then
                    Me.KnightWhite1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.KnightWhite1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "KnightWhite2"
                If Brown = True Then
                    Me.KnightWhite2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.KnightWhite2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "BishopWhite1"
                If Brown = True Then
                    Me.BishopWhite1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.BishopWhite1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "BishopWhite2"
                If Brown = True Then
                    Me.BishopWhite2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.BishopWhite2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "QueenWhite"
                If Brown = True Then
                    Me.QueenWhite.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.QueenWhite.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "KingWhite"
                If Brown = True Then
                    Me.KingWhite.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.KingWhite.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "PawnWhite1"
                If Brown = True Then
                    Me.PawnWhite1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnWhite1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "PawnWhite2"
                If Brown = True Then
                    Me.PawnWhite2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnWhite2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "PawnWhite3"
                If Brown = True Then
                    Me.PawnWhite3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnWhite3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "PawnWhite4"
                If Brown = True Then
                    Me.PawnWhite4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnWhite4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "PawnWhite5"
                If Brown = True Then
                    Me.PawnWhite5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnWhite5.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "PawnWhite6"
                If Brown = True Then
                    Me.PawnWhite6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnWhite6.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "PawnWhite7"
                If Brown = True Then
                    Me.PawnWhite7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnWhite7.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
            Case "PawnWhite8"
                If Brown = True Then
                    Me.PawnWhite8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BROWN
                ElseIf LightBrown = True Then
                    Me.PawnWhite8.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.LightBrown
                End If
        End Select
    End Sub
    Private Sub clean()
        For i = 1 To 8
            PositionA(i) = ""
            PositionB(i) = ""
            PositionC(i) = ""
            PositionD(i) = ""
            PositionE(i) = ""
            PositionF(i) = ""
            PositionG(i) = ""
            PositionH(i) = ""
            KillA(i) = ""
            KillB(i) = ""
            KillC(i) = ""
            KillD(i) = ""
            KillE(i) = ""
            KillF(i) = ""
            KillG(i) = ""
            KillH(i) = ""
        Next
    End Sub
    Private Sub PositionTopLeft()
        PositionTop(1) = 30
        PositionTop(2) = 104
        PositionTop(3) = 178
        PositionTop(4) = 252
        PositionTop(5) = 326
        PositionTop(6) = 400
        PositionTop(7) = 474
        PositionTop(8) = 548

        PositionLeft(1) = 12
        PositionLeft(2) = 86
        PositionLeft(3) = 160
        PositionLeft(4) = 234
        PositionLeft(5) = 308
        PositionLeft(6) = 382
        PositionLeft(7) = 456
        PositionLeft(8) = 530

        PositionTop2(1) = 400
        PositionTop2(2) = 400
        PositionTop2(3) = 400
        PositionTop2(4) = 400
        PositionTop2(5) = 400
        PositionTop2(6) = 400
        PositionTop2(7) = 400
        PositionTop2(8) = 474
        PositionTop2(9) = 474
        PositionTop2(10) = 474
        PositionTop2(11) = 474
        PositionTop2(12) = 474
        PositionTop2(13) = 474
        PositionTop2(14) = 474
        PositionTop2(15) = 548
        PositionTop2(16) = 548

        PositionLeft2(1) = 634
        PositionLeft2(2) = 709
        PositionLeft2(3) = 784
        PositionLeft2(4) = 859
        PositionLeft2(5) = 934
        PositionLeft2(6) = 1009
        PositionLeft2(7) = 1084
        PositionLeft2(8) = 634
        PositionLeft2(9) = 709
        PositionLeft2(10) = 784
        PositionLeft2(11) = 859
        PositionLeft2(12) = 934
        PositionLeft2(13) = 1009
        PositionLeft2(14) = 1084
        PositionLeft2(15) = 634
        PositionLeft2(16) = 709



        PBlack(1) = "PawnBlack1"
        PBlack(2) = "PawnBlack2"
        PBlack(3) = "PawnBlack3"
        PBlack(4) = "PawnBlack4"
        PBlack(5) = "PawnBlack5"
        PBlack(6) = "PawnBlack6"
        PBlack(7) = "PawnBlack7"
        PBlack(8) = "PawnBlack8"

    End Sub
    Private Sub PiecesStartPosition()
        PositionA(1) = "RookBlack1"
        PositionA(2) = "KnightBlack1"
        PositionA(3) = "BishopBlack1"
        PositionA(4) = "QueenBlack"
        PositionA(5) = "KingBlack"
        PositionA(6) = "BishopBlack2"
        PositionA(7) = "KnightBlack2"
        PositionA(8) = "RookBlack2"

        PositionB(1) = "PawnBlack1"
        PositionB(2) = "PawnBlack2"
        PositionB(3) = "PawnBlack3"
        PositionB(4) = "PawnBlack4"
        PositionB(5) = "PawnBlack5"
        PositionB(6) = "PawnBlack6"
        PositionB(7) = "PawnBlack7"
        PositionB(8) = "PawnBlack8"
    End Sub
    Private Sub SetBackColor()
        For i = 1 To 8
            If PositionA(i) = "PawnWhite1" And KillA(i) = "True" Then
                Me.PawnWhite1.BackgroundImage = Nothing
                Me.PawnWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "PawnWhite1" And KillA(i) = "" Then
                ChessPiece3 = "PawnWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "PawnWhite1" And KillB(i) = "True" Then
                Me.PawnWhite1.BackgroundImage = Nothing
                Me.PawnWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "PawnWhite1" And KillB(i) = "" Then
                ChessPiece3 = "PawnWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "PawnWhite1" And KillC(i) = "True" Then
                Me.PawnWhite1.BackgroundImage = Nothing
                Me.PawnWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "PawnWhite1" And KillC(i) = "" Then
                ChessPiece3 = "PawnWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "PawnWhite1" And KillD(i) = "True" Then
                Me.PawnWhite1.BackgroundImage = Nothing
                Me.PawnWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "PawnWhite1" And KillD(i) = "" Then
                ChessPiece3 = "PawnWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "PawnWhite1" And KillE(i) = "True" Then
                Me.PawnWhite1.BackgroundImage = Nothing
                Me.PawnWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "PawnWhite1" And KillE(i) = "" Then
                ChessPiece3 = "PawnWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "PawnWhite1" And KillF(i) = "True" Then
                Me.PawnWhite1.BackgroundImage = Nothing
                Me.PawnWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "PawnWhite1" And KillF(i) = "" Then
                ChessPiece3 = "PawnWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "PawnWhite1" And KillG(i) = "True" Then
                Me.PawnWhite1.BackgroundImage = Nothing
                Me.PawnWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "PawnWhite1" And KillG(i) = "" Then
                ChessPiece3 = "PawnWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "PawnWhite1" And KillH(i) = "True" Then
                Me.PawnWhite1.BackgroundImage = Nothing
                Me.PawnWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "PawnWhite1" And KillH(i) = "" Then
                ChessPiece3 = "PawnWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "PawnWhite1" And PositionB(i) <> "PawnWhite1" And PositionC(i) <> "PawnWhite1" And PositionD(i) <> "PawnWhite1" And PositionE(i) <> "PawnWhite1" And PositionF(i) <> "PawnWhite1" And PositionG(i) <> "PawnWhite1" And PositionH(i) <> "PawnWhite1" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.PawnWhite1.BackColor = Nothing
                Me.PawnWhite1.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "PawnWhite2" And KillA(i) = "True" Then
                Me.PawnWhite2.BackgroundImage = Nothing
                Me.PawnWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "PawnWhite2" And KillA(i) = "" Then
                ChessPiece3 = "PawnWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "PawnWhite2" And KillB(i) = "True" Then
                Me.PawnWhite2.BackgroundImage = Nothing
                Me.PawnWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "PawnWhite2" And KillB(i) = "" Then
                ChessPiece3 = "PawnWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "PawnWhite2" And KillC(i) = "True" Then
                Me.PawnWhite2.BackgroundImage = Nothing
                Me.PawnWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "PawnWhite2" And KillC(i) = "" Then
                ChessPiece3 = "PawnWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "PawnWhite2" And KillD(i) = "True" Then
                Me.PawnWhite2.BackgroundImage = Nothing
                Me.PawnWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "PawnWhite2" And KillD(i) = "" Then
                ChessPiece3 = "PawnWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "PawnWhite2" And KillE(i) = "True" Then
                Me.PawnWhite2.BackgroundImage = Nothing
                Me.PawnWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "PawnWhite2" And KillE(i) = "" Then
                ChessPiece3 = "PawnWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "PawnWhite2" And KillF(i) = "True" Then
                Me.PawnWhite2.BackgroundImage = Nothing
                Me.PawnWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "PawnWhite2" And KillF(i) = "" Then
                ChessPiece3 = "PawnWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "PawnWhite2" And KillG(i) = "True" Then
                Me.PawnWhite2.BackgroundImage = Nothing
                Me.PawnWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "PawnWhite2" And KillG(i) = "" Then
                ChessPiece3 = "PawnWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "PawnWhite2" And KillH(i) = "True" Then
                Me.PawnWhite2.BackgroundImage = Nothing
                Me.PawnWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "PawnWhite2" And KillH(i) = "" Then
                ChessPiece3 = "PawnWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "PawnWhite2" And PositionB(i) <> "PawnWhite2" And PositionC(i) <> "PawnWhite2" And PositionD(i) <> "PawnWhite2" And PositionE(i) <> "PawnWhite2" And PositionF(i) <> "PawnWhite2" And PositionG(i) <> "PawnWhite2" And PositionH(i) <> "PawnWhite2" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.PawnWhite2.BackColor = Nothing
                Me.PawnWhite2.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "PawnWhite3" And KillA(i) = "True" Then
                Me.PawnWhite3.BackgroundImage = Nothing
                Me.PawnWhite3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "PawnWhite3" And KillA(i) = "" Then
                ChessPiece3 = "PawnWhite3"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "PawnWhite3" And KillB(i) = "True" Then
                Me.PawnWhite3.BackgroundImage = Nothing
                Me.PawnWhite3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "PawnWhite3" And KillB(i) = "" Then
                ChessPiece3 = "PawnWhite3"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "PawnWhite3" And KillC(i) = "True" Then
                Me.PawnWhite3.BackgroundImage = Nothing
                Me.PawnWhite3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "PawnWhite3" And KillC(i) = "" Then
                ChessPiece3 = "PawnWhite3"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "PawnWhite3" And KillD(i) = "True" Then
                Me.PawnWhite3.BackgroundImage = Nothing
                Me.PawnWhite3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "PawnWhite3" And KillD(i) = "" Then
                ChessPiece3 = "PawnWhite3"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "PawnWhite3" And KillE(i) = "True" Then
                Me.PawnWhite3.BackgroundImage = Nothing
                Me.PawnWhite3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "PawnWhite3" And KillE(i) = "" Then
                ChessPiece3 = "PawnWhite3"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "PawnWhite3" And KillF(i) = "True" Then
                Me.PawnWhite3.BackgroundImage = Nothing
                Me.PawnWhite3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "PawnWhite3" And KillF(i) = "" Then
                ChessPiece3 = "PawnWhite3"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "PawnWhite3" And KillG(i) = "True" Then
                Me.PawnWhite3.BackgroundImage = Nothing
                Me.PawnWhite3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "PawnWhite3" And KillG(i) = "" Then
                ChessPiece3 = "PawnWhite3"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "PawnWhite3" And KillH(i) = "True" Then
                Me.PawnWhite3.BackgroundImage = Nothing
                Me.PawnWhite3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "PawnWhite3" And KillH(i) = "" Then
                ChessPiece3 = "PawnWhite3"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "PawnWhite3" And PositionB(i) <> "PawnWhite3" And PositionC(i) <> "PawnWhite3" And PositionD(i) <> "PawnWhite3" And PositionE(i) <> "PawnWhite3" And PositionF(i) <> "PawnWhite3" And PositionG(i) <> "PawnWhite3" And PositionH(i) <> "PawnWhite3" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.PawnWhite3.BackColor = Nothing
                Me.PawnWhite3.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "PawnWhite4" And KillA(i) = "True" Then
                Me.PawnWhite4.BackgroundImage = Nothing
                Me.PawnWhite4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "PawnWhite4" And KillA(i) = "" Then
                ChessPiece3 = "PawnWhite4"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "PawnWhite4" And KillB(i) = "True" Then
                Me.PawnWhite4.BackgroundImage = Nothing
                Me.PawnWhite4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "PawnWhite4" And KillB(i) = "" Then
                ChessPiece3 = "PawnWhite4"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "PawnWhite4" And KillC(i) = "True" Then
                Me.PawnWhite4.BackgroundImage = Nothing
                Me.PawnWhite4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "PawnWhite4" And KillC(i) = "" Then
                ChessPiece3 = "PawnWhite4"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "PawnWhite4" And KillD(i) = "True" Then
                Me.PawnWhite4.BackgroundImage = Nothing
                Me.PawnWhite4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "PawnWhite4" And KillD(i) = "" Then
                ChessPiece3 = "PawnWhite4"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "PawnWhite4" And KillE(i) = "True" Then
                Me.PawnWhite4.BackgroundImage = Nothing
                Me.PawnWhite4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "PawnWhite4" And KillE(i) = "" Then
                ChessPiece3 = "PawnWhite4"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "PawnWhite4" And KillF(i) = "True" Then
                Me.PawnWhite4.BackgroundImage = Nothing
                Me.PawnWhite4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "PawnWhite4" And KillF(i) = "" Then
                ChessPiece3 = "PawnWhite4"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "PawnWhite4" And KillG(i) = "True" Then
                Me.PawnWhite4.BackgroundImage = Nothing
                Me.PawnWhite4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "PawnWhite4" And KillG(i) = "" Then
                ChessPiece3 = "PawnWhite4"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "PawnWhite4" And KillH(i) = "True" Then
                Me.PawnWhite4.BackgroundImage = Nothing
                Me.PawnWhite4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "PawnWhite4" And KillH(i) = "" Then
                ChessPiece3 = "PawnWhite4"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "PawnWhite4" And PositionB(i) <> "PawnWhite4" And PositionC(i) <> "PawnWhite4" And PositionD(i) <> "PawnWhite4" And PositionE(i) <> "PawnWhite4" And PositionF(i) <> "PawnWhite4" And PositionG(i) <> "PawnWhite4" And PositionH(i) <> "PawnWhite4" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.PawnWhite4.BackColor = Nothing
                Me.PawnWhite4.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "PawnWhite5" And KillA(i) = "True" Then
                Me.PawnWhite5.BackgroundImage = Nothing
                Me.PawnWhite5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "PawnWhite5" And KillA(i) = "" Then
                ChessPiece3 = "PawnWhite5"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "PawnWhite5" And KillB(i) = "True" Then
                Me.PawnWhite5.BackgroundImage = Nothing
                Me.PawnWhite5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "PawnWhite5" And KillB(i) = "" Then
                ChessPiece3 = "PawnWhite5"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "PawnWhite5" And KillC(i) = "True" Then
                Me.PawnWhite5.BackgroundImage = Nothing
                Me.PawnWhite5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "PawnWhite5" And KillC(i) = "" Then
                ChessPiece3 = "PawnWhite5"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "PawnWhite5" And KillD(i) = "True" Then
                Me.PawnWhite5.BackgroundImage = Nothing
                Me.PawnWhite5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "PawnWhite5" And KillD(i) = "" Then
                ChessPiece3 = "PawnWhite5"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "PawnWhite5" And KillE(i) = "True" Then
                Me.PawnWhite5.BackgroundImage = Nothing
                Me.PawnWhite5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "PawnWhite5" And KillE(i) = "" Then
                ChessPiece3 = "PawnWhite5"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "PawnWhite5" And KillF(i) = "True" Then
                Me.PawnWhite5.BackgroundImage = Nothing
                Me.PawnWhite5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "PawnWhite5" And KillF(i) = "" Then
                ChessPiece3 = "PawnWhite5"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "PawnWhite5" And KillG(i) = "True" Then
                Me.PawnWhite5.BackgroundImage = Nothing
                Me.PawnWhite5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "PawnWhite5" And KillG(i) = "" Then
                ChessPiece3 = "PawnWhite5"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "PawnWhite5" And KillH(i) = "True" Then
                Me.PawnWhite5.BackgroundImage = Nothing
                Me.PawnWhite5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "PawnWhite5" And KillH(i) = "" Then
                ChessPiece3 = "PawnWhite5"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "PawnWhite5" And PositionB(i) <> "PawnWhite5" And PositionC(i) <> "PawnWhite5" And PositionD(i) <> "PawnWhite5" And PositionE(i) <> "PawnWhite5" And PositionF(i) <> "PawnWhite5" And PositionG(i) <> "PawnWhite5" And PositionH(i) <> "PawnWhite5" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.PawnWhite5.BackColor = Nothing
                Me.PawnWhite5.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "PawnWhite6" And KillA(i) = "True" Then
                Me.PawnWhite6.BackgroundImage = Nothing
                Me.PawnWhite6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "PawnWhite6" And KillA(i) = "" Then
                ChessPiece3 = "PawnWhite6"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "PawnWhite6" And KillB(i) = "True" Then
                Me.PawnWhite6.BackgroundImage = Nothing
                Me.PawnWhite6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "PawnWhite6" And KillB(i) = "" Then
                ChessPiece3 = "PawnWhite6"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "PawnWhite6" And KillC(i) = "True" Then
                Me.PawnWhite6.BackgroundImage = Nothing
                Me.PawnWhite6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "PawnWhite6" And KillC(i) = "" Then
                ChessPiece3 = "PawnWhite6"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "PawnWhite6" And KillD(i) = "True" Then
                Me.PawnWhite6.BackgroundImage = Nothing
                Me.PawnWhite6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "PawnWhite6" And KillD(i) = "" Then
                ChessPiece3 = "PawnWhite6"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "PawnWhite6" And KillE(i) = "True" Then
                Me.PawnWhite6.BackgroundImage = Nothing
                Me.PawnWhite6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "PawnWhite6" And KillE(i) = "" Then
                ChessPiece3 = "PawnWhite6"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "PawnWhite6" And KillF(i) = "True" Then
                Me.PawnWhite6.BackgroundImage = Nothing
                Me.PawnWhite6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "PawnWhite6" And KillF(i) = "" Then
                ChessPiece3 = "PawnWhite6"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "PawnWhite6" And KillG(i) = "True" Then
                Me.PawnWhite6.BackgroundImage = Nothing
                Me.PawnWhite6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "PawnWhite6" And KillG(i) = "" Then
                ChessPiece3 = "PawnWhite6"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "PawnWhite6" And KillH(i) = "True" Then
                Me.PawnWhite6.BackgroundImage = Nothing
                Me.PawnWhite6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "PawnWhite6" And KillH(i) = "" Then
                ChessPiece3 = "PawnWhite6"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "PawnWhite6" And PositionB(i) <> "PawnWhite6" And PositionC(i) <> "PawnWhite6" And PositionD(i) <> "PawnWhite6" And PositionE(i) <> "PawnWhite6" And PositionF(i) <> "PawnWhite6" And PositionG(i) <> "PawnWhite6" And PositionH(i) <> "PawnWhite6" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.PawnWhite6.BackColor = Nothing
                Me.PawnWhite6.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "PawnWhite7" And KillA(i) = "True" Then
                Me.PawnWhite7.BackgroundImage = Nothing
                Me.PawnWhite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "PawnWhite7" And KillA(i) = "" Then
                ChessPiece3 = "PawnWhite7"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "PawnWhite7" And KillB(i) = "True" Then
                Me.PawnWhite7.BackgroundImage = Nothing
                Me.PawnWhite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "PawnWhite7" And KillB(i) = "" Then
                ChessPiece3 = "PawnWhite7"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "PawnWhite7" And KillC(i) = "True" Then
                Me.PawnWhite7.BackgroundImage = Nothing
                Me.PawnWhite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "PawnWhite7" And KillC(i) = "" Then
                ChessPiece3 = "PawnWhite7"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "PawnWhite7" And KillD(i) = "True" Then
                Me.PawnWhite7.BackgroundImage = Nothing
                Me.PawnWhite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "PawnWhite7" And KillD(i) = "" Then
                ChessPiece3 = "PawnWhite7"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "PawnWhite7" And KillE(i) = "True" Then
                Me.PawnWhite7.BackgroundImage = Nothing
                Me.PawnWhite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "PawnWhite7" And KillE(i) = "" Then
                ChessPiece3 = "PawnWhite7"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "PawnWhite7" And KillF(i) = "True" Then
                Me.PawnWhite7.BackgroundImage = Nothing
                Me.PawnWhite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "PawnWhite7" And KillF(i) = "" Then
                ChessPiece3 = "PawnWhite7"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "PawnWhite7" And KillG(i) = "True" Then
                Me.PawnWhite7.BackgroundImage = Nothing
                Me.PawnWhite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "PawnWhite7" And KillG(i) = "" Then
                ChessPiece3 = "PawnWhite7"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "PawnWhite7" And KillH(i) = "True" Then
                Me.PawnWhite7.BackgroundImage = Nothing
                Me.PawnWhite7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "PawnWhite7" And KillH(i) = "" Then
                ChessPiece3 = "PawnWhite7"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "PawnWhite7" And PositionB(i) <> "PawnWhite7" And PositionC(i) <> "PawnWhite7" And PositionD(i) <> "PawnWhite7" And PositionE(i) <> "PawnWhite7" And PositionF(i) <> "PawnWhite7" And PositionG(i) <> "PawnWhite7" And PositionH(i) <> "PawnWhite7" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.PawnWhite7.BackColor = Nothing
                Me.PawnWhite7.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "PawnWhite8" And KillA(i) = "True" Then
                Me.PawnWhite8.BackgroundImage = Nothing
                Me.PawnWhite8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "PawnWhite8" And KillA(i) = "" Then
                ChessPiece3 = "PawnWhite8"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "PawnWhite8" And KillB(i) = "True" Then
                Me.PawnWhite8.BackgroundImage = Nothing
                Me.PawnWhite8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "PawnWhite8" And KillB(i) = "" Then
                ChessPiece3 = "PawnWhite8"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "PawnWhite8" And KillC(i) = "True" Then
                Me.PawnWhite8.BackgroundImage = Nothing
                Me.PawnWhite8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "PawnWhite8" And KillC(i) = "" Then
                ChessPiece3 = "PawnWhite8"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "PawnWhite8" And KillD(i) = "True" Then
                Me.PawnWhite8.BackgroundImage = Nothing
                Me.PawnWhite8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "PawnWhite8" And KillD(i) = "" Then
                ChessPiece3 = "PawnWhite8"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "PawnWhite8" And KillE(i) = "True" Then
                Me.PawnWhite8.BackgroundImage = Nothing
                Me.PawnWhite8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "PawnWhite8" And KillE(i) = "" Then
                ChessPiece3 = "PawnWhite8"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "PawnWhite8" And KillF(i) = "True" Then
                Me.PawnWhite8.BackgroundImage = Nothing
                Me.PawnWhite8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "PawnWhite8" And KillF(i) = "" Then
                ChessPiece3 = "PawnWhite8"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "PawnWhite8" And KillG(i) = "True" Then
                Me.PawnWhite8.BackgroundImage = Nothing
                Me.PawnWhite8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "PawnWhite8" And KillG(i) = "" Then
                ChessPiece3 = "PawnWhite8"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "PawnWhite8" And KillH(i) = "True" Then
                Me.PawnWhite8.BackgroundImage = Nothing
                Me.PawnWhite8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "PawnWhite8" And KillH(i) = "" Then
                ChessPiece3 = "PawnWhite8"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "PawnWhite8" And PositionB(i) <> "PawnWhite8" And PositionC(i) <> "PawnWhite8" And PositionD(i) <> "PawnWhite8" And PositionE(i) <> "PawnWhite8" And PositionF(i) <> "PawnWhite8" And PositionG(i) <> "PawnWhite8" And PositionH(i) <> "PawnWhite8" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.PawnWhite8.BackColor = Nothing
                Me.PawnWhite8.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "KingWhite" And KillA(i) = "True" Then
                Me.KingWhite.BackgroundImage = Nothing
                Me.KingWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "KingWhite" And KillA(i) = "" Then
                ChessPiece3 = "KingWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "KingWhite" And KillB(i) = "True" Then
                Me.KingWhite.BackgroundImage = Nothing
                Me.KingWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "KingWhite" And KillB(i) = "" Then
                ChessPiece3 = "KingWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "KingWhite" And KillC(i) = "True" Then
                Me.KingWhite.BackgroundImage = Nothing
                Me.KingWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "KingWhite" And KillC(i) = "" Then
                ChessPiece3 = "KingWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "KingWhite" And KillD(i) = "True" Then
                Me.KingWhite.BackgroundImage = Nothing
                Me.KingWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "KingWhite" And KillD(i) = "" Then
                ChessPiece3 = "KingWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "KingWhite" And KillE(i) = "True" Then
                Me.KingWhite.BackgroundImage = Nothing
                Me.KingWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "KingWhite" And KillE(i) = "" Then
                ChessPiece3 = "KingWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "KingWhite" And KillF(i) = "True" Then
                Me.KingWhite.BackgroundImage = Nothing
                Me.KingWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "KingWhite" And KillF(i) = "" Then
                ChessPiece3 = "KingWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "KingWhite" And KillG(i) = "True" Then
                Me.KingWhite.BackgroundImage = Nothing
                Me.KingWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "KingWhite" And KillG(i) = "" Then
                ChessPiece3 = "KingWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "KingWhite" And KillH(i) = "True" Then
                Me.KingWhite.BackgroundImage = Nothing
                Me.KingWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "KingWhite" And KillH(i) = "" Then
                ChessPiece3 = "KingWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "KingWhite" And PositionB(i) <> "KingWhite" And PositionC(i) <> "KingWhite" And PositionD(i) <> "KingWhite" And PositionE(i) <> "KingWhite" And PositionF(i) <> "KingWhite" And PositionG(i) <> "KingWhite" And PositionH(i) <> "KingWhite" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.KingWhite.BackColor = Nothing
                Me.KingWhite.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "QueenWhite" And KillA(i) = "True" Then
                Me.QueenWhite.BackgroundImage = Nothing
                Me.QueenWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "QueenWhite" And KillA(i) = "" Then
                ChessPiece3 = "QueenWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "QueenWhite" And KillB(i) = "True" Then
                Me.QueenWhite.BackgroundImage = Nothing
                Me.QueenWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "QueenWhite" And KillB(i) = "" Then
                ChessPiece3 = "QueenWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "QueenWhite" And KillC(i) = "True" Then
                Me.QueenWhite.BackgroundImage = Nothing
                Me.QueenWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "QueenWhite" And KillC(i) = "" Then
                ChessPiece3 = "QueenWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "QueenWhite" And KillD(i) = "True" Then
                Me.QueenWhite.BackgroundImage = Nothing
                Me.QueenWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "QueenWhite" And KillD(i) = "" Then
                ChessPiece3 = "QueenWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "QueenWhite" And KillE(i) = "True" Then
                Me.QueenWhite.BackgroundImage = Nothing
                Me.QueenWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "QueenWhite" And KillE(i) = "" Then
                ChessPiece3 = "QueenWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "QueenWhite" And KillF(i) = "True" Then
                Me.QueenWhite.BackgroundImage = Nothing
                Me.QueenWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "QueenWhite" And KillF(i) = "" Then
                ChessPiece3 = "QueenWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "QueenWhite" And KillG(i) = "True" Then
                Me.QueenWhite.BackgroundImage = Nothing
                Me.QueenWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "QueenWhite" And KillG(i) = "" Then
                ChessPiece3 = "QueenWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "QueenWhite" And KillH(i) = "True" Then
                Me.QueenWhite.BackgroundImage = Nothing
                Me.QueenWhite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "QueenWhite" And KillH(i) = "" Then
                ChessPiece3 = "QueenWhite"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "QueenWhite" And PositionB(i) <> "QueenWhite" And PositionC(i) <> "QueenWhite" And PositionD(i) <> "QueenWhite" And PositionE(i) <> "QueenWhite" And PositionF(i) <> "QueenWhite" And PositionG(i) <> "QueenWhite" And PositionH(i) <> "QueenWhite" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.QueenWhite.BackColor = Nothing
                Me.QueenWhite.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "BishopWhite1" And KillA(i) = "True" Then
                Me.BishopWhite1.BackgroundImage = Nothing
                Me.BishopWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "BishopWhite1" And KillA(i) = "" Then
                ChessPiece3 = "BishopWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "BishopWhite1" And KillB(i) = "True" Then
                Me.BishopWhite1.BackgroundImage = Nothing
                Me.BishopWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "BishopWhite1" And KillB(i) = "" Then
                ChessPiece3 = "BishopWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "BishopWhite1" And KillC(i) = "True" Then
                Me.BishopWhite1.BackgroundImage = Nothing
                Me.BishopWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "BishopWhite1" And KillC(i) = "" Then
                ChessPiece3 = "BishopWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "BishopWhite1" And KillD(i) = "True" Then
                Me.BishopWhite1.BackgroundImage = Nothing
                Me.BishopWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "BishopWhite1" And KillD(i) = "" Then
                ChessPiece3 = "BishopWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "BishopWhite1" And KillE(i) = "True" Then
                Me.BishopWhite1.BackgroundImage = Nothing
                Me.BishopWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "BishopWhite1" And KillE(i) = "" Then
                ChessPiece3 = "BishopWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "BishopWhite1" And KillF(i) = "True" Then
                Me.BishopWhite1.BackgroundImage = Nothing
                Me.BishopWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "BishopWhite1" And KillF(i) = "" Then
                ChessPiece3 = "BishopWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "BishopWhite1" And KillG(i) = "True" Then
                Me.BishopWhite1.BackgroundImage = Nothing
                Me.BishopWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "BishopWhite1" And KillG(i) = "" Then
                ChessPiece3 = "BishopWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "BishopWhite1" And KillH(i) = "True" Then
                Me.BishopWhite1.BackgroundImage = Nothing
                Me.BishopWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "BishopWhite1" And KillH(i) = "" Then
                ChessPiece3 = "BishopWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "BishopWhite1" And PositionB(i) <> "BishopWhite1" And PositionC(i) <> "BishopWhite1" And PositionD(i) <> "BishopWhite1" And PositionE(i) <> "BishopWhite1" And PositionF(i) <> "BishopWhite1" And PositionG(i) <> "BishopWhite1" And PositionH(i) <> "BishopWhite1" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.BishopWhite1.BackColor = Nothing
                Me.BishopWhite1.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "BishopWhite2" And KillA(i) = "True" Then
                Me.BishopWhite2.BackgroundImage = Nothing
                Me.BishopWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "BishopWhite2" And KillA(i) = "" Then
                ChessPiece3 = "BishopWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "BishopWhite2" And KillB(i) = "True" Then
                Me.BishopWhite2.BackgroundImage = Nothing
                Me.BishopWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "BishopWhite2" And KillB(i) = "" Then
                ChessPiece3 = "BishopWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "BishopWhite2" And KillC(i) = "True" Then
                Me.BishopWhite2.BackgroundImage = Nothing
                Me.BishopWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "BishopWhite2" And KillC(i) = "" Then
                ChessPiece3 = "BishopWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "BishopWhite2" And KillD(i) = "True" Then
                Me.BishopWhite2.BackgroundImage = Nothing
                Me.BishopWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "BishopWhite2" And KillD(i) = "" Then
                ChessPiece3 = "BishopWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "BishopWhite2" And KillE(i) = "True" Then
                Me.BishopWhite2.BackgroundImage = Nothing
                Me.BishopWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "BishopWhite2" And KillE(i) = "" Then
                ChessPiece3 = "BishopWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "BishopWhite2" And KillF(i) = "True" Then
                Me.BishopWhite2.BackgroundImage = Nothing
                Me.BishopWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "BishopWhite2" And KillF(i) = "" Then
                ChessPiece3 = "BishopWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "BishopWhite2" And KillG(i) = "True" Then
                Me.BishopWhite2.BackgroundImage = Nothing
                Me.BishopWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "BishopWhite2" And KillG(i) = "" Then
                ChessPiece3 = "BishopWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "BishopWhite2" And KillH(i) = "True" Then
                Me.BishopWhite2.BackgroundImage = Nothing
                Me.BishopWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "BishopWhite2" And KillH(i) = "" Then
                ChessPiece3 = "BishopWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "BishopWhite2" And PositionB(i) <> "BishopWhite2" And PositionC(i) <> "BishopWhite2" And PositionD(i) <> "BishopWhite2" And PositionE(i) <> "BishopWhite2" And PositionF(i) <> "BishopWhite2" And PositionG(i) <> "BishopWhite2" And PositionH(i) <> "BishopWhite2" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.BishopWhite2.BackColor = Nothing
                Me.BishopWhite2.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "KnightWhite1" And KillA(i) = "True" Then
                Me.KnightWhite1.BackgroundImage = Nothing
                Me.KnightWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "KnightWhite1" And KillA(i) = "" Then
                ChessPiece3 = "KnightWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "KnightWhite1" And KillB(i) = "True" Then
                Me.KnightWhite1.BackgroundImage = Nothing
                Me.KnightWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "KnightWhite1" And KillB(i) = "" Then
                ChessPiece3 = "KnightWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "KnightWhite1" And KillC(i) = "True" Then
                Me.KnightWhite1.BackgroundImage = Nothing
                Me.KnightWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "KnightWhite1" And KillC(i) = "" Then
                ChessPiece3 = "KnightWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "KnightWhite1" And KillD(i) = "True" Then
                Me.KnightWhite1.BackgroundImage = Nothing
                Me.KnightWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "KnightWhite1" And KillD(i) = "" Then
                ChessPiece3 = "KnightWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "KnightWhite1" And KillE(i) = "True" Then
                Me.KnightWhite1.BackgroundImage = Nothing
                Me.KnightWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "KnightWhite1" And KillE(i) = "" Then
                ChessPiece3 = "KnightWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "KnightWhite1" And KillF(i) = "True" Then
                Me.KnightWhite1.BackgroundImage = Nothing
                Me.KnightWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "KnightWhite1" And KillF(i) = "" Then
                ChessPiece3 = "KnightWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "KnightWhite1" And KillG(i) = "True" Then
                Me.KnightWhite1.BackgroundImage = Nothing
                Me.KnightWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "KnightWhite1" And KillG(i) = "" Then
                ChessPiece3 = "KnightWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "KnightWhite1" And KillH(i) = "True" Then
                Me.KnightWhite1.BackgroundImage = Nothing
                Me.KnightWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "KnightWhite1" And KillH(i) = "" Then
                ChessPiece3 = "KnightWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "KnightWhite1" And PositionB(i) <> "KnightWhite1" And PositionC(i) <> "KnightWhite1" And PositionD(i) <> "KnightWhite1" And PositionE(i) <> "KnightWhite1" And PositionF(i) <> "KnightWhite1" And PositionG(i) <> "KnightWhite1" And PositionH(i) <> "KnightWhite1" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.KnightWhite1.BackColor = Nothing
                Me.KnightWhite1.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "KnightWhite2" And KillA(i) = "True" Then
                Me.KnightWhite2.BackgroundImage = Nothing
                Me.KnightWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "KnightWhite2" And KillA(i) = "" Then
                ChessPiece3 = "KnightWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "KnightWhite2" And KillB(i) = "True" Then
                Me.KnightWhite2.BackgroundImage = Nothing
                Me.KnightWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "KnightWhite2" And KillB(i) = "" Then
                ChessPiece3 = "KnightWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "KnightWhite2" And KillC(i) = "True" Then
                Me.KnightWhite2.BackgroundImage = Nothing
                Me.KnightWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "KnightWhite2" And KillC(i) = "" Then
                ChessPiece3 = "KnightWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "KnightWhite2" And KillD(i) = "True" Then
                Me.KnightWhite2.BackgroundImage = Nothing
                Me.KnightWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "KnightWhite2" And KillD(i) = "" Then
                ChessPiece3 = "KnightWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "KnightWhite2" And KillE(i) = "True" Then
                Me.KnightWhite2.BackgroundImage = Nothing
                Me.KnightWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "KnightWhite2" And KillE(i) = "" Then
                ChessPiece3 = "KnightWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "KnightWhite2" And KillF(i) = "True" Then
                Me.KnightWhite2.BackgroundImage = Nothing
                Me.KnightWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "KnightWhite2" And KillF(i) = "" Then
                ChessPiece3 = "KnightWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "KnightWhite2" And KillG(i) = "True" Then
                Me.KnightWhite2.BackgroundImage = Nothing
                Me.KnightWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "KnightWhite2" And KillG(i) = "" Then
                ChessPiece3 = "KnightWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "KnightWhite2" And KillH(i) = "True" Then
                Me.KnightWhite2.BackgroundImage = Nothing
                Me.KnightWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "KnightWhite2" And KillH(i) = "" Then
                ChessPiece3 = "KnightWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "KnightWhite2" And PositionB(i) <> "KnightWhite2" And PositionC(i) <> "KnightWhite2" And PositionD(i) <> "KnightWhite2" And PositionE(i) <> "KnightWhite2" And PositionF(i) <> "KnightWhite2" And PositionG(i) <> "KnightWhite2" And PositionH(i) <> "KnightWhite2" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.KnightWhite2.BackColor = Nothing
                Me.KnightWhite2.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "RookWhite1" And KillA(i) = "True" Then
                Me.RookWhite1.BackgroundImage = Nothing
                Me.RookWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "RookWhite1" And KillA(i) = "" Then
                ChessPiece3 = "RookWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "RookWhite1" And KillB(i) = "True" Then
                Me.RookWhite1.BackgroundImage = Nothing
                Me.RookWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "RookWhite1" And KillB(i) = "" Then
                ChessPiece3 = "RookWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "RookWhite1" And KillC(i) = "True" Then
                Me.RookWhite1.BackgroundImage = Nothing
                Me.RookWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "RookWhite1" And KillC(i) = "" Then
                ChessPiece3 = "RookWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "RookWhite1" And KillD(i) = "True" Then
                Me.RookWhite1.BackgroundImage = Nothing
                Me.RookWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "RookWhite1" And KillD(i) = "" Then
                ChessPiece3 = "RookWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "RookWhite1" And KillE(i) = "True" Then
                Me.RookWhite1.BackgroundImage = Nothing
                Me.RookWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "RookWhite1" And KillE(i) = "" Then
                ChessPiece3 = "RookWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "RookWhite1" And KillF(i) = "True" Then
                Me.RookWhite1.BackgroundImage = Nothing
                Me.RookWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "RookWhite1" And KillF(i) = "" Then
                ChessPiece3 = "RookWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "RookWhite1" And KillG(i) = "True" Then
                Me.RookWhite1.BackgroundImage = Nothing
                Me.RookWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "RookWhite1" And KillG(i) = "" Then
                ChessPiece3 = "RookWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "RookWhite1" And KillH(i) = "True" Then
                Me.RookWhite1.BackgroundImage = Nothing
                Me.RookWhite1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "RookWhite1" And KillH(i) = "" Then
                ChessPiece3 = "RookWhite1"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "RookWhite1" And PositionB(i) <> "RookWhite1" And PositionC(i) <> "RookWhite1" And PositionD(i) <> "RookWhite1" And PositionE(i) <> "RookWhite1" And PositionF(i) <> "RookWhite1" And PositionG(i) <> "RookWhite1" And PositionH(i) <> "RookWhite1" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.RookWhite1.BackColor = Nothing
                Me.RookWhite1.BackgroundImage = Nothing
            End If
        Next
        nu = 0
        For i = 1 To 8
            If PositionA(i) = "RookWhite2" And KillA(i) = "True" Then
                Me.RookWhite2.BackgroundImage = Nothing
                Me.RookWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionA(i) = "RookWhite2" And KillA(i) = "" Then
                ChessPiece3 = "RookWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionB(i) = "RookWhite2" And KillB(i) = "True" Then
                Me.RookWhite2.BackgroundImage = Nothing
                Me.RookWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionB(i) = "RookWhite2" And KillB(i) = "" Then
                ChessPiece3 = "RookWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionC(i) = "RookWhite2" And KillC(i) = "True" Then
                Me.RookWhite2.BackgroundImage = Nothing
                Me.RookWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionC(i) = "RookWhite2" And KillC(i) = "" Then
                ChessPiece3 = "RookWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionD(i) = "RookWhite2" And KillD(i) = "True" Then
                Me.RookWhite2.BackgroundImage = Nothing
                Me.RookWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionD(i) = "RookWhite2" And KillD(i) = "" Then
                ChessPiece3 = "RookWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionE(i) = "RookWhite2" And KillE(i) = "True" Then
                Me.RookWhite2.BackgroundImage = Nothing
                Me.RookWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionE(i) = "RookWhite2" And KillE(i) = "" Then
                ChessPiece3 = "RookWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionF(i) = "RookWhite2" And KillF(i) = "True" Then
                Me.RookWhite2.BackgroundImage = Nothing
                Me.RookWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionF(i) = "RookWhite2" And KillF(i) = "" Then
                ChessPiece3 = "RookWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionG(i) = "RookWhite2" And KillG(i) = "True" Then
                Me.RookWhite2.BackgroundImage = Nothing
                Me.RookWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionG(i) = "RookWhite2" And KillG(i) = "" Then
                ChessPiece3 = "RookWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionH(i) = "RookWhite2" And KillH(i) = "True" Then
                Me.RookWhite2.BackgroundImage = Nothing
                Me.RookWhite2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
            ElseIf PositionH(i) = "RookWhite2" And KillH(i) = "" Then
                ChessPiece3 = "RookWhite2"
                SetBackGround2()
                ChessPiece3 = ""
            End If
            If PositionA(i) <> "RookWhite2" And PositionB(i) <> "RookWhite2" And PositionC(i) <> "RookWhite2" And PositionD(i) <> "RookWhite2" And PositionE(i) <> "RookWhite2" And PositionF(i) <> "RookWhite2" And PositionG(i) <> "RookWhite2" And PositionH(i) <> "RookWhite2" Then
                nu = nu + 1
            End If
            If nu = 8 Then
                Me.RookWhite2.BackColor = Nothing
                Me.RookWhite2.BackgroundImage = Nothing
            End If
        Next
        nu = 0
    End Sub
    Private Sub CheckPosition()
        clean()
        For x = 1 To 8
            For y = 1 To 8
                If RookBlack1.Top = PositionTop(x) And RookBlack1.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "RookBlack1"
                        Case 2
                            PositionB(y) = "RookBlack1"
                        Case 3
                            PositionC(y) = "RookBlack1"
                        Case 4
                            PositionD(y) = "RookBlack1"
                        Case 5
                            PositionE(y) = "RookBlack1"
                        Case 6
                            PositionF(y) = "RookBlack1"
                        Case 7
                            PositionG(y) = "RookBlack1"
                        Case 8
                            PositionH(y) = "RookBlack1"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If KnightBlack1.Top = PositionTop(x) And KnightBlack1.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "KnightBlack1"
                        Case 2
                            PositionB(y) = "KnightBlack1"
                        Case 3
                            PositionC(y) = "KnightBlack1"
                        Case 4
                            PositionD(y) = "KnightBlack1"
                        Case 5
                            PositionE(y) = "KnightBlack1"
                        Case 6
                            PositionF(y) = "KnightBlack1"
                        Case 7
                            PositionG(y) = "KnightBlack1"
                        Case 8
                            PositionH(y) = "KnightBlack1"
                    End Select
                End If
            Next
        Next
        For x = 1 To 8
            For y = 1 To 8
                If BishopBlack1.Top = PositionTop(x) And BishopBlack1.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "BishopBlack1"
                        Case 2
                            PositionB(y) = "BishopBlack1"
                        Case 3
                            PositionC(y) = "BishopBlack1"
                        Case 4
                            PositionD(y) = "BishopBlack1"
                        Case 5
                            PositionE(y) = "BishopBlack1"
                        Case 6
                            PositionF(y) = "BishopBlack1"
                        Case 7
                            PositionG(y) = "BishopBlack1"
                        Case 8
                            PositionH(y) = "BishopBlack1"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If QueenBlack.Top = PositionTop(x) And QueenBlack.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "QueenBlack"
                        Case 2
                            PositionB(y) = "QueenBlack"
                        Case 3
                            PositionC(y) = "QueenBlack"
                        Case 4
                            PositionD(y) = "QueenBlack"
                        Case 5
                            PositionE(y) = "QueenBlack"
                        Case 6
                            PositionF(y) = "QueenBlack"
                        Case 7
                            PositionG(y) = "QueenBlack"
                        Case 8
                            PositionH(y) = "QueenBlack"
                    End Select
                End If
            Next
        Next
        For x = 1 To 8
            For y = 1 To 8
                If KingBlack.Top = PositionTop(x) And KingBlack.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "KingBlack"
                        Case 2
                            PositionB(y) = "KingBlack"
                        Case 3
                            PositionC(y) = "KingBlack"
                        Case 4
                            PositionD(y) = "KingBlack"
                        Case 5
                            PositionE(y) = "KingBlack"
                        Case 6
                            PositionF(y) = "KingBlack"
                        Case 7
                            PositionG(y) = "KingBlack"
                        Case 8
                            PositionH(y) = "KingBlack"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If BishopBlack2.Top = PositionTop(x) And BishopBlack2.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "BishopBlack2"
                        Case 2
                            PositionB(y) = "BishopBlack2"
                        Case 3
                            PositionC(y) = "BishopBlack2"
                        Case 4
                            PositionD(y) = "BishopBlack2"
                        Case 5
                            PositionE(y) = "BishopBlack2"
                        Case 6
                            PositionF(y) = "BishopBlack2"
                        Case 7
                            PositionG(y) = "BishopBlack2"
                        Case 8
                            PositionH(y) = "BishopBlack2"
                    End Select
                End If
            Next
        Next
        For x = 1 To 8
            For y = 1 To 8
                If KnightBlack2.Top = PositionTop(x) And KnightBlack2.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "KnightBlack2"
                        Case 2
                            PositionB(y) = "KnightBlack2"
                        Case 3
                            PositionC(y) = "KnightBlack2"
                        Case 4
                            PositionD(y) = "KnightBlack2"
                        Case 5
                            PositionE(y) = "KnightBlack2"
                        Case 6
                            PositionF(y) = "KnightBlack2"
                        Case 7
                            PositionG(y) = "KnightBlack2"
                        Case 8
                            PositionH(y) = "BishopBlack1"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If RookBlack2.Top = PositionTop(x) And RookBlack2.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "RookBlack2"
                        Case 2
                            PositionB(y) = "RookBlack2"
                        Case 3
                            PositionC(y) = "RookBlack2"
                        Case 4
                            PositionD(y) = "RookBlack2"
                        Case 5
                            PositionE(y) = "RookBlack2"
                        Case 6
                            PositionF(y) = "RookBlack2"
                        Case 7
                            PositionG(y) = "RookBlack2"
                        Case 8
                            PositionH(y) = "RookBlack2"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnBlack1.Top = PositionTop(x) And PawnBlack1.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = PBlack(1)
                        Case 2
                            PositionB(y) = PBlack(1)
                        Case 3
                            PositionC(y) = PBlack(1)
                        Case 4
                            PositionD(y) = PBlack(1)
                        Case 5
                            PositionE(y) = PBlack(1)
                        Case 6
                            PositionF(y) = PBlack(1)
                        Case 7
                            PositionG(y) = PBlack(1)
                        Case 8
                            PositionH(y) = PBlack(1)
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnBlack2.Top = PositionTop(x) And PawnBlack2.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = PBlack(2)
                        Case 2
                            PositionB(y) = PBlack(2)
                        Case 3
                            PositionC(y) = PBlack(2)
                        Case 4
                            PositionD(y) = PBlack(2)
                        Case 5
                            PositionE(y) = PBlack(2)
                        Case 6
                            PositionF(y) = PBlack(2)
                        Case 7
                            PositionG(y) = PBlack(2)
                        Case 8
                            PositionH(y) = PBlack(2)
                    End Select
                End If
            Next
        Next
        For x = 1 To 8
            For y = 1 To 8
                If PawnBlack3.Top = PositionTop(x) And PawnBlack3.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = PBlack(3)
                        Case 2
                            PositionB(y) = PBlack(3)
                        Case 3
                            PositionC(y) = PBlack(3)
                        Case 4
                            PositionD(y) = PBlack(3)
                        Case 5
                            PositionE(y) = PBlack(3)
                        Case 6
                            PositionF(y) = PBlack(3)
                        Case 7
                            PositionG(y) = PBlack(3)
                        Case 8
                            PositionH(y) = PBlack(3)
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnBlack4.Top = PositionTop(x) And PawnBlack4.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = PBlack(4)
                        Case 2
                            PositionB(y) = PBlack(4)
                        Case 3
                            PositionC(y) = PBlack(4)
                        Case 4
                            PositionD(y) = PBlack(4)
                        Case 5
                            PositionE(y) = PBlack(4)
                        Case 6
                            PositionF(y) = PBlack(4)
                        Case 7
                            PositionG(y) = PBlack(4)
                        Case 8
                            PositionH(y) = PBlack(4)
                    End Select
                End If
            Next
        Next
        For x = 1 To 8
            For y = 1 To 8
                If PawnBlack5.Top = PositionTop(x) And PawnBlack5.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = PBlack(5)
                        Case 2
                            PositionB(y) = PBlack(5)
                        Case 3
                            PositionC(y) = PBlack(5)
                        Case 4
                            PositionD(y) = PBlack(5)
                        Case 5
                            PositionE(y) = PBlack(5)
                        Case 6
                            PositionF(y) = PBlack(5)
                        Case 7
                            PositionG(y) = PBlack(5)
                        Case 8
                            PositionH(y) = PBlack(5)
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnBlack6.Top = PositionTop(x) And PawnBlack6.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = PBlack(6)
                        Case 2
                            PositionB(y) = PBlack(6)
                        Case 3
                            PositionC(y) = PBlack(6)
                        Case 4
                            PositionD(y) = PBlack(6)
                        Case 5
                            PositionE(y) = PBlack(6)
                        Case 6
                            PositionF(y) = PBlack(6)
                        Case 7
                            PositionG(y) = PBlack(6)
                        Case 8
                            PositionH(y) = PBlack(6)
                    End Select
                End If
            Next
        Next
        For x = 1 To 8
            For y = 1 To 8
                If PawnBlack7.Top = PositionTop(x) And PawnBlack7.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = PBlack(7)
                        Case 2
                            PositionB(y) = PBlack(7)
                        Case 3
                            PositionC(y) = PBlack(7)
                        Case 4
                            PositionD(y) = PBlack(7)
                        Case 5
                            PositionE(y) = PBlack(7)
                        Case 6
                            PositionF(y) = PBlack(7)
                        Case 7
                            PositionG(y) = PBlack(7)
                        Case 8
                            PositionH(y) = PBlack(7)
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnBlack8.Top = PositionTop(x) And PawnBlack8.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = PBlack(8)
                        Case 2
                            PositionB(y) = PBlack(8)
                        Case 3
                            PositionC(y) = PBlack(8)
                        Case 4
                            PositionD(y) = PBlack(8)
                        Case 5
                            PositionE(y) = PBlack(8)
                        Case 6
                            PositionF(y) = PBlack(8)
                        Case 7
                            PositionG(y) = PBlack(8)
                        Case 8
                            PositionH(y) = PBlack(8)
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnWhite1.Top = PositionTop(x) And PawnWhite1.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "PawnWhite1"
                        Case 2
                            PositionB(y) = "PawnWhite1"
                        Case 3
                            PositionC(y) = "PawnWhite1"
                        Case 4
                            PositionD(y) = "PawnWhite1"
                        Case 5
                            PositionE(y) = "PawnWhite1"
                        Case 6
                            PositionF(y) = "PawnWhite1"
                        Case 7
                            PositionG(y) = "PawnWhite1"
                        Case 8
                            PositionH(y) = "PawnWhite1"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnWhite2.Top = PositionTop(x) And PawnWhite2.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "PawnWhite2"
                        Case 2
                            PositionB(y) = "PawnWhite2"
                        Case 3
                            PositionC(y) = "PawnWhite2"
                        Case 4
                            PositionD(y) = "PawnWhite2"
                        Case 5
                            PositionE(y) = "PawnWhite2"
                        Case 6
                            PositionF(y) = "PawnWhite2"
                        Case 7
                            PositionG(y) = "PawnWhite2"
                        Case 8
                            PositionH(y) = "PawnWhite2"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnWhite3.Top = PositionTop(x) And PawnWhite3.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "PawnWhite3"
                        Case 2
                            PositionB(y) = "PawnWhite3"
                        Case 3
                            PositionC(y) = "PawnWhite3"
                        Case 4
                            PositionD(y) = "PawnWhite3"
                        Case 5
                            PositionE(y) = "PawnWhite3"
                        Case 6
                            PositionF(y) = "PawnWhite3"
                        Case 7
                            PositionG(y) = "PawnWhite3"
                        Case 8
                            PositionH(y) = "PawnWhite3"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnWhite4.Top = PositionTop(x) And PawnWhite4.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "PawnWhite4"
                        Case 2
                            PositionB(y) = "PawnWhite4"
                        Case 3
                            PositionC(y) = "PawnWhite4"
                        Case 4
                            PositionD(y) = "PawnWhite4"
                        Case 5
                            PositionE(y) = "PawnWhite4"
                        Case 6
                            PositionF(y) = "PawnWhite4"
                        Case 7
                            PositionG(y) = "PawnWhite4"
                        Case 8
                            PositionH(y) = "PawnWhite4"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnWhite5.Top = PositionTop(x) And PawnWhite5.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "PawnWhite5"
                        Case 2
                            PositionB(y) = "PawnWhite5"
                        Case 3
                            PositionC(y) = "PawnWhite5"
                        Case 4
                            PositionD(y) = "PawnWhite5"
                        Case 5
                            PositionE(y) = "PawnWhite5"
                        Case 6
                            PositionF(y) = "PawnWhite5"
                        Case 7
                            PositionG(y) = "PawnWhite5"
                        Case 8
                            PositionH(y) = "PawnWhite5"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnWhite6.Top = PositionTop(x) And PawnWhite6.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "PawnWhite6"
                        Case 2
                            PositionB(y) = "PawnWhite6"
                        Case 3
                            PositionC(y) = "PawnWhite6"
                        Case 4
                            PositionD(y) = "PawnWhite6"
                        Case 5
                            PositionE(y) = "PawnWhite6"
                        Case 6
                            PositionF(y) = "PawnWhite6"
                        Case 7
                            PositionG(y) = "PawnWhite6"
                        Case 8
                            PositionH(y) = "PawnWhite6"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnWhite7.Top = PositionTop(x) And PawnWhite7.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "PawnWhite7"
                        Case 2
                            PositionB(y) = "PawnWhite7"
                        Case 3
                            PositionC(y) = "PawnWhite7"
                        Case 4
                            PositionD(y) = "PawnWhite7"
                        Case 5
                            PositionE(y) = "PawnWhite7"
                        Case 6
                            PositionF(y) = "PawnWhite7"
                        Case 7
                            PositionG(y) = "PawnWhite7"
                        Case 8
                            PositionH(y) = "PawnWhite7"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If PawnWhite8.Top = PositionTop(x) And PawnWhite8.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "PawnWhite8"
                        Case 2
                            PositionB(y) = "PawnWhite8"
                        Case 3
                            PositionC(y) = "PawnWhite8"
                        Case 4
                            PositionD(y) = "PawnWhite8"
                        Case 5
                            PositionE(y) = "PawnWhite8"
                        Case 6
                            PositionF(y) = "PawnWhite8"
                        Case 7
                            PositionG(y) = "PawnWhite8"
                        Case 8
                            PositionH(y) = "PawnWhite8"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If RookWhite1.Top = PositionTop(x) And RookWhite1.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "RookWhite1"
                        Case 2
                            PositionB(y) = "RookWhite1"
                        Case 3
                            PositionC(y) = "RookWhite1"
                        Case 4
                            PositionD(y) = "RookWhite1"
                        Case 5
                            PositionE(y) = "RookWhite1"
                        Case 6
                            PositionF(y) = "RookWhite1"
                        Case 7
                            PositionG(y) = "RookWhite1"
                        Case 8
                            PositionH(y) = "RookWhite1"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If KnightWhite1.Top = PositionTop(x) And KnightWhite1.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "KnightWhite1"
                        Case 2
                            PositionB(y) = "KnightWhite1"
                        Case 3
                            PositionC(y) = "KnightWhite1"
                        Case 4
                            PositionD(y) = "KnightWhite1"
                        Case 5
                            PositionE(y) = "KnightWhite1"
                        Case 6
                            PositionF(y) = "KnightWhite1"
                        Case 7
                            PositionG(y) = "KnightWhite1"
                        Case 8
                            PositionH(y) = "KnightWhite1"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If BishopWhite1.Top = PositionTop(x) And BishopWhite1.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "BishopWhite1"
                        Case 2
                            PositionB(y) = "BishopWhite1"
                        Case 3
                            PositionC(y) = "BishopWhite1"
                        Case 4
                            PositionD(y) = "BishopWhite1"
                        Case 5
                            PositionE(y) = "BishopWhite1"
                        Case 6
                            PositionF(y) = "BishopWhite1"
                        Case 7
                            PositionG(y) = "BishopWhite1"
                        Case 8
                            PositionH(y) = "BishopWhite1"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If QueenWhite.Top = PositionTop(x) And QueenWhite.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "QueenWhite"
                        Case 2
                            PositionB(y) = "QueenWhite"
                        Case 3
                            PositionC(y) = "QueenWhite"
                        Case 4
                            PositionD(y) = "QueenWhite"
                        Case 5
                            PositionE(y) = "QueenWhite"
                        Case 6
                            PositionF(y) = "QueenWhite"
                        Case 7
                            PositionG(y) = "QueenWhite"
                        Case 8
                            PositionH(y) = "QueenWhite"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If KingWhite.Top = PositionTop(x) And KingWhite.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "KingWhite"
                        Case 2
                            PositionB(y) = "KingWhite"
                        Case 3
                            PositionC(y) = "KingWhite"
                        Case 4
                            PositionD(y) = "KingWhite"
                        Case 5
                            PositionE(y) = "KingWhite"
                        Case 6
                            PositionF(y) = "KingWhite"
                        Case 7
                            PositionG(y) = "KingWhite"
                        Case 8
                            PositionH(y) = "KingWhite"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If BishopWhite2.Top = PositionTop(x) And BishopWhite2.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "BishopWhite2"
                        Case 2
                            PositionB(y) = "BishopWhite2"
                        Case 3
                            PositionC(y) = "BishopWhite2"
                        Case 4
                            PositionD(y) = "BishopWhite2"
                        Case 5
                            PositionE(y) = "BishopWhite2"
                        Case 6
                            PositionF(y) = "BishopWhite2"
                        Case 7
                            PositionG(y) = "BishopWhite2"
                        Case 8
                            PositionH(y) = "BishopWhite2"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If KnightWhite2.Top = PositionTop(x) And KnightWhite2.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "KnightWhite2"
                        Case 2
                            PositionB(y) = "KnightWhite2"
                        Case 3
                            PositionC(y) = "KnightWhite2"
                        Case 4
                            PositionD(y) = "KnightWhite2"
                        Case 5
                            PositionE(y) = "KnightWhite2"
                        Case 6
                            PositionF(y) = "KnightWhite2"
                        Case 7
                            PositionG(y) = "KnightWhite2"
                        Case 8
                            PositionH(y) = "KnightWhite2"
                    End Select
                End If
            Next
        Next

        For x = 1 To 8
            For y = 1 To 8
                If RookWhite2.Top = PositionTop(x) And RookWhite2.Left = PositionLeft(y) Then
                    Select Case x
                        Case 1
                            PositionA(y) = "RookWhite2"
                        Case 2
                            PositionB(y) = "RookWhite2"
                        Case 3
                            PositionC(y) = "RookWhite2"
                        Case 4
                            PositionD(y) = "RookWhite2"
                        Case 5
                            PositionE(y) = "RookWhite2"
                        Case 6
                            PositionF(y) = "RookWhite2"
                        Case 7
                            PositionG(y) = "RookWhite2"
                        Case 8
                            PositionH(y) = "RookWhite2"
                    End Select
                End If
            Next
        Next
    End Sub
    Private Sub FixIndice()
        If m = -1 Or m = -2 Or m = -3 Or m = -4 Or m = -5 Or m = -6 Or m = -7 Or m = -8 Or m = -9 Then
            m = 0
        End If
        If u = -1 Or u = -2 Or u = -3 Or u = -4 Or u = -5 Or u = -6 Or u = -7 Or u = -8 Or u = -9 Then
            u = 0
        End If
        If n = -1 Or n = -2 Or n = -3 Or n = -4 Or n = -5 Or n = -6 Or n = -7 Or n = -8 Or n = -9 Then
            n = 0
        End If
        If u2 = -1 Or u2 = -2 Or u2 = -3 Or u2 = -4 Or u2 = -5 Or u2 = -6 Or u2 = -7 Or u2 = -8 Or u2 = -9 Then
            u2 = 0
        End If
        If n2 = -1 Or n2 = -2 Or n2 = -3 Or n2 = -4 Or n2 = -5 Or n2 = -6 Or n2 = -7 Or n2 = -8 Or n2 = -9 Then
            n2 = 0
        End If
        If m2 = -1 Or m2 = -2 Or m2 = -3 Or m2 = -4 Or m2 = -5 Or m2 = -6 Or m2 = -7 Or m2 = -8 Or m2 = -9 Then
            m2 = 0
        End If
        If o2 = -1 Or o2 = -2 Or o2 = -3 Or o2 = -4 Or o2 = -5 Or o2 = -6 Or o2 = -7 Or o2 = -8 Or o2 = -9 Then
            o2 = 0
        End If
    End Sub
    Private Sub ButtonDisabled()
        For i = 1 To 8
            buttonA(i) = 0
            buttonB(i) = 0
            buttonC(i) = 0
            buttonD(i) = 0
            buttonF(i) = 0
            buttonE(i) = 0
            buttonG(i) = 0
            buttonH(i) = 0
        Next
    End Sub
    Private Sub ButtonHide()
        If buttonA(1) = 0 Then
            A1.Hide()
        Else
            A1.Show()
        End If
        If buttonA(2) = 0 Then
            A2.Hide()
        Else
            A2.Show()
        End If
        If buttonA(3) = 0 Then
            A3.Hide()
        Else
            A3.Show()
        End If
        If buttonA(4) = 0 Then
            A4.Hide()
        Else
            A4.Show()
        End If
        If buttonA(5) = 0 Then
            A5.Hide()
        Else
            A5.Show()
        End If
        If buttonA(6) = 0 Then
            A6.Hide()
        Else
            A6.Show()
        End If
        If buttonA(7) = 0 Then
            A7.Hide()
        Else
            A7.Show()
        End If
        If buttonA(8) = 0 Then
            A8.Hide()
        Else
            A8.Show()
        End If
        If buttonB(1) = 0 Then
            B1.Hide()
        Else
            B1.Show()
        End If
        If buttonB(2) = 0 Then
            B2.Hide()
        Else
            B2.Show()
        End If
        If buttonB(3) = 0 Then
            B3.Hide()
        Else
            B3.Show()
        End If
        If buttonB(4) = 0 Then
            B4.Hide()
        Else
            B4.Show()
        End If
        If buttonB(5) = 0 Then
            B5.Hide()
        Else
            B5.Show()
        End If
        If buttonB(6) = 0 Then
            B6.Hide()
        Else
            B6.Show()
        End If
        If buttonB(7) = 0 Then
            B7.Hide()
        Else
            B7.Show()
        End If
        If buttonB(8) = 0 Then
            B8.Hide()
        Else
            B8.Show()
        End If
        If buttonC(1) = 0 Then
            C1.Hide()
        Else
            C1.Show()
        End If
        If buttonC(2) = 0 Then
            C2.Hide()
        Else
            C2.Show()
        End If
        If buttonC(3) = 0 Then
            C3.Hide()
        Else
            C3.Show()
        End If
        If buttonC(4) = 0 Then
            C4.Hide()
        Else
            C4.Show()
        End If
        If buttonC(5) = 0 Then
            C5.Hide()
        Else
            C5.Show()
        End If
        If buttonC(6) = 0 Then
            C6.Hide()
        Else
            C6.Show()
        End If
        If buttonC(7) = 0 Then
            C7.Hide()
        Else
            C7.Show()
        End If
        If buttonC(8) = 0 Then
            C8.Hide()
        Else
            C8.Show()
        End If
        If buttonD(1) = 0 Then
            D1.Hide()
        Else
            D1.Show()
        End If
        If buttonD(2) = 0 Then
            D2.Hide()
        Else
            D2.Show()
        End If
        If buttonD(3) = 0 Then
            D3.Hide()
        Else
            D3.Show()
        End If
        If buttonD(4) = 0 Then
            D4.Hide()
        Else
            D4.Show()
        End If
        If buttonD(5) = 0 Then
            D5.Hide()
        Else
            D5.Show()
        End If
        If buttonD(6) = 0 Then
            D6.Hide()
        Else
            D6.Show()
        End If
        If buttonD(7) = 0 Then
            D7.Hide()
        Else
            D7.Show()
        End If
        If buttonD(8) = 0 Then
            D8.Hide()
        Else
            D8.Show()
        End If
        If buttonE(1) = 0 Then
            E1.Hide()
        Else
            E1.Show()
        End If
        If buttonE(2) = 0 Then
            E2.Hide()
        Else
            E2.Show()
        End If
        If buttonE(3) = 0 Then
            E3.Hide()
        Else
            E3.Show()
        End If
        If buttonE(4) = 0 Then
            E4.Hide()
        Else
            E4.Show()
        End If
        If buttonE(5) = 0 Then
            E5.Hide()
        Else
            E5.Show()
        End If
        If buttonE(6) = 0 Then
            E6.Hide()
        Else
            E6.Show()
        End If
        If buttonE(7) = 0 Then
            E7.Hide()
        Else
            E7.Show()
        End If
        If buttonE(8) = 0 Then
            E8.Hide()
        Else
            E8.Show()
        End If
        If buttonF(1) = 0 Then
            F1.Hide()
        Else
            F1.Show()
        End If
        If buttonF(2) = 0 Then
            F2.Hide()
        Else
            F2.Show()
        End If
        If buttonF(3) = 0 Then
            F3.Hide()
        Else
            F3.Show()
        End If
        If buttonF(4) = 0 Then
            F4.Hide()
        Else
            F4.Show()
        End If
        If buttonF(5) = 0 Then
            F5.Hide()
        Else
            F5.Show()
        End If
        If buttonF(6) = 0 Then
            F6.Hide()
        Else
            F6.Show()
        End If
        If buttonF(7) = 0 Then
            F7.Hide()
        Else
            F7.Show()
        End If
        If buttonF(8) = 0 Then
            F8.Hide()
        Else
            F8.Show()
        End If
        If buttonG(1) = 0 Then
            G1.Hide()
        Else
            G1.Show()
        End If
        If buttonG(2) = 0 Then
            G2.Hide()
        Else
            G2.Show()
        End If
        If buttonG(3) = 0 Then
            G3.Hide()
        Else
            G3.Show()
        End If
        If buttonG(4) = 0 Then
            G4.Hide()
        Else
            G4.Show()
        End If
        If buttonG(5) = 0 Then
            G5.Hide()
        Else
            G5.Show()
        End If
        If buttonG(6) = 0 Then
            G6.Hide()
        Else
            G6.Show()
        End If
        If buttonG(7) = 0 Then
            G7.Hide()
        Else
            G7.Show()
        End If
        If buttonG(8) = 0 Then
            G8.Hide()
        Else
            G8.Show()
        End If
        If buttonH(1) = 0 Then
            H1.Hide()
        Else
            H1.Show()
        End If
        If buttonH(2) = 0 Then
            H2.Hide()
        Else
            H2.Show()
        End If
        If buttonH(3) = 0 Then
            H3.Hide()
        Else
            H3.Show()
        End If
        If buttonH(4) = 0 Then
            H4.Hide()
        Else
            H4.Show()
        End If
        If buttonH(5) = 0 Then
            H5.Hide()
        Else
            H5.Show()
        End If
        If buttonH(6) = 0 Then
            H6.Hide()
        Else
            H6.Show()
        End If
        If buttonH(7) = 0 Then
            H7.Hide()
        Else
            H7.Show()
        End If
        If buttonH(8) = 0 Then
            H8.Hide()
        Else
            H8.Show()
        End If
    End Sub
    Private Sub BottonEnabled()
        Select Case ChessPiece
            Case "RookBlack1"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "RookBlack1" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "RookBlack1" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "RookBlack1" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "RookBlack1" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "RookBlack1" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "RookBlack1" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "RookBlack1" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "RookBlack1" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "RookBlack1" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "RookBlack1" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "RookBlack1" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "RookBlack1" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "RookBlack1" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "RookBlack1" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "RookBlack1" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "RookBlack1" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "RookBlack1" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "RookBlack1" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "RookBlack1" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "RookBlack1" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "RookBlack1" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "RookBlack1" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "RookBlack1" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "RookBlack1" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "RookBlack1" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "RookBlack1" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "RookBlack1" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "RookBlack1" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "RookBlack1" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "RookBlack1" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "RookBlack1" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "RookBlack1" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "RookBlack1" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "RookBlack1" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "RookBlack1" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "RookBlack1" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "RookBlack1" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "RookBlack1" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "RookBlack1" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "RookBlack1" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "RookBlack1" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "RookBlack1" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "RookBlack1" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "RookBlack1" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "RookBlack1" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "RookBlack1" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "RookBlack1" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "RookBlack1" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "RookBlack1" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "RookBlack1" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "RookBlack1" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "RookBlack1" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "RookBlack1" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "RookBlack1" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "RookBlack1" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "RookBlack1" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "RookBlack1" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "RookBlack1" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "RookBlack1" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "RookBlack1" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "RookBlack1" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "RookBlack1" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "RookBlack1" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "RookBlack1" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "RookBlack1" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "RookBlack1" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "RookBlack1" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "RookBlack1" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "RookBlack1" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "RookBlack1" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "RookBlack1" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "RookBlack1" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "RookBlack1" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "RookBlack1" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "RookBlack1" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "RookBlack1" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "RookBlack1" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "RookBlack1" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "RookBlack1" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "RookBlack1" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "RookBlack1" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "RookBlack1" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "RookBlack1" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "RookBlack1" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "RookBlack1" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "RookBlack1" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "RookBlack1" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "RookBlack1" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "RookBlack1" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "RookBlack1" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "RookBlack1" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "RookBlack1" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "RookBlack1" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "RookBlack1" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "RookBlack1" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "RookBlack1" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "RookBlack1" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "RookBlack1" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "RookBlack1" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "RookBlack1" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "RookBlack1" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "RookBlack1" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "RookBlack1" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "RookBlack1" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "RookBlack1" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "RookBlack1" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "RookBlack1" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "RookBlack1" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "RookBlack1" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "RookBlack1" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "RookBlack1" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "RookBlack1" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "RookBlack1" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "RookBlack1" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "RookBlack1" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "RookBlack1" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "RookBlack1" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "RookBlack1" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "RookBlack1" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "RookBlack1" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "RookBlack1" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "RookBlack1" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "RookBlack1" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "RookBlack1" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "RookBlack1" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "RookBlack1" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "RookBlack1" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionH(c) = "RookBlack1" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "RookBlack1" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "RookBlack1" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "RookBlack1" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "RookBlack1" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "RookBlack1" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "RookBlack1" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "RookBlack1" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "RookBlack1" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "RookBlack1" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "RookBlack1" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "RookBlack1" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "RookBlack1" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "RookBlack1" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "RookBlack1" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "RookBlack1" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "RookBlack1" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "RookBlack1" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "RookBlack2"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "RookBlack2" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "RookBlack2" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "RookBlack2" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "RookBlack2" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "RookBlack2" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "RookBlack2" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "RookBlack2" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "RookBlack2" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "RookBlack2" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "RookBlack2" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "RookBlack2" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "RookBlack2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "RookBlack2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "RookBlack2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "RookBlack2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "RookBlack2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "RookBlack2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "RookBlack2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "RookBlack2" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "RookBlack2" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "RookBlack2" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "RookBlack2" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "RookBlack2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "RookBlack2" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "RookBlack2" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "RookBlack2" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "RookBlack2" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "RookBlack2" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "RookBlack2" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "RookBlack2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "RookBlack2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "RookBlack2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "RookBlack2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "RookBlack2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "RookBlack2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "RookBlack2" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "RookBlack2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "RookBlack2" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "RookBlack2" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "RookBlack2" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "RookBlack2" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "RookBlack2" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "RookBlack2" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "RookBlack2" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "RookBlack2" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "RookBlack2" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "RookBlack2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "RookBlack2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "RookBlack2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "RookBlack2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "RookBlack2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "RookBlack2" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "RookBlack2" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "RookBlack2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "RookBlack2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "RookBlack2" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "RookBlack2" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "RookBlack2" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "RookBlack2" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "RookBlack2" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "RookBlack2" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "RookBlack2" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "RookBlack2" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "RookBlack2" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "RookBlack2" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "RookBlack2" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "RookBlack2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "RookBlack2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "RookBlack2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "RookBlack2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "RookBlack2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "RookBlack2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "RookBlack2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "RookBlack2" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "RookBlack2" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "RookBlack2" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "RookBlack2" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "RookBlack2" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "RookBlack2" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "RookBlack2" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "RookBlack2" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "RookBlack2" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "RookBlack2" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "RookBlack2" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "RookBlack2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "RookBlack2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "RookBlack2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "RookBlack2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "RookBlack2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "RookBlack2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "RookBlack2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "RookBlack2" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "RookBlack2" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "RookBlack2" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "RookBlack2" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "RookBlack2" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "RookBlack2" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "RookBlack2" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "RookBlack2" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "RookBlack2" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "RookBlack2" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "RookBlack2" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "RookBlack2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "RookBlack2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "RookBlack2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "RookBlack2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "RookBlack2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "RookBlack2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "RookBlack2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "RookBlack2" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "RookBlack2" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "RookBlack2" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "RookBlack2" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "RookBlack2" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "RookBlack2" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "RookBlack2" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "RookBlack2" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "RookBlack2" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "RookBlack2" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "RookBlack2" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "RookBlack2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "RookBlack2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "RookBlack2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "RookBlack2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "RookBlack2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "RookBlack2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "RookBlack2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionH(c) = "RookBlack2" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "RookBlack2" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "RookBlack2" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "RookBlack2" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "RookBlack2" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "RookBlack2" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "RookBlack2" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "RookBlack2" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "RookBlack2" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "RookBlack2" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "RookBlack2" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "RookBlack2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "RookBlack2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "RookBlack2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "RookBlack2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "RookBlack2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "RookBlack2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "RookBlack2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "PawnBlack1"
                Do
                    c = c + 1
                    o = c - 1
                    m = c + 1
                    FixIndice()
                    If PositionB(c) = "PawnBlack1" And PositionC(c) = "" Then
                        buttonC(c) = 1
                        If PositionB(c) = "PawnBlack1" And PositionD(c) = "" Then
                            buttonD(c) = 1
                        End If
                    End If

                    If PositionC(c) = "PawnBlack1" And PositionD(c) = "" Then
                        buttonD(c) = 1
                    End If

                    If PositionD(c) = "PawnBlack1" And PositionE(c) = "" Then
                        buttonE(c) = 1
                    End If

                    If PositionE(c) = "PawnBlack1" And PositionF(c) = "" Then
                        buttonF(c) = 1
                    End If

                    If PositionF(c) = "PawnBlack1" And PositionG(c) = "" Then
                        buttonG(c) = 1
                    End If
                    If PositionG(c) = "PawnBlack1" And PositionH(c) = "" Then
                        buttonH(c) = 1
                    End If

                    'kill sistem 

                    If PositionB(c) = "PawnBlack1" And PositionC(o) <> "" Then
                        KillC(o) = "True"
                    End If
                    If PositionB(c) = "PawnBlack1" And PositionC(m) <> "" Then
                        KillC(m) = "True"
                    End If

                    If PositionC(c) = "PawnBlack1" And PositionD(o) <> "" Then
                        KillD(o) = "True"
                    End If
                    If PositionC(c) = "PawnBlack1" And PositionD(m) <> "" Then
                        KillD(m) = "True"
                    End If

                    If PositionD(c) = "PawnBlack1" And PositionE(o) <> "" Then
                        KillE(o) = "True"
                    End If
                    If PositionD(c) = "PawnBlack1" And PositionE(m) <> "" Then
                        KillE(m) = "True"
                    End If

                    If PositionE(c) = "PawnBlack1" And PositionF(o) <> "" Then
                        KillF(o) = "True"
                    End If
                    If PositionE(c) = "PawnBlack1" And PositionF(m) <> "" Then
                        KillF(m) = "True"
                    End If

                    If PositionF(c) = "PawnBlack1" And PositionG(o) <> "" Then
                        KillG(o) = "True"
                    End If
                    If PositionF(c) = "PawnBlack1" And PositionG(m) <> "" Then
                        KillG(m) = "True"
                    End If

                    If PositionG(c) = "PawnBlack1" And PositionH(o) <> "" Then
                        KillH(o) = "True"
                    End If
                    If PositionG(c) = "PawnBlack1" And PositionH(m) <> "" Then
                        KillH(m) = "True"
                    End If
                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Queen"
                Do
                    c = c + 1
                    FixIndice()
                    If PositionH(c) = "P=Queen" Then

                    End If
                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Rook"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "P=Rook" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "P=Rook" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "P=Rook" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "P=Rook" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "P=Rook" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "P=Rook" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "P=Rook" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "P=Rook" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "P=Rook" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "P=Rook" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "P=Rook" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "P=Rook" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "P=Rook" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "P=Rook" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "P=Rook" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "P=Rook" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "P=Rook" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "P=Rook" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "P=Rook" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "P=Rook" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "P=Rook" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "P=Rook" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "P=Rook" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "P=Rook" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "P=Rook" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "P=Rook" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "P=Rook" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "P=Rook" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "P=Rook" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "P=Rook" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "P=Rook" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "P=Rook" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "P=Rook" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "P=Rook" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "P=Rook" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "P=Rook" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "P=Rook" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "P=Rook" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "P=Rook" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "P=Rook" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "P=Rook" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "P=Rook" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "P=Rook" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "P=Rook" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "P=Rook" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "P=Rook" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "P=Rook" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "P=Rook" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "P=Rook" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "P=Rook" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "P=Rook" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "P=Rook" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "P=Rook" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "P=Rook" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "P=Rook" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "P=Rook" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "P=Rook" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "P=Rook" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "P=Rook" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "P=Rook" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "P=Rook" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "P=Rook" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "P=Rook" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "P=Rook" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "P=Rook" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "P=Rook" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "P=Rook" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "P=Rook" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "P=Rook" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "P=Rook" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "P=Rook" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "P=Rook" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "P=Rook" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "P=Rook" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "P=Rook" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "P=Rook" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "P=Rook" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "P=Rook" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "P=Rook" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "P=Rook" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "P=Rook" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "P=Rook" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "P=Rook" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "P=Rook" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "P=Rook" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "P=Rook" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "P=Rook" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "P=Rook" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "P=Rook" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "P=Rook" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "P=Rook" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "P=Rook" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "P=Rook" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "P=Rook" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "P=Rook" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "P=Rook" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "P=Rook" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "P=Rook" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "P=Rook" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "P=Rook" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "P=Rook" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "P=Rook" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "P=Rook" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "P=Rook" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "P=Rook" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "P=Rook" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "P=Rook" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "P=Rook" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "P=Rook" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "P=Rook" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "P=Rook" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "P=Rook" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "P=Rook" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "P=Rook" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "P=Rook" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "P=Rook" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "P=Rook" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "P=Rook" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "P=Rook" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionH(c) = "P=Rook" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "P=Rook" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "P=Rook" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "P=Rook" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "P=Rook" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "P=Rook" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "P=Rook" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "P=Rook" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "P=Rook" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "P=Rook" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "P=Rook" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "P=Rook" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "P=Rook" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "P=Rook" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "P=Rook" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "P=Rook" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "P=Rook" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "P=Rook" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "PawnBlack2"
                Do
                    c = c + 1
                    o = c - 1
                    m = c + 1

                    FixIndice()
                    If PositionB(c) = "PawnBlack2" And PositionC(c) = "" Then
                        buttonC(c) = 1
                        If PositionB(c) = "PawnBlack2" And PositionD(c) = "" Then
                            buttonD(c) = 1
                        End If
                    End If

                    If PositionC(c) = "PawnBlack2" And PositionD(c) = "" Then
                        buttonD(c) = 1
                    End If

                    If PositionD(c) = "PawnBlack2" And PositionE(c) = "" Then
                        buttonE(c) = 1
                    End If

                    If PositionE(c) = "PawnBlack2" And PositionF(c) = "" Then
                        buttonF(c) = 1
                    End If

                    If PositionF(c) = "PawnBlack2" And PositionG(c) = "" Then
                        buttonG(c) = 1
                    End If
                    If PositionG(c) = "PawnBlack2" And PositionH(c) = "" Then
                        buttonH(c) = 1
                    End If

                    'kill sistem 

                    If PositionB(c) = "PawnBlack2" And PositionC(o) <> "" Then
                        KillC(o) = "True"
                    End If
                    If PositionB(c) = "PawnBlack2" And PositionC(m) <> "" Then
                        KillC(m) = "True"
                    End If

                    If PositionC(c) = "PawnBlack2" And PositionD(o) <> "" Then
                        KillD(o) = "True"
                    End If
                    If PositionC(c) = "PawnBlack2" And PositionD(m) <> "" Then
                        KillD(m) = "True"
                    End If

                    If PositionD(c) = "PawnBlack2" And PositionE(o) <> "" Then
                        KillE(o) = "True"
                    End If
                    If PositionD(c) = "PawnBlack2" And PositionE(m) <> "" Then
                        KillE(m) = "True"
                    End If

                    If PositionE(c) = "PawnBlack2" And PositionF(o) <> "" Then
                        KillF(o) = "True"
                    End If
                    If PositionE(c) = "PawnBlack2" And PositionF(m) <> "" Then
                        KillF(m) = "True"
                    End If

                    If PositionF(c) = "PawnBlack2" And PositionG(o) <> "" Then
                        KillG(o) = "True"
                    End If
                    If PositionF(c) = "PawnBlack2" And PositionG(m) <> "" Then
                        KillG(m) = "True"
                    End If

                    If PositionG(c) = "PawnBlack2" And PositionH(o) <> "" Then
                        KillH(o) = "True"
                    End If
                    If PositionG(c) = "PawnBlack2" And PositionH(m) <> "" Then
                        KillH(m) = "True"
                    End If
                    ' change


                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Queen2"
                Do
                    c = c + 1
                    FixIndice()
                    If PositionH(c) = "P=Queen2" Then

                    End If
                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Rook2"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "P=Rook2" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "P=Rook2" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "P=Rook2" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "P=Rook2" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "P=Rook2" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "P=Rook2" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "P=Rook2" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "P=Rook2" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "P=Rook2" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "P=Rook2" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "P=Rook2" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "P=Rook2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "P=Rook2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "P=Rook2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "P=Rook2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "P=Rook2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "P=Rook2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "P=Rook2" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "P=Rook2" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "P=Rook2" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "P=Rook2" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "P=Rook2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook2" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "P=Rook2" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "P=Rook2" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "P=Rook2" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "P=Rook2" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "P=Rook2" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "P=Rook2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "P=Rook2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "P=Rook2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "P=Rook2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "P=Rook2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "P=Rook2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook2" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "P=Rook2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "P=Rook2" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "P=Rook2" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "P=Rook2" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "P=Rook2" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "P=Rook2" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "P=Rook2" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "P=Rook2" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "P=Rook2" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "P=Rook2" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "P=Rook2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "P=Rook2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "P=Rook2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "P=Rook2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "P=Rook2" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "P=Rook2" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "P=Rook2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "P=Rook2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "P=Rook2" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "P=Rook2" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "P=Rook2" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "P=Rook2" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "P=Rook2" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "P=Rook2" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "P=Rook2" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "P=Rook2" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook2" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "P=Rook2" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "P=Rook2" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "P=Rook2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "P=Rook2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "P=Rook2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "P=Rook2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "P=Rook2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "P=Rook2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "P=Rook2" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "P=Rook2" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "P=Rook2" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "P=Rook2" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "P=Rook2" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "P=Rook2" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "P=Rook2" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook2" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "P=Rook2" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "P=Rook2" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "P=Rook2" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "P=Rook2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "P=Rook2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "P=Rook2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "P=Rook2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "P=Rook2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "P=Rook2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "P=Rook2" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "P=Rook2" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "P=Rook2" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "P=Rook2" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "P=Rook2" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "P=Rook2" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "P=Rook2" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "P=Rook2" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "P=Rook2" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "P=Rook2" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "P=Rook2" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "P=Rook2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "P=Rook2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "P=Rook2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "P=Rook2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "P=Rook2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "P=Rook2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "P=Rook2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "P=Rook2" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "P=Rook2" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "P=Rook2" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "P=Rook2" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "P=Rook2" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "P=Rook2" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "P=Rook2" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "P=Rook2" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "P=Rook2" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "P=Rook2" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "P=Rook2" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "P=Rook2" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "P=Rook2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "P=Rook2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "P=Rook2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "P=Rook2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "P=Rook2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "P=Rook2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionH(c) = "P=Rook2" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "P=Rook2" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "P=Rook2" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "P=Rook2" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "P=Rook2" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "P=Rook2" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "P=Rook2" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "P=Rook2" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "P=Rook2" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "P=Rook2" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "P=Rook2" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "P=Rook2" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "P=Rook2" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "P=Rook2" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "P=Rook2" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "P=Rook2" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "P=Rook2" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "P=Rook2" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "PawnBlack3"
                Do
                    c = c + 1
                    o = c - 1
                    m = c + 1

                    FixIndice()
                    If PositionB(c) = "PawnBlack3" And PositionC(c) = "" Then
                        buttonC(c) = 1
                        If PositionB(c) = "PawnBlack3" And PositionD(c) = "" Then
                            buttonD(c) = 1
                        End If
                    End If

                    If PositionC(c) = "PawnBlack3" And PositionD(c) = "" Then
                        buttonD(c) = 1
                    End If

                    If PositionD(c) = "PawnBlack3" And PositionE(c) = "" Then
                        buttonE(c) = 1
                    End If

                    If PositionE(c) = "PawnBlack3" And PositionF(c) = "" Then
                        buttonF(c) = 1
                    End If

                    If PositionF(c) = "PawnBlack3" And PositionG(c) = "" Then
                        buttonG(c) = 1
                    End If
                    If PositionG(c) = "PawnBlack3" And PositionH(c) = "" Then
                        buttonH(c) = 1
                    End If

                    'kill sistem 

                    If PositionB(c) = "PawnBlack3" And PositionC(o) <> "" Then
                        KillC(o) = "True"
                    End If
                    If PositionB(c) = "PawnBlack3" And PositionC(m) <> "" Then
                        KillC(m) = "True"
                    End If

                    If PositionC(c) = "PawnBlack3" And PositionD(o) <> "" Then
                        KillD(o) = "True"
                    End If
                    If PositionC(c) = "PawnBlack3" And PositionD(m) <> "" Then
                        KillD(m) = "True"
                    End If

                    If PositionD(c) = "PawnBlack3" And PositionE(o) <> "" Then
                        KillE(o) = "True"
                    End If
                    If PositionD(c) = "PawnBlack3" And PositionE(m) <> "" Then
                        KillE(m) = "True"
                    End If

                    If PositionE(c) = "PawnBlack3" And PositionF(o) <> "" Then
                        KillF(o) = "True"
                    End If
                    If PositionE(c) = "PawnBlack3" And PositionF(m) <> "" Then
                        KillF(m) = "True"
                    End If

                    If PositionF(c) = "PawnBlack3" And PositionG(o) <> "" Then
                        KillG(o) = "True"
                    End If
                    If PositionF(c) = "PawnBlack3" And PositionG(m) <> "" Then
                        KillG(m) = "True"
                    End If

                    If PositionG(c) = "PawnBlack3" And PositionH(o) <> "" Then
                        KillH(o) = "True"
                    End If
                    If PositionG(c) = "PawnBlack3" And PositionH(m) <> "" Then
                        KillH(m) = "True"
                    End If
                    ' change


                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Queen3"
                Do
                    c = c + 1
                    FixIndice()
                    If PositionH(c) = "P=Queen3" Then

                    End If
                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Rook3"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "P=Rook3" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "P=Rook3" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "P=Rook3" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "P=Rook3" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "P=Rook3" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "P=Rook3" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "P=Rook3" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "P=Rook3" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "P=Rook3" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "P=Rook3" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "P=Rook3" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "P=Rook3" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "P=Rook3" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "P=Rook3" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "P=Rook3" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook3" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "P=Rook3" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "P=Rook3" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "P=Rook3" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "P=Rook3" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "P=Rook3" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "P=Rook3" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "P=Rook3" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook3" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "P=Rook3" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "P=Rook3" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "P=Rook3" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "P=Rook3" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "P=Rook3" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "P=Rook3" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "P=Rook3" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "P=Rook3" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "P=Rook3" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "P=Rook3" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "P=Rook3" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook3" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "P=Rook3" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "P=Rook3" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "P=Rook3" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "P=Rook3" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "P=Rook3" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "P=Rook3" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "P=Rook3" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "P=Rook3" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "P=Rook3" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "P=Rook3" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "P=Rook3" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "P=Rook3" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook3" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "P=Rook3" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "P=Rook3" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "P=Rook3" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "P=Rook3" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "P=Rook3" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "P=Rook3" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "P=Rook3" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "P=Rook3" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "P=Rook3" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "P=Rook3" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "P=Rook3" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "P=Rook3" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "P=Rook3" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "P=Rook3" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook3" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "P=Rook3" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "P=Rook3" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook3" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "P=Rook3" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "P=Rook3" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "P=Rook3" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "P=Rook3" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "P=Rook3" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "P=Rook3" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "P=Rook3" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "P=Rook3" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "P=Rook3" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "P=Rook3" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "P=Rook3" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "P=Rook3" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "P=Rook3" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook3" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "P=Rook3" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "P=Rook3" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "P=Rook3" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook3" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "P=Rook3" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "P=Rook3" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "P=Rook3" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "P=Rook3" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "P=Rook3" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "P=Rook3" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "P=Rook3" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "P=Rook3" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "P=Rook3" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "P=Rook3" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "P=Rook3" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "P=Rook3" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "P=Rook3" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "P=Rook3" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "P=Rook3" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "P=Rook3" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "P=Rook3" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "P=Rook3" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "P=Rook3" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "P=Rook3" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "P=Rook3" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "P=Rook3" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "P=Rook3" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "P=Rook3" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "P=Rook3" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "P=Rook3" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "P=Rook3" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "P=Rook3" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "P=Rook3" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "P=Rook3" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "P=Rook3" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "P=Rook3" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "P=Rook3" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "P=Rook3" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "P=Rook3" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "P=Rook3" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "P=Rook3" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "P=Rook3" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "P=Rook3" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "P=Rook3" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "P=Rook3" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "P=Rook3" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionH(c) = "P=Rook3" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "P=Rook3" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "P=Rook3" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "P=Rook3" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "P=Rook3" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "P=Rook3" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "P=Rook3" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "P=Rook3" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "P=Rook3" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "P=Rook3" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "P=Rook3" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "P=Rook3" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "P=Rook3" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "P=Rook3" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "P=Rook3" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "P=Rook3" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "P=Rook3" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "P=Rook3" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "PawnBlack4"
                Do
                    c = c + 1
                    o = c - 1
                    m = c + 1

                    FixIndice()
                    If PositionB(c) = "PawnBlack4" And PositionC(c) = "" Then
                        buttonC(c) = 1
                        If PositionB(c) = "PawnBlack4" And PositionD(c) = "" Then
                            buttonD(c) = 1
                        End If
                    End If

                    If PositionC(c) = "PawnBlack4" And PositionD(c) = "" Then
                        buttonD(c) = 1
                    End If

                    If PositionD(c) = "PawnBlack4" And PositionE(c) = "" Then
                        buttonE(c) = 1
                    End If

                    If PositionE(c) = "PawnBlack4" And PositionF(c) = "" Then
                        buttonF(c) = 1
                    End If

                    If PositionF(c) = "PawnBlack4" And PositionG(c) = "" Then
                        buttonG(c) = 1
                    End If
                    If PositionG(c) = "PawnBlack4" And PositionH(c) = "" Then
                        buttonH(c) = 1
                    End If

                    'kill sistem 

                    If PositionB(c) = "PawnBlack4" And PositionC(o) <> "" Then
                        KillC(o) = "True"
                    End If
                    If PositionB(c) = "PawnBlack4" And PositionC(m) <> "" Then
                        KillC(m) = "True"
                    End If

                    If PositionC(c) = "PawnBlack4" And PositionD(o) <> "" Then
                        KillD(o) = "True"
                    End If
                    If PositionC(c) = "PawnBlack4" And PositionD(m) <> "" Then
                        KillD(m) = "True"
                    End If

                    If PositionD(c) = "PawnBlack4" And PositionE(o) <> "" Then
                        KillE(o) = "True"
                    End If
                    If PositionD(c) = "PawnBlack4" And PositionE(m) <> "" Then
                        KillE(m) = "True"
                    End If

                    If PositionE(c) = "PawnBlack4" And PositionF(o) <> "" Then
                        KillF(o) = "True"
                    End If
                    If PositionE(c) = "PawnBlack4" And PositionF(m) <> "" Then
                        KillF(m) = "True"
                    End If

                    If PositionF(c) = "PawnBlack4" And PositionG(o) <> "" Then
                        KillG(o) = "True"
                    End If
                    If PositionF(c) = "PawnBlack4" And PositionG(m) <> "" Then
                        KillG(m) = "True"
                    End If

                    If PositionG(c) = "PawnBlack4" And PositionH(o) <> "" Then
                        KillH(o) = "True"
                    End If
                    If PositionG(c) = "PawnBlack4" And PositionH(m) <> "" Then
                        KillH(m) = "True"
                    End If
                    ' change


                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Queen4"
                Do
                    c = c + 1
                    FixIndice()
                    If PositionH(c) = "P=Queen4" Then

                    End If
                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Rook4"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "P=Rook4" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "P=Rook4" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "P=Rook4" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "P=Rook4" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "P=Rook4" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "P=Rook4" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "P=Rook4" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "P=Rook4" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "P=Rook4" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "P=Rook4" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "P=Rook4" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "P=Rook4" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "P=Rook4" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "P=Rook4" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "P=Rook4" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook4" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "P=Rook4" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "P=Rook4" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "P=Rook4" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "P=Rook4" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "P=Rook4" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "P=Rook4" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "P=Rook4" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook4" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "P=Rook4" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "P=Rook4" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "P=Rook4" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "P=Rook4" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "P=Rook4" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "P=Rook4" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "P=Rook4" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "P=Rook4" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "P=Rook4" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "P=Rook4" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "P=Rook4" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook4" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "P=Rook4" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "P=Rook4" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "P=Rook4" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "P=Rook4" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "P=Rook4" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "P=Rook4" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "P=Rook4" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "P=Rook4" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "P=Rook4" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "P=Rook4" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "P=Rook4" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "P=Rook4" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook4" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "P=Rook4" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "P=Rook4" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "P=Rook4" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "P=Rook4" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "P=Rook4" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "P=Rook4" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "P=Rook4" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "P=Rook4" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "P=Rook4" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "P=Rook4" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "P=Rook4" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "P=Rook4" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "P=Rook4" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "P=Rook4" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook4" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "P=Rook4" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "P=Rook4" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook4" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "P=Rook4" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "P=Rook4" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "P=Rook4" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "P=Rook4" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "P=Rook4" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "P=Rook4" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "P=Rook4" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "P=Rook4" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "P=Rook4" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "P=Rook4" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "P=Rook4" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "P=Rook4" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "P=Rook4" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook4" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "P=Rook4" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "P=Rook4" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "P=Rook4" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook4" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "P=Rook4" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "P=Rook4" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "P=Rook4" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "P=Rook4" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "P=Rook4" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "P=Rook4" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "P=Rook4" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "P=Rook4" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "P=Rook4" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "P=Rook4" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "P=Rook4" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "P=Rook4" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "P=Rook4" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "P=Rook4" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "P=Rook4" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "P=Rook4" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "P=Rook4" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "P=Rook4" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "P=Rook4" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "P=Rook4" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "P=Rook4" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "P=Rook4" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "P=Rook4" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "P=Rook4" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "P=Rook4" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "P=Rook4" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "P=Rook4" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "P=Rook4" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "P=Rook4" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "P=Rook4" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "P=Rook4" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "P=Rook4" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "P=Rook4" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "P=Rook4" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "P=Rook4" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "P=Rook4" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "P=Rook4" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "P=Rook4" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "P=Rook4" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "P=Rook4" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "P=Rook4" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "P=Rook4" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionH(c) = "P=Rook4" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "P=Rook4" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "P=Rook4" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "P=Rook4" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "P=Rook4" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "P=Rook4" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "P=Rook4" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "P=Rook4" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "P=Rook4" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "P=Rook4" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "P=Rook4" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "P=Rook4" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "P=Rook4" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "P=Rook4" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "P=Rook4" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "P=Rook4" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "P=Rook4" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "P=Rook4" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "PawnBlack5"
                Do
                    c = c + 1
                    o = c - 1
                    m = c + 1

                    FixIndice()
                    If PositionB(c) = "PawnBlack5" And PositionC(c) = "" Then
                        buttonC(c) = 1
                        If PositionB(c) = "PawnBlack5" And PositionD(c) = "" Then
                            buttonD(c) = 1
                        End If
                    End If

                    If PositionC(c) = "PawnBlack5" And PositionD(c) = "" Then
                        buttonD(c) = 1
                    End If

                    If PositionD(c) = "PawnBlack5" And PositionE(c) = "" Then
                        buttonE(c) = 1
                    End If

                    If PositionE(c) = "PawnBlack5" And PositionF(c) = "" Then
                        buttonF(c) = 1
                    End If

                    If PositionF(c) = "PawnBlack5" And PositionG(c) = "" Then
                        buttonG(c) = 1
                    End If
                    If PositionG(c) = "PawnBlack5" And PositionH(c) = "" Then
                        buttonH(c) = 1
                    End If

                    'kill sistem 

                    If PositionB(c) = "PawnBlack5" And PositionC(o) <> "" Then
                        KillC(o) = "True"
                    End If
                    If PositionB(c) = "PawnBlack5" And PositionC(m) <> "" Then
                        KillC(m) = "True"
                    End If

                    If PositionC(c) = "PawnBlack5" And PositionD(o) <> "" Then
                        KillD(o) = "True"
                    End If
                    If PositionC(c) = "PawnBlack5" And PositionD(m) <> "" Then
                        KillD(m) = "True"
                    End If

                    If PositionD(c) = "PawnBlack5" And PositionE(o) <> "" Then
                        KillE(o) = "True"
                    End If
                    If PositionD(c) = "PawnBlack5" And PositionE(m) <> "" Then
                        KillE(m) = "True"
                    End If

                    If PositionE(c) = "PawnBlack5" And PositionF(o) <> "" Then
                        KillF(o) = "True"
                    End If
                    If PositionE(c) = "PawnBlack5" And PositionF(m) <> "" Then
                        KillF(m) = "True"
                    End If

                    If PositionF(c) = "PawnBlack5" And PositionG(o) <> "" Then
                        KillG(o) = "True"
                    End If
                    If PositionF(c) = "PawnBlack5" And PositionG(m) <> "" Then
                        KillG(m) = "True"
                    End If

                    If PositionG(c) = "PawnBlack5" And PositionH(o) <> "" Then
                        KillH(o) = "True"
                    End If
                    If PositionG(c) = "PawnBlack5" And PositionH(m) <> "" Then
                        KillH(m) = "True"
                    End If
                    ' change


                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Queen5"
                Do
                    c = c + 1
                    FixIndice()
                    If PositionH(c) = "P=Queen5" Then

                    End If
                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Rook5"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "P=Rook5" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "P=Rook5" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "P=Rook5" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "P=Rook5" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "P=Rook5" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "P=Rook5" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "P=Rook5" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "P=Rook5" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "P=Rook5" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "P=Rook5" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "P=Rook5" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "P=Rook5" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "P=Rook5" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "P=Rook5" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "P=Rook5" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook5" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "P=Rook5" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "P=Rook5" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "P=Rook5" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "P=Rook5" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "P=Rook5" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "P=Rook5" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "P=Rook5" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook5" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "P=Rook5" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "P=Rook5" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "P=Rook5" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "P=Rook5" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "P=Rook5" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "P=Rook5" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "P=Rook5" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "P=Rook5" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "P=Rook5" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "P=Rook5" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "P=Rook5" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook5" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "P=Rook5" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "P=Rook5" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "P=Rook5" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "P=Rook5" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "P=Rook5" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "P=Rook5" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "P=Rook5" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "P=Rook5" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "P=Rook5" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "P=Rook5" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "P=Rook5" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "P=Rook5" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook5" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "P=Rook5" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "P=Rook5" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "P=Rook5" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "P=Rook5" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "P=Rook5" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "P=Rook5" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "P=Rook5" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "P=Rook5" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "P=Rook5" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "P=Rook5" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "P=Rook5" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "P=Rook5" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "P=Rook5" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "P=Rook5" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook5" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "P=Rook5" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "P=Rook5" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook5" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "P=Rook5" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "P=Rook5" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "P=Rook5" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "P=Rook5" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "P=Rook5" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "P=Rook5" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "P=Rook5" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "P=Rook5" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "P=Rook5" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "P=Rook5" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "P=Rook5" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "P=Rook5" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "P=Rook5" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook5" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "P=Rook5" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "P=Rook5" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "P=Rook5" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook5" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "P=Rook5" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "P=Rook5" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "P=Rook5" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "P=Rook5" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "P=Rook5" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "P=Rook5" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "P=Rook5" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "P=Rook5" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "P=Rook5" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "P=Rook5" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "P=Rook5" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "P=Rook5" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "P=Rook5" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "P=Rook5" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "P=Rook5" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "P=Rook5" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "P=Rook5" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "P=Rook5" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "P=Rook5" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "P=Rook5" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "P=Rook5" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "P=Rook5" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "P=Rook5" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "P=Rook5" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "P=Rook5" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "P=Rook5" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "P=Rook5" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "P=Rook5" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "P=Rook5" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "P=Rook5" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "P=Rook5" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "P=Rook5" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "P=Rook5" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "P=Rook5" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "P=Rook5" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "P=Rook5" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "P=Rook5" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "P=Rook5" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "P=Rook5" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "P=Rook5" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "P=Rook5" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "P=Rook5" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionH(c) = "P=Rook5" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "P=Rook5" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "P=Rook5" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "P=Rook5" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "P=Rook5" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "P=Rook5" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "P=Rook5" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "P=Rook5" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "P=Rook5" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "P=Rook5" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "P=Rook5" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "P=Rook5" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "P=Rook5" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "P=Rook5" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "P=Rook5" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "P=Rook5" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "P=Rook5" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "P=Rook5" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "PawnBlack6"
                Do
                    c = c + 1
                    o = c - 1
                    m = c + 1

                    FixIndice()
                    If PositionB(c) = "PawnBlack6" And PositionC(c) = "" Then
                        buttonC(c) = 1
                        If PositionB(c) = "PawnBlack6" And PositionD(c) = "" Then
                            buttonD(c) = 1
                        End If
                    End If

                    If PositionC(c) = "PawnBlack6" And PositionD(c) = "" Then
                        buttonD(c) = 1
                    End If

                    If PositionD(c) = "PawnBlack6" And PositionE(c) = "" Then
                        buttonE(c) = 1
                    End If

                    If PositionE(c) = "PawnBlack6" And PositionF(c) = "" Then
                        buttonF(c) = 1
                    End If

                    If PositionF(c) = "PawnBlack6" And PositionG(c) = "" Then
                        buttonG(c) = 1
                    End If
                    If PositionG(c) = "PawnBlack6" And PositionH(c) = "" Then
                        buttonH(c) = 1
                    End If

                    'kill sistem 

                    If PositionB(c) = "PawnBlack6" And PositionC(o) <> "" Then
                        KillC(o) = "True"
                    End If
                    If PositionB(c) = "PawnBlack6" And PositionC(m) <> "" Then
                        KillC(m) = "True"
                    End If

                    If PositionC(c) = "PawnBlack6" And PositionD(o) <> "" Then
                        KillD(o) = "True"
                    End If
                    If PositionC(c) = "PawnBlack6" And PositionD(m) <> "" Then
                        KillD(m) = "True"
                    End If

                    If PositionD(c) = "PawnBlack6" And PositionE(o) <> "" Then
                        KillE(o) = "True"
                    End If
                    If PositionD(c) = "PawnBlack6" And PositionE(m) <> "" Then
                        KillE(m) = "True"
                    End If

                    If PositionE(c) = "PawnBlack6" And PositionF(o) <> "" Then
                        KillF(o) = "True"
                    End If
                    If PositionE(c) = "PawnBlack6" And PositionF(m) <> "" Then
                        KillF(m) = "True"
                    End If

                    If PositionF(c) = "PawnBlack6" And PositionG(o) <> "" Then
                        KillG(o) = "True"
                    End If
                    If PositionF(c) = "PawnBlack6" And PositionG(m) <> "" Then
                        KillG(m) = "True"
                    End If

                    If PositionG(c) = "PawnBlack6" And PositionH(o) <> "" Then
                        KillH(o) = "True"
                    End If
                    If PositionG(c) = "PawnBlack6" And PositionH(m) <> "" Then
                        KillH(m) = "True"
                    End If
                    ' change


                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Queen6"
                Do
                    c = c + 1
                    FixIndice()
                    If PositionH(c) = "P=Queen6" Then

                    End If
                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Rook6"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "P=Rook6" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "P=Rook6" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "P=Rook6" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "P=Rook6" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "P=Rook6" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "P=Rook6" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "P=Rook6" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "P=Rook6" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "P=Rook6" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "P=Rook6" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "P=Rook6" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "P=Rook6" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "P=Rook6" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "P=Rook6" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "P=Rook6" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook6" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "P=Rook6" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "P=Rook6" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "P=Rook6" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "P=Rook6" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "P=Rook6" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "P=Rook6" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "P=Rook6" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook6" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "P=Rook6" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "P=Rook6" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "P=Rook6" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "P=Rook6" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "P=Rook6" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "P=Rook6" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "P=Rook6" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "P=Rook6" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "P=Rook6" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "P=Rook6" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "P=Rook6" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook6" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "P=Rook6" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "P=Rook6" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "P=Rook6" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "P=Rook6" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "P=Rook6" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "P=Rook6" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "P=Rook6" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "P=Rook6" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "P=Rook6" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "P=Rook6" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "P=Rook6" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "P=Rook6" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook6" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "P=Rook6" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "P=Rook6" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "P=Rook6" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "P=Rook6" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "P=Rook6" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "P=Rook6" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "P=Rook6" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "P=Rook6" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "P=Rook6" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "P=Rook6" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "P=Rook6" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "P=Rook6" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "P=Rook6" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "P=Rook6" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook6" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "P=Rook6" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "P=Rook6" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook6" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "P=Rook6" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "P=Rook6" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "P=Rook6" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "P=Rook6" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "P=Rook6" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "P=Rook6" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "P=Rook6" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "P=Rook6" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "P=Rook6" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "P=Rook6" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "P=Rook6" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "P=Rook6" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "P=Rook6" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook6" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "P=Rook6" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "P=Rook6" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "P=Rook6" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook6" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "P=Rook6" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "P=Rook6" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "P=Rook6" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "P=Rook6" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "P=Rook6" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "P=Rook6" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "P=Rook6" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "P=Rook6" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "P=Rook6" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "P=Rook6" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "P=Rook6" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "P=Rook6" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "P=Rook6" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "P=Rook6" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "P=Rook6" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "P=Rook6" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "P=Rook6" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "P=Rook6" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "P=Rook6" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "P=Rook6" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "P=Rook6" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "P=Rook6" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "P=Rook6" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "P=Rook6" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "P=Rook6" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "P=Rook6" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "P=Rook6" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "P=Rook6" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "P=Rook6" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "P=Rook6" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "P=Rook6" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "P=Rook6" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "P=Rook6" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "P=Rook6" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "P=Rook6" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "P=Rook6" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "P=Rook6" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "P=Rook6" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "P=Rook6" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "P=Rook6" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "P=Rook6" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "P=Rook6" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionH(c) = "P=Rook6" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "P=Rook6" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "P=Rook6" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "P=Rook6" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "P=Rook6" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "P=Rook6" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "P=Rook6" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "P=Rook6" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "P=Rook6" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "P=Rook6" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "P=Rook6" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "P=Rook6" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "P=Rook6" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "P=Rook6" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "P=Rook6" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "P=Rook6" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "P=Rook6" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "P=Rook6" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "PawnBlack7"
                Do
                    c = c + 1
                    o = c - 1
                    m = c + 1

                    FixIndice()
                    If PositionB(c) = "PawnBlack7" And PositionC(c) = "" Then
                        buttonC(c) = 1
                        If PositionB(c) = "PawnBlack7" And PositionD(c) = "" Then
                            buttonD(c) = 1
                        End If
                    End If

                    If PositionC(c) = "PawnBlack7" And PositionD(c) = "" Then
                        buttonD(c) = 1
                    End If

                    If PositionD(c) = "PawnBlack7" And PositionE(c) = "" Then
                        buttonE(c) = 1
                    End If

                    If PositionE(c) = "PawnBlack7" And PositionF(c) = "" Then
                        buttonF(c) = 1
                    End If

                    If PositionF(c) = "PawnBlack7" And PositionG(c) = "" Then
                        buttonG(c) = 1
                    End If
                    If PositionG(c) = "PawnBlack7" And PositionH(c) = "" Then
                        buttonH(c) = 1
                    End If

                    'kill sistem 

                    If PositionB(c) = "PawnBlack7" And PositionC(o) <> "" Then
                        KillC(o) = "True"
                    End If
                    If PositionB(c) = "PawnBlack7" And PositionC(m) <> "" Then
                        KillC(m) = "True"
                    End If

                    If PositionC(c) = "PawnBlack7" And PositionD(o) <> "" Then
                        KillD(o) = "True"
                    End If
                    If PositionC(c) = "PawnBlack7" And PositionD(m) <> "" Then
                        KillD(m) = "True"
                    End If

                    If PositionD(c) = "PawnBlack7" And PositionE(o) <> "" Then
                        KillE(o) = "True"
                    End If
                    If PositionD(c) = "PawnBlack7" And PositionE(m) <> "" Then
                        KillE(m) = "True"
                    End If

                    If PositionE(c) = "PawnBlack7" And PositionF(o) <> "" Then
                        KillF(o) = "True"
                    End If
                    If PositionE(c) = "PawnBlack7" And PositionF(m) <> "" Then
                        KillF(m) = "True"
                    End If

                    If PositionF(c) = "PawnBlack7" And PositionG(o) <> "" Then
                        KillG(o) = "True"
                    End If
                    If PositionF(c) = "PawnBlack7" And PositionG(m) <> "" Then
                        KillG(m) = "True"
                    End If

                    If PositionG(c) = "PawnBlack7" And PositionH(o) <> "" Then
                        KillH(o) = "True"
                    End If
                    If PositionG(c) = "PawnBlack7" And PositionH(m) <> "" Then
                        KillH(m) = "True"
                    End If
                    ' change


                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Queen7"
                Do
                    c = c + 1
                    FixIndice()
                    If PositionH(c) = "P=Queen7" Then

                    End If
                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Rook7"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "P=Rook7" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "P=Rook7" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "P=Rook7" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "P=Rook7" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "P=Rook7" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "P=Rook7" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "P=Rook7" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "P=Rook7" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "P=Rook7" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "P=Rook7" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "P=Rook7" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "P=Rook7" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "P=Rook7" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "P=Rook7" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "P=Rook7" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook7" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "P=Rook7" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "P=Rook7" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "P=Rook7" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "P=Rook7" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "P=Rook7" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "P=Rook7" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "P=Rook7" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook7" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "P=Rook7" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "P=Rook7" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "P=Rook7" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "P=Rook7" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "P=Rook7" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "P=Rook7" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "P=Rook7" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "P=Rook7" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "P=Rook7" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "P=Rook7" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "P=Rook7" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook7" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "P=Rook7" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "P=Rook7" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "P=Rook7" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "P=Rook7" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "P=Rook7" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "P=Rook7" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "P=Rook7" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "P=Rook7" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "P=Rook7" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "P=Rook7" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "P=Rook7" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "P=Rook7" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook7" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "P=Rook7" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "P=Rook7" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "P=Rook7" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "P=Rook7" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "P=Rook7" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "P=Rook7" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "P=Rook7" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "P=Rook7" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "P=Rook7" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "P=Rook7" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "P=Rook7" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "P=Rook7" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "P=Rook7" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "P=Rook7" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook7" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "P=Rook7" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "P=Rook7" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook7" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "P=Rook7" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "P=Rook7" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "P=Rook7" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "P=Rook7" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "P=Rook7" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "P=Rook7" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "P=Rook7" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "P=Rook7" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "P=Rook7" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "P=Rook7" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "P=Rook7" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "P=Rook7" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "P=Rook7" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook7" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "P=Rook7" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "P=Rook7" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "P=Rook7" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook7" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "P=Rook7" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "P=Rook7" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "P=Rook7" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "P=Rook7" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "P=Rook7" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "P=Rook7" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "P=Rook7" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "P=Rook7" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "P=Rook7" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "P=Rook7" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "P=Rook7" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "P=Rook7" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "P=Rook7" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "P=Rook7" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "P=Rook7" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "P=Rook7" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "P=Rook7" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "P=Rook7" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "P=Rook7" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "P=Rook7" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "P=Rook7" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "P=Rook7" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "P=Rook7" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "P=Rook7" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "P=Rook7" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "P=Rook7" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "P=Rook7" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "P=Rook7" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "P=Rook7" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "P=Rook7" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "P=Rook7" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "P=Rook7" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "P=Rook7" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "P=Rook7" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "P=Rook7" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "P=Rook7" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "P=Rook7" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "P=Rook7" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "P=Rook7" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "P=Rook7" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "P=Rook7" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "P=Rook7" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionH(c) = "P=Rook7" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "P=Rook7" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "P=Rook7" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "P=Rook7" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "P=Rook7" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "P=Rook7" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "P=Rook7" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "P=Rook7" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "P=Rook7" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "P=Rook7" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "P=Rook7" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "P=Rook7" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "P=Rook7" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "P=Rook7" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "P=Rook7" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "P=Rook7" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "P=Rook7" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "P=Rook7" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "PawnBlack8"
                Do
                    c = c + 1
                    o = c - 1
                    m = c + 1

                    FixIndice()
                    If PositionB(c) = "PawnBlack8" And PositionC(c) = "" Then
                        buttonC(c) = 1
                        If PositionB(c) = "PawnBlack8" And PositionD(c) = "" Then
                            buttonD(c) = 1
                        End If
                    End If

                    If PositionC(c) = "PawnBlack8" And PositionD(c) = "" Then
                        buttonD(c) = 1
                    End If

                    If PositionD(c) = "PawnBlack8" And PositionE(c) = "" Then
                        buttonE(c) = 1
                    End If

                    If PositionE(c) = "PawnBlack8" And PositionF(c) = "" Then
                        buttonF(c) = 1
                    End If

                    If PositionF(c) = "PawnBlack8" And PositionG(c) = "" Then
                        buttonG(c) = 1
                    End If
                    If PositionG(c) = "PawnBlack8" And PositionH(c) = "" Then
                        buttonH(c) = 1
                    End If

                    'kill sistem 

                    If PositionB(c) = "PawnBlack8" And PositionC(o) <> "" Then
                        KillC(o) = "True"
                    End If
                    If PositionB(c) = "PawnBlack8" And PositionC(m) <> "" Then
                        KillC(m) = "True"
                    End If

                    If PositionC(c) = "PawnBlack8" And PositionD(o) <> "" Then
                        KillD(o) = "True"
                    End If
                    If PositionC(c) = "PawnBlack8" And PositionD(m) <> "" Then
                        KillD(m) = "True"
                    End If

                    If PositionD(c) = "PawnBlack8" And PositionE(o) <> "" Then
                        KillE(o) = "True"
                    End If
                    If PositionD(c) = "PawnBlack8" And PositionE(m) <> "" Then
                        KillE(m) = "True"
                    End If

                    If PositionE(c) = "PawnBlack8" And PositionF(o) <> "" Then
                        KillF(o) = "True"
                    End If
                    If PositionE(c) = "PawnBlack8" And PositionF(m) <> "" Then
                        KillF(m) = "True"
                    End If

                    If PositionF(c) = "PawnBlack8" And PositionG(o) <> "" Then
                        KillG(o) = "True"
                    End If
                    If PositionF(c) = "PawnBlack8" And PositionG(m) <> "" Then
                        KillG(m) = "True"
                    End If

                    If PositionG(c) = "PawnBlack8" And PositionH(o) <> "" Then
                        KillH(o) = "True"
                    End If
                    If PositionG(c) = "PawnBlack8" And PositionH(m) <> "" Then
                        KillH(m) = "True"
                    End If
                    ' change


                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Queen8"
                Do
                    c = c + 1
                    FixIndice()
                    If PositionH(c) = "P=Queen8" Then

                    End If
                Loop Until c > 7 Or Check = 1
                Check = 0
                c = 0
            Case "P=Rook8"
                Do
                    c = c + 1
                    For y = 1 To 8
                        o = c + y
                        m = c - y
                        u = m - 1
                        n = o + 1
                        FixIndice()

                        If PositionA(c) = "P=Rook8" And PositionA(o) = "" And Check = 0 Then
                            buttonA(o) = 1
                            KillA(n) = "True"
                        ElseIf PositionA(c) = "P=Rook8" And PositionA(o) <> "" And Check = 0 Then
                            Check = 1
                            KillA(o) = "True"
                        End If
                        If PositionA(c) = "P=Rook8" And PositionA(m) = "" And Check2 = 0 Then
                            buttonA(m) = 1
                            KillA(u) = "True"
                        ElseIf PositionA(c) = "P=Rook8" And PositionA(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillA(m) = "True"
                        End If

                        If PositionA(c) = "P=Rook8" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionA(c) = "P=Rook8" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionA(c) = "P=Rook8" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionA(c) = "P=Rook8" And PositionE(c) = "" Then
                                        buttonE(c) = 1
                                        If PositionA(c) = "P=Rook8" And PositionF(c) = "" Then
                                            buttonF(c) = 1
                                            If PositionA(c) = "P=Rook8" And PositionG(c) = "" Then
                                                buttonG(c) = 1
                                                If PositionA(c) = "P=Rook8" And PositionH(c) = "" Then
                                                    buttonH(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                            Check = 1
                        End If
                        If PositionA(c) = "P=Rook8" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionA(c) = "P=Rook8" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionA(c) = "P=Rook8" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionA(c) = "P=Rook8" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook8" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionA(c) = "P=Rook8" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionA(c) = "P=Rook8" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If

                        If PositionB(c) = "P=Rook8" And PositionB(o) = "" And Check = 0 Then
                            buttonB(o) = 1
                            KillB(n) = "True"
                        ElseIf PositionB(c) = "P=Rook8" And PositionB(o) <> "" And Check = 0 Then
                            Check = 1
                            KillB(o) = "True"
                        End If
                        If PositionB(c) = "P=Rook8" And PositionB(m) = "" And Check2 = 0 Then
                            buttonB(m) = 1
                            KillB(u) = "True"
                        ElseIf PositionB(c) = "P=Rook8" And PositionB(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillB(m) = "True"
                        End If
                        If PositionB(c) = "P=Rook8" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook8" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionB(c) = "P=Rook8" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionB(c) = "P=Rook8" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionB(c) = "P=Rook8" And PositionF(c) = "" Then
                                        buttonF(c) = 1
                                        If PositionB(c) = "P=Rook8" And PositionG(c) = "" Then
                                            buttonG(c) = 1
                                            If PositionB(c) = "P=Rook8" And PositionH(c) = "" Then
                                                buttonH(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionB(c) = "P=Rook8" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionB(c) = "P=Rook8" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionB(c) = "P=Rook8" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionB(c) = "P=Rook8" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionB(c) = "P=Rook8" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionB(c) = "P=Rook8" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionB(c) = "P=Rook8" And PositionA(c) = "" Then
                            buttonA(c) = 1
                        End If
                        If PositionB(c) = "P=Rook8" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If



                        If PositionC(c) = "P=Rook8" And PositionC(o) = "" And Check = 0 Then
                            buttonC(o) = 1
                            KillC(n) = "True"
                        ElseIf PositionC(c) = "P=Rook8" And PositionC(o) <> "" And Check = 0 Then
                            Check = 1
                            KillC(o) = "True"
                        End If
                        If PositionC(c) = "P=Rook8" And PositionC(m) = "" And Check2 = 0 Then
                            buttonC(m) = 1
                            KillC(u) = "True"
                        ElseIf PositionC(c) = "P=Rook8" And PositionC(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillC(m) = "True"
                        End If
                        If PositionC(c) = "P=Rook8" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionC(c) = "P=Rook8" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionC(c) = "P=Rook8" And PositionF(c) = "" Then
                                    buttonF(c) = 1
                                    If PositionC(c) = "P=Rook8" And PositionG(c) = "" Then
                                        buttonG(c) = 1
                                        If PositionC(c) = "P=Rook8" And PositionH(c) = "" Then
                                            buttonH(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionC(c) = "P=Rook8" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionC(c) = "P=Rook8" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionA(c) = "P=Rook8" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionC(c) = "P=Rook8" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionC(c) = "P=Rook8" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionC(c) = "P=Rook8" And PositionB(c) = "" Then
                            buttonB(c) = 1
                            If PositionC(c) = "P=Rook8" And PositionA(c) = "" Then
                                buttonA(c) = 1
                            End If
                        End If
                        If PositionC(c) = "P=Rook8" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionC(c) = "P=Rook8" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If


                        If PositionD(c) = "P=Rook8" And PositionD(o) = "" And Check = 0 Then
                            buttonD(o) = 1
                            KillD(n) = "True"
                        ElseIf PositionD(c) = "P=Rook8" And PositionD(o) <> "" And Check = 0 Then
                            Check = 1
                            KillD(o) = "True"
                        End If
                        If PositionD(c) = "P=Rook8" And PositionD(m) = "" And Check2 = 0 Then
                            buttonD(m) = 1
                            KillD(u) = "True"
                        ElseIf PositionD(c) = "P=Rook8" And PositionD(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillD(m) = "True"
                        End If
                        If PositionD(c) = "P=Rook8" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionD(c) = "P=Rook8" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionD(c) = "P=Rook8" And PositionG(c) = "" Then
                                    buttonG(c) = 1
                                    If PositionD(c) = "P=Rook8" And PositionH(c) = "" Then
                                        buttonH(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook8" And PositionC(c) = "" Then
                            buttonC(c) = 1
                            If PositionD(c) = "P=Rook8" And PositionB(c) = "" Then
                                buttonB(c) = 1
                                If PositionD(c) = "P=Rook8" And PositionA(c) = "" Then
                                    buttonA(c) = 1
                                End If
                            End If
                        End If
                        If PositionD(c) = "P=Rook8" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionD(c) = "P=Rook8" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionD(c) = "P=Rook8" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionD(c) = "P=Rook8" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionD(c) = "P=Rook8" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionD(c) = "P=Rook8" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionD(c) = "P=Rook8" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionE(c) = "P=Rook8" And PositionE(o) = "" And Check = 0 Then
                            buttonE(o) = 1
                            KillE(n) = "True"
                        ElseIf PositionE(c) = "P=Rook8" And PositionE(o) <> "" And Check = 0 Then
                            Check = 1
                            KillE(o) = "True"
                        End If
                        If PositionE(c) = "P=Rook8" And PositionE(m) = "" And Check2 = 0 Then
                            buttonE(m) = 1
                            KillE(u) = "True"
                        ElseIf PositionE(c) = "P=Rook8" And PositionE(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillE(m) = "True"
                        End If
                        If PositionE(c) = "P=Rook8" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionE(c) = "P=Rook8" And PositionG(c) = "" Then
                                buttonG(c) = 1
                                If PositionE(c) = "P=Rook8" And PositionH(c) = "" Then
                                    buttonH(c) = 1
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook8" And PositionD(c) = "" Then
                            buttonD(c) = 1
                            If PositionE(c) = "P=Rook8" And PositionC(c) = "" Then
                                buttonC(c) = 1
                                If PositionE(c) = "P=Rook8" And PositionB(c) = "" Then
                                    buttonB(c) = 1
                                    If PositionE(c) = "P=Rook8" And PositionA(c) = "" Then
                                        buttonA(c) = 1
                                    End If
                                End If
                            End If
                        End If
                        If PositionE(c) = "P=Rook8" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionE(c) = "P=Rook8" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionE(c) = "P=Rook8" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionE(c) = "P=Rook8" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionE(c) = "P=Rook8" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionE(c) = "P=Rook8" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionE(c) = "P=Rook8" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionF(c) = "P=Rook8" And PositionF(o) = "" And Check = 0 Then
                            buttonF(o) = 1
                            KillF(n) = "True"
                        ElseIf PositionF(c) = "P=Rook8" And PositionF(o) <> "" And Check = 0 Then
                            Check = 1
                            KillF(o) = "True"
                        End If
                        If PositionF(c) = "P=Rook8" And PositionF(m) = "" And Check2 = 0 Then
                            buttonF(m) = 1
                            KillF(u) = "True"
                        ElseIf PositionF(c) = "P=Rook8" And PositionF(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillF(m) = "True"
                        End If
                        If PositionF(c) = "P=Rook8" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionF(c) = "P=Rook8" And PositionH(c) = "" Then
                                buttonH(c) = 1
                            End If
                        End If
                        If PositionF(c) = "P=Rook8" And PositionE(c) = "" Then
                            buttonE(c) = 1
                            If PositionF(c) = "P=Rook8" And PositionD(c) = "" Then
                                buttonD(c) = 1
                                If PositionF(c) = "P=Rook8" And PositionC(c) = "" Then
                                    buttonC(c) = 1
                                    If PositionF(c) = "P=Rook8" And PositionB(c) = "" Then
                                        buttonB(c) = 1
                                        If PositionF(c) = "P=Rook8" And PositionA(c) = "" Then
                                            buttonA(c) = 1
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionF(c) = "P=Rook8" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionF(c) = "P=Rook8" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionF(c) = "P=Rook8" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionF(c) = "P=Rook8" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionF(c) = "P=Rook8" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionF(c) = "P=Rook8" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionF(c) = "P=Rook8" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionG(c) = "P=Rook8" And PositionG(o) = "" And Check = 0 Then
                            buttonG(o) = 1
                            KillG(n) = "True"
                        ElseIf PositionG(c) = "P=Rook8" And PositionG(o) <> "" And Check = 0 Then
                            Check = 1
                            KillG(o) = "True"
                        End If
                        If PositionG(c) = "P=Rook8" And PositionG(m) = "" And Check2 = 0 Then
                            buttonG(m) = 1
                            KillG(u) = "True"
                        ElseIf PositionG(c) = "P=Rook8" And PositionG(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillG(m) = "True"
                        End If
                        If PositionG(c) = "P=Rook8" And PositionH(c) = "" Then
                            buttonH(c) = 1
                        End If
                        If PositionG(c) = "P=Rook8" And PositionF(c) = "" Then
                            buttonF(c) = 1
                            If PositionG(c) = "P=Rook8" And PositionE(c) = "" Then
                                buttonE(c) = 1
                                If PositionG(c) = "P=Rook8" And PositionD(c) = "" Then
                                    buttonD(c) = 1
                                    If PositionG(c) = "P=Rook8" And PositionC(c) = "" Then
                                        buttonC(c) = 1
                                        If PositionG(c) = "P=Rook8" And PositionB(c) = "" Then
                                            buttonB(c) = 1
                                            If PositionG(c) = "P=Rook8" And PositionA(c) = "" Then
                                                buttonA(c) = 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionG(c) = "P=Rook8" And PositionH(c) <> "" Then
                            KillH(c) = "True"
                        End If
                        If PositionG(c) = "P=Rook8" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionG(c) = "P=Rook8" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionG(c) = "P=Rook8" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionG(c) = "P=Rook8" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionG(c) = "P=Rook8" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionG(c) = "P=Rook8" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If

                        If PositionH(c) = "P=Rook8" And PositionH(o) = "" And Check = 0 Then
                            buttonH(o) = 1
                            KillH(n) = "True"
                        ElseIf PositionH(c) = "P=Rook8" And PositionH(o) <> "" And Check = 0 Then
                            Check = 1
                            KillH(o) = "True"
                        End If
                        If PositionH(c) = "P=Rook8" And PositionH(m) = "" And Check2 = 0 Then
                            buttonH(m) = 1
                            KillH(u) = "True"
                        ElseIf PositionH(c) = "P=Rook8" And PositionH(m) <> "" And Check2 = 0 Then
                            Check2 = 1
                            KillH(m) = "True"
                        End If
                        If PositionH(c) = "P=Rook8" And PositionG(c) = "" Then
                            buttonG(c) = 1
                            If PositionH(c) = "P=Rook8" And PositionF(c) = "" Then
                                buttonF(c) = 1
                                If PositionH(c) = "P=Rook8" And PositionE(c) = "" Then
                                    buttonE(c) = 1
                                    If PositionH(c) = "P=Rook8" And PositionD(c) = "" Then
                                        buttonD(c) = 1
                                        If PositionH(c) = "P=Rook8" And PositionC(c) = "" Then
                                            buttonC(c) = 1
                                            If PositionH(c) = "P=Rook8" And PositionB(c) = "" Then
                                                buttonB(c) = 1
                                                If PositionH(c) = "P=Rook8" And PositionA(c) = "" Then
                                                    buttonA(c) = 1
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        If PositionH(c) = "P=Rook8" And PositionG(c) <> "" Then
                            KillG(c) = "True"
                        ElseIf PositionH(c) = "P=Rook8" And PositionF(c) <> "" Then
                            KillF(c) = "True"
                        ElseIf PositionH(c) = "P=Rook8" And PositionE(c) <> "" Then
                            KillE(c) = "True"
                        ElseIf PositionH(c) = "P=Rook8" And PositionD(c) <> "" Then
                            KillD(c) = "True"
                        ElseIf PositionH(c) = "P=Rook8" And PositionC(c) <> "" Then
                            KillC(c) = "True"
                        ElseIf PositionH(c) = "P=Rook8" And PositionB(c) <> "" Then
                            KillB(c) = "True"
                        ElseIf PositionH(c) = "P=Rook8" And PositionA(c) <> "" Then
                            KillA(c) = "True"
                        End If
                    Next
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "KnightBlack1"
                Do
                    c = c + 1
                    o = c + 1
                    m = c + 2
                    u = c - 1
                    n = c - 2
                    FixIndice()
                    If PositionA(c) = "KnightBlack1" Then
                        buttonC(o) = 1
                        buttonB(m) = 1
                        buttonC(u) = 1
                        buttonB(n) = 1
                        KillC(o) = "True"
                        KillB(m) = "True"
                        KillC(u) = "True"
                        KillB(n) = "True"
                    End If
                    If PositionB(c) = "KnightBlack1" Then
                        buttonD(o) = 1
                        buttonC(m) = 1
                        buttonD(u) = 1
                        buttonC(n) = 1
                        buttonA(m) = 1
                        buttonA(n) = 1
                        KillD(o) = "True"
                        KillC(m) = "True"
                        KillD(u) = "True"
                        KillC(n) = "True"
                        KillA(m) = "True"
                        KillA(n) = "True"
                    End If
                    If PositionC(c) = "KnightBlack1" Then
                        buttonE(o) = 1
                        buttonD(m) = 1
                        buttonE(u) = 1
                        buttonD(n) = 1
                        buttonA(o) = 1
                        buttonB(m) = 1
                        buttonA(u) = 1
                        buttonB(n) = 1

                        KillE(o) = "True"
                        KillD(m) = "True"
                        KillE(u) = "True"
                        KillD(n) = "True"
                        KillA(o) = "True"
                        KillB(m) = "True"
                        KillA(u) = "True"
                        KillB(n) = "True"
                    End If
                    If PositionD(c) = "KnightBlack1" Then
                        buttonF(o) = 1
                        buttonE(m) = 1
                        buttonF(u) = 1
                        buttonE(n) = 1
                        buttonB(o) = 1
                        buttonC(m) = 1
                        buttonB(u) = 1
                        buttonC(n) = 1

                        KillF(o) = "True"
                        KillE(m) = "True"
                        KillF(u) = "True"
                        KillE(n) = "True"
                        KillB(o) = "True"
                        KillC(m) = "True"
                        KillB(u) = "True"
                        KillC(n) = "True"
                    End If
                    If PositionE(c) = "KnightBlack1" Then
                        buttonG(o) = 1
                        buttonF(m) = 1
                        buttonG(u) = 1
                        buttonF(n) = 1
                        buttonC(o) = 1
                        buttonD(m) = 1
                        buttonC(u) = 1
                        buttonD(n) = 1

                        KillG(o) = "True"
                        KillF(m) = "True"
                        KillG(u) = "True"
                        KillF(n) = "True"
                        KillC(o) = "True"
                        KillD(m) = "True"
                        KillC(u) = "True"
                        KillD(n) = "True"
                    End If
                    If PositionF(c) = "KnightBlack1" Then
                        buttonH(o) = 1
                        buttonG(m) = 1
                        buttonH(u) = 1
                        buttonG(n) = 1
                        buttonD(o) = 1
                        buttonE(m) = 1
                        buttonD(u) = 1
                        buttonE(n) = 1

                        KillH(o) = "True"
                        KillG(m) = "True"
                        KillH(u) = "True"
                        KillG(n) = "True"
                        KillD(o) = "True"
                        KillE(m) = "True"
                        KillD(u) = "True"
                        KillE(n) = "True"
                    End If
                    If PositionG(c) = "KnightBlack1" Then
                        buttonH(m) = 1
                        buttonH(n) = 1
                        buttonE(o) = 1
                        buttonF(m) = 1
                        buttonE(u) = 1
                        buttonF(n) = 1

                        KillH(m) = "True"
                        KillH(n) = "True"
                        KillE(o) = "True"
                        KillF(m) = "True"
                        KillE(u) = "True"
                        KillF(n) = "True"
                    End If
                    If PositionH(c) = "KnightBlack1" Then
                        buttonF(o) = 1
                        buttonG(m) = 1
                        buttonF(u) = 1
                        buttonG(n) = 1

                        KillF(o) = "True"
                        KillG(m) = "True"
                        KillF(u) = "True"
                        KillG(n) = "True"
                    End If
                Loop Until c > 7
                Check = 0
                c = 0
                Check2 = 0
            Case "BishopBlack1"
                Do
                    c = c + 1
                    o = c + 1
                    u = c - 1
                    If PositionA(c) = "BishopBlack1" Then
                        If PositionB(o) = "" Then
                            buttonB(o) = 1
                            o = o + 1
                            If PositionC(o) = "" Then
                                buttonC(o) = 1
                                o = o + 1
                                If PositionD(o) = "" Then
                                    buttonD(o) = 1
                                    o = o + 1
                                    If PositionE(o) = "" Then
                                        buttonE(o) = 1
                                        o = o + 1
                                        If PositionF(o) = "" Then
                                            buttonF(o) = 1
                                            o = o + 1
                                            If PositionG(o) = "" Then
                                                buttonG(o) = 1
                                                o = o + 1
                                                If PositionH(o) = "" Then
                                                    buttonH(o) = 1
                                                ElseIf PositionH(o) <> "" Then
                                                    KillH(o) = "True"
                                                End If
                                            ElseIf PositionG(o) <> "" Then
                                                KillG(o) = "True"
                                            End If
                                        ElseIf PositionF(o) <> "" Then
                                            KillF(o) = "True"
                                        End If
                                    ElseIf PositionE(o) <> "" Then
                                        KillE(o) = "True"
                                    End If
                                ElseIf PositionD(o) <> "" Then
                                    KillD(o) = "True"
                                End If
                            ElseIf PositionC(o) <> "" Then
                                KillC(o) = "True"
                            End If
                        ElseIf PositionB(o) <> "" Then
                            KillB(o) = "True"
                        End If
                    End If
                    If PositionA(c) = "BishopBlack1" Then
                        If PositionB(u) = "" Then
                            buttonB(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionC(u) = "" Then
                                buttonC(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionD(u) = "" Then
                                    buttonD(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionE(u) = "" Then
                                        buttonE(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionF(u) = "" Then
                                            buttonF(u) = 1
                                            u = u - 1
                                            FixIndice()
                                            If PositionG(u) = "" Then
                                                buttonG(u) = 1
                                                u = u - 1
                                                FixIndice()
                                                If PositionH(u) = "" Then
                                                    buttonH(u) = 1
                                                ElseIf PositionH(u) <> "" Then
                                                    KillH(u) = "True"
                                                End If
                                            ElseIf PositionG(u) <> "" Then
                                                KillG(u) = "True"
                                            End If
                                        ElseIf PositionF(u) <> "" Then
                                            KillF(u) = "True"
                                        End If
                                    ElseIf PositionE(u) <> "" Then
                                        KillE(u) = "True"
                                    End If
                                ElseIf PositionD(u) <> "" Then
                                    KillD(u) = "True"
                                End If
                            ElseIf PositionC(u) <> "" Then
                                KillC(u) = "True"
                            End If
                        ElseIf PositionB(u) <> "" Then
                            KillB(u) = "True"
                        End If
                    End If

                    If PositionB(c) = "BishopBlack1" Then
                        If PositionA(o) = "" Then
                            buttonA(o) = 1
                        ElseIf PositionA(o) <> "" Then
                            KillA(o) = "True"
                        End If
                        If PositionC(o) = "" Then
                            buttonC(o) = 1
                            o = o + 1
                            If PositionD(o) = "" Then
                                buttonD(o) = 1
                                o = o + 1
                                If PositionE(o) = "" Then
                                    buttonE(o) = 1
                                    o = o + 1
                                    If PositionF(o) = "" Then
                                        buttonF(o) = 1
                                        o = o + 1
                                        If PositionG(o) = "" Then
                                            buttonG(o) = 1
                                            o = o + 1
                                            If PositionH(o) = "" Then
                                                buttonH(o) = 1
                                            ElseIf PositionH(o) <> "" Then
                                                KillH(o) = "True"
                                            End If
                                        ElseIf PositionG(o) <> "" Then
                                            KillG(o) = "True"
                                        End If
                                    ElseIf PositionF(o) <> "" Then
                                        KillF(o) = "True"
                                    End If
                                ElseIf PositionE(o) <> "" Then
                                    KillE(o) = "True"
                                End If
                            ElseIf PositionD(o) <> "" Then
                                KillD(o) = "True"
                            End If
                        ElseIf PositionC(o) <> "" Then
                            KillC(o) = "True"
                        End If
                    End If

                    If PositionB(c) = "BishopBlack1" Then
                        If PositionA(u) = "" Then
                            buttonA(u) = 1
                        ElseIf PositionB(u) <> "" Then
                            KillB(u) = "True"
                        End If
                        If PositionC(u) = "" Then
                            buttonC(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionD(u) = "" Then
                                buttonD(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionE(u) = "" Then
                                    buttonE(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionF(u) = "" Then
                                        buttonF(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionG(u) = "" Then
                                            buttonG(u) = 1
                                            u = u - 1
                                            FixIndice()
                                            If PositionH(u) = "" Then
                                                buttonH(u) = 1
                                            ElseIf PositionH(u) <> "" Then
                                                KillH(u) = "True"
                                            End If
                                        ElseIf PositionG(u) <> "" Then
                                            KillG(u) = "True"
                                        End If
                                    ElseIf PositionF(u) <> "" Then
                                        KillF(u) = "True"
                                    End If
                                ElseIf PositionE(u) <> "" Then
                                    KillE(u) = "True"
                                End If
                            ElseIf PositionD(u) <> "" Then
                                KillD(u) = "True"
                            End If
                        ElseIf PositionC(u) <> "" Then
                            KillC(u) = "True"
                        End If
                    End If

                    If PositionC(c) = "BishopBlack1" Then
                        If PositionB(o) = "" Then
                            buttonB(o) = 1
                            o = o + 1
                            If PositionA(o) = "" Then
                                buttonA(o) = 1
                            ElseIf PositionA(o) <> "" Then
                                KillA(o) = "True"
                            ElseIf PositionB(o) <> "" Then
                                KillB(o) = "True"
                            End If
                        End If
                        o = c + 1
                        If PositionD(o) = "" Then
                            buttonD(o) = 1
                            o = o + 1
                            If PositionE(o) = "" Then
                                buttonE(o) = 1
                                o = o + 1
                                If PositionF(o) = "" Then
                                    buttonF(o) = 1
                                    o = o + 1
                                    If PositionG(o) = "" Then
                                        buttonG(o) = 1
                                        o = o + 1
                                        If PositionH(o) = "" Then
                                            buttonH(o) = 1
                                        ElseIf PositionH(o) <> "" Then
                                            KillH(o) = "True"
                                        End If
                                    ElseIf PositionG(o) <> "" Then
                                        KillG(o) = "True"
                                    End If
                                ElseIf PositionF(o) <> "" Then
                                    KillF(o) = "True"
                                End If
                            ElseIf PositionE(o) <> "" Then
                                KillE(o) = "True"
                            End If
                        ElseIf PositionD(o) <> "" Then
                            KillD(o) = "True"
                        End If
                    End If
                    If PositionC(c) = "BishopBlack1" Then
                        If PositionB(u) = "" Then
                            buttonB(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionA(u) = "" Then
                                buttonA(u) = 1
                            ElseIf PositionC(u) <> "" Then
                                KillC(u) = "True"
                            End If
                        ElseIf PositionB(u) <> "" Then
                            KillB(u) = "True"
                        End If
                        u = c - 1
                        If PositionD(u) = "" Then
                            buttonD(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionE(u) = "" Then
                                buttonE(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionF(u) = "" Then
                                    buttonF(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionG(u) = "" Then
                                        buttonG(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionH(u) = "" Then
                                            buttonH(u) = 1
                                        ElseIf PositionH(u) <> "" Then
                                            KillH(u) = "True"
                                        End If
                                    ElseIf PositionG(u) <> "" Then
                                        KillG(u) = "True"
                                    End If
                                ElseIf PositionF(u) <> "" Then
                                    KillF(u) = "True"
                                End If
                            ElseIf PositionE(u) <> "" Then
                                KillE(u) = "True"
                            End If
                        ElseIf PositionD(u) <> "" Then
                            KillD(u) = "True"
                        End If
                    End If

                    If PositionD(c) = "BishopBlack1" Then
                        If PositionC(o) = "" Then
                            buttonC(o) = 1
                            o = o + 1
                            If PositionB(o) = "" Then
                                buttonB(o) = 1
                                o = o + 1
                                If PositionA(o) = "" Then
                                    buttonA(o) = 1
                                ElseIf PositionA(o) <> "" Then
                                    KillA(o) = "True"
                                End If
                            ElseIf PositionB(o) <> "" Then
                                KillB(o) = "True"
                            End If
                        ElseIf PositionC(o) <> "" Then
                            KillC(o) = "True"
                        End If
                        o = c + 1
                        If PositionE(o) = "" Then
                            buttonE(o) = 1
                            o = o + 1
                            If PositionF(o) = "" Then
                                buttonF(o) = 1
                                o = o + 1
                                If PositionG(o) = "" Then
                                    buttonG(o) = 1
                                    o = o + 1
                                    If PositionH(o) = "" Then
                                        buttonH(o) = 1
                                    ElseIf PositionH(o) <> "" Then
                                        KillH(o) = "True"
                                    End If
                                ElseIf PositionG(o) <> "" Then
                                    KillG(o) = "True"
                                End If
                            ElseIf PositionF(o) <> "" Then
                                KillF(o) = "True"
                            End If
                        ElseIf PositionE(o) <> "" Then
                            KillE(o) = "True"
                        End If
                    End If
                    If PositionD(c) = "BishopBlack1" Then
                        If PositionC(u) = "" Then
                            buttonC(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionB(u) = "" Then
                                buttonB(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionA(u) = "" Then
                                    buttonA(u) = 1
                                ElseIf PositionA(u) <> "" Then
                                    KillA(u) = "True"
                                End If
                            ElseIf PositionB(u) <> "" Then
                                KillB(u) = "True"
                            End If
                        ElseIf PositionC(u) <> "" Then
                            KillC(u) = "True"
                        End If
                        u = c - 1
                        If PositionE(u) = "" Then
                            buttonE(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionF(u) = "" Then
                                buttonF(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionG(u) = "" Then
                                    buttonG(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionH(u) = "" Then
                                        buttonH(u) = 1
                                    ElseIf PositionH(u) <> "" Then
                                        KillH(u) = "True"
                                    End If
                                ElseIf PositionG(u) <> "" Then
                                    KillG(u) = "True"
                                End If
                            ElseIf PositionF(u) <> "" Then
                                KillF(u) = "True"
                            End If
                        ElseIf PositionE(u) <> "" Then
                            KillE(u) = "True"
                        End If
                    End If

                    If PositionE(c) = "BishopBlack1" Then
                        If PositionD(o) = "" Then
                            buttonD(o) = 1
                            o = o + 1
                            If PositionC(o) = "" Then
                                buttonC(o) = 1
                                o = o + 1
                                If PositionB(o) = "" Then
                                    buttonB(o) = 1
                                    o = o + 1
                                    If PositionA(o) = "" Then
                                        buttonA(o) = 1
                                    ElseIf PositionE(o) <> "" Then
                                        KillA(o) = "True"
                                    End If
                                ElseIf PositionB(o) <> "" Then
                                    KillB(o) = "True"
                                End If
                            ElseIf PositionC(o) <> "" Then
                                KillC(o) = "True"
                            End If
                        ElseIf PositionD(o) <> "" Then
                            KillD(o) = "True"
                        End If
                        o = c + 1
                        If PositionF(o) = "" Then
                            buttonF(o) = 1
                            o = o + 1
                            If PositionG(o) = "" Then
                                buttonG(o) = 1
                                o = o + 1
                                If PositionH(o) = "" Then
                                    buttonH(o) = 1
                                ElseIf PositionH(o) <> "" Then
                                    KillH(o) = "True"
                                End If
                            ElseIf PositionG(o) <> "" Then
                                KillG(o) = "True"
                            End If
                        ElseIf PositionF(o) <> "" Then
                            KillF(o) = "True"
                        End If
                    End If
                    If PositionE(c) = "BishopBlack1" Then
                        If PositionD(u) = "" Then
                            buttonD(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionC(u) = "" Then
                                buttonC(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionB(u) = "" Then
                                    buttonB(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionA(u) = "" Then
                                        buttonA(u) = 1
                                    ElseIf PositionA(u) <> "" Then
                                        KillA(u) = "True"
                                    End If
                                ElseIf PositionB(u) <> "" Then
                                    KillB(u) = "True"
                                End If
                            ElseIf PositionC(u) <> "" Then
                                KillC(u) = "True"
                            End If
                        ElseIf PositionD(u) <> "" Then
                            KillD(u) = "True"
                        End If
                        u = c - 1
                        If PositionF(u) = "" Then
                            buttonF(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionG(u) = "" Then
                                buttonG(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionH(u) = "" Then
                                    buttonH(u) = 1
                                ElseIf PositionH(u) <> "" Then
                                    KillH(u) = "True"
                                End If
                            ElseIf PositionG(u) <> "" Then
                                KillG(u) = "True"
                            End If
                        ElseIf PositionF(u) <> "" Then
                            KillF(u) = "True"
                        End If
                    End If

                        If PositionF(c) = "BishopBlack1" Then
                            If PositionE(o) = "" Then
                                buttonE(o) = 1
                                o = o + 1
                                If PositionD(o) = "" Then
                                    buttonD(o) = 1
                                    o = o + 1
                                    If PositionC(o) = "" Then
                                        buttonC(o) = 1
                                        o = o + 1
                                        If PositionB(o) = "" Then
                                            buttonB(o) = 1
                                            o = o + 1
                                            If PositionA(o) = "" Then
                                                buttonA(o) = 1
                                        ElseIf PositionA(o) <> "" Then
                                            KillA(o) = "True"
                                        End If
                                    ElseIf PositionB(o) <> "" Then
                                        KillB(o) = "True"
                                    End If
                                ElseIf PositionC(o) <> "" Then
                                    KillC(o) = "True"
                                End If
                            ElseIf PositionD(o) <> "" Then
                                KillD(o) = "True"
                            End If
                        ElseIf PositionE(o) <> "" Then
                            KillE(o) = "True"
                        End If
                        o = c + 1
                        If PositionG(o) = "" Then
                            buttonG(o) = 1
                            o = o + 1
                            If PositionH(o) = "" Then
                                buttonH(o) = 1
                            ElseIf PositionH(o) <> "" Then
                                KillH(o) = "True"
                            End If
                        ElseIf PositionG(o) <> "" Then
                            KillG(o) = "True"
                        End If
                    End If
                    If PositionF(c) = "BishopBlack1" Then
                        If PositionE(u) = "" Then
                            buttonE(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionD(u) = "" Then
                                buttonD(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionC(u) = "" Then
                                    buttonC(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionB(u) = "" Then
                                        buttonB(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionA(u) = "" Then
                                            buttonA(u) = 1
                                        ElseIf PositionA(u) <> "" Then
                                            KillA(u) = "True"
                                        End If
                                    ElseIf PositionB(u) <> "" Then
                                        KillB(u) = "True"
                                    End If
                                ElseIf PositionC(u) <> "" Then
                                    KillC(u) = "True"
                                End If
                            ElseIf PositionD(u) <> "" Then
                                KillD(u) = "True"
                            End If
                        ElseIf PositionE(u) <> "" Then
                            KillE(u) = "True"
                        End If
                        u = c - 1
                        If PositionG(u) = "" Then
                            buttonG(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionH(u) = "" Then
                                buttonH(u) = 1
                            ElseIf PositionH(u) <> "" Then
                                KillH(u) = "True"
                            End If
                        ElseIf PositionG(u) <> "" Then
                            KillG(u) = "True"
                        End If
                    End If

                    If PositionG(c) = "BishopBlack1" Then
                        If PositionF(o) = "" Then
                            buttonF(o) = 1
                            o = o + 1
                            If PositionE(o) = "" Then
                                buttonE(o) = 1
                                o = o + 1
                                If PositionD(o) = "" Then
                                    buttonD(o) = 1
                                    o = o + 1
                                    If PositionC(o) = "" Then
                                        buttonC(o) = 1
                                        o = o + 1
                                        If PositionB(o) = "" Then
                                            buttonB(o) = 1
                                            o = o + 1
                                            If PositionA(o) = "" Then
                                                buttonA(o) = 1
                                            ElseIf PositionA(o) <> "" Then
                                                KillA(o) = "True"
                                            End If
                                        ElseIf PositionB(o) <> "" Then
                                            KillB(o) = "True"
                                        End If
                                    ElseIf PositionC(o) <> "" Then
                                        KillC(o) = "True"
                                    End If
                                ElseIf PositionD(o) <> "" Then
                                    KillD(o) = "True"
                                End If
                            ElseIf PositionE(o) <> "" Then
                                KillE(o) = "True"
                            End If
                        ElseIf PositionF(o) <> "" Then
                            KillF(o) = "True"
                        End If
                        o = c + 1
                        If PositionH(o) = "" Then
                            buttonH(o) = 1
                        ElseIf PositionH(o) <> "" Then
                            KillH(o) = "True"
                        End If
                    End If
                    If PositionG(c) = "BishopBlack1" Then
                        If PositionF(u) = "" Then
                            buttonF(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionE(u) = "" Then
                                buttonE(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionD(u) = "" Then
                                    buttonD(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionC(u) = "" Then
                                        buttonC(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionB(u) = "" Then
                                            buttonB(u) = 1
                                            u = u - 1
                                            FixIndice()
                                            If PositionA(u) = "" Then
                                                buttonA(u) = 1
                                            ElseIf PositionA(u) <> "" Then
                                                KillA(u) = "True"
                                            End If
                                        ElseIf PositionB(u) <> "" Then
                                            KillB(u) = "True"
                                        End If
                                    ElseIf PositionC(u) <> "" Then
                                        KillC(u) = "True"
                                    End If
                                ElseIf PositionD(u) <> "" Then
                                    KillD(u) = "True"
                                End If
                            ElseIf PositionE(u) <> "" Then
                                KillE(u) = "True"
                            End If
                        ElseIf PositionF(u) <> "" Then
                            KillF(u) = "True"
                        End If
                        u = c - 1
                        If PositionH(u) = "" Then
                            buttonH(u) = 1
                        ElseIf PositionH(u) <> "" Then
                            KillH(u) = "True"
                        End If
                    End If

                    If PositionH(c) = "BishopBlack1" Then
                        o = c + 1
                        If PositionG(o) = "" Then
                            buttonG(o) = 1
                            o = o + 1
                            If PositionF(o) = "" Then
                                buttonF(o) = 1
                                o = o + 1
                                If PositionE(o) = "" Then
                                    buttonE(o) = 1
                                    o = o + 1
                                    If PositionD(o) = "" Then
                                        buttonD(o) = 1
                                        o = o + 1
                                        If PositionC(o) = "" Then
                                            buttonC(o) = 1
                                            o = o + 1
                                            If PositionB(o) = "" Then
                                                buttonB(o) = 1
                                                o = o + 1
                                                If PositionA(o) = "" Then
                                                    buttonA(o) = 1
                                                ElseIf PositionA(o) <> "" Then
                                                    KillA(o) = "True"
                                                End If
                                            ElseIf PositionB(o) <> "" Then
                                                KillB(o) = "True"
                                            End If
                                        ElseIf PositionC(o) <> "" Then
                                            KillC(o) = "True"
                                        End If
                                    ElseIf PositionD(o) <> "" Then
                                        KillD(o) = "True"
                                    End If
                                ElseIf PositionE(o) <> "" Then
                                    KillE(o) = "True"
                                End If
                            ElseIf PositionF(o) <> "" Then
                                KillF(o) = "True"
                            End If
                            ElseIf PositionG(o) <> "" Then
                                KillG(o) = "True"
                            End If
                        End If
                        If PositionH(c) = "BishopBlack1" Then
                            u = c - 1
                            If PositionG(u) = "" Then
                                buttonG(u) = 1
                                u = u - 1
                                If PositionF(u) = "" Then
                                    buttonF(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionE(u) = "" Then
                                        buttonE(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionD(u) = "" Then
                                            buttonD(u) = 1
                                            u = u - 1
                                            FixIndice()
                                            If PositionC(u) = "" Then
                                                buttonC(u) = 1
                                                u = u - 1
                                                FixIndice()
                                                If PositionB(u) = "" Then
                                                    buttonB(u) = 1
                                                    u = u - 1
                                                    FixIndice()
                                                    If PositionA(u) = "" Then
                                                        buttonA(u) = 1
                                                    ElseIf PositionA(u) <> "" Then
                                                        KillA(u) = "True"
                                                    End If
                                                ElseIf PositionB(u) <> "" Then
                                                    KillB(u) = "True"
                                                End If
                                            ElseIf PositionC(u) <> "" Then
                                                KillC(u) = "True"
                                            End If
                                        ElseIf PositionD(u) <> "" Then
                                            KillD(u) = "True"
                                        End If
                                    ElseIf PositionE(u) <> "" Then
                                        KillE(u) = "True"
                                    End If
                                ElseIf PositionF(u) <> "" Then
                                    KillF(u) = "True"
                                End If
                            ElseIf PositionG(u) <> "" Then
                                KillG(u) = "True"
                            End If
                        End If
                Loop Until c > 7
                c = 0
               
            Case "BishopBlack2"
                Do
                    c = c + 1
                    o = c + 1
                    u = c - 1
                    If PositionA(c) = "BishopBlack2" Then
                        If PositionB(o) = "" Then
                            buttonB(o) = 1
                            o = o + 1
                            If PositionC(o) = "" Then
                                buttonC(o) = 1
                                o = o + 1
                                If PositionD(o) = "" Then
                                    buttonD(o) = 1
                                    o = o + 1
                                    If PositionE(o) = "" Then
                                        buttonE(o) = 1
                                        o = o + 1
                                        If PositionF(o) = "" Then
                                            buttonF(o) = 1
                                            o = o + 1
                                            If PositionG(o) = "" Then
                                                buttonG(o) = 1
                                                o = o + 1
                                                If PositionH(o) = "" Then
                                                    buttonH(o) = 1
                                                ElseIf PositionH(o) <> "" Then
                                                    KillH(o) = "True"
                                                End If
                                            ElseIf PositionG(o) <> "" Then
                                                KillG(o) = "True"
                                            End If
                                        ElseIf PositionF(o) <> "" Then
                                            KillF(o) = "True"
                                        End If
                                    ElseIf PositionE(o) <> "" Then
                                        KillE(o) = "True"
                                    End If
                                ElseIf PositionD(o) <> "" Then
                                    KillD(o) = "True"
                                End If
                            ElseIf PositionC(o) <> "" Then
                                KillC(o) = "True"
                            End If
                        ElseIf PositionB(o) <> "" Then
                            KillB(o) = "True"
                        End If
                    End If
                    If PositionA(c) = "BishopBlack2" Then
                        If PositionB(u) = "" Then
                            buttonB(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionC(u) = "" Then
                                buttonC(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionD(u) = "" Then
                                    buttonD(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionE(u) = "" Then
                                        buttonE(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionF(u) = "" Then
                                            buttonF(u) = 1
                                            u = u - 1
                                            FixIndice()
                                            If PositionG(u) = "" Then
                                                buttonG(u) = 1
                                                u = u - 1
                                                FixIndice()
                                                If PositionH(u) = "" Then
                                                    buttonH(u) = 1
                                                ElseIf PositionH(u) <> "" Then
                                                    KillH(u) = "True"
                                                End If
                                            ElseIf PositionG(u) <> "" Then
                                                KillG(u) = "True"
                                            End If
                                        ElseIf PositionF(u) <> "" Then
                                            KillF(u) = "True"
                                        End If
                                    ElseIf PositionE(u) <> "" Then
                                        KillE(u) = "True"
                                    End If
                                ElseIf PositionD(u) <> "" Then
                                    KillD(u) = "True"
                                End If
                            ElseIf PositionC(u) <> "" Then
                                KillC(u) = "True"
                            End If
                        ElseIf PositionB(u) <> "" Then
                            KillB(u) = "True"
                        End If
                    End If

                    If PositionB(c) = "BishopBlack2" Then
                        If PositionA(o) = "" Then
                            buttonA(o) = 1
                        ElseIf PositionA(o) <> "" Then
                            KillA(o) = "True"
                        End If
                        If PositionC(o) = "" Then
                            buttonC(o) = 1
                            o = o + 1
                            If PositionD(o) = "" Then
                                buttonD(o) = 1
                                o = o + 1
                                If PositionE(o) = "" Then
                                    buttonE(o) = 1
                                    o = o + 1
                                    If PositionF(o) = "" Then
                                        buttonF(o) = 1
                                        o = o + 1
                                        If PositionG(o) = "" Then
                                            buttonG(o) = 1
                                            o = o + 1
                                            If PositionH(o) = "" Then
                                                buttonH(o) = 1
                                            ElseIf PositionH(o) <> "" Then
                                                KillH(o) = "True"
                                            End If
                                        ElseIf PositionG(o) <> "" Then
                                            KillG(o) = "True"
                                        End If
                                    ElseIf PositionF(o) <> "" Then
                                        KillF(o) = "True"
                                    End If
                                ElseIf PositionE(o) <> "" Then
                                    KillE(o) = "True"
                                End If
                            ElseIf PositionD(o) <> "" Then
                                KillD(o) = "True"
                            End If
                        ElseIf PositionC(o) <> "" Then
                            KillC(o) = "True"
                        End If
                    End If

                    If PositionB(c) = "BishopBlack2" Then
                        If PositionA(u) = "" Then
                            buttonA(u) = 1
                        ElseIf PositionB(u) <> "" Then
                            KillB(u) = "True"
                        End If
                        If PositionC(u) = "" Then
                            buttonC(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionD(u) = "" Then
                                buttonD(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionE(u) = "" Then
                                    buttonE(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionF(u) = "" Then
                                        buttonF(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionG(u) = "" Then
                                            buttonG(u) = 1
                                            u = u - 1
                                            FixIndice()
                                            If PositionH(u) = "" Then
                                                buttonH(u) = 1
                                            ElseIf PositionH(u) <> "" Then
                                                KillH(u) = "True"
                                            End If
                                        ElseIf PositionG(u) <> "" Then
                                            KillG(u) = "True"
                                        End If
                                    ElseIf PositionF(u) <> "" Then
                                        KillF(u) = "True"
                                    End If
                                ElseIf PositionE(u) <> "" Then
                                    KillE(u) = "True"
                                End If
                            ElseIf PositionD(u) <> "" Then
                                KillD(u) = "True"
                            End If
                        ElseIf PositionC(u) <> "" Then
                            KillC(u) = "True"
                        End If
                    End If

                    If PositionC(c) = "BishopBlack2" Then
                        If PositionB(o) = "" Then
                            buttonB(o) = 1
                            o = o + 1
                            If PositionA(o) = "" Then
                                buttonA(o) = 1
                            ElseIf PositionA(o) <> "" Then
                                KillA(o) = "True"
                            ElseIf PositionB(o) <> "" Then
                                KillB(o) = "True"
                            End If
                        End If
                        o = c + 1
                        If PositionD(o) = "" Then
                            buttonD(o) = 1
                            o = o + 1
                            If PositionE(o) = "" Then
                                buttonE(o) = 1
                                o = o + 1
                                If PositionF(o) = "" Then
                                    buttonF(o) = 1
                                    o = o + 1
                                    If PositionG(o) = "" Then
                                        buttonG(o) = 1
                                        o = o + 1
                                        If PositionH(o) = "" Then
                                            buttonH(o) = 1
                                        ElseIf PositionH(o) <> "" Then
                                            KillH(o) = "True"
                                        End If
                                    ElseIf PositionG(o) <> "" Then
                                        KillG(o) = "True"
                                    End If
                                ElseIf PositionF(o) <> "" Then
                                    KillF(o) = "True"
                                End If
                            ElseIf PositionE(o) <> "" Then
                                KillE(o) = "True"
                            End If
                        ElseIf PositionD(o) <> "" Then
                            KillD(o) = "True"
                        End If
                    End If
                    If PositionC(c) = "BishopBlack2" Then
                        If PositionB(u) = "" Then
                            buttonB(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionA(u) = "" Then
                                buttonA(u) = 1
                            ElseIf PositionC(u) <> "" Then
                                KillC(u) = "True"
                            End If
                        ElseIf PositionB(u) <> "" Then
                            KillB(u) = "True"
                        End If
                        u = c - 1
                        If PositionD(u) = "" Then
                            buttonD(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionE(u) = "" Then
                                buttonE(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionF(u) = "" Then
                                    buttonF(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionG(u) = "" Then
                                        buttonG(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionH(u) = "" Then
                                            buttonH(u) = 1
                                        ElseIf PositionH(u) <> "" Then
                                            KillH(u) = "True"
                                        End If
                                    ElseIf PositionG(u) <> "" Then
                                        KillG(u) = "True"
                                    End If
                                ElseIf PositionF(u) <> "" Then
                                    KillF(u) = "True"
                                End If
                            ElseIf PositionE(u) <> "" Then
                                KillE(u) = "True"
                            End If
                        ElseIf PositionD(u) <> "" Then
                            KillD(u) = "True"
                        End If
                    End If

                    If PositionD(c) = "BishopBlack2" Then
                        If PositionC(o) = "" Then
                            buttonC(o) = 1
                            o = o + 1
                            If PositionB(o) = "" Then
                                buttonB(o) = 1
                                o = o + 1
                                If PositionA(o) = "" Then
                                    buttonA(o) = 1
                                ElseIf PositionA(o) <> "" Then
                                    KillA(o) = "True"
                                End If
                            ElseIf PositionB(o) <> "" Then
                                KillB(o) = "True"
                            End If
                        ElseIf PositionC(o) <> "" Then
                            KillC(o) = "True"
                        End If
                        o = c + 1
                        If PositionE(o) = "" Then
                            buttonE(o) = 1
                            o = o + 1
                            If PositionF(o) = "" Then
                                buttonF(o) = 1
                                o = o + 1
                                If PositionG(o) = "" Then
                                    buttonG(o) = 1
                                    o = o + 1
                                    If PositionH(o) = "" Then
                                        buttonH(o) = 1
                                    ElseIf PositionH(o) <> "" Then
                                        KillH(o) = "True"
                                    End If
                                ElseIf PositionG(o) <> "" Then
                                    KillG(o) = "True"
                                End If
                            ElseIf PositionF(o) <> "" Then
                                KillF(o) = "True"
                            End If
                        ElseIf PositionE(o) <> "" Then
                            KillE(o) = "True"
                        End If
                    End If
                    If PositionD(c) = "BishopBlack2" Then
                        If PositionC(u) = "" Then
                            buttonC(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionB(u) = "" Then
                                buttonB(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionA(u) = "" Then
                                    buttonA(u) = 1
                                ElseIf PositionA(u) <> "" Then
                                    KillA(u) = "True"
                                End If
                            ElseIf PositionB(u) <> "" Then
                                KillB(u) = "True"
                            End If
                        ElseIf PositionC(u) <> "" Then
                            KillC(u) = "True"
                        End If
                        u = c - 1
                        If PositionE(u) = "" Then
                            buttonE(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionF(u) = "" Then
                                buttonF(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionG(u) = "" Then
                                    buttonG(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionH(u) = "" Then
                                        buttonH(u) = 1
                                    ElseIf PositionH(u) <> "" Then
                                        KillH(u) = "True"
                                    End If
                                ElseIf PositionG(u) <> "" Then
                                    KillG(u) = "True"
                                End If
                            ElseIf PositionF(u) <> "" Then
                                KillF(u) = "True"
                            End If
                        ElseIf PositionE(u) <> "" Then
                            KillE(u) = "True"
                        End If
                    End If

                    If PositionE(c) = "BishopBlack2" Then
                        If PositionD(o) = "" Then
                            buttonD(o) = 1
                            o = o + 1
                            If PositionC(o) = "" Then
                                buttonC(o) = 1
                                o = o + 1
                                If PositionB(o) = "" Then
                                    buttonB(o) = 1
                                    o = o + 1
                                    If PositionA(o) = "" Then
                                        buttonA(o) = 1
                                    ElseIf PositionE(o) <> "" Then
                                        KillA(o) = "True"
                                    End If
                                ElseIf PositionB(o) <> "" Then
                                    KillB(o) = "True"
                                End If
                            ElseIf PositionC(o) <> "" Then
                                KillC(o) = "True"
                            End If
                        ElseIf PositionD(o) <> "" Then
                            KillD(o) = "True"
                        End If
                        o = c + 1
                        If PositionF(o) = "" Then
                            buttonF(o) = 1
                            o = o + 1
                            If PositionG(o) = "" Then
                                buttonG(o) = 1
                                o = o + 1
                                If PositionH(o) = "" Then
                                    buttonH(o) = 1
                                ElseIf PositionH(o) <> "" Then
                                    KillH(o) = "True"
                                End If
                            ElseIf PositionG(o) <> "" Then
                                KillG(o) = "True"
                            End If
                        ElseIf PositionF(o) <> "" Then
                            KillF(o) = "True"
                        End If
                    End If
                    If PositionE(c) = "BishopBlack2" Then
                        If PositionD(u) = "" Then
                            buttonD(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionC(u) = "" Then
                                buttonC(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionB(u) = "" Then
                                    buttonB(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionA(u) = "" Then
                                        buttonA(u) = 1
                                    ElseIf PositionA(u) <> "" Then
                                        KillA(u) = "True"
                                    End If
                                ElseIf PositionB(u) <> "" Then
                                    KillB(u) = "True"
                                End If
                            ElseIf PositionC(u) <> "" Then
                                KillC(u) = "True"
                            End If
                        ElseIf PositionD(u) <> "" Then
                            KillD(u) = "True"
                        End If
                        u = c - 1
                        If PositionF(u) = "" Then
                            buttonF(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionG(u) = "" Then
                                buttonG(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionH(u) = "" Then
                                    buttonH(u) = 1
                                ElseIf PositionH(u) <> "" Then
                                    KillH(u) = "True"
                                End If
                            ElseIf PositionG(u) <> "" Then
                                KillG(u) = "True"
                            End If
                        ElseIf PositionF(u) <> "" Then
                            KillF(u) = "True"
                        End If
                    End If

                    If PositionF(c) = "BishopBlack2" Then
                        If PositionE(o) = "" Then
                            buttonE(o) = 1
                            o = o + 1
                            If PositionD(o) = "" Then
                                buttonD(o) = 1
                                o = o + 1
                                If PositionC(o) = "" Then
                                    buttonC(o) = 1
                                    o = o + 1
                                    If PositionB(o) = "" Then
                                        buttonB(o) = 1
                                        o = o + 1
                                        If PositionA(o) = "" Then
                                            buttonA(o) = 1
                                        ElseIf PositionA(o) <> "" Then
                                            KillA(o) = "True"
                                        End If
                                    ElseIf PositionB(o) <> "" Then
                                        KillB(o) = "True"
                                    End If
                                ElseIf PositionC(o) <> "" Then
                                    KillC(o) = "True"
                                End If
                            ElseIf PositionD(o) <> "" Then
                                KillD(o) = "True"
                            End If
                        ElseIf PositionE(o) <> "" Then
                            KillE(o) = "True"
                        End If
                        o = c + 1
                        If PositionG(o) = "" Then
                            buttonG(o) = 1
                            o = o + 1
                            If PositionH(o) = "" Then
                                buttonH(o) = 1
                            ElseIf PositionH(o) <> "" Then
                                KillH(o) = "True"
                            End If
                        ElseIf PositionG(o) <> "" Then
                            KillG(o) = "True"
                        End If
                    End If
                    If PositionF(c) = "BishopBlack2" Then
                        If PositionE(u) = "" Then
                            buttonE(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionD(u) = "" Then
                                buttonD(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionC(u) = "" Then
                                    buttonC(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionB(u) = "" Then
                                        buttonB(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionA(u) = "" Then
                                            buttonA(u) = 1
                                        ElseIf PositionA(u) <> "" Then
                                            KillA(u) = "True"
                                        End If
                                    ElseIf PositionB(u) <> "" Then
                                        KillB(u) = "True"
                                    End If
                                ElseIf PositionC(u) <> "" Then
                                    KillC(u) = "True"
                                End If
                            ElseIf PositionD(u) <> "" Then
                                KillD(u) = "True"
                            End If
                        ElseIf PositionE(u) <> "" Then
                            KillE(u) = "True"
                        End If
                        u = c - 1
                        If PositionG(u) = "" Then
                            buttonG(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionH(u) = "" Then
                                buttonH(u) = 1
                            ElseIf PositionH(u) <> "" Then
                                KillH(u) = "True"
                            End If
                        ElseIf PositionG(u) <> "" Then
                            KillG(u) = "True"
                        End If
                    End If

                    If PositionG(c) = "BishopBlack2" Then
                        If PositionF(o) = "" Then
                            buttonF(o) = 1
                            o = o + 1
                            If PositionE(o) = "" Then
                                buttonE(o) = 1
                                o = o + 1
                                If PositionD(o) = "" Then
                                    buttonD(o) = 1
                                    o = o + 1
                                    If PositionC(o) = "" Then
                                        buttonC(o) = 1
                                        o = o + 1
                                        If PositionB(o) = "" Then
                                            buttonB(o) = 1
                                            o = o + 1
                                            If PositionA(o) = "" Then
                                                buttonA(o) = 1
                                            ElseIf PositionA(o) <> "" Then
                                                KillA(o) = "True"
                                            End If
                                        ElseIf PositionB(o) <> "" Then
                                            KillB(o) = "True"
                                        End If
                                    ElseIf PositionC(o) <> "" Then
                                        KillC(o) = "True"
                                    End If
                                ElseIf PositionD(o) <> "" Then
                                    KillD(o) = "True"
                                End If
                            ElseIf PositionE(o) <> "" Then
                                KillE(o) = "True"
                            End If
                        ElseIf PositionF(o) <> "" Then
                            KillF(o) = "True"
                        End If
                        o = c + 1
                        If PositionH(o) = "" Then
                            buttonH(o) = 1
                        ElseIf PositionH(o) <> "" Then
                            KillH(o) = "True"
                        End If
                    End If
                    If PositionG(c) = "BishopBlack2" Then
                        If PositionF(u) = "" Then
                            buttonF(u) = 1
                            u = u - 1
                            FixIndice()
                            If PositionE(u) = "" Then
                                buttonE(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionD(u) = "" Then
                                    buttonD(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionC(u) = "" Then
                                        buttonC(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionB(u) = "" Then
                                            buttonB(u) = 1
                                            u = u - 1
                                            FixIndice()
                                            If PositionA(u) = "" Then
                                                buttonA(u) = 1
                                            ElseIf PositionA(u) <> "" Then
                                                KillA(u) = "True"
                                            End If
                                        ElseIf PositionB(u) <> "" Then
                                            KillB(u) = "True"
                                        End If
                                    ElseIf PositionC(u) <> "" Then
                                        KillC(u) = "True"
                                    End If
                                ElseIf PositionD(u) <> "" Then
                                    KillD(u) = "True"
                                End If
                            ElseIf PositionE(u) <> "" Then
                                KillE(u) = "True"
                            End If
                        ElseIf PositionF(u) <> "" Then
                            KillF(u) = "True"
                        End If
                        u = c - 1
                        If PositionH(u) = "" Then
                            buttonH(u) = 1
                        ElseIf PositionH(u) <> "" Then
                            KillH(u) = "True"
                        End If
                    End If

                    If PositionH(c) = "BishopBlack2" Then
                        o = c + 1
                        If PositionG(o) = "" Then
                            buttonG(o) = 1
                            o = o + 1
                            If PositionF(o) = "" Then
                                buttonF(o) = 1
                                o = o + 1
                                If PositionE(o) = "" Then
                                    buttonE(o) = 1
                                    o = o + 1
                                    If PositionD(o) = "" Then
                                        buttonD(o) = 1
                                        o = o + 1
                                        If PositionC(o) = "" Then
                                            buttonC(o) = 1
                                            o = o + 1
                                            If PositionB(o) = "" Then
                                                buttonB(o) = 1
                                                o = o + 1
                                                If PositionA(o) = "" Then
                                                    buttonA(o) = 1
                                                ElseIf PositionA(o) <> "" Then
                                                    KillA(o) = "True"
                                                End If
                                            ElseIf PositionB(o) <> "" Then
                                                KillB(o) = "True"
                                            End If
                                        ElseIf PositionC(o) <> "" Then
                                            KillC(o) = "True"
                                        End If
                                    ElseIf PositionD(o) <> "" Then
                                        KillD(o) = "True"
                                    End If
                                ElseIf PositionE(o) <> "" Then
                                    KillE(o) = "True"
                                End If
                            ElseIf PositionF(o) <> "" Then
                                KillF(o) = "True"
                            End If
                            ElseIf PositionG(o) <> "" Then
                                KillG(o) = "True"
                            End If
                        End If
                    If PositionH(c) = "BishopBlack2" Then
                        u = c - 1
                        If PositionG(u) = "" Then
                            buttonG(u) = 1
                            u = u - 1
                            If PositionF(u) = "" Then
                                buttonF(u) = 1
                                u = u - 1
                                FixIndice()
                                If PositionE(u) = "" Then
                                    buttonE(u) = 1
                                    u = u - 1
                                    FixIndice()
                                    If PositionD(u) = "" Then
                                        buttonD(u) = 1
                                        u = u - 1
                                        FixIndice()
                                        If PositionC(u) = "" Then
                                            buttonC(u) = 1
                                            u = u - 1
                                            FixIndice()
                                            If PositionB(u) = "" Then
                                                buttonB(u) = 1
                                                u = u - 1
                                                FixIndice()
                                                If PositionA(u) = "" Then
                                                    buttonA(u) = 1
                                                ElseIf PositionA(u) <> "" Then
                                                    KillA(u) = "True"
                                                End If
                                            ElseIf PositionB(u) <> "" Then
                                                KillB(u) = "True"
                                            End If
                                        ElseIf PositionC(u) <> "" Then
                                            KillC(u) = "True"
                                        End If
                                    ElseIf PositionD(u) <> "" Then
                                        KillD(u) = "True"
                                    End If
                                ElseIf PositionE(u) <> "" Then
                                    KillE(u) = "True"
                                End If
                            ElseIf PositionF(u) <> "" Then
                                KillF(u) = "True"
                            End If
                        ElseIf PositionG(u) <> "" Then
                            KillG(u) = "True"
                        End If
                    End If
                Loop Until c > 7
                c = 0
        End Select
        SetBackColor()
    End Sub
    Private Sub MovePiece()
        Select Case ChessPiece
            Case "RookBlack1"
                RookBlack1.Top = t
                RookBlack1.Left = l
            Case "RookBlack2"
                RookBlack2.Top = t
                RookBlack2.Left = l
            Case "KnightBlack1"
                KnightBlack1.Top = t
                KnightBlack1.Left = l
            Case "KnightBlack2"
                KnightBlack2.Top = t
                KnightBlack2.Left = l
            Case "BishopBlack1"
                BishopBlack1.Top = t
                BishopBlack1.Left = l
            Case "BishopBlack2"
                BishopBlack2.Top = t
                BishopBlack2.Left = l
            Case PBlack(1)
                PawnBlack1.Top = t
                PawnBlack1.Left = l
            Case PBlack(2)
                PawnBlack2.Top = t
                PawnBlack2.Left = l
            Case PBlack(3)
                PawnBlack3.Top = t
                PawnBlack3.Left = l
            Case PBlack(4)
                PawnBlack4.Top = t
                PawnBlack4.Left = l
            Case PBlack(5)
                PawnBlack5.Top = t
                PawnBlack5.Left = l
            Case PBlack(6)
                PawnBlack6.Top = t
                PawnBlack6.Left = l
            Case PBlack(7)
                PawnBlack7.Top = t
                PawnBlack7.Left = l
            Case PBlack(8)
                PawnBlack8.Top = t
                PawnBlack8.Left = l
            Case "PawnWhite1"
                PawnWhite1.Top = t
                PawnWhite1.Left = l
            Case "PawnWhite2"
                PawnWhite2.Top = t
                PawnWhite2.Left = l
            Case "PawnWhite3"
                PawnWhite3.Top = t
                PawnWhite3.Left = l
            Case "PawnWhite4"
                PawnWhite4.Top = t
                PawnWhite4.Left = l
            Case "PawnWhite5"
                PawnWhite5.Top = t
                PawnWhite5.Left = l
            Case "PawnWhite6"
                PawnWhite6.Top = t
                PawnWhite6.Left = l
            Case "PawnWhite7"
                PawnWhite7.Top = t
                PawnWhite7.Left = l
            Case "PawnWhite8"
                PawnWhite8.Top = t
                PawnWhite8.Left = l
            Case "RookWhite1"
                RookWhite1.Top = t
                RookWhite1.Left = l
            Case "KnightWhite1"
                KnightWhite1.Top = t
                KnightWhite1.Left = l
            Case "BishopWhite1"
                BishopWhite1.Top = t
                BishopWhite1.Left = l
            Case "QueenWhite"
                QueenWhite.Top = t
                QueenWhite.Left = l
            Case "KingWhite"
                KingWhite.Top = t
                KingWhite.Left = l
            Case "BishopWhite2"
                BishopWhite2.Top = t
                BishopWhite2.Left = l
            Case "KnightWhite2"
                KnightWhite2.Top = t
                KnightWhite2.Left = l
            Case "RookWhite2"
                RookWhite2.Top = t
                RookWhite2.Left = l
        End Select

    End Sub
    Private Sub MovePiece2()
        Select Case ChessPiece2
            Case "RookBlack1"
                RookBlack1.Top = t
                RookBlack1.Left = l
            Case PBlack(1)
                PawnBlack1.Top = t
                PawnBlack1.Left = l
            Case PBlack(2)
                PawnBlack2.Top = t
                PawnBlack2.Left = l
            Case PBlack(3)
                PawnBlack3.Top = t
                PawnBlack3.Left = l
            Case PBlack(4)
                PawnBlack4.Top = t
                PawnBlack4.Left = l
            Case PBlack(5)
                PawnBlack5.Top = t
                PawnBlack5.Left = l
            Case PBlack(6)
                PawnBlack6.Top = t
                PawnBlack6.Left = l
            Case PBlack(7)
                PawnBlack7.Top = t
                PawnBlack7.Left = l
            Case PBlack(8)
                PawnBlack8.Top = t
                PawnBlack8.Left = l
            Case "PawnWhite1"
                PawnWhite1.Top = t
                PawnWhite1.Left = l
            Case "PawnWhite2"
                PawnWhite2.Top = t
                PawnWhite2.Left = l
            Case "PawnWhite3"
                PawnWhite3.Top = t
                PawnWhite3.Left = l
            Case "PawnWhite4"
                PawnWhite4.Top = t
                PawnWhite4.Left = l
            Case "PawnWhite5"
                PawnWhite5.Top = t
                PawnWhite5.Left = l
            Case "PawnWhite6"
                PawnWhite6.Top = t
                PawnWhite6.Left = l
            Case "PawnWhite7"
                PawnWhite7.Top = t
                PawnWhite7.Left = l
            Case "PawnWhite8"
                PawnWhite8.Top = t
                PawnWhite8.Left = l
            Case "RookWhite1"
                RookWhite1.Top = t
                RookWhite1.Left = l
            Case "KnightWhite1"
                KnightWhite1.Top = t
                KnightWhite1.Left = l
            Case "BishopWhite1"
                BishopWhite1.Top = t
                BishopWhite1.Left = l
            Case "QueenWhite"
                QueenWhite.Top = t
                QueenWhite.Left = l
            Case "KingWhite"
                KingWhite.Top = t
                KingWhite.Left = l
            Case "BishopWhite2"
                BishopWhite2.Top = t
                BishopWhite2.Left = l
            Case "KnightWhite2"
                KnightWhite2.Top = t
                KnightWhite2.Left = l
            Case "RookWhite2"
                RookWhite2.Top = t
                RookWhite2.Left = l
        End Select
    End Sub
    Private Sub SelectPiece()
        Select Case ChessPiece2
            Case "PawnWhite1"
                If PawnWhite1.Top = PositionTop(k) And PawnWhite1.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "PawnWhite2"
                If PawnWhite2.Top = PositionTop(k) And PawnWhite2.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "PawnWhite3"
                If PawnWhite3.Top = PositionTop(k) And PawnWhite3.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "PawnWhite4"
                If PawnWhite4.Top = PositionTop(k) And PawnWhite4.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "PawnWhite5"
                If PawnWhite5.Top = PositionTop(k) And PawnWhite5.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "PawnWhite6"
                If PawnWhite6.Top = PositionTop(k) And PawnWhite6.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "PawnWhite7"
                If PawnWhite7.Top = PositionTop(k) And PawnWhite7.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "PawnWhite8"
                If PawnWhite8.Top = PositionTop(k) And PawnWhite8.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "RookWhite1"
                If RookWhite1.Top = PositionTop(k) And RookWhite1.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "KnightWhite1"
                If KnightWhite1.Top = PositionTop(k) And KnightWhite1.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "BishopWhite1"
                If BishopWhite1.Top = PositionTop(k) And BishopWhite1.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                        MovePiece2()
                    Check = 1
                End If
            Case "QueenWhite"
                If QueenWhite.Top = PositionTop(k) And QueenWhite.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                         MovePiece2()
                    Check = 1
                End If
            Case "KingWhite"
                If KingWhite.Top = PositionTop(k) And KingWhite.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                    MovePiece2()
                    Check = 1
                End If
            Case "BishopWhite2"
                If BishopWhite2.Top = PositionTop(k) And BishopWhite2.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                         MovePiece2()
                    Check = 1
                End If
            Case "KnightWhite2"
                If KnightWhite2.Top = PositionTop(k) And KnightWhite2.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                        MovePiece2()
                    Check = 1
                End If
            Case "RookWhite2"
                If RookWhite2.Top = PositionTop(k) And RookWhite2.Left = PositionLeft(p) Then
                    t = PositionTop(k)
                    l = PositionLeft(p)
                    MovePiece()
                    t = PositionTop2(f)
                    l = PositionLeft2(f)
                    f = f + 1
                        MovePiece2()
                    Check = 1
                End If
        End Select
    End Sub
    Private Sub KillSistem()
        Do
            p = p + 1
            k = k + 1
            If KillA(p) = "True" Then
                SelectPiece()
            End If
            k = k + 1
            If KillB(p) = "True" Then
                SelectPiece()
            End If
            k = k + 1
            If KillC(p) = "True" Then
                SelectPiece()
            End If
            k = k + 1
            If KillD(p) = "True" Then
                SelectPiece()
            End If
            k = k + 1
            If KillE(p) = "True" Then
                SelectPiece()
            End If
            k = k + 1
            If KillF(p) = "True" Then
                SelectPiece()
            End If
            k = k + 1
            If KillG(p) = "True" Then
                SelectPiece()
            End If
            k = k + 1
            If KillH(p) = "True" Then
                SelectPiece()
            End If
            k = 0
        Loop Until p = 8 Or Check = 1
        p = 0
        Check = 0
        clean()
        ButtonDisabled()
        CheckPosition()
        ButtonHide()
        SetBackGround()
        For i = 1 To 8
            t = PositionTop(8)
            l = PositionLeft(i)
            If PawnBlack1.Top = t And PawnBlack1.Left = l And b(1) = 0 Then
                b(1) = 1
                q = 1
                combobox.ShowDialog()
            End If
            If PawnBlack2.Top = t And PawnBlack2.Left = l And b(2) = 0 Then
                b(2) = 1
                q = 2
                combobox.ShowDialog()
            End If
            If PawnBlack3.Top = t And PawnBlack3.Left = l And b(3) = 0 Then
                b(3) = 1
                q = 3
                combobox.ShowDialog()
            End If
            If PawnBlack4.Top = t And PawnBlack4.Left = l And b(4) = 0 Then
                b(4) = 1
                q = 4
                combobox.ShowDialog()
            End If
            If PawnBlack5.Top = t And PawnBlack5.Left = l And b(5) = 0 Then
                b(5) = 1
                q = 5
                combobox.ShowDialog()
            End If
            If PawnBlack6.Top = t And PawnBlack6.Left = l And b(6) = 0 Then
                b(6) = 1
                q = 6
                combobox.ShowDialog()
            End If
            If PawnBlack7.Top = t And PawnBlack7.Left = l And b(7) = 0 Then
                b(7) = 1
                q = 7
                combobox.ShowDialog()
            End If
            If PawnBlack8.Top = t And PawnBlack8.Left = l And b(8) = 0 Then
                b(8) = 1
                q = 8
                combobox.ShowDialog()
            End If
        Next
        SetBackColor()
    End Sub

    Private Sub PawnBlack1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnBlack1.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = PBlack(1)
        CheckPosition()
        BottonEnabled()
        ButtonHide()
    End Sub

    Private Sub RookBlack1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RookBlack1.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = "RookBlack1"
        CheckPosition()
        BottonEnabled()
        ButtonHide()
        TextBox1.Text = KillG(1)
    End Sub

    Private Sub PawnBlack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnBlack2.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = PBlack(2)
        CheckPosition()
        BottonEnabled()
        ButtonHide()
    End Sub

    Private Sub PawnBlack3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnBlack3.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = PBlack(3)
        CheckPosition()
        BottonEnabled()
        ButtonHide()
    End Sub

    Private Sub PawnBlack4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnBlack4.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = PBlack(4)
        CheckPosition()
        BottonEnabled()
        ButtonHide()
    End Sub

    Private Sub PawnBlack5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnBlack5.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = PBlack(5)
        CheckPosition()
        BottonEnabled()
        ButtonHide()
    End Sub

    Private Sub PawnBlack6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnBlack6.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = PBlack(6)
        CheckPosition()
        BottonEnabled()
        ButtonHide()
    End Sub

    Private Sub PawnBlack7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnBlack7.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = PBlack(7)
        CheckPosition()
        BottonEnabled()
        ButtonHide()
    End Sub

    Private Sub PawnBlack8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnBlack8.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = PBlack(8)
        CheckPosition()
        BottonEnabled()
        ButtonHide()
    End Sub

    Private Sub KnightBlack1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnightBlack1.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = "KnightBlack1"
        CheckPosition()
        BottonEnabled()
        ButtonHide()
        TextBox1.Text = KillG(4)
    End Sub

    Private Sub RookBlack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RookBlack2.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = "RookBlack2"
        CheckPosition()
        BottonEnabled()
        ButtonHide()
    End Sub

    Private Sub BishopBlack1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BishopBlack1.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = "BishopBlack1"
        CheckPosition()
        BottonEnabled()
        ButtonHide()

    End Sub

    Private Sub BishopBlack2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BishopBlack2.Click
        ButtonDisabled()
        ButtonHide()
        ChessPiece = "BishopBlack2"
        CheckPosition()
        BottonEnabled()
        ButtonHide()
        TextBox1.Text = KillG(8)
    End Sub

    Private Sub PawnWhite1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnWhite1.Click
        ChessPiece2 = "PawnWhite1"
        KillSistem()
    End Sub

    Private Sub PawnWhite2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnWhite2.Click
        ChessPiece2 = "PawnWhite2"
        KillSistem()
    End Sub

    Private Sub PawnWhite3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnWhite3.Click
        ChessPiece2 = "PawnWhite3"
        KillSistem()
    End Sub

    Private Sub PawnWhite4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnWhite4.Click
        ChessPiece2 = "PawnWhite4"
        KillSistem()
    End Sub

    Private Sub PawnWhite5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnWhite5.Click
        ChessPiece2 = "PawnWhite5"
        KillSistem()
    End Sub

    Private Sub PawnWhite6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnWhite6.Click
        ChessPiece2 = "PawnWhite6"
        KillSistem()
    End Sub

    Private Sub PawnWhite7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnWhite7.Click
        ChessPiece2 = "PawnWhite7"
        KillSistem()
    End Sub

    Private Sub PawnWhite8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PawnWhite8.Click
        ChessPiece2 = "PawnWhite8"
        KillSistem()
    End Sub

    Private Sub RookWhite1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RookWhite1.Click
        ChessPiece2 = "RookWhite1"
        KillSistem()
    End Sub

    Private Sub KnightWhite1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnightWhite1.Click
        ChessPiece2 = "KnightWhite1"
        KillSistem()
    End Sub

    Private Sub BishopWhite1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BishopWhite1.Click
        ChessPiece2 = "BishopWhite1"
        KillSistem()
    End Sub

    Private Sub QueenWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QueenWhite.Click
        ChessPiece2 = "QueenWhite"
        KillSistem()
    End Sub

    Private Sub KingWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KingWhite.Click
        ChessPiece2 = "KingWhite"
        KillSistem()
    End Sub

    Private Sub BishopWhite2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BishopWhite2.Click
        ChessPiece2 = "BishopWhite2"
        KillSistem()
    End Sub

    Private Sub KnightWhite2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KnightWhite2.Click
        ChessPiece2 = "KnightWhite2"
        KillSistem()
    End Sub

    Private Sub RookWhite2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RookWhite2.Click
        ChessPiece2 = "RookWhite2"
        KillSistem()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        f = 1
        clean()
        PositionTopLeft()
        ButtonDisabled()
        ButtonHide()
        CheckPosition()
    End Sub

    Private Sub A1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A1.Click
        t = PositionTop(1)
        l = PositionLeft(1)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub A2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2.Click
        t = PositionTop(1)
        l = PositionLeft(2)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub A3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A3.Click
        t = PositionTop(1)
        l = PositionLeft(3)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub A4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A4.Click
        t = PositionTop(1)
        l = PositionLeft(4)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub A5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A5.Click
        t = PositionTop(1)
        l = PositionLeft(5)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub A6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A6.Click
        t = PositionTop(1)
        l = PositionLeft(6)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub A7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A7.Click
        t = PositionTop(1)
        l = PositionLeft(7)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub A8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A8.Click
        t = PositionTop(1)
        l = PositionLeft(8)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        t = PositionTop(2)
        l = PositionLeft(1)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        t = PositionTop(2)
        l = PositionLeft(2)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        t = PositionTop(2)
        l = PositionLeft(3)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        t = PositionTop(2)
        l = PositionLeft(4)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub B5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5.Click
        t = PositionTop(2)
        l = PositionLeft(5)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub B6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B6.Click
        t = PositionTop(2)
        l = PositionLeft(6)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub B7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B7.Click
        t = PositionTop(2)
        l = PositionLeft(7)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub B8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B8.Click
        t = PositionTop(2)
        l = PositionLeft(8)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub C1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1.Click
        t = PositionTop(3)
        l = PositionLeft(1)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub C2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C2.Click
        t = PositionTop(3)
        l = PositionLeft(2)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub C3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C3.Click
        t = PositionTop(3)
        l = PositionLeft(3)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub C4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C4.Click
        t = PositionTop(3)
        l = PositionLeft(4)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub C5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C5.Click
        t = PositionTop(3)
        l = PositionLeft(5)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub C6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C6.Click
        t = PositionTop(3)
        l = PositionLeft(6)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub C7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C7.Click
        t = PositionTop(3)
        l = PositionLeft(7)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub C8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C8.Click
        t = PositionTop(3)
        l = PositionLeft(8)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub D1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1.Click
        t = PositionTop(4)
        l = PositionLeft(1)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub D2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2.Click
        t = PositionTop(4)
        l = PositionLeft(2)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub D3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D3.Click
        t = PositionTop(4)
        l = PositionLeft(3)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub D4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D4.Click
        t = PositionTop(4)
        l = PositionLeft(4)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub D5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D5.Click
        t = PositionTop(4)
        l = PositionLeft(5)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub D6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D6.Click
        t = PositionTop(4)
        l = PositionLeft(6)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub D7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D7.Click
        t = PositionTop(4)
        l = PositionLeft(7)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub D8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D8.Click
        t = PositionTop(4)
        l = PositionLeft(8)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub E1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E1.Click
        t = PositionTop(5)
        l = PositionLeft(1)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub E2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E2.Click
        t = PositionTop(5)
        l = PositionLeft(2)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub E3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E3.Click
        t = PositionTop(5)
        l = PositionLeft(3)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub E4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E4.Click
        t = PositionTop(5)
        l = PositionLeft(4)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub E5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E5.Click
        t = PositionTop(5)
        l = PositionLeft(5)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub E6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E6.Click
        t = PositionTop(5)
        l = PositionLeft(6)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub E7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E7.Click
        t = PositionTop(5)
        l = PositionLeft(7)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub E8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles E8.Click
        t = PositionTop(5)
        l = PositionLeft(8)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub F1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F1.Click
        t = PositionTop(6)
        l = PositionLeft(1)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub F2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F2.Click
        t = PositionTop(6)
        l = PositionLeft(2)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub F3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F3.Click
        t = PositionTop(6)
        l = PositionLeft(3)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub F4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4.Click
        t = PositionTop(6)
        l = PositionLeft(4)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub F5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F5.Click
        t = PositionTop(6)
        l = PositionLeft(5)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub F6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F6.Click
        t = PositionTop(6)
        l = PositionLeft(6)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub F7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F7.Click
        t = PositionTop(6)
        l = PositionLeft(7)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub F8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F8.Click
        t = PositionTop(6)
        l = PositionLeft(8)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub G1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G1.Click
        t = PositionTop(7)
        l = PositionLeft(1)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub G2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G2.Click
        t = PositionTop(7)
        l = PositionLeft(2)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub G3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G3.Click
        t = PositionTop(7)
        l = PositionLeft(3)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub G4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G4.Click
        t = PositionTop(7)
        l = PositionLeft(4)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub G5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G5.Click
        t = PositionTop(7)
        l = PositionLeft(5)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub G6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G6.Click
        t = PositionTop(7)
        l = PositionLeft(6)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub G7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G7.Click
        t = PositionTop(7)
        l = PositionLeft(7)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub G8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles G8.Click
        t = PositionTop(7)
        l = PositionLeft(8)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        SetBackColor()
    End Sub

    Private Sub H1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H1.Click
        t = PositionTop(8)
        l = PositionLeft(1)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        If PawnBlack1.Top = t And PawnBlack1.Left = l And b(1) = 0 Then
            b(1) = 1
            q = 1
            combobox.ShowDialog()
        End If
        If PawnBlack2.Top = t And PawnBlack2.Left = l And b(2) = 0 Then
            b(2) = 1
            q = 2
            combobox.ShowDialog()
        End If
        If PawnBlack3.Top = t And PawnBlack3.Left = l And b(3) = 0 Then
            b(3) = 1
            q = 3
            combobox.ShowDialog()
        End If
        If PawnBlack4.Top = t And PawnBlack4.Left = l And b(4) = 0 Then
            b(4) = 1
            q = 4
            combobox.ShowDialog()
        End If
        If PawnBlack5.Top = t And PawnBlack5.Left = l And b(5) = 0 Then
            b(5) = 1
            q = 5
            combobox.ShowDialog()
        End If
        If PawnBlack6.Top = t And PawnBlack6.Left = l And b(6) = 0 Then
            b(6) = 1
            q = 6
            combobox.ShowDialog()
        End If
        If PawnBlack7.Top = t And PawnBlack7.Left = l And b(7) = 0 Then
            b(7) = 1
            q = 7
            combobox.ShowDialog()
        End If
        If PawnBlack8.Top = t And PawnBlack8.Left = l And b(8) = 0 Then
            b(8) = 1
            q = 8
            combobox.ShowDialog()
        End If
        SetBackColor()
    End Sub

    Private Sub H2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H2.Click
        t = PositionTop(8)
        l = PositionLeft(2)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        If PawnBlack1.Top = t And PawnBlack1.Left = l And b(1) = 0 Then
            b(1) = 1
            q = 1
            combobox.ShowDialog()
        End If
        If PawnBlack2.Top = t And PawnBlack2.Left = l And b(2) = 0 Then
            b(2) = 1
            q = 2
            combobox.ShowDialog()
        End If
        If PawnBlack3.Top = t And PawnBlack3.Left = l And b(3) = 0 Then
            b(3) = 1
            q = 3
            combobox.ShowDialog()
        End If
        If PawnBlack4.Top = t And PawnBlack4.Left = l And b(4) = 0 Then
            b(4) = 1
            q = 4
            combobox.ShowDialog()
        End If
        If PawnBlack5.Top = t And PawnBlack5.Left = l And b(5) = 0 Then
            b(5) = 1
            q = 5
            combobox.ShowDialog()
        End If
        If PawnBlack6.Top = t And PawnBlack6.Left = l And b(6) = 0 Then
            b(6) = 1
            q = 6
            combobox.ShowDialog()
        End If
        If PawnBlack7.Top = t And PawnBlack7.Left = l And b(7) = 0 Then
            b(7) = 1
            q = 7
            combobox.ShowDialog()
        End If
        If PawnBlack8.Top = t And PawnBlack8.Left = l And b(8) = 0 Then
            b(8) = 1
            q = 8
            combobox.ShowDialog()
        End If
        SetBackColor()
    End Sub

    Private Sub H3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H3.Click
        t = PositionTop(8)
        l = PositionLeft(3)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        If PawnBlack1.Top = t And PawnBlack1.Left = l And b(1) = 0 Then
            b(1) = 1
            q = 1
            combobox.ShowDialog()
        End If
        If PawnBlack2.Top = t And PawnBlack2.Left = l And b(2) = 0 Then
            b(2) = 1
            q = 2
            combobox.ShowDialog()
        End If
        If PawnBlack3.Top = t And PawnBlack3.Left = l And b(3) = 0 Then
            b(3) = 1
            q = 3
            combobox.ShowDialog()
        End If
        If PawnBlack4.Top = t And PawnBlack4.Left = l And b(4) = 0 Then
            b(4) = 1
            q = 4
            combobox.ShowDialog()
        End If
        If PawnBlack5.Top = t And PawnBlack5.Left = l And b(5) = 0 Then
            b(5) = 1
            q = 5
            combobox.ShowDialog()
        End If
        If PawnBlack6.Top = t And PawnBlack6.Left = l And b(6) = 0 Then
            b(6) = 1
            q = 6
            combobox.ShowDialog()
        End If
        If PawnBlack7.Top = t And PawnBlack7.Left = l And b(7) = 0 Then
            b(7) = 1
            q = 7
            combobox.ShowDialog()
        End If
        If PawnBlack8.Top = t And PawnBlack8.Left = l And b(8) = 0 Then
            b(8) = 1
            q = 8
            combobox.ShowDialog()
        End If
        SetBackColor()
    End Sub

    Private Sub H4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H4.Click
        t = PositionTop(8)
        l = PositionLeft(4)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        If PawnBlack1.Top = t And PawnBlack1.Left = l And b(1) = 0 Then
            b(1) = 1
            q = 1
            combobox.ShowDialog()
        End If
        If PawnBlack2.Top = t And PawnBlack2.Left = l And b(2) = 0 Then
            b(2) = 1
            q = 2
            combobox.ShowDialog()
        End If
        If PawnBlack3.Top = t And PawnBlack3.Left = l And b(3) = 0 Then
            b(3) = 1
            q = 3
            combobox.ShowDialog()
        End If
        If PawnBlack4.Top = t And PawnBlack4.Left = l And b(4) = 0 Then
            b(4) = 1
            q = 4
            combobox.ShowDialog()
        End If
        If PawnBlack5.Top = t And PawnBlack5.Left = l And b(5) = 0 Then
            b(5) = 1
            q = 5
            combobox.ShowDialog()
        End If
        If PawnBlack6.Top = t And PawnBlack6.Left = l And b(6) = 0 Then
            b(6) = 1
            q = 6
            combobox.ShowDialog()
        End If
        If PawnBlack7.Top = t And PawnBlack7.Left = l And b(7) = 0 Then
            b(7) = 1
            q = 7
            combobox.ShowDialog()
        End If
        If PawnBlack8.Top = t And PawnBlack8.Left = l And b(8) = 0 Then
            b(8) = 1
            q = 8
            combobox.ShowDialog()
        End If
        SetBackColor()
    End Sub

    Private Sub H5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H5.Click
        t = PositionTop(8)
        l = PositionLeft(5)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        If PawnBlack1.Top = t And PawnBlack1.Left = l And b(1) = 0 Then
            b(1) = 1
            q = 1
            combobox.ShowDialog()
        End If
        If PawnBlack2.Top = t And PawnBlack2.Left = l And b(2) = 0 Then
            b(2) = 1
            q = 2
            combobox.ShowDialog()
        End If
        If PawnBlack3.Top = t And PawnBlack3.Left = l And b(3) = 0 Then
            b(3) = 1
            q = 3
            combobox.ShowDialog()
        End If
        If PawnBlack4.Top = t And PawnBlack4.Left = l And b(4) = 0 Then
            b(4) = 1
            q = 4
            combobox.ShowDialog()
        End If
        If PawnBlack5.Top = t And PawnBlack5.Left = l And b(5) = 0 Then
            b(5) = 1
            q = 5
            combobox.ShowDialog()
        End If
        If PawnBlack6.Top = t And PawnBlack6.Left = l And b(6) = 0 Then
            b(6) = 1
            q = 6
            combobox.ShowDialog()
        End If
        If PawnBlack7.Top = t And PawnBlack7.Left = l And b(7) = 0 Then
            b(7) = 1
            q = 7
            combobox.ShowDialog()
        End If
        If PawnBlack8.Top = t And PawnBlack8.Left = l And b(8) = 0 Then
            b(8) = 1
            q = 8
            combobox.ShowDialog()
        End If
        SetBackColor()
    End Sub

    Private Sub H6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H6.Click
        t = PositionTop(8)
        l = PositionLeft(6)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        If PawnBlack1.Top = t And PawnBlack1.Left = l And b(1) = 0 Then
            b(1) = 1
            q = 1
            combobox.ShowDialog()
        End If
        If PawnBlack2.Top = t And PawnBlack2.Left = l And b(2) = 0 Then
            b(2) = 1
            q = 2
            combobox.ShowDialog()
        End If
        If PawnBlack3.Top = t And PawnBlack3.Left = l And b(3) = 0 Then
            b(3) = 1
            q = 3
            combobox.ShowDialog()
        End If
        If PawnBlack4.Top = t And PawnBlack4.Left = l And b(4) = 0 Then
            b(4) = 1
            q = 4
            combobox.ShowDialog()
        End If
        If PawnBlack5.Top = t And PawnBlack5.Left = l And b(5) = 0 Then
            b(5) = 1
            q = 5
            combobox.ShowDialog()
        End If
        If PawnBlack6.Top = t And PawnBlack6.Left = l And b(6) = 0 Then
            b(6) = 1
            q = 6
            combobox.ShowDialog()
        End If
        If PawnBlack7.Top = t And PawnBlack7.Left = l And b(7) = 0 Then
            b(7) = 1
            q = 7
            combobox.ShowDialog()
        End If
        If PawnBlack8.Top = t And PawnBlack8.Left = l And b(8) = 0 Then
            b(8) = 1
            q = 8
            combobox.ShowDialog()
        End If
        SetBackColor()
    End Sub

    Private Sub H7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H7.Click
        t = PositionTop(8)
        l = PositionLeft(7)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        If PawnBlack1.Top = t And PawnBlack1.Left = l And b(1) = 0 Then
            b(1) = 1
            q = 1
            combobox.ShowDialog()
        End If
        If PawnBlack2.Top = t And PawnBlack2.Left = l And b(2) = 0 Then
            b(2) = 1
            q = 2
            combobox.ShowDialog()
        End If
        If PawnBlack3.Top = t And PawnBlack3.Left = l And b(3) = 0 Then
            b(3) = 1
            q = 3
            combobox.ShowDialog()
        End If
        If PawnBlack4.Top = t And PawnBlack4.Left = l And b(4) = 0 Then
            b(4) = 1
            q = 4
            combobox.ShowDialog()
        End If
        If PawnBlack5.Top = t And PawnBlack5.Left = l And b(5) = 0 Then
            b(5) = 1
            q = 5
            combobox.ShowDialog()
        End If
        If PawnBlack6.Top = t And PawnBlack6.Left = l And b(6) = 0 Then
            b(6) = 1
            q = 6
            combobox.ShowDialog()
        End If
        If PawnBlack7.Top = t And PawnBlack7.Left = l And b(7) = 0 Then
            b(7) = 1
            q = 7
            combobox.ShowDialog()
        End If
        If PawnBlack8.Top = t And PawnBlack8.Left = l And b(8) = 0 Then
            b(8) = 1
            q = 8
            combobox.ShowDialog()
        End If
        SetBackColor()
    End Sub

    Private Sub H8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles H8.Click
        t = PositionTop(8)
        l = PositionLeft(8)
        MovePiece()
        CheckPosition()
        ButtonDisabled()
        ButtonHide()
        SetBackGround()
        ChessPiece = ""
        If PawnBlack1.Top = t And PawnBlack1.Left = l And b(1) = 0 Then
            b(1) = 1
            q = 1
            combobox.ShowDialog()
        End If
        If PawnBlack2.Top = t And PawnBlack2.Left = l And b(2) = 0 Then
            b(2) = 1
            q = 2
            combobox.ShowDialog()
        End If
        If PawnBlack3.Top = t And PawnBlack3.Left = l And b(3) = 0 Then
            b(3) = 1
            q = 3
            combobox.ShowDialog()
        End If
        If PawnBlack4.Top = t And PawnBlack4.Left = l And b(4) = 0 Then
            b(4) = 1
            q = 4
            combobox.ShowDialog()
        End If
        If PawnBlack5.Top = t And PawnBlack5.Left = l And b(5) = 0 Then
            b(5) = 1
            q = 5
            combobox.ShowDialog()
        End If
        If PawnBlack6.Top = t And PawnBlack6.Left = l And b(6) = 0 Then
            b(6) = 1
            q = 6
            combobox.ShowDialog()
        End If
        If PawnBlack7.Top = t And PawnBlack7.Left = l And b(7) = 0 Then
            b(7) = 1
            q = 7
            combobox.ShowDialog()
        End If
        If PawnBlack8.Top = t And PawnBlack8.Left = l And b(8) = 0 Then
            b(8) = 1
            q = 8
            combobox.ShowDialog()
        End If
        SetBackColor()
    End Sub








End Class