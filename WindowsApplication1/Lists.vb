Module Lists
    Dim namesList = New String() {"trent", "john", "matthew", "mark", "luke", "george", "ronald", "paul", "isaac", "abraham", "jacob", "will",
                                  "sarah", "courtney", "jennifer", "tina", "kristina", "anna", "constance"}
    Dim speciesList = New String() {"human", "elf", "orc", "dwarf", "halfling", "ogre", "troll", "goblin"}
    Dim statList = New String() {"maxHealth", "dexterity", "armor", "strength", "initiative", "intelligence", "wisdom", "health"}
    Dim weaponNames = New String() {"sword", "shield", "hammer", "staff", "wand", "scepter", "tome", "crossbow", "bow", "spear"}
    Dim armorNames = New String() {"helmet", "cap", "shoulderpads", "spaulders", "sleaves", "gloves", "gauntlets", "cape", "tunic", "breastplate", "belt", "pants", "shinguards", "greaves", "shoes", "boots"}
    Dim resistanceNames = New String() {"fire", "ice", "mental", "death", "lightning", "nature", "divine"}

    Public Function getCreatureName() As String
        Return namesList(Roll(19) - 1)
    End Function

    Public Function getSpecies() As String
        Return speciesList(Roll(8) - 1)
    End Function

    Public Function getEquipStatName() As String
        Return statList(Roll(7) - 1)
    End Function

    Public Function getConsumableStatName() As String
        Return statList(Roll(8) - 1)
    End Function

    Public Function getWeaponName() As String
        Return weaponNames(Roll(10) - 1)
    End Function

    Public Function getArmorName() As String
        Return armorNames(Roll(16) - 1)
    End Function

    Public Function getResistanceName() As String
        Return resistanceNames(Roll(7) - 1)
    End Function

    Public Function getMaxHealth() As Integer
        Return 70 + Roll(50)
    End Function

    Public Function getArmor() As Integer
        Return 70 + Roll(50)
    End Function

    Public Function getStrength() As Integer
        Return 70 + Roll(50)
    End Function

    Public Function getIni() As Integer
        Return 70 + Roll(50)
    End Function

    Public Function getInt() As Integer
        Return 70 + Roll(50)
    End Function

    Public Function getWis() As Integer
        Return 70 + Roll(50)
    End Function

    Public Function getDex() As Integer
        Return 70 + Roll(50)
    End Function
End Module
