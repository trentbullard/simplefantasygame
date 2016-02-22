Public Class DatasetController
    Private dataSet As GameDatabaseDataSet
    Private playersTA As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
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

    Public Sub New(DS As GameDatabaseDataSet, playersTA As GameDatabaseDataSetTableAdapters.PlayersTableAdapter,
                   statesBS As BindingSource, statesTA As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter,
                   creaturesBS As BindingSource, creaturesTA As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter,
                   skillsBS As BindingSource, skillsTA As GameDatabaseDataSetTableAdapters.PlayerSkillsTableAdapter,
                   armorBS As BindingSource, armorTA As GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter,
                   weaponsBS As BindingSource, weaponsTA As GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter,
                   consumablesBS As BindingSource, consumablesTA As GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter,
                   jewelryBS As BindingSource, jewelryTA As GameDatabaseDataSetTableAdapters.PlayerJewelryTableAdapter,
                   augmentsBS As BindingSource, augmentsTA As GameDatabaseDataSetTableAdapters.PlayerAugmentsTableAdapter)
        dataSet = DS
        Me.playersTA = playersTA
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
        Dim oldState As PlayerState = currentState

        Dim stateRow As GameDatabaseDataSet.PlayerStatesRow = dataSet.PlayerStates.NewPlayerStatesRow
        stateRow.playerid = currentPlayer.id
        stateRow.dateSaved = Date.Now
        stateRow("currentPartyid") = If(currentState.party Is Nothing, DBNull.Value, currentState.party.id)
        stateRow("currentTierid") = If(currentState.tier Is Nothing, DBNull.Value, currentState.tier.id)
        stateRow("currentQuestid") = If(currentState.quest Is Nothing, DBNull.Value, currentState.quest.id)
        stateRow.gameDate = currentState.dateInGame
        stateRow.isAmbushed = currentState.isAmbushed
        stateRow.playerGold = currentPlayer.gold
        stateRow.playerLevel = currentPlayer.level
        stateRow.playerExperience = currentPlayer.exp
        dataSet.PlayerStates.Rows.Add(stateRow)
        playerStatesBS.EndEdit()
        playerStatesTA.Update(dataSet.PlayerStates)
        currentState = New PlayerState(playerStatesTA.GetData.Last)
        currentState.LoadWindows(oldState)

        playerCreaturesTA.FillByPlayerStateid(dataSet.PlayerCreatures, oldState.id)
        For Each oldRow As GameDatabaseDataSet.PlayerCreaturesRow In playerCreaturesTA.GetCreaturesByPlayerStateid(oldState.id)
            Dim newRow As GameDatabaseDataSet.PlayerCreaturesRow = dataSet.PlayerCreatures.NewPlayerCreaturesRow
            newRow.playerStateid = currentState.id
            newRow.creatureid = oldRow.creatureid
            newRow.name = oldRow.name
            dataSet.PlayerCreatures.Rows.Add(newRow)
            playerCreaturesBS.EndEdit()
            playerCreaturesTA.Update(dataSet.PlayerCreatures)
        Next

        'playerSkillsTA.FillByPlayerStateid(dataSet.PlayerSkills, oldState.id)
        'For Each oldRow As GameDatabaseDataSet.PlayerSkillsRow In playerSkillsTA.GetData
        '    Dim newRow As GameDatabaseDataSet.PlayerSkillsRow = dataSet.PlayerSkills.NewPlayerSkillsRow
        '    newRow.playerStateid = currentState.id
        '    newRow.skillid = oldRow.skillid
        '    dataSet.PlayerSkills.Rows.Add(newRow)
        '    playerSkillsBS.EndEdit()
        '    playerSkillsTA.Update(dataSet.PlayerSkills)
        'Next

        'playerArmorTA.FillByPlayerStateid(dataSet.PlayerArmor, oldState.id)
        'For Each oldRow As GameDatabaseDataSet.PlayerArmorRow In playerArmorTA.GetData
        '    Dim newRow As GameDatabaseDataSet.PlayerArmorRow = dataSet.PlayerArmor.NewPlayerArmorRow
        '    newRow.playerStateid = currentState.id
        '    newRow.armorid = oldRow.armorid
        '    newRow.wearerid = oldRow.wearerid
        '    newRow.slotWorn = oldRow.slotWorn
        '    dataSet.PlayerArmor.Rows.Add(newRow)
        '    playerArmorBS.EndEdit()
        '    playerArmorTA.Update(dataSet.PlayerArmor)
        'Next

        'playerWeaponsTA.FillByPlayerStateid(dataSet.PlayerWeapons, oldState.id)
        'For Each oldRow As GameDatabaseDataSet.PlayerWeaponsRow In playerWeaponsTA.GetData
        '    Dim newRow As GameDatabaseDataSet.PlayerWeaponsRow = dataSet.PlayerWeapons.NewPlayerWeaponsRow
        '    newRow.playerStateid = currentState.id
        '    newRow.weaponid = oldRow.weaponid
        '    newRow.wearerid = oldRow.wearerid
        '    newRow.slotWorn = oldRow.slotWorn
        '    dataSet.PlayerWeapons.Rows.Add(newRow)
        '    playerWeaponsBS.EndEdit()
        '    playerWeaponsTA.Update(dataSet.PlayerWeapons)
        'Next

        'playerConsumablesTA.FillByPlayerStateid(dataSet.PlayerConsumables, oldState.id)
        'For Each oldRow As GameDatabaseDataSet.PlayerConsumablesRow In playerConsumablesTA.GetData
        '    Dim newRow As GameDatabaseDataSet.PlayerConsumablesRow = dataSet.PlayerConsumables.NewPlayerConsumablesRow
        '    newRow.playerStateid = currentState.id
        '    newRow.consumableid = oldRow.consumableid
        '    newRow.isUsed = oldRow.isUsed
        '    dataSet.PlayerConsumables.Rows.Add(newRow)
        '    playerConsumablesBS.EndEdit()
        '    playerConsumablesTA.Update(dataSet.PlayerConsumables)
        'Next

        'playerJewelryTA.FillByPlayerStateid(dataSet.PlayerJewelry, oldState.id)
        'For Each oldRow As GameDatabaseDataSet.PlayerJewelryRow In playerJewelryTA.GetData
        '    Dim newRow As GameDatabaseDataSet.PlayerJewelryRow = dataSet.PlayerJewelry.NewPlayerJewelryRow
        '    newRow.playerStateid = currentState.id
        '    newRow.jewelryid = oldRow.jewelryid
        '    newRow.wearerid = oldRow.wearerid
        '    newRow.slot = oldRow.slot
        '    dataSet.PlayerJewelry.Rows.Add(newRow)
        '    playerJewelryBS.EndEdit()
        '    playerJewelryTA.Update(dataSet.PlayerJewelry)
        'Next

        'playerAugmentsTA.FillByPlayerStateid(dataSet.PlayerAugments, oldState.id)
        'For Each oldRow As GameDatabaseDataSet.PlayerAugmentsRow In playerAugmentsTA.GetData
        '    Dim newRow As GameDatabaseDataSet.PlayerAugmentsRow = dataSet.PlayerAugments.NewPlayerAugmentsRow
        '    newRow.playerStateid = currentState.id
        '    newRow.augmentid = oldRow.augmentid
        '    dataSet.PlayerAugments.Rows.Add(newRow)
        '    playerAugmentsBS.EndEdit()
        '    playerAugmentsTA.Update(dataSet.PlayerAugments)
        'Next

        dataSet.Players.FindByid(currentPlayer.id).name = currentPlayer.name
        dataSet.Players.FindByid(currentPlayer.id).level = currentState.level
        dataSet.Players.FindByid(currentPlayer.id).experience = currentState.exp
        dataSet.Players.FindByid(currentPlayer.id).gold = currentState.gold
        Me.playersTA.Update(dataSet.Players.FindByid(currentPlayer.id))
    End Sub
End Class
