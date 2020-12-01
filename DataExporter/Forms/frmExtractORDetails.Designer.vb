<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtractORDetails
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
        Me.dgvOR_DETAILS = New System.Windows.Forms.DataGridView()
        Me.HPN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OR_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OR_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCRIPTION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACCT_DESC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMOUNT_PAID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSIGNMENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOSP_INC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAYREM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CASHIER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbProgress = New System.Windows.Forms.ProgressBar()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbFilterBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkSum = New System.Windows.Forms.CheckBox()
        CType(Me.dgvOR_DETAILS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Image = Global.iHomisReports.My.Resources.Resources.show
        Me.btnShow.Location = New System.Drawing.Point(6, 9)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 77)
        Me.btnShow.TabIndex = 0
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'dgvOR_DETAILS
        '
        Me.dgvOR_DETAILS.AllowUserToAddRows = False
        Me.dgvOR_DETAILS.AllowUserToDeleteRows = False
        Me.dgvOR_DETAILS.AllowUserToOrderColumns = True
        Me.dgvOR_DETAILS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOR_DETAILS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvOR_DETAILS.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvOR_DETAILS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOR_DETAILS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HPN, Me.OR_NO, Me.OR_DATE, Me.DESCRIPTION, Me.ACCT_DESC, Me.AMOUNT_PAID, Me.CONSIGNMENT, Me.HOSP_INC, Me.PAYREM, Me.PATIENT_NAME, Me.CASHIER})
        Me.dgvOR_DETAILS.Location = New System.Drawing.Point(12, 110)
        Me.dgvOR_DETAILS.Name = "dgvOR_DETAILS"
        Me.dgvOR_DETAILS.ReadOnly = True
        Me.dgvOR_DETAILS.Size = New System.Drawing.Size(1336, 578)
        Me.dgvOR_DETAILS.TabIndex = 1
        '
        'HPN
        '
        Me.HPN.HeaderText = "HPN"
        Me.HPN.Name = "HPN"
        Me.HPN.ReadOnly = True
        Me.HPN.Width = 55
        '
        'OR_NO
        '
        Me.OR_NO.HeaderText = "OR NO"
        Me.OR_NO.Name = "OR_NO"
        Me.OR_NO.ReadOnly = True
        Me.OR_NO.Width = 48
        '
        'OR_DATE
        '
        Me.OR_DATE.HeaderText = "OR DATE"
        Me.OR_DATE.Name = "OR_DATE"
        Me.OR_DATE.ReadOnly = True
        Me.OR_DATE.Width = 74
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.HeaderText = "DESCRIPTION"
        Me.DESCRIPTION.Name = "DESCRIPTION"
        Me.DESCRIPTION.ReadOnly = True
        Me.DESCRIPTION.Width = 105
        '
        'ACCT_DESC
        '
        Me.ACCT_DESC.HeaderText = "ACCT DESC"
        Me.ACCT_DESC.Name = "ACCT_DESC"
        Me.ACCT_DESC.ReadOnly = True
        Me.ACCT_DESC.Width = 85
        '
        'AMOUNT_PAID
        '
        Me.AMOUNT_PAID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.AMOUNT_PAID.HeaderText = "AMOUNT PAID"
        Me.AMOUNT_PAID.Name = "AMOUNT_PAID"
        Me.AMOUNT_PAID.ReadOnly = True
        Me.AMOUNT_PAID.Width = 98
        '
        'CONSIGNMENT
        '
        Me.CONSIGNMENT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CONSIGNMENT.HeaderText = "CONSIGNMENT"
        Me.CONSIGNMENT.Name = "CONSIGNMENT"
        Me.CONSIGNMENT.ReadOnly = True
        Me.CONSIGNMENT.Width = 112
        '
        'HOSP_INC
        '
        Me.HOSP_INC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.HOSP_INC.HeaderText = "HOSP INC"
        Me.HOSP_INC.Name = "HOSP_INC"
        Me.HOSP_INC.ReadOnly = True
        Me.HOSP_INC.Width = 77
        '
        'PAYREM
        '
        Me.PAYREM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PAYREM.HeaderText = "PAYREM"
        Me.PAYREM.Name = "PAYREM"
        Me.PAYREM.ReadOnly = True
        Me.PAYREM.Width = 77
        '
        'PATIENT_NAME
        '
        Me.PATIENT_NAME.HeaderText = "PATIENT NAME"
        Me.PATIENT_NAME.Name = "PATIENT_NAME"
        Me.PATIENT_NAME.ReadOnly = True
        Me.PATIENT_NAME.Width = 103
        '
        'CASHIER
        '
        Me.CASHIER.HeaderText = "CASHIER"
        Me.CASHIER.Name = "CASHIER"
        Me.CASHIER.ReadOnly = True
        Me.CASHIER.Width = 79
        '
        'pbProgress
        '
        Me.pbProgress.Location = New System.Drawing.Point(12, 74)
        Me.pbProgress.Maximum = 0
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(1011, 23)
        Me.pbProgress.TabIndex = 2
        '
        'btnExtract
        '
        Me.btnExtract.Image = Global.iHomisReports.My.Resources.Resources.excel
        Me.btnExtract.Location = New System.Drawing.Point(87, 9)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(76, 77)
        Me.btnExtract.TabIndex = 3
        Me.btnExtract.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(226, 18)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(228, 20)
        Me.txtSearch.TabIndex = 4
        '
        'cbFilterBy
        '
        Me.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilterBy.FormattingEnabled = True
        Me.cbFilterBy.Items.AddRange(New Object() {"", "OR_NO", "HOSPITAL_NO", "ITEMDESC", "PATIENT_NAME", "CASHIER"})
        Me.cbFilterBy.Location = New System.Drawing.Point(70, 17)
        Me.cbFilterBy.Name = "cbFilterBy"
        Me.cbFilterBy.Size = New System.Drawing.Size(150, 21)
        Me.cbFilterBy.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Date To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Search by"
        '
        'dpDateFrom
        '
        Me.dpDateFrom.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateFrom.CustomFormat = "MM/d/yyyy"
        Me.dpDateFrom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDateFrom.Location = New System.Drawing.Point(71, 19)
        Me.dpDateFrom.Name = "dpDateFrom"
        Me.dpDateFrom.Size = New System.Drawing.Size(200, 23)
        Me.dpDateFrom.TabIndex = 55
        '
        'dpDateTo
        '
        Me.dpDateTo.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateTo.CustomFormat = "MM/d/yyyy "
        Me.dpDateTo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDateTo.Location = New System.Drawing.Point(329, 19)
        Me.dpDateTo.Name = "dpDateTo"
        Me.dpDateTo.Size = New System.Drawing.Size(207, 23)
        Me.dpDateTo.TabIndex = 56
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dpDateTo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dpDateFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 54)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSearch)
        Me.GroupBox3.Controls.Add(Me.cbFilterBy)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(560, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 53)
        Me.GroupBox3.TabIndex = 60
        Me.GroupBox3.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnShow)
        Me.GroupBox2.Controls.Add(Me.btnExtract)
        Me.GroupBox2.Location = New System.Drawing.Point(1029, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(168, 93)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        '
        'chkSum
        '
        Me.chkSum.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSum.AutoSize = True
        Me.chkSum.Location = New System.Drawing.Point(1203, 28)
        Me.chkSum.Name = "chkSum"
        Me.chkSum.Size = New System.Drawing.Size(88, 17)
        Me.chkSum.TabIndex = 64
        Me.chkSum.Text = "OR Summary"
        Me.chkSum.UseVisualStyleBackColor = True
        '
        'frmExtractORDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1360, 700)
        Me.Controls.Add(Me.chkSum)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.dgvOR_DETAILS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExtractORDetails"
        Me.Text = "OR Details"
        CType(Me.dgvOR_DETAILS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents dgvOR_DETAILS As System.Windows.Forms.DataGridView
    Friend WithEvents pbProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents btnExtract As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cbFilterBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents HPN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OR_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OR_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCRIPTION As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACCT_DESC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMOUNT_PAID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSIGNMENT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOSP_INC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PAYREM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENT_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CASHIER As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkSum As System.Windows.Forms.CheckBox

End Class
