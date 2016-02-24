<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreatureWindow
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
        Me.mainLayoutpnl = New System.Windows.Forms.TableLayoutPanel()
        Me.GameDatabaseDataSet = New simplefantasygame.GameDatabaseDataSet()
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.TableAdapterManager = New simplefantasygame.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.namelbl = New System.Windows.Forms.LinkLabel()
        Me.initiativelbl = New System.Windows.Forms.Label()
        Me.wisdomlbl = New System.Windows.Forms.Label()
        Me.intelligencelbl = New System.Windows.Forms.Label()
        Me.dexteritylbl = New System.Windows.Forms.Label()
        Me.strengthlbl = New System.Windows.Forms.Label()
        Me.armorlbl = New System.Windows.Forms.Label()
        Me.healthlbl = New System.Windows.Forms.Label()
        Me.maxHealthlbl = New System.Windows.Forms.Label()
        Me.experiencelbl = New System.Windows.Forms.Label()
        Me.levellbl = New System.Windows.Forms.Label()
        Me.specieslbl = New System.Windows.Forms.Label()
        Me.wisdomtxt = New System.Windows.Forms.TextBox()
        Me.initiativetxt = New System.Windows.Forms.TextBox()
        Me.intelligencetxt = New System.Windows.Forms.TextBox()
        Me.dexteritytxt = New System.Windows.Forms.TextBox()
        Me.strengthtxt = New System.Windows.Forms.TextBox()
        Me.armortxt = New System.Windows.Forms.TextBox()
        Me.healthtxt = New System.Windows.Forms.TextBox()
        Me.maxHPtxt = New System.Windows.Forms.TextBox()
        Me.experiencetxt = New System.Windows.Forms.TextBox()
        Me.leveltxt = New System.Windows.Forms.TextBox()
        Me.speciestxt = New System.Windows.Forms.TextBox()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.classtxt = New System.Windows.Forms.TextBox()
        Me.statspnl = New System.Windows.Forms.TableLayoutPanel()
        Me.classlbl = New System.Windows.Forms.LinkLabel()
        Me.mainLayoutpnl.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.statspnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainLayoutpnl
        '
        Me.mainLayoutpnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.mainLayoutpnl.ColumnCount = 2
        Me.mainLayoutpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195.0!))
        Me.mainLayoutpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainLayoutpnl.Controls.Add(Me.statspnl, 0, 0)
        Me.mainLayoutpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainLayoutpnl.Location = New System.Drawing.Point(0, 0)
        Me.mainLayoutpnl.Name = "mainLayoutpnl"
        Me.mainLayoutpnl.RowCount = 2
        Me.mainLayoutpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 384.0!))
        Me.mainLayoutpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainLayoutpnl.Size = New System.Drawing.Size(383, 520)
        Me.mainLayoutpnl.TabIndex = 0
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.ArmorAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BattlesTableAdapter = Nothing
        Me.TableAdapterManager.BlacksmithStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.BlacksmithStatesTableAdapter = Nothing
        Me.TableAdapterManager.ChemistStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ChemistStatesTableAdapter = Nothing
        Me.TableAdapterManager.EnemyPartiesTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.FarmerStatesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerArmorTableAdapter = Nothing
        Me.TableAdapterManager.PlayerAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Me.PlayerCreaturesTableAdapter
        Me.TableAdapterManager.PlayerJewelryTableAdapter = Nothing
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Nothing
        Me.TableAdapterManager.PlayerStatesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.RoadStatesTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStatesTableAdapter = Nothing
        Me.TableAdapterManager.StaticArmorTableAdapter = Nothing
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampTiersTableAdapter = Nothing
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.StaticJewelryTableAdapter = Nothing
        Me.TableAdapterManager.StaticMobsTableAdapter = Nothing
        Me.TableAdapterManager.StaticQuestsTableAdapter = Nothing
        Me.TableAdapterManager.StaticSkillsTableAdapter = Nothing
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.TavernStatesTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = simplefantasygame.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Nothing
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.namelbl.Location = New System.Drawing.Point(4, 1)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(72, 28)
        Me.namelbl.TabIndex = 27
        Me.namelbl.TabStop = True
        Me.namelbl.Text = "name"
        Me.namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'initiativelbl
        '
        Me.initiativelbl.AutoSize = True
        Me.initiativelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.initiativelbl.Location = New System.Drawing.Point(4, 320)
        Me.initiativelbl.Name = "initiativelbl"
        Me.initiativelbl.Size = New System.Drawing.Size(72, 28)
        Me.initiativelbl.TabIndex = 11
        Me.initiativelbl.Text = "initiative"
        Me.initiativelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'wisdomlbl
        '
        Me.wisdomlbl.AutoSize = True
        Me.wisdomlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wisdomlbl.Location = New System.Drawing.Point(4, 349)
        Me.wisdomlbl.Name = "wisdomlbl"
        Me.wisdomlbl.Size = New System.Drawing.Size(72, 28)
        Me.wisdomlbl.TabIndex = 10
        Me.wisdomlbl.Text = "wisdom"
        Me.wisdomlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'intelligencelbl
        '
        Me.intelligencelbl.AutoSize = True
        Me.intelligencelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.intelligencelbl.Location = New System.Drawing.Point(4, 291)
        Me.intelligencelbl.Name = "intelligencelbl"
        Me.intelligencelbl.Size = New System.Drawing.Size(72, 28)
        Me.intelligencelbl.TabIndex = 12
        Me.intelligencelbl.Text = "intelligence"
        Me.intelligencelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dexteritylbl
        '
        Me.dexteritylbl.AutoSize = True
        Me.dexteritylbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dexteritylbl.Location = New System.Drawing.Point(4, 262)
        Me.dexteritylbl.Name = "dexteritylbl"
        Me.dexteritylbl.Size = New System.Drawing.Size(72, 28)
        Me.dexteritylbl.TabIndex = 13
        Me.dexteritylbl.Text = "dexterity"
        Me.dexteritylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'strengthlbl
        '
        Me.strengthlbl.AutoSize = True
        Me.strengthlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.strengthlbl.Location = New System.Drawing.Point(4, 233)
        Me.strengthlbl.Name = "strengthlbl"
        Me.strengthlbl.Size = New System.Drawing.Size(72, 28)
        Me.strengthlbl.TabIndex = 14
        Me.strengthlbl.Text = "strength"
        Me.strengthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'armorlbl
        '
        Me.armorlbl.AutoSize = True
        Me.armorlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.armorlbl.Location = New System.Drawing.Point(4, 204)
        Me.armorlbl.Name = "armorlbl"
        Me.armorlbl.Size = New System.Drawing.Size(72, 28)
        Me.armorlbl.TabIndex = 15
        Me.armorlbl.Text = "armor"
        Me.armorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'healthlbl
        '
        Me.healthlbl.AutoSize = True
        Me.healthlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.healthlbl.Location = New System.Drawing.Point(4, 175)
        Me.healthlbl.Name = "healthlbl"
        Me.healthlbl.Size = New System.Drawing.Size(72, 28)
        Me.healthlbl.TabIndex = 9
        Me.healthlbl.Text = "current health"
        Me.healthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxHealthlbl
        '
        Me.maxHealthlbl.AutoSize = True
        Me.maxHealthlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maxHealthlbl.Location = New System.Drawing.Point(4, 146)
        Me.maxHealthlbl.Name = "maxHealthlbl"
        Me.maxHealthlbl.Size = New System.Drawing.Size(72, 28)
        Me.maxHealthlbl.TabIndex = 8
        Me.maxHealthlbl.Text = "max health"
        Me.maxHealthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'experiencelbl
        '
        Me.experiencelbl.AutoSize = True
        Me.experiencelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.experiencelbl.Location = New System.Drawing.Point(4, 117)
        Me.experiencelbl.Name = "experiencelbl"
        Me.experiencelbl.Size = New System.Drawing.Size(72, 28)
        Me.experiencelbl.TabIndex = 4
        Me.experiencelbl.Text = "experience"
        Me.experiencelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'levellbl
        '
        Me.levellbl.AutoSize = True
        Me.levellbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.levellbl.Location = New System.Drawing.Point(4, 88)
        Me.levellbl.Name = "levellbl"
        Me.levellbl.Size = New System.Drawing.Size(72, 28)
        Me.levellbl.TabIndex = 6
        Me.levellbl.Text = "level"
        Me.levellbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'specieslbl
        '
        Me.specieslbl.AutoSize = True
        Me.specieslbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.specieslbl.Location = New System.Drawing.Point(4, 59)
        Me.specieslbl.Name = "specieslbl"
        Me.specieslbl.Size = New System.Drawing.Size(72, 28)
        Me.specieslbl.TabIndex = 2
        Me.specieslbl.Text = "species"
        Me.specieslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'wisdomtxt
        '
        Me.wisdomtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wisdomtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wisdomtxt.Location = New System.Drawing.Point(83, 353)
        Me.wisdomtxt.Name = "wisdomtxt"
        Me.wisdomtxt.ReadOnly = True
        Me.wisdomtxt.Size = New System.Drawing.Size(102, 20)
        Me.wisdomtxt.TabIndex = 26
        '
        'initiativetxt
        '
        Me.initiativetxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.initiativetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.initiativetxt.Location = New System.Drawing.Point(83, 324)
        Me.initiativetxt.Name = "initiativetxt"
        Me.initiativetxt.ReadOnly = True
        Me.initiativetxt.Size = New System.Drawing.Size(102, 20)
        Me.initiativetxt.TabIndex = 25
        '
        'intelligencetxt
        '
        Me.intelligencetxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.intelligencetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.intelligencetxt.Location = New System.Drawing.Point(83, 295)
        Me.intelligencetxt.Name = "intelligencetxt"
        Me.intelligencetxt.ReadOnly = True
        Me.intelligencetxt.Size = New System.Drawing.Size(102, 20)
        Me.intelligencetxt.TabIndex = 24
        '
        'dexteritytxt
        '
        Me.dexteritytxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dexteritytxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dexteritytxt.Location = New System.Drawing.Point(83, 266)
        Me.dexteritytxt.Name = "dexteritytxt"
        Me.dexteritytxt.ReadOnly = True
        Me.dexteritytxt.Size = New System.Drawing.Size(102, 20)
        Me.dexteritytxt.TabIndex = 23
        '
        'strengthtxt
        '
        Me.strengthtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.strengthtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.strengthtxt.Location = New System.Drawing.Point(83, 237)
        Me.strengthtxt.Name = "strengthtxt"
        Me.strengthtxt.ReadOnly = True
        Me.strengthtxt.Size = New System.Drawing.Size(102, 20)
        Me.strengthtxt.TabIndex = 22
        '
        'armortxt
        '
        Me.armortxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.armortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.armortxt.Location = New System.Drawing.Point(83, 208)
        Me.armortxt.Name = "armortxt"
        Me.armortxt.ReadOnly = True
        Me.armortxt.Size = New System.Drawing.Size(102, 20)
        Me.armortxt.TabIndex = 21
        '
        'healthtxt
        '
        Me.healthtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.healthtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.healthtxt.Location = New System.Drawing.Point(83, 179)
        Me.healthtxt.Name = "healthtxt"
        Me.healthtxt.ReadOnly = True
        Me.healthtxt.Size = New System.Drawing.Size(102, 20)
        Me.healthtxt.TabIndex = 20
        '
        'maxHPtxt
        '
        Me.maxHPtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxHPtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.maxHPtxt.Location = New System.Drawing.Point(83, 150)
        Me.maxHPtxt.Name = "maxHPtxt"
        Me.maxHPtxt.ReadOnly = True
        Me.maxHPtxt.Size = New System.Drawing.Size(102, 20)
        Me.maxHPtxt.TabIndex = 19
        '
        'experiencetxt
        '
        Me.experiencetxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.experiencetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.experiencetxt.Location = New System.Drawing.Point(83, 121)
        Me.experiencetxt.Name = "experiencetxt"
        Me.experiencetxt.ReadOnly = True
        Me.experiencetxt.Size = New System.Drawing.Size(102, 20)
        Me.experiencetxt.TabIndex = 17
        '
        'leveltxt
        '
        Me.leveltxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.leveltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.leveltxt.Location = New System.Drawing.Point(83, 92)
        Me.leveltxt.Name = "leveltxt"
        Me.leveltxt.ReadOnly = True
        Me.leveltxt.Size = New System.Drawing.Size(102, 20)
        Me.leveltxt.TabIndex = 7
        '
        'speciestxt
        '
        Me.speciestxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.speciestxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.speciestxt.Location = New System.Drawing.Point(83, 63)
        Me.speciestxt.Name = "speciestxt"
        Me.speciestxt.ReadOnly = True
        Me.speciestxt.Size = New System.Drawing.Size(102, 20)
        Me.speciestxt.TabIndex = 5
        '
        'nametxt
        '
        Me.nametxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nametxt.Location = New System.Drawing.Point(83, 5)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.ReadOnly = True
        Me.nametxt.Size = New System.Drawing.Size(102, 20)
        Me.nametxt.TabIndex = 0
        '
        'classtxt
        '
        Me.classtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.classtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.classtxt.Location = New System.Drawing.Point(83, 34)
        Me.classtxt.Name = "classtxt"
        Me.classtxt.ReadOnly = True
        Me.classtxt.Size = New System.Drawing.Size(102, 20)
        Me.classtxt.TabIndex = 3
        '
        'statspnl
        '
        Me.statspnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statspnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.statspnl.ColumnCount = 2
        Me.statspnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.statspnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.statspnl.Controls.Add(Me.classtxt, 1, 1)
        Me.statspnl.Controls.Add(Me.nametxt, 1, 0)
        Me.statspnl.Controls.Add(Me.speciestxt, 1, 2)
        Me.statspnl.Controls.Add(Me.leveltxt, 1, 3)
        Me.statspnl.Controls.Add(Me.experiencetxt, 1, 4)
        Me.statspnl.Controls.Add(Me.maxHPtxt, 1, 5)
        Me.statspnl.Controls.Add(Me.healthtxt, 1, 6)
        Me.statspnl.Controls.Add(Me.armortxt, 1, 7)
        Me.statspnl.Controls.Add(Me.strengthtxt, 1, 8)
        Me.statspnl.Controls.Add(Me.dexteritytxt, 1, 9)
        Me.statspnl.Controls.Add(Me.intelligencetxt, 1, 10)
        Me.statspnl.Controls.Add(Me.initiativetxt, 1, 11)
        Me.statspnl.Controls.Add(Me.wisdomtxt, 1, 12)
        Me.statspnl.Controls.Add(Me.specieslbl, 0, 2)
        Me.statspnl.Controls.Add(Me.levellbl, 0, 3)
        Me.statspnl.Controls.Add(Me.experiencelbl, 0, 4)
        Me.statspnl.Controls.Add(Me.maxHealthlbl, 0, 5)
        Me.statspnl.Controls.Add(Me.healthlbl, 0, 6)
        Me.statspnl.Controls.Add(Me.armorlbl, 0, 7)
        Me.statspnl.Controls.Add(Me.strengthlbl, 0, 8)
        Me.statspnl.Controls.Add(Me.dexteritylbl, 0, 9)
        Me.statspnl.Controls.Add(Me.intelligencelbl, 0, 10)
        Me.statspnl.Controls.Add(Me.wisdomlbl, 0, 12)
        Me.statspnl.Controls.Add(Me.initiativelbl, 0, 11)
        Me.statspnl.Controls.Add(Me.namelbl, 0, 0)
        Me.statspnl.Controls.Add(Me.classlbl, 0, 1)
        Me.statspnl.Location = New System.Drawing.Point(4, 4)
        Me.statspnl.MinimumSize = New System.Drawing.Size(189, 378)
        Me.statspnl.Name = "statspnl"
        Me.statspnl.RowCount = 13
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692307!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.statspnl.Size = New System.Drawing.Size(189, 378)
        Me.statspnl.TabIndex = 0
        '
        'classlbl
        '
        Me.classlbl.AutoSize = True
        Me.classlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.classlbl.Location = New System.Drawing.Point(4, 30)
        Me.classlbl.Name = "classlbl"
        Me.classlbl.Size = New System.Drawing.Size(72, 28)
        Me.classlbl.TabIndex = 28
        Me.classlbl.TabStop = True
        Me.classlbl.Text = "class"
        Me.classlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CreatureWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 520)
        Me.Controls.Add(Me.mainLayoutpnl)
        Me.MinimumSize = New System.Drawing.Size(399, 559)
        Me.Name = "CreatureWindow"
        Me.ShowIcon = False
        Me.Text = "creature"
        Me.mainLayoutpnl.ResumeLayout(False)
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.statspnl.ResumeLayout(False)
        Me.statspnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mainLayoutpnl As TableLayoutPanel
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayerCreaturesBindingSource As BindingSource
    Friend WithEvents PlayerCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents statspnl As TableLayoutPanel
    Friend WithEvents classtxt As TextBox
    Friend WithEvents nametxt As TextBox
    Friend WithEvents speciestxt As TextBox
    Friend WithEvents leveltxt As TextBox
    Friend WithEvents experiencetxt As TextBox
    Friend WithEvents maxHPtxt As TextBox
    Friend WithEvents healthtxt As TextBox
    Friend WithEvents armortxt As TextBox
    Friend WithEvents strengthtxt As TextBox
    Friend WithEvents dexteritytxt As TextBox
    Friend WithEvents intelligencetxt As TextBox
    Friend WithEvents initiativetxt As TextBox
    Friend WithEvents wisdomtxt As TextBox
    Friend WithEvents specieslbl As Label
    Friend WithEvents levellbl As Label
    Friend WithEvents experiencelbl As Label
    Friend WithEvents maxHealthlbl As Label
    Friend WithEvents healthlbl As Label
    Friend WithEvents armorlbl As Label
    Friend WithEvents strengthlbl As Label
    Friend WithEvents dexteritylbl As Label
    Friend WithEvents intelligencelbl As Label
    Friend WithEvents wisdomlbl As Label
    Friend WithEvents initiativelbl As Label
    Friend WithEvents namelbl As LinkLabel
    Friend WithEvents classlbl As LinkLabel
End Class
