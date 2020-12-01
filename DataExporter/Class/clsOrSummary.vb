Public Class clsOrSummary

    Sub FillORSummaryGrid(ByRef dgvOR_Details As DataGridView, ByRef prg As ProgressBar, ByVal DateFrom As Date, ByVal DateTo As Date, ByRef cbFilter As ComboBox, ByRef txtSearch As TextBox)
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.CommandText = "select " & _
                                "ACCOUNT_NO, " & _
                                "ENCOUNTER, " & _
                                "HOSPITAL_NO, " & _
                                "PATIENT_NAME, " & _
                                "OR_NO, " & _
                                "OR_DATE, " & _
                                "sum(AMOUNT) AMOUNT, " & _
                                "ENCTR_DATE, " & _
                                "ADM_DATE, " & _
                                "DIS_DATE " & _
                              "from VW_ORDETAILS " & _
                              "where " & _
                                "OR_DATE " & _
                              "between " & _
                                "'" & DateFrom & "'" & _
                              " and " & _
                                 "'" & DateTo & "'"

            If cbFilter.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " & _
                            cbFilter.Text & " like " & _
                            "@search"
            End If

            Cmd.CommandText = Cmd.CommandText & _
                    " group by " & _
                    "   OR_NO," & _
                    "   OR_DATE," & _
                    "   ACCOUNT_NO," & _
                    "   ENCOUNTER," & _
                    "   ENCTR_DATE," & _
                    "   ADM_DATE," & _
                    "   DIS_DATE," & _
                    "   HOSPITAL_NO," & _
                    "   PATIENT_NAME"
            Dr = Cmd.ExecuteReader

            dgvOR_Details.Rows.Clear()
            While Dr.Read
                dgvOR_Details.Rows.Add( _
                    Dr("ACCOUNT_NO"), _
                    Dr("OR_NO"), _
                    Dr("OR_DATE"), _
                    Dr("ENCOUNTER"), _
                    Dr("HOSPITAL_NO"), _
                    Dr("PATIENT_NAME"), _
                    Dr("ENCTR_DATE"), _
                    Dr("ADM_DATE"), _
                    Dr("DIS_DATE"), _
                    Dr("AMOUNT"))
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
