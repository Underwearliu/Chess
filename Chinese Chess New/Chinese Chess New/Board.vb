Public Class Board

    Public Const BoardX As Byte = 8
    Public Const BoardY As Byte = 9
    Public Const StartX = 21 'Top left hand corner of the board
    Public Const StartY = 8  'Top left hand corner of the board
    Public Const IntervalX As SByte = 86 'For Chesspieces gap
    Public Const IntervalY As SByte = 77 'For Chesspieces gap

    Private ChessMove As Move

    Public Shared PossBox(BoardX, BoardY) As PictureBox


    Public Sub New()
        SetupPossible()
    End Sub


    Private Sub SetupPossible()
        Const PossX As Integer = IntervalX - 50
        Const PossY As Integer = IntervalY - 40
        Dim Image As New Bitmap(My.Resources.Target, New Size(PossX, PossY))
        For x = 0 To BoardX
            For y = 0 To BoardY
                PossBox(x, y) = New PictureBox
                PossBox(x, y).Parent = VisualBoard
                PossBox(x, y).Image = Image
                PossBox(x, y).Size = PossBox(x, y).Image.Size()
                PossBox(x, y).Location = New Point(StartX + (x * IntervalX + 8), StartY + (y * IntervalY + 8))
                PossBox(x, y).BringToFront()
                PossBox(x, y).Visible = False
                AddHandler PossBox(x, y).Click, AddressOf possBox_Click
            Next
        Next
    End Sub

    Private Sub possBox_Click(sender As Object, e As EventArgs)
        If VisualBoard.ChessUp = True Then
            ChessMove = New Move
        End If
        VisualBoard.ChessUp = False
        VisualBoard.CurrentPlayer = Not VisualBoard.CurrentPlayer
    End Sub

End Class
