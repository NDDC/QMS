Imports MainClass.Library

Public Class ChangePass

    Private Sub ClearText()

        txtOld.Text = ""
        txtNew.Text = ""
        txtConfirm.Text = ""

    End Sub

    Private Sub txtNew_TextChanged(sender As Object, e As EventArgs) Handles txtNew.TextChanged

        If txtNew.Text = "" Or txtConfirm.Text = "" Then
            pcbcheck.Visible = False
            pcberror.Visible = False
        Else
            If txtNew.Text = txtConfirm.Text Then
                pcbcheck.Visible = True
                pcberror.Visible = False
            Else
                pcberror.Visible = True
                pcbcheck.Visible = False
            End If
        End If

    End Sub

    Private Sub txtConfirm_TextChanged(sender As Object, e As EventArgs) Handles txtConfirm.TextChanged

        If txtConfirm.Text = "" Or txtNew.Text = "" Then
            pcbcheck.Visible = False
            pcberror.Visible = False
        Else
            If txtConfirm.Text = txtNew.Text Then
                pcbcheck.Visible = True
                pcberror.Visible = False
            Else
                pcberror.Visible = True
                pcbcheck.Visible = False
            End If
        End If

    End Sub

    Private Sub txtOld_TextChanged(sender As Object, e As EventArgs) Handles txtOld.TextChanged

        If txtOld.Text = "" Then
            pcbx.Visible = False
            pcbok.Visible = False
        Else
            If txtOld.Text = txtOP.Text Then
                pcbx.Visible = False
                pcbok.Visible = True
            Else
                pcbx.Visible = True
                pcbok.Visible = False
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

    Private Sub ChangePass_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If z = "1" Then

            ClearText()

            ChangePass_Load(Me, New System.EventArgs())
            HOME.btnRefresh.PerformClick()
            HOME.Show()

        Else
            If MsgBox("Return to HOME?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CLOSE") = Windows.Forms.DialogResult.Yes Then

                ClearText()

                ChangePass_Load(Me, New System.EventArgs())
                HOME.btnRefresh.PerformClick()
                HOME.Show()

            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtOP.Text = MainClass.Library.Command.ExecScalar("SELECT UserPass from Users WHERE UserName='" & Login.txtUserN.Text & "'")

        pcbcheck.Visible = False
        pcberror.Visible = False
        pcbok.Visible = False
        pcbx.Visible = False

    End Sub

    Private Sub btnChangeP_Click(sender As Object, e As EventArgs) Handles btnChangeP.Click

        If txtOld.Text = "" Or txtNew.Text = "" Or txtConfirm.Text = "" Then
            MsgBox("Please COMPLETE ALL the DATA REQUIREMENTS", MsgBoxStyle.Critical, "Error")
            txtNew.Text = ""
            txtConfirm.Text = ""
        Else
            If pcbx.Visible = True Then
                MsgBox("OLD PASSWORD NOT MATCH", MsgBoxStyle.Critical, "Error")
            Else

                If txtNew.Text <> txtConfirm.Text Then
                    MsgBox("Password Not Match!!", MsgBoxStyle.Critical, "Error")
                    txtNew.Text = ""
                    txtConfirm.Text = ""
                    pcberror.Visible = True
                    pcbcheck.Visible = False
                    txtNew.Focus()

                Else
                    If Len(txtNew.Text) And Len(txtConfirm.Text) <= 5 Then
                        MsgBox("Password Too Short, Password must be at least 6 characters", MsgBoxStyle.Critical, "Error")
                        txtNew.Focus()
                        txtNew.Text = ""
                        txtConfirm.Text = ""

                    Else
                        If txtNew.Text = txtConfirm.Text AndAlso MsgBox("DO YOU WANT TO SAVE?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Change") = MsgBoxResult.Yes Then

                            MainClass.Library.Command.Execute("UPDATE Users SET UserPass='" & txtConfirm.Text & "' where UserName='" & Login.txtUserN.Text & "' ")

                            MsgBox("Password Successfully Changed", MsgBoxStyle.Information, "Message Box")

                            z = "1"
                            Me.Close()

                        Else

                            btnChangeP.Focus()

                        End If
                    End If
                End If
            End If
        End If
    End Sub

    'Private Sub txtOld_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOld.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '        And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '        And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '        And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '        And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNew.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '          And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '          And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '          And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '          And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtConfirm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConfirm.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '           And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '           And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '           And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '           And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

End Class