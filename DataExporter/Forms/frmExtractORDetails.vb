
Public Class frmExtractORDetails
    Dim clsOrDetails As New clsOrDetails
    Dim clsDGVtoExcel As New clsDGVtoExcel
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            Me.Enabled = False
            clsOrDetails.FillORDetalsGrid(dgvOR_DETAILS, _
                                          pbProgress, _
                                          dpDateFrom.Value.Date, _
                                          dpDateTo.Value.Date, _
                                          cbFilterBy, _
                                          txtSearch)
            pbProgress.Minimum = 1
            pbProgress.Value = 1
            Me.Enabled = True
            MsgBox("Retrieve " & dgvOR_DETAILS.RowCount & " Record/s.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Con.Close()
        End Try
    End Sub

    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        clsDGVtoExcel.ExtractDGVtoExcel_2(dgvOR_DETAILS, pbProgress)
    End Sub

    Private Sub cbFilterBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterBy.SelectedIndexChanged
        txtSearch.Focus()
    End Sub
End Class
