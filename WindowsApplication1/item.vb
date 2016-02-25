Public Class Item
    Private itemid As Integer
    Private itemOwner As Player
    Private itemName As String
    Private itemAttributes As New Collection
    Private itemCost As Integer
    Private itemStoreIndex As Integer

    Public Sub New()
        itemid = -1
        itemOwner = currentPlayer
        itemName = "item"
        itemCost = 1
    End Sub

    Public Sub New(id As Integer)
        itemid = id
        itemOwner = currentPlayer
        itemName = "item"
        itemAttributes = New Collection
        itemCost = 1
    End Sub

    Public Sub New(id As Integer, owner As Player, name As String)
        itemid = id
        itemOwner = owner
        itemName = name
        itemAttributes = New Collection
        itemCost = 1
    End Sub

    Public Overridable ReadOnly Property id() As Integer
        Get
            Return itemid
        End Get
    End Property

    Public Overridable ReadOnly Property owner() As Player
        Get
            Return itemOwner
        End Get
    End Property

    Public Overridable Property name() As String
        Get
            Return itemName
        End Get
        Set(value As String)
            itemName = value
        End Set
    End Property

    Public Overridable Property stats() As Collection
        Get
            Return itemAttributes
        End Get
        Set(value As Collection)
            itemAttributes = value
        End Set
    End Property

    Public Overridable Property cost As Integer
        Get
            Return itemCost
        End Get
        Set(value As Integer)
            itemCost = value
        End Set
    End Property

    Public Overridable Property index As Integer
        Get
            Return itemStoreIndex
        End Get
        Set(value As Integer)
            itemStoreIndex = value
        End Set
    End Property

    Public Overridable Function DetailsString() As String
    End Function

    Public Overridable ReadOnly Property wearableBy() As String
        Get
            Return Nothing
        End Get
    End Property

    Public Overrides Function ToString() As String
        Return Me.name & Space(1) & Me.id
    End Function

End Class
