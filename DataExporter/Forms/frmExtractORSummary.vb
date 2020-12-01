
Public Class frmExtractORSummary
    Dim clsOrSummary As New clsOrSummary
    Dim clsDGVtoExcel As New clsDGVtoExcel

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            Me.Enabled = False
            clsOrSummary.FillORSummaryGrid(dgvOR_SUMMARY, _
                                          pbProgress, _
                                          dpDateFrom.Value, _
                                          dpDateTo.Value, _
                                          cbFilterBy, _
                                          txtSearch)
            pbProgress.Minimum = 1
            pbProgress.Value = 1
            Me.Enabled = True
            MsgBox("Retrieve " & pbProgress.Maximum & " Record/s.")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Con.Close()
        End Try
    End Sub

    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        clsDGVtoExcel.ExtractDGVtoExcel(dgvOR_SUMMARY, pbProgress)
    End Sub
End Class
