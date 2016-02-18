Public Class MarketWindow
    Private Sub MarketWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub blacksmithbtn_Click(sender As Object, e As EventArgs) Handles blacksmithbtn.Click
        currentState.blacksmithwindow = New BlacksmithWindow
        currentState.blacksmithwindow.Show()
        Me.Close()
    End Sub

    Private Sub farmerbtn_Click(sender As Object, e As EventArgs) Handles farmerbtn.Click
    End Sub

    Private Sub scholarbtn_Click(sender As Object, e As EventArgs) Handles scholarbtn.Click
    End Sub

    Private Sub chemistbtn_Click(sender As Object, e As EventArgs) Handles chemistbtn.Click
    End Sub

    Private Sub playerInfobtn_Click(sender As Object, e As EventArgs) Handles playerInfobtn.Click
    End Sub

    Private Sub mainMenubtn_Click(sender As Object, e As EventArgs) Handles mainMenubtn.Click
        OpenMainMenu()
    End Sub
End Class