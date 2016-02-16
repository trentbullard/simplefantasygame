Public Class BlacksmithWindow
    Private Sub BlacksmithWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.ArmorAugments' table. You can move, or remove it, as needed.
        Me.ArmorAugmentsTableAdapter.Fill(Me.GameDatabaseDataSet.ArmorAugments)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.WeaponAugments' table. You can move, or remove it, as needed.
        Me.WeaponAugmentsTableAdapter.Fill(Me.GameDatabaseDataSet.WeaponAugments)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticAugments' table. You can move, or remove it, as needed.
        Me.StaticAugmentsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticAugments)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerArmor' table. You can move, or remove it, as needed.
        Me.PlayerArmorTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerArmor)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.Players' table. You can move, or remove it, as needed.
        Me.PlayersTableAdapter.Fill(Me.GameDatabaseDataSet.Players)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.BlacksmithStateItems' table. You can move, or remove it, as needed.
        Me.BlacksmithStateItemsTableAdapter.Fill(Me.GameDatabaseDataSet.BlacksmithStateItems)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.BlacksmithStates' table. You can move, or remove it, as needed.
        Me.BlacksmithStatesTableAdapter.Fill(Me.GameDatabaseDataSet.BlacksmithStates)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticWeapons' table. You can move, or remove it, as needed.
        Me.StaticWeaponsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticWeapons)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticArmor' table. You can move, or remove it, as needed.
        Me.StaticArmorTableAdapter.Fill(Me.GameDatabaseDataSet.StaticArmor)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerStates' table. You can move, or remove it, as needed.
        Me.PlayerStatesTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerStates)

    End Sub

    Private Sub weaponstbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PlayerStatesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayerStatesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub
End Class