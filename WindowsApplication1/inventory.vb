Public Class Inventory
    Private inventoryid As Integer
    Private inventoryOwner As Player
    Private inventoryName As String
    Private inventoryItems As Collection

    Public Sub New()
        inventoryid = -1
        inventoryOwner = New Player()
        inventoryName = "name"
        inventoryItems = New Collection()
    End Sub

    Public Sub New(id, owner, name, items)
        inventoryid = id
        inventoryOwner = owner
        inventoryName = name
        inventoryItems = items
    End Sub

    Public Property id()
        Get
            Return inventoryid
        End Get
        Set(value)
            inventoryid = value
        End Set
    End Property

    Public Property owner()
        Get
            Return inventoryOwner
        End Get
        Set(value)
            inventoryOwner = value
        End Set
    End Property

    Public Property name()
        Get
            Return inventoryName
        End Get
        Set(value)
            inventoryName = value
        End Set
    End Property

    Public Property items()
        Get
            Return inventoryItems
        End Get
        Set(value)
            inventoryItems = value
        End Set
    End Property
End Class
