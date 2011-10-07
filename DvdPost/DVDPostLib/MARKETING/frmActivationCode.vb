Imports System.IO
Imports System.Collections.Generic
Public Class frmActivationCode
    Inherits BizzLib.frmGeneral_Browse
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
    Friend WithEvents lblYear As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbValidTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQtyToGenerate As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtValidValue As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbNextDiscount As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbValidType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbProductsID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnGenerate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVDCredit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPrefix As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DS As DVDPostLib.dsMarketting
    Friend WithEvents chkWaranty As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAuto_Stop_at_Next_Reconduction As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtBanner As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDescEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescNL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDescFR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkFree_Upgrade_Allowed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtFooter As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCampaign As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblSearch As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtActivationId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSearchName As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupSearch As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtActivationCodeSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFromDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkOnlyUsed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtToDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabResult2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridActivationCode As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewActivationCode As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents activation_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_group As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents campaign_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_group_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_pack As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_code_creation_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_code_validto_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_products_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents validity_month As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents validity_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents validity_value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_waranty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents abo_dvd_credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents next_discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents credit0_auto_reconduct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents abo_auto_stop_next_reconduction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents banner As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_text_fr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_text_nl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents activation_text_en As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents free_upgrade_allowed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents footer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents campaign As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents combined_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCampaignSearch As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCampaign As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEx As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbGroupSearch As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActivationCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmbCombinedAction As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValidityMonth As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents btnSaveBycustomer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomerId As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomersIdSearch As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GrpCustomers As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtValidityToCustomersChange As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtActivationCodeID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCreationDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnNewActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbNextAboType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSaveDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNewDiscount As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXls As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colSize_w As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Grid1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Main_Bar As DevExpress.XtraBars.Bar
    Friend WithEvents btnNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUndo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Misc_Bar As DevExpress.XtraBars.Bar
    Friend WithEvents MainBtns_btnExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MainBtns_btnBigger As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MainBtns_btnSmaller As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MainBtns_btnBestFit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOK As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUser1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUser2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUser3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUser4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUser5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnExportXML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnImportXML As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents View_Bar As DevExpress.XtraBars.Bar
    Friend WithEvents btnView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbViewList As DevExpress.XtraBars.BarEditItem
    Friend WithEvents btnViewDetail As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnEditView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMakeViewCommon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSendViewUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCopyView As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents QuickSearch_Bar As DevExpress.XtraBars.Bar
    Friend WithEvents txtQuickSearch As DevExpress.XtraBars.BarEditItem
    Friend WithEvents btnQuickSearch As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Report_Bar As DevExpress.XtraBars.Bar
    Friend WithEvents btnPrint As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbReportList As DevExpress.XtraBars.BarEditItem
    Friend WithEvents btnReportDetail As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnEditReportInfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDesignReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMakeReportCommon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSendReportUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCopyReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Filter_Bar As DevExpress.XtraBars.Bar
    Friend WithEvents btnFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbFilterList As DevExpress.XtraBars.BarEditItem
    Friend WithEvents btnFilterDetail As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnEditFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMakeFilterCommon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSendFilterUSer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCopyFilter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DefaultSet_Bar As DevExpress.XtraBars.Bar
    Friend WithEvents btnDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmbDefaultList As DevExpress.XtraBars.BarEditItem
    Friend WithEvents btnDefaultDetail As DevExpress.XtraBars.BarSubItem
    Friend WithEvents btnEditDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaveDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMakeDefaultCommon As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSendDefaultUser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCopyDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Misc_Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents btnTranslation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnComments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAttachements As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Nav_Bar As DevExpress.XtraBars.Bar
    Friend WithEvents btnFirst As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrevious As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNext As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLast As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents txtComment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarShortcut1 As DevExpress.XtraBars.BarShortcut

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActivationCode))
        Me.Grid1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
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
        Me.btnViewDetail = New DevExpress.XtraBars.BarSubItem
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
        Me.btnReportDetail = New DevExpress.XtraBars.BarSubItem
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
        Me.btnFilterDetail = New DevExpress.XtraBars.BarSubItem
        Me.btnEditFilter = New DevExpress.XtraBars.BarButtonItem
        Me.btnNewFilter = New DevExpress.XtraBars.BarButtonItem
        Me.btnDeleteFilter = New DevExpress.XtraBars.BarButtonItem
        Me.btnMakeFilterCommon = New DevExpress.XtraBars.BarButtonItem
        Me.btnSendFilterUSer = New DevExpress.XtraBars.BarButtonItem
        Me.btnCopyFilter = New DevExpress.XtraBars.BarButtonItem
        Me.DefaultSet_Bar = New DevExpress.XtraBars.Bar
        Me.btnDefault = New DevExpress.XtraBars.BarButtonItem
        Me.cmbDefaultList = New DevExpress.XtraBars.BarEditItem
        Me.btnDefaultDetail = New DevExpress.XtraBars.BarSubItem
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
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.lblYear = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.txtComment = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.btnGenerate = New DevExpress.XtraEditors.SimpleButton
        Me.cmbGroup = New DevExpress.XtraEditors.LookUpEdit
        Me.DS = New DVDPostLib.dsMarketting
        Me.cmbProductsID = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbValidType = New DevExpress.XtraEditors.LookUpEdit
        Me.cmbNextDiscount = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.txtValidValue = New DevExpress.XtraEditors.SpinEdit
        Me.txtQtyToGenerate = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.cmbValidTo = New DevExpress.XtraEditors.DateEdit
        Me.txtDVDCredit = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.txtPrefix = New DevExpress.XtraEditors.TextEdit
        Me.chkWaranty = New DevExpress.XtraEditors.CheckEdit
        Me.chkAuto_Stop_at_Next_Reconduction = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.txtBanner = New DevExpress.XtraEditors.TextEdit
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.txtDescEN = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescNL = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
        Me.txtDescFR = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
        Me.chkFree_Upgrade_Allowed = New DevExpress.XtraEditors.CheckEdit
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
        Me.txtFooter = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
        Me.txtCampaign = New DevExpress.XtraEditors.TextEdit
        Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
        Me.GroupSearch = New DevExpress.XtraEditors.GroupControl
        Me.btnXls = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewActivation = New DevExpress.XtraEditors.SimpleButton
        Me.btnEx = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
        Me.cmbGroupSearch = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
        Me.txtCustomersIdSearch = New DevExpress.XtraEditors.SpinEdit
        Me.lblCampaign = New DevExpress.XtraEditors.LabelControl
        Me.chkOnlyUsed = New DevExpress.XtraEditors.CheckEdit
        Me.txtFromDate = New DevExpress.XtraEditors.DateEdit
        Me.txtCampaignSearch = New DevExpress.XtraEditors.TextEdit
        Me.txtActivationCodeSearch = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
        Me.lblSearchName = New DevExpress.XtraEditors.LabelControl
        Me.txtToDate = New DevExpress.XtraEditors.DateEdit
        Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
        Me.lblSearch = New DevExpress.XtraEditors.LabelControl
        Me.txtActivationId = New DevExpress.XtraEditors.TextEdit
        Me.tabResult2 = New DevExpress.XtraTab.XtraTabPage
        Me.GridActivationCode = New DevExpress.XtraGrid.GridControl
        Me.GridViewActivationCode = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.activation_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_code = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_group = New DevExpress.XtraGrid.Columns.GridColumn
        Me.campaign_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_group_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_pack = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_code_creation_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_code_validto_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_products_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.validity_month = New DevExpress.XtraGrid.Columns.GridColumn
        Me.validity_type = New DevExpress.XtraGrid.Columns.GridColumn
        Me.validity_value = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_waranty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.customers_id = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.comment = New DevExpress.XtraGrid.Columns.GridColumn
        Me.abo_dvd_credit = New DevExpress.XtraGrid.Columns.GridColumn
        Me.next_discount = New DevExpress.XtraGrid.Columns.GridColumn
        Me.credit0_auto_reconduct = New DevExpress.XtraGrid.Columns.GridColumn
        Me.abo_auto_stop_next_reconduction = New DevExpress.XtraGrid.Columns.GridColumn
        Me.banner = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_text_fr = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_text_nl = New DevExpress.XtraGrid.Columns.GridColumn
        Me.activation_text_en = New DevExpress.XtraGrid.Columns.GridColumn
        Me.free_upgrade_allowed = New DevExpress.XtraGrid.Columns.GridColumn
        Me.footer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.campaign = New DevExpress.XtraGrid.Columns.GridColumn
        Me.combined_action = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSize_w = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
        Me.txtActivationCode = New DevExpress.XtraEditors.TextEdit
        Me.cmbCombinedAction = New DevExpress.XtraEditors.LookUpEdit
        Me.txtValidityMonth = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
        Me.btnSaveBycustomer = New DevExpress.XtraEditors.SimpleButton
        Me.txtCustomerId = New DevExpress.XtraEditors.SpinEdit
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
        Me.GrpCustomers = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
        Me.txtValidityToCustomersChange = New DevExpress.XtraEditors.DateEdit
        Me.txtActivationCodeID = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
        Me.txtCreationDate = New DevExpress.XtraEditors.DateEdit
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
        Me.cmbNextAboType = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.btnSaveDiscount = New DevExpress.XtraEditors.SimpleButton
        Me.btnEditActivation = New DevExpress.XtraEditors.SimpleButton
        Me.btnNewDiscount = New DevExpress.XtraEditors.SimpleButton
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
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductsID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbValidType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextDiscount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidValue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQtyToGenerate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbValidTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbValidTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDVDCredit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrefix.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkWaranty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkAuto_Stop_at_Next_Reconduction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBanner.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txtDescEN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescNL.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDescFR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkFree_Upgrade_Allowed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFooter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCampaign.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSearch.SuspendLayout()
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupSearch.SuspendLayout()
        CType(Me.cmbGroupSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomersIdSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkOnlyUsed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCampaignSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationCodeSearch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabResult2.SuspendLayout()
        CType(Me.GridActivationCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewActivationCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCombinedAction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidityMonth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomerId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrpCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpCustomers.SuspendLayout()
        CType(Me.txtValidityToCustomersChange.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtValidityToCustomersChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtActivationCodeID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCreationDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbNextAboType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        resources.ApplyResources(Me.StatusBar1, "StatusBar1")
        '
        'Panel1
        '
        resources.ApplyResources(Me.Panel1, "Panel1")
        '
        'TabControl1
        '
        Me.TabControl1.LookAndFeel.SkinName = "Lilian"
        Me.TabControl1.SelectedTabPage = Me.TabResult
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabResult2})
        Me.TabControl1.Controls.SetChildIndex(Me.TabChart, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabAnalyse, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabResult, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.tabResult2, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.TabParameters, 0)
        Me.TabControl1.Controls.SetChildIndex(Me.tabSearch, 0)
        '
        'TabParameters
        '
        Me.TabParameters.Controls.Add(Me.btnCancel)
        Me.TabParameters.Controls.Add(Me.btnSaveDiscount)
        Me.TabParameters.Controls.Add(Me.btnEditActivation)
        Me.TabParameters.Controls.Add(Me.btnNewDiscount)
        Me.TabParameters.Controls.Add(Me.cmbNextAboType)
        Me.TabParameters.Controls.Add(Me.LabelControl27)
        Me.TabParameters.Controls.Add(Me.LabelControl26)
        Me.TabParameters.Controls.Add(Me.txtCreationDate)
        Me.TabParameters.Controls.Add(Me.LabelControl25)
        Me.TabParameters.Controls.Add(Me.txtActivationCodeID)
        Me.TabParameters.Controls.Add(Me.GrpCustomers)
        Me.TabParameters.Controls.Add(Me.LabelControl23)
        Me.TabParameters.Controls.Add(Me.cmbValidTo)
        Me.TabParameters.Controls.Add(Me.LabelControl2)
        Me.TabParameters.Controls.Add(Me.LabelControl20)
        Me.TabParameters.Controls.Add(Me.txtValidityMonth)
        Me.TabParameters.Controls.Add(Me.cmbCombinedAction)
        Me.TabParameters.Controls.Add(Me.txtActivationCode)
        Me.TabParameters.Controls.Add(Me.LabelControl19)
        Me.TabParameters.Controls.Add(Me.LabelControl15)
        Me.TabParameters.Controls.Add(Me.txtCampaign)
        Me.TabParameters.Controls.Add(Me.LabelControl14)
        Me.TabParameters.Controls.Add(Me.txtFooter)
        Me.TabParameters.Controls.Add(Me.chkFree_Upgrade_Allowed)
        Me.TabParameters.Controls.Add(Me.GroupControl2)
        Me.TabParameters.Controls.Add(Me.GroupControl1)
        Me.TabParameters.Controls.Add(Me.chkAuto_Stop_at_Next_Reconduction)
        Me.TabParameters.Controls.Add(Me.chkWaranty)
        Me.TabParameters.Controls.Add(Me.txtDVDCredit)
        Me.TabParameters.Controls.Add(Me.LabelControl8)
        Me.TabParameters.Controls.Add(Me.txtValidValue)
        Me.TabParameters.Controls.Add(Me.LabelControl6)
        Me.TabParameters.Controls.Add(Me.cmbNextDiscount)
        Me.TabParameters.Controls.Add(Me.cmbValidType)
        Me.TabParameters.Controls.Add(Me.cmbProductsID)
        Me.TabParameters.Controls.Add(Me.cmbGroup)
        Me.TabParameters.Controls.Add(Me.LabelControl5)
        Me.TabParameters.Controls.Add(Me.LabelControl4)
        Me.TabParameters.Controls.Add(Me.LabelControl1)
        Me.TabParameters.Controls.Add(Me.LabelControl3)
        Me.TabParameters.Controls.Add(Me.txtComment)
        Me.TabParameters.Controls.Add(Me.lblYear)
        resources.ApplyResources(Me.TabParameters, "TabParameters")
        '
        'TabResult
        '
        resources.ApplyResources(Me.TabResult, "TabResult")
        '
        'TabAnalyse
        '
        resources.ApplyResources(Me.TabAnalyse, "TabAnalyse")
        '
        'UcPivotGrid1
        '
        resources.ApplyResources(Me.UcPivotGrid1, "UcPivotGrid1")
        '
        'UcChart1
        '
        resources.ApplyResources(Me.UcChart1, "UcChart1")
        '
        'TabChart
        '
        resources.ApplyResources(Me.TabChart, "TabChart")
        '
        'Grid1
        '
        resources.ApplyResources(Me.Grid1, "Grid1")
        Me.Grid1.EmbeddedNavigator.Name = ""
        Me.Grid1.FormsUseDefaultLookAndFeel = False
        Me.Grid1.MainView = Me.GridView1
        Me.Grid1.Name = "Grid1"
        Me.HelpProvider1.SetShowHelp(Me.Grid1, CType(resources.GetObject("Grid1.ShowHelp"), Boolean))
        Me.Grid1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.Grid1
        Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
        resources.ApplyResources(Me.GridView1, "GridView1")
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowIncrementalSearch = True
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowBands = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'Bar1
        '
        Me.Bar1.BarName = "View_Bar"
        Me.Bar1.DockCol = 2
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.FloatLocation = New System.Drawing.Point(517, 188)
        Me.Bar1.Offset = 279
        resources.ApplyResources(Me.Bar1, "Bar1")
        '
        'BarManager1
        '
        Me.BarManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() {CType(resources.GetObject("BarManager1.Categories"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager1.Categories1"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager1.Categories2"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager1.Categories3"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager1.Categories4"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager1.Categories5"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager1.Categories6"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager1.Categories7"), DevExpress.XtraBars.BarManagerCategory), CType(resources.GetObject("BarManager1.Categories8"), DevExpress.XtraBars.BarManagerCategory)})
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
        resources.ApplyResources(Me.Main_Bar, "Main_Bar")
        Me.Main_Bar.Visible = False
        '
        'btnNew
        '
        resources.ApplyResources(Me.btnNew, "btnNew")
        Me.btnNew.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnNew.Glyph = CType(resources.GetObject("btnNew.Glyph"), System.Drawing.Image)
        Me.btnNew.Id = 0
        Me.btnNew.Name = "btnNew"
        '
        'btnEdit
        '
        resources.ApplyResources(Me.btnEdit, "btnEdit")
        Me.btnEdit.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnEdit.Glyph = CType(resources.GetObject("btnEdit.Glyph"), System.Drawing.Image)
        Me.btnEdit.Id = 2
        Me.btnEdit.Name = "btnEdit"
        '
        'btnDelete
        '
        resources.ApplyResources(Me.btnDelete, "btnDelete")
        Me.btnDelete.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnDelete.Glyph = CType(resources.GetObject("btnDelete.Glyph"), System.Drawing.Image)
        Me.btnDelete.Id = 1
        Me.btnDelete.Name = "btnDelete"
        '
        'btnSave
        '
        resources.ApplyResources(Me.btnSave, "btnSave")
        Me.btnSave.CategoryGuid = New System.Guid("434484d9-7ac5-47e5-9412-313a111b7240")
        Me.btnSave.Glyph = CType(resources.GetObject("btnSave.Glyph"), System.Drawing.Image)
        Me.btnSave.Id = 3
        Me.btnSave.Name = "btnSave"
        '
        'btnUndo
        '
        resources.ApplyResources(Me.btnUndo, "btnUndo")
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
        resources.ApplyResources(Me.Misc_Bar, "Misc_Bar")
        Me.Misc_Bar.Visible = False
        '
        'MainBtns_btnExcel
        '
        resources.ApplyResources(Me.MainBtns_btnExcel, "MainBtns_btnExcel")
        Me.MainBtns_btnExcel.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnExcel.Glyph = CType(resources.GetObject("MainBtns_btnExcel.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnExcel.Id = 5
        Me.MainBtns_btnExcel.Name = "MainBtns_btnExcel"
        '
        'MainBtns_btnBigger
        '
        resources.ApplyResources(Me.MainBtns_btnBigger, "MainBtns_btnBigger")
        Me.MainBtns_btnBigger.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnBigger.Glyph = CType(resources.GetObject("MainBtns_btnBigger.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnBigger.Id = 6
        Me.MainBtns_btnBigger.Name = "MainBtns_btnBigger"
        '
        'MainBtns_btnSmaller
        '
        resources.ApplyResources(Me.MainBtns_btnSmaller, "MainBtns_btnSmaller")
        Me.MainBtns_btnSmaller.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnSmaller.Glyph = CType(resources.GetObject("MainBtns_btnSmaller.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnSmaller.Id = 7
        Me.MainBtns_btnSmaller.Name = "MainBtns_btnSmaller"
        '
        'MainBtns_btnBestFit
        '
        resources.ApplyResources(Me.MainBtns_btnBestFit, "MainBtns_btnBestFit")
        Me.MainBtns_btnBestFit.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.MainBtns_btnBestFit.Glyph = CType(resources.GetObject("MainBtns_btnBestFit.Glyph"), System.Drawing.Image)
        Me.MainBtns_btnBestFit.Id = 8
        Me.MainBtns_btnBestFit.Name = "MainBtns_btnBestFit"
        '
        'btnOK
        '
        Me.btnOK.Id = -1
        Me.btnOK.Name = "btnOK"
        '
        'btnUser1
        '
        Me.btnUser1.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        resources.ApplyResources(Me.btnUser1, "btnUser1")
        Me.btnUser1.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser1.Id = 58
        Me.btnUser1.Name = "btnUser1"
        Me.btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser2
        '
        Me.btnUser2.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        resources.ApplyResources(Me.btnUser2, "btnUser2")
        Me.btnUser2.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser2.Id = 59
        Me.btnUser2.Name = "btnUser2"
        Me.btnUser2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser3
        '
        Me.btnUser3.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        resources.ApplyResources(Me.btnUser3, "btnUser3")
        Me.btnUser3.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser3.Id = 60
        Me.btnUser3.Name = "btnUser3"
        Me.btnUser3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser4
        '
        Me.btnUser4.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        resources.ApplyResources(Me.btnUser4, "btnUser4")
        Me.btnUser4.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser4.Id = 61
        Me.btnUser4.Name = "btnUser4"
        Me.btnUser4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUser5
        '
        Me.btnUser5.Border = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        resources.ApplyResources(Me.btnUser5, "btnUser5")
        Me.btnUser5.CategoryGuid = New System.Guid("a767b561-c256-451a-a199-6ebf84a07265")
        Me.btnUser5.Id = 62
        Me.btnUser5.Name = "btnUser5"
        Me.btnUser5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnExportXML
        '
        Me.btnExportXML.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        resources.ApplyResources(Me.btnExportXML, "btnExportXML")
        Me.btnExportXML.Id = 71
        Me.btnExportXML.Name = "btnExportXML"
        '
        'btnImportXML
        '
        Me.btnImportXML.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        resources.ApplyResources(Me.btnImportXML, "btnImportXML")
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
        resources.ApplyResources(Me.View_Bar, "View_Bar")
        Me.View_Bar.Visible = False
        '
        'btnView
        '
        resources.ApplyResources(Me.btnView, "btnView")
        Me.btnView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnView.Glyph = CType(resources.GetObject("btnView.Glyph"), System.Drawing.Image)
        Me.btnView.Id = 19
        Me.btnView.Name = "btnView"
        '
        'cmbViewList
        '
        resources.ApplyResources(Me.cmbViewList, "cmbViewList")
        Me.cmbViewList.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.cmbViewList.Edit = Me.cmbViewListRepos
        Me.cmbViewList.Id = 21
        Me.cmbViewList.Name = "cmbViewList"
        '
        'btnViewDetail
        '
        resources.ApplyResources(Me.btnViewDetail, "btnViewDetail")
        Me.btnViewDetail.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnViewDetail.Glyph = CType(resources.GetObject("btnViewDetail.Glyph"), System.Drawing.Image)
        Me.btnViewDetail.Id = 11
        Me.btnViewDetail.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditView), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNewView), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDeleteView), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveView), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMakeViewCommon), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSendViewUser), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCopyView)})
        Me.btnViewDetail.Name = "btnViewDetail"
        '
        'btnEditView
        '
        resources.ApplyResources(Me.btnEditView, "btnEditView")
        Me.btnEditView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnEditView.Glyph = CType(resources.GetObject("btnEditView.Glyph"), System.Drawing.Image)
        Me.btnEditView.Id = 13
        Me.btnEditView.Name = "btnEditView"
        '
        'btnNewView
        '
        resources.ApplyResources(Me.btnNewView, "btnNewView")
        Me.btnNewView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnNewView.Glyph = CType(resources.GetObject("btnNewView.Glyph"), System.Drawing.Image)
        Me.btnNewView.Id = 12
        Me.btnNewView.Name = "btnNewView"
        '
        'btnDeleteView
        '
        resources.ApplyResources(Me.btnDeleteView, "btnDeleteView")
        Me.btnDeleteView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnDeleteView.Glyph = CType(resources.GetObject("btnDeleteView.Glyph"), System.Drawing.Image)
        Me.btnDeleteView.Id = 14
        Me.btnDeleteView.Name = "btnDeleteView"
        '
        'btnSaveView
        '
        resources.ApplyResources(Me.btnSaveView, "btnSaveView")
        Me.btnSaveView.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnSaveView.Glyph = CType(resources.GetObject("btnSaveView.Glyph"), System.Drawing.Image)
        Me.btnSaveView.Id = 17
        Me.btnSaveView.Name = "btnSaveView"
        '
        'btnMakeViewCommon
        '
        resources.ApplyResources(Me.btnMakeViewCommon, "btnMakeViewCommon")
        Me.btnMakeViewCommon.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnMakeViewCommon.Glyph = CType(resources.GetObject("btnMakeViewCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeViewCommon.Id = 15
        Me.btnMakeViewCommon.Name = "btnMakeViewCommon"
        '
        'btnSendViewUser
        '
        resources.ApplyResources(Me.btnSendViewUser, "btnSendViewUser")
        Me.btnSendViewUser.CategoryGuid = New System.Guid("af850004-dbd4-452a-ae51-0d3b7833023a")
        Me.btnSendViewUser.Glyph = CType(resources.GetObject("btnSendViewUser.Glyph"), System.Drawing.Image)
        Me.btnSendViewUser.Id = 16
        Me.btnSendViewUser.Name = "btnSendViewUser"
        '
        'btnCopyView
        '
        resources.ApplyResources(Me.btnCopyView, "btnCopyView")
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
        resources.ApplyResources(Me.QuickSearch_Bar, "QuickSearch_Bar")
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
        resources.ApplyResources(Me.btnQuickSearch, "btnQuickSearch")
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
        resources.ApplyResources(Me.Report_Bar, "Report_Bar")
        Me.Report_Bar.Visible = False
        '
        'btnPrint
        '
        resources.ApplyResources(Me.btnPrint, "btnPrint")
        Me.btnPrint.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnPrint.Glyph = CType(resources.GetObject("btnPrint.Glyph"), System.Drawing.Image)
        Me.btnPrint.Id = 24
        Me.btnPrint.Name = "btnPrint"
        '
        'cmbReportList
        '
        resources.ApplyResources(Me.cmbReportList, "cmbReportList")
        Me.cmbReportList.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.cmbReportList.Edit = Me.cmbReportListRepos
        Me.cmbReportList.Id = 26
        Me.cmbReportList.Name = "cmbReportList"
        '
        'btnReportDetail
        '
        resources.ApplyResources(Me.btnReportDetail, "btnReportDetail")
        Me.btnReportDetail.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnReportDetail.Id = 27
        Me.btnReportDetail.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditReportInfo), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNewReport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDeleteReport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDesignReport), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMakeReportCommon), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSendReportUser), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCopyReport)})
        Me.btnReportDetail.Name = "btnReportDetail"
        '
        'btnEditReportInfo
        '
        resources.ApplyResources(Me.btnEditReportInfo, "btnEditReportInfo")
        Me.btnEditReportInfo.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnEditReportInfo.Glyph = CType(resources.GetObject("btnEditReportInfo.Glyph"), System.Drawing.Image)
        Me.btnEditReportInfo.Id = 28
        Me.btnEditReportInfo.Name = "btnEditReportInfo"
        '
        'btnNewReport
        '
        resources.ApplyResources(Me.btnNewReport, "btnNewReport")
        Me.btnNewReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnNewReport.Glyph = CType(resources.GetObject("btnNewReport.Glyph"), System.Drawing.Image)
        Me.btnNewReport.Id = 29
        Me.btnNewReport.Name = "btnNewReport"
        '
        'btnDeleteReport
        '
        resources.ApplyResources(Me.btnDeleteReport, "btnDeleteReport")
        Me.btnDeleteReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnDeleteReport.Glyph = CType(resources.GetObject("btnDeleteReport.Glyph"), System.Drawing.Image)
        Me.btnDeleteReport.Id = 30
        Me.btnDeleteReport.Name = "btnDeleteReport"
        '
        'btnDesignReport
        '
        resources.ApplyResources(Me.btnDesignReport, "btnDesignReport")
        Me.btnDesignReport.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnDesignReport.Glyph = CType(resources.GetObject("btnDesignReport.Glyph"), System.Drawing.Image)
        Me.btnDesignReport.Id = 31
        Me.btnDesignReport.Name = "btnDesignReport"
        '
        'btnMakeReportCommon
        '
        resources.ApplyResources(Me.btnMakeReportCommon, "btnMakeReportCommon")
        Me.btnMakeReportCommon.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnMakeReportCommon.Glyph = CType(resources.GetObject("btnMakeReportCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeReportCommon.Id = 32
        Me.btnMakeReportCommon.Name = "btnMakeReportCommon"
        '
        'btnSendReportUser
        '
        resources.ApplyResources(Me.btnSendReportUser, "btnSendReportUser")
        Me.btnSendReportUser.CategoryGuid = New System.Guid("9db3be29-f7ff-440f-a6cc-0249be6c1df4")
        Me.btnSendReportUser.Glyph = CType(resources.GetObject("btnSendReportUser.Glyph"), System.Drawing.Image)
        Me.btnSendReportUser.Id = 33
        Me.btnSendReportUser.Name = "btnSendReportUser"
        '
        'btnCopyReport
        '
        resources.ApplyResources(Me.btnCopyReport, "btnCopyReport")
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
        resources.ApplyResources(Me.Filter_Bar, "Filter_Bar")
        Me.Filter_Bar.Visible = False
        '
        'btnFilter
        '
        resources.ApplyResources(Me.btnFilter, "btnFilter")
        Me.btnFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnFilter.Glyph = CType(resources.GetObject("btnFilter.Glyph"), System.Drawing.Image)
        Me.btnFilter.Id = 35
        Me.btnFilter.Name = "btnFilter"
        '
        'cmbFilterList
        '
        resources.ApplyResources(Me.cmbFilterList, "cmbFilterList")
        Me.cmbFilterList.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.cmbFilterList.Edit = Me.cmbFilterListRepos
        Me.cmbFilterList.Id = 38
        Me.cmbFilterList.Name = "cmbFilterList"
        '
        'btnFilterDetail
        '
        resources.ApplyResources(Me.btnFilterDetail, "btnFilterDetail")
        Me.btnFilterDetail.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnFilterDetail.Id = 37
        Me.btnFilterDetail.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditFilter), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNewFilter), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDeleteFilter), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMakeFilterCommon), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSendFilterUSer), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCopyFilter)})
        Me.btnFilterDetail.Name = "btnFilterDetail"
        '
        'btnEditFilter
        '
        resources.ApplyResources(Me.btnEditFilter, "btnEditFilter")
        Me.btnEditFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnEditFilter.Glyph = CType(resources.GetObject("btnEditFilter.Glyph"), System.Drawing.Image)
        Me.btnEditFilter.Id = 39
        Me.btnEditFilter.Name = "btnEditFilter"
        '
        'btnNewFilter
        '
        resources.ApplyResources(Me.btnNewFilter, "btnNewFilter")
        Me.btnNewFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnNewFilter.Glyph = CType(resources.GetObject("btnNewFilter.Glyph"), System.Drawing.Image)
        Me.btnNewFilter.Id = 40
        Me.btnNewFilter.Name = "btnNewFilter"
        '
        'btnDeleteFilter
        '
        resources.ApplyResources(Me.btnDeleteFilter, "btnDeleteFilter")
        Me.btnDeleteFilter.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnDeleteFilter.Glyph = CType(resources.GetObject("btnDeleteFilter.Glyph"), System.Drawing.Image)
        Me.btnDeleteFilter.Id = 41
        Me.btnDeleteFilter.Name = "btnDeleteFilter"
        '
        'btnMakeFilterCommon
        '
        resources.ApplyResources(Me.btnMakeFilterCommon, "btnMakeFilterCommon")
        Me.btnMakeFilterCommon.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnMakeFilterCommon.Glyph = CType(resources.GetObject("btnMakeFilterCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeFilterCommon.Id = 43
        Me.btnMakeFilterCommon.Name = "btnMakeFilterCommon"
        '
        'btnSendFilterUSer
        '
        resources.ApplyResources(Me.btnSendFilterUSer, "btnSendFilterUSer")
        Me.btnSendFilterUSer.CategoryGuid = New System.Guid("347bb883-f9ce-44fc-b2c1-d98bab86cea9")
        Me.btnSendFilterUSer.Glyph = CType(resources.GetObject("btnSendFilterUSer.Glyph"), System.Drawing.Image)
        Me.btnSendFilterUSer.Id = 44
        Me.btnSendFilterUSer.Name = "btnSendFilterUSer"
        '
        'btnCopyFilter
        '
        resources.ApplyResources(Me.btnCopyFilter, "btnCopyFilter")
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
        resources.ApplyResources(Me.DefaultSet_Bar, "DefaultSet_Bar")
        Me.DefaultSet_Bar.Visible = False
        '
        'btnDefault
        '
        resources.ApplyResources(Me.btnDefault, "btnDefault")
        Me.btnDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnDefault.Glyph = CType(resources.GetObject("btnDefault.Glyph"), System.Drawing.Image)
        Me.btnDefault.Id = 47
        Me.btnDefault.Name = "btnDefault"
        '
        'cmbDefaultList
        '
        resources.ApplyResources(Me.cmbDefaultList, "cmbDefaultList")
        Me.cmbDefaultList.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.cmbDefaultList.Edit = Me.cmbDefaultListRepos
        Me.cmbDefaultList.Id = 49
        Me.cmbDefaultList.Name = "cmbDefaultList"
        '
        'btnDefaultDetail
        '
        resources.ApplyResources(Me.btnDefaultDetail, "btnDefaultDetail")
        Me.btnDefaultDetail.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnDefaultDetail.Id = 50
        Me.btnDefaultDetail.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnEditDefault), New DevExpress.XtraBars.LinkPersistInfo(Me.btnNewDefault), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDeleteDefault), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaveDefault), New DevExpress.XtraBars.LinkPersistInfo(Me.btnMakeDefaultCommon), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSendDefaultUser), New DevExpress.XtraBars.LinkPersistInfo(Me.btnCopyDefault)})
        Me.btnDefaultDetail.Name = "btnDefaultDetail"
        '
        'btnEditDefault
        '
        resources.ApplyResources(Me.btnEditDefault, "btnEditDefault")
        Me.btnEditDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnEditDefault.Glyph = CType(resources.GetObject("btnEditDefault.Glyph"), System.Drawing.Image)
        Me.btnEditDefault.Id = 51
        Me.btnEditDefault.Name = "btnEditDefault"
        '
        'btnNewDefault
        '
        resources.ApplyResources(Me.btnNewDefault, "btnNewDefault")
        Me.btnNewDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnNewDefault.Glyph = CType(resources.GetObject("btnNewDefault.Glyph"), System.Drawing.Image)
        Me.btnNewDefault.Id = 52
        Me.btnNewDefault.Name = "btnNewDefault"
        '
        'btnDeleteDefault
        '
        resources.ApplyResources(Me.btnDeleteDefault, "btnDeleteDefault")
        Me.btnDeleteDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnDeleteDefault.Glyph = CType(resources.GetObject("btnDeleteDefault.Glyph"), System.Drawing.Image)
        Me.btnDeleteDefault.Id = 53
        Me.btnDeleteDefault.Name = "btnDeleteDefault"
        '
        'btnSaveDefault
        '
        resources.ApplyResources(Me.btnSaveDefault, "btnSaveDefault")
        Me.btnSaveDefault.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnSaveDefault.Glyph = CType(resources.GetObject("btnSaveDefault.Glyph"), System.Drawing.Image)
        Me.btnSaveDefault.Id = 54
        Me.btnSaveDefault.Name = "btnSaveDefault"
        '
        'btnMakeDefaultCommon
        '
        resources.ApplyResources(Me.btnMakeDefaultCommon, "btnMakeDefaultCommon")
        Me.btnMakeDefaultCommon.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnMakeDefaultCommon.Glyph = CType(resources.GetObject("btnMakeDefaultCommon.Glyph"), System.Drawing.Image)
        Me.btnMakeDefaultCommon.Id = 55
        Me.btnMakeDefaultCommon.Name = "btnMakeDefaultCommon"
        '
        'btnSendDefaultUser
        '
        resources.ApplyResources(Me.btnSendDefaultUser, "btnSendDefaultUser")
        Me.btnSendDefaultUser.CategoryGuid = New System.Guid("95aa002d-ba5d-485a-9e35-d9c5d76d68de")
        Me.btnSendDefaultUser.Glyph = CType(resources.GetObject("btnSendDefaultUser.Glyph"), System.Drawing.Image)
        Me.btnSendDefaultUser.Id = 56
        Me.btnSendDefaultUser.Name = "btnSendDefaultUser"
        '
        'btnCopyDefault
        '
        resources.ApplyResources(Me.btnCopyDefault, "btnCopyDefault")
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
        resources.ApplyResources(Me.Misc_Bar2, "Misc_Bar2")
        Me.Misc_Bar2.Visible = False
        '
        'btnTranslation
        '
        resources.ApplyResources(Me.btnTranslation, "btnTranslation")
        Me.btnTranslation.CategoryGuid = New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
        Me.btnTranslation.Glyph = CType(resources.GetObject("btnTranslation.Glyph"), System.Drawing.Image)
        Me.btnTranslation.Id = 63
        Me.btnTranslation.Name = "btnTranslation"
        '
        'btnComments
        '
        resources.ApplyResources(Me.btnComments, "btnComments")
        Me.btnComments.CategoryGuid = New System.Guid("d45f4b42-7c78-4255-9839-0f9b81be7603")
        Me.btnComments.Glyph = CType(resources.GetObject("btnComments.Glyph"), System.Drawing.Image)
        Me.btnComments.Id = 64
        Me.btnComments.Name = "btnComments"
        '
        'btnAttachements
        '
        resources.ApplyResources(Me.btnAttachements, "btnAttachements")
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
        resources.ApplyResources(Me.Nav_Bar, "Nav_Bar")
        Me.Nav_Bar.Visible = False
        '
        'btnFirst
        '
        resources.ApplyResources(Me.btnFirst, "btnFirst")
        Me.btnFirst.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnFirst.Glyph = CType(resources.GetObject("btnFirst.Glyph"), System.Drawing.Image)
        Me.btnFirst.Id = 66
        Me.btnFirst.Name = "btnFirst"
        '
        'btnPrevious
        '
        resources.ApplyResources(Me.btnPrevious, "btnPrevious")
        Me.btnPrevious.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnPrevious.Glyph = CType(resources.GetObject("btnPrevious.Glyph"), System.Drawing.Image)
        Me.btnPrevious.Id = 67
        Me.btnPrevious.Name = "btnPrevious"
        '
        'btnNext
        '
        resources.ApplyResources(Me.btnNext, "btnNext")
        Me.btnNext.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnNext.Glyph = CType(resources.GetObject("btnNext.Glyph"), System.Drawing.Image)
        Me.btnNext.Id = 68
        Me.btnNext.Name = "btnNext"
        '
        'btnLast
        '
        resources.ApplyResources(Me.btnLast, "btnLast")
        Me.btnLast.CategoryGuid = New System.Guid("d55c49d9-25b9-4030-98b4-b0b1e7d65b90")
        Me.btnLast.Glyph = CType(resources.GetObject("btnLast.Glyph"), System.Drawing.Image)
        Me.btnLast.Id = 69
        Me.btnLast.Name = "btnLast"
        '
        'lblYear
        '
        resources.ApplyResources(Me.lblYear, "lblYear")
        Me.lblYear.Name = "lblYear"
        Me.HelpProvider1.SetShowHelp(Me.lblYear, CType(resources.GetObject("lblYear.ShowHelp"), Boolean))
        '
        'LabelControl2
        '
        resources.ApplyResources(Me.LabelControl2, "LabelControl2")
        Me.LabelControl2.Name = "LabelControl2"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl2, CType(resources.GetObject("LabelControl2.ShowHelp"), Boolean))
        '
        'LabelControl3
        '
        resources.ApplyResources(Me.LabelControl3, "LabelControl3")
        Me.LabelControl3.Name = "LabelControl3"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl3, CType(resources.GetObject("LabelControl3.ShowHelp"), Boolean))
        '
        'txtComment
        '
        resources.ApplyResources(Me.txtComment, "txtComment")
        Me.txtComment.Name = "txtComment"
        Me.HelpProvider1.SetShowHelp(Me.txtComment, CType(resources.GetObject("txtComment.ShowHelp"), Boolean))
        '
        'LabelControl1
        '
        resources.ApplyResources(Me.LabelControl1, "LabelControl1")
        Me.LabelControl1.Name = "LabelControl1"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl1, CType(resources.GetObject("LabelControl1.ShowHelp"), Boolean))
        '
        'LabelControl4
        '
        resources.ApplyResources(Me.LabelControl4, "LabelControl4")
        Me.LabelControl4.Name = "LabelControl4"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl4, CType(resources.GetObject("LabelControl4.ShowHelp"), Boolean))
        '
        'LabelControl5
        '
        resources.ApplyResources(Me.LabelControl5, "LabelControl5")
        Me.LabelControl5.Name = "LabelControl5"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl5, CType(resources.GetObject("LabelControl5.ShowHelp"), Boolean))
        '
        'btnGenerate
        '
        resources.ApplyResources(Me.btnGenerate, "btnGenerate")
        Me.btnGenerate.Name = "btnGenerate"
        '
        'cmbGroup
        '
        resources.ApplyResources(Me.cmbGroup, "cmbGroup")
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbGroup.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbGroup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbGroup.Properties.DisplayMember = "DisplayMember"
        Me.cmbGroup.Properties.NullText = resources.GetString("cmbGroup.Properties.NullText")
        Me.cmbGroup.Properties.ValueMember = "Value"
        '
        'DS
        '
        Me.DS.DataSetName = "dsMarketting"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbProductsID
        '
        resources.ApplyResources(Me.cmbProductsID, "cmbProductsID")
        Me.cmbProductsID.Name = "cmbProductsID"
        Me.cmbProductsID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbProductsID.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbProductsID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 75, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbProductsID.Properties.DisplayMember = "DisplayMember"
        Me.cmbProductsID.Properties.NullText = resources.GetString("cmbProductsID.Properties.NullText")
        Me.cmbProductsID.Properties.PopupWidth = 500
        Me.cmbProductsID.Properties.ValueMember = "Value"
        Me.HelpProvider1.SetShowHelp(Me.cmbProductsID, CType(resources.GetObject("cmbProductsID.ShowHelp"), Boolean))
        '
        'cmbValidType
        '
        resources.ApplyResources(Me.cmbValidType, "cmbValidType")
        Me.cmbValidType.Name = "cmbValidType"
        Me.cmbValidType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbValidType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbValidType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbValidType.Properties.DisplayMember = "DisplayMember"
        Me.cmbValidType.Properties.NullText = resources.GetString("cmbValidType.Properties.NullText")
        Me.cmbValidType.Properties.ValueMember = "Value"
        Me.HelpProvider1.SetShowHelp(Me.cmbValidType, CType(resources.GetObject("cmbValidType.ShowHelp"), Boolean))
        '
        'cmbNextDiscount
        '
        resources.ApplyResources(Me.cmbNextDiscount, "cmbNextDiscount")
        Me.cmbNextDiscount.Name = "cmbNextDiscount"
        Me.cmbNextDiscount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbNextDiscount.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbNextDiscount.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 50)})
        Me.cmbNextDiscount.Properties.DisplayMember = "DisplayMember"
        Me.cmbNextDiscount.Properties.NullText = resources.GetString("cmbNextDiscount.Properties.NullText")
        Me.cmbNextDiscount.Properties.PopupWidth = 500
        Me.cmbNextDiscount.Properties.ValueMember = "Value"
        Me.HelpProvider1.SetShowHelp(Me.cmbNextDiscount, CType(resources.GetObject("cmbNextDiscount.ShowHelp"), Boolean))
        '
        'LabelControl6
        '
        resources.ApplyResources(Me.LabelControl6, "LabelControl6")
        Me.LabelControl6.Name = "LabelControl6"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl6, CType(resources.GetObject("LabelControl6.ShowHelp"), Boolean))
        '
        'txtValidValue
        '
        resources.ApplyResources(Me.txtValidValue, "txtValidValue")
        Me.txtValidValue.Name = "txtValidValue"
        Me.txtValidValue.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtValidValue.Properties.MaxLength = 1000000
        Me.txtValidValue.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        '
        'txtQtyToGenerate
        '
        resources.ApplyResources(Me.txtQtyToGenerate, "txtQtyToGenerate")
        Me.txtQtyToGenerate.Name = "txtQtyToGenerate"
        Me.txtQtyToGenerate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtQtyToGenerate.Properties.MaxLength = 1000000
        Me.txtQtyToGenerate.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtQtyToGenerate, CType(resources.GetObject("txtQtyToGenerate.ShowHelp"), Boolean))
        '
        'LabelControl7
        '
        resources.ApplyResources(Me.LabelControl7, "LabelControl7")
        Me.LabelControl7.Name = "LabelControl7"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl7, CType(resources.GetObject("LabelControl7.ShowHelp"), Boolean))
        '
        'cmbValidTo
        '
        Me.cmbValidTo.EditValue = Nothing
        resources.ApplyResources(Me.cmbValidTo, "cmbValidTo")
        Me.cmbValidTo.Name = "cmbValidTo"
        Me.cmbValidTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbValidTo.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbValidTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'txtDVDCredit
        '
        resources.ApplyResources(Me.txtDVDCredit, "txtDVDCredit")
        Me.txtDVDCredit.Name = "txtDVDCredit"
        Me.txtDVDCredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtDVDCredit.Properties.MaxLength = 1000000
        Me.txtDVDCredit.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtDVDCredit, CType(resources.GetObject("txtDVDCredit.ShowHelp"), Boolean))
        '
        'LabelControl8
        '
        resources.ApplyResources(Me.LabelControl8, "LabelControl8")
        Me.LabelControl8.Name = "LabelControl8"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl8, CType(resources.GetObject("LabelControl8.ShowHelp"), Boolean))
        '
        'LabelControl9
        '
        resources.ApplyResources(Me.LabelControl9, "LabelControl9")
        Me.LabelControl9.Name = "LabelControl9"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl9, CType(resources.GetObject("LabelControl9.ShowHelp"), Boolean))
        '
        'txtPrefix
        '
        resources.ApplyResources(Me.txtPrefix, "txtPrefix")
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Properties.MaxLength = 5
        Me.HelpProvider1.SetShowHelp(Me.txtPrefix, CType(resources.GetObject("txtPrefix.ShowHelp"), Boolean))
        '
        'chkWaranty
        '
        resources.ApplyResources(Me.chkWaranty, "chkWaranty")
        Me.chkWaranty.Name = "chkWaranty"
        Me.chkWaranty.Properties.Caption = resources.GetString("chkWaranty.Properties.Caption")
        Me.chkWaranty.Properties.ValueChecked = 1
        Me.chkWaranty.Properties.ValueUnchecked = 0
        '
        'chkAuto_Stop_at_Next_Reconduction
        '
        resources.ApplyResources(Me.chkAuto_Stop_at_Next_Reconduction, "chkAuto_Stop_at_Next_Reconduction")
        Me.chkAuto_Stop_at_Next_Reconduction.Name = "chkAuto_Stop_at_Next_Reconduction"
        Me.chkAuto_Stop_at_Next_Reconduction.Properties.Caption = resources.GetString("chkAuto_Stop_at_Next_Reconduction.Properties.Caption")
        Me.chkAuto_Stop_at_Next_Reconduction.Properties.ValueChecked = 1
        Me.chkAuto_Stop_at_Next_Reconduction.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.chkAuto_Stop_at_Next_Reconduction, CType(resources.GetObject("chkAuto_Stop_at_Next_Reconduction.ShowHelp"), Boolean))
        '
        'LabelControl10
        '
        resources.ApplyResources(Me.LabelControl10, "LabelControl10")
        Me.LabelControl10.Name = "LabelControl10"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl10, CType(resources.GetObject("LabelControl10.ShowHelp"), Boolean))
        '
        'txtBanner
        '
        resources.ApplyResources(Me.txtBanner, "txtBanner")
        Me.txtBanner.Name = "txtBanner"
        Me.HelpProvider1.SetShowHelp(Me.txtBanner, CType(resources.GetObject("txtBanner.ShowHelp"), Boolean))
        '
        'GroupControl1
        '
        resources.ApplyResources(Me.GroupControl1, "GroupControl1")
        Me.GroupControl1.Controls.Add(Me.txtQtyToGenerate)
        Me.GroupControl1.Controls.Add(Me.btnGenerate)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.txtPrefix)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Name = "GroupControl1"
        '
        'GroupControl2
        '
        resources.ApplyResources(Me.GroupControl2, "GroupControl2")
        Me.GroupControl2.Controls.Add(Me.txtDescEN)
        Me.GroupControl2.Controls.Add(Me.LabelControl13)
        Me.GroupControl2.Controls.Add(Me.txtDescNL)
        Me.GroupControl2.Controls.Add(Me.LabelControl12)
        Me.GroupControl2.Controls.Add(Me.txtDescFR)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.txtBanner)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Name = "GroupControl2"
        '
        'txtDescEN
        '
        resources.ApplyResources(Me.txtDescEN, "txtDescEN")
        Me.txtDescEN.Name = "txtDescEN"
        Me.HelpProvider1.SetShowHelp(Me.txtDescEN, CType(resources.GetObject("txtDescEN.ShowHelp"), Boolean))
        '
        'LabelControl13
        '
        resources.ApplyResources(Me.LabelControl13, "LabelControl13")
        Me.LabelControl13.Name = "LabelControl13"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl13, CType(resources.GetObject("LabelControl13.ShowHelp"), Boolean))
        '
        'txtDescNL
        '
        resources.ApplyResources(Me.txtDescNL, "txtDescNL")
        Me.txtDescNL.Name = "txtDescNL"
        Me.HelpProvider1.SetShowHelp(Me.txtDescNL, CType(resources.GetObject("txtDescNL.ShowHelp"), Boolean))
        '
        'LabelControl12
        '
        resources.ApplyResources(Me.LabelControl12, "LabelControl12")
        Me.LabelControl12.Name = "LabelControl12"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl12, CType(resources.GetObject("LabelControl12.ShowHelp"), Boolean))
        '
        'txtDescFR
        '
        resources.ApplyResources(Me.txtDescFR, "txtDescFR")
        Me.txtDescFR.Name = "txtDescFR"
        Me.HelpProvider1.SetShowHelp(Me.txtDescFR, CType(resources.GetObject("txtDescFR.ShowHelp"), Boolean))
        '
        'LabelControl11
        '
        resources.ApplyResources(Me.LabelControl11, "LabelControl11")
        Me.LabelControl11.Name = "LabelControl11"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl11, CType(resources.GetObject("LabelControl11.ShowHelp"), Boolean))
        '
        'chkFree_Upgrade_Allowed
        '
        resources.ApplyResources(Me.chkFree_Upgrade_Allowed, "chkFree_Upgrade_Allowed")
        Me.chkFree_Upgrade_Allowed.Name = "chkFree_Upgrade_Allowed"
        Me.chkFree_Upgrade_Allowed.Properties.Caption = resources.GetString("chkFree_Upgrade_Allowed.Properties.Caption")
        Me.chkFree_Upgrade_Allowed.Properties.ValueChecked = 1
        Me.chkFree_Upgrade_Allowed.Properties.ValueUnchecked = 0
        Me.HelpProvider1.SetShowHelp(Me.chkFree_Upgrade_Allowed, CType(resources.GetObject("chkFree_Upgrade_Allowed.ShowHelp"), Boolean))
        '
        'LabelControl14
        '
        resources.ApplyResources(Me.LabelControl14, "LabelControl14")
        Me.LabelControl14.Name = "LabelControl14"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl14, CType(resources.GetObject("LabelControl14.ShowHelp"), Boolean))
        '
        'txtFooter
        '
        resources.ApplyResources(Me.txtFooter, "txtFooter")
        Me.txtFooter.Name = "txtFooter"
        Me.HelpProvider1.SetShowHelp(Me.txtFooter, CType(resources.GetObject("txtFooter.ShowHelp"), Boolean))
        '
        'LabelControl15
        '
        resources.ApplyResources(Me.LabelControl15, "LabelControl15")
        Me.LabelControl15.Name = "LabelControl15"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl15, CType(resources.GetObject("LabelControl15.ShowHelp"), Boolean))
        '
        'txtCampaign
        '
        resources.ApplyResources(Me.txtCampaign, "txtCampaign")
        Me.txtCampaign.Name = "txtCampaign"
        Me.HelpProvider1.SetShowHelp(Me.txtCampaign, CType(resources.GetObject("txtCampaign.ShowHelp"), Boolean))
        '
        'tabSearch
        '
        Me.tabSearch.Controls.Add(Me.GroupSearch)
        Me.tabSearch.Name = "tabSearch"
        resources.ApplyResources(Me.tabSearch, "tabSearch")
        '
        'GroupSearch
        '
        resources.ApplyResources(Me.GroupSearch, "GroupSearch")
        Me.GroupSearch.Controls.Add(Me.btnXls)
        Me.GroupSearch.Controls.Add(Me.btnNewActivation)
        Me.GroupSearch.Controls.Add(Me.btnEx)
        Me.GroupSearch.Controls.Add(Me.LabelControl22)
        Me.GroupSearch.Controls.Add(Me.cmbGroupSearch)
        Me.GroupSearch.Controls.Add(Me.LabelControl18)
        Me.GroupSearch.Controls.Add(Me.txtCustomersIdSearch)
        Me.GroupSearch.Controls.Add(Me.lblCampaign)
        Me.GroupSearch.Controls.Add(Me.chkOnlyUsed)
        Me.GroupSearch.Controls.Add(Me.txtFromDate)
        Me.GroupSearch.Controls.Add(Me.txtCampaignSearch)
        Me.GroupSearch.Controls.Add(Me.txtActivationCodeSearch)
        Me.GroupSearch.Controls.Add(Me.LabelControl16)
        Me.GroupSearch.Controls.Add(Me.lblSearchName)
        Me.GroupSearch.Controls.Add(Me.txtToDate)
        Me.GroupSearch.Controls.Add(Me.btnSearch)
        Me.GroupSearch.Controls.Add(Me.LabelControl17)
        Me.GroupSearch.Controls.Add(Me.lblSearch)
        Me.GroupSearch.Controls.Add(Me.txtActivationId)
        Me.GroupSearch.Name = "GroupSearch"
        Me.HelpProvider1.SetShowHelp(Me.GroupSearch, CType(resources.GetObject("GroupSearch.ShowHelp"), Boolean))
        '
        'btnXls
        '
        Me.btnXls.Image = CType(resources.GetObject("btnXls.Image"), System.Drawing.Image)
        resources.ApplyResources(Me.btnXls, "btnXls")
        Me.btnXls.Name = "btnXls"
        Me.HelpProvider1.SetShowHelp(Me.btnXls, CType(resources.GetObject("btnXls.ShowHelp"), Boolean))
        '
        'btnNewActivation
        '
        resources.ApplyResources(Me.btnNewActivation, "btnNewActivation")
        Me.btnNewActivation.Name = "btnNewActivation"
        Me.HelpProvider1.SetShowHelp(Me.btnNewActivation, CType(resources.GetObject("btnNewActivation.ShowHelp"), Boolean))
        '
        'btnEx
        '
        resources.ApplyResources(Me.btnEx, "btnEx")
        Me.btnEx.Name = "btnEx"
        Me.HelpProvider1.SetShowHelp(Me.btnEx, CType(resources.GetObject("btnEx.ShowHelp"), Boolean))
        '
        'LabelControl22
        '
        resources.ApplyResources(Me.LabelControl22, "LabelControl22")
        Me.LabelControl22.Name = "LabelControl22"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl22, CType(resources.GetObject("LabelControl22.ShowHelp"), Boolean))
        '
        'cmbGroupSearch
        '
        resources.ApplyResources(Me.cmbGroupSearch, "cmbGroupSearch")
        Me.cmbGroupSearch.Name = "cmbGroupSearch"
        Me.cmbGroupSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbGroupSearch.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbGroupSearch.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbGroupSearch.Properties.DisplayMember = "DisplayMember"
        Me.cmbGroupSearch.Properties.NullText = resources.GetString("cmbGroupSearch.Properties.NullText")
        Me.cmbGroupSearch.Properties.ValueMember = "Value"
        Me.HelpProvider1.SetShowHelp(Me.cmbGroupSearch, CType(resources.GetObject("cmbGroupSearch.ShowHelp"), Boolean))
        '
        'LabelControl18
        '
        resources.ApplyResources(Me.LabelControl18, "LabelControl18")
        Me.LabelControl18.Name = "LabelControl18"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl18, CType(resources.GetObject("LabelControl18.ShowHelp"), Boolean))
        '
        'txtCustomersIdSearch
        '
        resources.ApplyResources(Me.txtCustomersIdSearch, "txtCustomersIdSearch")
        Me.txtCustomersIdSearch.Name = "txtCustomersIdSearch"
        Me.txtCustomersIdSearch.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCustomersIdSearch.Properties.MaxLength = 1000000
        Me.txtCustomersIdSearch.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtCustomersIdSearch, CType(resources.GetObject("txtCustomersIdSearch.ShowHelp"), Boolean))
        '
        'lblCampaign
        '
        resources.ApplyResources(Me.lblCampaign, "lblCampaign")
        Me.lblCampaign.Name = "lblCampaign"
        Me.HelpProvider1.SetShowHelp(Me.lblCampaign, CType(resources.GetObject("lblCampaign.ShowHelp"), Boolean))
        '
        'chkOnlyUsed
        '
        resources.ApplyResources(Me.chkOnlyUsed, "chkOnlyUsed")
        Me.chkOnlyUsed.Name = "chkOnlyUsed"
        Me.chkOnlyUsed.Properties.Caption = resources.GetString("chkOnlyUsed.Properties.Caption")
        Me.chkOnlyUsed.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HelpProvider1.SetShowHelp(Me.chkOnlyUsed, CType(resources.GetObject("chkOnlyUsed.ShowHelp"), Boolean))
        '
        'txtFromDate
        '
        Me.txtFromDate.EditValue = Nothing
        resources.ApplyResources(Me.txtFromDate, "txtFromDate")
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtFromDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtFromDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtFromDate, CType(resources.GetObject("txtFromDate.ShowHelp"), Boolean))
        '
        'txtCampaignSearch
        '
        resources.ApplyResources(Me.txtCampaignSearch, "txtCampaignSearch")
        Me.txtCampaignSearch.Name = "txtCampaignSearch"
        Me.HelpProvider1.SetShowHelp(Me.txtCampaignSearch, CType(resources.GetObject("txtCampaignSearch.ShowHelp"), Boolean))
        '
        'txtActivationCodeSearch
        '
        resources.ApplyResources(Me.txtActivationCodeSearch, "txtActivationCodeSearch")
        Me.txtActivationCodeSearch.Name = "txtActivationCodeSearch"
        Me.HelpProvider1.SetShowHelp(Me.txtActivationCodeSearch, CType(resources.GetObject("txtActivationCodeSearch.ShowHelp"), Boolean))
        '
        'LabelControl16
        '
        resources.ApplyResources(Me.LabelControl16, "LabelControl16")
        Me.LabelControl16.Name = "LabelControl16"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl16, CType(resources.GetObject("LabelControl16.ShowHelp"), Boolean))
        '
        'lblSearchName
        '
        resources.ApplyResources(Me.lblSearchName, "lblSearchName")
        Me.lblSearchName.Name = "lblSearchName"
        Me.HelpProvider1.SetShowHelp(Me.lblSearchName, CType(resources.GetObject("lblSearchName.ShowHelp"), Boolean))
        '
        'txtToDate
        '
        Me.txtToDate.EditValue = Nothing
        resources.ApplyResources(Me.txtToDate, "txtToDate")
        Me.txtToDate.Name = "txtToDate"
        Me.txtToDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtToDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtToDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtToDate, CType(resources.GetObject("txtToDate.ShowHelp"), Boolean))
        '
        'btnSearch
        '
        resources.ApplyResources(Me.btnSearch, "btnSearch")
        Me.btnSearch.Name = "btnSearch"
        Me.HelpProvider1.SetShowHelp(Me.btnSearch, CType(resources.GetObject("btnSearch.ShowHelp"), Boolean))
        '
        'LabelControl17
        '
        resources.ApplyResources(Me.LabelControl17, "LabelControl17")
        Me.LabelControl17.Name = "LabelControl17"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl17, CType(resources.GetObject("LabelControl17.ShowHelp"), Boolean))
        '
        'lblSearch
        '
        resources.ApplyResources(Me.lblSearch, "lblSearch")
        Me.lblSearch.Name = "lblSearch"
        Me.HelpProvider1.SetShowHelp(Me.lblSearch, CType(resources.GetObject("lblSearch.ShowHelp"), Boolean))
        '
        'txtActivationId
        '
        resources.ApplyResources(Me.txtActivationId, "txtActivationId")
        Me.txtActivationId.Name = "txtActivationId"
        Me.HelpProvider1.SetShowHelp(Me.txtActivationId, CType(resources.GetObject("txtActivationId.ShowHelp"), Boolean))
        '
        'tabResult2
        '
        Me.tabResult2.Controls.Add(Me.GridActivationCode)
        Me.tabResult2.Name = "tabResult2"
        resources.ApplyResources(Me.tabResult2, "tabResult2")
        '
        'GridActivationCode
        '
        resources.ApplyResources(Me.GridActivationCode, "GridActivationCode")
        Me.GridActivationCode.EmbeddedNavigator.Name = ""
        Me.GridActivationCode.FormsUseDefaultLookAndFeel = False
        Me.GridActivationCode.MainView = Me.GridViewActivationCode
        Me.GridActivationCode.Name = "GridActivationCode"
        Me.GridActivationCode.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewActivationCode})
        '
        'GridViewActivationCode
        '
        Me.GridViewActivationCode.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.activation_id, Me.activation_code, Me.activation_group, Me.campaign_id, Me.activation_group_id, Me.activation_pack, Me.activation_code_creation_date, Me.activation_code_validto_date, Me.activation_products_id, Me.validity_month, Me.validity_type, Me.validity_value, Me.activation_waranty, Me.customers_id, Me.activation_date, Me.comment, Me.abo_dvd_credit, Me.next_discount, Me.credit0_auto_reconduct, Me.abo_auto_stop_next_reconduction, Me.banner, Me.activation_text_fr, Me.activation_text_nl, Me.activation_text_en, Me.free_upgrade_allowed, Me.footer, Me.campaign, Me.combined_action, Me.colSize_w})
        Me.GridViewActivationCode.GridControl = Me.GridActivationCode
        Me.GridViewActivationCode.Name = "GridViewActivationCode"
        Me.GridViewActivationCode.OptionsView.ShowFooter = True
        '
        'activation_id
        '
        resources.ApplyResources(Me.activation_id, "activation_id")
        Me.activation_id.FieldName = "activation_id"
        Me.activation_id.Name = "activation_id"
        Me.activation_id.OptionsColumn.ReadOnly = True
        '
        'activation_code
        '
        resources.ApplyResources(Me.activation_code, "activation_code")
        Me.activation_code.FieldName = "activation_code"
        Me.activation_code.Name = "activation_code"
        Me.activation_code.OptionsColumn.ReadOnly = True
        '
        'activation_group
        '
        resources.ApplyResources(Me.activation_group, "activation_group")
        Me.activation_group.FieldName = "activation_group"
        Me.activation_group.Name = "activation_group"
        '
        'campaign_id
        '
        resources.ApplyResources(Me.campaign_id, "campaign_id")
        Me.campaign_id.FieldName = "campaign_id"
        Me.campaign_id.Name = "campaign_id"
        '
        'activation_group_id
        '
        resources.ApplyResources(Me.activation_group_id, "activation_group_id")
        Me.activation_group_id.FieldName = "activation_group_id"
        Me.activation_group_id.Name = "activation_group_id"
        '
        'activation_pack
        '
        resources.ApplyResources(Me.activation_pack, "activation_pack")
        Me.activation_pack.FieldName = "activation_pack"
        Me.activation_pack.Name = "activation_pack"
        '
        'activation_code_creation_date
        '
        resources.ApplyResources(Me.activation_code_creation_date, "activation_code_creation_date")
        Me.activation_code_creation_date.FieldName = "activation_code_creation_date"
        Me.activation_code_creation_date.Name = "activation_code_creation_date"
        Me.activation_code_creation_date.OptionsColumn.ReadOnly = True
        '
        'activation_code_validto_date
        '
        resources.ApplyResources(Me.activation_code_validto_date, "activation_code_validto_date")
        Me.activation_code_validto_date.FieldName = "activation_code_validto_date"
        Me.activation_code_validto_date.Name = "activation_code_validto_date"
        Me.activation_code_validto_date.OptionsColumn.ReadOnly = True
        '
        'activation_products_id
        '
        resources.ApplyResources(Me.activation_products_id, "activation_products_id")
        Me.activation_products_id.FieldName = "activation_products_id"
        Me.activation_products_id.Name = "activation_products_id"
        Me.activation_products_id.OptionsColumn.ReadOnly = True
        '
        'validity_month
        '
        resources.ApplyResources(Me.validity_month, "validity_month")
        Me.validity_month.FieldName = "validity_month"
        Me.validity_month.Name = "validity_month"
        Me.validity_month.OptionsColumn.ReadOnly = True
        '
        'validity_type
        '
        resources.ApplyResources(Me.validity_type, "validity_type")
        Me.validity_type.FieldName = "validity_type"
        Me.validity_type.Name = "validity_type"
        Me.validity_type.OptionsColumn.ReadOnly = True
        '
        'validity_value
        '
        resources.ApplyResources(Me.validity_value, "validity_value")
        Me.validity_value.FieldName = "validity_value"
        Me.validity_value.Name = "validity_value"
        Me.validity_value.OptionsColumn.ReadOnly = True
        '
        'activation_waranty
        '
        resources.ApplyResources(Me.activation_waranty, "activation_waranty")
        Me.activation_waranty.FieldName = "activation_waranty"
        Me.activation_waranty.Name = "activation_waranty"
        '
        'customers_id
        '
        resources.ApplyResources(Me.customers_id, "customers_id")
        Me.customers_id.FieldName = "customers_id"
        Me.customers_id.Name = "customers_id"
        Me.customers_id.OptionsColumn.ReadOnly = True
        '
        'activation_date
        '
        resources.ApplyResources(Me.activation_date, "activation_date")
        Me.activation_date.DisplayFormat.FormatString = "d"
        Me.activation_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.activation_date.FieldName = "activation_date"
        Me.activation_date.Name = "activation_date"
        Me.activation_date.OptionsColumn.ReadOnly = True
        '
        'comment
        '
        resources.ApplyResources(Me.comment, "comment")
        Me.comment.FieldName = "comment"
        Me.comment.Name = "comment"
        Me.comment.OptionsColumn.ReadOnly = True
        '
        'abo_dvd_credit
        '
        resources.ApplyResources(Me.abo_dvd_credit, "abo_dvd_credit")
        Me.abo_dvd_credit.FieldName = "abo_dvd_credit"
        Me.abo_dvd_credit.Name = "abo_dvd_credit"
        Me.abo_dvd_credit.OptionsColumn.ReadOnly = True
        '
        'next_discount
        '
        resources.ApplyResources(Me.next_discount, "next_discount")
        Me.next_discount.FieldName = "next_discount"
        Me.next_discount.Name = "next_discount"
        Me.next_discount.OptionsColumn.ReadOnly = True
        '
        'credit0_auto_reconduct
        '
        resources.ApplyResources(Me.credit0_auto_reconduct, "credit0_auto_reconduct")
        Me.credit0_auto_reconduct.FieldName = "credit0_auto_reconduct"
        Me.credit0_auto_reconduct.Name = "credit0_auto_reconduct"
        '
        'abo_auto_stop_next_reconduction
        '
        resources.ApplyResources(Me.abo_auto_stop_next_reconduction, "abo_auto_stop_next_reconduction")
        Me.abo_auto_stop_next_reconduction.FieldName = "abo_auto_stop_next_reconduction"
        Me.abo_auto_stop_next_reconduction.Name = "abo_auto_stop_next_reconduction"
        '
        'banner
        '
        resources.ApplyResources(Me.banner, "banner")
        Me.banner.FieldName = "banner"
        Me.banner.Name = "banner"
        '
        'activation_text_fr
        '
        resources.ApplyResources(Me.activation_text_fr, "activation_text_fr")
        Me.activation_text_fr.FieldName = "activation_text_fr"
        Me.activation_text_fr.Name = "activation_text_fr"
        '
        'activation_text_nl
        '
        resources.ApplyResources(Me.activation_text_nl, "activation_text_nl")
        Me.activation_text_nl.FieldName = "activation_text_nl"
        Me.activation_text_nl.Name = "activation_text_nl"
        '
        'activation_text_en
        '
        resources.ApplyResources(Me.activation_text_en, "activation_text_en")
        Me.activation_text_en.FieldName = "activation_text_en"
        Me.activation_text_en.Name = "activation_text_en"
        '
        'free_upgrade_allowed
        '
        resources.ApplyResources(Me.free_upgrade_allowed, "free_upgrade_allowed")
        Me.free_upgrade_allowed.FieldName = "free_upgrade_allowed"
        Me.free_upgrade_allowed.Name = "free_upgrade_allowed"
        '
        'footer
        '
        resources.ApplyResources(Me.footer, "footer")
        Me.footer.FieldName = "footer"
        Me.footer.Name = "footer"
        '
        'campaign
        '
        resources.ApplyResources(Me.campaign, "campaign")
        Me.campaign.FieldName = "campaign"
        Me.campaign.Name = "campaign"
        Me.campaign.OptionsColumn.ReadOnly = True
        '
        'combined_action
        '
        resources.ApplyResources(Me.combined_action, "combined_action")
        Me.combined_action.FieldName = "combined_action"
        Me.combined_action.Name = "combined_action"
        '
        'colSize_w
        '
        resources.ApplyResources(Me.colSize_w, "colSize_w")
        Me.colSize_w.FieldName = "size_w"
        Me.colSize_w.Name = "colSize_w"
        '
        'LabelControl19
        '
        resources.ApplyResources(Me.LabelControl19, "LabelControl19")
        Me.LabelControl19.Name = "LabelControl19"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl19, CType(resources.GetObject("LabelControl19.ShowHelp"), Boolean))
        '
        'txtActivationCode
        '
        resources.ApplyResources(Me.txtActivationCode, "txtActivationCode")
        Me.txtActivationCode.Name = "txtActivationCode"
        Me.HelpProvider1.SetShowHelp(Me.txtActivationCode, CType(resources.GetObject("txtActivationCode.ShowHelp"), Boolean))
        '
        'cmbCombinedAction
        '
        resources.ApplyResources(Me.cmbCombinedAction, "cmbCombinedAction")
        Me.cmbCombinedAction.Name = "cmbCombinedAction"
        Me.cmbCombinedAction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbCombinedAction.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbCombinedAction.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
        Me.cmbCombinedAction.Properties.DisplayMember = "DisplayMember"
        Me.cmbCombinedAction.Properties.NullText = resources.GetString("cmbCombinedAction.Properties.NullText")
        Me.cmbCombinedAction.Properties.ValueMember = "DisplayMember"
        Me.HelpProvider1.SetShowHelp(Me.cmbCombinedAction, CType(resources.GetObject("cmbCombinedAction.ShowHelp"), Boolean))
        '
        'txtValidityMonth
        '
        resources.ApplyResources(Me.txtValidityMonth, "txtValidityMonth")
        Me.txtValidityMonth.Name = "txtValidityMonth"
        Me.txtValidityMonth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtValidityMonth.Properties.MaxLength = 1000000
        Me.txtValidityMonth.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtValidityMonth, CType(resources.GetObject("txtValidityMonth.ShowHelp"), Boolean))
        '
        'LabelControl20
        '
        resources.ApplyResources(Me.LabelControl20, "LabelControl20")
        Me.LabelControl20.Name = "LabelControl20"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl20, CType(resources.GetObject("LabelControl20.ShowHelp"), Boolean))
        '
        'btnSaveBycustomer
        '
        resources.ApplyResources(Me.btnSaveBycustomer, "btnSaveBycustomer")
        Me.btnSaveBycustomer.Name = "btnSaveBycustomer"
        Me.HelpProvider1.SetShowHelp(Me.btnSaveBycustomer, CType(resources.GetObject("btnSaveBycustomer.ShowHelp"), Boolean))
        '
        'txtCustomerId
        '
        resources.ApplyResources(Me.txtCustomerId, "txtCustomerId")
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.txtCustomerId.Properties.MaxLength = 1000000
        Me.txtCustomerId.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.HelpProvider1.SetShowHelp(Me.txtCustomerId, CType(resources.GetObject("txtCustomerId.ShowHelp"), Boolean))
        '
        'LabelControl21
        '
        resources.ApplyResources(Me.LabelControl21, "LabelControl21")
        Me.LabelControl21.Name = "LabelControl21"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl21, CType(resources.GetObject("LabelControl21.ShowHelp"), Boolean))
        '
        'LabelControl23
        '
        resources.ApplyResources(Me.LabelControl23, "LabelControl23")
        Me.LabelControl23.Name = "LabelControl23"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl23, CType(resources.GetObject("LabelControl23.ShowHelp"), Boolean))
        '
        'GrpCustomers
        '
        resources.ApplyResources(Me.GrpCustomers, "GrpCustomers")
        Me.GrpCustomers.Controls.Add(Me.LabelControl24)
        Me.GrpCustomers.Controls.Add(Me.txtValidityToCustomersChange)
        Me.GrpCustomers.Controls.Add(Me.btnSaveBycustomer)
        Me.GrpCustomers.Controls.Add(Me.txtCustomerId)
        Me.GrpCustomers.Controls.Add(Me.LabelControl21)
        Me.GrpCustomers.Name = "GrpCustomers"
        Me.HelpProvider1.SetShowHelp(Me.GrpCustomers, CType(resources.GetObject("GrpCustomers.ShowHelp"), Boolean))
        '
        'LabelControl24
        '
        resources.ApplyResources(Me.LabelControl24, "LabelControl24")
        Me.LabelControl24.Name = "LabelControl24"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl24, CType(resources.GetObject("LabelControl24.ShowHelp"), Boolean))
        '
        'txtValidityToCustomersChange
        '
        Me.txtValidityToCustomersChange.EditValue = Nothing
        resources.ApplyResources(Me.txtValidityToCustomersChange, "txtValidityToCustomersChange")
        Me.txtValidityToCustomersChange.Name = "txtValidityToCustomersChange"
        Me.txtValidityToCustomersChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtValidityToCustomersChange.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtValidityToCustomersChange.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtValidityToCustomersChange, CType(resources.GetObject("txtValidityToCustomersChange.ShowHelp"), Boolean))
        '
        'txtActivationCodeID
        '
        resources.ApplyResources(Me.txtActivationCodeID, "txtActivationCodeID")
        Me.txtActivationCodeID.Name = "txtActivationCodeID"
        Me.HelpProvider1.SetShowHelp(Me.txtActivationCodeID, CType(resources.GetObject("txtActivationCodeID.ShowHelp"), Boolean))
        '
        'LabelControl25
        '
        resources.ApplyResources(Me.LabelControl25, "LabelControl25")
        Me.LabelControl25.Name = "LabelControl25"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl25, CType(resources.GetObject("LabelControl25.ShowHelp"), Boolean))
        '
        'txtCreationDate
        '
        resources.ApplyResources(Me.txtCreationDate, "txtCreationDate")
        Me.txtCreationDate.Name = "txtCreationDate"
        Me.txtCreationDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("txtCreationDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.txtCreationDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.HelpProvider1.SetShowHelp(Me.txtCreationDate, CType(resources.GetObject("txtCreationDate.ShowHelp"), Boolean))
        '
        'LabelControl26
        '
        resources.ApplyResources(Me.LabelControl26, "LabelControl26")
        Me.LabelControl26.Name = "LabelControl26"
        Me.HelpProvider1.SetShowHelp(Me.LabelControl26, CType(resources.GetObject("LabelControl26.ShowHelp"), Boolean))
        '
        'cmbNextAboType
        '
        Me.cmbNextAboType.AllowDrop = True
        resources.ApplyResources(Me.cmbNextAboType, "cmbNextAboType")
        Me.cmbNextAboType.Name = "cmbNextAboType"
        Me.cmbNextAboType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType(resources.GetObject("cmbNextAboType.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines))})
        Me.cmbNextAboType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 87, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 98, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.cmbNextAboType.Properties.DisplayMember = "DisplayMember"
        Me.cmbNextAboType.Properties.NullText = resources.GetString("cmbNextAboType.Properties.NullText")
        Me.cmbNextAboType.Properties.ValueMember = "Value"
        '
        'LabelControl27
        '
        resources.ApplyResources(Me.LabelControl27, "LabelControl27")
        Me.LabelControl27.Name = "LabelControl27"
        '
        'btnCancel
        '
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.HelpProvider1.SetShowHelp(Me.btnCancel, CType(resources.GetObject("btnCancel.ShowHelp"), Boolean))
        '
        'btnSaveDiscount
        '
        resources.ApplyResources(Me.btnSaveDiscount, "btnSaveDiscount")
        Me.btnSaveDiscount.Name = "btnSaveDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnSaveDiscount, CType(resources.GetObject("btnSaveDiscount.ShowHelp"), Boolean))
        '
        'btnEditActivation
        '
        resources.ApplyResources(Me.btnEditActivation, "btnEditActivation")
        Me.btnEditActivation.Name = "btnEditActivation"
        Me.HelpProvider1.SetShowHelp(Me.btnEditActivation, CType(resources.GetObject("btnEditActivation.ShowHelp"), Boolean))
        '
        'btnNewDiscount
        '
        resources.ApplyResources(Me.btnNewDiscount, "btnNewDiscount")
        Me.btnNewDiscount.Name = "btnNewDiscount"
        Me.HelpProvider1.SetShowHelp(Me.btnNewDiscount, CType(resources.GetObject("btnNewDiscount.ShowHelp"), Boolean))
        '
        'frmActivationCode
        '
        resources.ApplyResources(Me, "$this")
        Me.HelpButton = False
        Me.HelpProvider1.SetHelpKeyword(Me, resources.GetString("$this.HelpKeyword"))
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.HelpProvider1.SetHelpString(Me, resources.GetString("$this.HelpString"))
        Me.Name = "frmActivationCode"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
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
        CType(Me.Grid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtComment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductsID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbValidType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextDiscount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidValue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQtyToGenerate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbValidTo.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbValidTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDVDCredit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrefix.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkWaranty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkAuto_Stop_at_Next_Reconduction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBanner.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txtDescEN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescNL.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDescFR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkFree_Upgrade_Allowed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFooter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCampaign.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSearch.ResumeLayout(False)
        CType(Me.GroupSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupSearch.ResumeLayout(False)
        Me.GroupSearch.PerformLayout()
        CType(Me.cmbGroupSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomersIdSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkOnlyUsed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFromDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCampaignSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationCodeSearch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtToDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabResult2.ResumeLayout(False)
        CType(Me.GridActivationCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewActivationCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCombinedAction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidityMonth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomerId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrpCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpCustomers.ResumeLayout(False)
        Me.GrpCustomers.PerformLayout()
        CType(Me.txtValidityToCustomersChange.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtValidityToCustomersChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtActivationCodeID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreationDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCreationDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbNextAboType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()
    End Sub
    Dim KeyDataSet As String = "BizzLib.dsMarketting" 'The Dataset used 
    Dim CurrentCodeType As String
    Dim param As DVDPostBuziness.clsSingleton
    ' Public WithEvents cmbLeverancier As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    ' free_upgrade_allowed, footer, campaign, combined_action
    Dim _activationId As Integer
    Dim _activationCode As String
    Dim _campaignId As String
    Dim _activationGroupId As Integer
    Dim _activationPack As Integer
    Dim _activationCodeCreationDate As String
    Dim _activationCodeValidtoDate As String
    Dim _activationProductsId As Integer
    Dim _validityMonth As Integer
    Dim _validityType As Integer
    Dim _validityValue As Integer
    Dim _activationWaranty As Integer
    Dim _customersId As Integer
    Dim _activationDate As String
    Dim _commentActivation As String
    Dim _aboDvdCredit As Integer
    Dim _nextDiscount As Integer
    Dim _NextaboType As String
    Dim _credit0autoReconduct As Integer
    Dim _aboAutoStopNextReconduction As Boolean
    Dim _bannerActivation As String
    Dim _activationTextFr As String
    Dim _activationTextNl As String
    Dim _activationTextEn As String
    Dim _freeUpgradeAllowed As Integer
    Dim _footerActivation As String
    Dim _campaignActivation As String
    Dim _combinedAction As String
    Dim _validityToChangeCustomers As String

    Dim _enableField As Boolean

    Enum StepForm
        EDIT
        [NEW]
        SAVE
        CANCEL
        INIT
        LOAD
    End Enum


    Private Sub ChangeStep(ByVal stepCurrent As StepForm)
        Select Case stepCurrent
            Case StepForm.CANCEL
                btnEditActivation.Enabled = True
                btnSaveDiscount.Enabled = False
                btnGenerate.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False

                EnableField(False)
                btnGenerate.Enabled = False

                tabSearch.PageVisible = True
                tabResult2.PageVisible = True

            Case StepForm.EDIT
                btnEditActivation.Enabled = False
                btnSaveDiscount.Enabled = True
                btnNew.Enabled = False
                btnCancel.Enabled = True
                btnGenerate.Enabled = True

                EnableField(True)
                btnGenerate.Enabled = True
                TabParameters.PageVisible = True
                tabResult2.PageVisible = False

            Case StepForm.INIT
                btnEditActivation.Enabled = False
                btnSaveDiscount.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False
                btnGenerate.Enabled = False

                EnableField(False)
                btnGenerate.Enabled = False
                tabResult2.PageVisible = False
                tabSearch.PageVisible = True
                TabParameters.PageVisible = False
                TabControl1.SelectedTabPage = tabSearch


            Case StepForm.[NEW]
                btnEditActivation.Enabled = False
                btnSaveDiscount.Enabled = True
                btnNew.Enabled = False
                btnCancel.Enabled = True
                btnGenerate.Enabled = True

                btnGenerate.Enabled = True
                EnableField(True)
                tabResult2.PageVisible = False
                TabParameters.PageVisible = True
                TabControl1.SelectedTabPage = TabParameters



            Case StepForm.SAVE
                btnEditActivation.Enabled = True
                btnSaveDiscount.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False
                btnGenerate.Enabled = False

                btnGenerate.Enabled = False
                EnableField(False)
                TabParameters.PageVisible = True
                tabResult2.PageVisible = True

            Case StepForm.LOAD
                btnEditActivation.Enabled = True
                btnSaveDiscount.Enabled = False
                btnNew.Enabled = True
                btnCancel.Enabled = False
                btnGenerate.Enabled = False

                EnableField(False)
                btnGenerate.Enabled = False
                TabParameters.PageVisible = True
                TabControl1.SelectedTabPage = TabParameters

        End Select
    End Sub

    Public Sub this_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        GridViewActivationCode.OptionsView.ColumnAutoWidth = False
        GridViewActivationCode.OptionsBehavior.Editable = False

        TabControl1.SelectedTabPage = tabSearch
        ' Misc_Bar.Visible = True
        TabParameters.PageVisible = False
        TabAnalyse.PageVisible = False ' not used
        TabChart.PageVisible = False ' not used
        TabResult.PageVisible = False ' not used


        Dim menuStrip As New DVDPostBuziness.contextMenu()
        GridActivationCode.ContextMenuStrip = menuStrip
        LoadBKComboSet()
        ChangeStep(StepForm.INIT)


    End Sub

    Public Sub LoadBKComboSet()

        cmbGroup.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetActivationGroup, "activation_group_name", "activation_group_id") 'GetCombo(DvdPostData.clsActivationCode.GetActivationGroup)
        cmbProductsID.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetProducts(DvdPostData.clsActivationCode.productsTypeAbo), "products_model", "products_id") 'GetCombo(DvdPostData.clsActivationCode.GetProducts(DvdPostData.clsActivationCode.productsTypeAbo))
        cmbValidType.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetActivationValidityType, "validity_type_explained", "validity_type_id") 'GetCombo(DvdPostData.clsActivationCode.GetActivationValidityType)
        cmbNextDiscount.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetDiscountCode(), "discount_code", "discount_code_id") 'GetCombo(DvdPostData.clsActivationCode.GetDiscountCode)
        cmbGroupSearch.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetActivationGroup(), "activation_group_name", "activation_group_id")
        cmbCombinedAction.Properties.DataSource = GetListCombinedAction()
        cmbNextAboType.Properties.DataSource = GetListCmb(DvdPostData.clsActivationCode.GetProducts(DvdPostData.clsActivationCode.productsTypeAbo), "products_title", "products_id")

    End Sub

    Private Function GetListCombinedAction() As List(Of DVDPostBuziness.clsKeyCombo)
        Dim listCmb As New List(Of DVDPostBuziness.clsKeyCombo)
        listCmb.Add(New DVDPostBuziness.clsKeyCombo("YES", 0))
        listCmb.Add(New DVDPostBuziness.clsKeyCombo("NO", 1))
        Return listCmb
    End Function
    Private Function GetListCmb(ByVal sql As String, ByVal displayMember As String, ByVal value As String) As List(Of DVDPostBuziness.clsKeyCombo)
        Dim listCmb As New List(Of DVDPostBuziness.clsKeyCombo)
        Dim dt As DataTable
        Dim dr As DataRow

        dt = DvdPostData.clsConnection.FillDataSet(sql)

        listCmb.Add(New DVDPostBuziness.clsKeyCombo("", 0))
        For Each dr In dt.Rows
            listCmb.Add(New DVDPostBuziness.clsKeyCombo(dr(displayMember), dr(value)))
        Next

        Return listCmb
    End Function


    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        Dim number As Integer
        Dim ok As Boolean
        number = txtQtyToGenerate.EditValue
        If txtQtyToGenerate.EditValue <= 0 Or (txtPrefix.Text & "" = "" And txtPrefix.Text.Length < 4) Then
            MsgBox("Specify a Nbr of code to generate " _
                   & " and specify a Prefix with 4 characters ", MsgBoxStyle.Critical)
        Else
            ok = CheckTextBox()
            If ok Then
                loadVarUpdateInsert()
                generateActivationCode(number)
                ChangeStep(StepForm.SAVE)
            End If

        End If
        'If txtPrefix.Text & "" = "" And txtPrefix.Text.Length < 4 Then
        '    MsgBox("Please specify a Prefix with 4 characters", MsgBoxStyle.Critical)

        '    Exit Sub
        'End If


    End Sub


    Private Function CheckTextBox() As Boolean

        If cmbGroup.EditValue & "" = "" Then
            MsgBox("Select a Group", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If

        If cmbProductsID.EditValue & "" = "" Then
            MsgBox("Please Select a Product", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If
        If cmbValidType.EditValue & "" = "" Then
            MsgBox("Please Select a Validity Type", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If
        If txtValidValue.EditValue <= 0 Then
            MsgBox("Please select a validity value greater than 0", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If
        If txtDVDCredit.EditValue <= 0 Then
            MsgBox("Please select a DVD Credit value greater than 0", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If
        If cmbValidTo.EditValue & "" = "" Then
            MsgBox("Please select a Valid TO Date", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If

        If txtCampaign.EditValue = "" Then
            MsgBox("Please specify a compaign name ", MsgBoxStyle.Critical)
            Return False
            Exit Function
        End If

        Return True

    End Function


    Private Sub generateActivationCode(ByVal number As Integer)
        Dim tabCode As ArrayList = createData(number)
        Dim count As Integer = 0
        Dim el As String
        Dim fieldInsert As String = ""
        'Dim strline As String
        Dim sql As String


        DvdPostData.clsConnection.CreateTransaction(True)

        For Each el In tabCode
            count += 1

            sql = DvdPostData.clsActivationCode.insertActivationCode(el, _activationGroupId, 0, _
                                                                            _activationCodeValidtoDate, _activationProductsId, _
                                                                            _validityType, _validityValue, _
                                                                            _activationWaranty, _commentActivation, _
                                                                            _aboDvdCredit, _nextDiscount, _
                                                                            _aboAutoStopNextReconduction, _bannerActivation, _
                                                                            _activationTextFr, _activationTextNl, _
                                                                            _activationTextEn, _freeUpgradeAllowed, _
                                                                            _footerActivation, _campaignActivation, _
                                                                            _combinedAction)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

        Next
        DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Discount, count)


        MsgBox(count.ToString & " activation_code created")






    End Sub
    Public Function GenerateCode() As String
        Dim _Code As String

        _Code = Guid.NewGuid().ToString().GetHashCode.ToString("X")

        _Code = Replace(_Code, "0", "-")
        _Code = Replace(_Code, "O", "-")
        _Code = txtPrefix.Text.ToUpper + _Code
        _Code.ToUpper()

        Return _Code.Substring(0, _Code.Length - 2)
    End Function

    Public Function getActivationCode() As DataView
        Dim dt As DataTable
        dt = DvdPostData.clsConnection.FillDataSet(DvdPostData.clsActivationCode.GetActivationSearch(, , txtPrefix.Text)) 'GetActivationWithPrefixe(txtPrefix.Text))
        Dim view As New DataView(dt, "", "activation_code", DataViewRowState.CurrentRows)
        Return view
    End Function


    Public Function createData(ByVal maxNumber As Integer) As ArrayList

        Dim activationCode As String
        Dim tabActivationCode As New ArrayList
        Dim viewExist As DataView = getActivationCode()

        Dim dico As New System.Collections.Generic.Dictionary(Of String, String)
        For Each data As DataRowView In viewExist
            dico.Add(data.Row("activation_code").ToUpper(), "")
        Next

        Dim i As Integer

        For i = 0 To maxNumber - 1
            activationCode = GenerateCode()

            While (dico.ContainsKey((activationCode).ToUpper()) = True)
                activationCode = GenerateCode()
            End While

            tabActivationCode.Add(activationCode)
            dico.Add(activationCode.ToUpper(), "")
        Next

        Return tabActivationCode
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        search()

        TabParameters.PageVisible = False
        tabResult2.PageVisible = True
        TabControl1.SelectedTabPage = tabResult2
    End Sub

    Public Sub search()
        Dim activation_id As String
        Dim activation_code As String
        Dim activationUse As Boolean = False
        Dim dateTo As String
        Dim dateFrom As String
        Dim groupId As String
        Dim campaign As String
        Dim dt As DataTable
        Dim sqlSearch As String
        Dim customers_id As Integer

        Dim param As DVDPostBuziness.clsSingleton
        param = DVDPostBuziness.clsSingleton.Instance()



        If param.Activation_Discount_id = Nothing Then
            activation_id = txtActivationId.Text.Trim
        Else
            activation_id = param.Activation_Discount_id
            param.Activation_Discount_id = Nothing
        End If
        'activation_id = txtActivationId.Text.Trim
        activation_code = txtActivationCodeSearch.Text.Trim
        dateFrom = txtFromDate.EditValue
        dateTo = txtToDate.EditValue
        campaign = txtCampaignSearch.Text.Trim
        groupId = cmbGroupSearch.EditValue
        customers_id = txtCustomersIdSearch.EditValue

        If groupId = "0" Then
            groupId = String.Empty
        End If

        If chkOnlyUsed.Checked = True Then
            activationUse = True
        End If

        sqlSearch = DvdPostData.clsActivationCode.GetActivationSearch(customers_id, activation_id, activation_code, activationUse, campaign, dateFrom, dateTo, groupId)
        dt = DvdPostData.clsConnection.FillDataSet(sqlSearch)
        GridActivationCode.DataSource = dt

        btnXls.Visible = dt.Rows.Count > 0


    End Sub


    Private Function GetCombo(ByVal sql As String) As DataTable
        Dim dt As DataTable
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function



    Private Sub loadActivationExpiration()
        Dim dt As DataTable
        Dim sqlActivationExp As String = DvdPostData.clsActivationCode.GetActivationExpiration()
        dt = DvdPostData.clsConnection.FillDataSet(sqlActivationExp)
        GridActivationCode.DataSource = dt
        TabControl1.SelectedTabPage = tabResult2
    End Sub


    Private Sub btnEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEx.Click
        loadActivationExpiration()
        AddHandler GridViewActivationCode.RowStyle, AddressOf GridViewActivationCode_RowStyle
    End Sub

    'change color of the row by gauthier
    Public Sub GridViewActivationCode_RowStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs)
        Dim View As DevExpress.XtraGrid.Views.Grid.GridView = sender
        If (e.RowHandle >= 0) Then
            Dim validitytoString As String = View.GetRowCellDisplayText(e.RowHandle, View.Columns("activation_code_validto_date")).ToString
            If validitytoString <> "" Then
                Dim validityToDate As Date = CType(validitytoString, Date)
                If validityToDate >= Date.Now Then
                    e.Appearance.BackColor = Drawing.Color.LightGreen
                    e.Appearance.BackColor2 = Drawing.Color.SeaShell
                End If

                If validityToDate < Date.Now Then
                    e.Appearance.BackColor = Drawing.Color.LightSalmon
                    e.Appearance.BackColor2 = Drawing.Color.SeaShell
                End If

            End If
        End If
    End Sub
    Private Sub initForm()
        Dim blank As String = String.Empty
        txtActivationCodeID.EditValue = blank
        txtCustomerId.EditValue = blank
        txtActivationCode.EditValue = blank
        cmbGroup.EditValue = blank
        cmbValidTo.EditValue = blank
        cmbProductsID.EditValue = blank
        txtValidityMonth.EditValue = blank
        cmbValidType.EditValue = blank
        txtValidValue.EditValue = blank
        txtDVDCredit.EditValue = blank
        cmbNextDiscount.EditValue = 0
        txtFooter.EditValue = blank
        txtComment.EditValue = blank
        txtBanner.EditValue = blank
        txtDescFR.EditValue = blank
        txtDescNL.EditValue = blank
        txtDescNL.EditValue = blank
        txtDescEN.EditValue = blank
        txtCampaign.EditValue = blank
        chkWaranty.EditValue = 0
        chkAuto_Stop_at_Next_Reconduction.EditValue = 1
        cmbCombinedAction.EditValue = 0
        'CheckCombinetActi.EditValue = clsMarketing.clsActivationCode.GetCombinedAction(dr)
        chkFree_Upgrade_Allowed.EditValue = 0

        '  txtValidityToCustomersChange.EditValue = blank
        txtCreationDate.EditValue = blank
        cmbNextAboType.EditValue = 0

    End Sub


    Private Sub loadTextBoxInfo(ByVal dr As DataRow)
        txtActivationCodeID.EditValue = clsMarketing.clsActivationCode.GetActivationId(dr)
        txtCustomerId.EditValue = clsMarketing.clsActivationCode.GetCustomersId(dr)
        txtActivationCode.EditValue = clsMarketing.clsActivationCode.GetActivationCode(dr)
        cmbGroup.EditValue = clsMarketing.clsActivationCode.GetActivationGroup(dr)
        cmbValidTo.EditValue = clsMarketing.clsActivationCode.GetActivationCodeValidtoDate(dr)
        cmbProductsID.EditValue = clsMarketing.clsActivationCode.GetActivationProductsId(dr)
        txtValidityMonth.EditValue = clsMarketing.clsActivationCode.GetValidityMonth(dr)
        cmbValidType.EditValue = clsMarketing.clsActivationCode.GetValidityType(dr)
        txtValidValue.EditValue = clsMarketing.clsActivationCode.GetValidityValue(dr)
        txtDVDCredit.EditValue = clsMarketing.clsActivationCode.GetAboDvdCredit(dr)
        cmbNextDiscount.EditValue = clsMarketing.clsActivationCode.GetNextDiscount(dr)
        txtFooter.EditValue = clsMarketing.clsActivationCode.GetFooter(dr)
        txtComment.EditValue = clsMarketing.clsActivationCode.GetComment(dr)
        txtBanner.EditValue = clsMarketing.clsActivationCode.GetBanner(dr)
        txtDescFR.EditValue = clsMarketing.clsActivationCode.getActivationTextFr(dr)
        txtDescNL.EditValue = clsMarketing.clsActivationCode.getActivationTextNl(dr)
        txtDescNL.EditValue = clsMarketing.clsActivationCode.getActivationTextNl(dr)
        txtDescEN.EditValue = clsMarketing.clsActivationCode.getActivationTextEn(dr)
        txtCampaign.EditValue = clsMarketing.clsActivationCode.GetCampaign(dr)
        chkWaranty.EditValue = clsMarketing.clsActivationCode.GetActivationWaranty(dr)
        chkAuto_Stop_at_Next_Reconduction.EditValue = clsMarketing.clsActivationCode.GetAboAutoStopNextReconduction(dr)
        cmbCombinedAction.EditValue = clsMarketing.clsActivationCode.GetCombinedAction(dr)
        'CheckCombinetActi.EditValue = clsMarketing.clsActivationCode.GetCombinedAction(dr)
        chkFree_Upgrade_Allowed.EditValue = clsMarketing.clsActivationCode.GetFreeUpgradeAllowed(dr)

        txtValidityToCustomersChange.EditValue = clsMarketing.clsActivationCode.GetActivationCodeValidtoDate(dr)
        txtCreationDate.EditValue = clsMarketing.clsActivationCode.GetActivationCodeCreationDate(dr)
        cmbNextAboType.EditValue = clsMarketing.clsDiscountCode.GetNextAboType(dr) 'dr("next_abo_type")

    End Sub

    Private Sub loadVarUpdateInsert()

        If txtActivationCodeID.EditValue IsNot String.Empty Then
            _activationId = txtActivationCodeID.EditValue
        End If
        _activationCode = txtActivationCode.EditValue
        '_campaignId 
        _activationGroupId = cmbGroup.EditValue
        '_activationPack 
        _activationCodeCreationDate = txtCreationDate.EditValue
        _activationCodeValidtoDate = cmbValidTo.EditValue
        _activationProductsId = cmbProductsID.EditValue
        _validityMonth = txtValidityMonth.EditValue
        _validityType = cmbValidType.EditValue
        _validityValue = txtValidValue.EditValue
        _activationWaranty = chkWaranty.Checked
        '_activationDate'
        _commentActivation = txtComment.EditValue
        _aboDvdCredit = txtDVDCredit.EditValue
        _nextDiscount = cmbNextDiscount.EditValue
        '_credit0autoReconduct 
        _aboAutoStopNextReconduction = chkAuto_Stop_at_Next_Reconduction.Checked
        _bannerActivation = txtBanner.EditValue
        _activationTextFr = txtDescFR.EditValue
        _activationTextNl = txtDescNL.EditValue
        _activationTextEn = txtDescEN.EditValue
        _freeUpgradeAllowed = chkFree_Upgrade_Allowed.Checked
        _footerActivation = txtFooter.EditValue
        _campaignActivation = txtCampaign.EditValue
        _combinedAction = cmbCombinedAction.EditValue

        _validityToChangeCustomers = txtValidityToCustomersChange.EditValue
        _customersId = txtCustomerId.EditValue

        _NextaboType = cmbNextAboType.EditValue

    End Sub


    Private Sub loadInfoActivation(ByVal activation_id As Integer)
        Dim dt As DataTable
        Dim sql As String

        sql = DvdPostData.clsActivationCode.GetActivationSearch(, activation_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        loadTextBoxInfo(dt.Rows(0))
    End Sub

    Private Sub GridActivationCode_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridActivationCode.DoubleClick
        loadInfo()
        ChangeStep(StepForm.LOAD)
    End Sub

    Private Sub loadInfo()
        Dim activation_id As Integer
        If GridViewActivationCode.RowCount > 0 Then
            activation_id = GridViewActivationCode.GetDataRow(GridViewActivationCode.FocusedRowHandle())("activation_id")
            loadInfoActivation(activation_id)
            TabControl1.SelectedTabPage = TabParameters
        End If
    End Sub

    Private Sub updateActivationByCust()
        Dim sql As String
        Dim count As Integer
        loadVarUpdateInsert()
        Try


            DvdPostData.clsConnection.CreateTransaction(False)
            sql = DvdPostData.clsActivationCode.updateActivationBYCust(_customersId, _activationId, _validityToChangeCustomers)
            count = DvdPostData.clsConnection.ExecuteNonQuery(sql)

            If MsgBox("you go to update " & count & " activations codes ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                DvdPostData.clsConnection.CommitTransaction(True)
                ChangeStep(StepForm.SAVE)
            Else
                DvdPostData.clsConnection.CommitTransaction(False)
                ChangeStep(StepForm.CANCEL)
            End If
        Catch ex As Exception
            DvdPostData.clsConnection.CommitTransaction(False)
            DVDPostBuziness.clsMsgError.MsgBox(ex.Message)
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Discount, ex, _customersId)
        End Try
    End Sub



    Private Sub btnSaveBycustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBycustomer.Click
        updateActivationByCust()
    End Sub

    Private Sub updateActivation()
        Dim sql As String
        Dim activationCodeCondition As String
        Dim count As Integer

        Try

            loadVarUpdateInsert()
            activationCodeCondition = _activationCode.Substring(0, 3)
            DvdPostData.clsConnection.CreateTransaction(False)
            sql = DvdPostData.clsActivationCode.updateActivation(_activationGroupId, 0, _
                                                                                 _activationCodeValidtoDate, _activationProductsId, _
                                                                                 _validityType, _validityValue, _
                                                                                 _activationWaranty, _commentActivation, _
                                                                                 _aboDvdCredit, _nextDiscount, _
                                                                                 _aboAutoStopNextReconduction, _bannerActivation, _
                                                                                 _activationTextFr, _activationTextNl, _
                                                                                 _activationTextEn, _freeUpgradeAllowed, _
                                                                                 _footerActivation, _campaignActivation, _
                                                                                 _combinedAction, _activationCodeCreationDate, activationCodeCondition, _NextaboType)

            count = DvdPostData.clsConnection.ExecuteNonQuery(sql)
            If MsgBox("you go to update " & count & " activations codes ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

                DvdPostData.clsConnection.CommitTransaction(True)
                ChangeStep(StepForm.SAVE)
            Else
                ChangeStep(StepForm.CANCEL)
                DvdPostData.clsConnection.CommitTransaction(False)
            End If


        Catch ex As Exception
            DvdPostData.clsConnection.CommitTransaction(False)
            DVDPostBuziness.clsMsgError.MsgBox(ex.Message)
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Discount, ex)
        End Try



    End Sub

    Private Function EnableField(ByVal ok As Boolean) As Boolean
        Dim enable As Boolean
        enable = ok


        cmbGroup.Enabled = enable
        cmbValidTo.Enabled = enable
        cmbProductsID.Enabled = enable
        txtValidityMonth.Enabled = enable
        cmbValidType.Enabled = enable
        txtValidValue.Enabled = enable
        txtDVDCredit.Enabled = enable
        cmbNextDiscount.Enabled = enable
        txtFooter.Enabled = enable
        txtComment.Enabled = enable
        txtBanner.Enabled = enable
        txtDescFR.Enabled = enable
        txtDescNL.Enabled = enable
        txtDescNL.Enabled = enable
        txtDescEN.Enabled = enable
        txtCampaign.Enabled = enable
        chkWaranty.Enabled = enable
        chkAuto_Stop_at_Next_Reconduction.Enabled = enable
        cmbCombinedAction.Enabled = enable
        chkFree_Upgrade_Allowed.Enabled = enable

        txtValidityToCustomersChange.Enabled = enable
        txtPrefix.Enabled = enable

        txtQtyToGenerate.Enabled = enable
        cmbNextAboType.Enabled = enable
        Return ok
    End Function

    Private Sub btnEditActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChangeStep(StepForm.EDIT)

    End Sub

    'Public Sub enablingField() '
    '    If _enableField Then
    '        _enableField = EnableField(False)
    '        loadInfo()
    '    Else
    '        _enableField = EnableField(True)
    '    End If
    'End Sub

    Private Sub btnNewActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewActivation.Click

        initForm()
        ChangeStep(StepForm.[NEW])
    End Sub

    Private Sub btnEditDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditActivation.Click
        ChangeStep(StepForm.EDIT)
    End Sub

    Private Sub btnSaveDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveDiscount.Click
        Dim ok As Boolean

        ok = CheckTextBox()
        If ok Then
            '  loadVarUpdateInsert()
            updateActivation()
        End If
    End Sub


    Private Sub btnNewDiscount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewDiscount.Click
        btnNewActivation_Click(Nothing, Nothing)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ChangeStep(StepForm.CANCEL)
    End Sub

    Private Sub btnXls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXls.Click
        DVDPostBuziness.clsExport.ExportXls(GridViewActivationCode)
    End Sub

End Class



