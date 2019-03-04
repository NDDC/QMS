<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUser
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateUser))
        Me.rdbMember = New System.Windows.Forms.RadioButton()
        Me.txteadd = New System.Windows.Forms.TextBox()
        Me.rdbAdmin = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtNewP = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnC = New System.Windows.Forms.Button()
        Me.txtUserT = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtUsern = New System.Windows.Forms.TextBox()
        Me.pcberror = New System.Windows.Forms.PictureBox()
        Me.pcbx = New System.Windows.Forms.PictureBox()
        Me.pcbok = New System.Windows.Forms.PictureBox()
        Me.pcbcheck = New System.Windows.Forms.PictureBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.pcberror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdbMember
        '
        Me.rdbMember.AutoSize = True
        Me.rdbMember.BackColor = System.Drawing.Color.Transparent
        Me.rdbMember.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMember.Location = New System.Drawing.Point(460, 58)
        Me.rdbMember.Name = "rdbMember"
        Me.rdbMember.Size = New System.Drawing.Size(80, 28)
        Me.rdbMember.TabIndex = 2
        Me.rdbMember.TabStop = True
        Me.rdbMember.Text = "Guest"
        Me.rdbMember.UseVisualStyleBackColor = False
        '
        'txteadd
        '
        Me.txteadd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteadd.Location = New System.Drawing.Point(205, 221)
        Me.txteadd.Name = "txteadd"
        Me.txteadd.Size = New System.Drawing.Size(414, 26)
        Me.txteadd.TabIndex = 8
        Me.txteadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rdbAdmin
        '
        Me.rdbAdmin.AutoSize = True
        Me.rdbAdmin.BackColor = System.Drawing.Color.Transparent
        Me.rdbAdmin.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAdmin.Location = New System.Drawing.Point(282, 58)
        Me.rdbAdmin.Name = "rdbAdmin"
        Me.rdbAdmin.Size = New System.Drawing.Size(87, 28)
        Me.rdbAdmin.TabIndex = 1
        Me.rdbAdmin.TabStop = True
        Me.rdbAdmin.Text = "Admin"
        Me.rdbAdmin.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 22)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Email Address:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 22)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "User Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 22)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "User Type:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConfirm.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.Location = New System.Drawing.Point(448, 336)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(120, 47)
        Me.btnConfirm.TabIndex = 12
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(135, 336)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 47)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(205, 285)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(414, 26)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNewP
        '
        Me.txtNewP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewP.Location = New System.Drawing.Point(205, 253)
        Me.txtNewP.Name = "txtNewP"
        Me.txtNewP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewP.Size = New System.Drawing.Size(414, 26)
        Me.txtNewP.TabIndex = 9
        Me.txtNewP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(205, 157)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(414, 26)
        Me.txtAdd.TabIndex = 6
        Me.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(205, 125)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(414, 26)
        Me.txtName.TabIndex = 5
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 286)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(168, 22)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Confirm Password:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(217, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(274, 31)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Create a New Account"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(34, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 22)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Password:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 22)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Address:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 22)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Full Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Transparent
        Me.btnC.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(625, 94)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(58, 26)
        Me.btnC.TabIndex = 4
        Me.btnC.Text = "Check"
        Me.ToolTip1.SetToolTip(Me.btnC, "Check User Name if Available")
        Me.btnC.UseVisualStyleBackColor = False
        '
        'txtUserT
        '
        Me.txtUserT.Location = New System.Drawing.Point(724, 531)
        Me.txtUserT.Name = "txtUserT"
        Me.txtUserT.ReadOnly = True
        Me.txtUserT.Size = New System.Drawing.Size(17, 20)
        Me.txtUserT.TabIndex = 92
        Me.txtUserT.TabStop = False
        Me.txtUserT.Visible = False
        '
        'txtUsern
        '
        Me.txtUsern.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsern.Location = New System.Drawing.Point(205, 93)
        Me.txtUsern.Name = "txtUsern"
        Me.txtUsern.Size = New System.Drawing.Size(414, 26)
        Me.txtUsern.TabIndex = 3
        Me.txtUsern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pcberror
        '
        Me.pcberror.BackColor = System.Drawing.Color.Transparent
        Me.pcberror.Image = Global.QMS.My.Resources.Resources.iconX
        Me.pcberror.Location = New System.Drawing.Point(624, 285)
        Me.pcberror.Name = "pcberror"
        Me.pcberror.Size = New System.Drawing.Size(35, 26)
        Me.pcberror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcberror.TabIndex = 96
        Me.pcberror.TabStop = False
        '
        'pcbx
        '
        Me.pcbx.BackColor = System.Drawing.Color.Transparent
        Me.pcbx.Image = Global.QMS.My.Resources.Resources.minus
        Me.pcbx.Location = New System.Drawing.Point(625, 94)
        Me.pcbx.Name = "pcbx"
        Me.pcbx.Size = New System.Drawing.Size(35, 26)
        Me.pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbx.TabIndex = 95
        Me.pcbx.TabStop = False
        '
        'pcbok
        '
        Me.pcbok.BackColor = System.Drawing.Color.Transparent
        Me.pcbok.Image = Global.QMS.My.Resources.Resources.ok1
        Me.pcbok.Location = New System.Drawing.Point(625, 94)
        Me.pcbok.Name = "pcbok"
        Me.pcbok.Size = New System.Drawing.Size(35, 26)
        Me.pcbok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbok.TabIndex = 94
        Me.pcbok.TabStop = False
        '
        'pcbcheck
        '
        Me.pcbcheck.BackColor = System.Drawing.Color.Transparent
        Me.pcbcheck.Image = Global.QMS.My.Resources.Resources.Check1
        Me.pcbcheck.Location = New System.Drawing.Point(624, 286)
        Me.pcbcheck.Name = "pcbcheck"
        Me.pcbcheck.Size = New System.Drawing.Size(35, 26)
        Me.pcbcheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbcheck.TabIndex = 93
        Me.pcbcheck.TabStop = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(753, 518)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 97
        Me.lblDate.Text = "Label2"
        Me.lblDate.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(747, 531)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(45, 13)
        Me.lblTime.TabIndex = 98
        Me.lblTime.Text = "Label10"
        Me.lblTime.Visible = False
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(205, 189)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(414, 26)
        Me.txtContact.TabIndex = 7
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 22)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Contact Number:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CreateUser
        '
        Me.AcceptButton = Me.btnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnConfirm
        Me.ClientSize = New System.Drawing.Size(698, 400)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.txtUsern)
        Me.Controls.Add(Me.pcberror)
        Me.Controls.Add(Me.pcbx)
        Me.Controls.Add(Me.pcbok)
        Me.Controls.Add(Me.pcbcheck)
        Me.Controls.Add(Me.txtUserT)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.rdbMember)
        Me.Controls.Add(Me.txteadd)
        Me.Controls.Add(Me.rdbAdmin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtNewP)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CreateUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New User Account"
        CType(Me.pcberror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdbMember As System.Windows.Forms.RadioButton
    Friend WithEvents txteadd As System.Windows.Forms.TextBox
    Friend WithEvents rdbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnConfirm As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewP As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnC As System.Windows.Forms.Button
    Friend WithEvents txtUserT As System.Windows.Forms.TextBox
    Friend WithEvents pcbcheck As System.Windows.Forms.PictureBox
    Friend WithEvents pcbok As System.Windows.Forms.PictureBox
    Friend WithEvents pcbx As System.Windows.Forms.PictureBox
    Friend WithEvents pcberror As System.Windows.Forms.PictureBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents UsersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserPassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailAddDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtUsern As System.Windows.Forms.TextBox
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
