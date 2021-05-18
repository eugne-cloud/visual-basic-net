<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.lblFirstNumber = New System.Windows.Forms.Label()
        Me.lblSecondNumber = New System.Windows.Forms.Label()
        Me.txtFirstNumber1 = New System.Windows.Forms.TextBox()
        Me.txtSecondNumber2 = New System.Windows.Forms.TextBox()
        Me.btnFindLargestNumber = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.lblRichTxtBox = New System.Windows.Forms.Label()
        Me.rtbMessage = New System.Windows.Forms.RichTextBox()
        Me.btnBlackColor = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnFont = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.groupbox.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFirstNumber
        '
        Me.lblFirstNumber.AutoSize = True
        Me.lblFirstNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNumber.Location = New System.Drawing.Point(99, 84)
        Me.lblFirstNumber.Name = "lblFirstNumber"
        Me.lblFirstNumber.Size = New System.Drawing.Size(112, 20)
        Me.lblFirstNumber.TabIndex = 0
        Me.lblFirstNumber.Text = "First Number"
        '
        'lblSecondNumber
        '
        Me.lblSecondNumber.AutoSize = True
        Me.lblSecondNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondNumber.Location = New System.Drawing.Point(99, 161)
        Me.lblSecondNumber.Name = "lblSecondNumber"
        Me.lblSecondNumber.Size = New System.Drawing.Size(137, 20)
        Me.lblSecondNumber.TabIndex = 1
        Me.lblSecondNumber.Text = "Second Number"
        '
        'txtFirstNumber1
        '
        Me.txtFirstNumber1.Location = New System.Drawing.Point(250, 84)
        Me.txtFirstNumber1.Name = "txtFirstNumber1"
        Me.txtFirstNumber1.Size = New System.Drawing.Size(100, 26)
        Me.txtFirstNumber1.TabIndex = 2
        '
        'txtSecondNumber2
        '
        Me.txtSecondNumber2.Location = New System.Drawing.Point(250, 161)
        Me.txtSecondNumber2.Name = "txtSecondNumber2"
        Me.txtSecondNumber2.Size = New System.Drawing.Size(100, 26)
        Me.txtSecondNumber2.TabIndex = 3
        '
        'btnFindLargestNumber
        '
        Me.btnFindLargestNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindLargestNumber.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnFindLargestNumber.Location = New System.Drawing.Point(103, 255)
        Me.btnFindLargestNumber.Name = "btnFindLargestNumber"
        Me.btnFindLargestNumber.Size = New System.Drawing.Size(329, 49)
        Me.btnFindLargestNumber.TabIndex = 4
        Me.btnFindLargestNumber.Text = "Find Largest Number"
        Me.btnFindLargestNumber.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(97, 341)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(109, 32)
        Me.lblOutput.TabIndex = 6
        Me.lblOutput.Text = "Output"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 33)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1225, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.UseWaitCursor = True
        '
        'groupbox
        '
        Me.groupbox.Controls.Add(Me.lblRichTxtBox)
        Me.groupbox.Controls.Add(Me.rtbMessage)
        Me.groupbox.Controls.Add(Me.btnBlackColor)
        Me.groupbox.Controls.Add(Me.btnColor)
        Me.groupbox.Controls.Add(Me.btnFont)
        Me.groupbox.Controls.Add(Me.btnSave)
        Me.groupbox.Controls.Add(Me.btnBrowse)
        Me.groupbox.Location = New System.Drawing.Point(473, 27)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(709, 330)
        Me.groupbox.TabIndex = 9
        Me.groupbox.TabStop = False
        Me.groupbox.UseWaitCursor = True
        '
        'lblRichTxtBox
        '
        Me.lblRichTxtBox.AutoSize = True
        Me.lblRichTxtBox.Location = New System.Drawing.Point(11, 36)
        Me.lblRichTxtBox.Name = "lblRichTxtBox"
        Me.lblRichTxtBox.Size = New System.Drawing.Size(106, 20)
        Me.lblRichTxtBox.TabIndex = 10
        Me.lblRichTxtBox.Text = "Rich Text Box"
        '
        'rtbMessage
        '
        Me.rtbMessage.ContextMenuStrip = Me.ContextMenuStrip3
        Me.rtbMessage.Location = New System.Drawing.Point(47, 71)
        Me.rtbMessage.Name = "rtbMessage"
        Me.rtbMessage.Size = New System.Drawing.Size(621, 156)
        Me.rtbMessage.TabIndex = 9
        Me.rtbMessage.Text = ""
        Me.rtbMessage.UseWaitCursor = True
        '
        'btnBlackColor
        '
        Me.btnBlackColor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBlackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlackColor.Location = New System.Drawing.Point(556, 244)
        Me.btnBlackColor.Name = "btnBlackColor"
        Me.btnBlackColor.Size = New System.Drawing.Size(112, 54)
        Me.btnBlackColor.TabIndex = 4
        Me.btnBlackColor.Text = "Black Color"
        Me.btnBlackColor.UseVisualStyleBackColor = False
        '
        'btnColor
        '
        Me.btnColor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnColor.Location = New System.Drawing.Point(420, 246)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(96, 50)
        Me.btnColor.TabIndex = 3
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = False
        '
        'btnFont
        '
        Me.btnFont.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnFont.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFont.Location = New System.Drawing.Point(296, 246)
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(94, 50)
        Me.btnFont.TabIndex = 2
        Me.btnFont.Text = "Font"
        Me.btnFont.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(174, 246)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 50)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.Location = New System.Drawing.Point(47, 246)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(100, 50)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1225, 33)
        Me.MenuStrip2.TabIndex = 10
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuOpen, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(54, 29)
        Me.mnuFile.Text = "File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.mnuOpen.Size = New System.Drawing.Size(270, 34)
        Me.mnuOpen.Text = "Open"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(270, 34)
        Me.mnuExit.Text = "Exit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuPaste, Me.mnuCut})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(58, 29)
        Me.mnuEdit.Text = "Edit"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(270, 34)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.mnuPaste.Size = New System.Drawing.Size(270, 34)
        Me.mnuPaste.Text = "Paste"
        '
        'mnuCut
        '
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(270, 34)
        Me.mnuCut.Text = "Cut"
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.CutToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(127, 100)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(126, 32)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(126, 32)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(126, 32)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1225, 404)
        Me.ContextMenuStrip = Me.ContextMenuStrip3
        Me.Controls.Add(Me.groupbox)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnFindLargestNumber)
        Me.Controls.Add(Me.txtSecondNumber2)
        Me.Controls.Add(Me.txtFirstNumber1)
        Me.Controls.Add(Me.lblSecondNumber)
        Me.Controls.Add(Me.lblFirstNumber)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.UseWaitCursor = True
        Me.groupbox.ResumeLayout(False)
        Me.groupbox.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstNumber As Label
    Friend WithEvents lblSecondNumber As Label
    Friend WithEvents txtFirstNumber1 As TextBox
    Friend WithEvents txtSecondNumber2 As TextBox
    Friend WithEvents btnFindLargestNumber As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents groupbox As GroupBox
    Friend WithEvents btnBlackColor As Button
    Friend WithEvents btnColor As Button
    Friend WithEvents btnFont As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents lblRichTxtBox As Label
    Friend WithEvents rtbMessage As RichTextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip3 As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
End Class
