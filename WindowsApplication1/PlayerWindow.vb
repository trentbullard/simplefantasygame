Public Class PlayerWindow
    Private Sub PlayerWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = currentPlayer.ToString
        playerInfoPanellbl.Text = currentPlayer.ToString
        playerLeveltxt.Text = currentPlayer.level
        playerGoldtxt.Text = currentPlayer.gold
        playerExperiencebar.Minimum = currentPlayer.level ^ 5
        playerExperiencebar.Maximum = (currentPlayer.level + 1) ^ 5
        playerExperiencebar.Value = currentPlayer.exp

        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)
        PlayerStatesTableAdapter.Fill(GameDatabaseDataSet.PlayerStates)
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        StaticQuestsTableAdapter.Fill(GameDatabaseDataSet.StaticQuests)
        PlayerCreaturesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerCreatures, currentPlayer.id)

        RefreshQuest()

        For Each row As DataRow In PlayerCreaturesTableAdapter.GetCreaturesByPlayerid(currentPlayer.id)
            Dim creation As New Creature(StaticCreaturesTableAdapter.GetCreatureByid(row("creatureid"))(0))
            creation.name = ProperCase(row("name"))
            creaturelst.Items.Add(creation.ToString)
        Next
    End Sub

    Private Sub creaturelst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles creaturelst.SelectedIndexChanged
        If Not creaturelst.SelectedIndices(0) = -1 Then
            currentState.creaturewindow = New CreatureWindow
            currentState.creaturewindow.Show()
        End If
    End Sub

    Private Sub NameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NameToolStripMenuItem.Click
        Dim nameString As String = InputBox("enter a name.",, currentPlayer.name)
        If String.IsNullOrWhiteSpace(nameString) Then
            MsgBox("Name cannot be blank.")
            Exit Sub
        End If

        'Called from Names.vb
        'Converts any string into a proper-cased trimmed string
        nameString = ProperCase(nameString)

        currentPlayer.ReName(nameString)
        Me.Text = currentPlayer.ToString
        playerInfoPanellbl.Text = currentPlayer.ToString
        currentPlayer.Save(GameDatabaseDataSet, PlayersBindingSource, PlayersTableAdapter)
    End Sub

    Private Sub PlayersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub

    Private Sub PlayersBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub

    Private Sub currentQuestlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles currentQuestlbl.LinkClicked
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("are you sure you want to abandon this quest?", style, "Confirm Deletion")

        If response = MsgBoxResult.Yes Then
            currentState.AbandonQuest()
            currentState.Save(GameDatabaseDataSet, PlayerStatesBindingSource, PlayerStatesTableAdapter)
            RefreshQuest()
        End If
    End Sub

    Private Sub RefreshQuest()
        If currentState.quest IsNot Nothing Then
            noActiveQuestlbl.Enabled = False
            noActiveQuestlbl.Visible = False
            currentQuestlbl.Enabled = True
            currentQuestlbl.Visible = True
            currentQuestrtxt.Text = currentState.quest.ToString
        Else
            currentQuestlbl.Enabled = False
            currentQuestlbl.Visible = False
            noActiveQuestlbl.Enabled = True
            noActiveQuestlbl.Visible = True
            currentQuestrtxt.Text = "you do not have a quest currently active. accept a new one at the tavern in town."
        End If
    End Sub

    Private Sub QuestsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuestsToolStripMenuItem.Click
        MsgBox("quests are given at the tavern in town." & vbCrLf & "abandon your current quest by clicking ""current quest""")
    End Sub
End Class