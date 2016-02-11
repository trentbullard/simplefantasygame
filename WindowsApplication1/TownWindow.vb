Public Class TownWindow
    Private Sub TownWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerCreaturesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerCreatures, currentPlayer.id)
        datelbl.Text = currentPlayer.currentDate.ToString

        If currentPlayer.exp > 1 Then
            innlbl.Hide()
            tavernlbl.Hide()
            marketlbl.Hide()
            necromancerlbl.Hide()
            roadlbl.Hide()
        ElseIf Not PlayerCreaturesTableAdapter.GetDataByPlayerid(currentPlayer.id).Any Then
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
        currentInnWindow = New InnWindow
        currentInnWindow.Show()
    End Sub

    Private Sub tavernbtn_Click(sender As Object, e As EventArgs) Handles tavernbtn.Click
        currentTavernWindow = New TavernWindow
        currentTavernWindow.Show()
    End Sub

    Private Sub marketbtn_Click(sender As Object, e As EventArgs) Handles marketbtn.Click
        currentMarketWindow = New MarketWindow
        currentMarketWindow.Show()
    End Sub

    Private Sub necromancerbtn_Click(sender As Object, e As EventArgs) Handles necromancerbtn.Click
        currentNecromancerWindow = New NecromancerWindow
        currentNecromancerWindow.Show()
    End Sub

    Private Sub roadbtn_Click(sender As Object, e As EventArgs) Handles roadbtn.Click
        currentRoadWindow = New RoadWindow
        currentRoadWindow.Show()
        Me.Close()
    End Sub

    Private Sub playerbtn_Click(sender As Object, e As EventArgs) Handles playerbtn.Click
        currentPlayerWindow = New PlayerWindow
        currentPlayerWindow.Show()
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
        ElseIf Not PlayerCreaturesTableAdapter.GetDataByPlayerid(currentPlayer.id).Any Then
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
        currentPlayer.currentDate.AddDays(7)
        datelbl.Text = currentPlayer.currentDate.ToString
    End Sub
End Class