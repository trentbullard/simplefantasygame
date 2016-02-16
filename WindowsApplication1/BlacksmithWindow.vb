Public Class BlacksmithWindow
    Private Sub BlacksmithWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BlacksmithStatesTableAdapter.FillByPlayerid(GameDatabaseDataSet.BlacksmithStates, currentPlayer.id)
        BlacksmithStateItemsTableAdapter.FillByPlayerid(GameDatabaseDataSet.BlacksmithStateItems, currentPlayer.id)
        StaticWeaponsTableAdapter.Fill(GameDatabaseDataSet.StaticWeapons)
        StaticArmorTableAdapter.Fill(GameDatabaseDataSet.StaticArmor)
        StaticAugmentsTableAdapter.Fill(GameDatabaseDataSet.StaticAugments)
        WeaponAugmentsTableAdapter.FillByPlayerid(GameDatabaseDataSet.WeaponAugments, currentPlayer.id)
        ArmorAugmentsTableAdapter.FillByPlayerid(GameDatabaseDataSet.ArmorAugments, currentPlayer.id)
        PlayersTableAdapter.FillByPlayerid(GameDatabaseDataSet.Players, currentPlayer.id)
        PlayerStatesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerStates, currentPlayer.id)
        PlayerWeaponsTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerWeapons, currentPlayer.id)
        PlayerArmorTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerArmor, currentPlayer.id)

        If BlacksmithStatesTableAdapter.GetLastBlacksmithStateByPlayerStateid(currentState.id).Any Then

        Else
            For Each row As DataRow In StaticWeaponsTableAdapter.GetBlacksmithWeapons()

            Next
        End If
    End Sub

    Private Sub weaponstbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class