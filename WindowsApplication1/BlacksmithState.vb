Public Class BlacksmithState
    Private stateid As Integer
    Private stateDateVisited As Date
    Private statePlayerState As PlayerState
    Private stateWeapons As Collection
    Private stateArmor As Collection

    Public Sub New()
        stateid = -1
        stateDateVisited = currentState.dateInGame
        statePlayerState = currentState
        stateWeapons = New Collection
        stateArmor = New Collection
    End Sub

    Public Sub New(id As Integer)
        stateid = id
        stateDateVisited = currentState.dateInGame
        statePlayerState = currentState
        stateWeapons = New Collection
        stateArmor = New Collection
    End Sub

    Public Sub New(weapons As Collection, armor As Collection)
        stateid = -1
        stateDateVisited = currentState.dateInGame
        statePlayerState = currentState
        stateWeapons = weapons
        stateArmor = armor
    End Sub

    Public Sub New(row As GameDatabaseDataSet.BlacksmithStatesRow)
        stateid = row.id
        stateDateVisited = row.dateVisted
        statePlayerState = New PlayerState(row.playerStateid)
        stateWeapons = New Collection
        stateArmor = New Collection
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
        End Set
    End Property

    Public Property armor() As Collection
        Get
            Return stateArmor
        End Get
        Set(value As Collection)
            stateArmor = value
        End Set
    End Property
End Class
