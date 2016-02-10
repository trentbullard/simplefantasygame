Imports System
Imports System.IO
Imports System.Text

Public Class MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        PlayersTableAdapter.Fill(GameDatabaseDataSet.Players)

        For ctr = 1 To 50
            LoadCreatures(New creature("creature " & ctr))
        Next

        StartLog()  'From log.vb

        For Each row As DataRow In GameDatabaseDataSet.Players
            playerSelectlstv.Items.Add(New player(row).level)
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

        Dim player As New player(nameString)
        NewPlayer(player)
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
            currentPlayer = New player(row("id"), row("name"), row("level"), row("experience"), row("gold"), testPlayer.currentDate)
            currentTownWindow = New TownWindow
            currentTownWindow.Show()
            Me.Close()
        End If
    End Sub

    Private Sub NewPlayer(player As player)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("Players").NewRow()

        newRow("name") = player.name
        newRow("level") = player.level
        newRow("experience") = player.exp
        newRow("gold") = player.gold

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
        Catch ex As Exception
            LogNewPlayer(newRow, False)  'from log.vb
            MsgBox("Failed to add player to database.")
        End Try
    End Sub

    Private Sub LoadCreatures(creature As creature)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("StaticCreatures").NewRow()

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

    Private Sub PlayersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub
End Class