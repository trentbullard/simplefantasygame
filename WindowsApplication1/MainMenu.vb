Imports System
Imports System.IO
Imports System.Text

Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerPartiesTableAdapter.Fill(GameDatabaseDataSet.PlayerParties)
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)
        PlayerStatesTableAdapter.Fill(GameDatabaseDataSet.PlayerStates)
        'StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        'StaticCampsTableAdapter.Fill(GameDatabaseDataSet.StaticCamps)
        'StaticCampTiersTableAdapter.Fill(GameDatabaseDataSet.StaticCampTiers)
        'StaticQuestsTableAdapter.Fill(GameDatabaseDataSet.StaticQuests)
        'StaticArmorTableAdapter.Fill(GameDatabaseDataSet.StaticArmor)
        'StaticWeaponsTableAdapter.Fill(GameDatabaseDataSet.StaticWeapons)

        For ctr = 1 To 20
            Dim creature As Creature
            creature = New Creature("creature " & ctr)
            creature.Save(GameDatabaseDataSet, StaticCreaturesBindingSource, StaticCreaturesTableAdapter)
        Next

        For ctr = 1 To 20
            Dim quest As Quest
            quest = New Quest("quest " & ctr)
            quest.Save(GameDatabaseDataSet, StaticCreaturesBindingSource, StaticQuestsTableAdapter)
        Next

        For ctr = 1 To 5
            Dim camp As Camp
            camp = New Camp()
            camp.save(GameDatabaseDataSet, StaticCampsBindingSource, StaticCampsTableAdapter)
            For ctr2 = 1 To 5
                Dim tier As Tier
                tier = New Tier(camp)
                tier.save(GameDatabaseDataSet, StaticCampTiersBindingSource, StaticCampTiersTableAdapter)
            Next
        Next

        For ctr = 1 To 10
            Dim weapon As Weapon
            weapon = New Weapon()
            weapon.Save(GameDatabaseDataSet, StaticWeaponsBindingSource, StaticWeaponsTableAdapter)
        Next

        StartLog()  'From Logs.vb

        For Each row As DataRow In GameDatabaseDataSet.Players
            playerSelectlstv.Items.Add(row("level").ToString)
            playerSelectlstv.Items(playerSelectlstv.Items.Count - 1).SubItems.Add(row("name").ToString)
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
        Try
            playerSelectlstv.Items.Add(currentPlayer.level)
            playerSelectlstv.Items(playerSelectlstv.Items.Count - 1).SubItems.Add(currentPlayer.name)
        Catch ex As Exception
            MsgBox("Unable to create new player.")
            Exit Sub
        End Try
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
                    currentState.party = New Party(PlayerPartiesTableAdapter.GetLastPartyByPlayerid(currentPlayer.id).First)
                End If
                If Not currentState.tier IsNot Nothing Then
                    currentState.tier = New Tier() 'TODO (StaticCampTierTableAdapter.GetTierByid(currentState.tier.id).First)
                End If
            Else
                currentState.Save(GameDatabaseDataSet, PlayerStatesBindingSource, PlayerStatesTableAdapter)
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

End Class
