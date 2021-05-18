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
        Me.lblCountryName = New System.Windows.Forms.Label()
        Me.lstCountryName = New System.Windows.Forms.ListBox()
        Me.picFlag = New System.Windows.Forms.PictureBox()
        Me.btnShow = New System.Windows.Forms.Button()
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCountryName
        '
        Me.lblCountryName.AutoSize = True
        Me.lblCountryName.Location = New System.Drawing.Point(36, 50)
        Me.lblCountryName.Name = "lblCountryName"
        Me.lblCountryName.Size = New System.Drawing.Size(110, 20)
        Me.lblCountryName.TabIndex = 0
        Me.lblCountryName.Text = "Country Name"
        '
        'lstCountryName
        '
        Me.lstCountryName.FormattingEnabled = True
        Me.lstCountryName.ItemHeight = 20
        Me.lstCountryName.Items.AddRange(New Object() {"CANADA", "MALAYSIA", "UNITED STATES"})
        Me.lstCountryName.Location = New System.Drawing.Point(40, 102)
        Me.lstCountryName.Name = "lstCountryName"
        Me.lstCountryName.Size = New System.Drawing.Size(181, 244)
        Me.lstCountryName.TabIndex = 1
        '
        'picFlag
        '
        Me.picFlag.Location = New System.Drawing.Point(307, 102)
        Me.picFlag.Name = "picFlag"
        Me.picFlag.Size = New System.Drawing.Size(321, 244)
        Me.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag.TabIndex = 2
        Me.picFlag.TabStop = False
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(307, 367)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(96, 43)
        Me.btnShow.TabIndex = 3
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.picFlag)
        Me.Controls.Add(Me.lstCountryName)
        Me.Controls.Add(Me.lblCountryName)
        Me.Name = "Form2"
        Me.Text = "frmDisplayFlag"
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCountryName As Label
    Friend WithEvents lstCountryName As ListBox
    Friend WithEvents picFlag As PictureBox
    Friend WithEvents btnShow As Button
End Class
