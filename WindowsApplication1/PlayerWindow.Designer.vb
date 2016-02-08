<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerWindow
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
        Me.playerStatspnl = New System.Windows.Forms.Panel()
        Me.creaturelst = New System.Windows.Forms.ListBox()
        Me.playerInfoPanellbl = New System.Windows.Forms.Label()
        Me.playerSkillTreebtn = New System.Windows.Forms.Button()
        Me.playerExperiencelbl = New System.Windows.Forms.Label()
        Me.playerGoldlbl = New System.Windows.Forms.Label()
        Me.playerExperiencebar = New System.Windows.Forms.ProgressBar()
        Me.playerLevellbl = New System.Windows.Forms.Label()
        Me.playerGoldtxt = New System.Windows.Forms.TextBox()
        Me.playerLeveltxt = New System.Windows.Forms.TextBox()
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayerCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.StaticCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportPlayerDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.playerStatspnl.SuspendLayout()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playerStatspnl
        '
        Me.playerStatspnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.playerStatspnl.Size = New System.Drawing.Size(324, 350)
        Me.playerStatspnl.TabIndex = 5
        '
        'creaturelst
        '
        Me.creaturelst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.creaturelst.FormattingEnabled = True
        Me.creaturelst.Location = New System.Drawing.Point(12, 107)
        Me.creaturelst.Name = "creaturelst"
        Me.creaturelst.Size = New System.Drawing.Size(300, 186)
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
        Me.playerExperiencelbl.Location = New System.Drawing.Point(255, 309)
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
        Me.playerExperiencebar.Location = New System.Drawing.Point(12, 325)
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
        'PlayerCreaturesBindingSource
        '
        Me.PlayerCreaturesBindingSource.DataMember = "PlayerCreatures"
        Me.PlayerCreaturesBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.PartiesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerArmorTableAdapter = Nothing
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Me.PlayerCreaturesTableAdapter
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Nothing
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.StaticArmorTableAdapter = Nothing
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.StaticMobsTableAdapter = Nothing
        Me.TableAdapterManager.StaticSkillsTableAdapter = Nothing
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Nothing
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(324, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportPlayerDataToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NameToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "edit"
        '
        'ImportPlayerDataToolStripMenuItem
        '
        Me.ImportPlayerDataToolStripMenuItem.Enabled = False
        Me.ImportPlayerDataToolStripMenuItem.Name = "ImportPlayerDataToolStripMenuItem"
        Me.ImportPlayerDataToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportPlayerDataToolStripMenuItem.Text = "import"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Enabled = False
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToolStripMenuItem.Text = "export"
        '
        'NameToolStripMenuItem
        '
        Me.NameToolStripMenuItem.Name = "NameToolStripMenuItem"
        Me.NameToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NameToolStripMenuItem.Text = "name"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.HelpToolStripMenuItem.Text = "help"
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
        'PlayerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 374)
        Me.Controls.Add(Me.playerStatspnl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "PlayerWindow"
        Me.ShowIcon = False
        Me.Text = "PlayerWindow"
        Me.playerStatspnl.ResumeLayout(False)
        Me.playerStatspnl.PerformLayout()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayerCreaturesBindingSource As BindingSource
    Friend WithEvents PlayerCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents creaturelst As ListBox
    Friend WithEvents StaticCreaturesBindingSource As BindingSource
    Friend WithEvents StaticCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportPlayerDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
End Class
