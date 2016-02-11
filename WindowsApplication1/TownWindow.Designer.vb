<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TownWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TownWindow))
        Me.townpnl = New System.Windows.Forms.Panel()
        Me.datepnl = New System.Windows.Forms.Panel()
        Me.datelbl = New System.Windows.Forms.Label()
        Me.add1Weekbtn = New System.Windows.Forms.Button()
        Me.playerbtn = New System.Windows.Forms.Button()
        Me.roadlbl = New System.Windows.Forms.Label()
        Me.marketlbl = New System.Windows.Forms.Label()
        Me.tavernlbl = New System.Windows.Forms.Label()
        Me.innlbl = New System.Windows.Forms.Label()
        Me.necromancerlbl = New System.Windows.Forms.Label()
        Me.mainMenubtn = New System.Windows.Forms.Button()
        Me.roadbtn = New System.Windows.Forms.Button()
        Me.necromancerbtn = New System.Windows.Forms.Button()
        Me.marketbtn = New System.Windows.Forms.Button()
        Me.tavernbtn = New System.Windows.Forms.Button()
        Me.innbtn = New System.Windows.Forms.Button()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayerCreaturesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayerCreaturesTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.townpnl.SuspendLayout()
        Me.datepnl.SuspendLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'townpnl
        '
        Me.townpnl.BackgroundImage = CType(resources.GetObject("townpnl.BackgroundImage"), System.Drawing.Image)
        Me.townpnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.townpnl.Controls.Add(Me.datepnl)
        Me.townpnl.Controls.Add(Me.add1Weekbtn)
        Me.townpnl.Controls.Add(Me.playerbtn)
        Me.townpnl.Controls.Add(Me.roadlbl)
        Me.townpnl.Controls.Add(Me.marketlbl)
        Me.townpnl.Controls.Add(Me.tavernlbl)
        Me.townpnl.Controls.Add(Me.innlbl)
        Me.townpnl.Controls.Add(Me.necromancerlbl)
        Me.townpnl.Controls.Add(Me.mainMenubtn)
        Me.townpnl.Controls.Add(Me.roadbtn)
        Me.townpnl.Controls.Add(Me.necromancerbtn)
        Me.townpnl.Controls.Add(Me.marketbtn)
        Me.townpnl.Controls.Add(Me.tavernbtn)
        Me.townpnl.Controls.Add(Me.innbtn)
        Me.townpnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.townpnl.Location = New System.Drawing.Point(0, 0)
        Me.townpnl.Name = "townpnl"
        Me.townpnl.Size = New System.Drawing.Size(1000, 600)
        Me.townpnl.TabIndex = 0
        '
        'datepnl
        '
        Me.datepnl.BackColor = System.Drawing.Color.Transparent
        Me.datepnl.Controls.Add(Me.datelbl)
        Me.datepnl.Location = New System.Drawing.Point(524, 570)
        Me.datepnl.Name = "datepnl"
        Me.datepnl.Size = New System.Drawing.Size(221, 12)
        Me.datepnl.TabIndex = 12
        '
        'datelbl
        '
        Me.datelbl.AutoSize = True
        Me.datelbl.BackColor = System.Drawing.Color.White
        Me.datelbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.datelbl.Location = New System.Drawing.Point(158, 0)
        Me.datelbl.Name = "datelbl"
        Me.datelbl.Size = New System.Drawing.Size(63, 13)
        Me.datelbl.TabIndex = 1
        Me.datelbl.Text = "currentDate"
        Me.datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'add1Weekbtn
        '
        Me.add1Weekbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.add1Weekbtn.Location = New System.Drawing.Point(751, 565)
        Me.add1Weekbtn.Name = "add1Weekbtn"
        Me.add1Weekbtn.Size = New System.Drawing.Size(75, 23)
        Me.add1Weekbtn.TabIndex = 1
        Me.add1Weekbtn.Text = "+ 1 week"
        Me.add1Weekbtn.UseVisualStyleBackColor = True
        '
        'playerbtn
        '
        Me.playerbtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playerbtn.Location = New System.Drawing.Point(832, 565)
        Me.playerbtn.Name = "playerbtn"
        Me.playerbtn.Size = New System.Drawing.Size(75, 23)
        Me.playerbtn.TabIndex = 11
        Me.playerbtn.Text = "player info"
        Me.playerbtn.UseVisualStyleBackColor = True
        '
        'roadlbl
        '
        Me.roadlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roadlbl.AutoSize = True
        Me.roadlbl.BackColor = System.Drawing.Color.Transparent
        Me.roadlbl.ForeColor = System.Drawing.Color.Lime
        Me.roadlbl.Location = New System.Drawing.Point(834, 87)
        Me.roadlbl.Name = "roadlbl"
        Me.roadlbl.Size = New System.Drawing.Size(97, 13)
        Me.roadlbl.TabIndex = 10
        Me.roadlbl.Text = "click here to travel!"
        '
        'marketlbl
        '
        Me.marketlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.marketlbl.AutoSize = True
        Me.marketlbl.BackColor = System.Drawing.Color.Transparent
        Me.marketlbl.ForeColor = System.Drawing.Color.Lime
        Me.marketlbl.Location = New System.Drawing.Point(521, 142)
        Me.marketlbl.Name = "marketlbl"
        Me.marketlbl.Size = New System.Drawing.Size(115, 13)
        Me.marketlbl.TabIndex = 9
        Me.marketlbl.Text = "click here to buy items!"
        '
        'tavernlbl
        '
        Me.tavernlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tavernlbl.AutoSize = True
        Me.tavernlbl.BackColor = System.Drawing.Color.Transparent
        Me.tavernlbl.ForeColor = System.Drawing.Color.Lime
        Me.tavernlbl.Location = New System.Drawing.Point(315, 322)
        Me.tavernlbl.Name = "tavernlbl"
        Me.tavernlbl.Size = New System.Drawing.Size(159, 13)
        Me.tavernlbl.TabIndex = 8
        Me.tavernlbl.Text = "click here to hire team members!"
        '
        'innlbl
        '
        Me.innlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.innlbl.AutoSize = True
        Me.innlbl.BackColor = System.Drawing.Color.Transparent
        Me.innlbl.ForeColor = System.Drawing.Color.Lime
        Me.innlbl.Location = New System.Drawing.Point(58, 351)
        Me.innlbl.Name = "innlbl"
        Me.innlbl.Size = New System.Drawing.Size(137, 13)
        Me.innlbl.TabIndex = 7
        Me.innlbl.Text = "click here to rest your team!"
        '
        'necromancerlbl
        '
        Me.necromancerlbl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.necromancerlbl.AutoSize = True
        Me.necromancerlbl.BackColor = System.Drawing.Color.Transparent
        Me.necromancerlbl.ForeColor = System.Drawing.Color.Lime
        Me.necromancerlbl.Location = New System.Drawing.Point(595, 204)
        Me.necromancerlbl.Name = "necromancerlbl"
        Me.necromancerlbl.Size = New System.Drawing.Size(199, 13)
        Me.necromancerlbl.TabIndex = 6
        Me.necromancerlbl.Text = "click here to revive fallen team members!"
        '
        'mainMenubtn
        '
        Me.mainMenubtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainMenubtn.Location = New System.Drawing.Point(913, 565)
        Me.mainMenubtn.Name = "mainMenubtn"
        Me.mainMenubtn.Size = New System.Drawing.Size(75, 23)
        Me.mainMenubtn.TabIndex = 0
        Me.mainMenubtn.Text = "main menu"
        Me.mainMenubtn.UseVisualStyleBackColor = True
        '
        'roadbtn
        '
        Me.roadbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.roadbtn.Location = New System.Drawing.Point(843, 103)
        Me.roadbtn.Name = "roadbtn"
        Me.roadbtn.Size = New System.Drawing.Size(81, 23)
        Me.roadbtn.TabIndex = 5
        Me.roadbtn.Text = "road"
        Me.roadbtn.UseVisualStyleBackColor = True
        '
        'necromancerbtn
        '
        Me.necromancerbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.necromancerbtn.Location = New System.Drawing.Point(655, 220)
        Me.necromancerbtn.Name = "necromancerbtn"
        Me.necromancerbtn.Size = New System.Drawing.Size(81, 23)
        Me.necromancerbtn.TabIndex = 4
        Me.necromancerbtn.Text = "necromancer"
        Me.necromancerbtn.UseVisualStyleBackColor = True
        '
        'marketbtn
        '
        Me.marketbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.marketbtn.Location = New System.Drawing.Point(542, 158)
        Me.marketbtn.Name = "marketbtn"
        Me.marketbtn.Size = New System.Drawing.Size(75, 23)
        Me.marketbtn.TabIndex = 3
        Me.marketbtn.Text = "market"
        Me.marketbtn.UseVisualStyleBackColor = True
        '
        'tavernbtn
        '
        Me.tavernbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tavernbtn.Location = New System.Drawing.Point(358, 296)
        Me.tavernbtn.Name = "tavernbtn"
        Me.tavernbtn.Size = New System.Drawing.Size(75, 23)
        Me.tavernbtn.TabIndex = 2
        Me.tavernbtn.Text = "tavern"
        Me.tavernbtn.UseVisualStyleBackColor = True
        '
        'innbtn
        '
        Me.innbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.innbtn.Location = New System.Drawing.Point(90, 325)
        Me.innbtn.Name = "innbtn"
        Me.innbtn.Size = New System.Drawing.Size(75, 23)
        Me.innbtn.TabIndex = 1
        Me.innbtn.Text = "inn"
        Me.innbtn.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.PlayerConsumablesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerCreaturesTableAdapter = Me.PlayerCreaturesTableAdapter
        Me.TableAdapterManager.PlayerPartiesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerSkillsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Nothing
        Me.TableAdapterManager.PlayerStatesTableAdapter = Nothing
        Me.TableAdapterManager.PlayerWeaponsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStateItemsTableAdapter = Nothing
        Me.TableAdapterManager.ScholarStatesTableAdapter = Nothing
        Me.TableAdapterManager.StaticArmorTableAdapter = Nothing
        Me.TableAdapterManager.StaticAugmentsTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampTableAdapter = Nothing
        Me.TableAdapterManager.StaticCampTierTableAdapter = Nothing
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
        'PlayersBindingSource
        '
        Me.PlayersBindingSource.DataMember = "Players"
        Me.PlayersBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'PlayersTableAdapter
        '
        Me.PlayersTableAdapter.ClearBeforeFill = True
        '
        'TownWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.townpnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TownWindow"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "TownWindow"
        Me.townpnl.ResumeLayout(False)
        Me.townpnl.PerformLayout()
        Me.datepnl.ResumeLayout(False)
        Me.datepnl.PerformLayout()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCreaturesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents townpnl As Panel
    Friend WithEvents mainMenubtn As Button
    Friend WithEvents necromancerlbl As Label
    Friend WithEvents roadbtn As Button
    Friend WithEvents necromancerbtn As Button
    Friend WithEvents marketbtn As Button
    Friend WithEvents tavernbtn As Button
    Friend WithEvents innbtn As Button
    Friend WithEvents roadlbl As Label
    Friend WithEvents marketlbl As Label
    Friend WithEvents tavernlbl As Label
    Friend WithEvents innlbl As Label
    Friend WithEvents playerbtn As Button
    Friend WithEvents add1Weekbtn As Button
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayerCreaturesBindingSource As BindingSource
    Friend WithEvents PlayerCreaturesTableAdapter As GameDatabaseDataSetTableAdapters.PlayerCreaturesTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents datelbl As Label
    Friend WithEvents datepnl As Panel
End Class
