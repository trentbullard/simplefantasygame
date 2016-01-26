Imports System
Imports System.IO
Imports System.Text

Public Class MainMenu
    Public nameString As String

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartLog()  'From log.vb

        For Each row As DataRow In GameDatabaseDataSet.Players
            playerSelectionlst.Items.Add(New player(row("id"), row("name"), row("level"), row("experience"), row("gold")))
        Next
    End Sub

    Private Sub playerNewbtn_Click(sender As Object, e As EventArgs) Handles playerNewbtn.Click
        nameString = InputBox("Enter a name.",, "name")
        playerSelectionlst.Items.Add(NewPlayer(nameString, 1, 0, -0))
    End Sub

    Private Sub playerSelectionlst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerSelectionlst.SelectedIndexChanged
        currentPlayer = playerSelectionlst.SelectedItem
        Dim oForm As New AdventureWindow
        oForm.Show()
        Me.Close()
    End Sub

    Private Function NewPlayer(name, level, experience, gold)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("Players").NewRow()

        newRow("name") = name
        newRow("level") = level
        newRow("experience") = experience
        newRow("gold") = gold

        GameDatabaseDataSet.Tables("Players").Rows.Add(newRow)

        'Attempts to update the database with the new row from the dataset.
        'If successful, a new Player instance is created with the attributes
        'from the new database record.
        Try
            Validate()
            PlayersBindingSource.EndEdit()
            PlayersTableAdapter.Update(GameDatabaseDataSet.Players)
            newRow = PlayersTableAdapter.GetLastRow().Select().First
            LogNewPlayer(newRow, True)  'from log.vb
            Return New player(newRow("id"), name, level, experience, gold)
        Catch ex As Exception
            LogNewPlayer(newRow, False)  'from log.vb
            MsgBox("Failed to add player to database.")
        Exit Function
        End Try
    End Function
End Class