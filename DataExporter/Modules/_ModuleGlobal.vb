Module _ModuleGlobal
    Public CostCenter As Integer
    'Pharmacy - 1
    'CSR -2
    Public Sub callforms(ByVal frmname As System.Windows.Forms.Form, ByVal pnlname As System.Windows.Forms.Panel)
        frmname.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmname.TopLevel = False
        frmname.ShowInTaskbar = False
        frmname.Show()
        frmname.Dock = DockStyle.Fill
        pnlname.Controls.Clear()
        pnlname.Controls.Add(frmname)
    End Sub

    Public Function StrNullHandler(ByVal str As String)
        If IsDBNull(str) Then
            Return ""
        Else
            Return str
        End If
    End Function
End Module
