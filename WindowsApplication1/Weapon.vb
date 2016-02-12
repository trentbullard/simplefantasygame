Public Class Weapon : Inherits Item
    Private weaponid As Integer

    Public Sub New()
        weaponid = -1
    End Sub

    Public Sub New(id As Integer)
        weaponid = id
    End Sub
End Class
