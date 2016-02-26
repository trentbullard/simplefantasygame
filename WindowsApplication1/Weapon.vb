Public Class Weapon : Inherits Item
    Private weaponSlotsPossible As String
    Private weaponWearableBy As String
    Private weaponIsUnique As Boolean
    Private weaponMinStats As New Collection
    Private weaponIsRanged As Boolean
    Private weaponIsMagic As Boolean

    Public Sub New()
        MyBase.New()
        MyBase.name = getWeaponName()
        weaponIsMagic = False
        weaponIsRanged = False
        weaponIsUnique = False
        weaponSlotsPossible = "1 2"
        weaponWearableBy = "gnome"

        Select Case MyBase.name
            Case "staff"
                If Roll(2) = 1 Then
                    weaponIsRanged = True
                    weaponIsMagic = True
                End If
            Case "wand"
                weaponIsRanged = True
                weaponIsMagic = True
            Case "scepter"
                weaponIsRanged = True
                weaponIsMagic = True
            Case "crossbow"
                weaponIsRanged = True
                weaponSlotsPossible = "1"
            Case "bow"
                weaponIsRanged = True
                weaponSlotsPossible = "1"
            Case "tome"
                weaponIsMagic = True
            Case "shield"
                weaponSlotsPossible = "2"
        End Select

        MyBase.stats.Add(Roll(10), getEquipStatName())

        If Roll(10) = 1 Then
            weaponIsUnique = True
            MyBase.name = getCreatureName() & "'s " & MyBase.name
        End If

        Dim stat1 = If(Roll(2) = 1, "strength", "intelligence")
        weaponMinStats.Add(60, stat1)
        Dim stat2 As String = If(Roll(2) = 1, "dexterity", "wisdom")
        'Do Until stat2 <> stat1
        '    stat2 = getCoreStatName()
        'Loop
        weaponMinStats.Add(60, stat2)
    End Sub

    Public Sub New(id As Integer)
        MyBase.New(id)
    End Sub

    Public Sub New(row As GameDatabaseDataSet.StaticWeaponsRow)
        MyBase.New(row.id, currentPlayer, row.name)
        weaponIsRanged = row.isRanged
        weaponIsMagic = row.isMagic
        weaponIsUnique = row.isUnique
        weaponSlotsPossible = row.slotsPossible
        weaponWearableBy = row.wearableBy

        Dim statsArray() As String = row.attributes.Split(" "c)
        For Each stat In statsArray
            Dim statArray() As String = stat.Split(":"c)
            MyBase.stats.Add(CInt(statArray(1)), statArray(0))
        Next

        statsArray = row.minStats.Split(" "c)
        For Each stat In statsArray
            Dim statArray() As String = stat.Split(":"c)
            weaponMinStats.Add(CInt(statArray(1)), statArray(0))
        Next
    End Sub

    Public Sub New(id As Integer, row As GameDatabaseDataSet.StaticWeaponsRow)
        MyBase.New(id, currentPlayer, row.name)
        weaponIsRanged = row.isRanged
        weaponIsMagic = row.isMagic
        weaponIsUnique = row.isUnique
        weaponSlotsPossible = row.slotsPossible
        weaponWearableBy = row.wearableBy

        Dim statsArray() As String = row.attributes.Split(" "c)
        For Each stat In statsArray
            Dim statArray() As String = stat.Split(":"c)
            MyBase.stats.Add(CInt(statArray(1)), statArray(0))
        Next

        statsArray = row.minStats.Split(" "c)
        For Each stat In statsArray
            Dim statArray() As String = stat.Split(":"c)
            weaponMinStats.Add(CInt(statArray(1)), statArray(0))
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

    Public ReadOnly Property slots As String()
        Get
            Dim slotArray As String() = weaponSlotsPossible.Split(" ")
            Return slotArray
        End Get
    End Property

    Public ReadOnly Property isUnique As Boolean
        Get
            Return weaponIsUnique
        End Get
    End Property

    Public ReadOnly Property minStats As Collection
        Get
            Return weaponMinStats
        End Get
    End Property

    Public ReadOnly Property isRanged As Boolean
        Get
            Return weaponIsRanged
        End Get
    End Property

    Public Property isMagic As Boolean
        Get
            Return weaponIsMagic
        End Get
        Set(value As Boolean)
            weaponIsMagic = value
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

    Public ReadOnly Property wearableBy() As String
        Get
            Return weaponWearableBy
        End Get
    End Property

    Public Overrides Property index As Integer
        Get
            Return MyBase.index
        End Get
        Set(value As Integer)
            MyBase.index = value
        End Set
    End Property

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

    Public Function DetailsString() As String
        Dim detailString As String = Nothing
        detailString = MyBase.name & vbCrLf
        detailString = detailString & If(weaponIsUnique, "unique" & vbCrLf, Nothing)
        detailString = detailString & If(weaponIsRanged, "ranged" & vbCrLf, Nothing)
        detailString = detailString & If(weaponIsMagic, "magic" & vbCrLf, Nothing)
        Dim statsString As String = Nothing
        statsString = statsString & If(MyBase.stats.Contains("maxHealth"), "max HP:" & MyBase.stats.Item("maxHealth") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("armor"), "armor: " & MyBase.stats.Item("armor") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("strength"), "str: " & MyBase.stats.Item("strength") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("initiative"), "ini: " & MyBase.stats.Item("initiative") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("intelligence"), "int: " & MyBase.stats.Item("intelligence") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("wisdom"), "wis: " & MyBase.stats.Item("wisdom") & Space(1), Nothing)
        statsString = statsString & If(MyBase.stats.Contains("dexterity"), "dex: " & MyBase.stats.Item("dexterity") & Space(1), Nothing)
        detailString = detailString & statsString & vbCrLf
        Dim slotArray As String() = weaponSlotsPossible.Split(" "c)
        Dim slotString As String = Nothing
        For Each slot As Integer In slotArray
            Select Case slot
                Case 1
                    slotString = slotString & "primary" & Space(1)
                Case 2
                    slotString = slotString & "secondary" & Space(1)
            End Select
        Next
        detailString = detailString & "equipable on: " & slotString.Trim & vbCrLf
        detailString = detailString & "usable by: " & weaponWearableBy & vbCrLf
        statsString = Nothing
        statsString = statsString & If(weaponMinStats.Contains("strength"), "str: " & weaponMinStats.Item("strength") & Space(1), Nothing)
        statsString = statsString & If(weaponMinStats.Contains("initiative"), "ini: " & weaponMinStats.Item("initiative") & Space(1), Nothing)
        statsString = statsString & If(weaponMinStats.Contains("intelligence"), "int: " & weaponMinStats.Item("intelligence") & Space(1), Nothing)
        statsString = statsString & If(weaponMinStats.Contains("wisdom"), "wis: " & weaponMinStats.Item("wisdom") & Space(1), Nothing)
        statsString = statsString & If(weaponMinStats.Contains("dexterity"), "dex: " & weaponMinStats.Item("dexterity") & Space(1), Nothing)
        detailString = detailString & "minimum stats: " & statsString & vbCrLf
        detailString = detailString & "cost: " & Me.cost
        Return detailString
    End Function

    Public Sub Save(ds As GameDatabaseDataSet,
                    bs As BindingSource,
                    ta As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter)
        Dim newRow As DataRow = ds.StaticWeapons.NewRow
        newRow("name") = MyBase.name
        Dim statString As String = Nothing
        statString = statString & If(MyBase.stats.Contains("maxHealth"), "maxHealth:" & MyBase.stats.Item("maxHealth") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("armor"), "armor:" & MyBase.stats.Item("armor") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("strength"), "strength:" & MyBase.stats.Item("strength") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("initiative"), "initiative:" & MyBase.stats.Item("initiative") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("intelligence"), "intelligence:" & MyBase.stats.Item("intelligence") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("wisdom"), "wisdom:" & MyBase.stats.Item("wisdom") & Space(1), Nothing)
        statString = statString & If(MyBase.stats.Contains("dexterity"), "dexterity:" & MyBase.stats.Item("dexterity") & Space(1), Nothing)
        If statString IsNot Nothing Then
            newRow("attributes") = statString.Trim
        Else
            newRow("attributes") = DBNull.Value
        End If
        newRow("slotsPossible") = weaponSlotsPossible
        newRow("wearableBy") = weaponWearableBy
        newRow("isUnique") = weaponIsUnique
        statString = Nothing
        statString = statString & If(weaponMinStats.Contains("strength"), "strength:" & weaponMinStats.Item("strength") & Space(1), Nothing)
        statString = statString & If(weaponMinStats.Contains("initiative"), "initiative:" & weaponMinStats.Item("initiative") & Space(1), Nothing)
        statString = statString & If(weaponMinStats.Contains("intelligence"), "intelligence:" & weaponMinStats.Item("intelligence") & Space(1), Nothing)
        statString = statString & If(weaponMinStats.Contains("wisdom"), "wisdom:" & weaponMinStats.Item("wisdom") & Space(1), Nothing)
        statString = statString & If(weaponMinStats.Contains("dexterity"), "dexterity:" & weaponMinStats.Item("dexterity") & Space(1), Nothing)
        If statString IsNot Nothing Then
            newRow("minStats") = statString.Trim
        Else
            newRow("minStats") = DBNull.Value
        End If
        newRow("isRanged") = weaponIsRanged
        newRow("isMagic") = weaponIsMagic
        ds.StaticWeapons.Rows.Add(newRow)
        Try
            bs.EndEdit()
            ta.Update(ds.StaticWeapons)
        Catch ex As Exception
            MsgBox("unable to add weapon to database")
        End Try
    End Sub
End Class
