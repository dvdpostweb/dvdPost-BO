<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductsVOD
    Inherits BizzLib.frmBKForm

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
        Me.components = New System.ComponentModel.Container
        Dim colDateStartUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductsVOD))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.Main_Bar = New DevExpress.XtraBars.Bar
        Me.btnNew = New DevExpress.XtraBars.BarButtonItem
        Me.btnEdit = New DevExpress.XtraBars.BarButtonItem
        Me.btnDelete = New DevExpress.XtraBars.BarButtonItem
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem
        Me.btnUndo = New DevExpress.XtraBars.BarButtonItem
        Me.Misc_Bar = New DevExpress.XtraBars.Bar
        Me.MainBtns_btnExcel = New DevExpress.XtraBars.BarButtonItem
        Me.MainBtns_btnBigger = New DevExpress.XtraBars.BarButtonItem
        Me.MainBtns_btnSmaller = New DevExpress.XtraBars.BarButtonItem
        Me.MainBtns_btnBestFit = New DevExpress.XtraBars.BarButtonItem
        Me.btnOK = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser1 = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser2 = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser3 = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser4 = New DevExpress.XtraBars.BarButtonItem
        Me.btnUser5 = New DevExpress.XtraBars.BarButtonItem
        Me.btnExportXML = New DevExpress.XtraBars.BarButtonItem
        Me.btnImportXML = New DevExpress.XtraBars.BarButtonItem
        Me.View_Bar = New DevExpress.XtraBars.Bar
        Me.btnView = New DevExpress.XtraBars.BarButtonItem
        Me.cmbViewList = New DevExpress.XtraBars.BarEditItem
        Me.btnEditView = New DevExpress.XtraBars.BarButtonItem
        Me.btnNewView = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteView = New DevExpress.XtraBars.BarButtonItem
        Me.btnSaveView = New DevExpress.XtraBars.BarButtonItem
        Me.btnMakeViewCommon = New DevExpress.XtraBars.BarButtonItem
        Me.btnSendViewUser = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopyView = New DevExpress.XtraBars.BarButtonItem
        Me.QuickSearch_Bar = New DevExpress.XtraBars.Bar
        Me.txtQuickSearch = New DevExpress.XtraBars.BarEditItem
        Me.btnQuickSearch = New DevExpress.XtraBars.BarButtonItem
        Me.Report_Bar = New DevExpress.XtraBars.Bar
        Me.btnPrint = New DevExpress.XtraBars.BarButtonItem
        Me.cmbReportList = New DevExpress.XtraBars.BarEditItem
        Me.btnEditReportInfo = New DevExpress.XtraBars.BarButtonItem
        Me.btnNewReport = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteReport = New DevExpress.XtraBars.BarButtonItem
        Me.btnDesignReport = New DevExpress.XtraBars.BarButtonItem
        Me.btnMakeReportCommon = New DevExpress.XtraBars.BarButtonItem
        Me.btnSendReportUser = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopyReport = New DevExpress.XtraBars.BarButtonItem
        Me.Filter_Bar = New DevExpress.XtraBars.Bar
        Me.btnFilter = New DevExpress.XtraBars.BarButtonItem
        Me.cmbFilterList = New DevExpress.XtraBars.BarEditItem
        Me.btnEditFilter = New DevExpress.XtraBars.BarButtonItem
        Me.btnNewFilter = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteFilter = New DevExpress.XtraBars.BarButtonItem
        Me.btnMakeFilterCommon = New DevExpress.XtraBars.BarButtonItem
        Me.btnSendFilterUSer = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopyFilter = New DevExpress.XtraBars.BarButtonItem
        Me.DefaultSet_Bar = New DevExpress.XtraBars.Bar
        Me.btnDefault = New DevExpress.XtraBars.BarButtonItem
        Me.cmbDefaultList = New DevExpress.XtraBars.BarEditItem
        Me.btnEditDefault = New DevExpress.XtraBars.BarButtonItem
        Me.btnNewDefault = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteDefault = New DevExpress.XtraBars.BarButtonItem
        Me.btnSaveDefault = New DevExpress.XtraBars.BarButtonItem
        Me.btnMakeDefaultCommon = New DevExpress.XtraBars.BarButtonItem
        Me.btnSendDefaultUser = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopyDefault = New DevExpress.XtraBars.BarButtonItem
        Me.Misc_Bar2 = New DevExpress.XtraBars.Bar
        Me.btnTranslation = New DevExpress.XtraBars.BarButtonItem
        Me.btnComments = New DevExpress.XtraBars.BarButtonItem
        Me.btnAttachements = New DevExpress.XtraBars.BarButtonItem
        Me.Nav_Bar = New DevExpress.XtraBars.Bar
        Me.btnFirst = New DevExpress.XtraBars.BarButtonItem
        Me.btnPrevious = New DevExpress.XtraBars.BarButtonItem
        Me.btnNext = New DevExpress.XtraBars.BarButtonItem
        Me.btnLast = New DevExpress.XtraBars.BarButtonItem
        Me.XTabControlVod = New DevExpress.XtraTab.XtraTabControl
        Me.XTabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.btnRipped = New DevExpress.XtraEditors.SimpleButton
        Me.BtnViewAll = New DevExpress.XtraEditors.SimpleButton
        Me.BtnNewVodProduct = New DevExpress.XtraEditors.SimpleButton
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.txtImdb = New DevExpress.XtraEditors.TextEdit
        Me.LblImdb = New DevExpress.XtraEditors.LabelControl
        Me.TxtProducts_id = New DevExpress.XtraEditors.TextEdit
        Me.lblProduct_id = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.lblPartTitle = New DevExpress.XtraEditors.LabelControl
        Me.XTabResult = New DevExpress.XtraTab.XtraTabPage
        Me.btnSaveAllChanges = New DevExpress.XtraEditors.SimpleButton
        Me.GridVod = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colSupportVod = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositorycmbSupportVod = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colImdb_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colQuality = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colSource = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStudio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbStudio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colStatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbgridStatus = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.collanguage_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguages = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colLanguage_subtitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguagesSubtitleEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ColAvailable_from = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dpDateStart = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colExpireAt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.dtpDateExpired = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.colAvailable = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.chkcolAvailable = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colCredit = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.XTabView = New DevExpress.XtraTab.XtraTabPage
        Me.btnDeleteVOD = New DevExpress.XtraEditors.SimpleButton
        Me.lblCredit = New DevExpress.XtraEditors.LabelControl
        Me.spedCredit = New DevExpress.XtraEditors.SpinEdit
        Me.cmbSupportVod = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSupport = New DevExpress.XtraEditors.LabelControl
        Me.cmbSource = New DevExpress.XtraEditors.LookUpEdit
        Me.lblSource = New DevExpress.XtraEditors.LabelControl
        Me.cmbQuality = New DevExpress.XtraEditors.LookUpEdit
        Me.lblHigh = New DevExpress.XtraEditors.LabelControl
        Me.cmbStatus = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl
        Me.cmbStudioEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.lblStudio = New DevExpress.XtraEditors.LabelControl
        Me.txtId = New DevExpress.XtraEditors.TextEdit
        Me.lblId = New DevExpress.XtraEditors.LabelControl
        Me.btnCancelVod = New DevExpress.XtraEditors.SimpleButton
        Me.cmbLanguageSubtitle = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbLanguageSound = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbDateExpired = New DevExpress.XtraEditors.DateEdit
        Me.cmbDateStart = New DevExpress.XtraEditors.DateEdit
        Me.TxtFilename = New DevExpress.XtraEditors.TextEdit
        Me.chkAvailable = New DevExpress.XtraEditors.CheckEdit
        Me.lblAvailable = New DevExpress.XtraEditors.LabelControl
        Me.lblNameFile = New DevExpress.XtraEditors.LabelControl
        Me.lblDateExpired = New DevExpress.XtraEditors.LabelControl
        Me.lblDateStart = New DevExpress.XtraEditors.LabelControl
        Me.lblLanguage_subtitle = New DevExpress.XtraEditors.LabelControl
        Me.lblLanguageSound = New DevExpress.XtraEditors.LabelControl
        Me.txtImdbView = New DevExpress.XtraEditors.TextEdit
        Me.lblImdbView = New DevExpress.XtraEditors.LabelControl
        Me.btnSaveVod = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditVod = New DevExpress.XtraEditors.SimpleButton
        Me.XTabProcess = New DevExpress.XtraTab.XtraTabPage
        Me.lblDestinationPathFile = New System.Windows.Forms.Label
        Me.txtDestinationPath = New DevExpress.XtraEditors.TextEdit
        Me.btnDestination = New DevExpress.XtraEditors.SimpleButton
        Me.txtSourcePath = New DevExpress.XtraEditors.TextEdit
        Me.ProgressBarRipping = New DevExpress.XtraEditors.ProgressBarControl
        Me.btnGenerateRipping = New DevExpress.XtraEditors.SimpleButton
        Me.btnSource = New DevExpress.XtraEditors.SimpleButton
        Me.lblPathSourceTitle = New System.Windows.Forms.Label
        Me.XTabViewVod = New DevExpress.XtraTab.XtraTabPage
        Me.GridVodWatch = New DevExpress.XtraGrid.GridControl
        Me.gridViewVodWatch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colBtnWatchFilm = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryBtnWatchMovie = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colQuality2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProductNameUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStudioUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryCmbStudio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colStatusUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ColImdbUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLangAudioUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositorycmbLanguage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colLangSubtitleUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryLanguageSubtitleGrid = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colDateExpiredUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAvailableUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositorychkAvailable = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.WebSiteDvdPost = New System.Windows.Forms.WebBrowser
        Me.XTabFtp = New DevExpress.XtraTab.XtraTabPage
        Me.lblDbFtp = New System.Windows.Forms.Label
        Me.lblFtpLocal = New System.Windows.Forms.Label
        Me.txtSourceFtp = New DevExpress.XtraEditors.TextEdit
        Me.TxtSourceLocal = New DevExpress.XtraEditors.TextEdit
        Me.btnFolderLocal = New DevExpress.XtraEditors.SimpleButton
        Me.lblLocal = New System.Windows.Forms.Label
        Me.GridDBFtp = New DevExpress.XtraGrid.GridControl
        Me.GridViewDBFtp = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridFtpLocal = New DevExpress.XtraGrid.GridControl
        Me.GridViewFtpLocal = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNameFileFtp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BtnCompare = New System.Windows.Forms.Button
        Me.lblFTP = New System.Windows.Forms.Label
        Me.XtabAutomateTranscode = New DevExpress.XtraTab.XtraTabPage
        Me.lblError = New System.Windows.Forms.Label
        Me.lblOk = New System.Windows.Forms.Label
        Me.lstError = New System.Windows.Forms.ListBox
        Me.LstResult = New System.Windows.Forms.ListBox
        Me.btnGenerateVod = New DevExpress.XtraEditors.SimpleButton
        Me.txtPathOfFile = New DevExpress.XtraEditors.TextEdit
        Me.btnChooseFileTxt = New DevExpress.XtraEditors.SimpleButton
        Me.lblTxtFile = New System.Windows.Forms.Label
        Me.xTabVODOnlyMovie = New DevExpress.XtraTab.XtraTabPage
        Me.grdOnlyVODMovie = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.imdb_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.filename = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnAllNoMovieInfo = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.FolderChoose = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFile = New System.Windows.Forms.OpenFileDialog
        colDateStartUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTabControlVod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabControlVod.SuspendLayout()
        Me.XTabSearch.SuspendLayout()
        CType(Me.txtImdb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabResult.SuspendLayout()
        CType(Me.GridVod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorycmbSupportVod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbgridStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguagesSubtitleEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDateStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dpDateStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateExpired, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpDateExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabView.SuspendLayout()
        CType(Me.spedCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupportVod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbQuality.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudioEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguageSubtitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguageSound.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateExpired.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDateStart.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFilename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAvailable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImdbView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabProcess.SuspendLayout()
        CType(Me.txtDestinationPath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSourcePath.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBarRipping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabViewVod.SuspendLayout()
        CType(Me.GridVodWatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewVodWatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryBtnWatchMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryCmbStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorycmbLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryLanguageSubtitleGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorychkAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabFtp.SuspendLayout()
        CType(Me.txtSourceFtp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSourceLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDBFtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDBFtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFtpLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewFtpLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtabAutomateTranscode.SuspendLayout()
        CType(Me.txtPathOfFile.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.xTabVODOnlyMovie.SuspendLayout()
        CType(Me.grdOnlyVODMovie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'colDateStartUploaded
        '
        colDateStartUploaded.Caption = "date start"
        colDateStartUploaded.FieldName = "available_from"
        colDateStartUploaded.Name = "colDateStartUploaded"
        colDateStartUploaded.OptionsColumn.AllowEdit = False
        colDateStartUploaded.Visible = True
        colDateStartUploaded.Width = 68
        '
        'BarManager1
        '
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {New DevExpress.XtraBars.BarManagerCategory("Main", New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")), New DevExpress.XtraBars.BarManagerCategory("Miscelaneous", New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")), New DevExpress.XtraBars.BarManagerCategory("Views", New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")), New DevExpress.XtraBars.BarManagerCategory("Filters", New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")), New DevExpress.XtraBars.BarManagerCategory("Reporting", New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")), New DevExpress.XtraBars.BarManagerCategory("Default Values", New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")), New DevExpress.XtraBars.BarManagerCategory("Quick Search", New System.Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")), New DevExpress.XtraBars.BarManagerCategory("Misc_Maintenance", New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")), New DevExpress.XtraBars.BarManagerCategory("Navigation", New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90"))})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 73
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbViewListRepos, Me.txtQuickSearchRepos, Me.cmbReportListRepos, Me.cmbFilterListRepos, Me.cmbDefaultListRepos})
        '
        'Main_Bar
        '
        Me.Main_Bar.BarName = "Main_Bar"
        Me.Main_Bar.DockCol = 0
        Me.Main_Bar.DockRow = 0
        Me.Main_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Main_Bar.FloatLocation = New System.Drawing.Point(246, 185)
        Me.Main_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnNew), New DevExpress.XtraBars.LinkPersistInfo(Me.btnEdit), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDelete), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSave), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUndo)})
        Me.Main_Bar.Offset = 7
        Me.Main_Bar.Text = "Main Bar"
        Me.Main_Bar.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Caption = "New"
        Me.btnNew.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnNew.Glyph = CType(resources.GetObject("btnNew.Glyph"), System.Drawing.Image)
        Me.btnNew.Id = 0
        Me.btnNew.Name = "btnNew"
        '
        'btnEdit
        '
        Me.btnEdit.Caption = "Edit"
        Me.btnEdit.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnEdit.Glyph = CType(resources.GetObject("btnEdit.Glyph"), System.Drawing.Image)
        Me.btnEdit.Id = 2
        Me.btnEdit.Name = "btnEdit"
        '
        'btnDelete
        '
        Me.btnDelete.Caption = "Delete"
        Me.btnDelete.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.Glyph"), System.Drawing.Image)
        Me.btnDelete.Id = 1
        Me.btnDelete.Name = "btnDelete"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
        Me.btnSave.Id = 3
        Me.btnSave.Name = "btnSave"
        '
        'btnUndo
        '
        Me.btnUndo.Caption = "Undo"
        Me.btnUndo.Glyph = CType(resources.GetObject("btnUndo.Glyph"), System.Drawing.Image)
        Me.btnUndo.Id = 70
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'Misc_Bar
        '
        Me.Misc_Bar.BarName = "Misc_Bar"
        Me.Misc_Bar.DockCol = 1
        Me.Misc_Bar.DockRow = 0
        Me.Misc_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Misc_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.MainBtns_btnExcel), New DevExpress.XtraBars.LinkPersistInfo(Me.MainBtns_btnBigger), New DevExpress.XtraBars.LinkPersistInfo(Me.MainBtns_btnSmaller), New DevExpress.XtraBars.LinkPersistInfo(Me.MainBtns_btnBestFit), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnOK, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser1), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser2), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser3), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser4), New DevExpress.XtraBars.LinkPersistInfo(Me.btnUser5), New DevExpress.XtraBars.LinkPersistInfo(Me.btnExportXML), New DevExpress.XtraBars.LinkPersistInfo(Me.btnImportXML)})
        Me.Misc_Bar.Offset = 182
        Me.Misc_Bar.Text = "Misc. Bar"
        Me.Misc_Bar.Visible = False
        '
        'MainBtns_btnExcel
        '
        Me.MainBtns_btnExcel.Caption = "Excell"
        Me.MainBtns_btnExcel.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnExcel.Glyph = CType(resources.GetObject("MainBtns_btnExcel.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnExcel.Id = 5
        Me.MainBtns_btnExcel.Name = "MainBtns_btnExcel"
        '
        'MainBtns_btnBigger
        '
        Me.MainBtns_btnBigger.Caption = "Bigger"
        Me.MainBtns_btnBigger.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnBigger.Glyph = CType(resources.GetObject("MainBtns_btnBigger.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnBigger.Id = 6
        Me.MainBtns_btnBigger.Name = "MainBtns_btnBigger"
        '
        'MainBtns_btnSmaller
        '
        Me.MainBtns_btnSmaller.Caption = "Smaller"
        Me.MainBtns_btnSmaller.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnSmaller.Glyph = CType(resources.GetObject("MainBtns_btnSmaller.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnSmaller.Id = 7
        Me.MainBtns_btnSmaller.Name = "MainBtns_btnSmaller"
        '
        'MainBtns_btnBestFit
        '
        Me.MainBtns_btnBestFit.Caption = "BestFit"
        Me.MainBtns_btnBestFit.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnBestFit.Glyph = CType(resources.GetObject("MainBtns_btnBestFit.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnBestFit.Id = 8
        Me.MainBtns_btnBestFit.Name = "MainBtns_btnBestFit"
        '
        'btnOK
        '
        Me.btnOK.Caption = "OK"
        Me.btnOK.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnOK.Glyph = CType(resources.GetObject("btnOK.Glyph"), System.Drawing.Image)
        Me.btnOK.Id = 46
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser1
        '
        Me.btnUser1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser1.Caption = "1"
        Me.btnUser1.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser1.Id = 58
        Me.btnUser1.Name = "btnUser1"
        Me.btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser2
        '
        Me.btnUser2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser2.Caption = "2"
        Me.btnUser2.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser2.Id = 59
        Me.btnUser2.Name = "btnUser2"
        Me.btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser3
        '
        Me.btnUser3.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser3.Caption = "3"
        Me.btnUser3.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser3.Id = 60
        Me.btnUser3.Name = "btnUser3"
        Me.btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser4
        '
        Me.btnUser4.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser4.Caption = "4"
        Me.btnUser4.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser4.Id = 61
        Me.btnUser4.Name = "btnUser4"
        Me.btnUser4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser5
        '
        Me.btnUser5.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.btnUser5.Caption = "5"
        Me.btnUser5.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser5.Id = 62
        Me.btnUser5.Name = "btnUser5"
        Me.btnUser5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnExportXML
        '
        Me.btnExportXML.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnExportXML.Caption = "Export"
        Me.btnExportXML.Id = 71
        Me.btnExportXML.Name = "btnExportXML"
        '
        'btnImportXML
        '
        Me.btnImportXML.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnImportXML.Caption = "Import"
        Me.btnImportXML.Id = 72
        Me.btnImportXML.Name = "btnImportXML"
        '
        'View_Bar
        '
        Me.View_Bar.BarName = "View_Bar"
        Me.View_Bar.DockCol = 4
        Me.View_Bar.DockRow = 0
        Me.View_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.View_Bar.FloatLocation = New System.Drawing.Point(517, 188)
        Me.View_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnView), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.cmbViewList, "", False, True, True, 133), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Me.btnViewDetail, DevExpress.XtraBars.BarItemPaintStyle.Standard)})
        Me.View_Bar.Offset = 395
        Me.View_Bar.Text = "View Bar"
        Me.View_Bar.Visible = False
        '
        'btnView
        '
        Me.btnView.Caption = "View"
        Me.btnView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnView.Glyph = CType(resources.GetObject("btnView.Glyph"), System.Drawing.Image)
        Me.btnView.Id = 19
        Me.btnView.Name = "btnView"
        '
        'cmbViewList
        '
        Me.cmbViewList.Caption = "ViewList"
        Me.cmbViewList.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.cmbViewList.Edit = Me.cmbViewListRepos
        Me.cmbViewList.Id = 21
        Me.cmbViewList.Name = "cmbViewList"
        '
        'btnEditView
        '
        Me.btnEditView.Caption = "Edit"
        Me.btnEditView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnEditView.Glyph = CType(resources.GetObject("btnEditView.Glyph"), System.Drawing.Image)
        Me.btnEditView.Id = 13
        Me.btnEditView.Name = "btnEditView"
        '
        'btnNewView
        '
        Me.btnNewView.Caption = "New"
        Me.btnNewView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnNewView.Glyph = CType(resources.GetObject("btnNewView.Glyph"), System.Drawing.Image)
        Me.btnNewView.Id = 12
        Me.btnNewView.Name = "btnNewView"
        '
        'btnDeleteView
        '
        Me.btnDeleteView.Caption = "Delete"
        Me.btnDeleteView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnDeleteView.Glyph = CType(resources.GetObject("btnDeleteView.Glyph"), System.Drawing.Image)
        Me.btnDeleteView.Id = 14
        Me.btnDeleteView.Name = "btnDeleteView"
        '
        'btnSaveView
        '
        Me.btnSaveView.Caption = "Save"
        Me.btnSaveView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnSaveView.Glyph = CType(resources.GetObject("btnSaveView.Glyph"), System.Drawing.Image)
        Me.btnSaveView.Id = 17
        Me.btnSaveView.Name = "btnSaveView"
        '
        'btnMakeViewCommon
        '
        Me.btnMakeViewCommon.Caption = "Make Common"
        Me.btnMakeViewCommon.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnMakeViewCommon.Glyph = CType(resources.GetObject("btnMakeViewCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeViewCommon.Id = 15
        Me.btnMakeViewCommon.Name = "btnMakeViewCommon"
        '
        'btnSendViewUser
        '
        Me.btnSendViewUser.Caption = "Send to USer"
        Me.btnSendViewUser.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnSendViewUser.Glyph = CType(resources.GetObject("btnSendViewUser.Glyph"), System.Drawing.Image)
        Me.btnSendViewUser.Id = 16
        Me.btnSendViewUser.Name = "btnSendViewUser"
        '
        'btnCopyView
        '
        Me.btnCopyView.Caption = "Copy"
        Me.btnCopyView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnCopyView.Glyph = CType(resources.GetObject("btnCopyView.Glyph"), System.Drawing.Image)
        Me.btnCopyView.Id = 18
        Me.btnCopyView.Name = "btnCopyView"
        '
        'QuickSearch_Bar
        '
        Me.QuickSearch_Bar.BarName = "QuickSearch_Bar"
        Me.QuickSearch_Bar.DockCol = 2
        Me.QuickSearch_Bar.DockRow = 0
        Me.QuickSearch_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.QuickSearch_Bar.FloatLocation = New System.Drawing.Point(251, 153)
        Me.QuickSearch_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.txtQuickSearch, "", False, True, True, 122), New DevExpress.XtraBars.LinkPersistInfo(Me.btnQuickSearch)})
        Me.QuickSearch_Bar.Offset = 498
        Me.QuickSearch_Bar.Text = "Quick Search Bar"
        Me.QuickSearch_Bar.Visible = False
        '
        'txtQuickSearch
        '
        Me.txtQuickSearch.CategoryGuid = New System.Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
        Me.txtQuickSearch.Edit = Me.txtQuickSearchRepos
        Me.txtQuickSearch.Id = 23
        Me.txtQuickSearch.Name = "txtQuickSearch"
        '
        'btnQuickSearch
        '
        Me.btnQuickSearch.Caption = "Search"
        Me.btnQuickSearch.CategoryGuid = New System.Guid("2d735e09-7c7c-4ed4-b3ca-996e094a2026")
        Me.btnQuickSearch.Glyph = CType(resources.GetObject("btnQuickSearch.Glyph"), System.Drawing.Image)
        Me.btnQuickSearch.Id = 22
        Me.btnQuickSearch.Name = "btnQuickSearch"
        '
        'Report_Bar
        '
        Me.Report_Bar.BarName = "Report_Bar"
        Me.Report_Bar.DockCol = 7
        Me.Report_Bar.DockRow = 0
        Me.Report_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Report_Bar.FloatLocation = New System.Drawing.Point(31, 162)
        Me.Report_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrint), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.cmbReportList, "", False, True, True, 131), New DevExpress.XtraBars.LinkPersistInfo(Me.btnReportDetail)})
        Me.Report_Bar.Offset = 1065
        Me.Report_Bar.Text = "Report Bar"
        Me.Report_Bar.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Caption = "Print"
        Me.btnPrint.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnPrint.Glyph = CType(resources.GetObject("btnPrint.Glyph"), System.Drawing.Image)
        Me.btnPrint.Id = 24
        Me.btnPrint.Name = "btnPrint"
        '
        'cmbReportList
        '
        Me.cmbReportList.Caption = "Report List"
        Me.cmbReportList.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.cmbReportList.Edit = Me.cmbReportListRepos
        Me.cmbReportList.Id = 26
        Me.cmbReportList.Name = "cmbReportList"
        '
        'btnEditReportInfo
        '
        Me.btnEditReportInfo.Caption = "Edit"
        Me.btnEditReportInfo.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnEditReportInfo.Glyph = CType(resources.GetObject("btnEditReportInfo.Glyph"), System.Drawing.Image)
        Me.btnEditReportInfo.Id = 28
        Me.btnEditReportInfo.Name = "btnEditReportInfo"
        '
        'btnNewReport
        '
        Me.btnNewReport.Caption = "New"
        Me.btnNewReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnNewReport.Glyph = CType(resources.GetObject("btnNewReport.Glyph"), System.Drawing.Image)
        Me.btnNewReport.Id = 29
        Me.btnNewReport.Name = "btnNewReport"
        '
        'btnDeleteReport
        '
        Me.btnDeleteReport.Caption = "Delete"
        Me.btnDeleteReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnDeleteReport.Glyph = CType(resources.GetObject("btnDeleteReport.Glyph"), System.Drawing.Image)
        Me.btnDeleteReport.Id = 30
        Me.btnDeleteReport.Name = "btnDeleteReport"
        '
        'btnDesignReport
        '
        Me.btnDesignReport.Caption = "Design Report"
        Me.btnDesignReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnDesignReport.Glyph = CType(resources.GetObject("btnDesignReport.Glyph"), System.Drawing.Image)
        Me.btnDesignReport.Id = 31
        Me.btnDesignReport.Name = "btnDesignReport"
        '
        'btnMakeReportCommon
        '
        Me.btnMakeReportCommon.Caption = "Make Common"
        Me.btnMakeReportCommon.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnMakeReportCommon.Glyph = CType(resources.GetObject("btnMakeReportCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeReportCommon.Id = 32
        Me.btnMakeReportCommon.Name = "btnMakeReportCommon"
        '
        'btnSendReportUser
        '
        Me.btnSendReportUser.Caption = "Send to User"
        Me.btnSendReportUser.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnSendReportUser.Glyph = CType(resources.GetObject("btnSendReportUser.Glyph"), System.Drawing.Image)
        Me.btnSendReportUser.Id = 33
        Me.btnSendReportUser.Name = "btnSendReportUser"
        '
        'btnCopyReport
        '
        Me.btnCopyReport.Caption = "Copy"
        Me.btnCopyReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnCopyReport.Glyph = CType(resources.GetObject("btnCopyReport.Glyph"), System.Drawing.Image)
        Me.btnCopyReport.Id = 34
        Me.btnCopyReport.Name = "btnCopyReport"
        '
        'Filter_Bar
        '
        Me.Filter_Bar.BarName = "Filter_Bar"
        Me.Filter_Bar.DockCol = 5
        Me.Filter_Bar.DockRow = 0
        Me.Filter_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Filter_Bar.FloatLocation = New System.Drawing.Point(337, 218)
        Me.Filter_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilter), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.cmbFilterList, "", False, True, True, 132), New DevExpress.XtraBars.LinkPersistInfo(Me.btnFilterDetail)})
        Me.Filter_Bar.Offset = 1053
        Me.Filter_Bar.Text = "Filter Bar"
        Me.Filter_Bar.Visible = False
        '
        'btnFilter
        '
        Me.btnFilter.Caption = "btnFilter"
        Me.btnFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnFilter.Glyph = CType(resources.GetObject("btnFilter.Glyph"), System.Drawing.Image)
        Me.btnFilter.Id = 35
        Me.btnFilter.Name = "btnFilter"
        '
        'cmbFilterList
        '
        Me.cmbFilterList.Caption = "cmbFilterList"
        Me.cmbFilterList.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.cmbFilterList.Edit = Me.cmbFilterListRepos
        Me.cmbFilterList.Id = 38
        Me.cmbFilterList.Name = "cmbFilterList"
        '
        'btnEditFilter
        '
        Me.btnEditFilter.Caption = "Edit"
        Me.btnEditFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnEditFilter.Glyph = CType(resources.GetObject("btnEditFilter.Glyph"), System.Drawing.Image)
        Me.btnEditFilter.Id = 39
        Me.btnEditFilter.Name = "btnEditFilter"
        '
        'btnNewFilter
        '
        Me.btnNewFilter.Caption = "New"
        Me.btnNewFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnNewFilter.Glyph = CType(resources.GetObject("btnNewFilter.Glyph"), System.Drawing.Image)
        Me.btnNewFilter.Id = 40
        Me.btnNewFilter.Name = "btnNewFilter"
        '
        'btnDeleteFilter
        '
        Me.btnDeleteFilter.Caption = "Delete"
        Me.btnDeleteFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnDeleteFilter.Glyph = CType(resources.GetObject("btnDeleteFilter.Glyph"), System.Drawing.Image)
        Me.btnDeleteFilter.Id = 41
        Me.btnDeleteFilter.Name = "btnDeleteFilter"
        '
        'btnMakeFilterCommon
        '
        Me.btnMakeFilterCommon.Caption = "Make Common"
        Me.btnMakeFilterCommon.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnMakeFilterCommon.Glyph = CType(resources.GetObject("btnMakeFilterCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeFilterCommon.Id = 43
        Me.btnMakeFilterCommon.Name = "btnMakeFilterCommon"
        '
        'btnSendFilterUSer
        '
        Me.btnSendFilterUSer.Caption = "Send to USer"
        Me.btnSendFilterUSer.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnSendFilterUSer.Glyph = CType(resources.GetObject("btnSendFilterUSer.Glyph"), System.Drawing.Image)
        Me.btnSendFilterUSer.Id = 44
        Me.btnSendFilterUSer.Name = "btnSendFilterUSer"
        '
        'btnCopyFilter
        '
        Me.btnCopyFilter.Caption = "Copy"
        Me.btnCopyFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnCopyFilter.Glyph = CType(resources.GetObject("btnCopyFilter.Glyph"), System.Drawing.Image)
        Me.btnCopyFilter.Id = 45
        Me.btnCopyFilter.Name = "btnCopyFilter"
        '
        'DefaultSet_Bar
        '
        Me.DefaultSet_Bar.BarName = "DefaultSet_Bar"
        Me.DefaultSet_Bar.DockCol = 6
        Me.DefaultSet_Bar.DockRow = 0
        Me.DefaultSet_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.DefaultSet_Bar.FloatLocation = New System.Drawing.Point(298, 224)
        Me.DefaultSet_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnDefault), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.cmbDefaultList, "", False, True, True, 132), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDefaultDetail)})
        Me.DefaultSet_Bar.Offset = 1060
        Me.DefaultSet_Bar.Text = "Default Set Bar"
        Me.DefaultSet_Bar.Visible = False
        '
        'btnDefault
        '
        Me.btnDefault.Caption = "Default"
        Me.btnDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnDefault.Glyph = CType(resources.GetObject("btnDefault.Glyph"), System.Drawing.Image)
        Me.btnDefault.Id = 47
        Me.btnDefault.Name = "btnDefault"
        '
        'cmbDefaultList
        '
        Me.cmbDefaultList.Caption = "cmbDefaultList"
        Me.cmbDefaultList.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.cmbDefaultList.Edit = Me.cmbDefaultListRepos
        Me.cmbDefaultList.Id = 49
        Me.cmbDefaultList.Name = "cmbDefaultList"
        '
        'btnEditDefault
        '
        Me.btnEditDefault.Caption = "Edit"
        Me.btnEditDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnEditDefault.Glyph = CType(resources.GetObject("btnEditDefault.Glyph"), System.Drawing.Image)
        Me.btnEditDefault.Id = 51
        Me.btnEditDefault.Name = "btnEditDefault"
        '
        'btnNewDefault
        '
        Me.btnNewDefault.Caption = "New"
        Me.btnNewDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnNewDefault.Glyph = CType(resources.GetObject("btnNewDefault.Glyph"), System.Drawing.Image)
        Me.btnNewDefault.Id = 52
        Me.btnNewDefault.Name = "btnNewDefault"
        '
        'btnDeleteDefault
        '
        Me.btnDeleteDefault.Caption = "Delete"
        Me.btnDeleteDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnDeleteDefault.Glyph = CType(resources.GetObject("btnDeleteDefault.Glyph"), System.Drawing.Image)
        Me.btnDeleteDefault.Id = 53
        Me.btnDeleteDefault.Name = "btnDeleteDefault"
        '
        'btnSaveDefault
        '
        Me.btnSaveDefault.Caption = "Save"
        Me.btnSaveDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnSaveDefault.Glyph = CType(resources.GetObject("btnSaveDefault.Glyph"), System.Drawing.Image)
        Me.btnSaveDefault.Id = 54
        Me.btnSaveDefault.Name = "btnSaveDefault"
        '
        'btnMakeDefaultCommon
        '
        Me.btnMakeDefaultCommon.Caption = "Make Common"
        Me.btnMakeDefaultCommon.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnMakeDefaultCommon.Glyph = CType(resources.GetObject("btnMakeDefaultCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeDefaultCommon.Id = 55
        Me.btnMakeDefaultCommon.Name = "btnMakeDefaultCommon"
        '
        'btnSendDefaultUser
        '
        Me.btnSendDefaultUser.Caption = "Send to USer"
        Me.btnSendDefaultUser.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnSendDefaultUser.Glyph = CType(resources.GetObject("btnSendDefaultUser.Glyph"), System.Drawing.Image)
        Me.btnSendDefaultUser.Id = 56
        Me.btnSendDefaultUser.Name = "btnSendDefaultUser"
        '
        'btnCopyDefault
        '
        Me.btnCopyDefault.Caption = "Copy"
        Me.btnCopyDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnCopyDefault.Glyph = CType(resources.GetObject("btnCopyDefault.Glyph"), System.Drawing.Image)
        Me.btnCopyDefault.Id = 57
        Me.btnCopyDefault.Name = "btnCopyDefault"
        '
        'Misc_Bar2
        '
        Me.Misc_Bar2.BarName = "Misc_Bar2"
        Me.Misc_Bar2.DockCol = 8
        Me.Misc_Bar2.DockRow = 0
        Me.Misc_Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Misc_Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnTranslation), New DevExpress.XtraBars.LinkPersistInfo(Me.btnComments), New DevExpress.XtraBars.LinkPersistInfo(Me.btnAttachements)})
        Me.Misc_Bar2.Offset = 1123
        Me.Misc_Bar2.Text = "Misc_Bar2 for Maintenance Screen"
        Me.Misc_Bar2.Visible = False
        '
        'btnTranslation
        '
        Me.btnTranslation.Caption = "Translation"
        Me.btnTranslation.CategoryGuid = New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
        Me.btnTranslation.Glyph = CType(resources.GetObject("btnTranslation.Glyph"), System.Drawing.Image)
        Me.btnTranslation.Id = 63
        Me.btnTranslation.Name = "btnTranslation"
        '
        'btnComments
        '
        Me.btnComments.Caption = "Comments"
        Me.btnComments.CategoryGuid = New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
        Me.btnComments.Glyph = CType(resources.GetObject("btnComments.Glyph"), System.Drawing.Image)
        Me.btnComments.Id = 64
        Me.btnComments.Name = "btnComments"
        '
        'btnAttachements
        '
        Me.btnAttachements.Caption = "Attachements"
        Me.btnAttachements.CategoryGuid = New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
        Me.btnAttachements.Glyph = CType(resources.GetObject("btnAttachements.Glyph"), System.Drawing.Image)
        Me.btnAttachements.Id = 65
        Me.btnAttachements.Name = "btnAttachements"
        '
        'Nav_Bar
        '
        Me.Nav_Bar.BarName = "Nav_Bar"
        Me.Nav_Bar.DockCol = 3
        Me.Nav_Bar.DockRow = 0
        Me.Nav_Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Nav_Bar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnFirst), New DevExpress.XtraBars.LinkPersistInfo(Me.btnPrevious), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNext), New DevExpress.XtraBars.LinkPersistInfo(Me.btnLast)})
        Me.Nav_Bar.Offset = 172
        Me.Nav_Bar.Text = "Nav Bar"
        Me.Nav_Bar.Visible = False
        '
        'btnFirst
        '
        Me.btnFirst.Caption = "First"
        Me.btnFirst.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnFirst.Glyph = CType(resources.GetObject("btnFirst.Glyph"), System.Drawing.Image)
        Me.btnFirst.Id = 66
        Me.btnFirst.Name = "btnFirst"
        '
        'btnPrevious
        '
        Me.btnPrevious.Caption = "Previous"
        Me.btnPrevious.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnPrevious.Glyph = CType(resources.GetObject("btnPrevious.Glyph"), System.Drawing.Image)
        Me.btnPrevious.Id = 67
        Me.btnPrevious.Name = "btnPrevious"
        '
        'btnNext
        '
        Me.btnNext.Caption = "Next"
        Me.btnNext.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnNext.Glyph = CType(resources.GetObject("btnNext.Glyph"), System.Drawing.Image)
        Me.btnNext.Id = 68
        Me.btnNext.Name = "btnNext"
        '
        'btnLast
        '
        Me.btnLast.Caption = "Last"
        Me.btnLast.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnLast.Glyph = CType(resources.GetObject("btnLast.Glyph"), System.Drawing.Image)
        Me.btnLast.Id = 69
        Me.btnLast.Name = "btnLast"
        '
        'XTabControlVod
        '
        Me.XTabControlVod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTabControlVod.Location = New System.Drawing.Point(0, 30)
        Me.XTabControlVod.Name = "XTabControlVod"
        Me.XTabControlVod.SelectedTabPage = Me.XTabSearch
        Me.XTabControlVod.Size = New System.Drawing.Size(1018, 665)
        Me.XTabControlVod.TabIndex = 4
        Me.XTabControlVod.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTabSearch, Me.XTabResult, Me.XTabView, Me.XTabProcess, Me.XTabViewVod, Me.XTabFtp, Me.XtabAutomateTranscode, Me.xTabVODOnlyMovie})
        Me.XTabControlVod.Text = "VOD"
        '
        'XTabSearch
        '
        Me.XTabSearch.Controls.Add(Me.btnRipped)
        Me.XTabSearch.Controls.Add(Me.BtnViewAll)
        Me.XTabSearch.Controls.Add(Me.BtnNewVodProduct)
        Me.XTabSearch.Controls.Add(Me.btnSearch)
        Me.XTabSearch.Controls.Add(Me.txtImdb)
        Me.XTabSearch.Controls.Add(Me.LblImdb)
        Me.XTabSearch.Controls.Add(Me.TxtProducts_id)
        Me.XTabSearch.Controls.Add(Me.lblProduct_id)
        Me.XTabSearch.Controls.Add(Me.txtTitleSearch)
        Me.XTabSearch.Controls.Add(Me.lblPartTitle)
        Me.XTabSearch.Name = "XTabSearch"
        Me.XTabSearch.Size = New System.Drawing.Size(1009, 634)
        Me.XTabSearch.Text = "Search"
        '
        'btnRipped
        '
        Me.btnRipped.Location = New System.Drawing.Point(444, 211)
        Me.btnRipped.Name = "btnRipped"
        Me.btnRipped.Size = New System.Drawing.Size(75, 23)
        Me.btnRipped.TabIndex = 18
        Me.btnRipped.Text = "ripped"
        '
        'BtnViewAll
        '
        Me.BtnViewAll.Location = New System.Drawing.Point(335, 211)
        Me.BtnViewAll.Name = "BtnViewAll"
        Me.BtnViewAll.Size = New System.Drawing.Size(75, 23)
        Me.BtnViewAll.TabIndex = 17
        Me.BtnViewAll.Text = "View all"
        '
        'BtnNewVodProduct
        '
        Me.BtnNewVodProduct.Location = New System.Drawing.Point(194, 211)
        Me.BtnNewVodProduct.Name = "BtnNewVodProduct"
        Me.BtnNewVodProduct.Size = New System.Drawing.Size(75, 23)
        Me.BtnNewVodProduct.TabIndex = 16
        Me.BtnNewVodProduct.Text = "New"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(56, 211)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        '
        'txtImdb
        '
        Me.txtImdb.Location = New System.Drawing.Point(157, 113)
        Me.txtImdb.Name = "txtImdb"
        Me.txtImdb.Size = New System.Drawing.Size(112, 20)
        Me.txtImdb.TabIndex = 14
        '
        'LblImdb
        '
        Me.LblImdb.Location = New System.Drawing.Point(26, 116)
        Me.LblImdb.Name = "LblImdb"
        Me.LblImdb.Size = New System.Drawing.Size(38, 13)
        Me.LblImdb.TabIndex = 13
        Me.LblImdb.Text = "Imdb ID"
        '
        'TxtProducts_id
        '
        Me.TxtProducts_id.Location = New System.Drawing.Point(157, 68)
        Me.TxtProducts_id.Name = "TxtProducts_id"
        Me.TxtProducts_id.Size = New System.Drawing.Size(112, 20)
        Me.TxtProducts_id.TabIndex = 12
        '
        'lblProduct_id
        '
        Me.lblProduct_id.Location = New System.Drawing.Point(26, 71)
        Me.lblProduct_id.Name = "lblProduct_id"
        Me.lblProduct_id.Size = New System.Drawing.Size(51, 13)
        Me.lblProduct_id.TabIndex = 11
        Me.lblProduct_id.Text = "Product ID"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(157, 28)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(472, 20)
        Me.txtTitleSearch.TabIndex = 10
        '
        'lblPartTitle
        '
        Me.lblPartTitle.Location = New System.Drawing.Point(26, 35)
        Me.lblPartTitle.Name = "lblPartTitle"
        Me.lblPartTitle.Size = New System.Drawing.Size(56, 13)
        Me.lblPartTitle.TabIndex = 9
        Me.lblPartTitle.Text = "Part of Title"
        '
        'XTabResult
        '
        Me.XTabResult.Controls.Add(Me.btnSaveAllChanges)
        Me.XTabResult.Controls.Add(Me.GridVod)
        Me.XTabResult.Name = "XTabResult"
        Me.XTabResult.Size = New System.Drawing.Size(1009, 634)
        Me.XTabResult.Text = "Result"
        '
        'btnSaveAllChanges
        '
        Me.btnSaveAllChanges.Location = New System.Drawing.Point(9, 3)
        Me.btnSaveAllChanges.Name = "btnSaveAllChanges"
        Me.btnSaveAllChanges.Size = New System.Drawing.Size(97, 23)
        Me.btnSaveAllChanges.TabIndex = 19
        Me.btnSaveAllChanges.Text = "Save All Changes"
        '
        'GridVod
        '
        Me.GridVod.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridVod.EmbeddedNavigator.Name = ""
        Me.GridVod.FormsUseDefaultLookAndFeel = False
        Me.GridVod.Location = New System.Drawing.Point(9, 32)
        Me.GridVod.MainView = Me.GridViewSearch
        Me.GridVod.Name = "GridVod"
        Me.GridVod.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages, Me.chkcolAvailable, Me.cmbStudio, Me.RepositorycmbSupportVod, Me.cmbgridStatus, Me.dpDateStart, Me.dtpDateExpired, Me.cmbLanguagesSubtitleEdit, Me.RepositoryItemLookUpEdit2})
        Me.GridVod.Size = New System.Drawing.Size(1000, 602)
        Me.GridVod.TabIndex = 4
        Me.GridVod.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Appearance.FocusedRow.BackColor = System.Drawing.Color.Silver
        Me.GridViewSearch.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.GridBand3, Me.GridBand4})
        Me.GridViewSearch.ColumnPanelRowHeight = 45
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colImdb_id, Me.collanguage_id, Me.colproducts_name, Me.ColAvailable_from, Me.colExpireAt, Me.colLanguage_subtitle, Me.colAvailable, Me.colStudio, Me.colStatus, Me.colSource, Me.colQuality, Me.colSupportVod, Me.colCredit})
        Me.GridViewSearch.CustomizationFormBounds = New System.Drawing.Rectangle(799, 449, 225, 209)
        Me.GridViewSearch.DetailHeight = 50
        Me.GridViewSearch.GridControl = Me.GridVod
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
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colSupportVod)
        Me.GridBand1.Columns.Add(Me.colImdb_id)
        Me.GridBand1.Columns.Add(Me.colproducts_name)
        Me.GridBand1.Columns.Add(Me.colQuality)
        Me.GridBand1.Columns.Add(Me.colSource)
        Me.GridBand1.Columns.Add(Me.colStudio)
        Me.GridBand1.Columns.Add(Me.colStatus)
        Me.GridBand1.Columns.Add(Me.collanguage_id)
        Me.GridBand1.Columns.Add(Me.colLanguage_subtitle)
        Me.GridBand1.Columns.Add(Me.ColAvailable_from)
        Me.GridBand1.Columns.Add(Me.colExpireAt)
        Me.GridBand1.Columns.Add(Me.colAvailable)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 879
        '
        'colSupportVod
        '
        Me.colSupportVod.Caption = "Support"
        Me.colSupportVod.ColumnEdit = Me.RepositorycmbSupportVod
        Me.colSupportVod.FieldName = "vod_support_id"
        Me.colSupportVod.Name = "colSupportVod"
        Me.colSupportVod.OptionsColumn.AllowEdit = False
        Me.colSupportVod.Visible = True
        Me.colSupportVod.Width = 47
        '
        'RepositorycmbSupportVod
        '
        Me.RepositorycmbSupportVod.AutoHeight = False
        Me.RepositorycmbSupportVod.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositorycmbSupportVod.Name = "RepositorycmbSupportVod"
        Me.RepositorycmbSupportVod.NullText = ""
        '
        'colImdb_id
        '
        Me.colImdb_id.Caption = "imdb id"
        Me.colImdb_id.FieldName = "imdb_id"
        Me.colImdb_id.Name = "colImdb_id"
        Me.colImdb_id.OptionsColumn.AllowEdit = False
        Me.colImdb_id.Visible = True
        Me.colImdb_id.Width = 54
        '
        'colproducts_name
        '
        Me.colproducts_name.Caption = "products name"
        Me.colproducts_name.FieldName = "products_name"
        Me.colproducts_name.Name = "colproducts_name"
        Me.colproducts_name.OptionsColumn.AllowEdit = False
        Me.colproducts_name.Visible = True
        Me.colproducts_name.Width = 135
        '
        'colQuality
        '
        Me.colQuality.Caption = "quality"
        Me.colQuality.FieldName = "quality"
        Me.colQuality.Name = "colQuality"
        Me.colQuality.OptionsColumn.AllowEdit = False
        Me.colQuality.Visible = True
        Me.colQuality.Width = 46
        '
        'colSource
        '
        Me.colSource.Caption = "source"
        Me.colSource.FieldName = "source"
        Me.colSource.Name = "colSource"
        Me.colSource.OptionsColumn.AllowEdit = False
        Me.colSource.Visible = True
        Me.colSource.Width = 51
        '
        'colStudio
        '
        Me.colStudio.Caption = "studio"
        Me.colStudio.ColumnEdit = Me.cmbStudio
        Me.colStudio.FieldName = "studio_id"
        Me.colStudio.Name = "colStudio"
        Me.colStudio.Visible = True
        Me.colStudio.Width = 68
        '
        'cmbStudio
        '
        Me.cmbStudio.AutoHeight = False
        Me.cmbStudio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStudio.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbStudio.DisplayMember = "studio_name"
        Me.cmbStudio.Name = "cmbStudio"
        Me.cmbStudio.NullText = ""
        Me.cmbStudio.ValueMember = "studio_id"
        '
        'colStatus
        '
        Me.colStatus.Caption = "status"
        Me.colStatus.ColumnEdit = Me.cmbgridStatus
        Me.colStatus.FieldName = "status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.Width = 72
        '
        'cmbgridStatus
        '
        Me.cmbgridStatus.AutoHeight = False
        Me.cmbgridStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbgridStatus.Name = "cmbgridStatus"
        '
        'collanguage_id
        '
        Me.collanguage_id.Caption = "language sound"
        Me.collanguage_id.ColumnEdit = Me.cmbLanguages
        Me.collanguage_id.FieldName = "language_id"
        Me.collanguage_id.Name = "collanguage_id"
        Me.collanguage_id.OptionsColumn.AllowEdit = False
        Me.collanguage_id.Visible = True
        Me.collanguage_id.Width = 87
        '
        'cmbLanguages
        '
        Me.cmbLanguages.AutoHeight = False
        Me.cmbLanguages.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguages.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguages.DisplayMember = "name"
        Me.cmbLanguages.Name = "cmbLanguages"
        Me.cmbLanguages.NullText = ""
        Me.cmbLanguages.ValueMember = "languages_id"
        '
        'colLanguage_subtitle
        '
        Me.colLanguage_subtitle.Caption = "language subtitle"
        Me.colLanguage_subtitle.ColumnEdit = Me.cmbLanguagesSubtitleEdit
        Me.colLanguage_subtitle.FieldName = "subtitle_id"
        Me.colLanguage_subtitle.Name = "colLanguage_subtitle"
        Me.colLanguage_subtitle.OptionsColumn.AllowEdit = False
        Me.colLanguage_subtitle.Visible = True
        Me.colLanguage_subtitle.Width = 99
        '
        'cmbLanguagesSubtitleEdit
        '
        Me.cmbLanguagesSubtitleEdit.AutoHeight = False
        Me.cmbLanguagesSubtitleEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguagesSubtitleEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "language", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbLanguagesSubtitleEdit.DisplayMember = "code"
        Me.cmbLanguagesSubtitleEdit.Name = "cmbLanguagesSubtitleEdit"
        Me.cmbLanguagesSubtitleEdit.NullText = ""
        '
        'ColAvailable_from
        '
        Me.ColAvailable_from.Caption = "date start"
        Me.ColAvailable_from.ColumnEdit = Me.dpDateStart
        Me.ColAvailable_from.FieldName = "available_from"
        Me.ColAvailable_from.Name = "ColAvailable_from"
        Me.ColAvailable_from.Visible = True
        Me.ColAvailable_from.Width = 79
        '
        'dpDateStart
        '
        Me.dpDateStart.AutoHeight = False
        Me.dpDateStart.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dpDateStart.Name = "dpDateStart"
        Me.dpDateStart.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colExpireAt
        '
        Me.colExpireAt.Caption = "date expired"
        Me.colExpireAt.ColumnEdit = Me.dtpDateExpired
        Me.colExpireAt.FieldName = "expire_at"
        Me.colExpireAt.Name = "colExpireAt"
        Me.colExpireAt.Visible = True
        Me.colExpireAt.Width = 72
        '
        'dtpDateExpired
        '
        Me.dtpDateExpired.AutoHeight = False
        Me.dtpDateExpired.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpDateExpired.Name = "dtpDateExpired"
        Me.dtpDateExpired.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'colAvailable
        '
        Me.colAvailable.Caption = "available"
        Me.colAvailable.ColumnEdit = Me.chkcolAvailable
        Me.colAvailable.FieldName = "available"
        Me.colAvailable.Name = "colAvailable"
        Me.colAvailable.Visible = True
        Me.colAvailable.Width = 69
        '
        'chkcolAvailable
        '
        Me.chkcolAvailable.AutoHeight = False
        Me.chkcolAvailable.Name = "chkcolAvailable"
        Me.chkcolAvailable.ValueChecked = CType(1, Byte)
        Me.chkcolAvailable.ValueUnchecked = CType(0, Byte)
        '
        'GridBand3
        '
        Me.GridBand3.Caption = "gridBand1"
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 46
        '
        'GridBand4
        '
        Me.GridBand4.Caption = "gridBand2"
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 54
        '
        'colCredit
        '
        Me.colCredit.Caption = "credit"
        Me.colCredit.FieldName = "credit"
        Me.colCredit.Name = "colCredit"
        Me.colCredit.OptionsColumn.AllowEdit = False
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'XTabView
        '
        Me.XTabView.Controls.Add(Me.btnDeleteVOD)
        Me.XTabView.Controls.Add(Me.lblCredit)
        Me.XTabView.Controls.Add(Me.spedCredit)
        Me.XTabView.Controls.Add(Me.cmbSupportVod)
        Me.XTabView.Controls.Add(Me.lblSupport)
        Me.XTabView.Controls.Add(Me.cmbSource)
        Me.XTabView.Controls.Add(Me.lblSource)
        Me.XTabView.Controls.Add(Me.cmbQuality)
        Me.XTabView.Controls.Add(Me.lblHigh)
        Me.XTabView.Controls.Add(Me.cmbStatus)
        Me.XTabView.Controls.Add(Me.lblStatus)
        Me.XTabView.Controls.Add(Me.cmbStudioEdit)
        Me.XTabView.Controls.Add(Me.lblStudio)
        Me.XTabView.Controls.Add(Me.txtId)
        Me.XTabView.Controls.Add(Me.lblId)
        Me.XTabView.Controls.Add(Me.btnCancelVod)
        Me.XTabView.Controls.Add(Me.cmbLanguageSubtitle)
        Me.XTabView.Controls.Add(Me.cmbLanguageSound)
        Me.XTabView.Controls.Add(Me.cmbDateExpired)
        Me.XTabView.Controls.Add(Me.cmbDateStart)
        Me.XTabView.Controls.Add(Me.TxtFilename)
        Me.XTabView.Controls.Add(Me.chkAvailable)
        Me.XTabView.Controls.Add(Me.lblAvailable)
        Me.XTabView.Controls.Add(Me.lblNameFile)
        Me.XTabView.Controls.Add(Me.lblDateExpired)
        Me.XTabView.Controls.Add(Me.lblDateStart)
        Me.XTabView.Controls.Add(Me.lblLanguage_subtitle)
        Me.XTabView.Controls.Add(Me.lblLanguageSound)
        Me.XTabView.Controls.Add(Me.txtImdbView)
        Me.XTabView.Controls.Add(Me.lblImdbView)
        Me.XTabView.Controls.Add(Me.btnSaveVod)
        Me.XTabView.Controls.Add(Me.btnEditVod)
        Me.XTabView.Name = "XTabView"
        Me.XTabView.Size = New System.Drawing.Size(1009, 634)
        Me.XTabView.Text = "View"
        '
        'btnDeleteVOD
        '
        Me.btnDeleteVOD.Enabled = False
        Me.btnDeleteVOD.Location = New System.Drawing.Point(317, 23)
        Me.btnDeleteVOD.Name = "btnDeleteVOD"
        Me.btnDeleteVOD.Size = New System.Drawing.Size(79, 23)
        Me.btnDeleteVOD.TabIndex = 86
        Me.btnDeleteVOD.Text = "Delete"
        '
        'lblCredit
        '
        Me.lblCredit.Location = New System.Drawing.Point(247, 362)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(27, 13)
        Me.lblCredit.TabIndex = 85
        Me.lblCredit.Text = "credit"
        '
        'spedCredit
        '
        Me.spedCredit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spedCredit.Location = New System.Drawing.Point(342, 355)
        Me.spedCredit.Name = "spedCredit"
        Me.spedCredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.spedCredit.Properties.MaxValue = New Decimal(New Integer() {3, 0, 0, 0})
        Me.spedCredit.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.spedCredit.Size = New System.Drawing.Size(112, 20)
        Me.spedCredit.TabIndex = 84
        '
        'cmbSupportVod
        '
        Me.cmbSupportVod.AllowDrop = True
        Me.cmbSupportVod.Enabled = False
        Me.cmbSupportVod.Location = New System.Drawing.Point(342, 309)
        Me.cmbSupportVod.Name = "cmbSupportVod"
        Me.cmbSupportVod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSupportVod.Properties.DisplayMember = "status_desc"
        Me.cmbSupportVod.Properties.NullText = ""
        Me.cmbSupportVod.Properties.ValueMember = "status_id"
        Me.cmbSupportVod.Size = New System.Drawing.Size(112, 20)
        Me.cmbSupportVod.TabIndex = 83
        '
        'lblSupport
        '
        Me.lblSupport.Location = New System.Drawing.Point(247, 312)
        Me.lblSupport.Name = "lblSupport"
        Me.lblSupport.Size = New System.Drawing.Size(37, 13)
        Me.lblSupport.TabIndex = 82
        Me.lblSupport.Text = "support"
        '
        'cmbSource
        '
        Me.cmbSource.AllowDrop = True
        Me.cmbSource.Enabled = False
        Me.cmbSource.Location = New System.Drawing.Point(341, 271)
        Me.cmbSource.Name = "cmbSource"
        Me.cmbSource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbSource.Properties.DisplayMember = "status_desc"
        Me.cmbSource.Properties.NullText = ""
        Me.cmbSource.Properties.ValueMember = "status_id"
        Me.cmbSource.Size = New System.Drawing.Size(112, 20)
        Me.cmbSource.TabIndex = 81
        '
        'lblSource
        '
        Me.lblSource.Location = New System.Drawing.Point(249, 275)
        Me.lblSource.Name = "lblSource"
        Me.lblSource.Size = New System.Drawing.Size(32, 13)
        Me.lblSource.TabIndex = 80
        Me.lblSource.Text = "source"
        '
        'cmbQuality
        '
        Me.cmbQuality.AllowDrop = True
        Me.cmbQuality.Enabled = False
        Me.cmbQuality.Location = New System.Drawing.Point(342, 235)
        Me.cmbQuality.Name = "cmbQuality"
        Me.cmbQuality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbQuality.Properties.DisplayMember = "status_desc"
        Me.cmbQuality.Properties.NullText = ""
        Me.cmbQuality.Properties.ValueMember = "status_id"
        Me.cmbQuality.Size = New System.Drawing.Size(112, 20)
        Me.cmbQuality.TabIndex = 79
        '
        'lblHigh
        '
        Me.lblHigh.Location = New System.Drawing.Point(247, 238)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(32, 13)
        Me.lblHigh.TabIndex = 78
        Me.lblHigh.Text = "quality"
        '
        'cmbStatus
        '
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.Location = New System.Drawing.Point(342, 191)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.DisplayMember = "status_desc"
        Me.cmbStatus.Properties.NullText = ""
        Me.cmbStatus.Properties.ValueMember = "status_id"
        Me.cmbStatus.Size = New System.Drawing.Size(112, 20)
        Me.cmbStatus.TabIndex = 77
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(247, 194)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(30, 13)
        Me.lblStatus.TabIndex = 76
        Me.lblStatus.Text = "status"
        '
        'cmbStudioEdit
        '
        Me.cmbStudioEdit.Enabled = False
        Me.cmbStudioEdit.Location = New System.Drawing.Point(113, 107)
        Me.cmbStudioEdit.Name = "cmbStudioEdit"
        Me.cmbStudioEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStudioEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbStudioEdit.Properties.DisplayMember = "status_desc"
        Me.cmbStudioEdit.Properties.NullText = ""
        Me.cmbStudioEdit.Properties.ValueMember = "status_id"
        Me.cmbStudioEdit.Size = New System.Drawing.Size(112, 20)
        Me.cmbStudioEdit.TabIndex = 75
        '
        'lblStudio
        '
        Me.lblStudio.Location = New System.Drawing.Point(18, 110)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(29, 13)
        Me.lblStudio.TabIndex = 74
        Me.lblStudio.Text = "studio"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(379, 66)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(112, 20)
        Me.txtId.TabIndex = 73
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(342, 69)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(11, 13)
        Me.lblId.TabIndex = 72
        Me.lblId.Text = "ID"
        '
        'btnCancelVod
        '
        Me.btnCancelVod.Enabled = False
        Me.btnCancelVod.Location = New System.Drawing.Point(215, 23)
        Me.btnCancelVod.Name = "btnCancelVod"
        Me.btnCancelVod.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelVod.TabIndex = 71
        Me.btnCancelVod.Text = "Cancel"
        '
        'cmbLanguageSubtitle
        '
        Me.cmbLanguageSubtitle.Enabled = False
        Me.cmbLanguageSubtitle.Location = New System.Drawing.Point(113, 179)
        Me.cmbLanguageSubtitle.Name = "cmbLanguageSubtitle"
        Me.cmbLanguageSubtitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguageSubtitle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("subtitle_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lngdsc", "Language", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguageSubtitle.Properties.DisplayMember = "lngdsc"
        Me.cmbLanguageSubtitle.Properties.NullText = ""
        Me.cmbLanguageSubtitle.Properties.ValueMember = "subtitle_id"
        Me.cmbLanguageSubtitle.Size = New System.Drawing.Size(112, 20)
        Me.cmbLanguageSubtitle.TabIndex = 70
        '
        'cmbLanguageSound
        '
        Me.cmbLanguageSound.Enabled = False
        Me.cmbLanguageSound.Location = New System.Drawing.Point(113, 143)
        Me.cmbLanguageSound.Name = "cmbLanguageSound"
        Me.cmbLanguageSound.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguageSound.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lngdsc", "Language", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguageSound.Properties.DisplayMember = "lngdsc"
        Me.cmbLanguageSound.Properties.NullText = ""
        Me.cmbLanguageSound.Properties.ValueMember = "id"
        Me.cmbLanguageSound.Size = New System.Drawing.Size(112, 20)
        Me.cmbLanguageSound.TabIndex = 69
        '
        'cmbDateExpired
        '
        Me.cmbDateExpired.EditValue = Nothing
        Me.cmbDateExpired.Enabled = False
        Me.cmbDateExpired.Location = New System.Drawing.Point(113, 267)
        Me.cmbDateExpired.Name = "cmbDateExpired"
        Me.cmbDateExpired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateExpired.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateExpired.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateExpired.TabIndex = 68
        '
        'cmbDateStart
        '
        Me.cmbDateStart.EditValue = Nothing
        Me.cmbDateStart.Enabled = False
        Me.cmbDateStart.Location = New System.Drawing.Point(113, 221)
        Me.cmbDateStart.Name = "cmbDateStart"
        Me.cmbDateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateStart.Size = New System.Drawing.Size(112, 20)
        Me.cmbDateStart.TabIndex = 67
        '
        'TxtFilename
        '
        Me.TxtFilename.Enabled = False
        Me.TxtFilename.Location = New System.Drawing.Point(342, 103)
        Me.TxtFilename.Name = "TxtFilename"
        Me.TxtFilename.Size = New System.Drawing.Size(179, 20)
        Me.TxtFilename.TabIndex = 66
        '
        'chkAvailable
        '
        Me.chkAvailable.Location = New System.Drawing.Point(340, 149)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Properties.Caption = ""
        Me.chkAvailable.Size = New System.Drawing.Size(56, 19)
        Me.chkAvailable.TabIndex = 65
        '
        'lblAvailable
        '
        Me.lblAvailable.Location = New System.Drawing.Point(247, 152)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(42, 13)
        Me.lblAvailable.TabIndex = 64
        Me.lblAvailable.Text = "available"
        '
        'lblNameFile
        '
        Me.lblNameFile.Location = New System.Drawing.Point(247, 110)
        Me.lblNameFile.Name = "lblNameFile"
        Me.lblNameFile.Size = New System.Drawing.Size(43, 13)
        Me.lblNameFile.TabIndex = 63
        Me.lblNameFile.Text = "file name"
        '
        'lblDateExpired
        '
        Me.lblDateExpired.Location = New System.Drawing.Point(18, 274)
        Me.lblDateExpired.Name = "lblDateExpired"
        Me.lblDateExpired.Size = New System.Drawing.Size(61, 13)
        Me.lblDateExpired.TabIndex = 62
        Me.lblDateExpired.Text = "date expired"
        '
        'lblDateStart
        '
        Me.lblDateStart.Location = New System.Drawing.Point(18, 228)
        Me.lblDateStart.Name = "lblDateStart"
        Me.lblDateStart.Size = New System.Drawing.Size(48, 13)
        Me.lblDateStart.TabIndex = 61
        Me.lblDateStart.Text = "date start"
        '
        'lblLanguage_subtitle
        '
        Me.lblLanguage_subtitle.Location = New System.Drawing.Point(18, 182)
        Me.lblLanguage_subtitle.Name = "lblLanguage_subtitle"
        Me.lblLanguage_subtitle.Size = New System.Drawing.Size(82, 13)
        Me.lblLanguage_subtitle.TabIndex = 60
        Me.lblLanguage_subtitle.Text = "language subtitle"
        '
        'lblLanguageSound
        '
        Me.lblLanguageSound.Location = New System.Drawing.Point(18, 146)
        Me.lblLanguageSound.Name = "lblLanguageSound"
        Me.lblLanguageSound.Size = New System.Drawing.Size(76, 13)
        Me.lblLanguageSound.TabIndex = 59
        Me.lblLanguageSound.Text = "language sound"
        '
        'txtImdbView
        '
        Me.txtImdbView.Enabled = False
        Me.txtImdbView.Location = New System.Drawing.Point(113, 81)
        Me.txtImdbView.Name = "txtImdbView"
        Me.txtImdbView.Size = New System.Drawing.Size(112, 20)
        Me.txtImdbView.TabIndex = 58
        '
        'lblImdbView
        '
        Me.lblImdbView.Location = New System.Drawing.Point(18, 84)
        Me.lblImdbView.Name = "lblImdbView"
        Me.lblImdbView.Size = New System.Drawing.Size(38, 13)
        Me.lblImdbView.TabIndex = 57
        Me.lblImdbView.Text = "Imdb ID"
        '
        'btnSaveVod
        '
        Me.btnSaveVod.Enabled = False
        Me.btnSaveVod.Location = New System.Drawing.Point(18, 23)
        Me.btnSaveVod.Name = "btnSaveVod"
        Me.btnSaveVod.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveVod.TabIndex = 52
        Me.btnSaveVod.Text = "Save"
        '
        'btnEditVod
        '
        Me.btnEditVod.Enabled = False
        Me.btnEditVod.Location = New System.Drawing.Point(113, 23)
        Me.btnEditVod.Name = "btnEditVod"
        Me.btnEditVod.Size = New System.Drawing.Size(79, 23)
        Me.btnEditVod.TabIndex = 51
        Me.btnEditVod.Text = "Edit"
        '
        'XTabProcess
        '
        Me.XTabProcess.Controls.Add(Me.lblDestinationPathFile)
        Me.XTabProcess.Controls.Add(Me.txtDestinationPath)
        Me.XTabProcess.Controls.Add(Me.btnDestination)
        Me.XTabProcess.Controls.Add(Me.txtSourcePath)
        Me.XTabProcess.Controls.Add(Me.ProgressBarRipping)
        Me.XTabProcess.Controls.Add(Me.btnGenerateRipping)
        Me.XTabProcess.Controls.Add(Me.btnSource)
        Me.XTabProcess.Controls.Add(Me.lblPathSourceTitle)
        Me.XTabProcess.Name = "XTabProcess"
        Me.XTabProcess.Size = New System.Drawing.Size(1009, 634)
        Me.XTabProcess.Text = "Processus vod"
        '
        'lblDestinationPathFile
        '
        Me.lblDestinationPathFile.AutoSize = True
        Me.lblDestinationPathFile.Location = New System.Drawing.Point(76, 64)
        Me.lblDestinationPathFile.Name = "lblDestinationPathFile"
        Me.lblDestinationPathFile.Size = New System.Drawing.Size(126, 13)
        Me.lblDestinationPathFile.TabIndex = 8
        Me.lblDestinationPathFile.Text = "Destination queue filezilla"
        '
        'txtDestinationPath
        '
        Me.txtDestinationPath.EditValue = "z:\vod\tmp\xml"
        Me.txtDestinationPath.Location = New System.Drawing.Point(219, 61)
        Me.txtDestinationPath.Name = "txtDestinationPath"
        Me.txtDestinationPath.Size = New System.Drawing.Size(471, 20)
        Me.txtDestinationPath.TabIndex = 7
        '
        'btnDestination
        '
        Me.btnDestination.Location = New System.Drawing.Point(30, 58)
        Me.btnDestination.Name = "btnDestination"
        Me.btnDestination.Size = New System.Drawing.Size(40, 23)
        Me.btnDestination.TabIndex = 6
        Me.btnDestination.Text = "..."
        '
        'txtSourcePath
        '
        Me.txtSourcePath.Location = New System.Drawing.Point(219, 16)
        Me.txtSourcePath.Name = "txtSourcePath"
        Me.txtSourcePath.Size = New System.Drawing.Size(471, 20)
        Me.txtSourcePath.TabIndex = 5
        '
        'ProgressBarRipping
        '
        Me.ProgressBarRipping.Location = New System.Drawing.Point(219, 136)
        Me.ProgressBarRipping.Name = "ProgressBarRipping"
        Me.ProgressBarRipping.Size = New System.Drawing.Size(350, 23)
        Me.ProgressBarRipping.TabIndex = 4
        '
        'btnGenerateRipping
        '
        Me.btnGenerateRipping.Location = New System.Drawing.Point(9, 136)
        Me.btnGenerateRipping.Name = "btnGenerateRipping"
        Me.btnGenerateRipping.Size = New System.Drawing.Size(116, 23)
        Me.btnGenerateRipping.TabIndex = 3
        Me.btnGenerateRipping.Text = "Generate Ripping"
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(30, 16)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(40, 23)
        Me.btnSource.TabIndex = 2
        Me.btnSource.Text = "..."
        '
        'lblPathSourceTitle
        '
        Me.lblPathSourceTitle.AutoSize = True
        Me.lblPathSourceTitle.Location = New System.Drawing.Point(76, 23)
        Me.lblPathSourceTitle.Name = "lblPathSourceTitle"
        Me.lblPathSourceTitle.Size = New System.Drawing.Size(85, 13)
        Me.lblPathSourceTitle.TabIndex = 0
        Me.lblPathSourceTitle.Text = "Source files mp4"
        '
        'XTabViewVod
        '
        Me.XTabViewVod.Controls.Add(Me.GridVodWatch)
        Me.XTabViewVod.Controls.Add(Me.WebSiteDvdPost)
        Me.XTabViewVod.Name = "XTabViewVod"
        Me.XTabViewVod.Size = New System.Drawing.Size(1009, 634)
        Me.XTabViewVod.Text = "view vod"
        '
        'GridVodWatch
        '
        Me.GridVodWatch.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridVodWatch.EmbeddedNavigator.Name = ""
        Me.GridVodWatch.FormsUseDefaultLookAndFeel = False
        Me.GridVodWatch.Location = New System.Drawing.Point(0, 0)
        Me.GridVodWatch.MainView = Me.gridViewVodWatch
        Me.GridVodWatch.Name = "GridVodWatch"
        Me.GridVodWatch.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositorycmbLanguage, Me.RepositorychkAvailable, Me.RepositoryCmbStudio, Me.RepositoryBtnWatchMovie, Me.RepositoryLanguageSubtitleGrid})
        Me.GridVodWatch.Size = New System.Drawing.Size(514, 634)
        Me.GridVodWatch.TabIndex = 5
        Me.GridVodWatch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewVodWatch})
        '
        'gridViewVodWatch
        '
        Me.gridViewVodWatch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.gridViewVodWatch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.ColImdbUploaded, Me.colLangAudioUploaded, Me.colProductNameUploaded, colDateStartUploaded, Me.colDateExpiredUploaded, Me.colLangSubtitleUploaded, Me.colAvailableUploaded, Me.colStudioUploaded, Me.colStatusUploaded, Me.colQuality2, Me.colBtnWatchFilm})
        Me.gridViewVodWatch.CustomizationFormBounds = New System.Drawing.Rectangle(799, 449, 225, 209)
        Me.gridViewVodWatch.GridControl = Me.GridVodWatch
        Me.gridViewVodWatch.Name = "gridViewVodWatch"
        Me.gridViewVodWatch.OptionsView.ColumnAutoWidth = True
        Me.gridViewVodWatch.OptionsView.ShowAutoFilterRow = True
        Me.gridViewVodWatch.OptionsView.ShowBands = False
        Me.gridViewVodWatch.OptionsView.ShowFooter = True
        '
        'GridBand2
        '
        Me.GridBand2.Caption = "GridBand1"
        Me.GridBand2.Columns.Add(Me.colBtnWatchFilm)
        Me.GridBand2.Columns.Add(Me.colQuality2)
        Me.GridBand2.Columns.Add(Me.colProductNameUploaded)
        Me.GridBand2.Columns.Add(Me.colStudioUploaded)
        Me.GridBand2.Columns.Add(Me.colStatusUploaded)
        Me.GridBand2.Columns.Add(Me.ColImdbUploaded)
        Me.GridBand2.Columns.Add(Me.colLangAudioUploaded)
        Me.GridBand2.Columns.Add(Me.colLangSubtitleUploaded)
        Me.GridBand2.Columns.Add(colDateStartUploaded)
        Me.GridBand2.Columns.Add(Me.colDateExpiredUploaded)
        Me.GridBand2.Columns.Add(Me.colAvailableUploaded)
        Me.GridBand2.MinWidth = 20
        Me.GridBand2.Name = "GridBand2"
        Me.GridBand2.Width = 582
        '
        'colBtnWatchFilm
        '
        Me.colBtnWatchFilm.Caption = "watch movie"
        Me.colBtnWatchFilm.ColumnEdit = Me.RepositoryBtnWatchMovie
        Me.colBtnWatchFilm.FieldName = "colBtnWatchFilm"
        Me.colBtnWatchFilm.Name = "colBtnWatchFilm"
        Me.colBtnWatchFilm.Visible = True
        Me.colBtnWatchFilm.Width = 67
        '
        'RepositoryBtnWatchMovie
        '
        Me.RepositoryBtnWatchMovie.AutoHeight = False
        Me.RepositoryBtnWatchMovie.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.RepositoryBtnWatchMovie.Name = "RepositoryBtnWatchMovie"
        Me.RepositoryBtnWatchMovie.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colQuality2
        '
        Me.colQuality2.Caption = "quality"
        Me.colQuality2.FieldName = "quality"
        Me.colQuality2.Name = "colQuality2"
        Me.colQuality2.OptionsColumn.AllowEdit = False
        Me.colQuality2.Visible = True
        Me.colQuality2.Width = 46
        '
        'colProductNameUploaded
        '
        Me.colProductNameUploaded.Caption = "products name"
        Me.colProductNameUploaded.FieldName = "products_name"
        Me.colProductNameUploaded.Name = "colProductNameUploaded"
        Me.colProductNameUploaded.OptionsColumn.AllowEdit = False
        Me.colProductNameUploaded.Visible = True
        Me.colProductNameUploaded.Width = 121
        '
        'colStudioUploaded
        '
        Me.colStudioUploaded.Caption = "studio"
        Me.colStudioUploaded.ColumnEdit = Me.RepositoryCmbStudio
        Me.colStudioUploaded.FieldName = "studio_id"
        Me.colStudioUploaded.Name = "colStudioUploaded"
        Me.colStudioUploaded.OptionsColumn.AllowEdit = False
        Me.colStudioUploaded.OptionsColumn.ReadOnly = True
        '
        'RepositoryCmbStudio
        '
        Me.RepositoryCmbStudio.AutoHeight = False
        Me.RepositoryCmbStudio.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryCmbStudio.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryCmbStudio.DisplayMember = "studio_name"
        Me.RepositoryCmbStudio.Name = "RepositoryCmbStudio"
        Me.RepositoryCmbStudio.NullText = ""
        Me.RepositoryCmbStudio.ValueMember = "studio_id"
        '
        'colStatusUploaded
        '
        Me.colStatusUploaded.Caption = "status"
        Me.colStatusUploaded.FieldName = "status"
        Me.colStatusUploaded.Name = "colStatusUploaded"
        '
        'ColImdbUploaded
        '
        Me.ColImdbUploaded.Caption = "imdb id"
        Me.ColImdbUploaded.FieldName = "imdb_id"
        Me.ColImdbUploaded.Name = "ColImdbUploaded"
        Me.ColImdbUploaded.OptionsColumn.AllowEdit = False
        Me.ColImdbUploaded.Visible = True
        Me.ColImdbUploaded.Width = 64
        '
        'colLangAudioUploaded
        '
        Me.colLangAudioUploaded.Caption = "Audio"
        Me.colLangAudioUploaded.ColumnEdit = Me.RepositorycmbLanguage
        Me.colLangAudioUploaded.FieldName = "language_id"
        Me.colLangAudioUploaded.Name = "colLangAudioUploaded"
        Me.colLangAudioUploaded.OptionsColumn.AllowEdit = False
        Me.colLangAudioUploaded.Visible = True
        Me.colLangAudioUploaded.Width = 51
        '
        'RepositorycmbLanguage
        '
        Me.RepositorycmbLanguage.AutoHeight = False
        Me.RepositorycmbLanguage.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositorycmbLanguage.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositorycmbLanguage.DisplayMember = "name"
        Me.RepositorycmbLanguage.Name = "RepositorycmbLanguage"
        Me.RepositorycmbLanguage.NullText = ""
        Me.RepositorycmbLanguage.ValueMember = "languages_id"
        '
        'colLangSubtitleUploaded
        '
        Me.colLangSubtitleUploaded.Caption = "Subtitle"
        Me.colLangSubtitleUploaded.ColumnEdit = Me.RepositoryLanguageSubtitleGrid
        Me.colLangSubtitleUploaded.FieldName = "subtitle_id"
        Me.colLangSubtitleUploaded.Name = "colLangSubtitleUploaded"
        Me.colLangSubtitleUploaded.OptionsColumn.AllowEdit = False
        Me.colLangSubtitleUploaded.Visible = True
        Me.colLangSubtitleUploaded.Width = 59
        '
        'RepositoryLanguageSubtitleGrid
        '
        Me.RepositoryLanguageSubtitleGrid.AutoHeight = False
        Me.RepositoryLanguageSubtitleGrid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryLanguageSubtitleGrid.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "Name29", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "Name30", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.RepositoryLanguageSubtitleGrid.DisplayMember = "code"
        Me.RepositoryLanguageSubtitleGrid.Name = "RepositoryLanguageSubtitleGrid"
        Me.RepositoryLanguageSubtitleGrid.NullText = ""
        '
        'colDateExpiredUploaded
        '
        Me.colDateExpiredUploaded.Caption = "date expired"
        Me.colDateExpiredUploaded.FieldName = "expire_at"
        Me.colDateExpiredUploaded.Name = "colDateExpiredUploaded"
        Me.colDateExpiredUploaded.OptionsColumn.AllowEdit = False
        Me.colDateExpiredUploaded.Visible = True
        Me.colDateExpiredUploaded.Width = 86
        '
        'colAvailableUploaded
        '
        Me.colAvailableUploaded.Caption = "available"
        Me.colAvailableUploaded.ColumnEdit = Me.RepositorychkAvailable
        Me.colAvailableUploaded.FieldName = "available"
        Me.colAvailableUploaded.Name = "colAvailableUploaded"
        Me.colAvailableUploaded.OptionsColumn.AllowEdit = False
        Me.colAvailableUploaded.OptionsColumn.ReadOnly = True
        Me.colAvailableUploaded.Visible = True
        Me.colAvailableUploaded.Width = 20
        '
        'RepositorychkAvailable
        '
        Me.RepositorychkAvailable.AutoHeight = False
        Me.RepositorychkAvailable.Name = "RepositorychkAvailable"
        Me.RepositorychkAvailable.ValueChecked = CType(1, Byte)
        Me.RepositorychkAvailable.ValueUnchecked = CType(0, Byte)
        '
        'WebSiteDvdPost
        '
        Me.WebSiteDvdPost.Dock = System.Windows.Forms.DockStyle.Right
        Me.WebSiteDvdPost.Location = New System.Drawing.Point(394, 0)
        Me.WebSiteDvdPost.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebSiteDvdPost.Name = "WebSiteDvdPost"
        Me.WebSiteDvdPost.Size = New System.Drawing.Size(615, 634)
        Me.WebSiteDvdPost.TabIndex = 6
        '
        'XTabFtp
        '
        Me.XTabFtp.Controls.Add(Me.lblDbFtp)
        Me.XTabFtp.Controls.Add(Me.lblFtpLocal)
        Me.XTabFtp.Controls.Add(Me.txtSourceFtp)
        Me.XTabFtp.Controls.Add(Me.TxtSourceLocal)
        Me.XTabFtp.Controls.Add(Me.btnFolderLocal)
        Me.XTabFtp.Controls.Add(Me.lblLocal)
        Me.XTabFtp.Controls.Add(Me.GridDBFtp)
        Me.XTabFtp.Controls.Add(Me.GridFtpLocal)
        Me.XTabFtp.Controls.Add(Me.BtnCompare)
        Me.XTabFtp.Controls.Add(Me.lblFTP)
        Me.XTabFtp.Name = "XTabFtp"
        Me.XTabFtp.Size = New System.Drawing.Size(1009, 634)
        Me.XTabFtp.Text = "Compare Ftp"
        '
        'lblDbFtp
        '
        Me.lblDbFtp.AutoSize = True
        Me.lblDbFtp.Location = New System.Drawing.Point(526, 85)
        Me.lblDbFtp.Name = "lblDbFtp"
        Me.lblDbFtp.Size = New System.Drawing.Size(56, 13)
        Me.lblDbFtp.TabIndex = 14
        Me.lblDbFtp.Text = "DB % FTP"
        '
        'lblFtpLocal
        '
        Me.lblFtpLocal.AutoSize = True
        Me.lblFtpLocal.Location = New System.Drawing.Point(140, 85)
        Me.lblFtpLocal.Name = "lblFtpLocal"
        Me.lblFtpLocal.Size = New System.Drawing.Size(60, 13)
        Me.lblFtpLocal.TabIndex = 13
        Me.lblFtpLocal.Text = "FT % Local"
        '
        'txtSourceFtp
        '
        Me.txtSourceFtp.EditValue = "ftp://upload.cdnlayer.com/media/secureflash/"
        Me.txtSourceFtp.Location = New System.Drawing.Point(42, 31)
        Me.txtSourceFtp.Name = "txtSourceFtp"
        Me.txtSourceFtp.Size = New System.Drawing.Size(263, 20)
        Me.txtSourceFtp.TabIndex = 12
        '
        'TxtSourceLocal
        '
        Me.TxtSourceLocal.EditValue = "z:\vod\tmp"
        Me.TxtSourceLocal.Location = New System.Drawing.Point(46, 60)
        Me.TxtSourceLocal.Name = "TxtSourceLocal"
        Me.TxtSourceLocal.Size = New System.Drawing.Size(182, 20)
        Me.TxtSourceLocal.TabIndex = 11
        '
        'btnFolderLocal
        '
        Me.btnFolderLocal.Location = New System.Drawing.Point(234, 63)
        Me.btnFolderLocal.Name = "btnFolderLocal"
        Me.btnFolderLocal.Size = New System.Drawing.Size(40, 23)
        Me.btnFolderLocal.TabIndex = 10
        Me.btnFolderLocal.Text = "..."
        '
        'lblLocal
        '
        Me.lblLocal.AutoSize = True
        Me.lblLocal.Location = New System.Drawing.Point(11, 67)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(29, 13)
        Me.lblLocal.TabIndex = 9
        Me.lblLocal.Text = "local"
        '
        'GridDBFtp
        '
        Me.GridDBFtp.EmbeddedNavigator.Name = ""
        Me.GridDBFtp.FormsUseDefaultLookAndFeel = False
        Me.GridDBFtp.Location = New System.Drawing.Point(357, 101)
        Me.GridDBFtp.MainView = Me.GridViewDBFtp
        Me.GridDBFtp.Name = "GridDBFtp"
        Me.GridDBFtp.Size = New System.Drawing.Size(486, 530)
        Me.GridDBFtp.TabIndex = 7
        Me.GridDBFtp.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDBFtp})
        '
        'GridViewDBFtp
        '
        Me.GridViewDBFtp.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1})
        Me.GridViewDBFtp.GridControl = Me.GridDBFtp
        Me.GridViewDBFtp.Name = "GridViewDBFtp"
        Me.GridViewDBFtp.OptionsBehavior.Editable = False
        Me.GridViewDBFtp.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Name File"
        Me.GridColumn1.FieldName = "Column"
        Me.GridColumn1.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridFtpLocal
        '
        Me.GridFtpLocal.EmbeddedNavigator.Name = ""
        Me.GridFtpLocal.FormsUseDefaultLookAndFeel = False
        Me.GridFtpLocal.Location = New System.Drawing.Point(12, 101)
        Me.GridFtpLocal.MainView = Me.GridViewFtpLocal
        Me.GridFtpLocal.Name = "GridFtpLocal"
        Me.GridFtpLocal.Size = New System.Drawing.Size(318, 527)
        Me.GridFtpLocal.TabIndex = 5
        Me.GridFtpLocal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewFtpLocal})
        '
        'GridViewFtpLocal
        '
        Me.GridViewFtpLocal.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNameFileFtp})
        Me.GridViewFtpLocal.GridControl = Me.GridFtpLocal
        Me.GridViewFtpLocal.Name = "GridViewFtpLocal"
        Me.GridViewFtpLocal.OptionsBehavior.Editable = False
        Me.GridViewFtpLocal.OptionsView.ShowFooter = True
        '
        'colNameFileFtp
        '
        Me.colNameFileFtp.Caption = "Name file"
        Me.colNameFileFtp.FieldName = "Column"
        Me.colNameFileFtp.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colNameFileFtp.Name = "colNameFileFtp"
        Me.colNameFileFtp.OptionsColumn.AllowEdit = False
        Me.colNameFileFtp.OptionsColumn.ReadOnly = True
        Me.colNameFileFtp.Visible = True
        Me.colNameFileFtp.VisibleIndex = 0
        '
        'BtnCompare
        '
        Me.BtnCompare.Location = New System.Drawing.Point(230, 3)
        Me.BtnCompare.Name = "BtnCompare"
        Me.BtnCompare.Size = New System.Drawing.Size(75, 23)
        Me.BtnCompare.TabIndex = 4
        Me.BtnCompare.Text = "Compare"
        Me.BtnCompare.UseVisualStyleBackColor = True
        '
        'lblFTP
        '
        Me.lblFTP.AutoSize = True
        Me.lblFTP.Location = New System.Drawing.Point(9, 34)
        Me.lblFTP.Name = "lblFTP"
        Me.lblFTP.Size = New System.Drawing.Size(27, 13)
        Me.lblFTP.TabIndex = 2
        Me.lblFTP.Text = "FTP"
        '
        'XtabAutomateTranscode
        '
        Me.XtabAutomateTranscode.Controls.Add(Me.lblError)
        Me.XtabAutomateTranscode.Controls.Add(Me.lblOk)
        Me.XtabAutomateTranscode.Controls.Add(Me.lstError)
        Me.XtabAutomateTranscode.Controls.Add(Me.LstResult)
        Me.XtabAutomateTranscode.Controls.Add(Me.btnGenerateVod)
        Me.XtabAutomateTranscode.Controls.Add(Me.txtPathOfFile)
        Me.XtabAutomateTranscode.Controls.Add(Me.btnChooseFileTxt)
        Me.XtabAutomateTranscode.Controls.Add(Me.lblTxtFile)
        Me.XtabAutomateTranscode.Margin = New System.Windows.Forms.Padding(2)
        Me.XtabAutomateTranscode.Name = "XtabAutomateTranscode"
        Me.XtabAutomateTranscode.Size = New System.Drawing.Size(1009, 634)
        Me.XtabAutomateTranscode.Text = "Automate Transcode"
        Me.XtabAutomateTranscode.Tooltip = "Deletes data from last load"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(203, 256)
        Me.lblError.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(29, 13)
        Me.lblError.TabIndex = 13
        Me.lblError.Text = "Error"
        '
        'lblOk
        '
        Me.lblOk.AutoSize = True
        Me.lblOk.Location = New System.Drawing.Point(206, 102)
        Me.lblOk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOk.Name = "lblOk"
        Me.lblOk.Size = New System.Drawing.Size(49, 13)
        Me.lblOk.TabIndex = 12
        Me.lblOk.Text = "new Vod"
        '
        'lstError
        '
        Me.lstError.FormattingEnabled = True
        Me.lstError.Location = New System.Drawing.Point(290, 217)
        Me.lstError.Margin = New System.Windows.Forms.Padding(2)
        Me.lstError.Name = "lstError"
        Me.lstError.Size = New System.Drawing.Size(287, 134)
        Me.lstError.TabIndex = 11
        '
        'LstResult
        '
        Me.LstResult.FormattingEnabled = True
        Me.LstResult.Location = New System.Drawing.Point(290, 58)
        Me.LstResult.Margin = New System.Windows.Forms.Padding(2)
        Me.LstResult.Name = "LstResult"
        Me.LstResult.Size = New System.Drawing.Size(287, 134)
        Me.LstResult.TabIndex = 10
        '
        'btnGenerateVod
        '
        Me.btnGenerateVod.Location = New System.Drawing.Point(16, 58)
        Me.btnGenerateVod.Name = "btnGenerateVod"
        Me.btnGenerateVod.Size = New System.Drawing.Size(116, 23)
        Me.btnGenerateVod.TabIndex = 9
        Me.btnGenerateVod.Text = "Generate Create vod"
        '
        'txtPathOfFile
        '
        Me.txtPathOfFile.Location = New System.Drawing.Point(206, 15)
        Me.txtPathOfFile.Name = "txtPathOfFile"
        Me.txtPathOfFile.Size = New System.Drawing.Size(471, 20)
        Me.txtPathOfFile.TabIndex = 8
        '
        'btnChooseFileTxt
        '
        Me.btnChooseFileTxt.Location = New System.Drawing.Point(16, 15)
        Me.btnChooseFileTxt.Name = "btnChooseFileTxt"
        Me.btnChooseFileTxt.Size = New System.Drawing.Size(40, 23)
        Me.btnChooseFileTxt.TabIndex = 7
        Me.btnChooseFileTxt.Text = "..."
        '
        'lblTxtFile
        '
        Me.lblTxtFile.AutoSize = True
        Me.lblTxtFile.Location = New System.Drawing.Point(62, 22)
        Me.lblTxtFile.Name = "lblTxtFile"
        Me.lblTxtFile.Size = New System.Drawing.Size(76, 13)
        Me.lblTxtFile.TabIndex = 6
        Me.lblTxtFile.Text = "Source files txt"
        '
        'xTabVODOnlyMovie
        '
        Me.xTabVODOnlyMovie.Controls.Add(Me.grdOnlyVODMovie)
        Me.xTabVODOnlyMovie.Controls.Add(Me.btnAllNoMovieInfo)
        Me.xTabVODOnlyMovie.Name = "xTabVODOnlyMovie"
        Me.xTabVODOnlyMovie.Size = New System.Drawing.Size(1009, 634)
        Me.xTabVODOnlyMovie.Text = "VOD Without Info"
        '
        'grdOnlyVODMovie
        '
        Me.grdOnlyVODMovie.EmbeddedNavigator.Name = ""
        Me.grdOnlyVODMovie.FormsUseDefaultLookAndFeel = False
        Me.grdOnlyVODMovie.Location = New System.Drawing.Point(26, 69)
        Me.grdOnlyVODMovie.MainView = Me.GridView1
        Me.grdOnlyVODMovie.Name = "grdOnlyVODMovie"
        Me.grdOnlyVODMovie.Size = New System.Drawing.Size(486, 530)
        Me.grdOnlyVODMovie.TabIndex = 19
        Me.grdOnlyVODMovie.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.imdb_id, Me.filename})
        Me.GridView1.GridControl = Me.grdOnlyVODMovie
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'imdb_id
        '
        Me.imdb_id.Caption = "imdb_id"
        Me.imdb_id.FieldName = "imdb_id"
        Me.imdb_id.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.imdb_id.Name = "imdb_id"
        Me.imdb_id.OptionsColumn.ReadOnly = True
        Me.imdb_id.Visible = True
        Me.imdb_id.VisibleIndex = 0
        Me.imdb_id.Width = 147
        '
        'filename
        '
        Me.filename.Caption = "file name"
        Me.filename.FieldName = "filename"
        Me.filename.Name = "filename"
        Me.filename.Visible = True
        Me.filename.VisibleIndex = 1
        Me.filename.Width = 318
        '
        'btnAllNoMovieInfo
        '
        Me.btnAllNoMovieInfo.Location = New System.Drawing.Point(26, 30)
        Me.btnAllNoMovieInfo.Name = "btnAllNoMovieInfo"
        Me.btnAllNoMovieInfo.Size = New System.Drawing.Size(136, 23)
        Me.btnAllNoMovieInfo.TabIndex = 18
        Me.btnAllNoMovieInfo.Text = "Show All VOD Without Info"
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(157, 28)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(472, 20)
        Me.TextEdit2.TabIndex = 10
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(26, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Part of Title"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(194, 211)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 16
        Me.SimpleButton1.Text = "New"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(56, 211)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "Search"
        '
        'TextEdit3
        '
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.Location = New System.Drawing.Point(157, 113)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(112, 20)
        Me.TextEdit3.TabIndex = 14
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(26, 116)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl3.TabIndex = 13
        Me.LabelControl3.Text = "Imdb ID"
        '
        'TextEdit4
        '
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.Location = New System.Drawing.Point(157, 68)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(112, 20)
        Me.TextEdit4.TabIndex = 12
        '
        'FolderChoose
        '
        Me.FolderChoose.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.FolderChoose.SelectedPath = "Z:\VOD\tmp"
        '
        'FrmProductsVOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 695)
        Me.Controls.Add(Me.XTabControlVod)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmProductsVOD"
        Me.Text = "FrmProductsVOD"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.XTabControlVod, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTabControlVod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabControlVod.ResumeLayout(False)
        Me.XTabSearch.ResumeLayout(False)
        Me.XTabSearch.PerformLayout()
        CType(Me.txtImdb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabResult.ResumeLayout(False)
        CType(Me.GridVod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorycmbSupportVod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbgridStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguagesSubtitleEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDateStart.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dpDateStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateExpired.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpDateExpired, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabView.ResumeLayout(False)
        Me.XTabView.PerformLayout()
        CType(Me.spedCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupportVod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbQuality.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudioEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguageSubtitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguageSound.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpired.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateExpired.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStart.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDateStart.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFilename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAvailable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImdbView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabProcess.ResumeLayout(False)
        Me.XTabProcess.PerformLayout()
        CType(Me.txtDestinationPath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSourcePath.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBarRipping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabViewVod.ResumeLayout(False)
        CType(Me.GridVodWatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewVodWatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryBtnWatchMovie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryCmbStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorycmbLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryLanguageSubtitleGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorychkAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabFtp.ResumeLayout(False)
        Me.XTabFtp.PerformLayout()
        CType(Me.txtSourceFtp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSourceLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDBFtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDBFtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFtpLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewFtpLocal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtabAutomateTranscode.ResumeLayout(False)
        Me.XtabAutomateTranscode.PerformLayout()
        CType(Me.txtPathOfFile.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.xTabVODOnlyMovie.ResumeLayout(False)
        CType(Me.grdOnlyVODMovie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XTabControlVod As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XTabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTabResult As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XTabView As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblPartTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtProducts_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProduct_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImdb As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LblImdb As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridVod As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colImdb_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents collanguage_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbLanguages As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colproducts_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BtnNewVodProduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColAvailable_from As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colExpireAt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLanguage_subtitle As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAvailable As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnSaveVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtImdbView As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblImdbView As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblAvailable As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNameFile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateExpired As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateStart As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLanguage_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLanguageSound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TxtFilename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkAvailable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDateExpired As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbLanguageSubtitle As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbLanguageSound As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnCancelVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkcolAvailable As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblId As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colStudio As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cmbStudioEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnViewAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colStatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents XTabProcess As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblPathSourceTitle As System.Windows.Forms.Label
    Friend WithEvents FolderChoose As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnSource As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBarRipping As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents btnGenerateRipping As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtSourcePath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblDestinationPathFile As System.Windows.Forms.Label
    Friend WithEvents txtDestinationPath As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnDestination As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTabViewVod As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents WebSiteDvdPost As System.Windows.Forms.WebBrowser
    Friend WithEvents GridVodWatch As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewVodWatch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colStudioUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryCmbStudio As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colStatusUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColImdbUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colLangAudioUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositorycmbLanguage As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colLangSubtitleUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProductNameUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDateExpiredUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAvailableUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositorychkAvailable As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents lblHigh As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnRipped As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XTabFtp As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblFTP As System.Windows.Forms.Label
    Friend WithEvents BtnCompare As System.Windows.Forms.Button
    Friend WithEvents GridFtpLocal As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewFtpLocal As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNameFileFtp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridDBFtp As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDBFtp As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtSourceLocal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnFolderLocal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblLocal As System.Windows.Forms.Label
    Friend WithEvents txtSourceFtp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblFtpLocal As System.Windows.Forms.Label
    Friend WithEvents lblDbFtp As System.Windows.Forms.Label
    Friend WithEvents colQuality As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbQuality As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colQuality2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbSource As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSource As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtabAutomateTranscode As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtPathOfFile As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnChooseFileTxt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTxtFile As System.Windows.Forms.Label
    Friend WithEvents btnGenerateVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblOk As System.Windows.Forms.Label
    Friend WithEvents lstError As System.Windows.Forms.ListBox
    Friend WithEvents LstResult As System.Windows.Forms.ListBox
    Friend WithEvents cmbSupportVod As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSupport As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colSupportVod As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositorycmbSupportVod As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents OpenFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RepositoryBtnWatchMovie As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colBtnWatchFilm As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Private WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Private WithEvents Main_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnNew As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Misc_Bar As DevExpress.XtraBars.Bar
    Private WithEvents MainBtns_btnExcel As DevExpress.XtraBars.BarButtonItem
    Private WithEvents MainBtns_btnBigger As DevExpress.XtraBars.BarButtonItem
    Private WithEvents MainBtns_btnSmaller As DevExpress.XtraBars.BarButtonItem
    Private WithEvents MainBtns_btnBestFit As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnOK As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser1 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser2 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser3 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser4 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnUser5 As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnExportXML As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnImportXML As DevExpress.XtraBars.BarButtonItem
    Private WithEvents View_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents cmbViewList As DevExpress.XtraBars.BarEditItem
    'Private WithEvents btnViewDetail As DevExpress.XtraBars.BarSubItem
    Private WithEvents btnEditView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNewView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDeleteView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSaveView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnMakeViewCommon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSendViewUser As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnCopyView As DevExpress.XtraBars.BarButtonItem
    Private WithEvents QuickSearch_Bar As DevExpress.XtraBars.Bar
    Private WithEvents txtQuickSearch As DevExpress.XtraBars.BarEditItem
    Private WithEvents btnQuickSearch As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Report_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Private WithEvents cmbReportList As DevExpress.XtraBars.BarEditItem
    'Private WithEvents btnReportDetail As DevExpress.XtraBars.BarSubItem
    Private WithEvents btnEditReportInfo As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNewReport As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDeleteReport As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDesignReport As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnMakeReportCommon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSendReportUser As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnCopyReport As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Filter_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents cmbFilterList As DevExpress.XtraBars.BarEditItem
    'Private WithEvents btnFilterDetail As DevExpress.XtraBars.BarSubItem
    Private WithEvents btnEditFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNewFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDeleteFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnMakeFilterCommon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSendFilterUSer As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnCopyFilter As DevExpress.XtraBars.BarButtonItem
    Private WithEvents DefaultSet_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents cmbDefaultList As DevExpress.XtraBars.BarEditItem
    'Private WithEvents btnDefaultDetail As DevExpress.XtraBars.BarSubItem
    Private WithEvents btnEditDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNewDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnDeleteDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSaveDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnMakeDefaultCommon As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnSendDefaultUser As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnCopyDefault As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Misc_Bar2 As DevExpress.XtraBars.Bar
    Private WithEvents btnTranslation As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnComments As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnAttachements As DevExpress.XtraBars.BarButtonItem
    Private WithEvents Nav_Bar As DevExpress.XtraBars.Bar
    Private WithEvents btnFirst As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnPrevious As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnNext As DevExpress.XtraBars.BarButtonItem
    Private WithEvents btnLast As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colSource As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents lblCredit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents spedCredit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents colCredit As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents xTabVODOnlyMovie As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnAllNoMovieInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grdOnlyVODMovie As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents imdb_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents filename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDeleteVOD As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmbgridStatus As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents btnSaveAllChanges As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dpDateStart As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents dtpDateExpired As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents cmbLanguagesSubtitleEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryLanguageSubtitleGrid As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

End Class
