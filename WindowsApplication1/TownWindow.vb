Public Class TownWindow
    Private Sub TownWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ArmorAugmentsTableAdapter.FillByArmorid(Me.GameDatabaseDataSet.ArmorAugments, currentPlayer.id)
        Me.BattlesTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.Battles, currentPlayer.id)
        Me.PartiesTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.Parties, currentPlayer.id)
        Me.PlayerArmorTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerArmor, currentPlayer.id)
        Me.PlayerConsumablesTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerConsumables, currentPlayer.id)
        Me.PlayerCreaturesTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreatures, currentPlayer.id)
        Me.PlayerSkillsTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerSkills, currentPlayer.id)
        Me.PlayerWeaponsTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerWeapons, currentPlayer.id)
        Me.PlayersTableAdapter.Fill(Me.GameDatabaseDataSet.Players)
        Me.StaticArmorTableAdapter.Fill(Me.GameDatabaseDataSet.StaticArmor)
        Me.StaticAugmentsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticAugments)
        Me.StaticConsumablesTableAdapter.Fill(Me.GameDatabaseDataSet.StaticConsumables)
        Me.StaticCreaturesTableAdapter.Fill(Me.GameDatabaseDataSet.StaticCreatures)
        Me.StaticMobsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticMobs)
        Me.StaticSkillsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticSkills)
        Me.StaticWeaponsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticWeapons)
        Me.TurnsTableAdapter.FillByBattleid(Me.GameDatabaseDataSet.Turns, currentPlayer.id)
        Me.WeaponAugmentsTableAdapter.FillByWeaponid(Me.GameDatabaseDataSet.WeaponAugments, currentPlayer.id)

        If currentPlayer.exp > 1 Then
            Me.innlbl.Hide()
            Me.tavernlbl.Hide()
            Me.marketlbl.Hide()
            Me.necromancerlbl.Hide()
            Me.roadlbl.Hide()
        End If

    End Sub

    Private Sub UpdateDatabase()
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)
    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        UpdateDatabase()
        currentMainMenu = New MainMenu
        currentMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub innbtn_Click(sender As Object, e As EventArgs) Handles innbtn.Click
        UpdateDatabase()
        currentInnWindow = New InnWindow
        currentInnWindow.Show()
    End Sub

    Private Sub tavernbtn_Click(sender As Object, e As EventArgs) Handles tavernbtn.Click
        UpdateDatabase()
        currentTavernWindow = New TavernWindow
        currentTavernWindow.Show()
    End Sub

    Private Sub marketbtn_Click(sender As Object, e As EventArgs) Handles marketbtn.Click
        UpdateDatabase()
        currentMarketWindow = New MarketWindow
        currentMarketWindow.show()
    End Sub

    Private Sub necromancerbtn_Click(sender As Object, e As EventArgs) Handles necromancerbtn.Click
        UpdateDatabase()
        currentNecromancerWindow = New NecromancerWindow
        currentNecromancerWindow.show()
    End Sub

    Private Sub roadbtn_Click(sender As Object, e As EventArgs) Handles roadbtn.Click
        UpdateDatabase()
        currentRoadWindow = New RoadWindow
        currentRoadWindow.show()
        Me.Close()
    End Sub

    Private Sub playerbtn_Click(sender As Object, e As EventArgs) Handles playerbtn.Click
        UpdateDatabase()
        currentPlayerWindow = New PlayerWindow
        currentPlayerWindow.Show()
    End Sub
End Class