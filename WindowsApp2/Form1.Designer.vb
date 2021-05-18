<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnAnalyzeName = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(21, 53)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(326, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "NAME (FIRST AND LAST NAME ONLY)"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(370, 53)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(318, 26)
        Me.txtName.TabIndex = 1
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(21, 118)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(91, 20)
        Me.lblResults.TabIndex = 2
        Me.lblResults.Text = "RESULTS"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 20
        Me.lstResults.Location = New System.Drawing.Point(129, 118)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(559, 224)
        Me.lstResults.TabIndex = 3
        '
        'btnAnalyzeName
        '
        Me.btnAnalyzeName.Location = New System.Drawing.Point(507, 363)
        Me.btnAnalyzeName.Name = "btnAnalyzeName"
        Me.btnAnalyzeName.Size = New System.Drawing.Size(181, 37)
        Me.btnAnalyzeName.TabIndex = 4
        Me.btnAnalyzeName.Text = "Analyze Name"
        Me.btnAnalyzeName.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAnalyzeName)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "frmParseName"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblResults As Label
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnAnalyzeName As Button
End Class
