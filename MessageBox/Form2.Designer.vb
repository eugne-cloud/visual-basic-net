<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblEnterANumber = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEnterANumber
        '
        Me.lblEnterANumber.AutoSize = True
        Me.lblEnterANumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterANumber.Location = New System.Drawing.Point(56, 83)
        Me.lblEnterANumber.Name = "lblEnterANumber"
        Me.lblEnterANumber.Size = New System.Drawing.Size(137, 20)
        Me.lblEnterANumber.TabIndex = 1
        Me.lblEnterANumber.Text = "Enter A Number"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(220, 83)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 26)
        Me.TextBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Image = CType(resources.GetObject("btnPower.Image"), System.Drawing.Image)
        Me.btnPower.Location = New System.Drawing.Point(611, 160)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(445, 426)
        Me.btnPower.TabIndex = 4
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.White
        Me.btnStop.Image = CType(resources.GetObject("btnStop.Image"), System.Drawing.Image)
        Me.btnStop.Location = New System.Drawing.Point(71, 160)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(447, 426)
        Me.btnStop.TabIndex = 5
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 679)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblEnterANumber)
        Me.Name = "Form2"
        Me.Text = "frmMain"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnterANumber As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnStop As Button
End Class
