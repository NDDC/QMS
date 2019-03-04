Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient
Imports System.Data

Public Class ReportsVisitors

    Private Sub ReportsVisitors_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Return to HOME?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CLOSE") = Windows.Forms.DialogResult.Yes Then

            ReportsVisitors_Load(Me, New System.EventArgs())
            HOME.btnRefresh.PerformClick()
            HOME.Show()

        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ReportsVisitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        ReportsVisitors_Load(Me, New System.EventArgs())
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Me.VisitorsInfoTableAdapter.Fill(Me.QMSDataSet.VisitorsInfo, dtpS.Text, dtpE.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class