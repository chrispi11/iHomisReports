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

    'Fill Data of Pharmacy Items with COA Code
    Sub FillCosignmentSetupGrid(ByRef dgv As DataGridView,
                                ByRef txtSearch As TextBox)
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.CommandText = "select " +
                              "  COACODE, " +
                              "  DESCRIPTION, " +
                              "  UOM, " +
                              "  ITEMCODE " +
                              "from " +
                              "  VW_PHARMACY_COALIST "

            If txtSearch.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " where " +
                                                        "DESCRIPTION like @search"
            End If
            Dr = Cmd.ExecuteReader

            dgv.Rows.Clear()
            While Dr.Read
                dgv.Rows.Add(
                    Dr("COACODE"),
                    Dr("DESCRIPTION"),
                    Dr("UOM"),
                    Dr("ITEMCODE"))
                cntr = cntr + 1
            End While

            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd.Parameters.Clear()
            Con.Close()
        End Try
    End Sub
End Class
