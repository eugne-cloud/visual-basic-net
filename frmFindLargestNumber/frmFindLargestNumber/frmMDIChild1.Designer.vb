<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMDIChild1
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
        Me.Day = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.cboOptions = New System.Windows.Forms.ComboBox()
        Me.cboSelectionOutcome = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lstDay = New System.Windows.Forms.ListBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Day
        '
        Me.Day.AutoSize = True
        Me.Day.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Day.Location = New System.Drawing.Point(15, 28)
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(50, 25)
        Me.Day.TabIndex = 0
        Me.Day.Text = "Day"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Options"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(391, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Selection Outcome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Day"
        '
        'cboDay
        '
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Location = New System.Drawing.Point(108, 28)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(204, 28)
        Me.cboDay.TabIndex = 5
        '
        'cboOptions
        '
        Me.cboOptions.FormattingEnabled = True
        Me.cboOptions.Location = New System.Drawing.Point(108, 81)
        Me.cboOptions.Name = "cboOptions"
        Me.cboOptions.Size = New System.Drawing.Size(204, 28)
        Me.cboOptions.TabIndex = 6
        '
        'cboSelectionOutcome
        '
        Me.cboSelectionOutcome.FormattingEnabled = True
        Me.cboSelectionOutcome.Location = New System.Drawing.Point(607, 84)
        Me.cboSelectionOutcome.Name = "cboSelectionOutcome"
        Me.cboSelectionOutcome.Size = New System.Drawing.Size(239, 28)
        Me.cboSelectionOutcome.TabIndex = 7
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(108, 139)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(274, 26)
        Me.dtpDate.TabIndex = 8
        '
        'lstDay
        '
        Me.lstDay.FormattingEnabled = True
        Me.lstDay.ItemHeight = 20
        Me.lstDay.Location = New System.Drawing.Point(108, 194)
        Me.lstDay.Name = "lstDay"
        Me.lstDay.Size = New System.Drawing.Size(274, 224)
        Me.lstDay.TabIndex = 9
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(607, 221)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(91, 37)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'frmMDIChild1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 454)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lstDay)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.cboSelectionOutcome)
        Me.Controls.Add(Me.cboOptions)
        Me.Controls.Add(Me.cboDay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Day)
        Me.Name = "frmMDIChild1"
        Me.Text = "frmMDIChild1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Day As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboDay As ComboBox
    Friend WithEvents cboOptions As ComboBox
    Friend WithEvents cboSelectionOutcome As ComboBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents lstDay As ListBox
    Friend WithEvents btnShow As Button
End Class
