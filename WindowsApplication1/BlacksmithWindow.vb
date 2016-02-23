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
            For Each row As GameDatabaseDataSet.StaticWeaponsRow In GameDatabaseDataSet.StaticWeapons
                Weapon = New Weapon(row)
                weaponslst.Items.Add(Weapon.id.ToString, Weapon.ToString, 0)
                currentBlacksmithState.weapons.Add(Weapon)
            Next
            For Each row As GameDatabaseDataSet.StaticArmorRow In GameDatabaseDataSet.StaticArmor
                Armor = New Armor(row)
                armorlst.Items.Add(Armor.id.ToString, Armor.ToString, 0)
                currentBlacksmithState.armor.Add(Armor)
            Next
        Else
            NewBlacksmithState()
            StaticWeaponsTableAdapter.FillWithBlacksmithWeapons(GameDatabaseDataSet.StaticWeapons)
            StaticArmorTableAdapter.FillWithBlacksmithArmor(GameDatabaseDataSet.StaticArmor)
            For Each row As GameDatabaseDataSet.StaticWeaponsRow In GameDatabaseDataSet.StaticWeapons
                weapon = New Weapon(row)
                NewBlacksmithStateItem(weapon)
                weaponslst.Items.Add(weapon.id.ToString, weapon.ToString, 0)
                currentBlacksmithState.weapons.Add(Weapon)
            Next
            For Each row As GameDatabaseDataSet.StaticArmorRow In GameDatabaseDataSet.StaticArmor
                armor = New Armor(row)
                NewBlacksmithStateItem(armor)
                armorlst.Items.Add(armor.id.ToString, armor.ToString, 0)
                currentBlacksmithState.armor.Add(Armor)
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

    Private Sub weaponslst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles weaponslst.SelectedIndexChanged
        If weaponslst.SelectedItems.Count > 0 Then
            If Not weaponslst.SelectedIndices(0) = -1 Then
                Dim currentWeapon As Weapon
                currentWeapon = currentBlacksmithState.weapons(weaponslst.SelectedIndices(0) + 1)
                MsgBox(currentWeapon.DetailsString)
            End If
        End If
    End Sub

    Private Sub armorlst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles armorlst.SelectedIndexChanged
        If armorlst.SelectedItems.Count > 0 Then
            If Not armorlst.SelectedIndices(0) = -1 Then
                Dim currentArmor As Armor
                currentArmor = currentBlacksmithState.armor(armorlst.SelectedIndices(0) + 1)
                MsgBox(currentArmor.DetailsString)
            End If
        End If
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

    Private Sub CloseEventHandler(sender As Object, e As EventArgs) Handles Me.Closed
        'currentController.SaveState()
        'NewBlacksmithState()
    End Sub

End Class