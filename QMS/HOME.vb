Imports System.Windows.Forms
Imports MainClass.Library

Public Class HOME

    Private Sub HOME_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If z = "1" Then
            If MsgBox("Do you want to Exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "EXIT") = MsgBoxResult.Yes Then
                Login.txtUserT.Text = ""
                Login.txtU.Text = ""
                Login.txtUserN.Text = ""
                Login.txtPass.Text = ""
                Me.Refresh()

                HomeView.Show()
            End If
        Else
            If MsgBox("Logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "LOGOUT") = Windows.Forms.DialogResult.Yes Then
                Login.txtUserT.Text = ""
                Login.txtU.Text = ""
                Login.txtUserN.Text = ""
                Login.txtPass.Text = ""
                Me.Refresh()
                Login.Show()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub HOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Times New Roman", 15)

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoResizeColumns()

        DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM VisitorsInfo")
       
        Account()

    End Sub

    Private Sub Account()

        txtUsern.Text = Login.txtUserN.Text

        DataGridView2.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM Users WHERE UserName='" & txtUsern.Text & "'")

        Try
            Dim i As Integer
            txtUserID.Text = DataGridView2.Item(0, i).Value
            txtUT.Text = DataGridView2.Item(1, i).Value
            txtUsern.Text = DataGridView2.Item(2, i).Value
            txtName.Text = DataGridView2.Item(4, i).Value
            txtAdd.Text = DataGridView2.Item(5, i).Value
            txtMS.Text = DataGridView2.Item(6, i).Value
            txtContact.Text = DataGridView2.Item(7, i).Value
            txteadd.Text = DataGridView2.Item(8, i).Value

        Catch ex As Exception
        Finally
        End Try

        If txtUT.Text = "Admin" Then
            AD()
        ElseIf txtUT.Text = "Guest" Then
            GT()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        HOME_Load(Me, New System.EventArgs())

    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click

        Me.Close()

    End Sub

    Private Sub CreateNewUser_Click(sender As Object, e As EventArgs) Handles CreateNewUser.Click

        CreateUser.Show()
        Me.Hide()

    End Sub

    Private Sub ViewUser_Click(sender As Object, e As EventArgs) Handles ViewUser.Click

        ViewUser1.Show()
        Me.Hide()

    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click

        ChangePass.Show()
        Me.Hide()

    End Sub

    Private Sub GT()

    End Sub

    Private Sub AD()

    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        z = "1"
        Me.Close()

    End Sub

    Private Sub VisitorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VisitorToolStripMenuItem1.Click

        ReportsVisitors.Show()
        Me.Hide()

    End Sub

End Class
