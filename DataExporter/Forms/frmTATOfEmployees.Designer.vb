<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTATofEmployees
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.btnExtract = New System.Windows.Forms.Button()
        Me.tabTAT = New System.Windows.Forms.TabControl()
        Me.Detail = New System.Windows.Forms.TabPage()
        Me.dgvTAT = New System.Windows.Forms.DataGridView()
        Me.Summary = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rbHrs = New System.Windows.Forms.RadioButton()
        Me.rbDays = New System.Windows.Forms.RadioButton()
        Me.dgvTATSummary = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AVG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbGroup = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HOSPITAL_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATIENT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEPT_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMPLOYEE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTIFY_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLEAR_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIFFERENCE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMARKS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.DH_COPY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabTAT.SuspendLayout()
        Me.Detail.SuspendLayout()
        CType(Me.dgvTAT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Summary.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvTATSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbProgress
        '
        Me.pbProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbProgress.Location = New System.Drawing.Point(14, 66)
        Me.pbProgress.Maximum = 0
        Me.pbProgress.Name = "pbProgress"
        Me.pbProgress.Size = New System.Drawing.Size(894, 24)
        Me.pbProgress.TabIndex = 2
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Location = New System.Drawing.Point(198, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(235, 20)
        Me.txtSearch.TabIndex = 4
        '
        'cbFilterBy
        '
        Me.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFilterBy.FormattingEnabled = True
        Me.cbFilterBy.Items.AddRange(New Object() {"", "HOSPITAL_NO", "PATIENT_NAME", "SECTION", "EMPLOYEE"})
        Me.cbFilterBy.Location = New System.Drawing.Point(65, 13)
        Me.cbFilterBy.Name = "cbFilterBy"
        Me.cbFilterBy.Size = New System.Drawing.Size(127, 21)
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
        Me.GroupBox2.Size = New System.Drawing.Size(438, 50)
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
        Me.GroupBox4.Location = New System.Drawing.Point(911, 9)
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
        Me.GroupBox1.Controls.Add(Me.btnExtract)
        Me.GroupBox1.Location = New System.Drawing.Point(1005, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(87, 90)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
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
        'tabTAT
        '
        Me.tabTAT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTAT.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabTAT.Controls.Add(Me.Summary)
        Me.tabTAT.Controls.Add(Me.Detail)
        Me.tabTAT.Location = New System.Drawing.Point(13, 103)
        Me.tabTAT.Name = "tabTAT"
        Me.tabTAT.SelectedIndex = 0
        Me.tabTAT.Size = New System.Drawing.Size(1318, 424)
        Me.tabTAT.TabIndex = 66
        '
        'Detail
        '
        Me.Detail.Controls.Add(Me.dgvTAT)
        Me.Detail.Location = New System.Drawing.Point(4, 25)
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New System.Windows.Forms.Padding(3)
        Me.Detail.Size = New System.Drawing.Size(1310, 395)
        Me.Detail.TabIndex = 0
        Me.Detail.Text = "Detail"
        Me.Detail.UseVisualStyleBackColor = True
        '
        'dgvTAT
        '
        Me.dgvTAT.AllowUserToAddRows = False
        Me.dgvTAT.AllowUserToDeleteRows = False
        Me.dgvTAT.AllowUserToOrderColumns = True
        Me.dgvTAT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTAT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTAT.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTAT.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTAT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.HOSPITAL_NO, Me.PATIENT_NAME, Me.DEPT_NAME, Me.EMPLOYEE, Me.NOTIFY_DATE, Me.CLEAR_DATE, Me.DIFFERENCE, Me.REMARKS})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTAT.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTAT.Location = New System.Drawing.Point(3, 3)
        Me.dgvTAT.MultiSelect = False
        Me.dgvTAT.Name = "dgvTAT"
        Me.dgvTAT.ReadOnly = True
        Me.dgvTAT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTAT.Size = New System.Drawing.Size(1301, 384)
        Me.dgvTAT.TabIndex = 1
        '
        'Summary
        '
        Me.Summary.Controls.Add(Me.btnRemove)
        Me.Summary.Controls.Add(Me.GroupBox5)
        Me.Summary.Controls.Add(Me.dgvTATSummary)
        Me.Summary.Controls.Add(Me.cbGroup)
        Me.Summary.Controls.Add(Me.Label4)
        Me.Summary.Location = New System.Drawing.Point(4, 25)
        Me.Summary.Name = "Summary"
        Me.Summary.Padding = New System.Windows.Forms.Padding(3)
        Me.Summary.Size = New System.Drawing.Size(1310, 395)
        Me.Summary.TabIndex = 1
        Me.Summary.Text = "Summary"
        Me.Summary.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rbHrs)
        Me.GroupBox5.Controls.Add(Me.rbDays)
        Me.GroupBox5.Location = New System.Drawing.Point(202, 1)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(178, 40)
        Me.GroupBox5.TabIndex = 13
        Me.GroupBox5.TabStop = False
        '
        'rbHrs
        '
        Me.rbHrs.AutoSize = True
        Me.rbHrs.Location = New System.Drawing.Point(101, 13)
        Me.rbHrs.Name = "rbHrs"
        Me.rbHrs.Size = New System.Drawing.Size(64, 17)
        Me.rbHrs.TabIndex = 1
        Me.rbHrs.Text = "in Hours"
        Me.rbHrs.UseVisualStyleBackColor = True
        '
        'rbDays
        '
        Me.rbDays.AutoSize = True
        Me.rbDays.Checked = True
        Me.rbDays.Location = New System.Drawing.Point(19, 13)
        Me.rbDays.Name = "rbDays"
        Me.rbDays.Size = New System.Drawing.Size(60, 17)
        Me.rbDays.TabIndex = 0
        Me.rbDays.TabStop = True
        Me.rbDays.Text = "in Days"
        Me.rbDays.UseVisualStyleBackColor = True
        '
        'dgvTATSummary
        '
        Me.dgvTATSummary.AllowUserToAddRows = False
        Me.dgvTATSummary.AllowUserToDeleteRows = False
        Me.dgvTATSummary.AllowUserToOrderColumns = True
        Me.dgvTATSummary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTATSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTATSummary.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTATSummary.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTATSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTATSummary.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.Column1, Me.Total, Me.AVG, Me.DH, Me.DH_COPY})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTATSummary.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTATSummary.Location = New System.Drawing.Point(3, 47)
        Me.dgvTATSummary.Name = "dgvTATSummary"
        Me.dgvTATSummary.ReadOnly = True
        Me.dgvTATSummary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTATSummary.Size = New System.Drawing.Size(1301, 342)
        Me.dgvTATSummary.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "GROUP"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 71
        '
        'Column1
        '
        Me.Column1.HeaderText = "COUNT OF PX"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 83
        '
        'Total
        '
        Me.Total.HeaderText = "Total TAT"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 74
        '
        'AVG
        '
        Me.AVG.HeaderText = "AVG TAT per Patient"
        Me.AVG.Name = "AVG"
        Me.AVG.ReadOnly = True
        Me.AVG.Width = 91
        '
        'DH
        '
        Me.DH.HeaderText = "DH"
        Me.DH.Name = "DH"
        Me.DH.ReadOnly = True
        Me.DH.Width = 48
        '
        'cbGroup
        '
        Me.cbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGroup.FormattingEnabled = True
        Me.cbGroup.Items.AddRange(New Object() {"SECTION", "EMPLOYEE"})
        Me.cbGroup.Location = New System.Drawing.Point(67, 10)
        Me.cbGroup.Name = "cbGroup"
        Me.cbGroup.Size = New System.Drawing.Size(127, 21)
        Me.cbGroup.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Group by"
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
        'DEPT_NAME
        '
        Me.DEPT_NAME.HeaderText = "WARD/SECTION"
        Me.DEPT_NAME.Name = "DEPT_NAME"
        Me.DEPT_NAME.ReadOnly = True
        Me.DEPT_NAME.Width = 118
        '
        'EMPLOYEE
        '
        Me.EMPLOYEE.HeaderText = "EMPLOYEE"
        Me.EMPLOYEE.Name = "EMPLOYEE"
        Me.EMPLOYEE.ReadOnly = True
        Me.EMPLOYEE.Width = 90
        '
        'NOTIFY_DATE
        '
        Me.NOTIFY_DATE.HeaderText = "NOTIFY DATE"
        Me.NOTIFY_DATE.Name = "NOTIFY_DATE"
        Me.NOTIFY_DATE.ReadOnly = True
        Me.NOTIFY_DATE.Width = 95
        '
        'CLEAR_DATE
        '
        Me.CLEAR_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLEAR_DATE.HeaderText = "CLEAR DATE"
        Me.CLEAR_DATE.Name = "CLEAR_DATE"
        Me.CLEAR_DATE.ReadOnly = True
        Me.CLEAR_DATE.Width = 91
        '
        'DIFFERENCE
        '
        Me.DIFFERENCE.HeaderText = "DIFFERENCE"
        Me.DIFFERENCE.Name = "DIFFERENCE"
        Me.DIFFERENCE.ReadOnly = True
        Me.DIFFERENCE.Width = 99
        '
        'REMARKS
        '
        Me.REMARKS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.REMARKS.HeaderText = "REMARKS"
        Me.REMARKS.Name = "REMARKS"
        Me.REMARKS.ReadOnly = True
        Me.REMARKS.Width = 85
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnRemove.BackgroundImage = Global.iHomisReports.My.Resources.Resources.delete
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRemove.Location = New System.Drawing.Point(386, 6)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(39, 35)
        Me.btnRemove.TabIndex = 1
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'DH_COPY
        '
        Me.DH_COPY.HeaderText = ""
        Me.DH_COPY.Name = "DH_COPY"
        Me.DH_COPY.ReadOnly = True
        Me.DH_COPY.Visible = False
        Me.DH_COPY.Width = 19
        '
        'frmTATofEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1343, 533)
        Me.Controls.Add(Me.tabTAT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.pbProgress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmTATofEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.tabTAT.ResumeLayout(False)
        Me.Detail.ResumeLayout(False)
        CType(Me.dgvTAT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Summary.ResumeLayout(False)
        Me.Summary.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dgvTATSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents btnExtract As System.Windows.Forms.Button
    Friend WithEvents tabTAT As System.Windows.Forms.TabControl
    Friend WithEvents Detail As System.Windows.Forms.TabPage
    Friend WithEvents dgvTAT As System.Windows.Forms.DataGridView
    Friend WithEvents Summary As System.Windows.Forms.TabPage
    Friend WithEvents dgvTATSummary As System.Windows.Forms.DataGridView
    Friend WithEvents cbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbHrs As System.Windows.Forms.RadioButton
    Friend WithEvents rbDays As System.Windows.Forms.RadioButton
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AVG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HOSPITAL_NO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PATIENT_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEPT_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMPLOYEE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTIFY_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLEAR_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIFFERENCE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMARKS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents DH_COPY As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
