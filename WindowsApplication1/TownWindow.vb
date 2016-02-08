Public Class TownWindow
    Private Sub TownWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ArmorAugmentTableAdapter.FillByArmorid(Me.GameDatabaseDataSet.ArmorAugment, currentPlayer.id)
        Me.BattlesTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.Battles, currentPlayer.id)
        Me.PartiesTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreature, currentPlayer.id)
        Me.PlayerArmorTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreature, currentPlayer.id)
        Me.PlayerConsumableTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreature, currentPlayer.id)
        Me.PlayerCreatureTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreature, currentPlayer.id)
        Me.PlayerSkillTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreature, currentPlayer.id)
        Me.PlayerWeaponTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreature, currentPlayer.id)
        Me.PlayersTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreature, currentPlayer.id)
        Me.StaticArmorTableAdapter.Fill(Me.GameDatabaseDataSet.StaticArmor)
        Me.StaticAugmentsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticAugments)
        Me.StaticConsumablesTableAdapter.Fill(Me.GameDatabaseDataSet.StaticConsumables)
        Me.StaticCreaturesTableAdapter.Fill(Me.GameDatabaseDataSet.StaticCreatures)
        Me.StaticMobsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticMobs)
        Me.StaticSkillsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticSkills)
        Me.StaticWeaponsTableAdapter.Fill(Me.GameDatabaseDataSet.StaticWeapons)
        Me.TurnsTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreature, currentPlayer.id)
        Me.WeaponAugmentTableAdapter.FillByPlayerid(Me.GameDatabaseDataSet.PlayerCreature, currentPlayer.id)

    End Sub

    Private Sub UpdateDatabase()
        Me.Validate()
        Me.PlayersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)
    End Sub

    Private Sub ArmorAugmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ArmorAugmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub
End Class