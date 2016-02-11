Module FormControl
    Public currentState As New PlayerState

    Public Sub OpenMainMenu()
        currentState = New PlayerState
        currentState.mainmenu.Show()
        currentState.combatwindow.Close()
        currentState.innwindow.Close()
        currentState.marketwindow.Close()
        currentState.necrowindow.Close()
        currentState.playerwindow.Close()
        currentState.roadwindow.Close()
        currentState.tavernwindow.Close()
        currentState.townwindow.Close()
        currentState.creaturewindow.Close()
        currentState.deletewindow.Close()
    End Sub
End Module