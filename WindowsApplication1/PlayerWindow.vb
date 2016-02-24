Public Class PlayerWindow
    Dim creatures As New Collection

    Private Sub PlayerWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = currentPlayer.ToString
        playerLeveltxt.Text = currentPlayer.level
        playerGoldtxt.Text = currentPlayer.gold
        playerExperiencebar.Minimum = currentPlayer.level ^ 5
        playerExperiencebar.Maximum = (currentPlayer.level + 1) ^ 5
        playerExperiencebar.Value = currentPlayer.exp

        PlayersTableAdapter.FillByPlayerid(GameDatabaseDataSet.Players, currentPlayer.id)
        PlayerCreaturesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.PlayerCreatures, currentState.id)
        PlayerWeaponsTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.PlayerWeapons, currentState.id)
        PlayerArmorTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.PlayerArmor, currentState.id)
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        StaticWeaponsTableAdapter.Fill(GameDatabaseDataSet.StaticWeapons)
        StaticArmorTableAdapter.Fill(GameDatabaseDataSet.StaticArmor)

        RefreshQuest()

        For Each row As GameDatabaseDataSet.PlayerCreaturesRow In GameDatabaseDataSet.PlayerCreatures
            Dim creation As New Creature(row.id, GameDatabaseDataSet.StaticCreatures.FindByid(row.creatureid))
            creation.name = row.name
            creaturelst.Items.Add(creation.ToString)
            creatures.Add(creation, creaturelst.Items.Count)
        Next
        For Each row As GameDatabaseDataSet.PlayerWeaponsRow In GameDatabaseDataSet.PlayerWeapons
            Dim weapon As New Weapon(GameDatabaseDataSet.StaticWeapons.FindByid(row.weaponid))
            itemslst.Items.Add(weapon.ToString)
        Next
        For Each row As GameDatabaseDataSet.PlayerArmorRow In GameDatabaseDataSet.PlayerArmor
            Dim armor As New Armor(GameDatabaseDataSet.StaticArmor.FindByid(row.armorid))
            itemslst.Items.Add(armor.ToString)
        Next
    End Sub

    Private Sub creaturelst_Click(sender As Object, e As EventArgs) Handles creaturelst.Click
        If creaturelst.SelectedIndices.Count = 0 Then Exit Sub
        If creaturelst.SelectedIndices(0) = -1 Then Exit Sub

        Dim index = creaturelst.SelectedIndex + 1
        currentState.creaturewindow = New CreatureWindow(creatures(index))
        currentState.creaturewindow.ShowDialog(Me)
        RefreshControls()
    End Sub

    Private Sub itemslst_Click(sender As Object, e As EventArgs) Handles itemslst.Click
        If itemslst.SelectedIndices.Count = 0 Then Exit Sub
        If itemslst.SelectedIndices(0) = -1 Then Exit Sub

        currentState.itemwindow = New ItemWindow
        currentState.itemwindow.ShowDialog(Me)
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
        currentPlayer.Save(GameDatabaseDataSet, PlayersBindingSource, PlayersTableAdapter)
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

    Private Sub RefreshControls()
        For ctr = creaturelst.Items.Count - 1 To 0 Step -1
            creaturelst.Items.RemoveAt(ctr)
        Next
        creatures.Clear()
        PlayerCreaturesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.PlayerCreatures, currentState.id)
        For Each row As GameDatabaseDataSet.PlayerCreaturesRow In GameDatabaseDataSet.PlayerCreatures
            Dim creation As New Creature(row.id, GameDatabaseDataSet.StaticCreatures.FindByid(row.creatureid))
            creation.name = row.name
            creaturelst.Items.Add(creation.ToString)
            creatures.Add(creation, creaturelst.Items.Count)
        Next
    End Sub

End Class