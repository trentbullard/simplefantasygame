Module dice
    Dim die = New Random()

    Public Function Roll(number)
        Return die.Next(1, number + 1)
    End Function
End Module
