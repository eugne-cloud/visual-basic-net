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
        Me.btnShowMessage = New System.Windows.Forms.Button()
        Me.btnShowMessage1 = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtSecondPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShowMessage
        '
        Me.btnShowMessage.Location = New System.Drawing.Point(468, 313)
        Me.btnShowMessage.Name = "btnShowMessage"
        Me.btnShowMessage.Size = New System.Drawing.Size(146, 65)
        Me.btnShowMessage.TabIndex = 0
        Me.btnShowMessage.Text = "Show Message"
        Me.btnShowMessage.UseVisualStyleBackColor = True
        '
        'btnShowMessage1
        '
        Me.btnShowMessage1.Location = New System.Drawing.Point(155, 313)
        Me.btnShowMessage1.Name = "btnShowMessage1"
        Me.btnShowMessage1.Size = New System.Drawing.Size(146, 65)
        Me.btnShowMessage1.TabIndex = 1
        Me.btnShowMessage1.Text = "Show Message 1"
        Me.btnShowMessage1.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(314, 124)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(223, 26)
        Me.txtPassword.TabIndex = 2
        '
        'txtSecondPassword
        '
        Me.txtSecondPassword.Location = New System.Drawing.Point(314, 225)
        Me.txtSecondPassword.Name = "txtSecondPassword"
        Me.txtSecondPassword.Size = New System.Drawing.Size(223, 26)
        Me.txtSecondPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(144, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(151, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Second Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSecondPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnShowMessage1)
        Me.Controls.Add(Me.btnShowMessage)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowMessage As Button
    Friend WithEvents btnShowMessage1 As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSecondPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
