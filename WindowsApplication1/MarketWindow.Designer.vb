<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MarketWindow
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
        Me.farmerbtn = New System.Windows.Forms.Button()
        Me.chemistbtn = New System.Windows.Forms.Button()
        Me.blacksmithbtn = New System.Windows.Forms.Button()
        Me.scholarbtn = New System.Windows.Forms.Button()
        Me.mainMenubtn = New System.Windows.Forms.Button()
        Me.playerInfobtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.townbtn = New System.Windows.Forms.Button()
        Me.chemistlbl = New System.Windows.Forms.Label()
        Me.scholarlbl = New System.Windows.Forms.Label()
        Me.farmerlbl = New System.Windows.Forms.Label()
        Me.blacksmithlbl = New System.Windows.Forms.Label()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.BlacksmithStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlacksmithStatesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.BlacksmithStatesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.BlacksmithStateItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlacksmithStateItemsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.BlacksmithStateItemsTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlacksmithStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlacksmithStateItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'farmerbtn
        '
        Me.farmerbtn.Location = New System.Drawing.Point(241, 54)
        Me.farmerbtn.Name = "farmerbtn"
        Me.farmerbtn.Size = New System.Drawing.Size(75, 23)
        Me.farmerbtn.TabIndex = 0
        Me.farmerbtn.Text = "farmer"
        Me.farmerbtn.UseVisualStyleBackColor = True
        '
        'chemistbtn
        '
        Me.chemistbtn.Location = New System.Drawing.Point(205, 138)
        Me.chemistbtn.Name = "chemistbtn"
        Me.chemistbtn.Size = New System.Drawing.Size(75, 23)
        Me.chemistbtn.TabIndex = 1
        Me.chemistbtn.Text = "chemist"
        Me.chemistbtn.UseVisualStyleBackColor = True
        '
        'blacksmithbtn
        '
        Me.blacksmithbtn.Location = New System.Drawing.Point(248, 12)
        Me.blacksmithbtn.Name = "blacksmithbtn"
        Me.blacksmithbtn.Size = New System.Drawing.Size(75, 23)
        Me.blacksmithbtn.TabIndex = 2
        Me.blacksmithbtn.Text = "blacksmith"
        Me.blacksmithbtn.UseVisualStyleBackColor = True
        '
        'scholarbtn
        '
        Me.scholarbtn.Location = New System.Drawing.Point(266, 96)
        Me.scholarbtn.Name = "scholarbtn"
        Me.scholarbtn.Size = New System.Drawing.Size(75, 23)
        Me.scholarbtn.TabIndex = 3
        Me.scholarbtn.Text = "scholar"
        Me.scholarbtn.UseVisualStyleBackColor = True
        '
        'mainMenubtn
        '
        Me.mainMenubtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainMenubtn.Location = New System.Drawing.Point(266, 188)
        Me.mainMenubtn.Name = "mainMenubtn"
        Me.mainMenubtn.Size = New System.Drawing.Size(75, 23)
        Me.mainMenubtn.TabIndex = 4
        Me.mainMenubtn.Text = "main menu"
        Me.mainMenubtn.UseVisualStyleBackColor = True
        '
        'playerInfobtn
        '
        Me.playerInfobtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerInfobtn.Location = New System.Drawing.Point(185, 188)
        Me.playerInfobtn.Name = "playerInfobtn"
        Me.playerInfobtn.Size = New System.Drawing.Size(75, 23)
        Me.playerInfobtn.TabIndex = 5
        Me.playerInfobtn.Text = "player info"
        Me.playerInfobtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.townbtn)
        Me.Panel1.Controls.Add(Me.chemistlbl)
        Me.Panel1.Controls.Add(Me.scholarlbl)
        Me.Panel1.Controls.Add(Me.farmerlbl)
        Me.Panel1.Controls.Add(Me.blacksmithlbl)
        Me.Panel1.Controls.Add(Me.mainMenubtn)
        Me.Panel1.Controls.Add(Me.playerInfobtn)
        Me.Panel1.Controls.Add(Me.farmerbtn)
        Me.Panel1.Controls.Add(Me.chemistbtn)
        Me.Panel1.Controls.Add(Me.scholarbtn)
        Me.Panel1.Controls.Add(Me.blacksmithbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 223)
        Me.Panel1.TabIndex = 6
        '
        'townbtn
        '
        Me.townbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.townbtn.Location = New System.Drawing.Point(89, 188)
        Me.townbtn.Name = "townbtn"
        Me.townbtn.Size = New System.Drawing.Size(90, 23)
        Me.townbtn.TabIndex = 7
        Me.townbtn.Text = "back to town"
        Me.townbtn.UseVisualStyleBackColor = True
        '
        'chemistlbl
        '
        Me.chemistlbl.AutoSize = True
        Me.chemistlbl.Location = New System.Drawing.Point(74, 143)
        Me.chemistlbl.Name = "chemistlbl"
        Me.chemistlbl.Size = New System.Drawing.Size(125, 13)
        Me.chemistlbl.TabIndex = 9
        Me.chemistlbl.Text = "click here to buy potions!"
        '
        'scholarlbl
        '
        Me.scholarlbl.AutoSize = True
        Me.scholarlbl.Location = New System.Drawing.Point(12, 101)
        Me.scholarlbl.Name = "scholarlbl"
        Me.scholarlbl.Size = New System.Drawing.Size(248, 13)
        Me.scholarlbl.TabIndex = 8
        Me.scholarlbl.Text = "click here to buy augments for weapons and armor!"
        '
        'farmerlbl
        '
        Me.farmerlbl.AutoSize = True
        Me.farmerlbl.Location = New System.Drawing.Point(38, 59)
        Me.farmerlbl.Name = "farmerlbl"
        Me.farmerlbl.Size = New System.Drawing.Size(197, 13)
        Me.farmerlbl.TabIndex = 7
        Me.farmerlbl.Text = "click here to buy food and leather armor!"
        '
        'blacksmithlbl
        '
        Me.blacksmithlbl.AutoSize = True
        Me.blacksmithlbl.Location = New System.Drawing.Point(30, 17)
        Me.blacksmithlbl.Name = "blacksmithlbl"
        Me.blacksmithlbl.Size = New System.Drawing.Size(212, 13)
        Me.blacksmithlbl.TabIndex = 6
        Me.blacksmithlbl.Text = "click here to buy weapons and metal armor!"
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
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Nothing
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
        Me.TableAdapterManager.StaticMobsTableAdapter = Nothing
        Me.TableAdapterManager.StaticQuestsTableAdapter = Nothing
        Me.TableAdapterManager.StaticSkillsTableAdapter = Nothing
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.TavernStatesTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Nothing
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
        'MarketWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 223)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "MarketWindow"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "market"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlacksmithStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlacksmithStateItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents farmerbtn As Button
    Friend WithEvents chemistbtn As Button
    Friend WithEvents blacksmithbtn As Button
    Friend WithEvents scholarbtn As Button
    Friend WithEvents mainMenubtn As Button
    Friend WithEvents playerInfobtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chemistlbl As Label
    Friend WithEvents scholarlbl As Label
    Friend WithEvents farmerlbl As Label
    Friend WithEvents blacksmithlbl As Label
    Friend WithEvents townbtn As Button
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents BlacksmithStatesBindingSource As BindingSource
    Friend WithEvents BlacksmithStatesTableAdapter As GameDatabaseDataSetTableAdapters.BlacksmithStatesTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BlacksmithStateItemsTableAdapter As GameDatabaseDataSetTableAdapters.BlacksmithStateItemsTableAdapter
    Friend WithEvents BlacksmithStateItemsBindingSource As BindingSource
End Class
