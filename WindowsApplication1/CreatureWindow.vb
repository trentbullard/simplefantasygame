Public Class CreatureWindow
    Private creature As Creature
    Private itemIndexCol As New Collection
    Private slotStringArray As String() = {"head",
                                           "shoulders",
                                           "sleeves",
                                           "hands",
                                           "feet",
                                           "back",
                                           "chest",
                                           "waist",
                                           "legs",
                                           "shins",
                                           "primary",
                                           "secondary"}

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(creature As Creature)
        InitializeComponent()
        Me.creature = creature
    End Sub

    Private Sub CreatureWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StaticWeaponsTableAdapter.Fill(GameDatabaseDataSet.StaticWeapons)
        StaticArmorTableAdapter.Fill(GameDatabaseDataSet.StaticArmor)
        StaticAugmentsTableAdapter.Fill(GameDatabaseDataSet.StaticAugments)
        'TODO add staticSkills
        'TODO add staticJewelry
        PlayerCreaturesTableAdapter.FillByPlayerStateid(GameDatabaseDataSet.PlayerCreatures, currentState.id)
        PlayerArmorTableAdapter.FillWithCurrentCreatureArmor(GameDatabaseDataSet.PlayerArmor, currentState.id, creature.id)
        PlayerWeaponsTableAdapter.FillWithCurrentCreatureWeapons(GameDatabaseDataSet.PlayerWeapons, currentState.id, creature.id)
        'TODO add ArmorAugments
        'TODO add WeaponAugments
        'TODO add creatureSkills

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

        For Each row As GameDatabaseDataSet.PlayerArmorRow In GameDatabaseDataSet.PlayerArmor
            Dim armorItem As Armor = New Armor(row.id, GameDatabaseDataSet.StaticArmor.FindByid(row.armorid))
            Select Case row.slotWorn
                Case 1
                    headpic.Image = simplefantasygame.My.Resources.Resources.helmet
                    headtip.SetToolTip(headpic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
                Case 2
                    shoulderspic.Image = simplefantasygame.My.Resources.Resources.spaulders
                    shoulderstip.SetToolTip(shoulderspic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
                Case 3
                    sleevespic.Image = simplefantasygame.My.Resources.Resources.sleeves
                    sleevestip.SetToolTip(sleevespic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
                Case 4
                    handspic.Image = simplefantasygame.My.Resources.Resources.gauntlet
                    handstip.SetToolTip(handspic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
                Case 5
                    feetpic.Image = simplefantasygame.My.Resources.Resources.boots
                    feettip.SetToolTip(feetpic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
                Case 6
                    backpic.Image = simplefantasygame.My.Resources.Resources.cape
                    backtip.SetToolTip(backpic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
                Case 7
                    chestpic.Image = simplefantasygame.My.Resources.Resources.breastplate
                    chesttip.SetToolTip(chestpic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
                Case 8
                    waistpic.Image = simplefantasygame.My.Resources.Resources.belt
                    waisttip.SetToolTip(waistpic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
                Case 9
                    legspic.Image = simplefantasygame.My.Resources.Resources.pants
                    legstip.SetToolTip(legspic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
                Case 10
                    shinspic.Image = simplefantasygame.My.Resources.Resources.greaves
                    shinstip.SetToolTip(shinspic, armorItem.DetailsString)
                    itemIndexCol.Add(armorItem.id, slotStringArray(row.slotWorn - 1))
            End Select
        Next

        For Each row As GameDatabaseDataSet.PlayerWeaponsRow In GameDatabaseDataSet.PlayerWeapons
            Dim weapon As Weapon = New Weapon(row.id, GameDatabaseDataSet.StaticWeapons.FindByid(row.weaponid))
            itemIndexCol.Add(weapon.id, slotStringArray(row.slotWorn + 9))
            Select Case row.slotWorn
                Case 1
                    primarytip.SetToolTip(primarypic, weapon.DetailsString)
                    If weapon.name.Contains("sword") Then
                        primarypic.Image = simplefantasygame.My.Resources.Resources.sword
                    ElseIf weapon.name.Contains("axe") Then
                        primarypic.Image = simplefantasygame.My.Resources.Resources.axe
                    ElseIf weapon.name.Contains("shield") Then
                        'primarypic.Image = simplefantasygame.My.Resources.Resources.shield
                    ElseIf weapon.name.Contains("hammer") Then
                        'primarypic.Image = simplefantasygame.My.Resources.Resources.hammer
                    ElseIf weapon.name.Contains("staff") Then
                        'primarypic.Image = simplefantasygame.My.Resources.Resources.staff
                    ElseIf weapon.name.Contains("wand") Then
                        'primarypic.Image = simplefantasygame.My.Resources.Resources.wand
                    ElseIf weapon.name.Contains("scepter") Then
                        'primarypic.Image = simplefantasygame.My.Resources.Resources.scepter
                    ElseIf weapon.name.Contains("tome") Then
                        'primarypic.Image = simplefantasygame.My.Resources.Resources.tome
                    ElseIf weapon.name.Contains("crossbow") Then
                        'primarypic.Image = simplefantasygame.My.Resources.Resources.crossbow
                    ElseIf weapon.name.Contains("bow") Then
                        'primarypic.Image = simplefantasygame.My.Resources.Resources.bow
                    ElseIf weapon.name.Contains("spear") Then
                        'primarypic.Image = simplefantasygame.My.Resources.Resources.spear
                    End If
                Case 2
                    secondarytip.SetToolTip(secondarypic, weapon.DetailsString)
                    If weapon.name.Contains("sword") Then
                        secondarypic.Image = simplefantasygame.My.Resources.Resources.sword
                    ElseIf weapon.name.Contains("axe") Then
                        secondarypic.Image = simplefantasygame.My.Resources.Resources.axe
                    ElseIf weapon.name.Contains("shield") Then
                        'secondarypic.Image = simplefantasygame.My.Resources.Resources.shield
                    ElseIf weapon.name.Contains("hammer") Then
                        'secondarypic.Image = simplefantasygame.My.Resources.Resources.hammer
                    ElseIf weapon.name.Contains("staff") Then
                        'secondarypic.Image = simplefantasygame.My.Resources.Resources.staff
                    ElseIf weapon.name.Contains("wand") Then
                        'secondarypic.Image = simplefantasygame.My.Resources.Resources.wand
                    ElseIf weapon.name.Contains("scepter") Then
                        'secondarypic.Image = simplefantasygame.My.Resources.Resources.scepter
                    ElseIf weapon.name.Contains("tome") Then
                        'secondarypic.Image = simplefantasygame.My.Resources.Resources.tome
                    ElseIf weapon.name.Contains("crossbow") Then
                        'secondarypic.Image = simplefantasygame.My.Resources.Resources.crossbow
                    ElseIf weapon.name.Contains("bow") Then
                        'secondarypic.Image = simplefantasygame.My.Resources.Resources.bow
                    ElseIf weapon.name.Contains("spear") Then
                        'secondarypic.Image = simplefantasygame.My.Resources.Resources.spear
                    End If
            End Select
        Next

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

    Private Sub headlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles secondarylbl.LinkClicked
        If headpic Is Nothing Then Exit Sub
        Dim slotInt = 0
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip head item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement head item unequip
            'currentCreature.unequip(headItem)
            'change headItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            headpic.Image = Nothing
            headtip.RemoveAll()
        End If
    End Sub

    Private Sub shoulderslbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles shoulderslbl.LinkClicked
        If shoulderspic Is Nothing Then Exit Sub
        Dim slotInt = 1
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip shoulders item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement shoulders item unequip
            'currentCreature.unequip(shouldersItem)
            'change shouldersItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            shoulderspic.Image = Nothing
            shoulderstip.RemoveAll()
        End If
    End Sub

    Private Sub sleevelbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles sleevelbl.LinkClicked
        If sleevespic Is Nothing Then Exit Sub
        Dim slotInt = 2
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip sleeves item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement sleeves item unequip
            'currentCreature.unequip(sleevesItem)
            'change sleevesItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            sleevespic.Image = Nothing
            sleevestip.RemoveAll()
        End If
    End Sub

    Private Sub handslbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles handslbl.LinkClicked
        If handspic Is Nothing Then Exit Sub
        Dim slotInt = 3
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip hands item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement hands item unequip
            'currentCreature.unequip(handsItem)
            'change handsItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            handspic.Image = Nothing
            handstip.RemoveAll()
        End If
    End Sub

    Private Sub feetlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles feetlbl.LinkClicked
        If feetpic Is Nothing Then Exit Sub
        Dim slotInt = 4
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip feet item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement feet item unequip
            'currentCreature.unequip(feetItem)
            'change feetItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            feetpic.Image = Nothing
            feettip.RemoveAll()
        End If
    End Sub

    Private Sub backlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles backlbl.LinkClicked
        If backpic Is Nothing Then Exit Sub
        Dim slotInt = 5
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip back item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement back item unequip
            'currentCreature.unequip(backItem)
            'change backItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            backpic.Image = Nothing
            backtip.RemoveAll()
        End If
    End Sub

    Private Sub chestlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles chestlbl.LinkClicked
        If chestpic Is Nothing Then Exit Sub
        Dim slotInt = 6
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip chest item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement chest item unequip
            'currentCreature.unequip(chestItem)
            'change chestItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            chestpic.Image = Nothing
            chesttip.RemoveAll()
        End If
    End Sub

    Private Sub waistlbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles waistlbl.LinkClicked
        If waistpic Is Nothing Then Exit Sub
        Dim slotInt = 7
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip waist item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement waist item unequip
            'currentCreature.unequip(waistItem)
            'change waistItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            waistpic.Image = Nothing
            waisttip.RemoveAll()
        End If
    End Sub

    Private Sub legslbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles legslbl.LinkClicked
        If legspic Is Nothing Then Exit Sub
        Dim slotInt = 8
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip legs item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement legs item unequip
            'currentCreature.unequip(legsItem)
            'change legsItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            legspic.Image = Nothing
            legstip.RemoveAll()
        End If
    End Sub

    Private Sub shinslbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles shinslbl.LinkClicked
        If shinspic Is Nothing Then Exit Sub
        Dim slotInt = 9
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip shins item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO implement shins item unequip
            'currentCreature.unequip(shinsItem)
            'change shinsItem in database:
            '   remove slotWorn
            '   remove wearerid
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerArmor.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            shinspic.Image = Nothing
            shinstip.RemoveAll()
        End If
    End Sub

    Private Sub primarylbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles primarylbl.LinkClicked
        If primarypic Is Nothing Then Exit Sub
        Dim slotInt = 10
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip primary item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO debug
            GameDatabaseDataSet.PlayerWeapons.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerWeapons.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            primarypic.Image = Nothing
            primarytip.RemoveAll()
        End If
    End Sub

    Private Sub secondarylbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles secondarylbl.LinkClicked
        If secondarypic Is Nothing Then Exit Sub
        Dim slotInt = 11
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox("unequip secondary item?", style, "confirm unequip")
        If response = MsgBoxResult.Yes Then
            'TODO debug
            GameDatabaseDataSet.PlayerWeapons.FindByid(itemIndexCol(slotStringArray(slotInt)))("wearerid") = DBNull.Value
            GameDatabaseDataSet.PlayerWeapons.FindByid(itemIndexCol(slotStringArray(slotInt)))("slotWorn") = DBNull.Value
            PlayerArmorTableAdapter.Update(GameDatabaseDataSet.PlayerArmor)
            secondarypic.Image = Nothing
            secondarytip.RemoveAll()
        End If
    End Sub
End Class