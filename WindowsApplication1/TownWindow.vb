Public Class TownWindow
    Private Sub TownWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerStatesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerStates, currentPlayer.id)
        PlayerCreaturesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.PlayerCreatures, currentState.id)
        datelbl.Text = currentState.dateInGame.ToString

        If currentPlayer.exp > 1 Then
            innlbl.Hide()
            tavernlbl.Hide()
            marketlbl.Hide()
            necromancerlbl.Hide()
            roadlbl.Hide()
        ElseIf Not PlayerCreaturesTableAdapter.GetData.Any Then
            innbtn.Enabled = False
            marketbtn.Enabled = False
            necromancerbtn.Enabled = False
            roadbtn.Enabled = False
            innlbl.Text = "go to the tavern to hire a team first"
            marketlbl.Text = "go to the tavern to hire a team first"
            necromancerlbl.Text = "go to the tavern to hire a team first"
            roadlbl.Text = "go to the tavern to hire a team first"
        Else
            tavernlbl.Hide()
        End If

    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        OpenMainMenu()
    End Sub

    Private Sub innbtn_Click(sender As Object, e As EventArgs) Handles innbtn.Click
        currentState.innwindow = New InnWindow
        currentState.innwindow.Show()
    End Sub

    Private Sub tavernbtn_Click(sender As Object, e As EventArgs) Handles tavernbtn.Click
        currentState.tavernwindow = New TavernWindow
        currentState.tavernwindow.Show()
    End Sub

    Private Sub marketbtn_Click(sender As Object, e As EventArgs) Handles marketbtn.Click
        currentState.marketwindow = New MarketWindow
        currentState.marketwindow.Show()
    End Sub

    Private Sub necromancerbtn_Click(sender As Object, e As EventArgs) Handles necromancerbtn.Click
        currentState.necrowindow = New NecromancerWindow
        currentState.necrowindow.Show()
    End Sub

    Private Sub roadbtn_Click(sender As Object, e As EventArgs) Handles roadbtn.Click
        currentState.roadwindow = New RoadWindow
        currentState.roadwindow.Show()
    End Sub

    Private Sub playerbtn_Click(sender As Object, e As EventArgs) Handles playerbtn.Click
        currentState.playerwindow = New PlayerWindow
        currentState.playerwindow.Show()
    End Sub

    Public Sub RefreshControls()
        If currentPlayer.exp > 1 Then
            innlbl.Hide()
            innbtn.Enabled = True
            tavernlbl.Hide()
            tavernbtn.Enabled = True
            marketlbl.Hide()
            marketbtn.Enabled = True
            necromancerlbl.Hide()
            necromancerbtn.Enabled = True
            roadlbl.Hide()
            roadbtn.Enabled = True
        ElseIf Not PlayerCreaturesTableAdapter.GetData.Any Then
            innbtn.Enabled = False
            marketbtn.Enabled = False
            necromancerbtn.Enabled = False
            roadbtn.Enabled = False
            innlbl.Text = "go to the tavern to hire a team first"
            marketlbl.Text = "go to the tavern to hire a team first"
            necromancerlbl.Text = "go to the tavern to hire a team first"
            roadlbl.Text = "go to the tavern to hire a team first"
        Else
            tavernlbl.Hide()
            innbtn.Enabled = True
            tavernbtn.Enabled = True
            marketbtn.Enabled = True
            necromancerbtn.Enabled = True
            roadbtn.Enabled = True
            innlbl.Text = "click here to rest your team!"
            marketlbl.Text = "click here to buy items!"
            necromancerlbl.Text = "click here to resurrect dead team members!"
            roadlbl.Text = "click here to travel!"
        End If
    End Sub

    Private Sub add1Weekbtn_Click(sender As Object, e As EventArgs) Handles add1Weekbtn.Click
        currentState.ChangeDate(TimeSpan.FromDays(7))
        datelbl.Text = currentState.dateInGame.ToString
        currentController.SaveState()
    End Sub
End Class