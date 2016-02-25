Public Class ItemWindow
    Private item As Object
    Private creatures As Collection
    Private appliedCreature As Creature

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(item)
        InitializeComponent()

        Me.item = item
        creatures = New Collection
    End Sub

    Public ReadOnly Property creature As Creature
        Get
            Return appliedCreature
        End Get
    End Property

    Private Sub ItemWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaticCreaturesTableAdapter.Fill(GameDatabaseDataSet.StaticCreatures)
        PlayerCreaturesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.PlayerCreatures, currentState.id)

        For Each row As GameDatabaseDataSet.PlayerCreaturesRow In GameDatabaseDataSet.PlayerCreatures
            Dim creature As New Creature(row.id, GameDatabaseDataSet.StaticCreatures.FindByid(row.creatureid))
            If creature.species = item.wearableBy Then
                creatures.Add(creature, creature.id)
            End If
        Next
        Me.Text = item.name
        detailstxt.Text = item.DetailsString
    End Sub

    Private Sub equipbtn_Click(sender As Object, e As EventArgs) Handles equipbtn.Click
        Dim equip As New EquipWindow(creatures)
        Dim result As DialogResult = equip.ShowDialog()
        If result = DialogResult.Yes Then
            appliedCreature = equip.onCreature
            equip.Close()
            Me.DialogResult = DialogResult.Yes
        Else
            equip.Close()
            Me.DialogResult = DialogResult.No
        End If
    End Sub
End Class