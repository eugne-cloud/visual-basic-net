﻿Public Class frmNoOfDays

    Private Sub btnDetDays_Click(sender As Object, e As EventArgs) Handles btnDetDays.Click
        Dim strSelection As String = ""
        Dim strOutput As String = lblOutput2.Text

        Select Case strSelection
            Case 1
                strSelection = "January"
                strOutput = 31
            Case 2
                strSelection = "February"
                strOutput = 30
            Case 3
                strSelection = "March"
                strOutput = 31
            Case 4
                strSelection = "April"
                strOutput = 30
            Case 5
                strSelection = "May"
                strOutput = 31
            Case 6
                strSelection = "June"
                strOutput = 30
            Case 7
                strSelection = "July"
                strOutput = 31
            Case 8
                strSelection = "August"
                strOutput = 30
            Case 9
                strSelection = "September"
                strOutput = 31
            Case 10
                strSelection = "October"
                strOutput = 30
            Case 11
                strSelection = "November"
                strOutput = 31
            Case 12
                strSelection = "December"
                strOutput = 31
        End Select

        lblOutput2.Text = strOutput
    End Sub
End Class



