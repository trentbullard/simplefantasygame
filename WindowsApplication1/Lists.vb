Module Lists
    Dim namesList = New String() {"trent", "john", "matthew", "mark", "luke", "george", "ronald", "paul", "isaac", "abraham", "jacob"}
    Dim speciesList = New String() {"human", "elf", "orc", "dwarf", "halfling", "ogre", "troll", "goblin"}

    Public Function getName()
        Return namesList(Roll(11) - 1)
    End Function

    Public Function getSpecies()
        Return speciesList(Roll(8) - 1)
    End Function

    Public Function getHealth()
        Return 70 + (Roll(5) * 10)
    End Function

    Public Function getStrength()
        Return 70 + (Roll(5) * 10)
    End Function

    Public Function getArmor()
        Return 70 + (Roll(5) * 10)
    End Function
End Module
