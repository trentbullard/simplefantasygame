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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left)
        Me.blacksmithpnl = New System.Windows.Forms.Panel()
        Me.sellbtn = New System.Windows.Forms.Button()
        Me.itemsTablepnl = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.weaponslst = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.armorlst = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playerGoldlbl = New System.Windows.Forms.Label()
        Me.playerGoldtxt = New System.Windows.Forms.TextBox()
        Me.marketbtn = New System.Windows.Forms.Button()
        Me.playerbtn = New System.Windows.Forms.Button()
        Me.mainMenubtn = New System.Windows.Forms.Button()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.BlacksmithStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlacksmithStatesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.BlacksmithStatesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BlacksmithStateItemsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.BlacksmithStateItemsTableAdapter()
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.PlayerStatesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter()
        Me.StaticArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        Me.StaticWeaponsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.BlacksmithStateItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.blacksmithpnl.SuspendLayout()
        Me.itemsTablepnl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlacksmithStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlacksmithStateItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.blacksmithpnl.Size = New System.Drawing.Size(519, 203)
        Me.blacksmithpnl.TabIndex = 0
        '
        'sellbtn
        '
        Me.sellbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sellbtn.Location = New System.Drawing.Point(189, 168)
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
        Me.itemsTablepnl.Size = New System.Drawing.Size(495, 133)
        Me.itemsTablepnl.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.weaponslst)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 127)
        Me.Panel1.TabIndex = 0
        '
        'weaponslst
        '
        Me.weaponslst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.weaponslst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.weaponslst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.weaponslst.FullRowSelect = True
        ListViewGroup1.Header = "ListViewGroup"
        ListViewGroup1.Name = "ListViewGroup1"
        Me.weaponslst.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        Me.weaponslst.HideSelection = False
        Me.weaponslst.Location = New System.Drawing.Point(0, 0)
        Me.weaponslst.MultiSelect = False
        Me.weaponslst.Name = "weaponslst"
        Me.weaponslst.ShowGroups = False
        Me.weaponslst.ShowItemToolTips = True
        Me.weaponslst.Size = New System.Drawing.Size(231, 127)
        Me.weaponslst.TabIndex = 2
        Me.weaponslst.UseCompatibleStateImageBehavior = False
        Me.weaponslst.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "weapons"
        Me.ColumnHeader1.Width = 213
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.armorlst)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(260, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 127)
        Me.Panel2.TabIndex = 1
        '
        'armorlst
        '
        Me.armorlst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.armorlst.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.armorlst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.armorlst.FullRowSelect = True
        ListViewGroup2.Header = "ListViewGroup"
        ListViewGroup2.Name = "ListViewGroup1"
        Me.armorlst.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup2})
        Me.armorlst.HideSelection = False
        Me.armorlst.Location = New System.Drawing.Point(0, 0)
        Me.armorlst.MultiSelect = False
        Me.armorlst.Name = "armorlst"
        Me.armorlst.ShowGroups = False
        Me.armorlst.Size = New System.Drawing.Size(232, 127)
        Me.armorlst.TabIndex = 3
        Me.armorlst.UseCompatibleStateImageBehavior = False
        Me.armorlst.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "armor"
        Me.ColumnHeader2.Width = 214
        '
        'playerGoldlbl
        '
        Me.playerGoldlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerGoldlbl.AutoSize = True
        Me.playerGoldlbl.Location = New System.Drawing.Point(12, 173)
        Me.playerGoldlbl.Name = "playerGoldlbl"
        Me.playerGoldlbl.Size = New System.Drawing.Size(65, 13)
        Me.playerGoldlbl.TabIndex = 36
        Me.playerGoldlbl.Text = "player's gold"
        '
        'playerGoldtxt
        '
        Me.playerGoldtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerGoldtxt.Location = New System.Drawing.Point(83, 170)
        Me.playerGoldtxt.Name = "playerGoldtxt"
        Me.playerGoldtxt.ReadOnly = True
        Me.playerGoldtxt.Size = New System.Drawing.Size(100, 20)
        Me.playerGoldtxt.TabIndex = 35
        Me.playerGoldtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'marketbtn
        '
        Me.marketbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.marketbtn.Location = New System.Drawing.Point(270, 168)
        Me.marketbtn.Name = "marketbtn"
        Me.marketbtn.Size = New System.Drawing.Size(75, 23)
        Me.marketbtn.TabIndex = 34
        Me.marketbtn.Text = "front door"
        Me.marketbtn.UseVisualStyleBackColor = True
        '
        'playerbtn
        '
        Me.playerbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerbtn.Location = New System.Drawing.Point(351, 168)
        Me.playerbtn.Name = "playerbtn"
        Me.playerbtn.Size = New System.Drawing.Size(75, 23)
        Me.playerbtn.TabIndex = 33
        Me.playerbtn.Text = "player info"
        Me.playerbtn.UseVisualStyleBackColor = True
        '
        'mainMenubtn
        '
        Me.mainMenubtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainMenubtn.Location = New System.Drawing.Point(432, 168)
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
        'BlacksmithStatesBindingSource
        '
        Me.BlacksmithStatesBindingSource.DataMember = "BlacksmithStates"
        Me.BlacksmithStatesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'BlacksmithStatesTableAdapter
        '
        Me.BlacksmithStatesTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.PlayersTableAdapter = Me.PlayersTableAdapter
        Me.TableAdapterManager.PlayerStatesTableAdapter = Me.PlayerStatesTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Nothing
        '
        'BlacksmithStateItemsTableAdapter
        '
        Me.BlacksmithStateItemsTableAdapter.ClearBeforeFill = True
        '
        'PlayersTableAdapter
        '
        Me.PlayersTableAdapter.ClearBeforeFill = True
        '
        'PlayerStatesTableAdapter
        '
        Me.PlayerStatesTableAdapter.ClearBeforeFill = True
        '
        'StaticArmorTableAdapter
        '
        Me.StaticArmorTableAdapter.ClearBeforeFill = True
        '
        'StaticWeaponsTableAdapter
        '
        Me.StaticWeaponsTableAdapter.ClearBeforeFill = True
        '
        'BlacksmithStateItemsBindingSource
        '
        Me.BlacksmithStateItemsBindingSource.DataMember = "BlacksmithStateItems"
        Me.BlacksmithStateItemsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerStatesBindingSource
        '
        Me.PlayerStatesBindingSource.DataMember = "PlayerStates"
        Me.PlayerStatesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayersBindingSource
        '
        Me.PlayersBindingSource.DataMember = "Players"
        Me.PlayersBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticArmorBindingSource
        '
        Me.StaticArmorBindingSource.DataMember = "StaticArmor"
        Me.StaticArmorBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticWeaponsBindingSource
        '
        Me.StaticWeaponsBindingSource.DataMember = "StaticWeapons"
        Me.StaticWeaponsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'BlacksmithWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 203)
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
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlacksmithStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlacksmithStateItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents BlacksmithStatesBindingSource As BindingSource
    Friend WithEvents BlacksmithStatesTableAdapter As GameDatabaseDataSetTableAdapters.BlacksmithStatesTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BlacksmithStateItemsTableAdapter As GameDatabaseDataSetTableAdapters.BlacksmithStateItemsTableAdapter
    Friend WithEvents BlacksmithStateItemsBindingSource As BindingSource
    Friend WithEvents PlayerStatesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter
    Friend WithEvents PlayerStatesBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents StaticArmorTableAdapter As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter
    Friend WithEvents StaticArmorBindingSource As BindingSource
    Friend WithEvents StaticWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter
    Friend WithEvents StaticWeaponsBindingSource As BindingSource
    Friend WithEvents sellbtn As Button
End Class
