Public Class TavernState
    Private tavernStateid As Integer
    Private tavernStatePlayerState As PlayerState
    Private tavernStateHires(4) As Creature
    Private tavernStateQuests(3) As Quest
    Private tavernStateDateVisited As Date = "1/1/1000"

    Public Sub New()
        tavernStateid = -1
        tavernStatePlayerState = currentState
        tavernStateDateVisited = currentState.dateInGame
    End Sub

    Public Sub New(id As Integer)
        tavernStateid = id
        tavernStatePlayerState = currentState
        tavernStateDateVisited = currentState.dateInGame
    End Sub

    Public Sub New(state As PlayerState)
        tavernStateid = -1
        tavernStatePlayerState = state
        tavernStateDateVisited = state.dateInGame
    End Sub

    Public Sub New(row As GameDatabaseDataSet.TavernStatesRow)
        tavernStateid = row("id")
        tavernStatePlayerState = currentState
        For ctr = 0 To 3
            Select Case ctr
                Case 0
                    If row("hireSlot1id") IsNot DBNull.Value Then
                        tavernStateHires(ctr) = New Creature(CInt(row("hireSlot1id")))
                    Else
                        tavernStateHires(ctr) = Nothing
                    End If
                Case 1
                    If row("hireSlot2id") IsNot DBNull.Value Then
                        tavernStateHires(ctr) = New Creature(CInt(row("hireSlot2id")))
                    Else
                        tavernStateHires(ctr) = Nothing
                    End If
                Case 2
                    If row("hireSlot3id") IsNot DBNull.Value Then
                        tavernStateHires(ctr) = New Creature(CInt(row("hireSlot3id")))
                    Else
                        tavernStateHires(ctr) = Nothing
                    End If
                Case 3
                    If row("hireSlot4id") IsNot DBNull.Value Then
                        tavernStateHires(ctr) = New Creature(CInt(row("hireSlot4id")))
                    Else
                        tavernStateHires(ctr) = Nothing
                    End If
            End Select
        Next
        tavernStateDateVisited = row("dateVisited")
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

    Public ReadOnly Property dateVisited() As DateTime
        Get
            Return tavernStateDateVisited
        End Get
    End Property

    Public Sub FillHires(creaturesTable As GameDatabaseDataSet.StaticCreaturesDataTable)
        Dim ctr As Integer = 0
        For Each row In creaturesTable
            tavernStateHires(ctr) = New Creature(row)
            ctr += 1
        Next
    End Sub

    Public Sub FillQuests(questsTable As GameDatabaseDataSet.StaticQuestsDataTable)
        Dim ctr As Integer = 0
        For Each row In questsTable
            tavernStateQuests(ctr) = New Quest(row)
            ctr += 1
        Next
    End Sub

    Public Sub changeDate(amount As TimeSpan)
        If amount < TimeSpan.Zero Then
            tavernStateDateVisited = tavernStateDateVisited.Subtract(amount)
        Else
            tavernStateDateVisited = tavernStateDateVisited.Add(amount)
        End If
    End Sub
End Class
