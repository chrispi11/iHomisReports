Public Class clsOrDetails

    Sub FillORDetalsGrid(ByRef dgvOR_Details As DataGridView,
                         ByRef prg As ProgressBar,
                         ByVal DateFrom As Date,
                         ByVal DateTo As Date,
                         ByRef cbFilter As ComboBox,
                         ByRef txtSearch As TextBox)
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.CommandText = "select * from VW_ORDETAILS " & _
                              "where " & _
                                "OR_DATE " & _
                              "between " & _
                                "'" & DateFrom & "'" & _
                              " and " & _
                                 "'" & DateTo.AddDays(1) & "'"

            If cbFilter.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " & _
                            cbFilter.Text & " like " & _
                            "@search"
            End If
            Dr = Cmd.ExecuteReader

            dgvOR_Details.Rows.Clear()
            While Dr.Read
                dgvOR_Details.Rows.Add( _
                    Dr("HOSPITAL_NO"), _
                    Dr("OR_NO"), _
                    Dr("OR_DATE"), _
                    Dr("ITEMDESC"), _
                    Dr("ACCT_DESC"), _
                    Dr("AMOUNT"), _
                    Dr("CONSIGNMENT"), _
                    Dr("HOSP_INC"), _
                    Dr("PAYREM"), _
                    Dr("PATIENT_NAME"), _
                    Dr("CASHIER"))
                cntr = cntr + 1
            End While

            prg.Maximum = cntr
            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Con.Close()
        End Try
    End Sub

End Class
