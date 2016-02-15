Public Class Armor : Inherits Item 'TODO
    Private armorAttributes As New Collection

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(id As Integer)
        MyBase.New(id)
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

    Public ReadOnly Property attributes() As Collection
        Get
            Return armorAttributes
        End Get
    End Property

    Public Overrides Function ToString() As String
        Dim attributeString As String = ""
        For Each attribute As String In armorAttributes
            attributeString = attributeString & " " & attribute
        Next
        Return "armor " & MyBase.ToString() & attributeString
    End Function
End Class
