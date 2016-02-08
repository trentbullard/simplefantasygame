Public Class TownWindow
    Private Sub TownWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ArmorAugmentsTableAdapter.FillByArmorid(GameDatabaseDataSet.ArmorAugments, currentPlayer.id)
        'BattlesTableAdapter.FillByPlayerid(GameDatabaseDataSet.Battles, currentPlayer.id)
        'PartiesTableAdapter.FillByPlayerid(GameDatabaseDataSet.Parties, currentPlayer.id)
        'PlayerArmorTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerArmor, currentPlayer.id)
        'PlayerConsumablesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerConsumables, currentPlayer.id)
        PlayerCreaturesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerCreatures, currentPlayer.id)
        'PlayerSkillsTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerSkills, currentPlayer.id)
        'PlayerWeaponsTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerWeapons, currentPlayer.id)
        'PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)
        'StaticArmorTableAdapter.Fill(GameDatabaseDataSet.StaticArmor)
        'StaticAugmentsTableAdapter.Fill(GameDatabaseDataSet.StaticAugments)
        'StaticConsumablesTableAdapter.Fill(GameDatabaseDataSet.StaticConsumables)
        'StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        'StaticMobsTableAdapter.Fill(GameDatabaseDataSet.StaticMobs)
        'StaticSkillsTableAdapter.Fill(GameDatabaseDataSet.StaticSkills)
        'StaticWeaponsTableAdapter.Fill(GameDatabaseDataSet.StaticWeapons)
        'TurnsTableAdapter.FillByBattleid(GameDatabaseDataSet.Turns, currentPlayer.id)
        'WeaponAugmentsTableAdapter.FillByWeaponid(GameDatabaseDataSet.WeaponAugments, currentPlayer.id)

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
            marketlbl.Hide()
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
End Class