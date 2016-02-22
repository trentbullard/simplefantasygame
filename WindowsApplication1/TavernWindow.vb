Public Class TavernWindow
    Private currentTavernState As TavernState
    Private tavernRandomInts(4) As Integer

    Private Sub TavernWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayersTableAdapter.FillByPlayerid(GameDatabaseDataSet.Players, currentPlayer.id)
        TavernStatesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.TavernStates, currentState.id)
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        StaticQuestsTableAdapter.Fill(GameDatabaseDataSet.StaticQuests)
        PlayerCreaturesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.PlayerCreatures, currentState.id)
        tavernRandoms()

        If TavernStatesTableAdapter.GetLastTavernStateByPlayerStateid(currentState.id).Any Then
            currentTavernState = New TavernState(TavernStatesTableAdapter.GetLastTavernStateByPlayerStateid(currentState.id).First)
            currentTavernState.FillHires(StaticCreaturesTableAdapter.GetCreaturesByTavernStateid(currentTavernState.id))
            currentTavernState.FillQuests(StaticQuestsTableAdapter.GetQuestsByTavernStateid(currentTavernState.id))
            For ctr = 0 To 3
                If currentTavernState.dateVisited < currentState.dateInGame Then
                    RefreshTavernHireSlot(ctr + 1)
                    If ctr < 3 Then
                        RefreshTavernQuestSlot(ctr + 1)
                    End If
                ElseIf currentTavernState.hires(ctr) IsNot Nothing Then
                    If Not currentTavernState.hires(ctr).id = -1 Then
                        FillCreatureSlot(currentTavernState.hires(ctr), ctr + 1)
                    End If
                Else
                    ClearCreatureSlot(ctr + 1)
                End If
            Next
            For ctr = 0 To 2
                If currentState.quest IsNot Nothing Then
                    ClearQuestSlots()
                ElseIf currentTavernState.quests(ctr) IsNot Nothing Then
                    If Not currentTavernState.quests(ctr).id = -1 Then
                        FillQuestSlot(currentTavernState.quests(ctr), ctr + 1)
                    End If
                Else
                    ClearQuestSlots()
                End If
            Next
        Else
            currentTavernState = New TavernState(currentState)
            For ctr = 0 To 3
                RefreshTavernHireSlot(ctr + 1)
                If ctr < 3 Then
                    RefreshTavernQuestSlot(ctr + 1)
                End If
            Next
        End If
        NewTavernState()
    End Sub

    Private Sub tavernSlot1Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot1Hirebtn.Click
        If currentPlayer.SpendGold(currentTavernState.hires(0).level) Then
            HireCreature(currentTavernState.hires(0), 1)
        End If
    End Sub

    Private Sub tavernSlot2Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot2Hirebtn.Click
        If currentPlayer.SpendGold(currentTavernState.hires(1).level) Then
            HireCreature(currentTavernState.hires(1), 2)
        End If
    End Sub

    Private Sub tavernSlot3Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot3Hirebtn.Click
        If currentPlayer.SpendGold(currentTavernState.hires(2).level) Then
            HireCreature(currentTavernState.hires(2), 3)
        End If
    End Sub

    Private Sub tavernSlot4Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot4Hirebtn.Click
        If currentPlayer.SpendGold(currentTavernState.hires(3).level) Then
            HireCreature(currentTavernState.hires(3), 4)
        End If
    End Sub

    Private Sub questSlot1btn_Click(sender As Object, e As EventArgs) Handles questSlot1btn.Click
        AcceptQuest(currentTavernState.quests(0), 1)
    End Sub

    Private Sub questSlot2btn_Click(sender As Object, e As EventArgs) Handles questSlot2btn.Click
        AcceptQuest(currentTavernState.quests(1), 2)
    End Sub

    Private Sub questSlot3btn_Click(sender As Object, e As EventArgs) Handles questSlot3btn.Click
        AcceptQuest(currentTavernState.quests(2), 3)
    End Sub

    Private Sub HireCreature(creature As Creature, slot As Integer)
        Dim newRow As GameDatabaseDataSet.PlayerCreaturesRow = GameDatabaseDataSet.PlayerCreatures.NewPlayerCreaturesRow

        newRow.playerStateid = currentState.id
        newRow.creatureid = creature.id
        newRow.name = creature.name

        GameDatabaseDataSet.PlayerCreatures.Rows.Add(newRow)

        'Attempts to update the database
        Try
            PlayerCreaturesBindingSource.EndEdit()
            PlayerCreaturesTableAdapter.Update(GameDatabaseDataSet.PlayerCreatures)
            ClearCreatureSlot(slot)
        Catch ex As Exception
            MsgBox("failed to save state (TavernWindow.HireCreature)")
            Exit Sub
        End Try
        currentState.townwindow.RefreshControls()
    End Sub

    Private Sub AcceptQuest(quest As Quest, slot As Integer)
        currentState.AcceptQuest(quest)
        Try
            currentController.SaveState()
            ClearQuestSlots()
        Catch ex As Exception
            MsgBox("unable to save state (TavernWindow.AcceptQuest)")
        End Try
        NewTavernState()
    End Sub

    Private Sub FillCreatureSlot(creature As Creature, slot As Integer)
        Select Case slot
            Case 1
                tavernSlot1Nametxt.Text = currentTavernState.hires(0).name
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
                tavernSlot1Hirebtn.Enabled = True
                tavernSlot1Nametxt.ReadOnly = False
            Case 2
                tavernSlot2Nametxt.Text = currentTavernState.hires(1).name
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
                tavernSlot2Hirebtn.Enabled = True
                tavernSlot2Nametxt.ReadOnly = False
            Case 3
                tavernSlot3Nametxt.Text = currentTavernState.hires(2).name
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
                tavernSlot3Hirebtn.Enabled = True
                tavernSlot3Nametxt.ReadOnly = False
            Case 4
                tavernSlot4Nametxt.Text = currentTavernState.hires(3).name
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
                tavernSlot4Hirebtn.Enabled = True
                tavernSlot4Nametxt.ReadOnly = False
        End Select
    End Sub

    Private Sub FillQuestSlot(quest As Quest, slot As Integer)
        Select Case slot
            Case 1
                questSlot1rtxt.Text = quest.ToString
            Case 2
                questSlot2rtxt.Text = quest.ToString
            Case 3
                questSlot3rtxt.Text = quest.ToString
        End Select
    End Sub

    Private Sub ClearCreatureSlot(slot As Integer)
        currentTavernState.hires(slot - 1) = Nothing
        Select Case slot
            Case 1
                tavernSlot1Nametxt.Clear()
                tavernSlot1Nametxt.ReadOnly = True
                tavernSlot1Leveltxt.Clear()
                tavernSlot1Speciestxt.Clear()
                tavernSlot1Healthtxt.Clear()
                tavernSlot1Strengthtxt.Clear()
                tavernSlot1Armortxt.Clear()
                tavernSlot1Initiativetxt.Clear()
                tavernSlot1Intelligencetxt.Clear()
                tavernSlot1Wisdomtxt.Clear()
                tavernSlot1Dexteritytxt.Clear()
                tavernSlot1Hirebtn.Text = "return later"
                tavernSlot1Hirebtn.Enabled = False
            Case 2
                tavernSlot2Nametxt.Clear()
                tavernSlot2Nametxt.ReadOnly = True
                tavernSlot2Leveltxt.Clear()
                tavernSlot2Speciestxt.Clear()
                tavernSlot2Healthtxt.Clear()
                tavernSlot2Strengthtxt.Clear()
                tavernSlot2Armortxt.Clear()
                tavernSlot2Initiativetxt.Clear()
                tavernSlot2Intelligencetxt.Clear()
                tavernSlot2Wisdomtxt.Clear()
                tavernSlot2Dexteritytxt.Clear()
                tavernSlot2Hirebtn.Text = "return later"
                tavernSlot2Hirebtn.Enabled = False
            Case 3
                tavernSlot3Nametxt.Clear()
                tavernSlot3Nametxt.ReadOnly = True
                tavernSlot3Leveltxt.Clear()
                tavernSlot3Speciestxt.Clear()
                tavernSlot3Healthtxt.Clear()
                tavernSlot3Strengthtxt.Clear()
                tavernSlot3Armortxt.Clear()
                tavernSlot3Initiativetxt.Clear()
                tavernSlot3Intelligencetxt.Clear()
                tavernSlot3Wisdomtxt.Clear()
                tavernSlot3Dexteritytxt.Clear()
                tavernSlot3Hirebtn.Text = "return later"
                tavernSlot3Hirebtn.Enabled = False
            Case 4
                tavernSlot4Nametxt.Clear()
                tavernSlot4Nametxt.ReadOnly = True
                tavernSlot4Leveltxt.Clear()
                tavernSlot4Speciestxt.Clear()
                tavernSlot4Healthtxt.Clear()
                tavernSlot4Strengthtxt.Clear()
                tavernSlot4Armortxt.Clear()
                tavernSlot4Initiativetxt.Clear()
                tavernSlot4Intelligencetxt.Clear()
                tavernSlot4Wisdomtxt.Clear()
                tavernSlot4Dexteritytxt.Clear()
                tavernSlot4Hirebtn.Text = "return later"
                tavernSlot4Hirebtn.Enabled = False
        End Select
    End Sub

    Private Sub ClearQuestSlots()
        questSlot1rtxt.Text = "complete or abandon current quest"
        questSlot1rtxt.Enabled = False
        questSlot2rtxt.Text = "complete or abandon current quest"
        questSlot2rtxt.Enabled = False
        questSlot3rtxt.Text = "complete or abandon current quest"
        questSlot3rtxt.Enabled = False
    End Sub

    Private Sub playerbtn_Click(sender As Object, e As EventArgs) Handles playerbtn.Click
        currentState.playerwindow = New PlayerWindow
        currentState.playerwindow.Show()
    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        OpenMainMenu()
    End Sub

    Private Sub townbtn_Click(sender As Object, e As EventArgs) Handles townbtn.Click
        Me.Close()
    End Sub

    Private Sub tavernSlot1Nametxt_TextChanged(sender As Object, e As EventArgs) Handles tavernSlot1Nametxt.TextChanged
        If currentTavernState.hires(0) IsNot Nothing Then
            currentTavernState.hires(0).name = tavernSlot1Nametxt.Text
        End If
    End Sub

    Private Sub tavernSlot2Nametxt_TextChanged(sender As Object, e As EventArgs) Handles tavernSlot2Nametxt.TextChanged
        If currentTavernState.hires(1) IsNot Nothing Then
            currentTavernState.hires(1).name = tavernSlot2Nametxt.Text
        End If
    End Sub

    Private Sub tavernSlot3Nametxt_TextChanged(sender As Object, e As EventArgs) Handles tavernSlot3Nametxt.TextChanged
        If currentTavernState.hires(2) IsNot Nothing Then
            currentTavernState.hires(2).name = tavernSlot3Nametxt.Text
        End If
    End Sub

    Private Sub tavernSlot4Nametxt_TextChanged(sender As Object, e As EventArgs) Handles tavernSlot4Nametxt.TextChanged
        If currentTavernState.hires(3) IsNot Nothing Then
            currentTavernState.hires(3).name = tavernSlot4Nametxt.Text
        End If
    End Sub

    Private Sub innbtn_Click(sender As Object, e As EventArgs) Handles innbtn.Click
        currentState.innwindow = New InnWindow
        currentState.innwindow.Show()
        Me.Close()
    End Sub

    Public Sub NewTavernState()
        currentTavernState.changeDate(DateTime.Parse(currentState.dateInGame) - currentTavernState.dateVisited)
        Dim newRow As GameDatabaseDataSet.TavernStatesRow = GameDatabaseDataSet.TavernStates.NewRow()

        newRow("playerStateid") = currentState.id
        If currentTavernState.hires(0) IsNot Nothing Then
            newRow("hireSlot1id") = currentTavernState.hires(0).id
        Else
            newRow("hireSlot1id") = DBNull.Value
        End If
        If currentTavernState.hires(1) IsNot Nothing Then
            newRow("hireSlot2id") = currentTavernState.hires(1).id
        Else
            newRow("hireSlot2id") = DBNull.Value
        End If
        If currentTavernState.hires(2) IsNot Nothing Then
            newRow("hireSlot3id") = currentTavernState.hires(2).id
        Else
            newRow("hireSlot3id") = DBNull.Value
        End If
        If currentTavernState.hires(3) IsNot Nothing Then
            newRow("hireSlot4id") = currentTavernState.hires(3).id
        Else
            newRow("hireSlot4id") = DBNull.Value
        End If
        If currentTavernState.quests(0) IsNot Nothing Then
            newRow("questSlot1id") = currentTavernState.quests(0).id
        Else
            newRow("questSlot1id") = DBNull.Value
        End If
        If currentTavernState.quests(1) IsNot Nothing Then
            newRow("questSlot2id") = currentTavernState.quests(1).id
        Else
            newRow("questSlot2id") = DBNull.Value
        End If
        If currentTavernState.quests(2) IsNot Nothing Then
            newRow("questSlot3id") = currentTavernState.quests(2).id
        Else
            newRow("questSlot3id") = DBNull.Value
        End If
        newRow("dateVisited") = currentTavernState.dateVisited

        GameDatabaseDataSet.TavernStates.Rows.Add(newRow)

        Try
            Validate()
            TavernStatesBindingSource.EndEdit()
            TavernStatesTableAdapter.Update(GameDatabaseDataSet.TavernStates)
        Catch ex As Exception
            MsgBox("Failed to add tavern state to database.")
        End Try
    End Sub

    Private Sub RefreshTavernHireSlot(slot As Integer)
        currentTavernState.hires(slot - 1) = New Creature(StaticCreaturesTableAdapter.GetCreatureByid(tavernRandomInts(slot - 1)).First)
        FillCreatureSlot(currentTavernState.hires(slot - 1), slot)
    End Sub

    Private Sub RefreshTavernQuestSlot(slot As Integer)
        currentTavernState.quests(slot - 1) = New Quest(StaticQuestsTableAdapter.GetQuestByid(tavernRandomInts(slot - 1)).First)
        FillQuestSlot(currentTavernState.quests(slot - 1), slot)
    End Sub

    Private Sub tavernRandoms()
        For ctr = 0 To 3
            Select Case ctr
                Case 0
                    tavernRandomInts(0) = Roll(20)
                Case 1
                    Do
                        tavernRandomInts(1) = Roll(20)
                    Loop While tavernRandomInts(1) = tavernRandomInts(0)
                Case 2
                    Do
                        tavernRandomInts(2) = Roll(20)
                    Loop While tavernRandomInts(2) = tavernRandomInts(0) _
                        Or tavernRandomInts(2) = tavernRandomInts(1)
                Case 3
                    Do
                        tavernRandomInts(3) = Roll(20)
                    Loop While tavernRandomInts(3) = tavernRandomInts(0) _
                        Or tavernRandomInts(3) = tavernRandomInts(1) _
                        Or tavernRandomInts(3) = tavernRandomInts(2)
            End Select
        Next
    End Sub

    Private Sub CloseEventHandler(sender As Object, e As EventArgs) Handles Me.Closed
        currentController.SaveState()
        NewTavernState()
    End Sub

End Class