Public Class Armor : Inherits Item
    Private armorid As Integer

    Public Sub New()
        armorid = -1
    End Sub

    Public Sub New(id As Integer)
        armorid = id
    End Sub
End Class
