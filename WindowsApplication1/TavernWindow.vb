Public Class TavernWindow
    Private Shared tavernCreatures(4) As creature
    Private Shared tavernQuests(3) As quest
    Private Shared tavernVisited As Boolean = False

    Private Sub TavernWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)
        PlayerCreaturesTableAdapter.Fill(GameDatabaseDataSet.PlayerCreatures)

        For ctr = 0 To 3
            If Not PlayerCreaturesTableAdapter.GetDataByPlayerid(currentPlayer.id).Any And Not tavernVisited Then
                tavernCreatures(ctr) = New creature(GameDatabaseDataSet.StaticCreatures(ctr))
                FillCreatureSlot(tavernCreatures(ctr), ctr + 1)
            ElseIf Not PlayerCreaturesTableAdapter.GetDataByPlayerid(currentPlayer.id).Any And tavernVisited Then
                FillCreatureSlot(tavernCreatures(ctr), ctr + 1)
            ElseIf currentDate < currentPlayer.currentDate Then
                tavernCreatures(ctr) = New creature(GameDatabaseDataSet.StaticCreatures(ctr))
                FillCreatureSlot(tavernCreatures(ctr), ctr + 1)
            ElseIf Not tavernCreatures(ctr).name = "" And currentDate = currentPlayer.currentDate Then
                FillCreatureSlot(tavernCreatures(ctr), ctr + 1)
            Else
                ClearCreatureSlot(ctr + 1)
                Continue For
            End If
            Select Case ctr
                Case 0
                    tavernSlot1Hirebtn.Enabled = True
                Case 1
                    tavernSlot2Hirebtn.Enabled = True
                Case 2
                    tavernSlot3Hirebtn.Enabled = True
                Case 3
                    tavernSlot4Hirebtn.Enabled = True
            End Select
        Next
        tavernVisited = True
    End Sub

    Private Sub tavernSlot1Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot1Hirebtn.Click
        If currentPlayer.SpendGold(tavernCreatures(0).level) Then
            HireCreature(tavernCreatures(0), 1)
        End If
    End Sub

    Private Sub tavernSlot2Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot2Hirebtn.Click
        If currentPlayer.SpendGold(tavernCreatures(1).level) Then
            HireCreature(tavernCreatures(1), 2)
        End If
    End Sub

    Private Sub tavernSlot3Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot3Hirebtn.Click
        If currentPlayer.SpendGold(tavernCreatures(2).level) Then
            HireCreature(tavernCreatures(2), 3)
        End If
    End Sub

    Private Sub tavernSlot4Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot4Hirebtn.Click
        If currentPlayer.SpendGold(tavernCreatures(3).level) Then
            HireCreature(tavernCreatures(3), 4)
        End If
    End Sub

    Private Sub HireCreature(creature, slot)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("PlayerCreatures").NewRow()

        newRow("playerid") = creature.owner.id
        newRow("creatureid") = creature.id
        newRow("name") = creature.name

        GameDatabaseDataSet.Tables("PlayerCreatures").Rows.Add(newRow)

        'Attempts to update the database
        Try
            Validate()
            GameDatabaseDataSet.Players(currentPlayer.id - 1).gold = currentPlayer.gold
            PlayersBindingSource.EndEdit()
            PlayersTableAdapter.Update(GameDatabaseDataSet.Players)
            PlayerCreaturesBindingSource.EndEdit()
            PlayerCreaturesTableAdapter.Update(GameDatabaseDataSet.PlayerCreatures)
            ClearCreatureSlot(slot)
        Catch ex As Exception
            MsgBox("Failed to add creature to database.")
            Exit Sub
        End Try

        currentTownWindow.RefreshControls()
    End Sub

    Private Sub FillCreatureSlot(creature, slot)
        Select Case slot
            Case 1
                tavernSlot1Nametxt.Text = creature.name
                tavernSlot1Leveltxt.Text = creature.level
                tavernSlot1Speciestxt.Text = creature.species
                tavernSlot1Healthtxt.Text = creature.health
                tavernSlot1Strengthtxt.Text = creature.str
                tavernSlot1Armortxt.Text = creature.armor
                tavernSlot1Initiativetxt.Text = creature.ini
                tavernSlot1Intelligencetxt.Text = creature.int
                tavernSlot1Wisdomtxt.Text = creature.wis
                tavernSlot1Dexteritytxt.Text = creature.dex
                tavernSlot1Hirebtn.Text = "hire for " & creature.level & " gold"
            Case 2
                tavernSlot2Nametxt.Text = creature.name
                tavernSlot2Leveltxt.Text = creature.level
                tavernSlot2Speciestxt.Text = creature.species
                tavernSlot2Healthtxt.Text = creature.health
                tavernSlot2Strengthtxt.Text = creature.str
                tavernSlot2Armortxt.Text = creature.armor
                tavernSlot2Initiativetxt.Text = creature.ini
                tavernSlot2Intelligencetxt.Text = creature.int
                tavernSlot2Wisdomtxt.Text = creature.wis
                tavernSlot2Dexteritytxt.Text = creature.dex
                tavernSlot2Hirebtn.Text = "hire for " & creature.level & " gold"
            Case 3
                tavernSlot3Nametxt.Text = creature.name
                tavernSlot3Leveltxt.Text = creature.level
                tavernSlot3Speciestxt.Text = creature.species
                tavernSlot3Healthtxt.Text = creature.health
                tavernSlot3Strengthtxt.Text = creature.str
                tavernSlot3Armortxt.Text = creature.armor
                tavernSlot3Initiativetxt.Text = creature.ini
                tavernSlot3Intelligencetxt.Text = creature.int
                tavernSlot3Wisdomtxt.Text = creature.wis
                tavernSlot3Dexteritytxt.Text = creature.dex
                tavernSlot3Hirebtn.Text = "hire for " & creature.level & " gold"
            Case 4
                tavernSlot4Nametxt.Text = creature.name
                tavernSlot4Leveltxt.Text = creature.level
                tavernSlot4Speciestxt.Text = creature.species
                tavernSlot4Healthtxt.Text = creature.health
                tavernSlot4Strengthtxt.Text = creature.str
                tavernSlot4Armortxt.Text = creature.armor
                tavernSlot4Initiativetxt.Text = creature.ini
                tavernSlot4Intelligencetxt.Text = creature.int
                tavernSlot4Wisdomtxt.Text = creature.wis
                tavernSlot4Dexteritytxt.Text = creature.dex
                tavernSlot4Hirebtn.Text = "hire for " & creature.level & " gold"
        End Select
    End Sub

    Private Sub ClearCreatureSlot(slot)
        tavernCreatures(slot - 1).name = ""
        Select Case slot
            Case 1
                tavernSlot1Nametxt.Clear()
                tavernSlot1Leveltxt.Clear()
                tavernSlot1Speciestxt.Clear()
                tavernSlot1Healthtxt.Clear()
                tavernSlot1Strengthtxt.Clear()
                tavernSlot1Armortxt.Clear()
                tavernSlot1Initiativetxt.Clear()
                tavernSlot1Intelligencetxt.Clear()
                tavernSlot1Wisdomtxt.Clear()
                tavernSlot1Dexteritytxt.Clear()
                tavernSlot1Hirebtn.Text = ""
                tavernSlot1Hirebtn.Enabled = False
            Case 2
                tavernSlot2Nametxt.Clear()
                tavernSlot2Leveltxt.Clear()
                tavernSlot2Speciestxt.Clear()
                tavernSlot2Healthtxt.Clear()
                tavernSlot2Strengthtxt.Clear()
                tavernSlot2Armortxt.Clear()
                tavernSlot2Initiativetxt.Clear()
                tavernSlot2Intelligencetxt.Clear()
                tavernSlot2Wisdomtxt.Clear()
                tavernSlot2Dexteritytxt.Clear()
                tavernSlot2Hirebtn.Text = ""
                tavernSlot2Hirebtn.Enabled = False
            Case 3
                tavernSlot3Nametxt.Clear()
                tavernSlot3Leveltxt.Clear()
                tavernSlot3Speciestxt.Clear()
                tavernSlot3Healthtxt.Clear()
                tavernSlot3Strengthtxt.Clear()
                tavernSlot3Armortxt.Clear()
                tavernSlot3Initiativetxt.Clear()
                tavernSlot3Intelligencetxt.Clear()
                tavernSlot3Wisdomtxt.Clear()
                tavernSlot3Dexteritytxt.Clear()
                tavernSlot3Hirebtn.Text = ""
                tavernSlot3Hirebtn.Enabled = False
            Case 4
                tavernSlot4Nametxt.Clear()
                tavernSlot4Leveltxt.Clear()
                tavernSlot4Speciestxt.Clear()
                tavernSlot4Healthtxt.Clear()
                tavernSlot4Strengthtxt.Clear()
                tavernSlot4Armortxt.Clear()
                tavernSlot4Initiativetxt.Clear()
                tavernSlot4Intelligencetxt.Clear()
                tavernSlot4Wisdomtxt.Clear()
                tavernSlot4Dexteritytxt.Clear()
                tavernSlot4Hirebtn.Text = ""
                tavernSlot4Hirebtn.Enabled = False
        End Select
    End Sub

    Private Sub playerbtn_Click(sender As Object, e As EventArgs) Handles playerbtn.Click
        currentPlayerWindow = New PlayerWindow
        currentPlayerWindow.Show()
    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        OpenMainMenu()
    End Sub

    Private Sub townbtn_Click(sender As Object, e As EventArgs) Handles townbtn.Click
        Me.Close()
    End Sub

    Private Sub tavernSlot1Nametxt_TextChanged(sender As Object, e As EventArgs) Handles tavernSlot1Nametxt.TextChanged
        tavernCreatures(0).name = tavernSlot1Nametxt.Text
    End Sub

    Private Sub tavernSlot2Nametxt_TextChanged(sender As Object, e As EventArgs) Handles tavernSlot2Nametxt.TextChanged
        tavernCreatures(1).name = tavernSlot2Nametxt.Text
    End Sub

    Private Sub tavernSlot3Nametxt_TextChanged(sender As Object, e As EventArgs) Handles tavernSlot3Nametxt.TextChanged
        tavernCreatures(2).name = tavernSlot3Nametxt.Text
    End Sub

    Private Sub tavernSlot4Nametxt_TextChanged(sender As Object, e As EventArgs) Handles tavernSlot4Nametxt.TextChanged
        tavernCreatures(3).name = tavernSlot4Nametxt.Text
    End Sub

    Private Sub innbtn_Click(sender As Object, e As EventArgs) Handles innbtn.Click
        currentInnWindow = New InnWindow
        currentInnWindow.Show()
        Me.Close()
    End Sub

    Private Sub NewTavernState()
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("TavernStates").NewRow()

        newRow("playerStateid") = currentState.id
        newRow("hireSlot1id") = tavernCreatures(0).id
        newRow("hireSlot2id") = tavernCreatures(1).id
        newRow("hireSlot3id") = tavernCreatures(2).id
        newRow("hireSlot4id") = tavernCreatures(3).id
        newRow("questSlot1id") = tavernQuests(0).id
        newRow("questSlot2id") = tavernQuests(1).id
        newRow("questSlot3id") = tavernQuests(2).id

    End Sub
End Class