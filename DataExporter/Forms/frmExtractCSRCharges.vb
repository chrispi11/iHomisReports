'Programmer Name: Joenor Chris Pineda
'Date           : November, 2020
'Purpose        : List of Charges issued by CSR

Public Class frmExtractCSRCharges
    Dim clsCSRCharges As New clsCharges
    Dim clsDGVtoExcel As New clsDGVtoExcel

    '------------------------   Buttons   -------------------------------
    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Try
            If tabCSR.SelectedTab.Text = "Issued" Then
                clsCSRCharges.FillCSRIssuedGrid(dgvCSR_Issued,
                                 pbProgress,
                                 dpDateFrom.Value.Date,
                                 dpDateTo.Value.Date,
                                 cbSearchBy,
                                 cbFilterBy,
                                 txtSearch,
                                 chkCons,
                                 chkCovid,
                                 chkNoCoaCode)
                MsgBox("Retrieve " & dgvCSR_Issued.RowCount & " Record/s.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            ElseIf tabCSR.SelectedTab.Text = "Charges" Then
                clsCSRCharges.FillCSRChargesGrid(dgvCSR_Charges,
                                 pbProgress,
                                 dpDateFrom.Value.Date,
                                 dpDateTo.Value.Date,
                                 cbSearchBy,
                                 cbFilterBy,
                                 txtSearch,
                                 chkCons,
                                 chkCovid,
                                 chkNoCoaCode)
                MsgBox("Retrieve " & dgvCSR_Charges.RowCount & " Record/s.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
            End If
            pbProgress.Minimum = 0
            pbProgress.Value = 0
            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Con.Close()
        End Try
        If dgvCSR_Issued.RowCount > 0 Then
            btnExtract.Enabled = True
            If cbSearchBy.Text = "" Then
                btnExtractCOA.Enabled = True
            End If
        Else
            btnExtract.Enabled = False
            btnExtractCoa.Enabled = False
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtractCOA.Click
        chkCons.Checked = True
        chkNoCoaCode.Checked = True
        btnShow.PerformClick()
        clsDGVtoExcel.ExtractDGVtoCOAExcel(dgvCSR_Issued, pbProgress)
    End Sub

    '------------------------   Events   -------------------------------

    Private Sub cbFilterBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFilterBy.SelectedIndexChanged
        txtSearch.Focus()
    End Sub

    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        clsDGVtoExcel.ExtractDGVtoExcel_2(dgvCSR_Issued, pbProgress)
    End Sub

    Private Sub cbSearchBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSearchBy.SelectedIndexChanged
        If cbSearchBy.Text <> "" Then
            btnExtractCOA.Enabled = False
        Else
            btnExtractCOA.Enabled = True
        End If
    End Sub
End Class
