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
        Me.playerInfoPanellbl = New System.Windows.Forms.Label()
        Me.playerSkillTreebtn = New System.Windows.Forms.Button()
        Me.playerExperiencelbl = New System.Windows.Forms.Label()
        Me.playerGoldlbl = New System.Windows.Forms.Label()
        Me.playerExperiencebar = New System.Windows.Forms.ProgressBar()
        Me.playerLevellbl = New System.Windows.Forms.Label()
        Me.playerGoldtxt = New System.Windows.Forms.TextBox()
        Me.playerLeveltxt = New System.Windows.Forms.TextBox()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlayerCreaturesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.playerStatspnl.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreaturesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'playerStatspnl
        '
        Me.playerStatspnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.playerStatspnl.Controls.Add(Me.PlayerCreaturesDataGridView)
        Me.playerStatspnl.Controls.Add(Me.playerInfoPanellbl)
        Me.playerStatspnl.Controls.Add(Me.playerSkillTreebtn)
        Me.playerStatspnl.Controls.Add(Me.playerExperiencelbl)
        Me.playerStatspnl.Controls.Add(Me.playerGoldlbl)
        Me.playerStatspnl.Controls.Add(Me.playerExperiencebar)
        Me.playerStatspnl.Controls.Add(Me.playerLevellbl)
        Me.playerStatspnl.Controls.Add(Me.playerGoldtxt)
        Me.playerStatspnl.Controls.Add(Me.playerLeveltxt)
        Me.playerStatspnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.playerStatspnl.Location = New System.Drawing.Point(0, 0)
        Me.playerStatspnl.Name = "playerStatspnl"
        Me.playerStatspnl.Size = New System.Drawing.Size(324, 374)
        Me.playerStatspnl.TabIndex = 5
        '
        'playerInfoPanellbl
        '
        Me.playerInfoPanellbl.AutoSize = True
        Me.playerInfoPanellbl.ForeColor = System.Drawing.Color.White
        Me.playerInfoPanellbl.Location = New System.Drawing.Point(260, 5)
        Me.playerInfoPanellbl.Name = "playerInfoPanellbl"
        Me.playerInfoPanellbl.Size = New System.Drawing.Size(55, 13)
        Me.playerInfoPanellbl.TabIndex = 16
        Me.playerInfoPanellbl.Text = "player info"
        '
        'playerSkillTreebtn
        '
        Me.playerSkillTreebtn.Location = New System.Drawing.Point(38, 78)
        Me.playerSkillTreebtn.Name = "playerSkillTreebtn"
        Me.playerSkillTreebtn.Size = New System.Drawing.Size(54, 23)
        Me.playerSkillTreebtn.TabIndex = 13
        Me.playerSkillTreebtn.Text = "skills"
        Me.playerSkillTreebtn.UseVisualStyleBackColor = True
        '
        'playerExperiencelbl
        '
        Me.playerExperiencelbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerExperiencelbl.AutoSize = True
        Me.playerExperiencelbl.ForeColor = System.Drawing.Color.White
        Me.playerExperiencelbl.Location = New System.Drawing.Point(251, 333)
        Me.playerExperiencelbl.Name = "playerExperiencelbl"
        Me.playerExperiencelbl.Size = New System.Drawing.Size(59, 13)
        Me.playerExperiencelbl.TabIndex = 14
        Me.playerExperiencelbl.Text = "experience"
        '
        'playerGoldlbl
        '
        Me.playerGoldlbl.AutoSize = True
        Me.playerGoldlbl.ForeColor = System.Drawing.Color.White
        Me.playerGoldlbl.Location = New System.Drawing.Point(5, 29)
        Me.playerGoldlbl.Name = "playerGoldlbl"
        Me.playerGoldlbl.Size = New System.Drawing.Size(27, 13)
        Me.playerGoldlbl.TabIndex = 13
        Me.playerGoldlbl.Text = "gold"
        '
        'playerExperiencebar
        '
        Me.playerExperiencebar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerExperiencebar.Location = New System.Drawing.Point(12, 349)
        Me.playerExperiencebar.Name = "playerExperiencebar"
        Me.playerExperiencebar.Size = New System.Drawing.Size(300, 13)
        Me.playerExperiencebar.Step = 1
        Me.playerExperiencebar.TabIndex = 13
        '
        'playerLevellbl
        '
        Me.playerLevellbl.AutoSize = True
        Me.playerLevellbl.ForeColor = System.Drawing.Color.White
        Me.playerLevellbl.Location = New System.Drawing.Point(3, 55)
        Me.playerLevellbl.Name = "playerLevellbl"
        Me.playerLevellbl.Size = New System.Drawing.Size(29, 13)
        Me.playerLevellbl.TabIndex = 15
        Me.playerLevellbl.Text = "level"
        '
        'playerGoldtxt
        '
        Me.playerGoldtxt.Location = New System.Drawing.Point(38, 26)
        Me.playerGoldtxt.Name = "playerGoldtxt"
        Me.playerGoldtxt.ReadOnly = True
        Me.playerGoldtxt.Size = New System.Drawing.Size(54, 20)
        Me.playerGoldtxt.TabIndex = 12
        '
        'playerLeveltxt
        '
        Me.playerLeveltxt.Location = New System.Drawing.Point(38, 52)
        Me.playerLeveltxt.Name = "playerLeveltxt"
        Me.playerLeveltxt.ReadOnly = True
        Me.playerLeveltxt.Size = New System.Drawing.Size(54, 20)
        Me.playerLeveltxt.TabIndex = 14
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
        'PlayerCreaturesDataGridView
        '
        Me.PlayerCreaturesDataGridView.AllowUserToResizeColumns = False
        Me.PlayerCreaturesDataGridView.AllowUserToResizeRows = False
        Me.PlayerCreaturesDataGridView.AutoGenerateColumns = False
        Me.PlayerCreaturesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.PlayerCreaturesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlayerCreaturesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.PlayerCreaturesDataGridView.DataSource = Me.PlayerCreaturesBindingSource
        Me.PlayerCreaturesDataGridView.Location = New System.Drawing.Point(12, 107)
        Me.PlayerCreaturesDataGridView.Name = "PlayerCreaturesDataGridView"
        Me.PlayerCreaturesDataGridView.ReadOnly = True
        Me.PlayerCreaturesDataGridView.RowHeadersWidth = 25
        Me.PlayerCreaturesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PlayerCreaturesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PlayerCreaturesDataGridView.ShowEditingIcon = False
        Me.PlayerCreaturesDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PlayerCreaturesDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 40
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "playerid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "playerid"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 68
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "creatureid"
        Me.DataGridViewTextBoxColumn3.HeaderText = "creatureid"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 79
        '
        'PlayerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 374)
        Me.Controls.Add(Me.playerStatspnl)
        Me.Name = "PlayerWindow"
        Me.ShowIcon = False
        Me.Text = "PlayerWindow"
        Me.playerStatspnl.ResumeLayout(False)
        Me.playerStatspnl.PerformLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreaturesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents PlayerCreaturesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
