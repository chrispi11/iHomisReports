'Programmer Name: Joenor Chris Pineda
'Date           : November, 2020
'Purpose        : Modify Item from iHomis with its corresponding item code from COA

Public Class frmCOACode
    Dim clsCoa As New clsCOAItemCode
    Public Sub frmCOA_Load(ByVal sender As System.Object,
                           ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Shown
        EnableButton(True, False, True, False)
        SearchCoaCode()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object,
                                ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchCoaCode()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object,
                             ByVal e As System.EventArgs) Handles btnAdd.Click
        'txtDescription.Enabled = True
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnEdit.Click
        txtCoaCode.Enabled = True
        txtCoaCode.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) Handles btnSave.Click
        If clsCoa.COAItemHasRows(txtItemCode.Text) = True Then
            clsCoa.UpdateCoaCode(txtCoaCode.Text, txtItemCode.Text)
        Else
            MsgBox("Not yet Added!")
        End If
        'MsgBox("Are you sure you want to logout?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "LogOut Confirmation")
        MsgBox("Successfully Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "")
        SearchCoaCode()
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        SearchCoaCode()
        DisplayRowToTextbox(dgv_COACode.SelectedRows(0))
    End Sub

    Private Sub dgv_COACode_CellClick(ByVal sender As System.Object,
                                      ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_COACode.CellClick
        Dim row As DataGridViewRow = dgv_COACode.Rows(e.RowIndex)
        DisplayRowToTextbox(row)
    End Sub

    Private Sub dgv_COACode_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dgv_COACode.KeyUp
        DisplayRowToTextbox(dgv_COACode.SelectedRows(0))
    End Sub

    '--------------------Private Function-------------------------------------
    Private Sub DisplayRowToTextbox(ByVal row As DataGridViewRow)
        EnableButton(True, True, True, False)
        txtCoaCode.Text = row.Cells(0).Value.ToString
        txtDescription.Text = row.Cells(1).Value.ToString + " " + row.Cells(2).Value.ToString
        txtItemCode.Text = row.Cells(3).Value.ToString
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

    Private Sub SearchCoaCode()
        dgv_COACode.Rows.Clear()
        dgv_COACode.Refresh()
        If CostCenter = 1 Then
            clsCoa.FillPharmaCoaCodeGrid(dgv_COACode, txtSearch)
        ElseIf CostCenter = 2 Then
            clsCoa.FillCSRCoaCodeGrid(dgv_COACode, txtSearch)
        End If
    End Sub

End Class