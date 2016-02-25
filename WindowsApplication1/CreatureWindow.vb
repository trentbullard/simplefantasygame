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
        'TODO add staticWeapons
        'TODO add staticAugments
        'TODO add staticJewelry
        'TODO add creatureSkills
        'TODO add staticSkills
        'TODO add ArmorAugments
        'TODO add WeaponAugments
        StaticArmorTableAdapter.Fill(GameDatabaseDataSet.StaticArmor)
        PlayerArmorTableAdapter.FillWithCurrentCreatureArmor(GameDatabaseDataSet.PlayerArmor, currentState.id, creature.id)

        Me.Text = creature.ToString
        nametxt.Text = creature.name
        classtxt.Text = creature.className
        speciestxt.Text = creature.species
        leveltxt.Text = creature.level
        maxHPtxt.Text = creature.maxHP
        healthtxt.Text = creature.health
        armortxt.Text = creature.armor
        strengthtxt.Text = creature.str
        dexteritytxt.Text = creature.dex
        intelligencetxt.Text = creature.int
        initiativetxt.Text = creature.ini
        wisdomtxt.Text = creature.wis

        expbar.Minimum = creature.level ^ 5
        expbar.Maximum = (creature.level + 1) ^ 5
        expbar.Value = creature.exp

        headtip.SetToolTip(headpic, (New Weapon).DetailsString)
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
        GameDatabaseDataSet.PlayerCreatures.FindByid(creature.id).name = nameString
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

    Private Sub headlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles headlbl.LinkClicked
        If headpic Is Nothing Then Exit Sub
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip head item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement head item unequip
            'currentCreature.unequip(headItem)
            'change headItem in database:
            '   remove slotWorn
            '   remove wearerid
            headpic.Image = Nothing
            headtip.RemoveAll()
        End If
    End Sub

    Private Sub dismissbtn_Click(sender As Object, e As EventArgs) Handles dismissbtn.Click
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("are you sure you want to dismiss this creature? it will be gone forever.", style, "confirm dismissal")
        If response = MsgBoxResult.Yes Then
            'TODO implement creature dismiss code
            'unequip all gear
            'delete playerCreature record
            'Dim oldRow As GameDatabaseDataSet.PlayerCreaturesRow = GameDatabaseDataSet.PlayerCreatures.FindByid(creature.id)
            'GameDatabaseDataSet.PlayerCreatures.RemovePlayerCreaturesRow(oldRow)
            'me.close()
        End If
    End Sub
End Class