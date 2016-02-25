Public Class EquipWindow
    Private creatures As New Collection
    Private creature As Creature

    Public Sub New(creatures As Collection)
        InitializeComponent()

        For Each creation As Creature In creatures
            Me.creatures.Add(creation, CStr(Me.creatures.Count))
        Next
    End Sub

    Public ReadOnly Property onCreature As Creature
        Get
            Return creature
        End Get
    End Property

    Private Sub EquipWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If creatures.Count = 0 Then
            creaturelst.Enabled = False
            creaturelst.Items.Add("you have no creatures that can wear this item")
        Else
            For Each creation As Creature In creatures
                creaturelst.Items.Add(creation.ToString)
            Next
        End If
    End Sub

    Private Sub creaturelst_Click(sender As Object, e As EventArgs) Handles creaturelst.Click
        If creaturelst.SelectedIndices.Count = 0 Then Exit Sub
        If creaturelst.SelectedIndices(0) = -1 Then Exit Sub

        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("are you sure?", style, "confirm equip")
        If response = MsgBoxResult.Yes Then
            creature = creatures(creaturelst.SelectedIndex.ToString)
            Me.DialogResult = DialogResult.Yes
        Else
            Me.DialogResult = DialogResult.No
        End If
    End Sub
End Class