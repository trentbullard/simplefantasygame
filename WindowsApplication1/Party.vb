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
