<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BlacksmithWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.blacksmithpnl = New System.Windows.Forms.Panel()
        Me.weaponslst = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.armorlbl = New System.Windows.Forms.Label()
        Me.weaponslbl = New System.Windows.Forms.Label()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayerWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerWeaponsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BlacksmithStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlacksmithStatesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.BlacksmithStatesTableAdapter()
        Me.BlacksmithStateItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlacksmithStateItemsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.BlacksmithStateItemsTableAdapter()
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        Me.StaticAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter()
        Me.WeaponAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeaponAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.WeaponAugmentsTableAdapter()
        Me.ArmorAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArmorAugmentsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.ArmorAugmentsTableAdapter()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.PlayerStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerStatesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter()
        Me.PlayerArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter()
        Me.armorlst = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mainMenubtn = New System.Windows.Forms.Button()
        Me.townbtn = New System.Windows.Forms.Button()
        Me.playerbtn = New System.Windows.Forms.Button()
        Me.playerGoldtxt = New System.Windows.Forms.TextBox()
        Me.playerGoldlbl = New System.Windows.Forms.Label()
        Me.blacksmithpnl.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlacksmithStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlacksmithStateItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeaponAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmorAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blacksmithpnl
        '
        Me.blacksmithpnl.Controls.Add(Me.playerGoldlbl)
        Me.blacksmithpnl.Controls.Add(Me.playerGoldtxt)
        Me.blacksmithpnl.Controls.Add(Me.townbtn)
        Me.blacksmithpnl.Controls.Add(Me.playerbtn)
        Me.blacksmithpnl.Controls.Add(Me.mainMenubtn)
        Me.blacksmithpnl.Controls.Add(Me.armorlst)
        Me.blacksmithpnl.Controls.Add(Me.weaponslst)
        Me.blacksmithpnl.Controls.Add(Me.armorlbl)
        Me.blacksmithpnl.Controls.Add(Me.weaponslbl)
        Me.blacksmithpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.blacksmithpnl.Location = New System.Drawing.Point(0, 0)
        Me.blacksmithpnl.Name = "blacksmithpnl"
        Me.blacksmithpnl.Size = New System.Drawing.Size(675, 605)
        Me.blacksmithpnl.TabIndex = 0
        '
        'weaponslst
        '
        Me.weaponslst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.weaponslst.Location = New System.Drawing.Point(12, 25)
        Me.weaponslst.Name = "weaponslst"
        Me.weaponslst.Size = New System.Drawing.Size(322, 288)
        Me.weaponslst.TabIndex = 2
        Me.weaponslst.UseCompatibleStateImageBehavior = False
        Me.weaponslst.View = System.Windows.Forms.View.SmallIcon
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = ""
        '
        'armorlbl
        '
        Me.armorlbl.AutoSize = True
        Me.armorlbl.Location = New System.Drawing.Point(485, 9)
        Me.armorlbl.Name = "armorlbl"
        Me.armorlbl.Size = New System.Drawing.Size(33, 13)
        Me.armorlbl.TabIndex = 1
        Me.armorlbl.Text = "armor"
        '
        'weaponslbl
        '
        Me.weaponslbl.AutoSize = True
        Me.weaponslbl.Location = New System.Drawing.Point(148, 9)
        Me.weaponslbl.Name = "weaponslbl"
        Me.weaponslbl.Size = New System.Drawing.Size(50, 13)
        Me.weaponslbl.TabIndex = 1
        Me.weaponslbl.Text = "weapons"
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArmorAugmentsTableAdapter = Me.ArmorAugmentsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BattlesTableAdapter = Nothing
        Me.TableAdapterManager.BlacksmithStateItemsTableAdapter = Me.BlacksmithStateItemsTableAdapter
        Me.TableAdapterManager.BlacksmithStatesTableAdapter = Me.BlacksmithStatesTableAdapter
        Me.TableAdapterManager.ChemistStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ChemistStatesTableAdapter = Nothing
        Me.TableAdapterManager.EnemyPartiesTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStatesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerArmorTableAdapter = Me.PlayerArmorTableAdapter
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Me.PlayersTableAdapter
        Me.TableAdapterManager.PlayerStatesTableAdapter = Me.PlayerStatesTableAdapter
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Me.PlayerWeaponsTableAdapter
        Me.TableAdapterManager.RoadStatesTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStatesTableAdapter = Nothing
        Me.TableAdapterManager.StaticArmorTableAdapter = Me.StaticArmorTableAdapter
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Me.StaticAugmentsTableAdapter
        Me.TableAdapterManager.StaticCampsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampTiersTableAdapter = Nothing
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.StaticMobsTableAdapter = Nothing
        Me.TableAdapterManager.StaticQuestsTableAdapter = Nothing
        Me.TableAdapterManager.StaticSkillsTableAdapter = Nothing
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Me.StaticWeaponsTableAdapter
        Me.TableAdapterManager.TavernStatesTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Me.WeaponAugmentsTableAdapter
        '
        'BlacksmithStatesBindingSource
        '
        Me.BlacksmithStatesBindingSource.DataMember = "BlacksmithStates"
        Me.BlacksmithStatesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'BlacksmithStatesTableAdapter
        '
        Me.BlacksmithStatesTableAdapter.ClearBeforeFill = True
        '
        'BlacksmithStateItemsBindingSource
        '
        Me.BlacksmithStateItemsBindingSource.DataMember = "BlacksmithStateItems"
        Me.BlacksmithStateItemsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'BlacksmithStateItemsTableAdapter
        '
        Me.BlacksmithStateItemsTableAdapter.ClearBeforeFill = True
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
        'WeaponAugmentsBindingSource
        '
        Me.WeaponAugmentsBindingSource.DataMember = "WeaponAugments"
        Me.WeaponAugmentsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'WeaponAugmentsTableAdapter
        '
        Me.WeaponAugmentsTableAdapter.ClearBeforeFill = True
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
        'PlayersBindingSource
        '
        Me.PlayersBindingSource.DataMember = "Players"
        Me.PlayersBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayersTableAdapter
        '
        Me.PlayersTableAdapter.ClearBeforeFill = True
        '
        'PlayerStatesBindingSource
        '
        Me.PlayerStatesBindingSource.DataMember = "PlayerStates"
        Me.PlayerStatesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerStatesTableAdapter
        '
        Me.PlayerStatesTableAdapter.ClearBeforeFill = True
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
        'armorlst
        '
        Me.armorlst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.armorlst.Location = New System.Drawing.Point(340, 25)
        Me.armorlst.Name = "armorlst"
        Me.armorlst.Size = New System.Drawing.Size(322, 288)
        Me.armorlst.TabIndex = 3
        Me.armorlst.UseCompatibleStateImageBehavior = False
        Me.armorlst.View = System.Windows.Forms.View.SmallIcon
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = ""
        '
        'mainMenubtn
        '
        Me.mainMenubtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainMenubtn.Location = New System.Drawing.Point(588, 570)
        Me.mainMenubtn.Name = "mainMenubtn"
        Me.mainMenubtn.Size = New System.Drawing.Size(75, 23)
        Me.mainMenubtn.TabIndex = 1
        Me.mainMenubtn.Text = "main menu"
        Me.mainMenubtn.UseVisualStyleBackColor = True
        '
        'townbtn
        '
        Me.townbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.townbtn.Location = New System.Drawing.Point(426, 570)
        Me.townbtn.Name = "townbtn"
        Me.townbtn.Size = New System.Drawing.Size(75, 23)
        Me.townbtn.TabIndex = 34
        Me.townbtn.Text = "front door"
        Me.townbtn.UseVisualStyleBackColor = True
        '
        'playerbtn
        '
        Me.playerbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerbtn.Location = New System.Drawing.Point(507, 570)
        Me.playerbtn.Name = "playerbtn"
        Me.playerbtn.Size = New System.Drawing.Size(75, 23)
        Me.playerbtn.TabIndex = 33
        Me.playerbtn.Text = "player info"
        Me.playerbtn.UseVisualStyleBackColor = True
        '
        'playerGoldtxt
        '
        Me.playerGoldtxt.Location = New System.Drawing.Point(320, 572)
        Me.playerGoldtxt.Name = "playerGoldtxt"
        Me.playerGoldtxt.ReadOnly = True
        Me.playerGoldtxt.Size = New System.Drawing.Size(100, 20)
        Me.playerGoldtxt.TabIndex = 35
        Me.playerGoldtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'playerGoldlbl
        '
        Me.playerGoldlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerGoldlbl.AutoSize = True
        Me.playerGoldlbl.Location = New System.Drawing.Point(355, 556)
        Me.playerGoldlbl.Name = "playerGoldlbl"
        Me.playerGoldlbl.Size = New System.Drawing.Size(65, 13)
        Me.playerGoldlbl.TabIndex = 36
        Me.playerGoldlbl.Text = "player's gold"
        '
        'BlacksmithWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 605)
        Me.Controls.Add(Me.blacksmithpnl)
        Me.Name = "BlacksmithWindow"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "blacksmith"
        Me.blacksmithpnl.ResumeLayout(False)
        Me.blacksmithpnl.PerformLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlacksmithStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlacksmithStateItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeaponAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmorAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents blacksmithpnl As Panel
    Friend WithEvents weaponslbl As Label
    Friend WithEvents armorlbl As Label
    Friend WithEvents weaponslst As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayerWeaponsBindingSource As BindingSource
    Friend WithEvents PlayerWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BlacksmithStatesTableAdapter As GameDatabaseDataSetTableAdapters.BlacksmithStatesTableAdapter
    Friend WithEvents BlacksmithStatesBindingSource As BindingSource
    Friend WithEvents BlacksmithStateItemsTableAdapter As GameDatabaseDataSetTableAdapters.BlacksmithStateItemsTableAdapter
    Friend WithEvents BlacksmithStateItemsBindingSource As BindingSource
    Friend WithEvents StaticWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter
    Friend WithEvents StaticWeaponsBindingSource As BindingSource
    Friend WithEvents StaticArmorTableAdapter As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter
    Friend WithEvents StaticArmorBindingSource As BindingSource
    Friend WithEvents StaticAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter
    Friend WithEvents StaticAugmentsBindingSource As BindingSource
    Friend WithEvents WeaponAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.WeaponAugmentsTableAdapter
    Friend WithEvents WeaponAugmentsBindingSource As BindingSource
    Friend WithEvents ArmorAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.ArmorAugmentsTableAdapter
    Friend WithEvents ArmorAugmentsBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayerStatesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter
    Friend WithEvents PlayerStatesBindingSource As BindingSource
    Friend WithEvents PlayerArmorTableAdapter As GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter
    Friend WithEvents PlayerArmorBindingSource As BindingSource
    Friend WithEvents mainMenubtn As Button
    Friend WithEvents armorlst As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents playerGoldlbl As Label
    Friend WithEvents playerGoldtxt As TextBox
    Friend WithEvents townbtn As Button
    Friend WithEvents playerbtn As Button
End Class
