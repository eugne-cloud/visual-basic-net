<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_CustomerID = New System.Windows.Forms.Label()
        Me.txtCustomerID = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.cboState = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.txtCUstomerID2 = New System.Windows.Forms.TextBox()
        Me.lblCustomerID = New System.Windows.Forms.Label()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.lstvCustomerDt = New System.Windows.Forms.ListView()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grpCustomerDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_CustomerID
        '
        Me.lbl_CustomerID.AutoSize = True
        Me.lbl_CustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CustomerID.Location = New System.Drawing.Point(96, -56)
        Me.lbl_CustomerID.Name = "lbl_CustomerID"
        Me.lbl_CustomerID.Size = New System.Drawing.Size(110, 20)
        Me.lbl_CustomerID.TabIndex = 0
        Me.lbl_CustomerID.Text = "Customer ID"
        '
        'txtCustomerID
        '
        Me.txtCustomerID.Location = New System.Drawing.Point(212, -56)
        Me.txtCustomerID.Name = "txtCustomerID"
        Me.txtCustomerID.Size = New System.Drawing.Size(160, 26)
        Me.txtCustomerID.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(22, 160)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(138, 154)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(274, 26)
        Me.txtName.TabIndex = 3
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(22, 211)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(41, 20)
        Me.lblAge.TabIndex = 4
        Me.lblAge.Text = "Age"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(138, 205)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(164, 26)
        Me.txtAge.TabIndex = 5
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(22, 258)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(53, 20)
        Me.lblState.TabIndex = 6
        Me.lblState.Text = "State"
        '
        'cboState
        '
        Me.cboState.FormattingEnabled = True
        Me.cboState.Location = New System.Drawing.Point(138, 250)
        Me.cboState.Name = "cboState"
        Me.cboState.Size = New System.Drawing.Size(121, 28)
        Me.cboState.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(572, 515)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 37)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(684, 514)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(85, 39)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(798, 515)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 39)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(918, 515)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(92, 39)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(461, 514)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 37)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.Controls.Add(Me.txtCUstomerID2)
        Me.grpCustomerDetails.Controls.Add(Me.lblCustomerID)
        Me.grpCustomerDetails.Controls.Add(Me.txtAge)
        Me.grpCustomerDetails.Controls.Add(Me.lbl_CustomerID)
        Me.grpCustomerDetails.Controls.Add(Me.txtCustomerID)
        Me.grpCustomerDetails.Controls.Add(Me.lblName)
        Me.grpCustomerDetails.Controls.Add(Me.txtName)
        Me.grpCustomerDetails.Controls.Add(Me.lblAge)
        Me.grpCustomerDetails.Controls.Add(Me.cboState)
        Me.grpCustomerDetails.Controls.Add(Me.lblState)
        Me.grpCustomerDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomerDetails.Location = New System.Drawing.Point(28, 12)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Size = New System.Drawing.Size(956, 303)
        Me.grpCustomerDetails.TabIndex = 13
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Text = "Customer Details"
        '
        'txtCUstomerID2
        '
        Me.txtCUstomerID2.Location = New System.Drawing.Point(138, 101)
        Me.txtCUstomerID2.Name = "txtCUstomerID2"
        Me.txtCUstomerID2.Size = New System.Drawing.Size(164, 26)
        Me.txtCUstomerID2.TabIndex = 14
        '
        'lblCustomerID
        '
        Me.lblCustomerID.AutoSize = True
        Me.lblCustomerID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.Location = New System.Drawing.Point(22, 101)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(110, 20)
        Me.lblCustomerID.TabIndex = 13
        Me.lblCustomerID.Text = "Customer ID"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'lstvCustomerDt
        '
        Me.lstvCustomerDt.HideSelection = False
        Me.lstvCustomerDt.Location = New System.Drawing.Point(28, 336)
        Me.lstvCustomerDt.Name = "lstvCustomerDt"
        Me.lstvCustomerDt.Size = New System.Drawing.Size(956, 161)
        Me.lstvCustomerDt.TabIndex = 14
        Me.lstvCustomerDt.UseCompatibleStateImageBehavior = False
        Me.lstvCustomerDt.View = System.Windows.Forms.View.Details
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(28, 517)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(85, 37)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmCustomerProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 739)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.lstvCustomerDt)
        Me.Controls.Add(Me.grpCustomerDetails)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "frmCustomerProfile"
        Me.Text = "Customer Profile"
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.grpCustomerDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_CustomerID As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblState As Label
    Friend WithEvents cboState As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents grpCustomerDetails As GroupBox
    Friend WithEvents txtCUstomerID2 As TextBox
    Friend WithEvents lblCustomerID As Label
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents lstvCustomerDt As ListView
    Friend WithEvents btnPrint As Button
End Class
