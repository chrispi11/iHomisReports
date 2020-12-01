<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtractORSummary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.dgvOR_SUMMARY = New System.Windows.Forms.DataGridView()
        Me.ACCOUNT_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OR_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OR_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENCOUNTER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOSPITAL_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ENCTR_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADM_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIS_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbProgress = New System.Windows.Forms.ProgressBar()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbFilterBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.dpDateFrom = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvOR_SUMMARY, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(1000, 11)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "SHOW"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'dgvOR_SUMMARY
        '
        Me.dgvOR_SUMMARY.AllowUserToAddRows = False
        Me.dgvOR_SUMMARY.AllowUserToDeleteRows = False
        Me.dgvOR_SUMMARY.AllowUserToOrderColumns = True
        Me.dgvOR_SUMMARY.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOR_SUMMARY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOR_SUMMARY.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ACCOUNT_NO, Me.OR_NO, Me.OR_DATE, Me.ENCOUNTER, Me.HOSPITAL_NO, Me.PATIENT_NAME, Me.ENCTR_DATE, Me.ADM_DATE, Me.DIS_DATE, Me.AMOUNT})
        Me.dgvOR_SUMMARY.Location = New System.Drawing.Point(12, 73)
        Me.dgvOR_SUMMARY.Name = "dgvOR_SUMMARY"
        Me.dgvOR_SUMMARY.ReadOnly = True
        Me.dgvOR_SUMMARY.Size = New System.Drawing.Size(1336, 586)
        Me.dgvOR_SUMMARY.TabIndex = 1
        '
        'ACCOUNT_NO
        '
        Me.ACCOUNT_NO.HeaderText = "ACCOUNT_NO"
        Me.ACCOUNT_NO.Name = "ACCOUNT_NO"
        Me.ACCOUNT_NO.ReadOnly = True
        '
        'OR_NO
        '
        Me.OR_NO.HeaderText = "OR_NO"
        Me.OR_NO.Name = "OR_NO"
        Me.OR_NO.ReadOnly = True
        '
        'OR_DATE
        '
        Me.OR_DATE.HeaderText = "OR_DATE"
        Me.OR_DATE.Name = "OR_DATE"
        Me.OR_DATE.ReadOnly = True
        '
        'ENCOUNTER
        '
        Me.ENCOUNTER.HeaderText = "ENCOUNTER"
        Me.ENCOUNTER.Name = "ENCOUNTER"
        Me.ENCOUNTER.ReadOnly = True
        '
        'HOSPITAL_NO
        '
        Me.HOSPITAL_NO.HeaderText = "HOSPITAL_NO"
        Me.HOSPITAL_NO.Name = "HOSPITAL_NO"
        Me.HOSPITAL_NO.ReadOnly = True
        '
        'PATIENT_NAME
        '
        Me.PATIENT_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PATIENT_NAME.HeaderText = "PATIENT_NAME"
        Me.PATIENT_NAME.Name = "PATIENT_NAME"
        Me.PATIENT_NAME.ReadOnly = True
        Me.PATIENT_NAME.Width = 115
        '
        'ENCTR_DATE
        '
        Me.ENCTR_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ENCTR_DATE.HeaderText = "ENCTR_DATE"
        Me.ENCTR_DATE.Name = "ENCTR_DATE"
        Me.ENCTR_DATE.ReadOnly = True
        Me.ENCTR_DATE.Width = 104
        '
        'ADM_DATE
        '
        Me.ADM_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.ADM_DATE.HeaderText = "ADM_DATE"
        Me.ADM_DATE.Name = "ADM_DATE"
        Me.ADM_DATE.ReadOnly = True
        Me.ADM_DATE.Width = 91
        '
        'DIS_DATE
        '
        Me.DIS_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DIS_DATE.HeaderText = "DIS_DATE"
        Me.DIS_DATE.Name = "DIS_DATE"
        Me.DIS_DATE.ReadOnly = True
        Me.DIS_DATE.Width = 85
        '
        'AMOUNT
        '
        Me.AMOUNT.HeaderText = "AMOUNT"
        Me.AMOUNT.Name = "AMOUNT"
        Me.AMOUNT.ReadOnly = True
        '
        'pbProgress
        '
        Me.pbProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgress.Location = New System.Drawing.Point(12, 40)
        Me.pbProgress.Maximum = 0
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(1336, 23)
        Me.pbProgress.TabIndex = 2
        '
        'btnExtract
        '
        Me.btnExtract.Location = New System.Drawing.Point(1081, 12)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(267, 22)
        Me.btnExtract.TabIndex = 3
        Me.btnExtract.Text = "EXTRACT OFFICIAL RECEIPT DATA"
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(772, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(222, 20)
        Me.txtSearch.TabIndex = 4
        '
        'cbFilterBy
        '
        Me.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilterBy.FormattingEnabled = True
        Me.cbFilterBy.Items.AddRange(New Object() {"", "ACCOUNT_NO", "OR_NO", "ENCOUNTER", "HOSPITAL_NO", "PATIENT_NAME"})
        Me.cbFilterBy.Location = New System.Drawing.Point(616, 11)
        Me.cbFilterBy.Name = "cbFilterBy"
        Me.cbFilterBy.Size = New System.Drawing.Size(150, 21)
        Me.cbFilterBy.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(290, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Date To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(555, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Search by"
        '
        'dpDateTo
        '
        Me.dpDateTo.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateTo.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dpDateTo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDateTo.Location = New System.Drawing.Point(342, 8)
        Me.dpDateTo.Name = "dpDateTo"
        Me.dpDateTo.Size = New System.Drawing.Size(207, 23)
        Me.dpDateTo.TabIndex = 56
        '
        'dpDateFrom
        '
        Me.dpDateFrom.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateFrom.CustomFormat = "MM/dd/yyyy hh:mm tt"
        Me.dpDateFrom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDateFrom.Location = New System.Drawing.Point(77, 7)
        Me.dpDateFrom.Name = "dpDateFrom"
        Me.dpDateFrom.Size = New System.Drawing.Size(207, 23)
        Me.dpDateFrom.TabIndex = 57
        '
        'frmExtractORSummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 700)
        Me.Controls.Add(Me.dpDateFrom)
        Me.Controls.Add(Me.dpDateTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbFilterBy)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnExtract)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.dgvOR_SUMMARY)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExtractORSummary"
        Me.Text = "OR Details"
        CType(Me.dgvOR_SUMMARY, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents dgvOR_SUMMARY As System.Windows.Forms.DataGridView
    Friend WithEvents pbProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents btnExtract As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cbFilterBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents ACCOUNT_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OR_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OR_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENCOUNTER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOSPITAL_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENT_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ENCTR_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADM_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIS_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dpDateFrom As System.Windows.Forms.DateTimePicker

End Class
