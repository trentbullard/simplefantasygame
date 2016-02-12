Public Class Camp
    Private campid As Integer
    Private campSpecies As String
    Private campMinLevel As Integer
    Private campMaxLevel As Integer

    Public Property id As Integer
        Get
            Return campid
        End Get
        Set(value As Integer)
            campid = value
        End Set
    End Property

    Public Property species As String
        Get
            Return campSpecies
        End Get
        Set(value As String)
            campSpecies = value
        End Set
    End Property

    Public Property minLevel As Integer
        Get
            Return campMinLevel
        End Get
        Set(value As Integer)
            campMinLevel = value
        End Set
    End Property

    Public Property maxLevel As Integer
        Get
            Return campMaxLevel
        End Get
        Set(value As Integer)
            campMaxLevel = value
        End Set
    End Property
End Class
