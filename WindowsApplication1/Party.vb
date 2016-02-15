Public Class Party
    Private partyid As Integer
    Private partyOwner As Player
    Private partyName As String
    Private partyMembers As Collection

    Public Sub New()
        partyid = -1
        partyOwner = currentPlayer
        partyName = "name"
        partyMembers = New Collection
    End Sub

    Public Sub New(id As Integer)
        partyid = id
        partyOwner = currentPlayer
        partyName = "name"
        partyMembers = New Collection
    End Sub

    Public Sub New(id As Integer, owner As Player, name As String, members As Collection)
        partyid = id
        partyOwner = owner
        partyName = name
        partyMembers = members
    End Sub

    Public Sub New(dataRow As GameDatabaseDataSet.PlayerPartiesRow)
        partyid = dataRow("id")
        If dataRow("playerid") = currentPlayer.id Then
            partyOwner = currentPlayer
        Else
            partyOwner = New Player(CInt(dataRow("playerid")))
        End If
        partyName = dataRow("name")
        partyMembers = New Collection
        For ctr = 0 To 3
            Select Case ctr
                Case 0
                    If dataRow("slot1id") IsNot DBNull.Value Then
                        partyMembers.Add(New Creature(CInt(dataRow("slot1id"))))
                    End If
                Case 1
                    If dataRow("slot2id") IsNot DBNull.Value Then
                        partyMembers.Add(New Creature(CInt(dataRow("slot2id"))))
                    End If
                Case 2
                    If dataRow("slot3id") IsNot DBNull.Value Then
                        partyMembers.Add(New Creature(CInt(dataRow("slot3id"))))
                    End If
                Case 3
                    If dataRow("slot4id") IsNot DBNull.Value Then
                        partyMembers.Add(New Creature(CInt(dataRow("slot4id"))))
                    End If
            End Select
        Next
    End Sub

    Public Property id() As Integer
        Get
            Return partyid
        End Get
        Set(value As Integer)
            partyid = value
        End Set
    End Property

    Public Property owner() As Player
        Get
            Return partyOwner
        End Get
        Set(value As Player)
            partyOwner = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return partyName
        End Get
        Set(value As String)
            partyName = value
        End Set
    End Property

    Public Property members() As Collection
        Get
            Return partyMembers
        End Get
        Set(value As Collection)
            partyMembers = value
        End Set
    End Property
End Class
