﻿Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Dim name As String
    Dim age As String
    Dim contact As String


    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        name = txtName.Text
        age = txtAge.Text
        contact = txtCtc.Text
        MessageBox.Show("Hello," + name + "you are" + age + "years old. I can contact you at" + contact)
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Application.ExitThread()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
