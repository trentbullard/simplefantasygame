Public Class TavernWindow
    Private tavernCreatures(4) As creature

    Private Sub TavernWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.Creatures' table. You can move, or remove it, as needed.
        Me.CreaturesTableAdapter.Fill(Me.GameDatabaseDataSet.Creatures)
        currentTavernWindow = Me

        For ctr = 1 To 4
            tavernCreatures(ctr) = New creature("creature " & ctr)
            FillCreatureSlot(tavernCreatures(ctr), ctr)
        Next

    End Sub

    Private Sub tavernSlot1Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot1Hirebtn.Click
        NewCreature(tavernCreatures(1))
        currentCombatWindow.hireListlst.Items.Add(New creature(CreaturesTableAdapter.GetLastRow().First))
        ClearCreatureSlot(1)
    End Sub

    Private Sub tavernSlot2Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot2Hirebtn.Click
        NewCreature(tavernCreatures(2))
        currentCombatWindow.hireListlst.Items.Add(New creature(CreaturesTableAdapter.GetLastRow().First))
        ClearCreatureSlot(2)
    End Sub

    Private Sub tavernSlot3Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot3Hirebtn.Click
        NewCreature(tavernCreatures(3))
        currentCombatWindow.hireListlst.Items.Add(New creature(CreaturesTableAdapter.GetLastRow().First))
        ClearCreatureSlot(3)
    End Sub

    Private Sub tavernSlot4Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot4Hirebtn.Click
        NewCreature(tavernCreatures(4))
        currentCombatWindow.hireListlst.Items.Add(New creature(CreaturesTableAdapter.GetLastRow().First))
        ClearCreatureSlot(4)
    End Sub

    Private Sub NewCreature(creature)
        Dim newRow As DataRow = GameDatabaseDataSet.Tables("Creatures").NewRow()

        newRow("name") = creature.name
        newRow("species") = creature.species
        newRow("health") = creature.health
        newRow("strength") = creature.strength
        newRow("armor") = creature.armor
        newRow("level") = creature.level
        newRow("experience") = creature.exp
        newRow("playerid") = creature.owner.id

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

    Private Sub FillCreatureSlot(creature, slot)
        Select Case slot
            Case 1
                tavernSlot1Nametxt.Text = creature.name
                tavernSlot1Speciestxt.Text = creature.species
                tavernSlot1Healthtxt.Text = creature.health
                tavernSlot1Strengthtxt.Text = creature.strength
                tavernSlot1Armortxt.Text = creature.armor
            Case 2
                tavernSlot2Nametxt.Text = creature.name
                tavernSlot2Speciestxt.Text = creature.species
                tavernSlot2Healthtxt.Text = creature.health
                tavernSlot2Strengthtxt.Text = creature.strength
                tavernSlot2Armortxt.Text = creature.armor
            Case 3
                tavernSlot3Nametxt.Text = creature.name
                tavernSlot3Speciestxt.Text = creature.species
                tavernSlot3Healthtxt.Text = creature.health
                tavernSlot3Strengthtxt.Text = creature.strength
                tavernSlot3Armortxt.Text = creature.armor
            Case 4
                tavernSlot4Nametxt.Text = creature.name
                tavernSlot4Speciestxt.Text = creature.species
                tavernSlot4Healthtxt.Text = creature.health
                tavernSlot4Strengthtxt.Text = creature.strength
                tavernSlot4Armortxt.Text = creature.armor
        End Select
    End Sub

    Private Sub ClearCreatureSlot(slot)
        Select Case slot
            Case 1
                tavernSlot1Nametxt.Clear()
                tavernSlot1Speciestxt.Clear()
                tavernSlot1Healthtxt.Clear()
                tavernSlot1Strengthtxt.Clear()
                tavernSlot1Armortxt.Clear()
            Case 2
                tavernSlot2Nametxt.Clear()
                tavernSlot2Speciestxt.Clear()
                tavernSlot2Healthtxt.Clear()
                tavernSlot2Strengthtxt.Clear()
                tavernSlot2Armortxt.Clear()
            Case 3
                tavernSlot3Nametxt.Clear()
                tavernSlot3Speciestxt.Clear()
                tavernSlot3Healthtxt.Clear()
                tavernSlot3Strengthtxt.Clear()
                tavernSlot3Armortxt.Clear()
            Case 4
                tavernSlot4Nametxt.Clear()
                tavernSlot4Speciestxt.Clear()
                tavernSlot4Healthtxt.Clear()
                tavernSlot4Strengthtxt.Clear()
                tavernSlot4Armortxt.Clear()
        End Select
    End Sub
End Class