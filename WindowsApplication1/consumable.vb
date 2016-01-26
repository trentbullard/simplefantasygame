Public Class consumable : Inherits item
    Private consumableAttributes As New Collection

    Public Sub New()
        Me.consumableAttributes = New Collection()
    End Sub

    Public Sub New(id, owner, name, attributes)
        Me.id = id
        Me.owner = owner
        Me.name = name
        consumableAttributes.Add(attributes(0), attributes(1))
    End Sub

    Public Overrides Property id()
        Get
            Return MyBase.id
        End Get
        Set(value As Object)
            MyBase.id = value
        End Set
    End Property

    Public Overrides Property owner As Object
        Get
            Return MyBase.owner
        End Get
        Set(value As Object)
            MyBase.owner = value
        End Set
    End Property

    Public Overrides Property name As Object
        Get
            Return MyBase.name
        End Get
        Set(value As Object)
            MyBase.name = value
        End Set
    End Property

    Public Property attributes()
        Get
            Return consumableAttributes
        End Get
        Set(value)
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

    Public Overrides Sub use(creature)
        If Me.consumableAttributes.Contains("health") Then
            creature.health += Me.consumableAttributes.Item("health")
        End If
        If Me.consumableAttributes.Contains("strength") Then
            creature.strength += Me.consumableAttributes.Item("strength")
        End If
        If Me.consumableAttributes.Contains("armor") Then
            creature.armor += Me.consumableAttributes.Item("armor")
        End If
    End Sub
End Class
