<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShopWindow
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
        Me.shoppnl = New System.Windows.Forms.Panel()
        Me.consumablesPanellbl = New System.Windows.Forms.Label()
        Me.consumablesSlot1Namelbl = New System.Windows.Forms.Label()
        Me.consumablesSlot1Nametxt = New System.Windows.Forms.TextBox()
        Me.consumablespnl = New System.Windows.Forms.Panel()
        Me.shoppnl.SuspendLayout()
        Me.consumablespnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'shoppnl
        '
        Me.shoppnl.Controls.Add(Me.consumablespnl)
        Me.shoppnl.Controls.Add(Me.consumablesPanellbl)
        Me.shoppnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shoppnl.Location = New System.Drawing.Point(0, 0)
        Me.shoppnl.Name = "shoppnl"
        Me.shoppnl.Size = New System.Drawing.Size(1062, 800)
        Me.shoppnl.TabIndex = 0
        '
        'consumablesPanellbl
        '
        Me.consumablesPanellbl.AutoSize = True
        Me.consumablesPanellbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consumablesPanellbl.Location = New System.Drawing.Point(165, 9)
        Me.consumablesPanellbl.Name = "consumablesPanellbl"
        Me.consumablesPanellbl.Size = New System.Drawing.Size(106, 20)
        Me.consumablesPanellbl.TabIndex = 0
        Me.consumablesPanellbl.Text = "Consumables"
        '
        'consumablesSlot1Namelbl
        '
        Me.consumablesSlot1Namelbl.AutoSize = True
        Me.consumablesSlot1Namelbl.Location = New System.Drawing.Point(55, 45)
        Me.consumablesSlot1Namelbl.Name = "consumablesSlot1Namelbl"
        Me.consumablesSlot1Namelbl.Size = New System.Drawing.Size(33, 13)
        Me.consumablesSlot1Namelbl.TabIndex = 0
        Me.consumablesSlot1Namelbl.Text = "name"
        '
        'consumablesSlot1Nametxt
        '
        Me.consumablesSlot1Nametxt.Location = New System.Drawing.Point(94, 42)
        Me.consumablesSlot1Nametxt.Name = "consumablesSlot1Nametxt"
        Me.consumablesSlot1Nametxt.Size = New System.Drawing.Size(100, 20)
        Me.consumablesSlot1Nametxt.TabIndex = 2
        '
        'consumablespnl
        '
        Me.consumablespnl.Controls.Add(Me.consumablesSlot1Namelbl)
        Me.consumablespnl.Controls.Add(Me.consumablesSlot1Nametxt)
        Me.consumablespnl.Location = New System.Drawing.Point(12, 32)
        Me.consumablespnl.Name = "consumablespnl"
        Me.consumablespnl.Size = New System.Drawing.Size(414, 493)
        Me.consumablespnl.TabIndex = 3
        '
        'ShopWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 800)
        Me.Controls.Add(Me.shoppnl)
        Me.Name = "ShopWindow"
        Me.ShowIcon = False
        Me.Text = "Shop"
        Me.shoppnl.ResumeLayout(False)
        Me.shoppnl.PerformLayout()
        Me.consumablespnl.ResumeLayout(False)
        Me.consumablespnl.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents shoppnl As Panel
    Friend WithEvents consumablespnl As Panel
    Friend WithEvents consumablesSlot1Namelbl As Label
    Friend WithEvents consumablesSlot1Nametxt As TextBox
    Friend WithEvents consumablesPanellbl As Label
End Class
