﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.titlelbl = New System.Windows.Forms.Label()
        Me.playerSelectionlbl = New System.Windows.Forms.Label()
        Me.playerNewbtn = New System.Windows.Forms.Button()
        Me.playerSelectlstv = New System.Windows.Forms.ListView()
        Me.playerLevel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playerName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.playerDeletebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'titlelbl
        '
        Me.titlelbl.AutoSize = True
        Me.titlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlelbl.Location = New System.Drawing.Point(13, 18)
        Me.titlelbl.Name = "titlelbl"
        Me.titlelbl.Size = New System.Drawing.Size(205, 24)
        Me.titlelbl.TabIndex = 0
        Me.titlelbl.Text = "Fantasy Game by Trent"
        '
        'playerSelectionlbl
        '
        Me.playerSelectionlbl.AutoSize = True
        Me.playerSelectionlbl.Location = New System.Drawing.Point(65, 53)
        Me.playerSelectionlbl.Name = "playerSelectionlbl"
        Me.playerSelectionlbl.Size = New System.Drawing.Size(97, 13)
        Me.playerSelectionlbl.TabIndex = 2
        Me.playerSelectionlbl.Text = "Choose your player"
        '
        'playerNewbtn
        '
        Me.playerNewbtn.Location = New System.Drawing.Point(37, 172)
        Me.playerNewbtn.Name = "playerNewbtn"
        Me.playerNewbtn.Size = New System.Drawing.Size(75, 23)
        Me.playerNewbtn.TabIndex = 3
        Me.playerNewbtn.Text = "New"
        Me.playerNewbtn.UseVisualStyleBackColor = True
        '
        'playerSelectlstv
        '
        Me.playerSelectlstv.AutoArrange = False
        Me.playerSelectlstv.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.playerLevel, Me.playerName})
        Me.playerSelectlstv.FullRowSelect = True
        Me.playerSelectlstv.GridLines = True
        Me.playerSelectlstv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.playerSelectlstv.Location = New System.Drawing.Point(54, 69)
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
        Me.playerDeletebtn.Location = New System.Drawing.Point(118, 172)
        Me.playerDeletebtn.Name = "playerDeletebtn"
        Me.playerDeletebtn.Size = New System.Drawing.Size(75, 23)
        Me.playerDeletebtn.TabIndex = 5
        Me.playerDeletebtn.Text = "Delete"
        Me.playerDeletebtn.UseVisualStyleBackColor = True
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
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents titlelbl As Label
    Friend WithEvents playerSelectionlbl As Label
    Friend WithEvents playerNewbtn As Button
    Friend WithEvents TeamidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InventoryidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents playerSelectlstv As ListView
    Friend WithEvents playerLevel As ColumnHeader
    Friend WithEvents playerName As ColumnHeader
    Friend WithEvents playerDeletebtn As Button
End Class
