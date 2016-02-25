Module Lists
    Public namesList = New String() {"trent", "john", "matthew", "mark", "luke", "george", "ronald", "paul", "isaac", "abraham", "jacob", "will",
                                  "sarah", "courtney", "jennifer", "tina", "kristina", "anna", "constance"}
    Public speciesList = New String() {"human", "elf", "orc", "dwarf", "halfling", "ogre", "troll", "goblin", "kobold", "gnome"}
    Public smallSpecies = New String() {"dwarf", "halfling", "goblin", "gnome"}
    Public middleSpecies = New String() {"human", "elf", "kobold"}
    Public largeSpecies = New String() {"orc", "ogre", "troll"}
    Public goodSpecies = New String() {"elf", "dwarf", "halfling", "gnome", "human", "ogre"}
    Public evilSpecies = New String() {"orc", "troll", "goblin", "kobold"}
    Public statList = New String() {"dexterity", "wisdom", "strength", "initiative", "intelligence", "armor", "maxHealth", "health"}
    Public weaponNames = New String() {"sword", "shield", "hammer", "staff", "wand", "scepter", "tome", "crossbow", "bow", "spear"}
    Public armorNames = New String() {"helmet", "cap", "shoulderpads", "spaulders", "sleeves", "gloves", "gauntlets", "cape", "tunic", "breastplate", "belt", "pants", "shinguards", "greaves", "shoes", "boots"}
    Public resistanceNames = New String() {"fire", "ice", "mental", "death", "lightning", "nature", "divine"}

    Public Function getCreatureName() As String
        Return namesList(Roll(19) - 1)
    End Function

    Public Function getSpecies() As String
        Return speciesList(Roll(10) - 1)
    End Function

    Public Function getSmallSpecies() As String
        Return smallSpecies(Roll(4) - 1)
    End Function

    Public Function getMiddleSpecies() As String
        Return middleSpecies(Roll(3) - 1)
    End Function

    Public Function getLargeSpecies() As String
        Return largeSpecies(Roll(3) - 1)
    End Function

    Public Function getGoodSpecies() As String
        Return goodSpecies(Roll(6) - 1)
    End Function

    Public Function getEvilSpecies() As String
        Return evilSpecies(Roll(4) - 1)
    End Function

    Public Function getEquipStatName() As String
        Return statList(Roll(7) - 1)
    End Function

    Public Function getConsumableStatName() As String
        Return statList(Roll(8) - 1)
    End Function

    Public Function getCoreStatName() As String
        Return statList(Roll(5) - 1)
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
