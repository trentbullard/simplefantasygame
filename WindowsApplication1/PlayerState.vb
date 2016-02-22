Public Class PlayerState
    Private stateid As Integer
    Private statePlayer As Player
    Private stateDateSaved As DateTime
    Private stateParty As Party = Nothing
    Private stateTier As Tier = Nothing
    Private stateQuest As Quest = Nothing
    Private stateGameDate As DateTime
    Private stateIsAmbushed As Boolean
    Private statePlayerGold As Integer
    Private statePlayerLevel As Integer
    Private statePlayerExperience As Integer
    Private stateCombatWindow As CombatWindow
    Private stateDeletePlayersWindow As DeletePlayersWindow
    Private stateInnWindow As InnWindow
    Private stateMainMenu As MainMenu
    Private stateMarketWindow As MarketWindow
    Private stateNecromancerWindow As NecromancerWindow
    Private statePlayerWindow As PlayerWindow
    Private stateRoadWindow As RoadWindow
    Private stateTavernWindow As TavernWindow
    Private stateTownWindow As TownWindow
    Private stateCreatureWindow As CreatureWindow
    Private stateBlacksmithWindow As BlacksmithWindow

    Public Sub New()
        stateid = -1
        statePlayer = currentPlayer
        stateDateSaved = DateTime.Now
        stateGameDate = "01/01/1000"
        stateIsAmbushed = False
        statePlayerGold = 4
        statePlayerLevel = 1
        statePlayerExperience = 1
        stateCombatWindow = New CombatWindow
        stateDeletePlayersWindow = New DeletePlayersWindow
        stateInnWindow = New InnWindow
        stateMainMenu = New MainMenu
        stateMarketWindow = New MarketWindow
        stateNecromancerWindow = New NecromancerWindow
        statePlayerWindow = New PlayerWindow
        stateRoadWindow = New RoadWindow
        stateTavernWindow = New TavernWindow
        stateTownWindow = New TownWindow
        stateCreatureWindow = New CreatureWindow
        stateBlacksmithWindow = New BlacksmithWindow
    End Sub

    Public Sub New(id As Integer)
        stateid = id
        statePlayer = currentPlayer
        stateDateSaved = DateTime.Now
        stateGameDate = "01/01/1000"
        stateIsAmbushed = False
        statePlayerGold = 4
        statePlayerLevel = 1
        statePlayerExperience = 1
        stateCombatWindow = New CombatWindow
        stateDeletePlayersWindow = New DeletePlayersWindow
        stateInnWindow = New InnWindow
        stateMainMenu = New MainMenu
        stateMarketWindow = New MarketWindow
        stateNecromancerWindow = New NecromancerWindow
        statePlayerWindow = New PlayerWindow
        stateRoadWindow = New RoadWindow
        stateTavernWindow = New TavernWindow
        stateTownWindow = New TownWindow
        stateCreatureWindow = New CreatureWindow
        stateBlacksmithWindow = New BlacksmithWindow
    End Sub

    Public Sub New(player As Player)
        stateid = -1
        statePlayer = player
        stateDateSaved = DateTime.Now
        stateGameDate = "01/01/1000"
        stateIsAmbushed = False
        statePlayerGold = player.gold
        statePlayerLevel = player.level
        statePlayerExperience = player.exp
        stateCombatWindow = New CombatWindow
        stateDeletePlayersWindow = New DeletePlayersWindow
        stateInnWindow = New InnWindow
        stateMainMenu = New MainMenu
        stateMarketWindow = New MarketWindow
        stateNecromancerWindow = New NecromancerWindow
        statePlayerWindow = New PlayerWindow
        stateRoadWindow = New RoadWindow
        stateTavernWindow = New TavernWindow
        stateTownWindow = New TownWindow
        stateCreatureWindow = New CreatureWindow
        stateBlacksmithWindow = New BlacksmithWindow
    End Sub

    Public Sub New(row As GameDatabaseDataSet.PlayerStatesRow)
        stateid = row.id
        statePlayer = currentPlayer
        stateDateSaved = row("dateSaved")
        stateParty = If(row("currentPartyid") IsNot DBNull.Value, New Party(CInt(row("currentPartyid"))), Nothing)
        stateTier = If(row("currentTierid") IsNot DBNull.Value, New Tier(CInt(row("currentTierid"))), Nothing)
        stateQuest = If(row("currentQuestid") IsNot DBNull.Value, New Quest(CInt(row("currentQuestid"))), Nothing)
        stateGameDate = row("gameDate")
        stateIsAmbushed = row("isAmbushed")
        statePlayerGold = row.playerGold
        statePlayerLevel = row.playerLevel
        statePlayerExperience = row.playerExperience
        stateCombatWindow = New CombatWindow
        stateDeletePlayersWindow = New DeletePlayersWindow
        stateInnWindow = New InnWindow
        stateMainMenu = New MainMenu
        stateMarketWindow = New MarketWindow
        stateNecromancerWindow = New NecromancerWindow
        statePlayerWindow = New PlayerWindow
        stateRoadWindow = New RoadWindow
        stateTavernWindow = New TavernWindow
        stateTownWindow = New TownWindow
        stateCreatureWindow = New CreatureWindow
        stateBlacksmithWindow = New BlacksmithWindow
    End Sub

    Public ReadOnly Property id() As Integer
        Get
            Return stateid
        End Get
    End Property

    Public ReadOnly Property player() As Player
        Get
            Return statePlayer
        End Get
    End Property

    Public ReadOnly Property dateSaved() As String
        Get
            Return stateDateSaved.ToString
        End Get
    End Property

    Public Property party() As Party
        Get
            Return stateParty
        End Get
        Set(value As Party)
            stateParty = value
        End Set
    End Property

    Public Property tier() As Tier
        Get
            Return stateTier
        End Get
        Set(value As Tier)
            stateTier = value
        End Set
    End Property

    Public ReadOnly Property quest() As Quest
        Get
            Return stateQuest
        End Get
    End Property

    Public Property dateInGame() As String
        Get
            Return stateGameDate
        End Get
        Set(value As String)
            stateGameDate = value
        End Set
    End Property

    Public Property isAmbushed As Boolean
        Get
            Return stateIsAmbushed
        End Get
        Set(value As Boolean)
            stateIsAmbushed = value
        End Set
    End Property

    Public Property gold() As Integer
        Get
            Return statePlayerGold
        End Get
        Set(value As Integer)
            statePlayerGold = value
        End Set
    End Property

    Public Property level() As Integer
        Get
            Return statePlayerLevel
        End Get
        Set(value As Integer)
            statePlayerLevel = value
        End Set
    End Property

    Public Property exp() As Integer
        Get
            Return statePlayerExperience
        End Get
        Set(value As Integer)
            statePlayerExperience = value
        End Set
    End Property

    Public Property combatwindow() As CombatWindow
        Get
            Return stateCombatWindow
        End Get
        Set(value As CombatWindow)
            stateCombatWindow = value
        End Set
    End Property

    Public Property deletewindow() As DeletePlayersWindow
        Get
            Return stateDeletePlayersWindow
        End Get
        Set(value As DeletePlayersWindow)
            stateDeletePlayersWindow = value
        End Set
    End Property

    Public Property innwindow() As InnWindow
        Get
            Return stateInnWindow
        End Get
        Set(value As InnWindow)
            stateInnWindow = value
        End Set
    End Property

    Public Property mainmenu() As MainMenu
        Get
            Return stateMainMenu
        End Get
        Set(value As MainMenu)
            stateMainMenu = value
        End Set
    End Property

    Public Property marketwindow() As MarketWindow
        Get
            Return stateMarketWindow
        End Get
        Set(value As MarketWindow)
            stateMarketWindow = value
        End Set
    End Property

    Public Property necrowindow() As NecromancerWindow
        Get
            Return stateNecromancerWindow
        End Get
        Set(value As NecromancerWindow)
            stateNecromancerWindow = value
        End Set
    End Property

    Public Property playerwindow() As PlayerWindow
        Get
            Return statePlayerWindow
        End Get
        Set(value As PlayerWindow)
            statePlayerWindow = value
        End Set
    End Property

    Public Property roadwindow() As RoadWindow
        Get
            Return stateRoadWindow
        End Get
        Set(value As RoadWindow)
            stateRoadWindow = value
        End Set
    End Property

    Public Property tavernwindow() As TavernWindow
        Get
            Return stateTavernWindow
        End Get
        Set(value As TavernWindow)
            stateTavernWindow = value
        End Set
    End Property

    Public Property townwindow() As TownWindow
        Get
            Return stateTownWindow
        End Get
        Set(value As TownWindow)
            stateTownWindow = value
        End Set
    End Property

    Public Property creaturewindow() As CreatureWindow
        Get
            Return stateCreatureWindow
        End Get
        Set(value As CreatureWindow)
            stateCreatureWindow = value
        End Set
    End Property

    Public Property blacksmithwindow As BlacksmithWindow
        Get
            Return stateBlacksmithWindow
        End Get
        Set(value As BlacksmithWindow)
            stateBlacksmithWindow = value
        End Set
    End Property

    Public Sub ChangeDate(amount As TimeSpan)
        If amount < TimeSpan.Zero Then
            stateGameDate = stateGameDate.Subtract(amount)
        Else
            stateGameDate = stateGameDate.Add(amount)
        End If
    End Sub

    Public Sub AcceptQuest(quest As Quest)
        stateQuest = quest
    End Sub

    Public Sub AbandonQuest()
        stateQuest = Nothing
    End Sub

    Public Sub Save(ByRef dataSet As GameDatabaseDataSet,
                    ByRef bindingSource As BindingSource,
                    ByRef tableAdapter As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter)
        Dim newRow As GameDatabaseDataSet.PlayerStatesRow = dataSet.PlayerStates.NewRow()
        newRow.playerid = statePlayer.id
        newRow.dateSaved = Date.Now
        newRow("currentPartyid") = If(stateParty IsNot Nothing, stateParty.id, DBNull.Value)
        newRow("currentTierid") = If(stateTier IsNot Nothing, stateTier.id, DBNull.Value)
        newRow("currentQuestid") = If(stateQuest IsNot Nothing, stateQuest.id, DBNull.Value)
        newRow.gameDate = stateGameDate
        newRow.isAmbushed = stateIsAmbushed
        newRow.playerGold = statePlayerGold
        newRow.playerLevel = statePlayerLevel
        newRow.playerExperience = statePlayerExperience
        dataSet.Tables("PlayerStates").Rows.Add(newRow)
        Try
            bindingSource.EndEdit()
            tableAdapter.Update(dataSet.PlayerStates)
            stateid = tableAdapter.GetData.Last.id
        Catch ex As Exception
            MsgBox("failed to update database record for " & Me.ToString)
        End Try
    End Sub

    Public Sub LoadWindows(oldState As PlayerState)
        stateCombatWindow = oldState.combatwindow
        stateDeletePlayersWindow = oldState.deletewindow
        stateInnWindow = oldState.innwindow
        stateMainMenu = oldState.mainmenu
        stateMarketWindow = oldState.marketwindow
        stateNecromancerWindow = oldState.necrowindow
        statePlayerWindow = oldState.playerwindow
        stateRoadWindow = oldState.roadwindow
        stateTavernWindow = oldState.tavernwindow
        stateTownWindow = oldState.townwindow
        stateCreatureWindow = oldState.creaturewindow
        stateBlacksmithWindow = oldState.blacksmithwindow
    End Sub

End Class