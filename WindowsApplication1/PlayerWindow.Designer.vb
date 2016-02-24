<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlayerWindow
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
        Me.playerStatspnl = New System.Windows.Forms.Panel()
        Me.playerGoldlbl = New System.Windows.Forms.Label()
        Me.playerLevellbl = New System.Windows.Forms.Label()
        Me.playerGoldtxt = New System.Windows.Forms.TextBox()
        Me.playerLeveltxt = New System.Windows.Forms.TextBox()
        Me.playerSkillTreebtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.itemslbl = New System.Windows.Forms.Label()
        Me.creatureListlbl = New System.Windows.Forms.Label()
        Me.itemstbl = New System.Windows.Forms.TableLayoutPanel()
        Me.creaturelst = New System.Windows.Forms.ListBox()
        Me.itemslst = New System.Windows.Forms.ListBox()
        Me.noActiveQuestlbl = New System.Windows.Forms.Label()
        Me.currentQuestlbl = New System.Windows.Forms.LinkLabel()
        Me.currentQuestrtxt = New System.Windows.Forms.RichTextBox()
        Me.playerExperiencelbl = New System.Windows.Forms.Label()
        Me.playerExperiencebar = New System.Windows.Forms.ProgressBar()
        Me.playerMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportPlayerDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameDatabaseDataSet = New simplefantasygame.GameDatabaseDataSet()
        Me.ArmorAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArmorAugmentsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.ArmorAugmentsTableAdapter()
        Me.TableAdapterManager = New simplefantasygame.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlayerArmorTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter()
        Me.PlayerConsumablesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter()
        Me.PlayerCreaturesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.PlayerPartiesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerPartiesTableAdapter()
        Me.PlayersTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.PlayerStatesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter()
        Me.PlayerWeaponsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter()
        Me.StaticArmorTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        Me.StaticAugmentsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter()
        Me.StaticConsumablesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticConsumablesTableAdapter()
        Me.StaticCreaturesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter()
        Me.StaticQuestsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticQuestsTableAdapter()
        Me.StaticWeaponsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.WeaponAugmentsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.WeaponAugmentsTableAdapter()
        Me.PlayerArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerConsumablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerPartiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticConsumablesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticQuestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeaponAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.playerStatspnl.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.itemstbl.SuspendLayout()
        Me.playerMenuStrip.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArmorAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerConsumablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerPartiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticConsumablesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticQuestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeaponAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playerStatspnl
        '
        Me.playerStatspnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.playerStatspnl.Controls.Add(Me.playerGoldlbl)
        Me.playerStatspnl.Controls.Add(Me.playerLevellbl)
        Me.playerStatspnl.Controls.Add(Me.playerGoldtxt)
        Me.playerStatspnl.Controls.Add(Me.playerLeveltxt)
        Me.playerStatspnl.Controls.Add(Me.playerSkillTreebtn)
        Me.playerStatspnl.Controls.Add(Me.TableLayoutPanel1)
        Me.playerStatspnl.Controls.Add(Me.itemstbl)
        Me.playerStatspnl.Controls.Add(Me.noActiveQuestlbl)
        Me.playerStatspnl.Controls.Add(Me.currentQuestlbl)
        Me.playerStatspnl.Controls.Add(Me.currentQuestrtxt)
        Me.playerStatspnl.Controls.Add(Me.playerExperiencelbl)
        Me.playerStatspnl.Controls.Add(Me.playerExperiencebar)
        Me.playerStatspnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.playerStatspnl.Location = New System.Drawing.Point(0, 24)
        Me.playerStatspnl.Name = "playerStatspnl"
        Me.playerStatspnl.Size = New System.Drawing.Size(566, 502)
        Me.playerStatspnl.TabIndex = 5
        '
        'playerGoldlbl
        '
        Me.playerGoldlbl.AutoSize = True
        Me.playerGoldlbl.ForeColor = System.Drawing.Color.White
        Me.playerGoldlbl.Location = New System.Drawing.Point(11, 29)
        Me.playerGoldlbl.Name = "playerGoldlbl"
        Me.playerGoldlbl.Size = New System.Drawing.Size(27, 13)
        Me.playerGoldlbl.TabIndex = 13
        Me.playerGoldlbl.Text = "gold"
        '
        'playerLevellbl
        '
        Me.playerLevellbl.AutoSize = True
        Me.playerLevellbl.ForeColor = System.Drawing.Color.White
        Me.playerLevellbl.Location = New System.Drawing.Point(9, 55)
        Me.playerLevellbl.Name = "playerLevellbl"
        Me.playerLevellbl.Size = New System.Drawing.Size(29, 13)
        Me.playerLevellbl.TabIndex = 15
        Me.playerLevellbl.Text = "level"
        '
        'playerGoldtxt
        '
        Me.playerGoldtxt.Location = New System.Drawing.Point(44, 26)
        Me.playerGoldtxt.Name = "playerGoldtxt"
        Me.playerGoldtxt.ReadOnly = True
        Me.playerGoldtxt.Size = New System.Drawing.Size(54, 20)
        Me.playerGoldtxt.TabIndex = 12
        '
        'playerLeveltxt
        '
        Me.playerLeveltxt.Location = New System.Drawing.Point(44, 52)
        Me.playerLeveltxt.Name = "playerLeveltxt"
        Me.playerLeveltxt.ReadOnly = True
        Me.playerLeveltxt.Size = New System.Drawing.Size(54, 20)
        Me.playerLeveltxt.TabIndex = 14
        '
        'playerSkillTreebtn
        '
        Me.playerSkillTreebtn.Location = New System.Drawing.Point(44, 78)
        Me.playerSkillTreebtn.Name = "playerSkillTreebtn"
        Me.playerSkillTreebtn.Size = New System.Drawing.Size(54, 23)
        Me.playerSkillTreebtn.TabIndex = 13
        Me.playerSkillTreebtn.Text = "skills"
        Me.playerSkillTreebtn.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.itemslbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.creatureListlbl, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 82)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(542, 22)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'itemslbl
        '
        Me.itemslbl.AutoSize = True
        Me.itemslbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.itemslbl.ForeColor = System.Drawing.Color.White
        Me.itemslbl.Location = New System.Drawing.Point(274, 9)
        Me.itemslbl.Name = "itemslbl"
        Me.itemslbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.itemslbl.Size = New System.Drawing.Size(265, 13)
        Me.itemslbl.TabIndex = 25
        Me.itemslbl.Text = "items in inventory"
        Me.itemslbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'creatureListlbl
        '
        Me.creatureListlbl.AutoSize = True
        Me.creatureListlbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.creatureListlbl.ForeColor = System.Drawing.Color.White
        Me.creatureListlbl.Location = New System.Drawing.Point(3, 9)
        Me.creatureListlbl.Name = "creatureListlbl"
        Me.creatureListlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.creatureListlbl.Size = New System.Drawing.Size(265, 13)
        Me.creatureListlbl.TabIndex = 18
        Me.creatureListlbl.Text = "creatures owned"
        Me.creatureListlbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'itemstbl
        '
        Me.itemstbl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.itemstbl.ColumnCount = 2
        Me.itemstbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.itemstbl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.itemstbl.Controls.Add(Me.creaturelst, 0, 0)
        Me.itemstbl.Controls.Add(Me.itemslst, 1, 0)
        Me.itemstbl.Location = New System.Drawing.Point(12, 107)
        Me.itemstbl.Name = "itemstbl"
        Me.itemstbl.RowCount = 1
        Me.itemstbl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.itemstbl.Size = New System.Drawing.Size(542, 182)
        Me.itemstbl.TabIndex = 26
        '
        'creaturelst
        '
        Me.creaturelst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.creaturelst.FormattingEnabled = True
        Me.creaturelst.Location = New System.Drawing.Point(3, 3)
        Me.creaturelst.Name = "creaturelst"
        Me.creaturelst.Size = New System.Drawing.Size(265, 176)
        Me.creaturelst.TabIndex = 17
        '
        'itemslst
        '
        Me.itemslst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemslst.FormattingEnabled = True
        Me.itemslst.Location = New System.Drawing.Point(274, 3)
        Me.itemslst.Name = "itemslst"
        Me.itemslst.Size = New System.Drawing.Size(265, 176)
        Me.itemslst.TabIndex = 24
        '
        'noActiveQuestlbl
        '
        Me.noActiveQuestlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.noActiveQuestlbl.AutoSize = True
        Me.noActiveQuestlbl.BackColor = System.Drawing.Color.Transparent
        Me.noActiveQuestlbl.ForeColor = System.Drawing.Color.White
        Me.noActiveQuestlbl.Location = New System.Drawing.Point(485, 307)
        Me.noActiveQuestlbl.Name = "noActiveQuestlbl"
        Me.noActiveQuestlbl.Size = New System.Drawing.Size(69, 13)
        Me.noActiveQuestlbl.TabIndex = 23
        Me.noActiveQuestlbl.Text = "current quest"
        '
        'currentQuestlbl
        '
        Me.currentQuestlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentQuestlbl.AutoSize = True
        Me.currentQuestlbl.Enabled = False
        Me.currentQuestlbl.LinkColor = System.Drawing.Color.White
        Me.currentQuestlbl.Location = New System.Drawing.Point(485, 307)
        Me.currentQuestlbl.Name = "currentQuestlbl"
        Me.currentQuestlbl.Size = New System.Drawing.Size(69, 13)
        Me.currentQuestlbl.TabIndex = 22
        Me.currentQuestlbl.TabStop = True
        Me.currentQuestlbl.Text = "current quest"
        Me.currentQuestlbl.Visible = False
        '
        'currentQuestrtxt
        '
        Me.currentQuestrtxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.currentQuestrtxt.Location = New System.Drawing.Point(12, 323)
        Me.currentQuestrtxt.Name = "currentQuestrtxt"
        Me.currentQuestrtxt.ReadOnly = True
        Me.currentQuestrtxt.Size = New System.Drawing.Size(542, 121)
        Me.currentQuestrtxt.TabIndex = 21
        Me.currentQuestrtxt.Text = ""
        '
        'playerExperiencelbl
        '
        Me.playerExperiencelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerExperiencelbl.AutoSize = True
        Me.playerExperiencelbl.ForeColor = System.Drawing.Color.White
        Me.playerExperiencelbl.Location = New System.Drawing.Point(495, 461)
        Me.playerExperiencelbl.Name = "playerExperiencelbl"
        Me.playerExperiencelbl.Size = New System.Drawing.Size(59, 13)
        Me.playerExperiencelbl.TabIndex = 14
        Me.playerExperiencelbl.Text = "experience"
        '
        'playerExperiencebar
        '
        Me.playerExperiencebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerExperiencebar.Location = New System.Drawing.Point(12, 477)
        Me.playerExperiencebar.Name = "playerExperiencebar"
        Me.playerExperiencebar.Size = New System.Drawing.Size(542, 13)
        Me.playerExperiencebar.Step = 1
        Me.playerExperiencebar.TabIndex = 13
        '
        'playerMenuStrip
        '
        Me.playerMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.playerMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.playerMenuStrip.Name = "playerMenuStrip"
        Me.playerMenuStrip.Size = New System.Drawing.Size(566, 24)
        Me.playerMenuStrip.TabIndex = 6
        Me.playerMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportPlayerDataToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'ImportPlayerDataToolStripMenuItem
        '
        Me.ImportPlayerDataToolStripMenuItem.Enabled = False
        Me.ImportPlayerDataToolStripMenuItem.Name = "ImportPlayerDataToolStripMenuItem"
        Me.ImportPlayerDataToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ImportPlayerDataToolStripMenuItem.Text = "import"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Enabled = False
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExportToolStripMenuItem.Text = "export"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "edit"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.NameToolStripMenuItem.Text = "name"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuestsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.HelpToolStripMenuItem.Text = "help"
        '
        'QuestsToolStripMenuItem
        '
        Me.QuestsToolStripMenuItem.Name = "QuestsToolStripMenuItem"
        Me.QuestsToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.QuestsToolStripMenuItem.Text = "quests"
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
        Me.TableAdapterManager.BattlesTableAdapter = Nothing
        Me.TableAdapterManager.BlacksmithStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.BlacksmithStatesTableAdapter = Nothing
        Me.TableAdapterManager.ChemistStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ChemistStatesTableAdapter = Nothing
        Me.TableAdapterManager.EnemyPartiesTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStatesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerArmorTableAdapter = Me.PlayerArmorTableAdapter
        Me.TableAdapterManager.PlayerAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Me.PlayerConsumablesTableAdapter
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Me.PlayerCreaturesTableAdapter
        Me.TableAdapterManager.PlayerJewelryTableAdapter = Nothing
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Me.PlayerPartiesTableAdapter
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
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Me.StaticConsumablesTableAdapter
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Me.StaticCreaturesTableAdapter
        Me.TableAdapterManager.StaticJewelryTableAdapter = Nothing
        Me.TableAdapterManager.StaticMobsTableAdapter = Nothing
        Me.TableAdapterManager.StaticQuestsTableAdapter = Me.StaticQuestsTableAdapter
        Me.TableAdapterManager.StaticSkillsTableAdapter = Nothing
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Me.StaticWeaponsTableAdapter
        Me.TableAdapterManager.TavernStatesTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = simplefantasygame.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Me.WeaponAugmentsTableAdapter
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
        'PlayerPartiesTableAdapter
        '
        Me.PlayerPartiesTableAdapter.ClearBeforeFill = True
        '
        'PlayersTableAdapter
        '
        Me.PlayersTableAdapter.ClearBeforeFill = True
        '
        'PlayerStatesTableAdapter
        '
        Me.PlayerStatesTableAdapter.ClearBeforeFill = True
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
        'StaticQuestsTableAdapter
        '
        Me.StaticQuestsTableAdapter.ClearBeforeFill = True
        '
        'StaticWeaponsTableAdapter
        '
        Me.StaticWeaponsTableAdapter.ClearBeforeFill = True
        '
        'WeaponAugmentsTableAdapter
        '
        Me.WeaponAugmentsTableAdapter.ClearBeforeFill = True
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
        'PlayerPartiesBindingSource
        '
        Me.PlayerPartiesBindingSource.DataMember = "PlayerParties"
        Me.PlayerPartiesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerStatesBindingSource
        '
        Me.PlayerStatesBindingSource.DataMember = "PlayerStates"
        Me.PlayerStatesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerWeaponsBindingSource
        '
        Me.PlayerWeaponsBindingSource.DataMember = "PlayerWeapons"
        Me.PlayerWeaponsBindingSource.DataSource = Me.GameDatabaseDataSet
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
        'StaticQuestsBindingSource
        '
        Me.StaticQuestsBindingSource.DataMember = "StaticQuests"
        Me.StaticQuestsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticWeaponsBindingSource
        '
        Me.StaticWeaponsBindingSource.DataMember = "StaticWeapons"
        Me.StaticWeaponsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'WeaponAugmentsBindingSource
        '
        Me.WeaponAugmentsBindingSource.DataMember = "WeaponAugments"
        Me.WeaponAugmentsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 526)
        Me.Controls.Add(Me.playerStatspnl)
        Me.Controls.Add(Me.playerMenuStrip)
        Me.MainMenuStrip = Me.playerMenuStrip
        Me.MinimumSize = New System.Drawing.Size(414, 494)
        Me.Name = "PlayerWindow"
        Me.ShowIcon = False
        Me.Text = "player"
        Me.playerStatspnl.ResumeLayout(False)
        Me.playerStatspnl.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.itemstbl.ResumeLayout(False)
        Me.playerMenuStrip.ResumeLayout(False)
        Me.playerMenuStrip.PerformLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArmorAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerConsumablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerPartiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticConsumablesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticQuestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeaponAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents playerStatspnl As Panel
    Friend WithEvents playerSkillTreebtn As Button
    Friend WithEvents playerExperiencelbl As Label
    Friend WithEvents playerGoldlbl As Label
    Friend WithEvents playerExperiencebar As ProgressBar
    Friend WithEvents playerLevellbl As Label
    Friend WithEvents playerGoldtxt As TextBox
    Friend WithEvents playerLeveltxt As TextBox
    Friend WithEvents creaturelst As ListBox
    Friend WithEvents playerMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportPlayerDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents currentQuestrtxt As RichTextBox
    Friend WithEvents creatureListlbl As Label
    Friend WithEvents currentQuestlbl As LinkLabel
    Friend WithEvents noActiveQuestlbl As Label
    Friend WithEvents QuestsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents itemslst As ListBox
    Friend WithEvents itemslbl As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents itemstbl As TableLayoutPanel
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents ArmorAugmentsBindingSource As BindingSource
    Friend WithEvents ArmorAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.ArmorAugmentsTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlayerArmorTableAdapter As GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter
    Friend WithEvents PlayerArmorBindingSource As BindingSource
    Friend WithEvents PlayerConsumablesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerConsumablesTableAdapter
    Friend WithEvents PlayerConsumablesBindingSource As BindingSource
    Friend WithEvents PlayerCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter
    Friend WithEvents PlayerCreaturesBindingSource As BindingSource
    Friend WithEvents PlayerPartiesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerPartiesTableAdapter
    Friend WithEvents PlayerPartiesBindingSource As BindingSource
    Friend WithEvents PlayerStatesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter
    Friend WithEvents PlayerStatesBindingSource As BindingSource
    Friend WithEvents PlayerWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter
    Friend WithEvents PlayerWeaponsBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents StaticArmorTableAdapter As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter
    Friend WithEvents StaticArmorBindingSource As BindingSource
    Friend WithEvents StaticAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter
    Friend WithEvents StaticAugmentsBindingSource As BindingSource
    Friend WithEvents StaticConsumablesTableAdapter As GameDatabaseDataSetTableAdapters.StaticConsumablesTableAdapter
    Friend WithEvents StaticConsumablesBindingSource As BindingSource
    Friend WithEvents StaticCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter
    Friend WithEvents StaticCreaturesBindingSource As BindingSource
    Friend WithEvents StaticQuestsTableAdapter As GameDatabaseDataSetTableAdapters.StaticQuestsTableAdapter
    Friend WithEvents StaticQuestsBindingSource As BindingSource
    Friend WithEvents StaticWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter
    Friend WithEvents StaticWeaponsBindingSource As BindingSource
    Friend WithEvents WeaponAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.WeaponAugmentsTableAdapter
    Friend WithEvents WeaponAugmentsBindingSource As BindingSource
End Class
