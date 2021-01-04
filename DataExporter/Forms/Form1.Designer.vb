<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CashierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ORDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COAFormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PharmacyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsignmentSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PharmacyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CSRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblComputerName = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CashierToolStripMenuItem, Me.ChargesToolStripMenuItem, Me.MaintenanceToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CashierToolStripMenuItem
        '
        Me.CashierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ORDetailsToolStripMenuItem})
        Me.CashierToolStripMenuItem.Enabled = False
        Me.CashierToolStripMenuItem.Name = "CashierToolStripMenuItem"
        Me.CashierToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.CashierToolStripMenuItem.Text = "CTO Receipts"
        '
        'ORDetailsToolStripMenuItem
        '
        Me.ORDetailsToolStripMenuItem.Name = "ORDetailsToolStripMenuItem"
        Me.ORDetailsToolStripMenuItem.Size = New System.Drawing.Size(128, 22)
        Me.ORDetailsToolStripMenuItem.Text = "OR Details"
        '
        'ChargesToolStripMenuItem
        '
        Me.ChargesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COAFormatToolStripMenuItem})
        Me.ChargesToolStripMenuItem.Enabled = False
        Me.ChargesToolStripMenuItem.Name = "ChargesToolStripMenuItem"
        Me.ChargesToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ChargesToolStripMenuItem.Text = "Charges"
        '
        'COAFormatToolStripMenuItem
        '
        Me.COAFormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PharmacyToolStripMenuItem1, Me.CSRToolStripMenuItem1})
        Me.COAFormatToolStripMenuItem.Name = "COAFormatToolStripMenuItem"
        Me.COAFormatToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.COAFormatToolStripMenuItem.Text = "COA Format"
        '
        'PharmacyToolStripMenuItem1
        '
        Me.PharmacyToolStripMenuItem1.Name = "PharmacyToolStripMenuItem1"
        Me.PharmacyToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.PharmacyToolStripMenuItem1.Text = "Pharmacy"
        '
        'CSRToolStripMenuItem1
        '
        Me.CSRToolStripMenuItem1.Name = "CSRToolStripMenuItem1"
        Me.CSRToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.CSRToolStripMenuItem1.Text = "CSR"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsignmentSetupToolStripMenuItem, Me.ChargesToolStripMenuItem1})
        Me.MaintenanceToolStripMenuItem.Enabled = False
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'ConsignmentSetupToolStripMenuItem
        '
        Me.ConsignmentSetupToolStripMenuItem.Name = "ConsignmentSetupToolStripMenuItem"
        Me.ConsignmentSetupToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ConsignmentSetupToolStripMenuItem.Text = "Consignment Setup"
        '
        'ChargesToolStripMenuItem1
        '
        Me.ChargesToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PharmacyToolStripMenuItem, Me.CSRToolStripMenuItem})
        Me.ChargesToolStripMenuItem1.Name = "ChargesToolStripMenuItem1"
        Me.ChargesToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.ChargesToolStripMenuItem1.Text = "COA Item Code"
        '
        'PharmacyToolStripMenuItem
        '
        Me.PharmacyToolStripMenuItem.Name = "PharmacyToolStripMenuItem"
        Me.PharmacyToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PharmacyToolStripMenuItem.Text = "Pharmacy"
        '
        'CSRToolStripMenuItem
        '
        Me.CSRToolStripMenuItem.Name = "CSRToolStripMenuItem"
        Me.CSRToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.CSRToolStripMenuItem.Text = "CSR"
        '
        'pnlBody
        '
        Me.pnlBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlBody.AutoSize = True
        Me.pnlBody.BackColor = System.Drawing.SystemColors.Window
        Me.pnlBody.Location = New System.Drawing.Point(0, 27)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1350, 711)
        Me.pnlBody.TabIndex = 1
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblVersion.Location = New System.Drawing.Point(0, 741)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(39, 13)
        Me.lblVersion.TabIndex = 2
        Me.lblVersion.Text = "Label1"
        '
        'lblComputerName
        '
        Me.lblComputerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblComputerName.AutoSize = True
        Me.lblComputerName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblComputerName.Location = New System.Drawing.Point(439, 741)
        Me.lblComputerName.Name = "lblComputerName"
        Me.lblComputerName.Size = New System.Drawing.Size(39, 13)
        Me.lblComputerName.TabIndex = 3
        Me.lblComputerName.Text = "Label1"
        Me.lblComputerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1350, 754)
        Me.Controls.Add(Me.lblComputerName)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "iHOMIS Data Extractor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CashierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ORDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents ChargesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsignmentSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COAFormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PharmacyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSRToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents ChargesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PharmacyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CSRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblComputerName As System.Windows.Forms.Label
End Class
