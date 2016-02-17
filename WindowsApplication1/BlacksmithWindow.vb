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

        playerGoldlbl.Text = currentPlayer.name & "'s gold"
        playerGoldtxt.Text = currentPlayer.gold

        If BlacksmithStatesTableAdapter.GetLastBlacksmithStateByPlayerStateid(currentState.id).Any Then
            For Each row As DataRow In BlacksmithStateItemsTableAdapter.GetBlacksmithItemsByBlacksmithStateid(BlacksmithStatesTableAdapter.GetLastBlacksmithStateByPlayerStateid(currentState.id).First("id"))

            Next
        Else
                Dim weapon As Weapon = New Weapon()
            Dim armor As Armor = New Armor()
            For ctr = 1 To 20
                weapon = New Weapon()
                weaponslst.Items.Add(weapon.ToString)
                weapon.Save(GameDatabaseDataSet, StaticWeaponsBindingSource, StaticWeaponsTableAdapter)
                armor = New Armor()
                armorlst.Items.Add(armor.ToString)
                armor.Save(GameDatabaseDataSet, StaticArmorBindingSource, StaticArmorTableAdapter)
            Next
        End If
    End Sub

    Private Sub weaponstbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class