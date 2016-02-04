Public Class DeletePlayersWindow
    Dim playerSelection As New player

    Private Sub DeletePlayersWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PlayersTableAdapter.Fill(Me.GameDatabaseDataSet.Players)
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)

        StartLog()  'From log.vb

        For Each row As DataRow In GameDatabaseDataSet.Players
            deletePlayerslst.Items.Add(New player(row("id"), row("name"), row("level"), row("experience"), row("gold")))
        Next
    End Sub

    Private Sub deletePlayerslst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles deletePlayerslst.SelectedIndexChanged
        playerSelection = deletePlayerslst.SelectedItem
    End Sub

    Private Sub deletePlayersbtn_Click(sender As Object, e As EventArgs) Handles deletePlayersbtn.Click
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("Are you sure??", style, "Confirm Deletion")
        Dim oForm As New MainMenu
        Dim oldPlayersRow As GameDatabaseDataSet.PlayersRow

        If response = MsgBoxResult.Yes Then
            Try
                oldPlayersRow = GameDatabaseDataSet.Players.FindByid(playerSelection.id)
                oldPlayersRow.Delete()
                Validate()
                PlayersBindingSource.EndEdit()
                PlayersTableAdapter.Update(GameDatabaseDataSet.Players)
            Catch ex As Exception
                MsgBox("Failed to remove players from database.")
            End Try

            oForm.Show()
            Me.Close()
        Else
            oForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub PlayersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)
    End Sub
End Class