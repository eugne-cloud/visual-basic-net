<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoLoop
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
        Me.btnChooseYourMeal = New System.Windows.Forms.Button()
        Me.txtSelection = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnChooseYourMeal
        '
        Me.btnChooseYourMeal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChooseYourMeal.Location = New System.Drawing.Point(72, 64)
        Me.btnChooseYourMeal.Name = "btnChooseYourMeal"
        Me.btnChooseYourMeal.Size = New System.Drawing.Size(270, 67)
        Me.btnChooseYourMeal.TabIndex = 0
        Me.btnChooseYourMeal.Text = "Choose Your Meal"
        Me.btnChooseYourMeal.UseVisualStyleBackColor = True
        '
        'txtSelection
        '
        Me.txtSelection.Location = New System.Drawing.Point(72, 161)
        Me.txtSelection.Multiline = True
        Me.txtSelection.Name = "txtSelection"
        Me.txtSelection.Size = New System.Drawing.Size(270, 150)
        Me.txtSelection.TabIndex = 1
        '
        'frmDoLoop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtSelection)
        Me.Controls.Add(Me.btnChooseYourMeal)
        Me.Name = "frmDoLoop"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnChooseYourMeal As Button
    Friend WithEvents txtSelection As TextBox
End Class
