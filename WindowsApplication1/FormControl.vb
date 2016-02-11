Module FormControl
    Public currentState As New PlayerState

    Public Sub OpenMainMenu()
        currentMainMenu = New MainMenu
        currentMainMenu.Show()
        currentCombatWindow.Close()
        currentCombatWindow = New CombatWindow
        currentDeletePlayersWindow.Close()
        currentDeletePlayersWindow = New DeletePlayersWindow
        currentInnWindow.Close()
        currentInnWindow = New InnWindow
        currentMarketWindow.Close()
        currentMarketWindow = New MarketWindow
        currentNecromancerWindow.Close()
        currentNecromancerWindow = New NecromancerWindow
        currentPlayerWindow.Close()
        currentPlayerWindow = New PlayerWindow
        currentRoadWindow.Close()
        currentRoadWindow = New RoadWindow
        currentTavernWindow.Close()
        currentTavernWindow = New TavernWindow
        currentTownWindow.Close()
        currentTownWindow = New TownWindow
        currentCreatureWindow.Close()
        currentCreatureWindow = New CreatureWindow
    End Sub

End Module