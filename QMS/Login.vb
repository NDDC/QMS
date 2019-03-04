Imports MainClass.Library

Public Class Login

    Dim attempt As Short

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim UserName As String
        Dim dtUser As New DataTable
        Dim htParameters As New Hashtable
        htParameters.Add("UserName", txtUserN.Text)

        dtUser = MainClass.Library.Adapter.GetRecordSet(htParameters, "LoginSel")
        If dtUser.Rows.Count > 0 Then
            For Each row As DataRow In dtUser.Rows

                If row("UserName") = txtUserN.Text And row("UserPass") = txtPass.Text Then
                    UserName = row("UserName").ToString
                    txtUserT.Text = row("UserType").ToString
                    txtU.Text = row("FullName").ToString

                    If txtUserT.Text = "Admin" Then
                        MsgBox("Welcome Admin " + txtUserN.Text, MsgBoxStyle.Information, "Welcome")

                        AD()

                        txtUserN.Focus()
                        HOME.Show()
                        HOME.Enabled = True
                        Me.Hide()

                    ElseIf txtUserT.Text = "Guest" Then
                        MsgBox("Welcome Guest " + txtUserN.Text, MsgBoxStyle.Information, "Welcome")

                        GT()

                        HOME.Show()
                        HOME.Enabled = True
                        txtUserN.Focus()
                        Me.Hide()
                    End If

                Else
                    MsgBox("Username and Password Do not Match!", MsgBoxStyle.Critical, "WARNING")
                    attempt = attempt + 1
                    If attempt = 3 Then
                        MsgBox("Warning!!!! System will Shut Down", MsgBoxStyle.Critical, "WARNING")
                    ElseIf attempt = 5 Then
                        MsgBox("System Shut Down!!!!", MsgBoxStyle.Critical, "Unknown User")
                        End
                    End If
                End If
            Next
        Else
            MsgBox("Username and Password Do not Match!", MsgBoxStyle.Critical, "WARNING")
            attempt = attempt + 1
            If attempt = 3 Then
                MsgBox("Warning!!!! System will Shut Down", MsgBoxStyle.Critical, "WARNING")
            ElseIf attempt = 5 Then
                MsgBox("System Shut Down!!!!", MsgBoxStyle.Critical, "Unknown User")
                End
            End If
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        txtUserT.Text = ""
        txtU.Text = ""
        txtUserN.Text = ""
        txtPass.Text = ""
        Me.Refresh()
        HomeView.btnRefresh.PerformClick()
        HomeView.Show()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        attempt = 0

        txtUserT.Text = ""
        txtU.Text = ""
        txtUserN.Text = ""
        txtPass.Text = ""

    End Sub

    'Private Sub txtUserN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserN.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '       And Asc(e.KeyChar) = 32 _
    '       And Asc(e.KeyChar) = 46 _
    '       And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '       And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 _
    '       And Asc(e.KeyChar) = 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '            And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 _
    '            And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '            And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '            And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub GT()

    
    End Sub

    Private Sub AD()

    End Sub

End Class
