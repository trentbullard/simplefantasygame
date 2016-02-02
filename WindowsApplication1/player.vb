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
        playerExperience = 1
        playerGold = 0
    End Sub

    Public Sub New(id, name, level, exp, gold)
        playerid = id
        playerName = name
        playerLevel = level
        playerExperience = exp
        playerGold = gold
    End Sub

    Public Sub New(row As GameDatabaseDataSet.PlayersRow)
        playerid = row("id")
        playerName = row("name")
        playerLevel = row("level")
        playerExperience = row("experience")
        playerGold = row("gold")
    End Sub

    Public ReadOnly Property id()
        Get
            Return playerid
        End Get
    End Property

    Public Property name()
        Get
            Return playerName
        End Get
        Set(value)
            playerName = value
        End Set
    End Property

    Public ReadOnly Property level()
        Get
            Return playerLevel
        End Get
    End Property

    Public ReadOnly Property exp()
        Get
            Return playerExperience
        End Get
    End Property

    Public ReadOnly Property gold()
        Get
            Return playerGold
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return "(" & playerLevel & ") " & playerName
    End Function

    Public Sub GainExp(amount)
        playerExperience += amount
        If playerExperience >= (playerLevel + 1) ^ 5 Then
            playerLevel += 1
            MsgBox("DING! gratz, you leveled up!")
        End If
    End Sub

    Public Sub GainGold(amount)
        playerGold += amount
    End Sub
End Class
