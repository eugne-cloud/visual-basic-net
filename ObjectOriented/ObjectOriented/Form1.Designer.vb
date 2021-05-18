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
        Me.btnMove = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picCircle = New System.Windows.Forms.PictureBox()
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(112, 254)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(260, 55)
        Me.btnMove.TabIndex = 0
        Me.btnMove.Text = "Move and Show Circle"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(617, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(121, 55)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picCircle
        '
        Me.picCircle.Location = New System.Drawing.Point(317, 34)
        Me.picCircle.Name = "picCircle"
        Me.picCircle.Size = New System.Drawing.Size(267, 169)
        Me.picCircle.TabIndex = 2
        Me.picCircle.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 345)
        Me.Controls.Add(Me.picCircle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMove)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picCircle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMove As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picCircle As PictureBox
End Class
