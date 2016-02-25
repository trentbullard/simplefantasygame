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
        Me.statspnl = New System.Windows.Forms.TableLayoutPanel()
        Me.classtxt = New System.Windows.Forms.TextBox()
        Me.nametxt = New System.Windows.Forms.TextBox()
        Me.speciestxt = New System.Windows.Forms.TextBox()
        Me.leveltxt = New System.Windows.Forms.TextBox()
        Me.maxHPtxt = New System.Windows.Forms.TextBox()
        Me.healthtxt = New System.Windows.Forms.TextBox()
        Me.armortxt = New System.Windows.Forms.TextBox()
        Me.strengthtxt = New System.Windows.Forms.TextBox()
        Me.dexteritytxt = New System.Windows.Forms.TextBox()
        Me.intelligencetxt = New System.Windows.Forms.TextBox()
        Me.initiativetxt = New System.Windows.Forms.TextBox()
        Me.wisdomtxt = New System.Windows.Forms.TextBox()
        Me.specieslbl = New System.Windows.Forms.Label()
        Me.levellbl = New System.Windows.Forms.Label()
        Me.maxHealthlbl = New System.Windows.Forms.Label()
        Me.healthlbl = New System.Windows.Forms.Label()
        Me.armorlbl = New System.Windows.Forms.Label()
        Me.strengthlbl = New System.Windows.Forms.Label()
        Me.dexteritylbl = New System.Windows.Forms.Label()
        Me.intelligencelbl = New System.Windows.Forms.Label()
        Me.wisdomlbl = New System.Windows.Forms.Label()
        Me.initiativelbl = New System.Windows.Forms.Label()
        Me.namelbl = New System.Windows.Forms.LinkLabel()
        Me.classlbl = New System.Windows.Forms.LinkLabel()
        Me.mainEquipmentpnl = New System.Windows.Forms.TableLayoutPanel()
        Me.leftEquipmentpnl = New System.Windows.Forms.TableLayoutPanel()
        Me.primarylbl = New System.Windows.Forms.Label()
        Me.shoulderslbl = New System.Windows.Forms.Label()
        Me.sleeveslbl = New System.Windows.Forms.Label()
        Me.handslbl = New System.Windows.Forms.Label()
        Me.feetlbl = New System.Windows.Forms.Label()
        Me.headpic = New System.Windows.Forms.PictureBox()
        Me.rightEquipmentpnl = New System.Windows.Forms.TableLayoutPanel()
        Me.secondarylbl = New System.Windows.Forms.Label()
        Me.backlbl = New System.Windows.Forms.Label()
        Me.chestlbl = New System.Windows.Forms.Label()
        Me.waistlbl = New System.Windows.Forms.Label()
        Me.legslbl = New System.Windows.Forms.Label()
        Me.shinslbl = New System.Windows.Forms.Label()
        Me.headtip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GameDatabaseDataSet = New simplefantasygame.GameDatabaseDataSet()
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.TableAdapterManager = New simplefantasygame.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        Me.StaticAugmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticAugmentsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter()
        Me.StaticJewelryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticJewelryTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticJewelryTableAdapter()
        Me.StaticSkillsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticSkillsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticSkillsTableAdapter()
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.PlayerArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerArmorTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter()
        Me.PlayerWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerWeaponsTableAdapter = New simplefantasygame.GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter()
        Me.headlbl = New System.Windows.Forms.LinkLabel()
        Me.infopnl = New System.Windows.Forms.Panel()
        Me.expbar = New System.Windows.Forms.ProgressBar()
        Me.playerExperiencelbl = New System.Windows.Forms.Label()
        Me.skillbtn = New System.Windows.Forms.Button()
        Me.dismissbtn = New System.Windows.Forms.Button()
        Me.mainLayoutpnl.SuspendLayout()
        Me.statspnl.SuspendLayout()
        Me.mainEquipmentpnl.SuspendLayout()
        Me.leftEquipmentpnl.SuspendLayout()
        CType(Me.headpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightEquipmentpnl.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticJewelryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticSkillsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.infopnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'mainLayoutpnl
        '
        Me.mainLayoutpnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.mainLayoutpnl.ColumnCount = 2
        Me.mainLayoutpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 195.0!))
        Me.mainLayoutpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainLayoutpnl.Controls.Add(Me.statspnl, 0, 0)
        Me.mainLayoutpnl.Controls.Add(Me.mainEquipmentpnl, 1, 0)
        Me.mainLayoutpnl.Controls.Add(Me.infopnl, 1, 1)
        Me.mainLayoutpnl.Controls.Add(Me.dismissbtn, 0, 1)
        Me.mainLayoutpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainLayoutpnl.Location = New System.Drawing.Point(0, 0)
        Me.mainLayoutpnl.Name = "mainLayoutpnl"
        Me.mainLayoutpnl.RowCount = 2
        Me.mainLayoutpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 426.0!))
        Me.mainLayoutpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainLayoutpnl.Size = New System.Drawing.Size(761, 520)
        Me.mainLayoutpnl.TabIndex = 0
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
        Me.statspnl.Controls.Add(Me.maxHPtxt, 1, 4)
        Me.statspnl.Controls.Add(Me.healthtxt, 1, 5)
        Me.statspnl.Controls.Add(Me.armortxt, 1, 6)
        Me.statspnl.Controls.Add(Me.strengthtxt, 1, 7)
        Me.statspnl.Controls.Add(Me.dexteritytxt, 1, 8)
        Me.statspnl.Controls.Add(Me.intelligencetxt, 1, 9)
        Me.statspnl.Controls.Add(Me.initiativetxt, 1, 10)
        Me.statspnl.Controls.Add(Me.wisdomtxt, 1, 11)
        Me.statspnl.Controls.Add(Me.specieslbl, 0, 2)
        Me.statspnl.Controls.Add(Me.levellbl, 0, 3)
        Me.statspnl.Controls.Add(Me.maxHealthlbl, 0, 4)
        Me.statspnl.Controls.Add(Me.healthlbl, 0, 5)
        Me.statspnl.Controls.Add(Me.armorlbl, 0, 6)
        Me.statspnl.Controls.Add(Me.strengthlbl, 0, 7)
        Me.statspnl.Controls.Add(Me.dexteritylbl, 0, 8)
        Me.statspnl.Controls.Add(Me.intelligencelbl, 0, 9)
        Me.statspnl.Controls.Add(Me.wisdomlbl, 0, 11)
        Me.statspnl.Controls.Add(Me.initiativelbl, 0, 10)
        Me.statspnl.Controls.Add(Me.namelbl, 0, 0)
        Me.statspnl.Controls.Add(Me.classlbl, 0, 1)
        Me.statspnl.Location = New System.Drawing.Point(4, 4)
        Me.statspnl.MinimumSize = New System.Drawing.Size(189, 378)
        Me.statspnl.Name = "statspnl"
        Me.statspnl.RowCount = 12
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333!))
        Me.statspnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.statspnl.Size = New System.Drawing.Size(189, 420)
        Me.statspnl.TabIndex = 0
        '
        'classtxt
        '
        Me.classtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.classtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.classtxt.Location = New System.Drawing.Point(83, 41)
        Me.classtxt.Name = "classtxt"
        Me.classtxt.ReadOnly = True
        Me.classtxt.Size = New System.Drawing.Size(102, 20)
        Me.classtxt.TabIndex = 3
        '
        'nametxt
        '
        Me.nametxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nametxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nametxt.Location = New System.Drawing.Point(83, 7)
        Me.nametxt.Name = "nametxt"
        Me.nametxt.ReadOnly = True
        Me.nametxt.Size = New System.Drawing.Size(102, 20)
        Me.nametxt.TabIndex = 0
        '
        'speciestxt
        '
        Me.speciestxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.speciestxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.speciestxt.Location = New System.Drawing.Point(83, 75)
        Me.speciestxt.Name = "speciestxt"
        Me.speciestxt.ReadOnly = True
        Me.speciestxt.Size = New System.Drawing.Size(102, 20)
        Me.speciestxt.TabIndex = 5
        '
        'leveltxt
        '
        Me.leveltxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.leveltxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.leveltxt.Location = New System.Drawing.Point(83, 109)
        Me.leveltxt.Name = "leveltxt"
        Me.leveltxt.ReadOnly = True
        Me.leveltxt.Size = New System.Drawing.Size(102, 20)
        Me.leveltxt.TabIndex = 7
        '
        'maxHPtxt
        '
        Me.maxHPtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxHPtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.maxHPtxt.Location = New System.Drawing.Point(83, 143)
        Me.maxHPtxt.Name = "maxHPtxt"
        Me.maxHPtxt.ReadOnly = True
        Me.maxHPtxt.Size = New System.Drawing.Size(102, 20)
        Me.maxHPtxt.TabIndex = 19
        '
        'healthtxt
        '
        Me.healthtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.healthtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.healthtxt.Location = New System.Drawing.Point(83, 177)
        Me.healthtxt.Name = "healthtxt"
        Me.healthtxt.ReadOnly = True
        Me.healthtxt.Size = New System.Drawing.Size(102, 20)
        Me.healthtxt.TabIndex = 20
        '
        'armortxt
        '
        Me.armortxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.armortxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.armortxt.Location = New System.Drawing.Point(83, 211)
        Me.armortxt.Name = "armortxt"
        Me.armortxt.ReadOnly = True
        Me.armortxt.Size = New System.Drawing.Size(102, 20)
        Me.armortxt.TabIndex = 21
        '
        'strengthtxt
        '
        Me.strengthtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.strengthtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.strengthtxt.Location = New System.Drawing.Point(83, 245)
        Me.strengthtxt.Name = "strengthtxt"
        Me.strengthtxt.ReadOnly = True
        Me.strengthtxt.Size = New System.Drawing.Size(102, 20)
        Me.strengthtxt.TabIndex = 22
        '
        'dexteritytxt
        '
        Me.dexteritytxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dexteritytxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dexteritytxt.Location = New System.Drawing.Point(83, 279)
        Me.dexteritytxt.Name = "dexteritytxt"
        Me.dexteritytxt.ReadOnly = True
        Me.dexteritytxt.Size = New System.Drawing.Size(102, 20)
        Me.dexteritytxt.TabIndex = 23
        '
        'intelligencetxt
        '
        Me.intelligencetxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.intelligencetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.intelligencetxt.Location = New System.Drawing.Point(83, 313)
        Me.intelligencetxt.Name = "intelligencetxt"
        Me.intelligencetxt.ReadOnly = True
        Me.intelligencetxt.Size = New System.Drawing.Size(102, 20)
        Me.intelligencetxt.TabIndex = 24
        '
        'initiativetxt
        '
        Me.initiativetxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.initiativetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.initiativetxt.Location = New System.Drawing.Point(83, 347)
        Me.initiativetxt.Name = "initiativetxt"
        Me.initiativetxt.ReadOnly = True
        Me.initiativetxt.Size = New System.Drawing.Size(102, 20)
        Me.initiativetxt.TabIndex = 25
        '
        'wisdomtxt
        '
        Me.wisdomtxt.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.wisdomtxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.wisdomtxt.Location = New System.Drawing.Point(83, 387)
        Me.wisdomtxt.Name = "wisdomtxt"
        Me.wisdomtxt.ReadOnly = True
        Me.wisdomtxt.Size = New System.Drawing.Size(102, 20)
        Me.wisdomtxt.TabIndex = 26
        '
        'specieslbl
        '
        Me.specieslbl.AutoSize = True
        Me.specieslbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.specieslbl.Location = New System.Drawing.Point(4, 69)
        Me.specieslbl.Name = "specieslbl"
        Me.specieslbl.Size = New System.Drawing.Size(72, 33)
        Me.specieslbl.TabIndex = 2
        Me.specieslbl.Text = "species"
        Me.specieslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'levellbl
        '
        Me.levellbl.AutoSize = True
        Me.levellbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.levellbl.Location = New System.Drawing.Point(4, 103)
        Me.levellbl.Name = "levellbl"
        Me.levellbl.Size = New System.Drawing.Size(72, 33)
        Me.levellbl.TabIndex = 6
        Me.levellbl.Text = "level"
        Me.levellbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'maxHealthlbl
        '
        Me.maxHealthlbl.AutoSize = True
        Me.maxHealthlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.maxHealthlbl.Location = New System.Drawing.Point(4, 137)
        Me.maxHealthlbl.Name = "maxHealthlbl"
        Me.maxHealthlbl.Size = New System.Drawing.Size(72, 33)
        Me.maxHealthlbl.TabIndex = 8
        Me.maxHealthlbl.Text = "max health"
        Me.maxHealthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'healthlbl
        '
        Me.healthlbl.AutoSize = True
        Me.healthlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.healthlbl.Location = New System.Drawing.Point(4, 171)
        Me.healthlbl.Name = "healthlbl"
        Me.healthlbl.Size = New System.Drawing.Size(72, 33)
        Me.healthlbl.TabIndex = 9
        Me.healthlbl.Text = "current health"
        Me.healthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'armorlbl
        '
        Me.armorlbl.AutoSize = True
        Me.armorlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.armorlbl.Location = New System.Drawing.Point(4, 205)
        Me.armorlbl.Name = "armorlbl"
        Me.armorlbl.Size = New System.Drawing.Size(72, 33)
        Me.armorlbl.TabIndex = 15
        Me.armorlbl.Text = "armor"
        Me.armorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'strengthlbl
        '
        Me.strengthlbl.AutoSize = True
        Me.strengthlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.strengthlbl.Location = New System.Drawing.Point(4, 239)
        Me.strengthlbl.Name = "strengthlbl"
        Me.strengthlbl.Size = New System.Drawing.Size(72, 33)
        Me.strengthlbl.TabIndex = 14
        Me.strengthlbl.Text = "strength"
        Me.strengthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dexteritylbl
        '
        Me.dexteritylbl.AutoSize = True
        Me.dexteritylbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dexteritylbl.Location = New System.Drawing.Point(4, 273)
        Me.dexteritylbl.Name = "dexteritylbl"
        Me.dexteritylbl.Size = New System.Drawing.Size(72, 33)
        Me.dexteritylbl.TabIndex = 13
        Me.dexteritylbl.Text = "dexterity"
        Me.dexteritylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'intelligencelbl
        '
        Me.intelligencelbl.AutoSize = True
        Me.intelligencelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.intelligencelbl.Location = New System.Drawing.Point(4, 307)
        Me.intelligencelbl.Name = "intelligencelbl"
        Me.intelligencelbl.Size = New System.Drawing.Size(72, 33)
        Me.intelligencelbl.TabIndex = 12
        Me.intelligencelbl.Text = "intelligence"
        Me.intelligencelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'wisdomlbl
        '
        Me.wisdomlbl.AutoSize = True
        Me.wisdomlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wisdomlbl.Location = New System.Drawing.Point(4, 375)
        Me.wisdomlbl.Name = "wisdomlbl"
        Me.wisdomlbl.Size = New System.Drawing.Size(72, 44)
        Me.wisdomlbl.TabIndex = 10
        Me.wisdomlbl.Text = "wisdom"
        Me.wisdomlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'initiativelbl
        '
        Me.initiativelbl.AutoSize = True
        Me.initiativelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.initiativelbl.Location = New System.Drawing.Point(4, 341)
        Me.initiativelbl.Name = "initiativelbl"
        Me.initiativelbl.Size = New System.Drawing.Size(72, 33)
        Me.initiativelbl.TabIndex = 11
        Me.initiativelbl.Text = "initiative"
        Me.initiativelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.namelbl.Location = New System.Drawing.Point(4, 1)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(72, 33)
        Me.namelbl.TabIndex = 27
        Me.namelbl.TabStop = True
        Me.namelbl.Text = "name"
        Me.namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'classlbl
        '
        Me.classlbl.AutoSize = True
        Me.classlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.classlbl.Location = New System.Drawing.Point(4, 35)
        Me.classlbl.Name = "classlbl"
        Me.classlbl.Size = New System.Drawing.Size(72, 33)
        Me.classlbl.TabIndex = 28
        Me.classlbl.TabStop = True
        Me.classlbl.Text = "class"
        Me.classlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'mainEquipmentpnl
        '
        Me.mainEquipmentpnl.ColumnCount = 3
        Me.mainEquipmentpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99999!))
        Me.mainEquipmentpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219.0!))
        Me.mainEquipmentpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001!))
        Me.mainEquipmentpnl.Controls.Add(Me.leftEquipmentpnl, 0, 0)
        Me.mainEquipmentpnl.Controls.Add(Me.rightEquipmentpnl, 2, 0)
        Me.mainEquipmentpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainEquipmentpnl.Location = New System.Drawing.Point(200, 4)
        Me.mainEquipmentpnl.Name = "mainEquipmentpnl"
        Me.mainEquipmentpnl.RowCount = 1
        Me.mainEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.mainEquipmentpnl.Size = New System.Drawing.Size(557, 420)
        Me.mainEquipmentpnl.TabIndex = 1
        '
        'leftEquipmentpnl
        '
        Me.leftEquipmentpnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.leftEquipmentpnl.ColumnCount = 2
        Me.leftEquipmentpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.leftEquipmentpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.leftEquipmentpnl.Controls.Add(Me.primarylbl, 0, 5)
        Me.leftEquipmentpnl.Controls.Add(Me.shoulderslbl, 0, 1)
        Me.leftEquipmentpnl.Controls.Add(Me.sleeveslbl, 0, 2)
        Me.leftEquipmentpnl.Controls.Add(Me.handslbl, 0, 3)
        Me.leftEquipmentpnl.Controls.Add(Me.feetlbl, 0, 4)
        Me.leftEquipmentpnl.Controls.Add(Me.headpic, 1, 0)
        Me.leftEquipmentpnl.Controls.Add(Me.headlbl, 0, 0)
        Me.leftEquipmentpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.leftEquipmentpnl.Location = New System.Drawing.Point(3, 3)
        Me.leftEquipmentpnl.Name = "leftEquipmentpnl"
        Me.leftEquipmentpnl.RowCount = 6
        Me.leftEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.leftEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.leftEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.leftEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.leftEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.leftEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.leftEquipmentpnl.Size = New System.Drawing.Size(162, 414)
        Me.leftEquipmentpnl.TabIndex = 0
        '
        'primarylbl
        '
        Me.primarylbl.AutoSize = True
        Me.primarylbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.primarylbl.Location = New System.Drawing.Point(4, 341)
        Me.primarylbl.Name = "primarylbl"
        Me.primarylbl.Size = New System.Drawing.Size(73, 72)
        Me.primarylbl.TabIndex = 0
        Me.primarylbl.Text = "main hand"
        Me.primarylbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'shoulderslbl
        '
        Me.shoulderslbl.AutoSize = True
        Me.shoulderslbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shoulderslbl.Location = New System.Drawing.Point(4, 69)
        Me.shoulderslbl.Name = "shoulderslbl"
        Me.shoulderslbl.Size = New System.Drawing.Size(73, 67)
        Me.shoulderslbl.TabIndex = 2
        Me.shoulderslbl.Text = "shoulders"
        Me.shoulderslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'sleeveslbl
        '
        Me.sleeveslbl.AutoSize = True
        Me.sleeveslbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sleeveslbl.Location = New System.Drawing.Point(4, 137)
        Me.sleeveslbl.Name = "sleeveslbl"
        Me.sleeveslbl.Size = New System.Drawing.Size(73, 67)
        Me.sleeveslbl.TabIndex = 3
        Me.sleeveslbl.Text = "sleeves"
        Me.sleeveslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'handslbl
        '
        Me.handslbl.AutoSize = True
        Me.handslbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.handslbl.Location = New System.Drawing.Point(4, 205)
        Me.handslbl.Name = "handslbl"
        Me.handslbl.Size = New System.Drawing.Size(73, 67)
        Me.handslbl.TabIndex = 4
        Me.handslbl.Text = "hands"
        Me.handslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'feetlbl
        '
        Me.feetlbl.AutoSize = True
        Me.feetlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.feetlbl.Location = New System.Drawing.Point(4, 273)
        Me.feetlbl.Name = "feetlbl"
        Me.feetlbl.Size = New System.Drawing.Size(73, 67)
        Me.feetlbl.TabIndex = 5
        Me.feetlbl.Text = "feet"
        Me.feetlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'headpic
        '
        Me.headpic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.headpic.Image = Global.simplefantasygame.My.Resources.Resources.megaman_jump
        Me.headpic.InitialImage = Global.simplefantasygame.My.Resources.Resources.megaman_jump
        Me.headpic.Location = New System.Drawing.Point(84, 4)
        Me.headpic.Name = "headpic"
        Me.headpic.Size = New System.Drawing.Size(74, 61)
        Me.headpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.headpic.TabIndex = 6
        Me.headpic.TabStop = False
        Me.headtip.SetToolTip(Me.headpic, "Info" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "more info" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "texty text")
        '
        'rightEquipmentpnl
        '
        Me.rightEquipmentpnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.rightEquipmentpnl.ColumnCount = 2
        Me.rightEquipmentpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.rightEquipmentpnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.rightEquipmentpnl.Controls.Add(Me.secondarylbl, 1, 5)
        Me.rightEquipmentpnl.Controls.Add(Me.backlbl, 1, 0)
        Me.rightEquipmentpnl.Controls.Add(Me.chestlbl, 1, 1)
        Me.rightEquipmentpnl.Controls.Add(Me.waistlbl, 1, 2)
        Me.rightEquipmentpnl.Controls.Add(Me.legslbl, 1, 3)
        Me.rightEquipmentpnl.Controls.Add(Me.shinslbl, 1, 4)
        Me.rightEquipmentpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rightEquipmentpnl.Location = New System.Drawing.Point(390, 3)
        Me.rightEquipmentpnl.Name = "rightEquipmentpnl"
        Me.rightEquipmentpnl.RowCount = 6
        Me.rightEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.rightEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.rightEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.rightEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.rightEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.rightEquipmentpnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.rightEquipmentpnl.Size = New System.Drawing.Size(164, 414)
        Me.rightEquipmentpnl.TabIndex = 1
        '
        'secondarylbl
        '
        Me.secondarylbl.AutoSize = True
        Me.secondarylbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.secondarylbl.Location = New System.Drawing.Point(85, 341)
        Me.secondarylbl.Name = "secondarylbl"
        Me.secondarylbl.Size = New System.Drawing.Size(75, 72)
        Me.secondarylbl.TabIndex = 0
        Me.secondarylbl.Text = "off-hand"
        Me.secondarylbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'backlbl
        '
        Me.backlbl.AutoSize = True
        Me.backlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.backlbl.Location = New System.Drawing.Point(85, 1)
        Me.backlbl.Name = "backlbl"
        Me.backlbl.Size = New System.Drawing.Size(75, 67)
        Me.backlbl.TabIndex = 1
        Me.backlbl.Text = "back"
        Me.backlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chestlbl
        '
        Me.chestlbl.AutoSize = True
        Me.chestlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chestlbl.Location = New System.Drawing.Point(85, 69)
        Me.chestlbl.Name = "chestlbl"
        Me.chestlbl.Size = New System.Drawing.Size(75, 67)
        Me.chestlbl.TabIndex = 2
        Me.chestlbl.Text = "chest"
        Me.chestlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'waistlbl
        '
        Me.waistlbl.AutoSize = True
        Me.waistlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.waistlbl.Location = New System.Drawing.Point(85, 137)
        Me.waistlbl.Name = "waistlbl"
        Me.waistlbl.Size = New System.Drawing.Size(75, 67)
        Me.waistlbl.TabIndex = 3
        Me.waistlbl.Text = "waist"
        Me.waistlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'legslbl
        '
        Me.legslbl.AutoSize = True
        Me.legslbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.legslbl.Location = New System.Drawing.Point(85, 205)
        Me.legslbl.Name = "legslbl"
        Me.legslbl.Size = New System.Drawing.Size(75, 67)
        Me.legslbl.TabIndex = 4
        Me.legslbl.Text = "legs"
        Me.legslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'shinslbl
        '
        Me.shinslbl.AutoSize = True
        Me.shinslbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shinslbl.Location = New System.Drawing.Point(85, 273)
        Me.shinslbl.Name = "shinslbl"
        Me.shinslbl.Size = New System.Drawing.Size(75, 67)
        Me.shinslbl.TabIndex = 5
        Me.shinslbl.Text = "shins"
        Me.shinslbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'StaticJewelryBindingSource
        '
        Me.StaticJewelryBindingSource.DataMember = "StaticJewelry"
        Me.StaticJewelryBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticJewelryTableAdapter
        '
        Me.StaticJewelryTableAdapter.ClearBeforeFill = True
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
        'PlayerArmorBindingSource
        '
        Me.PlayerArmorBindingSource.DataMember = "PlayerArmor"
        Me.PlayerArmorBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerArmorTableAdapter
        '
        Me.PlayerArmorTableAdapter.ClearBeforeFill = True
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
        'headlbl
        '
        Me.headlbl.AutoSize = True
        Me.headlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.headlbl.Location = New System.Drawing.Point(4, 1)
        Me.headlbl.Name = "headlbl"
        Me.headlbl.Size = New System.Drawing.Size(73, 67)
        Me.headlbl.TabIndex = 7
        Me.headlbl.TabStop = True
        Me.headlbl.Text = "head"
        Me.headlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'infopnl
        '
        Me.infopnl.Controls.Add(Me.skillbtn)
        Me.infopnl.Controls.Add(Me.playerExperiencelbl)
        Me.infopnl.Controls.Add(Me.expbar)
        Me.infopnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.infopnl.Location = New System.Drawing.Point(200, 431)
        Me.infopnl.Name = "infopnl"
        Me.infopnl.Size = New System.Drawing.Size(557, 85)
        Me.infopnl.TabIndex = 2
        '
        'expbar
        '
        Me.expbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.expbar.Location = New System.Drawing.Point(0, 69)
        Me.expbar.Name = "expbar"
        Me.expbar.Size = New System.Drawing.Size(557, 13)
        Me.expbar.Step = 1
        Me.expbar.TabIndex = 14
        '
        'playerExperiencelbl
        '
        Me.playerExperiencelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerExperiencelbl.AutoSize = True
        Me.playerExperiencelbl.ForeColor = System.Drawing.Color.Black
        Me.playerExperiencelbl.Location = New System.Drawing.Point(498, 53)
        Me.playerExperiencelbl.Name = "playerExperiencelbl"
        Me.playerExperiencelbl.Size = New System.Drawing.Size(59, 13)
        Me.playerExperiencelbl.TabIndex = 15
        Me.playerExperiencelbl.Text = "experience"
        '
        'skillbtn
        '
        Me.skillbtn.Location = New System.Drawing.Point(0, 0)
        Me.skillbtn.Name = "skillbtn"
        Me.skillbtn.Size = New System.Drawing.Size(54, 23)
        Me.skillbtn.TabIndex = 16
        Me.skillbtn.Text = "skills"
        Me.skillbtn.UseVisualStyleBackColor = True
        '
        'dismissbtn
        '
        Me.dismissbtn.Location = New System.Drawing.Point(4, 431)
        Me.dismissbtn.Name = "dismissbtn"
        Me.dismissbtn.Size = New System.Drawing.Size(75, 23)
        Me.dismissbtn.TabIndex = 3
        Me.dismissbtn.Text = "dismiss"
        Me.dismissbtn.UseVisualStyleBackColor = True
        '
        'CreatureWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 520)
        Me.Controls.Add(Me.mainLayoutpnl)
        Me.MinimumSize = New System.Drawing.Size(777, 559)
        Me.Name = "CreatureWindow"
        Me.ShowIcon = False
        Me.Text = "creature"
        Me.mainLayoutpnl.ResumeLayout(False)
        Me.statspnl.ResumeLayout(False)
        Me.statspnl.PerformLayout()
        Me.mainEquipmentpnl.ResumeLayout(False)
        Me.leftEquipmentpnl.ResumeLayout(False)
        Me.leftEquipmentpnl.PerformLayout()
        CType(Me.headpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightEquipmentpnl.ResumeLayout(False)
        Me.rightEquipmentpnl.PerformLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticAugmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticJewelryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticSkillsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.infopnl.ResumeLayout(False)
        Me.infopnl.PerformLayout()
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
    Friend WithEvents mainEquipmentpnl As TableLayoutPanel
    Friend WithEvents leftEquipmentpnl As TableLayoutPanel
    Friend WithEvents primarylbl As Label
    Friend WithEvents shoulderslbl As Label
    Friend WithEvents sleeveslbl As Label
    Friend WithEvents handslbl As Label
    Friend WithEvents feetlbl As Label
    Friend WithEvents rightEquipmentpnl As TableLayoutPanel
    Friend WithEvents secondarylbl As Label
    Friend WithEvents backlbl As Label
    Friend WithEvents chestlbl As Label
    Friend WithEvents waistlbl As Label
    Friend WithEvents legslbl As Label
    Friend WithEvents shinslbl As Label
    Friend WithEvents headpic As PictureBox
    Friend WithEvents headtip As ToolTip
    Friend WithEvents StaticArmorBindingSource As BindingSource
    Friend WithEvents StaticArmorTableAdapter As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter
    Friend WithEvents StaticAugmentsBindingSource As BindingSource
    Friend WithEvents StaticAugmentsTableAdapter As GameDatabaseDataSetTableAdapters.StaticAugmentsTableAdapter
    Friend WithEvents StaticJewelryBindingSource As BindingSource
    Friend WithEvents StaticJewelryTableAdapter As GameDatabaseDataSetTableAdapters.StaticJewelryTableAdapter
    Friend WithEvents StaticSkillsBindingSource As BindingSource
    Friend WithEvents StaticSkillsTableAdapter As GameDatabaseDataSetTableAdapters.StaticSkillsTableAdapter
    Friend WithEvents StaticWeaponsBindingSource As BindingSource
    Friend WithEvents StaticWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter
    Friend WithEvents PlayerArmorBindingSource As BindingSource
    Friend WithEvents PlayerArmorTableAdapter As GameDatabaseDataSetTableAdapters.PlayerArmorTableAdapter
    Friend WithEvents PlayerWeaponsBindingSource As BindingSource
    Friend WithEvents PlayerWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.PlayerWeaponsTableAdapter
    Friend WithEvents headlbl As LinkLabel
    Friend WithEvents infopnl As Panel
    Friend WithEvents expbar As ProgressBar
    Friend WithEvents playerExperiencelbl As Label
    Friend WithEvents skillbtn As Button
    Friend WithEvents dismissbtn As Button
End Class
