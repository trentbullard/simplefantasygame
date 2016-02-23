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
        Me.sellbtn = New System.Windows.Forms.Button()
        Me.itemsTablepnl = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.weaponslst = New System.Windows.Forms.ListView()
        Me.weaponColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.armorlst = New System.Windows.Forms.ListView()
        Me.armorColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playerGoldlbl = New System.Windows.Forms.Label()
        Me.playerGoldtxt = New System.Windows.Forms.TextBox()
        Me.marketbtn = New System.Windows.Forms.Button()
        Me.playerbtn = New System.Windows.Forms.Button()
        Me.mainMenubtn = New System.Windows.Forms.Button()
        Me.BlacksmithStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlacksmithStateItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GameDatabaseDataSet = New simplefantasygame.GameDatabaseDataSet()
        Me.BlacksmithStateItemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlacksmithStateItemsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.BlacksmithStateItemsTableAdapter()
        Me.TableAdapterManager = New simplefantasygame.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BlacksmithStatesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlacksmithStatesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.BlacksmithStatesTableAdapter()
        Me.StaticWeaponsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.StaticArmorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        Me.blacksmithpnl.SuspendLayout()
        Me.itemsTablepnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BlacksmithStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlacksmithStateItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlacksmithStateItemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlacksmithStatesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blacksmithpnl
        '
        Me.blacksmithpnl.Controls.Add(Me.sellbtn)
        Me.blacksmithpnl.Controls.Add(Me.itemsTablepnl)
        Me.blacksmithpnl.Controls.Add(Me.playerGoldlbl)
        Me.blacksmithpnl.Controls.Add(Me.playerGoldtxt)
        Me.blacksmithpnl.Controls.Add(Me.marketbtn)
        Me.blacksmithpnl.Controls.Add(Me.playerbtn)
        Me.blacksmithpnl.Controls.Add(Me.mainMenubtn)
        Me.blacksmithpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.blacksmithpnl.Location = New System.Drawing.Point(0, 0)
        Me.blacksmithpnl.Name = "blacksmithpnl"
        Me.blacksmithpnl.Size = New System.Drawing.Size(519, 397)
        Me.blacksmithpnl.TabIndex = 0
        '
        'sellbtn
        '
        Me.sellbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sellbtn.Location = New System.Drawing.Point(189, 362)
        Me.sellbtn.Name = "sellbtn"
        Me.sellbtn.Size = New System.Drawing.Size(75, 23)
        Me.sellbtn.TabIndex = 37
        Me.sellbtn.Text = "sell items"
        Me.sellbtn.UseVisualStyleBackColor = True
        '
        'itemsTablepnl
        '
        Me.itemsTablepnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.itemsTablepnl.ColumnCount = 3
        Me.itemsTablepnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.itemsTablepnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.itemsTablepnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.itemsTablepnl.Controls.Add(Me.Panel1, 0, 0)
        Me.itemsTablepnl.Controls.Add(Me.Panel2, 2, 0)
        Me.itemsTablepnl.Location = New System.Drawing.Point(12, 12)
        Me.itemsTablepnl.Name = "itemsTablepnl"
        Me.itemsTablepnl.RowCount = 1
        Me.itemsTablepnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.itemsTablepnl.Size = New System.Drawing.Size(494, 344)
        Me.itemsTablepnl.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.weaponslst)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 338)
        Me.Panel1.TabIndex = 0
        '
        'weaponslst
        '
        Me.weaponslst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.weaponslst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.weaponColumn})
        Me.weaponslst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.weaponslst.FullRowSelect = True
        Me.weaponslst.HideSelection = False
        Me.weaponslst.Location = New System.Drawing.Point(0, 0)
        Me.weaponslst.MultiSelect = False
        Me.weaponslst.Name = "weaponslst"
        Me.weaponslst.ShowGroups = False
        Me.weaponslst.ShowItemToolTips = True
        Me.weaponslst.Size = New System.Drawing.Size(231, 338)
        Me.weaponslst.TabIndex = 2
        Me.weaponslst.UseCompatibleStateImageBehavior = False
        Me.weaponslst.View = System.Windows.Forms.View.Details
        '
        'weaponColumn
        '
        Me.weaponColumn.Text = "weapons"
        Me.weaponColumn.Width = 213
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.armorlst)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(260, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(231, 338)
        Me.Panel2.TabIndex = 1
        '
        'armorlst
        '
        Me.armorlst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.armorlst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.armorColumn})
        Me.armorlst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.armorlst.FullRowSelect = True
        Me.armorlst.HideSelection = False
        Me.armorlst.Location = New System.Drawing.Point(0, 0)
        Me.armorlst.MultiSelect = False
        Me.armorlst.Name = "armorlst"
        Me.armorlst.ShowGroups = False
        Me.armorlst.Size = New System.Drawing.Size(231, 338)
        Me.armorlst.TabIndex = 3
        Me.armorlst.UseCompatibleStateImageBehavior = False
        Me.armorlst.View = System.Windows.Forms.View.Details
        '
        'armorColumn
        '
        Me.armorColumn.Text = "armor"
        Me.armorColumn.Width = 214
        '
        'playerGoldlbl
        '
        Me.playerGoldlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerGoldlbl.AutoSize = True
        Me.playerGoldlbl.Location = New System.Drawing.Point(12, 367)
        Me.playerGoldlbl.Name = "playerGoldlbl"
        Me.playerGoldlbl.Size = New System.Drawing.Size(65, 13)
        Me.playerGoldlbl.TabIndex = 36
        Me.playerGoldlbl.Text = "player's gold"
        '
        'playerGoldtxt
        '
        Me.playerGoldtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerGoldtxt.Location = New System.Drawing.Point(83, 364)
        Me.playerGoldtxt.Name = "playerGoldtxt"
        Me.playerGoldtxt.ReadOnly = True
        Me.playerGoldtxt.Size = New System.Drawing.Size(100, 20)
        Me.playerGoldtxt.TabIndex = 35
        Me.playerGoldtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'marketbtn
        '
        Me.marketbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.marketbtn.Location = New System.Drawing.Point(270, 362)
        Me.marketbtn.Name = "marketbtn"
        Me.marketbtn.Size = New System.Drawing.Size(75, 23)
        Me.marketbtn.TabIndex = 34
        Me.marketbtn.Text = "front door"
        Me.marketbtn.UseVisualStyleBackColor = True
        '
        'playerbtn
        '
        Me.playerbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerbtn.Location = New System.Drawing.Point(351, 362)
        Me.playerbtn.Name = "playerbtn"
        Me.playerbtn.Size = New System.Drawing.Size(75, 23)
        Me.playerbtn.TabIndex = 33
        Me.playerbtn.Text = "player info"
        Me.playerbtn.UseVisualStyleBackColor = True
        '
        'mainMenubtn
        '
        Me.mainMenubtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainMenubtn.Location = New System.Drawing.Point(432, 362)
        Me.mainMenubtn.Name = "mainMenubtn"
        Me.mainMenubtn.Size = New System.Drawing.Size(75, 23)
        Me.mainMenubtn.TabIndex = 1
        Me.mainMenubtn.Text = "main menu"
        Me.mainMenubtn.UseVisualStyleBackColor = True
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BlacksmithStateItemsBindingSource1
        '
        Me.BlacksmithStateItemsBindingSource1.DataMember = "BlacksmithStateItems"
        Me.BlacksmithStateItemsBindingSource1.DataSource = Me.GameDatabaseDataSet
        '
        'BlacksmithStateItemsTableAdapter
        '
        Me.BlacksmithStateItemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArmorAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BattlesTableAdapter = Nothing
        Me.TableAdapterManager.BlacksmithStateItemsTableAdapter = Me.BlacksmithStateItemsTableAdapter
        Me.TableAdapterManager.BlacksmithStatesTableAdapter = Me.BlacksmithStatesTableAdapter
        Me.TableAdapterManager.ChemistStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ChemistStatesTableAdapter = Nothing
        Me.TableAdapterManager.EnemyPartiesTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStatesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerArmorTableAdapter = Nothing
        Me.TableAdapterManager.PlayerAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerJewelryTableAdapter = Nothing
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Nothing
        Me.TableAdapterManager.PlayerStatesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.RoadStatesTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStatesTableAdapter = Nothing
        Me.TableAdapterManager.StaticArmorTableAdapter = Me.StaticArmorTableAdapter
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampTiersTableAdapter = Nothing
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.StaticJewelryTableAdapter = Nothing
        Me.TableAdapterManager.StaticMobsTableAdapter = Nothing
        Me.TableAdapterManager.StaticQuestsTableAdapter = Nothing
        Me.TableAdapterManager.StaticSkillsTableAdapter = Nothing
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Me.StaticWeaponsTableAdapter
        Me.TableAdapterManager.TavernStatesTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = simplefantasygame.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Nothing
        '
        'BlacksmithStatesBindingSource1
        '
        Me.BlacksmithStatesBindingSource1.DataMember = "BlacksmithStates"
        Me.BlacksmithStatesBindingSource1.DataSource = Me.GameDatabaseDataSet
        '
        'BlacksmithStatesTableAdapter
        '
        Me.BlacksmithStatesTableAdapter.ClearBeforeFill = True
        '
        'StaticWeaponsBindingSource1
        '
        Me.StaticWeaponsBindingSource1.DataMember = "StaticWeapons"
        Me.StaticWeaponsBindingSource1.DataSource = Me.GameDatabaseDataSet
        '
        'StaticWeaponsTableAdapter
        '
        Me.StaticWeaponsTableAdapter.ClearBeforeFill = True
        '
        'StaticArmorBindingSource1
        '
        Me.StaticArmorBindingSource1.DataMember = "StaticArmor"
        Me.StaticArmorBindingSource1.DataSource = Me.GameDatabaseDataSet
        '
        'StaticArmorTableAdapter
        '
        Me.StaticArmorTableAdapter.ClearBeforeFill = True
        '
        'BlacksmithWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 397)
        Me.Controls.Add(Me.blacksmithpnl)
        Me.MinimumSize = New System.Drawing.Size(535, 242)
        Me.Name = "BlacksmithWindow"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "blacksmith"
        Me.blacksmithpnl.ResumeLayout(False)
        Me.blacksmithpnl.PerformLayout()
        Me.itemsTablepnl.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.BlacksmithStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlacksmithStateItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlacksmithStateItemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlacksmithStatesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents blacksmithpnl As Panel
    Friend WithEvents weaponslst As ListView
    Friend WithEvents mainMenubtn As Button
    Friend WithEvents armorlst As ListView
    Friend WithEvents playerGoldlbl As Label
    Friend WithEvents playerGoldtxt As TextBox
    Friend WithEvents marketbtn As Button
    Friend WithEvents playerbtn As Button
    Friend WithEvents itemsTablepnl As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents weaponColumn As ColumnHeader
    Friend WithEvents armorColumn As ColumnHeader
    Friend WithEvents BlacksmithStatesBindingSource As BindingSource
    Friend WithEvents BlacksmithStateItemsBindingSource As BindingSource
    Friend WithEvents PlayerStatesBindingSource As BindingSource
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents StaticArmorBindingSource As BindingSource
    Friend WithEvents StaticWeaponsBindingSource As BindingSource
    Friend WithEvents sellbtn As Button
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents BlacksmithStateItemsBindingSource1 As BindingSource
    Friend WithEvents BlacksmithStateItemsTableAdapter As GameDatabaseDataSetTableAdapters.BlacksmithStateItemsTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BlacksmithStatesTableAdapter As GameDatabaseDataSetTableAdapters.BlacksmithStatesTableAdapter
    Friend WithEvents BlacksmithStatesBindingSource1 As BindingSource
    Friend WithEvents StaticWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter
    Friend WithEvents StaticWeaponsBindingSource1 As BindingSource
    Friend WithEvents StaticArmorTableAdapter As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter
    Friend WithEvents StaticArmorBindingSource1 As BindingSource
End Class
