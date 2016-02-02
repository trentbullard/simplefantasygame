Public Class attack
    Private attackid As Integer
    Private attackAggressor As creature
    Private attackVictim As creature
    Private attackDamage As Integer
    Private attackBattle As battle

    Public Sub New()
        attackid = -1
        attackAggressor = New creature
        attackVictim = New creature
        attackDamage = 0
        attackBattle = New battle
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
