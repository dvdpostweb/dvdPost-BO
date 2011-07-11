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
        Dim colDateStartUploaded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
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
        Me.GridProductsDVD = New DevExpress.XtraGrid.GridControl
        Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.colQuality = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStudio = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbStudio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colStatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colImdb_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.collanguage_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.cmbLanguages = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colLanguage_subtitle = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colproducts_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ColAvailable_from = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colExpireAt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAvailable = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.chkcolAvailable = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.XTabView = New DevExpress.XtraTab.XtraTabPage
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
        Me.colQuality2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colProductNameUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colStudioUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositoryCmbStudio = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colStatusUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ColImdbUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colLangAudioUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositorycmbLanguage = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colLangSubtitleUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colDateExpiredUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.colAvailableUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.RepositorychkAvailable = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.WebSiteDvdPost = New System.Windows.Forms.WebBrowser
        Me.TabFtp = New DevExpress.XtraTab.XtraTabPage
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
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
        Me.FolderChoose = New System.Windows.Forms.FolderBrowserDialog
        colDateStartUploaded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XTabControlVod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabControlVod.SuspendLayout()
        Me.XTabSearch.SuspendLayout()
        CType(Me.txtImdb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtProducts_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabResult.SuspendLayout()
        CType(Me.GridProductsDVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XTabView.SuspendLayout()
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
        CType(Me.RepositoryCmbStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorycmbLanguage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositorychkAvailable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabFtp.SuspendLayout()
        CType(Me.txtSourceFtp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSourceLocal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDBFtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewDBFtp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridFtpLocal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewFtpLocal, System.ComponentModel.ISupportInitialize).BeginInit()
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
        colDateStartUploaded.Width = 162
        '
        'XTabControlVod
        '
        Me.XTabControlVod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XTabControlVod.Location = New System.Drawing.Point(0, 35)
        Me.XTabControlVod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XTabControlVod.Name = "XTabControlVod"
        Me.XTabControlVod.SelectedTabPage = Me.XTabSearch
        Me.XTabControlVod.Size = New System.Drawing.Size(1408, 820)
        Me.XTabControlVod.TabIndex = 4
        Me.XTabControlVod.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XTabSearch, Me.XTabResult, Me.XTabView, Me.XTabProcess, Me.XTabViewVod, Me.TabFtp})
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
        Me.XTabSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XTabSearch.Name = "XTabSearch"
        Me.XTabSearch.Size = New System.Drawing.Size(1399, 786)
        Me.XTabSearch.Text = "Search"
        '
        'btnRipped
        '
        Me.btnRipped.Location = New System.Drawing.Point(592, 260)
        Me.btnRipped.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRipped.Name = "btnRipped"
        Me.btnRipped.Size = New System.Drawing.Size(100, 28)
        Me.btnRipped.TabIndex = 18
        Me.btnRipped.Text = "ripped"
        '
        'BtnViewAll
        '
        Me.BtnViewAll.Location = New System.Drawing.Point(447, 260)
        Me.BtnViewAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnViewAll.Name = "BtnViewAll"
        Me.BtnViewAll.Size = New System.Drawing.Size(100, 28)
        Me.BtnViewAll.TabIndex = 17
        Me.BtnViewAll.Text = "View all"
        '
        'BtnNewVodProduct
        '
        Me.BtnNewVodProduct.Location = New System.Drawing.Point(259, 260)
        Me.BtnNewVodProduct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnNewVodProduct.Name = "BtnNewVodProduct"
        Me.BtnNewVodProduct.Size = New System.Drawing.Size(100, 28)
        Me.BtnNewVodProduct.TabIndex = 16
        Me.BtnNewVodProduct.Text = "New"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(75, 260)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(100, 28)
        Me.btnSearch.TabIndex = 15
        Me.btnSearch.Text = "Search"
        '
        'txtImdb
        '
        Me.txtImdb.Location = New System.Drawing.Point(209, 139)
        Me.txtImdb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImdb.Name = "txtImdb"
        Me.txtImdb.Size = New System.Drawing.Size(149, 22)
        Me.txtImdb.TabIndex = 14
        '
        'LblImdb
        '
        Me.LblImdb.Location = New System.Drawing.Point(35, 143)
        Me.LblImdb.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LblImdb.Name = "LblImdb"
        Me.LblImdb.Size = New System.Drawing.Size(45, 16)
        Me.LblImdb.TabIndex = 13
        Me.LblImdb.Text = "Imdb ID"
        '
        'TxtProducts_id
        '
        Me.TxtProducts_id.Location = New System.Drawing.Point(209, 84)
        Me.TxtProducts_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtProducts_id.Name = "TxtProducts_id"
        Me.TxtProducts_id.Size = New System.Drawing.Size(149, 22)
        Me.TxtProducts_id.TabIndex = 12
        '
        'lblProduct_id
        '
        Me.lblProduct_id.Location = New System.Drawing.Point(35, 87)
        Me.lblProduct_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblProduct_id.Name = "lblProduct_id"
        Me.lblProduct_id.Size = New System.Drawing.Size(59, 16)
        Me.lblProduct_id.TabIndex = 11
        Me.lblProduct_id.Text = "Product ID"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(209, 34)
        Me.txtTitleSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(629, 22)
        Me.txtTitleSearch.TabIndex = 10
        '
        'lblPartTitle
        '
        Me.lblPartTitle.Location = New System.Drawing.Point(35, 43)
        Me.lblPartTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblPartTitle.Name = "lblPartTitle"
        Me.lblPartTitle.Size = New System.Drawing.Size(67, 16)
        Me.lblPartTitle.TabIndex = 9
        Me.lblPartTitle.Text = "Part of Title"
        '
        'XTabResult
        '
        Me.XTabResult.Controls.Add(Me.GridProductsDVD)
        Me.XTabResult.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XTabResult.Name = "XTabResult"
        Me.XTabResult.Size = New System.Drawing.Size(1399, 786)
        Me.XTabResult.Text = "Result"
        '
        'GridProductsDVD
        '
        Me.GridProductsDVD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProductsDVD.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridProductsDVD.EmbeddedNavigator.Name = ""
        Me.GridProductsDVD.FormsUseDefaultLookAndFeel = False
        Me.GridProductsDVD.Location = New System.Drawing.Point(0, 0)
        Me.GridProductsDVD.MainView = Me.GridViewSearch
        Me.GridProductsDVD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridProductsDVD.Name = "GridProductsDVD"
        Me.GridProductsDVD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages, Me.chkcolAvailable, Me.cmbStudio})
        Me.GridProductsDVD.Size = New System.Drawing.Size(1399, 786)
        Me.GridProductsDVD.TabIndex = 4
        Me.GridProductsDVD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
        '
        'GridViewSearch
        '
        Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
        Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colImdb_id, Me.collanguage_id, Me.colproducts_name, Me.ColAvailable_from, Me.colExpireAt, Me.colLanguage_subtitle, Me.colAvailable, Me.colStudio, Me.colStatus, Me.colQuality})
        Me.GridViewSearch.CustomizationFormBounds = New System.Drawing.Rectangle(1685, 658, 225, 209)
        Me.GridViewSearch.GridControl = Me.GridProductsDVD
        Me.GridViewSearch.Name = "GridViewSearch"
        Me.GridViewSearch.OptionsView.ColumnAutoWidth = True
        Me.GridViewSearch.OptionsView.ShowAutoFilterRow = True
        Me.GridViewSearch.OptionsView.ShowBands = False
        Me.GridViewSearch.OptionsView.ShowFooter = True
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "GridBand1"
        Me.GridBand1.Columns.Add(Me.colQuality)
        Me.GridBand1.Columns.Add(Me.colStudio)
        Me.GridBand1.Columns.Add(Me.colStatus)
        Me.GridBand1.Columns.Add(Me.colImdb_id)
        Me.GridBand1.Columns.Add(Me.collanguage_id)
        Me.GridBand1.Columns.Add(Me.colLanguage_subtitle)
        Me.GridBand1.Columns.Add(Me.colproducts_name)
        Me.GridBand1.Columns.Add(Me.ColAvailable_from)
        Me.GridBand1.Columns.Add(Me.colExpireAt)
        Me.GridBand1.Columns.Add(Me.colAvailable)
        Me.GridBand1.MinWidth = 20
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 1012
        '
        'colQuality
        '
        Me.colQuality.Caption = "quality"
        Me.colQuality.FieldName = "quality"
        Me.colQuality.Name = "colQuality"
        Me.colQuality.Visible = True
        '
        'colStudio
        '
        Me.colStudio.Caption = "studio"
        Me.colStudio.ColumnEdit = Me.cmbStudio
        Me.colStudio.FieldName = "studio_id"
        Me.colStudio.Name = "colStudio"
        Me.colStudio.OptionsColumn.AllowEdit = False
        Me.colStudio.OptionsColumn.ReadOnly = True
        Me.colStudio.Visible = True
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
        Me.colStatus.FieldName = "status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        '
        'colImdb_id
        '
        Me.colImdb_id.Caption = "imdb id"
        Me.colImdb_id.FieldName = "imdb_id"
        Me.colImdb_id.Name = "colImdb_id"
        Me.colImdb_id.OptionsColumn.AllowEdit = False
        Me.colImdb_id.Visible = True
        Me.colImdb_id.Width = 99
        '
        'collanguage_id
        '
        Me.collanguage_id.Caption = "language sound"
        Me.collanguage_id.ColumnEdit = Me.cmbLanguages
        Me.collanguage_id.FieldName = "language_id"
        Me.collanguage_id.Name = "collanguage_id"
        Me.collanguage_id.OptionsColumn.AllowEdit = False
        Me.collanguage_id.Visible = True
        Me.collanguage_id.Width = 118
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
        Me.colLanguage_subtitle.ColumnEdit = Me.cmbLanguages
        Me.colLanguage_subtitle.FieldName = "subtitle_id"
        Me.colLanguage_subtitle.Name = "colLanguage_subtitle"
        Me.colLanguage_subtitle.OptionsColumn.AllowEdit = False
        Me.colLanguage_subtitle.Visible = True
        Me.colLanguage_subtitle.Width = 104
        '
        'colproducts_name
        '
        Me.colproducts_name.Caption = "products name"
        Me.colproducts_name.FieldName = "products_name"
        Me.colproducts_name.Name = "colproducts_name"
        Me.colproducts_name.OptionsColumn.AllowEdit = False
        Me.colproducts_name.Visible = True
        Me.colproducts_name.Width = 134
        '
        'ColAvailable_from
        '
        Me.ColAvailable_from.Caption = "date start"
        Me.ColAvailable_from.FieldName = "available_from"
        Me.ColAvailable_from.Name = "ColAvailable_from"
        Me.ColAvailable_from.OptionsColumn.AllowEdit = False
        Me.ColAvailable_from.Visible = True
        Me.ColAvailable_from.Width = 129
        '
        'colExpireAt
        '
        Me.colExpireAt.Caption = "date expired"
        Me.colExpireAt.FieldName = "expire_at"
        Me.colExpireAt.Name = "colExpireAt"
        Me.colExpireAt.OptionsColumn.AllowEdit = False
        Me.colExpireAt.Visible = True
        Me.colExpireAt.Width = 128
        '
        'colAvailable
        '
        Me.colAvailable.Caption = "available"
        Me.colAvailable.ColumnEdit = Me.chkcolAvailable
        Me.colAvailable.FieldName = "available"
        Me.colAvailable.Name = "colAvailable"
        Me.colAvailable.OptionsColumn.AllowEdit = False
        Me.colAvailable.OptionsColumn.ReadOnly = True
        Me.colAvailable.Visible = True
        '
        'chkcolAvailable
        '
        Me.chkcolAvailable.AutoHeight = False
        Me.chkcolAvailable.Name = "chkcolAvailable"
        Me.chkcolAvailable.ValueChecked = CType(1, Byte)
        Me.chkcolAvailable.ValueUnchecked = CType(0, Byte)
        '
        'XTabView
        '
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
        Me.XTabView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XTabView.Name = "XTabView"
        Me.XTabView.Size = New System.Drawing.Size(1399, 786)
        Me.XTabView.Text = "View"
        '
        'cmbQuality
        '
        Me.cmbQuality.AllowDrop = True
        Me.cmbQuality.Enabled = False
        Me.cmbQuality.Location = New System.Drawing.Point(456, 289)
        Me.cmbQuality.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbQuality.Name = "cmbQuality"
        Me.cmbQuality.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbQuality.Properties.DisplayMember = "status_desc"
        Me.cmbQuality.Properties.NullText = ""
        Me.cmbQuality.Properties.ValueMember = "status_id"
        Me.cmbQuality.Size = New System.Drawing.Size(149, 22)
        Me.cmbQuality.TabIndex = 79
        '
        'lblHigh
        '
        Me.lblHigh.Location = New System.Drawing.Point(329, 293)
        Me.lblHigh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(37, 16)
        Me.lblHigh.TabIndex = 78
        Me.lblHigh.Text = "quality"
        '
        'cmbStatus
        '
        Me.cmbStatus.Enabled = False
        Me.cmbStatus.Location = New System.Drawing.Point(456, 235)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStatus.Properties.DisplayMember = "status_desc"
        Me.cmbStatus.Properties.NullText = ""
        Me.cmbStatus.Properties.ValueMember = "status_id"
        Me.cmbStatus.Size = New System.Drawing.Size(149, 22)
        Me.cmbStatus.TabIndex = 77
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(329, 239)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(34, 16)
        Me.lblStatus.TabIndex = 76
        Me.lblStatus.Text = "status"
        '
        'cmbStudioEdit
        '
        Me.cmbStudioEdit.Enabled = False
        Me.cmbStudioEdit.Location = New System.Drawing.Point(151, 132)
        Me.cmbStudioEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbStudioEdit.Name = "cmbStudioEdit"
        Me.cmbStudioEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbStudioEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "name", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbStudioEdit.Properties.DisplayMember = "status_desc"
        Me.cmbStudioEdit.Properties.NullText = ""
        Me.cmbStudioEdit.Properties.ValueMember = "status_id"
        Me.cmbStudioEdit.Size = New System.Drawing.Size(149, 22)
        Me.cmbStudioEdit.TabIndex = 75
        '
        'lblStudio
        '
        Me.lblStudio.Location = New System.Drawing.Point(24, 135)
        Me.lblStudio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblStudio.Name = "lblStudio"
        Me.lblStudio.Size = New System.Drawing.Size(34, 16)
        Me.lblStudio.TabIndex = 74
        Me.lblStudio.Text = "studio"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(505, 81)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(149, 22)
        Me.txtId.TabIndex = 73
        '
        'lblId
        '
        Me.lblId.Location = New System.Drawing.Point(456, 85)
        Me.lblId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(12, 16)
        Me.lblId.TabIndex = 72
        Me.lblId.Text = "ID"
        '
        'btnCancelVod
        '
        Me.btnCancelVod.Enabled = False
        Me.btnCancelVod.Location = New System.Drawing.Point(289, 28)
        Me.btnCancelVod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelVod.Name = "btnCancelVod"
        Me.btnCancelVod.Size = New System.Drawing.Size(100, 28)
        Me.btnCancelVod.TabIndex = 71
        Me.btnCancelVod.Text = "Cancel"
        '
        'cmbLanguageSubtitle
        '
        Me.cmbLanguageSubtitle.Enabled = False
        Me.cmbLanguageSubtitle.Location = New System.Drawing.Point(151, 220)
        Me.cmbLanguageSubtitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbLanguageSubtitle.Name = "cmbLanguageSubtitle"
        Me.cmbLanguageSubtitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguageSubtitle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguageSubtitle.Properties.DisplayMember = "status_desc"
        Me.cmbLanguageSubtitle.Properties.NullText = ""
        Me.cmbLanguageSubtitle.Properties.ValueMember = "status_id"
        Me.cmbLanguageSubtitle.Size = New System.Drawing.Size(149, 22)
        Me.cmbLanguageSubtitle.TabIndex = 70
        '
        'cmbLanguageSound
        '
        Me.cmbLanguageSound.Enabled = False
        Me.cmbLanguageSound.Location = New System.Drawing.Point(151, 176)
        Me.cmbLanguageSound.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbLanguageSound.Name = "cmbLanguageSound"
        Me.cmbLanguageSound.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbLanguageSound.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbLanguageSound.Properties.DisplayMember = "status_desc"
        Me.cmbLanguageSound.Properties.NullText = ""
        Me.cmbLanguageSound.Properties.ValueMember = "status_id"
        Me.cmbLanguageSound.Size = New System.Drawing.Size(149, 22)
        Me.cmbLanguageSound.TabIndex = 69
        '
        'cmbDateExpired
        '
        Me.cmbDateExpired.EditValue = Nothing
        Me.cmbDateExpired.Enabled = False
        Me.cmbDateExpired.Location = New System.Drawing.Point(151, 329)
        Me.cmbDateExpired.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbDateExpired.Name = "cmbDateExpired"
        Me.cmbDateExpired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateExpired.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateExpired.Size = New System.Drawing.Size(149, 22)
        Me.cmbDateExpired.TabIndex = 68
        '
        'cmbDateStart
        '
        Me.cmbDateStart.EditValue = Nothing
        Me.cmbDateStart.Enabled = False
        Me.cmbDateStart.Location = New System.Drawing.Point(151, 272)
        Me.cmbDateStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbDateStart.Name = "cmbDateStart"
        Me.cmbDateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDateStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.cmbDateStart.Size = New System.Drawing.Size(149, 22)
        Me.cmbDateStart.TabIndex = 67
        '
        'TxtFilename
        '
        Me.TxtFilename.Enabled = False
        Me.TxtFilename.Location = New System.Drawing.Point(456, 127)
        Me.TxtFilename.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtFilename.Name = "TxtFilename"
        Me.TxtFilename.Size = New System.Drawing.Size(239, 22)
        Me.TxtFilename.TabIndex = 66
        '
        'chkAvailable
        '
        Me.chkAvailable.Location = New System.Drawing.Point(453, 183)
        Me.chkAvailable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkAvailable.Name = "chkAvailable"
        Me.chkAvailable.Properties.Caption = ""
        Me.chkAvailable.Size = New System.Drawing.Size(75, 21)
        Me.chkAvailable.TabIndex = 65
        '
        'lblAvailable
        '
        Me.lblAvailable.Location = New System.Drawing.Point(329, 187)
        Me.lblAvailable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblAvailable.Name = "lblAvailable"
        Me.lblAvailable.Size = New System.Drawing.Size(50, 16)
        Me.lblAvailable.TabIndex = 64
        Me.lblAvailable.Text = "available"
        '
        'lblNameFile
        '
        Me.lblNameFile.Location = New System.Drawing.Point(329, 135)
        Me.lblNameFile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblNameFile.Name = "lblNameFile"
        Me.lblNameFile.Size = New System.Drawing.Size(53, 16)
        Me.lblNameFile.TabIndex = 63
        Me.lblNameFile.Text = "file name"
        '
        'lblDateExpired
        '
        Me.lblDateExpired.Location = New System.Drawing.Point(24, 337)
        Me.lblDateExpired.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDateExpired.Name = "lblDateExpired"
        Me.lblDateExpired.Size = New System.Drawing.Size(71, 16)
        Me.lblDateExpired.TabIndex = 62
        Me.lblDateExpired.Text = "date expired"
        '
        'lblDateStart
        '
        Me.lblDateStart.Location = New System.Drawing.Point(24, 281)
        Me.lblDateStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblDateStart.Name = "lblDateStart"
        Me.lblDateStart.Size = New System.Drawing.Size(55, 16)
        Me.lblDateStart.TabIndex = 61
        Me.lblDateStart.Text = "date start"
        '
        'lblLanguage_subtitle
        '
        Me.lblLanguage_subtitle.Location = New System.Drawing.Point(24, 224)
        Me.lblLanguage_subtitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLanguage_subtitle.Name = "lblLanguage_subtitle"
        Me.lblLanguage_subtitle.Size = New System.Drawing.Size(97, 16)
        Me.lblLanguage_subtitle.TabIndex = 60
        Me.lblLanguage_subtitle.Text = "language subtitle"
        '
        'lblLanguageSound
        '
        Me.lblLanguageSound.Location = New System.Drawing.Point(24, 180)
        Me.lblLanguageSound.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblLanguageSound.Name = "lblLanguageSound"
        Me.lblLanguageSound.Size = New System.Drawing.Size(90, 16)
        Me.lblLanguageSound.TabIndex = 59
        Me.lblLanguageSound.Text = "language sound"
        '
        'txtImdbView
        '
        Me.txtImdbView.Enabled = False
        Me.txtImdbView.Location = New System.Drawing.Point(151, 100)
        Me.txtImdbView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtImdbView.Name = "txtImdbView"
        Me.txtImdbView.Size = New System.Drawing.Size(149, 22)
        Me.txtImdbView.TabIndex = 58
        '
        'lblImdbView
        '
        Me.lblImdbView.Location = New System.Drawing.Point(24, 103)
        Me.lblImdbView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lblImdbView.Name = "lblImdbView"
        Me.lblImdbView.Size = New System.Drawing.Size(45, 16)
        Me.lblImdbView.TabIndex = 57
        Me.lblImdbView.Text = "Imdb ID"
        '
        'btnSaveVod
        '
        Me.btnSaveVod.Enabled = False
        Me.btnSaveVod.Location = New System.Drawing.Point(24, 28)
        Me.btnSaveVod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSaveVod.Name = "btnSaveVod"
        Me.btnSaveVod.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveVod.TabIndex = 52
        Me.btnSaveVod.Text = "Save"
        '
        'btnEditVod
        '
        Me.btnEditVod.Enabled = False
        Me.btnEditVod.Location = New System.Drawing.Point(151, 28)
        Me.btnEditVod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEditVod.Name = "btnEditVod"
        Me.btnEditVod.Size = New System.Drawing.Size(105, 28)
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
        Me.XTabProcess.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XTabProcess.Name = "XTabProcess"
        Me.XTabProcess.Size = New System.Drawing.Size(1399, 786)
        Me.XTabProcess.Text = "Processus vod"
        '
        'lblDestinationPathFile
        '
        Me.lblDestinationPathFile.AutoSize = True
        Me.lblDestinationPathFile.Location = New System.Drawing.Point(101, 79)
        Me.lblDestinationPathFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDestinationPathFile.Name = "lblDestinationPathFile"
        Me.lblDestinationPathFile.Size = New System.Drawing.Size(169, 17)
        Me.lblDestinationPathFile.TabIndex = 8
        Me.lblDestinationPathFile.Text = "Destination queue filezilla"
        '
        'txtDestinationPath
        '
        Me.txtDestinationPath.EditValue = "z:\vod\tmp\xml"
        Me.txtDestinationPath.Location = New System.Drawing.Point(292, 75)
        Me.txtDestinationPath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDestinationPath.Name = "txtDestinationPath"
        Me.txtDestinationPath.Size = New System.Drawing.Size(628, 22)
        Me.txtDestinationPath.TabIndex = 7
        '
        'btnDestination
        '
        Me.btnDestination.Location = New System.Drawing.Point(40, 71)
        Me.btnDestination.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDestination.Name = "btnDestination"
        Me.btnDestination.Size = New System.Drawing.Size(53, 28)
        Me.btnDestination.TabIndex = 6
        Me.btnDestination.Text = "..."
        '
        'txtSourcePath
        '
        Me.txtSourcePath.Location = New System.Drawing.Point(292, 20)
        Me.txtSourcePath.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSourcePath.Name = "txtSourcePath"
        Me.txtSourcePath.Size = New System.Drawing.Size(628, 22)
        Me.txtSourcePath.TabIndex = 5
        '
        'ProgressBarRipping
        '
        Me.ProgressBarRipping.Location = New System.Drawing.Point(292, 167)
        Me.ProgressBarRipping.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBarRipping.Name = "ProgressBarRipping"
        Me.ProgressBarRipping.Size = New System.Drawing.Size(467, 28)
        Me.ProgressBarRipping.TabIndex = 4
        '
        'btnGenerateRipping
        '
        Me.btnGenerateRipping.Location = New System.Drawing.Point(12, 167)
        Me.btnGenerateRipping.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerateRipping.Name = "btnGenerateRipping"
        Me.btnGenerateRipping.Size = New System.Drawing.Size(155, 28)
        Me.btnGenerateRipping.TabIndex = 3
        Me.btnGenerateRipping.Text = "Generate Ripping"
        '
        'btnSource
        '
        Me.btnSource.Location = New System.Drawing.Point(40, 20)
        Me.btnSource.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSource.Name = "btnSource"
        Me.btnSource.Size = New System.Drawing.Size(53, 28)
        Me.btnSource.TabIndex = 2
        Me.btnSource.Text = "..."
        '
        'lblPathSourceTitle
        '
        Me.lblPathSourceTitle.AutoSize = True
        Me.lblPathSourceTitle.Location = New System.Drawing.Point(101, 28)
        Me.lblPathSourceTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPathSourceTitle.Name = "lblPathSourceTitle"
        Me.lblPathSourceTitle.Size = New System.Drawing.Size(113, 17)
        Me.lblPathSourceTitle.TabIndex = 0
        Me.lblPathSourceTitle.Text = "Source files mp4"
        '
        'XTabViewVod
        '
        Me.XTabViewVod.Controls.Add(Me.GridVodWatch)
        Me.XTabViewVod.Controls.Add(Me.WebSiteDvdPost)
        Me.XTabViewVod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XTabViewVod.Name = "XTabViewVod"
        Me.XTabViewVod.Size = New System.Drawing.Size(1399, 784)
        Me.XTabViewVod.Text = "view vod"
        '
        'GridVodWatch
        '
        Me.GridVodWatch.Dock = System.Windows.Forms.DockStyle.Left
        Me.GridVodWatch.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridVodWatch.EmbeddedNavigator.Name = ""
        Me.GridVodWatch.FormsUseDefaultLookAndFeel = False
        Me.GridVodWatch.Location = New System.Drawing.Point(0, 0)
        Me.GridVodWatch.MainView = Me.gridViewVodWatch
        Me.GridVodWatch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridVodWatch.Name = "GridVodWatch"
        Me.GridVodWatch.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositorycmbLanguage, Me.RepositorychkAvailable, Me.RepositoryCmbStudio})
        Me.GridVodWatch.Size = New System.Drawing.Size(685, 784)
        Me.GridVodWatch.TabIndex = 5
        Me.GridVodWatch.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewVodWatch})
        '
        'gridViewVodWatch
        '
        Me.gridViewVodWatch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
        Me.gridViewVodWatch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.ColImdbUploaded, Me.colLangAudioUploaded, Me.colProductNameUploaded, colDateStartUploaded, Me.colDateExpiredUploaded, Me.colLangSubtitleUploaded, Me.colAvailableUploaded, Me.colStudioUploaded, Me.colStatusUploaded, Me.colQuality2})
        Me.gridViewVodWatch.CustomizationFormBounds = New System.Drawing.Rectangle(1685, 658, 225, 209)
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
        Me.GridBand2.Width = 1488
        '
        'colQuality2
        '
        Me.colQuality2.Caption = "quality"
        Me.colQuality2.FieldName = "quality"
        Me.colQuality2.Name = "colQuality2"
        Me.colQuality2.Visible = True
        Me.colQuality2.Width = 110
        '
        'colProductNameUploaded
        '
        Me.colProductNameUploaded.Caption = "products name"
        Me.colProductNameUploaded.FieldName = "products_name"
        Me.colProductNameUploaded.Name = "colProductNameUploaded"
        Me.colProductNameUploaded.OptionsColumn.AllowEdit = False
        Me.colProductNameUploaded.Visible = True
        Me.colProductNameUploaded.Width = 288
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
        Me.ColImdbUploaded.Width = 154
        '
        'colLangAudioUploaded
        '
        Me.colLangAudioUploaded.Caption = "Audio"
        Me.colLangAudioUploaded.ColumnEdit = Me.RepositorycmbLanguage
        Me.colLangAudioUploaded.FieldName = "language_id"
        Me.colLangAudioUploaded.Name = "colLangAudioUploaded"
        Me.colLangAudioUploaded.OptionsColumn.AllowEdit = False
        Me.colLangAudioUploaded.Visible = True
        Me.colLangAudioUploaded.Width = 199
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
        Me.colLangSubtitleUploaded.ColumnEdit = Me.RepositorycmbLanguage
        Me.colLangSubtitleUploaded.FieldName = "subtitle_id"
        Me.colLangSubtitleUploaded.Name = "colLangSubtitleUploaded"
        Me.colLangSubtitleUploaded.OptionsColumn.AllowEdit = False
        Me.colLangSubtitleUploaded.Visible = True
        Me.colLangSubtitleUploaded.Width = 136
        '
        'colDateExpiredUploaded
        '
        Me.colDateExpiredUploaded.Caption = "date expired"
        Me.colDateExpiredUploaded.FieldName = "expire_at"
        Me.colDateExpiredUploaded.Name = "colDateExpiredUploaded"
        Me.colDateExpiredUploaded.OptionsColumn.AllowEdit = False
        Me.colDateExpiredUploaded.Visible = True
        Me.colDateExpiredUploaded.Width = 204
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
        Me.colAvailableUploaded.Width = 235
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
        Me.WebSiteDvdPost.Location = New System.Drawing.Point(579, 0)
        Me.WebSiteDvdPost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WebSiteDvdPost.MinimumSize = New System.Drawing.Size(27, 25)
        Me.WebSiteDvdPost.Name = "WebSiteDvdPost"
        Me.WebSiteDvdPost.Size = New System.Drawing.Size(820, 784)
        Me.WebSiteDvdPost.TabIndex = 6
        '
        'TabFtp
        '
        Me.TabFtp.Controls.Add(Me.lblDbFtp)
        Me.TabFtp.Controls.Add(Me.lblFtpLocal)
        Me.TabFtp.Controls.Add(Me.txtSourceFtp)
        Me.TabFtp.Controls.Add(Me.TxtSourceLocal)
        Me.TabFtp.Controls.Add(Me.btnFolderLocal)
        Me.TabFtp.Controls.Add(Me.lblLocal)
        Me.TabFtp.Controls.Add(Me.GridDBFtp)
        Me.TabFtp.Controls.Add(Me.GridFtpLocal)
        Me.TabFtp.Controls.Add(Me.BtnCompare)
        Me.TabFtp.Controls.Add(Me.lblFTP)
        Me.TabFtp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabFtp.Name = "TabFtp"
        Me.TabFtp.Size = New System.Drawing.Size(1399, 784)
        Me.TabFtp.Text = "Compare Ftp"
        '
        'lblDbFtp
        '
        Me.lblDbFtp.AutoSize = True
        Me.lblDbFtp.Location = New System.Drawing.Point(701, 105)
        Me.lblDbFtp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDbFtp.Name = "lblDbFtp"
        Me.lblDbFtp.Size = New System.Drawing.Size(73, 17)
        Me.lblDbFtp.TabIndex = 14
        Me.lblDbFtp.Text = "DB % FTP"
        '
        'lblFtpLocal
        '
        Me.lblFtpLocal.AutoSize = True
        Me.lblFtpLocal.Location = New System.Drawing.Point(187, 105)
        Me.lblFtpLocal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFtpLocal.Name = "lblFtpLocal"
        Me.lblFtpLocal.Size = New System.Drawing.Size(79, 17)
        Me.lblFtpLocal.TabIndex = 13
        Me.lblFtpLocal.Text = "FT % Local"
        '
        'txtSourceFtp
        '
        Me.txtSourceFtp.EditValue = "ftp://upload.cdnlayer.com/media/secureflash/"
        Me.txtSourceFtp.Location = New System.Drawing.Point(56, 38)
        Me.txtSourceFtp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSourceFtp.Name = "txtSourceFtp"
        Me.txtSourceFtp.Size = New System.Drawing.Size(351, 22)
        Me.txtSourceFtp.TabIndex = 12
        '
        'TxtSourceLocal
        '
        Me.TxtSourceLocal.EditValue = "z:\vod\tmp"
        Me.TxtSourceLocal.Location = New System.Drawing.Point(61, 74)
        Me.TxtSourceLocal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSourceLocal.Name = "TxtSourceLocal"
        Me.TxtSourceLocal.Size = New System.Drawing.Size(243, 22)
        Me.TxtSourceLocal.TabIndex = 11
        '
        'btnFolderLocal
        '
        Me.btnFolderLocal.Location = New System.Drawing.Point(312, 78)
        Me.btnFolderLocal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFolderLocal.Name = "btnFolderLocal"
        Me.btnFolderLocal.Size = New System.Drawing.Size(53, 28)
        Me.btnFolderLocal.TabIndex = 10
        Me.btnFolderLocal.Text = "..."
        '
        'lblLocal
        '
        Me.lblLocal.AutoSize = True
        Me.lblLocal.Location = New System.Drawing.Point(15, 82)
        Me.lblLocal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLocal.Name = "lblLocal"
        Me.lblLocal.Size = New System.Drawing.Size(37, 17)
        Me.lblLocal.TabIndex = 9
        Me.lblLocal.Text = "local"
        '
        'GridDBFtp
        '
        Me.GridDBFtp.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridDBFtp.EmbeddedNavigator.Name = ""
        Me.GridDBFtp.FormsUseDefaultLookAndFeel = False
        Me.GridDBFtp.Location = New System.Drawing.Point(476, 124)
        Me.GridDBFtp.MainView = Me.GridViewDBFtp
        Me.GridDBFtp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridDBFtp.Name = "GridDBFtp"
        Me.GridDBFtp.Size = New System.Drawing.Size(648, 652)
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
        Me.GridFtpLocal.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridFtpLocal.EmbeddedNavigator.Name = ""
        Me.GridFtpLocal.FormsUseDefaultLookAndFeel = False
        Me.GridFtpLocal.Location = New System.Drawing.Point(16, 124)
        Me.GridFtpLocal.MainView = Me.GridViewFtpLocal
        Me.GridFtpLocal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GridFtpLocal.Name = "GridFtpLocal"
        Me.GridFtpLocal.Size = New System.Drawing.Size(424, 649)
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
        Me.BtnCompare.Location = New System.Drawing.Point(307, 4)
        Me.BtnCompare.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCompare.Name = "BtnCompare"
        Me.BtnCompare.Size = New System.Drawing.Size(100, 28)
        Me.BtnCompare.TabIndex = 4
        Me.BtnCompare.Text = "Compare"
        Me.BtnCompare.UseVisualStyleBackColor = True
        '
        'lblFTP
        '
        Me.lblFTP.AutoSize = True
        Me.lblFTP.Location = New System.Drawing.Point(12, 42)
        Me.lblFTP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFTP.Name = "lblFTP"
        Me.lblFTP.Size = New System.Drawing.Size(34, 17)
        Me.lblFTP.TabIndex = 2
        Me.lblFTP.Text = "FTP"
        
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 855)
        Me.Controls.Add(Me.XTabControlVod)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmProductsVOD"
        Me.Text = "FrmProductsVOD"
        Me.Controls.SetChildIndex(Me.XTabControlVod, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XTabControlVod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabControlVod.ResumeLayout(False)
        Me.XTabSearch.ResumeLayout(False)
        Me.XTabSearch.PerformLayout()
        CType(Me.txtImdb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtProducts_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabResult.ResumeLayout(False)
        CType(Me.GridProductsDVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLanguages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkcolAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XTabView.ResumeLayout(False)
        Me.XTabView.PerformLayout()
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
        CType(Me.RepositoryCmbStudio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorycmbLanguage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositorychkAvailable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabFtp.ResumeLayout(False)
        Me.TabFtp.PerformLayout()
        CType(Me.txtSourceFtp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSourceLocal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDBFtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewDBFtp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridFtpLocal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewFtpLocal, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridProductsDVD As DevExpress.XtraGrid.GridControl
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
    Friend WithEvents TabFtp As DevExpress.XtraTab.XtraTabPage
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
End Class
