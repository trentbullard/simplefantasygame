Public Class Armor : Inherits Item 'TODO
    Private armorSlotsPossible As String
    Private armorWearableBy As String
    Private armorIsUnique As Boolean
    Private armorMinStats As Collection
    Private armorSet As String
    Private armorSetBonus As String
    Private armorResistances As Collection

    Public Sub New()
        MyBase.New()
        MyBase.name = getArmorName() & MyBase.id
        armorWearableBy = getSpecies()

        Select Case MyBase.name
            Case "helmet"
                armorSlotsPossible = "1"
            Case "shoulderpads"
                armorSlotsPossible = "2"
            Case "sleeves"
                armorSlotsPossible = "3"
            Case "gloves"
                armorSlotsPossible = "4"
            Case "cape"
                armorSlotsPossible = "5"
            Case "shirt"
                armorSlotsPossible = "6"
            Case "belt"
                armorSlotsPossible = "7"
            Case "pants"
                armorSlotsPossible = "8"
            Case "greaves"
                armorSlotsPossible = "9"
            Case "shoes"
                armorSlotsPossible = "10"
            Case Else
                armorSlotsPossible = "0"
        End Select

        armorIsUnique = False
        If Roll(10) = 1 Then
            armorIsUnique = True
            armorSet = getCreatureName()
            MyBase.name = armorSet & "'s " & MyBase.name
            armorSetBonus = getEquipStatName()
        End If

        Dim resistance1 As String = getResistanceName()
        armorResistances.Add(Roll(10), resistance1)
        Dim resistance2 As String = resistance1
        Do Until resistance1 <> resistance2
            resistance2 = getResistanceName()
        Loop
        armorResistances.Add(Roll(10), resistance2)

        Dim stats As New Collection
        stats.Add(Roll(10), getEquipStatName())
        MyBase.stats = stats

        stats.Clear()
        Dim stat1 = getEquipStatName()
        stats.Add(50 + Roll(50), stat1)
        Dim stat2 As String = stat1
        Do Until stat2 <> stat1
            stat2 = getEquipStatName()
        Loop
        stats.Add(50 + Roll(50), stat2)
        armorMinStats = stats
    End Sub

    Public Sub New(id As Integer)
        MyBase.New(id)
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

    Public Overrides Function ToString() As String
        Dim statString As String = Nothing
        statString = statString & If(MyBase.stats.Item("maxHealth"), "maxHealth:" & MyBase.stats.Item("maxHealth"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("armor"), "armor:" & MyBase.stats.Item("armor"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("strength"), "strength:" & MyBase.stats.Item("strength"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("initiative"), "initiative:" & MyBase.stats.Item("initiative"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("intelligence"), "intelligence:" & MyBase.stats.Item("intelligence"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("wisdom"), "wisdom:" & MyBase.stats.Item("wisdom"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("dexterity"), "dexterity:" & MyBase.stats.Item("dexterity"), Nothing) & Space(1)
        Return MyBase.ToString() & " (" & statString.Trim & ")"
    End Function

    Public Sub Save(ds As GameDatabaseDataSet,
                    bs As BindingSource,
                    ta As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter)
        Dim newRow As DataRow = ds.StaticWeapons.NewRow
        newRow("name") = MyBase.name

        Dim statString As String = Nothing
        statString = statString & If(MyBase.stats.Contains("maxHealth"), "maxHealth:" & MyBase.stats.Item("maxHealth"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("armor"), "armor:" & MyBase.stats.Item("armor"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("strength"), "strength:" & MyBase.stats.Item("strength"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("initiative"), "initiative:" & MyBase.stats.Item("initiative"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("intelligence"), "intelligence:" & MyBase.stats.Item("intelligence"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("wisdom"), "wisdom:" & MyBase.stats.Item("wisdom"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("dexterity"), "dexterity:" & MyBase.stats.Item("dexterity"), Nothing) & Space(1)
        newRow("attributes") = statString.Trim

        newRow("slotsPossible") = armorSlotsPossible
        newRow("wearableBy") = armorWearableBy
        newRow("isUnique") = armorIsUnique

        statString = Nothing
        statString = statString & If(MyBase.stats.Item("strength"), "strength:" & MyBase.stats.Item("strength"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("initiative"), "initiative:" & MyBase.stats.Item("initiative"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("intelligence"), "intelligence:" & MyBase.stats.Item("intelligence"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("wisdom"), "wisdom:" & MyBase.stats.Item("wisdom"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Item("dexterity"), "dexterity:" & MyBase.stats.Item("dexterity"), Nothing) & Space(1)
        newRow("minStats") = statString.Trim

        newRow("set") = armorSet
        statString = Nothing
        statString = statString & If(MyBase.stats.Contains("maxHealth"), "maxHealth:" & MyBase.stats.Item("maxHealth"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("armor"), "armor:" & MyBase.stats.Item("armor"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("strength"), "strength:" & MyBase.stats.Item("strength"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("initiative"), "initiative:" & MyBase.stats.Item("initiative"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("intelligence"), "intelligence:" & MyBase.stats.Item("intelligence"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("wisdom"), "wisdom:" & MyBase.stats.Item("wisdom"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("dexterity"), "dexterity:" & MyBase.stats.Item("dexterity"), Nothing) & Space(1)
        newRow("setBonus") = statString.Trim

        statString = Nothing
        statString = statString & If(armorResistances.Contains("fire"), "fire:" & MyBase.stats.Item("fire"), Nothing) & Space(1)
        statString = statString & If(armorResistances.Contains("ice"), "ice:" & MyBase.stats.Item("ice"), Nothing) & Space(1)
        statString = statString & If(armorResistances.Contains("mental"), "mental:" & MyBase.stats.Item("mental"), Nothing) & Space(1)
        statString = statString & If(armorResistances.Contains("death"), "death:" & MyBase.stats.Item("death"), Nothing) & Space(1)
        statString = statString & If(armorResistances.Contains("lightning"), "lightning:" & MyBase.stats.Item("lightning"), Nothing) & Space(1)
        statString = statString & If(armorResistances.Contains("nature"), "nature:" & MyBase.stats.Item("nature"), Nothing) & Space(1)
        statString = statString & If(armorResistances.Contains("divine"), "divine:" & MyBase.stats.Item("divine"), Nothing) & Space(1)
        newRow("resistances") = statString.Trim

        ds.StaticWeapons.Rows.Add(newRow)
        Try
            bs.EndEdit()
            ta.Update(ds.StaticWeapons)
        Catch ex As Exception
            MsgBox("unable to add weapon to database")
        End Try
    End Sub
End Class
