Imports System
Imports System.IO
Imports System.Text

Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaticQuestsTableAdapter.Fill(GameDatabaseDataSet.StaticQuests)
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)
        PlayerStatesTableAdapter.Fill(GameDatabaseDataSet.PlayerStates)
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)

        For ctr = 1 To 20
            LoadCreatures(New Creature("creature " & ctr))
        Next

        For ctr = 1 To 20
            LoadQuests(New Quest("quest " & ctr))
        Next

        StartLog()  'From log.vb

        For Each row As DataRow In GameDatabaseDataSet.Players
            playerSelectlstv.Items.Add(New Player(row).level)
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

        Dim player As New Player(nameString)
        NewPlayer(player)
        Try
            playerSelectlstv.Items.Add(player.level)
            playerSelectlstv.Items(playerSelectlstv.Items.Count - 1).SubItems.Add(player.name)
        Catch ex As Exception
            MsgBox("Unable to create new player.")
            Exit Sub
        End Try
    End Sub

    Private Sub playerSelectlstv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerSelectlstv.SelectedIndexChanged
        If Not playerSelectlstv.SelectedIndices(0) = -1 Then
            Dim playerRow As DataRow = PlayersTableAdapter.GetPlayerByid(playerSelectlstv.SelectedIndices(0) + 1).First
            currentPlayer = New Player(playerRow)
            If PlayerStatesTableAdapter.GetLastPlayerStateByPlayerid(currentPlayer.id).Any Then
                Dim playerStateRow As DataRow = PlayerStatesTableAdapter.GetLastPlayerStateByPlayerid(currentPlayer.id).First
                currentState = New PlayerState(playerStateRow)
            Else
                currentState = New PlayerState(NewPlayerState(currentPlayer))
            End If
            currentState.townwindow = New TownWindow
            currentState.townwindow.Show()
            Me.Close()
        End If
    End Sub

    Private Sub NewPlayer(player As Player)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("Players").NewRow()

        newRow("name") = player.name
        newRow("level") = player.level
        newRow("experience") = player.exp
        newRow("gold") = player.gold

        GameDatabaseDataSet.Tables("Players").Rows.Add(newRow)

        'Attempts to update the database with the new row from the dataset.
        'If successful, a new Player instance is created with the attributes
        'from the new database record.
        Try
            Validate()
            PlayersBindingSource.EndEdit()
            PlayersTableAdapter.Update(GameDatabaseDataSet.Players)
            newRow = PlayersTableAdapter.GetLastRow().Select().First
            LogNewPlayer(newRow, True)  'from log.vb
        Catch ex As Exception
            LogNewPlayer(newRow, False)  'from log.vb
            MsgBox("Failed to add player to database.")
        End Try
    End Sub

    Private Function NewPlayerState(currentPlayer As Player) As GameDatabaseDataSet.PlayerStatesRow
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("PlayerStates").NewRow

        newRow("playerid") = currentPlayer.id
        newRow("dateSaved") = Date.Now
        newRow("currentPartyid") = -1
        newRow("currentTierid") = -1
        newRow("currentQuestid") = -1
        newRow("gameDate") = "1/1/1000"

        GameDatabaseDataSet.Tables("PlayerStates").Rows.Add(newRow)

        Try
            Validate()
            PlayerStatesBindingSource.EndEdit()
            PlayerStatesTableAdapter.Update(GameDatabaseDataSet.PlayerStates)
            Return PlayerStatesTableAdapter.GetLastRow().First
        Catch ex As Exception
            MsgBox("failed to add playerstate to database")
            Exit Function
        End Try
    End Function

    Private Sub LoadCreatures(creature As Creature)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("StaticCreatures").NewRow()

        newRow("species") = creature.species
        newRow("class") = creature.job
        newRow("level") = creature.level
        newRow("experience") = creature.exp
        newRow("maxHealth") = creature.maxHP
        newRow("health") = creature.health
        newRow("strength") = creature.str
        newRow("armor") = creature.armor
        newRow("initiative") = creature.ini
        newRow("intelligence") = creature.int
        newRow("wisdom") = creature.wis
        newRow("dexterity") = creature.dex
        newRow("name") = creature.name

        GameDatabaseDataSet.Tables("StaticCreatures").Rows.Add(newRow)

        Try
            Validate()
            StaticCreaturesBindingSource.EndEdit()
            StaticCreaturesTableAdapter.Update(GameDatabaseDataSet.StaticCreatures)
        Catch ex As Exception
            LogNewPlayer(newRow, False)  'from log.vb
            MsgBox("failed to add static creature to database.")
        End Try
    End Sub

    Private Sub LoadQuests(quest As Quest)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("StaticQuests").NewRow()
        Dim item As Integer = Roll(4)

        newRow("name") = quest.name
        newRow("tierid") = quest.tier.id
        newRow("minLevel") = quest.minLevel
        newRow("maxLevel") = quest.maxLevel
        Select Case item
            Case 1
                newRow("rewardWeaponid") = Roll(20)
            Case 2
                newRow("rewardArmorid") = Roll(20)
            Case 3
                newRow("rewardAugmentid") = Roll(20)
            Case 4
                newRow("rewardConsumableid") = Roll(20)
        End Select
        newRow("rewardExperience") = quest.rewardExp
        newRow("rewardGold") = quest.rewardGold
        newRow("isComplete") = quest.isComplete

        GameDatabaseDataSet.Tables("StaticQuests").Rows.Add(newRow)

        Try
            Validate()
            StaticQuestsBindingSource.EndEdit()
            StaticQuestsTableAdapter.Update(GameDatabaseDataSet.StaticQuests)
        Catch ex As Exception
            LogNewPlayer(newRow, False)  'from log.vb
            MsgBox("failed to add static quest to database.")
        End Try
    End Sub

    Private Sub playerDeletebtn_Click(sender As Object, e As EventArgs) Handles playerDeletebtn.Click
        currentState.deletewindow = New DeletePlayersWindow
        currentState.deletewindow.Show()
        Me.Close()
    End Sub
End Class