Imports System.Deployment.Application

Public Class Form1

    Private Sub ORDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ORDetailsToolStripMenuItem.Click
        callforms(frmExtractORDetails, pnlBody)
    End Sub

    Private Sub ORSummaryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        callforms(frmExtractORSummary, pnlBody)
    End Sub

    Private Sub ChargesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargesToolStripMenuItem.Click

    End Sub

    Private Sub PharmacyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        callforms(frmExtractPharmacyCharges, pnlBody)
    End Sub

    Private Sub ConsignmentSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsignmentSetupToolStripMenuItem.Click
        callforms(frmConsignment, pnlBody)
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
End Class