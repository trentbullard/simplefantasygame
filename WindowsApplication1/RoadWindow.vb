Public Class RoadWindow
    Private Sub RoadWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerStatesTableAdapter.Fill(GameDatabaseDataSet.PlayerStates)

    End Sub
End Class