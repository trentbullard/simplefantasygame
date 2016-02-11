Public Class PlayerState
    Private stateid As Integer
    Private statePlayer As player
    Private stateDateSaved As DateTime
    Private stateParty As party
    Private stateTier As tier
    Private stateQuest As quest
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
        statePlayer = currentPlayer.id
        stateDateSaved = DateTime.Now
        stateParty = -1
        stateTier = -1
        stateQuest = -1
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
        statePlayer = row("playerid")
        stateDateSaved = row("dateSaved")
        stateParty = row("currentPartyid")
        stateTier = row("currentTierid")
        stateQuest = row("currentQuestid")
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

    Public ReadOnly Property player() As player
        Get
            Return statePlayer
        End Get
    End Property

    Public ReadOnly Property savedate() As String
        Get
            Return stateDateSaved.ToString
        End Get
    End Property

    Public ReadOnly Property party() As party
        Get
            Return stateParty
        End Get
    End Property

    Public ReadOnly Property tier() As tier
        Get
            Return stateTier
        End Get
    End Property

    Public ReadOnly Property quest() As quest
        Get
            Return stateQuest
        End Get
    End Property

    Public ReadOnly Property gamedate() As String
        Get
            Return stateGameDate
        End Get
    End Property

    Public ReadOnly Property combatwindow() As CombatWindow
        Get
            Return stateCombatWindow
        End Get
    End Property

    Public ReadOnly Property deletewindow() As DeletePlayersWindow
        Get
            Return stateDeletePlayersWindow
        End Get
    End Property

    Public ReadOnly Property innwindow() As InnWindow
        Get
            Return stateInnWindow
        End Get
    End Property

    Public ReadOnly Property mainmenu() As MainMenu
        Get
            Return stateMainMenu
        End Get
    End Property

    Public ReadOnly Property marketwindow() As MarketWindow
        Get
            Return stateMarketWindow
        End Get
    End Property

    Public ReadOnly Property necrowindow() As NecromancerWindow
        Get
            Return stateNecromancerWindow
        End Get
    End Property

    Public ReadOnly Property playerwindow() As PlayerWindow
        Get
            Return statePlayerWindow
        End Get
    End Property

    Public ReadOnly Property roadwindow() As RoadWindow
        Get
            Return stateRoadWindow
        End Get
    End Property

    Public ReadOnly Property tavernwindow() As TavernWindow
        Get
            Return stateTavernWindow
        End Get
    End Property

    Public ReadOnly Property townwindow() As TownWindow
        Get
            Return stateTownWindow
        End Get
    End Property

    Public ReadOnly Property creaturewindow() As CreatureWindow
        Get
            Return stateCreatureWindow
        End Get
    End Property
End Class