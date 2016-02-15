Public Class PlayerState
    Private stateid As Integer
    Private statePlayer As Player
    Private stateDateSaved As DateTime
    Private stateParty As Party = Nothing
    Private stateTier As Tier = Nothing
    Private stateQuest As Quest = Nothing
    Private stateGameDate As DateTime
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

    Public Sub New()
        stateid = -1
        statePlayer = currentPlayer
        stateDateSaved = DateTime.Now
        stateGameDate = "01/01/1000"
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
    End Sub

    Public Sub New(id As Integer)
        stateid = id
        statePlayer = currentPlayer
        stateDateSaved = DateTime.Now
        stateGameDate = "01/01/1000"
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
    End Sub

    Public Sub New(player As Player)
        stateid = -1
        statePlayer = player
        stateDateSaved = DateTime.Now
        stateGameDate = "01/01/1000"
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
    End Sub

    Public Sub New(row As GameDatabaseDataSet.PlayerStatesRow)
        stateid = row("id")
        statePlayer = currentPlayer
        stateDateSaved = row("dateSaved")
        stateParty = New Party(CInt(row("currentPartyid")))
        stateTier = New Tier(CInt(row("currentTierid")))
        stateQuest = New Quest(CInt(row("currentQuestid")))
        stateGameDate = row("gameDate")
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

    Public ReadOnly Property party() As Party
        Get
            Return stateParty
        End Get
    End Property

    Public ReadOnly Property tier() As Tier
        Get
            Return stateTier
        End Get
    End Property

    Public ReadOnly Property quest() As Quest
        Get
            Return stateQuest
        End Get
    End Property

    Public ReadOnly Property dateInGame() As String
        Get
            Return stateGameDate
        End Get
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
End Class