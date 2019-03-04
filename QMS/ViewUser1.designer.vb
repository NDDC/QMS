<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewUser1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewUser1))
        Me.rdbGuest = New System.Windows.Forms.RadioButton()
        Me.txteadd = New System.Windows.Forms.TextBox()
        Me.rdbAdmin = New System.Windows.Forms.RadioButton()
        Me.lblEadd = New System.Windows.Forms.Label()
        Me.txtUsern = New System.Windows.Forms.TextBox()
        Me.lbluserN = New System.Windows.Forms.Label()
        Me.lblUserT = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtUserT = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.btnCancelUpdate = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblMemberID = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchN = New System.Windows.Forms.Button()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cmbSType = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbSearch1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbGuest
        '
        Me.rdbGuest.AutoSize = True
        Me.rdbGuest.BackColor = System.Drawing.Color.Transparent
        Me.rdbGuest.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbGuest.Location = New System.Drawing.Point(327, 227)
        Me.rdbGuest.Name = "rdbGuest"
        Me.rdbGuest.Size = New System.Drawing.Size(67, 23)
        Me.rdbGuest.TabIndex = 6
        Me.rdbGuest.TabStop = True
        Me.rdbGuest.Text = "Guest"
        Me.rdbGuest.UseVisualStyleBackColor = False
        '
        'txteadd
        '
        Me.txteadd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteadd.Location = New System.Drawing.Point(174, 397)
        Me.txteadd.Name = "txteadd"
        Me.txteadd.Size = New System.Drawing.Size(277, 22)
        Me.txteadd.TabIndex = 10
        Me.txteadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdbAdmin
        '
        Me.rdbAdmin.AutoSize = True
        Me.rdbAdmin.BackColor = System.Drawing.Color.Transparent
        Me.rdbAdmin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAdmin.Location = New System.Drawing.Point(215, 227)
        Me.rdbAdmin.Name = "rdbAdmin"
        Me.rdbAdmin.Size = New System.Drawing.Size(70, 23)
        Me.rdbAdmin.TabIndex = 2
        Me.rdbAdmin.TabStop = True
        Me.rdbAdmin.Text = "Admin"
        Me.rdbAdmin.UseVisualStyleBackColor = False
        '
        'lblEadd
        '
        Me.lblEadd.AutoSize = True
        Me.lblEadd.BackColor = System.Drawing.Color.Transparent
        Me.lblEadd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEadd.Location = New System.Drawing.Point(34, 400)
        Me.lblEadd.Name = "lblEadd"
        Me.lblEadd.Size = New System.Drawing.Size(110, 19)
        Me.lblEadd.TabIndex = 102
        Me.lblEadd.Text = "Email Address:"
        Me.lblEadd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsern
        '
        Me.txtUsern.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsern.Location = New System.Drawing.Point(174, 282)
        Me.txtUsern.Name = "txtUsern"
        Me.txtUsern.Size = New System.Drawing.Size(277, 22)
        Me.txtUsern.TabIndex = 5
        Me.txtUsern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbluserN
        '
        Me.lbluserN.AutoSize = True
        Me.lbluserN.BackColor = System.Drawing.Color.Transparent
        Me.lbluserN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluserN.Location = New System.Drawing.Point(34, 285)
        Me.lbluserN.Name = "lbluserN"
        Me.lbluserN.Size = New System.Drawing.Size(90, 19)
        Me.lbluserN.TabIndex = 101
        Me.lbluserN.Text = "User Name:"
        Me.lbluserN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUserT
        '
        Me.lblUserT.AutoSize = True
        Me.lblUserT.BackColor = System.Drawing.Color.Transparent
        Me.lblUserT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserT.Location = New System.Drawing.Point(34, 231)
        Me.lblUserT.Name = "lblUserT"
        Me.lblUserT.Size = New System.Drawing.Size(83, 19)
        Me.lblUserT.TabIndex = 100
        Me.lblUserT.Text = "User Type:"
        Me.lblUserT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(174, 425)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(277, 22)
        Me.txtPass.TabIndex = 11
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(174, 338)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(277, 22)
        Me.txtAdd.TabIndex = 7
        Me.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(174, 310)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(277, 22)
        Me.txtName.TabIndex = 6
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.BackColor = System.Drawing.Color.Transparent
        Me.lblPass.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(34, 428)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(77, 19)
        Me.lblPass.TabIndex = 98
        Me.lblPass.Text = "Password:"
        Me.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.BackColor = System.Drawing.Color.Transparent
        Me.lblAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(34, 341)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(69, 19)
        Me.lblAdd.TabIndex = 97
        Me.lblAdd.Text = "Address:"
        Me.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(34, 313)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 19)
        Me.lblName.TabIndex = 96
        Me.lblName.Text = "Full Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.Control
        Me.btnBack.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(621, 418)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(118, 38)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btnEdit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(472, 278)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(118, 38)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "EDIT Account"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(472, 222)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 38)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DELETE Account"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'txtUserT
        '
        Me.txtUserT.Location = New System.Drawing.Point(781, 310)
        Me.txtUserT.Name = "txtUserT"
        Me.txtUserT.ReadOnly = True
        Me.txtUserT.Size = New System.Drawing.Size(20, 20)
        Me.txtUserT.TabIndex = 107
        Me.txtUserT.TabStop = False
        Me.txtUserT.Visible = False
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(174, 256)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(277, 20)
        Me.txtUserID.TabIndex = 4
        Me.txtUserID.TabStop = False
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancelUpdate
        '
        Me.btnCancelUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancelUpdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelUpdate.Location = New System.Drawing.Point(472, 397)
        Me.btnCancelUpdate.Name = "btnCancelUpdate"
        Me.btnCancelUpdate.Size = New System.Drawing.Size(118, 38)
        Me.btnCancelUpdate.TabIndex = 15
        Me.btnCancelUpdate.Text = "Cancel Update"
        Me.btnCancelUpdate.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(472, 341)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 38)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "UPDATE Account"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(14, 48)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(745, 147)
        Me.DataGridView1.TabIndex = 1
        '
        'lblMemberID
        '
        Me.lblMemberID.AutoSize = True
        Me.lblMemberID.BackColor = System.Drawing.Color.Transparent
        Me.lblMemberID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMemberID.Location = New System.Drawing.Point(34, 257)
        Me.lblMemberID.Name = "lblMemberID"
        Me.lblMemberID.Size = New System.Drawing.Size(68, 19)
        Me.lblMemberID.TabIndex = 121
        Me.lblMemberID.Text = "User ID:"
        Me.lblMemberID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(174, 366)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(277, 22)
        Me.txtContact.TabIndex = 8
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 19)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "Contact Number:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSearchN
        '
        Me.btnSearchN.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearchN.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchN.Location = New System.Drawing.Point(621, 368)
        Me.btnSearchN.Name = "btnSearchN"
        Me.btnSearchN.Size = New System.Drawing.Size(118, 38)
        Me.btnSearchN.TabIndex = 19
        Me.btnSearchN.Text = "Search"
        Me.btnSearchN.UseVisualStyleBackColor = False
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(610, 336)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(134, 21)
        Me.cmbSearch.TabIndex = 18
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(621, 256)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(118, 38)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cmbSType
        '
        Me.cmbSType.Items.AddRange(New Object() {"User ID", "User Type", "User Name", "Full Name"})
        Me.cmbSType.Location = New System.Drawing.Point(610, 300)
        Me.cmbSType.Name = "cmbSType"
        Me.cmbSType.Size = New System.Drawing.Size(134, 21)
        Me.cmbSType.TabIndex = 17
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(621, 212)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(118, 38)
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(286, 36)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "View Users Account"
        '
        'cmbSearch1
        '
        Me.cmbSearch1.FormattingEnabled = True
        Me.cmbSearch1.Items.AddRange(New Object() {"Admin", "Guest"})
        Me.cmbSearch1.Location = New System.Drawing.Point(610, 336)
        Me.cmbSearch1.Name = "cmbSearch1"
        Me.cmbSearch1.Size = New System.Drawing.Size(134, 21)
        Me.cmbSearch1.TabIndex = 127
        '
        'ViewUser1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(771, 466)
        Me.Controls.Add(Me.cmbSearch1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSearchN)
        Me.Controls.Add(Me.cmbSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cmbSType)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMemberID)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnCancelUpdate)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.txtUserT)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rdbGuest)
        Me.Controls.Add(Me.txteadd)
        Me.Controls.Add(Me.rdbAdmin)
        Me.Controls.Add(Me.lblEadd)
        Me.Controls.Add(Me.txtUsern)
        Me.Controls.Add(Me.lbluserN)
        Me.Controls.Add(Me.lblUserT)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ViewUser1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Users"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbGuest As System.Windows.Forms.RadioButton
    Friend WithEvents txteadd As System.Windows.Forms.TextBox
    Friend WithEvents rdbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents lblEadd As System.Windows.Forms.Label
    Friend WithEvents txtUsern As System.Windows.Forms.TextBox
    Friend WithEvents lbluserN As System.Windows.Forms.Label
    Friend WithEvents lblUserT As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents lblAdd As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtUserT As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelUpdate As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserPassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblMemberID As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearchN As System.Windows.Forms.Button
    Friend WithEvents cmbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbSType As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSearch1 As System.Windows.Forms.ComboBox
 
End Class
