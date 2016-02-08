Public Class CombatWindow
    Dim enemyCreature1 As New creature
    Dim enemyCreature2 As New creature
    Dim enemyCreature3 As New creature
    Dim enemyCreature4 As New creature

    Private Sub CombatWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PlayersTableAdapter.Fill(Me.GameDatabaseDataSet.Players)

        Me.Text = "Simple Fantasy Game - Level " & currentPlayer.level & " " & currentPlayer.name
        playerTeamlbl.Text = currentPlayer.name & "'s Team"

        playerLeveltxt.Text = currentPlayer.level
        playerGoldtxt.Text = currentPlayer.gold
        playerExperiencebar.Minimum = currentPlayer.level ^ 5
        playerExperiencebar.Maximum = (currentPlayer.level + 1) ^ 5
        playerExperiencebar.Value = currentPlayer.exp
    End Sub

    Private Sub player1Itemslst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerItemslst.SelectedIndexChanged
        If Not playerItemslst.SelectedIndex = -1 Then
            currentItem = playerItemslst.SelectedItem
        End If
    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        UpdateDatabase()
        currentMainMenu = New MainMenu
        currentMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub enemySlot1Targetrad_CheckedChanged(sender As Object, e As EventArgs) Handles enemySlot1Targetrad.CheckedChanged
        playerTarget = enemyCreature1
    End Sub

    Private Sub enemySlot2Targetrad_CheckedChanged(sender As Object, e As EventArgs) Handles enemySlot2Targetrad.CheckedChanged
        playerTarget = enemyCreature2
    End Sub

    Private Sub enemySlot3Targetrad_CheckedChanged(sender As Object, e As EventArgs) Handles enemySlot3Targetrad.CheckedChanged
        playerTarget = enemyCreature3
    End Sub

    Private Sub enemySlot4Targetrad_CheckedChanged(sender As Object, e As EventArgs) Handles enemySlot4Targetrad.CheckedChanged
        playerTarget = enemyCreature4
    End Sub

    Private Sub playerSlot1Fillbtn_Click(sender As Object, e As EventArgs) Handles playerSlot1Fillbtn.Click

    End Sub

    Private Sub playerSlot2Fillbtn_Click(sender As Object, e As EventArgs) Handles playerSlot2Fillbtn.Click

    End Sub

    Private Sub playerSlot3Fillbtn_Click(sender As Object, e As EventArgs) Handles playerSlot3Fillbtn.Click

    End Sub

    Private Sub playerSlot4Fillbtn_Click(sender As Object, e As EventArgs) Handles playerSlot4Fillbtn.Click

    End Sub

    Private Sub UpdateDatabase()
        GameDatabaseDataSet.Players(currentPlayer.id - 1).level = currentPlayer.level
        GameDatabaseDataSet.Players(currentPlayer.id - 1).experience = currentPlayer.exp
        GameDatabaseDataSet.Players(currentPlayer.id - 1).gold = currentPlayer.gold
        PlayersBindingSource.EndEdit()
        PlayersTableAdapter.Update(GameDatabaseDataSet.Players)
    End Sub
End Class
