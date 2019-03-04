Imports MainClass.Library

Public Class CreateUser

    Private Sub ClearText()

        rdbAdmin.Checked = False
        rdbMember.Checked = False
        txtUsern.Text = ""
        txtName.Text = ""
        txtAdd.Text = ""
        txteadd.Text = ""
        txtContact.Text = ""
        txtNewP.Text = ""
        txtPassword.Text = ""

        pcbcheck.Visible = False
        pcberror.Visible = False
        pcbok.Visible = False
        pcbx.Visible = False
        btnC.Visible = False

    End Sub

    Private Sub rdbAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAdmin.CheckedChanged

        If rdbAdmin.Checked = True Then
            txtUserT.Text = rdbAdmin.Text
        End If

    End Sub

    Private Sub rdbGuest_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMember.CheckedChanged

        If rdbMember.Checked = True Then
            txtUserT.Text = rdbMember.Text
        End If

    End Sub

    Private Sub txtNewP_TextChanged(sender As Object, e As EventArgs) Handles txtNewP.TextChanged
        If txtNewP.Text = "" Or txtPassword.Text = "" Then
            pcbcheck.Visible = False
            pcberror.Visible = False
        Else
            If txtNewP.Text = txtPassword.Text Then
                pcbcheck.Visible = True
                pcberror.Visible = False
            Else
                pcberror.Visible = True
                pcbcheck.Visible = False
            End If
        End If

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        If txtNewP.Text = "" Or txtPassword.Text = "" Then
            pcbcheck.Visible = False
            pcberror.Visible = False
        Else
            If txtPassword.Text = txtNewP.Text Then
                pcbcheck.Visible = True
                pcberror.Visible = False
            Else
                pcberror.Visible = True
                pcbcheck.Visible = False
            End If
        End If

    End Sub

    Private Sub CreateUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If z = "1" Then
            ClearText()

            CreateUser_Load(Me, New System.EventArgs())
            HOME.btnRefresh.PerformClick()
            HOME.Show()
        Else
            If MsgBox("Return to HOME?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CLOSE") = Windows.Forms.DialogResult.Yes Then

                ClearText()

                CreateUser_Load(Me, New System.EventArgs())
                HOME.btnRefresh.PerformClick()
                HOME.Show()

            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub CreateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnC.Visible = False
        pcbcheck.Visible = False
        pcberror.Visible = False
        pcbok.Visible = False
        pcbx.Visible = False

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If txtUserT.Text = "" Or txtUsern.Text = "" Or txtName.Text = "" Or txtAdd.Text = "" Or txtContact.Text = "" Or txteadd.Text = "" Or txtNewP.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Please COMPLETE ALL the DATA REQUIREMENTS", MsgBoxStyle.Critical, "Error")
            txtNewP.Text = ""
            txtPassword.Text = ""

        Else
            If btnC.Visible = True Then
                MsgBox("Please Check User Name", MsgBoxStyle.Information, "Check User Name")
                txtNewP.Text = ""
                txtPassword.Text = ""
                btnC.Focus()

            Else
                If pcbx.Visible = True Then
                    MsgBox("User Name not Available!", MsgBoxStyle.Critical, "Error")
                    txtNewP.Text = ""
                    txtPassword.Text = ""
                    txtUsern.Focus()

                Else
                    If txtNewP.Text <> txtPassword.Text Then
                        MsgBox("Password Not Match!!", MsgBoxStyle.Critical, "Error")
                        txtNewP.Text = ""
                        txtPassword.Text = ""
                        pcberror.Visible = True
                        pcbcheck.Visible = False
                        txtNewP.Focus()

                    Else
                        If Len(txtNewP.Text) And Len(txtPassword.Text) <= 5 Then
                            MsgBox("Password Too Short, Password must be at least 6 characters", MsgBoxStyle.Critical, "Error")
                            txtNewP.Focus()
                            txtNewP.Text = ""
                            txtPassword.Text = ""

                        Else
                            If txtNewP.Text = txtPassword.Text AndAlso MsgBox("DO YOU WANT TO SAVE?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SAVE") = MsgBoxResult.Yes Then

                                Dim a = DateTime.Parse(Date.Today.ToLongDateString)
                                Dim b = DateTime.Parse(TimeOfDay)
                                lblDate.Text = a
                                lblTime.Text = b

                                MainClass.Library.Command.Execute("INSERT INTO Users (UserType, UserName, UserPass, FullName, Address, ContactNumber, EmailAddress) VALUES ('" & txtUserT.Text & "', '" & txtUsern.Text & "', '" & txtPassword.Text & "', '" & txtName.Text & "', '" & txtAdd.Text & "', '" & txtContact.Text & "', '" & txteadd.Text & "')")

                                MsgBox("Account Successfully Created", MsgBoxStyle.Information, "Message Box")

                                z = "1"

                                Me.Close()

                            Else

                                btnConfirm.Focus()
                           
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click

        Dim UserName As String
        Dim dtUser As New DataTable
        Dim htParameters As New Hashtable
        htParameters.Add("UserName", txtUsern.Text)

        dtUser = MainClass.Library.Adapter.GetRecordSet(htParameters, "LoginSel")

        If dtUser.Rows.Count > 0 Then
            For Each row As DataRow In dtUser.Rows
                If row("UserName") = txtUsern.Text Then
                    UserName = row("UserName").ToString
                    pcbx.Visible = True
                    pcbok.Visible = False
                    btnC.Visible = False
                    MsgBox("User Name not available", MsgBoxStyle.Information, "User Name not Available")

                    txtUsern.Focus()
                Else
                    MsgBox("User Name cannot be changed once Account is Created", MsgBoxStyle.Information, "User Name Available")
                    pcbx.Visible = False
                    pcbok.Visible = True
                    btnC.Visible = False
                End If
            Next
        Else
            pcbx.Visible = False
            pcbok.Visible = True
            btnC.Visible = False
        End If

    End Sub

    Private Sub txtUsern_TextChanged(sender As Object, e As EventArgs) Handles txtUsern.TextChanged
        btnC.Visible = True
        pcbok.Visible = False
        pcbx.Visible = False
    End Sub

    'Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '       And Asc(e.KeyChar) < 32 Or Asc(e.KeyChar) > 32 _
    '       And Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 46 _
    '       And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '       And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 _
    '       And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtUsern_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsern.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '        And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '        And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '        And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 _
    '        And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtAdd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdd.KeyPress
    '    'If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '    '       And Asc(e.KeyChar) < 32 Or Asc(e.KeyChar) > 32 _
    '    '       And Asc(e.KeyChar) < 35 Or Asc(e.KeyChar) > 35 _
    '    '       And Asc(e.KeyChar) < 38 Or Asc(e.KeyChar) > 41 _
    '    '       And Asc(e.KeyChar) < 44 Or Asc(e.KeyChar) > 46 _
    '    '       And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '    '       And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '    '       And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '    '       And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '    '    e.Handled = True
    '    'End If
    'End Sub

    'Private Sub txteadd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txteadd.KeyPress
    '    'If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '    '       And Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 46 _
    '    '       And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '    '       And Asc(e.KeyChar) < 64 Or Asc(e.KeyChar) > 90 _
    '    '       And Asc(e.KeyChar) < 95 Or Asc(e.KeyChar) < 95 _
    '    '       And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 _
    '    '       And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '    '    e.Handled = True
    '    'End If
    'End Sub

    'Private Sub txtNewP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewP.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '       And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '       And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '       And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '       And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '      And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '      And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '      And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '      And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress

    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '        And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '        e.Handled = True
    '    End If

    'End Sub

End Class