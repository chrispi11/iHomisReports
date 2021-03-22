Public Class clsCharges

    Sub FillPharmaIssuedGrid(ByRef dgvPharma_Charges As DataGridView,
                              ByRef prg As ProgressBar,
                              ByVal DateFrom As Date,
                              ByVal DateTo As Date,
                              ByRef cbSearchBy As ComboBox,
                              ByRef cbFilter As ComboBox,
                              ByRef txtSearch As TextBox,
                              ByRef chkCons As CheckBox,
                              ByRef chkCovid As CheckBox,
                              ByRef chkEP As CheckBox,
                              ByRef chkReturns As CheckBox)
        Dim Qty, ReturnedQty As Integer
        Dim UnitPrice, SellingPrice As Decimal
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.Parameters.AddWithValue("@searchby", "%" + cbSearchBy.Text + "%")
            Cmd.Parameters.AddWithValue("@x", "x")
            Cmd.CommandText = "select * from VW_PHARMACY_ISSUED " &
                              "left join " &
                              "  COA_ITEM on" &
                              "  COA_ITEM.ITEMCODE = VW_PHARMACY_ISSUED.ITEM_CODE " &
                              "where " &
                                "ISSUEDTE " &
                              "between " &
                                "'" & DateFrom & "'" &
                              " and " &
                                 "'" & DateTo.AddDays(1) & "'" &
                              " and " &
                                "  VW_PHARMACY_ISSUED.QTY <> 0"

            If chkCons.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_PHARMACY_ISSUED.ITEM" &
                                "    not like" &
                                "  '%CONSIGNMENT%' "
            End If

            If chkCovid.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_PHARMACY_ISSUED.ITEM" &
                                "    not like" &
                                "  '%COVID%' "
            End If

            If chkEP.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_PHARMACY_ISSUED.ITEM" &
                                "    not like" &
                                "  '%(EP)%' "
            End If

            If chkReturns.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                  "  (COA_ITEM.COACODE <> @x or COA_ITEM.COACODE <> null) "
            End If

            If cbFilter.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                             cbFilter.Text & " like " &
                             "@search"
            End If

            If cbSearchBy.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                             "ITEM like " &
                             "@searchby"
            End If

            Dr = Cmd.ExecuteReader

            dgvPharma_Charges.Rows.Clear()
            While Dr.Read
                If IsDBNull(Dr("QTY")) Then
                    Qty = 0
                Else
                    Qty = Dr("QTY")
                End If

                If IsDBNull(Dr("UNITPRICE")) Then
                    UnitPrice = 0
                Else
                    UnitPrice = Dr("UNITPRICE")
                End If

                If IsDBNull(Dr("SELLINGPRICE")) Then
                    SellingPrice = 0
                Else
                    SellingPrice = Dr("SELLINGPRICE")
                End If

                If IsDBNull(Dr("RETURNED_QTY")) Then
                    ReturnedQty = 0
                Else
                    ReturnedQty = Dr("RETURNED_QTY")
                End If
                With dgvPharma_Charges
                    .Rows.Add(
                    Dr("ISSUEDTE"),
                    Dr("CHARGE_SLIP_NO"),
                    Dr("HOSPITAL_NO"),
                    Dr("PATIENT_NAME"),
                    Dr("ITEM_CODE"),
                    Dr("COACODE"),
                    Dr("ITEM"),
                    Dr("STRENGTH"),
                    Qty,
                    UnitPrice,
                    Qty * UnitPrice,
                    SellingPrice,
                    Qty * SellingPrice,
                    Dr("ISSUED_BY"),
                    Dr("ESTATUS"),
                    ReturnedQty)
                    cntr = cntr + 1
                End With
            End While

            With dgvPharma_Charges
                For i As Integer = 0 To .Rows.Count - 1
                    If .Rows(i).Cells(15).Value > 0 Then
                        .Rows(i).DefaultCellStyle.BackColor = Color.Green
                        .Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                Next
            End With

            prg.Maximum = cntr
            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Cmd.Parameters.Clear()
            Con.Close()
        End Try
    End Sub

    Sub FillPharmaChargesGrid(ByRef dgvPharma_Charges As DataGridView,
                              ByRef prg As ProgressBar,
                              ByVal DateFrom As Date,
                              ByVal DateTo As Date,
                              ByRef cbSearchBy As ComboBox,
                              ByRef cbFilter As ComboBox,
                              ByRef txtSearch As TextBox,
                              ByRef chkCons As CheckBox,
                              ByRef chkCovid As CheckBox,
                              ByRef chkEP As CheckBox,
                              ByRef chkReturns As CheckBox)
        Dim Qty, ReturnedQty As Integer
        Dim UnitPrice, SellingPrice As Decimal
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.Parameters.AddWithValue("@searchby", "%" + cbSearchBy.Text + "%")
            Cmd.Parameters.AddWithValue("@x", "x")
            Cmd.CommandText = "select * from VW_PHARMACY_CHARGES " &
                              "left join " &
                              "  COA_ITEM on" &
                              "  COA_ITEM.ITEMCODE = VW_PHARMACY_CHARGES.ITEM_CODE " &
                              "where " &
                                "DODATE " &
                              "between " &
                                "'" & DateFrom & "'" &
                              " and " &
                                 "'" & DateTo.AddDays(1) & "'" &
                              " and " &
                                "  VW_PHARMACY_CHARGES.QTY <> 0"

            If chkCons.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_PHARMACY_CHARGES.ITEM" &
                                "    not like" &
                                "  '%CONSIGNMENT%' "
            End If

            If chkCovid.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_PHARMACY_CHARGES.ITEM" &
                                "    not like" &
                                "  '%COVID%' "
            End If

            If chkEP.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_PHARMACY_CHARGES.ITEM" &
                                "    not like" &
                                "  '%(EP)%' "
            End If

            If chkReturns.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                  "  (COA_ITEM.COACODE <> @x or COA_ITEM.COACODE <> null) "
            End If

            If cbFilter.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                             cbFilter.Text & " like " &
                             "@search"
            End If

            If cbSearchBy.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                             "ITEM like " &
                             "@searchby"
            End If

            Dr = Cmd.ExecuteReader

            dgvPharma_Charges.Rows.Clear()
            While Dr.Read
                If IsDBNull(Dr("QTY")) Then
                    Qty = 0
                Else
                    Qty = Dr("QTY")
                End If

                If IsDBNull(Dr("UNITPRICE")) Then
                    UnitPrice = 0
                Else
                    UnitPrice = Dr("UNITPRICE")
                End If

                If IsDBNull(Dr("SELLINGPRICE")) Then
                    SellingPrice = 0
                Else
                    SellingPrice = Dr("SELLINGPRICE")
                End If

                If IsDBNull(Dr("RETURNED_QTY")) Then
                    ReturnedQty = 0
                Else
                    ReturnedQty = Dr("RETURNED_QTY")
                End If
                With dgvPharma_Charges
                    .Rows.Add(
                    Dr("DODATE"),
                    Dr("CHARGE_SLIP_NO"),
                    Dr("HOSPITAL_NO"),
                    Dr("PATIENT_NAME"),
                    Dr("ITEM_CODE"),
                    Dr("COACODE"),
                    Dr("ITEM"),
                    Dr("STRENGTH"),
                    Qty,
                    UnitPrice,
                    Qty * UnitPrice,
                    SellingPrice,
                    Qty * SellingPrice,
                    Dr("ISSUED_BY"),
                    Dr("ESTATUS"),
                    ReturnedQty)
                    cntr = cntr + 1
                End With
            End While

            With dgvPharma_Charges
                For i As Integer = 0 To .Rows.Count - 1
                    If .Rows(i).Cells(14).Value = "U" Then
                        .Rows(i).DefaultCellStyle.BackColor = Color.Gray
                        .Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                    If .Rows(i).Cells(15).Value > 0 Then
                        .Rows(i).DefaultCellStyle.BackColor = Color.Green
                        .Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                Next
            End With

            prg.Maximum = cntr
            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Cmd.Parameters.Clear()
            Con.Close()
        End Try
    End Sub

    Sub FillCSRIssuedGrid(ByRef dgvCSR_Issued As DataGridView,
                           ByRef prg As ProgressBar,
                           ByVal DateFrom As Date,
                           ByVal DateTo As Date,
                           ByRef cbSearch As ComboBox,
                           ByRef cbFilter As ComboBox,
                           ByRef txtSearch As TextBox,
                           ByRef chkCons As CheckBox,
                           ByRef chkCovid As CheckBox,
                           ByRef chkReturns As CheckBox)
        Dim Qty, ReturnedQty As Integer
        Dim UnitPrice, SellingPrice As Decimal
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.Parameters.AddWithValue("@searchby", "%" + cbSearch.Text + "%")
            Cmd.Parameters.AddWithValue("@x", "x")
            Cmd.CommandText = "select * from VW_CSR_ISSUED " &
                              "left join " &
                              "  COA_ITEM on " &
                              "COA_ITEM.ITEMCODE = VW_CSR_ISSUED.ITEM_CODE " &
                              "where " &
                              "  ISSUEDTE " &
                              "between " &
                                "'" & DateFrom & "'" &
                              " and " &
                                 "'" & DateTo.AddDays(1) & "'" &
                              " and " &
                                "  VW_CSR_ISSUED.QTY <> 0"

            If chkCons.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_CSR_ISSUED.ITEM" &
                                "  not like" &
                                "  '%CONSIGNMENT%' "
            End If

            If chkCovid.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_CSR_ISSUED.ITEM" &
                                "    not like" &
                                "  '%COVID%' "
            End If

            If chkReturns.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  COA_ITEM.COACODE <> @x"
            End If


            If cbFilter.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                            cbFilter.Text & " like " &
                           "@search"
            End If

            If cbSearch.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                                "ITEM like " &
                                "@searchby"
            End If
            Dr = Cmd.ExecuteReader

            dgvCSR_Issued.Rows.Clear()
            While Dr.Read
                If IsDBNull(Dr("QTY")) Then
                    Qty = 0
                Else
                    Qty = Dr("QTY")
                End If

                If IsDBNull(Dr("UNITPRICE")) Then
                    UnitPrice = 0
                Else
                    UnitPrice = Dr("UNITPRICE")
                End If

                If IsDBNull(Dr("SELLINGPRICE")) Then
                    SellingPrice = 0
                Else
                    SellingPrice = Dr("SELLINGPRICE")
                End If

                If IsDBNull(Dr("RETURNED_QTY")) Then
                    ReturnedQty = 0
                Else
                    ReturnedQty = Dr("RETURNED_QTY")
                End If

                dgvCSR_Issued.Rows.Add(
                    Dr("ISSUEDTE"),
                    Dr("CHARGE_SLIP_NO"),
                    Dr("HOSPITAL_NO"),
                    Dr("PATIENT_NAME"),
                    Dr("ITEM_CODE"),
                    Dr("COACODE"),
                    Dr("ITEM"),
                    Dr("UOMCODE"),
                    Qty,
                    UnitPrice,
                    Qty * UnitPrice,
                    SellingPrice,
                    Qty * SellingPrice,
                    Dr("ISSUED_BY"),
                    Dr("ESTATUS"),
                    ReturnedQty)
                cntr = cntr + 1
            End While

            With dgvCSR_Issued
                For i As Integer = 0 To .Rows.Count - 1
                    If .Rows(i).Cells(15).Value > 0 Then
                        .Rows(i).DefaultCellStyle.BackColor = Color.Green
                        .Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                Next
            End With

            prg.Maximum = cntr
            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd.Parameters.Clear()
            Con.Close()
        End Try
    End Sub

    Sub FillCSRChargesGrid(ByRef dgvCSR_Charges As DataGridView,
                       ByRef prg As ProgressBar,
                       ByVal DateFrom As Date,
                       ByVal DateTo As Date,
                       ByRef cbSearch As ComboBox,
                       ByRef cbFilter As ComboBox,
                       ByRef txtSearch As TextBox,
                       ByRef chkCons As CheckBox,
                       ByRef chkCovid As CheckBox,
                       ByRef chkReturns As CheckBox)
        Dim Qty, ReturnedQty As Integer
        Dim UnitPrice, SellingPrice As Decimal
        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.Parameters.AddWithValue("@searchby", "%" + cbSearch.Text + "%")
            Cmd.Parameters.AddWithValue("@x", "x")
            Cmd.CommandText = "select * from VW_CSR_CHARGES " &
                              "left join " &
                              "  COA_ITEM on " &
                              "COA_ITEM.ITEMCODE = VW_CSR_CHARGES.ITEM_CODE " &
                              "where " &
                              "  DODATE " &
                              "between " &
                                "'" & DateFrom & "'" &
                              " and " &
                                 "'" & DateTo.AddDays(1) & "'" &
                              " and " &
                                "  VW_CSR_CHARGES.QTY <> 0"

            If chkCons.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_CSR_CHARGES.ITEM" &
                                "  not like" &
                                "  '%CONSIGNMENT%' "
            End If

            If chkCovid.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  VW_CSR_CHARGES.ITEM" &
                                "    not like" &
                                "  '%COVID%' "
            End If

            If chkReturns.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  COA_ITEM.COACODE <> @x"
            End If

            If cbFilter.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                            cbFilter.Text & " like " &
                           "@search"
            End If


            If cbSearch.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                                "ITEM like " &
                                "@searchby"
            End If
            Dr = Cmd.ExecuteReader

            dgvCSR_Charges.Rows.Clear()
            While Dr.Read
                If IsDBNull(Dr("QTY")) Then
                    Qty = 0
                Else
                    Qty = Dr("QTY")
                End If

                If IsDBNull(Dr("UNITPRICE")) Then
                    UnitPrice = 0
                Else
                    UnitPrice = Dr("UNITPRICE")
                End If

                If IsDBNull(Dr("SELLINGPRICE")) Then
                    SellingPrice = 0
                Else
                    SellingPrice = Dr("SELLINGPRICE")
                End If

                If IsDBNull(Dr("RETURNED_QTY")) Then
                    ReturnedQty = 0
                Else
                    ReturnedQty = Dr("RETURNED_QTY")
                End If

                dgvCSR_Charges.Rows.Add(
                    Dr("DODATE"),
                    Dr("CHARGE_SLIP_NO"),
                    Dr("HOSPITAL_NO"),
                    Dr("PATIENT_NAME"),
                    Dr("ITEM_CODE"),
                    Dr("COACODE"),
                    Dr("ITEM"),
                    Dr("UOMCODE"),
                    Qty,
                    UnitPrice,
                    Qty * UnitPrice,
                    SellingPrice,
                    Qty * SellingPrice,
                    Dr("ISSUED_BY"),
                    Dr("ESTATUS"),
                    ReturnedQty)
                cntr = cntr + 1
            End While

            With dgvCSR_Charges
                For i As Integer = 0 To .Rows.Count - 1
                    If .Rows(i).Cells(14).Value = "U" Then
                        .Rows(i).DefaultCellStyle.BackColor = Color.Gray
                        .Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                    If .Rows(i).Cells(15).Value > 0 Then
                        .Rows(i).DefaultCellStyle.BackColor = Color.Green
                        .Rows(i).DefaultCellStyle.ForeColor = Color.White
                    End If
                Next
            End With

            prg.Maximum = cntr
            Cmd.Parameters.Clear()
            closecon()
        Catch ex As Exception
            MsgBox(ex.Message)
            Cmd.Parameters.Clear()
            Con.Close()
        End Try
    End Sub

    Sub FillPharmaItemSummaryGrid(ByRef dgvItemSummary As DataGridView,
                                  ByVal DateFrom As Date,
                                  ByVal DateTo As Date,
                                  ByRef cbSearch As ComboBox,
                                  ByRef cbFilter As ComboBox,
                                  ByRef txtSearch As TextBox,
                                  ByRef chkCons As CheckBox,
                                  ByRef chkCovid As CheckBox,
                                  ByRef chkEP As CheckBox)

        Try
            Dim cntr As Integer = 0
            opencon()
            Cmd.Parameters.AddWithValue("@search", txtSearch.Text + "%")
            Cmd.Parameters.AddWithValue("@searchby", "%" + cbSearch.Text + "%")
            Cmd.CommandText = "select " &
                              "  ITEM, " &
                              "  STRENGTH, " &
                              "  sum(QTY) as QTY " &
                              "from " &
                              "  VW_PHARMACY_CHARGES " &
                              "where " &
                                "DODATE " &
                              "between " &
                                "'" & DateFrom & "'" &
                              " and " & _
                                 "'" & DateTo.AddDays(1) & "'"

            If chkCons.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  ITEM" &
                                "    not like" &
                                "  '%CONSIGNMENT%' "
            End If

            If chkCovid.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  ITEM" &
                                "    not like" &
                                "  '%COVID%' "
            End If

            If chkEP.Checked = True Then
                Cmd.CommandText = Cmd.CommandText & "and " &
                                "  ITEM" &
                                "    not like" &
                                "  '%(EP)%' "
            End If

            If cbFilter.Text = "ITEM" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                             cbFilter.Text & " like " &
                             "@search"
            End If

            If cbSearch.Text <> "" Then
                Cmd.CommandText = Cmd.CommandText & " and " &
                                "ITEM like " &
                                "@searchby"
            End If

            Cmd.CommandText = Cmd.CommandText &
                             " group by " &
                                " ITEM, " &
                                " STRENGTH "
            Dr = Cmd.ExecuteReader

            dgvItemSummary.Rows.Clear()
            While Dr.Read
                With dgvItemSummary
                    .Rows.Add(
                    Dr("ITEM"),
                    Dr("STRENGTH"),
                    Dr("QTY"))
                    cntr = cntr + 1
                End With
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
