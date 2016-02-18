Module Dice
    Dim die = New Random(CDbl(Date.Now.Millisecond))

    Public Function Roll(number)
        Return die.Next(1, number + 1)
    End Function
End Module
