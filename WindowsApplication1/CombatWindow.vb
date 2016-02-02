Public Class CombatWindow
    Dim enemyCreature1 As New creature
    Dim enemyCreature2 As New creature
    Dim enemyCreature3 As New creature
    Dim enemyCreature4 As New creature

    Private Sub CombatWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.GameDatabaseDataSet.Items)
        Me.CreaturesTableAdapter.Fill(Me.GameDatabaseDataSet.Creatures)
        Me.BattlesTableAdapter.Fill(Me.GameDatabaseDataSet.Battles)
        Me.AttacksTableAdapter.Fill(Me.GameDatabaseDataSet.Attacks)
        Me.ItemsTableAdapter.Fill(Me.GameDatabaseDataSet.Items)

        Me.Text = "Simple Fantasy Game - Level " & currentPlayer.level & " " & currentPlayer.name
        playerTeamlbl.Text = currentPlayer.name & "'s Team"

        playerLeveltxt.Text = currentPlayer.level
        playerGoldtxt.Text = currentPlayer.gold

        If CreaturesTableAdapter.GetRowsByPlayer(currentPlayer.id).Any Then
            tavernlbl.Hide()
            For Each row In CreaturesTableAdapter.GetRowsByPlayer(currentPlayer.id)
                hireListlst.Items.Add(New creature(row))
            Next
        End If
    End Sub

    Private Sub hireListlst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hireListlst.SelectedIndexChanged
        If Not hireListlst.SelectedIndex = -1 Then
            currentCreature = hireListlst.SelectedItem
        End If
    End Sub

    Private Sub player1Itemslst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerItemslst.SelectedIndexChanged
        currentItem = playerItemslst.SelectedItem
    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        Dim oForm As New MainMenu
        oForm.Show()
        Me.Close()
    End Sub

    Private Sub tavernbtn_Click(sender As Object, e As EventArgs) Handles tavernbtn.Click
        currentTavernWindow = New TavernWindow
        currentTavernWindow.Show()
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
        If Not hireListlst.SelectedIndex = -1 Then
            playerSlot1Nametxt.Text = currentCreature.name
            playerSlot1Leveltxt.Text = currentCreature.level
            playerSlot1Speciestxt.Text = currentCreature.species
            playerSlot1Healthtxt.Text = currentCreature.health
            playerSlot1Armortxt.Text = currentCreature.armor
            hireListlst.Items.Remove(hireListlst.SelectedItem)
        End If
    End Sub

    Private Sub playerSlot2Fillbtn_Click(sender As Object, e As EventArgs) Handles playerSlot2Fillbtn.Click
        If Not hireListlst.SelectedIndex = -1 Then
            playerSlot2Nametxt.Text = currentCreature.name
            playerSlot2Leveltxt.Text = currentCreature.level
            playerSlot2Speciestxt.Text = currentCreature.species
            playerSlot2Healthtxt.Text = currentCreature.health
            playerSlot2Armortxt.Text = currentCreature.armor
            hireListlst.Items.Remove(hireListlst.SelectedItem)
        End If
    End Sub

    Private Sub playerSlot3Fillbtn_Click(sender As Object, e As EventArgs) Handles playerSlot3Fillbtn.Click
        If Not hireListlst.SelectedIndex = -1 Then
            playerSlot3Nametxt.Text = currentCreature.name
            playerSlot3Leveltxt.Text = currentCreature.level
            playerSlot3Speciestxt.Text = currentCreature.species
            playerSlot3Healthtxt.Text = currentCreature.health
            playerSlot3Armortxt.Text = currentCreature.armor
            hireListlst.Items.Remove(hireListlst.SelectedItem)
        End If
    End Sub

    Private Sub playerSlot4Fillbtn_Click(sender As Object, e As EventArgs) Handles playerSlot4Fillbtn.Click
        If Not hireListlst.SelectedIndex = -1 Then
            playerSlot4Nametxt.Text = currentCreature.name
            playerSlot4Leveltxt.Text = currentCreature.level
            playerSlot4Speciestxt.Text = currentCreature.species
            playerSlot4Healthtxt.Text = currentCreature.health
            playerSlot4Armortxt.Text = currentCreature.armor
            hireListlst.Items.Remove(hireListlst.SelectedItem)
        End If
    End Sub
End Class
