Public Class BlacksmithWindow
    Private Sub BlacksmithWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BlacksmithStatesTableAdapter.FillByPlayerid(GameDatabaseDataSet.BlacksmithStates, currentPlayer.id)
        BlacksmithStateItemsTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.BlacksmithStateItems, currentState.id)
        StaticWeaponsTableAdapter.FillWithBlacksmithWeapons(GameDatabaseDataSet.StaticWeapons)
        StaticArmorTableAdapter.FillWithBlacksmithArmor(GameDatabaseDataSet.StaticArmor)
        'StaticAugmentsTableAdapter.Fill(GameDatabaseDataSet.StaticAugments)
        'WeaponAugmentsTableAdapter.FillByPlayerid(GameDatabaseDataSet.WeaponAugments, currentPlayer.id)
        'ArmorAugmentsTableAdapter.FillByPlayerid(GameDatabaseDataSet.ArmorAugments, currentPlayer.id)
        'PlayersTableAdapter.FillByPlayerid(GameDatabaseDataSet.Players, currentPlayer.id)
        'PlayerStatesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerStates, currentPlayer.id)
        'PlayerWeaponsTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerWeapons, currentPlayer.id)
        'PlayerArmorTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerArmor, currentPlayer.id)

        playerGoldlbl.Text = currentPlayer.name & "'s gold"
        playerGoldtxt.Text = currentPlayer.gold

        Dim allWeapons As New Collection
        Dim allArmor As New Collection
        If BlacksmithStatesTableAdapter.GetLastRow.Any Then
            Dim weapon As Weapon
            Dim armor As Armor
            For Each row As GameDatabaseDataSet.BlacksmithStateItemsRow In BlacksmithStateItemsTableAdapter.GetBlacksmithItemsByBlacksmithStateid(BlacksmithStatesTableAdapter.GetLastRow.First.id)
                If IsDBNull(row("armorid")) Then
                    weapon = New Weapon(StaticWeaponsTableAdapter.GetWeaponByid(row.id).First)
                    allWeapons.Add(weapon, weapon.id)
                    weaponslst.Items.Add(weapon.ToString)
                Else
                    armor = New Armor(StaticArmorTableAdapter.GetArmorByid(row.id).First)
                    allArmor.Add(armor, armor.id)
                    armorlst.Items.Add(armor.ToString)
                    AddBlacksmithItem(armor)
                End If
            Next
        Else
            For ctr = 1 To 20
                Dim weapon As New Weapon
                weapon.Save(GameDatabaseDataSet, StaticWeaponsBindingSource, StaticWeaponsTableAdapter)
                weapon = New Weapon(StaticWeaponsTableAdapter.GetLastRow.First)
                allWeapons.Add(weapon, weapon.id)
                AddBlacksmithItem(weapon)
                Dim armor As New Armor
                armor.Save(GameDatabaseDataSet, StaticArmorBindingSource, StaticArmorTableAdapter)
                allArmor.Add(armor, armor.id)
                AddBlacksmithItem(armor)
            Next
        End If
    End Sub

    Private Sub weaponstbl_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub AddBlacksmithItem(item As Item)
        Dim newRow As GameDatabaseDataSet.BlacksmithStateItemsRow = GameDatabaseDataSet.BlacksmithStateItems.NewRow()
        newRow.blacksmithStateid = BlacksmithStatesTableAdapter.GetLastRow.First.id
        If item.GetType = (New Armor).GetType Then
            newRow.armorid = item.id
            newRow("weaponid") = DBNull.Value
        ElseIf item.GetType = (New Weapon).GetType Then
            newRow.weaponid = item.id
            newRow("armorid") = DBNull.Value
        End If
        newRow.cost = item.cost
    End Sub
End Class