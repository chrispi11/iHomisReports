Imports Excel = Microsoft.Office.Interop.Excel

Public Class clsDGVtoExcel
    Public Sub ExtractDGVtoExcel(ByRef dgv As DataGridView, ByRef pb As ProgressBar)
        Dim excelType As Type = Type.GetTypeFromProgID("Excel.Application")
        Dim app As Excel.Application = CType(System.Activator.CreateInstance(excelType), Excel.Application)
        'Dim app As New Excel.Application
        Dim workbook As Excel.Workbook
        Dim worksheet As Excel.Worksheet

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 2

        Dim misval As Object = System.Reflection.Missing.Value

        Dim i As Integer
        Dim j As Integer

        workbook = app.Workbooks.Add(misval)
        worksheet = workbook.Sheets("sheet1")

        If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            For i = 0 To dgv.RowCount - 1
                For j = 0 To dgv.ColumnCount - 1
                    For k As Integer = 1 To dgv.Columns.Count
                        worksheet.Cells(1, k) = dgv.Columns(k - 1).HeaderText
                        worksheet.Cells(i + 2, j + 1) = dgv(j, i).Value.ToString()
                    Next
                Next
                pb.Increment(1)
            Next

            worksheet.SaveAs(saveDialog.FileName)
            MsgBox("File Successfully Saved to " & saveDialog.FileName, , "")
            workbook.Close()
            app.Quit()
        End If

        releaseObject(app)
        releaseObject(workbook)
        releaseObject(worksheet)
    End Sub

    Public Sub ExtractDGVtoCOAExcel(ByRef dgv As DataGridView, ByRef pb As ProgressBar)
        Dim excelType As Type = Type.GetTypeFromProgID("Excel.Application")
        Dim app As Excel.Application = CType(System.Activator.CreateInstance(excelType), Excel.Application)
        'Dim app As New Excel.Application
        Dim workbook As Excel.Workbook
        Dim worksheet As Excel.Worksheet

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 2

        Dim misval As Object = System.Reflection.Missing.Value

        Dim i As Integer


        workbook = app.Workbooks.Open("C:\COA_TEMPLATE\coa.xlsx")
        worksheet = workbook.Sheets("Summ. of Supp. & Mats. Issued")

        If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            For i = 0 To dgv.RowCount - 1
                worksheet.Cells(i + 9, 1).value = dgv(5, i).Value.ToString() 'COA Item Code
                worksheet.Cells(i + 9, 4).value = dgv(1, i).Value.ToString() 'Charge Slip
                worksheet.Cells(i + 9, 5).value = dgv(0, i).Value.ToString() 'Issued Date
                worksheet.Cells(i + 9, 6).value = dgv(13, i).Value.ToString() 'Issued By
                worksheet.Cells(i + 9, 7).value = dgv(3, i).Value.ToString() 'Issued To
                worksheet.Cells(i + 9, 9).value = dgv(7, i).Value.ToString() 'UOM
                worksheet.Cells(i + 9, 10).value = dgv(8, i).Value.ToString() 'Qty
                pb.Increment(1)
            Next
        End If
        'For i = 0 To dgv.RowCount - 2
        'For j = 0 To dgv.ColumnCount - 1
        'For k As Integer = 1 To dgv.Columns.Count
        'worksheet.Cells(1, k) = dgv.Columns(k - 1).HeaderText
        'worksheet.Cells(i + 2, j + 1) = dgv(j, i).Value.ToString()
        'Next
        'Next
        'pb.Increment(1)
        'Next

        worksheet.SaveAs(saveDialog.FileName)
        MsgBox("File Successfully Saved")
        workbook.Close()
        app.Quit()

        releaseObject(app)
        releaseObject(workbook)
        releaseObject(worksheet)
    End Sub

    Public Sub ExtractDGVtoExcel_2(ByRef dgv As DataGridView, ByRef pb As ProgressBar)
        Dim excelType As Type = Type.GetTypeFromProgID("Excel.Application")
        'Dim app As Excel.Application = CType(System.Activator.CreateInstance(excelType), Excel.Application)
        'Dim app As New Excel.Application
        'Dim workbook As Excel.Workbook
        'Dim worksheet As Excel.Worksheet

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
        saveDialog.FilterIndex = 2

        Dim counter As Integer = 0

        Cursor.Current = Cursors.WaitCursor

        If ((dgv.Columns.Count = 0) Or (dgv.Rows.Count = 0)) Then
            Exit Sub
        End If

        Dim dset As New DataSet

        dset.Tables.Add()
        For i As Integer = 0 To dgv.ColumnCount - 1
            dset.Tables(0).Columns.Add(dgv.Columns(i).HeaderText)
        Next

        Dim dr1 As DataRow

        For i As Integer = 0 To dgv.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For j As Integer = 0 To dgv.Columns.Count - 1
                dr1(j) = dgv.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next

        Dim excel As Excel.Application = CType(System.Activator.CreateInstance(excelType), Excel.Application)
        Dim wBook As Excel.Workbook
        Dim wSheet As Excel.Worksheet

        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dt As System.Data.DataTable = dset.Tables(0)
        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            For Each dc In dt.Columns
                colIndex = colIndex + 1
                excel.Cells(1, colIndex) = dc.ColumnName
            Next

            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)
                Next
                pb.Increment(1)
            Next

            wSheet.SaveAs(saveDialog.FileName)
            MsgBox("File Successfully Saved to " & saveDialog.FileName, , "")
            wBook.Close()
            excel.Quit()
        End If


        releaseObject(excel)
        releaseObject(wBook)
        releaseObject(wSheet)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class
