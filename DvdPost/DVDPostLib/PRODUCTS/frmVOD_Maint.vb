Imports BizzLib.clsGlobal.ObjectState
Imports System.Windows.Forms.Application
Imports System.Threading
Imports System.Windows.Forms
Imports System.Collections.Generic


Public Class frmVOD_Maint
    Inherits BizzLib.frmGeneral_Maintenance

    Private Class ComboParam
        Public LTable As DataTable
        Public LSQLStr As String
        Public Sub New(ByVal vTable As DataTable, ByVal vSQLSTr As String)
            LTable = vTable
            LSQLStr = vSQLSTr
        End Sub
    End Class
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
    Friend WithEvents lblDateAdded As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDirector As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbVODSerie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents objDS As DVDPostLib.dsProducts
    Friend WithEvents BandedGridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents PanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl71 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl75 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl79 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit5 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl80 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl81 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl82 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit6 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl83 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelControl84 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl85 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit7 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl86 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents tabVodWishlist As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridVODWishlist As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewVODWishlist As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand12 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabCritiques As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblValueNBRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueNbCritiquePositive As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbCritiquePositive As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueNbCrtitiques As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbCritiques As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueRatingAverage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRatingAverage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridCritiques As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCritiques As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabVod As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnCancelVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmbLanguageSubtitle As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbLanguageSound As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbDateExpired As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbDateStart As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TxtFilename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkAvailable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblAvailable As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNameFile As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateExpired As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDateStart As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLanguage_subtitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLanguageSound As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImdbView As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblImdbView As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSaveVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditVod As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabGames As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents chkGameOnline As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtGame_ConfigMini As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGame_NbrOfPlayersOnline As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGame_NbrOfPlayers As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabTrailers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents grpPictures As DevExpress.XtraEditors.GroupControl
    Friend WithEvents imgIMDBID_6 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_5 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_4 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_3 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents imgIMDBID_1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents grpSoundTracks As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridSoundtracks As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSoundTracks As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand8 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colproducts_id5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_soundtracks_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbSoundTracks As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSoundTracks As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitterControl3 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents grpTrailers As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridStreamingTrailers As DevExpress.XtraGrid.GridControl
    Friend WithEvents AdvBandedGridView2 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand13 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents BandedGridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn8 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn9 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BandedGridColumn10 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GridTrailers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewTrailers As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand7 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents coltrailers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_id4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colWatchTrailer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ButtonWatchTrailer As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents collanguage_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbLangTrailer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents coltrailer As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colbroadcast As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbTrailers_Broadcast As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabLanguages As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grpSubTitles As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridUndertitles As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewUndertitles As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colproducts_id3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_undertitles_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbUndertitles As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSubTitles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents grpLanguage As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridLanguages As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewLanguages As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colproducts_id2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_languages_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbLanguages1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnLang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tabTheme As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Public WithEvents TreeListThemes As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colthemes_id As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colparent_id1 As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colthemes_type As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colthemes_name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colthemes_selected As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents chkThemeSelected As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl12 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnThemes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SplitterControl2 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Public WithEvents TreeListCategories As DevExpress.XtraTreeList.TreeList
    Friend WithEvents colcategories_id As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colparent_id As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colcategories_type As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colcategories_name As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colcategory_selected As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents chkSelectCategory As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCategories As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabEN As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAwardEN As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pictEN As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtImageEN As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtURLEn As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabNL As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txtAwardNL As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pictNL As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtImageNL As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtURLNl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabFR As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtAwardFR As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents pictFR As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtImageFR As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtURLFr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grpVOD As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVODAudio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpActors As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridActors As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewActors As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colactors_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents cmbActors As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnActorsMaint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grpImage As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictProducts_Image As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txtPictureImage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grpSeries As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cmbVODSerieID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImdb_id_serie As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblImdb_id_serie As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABOSerieNbr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbABOSerie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtSerieNbr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblSerieNbr As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbSerie As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblSeries As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpMain As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkVodNextNL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkVodNextLU As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkVodNext As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbProducts_product_type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtIMDB_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtTitle As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkInTheBagsNext As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInTheBags As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkInCinemaNow As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkProduct_Next As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtOtherProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkGommetteNL As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkGommetteFR As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbRating As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbAvailability As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProducts_Media As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProducts_Type As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbProducts_Status As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDirector As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents cmbPictureFormat As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPictureFormat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPublic As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblPublic As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbStudio As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblStudio As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbcountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblcountry As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtRunTime As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRunTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtYear As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblYear As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateAvailable As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateAdded As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtQtyNow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblQtyNow As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblTitle As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtModel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblModel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblProductID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents XTabControlProduct As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents grpEpisode2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR5 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR4 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR6 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR8 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR7 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisdoe9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR9 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl72 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl73 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR10 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl74 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl76 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode11 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR11 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl77 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl78 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode12 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR12 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl88 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl89 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode13 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR13 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl90 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl91 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode14 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR14 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl92 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl93 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode15 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR15 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl94 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl95 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode17 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR17 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl98 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl99 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode16 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR16 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl96 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl97 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode18 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR18 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl100 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl101 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode20 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR20 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl104 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl105 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode19 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR19 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl102 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl103 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode23 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR23 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl110 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR23 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl111 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode22 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR22 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl108 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR22 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl109 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode21 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR21 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl106 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR21 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl107 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpEpisode24 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescFR24 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl112 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameFR24 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl113 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtEpisodesNumber As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtSeason As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox29 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN24 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN24 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox30 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN23 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl162 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN23 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl163 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox31 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN22 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl164 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN22 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl165 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox32 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN21 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl166 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN21 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl167 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox33 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN20 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl168 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl169 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox34 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN19 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl170 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl171 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox35 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN18 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl172 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl173 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox36 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN17 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl174 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl175 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox37 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN16 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl176 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl177 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox38 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN15 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl178 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl179 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox39 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN14 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl180 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl181 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox40 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN13 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl182 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl183 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox41 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN12 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl184 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl185 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox42 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN11 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl186 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl187 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox43 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN10 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl188 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl189 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox44 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN9 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl190 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl191 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox45 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN8 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl192 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl193 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox46 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN7 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl194 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl195 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox47 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN6 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl196 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl197 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox48 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN5 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl198 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl199 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox49 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN4 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl200 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl201 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox50 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl202 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl203 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox51 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl204 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl205 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox52 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescEN1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl206 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameEN1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl207 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL24 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL24 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL23 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl116 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL23 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl117 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL22 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl118 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL22 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl119 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL21 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl120 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL21 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl121 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL20 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl122 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl123 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL19 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl124 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl125 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL18 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl126 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl127 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL17 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl128 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl129 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL16 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl130 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl131 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL15 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl132 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl133 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL14 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl134 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl135 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL13 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl136 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl137 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL12 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl138 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl139 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL11 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl140 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl141 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL10 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl142 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl143 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL9 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl144 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl145 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL8 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl146 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl147 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL7 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl148 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl149 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL6 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl150 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl151 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL5 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl152 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl153 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox25 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL4 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl154 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl155 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox26 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl156 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl157 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox27 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl158 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl159 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupBox28 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescNL1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl160 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNameNL1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl161 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl87 As DevExpress.XtraEditors.LabelControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
Dim FilterCondition1 As DevExpress.XtraTreeList.FilterCondition = New DevExpress.XtraTreeList.FilterCondition
Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
Me.colcategory_selected = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.chkSelectCategory = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
Me.objDS = New DVDPostLib.dsProducts
Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl
Me.cmbVODSerie = New DevExpress.XtraEditors.LookUpEdit
Me.BandedGridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.PanelControl10 = New DevExpress.XtraEditors.PanelControl
Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
Me.GridControl1 = New DevExpress.XtraGrid.GridControl
Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox3 = New System.Windows.Forms.GroupBox
Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl
Me.LookUpEdit4 = New DevExpress.XtraEditors.LookUpEdit
Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl71 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox4 = New System.Windows.Forms.GroupBox
Me.LabelControl75 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl79 = New DevExpress.XtraEditors.LabelControl
Me.LookUpEdit5 = New DevExpress.XtraEditors.LookUpEdit
Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl80 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox5 = New System.Windows.Forms.GroupBox
Me.LabelControl81 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit15 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl82 = New DevExpress.XtraEditors.LabelControl
Me.LookUpEdit6 = New DevExpress.XtraEditors.LookUpEdit
Me.TextEdit16 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl83 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox6 = New System.Windows.Forms.GroupBox
Me.LabelControl84 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit17 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl85 = New DevExpress.XtraEditors.LabelControl
Me.LookUpEdit7 = New DevExpress.XtraEditors.LookUpEdit
Me.TextEdit18 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl86 = New DevExpress.XtraEditors.LabelControl
Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
Me.LabelControl87 = New DevExpress.XtraEditors.LabelControl
Me.tabVodWishlist = New DevExpress.XtraTab.XtraTabPage
Me.GridVODWishlist = New DevExpress.XtraGrid.GridControl
Me.gridViewVODWishlist = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand12 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.tabCritiques = New DevExpress.XtraTab.XtraTabPage
Me.lblValueNBRating = New DevExpress.XtraEditors.LabelControl
Me.lblNbRating = New DevExpress.XtraEditors.LabelControl
Me.lblValueNbCritiquePositive = New DevExpress.XtraEditors.LabelControl
Me.lblNbCritiquePositive = New DevExpress.XtraEditors.LabelControl
Me.lblValueNbCrtitiques = New DevExpress.XtraEditors.LabelControl
Me.lblNbCritiques = New DevExpress.XtraEditors.LabelControl
Me.lblValueRatingAverage = New DevExpress.XtraEditors.LabelControl
Me.lblRatingAverage = New DevExpress.XtraEditors.LabelControl
Me.GridCritiques = New DevExpress.XtraGrid.GridControl
Me.GridViewCritiques = New DevExpress.XtraGrid.Views.Grid.GridView
Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.tabVod = New DevExpress.XtraTab.XtraTabPage
Me.txtId = New DevExpress.XtraEditors.TextEdit
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
Me.tabGames = New DevExpress.XtraTab.XtraTabPage
Me.chkGameOnline = New DevExpress.XtraEditors.CheckEdit
Me.txtGame_ConfigMini = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
Me.txtGame_NbrOfPlayersOnline = New DevExpress.XtraEditors.TextEdit
Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
Me.txtGame_NbrOfPlayers = New DevExpress.XtraEditors.TextEdit
Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
Me.tabTrailers = New DevExpress.XtraTab.XtraTabPage
Me.Splitter1 = New System.Windows.Forms.Splitter
Me.grpPictures = New DevExpress.XtraEditors.GroupControl
Me.imgIMDBID_6 = New DevExpress.XtraEditors.PictureEdit
Me.imgIMDBID_5 = New DevExpress.XtraEditors.PictureEdit
Me.imgIMDBID_4 = New DevExpress.XtraEditors.PictureEdit
Me.imgIMDBID_3 = New DevExpress.XtraEditors.PictureEdit
Me.imgIMDBID_2 = New DevExpress.XtraEditors.PictureEdit
Me.imgIMDBID_1 = New DevExpress.XtraEditors.PictureEdit
Me.grpSoundTracks = New DevExpress.XtraEditors.GroupControl
Me.GridSoundtracks = New DevExpress.XtraGrid.GridControl
Me.GridViewSoundTracks = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand8 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.colproducts_id5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproducts_soundtracks_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.cmbSoundTracks = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl
Me.btnSoundTracks = New DevExpress.XtraEditors.SimpleButton
Me.SplitterControl3 = New DevExpress.XtraEditors.SplitterControl
Me.grpTrailers = New DevExpress.XtraEditors.GroupControl
Me.Panel2 = New System.Windows.Forms.Panel
Me.GridStreamingTrailers = New DevExpress.XtraGrid.GridControl
Me.AdvBandedGridView2 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand13 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.BandedGridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.BandedGridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.BandedGridColumn8 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.BandedGridColumn9 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.BandedGridColumn10 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.Splitter2 = New System.Windows.Forms.Splitter
Me.Panel1 = New System.Windows.Forms.Panel
Me.GridTrailers = New DevExpress.XtraGrid.GridControl
Me.GridViewTrailers = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand7 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.coltrailers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproducts_id4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colWatchTrailer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.ButtonWatchTrailer = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
Me.collanguage_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.cmbLangTrailer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.coltrailer = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colbroadcast = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.cmbTrailers_Broadcast = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
Me.tabLanguages = New DevExpress.XtraTab.XtraTabPage
Me.grpSubTitles = New DevExpress.XtraEditors.GroupControl
Me.GridUndertitles = New DevExpress.XtraGrid.GridControl
Me.GridViewUndertitles = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.colproducts_id3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproducts_undertitles_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.cmbUndertitles = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl
Me.btnSubTitles = New DevExpress.XtraEditors.SimpleButton
Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
Me.grpLanguage = New DevExpress.XtraEditors.GroupControl
Me.GridLanguages = New DevExpress.XtraGrid.GridControl
Me.GridViewLanguages = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.colproducts_id2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproducts_languages_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.cmbLanguages1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl
Me.btnLang = New DevExpress.XtraEditors.SimpleButton
Me.tabTheme = New DevExpress.XtraTab.XtraTabPage
Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
Me.TreeListThemes = New DevExpress.XtraTreeList.TreeList
Me.colthemes_id = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.colparent_id1 = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.colthemes_type = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.colthemes_name = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.colthemes_selected = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.chkThemeSelected = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
Me.PanelControl12 = New DevExpress.XtraEditors.PanelControl
Me.btnThemes = New DevExpress.XtraEditors.SimpleButton
Me.SplitterControl2 = New DevExpress.XtraEditors.SplitterControl
Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl
Me.TreeListCategories = New DevExpress.XtraTreeList.TreeList
Me.colcategories_id = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.colparent_id = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.colcategories_type = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.colcategories_name = New DevExpress.XtraTreeList.Columns.TreeListColumn
Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl
Me.btnCategories = New DevExpress.XtraEditors.SimpleButton
Me.tabEN = New DevExpress.XtraTab.XtraTabPage
Me.Panel7 = New System.Windows.Forms.Panel
Me.Panel8 = New System.Windows.Forms.Panel
Me.GroupBox29 = New System.Windows.Forms.GroupBox
Me.txtDescEN24 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN24 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox30 = New System.Windows.Forms.GroupBox
Me.txtDescEN23 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl162 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN23 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl163 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox31 = New System.Windows.Forms.GroupBox
Me.txtDescEN22 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl164 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN22 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl165 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox32 = New System.Windows.Forms.GroupBox
Me.txtDescEN21 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl166 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN21 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl167 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox33 = New System.Windows.Forms.GroupBox
Me.txtDescEN20 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl168 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN20 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl169 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox34 = New System.Windows.Forms.GroupBox
Me.txtDescEN19 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl170 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN19 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl171 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox35 = New System.Windows.Forms.GroupBox
Me.txtDescEN18 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl172 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN18 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl173 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox36 = New System.Windows.Forms.GroupBox
Me.txtDescEN17 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl174 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN17 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl175 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox37 = New System.Windows.Forms.GroupBox
Me.txtDescEN16 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl176 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN16 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl177 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox38 = New System.Windows.Forms.GroupBox
Me.txtDescEN15 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl178 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN15 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl179 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox39 = New System.Windows.Forms.GroupBox
Me.txtDescEN14 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl180 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN14 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl181 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox40 = New System.Windows.Forms.GroupBox
Me.txtDescEN13 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl182 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN13 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl183 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox41 = New System.Windows.Forms.GroupBox
Me.txtDescEN12 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl184 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN12 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl185 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox42 = New System.Windows.Forms.GroupBox
Me.txtDescEN11 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl186 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN11 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl187 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox43 = New System.Windows.Forms.GroupBox
Me.txtDescEN10 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl188 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN10 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl189 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox44 = New System.Windows.Forms.GroupBox
Me.txtDescEN9 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl190 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN9 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl191 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox45 = New System.Windows.Forms.GroupBox
Me.txtDescEN8 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl192 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN8 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl193 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox46 = New System.Windows.Forms.GroupBox
Me.txtDescEN7 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl194 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN7 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl195 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox47 = New System.Windows.Forms.GroupBox
Me.txtDescEN6 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl196 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN6 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl197 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox48 = New System.Windows.Forms.GroupBox
Me.txtDescEN5 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl198 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN5 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl199 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox49 = New System.Windows.Forms.GroupBox
Me.txtDescEN4 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl200 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN4 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl201 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox50 = New System.Windows.Forms.GroupBox
Me.txtDescEN3 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl202 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN3 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl203 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox51 = New System.Windows.Forms.GroupBox
Me.txtDescEN2 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl204 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN2 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl205 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox52 = New System.Windows.Forms.GroupBox
Me.txtDescEN1 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl206 = New DevExpress.XtraEditors.LabelControl
Me.txtNameEN1 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl207 = New DevExpress.XtraEditors.LabelControl
Me.txtAwardEN = New DevExpress.XtraEditors.MemoEdit
Me.pictEN = New DevExpress.XtraEditors.PictureEdit
Me.txtImageEN = New DevExpress.XtraEditors.TextEdit
Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
Me.txtURLEn = New DevExpress.XtraEditors.TextEdit
Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
Me.tabNL = New DevExpress.XtraTab.XtraTabPage
Me.Panel5 = New System.Windows.Forms.Panel
Me.Panel6 = New System.Windows.Forms.Panel
Me.GroupBox1 = New System.Windows.Forms.GroupBox
Me.txtDescNL24 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL24 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox2 = New System.Windows.Forms.GroupBox
Me.txtDescNL23 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl116 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL23 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl117 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox7 = New System.Windows.Forms.GroupBox
Me.txtDescNL22 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl118 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL22 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl119 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox8 = New System.Windows.Forms.GroupBox
Me.txtDescNL21 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl120 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL21 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl121 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox9 = New System.Windows.Forms.GroupBox
Me.txtDescNL20 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl122 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL20 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl123 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox10 = New System.Windows.Forms.GroupBox
Me.txtDescNL19 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl124 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL19 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl125 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox11 = New System.Windows.Forms.GroupBox
Me.txtDescNL18 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl126 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL18 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl127 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox12 = New System.Windows.Forms.GroupBox
Me.txtDescNL17 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl128 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL17 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl129 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox13 = New System.Windows.Forms.GroupBox
Me.txtDescNL16 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl130 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL16 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl131 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox14 = New System.Windows.Forms.GroupBox
Me.txtDescNL15 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl132 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL15 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl133 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox15 = New System.Windows.Forms.GroupBox
Me.txtDescNL14 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl134 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL14 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl135 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox16 = New System.Windows.Forms.GroupBox
Me.txtDescNL13 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl136 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL13 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl137 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox17 = New System.Windows.Forms.GroupBox
Me.txtDescNL12 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl138 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL12 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl139 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox18 = New System.Windows.Forms.GroupBox
Me.txtDescNL11 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl140 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL11 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl141 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox19 = New System.Windows.Forms.GroupBox
Me.txtDescNL10 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl142 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL10 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl143 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox20 = New System.Windows.Forms.GroupBox
Me.txtDescNL9 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl144 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL9 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl145 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox21 = New System.Windows.Forms.GroupBox
Me.txtDescNL8 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl146 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL8 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl147 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox22 = New System.Windows.Forms.GroupBox
Me.txtDescNL7 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl148 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL7 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl149 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox23 = New System.Windows.Forms.GroupBox
Me.txtDescNL6 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl150 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL6 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl151 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox24 = New System.Windows.Forms.GroupBox
Me.txtDescNL5 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl152 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL5 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl153 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox25 = New System.Windows.Forms.GroupBox
Me.txtDescNL4 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl154 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL4 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl155 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox26 = New System.Windows.Forms.GroupBox
Me.txtDescNL3 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl156 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL3 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl157 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox27 = New System.Windows.Forms.GroupBox
Me.txtDescNL2 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl158 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL2 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl159 = New DevExpress.XtraEditors.LabelControl
Me.GroupBox28 = New System.Windows.Forms.GroupBox
Me.txtDescNL1 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl160 = New DevExpress.XtraEditors.LabelControl
Me.txtNameNL1 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl161 = New DevExpress.XtraEditors.LabelControl
Me.txtAwardNL = New DevExpress.XtraEditors.MemoEdit
Me.pictNL = New DevExpress.XtraEditors.PictureEdit
Me.txtImageNL = New DevExpress.XtraEditors.TextEdit
Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
Me.txtURLNl = New DevExpress.XtraEditors.TextEdit
Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl
Me.tabFR = New DevExpress.XtraTab.XtraTabPage
Me.Panel3 = New System.Windows.Forms.Panel
Me.Panel4 = New System.Windows.Forms.Panel
Me.grpEpisode24 = New System.Windows.Forms.GroupBox
Me.txtDescFR24 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl112 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR24 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl113 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode23 = New System.Windows.Forms.GroupBox
Me.txtDescFR23 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl110 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR23 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl111 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode22 = New System.Windows.Forms.GroupBox
Me.txtDescFR22 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl108 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR22 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl109 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode21 = New System.Windows.Forms.GroupBox
Me.txtDescFR21 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl106 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR21 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl107 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode20 = New System.Windows.Forms.GroupBox
Me.txtDescFR20 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl104 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR20 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl105 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode19 = New System.Windows.Forms.GroupBox
Me.txtDescFR19 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl102 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR19 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl103 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode18 = New System.Windows.Forms.GroupBox
Me.txtDescFR18 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl100 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR18 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl101 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode17 = New System.Windows.Forms.GroupBox
Me.txtDescFR17 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl98 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR17 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl99 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode16 = New System.Windows.Forms.GroupBox
Me.txtDescFR16 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl96 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR16 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl97 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode15 = New System.Windows.Forms.GroupBox
Me.txtDescFR15 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl94 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR15 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl95 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode14 = New System.Windows.Forms.GroupBox
Me.txtDescFR14 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl92 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR14 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl93 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode13 = New System.Windows.Forms.GroupBox
Me.txtDescFR13 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl90 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR13 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl91 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode12 = New System.Windows.Forms.GroupBox
Me.txtDescFR12 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl88 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR12 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl89 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode11 = New System.Windows.Forms.GroupBox
Me.txtDescFR11 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl77 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR11 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl78 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode10 = New System.Windows.Forms.GroupBox
Me.txtDescFR10 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl74 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR10 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl76 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisdoe9 = New System.Windows.Forms.GroupBox
Me.txtDescFR9 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl72 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR9 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl73 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode8 = New System.Windows.Forms.GroupBox
Me.txtDescFR8 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR8 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode7 = New System.Windows.Forms.GroupBox
Me.txtDescFR7 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR7 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode6 = New System.Windows.Forms.GroupBox
Me.txtDescFR6 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR6 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode5 = New System.Windows.Forms.GroupBox
Me.txtDescFR5 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR5 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode4 = New System.Windows.Forms.GroupBox
Me.txtDescFR4 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR4 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode3 = New System.Windows.Forms.GroupBox
Me.txtDescFR3 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR3 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode2 = New System.Windows.Forms.GroupBox
Me.txtDescFR2 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR2 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
Me.grpEpisode1 = New System.Windows.Forms.GroupBox
Me.txtDescFR1 = New DevExpress.XtraEditors.MemoEdit
Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
Me.txtNameFR1 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
Me.txtAwardFR = New DevExpress.XtraEditors.MemoEdit
Me.pictFR = New DevExpress.XtraEditors.PictureEdit
Me.txtImageFR = New DevExpress.XtraEditors.TextEdit
Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl
Me.txtURLFr = New DevExpress.XtraEditors.TextEdit
Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl
Me.tabMain = New DevExpress.XtraTab.XtraTabPage
Me.grpVOD = New DevExpress.XtraEditors.GroupControl
Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl
Me.txtVODAudio = New DevExpress.XtraEditors.TextEdit
Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl
Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl
Me.grpActors = New DevExpress.XtraEditors.GroupControl
Me.GridActors = New DevExpress.XtraGrid.GridControl
Me.GridViewActors = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.colproducts_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colactors_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.cmbActors = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
Me.btnActorsMaint = New DevExpress.XtraEditors.SimpleButton
Me.grpImage = New DevExpress.XtraEditors.GroupControl
Me.PictProducts_Image = New DevExpress.XtraEditors.PictureEdit
Me.txtPictureImage = New DevExpress.XtraEditors.TextEdit
Me.grpSeries = New DevExpress.XtraEditors.GroupControl
Me.cmbVODSerieID = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl
Me.txtImdb_id_serie = New DevExpress.XtraEditors.TextEdit
Me.lblImdb_id_serie = New DevExpress.XtraEditors.LabelControl
Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
Me.txtABOSerieNbr = New DevExpress.XtraEditors.TextEdit
Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
Me.cmbABOSerie = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
Me.txtSerieNbr = New DevExpress.XtraEditors.TextEdit
Me.lblSerieNbr = New DevExpress.XtraEditors.LabelControl
Me.cmbSerie = New DevExpress.XtraEditors.LookUpEdit
Me.lblSeries = New DevExpress.XtraEditors.LabelControl
Me.grpMain = New DevExpress.XtraEditors.GroupControl
Me.txtSeason = New DevExpress.XtraEditors.SpinEdit
Me.txtEpisodesNumber = New DevExpress.XtraEditors.SpinEdit
Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl
Me.chkVodNextNL = New DevExpress.XtraEditors.CheckEdit
Me.chkVodNextLU = New DevExpress.XtraEditors.CheckEdit
Me.chkVodNext = New DevExpress.XtraEditors.CheckEdit
Me.cmbProducts_product_type = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
Me.txtIMDB_ID = New DevExpress.XtraEditors.TextEdit
Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
Me.txtTitle = New DevExpress.XtraEditors.TextEdit
Me.chkInTheBagsNext = New DevExpress.XtraEditors.CheckEdit
Me.chkInTheBags = New DevExpress.XtraEditors.CheckEdit
Me.chkInCinemaNow = New DevExpress.XtraEditors.CheckEdit
Me.chkProduct_Next = New DevExpress.XtraEditors.CheckEdit
Me.txtOtherProductID = New DevExpress.XtraEditors.TextEdit
Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
Me.chkGommetteNL = New DevExpress.XtraEditors.CheckEdit
Me.chkGommetteFR = New DevExpress.XtraEditors.CheckEdit
Me.cmbRating = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
Me.cmbAvailability = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
Me.cmbProducts_Media = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
Me.cmbProducts_Type = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
Me.cmbProducts_Status = New DevExpress.XtraEditors.LookUpEdit
Me.lblStatus = New DevExpress.XtraEditors.LabelControl
Me.cmbDirector = New DevExpress.XtraEditors.LookUpEdit
Me.cmbPictureFormat = New DevExpress.XtraEditors.LookUpEdit
Me.lblPictureFormat = New DevExpress.XtraEditors.LabelControl
Me.cmbPublic = New DevExpress.XtraEditors.LookUpEdit
Me.lblPublic = New DevExpress.XtraEditors.LabelControl
Me.cmbStudio = New DevExpress.XtraEditors.LookUpEdit
Me.lblStudio = New DevExpress.XtraEditors.LabelControl
Me.cmbcountry = New DevExpress.XtraEditors.LookUpEdit
Me.lblcountry = New DevExpress.XtraEditors.LabelControl
Me.txtRunTime = New DevExpress.XtraEditors.TextEdit
Me.lblRunTime = New DevExpress.XtraEditors.LabelControl
Me.txtYear = New DevExpress.XtraEditors.TextEdit
Me.lblYear = New DevExpress.XtraEditors.LabelControl
Me.txtDateAvailable = New DevExpress.XtraEditors.DateEdit
Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
Me.txtDateAdded = New DevExpress.XtraEditors.DateEdit
Me.txtQtyNow = New DevExpress.XtraEditors.TextEdit
Me.lblQtyNow = New DevExpress.XtraEditors.LabelControl
Me.txtQty = New DevExpress.XtraEditors.TextEdit
Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
Me.lblTitle = New DevExpress.XtraEditors.LabelControl
Me.txtModel = New DevExpress.XtraEditors.TextEdit
Me.lblModel = New DevExpress.XtraEditors.LabelControl
Me.txtProductID = New DevExpress.XtraEditors.TextEdit
Me.lblProductID = New DevExpress.XtraEditors.LabelControl
Me.XTabControlProduct = New DevExpress.XtraTab.XtraTabControl
CType(Me.PrintSystem1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MainDataSet,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbViewListRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtQuickSearchRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbReportListRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbFilterListRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDefaultListRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkSelectCategory,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.objDS,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbVODSerie.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PanelControl10,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl10.SuspendLayout
CType(Me.TextEdit3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox3.SuspendLayout
CType(Me.TextEdit11.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit12.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox4.SuspendLayout
CType(Me.TextEdit13.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit14.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox5.SuspendLayout
CType(Me.TextEdit15.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit16.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox6.SuspendLayout
CType(Me.TextEdit17.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit18.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SpinEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabVodWishlist.SuspendLayout
CType(Me.GridVODWishlist,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.gridViewVODWishlist,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView2,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabCritiques.SuspendLayout
CType(Me.GridCritiques,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewCritiques,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView3,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabVod.SuspendLayout
CType(Me.txtId.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbLanguageSubtitle.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbLanguageSound.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDateExpired.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDateExpired.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDateStart.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDateStart.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TxtFilename.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkAvailable.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtImdbView.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabGames.SuspendLayout
CType(Me.chkGameOnline.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtGame_ConfigMini.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtGame_NbrOfPlayersOnline.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtGame_NbrOfPlayers.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabTrailers.SuspendLayout
CType(Me.grpPictures,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpPictures.SuspendLayout
CType(Me.imgIMDBID_6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.imgIMDBID_5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.imgIMDBID_4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.imgIMDBID_3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.imgIMDBID_2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.imgIMDBID_1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.grpSoundTracks,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpSoundTracks.SuspendLayout
CType(Me.GridSoundtracks,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewSoundTracks,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbSoundTracks,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView6,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PanelControl9,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl9.SuspendLayout
CType(Me.grpTrailers,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpTrailers.SuspendLayout
Me.Panel2.SuspendLayout
CType(Me.GridStreamingTrailers,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.AdvBandedGridView2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryItemLookUpEdit1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryItemLookUpEdit2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryItemButtonEdit1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView5,System.ComponentModel.ISupportInitialize).BeginInit
Me.Panel1.SuspendLayout
CType(Me.GridTrailers,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewTrailers,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ButtonWatchTrailer,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbLangTrailer,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbTrailers_Broadcast,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PanelControl8,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabLanguages.SuspendLayout
CType(Me.grpSubTitles,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpSubTitles.SuspendLayout
CType(Me.GridUndertitles,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewUndertitles,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbUndertitles,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView8,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PanelControl5,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl5.SuspendLayout
CType(Me.grpLanguage,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpLanguage.SuspendLayout
CType(Me.GridLanguages,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewLanguages,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbLanguages1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView7,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PanelControl4,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl4.SuspendLayout
Me.tabTheme.SuspendLayout
CType(Me.PanelControl7,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl7.SuspendLayout
CType(Me.TreeListThemes,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkThemeSelected,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PanelControl12,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl12.SuspendLayout
CType(Me.PanelControl6,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl6.SuspendLayout
CType(Me.TreeListCategories,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PanelControl11,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl11.SuspendLayout
Me.tabEN.SuspendLayout
Me.Panel7.SuspendLayout
Me.Panel8.SuspendLayout
Me.GroupBox29.SuspendLayout
CType(Me.txtDescEN24.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN24.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox30.SuspendLayout
CType(Me.txtDescEN23.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN23.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox31.SuspendLayout
CType(Me.txtDescEN22.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN22.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox32.SuspendLayout
CType(Me.txtDescEN21.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN21.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox33.SuspendLayout
CType(Me.txtDescEN20.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN20.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox34.SuspendLayout
CType(Me.txtDescEN19.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN19.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox35.SuspendLayout
CType(Me.txtDescEN18.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN18.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox36.SuspendLayout
CType(Me.txtDescEN17.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN17.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox37.SuspendLayout
CType(Me.txtDescEN16.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN16.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox38.SuspendLayout
CType(Me.txtDescEN15.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN15.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox39.SuspendLayout
CType(Me.txtDescEN14.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN14.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox40.SuspendLayout
CType(Me.txtDescEN13.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN13.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox41.SuspendLayout
CType(Me.txtDescEN12.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN12.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox42.SuspendLayout
CType(Me.txtDescEN11.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN11.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox43.SuspendLayout
CType(Me.txtDescEN10.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN10.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox44.SuspendLayout
CType(Me.txtDescEN9.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN9.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox45.SuspendLayout
CType(Me.txtDescEN8.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN8.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox46.SuspendLayout
CType(Me.txtDescEN7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox47.SuspendLayout
CType(Me.txtDescEN6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox48.SuspendLayout
CType(Me.txtDescEN5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox49.SuspendLayout
CType(Me.txtDescEN4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox50.SuspendLayout
CType(Me.txtDescEN3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox51.SuspendLayout
CType(Me.txtDescEN2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox52.SuspendLayout
CType(Me.txtDescEN1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameEN1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtAwardEN.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.pictEN.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtImageEN.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtURLEn.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabNL.SuspendLayout
Me.Panel5.SuspendLayout
Me.Panel6.SuspendLayout
Me.GroupBox1.SuspendLayout
CType(Me.txtDescNL24.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL24.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox2.SuspendLayout
CType(Me.txtDescNL23.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL23.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox7.SuspendLayout
CType(Me.txtDescNL22.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL22.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox8.SuspendLayout
CType(Me.txtDescNL21.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL21.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox9.SuspendLayout
CType(Me.txtDescNL20.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL20.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox10.SuspendLayout
CType(Me.txtDescNL19.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL19.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox11.SuspendLayout
CType(Me.txtDescNL18.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL18.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox12.SuspendLayout
CType(Me.txtDescNL17.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL17.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox13.SuspendLayout
CType(Me.txtDescNL16.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL16.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox14.SuspendLayout
CType(Me.txtDescNL15.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL15.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox15.SuspendLayout
CType(Me.txtDescNL14.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL14.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox16.SuspendLayout
CType(Me.txtDescNL13.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL13.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox17.SuspendLayout
CType(Me.txtDescNL12.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL12.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox18.SuspendLayout
CType(Me.txtDescNL11.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL11.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox19.SuspendLayout
CType(Me.txtDescNL10.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL10.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox20.SuspendLayout
CType(Me.txtDescNL9.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL9.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox21.SuspendLayout
CType(Me.txtDescNL8.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL8.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox22.SuspendLayout
CType(Me.txtDescNL7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox23.SuspendLayout
CType(Me.txtDescNL6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox24.SuspendLayout
CType(Me.txtDescNL5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox25.SuspendLayout
CType(Me.txtDescNL4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox26.SuspendLayout
CType(Me.txtDescNL3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox27.SuspendLayout
CType(Me.txtDescNL2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupBox28.SuspendLayout
CType(Me.txtDescNL1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameNL1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtAwardNL.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.pictNL.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtImageNL.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtURLNl.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabFR.SuspendLayout
Me.Panel3.SuspendLayout
Me.Panel4.SuspendLayout
Me.grpEpisode24.SuspendLayout
CType(Me.txtDescFR24.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR24.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode23.SuspendLayout
CType(Me.txtDescFR23.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR23.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode22.SuspendLayout
CType(Me.txtDescFR22.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR22.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode21.SuspendLayout
CType(Me.txtDescFR21.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR21.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode20.SuspendLayout
CType(Me.txtDescFR20.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR20.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode19.SuspendLayout
CType(Me.txtDescFR19.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR19.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode18.SuspendLayout
CType(Me.txtDescFR18.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR18.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode17.SuspendLayout
CType(Me.txtDescFR17.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR17.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode16.SuspendLayout
CType(Me.txtDescFR16.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR16.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode15.SuspendLayout
CType(Me.txtDescFR15.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR15.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode14.SuspendLayout
CType(Me.txtDescFR14.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR14.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode13.SuspendLayout
CType(Me.txtDescFR13.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR13.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode12.SuspendLayout
CType(Me.txtDescFR12.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR12.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode11.SuspendLayout
CType(Me.txtDescFR11.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR11.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode10.SuspendLayout
CType(Me.txtDescFR10.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR10.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisdoe9.SuspendLayout
CType(Me.txtDescFR9.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR9.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode8.SuspendLayout
CType(Me.txtDescFR8.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR8.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode7.SuspendLayout
CType(Me.txtDescFR7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode6.SuspendLayout
CType(Me.txtDescFR6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode5.SuspendLayout
CType(Me.txtDescFR5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode4.SuspendLayout
CType(Me.txtDescFR4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode3.SuspendLayout
CType(Me.txtDescFR3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode2.SuspendLayout
CType(Me.txtDescFR2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpEpisode1.SuspendLayout
CType(Me.txtDescFR1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNameFR1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtAwardFR.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.pictFR.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtImageFR.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtURLFr.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabMain.SuspendLayout
CType(Me.grpVOD,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpVOD.SuspendLayout
CType(Me.TextEdit4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtVODAudio.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupControl2.SuspendLayout
CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PanelControl3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.grpActors,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpActors.SuspendLayout
CType(Me.GridActors,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewActors,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbActors,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView9,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl1.SuspendLayout
CType(Me.grpImage,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpImage.SuspendLayout
CType(Me.PictProducts_Image.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtPictureImage.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.grpSeries,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpSeries.SuspendLayout
CType(Me.cmbVODSerieID.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtImdb_id_serie.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtABOSerieNbr.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbABOSerie.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtSerieNbr.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbSerie.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.grpMain,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpMain.SuspendLayout
CType(Me.txtSeason.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtEpisodesNumber.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkVodNextNL.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkVodNextLU.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkVodNext.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbProducts_product_type.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtIMDB_ID.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtTitle.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkInTheBagsNext.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkInTheBags.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkInCinemaNow.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkProduct_Next.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtOtherProductID.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkGommetteNL.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkGommetteFR.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbRating.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbAvailability.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbProducts_Media.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbProducts_Type.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbProducts_Status.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDirector.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbPictureFormat.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbPublic.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbStudio.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbcountry.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtRunTime.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtYear.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDateAvailable.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDateAvailable.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDateAdded.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDateAdded.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtQtyNow.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtQty.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtModel.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtProductID.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.XTabControlProduct,System.ComponentModel.ISupportInitialize).BeginInit
Me.XTabControlProduct.SuspendLayout
Me.SuspendLayout
'
'PopMenuNew
'
'
'PopMenuEdit
'
'
'PopMenuSave
'
'
'PopMenuUndo
'
'
'StatusBar1
'
Me.StatusBar1.Location = New System.Drawing.Point(0, 795)
'
'colcategory_selected
'
Me.colcategory_selected.Caption = "category_selected"
Me.colcategory_selected.ColumnEdit = Me.chkSelectCategory
Me.colcategory_selected.FieldName = "category_selected"
Me.colcategory_selected.Name = "colcategory_selected"
Me.colcategory_selected.Visible = true
Me.colcategory_selected.VisibleIndex = 2
'
'chkSelectCategory
'
Me.chkSelectCategory.AutoHeight = false
Me.chkSelectCategory.Name = "chkSelectCategory"
Me.chkSelectCategory.ValueChecked = 1
Me.chkSelectCategory.ValueUnchecked = 0
'
'objDS
'
Me.objDS.DataSetName = "dsProducts"
Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'
'LabelControl63
'
Me.LabelControl63.Location = New System.Drawing.Point(14, 45)
Me.LabelControl63.Name = "LabelControl63"
Me.LabelControl63.Size = New System.Drawing.Size(37, 13)
Me.LabelControl63.TabIndex = 64
Me.LabelControl63.Text = "Episode"
'
'cmbVODSerie
'
Me.cmbVODSerie.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.serie_id", true))
Me.cmbVODSerie.Enabled = false
Me.cmbVODSerie.Location = New System.Drawing.Point(186, 42)
Me.cmbVODSerie.Name = "cmbVODSerie"
Me.cmbVODSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.cmbVODSerie.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbVODSerie.Properties.DataSource = Me.objDS.series
Me.cmbVODSerie.Properties.DisplayMember = "series_name"
Me.cmbVODSerie.Properties.NullText = ""
Me.cmbVODSerie.Properties.ValueMember = "series_id"
Me.cmbVODSerie.Size = New System.Drawing.Size(95, 20)
Me.cmbVODSerie.TabIndex = 67
'
'BandedGridColumn6
'
Me.BandedGridColumn6.Caption = "actors_id"
Me.BandedGridColumn6.FieldName = "actors_id"
Me.BandedGridColumn6.Name = "BandedGridColumn6"
Me.BandedGridColumn6.Visible = true
Me.BandedGridColumn6.Width = 237
'
'PanelControl10
'
Me.PanelControl10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl10.Controls.Add(Me.TextEdit3)
Me.PanelControl10.Controls.Add(Me.LabelControl38)
Me.PanelControl10.Controls.Add(Me.TextEdit2)
Me.PanelControl10.Controls.Add(Me.LabelControl37)
Me.PanelControl10.Controls.Add(Me.TextEdit1)
Me.PanelControl10.Controls.Add(Me.LabelControl36)
Me.PanelControl10.Dock = System.Windows.Forms.DockStyle.Top
Me.PanelControl10.Location = New System.Drawing.Point(0, 57)
Me.PanelControl10.Name = "PanelControl10"
Me.PanelControl10.Size = New System.Drawing.Size(1056, 39)
Me.PanelControl10.TabIndex = 36
'
'TextEdit3
'
Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_title", true))
Me.TextEdit3.Enabled = false
Me.TextEdit3.Location = New System.Drawing.Point(696, 8)
Me.TextEdit3.Name = "TextEdit3"
Me.TextEdit3.Size = New System.Drawing.Size(312, 20)
Me.TextEdit3.TabIndex = 9
'
'LabelControl38
'
Me.LabelControl38.Location = New System.Drawing.Point(608, 8)
Me.LabelControl38.Name = "LabelControl38"
Me.LabelControl38.Size = New System.Drawing.Size(20, 13)
Me.LabelControl38.TabIndex = 8
Me.LabelControl38.Text = "Title"
'
'TextEdit2
'
Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_model", true))
Me.TextEdit2.Enabled = false
Me.TextEdit2.Location = New System.Drawing.Point(304, 8)
Me.TextEdit2.Name = "TextEdit2"
Me.TextEdit2.Size = New System.Drawing.Size(296, 20)
Me.TextEdit2.TabIndex = 7
'
'LabelControl37
'
Me.LabelControl37.Location = New System.Drawing.Point(216, 8)
Me.LabelControl37.Name = "LabelControl37"
Me.LabelControl37.Size = New System.Drawing.Size(28, 13)
Me.LabelControl37.TabIndex = 6
Me.LabelControl37.Text = "Model"
'
'TextEdit1
'
Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_id", true))
Me.TextEdit1.Enabled = false
Me.TextEdit1.Location = New System.Drawing.Point(77, 6)
Me.TextEdit1.Name = "TextEdit1"
Me.TextEdit1.Size = New System.Drawing.Size(112, 20)
Me.TextEdit1.TabIndex = 2
'
'LabelControl36
'
Me.LabelControl36.Location = New System.Drawing.Point(8, 8)
Me.LabelControl36.Name = "LabelControl36"
Me.LabelControl36.Size = New System.Drawing.Size(51, 13)
Me.LabelControl36.TabIndex = 1
Me.LabelControl36.Text = "Product ID"
'
'LabelControl31
'
Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.LabelControl31.Appearance.Options.UseFont = true
Me.LabelControl31.Location = New System.Drawing.Point(300, 52)
Me.LabelControl31.Name = "LabelControl31"
Me.LabelControl31.Size = New System.Drawing.Size(13, 28)
Me.LabelControl31.TabIndex = 6
Me.LabelControl31.Text = "0"
'
'LabelControl33
'
Me.LabelControl33.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.LabelControl33.Appearance.Options.UseFont = true
Me.LabelControl33.Location = New System.Drawing.Point(254, 25)
Me.LabelControl33.Name = "LabelControl33"
Me.LabelControl33.Size = New System.Drawing.Size(152, 21)
Me.LabelControl33.TabIndex = 5
Me.LabelControl33.Text = "# Critiques positives"
'
'LabelControl34
'
Me.LabelControl34.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.LabelControl34.Appearance.Options.UseFont = true
Me.LabelControl34.Location = New System.Drawing.Point(198, 52)
Me.LabelControl34.Name = "LabelControl34"
Me.LabelControl34.Size = New System.Drawing.Size(13, 28)
Me.LabelControl34.TabIndex = 4
Me.LabelControl34.Text = "0"
'
'GridControl1
'
Me.GridControl1.EmbeddedNavigator.Name = ""
Me.GridControl1.FormsUseDefaultLookAndFeel = false
Me.GridControl1.Location = New System.Drawing.Point(9, 86)
Me.GridControl1.MainView = Me.GridView1
Me.GridControl1.Name = "GridControl1"
Me.GridControl1.Size = New System.Drawing.Size(1024, 443)
Me.GridControl1.TabIndex = 0
Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
'
'GridView1
'
Me.GridView1.GridControl = Me.GridControl1
Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "products_id", Nothing, "")})
Me.GridView1.Name = "GridView1"
Me.GridView1.OptionsView.ShowFooter = true
'
'LabelControl35
'
Me.LabelControl35.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.LabelControl35.Appearance.Options.UseFont = true
Me.LabelControl35.Location = New System.Drawing.Point(152, 25)
Me.LabelControl35.Name = "LabelControl35"
Me.LabelControl35.Size = New System.Drawing.Size(82, 21)
Me.LabelControl35.TabIndex = 3
Me.LabelControl35.Text = "# Critiques"
'
'LabelControl58
'
Me.LabelControl58.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.LabelControl58.Appearance.Options.UseFont = true
Me.LabelControl58.Location = New System.Drawing.Point(67, 52)
Me.LabelControl58.Name = "LabelControl58"
Me.LabelControl58.Size = New System.Drawing.Size(13, 28)
Me.LabelControl58.TabIndex = 2
Me.LabelControl58.Text = "0"
'
'LabelControl59
'
Me.LabelControl59.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.LabelControl59.Appearance.Options.UseFont = true
Me.LabelControl59.Location = New System.Drawing.Point(21, 25)
Me.LabelControl59.Name = "LabelControl59"
Me.LabelControl59.Size = New System.Drawing.Size(101, 21)
Me.LabelControl59.TabIndex = 1
Me.LabelControl59.Text = "Rating Moyen"
'
'GroupBox3
'
Me.GroupBox3.Controls.Add(Me.LabelControl64)
Me.GroupBox3.Controls.Add(Me.TextEdit11)
Me.GroupBox3.Controls.Add(Me.LabelControl67)
Me.GroupBox3.Controls.Add(Me.LookUpEdit4)
Me.GroupBox3.Controls.Add(Me.TextEdit12)
Me.GroupBox3.Controls.Add(Me.LabelControl71)
Me.GroupBox3.Location = New System.Drawing.Point(18, 325)
Me.GroupBox3.Name = "GroupBox3"
Me.GroupBox3.Size = New System.Drawing.Size(293, 78)
Me.GroupBox3.TabIndex = 74
Me.GroupBox3.TabStop = false
Me.GroupBox3.Text = "Episode "
'
'LabelControl64
'
Me.LabelControl64.Location = New System.Drawing.Point(14, 19)
Me.LabelControl64.Name = "LabelControl64"
Me.LabelControl64.Size = New System.Drawing.Size(35, 13)
Me.LabelControl64.TabIndex = 62
Me.LabelControl64.Text = "Season"
'
'TextEdit11
'
Me.TextEdit11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.season_id", true))
Me.TextEdit11.Enabled = false
Me.TextEdit11.Location = New System.Drawing.Point(60, 16)
Me.TextEdit11.Name = "TextEdit11"
Me.TextEdit11.Size = New System.Drawing.Size(104, 20)
Me.TextEdit11.TabIndex = 61
'
'LabelControl67
'
Me.LabelControl67.Location = New System.Drawing.Point(14, 45)
Me.LabelControl67.Name = "LabelControl67"
Me.LabelControl67.Size = New System.Drawing.Size(37, 13)
Me.LabelControl67.TabIndex = 64
Me.LabelControl67.Text = "Episode"
'
'LookUpEdit4
'
Me.LookUpEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.serie_id", true))
Me.LookUpEdit4.Enabled = false
Me.LookUpEdit4.Location = New System.Drawing.Point(186, 42)
Me.LookUpEdit4.Name = "LookUpEdit4"
Me.LookUpEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.LookUpEdit4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit4.Properties.DataSource = Me.objDS.series
Me.LookUpEdit4.Properties.DisplayMember = "series_name"
Me.LookUpEdit4.Properties.NullText = ""
Me.LookUpEdit4.Properties.ValueMember = "series_id"
Me.LookUpEdit4.Size = New System.Drawing.Size(95, 20)
Me.LookUpEdit4.TabIndex = 67
'
'TextEdit12
'
Me.TextEdit12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.episode_id", true))
Me.TextEdit12.Enabled = false
Me.TextEdit12.Location = New System.Drawing.Point(60, 42)
Me.TextEdit12.Name = "TextEdit12"
Me.TextEdit12.Size = New System.Drawing.Size(104, 20)
Me.TextEdit12.TabIndex = 63
'
'LabelControl71
'
Me.LabelControl71.Location = New System.Drawing.Point(186, 19)
Me.LabelControl71.Name = "LabelControl71"
Me.LabelControl71.Size = New System.Drawing.Size(38, 13)
Me.LabelControl71.TabIndex = 66
Me.LabelControl71.Text = "Serie ID"
'
'GroupBox4
'
Me.GroupBox4.Controls.Add(Me.LabelControl75)
Me.GroupBox4.Controls.Add(Me.TextEdit13)
Me.GroupBox4.Controls.Add(Me.LabelControl79)
Me.GroupBox4.Controls.Add(Me.LookUpEdit5)
Me.GroupBox4.Controls.Add(Me.TextEdit14)
Me.GroupBox4.Controls.Add(Me.LabelControl80)
Me.GroupBox4.Location = New System.Drawing.Point(18, 231)
Me.GroupBox4.Name = "GroupBox4"
Me.GroupBox4.Size = New System.Drawing.Size(293, 78)
Me.GroupBox4.TabIndex = 73
Me.GroupBox4.TabStop = false
Me.GroupBox4.Text = "Episode "
'
'LabelControl75
'
Me.LabelControl75.Location = New System.Drawing.Point(14, 19)
Me.LabelControl75.Name = "LabelControl75"
Me.LabelControl75.Size = New System.Drawing.Size(35, 13)
Me.LabelControl75.TabIndex = 62
Me.LabelControl75.Text = "Season"
'
'TextEdit13
'
Me.TextEdit13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.season_id", true))
Me.TextEdit13.Enabled = false
Me.TextEdit13.Location = New System.Drawing.Point(60, 16)
Me.TextEdit13.Name = "TextEdit13"
Me.TextEdit13.Size = New System.Drawing.Size(104, 20)
Me.TextEdit13.TabIndex = 61
'
'LabelControl79
'
Me.LabelControl79.Location = New System.Drawing.Point(14, 45)
Me.LabelControl79.Name = "LabelControl79"
Me.LabelControl79.Size = New System.Drawing.Size(37, 13)
Me.LabelControl79.TabIndex = 64
Me.LabelControl79.Text = "Episode"
'
'LookUpEdit5
'
Me.LookUpEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.serie_id", true))
Me.LookUpEdit5.Enabled = false
Me.LookUpEdit5.Location = New System.Drawing.Point(186, 42)
Me.LookUpEdit5.Name = "LookUpEdit5"
Me.LookUpEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.LookUpEdit5.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit5.Properties.DataSource = Me.objDS.series
Me.LookUpEdit5.Properties.DisplayMember = "series_name"
Me.LookUpEdit5.Properties.NullText = ""
Me.LookUpEdit5.Properties.ValueMember = "series_id"
Me.LookUpEdit5.Size = New System.Drawing.Size(95, 20)
Me.LookUpEdit5.TabIndex = 67
'
'TextEdit14
'
Me.TextEdit14.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.episode_id", true))
Me.TextEdit14.Enabled = false
Me.TextEdit14.Location = New System.Drawing.Point(60, 42)
Me.TextEdit14.Name = "TextEdit14"
Me.TextEdit14.Size = New System.Drawing.Size(104, 20)
Me.TextEdit14.TabIndex = 63
'
'LabelControl80
'
Me.LabelControl80.Location = New System.Drawing.Point(186, 23)
Me.LabelControl80.Name = "LabelControl80"
Me.LabelControl80.Size = New System.Drawing.Size(38, 13)
Me.LabelControl80.TabIndex = 66
Me.LabelControl80.Text = "Serie ID"
'
'GroupBox5
'
Me.GroupBox5.Controls.Add(Me.LabelControl81)
Me.GroupBox5.Controls.Add(Me.TextEdit15)
Me.GroupBox5.Controls.Add(Me.LabelControl82)
Me.GroupBox5.Controls.Add(Me.LookUpEdit6)
Me.GroupBox5.Controls.Add(Me.TextEdit16)
Me.GroupBox5.Controls.Add(Me.LabelControl83)
Me.GroupBox5.Location = New System.Drawing.Point(18, 147)
Me.GroupBox5.Name = "GroupBox5"
Me.GroupBox5.Size = New System.Drawing.Size(293, 78)
Me.GroupBox5.TabIndex = 72
Me.GroupBox5.TabStop = false
Me.GroupBox5.Text = "Episode "
'
'LabelControl81
'
Me.LabelControl81.Location = New System.Drawing.Point(14, 19)
Me.LabelControl81.Name = "LabelControl81"
Me.LabelControl81.Size = New System.Drawing.Size(35, 13)
Me.LabelControl81.TabIndex = 62
Me.LabelControl81.Text = "Season"
'
'TextEdit15
'
Me.TextEdit15.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.season_id", true))
Me.TextEdit15.Enabled = false
Me.TextEdit15.Location = New System.Drawing.Point(60, 16)
Me.TextEdit15.Name = "TextEdit15"
Me.TextEdit15.Size = New System.Drawing.Size(104, 20)
Me.TextEdit15.TabIndex = 61
'
'LabelControl82
'
Me.LabelControl82.Location = New System.Drawing.Point(14, 45)
Me.LabelControl82.Name = "LabelControl82"
Me.LabelControl82.Size = New System.Drawing.Size(37, 13)
Me.LabelControl82.TabIndex = 64
Me.LabelControl82.Text = "Episode"
'
'LookUpEdit6
'
Me.LookUpEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.serie_id", true))
Me.LookUpEdit6.Enabled = false
Me.LookUpEdit6.Location = New System.Drawing.Point(186, 42)
Me.LookUpEdit6.Name = "LookUpEdit6"
Me.LookUpEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.LookUpEdit6.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit6.Properties.DataSource = Me.objDS.series
Me.LookUpEdit6.Properties.DisplayMember = "series_name"
Me.LookUpEdit6.Properties.NullText = ""
Me.LookUpEdit6.Properties.ValueMember = "series_id"
Me.LookUpEdit6.Size = New System.Drawing.Size(95, 20)
Me.LookUpEdit6.TabIndex = 67
'
'TextEdit16
'
Me.TextEdit16.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.episode_id", true))
Me.TextEdit16.Enabled = false
Me.TextEdit16.Location = New System.Drawing.Point(60, 42)
Me.TextEdit16.Name = "TextEdit16"
Me.TextEdit16.Size = New System.Drawing.Size(104, 20)
Me.TextEdit16.TabIndex = 63
'
'LabelControl83
'
Me.LabelControl83.Location = New System.Drawing.Point(186, 23)
Me.LabelControl83.Name = "LabelControl83"
Me.LabelControl83.Size = New System.Drawing.Size(38, 13)
Me.LabelControl83.TabIndex = 66
Me.LabelControl83.Text = "Serie ID"
'
'GroupBox6
'
Me.GroupBox6.Controls.Add(Me.LabelControl84)
Me.GroupBox6.Controls.Add(Me.TextEdit17)
Me.GroupBox6.Controls.Add(Me.LabelControl85)
Me.GroupBox6.Controls.Add(Me.LookUpEdit7)
Me.GroupBox6.Controls.Add(Me.TextEdit18)
Me.GroupBox6.Controls.Add(Me.LabelControl86)
Me.GroupBox6.Location = New System.Drawing.Point(18, 53)
Me.GroupBox6.Name = "GroupBox6"
Me.GroupBox6.Size = New System.Drawing.Size(293, 78)
Me.GroupBox6.TabIndex = 71
Me.GroupBox6.TabStop = false
Me.GroupBox6.Text = "Episode "
'
'LabelControl84
'
Me.LabelControl84.Location = New System.Drawing.Point(14, 19)
Me.LabelControl84.Name = "LabelControl84"
Me.LabelControl84.Size = New System.Drawing.Size(35, 13)
Me.LabelControl84.TabIndex = 62
Me.LabelControl84.Text = "Season"
'
'TextEdit17
'
Me.TextEdit17.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.season_id", true))
Me.TextEdit17.Enabled = false
Me.TextEdit17.Location = New System.Drawing.Point(60, 16)
Me.TextEdit17.Name = "TextEdit17"
Me.TextEdit17.Size = New System.Drawing.Size(104, 20)
Me.TextEdit17.TabIndex = 61
'
'LabelControl85
'
Me.LabelControl85.Location = New System.Drawing.Point(14, 45)
Me.LabelControl85.Name = "LabelControl85"
Me.LabelControl85.Size = New System.Drawing.Size(37, 13)
Me.LabelControl85.TabIndex = 64
Me.LabelControl85.Text = "Episode"
'
'LookUpEdit7
'
Me.LookUpEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.serie_id", true))
Me.LookUpEdit7.Enabled = false
Me.LookUpEdit7.Location = New System.Drawing.Point(186, 42)
Me.LookUpEdit7.Name = "LookUpEdit7"
Me.LookUpEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.LookUpEdit7.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit7.Properties.DataSource = Me.objDS.series
Me.LookUpEdit7.Properties.DisplayMember = "series_name"
Me.LookUpEdit7.Properties.NullText = ""
Me.LookUpEdit7.Properties.ValueMember = "series_id"
Me.LookUpEdit7.Size = New System.Drawing.Size(95, 20)
Me.LookUpEdit7.TabIndex = 67
'
'TextEdit18
'
Me.TextEdit18.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.episode_id", true))
Me.TextEdit18.Enabled = false
Me.TextEdit18.Location = New System.Drawing.Point(60, 42)
Me.TextEdit18.Name = "TextEdit18"
Me.TextEdit18.Size = New System.Drawing.Size(104, 20)
Me.TextEdit18.TabIndex = 63
'
'LabelControl86
'
Me.LabelControl86.Location = New System.Drawing.Point(186, 23)
Me.LabelControl86.Name = "LabelControl86"
Me.LabelControl86.Size = New System.Drawing.Size(38, 13)
Me.LabelControl86.TabIndex = 66
Me.LabelControl86.Text = "Serie ID"
'
'SimpleButton1
'
Me.SimpleButton1.Location = New System.Drawing.Point(301, 14)
Me.SimpleButton1.Name = "SimpleButton1"
Me.SimpleButton1.Size = New System.Drawing.Size(112, 23)
Me.SimpleButton1.TabIndex = 70
Me.SimpleButton1.Text = "Set Episodes"
'
'SpinEdit1
'
Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.SpinEdit1.Location = New System.Drawing.Point(159, 17)
Me.SpinEdit1.Name = "SpinEdit1"
Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.SpinEdit1.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
Me.SpinEdit1.Size = New System.Drawing.Size(104, 20)
Me.SpinEdit1.TabIndex = 69
'
'LabelControl87
'
Me.LabelControl87.Location = New System.Drawing.Point(27, 20)
Me.LabelControl87.Name = "LabelControl87"
Me.LabelControl87.Size = New System.Drawing.Size(104, 13)
Me.LabelControl87.TabIndex = 68
Me.LabelControl87.Text = "# VOD Serie Episodes"
'
'tabVodWishlist
'
Me.tabVodWishlist.Controls.Add(Me.GridVODWishlist)
Me.tabVodWishlist.Name = "tabVodWishlist"
Me.tabVodWishlist.Size = New System.Drawing.Size(1047, 690)
Me.tabVodWishlist.Text = "VODWishlist"
'
'GridVODWishlist
'
Me.GridVODWishlist.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridVODWishlist.EmbeddedNavigator.Name = ""
Me.GridVODWishlist.FormsUseDefaultLookAndFeel = false
Me.GridVODWishlist.Location = New System.Drawing.Point(0, 0)
Me.GridVODWishlist.MainView = Me.gridViewVODWishlist
Me.GridVODWishlist.Name = "GridVODWishlist"
Me.GridVODWishlist.Size = New System.Drawing.Size(1047, 690)
Me.GridVODWishlist.TabIndex = 2
Me.GridVODWishlist.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewVODWishlist, Me.GridView2})
'
'gridViewVODWishlist
'
Me.gridViewVODWishlist.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand12})
Me.gridViewVODWishlist.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
Me.gridViewVODWishlist.GridControl = Me.GridVODWishlist
Me.gridViewVODWishlist.Name = "gridViewVODWishlist"
Me.gridViewVODWishlist.OptionsBehavior.Editable = false
Me.gridViewVODWishlist.OptionsView.ShowFooter = true
'
'GridBand12
'
Me.GridBand12.Caption = "GridBand12"
Me.GridBand12.Name = "GridBand12"
'
'GridView2
'
Me.GridView2.GridControl = Me.GridVODWishlist
Me.GridView2.Name = "GridView2"
'
'tabCritiques
'
Me.tabCritiques.Controls.Add(Me.lblValueNBRating)
Me.tabCritiques.Controls.Add(Me.lblNbRating)
Me.tabCritiques.Controls.Add(Me.lblValueNbCritiquePositive)
Me.tabCritiques.Controls.Add(Me.lblNbCritiquePositive)
Me.tabCritiques.Controls.Add(Me.lblValueNbCrtitiques)
Me.tabCritiques.Controls.Add(Me.lblNbCritiques)
Me.tabCritiques.Controls.Add(Me.lblValueRatingAverage)
Me.tabCritiques.Controls.Add(Me.lblRatingAverage)
Me.tabCritiques.Controls.Add(Me.GridCritiques)
Me.tabCritiques.Name = "tabCritiques"
Me.tabCritiques.Size = New System.Drawing.Size(1047, 690)
Me.tabCritiques.Text = "Critiques"
'
'lblValueNBRating
'
Me.lblValueNBRating.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblValueNBRating.Appearance.Options.UseFont = true
Me.lblValueNBRating.Location = New System.Drawing.Point(289, 62)
Me.lblValueNBRating.Name = "lblValueNBRating"
Me.lblValueNBRating.Size = New System.Drawing.Size(10, 22)
Me.lblValueNBRating.TabIndex = 15
Me.lblValueNBRating.Text = "0"
'
'lblNbRating
'
Me.lblNbRating.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblNbRating.Appearance.Options.UseFont = true
Me.lblNbRating.Location = New System.Drawing.Point(134, 68)
Me.lblNbRating.Name = "lblNbRating"
Me.lblNbRating.Size = New System.Drawing.Size(53, 17)
Me.lblNbRating.TabIndex = 14
Me.lblNbRating.Text = "# Rating"
'
'lblValueNbCritiquePositive
'
Me.lblValueNbCritiquePositive.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblValueNbCritiquePositive.Appearance.Options.UseFont = true
Me.lblValueNbCritiquePositive.Location = New System.Drawing.Point(289, 27)
Me.lblValueNbCritiquePositive.Name = "lblValueNbCritiquePositive"
Me.lblValueNbCritiquePositive.Size = New System.Drawing.Size(10, 22)
Me.lblValueNbCritiquePositive.TabIndex = 13
Me.lblValueNbCritiquePositive.Text = "0"
'
'lblNbCritiquePositive
'
Me.lblNbCritiquePositive.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblNbCritiquePositive.Appearance.Options.UseFont = true
Me.lblNbCritiquePositive.Location = New System.Drawing.Point(134, 32)
Me.lblNbCritiquePositive.Name = "lblNbCritiquePositive"
Me.lblNbCritiquePositive.Size = New System.Drawing.Size(138, 17)
Me.lblNbCritiquePositive.TabIndex = 12
Me.lblNbCritiquePositive.Text = "# Critiques pertinentes"
'
'lblValueNbCrtitiques
'
Me.lblValueNbCrtitiques.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblValueNbCrtitiques.Appearance.Options.UseFont = true
Me.lblValueNbCrtitiques.Location = New System.Drawing.Point(289, -3)
Me.lblValueNbCrtitiques.Name = "lblValueNbCrtitiques"
Me.lblValueNbCrtitiques.Size = New System.Drawing.Size(10, 22)
Me.lblValueNbCrtitiques.TabIndex = 11
Me.lblValueNbCrtitiques.Text = "0"
'
'lblNbCritiques
'
Me.lblNbCritiques.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblNbCritiques.Appearance.Options.UseFont = true
Me.lblNbCritiques.Location = New System.Drawing.Point(132, 3)
Me.lblNbCritiques.Name = "lblNbCritiques"
Me.lblNbCritiques.Size = New System.Drawing.Size(66, 17)
Me.lblNbCritiques.TabIndex = 10
Me.lblNbCritiques.Text = "# Critiques"
'
'lblValueRatingAverage
'
Me.lblValueRatingAverage.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblValueRatingAverage.Appearance.Options.UseFont = true
Me.lblValueRatingAverage.Location = New System.Drawing.Point(455, -3)
Me.lblValueRatingAverage.Name = "lblValueRatingAverage"
Me.lblValueRatingAverage.Size = New System.Drawing.Size(10, 22)
Me.lblValueRatingAverage.TabIndex = 9
Me.lblValueRatingAverage.Text = "0"
'
'lblRatingAverage
'
Me.lblRatingAverage.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblRatingAverage.Appearance.Options.UseFont = true
Me.lblRatingAverage.Location = New System.Drawing.Point(352, 3)
Me.lblRatingAverage.Name = "lblRatingAverage"
Me.lblRatingAverage.Size = New System.Drawing.Size(84, 17)
Me.lblRatingAverage.TabIndex = 8
Me.lblRatingAverage.Text = "Rating Moyen"
'
'GridCritiques
'
Me.GridCritiques.EmbeddedNavigator.Name = ""
Me.GridCritiques.FormsUseDefaultLookAndFeel = false
Me.GridCritiques.Location = New System.Drawing.Point(9, 97)
Me.GridCritiques.MainView = Me.GridViewCritiques
Me.GridCritiques.Name = "GridCritiques"
Me.GridCritiques.Size = New System.Drawing.Size(861, 384)
Me.GridCritiques.TabIndex = 7
Me.GridCritiques.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCritiques, Me.GridView3})
'
'GridViewCritiques
'
Me.GridViewCritiques.GridControl = Me.GridCritiques
Me.GridViewCritiques.Name = "GridViewCritiques"
Me.GridViewCritiques.OptionsView.ShowFooter = true
'
'GridView3
'
Me.GridView3.GridControl = Me.GridCritiques
Me.GridView3.Name = "GridView3"
'
'tabVod
'
Me.tabVod.Controls.Add(Me.txtId)
Me.tabVod.Controls.Add(Me.btnCancelVod)
Me.tabVod.Controls.Add(Me.cmbLanguageSubtitle)
Me.tabVod.Controls.Add(Me.cmbLanguageSound)
Me.tabVod.Controls.Add(Me.cmbDateExpired)
Me.tabVod.Controls.Add(Me.cmbDateStart)
Me.tabVod.Controls.Add(Me.TxtFilename)
Me.tabVod.Controls.Add(Me.chkAvailable)
Me.tabVod.Controls.Add(Me.lblAvailable)
Me.tabVod.Controls.Add(Me.lblNameFile)
Me.tabVod.Controls.Add(Me.lblDateExpired)
Me.tabVod.Controls.Add(Me.lblDateStart)
Me.tabVod.Controls.Add(Me.lblLanguage_subtitle)
Me.tabVod.Controls.Add(Me.lblLanguageSound)
Me.tabVod.Controls.Add(Me.txtImdbView)
Me.tabVod.Controls.Add(Me.lblImdbView)
Me.tabVod.Controls.Add(Me.btnSaveVod)
Me.tabVod.Controls.Add(Me.btnEditVod)
Me.tabVod.Name = "tabVod"
Me.tabVod.PageVisible = false
Me.tabVod.Size = New System.Drawing.Size(1047, 690)
Me.tabVod.Text = "Vod"
'
'txtId
'
Me.txtId.Enabled = false
Me.txtId.Location = New System.Drawing.Point(401, 71)
Me.txtId.Name = "txtId"
Me.txtId.Size = New System.Drawing.Size(112, 20)
Me.txtId.TabIndex = 91
'
'btnCancelVod
'
Me.btnCancelVod.Location = New System.Drawing.Point(239, 28)
Me.btnCancelVod.Name = "btnCancelVod"
Me.btnCancelVod.Size = New System.Drawing.Size(75, 23)
Me.btnCancelVod.TabIndex = 90
Me.btnCancelVod.Text = "Cancel"
'
'cmbLanguageSubtitle
'
Me.cmbLanguageSubtitle.Location = New System.Drawing.Point(135, 184)
Me.cmbLanguageSubtitle.Name = "cmbLanguageSubtitle"
Me.cmbLanguageSubtitle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbLanguageSubtitle.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbLanguageSubtitle.Properties.DisplayMember = "status_desc"
Me.cmbLanguageSubtitle.Properties.NullText = ""
Me.cmbLanguageSubtitle.Properties.ValueMember = "status_id"
Me.cmbLanguageSubtitle.Size = New System.Drawing.Size(112, 20)
Me.cmbLanguageSubtitle.TabIndex = 89
'
'cmbLanguageSound
'
Me.cmbLanguageSound.Location = New System.Drawing.Point(135, 136)
Me.cmbLanguageSound.Name = "cmbLanguageSound"
Me.cmbLanguageSound.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbLanguageSound.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "id", 63, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("code", "code", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbLanguageSound.Properties.DisplayMember = "status_desc"
Me.cmbLanguageSound.Properties.NullText = ""
Me.cmbLanguageSound.Properties.ValueMember = "status_id"
Me.cmbLanguageSound.Size = New System.Drawing.Size(112, 20)
Me.cmbLanguageSound.TabIndex = 88
'
'cmbDateExpired
'
Me.cmbDateExpired.EditValue = Nothing
Me.cmbDateExpired.Location = New System.Drawing.Point(135, 272)
Me.cmbDateExpired.Name = "cmbDateExpired"
Me.cmbDateExpired.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbDateExpired.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.cmbDateExpired.Size = New System.Drawing.Size(112, 20)
Me.cmbDateExpired.TabIndex = 87
'
'cmbDateStart
'
Me.cmbDateStart.EditValue = Nothing
Me.cmbDateStart.Location = New System.Drawing.Point(135, 226)
Me.cmbDateStart.Name = "cmbDateStart"
Me.cmbDateStart.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbDateStart.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.cmbDateStart.Size = New System.Drawing.Size(112, 20)
Me.cmbDateStart.TabIndex = 86
'
'TxtFilename
'
Me.TxtFilename.Enabled = false
Me.TxtFilename.Location = New System.Drawing.Point(135, 325)
Me.TxtFilename.Name = "TxtFilename"
Me.TxtFilename.Size = New System.Drawing.Size(179, 20)
Me.TxtFilename.TabIndex = 85
'
'chkAvailable
'
Me.chkAvailable.Location = New System.Drawing.Point(133, 371)
Me.chkAvailable.Name = "chkAvailable"
Me.chkAvailable.Properties.Caption = ""
Me.chkAvailable.Size = New System.Drawing.Size(56, 19)
Me.chkAvailable.TabIndex = 84
'
'lblAvailable
'
Me.lblAvailable.Location = New System.Drawing.Point(40, 374)
Me.lblAvailable.Name = "lblAvailable"
Me.lblAvailable.Size = New System.Drawing.Size(42, 13)
Me.lblAvailable.TabIndex = 83
Me.lblAvailable.Text = "available"
'
'lblNameFile
'
Me.lblNameFile.Location = New System.Drawing.Point(40, 332)
Me.lblNameFile.Name = "lblNameFile"
Me.lblNameFile.Size = New System.Drawing.Size(43, 13)
Me.lblNameFile.TabIndex = 82
Me.lblNameFile.Text = "file name"
'
'lblDateExpired
'
Me.lblDateExpired.Location = New System.Drawing.Point(40, 279)
Me.lblDateExpired.Name = "lblDateExpired"
Me.lblDateExpired.Size = New System.Drawing.Size(61, 13)
Me.lblDateExpired.TabIndex = 81
Me.lblDateExpired.Text = "date expired"
'
'lblDateStart
'
Me.lblDateStart.Location = New System.Drawing.Point(40, 233)
Me.lblDateStart.Name = "lblDateStart"
Me.lblDateStart.Size = New System.Drawing.Size(48, 13)
Me.lblDateStart.TabIndex = 80
Me.lblDateStart.Text = "date start"
'
'lblLanguage_subtitle
'
Me.lblLanguage_subtitle.Location = New System.Drawing.Point(40, 187)
Me.lblLanguage_subtitle.Name = "lblLanguage_subtitle"
Me.lblLanguage_subtitle.Size = New System.Drawing.Size(82, 13)
Me.lblLanguage_subtitle.TabIndex = 79
Me.lblLanguage_subtitle.Text = "language subtitle"
'
'lblLanguageSound
'
Me.lblLanguageSound.Location = New System.Drawing.Point(40, 139)
Me.lblLanguageSound.Name = "lblLanguageSound"
Me.lblLanguageSound.Size = New System.Drawing.Size(76, 13)
Me.lblLanguageSound.TabIndex = 78
Me.lblLanguageSound.Text = "language sound"
'
'txtImdbView
'
Me.txtImdbView.Location = New System.Drawing.Point(135, 101)
Me.txtImdbView.Name = "txtImdbView"
Me.txtImdbView.Size = New System.Drawing.Size(112, 20)
Me.txtImdbView.TabIndex = 77
'
'lblImdbView
'
Me.lblImdbView.Location = New System.Drawing.Point(40, 104)
Me.lblImdbView.Name = "lblImdbView"
Me.lblImdbView.Size = New System.Drawing.Size(38, 13)
Me.lblImdbView.TabIndex = 76
Me.lblImdbView.Text = "Imdb ID"
'
'btnSaveVod
'
Me.btnSaveVod.Location = New System.Drawing.Point(40, 28)
Me.btnSaveVod.Name = "btnSaveVod"
Me.btnSaveVod.Size = New System.Drawing.Size(75, 23)
Me.btnSaveVod.TabIndex = 75
Me.btnSaveVod.Text = "Save"
'
'btnEditVod
'
Me.btnEditVod.Location = New System.Drawing.Point(135, 28)
Me.btnEditVod.Name = "btnEditVod"
Me.btnEditVod.Size = New System.Drawing.Size(79, 23)
Me.btnEditVod.TabIndex = 74
Me.btnEditVod.Text = "Edit"
'
'tabGames
'
Me.tabGames.Controls.Add(Me.chkGameOnline)
Me.tabGames.Controls.Add(Me.txtGame_ConfigMini)
Me.tabGames.Controls.Add(Me.LabelControl55)
Me.tabGames.Controls.Add(Me.txtGame_NbrOfPlayersOnline)
Me.tabGames.Controls.Add(Me.LabelControl54)
Me.tabGames.Controls.Add(Me.txtGame_NbrOfPlayers)
Me.tabGames.Controls.Add(Me.LabelControl53)
Me.tabGames.Name = "tabGames"
Me.tabGames.Size = New System.Drawing.Size(1047, 690)
Me.tabGames.Text = "Games"
'
'chkGameOnline
'
Me.chkGameOnline.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.game_online", true))
Me.chkGameOnline.EditValue = 0
Me.chkGameOnline.Enabled = false
Me.chkGameOnline.Location = New System.Drawing.Point(36, 49)
Me.chkGameOnline.Name = "chkGameOnline"
Me.chkGameOnline.Properties.Caption = "Online"
Me.chkGameOnline.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
Me.chkGameOnline.Properties.ValueChecked = 1
Me.chkGameOnline.Properties.ValueUnchecked = 0
Me.chkGameOnline.Size = New System.Drawing.Size(133, 19)
Me.chkGameOnline.TabIndex = 42
'
'txtGame_ConfigMini
'
Me.txtGame_ConfigMini.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.game_config_mini", true))
Me.txtGame_ConfigMini.Enabled = false
Me.txtGame_ConfigMini.Location = New System.Drawing.Point(153, 100)
Me.txtGame_ConfigMini.Name = "txtGame_ConfigMini"
Me.txtGame_ConfigMini.Size = New System.Drawing.Size(408, 80)
Me.txtGame_ConfigMini.TabIndex = 13
'
'LabelControl55
'
Me.LabelControl55.Location = New System.Drawing.Point(41, 103)
Me.LabelControl55.Name = "LabelControl55"
Me.LabelControl55.Size = New System.Drawing.Size(74, 13)
Me.LabelControl55.TabIndex = 12
Me.LabelControl55.Text = "Config Minimum"
'
'txtGame_NbrOfPlayersOnline
'
Me.txtGame_NbrOfPlayersOnline.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.game_nbr_of_players_online", true))
Me.txtGame_NbrOfPlayersOnline.Enabled = false
Me.txtGame_NbrOfPlayersOnline.Location = New System.Drawing.Point(153, 74)
Me.txtGame_NbrOfPlayersOnline.Name = "txtGame_NbrOfPlayersOnline"
Me.txtGame_NbrOfPlayersOnline.Size = New System.Drawing.Size(112, 20)
Me.txtGame_NbrOfPlayersOnline.TabIndex = 11
'
'LabelControl54
'
Me.LabelControl54.Location = New System.Drawing.Point(41, 77)
Me.LabelControl54.Name = "LabelControl54"
Me.LabelControl54.Size = New System.Drawing.Size(103, 13)
Me.LabelControl54.TabIndex = 10
Me.LabelControl54.Text = "Nbr Of Players Online"
'
'txtGame_NbrOfPlayers
'
Me.txtGame_NbrOfPlayers.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.game_nbr_of_players", true))
Me.txtGame_NbrOfPlayers.Enabled = false
Me.txtGame_NbrOfPlayers.Location = New System.Drawing.Point(153, 20)
Me.txtGame_NbrOfPlayers.Name = "txtGame_NbrOfPlayers"
Me.txtGame_NbrOfPlayers.Size = New System.Drawing.Size(112, 20)
Me.txtGame_NbrOfPlayers.TabIndex = 9
'
'LabelControl53
'
Me.LabelControl53.Location = New System.Drawing.Point(41, 23)
Me.LabelControl53.Name = "LabelControl53"
Me.LabelControl53.Size = New System.Drawing.Size(68, 13)
Me.LabelControl53.TabIndex = 8
Me.LabelControl53.Text = "Nbr of Players"
'
'tabTrailers
'
Me.tabTrailers.Controls.Add(Me.Splitter1)
Me.tabTrailers.Controls.Add(Me.grpPictures)
Me.tabTrailers.Controls.Add(Me.grpSoundTracks)
Me.tabTrailers.Controls.Add(Me.SplitterControl3)
Me.tabTrailers.Controls.Add(Me.grpTrailers)
Me.tabTrailers.Name = "tabTrailers"
Me.tabTrailers.Size = New System.Drawing.Size(1047, 690)
Me.tabTrailers.Text = "Trailers / Sound Tracks/ Pictures"
'
'Splitter1
'
Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Right
Me.Splitter1.Location = New System.Drawing.Point(714, 0)
Me.Splitter1.Name = "Splitter1"
Me.Splitter1.Size = New System.Drawing.Size(10, 690)
Me.Splitter1.TabIndex = 5
Me.Splitter1.TabStop = false
'
'grpPictures
'
Me.grpPictures.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpPictures.Controls.Add(Me.imgIMDBID_6)
Me.grpPictures.Controls.Add(Me.imgIMDBID_5)
Me.grpPictures.Controls.Add(Me.imgIMDBID_4)
Me.grpPictures.Controls.Add(Me.imgIMDBID_3)
Me.grpPictures.Controls.Add(Me.imgIMDBID_2)
Me.grpPictures.Controls.Add(Me.imgIMDBID_1)
Me.grpPictures.Dock = System.Windows.Forms.DockStyle.Right
Me.grpPictures.Location = New System.Drawing.Point(724, 0)
Me.grpPictures.Name = "grpPictures"
Me.grpPictures.Size = New System.Drawing.Size(323, 690)
Me.grpPictures.TabIndex = 4
Me.grpPictures.Text = "SoundTracks"
'
'imgIMDBID_6
'
Me.imgIMDBID_6.Location = New System.Drawing.Point(6, 509)
Me.imgIMDBID_6.Name = "imgIMDBID_6"
Me.imgIMDBID_6.Properties.ReadOnly = true
Me.imgIMDBID_6.Size = New System.Drawing.Size(265, 95)
Me.imgIMDBID_6.TabIndex = 11
'
'imgIMDBID_5
'
Me.imgIMDBID_5.Location = New System.Drawing.Point(6, 414)
Me.imgIMDBID_5.Name = "imgIMDBID_5"
Me.imgIMDBID_5.Properties.ReadOnly = true
Me.imgIMDBID_5.Size = New System.Drawing.Size(265, 95)
Me.imgIMDBID_5.TabIndex = 10
'
'imgIMDBID_4
'
Me.imgIMDBID_4.Location = New System.Drawing.Point(6, 319)
Me.imgIMDBID_4.Name = "imgIMDBID_4"
Me.imgIMDBID_4.Properties.ReadOnly = true
Me.imgIMDBID_4.Size = New System.Drawing.Size(265, 95)
Me.imgIMDBID_4.TabIndex = 9
'
'imgIMDBID_3
'
Me.imgIMDBID_3.Location = New System.Drawing.Point(6, 224)
Me.imgIMDBID_3.Name = "imgIMDBID_3"
Me.imgIMDBID_3.Properties.ReadOnly = true
Me.imgIMDBID_3.Size = New System.Drawing.Size(265, 95)
Me.imgIMDBID_3.TabIndex = 8
'
'imgIMDBID_2
'
Me.imgIMDBID_2.Location = New System.Drawing.Point(6, 129)
Me.imgIMDBID_2.Name = "imgIMDBID_2"
Me.imgIMDBID_2.Properties.ReadOnly = true
Me.imgIMDBID_2.Size = New System.Drawing.Size(265, 95)
Me.imgIMDBID_2.TabIndex = 7
'
'imgIMDBID_1
'
Me.imgIMDBID_1.Location = New System.Drawing.Point(6, 23)
Me.imgIMDBID_1.Name = "imgIMDBID_1"
Me.imgIMDBID_1.Properties.ReadOnly = true
Me.imgIMDBID_1.Size = New System.Drawing.Size(265, 106)
Me.imgIMDBID_1.TabIndex = 6
'
'grpSoundTracks
'
Me.grpSoundTracks.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpSoundTracks.Controls.Add(Me.GridSoundtracks)
Me.grpSoundTracks.Controls.Add(Me.PanelControl9)
Me.grpSoundTracks.Dock = System.Windows.Forms.DockStyle.Fill
Me.grpSoundTracks.Location = New System.Drawing.Point(424, 0)
Me.grpSoundTracks.Name = "grpSoundTracks"
Me.grpSoundTracks.Size = New System.Drawing.Size(623, 690)
Me.grpSoundTracks.TabIndex = 3
Me.grpSoundTracks.Text = "SoundTracks"
'
'GridSoundtracks
'
Me.GridSoundtracks.DataSource = Me.objDS.products_to_soundtracks
Me.GridSoundtracks.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridSoundtracks.EmbeddedNavigator.Buttons.Edit.Visible = false
Me.GridSoundtracks.EmbeddedNavigator.Buttons.First.Visible = false
Me.GridSoundtracks.EmbeddedNavigator.Buttons.Last.Visible = false
Me.GridSoundtracks.EmbeddedNavigator.Buttons.Next.Visible = false
Me.GridSoundtracks.EmbeddedNavigator.Buttons.NextPage.Visible = false
Me.GridSoundtracks.EmbeddedNavigator.Buttons.Prev.Visible = false
Me.GridSoundtracks.EmbeddedNavigator.Buttons.PrevPage.Visible = false
Me.GridSoundtracks.EmbeddedNavigator.Enabled = false
Me.GridSoundtracks.EmbeddedNavigator.Name = ""
Me.GridSoundtracks.FormsUseDefaultLookAndFeel = false
Me.GridSoundtracks.Location = New System.Drawing.Point(2, 20)
Me.GridSoundtracks.MainView = Me.GridViewSoundTracks
Me.GridSoundtracks.Name = "GridSoundtracks"
Me.GridSoundtracks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbSoundTracks})
Me.GridSoundtracks.Size = New System.Drawing.Size(619, 628)
Me.GridSoundtracks.TabIndex = 4
Me.GridSoundtracks.UseEmbeddedNavigator = true
Me.GridSoundtracks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSoundTracks, Me.GridView6})
'
'GridViewSoundTracks
'
Me.GridViewSoundTracks.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand8})
Me.GridViewSoundTracks.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id5, Me.colproducts_soundtracks_id})
Me.GridViewSoundTracks.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
Me.GridViewSoundTracks.GridControl = Me.GridSoundtracks
Me.GridViewSoundTracks.Name = "GridViewSoundTracks"
Me.GridViewSoundTracks.OptionsBehavior.Editable = false
Me.GridViewSoundTracks.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
Me.GridViewSoundTracks.OptionsView.ShowBands = false
Me.GridViewSoundTracks.OptionsView.ShowGroupPanel = false
'
'GridBand8
'
Me.GridBand8.Caption = "gridBand1"
Me.GridBand8.Columns.Add(Me.colproducts_id5)
Me.GridBand8.Columns.Add(Me.colproducts_soundtracks_id)
Me.GridBand8.Name = "GridBand8"
Me.GridBand8.Width = 179
'
'colproducts_id5
'
Me.colproducts_id5.Caption = "products_id"
Me.colproducts_id5.FieldName = "products_id"
Me.colproducts_id5.Name = "colproducts_id5"
Me.colproducts_id5.Width = 123
'
'colproducts_soundtracks_id
'
Me.colproducts_soundtracks_id.Caption = "products_soundtracks_id"
Me.colproducts_soundtracks_id.ColumnEdit = Me.cmbSoundTracks
Me.colproducts_soundtracks_id.FieldName = "products_soundtracks_id"
Me.colproducts_soundtracks_id.Name = "colproducts_soundtracks_id"
Me.colproducts_soundtracks_id.Visible = true
Me.colproducts_soundtracks_id.Width = 179
'
'cmbSoundTracks
'
Me.cmbSoundTracks.AutoHeight = false
Me.cmbSoundTracks.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbSoundTracks.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("soundtracks_id", "soundtracks_id", 91, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("soundtracks_description", "soundtracks_description", 116, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbSoundTracks.DataSource = Me.objDS.products_soundtracks
Me.cmbSoundTracks.DisplayMember = "soundtracks_description"
Me.cmbSoundTracks.Name = "cmbSoundTracks"
Me.cmbSoundTracks.NullText = "NEW Line"
Me.cmbSoundTracks.ValueMember = "soundtracks_id"
'
'GridView6
'
Me.GridView6.GridControl = Me.GridSoundtracks
Me.GridView6.Name = "GridView6"
'
'PanelControl9
'
Me.PanelControl9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl9.Controls.Add(Me.btnSoundTracks)
Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Bottom
Me.PanelControl9.Location = New System.Drawing.Point(2, 648)
Me.PanelControl9.Name = "PanelControl9"
Me.PanelControl9.Size = New System.Drawing.Size(619, 40)
Me.PanelControl9.TabIndex = 5
'
'btnSoundTracks
'
Me.btnSoundTracks.Location = New System.Drawing.Point(8, 8)
Me.btnSoundTracks.Name = "btnSoundTracks"
Me.btnSoundTracks.Size = New System.Drawing.Size(120, 23)
Me.btnSoundTracks.TabIndex = 0
Me.btnSoundTracks.Text = "Manage Soundtracks"
'
'SplitterControl3
'
Me.SplitterControl3.Appearance.BackColor = System.Drawing.SystemColors.Highlight
Me.SplitterControl3.Appearance.Options.UseBackColor = true
Me.SplitterControl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.SplitterControl3.Location = New System.Drawing.Point(418, 0)
Me.SplitterControl3.Name = "SplitterControl3"
Me.SplitterControl3.Size = New System.Drawing.Size(6, 690)
Me.SplitterControl3.TabIndex = 2
Me.SplitterControl3.TabStop = false
'
'grpTrailers
'
Me.grpTrailers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpTrailers.Controls.Add(Me.Panel2)
Me.grpTrailers.Controls.Add(Me.Splitter2)
Me.grpTrailers.Controls.Add(Me.Panel1)
Me.grpTrailers.Controls.Add(Me.PanelControl8)
Me.grpTrailers.Dock = System.Windows.Forms.DockStyle.Left
Me.grpTrailers.Location = New System.Drawing.Point(0, 0)
Me.grpTrailers.Name = "grpTrailers"
Me.grpTrailers.Size = New System.Drawing.Size(418, 690)
Me.grpTrailers.TabIndex = 1
Me.grpTrailers.Text = "Trailers"
'
'Panel2
'
Me.Panel2.Controls.Add(Me.GridStreamingTrailers)
Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
Me.Panel2.Location = New System.Drawing.Point(2, 393)
Me.Panel2.Name = "Panel2"
Me.Panel2.Size = New System.Drawing.Size(414, 255)
Me.Panel2.TabIndex = 9
'
'GridStreamingTrailers
'
Me.GridStreamingTrailers.DataSource = Me.objDS.streaming_trailers
Me.GridStreamingTrailers.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.Edit.Visible = false
Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.First.Visible = false
Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.Last.Visible = false
Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.Next.Visible = false
Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.NextPage.Visible = false
Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.Prev.Visible = false
Me.GridStreamingTrailers.EmbeddedNavigator.Buttons.PrevPage.Visible = false
Me.GridStreamingTrailers.EmbeddedNavigator.Enabled = false
Me.GridStreamingTrailers.EmbeddedNavigator.Name = ""
Me.GridStreamingTrailers.FormsUseDefaultLookAndFeel = false
Me.GridStreamingTrailers.Location = New System.Drawing.Point(0, 0)
Me.GridStreamingTrailers.MainView = Me.AdvBandedGridView2
Me.GridStreamingTrailers.Name = "GridStreamingTrailers"
Me.GridStreamingTrailers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemButtonEdit1})
Me.GridStreamingTrailers.Size = New System.Drawing.Size(414, 255)
Me.GridStreamingTrailers.TabIndex = 6
Me.GridStreamingTrailers.UseEmbeddedNavigator = true
Me.GridStreamingTrailers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AdvBandedGridView2, Me.GridView5})
'
'AdvBandedGridView2
'
Me.AdvBandedGridView2.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand13})
Me.AdvBandedGridView2.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.BandedGridColumn3, Me.BandedGridColumn4, Me.BandedGridColumn8, Me.BandedGridColumn9, Me.BandedGridColumn10})
Me.AdvBandedGridView2.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
Me.AdvBandedGridView2.GridControl = Me.GridStreamingTrailers
Me.AdvBandedGridView2.Name = "AdvBandedGridView2"
Me.AdvBandedGridView2.OptionsBehavior.Editable = false
Me.AdvBandedGridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
Me.AdvBandedGridView2.OptionsView.ShowBands = false
Me.AdvBandedGridView2.OptionsView.ShowGroupPanel = false
'
'GridBand13
'
Me.GridBand13.Caption = "GridBand2"
Me.GridBand13.Columns.Add(Me.BandedGridColumn3)
Me.GridBand13.Columns.Add(Me.BandedGridColumn4)
Me.GridBand13.Columns.Add(Me.BandedGridColumn8)
Me.GridBand13.Columns.Add(Me.BandedGridColumn9)
Me.GridBand13.Columns.Add(Me.BandedGridColumn10)
Me.GridBand13.MinWidth = 20
Me.GridBand13.Name = "GridBand13"
Me.GridBand13.Width = 419
'
'BandedGridColumn3
'
Me.BandedGridColumn3.Caption = "id"
Me.BandedGridColumn3.FieldName = "id"
Me.BandedGridColumn3.Name = "BandedGridColumn3"
Me.BandedGridColumn3.Width = 121
'
'BandedGridColumn4
'
Me.BandedGridColumn4.Caption = "filename"
Me.BandedGridColumn4.FieldName = "filename"
Me.BandedGridColumn4.Name = "BandedGridColumn4"
Me.BandedGridColumn4.Visible = true
Me.BandedGridColumn4.Width = 173
'
'BandedGridColumn8
'
Me.BandedGridColumn8.Caption = "audio"
Me.BandedGridColumn8.FieldName = "audio"
Me.BandedGridColumn8.Name = "BandedGridColumn8"
Me.BandedGridColumn8.Visible = true
Me.BandedGridColumn8.Width = 51
'
'BandedGridColumn9
'
Me.BandedGridColumn9.Caption = "subtitle"
Me.BandedGridColumn9.FieldName = "subtitle"
Me.BandedGridColumn9.Name = "BandedGridColumn9"
Me.BandedGridColumn9.Visible = true
Me.BandedGridColumn9.Width = 58
'
'BandedGridColumn10
'
Me.BandedGridColumn10.Caption = "status"
Me.BandedGridColumn10.FieldName = "status"
Me.BandedGridColumn10.Name = "BandedGridColumn10"
Me.BandedGridColumn10.Visible = true
Me.BandedGridColumn10.Width = 137
'
'RepositoryItemLookUpEdit1
'
Me.RepositoryItemLookUpEdit1.AutoHeight = false
Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_description", "languages_description", 113, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.RepositoryItemLookUpEdit1.DataSource = Me.objDS.products_languages
Me.RepositoryItemLookUpEdit1.DisplayMember = "languages_description"
Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
Me.RepositoryItemLookUpEdit1.NullText = "New Line"
Me.RepositoryItemLookUpEdit1.ValueMember = "languages_id"
'
'RepositoryItemLookUpEdit2
'
Me.RepositoryItemLookUpEdit2.AutoHeight = false
Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("broadcast", "broadcast", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.RepositoryItemLookUpEdit2.DataSource = Me.objDS.trailers_broadcast
Me.RepositoryItemLookUpEdit2.DisplayMember = "broadcast"
Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
Me.RepositoryItemLookUpEdit2.ValueMember = "broadcast"
'
'RepositoryItemButtonEdit1
'
Me.RepositoryItemButtonEdit1.AutoHeight = false
Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
'
'GridView5
'
Me.GridView5.GridControl = Me.GridStreamingTrailers
Me.GridView5.Name = "GridView5"
'
'Splitter2
'
Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Top
Me.Splitter2.Location = New System.Drawing.Point(2, 383)
Me.Splitter2.Name = "Splitter2"
Me.Splitter2.Size = New System.Drawing.Size(414, 10)
Me.Splitter2.TabIndex = 8
Me.Splitter2.TabStop = false
'
'Panel1
'
Me.Panel1.Controls.Add(Me.GridTrailers)
Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
Me.Panel1.Location = New System.Drawing.Point(2, 20)
Me.Panel1.Name = "Panel1"
Me.Panel1.Size = New System.Drawing.Size(414, 363)
Me.Panel1.TabIndex = 7
'
'GridTrailers
'
Me.GridTrailers.DataSource = Me.objDS.products_trailers
Me.GridTrailers.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridTrailers.EmbeddedNavigator.Buttons.Edit.Visible = false
Me.GridTrailers.EmbeddedNavigator.Buttons.First.Visible = false
Me.GridTrailers.EmbeddedNavigator.Buttons.Last.Visible = false
Me.GridTrailers.EmbeddedNavigator.Buttons.Next.Visible = false
Me.GridTrailers.EmbeddedNavigator.Buttons.NextPage.Visible = false
Me.GridTrailers.EmbeddedNavigator.Buttons.Prev.Visible = false
Me.GridTrailers.EmbeddedNavigator.Buttons.PrevPage.Visible = false
Me.GridTrailers.EmbeddedNavigator.Enabled = false
Me.GridTrailers.EmbeddedNavigator.Name = ""
Me.GridTrailers.FormsUseDefaultLookAndFeel = false
Me.GridTrailers.Location = New System.Drawing.Point(0, 0)
Me.GridTrailers.MainView = Me.GridViewTrailers
Me.GridTrailers.Name = "GridTrailers"
Me.GridTrailers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLangTrailer, Me.cmbTrailers_Broadcast, Me.ButtonWatchTrailer})
Me.GridTrailers.Size = New System.Drawing.Size(414, 363)
Me.GridTrailers.TabIndex = 4
Me.GridTrailers.UseEmbeddedNavigator = true
Me.GridTrailers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewTrailers, Me.GridView4})
'
'GridViewTrailers
'
Me.GridViewTrailers.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand7})
Me.GridViewTrailers.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.coltrailers_id, Me.colproducts_id4, Me.collanguage_id1, Me.coltrailer, Me.colbroadcast, Me.colWatchTrailer})
Me.GridViewTrailers.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
Me.GridViewTrailers.GridControl = Me.GridTrailers
Me.GridViewTrailers.Name = "GridViewTrailers"
Me.GridViewTrailers.OptionsBehavior.Editable = false
Me.GridViewTrailers.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
Me.GridViewTrailers.OptionsView.ShowBands = false
Me.GridViewTrailers.OptionsView.ShowGroupPanel = false
'
'GridBand7
'
Me.GridBand7.Caption = "GridBand2"
Me.GridBand7.Columns.Add(Me.coltrailers_id)
Me.GridBand7.Columns.Add(Me.colproducts_id4)
Me.GridBand7.Columns.Add(Me.colWatchTrailer)
Me.GridBand7.Columns.Add(Me.collanguage_id1)
Me.GridBand7.Columns.Add(Me.coltrailer)
Me.GridBand7.Columns.Add(Me.colbroadcast)
Me.GridBand7.MinWidth = 20
Me.GridBand7.Name = "GridBand7"
Me.GridBand7.Width = 388
'
'coltrailers_id
'
Me.coltrailers_id.Caption = "trailers_id"
Me.coltrailers_id.FieldName = "trailers_id"
Me.coltrailers_id.Name = "coltrailers_id"
Me.coltrailers_id.Width = 121
'
'colproducts_id4
'
Me.colproducts_id4.Caption = "products_id"
Me.colproducts_id4.FieldName = "products_id"
Me.colproducts_id4.Name = "colproducts_id4"
Me.colproducts_id4.Width = 132
'
'colWatchTrailer
'
Me.colWatchTrailer.Caption = "watch"
Me.colWatchTrailer.ColumnEdit = Me.ButtonWatchTrailer
Me.colWatchTrailer.Name = "colWatchTrailer"
Me.colWatchTrailer.Visible = true
Me.colWatchTrailer.Width = 49
'
'ButtonWatchTrailer
'
Me.ButtonWatchTrailer.AutoHeight = false
Me.ButtonWatchTrailer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.ButtonWatchTrailer.Name = "ButtonWatchTrailer"
Me.ButtonWatchTrailer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
'
'collanguage_id1
'
Me.collanguage_id1.Caption = "language_id"
Me.collanguage_id1.ColumnEdit = Me.cmbLangTrailer
Me.collanguage_id1.FieldName = "language_id"
Me.collanguage_id1.Name = "collanguage_id1"
Me.collanguage_id1.Visible = true
Me.collanguage_id1.Width = 87
'
'cmbLangTrailer
'
Me.cmbLangTrailer.AutoHeight = false
Me.cmbLangTrailer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbLangTrailer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 82, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_description", "languages_description", 113, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbLangTrailer.DataSource = Me.objDS.products_languages
Me.cmbLangTrailer.DisplayMember = "languages_description"
Me.cmbLangTrailer.Name = "cmbLangTrailer"
Me.cmbLangTrailer.NullText = "New Line"
Me.cmbLangTrailer.ValueMember = "languages_id"
'
'coltrailer
'
Me.coltrailer.Caption = "trailer"
Me.coltrailer.FieldName = "trailer"
Me.coltrailer.Name = "coltrailer"
Me.coltrailer.Visible = true
Me.coltrailer.Width = 141
'
'colbroadcast
'
Me.colbroadcast.Caption = "broadcast"
Me.colbroadcast.ColumnEdit = Me.cmbTrailers_Broadcast
Me.colbroadcast.FieldName = "broadcast"
Me.colbroadcast.Name = "colbroadcast"
Me.colbroadcast.Visible = true
Me.colbroadcast.Width = 111
'
'cmbTrailers_Broadcast
'
Me.cmbTrailers_Broadcast.AutoHeight = false
Me.cmbTrailers_Broadcast.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbTrailers_Broadcast.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("broadcast", "broadcast", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbTrailers_Broadcast.DataSource = Me.objDS.trailers_broadcast
Me.cmbTrailers_Broadcast.DisplayMember = "broadcast"
Me.cmbTrailers_Broadcast.Name = "cmbTrailers_Broadcast"
Me.cmbTrailers_Broadcast.ValueMember = "broadcast"
'
'GridView4
'
Me.GridView4.GridControl = Me.GridTrailers
Me.GridView4.Name = "GridView4"
'
'PanelControl8
'
Me.PanelControl8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Bottom
Me.PanelControl8.Location = New System.Drawing.Point(2, 648)
Me.PanelControl8.Name = "PanelControl8"
Me.PanelControl8.Size = New System.Drawing.Size(414, 40)
Me.PanelControl8.TabIndex = 5
'
'tabLanguages
'
Me.tabLanguages.Controls.Add(Me.grpSubTitles)
Me.tabLanguages.Controls.Add(Me.SplitterControl1)
Me.tabLanguages.Controls.Add(Me.grpLanguage)
Me.tabLanguages.Name = "tabLanguages"
Me.tabLanguages.Size = New System.Drawing.Size(1047, 690)
Me.tabLanguages.Text = "Languages"
'
'grpSubTitles
'
Me.grpSubTitles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpSubTitles.Controls.Add(Me.GridUndertitles)
Me.grpSubTitles.Controls.Add(Me.PanelControl5)
Me.grpSubTitles.Dock = System.Windows.Forms.DockStyle.Fill
Me.grpSubTitles.Location = New System.Drawing.Point(502, 0)
Me.grpSubTitles.Name = "grpSubTitles"
Me.grpSubTitles.Size = New System.Drawing.Size(545, 690)
Me.grpSubTitles.TabIndex = 2
Me.grpSubTitles.Text = "SubTitles"
'
'GridUndertitles
'
Me.GridUndertitles.DataSource = Me.objDS.products_to_undertitles
Me.GridUndertitles.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridUndertitles.EmbeddedNavigator.Buttons.Edit.Visible = false
Me.GridUndertitles.EmbeddedNavigator.Buttons.First.Visible = false
Me.GridUndertitles.EmbeddedNavigator.Buttons.Last.Visible = false
Me.GridUndertitles.EmbeddedNavigator.Buttons.Next.Visible = false
Me.GridUndertitles.EmbeddedNavigator.Buttons.NextPage.Visible = false
Me.GridUndertitles.EmbeddedNavigator.Buttons.Prev.Visible = false
Me.GridUndertitles.EmbeddedNavigator.Buttons.PrevPage.Visible = false
Me.GridUndertitles.EmbeddedNavigator.Enabled = false
Me.GridUndertitles.EmbeddedNavigator.Name = ""
Me.GridUndertitles.FormsUseDefaultLookAndFeel = false
Me.GridUndertitles.Location = New System.Drawing.Point(2, 20)
Me.GridUndertitles.MainView = Me.GridViewUndertitles
Me.GridUndertitles.Name = "GridUndertitles"
Me.GridUndertitles.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbUndertitles})
Me.GridUndertitles.Size = New System.Drawing.Size(541, 628)
Me.GridUndertitles.TabIndex = 4
Me.GridUndertitles.UseEmbeddedNavigator = true
Me.GridUndertitles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewUndertitles, Me.GridView8})
'
'GridViewUndertitles
'
Me.GridViewUndertitles.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand4})
Me.GridViewUndertitles.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id3, Me.colproducts_undertitles_id})
Me.GridViewUndertitles.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
Me.GridViewUndertitles.GridControl = Me.GridUndertitles
Me.GridViewUndertitles.Name = "GridViewUndertitles"
Me.GridViewUndertitles.OptionsBehavior.Editable = false
Me.GridViewUndertitles.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
Me.GridViewUndertitles.OptionsView.ShowBands = false
Me.GridViewUndertitles.OptionsView.ShowGroupPanel = false
'
'GridBand4
'
Me.GridBand4.Caption = "GridBand2"
Me.GridBand4.Columns.Add(Me.colproducts_id3)
Me.GridBand4.Columns.Add(Me.colproducts_undertitles_id)
Me.GridBand4.Name = "GridBand4"
Me.GridBand4.Width = 245
'
'colproducts_id3
'
Me.colproducts_id3.Caption = "products_id"
Me.colproducts_id3.FieldName = "products_id"
Me.colproducts_id3.Name = "colproducts_id3"
'
'colproducts_undertitles_id
'
Me.colproducts_undertitles_id.Caption = "SubTitles"
Me.colproducts_undertitles_id.ColumnEdit = Me.cmbUndertitles
Me.colproducts_undertitles_id.FieldName = "products_undertitles_id"
Me.colproducts_undertitles_id.Name = "colproducts_undertitles_id"
Me.colproducts_undertitles_id.Visible = true
Me.colproducts_undertitles_id.Width = 245
'
'cmbUndertitles
'
Me.cmbUndertitles.AutoHeight = false
Me.cmbUndertitles.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbUndertitles.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("undertitles_id", "undertitles_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("undertitles_description", "undertitles_description", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbUndertitles.DataSource = Me.objDS.products_undertitles
Me.cmbUndertitles.DisplayMember = "undertitles_description"
Me.cmbUndertitles.Name = "cmbUndertitles"
Me.cmbUndertitles.NullText = "NEW Line"
Me.cmbUndertitles.ValueMember = "undertitles_id"
'
'GridView8
'
Me.GridView8.GridControl = Me.GridUndertitles
Me.GridView8.Name = "GridView8"
'
'PanelControl5
'
Me.PanelControl5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl5.Controls.Add(Me.btnSubTitles)
Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
Me.PanelControl5.Location = New System.Drawing.Point(2, 648)
Me.PanelControl5.Name = "PanelControl5"
Me.PanelControl5.Size = New System.Drawing.Size(541, 40)
Me.PanelControl5.TabIndex = 5
'
'btnSubTitles
'
Me.btnSubTitles.Location = New System.Drawing.Point(8, 8)
Me.btnSubTitles.Name = "btnSubTitles"
Me.btnSubTitles.Size = New System.Drawing.Size(96, 23)
Me.btnSubTitles.TabIndex = 0
Me.btnSubTitles.Text = "Manage SubTitles"
'
'SplitterControl1
'
Me.SplitterControl1.Appearance.BackColor = System.Drawing.SystemColors.Highlight
Me.SplitterControl1.Appearance.Options.UseBackColor = true
Me.SplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
Me.SplitterControl1.Location = New System.Drawing.Point(496, 0)
Me.SplitterControl1.Name = "SplitterControl1"
Me.SplitterControl1.Size = New System.Drawing.Size(6, 690)
Me.SplitterControl1.TabIndex = 1
Me.SplitterControl1.TabStop = false
'
'grpLanguage
'
Me.grpLanguage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpLanguage.Controls.Add(Me.GridLanguages)
Me.grpLanguage.Controls.Add(Me.PanelControl4)
Me.grpLanguage.Dock = System.Windows.Forms.DockStyle.Left
Me.grpLanguage.Location = New System.Drawing.Point(0, 0)
Me.grpLanguage.Name = "grpLanguage"
Me.grpLanguage.Size = New System.Drawing.Size(496, 690)
Me.grpLanguage.TabIndex = 0
Me.grpLanguage.Text = "Language"
'
'GridLanguages
'
Me.GridLanguages.DataSource = Me.objDS.products_to_languages
Me.GridLanguages.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridLanguages.EmbeddedNavigator.Buttons.Edit.Visible = false
Me.GridLanguages.EmbeddedNavigator.Buttons.First.Visible = false
Me.GridLanguages.EmbeddedNavigator.Buttons.Last.Visible = false
Me.GridLanguages.EmbeddedNavigator.Buttons.Next.Visible = false
Me.GridLanguages.EmbeddedNavigator.Buttons.NextPage.Visible = false
Me.GridLanguages.EmbeddedNavigator.Buttons.Prev.Visible = false
Me.GridLanguages.EmbeddedNavigator.Buttons.PrevPage.Visible = false
Me.GridLanguages.EmbeddedNavigator.Enabled = false
Me.GridLanguages.EmbeddedNavigator.Name = ""
Me.GridLanguages.FormsUseDefaultLookAndFeel = false
Me.GridLanguages.Location = New System.Drawing.Point(2, 20)
Me.GridLanguages.MainView = Me.GridViewLanguages
Me.GridLanguages.Name = "GridLanguages"
Me.GridLanguages.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbLanguages1})
Me.GridLanguages.Size = New System.Drawing.Size(492, 628)
Me.GridLanguages.TabIndex = 4
Me.GridLanguages.UseEmbeddedNavigator = true
Me.GridLanguages.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewLanguages, Me.GridView7})
'
'GridViewLanguages
'
Me.GridViewLanguages.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand3})
Me.GridViewLanguages.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id2, Me.colproducts_languages_id})
Me.GridViewLanguages.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
Me.GridViewLanguages.GridControl = Me.GridLanguages
Me.GridViewLanguages.Name = "GridViewLanguages"
Me.GridViewLanguages.OptionsBehavior.Editable = false
Me.GridViewLanguages.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
Me.GridViewLanguages.OptionsView.ShowBands = false
Me.GridViewLanguages.OptionsView.ShowGroupPanel = false
'
'GridBand3
'
Me.GridBand3.Caption = "GridBand2"
Me.GridBand3.Columns.Add(Me.colproducts_id2)
Me.GridBand3.Columns.Add(Me.colproducts_languages_id)
Me.GridBand3.Name = "GridBand3"
Me.GridBand3.Width = 241
'
'colproducts_id2
'
Me.colproducts_id2.Caption = "products_id"
Me.colproducts_id2.FieldName = "products_id"
Me.colproducts_id2.Name = "colproducts_id2"
'
'colproducts_languages_id
'
Me.colproducts_languages_id.Caption = "Language"
Me.colproducts_languages_id.ColumnEdit = Me.cmbLanguages1
Me.colproducts_languages_id.FieldName = "products_languages_id"
Me.colproducts_languages_id.Name = "colproducts_languages_id"
Me.colproducts_languages_id.Visible = true
Me.colproducts_languages_id.Width = 241
'
'cmbLanguages1
'
Me.cmbLanguages1.AutoHeight = false
Me.cmbLanguages1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbLanguages1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_id", "languages_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("languages_description", "languages_description", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbLanguages1.DataSource = Me.objDS.products_languages
Me.cmbLanguages1.DisplayMember = "languages_description"
Me.cmbLanguages1.Name = "cmbLanguages1"
Me.cmbLanguages1.NullText = "NEW Line"
Me.cmbLanguages1.ValueMember = "languages_id"
'
'GridView7
'
Me.GridView7.GridControl = Me.GridLanguages
Me.GridView7.Name = "GridView7"
'
'PanelControl4
'
Me.PanelControl4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl4.Controls.Add(Me.btnLang)
Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
Me.PanelControl4.Location = New System.Drawing.Point(2, 648)
Me.PanelControl4.Name = "PanelControl4"
Me.PanelControl4.Size = New System.Drawing.Size(492, 40)
Me.PanelControl4.TabIndex = 5
'
'btnLang
'
Me.btnLang.Location = New System.Drawing.Point(8, 8)
Me.btnLang.Name = "btnLang"
Me.btnLang.Size = New System.Drawing.Size(96, 23)
Me.btnLang.TabIndex = 0
Me.btnLang.Text = "Manage Lang"
'
'tabTheme
'
Me.tabTheme.Controls.Add(Me.PanelControl7)
Me.tabTheme.Controls.Add(Me.SplitterControl2)
Me.tabTheme.Controls.Add(Me.PanelControl6)
Me.tabTheme.Name = "tabTheme"
Me.tabTheme.Size = New System.Drawing.Size(1047, 690)
Me.tabTheme.Text = "Themes and Categories"
'
'PanelControl7
'
Me.PanelControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl7.Controls.Add(Me.TreeListThemes)
Me.PanelControl7.Controls.Add(Me.PanelControl12)
Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelControl7.Location = New System.Drawing.Point(550, 0)
Me.PanelControl7.Name = "PanelControl7"
Me.PanelControl7.Size = New System.Drawing.Size(497, 690)
Me.PanelControl7.TabIndex = 12
'
'TreeListThemes
'
Me.TreeListThemes.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListThemes.Appearance.Empty.BackColor2 = System.Drawing.Color.White
Me.TreeListThemes.Appearance.Empty.Options.UseBackColor = true
Me.TreeListThemes.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListThemes.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListThemes.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
Me.TreeListThemes.Appearance.EvenRow.Options.UseBackColor = true
Me.TreeListThemes.Appearance.EvenRow.Options.UseBorderColor = true
Me.TreeListThemes.Appearance.EvenRow.Options.UseForeColor = true
Me.TreeListThemes.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
Me.TreeListThemes.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
Me.TreeListThemes.Appearance.FocusedCell.Options.UseBackColor = true
Me.TreeListThemes.Appearance.FocusedCell.Options.UseForeColor = true
Me.TreeListThemes.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(189,Byte),Integer))
Me.TreeListThemes.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(206,Byte),Integer))
Me.TreeListThemes.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
Me.TreeListThemes.Appearance.FocusedRow.Options.UseBackColor = true
Me.TreeListThemes.Appearance.FocusedRow.Options.UseBorderColor = true
Me.TreeListThemes.Appearance.FocusedRow.Options.UseForeColor = true
Me.TreeListThemes.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListThemes.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListThemes.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
Me.TreeListThemes.Appearance.FooterPanel.Options.UseBackColor = true
Me.TreeListThemes.Appearance.FooterPanel.Options.UseBorderColor = true
Me.TreeListThemes.Appearance.FooterPanel.Options.UseForeColor = true
Me.TreeListThemes.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListThemes.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListThemes.Appearance.GroupButton.Options.UseBackColor = true
Me.TreeListThemes.Appearance.GroupButton.Options.UseBorderColor = true
Me.TreeListThemes.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170,Byte),Integer), CType(CType(216,Byte),Integer), CType(CType(254,Byte),Integer))
Me.TreeListThemes.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170,Byte),Integer), CType(CType(216,Byte),Integer), CType(CType(254,Byte),Integer))
Me.TreeListThemes.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
Me.TreeListThemes.Appearance.GroupFooter.Options.UseBackColor = true
Me.TreeListThemes.Appearance.GroupFooter.Options.UseBorderColor = true
Me.TreeListThemes.Appearance.GroupFooter.Options.UseForeColor = true
Me.TreeListThemes.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139,Byte),Integer), CType(CType(201,Byte),Integer), CType(CType(254,Byte),Integer))
Me.TreeListThemes.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139,Byte),Integer), CType(CType(201,Byte),Integer), CType(CType(254,Byte),Integer))
Me.TreeListThemes.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
Me.TreeListThemes.Appearance.HeaderPanel.Options.UseBackColor = true
Me.TreeListThemes.Appearance.HeaderPanel.Options.UseBorderColor = true
Me.TreeListThemes.Appearance.HeaderPanel.Options.UseForeColor = true
Me.TreeListThemes.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(225,Byte),Integer))
Me.TreeListThemes.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83,Byte),Integer), CType(CType(155,Byte),Integer), CType(CType(215,Byte),Integer))
Me.TreeListThemes.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListThemes.Appearance.HideSelectionRow.Options.UseBackColor = true
Me.TreeListThemes.Appearance.HideSelectionRow.Options.UseBorderColor = true
Me.TreeListThemes.Appearance.HideSelectionRow.Options.UseForeColor = true
Me.TreeListThemes.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListThemes.Appearance.HorzLine.Options.UseBackColor = true
Me.TreeListThemes.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListThemes.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListThemes.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
Me.TreeListThemes.Appearance.OddRow.Options.UseBackColor = true
Me.TreeListThemes.Appearance.OddRow.Options.UseBorderColor = true
Me.TreeListThemes.Appearance.OddRow.Options.UseForeColor = true
Me.TreeListThemes.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
Me.TreeListThemes.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83,Byte),Integer), CType(CType(155,Byte),Integer), CType(CType(215,Byte),Integer))
Me.TreeListThemes.Appearance.Preview.Options.UseFont = true
Me.TreeListThemes.Appearance.Preview.Options.UseForeColor = true
Me.TreeListThemes.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListThemes.Appearance.Row.ForeColor = System.Drawing.Color.Black
Me.TreeListThemes.Appearance.Row.Options.UseBackColor = true
Me.TreeListThemes.Appearance.Row.Options.UseForeColor = true
Me.TreeListThemes.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83,Byte),Integer), CType(CType(155,Byte),Integer), CType(CType(215,Byte),Integer))
Me.TreeListThemes.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
Me.TreeListThemes.Appearance.SelectedRow.Options.UseBackColor = true
Me.TreeListThemes.Appearance.SelectedRow.Options.UseForeColor = true
Me.TreeListThemes.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(133,Byte),Integer), CType(CType(195,Byte),Integer))
Me.TreeListThemes.Appearance.TreeLine.Options.UseBackColor = true
Me.TreeListThemes.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListThemes.Appearance.VertLine.Options.UseBackColor = true
Me.TreeListThemes.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colthemes_id, Me.colparent_id1, Me.colthemes_type, Me.colthemes_name, Me.colthemes_selected})
Me.TreeListThemes.CustomizationFormBounds = New System.Drawing.Rectangle(960, 402, 208, 170)
Me.TreeListThemes.DataSource = Me.objDS.themes_fr_view1
Me.TreeListThemes.Dock = System.Windows.Forms.DockStyle.Fill
Me.TreeListThemes.KeyFieldName = "themes_id"
Me.TreeListThemes.Location = New System.Drawing.Point(2, 2)
Me.TreeListThemes.Name = "TreeListThemes"
Me.TreeListThemes.OptionsBehavior.Editable = false
Me.TreeListThemes.OptionsBehavior.PopulateServiceColumns = true
Me.TreeListThemes.OptionsView.EnableAppearanceEvenRow = true
Me.TreeListThemes.OptionsView.EnableAppearanceOddRow = true
Me.TreeListThemes.OptionsView.ShowHorzLines = false
Me.TreeListThemes.OptionsView.ShowIndicator = false
Me.TreeListThemes.OptionsView.ShowVertLines = false
Me.TreeListThemes.ParentFieldName = "parent_id"
Me.TreeListThemes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkThemeSelected})
Me.TreeListThemes.Size = New System.Drawing.Size(493, 638)
Me.TreeListThemes.TabIndex = 9
'
'colthemes_id
'
Me.colthemes_id.Caption = "themes_id"
Me.colthemes_id.FieldName = "themes_id"
Me.colthemes_id.Format.FormatType = DevExpress.Utils.FormatType.Numeric
Me.colthemes_id.Name = "colthemes_id"
Me.colthemes_id.Width = 99
'
'colparent_id1
'
Me.colparent_id1.Caption = "parent_id"
Me.colparent_id1.FieldName = "parent_id"
Me.colparent_id1.Format.FormatType = DevExpress.Utils.FormatType.Numeric
Me.colparent_id1.Name = "colparent_id1"
Me.colparent_id1.Width = 99
'
'colthemes_type
'
Me.colthemes_type.Caption = "themes_type"
Me.colthemes_type.FieldName = "themes_type"
Me.colthemes_type.Name = "colthemes_type"
Me.colthemes_type.Visible = true
Me.colthemes_type.VisibleIndex = 1
Me.colthemes_type.Width = 165
'
'colthemes_name
'
Me.colthemes_name.Caption = "themes_name"
Me.colthemes_name.FieldName = "themes_name"
Me.colthemes_name.Name = "colthemes_name"
Me.colthemes_name.Visible = true
Me.colthemes_name.VisibleIndex = 0
Me.colthemes_name.Width = 164
'
'colthemes_selected
'
Me.colthemes_selected.Caption = "themes_selected"
Me.colthemes_selected.ColumnEdit = Me.chkThemeSelected
Me.colthemes_selected.FieldName = "themes_selected"
Me.colthemes_selected.Format.FormatType = DevExpress.Utils.FormatType.Numeric
Me.colthemes_selected.Name = "colthemes_selected"
Me.colthemes_selected.Visible = true
Me.colthemes_selected.VisibleIndex = 2
Me.colthemes_selected.Width = 163
'
'chkThemeSelected
'
Me.chkThemeSelected.AutoHeight = false
Me.chkThemeSelected.Name = "chkThemeSelected"
Me.chkThemeSelected.ValueChecked = 1
Me.chkThemeSelected.ValueUnchecked = 0
'
'PanelControl12
'
Me.PanelControl12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl12.Controls.Add(Me.btnThemes)
Me.PanelControl12.Dock = System.Windows.Forms.DockStyle.Bottom
Me.PanelControl12.Location = New System.Drawing.Point(2, 640)
Me.PanelControl12.Name = "PanelControl12"
Me.PanelControl12.Size = New System.Drawing.Size(493, 48)
Me.PanelControl12.TabIndex = 10
'
'btnThemes
'
Me.btnThemes.Location = New System.Drawing.Point(8, 16)
Me.btnThemes.Name = "btnThemes"
Me.btnThemes.Size = New System.Drawing.Size(120, 23)
Me.btnThemes.TabIndex = 0
Me.btnThemes.Text = "Manage Themes"
'
'SplitterControl2
'
Me.SplitterControl2.Location = New System.Drawing.Point(544, 0)
Me.SplitterControl2.Name = "SplitterControl2"
Me.SplitterControl2.Size = New System.Drawing.Size(6, 690)
Me.SplitterControl2.TabIndex = 11
Me.SplitterControl2.TabStop = false
'
'PanelControl6
'
Me.PanelControl6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl6.Controls.Add(Me.TreeListCategories)
Me.PanelControl6.Controls.Add(Me.PanelControl11)
Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Left
Me.PanelControl6.Location = New System.Drawing.Point(0, 0)
Me.PanelControl6.Name = "PanelControl6"
Me.PanelControl6.Size = New System.Drawing.Size(544, 690)
Me.PanelControl6.TabIndex = 10
'
'TreeListCategories
'
Me.TreeListCategories.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListCategories.Appearance.Empty.BackColor2 = System.Drawing.Color.White
Me.TreeListCategories.Appearance.Empty.Options.UseBackColor = true
Me.TreeListCategories.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListCategories.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListCategories.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
Me.TreeListCategories.Appearance.EvenRow.Options.UseBackColor = true
Me.TreeListCategories.Appearance.EvenRow.Options.UseBorderColor = true
Me.TreeListCategories.Appearance.EvenRow.Options.UseForeColor = true
Me.TreeListCategories.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
Me.TreeListCategories.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
Me.TreeListCategories.Appearance.FocusedCell.Options.UseBackColor = true
Me.TreeListCategories.Appearance.FocusedCell.Options.UseForeColor = true
Me.TreeListCategories.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(189,Byte),Integer))
Me.TreeListCategories.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(139,Byte),Integer), CType(CType(206,Byte),Integer))
Me.TreeListCategories.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
Me.TreeListCategories.Appearance.FocusedRow.Options.UseBackColor = true
Me.TreeListCategories.Appearance.FocusedRow.Options.UseBorderColor = true
Me.TreeListCategories.Appearance.FocusedRow.Options.UseForeColor = true
Me.TreeListCategories.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListCategories.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListCategories.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
Me.TreeListCategories.Appearance.FooterPanel.Options.UseBackColor = true
Me.TreeListCategories.Appearance.FooterPanel.Options.UseBorderColor = true
Me.TreeListCategories.Appearance.FooterPanel.Options.UseForeColor = true
Me.TreeListCategories.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListCategories.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListCategories.Appearance.GroupButton.Options.UseBackColor = true
Me.TreeListCategories.Appearance.GroupButton.Options.UseBorderColor = true
Me.TreeListCategories.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170,Byte),Integer), CType(CType(216,Byte),Integer), CType(CType(254,Byte),Integer))
Me.TreeListCategories.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170,Byte),Integer), CType(CType(216,Byte),Integer), CType(CType(254,Byte),Integer))
Me.TreeListCategories.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
Me.TreeListCategories.Appearance.GroupFooter.Options.UseBackColor = true
Me.TreeListCategories.Appearance.GroupFooter.Options.UseBorderColor = true
Me.TreeListCategories.Appearance.GroupFooter.Options.UseForeColor = true
Me.TreeListCategories.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139,Byte),Integer), CType(CType(201,Byte),Integer), CType(CType(254,Byte),Integer))
Me.TreeListCategories.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139,Byte),Integer), CType(CType(201,Byte),Integer), CType(CType(254,Byte),Integer))
Me.TreeListCategories.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
Me.TreeListCategories.Appearance.HeaderPanel.Options.UseBackColor = true
Me.TreeListCategories.Appearance.HeaderPanel.Options.UseBorderColor = true
Me.TreeListCategories.Appearance.HeaderPanel.Options.UseForeColor = true
Me.TreeListCategories.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(225,Byte),Integer))
Me.TreeListCategories.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83,Byte),Integer), CType(CType(155,Byte),Integer), CType(CType(215,Byte),Integer))
Me.TreeListCategories.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListCategories.Appearance.HideSelectionRow.Options.UseBackColor = true
Me.TreeListCategories.Appearance.HideSelectionRow.Options.UseBorderColor = true
Me.TreeListCategories.Appearance.HideSelectionRow.Options.UseForeColor = true
Me.TreeListCategories.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListCategories.Appearance.HorzLine.Options.UseBackColor = true
Me.TreeListCategories.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListCategories.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236,Byte),Integer), CType(CType(246,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListCategories.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
Me.TreeListCategories.Appearance.OddRow.Options.UseBackColor = true
Me.TreeListCategories.Appearance.OddRow.Options.UseBorderColor = true
Me.TreeListCategories.Appearance.OddRow.Options.UseForeColor = true
Me.TreeListCategories.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
Me.TreeListCategories.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83,Byte),Integer), CType(CType(155,Byte),Integer), CType(CType(215,Byte),Integer))
Me.TreeListCategories.Appearance.Preview.Options.UseFont = true
Me.TreeListCategories.Appearance.Preview.Options.UseForeColor = true
Me.TreeListCategories.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247,Byte),Integer), CType(CType(251,Byte),Integer), CType(CType(255,Byte),Integer))
Me.TreeListCategories.Appearance.Row.ForeColor = System.Drawing.Color.Black
Me.TreeListCategories.Appearance.Row.Options.UseBackColor = true
Me.TreeListCategories.Appearance.Row.Options.UseForeColor = true
Me.TreeListCategories.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83,Byte),Integer), CType(CType(155,Byte),Integer), CType(CType(215,Byte),Integer))
Me.TreeListCategories.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
Me.TreeListCategories.Appearance.SelectedRow.Options.UseBackColor = true
Me.TreeListCategories.Appearance.SelectedRow.Options.UseForeColor = true
Me.TreeListCategories.Appearance.TreeLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59,Byte),Integer), CType(CType(133,Byte),Integer), CType(CType(195,Byte),Integer))
Me.TreeListCategories.Appearance.TreeLine.Options.UseBackColor = true
Me.TreeListCategories.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104,Byte),Integer), CType(CType(184,Byte),Integer), CType(CType(251,Byte),Integer))
Me.TreeListCategories.Appearance.VertLine.Options.UseBackColor = true
Me.TreeListCategories.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colcategories_id, Me.colparent_id, Me.colcategories_type, Me.colcategories_name, Me.colcategory_selected})
Me.TreeListCategories.CustomizationFormBounds = New System.Drawing.Rectangle(960, 402, 208, 170)
Me.TreeListCategories.DataSource = Me.objDS.categories_fr_view1
Me.TreeListCategories.Dock = System.Windows.Forms.DockStyle.Fill
FilterCondition1.Column = Me.colcategory_selected
FilterCondition1.Condition = DevExpress.XtraTreeList.FilterConditionEnum.Equals
FilterCondition1.Value1 = true
FilterCondition1.Visible = true
Me.TreeListCategories.FilterConditions.AddRange(New DevExpress.XtraTreeList.FilterCondition() {FilterCondition1})
Me.TreeListCategories.KeyFieldName = "categories_id"
Me.TreeListCategories.Location = New System.Drawing.Point(2, 2)
Me.TreeListCategories.Name = "TreeListCategories"
Me.TreeListCategories.OptionsBehavior.Editable = false
Me.TreeListCategories.OptionsBehavior.EnableFiltering = true
Me.TreeListCategories.OptionsBehavior.PopulateServiceColumns = true
Me.TreeListCategories.OptionsView.EnableAppearanceEvenRow = true
Me.TreeListCategories.OptionsView.EnableAppearanceOddRow = true
Me.TreeListCategories.OptionsView.ShowHorzLines = false
Me.TreeListCategories.OptionsView.ShowIndicator = false
Me.TreeListCategories.OptionsView.ShowVertLines = false
Me.TreeListCategories.ParentFieldName = "parent_id"
Me.TreeListCategories.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.chkSelectCategory})
Me.TreeListCategories.Size = New System.Drawing.Size(540, 638)
Me.TreeListCategories.TabIndex = 7
'
'colcategories_id
'
Me.colcategories_id.Caption = "categories_id"
Me.colcategories_id.FieldName = "categories_id"
Me.colcategories_id.Name = "colcategories_id"
'
'colparent_id
'
Me.colparent_id.Caption = "parent_id"
Me.colparent_id.FieldName = "parent_id"
Me.colparent_id.Name = "colparent_id"
'
'colcategories_type
'
Me.colcategories_type.Caption = "categories_type"
Me.colcategories_type.FieldName = "categories_type"
Me.colcategories_type.Name = "colcategories_type"
Me.colcategories_type.Visible = true
Me.colcategories_type.VisibleIndex = 1
Me.colcategories_type.Width = 167
'
'colcategories_name
'
Me.colcategories_name.Caption = "categories_name"
Me.colcategories_name.FieldName = "categories_name"
Me.colcategories_name.Name = "colcategories_name"
Me.colcategories_name.SortOrder = System.Windows.Forms.SortOrder.Ascending
Me.colcategories_name.Visible = true
Me.colcategories_name.VisibleIndex = 0
Me.colcategories_name.Width = 167
'
'PanelControl11
'
Me.PanelControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl11.Controls.Add(Me.btnCategories)
Me.PanelControl11.Dock = System.Windows.Forms.DockStyle.Bottom
Me.PanelControl11.Location = New System.Drawing.Point(2, 640)
Me.PanelControl11.Name = "PanelControl11"
Me.PanelControl11.Size = New System.Drawing.Size(540, 48)
Me.PanelControl11.TabIndex = 8
'
'btnCategories
'
Me.btnCategories.Location = New System.Drawing.Point(8, 16)
Me.btnCategories.Name = "btnCategories"
Me.btnCategories.Size = New System.Drawing.Size(120, 23)
Me.btnCategories.TabIndex = 0
Me.btnCategories.Text = "Manage Categories"
'
'tabEN
'
Me.tabEN.Controls.Add(Me.Panel7)
Me.tabEN.Controls.Add(Me.txtAwardEN)
Me.tabEN.Controls.Add(Me.pictEN)
Me.tabEN.Controls.Add(Me.txtImageEN)
Me.tabEN.Controls.Add(Me.LabelControl25)
Me.tabEN.Controls.Add(Me.LabelControl26)
Me.tabEN.Controls.Add(Me.txtURLEn)
Me.tabEN.Controls.Add(Me.LabelControl27)
Me.tabEN.Name = "tabEN"
Me.tabEN.Size = New System.Drawing.Size(1047, 690)
Me.tabEN.Text = "EN"
'
'Panel7
'
Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
Me.Panel7.AutoScroll = true
Me.Panel7.AutoSize = true
Me.Panel7.Controls.Add(Me.Panel8)
Me.Panel7.Location = New System.Drawing.Point(9, 156)
Me.Panel7.Name = "Panel7"
Me.Panel7.Size = New System.Drawing.Size(615, 512)
Me.Panel7.TabIndex = 35
'
'Panel8
'
Me.Panel8.AutoScroll = true
Me.Panel8.AutoScrollMargin = New System.Drawing.Size(10, 10)
Me.Panel8.AutoScrollMinSize = New System.Drawing.Size(10, 10)
Me.Panel8.Controls.Add(Me.GroupBox29)
Me.Panel8.Controls.Add(Me.GroupBox30)
Me.Panel8.Controls.Add(Me.GroupBox31)
Me.Panel8.Controls.Add(Me.GroupBox32)
Me.Panel8.Controls.Add(Me.GroupBox33)
Me.Panel8.Controls.Add(Me.GroupBox34)
Me.Panel8.Controls.Add(Me.GroupBox35)
Me.Panel8.Controls.Add(Me.GroupBox36)
Me.Panel8.Controls.Add(Me.GroupBox37)
Me.Panel8.Controls.Add(Me.GroupBox38)
Me.Panel8.Controls.Add(Me.GroupBox39)
Me.Panel8.Controls.Add(Me.GroupBox40)
Me.Panel8.Controls.Add(Me.GroupBox41)
Me.Panel8.Controls.Add(Me.GroupBox42)
Me.Panel8.Controls.Add(Me.GroupBox43)
Me.Panel8.Controls.Add(Me.GroupBox44)
Me.Panel8.Controls.Add(Me.GroupBox45)
Me.Panel8.Controls.Add(Me.GroupBox46)
Me.Panel8.Controls.Add(Me.GroupBox47)
Me.Panel8.Controls.Add(Me.GroupBox48)
Me.Panel8.Controls.Add(Me.GroupBox49)
Me.Panel8.Controls.Add(Me.GroupBox50)
Me.Panel8.Controls.Add(Me.GroupBox51)
Me.Panel8.Controls.Add(Me.GroupBox52)
Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
Me.Panel8.Location = New System.Drawing.Point(0, 0)
Me.Panel8.Name = "Panel8"
Me.Panel8.Size = New System.Drawing.Size(615, 512)
Me.Panel8.TabIndex = 16
'
'GroupBox29
'
Me.GroupBox29.Controls.Add(Me.txtDescEN24)
Me.GroupBox29.Controls.Add(Me.LabelControl24)
Me.GroupBox29.Controls.Add(Me.txtNameEN24)
Me.GroupBox29.Controls.Add(Me.LabelControl28)
Me.GroupBox29.Location = New System.Drawing.Point(3, 5099)
Me.GroupBox29.Name = "GroupBox29"
Me.GroupBox29.Size = New System.Drawing.Size(532, 216)
Me.GroupBox29.TabIndex = 54
Me.GroupBox29.TabStop = false
Me.GroupBox29.Text = "Episode24"
'
'txtDescEN24
'
Me.txtDescEN24.Enabled = false
Me.txtDescEN24.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN24.Name = "txtDescEN24"
Me.txtDescEN24.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN24.TabIndex = 16
'
'LabelControl24
'
Me.LabelControl24.Location = New System.Drawing.Point(6, 65)
Me.LabelControl24.Name = "LabelControl24"
Me.LabelControl24.Size = New System.Drawing.Size(93, 13)
Me.LabelControl24.TabIndex = 14
Me.LabelControl24.Text = "Product Description"
'
'txtNameEN24
'
Me.txtNameEN24.Enabled = false
Me.txtNameEN24.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN24.Name = "txtNameEN24"
Me.txtNameEN24.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN24.TabIndex = 13
'
'LabelControl28
'
Me.LabelControl28.Location = New System.Drawing.Point(45, 26)
Me.LabelControl28.Name = "LabelControl28"
Me.LabelControl28.Size = New System.Drawing.Size(67, 13)
Me.LabelControl28.TabIndex = 12
Me.LabelControl28.Text = "Product Name"
'
'GroupBox30
'
Me.GroupBox30.Controls.Add(Me.txtDescEN23)
Me.GroupBox30.Controls.Add(Me.LabelControl162)
Me.GroupBox30.Controls.Add(Me.txtNameEN23)
Me.GroupBox30.Controls.Add(Me.LabelControl163)
Me.GroupBox30.Location = New System.Drawing.Point(5, 4886)
Me.GroupBox30.Name = "GroupBox30"
Me.GroupBox30.Size = New System.Drawing.Size(532, 216)
Me.GroupBox30.TabIndex = 48
Me.GroupBox30.TabStop = false
Me.GroupBox30.Text = "Episode23"
'
'txtDescEN23
'
Me.txtDescEN23.Enabled = false
Me.txtDescEN23.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN23.Name = "txtDescEN23"
Me.txtDescEN23.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN23.TabIndex = 16
'
'LabelControl162
'
Me.LabelControl162.Location = New System.Drawing.Point(6, 65)
Me.LabelControl162.Name = "LabelControl162"
Me.LabelControl162.Size = New System.Drawing.Size(93, 13)
Me.LabelControl162.TabIndex = 14
Me.LabelControl162.Text = "Product Description"
'
'txtNameEN23
'
Me.txtNameEN23.Enabled = false
Me.txtNameEN23.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN23.Name = "txtNameEN23"
Me.txtNameEN23.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN23.TabIndex = 13
'
'LabelControl163
'
Me.LabelControl163.Location = New System.Drawing.Point(45, 26)
Me.LabelControl163.Name = "LabelControl163"
Me.LabelControl163.Size = New System.Drawing.Size(67, 13)
Me.LabelControl163.TabIndex = 12
Me.LabelControl163.Text = "Product Name"
'
'GroupBox31
'
Me.GroupBox31.Controls.Add(Me.txtDescEN22)
Me.GroupBox31.Controls.Add(Me.LabelControl164)
Me.GroupBox31.Controls.Add(Me.txtNameEN22)
Me.GroupBox31.Controls.Add(Me.LabelControl165)
Me.GroupBox31.Location = New System.Drawing.Point(6, 4665)
Me.GroupBox31.Name = "GroupBox31"
Me.GroupBox31.Size = New System.Drawing.Size(532, 216)
Me.GroupBox31.TabIndex = 46
Me.GroupBox31.TabStop = false
Me.GroupBox31.Text = "Episode22"
'
'txtDescEN22
'
Me.txtDescEN22.Enabled = false
Me.txtDescEN22.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN22.Name = "txtDescEN22"
Me.txtDescEN22.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN22.TabIndex = 16
'
'LabelControl164
'
Me.LabelControl164.Location = New System.Drawing.Point(6, 65)
Me.LabelControl164.Name = "LabelControl164"
Me.LabelControl164.Size = New System.Drawing.Size(93, 13)
Me.LabelControl164.TabIndex = 14
Me.LabelControl164.Text = "Product Description"
'
'txtNameEN22
'
Me.txtNameEN22.Enabled = false
Me.txtNameEN22.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN22.Name = "txtNameEN22"
Me.txtNameEN22.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN22.TabIndex = 13
'
'LabelControl165
'
Me.LabelControl165.Location = New System.Drawing.Point(45, 26)
Me.LabelControl165.Name = "LabelControl165"
Me.LabelControl165.Size = New System.Drawing.Size(67, 13)
Me.LabelControl165.TabIndex = 12
Me.LabelControl165.Text = "Product Name"
'
'GroupBox32
'
Me.GroupBox32.Controls.Add(Me.txtDescEN21)
Me.GroupBox32.Controls.Add(Me.LabelControl166)
Me.GroupBox32.Controls.Add(Me.txtNameEN21)
Me.GroupBox32.Controls.Add(Me.LabelControl167)
Me.GroupBox32.Location = New System.Drawing.Point(12, 4443)
Me.GroupBox32.Name = "GroupBox32"
Me.GroupBox32.Size = New System.Drawing.Size(532, 216)
Me.GroupBox32.TabIndex = 45
Me.GroupBox32.TabStop = false
Me.GroupBox32.Text = "Episode21"
'
'txtDescEN21
'
Me.txtDescEN21.Enabled = false
Me.txtDescEN21.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN21.Name = "txtDescEN21"
Me.txtDescEN21.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN21.TabIndex = 16
'
'LabelControl166
'
Me.LabelControl166.Location = New System.Drawing.Point(6, 65)
Me.LabelControl166.Name = "LabelControl166"
Me.LabelControl166.Size = New System.Drawing.Size(93, 13)
Me.LabelControl166.TabIndex = 14
Me.LabelControl166.Text = "Product Description"
'
'txtNameEN21
'
Me.txtNameEN21.Enabled = false
Me.txtNameEN21.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN21.Name = "txtNameEN21"
Me.txtNameEN21.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN21.TabIndex = 13
'
'LabelControl167
'
Me.LabelControl167.Location = New System.Drawing.Point(45, 26)
Me.LabelControl167.Name = "LabelControl167"
Me.LabelControl167.Size = New System.Drawing.Size(67, 13)
Me.LabelControl167.TabIndex = 12
Me.LabelControl167.Text = "Product Name"
'
'GroupBox33
'
Me.GroupBox33.Controls.Add(Me.txtDescEN20)
Me.GroupBox33.Controls.Add(Me.LabelControl168)
Me.GroupBox33.Controls.Add(Me.txtNameEN20)
Me.GroupBox33.Controls.Add(Me.LabelControl169)
Me.GroupBox33.Location = New System.Drawing.Point(6, 4221)
Me.GroupBox33.Name = "GroupBox33"
Me.GroupBox33.Size = New System.Drawing.Size(532, 216)
Me.GroupBox33.TabIndex = 41
Me.GroupBox33.TabStop = false
Me.GroupBox33.Text = "Episode20"
'
'txtDescEN20
'
Me.txtDescEN20.Enabled = false
Me.txtDescEN20.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN20.Name = "txtDescEN20"
Me.txtDescEN20.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN20.TabIndex = 16
'
'LabelControl168
'
Me.LabelControl168.Location = New System.Drawing.Point(6, 65)
Me.LabelControl168.Name = "LabelControl168"
Me.LabelControl168.Size = New System.Drawing.Size(93, 13)
Me.LabelControl168.TabIndex = 14
Me.LabelControl168.Text = "Product Description"
'
'txtNameEN20
'
Me.txtNameEN20.Enabled = false
Me.txtNameEN20.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN20.Name = "txtNameEN20"
Me.txtNameEN20.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN20.TabIndex = 13
'
'LabelControl169
'
Me.LabelControl169.Location = New System.Drawing.Point(45, 26)
Me.LabelControl169.Name = "LabelControl169"
Me.LabelControl169.Size = New System.Drawing.Size(67, 13)
Me.LabelControl169.TabIndex = 12
Me.LabelControl169.Text = "Product Name"
'
'GroupBox34
'
Me.GroupBox34.Controls.Add(Me.txtDescEN19)
Me.GroupBox34.Controls.Add(Me.LabelControl170)
Me.GroupBox34.Controls.Add(Me.txtNameEN19)
Me.GroupBox34.Controls.Add(Me.LabelControl171)
Me.GroupBox34.Location = New System.Drawing.Point(6, 4001)
Me.GroupBox34.Name = "GroupBox34"
Me.GroupBox34.Size = New System.Drawing.Size(532, 216)
Me.GroupBox34.TabIndex = 39
Me.GroupBox34.TabStop = false
Me.GroupBox34.Text = "Episode19"
'
'txtDescEN19
'
Me.txtDescEN19.Enabled = false
Me.txtDescEN19.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN19.Name = "txtDescEN19"
Me.txtDescEN19.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN19.TabIndex = 16
'
'LabelControl170
'
Me.LabelControl170.Location = New System.Drawing.Point(6, 65)
Me.LabelControl170.Name = "LabelControl170"
Me.LabelControl170.Size = New System.Drawing.Size(93, 13)
Me.LabelControl170.TabIndex = 14
Me.LabelControl170.Text = "Product Description"
'
'txtNameEN19
'
Me.txtNameEN19.Enabled = false
Me.txtNameEN19.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN19.Name = "txtNameEN19"
Me.txtNameEN19.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN19.TabIndex = 13
'
'LabelControl171
'
Me.LabelControl171.Location = New System.Drawing.Point(45, 26)
Me.LabelControl171.Name = "LabelControl171"
Me.LabelControl171.Size = New System.Drawing.Size(67, 13)
Me.LabelControl171.TabIndex = 12
Me.LabelControl171.Text = "Product Name"
'
'GroupBox35
'
Me.GroupBox35.Controls.Add(Me.txtDescEN18)
Me.GroupBox35.Controls.Add(Me.LabelControl172)
Me.GroupBox35.Controls.Add(Me.txtNameEN18)
Me.GroupBox35.Controls.Add(Me.LabelControl173)
Me.GroupBox35.Location = New System.Drawing.Point(6, 3782)
Me.GroupBox35.Name = "GroupBox35"
Me.GroupBox35.Size = New System.Drawing.Size(532, 216)
Me.GroupBox35.TabIndex = 38
Me.GroupBox35.TabStop = false
Me.GroupBox35.Text = "Episode18"
'
'txtDescEN18
'
Me.txtDescEN18.Enabled = false
Me.txtDescEN18.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN18.Name = "txtDescEN18"
Me.txtDescEN18.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN18.TabIndex = 16
'
'LabelControl172
'
Me.LabelControl172.Location = New System.Drawing.Point(6, 65)
Me.LabelControl172.Name = "LabelControl172"
Me.LabelControl172.Size = New System.Drawing.Size(93, 13)
Me.LabelControl172.TabIndex = 14
Me.LabelControl172.Text = "Product Description"
'
'txtNameEN18
'
Me.txtNameEN18.Enabled = false
Me.txtNameEN18.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN18.Name = "txtNameEN18"
Me.txtNameEN18.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN18.TabIndex = 13
'
'LabelControl173
'
Me.LabelControl173.Location = New System.Drawing.Point(45, 26)
Me.LabelControl173.Name = "LabelControl173"
Me.LabelControl173.Size = New System.Drawing.Size(67, 13)
Me.LabelControl173.TabIndex = 12
Me.LabelControl173.Text = "Product Name"
'
'GroupBox36
'
Me.GroupBox36.Controls.Add(Me.txtDescEN17)
Me.GroupBox36.Controls.Add(Me.LabelControl174)
Me.GroupBox36.Controls.Add(Me.txtNameEN17)
Me.GroupBox36.Controls.Add(Me.LabelControl175)
Me.GroupBox36.Location = New System.Drawing.Point(12, 3560)
Me.GroupBox36.Name = "GroupBox36"
Me.GroupBox36.Size = New System.Drawing.Size(532, 216)
Me.GroupBox36.TabIndex = 37
Me.GroupBox36.TabStop = false
Me.GroupBox36.Text = "Episode17"
'
'txtDescEN17
'
Me.txtDescEN17.Enabled = false
Me.txtDescEN17.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN17.Name = "txtDescEN17"
Me.txtDescEN17.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN17.TabIndex = 16
'
'LabelControl174
'
Me.LabelControl174.Location = New System.Drawing.Point(6, 65)
Me.LabelControl174.Name = "LabelControl174"
Me.LabelControl174.Size = New System.Drawing.Size(93, 13)
Me.LabelControl174.TabIndex = 14
Me.LabelControl174.Text = "Product Description"
'
'txtNameEN17
'
Me.txtNameEN17.Enabled = false
Me.txtNameEN17.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN17.Name = "txtNameEN17"
Me.txtNameEN17.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN17.TabIndex = 13
'
'LabelControl175
'
Me.LabelControl175.Location = New System.Drawing.Point(45, 26)
Me.LabelControl175.Name = "LabelControl175"
Me.LabelControl175.Size = New System.Drawing.Size(67, 13)
Me.LabelControl175.TabIndex = 12
Me.LabelControl175.Text = "Product Name"
'
'GroupBox37
'
Me.GroupBox37.Controls.Add(Me.txtDescEN16)
Me.GroupBox37.Controls.Add(Me.LabelControl176)
Me.GroupBox37.Controls.Add(Me.txtNameEN16)
Me.GroupBox37.Controls.Add(Me.LabelControl177)
Me.GroupBox37.Location = New System.Drawing.Point(12, 3342)
Me.GroupBox37.Name = "GroupBox37"
Me.GroupBox37.Size = New System.Drawing.Size(532, 216)
Me.GroupBox37.TabIndex = 35
Me.GroupBox37.TabStop = false
Me.GroupBox37.Text = "Episode16"
'
'txtDescEN16
'
Me.txtDescEN16.Enabled = false
Me.txtDescEN16.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN16.Name = "txtDescEN16"
Me.txtDescEN16.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN16.TabIndex = 16
'
'LabelControl176
'
Me.LabelControl176.Location = New System.Drawing.Point(6, 65)
Me.LabelControl176.Name = "LabelControl176"
Me.LabelControl176.Size = New System.Drawing.Size(93, 13)
Me.LabelControl176.TabIndex = 14
Me.LabelControl176.Text = "Product Description"
'
'txtNameEN16
'
Me.txtNameEN16.Enabled = false
Me.txtNameEN16.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN16.Name = "txtNameEN16"
Me.txtNameEN16.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN16.TabIndex = 13
'
'LabelControl177
'
Me.LabelControl177.Location = New System.Drawing.Point(45, 26)
Me.LabelControl177.Name = "LabelControl177"
Me.LabelControl177.Size = New System.Drawing.Size(67, 13)
Me.LabelControl177.TabIndex = 12
Me.LabelControl177.Text = "Product Name"
'
'GroupBox38
'
Me.GroupBox38.Controls.Add(Me.txtDescEN15)
Me.GroupBox38.Controls.Add(Me.LabelControl178)
Me.GroupBox38.Controls.Add(Me.txtNameEN15)
Me.GroupBox38.Controls.Add(Me.LabelControl179)
Me.GroupBox38.Location = New System.Drawing.Point(12, 3122)
Me.GroupBox38.Name = "GroupBox38"
Me.GroupBox38.Size = New System.Drawing.Size(532, 216)
Me.GroupBox38.TabIndex = 34
Me.GroupBox38.TabStop = false
Me.GroupBox38.Text = "Episode15"
'
'txtDescEN15
'
Me.txtDescEN15.Enabled = false
Me.txtDescEN15.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN15.Name = "txtDescEN15"
Me.txtDescEN15.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN15.TabIndex = 16
'
'LabelControl178
'
Me.LabelControl178.Location = New System.Drawing.Point(6, 65)
Me.LabelControl178.Name = "LabelControl178"
Me.LabelControl178.Size = New System.Drawing.Size(93, 13)
Me.LabelControl178.TabIndex = 14
Me.LabelControl178.Text = "Product Description"
'
'txtNameEN15
'
Me.txtNameEN15.Enabled = false
Me.txtNameEN15.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN15.Name = "txtNameEN15"
Me.txtNameEN15.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN15.TabIndex = 13
'
'LabelControl179
'
Me.LabelControl179.Location = New System.Drawing.Point(45, 26)
Me.LabelControl179.Name = "LabelControl179"
Me.LabelControl179.Size = New System.Drawing.Size(67, 13)
Me.LabelControl179.TabIndex = 12
Me.LabelControl179.Text = "Product Name"
'
'GroupBox39
'
Me.GroupBox39.Controls.Add(Me.txtDescEN14)
Me.GroupBox39.Controls.Add(Me.LabelControl180)
Me.GroupBox39.Controls.Add(Me.txtNameEN14)
Me.GroupBox39.Controls.Add(Me.LabelControl181)
Me.GroupBox39.Location = New System.Drawing.Point(12, 2900)
Me.GroupBox39.Name = "GroupBox39"
Me.GroupBox39.Size = New System.Drawing.Size(532, 216)
Me.GroupBox39.TabIndex = 32
Me.GroupBox39.TabStop = false
Me.GroupBox39.Text = "Episode14"
'
'txtDescEN14
'
Me.txtDescEN14.Enabled = false
Me.txtDescEN14.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN14.Name = "txtDescEN14"
Me.txtDescEN14.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN14.TabIndex = 16
'
'LabelControl180
'
Me.LabelControl180.Location = New System.Drawing.Point(6, 65)
Me.LabelControl180.Name = "LabelControl180"
Me.LabelControl180.Size = New System.Drawing.Size(93, 13)
Me.LabelControl180.TabIndex = 14
Me.LabelControl180.Text = "Product Description"
'
'txtNameEN14
'
Me.txtNameEN14.Enabled = false
Me.txtNameEN14.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN14.Name = "txtNameEN14"
Me.txtNameEN14.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN14.TabIndex = 13
'
'LabelControl181
'
Me.LabelControl181.Location = New System.Drawing.Point(45, 26)
Me.LabelControl181.Name = "LabelControl181"
Me.LabelControl181.Size = New System.Drawing.Size(67, 13)
Me.LabelControl181.TabIndex = 12
Me.LabelControl181.Text = "Product Name"
'
'GroupBox40
'
Me.GroupBox40.Controls.Add(Me.txtDescEN13)
Me.GroupBox40.Controls.Add(Me.LabelControl182)
Me.GroupBox40.Controls.Add(Me.txtNameEN13)
Me.GroupBox40.Controls.Add(Me.LabelControl183)
Me.GroupBox40.Location = New System.Drawing.Point(12, 2677)
Me.GroupBox40.Name = "GroupBox40"
Me.GroupBox40.Size = New System.Drawing.Size(532, 216)
Me.GroupBox40.TabIndex = 30
Me.GroupBox40.TabStop = false
Me.GroupBox40.Text = "Episode13"
'
'txtDescEN13
'
Me.txtDescEN13.Enabled = false
Me.txtDescEN13.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN13.Name = "txtDescEN13"
Me.txtDescEN13.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN13.TabIndex = 16
'
'LabelControl182
'
Me.LabelControl182.Location = New System.Drawing.Point(6, 65)
Me.LabelControl182.Name = "LabelControl182"
Me.LabelControl182.Size = New System.Drawing.Size(93, 13)
Me.LabelControl182.TabIndex = 14
Me.LabelControl182.Text = "Product Description"
'
'txtNameEN13
'
Me.txtNameEN13.Enabled = false
Me.txtNameEN13.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN13.Name = "txtNameEN13"
Me.txtNameEN13.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN13.TabIndex = 13
'
'LabelControl183
'
Me.LabelControl183.Location = New System.Drawing.Point(45, 26)
Me.LabelControl183.Name = "LabelControl183"
Me.LabelControl183.Size = New System.Drawing.Size(67, 13)
Me.LabelControl183.TabIndex = 12
Me.LabelControl183.Text = "Product Name"
'
'GroupBox41
'
Me.GroupBox41.Controls.Add(Me.txtDescEN12)
Me.GroupBox41.Controls.Add(Me.LabelControl184)
Me.GroupBox41.Controls.Add(Me.txtNameEN12)
Me.GroupBox41.Controls.Add(Me.LabelControl185)
Me.GroupBox41.Location = New System.Drawing.Point(12, 2455)
Me.GroupBox41.Name = "GroupBox41"
Me.GroupBox41.Size = New System.Drawing.Size(532, 216)
Me.GroupBox41.TabIndex = 29
Me.GroupBox41.TabStop = false
Me.GroupBox41.Text = "Episode12"
'
'txtDescEN12
'
Me.txtDescEN12.Enabled = false
Me.txtDescEN12.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN12.Name = "txtDescEN12"
Me.txtDescEN12.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN12.TabIndex = 16
'
'LabelControl184
'
Me.LabelControl184.Location = New System.Drawing.Point(6, 65)
Me.LabelControl184.Name = "LabelControl184"
Me.LabelControl184.Size = New System.Drawing.Size(93, 13)
Me.LabelControl184.TabIndex = 14
Me.LabelControl184.Text = "Product Description"
'
'txtNameEN12
'
Me.txtNameEN12.Enabled = false
Me.txtNameEN12.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN12.Name = "txtNameEN12"
Me.txtNameEN12.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN12.TabIndex = 13
'
'LabelControl185
'
Me.LabelControl185.Location = New System.Drawing.Point(45, 26)
Me.LabelControl185.Name = "LabelControl185"
Me.LabelControl185.Size = New System.Drawing.Size(67, 13)
Me.LabelControl185.TabIndex = 12
Me.LabelControl185.Text = "Product Name"
'
'GroupBox42
'
Me.GroupBox42.Controls.Add(Me.txtDescEN11)
Me.GroupBox42.Controls.Add(Me.LabelControl186)
Me.GroupBox42.Controls.Add(Me.txtNameEN11)
Me.GroupBox42.Controls.Add(Me.LabelControl187)
Me.GroupBox42.Location = New System.Drawing.Point(12, 2233)
Me.GroupBox42.Name = "GroupBox42"
Me.GroupBox42.Size = New System.Drawing.Size(532, 216)
Me.GroupBox42.TabIndex = 28
Me.GroupBox42.TabStop = false
Me.GroupBox42.Text = "Episode11"
'
'txtDescEN11
'
Me.txtDescEN11.Enabled = false
Me.txtDescEN11.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN11.Name = "txtDescEN11"
Me.txtDescEN11.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN11.TabIndex = 16
'
'LabelControl186
'
Me.LabelControl186.Location = New System.Drawing.Point(6, 65)
Me.LabelControl186.Name = "LabelControl186"
Me.LabelControl186.Size = New System.Drawing.Size(93, 13)
Me.LabelControl186.TabIndex = 14
Me.LabelControl186.Text = "Product Description"
'
'txtNameEN11
'
Me.txtNameEN11.Enabled = false
Me.txtNameEN11.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN11.Name = "txtNameEN11"
Me.txtNameEN11.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN11.TabIndex = 13
'
'LabelControl187
'
Me.LabelControl187.Location = New System.Drawing.Point(45, 26)
Me.LabelControl187.Name = "LabelControl187"
Me.LabelControl187.Size = New System.Drawing.Size(67, 13)
Me.LabelControl187.TabIndex = 12
Me.LabelControl187.Text = "Product Name"
'
'GroupBox43
'
Me.GroupBox43.Controls.Add(Me.txtDescEN10)
Me.GroupBox43.Controls.Add(Me.LabelControl188)
Me.GroupBox43.Controls.Add(Me.txtNameEN10)
Me.GroupBox43.Controls.Add(Me.LabelControl189)
Me.GroupBox43.Location = New System.Drawing.Point(12, 2011)
Me.GroupBox43.Name = "GroupBox43"
Me.GroupBox43.Size = New System.Drawing.Size(532, 216)
Me.GroupBox43.TabIndex = 27
Me.GroupBox43.TabStop = false
Me.GroupBox43.Text = "Episode10"
'
'txtDescEN10
'
Me.txtDescEN10.Enabled = false
Me.txtDescEN10.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN10.Name = "txtDescEN10"
Me.txtDescEN10.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN10.TabIndex = 16
'
'LabelControl188
'
Me.LabelControl188.Location = New System.Drawing.Point(6, 65)
Me.LabelControl188.Name = "LabelControl188"
Me.LabelControl188.Size = New System.Drawing.Size(93, 13)
Me.LabelControl188.TabIndex = 14
Me.LabelControl188.Text = "Product Description"
'
'txtNameEN10
'
Me.txtNameEN10.Enabled = false
Me.txtNameEN10.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN10.Name = "txtNameEN10"
Me.txtNameEN10.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN10.TabIndex = 13
'
'LabelControl189
'
Me.LabelControl189.Location = New System.Drawing.Point(45, 26)
Me.LabelControl189.Name = "LabelControl189"
Me.LabelControl189.Size = New System.Drawing.Size(67, 13)
Me.LabelControl189.TabIndex = 12
Me.LabelControl189.Text = "Product Name"
'
'GroupBox44
'
Me.GroupBox44.Controls.Add(Me.txtDescEN9)
Me.GroupBox44.Controls.Add(Me.LabelControl190)
Me.GroupBox44.Controls.Add(Me.txtNameEN9)
Me.GroupBox44.Controls.Add(Me.LabelControl191)
Me.GroupBox44.Location = New System.Drawing.Point(12, 1789)
Me.GroupBox44.Name = "GroupBox44"
Me.GroupBox44.Size = New System.Drawing.Size(532, 216)
Me.GroupBox44.TabIndex = 25
Me.GroupBox44.TabStop = false
Me.GroupBox44.Text = "Episode9"
'
'txtDescEN9
'
Me.txtDescEN9.Enabled = false
Me.txtDescEN9.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN9.Name = "txtDescEN9"
Me.txtDescEN9.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN9.TabIndex = 16
'
'LabelControl190
'
Me.LabelControl190.Location = New System.Drawing.Point(6, 65)
Me.LabelControl190.Name = "LabelControl190"
Me.LabelControl190.Size = New System.Drawing.Size(93, 13)
Me.LabelControl190.TabIndex = 14
Me.LabelControl190.Text = "Product Description"
'
'txtNameEN9
'
Me.txtNameEN9.Enabled = false
Me.txtNameEN9.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN9.Name = "txtNameEN9"
Me.txtNameEN9.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN9.TabIndex = 13
'
'LabelControl191
'
Me.LabelControl191.Location = New System.Drawing.Point(45, 26)
Me.LabelControl191.Name = "LabelControl191"
Me.LabelControl191.Size = New System.Drawing.Size(67, 13)
Me.LabelControl191.TabIndex = 12
Me.LabelControl191.Text = "Product Name"
'
'GroupBox45
'
Me.GroupBox45.Controls.Add(Me.txtDescEN8)
Me.GroupBox45.Controls.Add(Me.LabelControl192)
Me.GroupBox45.Controls.Add(Me.txtNameEN8)
Me.GroupBox45.Controls.Add(Me.LabelControl193)
Me.GroupBox45.Location = New System.Drawing.Point(12, 1567)
Me.GroupBox45.Name = "GroupBox45"
Me.GroupBox45.Size = New System.Drawing.Size(532, 216)
Me.GroupBox45.TabIndex = 23
Me.GroupBox45.TabStop = false
Me.GroupBox45.Text = "Episode8"
'
'txtDescEN8
'
Me.txtDescEN8.Enabled = false
Me.txtDescEN8.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN8.Name = "txtDescEN8"
Me.txtDescEN8.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN8.TabIndex = 16
'
'LabelControl192
'
Me.LabelControl192.Location = New System.Drawing.Point(6, 65)
Me.LabelControl192.Name = "LabelControl192"
Me.LabelControl192.Size = New System.Drawing.Size(93, 13)
Me.LabelControl192.TabIndex = 14
Me.LabelControl192.Text = "Product Description"
'
'txtNameEN8
'
Me.txtNameEN8.Enabled = false
Me.txtNameEN8.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN8.Name = "txtNameEN8"
Me.txtNameEN8.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN8.TabIndex = 13
'
'LabelControl193
'
Me.LabelControl193.Location = New System.Drawing.Point(45, 26)
Me.LabelControl193.Name = "LabelControl193"
Me.LabelControl193.Size = New System.Drawing.Size(67, 13)
Me.LabelControl193.TabIndex = 12
Me.LabelControl193.Text = "Product Name"
'
'GroupBox46
'
Me.GroupBox46.Controls.Add(Me.txtDescEN7)
Me.GroupBox46.Controls.Add(Me.LabelControl194)
Me.GroupBox46.Controls.Add(Me.txtNameEN7)
Me.GroupBox46.Controls.Add(Me.LabelControl195)
Me.GroupBox46.Location = New System.Drawing.Point(12, 1345)
Me.GroupBox46.Name = "GroupBox46"
Me.GroupBox46.Size = New System.Drawing.Size(532, 216)
Me.GroupBox46.TabIndex = 21
Me.GroupBox46.TabStop = false
Me.GroupBox46.Text = "Episode7"
'
'txtDescEN7
'
Me.txtDescEN7.Enabled = false
Me.txtDescEN7.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN7.Name = "txtDescEN7"
Me.txtDescEN7.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN7.TabIndex = 16
'
'LabelControl194
'
Me.LabelControl194.Location = New System.Drawing.Point(6, 65)
Me.LabelControl194.Name = "LabelControl194"
Me.LabelControl194.Size = New System.Drawing.Size(93, 13)
Me.LabelControl194.TabIndex = 14
Me.LabelControl194.Text = "Product Description"
'
'txtNameEN7
'
Me.txtNameEN7.Enabled = false
Me.txtNameEN7.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN7.Name = "txtNameEN7"
Me.txtNameEN7.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN7.TabIndex = 13
'
'LabelControl195
'
Me.LabelControl195.Location = New System.Drawing.Point(45, 26)
Me.LabelControl195.Name = "LabelControl195"
Me.LabelControl195.Size = New System.Drawing.Size(67, 13)
Me.LabelControl195.TabIndex = 12
Me.LabelControl195.Text = "Product Name"
'
'GroupBox47
'
Me.GroupBox47.Controls.Add(Me.txtDescEN6)
Me.GroupBox47.Controls.Add(Me.LabelControl196)
Me.GroupBox47.Controls.Add(Me.txtNameEN6)
Me.GroupBox47.Controls.Add(Me.LabelControl197)
Me.GroupBox47.Location = New System.Drawing.Point(12, 1123)
Me.GroupBox47.Name = "GroupBox47"
Me.GroupBox47.Size = New System.Drawing.Size(532, 216)
Me.GroupBox47.TabIndex = 20
Me.GroupBox47.TabStop = false
Me.GroupBox47.Text = "Episode6"
'
'txtDescEN6
'
Me.txtDescEN6.Enabled = false
Me.txtDescEN6.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN6.Name = "txtDescEN6"
Me.txtDescEN6.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN6.TabIndex = 16
'
'LabelControl196
'
Me.LabelControl196.Location = New System.Drawing.Point(6, 65)
Me.LabelControl196.Name = "LabelControl196"
Me.LabelControl196.Size = New System.Drawing.Size(93, 13)
Me.LabelControl196.TabIndex = 14
Me.LabelControl196.Text = "Product Description"
'
'txtNameEN6
'
Me.txtNameEN6.Enabled = false
Me.txtNameEN6.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN6.Name = "txtNameEN6"
Me.txtNameEN6.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN6.TabIndex = 13
'
'LabelControl197
'
Me.LabelControl197.Location = New System.Drawing.Point(45, 26)
Me.LabelControl197.Name = "LabelControl197"
Me.LabelControl197.Size = New System.Drawing.Size(67, 13)
Me.LabelControl197.TabIndex = 12
Me.LabelControl197.Text = "Product Name"
'
'GroupBox48
'
Me.GroupBox48.Controls.Add(Me.txtDescEN5)
Me.GroupBox48.Controls.Add(Me.LabelControl198)
Me.GroupBox48.Controls.Add(Me.txtNameEN5)
Me.GroupBox48.Controls.Add(Me.LabelControl199)
Me.GroupBox48.Location = New System.Drawing.Point(12, 901)
Me.GroupBox48.Name = "GroupBox48"
Me.GroupBox48.Size = New System.Drawing.Size(532, 216)
Me.GroupBox48.TabIndex = 19
Me.GroupBox48.TabStop = false
Me.GroupBox48.Text = "Episode5"
'
'txtDescEN5
'
Me.txtDescEN5.Enabled = false
Me.txtDescEN5.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN5.Name = "txtDescEN5"
Me.txtDescEN5.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN5.TabIndex = 16
'
'LabelControl198
'
Me.LabelControl198.Location = New System.Drawing.Point(6, 65)
Me.LabelControl198.Name = "LabelControl198"
Me.LabelControl198.Size = New System.Drawing.Size(93, 13)
Me.LabelControl198.TabIndex = 14
Me.LabelControl198.Text = "Product Description"
'
'txtNameEN5
'
Me.txtNameEN5.Enabled = false
Me.txtNameEN5.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN5.Name = "txtNameEN5"
Me.txtNameEN5.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN5.TabIndex = 13
'
'LabelControl199
'
Me.LabelControl199.Location = New System.Drawing.Point(45, 26)
Me.LabelControl199.Name = "LabelControl199"
Me.LabelControl199.Size = New System.Drawing.Size(67, 13)
Me.LabelControl199.TabIndex = 12
Me.LabelControl199.Text = "Product Name"
'
'GroupBox49
'
Me.GroupBox49.Controls.Add(Me.txtDescEN4)
Me.GroupBox49.Controls.Add(Me.LabelControl200)
Me.GroupBox49.Controls.Add(Me.txtNameEN4)
Me.GroupBox49.Controls.Add(Me.LabelControl201)
Me.GroupBox49.Location = New System.Drawing.Point(12, 679)
Me.GroupBox49.Name = "GroupBox49"
Me.GroupBox49.Size = New System.Drawing.Size(532, 216)
Me.GroupBox49.TabIndex = 18
Me.GroupBox49.TabStop = false
Me.GroupBox49.Text = "Episode4"
'
'txtDescEN4
'
Me.txtDescEN4.Enabled = false
Me.txtDescEN4.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN4.Name = "txtDescEN4"
Me.txtDescEN4.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN4.TabIndex = 16
'
'LabelControl200
'
Me.LabelControl200.Location = New System.Drawing.Point(6, 65)
Me.LabelControl200.Name = "LabelControl200"
Me.LabelControl200.Size = New System.Drawing.Size(93, 13)
Me.LabelControl200.TabIndex = 14
Me.LabelControl200.Text = "Product Description"
'
'txtNameEN4
'
Me.txtNameEN4.Enabled = false
Me.txtNameEN4.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN4.Name = "txtNameEN4"
Me.txtNameEN4.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN4.TabIndex = 13
'
'LabelControl201
'
Me.LabelControl201.Location = New System.Drawing.Point(45, 26)
Me.LabelControl201.Name = "LabelControl201"
Me.LabelControl201.Size = New System.Drawing.Size(67, 13)
Me.LabelControl201.TabIndex = 12
Me.LabelControl201.Text = "Product Name"
'
'GroupBox50
'
Me.GroupBox50.Controls.Add(Me.txtDescEN3)
Me.GroupBox50.Controls.Add(Me.LabelControl202)
Me.GroupBox50.Controls.Add(Me.txtNameEN3)
Me.GroupBox50.Controls.Add(Me.LabelControl203)
Me.GroupBox50.Location = New System.Drawing.Point(12, 457)
Me.GroupBox50.Name = "GroupBox50"
Me.GroupBox50.Size = New System.Drawing.Size(532, 216)
Me.GroupBox50.TabIndex = 17
Me.GroupBox50.TabStop = false
Me.GroupBox50.Text = "Episode3"
'
'txtDescEN3
'
Me.txtDescEN3.Enabled = false
Me.txtDescEN3.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN3.Name = "txtDescEN3"
Me.txtDescEN3.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN3.TabIndex = 16
'
'LabelControl202
'
Me.LabelControl202.Location = New System.Drawing.Point(6, 65)
Me.LabelControl202.Name = "LabelControl202"
Me.LabelControl202.Size = New System.Drawing.Size(93, 13)
Me.LabelControl202.TabIndex = 14
Me.LabelControl202.Text = "Product Description"
'
'txtNameEN3
'
Me.txtNameEN3.Enabled = false
Me.txtNameEN3.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN3.Name = "txtNameEN3"
Me.txtNameEN3.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN3.TabIndex = 13
'
'LabelControl203
'
Me.LabelControl203.Location = New System.Drawing.Point(45, 26)
Me.LabelControl203.Name = "LabelControl203"
Me.LabelControl203.Size = New System.Drawing.Size(67, 13)
Me.LabelControl203.TabIndex = 12
Me.LabelControl203.Text = "Product Name"
'
'GroupBox51
'
Me.GroupBox51.Controls.Add(Me.txtDescEN2)
Me.GroupBox51.Controls.Add(Me.LabelControl204)
Me.GroupBox51.Controls.Add(Me.txtNameEN2)
Me.GroupBox51.Controls.Add(Me.LabelControl205)
Me.GroupBox51.Location = New System.Drawing.Point(12, 235)
Me.GroupBox51.Name = "GroupBox51"
Me.GroupBox51.Size = New System.Drawing.Size(532, 216)
Me.GroupBox51.TabIndex = 16
Me.GroupBox51.TabStop = false
Me.GroupBox51.Text = "Episode2"
'
'txtDescEN2
'
Me.txtDescEN2.Enabled = false
Me.txtDescEN2.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN2.Name = "txtDescEN2"
Me.txtDescEN2.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN2.TabIndex = 16
'
'LabelControl204
'
Me.LabelControl204.Location = New System.Drawing.Point(6, 65)
Me.LabelControl204.Name = "LabelControl204"
Me.LabelControl204.Size = New System.Drawing.Size(93, 13)
Me.LabelControl204.TabIndex = 14
Me.LabelControl204.Text = "Product Description"
'
'txtNameEN2
'
Me.txtNameEN2.Enabled = false
Me.txtNameEN2.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN2.Name = "txtNameEN2"
Me.txtNameEN2.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN2.TabIndex = 13
'
'LabelControl205
'
Me.LabelControl205.Location = New System.Drawing.Point(45, 26)
Me.LabelControl205.Name = "LabelControl205"
Me.LabelControl205.Size = New System.Drawing.Size(67, 13)
Me.LabelControl205.TabIndex = 12
Me.LabelControl205.Text = "Product Name"
'
'GroupBox52
'
Me.GroupBox52.Controls.Add(Me.txtDescEN1)
Me.GroupBox52.Controls.Add(Me.LabelControl206)
Me.GroupBox52.Controls.Add(Me.txtNameEN1)
Me.GroupBox52.Controls.Add(Me.LabelControl207)
Me.GroupBox52.Location = New System.Drawing.Point(12, 13)
Me.GroupBox52.Name = "GroupBox52"
Me.GroupBox52.Size = New System.Drawing.Size(532, 216)
Me.GroupBox52.TabIndex = 15
Me.GroupBox52.TabStop = false
Me.GroupBox52.Text = "Episode1"
'
'txtDescEN1
'
Me.txtDescEN1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_description", true))
Me.txtDescEN1.Enabled = false
Me.txtDescEN1.Location = New System.Drawing.Point(118, 63)
Me.txtDescEN1.Name = "txtDescEN1"
Me.txtDescEN1.Size = New System.Drawing.Size(408, 129)
Me.txtDescEN1.TabIndex = 16
'
'LabelControl206
'
Me.LabelControl206.Location = New System.Drawing.Point(6, 65)
Me.LabelControl206.Name = "LabelControl206"
Me.LabelControl206.Size = New System.Drawing.Size(93, 13)
Me.LabelControl206.TabIndex = 14
Me.LabelControl206.Text = "Product Description"
'
'txtNameEN1
'
Me.txtNameEN1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_name", true))
Me.txtNameEN1.Enabled = false
Me.txtNameEN1.Location = New System.Drawing.Point(118, 23)
Me.txtNameEN1.Name = "txtNameEN1"
Me.txtNameEN1.Size = New System.Drawing.Size(408, 20)
Me.txtNameEN1.TabIndex = 13
'
'LabelControl207
'
Me.LabelControl207.Location = New System.Drawing.Point(45, 26)
Me.LabelControl207.Name = "LabelControl207"
Me.LabelControl207.Size = New System.Drawing.Size(67, 13)
Me.LabelControl207.TabIndex = 12
Me.LabelControl207.Text = "Product Name"
'
'txtAwardEN
'
Me.txtAwardEN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_awards", true))
Me.txtAwardEN.Enabled = false
Me.txtAwardEN.Location = New System.Drawing.Point(128, 41)
Me.txtAwardEN.Name = "txtAwardEN"
Me.txtAwardEN.Size = New System.Drawing.Size(408, 80)
Me.txtAwardEN.TabIndex = 34
'
'pictEN
'
Me.pictEN.Location = New System.Drawing.Point(706, 16)
Me.pictEN.Name = "pictEN"
Me.pictEN.Properties.ReadOnly = true
Me.pictEN.Size = New System.Drawing.Size(280, 320)
Me.pictEN.TabIndex = 31
'
'txtImageEN
'
Me.txtImageEN.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_image_big", true))
Me.txtImageEN.Enabled = false
Me.txtImageEN.Location = New System.Drawing.Point(128, 129)
Me.txtImageEN.Name = "txtImageEN"
Me.txtImageEN.Size = New System.Drawing.Size(408, 20)
Me.txtImageEN.TabIndex = 30
'
'LabelControl25
'
Me.LabelControl25.Location = New System.Drawing.Point(16, 129)
Me.LabelControl25.Name = "LabelControl25"
Me.LabelControl25.Size = New System.Drawing.Size(70, 13)
Me.LabelControl25.TabIndex = 29
Me.LabelControl25.Text = "Product Image"
'
'LabelControl26
'
Me.LabelControl26.Location = New System.Drawing.Point(16, 41)
Me.LabelControl26.Name = "LabelControl26"
Me.LabelControl26.Size = New System.Drawing.Size(71, 13)
Me.LabelControl26.TabIndex = 27
Me.LabelControl26.Text = "Product Award"
'
'txtURLEn
'
Me.txtURLEn.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_en.products_url", true))
Me.txtURLEn.Enabled = false
Me.txtURLEn.Location = New System.Drawing.Point(128, 17)
Me.txtURLEn.Name = "txtURLEn"
Me.txtURLEn.Size = New System.Drawing.Size(408, 20)
Me.txtURLEn.TabIndex = 26
'
'LabelControl27
'
Me.LabelControl27.Location = New System.Drawing.Point(16, 17)
Me.LabelControl27.Name = "LabelControl27"
Me.LabelControl27.Size = New System.Drawing.Size(59, 13)
Me.LabelControl27.TabIndex = 25
Me.LabelControl27.Text = "Product URL"
'
'tabNL
'
Me.tabNL.Controls.Add(Me.Panel5)
Me.tabNL.Controls.Add(Me.txtAwardNL)
Me.tabNL.Controls.Add(Me.pictNL)
Me.tabNL.Controls.Add(Me.txtImageNL)
Me.tabNL.Controls.Add(Me.LabelControl20)
Me.tabNL.Controls.Add(Me.LabelControl21)
Me.tabNL.Controls.Add(Me.txtURLNl)
Me.tabNL.Controls.Add(Me.LabelControl22)
Me.tabNL.Name = "tabNL"
Me.tabNL.Size = New System.Drawing.Size(1047, 690)
Me.tabNL.Text = "NL"
'
'Panel5
'
Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
Me.Panel5.AutoScroll = true
Me.Panel5.AutoSize = true
Me.Panel5.Controls.Add(Me.Panel6)
Me.Panel5.Location = New System.Drawing.Point(16, 156)
Me.Panel5.Name = "Panel5"
Me.Panel5.Size = New System.Drawing.Size(615, 512)
Me.Panel5.TabIndex = 24
'
'Panel6
'
Me.Panel6.AutoScroll = true
Me.Panel6.AutoScrollMargin = New System.Drawing.Size(10, 10)
Me.Panel6.AutoScrollMinSize = New System.Drawing.Size(10, 10)
Me.Panel6.Controls.Add(Me.GroupBox1)
Me.Panel6.Controls.Add(Me.GroupBox2)
Me.Panel6.Controls.Add(Me.GroupBox7)
Me.Panel6.Controls.Add(Me.GroupBox8)
Me.Panel6.Controls.Add(Me.GroupBox9)
Me.Panel6.Controls.Add(Me.GroupBox10)
Me.Panel6.Controls.Add(Me.GroupBox11)
Me.Panel6.Controls.Add(Me.GroupBox12)
Me.Panel6.Controls.Add(Me.GroupBox13)
Me.Panel6.Controls.Add(Me.GroupBox14)
Me.Panel6.Controls.Add(Me.GroupBox15)
Me.Panel6.Controls.Add(Me.GroupBox16)
Me.Panel6.Controls.Add(Me.GroupBox17)
Me.Panel6.Controls.Add(Me.GroupBox18)
Me.Panel6.Controls.Add(Me.GroupBox19)
Me.Panel6.Controls.Add(Me.GroupBox20)
Me.Panel6.Controls.Add(Me.GroupBox21)
Me.Panel6.Controls.Add(Me.GroupBox22)
Me.Panel6.Controls.Add(Me.GroupBox23)
Me.Panel6.Controls.Add(Me.GroupBox24)
Me.Panel6.Controls.Add(Me.GroupBox25)
Me.Panel6.Controls.Add(Me.GroupBox26)
Me.Panel6.Controls.Add(Me.GroupBox27)
Me.Panel6.Controls.Add(Me.GroupBox28)
Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
Me.Panel6.Location = New System.Drawing.Point(0, 0)
Me.Panel6.Name = "Panel6"
Me.Panel6.Size = New System.Drawing.Size(615, 512)
Me.Panel6.TabIndex = 16
'
'GroupBox1
'
Me.GroupBox1.Controls.Add(Me.txtDescNL24)
Me.GroupBox1.Controls.Add(Me.LabelControl19)
Me.GroupBox1.Controls.Add(Me.txtNameNL24)
Me.GroupBox1.Controls.Add(Me.LabelControl23)
Me.GroupBox1.Location = New System.Drawing.Point(3, 5099)
Me.GroupBox1.Name = "GroupBox1"
Me.GroupBox1.Size = New System.Drawing.Size(532, 216)
Me.GroupBox1.TabIndex = 54
Me.GroupBox1.TabStop = false
Me.GroupBox1.Text = "Episode24"
'
'txtDescNL24
'
Me.txtDescNL24.Enabled = false
Me.txtDescNL24.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL24.Name = "txtDescNL24"
Me.txtDescNL24.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL24.TabIndex = 16
'
'LabelControl19
'
Me.LabelControl19.Location = New System.Drawing.Point(6, 65)
Me.LabelControl19.Name = "LabelControl19"
Me.LabelControl19.Size = New System.Drawing.Size(93, 13)
Me.LabelControl19.TabIndex = 14
Me.LabelControl19.Text = "Product Description"
'
'txtNameNL24
'
Me.txtNameNL24.Enabled = false
Me.txtNameNL24.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL24.Name = "txtNameNL24"
Me.txtNameNL24.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL24.TabIndex = 13
'
'LabelControl23
'
Me.LabelControl23.Location = New System.Drawing.Point(45, 26)
Me.LabelControl23.Name = "LabelControl23"
Me.LabelControl23.Size = New System.Drawing.Size(67, 13)
Me.LabelControl23.TabIndex = 12
Me.LabelControl23.Text = "Product Name"
'
'GroupBox2
'
Me.GroupBox2.Controls.Add(Me.txtDescNL23)
Me.GroupBox2.Controls.Add(Me.LabelControl116)
Me.GroupBox2.Controls.Add(Me.txtNameNL23)
Me.GroupBox2.Controls.Add(Me.LabelControl117)
Me.GroupBox2.Location = New System.Drawing.Point(5, 4886)
Me.GroupBox2.Name = "GroupBox2"
Me.GroupBox2.Size = New System.Drawing.Size(532, 216)
Me.GroupBox2.TabIndex = 48
Me.GroupBox2.TabStop = false
Me.GroupBox2.Text = "Episode23"
'
'txtDescNL23
'
Me.txtDescNL23.Enabled = false
Me.txtDescNL23.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL23.Name = "txtDescNL23"
Me.txtDescNL23.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL23.TabIndex = 16
'
'LabelControl116
'
Me.LabelControl116.Location = New System.Drawing.Point(6, 65)
Me.LabelControl116.Name = "LabelControl116"
Me.LabelControl116.Size = New System.Drawing.Size(93, 13)
Me.LabelControl116.TabIndex = 14
Me.LabelControl116.Text = "Product Description"
'
'txtNameNL23
'
Me.txtNameNL23.Enabled = false
Me.txtNameNL23.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL23.Name = "txtNameNL23"
Me.txtNameNL23.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL23.TabIndex = 13
'
'LabelControl117
'
Me.LabelControl117.Location = New System.Drawing.Point(45, 26)
Me.LabelControl117.Name = "LabelControl117"
Me.LabelControl117.Size = New System.Drawing.Size(67, 13)
Me.LabelControl117.TabIndex = 12
Me.LabelControl117.Text = "Product Name"
'
'GroupBox7
'
Me.GroupBox7.Controls.Add(Me.txtDescNL22)
Me.GroupBox7.Controls.Add(Me.LabelControl118)
Me.GroupBox7.Controls.Add(Me.txtNameNL22)
Me.GroupBox7.Controls.Add(Me.LabelControl119)
Me.GroupBox7.Location = New System.Drawing.Point(6, 4665)
Me.GroupBox7.Name = "GroupBox7"
Me.GroupBox7.Size = New System.Drawing.Size(532, 216)
Me.GroupBox7.TabIndex = 46
Me.GroupBox7.TabStop = false
Me.GroupBox7.Text = "Episode22"
'
'txtDescNL22
'
Me.txtDescNL22.Enabled = false
Me.txtDescNL22.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL22.Name = "txtDescNL22"
Me.txtDescNL22.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL22.TabIndex = 16
'
'LabelControl118
'
Me.LabelControl118.Location = New System.Drawing.Point(6, 65)
Me.LabelControl118.Name = "LabelControl118"
Me.LabelControl118.Size = New System.Drawing.Size(93, 13)
Me.LabelControl118.TabIndex = 14
Me.LabelControl118.Text = "Product Description"
'
'txtNameNL22
'
Me.txtNameNL22.Enabled = false
Me.txtNameNL22.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL22.Name = "txtNameNL22"
Me.txtNameNL22.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL22.TabIndex = 13
'
'LabelControl119
'
Me.LabelControl119.Location = New System.Drawing.Point(45, 26)
Me.LabelControl119.Name = "LabelControl119"
Me.LabelControl119.Size = New System.Drawing.Size(67, 13)
Me.LabelControl119.TabIndex = 12
Me.LabelControl119.Text = "Product Name"
'
'GroupBox8
'
Me.GroupBox8.Controls.Add(Me.txtDescNL21)
Me.GroupBox8.Controls.Add(Me.LabelControl120)
Me.GroupBox8.Controls.Add(Me.txtNameNL21)
Me.GroupBox8.Controls.Add(Me.LabelControl121)
Me.GroupBox8.Location = New System.Drawing.Point(12, 4443)
Me.GroupBox8.Name = "GroupBox8"
Me.GroupBox8.Size = New System.Drawing.Size(532, 216)
Me.GroupBox8.TabIndex = 45
Me.GroupBox8.TabStop = false
Me.GroupBox8.Text = "Episode21"
'
'txtDescNL21
'
Me.txtDescNL21.Enabled = false
Me.txtDescNL21.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL21.Name = "txtDescNL21"
Me.txtDescNL21.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL21.TabIndex = 16
'
'LabelControl120
'
Me.LabelControl120.Location = New System.Drawing.Point(6, 65)
Me.LabelControl120.Name = "LabelControl120"
Me.LabelControl120.Size = New System.Drawing.Size(93, 13)
Me.LabelControl120.TabIndex = 14
Me.LabelControl120.Text = "Product Description"
'
'txtNameNL21
'
Me.txtNameNL21.Enabled = false
Me.txtNameNL21.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL21.Name = "txtNameNL21"
Me.txtNameNL21.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL21.TabIndex = 13
'
'LabelControl121
'
Me.LabelControl121.Location = New System.Drawing.Point(45, 26)
Me.LabelControl121.Name = "LabelControl121"
Me.LabelControl121.Size = New System.Drawing.Size(67, 13)
Me.LabelControl121.TabIndex = 12
Me.LabelControl121.Text = "Product Name"
'
'GroupBox9
'
Me.GroupBox9.Controls.Add(Me.txtDescNL20)
Me.GroupBox9.Controls.Add(Me.LabelControl122)
Me.GroupBox9.Controls.Add(Me.txtNameNL20)
Me.GroupBox9.Controls.Add(Me.LabelControl123)
Me.GroupBox9.Location = New System.Drawing.Point(6, 4221)
Me.GroupBox9.Name = "GroupBox9"
Me.GroupBox9.Size = New System.Drawing.Size(532, 216)
Me.GroupBox9.TabIndex = 41
Me.GroupBox9.TabStop = false
Me.GroupBox9.Text = "Episode20"
'
'txtDescNL20
'
Me.txtDescNL20.Enabled = false
Me.txtDescNL20.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL20.Name = "txtDescNL20"
Me.txtDescNL20.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL20.TabIndex = 16
'
'LabelControl122
'
Me.LabelControl122.Location = New System.Drawing.Point(6, 65)
Me.LabelControl122.Name = "LabelControl122"
Me.LabelControl122.Size = New System.Drawing.Size(93, 13)
Me.LabelControl122.TabIndex = 14
Me.LabelControl122.Text = "Product Description"
'
'txtNameNL20
'
Me.txtNameNL20.Enabled = false
Me.txtNameNL20.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL20.Name = "txtNameNL20"
Me.txtNameNL20.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL20.TabIndex = 13
'
'LabelControl123
'
Me.LabelControl123.Location = New System.Drawing.Point(45, 26)
Me.LabelControl123.Name = "LabelControl123"
Me.LabelControl123.Size = New System.Drawing.Size(67, 13)
Me.LabelControl123.TabIndex = 12
Me.LabelControl123.Text = "Product Name"
'
'GroupBox10
'
Me.GroupBox10.Controls.Add(Me.txtDescNL19)
Me.GroupBox10.Controls.Add(Me.LabelControl124)
Me.GroupBox10.Controls.Add(Me.txtNameNL19)
Me.GroupBox10.Controls.Add(Me.LabelControl125)
Me.GroupBox10.Location = New System.Drawing.Point(6, 4001)
Me.GroupBox10.Name = "GroupBox10"
Me.GroupBox10.Size = New System.Drawing.Size(532, 216)
Me.GroupBox10.TabIndex = 39
Me.GroupBox10.TabStop = false
Me.GroupBox10.Text = "Episode19"
'
'txtDescNL19
'
Me.txtDescNL19.Enabled = false
Me.txtDescNL19.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL19.Name = "txtDescNL19"
Me.txtDescNL19.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL19.TabIndex = 16
'
'LabelControl124
'
Me.LabelControl124.Location = New System.Drawing.Point(6, 65)
Me.LabelControl124.Name = "LabelControl124"
Me.LabelControl124.Size = New System.Drawing.Size(93, 13)
Me.LabelControl124.TabIndex = 14
Me.LabelControl124.Text = "Product Description"
'
'txtNameNL19
'
Me.txtNameNL19.Enabled = false
Me.txtNameNL19.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL19.Name = "txtNameNL19"
Me.txtNameNL19.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL19.TabIndex = 13
'
'LabelControl125
'
Me.LabelControl125.Location = New System.Drawing.Point(45, 26)
Me.LabelControl125.Name = "LabelControl125"
Me.LabelControl125.Size = New System.Drawing.Size(67, 13)
Me.LabelControl125.TabIndex = 12
Me.LabelControl125.Text = "Product Name"
'
'GroupBox11
'
Me.GroupBox11.Controls.Add(Me.txtDescNL18)
Me.GroupBox11.Controls.Add(Me.LabelControl126)
Me.GroupBox11.Controls.Add(Me.txtNameNL18)
Me.GroupBox11.Controls.Add(Me.LabelControl127)
Me.GroupBox11.Location = New System.Drawing.Point(6, 3782)
Me.GroupBox11.Name = "GroupBox11"
Me.GroupBox11.Size = New System.Drawing.Size(532, 216)
Me.GroupBox11.TabIndex = 38
Me.GroupBox11.TabStop = false
Me.GroupBox11.Text = "Episode18"
'
'txtDescNL18
'
Me.txtDescNL18.Enabled = false
Me.txtDescNL18.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL18.Name = "txtDescNL18"
Me.txtDescNL18.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL18.TabIndex = 16
'
'LabelControl126
'
Me.LabelControl126.Location = New System.Drawing.Point(6, 65)
Me.LabelControl126.Name = "LabelControl126"
Me.LabelControl126.Size = New System.Drawing.Size(93, 13)
Me.LabelControl126.TabIndex = 14
Me.LabelControl126.Text = "Product Description"
'
'txtNameNL18
'
Me.txtNameNL18.Enabled = false
Me.txtNameNL18.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL18.Name = "txtNameNL18"
Me.txtNameNL18.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL18.TabIndex = 13
'
'LabelControl127
'
Me.LabelControl127.Location = New System.Drawing.Point(45, 26)
Me.LabelControl127.Name = "LabelControl127"
Me.LabelControl127.Size = New System.Drawing.Size(67, 13)
Me.LabelControl127.TabIndex = 12
Me.LabelControl127.Text = "Product Name"
'
'GroupBox12
'
Me.GroupBox12.Controls.Add(Me.txtDescNL17)
Me.GroupBox12.Controls.Add(Me.LabelControl128)
Me.GroupBox12.Controls.Add(Me.txtNameNL17)
Me.GroupBox12.Controls.Add(Me.LabelControl129)
Me.GroupBox12.Location = New System.Drawing.Point(12, 3560)
Me.GroupBox12.Name = "GroupBox12"
Me.GroupBox12.Size = New System.Drawing.Size(532, 216)
Me.GroupBox12.TabIndex = 37
Me.GroupBox12.TabStop = false
Me.GroupBox12.Text = "Episode17"
'
'txtDescNL17
'
Me.txtDescNL17.Enabled = false
Me.txtDescNL17.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL17.Name = "txtDescNL17"
Me.txtDescNL17.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL17.TabIndex = 16
'
'LabelControl128
'
Me.LabelControl128.Location = New System.Drawing.Point(6, 65)
Me.LabelControl128.Name = "LabelControl128"
Me.LabelControl128.Size = New System.Drawing.Size(93, 13)
Me.LabelControl128.TabIndex = 14
Me.LabelControl128.Text = "Product Description"
'
'txtNameNL17
'
Me.txtNameNL17.Enabled = false
Me.txtNameNL17.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL17.Name = "txtNameNL17"
Me.txtNameNL17.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL17.TabIndex = 13
'
'LabelControl129
'
Me.LabelControl129.Location = New System.Drawing.Point(45, 26)
Me.LabelControl129.Name = "LabelControl129"
Me.LabelControl129.Size = New System.Drawing.Size(67, 13)
Me.LabelControl129.TabIndex = 12
Me.LabelControl129.Text = "Product Name"
'
'GroupBox13
'
Me.GroupBox13.Controls.Add(Me.txtDescNL16)
Me.GroupBox13.Controls.Add(Me.LabelControl130)
Me.GroupBox13.Controls.Add(Me.txtNameNL16)
Me.GroupBox13.Controls.Add(Me.LabelControl131)
Me.GroupBox13.Location = New System.Drawing.Point(12, 3342)
Me.GroupBox13.Name = "GroupBox13"
Me.GroupBox13.Size = New System.Drawing.Size(532, 216)
Me.GroupBox13.TabIndex = 35
Me.GroupBox13.TabStop = false
Me.GroupBox13.Text = "Episode16"
'
'txtDescNL16
'
Me.txtDescNL16.Enabled = false
Me.txtDescNL16.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL16.Name = "txtDescNL16"
Me.txtDescNL16.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL16.TabIndex = 16
'
'LabelControl130
'
Me.LabelControl130.Location = New System.Drawing.Point(6, 65)
Me.LabelControl130.Name = "LabelControl130"
Me.LabelControl130.Size = New System.Drawing.Size(93, 13)
Me.LabelControl130.TabIndex = 14
Me.LabelControl130.Text = "Product Description"
'
'txtNameNL16
'
Me.txtNameNL16.Enabled = false
Me.txtNameNL16.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL16.Name = "txtNameNL16"
Me.txtNameNL16.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL16.TabIndex = 13
'
'LabelControl131
'
Me.LabelControl131.Location = New System.Drawing.Point(45, 26)
Me.LabelControl131.Name = "LabelControl131"
Me.LabelControl131.Size = New System.Drawing.Size(67, 13)
Me.LabelControl131.TabIndex = 12
Me.LabelControl131.Text = "Product Name"
'
'GroupBox14
'
Me.GroupBox14.Controls.Add(Me.txtDescNL15)
Me.GroupBox14.Controls.Add(Me.LabelControl132)
Me.GroupBox14.Controls.Add(Me.txtNameNL15)
Me.GroupBox14.Controls.Add(Me.LabelControl133)
Me.GroupBox14.Location = New System.Drawing.Point(12, 3122)
Me.GroupBox14.Name = "GroupBox14"
Me.GroupBox14.Size = New System.Drawing.Size(532, 216)
Me.GroupBox14.TabIndex = 34
Me.GroupBox14.TabStop = false
Me.GroupBox14.Text = "Episode15"
'
'txtDescNL15
'
Me.txtDescNL15.Enabled = false
Me.txtDescNL15.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL15.Name = "txtDescNL15"
Me.txtDescNL15.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL15.TabIndex = 16
'
'LabelControl132
'
Me.LabelControl132.Location = New System.Drawing.Point(6, 65)
Me.LabelControl132.Name = "LabelControl132"
Me.LabelControl132.Size = New System.Drawing.Size(93, 13)
Me.LabelControl132.TabIndex = 14
Me.LabelControl132.Text = "Product Description"
'
'txtNameNL15
'
Me.txtNameNL15.Enabled = false
Me.txtNameNL15.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL15.Name = "txtNameNL15"
Me.txtNameNL15.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL15.TabIndex = 13
'
'LabelControl133
'
Me.LabelControl133.Location = New System.Drawing.Point(45, 26)
Me.LabelControl133.Name = "LabelControl133"
Me.LabelControl133.Size = New System.Drawing.Size(67, 13)
Me.LabelControl133.TabIndex = 12
Me.LabelControl133.Text = "Product Name"
'
'GroupBox15
'
Me.GroupBox15.Controls.Add(Me.txtDescNL14)
Me.GroupBox15.Controls.Add(Me.LabelControl134)
Me.GroupBox15.Controls.Add(Me.txtNameNL14)
Me.GroupBox15.Controls.Add(Me.LabelControl135)
Me.GroupBox15.Location = New System.Drawing.Point(12, 2900)
Me.GroupBox15.Name = "GroupBox15"
Me.GroupBox15.Size = New System.Drawing.Size(532, 216)
Me.GroupBox15.TabIndex = 32
Me.GroupBox15.TabStop = false
Me.GroupBox15.Text = "Episode14"
'
'txtDescNL14
'
Me.txtDescNL14.Enabled = false
Me.txtDescNL14.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL14.Name = "txtDescNL14"
Me.txtDescNL14.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL14.TabIndex = 16
'
'LabelControl134
'
Me.LabelControl134.Location = New System.Drawing.Point(6, 65)
Me.LabelControl134.Name = "LabelControl134"
Me.LabelControl134.Size = New System.Drawing.Size(93, 13)
Me.LabelControl134.TabIndex = 14
Me.LabelControl134.Text = "Product Description"
'
'txtNameNL14
'
Me.txtNameNL14.Enabled = false
Me.txtNameNL14.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL14.Name = "txtNameNL14"
Me.txtNameNL14.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL14.TabIndex = 13
'
'LabelControl135
'
Me.LabelControl135.Location = New System.Drawing.Point(45, 26)
Me.LabelControl135.Name = "LabelControl135"
Me.LabelControl135.Size = New System.Drawing.Size(67, 13)
Me.LabelControl135.TabIndex = 12
Me.LabelControl135.Text = "Product Name"
'
'GroupBox16
'
Me.GroupBox16.Controls.Add(Me.txtDescNL13)
Me.GroupBox16.Controls.Add(Me.LabelControl136)
Me.GroupBox16.Controls.Add(Me.txtNameNL13)
Me.GroupBox16.Controls.Add(Me.LabelControl137)
Me.GroupBox16.Location = New System.Drawing.Point(12, 2677)
Me.GroupBox16.Name = "GroupBox16"
Me.GroupBox16.Size = New System.Drawing.Size(532, 216)
Me.GroupBox16.TabIndex = 30
Me.GroupBox16.TabStop = false
Me.GroupBox16.Text = "Episode13"
'
'txtDescNL13
'
Me.txtDescNL13.Enabled = false
Me.txtDescNL13.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL13.Name = "txtDescNL13"
Me.txtDescNL13.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL13.TabIndex = 16
'
'LabelControl136
'
Me.LabelControl136.Location = New System.Drawing.Point(6, 65)
Me.LabelControl136.Name = "LabelControl136"
Me.LabelControl136.Size = New System.Drawing.Size(93, 13)
Me.LabelControl136.TabIndex = 14
Me.LabelControl136.Text = "Product Description"
'
'txtNameNL13
'
Me.txtNameNL13.Enabled = false
Me.txtNameNL13.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL13.Name = "txtNameNL13"
Me.txtNameNL13.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL13.TabIndex = 13
'
'LabelControl137
'
Me.LabelControl137.Location = New System.Drawing.Point(45, 26)
Me.LabelControl137.Name = "LabelControl137"
Me.LabelControl137.Size = New System.Drawing.Size(67, 13)
Me.LabelControl137.TabIndex = 12
Me.LabelControl137.Text = "Product Name"
'
'GroupBox17
'
Me.GroupBox17.Controls.Add(Me.txtDescNL12)
Me.GroupBox17.Controls.Add(Me.LabelControl138)
Me.GroupBox17.Controls.Add(Me.txtNameNL12)
Me.GroupBox17.Controls.Add(Me.LabelControl139)
Me.GroupBox17.Location = New System.Drawing.Point(12, 2455)
Me.GroupBox17.Name = "GroupBox17"
Me.GroupBox17.Size = New System.Drawing.Size(532, 216)
Me.GroupBox17.TabIndex = 29
Me.GroupBox17.TabStop = false
Me.GroupBox17.Text = "Episode12"
'
'txtDescNL12
'
Me.txtDescNL12.Enabled = false
Me.txtDescNL12.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL12.Name = "txtDescNL12"
Me.txtDescNL12.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL12.TabIndex = 16
'
'LabelControl138
'
Me.LabelControl138.Location = New System.Drawing.Point(6, 65)
Me.LabelControl138.Name = "LabelControl138"
Me.LabelControl138.Size = New System.Drawing.Size(93, 13)
Me.LabelControl138.TabIndex = 14
Me.LabelControl138.Text = "Product Description"
'
'txtNameNL12
'
Me.txtNameNL12.Enabled = false
Me.txtNameNL12.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL12.Name = "txtNameNL12"
Me.txtNameNL12.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL12.TabIndex = 13
'
'LabelControl139
'
Me.LabelControl139.Location = New System.Drawing.Point(45, 26)
Me.LabelControl139.Name = "LabelControl139"
Me.LabelControl139.Size = New System.Drawing.Size(67, 13)
Me.LabelControl139.TabIndex = 12
Me.LabelControl139.Text = "Product Name"
'
'GroupBox18
'
Me.GroupBox18.Controls.Add(Me.txtDescNL11)
Me.GroupBox18.Controls.Add(Me.LabelControl140)
Me.GroupBox18.Controls.Add(Me.txtNameNL11)
Me.GroupBox18.Controls.Add(Me.LabelControl141)
Me.GroupBox18.Location = New System.Drawing.Point(12, 2233)
Me.GroupBox18.Name = "GroupBox18"
Me.GroupBox18.Size = New System.Drawing.Size(532, 216)
Me.GroupBox18.TabIndex = 28
Me.GroupBox18.TabStop = false
Me.GroupBox18.Text = "Episode11"
'
'txtDescNL11
'
Me.txtDescNL11.Enabled = false
Me.txtDescNL11.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL11.Name = "txtDescNL11"
Me.txtDescNL11.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL11.TabIndex = 16
'
'LabelControl140
'
Me.LabelControl140.Location = New System.Drawing.Point(6, 65)
Me.LabelControl140.Name = "LabelControl140"
Me.LabelControl140.Size = New System.Drawing.Size(93, 13)
Me.LabelControl140.TabIndex = 14
Me.LabelControl140.Text = "Product Description"
'
'txtNameNL11
'
Me.txtNameNL11.Enabled = false
Me.txtNameNL11.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL11.Name = "txtNameNL11"
Me.txtNameNL11.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL11.TabIndex = 13
'
'LabelControl141
'
Me.LabelControl141.Location = New System.Drawing.Point(45, 26)
Me.LabelControl141.Name = "LabelControl141"
Me.LabelControl141.Size = New System.Drawing.Size(67, 13)
Me.LabelControl141.TabIndex = 12
Me.LabelControl141.Text = "Product Name"
'
'GroupBox19
'
Me.GroupBox19.Controls.Add(Me.txtDescNL10)
Me.GroupBox19.Controls.Add(Me.LabelControl142)
Me.GroupBox19.Controls.Add(Me.txtNameNL10)
Me.GroupBox19.Controls.Add(Me.LabelControl143)
Me.GroupBox19.Location = New System.Drawing.Point(12, 2011)
Me.GroupBox19.Name = "GroupBox19"
Me.GroupBox19.Size = New System.Drawing.Size(532, 216)
Me.GroupBox19.TabIndex = 27
Me.GroupBox19.TabStop = false
Me.GroupBox19.Text = "Episode10"
'
'txtDescNL10
'
Me.txtDescNL10.Enabled = false
Me.txtDescNL10.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL10.Name = "txtDescNL10"
Me.txtDescNL10.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL10.TabIndex = 16
'
'LabelControl142
'
Me.LabelControl142.Location = New System.Drawing.Point(6, 65)
Me.LabelControl142.Name = "LabelControl142"
Me.LabelControl142.Size = New System.Drawing.Size(93, 13)
Me.LabelControl142.TabIndex = 14
Me.LabelControl142.Text = "Product Description"
'
'txtNameNL10
'
Me.txtNameNL10.Enabled = false
Me.txtNameNL10.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL10.Name = "txtNameNL10"
Me.txtNameNL10.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL10.TabIndex = 13
'
'LabelControl143
'
Me.LabelControl143.Location = New System.Drawing.Point(45, 26)
Me.LabelControl143.Name = "LabelControl143"
Me.LabelControl143.Size = New System.Drawing.Size(67, 13)
Me.LabelControl143.TabIndex = 12
Me.LabelControl143.Text = "Product Name"
'
'GroupBox20
'
Me.GroupBox20.Controls.Add(Me.txtDescNL9)
Me.GroupBox20.Controls.Add(Me.LabelControl144)
Me.GroupBox20.Controls.Add(Me.txtNameNL9)
Me.GroupBox20.Controls.Add(Me.LabelControl145)
Me.GroupBox20.Location = New System.Drawing.Point(12, 1789)
Me.GroupBox20.Name = "GroupBox20"
Me.GroupBox20.Size = New System.Drawing.Size(532, 216)
Me.GroupBox20.TabIndex = 25
Me.GroupBox20.TabStop = false
Me.GroupBox20.Text = "Episode9"
'
'txtDescNL9
'
Me.txtDescNL9.Enabled = false
Me.txtDescNL9.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL9.Name = "txtDescNL9"
Me.txtDescNL9.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL9.TabIndex = 16
'
'LabelControl144
'
Me.LabelControl144.Location = New System.Drawing.Point(6, 65)
Me.LabelControl144.Name = "LabelControl144"
Me.LabelControl144.Size = New System.Drawing.Size(93, 13)
Me.LabelControl144.TabIndex = 14
Me.LabelControl144.Text = "Product Description"
'
'txtNameNL9
'
Me.txtNameNL9.Enabled = false
Me.txtNameNL9.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL9.Name = "txtNameNL9"
Me.txtNameNL9.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL9.TabIndex = 13
'
'LabelControl145
'
Me.LabelControl145.Location = New System.Drawing.Point(45, 26)
Me.LabelControl145.Name = "LabelControl145"
Me.LabelControl145.Size = New System.Drawing.Size(67, 13)
Me.LabelControl145.TabIndex = 12
Me.LabelControl145.Text = "Product Name"
'
'GroupBox21
'
Me.GroupBox21.Controls.Add(Me.txtDescNL8)
Me.GroupBox21.Controls.Add(Me.LabelControl146)
Me.GroupBox21.Controls.Add(Me.txtNameNL8)
Me.GroupBox21.Controls.Add(Me.LabelControl147)
Me.GroupBox21.Location = New System.Drawing.Point(12, 1567)
Me.GroupBox21.Name = "GroupBox21"
Me.GroupBox21.Size = New System.Drawing.Size(532, 216)
Me.GroupBox21.TabIndex = 23
Me.GroupBox21.TabStop = false
Me.GroupBox21.Text = "Episode8"
'
'txtDescNL8
'
Me.txtDescNL8.Enabled = false
Me.txtDescNL8.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL8.Name = "txtDescNL8"
Me.txtDescNL8.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL8.TabIndex = 16
'
'LabelControl146
'
Me.LabelControl146.Location = New System.Drawing.Point(6, 65)
Me.LabelControl146.Name = "LabelControl146"
Me.LabelControl146.Size = New System.Drawing.Size(93, 13)
Me.LabelControl146.TabIndex = 14
Me.LabelControl146.Text = "Product Description"
'
'txtNameNL8
'
Me.txtNameNL8.Enabled = false
Me.txtNameNL8.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL8.Name = "txtNameNL8"
Me.txtNameNL8.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL8.TabIndex = 13
'
'LabelControl147
'
Me.LabelControl147.Location = New System.Drawing.Point(45, 26)
Me.LabelControl147.Name = "LabelControl147"
Me.LabelControl147.Size = New System.Drawing.Size(67, 13)
Me.LabelControl147.TabIndex = 12
Me.LabelControl147.Text = "Product Name"
'
'GroupBox22
'
Me.GroupBox22.Controls.Add(Me.txtDescNL7)
Me.GroupBox22.Controls.Add(Me.LabelControl148)
Me.GroupBox22.Controls.Add(Me.txtNameNL7)
Me.GroupBox22.Controls.Add(Me.LabelControl149)
Me.GroupBox22.Location = New System.Drawing.Point(12, 1345)
Me.GroupBox22.Name = "GroupBox22"
Me.GroupBox22.Size = New System.Drawing.Size(532, 216)
Me.GroupBox22.TabIndex = 21
Me.GroupBox22.TabStop = false
Me.GroupBox22.Text = "Episode7"
'
'txtDescNL7
'
Me.txtDescNL7.Enabled = false
Me.txtDescNL7.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL7.Name = "txtDescNL7"
Me.txtDescNL7.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL7.TabIndex = 16
'
'LabelControl148
'
Me.LabelControl148.Location = New System.Drawing.Point(6, 65)
Me.LabelControl148.Name = "LabelControl148"
Me.LabelControl148.Size = New System.Drawing.Size(93, 13)
Me.LabelControl148.TabIndex = 14
Me.LabelControl148.Text = "Product Description"
'
'txtNameNL7
'
Me.txtNameNL7.Enabled = false
Me.txtNameNL7.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL7.Name = "txtNameNL7"
Me.txtNameNL7.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL7.TabIndex = 13
'
'LabelControl149
'
Me.LabelControl149.Location = New System.Drawing.Point(45, 26)
Me.LabelControl149.Name = "LabelControl149"
Me.LabelControl149.Size = New System.Drawing.Size(67, 13)
Me.LabelControl149.TabIndex = 12
Me.LabelControl149.Text = "Product Name"
'
'GroupBox23
'
Me.GroupBox23.Controls.Add(Me.txtDescNL6)
Me.GroupBox23.Controls.Add(Me.LabelControl150)
Me.GroupBox23.Controls.Add(Me.txtNameNL6)
Me.GroupBox23.Controls.Add(Me.LabelControl151)
Me.GroupBox23.Location = New System.Drawing.Point(12, 1123)
Me.GroupBox23.Name = "GroupBox23"
Me.GroupBox23.Size = New System.Drawing.Size(532, 216)
Me.GroupBox23.TabIndex = 20
Me.GroupBox23.TabStop = false
Me.GroupBox23.Text = "Episode6"
'
'txtDescNL6
'
Me.txtDescNL6.Enabled = false
Me.txtDescNL6.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL6.Name = "txtDescNL6"
Me.txtDescNL6.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL6.TabIndex = 16
'
'LabelControl150
'
Me.LabelControl150.Location = New System.Drawing.Point(6, 65)
Me.LabelControl150.Name = "LabelControl150"
Me.LabelControl150.Size = New System.Drawing.Size(93, 13)
Me.LabelControl150.TabIndex = 14
Me.LabelControl150.Text = "Product Description"
'
'txtNameNL6
'
Me.txtNameNL6.Enabled = false
Me.txtNameNL6.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL6.Name = "txtNameNL6"
Me.txtNameNL6.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL6.TabIndex = 13
'
'LabelControl151
'
Me.LabelControl151.Location = New System.Drawing.Point(45, 26)
Me.LabelControl151.Name = "LabelControl151"
Me.LabelControl151.Size = New System.Drawing.Size(67, 13)
Me.LabelControl151.TabIndex = 12
Me.LabelControl151.Text = "Product Name"
'
'GroupBox24
'
Me.GroupBox24.Controls.Add(Me.txtDescNL5)
Me.GroupBox24.Controls.Add(Me.LabelControl152)
Me.GroupBox24.Controls.Add(Me.txtNameNL5)
Me.GroupBox24.Controls.Add(Me.LabelControl153)
Me.GroupBox24.Location = New System.Drawing.Point(12, 901)
Me.GroupBox24.Name = "GroupBox24"
Me.GroupBox24.Size = New System.Drawing.Size(532, 216)
Me.GroupBox24.TabIndex = 19
Me.GroupBox24.TabStop = false
Me.GroupBox24.Text = "Episode5"
'
'txtDescNL5
'
Me.txtDescNL5.Enabled = false
Me.txtDescNL5.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL5.Name = "txtDescNL5"
Me.txtDescNL5.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL5.TabIndex = 16
'
'LabelControl152
'
Me.LabelControl152.Location = New System.Drawing.Point(6, 65)
Me.LabelControl152.Name = "LabelControl152"
Me.LabelControl152.Size = New System.Drawing.Size(93, 13)
Me.LabelControl152.TabIndex = 14
Me.LabelControl152.Text = "Product Description"
'
'txtNameNL5
'
Me.txtNameNL5.Enabled = false
Me.txtNameNL5.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL5.Name = "txtNameNL5"
Me.txtNameNL5.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL5.TabIndex = 13
'
'LabelControl153
'
Me.LabelControl153.Location = New System.Drawing.Point(45, 26)
Me.LabelControl153.Name = "LabelControl153"
Me.LabelControl153.Size = New System.Drawing.Size(67, 13)
Me.LabelControl153.TabIndex = 12
Me.LabelControl153.Text = "Product Name"
'
'GroupBox25
'
Me.GroupBox25.Controls.Add(Me.txtDescNL4)
Me.GroupBox25.Controls.Add(Me.LabelControl154)
Me.GroupBox25.Controls.Add(Me.txtNameNL4)
Me.GroupBox25.Controls.Add(Me.LabelControl155)
Me.GroupBox25.Location = New System.Drawing.Point(12, 679)
Me.GroupBox25.Name = "GroupBox25"
Me.GroupBox25.Size = New System.Drawing.Size(532, 216)
Me.GroupBox25.TabIndex = 18
Me.GroupBox25.TabStop = false
Me.GroupBox25.Text = "Episode4"
'
'txtDescNL4
'
Me.txtDescNL4.Enabled = false
Me.txtDescNL4.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL4.Name = "txtDescNL4"
Me.txtDescNL4.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL4.TabIndex = 16
'
'LabelControl154
'
Me.LabelControl154.Location = New System.Drawing.Point(6, 65)
Me.LabelControl154.Name = "LabelControl154"
Me.LabelControl154.Size = New System.Drawing.Size(93, 13)
Me.LabelControl154.TabIndex = 14
Me.LabelControl154.Text = "Product Description"
'
'txtNameNL4
'
Me.txtNameNL4.Enabled = false
Me.txtNameNL4.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL4.Name = "txtNameNL4"
Me.txtNameNL4.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL4.TabIndex = 13
'
'LabelControl155
'
Me.LabelControl155.Location = New System.Drawing.Point(45, 26)
Me.LabelControl155.Name = "LabelControl155"
Me.LabelControl155.Size = New System.Drawing.Size(67, 13)
Me.LabelControl155.TabIndex = 12
Me.LabelControl155.Text = "Product Name"
'
'GroupBox26
'
Me.GroupBox26.Controls.Add(Me.txtDescNL3)
Me.GroupBox26.Controls.Add(Me.LabelControl156)
Me.GroupBox26.Controls.Add(Me.txtNameNL3)
Me.GroupBox26.Controls.Add(Me.LabelControl157)
Me.GroupBox26.Location = New System.Drawing.Point(12, 457)
Me.GroupBox26.Name = "GroupBox26"
Me.GroupBox26.Size = New System.Drawing.Size(532, 216)
Me.GroupBox26.TabIndex = 17
Me.GroupBox26.TabStop = false
Me.GroupBox26.Text = "Episode3"
'
'txtDescNL3
'
Me.txtDescNL3.Enabled = false
Me.txtDescNL3.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL3.Name = "txtDescNL3"
Me.txtDescNL3.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL3.TabIndex = 16
'
'LabelControl156
'
Me.LabelControl156.Location = New System.Drawing.Point(6, 65)
Me.LabelControl156.Name = "LabelControl156"
Me.LabelControl156.Size = New System.Drawing.Size(93, 13)
Me.LabelControl156.TabIndex = 14
Me.LabelControl156.Text = "Product Description"
'
'txtNameNL3
'
Me.txtNameNL3.Enabled = false
Me.txtNameNL3.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL3.Name = "txtNameNL3"
Me.txtNameNL3.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL3.TabIndex = 13
'
'LabelControl157
'
Me.LabelControl157.Location = New System.Drawing.Point(45, 26)
Me.LabelControl157.Name = "LabelControl157"
Me.LabelControl157.Size = New System.Drawing.Size(67, 13)
Me.LabelControl157.TabIndex = 12
Me.LabelControl157.Text = "Product Name"
'
'GroupBox27
'
Me.GroupBox27.Controls.Add(Me.txtDescNL2)
Me.GroupBox27.Controls.Add(Me.LabelControl158)
Me.GroupBox27.Controls.Add(Me.txtNameNL2)
Me.GroupBox27.Controls.Add(Me.LabelControl159)
Me.GroupBox27.Location = New System.Drawing.Point(12, 235)
Me.GroupBox27.Name = "GroupBox27"
Me.GroupBox27.Size = New System.Drawing.Size(532, 216)
Me.GroupBox27.TabIndex = 16
Me.GroupBox27.TabStop = false
Me.GroupBox27.Text = "Episode2"
'
'txtDescNL2
'
Me.txtDescNL2.Enabled = false
Me.txtDescNL2.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL2.Name = "txtDescNL2"
Me.txtDescNL2.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL2.TabIndex = 16
'
'LabelControl158
'
Me.LabelControl158.Location = New System.Drawing.Point(6, 65)
Me.LabelControl158.Name = "LabelControl158"
Me.LabelControl158.Size = New System.Drawing.Size(93, 13)
Me.LabelControl158.TabIndex = 14
Me.LabelControl158.Text = "Product Description"
'
'txtNameNL2
'
Me.txtNameNL2.Enabled = false
Me.txtNameNL2.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL2.Name = "txtNameNL2"
Me.txtNameNL2.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL2.TabIndex = 13
'
'LabelControl159
'
Me.LabelControl159.Location = New System.Drawing.Point(45, 26)
Me.LabelControl159.Name = "LabelControl159"
Me.LabelControl159.Size = New System.Drawing.Size(67, 13)
Me.LabelControl159.TabIndex = 12
Me.LabelControl159.Text = "Product Name"
'
'GroupBox28
'
Me.GroupBox28.Controls.Add(Me.txtDescNL1)
Me.GroupBox28.Controls.Add(Me.LabelControl160)
Me.GroupBox28.Controls.Add(Me.txtNameNL1)
Me.GroupBox28.Controls.Add(Me.LabelControl161)
Me.GroupBox28.Location = New System.Drawing.Point(12, 13)
Me.GroupBox28.Name = "GroupBox28"
Me.GroupBox28.Size = New System.Drawing.Size(532, 216)
Me.GroupBox28.TabIndex = 15
Me.GroupBox28.TabStop = false
Me.GroupBox28.Text = "Episode1"
'
'txtDescNL1
'
Me.txtDescNL1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_description", true))
Me.txtDescNL1.Enabled = false
Me.txtDescNL1.Location = New System.Drawing.Point(118, 63)
Me.txtDescNL1.Name = "txtDescNL1"
Me.txtDescNL1.Size = New System.Drawing.Size(408, 129)
Me.txtDescNL1.TabIndex = 16
'
'LabelControl160
'
Me.LabelControl160.Location = New System.Drawing.Point(6, 65)
Me.LabelControl160.Name = "LabelControl160"
Me.LabelControl160.Size = New System.Drawing.Size(93, 13)
Me.LabelControl160.TabIndex = 14
Me.LabelControl160.Text = "Product Description"
'
'txtNameNL1
'
Me.txtNameNL1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_name", true))
Me.txtNameNL1.Enabled = false
Me.txtNameNL1.Location = New System.Drawing.Point(118, 23)
Me.txtNameNL1.Name = "txtNameNL1"
Me.txtNameNL1.Size = New System.Drawing.Size(408, 20)
Me.txtNameNL1.TabIndex = 13
'
'LabelControl161
'
Me.LabelControl161.Location = New System.Drawing.Point(45, 26)
Me.LabelControl161.Name = "LabelControl161"
Me.LabelControl161.Size = New System.Drawing.Size(67, 13)
Me.LabelControl161.TabIndex = 12
Me.LabelControl161.Text = "Product Name"
'
'txtAwardNL
'
Me.txtAwardNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_awards", true))
Me.txtAwardNL.Enabled = false
Me.txtAwardNL.Location = New System.Drawing.Point(128, 34)
Me.txtAwardNL.Name = "txtAwardNL"
Me.txtAwardNL.Size = New System.Drawing.Size(408, 80)
Me.txtAwardNL.TabIndex = 23
'
'pictNL
'
Me.pictNL.Location = New System.Drawing.Point(693, 16)
Me.pictNL.Name = "pictNL"
Me.pictNL.Properties.ReadOnly = true
Me.pictNL.Size = New System.Drawing.Size(280, 320)
Me.pictNL.TabIndex = 20
'
'txtImageNL
'
Me.txtImageNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_image_big", true))
Me.txtImageNL.Enabled = false
Me.txtImageNL.Location = New System.Drawing.Point(128, 122)
Me.txtImageNL.Name = "txtImageNL"
Me.txtImageNL.Size = New System.Drawing.Size(408, 20)
Me.txtImageNL.TabIndex = 19
'
'LabelControl20
'
Me.LabelControl20.Location = New System.Drawing.Point(16, 122)
Me.LabelControl20.Name = "LabelControl20"
Me.LabelControl20.Size = New System.Drawing.Size(70, 13)
Me.LabelControl20.TabIndex = 18
Me.LabelControl20.Text = "Product Image"
'
'LabelControl21
'
Me.LabelControl21.Location = New System.Drawing.Point(16, 34)
Me.LabelControl21.Name = "LabelControl21"
Me.LabelControl21.Size = New System.Drawing.Size(71, 13)
Me.LabelControl21.TabIndex = 16
Me.LabelControl21.Text = "Product Award"
'
'txtURLNl
'
Me.txtURLNl.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_nl.products_url", true))
Me.txtURLNl.Enabled = false
Me.txtURLNl.Location = New System.Drawing.Point(128, 10)
Me.txtURLNl.Name = "txtURLNl"
Me.txtURLNl.Size = New System.Drawing.Size(408, 20)
Me.txtURLNl.TabIndex = 15
'
'LabelControl22
'
Me.LabelControl22.Location = New System.Drawing.Point(16, 10)
Me.LabelControl22.Name = "LabelControl22"
Me.LabelControl22.Size = New System.Drawing.Size(59, 13)
Me.LabelControl22.TabIndex = 14
Me.LabelControl22.Text = "Product URL"
'
'tabFR
'
Me.tabFR.Controls.Add(Me.Panel3)
Me.tabFR.Controls.Add(Me.txtAwardFR)
Me.tabFR.Controls.Add(Me.pictFR)
Me.tabFR.Controls.Add(Me.txtImageFR)
Me.tabFR.Controls.Add(Me.LabelControl17)
Me.tabFR.Controls.Add(Me.LabelControl16)
Me.tabFR.Controls.Add(Me.txtURLFr)
Me.tabFR.Controls.Add(Me.LabelControl15)
Me.tabFR.Name = "tabFR"
Me.tabFR.Size = New System.Drawing.Size(1047, 690)
Me.tabFR.Text = "FR"
'
'Panel3
'
Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
Me.Panel3.AutoScroll = true
Me.Panel3.AutoSize = true
Me.Panel3.Controls.Add(Me.Panel4)
Me.Panel3.Location = New System.Drawing.Point(0, 147)
Me.Panel3.Name = "Panel3"
Me.Panel3.Size = New System.Drawing.Size(615, 512)
Me.Panel3.TabIndex = 13
'
'Panel4
'
Me.Panel4.AutoScroll = true
Me.Panel4.AutoScrollMargin = New System.Drawing.Size(10, 10)
Me.Panel4.AutoScrollMinSize = New System.Drawing.Size(10, 10)
Me.Panel4.Controls.Add(Me.grpEpisode24)
Me.Panel4.Controls.Add(Me.grpEpisode23)
Me.Panel4.Controls.Add(Me.grpEpisode22)
Me.Panel4.Controls.Add(Me.grpEpisode21)
Me.Panel4.Controls.Add(Me.grpEpisode20)
Me.Panel4.Controls.Add(Me.grpEpisode19)
Me.Panel4.Controls.Add(Me.grpEpisode18)
Me.Panel4.Controls.Add(Me.grpEpisode17)
Me.Panel4.Controls.Add(Me.grpEpisode16)
Me.Panel4.Controls.Add(Me.grpEpisode15)
Me.Panel4.Controls.Add(Me.grpEpisode14)
Me.Panel4.Controls.Add(Me.grpEpisode13)
Me.Panel4.Controls.Add(Me.grpEpisode12)
Me.Panel4.Controls.Add(Me.grpEpisode11)
Me.Panel4.Controls.Add(Me.grpEpisode10)
Me.Panel4.Controls.Add(Me.grpEpisdoe9)
Me.Panel4.Controls.Add(Me.grpEpisode8)
Me.Panel4.Controls.Add(Me.grpEpisode7)
Me.Panel4.Controls.Add(Me.grpEpisode6)
Me.Panel4.Controls.Add(Me.grpEpisode5)
Me.Panel4.Controls.Add(Me.grpEpisode4)
Me.Panel4.Controls.Add(Me.grpEpisode3)
Me.Panel4.Controls.Add(Me.grpEpisode2)
Me.Panel4.Controls.Add(Me.grpEpisode1)
Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
Me.Panel4.Location = New System.Drawing.Point(0, 0)
Me.Panel4.Name = "Panel4"
Me.Panel4.Size = New System.Drawing.Size(615, 512)
Me.Panel4.TabIndex = 16
'
'grpEpisode24
'
Me.grpEpisode24.Controls.Add(Me.txtDescFR24)
Me.grpEpisode24.Controls.Add(Me.LabelControl112)
Me.grpEpisode24.Controls.Add(Me.txtNameFR24)
Me.grpEpisode24.Controls.Add(Me.LabelControl113)
Me.grpEpisode24.Location = New System.Drawing.Point(3, 5099)
Me.grpEpisode24.Name = "grpEpisode24"
Me.grpEpisode24.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode24.TabIndex = 54
Me.grpEpisode24.TabStop = false
Me.grpEpisode24.Text = "Episode24"
'
'txtDescFR24
'
Me.txtDescFR24.Enabled = false
Me.txtDescFR24.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR24.Name = "txtDescFR24"
Me.txtDescFR24.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR24.TabIndex = 16
'
'LabelControl112
'
Me.LabelControl112.Location = New System.Drawing.Point(6, 65)
Me.LabelControl112.Name = "LabelControl112"
Me.LabelControl112.Size = New System.Drawing.Size(93, 13)
Me.LabelControl112.TabIndex = 14
Me.LabelControl112.Text = "Product Description"
'
'txtNameFR24
'
Me.txtNameFR24.Enabled = false
Me.txtNameFR24.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR24.Name = "txtNameFR24"
Me.txtNameFR24.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR24.TabIndex = 13
'
'LabelControl113
'
Me.LabelControl113.Location = New System.Drawing.Point(45, 26)
Me.LabelControl113.Name = "LabelControl113"
Me.LabelControl113.Size = New System.Drawing.Size(67, 13)
Me.LabelControl113.TabIndex = 12
Me.LabelControl113.Text = "Product Name"
'
'grpEpisode23
'
Me.grpEpisode23.Controls.Add(Me.txtDescFR23)
Me.grpEpisode23.Controls.Add(Me.LabelControl110)
Me.grpEpisode23.Controls.Add(Me.txtNameFR23)
Me.grpEpisode23.Controls.Add(Me.LabelControl111)
Me.grpEpisode23.Location = New System.Drawing.Point(5, 4886)
Me.grpEpisode23.Name = "grpEpisode23"
Me.grpEpisode23.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode23.TabIndex = 48
Me.grpEpisode23.TabStop = false
Me.grpEpisode23.Text = "Episode23"
'
'txtDescFR23
'
Me.txtDescFR23.Enabled = false
Me.txtDescFR23.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR23.Name = "txtDescFR23"
Me.txtDescFR23.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR23.TabIndex = 16
'
'LabelControl110
'
Me.LabelControl110.Location = New System.Drawing.Point(6, 65)
Me.LabelControl110.Name = "LabelControl110"
Me.LabelControl110.Size = New System.Drawing.Size(93, 13)
Me.LabelControl110.TabIndex = 14
Me.LabelControl110.Text = "Product Description"
'
'txtNameFR23
'
Me.txtNameFR23.Enabled = false
Me.txtNameFR23.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR23.Name = "txtNameFR23"
Me.txtNameFR23.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR23.TabIndex = 13
'
'LabelControl111
'
Me.LabelControl111.Location = New System.Drawing.Point(45, 26)
Me.LabelControl111.Name = "LabelControl111"
Me.LabelControl111.Size = New System.Drawing.Size(67, 13)
Me.LabelControl111.TabIndex = 12
Me.LabelControl111.Text = "Product Name"
'
'grpEpisode22
'
Me.grpEpisode22.Controls.Add(Me.txtDescFR22)
Me.grpEpisode22.Controls.Add(Me.LabelControl108)
Me.grpEpisode22.Controls.Add(Me.txtNameFR22)
Me.grpEpisode22.Controls.Add(Me.LabelControl109)
Me.grpEpisode22.Location = New System.Drawing.Point(6, 4665)
Me.grpEpisode22.Name = "grpEpisode22"
Me.grpEpisode22.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode22.TabIndex = 46
Me.grpEpisode22.TabStop = false
Me.grpEpisode22.Text = "Episode22"
'
'txtDescFR22
'
Me.txtDescFR22.Enabled = false
Me.txtDescFR22.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR22.Name = "txtDescFR22"
Me.txtDescFR22.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR22.TabIndex = 16
'
'LabelControl108
'
Me.LabelControl108.Location = New System.Drawing.Point(6, 65)
Me.LabelControl108.Name = "LabelControl108"
Me.LabelControl108.Size = New System.Drawing.Size(93, 13)
Me.LabelControl108.TabIndex = 14
Me.LabelControl108.Text = "Product Description"
'
'txtNameFR22
'
Me.txtNameFR22.Enabled = false
Me.txtNameFR22.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR22.Name = "txtNameFR22"
Me.txtNameFR22.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR22.TabIndex = 13
'
'LabelControl109
'
Me.LabelControl109.Location = New System.Drawing.Point(45, 26)
Me.LabelControl109.Name = "LabelControl109"
Me.LabelControl109.Size = New System.Drawing.Size(67, 13)
Me.LabelControl109.TabIndex = 12
Me.LabelControl109.Text = "Product Name"
'
'grpEpisode21
'
Me.grpEpisode21.Controls.Add(Me.txtDescFR21)
Me.grpEpisode21.Controls.Add(Me.LabelControl106)
Me.grpEpisode21.Controls.Add(Me.txtNameFR21)
Me.grpEpisode21.Controls.Add(Me.LabelControl107)
Me.grpEpisode21.Location = New System.Drawing.Point(12, 4443)
Me.grpEpisode21.Name = "grpEpisode21"
Me.grpEpisode21.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode21.TabIndex = 45
Me.grpEpisode21.TabStop = false
Me.grpEpisode21.Text = "Episode21"
'
'txtDescFR21
'
Me.txtDescFR21.Enabled = false
Me.txtDescFR21.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR21.Name = "txtDescFR21"
Me.txtDescFR21.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR21.TabIndex = 16
'
'LabelControl106
'
Me.LabelControl106.Location = New System.Drawing.Point(6, 65)
Me.LabelControl106.Name = "LabelControl106"
Me.LabelControl106.Size = New System.Drawing.Size(93, 13)
Me.LabelControl106.TabIndex = 14
Me.LabelControl106.Text = "Product Description"
'
'txtNameFR21
'
Me.txtNameFR21.Enabled = false
Me.txtNameFR21.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR21.Name = "txtNameFR21"
Me.txtNameFR21.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR21.TabIndex = 13
'
'LabelControl107
'
Me.LabelControl107.Location = New System.Drawing.Point(45, 26)
Me.LabelControl107.Name = "LabelControl107"
Me.LabelControl107.Size = New System.Drawing.Size(67, 13)
Me.LabelControl107.TabIndex = 12
Me.LabelControl107.Text = "Product Name"
'
'grpEpisode20
'
Me.grpEpisode20.Controls.Add(Me.txtDescFR20)
Me.grpEpisode20.Controls.Add(Me.LabelControl104)
Me.grpEpisode20.Controls.Add(Me.txtNameFR20)
Me.grpEpisode20.Controls.Add(Me.LabelControl105)
Me.grpEpisode20.Location = New System.Drawing.Point(6, 4221)
Me.grpEpisode20.Name = "grpEpisode20"
Me.grpEpisode20.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode20.TabIndex = 41
Me.grpEpisode20.TabStop = false
Me.grpEpisode20.Text = "Episode20"
'
'txtDescFR20
'
Me.txtDescFR20.Enabled = false
Me.txtDescFR20.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR20.Name = "txtDescFR20"
Me.txtDescFR20.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR20.TabIndex = 16
'
'LabelControl104
'
Me.LabelControl104.Location = New System.Drawing.Point(6, 65)
Me.LabelControl104.Name = "LabelControl104"
Me.LabelControl104.Size = New System.Drawing.Size(93, 13)
Me.LabelControl104.TabIndex = 14
Me.LabelControl104.Text = "Product Description"
'
'txtNameFR20
'
Me.txtNameFR20.Enabled = false
Me.txtNameFR20.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR20.Name = "txtNameFR20"
Me.txtNameFR20.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR20.TabIndex = 13
'
'LabelControl105
'
Me.LabelControl105.Location = New System.Drawing.Point(45, 26)
Me.LabelControl105.Name = "LabelControl105"
Me.LabelControl105.Size = New System.Drawing.Size(67, 13)
Me.LabelControl105.TabIndex = 12
Me.LabelControl105.Text = "Product Name"
'
'grpEpisode19
'
Me.grpEpisode19.Controls.Add(Me.txtDescFR19)
Me.grpEpisode19.Controls.Add(Me.LabelControl102)
Me.grpEpisode19.Controls.Add(Me.txtNameFR19)
Me.grpEpisode19.Controls.Add(Me.LabelControl103)
Me.grpEpisode19.Location = New System.Drawing.Point(6, 4001)
Me.grpEpisode19.Name = "grpEpisode19"
Me.grpEpisode19.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode19.TabIndex = 39
Me.grpEpisode19.TabStop = false
Me.grpEpisode19.Text = "Episode19"
'
'txtDescFR19
'
Me.txtDescFR19.Enabled = false
Me.txtDescFR19.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR19.Name = "txtDescFR19"
Me.txtDescFR19.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR19.TabIndex = 16
'
'LabelControl102
'
Me.LabelControl102.Location = New System.Drawing.Point(6, 65)
Me.LabelControl102.Name = "LabelControl102"
Me.LabelControl102.Size = New System.Drawing.Size(93, 13)
Me.LabelControl102.TabIndex = 14
Me.LabelControl102.Text = "Product Description"
'
'txtNameFR19
'
Me.txtNameFR19.Enabled = false
Me.txtNameFR19.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR19.Name = "txtNameFR19"
Me.txtNameFR19.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR19.TabIndex = 13
'
'LabelControl103
'
Me.LabelControl103.Location = New System.Drawing.Point(45, 26)
Me.LabelControl103.Name = "LabelControl103"
Me.LabelControl103.Size = New System.Drawing.Size(67, 13)
Me.LabelControl103.TabIndex = 12
Me.LabelControl103.Text = "Product Name"
'
'grpEpisode18
'
Me.grpEpisode18.Controls.Add(Me.txtDescFR18)
Me.grpEpisode18.Controls.Add(Me.LabelControl100)
Me.grpEpisode18.Controls.Add(Me.txtNameFR18)
Me.grpEpisode18.Controls.Add(Me.LabelControl101)
Me.grpEpisode18.Location = New System.Drawing.Point(6, 3782)
Me.grpEpisode18.Name = "grpEpisode18"
Me.grpEpisode18.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode18.TabIndex = 38
Me.grpEpisode18.TabStop = false
Me.grpEpisode18.Text = "Episode18"
'
'txtDescFR18
'
Me.txtDescFR18.Enabled = false
Me.txtDescFR18.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR18.Name = "txtDescFR18"
Me.txtDescFR18.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR18.TabIndex = 16
'
'LabelControl100
'
Me.LabelControl100.Location = New System.Drawing.Point(6, 65)
Me.LabelControl100.Name = "LabelControl100"
Me.LabelControl100.Size = New System.Drawing.Size(93, 13)
Me.LabelControl100.TabIndex = 14
Me.LabelControl100.Text = "Product Description"
'
'txtNameFR18
'
Me.txtNameFR18.Enabled = false
Me.txtNameFR18.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR18.Name = "txtNameFR18"
Me.txtNameFR18.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR18.TabIndex = 13
'
'LabelControl101
'
Me.LabelControl101.Location = New System.Drawing.Point(45, 26)
Me.LabelControl101.Name = "LabelControl101"
Me.LabelControl101.Size = New System.Drawing.Size(67, 13)
Me.LabelControl101.TabIndex = 12
Me.LabelControl101.Text = "Product Name"
'
'grpEpisode17
'
Me.grpEpisode17.Controls.Add(Me.txtDescFR17)
Me.grpEpisode17.Controls.Add(Me.LabelControl98)
Me.grpEpisode17.Controls.Add(Me.txtNameFR17)
Me.grpEpisode17.Controls.Add(Me.LabelControl99)
Me.grpEpisode17.Location = New System.Drawing.Point(12, 3560)
Me.grpEpisode17.Name = "grpEpisode17"
Me.grpEpisode17.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode17.TabIndex = 37
Me.grpEpisode17.TabStop = false
Me.grpEpisode17.Text = "Episode17"
'
'txtDescFR17
'
Me.txtDescFR17.Enabled = false
Me.txtDescFR17.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR17.Name = "txtDescFR17"
Me.txtDescFR17.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR17.TabIndex = 16
'
'LabelControl98
'
Me.LabelControl98.Location = New System.Drawing.Point(6, 65)
Me.LabelControl98.Name = "LabelControl98"
Me.LabelControl98.Size = New System.Drawing.Size(93, 13)
Me.LabelControl98.TabIndex = 14
Me.LabelControl98.Text = "Product Description"
'
'txtNameFR17
'
Me.txtNameFR17.Enabled = false
Me.txtNameFR17.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR17.Name = "txtNameFR17"
Me.txtNameFR17.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR17.TabIndex = 13
'
'LabelControl99
'
Me.LabelControl99.Location = New System.Drawing.Point(45, 26)
Me.LabelControl99.Name = "LabelControl99"
Me.LabelControl99.Size = New System.Drawing.Size(67, 13)
Me.LabelControl99.TabIndex = 12
Me.LabelControl99.Text = "Product Name"
'
'grpEpisode16
'
Me.grpEpisode16.Controls.Add(Me.txtDescFR16)
Me.grpEpisode16.Controls.Add(Me.LabelControl96)
Me.grpEpisode16.Controls.Add(Me.txtNameFR16)
Me.grpEpisode16.Controls.Add(Me.LabelControl97)
Me.grpEpisode16.Location = New System.Drawing.Point(12, 3342)
Me.grpEpisode16.Name = "grpEpisode16"
Me.grpEpisode16.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode16.TabIndex = 35
Me.grpEpisode16.TabStop = false
Me.grpEpisode16.Text = "Episode16"
'
'txtDescFR16
'
Me.txtDescFR16.Enabled = false
Me.txtDescFR16.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR16.Name = "txtDescFR16"
Me.txtDescFR16.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR16.TabIndex = 16
'
'LabelControl96
'
Me.LabelControl96.Location = New System.Drawing.Point(6, 65)
Me.LabelControl96.Name = "LabelControl96"
Me.LabelControl96.Size = New System.Drawing.Size(93, 13)
Me.LabelControl96.TabIndex = 14
Me.LabelControl96.Text = "Product Description"
'
'txtNameFR16
'
Me.txtNameFR16.Enabled = false
Me.txtNameFR16.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR16.Name = "txtNameFR16"
Me.txtNameFR16.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR16.TabIndex = 13
'
'LabelControl97
'
Me.LabelControl97.Location = New System.Drawing.Point(45, 26)
Me.LabelControl97.Name = "LabelControl97"
Me.LabelControl97.Size = New System.Drawing.Size(67, 13)
Me.LabelControl97.TabIndex = 12
Me.LabelControl97.Text = "Product Name"
'
'grpEpisode15
'
Me.grpEpisode15.Controls.Add(Me.txtDescFR15)
Me.grpEpisode15.Controls.Add(Me.LabelControl94)
Me.grpEpisode15.Controls.Add(Me.txtNameFR15)
Me.grpEpisode15.Controls.Add(Me.LabelControl95)
Me.grpEpisode15.Location = New System.Drawing.Point(12, 3122)
Me.grpEpisode15.Name = "grpEpisode15"
Me.grpEpisode15.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode15.TabIndex = 34
Me.grpEpisode15.TabStop = false
Me.grpEpisode15.Text = "Episode15"
'
'txtDescFR15
'
Me.txtDescFR15.Enabled = false
Me.txtDescFR15.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR15.Name = "txtDescFR15"
Me.txtDescFR15.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR15.TabIndex = 16
'
'LabelControl94
'
Me.LabelControl94.Location = New System.Drawing.Point(6, 65)
Me.LabelControl94.Name = "LabelControl94"
Me.LabelControl94.Size = New System.Drawing.Size(93, 13)
Me.LabelControl94.TabIndex = 14
Me.LabelControl94.Text = "Product Description"
'
'txtNameFR15
'
Me.txtNameFR15.Enabled = false
Me.txtNameFR15.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR15.Name = "txtNameFR15"
Me.txtNameFR15.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR15.TabIndex = 13
'
'LabelControl95
'
Me.LabelControl95.Location = New System.Drawing.Point(45, 26)
Me.LabelControl95.Name = "LabelControl95"
Me.LabelControl95.Size = New System.Drawing.Size(67, 13)
Me.LabelControl95.TabIndex = 12
Me.LabelControl95.Text = "Product Name"
'
'grpEpisode14
'
Me.grpEpisode14.Controls.Add(Me.txtDescFR14)
Me.grpEpisode14.Controls.Add(Me.LabelControl92)
Me.grpEpisode14.Controls.Add(Me.txtNameFR14)
Me.grpEpisode14.Controls.Add(Me.LabelControl93)
Me.grpEpisode14.Location = New System.Drawing.Point(12, 2900)
Me.grpEpisode14.Name = "grpEpisode14"
Me.grpEpisode14.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode14.TabIndex = 32
Me.grpEpisode14.TabStop = false
Me.grpEpisode14.Text = "Episode14"
'
'txtDescFR14
'
Me.txtDescFR14.Enabled = false
Me.txtDescFR14.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR14.Name = "txtDescFR14"
Me.txtDescFR14.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR14.TabIndex = 16
'
'LabelControl92
'
Me.LabelControl92.Location = New System.Drawing.Point(6, 65)
Me.LabelControl92.Name = "LabelControl92"
Me.LabelControl92.Size = New System.Drawing.Size(93, 13)
Me.LabelControl92.TabIndex = 14
Me.LabelControl92.Text = "Product Description"
'
'txtNameFR14
'
Me.txtNameFR14.Enabled = false
Me.txtNameFR14.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR14.Name = "txtNameFR14"
Me.txtNameFR14.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR14.TabIndex = 13
'
'LabelControl93
'
Me.LabelControl93.Location = New System.Drawing.Point(45, 26)
Me.LabelControl93.Name = "LabelControl93"
Me.LabelControl93.Size = New System.Drawing.Size(67, 13)
Me.LabelControl93.TabIndex = 12
Me.LabelControl93.Text = "Product Name"
'
'grpEpisode13
'
Me.grpEpisode13.Controls.Add(Me.txtDescFR13)
Me.grpEpisode13.Controls.Add(Me.LabelControl90)
Me.grpEpisode13.Controls.Add(Me.txtNameFR13)
Me.grpEpisode13.Controls.Add(Me.LabelControl91)
Me.grpEpisode13.Location = New System.Drawing.Point(12, 2677)
Me.grpEpisode13.Name = "grpEpisode13"
Me.grpEpisode13.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode13.TabIndex = 30
Me.grpEpisode13.TabStop = false
Me.grpEpisode13.Text = "Episode13"
'
'txtDescFR13
'
Me.txtDescFR13.Enabled = false
Me.txtDescFR13.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR13.Name = "txtDescFR13"
Me.txtDescFR13.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR13.TabIndex = 16
'
'LabelControl90
'
Me.LabelControl90.Location = New System.Drawing.Point(6, 65)
Me.LabelControl90.Name = "LabelControl90"
Me.LabelControl90.Size = New System.Drawing.Size(93, 13)
Me.LabelControl90.TabIndex = 14
Me.LabelControl90.Text = "Product Description"
'
'txtNameFR13
'
Me.txtNameFR13.Enabled = false
Me.txtNameFR13.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR13.Name = "txtNameFR13"
Me.txtNameFR13.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR13.TabIndex = 13
'
'LabelControl91
'
Me.LabelControl91.Location = New System.Drawing.Point(45, 26)
Me.LabelControl91.Name = "LabelControl91"
Me.LabelControl91.Size = New System.Drawing.Size(67, 13)
Me.LabelControl91.TabIndex = 12
Me.LabelControl91.Text = "Product Name"
'
'grpEpisode12
'
Me.grpEpisode12.Controls.Add(Me.txtDescFR12)
Me.grpEpisode12.Controls.Add(Me.LabelControl88)
Me.grpEpisode12.Controls.Add(Me.txtNameFR12)
Me.grpEpisode12.Controls.Add(Me.LabelControl89)
Me.grpEpisode12.Location = New System.Drawing.Point(12, 2455)
Me.grpEpisode12.Name = "grpEpisode12"
Me.grpEpisode12.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode12.TabIndex = 29
Me.grpEpisode12.TabStop = false
Me.grpEpisode12.Text = "Episode12"
'
'txtDescFR12
'
Me.txtDescFR12.Enabled = false
Me.txtDescFR12.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR12.Name = "txtDescFR12"
Me.txtDescFR12.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR12.TabIndex = 16
'
'LabelControl88
'
Me.LabelControl88.Location = New System.Drawing.Point(6, 65)
Me.LabelControl88.Name = "LabelControl88"
Me.LabelControl88.Size = New System.Drawing.Size(93, 13)
Me.LabelControl88.TabIndex = 14
Me.LabelControl88.Text = "Product Description"
'
'txtNameFR12
'
Me.txtNameFR12.Enabled = false
Me.txtNameFR12.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR12.Name = "txtNameFR12"
Me.txtNameFR12.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR12.TabIndex = 13
'
'LabelControl89
'
Me.LabelControl89.Location = New System.Drawing.Point(45, 26)
Me.LabelControl89.Name = "LabelControl89"
Me.LabelControl89.Size = New System.Drawing.Size(67, 13)
Me.LabelControl89.TabIndex = 12
Me.LabelControl89.Text = "Product Name"
'
'grpEpisode11
'
Me.grpEpisode11.Controls.Add(Me.txtDescFR11)
Me.grpEpisode11.Controls.Add(Me.LabelControl77)
Me.grpEpisode11.Controls.Add(Me.txtNameFR11)
Me.grpEpisode11.Controls.Add(Me.LabelControl78)
Me.grpEpisode11.Location = New System.Drawing.Point(12, 2233)
Me.grpEpisode11.Name = "grpEpisode11"
Me.grpEpisode11.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode11.TabIndex = 28
Me.grpEpisode11.TabStop = false
Me.grpEpisode11.Text = "Episode11"
'
'txtDescFR11
'
Me.txtDescFR11.Enabled = false
Me.txtDescFR11.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR11.Name = "txtDescFR11"
Me.txtDescFR11.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR11.TabIndex = 16
'
'LabelControl77
'
Me.LabelControl77.Location = New System.Drawing.Point(6, 65)
Me.LabelControl77.Name = "LabelControl77"
Me.LabelControl77.Size = New System.Drawing.Size(93, 13)
Me.LabelControl77.TabIndex = 14
Me.LabelControl77.Text = "Product Description"
'
'txtNameFR11
'
Me.txtNameFR11.Enabled = false
Me.txtNameFR11.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR11.Name = "txtNameFR11"
Me.txtNameFR11.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR11.TabIndex = 13
'
'LabelControl78
'
Me.LabelControl78.Location = New System.Drawing.Point(45, 26)
Me.LabelControl78.Name = "LabelControl78"
Me.LabelControl78.Size = New System.Drawing.Size(67, 13)
Me.LabelControl78.TabIndex = 12
Me.LabelControl78.Text = "Product Name"
'
'grpEpisode10
'
Me.grpEpisode10.Controls.Add(Me.txtDescFR10)
Me.grpEpisode10.Controls.Add(Me.LabelControl74)
Me.grpEpisode10.Controls.Add(Me.txtNameFR10)
Me.grpEpisode10.Controls.Add(Me.LabelControl76)
Me.grpEpisode10.Location = New System.Drawing.Point(12, 2011)
Me.grpEpisode10.Name = "grpEpisode10"
Me.grpEpisode10.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode10.TabIndex = 27
Me.grpEpisode10.TabStop = false
Me.grpEpisode10.Text = "Episode10"
'
'txtDescFR10
'
Me.txtDescFR10.Enabled = false
Me.txtDescFR10.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR10.Name = "txtDescFR10"
Me.txtDescFR10.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR10.TabIndex = 16
'
'LabelControl74
'
Me.LabelControl74.Location = New System.Drawing.Point(6, 65)
Me.LabelControl74.Name = "LabelControl74"
Me.LabelControl74.Size = New System.Drawing.Size(93, 13)
Me.LabelControl74.TabIndex = 14
Me.LabelControl74.Text = "Product Description"
'
'txtNameFR10
'
Me.txtNameFR10.Enabled = false
Me.txtNameFR10.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR10.Name = "txtNameFR10"
Me.txtNameFR10.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR10.TabIndex = 13
'
'LabelControl76
'
Me.LabelControl76.Location = New System.Drawing.Point(45, 26)
Me.LabelControl76.Name = "LabelControl76"
Me.LabelControl76.Size = New System.Drawing.Size(67, 13)
Me.LabelControl76.TabIndex = 12
Me.LabelControl76.Text = "Product Name"
'
'grpEpisdoe9
'
Me.grpEpisdoe9.Controls.Add(Me.txtDescFR9)
Me.grpEpisdoe9.Controls.Add(Me.LabelControl72)
Me.grpEpisdoe9.Controls.Add(Me.txtNameFR9)
Me.grpEpisdoe9.Controls.Add(Me.LabelControl73)
Me.grpEpisdoe9.Location = New System.Drawing.Point(12, 1789)
Me.grpEpisdoe9.Name = "grpEpisdoe9"
Me.grpEpisdoe9.Size = New System.Drawing.Size(532, 216)
Me.grpEpisdoe9.TabIndex = 25
Me.grpEpisdoe9.TabStop = false
Me.grpEpisdoe9.Text = "Episode9"
'
'txtDescFR9
'
Me.txtDescFR9.Enabled = false
Me.txtDescFR9.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR9.Name = "txtDescFR9"
Me.txtDescFR9.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR9.TabIndex = 16
'
'LabelControl72
'
Me.LabelControl72.Location = New System.Drawing.Point(6, 65)
Me.LabelControl72.Name = "LabelControl72"
Me.LabelControl72.Size = New System.Drawing.Size(93, 13)
Me.LabelControl72.TabIndex = 14
Me.LabelControl72.Text = "Product Description"
'
'txtNameFR9
'
Me.txtNameFR9.Enabled = false
Me.txtNameFR9.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR9.Name = "txtNameFR9"
Me.txtNameFR9.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR9.TabIndex = 13
'
'LabelControl73
'
Me.LabelControl73.Location = New System.Drawing.Point(45, 26)
Me.LabelControl73.Name = "LabelControl73"
Me.LabelControl73.Size = New System.Drawing.Size(67, 13)
Me.LabelControl73.TabIndex = 12
Me.LabelControl73.Text = "Product Name"
'
'grpEpisode8
'
Me.grpEpisode8.Controls.Add(Me.txtDescFR8)
Me.grpEpisode8.Controls.Add(Me.LabelControl66)
Me.grpEpisode8.Controls.Add(Me.txtNameFR8)
Me.grpEpisode8.Controls.Add(Me.LabelControl68)
Me.grpEpisode8.Location = New System.Drawing.Point(12, 1567)
Me.grpEpisode8.Name = "grpEpisode8"
Me.grpEpisode8.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode8.TabIndex = 23
Me.grpEpisode8.TabStop = false
Me.grpEpisode8.Text = "Episode8"
'
'txtDescFR8
'
Me.txtDescFR8.Enabled = false
Me.txtDescFR8.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR8.Name = "txtDescFR8"
Me.txtDescFR8.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR8.TabIndex = 16
'
'LabelControl66
'
Me.LabelControl66.Location = New System.Drawing.Point(6, 65)
Me.LabelControl66.Name = "LabelControl66"
Me.LabelControl66.Size = New System.Drawing.Size(93, 13)
Me.LabelControl66.TabIndex = 14
Me.LabelControl66.Text = "Product Description"
'
'txtNameFR8
'
Me.txtNameFR8.Enabled = false
Me.txtNameFR8.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR8.Name = "txtNameFR8"
Me.txtNameFR8.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR8.TabIndex = 13
'
'LabelControl68
'
Me.LabelControl68.Location = New System.Drawing.Point(45, 26)
Me.LabelControl68.Name = "LabelControl68"
Me.LabelControl68.Size = New System.Drawing.Size(67, 13)
Me.LabelControl68.TabIndex = 12
Me.LabelControl68.Text = "Product Name"
'
'grpEpisode7
'
Me.grpEpisode7.Controls.Add(Me.txtDescFR7)
Me.grpEpisode7.Controls.Add(Me.LabelControl57)
Me.grpEpisode7.Controls.Add(Me.txtNameFR7)
Me.grpEpisode7.Controls.Add(Me.LabelControl65)
Me.grpEpisode7.Location = New System.Drawing.Point(12, 1345)
Me.grpEpisode7.Name = "grpEpisode7"
Me.grpEpisode7.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode7.TabIndex = 21
Me.grpEpisode7.TabStop = false
Me.grpEpisode7.Text = "Episode7"
'
'txtDescFR7
'
Me.txtDescFR7.Enabled = false
Me.txtDescFR7.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR7.Name = "txtDescFR7"
Me.txtDescFR7.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR7.TabIndex = 16
'
'LabelControl57
'
Me.LabelControl57.Location = New System.Drawing.Point(6, 65)
Me.LabelControl57.Name = "LabelControl57"
Me.LabelControl57.Size = New System.Drawing.Size(93, 13)
Me.LabelControl57.TabIndex = 14
Me.LabelControl57.Text = "Product Description"
'
'txtNameFR7
'
Me.txtNameFR7.Enabled = false
Me.txtNameFR7.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR7.Name = "txtNameFR7"
Me.txtNameFR7.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR7.TabIndex = 13
'
'LabelControl65
'
Me.LabelControl65.Location = New System.Drawing.Point(45, 26)
Me.LabelControl65.Name = "LabelControl65"
Me.LabelControl65.Size = New System.Drawing.Size(67, 13)
Me.LabelControl65.TabIndex = 12
Me.LabelControl65.Text = "Product Name"
'
'grpEpisode6
'
Me.grpEpisode6.Controls.Add(Me.txtDescFR6)
Me.grpEpisode6.Controls.Add(Me.LabelControl50)
Me.grpEpisode6.Controls.Add(Me.txtNameFR6)
Me.grpEpisode6.Controls.Add(Me.LabelControl56)
Me.grpEpisode6.Location = New System.Drawing.Point(12, 1123)
Me.grpEpisode6.Name = "grpEpisode6"
Me.grpEpisode6.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode6.TabIndex = 20
Me.grpEpisode6.TabStop = false
Me.grpEpisode6.Text = "Episode6"
'
'txtDescFR6
'
Me.txtDescFR6.Enabled = false
Me.txtDescFR6.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR6.Name = "txtDescFR6"
Me.txtDescFR6.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR6.TabIndex = 16
'
'LabelControl50
'
Me.LabelControl50.Location = New System.Drawing.Point(6, 65)
Me.LabelControl50.Name = "LabelControl50"
Me.LabelControl50.Size = New System.Drawing.Size(93, 13)
Me.LabelControl50.TabIndex = 14
Me.LabelControl50.Text = "Product Description"
'
'txtNameFR6
'
Me.txtNameFR6.Enabled = false
Me.txtNameFR6.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR6.Name = "txtNameFR6"
Me.txtNameFR6.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR6.TabIndex = 13
'
'LabelControl56
'
Me.LabelControl56.Location = New System.Drawing.Point(45, 26)
Me.LabelControl56.Name = "LabelControl56"
Me.LabelControl56.Size = New System.Drawing.Size(67, 13)
Me.LabelControl56.TabIndex = 12
Me.LabelControl56.Text = "Product Name"
'
'grpEpisode5
'
Me.grpEpisode5.Controls.Add(Me.txtDescFR5)
Me.grpEpisode5.Controls.Add(Me.LabelControl48)
Me.grpEpisode5.Controls.Add(Me.txtNameFR5)
Me.grpEpisode5.Controls.Add(Me.LabelControl49)
Me.grpEpisode5.Location = New System.Drawing.Point(12, 901)
Me.grpEpisode5.Name = "grpEpisode5"
Me.grpEpisode5.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode5.TabIndex = 19
Me.grpEpisode5.TabStop = false
Me.grpEpisode5.Text = "Episode5"
'
'txtDescFR5
'
Me.txtDescFR5.Enabled = false
Me.txtDescFR5.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR5.Name = "txtDescFR5"
Me.txtDescFR5.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR5.TabIndex = 16
'
'LabelControl48
'
Me.LabelControl48.Location = New System.Drawing.Point(6, 65)
Me.LabelControl48.Name = "LabelControl48"
Me.LabelControl48.Size = New System.Drawing.Size(93, 13)
Me.LabelControl48.TabIndex = 14
Me.LabelControl48.Text = "Product Description"
'
'txtNameFR5
'
Me.txtNameFR5.Enabled = false
Me.txtNameFR5.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR5.Name = "txtNameFR5"
Me.txtNameFR5.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR5.TabIndex = 13
'
'LabelControl49
'
Me.LabelControl49.Location = New System.Drawing.Point(45, 26)
Me.LabelControl49.Name = "LabelControl49"
Me.LabelControl49.Size = New System.Drawing.Size(67, 13)
Me.LabelControl49.TabIndex = 12
Me.LabelControl49.Text = "Product Name"
'
'grpEpisode4
'
Me.grpEpisode4.Controls.Add(Me.txtDescFR4)
Me.grpEpisode4.Controls.Add(Me.LabelControl46)
Me.grpEpisode4.Controls.Add(Me.txtNameFR4)
Me.grpEpisode4.Controls.Add(Me.LabelControl47)
Me.grpEpisode4.Location = New System.Drawing.Point(12, 679)
Me.grpEpisode4.Name = "grpEpisode4"
Me.grpEpisode4.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode4.TabIndex = 18
Me.grpEpisode4.TabStop = false
Me.grpEpisode4.Text = "Episode4"
'
'txtDescFR4
'
Me.txtDescFR4.Enabled = false
Me.txtDescFR4.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR4.Name = "txtDescFR4"
Me.txtDescFR4.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR4.TabIndex = 16
'
'LabelControl46
'
Me.LabelControl46.Location = New System.Drawing.Point(6, 65)
Me.LabelControl46.Name = "LabelControl46"
Me.LabelControl46.Size = New System.Drawing.Size(93, 13)
Me.LabelControl46.TabIndex = 14
Me.LabelControl46.Text = "Product Description"
'
'txtNameFR4
'
Me.txtNameFR4.Enabled = false
Me.txtNameFR4.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR4.Name = "txtNameFR4"
Me.txtNameFR4.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR4.TabIndex = 13
'
'LabelControl47
'
Me.LabelControl47.Location = New System.Drawing.Point(45, 26)
Me.LabelControl47.Name = "LabelControl47"
Me.LabelControl47.Size = New System.Drawing.Size(67, 13)
Me.LabelControl47.TabIndex = 12
Me.LabelControl47.Text = "Product Name"
'
'grpEpisode3
'
Me.grpEpisode3.Controls.Add(Me.txtDescFR3)
Me.grpEpisode3.Controls.Add(Me.LabelControl42)
Me.grpEpisode3.Controls.Add(Me.txtNameFR3)
Me.grpEpisode3.Controls.Add(Me.LabelControl45)
Me.grpEpisode3.Location = New System.Drawing.Point(12, 457)
Me.grpEpisode3.Name = "grpEpisode3"
Me.grpEpisode3.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode3.TabIndex = 17
Me.grpEpisode3.TabStop = false
Me.grpEpisode3.Text = "Episode3"
'
'txtDescFR3
'
Me.txtDescFR3.Enabled = false
Me.txtDescFR3.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR3.Name = "txtDescFR3"
Me.txtDescFR3.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR3.TabIndex = 16
'
'LabelControl42
'
Me.LabelControl42.Location = New System.Drawing.Point(6, 65)
Me.LabelControl42.Name = "LabelControl42"
Me.LabelControl42.Size = New System.Drawing.Size(93, 13)
Me.LabelControl42.TabIndex = 14
Me.LabelControl42.Text = "Product Description"
'
'txtNameFR3
'
Me.txtNameFR3.Enabled = false
Me.txtNameFR3.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR3.Name = "txtNameFR3"
Me.txtNameFR3.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR3.TabIndex = 13
'
'LabelControl45
'
Me.LabelControl45.Location = New System.Drawing.Point(45, 26)
Me.LabelControl45.Name = "LabelControl45"
Me.LabelControl45.Size = New System.Drawing.Size(67, 13)
Me.LabelControl45.TabIndex = 12
Me.LabelControl45.Text = "Product Name"
'
'grpEpisode2
'
Me.grpEpisode2.Controls.Add(Me.txtDescFR2)
Me.grpEpisode2.Controls.Add(Me.LabelControl29)
Me.grpEpisode2.Controls.Add(Me.txtNameFR2)
Me.grpEpisode2.Controls.Add(Me.LabelControl41)
Me.grpEpisode2.Location = New System.Drawing.Point(12, 235)
Me.grpEpisode2.Name = "grpEpisode2"
Me.grpEpisode2.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode2.TabIndex = 16
Me.grpEpisode2.TabStop = false
Me.grpEpisode2.Text = "Episode2"
'
'txtDescFR2
'
Me.txtDescFR2.Enabled = false
Me.txtDescFR2.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR2.Name = "txtDescFR2"
Me.txtDescFR2.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR2.TabIndex = 16
'
'LabelControl29
'
Me.LabelControl29.Location = New System.Drawing.Point(6, 65)
Me.LabelControl29.Name = "LabelControl29"
Me.LabelControl29.Size = New System.Drawing.Size(93, 13)
Me.LabelControl29.TabIndex = 14
Me.LabelControl29.Text = "Product Description"
'
'txtNameFR2
'
Me.txtNameFR2.Enabled = false
Me.txtNameFR2.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR2.Name = "txtNameFR2"
Me.txtNameFR2.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR2.TabIndex = 13
'
'LabelControl41
'
Me.LabelControl41.Location = New System.Drawing.Point(45, 26)
Me.LabelControl41.Name = "LabelControl41"
Me.LabelControl41.Size = New System.Drawing.Size(67, 13)
Me.LabelControl41.TabIndex = 12
Me.LabelControl41.Text = "Product Name"
'
'grpEpisode1
'
Me.grpEpisode1.Controls.Add(Me.txtDescFR1)
Me.grpEpisode1.Controls.Add(Me.LabelControl43)
Me.grpEpisode1.Controls.Add(Me.txtNameFR1)
Me.grpEpisode1.Controls.Add(Me.LabelControl44)
Me.grpEpisode1.Location = New System.Drawing.Point(12, 13)
Me.grpEpisode1.Name = "grpEpisode1"
Me.grpEpisode1.Size = New System.Drawing.Size(532, 216)
Me.grpEpisode1.TabIndex = 15
Me.grpEpisode1.TabStop = false
Me.grpEpisode1.Text = "Episode1"
'
'txtDescFR1
'
Me.txtDescFR1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_description", true))
Me.txtDescFR1.Enabled = false
Me.txtDescFR1.Location = New System.Drawing.Point(118, 63)
Me.txtDescFR1.Name = "txtDescFR1"
Me.txtDescFR1.Size = New System.Drawing.Size(408, 129)
Me.txtDescFR1.TabIndex = 16
'
'LabelControl43
'
Me.LabelControl43.Location = New System.Drawing.Point(6, 65)
Me.LabelControl43.Name = "LabelControl43"
Me.LabelControl43.Size = New System.Drawing.Size(93, 13)
Me.LabelControl43.TabIndex = 14
Me.LabelControl43.Text = "Product Description"
'
'txtNameFR1
'
Me.txtNameFR1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_name", true))
Me.txtNameFR1.Enabled = false
Me.txtNameFR1.Location = New System.Drawing.Point(118, 23)
Me.txtNameFR1.Name = "txtNameFR1"
Me.txtNameFR1.Size = New System.Drawing.Size(408, 20)
Me.txtNameFR1.TabIndex = 13
'
'LabelControl44
'
Me.LabelControl44.Location = New System.Drawing.Point(45, 26)
Me.LabelControl44.Name = "LabelControl44"
Me.LabelControl44.Size = New System.Drawing.Size(67, 13)
Me.LabelControl44.TabIndex = 12
Me.LabelControl44.Text = "Product Name"
'
'txtAwardFR
'
Me.txtAwardFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_awards", true))
Me.txtAwardFR.Enabled = false
Me.txtAwardFR.Location = New System.Drawing.Point(122, 33)
Me.txtAwardFR.Name = "txtAwardFR"
Me.txtAwardFR.Size = New System.Drawing.Size(408, 80)
Me.txtAwardFR.TabIndex = 12
'
'pictFR
'
Me.pictFR.Location = New System.Drawing.Point(761, 8)
Me.pictFR.Name = "pictFR"
Me.pictFR.Properties.ReadOnly = true
Me.pictFR.Size = New System.Drawing.Size(280, 320)
Me.pictFR.TabIndex = 9
'
'txtImageFR
'
Me.txtImageFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_image_big", true))
Me.txtImageFR.Enabled = false
Me.txtImageFR.Location = New System.Drawing.Point(122, 121)
Me.txtImageFR.Name = "txtImageFR"
Me.txtImageFR.Size = New System.Drawing.Size(408, 20)
Me.txtImageFR.TabIndex = 8
'
'LabelControl17
'
Me.LabelControl17.Location = New System.Drawing.Point(10, 121)
Me.LabelControl17.Name = "LabelControl17"
Me.LabelControl17.Size = New System.Drawing.Size(70, 13)
Me.LabelControl17.TabIndex = 7
Me.LabelControl17.Text = "Product Image"
'
'LabelControl16
'
Me.LabelControl16.Location = New System.Drawing.Point(10, 33)
Me.LabelControl16.Name = "LabelControl16"
Me.LabelControl16.Size = New System.Drawing.Size(71, 13)
Me.LabelControl16.TabIndex = 5
Me.LabelControl16.Text = "Product Award"
'
'txtURLFr
'
Me.txtURLFr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_url", true))
Me.txtURLFr.Enabled = false
Me.txtURLFr.Location = New System.Drawing.Point(122, 9)
Me.txtURLFr.Name = "txtURLFr"
Me.txtURLFr.Size = New System.Drawing.Size(408, 20)
Me.txtURLFr.TabIndex = 4
'
'LabelControl15
'
Me.LabelControl15.Location = New System.Drawing.Point(10, 9)
Me.LabelControl15.Name = "LabelControl15"
Me.LabelControl15.Size = New System.Drawing.Size(59, 13)
Me.LabelControl15.TabIndex = 3
Me.LabelControl15.Text = "Product URL"
'
'LabelControl32
'
Me.LabelControl32.Location = New System.Drawing.Point(6, 65)
Me.LabelControl32.Name = "LabelControl32"
Me.LabelControl32.Size = New System.Drawing.Size(93, 13)
Me.LabelControl32.TabIndex = 14
'
'TextEdit5
'
Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products_description_fr.products_name", true))
Me.TextEdit5.Enabled = false
Me.TextEdit5.Location = New System.Drawing.Point(118, 23)
Me.TextEdit5.Name = "TextEdit5"
Me.TextEdit5.Size = New System.Drawing.Size(408, 20)
Me.TextEdit5.TabIndex = 13
'
'LabelControl40
'
Me.LabelControl40.Location = New System.Drawing.Point(45, 26)
Me.LabelControl40.Name = "LabelControl40"
Me.LabelControl40.Size = New System.Drawing.Size(67, 13)
Me.LabelControl40.TabIndex = 12
'
'LabelControl30
'
Me.LabelControl30.Location = New System.Drawing.Point(45, 26)
Me.LabelControl30.Name = "LabelControl30"
Me.LabelControl30.Size = New System.Drawing.Size(67, 13)
Me.LabelControl30.TabIndex = 12
'
'LabelControl18
'
Me.LabelControl18.Location = New System.Drawing.Point(6, 65)
Me.LabelControl18.Name = "LabelControl18"
Me.LabelControl18.Size = New System.Drawing.Size(93, 13)
Me.LabelControl18.TabIndex = 14
'
'LabelControl14
'
Me.LabelControl14.Location = New System.Drawing.Point(45, 26)
Me.LabelControl14.Name = "LabelControl14"
Me.LabelControl14.Size = New System.Drawing.Size(67, 13)
Me.LabelControl14.TabIndex = 12
'
'tabMain
'
Me.tabMain.Controls.Add(Me.grpVOD)
Me.tabMain.Controls.Add(Me.GroupControl2)
Me.tabMain.Controls.Add(Me.PanelControl3)
Me.tabMain.Controls.Add(Me.grpActors)
Me.tabMain.Controls.Add(Me.grpImage)
Me.tabMain.Controls.Add(Me.grpSeries)
Me.tabMain.Controls.Add(Me.grpMain)
Me.tabMain.Name = "tabMain"
Me.tabMain.Size = New System.Drawing.Size(1047, 690)
Me.tabMain.Text = "General Info"
'
'grpVOD
'
Me.grpVOD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpVOD.Controls.Add(Me.TextEdit4)
Me.grpVOD.Controls.Add(Me.LabelControl61)
Me.grpVOD.Controls.Add(Me.txtVODAudio)
Me.grpVOD.Controls.Add(Me.LabelControl60)
Me.grpVOD.Location = New System.Drawing.Point(733, 41)
Me.grpVOD.Name = "grpVOD"
Me.grpVOD.Size = New System.Drawing.Size(265, 90)
Me.grpVOD.TabIndex = 6
Me.grpVOD.Text = "VOD"
'
'TextEdit4
'
Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "streaming_products.subtitle", true))
Me.TextEdit4.EditValue = ""
Me.TextEdit4.Enabled = false
Me.TextEdit4.Location = New System.Drawing.Point(63, 56)
Me.TextEdit4.Name = "TextEdit4"
Me.TextEdit4.Size = New System.Drawing.Size(197, 20)
Me.TextEdit4.TabIndex = 53
'
'LabelControl61
'
Me.LabelControl61.Location = New System.Drawing.Point(8, 60)
Me.LabelControl61.Name = "LabelControl61"
Me.LabelControl61.Size = New System.Drawing.Size(36, 13)
Me.LabelControl61.TabIndex = 52
Me.LabelControl61.Text = "Subtitle"
'
'txtVODAudio
'
Me.txtVODAudio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "streaming_products.audio", true))
Me.txtVODAudio.EditValue = ""
Me.txtVODAudio.Enabled = false
Me.txtVODAudio.Location = New System.Drawing.Point(63, 32)
Me.txtVODAudio.Name = "txtVODAudio"
Me.txtVODAudio.Size = New System.Drawing.Size(197, 20)
Me.txtVODAudio.TabIndex = 51
'
'LabelControl60
'
Me.LabelControl60.Location = New System.Drawing.Point(8, 36)
Me.LabelControl60.Name = "LabelControl60"
Me.LabelControl60.Size = New System.Drawing.Size(27, 13)
Me.LabelControl60.TabIndex = 50
Me.LabelControl60.Text = "Audio"
'
'GroupControl2
'
Me.GroupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GroupControl2.Controls.Add(Me.MemoEdit1)
Me.GroupControl2.Location = New System.Drawing.Point(8, 556)
Me.GroupControl2.Name = "GroupControl2"
Me.GroupControl2.Size = New System.Drawing.Size(992, 179)
Me.GroupControl2.TabIndex = 5
Me.GroupControl2.Text = "Espace de Travail"
'
'MemoEdit1
'
Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Fill
Me.MemoEdit1.Location = New System.Drawing.Point(2, 20)
Me.MemoEdit1.Name = "MemoEdit1"
Me.MemoEdit1.Size = New System.Drawing.Size(988, 157)
Me.MemoEdit1.TabIndex = 0
'
'PanelControl3
'
Me.PanelControl3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
Me.PanelControl3.Location = New System.Drawing.Point(0, 0)
Me.PanelControl3.Name = "PanelControl3"
Me.PanelControl3.Size = New System.Drawing.Size(1047, 32)
Me.PanelControl3.TabIndex = 4
'
'grpActors
'
Me.grpActors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpActors.Controls.Add(Me.GridActors)
Me.grpActors.Controls.Add(Me.PanelControl1)
Me.grpActors.Location = New System.Drawing.Point(728, 138)
Me.grpActors.Name = "grpActors"
Me.grpActors.Size = New System.Drawing.Size(272, 280)
Me.grpActors.TabIndex = 3
Me.grpActors.Text = "Actors"
'
'GridActors
'
Me.GridActors.DataSource = Me.objDS.products_to_actors
Me.GridActors.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridActors.EmbeddedNavigator.Buttons.Edit.Visible = false
Me.GridActors.EmbeddedNavigator.Buttons.First.Visible = false
Me.GridActors.EmbeddedNavigator.Buttons.Last.Visible = false
Me.GridActors.EmbeddedNavigator.Buttons.Next.Visible = false
Me.GridActors.EmbeddedNavigator.Buttons.NextPage.Visible = false
Me.GridActors.EmbeddedNavigator.Buttons.Prev.Visible = false
Me.GridActors.EmbeddedNavigator.Buttons.PrevPage.Visible = false
Me.GridActors.EmbeddedNavigator.Enabled = false
Me.GridActors.EmbeddedNavigator.Name = ""
Me.GridActors.FormsUseDefaultLookAndFeel = false
GridLevelNode1.RelationName = "Level1"
Me.GridActors.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
Me.GridActors.Location = New System.Drawing.Point(2, 20)
Me.GridActors.MainView = Me.GridViewActors
Me.GridActors.Name = "GridActors"
Me.GridActors.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cmbActors})
Me.GridActors.Size = New System.Drawing.Size(268, 218)
Me.GridActors.TabIndex = 0
Me.GridActors.UseEmbeddedNavigator = true
Me.GridActors.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewActors, Me.GridView9})
'
'GridViewActors
'
Me.GridViewActors.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
Me.GridViewActors.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colproducts_id1, Me.colactors_id})
Me.GridViewActors.CustomizationFormBounds = New System.Drawing.Rectangle(755, 333, 217, 222)
Me.GridViewActors.GridControl = Me.GridActors
Me.GridViewActors.Name = "GridViewActors"
Me.GridViewActors.OptionsBehavior.Editable = false
Me.GridViewActors.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
Me.GridViewActors.OptionsView.ShowBands = false
Me.GridViewActors.OptionsView.ShowGroupPanel = false
'
'GridBand2
'
Me.GridBand2.Caption = "GridBand2"
Me.GridBand2.Columns.Add(Me.colproducts_id1)
Me.GridBand2.Columns.Add(Me.colactors_id)
Me.GridBand2.Name = "GridBand2"
Me.GridBand2.Width = 170
'
'colproducts_id1
'
Me.colproducts_id1.Caption = "products_id"
Me.colproducts_id1.FieldName = "products_id"
Me.colproducts_id1.Name = "colproducts_id1"
'
'colactors_id
'
Me.colactors_id.Caption = "actors_id"
Me.colactors_id.ColumnEdit = Me.cmbActors
Me.colactors_id.FieldName = "actors_id"
Me.colactors_id.Name = "colactors_id"
Me.colactors_id.Visible = true
Me.colactors_id.Width = 170
'
'cmbActors
'
Me.cmbActors.AutoHeight = false
Me.cmbActors.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbActors.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("actors_id", "actors_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("actors_name", "actors_name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbActors.DataSource = Me.objDS.actors
Me.cmbActors.DisplayMember = "actors_name"
Me.cmbActors.Name = "cmbActors"
Me.cmbActors.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
Me.cmbActors.ThrowExceptionOnInvalidLookUpEditValueType = true
Me.cmbActors.ValidateOnEnterKey = true
Me.cmbActors.ValueMember = "actors_id"
'
'GridView9
'
Me.GridView9.GridControl = Me.GridActors
Me.GridView9.Name = "GridView9"
'
'PanelControl1
'
Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl1.Controls.Add(Me.btnActorsMaint)
Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
Me.PanelControl1.Location = New System.Drawing.Point(2, 238)
Me.PanelControl1.Name = "PanelControl1"
Me.PanelControl1.Size = New System.Drawing.Size(268, 40)
Me.PanelControl1.TabIndex = 1
'
'btnActorsMaint
'
Me.btnActorsMaint.Location = New System.Drawing.Point(48, 8)
Me.btnActorsMaint.Name = "btnActorsMaint"
Me.btnActorsMaint.Size = New System.Drawing.Size(96, 23)
Me.btnActorsMaint.TabIndex = 0
Me.btnActorsMaint.Text = "Manage Actors"
'
'grpImage
'
Me.grpImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpImage.Controls.Add(Me.PictProducts_Image)
Me.grpImage.Controls.Add(Me.txtPictureImage)
Me.grpImage.Location = New System.Drawing.Point(456, 286)
Me.grpImage.Name = "grpImage"
Me.grpImage.Size = New System.Drawing.Size(264, 264)
Me.grpImage.TabIndex = 2
Me.grpImage.Text = "Small Image"
'
'PictProducts_Image
'
Me.PictProducts_Image.Location = New System.Drawing.Point(88, 56)
Me.PictProducts_Image.Name = "PictProducts_Image"
Me.PictProducts_Image.Properties.ReadOnly = true
Me.PictProducts_Image.Size = New System.Drawing.Size(100, 136)
Me.PictProducts_Image.TabIndex = 5
'
'txtPictureImage
'
Me.txtPictureImage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_image", true))
Me.txtPictureImage.Enabled = false
Me.txtPictureImage.Location = New System.Drawing.Point(8, 24)
Me.txtPictureImage.Name = "txtPictureImage"
Me.txtPictureImage.Size = New System.Drawing.Size(248, 20)
Me.txtPictureImage.TabIndex = 0
'
'grpSeries
'
Me.grpSeries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpSeries.Controls.Add(Me.cmbVODSerieID)
Me.grpSeries.Controls.Add(Me.LabelControl70)
Me.grpSeries.Controls.Add(Me.txtImdb_id_serie)
Me.grpSeries.Controls.Add(Me.lblImdb_id_serie)
Me.grpSeries.Controls.Add(Me.LabelControl13)
Me.grpSeries.Controls.Add(Me.LabelControl12)
Me.grpSeries.Controls.Add(Me.txtABOSerieNbr)
Me.grpSeries.Controls.Add(Me.LabelControl10)
Me.grpSeries.Controls.Add(Me.cmbABOSerie)
Me.grpSeries.Controls.Add(Me.LabelControl11)
Me.grpSeries.Controls.Add(Me.txtSerieNbr)
Me.grpSeries.Controls.Add(Me.lblSerieNbr)
Me.grpSeries.Controls.Add(Me.cmbSerie)
Me.grpSeries.Controls.Add(Me.lblSeries)
Me.grpSeries.Location = New System.Drawing.Point(456, 40)
Me.grpSeries.Name = "grpSeries"
Me.grpSeries.Size = New System.Drawing.Size(264, 240)
Me.grpSeries.TabIndex = 1
Me.grpSeries.Text = "Series Info"
'
'cmbVODSerieID
'
Me.cmbVODSerieID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.serie_id", true))
Me.cmbVODSerieID.Location = New System.Drawing.Point(95, 195)
Me.cmbVODSerieID.Name = "cmbVODSerieID"
Me.cmbVODSerieID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.cmbVODSerieID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbVODSerieID.Properties.DataSource = Me.objDS.series
Me.cmbVODSerieID.Properties.DisplayMember = "series_name"
Me.cmbVODSerieID.Properties.NullText = ""
Me.cmbVODSerieID.Properties.ValueMember = "series_id"
Me.cmbVODSerieID.Size = New System.Drawing.Size(161, 20)
Me.cmbVODSerieID.TabIndex = 69
'
'LabelControl70
'
Me.LabelControl70.Location = New System.Drawing.Point(8, 198)
Me.LabelControl70.Name = "LabelControl70"
Me.LabelControl70.Size = New System.Drawing.Size(62, 13)
Me.LabelControl70.TabIndex = 68
Me.LabelControl70.Text = "VOD Serie ID"
'
'txtImdb_id_serie
'
Me.txtImdb_id_serie.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.imdb_id_serie", true))
Me.txtImdb_id_serie.EditValue = "0"
Me.txtImdb_id_serie.Enabled = false
Me.txtImdb_id_serie.Location = New System.Drawing.Point(96, 153)
Me.txtImdb_id_serie.Name = "txtImdb_id_serie"
Me.txtImdb_id_serie.Size = New System.Drawing.Size(160, 20)
Me.txtImdb_id_serie.TabIndex = 52
'
'lblImdb_id_serie
'
Me.lblImdb_id_serie.Location = New System.Drawing.Point(7, 156)
Me.lblImdb_id_serie.Name = "lblImdb_id_serie"
Me.lblImdb_id_serie.Size = New System.Drawing.Size(66, 13)
Me.lblImdb_id_serie.TabIndex = 53
Me.lblImdb_id_serie.Text = "IMDB ID Serie"
'
'LabelControl13
'
Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
Me.LabelControl13.Appearance.Options.UseFont = true
Me.LabelControl13.Location = New System.Drawing.Point(8, 24)
Me.LabelControl13.Name = "LabelControl13"
Me.LabelControl13.Size = New System.Drawing.Size(70, 13)
Me.LabelControl13.TabIndex = 35
Me.LabelControl13.Text = "For WEB Site"
'
'LabelControl12
'
Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
Me.LabelControl12.Appearance.Options.UseFont = true
Me.LabelControl12.Location = New System.Drawing.Point(8, 88)
Me.LabelControl12.Name = "LabelControl12"
Me.LabelControl12.Size = New System.Drawing.Size(91, 13)
Me.LabelControl12.TabIndex = 34
Me.LabelControl12.Text = "For ABO Process"
Me.LabelControl12.Visible = false
'
'txtABOSerieNbr
'
Me.txtABOSerieNbr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_series_aboprocess_number", true))
Me.txtABOSerieNbr.Enabled = false
Me.txtABOSerieNbr.Location = New System.Drawing.Point(96, 128)
Me.txtABOSerieNbr.Name = "txtABOSerieNbr"
Me.txtABOSerieNbr.Size = New System.Drawing.Size(160, 20)
Me.txtABOSerieNbr.TabIndex = 31
Me.txtABOSerieNbr.Visible = false
'
'LabelControl10
'
Me.LabelControl10.Location = New System.Drawing.Point(8, 128)
Me.LabelControl10.Name = "LabelControl10"
Me.LabelControl10.Size = New System.Drawing.Size(44, 13)
Me.LabelControl10.TabIndex = 33
Me.LabelControl10.Text = "Serie Nbr"
Me.LabelControl10.Visible = false
'
'cmbABOSerie
'
Me.cmbABOSerie.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_series_aboprocess_id", true))
Me.cmbABOSerie.Enabled = false
Me.cmbABOSerie.Location = New System.Drawing.Point(96, 104)
Me.cmbABOSerie.Name = "cmbABOSerie"
Me.cmbABOSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.cmbABOSerie.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbABOSerie.Properties.DataSource = Me.objDS.series
Me.cmbABOSerie.Properties.DisplayMember = "series_name"
Me.cmbABOSerie.Properties.NullText = ""
Me.cmbABOSerie.Properties.ValueMember = "series_id"
Me.cmbABOSerie.Size = New System.Drawing.Size(160, 20)
Me.cmbABOSerie.TabIndex = 30
Me.cmbABOSerie.Visible = false
'
'LabelControl11
'
Me.LabelControl11.Location = New System.Drawing.Point(8, 104)
Me.LabelControl11.Name = "LabelControl11"
Me.LabelControl11.Size = New System.Drawing.Size(24, 13)
Me.LabelControl11.TabIndex = 32
Me.LabelControl11.Text = "Serie"
Me.LabelControl11.Visible = false
'
'txtSerieNbr
'
Me.txtSerieNbr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_series_number", true))
Me.txtSerieNbr.Enabled = false
Me.txtSerieNbr.Location = New System.Drawing.Point(96, 64)
Me.txtSerieNbr.Name = "txtSerieNbr"
Me.txtSerieNbr.Size = New System.Drawing.Size(160, 20)
Me.txtSerieNbr.TabIndex = 1
'
'lblSerieNbr
'
Me.lblSerieNbr.Location = New System.Drawing.Point(8, 64)
Me.lblSerieNbr.Name = "lblSerieNbr"
Me.lblSerieNbr.Size = New System.Drawing.Size(44, 13)
Me.lblSerieNbr.TabIndex = 29
Me.lblSerieNbr.Text = "Serie Nbr"
'
'cmbSerie
'
Me.cmbSerie.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_series_id", true))
Me.cmbSerie.Enabled = false
Me.cmbSerie.Location = New System.Drawing.Point(96, 40)
Me.cmbSerie.Name = "cmbSerie"
Me.cmbSerie.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.cmbSerie.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_id", "series_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("series_name", "series_name", 120, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbSerie.Properties.DataSource = Me.objDS.series
Me.cmbSerie.Properties.DisplayMember = "series_name"
Me.cmbSerie.Properties.NullText = ""
Me.cmbSerie.Properties.ValueMember = "series_id"
Me.cmbSerie.Size = New System.Drawing.Size(160, 20)
Me.cmbSerie.TabIndex = 0
'
'lblSeries
'
Me.lblSeries.Location = New System.Drawing.Point(8, 40)
Me.lblSeries.Name = "lblSeries"
Me.lblSeries.Size = New System.Drawing.Size(24, 13)
Me.lblSeries.TabIndex = 12
Me.lblSeries.Text = "Serie"
'
'grpMain
'
Me.grpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpMain.Controls.Add(Me.txtSeason)
Me.grpMain.Controls.Add(Me.txtEpisodesNumber)
Me.grpMain.Controls.Add(Me.LabelControl69)
Me.grpMain.Controls.Add(Me.LabelControl62)
Me.grpMain.Controls.Add(Me.chkVodNextNL)
Me.grpMain.Controls.Add(Me.chkVodNextLU)
Me.grpMain.Controls.Add(Me.chkVodNext)
Me.grpMain.Controls.Add(Me.cmbProducts_product_type)
Me.grpMain.Controls.Add(Me.LabelControl52)
Me.grpMain.Controls.Add(Me.txtIMDB_ID)
Me.grpMain.Controls.Add(Me.LabelControl51)
Me.grpMain.Controls.Add(Me.txtTitle)
Me.grpMain.Controls.Add(Me.chkInTheBagsNext)
Me.grpMain.Controls.Add(Me.chkInTheBags)
Me.grpMain.Controls.Add(Me.chkInCinemaNow)
Me.grpMain.Controls.Add(Me.chkProduct_Next)
Me.grpMain.Controls.Add(Me.txtOtherProductID)
Me.grpMain.Controls.Add(Me.LabelControl39)
Me.grpMain.Controls.Add(Me.chkGommetteNL)
Me.grpMain.Controls.Add(Me.chkGommetteFR)
Me.grpMain.Controls.Add(Me.cmbRating)
Me.grpMain.Controls.Add(Me.LabelControl9)
Me.grpMain.Controls.Add(Me.LabelControl8)
Me.grpMain.Controls.Add(Me.cmbAvailability)
Me.grpMain.Controls.Add(Me.LabelControl6)
Me.grpMain.Controls.Add(Me.LabelControl5)
Me.grpMain.Controls.Add(Me.cmbProducts_Media)
Me.grpMain.Controls.Add(Me.LabelControl4)
Me.grpMain.Controls.Add(Me.cmbProducts_Type)
Me.grpMain.Controls.Add(Me.LabelControl3)
Me.grpMain.Controls.Add(Me.cmbProducts_Status)
Me.grpMain.Controls.Add(Me.lblStatus)
Me.grpMain.Controls.Add(Me.cmbDirector)
Me.grpMain.Controls.Add(Me.cmbPictureFormat)
Me.grpMain.Controls.Add(Me.lblPictureFormat)
Me.grpMain.Controls.Add(Me.cmbPublic)
Me.grpMain.Controls.Add(Me.lblPublic)
Me.grpMain.Controls.Add(Me.cmbStudio)
Me.grpMain.Controls.Add(Me.lblStudio)
Me.grpMain.Controls.Add(Me.cmbcountry)
Me.grpMain.Controls.Add(Me.lblcountry)
Me.grpMain.Controls.Add(Me.txtRunTime)
Me.grpMain.Controls.Add(Me.lblRunTime)
Me.grpMain.Controls.Add(Me.txtYear)
Me.grpMain.Controls.Add(Me.lblYear)
Me.grpMain.Controls.Add(Me.txtDateAvailable)
Me.grpMain.Controls.Add(Me.LabelControl2)
Me.grpMain.Controls.Add(Me.txtDateAdded)
Me.grpMain.Controls.Add(Me.txtQtyNow)
Me.grpMain.Controls.Add(Me.lblQtyNow)
Me.grpMain.Controls.Add(Me.txtQty)
Me.grpMain.Controls.Add(Me.LabelControl1)
Me.grpMain.Controls.Add(Me.lblTitle)
Me.grpMain.Controls.Add(Me.txtModel)
Me.grpMain.Controls.Add(Me.lblModel)
Me.grpMain.Controls.Add(Me.txtProductID)
Me.grpMain.Controls.Add(Me.lblProductID)
Me.grpMain.Location = New System.Drawing.Point(8, 40)
Me.grpMain.Name = "grpMain"
Me.grpMain.Size = New System.Drawing.Size(440, 510)
Me.grpMain.TabIndex = 0
Me.grpMain.Text = "General Info"
'
'txtSeason
'
Me.txtSeason.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.txtSeason.Location = New System.Drawing.Point(103, 295)
Me.txtSeason.Name = "txtSeason"
Me.txtSeason.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtSeason.Size = New System.Drawing.Size(117, 20)
Me.txtSeason.TabIndex = 69
'
'txtEpisodesNumber
'
Me.txtEpisodesNumber.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.txtEpisodesNumber.Location = New System.Drawing.Point(103, 321)
Me.txtEpisodesNumber.Name = "txtEpisodesNumber"
Me.txtEpisodesNumber.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtEpisodesNumber.Size = New System.Drawing.Size(117, 20)
Me.txtEpisodesNumber.TabIndex = 68
'
'LabelControl69
'
Me.LabelControl69.Location = New System.Drawing.Point(16, 323)
Me.LabelControl69.Name = "LabelControl69"
Me.LabelControl69.Size = New System.Drawing.Size(53, 13)
Me.LabelControl69.TabIndex = 66
Me.LabelControl69.Text = "# Episodes"
'
'LabelControl62
'
Me.LabelControl62.Location = New System.Drawing.Point(16, 302)
Me.LabelControl62.Name = "LabelControl62"
Me.LabelControl62.Size = New System.Drawing.Size(35, 13)
Me.LabelControl62.TabIndex = 64
Me.LabelControl62.Text = "Season"
'
'chkVodNextNL
'
Me.chkVodNextNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.vod_next_nl", true))
Me.chkVodNextNL.EditValue = 0
Me.chkVodNextNL.Enabled = false
Me.chkVodNextNL.Location = New System.Drawing.Point(326, 477)
Me.chkVodNextNL.Name = "chkVodNextNL"
Me.chkVodNextNL.Properties.Caption = "Soon in VOD Nl"
Me.chkVodNextNL.Properties.ValueChecked = 1
Me.chkVodNextNL.Properties.ValueUnchecked = 0
Me.chkVodNextNL.Size = New System.Drawing.Size(100, 19)
Me.chkVodNextNL.TabIndex = 56
'
'chkVodNextLU
'
Me.chkVodNextLU.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.vod_next_lux", true))
Me.chkVodNextLU.EditValue = 0
Me.chkVodNextLU.Enabled = false
Me.chkVodNextLU.Location = New System.Drawing.Point(326, 459)
Me.chkVodNextLU.Name = "chkVodNextLU"
Me.chkVodNextLU.Properties.Caption = "Soon in VOD Lux"
Me.chkVodNextLU.Properties.ValueChecked = 1
Me.chkVodNextLU.Properties.ValueUnchecked = 0
Me.chkVodNextLU.Size = New System.Drawing.Size(106, 19)
Me.chkVodNextLU.TabIndex = 55
'
'chkVodNext
'
Me.chkVodNext.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.vod_next", true))
Me.chkVodNext.EditValue = 0
Me.chkVodNext.Enabled = false
Me.chkVodNext.Location = New System.Drawing.Point(326, 443)
Me.chkVodNext.Name = "chkVodNext"
Me.chkVodNext.Properties.Caption = "Soon in VOD"
Me.chkVodNext.Properties.ValueChecked = 1
Me.chkVodNext.Properties.ValueUnchecked = 0
Me.chkVodNext.Size = New System.Drawing.Size(93, 19)
Me.chkVodNext.TabIndex = 54
'
'cmbProducts_product_type
'
Me.cmbProducts_product_type.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_product_type", true))
Me.cmbProducts_product_type.Enabled = false
Me.cmbProducts_product_type.Location = New System.Drawing.Point(104, 97)
Me.cmbProducts_product_type.Name = "cmbProducts_product_type"
Me.cmbProducts_product_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbProducts_product_type.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CodeDesc", "Desc", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbProducts_product_type.Properties.DataSource = Me.objDS.product_type
Me.cmbProducts_product_type.Properties.DisplayMember = "CodeDesc"
Me.cmbProducts_product_type.Properties.NullText = ""
Me.cmbProducts_product_type.Properties.ValueMember = "CodeValue"
Me.cmbProducts_product_type.Size = New System.Drawing.Size(112, 20)
Me.cmbProducts_product_type.TabIndex = 52
Me.cmbProducts_product_type.Visible = false
'
'LabelControl52
'
Me.LabelControl52.Location = New System.Drawing.Point(16, 97)
Me.LabelControl52.Name = "LabelControl52"
Me.LabelControl52.Size = New System.Drawing.Size(64, 13)
Me.LabelControl52.TabIndex = 53
Me.LabelControl52.Text = "Product Type"
Me.LabelControl52.Visible = false
'
'txtIMDB_ID
'
Me.txtIMDB_ID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.imdb_id", true))
Me.txtIMDB_ID.Enabled = false
Me.txtIMDB_ID.Location = New System.Drawing.Point(104, 269)
Me.txtIMDB_ID.Name = "txtIMDB_ID"
Me.txtIMDB_ID.Size = New System.Drawing.Size(104, 20)
Me.txtIMDB_ID.TabIndex = 50
'
'LabelControl51
'
Me.LabelControl51.Location = New System.Drawing.Point(16, 272)
Me.LabelControl51.Name = "LabelControl51"
Me.LabelControl51.Size = New System.Drawing.Size(39, 13)
Me.LabelControl51.TabIndex = 51
Me.LabelControl51.Text = "IMDB ID"
'
'txtTitle
'
Me.txtTitle.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_title", true))
Me.txtTitle.Enabled = false
Me.txtTitle.Location = New System.Drawing.Point(104, 147)
Me.txtTitle.Name = "txtTitle"
Me.txtTitle.Size = New System.Drawing.Size(328, 20)
Me.txtTitle.TabIndex = 49
'
'chkInTheBagsNext
'
Me.chkInTheBagsNext.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.in_the_bags_next", true))
Me.chkInTheBagsNext.EditValue = 0
Me.chkInTheBagsNext.Enabled = false
Me.chkInTheBagsNext.Location = New System.Drawing.Point(203, 459)
Me.chkInTheBagsNext.Name = "chkInTheBagsNext"
Me.chkInTheBagsNext.Properties.Caption = "In The Bags Next"
Me.chkInTheBagsNext.Properties.ValueChecked = 1
Me.chkInTheBagsNext.Properties.ValueUnchecked = 0
Me.chkInTheBagsNext.Size = New System.Drawing.Size(112, 19)
Me.chkInTheBagsNext.TabIndex = 48
Me.chkInTheBagsNext.Visible = false
'
'chkInTheBags
'
Me.chkInTheBags.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.in_the_bags", true))
Me.chkInTheBags.EditValue = 0
Me.chkInTheBags.Enabled = false
Me.chkInTheBags.Location = New System.Drawing.Point(101, 459)
Me.chkInTheBags.Name = "chkInTheBags"
Me.chkInTheBags.Properties.Caption = "In The Bags"
Me.chkInTheBags.Properties.ValueChecked = 1
Me.chkInTheBags.Properties.ValueUnchecked = 0
Me.chkInTheBags.Size = New System.Drawing.Size(93, 19)
Me.chkInTheBags.TabIndex = 47
Me.chkInTheBags.Visible = false
'
'chkInCinemaNow
'
Me.chkInCinemaNow.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.in_cinema_now", true))
Me.chkInCinemaNow.EditValue = 0
Me.chkInCinemaNow.Enabled = false
Me.chkInCinemaNow.Location = New System.Drawing.Point(203, 443)
Me.chkInCinemaNow.Name = "chkInCinemaNow"
Me.chkInCinemaNow.Properties.Caption = "In Cinema Now"
Me.chkInCinemaNow.Properties.ValueChecked = 1
Me.chkInCinemaNow.Properties.ValueUnchecked = 0
Me.chkInCinemaNow.Size = New System.Drawing.Size(112, 19)
Me.chkInCinemaNow.TabIndex = 46
'
'chkProduct_Next
'
Me.chkProduct_Next.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_next", true))
Me.chkProduct_Next.EditValue = 0
Me.chkProduct_Next.Enabled = false
Me.chkProduct_Next.Location = New System.Drawing.Point(101, 443)
Me.chkProduct_Next.Name = "chkProduct_Next"
Me.chkProduct_Next.Properties.Caption = "Product Next"
Me.chkProduct_Next.Properties.ValueChecked = 1
Me.chkProduct_Next.Properties.ValueUnchecked = 0
Me.chkProduct_Next.Size = New System.Drawing.Size(93, 19)
Me.chkProduct_Next.TabIndex = 45
'
'txtOtherProductID
'
Me.txtOtherProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_other_language", true))
Me.txtOtherProductID.Enabled = false
Me.txtOtherProductID.Location = New System.Drawing.Point(328, 24)
Me.txtOtherProductID.Name = "txtOtherProductID"
Me.txtOtherProductID.Size = New System.Drawing.Size(104, 20)
Me.txtOtherProductID.TabIndex = 44
'
'LabelControl39
'
Me.LabelControl39.Location = New System.Drawing.Point(240, 24)
Me.LabelControl39.Name = "LabelControl39"
Me.LabelControl39.Size = New System.Drawing.Size(44, 13)
Me.LabelControl39.TabIndex = 43
Me.LabelControl39.Text = "Linked ID"
Me.ToolTip1.SetToolTip(Me.LabelControl39, "Product ID of same title in another language.")
'
'chkGommetteNL
'
Me.chkGommetteNL.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_undertitle_nl", true))
Me.chkGommetteNL.EditValue = 0
Me.chkGommetteNL.Enabled = false
Me.chkGommetteNL.Location = New System.Drawing.Point(203, 477)
Me.chkGommetteNL.Name = "chkGommetteNL"
Me.chkGommetteNL.Properties.Caption = "Gommette NL"
Me.chkGommetteNL.Properties.ValueChecked = 1
Me.chkGommetteNL.Properties.ValueUnchecked = 0
Me.chkGommetteNL.Size = New System.Drawing.Size(112, 19)
Me.chkGommetteNL.TabIndex = 42
Me.chkGommetteNL.Visible = false
'
'chkGommetteFR
'
Me.chkGommetteFR.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_language_fr", true))
Me.chkGommetteFR.EditValue = 0
Me.chkGommetteFR.Enabled = false
Me.chkGommetteFR.Location = New System.Drawing.Point(101, 477)
Me.chkGommetteFR.Name = "chkGommetteFR"
Me.chkGommetteFR.Properties.Caption = "Gommette FR"
Me.chkGommetteFR.Properties.ValueChecked = 1
Me.chkGommetteFR.Properties.ValueUnchecked = 0
Me.chkGommetteFR.Size = New System.Drawing.Size(93, 19)
Me.chkGommetteFR.TabIndex = 41
Me.chkGommetteFR.Visible = false
'
'cmbRating
'
Me.cmbRating.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_rating", true))
Me.cmbRating.Enabled = false
Me.cmbRating.Location = New System.Drawing.Point(328, 243)
Me.cmbRating.Name = "cmbRating"
Me.cmbRating.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbRating.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("rating_desc", "rating_desc", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbRating.Properties.DataSource = Me.objDS.view_products_rating
Me.cmbRating.Properties.DisplayMember = "rating_desc"
Me.cmbRating.Properties.NullText = ""
Me.cmbRating.Properties.ValueMember = "rating_id"
Me.cmbRating.Size = New System.Drawing.Size(104, 20)
Me.cmbRating.TabIndex = 14
'
'LabelControl9
'
Me.LabelControl9.Location = New System.Drawing.Point(240, 243)
Me.LabelControl9.Name = "LabelControl9"
Me.LabelControl9.Size = New System.Drawing.Size(31, 13)
Me.LabelControl9.TabIndex = 40
Me.LabelControl9.Text = "Rating"
'
'LabelControl8
'
Me.LabelControl8.Location = New System.Drawing.Point(240, 48)
Me.LabelControl8.Name = "LabelControl8"
Me.LabelControl8.Size = New System.Drawing.Size(51, 13)
Me.LabelControl8.TabIndex = 39
Me.LabelControl8.Text = "Availability"
'
'cmbAvailability
'
Me.cmbAvailability.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_availability", true))
Me.cmbAvailability.Enabled = false
Me.cmbAvailability.Location = New System.Drawing.Point(328, 48)
Me.cmbAvailability.Name = "cmbAvailability"
Me.cmbAvailability.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbAvailability.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("availability_desc", "availability_desc", 84, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbAvailability.Properties.DataSource = Me.objDS.view_products_availability
Me.cmbAvailability.Properties.DisplayMember = "availability_desc"
Me.cmbAvailability.Properties.NullText = ""
Me.cmbAvailability.Properties.ValueMember = "availability_id"
Me.cmbAvailability.Size = New System.Drawing.Size(104, 20)
Me.cmbAvailability.TabIndex = 2
'
'LabelControl6
'
Me.LabelControl6.Location = New System.Drawing.Point(16, 419)
Me.LabelControl6.Name = "LabelControl6"
Me.LabelControl6.Size = New System.Drawing.Size(38, 13)
Me.LabelControl6.TabIndex = 37
Me.LabelControl6.Text = "Director"
'
'LabelControl5
'
Me.LabelControl5.Location = New System.Drawing.Point(16, 195)
Me.LabelControl5.Name = "LabelControl5"
Me.LabelControl5.Size = New System.Drawing.Size(57, 13)
Me.LabelControl5.TabIndex = 36
Me.LabelControl5.Text = "Date Added"
'
'cmbProducts_Media
'
Me.cmbProducts_Media.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_media", true))
Me.cmbProducts_Media.Enabled = false
Me.cmbProducts_Media.Location = New System.Drawing.Point(328, 72)
Me.cmbProducts_Media.Name = "cmbProducts_Media"
Me.cmbProducts_Media.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbProducts_Media.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("media_desc", "media_desc", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbProducts_Media.Properties.DataSource = Me.objDS.view_products_media
Me.cmbProducts_Media.Properties.DisplayMember = "media_desc"
Me.cmbProducts_Media.Properties.NullText = ""
Me.cmbProducts_Media.Properties.ValueMember = "media_desc"
Me.cmbProducts_Media.Size = New System.Drawing.Size(104, 20)
Me.cmbProducts_Media.TabIndex = 4
'
'LabelControl4
'
Me.LabelControl4.Location = New System.Drawing.Point(240, 72)
Me.LabelControl4.Name = "LabelControl4"
Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
Me.LabelControl4.TabIndex = 34
Me.LabelControl4.Text = "Media"
'
'cmbProducts_Type
'
Me.cmbProducts_Type.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_type", true))
Me.cmbProducts_Type.Enabled = false
Me.cmbProducts_Type.Location = New System.Drawing.Point(104, 72)
Me.cmbProducts_Type.Name = "cmbProducts_Type"
Me.cmbProducts_Type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbProducts_Type.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("type_desc", "type_desc", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbProducts_Type.Properties.DataSource = Me.objDS.view_products_type
Me.cmbProducts_Type.Properties.DisplayMember = "type_desc"
Me.cmbProducts_Type.Properties.NullText = ""
Me.cmbProducts_Type.Properties.ValueMember = "type_desc"
Me.cmbProducts_Type.Size = New System.Drawing.Size(112, 20)
Me.cmbProducts_Type.TabIndex = 3
'
'LabelControl3
'
Me.LabelControl3.Location = New System.Drawing.Point(16, 72)
Me.LabelControl3.Name = "LabelControl3"
Me.LabelControl3.Size = New System.Drawing.Size(24, 13)
Me.LabelControl3.TabIndex = 32
Me.LabelControl3.Text = "Type"
'
'cmbProducts_Status
'
Me.cmbProducts_Status.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_status", true))
Me.cmbProducts_Status.Enabled = false
Me.cmbProducts_Status.Location = New System.Drawing.Point(104, 48)
Me.cmbProducts_Status.Name = "cmbProducts_Status"
Me.cmbProducts_Status.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbProducts_Status.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("status_desc", "status_desc", 64, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbProducts_Status.Properties.DataSource = Me.objDS.view_products_status
Me.cmbProducts_Status.Properties.DisplayMember = "status_desc"
Me.cmbProducts_Status.Properties.NullText = ""
Me.cmbProducts_Status.Properties.ValueMember = "status_id"
Me.cmbProducts_Status.Size = New System.Drawing.Size(112, 20)
Me.cmbProducts_Status.TabIndex = 1
'
'lblStatus
'
Me.lblStatus.Location = New System.Drawing.Point(16, 48)
Me.lblStatus.Name = "lblStatus"
Me.lblStatus.Size = New System.Drawing.Size(31, 13)
Me.lblStatus.TabIndex = 30
Me.lblStatus.Text = "Status"
'
'cmbDirector
'
Me.cmbDirector.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_directors_id", true))
Me.cmbDirector.Enabled = false
Me.cmbDirector.Location = New System.Drawing.Point(104, 419)
Me.cmbDirector.Name = "cmbDirector"
Me.cmbDirector.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.cmbDirector.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("directors_id", "directors_id", 75, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("directors_name", "directors_name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbDirector.Properties.DataSource = Me.objDS.directors
Me.cmbDirector.Properties.DisplayMember = "directors_name"
Me.cmbDirector.Properties.NullText = ""
Me.cmbDirector.Properties.ValueMember = "directors_id"
Me.cmbDirector.Size = New System.Drawing.Size(328, 20)
Me.cmbDirector.TabIndex = 18
'
'cmbPictureFormat
'
Me.cmbPictureFormat.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_picture_format", true))
Me.cmbPictureFormat.Enabled = false
Me.cmbPictureFormat.Location = New System.Drawing.Point(104, 371)
Me.cmbPictureFormat.Name = "cmbPictureFormat"
Me.cmbPictureFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbPictureFormat.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("picture_format_id", "picture_format_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("picture_format_name", "picture_format_name", 109, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbPictureFormat.Properties.DataSource = Me.objDS.picture_format
Me.cmbPictureFormat.Properties.DisplayMember = "picture_format_name"
Me.cmbPictureFormat.Properties.NullText = ""
Me.cmbPictureFormat.Properties.ValueMember = "picture_format_id"
Me.cmbPictureFormat.Size = New System.Drawing.Size(328, 20)
Me.cmbPictureFormat.TabIndex = 16
'
'lblPictureFormat
'
Me.lblPictureFormat.Location = New System.Drawing.Point(16, 371)
Me.lblPictureFormat.Name = "lblPictureFormat"
Me.lblPictureFormat.Size = New System.Drawing.Size(70, 13)
Me.lblPictureFormat.TabIndex = 24
Me.lblPictureFormat.Text = "Picture Format"
'
'cmbPublic
'
Me.cmbPublic.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_public", true))
Me.cmbPublic.Enabled = false
Me.cmbPublic.Location = New System.Drawing.Point(104, 347)
Me.cmbPublic.Name = "cmbPublic"
Me.cmbPublic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbPublic.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("public_id", "public_id", 30, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("public_name", "public_name", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbPublic.Properties.DataSource = Me.objDS.public1
Me.cmbPublic.Properties.DisplayMember = "public_name"
Me.cmbPublic.Properties.NullText = ""
Me.cmbPublic.Properties.ValueMember = "public_id"
Me.cmbPublic.Size = New System.Drawing.Size(328, 20)
Me.cmbPublic.TabIndex = 15
'
'lblPublic
'
Me.lblPublic.Location = New System.Drawing.Point(16, 347)
Me.lblPublic.Name = "lblPublic"
Me.lblPublic.Size = New System.Drawing.Size(27, 13)
Me.lblPublic.TabIndex = 22
Me.lblPublic.Text = "Public"
'
'cmbStudio
'
Me.cmbStudio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_studio", true))
Me.cmbStudio.Enabled = false
Me.cmbStudio.Location = New System.Drawing.Point(104, 395)
Me.cmbStudio.Name = "cmbStudio"
Me.cmbStudio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.cmbStudio.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_name", "studio_name", 67, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("studio_type", "studio_type", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbStudio.Properties.DataSource = Me.objDS.studio
Me.cmbStudio.Properties.DisplayMember = "studio_name"
Me.cmbStudio.Properties.NullText = ""
Me.cmbStudio.Properties.ValueMember = "studio_id"
Me.cmbStudio.Size = New System.Drawing.Size(328, 20)
Me.cmbStudio.TabIndex = 17
'
'lblStudio
'
Me.lblStudio.Location = New System.Drawing.Point(16, 395)
Me.lblStudio.Name = "lblStudio"
Me.lblStudio.Size = New System.Drawing.Size(30, 13)
Me.lblStudio.TabIndex = 20
Me.lblStudio.Text = "Studio"
'
'cmbcountry
'
Me.cmbcountry.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_countries_id", true))
Me.cmbcountry.Enabled = false
Me.cmbcountry.Location = New System.Drawing.Point(104, 243)
Me.cmbcountry.Name = "cmbcountry"
Me.cmbcountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
Me.cmbcountry.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_id", "countries_id", 77, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_name", "countries_name", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbcountry.Properties.DataSource = Me.objDS.products_countries
Me.cmbcountry.Properties.DisplayMember = "countries_name"
Me.cmbcountry.Properties.NullText = ""
Me.cmbcountry.Properties.ValueMember = "countries_id"
Me.cmbcountry.Size = New System.Drawing.Size(112, 20)
Me.cmbcountry.TabIndex = 13
'
'lblcountry
'
Me.lblcountry.Location = New System.Drawing.Point(16, 243)
Me.lblcountry.Name = "lblcountry"
Me.lblcountry.Size = New System.Drawing.Size(37, 13)
Me.lblcountry.TabIndex = 18
Me.lblcountry.Text = "country"
'
'txtRunTime
'
Me.txtRunTime.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_runtime", true))
Me.txtRunTime.Enabled = false
Me.txtRunTime.Location = New System.Drawing.Point(328, 219)
Me.txtRunTime.Name = "txtRunTime"
Me.txtRunTime.Size = New System.Drawing.Size(104, 20)
Me.txtRunTime.TabIndex = 12
'
'lblRunTime
'
Me.lblRunTime.Location = New System.Drawing.Point(240, 219)
Me.lblRunTime.Name = "lblRunTime"
Me.lblRunTime.Size = New System.Drawing.Size(44, 13)
Me.lblRunTime.TabIndex = 16
Me.lblRunTime.Text = "Run Time"
'
'txtYear
'
Me.txtYear.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_year", true))
Me.txtYear.Enabled = false
Me.txtYear.Location = New System.Drawing.Point(104, 219)
Me.txtYear.Name = "txtYear"
Me.txtYear.Size = New System.Drawing.Size(112, 20)
Me.txtYear.TabIndex = 11
'
'lblYear
'
Me.lblYear.Location = New System.Drawing.Point(16, 219)
Me.lblYear.Name = "lblYear"
Me.lblYear.Size = New System.Drawing.Size(22, 13)
Me.lblYear.TabIndex = 14
Me.lblYear.Text = "Year"
'
'txtDateAvailable
'
Me.txtDateAvailable.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_date_available", true))
Me.txtDateAvailable.EditValue = Nothing
Me.txtDateAvailable.Enabled = false
Me.txtDateAvailable.Location = New System.Drawing.Point(328, 195)
Me.txtDateAvailable.Name = "txtDateAvailable"
Me.txtDateAvailable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.txtDateAvailable.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtDateAvailable.Size = New System.Drawing.Size(104, 20)
Me.txtDateAvailable.TabIndex = 10
'
'LabelControl2
'
Me.LabelControl2.Location = New System.Drawing.Point(240, 195)
Me.LabelControl2.Name = "LabelControl2"
Me.LabelControl2.Size = New System.Drawing.Size(69, 13)
Me.LabelControl2.TabIndex = 12
Me.LabelControl2.Text = "Date Available"
'
'txtDateAdded
'
Me.txtDateAdded.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_date_added", true))
Me.txtDateAdded.EditValue = Nothing
Me.txtDateAdded.Enabled = false
Me.txtDateAdded.Location = New System.Drawing.Point(104, 195)
Me.txtDateAdded.Name = "txtDateAdded"
Me.txtDateAdded.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.txtDateAdded.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtDateAdded.Size = New System.Drawing.Size(112, 20)
Me.txtDateAdded.TabIndex = 9
'
'txtQtyNow
'
Me.txtQtyNow.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_quantity", true))
Me.txtQtyNow.Enabled = false
Me.txtQtyNow.Location = New System.Drawing.Point(328, 171)
Me.txtQtyNow.Name = "txtQtyNow"
Me.txtQtyNow.Size = New System.Drawing.Size(104, 20)
Me.txtQtyNow.TabIndex = 8
'
'lblQtyNow
'
Me.lblQtyNow.Location = New System.Drawing.Point(240, 171)
Me.lblQtyNow.Name = "lblQtyNow"
Me.lblQtyNow.Size = New System.Drawing.Size(42, 13)
Me.lblQtyNow.TabIndex = 8
Me.lblQtyNow.Text = "Qty Now"
'
'txtQty
'
Me.txtQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_dvd_quantity", true))
Me.txtQty.Enabled = false
Me.txtQty.Location = New System.Drawing.Point(104, 171)
Me.txtQty.Name = "txtQty"
Me.txtQty.Size = New System.Drawing.Size(112, 20)
Me.txtQty.TabIndex = 7
'
'LabelControl1
'
Me.LabelControl1.Location = New System.Drawing.Point(16, 171)
Me.LabelControl1.Name = "LabelControl1"
Me.LabelControl1.Size = New System.Drawing.Size(18, 13)
Me.LabelControl1.TabIndex = 6
Me.LabelControl1.Text = "Qty"
'
'lblTitle
'
Me.lblTitle.Location = New System.Drawing.Point(16, 147)
Me.lblTitle.Name = "lblTitle"
Me.lblTitle.Size = New System.Drawing.Size(20, 13)
Me.lblTitle.TabIndex = 4
Me.lblTitle.Text = "Title"
'
'txtModel
'
Me.txtModel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_model", true))
Me.txtModel.Enabled = false
Me.txtModel.Location = New System.Drawing.Point(104, 123)
Me.txtModel.Name = "txtModel"
Me.txtModel.Size = New System.Drawing.Size(328, 20)
Me.txtModel.TabIndex = 5
'
'lblModel
'
Me.lblModel.Location = New System.Drawing.Point(16, 123)
Me.lblModel.Name = "lblModel"
Me.lblModel.Size = New System.Drawing.Size(28, 13)
Me.lblModel.TabIndex = 2
Me.lblModel.Text = "Model"
'
'txtProductID
'
Me.txtProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "products.products_id", true))
Me.txtProductID.Enabled = false
Me.txtProductID.Location = New System.Drawing.Point(104, 24)
Me.txtProductID.Name = "txtProductID"
Me.txtProductID.Size = New System.Drawing.Size(112, 20)
Me.txtProductID.TabIndex = 0
'
'lblProductID
'
Me.lblProductID.Location = New System.Drawing.Point(16, 24)
Me.lblProductID.Name = "lblProductID"
Me.lblProductID.Size = New System.Drawing.Size(51, 13)
Me.lblProductID.TabIndex = 0
Me.lblProductID.Text = "Product ID"
'
'XTabControlProduct
'
Me.XTabControlProduct.Dock = System.Windows.Forms.DockStyle.Fill
Me.XTabControlProduct.Location = New System.Drawing.Point(0, 96)
Me.XTabControlProduct.Name = "XTabControlProduct"
Me.XTabControlProduct.SelectedTabPage = Me.tabMain
Me.XTabControlProduct.Size = New System.Drawing.Size(1056, 721)
Me.XTabControlProduct.TabIndex = 35
Me.XTabControlProduct.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabMain, Me.tabFR, Me.tabNL, Me.tabEN, Me.tabTheme, Me.tabLanguages, Me.tabTrailers, Me.tabGames, Me.tabVod, Me.tabCritiques, Me.tabVodWishlist})
Me.XTabControlProduct.Text = "XtraTabControl1"
'
'frmVOD_Maint
'
Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
Me.ClientSize = New System.Drawing.Size(1056, 817)
Me.Controls.Add(Me.XTabControlProduct)
Me.Controls.Add(Me.PanelControl10)
Me.Name = "frmVOD_Maint"
Me.Controls.SetChildIndex(Me.PanelControl10, 0)
Me.Controls.SetChildIndex(Me.XTabControlProduct, 0)
Me.Controls.SetChildIndex(Me.StatusBar1, 0)
CType(Me.PrintSystem1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MainDataSet,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbViewListRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtQuickSearchRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbReportListRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbFilterListRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDefaultListRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkSelectCategory,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.objDS,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbVODSerie.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PanelControl10,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl10.ResumeLayout(false)
Me.PanelControl10.PerformLayout
CType(Me.TextEdit3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox3.ResumeLayout(false)
Me.GroupBox3.PerformLayout
CType(Me.TextEdit11.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit12.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox4.ResumeLayout(false)
Me.GroupBox4.PerformLayout
CType(Me.TextEdit13.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit14.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox5.ResumeLayout(false)
Me.GroupBox5.PerformLayout
CType(Me.TextEdit15.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit16.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox6.ResumeLayout(false)
Me.GroupBox6.PerformLayout
CType(Me.TextEdit17.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit7.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit18.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SpinEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.tabVodWishlist.ResumeLayout(false)
CType(Me.GridVODWishlist,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.gridViewVODWishlist,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView2,System.ComponentModel.ISupportInitialize).EndInit
Me.tabCritiques.ResumeLayout(false)
Me.tabCritiques.PerformLayout
CType(Me.GridCritiques,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewCritiques,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView3,System.ComponentModel.ISupportInitialize).EndInit
Me.tabVod.ResumeLayout(false)
Me.tabVod.PerformLayout
CType(Me.txtId.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbLanguageSubtitle.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbLanguageSound.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDateExpired.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDateExpired.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDateStart.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDateStart.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TxtFilename.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkAvailable.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtImdbView.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.tabGames.ResumeLayout(false)
Me.tabGames.PerformLayout
CType(Me.chkGameOnline.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtGame_ConfigMini.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtGame_NbrOfPlayersOnline.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtGame_NbrOfPlayers.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.tabTrailers.ResumeLayout(false)
CType(Me.grpPictures,System.ComponentModel.ISupportInitialize).EndInit
Me.grpPictures.ResumeLayout(false)
CType(Me.imgIMDBID_6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.imgIMDBID_5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.imgIMDBID_4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.imgIMDBID_3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.imgIMDBID_2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.imgIMDBID_1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.grpSoundTracks,System.ComponentModel.ISupportInitialize).EndInit
Me.grpSoundTracks.ResumeLayout(false)
CType(Me.GridSoundtracks,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewSoundTracks,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbSoundTracks,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView6,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PanelControl9,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl9.ResumeLayout(false)
CType(Me.grpTrailers,System.ComponentModel.ISupportInitialize).EndInit
Me.grpTrailers.ResumeLayout(false)
Me.Panel2.ResumeLayout(false)
CType(Me.GridStreamingTrailers,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.AdvBandedGridView2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryItemLookUpEdit1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryItemLookUpEdit2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryItemButtonEdit1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView5,System.ComponentModel.ISupportInitialize).EndInit
Me.Panel1.ResumeLayout(false)
CType(Me.GridTrailers,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewTrailers,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ButtonWatchTrailer,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbLangTrailer,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbTrailers_Broadcast,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PanelControl8,System.ComponentModel.ISupportInitialize).EndInit
Me.tabLanguages.ResumeLayout(false)
CType(Me.grpSubTitles,System.ComponentModel.ISupportInitialize).EndInit
Me.grpSubTitles.ResumeLayout(false)
CType(Me.GridUndertitles,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewUndertitles,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbUndertitles,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView8,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PanelControl5,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl5.ResumeLayout(false)
CType(Me.grpLanguage,System.ComponentModel.ISupportInitialize).EndInit
Me.grpLanguage.ResumeLayout(false)
CType(Me.GridLanguages,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewLanguages,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbLanguages1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView7,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PanelControl4,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl4.ResumeLayout(false)
Me.tabTheme.ResumeLayout(false)
CType(Me.PanelControl7,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl7.ResumeLayout(false)
CType(Me.TreeListThemes,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkThemeSelected,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PanelControl12,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl12.ResumeLayout(false)
CType(Me.PanelControl6,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl6.ResumeLayout(false)
CType(Me.TreeListCategories,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PanelControl11,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl11.ResumeLayout(false)
Me.tabEN.ResumeLayout(false)
Me.tabEN.PerformLayout
Me.Panel7.ResumeLayout(false)
Me.Panel8.ResumeLayout(false)
Me.GroupBox29.ResumeLayout(false)
Me.GroupBox29.PerformLayout
CType(Me.txtDescEN24.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN24.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox30.ResumeLayout(false)
Me.GroupBox30.PerformLayout
CType(Me.txtDescEN23.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN23.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox31.ResumeLayout(false)
Me.GroupBox31.PerformLayout
CType(Me.txtDescEN22.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN22.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox32.ResumeLayout(false)
Me.GroupBox32.PerformLayout
CType(Me.txtDescEN21.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN21.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox33.ResumeLayout(false)
Me.GroupBox33.PerformLayout
CType(Me.txtDescEN20.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN20.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox34.ResumeLayout(false)
Me.GroupBox34.PerformLayout
CType(Me.txtDescEN19.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN19.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox35.ResumeLayout(false)
Me.GroupBox35.PerformLayout
CType(Me.txtDescEN18.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN18.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox36.ResumeLayout(false)
Me.GroupBox36.PerformLayout
CType(Me.txtDescEN17.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN17.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox37.ResumeLayout(false)
Me.GroupBox37.PerformLayout
CType(Me.txtDescEN16.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN16.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox38.ResumeLayout(false)
Me.GroupBox38.PerformLayout
CType(Me.txtDescEN15.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN15.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox39.ResumeLayout(false)
Me.GroupBox39.PerformLayout
CType(Me.txtDescEN14.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN14.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox40.ResumeLayout(false)
Me.GroupBox40.PerformLayout
CType(Me.txtDescEN13.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN13.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox41.ResumeLayout(false)
Me.GroupBox41.PerformLayout
CType(Me.txtDescEN12.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN12.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox42.ResumeLayout(false)
Me.GroupBox42.PerformLayout
CType(Me.txtDescEN11.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN11.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox43.ResumeLayout(false)
Me.GroupBox43.PerformLayout
CType(Me.txtDescEN10.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN10.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox44.ResumeLayout(false)
Me.GroupBox44.PerformLayout
CType(Me.txtDescEN9.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN9.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox45.ResumeLayout(false)
Me.GroupBox45.PerformLayout
CType(Me.txtDescEN8.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN8.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox46.ResumeLayout(false)
Me.GroupBox46.PerformLayout
CType(Me.txtDescEN7.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN7.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox47.ResumeLayout(false)
Me.GroupBox47.PerformLayout
CType(Me.txtDescEN6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN6.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox48.ResumeLayout(false)
Me.GroupBox48.PerformLayout
CType(Me.txtDescEN5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN5.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox49.ResumeLayout(false)
Me.GroupBox49.PerformLayout
CType(Me.txtDescEN4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN4.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox50.ResumeLayout(false)
Me.GroupBox50.PerformLayout
CType(Me.txtDescEN3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN3.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox51.ResumeLayout(false)
Me.GroupBox51.PerformLayout
CType(Me.txtDescEN2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN2.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox52.ResumeLayout(false)
Me.GroupBox52.PerformLayout
CType(Me.txtDescEN1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameEN1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtAwardEN.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.pictEN.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtImageEN.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtURLEn.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.tabNL.ResumeLayout(false)
Me.tabNL.PerformLayout
Me.Panel5.ResumeLayout(false)
Me.Panel6.ResumeLayout(false)
Me.GroupBox1.ResumeLayout(false)
Me.GroupBox1.PerformLayout
CType(Me.txtDescNL24.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL24.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox2.ResumeLayout(false)
Me.GroupBox2.PerformLayout
CType(Me.txtDescNL23.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL23.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox7.ResumeLayout(false)
Me.GroupBox7.PerformLayout
CType(Me.txtDescNL22.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL22.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox8.ResumeLayout(false)
Me.GroupBox8.PerformLayout
CType(Me.txtDescNL21.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL21.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox9.ResumeLayout(false)
Me.GroupBox9.PerformLayout
CType(Me.txtDescNL20.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL20.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox10.ResumeLayout(false)
Me.GroupBox10.PerformLayout
CType(Me.txtDescNL19.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL19.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox11.ResumeLayout(false)
Me.GroupBox11.PerformLayout
CType(Me.txtDescNL18.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL18.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox12.ResumeLayout(false)
Me.GroupBox12.PerformLayout
CType(Me.txtDescNL17.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL17.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox13.ResumeLayout(false)
Me.GroupBox13.PerformLayout
CType(Me.txtDescNL16.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL16.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox14.ResumeLayout(false)
Me.GroupBox14.PerformLayout
CType(Me.txtDescNL15.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL15.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox15.ResumeLayout(false)
Me.GroupBox15.PerformLayout
CType(Me.txtDescNL14.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL14.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox16.ResumeLayout(false)
Me.GroupBox16.PerformLayout
CType(Me.txtDescNL13.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL13.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox17.ResumeLayout(false)
Me.GroupBox17.PerformLayout
CType(Me.txtDescNL12.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL12.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox18.ResumeLayout(false)
Me.GroupBox18.PerformLayout
CType(Me.txtDescNL11.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL11.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox19.ResumeLayout(false)
Me.GroupBox19.PerformLayout
CType(Me.txtDescNL10.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL10.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox20.ResumeLayout(false)
Me.GroupBox20.PerformLayout
CType(Me.txtDescNL9.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL9.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox21.ResumeLayout(false)
Me.GroupBox21.PerformLayout
CType(Me.txtDescNL8.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL8.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox22.ResumeLayout(false)
Me.GroupBox22.PerformLayout
CType(Me.txtDescNL7.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL7.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox23.ResumeLayout(false)
Me.GroupBox23.PerformLayout
CType(Me.txtDescNL6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL6.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox24.ResumeLayout(false)
Me.GroupBox24.PerformLayout
CType(Me.txtDescNL5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL5.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox25.ResumeLayout(false)
Me.GroupBox25.PerformLayout
CType(Me.txtDescNL4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL4.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox26.ResumeLayout(false)
Me.GroupBox26.PerformLayout
CType(Me.txtDescNL3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL3.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox27.ResumeLayout(false)
Me.GroupBox27.PerformLayout
CType(Me.txtDescNL2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL2.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupBox28.ResumeLayout(false)
Me.GroupBox28.PerformLayout
CType(Me.txtDescNL1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameNL1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtAwardNL.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.pictNL.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtImageNL.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtURLNl.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.tabFR.ResumeLayout(false)
Me.tabFR.PerformLayout
Me.Panel3.ResumeLayout(false)
Me.Panel4.ResumeLayout(false)
Me.grpEpisode24.ResumeLayout(false)
Me.grpEpisode24.PerformLayout
CType(Me.txtDescFR24.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR24.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode23.ResumeLayout(false)
Me.grpEpisode23.PerformLayout
CType(Me.txtDescFR23.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR23.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode22.ResumeLayout(false)
Me.grpEpisode22.PerformLayout
CType(Me.txtDescFR22.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR22.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode21.ResumeLayout(false)
Me.grpEpisode21.PerformLayout
CType(Me.txtDescFR21.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR21.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode20.ResumeLayout(false)
Me.grpEpisode20.PerformLayout
CType(Me.txtDescFR20.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR20.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode19.ResumeLayout(false)
Me.grpEpisode19.PerformLayout
CType(Me.txtDescFR19.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR19.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode18.ResumeLayout(false)
Me.grpEpisode18.PerformLayout
CType(Me.txtDescFR18.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR18.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode17.ResumeLayout(false)
Me.grpEpisode17.PerformLayout
CType(Me.txtDescFR17.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR17.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode16.ResumeLayout(false)
Me.grpEpisode16.PerformLayout
CType(Me.txtDescFR16.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR16.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode15.ResumeLayout(false)
Me.grpEpisode15.PerformLayout
CType(Me.txtDescFR15.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR15.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode14.ResumeLayout(false)
Me.grpEpisode14.PerformLayout
CType(Me.txtDescFR14.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR14.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode13.ResumeLayout(false)
Me.grpEpisode13.PerformLayout
CType(Me.txtDescFR13.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR13.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode12.ResumeLayout(false)
Me.grpEpisode12.PerformLayout
CType(Me.txtDescFR12.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR12.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode11.ResumeLayout(false)
Me.grpEpisode11.PerformLayout
CType(Me.txtDescFR11.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR11.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode10.ResumeLayout(false)
Me.grpEpisode10.PerformLayout
CType(Me.txtDescFR10.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR10.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisdoe9.ResumeLayout(false)
Me.grpEpisdoe9.PerformLayout
CType(Me.txtDescFR9.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR9.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode8.ResumeLayout(false)
Me.grpEpisode8.PerformLayout
CType(Me.txtDescFR8.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR8.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode7.ResumeLayout(false)
Me.grpEpisode7.PerformLayout
CType(Me.txtDescFR7.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR7.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode6.ResumeLayout(false)
Me.grpEpisode6.PerformLayout
CType(Me.txtDescFR6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR6.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode5.ResumeLayout(false)
Me.grpEpisode5.PerformLayout
CType(Me.txtDescFR5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR5.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode4.ResumeLayout(false)
Me.grpEpisode4.PerformLayout
CType(Me.txtDescFR4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR4.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode3.ResumeLayout(false)
Me.grpEpisode3.PerformLayout
CType(Me.txtDescFR3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR3.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode2.ResumeLayout(false)
Me.grpEpisode2.PerformLayout
CType(Me.txtDescFR2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR2.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.grpEpisode1.ResumeLayout(false)
Me.grpEpisode1.PerformLayout
CType(Me.txtDescFR1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNameFR1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtAwardFR.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.pictFR.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtImageFR.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtURLFr.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit5.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.tabMain.ResumeLayout(false)
CType(Me.grpVOD,System.ComponentModel.ISupportInitialize).EndInit
Me.grpVOD.ResumeLayout(false)
Me.grpVOD.PerformLayout
CType(Me.TextEdit4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtVODAudio.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupControl2.ResumeLayout(false)
CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PanelControl3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.grpActors,System.ComponentModel.ISupportInitialize).EndInit
Me.grpActors.ResumeLayout(false)
CType(Me.GridActors,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewActors,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbActors,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView9,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl1.ResumeLayout(false)
CType(Me.grpImage,System.ComponentModel.ISupportInitialize).EndInit
Me.grpImage.ResumeLayout(false)
CType(Me.PictProducts_Image.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtPictureImage.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.grpSeries,System.ComponentModel.ISupportInitialize).EndInit
Me.grpSeries.ResumeLayout(false)
Me.grpSeries.PerformLayout
CType(Me.cmbVODSerieID.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtImdb_id_serie.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtABOSerieNbr.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbABOSerie.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtSerieNbr.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbSerie.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.grpMain,System.ComponentModel.ISupportInitialize).EndInit
Me.grpMain.ResumeLayout(false)
Me.grpMain.PerformLayout
CType(Me.txtSeason.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtEpisodesNumber.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkVodNextNL.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkVodNextLU.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkVodNext.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbProducts_product_type.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtIMDB_ID.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtTitle.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkInTheBagsNext.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkInTheBags.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkInCinemaNow.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkProduct_Next.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtOtherProductID.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkGommetteNL.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkGommetteFR.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbRating.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbAvailability.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbProducts_Media.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbProducts_Type.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbProducts_Status.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDirector.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbPictureFormat.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbPublic.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbStudio.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbcountry.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtRunTime.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtYear.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDateAvailable.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDateAvailable.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDateAdded.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDateAdded.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtQtyNow.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtQty.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtModel.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtProductID.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.XTabControlProduct,System.ComponentModel.ISupportInitialize).EndInit
Me.XTabControlProduct.ResumeLayout(false)
Me.ResumeLayout(false)

End Sub

#End Region

    Dim sSQL As String
    Private _ctrlGridControl As DVDPostBuziness.ClsGridControl
    Dim _CheckProcess As ClsCheckProcessLogistic

    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()

    End Sub
    Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Dim CurrentProductID As Integer
    Dim SerieProductsIDs As List(Of Integer) = New List(Of Integer)
    Dim CurrentVODSerieID As Integer = -1
    Dim CurrentSeasonID As Integer = -1
    Dim CurrentEpisodeID As Integer = -1
    Dim MainData As clsProduct_VODSerie
    ' Dim sem As New Semaphore(0, 100)
    '  Dim boolLoadingDVDInfo As Boolean = False
    '  Dim boolLoadingOrder As Boolean = False
    Private Enum TypeOfTab

        FR = 0
        NL
        EN
        THEMES
        LANGUAGES
        TRAILERS
        GAMES
        VOD
        CRITIQUES
        VODWISHLIST


    End Enum
    Dim LstRefreshData As New List(Of Boolean)
    Dim _listFeeSharingStudio As New List(Of DVDPostBuziness.clsKeyCombo)



    Dim mvarImagesServer As String = ""
    Public Sub frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim menuStrip As New DVDPostBuziness.contextMenu()
        'GridProductsDVD.ContextMenuStrip = menuStrip
        GridActors.ContextMenuStrip = menuStrip
        GridLanguages.ContextMenuStrip = menuStrip
        GridUndertitles.ContextMenuStrip = menuStrip
        GridTrailers.ContextMenuStrip = menuStrip
        GridSoundtracks.ContextMenuStrip = menuStrip
        'GridProducts_DVD.ContextMenuStrip = menuStrip
        'GridDVDStatusHistory.ContextMenuStrip = menuStrip
        'GridOrders_History.ContextMenuStrip = menuStrip
        'GridOrdersStatusHistory.ContextMenuStrip = menuStrip
        'GridPrevision.ContextMenuStrip = menuStrip
        'GridWishlistCustomers.ContextMenuStrip = menuStrip
        GridCritiques.ContextMenuStrip = menuStrip


        tabGames.PageVisible = False

        Try

            'SetUp of Variables
            KeyFieldName = "products_id"
            IDField = "products_id"
            TableName = "products"
            MainDataSet = objDS
            'Attempt to load the dataset.
            mvarImagesServer = BKGlobal.ExecuteFindFieldValue("ParamValue", "SELECT * FROM generalglobalparameter WHERE SetUpCategory = 'Global' and Name = 'ImagesServer'")
            Me.LoadBKComboSet()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            btnEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            DefaultSet_Bar.Visible = False
            Filter_Bar.Visible = False
            Misc_Bar2.Visible = False


            XTabControlProduct.SelectedTabPage = tabMain

            ' recupe variable products_id  provenant du frmCustomer_maint GridViewOrders par la DVDPostBuziness.clsSingleton
            Dim params As DVDPostBuziness.clsSingleton = Nothing
            params = DVDPostBuziness.clsSingleton.Instance()
            Dim Dvd_Pr_ID As Integer = params.Products_dvd_id

            'If Dvd_Pr_ID <> Nothing Then
            '    txtQuickSearch.EditValue = Dvd_Pr_ID
            '    If IsNumeric(txtQuickSearch.EditValue) Then
            '        CurrentProductID = txtQuickSearch.EditValue
            '        LoadProductsInfo()
            '        If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
            '            XTabControlProduct.SelectedTabPage = tabMain
            '        End If
            '    End If
            'End If

            'initCheckProcess()
            'clsDevExpress.AddHyperlinkDynamic(GridOrders_History)
            'loadWhereDvd()

        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, eLoad)
            ' System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub
#Region "EDIT SAVE NEW"
    Private Sub NewRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuNew.Click, MyBase.EventNewRecord
        If txtSeason.EditValue Is Nothing Or txtSeason.EditValue = 0 Or txtEpisodesNumber.EditValue Is Nothing Or txtEpisodesNumber.EditValue = 0 Or cmbVODSerieID.EditValue Is Nothing Then
            MsgBox("Pleas enter Season, #Episodes and VOD Serie ID", MsgBoxStyle.Exclamation, "Worning")
            Return
        End If
        CurrentVODSerieID = cmbVODSerieID.EditValue
        CurrentSeasonID = txtSeason.EditValue

        ClearData()
        SetState(NewState)
        PopMenuNew.Enabled = False
        PopMenuEdit.Enabled = False
        PopMenuSave.Enabled = True
        PopMenuDelete.Enabled = False
        PopMenuUndo.Enabled = True
        EnablingAll(True)
        OpenType = "NEW"
        Try
            'Clear out the current edits
            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            MainData = New clsProduct_VODSerie(SessionInfo, objDS)

            CurrentProductID = MainData.AddNewProduct(CurrentSeasonID, 1, CurrentVODSerieID)

            txtQuickSearch.EditValue = CurrentProductID
            LoadProductsInfo()

            For i As Integer = 2 To txtEpisodesNumber.EditValue
                SerieProductsIDs.Add(MainData.CopyProduct(CurrentSeasonID, i, CurrentVODSerieID))
                LoadProductsInfo(SerieProductsIDs(SerieProductsIDs.Count - 1))
            Next
            objDS.AcceptChanges()
            EditRecord(Sender, e)
            cmbProducts_Media.SelectedText = "VOD"
        Catch eEndEdit As System.Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, eEndEdit)
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Sub
    Private Sub EditRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click, MyBase.EventEditRecord
        If Me.BindingContext(objDS, TableName).Position < 0 Then
            Exit Sub
        End If
        SetState(EditState)
        PopMenuNew.Enabled = False
        PopMenuEdit.Enabled = False
        PopMenuSave.Enabled = True
        PopMenuDelete.Enabled = False
        PopMenuUndo.Enabled = True
        EnablingForEdit()
        OpenType = "EDIT"
    End Sub
    Private Sub UndoChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuUndo.Click, MyBase.EventUndoChanges
        SetState(BrowseState)
        PopMenuNew.Enabled = True
        PopMenuEdit.Enabled = True
        PopMenuSave.Enabled = False
        PopMenuDelete.Enabled = True
        PopMenuUndo.Enabled = False
        EnablingAll(False)
        Me.BindingContext(objDS, TableName).CancelCurrentEdit()
        LoadProductsInfo()
        OpenType = "BROWSE"
    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges

        Try
            'Validate Fields and assign any Necessary ID
            MainData.ValidateRecordFields(CType(Me.BindingContext(objDS, TableName).Current, DataRowView))
            'Attempt to update the datasource.
            Me.UpdateDataSet()
            RefreshPictureFR()
            RefreshPictureEN()
            RefreshPictureNL()
            SetState(BrowseState)
            PopMenuNew.Enabled = True
            PopMenuEdit.Enabled = True
            PopMenuSave.Enabled = False
            PopMenuDelete.Enabled = True
            PopMenuUndo.Enabled = False
            EnablingAll(False)
            txtSeason.Enabled = True
            txtEpisodesNumber.Enabled = True
            cmbVODSerieID.Enabled = True
            OpenType = "BROWSE"
        Catch eUpdate As System.Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, eUpdate)
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eUpdate.Message)
        Finally
        End Try
    End Sub
    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        Try
            'Prepare saving many episode realted products
            ProductsPreSave()
            'Stop any current edits.
            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            GridViewActors.CloseEditor()
            GridViewActors.UpdateCurrentRow()
            ActorsPreSave()
            Me.BindingContext(objDS, "products_to_actors").EndCurrentEdit()
            GridViewLanguages.CloseEditor()
            GridViewLanguages.UpdateCurrentRow()
            LanguagesPreSave()
            Me.BindingContext(objDS, "products_to_languages").EndCurrentEdit()
            GridViewUndertitles.CloseEditor()
            GridViewUndertitles.UpdateCurrentRow()
            UndertitlesPreSave()
            Me.BindingContext(objDS, "products_to_undertitles").EndCurrentEdit()
            GridViewSoundTracks.CloseEditor()
            GridViewSoundTracks.UpdateCurrentRow()
            SoundtracksPreSave()
            Me.BindingContext(objDS, "products_to_soundtracks").EndCurrentEdit()
            GridViewTrailers.CloseEditor()
            GridViewTrailers.UpdateCurrentRow()
            Me.BindingContext(objDS, "products_trailers").EndCurrentEdit()
            ProductsDescriptionFrPreSave()
            ProductsDescriptionNlPreSave()
            ProductsDescriptionEnPreSave()
            Me.BindingContext(objDS, "products_description_fr").EndCurrentEdit()
            Me.BindingContext(objDS, "products_description_nl").EndCurrentEdit()
            Me.BindingContext(objDS, "products_description_en").EndCurrentEdit()
            'Saving Category Tree
            Dim _node As DevExpress.XtraTreeList.Nodes.TreeListNode
            For Each _node In TreeListCategories.Nodes
                SaveCategoryNode(_node)
            Next
            CategoriesPreSave()

            For Each _node In TreeListThemes.Nodes
                SaveThemeNode(_node)
            Next
            ThemesPreSave()
            'Changing GommetteInfo
            UpdateGommetteInfo()

            MainData.SaveAll(txtIMDB_ID.Text)

            'If XTabControlProduct.SelectedTabPage Is tabFeeSharing Then
            '    SaveMoviemax()
            'End If
            objDS.AcceptChanges()
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ProductsPreSave()
        objDS.products(0).products_last_modified = DateTime.Now
        For Each rowp As dsProducts.productsRow In objDS.Tables("products").Rows
            If rowp.products_id = CurrentProductID Then
                Continue For
            End If
            For index As Integer = 0 To objDS.Tables("products").Rows(0).ItemArray.Length - 1
                If index = 0 Or index = 78 Or index = 79 Then
                    Continue For
                End If
                rowp(index) = objDS.Tables("products").Rows(0)(index)
            Next

        Next

    End Sub

    Private Sub ActorsPreSave()
        Dim actorsList As List(Of Integer) = New List(Of Integer)

        For Each pa As dsProducts.products_to_actorsRow In objDS.Tables("products_to_actors").Rows
            actorsList.Add(pa.actors_id)
        Next
        For index As Integer = 0 To SerieProductsIDs.Count - 1

            For Each actors_id As Integer In actorsList
                If objDS.Tables("products_to_actors").Select(" products_id = " & objDS.Tables("products").Rows(index + 1)("products_id") & " and actors_id = " & actors_id).Length > 0 Then
                    Exit For
                End If
                Dim newpa As dsProducts.products_to_actorsRow = objDS.Tables("products_to_actors").NewRow()
                newpa.actors_id = actors_id
                newpa.products_id = objDS.Tables("products").Rows(index + 1)("products_id")
                objDS.Tables("products_to_actors").Rows.Add(newpa)
            Next
           
        Next
    End Sub

    Private Sub CategoriesPreSave()
        Dim categoriesList As List(Of Integer) = New List(Of Integer)

        For Each pc As dsProducts.products_to_categoriesRow In objDS.Tables("products_to_categories").Rows
            categoriesList.Add(pc.categories_id)
        Next
        For index As Integer = 0 To SerieProductsIDs.Count - 1

            For Each categories_id As Integer In categoriesList
                If objDS.Tables("products_to_categories").Select(" products_id = " & objDS.Tables("products").Rows(index + 1)("products_id") & " and categories_id = " & categories_id).Length > 0 Then
                    Exit For
                End If
                Dim newpc As dsProducts.products_to_categoriesRow = objDS.Tables("products_to_categories").NewRow()
                newpc.categories_id = categories_id
                newpc.products_id = objDS.Tables("products").Rows(index + 1)("products_id")
                objDS.Tables("products_to_categories").Rows.Add(newpc)
            Next

        Next
    End Sub

    Private Sub ThemesPreSave()
        Dim themesList As List(Of Integer) = New List(Of Integer)

        For Each pc As dsProducts.products_to_themesRow In objDS.Tables("products_to_themes").Rows
            themesList.Add(pc.themes_id)
        Next
        For index As Integer = 0 To SerieProductsIDs.Count - 1

            For Each themes_id As Integer In themesList
                If objDS.Tables("products_to_themes").Select(" products_id = " & objDS.Tables("products").Rows(index + 1)("products_id") & " and themes_id = " & themes_id).Length > 0 Then
                    Exit For
                End If
                Dim newpc As dsProducts.products_to_themesRow = objDS.Tables("products_to_themes").NewRow()
                newpc.themes_id = themes_id
                newpc.products_id = objDS.Tables("products").Rows(index + 1)("products_id")
                objDS.Tables("products_to_themes").Rows.Add(newpc)
            Next

        Next
    End Sub

    Private Sub LanguagesPreSave()
        Dim languagesList As List(Of Integer) = New List(Of Integer)

        For Each pl As dsProducts.products_to_languagesRow In objDS.Tables("products_to_languages").Rows
            languagesList.Add(pl.products_languages_id)
        Next
        For index As Integer = 0 To SerieProductsIDs.Count - 1
            If objDS.Tables("products_to_languages").Select(" products_id = " & objDS.Tables("products").Rows(index + 1)("products_id")).Length > 0 Then
                Exit For
            End If
            For Each languages_id As Integer In languagesList
                Dim newpa As dsProducts.products_to_languagesRow = objDS.Tables("products_to_languages").NewRow()
                newpa.products_languages_id = languages_id
                newpa.products_id = objDS.Tables("products").Rows(index + 1)("products_id")
                objDS.Tables("products_to_languages").Rows.Add(newpa)
            Next

        Next
    End Sub

    Private Sub UndertitlesPreSave()
        Dim languagesList As List(Of Integer) = New List(Of Integer)

        For Each pl As dsProducts.products_to_undertitlesRow In objDS.Tables("products_to_undertitles").Rows
            languagesList.Add(pl.products_undertitles_id)
        Next
        For index As Integer = 0 To SerieProductsIDs.Count - 1
            If objDS.Tables("products_to_undertitles").Select(" products_id = " & objDS.Tables("products").Rows(index + 1)("products_id")).Length > 0 Then
                Exit For
            End If
            For Each languages_id As Integer In languagesList
                Dim newpa As dsProducts.products_to_undertitlesRow = objDS.Tables("products_to_undertitles").NewRow()
                newpa.products_undertitles_id = languages_id
                newpa.products_id = objDS.Tables("products").Rows(index + 1)("products_id")
                objDS.Tables("products_to_undertitles").Rows.Add(newpa)
            Next

        Next
    End Sub

    Private Sub SoundtracksPreSave()
        Dim languagesList As List(Of Integer) = New List(Of Integer)

        For Each pl As dsProducts.products_to_soundtracksRow In objDS.Tables("products_to_soundtracks").Rows
            languagesList.Add(pl.products_soundtracks_id)
        Next
        For index As Integer = 0 To SerieProductsIDs.Count - 1
            If objDS.Tables("products_to_soundtracks").Select(" products_id = " & objDS.Tables("products").Rows(index + 1)("products_id")).Length > 0 Then
                Exit For
            End If
            For Each languages_id As Integer In languagesList
                Dim newpa As dsProducts.products_to_soundtracksRow = objDS.Tables("products_to_soundtracks").NewRow()
                newpa.products_soundtracks_id = languages_id
                newpa.products_id = objDS.Tables("products").Rows(index + 1)("products_id")
                objDS.Tables("products_to_soundtracks").Rows.Add(newpa)
            Next

        Next
    End Sub


    Private Sub ProductsDescriptionFrPreSave()
        If objDS.Tables("products_description_fr").Rows.Count = 0 Then
            Return
        End If
        For index As Integer = 0 To SerieProductsIDs.Count - 1
            objDS.Tables("products_description_fr").Rows(index + 1)("products_name") = Panel4.Controls(23 - index - 1).Controls("txtNameFR" & (index + 2)).Text
            objDS.Tables("products_description_fr").Rows(index + 1)("products_description") = Panel4.Controls(23 - index - 1).Controls("txtDescFR" & (index + 2)).Text
            objDS.Tables("products_description_fr").Rows(index + 1)("products_url") = txtURLFr.Text
            objDS.Tables("products_description_fr").Rows(index + 1)("products_awards") = txtAwardFR.Text
            objDS.Tables("products_description_fr").Rows(index + 1)("products_image_big") = txtImageFR.Text
        Next
    End Sub

    Private Sub ProductsDescriptionNlPreSave()
        If objDS.Tables("products_description_nl").Rows.Count = 0 Then
            Return
        End If
        For index As Integer = 0 To SerieProductsIDs.Count - 1
            objDS.Tables("products_description_nl").Rows(index + 1)("products_name") = Panel6.Controls(23 - index - 1).Controls("txtNameNL" & (index + 2)).Text
            objDS.Tables("products_description_nl").Rows(index + 1)("products_description") = Panel6.Controls(23 - index - 1).Controls("txtDescNL" & (index + 2)).Text
            objDS.Tables("products_description_nl").Rows(index + 1)("products_url") = txtURLNl.Text
            objDS.Tables("products_description_nl").Rows(index + 1)("products_awards") = txtAwardNL.Text
            objDS.Tables("products_description_nl").Rows(index + 1)("products_image_big") = txtImageNL.Text
        Next
    End Sub

    Private Sub ProductsDescriptionEnPreSave()
        If objDS.Tables("products_description_en").Rows.Count = 0 Then
            Return
        End If
        For index As Integer = 0 To SerieProductsIDs.Count - 1
            objDS.Tables("products_description_en").Rows(index + 1)("products_name") = Panel8.Controls(23 - index - 1).Controls("txtNameEN" & (index + 2)).Text
            objDS.Tables("products_description_en").Rows(index + 1)("products_description") = Panel8.Controls(23 - index - 1).Controls("txtDescEN" & (index + 2)).Text
            objDS.Tables("products_description_en").Rows(index + 1)("products_url") = txtURLEn.Text
            objDS.Tables("products_description_en").Rows(index + 1)("products_awards") = txtAwardEN.Text
            objDS.Tables("products_description_en").Rows(index + 1)("products_image_big") = txtImageEN.Text
        Next
    End Sub


    Private Sub SaveCategoryNode(ByVal Node1 As DevExpress.XtraTreeList.Nodes.TreeListNode)
        Dim _row As DataRow
        Dim _Node As DevExpress.XtraTreeList.Nodes.TreeListNode
        _row = objDS.Tables("products_to_categories").Rows.Find(New Object() {CurrentProductID, Node1("categories_id")})
        If Node1("category_selected") = 1 Then
            If IsNothing(_row) Then
                _row = objDS.Tables("products_to_categories").NewRow
                _row("products_id") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
                _row("categories_id") = Node1("categories_id")
                objDS.Tables("products_to_categories").Rows.Add(_row)
            End If
        Else
            'UnChecked
            If Not IsNothing(_row) Then
                _row.Delete()
            End If
        End If
        For Each _Node In Node1.Nodes
            SaveCategoryNode(_Node)
        Next
    End Sub
    Private Sub SaveThemeNode(ByVal Node1 As DevExpress.XtraTreeList.Nodes.TreeListNode)
        Dim _row As DataRow
        Dim _Node As DevExpress.XtraTreeList.Nodes.TreeListNode
        _row = objDS.Tables("products_to_themes").Rows.Find(New Object() {CurrentProductID, Node1("themes_id")})
        If Node1("themes_selected") = 1 Then
            If IsNothing(_row) Then
                _row = objDS.Tables("products_to_themes").NewRow
                _row("products_id") = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
                _row("themes_id") = Node1("themes_id")
                objDS.Tables("products_to_themes").Rows.Add(_row)
            End If
        Else
            'UnChecked
            If Not IsNothing(_row) Then
                _row.Delete()
            End If
        End If
        For Each _Node In Node1.Nodes
            SaveThemeNode(_Node)
        Next
    End Sub
    Private Sub SaveMoviemax()
        'If cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX Then

        '    Dim products_id As Integer = CurrentProductID
        '    Dim ok As Boolean = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.clsFeeSharing.moviemaxExist(products_id))
        '    Dim titelNr As Integer = txtTiteNrMovieMax.EditValue
        '    Dim maatschappij As Integer = cmbMovieMaxPartner.EditValue


        '    If ok = False Then
        '        Dim sql As String = DvdPostData.clsFeeSharing.insertMovieMax(products_id, titelNr, maatschappij)
        '        DvdPostData.clsConnection.ExecuteNonQuery(sql)
        '    End If

        '    If ok = True Then
        '        Dim updateSql As String = DvdPostData.clsFeeSharing.updateMovieMaxInput(products_id, txtTiteNrMovieMax.EditValue, cmbMovieMaxPartner.EditValue)
        '        DvdPostData.clsConnection.ExecuteNonQuery(updateSql)
        '    End If
        'End If
    End Sub
#End Region

#Region "Load Data"

    Private Sub InitRefeshTab()
        LstRefreshData.Clear()
        For Each Item As TypeOfTab In [Enum].GetValues(GetType(TypeOfTab))
            LstRefreshData.Add(True)
        Next

    End Sub

    Private Sub loadWhereDvd()
        'Dim lstWhereDvd As New List(Of DVDPostBuziness.clsKeyCombo)
        'Dim sql As String
        'Dim item As DVDPostBuziness.clsKeyCombo

        'item = New DVDPostBuziness.clsKeyCombo()
        'item.DisplayMember = DVDPostTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.WhereDVD.IN)
        'item.Value = DvdPostData.ClsCustomersData.WhereDVD.IN

        'lstWhereDvd.Add(item)

        'item = New DVDPostBuziness.clsKeyCombo()
        'item.DisplayMember = DVDPostTools.clsEnum.getNameStrEnum(DvdPostData.ClsCustomersData.WhereDVD.OUT)
        'item.Value = DvdPostData.ClsCustomersData.WhereDVD.OUT
        'lstWhereDvd.Add(item)

        'cmbInOut.ValueMember = "Value"
        'cmbInOut.DisplayMember = "DisplayMember"
        'cmbInOut.DataSource = lstWhereDvd

    End Sub
    'Private Sub LoadOrdersData(ByVal vDVD_ID As Integer)

    '    '  If boolLoadingOrder = True Then Exit Sub
    '    '  boolLoadingOrder = True
    '    objDS.orders_products_view1.Clear()
    '    Dim _SQLTxt As String
    '    If vDVD_ID <> -1 Then
    '        _SQLTxt = "select op.orders_id,o.orders_status, o.customers_id,o.customers_name,op.products_id, op.products_dvd as dvd_id, o.delivery_country, o.delivery_name, o.customers_email_address, " & _
    '                    " op.pick_group, op.pick_boxid, o.date_purchased, op.orders_products_status , os.name orders_status_name,o.orders_type" & _
    '                    " from orders_products op left join orders o on o.orders_id = op.orders_id " & _
    '                    " join orders_status_new os on o.orders_status = os.id " & _
    '                    " where op.products_id = " & CurrentProductID & " AND op.products_dvd = " & CurrentDVDID & _
    '                    " ORDER BY op.orders_id desc "
    '    Else
    '        _SQLTxt = "select o.orders_type,op.orders_id,o.orders_status, o.customers_id, op.products_id, op.products_dvd as dvd_id, o.delivery_country, o.delivery_name, o.customers_email_address, " & _
    '                                " op.pick_group, op.pick_boxid, o.date_purchased, op.orders_products_status ,os.name orders_status_name,o.orders_type" & _
    '                                " from orders_products op left join orders o on o.orders_id = op.orders_id " & _
    '                                " join orders_status_new os on o.orders_status = os.id " & _
    '                                " where op.products_id = " & CurrentProductID & _
    '                                " ORDER BY op.orders_id desc "
    '    End If
    '    DvdPostData.clsConnection.FillDataSet(objDS.orders_products_view1, _SQLTxt)
    '    ' boolLoadingOrder = False
    'End Sub
    'Private Sub LoadProductsDVDStatusHistory(ByVal vDVD_ID As Integer)
    '    If CurrentProductID < 1 Then Exit Sub
    '    objDS.products_dvd_status_history.Clear()
    '    Dim _SQLTxt As String
    '    _SQLTxt = "select * from products_dvd_status_history where products_id = " & CurrentProductID & " AND products_dvdid = " & CurrentDVDID
    '    DvdPostData.clsConnection.FillDataSet(objDS.products_dvd_status_history, _SQLTxt)
    'End Sub
    Private Sub loadFeeSharingStudio()
        '_listFeeSharingStudio.Clear()
        '_listFeeSharingStudio.Add(New DVDPostBuziness.clsKeyCombo("", 0))
        '_listFeeSharingStudio.Add(New DVDPostBuziness.clsKeyCombo("Universal/Global Data", DvdPostData.clsFeeSharing.feeSharingStudio.UNIVERSAL_GLOBAL_DATA))
        '_listFeeSharingStudio.Add(New DVDPostBuziness.clsKeyCombo("MovieMax", DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX))

        'cmbFeeSharingStudio.Properties.DataSource = _listFeeSharingStudio
    End Sub
    Private Sub loadcmbMovieMaxPartner()

        'Dim dt As DataTable
        'Dim sql As String = DvdPostData.clsFeeSharing.GetMovieMaxPartner()

        'dt = DvdPostData.clsConnection.FillDataSet(sql)
        'cmbMovieMaxPartner.Properties.DataSource = dt
        'cmbMovieMaxPartner.ItemIndex = -1
        'cmbMovieMaxPartner.EditValue = DBNull.Value


    End Sub
    Private Sub LoadMovieMaxInfo()

        'loadcmbMovieMaxPartner()
        'txtTiteNrMovieMax.EditValue = ""
        'If cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX Then

        '    Dim dt As DataTable
        '    Dim sql As String = DvdPostData.clsFeeSharing.GetMovieMaxInput(CurrentProductID)
        '    dt = DvdPostData.clsConnection.FillDataSet(sql)

        '    If Not dt.Rows.Count = 0 Then
        '        txtTiteNrMovieMax.EditValue = dt.Rows(0)("titelnr")
        '        cmbMovieMaxPartner.EditValue = dt.Rows(0)("maatschappij")
        '    End If

        'End If

    End Sub
    Private Sub LoadLanguagesData()
        DvdPostData.clsConnection.FillDataSet(objDS.languages, "SELECT * FROM languages")
    End Sub
    Private Sub loadStudio()
        DvdPostData.clsConnection.FillDataSet(objDS.studio, "SELECT * FROM studio")
    End Sub
    Private Sub loadDirectors()
        DvdPostData.clsConnection.FillDataSet(objDS.directors, "SELECT * FROM directors")
    End Sub
    Private Sub LoadActors()

        DvdPostData.clsConnection.FillDataSet(objDS.actors, "SELECT   actors_id,  actors_name,  actors_image,  actors_dateofbirth ,  actors_description ,  actors_awards ,  top_actors,  death_at,  death_place,   actors_type,  cached_slug, image_active, focus, sexuality , birth_place   FROM actors order by actors_name ")
        'DvdPostData.clsConnection.FillDataSet(objDS.actors, "SELECT * FROM actors order by actors_name ")
    End Sub
    Private Sub loadSeries()
        DvdPostData.clsConnection.FillDataSet(objDS.series, "SELECT * FROM series")
    End Sub
    Private Sub LoadProductsLanguage()
        DvdPostData.clsConnection.FillDataSet(objDS.products_languages, "SELECT * FROM products_languages where languagenav_id = 1 ")
    End Sub
    Private Sub loadProductsCountries()
        DvdPostData.clsConnection.FillDataSet(objDS.products_countries, "SELECT * FROM products_countries")
    End Sub
    Private Sub loadProductsUndertitle()
        DvdPostData.clsConnection.FillDataSet(objDS.products_undertitles, "SELECT * FROM products_undertitles  where language_id = 1 ")
    End Sub
    Private Sub loadProductsSoundtracks()
        DvdPostData.clsConnection.FillDataSet(objDS.products_soundtracks, "SELECT * FROM products_soundtracks  where language_id = 1 ")
    End Sub
    Private Sub loadCritique(ByVal products_id As Integer)
        If LstRefreshData(TypeOfTab.CRITIQUES) Then
            Dim dt_reviews As DataTable
            Dim dt_average As DataTable
            Dim dr_average As DataRow

            dt_reviews = DVDPostBuziness.clsReviews.GetReviewProduct(products_id)
            GridCritiques.DataSource = dt_reviews
            GridViewCritiques.BestFitColumns()
            clsDevExpress.AddHyperlinkDynamic(GridCritiques)
            clsDevExpress.AddCountFooter(GridCritiques)

            dt_average = DVDPostBuziness.clsReviews.GetAverageCritiqueProducts(products_id)

            If dt_average.Rows.Count > 0 Then
                dr_average = dt_average.Rows(0)
                lblValueNbCrtitiques.Text = dr_average("cpt_critiques")
                lblValueNbCritiquePositive.Text = dr_average("cpt_critiques_positive")
                lblValueRatingAverage.Text = dr_average("average_rating_critique")
            End If

            dt_average = DVDPostBuziness.clsReviews.GetAverageRatingProducts(products_id)
            If dt_average.Rows.Count > 0 Then
                dr_average = dt_average.Rows(0)
                lblValueNBRating.Text = dr_average("cpt_rating")
            End If

            LstRefreshData(TypeOfTab.CRITIQUES) = False
        End If
    End Sub
    Private Sub loadVOD(ByVal product_id As Integer)
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsProductDvd.GetSelectVod(product_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)

    End Sub
    Private Sub loadWishlistCustomers(ByVal product_id As Integer)
        'Dim sql As String
        'Dim dt As DataTable
        'If LstRefreshData(TypeOfTab.WISHLISTCUST) Then
        '    sql = DvdPostData.clsProductDvd.GetSelectWishlistCustomerProduct(product_id)
        '    dt = DvdPostData.clsConnection.FillDataSet(sql)
        '    gridViewWishlistCustomers.Columns.Clear()
        '    GridWishlistCustomers.DataSource = dt
        '    gridViewWishlistCustomers.BestFitColumns()
        '    clsDevExpress.AddHyperlinkDynamic(GridWishlistCustomers)
        '    clsDevExpress.AddCountFooter(GridWishlistCustomers)
        '    LstRefreshData(TypeOfTab.WISHLISTCUST) = False
        'End If
    End Sub
    Private Sub loadVodWishlist(ByVal product_id As Integer)
        Dim sql As String
        Dim dt As DataTable
        If LstRefreshData(TypeOfTab.VODWISHLIST) Then
            sql = DvdPostData.ClsVod.GetSelectVodWishlist(product_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            gridViewVODWishlist.Columns.Clear()
            GridVODWishlist.DataSource = dt
            gridViewVODWishlist.BestFitColumns()
            'clsDevExpress.AddHyperlinkDynamic(GridWishlistCustomers)
            'clsDevExpress.AddCountFooter(GridWishlistCustomers)
            LstRefreshData(TypeOfTab.VODWISHLIST) = False
        End If
    End Sub
    Private Sub loadPrevision(ByVal product_id As Integer)
        'Dim sql As String
        'Dim dt As DataTable
        'If LstRefreshData(TypeOfTab.PREVISION) Then
        '    sql = DvdPostData.ClsPurchaseSale.GetSelectViewPurchaseSaleByProducts(product_id)
        '    dt = DvdPostData.clsConnection.FillDataSet(sql)
        '    GridViewPrevision.Columns.Clear()
        '    GridPrevision.DataSource = dt
        '    GridViewPrevision.BestFitColumns()
        '    clsDevExpress.AddHyperlinkDynamic(GridPrevision)
        '    _ctrlGridControl = New DVDPostBuziness.ClsGridControl()
        '    AddHandler _ctrlGridControl.Purchase_click, AddressOf Purchase_click
        '    _ctrlGridControl.addColumnButtonOrderPurchase(GridPrevision, GridViewPrevision)
        '    LstRefreshData(TypeOfTab.PREVISION) = False
        'End If
    End Sub
    'Private Sub loadFeeSharing()
    '    If LstRefreshData(TypeOfTab.FEESHARING) = True Then
    '        loadFeeSharingStudio()
    '        LoadMovieMaxInfo()

    '        LstRefreshData(TypeOfTab.FEESHARING) = False
    '    End If
    'End Sub
    Private Sub LoadFR()
        If LstRefreshData.Count = 0 Then
            Return
        End If
        For j As Integer = 0 To 23
            Panel4.Controls(j).Visible = True
            Panel4.Controls(j).Refresh()
            Panel4.Controls(j).Show()
        Next
        For i As Integer = 23 - Integer.Parse(txtEpisodesNumber.Value) To 0 Step -1
            Panel4.Controls(i).Visible = False
            Panel4.Controls(i).Refresh()
        Next
        Panel4.Refresh()
        If LstRefreshData(TypeOfTab.FR) Then
            MainData.LoadDescriptionFR()
            RefreshPictureFR()
        End If
        LstRefreshData(TypeOfTab.FR) = False
    End Sub
    Private Sub LoadNL()
        If LstRefreshData.Count = 0 Then
            Return
        End If
        For j As Integer = 0 To 23
            Panel6.Controls(j).Visible = True
            Panel6.Controls(j).Refresh()
            Panel6.Controls(j).Show()
        Next
        For i As Integer = 23 - Integer.Parse(txtEpisodesNumber.Value) To 0 Step -1
            Panel6.Controls(i).Visible = False
            Panel6.Controls(i).Refresh()
        Next
        Panel6.Refresh()
        If LstRefreshData(TypeOfTab.NL) Then
            MainData.LoadDescriptionNL()
            RefreshPictureNL()
        End If
        LstRefreshData(TypeOfTab.NL) = False
    End Sub
    Private Sub LoadEN()
        If LstRefreshData.Count = 0 Then
            Return
        End If
        For j As Integer = 0 To 23
            Panel8.Controls(j).Visible = True
            Panel8.Controls(j).Refresh()
            Panel8.Controls(j).Show()
        Next
        For i As Integer = 23 - Integer.Parse(txtEpisodesNumber.Value) To 0 Step -1
            Panel8.Controls(i).Visible = False
            Panel8.Controls(i).Refresh()
        Next
        Panel8.Refresh()
        If LstRefreshData(TypeOfTab.EN) Then
            MainData.LoadDescriptionEN()
            RefreshPictureEN()
        End If
        LstRefreshData(TypeOfTab.EN) = False
    End Sub
    'Private Sub loadDVD()
    '    If LstRefreshData(TypeOfTab.DVD) Then
    '        MainData.Load_All_Products_DVD_Info()
    '        ' Me.GridProducts_DVD.RefreshDataSource()

    '    End If
    '    LstRefreshData(TypeOfTab.DVD) = False
    'End Sub

    Private Sub loadTrailer()
        If LstRefreshData(TypeOfTab.TRAILERS) Then
            MainData.LoadTrailers()
            MainData.LoadStreamingTrailers()
            MainData.LoadSoundtracks()
            RefreshPictureTrailer()
        End If
        LstRefreshData(TypeOfTab.TRAILERS) = False
    End Sub

    Private Sub loadLanguages()
        If LstRefreshData(TypeOfTab.LANGUAGES) Then
            MainData.LoadLanguages()
            MainData.LoadUndertitles()
        End If
        LstRefreshData(TypeOfTab.LANGUAGES) = False
    End Sub
    Private Sub loadTheme()
        If LstRefreshData(TypeOfTab.THEMES) Then
            TreeListCategories.Nodes.Clear()
            TreeListThemes.Nodes.Clear()
            MainData.LoadThemes()
            MainData.LoadCategories()
            RefreshCategoryTree()
            '  TreeListCategories.Refresh()
            RefreshThemeTree()
        End If
        LstRefreshData(TypeOfTab.THEMES) = False
    End Sub
    'Private Sub loadTransfer()
    '    If LstRefreshData(TypeOfTab.TRANSFER) Then
    '        MainData.Load()
    '    End If
    '    LstRefreshData(TypeOfTab.TRANSFER) = False
    'End Sub
    Private Sub loadDVDStatus()
        DvdPostData.clsConnection.FillDataSet(objDS.products_dvd_status, "SELECT * FROM products_dvd_status ")
    End Sub

    Public Sub LoadBKComboSet()
        Try

            LoadLanguagesData()
            loadStudio()
            loadDirectors()
            LoadActors()
            loadSeries()
            LoadProductsLanguage()
            loadProductsCountries()
            loadProductsUndertitle()
            loadProductsSoundtracks()
            loadDVDStatus()
            loadProductsCountries()


            DvdPostData.clsConnection.FillDataSet(objDS.view_products_status, "SELECT codevalue as status_id, codedesc as status_desc from generalglobalcode where CodeType = 'Products_Status'")
            DvdPostData.clsConnection.FillDataSet(objDS.view_products_type, "SELECT codevalue as type_id, codedesc as type_desc from generalglobalcode where CodeType = 'Products_Type'")
            DvdPostData.clsConnection.FillDataSet(objDS.product_type, "SELECT CodeValue , CodeDesc from generalglobalcode where CodeType = 'product_type'")
            DvdPostData.clsConnection.FillDataSet(objDS.view_products_media, "SELECT codevalue as media_id, codedesc as media_desc from generalglobalcode where CodeType = 'Products_Media'")
            DvdPostData.clsConnection.FillDataSet(objDS.view_products_availability, "SELECT codevalue as availability_id, codedesc as availability_desc from generalglobalcode where CodeType = 'Products_Availability'")
            DvdPostData.clsConnection.FillDataSet(objDS.view_products_rating, "SELECT codevalue as rating_id, codedesc as rating_desc from generalglobalcode where CodeType = 'Products_Rating'")

            DvdPostData.clsConnection.FillDataSet(objDS.public1, "SELECT * FROM public where language_id = 1 order by public_id ")
            DvdPostData.clsConnection.FillDataSet(objDS.picture_format, "SELECT * FROM picture_format where language_id = 1 order by picture_format_id ")

            DvdPostData.clsConnection.FillDataSet(objDS.orders_products_status, "SELECT * FROM orders_products_status  where language_id = 1 ")
            DvdPostData.clsConnection.FillDataSet(objDS.orders_status, "SELECT * FROM orders_status_new ")
            DvdPostData.clsConnection.FillDataSet(objDS.trailers_broadcast, "SELECT codevalue as broadcast from generalglobalcode where CodeType = 'trailers_broadcast'")
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            Throw ex
        End Try
    End Sub
    Public Sub LoadOneCombo(ByVal stateInfo As Object)
        Dim _ComboParam As ComboParam = CType(stateInfo, ComboParam)
        DvdPostData.clsConnection.FillDataSet(_ComboParam.LTable, _ComboParam.LSQLStr)
    End Sub

#End Region
    Private Sub ClearData()

        objDS.products.Clear()
        objDS.products_description.Clear()
        objDS.products_trailers.Clear()
        objDS.products_description_fr.Clear()
        objDS.products_description_nl.Clear()
        objDS.products_description_en.Clear()
        objDS.products_to_actors.Clear()
        objDS.products_to_categories.Clear()
        objDS.products_to_languages.Clear()
        objDS.products_to_soundtracks.Clear()
        objDS.products_to_undertitles.Clear()

    End Sub
    Public Sub UpdateGommetteInfo()
        Dim _row As DataRowView
        Dim _intFR As Integer = 0
        Dim _intNL As Integer = 0
        Dim _view As DataView
        _view = New DataView(objDS.products_to_languages, "", "", DataViewRowState.CurrentRows)
        For Each _row In _view
            If _row("products_languages_id") = 1 Then _intFR += 1
            If _row("products_languages_id") = 2 Then _intNL += 1
        Next
        _view = New DataView(objDS.products_to_undertitles, "", "", DataViewRowState.CurrentRows)
        For Each _row In _view
            If _row("products_undertitles_id") = 1 Then _intFR += 1
            If _row("products_undertitles_id") = 2 Then _intNL += 1
        Next
        If _intFR > 0 Then
            objDS.products.Rows(0)("products_language_fr") = 1
        Else
            objDS.products.Rows(0)("products_language_fr") = 0
        End If

        If _intNL > 0 Then
            objDS.products.Rows(0)("products_undertitle_nl") = 1
        Else
            objDS.products.Rows(0)("products_undertitle_nl") = 0
        End If
    End Sub
    Public Sub LoadProductsInfo()
        ' boolLoadingDVDInfo = True

        ClearData()
        'MainData = New clsProduct_VODSerie(SessionInfo, objDS, CurrentProductID)
        MainData.initObject(objDS)
        'objDS.orders_status_history.Clear()
        'objDS.orders_products_view1.Clear()
        If txtQuickSearch.EditValue <> CurrentProductID.ToString() Then
            txtQuickSearch.EditValue = CurrentProductID
        End If
        InitRefeshTab()

        RefreshTab(XTabControlProduct.SelectedTabPage)
        ' MainData.LoadProductsDetail()
        MainData.LoadActors()
        MainData.LoadTrailers()
        MainData.LoadSoundtracks()
        loadTheme()
        MainData.LoadVod()
        'MainData.LoadLanguages()
        'MainData.LoadUndertitles()
        'MainData.LoadTrailers()
        'MainData.LoadSoundtracks()
        'MainData.LoadDescriptionFR()
        'MainData.LoadDescriptionNL()
        'MainData.LoadDescriptionEN()
        ' MainData.Load_All_Products_DVD_Info()
        RefreshSmallPicture()
        'RefreshPictureFR()
        'RefreshPictureNL()
        'RefreshPictureEN()
        'RefreshCategoryTree()
        'RefreshThemeTree()
        ''  boolLoadingDVDInfo = False
        'RefreshCategoryTree()

        '  loadPrevision(CurrentProductID)
        '  loadWishlistCustomers(CurrentProductID)

    End Sub

    Public Sub LoadProductsInfo(ByVal products_id As Integer)
        ' boolLoadingDVDInfo = True

        'ClearData()
        'MainData = New clsProduct_VODSerie(SessionInfo, objDS, products_id)
        MainData.initObject(objDS, products_id)
        'objDS.orders_status_history.Clear()
        'objDS.orders_products_view1.Clear()
        If txtQuickSearch.EditValue <> products_id.ToString() Then
            txtQuickSearch.EditValue = products_id
        End If
        InitRefeshTab()

        RefreshTab(XTabControlProduct.SelectedTabPage)
        ' MainData.LoadProductsDetail()
        MainData.LoadActors()
        MainData.LoadTrailers()
        MainData.LoadSoundtracks()
        loadTheme()
        MainData.LoadVod()
        'MainData.LoadLanguages()
        'MainData.LoadUndertitles()
        'MainData.LoadTrailers()
        'MainData.LoadSoundtracks()
        'MainData.LoadDescriptionFR()
        'MainData.LoadDescriptionNL()
        'MainData.LoadDescriptionEN()
        ' MainData.Load_All_Products_DVD_Info()
        RefreshSmallPicture()
        'RefreshPictureFR()
        'RefreshPictureNL()
        'RefreshPictureEN()
        'RefreshCategoryTree()
        'RefreshThemeTree()
        ''  boolLoadingDVDInfo = False
        'RefreshCategoryTree()

        '  loadPrevision(CurrentProductID)
        '  loadWishlistCustomers(CurrentProductID)

    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields
        txtModel.Enabled = Enabling
        txtTitle.Enabled = Enabling
        'txtQty.Enabled = Enabling
        'txtQtyNow.Enabled = Enabling
        'txtDateAdded.Enabled = Enabling
        txtDateAvailable.Enabled = Enabling
        cmbProducts_Media.Enabled = Enabling
        cmbProducts_Status.Enabled = Enabling
        cmbProducts_Type.Enabled = Enabling
        txtYear.Enabled = Enabling
        txtRunTime.Enabled = Enabling
        cmbcountry.Enabled = Enabling
        cmbStudio.Enabled = Enabling
        cmbDirector.Enabled = Enabling
        cmbAvailability.Enabled = Enabling
        cmbRating.Enabled = Enabling
        cmbPictureFormat.Enabled = Enabling
        cmbPublic.Enabled = Enabling
        txtPictureImage.Enabled = Enabling
        txtOtherProductID.Enabled = Enabling
        txtIMDB_ID.Enabled = Enabling
        txtImdb_id_serie.Enabled = Enabling
        txtSeason.Enabled = Enabling
        txtEpisodesNumber.Enabled = Enabling
        cmbVODSerieID.Enabled = Enabling

        'PictProducts_Image.Enabled = Enabling
        cmbSerie.Enabled = Enabling
        cmbVODSerie.Enabled = Enabling
        txtSerieNbr.Enabled = Enabling
        cmbABOSerie.Enabled = Enabling
        txtABOSerieNbr.Enabled = Enabling
        GridViewActors.OptionsBehavior.Editable = Enabling
        GridActors.EmbeddedNavigator.Enabled = Enabling
        GridViewLanguages.OptionsBehavior.Editable = Enabling
        GridLanguages.EmbeddedNavigator.Enabled = Enabling
        GridViewUndertitles.OptionsBehavior.Editable = Enabling
        GridUndertitles.EmbeddedNavigator.Enabled = Enabling
        GridViewTrailers.OptionsBehavior.Editable = Enabling
        GridTrailers.EmbeddedNavigator.Enabled = Enabling
        GridViewSoundTracks.OptionsBehavior.Editable = Enabling
        GridSoundtracks.EmbeddedNavigator.Enabled = Enabling
        'Desc FR
        Dim indexFR As Integer = 1
        For i As Integer = 23 To 0 Step -1
            Panel4.Controls(i).Controls("txtNameFR" & indexFR).Enabled = Enabling
            Panel4.Controls(i).Controls("txtDescFR" & indexFR).Enabled = Enabling
            '
            Panel6.Controls(i).Controls("txtNameNL" & indexFR).Enabled = Enabling
            Panel6.Controls(i).Controls("txtDescNL" & indexFR).Enabled = Enabling
            '
            Panel8.Controls(i).Controls("txtNameEN" & indexFR).Enabled = Enabling
            Panel8.Controls(i).Controls("txtDescEN" & indexFR).Enabled = Enabling
            '
            indexFR = indexFR + 1
            'txtNameFR1.Enabled = Enabling
            'txtDescFR1.Enabled = Enabling
        Next
        txtURLFr.Enabled = Enabling
        txtImageFR.Enabled = Enabling
        txtAwardFR.Enabled = Enabling
        'Desc NL
        txtURLNl.Enabled = Enabling
        txtImageNL.Enabled = Enabling
        txtAwardNL.Enabled = Enabling
        'Desc EN
        txtURLEn.Enabled = Enabling
        txtImageEN.Enabled = Enabling
        txtAwardEN.Enabled = Enabling
        'FeeSharing
        'cmbMovieMaxPartner.Enabled = Enabling
        'txtTiteNrMovieMax.Enabled = Enabling
        'cmbMovieMaxPartner.Enabled = Enabling
        'cmbFeeSharingStudio.Enabled = Enabling

        'txtFeeSharing_End.Enabled = Enabling


        'txtFeeSharing_TurnPrice.Enabled = Enabling

        'txtFeeSharing_UpfrontFee.Enabled = Enabling

        chkInCinemaNow.Enabled = Enabling
        chkInTheBags.Enabled = Enabling
        chkInTheBagsNext.Enabled = Enabling
        chkProduct_Next.Enabled = Enabling
        chkVodNext.Enabled = Enabling
        chkVodNextLU.Enabled = Enabling
        chkVodNextNL.Enabled = Enabling
        'Categories
        TreeListCategories.OptionsBehavior.Editable = Enabling
        TreeListThemes.OptionsBehavior.Editable = Enabling
        'Sale/Purchqse
        'txtPrice.Enabled = Enabling
        'txtQty_to_sale.Enabled = Enabling
        'txtSale_price.Enabled = Enabling
        'txtSaleDate.Enabled = Enabling
        'txtNew_qty_to_sale.Enabled = Enabling
        'txtNew_Sale_Price.Enabled = Enabling
        'chkOnly_for_sale.Enabled = Enabling
        cmbProducts_product_type.Enabled = Enabling
        chkGameOnline.Enabled = Enabling
        txtGame_ConfigMini.Enabled = Enabling
        txtGame_NbrOfPlayersOnline.Enabled = Enabling
        txtGame_NbrOfPlayers.Enabled = Enabling


    End Sub
    Private Sub EnablingKeyFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingkeyFields
        'ToBeChecked ***
    End Sub
    Private Sub StartPrintForm() Handles MyBase.EventPrintForm
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM generalentityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("EntityID")
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("generalentityView1").Clear()
            _Cls1.FillDataSet(objDS.Tables("generalentityView1"), _SQLTxt)
            If objDS.Tables("generalentityView1").Rows.Count = 1 Then
                BKReport.PrintForm(CurrentReportID, New DataRow() { _
                    objDS.Tables("generalentityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub
    Private Sub StartDesignReport() Handles MyBase.EventDesignReport
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            'Find EntityView1Row
            Dim _SQLTxt As String = "SELECT * FROM generalentityView1 WHERE EntityID = " & CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("EntityID")
            Dim _Cls1 As New BizzLib.clsDataSet(SessionInfo)
            objDS.Tables("generalentityView1").Clear()
            _Cls1.FillDataSet(objDS.Tables("generalentityView1"), _SQLTxt)
            If objDS.Tables("generalentityView1").Rows.Count = 1 Then
                BKReport.DesignReport(CurrentReportID, New DataRow() { _
                    objDS.Tables("generalentityView1").Rows(0), _
                    CType(Me.BindingContext(objDS, "GeneralAddress").Current, DataRowView).Row})
            End If
        End If
    End Sub

#Region "Search"
    Public Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 
        Search()
    End Sub
    Public Sub Search()
        Dim _SQLTxt As String
        Dim dt As DataTable
        Dim searchTitle As String = String.Empty
        Dim searchImdb As String = String.Empty
        Dim searchImdb_id_serie As String = String.Empty
        Dim searchProducts_id As String = String.Empty
        Dim productsMedia As String = String.Empty
        Dim director As String = String.Empty

        'If Not txtTitleSearch.EditValue Is Nothing AndAlso txtTitleSearch.EditValue <> "" Then
        '    searchTitle = " and products_name like '%" & txtTitleSearch.Text.Trim & "%'"
        'End If

        'If Not txtSearchImdb_id.EditValue Is Nothing AndAlso txtSearchImdb_id.EditValue <> "" Then
        '    searchImdb = " and imdb_id = " & txtSearchImdb_id.Text.Trim
        'End If

        'If Not txtSearchImdbId_serie.EditValue Is Nothing AndAlso txtSearchImdbId_serie.EditValue <> "" Then
        '    searchImdb_id_serie = " and imdb_id_serie = " & txtSearchImdbId_serie.Text.Trim
        'End If

        'If Not txtSearchProductID.EditValue Is Nothing AndAlso txtSearchProductID.EditValue <> "" Then
        '    searchProducts_id = " and P.products_id = " & txtSearchProductID.Text.Trim
        'End If

        'If Not txtProducts_Media.EditValue Is Nothing AndAlso txtProducts_Media.EditValue <> "" Then
        '    productsMedia = " and P.products_media = '" & txtProducts_Media.Text.Trim & "'"
        'End If

        'If Not txtDirectorSearch.EditValue Is Nothing AndAlso txtDirectorSearch.EditValue <> "" Then
        '    director = " and P.products_directors_id in (select directors_id from directors where directors_name like '%" & txtDirectorSearch.Text.Trim & "%' ) "
        'End If

        '_SQLTxt = "SELECT PD.products_id, P.imdb_id, P.season_id, P.episode_id,  PD.language_id, PD.products_name , P.products_model as products_model, P.products_media " & _
        '          " FROM products_description PD " & _
        '          " Left join products P on P.products_id = PD.products_id " & _
        '          " where season_id > 0 " & searchTitle & searchImdb & director & _
        '          " group by P.products_id "
        ' objDS.products_description1.Clear()
        ' DvdPostData.clsConnection.FillDataSet(objDS.products_description1, _SQLTxt)
        'dt = DvdPostData.clsConnection.FillDataSet(_SQLTxt)
        'GridProductsDVD.DataSource = dt

    End Sub
    Private Sub txtTitleSearch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) 
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    'Private Sub GridViewSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridViewSearch.DoubleClick
    '    CurrentProductID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("products_id")
    '    LoadProductsInfo()
    '    If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
    '        XTabControlProduct.SelectedTabPage = tabMain
    '    End If
    'End Sub

    Public Sub searchID(ByVal products_id As Integer)
        'txtQuickSearch.EditValue = products_id
        'CurrentProductID = products_id
        'LoadProductsInfo()
        'If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
        '    XTabControlProduct.SelectedTabPage = tabMain
        'End If
    End Sub
    Public Sub searchID()
        'Dim param As DVDPostBuziness.clsSingleton
        'param = DVDPostBuziness.clsSingleton.Instance()

        'If IsNumeric(txtQuickSearch.EditValue) Then
        '    CurrentProductID = txtQuickSearch.EditValue
        '    LoadProductsInfo()
        '    If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
        '        XTabControlProduct.SelectedTabPage = tabMain
        '    End If

        '    ' RefreshTab(XTabControlProduct.SelectedTabPage)
        'End If
    End Sub
    Public Overrides Sub btnQuickSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickSearch.ItemClick
        searchID()
    End Sub

#End Region


#Region "Event"

    Public Overloads Sub btnPrevious_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrevious.ItemClick
        CurrentProductID -= 1
        If CurrentProductID < 51 Then CurrentProductID = 51
        LoadProductsInfo()
    End Sub
    Public Overloads Sub btnNext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        CurrentProductID += 1
        LoadProductsInfo()
    End Sub
    Public Overloads Sub btnFirst_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirst.ItemClick
        CurrentProductID = 51
        LoadProductsInfo()
    End Sub
    Public Overloads Sub btnLast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLast.ItemClick
        CurrentProductID = BKGlobal.ExecuteFindFieldValueINT("products_id", "select products_id from products order by products_id desc limit 1")
        LoadProductsInfo()
    End Sub

    'Private Sub btnRemoveDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveDVD.Click
    '    Dim _ans As MsgBoxResult
    '    _ans = MsgBox("Are you sure you want to remove this DVD from Site and ALL WishList?", MsgBoxStyle.YesNo)
    '    If _ans = MsgBoxResult.Yes Then
    '        XTabControlProduct.Enabled = False
    '        MainData.RemoveDVDFromCatalogue()
    '        XTabControlProduct.Enabled = True
    '        MsgBox("Ce titre a été retiré de notre catalogue et de toutes les wishlist (avec envoi de e-mail aux clients)", MsgBoxStyle.Information)
    '    End If
    '    XTabControlProduct.Enabled = True
    'End Sub
    Private Sub btnDeleteFromliste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim _ans As MsgBoxResult
        '_ans = MsgBox("Are you sure you want to erase this DVD of liste?", MsgBoxStyle.YesNo)
        'Dim exist As Boolean = False
        'exist = BKGlobal.ExecuteExists("select * from products_dvd where products_id = " & txtProductID.Text.ToString)
        'If _ans = MsgBoxResult.Yes Then
        '    If exist = False Then
        '        DvdPostData.clsConnection.ExecuteNonQuery("delete from products where products_id = " & txtProductID.Text.ToString)
        '        MsgBox("done")
        '        Search()
        '        XTabControlProduct.SelectedTabPage = tabSearch
        '    Else
        '        MsgBox("you can't erase this products , if exist DVDs for this products")
        '    End If
        'End If
    End Sub
    Private Sub btnReCalcQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '   MainData.RecalcQty()
    End Sub
    Private Sub cmbStudio_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbStudio.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmStudioBrowseMaint_Browse(SessionInfo)
            _frm.Tag = 670 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadStudio()
        End If
    End Sub
    Private Sub cmbcountry_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbcountry.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmProdCountriesBrowseMaint_Browse(SessionInfo)
            _frm.Tag = 671 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadProductsCountries()
        End If
    End Sub
    Private Sub cmbDirector_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbDirector.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmDirectorsBrowseMaint(SessionInfo)
            _frm.Tag = 672 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadDirectors()
        End If
    End Sub
    Private Sub cmbSerie_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbSerie.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmSeriesBrowseMaint(SessionInfo)
            _frm.Tag = 673 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadSeries()
        End If
    End Sub
    Private Sub cmbABOSerie_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbABOSerie.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmSeriesBrowseMaint(SessionInfo)
            _frm.Tag = 673 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
        End If
    End Sub
    Private Sub btnActorsMaint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActorsMaint.Click
        Dim _frm As New frmActorsBrowseMaint(SessionInfo)
        _frm.Tag = 674 'MenuID if started with the MenuTree
        Try
            _frm.ShowDialog(Me)
            LoadActors()
            cmbActors.ForceInitialize()
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnLang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLang.Click
        Dim _frm As New frmProdLangBrowseMaint(SessionInfo)
        _frm.Tag = 675 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        LoadProductsLanguage()
    End Sub
    Private Sub btnSubTitles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubTitles.Click
        Dim _frm As New frmProdUnderTitlesBrowseMaint(SessionInfo)
        _frm.Tag = 676 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        loadProductsUndertitle()

    End Sub
    Private Sub btnSoundTracks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoundTracks.Click
        Dim _frm As New frmSoundtracksBrowseMaint(SessionInfo)
        _frm.Tag = 678 'MenuID if started with the MenuTree
        _frm.ShowDialog(Me)
        loadProductsSoundtracks()
    End Sub

    Private Sub TreeListThemes_NodesReloaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeListThemes.NodesReloaded
        TreeListThemes.ExpandAll()
    End Sub
    Private Sub TreeListthemes_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles TreeListThemes.CellValueChanging
        Dim _view As DataView
        Dim _row As DataRowView
        If e.Column.FieldName <> "themes_selected" Then Exit Sub
        If e.Value = 1 Then 'Putting to TRUE then put Also Parent to True
            e.Node("themes_selected") = e.Value
            If Not IsNothing(e.Node.ParentNode) Then
                e.Node.ParentNode("themes_selected") = e.Value
            End If
        Else 'Putting to False , then Put also Children To False
            e.Node("themes_selected") = e.Value
            Try
                _view = New DataView(objDS.themes_fr_view1, "parent_id = " & e.Node("themes_id"), "", DataViewRowState.CurrentRows)
                For Each _row In _view
                    _row("themes_selected") = e.Value
                Next

            Catch ex As Exception
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            End Try

        End If

    End Sub

    Private Sub txtModel_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtModel.Leave
        If txtModel.Enabled = False Then Exit Sub
        If objDS.products_description_fr.Rows.Count = 0 Then Return
        If txtImageFR.EditValue & "" = "" Then
            objDS.products_description_fr.Rows(0)("products_image_big") = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
        End If
        If txtImageNL.EditValue & "" = "" Then
            objDS.products_description_nl.Rows(0)("products_image_big") = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
        End If
        If txtImageEN.EditValue & "" = "" Then
            objDS.products_description_en.Rows(0)("products_image_big") = "dvd/" & txtModel.Text.ToLower & "bfr.jpg"
        End If
    End Sub
    Private Sub btnCategories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategories.Click
        MsgBox("Pas Encore fini", MsgBoxStyle.Exclamation)
    End Sub
    Private Sub btnThemes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThemes.Click
        MsgBox("Pas Encore fini", MsgBoxStyle.Exclamation)
    End Sub
    'Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
    '    If IsNothing(MainData) Or MainData.ProductsID = -1 Then Exit Sub
    '    Dim _answ As MsgBoxResult
    '    _answ = MsgBox("Do you really want to make a copy of this Product Info ?", MsgBoxStyle.YesNo)
    '    If _answ = MsgBoxResult.No Then Exit Sub
    '    Dim _newID As Integer
    '    _newID = MainData.CopyProduct()
    '    MsgBox("New Products ID is : " & _newID.ToString, MsgBoxStyle.Exclamation)
    'End Sub

    Private Sub GridViewProducts_DVD_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        'If GridViewProducts_DVD.IsValidRowHandle(GridViewProducts_DVD.FocusedRowHandle) Then
        '    CurrentDVDID = GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvdid")
        '    LoadOrdersData(CurrentDVDID)
        '    LoadProductsDVDStatusHistory(CurrentDVDID)
        'End If
    End Sub
    Private Sub chkLoadAllOrders_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If chkLoadAllOrders.Checked = True Then
        '    LoadOrdersData(-1)
        'Else
        '    If GridViewProducts_DVD.IsValidRowHandle(GridViewProducts_DVD.FocusedRowHandle) Then
        '        CurrentDVDID = GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvdid")
        '        LoadOrdersData(CurrentDVDID)
        '    End If
        'End If
    End Sub

    Private Sub TreeListCategories_NodesReloaded(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TreeListCategories.NodesReloaded
        TreeListCategories.ExpandAll()
    End Sub
    Private Sub TreeListCategories_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CellValueChangedEventArgs) Handles TreeListCategories.CellValueChanging
        Dim _view As DataView
        Dim _row As DataRowView
        If e.Column.FieldName <> "category_selected" Then Exit Sub
        If e.Value = 1 Then 'Putting to TRUE then put Also Parent to True
            e.Node("category_selected") = e.Value
            If Not IsNothing(e.Node.ParentNode) Then
                e.Node.ParentNode("category_selected") = e.Value
            End If
        Else 'Putting to False , then Put also Children To False
            e.Node("category_selected") = e.Value
            Try
                _view = New DataView(objDS.categories_fr_view1, "parent_id = " & e.Node("categories_id"), "", DataViewRowState.CurrentRows)
                For Each _row In _view
                    _row("category_selected") = e.Value
                Next

            Catch ex As Exception
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
            End Try

        End If

    End Sub

    Private Sub GridVIewOrders_History_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        'Dim _SQLTxt As String
        'If GridVIewOrders_History.IsValidRowHandle(GridVIewOrders_History.FocusedRowHandle) Then
        '    CurrentOrderID = GridVIewOrders_History.GetDataRow(GridVIewOrders_History.FocusedRowHandle)("orders_id")
        'Else
        '    CurrentOrderID = -1
        'End If
        'objDS.orders_status_history.Clear()
        'If CurrentOrderID <> -1 Then
        '    _SQLTxt = "select * " & _
        '              " from orders_status_history " & _
        '              " where orders_id = " & CurrentOrderID & _
        '              " ORDER BY orders_status_history_id desc "
        '    DvdPostData.clsConnection.FillDataSet(objDS.orders_status_history, _SQLTxt)
        'End If
    End Sub

    Private Sub btnAddNewDVDs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MsgBox("Not Yet!", MsgBoxStyle.Information)
        'Dim msg As MsgBoxResult
        'msg = MsgBox("Do you want add " & txtNbrOfDVDToAdd.Value & "  Dvd ? ", MsgBoxStyle.YesNo)

        'If msg = MsgBoxResult.Yes Then
        '    If CurrentProductID <= 0 Then
        '        MsgBox("Choisir un Product.", MsgBoxStyle.Exclamation)
        '        Exit Sub
        '    End If
        '    If txtNbrOfDVDToAdd.Value <= 0 Then
        '        MsgBox("Choisir une quantité a ajouter.", MsgBoxStyle.Exclamation)
        '        Exit Sub
        '    End If
        '    If IsNothing(MainData) Then
        '        MsgBox("Choisir un Product.", MsgBoxStyle.Exclamation)
        '        Exit Sub
        '    End If

        '    MainData.AddNewDVD(txtNbrOfDVDToAdd.Value)

        '    LoadProductsInfo()

        'End If
    End Sub
    Private Sub btnTransferProductID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If CurrentProductID = -1 Then
        '    MsgBox("Please select a Product first", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        'If Not IsNumeric(txtToProdID1.EditValue) Then
        '    MsgBox("Please select a TO Product ID.", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        'Dim sSQL2 As String = "SELECT w.wl_id, w.customers_id, w.product_id, c.customers_language from wishlist w,  customers c where w.customers_id = c.customers_id and c.customers_language  = '" & txtCustLang1.EditValue & "' and w.product_id = '" & txtFromProdID1.EditValue & "' "
        'Dim _DS As New DataSet
        '_DS.Tables.Add("TmpTable")
        'DvdPostData.clsConnection.FillDataSet(_DS.Tables("TmpTable"), sSQL2)
        'Dim _row As DataRow
        'Dim i, j As Integer
        'Dim ssql3 As String = ""
        'Dim _Exist As Boolean = False
        ''txtWLToProcess.EditValue = _DS.Tables("TmpTable").Rows.Count
        'DoEvents()
        'For Each _row In _DS.Tables("TmpTable").Rows
        '    'txtWLToProcess.EditValue -= 1
        '    DoEvents()
        '    _Exist = BKGlobal.ExecuteExists("select count(*) as cnt from wishlist w " & _
        '           " where product_id = " & txtToProdID1.EditValue & " and w.customers_id = " & _row("customers_id"))
        '    Try
        '        If _Exist Then
        '            ssql3 = "delete from  wishlist where wl_id   = '" & _row("wl_id") & "' and product_id = '" & txtFromProdID1.EditValue & "'  "
        '            DvdPostData.clsConnection.ExecuteNonQuery(ssql3)
        '            j = j + 1
        '        Else
        '            ssql3 = "update wishlist  set product_id = '" & txtToProdID1.EditValue & "' where wl_id   = '" & _row("wl_id") & "' and product_id = '" & txtFromProdID1.EditValue & "'  "
        '            DvdPostData.clsConnection.ExecuteNonQuery(ssql3)
        '            i = i + 1
        '        End If
        '    Catch ex As Exception
        '        DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Stock, ex)
        '    End Try
        'Next
        'MsgBox(i & " entries Done; " & j & " deleted because bouble ", MsgBoxStyle.Exclamation)
    End Sub


    Private Sub ButDelPrDvdId_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''delete dvd in dvdmaintenance on DVDS

        'If Me.GridViewProducts_DVD.RowCount = 0 Then
        '    MsgBox("Select a products_dvdid.", MsgBoxStyle.Exclamation)
        '    Exit Sub
        'End If
        'Dim prdvd_id As String = Me.GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvdid").ToString
        'Dim _ans As MsgBoxResult
        '_ans = MsgBox("products: " + Me.CurrentProductID.ToString + "    products_dvdid: " + prdvd_id, MsgBoxStyle.YesNo)

        'Dim _SQLTxt As String
        'objDS.orders_products_view1.Clear()

        '_SQLTxt = "select op.orders_id, o.customers_id, op.products_id, op.products_dvd as dvd_id, o.delivery_country, o.delivery_name, o.customers_email_address, " & _
        '                       " op.pick_group, op.pick_boxid, o.date_purchased, op.orders_products_status " & _
        '                               " from orders_products op left join orders o on o.orders_id = op.orders_id " & _
        '                                " where op.products_dvd = '" & prdvd_id & " 'and op.products_id = " & CurrentProductID & _
        '                                " ORDER BY op.orders_id desc "
        'DvdPostData.clsConnection.FillDataSet(objDS.orders_products_view1, _SQLTxt)



        'If _ans = MsgBoxResult.Yes And objDS.orders_products_view1.Rows.Count = 0 Then
        '    'delete de dvd de la table products_dvd + update de la quantite de dvd  nbrDvd-1
        '    DvdPostData.clsConnection.ExecuteNonQuery("delete from products_dvd where products_id = " & Me.CurrentProductID.ToString & _
        '                                 " and products_dvdid = '" & prdvd_id & "' ")
        '    'DvdPostData.clsConnection.ExecuteNonQuery("update products set products_dvd_quantity = products_dvd_quantity -1 ,products_quantity = products_quantity -1 " & _
        '    '                             "where products_id = '" & CurrentProductID.ToString & "'  ")

        '    'Me.GridViewProducts_DVD.DeleteSelectedRows()
        '    MsgBox("ok")
        '    Exit Sub


        'ElseIf _ans = MsgBoxResult.No Then
        '    Exit Sub
        'Else
        '    MsgBox("You cannot remove this DVD of the list")
        'End If




    End Sub
    Private Sub Purchase_click(ByVal sender As Object, ByVal e As System.EventArgs)
        _ctrlGridControl.GridPurchase_click()
    End Sub


    Private Sub RefreshTab(ByVal tabCurrent As DevExpress.XtraTab.XtraTabPage)
        'If tabCurrent Is tabPrevision Then
        '    loadPrevision(CurrentProductID)
        'ElseIf tabCurrent Is tabFeeSharing Then
        '    loadFeeSharing()
        'ElseIf tabCurrent Is tabWishlistCustomers Then
        '    loadWishlistCustomers(CurrentProductID)
        If tabCurrent Is tabFR Then
            LoadFR()
        ElseIf tabCurrent Is tabNL Then
            LoadNL()
        ElseIf tabCurrent Is tabEN Then
            LoadEN()
            'ElseIf tabCurrent Is tabDVDs Then
            '    loadDVD()
        ElseIf tabCurrent Is tabLanguages Then
            loadLanguages()
        ElseIf tabCurrent Is tabTheme Then
            loadTheme()
        ElseIf tabCurrent Is tabTrailers Then
            loadTrailer()
        ElseIf tabCurrent Is tabCritiques Then
            loadCritique(CurrentProductID)
        ElseIf tabCurrent Is tabGames Then
            'ElseIf tabCurrent Is tabTransfers Then
        ElseIf tabCurrent Is tabVodWishlist Then
            loadVodWishlist(CurrentProductID)
        End If
    End Sub
    Private Sub XTabControlProduct_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTabControlProduct.SelectedPageChanged

        RefreshTab(XTabControlProduct.SelectedTabPage)
    End Sub

    Private Sub cmbFeeSharingStudio_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.UNIVERSAL_GLOBAL_DATA Then
        '    txtFeeSharing_UpfrontFee.EditValue = DvdPostData.clsFeeSharing.UPFRONTFEE_VALUE_UNIVERSAL_GLOBAL_DATA
        '    txtFeeSharing_TurnPrice.EditValue = DvdPostData.clsFeeSharing.TURN_PRICE

        'ElseIf cmbFeeSharingStudio.EditValue = DvdPostData.clsFeeSharing.feeSharingStudio.MOVIEMAX Then
        '    txtFeeSharing_UpfrontFee.EditValue = DvdPostData.clsFeeSharing.UPFRONTFEE_VALUE_MOVIEMAX
        '    txtFeeSharing_TurnPrice.EditValue = DvdPostData.clsFeeSharing.TURN_PRICE

        '    LoadMovieMaxInfo()
        'End If


    End Sub

    Private Sub GridWishlistCustomers_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If gridViewWishlistCustomers.RowCount <> 0 Then
        '    Dim customers_id As String = gridViewWishlistCustomers.GetDataRow(gridViewWishlistCustomers.FocusedRowHandle)("customers_id")
        '    Dim frm As frmCustomers_Maint
        '    frm = ClsCustomers.openFrmCustMaint(customers_id, Me.ParentForm, SessionInfo)
        '    frm.XTabCustomers.SelectedTabPage = frm.tabWishList
        'End If
    End Sub

#End Region

#Region "Images"
    Private Sub txtPictureImage_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPictureImage.EditValueChanged
        RefreshSmallPicture()
    End Sub
    Private Sub txtImageFR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageFR.EditValueChanged
        RefreshPictureFR()
    End Sub
    Private Sub txtImageNL_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageNL.EditValueChanged
        RefreshPictureNL()
    End Sub
    Private Sub txtImageEN_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageEN.EditValueChanged
        RefreshPictureEN()
    End Sub
    Private Sub RefreshPicture(ByVal CtrlnamePicture As DevExpress.XtraEditors.TextEdit, ByVal ctrlImg As DevExpress.XtraEditors.PictureEdit)

        If CtrlnamePicture Is Nothing Then Return
        ctrlImg.Image = Nothing
        Dim pathserver As String
        If CtrlnamePicture.EditValue & "" <> "" Then
            If MainData.productsType & "" = "DVD_NORM" Then
                pathserver = DVDPostBuziness.clsPicture.getPathServer(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM)
            Else
                pathserver = DVDPostBuziness.clsPicture.getPathServer(DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT)
            End If
            pathserver = pathserver & CtrlnamePicture.EditValue

            If System.IO.File.Exists(pathserver) Then
                ctrlImg.Image = System.Drawing.Image.FromFile(pathserver)
            End If

        End If
    End Sub
    Private Sub LoadPictureTrailer(ByVal CtrlnamePicture As String, ByVal ctrlImg As DevExpress.XtraEditors.PictureEdit)

        If CtrlnamePicture Is Nothing Then Return
        ctrlImg.Image = Nothing
        Dim pathserver As String
        If CtrlnamePicture & "" <> "" Then
            If MainData.productsType & "" = "DVD_NORM" Then
                pathserver = DVDPostBuziness.clsPicture.getPathServer(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM)
            Else
                pathserver = DVDPostBuziness.clsPicture.getPathServer(DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT)
            End If
            pathserver = pathserver & CtrlnamePicture

            If System.IO.File.Exists(pathserver) Then
                ctrlImg.Image = System.Drawing.Image.FromFile(pathserver)
            End If

        End If
    End Sub
    Private Sub RefreshSmallPicture()
        RefreshPicture(txtPictureImage, PictProducts_Image)
    End Sub
    Private Sub RefreshPictureFR()
        RefreshPicture(txtImageFR, pictFR)
    End Sub
    Private Sub RefreshPictureNL()
        RefreshPicture(txtImageNL, pictNL)

    End Sub
    Private Sub RefreshPictureEN()
        RefreshPicture(txtImageEN, pictEN)
    End Sub
    Private Sub RefreshPictureTrailer()
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_1.jpg", imgIMDBID_1)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_2.jpg", imgIMDBID_2)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_3.jpg", imgIMDBID_3)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_4.jpg", imgIMDBID_4)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_5.jpg", imgIMDBID_5)
        LoadPictureTrailer("screenshots\small\" & txtIMDB_ID.Text & "_6.jpg", imgIMDBID_6)
    End Sub
#End Region


    Private Sub RefreshCategoryTree()
        ' If boolLoadingDVDInfo Then Exit Sub
        Dim _ID As Integer
        Dim _product_type As String 'Movie; Game
        Dim _products_type As String 'DVD_NORM, DVD_Adult
        Dim _DS As New dsProducts
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            _ID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
            _products_type = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)("products_type")
            _product_type = cmbProducts_product_type.EditValue & ""
            '_products_type = cmbProducts_Type.EditValue & ""
            If _product_type & "" = "" Then _product_type = "Movie"
            If _products_type & "" = "" Then _products_type = "DVD_NORM"
            If IsDBNull(_ID) Then Exit Sub
            objDS.categories_fr_view1.Clear()
            Dim _category_sql As String = "select c.categories_id, parent_id, categories_type, cdesc.categories_name from categories c" & _
                 " left join categories_description cdesc on cdesc.categories_id = c.categories_id and cdesc.language_id = 1 " & _
                 " WHERE categories_type = '" & _products_type & "' and product_type = '" & _product_type & "'"
            DvdPostData.clsConnection.FillDataSet(objDS.categories_fr_view1, _category_sql)
            DvdPostData.clsConnection.FillDataSet(_DS.products_to_categories, "SELECT * from products_to_categories where products_id = " & MainData.ProductsID)
            Dim _row As DataRow
            For Each _row In objDS.categories_fr_view1.Rows
                If IsNothing(_DS.products_to_categories.Rows.Find(New Object() {MainData.ProductsID, _row("categories_id")})) Then
                    _row("category_selected") = 0
                Else
                    _row("category_selected") = 1
                End If

            Next
        End If
    End Sub


    Private Sub RefreshThemeTree()
        Dim _ID As Integer
        Dim _DS As New dsProducts
        If Me.BindingContext(objDS, TableName).Position >= 0 Then
            _ID = CType(Me.BindingContext(objDS, TableName).Current, DataRowView)(IDField)
            If IsDBNull(_ID) Then Exit Sub
            objDS.themes_fr_view1.Clear()
            Dim _theme_sql As String = "select t.themes_id, parent_id, themes_type, tdesc.themes_name from themes t " & _
                 " left join themes_description tdesc on tdesc.themes_id = t.themes_id and tdesc.language_id = 1 " & _
                 " WHERE themes_type = '" & MainData.productsType & "' "
            Cls1.FillDataSet(objDS.themes_fr_view1, _theme_sql)
            Cls1.FillDataSet(_DS.products_to_themes, "SELECT * from products_to_themes where products_id = " & MainData.ProductsID)
            Dim _row As DataRow
            For Each _row In objDS.themes_fr_view1.Rows
                If IsNothing(_DS.products_to_themes.Rows.Find(New Object() {MainData.ProductsID, _row("themes_id")})) Then
                    _row("themes_selected") = 0
                Else
                    _row("themes_selected") = 1
                End If

            Next
        End If
    End Sub


    'Private Sub initCheckProcess()
    '    _CheckProcess = New ClsCheckProcessLogistic()
    '    _CheckProcess.txtInfo = txtINFO
    '    _CheckProcess.sessionInfo = SessionInfo
    '    _CheckProcess.objDS = objDS
    '    _CheckProcess.txtbarcode = txtBarCode
    '    _CheckProcess.btnUnlock = btnUnlock
    '    objDS.EnforceConstraints = False
    'End Sub


    Private Sub btnOK1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If txtBarCode.Text = "" Then
        '    btnSearch_Click(Nothing, Nothing)
        '    Return
        'End If

        'Dim objProductDVD As clsProduct_VODSerie

        'objProductDVD = _CheckProcess.GetCodeBar(txtBarCode.Text)
        'If objProductDVD Is Nothing Then Return

        'txtQuickSearch.EditValue = objProductDVD.ProductsID
        'searchID()
        'XTabControlProduct.SelectedTabPage = tabDVDs
        'GridViewProducts_DVD.SelectRow(objProductDVD.DvdId - 1)
        'GridViewProducts_DVD.FocusedRowHandle = objProductDVD.DvdId - 1

    End Sub


    Private Sub btnFindBarCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        _CheckProcess.GenereBarCode()
    End Sub

    Private Sub RepositoryIProductProducts_id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 

        'CurrentProductID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("products_id")
        'LoadProductsInfo()
        'If XTabControlProduct.SelectedTabPage.Name = tabSearch.Name Then
        '    XTabControlProduct.SelectedTabPage = tabMain
        'End If
    End Sub

    Private Sub GridViewCritiques_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewCritiques.DoubleClick
        Dim _frm As New frmReviewsMaint(SessionInfo)
        Dim _Review_ID As Integer
        Dim _i As Integer = GridViewCritiques.FocusedRowHandle
        _Review_ID = GridViewCritiques.GetDataRow(_i)("reviews_id")
        _frm.txtReviewID.EditValue = _Review_ID
        _frm.SearchReviewInfo()
        _frm.ShowDialog(Me)
    End Sub

    Private Sub RepositoryIbtnChangeStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim orders_id As Integer
        'Dim order_status As Integer
        'Dim products_status As Integer
        'Dim sql As String

        'order_status = GridVIewOrders_History.GetDataRow(GridVIewOrders_History.FocusedRowHandle)("orders_status")
        'orders_id = GridVIewOrders_History.GetDataRow(GridVIewOrders_History.FocusedRowHandle)("orders_id")

        'If order_status = DvdPostData.clsOdersStatusHistory.OrderStatusNew.CHECK Then
        '    products_status = GridViewProducts_DVD.GetDataRow(GridViewProducts_DVD.FocusedRowHandle)("products_dvd_status")
        '    If products_status = DvdPostData.clsProductDvd.DVDStatus.DVD_STATUS_OK Then
        '        DVDPostBuziness.clsOrders.UpdateOrder(orders_id, DvdPostData.clsOdersStatusHistory.OrderStatusNew.COMPLAINT_INADMISSIBLE, order_status)
        '        MsgBox("DVD Lisible no accepted")
        '    Else
        '        DVDPostBuziness.clsOrders.UpdateOrder(orders_id, DvdPostData.clsOdersStatusHistory.OrderStatusNew.RETURNED, order_status)
        '        MsgBox("DVD Illisible", MsgBoxStyle.Critical)
        '    End If

        '    LoadOrdersData(CurrentDVDID)
        'End If
    End Sub

    Private Sub ButtonWatchTrailer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWatchTrailer.Click, GridTrailers.DoubleClick
        Dim WebTrailer As System.Windows.Forms.WebBrowser = New System.Windows.Forms.WebBrowser()
        Dim frmShowTrailer As System.Windows.Forms.Form = New System.Windows.Forms.Form()
        Dim strDocumentText As String = String.Empty
        Dim strTrailerRemoteID As String
        Dim strBroadcast As String = String.Empty

        If GridViewTrailers.FocusedRowHandle > -1 Then
            strTrailerRemoteID = GridViewTrailers.GetDataRow(GridViewTrailers.FocusedRowHandle)("trailer")
            strBroadcast = GridViewTrailers.GetDataRow(GridViewTrailers.FocusedRowHandle)("broadcast")
        End If
        If strBroadcast = "DAYLYMOTION" Then
            strDocumentText = String.Format("<object width=""480"" height=""285""><param name=""movie"" value=""http://www.dailymotion.com/swf/video/{0}_space-symphony-maetel-bande-annonce_creation""></param><param name=""allowFullScreen"" value=""true""></param><param name=""allowScriptAccess"" value=""always""></param><embed type=""application/x-shockwave-flash"" src=""http://www.dailymotion.com/swf/video/{0}_space-symphony-maetel-bande-annonce_creation"" width=""480"" height=""285"" allowfullscreen=""true"" allowscriptaccess=""always""></embed></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 550
            frmShowTrailer.Height = 330
        ElseIf strBroadcast = "YOUTUBE" Then
            strDocumentText = String.Format("<object width=""640"" height=""385""><param name=""movie"" value=""http://www.youtube.com/v/{0}&hl=en_US&fs=1?rel=0""></param><param name=""allowFullScreen"" value=""true""></param><param name=""allowscriptaccess"" value=""always""></param><embed src=""http://www.youtube.com/v/{0}&hl=en_US&;fs=1?rel=0"" type=""application/x-shockwave-flash"" allowscriptaccess=""always"" allowfullscreen=""true"" width=""640"" height=""385""></embed></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 700
            frmShowTrailer.Height = 440
        ElseIf strBroadcast = "CINEMOVIES" Then
            strDocumentText = String.Format("<html><body><embed height=""458"" width=""610"" allowscriptaccess=""always"" allowfullscreen=""true"" flashvars=""{0}"" src=""http://www.cinemovies.fr/player/export/CineMovies2.swf""></embed></html></body>", strTrailerRemoteID)
            '          strDocumentText = String.Format("<object id=""ply"" width=""610"" height=""458"" type=""application/x-shockwave-flash"" data=""http://www.cinemovies.fr/player/export/CineMovies2.swf""> " & _
            '"" <param name=""wmode"" value=""transparent""> " & _
            '"" <param name=""allowfullscreen"" value=""true""> " & _
            '"" <param name=""allowscriptaccess"" value=""always""> " & _
            '"" <param name=""flashvars"" value=""{0}""></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 700
            frmShowTrailer.Height = 530
        ElseIf strBroadcast = "ALLOCINE" Then
            strDocumentText = String.Format("<object type=""application/x-shockwave-flash"" id=""V6_player"" data=""http://images.allocine.fr/commons/player/AcV3/AcPlayer_v3.0.swf"" width=""760px"" height=""464px"" style=""visibility: visible; display: block; "" > " & _
                              " <param name=""menu"" value=""false""/> " & _
                              " <param name=""wmode"" value=""window""/> " & _
                              " <param name=""scale"" value=""noScale""/>" & _
                              " <param name=""allowFullscreen"" value=""true""/> " & _
                              " <param name=""allowScriptAccess"" value=""always""/> " & _
                              " <param name=""bgcolor"" value=""#000000""/> " & _
                              " <param name=""flashvars"" value=""{0}""/></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 770
            frmShowTrailer.Height = 470
        ElseIf strBroadcast = "AAMREVIEWS" Then
            strDocumentText = String.Format("<object type=""application/x-shockwave-flash"" width=""450"" height=""300""wmode=""transparent"" data=""http://www.aamreviews.com/flvplayer.swf?file=http://www.aamreviews.com/flvideo/{0}&autostart=true&showfsbutton=true""> " & _
                                           "   <param name=""movie"" value=""http://www.aamreviews.com/flvplayer.swf?file=http://www.aamreviews.com/flvideo/3372.flv&autostart=true&showfsbutton=true"" /> " & _
                                           "  <param name=""wmode"" value=""transparent"" /> " & _
                                           " <param name=""allowScriptAccess"" value=""sameDomain"" /> " & _
                                           " <embed src=""http://www.aamreviews.com/flvplayer.swf?file=http://www.aamreviews.com/flvideo/<%= trailer.remote_id %>&autostart=true&showfsbutton=true"" loop=""False"" width=""330"" height=""220"" allowscriptaccess=""sameDomain"" type=""application/x-shockwave-flash"" pluginspage=""http://www.macromedia.com/go/getflashplayer"" /></embed></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 500
            frmShowTrailer.Height = 350
        ElseIf strBroadcast = "DORCELVISION" Then
            strDocumentText = String.Format("<object codebase=""http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=,0,0,0"" id=""AnimationFlash"" width=""330"" height=""220"" classid=""clsid:d27cdb6e-ae6d-11cf-96b8-444553540000""> " & _
                                             " <param name=""allowScriptAccess"" value=""always""/>  " & _
                                             " <param name=""movie"" value=""{0}""/>  " & _
                                             "  <param name=""swLiveConnect"" value=""TRUE""/> " & _
                                             " <param name=""quality"" value=""high""/> " & _
                                             "<param name=""bgcolor"" value=""""/> " & _
                                             " <param name=""wmode"" value=""opaque""/> " & _
                                             " <embed id=""AnimationFlash"" allowscriptaccess=""always"" width=""330"" height=""220"" src=""{0}"" swliveconnect=""TRUE"" quality=""high"" pluginspage=""http://www.macromedia.com/shockwave/download/index.cgi?P1_Prod_Version=ShockwaveFlash"" bgcolor="""" wmode=""opaque"" type=""application/x-shockwave-flash""/></object>", strTrailerRemoteID)
            frmShowTrailer.Width = 300
            frmShowTrailer.Height = 400
        ElseIf strBroadcast = "FILM1" Or strBroadcast = "COMMEAUCINEMA" Or strBroadcast = "CINENEWS.BE" Or strBroadcast = "TRUVEO" Then
            strDocumentText = "<object width=""640"" height=""385"" type=""application/x-shockwave-flash"" data=""http://releases.flowplayer.org/swf/flowplayer-3.2.7.swf"" name=""player_api"" id=""player_api""><param value=""true"" name=""allowfullscreen""><param value=""always"" name=""allowscriptaccess""><param value=""high"" name=""quality""><param value=""#000000"" name=""bgcolor""><param value=""config={""plugins"":{""content"":{""url"":""flowplayer.content-3.2.0.swf"",""height"":220,""padding"":30,""backgroundColor"":""#112233"",""opacity"":0.0,""backgroundGradient"":[0.1,0.1,1],""html"":"""",""style"":{""p"":{""fontSize"":40}}},""controls"":{""url"":""flowplayer.controls-tube-3.2.5.swf""}},""playerId"":""player"",""clip"":{""url"":"
            strDocumentText = strDocumentText & strTrailerRemoteID & ",""playlist"":[{""url"":" & strTrailerRemoteID & "}]} name=""flashvars""> </object>"

            frmShowTrailer.Width = 700
            frmShowTrailer.Height = 550
        End If

        WebTrailer.DocumentText = strDocumentText
        WebTrailer.Dock = DockStyle.Fill

        frmShowTrailer.Controls.Add(WebTrailer)
        Try
            frmShowTrailer.ShowDialog(Me)
        Catch ex As Exception

        End Try

        WebTrailer.Stop()
        WebTrailer.Dispose()
        WebTrailer = Nothing
        frmShowTrailer.Dispose()
        frmShowTrailer = Nothing
    End Sub

    Private Sub txtImageFR_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageFR.Leave
        ValidateImagePath(sender)
    End Sub

    Private Sub ValidateImagePath(ByVal sender As System.Object)
        If CType(sender, DevExpress.XtraEditors.TextEdit).Text.Contains(" ") Then
            MessageBox.Show("Image name can not contain spaces !")
            CType(sender, DevExpress.XtraEditors.TextEdit).Focus()
        End If

    End Sub

    Private Sub txtImageNL_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageNL.Leave
        ValidateImagePath(sender)
    End Sub

    Private Sub txtImageEN_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImageEN.Leave
        ValidateImagePath(sender)
    End Sub

    Private Sub btnMoveToPlush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sqlCall As String = "call spProductToPlush({0})"
        'Dim sqlVODExists As String = "select count(*) from stremaing_products where imdb_id = txtIMDB_ID.EditValue and status <> deleted "
        'Dim vodExists As Integer = DvdPostData.clsConnection.ExecuteScalar(sqlVODExists, DvdPostData.clsConnection.typeAccessDb.READ)
        'If vodExists = 0 Then
        '    MsgBox("This movie is not available in OVD")
        '    Return
        'End If

        sqlCall = String.Format(sqlCall, txtIMDB_ID.EditValue)
        Try
            DvdPostData.clsConnection.ExecuteNonQuery(sqlCall)
            MsgBox("Movie transfered to Plush", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Movie not transfered to Plsuh")
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.BO, ex)
        End Try

    End Sub

    Private Sub cmbVODSerie_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmSeriesBrowseMaint(SessionInfo)
            _frm.Tag = 673 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadSeries()
        End If
    End Sub


    Private Sub cmbVODSerieID_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbVODSerieID.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
            Dim _frm As New frmSeriesBrowseMaint(SessionInfo)
            _frm.Tag = 673 'MenuID if started with the MenuTree
            _frm.ShowDialog(Me)
            loadSeries()
        End If
    End Sub
End Class
