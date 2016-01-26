Public Class item
    Private itemid As Integer
    Private itemOwner As player
    Private itemName As String
    Private itemInventory As inventory

    Public Sub New()
        itemid = -1
        itemOwner = New player()
        itemName = "name"
        itemInventory = New inventory()
    End Sub

    Public Sub New(id, owner, name, inventory)
        itemid = id
        itemOwner = owner
        itemName = name
    End Sub

    Public Overridable Property id()
        Get
            Return itemid
        End Get
        Set(value)
            itemid = value
        End Set
    End Property

    Public Overridable Property owner()
        Get
            Return itemOwner
        End Get
        Set(value)
            itemOwner = value
        End Set
    End Property

    Public Overridable Property name()
        Get
            Return itemName
        End Get
        Set(value)
            itemName = value
        End Set
    End Property

    Public Overridable Sub use(creature)
    End Sub

    Public Overrides Function ToString() As String
        Return "(" & Me.id & ") " & Me.name
    End Function
End Class
