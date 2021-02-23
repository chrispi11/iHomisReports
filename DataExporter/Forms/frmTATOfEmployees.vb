'Programmer Name: Joenor Chris Pineda
'Date           : February, 2021
'Purpose        : TAT of Employees

Public Class frmTATofEmployees
    Dim clsTAT As New clsTATOfEmployees
    Dim clsDGVtoExcel As New clsDGVtoExcel

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            If tabTAT.SelectedTab.Text = "Detail" Then
                clsTAT.FillPTATDetailsGrid(dgvTAT,
                                           pbProgress,
                                           dpDateFrom.Value.Date,
                                           dpDateTo.Value.Date,
                                           cbFilterBy,
                                           txtSearch)
                MsgBox("Retrieve " & dgvTAT.RowCount & " Record/s.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            ElseIf tabTAT.SelectedTab.Text = "Summary" Then

            End If
            pbProgress.Minimum = 0
            pbProgress.Value = 0
            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Con.Close()
        End Try
        If dgvTAT.RowCount > 0 Then
            btnExtract.Enabled = True
        Else
            btnExtract.Enabled = False
        End If
    End Sub

    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        clsDGVtoExcel.ExtractDGVtoExcel_2(dgvTAT, pbProgress)
    End Sub
End Class
