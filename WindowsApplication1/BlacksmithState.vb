Public Class BlacksmithState
    Private stateid As Integer
    Private stateDateVisited As Date
    Private statePlayerState As PlayerState
    Private stateWeapons As Collection
    Private stateArmor As Collection
    Private stateItems As Collection
    Private stateItemCount As Integer = 0

    Public Sub New()
        stateid = -1
        stateDateVisited = currentState.dateInGame
        statePlayerState = currentState
        stateWeapons = New Collection
        stateArmor = New Collection
        stateItems = New Collection
        stateItemCount = stateItems.Count
    End Sub

    Public Sub New(id As Integer)
        stateid = id
        stateDateVisited = currentState.dateInGame
        statePlayerState = currentState
        stateWeapons = New Collection
        stateArmor = New Collection
        stateItems = New Collection
        stateItems = New Collection
        stateItemCount = stateItems.Count
    End Sub

    Public Sub New(weapons As Collection, armor As Collection)
        stateid = -1
        stateDateVisited = currentState.dateInGame
        statePlayerState = currentState
        stateWeapons = weapons
        stateArmor = armor
        stateItems = New Collection
        For Each weapon In weapons
            stateItems.Add(weapon)
        Next
        For Each armorItem In armor
            stateItems.Add(armorItem)
        Next
        stateItemCount = stateItems.Count
    End Sub

    Public Sub New(row As GameDatabaseDataSet.BlacksmithStatesRow)
        stateid = row.id
        stateDateVisited = row.dateVisted
        statePlayerState = New PlayerState(row.playerStateid)
        stateWeapons = New Collection
        stateArmor = New Collection
        stateItems = New Collection
        stateItems = New Collection
        stateItemCount = stateItems.Count
    End Sub

    Public ReadOnly Property id() As Integer
        Get
            Return stateid
        End Get
    End Property

    Public ReadOnly Property DateVisited() As Date
        Get
            Return stateDateVisited
        End Get
    End Property

    Public ReadOnly Property PlayerState() As PlayerState
        Get
            Return statePlayerState
        End Get
    End Property

    Public Property weapons() As Collection
        Get
            Return stateWeapons
        End Get
        Set(value As Collection)
            stateWeapons = value
            stateItemCount += 1
            stateItems.Add(New Item(stateItemCount), stateItemCount)
        End Set
    End Property

    Public Property armor() As Collection
        Get
            Return stateArmor
        End Get
        Set(value As Collection)
            stateArmor = value
            stateItemCount += 1
            stateItems.Add(New Item(stateItemCount), stateItemCount)
        End Set
    End Property

    Public ReadOnly Property items As Collection
        Get
            Return stateItems
        End Get
    End Property

    Public ReadOnly Property itemCount As Integer
        Get
            Return stateItemCount
        End Get
    End Property
End Class
