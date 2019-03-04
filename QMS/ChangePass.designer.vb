<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePass))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtOld = New System.Windows.Forms.TextBox()
        Me.txtNew = New System.Windows.Forms.TextBox()
        Me.txtConfirm = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnChangeP = New System.Windows.Forms.Button()
        Me.pcberror = New System.Windows.Forms.PictureBox()
        Me.pcbx = New System.Windows.Forms.PictureBox()
        Me.pcbok = New System.Windows.Forms.PictureBox()
        Me.pcbcheck = New System.Windows.Forms.PictureBox()
        Me.txtOP = New System.Windows.Forms.TextBox()
        CType(Me.pcberror, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Change Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Old Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "New Password:"
        '
        'txtOld
        '
        Me.txtOld.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOld.Location = New System.Drawing.Point(177, 60)
        Me.txtOld.Name = "txtOld"
        Me.txtOld.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOld.Size = New System.Drawing.Size(198, 26)
        Me.txtOld.TabIndex = 4
        Me.txtOld.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNew
        '
        Me.txtNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNew.Location = New System.Drawing.Point(177, 92)
        Me.txtNew.Name = "txtNew"
        Me.txtNew.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNew.Size = New System.Drawing.Size(198, 26)
        Me.txtNew.TabIndex = 5
        Me.txtNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtConfirm
        '
        Me.txtConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirm.Location = New System.Drawing.Point(177, 124)
        Me.txtConfirm.Name = "txtConfirm"
        Me.txtConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirm.Size = New System.Drawing.Size(198, 26)
        Me.txtConfirm.TabIndex = 6
        Me.txtConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Control
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(78, 173)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(122, 50)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnChangeP
        '
        Me.btnChangeP.BackColor = System.Drawing.SystemColors.Control
        Me.btnChangeP.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnChangeP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeP.Location = New System.Drawing.Point(271, 173)
        Me.btnChangeP.Name = "btnChangeP"
        Me.btnChangeP.Size = New System.Drawing.Size(122, 50)
        Me.btnChangeP.TabIndex = 8
        Me.btnChangeP.Text = "Change Password"
        Me.btnChangeP.UseVisualStyleBackColor = False
        '
        'pcberror
        '
        Me.pcberror.Image = Global.QMS.My.Resources.Resources.iconX
        Me.pcberror.Location = New System.Drawing.Point(381, 122)
        Me.pcberror.Name = "pcberror"
        Me.pcberror.Size = New System.Drawing.Size(45, 28)
        Me.pcberror.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcberror.TabIndex = 101
        Me.pcberror.TabStop = False
        '
        'pcbx
        '
        Me.pcbx.BackColor = System.Drawing.Color.Transparent
        Me.pcbx.Image = Global.QMS.My.Resources.Resources.minus
        Me.pcbx.Location = New System.Drawing.Point(381, 61)
        Me.pcbx.Name = "pcbx"
        Me.pcbx.Size = New System.Drawing.Size(45, 28)
        Me.pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbx.TabIndex = 100
        Me.pcbx.TabStop = False
        '
        'pcbok
        '
        Me.pcbok.BackColor = System.Drawing.Color.Transparent
        Me.pcbok.Image = Global.QMS.My.Resources.Resources.ok1
        Me.pcbok.Location = New System.Drawing.Point(381, 61)
        Me.pcbok.Name = "pcbok"
        Me.pcbok.Size = New System.Drawing.Size(45, 28)
        Me.pcbok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbok.TabIndex = 99
        Me.pcbok.TabStop = False
        '
        'pcbcheck
        '
        Me.pcbcheck.BackColor = System.Drawing.Color.Transparent
        Me.pcbcheck.Image = Global.QMS.My.Resources.Resources.Check1
        Me.pcbcheck.Location = New System.Drawing.Point(381, 122)
        Me.pcbcheck.Name = "pcbcheck"
        Me.pcbcheck.Size = New System.Drawing.Size(45, 28)
        Me.pcbcheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pcbcheck.TabIndex = 98
        Me.pcbcheck.TabStop = False
        '
        'txtOP
        '
        Me.txtOP.Location = New System.Drawing.Point(532, 286)
        Me.txtOP.Name = "txtOP"
        Me.txtOP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOP.Size = New System.Drawing.Size(10, 20)
        Me.txtOP.TabIndex = 102
        Me.txtOP.Visible = False
        '
        'ChangePass
        '
        Me.AcceptButton = Me.btnChangeP
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.CancelButton = Me.btnChangeP
        Me.ClientSize = New System.Drawing.Size(450, 241)
        Me.Controls.Add(Me.txtOP)
        Me.Controls.Add(Me.pcberror)
        Me.Controls.Add(Me.pcbx)
        Me.Controls.Add(Me.pcbok)
        Me.Controls.Add(Me.pcbcheck)
        Me.Controls.Add(Me.btnChangeP)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.txtConfirm)
        Me.Controls.Add(Me.txtNew)
        Me.Controls.Add(Me.txtOld)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ChangePass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change your Password"
        Me.TopMost = True
        CType(Me.pcberror, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbcheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtOld As System.Windows.Forms.TextBox
    Friend WithEvents txtNew As System.Windows.Forms.TextBox
    Friend WithEvents txtConfirm As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnChangeP As System.Windows.Forms.Button
    Friend WithEvents pcberror As System.Windows.Forms.PictureBox
    Friend WithEvents pcbx As System.Windows.Forms.PictureBox
    Friend WithEvents pcbok As System.Windows.Forms.PictureBox
    Friend WithEvents pcbcheck As System.Windows.Forms.PictureBox
    Friend WithEvents txtOP As System.Windows.Forms.TextBox
End Class
