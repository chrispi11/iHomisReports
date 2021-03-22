'Programmer Name: Joenor Chris Pineda
'Date           : February, 2021
'Purpose        : TAT of Employees

Public Class frmTATofEmployees
    Dim clsTAT As New clsTATOfEmployees
    Dim clsDGVtoExcel As New clsDGVtoExcel

    Private Sub frmTATofEmployees_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbGroup.Text = "SECTION"
    End Sub

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
                If cbGroup.Text = "" Then
                    MsgBox("Please Select Group By!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "")
                    cbGroup.Focus()
                Else
                    clsTAT.FillPTATSummaryGrid(dgvTATSummary,
                                               pbProgress,
                                               dpDateFrom.Value.Date,
                                               dpDateTo.Value.Date,
                                               cbGroup,
                                               rbDays)
                    AddTotalDH(dgvTATSummary)
                    MsgBox("Retrieve " & dgvTATSummary.RowCount & " Record/s.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
                End If
            End If
            pbProgress.Minimum = 0
            pbProgress.Value = 0
            Me.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString)
            Con.Close()
        End Try
        If dgvTAT.RowCount > 0 Or dgvTATSummary.RowCount > 0 Then
            btnExtract.Enabled = True
        Else
            btnExtract.Enabled = False
        End If
    End Sub

    Private Sub btnExtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExtract.Click
        If tabTAT.SelectedTab.Text = "Detail" Then
            clsDGVtoExcel.ExtractDGVtoExcel_2(dgvTAT, pbProgress)
        ElseIf tabTAT.SelectedTab.Text = "Summary" Then
            clsDGVtoExcel.ExtractDGVtoExcel_2(dgvTATSummary, pbProgress)
        End If
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        For Each row As DataGridViewRow In dgvTATSummary.SelectedRows
            dgvTATSummary.Rows.Remove(row)
        Next
        dgvTATSummary.Rows.Remove(dgvTATSummary.Rows(dgvTATSummary.RowCount - 1))
        AddTotalDH(dgvTATSummary)
    End Sub

    Private Sub AddTotalDH(ByRef dgv As DataGridView)
        Dim cntr As Integer = 0
        Dim max As Integer = 0
        Dim avgdh As Decimal = 0

        For row As Integer = 0 To dgv.RowCount - 1
            If max < dgv.Rows(row).Cells(1).Value Then
                max = dgv.Rows(row).Cells(1).Value
            End If
            cntr = cntr + dgv.Rows(row).Cells(1).Value
            avgdh = avgdh + dgv.Rows(row).Cells(5).Value
        Next

        With dgv
            .Rows.Add(
            "TOTAL DH",
            max,
            Math.Round(avgdh / cntr, 2),
            Math.Round((avgdh / cntr) / max, 2),
            Math.Round(avgdh, 2))
            cntr = cntr + 1
        End With
        ' pxcount = pxcount + Dr("PATIENT_COUNT")
        ' avgdh = avgdh + Math.Round(Dr("PATIENT_COUNT") * Val(), 2)
    End Sub
End Class
