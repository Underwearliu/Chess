Public Class Move

    '1 Soldier
    '2 General
    '3 Chariot
    '4 Horse
    '5 Elephant
    '6 Advisor
    '7 Cannon
    'True = Black
    'False = Red

    Public Sub New()


        For b = 1 To PickUpChess.getPossCounter
            MakePossInvisible(PickUpChess.getXPoss(b), PickUpChess.getYPoss(b))
        Next

    End Sub

    Public Sub MakePossInvisible(ByVal PossX As Byte, ByVal PossY As Byte)
        Board.PossBox(PossX, PossY).Visible = False
    End Sub
End Class
