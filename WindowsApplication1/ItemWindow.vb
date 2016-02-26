Public Class ItemWindow
    Private item As Object
    Private properCreatures As Collection
    Private appliedCreature As Creature

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(item)
        InitializeComponent()

        Me.item = item
        properCreatures = New Collection
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
            Dim creature As New Creature(row.id, row.name, GameDatabaseDataSet.StaticCreatures.FindByid(row.creatureid))
            If CanBeWornBy(creature) Then
                properCreatures.Add(creature, creature.id)
            End If
        Next
        Me.Text = item.name
        detailstxt.Text = item.DetailsString
    End Sub

    Private Sub equipbtn_Click(sender As Object, e As EventArgs) Handles equipbtn.Click
        Dim equip As New EquipWindow(properCreatures)
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

    Private Function CanBeWornBy(creature As Creature) As Boolean
        If creature.species = item.wearableBy Then
            For ctr1 = 0 To 4
                If item.minStats.Contains(statList(ctr1)) Then
                    For ctr2 = 1 + ctr1 To 4
                        If item.minStats.Contains(statList(ctr2)) Then
                            If creature.statsCol(statList(ctr1)) >= item.minStats(statList(ctr1)) And
                                creature.statsCol(statList(ctr2)) >= item.minStats(statList(ctr2)) Then
                                Return True
                            End If
                        End If
                    Next
                End If
            Next
        End If
        Return False
    End Function
End Class