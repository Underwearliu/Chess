Public Class ChessPiece

    'Details of chesspieces
    Private ChessID As Byte
    Private ChessValue As Byte
    Private Alive As Boolean
    Private Side As Boolean '(True = Black; False = Red)
    Private ChessX As Integer
    Private ChessY As Integer

    Private Chess As New PictureBox
    Private ChessUp As PickUpChess


    Public Sub New(ByRef ID As Byte, ByRef Value As Byte, ByRef Icon As Image, ByRef BoardX As Byte, ByRef BoardY As Byte, ByRef ChessSide As Boolean)

        'Stores details into Player's chesspieces
        ChessID = ID
        ChessValue = Value
        Alive = True
        If ChessSide = True Then
            Side = True
        Else
            Side = False
        End If
        ChessX = BoardX
        ChessY = BoardY

        'Visual Display of chesspieces
        Chess.Parent = VisualBoard
        Chess.Image = New Bitmap(Icon, New Size(50, 50))
        Chess.Size = Chess.Image.Size
        Chess.Location = New Point(Board.StartX + (BoardX * Board.IntervalX), Board.StartY + (BoardY * Board.IntervalY))
        Chess.BringToFront()
        Chess.Visible = True

        AddHandler Chess.Click, AddressOf chess_Click

    End Sub

    Private Sub chess_Click(sender As Object, e As EventArgs)
        Dim CurrentID As Byte
        Dim CurrentSide As Boolean

        If Side = VisualBoard.CurrentPlayer And VisualBoard.ChessUp = False Then
            'VisualBoard.CurrentPlayer = Not VisualBoard.CurrentPlayer
            CurrentID = ChessID
            CurrentSide = Side
            VisualBoard.ChessUp = True
            ChessUp = New PickUpChess(ChessValue, Side, ChessX, ChessY)
        End If

    End Sub

End Class
