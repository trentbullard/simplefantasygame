Public Class Tier
    Private tierid As Integer
    Private tierCamp As Camp
    Private tierBoss As Creature

    Public Sub New()
        tierid = -1
        tierCamp = New Camp
        tierBoss = New Creature
    End Sub

    Public Sub New(id As Integer)
        tierid = id
        tierCamp = New Camp
        tierBoss = New Creature
    End Sub

    Public ReadOnly Property id As Integer
        Get
            Return tierid
        End Get
    End Property

    Public Property camp As Camp
        Get
            Return tierCamp
        End Get
        Set(value As Camp)
            tierCamp = value
        End Set
    End Property

    Public Property boss As Creature
        Get
            Return tierBoss
        End Get
        Set(value As Creature)
            tierBoss = value
        End Set
    End Property
End Class
