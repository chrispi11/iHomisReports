Public Class clsTATOfEmployees

    Sub FillPTATDetailsGrid(ByRef dgvTAT As DataGridView,
                            ByRef prg As ProgressBar,
                            ByVal DateFrom As Date,
                            ByVal DateTo As Date,
                            ByRef cbFilter As ComboBox,
                            ByRef txtSearch As TextBox)
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.Parameters.AddWithValue("@x", "x")
            Cmd.CommandText = "select * from VW_TAT " &
                              "where " &
                                "NOTIFYDATE " &
                              "between " &
                                "'" & DateFrom & "'" &
                              " and " &
                                 "'" & DateTo.AddDays(1) & "'" &
                              " and " &
                                "  CLEARDATE is not null"

            If cbFilter.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                             cbFilter.Text & " like " &
                             "@search"
            End If


            Dr = Cmd.ExecuteReader

            dgvTAT.Rows.Clear()
            While Dr.Read
                With dgvTAT
                    .Rows.Add(
                    Dr("HOSPITAL_NO"),
                    Dr("PATIENT_NAME"),
                    Dr("SECTION"),
                    Dr("EMPLOYEE"),
                    Dr("NOTIFYDATE"),
                    Dr("CLEARDATE"),
                    Dr("DIFF"),
                    Dr("REMARKS"))
                    cntr = cntr + 1
                End With
            End While

            prg.Maximum = cntr
            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Cmd.Parameters.Clear()
            Con.Close()
        End Try
    End Sub


End Class
