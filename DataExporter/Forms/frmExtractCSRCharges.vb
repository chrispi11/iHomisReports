'Programmer Name: Joenor Chris Pineda
'Date           : November, 2020
'Purpose        : List of Charges issued by CSR

Public Class frmExtractCSRCharges
    Dim clsCSRCharges As New clsCharges
    Dim clsDGVtoExcel As New clsDGVtoExcel

    '------------------------   Buttons   -------------------------------
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            clsCSRCharges.FillCSRChargesGrid(dgvCSR_Charges,
                                             pbProgress,
                                             dpDateFrom.Value.Date,
                                             dpDateTo.Value.Date,
                                             cbFilterBy,
                                             txtSearch,
                                             chkCons,
                                             chkCovid,
                                             chkReturns)
            pbProgress.Minimum = 0
            pbProgress.Value = 0
            Me.Enabled = True
            MsgBox("Retrieve " & dgvCSR_Charges.RowCount & " Record/s.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        Catch ex As Exception
            MsgBox(ex.ToString)
            Con.Close()
        End Try
        If dgvCSR_Charges.RowCount > 0 Then
            btnExtract.Enabled = True
            btnExtractCoa.Enabled = True
        Else
            btnExtract.Enabled = False
            btnExtractCoa.Enabled = False
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtractCOA.Click
        chkCons.Checked = True
        btnShow.PerformClick()
        clsDGVtoExcel.ExtractDGVtoCOAExcel(dgvCSR_Charges, pbProgress)
    End Sub

    Private Sub cbFilterBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterBy.SelectedIndexChanged
        txtSearch.Focus()
    End Sub

    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        clsDGVtoExcel.ExtractDGVtoExcel_2(dgvCSR_Charges, pbProgress)
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        clsCSRCharges.FillCSRChargesGrid(dgvCSR_Charges,
                                 pbProgress,
                                 dpDateFrom.Value.Date,
                                 dpDateTo.Value.Date,
                                 cbFilterBy,
                                 txtSearch,
                                 chkCons,
                                 chkCovid,
                                 chkReturns)
    End Sub

End Class
