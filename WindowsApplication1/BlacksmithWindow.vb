Public Class BlacksmithWindow
    Private Sub BlacksmithWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BlacksmithStatesTableAdapter.Fill(GameDatabaseDataSet.BlacksmithStates)
        BlacksmithStateItemsTableAdapter.Fill(GameDatabaseDataSet.BlacksmithStateItems)
        StaticWeaponsTableAdapter.Fill(GameDatabaseDataSet.StaticWeapons)
        StaticArmorTableAdapter.Fill(GameDatabaseDataSet.StaticArmor)
        StaticAugmentsTableAdapter.Fill(GameDatabaseDataSet.StaticAugments)
        WeaponAugmentsTableAdapter.Fill(GameDatabaseDataSet.WeaponAugments)
        ArmorAugmentsTableAdapter.Fill(GameDatabaseDataSet.ArmorAugments)
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)
        PlayerStatesTableAdapter.Fill(GameDatabaseDataSet.PlayerStates)
        PlayerWeaponsTableAdapter.Fill(GameDatabaseDataSet.PlayerWeapons)
        PlayerArmorTableAdapter.Fill(GameDatabaseDataSet.PlayerArmor)

    End Sub

    Private Sub weaponstbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PlayerStatesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayerStatesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub

    Private Sub PlayerWeaponsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayerWeaponsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub
End Class