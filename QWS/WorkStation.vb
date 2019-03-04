Public Class WorkStation

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblDate.Text = Date.Today.ToLongDateString
        lblTime.Text = TimeOfDay

    End Sub

    Private Sub WorkStation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If MsgBox("Logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "LOGOUT") = Windows.Forms.DialogResult.Yes Then
            Me.Refresh()
            Login1.Show()
            Login1.txtUserN.Text = ""
            Login1.txtPass.Text = ""
            Login1.txtUserN.Focus()

        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub WorkStation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Visible = True
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height

        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
            x = x - 1
            Me.Location = New Point(x, y)
        Loop

        cbSearch.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT FullName FROM Users where UserName !='admin'")
        cbSearch.ValueMember = "FullName"
        cbSearch.DisplayMember = "FullName"

        cbSearch.Text = "Select ..."

        LoadForm()

    End Sub

    Private Sub LoadForm()

        Me.DataGridView1.DefaultCellStyle.Font = New Font("Times New Roman", 12)

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoResizeColumns()

        ' DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT VisitNum, Name, POA, Status from VisitorsInfo WHERE Status='NEXT'")

        UType()

        NowServingHide()

        NextVisitorHide()

        DataGridView1.Enabled = True

    End Sub

    Private Sub NowServingHide()

        lblNow.Visible = False
        lblNameS.Visible = False
        lblNS.Visible = False
        'lblPOAs.Visible = False
        'lblPS.Visible = False
        btnDone.Visible = False

    End Sub

    Private Sub NowServingShow()

        lblNow.Visible = True
        lblNameS.Visible = True
        lblNS.Visible = True
        'lblPOAs.Visible = True
        'lblPS.Visible = True
        btnDone.Visible = True

        lblNS.Text = txtName.Text

    End Sub

    Private Sub NextVisitorHide()

        lblNext.Visible = False
        lblName.Visible = False
        lblNX.Visible = False
        'lblPOA.Visible = False
        'lblPX.Visible = False
        btnCall.Visible = False

    End Sub

    Private Sub NextVisitorShow()

        lblNext.Visible = True
        lblName.Visible = True
        lblNX.Visible = True
        'lblPOA.Visible = True
        'lblPX.Visible = True
        btnCall.Visible = True

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        Dim bb = MainClass.Library.Command.ExecScalar("SELECT Status from VisitorsInfo WHERE VisitNum='" & txtid.Text & "'")

        If bb = "LEAVE" Then
            MsgBox("Visitor " + txtName.Text + " Already Left," + " Please Call Another Visitor", MsgBoxStyle.Information, "Message Box")

            txtid.Text = ""

            LoadForm()

            DataGridView1.Enabled = True
        Else
            If MsgBox("Done with your Visitor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "DONE?") = MsgBoxResult.Yes Then
                Dim aa = MainClass.Library.Command.ExecScalar("SELECT TimeCalled from VisitorsInfo WHERE VisitNum='" & txtid.Text & "'")
                aa = "11:22:00"
                Dim a = DateTime.Parse(aa.ToString)
                Dim b = DateTime.Parse(TimeOfDay)

                Dim c = b - a


                txtServing.Text = Math.Round(c.TotalMinutes, 2, MidpointRounding.AwayFromZero)

                txtServing.Text = txtServing.Text + " minutes"

                txtTimeOut.Text = b

                txtStatus.Text = "DONE"

                MainClass.Library.Command.Execute("UPDATE VisitorsInfo SET TimeOut='" & txtTimeOut.Text & "', ServingTime='" & txtServing.Text & "', Status='" & txtStatus.Text & "' where VisitNum='" & txtid.Text & "'")

                MsgBox("Thank You", MsgBoxStyle.Information, "Message Box")

                LoadForm()

                NextVisitorHide()

                NowServingHide()

                btnLogout.Enabled = True

            Else

                NowServingShow()

            End If
        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If Login1.txtUserT.Text = "Admin" Then
            NowServingHide()
            NextVisitorHide()
        ElseIf Login1.txtUserT.Text = "Guest" Then

            Try
                Dim i As Integer
                i = DataGridView1.CurrentRow.Index
                txtid.Text = DataGridView1.Item(0, i).Value
                txtName.Text = DataGridView1.Item(1, i).Value
                txtRank.Text = DataGridView1.Item(2, i).Value
                'txtPOA.Text = DataGridView1.Item(3, i).Value
                'txtCon.Text = DataGridView1.Item(4, i).Value
                txtReason.Text = DataGridView1.Item(5, i).Value
                'txtDate.Text = DataGridView1.Item(6, i).Value
                'txtTimeIn.Text = DataGridView1.Item(7, i).Value.ToString
                'txtCalled.Text = DataGridView1.Item(8, i).Value.ToString
                'txtTimeOut.Text = DataGridView1.Item(9, i).Value.ToString
                'txtWaiting.Text = DataGridView1.Item(10, i).Value
                'txtServing.Text = DataGridView1.Item(11, i).Value
                txtStatus.Text = DataGridView1.Item(12, i).Value

                lblNX.Text = txtName.Text
                lblPX.Text = txtPOA.Text
                NextVisitorShow()

            Catch ex As Exception
            Finally
            End Try

        End If
    End Sub

    Private Sub btnCall_Click(sender As Object, e As EventArgs) Handles btnCall.Click
        Dim bb = MainClass.Library.Command.ExecScalar("SELECT Status from VisitorsInfo WHERE VisitNum='" & txtid.Text & "'")

        If bb = "LEAVE" Then
            MsgBox("Visitor " + txtName.Text + " Already Left," + " Please Call Another Visitor", MsgBoxStyle.Information, "Message Box")

        ElseIf MsgBox("Call Next Visitor?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CALL") = MsgBoxResult.Yes Then

            Dim a = DateTime.Parse(Date.Today)

            txtStatus.Text = "BEING CALLED"

            MainClass.Library.Command.Execute("UPDATE VisitorsInfo SET Status='" & txtStatus.Text & "' where VisitNum='" & txtid.Text & "'")

            MsgBox("Visitor " + txtName.Text + " Called")

            DataGridView1.Enabled = False

            NowServingShow()

            NextVisitorHide()

            btnLogout.Enabled = False

        Else

            LoadForm()

        End If


    End Sub

    'Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    '    UType()
    '    DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM VisitorsInfo WHERE POA= '" & Login1.txtU.Text & "' and Status='NEXT' ")

    '    DGView()
    'End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

        Dim bb = MainClass.Library.Command.ExecScalar("SELECT Status from VisitorsInfo WHERE VisitNum='" & txtid.Text & "'")

        If bb = "LEAVE" Then
            MsgBox("Visitor " + txtName.Text + " Already Left," + " Please Call Another Visitor", MsgBoxStyle.Information, "Message Box")

            txtid.Text = ""

            LoadForm()

            DataGridView1.Enabled = True

        End If

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        LoadForm()

    End Sub

    Private Sub UType()

        If Login1.txtUserT.Text = "Admin" Then

            'If cmbSearch.SelectedValue Is Nothing Then
            '    DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM VisitorsInfo")
            'Else
            '    DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM VisitorsInfo AND POA ='" & cmbSearch.SelectedValue & "'") Then

            'End If

            DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM VisitorsInfo")

            NowServingHide()
            NextVisitorHide()

        ElseIf Login1.txtUserT.Text = "Guest" Then

            DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM VisitorsInfo WHERE POA= '" & Login1.txtU.Text & "' and Status='NEXT' ")

            DGView()

        End If

    End Sub

    Private Sub DGView()

        Me.DataGridView1.Columns(0).Visible = False
        Me.DataGridView1.Columns(3).Visible = False
        Me.DataGridView1.Columns(4).Visible = False
        ' Me.DataGridView1.Columns(5).Visible = False
        Me.DataGridView1.Columns(6).Visible = False
        Me.DataGridView1.Columns(7).Visible = False
        Me.DataGridView1.Columns(8).Visible = False
        Me.DataGridView1.Columns(9).Visible = False
        Me.DataGridView1.Columns(10).Visible = False
        Me.DataGridView1.Columns(11).Visible = False
        Me.DataGridView1.Columns(12).Visible = False

    End Sub

    'Private Sub cbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSearch.SelectedIndexChanged

    '    Dim strSQL As String
    '    If cbSearch.Text.Length > 0 Then
    '        strSQL = "SELECT * FROM VisitorsInfo WHERE POA = '" & cbSearch.Text & "'"
    '        DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet(strSQL)
    '        ' Timer4.Enabled = False
    '    Else
    '        strSQL = "SELECT * FROM VisitorsInfo"
    '        DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet(strSQL)
    '        ' Timer4.Enabled = False
    '    End If

    'End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        UType()
        DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM VisitorsInfo WHERE POA= '" & Login1.txtU.Text & "' and Status='NEXT' ")

        DGView()
    End Sub
End Class