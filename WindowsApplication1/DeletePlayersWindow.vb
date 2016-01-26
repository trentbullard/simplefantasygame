Public Class DeletePlayersWindow
    Dim playerSelection As ListBox.SelectedIndexCollection

    Private Sub DeletePlayersWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)

        StartLog()  'From log.vb

        For Each row As DataRow In GameDatabaseDataSet.Players
            deletePlayersclst.Items.Add(New player(row("id"), row("name"), row("level"), row("experience"), row("gold")))
        Next
    End Sub

    Private Sub deletePlayersclst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deletePlayersclst.SelectedIndexChanged
        playerSelection = deletePlayersclst.SelectedIndices
    End Sub

    Private Sub deletePlayersbtn_Click(sender As Object, e As EventArgs) Handles deletePlayersbtn.Click
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("Are you sure??", style, "Confirm Deletion")
        Dim oForm As New MainMenu
        Dim oldPlayersRow As GameDatabaseDataSet.PlayersRow
        oldPlayersRow = GameDatabaseDataSet.Players.FindByid(playerSelection(0) + 1)

        If response = MsgBoxResult.Yes Then
            Try
                oldPlayersRow.Delete()
                Validate()
                PlayersBindingSource.EndEdit()
                PlayersTableAdapter.Update(GameDatabaseDataSet.Players)
            Catch ex As Exception
                MsgBox("Failed to remove player from database.")
            End Try

            oForm.Show()
            Me.Close()
        Else
            oForm.Show()
            Me.Close()
        End If

    End Sub
End Class