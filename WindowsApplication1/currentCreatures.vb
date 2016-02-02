Module currentCreatures
    Public currentCreature As New creature

    Public Function strdiff()
        Return currentCreature.strength - playerTarget.strength
    End Function
End Module
