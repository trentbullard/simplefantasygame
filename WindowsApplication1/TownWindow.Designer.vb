<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TownWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TownWindow))
        Me.townpnl = New System.Windows.Forms.Panel()
        Me.playerbtn = New System.Windows.Forms.Button()
        Me.roadlbl = New System.Windows.Forms.Label()
        Me.marketlbl = New System.Windows.Forms.Label()
        Me.tavernlbl = New System.Windows.Forms.Label()
        Me.innlbl = New System.Windows.Forms.Label()
        Me.necromancerlbl = New System.Windows.Forms.Label()
        Me.mainMenubtn = New System.Windows.Forms.Button()
        Me.roadbtn = New System.Windows.Forms.Button()
        Me.necromancerbtn = New System.Windows.Forms.Button()
        Me.marketbtn = New System.Windows.Forms.Button()
        Me.tavernbtn = New System.Windows.Forms.Button()
        Me.innbtn = New System.Windows.Forms.Button()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.ArmorAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArmorAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.ArmorAugmentsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BattlesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.BattlesTableAdapter()
        Me.PartiesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PartiesTableAdapter()
        Me.PlayerArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter()
        Me.PlayerConsumablesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter()
        Me.PlayerCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.PlayerSkillsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerSkillsTableAdapter()
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.PlayerWeaponsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter()
        Me.StaticArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        Me.StaticAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter()
        Me.StaticConsumablesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticConsumablesTableAdapter()
        Me.StaticCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter()
        Me.StaticMobsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticMobsTableAdapter()
        Me.StaticSkillsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticSkillsTableAdapter()
        Me.StaticWeaponsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.TurnsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TurnsTableAdapter()
        Me.WeaponAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.WeaponAugmentsTableAdapter()
        Me.BattlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerConsumablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerSkillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticConsumablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticMobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticSkillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurnsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeaponAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.townpnl.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmorAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BattlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerConsumablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerSkillsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticConsumablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticMobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticSkillsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeaponAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'townpnl
        '
        Me.townpnl.BackgroundImage = CType(resources.GetObject("townpnl.BackgroundImage"), System.Drawing.Image)
        Me.townpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.townpnl.Controls.Add(Me.playerbtn)
        Me.townpnl.Controls.Add(Me.roadlbl)
        Me.townpnl.Controls.Add(Me.marketlbl)
        Me.townpnl.Controls.Add(Me.tavernlbl)
        Me.townpnl.Controls.Add(Me.innlbl)
        Me.townpnl.Controls.Add(Me.necromancerlbl)
        Me.townpnl.Controls.Add(Me.mainMenubtn)
        Me.townpnl.Controls.Add(Me.roadbtn)
        Me.townpnl.Controls.Add(Me.necromancerbtn)
        Me.townpnl.Controls.Add(Me.marketbtn)
        Me.townpnl.Controls.Add(Me.tavernbtn)
        Me.townpnl.Controls.Add(Me.innbtn)
        Me.townpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.townpnl.Location = New System.Drawing.Point(0, 0)
        Me.townpnl.Name = "townpnl"
        Me.townpnl.Size = New System.Drawing.Size(1000, 600)
        Me.townpnl.TabIndex = 0
        '
        'playerbtn
        '
        Me.playerbtn.Location = New System.Drawing.Point(832, 565)
        Me.playerbtn.Name = "playerbtn"
        Me.playerbtn.Size = New System.Drawing.Size(75, 23)
        Me.playerbtn.TabIndex = 11
        Me.playerbtn.Text = "player info"
        Me.playerbtn.UseVisualStyleBackColor = True
        '
        'roadlbl
        '
        Me.roadlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roadlbl.AutoSize = True
        Me.roadlbl.BackColor = System.Drawing.Color.Transparent
        Me.roadlbl.ForeColor = System.Drawing.Color.Lime
        Me.roadlbl.Location = New System.Drawing.Point(834, 87)
        Me.roadlbl.Name = "roadlbl"
        Me.roadlbl.Size = New System.Drawing.Size(97, 13)
        Me.roadlbl.TabIndex = 10
        Me.roadlbl.Text = "click here to travel!"
        '
        'marketlbl
        '
        Me.marketlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.marketlbl.AutoSize = True
        Me.marketlbl.BackColor = System.Drawing.Color.Transparent
        Me.marketlbl.ForeColor = System.Drawing.Color.Lime
        Me.marketlbl.Location = New System.Drawing.Point(521, 142)
        Me.marketlbl.Name = "marketlbl"
        Me.marketlbl.Size = New System.Drawing.Size(115, 13)
        Me.marketlbl.TabIndex = 9
        Me.marketlbl.Text = "click here to buy items!"
        '
        'tavernlbl
        '
        Me.tavernlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tavernlbl.AutoSize = True
        Me.tavernlbl.BackColor = System.Drawing.Color.Transparent
        Me.tavernlbl.ForeColor = System.Drawing.Color.Lime
        Me.tavernlbl.Location = New System.Drawing.Point(315, 322)
        Me.tavernlbl.Name = "tavernlbl"
        Me.tavernlbl.Size = New System.Drawing.Size(159, 13)
        Me.tavernlbl.TabIndex = 8
        Me.tavernlbl.Text = "click here to hire team members!"
        '
        'innlbl
        '
        Me.innlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.innlbl.AutoSize = True
        Me.innlbl.BackColor = System.Drawing.Color.Transparent
        Me.innlbl.ForeColor = System.Drawing.Color.Lime
        Me.innlbl.Location = New System.Drawing.Point(58, 351)
        Me.innlbl.Name = "innlbl"
        Me.innlbl.Size = New System.Drawing.Size(137, 13)
        Me.innlbl.TabIndex = 7
        Me.innlbl.Text = "click here to rest your team!"
        '
        'necromancerlbl
        '
        Me.necromancerlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.necromancerlbl.AutoSize = True
        Me.necromancerlbl.BackColor = System.Drawing.Color.Transparent
        Me.necromancerlbl.ForeColor = System.Drawing.Color.Lime
        Me.necromancerlbl.Location = New System.Drawing.Point(595, 204)
        Me.necromancerlbl.Name = "necromancerlbl"
        Me.necromancerlbl.Size = New System.Drawing.Size(199, 13)
        Me.necromancerlbl.TabIndex = 6
        Me.necromancerlbl.Text = "click here to revive fallen team members!"
        '
        'mainMenubtn
        '
        Me.mainMenubtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainMenubtn.Location = New System.Drawing.Point(913, 565)
        Me.mainMenubtn.Name = "mainMenubtn"
        Me.mainMenubtn.Size = New System.Drawing.Size(75, 23)
        Me.mainMenubtn.TabIndex = 0
        Me.mainMenubtn.Text = "main menu"
        Me.mainMenubtn.UseVisualStyleBackColor = True
        '
        'roadbtn
        '
        Me.roadbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roadbtn.Location = New System.Drawing.Point(843, 103)
        Me.roadbtn.Name = "roadbtn"
        Me.roadbtn.Size = New System.Drawing.Size(81, 23)
        Me.roadbtn.TabIndex = 5
        Me.roadbtn.Text = "road"
        Me.roadbtn.UseVisualStyleBackColor = True
        '
        'necromancerbtn
        '
        Me.necromancerbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.necromancerbtn.Location = New System.Drawing.Point(655, 220)
        Me.necromancerbtn.Name = "necromancerbtn"
        Me.necromancerbtn.Size = New System.Drawing.Size(81, 23)
        Me.necromancerbtn.TabIndex = 4
        Me.necromancerbtn.Text = "necromancer"
        Me.necromancerbtn.UseVisualStyleBackColor = True
        '
        'marketbtn
        '
        Me.marketbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.marketbtn.Location = New System.Drawing.Point(542, 158)
        Me.marketbtn.Name = "marketbtn"
        Me.marketbtn.Size = New System.Drawing.Size(75, 23)
        Me.marketbtn.TabIndex = 3
        Me.marketbtn.Text = "market"
        Me.marketbtn.UseVisualStyleBackColor = True
        '
        'tavernbtn
        '
        Me.tavernbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tavernbtn.Location = New System.Drawing.Point(358, 296)
        Me.tavernbtn.Name = "tavernbtn"
        Me.tavernbtn.Size = New System.Drawing.Size(75, 23)
        Me.tavernbtn.TabIndex = 2
        Me.tavernbtn.Text = "tavern"
        Me.tavernbtn.UseVisualStyleBackColor = True
        '
        'innbtn
        '
        Me.innbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.innbtn.Location = New System.Drawing.Point(90, 325)
        Me.innbtn.Name = "innbtn"
        Me.innbtn.Size = New System.Drawing.Size(75, 23)
        Me.innbtn.TabIndex = 1
        Me.innbtn.Text = "inn"
        Me.innbtn.UseVisualStyleBackColor = True
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArmorAugmentsBindingSource
        '
        Me.ArmorAugmentsBindingSource.DataMember = "ArmorAugments"
        Me.ArmorAugmentsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'ArmorAugmentsTableAdapter
        '
        Me.ArmorAugmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArmorAugmentsTableAdapter = Me.ArmorAugmentsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BattlesTableAdapter = Me.BattlesTableAdapter
        Me.TableAdapterManager.PartiesTableAdapter = Me.PartiesTableAdapter
        Me.TableAdapterManager.PlayerArmorTableAdapter = Me.PlayerArmorTableAdapter
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Me.PlayerConsumablesTableAdapter
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Me.PlayerCreaturesTableAdapter
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Me.PlayerSkillsTableAdapter
        Me.TableAdapterManager.PlayersTableAdapter = Me.PlayersTableAdapter
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Me.PlayerWeaponsTableAdapter
        Me.TableAdapterManager.StaticArmorTableAdapter = Me.StaticArmorTableAdapter
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Me.StaticAugmentsTableAdapter
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Me.StaticConsumablesTableAdapter
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Me.StaticCreaturesTableAdapter
        Me.TableAdapterManager.StaticMobsTableAdapter = Me.StaticMobsTableAdapter
        Me.TableAdapterManager.StaticSkillsTableAdapter = Me.StaticSkillsTableAdapter
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Me.StaticWeaponsTableAdapter
        Me.TableAdapterManager.TurnsTableAdapter = Me.TurnsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Me.WeaponAugmentsTableAdapter
        '
        'BattlesTableAdapter
        '
        Me.BattlesTableAdapter.ClearBeforeFill = True
        '
        'PartiesTableAdapter
        '
        Me.PartiesTableAdapter.ClearBeforeFill = True
        '
        'PlayerArmorTableAdapter
        '
        Me.PlayerArmorTableAdapter.ClearBeforeFill = True
        '
        'PlayerConsumablesTableAdapter
        '
        Me.PlayerConsumablesTableAdapter.ClearBeforeFill = True
        '
        'PlayerCreaturesTableAdapter
        '
        Me.PlayerCreaturesTableAdapter.ClearBeforeFill = True
        '
        'PlayerSkillsTableAdapter
        '
        Me.PlayerSkillsTableAdapter.ClearBeforeFill = True
        '
        'PlayersTableAdapter
        '
        Me.PlayersTableAdapter.ClearBeforeFill = True
        '
        'PlayerWeaponsTableAdapter
        '
        Me.PlayerWeaponsTableAdapter.ClearBeforeFill = True
        '
        'StaticArmorTableAdapter
        '
        Me.StaticArmorTableAdapter.ClearBeforeFill = True
        '
        'StaticAugmentsTableAdapter
        '
        Me.StaticAugmentsTableAdapter.ClearBeforeFill = True
        '
        'StaticConsumablesTableAdapter
        '
        Me.StaticConsumablesTableAdapter.ClearBeforeFill = True
        '
        'StaticCreaturesTableAdapter
        '
        Me.StaticCreaturesTableAdapter.ClearBeforeFill = True
        '
        'StaticMobsTableAdapter
        '
        Me.StaticMobsTableAdapter.ClearBeforeFill = True
        '
        'StaticSkillsTableAdapter
        '
        Me.StaticSkillsTableAdapter.ClearBeforeFill = True
        '
        'StaticWeaponsTableAdapter
        '
        Me.StaticWeaponsTableAdapter.ClearBeforeFill = True
        '
        'TurnsTableAdapter
        '
        Me.TurnsTableAdapter.ClearBeforeFill = True
        '
        'WeaponAugmentsTableAdapter
        '
        Me.WeaponAugmentsTableAdapter.ClearBeforeFill = True
        '
        'BattlesBindingSource
        '
        Me.BattlesBindingSource.DataMember = "Battles"
        Me.BattlesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PartiesBindingSource
        '
        Me.PartiesBindingSource.DataMember = "Parties"
        Me.PartiesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerArmorBindingSource
        '
        Me.PlayerArmorBindingSource.DataMember = "PlayerArmor"
        Me.PlayerArmorBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerConsumablesBindingSource
        '
        Me.PlayerConsumablesBindingSource.DataMember = "PlayerConsumables"
        Me.PlayerConsumablesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerCreaturesBindingSource
        '
        Me.PlayerCreaturesBindingSource.DataMember = "PlayerCreatures"
        Me.PlayerCreaturesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayersBindingSource
        '
        Me.PlayersBindingSource.DataMember = "Players"
        Me.PlayersBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerSkillsBindingSource
        '
        Me.PlayerSkillsBindingSource.DataMember = "PlayerSkills"
        Me.PlayerSkillsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerWeaponsBindingSource
        '
        Me.PlayerWeaponsBindingSource.DataMember = "PlayerWeapons"
        Me.PlayerWeaponsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticArmorBindingSource
        '
        Me.StaticArmorBindingSource.DataMember = "StaticArmor"
        Me.StaticArmorBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticAugmentsBindingSource
        '
        Me.StaticAugmentsBindingSource.DataMember = "StaticAugments"
        Me.StaticAugmentsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticConsumablesBindingSource
        '
        Me.StaticConsumablesBindingSource.DataMember = "StaticConsumables"
        Me.StaticConsumablesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticCreaturesBindingSource
        '
        Me.StaticCreaturesBindingSource.DataMember = "StaticCreatures"
        Me.StaticCreaturesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticMobsBindingSource
        '
        Me.StaticMobsBindingSource.DataMember = "StaticMobs"
        Me.StaticMobsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticSkillsBindingSource
        '
        Me.StaticSkillsBindingSource.DataMember = "StaticSkills"
        Me.StaticSkillsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticWeaponsBindingSource
        '
        Me.StaticWeaponsBindingSource.DataMember = "StaticWeapons"
        Me.StaticWeaponsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'TurnsBindingSource
        '
        Me.TurnsBindingSource.DataMember = "Turns"
        Me.TurnsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'WeaponAugmentsBindingSource
        '
        Me.WeaponAugmentsBindingSource.DataMember = "WeaponAugments"
        Me.WeaponAugmentsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'TownWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.townpnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TownWindow"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "TownWindow"
        Me.townpnl.ResumeLayout(False)
        Me.townpnl.PerformLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmorAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BattlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerConsumablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerSkillsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticConsumablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticMobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticSkillsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeaponAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents townpnl As Panel
    Friend WithEvents mainMenubtn As Button
    Friend WithEvents necromancerlbl As Label
    Friend WithEvents roadbtn As Button
    Friend WithEvents necromancerbtn As Button
    Friend WithEvents marketbtn As Button
    Friend WithEvents tavernbtn As Button
    Friend WithEvents innbtn As Button
    Friend WithEvents roadlbl As Label
    Friend WithEvents marketlbl As Label
    Friend WithEvents tavernlbl As Label
    Friend WithEvents innlbl As Label
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents ArmorAugmentsBindingSource As BindingSource
    Friend WithEvents ArmorAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.ArmorAugmentsTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BattlesTableAdapter As GameDatabaseDataSetTableAdapters.BattlesTableAdapter
    Friend WithEvents BattlesBindingSource As BindingSource
    Friend WithEvents PartiesTableAdapter As GameDatabaseDataSetTableAdapters.PartiesTableAdapter
    Friend WithEvents PartiesBindingSource As BindingSource
    Friend WithEvents PlayerArmorTableAdapter As GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter
    Friend WithEvents PlayerArmorBindingSource As BindingSource
    Friend WithEvents PlayerConsumablesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter
    Friend WithEvents PlayerConsumablesBindingSource As BindingSource
    Friend WithEvents PlayerCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter
    Friend WithEvents PlayerCreaturesBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayerSkillsTableAdapter As GameDatabaseDataSetTableAdapters.PlayerSkillsTableAdapter
    Friend WithEvents PlayerSkillsBindingSource As BindingSource
    Friend WithEvents PlayerWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter
    Friend WithEvents PlayerWeaponsBindingSource As BindingSource
    Friend WithEvents StaticArmorTableAdapter As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter
    Friend WithEvents StaticArmorBindingSource As BindingSource
    Friend WithEvents StaticAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter
    Friend WithEvents StaticAugmentsBindingSource As BindingSource
    Friend WithEvents StaticConsumablesTableAdapter As GameDatabaseDataSetTableAdapters.StaticConsumablesTableAdapter
    Friend WithEvents StaticConsumablesBindingSource As BindingSource
    Friend WithEvents StaticCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter
    Friend WithEvents StaticCreaturesBindingSource As BindingSource
    Friend WithEvents StaticMobsTableAdapter As GameDatabaseDataSetTableAdapters.StaticMobsTableAdapter
    Friend WithEvents StaticMobsBindingSource As BindingSource
    Friend WithEvents StaticSkillsTableAdapter As GameDatabaseDataSetTableAdapters.StaticSkillsTableAdapter
    Friend WithEvents StaticSkillsBindingSource As BindingSource
    Friend WithEvents StaticWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter
    Friend WithEvents StaticWeaponsBindingSource As BindingSource
    Friend WithEvents TurnsTableAdapter As GameDatabaseDataSetTableAdapters.TurnsTableAdapter
    Friend WithEvents TurnsBindingSource As BindingSource
    Friend WithEvents WeaponAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.WeaponAugmentsTableAdapter
    Friend WithEvents WeaponAugmentsBindingSource As BindingSource
    Friend WithEvents playerbtn As Button
End Class
