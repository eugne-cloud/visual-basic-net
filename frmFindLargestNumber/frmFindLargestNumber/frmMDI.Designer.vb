<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMDI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuChild = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChild1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChild2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChild})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuChild
        '
        Me.mnuChild.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuChild1, Me.mnuChild2})
        Me.mnuChild.Name = "mnuChild"
        Me.mnuChild.Size = New System.Drawing.Size(115, 29)
        Me.mnuChild.Text = "Child Form"
        '
        'mnuChild1
        '
        Me.mnuChild1.Name = "mnuChild1"
        Me.mnuChild1.Size = New System.Drawing.Size(270, 34)
        Me.mnuChild1.Text = "Child 1"
        '
        'mnuChild2
        '
        Me.mnuChild2.Name = "mnuChild2"
        Me.mnuChild2.Size = New System.Drawing.Size(270, 34)
        Me.mnuChild2.Text = "Child 2"
        '
        'frmMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMDI"
        Me.Text = "frmMDI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuChild As ToolStripMenuItem
    Friend WithEvents mnuChild1 As ToolStripMenuItem
    Friend WithEvents mnuChild2 As ToolStripMenuItem
End Class
