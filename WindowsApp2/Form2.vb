Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strCountries() As String = {"Malaysia", "United States", "Canada"}

        lstCountryName.DataSource = strCountries
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If lstCountryName.SelectedItem = "MALAYSIA" Then
            picFlag.Image = Image.FromFile("C:\Users\Acer\Desktop\D-CS 2020\JAN2020_LECTURES\VB.NET\WindowsApp2\MAS.jpg")
        ElseIf lstCountryName.SelectedItem = "CANADA" Then
            picFlag.Image = Image.FromFile("C:\Users\Acer\Desktop\D-CS 2020\JAN2020_LECTURES\VB.NET\WindowsApp2\CAN.jpg")
        ElseIf lstCountryName.SelectedItem = "UNITED STATES" Then
            picFlag.Image = Image.FromFile("C:\Users\Acer\Desktop\D-CS 2020\JAN2020_LECTURES\VB.NET\WindowsApp2\USA.jpg")
        Else
            MessageBox.Show("Please Select A Country!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
End Class