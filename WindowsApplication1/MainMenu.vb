Imports System
Imports System.IO
Imports System.Text

Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerPartiesTableAdapter.Fill(GameDatabaseDataSet.PlayerParties)
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)
        PlayerStatesTableAdapter.Fill(GameDatabaseDataSet.PlayerStates)
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        StaticQuestsTableAdapter.Fill(GameDatabaseDataSet.StaticQuests)
        StaticCampsTableAdapter.Fill(GameDatabaseDataSet.StaticCamps)
        StaticCampTiersTableAdapter.Fill(GameDatabaseDataSet.StaticCampTiers)
        StaticWeaponsTableAdapter.Fill(GameDatabaseDataSet.StaticWeapons)
        StaticArmorTableAdapter.Fill(GameDatabaseDataSet.StaticArmor)
        initDataSetController()

        If Not StaticCreaturesTableAdapter.GetData.Any Then
            Dim creature As Creature
            For ctr = 1 To 20
                creature = New Creature("creature " & ctr)
                creature.Save(GameDatabaseDataSet, StaticCreaturesBindingSource, StaticCreaturesTableAdapter)
            Next
        End If

        If Not StaticQuestsTableAdapter.GetData.Any Then
            Dim quest As Quest
            For ctr = 1 To 20
                quest = New Quest("quest " & ctr)
                quest.Save(GameDatabaseDataSet, StaticCreaturesBindingSource, StaticQuestsTableAdapter)
            Next
        End If

        If Not StaticCampsTableAdapter.GetData.Any Then
            Dim camp As Camp
            For ctr = 1 To 5
                camp = New Camp()
                camp.save(GameDatabaseDataSet, StaticCampsBindingSource, StaticCampsTableAdapter)
                If StaticCampTiersTableAdapter.GetData.Any Then
                    Dim tier As Tier
                    For ctr2 = 1 To 5
                        tier = New Tier(camp)
                        tier.save(GameDatabaseDataSet, StaticCampTiersBindingSource, StaticCampTiersTableAdapter)
                    Next
                End If
            Next
        End If

        For ctr = 1 To 100
            If Not StaticWeaponsTableAdapter.GetData.Count >= 100 Then
                Dim weapon As Weapon
                weapon = New Weapon()
                weapon.Save(GameDatabaseDataSet, StaticWeaponsBindingSource, StaticWeaponsTableAdapter)
            End If
            If Not StaticArmorTableAdapter.GetData.Count >= 100 Then
                Dim armor As Armor
                armor = New Armor()
                armor.Save(GameDatabaseDataSet, StaticArmorBindingSource, StaticArmorTableAdapter)
            End If
            'If Not StaticAugmentsTableAdapter.GetData.Any Then
            '    Dim augment As Augment
            '    augment = New Augment()
            '    augment.Save(GameDatabaseDataSet, StaticAugmentsBindingSource, StaticAugmentsTableAdapter)
            'End If
            'If Not StaticConsumablesTableAdapter.GetData.Any Then
            '    Dim consumable As Consumable
            '    consumable = New Consumable()
            '    consumable.Save(GameDatabaseDataSet, StaticConsumablesBindingSource, StaticConsumablesTableAdapter)
            'End If
            'If Not StaticJewelryTableAdapter.GetData.Any Then
            '    Dim jewelryItem As Jewelry
            '    jewelry = New Jewelry()
            '    jewelry.save(GameDatabaseDataSet, StaticJewelryBindingSource, StaticJewelryTableAdapter)
            'End If
        Next

        StartLog()  'From Logs.vb

        For Each row As GameDatabaseDataSet.PlayersRow In GameDatabaseDataSet.Players
            playerSelectlstv.Items.Add(row.level)
            playerSelectlstv.Items(playerSelectlstv.Items.Count - 1).SubItems.Add(row.name)
        Next
    End Sub

    Private Sub playerNewbtn_Click(sender As Object, e As EventArgs) Handles playerNewbtn.Click
        Dim nameString As String = InputBox("Enter a name.",, "name")
        If String.IsNullOrWhiteSpace(nameString) Then
            MsgBox("Name cannot be blank.")
            Exit Sub
        End If

        'Called from Names.vb
        'Converts any string into a proper-cased trimmed string
        nameString = ProperCase(nameString)

        currentPlayer = New Player(nameString)
        currentPlayer.Save(GameDatabaseDataSet, PlayersBindingSource, PlayersTableAdapter)
        currentPlayer = New Player(PlayersTableAdapter.GetData.Last)
        playerSelectlstv.Items.Add(currentPlayer.level)
        playerSelectlstv.Items(playerSelectlstv.Items.Count - 1).SubItems.Add(currentPlayer.name)
    End Sub

    Private Sub playerSelectlstv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerSelectlstv.SelectedIndexChanged
        If Not playerSelectlstv.SelectedIndices(0) = -1 Then
            currentPlayer = New Player(PlayersTableAdapter.GetPlayerByid(playerSelectlstv.SelectedIndices(0) + 1).First)
            If PlayerStatesTableAdapter.GetLastPlayerStateByPlayerid(currentPlayer.id).Any Then
                currentState = New PlayerState(PlayerStatesTableAdapter.GetLastPlayerStateByPlayerid(currentPlayer.id).First)
                If currentState.quest IsNot Nothing Then
                    currentState.AcceptQuest(New Quest(StaticQuestsTableAdapter.GetQuestByid(currentState.quest.id).First))
                End If
                If currentState.party IsNot Nothing Then
                    currentState.party = New Party(PlayerPartiesTableAdapter.GetLastPlayerPartyByPlayerid(currentPlayer.id).First)
                End If
                If currentState.tier IsNot Nothing Then
                    currentState.tier = New Tier() 'TODO (StaticCampTierTableAdapter.GetTierByid(currentState.tier.id).First)
                End If
            Else
                currentState = New PlayerState(currentPlayer)
                currentController.SaveState()
            End If
            currentState.townwindow = New TownWindow
            currentState.townwindow.Show()
            Me.Close()
        End If
    End Sub

    Private Sub playerDeletebtn_Click(sender As Object, e As EventArgs) Handles playerDeletebtn.Click
        currentState.deletewindow = New DeletePlayersWindow
        currentState.deletewindow.Show()
        Me.Close()
    End Sub

    Private Sub initDataSetController()
        currentController = New DatasetController(GameDatabaseDataSet, PlayersTableAdapter,
                                                  PlayerStatesBindingSource, PlayerStatesTableAdapter,
                                                  PlayerCreaturesBindingSource, PlayerCreaturesTableAdapter,
                                                  PlayerSkillsBindingSource, PlayerSkillsTableAdapter,
                                                  PlayerArmorBindingSource, PlayerArmorTableAdapter,
                                                  PlayerWeaponsBindingSource, PlayerWeaponsTableAdapter,
                                                  PlayerConsumablesBindingSource, PlayerConsumablesTableAdapter,
                                                  PlayerJewelryBindingSource, PlayerJewelryTableAdapter,
                                                  PlayerAugmentsBindingSource, PlayerAugmentsTableAdapter)
    End Sub
End Class
