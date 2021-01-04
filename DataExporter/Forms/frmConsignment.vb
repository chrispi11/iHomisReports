Public Class frmConsignment
    Dim clsCons As New clsConsignmentSetup
    Private Sub cbConsignment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbConsignment.SelectedIndexChanged
        clsCons.FillConsCBSearch(cbConsignment, txtCode)
    End Sub

    Private Sub frmConsignment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsCons.FillConsCB(cbConsignment)
        clsCons.FillProcConsignmentGrid(dgvProc, txtSearch)
    End Sub

    Private Sub dgvProc_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProc.CellClick
        DisplayRowToTextbox(dgvProc.SelectedRows(0))
    End Sub

    Private Sub dgvProc_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgvProc.KeyUp
        DisplayRowToTextbox(dgvProc.SelectedRows(0))
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        MsgBox(clsCons.ConsignmentValueHasDateFrom(txtCode.Text))
        txtValue.Enabled = False
        cbConsignment.Enabled = False
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        txtValue.Enabled = True
        cbConsignment.Enabled = True
    End Sub

    '--------------------Private Function-------------------------------------
    Private Sub DisplayRowToTextbox(ByVal row As DataGridViewRow)
        EnableButton(True, False, True, False)
        txtCode.Text = row.Cells(0).Value.ToString
        cbConsignment.Text = row.Cells(1).Value.ToString
        txtValue.Text = row.Cells(2).Value.ToString
        If row.Cells(3).Value.ToString = "0" Then
            rbAmount.Checked = True
        Else
            rbPercentage.Checked = True
        End If
    End Sub

    Private Sub EnableButton(ByVal boolAdd As Boolean,
                             ByVal boolEdit As Boolean,
                             ByVal boolSearch As Boolean,
                             ByVal boolDelete As Boolean)
        btnAdd.Enabled = boolAdd
        btnEdit.Enabled = boolEdit
        btnSearch.Enabled = boolSearch
        btnDelete.Enabled = boolDelete
    End Sub
End Class