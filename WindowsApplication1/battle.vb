Public Class Battle
    Private battleId As Integer
    Private battlePlayer As Player

    Public Sub New()
        battleId = -1
        battlePlayer = currentPlayer
    End Sub

    Public Sub New(id, player)
        battleId = id
        battlePlayer = player
    End Sub

    Public Property id() As Integer
        Get
            Return battleId
        End Get
        Set(value As Integer)
            battleId = value
        End Set
    End Property

    Public Property player() As Player
        Get
            Return battlePlayer
        End Get
        Set(value As Player)
            battlePlayer = value
        End Set
    End Property
End Class
