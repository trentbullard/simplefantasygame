Public Class Weapon : Inherits Item 'TODO
    Private weaponSlotsPossible As String
    Private weaponWearableBy As String
    Private weaponIsUnique As Boolean
    Private weaponMinStats As New Collection
    Private weaponIsRanged As Boolean
    Private weaponIsMagic As Boolean

    Public Sub New()
        MyBase.New()
        MyBase.name = getWeaponName() & MyBase.id
        weaponIsMagic = False
        weaponIsRanged = False
        weaponIsUnique = False
        weaponSlotsPossible = "1 2"
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
        Dim stats As New Collection
        stats.Add(Roll(10), getEquipStatName())
        MyBase.stats = stats
        weaponWearableBy = getSpecies()
        If Roll(10) = 1 Then
            weaponIsUnique = True
            MyBase.name = getCreatureName() & "'s " & MyBase.name
        End If
        stats.Clear()
        Dim stat1 = getEquipStatName()
        stats.Add(50 + Roll(50), stat1)
        Dim stat2 As String = stat1
        Do Until stat2 <> stat1
            stat2 = getEquipStatName()
        Loop
        stats.Add(50 + Roll(50), stat2)
        weaponMinStats = stats
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
            Return weaponSlotsPossible
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
                    ta As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter)
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
        newRow("slotsPossible") = weaponSlotsPossible
        newRow("wearableBy") = weaponWearableBy
        newRow("isUnique") = weaponIsUnique
        statString = Nothing
        statString = statString & If(MyBase.stats.Contains("strength"), "strength:" & MyBase.stats.Item("strength"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("initiative"), "initiative:" & MyBase.stats.Item("initiative"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("intelligence"), "intelligence:" & MyBase.stats.Item("intelligence"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("wisdom"), "wisdom:" & MyBase.stats.Item("wisdom"), Nothing) & Space(1)
        statString = statString & If(MyBase.stats.Contains("dexterity"), "dexterity:" & MyBase.stats.Item("dexterity"), Nothing) & Space(1)
        newRow("minStats") = statString.Trim
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
