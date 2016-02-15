﻿Public Class PlayerState
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
        stateParty = If(row("currentPartyid") IsNot DBNull.Value, New Party(CInt(row("currentPartyid"))), Nothing)
        stateTier = If(row("currentTierid") IsNot DBNull.Value, New Tier(CInt(row("currentTierid"))), Nothing)
        stateQuest = If(row("currentQuestid") IsNot DBNull.Value, New Quest(CInt(row("currentQuestid"))), Nothing)
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

    Public Sub Save(ByRef dataSet As GameDatabaseDataSet,
                    ByRef bindingSource As BindingSource,
                    ByRef tableAdapter As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter)
        If Not tableAdapter.GetLastPlayerStateByPlayerid(statePlayer.id).Any Then
            Dim newRow As DataRow = dataSet.Tables("PlayerStates").NewRow()
            newRow("playerid") = statePlayer.id
            newRow("dateSaved") = Date.Now
            newRow("currentPartyid") = If(stateParty IsNot Nothing, stateParty.id, DBNull.Value)
            newRow("currentTierid") = If(stateTier IsNot Nothing, stateTier.id, DBNull.Value)
            newRow("currentQuestid") = If(stateQuest IsNot Nothing, stateQuest.id, DBNull.Value)
            newRow("gameDate") = stateGameDate
            dataSet.Tables("PlayerStates").Rows.Add(newRow)
        Else
            dataSet.Tables("PlayerStates").Rows.Find(stateid)("playerid") = statePlayer.id
            dataSet.Tables("PlayerStates").Rows.Find(stateid)("dateSaved") = Date.Now
            dataSet.Tables("PlayerStates").Rows.Find(stateid)("currentPartyid") = If(stateParty IsNot Nothing, stateParty.id, DBNull.Value)
            dataSet.Tables("PlayerStates").Rows.Find(stateid)("currentTierid") = If(stateTier IsNot Nothing, stateTier.id, DBNull.Value)
            dataSet.Tables("PlayerStates").Rows.Find(stateid)("currentQuestid") = If(stateQuest IsNot Nothing, stateQuest.id, DBNull.Value)
            dataSet.Tables("PlayerStates").Rows.Find(stateid)("gameDate") = stateGameDate
        End If
        Try
            bindingSource.EndEdit()
            tableAdapter.Update(dataSet.PlayerStates)
            stateid = tableAdapter.GetLastPlayerStateByPlayerid(statePlayer.id)(0)("id")
        Catch ex As Exception
            MsgBox("failed to update database record for " & Me.ToString)
        End Try
    End Sub
End Class