Imports MainClass.Library
Public Class ViewUser1

    Private Sub ViewUser1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Return to HOME?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CLOSE") = Windows.Forms.DialogResult.Yes Then

            ClearText()

            ViewUser_Load(Me, New System.EventArgs())
            HOME.btnRefresh.PerformClick()
            HOME.Show()

        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ViewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM Users")
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Times New Roman", 15)

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoResizeColumns()
        btnSearch.Visible = True

        DisableTextbox()

        ButtonDisabled()

        HideButtons()

        SearchFalse()

        ClearText()

        ButtonEditTrue()



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            txtUserID.Text = DataGridView1.Item(0, i).Value
            txtUserT.Text = DataGridView1.Item(1, i).Value
            txtUsern.Text = DataGridView1.Item(2, i).Value
            txtPass.Text = DataGridView1.Item(3, i).Value
            txtName.Text = DataGridView1.Item(4, i).Value
            txtAdd.Text = DataGridView1.Item(5, i).Value
            txtContact.Text = DataGridView1.Item(6, i).Value
            txteadd.Text = DataGridView1.Item(7, i).Value

            If txtUserT.Text = rdbAdmin.Text Then
                rdbAdmin.Checked = True
            ElseIf txtUserT.Text = rdbGuest.Text Then
                rdbGuest.Checked = True
            End If

            EnableTextbox()

            ReadTrue()

            ButtonEnabled()

        Catch ex As Exception
        Finally
        End Try

    End Sub

    Private Sub rdbAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAdmin.CheckedChanged

        If Me.rdbAdmin.Checked = True Then
            txtUserT.Text = Me.rdbAdmin.Text
        End If

    End Sub

    Private Sub rdbGuest_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGuest.CheckedChanged

        If rdbGuest.Checked = True Then
            txtUserT.Text = Me.rdbGuest.Text
        End If

    End Sub

    Private Sub ClearText()

        rdbAdmin.Checked = False
        rdbGuest.Checked = False
        txtUserID.Text = ""
        txtUserT.Text = ""
        txtUsern.Text = ""
        txtName.Text = ""
        txtAdd.Text = ""
        txteadd.Text = ""
        txtPass.Text = ""
        txtContact.Text = ""

        cmbSType.Text = ""
        cmbSearch.Text = ""
        cmbSearch1.Text = ""

    End Sub

    Private Sub DisableTextbox()

        rdbAdmin.Enabled = False
        rdbGuest.Enabled = False
        txtUserID.Enabled = False
        txtUserT.Enabled = False
        txtUsern.Enabled = False
        txtName.Enabled = False
        txtAdd.Enabled = False
        txteadd.Enabled = False
        txtPass.Enabled = False
        txtContact.Enabled = False

    End Sub

    Private Sub EnableTextbox()

        txtUserID.Enabled = True
        txtUserT.Enabled = True
        txtUsern.Enabled = True
        txtName.Enabled = True
        txtAdd.Enabled = True
        txteadd.Enabled = True
        txtPass.Enabled = True
        txtContact.Enabled = True

    End Sub

    Private Sub ReadTrue()

        rdbAdmin.Enabled = False
        rdbGuest.Enabled = False
        txtUserID.ReadOnly = True
        txtUserT.ReadOnly = True
        txtUsern.ReadOnly = True
        txtName.ReadOnly = True
        txtAdd.ReadOnly = True
        txteadd.ReadOnly = True
        txtPass.ReadOnly = True
        txtContact.ReadOnly = True

    End Sub

    Private Sub ReadFalse()

        rdbAdmin.Enabled = True
        rdbGuest.Enabled = True
        txtUserID.ReadOnly = True
        txtUserT.ReadOnly = False
        txtUsern.ReadOnly = True
        txtName.ReadOnly = False
        txtAdd.ReadOnly = False
        txteadd.ReadOnly = False
        txtPass.ReadOnly = False
        txtContact.ReadOnly = False

    End Sub

    Private Sub ButtonDisabled()

        btnEdit.Enabled = False
        btnDelete.Enabled = False
        DataGridView1.Enabled = True

    End Sub

    Private Sub ButtonEnabled()

        btnEdit.Enabled = True
        btnDelete.Enabled = True

    End Sub

    Private Sub ButtonFalse()

        btnEdit.Visible = False
        btnDelete.Visible = False
        btnSearch.Visible = False
        btnBack.Visible = False

        DataGridView1.Enabled = False

    End Sub

    Private Sub ButtonEditTrue()

        btnEdit.Visible = True
        btnDelete.Visible = True
        btnSearch.Visible = True
        btnBack.Visible = True

    End Sub

    Private Sub ShowUpdate()

        btnCancelUpdate.Visible = True
        btnUpdate.Visible = True

    End Sub

    Private Sub HideButtons()

        btnCancelUpdate.Visible = False
        btnUpdate.Visible = False

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        ReadFalse()

        ButtonFalse()

        ShowUpdate()

        SearchFalse()

    End Sub

    Private Sub btnCancelUpdate_Click(sender As Object, e As EventArgs) Handles btnCancelUpdate.Click

        ClearText()

        ButtonEditTrue()

        DataGridView1.Enabled = True

        ViewUser_Load(Me, New System.EventArgs())

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure you want to Delete this Account data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then

            MainClass.Library.Command.Execute("DELETE from Users where UserID='" & txtUserID.Text & "'")

            MsgBox("Successfully DELETED", MsgBoxStyle.Information, "Deleted")

            ClearText()

            ViewUser_Load(Me, New System.EventArgs())

        Else
            ClearText()

            ViewUser_Load(Me, New System.EventArgs())

            MsgBox("Account Data not Deleted", MsgBoxStyle.Information, "Message Box")
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtUserT.Text = "" Or txtUsern.Text = "" Or txtName.Text = "" Or txtAdd.Text = "" Or txteadd.Text = "" Or txtPass.Text = "" Then
            MsgBox("Please COMPLETE ALL the DATA REQUIREMENTS", MsgBoxStyle.Critical, "Error")
        Else
            If Len(txtPass.Text) <= 5 Then
                MsgBox("Password Too Short, Password must be at least 6 characters", MsgBoxStyle.Critical, "Error")
            Else
                btnUpdate.Focus()
                MainClass.Library.Command.Execute("UPDATE Users SET UserType='" & txtUserT.Text & "', UserName='" & txtUsern.Text & "', UserPass='" & txtPass.Text & "', FullName='" & txtName.Text & "', Address='" & txtAdd.Text & "', EmailAddress='" & txteadd.Text & "', ContactNumber='" & txtContact.Text & "' where UserID='" & txtUserID.Text & "' ")

                MsgBox("Successfully UPDATED", MsgBoxStyle.Information, "Updated")

                ClearText()

                ViewUser_Load(Me, New System.EventArgs())

                HideButtons()

                ButtonEditTrue()

                ButtonDisabled()

            End If
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub

    'Private Sub txtUsern_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsern.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '        And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '        And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '        And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 _
    '        And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '        And Asc(e.KeyChar) = 32 _
    '        And Asc(e.KeyChar) = 46 _
    '        And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '        And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 _
    '        And Asc(e.KeyChar) = 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtAdd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdd.KeyPress
    '    'If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '    '    And Asc(e.KeyChar) < 32 Or Asc(e.KeyChar) > 32 _
    '    '    And Asc(e.KeyChar) < 35 Or Asc(e.KeyChar) > 35 _
    '    '    And Asc(e.KeyChar) < 38 Or Asc(e.KeyChar) > 41 _
    '    '    And Asc(e.KeyChar) < 44 Or Asc(e.KeyChar) > 46 _
    '    '    And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '    '    And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '    '    And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '    '    And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '    '    e.Handled = True
    '    'End If
    'End Sub

    'Private Sub txteadd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txteadd.KeyPress
    '    'If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '    '    And Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 46 _
    '    '    And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '    '    And Asc(e.KeyChar) < 64 Or Asc(e.KeyChar) > 90 _
    '    '    And Asc(e.KeyChar) < 95 Or Asc(e.KeyChar) < 95 _
    '    '    And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 _
    '    '    And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '    '    e.Handled = True
    '    'End If
    'End Sub

    'Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '       And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '       And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '       And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '       And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub SearchFalse()

        cmbSType.Visible = False
        cmbSearch.Visible = False
        cmbSearch1.Visible = False
        btnSearchN.Visible = False

    End Sub

    Private Sub SelSearch()

        cmbSType.Text = "Select Category"

        If cmbSType.SelectedItem = "User ID" Then
            cmbSearch.Visible = True
            cmbSearch1.Visible = False
            cmbSearch.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT UserID FROM Users")
            cmbSearch.ValueMember = "UserID"
            cmbSearch.DisplayMember = "UserID"

            cmbSearch.Text = "Select User ID"
            MsgBox("Select User ID")

        ElseIf cmbSType.SelectedItem = "User Type" Then
            cmbSearch.Visible = False
            cmbSearch1.Visible = True

            cmbSearch1.Text = "Select User Type"
            MsgBox("Select User Type")

        ElseIf cmbSType.SelectedItem = "User Name" Then
            cmbSearch.Visible = True
            cmbSearch1.Visible = False
            cmbSearch.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT UserName FROM Users")
            cmbSearch.ValueMember = "UserName"
            cmbSearch.DisplayMember = "UserName"

            cmbSearch.Text = "Select User Name"
            MsgBox("Select User Name")

        ElseIf cmbSType.SelectedItem = "Full Name" Then
            cmbSearch.Visible = True
            cmbSearch1.Visible = False
            cmbSearch.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT FullName FROM Users")
            cmbSearch.ValueMember = "FullName"
            cmbSearch.DisplayMember = "FullName"

            cmbSearch.Text = "Select Full Name"
            MsgBox("Select Full Name")

        Else
            MsgBox("PLease Select a Category")
            cmbSType.Text = "Select Category"

        End If

    End Sub

    Private Sub SelSearchN()

        Dim strSQL As String
        If cmbSearch.Text.Length > 0 Then
            If cmbSType.SelectedItem = "User ID" Then
                If cmbSearch.Text = "Select User ID" Then
                    MsgBox("Select User ID")
                Else
                    strSQL = "SELECT * FROM Users WHERE UserID = '" & cmbSearch.Text & "'"
                    DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet(strSQL)
                    btnSearchN.Visible = True
                End If

            ElseIf cmbSType.SelectedItem = "User Type" Then
                If cmbSearch1.Text = "Select User Type" Then
                    MsgBox("Select User Type")
                Else
                    strSQL = "SELECT * FROM Users WHERE UserType = '" & cmbSearch1.Text & "'"
                    DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet(strSQL)
                    btnSearchN.Visible = True
                End If
            ElseIf cmbSType.SelectedItem = "User Name" Then
                If cmbSearch.Text = "Select User Name" Then
                    MsgBox("Select User Name")
                Else
                    strSQL = "SELECT * FROM Users WHERE UserName = '" & cmbSearch.Text & "'"
                    DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet(strSQL)
                    btnSearchN.Visible = True
                End If
            ElseIf cmbSType.SelectedItem = "Full Name" Then
                If cmbSearch.Text = "Select Full Name" Then
                    MsgBox("Select Full Name")
                Else
                    strSQL = "SELECT * FROM Users WHERE FullName = '" & cmbSearch.Text & "'"
                    DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet(strSQL)
                    btnSearchN.Visible = True
                End If
            End If
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        cmbSType.Visible = True

        SelSearch()

        cmbSearch.Visible = False
        cmbSearch1.Visible = False
        btnSearch.Visible = False

    End Sub

    Private Sub btnSearchN_Click(sender As Object, e As EventArgs) Handles btnSearchN.Click

        SelSearchN()

    End Sub

    Private Sub cmbSType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSType.SelectedIndexChanged

        SelSearch()

    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged

        btnSearchN.Visible = True

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        ViewUser_Load(Me, New System.EventArgs())

    End Sub

    'Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress

    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '        And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '        e.Handled = True
    '    End If

    'End Sub

    Private Sub cmbSearch1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch1.SelectedIndexChanged
        btnSearchN.Visible = True
    End Sub

End Class