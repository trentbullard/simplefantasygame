<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EquipWindow
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
        Me.creaturelst = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'creaturelst
        '
        Me.creaturelst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.creaturelst.FormattingEnabled = True
        Me.creaturelst.Location = New System.Drawing.Point(0, 0)
        Me.creaturelst.Name = "creaturelst"
        Me.creaturelst.Size = New System.Drawing.Size(221, 234)
        Me.creaturelst.TabIndex = 0
        Me.creaturelst.TabStop = False
        '
        'EquipWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(221, 234)
        Me.Controls.Add(Me.creaturelst)
        Me.Name = "EquipWindow"
        Me.ShowIcon = False
        Me.Text = "Apply"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents creaturelst As ListBox
End Class
