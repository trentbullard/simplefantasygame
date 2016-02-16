<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.titlelbl = New System.Windows.Forms.Label()
        Me.playerSelectionlbl = New System.Windows.Forms.Label()
        Me.playerNewbtn = New System.Windows.Forms.Button()
        Me.playerSelectlstv = New System.Windows.Forms.ListView()
        Me.playerLevel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playerDeletebtn = New System.Windows.Forms.Button()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlayerPartiesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerPartiesTableAdapter()
        Me.PlayerStatesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter()
        Me.StaticCampTiersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticCampTiersTableAdapter()
        Me.StaticCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter()
        Me.StaticQuestsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticQuestsTableAdapter()
        Me.PlayerStatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerPartiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticQuestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCampTiersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.StaticCampsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticCampsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticCampsTableAdapter()
        Me.StaticWeaponsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticWeaponsTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter()
        Me.StaticArmorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaticArmorTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerPartiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticQuestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCampTiersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticCampsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titlelbl
        '
        Me.titlelbl.AutoSize = True
        Me.titlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlelbl.Location = New System.Drawing.Point(24, 18)
        Me.titlelbl.Name = "titlelbl"
        Me.titlelbl.Size = New System.Drawing.Size(186, 24)
        Me.titlelbl.TabIndex = 0
        Me.titlelbl.Text = "fantasy game by trent"
        '
        'playerSelectionlbl
        '
        Me.playerSelectionlbl.AutoSize = True
        Me.playerSelectionlbl.Location = New System.Drawing.Point(69, 53)
        Me.playerSelectionlbl.Name = "playerSelectionlbl"
        Me.playerSelectionlbl.Size = New System.Drawing.Size(96, 13)
        Me.playerSelectionlbl.TabIndex = 2
        Me.playerSelectionlbl.Text = "choose your player"
        '
        'playerNewbtn
        '
        Me.playerNewbtn.Location = New System.Drawing.Point(39, 172)
        Me.playerNewbtn.Name = "playerNewbtn"
        Me.playerNewbtn.Size = New System.Drawing.Size(75, 23)
        Me.playerNewbtn.TabIndex = 3
        Me.playerNewbtn.Text = "new"
        Me.playerNewbtn.UseVisualStyleBackColor = True
        '
        'playerSelectlstv
        '
        Me.playerSelectlstv.AutoArrange = False
        Me.playerSelectlstv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.playerLevel, Me.playerName})
        Me.playerSelectlstv.FullRowSelect = True
        Me.playerSelectlstv.GridLines = True
        Me.playerSelectlstv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.playerSelectlstv.HideSelection = False
        Me.playerSelectlstv.Location = New System.Drawing.Point(56, 69)
        Me.playerSelectlstv.MultiSelect = False
        Me.playerSelectlstv.Name = "playerSelectlstv"
        Me.playerSelectlstv.Size = New System.Drawing.Size(125, 97)
        Me.playerSelectlstv.TabIndex = 4
        Me.playerSelectlstv.UseCompatibleStateImageBehavior = False
        Me.playerSelectlstv.View = System.Windows.Forms.View.Details
        '
        'playerLevel
        '
        Me.playerLevel.Text = "Level"
        Me.playerLevel.Width = 40
        '
        'playerName
        '
        Me.playerName.Text = "Name"
        Me.playerName.Width = 81
        '
        'playerDeletebtn
        '
        Me.playerDeletebtn.Location = New System.Drawing.Point(120, 172)
        Me.playerDeletebtn.Name = "playerDeletebtn"
        Me.playerDeletebtn.Size = New System.Drawing.Size(75, 23)
        Me.playerDeletebtn.TabIndex = 5
        Me.playerDeletebtn.Text = "delete"
        Me.playerDeletebtn.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Me.PlayerPartiesTableAdapter
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Me.PlayersTableAdapter
        Me.TableAdapterManager.PlayerStatesTableAdapter = Me.PlayerStatesTableAdapter
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.RoadStatesTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStatesTableAdapter = Nothing
        Me.TableAdapterManager.StaticArmorTableAdapter = Nothing
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampTiersTableAdapter = Me.StaticCampTiersTableAdapter
        Me.TableAdapterManager.StaticConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.StaticCreaturesTableAdapter = Me.StaticCreaturesTableAdapter
        Me.TableAdapterManager.StaticMobsTableAdapter = Nothing
        Me.TableAdapterManager.StaticQuestsTableAdapter = Me.StaticQuestsTableAdapter
        Me.TableAdapterManager.StaticSkillsTableAdapter = Nothing
        Me.TableAdapterManager.StaticWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.TavernStatesTableAdapter = Nothing
        Me.TableAdapterManager.TurnsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WeaponAugmentsTableAdapter = Nothing
        '
        'PlayerPartiesTableAdapter
        '
        Me.PlayerPartiesTableAdapter.ClearBeforeFill = True
        '
        'PlayerStatesTableAdapter
        '
        Me.PlayerStatesTableAdapter.ClearBeforeFill = True
        '
        'StaticCampTiersTableAdapter
        '
        Me.StaticCampTiersTableAdapter.ClearBeforeFill = True
        '
        'StaticCreaturesTableAdapter
        '
        Me.StaticCreaturesTableAdapter.ClearBeforeFill = True
        '
        'StaticQuestsTableAdapter
        '
        Me.StaticQuestsTableAdapter.ClearBeforeFill = True
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaticCampsBindingSource
        '
        Me.StaticCampsBindingSource.DataMember = "StaticCamps"
        Me.StaticCampsBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'StaticCampsTableAdapter
        '
        Me.StaticCampsTableAdapter.ClearBeforeFill = True
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
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(231, 212)
        Me.Controls.Add(Me.playerDeletebtn)
        Me.Controls.Add(Me.playerSelectlstv)
        Me.Controls.Add(Me.playerNewbtn)
        Me.Controls.Add(Me.playerSelectionlbl)
        Me.Controls.Add(Me.titlelbl)
        Me.MinimumSize = New System.Drawing.Size(247, 251)
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.Text = "main menu"
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerStatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerPartiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticQuestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCampTiersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticCampsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticWeaponsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaticArmorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelbl As Label
    Friend WithEvents playerSelectionlbl As Label
    Friend WithEvents playerNewbtn As Button
    Friend WithEvents playerSelectlstv As ListView
    Friend WithEvents playerLevel As ColumnHeader
    Friend WithEvents playerName As ColumnHeader
    Friend WithEvents playerDeletebtn As Button
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlayerStatesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerStatesTableAdapter
    Friend WithEvents PlayerStatesBindingSource As BindingSource
    Friend WithEvents PlayerPartiesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerPartiesTableAdapter
    Friend WithEvents PlayerPartiesBindingSource As BindingSource
    Friend WithEvents StaticCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.StaticCreaturesTableAdapter
    Friend WithEvents StaticCreaturesBindingSource As BindingSource
    Friend WithEvents StaticQuestsTableAdapter As GameDatabaseDataSetTableAdapters.StaticQuestsTableAdapter
    Friend WithEvents StaticQuestsBindingSource As BindingSource
    Friend WithEvents StaticCampTiersTableAdapter As GameDatabaseDataSetTableAdapters.StaticCampTiersTableAdapter
    Friend WithEvents StaticCampTiersBindingSource As BindingSource
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents StaticCampsBindingSource As BindingSource
    Friend WithEvents StaticCampsTableAdapter As GameDatabaseDataSetTableAdapters.StaticCampsTableAdapter
    Friend WithEvents StaticWeaponsBindingSource As BindingSource
    Friend WithEvents StaticWeaponsTableAdapter As GameDatabaseDataSetTableAdapters.StaticWeaponsTableAdapter
    Friend WithEvents StaticArmorBindingSource As BindingSource
    Friend WithEvents StaticArmorTableAdapter As GameDatabaseDataSetTableAdapters.StaticArmorTableAdapter
End Class
