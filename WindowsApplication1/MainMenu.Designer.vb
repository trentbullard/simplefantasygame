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
        Me.playerSelectionlst = New System.Windows.Forms.ListBox()
        Me.playerSelectionlbl = New System.Windows.Forms.Label()
        Me.playerNewbtn = New System.Windows.Forms.Button()
        Me.PlayersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GameDatabaseDataSet = New WindowsApplication1.GameDatabaseDataSet()
        Me.PlayersTableAdapter = New WindowsApplication1.GameDatabaseDataSetTableAdapters.PlayersTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.GameDatabaseDataSetTableAdapters.TableAdapterManager()
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'titlelbl
        '
        Me.titlelbl.AutoSize = True
        Me.titlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlelbl.Location = New System.Drawing.Point(16, 17)
        Me.titlelbl.Name = "titlelbl"
        Me.titlelbl.Size = New System.Drawing.Size(205, 24)
        Me.titlelbl.TabIndex = 0
        Me.titlelbl.Text = "Fantasy Game by Trent"
        '
        'playerSelectionlst
        '
        Me.playerSelectionlst.FormattingEnabled = True
        Me.playerSelectionlst.Location = New System.Drawing.Point(58, 72)
        Me.playerSelectionlst.Name = "playerSelectionlst"
        Me.playerSelectionlst.Size = New System.Drawing.Size(120, 95)
        Me.playerSelectionlst.TabIndex = 1
        '
        'playerSelectionlbl
        '
        Me.playerSelectionlbl.AutoSize = True
        Me.playerSelectionlbl.Location = New System.Drawing.Point(70, 56)
        Me.playerSelectionlbl.Name = "playerSelectionlbl"
        Me.playerSelectionlbl.Size = New System.Drawing.Size(97, 13)
        Me.playerSelectionlbl.TabIndex = 2
        Me.playerSelectionlbl.Text = "Choose your player"
        '
        'playerNewbtn
        '
        Me.playerNewbtn.Location = New System.Drawing.Point(81, 173)
        Me.playerNewbtn.Name = "playerNewbtn"
        Me.playerNewbtn.Size = New System.Drawing.Size(75, 23)
        Me.playerNewbtn.TabIndex = 3
        Me.playerNewbtn.Text = "New Player"
        Me.playerNewbtn.UseVisualStyleBackColor = True
        '
        'PlayersBindingSource
        '
        Me.PlayersBindingSource.DataMember = "Players"
        Me.PlayersBindingSource.DataSource = Me.GameDatabaseDataSet
        '
        'GameDatabaseDataSet
        '
        Me.GameDatabaseDataSet.DataSetName = "GameDatabaseDataSet"
        Me.GameDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 212)
        Me.Controls.Add(Me.playerNewbtn)
        Me.Controls.Add(Me.playerSelectionlbl)
        Me.Controls.Add(Me.playerSelectionlst)
        Me.Controls.Add(Me.titlelbl)
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.Text = "Main Menu"
        CType(Me.PlayersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GameDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelbl As Label
    Friend WithEvents playerSelectionlst As ListBox
    Friend WithEvents playerSelectionlbl As Label
    Friend WithEvents playerNewbtn As Button
    Friend WithEvents GameDatabaseDataSet As GameDatabaseDataSet
    Friend WithEvents PlayersBindingSource As BindingSource
    Friend WithEvents PlayersTableAdapter As GameDatabaseDataSetTableAdapters.PlayersTableAdapter
    Friend WithEvents TableAdapterManager As GameDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TeamidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
