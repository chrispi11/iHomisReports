'Programmer Name: Joenor Chris Pineda
'Date           : November, 2020
'Purpose        : List of Charges issued by Pharmacy

Public Class frmExtractPharmacyCharges
    Dim clsPharmaCharges As New clsCharges
    Dim clsDGVtoExcel As New clsDGVtoExcel


    '------------------------   Buttons   -------------------------------
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            If tabPharmacy.SelectedTab.Text = "Issued" Then
                clsPharmaCharges.FillPharmaIssuedGrid(dgvPharma_Issued,
                                                      pbProgress,
                                                      dpDateFrom.Value.Date,
                                                      dpDateTo.Value.Date,
                                                      cbSearchBy,
                                                      cbFilterBy,
                                                      txtSearch,
                                                      chkCons,
                                                      chkCovid,
                                                      chkEP,
                                                      chkNoCoaCode)
                MsgBox("Retrieve " & dgvPharma_Issued.RowCount & " Record/s.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            ElseIf tabPharmacy.SelectedTab.Text = "Charges" Then
                clsPharmaCharges.FillPharmaChargesGrid(dgvPharma_Charges,
                                                      pbProgress,
                                                      dpDateFrom.Value.Date,
                                                      dpDateTo.Value.Date,
                                                      cbSearchBy,
                                                      cbFilterBy,
                                                      txtSearch,
                                                      chkCons,
                                                      chkCovid,
                                                      chkEP,
                                                      chkNoCoaCode)
                MsgBox("Retrieve " & dgvPharma_Charges.RowCount & " Record/s.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            ElseIf tabPharmacy.SelectedTab.Text = "Item Summary" Then
                clsPharmaCharges.FillPharmaItemSummaryGrid(dgv_ItemSummary,
                                                           dpDateFrom.Value.Date,
                                                           dpDateTo.Value.Date,
                                                           cbFilterBy,
                                                           txtSearch,
                                                           chkCons,
                                                           chkCovid,
                                                           chkEP)
                MsgBox("Retrieve " & dgv_ItemSummary.RowCount & " Record/s.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            End If

            pbProgress.Minimum = 0
            pbProgress.Value = 0
            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Con.Close()
        End Try
        If dgvPharma_Issued.RowCount > 0 Then
            btnExtract.Enabled = True
            If cbSearchBy.Text = "" Then
                btnExtractCoa.Enabled = True
            End If
        Else
            btnExtract.Enabled = False
            btnExtractCoa.Enabled = False
        End If
    End Sub

    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        clsDGVtoExcel.ExtractDGVtoExcel_2(dgvPharma_Issued,
                                          pbProgress)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtractCoa.Click
        chkCons.Checked = True
        chkEP.Checked = True
        chkNoCoaCode.Checked = True
        btnShow.PerformClick()
        clsDGVtoExcel.ExtractDGVtoCOAExcel(dgvPharma_Issued,
                                           pbProgress)
    End Sub

    '------------------------   Events   -------------------------------

    Private Sub cbFilterBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterBy.SelectedIndexChanged
        txtSearch.Focus()
    End Sub

    Private Sub cbSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSearchBy.SelectedIndexChanged
        If cbSearchBy.Text <> "" Then
            btnExtractCoa.Enabled = False
        Else
            btnExtractCoa.Enabled = True
        End If
    End Sub
End Class
