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
        Me.deletePlayersclst = New System.Windows.Forms.CheckedListBox()
        Me.deletePlayersListlbl = New System.Windows.Forms.Label()
        Me.deletePlayersbtn = New System.Windows.Forms.Button()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.PlayersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deletePlayersclst
        '
        Me.deletePlayersclst.CheckOnClick = True
        Me.deletePlayersclst.FormattingEnabled = True
        Me.deletePlayersclst.Location = New System.Drawing.Point(49, 37)
        Me.deletePlayersclst.Name = "deletePlayersclst"
        Me.deletePlayersclst.Size = New System.Drawing.Size(171, 124)
        Me.deletePlayersclst.TabIndex = 0
        '
        'deletePlayersListlbl
        '
        Me.deletePlayersListlbl.AutoSize = True
        Me.deletePlayersListlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletePlayersListlbl.Location = New System.Drawing.Point(12, 17)
        Me.deletePlayersListlbl.Name = "deletePlayersListlbl"
        Me.deletePlayersListlbl.Size = New System.Drawing.Size(245, 17)
        Me.deletePlayersListlbl.TabIndex = 1
        Me.deletePlayersListlbl.Text = "Which Players do you want to delete?"
        '
        'deletePlayersbtn
        '
        Me.deletePlayersbtn.Location = New System.Drawing.Point(97, 167)
        Me.deletePlayersbtn.Name = "deletePlayersbtn"
        Me.deletePlayersbtn.Size = New System.Drawing.Size(75, 23)
        Me.deletePlayersbtn.TabIndex = 2
        Me.deletePlayersbtn.Text = "Delete"
        Me.deletePlayersbtn.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.AttacksTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BattlesTableAdapter = Nothing
        Me.TableAdapterManager.CreaturesTableAdapter = Nothing
        Me.TableAdapterManager.ItemsTableAdapter = Nothing
        Me.TableAdapterManager.PlayersTableAdapter = Me.PlayersTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PlayersDataGridView
        '
        Me.PlayersDataGridView.AutoGenerateColumns = False
        Me.PlayersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.PlayersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlayersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PlayersDataGridView.DataSource = Me.PlayersBindingSource
        Me.PlayersDataGridView.Location = New System.Drawing.Point(269, 37)
        Me.PlayersDataGridView.Name = "PlayersDataGridView"
        Me.PlayersDataGridView.RowHeadersWidth = 25
        Me.PlayersDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.PlayersDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 21
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 21
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "level"
        Me.DataGridViewTextBoxColumn3.HeaderText = "level"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 21
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "experience"
        Me.DataGridViewTextBoxColumn4.HeaderText = "experience"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 21
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "gold"
        Me.DataGridViewTextBoxColumn5.HeaderText = "gold"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 21
        '
        'DeletePlayersWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 285)
        Me.Controls.Add(Me.PlayersDataGridView)
        Me.Controls.Add(Me.deletePlayersbtn)
        Me.Controls.Add(Me.deletePlayersListlbl)
        Me.Controls.Add(Me.deletePlayersclst)
        Me.Name = "DeletePlayersWindow"
        Me.ShowIcon = False
        Me.Text = "Delete Players"
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deletePlayersclst As CheckedListBox
    Friend WithEvents deletePlayersListlbl As Label
    Friend WithEvents deletePlayersbtn As Button
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PlayersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
