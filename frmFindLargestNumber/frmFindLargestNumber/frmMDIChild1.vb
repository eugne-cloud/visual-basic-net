Public Class frmMDIChild1
    Private Sub frmMDIChild1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDays()
        cboDay.SelectedItem = cboDay.Items(0)
        cboDay.DropDownStyle = ComboBoxStyle.DropDownList

        DisplayDays()
        lstDay.SelectionMode = SelectionMode.MultiSimple

       Sub SetDefaultDate()
        dtpDate.Format = DateTimePicker.Long
        'Day Month Year
        dtpDate.Value = "05/02/2020"
    End Sub

    Public Sub Dim() obj As Object
        For Each obj In lstDay.SelectedItems
            MessageBox.Show("Selected day is: " & obj.ToString, "User Selection", MessageBoxButtons.OK, MessageBoxIcon)
        Next

    End Sub

    Private Sub cboDay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDay.SelectedIndexChanged

    End Sub

    'load the days
    Sub LoadDays()
        cboDay.Items.Add("Sunday")
        cboDay.Items.Add("Monday")
        cboDay.Items.Add("Tuesday")
        cboDay.Items.Add("Wednesday")
        cboDay.Items.Add("Friday")
        cboDay.Items.Add("Saturday")

        'With cboDay
        '    .Items.Add("Sunday")
        '    .Items.Add("Monday")
        '    .Items.Add("Tuesday")
        '    .Items.Add("Wednesday")
        '    .Items.Add("Friday")
        '    .Items.Add("Saturday")
        'End With
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim strChoice As String
        strChoice = cboDay.Text
        MessageBox.Show("Selected Day Is: " + strChoice, "User Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub cboOptions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOptions.SelectedIndexChanged
        cboSelectionOutcome.Items.Clear()
        If cboOptions.SelectedItem = "Weekdays" Then
            cboSelectionOutcome.Items.Add("Sunday")
            cboSelectionOutcome.Items.Add("Monday")
            cboSelectionOutcome.Items.Add("Tuesday")
            cboSelectionOutcome.Items.Add("Wednesday")
            cboSelectionOutcome.Items.Add("Thursday")
            cboSelectionOutcome.Items.Add("Friday")
            cboSelectionOutcome.Items.Add("Saturday")

        ElseIf cboOptions.SelectedItem = "Year" Then
            cboSelectionOutcome.Items.Add("2019")
            cboSelectionOutcome.Items.Add("2020")
            cboSelectionOutcome.Items.Add("2021")
        End If
    End Sub
     