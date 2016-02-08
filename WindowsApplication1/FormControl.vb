Module FormControl
    Public currentCombatWindow As New CombatWindow
    Public currentDeletePlayersWindow As New DeletePlayersWindow
    Public currentInnWindow As New InnWindow
    Public currentMainMenu As New MainMenu
    Public currentMarketWindow As New MarketWindow
    Public currentNecromancerWindow As New NecromancerWindow
    Public currentPlayerWindow As New PlayerWindow
    Public currentRoadWindow As New RoadWindow
    Public currentTavernWindow As New TavernWindow
    Public currentTownWindow As New TownWindow

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
    End Sub
End Module