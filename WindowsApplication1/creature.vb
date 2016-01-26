Public Class creature
    Private creatureid As Integer
    Private creatureName As String
    Private creatureSpecies As String
    Private creatureHealth As Integer
    Private creatureStrength As Integer
    Private creatureArmor As Integer

    Public Sub New()
        creatureid = -1
        creatureName = "name"
        creatureSpecies = "species"
        creatureHealth = -1
        creatureStrength = -1
        creatureArmor = -1
    End Sub

    Public Sub New(id, name, species, health, strength, armor)
        creatureid = id
        creatureName = name
        creatureSpecies = species
        creatureHealth = health
        creatureStrength = strength
        creatureArmor = armor
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

    Public Property strength() As Integer
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

    Public Overloads Overrides Function Equals(creature) As Boolean
        If creatureid = creature.creatureid Then
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
        Return "(" & Me.id & ") " & Me.name & " the " & Me.species
    End Function
End Class
