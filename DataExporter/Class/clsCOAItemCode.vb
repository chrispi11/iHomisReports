Public Class clsCOAItemCode

    'Fill Data of Pharmacy Items with COA Code
    Sub FillPharmaCoaCodeGrid(ByRef dgv As DataGridView,
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

    Sub FillCSRCoaCodeGrid(ByRef dgv As DataGridView,
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
                              "  VW_CSR_COALIST "

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

    Function COAItemHasRows(ByVal itemcode As String) As Boolean
        Dim result As Boolean
        Try
            opencon()
            Cmd.Parameters.AddWithValue("@itemcode", itemcode)
            Cmd.CommandText = "select " +
                              "  * " +
                              "from " +
                              "  COA_ITEM " +
                              "where " +
                              "  ITEMCODE = @itemcode "

            Dr = Cmd.ExecuteReader

            If Dr.HasRows Then
                result = True
            Else
                result = False
            End If


            Cmd.Parameters.Clear()
            closecon()

        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd.Parameters.Clear()
            Con.Close()
        End Try
        Return result
    End Function

    Sub UpdateCoaCode(ByVal NewCode As String,
                             ByVal ItemCode As String)
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@newcode", NewCode)
            Cmd.Parameters.AddWithValue("@itemcode", ItemCode)
            Cmd.CommandText = "update COA_ITEM SET COACODE=@newcode WHERE ITEMCODE = @itemcode"
            Cmd.ExecuteNonQuery()

            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd.Parameters.Clear()
            Con.Close()
        End Try
    End Sub
End Class
