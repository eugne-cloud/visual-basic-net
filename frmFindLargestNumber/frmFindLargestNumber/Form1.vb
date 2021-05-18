Public Class Form1

    Private Sub btnFindLargestNumber_Click(sender As Object, e As EventArgs) Handles btnFindLargestNumber.Click
        If txtFirstNumber1.Text > txtSecondNumber2.Text Then
            lblOutput.Text = txtFirstNumber1.Text & "is greater than" & txtSecondNumber2.Text
        End If
        If txtFirstNumber1.Text < txtSecondNumber2.Text Then
            lblOutput.Text = txtSecondNumber2.Text & "is greater than" & txtFirstNumber1.Text
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If rtbMessage.Text.Length <> 0 Then
            If MsgBox("Save File?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    rtbMessage.SaveFile(SaveFileDialog1.FileName)
                End If
            Else
                'rtbMessage.Clear()
            End If
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtbMessage.LoadFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtbMessage.SelectionFont = FontDialog1.Font
        End If
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtbMessage.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btnBlackColor_Click(sender As Object, e As EventArgs) Handles btnBlackColor.Click
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            rtbMessage.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        rtbMessage.Copy()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        rtbMessage.Paste()
    End Sub

    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub cmnuCopy_Click(sender As Object, e As EventArgs)
        mnuCopy.PerformClick()
    End Sub

    Private Sub cmnuPaste_Click(sender As Object, e As EventArgs)
        mnuPaste.PerformClick()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ContextMenuStrip3_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip3.Opening

    End Sub
End Class
