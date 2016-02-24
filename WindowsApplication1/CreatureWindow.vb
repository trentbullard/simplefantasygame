Public Class CreatureWindow
    Private creature As Creature

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(creature As Creature)
        InitializeComponent()
        Me.creature = creature
    End Sub

    Private Sub CreatureWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayerCreaturesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.PlayerCreatures, currentState.id)

        Me.Text = creature.ToString
        nametxt.Text = creature.name
        classtxt.Text = creature.className
        speciestxt.Text = creature.species
        leveltxt.Text = creature.level
        experiencetxt.Text = creature.exp
        maxHPtxt.Text = creature.maxHP
        healthtxt.Text = creature.health
        armortxt.Text = creature.armor
        strengthtxt.Text = creature.str
        dexteritytxt.Text = creature.dex
        intelligencetxt.Text = creature.int
        initiativetxt.Text = creature.ini
        wisdomtxt.Text = creature.wis
    End Sub

    Private Sub namelbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles namelbl.LinkClicked
        Dim nameString As String = InputBox("enter a name",, creature.name)
        If String.IsNullOrWhiteSpace(nameString) Then
            MsgBox("Name cannot be blank.")
            Exit Sub
        End If

        'Called from Names.vb
        'Converts any string into a proper-cased trimmed string
        nameString = ProperCase(nameString)

        creature.name = nameString
        Me.Text = creature.ToString
        nametxt.Text = nameString
        GameDatabaseDataSet.PlayerCreatures.Item(creature.id - 1).name = nameString
        PlayerCreaturesTableAdapter.Update(GameDatabaseDataSet.PlayerCreatures)
    End Sub

    Private Sub classlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles classlbl.LinkClicked
        Dim nameString As String = InputBox("enter a name",, creature.className)

        'Called from Names.vb
        'Converts any string into a proper-cased trimmed string
        nameString = ProperCase(nameString)

        creature.className = nameString
        classtxt.Text = nameString
        'GameDatabaseDataSet.PlayerCreatures.Item(creature.id).className = nameString TODO
        'PlayerCreaturesTableAdapter.Update(GameDatabaseDataSet.PlayerCreatures)
    End Sub
End Class