Module currentCreatures
    Public currentCreature As New Collection
    Public Sub initCreatures()
        currentCreature.Add(New creature(), 1)
        currentCreature.Add(New creature(), 2)
    End Sub

    Public Function strdiff()
        Return currentCreature(1).strength - currentCreature(2).strength
    End Function
End Module
