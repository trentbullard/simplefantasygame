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
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.StaticCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter()
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        Me.StaticAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter()
        Me.StaticConsumablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticConsumablesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticConsumablesTableAdapter()
        Me.StaticMobsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticMobsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticMobsTableAdapter()
        Me.StaticSkillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticSkillsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticSkillsTableAdapter()
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.PartiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartiesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PartiesTableAdapter()
        Me.PlayerArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter()
        Me.PlayerConsumableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerConsumableTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerConsumableTableAdapter()
        Me.PlayerCreatureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreatureTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerCreatureTableAdapter()
        Me.PlayerSkillBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerSkillTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerSkillTableAdapter()
        Me.PlayerWeaponBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerWeaponTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerWeaponTableAdapter()
        Me.WeaponAugmentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeaponAugmentTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.WeaponAugmentTableAdapter()
        Me.BattlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BattlesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.BattlesTableAdapter()
        Me.TurnsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurnsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TurnsTableAdapter()
        Me.townpnl = New System.Windows.Forms.Panel()
        Me.mainMenuButtonpnl = New System.Windows.Forms.Panel()
        Me.mainMenubtn = New System.Windows.Forms.Button()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticConsumablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticMobsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticSkillsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerConsumableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreatureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerSkillBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerWeaponBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeaponAugmentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BattlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.townpnl.SuspendLayout()
        Me.mainMenuButtonpnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArmorAugmentTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BattlesTableAdapter = Me.BattlesTableAdapter
        Me.TableAdapterManager.PartiesTableAdapter = Me.PartiesTableAdapter
        Me.TableAdapterManager.PlayerArmorTableAdapter = Me.PlayerArmorTableAdapter
        Me.TableAdapterManager.PlayerConsumableTableAdapter = Me.PlayerConsumableTableAdapter
        Me.TableAdapterManager.PlayerCreatureTableAdapter = Me.PlayerCreatureTableAdapter
        Me.TableAdapterManager.PlayerSkillTableAdapter = Me.PlayerSkillTableAdapter
        Me.TableAdapterManager.PlayersTableAdapter = Me.PlayersTableAdapter
        Me.TableAdapterManager.PlayerWeaponTableAdapter = Me.PlayerWeaponTableAdapter
        Me.TableAdapterManager.StaticArmorTableAdapter = Me.StaticArmorTableAdapter
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Me.StaticAugmentsTableAdapter
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Me.StaticConsumablesTableAdapter
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Me.StaticCreaturesTableAdapter
        Me.TableAdapterManager.StaticMobsTableAdapter = Me.StaticMobsTableAdapter
        Me.TableAdapterManager.StaticSkillsTableAdapter = Me.StaticSkillsTableAdapter
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Me.StaticWeaponsTableAdapter
        Me.TableAdapterManager.TurnsTableAdapter = Me.TurnsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentTableAdapter = Me.WeaponAugmentTableAdapter
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
        'PlayerConsumableBindingSource
        '
        Me.PlayerConsumableBindingSource.DataMember = "PlayerConsumable"
        Me.PlayerConsumableBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerConsumableTableAdapter
        '
        Me.PlayerConsumableTableAdapter.ClearBeforeFill = True
        '
        'PlayerCreatureBindingSource
        '
        Me.PlayerCreatureBindingSource.DataMember = "PlayerCreature"
        Me.PlayerCreatureBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerCreatureTableAdapter
        '
        Me.PlayerCreatureTableAdapter.ClearBeforeFill = True
        '
        'PlayerSkillBindingSource
        '
        Me.PlayerSkillBindingSource.DataMember = "PlayerSkill"
        Me.PlayerSkillBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerSkillTableAdapter
        '
        Me.PlayerSkillTableAdapter.ClearBeforeFill = True
        '
        'PlayerWeaponBindingSource
        '
        Me.PlayerWeaponBindingSource.DataMember = "PlayerWeapon"
        Me.PlayerWeaponBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerWeaponTableAdapter
        '
        Me.PlayerWeaponTableAdapter.ClearBeforeFill = True
        '
        'WeaponAugmentBindingSource
        '
        Me.WeaponAugmentBindingSource.DataMember = "WeaponAugment"
        Me.WeaponAugmentBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'WeaponAugmentTableAdapter
        '
        Me.WeaponAugmentTableAdapter.ClearBeforeFill = True
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
        'TurnsBindingSource
        '
        Me.TurnsBindingSource.DataMember = "Turns"
        Me.TurnsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'TurnsTableAdapter
        '
        Me.TurnsTableAdapter.ClearBeforeFill = True
        '
        'townpnl
        '
        Me.townpnl.Controls.Add(Me.mainMenuButtonpnl)
        Me.townpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.townpnl.Location = New System.Drawing.Point(0, 0)
        Me.townpnl.Name = "townpnl"
        Me.townpnl.Size = New System.Drawing.Size(1083, 726)
        Me.townpnl.TabIndex = 0
        '
        'mainMenuButtonpnl
        '
        Me.mainMenuButtonpnl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainMenuButtonpnl.Controls.Add(Me.mainMenubtn)
        Me.mainMenuButtonpnl.Location = New System.Drawing.Point(984, 679)
        Me.mainMenuButtonpnl.Name = "mainMenuButtonpnl"
        Me.mainMenuButtonpnl.Size = New System.Drawing.Size(99, 47)
        Me.mainMenuButtonpnl.TabIndex = 0
        '
        'mainMenubtn
        '
        Me.mainMenubtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainMenubtn.Location = New System.Drawing.Point(12, 12)
        Me.mainMenubtn.Name = "mainMenubtn"
        Me.mainMenubtn.Size = New System.Drawing.Size(75, 23)
        Me.mainMenubtn.TabIndex = 0
        Me.mainMenubtn.Text = "Main Menu"
        Me.mainMenubtn.UseVisualStyleBackColor = True
        '
        'TownWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1083, 726)
        Me.Controls.Add(Me.townpnl)
        Me.Name = "TownWindow"
        Me.ShowIcon = False
        Me.Text = "TownWindow"
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticConsumablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticMobsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticSkillsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerConsumableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreatureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerSkillBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerWeaponBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeaponAugmentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BattlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.townpnl.ResumeLayout(False)
        Me.mainMenuButtonpnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaticCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter
    Friend WithEvents StaticCreaturesBindingSource As BindingSource
    Friend WithEvents StaticArmorTableAdapter As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter
    Friend WithEvents StaticArmorBindingSource As BindingSource
    Friend WithEvents StaticAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter
    Friend WithEvents StaticAugmentsBindingSource As BindingSource
    Friend WithEvents StaticConsumablesTableAdapter As GameDatabaseDataSetTableAdapters.StaticConsumablesTableAdapter
    Friend WithEvents StaticConsumablesBindingSource As BindingSource
    Friend WithEvents StaticMobsTableAdapter As GameDatabaseDataSetTableAdapters.StaticMobsTableAdapter
    Friend WithEvents StaticMobsBindingSource As BindingSource
    Friend WithEvents StaticSkillsTableAdapter As GameDatabaseDataSetTableAdapters.StaticSkillsTableAdapter
    Friend WithEvents StaticSkillsBindingSource As BindingSource
    Friend WithEvents StaticWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter
    Friend WithEvents StaticWeaponsBindingSource As BindingSource
    Friend WithEvents PartiesTableAdapter As GameDatabaseDataSetTableAdapters.PartiesTableAdapter
    Friend WithEvents PartiesBindingSource As BindingSource
    Friend WithEvents PlayerArmorTableAdapter As GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter
    Friend WithEvents PlayerArmorBindingSource As BindingSource
    Friend WithEvents PlayerConsumableTableAdapter As GameDatabaseDataSetTableAdapters.PlayerConsumableTableAdapter
    Friend WithEvents PlayerConsumableBindingSource As BindingSource
    Friend WithEvents PlayerCreatureTableAdapter As GameDatabaseDataSetTableAdapters.PlayerCreatureTableAdapter
    Friend WithEvents PlayerCreatureBindingSource As BindingSource
    Friend WithEvents PlayerSkillTableAdapter As GameDatabaseDataSetTableAdapters.PlayerSkillTableAdapter
    Friend WithEvents PlayerSkillBindingSource As BindingSource
    Friend WithEvents PlayerWeaponTableAdapter As GameDatabaseDataSetTableAdapters.PlayerWeaponTableAdapter
    Friend WithEvents PlayerWeaponBindingSource As BindingSource
    Friend WithEvents WeaponAugmentTableAdapter As GameDatabaseDataSetTableAdapters.WeaponAugmentTableAdapter
    Friend WithEvents WeaponAugmentBindingSource As BindingSource
    Friend WithEvents BattlesTableAdapter As GameDatabaseDataSetTableAdapters.BattlesTableAdapter
    Friend WithEvents BattlesBindingSource As BindingSource
    Friend WithEvents TurnsTableAdapter As GameDatabaseDataSetTableAdapters.TurnsTableAdapter
    Friend WithEvents TurnsBindingSource As BindingSource
    Friend WithEvents townpnl As Panel
    Friend WithEvents mainMenuButtonpnl As Panel
    Friend WithEvents mainMenubtn As Button
End Class
