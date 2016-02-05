Public Class TownWindow
    Private Sub PlayersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub

    Private Sub TownWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.Turns' table. You can move, or remove it, as needed.
        Me.TurnsTableAdapter.Fill(Me.GameDatabaseDataSet.Turns)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.Battles' table. You can move, or remove it, as needed.
        Me.BattlesTableAdapter.Fill(Me.GameDatabaseDataSet.Battles)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.WeaponAugment' table. You can move, or remove it, as needed.
        Me.WeaponAugmentTableAdapter.Fill(Me.GameDatabaseDataSet.WeaponAugment)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerWeapon' table. You can move, or remove it, as needed.
        Me.PlayerWeaponTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerWeapon)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerSkill' table. You can move, or remove it, as needed.
        Me.PlayerSkillTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerSkill)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerCreature' table. You can move, or remove it, as needed.
        Me.PlayerCreatureTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerCreature)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerConsumable' table. You can move, or remove it, as needed.
        Me.PlayerConsumableTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerConsumable)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerArmor' table. You can move, or remove it, as needed.
        Me.PlayerArmorTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerArmor)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.Parties' table. You can move, or remove it, as needed.
        Me.PartiesTableAdapter.Fill(Me.GameDatabaseDataSet.Parties)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticWeapons' table. You can move, or remove it, as needed.
        Me.StaticWeaponsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticWeapons)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticSkills' table. You can move, or remove it, as needed.
        Me.StaticSkillsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticSkills)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticMobs' table. You can move, or remove it, as needed.
        Me.StaticMobsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticMobs)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticConsumables' table. You can move, or remove it, as needed.
        Me.StaticConsumablesTableAdapter.Fill(Me.GameDatabaseDataSet.StaticConsumables)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticAugments' table. You can move, or remove it, as needed.
        Me.StaticAugmentsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticAugments)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticArmor' table. You can move, or remove it, as needed.
        Me.StaticArmorTableAdapter.Fill(Me.GameDatabaseDataSet.StaticArmor)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.StaticCreatures' table. You can move, or remove it, as needed.
        Me.StaticCreaturesTableAdapter.Fill(Me.GameDatabaseDataSet.StaticCreatures)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.Players' table. You can move, or remove it, as needed.
        Me.PlayersTableAdapter.Fill(Me.GameDatabaseDataSet.Players)

    End Sub
End Class