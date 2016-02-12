Public Class Consumable : Inherits Item
    Private consumableAttributes As New Collection
    Private consumableTurns As Integer

    Public Sub New()
        MyBase.New()
        consumableAttributes = New Collection()
        consumableTurns = 1
    End Sub

    Public Sub New(id As Integer)
        MyBase.New(id, currentPlayer, "name")
        consumableAttributes = New Collection
        consumableTurns = 1
    End Sub

    Public Sub New(id As Integer, owner As Player, name As String, attributes As Collection, turns As Integer)
        MyBase.New(id, owner, name)
        For Each stat In attributes
            consumableAttributes.Add(stat)
        Next
        consumableTurns = turns
    End Sub

    Public Overrides ReadOnly Property id() As Integer
        Get
            Return MyBase.id
        End Get
    End Property

    Public Overrides ReadOnly Property owner() As Player
        Get
            Return MyBase.owner
        End Get
    End Property

    Public Overrides Property name() As String
        Get
            Return MyBase.name
        End Get
        Set(value As String)
            MyBase.name = value
        End Set
    End Property

    Public Property attributes() As Collection
        Get
            Return consumableAttributes
        End Get
        Set(value As Collection)
            consumableAttributes = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Dim attributeString As String = ""
        For Each attribute As String In Me.consumableAttributes
            attributeString = attributeString & " " & attribute
        Next
        Return MyBase.ToString() & attributeString
    End Function

    Public Sub use(creature)
        If Me.consumableAttributes.Contains("maxHealth") Then
            creature.health += Me.consumableAttributes.Item("maxHealth")
        End If
        If Me.consumableAttributes.Contains("health") Then
            creature.strength += Me.consumableAttributes.Item("health")
        End If
        If Me.consumableAttributes.Contains("strength") Then
            creature.armor += Me.consumableAttributes.Item("strength")
        End If
        If Me.consumableAttributes.Contains("armor") Then
            creature.armor += Me.consumableAttributes.Item("armor")
        End If
        If Me.consumableAttributes.Contains("initiative") Then
            creature.armor += Me.consumableAttributes.Item("initiative")
        End If
        If Me.consumableAttributes.Contains("intelligence") Then
            creature.armor += Me.consumableAttributes.Item("intelligence")
        End If
        If Me.consumableAttributes.Contains("wisdom") Then
            creature.armor += Me.consumableAttributes.Item("wisdom")
        End If
        If Me.consumableAttributes.Contains("dexterity") Then
            creature.armor += Me.consumableAttributes.Item("dexterity")
        End If
    End Sub
End Class
