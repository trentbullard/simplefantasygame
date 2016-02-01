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
        Me.deletePlayersListlbl = New System.Windows.Forms.Label()
        Me.deletePlayersbtn = New System.Windows.Forms.Button()
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.deletePlayerslst = New System.Windows.Forms.ListBox()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deletePlayersListlbl
        '
        Me.deletePlayersListlbl.AutoSize = True
        Me.deletePlayersListlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletePlayersListlbl.Location = New System.Drawing.Point(53, 22)
        Me.deletePlayersListlbl.Name = "deletePlayersListlbl"
        Me.deletePlayersListlbl.Size = New System.Drawing.Size(165, 17)
        Me.deletePlayersListlbl.TabIndex = 1
        Me.deletePlayersListlbl.Text = "Select 1 player to delete."
        '
        'deletePlayersbtn
        '
        Me.deletePlayersbtn.Location = New System.Drawing.Point(98, 172)
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
        'deletePlayerslst
        '
        Me.deletePlayerslst.FormattingEnabled = True
        Me.deletePlayerslst.Location = New System.Drawing.Point(56, 42)
        Me.deletePlayerslst.Name = "deletePlayerslst"
        Me.deletePlayerslst.Size = New System.Drawing.Size(162, 121)
        Me.deletePlayerslst.TabIndex = 3
        '
        'DeletePlayersWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 217)
        Me.Controls.Add(Me.deletePlayerslst)
        Me.Controls.Add(Me.deletePlayersbtn)
        Me.Controls.Add(Me.deletePlayersListlbl)
        Me.Name = "DeletePlayersWindow"
        Me.ShowIcon = False
        Me.Text = "Delete Players"
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents deletePlayersListlbl As Label
    Friend WithEvents deletePlayersbtn As Button
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents deletePlayerslst As ListBox
End Class
