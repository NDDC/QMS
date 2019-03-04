Public Class HomeView

    Private Sub HomeView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If MsgBox("EXIT?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CLOSE") = Windows.Forms.DialogResult.Yes Then

            End

        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub HomeView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DataGridView1.DefaultCellStyle.Font = New Font("Times New Roman", 15)

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoResizeColumns()

        DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM VisitorsInfo where Status='NEXT'")

        cbSearch.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT FullName FROM Users where UserName !='admin'")
        cbSearch.ValueMember = "FullName"
        cbSearch.DisplayMember = "FullName"

        DGV2LOAD()

        btnNext.Enabled = False
        btnLeave.Enabled = False

    End Sub

    Private Sub DGV2LOAD()
        Me.DataGridView2.DefaultCellStyle.Font = New Font("Times New Roman", 15)

        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView2.AutoResizeColumns()

        DataGridView2.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT VisitNum, Name, Rank, POA, TimeIn, Status FROM VisitorsInfo WHERE STATUS='BEING CALLED'")

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Login.Show()

        btnRefresh.PerformClick()

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        VisitorsInfo.Show()

        btnRefresh.PerformClick()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        HomeView_Load(Me, New System.EventArgs())

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblDate.Text = Date.Today.ToLongDateString
        lblTime.Text = TimeOfDay

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        Dim dtNExt As DataTable

        dtNExt = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM VisitorsInfo WHERE Status='BEING CALLED'")
        DataGridView2.DataSource = dtNExt
        If dtNExt.Rows.Count > 0 Then
            btnRefresh.PerformClick()
            MsgBox("A Visitor is BEING CALLED", MsgBoxStyle.Exclamation, "BEING CALLED")

        Else

            DGV2LOAD()

        End If

    End Sub

    Private Sub btnNext_Click_1(sender As Object, e As EventArgs) Handles btnNext.Click

        If MsgBox("Call Visitor " + txtName.Text + " " + txtPOA.Text + "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CALL") = MsgBoxResult.Yes Then

            Dim a = DateTime.Parse(txtTimeIn.Text)
            Dim b = DateTime.Parse(TimeOfDay)
            Dim c = b - a
            Dim d = DateTime.Parse(Date.Today)

            txtCalled.Text = b

            txtWaiting.Text = Math.Round(c.TotalMinutes, 2, MidpointRounding.AwayFromZero)

            txtWaiting.Text = txtWaiting.Text + " minutes"

            txtStatus.Text = "NOW SERVING"

            MainClass.Library.Command.Execute("UPDATE VisitorsInfo SET TimeCalled='" & txtCalled.Text & "', WaitingTime='" & txtWaiting.Text & "', Status='" & txtStatus.Text & "' where VisitNum='" & txtid.Text & "' ")

            MsgBox("Visitor " + txtName.Text + " Called")
            MsgBox("Please Proceed Imediately to " + txtPOA.Text, MsgBoxStyle.Information, "Message Box")

            btnRefresh.PerformClick()

            btnNext.Enabled = False

        Else

            btnNext.Enabled = False

        End If

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try
            Dim i As Integer
            i = DataGridView2.CurrentRow.Index
            txtid.Text = DataGridView2.Item(0, i).Value
            txtName.Text = DataGridView2.Item(1, i).Value
            txtRank.Text = DataGridView2.Item(2, i).Value
            txtPOA.Text = DataGridView2.Item(3, i).Value
            '   txtReason.Text = DataGridView2.Item(5, i).Value
            txtTimeIn.Text = DataGridView2.Item(4, i).Value.ToString
            txtStatus.Text = DataGridView2.Item(5, i).Value

            btnNext.Enabled = True
            btnLeave.Enabled = True


        Catch ex As Exception
        Finally
        End Try
    End Sub

    Private Sub btnLeave_Click(sender As Object, e As EventArgs) Handles btnLeave.Click

        If MsgBox("Visitor " + txtName.Text + " Already Left?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CALL") = MsgBoxResult.Yes Then

            txtStatus.Text = "LEAVE"

            Dim a = DateTime.Parse(Date.Today)

            MainClass.Library.Command.Execute("UPDATE VisitorsInfo SET Status='" & txtStatus.Text & "' where VisitNum='" & txtid.Text & "'")

            MsgBox("Visitor " + txtName.Text + " Left")
            btnRefresh.PerformClick()

            btnLeave.Enabled = False

        Else

            btnLeave.Enabled = False

        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim strSQL As String
        If cbSearch.Text.Length > 0 Then
            strSQL = "SELECT * FROM VisitorsInfo WHERE POA = '" & cbSearch.Text & "'"
            DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet(strSQL)
        Else
            strSQL = "SELECT * FROM VisitorsInfo"
            DataGridView1.DataSource = MainClass.Library.Adapter.GetRecordSet(strSQL)

        End If

    End Sub

End Class