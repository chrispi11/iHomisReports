<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtractCSRCharges
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvCSR_Charges = New System.Windows.Forms.DataGridView()
        Me.ISSUE_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHARGE_SLIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOSPITAL_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COA_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UOM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIT_COST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_UNIT_COST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SELLING_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_SELLING_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISSUED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETURNED_QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pbProgress = New System.Windows.Forms.ProgressBar()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cbFilterBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExtractCOA = New System.Windows.Forms.Button()
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.chkCons = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkCovid = New System.Windows.Forms.CheckBox()
        Me.chkNoCoaCode = New System.Windows.Forms.CheckBox()
        CType(Me.dgvCSR_Charges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvCSR_Charges
        '
        Me.dgvCSR_Charges.AllowUserToAddRows = False
        Me.dgvCSR_Charges.AllowUserToDeleteRows = False
        Me.dgvCSR_Charges.AllowUserToOrderColumns = True
        Me.dgvCSR_Charges.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCSR_Charges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCSR_Charges.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCSR_Charges.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCSR_Charges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCSR_Charges.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISSUE_DATE, Me.CHARGE_SLIP, Me.HOSPITAL_NO, Me.PATIENT_NAME, Me.ITEM_CODE, Me.COA_CODE, Me.ITEM, Me.UOM, Me.QTY, Me.UNIT_COST, Me.TOTAL_UNIT_COST, Me.SELLING_PRICE, Me.TOTAL_SELLING_PRICE, Me.ISSUED_BY, Me.RETURNED_QTY})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCSR_Charges.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCSR_Charges.Location = New System.Drawing.Point(14, 104)
        Me.dgvCSR_Charges.MultiSelect = False
        Me.dgvCSR_Charges.Name = "dgvCSR_Charges"
        Me.dgvCSR_Charges.ReadOnly = True
        Me.dgvCSR_Charges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCSR_Charges.Size = New System.Drawing.Size(1309, 414)
        Me.dgvCSR_Charges.TabIndex = 1
        '
        'ISSUE_DATE
        '
        Me.ISSUE_DATE.HeaderText = "ISSUED DATE"
        Me.ISSUE_DATE.Name = "ISSUE_DATE"
        Me.ISSUE_DATE.ReadOnly = True
        Me.ISSUE_DATE.Width = 96
        '
        'CHARGE_SLIP
        '
        Me.CHARGE_SLIP.HeaderText = "CHARGE SLIP NO"
        Me.CHARGE_SLIP.Name = "CHARGE_SLIP"
        Me.CHARGE_SLIP.ReadOnly = True
        Me.CHARGE_SLIP.Width = 97
        '
        'HOSPITAL_NO
        '
        Me.HOSPITAL_NO.HeaderText = "HOSPITAL NO"
        Me.HOSPITAL_NO.Name = "HOSPITAL_NO"
        Me.HOSPITAL_NO.ReadOnly = True
        Me.HOSPITAL_NO.Width = 96
        '
        'PATIENT_NAME
        '
        Me.PATIENT_NAME.HeaderText = "PATIENT NAME"
        Me.PATIENT_NAME.Name = "PATIENT_NAME"
        Me.PATIENT_NAME.ReadOnly = True
        Me.PATIENT_NAME.Width = 103
        '
        'ITEM_CODE
        '
        Me.ITEM_CODE.HeaderText = "ITEM_CODE"
        Me.ITEM_CODE.Name = "ITEM_CODE"
        Me.ITEM_CODE.ReadOnly = True
        Me.ITEM_CODE.Width = 94
        '
        'COA_CODE
        '
        Me.COA_CODE.HeaderText = "COA_CODE"
        Me.COA_CODE.Name = "COA_CODE"
        Me.COA_CODE.ReadOnly = True
        Me.COA_CODE.Width = 90
        '
        'ITEM
        '
        Me.ITEM.HeaderText = "ITEM"
        Me.ITEM.Name = "ITEM"
        Me.ITEM.ReadOnly = True
        Me.ITEM.Width = 58
        '
        'UOM
        '
        Me.UOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.UOM.HeaderText = "UNIT"
        Me.UOM.Name = "UOM"
        Me.UOM.ReadOnly = True
        Me.UOM.Width = 58
        '
        'QTY
        '
        Me.QTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.QTY.HeaderText = "QTY"
        Me.QTY.Name = "QTY"
        Me.QTY.ReadOnly = True
        Me.QTY.Width = 54
        '
        'UNIT_COST
        '
        Me.UNIT_COST.HeaderText = "UNIT COST"
        Me.UNIT_COST.Name = "UNIT_COST"
        Me.UNIT_COST.ReadOnly = True
        Me.UNIT_COST.Width = 83
        '
        'TOTAL_UNIT_COST
        '
        Me.TOTAL_UNIT_COST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TOTAL_UNIT_COST.HeaderText = "TOTAL UNIT COST"
        Me.TOTAL_UNIT_COST.Name = "TOTAL_UNIT_COST"
        Me.TOTAL_UNIT_COST.ReadOnly = True
        Me.TOTAL_UNIT_COST.Width = 91
        '
        'SELLING_PRICE
        '
        Me.SELLING_PRICE.HeaderText = "SELLING_PRICE"
        Me.SELLING_PRICE.Name = "SELLING_PRICE"
        Me.SELLING_PRICE.ReadOnly = True
        Me.SELLING_PRICE.Width = 115
        '
        'TOTAL_SELLING_PRICE
        '
        Me.TOTAL_SELLING_PRICE.HeaderText = "TOTAL SELLING PRICE"
        Me.TOTAL_SELLING_PRICE.Name = "TOTAL_SELLING_PRICE"
        Me.TOTAL_SELLING_PRICE.ReadOnly = True
        Me.TOTAL_SELLING_PRICE.Width = 137
        '
        'ISSUED_BY
        '
        Me.ISSUED_BY.HeaderText = "ISSUED_BY"
        Me.ISSUED_BY.Name = "ISSUED_BY"
        Me.ISSUED_BY.ReadOnly = True
        Me.ISSUED_BY.Width = 92
        '
        'RETURNED_QTY
        '
        Me.RETURNED_QTY.HeaderText = "RETURNED ITEMS"
        Me.RETURNED_QTY.Name = "RETURNED_QTY"
        Me.RETURNED_QTY.ReadOnly = True
        Me.RETURNED_QTY.Visible = False
        Me.RETURNED_QTY.Width = 118
        '
        'pbProgress
        '
        Me.pbProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgress.Location = New System.Drawing.Point(14, 66)
        Me.pbProgress.Maximum = 0
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(886, 24)
        Me.pbProgress.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(225, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 20)
        Me.txtSearch.TabIndex = 4
        '
        'cbFilterBy
        '
        Me.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilterBy.FormattingEnabled = True
        Me.cbFilterBy.Items.AddRange(New Object() {"", "CHARGE_SLIP_NO", "HOSPITAL_NO", "PATIENT_NAME", "ITEM", "ISSUED_BY"})
        Me.cbFilterBy.Location = New System.Drawing.Point(67, 13)
        Me.cbFilterBy.Name = "cbFilterBy"
        Me.cbFilterBy.Size = New System.Drawing.Size(150, 21)
        Me.cbFilterBy.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Date To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Search by"
        '
        'dpDateFrom
        '
        Me.dpDateFrom.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateFrom.CustomFormat = "MM/dd/yyyy"
        Me.dpDateFrom.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDateFrom.Location = New System.Drawing.Point(68, 13)
        Me.dpDateFrom.Name = "dpDateFrom"
        Me.dpDateFrom.Size = New System.Drawing.Size(150, 23)
        Me.dpDateFrom.TabIndex = 55
        '
        'dpDateTo
        '
        Me.dpDateTo.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateTo.CustomFormat = "MM/dd/yyyy"
        Me.dpDateTo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpDateTo.Location = New System.Drawing.Point(294, 13)
        Me.dpDateTo.Name = "dpDateTo"
        Me.dpDateTo.Size = New System.Drawing.Size(150, 23)
        Me.dpDateTo.TabIndex = 56
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbFilterBy)
        Me.GroupBox2.Location = New System.Drawing.Point(470, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 50)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dpDateTo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.dpDateFrom)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 9)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(450, 50)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.btnShow)
        Me.GroupBox4.Location = New System.Drawing.Point(1059, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(88, 90)
        Me.GroupBox4.TabIndex = 61
        Me.GroupBox4.TabStop = False
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnShow.Image = Global.iHomisReports.My.Resources.Resources.show
        Me.btnShow.Location = New System.Drawing.Point(6, 11)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 72)
        Me.btnShow.TabIndex = 0
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnExtractCOA)
        Me.GroupBox1.Controls.Add(Me.btnExtract)
        Me.GroupBox1.Location = New System.Drawing.Point(1153, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 90)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'btnExtractCOA
        '
        Me.btnExtractCOA.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnExtractCOA.Enabled = False
        Me.btnExtractCOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtractCOA.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExtractCOA.Image = Global.iHomisReports.My.Resources.Resources.excel
        Me.btnExtractCOA.Location = New System.Drawing.Point(88, 11)
        Me.btnExtractCOA.Name = "btnExtractCOA"
        Me.btnExtractCOA.Size = New System.Drawing.Size(76, 71)
        Me.btnExtractCOA.TabIndex = 4
        Me.btnExtractCOA.Text = "COA"
        Me.btnExtractCOA.UseVisualStyleBackColor = False
        '
        'btnExtract
        '
        Me.btnExtract.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnExtract.Enabled = False
        Me.btnExtract.Image = Global.iHomisReports.My.Resources.Resources.excel
        Me.btnExtract.Location = New System.Drawing.Point(6, 11)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(76, 71)
        Me.btnExtract.TabIndex = 3
        Me.btnExtract.UseVisualStyleBackColor = False
        '
        'chkCons
        '
        Me.chkCons.AutoSize = True
        Me.chkCons.Location = New System.Drawing.Point(9, 15)
        Me.chkCons.Name = "chkCons"
        Me.chkCons.Size = New System.Drawing.Size(128, 17)
        Me.chkCons.TabIndex = 63
        Me.chkCons.Text = "Exclude Consignment"
        Me.chkCons.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.chkCovid)
        Me.GroupBox6.Controls.Add(Me.chkNoCoaCode)
        Me.GroupBox6.Controls.Add(Me.chkCons)
        Me.GroupBox6.Location = New System.Drawing.Point(905, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(148, 90)
        Me.GroupBox6.TabIndex = 64
        Me.GroupBox6.TabStop = False
        '
        'chkCovid
        '
        Me.chkCovid.AutoSize = True
        Me.chkCovid.Location = New System.Drawing.Point(9, 38)
        Me.chkCovid.Name = "chkCovid"
        Me.chkCovid.Size = New System.Drawing.Size(115, 17)
        Me.chkCovid.TabIndex = 66
        Me.chkCovid.Text = "Exclude COVID-19"
        Me.chkCovid.UseVisualStyleBackColor = True
        '
        'chkNoCoaCode
        '
        Me.chkNoCoaCode.AutoSize = True
        Me.chkNoCoaCode.Location = New System.Drawing.Point(9, 61)
        Me.chkNoCoaCode.Name = "chkNoCoaCode"
        Me.chkNoCoaCode.Size = New System.Drawing.Size(134, 17)
        Me.chkNoCoaCode.TabIndex = 65
        Me.chkNoCoaCode.Text = "Exclude No COA Code"
        Me.chkNoCoaCode.UseVisualStyleBackColor = True
        '
        'frmExtractCSRCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1335, 530)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.dgvCSR_Charges)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExtractCSRCharges"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvCSR_Charges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCSR_Charges As System.Windows.Forms.DataGridView
    Friend WithEvents pbProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cbFilterBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dpDateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExtractCOA As System.Windows.Forms.Button
    Friend WithEvents btnExtract As System.Windows.Forms.Button
    Friend WithEvents chkCons As System.Windows.Forms.CheckBox
    Friend WithEvents ISSUE_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHARGE_SLIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOSPITAL_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENT_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEM_CODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COA_CODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UOM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIT_COST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_UNIT_COST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SELLING_PRICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_SELLING_PRICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISSUED_BY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents RETURNED_QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkNoCoaCode As System.Windows.Forms.CheckBox
    Friend WithEvents chkCovid As System.Windows.Forms.CheckBox

End Class
