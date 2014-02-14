Imports System.Windows.Forms.Application
Imports System.IO

Public Class frmMandateLettters
    Inherits BizzLib.frmGeneral_Browse

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents btnEddPrepayment As DevExpress.XtraEditors.SimpleButton

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.btnMandateLetters = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtMandateFolder = New DevExpress.XtraEditors.TextEdit
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.btnEddPrepayment = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1.SuspendLayout()
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabParameters.SuspendLayout()
        Me.TabAnalyse.SuspendLayout()
        Me.TabChart.SuspendLayout()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMandateFolder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Size = New System.Drawing.Size(1104, 416)
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        Me.TabControl1.Size = New System.Drawing.Size(1104, 416)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.btnEddPrepayment)
        Me.TabParameters.Controls.Add(Me.txtMandateFolder)
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.btnMandateLetters)
        Me.TabParameters.PageVisible = True
        Me.TabParameters.Size = New System.Drawing.Size(1095, 415)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Size = New System.Drawing.Size(1095, 415)
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Size = New System.Drawing.Size(1095, 415)
        '
        'UcChart1
        '
        Me.UcChart1.Size = New System.Drawing.Size(1095, 415)
        '
        'TabChart
        '
        Me.TabChart.Size = New System.Drawing.Size(1095, 415)
        '
        'btnMandateLetters
        '
        Me.btnMandateLetters.Location = New System.Drawing.Point(387, 25)
        Me.btnMandateLetters.Name = "btnMandateLetters"
        Me.HelpProvider1.SetShowHelp(Me.btnMandateLetters, False)
        Me.btnMandateLetters.Size = New System.Drawing.Size(140, 23)
        Me.btnMandateLetters.TabIndex = 36
        Me.btnMandateLetters.Text = "Create mandate letters"
        Me.btnMandateLetters.ToolTip = "Create domiciliation mandate letters"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl2.TabIndex = 109
        Me.LabelControl2.Text = "Mandate folder"
        '
        'txtMandateFolder
        '
        Me.txtMandateFolder.Location = New System.Drawing.Point(103, 28)
        Me.txtMandateFolder.Name = "txtMandateFolder"
        Me.txtMandateFolder.Size = New System.Drawing.Size(236, 20)
        Me.txtMandateFolder.TabIndex = 110
        '
        'btnEddPrepayment
        '
        Me.btnEddPrepayment.Location = New System.Drawing.Point(387, 70)
        Me.btnEddPrepayment.Name = "btnEddPrepayment"
        Me.HelpProvider1.SetShowHelp(Me.btnEddPrepayment, False)
        Me.btnEddPrepayment.Size = New System.Drawing.Size(177, 23)
        Me.btnEddPrepayment.TabIndex = 111
        Me.btnEddPrepayment.Text = "Send edd prepayment email notif"
        Me.btnEddPrepayment.ToolTip = "Create domiciliation mandate letters"
        '
        'frmMandateLettters
        '
        Me.ClientSize = New System.Drawing.Size(1104, 470)
        Me.Name = "frmMandateLettters"
        Me.HelpProvider1.SetShowHelp(Me, False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabParameters.PerformLayout()
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMandateFolder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMandateFolder As DevExpress.XtraEditors.TextEdit
    Friend WithEvents FolderBrowserDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnMandateLetters As DevExpress.XtraEditors.SimpleButton

    Enum MandateLetters
        CoreLetters = 1104
    End Enum
    Private Sub btnMandateLetters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMandateLetters.Click
        Dim _OffLinePay As DVDPostBuziness.clsCompta = New DVDPostBuziness.clsCompta()
        Dim dt As DataTable
        Dim mandate As DVDPostBuziness.clsMandate = New DVDPostBuziness.clsMandate()
        Dim sql As String = DvdPostData.PaymentOfflineData.GetDom80ToEDDMigration()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        mandate.SendLetter(dt, MandateLetters.CoreLetters, txtMandateFolder.Text)

    End Sub


    Private Sub txtMandateFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMandateFolder.Click
        FolderBrowserDialog.ShowDialog()
        txtMandateFolder.Text = FolderBrowserDialog.SelectedPath
    End Sub

    Private Sub btnEddPrepayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEddPrepayment.Click
        Dim _OffLinePay As New DVDPostBuziness.clsOffLinePayments()
        _OffLinePay.SendEDDPrepaymentMail(Configuration.ConfigurationManager.AppSettings("eddprepaymentnotif"))
    End Sub
End Class
