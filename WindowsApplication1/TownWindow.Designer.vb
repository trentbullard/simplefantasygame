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
        Me.mainMenubtn = New System.Windows.Forms.Button()
        Me.innbtn = New System.Windows.Forms.Button()
        Me.tavernbtn = New System.Windows.Forms.Button()
        Me.marketbtn = New System.Windows.Forms.Button()
        Me.necromancerbtn = New System.Windows.Forms.Button()
        Me.roadbtn = New System.Windows.Forms.Button()
        Me.necromancerlbl = New System.Windows.Forms.Label()
        Me.innlbl = New System.Windows.Forms.Label()
        Me.tavernlbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.ArmorAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArmorAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.ArmorAugmentsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BattlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BattlesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.BattlesTableAdapter()
        Me.PartiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartiesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PartiesTableAdapter()
        Me.PlayerArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter()
        Me.PlayerConsumablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerConsumablesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter()
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.PlayerSkillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerSkillsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerSkillsTableAdapter()
        Me.PlayerWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerWeaponsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter()
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        Me.StaticAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter()
        Me.StaticConsumablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticConsumablesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticConsumablesTableAdapter()
        Me.StaticCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter()
        Me.StaticMobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticMobsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticMobsTableAdapter()
        Me.StaticSkillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticSkillsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticSkillsTableAdapter()
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.TurnsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurnsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TurnsTableAdapter()
        Me.WeaponAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeaponAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.WeaponAugmentsTableAdapter()
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
        Me.townpnl.Controls.Add(Me.Label2)
        Me.townpnl.Controls.Add(Me.Label1)
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
        'mainMenubtn
        '
        Me.mainMenubtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainMenubtn.Location = New System.Drawing.Point(913, 565)
        Me.mainMenubtn.Name = "mainMenubtn"
        Me.mainMenubtn.Size = New System.Drawing.Size(75, 23)
        Me.mainMenubtn.TabIndex = 0
        Me.mainMenubtn.Text = "Main Menu"
        Me.mainMenubtn.UseVisualStyleBackColor = True
        '
        'innbtn
        '
        Me.innbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.innbtn.Location = New System.Drawing.Point(90, 325)
        Me.innbtn.Name = "innbtn"
        Me.innbtn.Size = New System.Drawing.Size(75, 23)
        Me.innbtn.TabIndex = 1
        Me.innbtn.Text = "Inn"
        Me.innbtn.UseVisualStyleBackColor = True
        '
        'tavernbtn
        '
        Me.tavernbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tavernbtn.Location = New System.Drawing.Point(358, 296)
        Me.tavernbtn.Name = "tavernbtn"
        Me.tavernbtn.Size = New System.Drawing.Size(75, 23)
        Me.tavernbtn.TabIndex = 2
        Me.tavernbtn.Text = "Tavern"
        Me.tavernbtn.UseVisualStyleBackColor = True
        '
        'marketbtn
        '
        Me.marketbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.marketbtn.Location = New System.Drawing.Point(542, 158)
        Me.marketbtn.Name = "marketbtn"
        Me.marketbtn.Size = New System.Drawing.Size(75, 23)
        Me.marketbtn.TabIndex = 3
        Me.marketbtn.Text = "Market"
        Me.marketbtn.UseVisualStyleBackColor = True
        '
        'necromancerbtn
        '
        Me.necromancerbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.necromancerbtn.Location = New System.Drawing.Point(655, 220)
        Me.necromancerbtn.Name = "necromancerbtn"
        Me.necromancerbtn.Size = New System.Drawing.Size(81, 23)
        Me.necromancerbtn.TabIndex = 4
        Me.necromancerbtn.Text = "Necromancer"
        Me.necromancerbtn.UseVisualStyleBackColor = True
        '
        'roadbtn
        '
        Me.roadbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roadbtn.Location = New System.Drawing.Point(843, 103)
        Me.roadbtn.Name = "roadbtn"
        Me.roadbtn.Size = New System.Drawing.Size(81, 23)
        Me.roadbtn.TabIndex = 5
        Me.roadbtn.Text = "Road"
        Me.roadbtn.UseVisualStyleBackColor = True
        '
        'necromancerlbl
        '
        Me.necromancerlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.necromancerlbl.AutoSize = True
        Me.necromancerlbl.BackColor = System.Drawing.Color.Transparent
        Me.necromancerlbl.ForeColor = System.Drawing.Color.Lime
        Me.necromancerlbl.Location = New System.Drawing.Point(595, 204)
        Me.necromancerlbl.Name = "necromancerlbl"
        Me.necromancerlbl.Size = New System.Drawing.Size(200, 13)
        Me.necromancerlbl.TabIndex = 6
        Me.necromancerlbl.Text = "Click here to revive fallen team members!"
        '
        'innlbl
        '
        Me.innlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.innlbl.AutoSize = True
        Me.innlbl.BackColor = System.Drawing.Color.Transparent
        Me.innlbl.ForeColor = System.Drawing.Color.Lime
        Me.innlbl.Location = New System.Drawing.Point(58, 351)
        Me.innlbl.Name = "innlbl"
        Me.innlbl.Size = New System.Drawing.Size(138, 13)
        Me.innlbl.TabIndex = 7
        Me.innlbl.Text = "Click here to rest your team!"
        '
        'tavernlbl
        '
        Me.tavernlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tavernlbl.AutoSize = True
        Me.tavernlbl.BackColor = System.Drawing.Color.Transparent
        Me.tavernlbl.ForeColor = System.Drawing.Color.Lime
        Me.tavernlbl.Location = New System.Drawing.Point(315, 322)
        Me.tavernlbl.Name = "tavernlbl"
        Me.tavernlbl.Size = New System.Drawing.Size(160, 13)
        Me.tavernlbl.TabIndex = 8
        Me.tavernlbl.Text = "Click here to hire team members!"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(521, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Click here to buy items!"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(834, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Click here to travel!"
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
        'BattlesBindingSource
        '
        Me.BattlesBindingSource.DataMember = "Battles"
        Me.BattlesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'BattlesTableAdapter
        '
        Me.BattlesTableAdapter.ClearBeforeFill = True
        '
        'PartiesBindingSource
        '
        Me.PartiesBindingSource.DataMember = "Parties"
        Me.PartiesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PartiesTableAdapter
        '
        Me.PartiesTableAdapter.ClearBeforeFill = True
        '
        'PlayerArmorBindingSource
        '
        Me.PlayerArmorBindingSource.DataMember = "PlayerArmor"
        Me.PlayerArmorBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerArmorTableAdapter
        '
        Me.PlayerArmorTableAdapter.ClearBeforeFill = True
        '
        'PlayerConsumablesBindingSource
        '
        Me.PlayerConsumablesBindingSource.DataMember = "PlayerConsumables"
        Me.PlayerConsumablesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerConsumablesTableAdapter
        '
        Me.PlayerConsumablesTableAdapter.ClearBeforeFill = True
        '
        'PlayerCreaturesBindingSource
        '
        Me.PlayerCreaturesBindingSource.DataMember = "PlayerCreatures"
        Me.PlayerCreaturesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerCreaturesTableAdapter
        '
        Me.PlayerCreaturesTableAdapter.ClearBeforeFill = True
        '
        'PlayersBindingSource
        '
        Me.PlayersBindingSource.DataMember = "Players"
        Me.PlayersBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayersTableAdapter
        '
        Me.PlayersTableAdapter.ClearBeforeFill = True
        '
        'PlayerSkillsBindingSource
        '
        Me.PlayerSkillsBindingSource.DataMember = "PlayerSkills"
        Me.PlayerSkillsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerSkillsTableAdapter
        '
        Me.PlayerSkillsTableAdapter.ClearBeforeFill = True
        '
        'PlayerWeaponsBindingSource
        '
        Me.PlayerWeaponsBindingSource.DataMember = "PlayerWeapons"
        Me.PlayerWeaponsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerWeaponsTableAdapter
        '
        Me.PlayerWeaponsTableAdapter.ClearBeforeFill = True
        '
        'StaticArmorBindingSource
        '
        Me.StaticArmorBindingSource.DataMember = "StaticArmor"
        Me.StaticArmorBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticArmorTableAdapter
        '
        Me.StaticArmorTableAdapter.ClearBeforeFill = True
        '
        'StaticAugmentsBindingSource
        '
        Me.StaticAugmentsBindingSource.DataMember = "StaticAugments"
        Me.StaticAugmentsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticAugmentsTableAdapter
        '
        Me.StaticAugmentsTableAdapter.ClearBeforeFill = True
        '
        'StaticConsumablesBindingSource
        '
        Me.StaticConsumablesBindingSource.DataMember = "StaticConsumables"
        Me.StaticConsumablesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticConsumablesTableAdapter
        '
        Me.StaticConsumablesTableAdapter.ClearBeforeFill = True
        '
        'StaticCreaturesBindingSource
        '
        Me.StaticCreaturesBindingSource.DataMember = "StaticCreatures"
        Me.StaticCreaturesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticCreaturesTableAdapter
        '
        Me.StaticCreaturesTableAdapter.ClearBeforeFill = True
        '
        'StaticMobsBindingSource
        '
        Me.StaticMobsBindingSource.DataMember = "StaticMobs"
        Me.StaticMobsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticMobsTableAdapter
        '
        Me.StaticMobsTableAdapter.ClearBeforeFill = True
        '
        'StaticSkillsBindingSource
        '
        Me.StaticSkillsBindingSource.DataMember = "StaticSkills"
        Me.StaticSkillsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticSkillsTableAdapter
        '
        Me.StaticSkillsTableAdapter.ClearBeforeFill = True
        '
        'StaticWeaponsBindingSource
        '
        Me.StaticWeaponsBindingSource.DataMember = "StaticWeapons"
        Me.StaticWeaponsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticWeaponsTableAdapter
        '
        Me.StaticWeaponsTableAdapter.ClearBeforeFill = True
        '
        'TurnsBindingSource
        '
        Me.TurnsBindingSource.DataMember = "Turns"
        Me.TurnsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'TurnsTableAdapter
        '
        Me.TurnsTableAdapter.ClearBeforeFill = True
        '
        'WeaponAugmentsBindingSource
        '
        Me.WeaponAugmentsBindingSource.DataMember = "WeaponAugments"
        Me.WeaponAugmentsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'WeaponAugmentsTableAdapter
        '
        Me.WeaponAugmentsTableAdapter.ClearBeforeFill = True
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
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
End Class
