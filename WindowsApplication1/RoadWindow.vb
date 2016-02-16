Public Class RoadWindow
    Private Sub RoadWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerStates' table. You can move, or remove it, as needed.
        Me.PlayerStatesTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerStates)
        PlayerStatesTableAdapter.Fill(GameDatabaseDataSet.PlayerStates)

    End Sub

    Private Sub PlayerStatesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PlayerStatesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PlayerStatesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub
End Class