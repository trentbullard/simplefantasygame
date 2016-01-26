Public Class attack
    Private attackid As Integer
    Private attackAggressor As creature
    Private attackVictim As creature
    Private attackDamage As Integer
    Private attackBattle As battle

    Public Sub New()
        If Roll(100) < 50 + strdiff() Then
            attackAggressor = currentCreature(1)
            attackVictim = currentCreature(2)
        Else
            attackAggressor = currentCreature(2)
            attackVictim = currentCreature(1)
        End If

        If attackAggressor.strength > attackVictim.armor Then
            attackDamage = Roll(15)
        Else
            attackDamage = Roll(10)
        End If
    End Sub

    Public Sub New(id, aggressor, victim, damage, battle)
        attackid = id
        attackAggressor = aggressor
        attackVictim = victim
        attackDamage = damage
        attackBattle = battle
    End Sub

    Public Property id()
        Get
            Return attackid
        End Get
        Set(value)
            attackid = value
        End Set
    End Property

    Public Property aggressor()
        Get
            Return attackAggressor
        End Get
        Set(value)
            attackAggressor = value
        End Set
    End Property

    Public Property victim()
        Get
            Return attackVictim
        End Get
        Set(value)
            attackVictim = value
        End Set
    End Property

    Public Property damage()
        Get
            Return attackDamage
        End Get
        Set(value)
            attackDamage = value
        End Set
    End Property

    Public Property battle()
        Get
            Return attackBattle
        End Get
        Set(value)
            attackBattle = value
        End Set
    End Property
End Class
