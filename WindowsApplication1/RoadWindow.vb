Public Class RoadWindow
    'Dim dateVisited As Date
    'Dim campChances(5) As Integer
    'Dim rowNames() As String = {"camp1Chance", "camp2Chance", "camp3Chance", "camp4Chance", "camp5Chance"}

    'Private Sub RoadWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    RoadStatesTableAdapter.FillByPlayerid(GameDatabaseDataSet.RoadStates, currentPlayer.id)
    '    PlayerStatesTableAdapter.FillByPlayerid(GameDatabaseDataSet.PlayerStates, currentPlayer.id)

    '    If RoadStatesTableAdapter.GetLastRoadStateByPlayerStateid(currentPlayer.id).Any Then
    '        Dim row As DataRow = RoadStatesTableAdapter.GetLastRoadStateByPlayerStateid(currentPlayer.id).First
    '        For ctr = 0 To 4
    '            If currentState.isAmbushed Then
    '                campChances(ctr) = 100
    '            Else
    '                campChances(ctr) = row(rowNames(ctr))
    '            End If
    '        Next
    '    Else
    '        dateVisited = currentState.dateInGame
    '        For ctr = 0 To 4
    '            campChances(ctr) = Roll(5) * 5
    '        Next
    '    End If
    '    camp1Chanceslbl.Text = campChances(0) & "% chance for ambush"
    '    camp2Chanceslbl.Text = campChances(1) & "% chance for ambush"
    '    camp3Chanceslbl.Text = campChances(2) & "% chance for ambush"
    '    camp4Chanceslbl.Text = campChances(3) & "% chance for ambush"
    '    camp5Chanceslbl.Text = campChances(4) & "% chance for ambush"
    '    NewRoadState()
    'End Sub

    'Private Sub camp1btn_Click(sender As Object, e As EventArgs) Handles camp1btn.Click
    '    If Roll(100) <= campChances(0) Then
    '        currentState.isAmbushed = True
    '    End If
    'End Sub

    'Private Sub camp2btn_Click(sender As Object, e As EventArgs) Handles camp2btn.Click
    '    If Roll(100) <= campChances(1) Then
    '        currentState.isAmbushed = True
    '    End If
    'End Sub

    'Private Sub camp3btn_Click(sender As Object, e As EventArgs) Handles camp3btn.Click
    '    If Roll(100) <= campChances(2) Then
    '        currentState.isAmbushed = True
    '    End If
    'End Sub

    'Private Sub camp4btn_Click(sender As Object, e As EventArgs) Handles camp4btn.Click
    '    If Roll(100) <= campChances(3) Then
    '        currentState.isAmbushed = True
    '    End If
    'End Sub

    'Private Sub camp5btn_Click(sender As Object, e As EventArgs) Handles camp5btn.Click
    '    If Roll(100) <= campChances(4) Then
    '        currentState.isAmbushed = True
    '    End If
    'End Sub

    'Private Sub NewRoadState()
    '    Dim newRow As DataRow = GameDatabaseDataSet.Tables("RoadStates").NewRow()
    '    newRow("dateVisited") = dateVisited
    '    newRow("playerStateid") = currentState.id
    '    newRow("camp1Chance") = campChances(0)
    '    newRow("camp2Chance") = campChances(1)
    '    newRow("camp3Chance") = campChances(2)
    '    newRow("camp4Chance") = campChances(3)
    '    newRow("camp5Chance") = campChances(4)
    '    GameDatabaseDataSet.Tables("RoadStates").Rows.Add(newRow)
    '    Try
    '        Validate()
    '        RoadStatesBindingSource.EndEdit()
    '        RoadStatesTableAdapter.Update(GameDatabaseDataSet.RoadStates)
    '    Catch ex As Exception
    '        MsgBox("unable to add road state to database")
    '    End Try
    'End Sub

    'Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
    '    OpenMainMenu()
    'End Sub

    'Private Sub playerbtn_Click(sender As Object, e As EventArgs) Handles playerbtn.Click
    '    currentState.playerwindow = New PlayerWindow
    '    currentState.playerwindow.Show()
    'End Sub

    'Private Sub townbtn_Click(sender As Object, e As EventArgs) Handles townbtn.Click
    '    currentState.townwindow = New TownWindow
    '    currentState.townwindow.Show()
    'End Sub
End Class