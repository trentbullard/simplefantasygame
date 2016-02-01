Public Class CombatWindow

    Private Sub CombatWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.GameDatabaseDataSet.Items)
        Me.CreaturesTableAdapter.Fill(Me.GameDatabaseDataSet.Creatures)
        Me.BattlesTableAdapter.Fill(Me.GameDatabaseDataSet.Battles)
        Me.AttacksTableAdapter.Fill(Me.GameDatabaseDataSet.Attacks)
        Me.ItemsTableAdapter.Fill(Me.GameDatabaseDataSet.Items)

        Me.Text = "Simple Fantasy Game - Level " & currentPlayer.level & " " & currentPlayer.name
        playerTeamlbl.Text = currentPlayer.name & "'s Team"

        If CreaturesTableAdapter.GetRowsByPlayer(currentPlayer.id).Any Then
            tavernlbl.Hide()
            For Each row In CreaturesTableAdapter.GetRowsByPlayer(currentPlayer.id)
                hireListlst.Items.Add(New creature(row))
            Next
        End If
    End Sub

    'Called in the following cases:
    '1) The user clicks the Create button on the main window under either creature slot
    '2) A creature is killed by an attack
    '
    'First attempts to create a new record in the Creatures DataTable.
    'If this is successful, it uses that record (specifically the record Id)
    'to create a new Creature instance using the same attributes.
    Private Sub NewCreature(name, species, health, strength, armor, level, exp, owner)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("Creatures").NewRow()

        newRow("name") = name
        newRow("species") = species
        newRow("health") = health
        newRow("strength") = strength
        newRow("armor") = armor
        newRow("level") = level
        newRow("experience") = exp
        newRow("playerid") = owner.id

        GameDatabaseDataSet.Tables("Creatures").Rows.Add(newRow)

        'Attempts to update the database with the new row from the dataset.
        'If successful, a new Creature instance is created with the attributes
        'from the new database record.
        Try
            Validate()
            CreaturesBindingSource.EndEdit()
            CreaturesTableAdapter.Update(GameDatabaseDataSet.Creatures)
        Catch ex As Exception
            MsgBox("Failed to add creature to database.")
        End Try
    End Sub

    'Called in the following cases:
    ' 1) By NewAttack() from this document at first run of program when 
    '   the first attack is created if battleActive is false (default until changed
    '   by this function
    ' 2) By AttackResult() from this document in the event of a new creature
    '   replacing a killed creature.
    ' 3) New creature created by user after first battle
    '
    'First attempts to create a new record in the Battles DataTable.
    'If this is successful, it uses that record (specifically the record Id)
    'to create a new Battle instance using the same attributes.
    Private Sub NewBattle(creature1, creature2)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("Battles").NewRow()

        newRow("creature1") = creature1.id
        newRow("creature2") = creature2.id

        GameDatabaseDataSet.Tables("Battles").Rows.Add(newRow)

        'Attempts to update the database with the new row from the dataset.
        'If successful, a new instance of Battle is created
        'using the new record's attributes. Then battleActive is set to True.
        Try
            Validate()
            BattlesBindingSource.EndEdit()
            BattlesTableAdapter.Update(GameDatabaseDataSet.Battles)
            newRow = BattlesTableAdapter.GetLastRow().Select().First
            currentBattle = New battle(newRow("Id"), creature1, creature2)
            battleActive = True
            LogBattle(newRow, True)  'from log.vb
        Catch ex As Exception
            LogBattle(newRow, False)  'from log.vb
            MsgBox("Failed to add battle to database.")
        End Try
    End Sub

    'Called in the following cases:
    ' 1) User clicking Attack button on main window
    '
    'First attempts to create a new record in the Attacks DataTable.
    'If this is successful, it uses that record (specifically the record Id)
    'to create a new Attack instance using the same attributes.
    Private Sub NewAttack(attack)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("Attacks").NewRow()

        If Not battleActive Then
            NewBattle(currentCreature(1), currentCreature(2))
        End If

        newRow("aggressor") = attack.aggressor.id
        newRow("victim") = attack.victim.id
        newRow("damage") = attack.damage
        newRow("battle") = currentBattle.id

        GameDatabaseDataSet.Tables("Attacks").Rows.Add(newRow)

        'Attempts to update the database with the new row from the dataset.
        'If successful, a new instance of Battle is created using 
        'the new record's attributes. Then the attack is sent to the
        'AttackResult() function in this document.
        Try
            Validate()
            AttacksBindingSource.EndEdit()
            AttacksTableAdapter.Update(GameDatabaseDataSet.Attacks)
            newRow = AttacksTableAdapter.GetLastRow().Select().First
            LogAttack(newRow, True)  'from log.vb
        Catch ex As Exception
            LogAttack(newRow, False)  'from log.vb
            MsgBox("Failed to add attack to database.")
        End Try
    End Sub

    Private Sub player1Itemslst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerItemslst.SelectedIndexChanged
        currentItem = playerItemslst.SelectedItem
    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        Dim oForm As New MainMenu
        oForm.Show()
        Me.Close()
    End Sub

    Private Sub tavernbtn_Click(sender As Object, e As EventArgs) Handles tavernbtn.Click
        currentTavernWindow = New TavernWindow
        currentTavernWindow.Show()
    End Sub
End Class
