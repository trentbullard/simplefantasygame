Public Class player
    Private playerid As Integer
    Private playerName As String
    Private playerLevel As Integer
    Private playerExperience As Integer
    Private playerGold As Integer

    Public Sub New()
        playerid = -1
        playerName = "name"
        playerLevel = 1
        playerExperience = 0
        playerGold = 0
    End Sub

    Public Sub New(id, name, level, exp, gold)
        playerid = id
        playerName = name
        playerLevel = level
        playerExperience = exp
        playerGold = gold
    End Sub

    Public Property id()
        Get
            Return playerid
        End Get
        Set(value)
            playerid = value
        End Set
    End Property

    Public Property name()
        Get
            Return playerName
        End Get
        Set(value)
            playerName = value
        End Set
    End Property

    Public Property level()
        Get
            Return playerLevel
        End Get
        Set(value)
            playerLevel = value
        End Set
    End Property

    Public Property exp()
        Get
            Return playerExperience
        End Get
        Set(value)
            playerExperience = value
        End Set
    End Property

    Public Property gold()
        Get
            Return playerGold
        End Get
        Set(value)
            playerGold = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "(" & playerLevel & ") " & playerName
    End Function
End Class
