Public Class BlacksmithWindow

    Private Sub BlacksmithWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerGoldlbl.Text = currentPlayer.name & "'s gold"
        playerGoldtxt.Text = currentPlayer.gold

        BlacksmithStatesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.BlacksmithStates, currentState.id)

        Dim weapon As Weapon
        Dim armor As Armor
        If GameDatabaseDataSet.BlacksmithStates.Any And currentState.dateInGame = currentBlacksmithState.DateVisited Then
            currentBlacksmithState = New BlacksmithState(GameDatabaseDataSet.BlacksmithStates.Last)
            StaticWeaponsTableAdapter.FillByBlacksmithStateid(GameDatabaseDataSet.StaticWeapons, currentBlacksmithState.id)
            StaticArmorTableAdapter.FillByBlacksmithStateid(GameDatabaseDataSet.StaticArmor, currentBlacksmithState.id)
            BlacksmithStateItemsTableAdapter.FillByBlacksmithStateid(GameDatabaseDataSet.BlacksmithStateItems, currentBlacksmithState.id)
            For Each row As GameDatabaseDataSet.BlacksmithStateItemsRow In GameDatabaseDataSet.BlacksmithStateItems
                If IsDBNull(row("armorid")) Then
                    Dim staticWeaponsRow As GameDatabaseDataSet.StaticWeaponsRow = GameDatabaseDataSet.StaticWeapons.FindByid(row.weaponid)
                    weapon = New Weapon(staticWeaponsRow)
                    weapon.index = row.id
                    weaponslst.Items.Add(weapon.ToString)
                    currentBlacksmithState.weapons.Add(weapon, weapon.index)
                Else
                    Dim staticArmorRow As GameDatabaseDataSet.StaticArmorRow = GameDatabaseDataSet.StaticArmor.FindByid(row.armorid)
                    armor = New Armor(staticArmorRow)
                    armor.index = row.id
                    armorlst.Items.Add(armor.ToString)
                    currentBlacksmithState.armor.Add(armor, armor.index)
                End If
            Next
        Else
            NewBlacksmithState()
            StaticWeaponsTableAdapter.FillWithBlacksmithWeapons(GameDatabaseDataSet.StaticWeapons)
            StaticArmorTableAdapter.FillWithBlacksmithArmor(GameDatabaseDataSet.StaticArmor)
            For Each row As GameDatabaseDataSet.StaticWeaponsRow In GameDatabaseDataSet.StaticWeapons
                weapon = New Weapon(row)
                NewBlacksmithStateItem(weapon)
                weapon.index = GameDatabaseDataSet.BlacksmithStateItems.Last.id
                weaponslst.Items.Add(weapon.ToString)
                currentBlacksmithState.weapons.Add(weapon, weapon.index)
            Next
            For Each row As GameDatabaseDataSet.StaticArmorRow In GameDatabaseDataSet.StaticArmor
                armor = New Armor(row)
                NewBlacksmithStateItem(armor)
                armor.index = GameDatabaseDataSet.BlacksmithStateItems.Last.id
                armorlst.Items.Add(armor.ToString)
                currentBlacksmithState.armor.Add(armor, armor.index)
            Next
        End If
        weaponslst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        armorlst.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
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

    Private Sub weaponslst_Click(sender As Object, e As EventArgs) Handles weaponslst.Click
        If weaponslst.SelectedIndices.Count = 0 Then Exit Sub
        If weaponslst.SelectedIndices(0) = -1 Then Exit Sub

        Dim index As Integer = weaponslst.SelectedIndices(0)
        Dim currentWeapon As Weapon
        currentWeapon = currentBlacksmithState.weapons(index + 1)
        If currentPlayer.SpendGold(currentWeapon.cost) Then
            Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question
            Dim response = MsgBox(currentWeapon.DetailsString, style, "buy item?")
            If response = 6 Then
                BuyWeapon(currentWeapon)
                weaponslst.Items.RemoveAt(index)
                currentBlacksmithState.weapons.Remove(currentWeapon.index.ToString)
                RemoveBlacksmithStateItem(currentWeapon.index)
                playerGoldtxt.Text = currentPlayer.gold
            End If
        End If
    End Sub

    Private Sub armorlst_Click(sender As Object, e As EventArgs) Handles armorlst.Click
        If armorlst.SelectedIndices.Count = 0 Then Exit Sub
        If armorlst.SelectedIndices(0) = -1 Then Exit Sub

        Dim index As Integer = armorlst.SelectedIndices(0)
        Dim currentArmor As Armor
        currentArmor = currentBlacksmithState.armor(index + 1)
        If currentPlayer.SpendGold(currentArmor.cost) Then
            Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question
            Dim response = MsgBox(currentArmor.DetailsString, style, "buy item?")
            If response = 6 Then
                BuyArmor(currentArmor)
                armorlst.Items.RemoveAt(index)
                currentBlacksmithState.armor.Remove(currentArmor.index.ToString)
                RemoveBlacksmithStateItem(currentArmor.index)
                playerGoldtxt.Text = currentPlayer.gold
            End If
        End If
    End Sub

    Private Sub BuyWeapon(weapon As Weapon)
        Dim newRow As GameDatabaseDataSet.PlayerWeaponsRow = GameDatabaseDataSet.PlayerWeapons.NewPlayerWeaponsRow
        newRow.playerStateid = currentState.id
        newRow.weaponid = weapon.id
        newRow("wearerid") = DBNull.Value
        newRow("slotWorn") = DBNull.Value
        GameDatabaseDataSet.PlayerWeapons.Rows.Add(newRow)
        PlayerWeaponsBindingSource.EndEdit()
        PlayerWeaponsTableAdapter.Update(GameDatabaseDataSet.PlayerWeapons)
        Try
        Catch ex As Exception
            MsgBox("unable to add player weapon")
        End Try
    End Sub

    Private Sub BuyArmor(armor As Armor)
        Dim newRow As GameDatabaseDataSet.PlayerArmorRow = GameDatabaseDataSet.PlayerArmor.NewPlayerArmorRow
        newRow.playerStateid = currentState.id
        newRow.armorid = armor.id
        newRow("wearerid") = DBNull.Value
        newRow("slotWorn") = DBNull.Value
        GameDatabaseDataSet.PlayerArmor.Rows.Add(newRow)
        PlayerArmorBindingSource.EndEdit()
        PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
        Try
        Catch ex As Exception
            MsgBox("unable to add player armor")
        End Try
    End Sub

    Public Sub NewBlacksmithState()
        Dim newRow As GameDatabaseDataSet.BlacksmithStatesRow = GameDatabaseDataSet.BlacksmithStates.NewBlacksmithStatesRow
        newRow.playerStateid = currentState.id
        newRow.dateVisted = currentState.dateInGame
        GameDatabaseDataSet.BlacksmithStates.Rows.Add(newRow)
        Try
            BlacksmithStatesBindingSource.EndEdit()
            BlacksmithStatesTableAdapter.Update(GameDatabaseDataSet.BlacksmithStates)
            currentBlacksmithState = New BlacksmithState(GameDatabaseDataSet.BlacksmithStates.Last)
        Catch ex As Exception
            MsgBox("unable to add blacksmith state to database")
        End Try
    End Sub

    Private Sub NewBlacksmithStateItem(item As Item)
        Dim newRow As GameDatabaseDataSet.BlacksmithStateItemsRow = GameDatabaseDataSet.BlacksmithStateItems.NewBlacksmithStateItemsRow
        newRow.blacksmithStateid = currentBlacksmithState.id
        If item.GetType = (New Armor).GetType Then
            newRow.armorid = item.id
            newRow("weaponid") = DBNull.Value
        ElseIf item.GetType = (New Weapon).GetType Then
            newRow.weaponid = item.id
            newRow("armorid") = DBNull.Value
        End If
        newRow.cost = 1
        GameDatabaseDataSet.BlacksmithStateItems.Rows.Add(newRow)
        Try
            BlacksmithStateItemsBindingSource.EndEdit()
            BlacksmithStateItemsTableAdapter.Update(GameDatabaseDataSet.BlacksmithStateItems)
        Catch ex As Exception
            MsgBox("unable to add blacksmith state item")
        End Try
    End Sub

    Private Sub RemoveBlacksmithStateItem(index As Integer)
        GameDatabaseDataSet.BlacksmithStateItems.FindByid(index).Delete()
        BlacksmithStateItemsTableAdapter.Update(GameDatabaseDataSet.BlacksmithStateItems)
        Try
        Catch ex As Exception
            MsgBox("unable to remove blacksmith state item")
        End Try
    End Sub

    Private Sub CloseEventHandler(sender As Object, e As EventArgs) Handles Me.Closed
        'currentController.SaveState()
        'NewBlacksmithState()
    End Sub

End Class