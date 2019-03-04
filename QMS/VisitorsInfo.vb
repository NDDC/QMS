Imports MainClass.Library

Public Class VisitorsInfo

    Public Sub ClearText()

        txtName.Text = ""
        txtCon.Text = ""
        txtReason.Text = ""

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtName.Text = "" Or txtCon.Text = "" Then
            MsgBox("Please Fill all the Required Data", MsgBoxStyle.Critical, "Incomplete Data Records")
        Else
            txtStatus.Text = "NEXT"

            Dim a = DateTime.Parse(Date.Today.ToLongDateString)
            Dim b = DateTime.Parse(TimeOfDay)

            lblDate.Text = a
            lblTime.Text = b

            MainClass.Library.Command.Execute("INSERT INTO VisitorsInfo (Name, Rank, POA, ContactNumber, Reason, Date, TimeIn, Status) VALUES ('" & txtName.Text & "','" & cbRank.Text & "','" & cbPOA.Text & "','" & txtCon.Text & "','" & txtReason.Text & "','" & lblDate.Text & "','" & lblTime.Text & "','" & txtStatus.Text & "')")

            MsgBox("Successfully ADDED to the Queing", MsgBoxStyle.Information, "On Queue")

            z = "1"

            'Me.Close()
            ClearText()

            VisitorsInfo_Load(Me, New System.EventArgs())
        End If

    End Sub

    Private Sub VisitorsInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If z = "1" Then
            ClearText()

            VisitorsInfo_Load(Me, New System.EventArgs())
            HomeView.btnRefresh.PerformClick()
            HomeView.Show()
        Else
            If MsgBox("Return to HOME?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CLOSE") = Windows.Forms.DialogResult.Yes Then

                ClearText()

                VisitorsInfo_Load(Me, New System.EventArgs())
                HomeView.btnRefresh.PerformClick()
                HomeView.Show()

            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub VisitorsInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtStatus.Text = "NEXT"

        ClearText()

        cbRank.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT * FROM Rank")
        cbRank.ValueMember = "RankCode"
        cbRank.DisplayMember = "RankDescription"

        cbPOA.DataSource = MainClass.Library.Adapter.GetRecordSet("SELECT FullName FROM Users where UserName !='admin'")
        cbPOA.ValueMember = "FullName"
        cbPOA.DisplayMember = "FullName"

    End Sub

    'Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '        And Asc(e.KeyChar) < 32 Or Asc(e.KeyChar) > 32 _
    '        And Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 46 _
    '        And Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 90 _
    '        And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 _
    '        And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtDateToReturn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDateToReturn.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '        And Asc(e.KeyChar) < 32 Or Asc(e.KeyChar) > 32 _
    '        And Asc(e.KeyChar) < 35 Or Asc(e.KeyChar) > 35 _
    '        And Asc(e.KeyChar) < 38 Or Asc(e.KeyChar) > 41 _
    '        And Asc(e.KeyChar) < 44 Or Asc(e.KeyChar) > 59 _
    '        And Asc(e.KeyChar) < 63 Or Asc(e.KeyChar) > 90 _
    '        And Asc(e.KeyChar) < 96 Or Asc(e.KeyChar) > 122 _
    '        And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCon.KeyPress
    '    If Asc(e.KeyChar) < 8 Or Asc(e.KeyChar) > 8 _
    '     And Asc(e.KeyChar) < 40 Or Asc(e.KeyChar) > 41 _
    '     And Asc(e.KeyChar) < 43 Or Asc(e.KeyChar) > 43 _
    '     And Asc(e.KeyChar) < 45 Or Asc(e.KeyChar) > 45 _
    '     And Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 _
    '     And Asc(e.KeyChar) < 127 Or Asc(e.KeyChar) > 127 Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class