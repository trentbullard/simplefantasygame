Public Class PlayerWindow
    Private Sub PlayerWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerInfoPanellbl.Text = currentPlayer.ToString
        playerLeveltxt.Text = currentPlayer.level
        playerGoldtxt.Text = currentPlayer.gold
        playerExperiencebar.Minimum = currentPlayer.level ^ 5
        playerExperiencebar.Maximum = (currentPlayer.level + 1) ^ 5
        playerExperiencebar.Value = currentPlayer.exp
        PlayerCreaturesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerCreatures, currentPlayer.id)
    End Sub
End Class