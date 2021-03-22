Imports System.Deployment.Application

Public Class Form1

    Private Sub HomeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeToolStripMenuItem.Click
        pnlBody.Controls.Clear()
    End Sub

    'CTO Receips
    Private Sub ORDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORDetailsToolStripMenuItem.Click
        callforms(frmExtractORDetails, pnlBody)
    End Sub

    Private Sub ORSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        callforms(frmExtractORSummary, pnlBody)
    End Sub

    'Inventory
    Private Sub PharmacyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        callforms(frmExtractPharmacyCharges, pnlBody)
    End Sub

    Private Sub PharmacyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacyToolStripMenuItem1.Click
        callforms(frmExtractPharmacyCharges, pnlBody)
    End Sub

    Private Sub CSRToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSRToolStripMenuItem1.Click
        callforms(frmExtractCSRCharges, pnlBody)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ApplicationDeployment.IsNetworkDeployed Then
            lblVersion.Text = "v" & ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() & "  (c) Joenor Pineda 2020"
        Else
            lblVersion.Text = "v" & Application.ProductVersion & "  (c) Joenor Pineda 2020"
        End If
        lblComputerName.Text = "Device: " & System.Net.Dns.GetHostName
        MenuRights()
        Me.Location = New Point(0, 0)
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
    End Sub

    Private Sub PharmacyToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PharmacyToolStripMenuItem.Click
        CostCenter = 1
        callforms(frmCOACode, pnlBody)
        frmCOACode.frmCOA_Load(e, e)
    End Sub

    Private Sub CSRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CSRToolStripMenuItem.Click
        CostCenter = 2
        callforms(frmCOACode, pnlBody)
        frmCOACode.frmCOA_Load(e, e)
    End Sub

    'Misc
    Private Sub TurnAroundTimeForEmployeesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnAroundTimeForEmployeesToolStripMenuItem.Click
        callforms(frmTATofEmployees, pnlBody)
    End Sub

    'Maintenance
    Private Sub ConsignmentSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsignmentSetupToolStripMenuItem.Click
        callforms(frmConsignment, pnlBody)
    End Sub

    Private Sub MenuRights()

        If lblComputerName.Text.Contains("ACCOUNTING") Then
            CashierToolStripMenuItem.Enabled = True
            MaintenanceToolStripMenuItem.Enabled = True
        ElseIf lblComputerName.Text.Contains("PHARMACY") Or lblComputerName.Text.Contains("CONS") Or lblComputerName.Text.Contains("CSR") Then
            ChargesToolStripMenuItem.Enabled = True
        ElseIf lblComputerName.Text.Contains("SUPPLY") Then
            ChargesToolStripMenuItem.Enabled = True
            MaintenanceToolStripMenuItem.Enabled = True
        ElseIf lblComputerName.Text.Contains("ICT") Then
            CashierToolStripMenuItem.Enabled = True
            ChargesToolStripMenuItem.Enabled = True
            MaintenanceToolStripMenuItem.Enabled = True
        End If
    End Sub
End Class