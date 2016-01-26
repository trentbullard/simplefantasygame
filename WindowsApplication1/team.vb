Public Class team
    Private teamid As Integer
    Private teamOwner As player
    Private teamName As String
    Private teamMembers As Collection

    Public Sub New()
        teamid = -1
        teamOwner = New player()
        teamName = "name"
        teamMembers = New Collection()
    End Sub

    Public Sub New(id, owner, name, team)
        teamid = id
        teamOwner = owner
        teamName = name
        teamMembers = team
    End Sub

    Public Property id()
        Get
            Return teamid
        End Get
        Set(value)
            teamid = value
        End Set
    End Property

    Public Property owner()
        Get
            Return teamOwner
        End Get
        Set(value)
            teamOwner = value
        End Set
    End Property

    Public Property name()
        Get
            Return teamName
        End Get
        Set(value)
            teamName = value
        End Set
    End Property

    Public Property members()
        Get
            Return teamMembers
        End Get
        Set(value)
            teamMembers = value
        End Set
    End Property
End Class
