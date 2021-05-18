Imports System.Data
Imports System.Data.SqlClient



Public Class frmCustomerProfile
    Private Sub frmCustomerProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadState()
    End Sub

    Sub LoadState()
        Dim strConnectionString As String
        Dim sqlConn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim intRecCount As Integer
        Dim strSql As String

        'Using Own Laptop
        strConnectionString = "Data Source=LAPTOP-52IBVO0Q\EUGNESERVER;Initial Catalog=VBApp;Integrated Security = True"
        strSql = "Select StateName from State"


        sqlConn = New SqlConnection(strConnectionString)
        Try
            sqlConn.Open()
            sqlCmd = New SqlCommand(strSql, sqlConn)
            adapter.SelectCommand = sqlCmd
            adapter.Fill(ds)


            intRecCount = ds.Tables(0).Rows.Count
            For intRecCount = 0 To ds.Tables(0).Rows.Count - 1
                cboState.Items.Add(ds.Tables(0).Rows(intRecCount).Item(0))

            Next

        Catch ex As Exception
            MessageBox.Show("Cannot Open Connection")
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strConnectionString As String
        Dim sqlConn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        strConnectionString = "Data Source=LAPTOP-52IBVO0Q\EUGNESERVER;Initial Catalog=VBApp;Integrated Security = True"

        strSql = "Insert Into Customer ([CustomerID],[CustomerName],[CustomerAge],[CustomerState])
                  values('" & txtCustomerID.Text & "', '" & txtName.Text & "','" & txtAge.Text & "','" & cboState.Text & "')"

        sqlConn = New SqlConnection(strConnectionString)
        Try
            sqlConn.Open()
            sqlCmd = New SqlCommand(strSql, sqlConn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlConn.Close()
            MessageBox.Show("Record is successfully added!")

        Catch ex As Exception
            MessageBox.Show("Cannot open connection!")
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim strConnectionString As String
        Dim sqlConn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        strConnectionString = "Data Source=LAPTOP-52IBVO0Q\EUGNESERVER;Initial Catalog=VBApp;Integrated Security = True"

        strSql = "Update Customer Set CustomerName= '" & txtCustomerID.Text & "'
                Where CustomerId= '" & txtCustomerID.Text & "'"
        sqlConn = New SqlConnection(strConnectionString)
        Try
            sqlConn.Open()
            sqlCmd = New SqlCommand(strSql, sqlConn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlConn.Close()
            MessageBox.Show("Record Updated!")
        Catch ex As Exception
            MessageBox.Show("Cannot Open Connection!")
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strConnectionString As String
        Dim sqlConn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        strConnectionString = "Data Source=LAPTOP-52IBVO0Q\EUGNESERVER;Initial Catalog=VBApp;Integrated Security = True"

        strSql = "Delete from Customer where CustomerId='" & txtCustomerID.Text & "'"
        sqlConn = New SqlConnection(strConnectionString)
        Try
            sqlConn.Open()
            sqlCmd = New SqlCommand(strSql, sqlConn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            sqlConn.Close()
            MessageBox.Show("Record is successfully removed !")

        Catch ex As Exception
            MessageBox.Show("Cannot Open Connection!")
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim strConnectionString As String
        Dim sqlConn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim strSql As String

        strConnectionString = "Data Source=LAPTOP-52IBVO0Q\EUGNESERVER;Initial Catalog=VBApp;Integrated Security = True"
        Display()
    End Sub

    Sub Display()
        'pulling data from Sql Server
        Dim strConnectionString As String
        Dim sqlConn As SqlConnection
        Dim sqlCmd As SqlCommand
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String

        strConnectionString = "Data Source=LAPTOP-52IBVO0Q\EUGNESERVER;Initial Catalog=VBApp;Integrated Security = True"

        strSql = "Select *from Customer"
        sqlConn = New SqlConnection(strConnectionString)

        'adding columns to our list view
        With lstvCustomerDt.Columns
            .Add("Customer ID", 100)
            .Add("Customer Name", 200)
            .Add("Customer Age", 100)
            .Add("City", 200)
        End With

        Try
            sqlConn.Open()
            sqlCmd = New SqlCommand(strSql, sqlConn)
            adapter.SelectCommand = sqlCmd
            adapter.Fill(dt)

            Dim newrow As DataRow
            For Each newrow In dt.Rows
                'display results
                With lstvCustomerDt
                    .Items.Add(newrow.Item(0))
                    .Items(lstvCustomerDt.Items.Count - 1).SubItems.Add(newrow.Item(1))
                    .Items(lstvCustomerDt.Items.Count - 1).SubItems.Add(newrow.Item(2))
                    .Items(lstvCustomerDt.Items.Count - 1).SubItems.Add(newrow.Item(3))

                End With
            Next

        Catch ex As Exception
            MessageBox.Show(("Cannot open connection!"))

        End Try
    End Sub

    Private Sub lstvCustomerDt_DoubleClick(sender As Object, e As EventArgs) Handles lstvCustomerDt.DoubleClick
        If Me.lstvCustomerDt.SelectedItems.Count > 0 Then
            Dim lstv As ListViewItem = Me.lstvCustomerDt.SelectedItems(0)

            txtCustomerID.Text = lstv.SubItems(0).Text
            txtName.Text = lstv.SubItems(1).Text
            txtAge.Text = lstv.SubItems(2).Text
            cboState.Text = lstv.SubItems(3).Text

        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPrintReport.Show()
    End Sub

    Private Sub txtCUstomerID2_TextChanged(sender As Object, e As EventArgs) Handles txtCUstomerID2.TextChanged

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
