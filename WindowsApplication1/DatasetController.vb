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
        Dim oldStateid As Integer = currentState.id

        Dim stateRow As GameDatabaseDataSet.PlayerStatesRow = dataSet.PlayerStates.NewPlayerStatesRow
        stateRow.playerid = currentPlayer.id
        stateRow.dateSaved = Date.Now
        stateRow("currentPartyid") = If(currentState.party Is Nothing, DBNull.Value, currentState.party.id)
        stateRow("currentTierid") = If(currentState.tier Is Nothing, DBNull.Value, currentState.tier.id)
        stateRow("currentQuestid") = If(currentState.quest Is Nothing, DBNull.Value, currentState.quest.id)
        stateRow.gameDate = currentState.dateInGame
        stateRow.isAmbushed = currentState.isAmbushed
        stateRow.playerGold = currentState.gold
        stateRow.playerLevel = currentState.level
        stateRow.playerExperience = currentState.exp
        dataSet.PlayerStates.Rows.Add(stateRow)
        playerStatesBS.EndEdit()
        playerStatesTA.Update(dataSet.PlayerStates)
        currentState = New PlayerState(playerStatesTA.GetData.Last)

        playerCreaturesTA.FillByPlayerStateid(dataSet.PlayerCreatures, oldStateid)
        For Each oldRow As GameDatabaseDataSet.PlayerCreaturesRow In playerCreaturesTA.GetData
            Dim newRow As GameDatabaseDataSet.PlayerCreaturesRow = dataSet.PlayerCreatures.NewPlayerCreaturesRow
            newRow = oldRow
            newRow("id") = DBNull.Value
            newRow.playerStateid = currentState.id
            dataSet.PlayerCreatures.Rows.Add(newRow)
        Next
        playerCreaturesBS.EndEdit()
        playerCreaturesTA.Update(dataSet.PlayerCreatures)

        playerSkillsTA.FillByPlayerStateid(dataSet.PlayerSkills, oldStateid)
        For Each oldRow As GameDatabaseDataSet.PlayerSkillsRow In playerSkillsTA.GetData
            Dim newRow As GameDatabaseDataSet.PlayerSkillsRow = dataSet.PlayerSkills.NewPlayerSkillsRow
            newRow = oldRow
            newRow("id") = DBNull.Value
            newRow.playerStateid = currentState.id
            dataSet.PlayerSkills.Rows.Add(newRow)
        Next
        playerSkillsBS.EndEdit()
        playerSkillsTA.Update(dataSet.PlayerSkills)

        playerArmorTA.FillByPlayerStateid(dataSet.PlayerArmor, oldStateid)
        For Each oldRow As GameDatabaseDataSet.PlayerArmorRow In playerArmorTA.GetData
            Dim newRow As GameDatabaseDataSet.PlayerArmorRow = dataSet.PlayerArmor.NewPlayerArmorRow
            newRow = oldRow
            newRow("id") = DBNull.Value
            newRow.playerStateid = currentState.id
            dataSet.PlayerArmor.Rows.Add(newRow)
        Next
        playerArmorBS.EndEdit()
        playerArmorTA.Update(dataSet.PlayerArmor)

        playerWeaponsTA.FillByPlayerStateid(dataSet.PlayerWeapons, oldStateid)
        For Each oldRow As GameDatabaseDataSet.PlayerWeaponsRow In playerWeaponsTA.GetData
            Dim newRow As GameDatabaseDataSet.PlayerWeaponsRow = dataSet.PlayerWeapons.NewPlayerWeaponsRow
            newRow = oldRow
            newRow("id") = DBNull.Value
            newRow.playerStateid = currentState.id
            dataSet.PlayerWeapons.Rows.Add(newRow)
        Next
        playerWeaponsBS.EndEdit()
        playerWeaponsTA.Update(dataSet.PlayerWeapons)

        playerConsumablesTA.FillByPlayerStateid(dataSet.PlayerConsumables, oldStateid)
        For Each oldRow As GameDatabaseDataSet.PlayerConsumablesRow In playerConsumablesTA.GetData
            Dim newRow As GameDatabaseDataSet.PlayerConsumablesRow = dataSet.PlayerConsumables.NewPlayerConsumablesRow
            newRow = oldRow
            newRow("id") = DBNull.Value
            newRow.playerStateid = currentState.id
            dataSet.PlayerConsumables.Rows.Add(newRow)
        Next
        playerConsumablesBS.EndEdit()
        playerConsumablesTA.Update(dataSet.PlayerConsumables)

        playerJewelryTA.FillByPlayerStateid(dataSet.PlayerJewelry, oldStateid)
        For Each oldRow As GameDatabaseDataSet.PlayerJewelryRow In playerJewelryTA.GetData
            Dim newRow As GameDatabaseDataSet.PlayerJewelryRow = dataSet.PlayerJewelry.NewPlayerJewelryRow
            newRow = oldRow
            newRow("id") = DBNull.Value
            newRow.playerStateid = currentState.id
            dataSet.PlayerJewelry.Rows.Add(newRow)
        Next
        playerJewelryBS.EndEdit()
        playerJewelryTA.Update(dataSet.PlayerJewelry)

        playerAugmentsTA.FillByPlayerStateid(dataSet.PlayerAugments, oldStateid)
        For Each oldRow As GameDatabaseDataSet.PlayerAugmentsRow In playerAugmentsTA.GetData
            Dim newRow As GameDatabaseDataSet.PlayerAugmentsRow = dataSet.PlayerAugments.NewPlayerAugmentsRow
            newRow = oldRow
            newRow("id") = DBNull.Value
            newRow.playerStateid = currentState.id
            dataSet.PlayerAugments.Rows.Add(newRow)
        Next
        playerAugmentsBS.EndEdit()
        playerAugmentsTA.Update(dataSet.PlayerAugments)
    End Sub
End Class
