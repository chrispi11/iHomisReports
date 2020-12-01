Public Class frmConsignment
    Dim clsCons As New clsConsignmentSetup
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbConsignment.SelectedIndexChanged
        clsCons.FillProcCode(txtCode, cbConsignment.Text)
    End Sub

    Private Sub frmConsignment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clsCons.FillConsCB(cbConsignment)
    End Sub

End Class