<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoOfDays
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
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lstbMonth = New System.Windows.Forms.ListBox()
        Me.btnDetDays = New System.Windows.Forms.Button()
        Me.lblNoDays = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(29, 34)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(157, 25)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "Select a Month"
        '
        'lstbMonth
        '
        Me.lstbMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbMonth.FormattingEnabled = True
        Me.lstbMonth.ItemHeight = 20
        Me.lstbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.lstbMonth.Location = New System.Drawing.Point(34, 80)
        Me.lstbMonth.Name = "lstbMonth"
        Me.lstbMonth.Size = New System.Drawing.Size(152, 264)
        Me.lstbMonth.TabIndex = 1
        '
        'btnDetDays
        '
        Me.btnDetDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDetDays.Location = New System.Drawing.Point(277, 80)
        Me.btnDetDays.Name = "btnDetDays"
        Me.btnDetDays.Size = New System.Drawing.Size(300, 63)
        Me.btnDetDays.TabIndex = 2
        Me.btnDetDays.Text = "Determine Number of Days"
        Me.btnDetDays.UseVisualStyleBackColor = True
        '
        'lblNoDays
        '
        Me.lblNoDays.AutoSize = True
        Me.lblNoDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoDays.Location = New System.Drawing.Point(277, 178)
        Me.lblNoDays.Name = "lblNoDays"
        Me.lblNoDays.Size = New System.Drawing.Size(142, 26)
        Me.lblNoDays.TabIndex = 3
        Me.lblNoDays.Text = "No Of Days:"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(426, 183)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 20)
        Me.lblOutput.TabIndex = 4
        '
        'lblOutput2
        '
        Me.lblOutput2.AutoSize = True
        Me.lblOutput2.Location = New System.Drawing.Point(433, 183)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(18, 20)
        Me.lblOutput2.TabIndex = 5
        Me.lblOutput2.Text = "0"
        '
        'frmNoOfDays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 408)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblNoDays)
        Me.Controls.Add(Me.btnDetDays)
        Me.Controls.Add(Me.lstbMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Name = "frmNoOfDays"
        Me.Text = "Number of Days"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMonth As Label
    Friend WithEvents lstbMonth As ListBox
    Friend WithEvents btnDetDays As Button
    Friend WithEvents lblNoDays As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblOutput2 As Label
End Class
