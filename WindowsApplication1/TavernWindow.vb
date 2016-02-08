Public Class TavernWindow
    Private tavernCreatures(4) As creature

    Private Sub TavernWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)

        For ctr = 1 To 4
            tavernCreatures(ctr) = New creature(GameDatabaseDataSet.StaticCreatures(ctr - 1))
            FillCreatureSlot(tavernCreatures(ctr), ctr)
        Next
    End Sub

    Private Sub tavernSlot1Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot1Hirebtn.Click
        If currentPlayer.SpendGold(tavernCreatures(1).level) Then
            HireCreature(tavernCreatures(1), 1)
        End If
    End Sub

    Private Sub tavernSlot2Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot2Hirebtn.Click
        If currentPlayer.SpendGold(tavernCreatures(2).level) Then
            HireCreature(tavernCreatures(2), 2)
        End If
    End Sub

    Private Sub tavernSlot3Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot3Hirebtn.Click
        If currentPlayer.SpendGold(tavernCreatures(3).level) Then
            HireCreature(tavernCreatures(3), 3)
        End If
    End Sub

    Private Sub tavernSlot4Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot4Hirebtn.Click
        If currentPlayer.SpendGold(tavernCreatures(4).level) Then
            HireCreature(tavernCreatures(4), 4)
        End If
    End Sub

    Private Sub HireCreature(creature, slot)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("PlayerCreatures").NewRow()

        newRow("playerid") = creature.owner.id
        newRow("creatureid") = creature.id

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
        End Try
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
End Class