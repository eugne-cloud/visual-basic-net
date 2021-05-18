Public Class frmDoLoop
    Private Sub btnChooseYourMeal_Click(sender As Object, e As EventArgs) Handles btnChooseYourMeal.Click
        Dim intResponse As Integer = 0, strSelection As String = ""

        Do While (intResponse < 1) Or (intResponse > 3)
            intResponse = CInt(InputBox("Enter a number from 1 to 3."))
        Loop

        Select Case intResponse
            Case 1
                strSelection = "Breakfast"
            Case 2
                strSelection = "Lunch"
            Case 3
                strSelection = "Dinner"
        End Select

        txtSelection.Text = strSelection
    End Sub
End Class