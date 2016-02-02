Public Class creature
    Private creatureid As Integer
    Private creatureName As String
    Private creatureSpecies As String
    Private creatureHealth As Integer
    Private creatureStrength As Integer
    Private creatureArmor As Integer
    Private creatureLevel As Integer
    Private creatureExperience As Integer
    Private creatureInitiative As Integer
    Private creatureIntelligence As Integer
    Private creatureWisdom As Integer
    Private creatureDexterity As Integer
    Private creatureOwner As player

    Public Sub New()
        creatureid = -1
        creatureName = "name"
        creatureSpecies = "species"
        creatureHealth = 1
        creatureStrength = 1
        creatureArmor = 1
        creatureLevel = 1
        creatureExperience = 0
        creatureOwner = currentPlayer
    End Sub

    Public Sub New(name As String)
        creatureid = -1
        creatureName = name
        creatureSpecies = "species"
        creatureHealth = 1
        creatureStrength = 1
        creatureArmor = 1
        creatureLevel = 1
        creatureExperience = 0
        creatureOwner = currentPlayer
    End Sub

    Public Sub New(id As Integer, name As String, species As String, health As Integer, strength As Integer, armor As Integer, level As Integer, exp As Integer, owner As player)
        creatureid = id
        creatureName = name
        creatureSpecies = species
        creatureHealth = health
        creatureStrength = strength
        creatureArmor = armor
        creatureLevel = level
        creatureExperience = exp
        creatureOwner = owner
    End Sub

    Public Sub New(row As GameDatabaseDataSet.CreaturesRow)
        creatureid = row("id")
        creatureName = row("name")
        creatureSpecies = row("species")
        creatureHealth = row("health")
        creatureStrength = row("strength")
        creatureArmor = row("armor")
        creatureLevel = row("level")
        creatureExperience = row("experience")
        creatureOwner = currentPlayer
    End Sub

    Public Property id() As Integer
        Get
            Return creatureid
        End Get
        Set(value As Integer)
            creatureid = value
        End Set
    End Property

    Public Property name() As String
        Get
            Return creatureName
        End Get
        Set(value As String)
            creatureName = value
        End Set
    End Property

    Public Property species() As String
        Get
            Return creatureSpecies
        End Get
        Set(value As String)
            creatureName = value
        End Set
    End Property

    Public Property health() As Integer
        Get
            Return creatureHealth
        End Get
        Set(value As Integer)
            creatureHealth = value
        End Set
    End Property

    Public Property str() As Integer
        Get
            Return creatureStrength
        End Get
        Set(value As Integer)
            creatureStrength = value
        End Set
    End Property

    Public Property armor() As Integer
        Get
            Return creatureArmor
        End Get
        Set(value As Integer)
            creatureArmor = value
        End Set
    End Property

    Public Property level() As Integer
        Get
            Return creatureLevel
        End Get
        Set(value As Integer)
            creatureLevel = value
        End Set
    End Property

    Public Property exp() As Integer
        Get
            Return creatureExperience
        End Get
        Set(value As Integer)
            creatureExperience = value
        End Set
    End Property

    Public Property ini() As Integer
        Get
            Return creatureInitiative
        End Get
        Set(value As Integer)
            creatureInitiative = value
        End Set
    End Property

    Public Property int() As Integer
        Get
            Return creatureIntelligence
        End Get
        Set(value As Integer)
            creatureIntelligence = value
        End Set
    End Property

    Public Property wis() As Integer
        Get
            Return creatureWisdom
        End Get
        Set(value As Integer)
            creatureWisdom = value
        End Set
    End Property

    Public Property dex() As Integer
        Get
            Return creatureDexterity
        End Get
        Set(value As Integer)
            creatureDexterity = value
        End Set
    End Property

    Public Property owner() As player
        Get
            Return creatureOwner
        End Get
        Set(value As player)
            creatureOwner = value
        End Set
    End Property

    Public Overloads Overrides Function Equals(creature) As Boolean
        If creatureid = creature.id Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub TakeDamage(damage)
        LogCreatureDamageTaken(Me, damage)
        If damage < creatureHealth Then
            creatureHealth = creatureHealth - damage
        Else
            creatureHealth = 0
            MsgBox(creatureName & " has died.")
            LogCreatureDeath(Me)
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return Me.name & " the level " & Me.creatureLevel & Space(1) & Me.species
    End Function

    Public Sub gainExp(amount)
        creatureExperience += amount
        If creatureExperience > creatureLevel ^ 5 Then
            creatureLevel += 1
        End If
    End Sub
End Class
