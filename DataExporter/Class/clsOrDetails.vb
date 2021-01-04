Public Class clsOrDetails

    Sub FillORDetalsGrid(ByRef dgvOR_Details As DataGridView,
                         ByRef prg As ProgressBar,
                         ByVal DateFrom As Date,
                         ByVal DateTo As Date,
                         ByRef cbFilter As ComboBox,
                         ByRef txtSearch As TextBox)
        Try
            Dim cntr As Integer = 0
            Dim TotalAmount As Decimal = 0
            Dim TotalConsignment As Decimal = 0
            Dim TotalHospInc As Decimal = 0
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
                If Not IsDBNull(Dr("CONSIGNMENT")) And Not IsDBNull(Dr("HOSP_INC")) Then
                    TotalConsignment = TotalConsignment + Decimal.Parse(Dr("CONSIGNMENT"))
                    TotalHospInc = TotalHospInc + Decimal.Parse(Dr("HOSP_INC"))
                End If
                TotalAmount = TotalAmount + Decimal.Parse(Dr("AMOUNT"))
                dgvOR_Details.Rows.Add(
                    Dr("HOSPITAL_NO"),
                    Dr("OR_NO"),
                    Dr("OR_DATE"),
                    Dr("ITEMDESC"),
                    Dr("ACCT_DESC"),
                    Dr("AMOUNT"),
                    Dr("CONSIGNMENT"),
                    Dr("HOSP_INC"),
                    Dr("PAYREM"),
                    Dr("PATIENT_NAME"),
                    Dr("CASHIER"))
                cntr = cntr + 1
            End While
            dgvOR_Details.Rows.Add(
                "",
                "",
                "",
                "",
                "TOTAL",
                TotalAmount,
                TotalConsignment,
                TotalHospInc,
                "",
                "",
                "")
            prg.Maximum = cntr
            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Con.Close()
        End Try
    End Sub

End Class
