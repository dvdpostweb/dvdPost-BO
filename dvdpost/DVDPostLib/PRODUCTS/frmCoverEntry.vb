Public Class frmCoverEntry
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
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTitleSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTotalQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtyNoCover As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCoverQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCoverBoxID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnUpdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvdid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_dvd_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcover_box_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbDVDStatus As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnSaveGrid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSalesPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtyToSale As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSaleDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnSaveSaleInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtTitle = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.txtTitleSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.cmbProductID = New DevExpress.XtraEditors.LookUpEdit
        Me.objDS = New DVDPostLib.dsProducts
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.txtTotalQty = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.txtQtyNoCover = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtCoverQty = New DevExpress.XtraEditors.TextEdit
        Me.txtCoverBoxID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.btnUpdate = New DevExpress.XtraEditors.SimpleButton
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colproducts_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvdid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colproducts_dvd_status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cmbDVDStatus = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.colcover_box_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnSaveGrid = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.txtSalesPrice = New DevExpress.XtraEditors.TextEdit
        Me.txtQtyToSale = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtSaleDate = New DevExpress.XtraEditors.DateEdit
        Me.btnSaveSaleInfo = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyNoCover.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCoverQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCoverBoxID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalesPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyToSale.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaleDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSaleDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(115, 102)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Properties.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(365, 22)
        Me.txtTitle.TabIndex = 3
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(19, 74)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 16)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Product ID"
        '
        'txtTitleSearch
        '
        Me.txtTitleSearch.Location = New System.Drawing.Point(115, 18)
        Me.txtTitleSearch.Name = "txtTitleSearch"
        Me.txtTitleSearch.Size = New System.Drawing.Size(365, 22)
        Me.txtTitleSearch.TabIndex = 0
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(19, 18)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "Title Like"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(490, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(90, 27)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "Search"
        '
        'cmbProductID
        '
        Me.cmbProductID.Location = New System.Drawing.Point(115, 74)
        Me.cmbProductID.Name = "cmbProductID"
        Me.cmbProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_name", "products_name", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProductID.Properties.DataSource = Me.objDS.products_description1
        Me.cmbProductID.Properties.DisplayMember = "products_id"
        Me.cmbProductID.Properties.NullText = ""
        Me.cmbProductID.Properties.PopupWidth = 500
        Me.cmbProductID.Properties.ValueMember = "products_id"
        Me.cmbProductID.Size = New System.Drawing.Size(120, 22)
        Me.cmbProductID.TabIndex = 2
        '
        'objDS
        '
        Me.objDS.DataSetName = "dsProducts"
        Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
        Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(19, 102)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(25, 16)
        Me.LabelControl3.TabIndex = 10
        Me.LabelControl3.Text = "Title"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(19, 129)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl4.TabIndex = 11
        Me.LabelControl4.Text = "Total Qty"
        '
        'txtTotalQty
        '
        Me.txtTotalQty.Location = New System.Drawing.Point(115, 129)
        Me.txtTotalQty.Name = "txtTotalQty"
        Me.txtTotalQty.Properties.ReadOnly = True
        Me.txtTotalQty.Size = New System.Drawing.Size(115, 22)
        Me.txtTotalQty.TabIndex = 4
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(240, 129)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Qty with No Cover"
        '
        'txtQtyNoCover
        '
        Me.txtQtyNoCover.Location = New System.Drawing.Point(365, 129)
        Me.txtQtyNoCover.Name = "txtQtyNoCover"
        Me.txtQtyNoCover.Properties.ReadOnly = True
        Me.txtQtyNoCover.Size = New System.Drawing.Size(115, 22)
        Me.txtQtyNoCover.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(10, 185)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl6.TabIndex = 15
        Me.LabelControl6.Text = "Cover Qty"
        '
        'txtCoverQty
        '
        Me.txtCoverQty.Location = New System.Drawing.Point(115, 185)
        Me.txtCoverQty.Name = "txtCoverQty"
        Me.txtCoverQty.Size = New System.Drawing.Size(115, 22)
        Me.txtCoverQty.TabIndex = 6
        '
        'txtCoverBoxID
        '
        Me.txtCoverBoxID.Location = New System.Drawing.Point(365, 185)
        Me.txtCoverBoxID.Name = "txtCoverBoxID"
        Me.txtCoverBoxID.Size = New System.Drawing.Size(115, 22)
        Me.txtCoverBoxID.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(269, 185)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl7.TabIndex = 18
        Me.LabelControl7.Text = "Cover Box ID"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(490, 185)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(90, 26)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.objDS.products_dvd
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.FormsUseDefaultLookAndFeel = False
        Me.GridControl1.Location = New System.Drawing.Point(659, 35)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbDVDStatus})
        Me.GridControl1.Size = New System.Drawing.Size(381, 299)
        Me.GridControl1.TabIndex = 20
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colproducts_id, Me.colproducts_dvdid, Me.colproducts_dvd_status, Me.colcover_box_id})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'colproducts_id
        '
        Me.colproducts_id.Caption = "products_id"
        Me.colproducts_id.FieldName = "products_id"
        Me.colproducts_id.Name = "colproducts_id"
        Me.colproducts_id.OptionsColumn.ReadOnly = True
        '
        'colproducts_dvdid
        '
        Me.colproducts_dvdid.Caption = "products_dvdid"
        Me.colproducts_dvdid.FieldName = "products_dvdid"
        Me.colproducts_dvdid.Name = "colproducts_dvdid"
        Me.colproducts_dvdid.OptionsColumn.ReadOnly = True
        Me.colproducts_dvdid.Visible = True
        Me.colproducts_dvdid.VisibleIndex = 0
        '
        'colproducts_dvd_status
        '
        Me.colproducts_dvd_status.Caption = "products_dvd_status"
        Me.colproducts_dvd_status.ColumnEdit = Me.cmbDVDStatus
        Me.colproducts_dvd_status.FieldName = "products_dvd_status"
        Me.colproducts_dvd_status.Name = "colproducts_dvd_status"
        Me.colproducts_dvd_status.OptionsColumn.ReadOnly = True
        Me.colproducts_dvd_status.Visible = True
        Me.colproducts_dvd_status.VisibleIndex = 1
        '
        'cmbDVDStatus
        '
        Me.cmbDVDStatus.AutoHeight = False
        Me.cmbDVDStatus.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbDVDStatus.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_id", "products_dvd_status_id", 135, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_dvd_status_name", "products_dvd_status_name", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbDVDStatus.DataSource = Me.objDS.products_dvd_status
        Me.cmbDVDStatus.DisplayMember = "products_dvd_status_name"
        Me.cmbDVDStatus.Name = "cmbDVDStatus"
        Me.cmbDVDStatus.NullText = ""
        Me.cmbDVDStatus.ValueMember = "products_dvd_status_id"
        '
        'colcover_box_id
        '
        Me.colcover_box_id.Caption = "cover_box_id"
        Me.colcover_box_id.FieldName = "cover_box_id"
        Me.colcover_box_id.Name = "colcover_box_id"
        Me.colcover_box_id.Visible = True
        Me.colcover_box_id.VisibleIndex = 2
        '
        'btnSaveGrid
        '
        Me.btnSaveGrid.Location = New System.Drawing.Point(490, 268)
        Me.btnSaveGrid.Name = "btnSaveGrid"
        Me.btnSaveGrid.Size = New System.Drawing.Size(90, 26)
        Me.btnSaveGrid.TabIndex = 21
        Me.btnSaveGrid.Text = "Save Grid"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(10, 65)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "Sales Price"
        '
        'txtSalesPrice
        '
        Me.txtSalesPrice.Location = New System.Drawing.Point(115, 65)
        Me.txtSalesPrice.Name = "txtSalesPrice"
        Me.txtSalesPrice.Size = New System.Drawing.Size(115, 22)
        Me.txtSalesPrice.TabIndex = 23
        '
        'txtQtyToSale
        '
        Me.txtQtyToSale.Location = New System.Drawing.Point(115, 37)
        Me.txtQtyToSale.Name = "txtQtyToSale"
        Me.txtQtyToSale.Size = New System.Drawing.Size(115, 22)
        Me.txtQtyToSale.TabIndex = 22
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(10, 37)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(67, 16)
        Me.LabelControl9.TabIndex = 24
        Me.LabelControl9.Text = "Qty To Sale"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(10, 92)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl10.TabIndex = 26
        Me.LabelControl10.Text = "Sales Price"
        '
        'txtSaleDate
        '
        Me.txtSaleDate.EditValue = Nothing
        Me.txtSaleDate.Enabled = False
        Me.txtSaleDate.Location = New System.Drawing.Point(115, 92)
        Me.txtSaleDate.Name = "txtSaleDate"
        Me.txtSaleDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSaleDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtSaleDate.Size = New System.Drawing.Size(120, 22)
        Me.txtSaleDate.TabIndex = 27
        '
        'btnSaveSaleInfo
        '
        Me.btnSaveSaleInfo.Location = New System.Drawing.Point(269, 37)
        Me.btnSaveSaleInfo.Name = "btnSaveSaleInfo"
        Me.btnSaveSaleInfo.Size = New System.Drawing.Size(105, 26)
        Me.btnSaveSaleInfo.TabIndex = 28
        Me.btnSaveSaleInfo.Text = "Save Sale Info"
        '
        'GroupControl1
        '
        Me.GroupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.txtSaleDate)
        Me.GroupControl1.Controls.Add(Me.btnSaveSaleInfo)
        Me.GroupControl1.Controls.Add(Me.txtQtyToSale)
        Me.GroupControl1.Controls.Add(Me.txtSalesPrice)
        Me.GroupControl1.Location = New System.Drawing.Point(10, 212)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(403, 139)
        Me.GroupControl1.TabIndex = 29
        Me.GroupControl1.Text = "Sale Info"
        '
        'PanelControl1
        '
        Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.txtCoverQty)
        Me.PanelControl1.Controls.Add(Me.btnSearch)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.cmbProductID)
        Me.PanelControl1.Controls.Add(Me.btnSaveGrid)
        Me.PanelControl1.Controls.Add(Me.btnUpdate)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txtTitleSearch)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtCoverBoxID)
        Me.PanelControl1.Controls.Add(Me.txtTitle)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txtTotalQty)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txtQtyNoCover)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 35)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(653, 299)
        Me.PanelControl1.TabIndex = 30
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Location = New System.Drawing.Point(653, 35)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(6, 299)
        Me.SplitterControl1.TabIndex = 31
        Me.SplitterControl1.TabStop = False
        '
        'frmCoverEntry
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(1040, 334)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SplitterControl1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frmCoverEntry"
        Me.Controls.SetChildIndex(Me.PanelControl1, 0)
        Me.Controls.SetChildIndex(Me.SplitterControl1, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        CType(Me.cmbViewListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQuickSearchRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbReportListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbFilterListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDefaultListRepos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTitleSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.objDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyNoCover.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCoverQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCoverBoxID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDVDStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalesPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyToSale.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaleDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSaleDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Dim _SQLTxt As String = "SELECT products_id, products_title, products_model FROM products where products_title like '%" & txtTitleSearch.EditValue & "%' "
        'objDS.Tables("products").Clear()
        ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("products"), _SQLTxt)
        'cmbProductID.Focus()
        'cmbProductID.ShowPopup()
        Dim _SQLTxt As String = "SELECT PD.products_id, PD.language_id, PD.products_name , P.products_model as products_model FROM products_description PD " & _
                                " Left join products P on P.products_id = PD.products_id " & _
                                " where products_name like '%" & txtTitleSearch.EditValue & "%'  "
        objDS.Tables("products_description1").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_description1"), _SQLTxt)
        cmbProductID.Focus()
        cmbProductID.ShowPopup()
    End Sub

    Private Sub cmbProductID_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductID.EditValueChanged
        RefreshDVDInfo()
    End Sub
    Private Sub RefreshDVDInfo()
        Dim _PRow As DataRow
        Dim _SQLTxt As String
        '_row = objDS.Tables("products_description1").Rows.Find(New Object() {cmbProductID.EditValue})

        _SQLTxt = "SELECT products_id, products_title, products_model, products_quantity, quantity_to_sale, " & _
                  " products_sale_price, if (products_sale_date = '0000-00-00', Null, products_sale_date) as products_sale_date " & _
                  " FROM products where products_id = " & cmbProductID.EditValue
        objDS.Tables("products_combo").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_combo"), _SQLTxt)
        If objDS.Tables("products_combo").Rows.Count = 1 Then
            _PRow = objDS.Tables("products_combo").Rows(0)
        Else
            _PRow = Nothing
        End If
        If Not IsNothing(_PRow) Then
            txtTitle.EditValue = _PRow("products_title")
            txtQtyToSale.EditValue = _PRow("quantity_to_sale")
            txtSalesPrice.EditValue = _PRow("products_sale_price")
            'txtSaleDate.EditValue = _PRow("products_sale_date")
            _SQLTxt = "SELECT count(*) from products_dvd where products_id = " & cmbProductID.EditValue
            txtTotalQty.EditValue = BKGlobal.ExecuteCount(_SQLTxt)
            _SQLTxt = "SELECT count(*) from products_dvd where products_id = " & cmbProductID.EditValue & " AND ( cover_box_id = '' or cover_box_id is null)"
            txtQtyNoCover.EditValue = BKGlobal.ExecuteCount(_SQLTxt)
        End If
        _SQLTxt = "SELECT products_id, products_dvdid, products_dvd_status, cover_box_id, `inout`, nbr_rotation_in_feesharing, box_id, pibox_id, last_adminby, " & _
                  " if (dvd_buy_date = '0000-00-00', Null, dvd_buy_date) as dvd_buy_date, " & _
                  " if (date_lastrented = '0000-00-00', Null, date_lastrented) as date_lastrented, " & _
                  " if (last_admindate = '0000-00-00', Null, last_admindate) as last_admindate " & _
                  " FROM products_dvd where products_id = " & cmbProductID.EditValue & _
                  " ORDER BY products_dvd_status, products_dvdid "  ' & " AND ( cover_box_id is null or cover_box_id = '' )"

        objDS.Tables("products_dvd").Clear()
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd"), _SQLTxt)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim _i As Integer
        Dim _row As DataRow
        'Dim _View As DataView = New DataView(objDS.Tables("products_dvd"), "cover_box_id = '' OR Isnull(cover_box_id,'Null Column') = 'Null Column'", _
        '       "products_dvd_status", DataViewRowState.CurrentRows)
        _i = 1
        For Each _row In objDS.Tables("products_dvd").Rows
            If _row("cover_box_id") & "" = "" Then
                _row("cover_box_id") = txtCoverBoxID.EditValue
                _i += 1
            End If
            If _i > CInt(txtCoverQty.EditValue) Then Exit For
        Next
        'Do
        '    If _i > _View.Count Then Exit Do
        '    _row = _View(_i)
        '    '_SQLTxt = "UPDATE products_dvd set cover_box_id = '" & txtCoverBoxID.EditValue & "' WHERE products_id = " & cmbProductID.EditValue & _
        '    '         " AND products_dvdid = " & _row("products_dvdid")
        '    'DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        '    '_row.BeginEdit()
        '    _row("cover_box_id") = txtCoverBoxID.EditValue
        '    '_row.EndEdit()
        '    _i += 1
        '    If _i = CInt(txtCoverQty.EditValue) Then Exit Do
        'Loop
        SaveGrid()
        RefreshDVDInfo()
    End Sub

    Private Sub frmCoverEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load DVD Status List
        Dim _SQLTxt As String = "SELECT * FROM products_dvd_status"
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("products_dvd_status"), _SQLTxt)
    End Sub

    Private Sub btnSaveGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveGrid.Click
        SaveGrid()
    End Sub
    Private Sub SaveGrid()
        Dim _SQLTxt As String
        _SQLTxt = "SELECT products_id, products_dvdid, products_dvd_status, cover_box_id FROM products_dvd where products_id = " & cmbProductID.EditValue & " AND ( cover_box_id is null or cover_box_id = '' )"
        DvdPostData.clsConnection.UpdateDataTableInDB(objDS.Tables("products_dvd"), _SQLTxt)
    End Sub
    Private Sub SaveSaleInfo()
        Dim _SQLTxt As String
        _SQLTxt = "UPDATE Products SET quantity_to_sale = " & txtQtyToSale.EditValue & _
          ", products_sale_price = " & txtSalesPrice.EditValue & _
          " WHERE products_id = " & cmbProductID.EditValue
        DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        If txtQtyToSale.EditValue > 0 Then
            _SQLTxt = "UPDATE Products SET products_sale_date = " & Today & _
                      " WHERE products_id = " & cmbProductID.EditValue
            DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        End If
    End Sub

    Private Sub btnSaveSaleInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSaleInfo.Click
        SaveSaleInfo()
    End Sub
End Class
