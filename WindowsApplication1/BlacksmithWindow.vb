Public Class BlacksmithWindow
    Private currentBlacksmithState As BlacksmithState

    Private Sub BlacksmithWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerGoldlbl.Text = currentPlayer.name & "'s gold"
        playerGoldtxt.Text = currentPlayer.gold

        BlacksmithStatesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.BlacksmithStates, currentState.id)

        If GameDatabaseDataSet.BlacksmithStates.Any Then
            currentBlacksmithState = New BlacksmithState(GameDatabaseDataSet.BlacksmithStates.Last)
            StaticWeaponsTableAdapter.FillByBlacksmithStateid(GameDatabaseDataSet.StaticWeapons, currentBlacksmithState.id)
            StaticArmorTableAdapter.FillByBlacksmithStateid(GameDatabaseDataSet.StaticArmor, currentBlacksmithState.id)
            For Each row As GameDatabaseDataSet.StaticWeaponsRow In GameDatabaseDataSet.StaticWeapons

            Next
            For Each row As GameDatabaseDataSet.StaticArmorRow In GameDatabaseDataSet.StaticArmor

            Next
        Else
            NewBlacksmithState()
            StaticWeaponsTableAdapter.Fill(GameDatabaseDataSet.StaticWeapons)
            StaticArmorTableAdapter.Fill(GameDatabaseDataSet.StaticArmor)
            Dim allWeapons As New Collection
            Dim allArmor As New Collection
            Dim weapon As Weapon
            Dim armor As Armor
            For ctr = 1 To 20
                weapon = New Weapon(GameDatabaseDataSet.StaticWeapons.FindByid(ctr))
                NewBlacksmithStateItem(weapon)
                weaponslst.Items.Add(weapon.ToString)
                allWeapons.Add(weapon)
                armor = New Armor(GameDatabaseDataSet.StaticArmor.FindByid(ctr))
                NewBlacksmithStateItem(armor)
                armorlst.Items.Add(armor.ToString)
                allArmor.Add(armor)
            Next
            currentBlacksmithState.weapons = allWeapons
            currentBlacksmithState.armor = allArmor
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
        currentController.SaveState()
        NewBlacksmithState()
    End Sub
End Class