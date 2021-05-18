Public Class Form1
    Private Sub BtnShowMessage_Click(sender As Object, e As EventArgs) Handles btnShowMessage.Click
        If Windows.Forms.MessageBox.Show("Do you want to make any orders??", "food order!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Windows.Forms.MessageBox.Show("Yes!", "Reply")
        Else
            Windows.Forms.MessageBox.Show("No!", "Reply")
        End If
    End Sub

    Private Sub btnShowMessage1_Click(sender As Object, e As EventArgs) Handles btnShowMessage1.Click
        If txtPassword.Text = "" Or txtSecondPassword.Text = "" Then
            Windows.Forms.MessageBox.Show("You did not fill in the fields!")
        End If

        If txtPassword.Text = "thepassword" And "txtSecondPassword.Text" Then
            Me.Show()
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
