Imports WindowsApplication1

Public Class TavernState
    Private tavernStateid As Integer
    Private tavernStatePlayerState As PlayerState
    Private tavernStateHires(4) As Creature
    Private tavernStateQuests(4) As Quest

    Public Sub New()
        tavernStateid = -1
        tavernStatePlayerState = New PlayerState
        tavernStateHires = Nothing
        tavernStateQuests = Nothing
    End Sub

    Public Sub New(id As Integer)
        tavernStateid = id
        tavernStatePlayerState = New PlayerState
        tavernStateHires = Nothing
        tavernStateQuests = Nothing
    End Sub

    Public Sub New(state As PlayerState)
        tavernStateid = -1
        tavernStatePlayerState = state
        tavernStateHires = Nothing
        tavernStateQuests = Nothing
    End Sub

    Public Sub New(row As GameDatabaseDataSet.TavernStatesRow, creatures As Creature(), quests As Quest())
        tavernStateid = row("id")
        If row("playerStateid") = currentState.id Then
            tavernStatePlayerState = currentState
        Else
            Dim stateid As Integer = row("playerStateid")
            tavernStatePlayerState = New PlayerState(stateid)
        End If
        tavernStateHires = creatures
        tavernStateQuests = quests
    End Sub

    Public Sub New(id As Integer, state As PlayerState, creatures As Creature(), quests As Quest())
        tavernStateid = id
        tavernStatePlayerState = state
        tavernStateHires = creatures
        tavernStateQuests = quests
    End Sub

    Public ReadOnly Property id As Integer
        Get
            Return tavernStateid
        End Get
    End Property

    Public Property playerState As PlayerState
        Get
            Return tavernStatePlayerState
        End Get
        Set(value As PlayerState)
            tavernStatePlayerState = value
        End Set
    End Property

    Public Property hires As Creature()
        Get
            Return tavernStateHires
        End Get
        Set(value As Creature())
            tavernStateHires = value
        End Set
    End Property

    Public Property quests As Quest()
        Get
            Return tavernStateQuests
        End Get
        Set(value As Quest())
            tavernStateQuests = value
        End Set
    End Property
End Class
