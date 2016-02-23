Public Class Armor : Inherits Item 'TODO
    Private armorSlotsPossible As String
    Private armorWearableBy As String
    Private armorIsUnique As Boolean
    Private armorMinStats As New Collection
    Private armorSet As String
    Private armorSetBonus As String
    Private armorResistances As New Collection

    Public Sub New()
        MyBase.New()
        MyBase.name = getArmorName()
        armorWearableBy = getSpecies()

        MyBase.stats.Add(Roll(10), getEquipStatName())

        Select Case MyBase.name
            Case "helmet", "cap"
                armorSlotsPossible = "1"
            Case "shoulderpads", "spaulders"
                armorSlotsPossible = "2"
            Case "sleeves"
                armorSlotsPossible = "3"
            Case "gloves", "gauntlets"
                armorSlotsPossible = "4"
            Case "cape"
                armorSlotsPossible = "5"
            Case "tunic", "breastplate"
                armorSlotsPossible = "6"
            Case "belt"
                armorSlotsPossible = "7"
            Case "pants"
                armorSlotsPossible = "8"
            Case "greaves", "shinguards"
                armorSlotsPossible = "9"
            Case "shoes", "boots"
                armorSlotsPossible = "10"
        End Select

        armorIsUnique = False
        If Roll(10) = 1 Then
            armorIsUnique = True
            armorSet = getCreatureName()
            MyBase.name = armorSet & "'s " & MyBase.name
            armorSetBonus = getEquipStatName()
        End If

        Dim stat1 = getCoreStatName()
        armorMinStats.Add(50 + Roll(50), stat1)
        Dim stat2 As String = stat1
        Do Until stat2 <> stat1
            stat2 = getCoreStatName()
        Loop
        armorMinStats.Add(50 + Roll(50), stat2)

        Dim resistance1 As String = getResistanceName()
        armorResistances.Add(Roll(10), resistance1)
        Dim resistance2 As String = resistance1
        Do Until resistance1 <> resistance2
            resistance2 = getResistanceName()
        Loop
        armorResistances.Add(Roll(10), resistance2)

    End Sub

    Public Sub New(id As Integer)
        MyBase.New(id)
    End Sub

    Public Sub New(row As GameDatabaseDataSet.StaticArmorRow)
        MyBase.New(row.id, currentPlayer, row.name)
        armorIsUnique = row.isUnique
        armorSlotsPossible = row.slotsPossible
        armorWearableBy = row.wearableBy

        Dim statsArray() As String = row.attributes.Split(" "c)
        For Each stat In statsArray
            Dim statArray() As String = stat.Split(":"c)
            MyBase.stats.Add(CInt(statArray(1)), statArray(0))
        Next

        statsArray = row.minStats.Split(" "c)
        For Each stat In statsArray
            Dim statArray() As String = stat.Split(":"c)
            armorMinStats.Add(CInt(statArray(1)), statArray(0))
        Next

        If Not IsDBNull(row("setName")) Then
            armorSet = row.setName
            armorSetBonus = row.setBonus
        End If

        statsArray = row.resistances.Split(" "c)
        For Each stat In statsArray
            Dim statArray() As String = stat.Split(":"c)
            armorResistances.Add(CInt(statArray(1)), statArray(0))
        Next
    End Sub

    Public Overrides ReadOnly Property id() As Integer
        Get
            Return MyBase.id
        End Get
    End Property

    Public Overrides ReadOnly Property owner() As Player
        Get
            Return MyBase.owner
        End Get
    End Property

    Public Overrides Property name() As String
        Get
            Return MyBase.name
        End Get
        Set(value As String)
            MyBase.name = value
        End Set
    End Property

    Public Overrides Property stats() As Collection
        Get
            Return MyBase.stats
        End Get
        Set(value As Collection)
            MyBase.stats = value
        End Set
    End Property

    Public ReadOnly Property slots As String
        Get
            Return armorSlotsPossible
        End Get
    End Property

    Public ReadOnly Property isUnique As Boolean
        Get
            Return armorIsUnique
        End Get
    End Property

    Public ReadOnly Property minStats As Collection
        Get
            Return armorMinStats
        End Get
    End Property

    Public ReadOnly Property setName() As String
        Get
            Return armorSet
        End Get
    End Property

    Public ReadOnly Property setBonus() As String
        Get
            Return armorSetBonus
        End Get
    End Property

    Public Property resists() As Collection
        Get
            Return armorResistances
        End Get
        Set(value As Collection)
            armorResistances = value
        End Set
    End Property

    Public Overrides Property cost As Integer
        Get
            Return MyBase.cost
        End Get
        Set(value As Integer)
            MyBase.cost = value
        End Set
    End Property

    Public Function DetailsString() As String
        Dim detailString As String = Nothing
        detailString = MyBase.name & vbCrLf
        detailString = detailString & If(armorIsUnique, "unique" & vbCrLf, Nothing)
        Dim statsString As String = Nothing
        statsString = statsString & If(MyBase.stats.Contains("maxHealth"), "max HP: " & MyBase.stats.Item("maxHealth") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("armor"), "armor: " & MyBase.stats.Item("armor") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("strength"), "str: " & MyBase.stats.Item("strength") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("initiative"), "ini: " & MyBase.stats.Item("initiative") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("intelligence"), "int: " & MyBase.stats.Item("intelligence") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("wisdom"), "wis: " & MyBase.stats.Item("wisdom") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("dexterity"), "dex: " & MyBase.stats.Item("dexterity") & Space(1), Nothing)
        detailString = detailString & statsString & vbCrLf
        Dim slotArray As String() = armorSlotsPossible.Split(" "c)
        Dim slotString As String = Nothing
        For Each slot As Integer In slotArray
            Select Case slot
                Case 1
                    slotString = slotString & "head" & Space(1)
                Case 2
                    slotString = slotString & "shoulders" & Space(1)
                Case 3
                    slotString = slotString & "arms" & Space(1)
                Case 4
                    slotString = slotString & "hands" & Space(1)
                Case 5
                    slotString = slotString & "back" & Space(1)
                Case 6
                    slotString = slotString & "chest" & Space(1)
                Case 7
                    slotString = slotString & "waist" & Space(1)
                Case 8
                    slotString = slotString & "legs" & Space(1)
                Case 9
                    slotString = slotString & "shins" & Space(1)
                Case 10
                    slotString = slotString & "feet" & Space(1)
            End Select
        Next
        detailString = detailString & "wearable on: " & slotString.Trim & vbCrLf
        detailString = detailString & "wearable by: " & armorWearableBy & vbCrLf
        statsString = Nothing
        statsString = statsString & If(armorMinStats.Contains("strength"), "str: " & armorMinStats.Item("strength") & Space(1), Nothing)
        statsString = statsString & If(armorMinStats.Contains("initiative"), "ini: " & armorMinStats.Item("initiative") & Space(1), Nothing)
        statsString = statsString & If(armorMinStats.Contains("intelligence"), "int: " & armorMinStats.Item("intelligence") & Space(1), Nothing)
        statsString = statsString & If(armorMinStats.Contains("wisdom"), "wis: " & armorMinStats.Item("wisdom") & Space(1), Nothing)
        statsString = statsString & If(armorMinStats.Contains("dexterity"), "dex: " & armorMinStats.Item("dexterity") & Space(1), Nothing)
        detailString = detailString & "minimum stats: " & statsString & vbCrLf
        detailString = detailString & If(armorIsUnique, "set name: " & armorSet & vbCrLf, Nothing)
        detailString = detailString & If(armorIsUnique, "set bonus: " & armorSetBonus & vbCrLf, Nothing)
        statsString = Nothing
        statsString = statsString & If(armorResistances.Contains("fire"), "fire: " & armorResistances.Item("fire") & Space(1), Nothing)
        statsString = statsString & If(armorResistances.Contains("ice"), "ice: " & armorResistances.Item("ice") & Space(1), Nothing)
        statsString = statsString & If(armorResistances.Contains("mental"), "mental: " & armorResistances.Item("mental") & Space(1), Nothing)
        statsString = statsString & If(armorResistances.Contains("death"), "death: " & armorResistances.Item("death") & Space(1), Nothing)
        statsString = statsString & If(armorResistances.Contains("lightning"), "lightning: " & armorResistances.Item("lightning") & Space(1), Nothing)
        statsString = statsString & If(armorResistances.Contains("nature"), "nature: " & armorResistances.Item("nature") & Space(1), Nothing)
        statsString = statsString & If(armorResistances.Contains("divine"), "divine: " & armorResistances.Item("divine") & Space(1), Nothing)
        detailString = detailString & "resistances: " & statsString & vbCrLf
        Return detailString.Trim
    End Function

    Public Overrides Function ToString() As String
        Dim statString As String = Nothing
        statString = statString & If(MyBase.stats.Contains("maxHealth"), "hp:" & MyBase.stats.Item("maxHealth") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("armor"), "armor:" & MyBase.stats.Item("armor") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("strength"), "str:" & MyBase.stats.Item("strength") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("initiative"), "ini:" & MyBase.stats.Item("initiative") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("intelligence"), "int:" & MyBase.stats.Item("intelligence") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("wisdom"), "wis:" & MyBase.stats.Item("wisdom") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("dexterity"), "dex:" & MyBase.stats.Item("dexterity") & Space(1), Nothing)
        Return MyBase.ToString() & " (" & statString.Trim & ")"
    End Function

    Public Sub Save(ds As GameDatabaseDataSet,
                    bs As BindingSource,
                    ta As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter)
        Dim newRow As DataRow = ds.StaticArmor.NewRow
        newRow("name") = MyBase.name

        Dim statString As String = Nothing
        statString = statString & If(MyBase.stats.Contains("maxHealth"), "maxHealth:" & MyBase.stats.Item("maxHealth") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("armor"), "armor:" & MyBase.stats.Item("armor") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("strength"), "strength:" & MyBase.stats.Item("strength") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("initiative"), "initiative:" & MyBase.stats.Item("initiative") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("intelligence"), "intelligence:" & MyBase.stats.Item("intelligence") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("wisdom"), "wisdom:" & MyBase.stats.Item("wisdom") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("dexterity"), "dexterity:" & MyBase.stats.Item("dexterity") & Space(1), Nothing)
        newRow("attributes") = statString.Trim

        newRow("slotsPossible") = armorSlotsPossible
        newRow("wearableBy") = armorWearableBy
        newRow("isUnique") = armorIsUnique

        statString = Nothing
        statString = statString & If(armorMinStats.Contains("strength"), "strength:" & armorMinStats.Item("strength") & Space(1), Nothing)
        statString = statString & If(armorMinStats.Contains("initiative"), "initiative:" & armorMinStats.Item("initiative") & Space(1), Nothing)
        statString = statString & If(armorMinStats.Contains("intelligence"), "intelligence:" & armorMinStats.Item("intelligence") & Space(1), Nothing)
        statString = statString & If(armorMinStats.Contains("wisdom"), "wisdom:" & armorMinStats.Item("wisdom") & Space(1), Nothing)
        statString = statString & If(armorMinStats.Contains("dexterity"), "dexterity:" & armorMinStats.Item("dexterity") & Space(1), Nothing)
        newRow("minStats") = statString.Trim

        newRow("setName") = armorSet
        'statString = Nothing
        'statString = statString & If(armorSetBonus.Contains("maxHealth"), "maxHealth:" & armorSetBonus.Item("maxHealth") & Space(1), Nothing)
        'statString = statString & If(armorSetBonus.Contains("armor"), "armor:" & armorSetBonus.Item("armor") & Space(1), Nothing)
        'statString = statString & If(armorSetBonus.Contains("strength"), "strength:" & armorSetBonus.Item("strength") & Space(1), Nothing)
        'statString = statString & If(armorSetBonus.Contains("initiative"), "initiative:" & armorSetBonus.Item("initiative") & Space(1), Nothing)
        'statString = statString & If(armorSetBonus.Contains("intelligence"), "intelligence:" & armorSetBonus.Item("intelligence") & Space(1), Nothing)
        'statString = statString & If(armorSetBonus.Contains("wisdom"), "wisdom:" & armorSetBonus.Item("wisdom") & Space(1), Nothing)
        'statString = statString & If(armorSetBonus.Contains("dexterity"), "dexterity:" & armorSetBonus.Item("dexterity") & Space(1), Nothing)
        newRow("setBonus") = armorSetBonus

        statString = Nothing
        statString = statString & If(armorResistances.Contains("fire"), "fire:" & armorResistances.Item("fire") & Space(1), Nothing)
        statString = statString & If(armorResistances.Contains("ice"), "ice:" & armorResistances.Item("ice") & Space(1), Nothing)
        statString = statString & If(armorResistances.Contains("mental"), "mental:" & armorResistances.Item("mental") & Space(1), Nothing)
        statString = statString & If(armorResistances.Contains("death"), "death:" & armorResistances.Item("death") & Space(1), Nothing)
        statString = statString & If(armorResistances.Contains("lightning"), "lightning:" & armorResistances.Item("lightning") & Space(1), Nothing)
        statString = statString & If(armorResistances.Contains("nature"), "nature:" & armorResistances.Item("nature") & Space(1), Nothing)
        statString = statString & If(armorResistances.Contains("divine"), "divine:" & armorResistances.Item("divine") & Space(1), Nothing)
        newRow("resistances") = statString.Trim

        ds.StaticArmor.Rows.Add(newRow)
        Try
            bs.EndEdit()
            ta.Update(ds.StaticArmor)
        Catch ex As Exception
            MsgBox("unable to add weapon to database")
        End Try
    End Sub
End Class
