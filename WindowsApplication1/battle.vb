Public Class battle
    Private battleId As Integer
    Private battleCreatures As Collection

    Public Sub New()
        battleId = -1
        battleCreatures = New Collection
        battleCreatures.Add(New creature())
        battleCreatures.Add(New creature())
    End Sub

    Public Sub New(id, creature1, creature2)
        battleId = id
        battleCreatures = New Collection
        battleCreatures.Add(creature1)
        battleCreatures.Add(creature2)
    End Sub

    Public Property id()
        Get
            Return battleId
        End Get
        Set(value)
            battleId = value
        End Set
    End Property

    Public Property creature1()
        Get
            Return battleCreatures(1)
        End Get
        Set(value)
            battleCreatures.Remove(1)
            battleCreatures.Add(value, 1, 1)
        End Set
    End Property

    Public Property creature2()
        Get
            Return battleCreatures(2)
        End Get
        Set(value)
            battleCreatures.Remove(2)
            battleCreatures.Add(value, 2)
        End Set
    End Property
End Class
