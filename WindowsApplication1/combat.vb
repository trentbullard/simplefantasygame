Public Class AdventureWindow

    Private Sub AdventureWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ItemsTableAdapter.Fill(Me.GameDatabaseDataSet.Items)
        Me.CreaturesTableAdapter.Fill(Me.GameDatabaseDataSet.Creatures)
        Me.BattlesTableAdapter.Fill(Me.GameDatabaseDataSet.Battles)
        Me.AttacksTableAdapter.Fill(Me.GameDatabaseDataSet.Attacks)
        Me.ItemsTableAdapter.Fill(Me.GameDatabaseDataSet.Items)

        Me.Text = currentPlayer.level & " " & currentPlayer.name
        playerTeamlbl.Text = currentPlayer.name & "'s Team"
    End Sub

    'Called in the following cases:
    '1) The user clicks the Create button on the main window under either creature slot
    '2) A creature is killed by an attack
    '
    'First attempts to create a new record in the Creatures DataTable.
    'If this is successful, it uses that record (specifically the record Id)
    'to create a new Creature instance using the same attributes.
    Private Function NewCreature(name, species, health, strength, armor)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("Creatures").NewRow()

        newRow("name") = name
        newRow("species") = species
        newRow("health") = health
        newRow("strength") = strength
        newRow("armor") = armor

        GameDatabaseDataSet.Tables("Creatures").Rows.Add(newRow)

        'Attempts to update the database with the new row from the dataset.
        'If successful, a new Creature instance is created with the attributes
        'from the new database record.
        Try
            Validate()
            CreaturesBindingSource.EndEdit()
            CreaturesTableAdapter.Update(GameDatabaseDataSet.Creatures)
            newRow = CreaturesTableAdapter.GetLastRow().Select().First
            Return New creature(newRow("id"), name, species, health, strength, armor)
        Catch ex As Exception
            MsgBox("Failed to add creature to database.")
            Exit Function
        End Try
    End Function

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

    Private Sub player1Itemslst_SelectedIndexChanged(sender As Object, e As EventArgs) Handles player1Itemslst.SelectedIndexChanged
        currentItem = player1Itemslst.SelectedItem
    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        Dim oForm As New MainMenu
        oForm.Show()
        Me.Close()
    End Sub
End Class
