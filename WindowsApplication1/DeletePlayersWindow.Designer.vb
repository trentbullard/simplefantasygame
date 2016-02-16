<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeletePlayersWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeletePlayersWindow))
        Me.deletePlayersListlbl = New System.Windows.Forms.Label()
        Me.deletePlayersbtn = New System.Windows.Forms.Button()
        Me.deletePlayerslst = New System.Windows.Forms.ListBox()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlayersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PlayersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'deletePlayersListlbl
        '
        Me.deletePlayersListlbl.AutoSize = True
        Me.deletePlayersListlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletePlayersListlbl.Location = New System.Drawing.Point(56, 22)
        Me.deletePlayersListlbl.Name = "deletePlayersListlbl"
        Me.deletePlayersListlbl.Size = New System.Drawing.Size(159, 17)
        Me.deletePlayersListlbl.TabIndex = 1
        Me.deletePlayersListlbl.Text = "select a player to delete"
        '
        'deletePlayersbtn
        '
        Me.deletePlayersbtn.Location = New System.Drawing.Point(98, 172)
        Me.deletePlayersbtn.Name = "deletePlayersbtn"
        Me.deletePlayersbtn.Size = New System.Drawing.Size(75, 23)
        Me.deletePlayersbtn.TabIndex = 2
        Me.deletePlayersbtn.Text = "delete"
        Me.deletePlayersbtn.UseVisualStyleBackColor = True
        '
        'deletePlayerslst
        '
        Me.deletePlayerslst.FormattingEnabled = True
        Me.deletePlayerslst.Location = New System.Drawing.Point(56, 42)
        Me.deletePlayerslst.Name = "deletePlayerslst"
        Me.deletePlayerslst.Size = New System.Drawing.Size(162, 121)
        Me.deletePlayerslst.TabIndex = 3
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
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Me.PlayersTableAdapter
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
        'PlayersBindingNavigator
        '
        Me.PlayersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PlayersBindingNavigator.BindingSource = Me.PlayersBindingSource
        Me.PlayersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PlayersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PlayersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PlayersBindingNavigatorSaveItem})
        Me.PlayersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PlayersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PlayersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PlayersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PlayersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PlayersBindingNavigator.Name = "PlayersBindingNavigator"
        Me.PlayersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PlayersBindingNavigator.Size = New System.Drawing.Size(111, 25)
        Me.PlayersBindingNavigator.TabIndex = 4
        Me.PlayersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'PlayersBindingNavigatorSaveItem
        '
        Me.PlayersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PlayersBindingNavigatorSaveItem.Image = CType(resources.GetObject("PlayersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PlayersBindingNavigatorSaveItem.Name = "PlayersBindingNavigatorSaveItem"
        Me.PlayersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PlayersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DeletePlayersWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 217)
        Me.Controls.Add(Me.PlayersBindingNavigator)
        Me.Controls.Add(Me.deletePlayerslst)
        Me.Controls.Add(Me.deletePlayersbtn)
        Me.Controls.Add(Me.deletePlayersListlbl)
        Me.Name = "DeletePlayersWindow"
        Me.ShowIcon = False
        Me.Text = "delete player"
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlayersBindingNavigator.ResumeLayout(False)
        Me.PlayersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deletePlayersListlbl As Label
    Friend WithEvents deletePlayersbtn As Button
    Friend WithEvents deletePlayerslst As ListBox
    Friend WithEvents GameDatabaseDataSet1 As GameDatabaseDataSet
    Friend WithEvents PlayersBindingSource1 As BindingSource
    Friend WithEvents PlayersTableAdapter1 As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents TableAdapterManager1 As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlayersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PlayersBindingNavigatorSaveItem As ToolStripButton
End Class
