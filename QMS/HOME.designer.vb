<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOME
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HOME))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtUT = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.lblDue = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.txtMS = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txteadd = New System.Windows.Forms.TextBox()
        Me.txtUsern = New System.Windows.Forms.TextBox()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtEDate = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtDManu = New System.Windows.Forms.TextBox()
        Me.txtManu = New System.Windows.Forms.TextBox()
        Me.txtIName = New System.Windows.Forms.TextBox()
        Me.txtICode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateNewUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ViewAccountToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1135, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 537)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1135, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 164)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 70
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1111, 355)
        Me.DataGridView1.TabIndex = 9
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.SystemColors.Control
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(999, 121)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(124, 37)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtStatus)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.txtEDate)
        Me.Panel1.Controls.Add(Me.txtType)
        Me.Panel1.Controls.Add(Me.txtStock)
        Me.Panel1.Controls.Add(Me.txtDManu)
        Me.Panel1.Controls.Add(Me.txtManu)
        Me.Panel1.Controls.Add(Me.txtIName)
        Me.Panel1.Controls.Add(Me.txtICode)
        Me.Panel1.Location = New System.Drawing.Point(1302, 624)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(94, 100)
        Me.Panel1.TabIndex = 17
        Me.Panel1.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(4, 3)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(27, 20)
        Me.txtStatus.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtUT)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.lblDue)
        Me.Panel2.Controls.Add(Me.lblTime)
        Me.Panel2.Controls.Add(Me.txtMS)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.txtContact)
        Me.Panel2.Controls.Add(Me.txtUserID)
        Me.Panel2.Controls.Add(Me.txteadd)
        Me.Panel2.Controls.Add(Me.txtUsern)
        Me.Panel2.Controls.Add(Me.txtAdd)
        Me.Panel2.Controls.Add(Me.txtName)
        Me.Panel2.Location = New System.Drawing.Point(18, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(163, 49)
        Me.Panel2.TabIndex = 19
        Me.Panel2.Visible = False
        '
        'txtUT
        '
        Me.txtUT.Location = New System.Drawing.Point(63, 3)
        Me.txtUT.Name = "txtUT"
        Me.txtUT.ReadOnly = True
        Me.txtUT.Size = New System.Drawing.Size(17, 20)
        Me.txtUT.TabIndex = 148
        Me.txtUT.TabStop = False
        Me.txtUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUT.Visible = False
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(105, 8)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(52, 38)
        Me.DataGridView2.TabIndex = 20
        Me.DataGridView2.Visible = False
        '
        'lblDue
        '
        Me.lblDue.AutoSize = True
        Me.lblDue.Location = New System.Drawing.Point(102, 27)
        Me.lblDue.Name = "lblDue"
        Me.lblDue.Size = New System.Drawing.Size(39, 13)
        Me.lblDue.TabIndex = 21
        Me.lblDue.Text = "Label1"
        Me.lblDue.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(112, 14)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 13)
        Me.lblTime.TabIndex = 20
        Me.lblTime.Text = "Label1"
        Me.lblTime.Visible = False
        '
        'txtMS
        '
        Me.txtMS.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMS.Location = New System.Drawing.Point(111, 16)
        Me.txtMS.MaxLength = 15
        Me.txtMS.Name = "txtMS"
        Me.txtMS.ReadOnly = True
        Me.txtMS.Size = New System.Drawing.Size(27, 22)
        Me.txtMS.TabIndex = 147
        Me.txtMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(103, 14)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(39, 13)
        Me.lblDate.TabIndex = 19
        Me.lblDate.Text = "Label1"
        Me.lblDate.Visible = False
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(97, 16)
        Me.txtContact.MaxLength = 50
        Me.txtContact.Name = "txtContact"
        Me.txtContact.ReadOnly = True
        Me.txtContact.Size = New System.Drawing.Size(27, 22)
        Me.txtContact.TabIndex = 146
        Me.txtContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(4, 16)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(27, 20)
        Me.txtUserID.TabIndex = 145
        Me.txtUserID.TabStop = False
        Me.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txteadd
        '
        Me.txteadd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txteadd.Location = New System.Drawing.Point(130, 16)
        Me.txteadd.MaxLength = 30
        Me.txteadd.Name = "txteadd"
        Me.txteadd.ReadOnly = True
        Me.txteadd.Size = New System.Drawing.Size(27, 22)
        Me.txteadd.TabIndex = 144
        Me.txteadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsern
        '
        Me.txtUsern.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsern.Location = New System.Drawing.Point(30, 16)
        Me.txtUsern.MaxLength = 15
        Me.txtUsern.Name = "txtUsern"
        Me.txtUsern.ReadOnly = True
        Me.txtUsern.Size = New System.Drawing.Size(27, 22)
        Me.txtUsern.TabIndex = 141
        Me.txtUsern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAdd
        '
        Me.txtAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(75, 16)
        Me.txtAdd.MaxLength = 50
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.ReadOnly = True
        Me.txtAdd.Size = New System.Drawing.Size(27, 22)
        Me.txtAdd.TabIndex = 143
        Me.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(54, 16)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(27, 22)
        Me.txtName.TabIndex = 142
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(18, 69)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(27, 20)
        Me.txtPrice.TabIndex = 24
        '
        'txtEDate
        '
        Me.txtEDate.Location = New System.Drawing.Point(61, 53)
        Me.txtEDate.Name = "txtEDate"
        Me.txtEDate.Size = New System.Drawing.Size(27, 20)
        Me.txtEDate.TabIndex = 23
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(37, 3)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(27, 20)
        Me.txtType.TabIndex = 22
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(51, 66)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(27, 20)
        Me.txtStock.TabIndex = 4
        '
        'txtDManu
        '
        Me.txtDManu.Location = New System.Drawing.Point(51, 40)
        Me.txtDManu.Name = "txtDManu"
        Me.txtDManu.Size = New System.Drawing.Size(27, 20)
        Me.txtDManu.TabIndex = 3
        '
        'txtManu
        '
        Me.txtManu.Location = New System.Drawing.Point(51, 17)
        Me.txtManu.Name = "txtManu"
        Me.txtManu.Size = New System.Drawing.Size(27, 20)
        Me.txtManu.TabIndex = 2
        '
        'txtIName
        '
        Me.txtIName.Location = New System.Drawing.Point(18, 43)
        Me.txtIName.Name = "txtIName"
        Me.txtIName.Size = New System.Drawing.Size(27, 20)
        Me.txtIName.TabIndex = 1
        '
        'txtICode
        '
        Me.txtICode.Location = New System.Drawing.Point(18, 17)
        Me.txtICode.Name = "txtICode"
        Me.txtICode.Size = New System.Drawing.Size(27, 20)
        Me.txtICode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Viner Hand ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(952, 78)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Norteam Shipping Services Incorporated"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.QMS.My.Resources.Resources.norteam_jpeg
        Me.PictureBox1.Location = New System.Drawing.Point(12, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 121)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOut, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
        Me.FileMenu.Image = Global.QMS.My.Resources.Resources.books
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(53, 20)
        Me.FileMenu.Text = "&File"
        '
        'LogOut
        '
        Me.LogOut.Image = Global.QMS.My.Resources.Resources.logout
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(112, 22)
        Me.LogOut.Text = "Logo&ut"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(109, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.QMS.My.Resources.Resources.ex3
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewAccountToolStripMenuItem
        '
        Me.ViewAccountToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportsToolStripMenuItem})
        Me.ViewAccountToolStripMenuItem.Image = Global.QMS.My.Resources.Resources.search3
        Me.ViewAccountToolStripMenuItem.Name = "ViewAccountToolStripMenuItem"
        Me.ViewAccountToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ViewAccountToolStripMenuItem.Text = "&View"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitorToolStripMenuItem1})
        Me.ReportsToolStripMenuItem.Image = Global.QMS.My.Resources.Resources.reports
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'VisitorToolStripMenuItem1
        '
        Me.VisitorToolStripMenuItem1.Image = Global.QMS.My.Resources.Resources.invent
        Me.VisitorToolStripMenuItem1.Name = "VisitorToolStripMenuItem1"
        Me.VisitorToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.VisitorToolStripMenuItem1.Text = "Vis&itors"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ChangePasswordToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Image = Global.QMS.My.Resources.Resources.invent1
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewUser, Me.ViewUser})
        Me.ToolStripMenuItem1.Image = Global.QMS.My.Resources.Resources.users
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem1.Text = "&Manage Accounts"
        '
        'CreateNewUser
        '
        Me.CreateNewUser.Image = Global.QMS.My.Resources.Resources.users3
        Me.CreateNewUser.Name = "CreateNewUser"
        Me.CreateNewUser.Size = New System.Drawing.Size(209, 22)
        Me.CreateNewUser.Text = "&Create New User Account"
        '
        'ViewUser
        '
        Me.ViewUser.Image = Global.QMS.My.Resources.Resources.search1
        Me.ViewUser.Name = "ViewUser"
        Me.ViewUser.Size = New System.Drawing.Size(209, 22)
        Me.ViewUser.Text = "View &User Accounts"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Image = Global.QMS.My.Resources.Resources.change_pass
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change &Password"
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1135, 559)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "HOME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOME"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewUser As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtDManu As System.Windows.Forms.TextBox
    Friend WithEvents txtManu As System.Windows.Forms.TextBox
    Friend WithEvents txtIName As System.Windows.Forms.TextBox
    Friend WithEvents txtICode As System.Windows.Forms.TextBox
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblDue As System.Windows.Forms.Label
    Friend WithEvents txtEDate As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtMS As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txteadd As System.Windows.Forms.TextBox
    Friend WithEvents txtUsern As System.Windows.Forms.TextBox
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtUT As System.Windows.Forms.TextBox
    Friend WithEvents ViewAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisitorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
