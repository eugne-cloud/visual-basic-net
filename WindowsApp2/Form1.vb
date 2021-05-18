Public Class Form1
    Private Sub btnAnalyzeName_Click(sender As Object, e As EventArgs) Handles btnAnalyzeName.Click
        Dim strFullName, strFirstName, strLastName As String

        Dim intNum As Integer 'location oof the space seperating the two 

        strFullName = txtName.Text
        intNum = strFullName.IndexOf("")
        strFirstName = strFullName.Substring(0, intNum)
        strLastName = strFullName.Substring(intNum + 1)
        'display the information in a list box
        lstResults.Items.Clear()
        lstResults.Items.Add("First Name: " & strFirstName)
        lstResults.Items.Add("Your last Name has" & strLastName.Length & "letters.")


    End Sub
End Class
