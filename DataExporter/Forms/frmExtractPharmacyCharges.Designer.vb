<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExtractPharmacyCharges
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.dgvPharma_Charges = New System.Windows.Forms.DataGridView()
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
        Me.btnExtractCoa = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbSearchBy = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkCons = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkNoCoaCode = New System.Windows.Forms.CheckBox()
        Me.chkEP = New System.Windows.Forms.CheckBox()
        Me.chkCovid = New System.Windows.Forms.CheckBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Charges = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgv_ItemSummary = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOSAGE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISSUE_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHARGE_SLIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HOSPITAL_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COA_CODE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ITEM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STRENGTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNIT_COST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_UNIT_COST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SELLING_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOTAL_SELLING_PRICE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISSUED_BY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RETURNED_ITEMS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPharma_Charges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Charges.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgv_ItemSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnShow.Image = Global.iHomisReports.My.Resources.Resources.show
        Me.btnShow.Location = New System.Drawing.Point(6, 11)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 72)
        Me.btnShow.TabIndex = 5
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'dgvPharma_Charges
        '
        Me.dgvPharma_Charges.AllowUserToAddRows = False
        Me.dgvPharma_Charges.AllowUserToDeleteRows = False
        Me.dgvPharma_Charges.AllowUserToOrderColumns = True
        Me.dgvPharma_Charges.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPharma_Charges.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvPharma_Charges.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPharma_Charges.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPharma_Charges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPharma_Charges.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISSUE_DATE, Me.CHARGE_SLIP, Me.HOSPITAL_NO, Me.PATIENT_NAME, Me.ITEM_CODE, Me.COA_CODE, Me.ITEM, Me.STRENGTH, Me.QTY, Me.UNIT_COST, Me.TOTAL_UNIT_COST, Me.SELLING_PRICE, Me.TOTAL_SELLING_PRICE, Me.ISSUED_BY, Me.RETURNED_ITEMS})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPharma_Charges.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPharma_Charges.Location = New System.Drawing.Point(3, 3)
        Me.dgvPharma_Charges.MultiSelect = False
        Me.dgvPharma_Charges.Name = "dgvPharma_Charges"
        Me.dgvPharma_Charges.ReadOnly = True
        Me.dgvPharma_Charges.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPharma_Charges.Size = New System.Drawing.Size(1299, 621)
        Me.dgvPharma_Charges.TabIndex = 6
        '
        'pbProgress
        '
        Me.pbProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgress.Location = New System.Drawing.Point(14, 67)
        Me.pbProgress.Maximum = 0
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(886, 24)
        Me.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbProgress.TabIndex = 2
        '
        'btnExtract
        '
        Me.btnExtract.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnExtract.Enabled = False
        Me.btnExtract.Image = Global.iHomisReports.My.Resources.Resources.excel
        Me.btnExtract.Location = New System.Drawing.Point(6, 11)
        Me.btnExtract.Name = "btnExtract"
        Me.btnExtract.Size = New System.Drawing.Size(76, 71)
        Me.btnExtract.TabIndex = 8
        Me.btnExtract.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(330, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(95, 20)
        Me.txtSearch.TabIndex = 4
        '
        'cbFilterBy
        '
        Me.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilterBy.FormattingEnabled = True
        Me.cbFilterBy.Items.AddRange(New Object() {"", "CHARGE_SLIP_NO", "HOSPITAL_NO", "PATIENT_NAME", "ITEM", "ISSUED_BY"})
        Me.cbFilterBy.Location = New System.Drawing.Point(206, 13)
        Me.cbFilterBy.Name = "cbFilterBy"
        Me.cbFilterBy.Size = New System.Drawing.Size(118, 21)
        Me.cbFilterBy.TabIndex = 3
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
        Me.dpDateFrom.TabIndex = 1
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
        Me.dpDateTo.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnExtractCoa)
        Me.GroupBox1.Controls.Add(Me.btnExtract)
        Me.GroupBox1.Location = New System.Drawing.Point(1158, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 90)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'btnExtractCoa
        '
        Me.btnExtractCoa.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnExtractCoa.Enabled = False
        Me.btnExtractCoa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtractCoa.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnExtractCoa.Image = Global.iHomisReports.My.Resources.Resources.excel
        Me.btnExtractCoa.Location = New System.Drawing.Point(88, 11)
        Me.btnExtractCoa.Name = "btnExtractCoa"
        Me.btnExtractCoa.Size = New System.Drawing.Size(76, 71)
        Me.btnExtractCoa.TabIndex = 9
        Me.btnExtractCoa.Text = "COA"
        Me.btnExtractCoa.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cbSearchBy)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cbFilterBy)
        Me.GroupBox2.Location = New System.Drawing.Point(470, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(430, 50)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'cbSearchBy
        '
        Me.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSearchBy.FormattingEnabled = True
        Me.cbSearchBy.Items.AddRange(New Object() {"", "CONSIGNMENT", "CLEARVUE", "INFIMAX", "IVAXX", "MACRIK", "MAHINTANA", "RUSANN", "SANNOVEX", "TWINCIRCA"})
        Me.cbSearchBy.Location = New System.Drawing.Point(67, 13)
        Me.cbSearchBy.Name = "cbSearchBy"
        Me.cbSearchBy.Size = New System.Drawing.Size(133, 21)
        Me.cbSearchBy.TabIndex = 11
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
        Me.GroupBox4.Location = New System.Drawing.Point(1064, 9)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(88, 90)
        Me.GroupBox4.TabIndex = 60
        Me.GroupBox4.TabStop = False
        '
        'chkCons
        '
        Me.chkCons.AutoSize = True
        Me.chkCons.Location = New System.Drawing.Point(10, 13)
        Me.chkCons.Name = "chkCons"
        Me.chkCons.Size = New System.Drawing.Size(128, 17)
        Me.chkCons.TabIndex = 7
        Me.chkCons.Text = "Exclude Consignment"
        Me.chkCons.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.chkNoCoaCode)
        Me.GroupBox6.Controls.Add(Me.chkEP)
        Me.GroupBox6.Controls.Add(Me.chkCovid)
        Me.GroupBox6.Controls.Add(Me.chkCons)
        Me.GroupBox6.Location = New System.Drawing.Point(910, 9)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(148, 90)
        Me.GroupBox6.TabIndex = 58
        Me.GroupBox6.TabStop = False
        '
        'chkNoCoaCode
        '
        Me.chkNoCoaCode.AutoSize = True
        Me.chkNoCoaCode.Location = New System.Drawing.Point(10, 67)
        Me.chkNoCoaCode.Name = "chkNoCoaCode"
        Me.chkNoCoaCode.Size = New System.Drawing.Size(134, 17)
        Me.chkNoCoaCode.TabIndex = 7
        Me.chkNoCoaCode.Text = "Exclude No COA Code"
        Me.chkNoCoaCode.UseVisualStyleBackColor = True
        '
        'chkEP
        '
        Me.chkEP.AutoSize = True
        Me.chkEP.Location = New System.Drawing.Point(10, 49)
        Me.chkEP.Name = "chkEP"
        Me.chkEP.Size = New System.Drawing.Size(81, 17)
        Me.chkEP.TabIndex = 9
        Me.chkEP.Text = "Exclude EP"
        Me.chkEP.UseVisualStyleBackColor = True
        '
        'chkCovid
        '
        Me.chkCovid.AutoSize = True
        Me.chkCovid.Location = New System.Drawing.Point(10, 31)
        Me.chkCovid.Name = "chkCovid"
        Me.chkCovid.Size = New System.Drawing.Size(115, 17)
        Me.chkCovid.TabIndex = 8
        Me.chkCovid.Text = "Exclude COVID-19"
        Me.chkCovid.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.Charges)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 105)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1316, 659)
        Me.TabControl1.TabIndex = 61
        '
        'Charges
        '
        Me.Charges.Controls.Add(Me.dgvPharma_Charges)
        Me.Charges.Location = New System.Drawing.Point(4, 25)
        Me.Charges.Name = "Charges"
        Me.Charges.Padding = New System.Windows.Forms.Padding(3)
        Me.Charges.Size = New System.Drawing.Size(1308, 630)
        Me.Charges.TabIndex = 0
        Me.Charges.Text = "Charges"
        Me.Charges.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgv_ItemSummary)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1308, 630)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Item Summary"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgv_ItemSummary
        '
        Me.dgv_ItemSummary.AllowUserToAddRows = False
        Me.dgv_ItemSummary.AllowUserToDeleteRows = False
        Me.dgv_ItemSummary.AllowUserToOrderColumns = True
        Me.dgv_ItemSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ItemSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_ItemSummary.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ItemSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_ItemSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ItemSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DOSAGE, Me.DataGridViewTextBoxColumn2})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_ItemSummary.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_ItemSummary.Location = New System.Drawing.Point(5, 4)
        Me.dgv_ItemSummary.Name = "dgv_ItemSummary"
        Me.dgv_ItemSummary.ReadOnly = True
        Me.dgv_ItemSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ItemSummary.Size = New System.Drawing.Size(1297, 621)
        Me.dgv_ItemSummary.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ITEM"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 58
        '
        'DOSAGE
        '
        Me.DOSAGE.HeaderText = "STRENGTH"
        Me.DOSAGE.Name = "DOSAGE"
        Me.DOSAGE.ReadOnly = True
        Me.DOSAGE.Width = 92
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "QTY ISSUED"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 97
        '
        'ISSUE_DATE
        '
        Me.ISSUE_DATE.HeaderText = "ISSUED DATE"
        Me.ISSUE_DATE.MinimumWidth = 50
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
        'STRENGTH
        '
        Me.STRENGTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.STRENGTH.HeaderText = "STRENGTH"
        Me.STRENGTH.Name = "STRENGTH"
        Me.STRENGTH.ReadOnly = True
        Me.STRENGTH.Width = 92
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
        Me.ISSUED_BY.HeaderText = "ISSUED BY"
        Me.ISSUED_BY.Name = "ISSUED_BY"
        Me.ISSUED_BY.ReadOnly = True
        Me.ISSUED_BY.Width = 82
        '
        'RETURNED_ITEMS
        '
        Me.RETURNED_ITEMS.HeaderText = "RETURNED QTY"
        Me.RETURNED_ITEMS.Name = "RETURNED_ITEMS"
        Me.RETURNED_ITEMS.ReadOnly = True
        Me.RETURNED_ITEMS.Width = 108
        '
        'frmExtractPharmacyCharges
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1340, 768)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.pbProgress)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmExtractPharmacyCharges"
        CType(Me.dgvPharma_Charges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.Charges.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgv_ItemSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents dgvPharma_Charges As System.Windows.Forms.DataGridView
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExtractCoa As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkCons As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEP As System.Windows.Forms.CheckBox
    Friend WithEvents chkCovid As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoCoaCode As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Charges As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgv_ItemSummary As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOSAGE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents ISSUE_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHARGE_SLIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOSPITAL_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENT_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEM_CODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents COA_CODE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ITEM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STRENGTH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QTY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNIT_COST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_UNIT_COST As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SELLING_PRICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOTAL_SELLING_PRICE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ISSUED_BY As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RETURNED_ITEMS As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
