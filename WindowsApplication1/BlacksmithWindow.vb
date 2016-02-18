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
        weaponslst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        armorlst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

        Dim allWeapons As New Collection
        Dim allArmor As New Collection
        Dim weapon As Weapon
        Dim armor As Armor
        If BlacksmithStatesTableAdapter.GetLastRow.Any Then
            For Each row As GameDatabaseDataSet.BlacksmithStateItemsRow In BlacksmithStateItemsTableAdapter.GetBlacksmithItemsByBlacksmithStateid(BlacksmithStatesTableAdapter.GetLastRow.First.id)
                If IsDBNull(row("armorid")) Then
                    weapon = New Weapon(StaticWeaponsTableAdapter.GetWeaponByid(row.id).First)
                    allWeapons.Add(weapon, weapon.id)
                    weaponslst.Items.Add(weapon.ToString)
                Else
                    armor = New Armor(StaticArmorTableAdapter.GetArmorByid(row.id).First)
                    allArmor.Add(armor, armor.id)
                    armorlst.Items.Add(armor.ToString)
                End If
            Next
        Else
            NewBlacksmithState()
            For ctr = 1 To 20
                weapon = New Weapon
                weapon.Save(GameDatabaseDataSet, StaticWeaponsBindingSource, StaticWeaponsTableAdapter)
                weapon = New Weapon(StaticWeaponsTableAdapter.GetLastRow.First)
                allWeapons.Add(weapon, weapon.id)
                AddBlacksmithItem(weapon)
                weaponslst.Items.Add(weapon.ToString)
                armor = New Armor
                armor.Save(GameDatabaseDataSet, StaticArmorBindingSource, StaticArmorTableAdapter)
                armor = New Armor(StaticArmorTableAdapter.GetLastRow.First)
                allArmor.Add(armor, armor.id)
                AddBlacksmithItem(armor)
                armorlst.Items.Add(armor.ToString)
            Next
        End If
    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        OpenMainMenu()
    End Sub

    Private Sub playerbtn_Click(sender As Object, e As EventArgs) Handles playerbtn.Click
        currentState.playerwindow = New PlayerWindow
        currentState.playerwindow.Show()
    End Sub

    Private Sub marketbtn_Click(sender As Object, e As EventArgs) Handles marketbtn.Click
        currentState.marketwindow = New MarketWindow
        currentState.marketwindow.Show()
        Me.Close()
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
        GameDatabaseDataSet.BlacksmithStateItems.Rows.Add(newRow)
        Try
            BlacksmithStateItemsBindingSource.EndEdit()
            BlacksmithStateItemsTableAdapter.Update(GameDatabaseDataSet.BlacksmithStateItems)
        Catch ex As Exception
            MsgBox("unable to add blacksmith state item to database")
        End Try
    End Sub

    Private Sub NewBlacksmithState()
        Dim newRow As GameDatabaseDataSet.BlacksmithStatesRow = GameDatabaseDataSet.BlacksmithStates.NewRow()
        newRow.playerStateid = currentState.id
        newRow.dateVisted = currentState.dateInGame
        GameDatabaseDataSet.BlacksmithStates.Rows.Add(newRow)
        Try
            BlacksmithStatesBindingSource.EndEdit()
            BlacksmithStatesTableAdapter.Update(GameDatabaseDataSet.BlacksmithStates)
        Catch ex As Exception
            MsgBox("unable to add blacksmith state to database")
        End Try
    End Sub
End Class