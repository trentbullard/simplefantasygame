Public Class MarketWindow
    Private Sub ArmorAugmentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ArmorAugmentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GameDatabaseDataSet)

    End Sub

    Private Sub MarketWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerCreatures' table. You can move, or remove it, as needed.
        Me.PlayerCreaturesTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerCreatures)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerConsumables' table. You can move, or remove it, as needed.
        Me.PlayerConsumablesTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerConsumables)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.PlayerArmor' table. You can move, or remove it, as needed.
        Me.PlayerArmorTableAdapter.Fill(Me.GameDatabaseDataSet.PlayerArmor)
        'TODO: This line of code loads data into the 'GameDatabaseDataSet.ArmorAugments' table. You can move, or remove it, as needed.
        Me.ArmorAugmentsTableAdapter.Fill(Me.GameDatabaseDataSet.ArmorAugments)

    End Sub
End Class