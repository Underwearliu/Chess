Public Class Player

    '## Side '(True = Black; False = Red)
    Public Shared ArrayChessPiece(16) As ChessPiece
    Private BoardX(16) As Byte  'BoardX of chesspiece
    Private BoardY(16) As Byte  'BoardY of chesspiece


    Private Sub SetUpChess(ByVal Side As Boolean)

        If Side = True Then 'Black Side Chess
            For a = 1 To 16
                Select Case a

                    Case 1 To 5
                        BoardX(a) = (a - 1) * 2
                        BoardY(a) = 3
                        ArrayChessPiece(a) = New ChessPiece(a, 1, My.Resources.Chess_Pieces___Soldier__Black_, BoardX(a), BoardY(a), Side)

                    Case 6
                        BoardX(a) = 4
                        BoardY(a) = 0
                        ArrayChessPiece(a) = New ChessPiece(a, 2, My.Resources.Chess_Pieces___General__Black_, BoardX(a), BoardY(a), Side)

                    Case 7 To 8
                        If a = 7 Then
                            BoardX(a) = 0
                        Else : BoardX(a) = 8
                        End If
                        BoardY(a) = 0
                        ArrayChessPiece(a) = New ChessPiece(a, 3, My.Resources.Chess_Pieces___Chariot__Black_, BoardX(a), BoardY(a), Side)

                    Case 9 To 10
                        If a = 9 Then
                            BoardX(a) = 1
                        Else : BoardX(a) = 7
                        End If
                        BoardY(a) = 0
                        ArrayChessPiece(a) = New ChessPiece(a, 4, My.Resources.Chess_Pieces___Horse__Black_, BoardX(a), BoardY(a), Side)

                    Case 11 To 12
                        If a = 11 Then
                            BoardX(a) = 2
                        Else BoardX(a) = 6
                        End If
                        BoardY(a) = 0
                        ArrayChessPiece(a) = New ChessPiece(a, 5, My.Resources.Chess_Pieces___Elephant__Black_, BoardX(a), BoardY(a), Side)

                    Case 13 To 14
                        If a = 13 Then
                            BoardX(a) = 3
                        Else BoardX(a) = 5
                        End If
                        BoardY(a) = 0
                        ArrayChessPiece(a) = New ChessPiece(a, 6, My.Resources.Chess_Pieces___Advisor__Black_, BoardX(a), BoardY(a), Side)

                    Case 15 To 16
                        If a = 15 Then
                            BoardX(a) = 1
                        Else BoardX(a) = 7
                        End If
                        BoardY(a) = 2
                        ArrayChessPiece(a) = New ChessPiece(a, 7, My.Resources.Chess_Pieces___Cannon__Black_, BoardX(a), BoardY(a), Side)
                End Select
            Next

        Else : For b = 1 To 16 'Red Side Chess Pieces
                Select Case b
                    Case 1 To 5
                        BoardX(b) = (b - 1) * 2
                        BoardY(b) = 6
                        ArrayChessPiece(b) = New ChessPiece(b, 1, My.Resources.Chess_Pieces___Soldier__Red_, BoardX(b), BoardY(b), Side)

                    Case 6
                        BoardX(b) = 4
                        BoardY(b) = 9
                        ArrayChessPiece(b) = New ChessPiece(b, 2, My.Resources.Chess_Pieces___General__Red_, BoardX(b), BoardY(b), Side)

                    Case 7 To 8
                        If b = 7 Then
                            BoardX(b) = 0
                        Else : BoardX(b) = 8
                        End If
                        BoardY(b) = 9
                        ArrayChessPiece(b) = New ChessPiece(b, 3, My.Resources.Chess_Pieces___Chariot__Red_, BoardX(b), BoardY(b), Side)

                    Case 9 To 10
                        If b = 9 Then
                            BoardX(b) = 1
                        Else : BoardX(b) = 7
                        End If
                        BoardY(b) = 9
                        ArrayChessPiece(b) = New ChessPiece(b, 4, My.Resources.Chess_Pieces___Horse__Red_, BoardX(b), BoardY(b), Side)

                    Case 11 To 12
                        If b = 11 Then
                            BoardX(b) = 2
                        Else : BoardX(b) = 6
                        End If
                        BoardY(b) = 9
                        ArrayChessPiece(b) = New ChessPiece(b, 5, My.Resources.Chess_Pieces___Elephant__Red_, BoardX(b), BoardY(b), Side)

                    Case 13 To 14
                        If b = 13 Then
                            BoardX(b) = 3
                        Else : BoardX(b) = 5
                        End If
                        BoardY(b) = 9
                        ArrayChessPiece(b) = New ChessPiece(b, 6, My.Resources.Chess_Pieces___Advisor__Red_, BoardX(b), BoardY(b), Side)

                    Case 15 To 16
                        If b = 15 Then
                            BoardX(b) = 1
                        Else : BoardX(b) = 7
                        End If
                        BoardY(b) = 7
                        ArrayChessPiece(b) = New ChessPiece(b, 7, My.Resources.Chess_Pieces___Cannon__Red_, BoardX(b), BoardY(b), Side)
                End Select
            Next
        End If

    End Sub


    Public Sub New(ByVal Side As Boolean)

        SetUpChess(Side)

    End Sub
End Class
