<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatVOD
    Inherits BizzLib.frmGeneral_Browse

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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.GCWithDate = New DevExpress.XtraEditors.GroupControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnSpentCreditEarlier = New DevExpress.XtraEditors.SimpleButton
        Me.speCreditEarlier = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.btnCustomersByWatchedPlush = New DevExpress.XtraEditors.SimpleButton
        Me.btnCustomersNmbrWathed = New DevExpress.XtraEditors.SimpleButton
        Me.btnVodByChannelsPlush = New DevExpress.XtraEditors.SimpleButton
        Me.btnVodByChannels = New DevExpress.XtraEditors.SimpleButton
        Me.btnTopWatchedVOD = New DevExpress.XtraEditors.SimpleButton
        Me.btnTopWatchedKPN = New DevExpress.XtraEditors.SimpleButton
        Me.btnTopWatchedPrisons = New DevExpress.XtraEditors.SimpleButton
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
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GCWithDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GCWithDate.SuspendLayout()
        CType(Me.speCreditEarlier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabParameters.Controls.Add(Me.GCWithDate)
        '
        'TabAnalyse
        '
        Me.TabAnalyse.Size = New System.Drawing.Size(1095, 385)
        '
        'UcPivotGrid1
        '
        Me.UcPivotGrid1.Size = New System.Drawing.Size(1095, 385)
        '
        'UcChart1
        '
        Me.UcChart1.Size = New System.Drawing.Size(1095, 385)
        '
        'TabChart
        '
        Me.TabChart.Size = New System.Drawing.Size(1095, 385)
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(27, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, False)
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "From Date"
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        Me.txtFromDate.Location = New System.Drawing.Point(96, 23)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, False)
        Me.txtFromDate.Size = New System.Drawing.Size(100, 20)
        Me.txtFromDate.TabIndex = 3
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        Me.txtToDate.Location = New System.Drawing.Point(96, 49)
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, False)
        Me.txtToDate.Size = New System.Drawing.Size(100, 20)
        Me.txtToDate.TabIndex = 35
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(27, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, False)
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 36
        Me.LabelControl2.Text = "To Date"
        '
        'GCWithDate
        '
        Me.GCWithDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GCWithDate.Controls.Add(Me.btnTopWatchedPrisons)
        Me.GCWithDate.Controls.Add(Me.btnTopWatchedKPN)
        Me.GCWithDate.Controls.Add(Me.SimpleButton1)
        Me.GCWithDate.Controls.Add(Me.btnSpentCreditEarlier)
        Me.GCWithDate.Controls.Add(Me.speCreditEarlier)
        Me.GCWithDate.Controls.Add(Me.LabelControl3)
        Me.GCWithDate.Controls.Add(Me.btnCustomersByWatchedPlush)
        Me.GCWithDate.Controls.Add(Me.btnCustomersNmbrWathed)
        Me.GCWithDate.Controls.Add(Me.btnVodByChannelsPlush)
        Me.GCWithDate.Controls.Add(Me.btnVodByChannels)
        Me.GCWithDate.Controls.Add(Me.btnTopWatchedVOD)
        Me.GCWithDate.Controls.Add(Me.LabelControl2)
        Me.GCWithDate.Controls.Add(Me.txtToDate)
        Me.GCWithDate.Controls.Add(Me.LabelControl1)
        Me.GCWithDate.Controls.Add(Me.txtFromDate)
        Me.GCWithDate.Location = New System.Drawing.Point(23, 24)
        Me.GCWithDate.Name = "GCWithDate"
        Me.GCWithDate.Size = New System.Drawing.Size(1016, 339)
        Me.GCWithDate.TabIndex = 38
        Me.GCWithDate.Text = "Stat With Date"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(424, 202)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.HelpProvider1.SetShowHelp(Me.SimpleButton1, False)
        Me.SimpleButton1.Size = New System.Drawing.Size(183, 46)
        Me.SimpleButton1.TabIndex = 47
        Me.SimpleButton1.Text = "Not Spent Credits"
        '
        'btnSpentCreditEarlier
        '
        Me.btnSpentCreditEarlier.Location = New System.Drawing.Point(762, 79)
        Me.btnSpentCreditEarlier.Name = "btnSpentCreditEarlier"
        Me.HelpProvider1.SetShowHelp(Me.btnSpentCreditEarlier, False)
        Me.btnSpentCreditEarlier.Size = New System.Drawing.Size(183, 46)
        Me.btnSpentCreditEarlier.TabIndex = 46
        Me.btnSpentCreditEarlier.Text = "Spent Credit Before"
        '
        'speCreditEarlier
        '
        Me.speCreditEarlier.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.speCreditEarlier.Location = New System.Drawing.Point(845, 53)
        Me.speCreditEarlier.Name = "speCreditEarlier"
        Me.speCreditEarlier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.speCreditEarlier.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
        Me.speCreditEarlier.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.speCreditEarlier.Size = New System.Drawing.Size(100, 20)
        Me.speCreditEarlier.TabIndex = 45
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(649, 56)
        Me.LabelControl3.Name = "LabelControl3"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl3, False)
        Me.LabelControl3.Size = New System.Drawing.Size(169, 13)
        Me.LabelControl3.TabIndex = 44
        Me.LabelControl3.Text = "Number of days credit spent earlier"
        '
        'btnCustomersByWatchedPlush
        '
        Me.btnCustomersByWatchedPlush.Location = New System.Drawing.Point(424, 146)
        Me.btnCustomersByWatchedPlush.Name = "btnCustomersByWatchedPlush"
        Me.HelpProvider1.SetShowHelp(Me.btnCustomersByWatchedPlush, False)
        Me.btnCustomersByWatchedPlush.Size = New System.Drawing.Size(183, 46)
        Me.btnCustomersByWatchedPlush.TabIndex = 42
        Me.btnCustomersByWatchedPlush.Text = "#Custom. By #Watched - Plush"
        Me.btnCustomersByWatchedPlush.ToolTip = "#VOD by channels"
        '
        'btnCustomersNmbrWathed
        '
        Me.btnCustomersNmbrWathed.Location = New System.Drawing.Point(424, 87)
        Me.btnCustomersNmbrWathed.Name = "btnCustomersNmbrWathed"
        Me.HelpProvider1.SetShowHelp(Me.btnCustomersNmbrWathed, False)
        Me.btnCustomersNmbrWathed.Size = New System.Drawing.Size(183, 46)
        Me.btnCustomersNmbrWathed.TabIndex = 41
        Me.btnCustomersNmbrWathed.Text = "#Customers by #Watched - DVDPost"
        Me.btnCustomersNmbrWathed.ToolTip = "#VOD by channels"
        '
        'btnVodByChannelsPlush
        '
        Me.btnVodByChannelsPlush.Location = New System.Drawing.Point(218, 149)
        Me.btnVodByChannelsPlush.Name = "btnVodByChannelsPlush"
        Me.HelpProvider1.SetShowHelp(Me.btnVodByChannelsPlush, False)
        Me.btnVodByChannelsPlush.Size = New System.Drawing.Size(183, 46)
        Me.btnVodByChannelsPlush.TabIndex = 40
        Me.btnVodByChannelsPlush.Text = "#VOD by channels - Plush"
        Me.btnVodByChannelsPlush.ToolTip = "#VOD by channels"
        '
        'btnVodByChannels
        '
        Me.btnVodByChannels.Location = New System.Drawing.Point(218, 87)
        Me.btnVodByChannels.Name = "btnVodByChannels"
        Me.HelpProvider1.SetShowHelp(Me.btnVodByChannels, False)
        Me.btnVodByChannels.Size = New System.Drawing.Size(183, 46)
        Me.btnVodByChannels.TabIndex = 39
        Me.btnVodByChannels.Text = "#VOD by channels - DVDPost"
        Me.btnVodByChannels.ToolTip = "#VOD by channels"
        '
        'btnTopWatchedVOD
        '
        Me.btnTopWatchedVOD.Location = New System.Drawing.Point(13, 87)
        Me.btnTopWatchedVOD.Name = "btnTopWatchedVOD"
        Me.HelpProvider1.SetShowHelp(Me.btnTopWatchedVOD, False)
        Me.btnTopWatchedVOD.Size = New System.Drawing.Size(183, 46)
        Me.btnTopWatchedVOD.TabIndex = 38
        Me.btnTopWatchedVOD.Text = "Top Watched VOD"
        Me.btnTopWatchedVOD.ToolTip = "Top watched VOD movies"
        '
        'btnTopWatchedKPN
        '
        Me.btnTopWatchedKPN.Location = New System.Drawing.Point(13, 146)
        Me.btnTopWatchedKPN.Name = "btnTopWatchedKPN"
        Me.HelpProvider1.SetShowHelp(Me.btnTopWatchedKPN, False)
        Me.btnTopWatchedKPN.Size = New System.Drawing.Size(183, 46)
        Me.btnTopWatchedKPN.TabIndex = 48
        Me.btnTopWatchedKPN.Text = "Top Watched VOD KPN"
        Me.btnTopWatchedKPN.ToolTip = "Top watched VOD movies"
        '
        'btnTopWatchedPrisons
        '
        Me.btnTopWatchedPrisons.Location = New System.Drawing.Point(13, 202)
        Me.btnTopWatchedPrisons.Name = "btnTopWatchedPrisons"
        Me.HelpProvider1.SetShowHelp(Me.btnTopWatchedPrisons, False)
        Me.btnTopWatchedPrisons.Size = New System.Drawing.Size(183, 46)
        Me.btnTopWatchedPrisons.TabIndex = 49
        Me.btnTopWatchedPrisons.Text = "Top Watched VOD Prisons"
        Me.btnTopWatchedPrisons.ToolTip = "Top watched VOD movies"
        '
        'frmStatVOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 470)
        Me.Name = "frmStatVOD"
        Me.HelpProvider1.SetShowHelp(Me, False)
        Me.Text = "FrmStat"
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabParameters.ResumeLayout(False)
        Me.TabAnalyse.ResumeLayout(False)
        Me.TabChart.ResumeLayout(False)
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GCWithDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GCWithDate.ResumeLayout(False)
        Me.GCWithDate.PerformLayout()
        CType(Me.speCreditEarlier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GCWithDate As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnTopWatchedVOD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVodByChannels As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnVodByChannelsPlush As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomersNmbrWathed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCustomersByWatchedPlush As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents speCreditEarlier As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnSpentCreditEarlier As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTopWatchedPrisons As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnTopWatchedKPN As DevExpress.XtraEditors.SimpleButton
End Class
