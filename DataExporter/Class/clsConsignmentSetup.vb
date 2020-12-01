Public Class clsConsignmentSetup
    Sub FillConsCB(ByRef cbCons As ComboBox)
        Try
            opencon()
            Cmd.CommandText = "SELECT procdesc FROM hprocm ORDER BY procdesc"
            Dr = Cmd.ExecuteReader

            cbCons.Items.Add("")
            While Dr.Read
                cbCons.Items.Add(Dr.GetString(0))
            End While
            closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
            closecon()
        End Try
    End Sub

    Sub FillProcCode(ByRef txtCode As TextBox, ByVal txtParam As String)
        Try
            opencon()
            Cmd.CommandText = "SELECT proccode FROM hprocm where procdesc = '" & txtParam & "'"
            Dr = Cmd.ExecuteReader

            If Dr.Read Then
                txtCode.Text = Dr.GetString(0)
            End If
            closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
            closecon()
        End Try
    End Sub
End Class
