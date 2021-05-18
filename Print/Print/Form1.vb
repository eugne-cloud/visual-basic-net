Public Class frmPrintDoc
    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        Dim FILE_NAME As String = "C:\Users\Acer\Desktop\D-CS 2020\JAN2020_LECTURES\VB.NET\Print"

        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME)

            objWriter.Write(txtInput.Text)
            objWriter.Close()
            MessageBox.Show("Text Written to File")
        Else
            MessageBox.Show("File Does Not Exist!")
        End If
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim FILE_NAME As String = "C:\Users\Acer\Desktop\D-CS 2020\JAN2020_LECTURES\VB.NET\Print\Test.txt"

        Dim TextLine As String

        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)

            Do While objReader.Peek() <> -1
                TextLine = TextLine & objReader.ReadLine() & vbNewLine
            Loop

            txtOutput.Text = TextLine
        Else
            MessageBox.Show("File Does Not Exist!!")
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.AllowSomePages = True

        Try
            If PrintDialog1.ShowDialog = DialogResult.OK Then
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
                PrintDocument1.Print()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub
End Class
