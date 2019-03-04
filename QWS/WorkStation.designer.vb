<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkStation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WorkStation))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCall = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblNext = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblNameS = New System.Windows.Forms.Label()
        Me.lblNow = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCon = New System.Windows.Forms.TextBox()
        Me.txtServing = New System.Windows.Forms.TextBox()
        Me.txtCalled = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtWaiting = New System.Windows.Forms.TextBox()
        Me.txtTimeOut = New System.Windows.Forms.TextBox()
        Me.txtTimeIn = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.txtPOA = New System.Windows.Forms.TextBox()
        Me.txtRank = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblNS = New System.Windows.Forms.Label()
        Me.lblNX = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPX = New System.Windows.Forms.Label()
        Me.lblPS = New System.Windows.Forms.Label()
        Me.lblPOAs = New System.Windows.Forms.Label()
        Me.lblPOA = New System.Windows.Forms.Label()
        Me.cbSearch = New System.Windows.Forms.ComboBox()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(12, 82)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(462, 207)
        Me.DataGridView1.TabIndex = 0
        '
        'btnCall
        '
        Me.btnCall.BackColor = System.Drawing.Color.Transparent
        Me.btnCall.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCall.Location = New System.Drawing.Point(371, 319)
        Me.btnCall.Name = "btnCall"
        Me.btnCall.Size = New System.Drawing.Size(99, 49)
        Me.btnCall.TabIndex = 1
        Me.btnCall.Text = "Call Next Visitor"
        Me.btnCall.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(77, 44)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(38, 19)
        Me.lblTime.TabIndex = 14
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(75, 14)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 19)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblNext
        '
        Me.lblNext.AutoSize = True
        Me.lblNext.BackColor = System.Drawing.Color.Transparent
        Me.lblNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext.Location = New System.Drawing.Point(26, 293)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(89, 20)
        Me.lblNext.TabIndex = 15
        Me.lblNext.Text = "Next Visitor"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(38, 319)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 18)
        Me.lblName.TabIndex = 16
        Me.lblName.Text = "Name:"
        '
        'lblNameS
        '
        Me.lblNameS.AutoSize = True
        Me.lblNameS.BackColor = System.Drawing.Color.Transparent
        Me.lblNameS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameS.Location = New System.Drawing.Point(36, 319)
        Me.lblNameS.Name = "lblNameS"
        Me.lblNameS.Size = New System.Drawing.Size(52, 18)
        Me.lblNameS.TabIndex = 20
        Me.lblNameS.Text = "Name:"
        '
        'lblNow
        '
        Me.lblNow.AutoSize = True
        Me.lblNow.BackColor = System.Drawing.Color.Transparent
        Me.lblNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNow.Location = New System.Drawing.Point(24, 293)
        Me.lblNow.Name = "lblNow"
        Me.lblNow.Size = New System.Drawing.Size(97, 20)
        Me.lblNow.TabIndex = 19
        Me.lblNow.Text = "Now Serving"
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Transparent
        Me.btnDone.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.Location = New System.Drawing.Point(384, 319)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(73, 49)
        Me.btnDone.TabIndex = 2
        Me.btnDone.Text = "DONE"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtCon)
        Me.Panel1.Controls.Add(Me.txtServing)
        Me.Panel1.Controls.Add(Me.txtCalled)
        Me.Panel1.Controls.Add(Me.txtid)
        Me.Panel1.Controls.Add(Me.txtStatus)
        Me.Panel1.Controls.Add(Me.txtWaiting)
        Me.Panel1.Controls.Add(Me.txtTimeOut)
        Me.Panel1.Controls.Add(Me.txtTimeIn)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.txtReason)
        Me.Panel1.Controls.Add(Me.txtPOA)
        Me.Panel1.Controls.Add(Me.txtRank)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Location = New System.Drawing.Point(544, 239)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 119)
        Me.Panel1.TabIndex = 24
        '
        'txtCon
        '
        Me.txtCon.Location = New System.Drawing.Point(49, 49)
        Me.txtCon.Name = "txtCon"
        Me.txtCon.Size = New System.Drawing.Size(35, 20)
        Me.txtCon.TabIndex = 13
        '
        'txtServing
        '
        Me.txtServing.Location = New System.Drawing.Point(97, 68)
        Me.txtServing.Name = "txtServing"
        Me.txtServing.Size = New System.Drawing.Size(35, 20)
        Me.txtServing.TabIndex = 12
        '
        'txtCalled
        '
        Me.txtCalled.Location = New System.Drawing.Point(56, 94)
        Me.txtCalled.Name = "txtCalled"
        Me.txtCalled.Size = New System.Drawing.Size(35, 20)
        Me.txtCalled.TabIndex = 10
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(15, 16)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(35, 20)
        Me.txtid.TabIndex = 9
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(97, 94)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(35, 20)
        Me.txtStatus.TabIndex = 8
        '
        'txtWaiting
        '
        Me.txtWaiting.Location = New System.Drawing.Point(97, 42)
        Me.txtWaiting.Name = "txtWaiting"
        Me.txtWaiting.Size = New System.Drawing.Size(35, 20)
        Me.txtWaiting.TabIndex = 7
        '
        'txtTimeOut
        '
        Me.txtTimeOut.Location = New System.Drawing.Point(97, 16)
        Me.txtTimeOut.Name = "txtTimeOut"
        Me.txtTimeOut.Size = New System.Drawing.Size(35, 20)
        Me.txtTimeOut.TabIndex = 6
        '
        'txtTimeIn
        '
        Me.txtTimeIn.Location = New System.Drawing.Point(56, 68)
        Me.txtTimeIn.Name = "txtTimeIn"
        Me.txtTimeIn.Size = New System.Drawing.Size(35, 20)
        Me.txtTimeIn.TabIndex = 5
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(56, 42)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(35, 20)
        Me.txtDate.TabIndex = 4
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(56, 17)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(35, 20)
        Me.txtReason.TabIndex = 3
        '
        'txtPOA
        '
        Me.txtPOA.Location = New System.Drawing.Point(15, 94)
        Me.txtPOA.Name = "txtPOA"
        Me.txtPOA.Size = New System.Drawing.Size(35, 20)
        Me.txtPOA.TabIndex = 2
        '
        'txtRank
        '
        Me.txtRank.Location = New System.Drawing.Point(15, 68)
        Me.txtRank.Name = "txtRank"
        Me.txtRank.Size = New System.Drawing.Size(35, 20)
        Me.txtRank.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(15, 42)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(35, 20)
        Me.txtName.TabIndex = 0
        '
        'lblNS
        '
        Me.lblNS.AutoSize = True
        Me.lblNS.BackColor = System.Drawing.Color.Transparent
        Me.lblNS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNS.Location = New System.Drawing.Point(96, 319)
        Me.lblNS.Name = "lblNS"
        Me.lblNS.Size = New System.Drawing.Size(48, 18)
        Me.lblNS.TabIndex = 27
        Me.lblNS.Text = "Name"
        '
        'lblNX
        '
        Me.lblNX.AutoSize = True
        Me.lblNX.BackColor = System.Drawing.Color.Transparent
        Me.lblNX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNX.Location = New System.Drawing.Point(96, 319)
        Me.lblNX.Name = "lblNX"
        Me.lblNX.Size = New System.Drawing.Size(48, 18)
        Me.lblNX.TabIndex = 25
        Me.lblNX.Text = "Name"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 10000
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(384, 14)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(86, 27)
        Me.btnLogout.TabIndex = 31
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(384, 44)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(71, 27)
        Me.btnRefresh.TabIndex = 30
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Time:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Date:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPX
        '
        Me.lblPX.AutoSize = True
        Me.lblPX.BackColor = System.Drawing.Color.Transparent
        Me.lblPX.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPX.Location = New System.Drawing.Point(98, 353)
        Me.lblPX.Name = "lblPX"
        Me.lblPX.Size = New System.Drawing.Size(39, 18)
        Me.lblPX.TabIndex = 37
        Me.lblPX.Text = "POA"
        Me.lblPX.Visible = False
        '
        'lblPS
        '
        Me.lblPS.AutoSize = True
        Me.lblPS.BackColor = System.Drawing.Color.Transparent
        Me.lblPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPS.Location = New System.Drawing.Point(96, 353)
        Me.lblPS.Name = "lblPS"
        Me.lblPS.Size = New System.Drawing.Size(39, 18)
        Me.lblPS.TabIndex = 36
        Me.lblPS.Text = "POA"
        Me.lblPS.Visible = False
        '
        'lblPOAs
        '
        Me.lblPOAs.AutoSize = True
        Me.lblPOAs.BackColor = System.Drawing.Color.Transparent
        Me.lblPOAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOAs.Location = New System.Drawing.Point(38, 353)
        Me.lblPOAs.Name = "lblPOAs"
        Me.lblPOAs.Size = New System.Drawing.Size(43, 18)
        Me.lblPOAs.TabIndex = 35
        Me.lblPOAs.Text = "POA:"
        Me.lblPOAs.Visible = False
        '
        'lblPOA
        '
        Me.lblPOA.AutoSize = True
        Me.lblPOA.BackColor = System.Drawing.Color.Transparent
        Me.lblPOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOA.Location = New System.Drawing.Point(38, 353)
        Me.lblPOA.Name = "lblPOA"
        Me.lblPOA.Size = New System.Drawing.Size(43, 18)
        Me.lblPOA.TabIndex = 34
        Me.lblPOA.Text = "POA:"
        Me.lblPOA.Visible = False
        '
        'cbSearch
        '
        Me.cbSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearch.Location = New System.Drawing.Point(221, 44)
        Me.cbSearch.Name = "cbSearch"
        Me.cbSearch.Size = New System.Drawing.Size(157, 27)
        Me.cbSearch.TabIndex = 38
        '
        'Timer4
        '
        Me.Timer4.Enabled = True
        Me.Timer4.Interval = 20000
        '
        'WorkStation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(486, 389)
        Me.Controls.Add(Me.cbSearch)
        Me.Controls.Add(Me.lblPX)
        Me.Controls.Add(Me.lblPS)
        Me.Controls.Add(Me.lblPOAs)
        Me.Controls.Add(Me.lblPOA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.lblNS)
        Me.Controls.Add(Me.lblNX)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblNameS)
        Me.Controls.Add(Me.lblNow)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblNext)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnCall)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "WorkStation"
        Me.Text = "Work Station"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCall As System.Windows.Forms.Button
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblNext As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblNameS As System.Windows.Forms.Label
    Friend WithEvents lblNow As System.Windows.Forms.Label
    Friend WithEvents btnDone As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtServing As System.Windows.Forms.TextBox
    Friend WithEvents txtCalled As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtWaiting As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeOut As System.Windows.Forms.TextBox
    Friend WithEvents txtTimeIn As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents txtPOA As System.Windows.Forms.TextBox
    Friend WithEvents txtRank As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblNS As System.Windows.Forms.Label
    Friend WithEvents lblNX As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents txtCon As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblPX As System.Windows.Forms.Label
    Friend WithEvents lblPS As System.Windows.Forms.Label
    Friend WithEvents lblPOAs As System.Windows.Forms.Label
    Friend WithEvents lblPOA As System.Windows.Forms.Label
    Friend WithEvents cbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
End Class
