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

    Sub FillConsCBSearch(ByRef cbCons As ComboBox,
                         ByRef txtCode As TextBox)
        Try
            opencon()
            Cmd.Parameters.AddWithValue("@search", cbCons.Text)
            Cmd.CommandText = "select " +
                              "  PROCCODE " +
                              "from " +
                              "  hprocm " +
                              "where " +
                              "  PROCDESC = @search"
            Dr = Cmd.ExecuteReader

            If Dr.Read Then
                txtCode.Text = Dr("PROCCODE").ToString
            End If
            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
            closecon()
        End Try
    End Sub

    Sub FillProcCode(ByRef txtCode As TextBox,
                     ByRef rbAmount As RadioButton,
                     ByRef rbPercentage As RadioButton,
                     ByRef txtValue As TextBox,
                     ByVal txtParam As String)
        Try
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtParam + "%")
            Cmd.CommandText = "select " +
                              "  PROCCODE, " +
                              "  PROCDESC, " +
                              "  CONSVAL_ISPERCENT, " +
                              "  CONSVAL, " +
                              "  CONS_DATEFROM, " +
                              "  CONS_DATETO " +
                              "from " +
                              "  VW_PROCM_CONSIGNMENT " +
                              "where " +
                              "  PROCDESC like @search"
            Dr = Cmd.ExecuteReader

            If Dr.Read Then
                txtCode.Text = Dr("PROCCODE").ToString
                txtValue.Text = Dr("CONSVAL").ToString
                If Dr("CONSVAL_ISPERCENT").ToString = "0" Then
                    rbAmount.Checked = True
                Else
                    rbPercentage.Checked = True
                End If
            End If
            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
            closecon()
        End Try
    End Sub

    'Fill Data of Consignment Procedure with Value
    Sub FillProcConsignmentGrid(ByRef dgv As DataGridView,
                                ByRef txtSearch As TextBox)
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.CommandText = "select " +
                              "  PROCCODE, " +
                              "  PROCDESC, " +
                              "  CONSVAL_ISPERCENT, " +
                              "  CONSVAL, " +
                              "  CONS_DATEFROM, " +
                              "  CONS_DATETO " +
                              "from " +
                              "  VW_PROCM_CONSIGNMENT "

            If txtSearch.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " where " +
                                                        "PROCDESC like @search"
            End If
            Dr = Cmd.ExecuteReader

            dgv.Rows.Clear()
            While Dr.Read
                dgv.Rows.Add(
                    Dr("PROCCODE"),
                    Dr("PROCDESC"),
                    Dr("CONSVAL"),
                    Dr("CONSVAL_ISPERCENT"),
                    Dr("CONS_DATEFROM"),
                    Dr("CONS_DATETO"))
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

    Sub InsertConsDetails(ByVal proccode As String,
                          ByVal value As Decimal,
                          ByVal ispercent As Integer,
                          ByVal datefrom As Date,
                          ByVal dateto As Date)
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@proccode", proccode)
            Cmd.Parameters.AddWithValue("@value", value)
            Cmd.Parameters.AddWithValue("@ispercent", ispercent)
            Cmd.Parameters.AddWithValue("@datefrom", datefrom)
            Cmd.Parameters.AddWithValue("@dateto", dateto)
            Cmd.CommandText = "insert into " +
                              "  PROC_CONS " +
                              "values(@proccode, @value, @ispercent, @datefrom, @dateto)"
            Cmd.ExecuteNonQuery()

            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd.Parameters.Clear()
            Con.Close()
        End Try
    End Sub

    '----------------------------FUNCTION---------------------------------
    Function ConsignmentValueHasDateFrom(ByVal proccode As String) As Boolean
        Dim result As Boolean
        Try
            opencon()
            Cmd.Parameters.AddWithValue("@proccode", proccode)
            Cmd.CommandText = "select " +
                              "top 1 " +
                              "  CONS_DATEFROM " +
                              "from " +
                              "  PROC_CONS " +
                              "where " +
                              "  PROCCODE = @proccode " +
                              "ORDER BY " +
                              "CONS_DATEFROM "

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
End Class
