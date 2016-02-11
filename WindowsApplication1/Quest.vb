Imports WindowsApplication1

Public Class Quest
    Private questid As Integer
    Private questName As String
    Private questTier As Tier
    Private questMinLevel As Integer
    Private questMaxLevel As Integer
    Private questRewardItem As Item
    Private questRewardExp As Integer
    Private questRewardGold As Integer
    Private questIsComplete As Boolean

    Public Sub New()
        questid = -1
        questName = "quest"
        questTier = currentState.tier
        questMinLevel = 1
        questMaxLevel = 50
        questRewardItem = New Item
        questRewardExp = 1
        questRewardGold = 1
        questIsComplete = False
    End Sub

    Public Sub New(row As GameDatabaseDataSet.StaticQuestsRow, tier As Tier, item As Item)
        questid = row("id")
        questName = row("name")
        questTier = tier
        questMinLevel = row("minLevel")
        questMaxLevel = row("maxLevel")
        questRewardItem = item
        questRewardExp = row("rewardExperience")
        questRewardGold = row("rewardGold")
        questIsComplete = row("isComplete")
    End Sub

    Public Property id() As Integer
        Get
            Return questid
        End Get
        Set(value As Integer)
            questid = value
        End Set
    End Property

    Public Property name As String
        Get
            Return questName
        End Get
        Set(value As String)
            questName = value
        End Set
    End Property

    Public Property tier As Tier
        Get
            Return questTier
        End Get
        Set(value As Tier)
            questTier = value
        End Set
    End Property

    Public Property minLevel As Integer
        Get
            Return questMinLevel
        End Get
        Set(value As Integer)
            questMinLevel = value
        End Set
    End Property

    Public Property maxlevel1 As Integer
        Get
            Return questMaxLevel
        End Get
        Set(value As Integer)
            questMaxLevel = value
        End Set
    End Property

    Public Property rewardItem As Item
        Get
            Return questRewardItem
        End Get
        Set(value As Item)
            questRewardItem = value
        End Set
    End Property

    Public Property rewardExp As Integer
        Get
            Return questRewardExp
        End Get
        Set(value As Integer)
            questRewardExp = value
        End Set
    End Property

    Public Property rewardGold As Integer
        Get
            Return questRewardGold
        End Get
        Set(value As Integer)
            questRewardGold = value
        End Set
    End Property

    Public Property isComplete As Boolean
        Get
            Return questIsComplete
        End Get
        Set(value As Boolean)
            questIsComplete = value
        End Set
    End Property
End Class
