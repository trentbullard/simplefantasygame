Public Class Weapon : Inherits Item 'TODO
    Private weaponSlotsPossible As String
    Private weaponWearableBy As String
    Private weaponIsUnique As Boolean
    Private weaponMinStats As Collection
    Private weaponIsRanged As Boolean
    Private weaponIsMagic As Boolean

    Public Sub New()
        MyBase.New()
        Dim names() As String = {"sword", "shield", "hammer", "staff", "wand", "scepter", "tome", "crossbow", "bow", "spear"}
        MyBase.name = names(Roll(10) - 1) & MyBase.id
        weaponIsMagic = False
        weaponIsRanged = False
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
        Dim statNames() As String = {"strength", "initiative", "intelligence", "wisdom", "dexterity", "maxHealth", "armor"}
        Dim stats As New Collection
        stats.Add(Roll(10), statNames(Roll(5) - 1))
        MyBase.stats = stats
        weaponWearableBy = getSpecies()
        weaponIsUnique = If(Roll(2) = 1, True, False)
        If weaponIsUnique Then
            MyBase.name = getName() & "'s" & MyBase.name
        End If
        stats.Clear()
        stats.Add(50 + Roll(50), statNames(Roll(5) - 1))
        stats.Add(50 + Roll(50), statNames(Roll(5) - 1))
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

    Public ReadOnly Property attributes() As Collection
        Get
            Return MyBase.stats
        End Get
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
        Dim attributeString As String = ""
        For Each attribute As String In weaponAttributes
            attributeString = attributeString & " " & attribute
        Next
        Return "weapon " & MyBase.ToString() & attributeString
    End Function

    Public Sub Save(ds As GameDatabaseDataSet,
                    bs As BindingSource,
                    ta As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter)
        Dim newRow As DataRow = ds.StaticWeapons.NewRow
        newRow("name") = MyBase.name
        Dim statString As String = Nothing
        statString = statString & If(MyBase.stats.Item("maxHealth"), "maxHealth:" & MyBase.stats.Item("maxHealth"), Nothing)
        statString = statString & If(MyBase.stats.Item("armor"), "armor:" & MyBase.stats.Item("armor"), Nothing)
        statString = statString & If(MyBase.stats.Item("strength"), "strength:" & MyBase.stats.Item("strength"), Nothing)
        statString = statString & If(MyBase.stats.Item("initiative"), "initiative:" & MyBase.stats.Item("initiative"), Nothing)
        statString = statString & If(MyBase.stats.Item("intelligence"), "intelligence:" & MyBase.stats.Item("intelligence"), Nothing)
        statString = statString & If(MyBase.stats.Item("wisdom"), "wisdom:" & MyBase.stats.Item("wisdom"), Nothing)
        statString = statString & If(MyBase.stats.Item("dexterity"), "dexterity:" & MyBase.stats.Item("dexterity"), Nothing)
        newRow("attributes") = statString
        newRow("slotsPossible") = weaponSlotsPossible
        newRow("wearableBy") = weaponWearableBy
        newRow("isUnique") = weaponIsUnique
        statString = Nothing
        statString = statString & If(MyBase.stats.Item("strength"), "strength:" & MyBase.stats.Item("strength"), Nothing)
        statString = statString & If(MyBase.stats.Item("initiative"), "initiative:" & MyBase.stats.Item("initiative"), Nothing)
        statString = statString & If(MyBase.stats.Item("intelligence"), "intelligence:" & MyBase.stats.Item("intelligence"), Nothing)
        statString = statString & If(MyBase.stats.Item("wisdom"), "wisdom:" & MyBase.stats.Item("wisdom"), Nothing)
        statString = statString & If(MyBase.stats.Item("dexterity"), "dexterity:" & MyBase.stats.Item("dexterity"), Nothing)
        newRow("minStats") = statString
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
