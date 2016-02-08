Imports System
Imports System.IO
Imports System.Text

Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)

        For ctr = 1 To 4
            LoadCreatures(New creature("creature " & ctr))
        Next

        StartLog()  'From log.vb

        For Each row As DataRow In GameDatabaseDataSet.Players
            playerSelectlstv.Items.Add(New player(row("id"), row("name"), row("level"), row("experience"), row("gold")).level)
            playerSelectlstv.Items(playerSelectlstv.Items.Count - 1).SubItems.Add(row("name").ToString)
        Next
    End Sub

    Private Sub playerNewbtn_Click(sender As Object, e As EventArgs) Handles playerNewbtn.Click
        Dim nameString As String = InputBox("Enter a name.",, "name")
        If String.IsNullOrWhiteSpace(nameString) Then
            MsgBox("Name cannot be blank.")
            Exit Sub
        End If

        'Called from Names.vb
        'Converts any string into a proper-cased trimmed string
        nameString = ProperCase(nameString)

        Dim player As player = NewPlayer(nameString, 1, 1, 4)
        Try
            playerSelectlstv.Items.Add(player.level)
            playerSelectlstv.Items(playerSelectlstv.Items.Count - 1).SubItems.Add(player.name)
        Catch ex As Exception
            MsgBox("Unable to create new player.")
        End Try
    End Sub

    Private Sub playerSelectlstv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerSelectlstv.SelectedIndexChanged
        Dim row As DataRow = GameDatabaseDataSet.Players(playerSelectlstv.SelectedIndices(0))
        If Not playerSelectlstv.SelectedIndices(0) = -1 Then
            currentPlayer = New player(row("id"), row("name"), row("level"), row("experience"), row("gold"))
            currentTownWindow = New TownWindow
            currentTownWindow.Show()
            Me.Close()
        End If
    End Sub

    Private Function NewPlayer(name As String, level As Integer, experience As Integer, gold As Integer)
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

    Private Sub LoadCreatures(creature As creature)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("StaticCreatures").NewRow()

        newRow("name") = creature.name
        newRow("species") = creature.species
        newRow("class") = creature.job
        newRow("level") = creature.level
        newRow("experience") = creature.exp
        newRow("maxHealth") = creature.maxHP
        newRow("health") = creature.health
        newRow("strength") = creature.str
        newRow("armor") = creature.armor
        newRow("initiative") = creature.ini
        newRow("intelligence") = creature.int
        newRow("wisdom") = creature.wis
        newRow("dexterity") = creature.dex

        GameDatabaseDataSet.Tables("StaticCreatures").Rows.Add(newRow)

        Try
            Validate()
            StaticCreaturesBindingSource.EndEdit()
            StaticCreaturesTableAdapter.Update(GameDatabaseDataSet.StaticCreatures)
        Catch ex As Exception
            LogNewPlayer(newRow, False)  'from log.vb
            MsgBox("Failed to add player to database.")
        End Try
    End Sub

    Private Sub playerDeletebtn_Click(sender As Object, e As EventArgs) Handles playerDeletebtn.Click
        currentDeletePlayersWindow = New DeletePlayersWindow
        currentDeletePlayersWindow.Show()
        Me.Close()
    End Sub
End Class