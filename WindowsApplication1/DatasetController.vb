Public Class DatasetController
    Private dataSet As GameDatabaseDataSet
    Private playerStatesBS As BindingSource
    Private playerStatesTA As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter
    Private playerCreaturesBS As BindingSource
    Private playerCreaturesTA As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter
    Private playerSkillsBS As BindingSource
    Private playerSkillsTA As GameDatabaseDataSetTableAdapters.PlayerSkillsTableAdapter
    Private playerArmorBS As BindingSource
    Private playerArmorTA As GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter
    Private playerWeaponsBS As BindingSource
    Private playerWeaponsTA As GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter
    Private playerConsumablesBS As BindingSource
    Private playerConsumablesTA As GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter
    Private playerJewelryBS As BindingSource
    Private playerJewelryTA As GameDatabaseDataSetTableAdapters.PlayerJewelryTableAdapter
    Private playerAugmentsBS As BindingSource
    Private playerAugmentsTA As GameDatabaseDataSetTableAdapters.PlayerAugmentsTableAdapter

    Public Sub New(DS As GameDatabaseDataSet,
                   statesBS As BindingSource, statesTA As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter,
                   creaturesBS As BindingSource, creaturesTA As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter,
                   skillsBS As BindingSource, skillsTA As GameDatabaseDataSetTableAdapters.PlayerSkillsTableAdapter,
                   armorBS As BindingSource, armorTA As GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter,
                   weaponsBS As BindingSource, weaponsTA As GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter,
                   consumablesBS As BindingSource, consumablesTA As GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter,
                   jewelryBS As BindingSource, jewelryTA As GameDatabaseDataSetTableAdapters.PlayerJewelryTableAdapter,
                   augmentsBS As BindingSource, augmentsTA As GameDatabaseDataSetTableAdapters.PlayerAugmentsTableAdapter)
        dataSet = DS
        playerStatesBS = statesBS
        playerStatesTA = statesTA
        playerCreaturesBS = creaturesBS
        playerCreaturesTA = creaturesTA
        playerSkillsBS = skillsBS
        playerSkillsTA = skillsTA
        playerArmorBS = armorBS
        playerArmorTA = armorTA
        playerWeaponsBS = weaponsBS
        playerWeaponsTA = weaponsTA
        playerConsumablesBS = consumablesBS
        playerConsumablesTA = consumablesTA
        playerJewelryBS = jewelryBS
        playerJewelryTA = jewelryTA
        playerAugmentsBS = augmentsBS
        playerAugmentsTA = augmentsTA
    End Sub

    Public Sub SaveState()
        Dim stateRow As GameDatabaseDataSet.PlayerStatesRow = dataSet.PlayerStates.NewPlayerStatesRow
        stateRow.playerid = currentPlayer.id
        stateRow.dateSaved = Date.Now
        stateRow("currentPartyid") = If(currentState.party Is Nothing, currentState.party.id, DBNull.Value)
        stateRow("currentTierid") = If(currentState.tier Is Nothing, currentState.tier.id, DBNull.Value)
        stateRow("currentQuestid") = If(currentState.quest Is Nothing, currentState.quest.id, DBNull.Value)
        stateRow.gameDate = currentState.dateInGame
        stateRow.isAmbushed = currentState.isAmbushed
        stateRow.playerGold = currentState.gold
        stateRow.playerLevel = currentState.level
        stateRow.playerExperience = currentState.exp
        dataSet.PlayerStates.Rows.Add(stateRow)


        playerCreaturesTA.FillByPlayerStateid(dataSet.PlayerCreatures, currentState.id)
        For Each oldRow As GameDatabaseDataSet.PlayerCreaturesRow In playerCreaturesTA.GetData
            Dim newRow As GameDatabaseDataSet.PlayerCreaturesRow = dataSet.PlayerCreatures.NewPlayerCreaturesRow
            newRow = oldRow
            newRow.playerStateid = 
        Next
        creatureRow.playerStateid =
            creatureRow.
            creatureRow.

        Dim skillRow As GameDatabaseDataSet.PlayerSkillsRow = dataSet.PlayerSkills.NewPlayerSkillsRow


        Dim armorRow As GameDatabaseDataSet.PlayerArmorRow = dataSet.PlayerArmor.NewPlayerArmorRow


        Dim weaponRow As GameDatabaseDataSet.PlayerWeaponsRow = dataSet.PlayerWeapons.NewPlayerWeaponsRow


        Dim consumableRow As GameDatabaseDataSet.PlayerConsumablesRow = dataSet.PlayerConsumables.NewPlayerConsumablesRow


        Dim jewelryRow As GameDatabaseDataSet.PlayerJewelryRow = dataSet.PlayerJewelry.NewPlayerJewelryRow


        Dim augmentRow As GameDatabaseDataSet.PlayerAugmentsRow = dataSet.PlayerAugments.NewPlayerAugmentsRow


    End Sub
End Class
