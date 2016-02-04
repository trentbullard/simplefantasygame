Public Class TavernWindow
    Private tavernCreatures(4) As creature

    Private Sub TavernWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StaticCreaturesTableAdapter.Fill(Me.GameDatabaseDataSet.StaticCreatures)
        currentTavernWindow = Me

        For ctr = 1 To 4
            tavernCreatures(ctr) = New creature("creature " & ctr)
            FillCreatureSlot(tavernCreatures(ctr), ctr)
        Next
    End Sub

    Private Sub tavernSlot1Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot1Hirebtn.Click
        'NewCreature(tavernCreatures(1))
        'currentCombatWindow.hireListlst.Items.Add(New creature(CreaturesTableAdapter.GetLastRow().First))
        'ClearCreatureSlot(1)
    End Sub

    Private Sub tavernSlot2Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot2Hirebtn.Click
        'NewCreature(tavernCreatures(2))
        'currentCombatWindow.hireListlst.Items.Add(New creature(CreaturesTableAdapter.GetLastRow().First))
        'ClearCreatureSlot(2)
    End Sub

    Private Sub tavernSlot3Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot3Hirebtn.Click
        'NewCreature(tavernCreatures(3))
        'currentCombatWindow.hireListlst.Items.Add(New creature(CreaturesTableAdapter.GetLastRow().First))
        'ClearCreatureSlot(3)
    End Sub

    Private Sub tavernSlot4Hirebtn_Click(sender As Object, e As EventArgs) Handles tavernSlot4Hirebtn.Click
        'NewCreature(tavernCreatures(4))
        'currentCombatWindow.hireListlst.Items.Add(New creature(CreaturesTableAdapter.GetLastRow().First))
        'ClearCreatureSlot(4)
    End Sub

    'Private Sub NewCreature(creature)
    '    Dim newRow As DataRow = GameDatabaseDataSet.Tables("StaticCreatures").NewRow()

    '    newRow("name") = creature.name
    '    newRow("species") = creature.species
    '    newRow("health") = creature.health
    '    newRow("strength") = creature.str
    '    newRow("armor") = creature.armor
    '    newRow("level") = creature.level
    '    newRow("experience") = creature.exp
    '    newRow("playerid") = creature.owner.id
    '    newRow("initiative") = creature.ini
    '    newRow("intelligence") = creature.int
    '    newRow("wisdom") = creature.wis
    '    newRow("dexterity") = creature.dex

    '    GameDatabaseDataSet.Tables("Creatures").Rows.Add(newRow)

    '    'Attempts to update the database with the new row from the dataset.
    '    'If successful, a new Creature instance is created with the attributes
    '    'from the new database record.
    '    Try
    '        Validate()
    '        CreaturesBindingSource.EndEdit()
    '        CreaturesTableAdapter.Update(GameDatabaseDataSet.Creatures)
    '    Catch ex As Exception
    '        MsgBox("Failed to add creature to database.")
    '    End Try
    'End Sub

    Private Sub FillCreatureSlot(creature, slot)
        Select Case slot
            Case 1
                tavernSlot1Nametxt.Text = creature.name
                tavernSlot1Leveltxt.Text = creature.level
                tavernSlot1Speciestxt.Text = creature.species
                tavernSlot1Healthtxt.Text = creature.health
                tavernSlot1Strengthtxt.Text = creature.str
                tavernSlot1Armortxt.Text = creature.armor
                tavernSlot1Initiativetxt.Text = creature.ini
                tavernSlot1Intelligencetxt.Text = creature.int
                tavernSlot1Wisdomtxt.Text = creature.wis
                tavernSlot1Dexteritytxt.Text = creature.dex
                tavernSlot1Hirebtn.Text = "hire for " & creature.level & " gold"
            Case 2
                tavernSlot2Nametxt.Text = creature.name
                tavernSlot2Leveltxt.Text = creature.level
                tavernSlot2Speciestxt.Text = creature.species
                tavernSlot2Healthtxt.Text = creature.health
                tavernSlot2Strengthtxt.Text = creature.str
                tavernSlot2Armortxt.Text = creature.armor
                tavernSlot2Initiativetxt.Text = creature.ini
                tavernSlot2Intelligencetxt.Text = creature.int
                tavernSlot2Wisdomtxt.Text = creature.wis
                tavernSlot2Dexteritytxt.Text = creature.dex
                tavernSlot2Hirebtn.Text = "hire for " & creature.level & " gold"
            Case 3
                tavernSlot3Nametxt.Text = creature.name
                tavernSlot3Leveltxt.Text = creature.level
                tavernSlot3Speciestxt.Text = creature.species
                tavernSlot3Healthtxt.Text = creature.health
                tavernSlot3Strengthtxt.Text = creature.str
                tavernSlot3Armortxt.Text = creature.armor
                tavernSlot3Initiativetxt.Text = creature.ini
                tavernSlot3Intelligencetxt.Text = creature.int
                tavernSlot3Wisdomtxt.Text = creature.wis
                tavernSlot3Dexteritytxt.Text = creature.dex
                tavernSlot3Hirebtn.Text = "hire for " & creature.level & " gold"
            Case 4
                tavernSlot4Nametxt.Text = creature.name
                tavernSlot4Leveltxt.Text = creature.level
                tavernSlot4Speciestxt.Text = creature.species
                tavernSlot4Healthtxt.Text = creature.health
                tavernSlot4Strengthtxt.Text = creature.str
                tavernSlot4Armortxt.Text = creature.armor
                tavernSlot4Initiativetxt.Text = creature.ini
                tavernSlot4Intelligencetxt.Text = creature.int
                tavernSlot4Wisdomtxt.Text = creature.wis
                tavernSlot4Dexteritytxt.Text = creature.dex
                tavernSlot4Hirebtn.Text = "hire for " & creature.level & " gold"
        End Select
    End Sub

    Private Sub ClearCreatureSlot(slot)
        Select Case slot
            Case 1
                tavernSlot1Nametxt.Clear()
                tavernSlot1Leveltxt.Clear()
                tavernSlot1Speciestxt.Clear()
                tavernSlot1Healthtxt.Clear()
                tavernSlot1Strengthtxt.Clear()
                tavernSlot1Armortxt.Clear()
                tavernSlot1Initiativetxt.Clear()
                tavernSlot1Intelligencetxt.Clear()
                tavernSlot1Wisdomtxt.Clear()
                tavernSlot1Dexteritytxt.Clear()
                tavernSlot1Hirebtn.Text = ""
            Case 2
                tavernSlot2Nametxt.Clear()
                tavernSlot2Leveltxt.Clear()
                tavernSlot2Speciestxt.Clear()
                tavernSlot2Healthtxt.Clear()
                tavernSlot2Strengthtxt.Clear()
                tavernSlot2Armortxt.Clear()
                tavernSlot2Initiativetxt.Clear()
                tavernSlot2Intelligencetxt.Clear()
                tavernSlot2Wisdomtxt.Clear()
                tavernSlot2Dexteritytxt.Clear()
                tavernSlot2Hirebtn.Text = ""
            Case 3
                tavernSlot3Nametxt.Clear()
                tavernSlot3Leveltxt.Clear()
                tavernSlot3Speciestxt.Clear()
                tavernSlot3Healthtxt.Clear()
                tavernSlot3Strengthtxt.Clear()
                tavernSlot3Armortxt.Clear()
                tavernSlot3Initiativetxt.Clear()
                tavernSlot3Intelligencetxt.Clear()
                tavernSlot3Wisdomtxt.Clear()
                tavernSlot3Dexteritytxt.Clear()
                tavernSlot3Hirebtn.Text = ""
            Case 4
                tavernSlot4Nametxt.Clear()
                tavernSlot4Leveltxt.Clear()
                tavernSlot4Speciestxt.Clear()
                tavernSlot4Healthtxt.Clear()
                tavernSlot4Strengthtxt.Clear()
                tavernSlot4Armortxt.Clear()
                tavernSlot4Initiativetxt.Clear()
                tavernSlot4Intelligencetxt.Clear()
                tavernSlot4Wisdomtxt.Clear()
                tavernSlot4Dexteritytxt.Clear()
                tavernSlot4Hirebtn.Text = ""
        End Select
    End Sub

    Private Sub StaticCreaturesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaticCreaturesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)
    End Sub
End Class