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
        Me.noActiveQuestlbl = New System.Windows.Forms.Label()
        Me.currentQuestlbl = New System.Windows.Forms.LinkLabel()
        Me.currentQuestrtxt = New System.Windows.Forms.RichTextBox()
        Me.creatureListlbl = New System.Windows.Forms.Label()
        Me.creaturelst = New System.Windows.Forms.ListBox()
        Me.playerInfoPanellbl = New System.Windows.Forms.Label()
        Me.playerSkillTreebtn = New System.Windows.Forms.Button()
        Me.playerExperiencelbl = New System.Windows.Forms.Label()
        Me.playerGoldlbl = New System.Windows.Forms.Label()
        Me.playerExperiencebar = New System.Windows.Forms.ProgressBar()
        Me.playerLevellbl = New System.Windows.Forms.Label()
        Me.playerGoldtxt = New System.Windows.Forms.TextBox()
        Me.playerLeveltxt = New System.Windows.Forms.TextBox()
        Me.playerMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportPlayerDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlayerCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.StaticCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter()
        Me.StaticCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticQuestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticQuestsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticQuestsTableAdapter()
        Me.PlayerStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerStatesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter()
        Me.playerStatspnl.SuspendLayout()
        Me.playerMenuStrip.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticQuestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playerStatspnl
        '
        Me.playerStatspnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.playerStatspnl.Controls.Add(Me.noActiveQuestlbl)
        Me.playerStatspnl.Controls.Add(Me.currentQuestlbl)
        Me.playerStatspnl.Controls.Add(Me.currentQuestrtxt)
        Me.playerStatspnl.Controls.Add(Me.creatureListlbl)
        Me.playerStatspnl.Controls.Add(Me.creaturelst)
        Me.playerStatspnl.Controls.Add(Me.playerInfoPanellbl)
        Me.playerStatspnl.Controls.Add(Me.playerSkillTreebtn)
        Me.playerStatspnl.Controls.Add(Me.playerExperiencelbl)
        Me.playerStatspnl.Controls.Add(Me.playerGoldlbl)
        Me.playerStatspnl.Controls.Add(Me.playerExperiencebar)
        Me.playerStatspnl.Controls.Add(Me.playerLevellbl)
        Me.playerStatspnl.Controls.Add(Me.playerGoldtxt)
        Me.playerStatspnl.Controls.Add(Me.playerLeveltxt)
        Me.playerStatspnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.playerStatspnl.Location = New System.Drawing.Point(0, 24)
        Me.playerStatspnl.Name = "playerStatspnl"
        Me.playerStatspnl.Size = New System.Drawing.Size(324, 438)
        Me.playerStatspnl.TabIndex = 5
        '
        'noActiveQuestlbl
        '
        Me.noActiveQuestlbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.noActiveQuestlbl.AutoSize = True
        Me.noActiveQuestlbl.BackColor = System.Drawing.Color.Transparent
        Me.noActiveQuestlbl.ForeColor = System.Drawing.Color.White
        Me.noActiveQuestlbl.Location = New System.Drawing.Point(243, 261)
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
        Me.currentQuestlbl.Location = New System.Drawing.Point(243, 261)
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
        Me.currentQuestrtxt.Location = New System.Drawing.Point(12, 277)
        Me.currentQuestrtxt.Name = "currentQuestrtxt"
        Me.currentQuestrtxt.ReadOnly = True
        Me.currentQuestrtxt.Size = New System.Drawing.Size(300, 96)
        Me.currentQuestrtxt.TabIndex = 21
        Me.currentQuestrtxt.Text = ""
        '
        'creatureListlbl
        '
        Me.creatureListlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.creatureListlbl.AutoSize = True
        Me.creatureListlbl.ForeColor = System.Drawing.Color.White
        Me.creatureListlbl.Location = New System.Drawing.Point(226, 91)
        Me.creatureListlbl.Name = "creatureListlbl"
        Me.creatureListlbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.creatureListlbl.Size = New System.Drawing.Size(86, 13)
        Me.creatureListlbl.TabIndex = 18
        Me.creatureListlbl.Text = "creatures owned"
        Me.creatureListlbl.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'creaturelst
        '
        Me.creaturelst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.creaturelst.FormattingEnabled = True
        Me.creaturelst.Location = New System.Drawing.Point(12, 107)
        Me.creaturelst.Name = "creaturelst"
        Me.creaturelst.Size = New System.Drawing.Size(300, 121)
        Me.creaturelst.TabIndex = 17
        '
        'playerInfoPanellbl
        '
        Me.playerInfoPanellbl.AutoSize = True
        Me.playerInfoPanellbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.playerInfoPanellbl.ForeColor = System.Drawing.Color.White
        Me.playerInfoPanellbl.Location = New System.Drawing.Point(260, 0)
        Me.playerInfoPanellbl.Name = "playerInfoPanellbl"
        Me.playerInfoPanellbl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.playerInfoPanellbl.Size = New System.Drawing.Size(64, 13)
        Me.playerInfoPanellbl.TabIndex = 16
        Me.playerInfoPanellbl.Text = "player name"
        Me.playerInfoPanellbl.TextAlign = System.Drawing.ContentAlignment.TopRight
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
        'playerExperiencelbl
        '
        Me.playerExperiencelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerExperiencelbl.AutoSize = True
        Me.playerExperiencelbl.ForeColor = System.Drawing.Color.White
        Me.playerExperiencelbl.Location = New System.Drawing.Point(253, 397)
        Me.playerExperiencelbl.Name = "playerExperiencelbl"
        Me.playerExperiencelbl.Size = New System.Drawing.Size(59, 13)
        Me.playerExperiencelbl.TabIndex = 14
        Me.playerExperiencelbl.Text = "experience"
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
        'playerExperiencebar
        '
        Me.playerExperiencebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerExperiencebar.Location = New System.Drawing.Point(12, 413)
        Me.playerExperiencebar.Name = "playerExperiencebar"
        Me.playerExperiencebar.Size = New System.Drawing.Size(300, 13)
        Me.playerExperiencebar.Step = 1
        Me.playerExperiencebar.TabIndex = 13
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
        'playerMenuStrip
        '
        Me.playerMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.playerMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.playerMenuStrip.Name = "playerMenuStrip"
        Me.playerMenuStrip.Size = New System.Drawing.Size(324, 24)
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
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Me.PlayerCreaturesTableAdapter
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Me.PlayersTableAdapter
        Me.TableAdapterManager.PlayerStatesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStatesTableAdapter = Nothing
        Me.TableAdapterManager.StaticArmorTableAdapter = Nothing
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampTierTableAdapter = Nothing
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Me.StaticCreaturesTableAdapter
        Me.TableAdapterManager.StaticMobsTableAdapter = Nothing
        Me.TableAdapterManager.StaticQuestsTableAdapter = Nothing
        Me.TableAdapterManager.StaticSkillsTableAdapter = Nothing
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.TavernStatesTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Nothing
        '
        'PlayerCreaturesTableAdapter
        '
        Me.PlayerCreaturesTableAdapter.ClearBeforeFill = True
        '
        'StaticCreaturesTableAdapter
        '
        Me.StaticCreaturesTableAdapter.ClearBeforeFill = True
        '
        'StaticCreaturesBindingSource
        '
        Me.StaticCreaturesBindingSource.DataMember = "StaticCreatures"
        Me.StaticCreaturesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayerCreaturesBindingSource
        '
        Me.PlayerCreaturesBindingSource.DataMember = "PlayerCreatures"
        Me.PlayerCreaturesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticQuestsBindingSource
        '
        Me.StaticQuestsBindingSource.DataMember = "StaticQuests"
        Me.StaticQuestsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticQuestsTableAdapter
        '
        Me.StaticQuestsTableAdapter.ClearBeforeFill = True
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
        'PlayerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 462)
        Me.Controls.Add(Me.playerStatspnl)
        Me.Controls.Add(Me.playerMenuStrip)
        Me.MainMenuStrip = Me.playerMenuStrip
        Me.Name = "PlayerWindow"
        Me.ShowIcon = False
        Me.Text = "player"
        Me.playerStatspnl.ResumeLayout(False)
        Me.playerStatspnl.PerformLayout()
        Me.playerMenuStrip.ResumeLayout(False)
        Me.playerMenuStrip.PerformLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticQuestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents playerStatspnl As Panel
    Friend WithEvents playerInfoPanellbl As Label
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
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaticCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter
    Friend WithEvents StaticCreaturesBindingSource As BindingSource
    Friend WithEvents PlayerCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter
    Friend WithEvents PlayerCreaturesBindingSource As BindingSource
    Friend WithEvents currentQuestrtxt As RichTextBox
    Friend WithEvents creatureListlbl As Label
    Friend WithEvents StaticQuestsBindingSource As BindingSource
    Friend WithEvents StaticQuestsTableAdapter As GameDatabaseDataSetTableAdapters.StaticQuestsTableAdapter
    Friend WithEvents PlayerStatesBindingSource As BindingSource
    Friend WithEvents PlayerStatesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter
    Friend WithEvents currentQuestlbl As LinkLabel
    Friend WithEvents noActiveQuestlbl As Label
    Friend WithEvents QuestsToolStripMenuItem As ToolStripMenuItem
End Class
