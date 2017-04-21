Public Class VisualBoard

    Private NewGame As Game
    Public CurrentPlayer As Boolean = False 'Red Side always start first
    Public PosX As Integer
    Public PosY As Integer
    Public ChessUp As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ChessTimer.Enabled = True

        NewGame = New Game

    End Sub

    Private Sub ChessTimer_Tick(sender As Object, e As EventArgs) Handles ChessTimer.Tick

        If CurrentPlayer = True Then 'Display Player Turn
            PlayerTurn.Image = My.Resources.Black
        Else
            PlayerTurn.Image = My.Resources.Red
        End If

    End Sub

End Class
