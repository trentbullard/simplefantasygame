Public Class Quest
    Private questid As Integer
    Private questName As String
    Private questTier As Tier = Nothing
    Private questMinLevel As Integer
    Private questMaxLevel As Integer
    Private questRewardItem As Item = Nothing
    Private questRewardExp As Integer
    Private questRewardGold As Integer
    Private questIsComplete As Boolean
    Private questDescription As String

    Public Sub New()
        questid = -1
        questName = "quest"
        questTier = New Tier
        questMinLevel = 1
        questMaxLevel = 50
        questRewardItem = New Item
        questRewardExp = 1
        questRewardGold = 1
        questIsComplete = False
        questDescription = "quest description"
    End Sub

    Public Sub New(id As Integer)
        questid = id
        questName = "quest"
        questTier = New Tier
        questMinLevel = 1
        questMaxLevel = 50
        questRewardItem = New Item
        questRewardExp = 1
        questRewardGold = 1
        questIsComplete = False
        questDescription = "quest description"
    End Sub

    Public Sub New(name As String)
        questid = -1
        questName = name
        questTier = New Tier
        questMinLevel = 1
        questMaxLevel = 50
        questRewardItem = New Item
        questRewardExp = 1
        questRewardGold = 1
        questIsComplete = False
        questDescription = "quest description"
    End Sub

    Public Sub New(row As GameDatabaseDataSet.StaticQuestsRow)
        questid = row("id")
        questName = row("name")
        questTier = New Tier(row("tierid"))
        questMinLevel = row("minLevel")
        questMaxLevel = row("maxLevel")
        If Not IsDBNull(row("rewardWeaponid")) Then
            questRewardItem = New Weapon(CInt(row("rewardWeaponid")))
        ElseIf Not IsDBNull(row("rewardArmorid")) Then
            questRewardItem = New Armor(CInt(row("rewardArmorid")))
        ElseIf Not IsDBNull(row("rewardAugmentid")) Then
            questRewardItem = New Augment(CInt(row("rewardAugmentid")))
        ElseIf Not IsDBNull(row("rewardConsumableid")) Then
            questRewardItem = New Consumable(CInt(row("rewardConsumableid")))
        Else
            questRewardItem = Nothing
        End If
        questRewardExp = row("rewardExperience")
        questRewardGold = row("rewardGold")
        questIsComplete = row("isComplete")
        questDescription = "quest description"
    End Sub

    Public ReadOnly Property id() As Integer
        Get
            Return questid
        End Get
    End Property

    Public Property name As String
        Get
            Return questName
        End Get
        Set(value As String)
            questName = value
        End Set
    End Property

    Public ReadOnly Property tier As Tier
        Get
            Return questTier
        End Get
    End Property

    Public ReadOnly Property minLevel As Integer
        Get
            Return questMinLevel
        End Get
    End Property

    Public ReadOnly Property maxLevel As Integer
        Get
            Return questMaxLevel
        End Get
    End Property

    Public Property rewardItem As Item
        Get
            Return questRewardItem
        End Get
        Set(value As Item)
            questRewardItem = value
        End Set
    End Property

    Public ReadOnly Property rewardExp As Integer
        Get
            Return questRewardExp
        End Get
    End Property

    Public ReadOnly Property rewardGold As Integer
        Get
            Return questRewardGold
        End Get
    End Property

    Public ReadOnly Property isComplete As Boolean
        Get
            Return questIsComplete
        End Get
    End Property

    Public ReadOnly Property description() As String
        Get
            Return questDescription
        End Get
    End Property

    Public Sub complete()
        questIsComplete = True
    End Sub

    Public Overrides Function ToString() As String
        Return questName & vbCrLf &
            "level range: " & questMinLevel & " - " & questMaxLevel & vbCrLf &
            "rewards: " & questRewardExp & " experience, " & questRewardGold & " gold, and an " & questRewardItem.ToString & vbCrLf &
            questDescription
    End Function

    Public Sub Save(ds As GameDatabaseDataSet,
                    bs As BindingSource,
                    ta As GameDatabaseDataSetTableAdapters.StaticQuestsTableAdapter)
        Dim newRow As DataRow = ds.Tables("StaticQuests").NewRow()
        Dim item As Integer = Roll(4)
        newRow("name") = questName
        newRow("tierid") = questTier.id
        newRow("minLevel") = questMinLevel
        newRow("maxLevel") = questMaxLevel
        Select Case item
            Case 1
                newRow("rewardWeaponid") = Roll(20)
            Case 2
                newRow("rewardArmorid") = Roll(20)
            Case 3
                newRow("rewardAugmentid") = Roll(20)
            Case 4
                newRow("rewardConsumableid") = Roll(20)
        End Select
        newRow("rewardExperience") = questRewardExp
        newRow("rewardGold") = questRewardGold
        newRow("isComplete") = questIsComplete
        ds.Tables("StaticQuests").Rows.Add(newRow)
        Try
            bs.EndEdit()
            ta.Update(ds.StaticQuests)
        Catch ex As Exception
            MsgBox("failed to add static quest to database.")
        End Try
    End Sub
End Class
