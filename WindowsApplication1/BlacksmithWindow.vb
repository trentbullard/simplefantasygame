Public Class BlacksmithWindow
    Private Sub BlacksmithWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        playerGoldlbl.Text = currentPlayer.name & "'s gold"
        playerGoldtxt.Text = currentPlayer.gold





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

    Private Sub AddBlacksmithItem(item As Item)

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