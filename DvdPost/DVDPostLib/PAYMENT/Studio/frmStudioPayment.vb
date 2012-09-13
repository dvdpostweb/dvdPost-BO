Imports System.IO
Imports System.Collections.Generic
Public Class frmStudioPayment
    Inherits BizzLib.frmBKForm
#Region " Windows Form Designer generated code "

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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents XtraTabStudio As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabResult As DevExpress.XtraTab.XtraTabPage



    Friend WithEvents lblSelected As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkSelected As DevExpress.XtraEditors.CheckEdit

    Friend WithEvents ContextMenu1 As DVDPostBuziness.contextMenu
    Friend WithEvents DsSite1 As DVDPostLib.DsSite
    Friend WithEvents RepositoryItemLookUpCategorie As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStudioSearch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudioSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtStudioNameSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbStudioTypeSearch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudioTypeSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblStudioNameSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnViewAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnNewVodProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridStudio As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colStudioID As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colStudio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colStudioType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colCreditNew As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colCredit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colBillingReportType As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbLanguages As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents chkcolAvailable As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositorycmbSupportVod As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbgridStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents dpDateStart As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtpDateExpired As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cmbLanguagesSubtitleEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents spnedtCredit As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents dpBackcatalogueStart As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dpBackcataloguExpired As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents TabStudio As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblHasBilling As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkHasBillingReport As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnEditStudio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbBillingReportType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblReportType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblMinGlobal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinGlobal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMinBackcatalogueVOD As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinBackcatalogueVOD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblMinimumNewVOD As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMinNewVOD As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFeeBackcatalogue As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_fee_backcatalogue As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFeeForNew As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFeeNew As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCredit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spedCredit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnDeleteStudio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCreditNew As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spedCreditNew As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblStudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancelStudio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbStudioType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtStudioName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblLanguageSound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSaveStudio As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TabCreateReport As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnCreateDetailedReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreateSummaryReport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdBillingReportFormat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblBillingReportFormat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbStudioBilling As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudioBilling As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TabStudioDetailReport As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridStudioDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colHasBilling As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents TabSABAMDetail As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridSABAMDetail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabSABAMSummary As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridSABAMSummary As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnCreateSABAMDetail As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCreateSABAMSummary As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtSABAMTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtSABAMFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbProductType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblProductType As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton




    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudioPayment))
        Me.TabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.cmbStudioSearch = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStudioSearch = New DevExpress.XtraEditors.LabelControl
        Me.txtStudioNameSearch = New DevExpress.XtraEditors.TextEdit
        Me.cmbStudioTypeSearch = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStudioTypeSearch = New DevExpress.XtraEditors.LabelControl
        Me.lblStudioNameSearch = New DevExpress.XtraEditors.LabelControl
        Me.BtnViewAll = New DevExpress.XtraEditors.SimpleButton
        Me.BtnNewVodProduct = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.TabResult = New DevExpress.XtraTab.XtraTabPage
        Me.GridStudio = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colStudioID = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStudio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colStudioType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colCreditNew = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colCredit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colHasBilling = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.colBillingReportType = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguages = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.chkcolAvailable = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.cmbStudio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositorycmbSupportVod = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.cmbgridStatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.dpDateStart = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dtpDateExpired = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.cmbLanguagesSubtitleEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.spnedtCredit = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.dpBackcatalogueStart = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.dpBackcataloguExpired = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.DsSite1 = New DVDPostLib.DsSite
        Me.chkSelected = New DevExpress.XtraEditors.CheckEdit
        Me.lblSelected = New DevExpress.XtraEditors.LabelControl
        Me.ContextMenu1 = New DVDPostBuziness.contextMenu
        Me.XtraTabStudio = New DevExpress.XtraTab.XtraTabControl
        Me.TabStudio = New DevExpress.XtraTab.XtraTabPage
        Me.lblHasBilling = New DevExpress.XtraEditors.LabelControl
        Me.chkHasBillingReport = New DevExpress.XtraEditors.CheckEdit
        Me.btnEditStudio = New DevExpress.XtraEditors.SimpleButton
        Me.cmbBillingReportType = New DevExpress.XtraEditors.LookUpEdit
        Me.lblReportType = New DevExpress.XtraEditors.LabelControl
        Me.lblMinGlobal = New DevExpress.XtraEditors.LabelControl
        Me.txtMinGlobal = New DevExpress.XtraEditors.TextEdit
        Me.lblMinBackcatalogueVOD = New DevExpress.XtraEditors.LabelControl
        Me.txtMinBackcatalogueVOD = New DevExpress.XtraEditors.TextEdit
        Me.lblMinimumNewVOD = New DevExpress.XtraEditors.LabelControl
        Me.txtMinNewVOD = New DevExpress.XtraEditors.TextEdit
        Me.lblFeeBackcatalogue = New DevExpress.XtraEditors.LabelControl
        Me.txt_fee_backcatalogue = New DevExpress.XtraEditors.TextEdit
        Me.lblFeeForNew = New DevExpress.XtraEditors.LabelControl
        Me.txtFeeNew = New DevExpress.XtraEditors.TextEdit
        Me.lblCredit = New DevExpress.XtraEditors.LabelControl
        Me.spedCredit = New DevExpress.XtraEditors.SpinEdit
        Me.btnDeleteStudio = New DevExpress.XtraEditors.SimpleButton
        Me.lblCreditNew = New DevExpress.XtraEditors.LabelControl
        Me.spedCreditNew = New DevExpress.XtraEditors.SpinEdit
        Me.lblStudio = New DevExpress.XtraEditors.LabelControl
        Me.txtId = New DevExpress.XtraEditors.TextEdit
        Me.lblId = New DevExpress.XtraEditors.LabelControl
        Me.btnCancelStudio = New DevExpress.XtraEditors.SimpleButton
        Me.cmbStudioType = New DevExpress.XtraEditors.LookUpEdit
        Me.txtStudioName = New DevExpress.XtraEditors.TextEdit
        Me.lblLanguageSound = New DevExpress.XtraEditors.LabelControl
        Me.btnSaveStudio = New DevExpress.XtraEditors.SimpleButton
        Me.TabCreateReport = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.btnCreateDetailedReport = New DevExpress.XtraEditors.SimpleButton
        Me.btnCreateSummaryReport = New DevExpress.XtraEditors.SimpleButton
        Me.cmdBillingReportFormat = New DevExpress.XtraEditors.LookUpEdit
        Me.lblBillingReportFormat = New DevExpress.XtraEditors.LabelControl
        Me.cmbStudioBilling = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStudioBilling = New DevExpress.XtraEditors.LabelControl
        Me.TabStudioDetailReport = New DevExpress.XtraTab.XtraTabPage
        Me.GridStudioDetail = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.dtSABAMTo = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.dtSABAMFrom = New DevExpress.XtraEditors.DateEdit
        Me.btnCreateSABAMDetail = New DevExpress.XtraEditors.SimpleButton
        Me.btnCreateSABAMSummary = New DevExpress.XtraEditors.SimpleButton
        Me.TabSABAMDetail = New DevExpress.XtraTab.XtraTabPage
        Me.GridSABAMDetail = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.TabSABAMSummary = New DevExpress.XtraTab.XtraTabPage
        Me.GridSABAMSummary = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cmbProductType = New DevExpress.XtraEditors.LookUpEdit
        Me.lblProductType = New DevExpress.XtraEditors.LabelControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSearch.SuspendLayout()
        CType(Me.cmbStudioSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStudioNameSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudioTypeSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabResult.SuspendLayout()
        CType(Me.GridStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorycmbSupportVod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbgridStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDateStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguagesSubtitleEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spnedtCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcatalogueStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcatalogueStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcataloguExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpBackcataloguExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabStudio.SuspendLayout()
        Me.TabStudio.SuspendLayout()
        CType(Me.chkHasBillingReport.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBillingReportType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinGlobal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinBackcatalogueVOD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinNewVOD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fee_backcatalogue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFeeNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spedCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spedCreditNew.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudioType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStudioName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCreateReport.SuspendLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdBillingReportFormat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudioBilling.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabStudioDetailReport.SuspendLayout()
        CType(Me.GridStudioDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.dtSABAMTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSABAMTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSABAMFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtSABAMFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSABAMDetail.SuspendLayout()
        CType(Me.GridSABAMDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSABAMSummary.SuspendLayout()
        CType(Me.GridSABAMSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabSearch
        '
        Me.TabSearch.Controls.Add(Me.cmbStudioSearch)
        Me.TabSearch.Controls.Add(Me.lblStudioSearch)
        Me.TabSearch.Controls.Add(Me.txtStudioNameSearch)
        Me.TabSearch.Controls.Add(Me.cmbStudioTypeSearch)
        Me.TabSearch.Controls.Add(Me.lblStudioTypeSearch)
        Me.TabSearch.Controls.Add(Me.lblStudioNameSearch)
        Me.TabSearch.Controls.Add(Me.BtnViewAll)
        Me.TabSearch.Controls.Add(Me.BtnNewVodProduct)
        Me.TabSearch.Controls.Add(Me.btnSearch)
        Me.TabSearch.Name = "TabSearch"
        resources.ApplyResources(Me.TabSearch, "TabSearch")
        '
        'cmbStudioSearch
        '
        resources.ApplyResources(Me.cmbStudioSearch, "cmbStudioSearch")
        Me.cmbStudioSearch.Name = "cmbStudioSearch"
        Me.cmbStudioSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbStudioSearch.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbStudioSearch.Properties.DisplayMember = "status_desc"
        Me.cmbStudioSearch.Properties.NullText = resources.GetString("cmbStudioSearch.Properties.NullText")
        Me.cmbStudioSearch.Properties.ValueMember = "status_id"
        '
        'lblStudioSearch
        '
        resources.ApplyResources(Me.lblStudioSearch, "lblStudioSearch")
        Me.lblStudioSearch.Name = "lblStudioSearch"
        '
        'txtStudioNameSearch
        '
        resources.ApplyResources(Me.txtStudioNameSearch, "txtStudioNameSearch")
        Me.txtStudioNameSearch.Name = "txtStudioNameSearch"
        '
        'cmbStudioTypeSearch
        '
        resources.ApplyResources(Me.cmbStudioTypeSearch, "cmbStudioTypeSearch")
        Me.cmbStudioTypeSearch.Name = "cmbStudioTypeSearch"
        Me.cmbStudioTypeSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbStudioTypeSearch.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbStudioTypeSearch.Properties.NullText = resources.GetString("cmbStudioTypeSearch.Properties.NullText")
        Me.cmbStudioTypeSearch.Properties.ValueMember = "status_id"
        '
        'lblStudioTypeSearch
        '
        resources.ApplyResources(Me.lblStudioTypeSearch, "lblStudioTypeSearch")
        Me.lblStudioTypeSearch.Name = "lblStudioTypeSearch"
        '
        'lblStudioNameSearch
        '
        resources.ApplyResources(Me.lblStudioNameSearch, "lblStudioNameSearch")
        Me.lblStudioNameSearch.Name = "lblStudioNameSearch"
        '
        'BtnViewAll
        '
        resources.ApplyResources(Me.BtnViewAll, "BtnViewAll")
        Me.BtnViewAll.Name = "BtnViewAll"
        '
        'BtnNewVodProduct
        '
        resources.ApplyResources(Me.BtnNewVodProduct, "BtnNewVodProduct")
        Me.BtnNewVodProduct.Name = "BtnNewVodProduct"
        '
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        '
        'TabResult
        '
        Me.TabResult.Controls.Add(Me.GridStudio)
        Me.TabResult.Name = "TabResult"
        resources.ApplyResources(Me.TabResult, "TabResult")
        '
        'GridStudio
        '
        resources.ApplyResources(Me.GridStudio, "GridStudio")
        Me.GridStudio.EmbeddedNavigator.Name = ""
        Me.GridStudio.FormsUseDefaultLookAndFeel = False
        Me.GridStudio.MainView = Me.GridViewSearch
        Me.GridStudio.Name = "GridStudio"
        Me.GridStudio.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages, Me.chkcolAvailable, Me.cmbStudio, Me.RepositorycmbSupportVod, Me.cmbgridStatus, Me.dpDateStart, Me.dtpDateExpired, Me.cmbLanguagesSubtitleEdit, Me.RepositoryItemLookUpEdit2, Me.spnedtCredit, Me.dpBackcatalogueStart, Me.dpBackcataloguExpired, Me.RepositoryItemCheckEdit1})
        Me.GridStudio.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridViewSearch.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3, Me.GridBand4})
        Me.GridViewSearch.ColumnPanelRowHeight = 45
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colStudio, Me.colStudioType, Me.colCreditNew, Me.colCredit, Me.colStudioID, Me.colHasBilling, Me.colBillingReportType})
        Me.GridViewSearch.CustomizationFormBounds = New System.Drawing.Rectangle(0, 375, 225, 209)
        Me.GridViewSearch.DetailHeight = 50
        Me.GridViewSearch.GridControl = Me.GridStudio
        Me.GridViewSearch.Name = "GridViewSearch"
        Me.GridViewSearch.OptionsView.ColumnAutoWidth = True
        Me.GridViewSearch.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSearch.OptionsView.ShowBands = False
        Me.GridViewSearch.OptionsView.ShowFooter = True
        Me.GridViewSearch.RowHeight = 33
        Me.GridViewSearch.RowSeparatorHeight = 3
        '
        'GridBand1
        '
        resources.ApplyResources(Me.GridBand1, "GridBand1")
        Me.GridBand1.Columns.Add(Me.colStudioID)
        Me.GridBand1.Columns.Add(Me.colStudio)
        '
        'colStudioID
        '
        resources.ApplyResources(Me.colStudioID, "colStudioID")
        Me.colStudioID.FieldName = "studio_id"
        Me.colStudioID.Name = "colStudioID"
        Me.colStudioID.OptionsColumn.AllowEdit = False
        '
        'colStudio
        '
        resources.ApplyResources(Me.colStudio, "colStudio")
        Me.colStudio.FieldName = "studio_name"
        Me.colStudio.Name = "colStudio"
        Me.colStudio.OptionsColumn.AllowEdit = False
        '
        'GridBand3
        '
        resources.ApplyResources(Me.GridBand3, "GridBand3")
        Me.GridBand3.Columns.Add(Me.colStudioType)
        Me.GridBand3.Columns.Add(Me.colCreditNew)
        '
        'colStudioType
        '
        resources.ApplyResources(Me.colStudioType, "colStudioType")
        Me.colStudioType.FieldName = "studio_type"
        Me.colStudioType.Name = "colStudioType"
        Me.colStudioType.OptionsColumn.AllowEdit = False
        '
        'colCreditNew
        '
        resources.ApplyResources(Me.colCreditNew, "colCreditNew")
        Me.colCreditNew.FieldName = "cost_for_new"
        Me.colCreditNew.Name = "colCreditNew"
        Me.colCreditNew.OptionsColumn.AllowEdit = False
        '
        'GridBand4
        '
        resources.ApplyResources(Me.GridBand4, "GridBand4")
        Me.GridBand4.Columns.Add(Me.colCredit)
        Me.GridBand4.Columns.Add(Me.colHasBilling)
        Me.GridBand4.Columns.Add(Me.colBillingReportType)
        '
        'colCredit
        '
        resources.ApplyResources(Me.colCredit, "colCredit")
        Me.colCredit.FieldName = "cost"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.OptionsColumn.AllowEdit = False
        '
        'colHasBilling
        '
        resources.ApplyResources(Me.colHasBilling, "colHasBilling")
        Me.colHasBilling.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colHasBilling.FieldName = "billing_reporting"
        Me.colHasBilling.Name = "colHasBilling"
        '
        'RepositoryItemCheckEdit1
        '
        resources.ApplyResources(Me.RepositoryItemCheckEdit1, "RepositoryItemCheckEdit1")
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "1"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "0"
        '
        'colBillingReportType
        '
        resources.ApplyResources(Me.colBillingReportType, "colBillingReportType")
        Me.colBillingReportType.FieldName = "billing_report_type"
        Me.colBillingReportType.Name = "colBillingReportType"
        '
        'cmbLanguages
        '
        resources.ApplyResources(Me.cmbLanguages, "cmbLanguages")
        Me.cmbLanguages.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbLanguages.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbLanguages.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguages.DisplayMember = "name"
        Me.cmbLanguages.Name = "cmbLanguages"
        Me.cmbLanguages.ValueMember = "languages_id"
        '
        'chkcolAvailable
        '
        resources.ApplyResources(Me.chkcolAvailable, "chkcolAvailable")
        Me.chkcolAvailable.Name = "chkcolAvailable"
        Me.chkcolAvailable.ValueChecked = CType(1, Byte)
        Me.chkcolAvailable.ValueUnchecked = CType(0, Byte)
        '
        'cmbStudio
        '
        resources.ApplyResources(Me.cmbStudio, "cmbStudio")
        Me.cmbStudio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbStudio.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbStudio.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbStudio.DisplayMember = "studio_name"
        Me.cmbStudio.Name = "cmbStudio"
        Me.cmbStudio.ValueMember = "studio_id"
        '
        'RepositorycmbSupportVod
        '
        resources.ApplyResources(Me.RepositorycmbSupportVod, "RepositorycmbSupportVod")
        Me.RepositorycmbSupportVod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositorycmbSupportVod.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositorycmbSupportVod.Name = "RepositorycmbSupportVod"
        '
        'cmbgridStatus
        '
        resources.ApplyResources(Me.cmbgridStatus, "cmbgridStatus")
        Me.cmbgridStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbgridStatus.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbgridStatus.Name = "cmbgridStatus"
        '
        'dpDateStart
        '
        resources.ApplyResources(Me.dpDateStart, "dpDateStart")
        Me.dpDateStart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("dpDateStart.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.dpDateStart.Name = "dpDateStart"
        Me.dpDateStart.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'dtpDateExpired
        '
        resources.ApplyResources(Me.dtpDateExpired, "dtpDateExpired")
        Me.dtpDateExpired.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("dtpDateExpired.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.dtpDateExpired.Name = "dtpDateExpired"
        Me.dtpDateExpired.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'cmbLanguagesSubtitleEdit
        '
        resources.ApplyResources(Me.cmbLanguagesSubtitleEdit, "cmbLanguagesSubtitleEdit")
        Me.cmbLanguagesSubtitleEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbLanguagesSubtitleEdit.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbLanguagesSubtitleEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "language", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbLanguagesSubtitleEdit.DisplayMember = "code"
        Me.cmbLanguagesSubtitleEdit.Name = "cmbLanguagesSubtitleEdit"
        '
        'RepositoryItemLookUpEdit2
        '
        resources.ApplyResources(Me.RepositoryItemLookUpEdit2, "RepositoryItemLookUpEdit2")
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("RepositoryItemLookUpEdit2.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'spnedtCredit
        '
        resources.ApplyResources(Me.spnedtCredit, "spnedtCredit")
        Me.spnedtCredit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spnedtCredit.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.spnedtCredit.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spnedtCredit.Name = "spnedtCredit"
        '
        'dpBackcatalogueStart
        '
        resources.ApplyResources(Me.dpBackcatalogueStart, "dpBackcatalogueStart")
        Me.dpBackcatalogueStart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("dpBackcatalogueStart.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.dpBackcatalogueStart.Name = "dpBackcatalogueStart"
        Me.dpBackcatalogueStart.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'dpBackcataloguExpired
        '
        resources.ApplyResources(Me.dpBackcataloguExpired, "dpBackcataloguExpired")
        Me.dpBackcataloguExpired.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("dpBackcataloguExpired.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.dpBackcataloguExpired.Name = "dpBackcataloguExpired"
        Me.dpBackcataloguExpired.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'DsSite1
        '
        Me.DsSite1.DataSetName = "DsSite"
        Me.DsSite1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'chkSelected
        '
        Me.chkSelected.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsSite1, "themes_events.selected", True))
        resources.ApplyResources(Me.chkSelected, "chkSelected")
        Me.chkSelected.Name = "chkSelected"
        Me.chkSelected.Properties.Caption = resources.GetString("chkSelected.Properties.Caption")
        '
        'lblSelected
        '
        resources.ApplyResources(Me.lblSelected, "lblSelected")
        Me.lblSelected.Name = "lblSelected"
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Name = "ContextMenu1"
        resources.ApplyResources(Me.ContextMenu1, "ContextMenu1")
        '
        'XtraTabStudio
        '
        resources.ApplyResources(Me.XtraTabStudio, "XtraTabStudio")
        Me.XtraTabStudio.Name = "XtraTabStudio"
        Me.XtraTabStudio.SelectedTabPage = Me.TabResult
        Me.XtraTabStudio.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabSearch, Me.TabResult, Me.TabStudio, Me.TabCreateReport, Me.TabStudioDetailReport, Me.XtraTabPage1, Me.TabSABAMDetail, Me.TabSABAMSummary})
        '
        'TabStudio
        '
        Me.TabStudio.Controls.Add(Me.lblHasBilling)
        Me.TabStudio.Controls.Add(Me.chkHasBillingReport)
        Me.TabStudio.Controls.Add(Me.btnEditStudio)
        Me.TabStudio.Controls.Add(Me.cmbBillingReportType)
        Me.TabStudio.Controls.Add(Me.lblReportType)
        Me.TabStudio.Controls.Add(Me.lblMinGlobal)
        Me.TabStudio.Controls.Add(Me.txtMinGlobal)
        Me.TabStudio.Controls.Add(Me.lblMinBackcatalogueVOD)
        Me.TabStudio.Controls.Add(Me.txtMinBackcatalogueVOD)
        Me.TabStudio.Controls.Add(Me.lblMinimumNewVOD)
        Me.TabStudio.Controls.Add(Me.txtMinNewVOD)
        Me.TabStudio.Controls.Add(Me.lblFeeBackcatalogue)
        Me.TabStudio.Controls.Add(Me.txt_fee_backcatalogue)
        Me.TabStudio.Controls.Add(Me.lblFeeForNew)
        Me.TabStudio.Controls.Add(Me.txtFeeNew)
        Me.TabStudio.Controls.Add(Me.lblCredit)
        Me.TabStudio.Controls.Add(Me.spedCredit)
        Me.TabStudio.Controls.Add(Me.btnDeleteStudio)
        Me.TabStudio.Controls.Add(Me.lblCreditNew)
        Me.TabStudio.Controls.Add(Me.spedCreditNew)
        Me.TabStudio.Controls.Add(Me.lblStudio)
        Me.TabStudio.Controls.Add(Me.txtId)
        Me.TabStudio.Controls.Add(Me.lblId)
        Me.TabStudio.Controls.Add(Me.btnCancelStudio)
        Me.TabStudio.Controls.Add(Me.cmbStudioType)
        Me.TabStudio.Controls.Add(Me.txtStudioName)
        Me.TabStudio.Controls.Add(Me.lblLanguageSound)
        Me.TabStudio.Controls.Add(Me.btnSaveStudio)
        Me.TabStudio.Name = "TabStudio"
        resources.ApplyResources(Me.TabStudio, "TabStudio")
        '
        'lblHasBilling
        '
        resources.ApplyResources(Me.lblHasBilling, "lblHasBilling")
        Me.lblHasBilling.Name = "lblHasBilling"
        '
        'chkHasBillingReport
        '
        resources.ApplyResources(Me.chkHasBillingReport, "chkHasBillingReport")
        Me.chkHasBillingReport.Name = "chkHasBillingReport"
        Me.chkHasBillingReport.Properties.Caption = resources.GetString("chkHasBillingReport.Properties.Caption")
        '
        'btnEditStudio
        '
        resources.ApplyResources(Me.btnEditStudio, "btnEditStudio")
        Me.btnEditStudio.Name = "btnEditStudio"
        '
        'cmbBillingReportType
        '
        resources.ApplyResources(Me.cmbBillingReportType, "cmbBillingReportType")
        Me.cmbBillingReportType.Name = "cmbBillingReportType"
        Me.cmbBillingReportType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbBillingReportType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbBillingReportType.Properties.NullText = resources.GetString("cmbBillingReportType.Properties.NullText")
        Me.cmbBillingReportType.Properties.ValueMember = "id"
        '
        'lblReportType
        '
        resources.ApplyResources(Me.lblReportType, "lblReportType")
        Me.lblReportType.Name = "lblReportType"
        '
        'lblMinGlobal
        '
        resources.ApplyResources(Me.lblMinGlobal, "lblMinGlobal")
        Me.lblMinGlobal.Name = "lblMinGlobal"
        '
        'txtMinGlobal
        '
        resources.ApplyResources(Me.txtMinGlobal, "txtMinGlobal")
        Me.txtMinGlobal.Name = "txtMinGlobal"
        '
        'lblMinBackcatalogueVOD
        '
        resources.ApplyResources(Me.lblMinBackcatalogueVOD, "lblMinBackcatalogueVOD")
        Me.lblMinBackcatalogueVOD.Name = "lblMinBackcatalogueVOD"
        '
        'txtMinBackcatalogueVOD
        '
        resources.ApplyResources(Me.txtMinBackcatalogueVOD, "txtMinBackcatalogueVOD")
        Me.txtMinBackcatalogueVOD.Name = "txtMinBackcatalogueVOD"
        '
        'lblMinimumNewVOD
        '
        resources.ApplyResources(Me.lblMinimumNewVOD, "lblMinimumNewVOD")
        Me.lblMinimumNewVOD.Name = "lblMinimumNewVOD"
        '
        'txtMinNewVOD
        '
        resources.ApplyResources(Me.txtMinNewVOD, "txtMinNewVOD")
        Me.txtMinNewVOD.Name = "txtMinNewVOD"
        '
        'lblFeeBackcatalogue
        '
        resources.ApplyResources(Me.lblFeeBackcatalogue, "lblFeeBackcatalogue")
        Me.lblFeeBackcatalogue.Name = "lblFeeBackcatalogue"
        '
        'txt_fee_backcatalogue
        '
        resources.ApplyResources(Me.txt_fee_backcatalogue, "txt_fee_backcatalogue")
        Me.txt_fee_backcatalogue.Name = "txt_fee_backcatalogue"
        '
        'lblFeeForNew
        '
        resources.ApplyResources(Me.lblFeeForNew, "lblFeeForNew")
        Me.lblFeeForNew.Name = "lblFeeForNew"
        '
        'txtFeeNew
        '
        resources.ApplyResources(Me.txtFeeNew, "txtFeeNew")
        Me.txtFeeNew.Name = "txtFeeNew"
        Me.txtFeeNew.Properties.Mask.IgnoreMaskBlank = CType(resources.GetObject("txtFeeNew.Properties.Mask.IgnoreMaskBlank"), Boolean)
        '
        'lblCredit
        '
        resources.ApplyResources(Me.lblCredit, "lblCredit")
        Me.lblCredit.Name = "lblCredit"
        '
        'spedCredit
        '
        resources.ApplyResources(Me.spedCredit, "spedCredit")
        Me.spedCredit.Name = "spedCredit"
        Me.spedCredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spedCredit.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.spedCredit.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnDeleteStudio
        '
        resources.ApplyResources(Me.btnDeleteStudio, "btnDeleteStudio")
        Me.btnDeleteStudio.Name = "btnDeleteStudio"
        '
        'lblCreditNew
        '
        resources.ApplyResources(Me.lblCreditNew, "lblCreditNew")
        Me.lblCreditNew.Name = "lblCreditNew"
        '
        'spedCreditNew
        '
        resources.ApplyResources(Me.spedCreditNew, "spedCreditNew")
        Me.spedCreditNew.Name = "spedCreditNew"
        Me.spedCreditNew.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spedCreditNew.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.spedCreditNew.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblStudio
        '
        resources.ApplyResources(Me.lblStudio, "lblStudio")
        Me.lblStudio.Name = "lblStudio"
        '
        'txtId
        '
        resources.ApplyResources(Me.txtId, "txtId")
        Me.txtId.Name = "txtId"
        '
        'lblId
        '
        resources.ApplyResources(Me.lblId, "lblId")
        Me.lblId.Name = "lblId"
        '
        'btnCancelStudio
        '
        resources.ApplyResources(Me.btnCancelStudio, "btnCancelStudio")
        Me.btnCancelStudio.Name = "btnCancelStudio"
        '
        'cmbStudioType
        '
        resources.ApplyResources(Me.cmbStudioType, "cmbStudioType")
        Me.cmbStudioType.Name = "cmbStudioType"
        Me.cmbStudioType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbStudioType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbStudioType.Properties.NullText = resources.GetString("cmbStudioType.Properties.NullText")
        Me.cmbStudioType.Properties.ValueMember = "id"
        '
        'txtStudioName
        '
        resources.ApplyResources(Me.txtStudioName, "txtStudioName")
        Me.txtStudioName.Name = "txtStudioName"
        '
        'lblLanguageSound
        '
        resources.ApplyResources(Me.lblLanguageSound, "lblLanguageSound")
        Me.lblLanguageSound.Name = "lblLanguageSound"
        '
        'btnSaveStudio
        '
        resources.ApplyResources(Me.btnSaveStudio, "btnSaveStudio")
        Me.btnSaveStudio.Name = "btnSaveStudio"
        '
        'TabCreateReport
        '
        Me.TabCreateReport.Controls.Add(Me.LabelControl1)
        Me.TabCreateReport.Controls.Add(Me.txtToDate)
        Me.TabCreateReport.Controls.Add(Me.LabelControl4)
        Me.TabCreateReport.Controls.Add(Me.txtFromDate)
        Me.TabCreateReport.Controls.Add(Me.btnCreateDetailedReport)
        Me.TabCreateReport.Controls.Add(Me.btnCreateSummaryReport)
        Me.TabCreateReport.Controls.Add(Me.cmdBillingReportFormat)
        Me.TabCreateReport.Controls.Add(Me.lblBillingReportFormat)
        Me.TabCreateReport.Controls.Add(Me.cmbStudioBilling)
        Me.TabCreateReport.Controls.Add(Me.lblStudioBilling)
        Me.TabCreateReport.Name = "TabCreateReport"
        resources.ApplyResources(Me.TabCreateReport, "TabCreateReport")
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        resources.ApplyResources(Me.txtToDate, "txtToDate")
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        resources.ApplyResources(Me.txtFromDate, "txtFromDate")
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'btnCreateDetailedReport
        '
        resources.ApplyResources(Me.btnCreateDetailedReport, "btnCreateDetailedReport")
        Me.btnCreateDetailedReport.Name = "btnCreateDetailedReport"
        '
        'btnCreateSummaryReport
        '
        resources.ApplyResources(Me.btnCreateSummaryReport, "btnCreateSummaryReport")
        Me.btnCreateSummaryReport.Name = "btnCreateSummaryReport"
        '
        'cmdBillingReportFormat
        '
        resources.ApplyResources(Me.cmdBillingReportFormat, "cmdBillingReportFormat")
        Me.cmdBillingReportFormat.Name = "cmdBillingReportFormat"
        Me.cmdBillingReportFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmdBillingReportFormat.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmdBillingReportFormat.Properties.DisplayMember = "status_desc"
        Me.cmdBillingReportFormat.Properties.NullText = resources.GetString("cmdBillingReportFormat.Properties.NullText")
        Me.cmdBillingReportFormat.Properties.ValueMember = "status_id"
        '
        'lblBillingReportFormat
        '
        resources.ApplyResources(Me.lblBillingReportFormat, "lblBillingReportFormat")
        Me.lblBillingReportFormat.Name = "lblBillingReportFormat"
        '
        'cmbStudioBilling
        '
        resources.ApplyResources(Me.cmbStudioBilling, "cmbStudioBilling")
        Me.cmbStudioBilling.Name = "cmbStudioBilling"
        Me.cmbStudioBilling.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbStudioBilling.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbStudioBilling.Properties.DisplayMember = "status_desc"
        Me.cmbStudioBilling.Properties.NullText = resources.GetString("cmbStudioBilling.Properties.NullText")
        Me.cmbStudioBilling.Properties.ValueMember = "status_id"
        '
        'lblStudioBilling
        '
        resources.ApplyResources(Me.lblStudioBilling, "lblStudioBilling")
        Me.lblStudioBilling.Name = "lblStudioBilling"
        '
        'TabStudioDetailReport
        '
        Me.TabStudioDetailReport.Controls.Add(Me.GridStudioDetail)
        Me.TabStudioDetailReport.Name = "TabStudioDetailReport"
        resources.ApplyResources(Me.TabStudioDetailReport, "TabStudioDetailReport")
        '
        'GridStudioDetail
        '
        resources.ApplyResources(Me.GridStudioDetail, "GridStudioDetail")
        Me.GridStudioDetail.EmbeddedNavigator.Name = ""
        Me.GridStudioDetail.FormsUseDefaultLookAndFeel = False
        Me.GridStudioDetail.MainView = Me.GridView1
        Me.GridStudioDetail.Name = "GridStudioDetail"
        Me.GridStudioDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridStudioDetail
        Me.GridView1.Name = "GridView1"
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.cmbProductType)
        Me.XtraTabPage1.Controls.Add(Me.lblProductType)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.dtSABAMTo)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage1.Controls.Add(Me.dtSABAMFrom)
        Me.XtraTabPage1.Controls.Add(Me.btnCreateSABAMDetail)
        Me.XtraTabPage1.Controls.Add(Me.btnCreateSABAMSummary)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        resources.ApplyResources(Me.XtraTabPage1, "XtraTabPage1")
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        '
        'dtSABAMTo
        '
        Me.dtSABAMTo.EditValue = Nothing
        resources.ApplyResources(Me.dtSABAMTo, "dtSABAMTo")
        Me.dtSABAMTo.Name = "dtSABAMTo"
        Me.dtSABAMTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("dtSABAMTo.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.dtSABAMTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        '
        'dtSABAMFrom
        '
        Me.dtSABAMFrom.EditValue = Nothing
        resources.ApplyResources(Me.dtSABAMFrom, "dtSABAMFrom")
        Me.dtSABAMFrom.Name = "dtSABAMFrom"
        Me.dtSABAMFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("dtSABAMFrom.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.dtSABAMFrom.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'btnCreateSABAMDetail
        '
        resources.ApplyResources(Me.btnCreateSABAMDetail, "btnCreateSABAMDetail")
        Me.btnCreateSABAMDetail.Name = "btnCreateSABAMDetail"
        '
        'btnCreateSABAMSummary
        '
        resources.ApplyResources(Me.btnCreateSABAMSummary, "btnCreateSABAMSummary")
        Me.btnCreateSABAMSummary.Name = "btnCreateSABAMSummary"
        '
        'TabSABAMDetail
        '
        Me.TabSABAMDetail.Controls.Add(Me.GridSABAMDetail)
        Me.TabSABAMDetail.Name = "TabSABAMDetail"
        resources.ApplyResources(Me.TabSABAMDetail, "TabSABAMDetail")
        '
        'GridSABAMDetail
        '
        resources.ApplyResources(Me.GridSABAMDetail, "GridSABAMDetail")
        Me.GridSABAMDetail.EmbeddedNavigator.Name = ""
        Me.GridSABAMDetail.FormsUseDefaultLookAndFeel = False
        Me.GridSABAMDetail.MainView = Me.GridView2
        Me.GridSABAMDetail.Name = "GridSABAMDetail"
        Me.GridSABAMDetail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridSABAMDetail
        Me.GridView2.Name = "GridView2"
        '
        'TabSABAMSummary
        '
        Me.TabSABAMSummary.Controls.Add(Me.GridSABAMSummary)
        Me.TabSABAMSummary.Name = "TabSABAMSummary"
        resources.ApplyResources(Me.TabSABAMSummary, "TabSABAMSummary")
        '
        'GridSABAMSummary
        '
        resources.ApplyResources(Me.GridSABAMSummary, "GridSABAMSummary")
        Me.GridSABAMSummary.EmbeddedNavigator.Name = ""
        Me.GridSABAMSummary.FormsUseDefaultLookAndFeel = False
        Me.GridSABAMSummary.MainView = Me.GridView3
        Me.GridSABAMSummary.Name = "GridSABAMSummary"
        Me.GridSABAMSummary.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.GridControl = Me.GridSABAMSummary
        Me.GridView3.Name = "GridView3"
        '
        'cmbProductType
        '
        resources.ApplyResources(Me.cmbProductType, "cmbProductType")
        Me.cmbProductType.Name = "cmbProductType"
        Me.cmbProductType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbProductType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbProductType.Properties.NullText = resources.GetString("cmbProductType.Properties.NullText")
        '
        'lblProductType
        '
        resources.ApplyResources(Me.lblProductType, "lblProductType")
        Me.lblProductType.Name = "lblProductType"
        '
        'frmStudioPayment
        '
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.XtraTabStudio)
        Me.Name = "frmStudioPayment"
        Me.Controls.SetChildIndex(Me.XtraTabStudio, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSearch.ResumeLayout(False)
        Me.TabSearch.PerformLayout()
        CType(Me.cmbStudioSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStudioNameSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudioTypeSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabResult.ResumeLayout(False)
        CType(Me.GridStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorycmbSupportVod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbgridStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDateStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguagesSubtitleEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spnedtCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcatalogueStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcatalogueStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcataloguExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpBackcataloguExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsSite1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkSelected.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabStudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabStudio.ResumeLayout(False)
        Me.TabStudio.ResumeLayout(False)
        Me.TabStudio.PerformLayout()
        CType(Me.chkHasBillingReport.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBillingReportType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinGlobal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinBackcatalogueVOD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinNewVOD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fee_backcatalogue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFeeNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spedCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spedCreditNew.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudioType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStudioName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCreateReport.ResumeLayout(False)
        Me.TabCreateReport.PerformLayout()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdBillingReportFormat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudioBilling.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabStudioDetailReport.ResumeLayout(False)
        CType(Me.GridStudioDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.dtSABAMTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSABAMTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSABAMFrom.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtSABAMFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSABAMDetail.ResumeLayout(False)
        CType(Me.GridSABAMDetail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSABAMSummary.ResumeLayout(False)
        CType(Me.GridSABAMSummary, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim CurrentCodeType As String
    Dim _enableField As Boolean
    Dim _sql As String

    Dim WithEvents _ExportExcel As DevExpress.XtraBars.BarButtonItem = MainBtns_btnExcel
    Dim WithEvents SFDExportExcel As New System.Windows.Forms.SaveFileDialog


    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewSearch.OptionsView.ColumnAutoWidth = False
        GridViewSearch.OptionsBehavior.Editable = False

        XtraTabStudio.SelectedTabPage = TabSearch
        ' Misc_Bar.Visible = True

        Misc_Bar.Visible = True
        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridStudio.ContextMenuStrip = menuStrip
        txtFromDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        txtToDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)


        loadStudioType()
        loadStudioSearch()
        loadBillingReportType()
        loadStudioBilling()
        loadProductsType()


    End Sub

    Private Sub btnexcel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _ExportExcel.ItemClick
        SFDExportExcel.DefaultExt = "xls"
        SFDExportExcel.Filter = "Excel(*.xls)|*.xls"
        If SFDExportExcel.ShowDialog() = Windows.Forms.DialogResult.OK Then
            GridStudioDetail.ExportToXls(SFDExportExcel.FileName)
        End If
    End Sub


    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
        CHOOSEVOD
        DETAILED
    End Enum

    Enum typeSearch
        DETAIL
        ALL
    End Enum
    Private _typesearch As typeSearch
    Private Sub initForm()
        Dim blank As String = String.Empty

        txtId.EditValue = Nothing

        txtId.EditValue = blank
        txtStudioName.EditValue = blank
        cmbStudioType.EditValue = blank
        spedCreditNew.EditValue = blank
        spedCredit.EditValue = blank
        txtFeeNew.EditValue = blank
        txt_fee_backcatalogue.EditValue = blank
        txtMinNewVOD.EditValue = blank
        txtMinBackcatalogueVOD.EditValue = blank
        txtMinGlobal.EditValue = blank
        chkHasBillingReport.Checked = False
        cmbBillingReportType.EditValue = blank

    End Sub


    Private Sub loadData(ByVal row As DataRow)

        If row("studio_id") Is DBNull.Value Then
            txtId.EditValue = ""
        Else
            txtId.EditValue = row("studio_id")
        End If
        If row("studio_name") Is DBNull.Value Then
            txtStudioName.EditValue = ""
        Else
            txtStudioName.EditValue = row("studio_name")
        End If

        If row("studio_type") Is DBNull.Value Then
            cmbStudioType.EditValue = ""
        Else
            cmbStudioType.EditValue = row("studio_type")
        End If
        If row("cost_for_new") Is DBNull.Value Then
            spedCreditNew.EditValue = 0
        Else
            spedCreditNew.EditValue = row("cost_for_new")
        End If
        If row("cost") Is DBNull.Value Then
            spedCredit.EditValue = 0
        Else
            spedCredit.EditValue = row("cost")
        End If
        If row("fee_new_vod") Is DBNull.Value Then
            txtFeeNew.EditValue = 0
        Else
            txtFeeNew.EditValue = row("fee_new_vod")
        End If
        If row("fee_back_catalogue") Is DBNull.Value Then
            txt_fee_backcatalogue.EditValue = 0
        Else
            txt_fee_backcatalogue.EditValue = row("fee_back_catalogue")
        End If
        If row("minimum_new_vod") Is DBNull.Value Then
            txtMinNewVOD.EditValue = 0
        Else
            txtMinNewVOD.EditValue = row("minimum_new_vod")
        End If

        If row("minimum_back_catalogue") Is DBNull.Value Then
            txtMinBackcatalogueVOD.EditValue = 0
        Else
            txtMinBackcatalogueVOD.EditValue = row("minimum_back_catalogue")
        End If
        If row("minimum_global") Is DBNull.Value Then
            txtMinGlobal.EditValue = 0
        Else
            txtMinGlobal.EditValue = row("minimum_global")
        End If

        If row("billing_reporting") = 0 Then
            chkHasBillingReport.Checked = False
        Else
            chkHasBillingReport.Checked = True
        End If

        If row("billing_report_type") Is DBNull.Value Then
            cmbBillingReportType.EditValue = ""
        Else
            cmbBillingReportType.EditValue = row("billing_report_type")
        End If

    End Sub

    Private Sub EnableField(ByVal enable As Boolean)


        txtStudioName.Enabled = enable
        cmbStudioType.Enabled = enable
        txtFeeNew.Enabled = enable
        txt_fee_backcatalogue.Enabled = enable
        spedCredit.Enabled = enable
        spedCreditNew.Enabled = enable
        txtMinBackcatalogueVOD.Enabled = enable
        txtMinNewVOD.Enabled = enable
        txtMinGlobal.Enabled = enable
        chkHasBillingReport.Enabled = enable
        cmbBillingReportType.Enabled = enable And chkHasBillingReport.Checked

    End Sub
    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditStudio.Enabled = True
                btnSaveStudio.Enabled = False
                btnCancelStudio.Enabled = False
                btnDeleteStudio.Enabled = True

                EnableField(False)

                'TabSearch.PageVisible = True
                'TabResult.PageVisible = True

            Case StepForm.EDIT
                btnEditStudio.Enabled = False
                btnSaveStudio.Enabled = True
                btnCancelStudio.Enabled = True
                btnDeleteStudio.Enabled = True

                EnableField(True)
                'TabStudio.PageVisible = True
                'TabResult.PageVisible = False

            Case StepForm.INIT
                btnEditStudio.Enabled = False
                btnSaveStudio.Enabled = False
                btnCancelStudio.Enabled = False
                btnDeleteStudio.Enabled = False

                EnableField(False)

                'TabResult.PageVisible = True
                'TabSearch.PageVisible = True
                'TabStudio.PageVisible = False
                XtraTabStudio.SelectedTabPage = TabSearch


            Case StepForm.[NEW]
                btnEditStudio.Enabled = False
                btnSaveStudio.Enabled = True
                btnCancelStudio.Enabled = True
                btnDeleteStudio.Enabled = False

                EnableField(True)
                'TabResult.PageVisible = False
                'TabStudio.PageVisible = True
                XtraTabStudio.SelectedTabPage = TabStudio

            Case StepForm.SAVE
                btnEditStudio.Enabled = True
                btnSaveStudio.Enabled = False
                btnCancelStudio.Enabled = False
                btnDeleteStudio.Enabled = True

                EnableField(False)
                'TabStudio.PageVisible = True
                'TabResult.PageVisible = True

            Case StepForm.LOAD
                btnEditStudio.Enabled = True
                btnSaveStudio.Enabled = False
                btnCancelStudio.Enabled = False

                EnableField(False)
                'TabSearch.PageVisible = False
                'TabResult.PageVisible = True

                XtraTabStudio.SelectedTabPage = TabResult

            Case StepForm.CHOOSEVOD
                btnEditStudio.Enabled = True
                btnSaveStudio.Enabled = False
                btnCancelStudio.Enabled = False

                EnableField(False)
                'TabResult.PageVisible = False
                'TabStudio.PageVisible = True
                XtraTabStudio.SelectedTabPage = TabStudio

            Case StepForm.DETAILED
                btnEditStudio.Enabled = False
                btnSaveStudio.Enabled = False
                btnCancelStudio.Enabled = False

                EnableField(False)
                'XTabResult.PageVisible = True
                'XTabView.PageVisible = False
                XtraTabStudio.SelectedTabPage = TabStudio

        End Select
        XtraTabStudio.Refresh()
    End Sub

    Private Sub loadBillingReportType()

        Dim lstBillingReportType As List(Of DVDPostBuziness.clsKeyComboEnum)
        Dim sqlBillingReportType As String

        sqlBillingReportType = DvdPostData.clsStudio.GetEnumMysqlBillingReportType()
        lstBillingReportType = DVDPostBuziness.ClsCombo.GetListEnum(sqlBillingReportType)

        cmbBillingReportType.Properties.ValueMember = "Value"
        cmbBillingReportType.Properties.DisplayMember = "DisplayMember"
        cmbBillingReportType.Properties.DataSource = lstBillingReportType
    End Sub

    Private Sub loadStudioType()


        Dim lstStudioTypeSearch As List(Of DVDPostBuziness.clsKeyComboEnum)
        Dim lstStudioType As List(Of DVDPostBuziness.clsKeyComboEnum)
        Dim sqlStudioType As String

        sqlStudioType = DvdPostData.clsStudio.GetEnumMysqlStudioType()
        lstStudioTypeSearch = DVDPostBuziness.ClsCombo.GetListEnum(sqlStudioType)
        lstStudioType = DVDPostBuziness.ClsCombo.GetListEnum(sqlStudioType)

        cmbStudioTypeSearch.Properties.ValueMember = "Value"
        cmbStudioTypeSearch.Properties.DisplayMember = "DisplayMember"
        cmbStudioTypeSearch.Properties.DataSource = lstStudioTypeSearch

        cmbStudioType.Properties.ValueMember = "Value"
        cmbStudioType.Properties.DisplayMember = "DisplayMember"
        cmbStudioType.Properties.DataSource = lstStudioType
    End Sub
    Private Sub loadStudioSearch()

        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.ClsVod.GetStudio()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        cmbStudioSearch.Properties.ValueMember = "studio_id"
        cmbStudioSearch.Properties.DisplayMember = "studio_name"
        cmbStudioSearch.Properties.DataSource = dt
    End Sub

    Private Sub loadStudioBilling()

        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsStudio.GetStudioBilling()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Dim dr As DataRow = dt.NewRow()
        dr("studio_id") = -1
        dr("studio_name") = "All studios"

        dt.Rows.Add(dr)

        cmbStudioBilling.Properties.ValueMember = "studio_id"
        cmbStudioBilling.Properties.DisplayMember = "studio_name"
        cmbStudioBilling.Properties.DataSource = dt
    End Sub

    'Private Sub loadInfoStudio()

    '    Dim row As DataRow
    '    If GridViewSearch.RowCount > 0 Then
    '        row = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle())
    '        loadData(row)
    '    End If
    'End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim sql As String
        Dim dt As DataTable = Nothing

        If cmbStudioSearch.Text <> String.Empty Then
            sql = DvdPostData.clsStudio.getSelectStudioByStudioID(cmbStudioSearch.EditValue)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
        Else
            sql = DvdPostData.clsStudio.getSelectStudioByStudioNameAndStudioType(txtStudioNameSearch.EditValue, cmbStudioTypeSearch.Text)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
        End If
        If Not dt Is Nothing Then
            GridStudio.DataSource = dt
            ChangeStep(StepForm.LOAD)
            _typesearch = typeSearch.DETAIL
        End If


    End Sub
    Private Function Save() As Boolean
        Dim sql As String
        sql = ""
        Try
            If txtId.EditValue Is Nothing Then
                sql = DvdPostData.clsStudio.getInsertStudio(txtStudioName.EditValue, cmbStudioType.EditValue, spedCreditNew.EditValue, spedCredit.EditValue, txtFeeNew.EditValue, _
                    txt_fee_backcatalogue.EditValue, txtMinNewVOD.EditValue, txtMinBackcatalogueVOD.EditValue, txtMinGlobal.EditValue, chkHasBillingReport.Checked, cmbBillingReportType.EditValue)
                DvdPostData.clsConnection.ExecuteNonQuery(sql)
            Else
                sql = DvdPostData.clsStudio.getUpdateStudio(txtId.EditValue, txtStudioName.EditValue, cmbStudioType.EditValue, spedCreditNew.EditValue, spedCredit.EditValue, _
                    txtFeeNew.EditValue, txt_fee_backcatalogue.EditValue, txtMinNewVOD.EditValue, txtMinBackcatalogueVOD.EditValue, txtMinGlobal.EditValue, chkHasBillingReport.Checked, cmbBillingReportType.EditValue)
                DvdPostData.clsConnection.ExecuteNonQuery(sql)

            End If
            Return True
        Catch ex As Exception
            MsgBox(sql, MsgBoxStyle.Information)
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Vod, ex)
            Return False
        End Try
    End Function

    Private Sub btnSaveStudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveStudio.Click
        If Save() Then
            ChangeStep(StepForm.SAVE)
            If _typesearch = typeSearch.DETAIL Then
                btnSearch_Click(Nothing, Nothing)
            Else
                BtnViewAll_Click(Nothing, Nothing)
            End If
        Else
            MsgBox("Error Save Studio (voir log)", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnEditStudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditStudio.Click
        ChangeStep(StepForm.EDIT)
    End Sub

    Private Sub GridStudio_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridStudio.DoubleClick
        loadInfoStudio()
        ChangeStep(StepForm.CHOOSEVOD)
    End Sub


    Private Sub btnCancelStudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelStudio.Click
        ChangeStep(StepForm.CANCEL)
    End Sub

    Private Sub BtnViewAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewAll.Click
        Dim sql As String
        Dim dt As DataTable = Nothing

        sql = DvdPostData.clsStudio.getSelectStudioAll()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If Not dt Is Nothing Then
            GridStudio.DataSource = dt
            ChangeStep(StepForm.LOAD)
            _typesearch = typeSearch.ALL
        End If
    End Sub

    'Private Sub XTabControlVod_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabAnalise.SelectedPageChanged
    '    'If TabAnalise.SelectedTabPage Is XTabViewVod Then
    '    '    loadDatatUploaded()
    '    'End If
    'End Sub

    Private Sub btnDeleteStudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteStudio.Click
        Dim sql As String

        sql = DvdPostData.ClsVod.GetDeleteVod(txtId.Text)


        DvdPostData.clsConnection.ExecuteNonQuery(sql)

        If _typesearch = typeSearch.DETAIL Then
            btnSearch_Click(Nothing, Nothing)
        Else
            BtnViewAll_Click(Nothing, Nothing)
        End If

    End Sub

    Private Sub btnSaveAllChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dt As DataTable
        dt = GridStudio.DataSource.GetChanges()


        If dt Is Nothing Then
            Return
        ElseIf MsgBoxResult.Cancel = MsgBox(dt.Rows.Count & " movies are updated and will be saved, please confim ! ", MsgBoxStyle.OkCancel) Then
            Return
        End If
        For Each dr As DataRow In dt.Rows
            Dim sql As String
            sql = DvdPostData.ClsVod.GetUpdateVod(dr("id"), _
                                        IIf(dr("imdb_id") Is System.DBNull.Value, 0, dr("imdb_id")), _
                                        IIf(dr("filename") Is System.DBNull.Value, "", dr("filename")), _
                                        IIf(dr("available_from") Is System.DBNull.Value, DateTime.MinValue, dr("available_from")), _
                                        IIf(dr("expire_at") Is System.DBNull.Value, DateTime.MinValue, dr("expire_at")), _
                                        dr("available"), _
                                        IIf(dr("language_id") Is System.DBNull.Value, 0, dr("language_id")), _
                                        IIf(dr("subtitle_id") Is System.DBNull.Value, 0, dr("subtitle_id")), _
                                        IIf(dr("studio_id") Is System.DBNull.Value, 0, dr("studio_id")), _
                                        IIf(dr("status") Is System.DBNull.Value, "", dr("status")), _
                                        IIf(dr("quality") Is System.DBNull.Value, "", dr("quality")), _
                                        dr("source"), _
                                        IIf(dr("vod_support_id") Is System.DBNull.Value, 0, dr("vod_support_id")), _
                                        IIf(dr("credits") Is System.DBNull.Value, 0, dr("credits")), _
                                        IIf(dr("available_backcatalogue_from") Is System.DBNull.Value, DateTime.MinValue, dr("available_backcatalogue_from")), _
                                        IIf(dr("expire_backcatalogue_at") Is System.DBNull.Value, DateTime.MinValue, dr("expire_backcatalogue_at")))
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

        Next
        GridStudio.DataSource.AcceptChanges()

    End Sub

    Private Sub loadInfoStudio()

        Dim row As DataRow
        If GridViewSearch.RowCount > 0 Then
            row = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle())
            loadData(row)
        End If
    End Sub

    Private Sub loadProductsType()
        Dim dtProductType As DataTable

        Dim sql As String
        Dim key As String = "id"
        Dim value As String = "name"

        sql = DvdPostData.clsProductDvd.GetSelectType()
        dtProductType = DvdPostData.clsConnection.FillDataSet(sql)
        DVDPostBuziness.ClsCombo.addRowEmpty(dtProductType)

        cmbProductType.Properties.ValueMember = key
        cmbProductType.Properties.DisplayMember = value
        cmbProductType.Properties.DataSource = dtProductType

        cmbProductType.EditValue = 0

    End Sub

    Private Sub loadData(ByVal sql As String)

        'Dim dt As DataTable
        'dt = DvdPostData.clsConnection.FillDataSet(sql, DvdPostData.clsConnection.typeAccessDb.READ)
        '' dt = DvdPostData.clsConnection.FillDataSet(sql)
        'Grid1.DataSource = Nothing
        'Grid1.Views(0).PopulateColumns()

        'Grid1.DataSource = dt
        'TabAnalise.SelectedTabPage = XtraTabDetailedReport

        'clsDevExpress.AddHyperlinkDynamic(Grid1)

    End Sub

    Private Sub btnCreateDetailedReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateDetailedReport.Click
        Dim dt As DataTable
        Dim sql As String
        sql = DvdPostData.clsStudio.GetStudioDetailedReport(txtFromDate.EditValue, txtToDate.EditValue, cmbStudioBilling.EditValue)
        dt = DvdPostData.clsConnection.FillDataSet(sql, DvdPostData.clsConnection.typeAccessDb.READ)
        ' dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridStudioDetail.DataSource = Nothing
        GridStudioDetail.Views(0).PopulateColumns()

        GridStudioDetail.DataSource = dt
        XtraTabStudio.SelectedTabPage = TabStudioDetailReport
    End Sub

    Private Sub btnCreateSummaryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSummaryReport.Click
        Dim dt As DataTable
        Dim sql As String
        sql = DvdPostData.clsStudio.GetStudioSummaryReport(txtFromDate.EditValue, txtToDate.EditValue, cmbStudioBilling.EditValue)
        dt = DvdPostData.clsConnection.FillDataSet(sql, DvdPostData.clsConnection.typeAccessDb.READ)
        Dim rpt As New rptStudioSummaryReport

        rpt.DataSource = dt
        rpt.ShowPreview()
    End Sub

    Private Sub chkHasBillingReport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHasBillingReport.CheckedChanged
        cmbBillingReportType.Enabled = chkHasBillingReport.Checked
    End Sub

    Private Sub btnCreateSABAMDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSABAMDetail.Click
        Dim dt As DataTable
        Dim sql As String
        sql = DvdPostData.clsStudio.GetSABAMDetailedReport(cmbProductType.Text, dtSABAMFrom.EditValue, dtSABAMTo.EditValue)
        dt = DvdPostData.clsConnection.FillDataSet(sql, DvdPostData.clsConnection.typeAccessDb.READ)
        ' dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridSABAMDetail.DataSource = Nothing
        GridSABAMDetail.Views(0).PopulateColumns()

        GridSABAMDetail.DataSource = dt
        XtraTabStudio.SelectedTabPage = TabSABAMDetail
    End Sub

    Private Sub btnCreateSABAMSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateSABAMSummary.Click
        Dim dt As DataTable
        Dim sql As String
        sql = DvdPostData.clsStudio.GetSABAMSummaryReport(cmbProductType.Text, dtSABAMFrom.EditValue, dtSABAMTo.EditValue)
        dt = DvdPostData.clsConnection.FillDataSet(sql, DvdPostData.clsConnection.typeAccessDb.READ)
        ' dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridSABAMSummary.DataSource = Nothing
        GridSABAMSummary.Views(0).PopulateColumns()

        GridSABAMSummary.DataSource = dt
        XtraTabStudio.SelectedTabPage = TabSABAMSummary
    End Sub

End Class



