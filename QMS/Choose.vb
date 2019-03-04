Public Class Choose

    Private Sub btnPI_Click(sender As Object, e As EventArgs) Handles btnPI.Click

        HomeView.Show()
        Me.Hide()

    End Sub

    Private Sub btnQL_Click(sender As Object, e As EventArgs) Handles btnQL.Click

        VisitorsInfo.Show()
        Me.Hide()

    End Sub

    Private Sub Choose_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("EXIT?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CLOSE") = Windows.Forms.DialogResult.Yes Then

            End

        Else
            e.Cancel = True
        End If
    End Sub

End Class