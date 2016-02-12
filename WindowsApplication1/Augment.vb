Public Class Augment : Inherits Item
    Private augmentid As Integer

    Public Sub New()
        augmentid = -1
    End Sub

    Public Sub New(id As Integer)
        augmentid = id
    End Sub
End Class
