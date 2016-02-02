Public Class battle
    Private battleId As Integer
    Private battlePlayer As player

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

    Public Property player() As player
        Get
            Return battlePlayer
        End Get
        Set(value As player)
            battlePlayer = value
        End Set
    End Property
End Class
