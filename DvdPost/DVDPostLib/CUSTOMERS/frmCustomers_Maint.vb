Imports BizzLib.clsGlobal.ObjectState
Imports System.Net.Mail
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports DevExpress.XtraSpellChecker
Public Class frmCustomers_Maint
    Inherits BizzLib.frmGeneral_Maintenance



    ' Private Const MAIL_RECEIVEDDOM As Integer = 424

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
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents objDS As DVDPostLib.dsCustomerMaint
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colpayment_offline_request_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvdpost_bank_account1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcommunication2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpayment_offline_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcomment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colaccount_movements_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_closed1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_closed_eurofides1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colreason_pk_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colreason_pk_value1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount_received1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_id4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_date1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_address1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstrdomiciliation_debiter_name1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstrdomiciliation_number1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcommunication3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirst_payment1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colreconduction1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_isabel_date1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_unpaid_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbatch_immatriculation_number1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_stopped_with_dvdathome_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_id4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_added1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_status1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_batch_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustserv_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collanguage_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustserv_cat_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer_date1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsubject1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladmindate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminby1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminmessage1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessagesent1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_finally_arrived_mail1 As DevExpress.XtraGrid.Columns.GridColumn


    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCNumDom As DevExpress.XtraEditors.LabelControl

    '  Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Friend WithEvents tabMailHistory As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents GridCustServ As DevExpress.XtraGrid.GridControl
    Friend WithEvents colcustserv_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collanguage_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustserv_cat_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer_date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorders_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsubject2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessage2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladmindate2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminby2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminmessage2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessagesent2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_finally_arrived_mail2 As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents tabDroselia As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents butGenCode As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabPaymentMovements As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCBankAccountMovement As DevExpress.XtraEditors.GroupControl
    Friend WithEvents coldomiciliation_payment_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_id4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_address2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstrdomiciliation_debiter_name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colstrdomiciliation_number2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcommunication4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfirst_payment2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colreconduction2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_status2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_payment_isabel_date2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldomiciliation_unpaid_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colbatch_immatriculation_number2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_stopped_with_dvdathome_id2 As DevExpress.XtraGrid.Columns.GridColumn
    'Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents cologone_payment_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_added7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabo_id5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers_id9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_status2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_batch_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collast_modified7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabPayment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl50 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbPayMethod As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl49 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CalcEdit As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LabelControl48 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents GroupDomiciliation As DevExpress.XtraEditors.GroupControl
    Friend WithEvents panelDomiciliation As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl54 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDomStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl53 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDomDebiterName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl52 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDomNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl51 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDomAcctNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnCancelPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupOgone As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelOgone As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl58 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_owner2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl57 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_card_no2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl56 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_card_type2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepositoryItemPayment As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl55 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmb_cc_expiration_status2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txt_cc_expiration_date2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridPayment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewPayment As DevExpress.XtraGrid.Views.Grid.GridView
    ' Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColLastModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCommunicationPay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCustomersID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPayment_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents checkOpenPayment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnLoadPayment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabCustServ As DevExpress.XtraTab.XtraTabPage
    '  Friend WithEvents cmbCustServ_cat As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SPlitCCustserv As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GCCustServ As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSaveCustServ As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutCustServ As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewOrders As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand5 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents col2orders_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_purchased As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_name As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_date_finished As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_products_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_dvd As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colorders_products_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridABO As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewABO As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colcustomerid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colAction As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    ' Friend WithEvents cmbABO_Action As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colcode_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproduct_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpayment_method As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colprivilege_notified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsite As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwl_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproduct_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colrank2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colpriority1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colwishlist_type2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_title2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colqty_in_stock1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridWishList As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewWishList As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colSendIt As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents btnSendIt As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colwishlist_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwl_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproduct_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colrank As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colpriority As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_title As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colqty_in_stock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents txtCustServ_Response_Message As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCustServ_DVD_ID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustServ_Products_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustServ_OrderID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustServ_CustDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtCustServ_Subject As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LCGMisc As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LCGResponse As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridWishListAssigned As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewWishListAssigned As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents colwishlist_type1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwl_assigned_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colwl_id1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colrprioritywish As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldate_assigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colproducts_title1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tabOrdersHistor As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSearch As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents col2customers_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_firstname As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_lastname As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_email_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_abo As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colblack_listed As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents custserv_customer_date As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colentry_postcode As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents coldomiciliation_number As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colcustomers_language As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents call_phone As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tabAboHistory As DevExpress.XtraTab.XtraTabPage

    Friend WithEvents tabWishList As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GCWishlistAssigned As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl11 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelDetailWishlist As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tabMain As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btnForcedReconduction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnActivateDomiciliation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReceivedDomiciliation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCACtPhone As DevExpress.XtraEditors.GroupControl
    Public WithEvents cmbPhoneActivDelete As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelReason As System.Windows.Forms.Label
    Friend WithEvents btnDelPhoAct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateCallPhoneActivation As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelCallMeDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnActPhone As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chkRedListed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkBlackListed As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNewsLetterPartner As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkNewsLetter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtWishListKind As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNbrOfLogons As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbLanguage As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnReActivate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCAboInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblAboSumP As System.Windows.Forms.Label
    Friend WithEvents lblSuspended As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnGoto30 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtRegistrationStep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblRegistrationStep As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDVDAdultAtHome As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblDiscountrecurring As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDiscRecurring As DevExpress.XtraEditors.DateEdit
    Friend WithEvents chkAutoStop As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbNextDiscCode As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNextDiscount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblActivation As DevExpress.XtraEditors.LabelControl
    Friend WithEvents chkMultiShipment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbNextABO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDVDNormAtHome As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDVDAdult As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtDVDNorm As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblAdult As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNorm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHome As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAsked As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABOCredit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblCredits As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValidity As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtAbo_ValidityTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cmbABO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblNextAbo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAbo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCadresse As DevExpress.XtraEditors.GroupControl
    Friend WithEvents txtDeliveryFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbDeliverycountry As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtDeliveryCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryPostCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDeliveryAddr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GCcustomersInfo As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblComment As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtComment As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtYearsOld As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblGender As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtGender As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblyearsOld As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblSetPassWord As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblLogas As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmbEntity As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtDateCreated As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtTel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEMail As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents txtTelEvening As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtABO As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateBirthday As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtFirstName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtLastName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCustomers_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnStopNow As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnStopAtReconduction As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabSearch As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TxtCustomers_NumComm As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblNumComm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcustomers_domiciliation_number_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnPhoneActivation As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcustomers_postcode_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtcustomers_address_street_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcustomers_email_address_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtcustomers_name_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcustomers_id_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl

    Friend WithEvents XTabCustomers As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents grpContEmail As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewMail As DevExpress.XtraGrid.Views.Grid.GridView
    '  Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents messages_subject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents messages_title As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mail_opened_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents mail_opened As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_sended As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents messages_html As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents browser As System.Windows.Forms.WebBrowser
    Friend WithEvents products_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tabPurchase As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridShoppingOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewShoppingOrders As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents shopping_orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_orders As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shopping_products_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shopping_discount_code_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_state As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_bonus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_url As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_awards As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_viewed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_image_big As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabCreditHist As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCreditHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCreditHistory As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantity_paid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents action_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cologone_payment_status_history_id As DevExpress.XtraGrid.Columns.GridColumn






    Friend WithEvents chkCustServSendMail As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GridAboprocessOld As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAboprocessOld As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents dvd_norm_to_send As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_adult_to_send As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_highsent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_mediumsent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_lowsent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_norm_abo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_adult_abo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_norm_compensation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_adult_compensation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_norm_home As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dvd_adult_home As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents creditABoProcess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customer_abo_rank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents msgerror As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nbdvdfindnorm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nbdvdfindadult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nbwishlistadult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nbwishlistnorm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents label As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_start As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantity_free As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents credit_free As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabSponsorShip As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridSon As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents used_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSon_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents son_abo_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents points As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridViewGodson As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents date_used As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents sponsor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCSponsorShip As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GCGift As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridGift As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewGift As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents date_attribution As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents points_customers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_sent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_sent_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_id_gift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_name_fr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_name_nl As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gift_name_en As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents points_gift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridGodFather As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridviewGodFather As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldate_used As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents father_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colfather_abo_type As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtPtSponsorShip As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents customers_lastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_firstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2customers_lastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col2customers_firstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grpCustomersPoint As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridCustPointHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCustPointHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col2date_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_points_history As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_points_history_action_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_points_history_sub_action_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducts_availability As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents checkAvailibility As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents DateAdded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents products_date_available As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tabCompensation As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tabComment As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCompensation As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCompensation As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents compensation_date_given As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents compensation_date_setback As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents compensation_comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents orders_id_given As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_name_given As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompProducts_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbSuspended As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents MemoCustomersComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnAddCustomersComment As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCustComment As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCustComment As DevExpress.XtraGrid.Views.Grid.GridView

    Friend WithEvents MemoInsertComment As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents customers_comment_text As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customers_comment_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblDateEndHoliday As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEndOfHoliday As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnViewCustserv As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnViewGift As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Col3Orders_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BtnPaid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridAddress As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAddress As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents entry_firstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents entry_lastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents entry_street_address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents entry_postcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents entry_city As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents countries_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shopping_discount_value As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabProductsRating As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridProductsRating As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewProductsRating As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents products As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_rating As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents products_rating_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rating_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRatingProducts_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWAdate_added As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProducts_next As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colProductsstatus As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colentry_street_address As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents fullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridOrdersStatusHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewOrdersHistory As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents GridBand6 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

    Friend WithEvents coldate_added_Orders_history As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents new_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents old_status As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents BtnSponsorCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GCSponsonCard As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCard2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCard1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCard5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCard4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCard3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCard3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BtnSaveSponsorCard As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRedlisted As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnBlackListed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCodeLinked As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCodeLinked As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GCCodeLinked As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BtnEmailError As DevExpress.XtraEditors.SimpleButton


    Friend WithEvents gridViewCustServ As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colcustserv_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collanguage_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents custserv_cat_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorders_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladmindate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminmessage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessagesent As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomers2_id6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustserv2_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents collanguage2_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents custserv_cat_name2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustomer2_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colorders2_id1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colproducts2_id2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvd2_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colsubject3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessage3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladmindate3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coladminmessage3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmessagesent3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MemoOtherReason As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tabSuspendedHistory As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridSuspendedHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewSuspendedHistory As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents suspended_history_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents suspended_history_date_end As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents abosuspended_history_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridDroselia As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewDroselia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents droselia_codes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents droselia_buy_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents droselia_used_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents catalog_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents droselia_url_link As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDroselia As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colorders_last_modified As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents lblNextCredit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNextCredit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNextPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChkListConfig As DevExpress.XtraEditors.CheckedListBoxControl
    Friend WithEvents btnRefreshTab As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tabConfig As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblNextPrice As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColOrders_type As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SplitContainerOrders As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents colWAProducts_id As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tabVodView As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridViewVod As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcDate_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCLast_modified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCProducts_title As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCImdb_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCCount_ip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCNb_viewed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCUsedIp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GCMail_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourceAdded As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colsourceaddedAssigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColLast_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDate_closed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDomNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colabopay_id As DevExpress.XtraGrid.Columns.GridColumn

    Friend WithEvents txtLast_logon As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCpt_reconduction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbReconduction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridBankAccountMovements As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewBankAccountMovements As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colIsmatching As DevExpress.XtraGrid.Columns.GridColumn
    Protected WithEvents RepositoryCmbMatching As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colBankAccountMovements_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldate_coda_created As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodaFilename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colamount2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvdpost_bank_account As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcommunicationStr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStructuredComm12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCounterpartdetails As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColCommunication_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEntireData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccountClient As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColLastnModified As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColTotalPaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalFree As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccount_Customers_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBankAccount_Comment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabAboprocess As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents gridAboprocess As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewAboprocess As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents coldvdHigh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvdmedium As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldvdlow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDvd_Abo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDvd_Compensation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDvd_home As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCredit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colcustaborank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colmsgerror As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDvdFind As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWishlist As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coldateStart As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProducts_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabAboProcessOld As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents colserieid As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colserienumber As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colserieIdAssigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents colseriesNumberAssigned As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents gridInfoNorm As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewInfoNorm As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gridInfoAdult As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewInfoAdult As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents splitNormAdult As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents tabCalls As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl39 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl40 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl41 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl42 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    ' Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl43 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton6 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    ' Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl44 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit2 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LookUpEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelControl45 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton8 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl46 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl47 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit3 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl59 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl60 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LookUpEdit5 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit4 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl61 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl62 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl63 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl64 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SpinEdit5 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl65 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl66 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit4 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LookUpEdit6 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl67 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl68 As DevExpress.XtraEditors.LabelControl
    '  Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl69 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit7 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl70 As DevExpress.XtraEditors.LabelControl
    'Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit13 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SpinEdit6 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl71 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit3 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit14 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit4 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit15 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit5 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl72 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit6 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit16 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl73 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl74 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit17 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl75 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl76 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl77 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit18 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl78 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl79 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit8 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl80 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl81 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl82 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LookUpEdit9 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents DateEdit5 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl83 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit19 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HyperLinkEdit1 As DevExpress.XtraEditors.HyperLinkEdit
    Friend WithEvents TextEdit20 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl84 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit7 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl85 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit6 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit21 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit22 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl86 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit23 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl87 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton9 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton10 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UcCallsHistory1 As DVDPostLib.ucCallsHistory
    Friend WithEvents chkFt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents tabMessagerie As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cmbDiscountActivation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents UcMessagerieCustomer As DVDPostLib.UcMessagerie
    Friend WithEvents RepositoryWishlistIProduct As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryISponsorCustomers_id As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryISponsorGodCustomers_id As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryICustomersCustomers_id As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents tabCritiques As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GridCritiques As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridViewCritiques As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblValueNbCrtitiques As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbCrtitiques As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueRatingAverage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRatingAverage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lblValueNbCritiquePositive As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblNbCritiquePositive As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueAverageRatingDvdPost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblAverageRatingDvdPost As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblValueRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRating As DevExpress.XtraEditors.LabelControl
    Friend WithEvents colAddDvd As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents RepositoryIbtnAddDVD As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryIbtnCheckOrder As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colOrderCheck As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ColName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents ChkCreditCombined As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnCreditHistoryReplay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReplayAllCreditHistory As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chksleep As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cdate_added As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDate_added_Current As DevExpress.XtraEditors.TextEdit
    Friend WithEvents chkOnly_VOD As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkCreditReceivedBySite As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cmbDiscType As DevExpress.XtraEditors.ComboBoxEdit


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
Dim coldvd_finally_arrived_mail3 As DevExpress.XtraGrid.Columns.GridColumn
Dim GridchkAbo As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
Dim GridchkBlackList As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
Dim ColTypePayment As DevExpress.XtraGrid.Columns.GridColumn
Dim ColPayment_id As DevExpress.XtraGrid.Columns.GridColumn
Dim ColAmountPay As DevExpress.XtraGrid.Columns.GridColumn
Dim ColDateAdded As DevExpress.XtraGrid.Columns.GridColumn
Dim ColIdMatching As DevExpress.XtraGrid.Columns.GridColumn
Dim coldvd_to_send As DevExpress.XtraGrid.Columns.GridColumn
Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers_Maint))
Me.tabAboProcessOld = New DevExpress.XtraTab.XtraTabPage
Me.GridAboprocessOld = New DevExpress.XtraGrid.GridControl
Me.GridViewAboprocessOld = New DevExpress.XtraGrid.Views.Grid.GridView
Me.dvd_norm_to_send = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_adult_to_send = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_highsent = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_mediumsent = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_lowsent = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_norm_abo = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_adult_abo = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_norm_compensation = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_adult_compensation = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_norm_home = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_adult_home = New DevExpress.XtraGrid.Columns.GridColumn
Me.creditABoProcess = New DevExpress.XtraGrid.Columns.GridColumn
Me.customer_abo_rank = New DevExpress.XtraGrid.Columns.GridColumn
Me.msgerror = New DevExpress.XtraGrid.Columns.GridColumn
Me.nbdvdfindnorm = New DevExpress.XtraGrid.Columns.GridColumn
Me.nbdvdfindadult = New DevExpress.XtraGrid.Columns.GridColumn
Me.nbwishlistadult = New DevExpress.XtraGrid.Columns.GridColumn
Me.nbwishlistnorm = New DevExpress.XtraGrid.Columns.GridColumn
Me.label = New DevExpress.XtraGrid.Columns.GridColumn
Me.date_start = New DevExpress.XtraGrid.Columns.GridColumn
Me.txtNextCredit = New DevExpress.XtraEditors.TextEdit
Me.txtNextPrice = New DevExpress.XtraEditors.TextEdit
Me.objDS = New DVDPostLib.dsCustomerMaint
Me.colcustomers2_id6 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridViewGodson = New DevExpress.XtraGrid.Views.Grid.GridView
Me.date_used = New DevExpress.XtraGrid.Columns.GridColumn
Me.sponsor = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridSon = New DevExpress.XtraGrid.GridControl
Me.GridViewSon = New DevExpress.XtraGrid.Views.Grid.GridView
Me.used_date = New DevExpress.XtraGrid.Columns.GridColumn
Me.colSon_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.RepositoryISponsorCustomers_id = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
Me.son_abo_type = New DevExpress.XtraGrid.Columns.GridColumn
Me.points = New DevExpress.XtraGrid.Columns.GridColumn
Me.customers_lastname = New DevExpress.XtraGrid.Columns.GridColumn
Me.customers_firstname = New DevExpress.XtraGrid.Columns.GridColumn
Me.colpayment_offline_request_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colamount3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvdpost_bank_account1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcommunication2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldate_added = New DevExpress.XtraGrid.Columns.GridColumn
Me.colpayment_offline_status1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.collast_modified = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcomment = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_payment_id3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.cologone_payment_id3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colaccount_movements_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldate_closed1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldate_closed_eurofides1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colreason_pk_name1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colreason_pk_value1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colamount_received1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_payment_id4 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_payment_date1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colabo_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_name = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_address1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colamount4 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colstrdomiciliation_debiter_name1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colstrdomiciliation_number1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcommunication3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colfirst_payment1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colreconduction1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_payment_status1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_payment_isabel_date1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_unpaid_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colbatch_immatriculation_number1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.collast_modified4 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colabo_stopped_with_dvdathome_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.cologone_payment_id4 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldate_added1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colabo_id3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colamount5 = New DevExpress.XtraGrid.Columns.GridColumn
Me.cologone_payment_status1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.cologone_batch_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.collast_modified5 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustserv_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_id3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.collanguage_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustserv_cat_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomer_date1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colorders_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.colproducts_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvd_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colsubject1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colmessage1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coladmindate1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coladminby1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coladminmessage1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colmessagesent1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvd_finally_arrived_mail1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit
Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit
Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit
Me.LCNumDom = New DevExpress.XtraEditors.LabelControl
Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
Me.tabMailHistory = New DevExpress.XtraTab.XtraTabPage
Me.browser = New System.Windows.Forms.WebBrowser
Me.grpContEmail = New DevExpress.XtraGrid.GridControl
Me.GridViewMail = New DevExpress.XtraGrid.Views.Grid.GridView
Me.messages_subject = New DevExpress.XtraGrid.Columns.GridColumn
Me.messages_title = New DevExpress.XtraGrid.Columns.GridColumn
Me.mail_opened_date = New DevExpress.XtraGrid.Columns.GridColumn
Me.mail_opened = New DevExpress.XtraGrid.Columns.GridColumn
Me.date_sended = New DevExpress.XtraGrid.Columns.GridColumn
Me.messages_html = New DevExpress.XtraGrid.Columns.GridColumn
Me.GCMail_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridCustServ = New DevExpress.XtraGrid.GridControl
Me.gridViewCustServ = New DevExpress.XtraGrid.Views.Grid.GridView
Me.colcustserv2_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.collanguage2_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.custserv_cat_name2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomer2_date = New DevExpress.XtraGrid.Columns.GridColumn
Me.colorders2_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colproducts2_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvd2_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.colsubject3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colmessage3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coladmindate3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coladminmessage3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colmessagesent3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabDroselia = New DevExpress.XtraTab.XtraTabPage
Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl
Me.txtDroselia = New DevExpress.XtraEditors.SpinEdit
Me.GridDroselia = New DevExpress.XtraGrid.GridControl
Me.GridViewDroselia = New DevExpress.XtraGrid.Views.Grid.GridView
Me.droselia_codes = New DevExpress.XtraGrid.Columns.GridColumn
Me.droselia_buy_date = New DevExpress.XtraGrid.Columns.GridColumn
Me.droselia_used_date = New DevExpress.XtraGrid.Columns.GridColumn
Me.catalog_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.droselia_url_link = New DevExpress.XtraGrid.Columns.GridColumn
Me.butGenCode = New DevExpress.XtraEditors.SimpleButton
Me.tabPaymentMovements = New DevExpress.XtraTab.XtraTabPage
Me.GCBankAccountMovement = New DevExpress.XtraEditors.GroupControl
Me.GridBankAccountMovements = New DevExpress.XtraGrid.GridControl
Me.GridViewBankAccountMovements = New DevExpress.XtraGrid.Views.Grid.GridView
Me.colIsmatching = New DevExpress.XtraGrid.Columns.GridColumn
Me.RepositoryCmbMatching = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.colBankAccountMovements_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldate_coda_created = New DevExpress.XtraGrid.Columns.GridColumn
Me.colCodaFilename = New DevExpress.XtraGrid.Columns.GridColumn
Me.colamount2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvdpost_bank_account = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcommunicationStr = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colStructuredComm12 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colCounterpartdetails = New DevExpress.XtraGrid.Columns.GridColumn
Me.ColCommunication_type = New DevExpress.XtraGrid.Columns.GridColumn
Me.colEntireData = New DevExpress.XtraGrid.Columns.GridColumn
Me.colBankAccountClient = New DevExpress.XtraGrid.Columns.GridColumn
Me.colBankAccount_Customers_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.colBankAccount_Comment = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridOrders = New DevExpress.XtraGrid.GridControl
Me.GridViewOrders = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand5 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.ColName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colOrderCheck = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.RepositoryIbtnCheckOrder = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
Me.col2orders_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.coldate_purchased = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colorders_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproducts_name = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colorders_date_finished = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colorders_products_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.products_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproducts_dvd = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colorders_last_modified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.ColOrders_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colorders_products_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.Col3Orders_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridABO = New DevExpress.XtraGrid.GridControl
Me.GridViewABO = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.colcustomerid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colAction = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colcode_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproduct_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colpayment_method = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colprivilege_notified = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colsite = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.ColLast_status = New DevExpress.XtraGrid.Columns.GridColumn
Me.colDate_closed = New DevExpress.XtraGrid.Columns.GridColumn
Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
Me.colDomNumber = New DevExpress.XtraGrid.Columns.GridColumn
Me.colabopay_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabPayment = New DevExpress.XtraTab.XtraTabPage
Me.GridPayment = New DevExpress.XtraGrid.GridControl
Me.GridViewPayment = New DevExpress.XtraGrid.Views.Grid.GridView
Me.ColLastModified = New DevExpress.XtraGrid.Columns.GridColumn
Me.ColCommunicationPay = New DevExpress.XtraGrid.Columns.GridColumn
Me.ColCustomersID = New DevExpress.XtraGrid.Columns.GridColumn
Me.colPayment_status = New DevExpress.XtraGrid.Columns.GridColumn
Me.BtnPaid = New DevExpress.XtraEditors.SimpleButton
Me.btnLoadPayment = New DevExpress.XtraEditors.SimpleButton
Me.checkOpenPayment = New DevExpress.XtraEditors.CheckEdit
Me.GroupOgone = New DevExpress.XtraEditors.GroupControl
Me.PanelOgone = New DevExpress.XtraEditors.PanelControl
Me.txt_cc_expiration_date2 = New DevExpress.XtraEditors.TextEdit
Me.cmb_cc_expiration_status2 = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl55 = New DevExpress.XtraEditors.LabelControl
Me.txt_cc_card_type2 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl56 = New DevExpress.XtraEditors.LabelControl
Me.txt_cc_card_no2 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl57 = New DevExpress.XtraEditors.LabelControl
Me.txt_cc_owner2 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl58 = New DevExpress.XtraEditors.LabelControl
Me.BtnCancelPayment = New DevExpress.XtraEditors.SimpleButton
Me.GroupDomiciliation = New DevExpress.XtraEditors.GroupControl
Me.panelDomiciliation = New DevExpress.XtraEditors.PanelControl
Me.txtDomAcctNumber = New DevExpress.XtraEditors.TextEdit
Me.LabelControl51 = New DevExpress.XtraEditors.LabelControl
Me.txtDomNumber = New DevExpress.XtraEditors.TextEdit
Me.LabelControl52 = New DevExpress.XtraEditors.LabelControl
Me.txtDomDebiterName = New DevExpress.XtraEditors.TextEdit
Me.LabelControl53 = New DevExpress.XtraEditors.LabelControl
Me.cmbDomStatus = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl54 = New DevExpress.XtraEditors.LabelControl
Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit
Me.LabelControl48 = New DevExpress.XtraEditors.LabelControl
Me.CalcEdit = New DevExpress.XtraEditors.CalcEdit
Me.LabelControl49 = New DevExpress.XtraEditors.LabelControl
Me.cmbPayMethod = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl50 = New DevExpress.XtraEditors.LabelControl
Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colwl_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_id8 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colproduct_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colrank2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colpriority1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldate_added7 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colwishlist_type2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colproducts_title2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colqty_in_stock1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridWishList = New DevExpress.XtraGrid.GridControl
Me.GridViewWishList = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.colSendIt = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.btnSendIt = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
Me.colwishlist_type = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colserieid = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.DateAdded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colwl_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproduct_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colrank = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colpriority = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproducts_title = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.products_date_available = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colqty_in_stock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colProducts_next = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.checkAvailibility = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
Me.colProductsstatus = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colProducts_availability = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colSourceAdded = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colserienumber = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.tabCustServ = New DevExpress.XtraTab.XtraTabPage
Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl
Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl
Me.LayoutCustServ = New DevExpress.XtraDataLayout.DataLayoutControl
Me.txtCustServ_Response_Message = New DevExpress.XtraEditors.MemoEdit
Me.txtCustServ_DVD_ID = New DevExpress.XtraEditors.TextEdit
Me.txtCustServ_Products_id = New DevExpress.XtraEditors.TextEdit
Me.txtCustServ_OrderID = New DevExpress.XtraEditors.TextEdit
Me.txtCustServ_CustDate = New DevExpress.XtraEditors.DateEdit
Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
Me.txtCustServ_Subject = New DevExpress.XtraEditors.TextEdit
Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
Me.LCGMisc = New DevExpress.XtraLayout.LayoutControlGroup
Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem
Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem
Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem
Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup
Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem
Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem
Me.LCGResponse = New DevExpress.XtraLayout.LayoutControlGroup
Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem
Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem
Me.GCCustServ = New DevExpress.XtraEditors.GroupControl
Me.chkCustServSendMail = New DevExpress.XtraEditors.CheckEdit
Me.btnSaveCustServ = New DevExpress.XtraEditors.SimpleButton
Me.SPlitCCustserv = New DevExpress.XtraEditors.SplitterControl
Me.GridWishListAssigned = New DevExpress.XtraGrid.GridControl
Me.GridViewWishListAssigned = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.colAddDvd = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.RepositoryIbtnAddDVD = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
Me.colwishlist_type1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colwl_assigned_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colwl_id1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colrprioritywish = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.coldate_assigned = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colWAdate_added = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colproducts_title1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colWAProducts_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colsourceaddedAssigned = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colserieIdAssigned = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colseriesNumberAssigned = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.coldomiciliation_payment_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_payment_date2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colabo_id4 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_name2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_address2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colamount6 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colstrdomiciliation_debiter_name2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colstrdomiciliation_number2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcommunication4 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colfirst_payment2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colreconduction2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_payment_status2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_payment_isabel_date2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldomiciliation_unpaid_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colbatch_immatriculation_number2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.collast_modified6 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colabo_stopped_with_dvdathome_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.cologone_payment_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colabo_id5 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_id9 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colamount7 = New DevExpress.XtraGrid.Columns.GridColumn
Me.cologone_payment_status2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.cologone_batch_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.collast_modified7 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustserv_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomers_id10 = New DevExpress.XtraGrid.Columns.GridColumn
Me.collanguage_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustserv_cat_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustomer_date2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colorders_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colproducts_id1 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvd_id2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colsubject2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colmessage2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coladmindate2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coladminby2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coladminmessage2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.colmessagesent2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvd_finally_arrived_mail2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabOrdersHistor = New DevExpress.XtraTab.XtraTabPage
Me.SplitContainerOrders = New DevExpress.XtraEditors.SplitContainerControl
Me.GridOrdersStatusHistory = New DevExpress.XtraGrid.GridControl
Me.GridViewOrdersHistory = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand6 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.coldate_added_Orders_history = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.new_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.old_status = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.GridControl1 = New DevExpress.XtraGrid.GridControl
Me.GridViewSearch = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
Me.col2customers_id = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.RepositoryICustomersCustomers_id = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
Me.colcustomers_firstname = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colcustomers_lastname = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colcustomers_email_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colcustomers_abo = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colblack_listed = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colentry_postcode = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colentry_street_address = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.coldomiciliation_number = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.colcustomers_language = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.call_phone = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.custserv_customer_date = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
Me.tabAboHistory = New DevExpress.XtraTab.XtraTabPage
Me.tabWishList = New DevExpress.XtraTab.XtraTabPage
Me.GCWishlistAssigned = New DevExpress.XtraEditors.GroupControl
Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl
Me.PanelControl11 = New DevExpress.XtraEditors.PanelControl
Me.PanelDetailWishlist = New DevExpress.XtraEditors.PanelControl
Me.splitNormAdult = New DevExpress.XtraEditors.SplitterControl
Me.gridInfoAdult = New DevExpress.XtraGrid.GridControl
Me.GridViewInfoAdult = New DevExpress.XtraGrid.Views.Grid.GridView
Me.gridInfoNorm = New DevExpress.XtraGrid.GridControl
Me.GridViewInfoNorm = New DevExpress.XtraGrid.Views.Grid.GridView
Me.tabMain = New DevExpress.XtraTab.XtraTabPage
Me.chksleep = New DevExpress.XtraEditors.CheckEdit
Me.btnCreditHistoryReplay = New DevExpress.XtraEditors.SimpleButton
Me.ChkCreditCombined = New DevExpress.XtraEditors.CheckEdit
Me.chkFt = New DevExpress.XtraEditors.CheckEdit
Me.lblCpt_reconduction = New DevExpress.XtraEditors.LabelControl
Me.lblNbReconduction = New DevExpress.XtraEditors.LabelControl
Me.lblNextPrice = New DevExpress.XtraEditors.LabelControl
Me.lblNextCredit = New DevExpress.XtraEditors.LabelControl
Me.btnForcedReconduction = New DevExpress.XtraEditors.SimpleButton
Me.btnActivateDomiciliation = New DevExpress.XtraEditors.SimpleButton
Me.btnReceivedDomiciliation = New DevExpress.XtraEditors.SimpleButton
Me.GCACtPhone = New DevExpress.XtraEditors.GroupControl
Me.MemoOtherReason = New DevExpress.XtraEditors.MemoEdit
Me.Label2 = New System.Windows.Forms.Label
Me.cmbPhoneActivDelete = New DevExpress.XtraEditors.LookUpEdit
Me.LabelReason = New System.Windows.Forms.Label
Me.DateCallPhoneActivation = New DevExpress.XtraEditors.DateEdit
Me.LabelCallMeDate = New DevExpress.XtraEditors.LabelControl
Me.btnDelPhoAct = New DevExpress.XtraEditors.SimpleButton
Me.btnActPhone = New DevExpress.XtraEditors.SimpleButton
Me.btnReActivate = New DevExpress.XtraEditors.SimpleButton
Me.GCAboInfo = New DevExpress.XtraEditors.GroupControl
Me.cmbDiscountActivation = New DevExpress.XtraEditors.LookUpEdit
Me.cmbDiscType = New DevExpress.XtraEditors.ComboBoxEdit
Me.lblDateEndHoliday = New DevExpress.XtraEditors.LabelControl
Me.DateEndOfHoliday = New DevExpress.XtraEditors.DateEdit
Me.cmbSuspended = New DevExpress.XtraEditors.LookUpEdit
Me.lblAboSumP = New System.Windows.Forms.Label
Me.lblSuspended = New DevExpress.XtraEditors.LabelControl
Me.btnGoto30 = New DevExpress.XtraEditors.SimpleButton
Me.txtRegistrationStep = New DevExpress.XtraEditors.TextEdit
Me.lblRegistrationStep = New DevExpress.XtraEditors.LabelControl
Me.txtDVDAdultAtHome = New DevExpress.XtraEditors.SpinEdit
Me.lblDiscountrecurring = New DevExpress.XtraEditors.LabelControl
Me.txtDiscRecurring = New DevExpress.XtraEditors.DateEdit
Me.chkAutoStop = New DevExpress.XtraEditors.CheckEdit
Me.cmbNextDiscCode = New DevExpress.XtraEditors.LookUpEdit
Me.lblNextDiscount = New DevExpress.XtraEditors.LabelControl
Me.lblActivation = New DevExpress.XtraEditors.LabelControl
Me.chkMultiShipment = New DevExpress.XtraEditors.CheckEdit
Me.cmbNextABO = New DevExpress.XtraEditors.LookUpEdit
Me.txtDVDNormAtHome = New DevExpress.XtraEditors.SpinEdit
Me.txtDVDAdult = New DevExpress.XtraEditors.SpinEdit
Me.txtDVDNorm = New DevExpress.XtraEditors.SpinEdit
Me.lblAdult = New DevExpress.XtraEditors.LabelControl
Me.lblNorm = New DevExpress.XtraEditors.LabelControl
Me.lblHome = New DevExpress.XtraEditors.LabelControl
Me.lblAsked = New DevExpress.XtraEditors.LabelControl
Me.txtABOCredit = New DevExpress.XtraEditors.SpinEdit
Me.lblCredits = New DevExpress.XtraEditors.LabelControl
Me.lblValidity = New DevExpress.XtraEditors.LabelControl
Me.txtAbo_ValidityTo = New DevExpress.XtraEditors.DateEdit
Me.cmbABO = New DevExpress.XtraEditors.LookUpEdit
Me.lblNextAbo = New DevExpress.XtraEditors.LabelControl
Me.lblAbo = New DevExpress.XtraEditors.LabelControl
Me.GCadresse = New DevExpress.XtraEditors.GroupControl
Me.txtDate_added_Current = New DevExpress.XtraEditors.TextEdit
Me.GridAddress = New DevExpress.XtraGrid.GridControl
Me.GridViewAddress = New DevExpress.XtraGrid.Views.Grid.GridView
Me.entry_firstname = New DevExpress.XtraGrid.Columns.GridColumn
Me.entry_lastname = New DevExpress.XtraGrid.Columns.GridColumn
Me.entry_street_address = New DevExpress.XtraGrid.Columns.GridColumn
Me.entry_postcode = New DevExpress.XtraGrid.Columns.GridColumn
Me.entry_city = New DevExpress.XtraGrid.Columns.GridColumn
Me.countries_name = New DevExpress.XtraGrid.Columns.GridColumn
Me.cdate_added = New DevExpress.XtraGrid.Columns.GridColumn
Me.txtDeliveryFirstName = New DevExpress.XtraEditors.TextEdit
Me.txtDeliveryLastName = New DevExpress.XtraEditors.TextEdit
Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
Me.cmbDeliverycountry = New DevExpress.XtraEditors.LookUpEdit
Me.txtDeliveryCity = New DevExpress.XtraEditors.TextEdit
Me.txtDeliveryPostCode = New DevExpress.XtraEditors.TextEdit
Me.txtDeliveryAddr = New DevExpress.XtraEditors.TextEdit
Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
Me.GCcustomersInfo = New DevExpress.XtraEditors.GroupControl
Me.chkCreditReceivedBySite = New DevExpress.XtraEditors.CheckEdit
Me.chkOnly_VOD = New DevExpress.XtraEditors.CheckEdit
Me.txtLast_logon = New DevExpress.XtraEditors.TextEdit
Me.txtPtSponsorShip = New DevExpress.XtraEditors.SpinEdit
Me.lblComment = New DevExpress.XtraEditors.LabelControl
Me.chkRedListed = New DevExpress.XtraEditors.CheckEdit
Me.txtComment = New DevExpress.XtraEditors.TextEdit
Me.chkBlackListed = New DevExpress.XtraEditors.CheckEdit
Me.txtYearsOld = New DevExpress.XtraEditors.TextEdit
Me.chkNewsLetterPartner = New DevExpress.XtraEditors.CheckEdit
Me.lblGender = New DevExpress.XtraEditors.LabelControl
Me.chkNewsLetter = New DevExpress.XtraEditors.CheckEdit
Me.txtGender = New DevExpress.XtraEditors.TextEdit
Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl
Me.lblyearsOld = New DevExpress.XtraEditors.LabelControl
Me.txtWishListKind = New DevExpress.XtraEditors.TextEdit
Me.lblSetPassWord = New DevExpress.XtraEditors.LabelControl
Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl
Me.lblLogas = New DevExpress.XtraEditors.LabelControl
Me.txtNbrOfLogons = New DevExpress.XtraEditors.TextEdit
Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl
Me.cmbEntity = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl
Me.cmbLanguage = New DevExpress.XtraEditors.LookUpEdit
Me.txtDateCreated = New DevExpress.XtraEditors.DateEdit
Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl
Me.txtTel = New DevExpress.XtraEditors.TextEdit
Me.txtEMail = New DevExpress.XtraEditors.HyperLinkEdit
Me.txtTelEvening = New DevExpress.XtraEditors.TextEdit
Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl
Me.txtABO = New DevExpress.XtraEditors.CheckEdit
Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl
Me.DateBirthday = New DevExpress.XtraEditors.DateEdit
Me.txtFirstName = New DevExpress.XtraEditors.TextEdit
Me.txtLastName = New DevExpress.XtraEditors.TextEdit
Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
Me.txtCustomers_id = New DevExpress.XtraEditors.TextEdit
Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
Me.btnStopNow = New DevExpress.XtraEditors.SimpleButton
Me.btnStopAtReconduction = New DevExpress.XtraEditors.SimpleButton
Me.tabSearch = New DevExpress.XtraTab.XtraTabPage
Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
Me.btnReplayAllCreditHistory = New DevExpress.XtraEditors.SimpleButton
Me.BtnEmailError = New DevExpress.XtraEditors.SimpleButton
Me.btnRedlisted = New DevExpress.XtraEditors.SimpleButton
Me.btnBlackListed = New DevExpress.XtraEditors.SimpleButton
Me.BtnSponsorCard = New DevExpress.XtraEditors.SimpleButton
Me.btnViewGift = New DevExpress.XtraEditors.SimpleButton
Me.btnViewCustserv = New DevExpress.XtraEditors.SimpleButton
Me.TxtCustomers_NumComm = New DevExpress.XtraEditors.TextEdit
Me.lblNumComm = New DevExpress.XtraEditors.LabelControl
Me.txtcustomers_domiciliation_number_search = New DevExpress.XtraEditors.TextEdit
Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
Me.btnPhoneActivation = New DevExpress.XtraEditors.SimpleButton
Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
Me.txtcustomers_postcode_search = New DevExpress.XtraEditors.TextEdit
Me.btnSearch = New DevExpress.XtraEditors.SimpleButton
Me.txtcustomers_address_street_search = New DevExpress.XtraEditors.TextEdit
Me.txtcustomers_email_address_search = New DevExpress.XtraEditors.TextEdit
Me.txtcustomers_name_search = New DevExpress.XtraEditors.TextEdit
Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
Me.txtcustomers_id_search = New DevExpress.XtraEditors.TextEdit
Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
Me.XTabCustomers = New DevExpress.XtraTab.XtraTabControl
Me.tabComment = New DevExpress.XtraTab.XtraTabPage
Me.MemoCustomersComment = New DevExpress.XtraEditors.MemoEdit
Me.GridCustComment = New DevExpress.XtraGrid.GridControl
Me.GridViewCustComment = New DevExpress.XtraGrid.Views.Grid.GridView
Me.customers_comment_text = New DevExpress.XtraGrid.Columns.GridColumn
Me.customers_comment_date = New DevExpress.XtraGrid.Columns.GridColumn
Me.fullName = New DevExpress.XtraGrid.Columns.GridColumn
Me.MemoInsertComment = New DevExpress.XtraEditors.MemoEdit
Me.btnAddCustomersComment = New DevExpress.XtraEditors.SimpleButton
Me.tabCalls = New DevExpress.XtraTab.XtraTabPage
Me.UcCallsHistory1 = New DVDPostLib.ucCallsHistory
Me.tabMessagerie = New DevExpress.XtraTab.XtraTabPage
Me.UcMessagerieCustomer = New DVDPostLib.UcMessagerie
Me.tabSponsorShip = New DevExpress.XtraTab.XtraTabPage
Me.GCCodeLinked = New DevExpress.XtraEditors.GroupControl
Me.GridCodeLinked = New DevExpress.XtraGrid.GridControl
Me.GridViewCodeLinked = New DevExpress.XtraGrid.Views.Grid.GridView
Me.GCSponsonCard = New DevExpress.XtraEditors.GroupControl
Me.BtnSaveSponsorCard = New DevExpress.XtraEditors.SimpleButton
Me.lblCard5 = New DevExpress.XtraEditors.LabelControl
Me.txtCard5 = New DevExpress.XtraEditors.TextEdit
Me.lblCard4 = New DevExpress.XtraEditors.LabelControl
Me.txtCard4 = New DevExpress.XtraEditors.TextEdit
Me.lblCard3 = New DevExpress.XtraEditors.LabelControl
Me.txtCard3 = New DevExpress.XtraEditors.TextEdit
Me.lblCard2 = New DevExpress.XtraEditors.LabelControl
Me.txtCard2 = New DevExpress.XtraEditors.TextEdit
Me.lblCard1 = New DevExpress.XtraEditors.LabelControl
Me.txtCard1 = New DevExpress.XtraEditors.TextEdit
Me.grpCustomersPoint = New DevExpress.XtraEditors.GroupControl
Me.GridCustPointHistory = New DevExpress.XtraGrid.GridControl
Me.GridViewCustPointHistory = New DevExpress.XtraGrid.Views.Grid.GridView
Me.col2date_added = New DevExpress.XtraGrid.Columns.GridColumn
Me.customers_points_history = New DevExpress.XtraGrid.Columns.GridColumn
Me.customers_points_history_action_name = New DevExpress.XtraGrid.Columns.GridColumn
Me.customers_points_history_sub_action_name = New DevExpress.XtraGrid.Columns.GridColumn
Me.GCGift = New DevExpress.XtraEditors.GroupControl
Me.GridGift = New DevExpress.XtraGrid.GridControl
Me.GridViewGift = New DevExpress.XtraGrid.Views.Grid.GridView
Me.date_attribution = New DevExpress.XtraGrid.Columns.GridColumn
Me.gift_sent = New DevExpress.XtraGrid.Columns.GridColumn
Me.points_customers = New DevExpress.XtraGrid.Columns.GridColumn
Me.gift_sent_date = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_id_gift = New DevExpress.XtraGrid.Columns.GridColumn
Me.gift_name_fr = New DevExpress.XtraGrid.Columns.GridColumn
Me.gift_name_nl = New DevExpress.XtraGrid.Columns.GridColumn
Me.gift_name_en = New DevExpress.XtraGrid.Columns.GridColumn
Me.points_gift = New DevExpress.XtraGrid.Columns.GridColumn
Me.GCSponsorShip = New DevExpress.XtraEditors.GroupControl
Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl
Me.GridGodFather = New DevExpress.XtraGrid.GridControl
Me.GridviewGodFather = New DevExpress.XtraGrid.Views.Grid.GridView
Me.coldate_used = New DevExpress.XtraGrid.Columns.GridColumn
Me.father_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.RepositoryISponsorGodCustomers_id = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
Me.colfather_abo_type = New DevExpress.XtraGrid.Columns.GridColumn
Me.col2customers_lastname = New DevExpress.XtraGrid.Columns.GridColumn
Me.col2customers_firstname = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabAboprocess = New DevExpress.XtraTab.XtraTabPage
Me.gridAboprocess = New DevExpress.XtraGrid.GridControl
Me.GridViewAboprocess = New DevExpress.XtraGrid.Views.Grid.GridView
Me.colProducts_type = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldateStart = New DevExpress.XtraGrid.Columns.GridColumn
Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvdHigh = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvdmedium = New DevExpress.XtraGrid.Columns.GridColumn
Me.coldvdlow = New DevExpress.XtraGrid.Columns.GridColumn
Me.colDvd_Abo = New DevExpress.XtraGrid.Columns.GridColumn
Me.colDvd_Compensation = New DevExpress.XtraGrid.Columns.GridColumn
Me.colDvd_home = New DevExpress.XtraGrid.Columns.GridColumn
Me.colCredit = New DevExpress.XtraGrid.Columns.GridColumn
Me.colcustaborank = New DevExpress.XtraGrid.Columns.GridColumn
Me.colmsgerror = New DevExpress.XtraGrid.Columns.GridColumn
Me.colDvdFind = New DevExpress.XtraGrid.Columns.GridColumn
Me.colWishlist = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabPurchase = New DevExpress.XtraTab.XtraTabPage
Me.GridShoppingOrders = New DevExpress.XtraGrid.GridControl
Me.GridViewShoppingOrders = New DevExpress.XtraGrid.Views.Grid.GridView
Me.shopping_orders_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.customers_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.date_orders = New DevExpress.XtraGrid.Columns.GridColumn
Me.shopping_products_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.quantity = New DevExpress.XtraGrid.Columns.GridColumn
Me.dvd_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.price = New DevExpress.XtraGrid.Columns.GridColumn
Me.shopping_discount_code_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_type = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_state = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_name = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_description = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_bonus = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_url = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_awards = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_viewed = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_image_big = New DevExpress.XtraGrid.Columns.GridColumn
Me.status_name = New DevExpress.XtraGrid.Columns.GridColumn
Me.shopping_discount_value = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabCreditHist = New DevExpress.XtraTab.XtraTabPage
Me.GridCreditHistory = New DevExpress.XtraGrid.GridControl
Me.GridViewCreditHistory = New DevExpress.XtraGrid.Views.Grid.GridView
Me.id = New DevExpress.XtraGrid.Columns.GridColumn
Me.credit = New DevExpress.XtraGrid.Columns.GridColumn
Me.quantity_paid = New DevExpress.XtraGrid.Columns.GridColumn
Me.date_added = New DevExpress.XtraGrid.Columns.GridColumn
Me.action_name = New DevExpress.XtraGrid.Columns.GridColumn
Me.quantity_free = New DevExpress.XtraGrid.Columns.GridColumn
Me.credit_free = New DevExpress.XtraGrid.Columns.GridColumn
Me.ColTotal = New DevExpress.XtraGrid.Columns.GridColumn
Me.ColTotalPaid = New DevExpress.XtraGrid.Columns.GridColumn
Me.colTotalFree = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabCompensation = New DevExpress.XtraTab.XtraTabPage
Me.GridCompensation = New DevExpress.XtraGrid.GridControl
Me.GridViewCompensation = New DevExpress.XtraGrid.Views.Grid.GridView
Me.compensation_date_given = New DevExpress.XtraGrid.Columns.GridColumn
Me.compensation_date_setback = New DevExpress.XtraGrid.Columns.GridColumn
Me.compensation_comment = New DevExpress.XtraGrid.Columns.GridColumn
Me.orders_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.orders_id_given = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_name_given = New DevExpress.XtraGrid.Columns.GridColumn
Me.colCompProducts_name = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabProductsRating = New DevExpress.XtraTab.XtraTabPage
Me.GridProductsRating = New DevExpress.XtraGrid.GridControl
Me.GridViewProductsRating = New DevExpress.XtraGrid.Views.Grid.GridView
Me.products = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_rating = New DevExpress.XtraGrid.Columns.GridColumn
Me.products_rating_date = New DevExpress.XtraGrid.Columns.GridColumn
Me.rating_type = New DevExpress.XtraGrid.Columns.GridColumn
Me.colRatingProducts_name = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabSuspendedHistory = New DevExpress.XtraTab.XtraTabPage
Me.GridSuspendedHistory = New DevExpress.XtraGrid.GridControl
Me.GridViewSuspendedHistory = New DevExpress.XtraGrid.Views.Grid.GridView
Me.suspended_history_date = New DevExpress.XtraGrid.Columns.GridColumn
Me.suspended_history_date_end = New DevExpress.XtraGrid.Columns.GridColumn
Me.abosuspended_history_type = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabVodView = New DevExpress.XtraTab.XtraTabPage
Me.GridViewVod = New DevExpress.XtraGrid.GridControl
Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.gcDate_added = New DevExpress.XtraGrid.Columns.GridColumn
Me.GCLast_modified = New DevExpress.XtraGrid.Columns.GridColumn
Me.GCProducts_title = New DevExpress.XtraGrid.Columns.GridColumn
Me.GCImdb_id = New DevExpress.XtraGrid.Columns.GridColumn
Me.GCCount_ip = New DevExpress.XtraGrid.Columns.GridColumn
Me.GCNb_viewed = New DevExpress.XtraGrid.Columns.GridColumn
Me.GCUsedIp = New DevExpress.XtraGrid.Columns.GridColumn
Me.tabCritiques = New DevExpress.XtraTab.XtraTabPage
Me.lblValueRating = New DevExpress.XtraEditors.LabelControl
Me.lblRating = New DevExpress.XtraEditors.LabelControl
Me.lblValueAverageRatingDvdPost = New DevExpress.XtraEditors.LabelControl
Me.lblAverageRatingDvdPost = New DevExpress.XtraEditors.LabelControl
Me.lblValueNbCritiquePositive = New DevExpress.XtraEditors.LabelControl
Me.lblNbCritiquePositive = New DevExpress.XtraEditors.LabelControl
Me.lblValueNbCrtitiques = New DevExpress.XtraEditors.LabelControl
Me.lblNbCrtitiques = New DevExpress.XtraEditors.LabelControl
Me.lblValueRatingAverage = New DevExpress.XtraEditors.LabelControl
Me.lblRatingAverage = New DevExpress.XtraEditors.LabelControl
Me.GridCritiques = New DevExpress.XtraGrid.GridControl
Me.GridViewCritiques = New DevExpress.XtraGrid.Views.Grid.GridView
Me.tabConfig = New DevExpress.XtraTab.XtraTabPage
Me.btnRefreshTab = New DevExpress.XtraEditors.SimpleButton
Me.ChkListConfig = New DevExpress.XtraEditors.CheckedListBoxControl
Me.LabelControl39 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl40 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit
Me.Label1 = New System.Windows.Forms.Label
Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit
Me.Label3 = New System.Windows.Forms.Label
Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl
Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton
Me.SimpleButton6 = New DevExpress.XtraEditors.SimpleButton
Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton
Me.ComboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit
Me.LabelControl44 = New DevExpress.XtraEditors.LabelControl
Me.DateEdit2 = New DevExpress.XtraEditors.DateEdit
Me.LookUpEdit3 = New DevExpress.XtraEditors.LookUpEdit
Me.Label4 = New System.Windows.Forms.Label
Me.LabelControl45 = New DevExpress.XtraEditors.LabelControl
Me.SimpleButton8 = New DevExpress.XtraEditors.SimpleButton
Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl46 = New DevExpress.XtraEditors.LabelControl
Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit
Me.LabelControl47 = New DevExpress.XtraEditors.LabelControl
Me.DateEdit3 = New DevExpress.XtraEditors.DateEdit
Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit
Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit
Me.LookUpEdit4 = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl59 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl60 = New DevExpress.XtraEditors.LabelControl
Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit
Me.LookUpEdit5 = New DevExpress.XtraEditors.LookUpEdit
Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit
Me.SpinEdit3 = New DevExpress.XtraEditors.SpinEdit
Me.SpinEdit4 = New DevExpress.XtraEditors.SpinEdit
Me.LabelControl61 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl62 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl63 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl64 = New DevExpress.XtraEditors.LabelControl
Me.SpinEdit5 = New DevExpress.XtraEditors.SpinEdit
Me.LabelControl65 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl66 = New DevExpress.XtraEditors.LabelControl
Me.DateEdit4 = New DevExpress.XtraEditors.DateEdit
Me.LookUpEdit6 = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl67 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl68 = New DevExpress.XtraEditors.LabelControl
Me.GridControl2 = New DevExpress.XtraGrid.GridControl
Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit
Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl69 = New DevExpress.XtraEditors.LabelControl
Me.LookUpEdit7 = New DevExpress.XtraEditors.LookUpEdit
Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit
Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit
Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl70 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit13 = New DevExpress.XtraEditors.TextEdit
Me.SpinEdit6 = New DevExpress.XtraEditors.SpinEdit
Me.LabelControl71 = New DevExpress.XtraEditors.LabelControl
Me.CheckEdit3 = New DevExpress.XtraEditors.CheckEdit
Me.TextEdit14 = New DevExpress.XtraEditors.TextEdit
Me.CheckEdit4 = New DevExpress.XtraEditors.CheckEdit
Me.TextEdit15 = New DevExpress.XtraEditors.TextEdit
Me.CheckEdit5 = New DevExpress.XtraEditors.CheckEdit
Me.LabelControl72 = New DevExpress.XtraEditors.LabelControl
Me.CheckEdit6 = New DevExpress.XtraEditors.CheckEdit
Me.TextEdit16 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl73 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl74 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit17 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl75 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl76 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl77 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit18 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl78 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl79 = New DevExpress.XtraEditors.LabelControl
Me.LookUpEdit8 = New DevExpress.XtraEditors.LookUpEdit
Me.LabelControl80 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl81 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl82 = New DevExpress.XtraEditors.LabelControl
Me.LookUpEdit9 = New DevExpress.XtraEditors.LookUpEdit
Me.DateEdit5 = New DevExpress.XtraEditors.DateEdit
Me.LabelControl83 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit19 = New DevExpress.XtraEditors.TextEdit
Me.HyperLinkEdit1 = New DevExpress.XtraEditors.HyperLinkEdit
Me.TextEdit20 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl84 = New DevExpress.XtraEditors.LabelControl
Me.CheckEdit7 = New DevExpress.XtraEditors.CheckEdit
Me.LabelControl85 = New DevExpress.XtraEditors.LabelControl
Me.DateEdit6 = New DevExpress.XtraEditors.DateEdit
Me.TextEdit21 = New DevExpress.XtraEditors.TextEdit
Me.TextEdit22 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl86 = New DevExpress.XtraEditors.LabelControl
Me.TextEdit23 = New DevExpress.XtraEditors.TextEdit
Me.LabelControl87 = New DevExpress.XtraEditors.LabelControl
Me.SimpleButton9 = New DevExpress.XtraEditors.SimpleButton
Me.SimpleButton10 = New DevExpress.XtraEditors.SimpleButton
Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl
Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl
Me.GridControl3 = New DevExpress.XtraGrid.GridControl
Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
coldvd_finally_arrived_mail3 = New DevExpress.XtraGrid.Columns.GridColumn
GridchkAbo = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
GridchkBlackList = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
ColTypePayment = New DevExpress.XtraGrid.Columns.GridColumn
ColPayment_id = New DevExpress.XtraGrid.Columns.GridColumn
ColAmountPay = New DevExpress.XtraGrid.Columns.GridColumn
ColDateAdded = New DevExpress.XtraGrid.Columns.GridColumn
ColIdMatching = New DevExpress.XtraGrid.Columns.GridColumn
coldvd_to_send = New DevExpress.XtraGrid.Columns.GridColumn
CType(Me.PrintSystem1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MainDataSet,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbViewListRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtQuickSearchRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbReportListRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbFilterListRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDefaultListRepos,System.ComponentModel.ISupportInitialize).BeginInit
CType(GridchkAbo,System.ComponentModel.ISupportInitialize).BeginInit
CType(GridchkBlackList,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabAboProcessOld.SuspendLayout
CType(Me.GridAboprocessOld,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewAboprocessOld,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNextCredit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNextPrice.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.objDS,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewGodson,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridSon,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewSon,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryISponsorCustomers_id,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabMailHistory.SuspendLayout
CType(Me.grpContEmail,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewMail,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridCustServ,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.gridViewCustServ,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabDroselia.SuspendLayout
CType(Me.txtDroselia.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridDroselia,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewDroselia,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabPaymentMovements.SuspendLayout
CType(Me.GCBankAccountMovement,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCBankAccountMovement.SuspendLayout
CType(Me.GridBankAccountMovements,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewBankAccountMovements,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryCmbMatching,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridOrders,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewOrders,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryIbtnCheckOrder,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridABO,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewABO,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryItemLookUpEdit5,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabPayment.SuspendLayout
CType(Me.GridPayment,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewPayment,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.checkOpenPayment.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GroupOgone,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupOgone.SuspendLayout
CType(Me.PanelOgone,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelOgone.SuspendLayout
CType(Me.txt_cc_expiration_date2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmb_cc_expiration_status2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txt_cc_card_type2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txt_cc_card_no2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txt_cc_owner2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GroupDomiciliation,System.ComponentModel.ISupportInitialize).BeginInit
Me.GroupDomiciliation.SuspendLayout
CType(Me.panelDomiciliation,System.ComponentModel.ISupportInitialize).BeginInit
Me.panelDomiciliation.SuspendLayout
CType(Me.txtDomAcctNumber.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDomNumber.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDomDebiterName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDomStatus.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.CalcEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.CalcEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbPayMethod.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridWishList,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewWishList,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.btnSendIt,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.checkAvailibility,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabCustServ.SuspendLayout
CType(Me.PanelControl7,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl7.SuspendLayout
CType(Me.PanelControl8,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl8.SuspendLayout
CType(Me.LayoutCustServ,System.ComponentModel.ISupportInitialize).BeginInit
Me.LayoutCustServ.SuspendLayout
CType(Me.txtCustServ_Response_Message.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCustServ_DVD_ID.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCustServ_Products_id.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCustServ_OrderID.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCustServ_CustDate.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCustServ_CustDate.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCustServ_Subject.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LCGMisc,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LayoutControlItem7,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LayoutControlItem6,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LayoutControlItem8,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LayoutControlGroup3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LayoutControlItem5,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LayoutControlItem4,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LCGResponse,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LayoutControlItem11,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LayoutControlItem3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GCCustServ,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCCustServ.SuspendLayout
CType(Me.chkCustServSendMail.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridWishListAssigned,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewWishListAssigned,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryIbtnAddDVD,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabOrdersHistor.SuspendLayout
CType(Me.SplitContainerOrders,System.ComponentModel.ISupportInitialize).BeginInit
Me.SplitContainerOrders.SuspendLayout
CType(Me.GridOrdersStatusHistory,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewOrdersHistory,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewSearch,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryICustomersCustomers_id,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabAboHistory.SuspendLayout
Me.tabWishList.SuspendLayout
CType(Me.GCWishlistAssigned,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCWishlistAssigned.SuspendLayout
CType(Me.PanelControl11,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl11.SuspendLayout
CType(Me.PanelDetailWishlist,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelDetailWishlist.SuspendLayout
CType(Me.gridInfoAdult,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewInfoAdult,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.gridInfoNorm,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewInfoNorm,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabMain.SuspendLayout
CType(Me.chksleep.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ChkCreditCombined.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkFt.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GCACtPhone,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCACtPhone.SuspendLayout
CType(Me.MemoOtherReason.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbPhoneActivDelete.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateCallPhoneActivation.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateCallPhoneActivation.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GCAboInfo,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCAboInfo.SuspendLayout
CType(Me.cmbDiscountActivation.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDiscType.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEndOfHoliday.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEndOfHoliday.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbSuspended.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtRegistrationStep.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDVDAdultAtHome.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDiscRecurring.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDiscRecurring.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkAutoStop.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbNextDiscCode.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkMultiShipment.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbNextABO.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDVDNormAtHome.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDVDAdult.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDVDNorm.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtABOCredit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtAbo_ValidityTo.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtAbo_ValidityTo.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbABO.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GCadresse,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCadresse.SuspendLayout
CType(Me.txtDate_added_Current.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridAddress,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewAddress,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDeliveryFirstName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDeliveryLastName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbDeliverycountry.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDeliveryCity.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDeliveryPostCode.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDeliveryAddr.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GCcustomersInfo,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCcustomersInfo.SuspendLayout
CType(Me.chkCreditReceivedBySite.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkOnly_VOD.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtLast_logon.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtPtSponsorShip.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkRedListed.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtComment.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkBlackListed.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtYearsOld.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkNewsLetterPartner.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.chkNewsLetter.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtGender.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtWishListKind.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtNbrOfLogons.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbEntity.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.cmbLanguage.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDateCreated.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtDateCreated.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtTel.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtEMail.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtTelEvening.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtABO.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateBirthday.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateBirthday.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtFirstName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtLastName.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCustomers_id.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabSearch.SuspendLayout
CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).BeginInit
Me.PanelControl1.SuspendLayout
CType(Me.TxtCustomers_NumComm.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtcustomers_domiciliation_number_search.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtcustomers_postcode_search.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtcustomers_address_street_search.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtcustomers_email_address_search.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtcustomers_name_search.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtcustomers_id_search.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.XTabCustomers,System.ComponentModel.ISupportInitialize).BeginInit
Me.XTabCustomers.SuspendLayout
Me.tabComment.SuspendLayout
CType(Me.MemoCustomersComment.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridCustComment,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewCustComment,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MemoInsertComment.Properties,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabCalls.SuspendLayout
Me.tabMessagerie.SuspendLayout
Me.tabSponsorShip.SuspendLayout
CType(Me.GCCodeLinked,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCCodeLinked.SuspendLayout
CType(Me.GridCodeLinked,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewCodeLinked,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GCSponsonCard,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCSponsonCard.SuspendLayout
CType(Me.txtCard5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCard4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCard3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCard2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.txtCard1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.grpCustomersPoint,System.ComponentModel.ISupportInitialize).BeginInit
Me.grpCustomersPoint.SuspendLayout
CType(Me.GridCustPointHistory,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewCustPointHistory,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GCGift,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCGift.SuspendLayout
CType(Me.GridGift,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewGift,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GCSponsorShip,System.ComponentModel.ISupportInitialize).BeginInit
Me.GCSponsorShip.SuspendLayout
CType(Me.GridGodFather,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridviewGodFather,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.RepositoryISponsorGodCustomers_id,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabAboprocess.SuspendLayout
CType(Me.gridAboprocess,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewAboprocess,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabPurchase.SuspendLayout
CType(Me.GridShoppingOrders,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewShoppingOrders,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabCreditHist.SuspendLayout
CType(Me.GridCreditHistory,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewCreditHistory,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabCompensation.SuspendLayout
CType(Me.GridCompensation,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewCompensation,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabProductsRating.SuspendLayout
CType(Me.GridProductsRating,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewProductsRating,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabSuspendedHistory.SuspendLayout
CType(Me.GridSuspendedHistory,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewSuspendedHistory,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabVodView.SuspendLayout
CType(Me.GridViewVod,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabCritiques.SuspendLayout
CType(Me.GridCritiques,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridViewCritiques,System.ComponentModel.ISupportInitialize).BeginInit
Me.tabConfig.SuspendLayout
CType(Me.ChkListConfig,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.MemoEdit2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit1.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.ComboBoxEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit2.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SpinEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit3.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.CheckEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.CheckEdit2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SpinEdit2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SpinEdit3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SpinEdit4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SpinEdit5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit4.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridControl2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView2,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit8.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit9.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit10.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit11.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit12.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit13.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.SpinEdit6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.CheckEdit3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit14.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.CheckEdit4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit15.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.CheckEdit5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.CheckEdit6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit16.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit17.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit18.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit8.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.LookUpEdit9.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit5.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit19.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.HyperLinkEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit20.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.CheckEdit7.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit6.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.DateEdit6.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit21.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit22.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.TextEdit23.Properties,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridControl3,System.ComponentModel.ISupportInitialize).BeginInit
CType(Me.GridView3,System.ComponentModel.ISupportInitialize).BeginInit
Me.SuspendLayout
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
Me.StatusBar1.Location = New System.Drawing.Point(0, 870)
Me.StatusBar1.Size = New System.Drawing.Size(1262, 12)
'
'coldvd_finally_arrived_mail3
'
coldvd_finally_arrived_mail3.Caption = "dvd_finally_arrived_mail"
coldvd_finally_arrived_mail3.FieldName = "dvd_finally_arrived_mail"
coldvd_finally_arrived_mail3.Name = "coldvd_finally_arrived_mail3"
coldvd_finally_arrived_mail3.OptionsColumn.AllowEdit = false
coldvd_finally_arrived_mail3.OptionsColumn.ReadOnly = true
'
'GridchkAbo
'
GridchkAbo.AutoHeight = false
GridchkAbo.Name = "GridchkAbo"
GridchkAbo.ValueChecked = 1
GridchkAbo.ValueUnchecked = 0
'
'GridchkBlackList
'
GridchkBlackList.AutoHeight = false
GridchkBlackList.Name = "GridchkBlackList"
GridchkBlackList.ValueChecked = 1
GridchkBlackList.ValueUnchecked = 0
'
'ColTypePayment
'
ColTypePayment.Caption = "type payment "
ColTypePayment.FieldName = "type_payment"
ColTypePayment.Name = "ColTypePayment"
ColTypePayment.Visible = true
ColTypePayment.VisibleIndex = 0
ColTypePayment.Width = 81
'
'ColPayment_id
'
ColPayment_id.Caption = "ID"
ColPayment_id.FieldName = "id"
ColPayment_id.Name = "ColPayment_id"
ColPayment_id.Visible = true
ColPayment_id.VisibleIndex = 1
'
'ColAmountPay
'
ColAmountPay.Caption = "amount"
ColAmountPay.FieldName = "amount"
ColAmountPay.Name = "ColAmountPay"
ColAmountPay.Visible = true
ColAmountPay.VisibleIndex = 2
'
'ColDateAdded
'
ColDateAdded.Caption = "date_added"
ColDateAdded.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
ColDateAdded.FieldName = "date_added"
ColDateAdded.Name = "ColDateAdded"
ColDateAdded.Visible = true
ColDateAdded.VisibleIndex = 4
'
'ColIdMatching
'
ColIdMatching.Caption = "id matching"
ColIdMatching.FieldName = "id_matching"
ColIdMatching.Name = "ColIdMatching"
ColIdMatching.Visible = true
ColIdMatching.VisibleIndex = 8
'
'coldvd_to_send
'
coldvd_to_send.Caption = "dvd_to_send"
coldvd_to_send.FieldName = "dvd_to_send"
coldvd_to_send.Name = "coldvd_to_send"
coldvd_to_send.OptionsColumn.AllowEdit = false
coldvd_to_send.OptionsColumn.FixedWidth = true
coldvd_to_send.OptionsColumn.ReadOnly = true
coldvd_to_send.Visible = true
coldvd_to_send.VisibleIndex = 3
coldvd_to_send.Width = 117
'
'tabAboProcessOld
'
Me.tabAboProcessOld.Controls.Add(Me.GridAboprocessOld)
Me.tabAboProcessOld.Name = "tabAboProcessOld"
Me.tabAboProcessOld.Size = New System.Drawing.Size(1505, 905)
Me.tabAboProcessOld.Text = "aboProcess Old"
'
'GridAboprocessOld
'
Me.GridAboprocessOld.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridAboprocessOld.EmbeddedNavigator.Name = ""
Me.GridAboprocessOld.FormsUseDefaultLookAndFeel = false
Me.GridAboprocessOld.Location = New System.Drawing.Point(0, 0)
Me.GridAboprocessOld.MainView = Me.GridViewAboprocessOld
Me.GridAboprocessOld.Name = "GridAboprocessOld"
Me.GridAboprocessOld.Size = New System.Drawing.Size(1505, 905)
Me.GridAboprocessOld.TabIndex = 0
Me.GridAboprocessOld.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAboprocessOld})
'
'GridViewAboprocessOld
'
Me.GridViewAboprocessOld.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.dvd_norm_to_send, Me.dvd_adult_to_send, Me.dvd_highsent, Me.dvd_mediumsent, Me.dvd_lowsent, Me.dvd_norm_abo, Me.dvd_adult_abo, Me.dvd_norm_compensation, Me.dvd_adult_compensation, Me.dvd_norm_home, Me.dvd_adult_home, Me.creditABoProcess, Me.customer_abo_rank, Me.msgerror, Me.nbdvdfindnorm, Me.nbdvdfindadult, Me.nbwishlistadult, Me.nbwishlistnorm, Me.label, Me.date_start})
Me.GridViewAboprocessOld.GridControl = Me.GridAboprocessOld
Me.GridViewAboprocessOld.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewAboprocessOld.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
Me.GridViewAboprocessOld.Name = "GridViewAboprocessOld"
Me.GridViewAboprocessOld.OptionsView.ColumnAutoWidth = false
Me.GridViewAboprocessOld.OptionsView.ShowFooter = true
'
'dvd_norm_to_send
'
Me.dvd_norm_to_send.Caption = "dvd_norm_to_send"
Me.dvd_norm_to_send.FieldName = "dvd_norm_to_send"
Me.dvd_norm_to_send.Name = "dvd_norm_to_send"
Me.dvd_norm_to_send.OptionsColumn.AllowEdit = false
Me.dvd_norm_to_send.OptionsColumn.FixedWidth = true
Me.dvd_norm_to_send.OptionsColumn.ReadOnly = true
Me.dvd_norm_to_send.Visible = true
Me.dvd_norm_to_send.VisibleIndex = 2
Me.dvd_norm_to_send.Width = 117
'
'dvd_adult_to_send
'
Me.dvd_adult_to_send.Caption = "dvd_adult_to_send"
Me.dvd_adult_to_send.FieldName = "dvd_adult_to_send"
Me.dvd_adult_to_send.Name = "dvd_adult_to_send"
Me.dvd_adult_to_send.OptionsColumn.AllowEdit = false
Me.dvd_adult_to_send.OptionsColumn.FixedWidth = true
Me.dvd_adult_to_send.OptionsColumn.ReadOnly = true
Me.dvd_adult_to_send.Visible = true
Me.dvd_adult_to_send.VisibleIndex = 3
Me.dvd_adult_to_send.Width = 125
'
'dvd_highsent
'
Me.dvd_highsent.Caption = "dvd_highsent"
Me.dvd_highsent.FieldName = "dvd_highsent"
Me.dvd_highsent.Name = "dvd_highsent"
Me.dvd_highsent.OptionsColumn.AllowEdit = false
Me.dvd_highsent.OptionsColumn.FixedWidth = true
Me.dvd_highsent.OptionsColumn.ReadOnly = true
Me.dvd_highsent.Visible = true
Me.dvd_highsent.VisibleIndex = 4
Me.dvd_highsent.Width = 104
'
'dvd_mediumsent
'
Me.dvd_mediumsent.Caption = "dvd_mediumsent"
Me.dvd_mediumsent.FieldName = "dvd_mediumsent"
Me.dvd_mediumsent.Name = "dvd_mediumsent"
Me.dvd_mediumsent.OptionsColumn.AllowEdit = false
Me.dvd_mediumsent.OptionsColumn.FixedWidth = true
Me.dvd_mediumsent.OptionsColumn.ReadOnly = true
Me.dvd_mediumsent.Visible = true
Me.dvd_mediumsent.VisibleIndex = 5
Me.dvd_mediumsent.Width = 107
'
'dvd_lowsent
'
Me.dvd_lowsent.Caption = "dvd_lowsent"
Me.dvd_lowsent.FieldName = "dvd_lowsent"
Me.dvd_lowsent.Name = "dvd_lowsent"
Me.dvd_lowsent.OptionsColumn.AllowEdit = false
Me.dvd_lowsent.OptionsColumn.FixedWidth = true
Me.dvd_lowsent.OptionsColumn.ReadOnly = true
Me.dvd_lowsent.Visible = true
Me.dvd_lowsent.VisibleIndex = 6
'
'dvd_norm_abo
'
Me.dvd_norm_abo.Caption = "dvd_norm_abo"
Me.dvd_norm_abo.FieldName = "dvd_norm_abo"
Me.dvd_norm_abo.Name = "dvd_norm_abo"
Me.dvd_norm_abo.OptionsColumn.AllowEdit = false
Me.dvd_norm_abo.OptionsColumn.FixedWidth = true
Me.dvd_norm_abo.OptionsColumn.ReadOnly = true
Me.dvd_norm_abo.Visible = true
Me.dvd_norm_abo.VisibleIndex = 7
Me.dvd_norm_abo.Width = 104
'
'dvd_adult_abo
'
Me.dvd_adult_abo.Caption = "dvd_adult_abo"
Me.dvd_adult_abo.FieldName = "dvd_adult_abo"
Me.dvd_adult_abo.Name = "dvd_adult_abo"
Me.dvd_adult_abo.OptionsColumn.AllowEdit = false
Me.dvd_adult_abo.OptionsColumn.FixedWidth = true
Me.dvd_adult_abo.OptionsColumn.ReadOnly = true
Me.dvd_adult_abo.Visible = true
Me.dvd_adult_abo.VisibleIndex = 8
Me.dvd_adult_abo.Width = 95
'
'dvd_norm_compensation
'
Me.dvd_norm_compensation.Caption = "dvd_norm_compensation"
Me.dvd_norm_compensation.FieldName = "dvd_norm_compensation"
Me.dvd_norm_compensation.Name = "dvd_norm_compensation"
Me.dvd_norm_compensation.OptionsColumn.AllowEdit = false
Me.dvd_norm_compensation.OptionsColumn.FixedWidth = true
Me.dvd_norm_compensation.OptionsColumn.ReadOnly = true
Me.dvd_norm_compensation.Visible = true
Me.dvd_norm_compensation.VisibleIndex = 9
Me.dvd_norm_compensation.Width = 130
'
'dvd_adult_compensation
'
Me.dvd_adult_compensation.Caption = "dvd_adult_compensation"
Me.dvd_adult_compensation.FieldName = "dvd_adult_compensation"
Me.dvd_adult_compensation.Name = "dvd_adult_compensation"
Me.dvd_adult_compensation.OptionsColumn.AllowEdit = false
Me.dvd_adult_compensation.OptionsColumn.FixedWidth = true
Me.dvd_adult_compensation.OptionsColumn.ReadOnly = true
Me.dvd_adult_compensation.Visible = true
Me.dvd_adult_compensation.VisibleIndex = 10
Me.dvd_adult_compensation.Width = 155
'
'dvd_norm_home
'
Me.dvd_norm_home.Caption = "dvd_norm_home"
Me.dvd_norm_home.FieldName = "dvd_norm_home"
Me.dvd_norm_home.Name = "dvd_norm_home"
Me.dvd_norm_home.OptionsColumn.AllowEdit = false
Me.dvd_norm_home.OptionsColumn.FixedWidth = true
Me.dvd_norm_home.OptionsColumn.ReadOnly = true
Me.dvd_norm_home.Visible = true
Me.dvd_norm_home.VisibleIndex = 11
Me.dvd_norm_home.Width = 97
'
'dvd_adult_home
'
Me.dvd_adult_home.Caption = "dvd_adult_home"
Me.dvd_adult_home.FieldName = "dvd_adult_home"
Me.dvd_adult_home.Name = "dvd_adult_home"
Me.dvd_adult_home.OptionsColumn.AllowEdit = false
Me.dvd_adult_home.OptionsColumn.FixedWidth = true
Me.dvd_adult_home.OptionsColumn.ReadOnly = true
Me.dvd_adult_home.Visible = true
Me.dvd_adult_home.VisibleIndex = 12
Me.dvd_adult_home.Width = 127
'
'creditABoProcess
'
Me.creditABoProcess.Caption = " credit"
Me.creditABoProcess.FieldName = " credit"
Me.creditABoProcess.Name = "creditABoProcess"
Me.creditABoProcess.OptionsColumn.AllowEdit = false
Me.creditABoProcess.OptionsColumn.FixedWidth = true
Me.creditABoProcess.OptionsColumn.ReadOnly = true
'
'customer_abo_rank
'
Me.customer_abo_rank.Caption = "customer_abo_rank"
Me.customer_abo_rank.FieldName = "customer_abo_rank"
Me.customer_abo_rank.Name = "customer_abo_rank"
Me.customer_abo_rank.OptionsColumn.AllowEdit = false
Me.customer_abo_rank.OptionsColumn.FixedWidth = true
Me.customer_abo_rank.OptionsColumn.ReadOnly = true
Me.customer_abo_rank.Width = 123
'
'msgerror
'
Me.msgerror.Caption = "msgerror"
Me.msgerror.FieldName = "msgerror"
Me.msgerror.Name = "msgerror"
Me.msgerror.OptionsColumn.AllowEdit = false
Me.msgerror.OptionsColumn.FixedWidth = true
Me.msgerror.OptionsColumn.ReadOnly = true
Me.msgerror.Visible = true
Me.msgerror.VisibleIndex = 13
'
'nbdvdfindnorm
'
Me.nbdvdfindnorm.Caption = "nbdvdfindnorm"
Me.nbdvdfindnorm.FieldName = "nbdvdfindnorm"
Me.nbdvdfindnorm.Name = "nbdvdfindnorm"
Me.nbdvdfindnorm.OptionsColumn.AllowEdit = false
Me.nbdvdfindnorm.OptionsColumn.FixedWidth = true
Me.nbdvdfindnorm.OptionsColumn.ReadOnly = true
Me.nbdvdfindnorm.Visible = true
Me.nbdvdfindnorm.VisibleIndex = 14
Me.nbdvdfindnorm.Width = 94
'
'nbdvdfindadult
'
Me.nbdvdfindadult.Caption = "nbdvdfindadult"
Me.nbdvdfindadult.FieldName = "nbdvdfindadult"
Me.nbdvdfindadult.Name = "nbdvdfindadult"
Me.nbdvdfindadult.OptionsColumn.AllowEdit = false
Me.nbdvdfindadult.OptionsColumn.FixedWidth = true
Me.nbdvdfindadult.OptionsColumn.ReadOnly = true
Me.nbdvdfindadult.Visible = true
Me.nbdvdfindadult.VisibleIndex = 15
Me.nbdvdfindadult.Width = 94
'
'nbwishlistadult
'
Me.nbwishlistadult.Caption = "nbwishlistadult"
Me.nbwishlistadult.FieldName = "nbwishlistadult"
Me.nbwishlistadult.Name = "nbwishlistadult"
Me.nbwishlistadult.OptionsColumn.AllowEdit = false
Me.nbwishlistadult.OptionsColumn.FixedWidth = true
Me.nbwishlistadult.OptionsColumn.ReadOnly = true
Me.nbwishlistadult.Visible = true
Me.nbwishlistadult.VisibleIndex = 16
Me.nbwishlistadult.Width = 81
'
'nbwishlistnorm
'
Me.nbwishlistnorm.Caption = "nbwishlistnorm"
Me.nbwishlistnorm.FieldName = "nbwishlistnorm"
Me.nbwishlistnorm.Name = "nbwishlistnorm"
Me.nbwishlistnorm.OptionsColumn.AllowEdit = false
Me.nbwishlistnorm.OptionsColumn.FixedWidth = true
Me.nbwishlistnorm.OptionsColumn.ReadOnly = true
Me.nbwishlistnorm.Visible = true
Me.nbwishlistnorm.VisibleIndex = 17
Me.nbwishlistnorm.Width = 83
'
'label
'
Me.label.Caption = "status"
Me.label.FieldName = "label"
Me.label.Name = "label"
Me.label.OptionsColumn.AllowEdit = false
Me.label.OptionsColumn.FixedWidth = true
Me.label.OptionsColumn.ReadOnly = true
Me.label.Visible = true
Me.label.VisibleIndex = 1
'
'date_start
'
Me.date_start.Caption = "date_start"
Me.date_start.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.date_start.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.date_start.FieldName = "date_start"
Me.date_start.Name = "date_start"
Me.date_start.OptionsColumn.AllowEdit = false
Me.date_start.OptionsColumn.FixedWidth = true
Me.date_start.OptionsColumn.ReadOnly = true
Me.date_start.Visible = true
Me.date_start.VisibleIndex = 0
'
'txtNextCredit
'
Me.txtNextCredit.Enabled = false
Me.txtNextCredit.Location = New System.Drawing.Point(836, 16)
Me.txtNextCredit.Name = "txtNextCredit"
Me.txtNextCredit.Properties.ReadOnly = true
Me.txtNextCredit.Size = New System.Drawing.Size(95, 22)
Me.txtNextCredit.TabIndex = 21
'
'txtNextPrice
'
Me.txtNextPrice.Enabled = false
Me.txtNextPrice.Location = New System.Drawing.Point(1025, 16)
Me.txtNextPrice.Name = "txtNextPrice"
Me.txtNextPrice.Properties.ReadOnly = true
Me.txtNextPrice.Size = New System.Drawing.Size(95, 22)
Me.txtNextPrice.TabIndex = 23
'
'objDS
'
Me.objDS.DataSetName = "dsCustomerMaint"
Me.objDS.Locale = New System.Globalization.CultureInfo("en-US")
Me.objDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
'
'colcustomers2_id6
'
Me.colcustomers2_id6.Caption = "customers_id"
Me.colcustomers2_id6.FieldName = "customers_id"
Me.colcustomers2_id6.Name = "colcustomers2_id6"
Me.colcustomers2_id6.OptionsColumn.AllowEdit = false
Me.colcustomers2_id6.OptionsColumn.ReadOnly = true
'
'GridViewGodson
'
Me.GridViewGodson.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.date_used, Me.sponsor})
Me.GridViewGodson.GridControl = Me.GridSon
Me.GridViewGodson.Name = "GridViewGodson"
'
'date_used
'
Me.date_used.Caption = "date_used"
Me.date_used.FieldName = "date"
Me.date_used.Name = "date_used"
Me.date_used.Visible = true
Me.date_used.VisibleIndex = 0
Me.date_used.Width = 140
'
'sponsor
'
Me.sponsor.Caption = "sponsor"
Me.sponsor.FieldName = "son_id"
Me.sponsor.Name = "sponsor"
Me.sponsor.Visible = true
Me.sponsor.VisibleIndex = 1
Me.sponsor.Width = 888
'
'GridSon
'
Me.GridSon.EmbeddedNavigator.Name = ""
Me.GridSon.FormsUseDefaultLookAndFeel = false
Me.GridSon.Location = New System.Drawing.Point(0, 42)
Me.GridSon.MainView = Me.GridViewSon
Me.GridSon.Name = "GridSon"
Me.GridSon.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryISponsorCustomers_id})
Me.GridSon.Size = New System.Drawing.Size(732, 264)
Me.GridSon.TabIndex = 0
Me.GridSon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSon, Me.GridViewGodson})
'
'GridViewSon
'
Me.GridViewSon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.used_date, Me.colSon_id, Me.son_abo_type, Me.points, Me.customers_lastname, Me.customers_firstname})
Me.GridViewSon.CustomizationFormBounds = New System.Drawing.Rectangle(1382, 593, 218, 205)
Me.GridViewSon.GridControl = Me.GridSon
Me.GridViewSon.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewSon.Name = "GridViewSon"
'
'used_date
'
Me.used_date.Caption = "used_date"
Me.used_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.used_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.used_date.FieldName = "date"
Me.used_date.Name = "used_date"
Me.used_date.OptionsColumn.AllowEdit = false
Me.used_date.Visible = true
Me.used_date.VisibleIndex = 1
Me.used_date.Width = 70
'
'colSon_id
'
Me.colSon_id.Caption = "customers_id"
Me.colSon_id.ColumnEdit = Me.RepositoryISponsorCustomers_id
Me.colSon_id.FieldName = "customers_id"
Me.colSon_id.Name = "colSon_id"
Me.colSon_id.Visible = true
Me.colSon_id.VisibleIndex = 0
'
'RepositoryISponsorCustomers_id
'
Me.RepositoryISponsorCustomers_id.AutoHeight = false
Me.RepositoryISponsorCustomers_id.Name = "RepositoryISponsorCustomers_id"
'
'son_abo_type
'
Me.son_abo_type.Caption = "abo_type"
Me.son_abo_type.FieldName = "son_abo_type"
Me.son_abo_type.Name = "son_abo_type"
Me.son_abo_type.OptionsColumn.AllowEdit = false
Me.son_abo_type.Visible = true
Me.son_abo_type.VisibleIndex = 4
Me.son_abo_type.Width = 107
'
'points
'
Me.points.Caption = "points"
Me.points.FieldName = "points"
Me.points.Name = "points"
Me.points.OptionsColumn.AllowEdit = false
Me.points.Visible = true
Me.points.VisibleIndex = 5
Me.points.Width = 41
'
'customers_lastname
'
Me.customers_lastname.Caption = "customers_lastname"
Me.customers_lastname.FieldName = "customers_lastname"
Me.customers_lastname.Name = "customers_lastname"
Me.customers_lastname.OptionsColumn.AllowEdit = false
Me.customers_lastname.Visible = true
Me.customers_lastname.VisibleIndex = 2
Me.customers_lastname.Width = 142
'
'customers_firstname
'
Me.customers_firstname.Caption = "customers_firstname"
Me.customers_firstname.FieldName = "customers_firstname"
Me.customers_firstname.Name = "customers_firstname"
Me.customers_firstname.OptionsColumn.AllowEdit = false
Me.customers_firstname.Visible = true
Me.customers_firstname.VisibleIndex = 3
Me.customers_firstname.Width = 229
'
'colpayment_offline_request_id2
'
Me.colpayment_offline_request_id2.Caption = "payment_offline_request_id"
Me.colpayment_offline_request_id2.FieldName = "payment_offline_request_id"
Me.colpayment_offline_request_id2.Name = "colpayment_offline_request_id2"
Me.colpayment_offline_request_id2.Visible = true
Me.colpayment_offline_request_id2.VisibleIndex = 0
'
'colamount3
'
Me.colamount3.Caption = "amount"
Me.colamount3.FieldName = "amount"
Me.colamount3.Name = "colamount3"
Me.colamount3.Visible = true
Me.colamount3.VisibleIndex = 1
'
'coldvdpost_bank_account1
'
Me.coldvdpost_bank_account1.Caption = "dvdpost_bank_account"
Me.coldvdpost_bank_account1.FieldName = "dvdpost_bank_account"
Me.coldvdpost_bank_account1.Name = "coldvdpost_bank_account1"
Me.coldvdpost_bank_account1.Visible = true
Me.coldvdpost_bank_account1.VisibleIndex = 2
'
'colcommunication2
'
Me.colcommunication2.Caption = "communication"
Me.colcommunication2.FieldName = "communication"
Me.colcommunication2.Name = "colcommunication2"
Me.colcommunication2.Visible = true
Me.colcommunication2.VisibleIndex = 3
'
'colcustomers_id
'
Me.colcustomers_id.Caption = "customers_id"
Me.colcustomers_id.FieldName = "customers_id"
Me.colcustomers_id.Name = "colcustomers_id"
Me.colcustomers_id.Visible = true
Me.colcustomers_id.VisibleIndex = 4
'
'coldate_added
'
Me.coldate_added.Caption = "date_added"
Me.coldate_added.FieldName = "date_added"
Me.coldate_added.Name = "coldate_added"
Me.coldate_added.Visible = true
Me.coldate_added.VisibleIndex = 5
'
'colpayment_offline_status1
'
Me.colpayment_offline_status1.Caption = "payment_offline_status"
Me.colpayment_offline_status1.FieldName = "payment_offline_status"
Me.colpayment_offline_status1.Name = "colpayment_offline_status1"
Me.colpayment_offline_status1.Visible = true
Me.colpayment_offline_status1.VisibleIndex = 6
'
'collast_modified
'
Me.collast_modified.Caption = "last_modified"
Me.collast_modified.FieldName = "last_modified"
Me.collast_modified.Name = "collast_modified"
'
'colcomment
'
Me.colcomment.Caption = "comment"
Me.colcomment.FieldName = "comment"
Me.colcomment.Name = "colcomment"
Me.colcomment.Visible = true
Me.colcomment.VisibleIndex = 7
'
'coldomiciliation_payment_id3
'
Me.coldomiciliation_payment_id3.Caption = "domiciliation_payment_id"
Me.coldomiciliation_payment_id3.FieldName = "domiciliation_payment_id"
Me.coldomiciliation_payment_id3.Name = "coldomiciliation_payment_id3"
Me.coldomiciliation_payment_id3.Visible = true
Me.coldomiciliation_payment_id3.VisibleIndex = 8
'
'cologone_payment_id3
'
Me.cologone_payment_id3.Caption = "ogone_payment_id"
Me.cologone_payment_id3.FieldName = "ogone_payment_id"
Me.cologone_payment_id3.Name = "cologone_payment_id3"
Me.cologone_payment_id3.Visible = true
Me.cologone_payment_id3.VisibleIndex = 9
'
'colaccount_movements_id1
'
Me.colaccount_movements_id1.Caption = "account_movements_id"
Me.colaccount_movements_id1.FieldName = "account_movements_id"
Me.colaccount_movements_id1.Name = "colaccount_movements_id1"
Me.colaccount_movements_id1.Visible = true
Me.colaccount_movements_id1.VisibleIndex = 10
'
'coldate_closed1
'
Me.coldate_closed1.Caption = "date_closed"
Me.coldate_closed1.FieldName = "date_closed"
Me.coldate_closed1.Name = "coldate_closed1"
Me.coldate_closed1.Visible = true
Me.coldate_closed1.VisibleIndex = 11
'
'coldate_closed_eurofides1
'
Me.coldate_closed_eurofides1.Caption = "date_closed_eurofides"
Me.coldate_closed_eurofides1.FieldName = "date_closed_eurofides"
Me.coldate_closed_eurofides1.Name = "coldate_closed_eurofides1"
Me.coldate_closed_eurofides1.Visible = true
Me.coldate_closed_eurofides1.VisibleIndex = 12
'
'colreason_pk_name1
'
Me.colreason_pk_name1.Caption = "reason_pk_name"
Me.colreason_pk_name1.FieldName = "reason_pk_name"
Me.colreason_pk_name1.Name = "colreason_pk_name1"
Me.colreason_pk_name1.Visible = true
Me.colreason_pk_name1.VisibleIndex = 13
'
'colreason_pk_value1
'
Me.colreason_pk_value1.Caption = "reason_pk_value"
Me.colreason_pk_value1.FieldName = "reason_pk_value"
Me.colreason_pk_value1.Name = "colreason_pk_value1"
Me.colreason_pk_value1.Visible = true
Me.colreason_pk_value1.VisibleIndex = 14
'
'colamount_received1
'
Me.colamount_received1.Caption = "amount_received"
Me.colamount_received1.FieldName = "amount_received"
Me.colamount_received1.Name = "colamount_received1"
Me.colamount_received1.Visible = true
Me.colamount_received1.VisibleIndex = 15
'
'coldomiciliation_payment_id4
'
Me.coldomiciliation_payment_id4.Caption = "domiciliation_payment_id"
Me.coldomiciliation_payment_id4.FieldName = "domiciliation_payment_id"
Me.coldomiciliation_payment_id4.Name = "coldomiciliation_payment_id4"
Me.coldomiciliation_payment_id4.Visible = true
Me.coldomiciliation_payment_id4.VisibleIndex = 0
'
'coldomiciliation_payment_date1
'
Me.coldomiciliation_payment_date1.Caption = "domiciliation_payment_date"
Me.coldomiciliation_payment_date1.FieldName = "domiciliation_payment_date"
Me.coldomiciliation_payment_date1.Name = "coldomiciliation_payment_date1"
Me.coldomiciliation_payment_date1.Visible = true
Me.coldomiciliation_payment_date1.VisibleIndex = 1
'
'colabo_id
'
Me.colabo_id.Caption = "abo_id"
Me.colabo_id.FieldName = "abo_id"
Me.colabo_id.Name = "colabo_id"
Me.colabo_id.Visible = true
Me.colabo_id.VisibleIndex = 2
'
'colcustomers_id1
'
Me.colcustomers_id1.Caption = "customers_id"
Me.colcustomers_id1.FieldName = "customers_id"
Me.colcustomers_id1.Name = "colcustomers_id1"
'
'colcustomers_name
'
Me.colcustomers_name.Caption = "customers_name"
Me.colcustomers_name.FieldName = "customers_name"
Me.colcustomers_name.Name = "colcustomers_name"
'
'colcustomers_address1
'
Me.colcustomers_address1.Caption = "customers_address"
Me.colcustomers_address1.FieldName = "customers_address"
Me.colcustomers_address1.Name = "colcustomers_address1"
Me.colcustomers_address1.Visible = true
Me.colcustomers_address1.VisibleIndex = 3
'
'colamount4
'
Me.colamount4.Caption = "amount"
Me.colamount4.FieldName = "amount"
Me.colamount4.Name = "colamount4"
Me.colamount4.Visible = true
Me.colamount4.VisibleIndex = 4
'
'colstrdomiciliation_debiter_name1
'
Me.colstrdomiciliation_debiter_name1.Caption = "strdomiciliation_debiter_name"
Me.colstrdomiciliation_debiter_name1.FieldName = "strdomiciliation_debiter_name"
Me.colstrdomiciliation_debiter_name1.Name = "colstrdomiciliation_debiter_name1"
Me.colstrdomiciliation_debiter_name1.Visible = true
Me.colstrdomiciliation_debiter_name1.VisibleIndex = 5
'
'colstrdomiciliation_number1
'
Me.colstrdomiciliation_number1.Caption = "strdomiciliation_number"
Me.colstrdomiciliation_number1.FieldName = "strdomiciliation_number"
Me.colstrdomiciliation_number1.Name = "colstrdomiciliation_number1"
Me.colstrdomiciliation_number1.Visible = true
Me.colstrdomiciliation_number1.VisibleIndex = 6
'
'colcommunication3
'
Me.colcommunication3.Caption = "communication"
Me.colcommunication3.FieldName = "communication"
Me.colcommunication3.Name = "colcommunication3"
Me.colcommunication3.Visible = true
Me.colcommunication3.VisibleIndex = 7
'
'colfirst_payment1
'
Me.colfirst_payment1.Caption = "first_payment"
Me.colfirst_payment1.FieldName = "first_payment"
Me.colfirst_payment1.Name = "colfirst_payment1"
Me.colfirst_payment1.Visible = true
Me.colfirst_payment1.VisibleIndex = 8
'
'colreconduction1
'
Me.colreconduction1.Caption = "reconduction"
Me.colreconduction1.FieldName = "reconduction"
Me.colreconduction1.Name = "colreconduction1"
Me.colreconduction1.Visible = true
Me.colreconduction1.VisibleIndex = 9
'
'coldomiciliation_payment_status1
'
Me.coldomiciliation_payment_status1.Caption = "payment_status"
Me.coldomiciliation_payment_status1.FieldName = "payment_status"
Me.coldomiciliation_payment_status1.Name = "coldomiciliation_payment_status1"
Me.coldomiciliation_payment_status1.Visible = true
Me.coldomiciliation_payment_status1.VisibleIndex = 10
'
'coldomiciliation_payment_isabel_date1
'
Me.coldomiciliation_payment_isabel_date1.Caption = "domiciliation_payment_isabel_date"
Me.coldomiciliation_payment_isabel_date1.FieldName = "domiciliation_payment_isabel_date"
Me.coldomiciliation_payment_isabel_date1.Name = "coldomiciliation_payment_isabel_date1"
Me.coldomiciliation_payment_isabel_date1.Visible = true
Me.coldomiciliation_payment_isabel_date1.VisibleIndex = 11
'
'coldomiciliation_unpaid_id1
'
Me.coldomiciliation_unpaid_id1.Caption = "domiciliation_unpaid_id"
Me.coldomiciliation_unpaid_id1.FieldName = "domiciliation_unpaid_id"
Me.coldomiciliation_unpaid_id1.Name = "coldomiciliation_unpaid_id1"
Me.coldomiciliation_unpaid_id1.Visible = true
Me.coldomiciliation_unpaid_id1.VisibleIndex = 12
'
'colbatch_immatriculation_number1
'
Me.colbatch_immatriculation_number1.Caption = "batch_immatriculation_number"
Me.colbatch_immatriculation_number1.FieldName = "batch_immatriculation_number"
Me.colbatch_immatriculation_number1.Name = "colbatch_immatriculation_number1"
Me.colbatch_immatriculation_number1.Visible = true
Me.colbatch_immatriculation_number1.VisibleIndex = 13
'
'collast_modified4
'
Me.collast_modified4.Caption = "last_modified"
Me.collast_modified4.FieldName = "last_modified"
Me.collast_modified4.Name = "collast_modified4"
Me.collast_modified4.Visible = true
Me.collast_modified4.VisibleIndex = 14
'
'colabo_stopped_with_dvdathome_id1
'
Me.colabo_stopped_with_dvdathome_id1.Caption = "abo_stopped_with_dvdathome_id"
Me.colabo_stopped_with_dvdathome_id1.FieldName = "abo_stopped_with_dvdathome_id"
Me.colabo_stopped_with_dvdathome_id1.Name = "colabo_stopped_with_dvdathome_id1"
Me.colabo_stopped_with_dvdathome_id1.Visible = true
Me.colabo_stopped_with_dvdathome_id1.VisibleIndex = 15
'
'cologone_payment_id4
'
Me.cologone_payment_id4.Caption = "ogone_payment_id"
Me.cologone_payment_id4.FieldName = "ogone_payment_id"
Me.cologone_payment_id4.Name = "cologone_payment_id4"
Me.cologone_payment_id4.Visible = true
Me.cologone_payment_id4.VisibleIndex = 0
'
'coldate_added1
'
Me.coldate_added1.Caption = "date_added"
Me.coldate_added1.FieldName = "date_added"
Me.coldate_added1.Name = "coldate_added1"
Me.coldate_added1.Visible = true
Me.coldate_added1.VisibleIndex = 1
'
'colabo_id3
'
Me.colabo_id3.Caption = "abo_id"
Me.colabo_id3.FieldName = "abo_id"
Me.colabo_id3.Name = "colabo_id3"
Me.colabo_id3.Visible = true
Me.colabo_id3.VisibleIndex = 2
'
'colcustomers_id2
'
Me.colcustomers_id2.Caption = "customers_id"
Me.colcustomers_id2.FieldName = "customers_id"
Me.colcustomers_id2.Name = "colcustomers_id2"
'
'colamount5
'
Me.colamount5.Caption = "amount"
Me.colamount5.FieldName = "amount"
Me.colamount5.Name = "colamount5"
Me.colamount5.Visible = true
Me.colamount5.VisibleIndex = 3
'
'cologone_payment_status1
'
Me.cologone_payment_status1.Caption = "ogone_payment_status"
Me.cologone_payment_status1.FieldName = "ogone_payment_status"
Me.cologone_payment_status1.Name = "cologone_payment_status1"
Me.cologone_payment_status1.Visible = true
Me.cologone_payment_status1.VisibleIndex = 4
'
'cologone_batch_id1
'
Me.cologone_batch_id1.Caption = "ogone_batch_id"
Me.cologone_batch_id1.FieldName = "ogone_batch_id"
Me.cologone_batch_id1.Name = "cologone_batch_id1"
Me.cologone_batch_id1.Visible = true
Me.cologone_batch_id1.VisibleIndex = 5
'
'collast_modified5
'
Me.collast_modified5.Caption = "last_modified"
Me.collast_modified5.FieldName = "last_modified"
Me.collast_modified5.Name = "collast_modified5"
Me.collast_modified5.Visible = true
Me.collast_modified5.VisibleIndex = 6
'
'colcustserv_id1
'
Me.colcustserv_id1.Caption = "custserv_id"
Me.colcustserv_id1.FieldName = "custserv_id"
Me.colcustserv_id1.Name = "colcustserv_id1"
Me.colcustserv_id1.Visible = true
Me.colcustserv_id1.VisibleIndex = 0
'
'colcustomers_id3
'
Me.colcustomers_id3.Caption = "customers_id"
Me.colcustomers_id3.FieldName = "customers_id"
Me.colcustomers_id3.Name = "colcustomers_id3"
Me.colcustomers_id3.Visible = true
Me.colcustomers_id3.VisibleIndex = 1
'
'collanguage_id1
'
Me.collanguage_id1.Caption = "language_id"
Me.collanguage_id1.FieldName = "language_id"
Me.collanguage_id1.Name = "collanguage_id1"
Me.collanguage_id1.Visible = true
Me.collanguage_id1.VisibleIndex = 2
'
'colcustserv_cat_id1
'
Me.colcustserv_cat_id1.Caption = "custserv_cat_id"
Me.colcustserv_cat_id1.FieldName = "custserv_cat_id"
Me.colcustserv_cat_id1.Name = "colcustserv_cat_id1"
Me.colcustserv_cat_id1.Visible = true
Me.colcustserv_cat_id1.VisibleIndex = 3
'
'colcustomer_date1
'
Me.colcustomer_date1.Caption = "customer_date"
Me.colcustomer_date1.FieldName = "customer_date"
Me.colcustomer_date1.Name = "colcustomer_date1"
Me.colcustomer_date1.Visible = true
Me.colcustomer_date1.VisibleIndex = 4
'
'colorders_id
'
Me.colorders_id.Caption = "orders_id"
Me.colorders_id.FieldName = "orders_id"
Me.colorders_id.Name = "colorders_id"
Me.colorders_id.Visible = true
Me.colorders_id.VisibleIndex = 5
'
'colproducts_id
'
Me.colproducts_id.Caption = "products_id"
Me.colproducts_id.FieldName = "products_id"
Me.colproducts_id.Name = "colproducts_id"
Me.colproducts_id.Visible = true
Me.colproducts_id.VisibleIndex = 6
'
'coldvd_id1
'
Me.coldvd_id1.Caption = "dvd_id"
Me.coldvd_id1.FieldName = "dvd_id"
Me.coldvd_id1.Name = "coldvd_id1"
Me.coldvd_id1.Visible = true
Me.coldvd_id1.VisibleIndex = 7
'
'colsubject1
'
Me.colsubject1.Caption = "subject"
Me.colsubject1.FieldName = "subject"
Me.colsubject1.Name = "colsubject1"
Me.colsubject1.Visible = true
Me.colsubject1.VisibleIndex = 8
'
'colmessage1
'
Me.colmessage1.Caption = "message"
Me.colmessage1.FieldName = "message"
Me.colmessage1.Name = "colmessage1"
Me.colmessage1.Visible = true
Me.colmessage1.VisibleIndex = 9
'
'coladmindate1
'
Me.coladmindate1.Caption = "admindate"
Me.coladmindate1.FieldName = "admindate"
Me.coladmindate1.Name = "coladmindate1"
Me.coladmindate1.Visible = true
Me.coladmindate1.VisibleIndex = 10
'
'coladminby1
'
Me.coladminby1.Caption = "adminby"
Me.coladminby1.FieldName = "adminby"
Me.coladminby1.Name = "coladminby1"
Me.coladminby1.Visible = true
Me.coladminby1.VisibleIndex = 11
'
'coladminmessage1
'
Me.coladminmessage1.Caption = "adminmessage"
Me.coladminmessage1.FieldName = "adminmessage"
Me.coladminmessage1.Name = "coladminmessage1"
Me.coladminmessage1.Visible = true
Me.coladminmessage1.VisibleIndex = 12
'
'colmessagesent1
'
Me.colmessagesent1.Caption = "messagesent"
Me.colmessagesent1.FieldName = "messagesent"
Me.colmessagesent1.Name = "colmessagesent1"
Me.colmessagesent1.Visible = true
Me.colmessagesent1.VisibleIndex = 13
'
'coldvd_finally_arrived_mail1
'
Me.coldvd_finally_arrived_mail1.Caption = "dvd_finally_arrived_mail"
Me.coldvd_finally_arrived_mail1.FieldName = "dvd_finally_arrived_mail"
Me.coldvd_finally_arrived_mail1.Name = "coldvd_finally_arrived_mail1"
Me.coldvd_finally_arrived_mail1.Visible = true
Me.coldvd_finally_arrived_mail1.VisibleIndex = 14
'
'TextEdit3
'
Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_city", true))
Me.TextEdit3.Enabled = false
Me.TextEdit3.Location = New System.Drawing.Point(280, 72)
Me.TextEdit3.Name = "TextEdit3"
Me.TextEdit3.Size = New System.Drawing.Size(312, 22)
Me.TextEdit3.TabIndex = 13
'
'TextEdit4
'
Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_postcode", true))
Me.TextEdit4.Enabled = false
Me.TextEdit4.Location = New System.Drawing.Point(152, 72)
Me.TextEdit4.Name = "TextEdit4"
Me.TextEdit4.Size = New System.Drawing.Size(120, 22)
Me.TextEdit4.TabIndex = 12
'
'TextEdit5
'
Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_street_address", true))
Me.TextEdit5.Enabled = false
Me.TextEdit5.Location = New System.Drawing.Point(152, 48)
Me.TextEdit5.Name = "TextEdit5"
Me.TextEdit5.Size = New System.Drawing.Size(224, 22)
Me.TextEdit5.TabIndex = 10
'
'LCNumDom
'
Me.LCNumDom.Location = New System.Drawing.Point(16, 56)
Me.LCNumDom.Name = "LCNumDom"
Me.LCNumDom.Size = New System.Drawing.Size(45, 13)
Me.LCNumDom.TabIndex = 8
Me.ToolTip1.SetToolTip(Me.LCNumDom, "number of domiciliation ")
'
'SimpleButton1
'
Me.SimpleButton1.Location = New System.Drawing.Point(1021, 8)
Me.SimpleButton1.Name = "SimpleButton1"
Me.SimpleButton1.Size = New System.Drawing.Size(144, 23)
Me.SimpleButton1.TabIndex = 12
Me.SimpleButton1.Text = "test"
'
'tabMailHistory
'
Me.tabMailHistory.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.tabMailHistory.Appearance.Header.Options.UseFont = true
Me.tabMailHistory.AutoScroll = true
Me.tabMailHistory.Controls.Add(Me.browser)
Me.tabMailHistory.Controls.Add(Me.grpContEmail)
Me.tabMailHistory.Name = "tabMailHistory"
Me.tabMailHistory.Size = New System.Drawing.Size(1505, 905)
Me.tabMailHistory.Text = "mail history"
'
'browser
'
Me.browser.Location = New System.Drawing.Point(8, 447)
Me.browser.MinimumSize = New System.Drawing.Size(20, 20)
Me.browser.Name = "browser"
Me.browser.Size = New System.Drawing.Size(1395, 519)
Me.browser.TabIndex = 18
'
'grpContEmail
'
Me.grpContEmail.EmbeddedNavigator.Name = ""
Me.grpContEmail.FormsUseDefaultLookAndFeel = false
Me.grpContEmail.Location = New System.Drawing.Point(4, 38)
Me.grpContEmail.MainView = Me.GridViewMail
Me.grpContEmail.Name = "grpContEmail"
Me.grpContEmail.Size = New System.Drawing.Size(1399, 404)
Me.grpContEmail.TabIndex = 16
Me.grpContEmail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewMail})
'
'GridViewMail
'
Me.GridViewMail.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.messages_subject, Me.messages_title, Me.mail_opened_date, Me.mail_opened, Me.date_sended, Me.messages_html, Me.GCMail_id})
Me.GridViewMail.CustomizationFormBounds = New System.Drawing.Rectangle(513, 252, 296, 323)
Me.GridViewMail.GridControl = Me.grpContEmail
Me.GridViewMail.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewMail.Name = "GridViewMail"
Me.GridViewMail.OptionsView.ShowFooter = true
'
'messages_subject
'
Me.messages_subject.Caption = "messages_subject"
Me.messages_subject.FieldName = "messages_subject"
Me.messages_subject.Name = "messages_subject"
Me.messages_subject.OptionsColumn.AllowEdit = false
Me.messages_subject.OptionsColumn.ReadOnly = true
Me.messages_subject.Visible = true
Me.messages_subject.VisibleIndex = 1
Me.messages_subject.Width = 433
'
'messages_title
'
Me.messages_title.Caption = "messages_title"
Me.messages_title.FieldName = "messages_title"
Me.messages_title.Name = "messages_title"
Me.messages_title.OptionsColumn.AllowEdit = false
Me.messages_title.OptionsColumn.ReadOnly = true
Me.messages_title.Visible = true
Me.messages_title.VisibleIndex = 2
Me.messages_title.Width = 551
'
'mail_opened_date
'
Me.mail_opened_date.Caption = "mail_opened_date"
Me.mail_opened_date.FieldName = "mail_opened_date"
Me.mail_opened_date.Name = "mail_opened_date"
Me.mail_opened_date.OptionsColumn.AllowEdit = false
Me.mail_opened_date.OptionsColumn.ReadOnly = true
Me.mail_opened_date.Visible = true
Me.mail_opened_date.VisibleIndex = 3
Me.mail_opened_date.Width = 258
'
'mail_opened
'
Me.mail_opened.Caption = "mail_opened"
Me.mail_opened.FieldName = "mail_opened"
Me.mail_opened.Name = "mail_opened"
Me.mail_opened.OptionsColumn.AllowEdit = false
Me.mail_opened.OptionsColumn.ReadOnly = true
Me.mail_opened.Visible = true
Me.mail_opened.VisibleIndex = 4
Me.mail_opened.Width = 163
'
'date_sended
'
Me.date_sended.Caption = "date_sended"
Me.date_sended.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.date_sended.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.date_sended.FieldName = "date"
Me.date_sended.Name = "date_sended"
Me.date_sended.OptionsColumn.AllowEdit = false
Me.date_sended.OptionsColumn.ReadOnly = true
Me.date_sended.Visible = true
Me.date_sended.VisibleIndex = 0
Me.date_sended.Width = 215
'
'messages_html
'
Me.messages_html.Caption = "messages_html"
Me.messages_html.FieldName = "messages_html"
Me.messages_html.Name = "messages_html"
Me.messages_html.OptionsColumn.AllowEdit = false
Me.messages_html.OptionsColumn.ReadOnly = true
Me.messages_html.Width = 801
'
'GCMail_id
'
Me.GCMail_id.Caption = "Mail_id"
Me.GCMail_id.FieldName = "mail_messages_id"
Me.GCMail_id.Name = "GCMail_id"
Me.GCMail_id.Width = 108
'
'GridCustServ
'
Me.GridCustServ.Dock = System.Windows.Forms.DockStyle.Left
Me.GridCustServ.EmbeddedNavigator.Name = ""
Me.GridCustServ.FormsUseDefaultLookAndFeel = false
Me.GridCustServ.Location = New System.Drawing.Point(0, 0)
Me.GridCustServ.MainView = Me.gridViewCustServ
Me.GridCustServ.Name = "GridCustServ"
Me.GridCustServ.Size = New System.Drawing.Size(806, 905)
Me.GridCustServ.TabIndex = 1
Me.GridCustServ.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewCustServ})
'
'gridViewCustServ
'
Me.gridViewCustServ.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colcustserv2_id, Me.colcustomers2_id6, Me.collanguage2_id, Me.custserv_cat_name2, Me.colcustomer2_date, Me.colorders2_id1, Me.colproducts2_id2, Me.coldvd2_id, Me.colsubject3, Me.colmessage3, Me.coladmindate3, Me.coladminmessage3, Me.colmessagesent3, coldvd_finally_arrived_mail3})
Me.gridViewCustServ.CustomizationFormBounds = New System.Drawing.Rectangle(1384, 542, 216, 178)
Me.gridViewCustServ.GridControl = Me.GridCustServ
Me.gridViewCustServ.Name = "gridViewCustServ"
'
'colcustserv2_id
'
Me.colcustserv2_id.Caption = "custserv_id"
Me.colcustserv2_id.FieldName = "colcustserv_id"
Me.colcustserv2_id.Name = "colcustserv2_id"
Me.colcustserv2_id.OptionsColumn.AllowEdit = false
Me.colcustserv2_id.OptionsColumn.ReadOnly = true
'
'collanguage2_id
'
Me.collanguage2_id.Caption = "language_id"
Me.collanguage2_id.FieldName = "language_id"
Me.collanguage2_id.Name = "collanguage2_id"
Me.collanguage2_id.OptionsColumn.AllowEdit = false
Me.collanguage2_id.OptionsColumn.ReadOnly = true
'
'custserv_cat_name2
'
Me.custserv_cat_name2.Caption = "custserv_cat_name"
Me.custserv_cat_name2.FieldName = "custserv_cat_name"
Me.custserv_cat_name2.Name = "custserv_cat_name2"
Me.custserv_cat_name2.OptionsColumn.AllowEdit = false
Me.custserv_cat_name2.OptionsColumn.ReadOnly = true
Me.custserv_cat_name2.Visible = true
Me.custserv_cat_name2.VisibleIndex = 1
'
'colcustomer2_date
'
Me.colcustomer2_date.Caption = "customer_date"
Me.colcustomer2_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.colcustomer2_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.colcustomer2_date.FieldName = "customer_date"
Me.colcustomer2_date.Name = "colcustomer2_date"
Me.colcustomer2_date.OptionsColumn.AllowEdit = false
Me.colcustomer2_date.OptionsColumn.ReadOnly = true
Me.colcustomer2_date.Visible = true
Me.colcustomer2_date.VisibleIndex = 0
'
'colorders2_id1
'
Me.colorders2_id1.Caption = "orders_id"
Me.colorders2_id1.FieldName = "orders_id"
Me.colorders2_id1.Name = "colorders2_id1"
Me.colorders2_id1.OptionsColumn.AllowEdit = false
Me.colorders2_id1.OptionsColumn.ReadOnly = true
'
'colproducts2_id2
'
Me.colproducts2_id2.Caption = "products_id"
Me.colproducts2_id2.FieldName = "products_id2"
Me.colproducts2_id2.Name = "colproducts2_id2"
Me.colproducts2_id2.OptionsColumn.AllowEdit = false
Me.colproducts2_id2.OptionsColumn.ReadOnly = true
'
'coldvd2_id
'
Me.coldvd2_id.Caption = "dvd_id"
Me.coldvd2_id.FieldName = "dvd_id"
Me.coldvd2_id.Name = "coldvd2_id"
Me.coldvd2_id.OptionsColumn.AllowEdit = false
Me.coldvd2_id.OptionsColumn.ReadOnly = true
'
'colsubject3
'
Me.colsubject3.Caption = "subject"
Me.colsubject3.FieldName = "subject"
Me.colsubject3.Name = "colsubject3"
Me.colsubject3.OptionsColumn.AllowEdit = false
Me.colsubject3.OptionsColumn.ReadOnly = true
Me.colsubject3.Visible = true
Me.colsubject3.VisibleIndex = 2
'
'colmessage3
'
Me.colmessage3.Caption = "message"
Me.colmessage3.FieldName = "message"
Me.colmessage3.Name = "colmessage3"
Me.colmessage3.OptionsColumn.AllowEdit = false
Me.colmessage3.OptionsColumn.ReadOnly = true
'
'coladmindate3
'
Me.coladmindate3.Caption = "admindate"
Me.coladmindate3.FieldName = "admindate"
Me.coladmindate3.Name = "coladmindate3"
Me.coladmindate3.OptionsColumn.AllowEdit = false
Me.coladmindate3.OptionsColumn.ReadOnly = true
Me.coladmindate3.Visible = true
Me.coladmindate3.VisibleIndex = 3
'
'coladminmessage3
'
Me.coladminmessage3.Caption = "adminmessage"
Me.coladminmessage3.FieldName = "adminmessage"
Me.coladminmessage3.Name = "coladminmessage3"
Me.coladminmessage3.OptionsColumn.AllowEdit = false
Me.coladminmessage3.OptionsColumn.ReadOnly = true
'
'colmessagesent3
'
Me.colmessagesent3.Caption = "messagesent"
Me.colmessagesent3.FieldName = "messagesent"
Me.colmessagesent3.Name = "colmessagesent3"
Me.colmessagesent3.OptionsColumn.AllowEdit = false
Me.colmessagesent3.OptionsColumn.ReadOnly = true
Me.colmessagesent3.Visible = true
Me.colmessagesent3.VisibleIndex = 4
'
'tabDroselia
'
Me.tabDroselia.Appearance.PageClient.BackColor = System.Drawing.Color.Gray
Me.tabDroselia.Appearance.PageClient.Options.UseBackColor = true
Me.tabDroselia.Controls.Add(Me.LabelControl38)
Me.tabDroselia.Controls.Add(Me.txtDroselia)
Me.tabDroselia.Controls.Add(Me.GridDroselia)
Me.tabDroselia.Controls.Add(Me.butGenCode)
Me.tabDroselia.Name = "tabDroselia"
Me.tabDroselia.Size = New System.Drawing.Size(1505, 905)
Me.tabDroselia.Text = "Droselia"
'
'LabelControl38
'
Me.LabelControl38.Location = New System.Drawing.Point(4, 20)
Me.LabelControl38.Name = "LabelControl38"
Me.LabelControl38.Size = New System.Drawing.Size(160, 16)
Me.LabelControl38.TabIndex = 22
Me.LabelControl38.Text = "number of code to generate"
'
'txtDroselia
'
Me.txtDroselia.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.txtDroselia.Location = New System.Drawing.Point(174, 16)
Me.txtDroselia.Name = "txtDroselia"
Me.txtDroselia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtDroselia.Properties.MaxLength = 1000
Me.txtDroselia.Properties.MaxValue = New Decimal(New Integer() {99999, 0, 0, 0})
Me.txtDroselia.Size = New System.Drawing.Size(78, 22)
Me.txtDroselia.TabIndex = 21
'
'GridDroselia
'
Me.GridDroselia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
Me.GridDroselia.EmbeddedNavigator.Name = ""
Me.GridDroselia.FormsUseDefaultLookAndFeel = false
Me.GridDroselia.Location = New System.Drawing.Point(0, 67)
Me.GridDroselia.MainView = Me.GridViewDroselia
Me.GridDroselia.Name = "GridDroselia"
Me.GridDroselia.Size = New System.Drawing.Size(1502, 842)
Me.GridDroselia.TabIndex = 16
Me.GridDroselia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewDroselia})
'
'GridViewDroselia
'
Me.GridViewDroselia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.droselia_codes, Me.droselia_buy_date, Me.droselia_used_date, Me.catalog_id, Me.droselia_url_link})
Me.GridViewDroselia.GridControl = Me.GridDroselia
Me.GridViewDroselia.Name = "GridViewDroselia"
Me.GridViewDroselia.OptionsView.ColumnAutoWidth = false
Me.GridViewDroselia.OptionsView.ShowFooter = true
'
'droselia_codes
'
Me.droselia_codes.Caption = "droselia_codes"
Me.droselia_codes.FieldName = "droselia_codes"
Me.droselia_codes.Name = "droselia_codes"
Me.droselia_codes.OptionsColumn.AllowEdit = false
Me.droselia_codes.OptionsColumn.FixedWidth = true
Me.droselia_codes.OptionsColumn.ReadOnly = true
Me.droselia_codes.Visible = true
Me.droselia_codes.VisibleIndex = 0
Me.droselia_codes.Width = 109
'
'droselia_buy_date
'
Me.droselia_buy_date.Caption = "buy_date"
Me.droselia_buy_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.droselia_buy_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.droselia_buy_date.FieldName = "buy_date"
Me.droselia_buy_date.Name = "droselia_buy_date"
Me.droselia_buy_date.OptionsColumn.AllowEdit = false
Me.droselia_buy_date.OptionsColumn.FixedWidth = true
Me.droselia_buy_date.OptionsColumn.ReadOnly = true
Me.droselia_buy_date.Visible = true
Me.droselia_buy_date.VisibleIndex = 1
Me.droselia_buy_date.Width = 163
'
'droselia_used_date
'
Me.droselia_used_date.Caption = "used_date"
Me.droselia_used_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.droselia_used_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.droselia_used_date.FieldName = "used_date"
Me.droselia_used_date.Name = "droselia_used_date"
Me.droselia_used_date.OptionsColumn.AllowEdit = false
Me.droselia_used_date.OptionsColumn.FixedWidth = true
Me.droselia_used_date.OptionsColumn.ReadOnly = true
Me.droselia_used_date.Visible = true
Me.droselia_used_date.VisibleIndex = 2
Me.droselia_used_date.Width = 171
'
'catalog_id
'
Me.catalog_id.Caption = "catalog_id"
Me.catalog_id.FieldName = "catalog_id"
Me.catalog_id.Name = "catalog_id"
Me.catalog_id.OptionsColumn.AllowEdit = false
Me.catalog_id.OptionsColumn.FixedWidth = true
Me.catalog_id.OptionsColumn.ReadOnly = true
Me.catalog_id.Visible = true
Me.catalog_id.VisibleIndex = 3
Me.catalog_id.Width = 93
'
'droselia_url_link
'
Me.droselia_url_link.Caption = "url_link"
Me.droselia_url_link.FieldName = "url_link"
Me.droselia_url_link.Name = "droselia_url_link"
Me.droselia_url_link.OptionsColumn.AllowEdit = false
Me.droselia_url_link.OptionsColumn.FixedWidth = true
Me.droselia_url_link.OptionsColumn.ReadOnly = true
Me.droselia_url_link.Visible = true
Me.droselia_url_link.VisibleIndex = 4
'
'butGenCode
'
Me.butGenCode.Location = New System.Drawing.Point(266, 15)
Me.butGenCode.Name = "butGenCode"
Me.butGenCode.Size = New System.Drawing.Size(111, 27)
Me.butGenCode.TabIndex = 11
Me.butGenCode.Text = "Generate code"
'
'tabPaymentMovements
'
Me.tabPaymentMovements.Controls.Add(Me.GCBankAccountMovement)
Me.tabPaymentMovements.Name = "tabPaymentMovements"
Me.tabPaymentMovements.Size = New System.Drawing.Size(1505, 905)
Me.tabPaymentMovements.Text = "Payment Movements"
'
'GCBankAccountMovement
'
Me.GCBankAccountMovement.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCBankAccountMovement.Controls.Add(Me.GridBankAccountMovements)
Me.GCBankAccountMovement.Dock = System.Windows.Forms.DockStyle.Fill
Me.GCBankAccountMovement.Location = New System.Drawing.Point(0, 0)
Me.GCBankAccountMovement.Name = "GCBankAccountMovement"
Me.GCBankAccountMovement.Size = New System.Drawing.Size(1505, 905)
Me.GCBankAccountMovement.TabIndex = 1
Me.GCBankAccountMovement.Text = "Bank Account movements"
'
'GridBankAccountMovements
'
Me.GridBankAccountMovements.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridBankAccountMovements.EmbeddedNavigator.Name = ""
Me.GridBankAccountMovements.FormsUseDefaultLookAndFeel = false
Me.GridBankAccountMovements.Location = New System.Drawing.Point(2, 22)
Me.GridBankAccountMovements.MainView = Me.GridViewBankAccountMovements
Me.GridBankAccountMovements.Name = "GridBankAccountMovements"
Me.GridBankAccountMovements.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryCmbMatching})
Me.GridBankAccountMovements.Size = New System.Drawing.Size(1501, 881)
Me.GridBankAccountMovements.TabIndex = 5
Me.GridBankAccountMovements.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewBankAccountMovements})
'
'GridViewBankAccountMovements
'
Me.GridViewBankAccountMovements.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIsmatching, Me.colBankAccountMovements_id, Me.coldate_coda_created, Me.colCodaFilename, Me.colamount2, Me.coldvdpost_bank_account, Me.colcommunicationStr, Me.GridColumn1, Me.colStructuredComm12, Me.colCounterpartdetails, Me.ColCommunication_type, Me.colEntireData, Me.colBankAccountClient, Me.colBankAccount_Customers_id, Me.colBankAccount_Comment})
Me.GridViewBankAccountMovements.CustomizationFormBounds = New System.Drawing.Rectangle(1113, 176, 327, 364)
Me.GridViewBankAccountMovements.GridControl = Me.GridBankAccountMovements
Me.GridViewBankAccountMovements.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewBankAccountMovements.Name = "GridViewBankAccountMovements"
Me.GridViewBankAccountMovements.OptionsSelection.MultiSelect = true
Me.GridViewBankAccountMovements.OptionsView.ColumnAutoWidth = false
Me.GridViewBankAccountMovements.OptionsView.ShowFooter = true
'
'colIsmatching
'
Me.colIsmatching.Caption = "Open payment"
Me.colIsmatching.ColumnEdit = Me.RepositoryCmbMatching
Me.colIsmatching.FieldName = "ismatching"
Me.colIsmatching.Name = "colIsmatching"
Me.colIsmatching.OptionsColumn.AllowEdit = false
Me.colIsmatching.OptionsColumn.ReadOnly = true
Me.colIsmatching.Visible = true
Me.colIsmatching.VisibleIndex = 3
'
'RepositoryCmbMatching
'
Me.RepositoryCmbMatching.AutoHeight = false
Me.RepositoryCmbMatching.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.RepositoryCmbMatching.DisplayMember = "name"
Me.RepositoryCmbMatching.Name = "RepositoryCmbMatching"
Me.RepositoryCmbMatching.NullText = ""
Me.RepositoryCmbMatching.ValueMember = "id"
'
'colBankAccountMovements_id
'
Me.colBankAccountMovements_id.Caption = "id"
Me.colBankAccountMovements_id.FieldName = "account_movements_id"
Me.colBankAccountMovements_id.Name = "colBankAccountMovements_id"
Me.colBankAccountMovements_id.OptionsColumn.AllowEdit = false
Me.colBankAccountMovements_id.OptionsColumn.ReadOnly = true
Me.colBankAccountMovements_id.Visible = true
Me.colBankAccountMovements_id.VisibleIndex = 0
'
'coldate_coda_created
'
Me.coldate_coda_created.Caption = "date_added"
Me.coldate_coda_created.DisplayFormat.FormatString = "d"
Me.coldate_coda_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.coldate_coda_created.FieldName = "date_coda_created"
Me.coldate_coda_created.Name = "coldate_coda_created"
Me.coldate_coda_created.OptionsColumn.AllowEdit = false
Me.coldate_coda_created.OptionsColumn.ReadOnly = true
Me.coldate_coda_created.Visible = true
Me.coldate_coda_created.VisibleIndex = 4
Me.coldate_coda_created.Width = 105
'
'colCodaFilename
'
Me.colCodaFilename.Caption = "filename"
Me.colCodaFilename.FieldName = "coda_filename"
Me.colCodaFilename.Name = "colCodaFilename"
Me.colCodaFilename.OptionsColumn.AllowEdit = false
Me.colCodaFilename.OptionsColumn.ReadOnly = true
Me.colCodaFilename.Visible = true
Me.colCodaFilename.VisibleIndex = 12
'
'colamount2
'
Me.colamount2.Caption = "amount"
Me.colamount2.FieldName = "Amount"
Me.colamount2.Name = "colamount2"
Me.colamount2.OptionsColumn.AllowEdit = false
Me.colamount2.OptionsColumn.ReadOnly = true
Me.colamount2.Visible = true
Me.colamount2.VisibleIndex = 7
Me.colamount2.Width = 84
'
'coldvdpost_bank_account
'
Me.coldvdpost_bank_account.Caption = "dvdpost_bank_account"
Me.coldvdpost_bank_account.FieldName = "dvdpost_bank_account"
Me.coldvdpost_bank_account.Name = "coldvdpost_bank_account"
Me.coldvdpost_bank_account.OptionsColumn.AllowEdit = false
Me.coldvdpost_bank_account.OptionsColumn.ReadOnly = true
Me.coldvdpost_bank_account.Visible = true
Me.coldvdpost_bank_account.VisibleIndex = 13
'
'colcommunicationStr
'
Me.colcommunicationStr.Caption = "Str communication"
Me.colcommunicationStr.FieldName = "Communication"
Me.colcommunicationStr.Name = "colcommunicationStr"
Me.colcommunicationStr.OptionsColumn.AllowEdit = false
Me.colcommunicationStr.OptionsColumn.ReadOnly = true
Me.colcommunicationStr.Visible = true
Me.colcommunicationStr.VisibleIndex = 11
Me.colcommunicationStr.Width = 240
'
'GridColumn1
'
Me.GridColumn1.Caption = "Num Dom"
Me.GridColumn1.FieldName = "Communication2"
Me.GridColumn1.Name = "GridColumn1"
Me.GridColumn1.OptionsColumn.AllowEdit = false
Me.GridColumn1.OptionsColumn.ReadOnly = true
Me.GridColumn1.Visible = true
Me.GridColumn1.VisibleIndex = 8
Me.GridColumn1.Width = 124
'
'colStructuredComm12
'
Me.colStructuredComm12.Caption = "communication struct"
Me.colStructuredComm12.FieldName = "structuredComm12"
Me.colStructuredComm12.Name = "colStructuredComm12"
Me.colStructuredComm12.OptionsColumn.AllowEdit = false
Me.colStructuredComm12.OptionsColumn.ReadOnly = true
Me.colStructuredComm12.Visible = true
Me.colStructuredComm12.VisibleIndex = 9
Me.colStructuredComm12.Width = 113
'
'colCounterpartdetails
'
Me.colCounterpartdetails.Caption = "Info Client"
Me.colCounterpartdetails.FieldName = "CounterpartDetails"
Me.colCounterpartdetails.Name = "colCounterpartdetails"
Me.colCounterpartdetails.OptionsColumn.AllowEdit = false
Me.colCounterpartdetails.OptionsColumn.ReadOnly = true
Me.colCounterpartdetails.Visible = true
Me.colCounterpartdetails.VisibleIndex = 6
Me.colCounterpartdetails.Width = 180
'
'ColCommunication_type
'
Me.ColCommunication_type.Caption = "type communication "
Me.ColCommunication_type.FieldName = "communication_type"
Me.ColCommunication_type.Name = "ColCommunication_type"
Me.ColCommunication_type.OptionsColumn.AllowEdit = false
Me.ColCommunication_type.OptionsColumn.ReadOnly = true
Me.ColCommunication_type.Visible = true
Me.ColCommunication_type.VisibleIndex = 10
'
'colEntireData
'
Me.colEntireData.Caption = "entireData"
Me.colEntireData.FieldName = "EntireData"
Me.colEntireData.Name = "colEntireData"
Me.colEntireData.OptionsColumn.AllowEdit = false
Me.colEntireData.Visible = true
Me.colEntireData.VisibleIndex = 14
'
'colBankAccountClient
'
Me.colBankAccountClient.Caption = "BankAccountClient"
Me.colBankAccountClient.FieldName = "BankAccountCounterpart"
Me.colBankAccountClient.Name = "colBankAccountClient"
Me.colBankAccountClient.OptionsColumn.AllowEdit = false
Me.colBankAccountClient.Visible = true
Me.colBankAccountClient.VisibleIndex = 5
Me.colBankAccountClient.Width = 111
'
'colBankAccount_Customers_id
'
Me.colBankAccount_Customers_id.Caption = "customers_id"
Me.colBankAccount_Customers_id.FieldName = "customers_id"
Me.colBankAccount_Customers_id.Name = "colBankAccount_Customers_id"
Me.colBankAccount_Customers_id.Visible = true
Me.colBankAccount_Customers_id.VisibleIndex = 1
Me.colBankAccount_Customers_id.Width = 97
'
'colBankAccount_Comment
'
Me.colBankAccount_Comment.Caption = "comment"
Me.colBankAccount_Comment.FieldName = "comment"
Me.colBankAccount_Comment.Name = "colBankAccount_Comment"
Me.colBankAccount_Comment.Visible = true
Me.colBankAccount_Comment.VisibleIndex = 2
Me.colBankAccount_Comment.Width = 154
'
'GridOrders
'
Me.GridOrders.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridOrders.EmbeddedNavigator.Name = ""
Me.GridOrders.FormsUseDefaultLookAndFeel = false
Me.GridOrders.Location = New System.Drawing.Point(0, 0)
Me.GridOrders.MainView = Me.GridViewOrders
Me.GridOrders.Name = "GridOrders"
Me.GridOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryIbtnCheckOrder})
Me.GridOrders.Size = New System.Drawing.Size(1115, 881)
Me.GridOrders.TabIndex = 1
Me.GridOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewOrders})
'
'GridViewOrders
'
Me.GridViewOrders.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand5})
Me.GridViewOrders.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.coldate_purchased, Me.colorders_status, Me.colorders_date_finished, Me.colorders_products_id, Me.colproducts_name, Me.colproducts_dvd, Me.colorders_products_status, Me.col2orders_id, Me.products_id, Me.colorders_last_modified, Me.ColOrders_type, Me.colOrderCheck, Me.ColName})
Me.GridViewOrders.CustomizationFormBounds = New System.Drawing.Rectangle(671, 230, 217, 291)
Me.GridViewOrders.GridControl = Me.GridOrders
Me.GridViewOrders.GroupCount = 1
Me.GridViewOrders.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewOrders.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "orders_status", Nothing, "")})
Me.GridViewOrders.Name = "GridViewOrders"
Me.GridViewOrders.OptionsView.ShowBands = false
Me.GridViewOrders.OptionsView.ShowFooter = true
Me.GridViewOrders.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colorders_status, DevExpress.Data.ColumnSortOrder.Ascending)})
'
'GridBand5
'
Me.GridBand5.Caption = "GridBand4"
Me.GridBand5.Columns.Add(Me.ColName)
Me.GridBand5.Columns.Add(Me.colOrderCheck)
Me.GridBand5.Columns.Add(Me.col2orders_id)
Me.GridBand5.Columns.Add(Me.coldate_purchased)
Me.GridBand5.Columns.Add(Me.colorders_status)
Me.GridBand5.Columns.Add(Me.colproducts_name)
Me.GridBand5.Columns.Add(Me.colorders_date_finished)
Me.GridBand5.Columns.Add(Me.colorders_products_id)
Me.GridBand5.Columns.Add(Me.products_id)
Me.GridBand5.Columns.Add(Me.colproducts_dvd)
Me.GridBand5.Columns.Add(Me.colorders_last_modified)
Me.GridBand5.Columns.Add(Me.ColOrders_type)
Me.GridBand5.Columns.Add(Me.colorders_products_status)
Me.GridBand5.MinWidth = 20
Me.GridBand5.Name = "GridBand5"
Me.GridBand5.Width = 895
'
'ColName
'
Me.ColName.Caption = "Name"
Me.ColName.FieldName = "customers_name"
Me.ColName.Name = "ColName"
Me.ColName.Visible = true
'
'colOrderCheck
'
Me.colOrderCheck.Caption = "check order"
Me.colOrderCheck.ColumnEdit = Me.RepositoryIbtnCheckOrder
Me.colOrderCheck.Name = "colOrderCheck"
Me.colOrderCheck.Visible = true
Me.colOrderCheck.Width = 87
'
'RepositoryIbtnCheckOrder
'
Me.RepositoryIbtnCheckOrder.AutoHeight = false
Me.RepositoryIbtnCheckOrder.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.RepositoryIbtnCheckOrder.Name = "RepositoryIbtnCheckOrder"
Me.RepositoryIbtnCheckOrder.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
'
'col2orders_id
'
Me.col2orders_id.Caption = "orders_id"
Me.col2orders_id.FieldName = "orders_id"
Me.col2orders_id.Name = "col2orders_id"
Me.col2orders_id.OptionsColumn.AllowEdit = false
Me.col2orders_id.Visible = true
Me.col2orders_id.Width = 70
'
'coldate_purchased
'
Me.coldate_purchased.Caption = "date_purchased"
Me.coldate_purchased.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.coldate_purchased.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.coldate_purchased.FieldName = "date_purchased"
Me.coldate_purchased.Name = "coldate_purchased"
Me.coldate_purchased.OptionsColumn.AllowEdit = false
Me.coldate_purchased.OptionsColumn.ReadOnly = true
Me.coldate_purchased.Visible = true
Me.coldate_purchased.Width = 114
'
'colorders_status
'
Me.colorders_status.Caption = "orders_status"
Me.colorders_status.FieldName = "orders_status"
Me.colorders_status.Name = "colorders_status"
Me.colorders_status.OptionsColumn.AllowEdit = false
Me.colorders_status.OptionsColumn.ReadOnly = true
Me.colorders_status.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
Me.colorders_status.Visible = true
Me.colorders_status.Width = 91
'
'colproducts_name
'
Me.colproducts_name.Caption = "products_name"
Me.colproducts_name.FieldName = "products_name"
Me.colproducts_name.Name = "colproducts_name"
Me.colproducts_name.OptionsColumn.AllowEdit = false
Me.colproducts_name.OptionsColumn.ReadOnly = true
Me.colproducts_name.Visible = true
Me.colproducts_name.Width = 108
'
'colorders_date_finished
'
Me.colorders_date_finished.Caption = "orders_date_finished"
Me.colorders_date_finished.FieldName = "orders_date_finished"
Me.colorders_date_finished.Name = "colorders_date_finished"
Me.colorders_date_finished.OptionsColumn.AllowEdit = false
Me.colorders_date_finished.OptionsColumn.ReadOnly = true
'
'colorders_products_id
'
Me.colorders_products_id.Caption = "orders_products_id"
Me.colorders_products_id.FieldName = "orders_products_id"
Me.colorders_products_id.Name = "colorders_products_id"
Me.colorders_products_id.OptionsColumn.AllowEdit = false
Me.colorders_products_id.OptionsColumn.ReadOnly = true
Me.colorders_products_id.Width = 115
'
'products_id
'
Me.products_id.Caption = "products_id"
Me.products_id.FieldName = "products_id"
Me.products_id.Name = "products_id"
Me.products_id.Visible = true
Me.products_id.Width = 84
'
'colproducts_dvd
'
Me.colproducts_dvd.Caption = "products_dvd"
Me.colproducts_dvd.FieldName = "products_dvd"
Me.colproducts_dvd.Name = "colproducts_dvd"
Me.colproducts_dvd.OptionsColumn.AllowEdit = false
Me.colproducts_dvd.OptionsColumn.ReadOnly = true
Me.colproducts_dvd.Visible = true
Me.colproducts_dvd.Width = 94
'
'colorders_last_modified
'
Me.colorders_last_modified.Caption = "last_modified"
Me.colorders_last_modified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.colorders_last_modified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.colorders_last_modified.FieldName = "last_modified"
Me.colorders_last_modified.Name = "colorders_last_modified"
Me.colorders_last_modified.OptionsColumn.AllowEdit = false
Me.colorders_last_modified.OptionsColumn.ReadOnly = true
Me.colorders_last_modified.Visible = true
Me.colorders_last_modified.Width = 97
'
'ColOrders_type
'
Me.ColOrders_type.Caption = "Orders_type"
Me.ColOrders_type.FieldName = "orders_type"
Me.ColOrders_type.Name = "ColOrders_type"
Me.ColOrders_type.Visible = true
'
'colorders_products_status
'
Me.colorders_products_status.Caption = "orders_products_status"
Me.colorders_products_status.FieldName = "orders_products_status"
Me.colorders_products_status.Name = "colorders_products_status"
Me.colorders_products_status.OptionsColumn.AllowEdit = false
Me.colorders_products_status.OptionsColumn.ReadOnly = true
'
'Col3Orders_id
'
Me.Col3Orders_id.Caption = "orders_id"
Me.Col3Orders_id.FieldName = "orders_id"
Me.Col3Orders_id.Name = "Col3Orders_id"
Me.Col3Orders_id.OptionsColumn.AllowEdit = false
Me.Col3Orders_id.Visible = true
Me.Col3Orders_id.VisibleIndex = 7
'
'GridABO
'
Me.GridABO.DataSource = Me.objDS.abo
Me.GridABO.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridABO.EmbeddedNavigator.Name = ""
Me.GridABO.FormsUseDefaultLookAndFeel = false
Me.GridABO.Location = New System.Drawing.Point(0, 0)
Me.GridABO.MainView = Me.GridViewABO
Me.GridABO.Name = "GridABO"
Me.GridABO.Size = New System.Drawing.Size(1505, 905)
Me.GridABO.TabIndex = 0
Me.GridABO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewABO})
'
'GridViewABO
'
Me.GridViewABO.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand4})
Me.GridViewABO.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colcustomerid, Me.colAction, Me.colcode_id, Me.colDate, Me.colproduct_id1, Me.colpayment_method, Me.colprivilege_notified, Me.colsite})
Me.GridViewABO.CustomizationFormBounds = New System.Drawing.Rectangle(1383, 422, 217, 222)
Me.GridViewABO.GridControl = Me.GridABO
Me.GridViewABO.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewABO.Name = "GridViewABO"
Me.GridViewABO.OptionsView.ShowBands = false
Me.GridViewABO.OptionsView.ShowFooter = true
'
'GridBand4
'
Me.GridBand4.Caption = "GridBand4"
Me.GridBand4.Columns.Add(Me.colcustomerid)
Me.GridBand4.Columns.Add(Me.colAction)
Me.GridBand4.Columns.Add(Me.colcode_id)
Me.GridBand4.Columns.Add(Me.colDate)
Me.GridBand4.Columns.Add(Me.colproduct_id1)
Me.GridBand4.Columns.Add(Me.colpayment_method)
Me.GridBand4.Columns.Add(Me.colprivilege_notified)
Me.GridBand4.Columns.Add(Me.colsite)
Me.GridBand4.MinWidth = 20
Me.GridBand4.Name = "GridBand4"
Me.GridBand4.Width = 907
'
'colcustomerid
'
Me.colcustomerid.Caption = "customerid"
Me.colcustomerid.FieldName = "customerid"
Me.colcustomerid.Name = "colcustomerid"
Me.colcustomerid.OptionsColumn.AllowEdit = false
Me.colcustomerid.OptionsColumn.ReadOnly = true
Me.colcustomerid.Visible = true
Me.colcustomerid.Width = 112
'
'colAction
'
Me.colAction.Caption = "Action"
Me.colAction.FieldName = "Action"
Me.colAction.Name = "colAction"
Me.colAction.OptionsColumn.AllowEdit = false
Me.colAction.OptionsColumn.ReadOnly = true
Me.colAction.Visible = true
Me.colAction.Width = 135
'
'colcode_id
'
Me.colcode_id.Caption = "code_id"
Me.colcode_id.FieldName = "code_id"
Me.colcode_id.Name = "colcode_id"
Me.colcode_id.OptionsColumn.AllowEdit = false
Me.colcode_id.OptionsColumn.ReadOnly = true
Me.colcode_id.Visible = true
Me.colcode_id.Width = 114
'
'colDate
'
Me.colDate.Caption = "Date"
Me.colDate.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.colDate.FieldName = "Date"
Me.colDate.Name = "colDate"
Me.colDate.OptionsColumn.AllowEdit = false
Me.colDate.OptionsColumn.ReadOnly = true
Me.colDate.Visible = true
Me.colDate.Width = 127
'
'colproduct_id1
'
Me.colproduct_id1.Caption = "product_id"
Me.colproduct_id1.FieldName = "product_id"
Me.colproduct_id1.Name = "colproduct_id1"
Me.colproduct_id1.OptionsColumn.AllowEdit = false
Me.colproduct_id1.OptionsColumn.ReadOnly = true
Me.colproduct_id1.Visible = true
Me.colproduct_id1.Width = 120
'
'colpayment_method
'
Me.colpayment_method.Caption = "payment_method"
Me.colpayment_method.FieldName = "payment_method"
Me.colpayment_method.Name = "colpayment_method"
Me.colpayment_method.OptionsColumn.AllowEdit = false
Me.colpayment_method.OptionsColumn.ReadOnly = true
Me.colpayment_method.Visible = true
Me.colpayment_method.Width = 138
'
'colprivilege_notified
'
Me.colprivilege_notified.Caption = "privilege_notified"
Me.colprivilege_notified.FieldName = "privilege_notified"
Me.colprivilege_notified.Name = "colprivilege_notified"
Me.colprivilege_notified.OptionsColumn.AllowEdit = false
Me.colprivilege_notified.OptionsColumn.ReadOnly = true
Me.colprivilege_notified.Visible = true
Me.colprivilege_notified.Width = 86
'
'colsite
'
Me.colsite.Caption = "site"
Me.colsite.FieldName = "site"
Me.colsite.Name = "colsite"
Me.colsite.OptionsColumn.AllowEdit = false
Me.colsite.OptionsColumn.ReadOnly = true
Me.colsite.Visible = true
'
'ColLast_status
'
Me.ColLast_status.Caption = "last_status"
Me.ColLast_status.FieldName = "last_status"
Me.ColLast_status.Name = "ColLast_status"
Me.ColLast_status.OptionsColumn.AllowEdit = false
'
'colDate_closed
'
Me.colDate_closed.Caption = "date_closed"
Me.colDate_closed.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.colDate_closed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.colDate_closed.FieldName = "date_closed"
Me.colDate_closed.Name = "colDate_closed"
Me.colDate_closed.OptionsColumn.AllowEdit = false
'
'RepositoryItemLookUpEdit5
'
Me.RepositoryItemLookUpEdit5.AutoHeight = false
Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.RepositoryItemLookUpEdit5.DisplayMember = "name"
Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
Me.RepositoryItemLookUpEdit5.ValueMember = "id"
'
'colDomNumber
'
Me.colDomNumber.Caption = "domiciliation_number"
Me.colDomNumber.FieldName = "domiciliation_number"
Me.colDomNumber.Name = "colDomNumber"
Me.colDomNumber.OptionsColumn.AllowEdit = false
Me.colDomNumber.Width = 132
'
'colabopay_id
'
Me.colabopay_id.Caption = "abo_id"
Me.colabopay_id.FieldName = "abo_id"
Me.colabopay_id.Name = "colabopay_id"
Me.colabopay_id.OptionsColumn.AllowEdit = false
'
'tabPayment
'
Me.tabPayment.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
Me.tabPayment.Appearance.Header.Options.UseFont = true
Me.tabPayment.Controls.Add(Me.GridPayment)
Me.tabPayment.Controls.Add(Me.BtnPaid)
Me.tabPayment.Controls.Add(Me.btnLoadPayment)
Me.tabPayment.Controls.Add(Me.checkOpenPayment)
Me.tabPayment.Controls.Add(Me.GroupOgone)
Me.tabPayment.Controls.Add(Me.BtnCancelPayment)
Me.tabPayment.Controls.Add(Me.GroupDomiciliation)
Me.tabPayment.Controls.Add(Me.CalcEdit1)
Me.tabPayment.Controls.Add(Me.LabelControl48)
Me.tabPayment.Controls.Add(Me.CalcEdit)
Me.tabPayment.Controls.Add(Me.LabelControl49)
Me.tabPayment.Controls.Add(Me.cmbPayMethod)
Me.tabPayment.Controls.Add(Me.LabelControl50)
Me.tabPayment.Name = "tabPayment"
Me.tabPayment.Size = New System.Drawing.Size(1505, 905)
Me.tabPayment.Text = "Invoices"
'
'GridPayment
'
Me.GridPayment.EmbeddedNavigator.Name = ""
Me.GridPayment.FormsUseDefaultLookAndFeel = false
Me.GridPayment.Location = New System.Drawing.Point(4, 269)
Me.GridPayment.MainView = Me.GridViewPayment
Me.GridPayment.Name = "GridPayment"
Me.GridPayment.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit5})
Me.GridPayment.Size = New System.Drawing.Size(1380, 518)
Me.GridPayment.TabIndex = 61
Me.GridPayment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewPayment})
'
'GridViewPayment
'
Me.GridViewPayment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {ColTypePayment, ColPayment_id, ColAmountPay, ColDateAdded, Me.ColLastModified, Me.ColCommunicationPay, Me.ColCustomersID, Me.colPayment_status, ColIdMatching, Me.ColLast_status, Me.colDate_closed, Me.colDomNumber, Me.colabopay_id})
Me.GridViewPayment.CustomizationFormBounds = New System.Drawing.Rectangle(1273, 240, 327, 364)
Me.GridViewPayment.GridControl = Me.GridPayment
Me.GridViewPayment.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewPayment.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
Me.GridViewPayment.Name = "GridViewPayment"
Me.GridViewPayment.OptionsSelection.MultiSelect = true
Me.GridViewPayment.OptionsView.ColumnAutoWidth = false
Me.GridViewPayment.OptionsView.ShowFooter = true
'
'ColLastModified
'
Me.ColLastModified.Caption = "Last modified"
Me.ColLastModified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.ColLastModified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.ColLastModified.FieldName = "last_modified"
Me.ColLastModified.Name = "ColLastModified"
Me.ColLastModified.OptionsColumn.AllowEdit = false
Me.ColLastModified.OptionsColumn.ReadOnly = true
Me.ColLastModified.Visible = true
Me.ColLastModified.VisibleIndex = 5
'
'ColCommunicationPay
'
Me.ColCommunicationPay.Caption = "communication"
Me.ColCommunicationPay.FieldName = "communication"
Me.ColCommunicationPay.Name = "ColCommunicationPay"
Me.ColCommunicationPay.OptionsColumn.AllowEdit = false
Me.ColCommunicationPay.OptionsColumn.ReadOnly = true
Me.ColCommunicationPay.Visible = true
Me.ColCommunicationPay.VisibleIndex = 6
Me.ColCommunicationPay.Width = 101
'
'ColCustomersID
'
Me.ColCustomersID.Caption = "customers_id"
Me.ColCustomersID.FieldName = "customers_id"
Me.ColCustomersID.Name = "ColCustomersID"
Me.ColCustomersID.OptionsColumn.AllowEdit = false
Me.ColCustomersID.OptionsColumn.ReadOnly = true
Me.ColCustomersID.Visible = true
Me.ColCustomersID.VisibleIndex = 3
Me.ColCustomersID.Width = 112
'
'colPayment_status
'
Me.colPayment_status.Caption = "Payment_Status"
Me.colPayment_status.FieldName = "payment_status"
Me.colPayment_status.Name = "colPayment_status"
Me.colPayment_status.OptionsColumn.AllowEdit = false
Me.colPayment_status.OptionsColumn.ReadOnly = true
Me.colPayment_status.Visible = true
Me.colPayment_status.VisibleIndex = 7
Me.colPayment_status.Width = 105
'
'BtnPaid
'
Me.BtnPaid.Location = New System.Drawing.Point(607, 231)
Me.BtnPaid.Name = "BtnPaid"
Me.BtnPaid.Size = New System.Drawing.Size(163, 26)
Me.BtnPaid.TabIndex = 64
Me.BtnPaid.Text = "Paid Payment"
'
'btnLoadPayment
'
Me.btnLoadPayment.Location = New System.Drawing.Point(181, 231)
Me.btnLoadPayment.Name = "btnLoadPayment"
Me.btnLoadPayment.Size = New System.Drawing.Size(173, 26)
Me.btnLoadPayment.TabIndex = 63
Me.btnLoadPayment.Text = "Load"
'
'checkOpenPayment
'
Me.checkOpenPayment.Location = New System.Drawing.Point(41, 235)
Me.checkOpenPayment.Name = "checkOpenPayment"
Me.checkOpenPayment.Properties.Caption = "Open Payment"
Me.checkOpenPayment.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
Me.checkOpenPayment.Properties.ValueChecked = 1
Me.checkOpenPayment.Properties.ValueUnchecked = 0
Me.checkOpenPayment.Size = New System.Drawing.Size(127, 21)
Me.checkOpenPayment.TabIndex = 62
'
'GroupOgone
'
Me.GroupOgone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GroupOgone.Controls.Add(Me.PanelOgone)
Me.GroupOgone.Location = New System.Drawing.Point(509, 47)
Me.GroupOgone.Name = "GroupOgone"
Me.GroupOgone.Size = New System.Drawing.Size(552, 162)
Me.GroupOgone.TabIndex = 57
Me.GroupOgone.Text = "OGONE"
'
'PanelOgone
'
Me.PanelOgone.Anchor = System.Windows.Forms.AnchorStyles.None
Me.PanelOgone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelOgone.Controls.Add(Me.txt_cc_expiration_date2)
Me.PanelOgone.Controls.Add(Me.cmb_cc_expiration_status2)
Me.PanelOgone.Controls.Add(Me.LabelControl55)
Me.PanelOgone.Controls.Add(Me.txt_cc_card_type2)
Me.PanelOgone.Controls.Add(Me.LabelControl56)
Me.PanelOgone.Controls.Add(Me.txt_cc_card_no2)
Me.PanelOgone.Controls.Add(Me.LabelControl57)
Me.PanelOgone.Controls.Add(Me.txt_cc_owner2)
Me.PanelOgone.Controls.Add(Me.LabelControl58)
Me.PanelOgone.Location = New System.Drawing.Point(6, 27)
Me.PanelOgone.Name = "PanelOgone"
Me.PanelOgone.Size = New System.Drawing.Size(538, 128)
Me.PanelOgone.TabIndex = 0
'
'txt_cc_expiration_date2
'
Me.txt_cc_expiration_date2.AllowDrop = true
Me.txt_cc_expiration_date2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_exp_date", true))
Me.txt_cc_expiration_date2.Enabled = false
Me.txt_cc_expiration_date2.Location = New System.Drawing.Point(170, 96)
Me.txt_cc_expiration_date2.Name = "txt_cc_expiration_date2"
Me.txt_cc_expiration_date2.Size = New System.Drawing.Size(197, 22)
Me.txt_cc_expiration_date2.TabIndex = 59
'
'cmb_cc_expiration_status2
'
Me.cmb_cc_expiration_status2.AllowDrop = true
Me.cmb_cc_expiration_status2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_cc_expiration_status", true))
Me.cmb_cc_expiration_status2.Enabled = false
Me.cmb_cc_expiration_status2.Location = New System.Drawing.Point(374, 96)
Me.cmb_cc_expiration_status2.Name = "cmb_cc_expiration_status2"
Me.cmb_cc_expiration_status2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmb_cc_expiration_status2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("cc_expiration_status_name", "Name", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmb_cc_expiration_status2.Properties.DataSource = Me.objDS.cc_expiration_status
Me.cmb_cc_expiration_status2.Properties.DisplayMember = "cc_expiration_status_name"
Me.cmb_cc_expiration_status2.Properties.NullText = ""
Me.cmb_cc_expiration_status2.Properties.ValueMember = "cc_expiration_status_id"
Me.cmb_cc_expiration_status2.Size = New System.Drawing.Size(153, 22)
Me.cmb_cc_expiration_status2.TabIndex = 58
'
'LabelControl55
'
Me.LabelControl55.Location = New System.Drawing.Point(11, 99)
Me.LabelControl55.Name = "LabelControl55"
Me.LabelControl55.Size = New System.Drawing.Size(135, 16)
Me.LabelControl55.TabIndex = 57
Me.LabelControl55.Text = "Expiration Date / Status"
'
'txt_cc_card_type2
'
Me.txt_cc_card_type2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_card_type", true))
Me.txt_cc_card_type2.Enabled = false
Me.txt_cc_card_type2.Location = New System.Drawing.Point(170, 6)
Me.txt_cc_card_type2.Name = "txt_cc_card_type2"
Me.txt_cc_card_type2.Size = New System.Drawing.Size(197, 22)
Me.txt_cc_card_type2.TabIndex = 55
'
'LabelControl56
'
Me.LabelControl56.Location = New System.Drawing.Point(11, 9)
Me.LabelControl56.Name = "LabelControl56"
Me.LabelControl56.Size = New System.Drawing.Size(59, 16)
Me.LabelControl56.TabIndex = 54
Me.LabelControl56.Text = "Card Type"
'
'txt_cc_card_no2
'
Me.txt_cc_card_no2.AllowDrop = true
Me.txt_cc_card_no2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_card_no", true))
Me.txt_cc_card_no2.Enabled = false
Me.txt_cc_card_no2.Location = New System.Drawing.Point(170, 66)
Me.txt_cc_card_no2.Name = "txt_cc_card_no2"
Me.txt_cc_card_no2.Size = New System.Drawing.Size(197, 22)
Me.txt_cc_card_no2.TabIndex = 53
'
'LabelControl57
'
Me.LabelControl57.Location = New System.Drawing.Point(11, 69)
Me.LabelControl57.Name = "LabelControl57"
Me.LabelControl57.Size = New System.Drawing.Size(46, 16)
Me.LabelControl57.TabIndex = 52
Me.LabelControl57.Text = "Card No"
'
'txt_cc_owner2
'
Me.txt_cc_owner2.AllowDrop = true
Me.txt_cc_owner2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.ogone_owner", true))
Me.txt_cc_owner2.Enabled = false
Me.txt_cc_owner2.Location = New System.Drawing.Point(170, 36)
Me.txt_cc_owner2.Name = "txt_cc_owner2"
Me.txt_cc_owner2.Size = New System.Drawing.Size(197, 22)
Me.txt_cc_owner2.TabIndex = 51
'
'LabelControl58
'
Me.LabelControl58.Location = New System.Drawing.Point(11, 39)
Me.LabelControl58.Name = "LabelControl58"
Me.LabelControl58.Size = New System.Drawing.Size(38, 16)
Me.LabelControl58.TabIndex = 50
Me.LabelControl58.Text = "Owner"
'
'BtnCancelPayment
'
Me.BtnCancelPayment.Location = New System.Drawing.Point(409, 231)
Me.BtnCancelPayment.Name = "BtnCancelPayment"
Me.BtnCancelPayment.Size = New System.Drawing.Size(163, 26)
Me.BtnCancelPayment.TabIndex = 54
Me.BtnCancelPayment.Text = "Cancel Payment"
'
'GroupDomiciliation
'
Me.GroupDomiciliation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GroupDomiciliation.Controls.Add(Me.panelDomiciliation)
Me.GroupDomiciliation.Location = New System.Drawing.Point(23, 47)
Me.GroupDomiciliation.Name = "GroupDomiciliation"
Me.GroupDomiciliation.Size = New System.Drawing.Size(449, 168)
Me.GroupDomiciliation.TabIndex = 56
Me.GroupDomiciliation.Text = "Domiciliation"
'
'panelDomiciliation
'
Me.panelDomiciliation.Anchor = System.Windows.Forms.AnchorStyles.None
Me.panelDomiciliation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.panelDomiciliation.Controls.Add(Me.txtDomAcctNumber)
Me.panelDomiciliation.Controls.Add(Me.LabelControl51)
Me.panelDomiciliation.Controls.Add(Me.txtDomNumber)
Me.panelDomiciliation.Controls.Add(Me.LabelControl52)
Me.panelDomiciliation.Controls.Add(Me.txtDomDebiterName)
Me.panelDomiciliation.Controls.Add(Me.LabelControl53)
Me.panelDomiciliation.Controls.Add(Me.cmbDomStatus)
Me.panelDomiciliation.Controls.Add(Me.LabelControl54)
Me.panelDomiciliation.Location = New System.Drawing.Point(4, 27)
Me.panelDomiciliation.Name = "panelDomiciliation"
Me.panelDomiciliation.Size = New System.Drawing.Size(439, 128)
Me.panelDomiciliation.TabIndex = 0
'
'txtDomAcctNumber
'
Me.txtDomAcctNumber.AllowDrop = true
Me.txtDomAcctNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.domiciliation_account_number", true))
Me.txtDomAcctNumber.Enabled = false
Me.txtDomAcctNumber.Location = New System.Drawing.Point(155, 96)
Me.txtDomAcctNumber.Name = "txtDomAcctNumber"
Me.txtDomAcctNumber.Size = New System.Drawing.Size(269, 22)
Me.txtDomAcctNumber.TabIndex = 53
'
'LabelControl51
'
Me.LabelControl51.Location = New System.Drawing.Point(18, 99)
Me.LabelControl51.Name = "LabelControl51"
Me.LabelControl51.Size = New System.Drawing.Size(124, 16)
Me.LabelControl51.TabIndex = 52
Me.LabelControl51.Text = "Dom Account Number"
'
'txtDomNumber
'
Me.txtDomNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.domiciliation_number", true))
Me.txtDomNumber.Enabled = false
Me.txtDomNumber.Location = New System.Drawing.Point(155, 66)
Me.txtDomNumber.Name = "txtDomNumber"
Me.txtDomNumber.Size = New System.Drawing.Size(269, 22)
Me.txtDomNumber.TabIndex = 51
'
'LabelControl52
'
Me.LabelControl52.Location = New System.Drawing.Point(18, 69)
Me.LabelControl52.Name = "LabelControl52"
Me.LabelControl52.Size = New System.Drawing.Size(75, 16)
Me.LabelControl52.TabIndex = 50
Me.LabelControl52.Text = "Dom Number"
'
'txtDomDebiterName
'
Me.txtDomDebiterName.AllowDrop = true
Me.txtDomDebiterName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.domiciliation_debiter_name", true))
Me.txtDomDebiterName.Enabled = false
Me.txtDomDebiterName.Location = New System.Drawing.Point(155, 36)
Me.txtDomDebiterName.Name = "txtDomDebiterName"
Me.txtDomDebiterName.Size = New System.Drawing.Size(269, 22)
Me.txtDomDebiterName.TabIndex = 49
'
'LabelControl53
'
Me.LabelControl53.Location = New System.Drawing.Point(18, 39)
Me.LabelControl53.Name = "LabelControl53"
Me.LabelControl53.Size = New System.Drawing.Size(78, 16)
Me.LabelControl53.TabIndex = 48
Me.LabelControl53.Text = "Debiter Name"
'
'cmbDomStatus
'
Me.cmbDomStatus.AllowDrop = true
Me.cmbDomStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.domiciliation_status", true))
Me.cmbDomStatus.Enabled = false
Me.cmbDomStatus.Location = New System.Drawing.Point(155, 6)
Me.cmbDomStatus.Name = "cmbDomStatus"
Me.cmbDomStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbDomStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("domiciliation_status_name", "Name", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbDomStatus.Properties.DataSource = Me.objDS.domiciliation_status
Me.cmbDomStatus.Properties.DisplayMember = "domiciliation_status_name"
Me.cmbDomStatus.Properties.NullText = ""
Me.cmbDomStatus.Properties.ValueMember = "domiciliation_status_id"
Me.cmbDomStatus.Size = New System.Drawing.Size(269, 22)
Me.cmbDomStatus.TabIndex = 47
'
'LabelControl54
'
Me.LabelControl54.Location = New System.Drawing.Point(18, 9)
Me.LabelControl54.Name = "LabelControl54"
Me.LabelControl54.Size = New System.Drawing.Size(112, 16)
Me.LabelControl54.TabIndex = 46
Me.LabelControl54.Text = "Domiciliation Status"
'
'CalcEdit1
'
Me.CalcEdit1.Enabled = false
Me.CalcEdit1.Location = New System.Drawing.Point(762, 17)
Me.CalcEdit1.Name = "CalcEdit1"
Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.CalcEdit1.Size = New System.Drawing.Size(120, 22)
Me.CalcEdit1.TabIndex = 55
Me.CalcEdit1.Visible = false
'
'LabelControl48
'
Me.LabelControl48.Location = New System.Drawing.Point(676, 21)
Me.LabelControl48.Name = "LabelControl48"
Me.LabelControl48.Size = New System.Drawing.Size(78, 16)
Me.LabelControl48.TabIndex = 54
Me.LabelControl48.Text = "Open Amount"
Me.LabelControl48.Visible = false
'
'CalcEdit
'
Me.CalcEdit.Enabled = false
Me.CalcEdit.Location = New System.Drawing.Point(505, 17)
Me.CalcEdit.Name = "CalcEdit"
Me.CalcEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.CalcEdit.Size = New System.Drawing.Size(120, 22)
Me.CalcEdit.TabIndex = 53
Me.CalcEdit.Visible = false
'
'LabelControl49
'
Me.LabelControl49.Location = New System.Drawing.Point(476, 21)
Me.LabelControl49.Name = "LabelControl49"
Me.LabelControl49.Size = New System.Drawing.Size(16, 16)
Me.LabelControl49.TabIndex = 52
Me.LabelControl49.Text = "CA"
Me.LabelControl49.Visible = false
'
'cmbPayMethod
'
Me.cmbPayMethod.AllowDrop = true
Me.cmbPayMethod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_payment_method", true))
Me.cmbPayMethod.Enabled = false
Me.cmbPayMethod.Location = New System.Drawing.Point(154, 17)
Me.cmbPayMethod.Name = "cmbPayMethod"
Me.cmbPayMethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbPayMethod.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("customers_abo_payment_method_name", "Name", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbPayMethod.Properties.DataSource = Me.objDS.customers_abo_payment_method
Me.cmbPayMethod.Properties.DisplayMember = "customers_abo_payment_method_name"
Me.cmbPayMethod.Properties.NullText = ""
Me.cmbPayMethod.Properties.ValueMember = "customers_abo_payment_method_id"
Me.cmbPayMethod.Size = New System.Drawing.Size(268, 22)
Me.cmbPayMethod.TabIndex = 51
'
'LabelControl50
'
Me.LabelControl50.Location = New System.Drawing.Point(23, 21)
Me.LabelControl50.Name = "LabelControl50"
Me.LabelControl50.Size = New System.Drawing.Size(95, 16)
Me.LabelControl50.TabIndex = 50
Me.LabelControl50.Text = "Payment Method"
'
'GridColumn59
'
Me.GridColumn59.Name = "GridColumn59"
'
'GridColumn60
'
Me.GridColumn60.Name = "GridColumn60"
'
'GridColumn61
'
Me.GridColumn61.Name = "GridColumn61"
'
'GridColumn62
'
Me.GridColumn62.Name = "GridColumn62"
'
'GridColumn63
'
Me.GridColumn63.Name = "GridColumn63"
'
'colwl_id2
'
Me.colwl_id2.Name = "colwl_id2"
'
'colcustomers_id8
'
Me.colcustomers_id8.Name = "colcustomers_id8"
'
'colproduct_id2
'
Me.colproduct_id2.Name = "colproduct_id2"
'
'colrank2
'
Me.colrank2.Name = "colrank2"
'
'colpriority1
'
Me.colpriority1.Name = "colpriority1"
'
'coldate_added7
'
Me.coldate_added7.Name = "coldate_added7"
'
'colwishlist_type2
'
Me.colwishlist_type2.Name = "colwishlist_type2"
'
'colproducts_title2
'
Me.colproducts_title2.Name = "colproducts_title2"
'
'colqty_in_stock1
'
Me.colqty_in_stock1.Name = "colqty_in_stock1"
'
'GridWishList
'
Me.GridWishList.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridWishList.EmbeddedNavigator.Name = ""
Me.GridWishList.FormsUseDefaultLookAndFeel = false
Me.GridWishList.Location = New System.Drawing.Point(2, 153)
Me.GridWishList.MainView = Me.GridViewWishList
Me.GridWishList.Name = "GridWishList"
Me.GridWishList.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btnSendIt, Me.checkAvailibility})
Me.GridWishList.Size = New System.Drawing.Size(727, 750)
Me.GridWishList.TabIndex = 0
Me.GridWishList.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewWishList})
'
'GridViewWishList
'
Me.GridViewWishList.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand2})
Me.GridViewWishList.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colwl_id, Me.colproduct_id, Me.colrank, Me.colpriority, Me.colwishlist_type, Me.colproducts_title, Me.colqty_in_stock, Me.colSendIt, Me.colProducts_availability, Me.DateAdded, Me.products_date_available, Me.colProducts_next, Me.colProductsstatus, Me.colSourceAdded, Me.colserieid, Me.colserienumber})
Me.GridViewWishList.CustomizationFormBounds = New System.Drawing.Rectangle(1083, 490, 208, 191)
Me.GridViewWishList.GridControl = Me.GridWishList
Me.GridViewWishList.GroupCount = 2
Me.GridViewWishList.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewWishList.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "wishlist_type", Nothing, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "series_id", Nothing, "")})
Me.GridViewWishList.Name = "GridViewWishList"
Me.GridViewWishList.OptionsView.ShowBands = false
Me.GridViewWishList.OptionsView.ShowFooter = true
Me.GridViewWishList.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colwishlist_type, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colserieid, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colserienumber, DevExpress.Data.ColumnSortOrder.Ascending)})
'
'GridBand2
'
Me.GridBand2.Caption = "GridBand2"
Me.GridBand2.Columns.Add(Me.colSendIt)
Me.GridBand2.Columns.Add(Me.colwishlist_type)
Me.GridBand2.Columns.Add(Me.colserieid)
Me.GridBand2.Columns.Add(Me.DateAdded)
Me.GridBand2.Columns.Add(Me.colwl_id)
Me.GridBand2.Columns.Add(Me.colproduct_id)
Me.GridBand2.Columns.Add(Me.colrank)
Me.GridBand2.Columns.Add(Me.colpriority)
Me.GridBand2.Columns.Add(Me.colproducts_title)
Me.GridBand2.Columns.Add(Me.products_date_available)
Me.GridBand2.Columns.Add(Me.colqty_in_stock)
Me.GridBand2.Columns.Add(Me.colProducts_next)
Me.GridBand2.Columns.Add(Me.colProductsstatus)
Me.GridBand2.Columns.Add(Me.colProducts_availability)
Me.GridBand2.MinWidth = 20
Me.GridBand2.Name = "GridBand2"
Me.GridBand2.Width = 1180
'
'colSendIt
'
Me.colSendIt.Caption = "Send It"
Me.colSendIt.ColumnEdit = Me.btnSendIt
Me.colSendIt.Name = "colSendIt"
Me.colSendIt.Visible = true
'
'btnSendIt
'
Me.btnSendIt.AutoHeight = false
Me.btnSendIt.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.btnSendIt.Name = "btnSendIt"
Me.btnSendIt.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
'
'colwishlist_type
'
Me.colwishlist_type.Caption = "wishlist_type"
Me.colwishlist_type.FieldName = "wishlist_type"
Me.colwishlist_type.Name = "colwishlist_type"
Me.colwishlist_type.OptionsColumn.AllowEdit = false
Me.colwishlist_type.OptionsColumn.ReadOnly = true
Me.colwishlist_type.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
Me.colwishlist_type.Visible = true
Me.colwishlist_type.Width = 87
'
'colserieid
'
Me.colserieid.Caption = "serie_id"
Me.colserieid.FieldName = "products_series_id"
Me.colserieid.Name = "colserieid"
Me.colserieid.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
Me.colserieid.Visible = true
'
'DateAdded
'
Me.DateAdded.Caption = "date_added"
Me.DateAdded.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.DateAdded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.DateAdded.FieldName = "date_added"
Me.DateAdded.Name = "DateAdded"
Me.DateAdded.OptionsColumn.AllowEdit = false
Me.DateAdded.OptionsColumn.ReadOnly = true
Me.DateAdded.Visible = true
Me.DateAdded.Width = 109
'
'colwl_id
'
Me.colwl_id.Caption = "wl_id"
Me.colwl_id.FieldName = "wl_id"
Me.colwl_id.Name = "colwl_id"
Me.colwl_id.OptionsColumn.ReadOnly = true
'
'colproduct_id
'
Me.colproduct_id.AppearanceCell.ForeColor = System.Drawing.Color.Blue
Me.colproduct_id.AppearanceCell.Options.UseForeColor = true
Me.colproduct_id.Caption = "products_id"
Me.colproduct_id.FieldName = "product_id"
Me.colproduct_id.Name = "colproduct_id"
Me.colproduct_id.OptionsColumn.ReadOnly = true
Me.colproduct_id.ToolTip = "double click to open product fiche"
Me.colproduct_id.Visible = true
Me.colproduct_id.Width = 74
'
'colrank
'
Me.colrank.Caption = "rank"
Me.colrank.FieldName = "rank"
Me.colrank.Name = "colrank"
Me.colrank.OptionsColumn.AllowEdit = false
Me.colrank.OptionsColumn.ReadOnly = true
Me.colrank.Width = 44
'
'colpriority
'
Me.colpriority.Caption = "priority"
Me.colpriority.FieldName = "priority"
Me.colpriority.Name = "colpriority"
Me.colpriority.OptionsColumn.AllowEdit = false
Me.colpriority.OptionsColumn.ReadOnly = true
Me.colpriority.Visible = true
Me.colpriority.Width = 57
'
'colproducts_title
'
Me.colproducts_title.Caption = "products_title"
Me.colproducts_title.FieldName = "products_title_description"
Me.colproducts_title.Name = "colproducts_title"
Me.colproducts_title.OptionsColumn.AllowEdit = false
Me.colproducts_title.OptionsColumn.ReadOnly = true
Me.colproducts_title.Visible = true
Me.colproducts_title.Width = 144
'
'products_date_available
'
Me.products_date_available.Caption = "products_date_available"
Me.products_date_available.FieldName = "products_date_available"
Me.products_date_available.Name = "products_date_available"
Me.products_date_available.OptionsColumn.AllowEdit = false
Me.products_date_available.OptionsColumn.ReadOnly = true
Me.products_date_available.Visible = true
Me.products_date_available.Width = 142
'
'colqty_in_stock
'
Me.colqty_in_stock.Caption = "qty_in_stock"
Me.colqty_in_stock.FieldName = "qty_in_stock"
Me.colqty_in_stock.Name = "colqty_in_stock"
Me.colqty_in_stock.OptionsColumn.AllowEdit = false
Me.colqty_in_stock.OptionsColumn.ReadOnly = true
Me.colqty_in_stock.Visible = true
Me.colqty_in_stock.Width = 87
'
'colProducts_next
'
Me.colProducts_next.Caption = "Products_Next"
Me.colProducts_next.ColumnEdit = Me.checkAvailibility
Me.colProducts_next.FieldName = "products_next"
Me.colProducts_next.Name = "colProducts_next"
Me.colProducts_next.Visible = true
Me.colProducts_next.Width = 98
'
'checkAvailibility
'
Me.checkAvailibility.AutoHeight = false
Me.checkAvailibility.Name = "checkAvailibility"
Me.checkAvailibility.ReadOnly = true
Me.checkAvailibility.ValueChecked = 1
Me.checkAvailibility.ValueUnchecked = 0
'
'colProductsstatus
'
Me.colProductsstatus.Caption = "Products_status"
Me.colProductsstatus.FieldName = "products_status"
Me.colProductsstatus.Name = "colProductsstatus"
Me.colProductsstatus.Visible = true
Me.colProductsstatus.Width = 108
'
'colProducts_availability
'
Me.colProducts_availability.Caption = "products_availability"
Me.colProducts_availability.FieldName = "products_availability"
Me.colProducts_availability.Name = "colProducts_availability"
Me.colProducts_availability.Visible = true
Me.colProducts_availability.Width = 124
'
'colSourceAdded
'
Me.colSourceAdded.Caption = "source_added"
Me.colSourceAdded.FieldName = "source_added"
Me.colSourceAdded.Name = "colSourceAdded"
'
'colserienumber
'
Me.colserienumber.Caption = "serie number"
Me.colserienumber.FieldName = "products_series_number"
Me.colserienumber.Name = "colserienumber"
Me.colserienumber.Visible = true
'
'tabCustServ
'
Me.tabCustServ.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
Me.tabCustServ.Appearance.Header.Options.UseFont = true
Me.tabCustServ.Controls.Add(Me.PanelControl7)
Me.tabCustServ.Controls.Add(Me.SPlitCCustserv)
Me.tabCustServ.Controls.Add(Me.GridCustServ)
Me.tabCustServ.Name = "tabCustServ"
Me.tabCustServ.PageEnabled = false
Me.tabCustServ.PageVisible = false
Me.tabCustServ.Size = New System.Drawing.Size(1505, 905)
Me.tabCustServ.Text = "Cust Serv"
'
'PanelControl7
'
Me.PanelControl7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl7.Controls.Add(Me.PanelControl8)
Me.PanelControl7.Controls.Add(Me.GCCustServ)
Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelControl7.Location = New System.Drawing.Point(812, 0)
Me.PanelControl7.Name = "PanelControl7"
Me.PanelControl7.Size = New System.Drawing.Size(693, 905)
Me.PanelControl7.TabIndex = 3
'
'PanelControl8
'
Me.PanelControl8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl8.Controls.Add(Me.LayoutCustServ)
Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
Me.PanelControl8.Location = New System.Drawing.Point(2, 75)
Me.PanelControl8.Name = "PanelControl8"
Me.PanelControl8.Size = New System.Drawing.Size(689, 828)
Me.PanelControl8.TabIndex = 1
'
'LayoutCustServ
'
Me.LayoutCustServ.Controls.Add(Me.txtCustServ_Response_Message)
Me.LayoutCustServ.Controls.Add(Me.txtCustServ_DVD_ID)
Me.LayoutCustServ.Controls.Add(Me.txtCustServ_Products_id)
Me.LayoutCustServ.Controls.Add(Me.txtCustServ_OrderID)
Me.LayoutCustServ.Controls.Add(Me.txtCustServ_CustDate)
Me.LayoutCustServ.Controls.Add(Me.MemoEdit1)
Me.LayoutCustServ.Controls.Add(Me.txtCustServ_Subject)
Me.LayoutCustServ.DataSource = Me.objDS.custserv
Me.LayoutCustServ.Dock = System.Windows.Forms.DockStyle.Fill
Me.LayoutCustServ.Location = New System.Drawing.Point(2, 2)
Me.LayoutCustServ.Name = "LayoutCustServ"
Me.LayoutCustServ.Root = Me.LayoutControlGroup1
Me.LayoutCustServ.Size = New System.Drawing.Size(685, 824)
Me.LayoutCustServ.TabIndex = 0
Me.LayoutCustServ.Text = "DataLayoutControl1"
'
'txtCustServ_Response_Message
'
Me.txtCustServ_Response_Message.Location = New System.Drawing.Point(124, 516)
Me.txtCustServ_Response_Message.Name = "txtCustServ_Response_Message"
Me.txtCustServ_Response_Message.Size = New System.Drawing.Size(552, 299)
Me.txtCustServ_Response_Message.StyleController = Me.LayoutCustServ
Me.txtCustServ_Response_Message.TabIndex = 14
'
'txtCustServ_DVD_ID
'
Me.txtCustServ_DVD_ID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "custserv.dvd_id", true))
Me.txtCustServ_DVD_ID.Location = New System.Drawing.Point(574, 424)
Me.txtCustServ_DVD_ID.Name = "txtCustServ_DVD_ID"
Me.txtCustServ_DVD_ID.Properties.ReadOnly = true
Me.txtCustServ_DVD_ID.Size = New System.Drawing.Size(102, 22)
Me.txtCustServ_DVD_ID.StyleController = Me.LayoutCustServ
Me.txtCustServ_DVD_ID.TabIndex = 11
'
'txtCustServ_Products_id
'
Me.txtCustServ_Products_id.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "custserv.products_id", true))
Me.txtCustServ_Products_id.Location = New System.Drawing.Point(349, 424)
Me.txtCustServ_Products_id.Name = "txtCustServ_Products_id"
Me.txtCustServ_Products_id.Properties.ReadOnly = true
Me.txtCustServ_Products_id.Size = New System.Drawing.Size(100, 22)
Me.txtCustServ_Products_id.StyleController = Me.LayoutCustServ
Me.txtCustServ_Products_id.TabIndex = 10
'
'txtCustServ_OrderID
'
Me.txtCustServ_OrderID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "custserv.orders_id", true))
Me.txtCustServ_OrderID.Location = New System.Drawing.Point(124, 424)
Me.txtCustServ_OrderID.Name = "txtCustServ_OrderID"
Me.txtCustServ_OrderID.Properties.ReadOnly = true
Me.txtCustServ_OrderID.Size = New System.Drawing.Size(100, 22)
Me.txtCustServ_OrderID.StyleController = Me.LayoutCustServ
Me.txtCustServ_OrderID.TabIndex = 9
'
'txtCustServ_CustDate
'
Me.txtCustServ_CustDate.EditValue = Nothing
Me.txtCustServ_CustDate.Location = New System.Drawing.Point(124, 30)
Me.txtCustServ_CustDate.Name = "txtCustServ_CustDate"
Me.txtCustServ_CustDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.txtCustServ_CustDate.Properties.ReadOnly = true
Me.txtCustServ_CustDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtCustServ_CustDate.Size = New System.Drawing.Size(552, 22)
Me.txtCustServ_CustDate.StyleController = Me.LayoutCustServ
Me.txtCustServ_CustDate.TabIndex = 8
'
'MemoEdit1
'
Me.MemoEdit1.Location = New System.Drawing.Point(124, 63)
Me.MemoEdit1.Name = "MemoEdit1"
Me.MemoEdit1.Properties.ReadOnly = true
Me.MemoEdit1.Size = New System.Drawing.Size(552, 324)
Me.MemoEdit1.StyleController = Me.LayoutCustServ
Me.MemoEdit1.TabIndex = 7
'
'txtCustServ_Subject
'
Me.txtCustServ_Subject.Location = New System.Drawing.Point(121, 460)
Me.txtCustServ_Subject.Name = "txtCustServ_Subject"
Me.txtCustServ_Subject.Size = New System.Drawing.Size(558, 22)
Me.txtCustServ_Subject.StyleController = Me.LayoutCustServ
Me.txtCustServ_Subject.TabIndex = 6
'
'LayoutControlGroup1
'
Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup1"
Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LCGMisc, Me.LayoutControlGroup3, Me.LCGResponse, Me.LayoutControlItem3})
Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
Me.LayoutControlGroup1.Size = New System.Drawing.Size(685, 824)
Me.LayoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
Me.LayoutControlGroup1.Text = "LayoutControlGroup1"
Me.LayoutControlGroup1.TextVisible = false
'
'LCGMisc
'
Me.LCGMisc.CustomizationFormText = "Misc"
Me.LCGMisc.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem8})
Me.LCGMisc.Location = New System.Drawing.Point(0, 394)
Me.LCGMisc.Name = "LCGMisc"
Me.LCGMisc.Size = New System.Drawing.Size(683, 59)
Me.LCGMisc.Text = "Misc"
'
'LayoutControlItem7
'
Me.LayoutControlItem7.Control = Me.txtCustServ_Products_id
Me.LayoutControlItem7.CustomizationFormText = "Products ID"
Me.LayoutControlItem7.Location = New System.Drawing.Point(225, 0)
Me.LayoutControlItem7.Name = "LayoutControlItem7"
Me.LayoutControlItem7.Size = New System.Drawing.Size(225, 33)
Me.LayoutControlItem7.Text = "Products ID"
Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
Me.LayoutControlItem7.TextSize = New System.Drawing.Size(109, 20)
'
'LayoutControlItem6
'
Me.LayoutControlItem6.Control = Me.txtCustServ_OrderID
Me.LayoutControlItem6.CustomizationFormText = "Order ID"
Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
Me.LayoutControlItem6.Name = "LayoutControlItem6"
Me.LayoutControlItem6.Size = New System.Drawing.Size(225, 33)
Me.LayoutControlItem6.Text = "Order ID"
Me.LayoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
Me.LayoutControlItem6.TextSize = New System.Drawing.Size(109, 20)
'
'LayoutControlItem8
'
Me.LayoutControlItem8.Control = Me.txtCustServ_DVD_ID
Me.LayoutControlItem8.CustomizationFormText = "DVD ID"
Me.LayoutControlItem8.Location = New System.Drawing.Point(450, 0)
Me.LayoutControlItem8.Name = "LayoutControlItem8"
Me.LayoutControlItem8.Size = New System.Drawing.Size(227, 33)
Me.LayoutControlItem8.Text = "DVD ID"
Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
Me.LayoutControlItem8.TextSize = New System.Drawing.Size(109, 20)
'
'LayoutControlGroup3
'
Me.LayoutControlGroup3.CustomizationFormText = "Call / E-Mail Info"
Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem4})
Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
Me.LayoutControlGroup3.Size = New System.Drawing.Size(683, 394)
Me.LayoutControlGroup3.Text = "Call / E-Mail Info"
'
'LayoutControlItem5
'
Me.LayoutControlItem5.Control = Me.txtCustServ_CustDate
Me.LayoutControlItem5.CustomizationFormText = "Date"
Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
Me.LayoutControlItem5.Name = "LayoutControlItem5"
Me.LayoutControlItem5.Size = New System.Drawing.Size(677, 33)
Me.LayoutControlItem5.Text = "Date"
Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
Me.LayoutControlItem5.TextSize = New System.Drawing.Size(109, 20)
'
'LayoutControlItem4
'
Me.LayoutControlItem4.Control = Me.MemoEdit1
Me.LayoutControlItem4.CustomizationFormText = "Message"
Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 33)
Me.LayoutControlItem4.Name = "LayoutControlItem4"
Me.LayoutControlItem4.Size = New System.Drawing.Size(677, 335)
Me.LayoutControlItem4.Text = "Message"
Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
Me.LayoutControlItem4.TextSize = New System.Drawing.Size(109, 20)
'
'LCGResponse
'
Me.LCGResponse.CustomizationFormText = "Response"
Me.LCGResponse.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem11})
Me.LCGResponse.Location = New System.Drawing.Point(0, 486)
Me.LCGResponse.Name = "LCGResponse"
Me.LCGResponse.Size = New System.Drawing.Size(683, 336)
Me.LCGResponse.Text = "Response"
'
'LayoutControlItem11
'
Me.LayoutControlItem11.Control = Me.txtCustServ_Response_Message
Me.LayoutControlItem11.CustomizationFormText = "Response Message"
Me.LayoutControlItem11.Location = New System.Drawing.Point(0, 0)
Me.LayoutControlItem11.Name = "LayoutControlItem11"
Me.LayoutControlItem11.Size = New System.Drawing.Size(677, 310)
Me.LayoutControlItem11.Text = "Response Message"
Me.LayoutControlItem11.TextLocation = DevExpress.Utils.Locations.Left
Me.LayoutControlItem11.TextSize = New System.Drawing.Size(109, 20)
'
'LayoutControlItem3
'
Me.LayoutControlItem3.Control = Me.txtCustServ_Subject
Me.LayoutControlItem3.CustomizationFormText = "Subject"
Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 453)
Me.LayoutControlItem3.Name = "LayoutControlItem3"
Me.LayoutControlItem3.Size = New System.Drawing.Size(683, 33)
Me.LayoutControlItem3.Text = "Subject"
Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
Me.LayoutControlItem3.TextSize = New System.Drawing.Size(109, 20)
'
'GCCustServ
'
Me.GCCustServ.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCCustServ.Controls.Add(Me.chkCustServSendMail)
Me.GCCustServ.Controls.Add(Me.btnSaveCustServ)
Me.GCCustServ.Dock = System.Windows.Forms.DockStyle.Top
Me.GCCustServ.Location = New System.Drawing.Point(2, 2)
Me.GCCustServ.Name = "GCCustServ"
Me.GCCustServ.Size = New System.Drawing.Size(689, 73)
Me.GCCustServ.TabIndex = 0
Me.GCCustServ.Text = "Call / Action Detail"
'
'chkCustServSendMail
'
Me.chkCustServSendMail.EditValue = 1
Me.chkCustServSendMail.Location = New System.Drawing.Point(119, 35)
Me.chkCustServSendMail.Name = "chkCustServSendMail"
Me.chkCustServSendMail.Properties.Caption = "Send Email"
Me.chkCustServSendMail.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
Me.chkCustServSendMail.Properties.ValueChecked = 1
Me.chkCustServSendMail.Properties.ValueUnchecked = 0
Me.chkCustServSendMail.Size = New System.Drawing.Size(115, 21)
Me.chkCustServSendMail.TabIndex = 31
'
'btnSaveCustServ
'
Me.btnSaveCustServ.Location = New System.Drawing.Point(5, 31)
Me.btnSaveCustServ.Name = "btnSaveCustServ"
Me.btnSaveCustServ.Size = New System.Drawing.Size(90, 27)
Me.btnSaveCustServ.TabIndex = 9
Me.btnSaveCustServ.Text = "Save"
'
'SPlitCCustserv
'
Me.SPlitCCustserv.Location = New System.Drawing.Point(806, 0)
Me.SPlitCCustserv.Name = "SPlitCCustserv"
Me.SPlitCCustserv.Size = New System.Drawing.Size(6, 905)
Me.SPlitCCustserv.TabIndex = 2
Me.SPlitCCustserv.TabStop = false
'
'GridWishListAssigned
'
Me.GridWishListAssigned.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridWishListAssigned.EmbeddedNavigator.Name = ""
Me.GridWishListAssigned.FormsUseDefaultLookAndFeel = false
Me.GridWishListAssigned.Location = New System.Drawing.Point(2, 22)
Me.GridWishListAssigned.MainView = Me.GridViewWishListAssigned
Me.GridWishListAssigned.Name = "GridWishListAssigned"
Me.GridWishListAssigned.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryIbtnAddDVD})
Me.GridWishListAssigned.Size = New System.Drawing.Size(764, 881)
Me.GridWishListAssigned.TabIndex = 2
Me.GridWishListAssigned.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewWishListAssigned})
'
'GridViewWishListAssigned
'
Me.GridViewWishListAssigned.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand3})
Me.GridViewWishListAssigned.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colAddDvd, Me.colwl_assigned_id, Me.colwl_id1, Me.colrprioritywish, Me.coldate_assigned, Me.colwishlist_type1, Me.colproducts_title1, Me.colWAdate_added, Me.colWAProducts_id, Me.colsourceaddedAssigned, Me.colserieIdAssigned, Me.colseriesNumberAssigned})
Me.GridViewWishListAssigned.CustomizationFormBounds = New System.Drawing.Rectangle(883, 417, 208, 191)
Me.GridViewWishListAssigned.GridControl = Me.GridWishListAssigned
Me.GridViewWishListAssigned.GroupCount = 2
Me.GridViewWishListAssigned.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewWishListAssigned.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "wishlist_type", Nothing, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "products_series_id", Nothing, "")})
Me.GridViewWishListAssigned.Name = "GridViewWishListAssigned"
Me.GridViewWishListAssigned.OptionsView.ShowBands = false
Me.GridViewWishListAssigned.OptionsView.ShowFooter = true
Me.GridViewWishListAssigned.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colwishlist_type1, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colserieIdAssigned, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colseriesNumberAssigned, DevExpress.Data.ColumnSortOrder.Ascending)})
'
'GridBand3
'
Me.GridBand3.Caption = "GridBand2"
Me.GridBand3.Columns.Add(Me.colAddDvd)
Me.GridBand3.Columns.Add(Me.colwishlist_type1)
Me.GridBand3.Columns.Add(Me.colwl_assigned_id)
Me.GridBand3.Columns.Add(Me.colwl_id1)
Me.GridBand3.Columns.Add(Me.colrprioritywish)
Me.GridBand3.Columns.Add(Me.coldate_assigned)
Me.GridBand3.Columns.Add(Me.colWAdate_added)
Me.GridBand3.Columns.Add(Me.colproducts_title1)
Me.GridBand3.Columns.Add(Me.colWAProducts_id)
Me.GridBand3.MinWidth = 20
Me.GridBand3.Name = "GridBand3"
Me.GridBand3.Width = 619
'
'colAddDvd
'
Me.colAddDvd.Caption = "add dvd"
Me.colAddDvd.ColumnEdit = Me.RepositoryIbtnAddDVD
Me.colAddDvd.FieldName = "colAddDvd"
Me.colAddDvd.Name = "colAddDvd"
Me.colAddDvd.Visible = true
'
'RepositoryIbtnAddDVD
'
Me.RepositoryIbtnAddDVD.AutoHeight = false
Me.RepositoryIbtnAddDVD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "add dvd", -1, true, true, false, DevExpress.Utils.HorzAlignment.Center, Nothing)})
Me.RepositoryIbtnAddDVD.Name = "RepositoryIbtnAddDVD"
Me.RepositoryIbtnAddDVD.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
'
'colwishlist_type1
'
Me.colwishlist_type1.Caption = "wishlist_type"
Me.colwishlist_type1.FieldName = "wishlist_type"
Me.colwishlist_type1.Name = "colwishlist_type1"
Me.colwishlist_type1.OptionsColumn.AllowEdit = false
Me.colwishlist_type1.OptionsColumn.ReadOnly = true
Me.colwishlist_type1.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
Me.colwishlist_type1.Visible = true
'
'colwl_assigned_id
'
Me.colwl_assigned_id.Caption = "wl_assigned_id"
Me.colwl_assigned_id.FieldName = "wl_assigned_id"
Me.colwl_assigned_id.Name = "colwl_assigned_id"
Me.colwl_assigned_id.OptionsColumn.AllowEdit = false
Me.colwl_assigned_id.OptionsColumn.ReadOnly = true
'
'colwl_id1
'
Me.colwl_id1.Caption = "wl_id"
Me.colwl_id1.FieldName = "wl_id"
Me.colwl_id1.Name = "colwl_id1"
Me.colwl_id1.OptionsColumn.AllowEdit = false
Me.colwl_id1.OptionsColumn.ReadOnly = true
'
'colrprioritywish
'
Me.colrprioritywish.Caption = "priority"
Me.colrprioritywish.FieldName = "priority"
Me.colrprioritywish.Name = "colrprioritywish"
Me.colrprioritywish.OptionsColumn.AllowEdit = false
Me.colrprioritywish.OptionsColumn.ReadOnly = true
Me.colrprioritywish.Visible = true
'
'coldate_assigned
'
Me.coldate_assigned.Caption = "date_assigned"
Me.coldate_assigned.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.coldate_assigned.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.coldate_assigned.FieldName = "date_assigned"
Me.coldate_assigned.Name = "coldate_assigned"
Me.coldate_assigned.OptionsColumn.AllowEdit = false
Me.coldate_assigned.OptionsColumn.ReadOnly = true
Me.coldate_assigned.Visible = true
'
'colWAdate_added
'
Me.colWAdate_added.Caption = "wishlist_date_added"
Me.colWAdate_added.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.colWAdate_added.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.colWAdate_added.FieldName = "date_added"
Me.colWAdate_added.Name = "colWAdate_added"
Me.colWAdate_added.OptionsColumn.AllowEdit = false
Me.colWAdate_added.OptionsColumn.ReadOnly = true
Me.colWAdate_added.Visible = true
Me.colWAdate_added.Width = 119
'
'colproducts_title1
'
Me.colproducts_title1.Caption = "products_title"
Me.colproducts_title1.FieldName = "products_title_description"
Me.colproducts_title1.Name = "colproducts_title1"
Me.colproducts_title1.OptionsColumn.AllowEdit = false
Me.colproducts_title1.OptionsColumn.ReadOnly = true
Me.colproducts_title1.Visible = true
Me.colproducts_title1.Width = 125
'
'colWAProducts_id
'
Me.colWAProducts_id.Caption = "products_id"
Me.colWAProducts_id.FieldName = "products_id"
Me.colWAProducts_id.Name = "colWAProducts_id"
Me.colWAProducts_id.Visible = true
'
'colsourceaddedAssigned
'
Me.colsourceaddedAssigned.Caption = "source_added"
Me.colsourceaddedAssigned.FieldName = "source_added"
Me.colsourceaddedAssigned.Name = "colsourceaddedAssigned"
'
'colserieIdAssigned
'
Me.colserieIdAssigned.Caption = "series_id"
Me.colserieIdAssigned.FieldName = "products_series_id"
Me.colserieIdAssigned.Name = "colserieIdAssigned"
'
'colseriesNumberAssigned
'
Me.colseriesNumberAssigned.Caption = "series_number"
Me.colseriesNumberAssigned.FieldName = "products_series_number"
Me.colseriesNumberAssigned.Name = "colseriesNumberAssigned"
'
'coldomiciliation_payment_id2
'
Me.coldomiciliation_payment_id2.Caption = "domiciliation_payment_id"
Me.coldomiciliation_payment_id2.FieldName = "domiciliation_payment_id"
Me.coldomiciliation_payment_id2.Name = "coldomiciliation_payment_id2"
Me.coldomiciliation_payment_id2.Visible = true
Me.coldomiciliation_payment_id2.VisibleIndex = 0
'
'coldomiciliation_payment_date2
'
Me.coldomiciliation_payment_date2.Caption = "domiciliation_payment_date"
Me.coldomiciliation_payment_date2.FieldName = "domiciliation_payment_date"
Me.coldomiciliation_payment_date2.Name = "coldomiciliation_payment_date2"
Me.coldomiciliation_payment_date2.Visible = true
Me.coldomiciliation_payment_date2.VisibleIndex = 1
'
'colabo_id4
'
Me.colabo_id4.Caption = "abo_id"
Me.colabo_id4.FieldName = "abo_id"
Me.colabo_id4.Name = "colabo_id4"
Me.colabo_id4.Visible = true
Me.colabo_id4.VisibleIndex = 2
'
'colcustomers_name2
'
Me.colcustomers_name2.Caption = "customers_name"
Me.colcustomers_name2.FieldName = "customers_name"
Me.colcustomers_name2.Name = "colcustomers_name2"
Me.colcustomers_name2.Visible = true
Me.colcustomers_name2.VisibleIndex = 4
'
'colcustomers_address2
'
Me.colcustomers_address2.Caption = "customers_address"
Me.colcustomers_address2.FieldName = "customers_address"
Me.colcustomers_address2.Name = "colcustomers_address2"
Me.colcustomers_address2.Visible = true
Me.colcustomers_address2.VisibleIndex = 5
'
'colamount6
'
Me.colamount6.Caption = "amount"
Me.colamount6.FieldName = "amount"
Me.colamount6.Name = "colamount6"
Me.colamount6.Visible = true
Me.colamount6.VisibleIndex = 6
'
'colstrdomiciliation_debiter_name2
'
Me.colstrdomiciliation_debiter_name2.Caption = "strdomiciliation_debiter_name"
Me.colstrdomiciliation_debiter_name2.FieldName = "strdomiciliation_debiter_name"
Me.colstrdomiciliation_debiter_name2.Name = "colstrdomiciliation_debiter_name2"
Me.colstrdomiciliation_debiter_name2.Visible = true
Me.colstrdomiciliation_debiter_name2.VisibleIndex = 7
'
'colstrdomiciliation_number2
'
Me.colstrdomiciliation_number2.Caption = "strdomiciliation_number"
Me.colstrdomiciliation_number2.FieldName = "strdomiciliation_number"
Me.colstrdomiciliation_number2.Name = "colstrdomiciliation_number2"
Me.colstrdomiciliation_number2.Visible = true
Me.colstrdomiciliation_number2.VisibleIndex = 8
'
'colcommunication4
'
Me.colcommunication4.Caption = "communication"
Me.colcommunication4.FieldName = "communication"
Me.colcommunication4.Name = "colcommunication4"
Me.colcommunication4.Visible = true
Me.colcommunication4.VisibleIndex = 9
'
'colfirst_payment2
'
Me.colfirst_payment2.Caption = "first_payment"
Me.colfirst_payment2.FieldName = "first_payment"
Me.colfirst_payment2.Name = "colfirst_payment2"
Me.colfirst_payment2.Visible = true
Me.colfirst_payment2.VisibleIndex = 10
'
'colreconduction2
'
Me.colreconduction2.Caption = "reconduction"
Me.colreconduction2.FieldName = "reconduction"
Me.colreconduction2.Name = "colreconduction2"
Me.colreconduction2.Visible = true
Me.colreconduction2.VisibleIndex = 11
'
'coldomiciliation_payment_status2
'
Me.coldomiciliation_payment_status2.Caption = "payment_status"
Me.coldomiciliation_payment_status2.FieldName = "payment_status"
Me.coldomiciliation_payment_status2.Name = "coldomiciliation_payment_status2"
Me.coldomiciliation_payment_status2.Visible = true
Me.coldomiciliation_payment_status2.VisibleIndex = 12
'
'coldomiciliation_payment_isabel_date2
'
Me.coldomiciliation_payment_isabel_date2.Caption = "domiciliation_payment_isabel_date"
Me.coldomiciliation_payment_isabel_date2.FieldName = "domiciliation_payment_isabel_date"
Me.coldomiciliation_payment_isabel_date2.Name = "coldomiciliation_payment_isabel_date2"
Me.coldomiciliation_payment_isabel_date2.Visible = true
Me.coldomiciliation_payment_isabel_date2.VisibleIndex = 13
'
'coldomiciliation_unpaid_id2
'
Me.coldomiciliation_unpaid_id2.Caption = "domiciliation_unpaid_id"
Me.coldomiciliation_unpaid_id2.FieldName = "domiciliation_unpaid_id"
Me.coldomiciliation_unpaid_id2.Name = "coldomiciliation_unpaid_id2"
Me.coldomiciliation_unpaid_id2.Visible = true
Me.coldomiciliation_unpaid_id2.VisibleIndex = 14
'
'colbatch_immatriculation_number2
'
Me.colbatch_immatriculation_number2.Caption = "batch_immatriculation_number"
Me.colbatch_immatriculation_number2.FieldName = "batch_immatriculation_number"
Me.colbatch_immatriculation_number2.Name = "colbatch_immatriculation_number2"
Me.colbatch_immatriculation_number2.Visible = true
Me.colbatch_immatriculation_number2.VisibleIndex = 15
'
'collast_modified6
'
Me.collast_modified6.Caption = "last_modified"
Me.collast_modified6.FieldName = "last_modified"
Me.collast_modified6.Name = "collast_modified6"
Me.collast_modified6.Visible = true
Me.collast_modified6.VisibleIndex = 16
'
'colabo_stopped_with_dvdathome_id2
'
Me.colabo_stopped_with_dvdathome_id2.Caption = "abo_stopped_with_dvdathome_id"
Me.colabo_stopped_with_dvdathome_id2.FieldName = "abo_stopped_with_dvdathome_id"
Me.colabo_stopped_with_dvdathome_id2.Name = "colabo_stopped_with_dvdathome_id2"
Me.colabo_stopped_with_dvdathome_id2.Visible = true
Me.colabo_stopped_with_dvdathome_id2.VisibleIndex = 17
'
'cologone_payment_id2
'
Me.cologone_payment_id2.Caption = "ogone_payment_id"
Me.cologone_payment_id2.FieldName = "ogone_payment_id"
Me.cologone_payment_id2.Name = "cologone_payment_id2"
Me.cologone_payment_id2.Visible = true
Me.cologone_payment_id2.VisibleIndex = 0
'
'colabo_id5
'
Me.colabo_id5.Caption = "abo_id"
Me.colabo_id5.FieldName = "abo_id"
Me.colabo_id5.Name = "colabo_id5"
Me.colabo_id5.Visible = true
Me.colabo_id5.VisibleIndex = 1
'
'colcustomers_id9
'
Me.colcustomers_id9.Caption = "customers_id"
Me.colcustomers_id9.FieldName = "customers_id"
Me.colcustomers_id9.Name = "colcustomers_id9"
Me.colcustomers_id9.Visible = true
Me.colcustomers_id9.VisibleIndex = 2
'
'colamount7
'
Me.colamount7.Caption = "amount"
Me.colamount7.FieldName = "amount"
Me.colamount7.Name = "colamount7"
Me.colamount7.Visible = true
Me.colamount7.VisibleIndex = 3
'
'cologone_payment_status2
'
Me.cologone_payment_status2.Caption = "ogone_payment_status"
Me.cologone_payment_status2.FieldName = "ogone_payment_status"
Me.cologone_payment_status2.Name = "cologone_payment_status2"
Me.cologone_payment_status2.Visible = true
Me.cologone_payment_status2.VisibleIndex = 5
'
'cologone_batch_id2
'
Me.cologone_batch_id2.Caption = "ogone_batch_id"
Me.cologone_batch_id2.FieldName = "ogone_batch_id"
Me.cologone_batch_id2.Name = "cologone_batch_id2"
Me.cologone_batch_id2.Visible = true
Me.cologone_batch_id2.VisibleIndex = 6
'
'collast_modified7
'
Me.collast_modified7.Caption = "last_modified"
Me.collast_modified7.FieldName = "last_modified"
Me.collast_modified7.Name = "collast_modified7"
Me.collast_modified7.Visible = true
Me.collast_modified7.VisibleIndex = 7
'
'colcustserv_id2
'
Me.colcustserv_id2.Caption = "custserv_id"
Me.colcustserv_id2.FieldName = "custserv_id"
Me.colcustserv_id2.Name = "colcustserv_id2"
Me.colcustserv_id2.Visible = true
Me.colcustserv_id2.VisibleIndex = 0
'
'colcustomers_id10
'
Me.colcustomers_id10.Caption = "customers_id"
Me.colcustomers_id10.FieldName = "customers_id"
Me.colcustomers_id10.Name = "colcustomers_id10"
Me.colcustomers_id10.Visible = true
Me.colcustomers_id10.VisibleIndex = 1
'
'collanguage_id2
'
Me.collanguage_id2.Caption = "language_id"
Me.collanguage_id2.FieldName = "language_id"
Me.collanguage_id2.Name = "collanguage_id2"
Me.collanguage_id2.Visible = true
Me.collanguage_id2.VisibleIndex = 2
'
'colcustserv_cat_id2
'
Me.colcustserv_cat_id2.Caption = "custserv_cat_id"
Me.colcustserv_cat_id2.FieldName = "custserv_cat_id"
Me.colcustserv_cat_id2.Name = "colcustserv_cat_id2"
Me.colcustserv_cat_id2.Visible = true
Me.colcustserv_cat_id2.VisibleIndex = 3
'
'colcustomer_date2
'
Me.colcustomer_date2.Caption = "customer_date"
Me.colcustomer_date2.FieldName = "customer_date"
Me.colcustomer_date2.Name = "colcustomer_date2"
Me.colcustomer_date2.Visible = true
Me.colcustomer_date2.VisibleIndex = 4
'
'colorders_id2
'
Me.colorders_id2.Caption = "orders_id"
Me.colorders_id2.FieldName = "orders_id"
Me.colorders_id2.Name = "colorders_id2"
Me.colorders_id2.Visible = true
Me.colorders_id2.VisibleIndex = 5
'
'colproducts_id1
'
Me.colproducts_id1.Caption = "products_id"
Me.colproducts_id1.FieldName = "products_id"
Me.colproducts_id1.Name = "colproducts_id1"
Me.colproducts_id1.Visible = true
Me.colproducts_id1.VisibleIndex = 6
'
'coldvd_id2
'
Me.coldvd_id2.Caption = "dvd_id"
Me.coldvd_id2.FieldName = "dvd_id"
Me.coldvd_id2.Name = "coldvd_id2"
Me.coldvd_id2.Visible = true
Me.coldvd_id2.VisibleIndex = 7
'
'colsubject2
'
Me.colsubject2.Caption = "subject"
Me.colsubject2.FieldName = "subject"
Me.colsubject2.Name = "colsubject2"
Me.colsubject2.Visible = true
Me.colsubject2.VisibleIndex = 8
'
'colmessage2
'
Me.colmessage2.Caption = "message"
Me.colmessage2.FieldName = "message"
Me.colmessage2.Name = "colmessage2"
Me.colmessage2.Visible = true
Me.colmessage2.VisibleIndex = 9
'
'coladmindate2
'
Me.coladmindate2.Caption = "admindate"
Me.coladmindate2.FieldName = "admindate"
Me.coladmindate2.Name = "coladmindate2"
Me.coladmindate2.Visible = true
Me.coladmindate2.VisibleIndex = 10
'
'coladminby2
'
Me.coladminby2.Caption = "adminby"
Me.coladminby2.FieldName = "adminby"
Me.coladminby2.Name = "coladminby2"
Me.coladminby2.Visible = true
Me.coladminby2.VisibleIndex = 11
'
'coladminmessage2
'
Me.coladminmessage2.Caption = "adminmessage"
Me.coladminmessage2.FieldName = "adminmessage"
Me.coladminmessage2.Name = "coladminmessage2"
Me.coladminmessage2.Visible = true
Me.coladminmessage2.VisibleIndex = 12
'
'colmessagesent2
'
Me.colmessagesent2.Caption = "messagesent"
Me.colmessagesent2.FieldName = "messagesent"
Me.colmessagesent2.Name = "colmessagesent2"
Me.colmessagesent2.Visible = true
Me.colmessagesent2.VisibleIndex = 13
'
'coldvd_finally_arrived_mail2
'
Me.coldvd_finally_arrived_mail2.Caption = "dvd_finally_arrived_mail"
Me.coldvd_finally_arrived_mail2.FieldName = "dvd_finally_arrived_mail"
Me.coldvd_finally_arrived_mail2.Name = "coldvd_finally_arrived_mail2"
Me.coldvd_finally_arrived_mail2.Visible = true
Me.coldvd_finally_arrived_mail2.VisibleIndex = 14
'
'tabOrdersHistor
'
Me.tabOrdersHistor.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
Me.tabOrdersHistor.Appearance.Header.Options.UseFont = true
Me.tabOrdersHistor.Controls.Add(Me.SplitContainerOrders)
Me.tabOrdersHistor.Name = "tabOrdersHistor"
Me.tabOrdersHistor.Size = New System.Drawing.Size(1505, 905)
Me.tabOrdersHistor.Text = "Orders History"
'
'SplitContainerOrders
'
Me.SplitContainerOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.SplitContainerOrders.Dock = System.Windows.Forms.DockStyle.Fill
Me.SplitContainerOrders.Location = New System.Drawing.Point(0, 0)
Me.SplitContainerOrders.Name = "SplitContainerOrders"
Me.SplitContainerOrders.Panel1.Controls.Add(Me.GridOrders)
Me.SplitContainerOrders.Panel1.ShowCaption = true
Me.SplitContainerOrders.Panel1.Text = "Orders"
Me.SplitContainerOrders.Panel2.Controls.Add(Me.GridOrdersStatusHistory)
Me.SplitContainerOrders.Panel2.ShowCaption = true
Me.SplitContainerOrders.Panel2.Text = "Order Status History"
Me.SplitContainerOrders.Size = New System.Drawing.Size(1505, 905)
Me.SplitContainerOrders.SplitterPosition = 1119
Me.SplitContainerOrders.TabIndex = 3
Me.SplitContainerOrders.Text = "SplitContainerControl1"
'
'GridOrdersStatusHistory
'
Me.GridOrdersStatusHistory.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridOrdersStatusHistory.EmbeddedNavigator.Name = ""
Me.GridOrdersStatusHistory.FormsUseDefaultLookAndFeel = false
Me.GridOrdersStatusHistory.Location = New System.Drawing.Point(0, 0)
Me.GridOrdersStatusHistory.MainView = Me.GridViewOrdersHistory
Me.GridOrdersStatusHistory.Name = "GridOrdersStatusHistory"
Me.GridOrdersStatusHistory.Size = New System.Drawing.Size(376, 881)
Me.GridOrdersStatusHistory.TabIndex = 2
Me.GridOrdersStatusHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewOrdersHistory})
'
'GridViewOrdersHistory
'
Me.GridViewOrdersHistory.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand6})
Me.GridViewOrdersHistory.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.coldate_added_Orders_history, Me.new_status, Me.old_status})
Me.GridViewOrdersHistory.CustomizationFormBounds = New System.Drawing.Rectangle(989, 251, 217, 291)
Me.GridViewOrdersHistory.GridControl = Me.GridOrdersStatusHistory
Me.GridViewOrdersHistory.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewOrdersHistory.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "orders_status", Nothing, "")})
Me.GridViewOrdersHistory.Name = "GridViewOrdersHistory"
Me.GridViewOrdersHistory.OptionsBehavior.Editable = false
Me.GridViewOrdersHistory.OptionsView.ShowBands = false
Me.GridViewOrdersHistory.OptionsView.ShowFooter = true
'
'GridBand6
'
Me.GridBand6.Caption = "GridBand4"
Me.GridBand6.Columns.Add(Me.coldate_added_Orders_history)
Me.GridBand6.Columns.Add(Me.new_status)
Me.GridBand6.Columns.Add(Me.old_status)
Me.GridBand6.MinWidth = 20
Me.GridBand6.Name = "GridBand6"
Me.GridBand6.Width = 353
'
'coldate_added_Orders_history
'
Me.coldate_added_Orders_history.Caption = "date_added"
Me.coldate_added_Orders_history.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.coldate_added_Orders_history.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.coldate_added_Orders_history.FieldName = "date_added"
Me.coldate_added_Orders_history.Name = "coldate_added_Orders_history"
Me.coldate_added_Orders_history.OptionsColumn.AllowEdit = false
Me.coldate_added_Orders_history.OptionsColumn.ReadOnly = true
Me.coldate_added_Orders_history.Visible = true
Me.coldate_added_Orders_history.Width = 120
'
'new_status
'
Me.new_status.Caption = "new_status"
Me.new_status.FieldName = "new_status"
Me.new_status.Name = "new_status"
Me.new_status.Visible = true
Me.new_status.Width = 114
'
'old_status
'
Me.old_status.Caption = "old_status"
Me.old_status.FieldName = "old_status"
Me.old_status.Name = "old_status"
Me.old_status.Visible = true
Me.old_status.Width = 119
'
'GridControl1
'
Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridControl1.EmbeddedNavigator.Name = ""
Me.GridControl1.FormsUseDefaultLookAndFeel = false
Me.GridControl1.Location = New System.Drawing.Point(0, 203)
Me.GridControl1.MainView = Me.GridViewSearch
Me.GridControl1.Name = "GridControl1"
Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {GridchkAbo, GridchkBlackList, Me.RepositoryICustomersCustomers_id})
Me.GridControl1.Size = New System.Drawing.Size(1505, 702)
Me.GridControl1.TabIndex = 1
Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSearch})
'
'GridViewSearch
'
Me.GridViewSearch.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1})
Me.GridViewSearch.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colcustomers_firstname, Me.colcustomers_lastname, Me.colcustomers_email_address, Me.colcustomers_abo, Me.colblack_listed, Me.custserv_customer_date, Me.colentry_postcode, Me.coldomiciliation_number, Me.col2customers_id, Me.colcustomers_language, Me.call_phone, Me.colentry_street_address})
Me.GridViewSearch.GridControl = Me.GridControl1
Me.GridViewSearch.Name = "GridViewSearch"
Me.GridViewSearch.OptionsView.ShowAutoFilterRow = true
Me.GridViewSearch.OptionsView.ShowBands = false
Me.GridViewSearch.OptionsView.ShowFooter = true
'
'GridBand1
'
Me.GridBand1.Caption = "GridBand1"
Me.GridBand1.Columns.Add(Me.col2customers_id)
Me.GridBand1.Columns.Add(Me.colcustomers_firstname)
Me.GridBand1.Columns.Add(Me.colcustomers_lastname)
Me.GridBand1.Columns.Add(Me.colcustomers_email_address)
Me.GridBand1.Columns.Add(Me.colcustomers_abo)
Me.GridBand1.Columns.Add(Me.colblack_listed)
Me.GridBand1.Columns.Add(Me.colentry_postcode)
Me.GridBand1.Columns.Add(Me.colentry_street_address)
Me.GridBand1.Columns.Add(Me.coldomiciliation_number)
Me.GridBand1.Columns.Add(Me.colcustomers_language)
Me.GridBand1.Columns.Add(Me.call_phone)
Me.GridBand1.Columns.Add(Me.custserv_customer_date)
Me.GridBand1.MinWidth = 20
Me.GridBand1.Name = "GridBand1"
Me.GridBand1.Width = 1322
'
'col2customers_id
'
Me.col2customers_id.Caption = "customers_id"
Me.col2customers_id.ColumnEdit = Me.RepositoryICustomersCustomers_id
Me.col2customers_id.FieldName = "customers_id"
Me.col2customers_id.Name = "col2customers_id"
Me.col2customers_id.Visible = true
Me.col2customers_id.Width = 90
'
'RepositoryICustomersCustomers_id
'
Me.RepositoryICustomersCustomers_id.AutoHeight = false
Me.RepositoryICustomersCustomers_id.Name = "RepositoryICustomersCustomers_id"
'
'colcustomers_firstname
'
Me.colcustomers_firstname.Caption = "firstname"
Me.colcustomers_firstname.FieldName = "customers_firstname"
Me.colcustomers_firstname.Name = "colcustomers_firstname"
Me.colcustomers_firstname.OptionsColumn.AllowEdit = false
Me.colcustomers_firstname.Visible = true
Me.colcustomers_firstname.Width = 120
'
'colcustomers_lastname
'
Me.colcustomers_lastname.Caption = "lastname"
Me.colcustomers_lastname.FieldName = "customers_lastname"
Me.colcustomers_lastname.Name = "colcustomers_lastname"
Me.colcustomers_lastname.OptionsColumn.AllowEdit = false
Me.colcustomers_lastname.Visible = true
Me.colcustomers_lastname.Width = 118
'
'colcustomers_email_address
'
Me.colcustomers_email_address.Caption = "email"
Me.colcustomers_email_address.FieldName = "customers_email_address"
Me.colcustomers_email_address.Name = "colcustomers_email_address"
Me.colcustomers_email_address.OptionsColumn.AllowEdit = false
Me.colcustomers_email_address.Visible = true
Me.colcustomers_email_address.Width = 143
'
'colcustomers_abo
'
Me.colcustomers_abo.Caption = "abo"
Me.colcustomers_abo.ColumnEdit = GridchkAbo
Me.colcustomers_abo.FieldName = "customers_abo"
Me.colcustomers_abo.Name = "colcustomers_abo"
Me.colcustomers_abo.OptionsColumn.AllowEdit = false
Me.colcustomers_abo.Visible = true
Me.colcustomers_abo.Width = 90
'
'colblack_listed
'
Me.colblack_listed.Caption = "black_listed"
Me.colblack_listed.ColumnEdit = GridchkBlackList
Me.colblack_listed.FieldName = "black_listed"
Me.colblack_listed.Name = "colblack_listed"
Me.colblack_listed.OptionsColumn.AllowEdit = false
Me.colblack_listed.Visible = true
Me.colblack_listed.Width = 72
'
'colentry_postcode
'
Me.colentry_postcode.Caption = "postcode"
Me.colentry_postcode.FieldName = "entry_postcode"
Me.colentry_postcode.Name = "colentry_postcode"
Me.colentry_postcode.OptionsColumn.AllowEdit = false
Me.colentry_postcode.Visible = true
Me.colentry_postcode.Width = 96
'
'colentry_street_address
'
Me.colentry_street_address.Caption = "address"
Me.colentry_street_address.FieldName = "entry_street_address"
Me.colentry_street_address.Name = "colentry_street_address"
Me.colentry_street_address.OptionsColumn.AllowEdit = false
Me.colentry_street_address.OptionsColumn.ReadOnly = true
Me.colentry_street_address.Visible = true
Me.colentry_street_address.Width = 191
'
'coldomiciliation_number
'
Me.coldomiciliation_number.Caption = "domiciliation"
Me.coldomiciliation_number.FieldName = "domiciliation_number"
Me.coldomiciliation_number.Name = "coldomiciliation_number"
Me.coldomiciliation_number.OptionsColumn.AllowEdit = false
Me.coldomiciliation_number.Visible = true
Me.coldomiciliation_number.Width = 121
'
'colcustomers_language
'
Me.colcustomers_language.Caption = "language"
Me.colcustomers_language.FieldName = "customers_language"
Me.colcustomers_language.Name = "colcustomers_language"
Me.colcustomers_language.OptionsColumn.AllowEdit = false
Me.colcustomers_language.Visible = true
Me.colcustomers_language.Width = 52
'
'call_phone
'
Me.call_phone.Caption = "phone"
Me.call_phone.FieldName = "call_phone"
Me.call_phone.Name = "call_phone"
Me.call_phone.OptionsColumn.AllowEdit = false
Me.call_phone.Visible = true
Me.call_phone.Width = 105
'
'custserv_customer_date
'
Me.custserv_customer_date.Caption = "CustServ_date"
Me.custserv_customer_date.FieldName = "customer_date"
Me.custserv_customer_date.Name = "custserv_customer_date"
Me.custserv_customer_date.OptionsColumn.AllowEdit = false
Me.custserv_customer_date.Visible = true
Me.custserv_customer_date.Width = 124
'
'tabAboHistory
'
Me.tabAboHistory.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
Me.tabAboHistory.Appearance.Header.Options.UseFont = true
Me.tabAboHistory.Controls.Add(Me.GridABO)
Me.tabAboHistory.Name = "tabAboHistory"
Me.tabAboHistory.Size = New System.Drawing.Size(1505, 905)
Me.tabAboHistory.Text = "ABO History"
'
'tabWishList
'
Me.tabWishList.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
Me.tabWishList.Appearance.Header.Options.UseFont = true
Me.tabWishList.Controls.Add(Me.GCWishlistAssigned)
Me.tabWishList.Controls.Add(Me.SplitterControl1)
Me.tabWishList.Controls.Add(Me.PanelControl11)
Me.tabWishList.Name = "tabWishList"
Me.tabWishList.Size = New System.Drawing.Size(1505, 905)
Me.tabWishList.Text = "WishList"
'
'GCWishlistAssigned
'
Me.GCWishlistAssigned.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCWishlistAssigned.Controls.Add(Me.GridWishListAssigned)
Me.GCWishlistAssigned.Dock = System.Windows.Forms.DockStyle.Fill
Me.GCWishlistAssigned.Location = New System.Drawing.Point(737, 0)
Me.GCWishlistAssigned.Name = "GCWishlistAssigned"
Me.GCWishlistAssigned.Size = New System.Drawing.Size(768, 905)
Me.GCWishlistAssigned.TabIndex = 3
Me.GCWishlistAssigned.Text = "DVD Already Assigned"
'
'SplitterControl1
'
Me.SplitterControl1.Location = New System.Drawing.Point(731, 0)
Me.SplitterControl1.Name = "SplitterControl1"
Me.SplitterControl1.Size = New System.Drawing.Size(6, 905)
Me.SplitterControl1.TabIndex = 1
Me.SplitterControl1.TabStop = false
'
'PanelControl11
'
Me.PanelControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl11.Controls.Add(Me.GridWishList)
Me.PanelControl11.Controls.Add(Me.PanelDetailWishlist)
Me.PanelControl11.Dock = System.Windows.Forms.DockStyle.Left
Me.PanelControl11.Location = New System.Drawing.Point(0, 0)
Me.PanelControl11.Name = "PanelControl11"
Me.PanelControl11.Size = New System.Drawing.Size(731, 905)
Me.PanelControl11.TabIndex = 4
'
'PanelDetailWishlist
'
Me.PanelDetailWishlist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelDetailWishlist.Controls.Add(Me.splitNormAdult)
Me.PanelDetailWishlist.Controls.Add(Me.gridInfoAdult)
Me.PanelDetailWishlist.Controls.Add(Me.gridInfoNorm)
Me.PanelDetailWishlist.Dock = System.Windows.Forms.DockStyle.Top
Me.PanelDetailWishlist.Location = New System.Drawing.Point(2, 2)
Me.PanelDetailWishlist.Name = "PanelDetailWishlist"
Me.PanelDetailWishlist.Size = New System.Drawing.Size(727, 151)
Me.PanelDetailWishlist.TabIndex = 1
'
'splitNormAdult
'
Me.splitNormAdult.Location = New System.Drawing.Point(367, 2)
Me.splitNormAdult.Name = "splitNormAdult"
Me.splitNormAdult.Size = New System.Drawing.Size(6, 147)
Me.splitNormAdult.TabIndex = 2
Me.splitNormAdult.TabStop = false
'
'gridInfoAdult
'
Me.gridInfoAdult.Dock = System.Windows.Forms.DockStyle.Fill
Me.gridInfoAdult.EmbeddedNavigator.Name = ""
Me.gridInfoAdult.FormsUseDefaultLookAndFeel = false
Me.gridInfoAdult.Location = New System.Drawing.Point(367, 2)
Me.gridInfoAdult.MainView = Me.GridViewInfoAdult
Me.gridInfoAdult.Name = "gridInfoAdult"
Me.gridInfoAdult.Size = New System.Drawing.Size(358, 147)
Me.gridInfoAdult.TabIndex = 1
Me.gridInfoAdult.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewInfoAdult})
'
'GridViewInfoAdult
'
Me.GridViewInfoAdult.GridControl = Me.gridInfoAdult
Me.GridViewInfoAdult.Name = "GridViewInfoAdult"
Me.GridViewInfoAdult.OptionsView.ShowFooter = true
Me.GridViewInfoAdult.OptionsView.ShowGroupPanel = false
'
'gridInfoNorm
'
Me.gridInfoNorm.Dock = System.Windows.Forms.DockStyle.Left
Me.gridInfoNorm.EmbeddedNavigator.Name = ""
Me.gridInfoNorm.FormsUseDefaultLookAndFeel = false
Me.gridInfoNorm.Location = New System.Drawing.Point(2, 2)
Me.gridInfoNorm.MainView = Me.GridViewInfoNorm
Me.gridInfoNorm.Name = "gridInfoNorm"
Me.gridInfoNorm.Size = New System.Drawing.Size(365, 147)
Me.gridInfoNorm.TabIndex = 0
Me.gridInfoNorm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewInfoNorm})
'
'GridViewInfoNorm
'
Me.GridViewInfoNorm.GridControl = Me.gridInfoNorm
Me.GridViewInfoNorm.Name = "GridViewInfoNorm"
Me.GridViewInfoNorm.OptionsView.ShowFooter = true
Me.GridViewInfoNorm.OptionsView.ShowGroupPanel = false
'
'tabMain
'
Me.tabMain.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.tabMain.Appearance.Header.Options.UseFont = true
Me.tabMain.AutoScroll = true
Me.tabMain.Controls.Add(Me.chksleep)
Me.tabMain.Controls.Add(Me.btnCreditHistoryReplay)
Me.tabMain.Controls.Add(Me.ChkCreditCombined)
Me.tabMain.Controls.Add(Me.chkFt)
Me.tabMain.Controls.Add(Me.lblCpt_reconduction)
Me.tabMain.Controls.Add(Me.lblNbReconduction)
Me.tabMain.Controls.Add(Me.lblNextPrice)
Me.tabMain.Controls.Add(Me.lblNextCredit)
Me.tabMain.Controls.Add(Me.txtNextPrice)
Me.tabMain.Controls.Add(Me.txtNextCredit)
Me.tabMain.Controls.Add(Me.btnForcedReconduction)
Me.tabMain.Controls.Add(Me.btnActivateDomiciliation)
Me.tabMain.Controls.Add(Me.btnReceivedDomiciliation)
Me.tabMain.Controls.Add(Me.GCACtPhone)
Me.tabMain.Controls.Add(Me.btnDelPhoAct)
Me.tabMain.Controls.Add(Me.btnActPhone)
Me.tabMain.Controls.Add(Me.btnReActivate)
Me.tabMain.Controls.Add(Me.GCAboInfo)
Me.tabMain.Controls.Add(Me.GCadresse)
Me.tabMain.Controls.Add(Me.GCcustomersInfo)
Me.tabMain.Controls.Add(Me.btnStopNow)
Me.tabMain.Controls.Add(Me.btnStopAtReconduction)
Me.tabMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.tabMain.Name = "tabMain"
Me.tabMain.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[True]
Me.tabMain.Size = New System.Drawing.Size(1253, 779)
Me.tabMain.Text = "General Info"
'
'chksleep
'
Me.chksleep.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.sleep", true))
Me.chksleep.Location = New System.Drawing.Point(224, 21)
Me.chksleep.Name = "chksleep"
Me.chksleep.Properties.Caption = "Sleep"
Me.chksleep.Size = New System.Drawing.Size(92, 21)
Me.chksleep.TabIndex = 32
'
'btnCreditHistoryReplay
'
Me.btnCreditHistoryReplay.Location = New System.Drawing.Point(563, 0)
Me.btnCreditHistoryReplay.Name = "btnCreditHistoryReplay"
Me.btnCreditHistoryReplay.Size = New System.Drawing.Size(129, 23)
Me.btnCreditHistoryReplay.TabIndex = 31
Me.btnCreditHistoryReplay.Text = "replay credit history"
Me.btnCreditHistoryReplay.Visible = false
'
'ChkCreditCombined
'
Me.ChkCreditCombined.Location = New System.Drawing.Point(491, 20)
Me.ChkCreditCombined.Name = "ChkCreditCombined"
Me.ChkCreditCombined.Properties.Caption = "Credit Combined"
Me.ChkCreditCombined.Properties.ReadOnly = true
Me.ChkCreditCombined.Size = New System.Drawing.Size(132, 21)
Me.ChkCreditCombined.TabIndex = 30
Me.ToolTip1.SetToolTip(Me.ChkCreditCombined, "accumulation de credit lors de la reconduction suivante")
'
'chkFt
'
Me.chkFt.Location = New System.Drawing.Point(353, 20)
Me.chkFt.Name = "chkFt"
Me.chkFt.Properties.Caption = "Free Trial"
Me.chkFt.Properties.ReadOnly = true
Me.chkFt.Size = New System.Drawing.Size(91, 21)
Me.chkFt.TabIndex = 29
'
'lblCpt_reconduction
'
Me.lblCpt_reconduction.Location = New System.Drawing.Point(161, 23)
Me.lblCpt_reconduction.Name = "lblCpt_reconduction"
Me.lblCpt_reconduction.Size = New System.Drawing.Size(7, 16)
Me.lblCpt_reconduction.TabIndex = 28
Me.lblCpt_reconduction.Text = "0"
'
'lblNbReconduction
'
Me.lblNbReconduction.Location = New System.Drawing.Point(19, 23)
Me.lblNbReconduction.Name = "lblNbReconduction"
Me.lblNbReconduction.Size = New System.Drawing.Size(131, 16)
Me.lblNbReconduction.TabIndex = 27
Me.lblNbReconduction.Text = "Nombre reconduction :"
'
'lblNextPrice
'
Me.lblNextPrice.Location = New System.Drawing.Point(952, 20)
Me.lblNextPrice.Name = "lblNextPrice"
Me.lblNextPrice.Size = New System.Drawing.Size(57, 16)
Me.lblNextPrice.TabIndex = 24
Me.lblNextPrice.Text = "Next Price"
'
'lblNextCredit
'
Me.lblNextCredit.Location = New System.Drawing.Point(758, 20)
Me.lblNextCredit.Name = "lblNextCredit"
Me.lblNextCredit.Size = New System.Drawing.Size(63, 16)
Me.lblNextCredit.TabIndex = 22
Me.lblNextCredit.Text = "Next Credit"
'
'btnForcedReconduction
'
Me.btnForcedReconduction.Location = New System.Drawing.Point(1188, 46)
Me.btnForcedReconduction.Name = "btnForcedReconduction"
Me.btnForcedReconduction.Size = New System.Drawing.Size(173, 27)
Me.btnForcedReconduction.TabIndex = 13
Me.btnForcedReconduction.Text = "Reconduction"
'
'btnActivateDomiciliation
'
Me.btnActivateDomiciliation.Location = New System.Drawing.Point(1188, 283)
Me.btnActivateDomiciliation.Name = "btnActivateDomiciliation"
Me.btnActivateDomiciliation.Size = New System.Drawing.Size(173, 26)
Me.btnActivateDomiciliation.TabIndex = 12
Me.btnActivateDomiciliation.Text = "&Activate by Domiciliation"
Me.btnActivateDomiciliation.Visible = false
'
'btnReceivedDomiciliation
'
Me.btnReceivedDomiciliation.Location = New System.Drawing.Point(1187, 338)
Me.btnReceivedDomiciliation.Name = "btnReceivedDomiciliation"
Me.btnReceivedDomiciliation.Size = New System.Drawing.Size(173, 27)
Me.btnReceivedDomiciliation.TabIndex = 11
Me.btnReceivedDomiciliation.Text = "&Received domiciliation"
Me.ToolTip1.SetToolTip(Me.btnReceivedDomiciliation, "received dom 70")
Me.btnReceivedDomiciliation.Visible = false
'
'GCACtPhone
'
Me.GCACtPhone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCACtPhone.Controls.Add(Me.MemoOtherReason)
Me.GCACtPhone.Controls.Add(Me.Label2)
Me.GCACtPhone.Controls.Add(Me.cmbPhoneActivDelete)
Me.GCACtPhone.Controls.Add(Me.LabelReason)
Me.GCACtPhone.Controls.Add(Me.DateCallPhoneActivation)
Me.GCACtPhone.Controls.Add(Me.LabelCallMeDate)
Me.GCACtPhone.Location = New System.Drawing.Point(758, 511)
Me.GCACtPhone.Name = "GCACtPhone"
Me.GCACtPhone.Size = New System.Drawing.Size(394, 274)
Me.GCACtPhone.TabIndex = 10
Me.GCACtPhone.Text = "Phone activation Info"
'
'MemoOtherReason
'
Me.MemoOtherReason.Enabled = false
Me.MemoOtherReason.Location = New System.Drawing.Point(30, 151)
Me.MemoOtherReason.Name = "MemoOtherReason"
Me.MemoOtherReason.Size = New System.Drawing.Size(278, 91)
Me.MemoOtherReason.StyleController = Me.LayoutCustServ
Me.MemoOtherReason.TabIndex = 43
'
'Label2
'
Me.Label2.AutoSize = true
Me.Label2.Location = New System.Drawing.Point(26, 134)
Me.Label2.Name = "Label2"
Me.Label2.Size = New System.Drawing.Size(67, 17)
Me.Label2.TabIndex = 42
Me.Label2.Text = "Comment"
'
'cmbPhoneActivDelete
'
Me.cmbPhoneActivDelete.Enabled = false
Me.cmbPhoneActivDelete.Location = New System.Drawing.Point(163, 81)
Me.cmbPhoneActivDelete.Name = "cmbPhoneActivDelete"
Me.cmbPhoneActivDelete.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbPhoneActivDelete.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("reason", "reason", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("stop_phone_id", "stop_phone_id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
Me.cmbPhoneActivDelete.Properties.DisplayMember = "reason"
Me.cmbPhoneActivDelete.Properties.NullText = ""
Me.cmbPhoneActivDelete.Properties.ValueMember = "stop_phone_id"
Me.cmbPhoneActivDelete.Size = New System.Drawing.Size(145, 22)
Me.cmbPhoneActivDelete.TabIndex = 40
Me.cmbPhoneActivDelete.Visible = false
'
'LabelReason
'
Me.LabelReason.AutoSize = true
Me.LabelReason.Location = New System.Drawing.Point(26, 84)
Me.LabelReason.Name = "LabelReason"
Me.LabelReason.Size = New System.Drawing.Size(132, 17)
Me.LabelReason.TabIndex = 23
Me.LabelReason.Text = "Reason from delete"
Me.LabelReason.Visible = false
'
'DateCallPhoneActivation
'
Me.DateCallPhoneActivation.CausesValidation = false
Me.DateCallPhoneActivation.EditValue = Nothing
Me.DateCallPhoneActivation.Enabled = false
Me.DateCallPhoneActivation.Location = New System.Drawing.Point(163, 48)
Me.DateCallPhoneActivation.Name = "DateCallPhoneActivation"
Me.DateCallPhoneActivation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.DateCallPhoneActivation.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.DateCallPhoneActivation.Size = New System.Drawing.Size(145, 22)
Me.DateCallPhoneActivation.TabIndex = 18
'
'LabelCallMeDate
'
Me.LabelCallMeDate.Location = New System.Drawing.Point(30, 52)
Me.LabelCallMeDate.Name = "LabelCallMeDate"
Me.LabelCallMeDate.Size = New System.Drawing.Size(70, 16)
Me.LabelCallMeDate.TabIndex = 13
Me.LabelCallMeDate.Text = "call me date"
'
'btnDelPhoAct
'
Me.btnDelPhoAct.Location = New System.Drawing.Point(1188, 465)
Me.btnDelPhoAct.Name = "btnDelPhoAct"
Me.btnDelPhoAct.Size = New System.Drawing.Size(173, 27)
Me.btnDelPhoAct.TabIndex = 20
Me.btnDelPhoAct.Text = "Delete Phone activation"
'
'btnActPhone
'
Me.btnActPhone.Location = New System.Drawing.Point(1188, 227)
Me.btnActPhone.Name = "btnActPhone"
Me.btnActPhone.Size = New System.Drawing.Size(173, 27)
Me.btnActPhone.TabIndex = 9
Me.btnActPhone.Text = "&Activate by phone"
'
'btnReActivate
'
Me.btnReActivate.Location = New System.Drawing.Point(1188, 97)
Me.btnReActivate.Name = "btnReActivate"
Me.btnReActivate.Size = New System.Drawing.Size(173, 26)
Me.btnReActivate.TabIndex = 6
Me.btnReActivate.Text = "Re-Activate"
'
'GCAboInfo
'
Me.GCAboInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCAboInfo.Controls.Add(Me.cmbDiscountActivation)
Me.GCAboInfo.Controls.Add(Me.cmbDiscType)
Me.GCAboInfo.Controls.Add(Me.lblDateEndHoliday)
Me.GCAboInfo.Controls.Add(Me.DateEndOfHoliday)
Me.GCAboInfo.Controls.Add(Me.cmbSuspended)
Me.GCAboInfo.Controls.Add(Me.lblAboSumP)
Me.GCAboInfo.Controls.Add(Me.lblSuspended)
Me.GCAboInfo.Controls.Add(Me.btnGoto30)
Me.GCAboInfo.Controls.Add(Me.txtRegistrationStep)
Me.GCAboInfo.Controls.Add(Me.lblRegistrationStep)
Me.GCAboInfo.Controls.Add(Me.txtDVDAdultAtHome)
Me.GCAboInfo.Controls.Add(Me.lblDiscountrecurring)
Me.GCAboInfo.Controls.Add(Me.txtDiscRecurring)
Me.GCAboInfo.Controls.Add(Me.chkAutoStop)
Me.GCAboInfo.Controls.Add(Me.cmbNextDiscCode)
Me.GCAboInfo.Controls.Add(Me.lblNextDiscount)
Me.GCAboInfo.Controls.Add(Me.lblActivation)
Me.GCAboInfo.Controls.Add(Me.chkMultiShipment)
Me.GCAboInfo.Controls.Add(Me.cmbNextABO)
Me.GCAboInfo.Controls.Add(Me.txtDVDNormAtHome)
Me.GCAboInfo.Controls.Add(Me.txtDVDAdult)
Me.GCAboInfo.Controls.Add(Me.txtDVDNorm)
Me.GCAboInfo.Controls.Add(Me.lblAdult)
Me.GCAboInfo.Controls.Add(Me.lblNorm)
Me.GCAboInfo.Controls.Add(Me.lblHome)
Me.GCAboInfo.Controls.Add(Me.lblAsked)
Me.GCAboInfo.Controls.Add(Me.txtABOCredit)
Me.GCAboInfo.Controls.Add(Me.lblCredits)
Me.GCAboInfo.Controls.Add(Me.lblValidity)
Me.GCAboInfo.Controls.Add(Me.txtAbo_ValidityTo)
Me.GCAboInfo.Controls.Add(Me.cmbABO)
Me.GCAboInfo.Controls.Add(Me.lblNextAbo)
Me.GCAboInfo.Controls.Add(Me.lblAbo)
Me.GCAboInfo.Location = New System.Drawing.Point(758, 46)
Me.GCAboInfo.Name = "GCAboInfo"
Me.GCAboInfo.Size = New System.Drawing.Size(404, 448)
Me.GCAboInfo.TabIndex = 5
Me.GCAboInfo.Text = "ABO Info"
'
'cmbDiscountActivation
'
Me.cmbDiscountActivation.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.activation_discount_code_id", true))
Me.cmbDiscountActivation.Enabled = false
Me.cmbDiscountActivation.Location = New System.Drawing.Point(192, 306)
Me.cmbDiscountActivation.Name = "cmbDiscountActivation"
Me.cmbDiscountActivation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
Me.cmbDiscountActivation.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code_id", "discount_code_id", 102, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code", "discount_code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbDiscountActivation.Properties.DataSource = Me.objDS.discount_code
Me.cmbDiscountActivation.Properties.DisplayMember = "code"
Me.cmbDiscountActivation.Properties.NullText = ""
Me.cmbDiscountActivation.Properties.ValueMember = "code_id"
Me.cmbDiscountActivation.Size = New System.Drawing.Size(104, 22)
Me.cmbDiscountActivation.TabIndex = 60
'
'cmbDiscType
'
Me.cmbDiscType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.activation_discount_code_type", true))
Me.cmbDiscType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "customers.activation_discount_code_type", true))
Me.cmbDiscType.Enabled = false
Me.cmbDiscType.Location = New System.Drawing.Point(298, 306)
Me.cmbDiscType.Name = "cmbDiscType"
Me.cmbDiscType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbDiscType.Properties.Items.AddRange(New Object() {"A", "D"})
Me.cmbDiscType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
Me.cmbDiscType.Size = New System.Drawing.Size(96, 22)
Me.cmbDiscType.TabIndex = 59
'
'lblDateEndHoliday
'
Me.lblDateEndHoliday.Location = New System.Drawing.Point(10, 172)
Me.lblDateEndHoliday.Name = "lblDateEndHoliday"
Me.lblDateEndHoliday.Size = New System.Drawing.Size(132, 16)
Me.lblDateEndHoliday.TabIndex = 51
Me.lblDateEndHoliday.Text = "closing date of vacancy"
'
'DateEndOfHoliday
'
Me.DateEndOfHoliday.EditValue = Nothing
Me.DateEndOfHoliday.Enabled = false
Me.DateEndOfHoliday.Location = New System.Drawing.Point(192, 168)
Me.DateEndOfHoliday.Name = "DateEndOfHoliday"
Me.DateEndOfHoliday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.DateEndOfHoliday.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.DateEndOfHoliday.Size = New System.Drawing.Size(182, 22)
Me.DateEndOfHoliday.TabIndex = 50
'
'cmbSuspended
'
Me.cmbSuspended.Enabled = false
Me.cmbSuspended.Location = New System.Drawing.Point(192, 142)
Me.cmbSuspended.Name = "cmbSuspended"
Me.cmbSuspended.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbSuspended.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 75, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbSuspended.Properties.DisplayMember = "DisplayMember"
Me.cmbSuspended.Properties.NullText = ""
Me.cmbSuspended.Properties.ValueMember = "Value"
Me.cmbSuspended.Size = New System.Drawing.Size(182, 22)
Me.cmbSuspended.TabIndex = 48
'
'lblAboSumP
'
Me.lblAboSumP.AutoSize = true
Me.lblAboSumP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
Me.lblAboSumP.ForeColor = System.Drawing.Color.WhiteSmoke
Me.lblAboSumP.Location = New System.Drawing.Point(6, 33)
Me.lblAboSumP.Name = "lblAboSumP"
Me.lblAboSumP.Size = New System.Drawing.Size(185, 17)
Me.lblAboSumP.TabIndex = 47
Me.lblAboSumP.Text = "ABO 12 mois SummerPower"
'
'lblSuspended
'
Me.lblSuspended.Location = New System.Drawing.Point(10, 147)
Me.lblSuspended.Name = "lblSuspended"
Me.lblSuspended.Size = New System.Drawing.Size(63, 16)
Me.lblSuspended.TabIndex = 45
Me.lblSuspended.Text = "Suspended"
'
'btnGoto30
'
Me.btnGoto30.Enabled = false
Me.btnGoto30.Location = New System.Drawing.Point(298, 389)
Me.btnGoto30.Name = "btnGoto30"
Me.btnGoto30.Size = New System.Drawing.Size(76, 26)
Me.btnGoto30.TabIndex = 44
Me.btnGoto30.Text = "Goto 30"
Me.btnGoto30.Visible = false
'
'txtRegistrationStep
'
Me.txtRegistrationStep.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_registration_step", true))
Me.txtRegistrationStep.Enabled = false
Me.txtRegistrationStep.Location = New System.Drawing.Point(192, 389)
Me.txtRegistrationStep.Name = "txtRegistrationStep"
Me.txtRegistrationStep.Size = New System.Drawing.Size(96, 22)
Me.txtRegistrationStep.TabIndex = 43
'
'lblRegistrationStep
'
Me.lblRegistrationStep.Location = New System.Drawing.Point(10, 398)
Me.lblRegistrationStep.Name = "lblRegistrationStep"
Me.lblRegistrationStep.Size = New System.Drawing.Size(98, 16)
Me.lblRegistrationStep.TabIndex = 42
Me.lblRegistrationStep.Text = "Registration Step"
'
'txtDVDAdultAtHome
'
Me.txtDVDAdultAtHome.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_adult", true))
Me.txtDVDAdultAtHome.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.txtDVDAdultAtHome.Enabled = false
Me.txtDVDAdultAtHome.Location = New System.Drawing.Point(307, 278)
Me.txtDVDAdultAtHome.Name = "txtDVDAdultAtHome"
Me.txtDVDAdultAtHome.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtDVDAdultAtHome.Size = New System.Drawing.Size(85, 22)
Me.txtDVDAdultAtHome.TabIndex = 41
'
'lblDiscountrecurring
'
Me.lblDiscountrecurring.Location = New System.Drawing.Point(10, 343)
Me.lblDiscountrecurring.Name = "lblDiscountrecurring"
Me.lblDiscountrecurring.Size = New System.Drawing.Size(107, 16)
Me.lblDiscountrecurring.TabIndex = 40
Me.lblDiscountrecurring.Text = "Discount Recurring"
'
'txtDiscRecurring
'
Me.txtDiscRecurring.AllowDrop = true
Me.txtDiscRecurring.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_discount_recurring_to_date", true))
Me.txtDiscRecurring.EditValue = Nothing
Me.txtDiscRecurring.Enabled = false
Me.txtDiscRecurring.Location = New System.Drawing.Point(192, 333)
Me.txtDiscRecurring.Name = "txtDiscRecurring"
Me.txtDiscRecurring.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
Me.txtDiscRecurring.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.txtDiscRecurring.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtDiscRecurring.Size = New System.Drawing.Size(182, 22)
Me.txtDiscRecurring.TabIndex = 39
'
'chkAutoStop
'
Me.chkAutoStop.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_auto_stop_next_reconduction", true))
Me.chkAutoStop.Enabled = false
Me.chkAutoStop.Location = New System.Drawing.Point(144, 426)
Me.chkAutoStop.Name = "chkAutoStop"
Me.chkAutoStop.Properties.Caption = "Auto-Stop"
Me.chkAutoStop.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
Me.chkAutoStop.Size = New System.Drawing.Size(115, 21)
Me.chkAutoStop.TabIndex = 38
'
'cmbNextDiscCode
'
Me.cmbNextDiscCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_discount_code", true))
Me.cmbNextDiscCode.Enabled = false
Me.cmbNextDiscCode.Location = New System.Drawing.Point(192, 361)
Me.cmbNextDiscCode.Name = "cmbNextDiscCode"
Me.cmbNextDiscCode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
Me.cmbNextDiscCode.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code_id", "discount_code_id", 102, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code", "discount_code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbNextDiscCode.Properties.DataSource = Me.objDS.discount_code
Me.cmbNextDiscCode.Properties.DisplayMember = "code"
Me.cmbNextDiscCode.Properties.NullText = ""
Me.cmbNextDiscCode.Properties.ValueMember = "code_id"
Me.cmbNextDiscCode.Size = New System.Drawing.Size(182, 22)
Me.cmbNextDiscCode.TabIndex = 36
'
'lblNextDiscount
'
Me.lblNextDiscount.Location = New System.Drawing.Point(10, 370)
Me.lblNextDiscount.Name = "lblNextDiscount"
Me.lblNextDiscount.Size = New System.Drawing.Size(89, 16)
Me.lblNextDiscount.TabIndex = 33
Me.lblNextDiscount.Text = "Next Disc. Code"
'
'lblActivation
'
Me.lblActivation.Location = New System.Drawing.Point(10, 315)
Me.lblActivation.Name = "lblActivation"
Me.lblActivation.Size = New System.Drawing.Size(128, 16)
Me.lblActivation.TabIndex = 31
Me.lblActivation.Text = "Activation / Disc. Code"
'
'chkMultiShipment
'
Me.chkMultiShipment.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_multishipment", true))
Me.chkMultiShipment.Enabled = false
Me.chkMultiShipment.Location = New System.Drawing.Point(10, 426)
Me.chkMultiShipment.Name = "chkMultiShipment"
Me.chkMultiShipment.Properties.Caption = "Multi-Shipment"
Me.chkMultiShipment.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
Me.chkMultiShipment.Size = New System.Drawing.Size(115, 21)
Me.chkMultiShipment.TabIndex = 30
'
'cmbNextABO
'
Me.cmbNextABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_abo_type", true))
Me.cmbNextABO.Enabled = false
Me.cmbNextABO.Location = New System.Drawing.Point(192, 80)
Me.cmbNextABO.Name = "cmbNextABO"
Me.cmbNextABO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbNextABO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbNextABO.Properties.DataSource = Me.objDS.products_abo
Me.cmbNextABO.Properties.DisplayMember = "products_title"
Me.cmbNextABO.Properties.NullText = ""
Me.cmbNextABO.Properties.ValueMember = "products_id"
Me.cmbNextABO.Size = New System.Drawing.Size(182, 22)
Me.cmbNextABO.TabIndex = 29
'
'txtDVDNormAtHome
'
Me.txtDVDNormAtHome.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_norm", true))
Me.txtDVDNormAtHome.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.txtDVDNormAtHome.Enabled = false
Me.txtDVDNormAtHome.Location = New System.Drawing.Point(307, 250)
Me.txtDVDNormAtHome.Name = "txtDVDNormAtHome"
Me.txtDVDNormAtHome.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtDVDNormAtHome.Size = New System.Drawing.Size(85, 22)
Me.txtDVDNormAtHome.TabIndex = 27
'
'txtDVDAdult
'
Me.txtDVDAdult.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_adult", true))
Me.txtDVDAdult.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.txtDVDAdult.Enabled = false
Me.txtDVDAdult.Location = New System.Drawing.Point(192, 278)
Me.txtDVDAdult.Name = "txtDVDAdult"
Me.txtDVDAdult.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtDVDAdult.Size = New System.Drawing.Size(86, 22)
Me.txtDVDAdult.TabIndex = 26
'
'txtDVDNorm
'
Me.txtDVDNorm.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_norm", true))
Me.txtDVDNorm.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.txtDVDNorm.Enabled = false
Me.txtDVDNorm.Location = New System.Drawing.Point(192, 250)
Me.txtDVDNorm.Name = "txtDVDNorm"
Me.txtDVDNorm.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtDVDNorm.Size = New System.Drawing.Size(86, 22)
Me.txtDVDNorm.TabIndex = 25
'
'lblAdult
'
Me.lblAdult.Location = New System.Drawing.Point(10, 287)
Me.lblAdult.Name = "lblAdult"
Me.lblAdult.Size = New System.Drawing.Size(38, 16)
Me.lblAdult.TabIndex = 24
Me.lblAdult.Text = "ADULT"
'
'lblNorm
'
Me.lblNorm.Location = New System.Drawing.Point(10, 260)
Me.lblNorm.Name = "lblNorm"
Me.lblNorm.Size = New System.Drawing.Size(35, 16)
Me.lblNorm.TabIndex = 23
Me.lblNorm.Text = "NORM"
'
'lblHome
'
Me.lblHome.Location = New System.Drawing.Point(317, 232)
Me.lblHome.Name = "lblHome"
Me.lblHome.Size = New System.Drawing.Size(45, 16)
Me.lblHome.TabIndex = 22
Me.lblHome.Text = "@Home"
'
'lblAsked
'
Me.lblAsked.Location = New System.Drawing.Point(192, 232)
Me.lblAsked.Name = "lblAsked"
Me.lblAsked.Size = New System.Drawing.Size(34, 16)
Me.lblAsked.TabIndex = 21
Me.lblAsked.Text = "Asked"
'
'txtABOCredit
'
Me.txtABOCredit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_credit", true))
Me.txtABOCredit.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
Me.txtABOCredit.Enabled = false
Me.txtABOCredit.Location = New System.Drawing.Point(192, 204)
Me.txtABOCredit.Name = "txtABOCredit"
Me.txtABOCredit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtABOCredit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
Me.txtABOCredit.Properties.MaxLength = 1000
Me.txtABOCredit.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
Me.txtABOCredit.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
Me.txtABOCredit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
Me.txtABOCredit.Size = New System.Drawing.Size(182, 22)
Me.txtABOCredit.TabIndex = 20
'
'lblCredits
'
Me.lblCredits.Location = New System.Drawing.Point(10, 213)
Me.lblCredits.Name = "lblCredits"
Me.lblCredits.Size = New System.Drawing.Size(40, 16)
Me.lblCredits.TabIndex = 19
Me.lblCredits.Text = "Credits"
'
'lblValidity
'
Me.lblValidity.Location = New System.Drawing.Point(10, 117)
Me.lblValidity.Name = "lblValidity"
Me.lblValidity.Size = New System.Drawing.Size(41, 16)
Me.lblValidity.TabIndex = 18
Me.lblValidity.Text = "Validity"
'
'txtAbo_ValidityTo
'
Me.txtAbo_ValidityTo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_validityto", true))
Me.txtAbo_ValidityTo.EditValue = Nothing
Me.txtAbo_ValidityTo.Enabled = false
Me.txtAbo_ValidityTo.Location = New System.Drawing.Point(192, 107)
Me.txtAbo_ValidityTo.Name = "txtAbo_ValidityTo"
Me.txtAbo_ValidityTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.txtAbo_ValidityTo.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtAbo_ValidityTo.Size = New System.Drawing.Size(182, 22)
Me.txtAbo_ValidityTo.TabIndex = 17
'
'cmbABO
'
Me.cmbABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_type", true))
Me.cmbABO.Enabled = false
Me.cmbABO.Location = New System.Drawing.Point(192, 52)
Me.cmbABO.Name = "cmbABO"
Me.cmbABO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbABO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbABO.Properties.DataSource = Me.objDS.products_abo
Me.cmbABO.Properties.DisplayMember = "products_title"
Me.cmbABO.Properties.NullText = ""
Me.cmbABO.Properties.ValueMember = "products_id"
Me.cmbABO.Size = New System.Drawing.Size(182, 22)
Me.cmbABO.TabIndex = 15
'
'lblNextAbo
'
Me.lblNextAbo.Location = New System.Drawing.Point(10, 89)
Me.lblNextAbo.Name = "lblNextAbo"
Me.lblNextAbo.Size = New System.Drawing.Size(53, 16)
Me.lblNextAbo.TabIndex = 14
Me.lblNextAbo.Text = "Next ABO"
'
'lblAbo
'
Me.lblAbo.Location = New System.Drawing.Point(10, 61)
Me.lblAbo.Name = "lblAbo"
Me.lblAbo.Size = New System.Drawing.Size(24, 16)
Me.lblAbo.TabIndex = 12
Me.lblAbo.Text = "ABO"
'
'GCadresse
'
Me.GCadresse.AutoSize = true
Me.GCadresse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
Me.GCadresse.Controls.Add(Me.txtDate_added_Current)
Me.GCadresse.Controls.Add(Me.GridAddress)
Me.GCadresse.Controls.Add(Me.txtDeliveryFirstName)
Me.GCadresse.Controls.Add(Me.txtDeliveryLastName)
Me.GCadresse.Controls.Add(Me.LabelControl10)
Me.GCadresse.Controls.Add(Me.cmbDeliverycountry)
Me.GCadresse.Controls.Add(Me.txtDeliveryCity)
Me.GCadresse.Controls.Add(Me.txtDeliveryPostCode)
Me.GCadresse.Controls.Add(Me.txtDeliveryAddr)
Me.GCadresse.Controls.Add(Me.LabelControl9)
Me.GCadresse.Location = New System.Drawing.Point(19, 545)
Me.GCadresse.Name = "GCadresse"
Me.GCadresse.Size = New System.Drawing.Size(719, 349)
Me.GCadresse.TabIndex = 1
Me.GCadresse.Text = "Default Delivery Address"
'
'txtDate_added_Current
'
Me.txtDate_added_Current.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.date_added", true))
Me.txtDate_added_Current.Enabled = false
Me.txtDate_added_Current.Location = New System.Drawing.Point(5, 98)
Me.txtDate_added_Current.Name = "txtDate_added_Current"
Me.txtDate_added_Current.Properties.ReadOnly = true
Me.txtDate_added_Current.Size = New System.Drawing.Size(161, 22)
Me.txtDate_added_Current.TabIndex = 21
'
'GridAddress
'
Me.GridAddress.AllowDrop = true
Me.GridAddress.EmbeddedNavigator.Name = ""
Me.GridAddress.FormsUseDefaultLookAndFeel = false
Me.GridAddress.Location = New System.Drawing.Point(18, 153)
Me.GridAddress.MainView = Me.GridViewAddress
Me.GridAddress.Name = "GridAddress"
Me.GridAddress.Size = New System.Drawing.Size(692, 169)
Me.GridAddress.TabIndex = 20
Me.GridAddress.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAddress})
'
'GridViewAddress
'
Me.GridViewAddress.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.entry_firstname, Me.entry_lastname, Me.entry_street_address, Me.entry_postcode, Me.entry_city, Me.countries_name, Me.cdate_added})
Me.GridViewAddress.CustomizationFormBounds = New System.Drawing.Rectangle(1382, 593, 218, 205)
Me.GridViewAddress.GridControl = Me.GridAddress
Me.GridViewAddress.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewAddress.Name = "GridViewAddress"
Me.GridViewAddress.OptionsBehavior.Editable = false
Me.GridViewAddress.OptionsCustomization.AllowGroup = false
Me.GridViewAddress.OptionsNavigation.AutoMoveRowFocus = false
Me.GridViewAddress.OptionsSelection.EnableAppearanceFocusedCell = false
Me.GridViewAddress.OptionsSelection.EnableAppearanceFocusedRow = false
Me.GridViewAddress.OptionsView.ColumnAutoWidth = false
Me.GridViewAddress.OptionsView.ShowGroupPanel = false
Me.GridViewAddress.OptionsView.ShowHorzLines = false
Me.GridViewAddress.OptionsView.ShowIndicator = false
'
'entry_firstname
'
Me.entry_firstname.Caption = "entry_firstname"
Me.entry_firstname.FieldName = "entry_firstname"
Me.entry_firstname.Name = "entry_firstname"
Me.entry_firstname.OptionsColumn.AllowEdit = false
Me.entry_firstname.OptionsColumn.FixedWidth = true
Me.entry_firstname.OptionsColumn.ReadOnly = true
Me.entry_firstname.Visible = true
Me.entry_firstname.VisibleIndex = 1
Me.entry_firstname.Width = 130
'
'entry_lastname
'
Me.entry_lastname.Caption = "entry_lastname"
Me.entry_lastname.FieldName = "entry_lastname"
Me.entry_lastname.Name = "entry_lastname"
Me.entry_lastname.OptionsColumn.AllowEdit = false
Me.entry_lastname.OptionsColumn.FixedWidth = true
Me.entry_lastname.OptionsColumn.ReadOnly = true
Me.entry_lastname.Visible = true
Me.entry_lastname.VisibleIndex = 2
Me.entry_lastname.Width = 156
'
'entry_street_address
'
Me.entry_street_address.Caption = "entry_street_address"
Me.entry_street_address.FieldName = "entry_street_address"
Me.entry_street_address.Name = "entry_street_address"
Me.entry_street_address.OptionsColumn.AllowEdit = false
Me.entry_street_address.OptionsColumn.FixedWidth = true
Me.entry_street_address.OptionsColumn.ReadOnly = true
Me.entry_street_address.Visible = true
Me.entry_street_address.VisibleIndex = 3
Me.entry_street_address.Width = 235
'
'entry_postcode
'
Me.entry_postcode.Caption = "entry_postcode"
Me.entry_postcode.FieldName = "entry_postcode"
Me.entry_postcode.Name = "entry_postcode"
Me.entry_postcode.OptionsColumn.AllowEdit = false
Me.entry_postcode.OptionsColumn.FixedWidth = true
Me.entry_postcode.OptionsColumn.ReadOnly = true
Me.entry_postcode.Visible = true
Me.entry_postcode.VisibleIndex = 4
Me.entry_postcode.Width = 111
'
'entry_city
'
Me.entry_city.Caption = "entry_city"
Me.entry_city.FieldName = "entry_city"
Me.entry_city.Name = "entry_city"
Me.entry_city.OptionsColumn.AllowEdit = false
Me.entry_city.OptionsColumn.FixedWidth = true
Me.entry_city.OptionsColumn.ReadOnly = true
Me.entry_city.Visible = true
Me.entry_city.VisibleIndex = 5
Me.entry_city.Width = 108
'
'countries_name
'
Me.countries_name.Caption = "countries_name"
Me.countries_name.FieldName = "countries_name"
Me.countries_name.Name = "countries_name"
Me.countries_name.OptionsColumn.AllowEdit = false
Me.countries_name.OptionsColumn.FixedWidth = true
Me.countries_name.OptionsColumn.ReadOnly = true
Me.countries_name.Visible = true
Me.countries_name.VisibleIndex = 6
Me.countries_name.Width = 135
'
'cdate_added
'
Me.cdate_added.Caption = "date_added"
Me.cdate_added.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.cdate_added.FieldName = "date_added"
Me.cdate_added.Name = "cdate_added"
Me.cdate_added.OptionsColumn.AllowEdit = false
Me.cdate_added.OptionsColumn.ReadOnly = true
Me.cdate_added.Visible = true
Me.cdate_added.VisibleIndex = 0
Me.cdate_added.Width = 96
'
'txtDeliveryFirstName
'
Me.txtDeliveryFirstName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_firstname", true))
Me.txtDeliveryFirstName.Enabled = false
Me.txtDeliveryFirstName.Location = New System.Drawing.Point(461, 32)
Me.txtDeliveryFirstName.Name = "txtDeliveryFirstName"
Me.txtDeliveryFirstName.Size = New System.Drawing.Size(249, 22)
Me.txtDeliveryFirstName.TabIndex = 17
'
'txtDeliveryLastName
'
Me.txtDeliveryLastName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_lastname", true))
Me.txtDeliveryLastName.Enabled = false
Me.txtDeliveryLastName.Location = New System.Drawing.Point(182, 32)
Me.txtDeliveryLastName.Name = "txtDeliveryLastName"
Me.txtDeliveryLastName.Size = New System.Drawing.Size(269, 22)
Me.txtDeliveryLastName.TabIndex = 16
'
'LabelControl10
'
Me.LabelControl10.Location = New System.Drawing.Point(19, 42)
Me.LabelControl10.Name = "LabelControl10"
Me.LabelControl10.Size = New System.Drawing.Size(33, 16)
Me.LabelControl10.TabIndex = 15
Me.LabelControl10.Text = "Name"
'
'cmbDeliverycountry
'
Me.cmbDeliverycountry.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_country_id", true))
Me.cmbDeliverycountry.Enabled = false
Me.cmbDeliverycountry.Location = New System.Drawing.Point(184, 115)
Me.cmbDeliverycountry.Name = "cmbDeliverycountry"
Me.cmbDeliverycountry.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbDeliverycountry.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_id", "countries_id", 77, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_name", "countries_name", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbDeliverycountry.Properties.DataSource = Me.objDS.country
Me.cmbDeliverycountry.Properties.DisplayMember = "countries_name"
Me.cmbDeliverycountry.Properties.NullText = ""
Me.cmbDeliverycountry.Properties.ValueMember = "countries_id"
Me.cmbDeliverycountry.Size = New System.Drawing.Size(528, 22)
Me.cmbDeliverycountry.TabIndex = 14
'
'txtDeliveryCity
'
Me.txtDeliveryCity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_city", true))
Me.txtDeliveryCity.Enabled = false
Me.txtDeliveryCity.Location = New System.Drawing.Point(336, 88)
Me.txtDeliveryCity.Name = "txtDeliveryCity"
Me.txtDeliveryCity.Size = New System.Drawing.Size(374, 22)
Me.txtDeliveryCity.TabIndex = 13
'
'txtDeliveryPostCode
'
Me.txtDeliveryPostCode.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_postcode", true))
Me.txtDeliveryPostCode.Enabled = false
Me.txtDeliveryPostCode.Location = New System.Drawing.Point(182, 88)
Me.txtDeliveryPostCode.Name = "txtDeliveryPostCode"
Me.txtDeliveryPostCode.Size = New System.Drawing.Size(144, 22)
Me.txtDeliveryPostCode.TabIndex = 12
'
'txtDeliveryAddr
'
Me.txtDeliveryAddr.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_street_address", true))
Me.txtDeliveryAddr.Enabled = false
Me.txtDeliveryAddr.Location = New System.Drawing.Point(182, 60)
Me.txtDeliveryAddr.Name = "txtDeliveryAddr"
Me.txtDeliveryAddr.Size = New System.Drawing.Size(528, 22)
Me.txtDeliveryAddr.TabIndex = 10
'
'LabelControl9
'
Me.LabelControl9.Location = New System.Drawing.Point(19, 69)
Me.LabelControl9.Name = "LabelControl9"
Me.LabelControl9.Size = New System.Drawing.Size(46, 16)
Me.LabelControl9.TabIndex = 8
Me.LabelControl9.Text = "Address"
'
'GCcustomersInfo
'
Me.GCcustomersInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCcustomersInfo.Controls.Add(Me.chkCreditReceivedBySite)
Me.GCcustomersInfo.Controls.Add(Me.chkOnly_VOD)
Me.GCcustomersInfo.Controls.Add(Me.txtLast_logon)
Me.GCcustomersInfo.Controls.Add(Me.txtPtSponsorShip)
Me.GCcustomersInfo.Controls.Add(Me.lblComment)
Me.GCcustomersInfo.Controls.Add(Me.chkRedListed)
Me.GCcustomersInfo.Controls.Add(Me.txtComment)
Me.GCcustomersInfo.Controls.Add(Me.chkBlackListed)
Me.GCcustomersInfo.Controls.Add(Me.txtYearsOld)
Me.GCcustomersInfo.Controls.Add(Me.chkNewsLetterPartner)
Me.GCcustomersInfo.Controls.Add(Me.lblGender)
Me.GCcustomersInfo.Controls.Add(Me.chkNewsLetter)
Me.GCcustomersInfo.Controls.Add(Me.txtGender)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl31)
Me.GCcustomersInfo.Controls.Add(Me.lblyearsOld)
Me.GCcustomersInfo.Controls.Add(Me.txtWishListKind)
Me.GCcustomersInfo.Controls.Add(Me.lblSetPassWord)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl30)
Me.GCcustomersInfo.Controls.Add(Me.lblLogas)
Me.GCcustomersInfo.Controls.Add(Me.txtNbrOfLogons)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl36)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl29)
Me.GCcustomersInfo.Controls.Add(Me.cmbEntity)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl28)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl34)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl26)
Me.GCcustomersInfo.Controls.Add(Me.cmbLanguage)
Me.GCcustomersInfo.Controls.Add(Me.txtDateCreated)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl27)
Me.GCcustomersInfo.Controls.Add(Me.txtTel)
Me.GCcustomersInfo.Controls.Add(Me.txtEMail)
Me.GCcustomersInfo.Controls.Add(Me.txtTelEvening)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl21)
Me.GCcustomersInfo.Controls.Add(Me.txtABO)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl11)
Me.GCcustomersInfo.Controls.Add(Me.DateBirthday)
Me.GCcustomersInfo.Controls.Add(Me.txtFirstName)
Me.GCcustomersInfo.Controls.Add(Me.txtLastName)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl7)
Me.GCcustomersInfo.Controls.Add(Me.txtCustomers_id)
Me.GCcustomersInfo.Controls.Add(Me.LabelControl8)
Me.GCcustomersInfo.Location = New System.Drawing.Point(19, 46)
Me.GCcustomersInfo.Name = "GCcustomersInfo"
Me.GCcustomersInfo.Size = New System.Drawing.Size(720, 477)
Me.GCcustomersInfo.TabIndex = 0
Me.GCcustomersInfo.Text = "Global Info"
'
'chkCreditReceivedBySite
'
Me.chkCreditReceivedBySite.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customer_attributes.credits_already_recieved", true))
Me.chkCreditReceivedBySite.Enabled = false
Me.chkCreditReceivedBySite.Location = New System.Drawing.Point(413, 395)
Me.chkCreditReceivedBySite.Name = "chkCreditReceivedBySite"
Me.chkCreditReceivedBySite.Properties.Caption = "Credit Received By Site"
Me.chkCreditReceivedBySite.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.chkCreditReceivedBySite.Size = New System.Drawing.Size(171, 21)
Me.chkCreditReceivedBySite.TabIndex = 61
'
'chkOnly_VOD
'
Me.chkOnly_VOD.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customer_attributes.only_vod", true))
Me.chkOnly_VOD.Enabled = false
Me.chkOnly_VOD.Location = New System.Drawing.Point(413, 443)
Me.chkOnly_VOD.Name = "chkOnly_VOD"
Me.chkOnly_VOD.Properties.Caption = "Only VOD"
Me.chkOnly_VOD.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.chkOnly_VOD.Size = New System.Drawing.Size(153, 21)
Me.chkOnly_VOD.TabIndex = 60
'
'txtLast_logon
'
Me.txtLast_logon.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customer_attributes.last_login_at", true))
Me.txtLast_logon.Enabled = false
Me.txtLast_logon.Location = New System.Drawing.Point(173, 335)
Me.txtLast_logon.Name = "txtLast_logon"
Me.txtLast_logon.Size = New System.Drawing.Size(182, 22)
Me.txtLast_logon.TabIndex = 59
'
'txtPtSponsorShip
'
Me.txtPtSponsorShip.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.mgm_points", true))
Me.txtPtSponsorShip.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.txtPtSponsorShip.Enabled = false
Me.txtPtSponsorShip.Location = New System.Drawing.Point(526, 329)
Me.txtPtSponsorShip.Name = "txtPtSponsorShip"
Me.txtPtSponsorShip.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtPtSponsorShip.Properties.MaxLength = 100000
Me.txtPtSponsorShip.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
Me.txtPtSponsorShip.Size = New System.Drawing.Size(182, 22)
Me.txtPtSponsorShip.TabIndex = 26
'
'lblComment
'
Me.lblComment.Location = New System.Drawing.Point(19, 270)
Me.lblComment.Name = "lblComment"
Me.lblComment.Size = New System.Drawing.Size(55, 16)
Me.lblComment.TabIndex = 58
Me.lblComment.Text = "Comment"
'
'chkRedListed
'
Me.chkRedListed.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.red_listed", true))
Me.chkRedListed.Enabled = false
Me.chkRedListed.Location = New System.Drawing.Point(271, 396)
Me.chkRedListed.Name = "chkRedListed"
Me.chkRedListed.Properties.Caption = "Red Listed"
Me.chkRedListed.Size = New System.Drawing.Size(112, 21)
Me.chkRedListed.TabIndex = 54
'
'txtComment
'
Me.txtComment.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.comment", true))
Me.txtComment.Enabled = false
Me.txtComment.Location = New System.Drawing.Point(173, 267)
Me.txtComment.Name = "txtComment"
Me.txtComment.Size = New System.Drawing.Size(528, 22)
Me.txtComment.TabIndex = 57
'
'chkBlackListed
'
Me.chkBlackListed.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.black_listed", true))
Me.chkBlackListed.Enabled = false
Me.chkBlackListed.Location = New System.Drawing.Point(271, 443)
Me.chkBlackListed.Name = "chkBlackListed"
Me.chkBlackListed.Properties.Caption = "Black Listed"
Me.chkBlackListed.Size = New System.Drawing.Size(118, 21)
Me.chkBlackListed.TabIndex = 53
'
'txtYearsOld
'
Me.txtYearsOld.Enabled = false
Me.txtYearsOld.Location = New System.Drawing.Point(355, 207)
Me.txtYearsOld.Name = "txtYearsOld"
Me.txtYearsOld.Size = New System.Drawing.Size(34, 22)
Me.txtYearsOld.TabIndex = 56
'
'chkNewsLetterPartner
'
Me.chkNewsLetterPartner.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_newsletterpartner", true))
Me.chkNewsLetterPartner.Enabled = false
Me.chkNewsLetterPartner.Location = New System.Drawing.Point(82, 443)
Me.chkNewsLetterPartner.Name = "chkNewsLetterPartner"
Me.chkNewsLetterPartner.Properties.Caption = "NewsLetter Partner"
Me.chkNewsLetterPartner.Size = New System.Drawing.Size(182, 21)
Me.chkNewsLetterPartner.TabIndex = 52
'
'lblGender
'
Me.lblGender.Location = New System.Drawing.Point(19, 240)
Me.lblGender.Name = "lblGender"
Me.lblGender.Size = New System.Drawing.Size(41, 16)
Me.lblGender.TabIndex = 55
Me.lblGender.Text = "Gender"
'
'chkNewsLetter
'
Me.chkNewsLetter.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_newsletter", true))
Me.chkNewsLetter.Enabled = false
Me.chkNewsLetter.Location = New System.Drawing.Point(82, 396)
Me.chkNewsLetter.Name = "chkNewsLetter"
Me.chkNewsLetter.Properties.Caption = "NewsLetter"
Me.chkNewsLetter.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.chkNewsLetter.Size = New System.Drawing.Size(153, 21)
Me.chkNewsLetter.TabIndex = 51
'
'txtGender
'
Me.txtGender.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_gender", true))
Me.txtGender.Enabled = false
Me.txtGender.Location = New System.Drawing.Point(173, 237)
Me.txtGender.Name = "txtGender"
Me.txtGender.Size = New System.Drawing.Size(33, 22)
Me.txtGender.TabIndex = 54
'
'LabelControl31
'
Me.LabelControl31.Location = New System.Drawing.Point(396, 332)
Me.LabelControl31.Name = "LabelControl31"
Me.LabelControl31.Size = New System.Drawing.Size(95, 16)
Me.LabelControl31.TabIndex = 49
Me.LabelControl31.Text = "Points Parainage"
'
'lblyearsOld
'
Me.lblyearsOld.Location = New System.Drawing.Point(396, 210)
Me.lblyearsOld.Name = "lblyearsOld"
Me.lblyearsOld.Size = New System.Drawing.Size(52, 16)
Me.lblyearsOld.TabIndex = 53
Me.lblyearsOld.Text = "years old"
'
'txtWishListKind
'
Me.txtWishListKind.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.wishlist_kind", true))
Me.txtWishListKind.Enabled = false
Me.txtWishListKind.Location = New System.Drawing.Point(526, 300)
Me.txtWishListKind.Name = "txtWishListKind"
Me.txtWishListKind.Size = New System.Drawing.Size(182, 22)
Me.txtWishListKind.TabIndex = 48
'
'lblSetPassWord
'
Me.lblSetPassWord.Appearance.ForeColor = System.Drawing.Color.DarkRed
Me.lblSetPassWord.Appearance.Options.UseForeColor = true
Me.lblSetPassWord.Cursor = System.Windows.Forms.Cursors.Hand
Me.lblSetPassWord.Location = New System.Drawing.Point(239, 33)
Me.lblSetPassWord.Name = "lblSetPassWord"
Me.lblSetPassWord.Size = New System.Drawing.Size(121, 16)
Me.lblSetPassWord.TabIndex = 51
Me.lblSetPassWord.Text = " Set a new password"
'
'LabelControl30
'
Me.LabelControl30.Location = New System.Drawing.Point(396, 303)
Me.LabelControl30.Name = "LabelControl30"
Me.LabelControl30.Size = New System.Drawing.Size(75, 16)
Me.LabelControl30.TabIndex = 47
Me.LabelControl30.Text = "WishList Kind"
'
'lblLogas
'
Me.lblLogas.Appearance.ForeColor = System.Drawing.Color.DarkRed
Me.lblLogas.Appearance.Options.UseForeColor = true
Me.lblLogas.Cursor = System.Windows.Forms.Cursors.Hand
Me.lblLogas.Location = New System.Drawing.Point(173, 33)
Me.lblLogas.Name = "lblLogas"
Me.lblLogas.Size = New System.Drawing.Size(33, 16)
Me.lblLogas.TabIndex = 50
Me.lblLogas.Text = "Logas"
'
'txtNbrOfLogons
'
Me.txtNbrOfLogons.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customer_attributes.number_of_logins", true))
Me.txtNbrOfLogons.Enabled = false
Me.txtNbrOfLogons.Location = New System.Drawing.Point(173, 363)
Me.txtNbrOfLogons.Name = "txtNbrOfLogons"
Me.txtNbrOfLogons.Size = New System.Drawing.Size(182, 22)
Me.txtNbrOfLogons.TabIndex = 46
'
'LabelControl36
'
Me.LabelControl36.Location = New System.Drawing.Point(19, 155)
Me.LabelControl36.Name = "LabelControl36"
Me.LabelControl36.Size = New System.Drawing.Size(35, 16)
Me.LabelControl36.TabIndex = 49
Me.LabelControl36.Text = "E-Mail"
'
'LabelControl29
'
Me.LabelControl29.Location = New System.Drawing.Point(17, 365)
Me.LabelControl29.Name = "LabelControl29"
Me.LabelControl29.Size = New System.Drawing.Size(79, 16)
Me.LabelControl29.TabIndex = 45
Me.LabelControl29.Text = "Nbr of Logons"
'
'cmbEntity
'
Me.cmbEntity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.EntityID", true))
Me.cmbEntity.Enabled = false
Me.cmbEntity.Location = New System.Drawing.Point(173, 87)
Me.cmbEntity.Name = "cmbEntity"
Me.cmbEntity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbEntity.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbEntity.Properties.DataSource = Me.objDS.generalentity
Me.cmbEntity.Properties.DisplayMember = "Name"
Me.cmbEntity.Properties.NullText = ""
Me.cmbEntity.Properties.ValueMember = "EntityID"
Me.cmbEntity.Size = New System.Drawing.Size(269, 22)
Me.cmbEntity.TabIndex = 44
'
'LabelControl28
'
Me.LabelControl28.Location = New System.Drawing.Point(17, 337)
Me.LabelControl28.Name = "LabelControl28"
Me.LabelControl28.Size = New System.Drawing.Size(61, 16)
Me.LabelControl28.TabIndex = 44
Me.LabelControl28.Text = "Last Logon"
'
'LabelControl34
'
Me.LabelControl34.Location = New System.Drawing.Point(18, 90)
Me.LabelControl34.Name = "LabelControl34"
Me.LabelControl34.Size = New System.Drawing.Size(31, 16)
Me.LabelControl34.TabIndex = 43
Me.LabelControl34.Text = "Entity"
'
'LabelControl26
'
Me.LabelControl26.Location = New System.Drawing.Point(336, 59)
Me.LabelControl26.Name = "LabelControl26"
Me.LabelControl26.Size = New System.Drawing.Size(45, 16)
Me.LabelControl26.TabIndex = 42
Me.LabelControl26.Text = "Created"
'
'cmbLanguage
'
Me.cmbLanguage.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_language", true))
Me.cmbLanguage.Enabled = false
Me.cmbLanguage.Location = New System.Drawing.Point(173, 300)
Me.cmbLanguage.Name = "cmbLanguage"
Me.cmbLanguage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.cmbLanguage.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.cmbLanguage.Properties.DataSource = Me.objDS.languages
Me.cmbLanguage.Properties.DisplayMember = "name"
Me.cmbLanguage.Properties.NullText = ""
Me.cmbLanguage.Properties.ValueMember = "languages_id"
Me.cmbLanguage.Size = New System.Drawing.Size(182, 22)
Me.cmbLanguage.TabIndex = 17
'
'txtDateCreated
'
Me.txtDateCreated.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_info_date_account_created", true))
Me.txtDateCreated.EditValue = Nothing
Me.txtDateCreated.Enabled = false
Me.txtDateCreated.Location = New System.Drawing.Point(451, 59)
Me.txtDateCreated.Name = "txtDateCreated"
Me.txtDateCreated.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
Me.txtDateCreated.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.txtDateCreated.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.txtDateCreated.Size = New System.Drawing.Size(173, 22)
Me.txtDateCreated.TabIndex = 41
'
'LabelControl27
'
Me.LabelControl27.Location = New System.Drawing.Point(17, 309)
Me.LabelControl27.Name = "LabelControl27"
Me.LabelControl27.Size = New System.Drawing.Size(55, 16)
Me.LabelControl27.TabIndex = 16
Me.LabelControl27.Text = "Language"
'
'txtTel
'
Me.txtTel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone", true))
Me.txtTel.Enabled = false
Me.txtTel.Location = New System.Drawing.Point(173, 179)
Me.txtTel.Name = "txtTel"
Me.txtTel.Size = New System.Drawing.Size(269, 22)
Me.txtTel.TabIndex = 20
'
'txtEMail
'
Me.txtEMail.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_email_address", true))
Me.txtEMail.Enabled = false
Me.txtEMail.Location = New System.Drawing.Point(173, 151)
Me.txtEMail.Name = "txtEMail"
Me.txtEMail.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
Me.txtEMail.Size = New System.Drawing.Size(528, 22)
Me.txtEMail.TabIndex = 19
'
'txtTelEvening
'
Me.txtTelEvening.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone_evening", true))
Me.txtTelEvening.Enabled = false
Me.txtTelEvening.Location = New System.Drawing.Point(451, 179)
Me.txtTelEvening.Name = "txtTelEvening"
Me.txtTelEvening.Size = New System.Drawing.Size(250, 22)
Me.txtTelEvening.TabIndex = 18
'
'LabelControl21
'
Me.LabelControl21.Location = New System.Drawing.Point(19, 181)
Me.LabelControl21.Name = "LabelControl21"
Me.LabelControl21.Size = New System.Drawing.Size(100, 16)
Me.LabelControl21.TabIndex = 16
Me.LabelControl21.Text = "Tel Day / Evening"
'
'txtABO
'
Me.txtABO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo", true))
Me.txtABO.Enabled = false
Me.txtABO.Location = New System.Drawing.Point(634, 59)
Me.txtABO.Name = "txtABO"
Me.txtABO.Properties.Appearance.BackColor = System.Drawing.Color.Red
Me.txtABO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Bold)
Me.txtABO.Properties.Appearance.Options.UseBackColor = true
Me.txtABO.Properties.Appearance.Options.UseFont = true
Me.txtABO.Properties.Caption = "ABO"
Me.txtABO.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
Me.txtABO.Properties.ValueChecked = 1
Me.txtABO.Properties.ValueUnchecked = 0
Me.txtABO.Size = New System.Drawing.Size(67, 26)
Me.txtABO.TabIndex = 15
'
'LabelControl11
'
Me.LabelControl11.Location = New System.Drawing.Point(19, 210)
Me.LabelControl11.Name = "LabelControl11"
Me.LabelControl11.Size = New System.Drawing.Size(71, 16)
Me.LabelControl11.TabIndex = 11
Me.LabelControl11.Text = "Date of Birth"
'
'DateBirthday
'
Me.DateBirthday.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_dob", true))
Me.DateBirthday.EditValue = Nothing
Me.DateBirthday.Enabled = false
Me.DateBirthday.Location = New System.Drawing.Point(173, 207)
Me.DateBirthday.Name = "DateBirthday"
Me.DateBirthday.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.DateBirthday.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.DateBirthday.Size = New System.Drawing.Size(153, 22)
Me.DateBirthday.TabIndex = 10
'
'txtFirstName
'
Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_firstname", true))
Me.txtFirstName.Enabled = false
Me.txtFirstName.Location = New System.Drawing.Point(451, 123)
Me.txtFirstName.Name = "txtFirstName"
Me.txtFirstName.Size = New System.Drawing.Size(250, 22)
Me.txtFirstName.TabIndex = 9
'
'txtLastName
'
Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_lastname", true))
Me.txtLastName.Enabled = false
Me.txtLastName.Location = New System.Drawing.Point(173, 123)
Me.txtLastName.Name = "txtLastName"
Me.txtLastName.Size = New System.Drawing.Size(269, 22)
Me.txtLastName.TabIndex = 7
'
'LabelControl7
'
Me.LabelControl7.Location = New System.Drawing.Point(19, 127)
Me.LabelControl7.Name = "LabelControl7"
Me.LabelControl7.Size = New System.Drawing.Size(33, 16)
Me.LabelControl7.TabIndex = 6
Me.LabelControl7.Text = "Name"
'
'txtCustomers_id
'
Me.txtCustomers_id.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_id", true))
Me.txtCustomers_id.Enabled = false
Me.txtCustomers_id.Location = New System.Drawing.Point(173, 59)
Me.txtCustomers_id.Name = "txtCustomers_id"
Me.txtCustomers_id.Properties.ReadOnly = true
Me.txtCustomers_id.Size = New System.Drawing.Size(153, 22)
Me.txtCustomers_id.TabIndex = 5
'
'LabelControl8
'
Me.LabelControl8.Location = New System.Drawing.Point(19, 62)
Me.LabelControl8.Name = "LabelControl8"
Me.LabelControl8.Size = New System.Drawing.Size(71, 16)
Me.LabelControl8.TabIndex = 4
Me.LabelControl8.Text = "Customer ID"
'
'btnStopNow
'
Me.btnStopNow.Location = New System.Drawing.Point(1187, 417)
Me.btnStopNow.Name = "btnStopNow"
Me.btnStopNow.Size = New System.Drawing.Size(173, 26)
Me.btnStopNow.TabIndex = 2
Me.btnStopNow.Text = "Stop NOW"
'
'btnStopAtReconduction
'
Me.btnStopAtReconduction.Location = New System.Drawing.Point(1187, 150)
Me.btnStopAtReconduction.Name = "btnStopAtReconduction"
Me.btnStopAtReconduction.Size = New System.Drawing.Size(173, 27)
Me.btnStopAtReconduction.TabIndex = 3
Me.btnStopAtReconduction.Text = "Stop @ Reconduction"
'
'tabSearch
'
Me.tabSearch.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
Me.tabSearch.Appearance.Header.Options.UseFont = true
Me.tabSearch.Controls.Add(Me.GridControl1)
Me.tabSearch.Controls.Add(Me.PanelControl1)
Me.tabSearch.Name = "tabSearch"
Me.tabSearch.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[False]
Me.tabSearch.Size = New System.Drawing.Size(1505, 905)
Me.tabSearch.Text = "Search"
'
'PanelControl1
'
Me.PanelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.PanelControl1.Controls.Add(Me.btnReplayAllCreditHistory)
Me.PanelControl1.Controls.Add(Me.BtnEmailError)
Me.PanelControl1.Controls.Add(Me.btnRedlisted)
Me.PanelControl1.Controls.Add(Me.btnBlackListed)
Me.PanelControl1.Controls.Add(Me.BtnSponsorCard)
Me.PanelControl1.Controls.Add(Me.btnViewGift)
Me.PanelControl1.Controls.Add(Me.btnViewCustserv)
Me.PanelControl1.Controls.Add(Me.TxtCustomers_NumComm)
Me.PanelControl1.Controls.Add(Me.lblNumComm)
Me.PanelControl1.Controls.Add(Me.txtcustomers_domiciliation_number_search)
Me.PanelControl1.Controls.Add(Me.LabelControl4)
Me.PanelControl1.Controls.Add(Me.btnPhoneActivation)
Me.PanelControl1.Controls.Add(Me.LabelControl35)
Me.PanelControl1.Controls.Add(Me.LabelControl6)
Me.PanelControl1.Controls.Add(Me.LabelControl5)
Me.PanelControl1.Controls.Add(Me.txtcustomers_postcode_search)
Me.PanelControl1.Controls.Add(Me.btnSearch)
Me.PanelControl1.Controls.Add(Me.txtcustomers_address_street_search)
Me.PanelControl1.Controls.Add(Me.txtcustomers_email_address_search)
Me.PanelControl1.Controls.Add(Me.txtcustomers_name_search)
Me.PanelControl1.Controls.Add(Me.LabelControl2)
Me.PanelControl1.Controls.Add(Me.txtcustomers_id_search)
Me.PanelControl1.Controls.Add(Me.LabelControl1)
Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
Me.PanelControl1.Name = "PanelControl1"
Me.PanelControl1.Size = New System.Drawing.Size(1505, 203)
Me.PanelControl1.TabIndex = 0
'
'btnReplayAllCreditHistory
'
Me.btnReplayAllCreditHistory.Location = New System.Drawing.Point(974, 99)
Me.btnReplayAllCreditHistory.Name = "btnReplayAllCreditHistory"
Me.btnReplayAllCreditHistory.Size = New System.Drawing.Size(166, 45)
Me.btnReplayAllCreditHistory.TabIndex = 60
Me.btnReplayAllCreditHistory.Text = "replay all credit history"
Me.btnReplayAllCreditHistory.Visible = false
'
'BtnEmailError
'
Me.BtnEmailError.Location = New System.Drawing.Point(612, 137)
Me.BtnEmailError.Name = "BtnEmailError"
Me.BtnEmailError.Size = New System.Drawing.Size(166, 27)
Me.BtnEmailError.TabIndex = 59
Me.BtnEmailError.Text = "Email Error"
'
'btnRedlisted
'
Me.btnRedlisted.Location = New System.Drawing.Point(788, 55)
Me.btnRedlisted.Name = "btnRedlisted"
Me.btnRedlisted.Size = New System.Drawing.Size(166, 27)
Me.btnRedlisted.TabIndex = 58
Me.btnRedlisted.Text = "Customers Redlisted"
'
'btnBlackListed
'
Me.btnBlackListed.Location = New System.Drawing.Point(612, 55)
Me.btnBlackListed.Name = "btnBlackListed"
Me.btnBlackListed.Size = New System.Drawing.Size(169, 27)
Me.btnBlackListed.TabIndex = 57
Me.btnBlackListed.Text = "Customers Blacklisted"
'
'BtnSponsorCard
'
Me.BtnSponsorCard.Location = New System.Drawing.Point(974, 55)
Me.BtnSponsorCard.Name = "BtnSponsorCard"
Me.BtnSponsorCard.Size = New System.Drawing.Size(166, 27)
Me.BtnSponsorCard.TabIndex = 56
Me.BtnSponsorCard.Text = "Sponsor card"
'
'btnViewGift
'
Me.btnViewGift.Location = New System.Drawing.Point(788, 137)
Me.btnViewGift.Name = "btnViewGift"
Me.btnViewGift.Size = New System.Drawing.Size(166, 27)
Me.btnViewGift.TabIndex = 55
Me.btnViewGift.Text = "View Customers With Gift"
'
'btnViewCustserv
'
Me.btnViewCustserv.Location = New System.Drawing.Point(788, 99)
Me.btnViewCustserv.Name = "btnViewCustserv"
Me.btnViewCustserv.Size = New System.Drawing.Size(166, 27)
Me.btnViewCustserv.TabIndex = 54
Me.btnViewCustserv.Text = "View CustServ"
Me.btnViewCustserv.Visible = false
'
'TxtCustomers_NumComm
'
Me.TxtCustomers_NumComm.Location = New System.Drawing.Point(163, 126)
Me.TxtCustomers_NumComm.Name = "TxtCustomers_NumComm"
Me.TxtCustomers_NumComm.Size = New System.Drawing.Size(165, 22)
Me.TxtCustomers_NumComm.TabIndex = 53
'
'lblNumComm
'
Me.lblNumComm.Location = New System.Drawing.Point(41, 128)
Me.lblNumComm.Name = "lblNumComm"
Me.lblNumComm.Size = New System.Drawing.Size(118, 16)
Me.lblNumComm.TabIndex = 52
Me.lblNumComm.Text = "Communication Num"
'
'txtcustomers_domiciliation_number_search
'
Me.txtcustomers_domiciliation_number_search.Location = New System.Drawing.Point(163, 160)
Me.txtcustomers_domiciliation_number_search.Name = "txtcustomers_domiciliation_number_search"
Me.txtcustomers_domiciliation_number_search.Size = New System.Drawing.Size(165, 22)
Me.txtcustomers_domiciliation_number_search.TabIndex = 51
'
'LabelControl4
'
Me.LabelControl4.Location = New System.Drawing.Point(41, 164)
Me.LabelControl4.Name = "LabelControl4"
Me.LabelControl4.Size = New System.Drawing.Size(102, 16)
Me.LabelControl4.TabIndex = 50
Me.LabelControl4.Text = "Domiciliation Num"
'
'btnPhoneActivation
'
Me.btnPhoneActivation.Location = New System.Drawing.Point(612, 99)
Me.btnPhoneActivation.Name = "btnPhoneActivation"
Me.btnPhoneActivation.Size = New System.Drawing.Size(169, 27)
Me.btnPhoneActivation.TabIndex = 49
Me.btnPhoneActivation.Text = "&View Phone Activation"
'
'LabelControl35
'
Me.LabelControl35.Location = New System.Drawing.Point(29, 82)
Me.LabelControl35.Name = "LabelControl35"
Me.LabelControl35.Size = New System.Drawing.Size(35, 16)
Me.LabelControl35.TabIndex = 48
Me.LabelControl35.Text = "E-Mail"
'
'LabelControl6
'
Me.LabelControl6.Location = New System.Drawing.Point(313, 58)
Me.LabelControl6.Name = "LabelControl6"
Me.LabelControl6.Size = New System.Drawing.Size(53, 16)
Me.LabelControl6.TabIndex = 47
Me.LabelControl6.Text = "PostCode"
'
'LabelControl5
'
Me.LabelControl5.Location = New System.Drawing.Point(313, 27)
Me.LabelControl5.Name = "LabelControl5"
Me.LabelControl5.Size = New System.Drawing.Size(35, 16)
Me.LabelControl5.TabIndex = 46
Me.LabelControl5.Text = "Street"
'
'txtcustomers_postcode_search
'
Me.txtcustomers_postcode_search.Location = New System.Drawing.Point(376, 54)
Me.txtcustomers_postcode_search.Name = "txtcustomers_postcode_search"
Me.txtcustomers_postcode_search.Size = New System.Drawing.Size(187, 22)
Me.txtcustomers_postcode_search.TabIndex = 12
'
'btnSearch
'
Me.btnSearch.Location = New System.Drawing.Point(376, 136)
Me.btnSearch.Name = "btnSearch"
Me.btnSearch.Size = New System.Drawing.Size(164, 43)
Me.btnSearch.TabIndex = 10
Me.btnSearch.Text = "&Search"
'
'txtcustomers_address_street_search
'
Me.txtcustomers_address_street_search.Location = New System.Drawing.Point(376, 24)
Me.txtcustomers_address_street_search.Name = "txtcustomers_address_street_search"
Me.txtcustomers_address_street_search.Size = New System.Drawing.Size(187, 22)
Me.txtcustomers_address_street_search.TabIndex = 9
'
'txtcustomers_email_address_search
'
Me.txtcustomers_email_address_search.Location = New System.Drawing.Point(108, 78)
Me.txtcustomers_email_address_search.Name = "txtcustomers_email_address_search"
Me.txtcustomers_email_address_search.Size = New System.Drawing.Size(187, 22)
Me.txtcustomers_email_address_search.TabIndex = 5
'
'txtcustomers_name_search
'
Me.txtcustomers_name_search.Location = New System.Drawing.Point(108, 50)
Me.txtcustomers_name_search.Name = "txtcustomers_name_search"
Me.txtcustomers_name_search.Size = New System.Drawing.Size(187, 22)
Me.txtcustomers_name_search.TabIndex = 3
'
'LabelControl2
'
Me.LabelControl2.Location = New System.Drawing.Point(29, 55)
Me.LabelControl2.Name = "LabelControl2"
Me.LabelControl2.Size = New System.Drawing.Size(33, 16)
Me.LabelControl2.TabIndex = 2
Me.LabelControl2.Text = "Name"
'
'txtcustomers_id_search
'
Me.txtcustomers_id_search.Location = New System.Drawing.Point(108, 22)
Me.txtcustomers_id_search.Name = "txtcustomers_id_search"
Me.txtcustomers_id_search.Size = New System.Drawing.Size(187, 22)
Me.txtcustomers_id_search.TabIndex = 1
'
'LabelControl1
'
Me.LabelControl1.Location = New System.Drawing.Point(29, 25)
Me.LabelControl1.Name = "LabelControl1"
Me.LabelControl1.Size = New System.Drawing.Size(71, 16)
Me.LabelControl1.TabIndex = 0
Me.LabelControl1.Text = "Customer ID"
'
'XTabCustomers
'
Me.XTabCustomers.Dock = System.Windows.Forms.DockStyle.Fill
Me.XTabCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.XTabCustomers.Location = New System.Drawing.Point(0, 66)
Me.XTabCustomers.Name = "XTabCustomers"
Me.XTabCustomers.SelectedTabPage = Me.tabMain
Me.XTabCustomers.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
Me.XTabCustomers.Size = New System.Drawing.Size(1262, 816)
Me.XTabCustomers.TabIndex = 35
Me.XTabCustomers.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabSearch, Me.tabMain, Me.tabComment, Me.tabCalls, Me.tabWishList, Me.tabAboHistory, Me.tabOrdersHistor, Me.tabMessagerie, Me.tabCustServ, Me.tabPayment, Me.tabMailHistory, Me.tabSponsorShip, Me.tabPaymentMovements, Me.tabDroselia, Me.tabAboprocess, Me.tabAboProcessOld, Me.tabPurchase, Me.tabCreditHist, Me.tabCompensation, Me.tabProductsRating, Me.tabSuspendedHistory, Me.tabVodView, Me.tabCritiques, Me.tabConfig})
'
'tabComment
'
Me.tabComment.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
Me.tabComment.Appearance.Header.Options.UseFont = true
Me.tabComment.AutoScroll = true
Me.tabComment.Controls.Add(Me.MemoCustomersComment)
Me.tabComment.Controls.Add(Me.GridCustComment)
Me.tabComment.Controls.Add(Me.MemoInsertComment)
Me.tabComment.Controls.Add(Me.btnAddCustomersComment)
Me.tabComment.Name = "tabComment"
Me.tabComment.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[True]
Me.tabComment.Size = New System.Drawing.Size(1505, 905)
Me.tabComment.Text = "Comment"
'
'MemoCustomersComment
'
Me.MemoCustomersComment.Location = New System.Drawing.Point(68, 57)
Me.MemoCustomersComment.Name = "MemoCustomersComment"
Me.MemoCustomersComment.Properties.ReadOnly = true
Me.MemoCustomersComment.Size = New System.Drawing.Size(466, 98)
Me.MemoCustomersComment.StyleController = Me.LayoutCustServ
Me.MemoCustomersComment.TabIndex = 15
'
'GridCustComment
'
Me.GridCustComment.EmbeddedNavigator.Name = ""
Me.GridCustComment.FormsUseDefaultLookAndFeel = false
Me.GridCustComment.Location = New System.Drawing.Point(68, 227)
Me.GridCustComment.MainView = Me.GridViewCustComment
Me.GridCustComment.Name = "GridCustComment"
Me.GridCustComment.Size = New System.Drawing.Size(939, 460)
Me.GridCustComment.TabIndex = 0
Me.GridCustComment.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCustComment})
'
'GridViewCustComment
'
Me.GridViewCustComment.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.customers_comment_text, Me.customers_comment_date, Me.fullName})
Me.GridViewCustComment.GridControl = Me.GridCustComment
Me.GridViewCustComment.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewCustComment.Name = "GridViewCustComment"
'
'customers_comment_text
'
Me.customers_comment_text.Caption = "customers_comment_text"
Me.customers_comment_text.FieldName = "customers_comment_text"
Me.customers_comment_text.Name = "customers_comment_text"
Me.customers_comment_text.OptionsColumn.AllowEdit = false
Me.customers_comment_text.OptionsColumn.ReadOnly = true
Me.customers_comment_text.Visible = true
Me.customers_comment_text.VisibleIndex = 1
Me.customers_comment_text.Width = 1002
'
'customers_comment_date
'
Me.customers_comment_date.Caption = "customers_comment_date"
Me.customers_comment_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.customers_comment_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.customers_comment_date.FieldName = "customers_comment_date"
Me.customers_comment_date.Name = "customers_comment_date"
Me.customers_comment_date.OptionsColumn.AllowEdit = false
Me.customers_comment_date.OptionsColumn.ReadOnly = true
Me.customers_comment_date.Visible = true
Me.customers_comment_date.VisibleIndex = 0
Me.customers_comment_date.Width = 549
'
'fullName
'
Me.fullName.Caption = "comment_by"
Me.fullName.FieldName = "FullName"
Me.fullName.Name = "fullName"
Me.fullName.Visible = true
Me.fullName.VisibleIndex = 2
'
'MemoInsertComment
'
Me.MemoInsertComment.Location = New System.Drawing.Point(541, 57)
Me.MemoInsertComment.Name = "MemoInsertComment"
Me.MemoInsertComment.Size = New System.Drawing.Size(466, 98)
Me.MemoInsertComment.StyleController = Me.LayoutCustServ
Me.MemoInsertComment.TabIndex = 16
'
'btnAddCustomersComment
'
Me.btnAddCustomersComment.Location = New System.Drawing.Point(832, 162)
Me.btnAddCustomersComment.Name = "btnAddCustomersComment"
Me.btnAddCustomersComment.Size = New System.Drawing.Size(175, 26)
Me.btnAddCustomersComment.TabIndex = 14
Me.btnAddCustomersComment.Text = "Add Customers Comment"
'
'tabCalls
'
Me.tabCalls.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.tabCalls.Appearance.Header.Options.UseFont = true
Me.tabCalls.Controls.Add(Me.UcCallsHistory1)
Me.tabCalls.Name = "tabCalls"
Me.tabCalls.Size = New System.Drawing.Size(1505, 905)
Me.tabCalls.Text = "calls"
'
'UcCallsHistory1
'
Me.UcCallsHistory1.customers_id = 0
Me.UcCallsHistory1.FT = false
Me.UcCallsHistory1.Location = New System.Drawing.Point(8, 3)
Me.UcCallsHistory1.Margin = New System.Windows.Forms.Padding(2)
Me.UcCallsHistory1.Name = "UcCallsHistory1"
Me.UcCallsHistory1.Reconductions = 0
Me.UcCallsHistory1.Size = New System.Drawing.Size(1245, 594)
Me.UcCallsHistory1.TabIndex = 0
'
'tabMessagerie
'
Me.tabMessagerie.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.tabMessagerie.Appearance.Header.Options.UseFont = true
Me.tabMessagerie.Controls.Add(Me.UcMessagerieCustomer)
Me.tabMessagerie.Name = "tabMessagerie"
Me.tabMessagerie.Size = New System.Drawing.Size(1505, 905)
Me.tabMessagerie.Text = "Messagerie"
'
'UcMessagerieCustomer
'
Me.UcMessagerieCustomer.Customers_id = 0
Me.UcMessagerieCustomer.Dock = System.Windows.Forms.DockStyle.Fill
Me.UcMessagerieCustomer.language_id = 0
Me.UcMessagerieCustomer.Location = New System.Drawing.Point(0, 0)
Me.UcMessagerieCustomer.Margin = New System.Windows.Forms.Padding(2)
Me.UcMessagerieCustomer.Name = "UcMessagerieCustomer"
Me.UcMessagerieCustomer.Size = New System.Drawing.Size(1505, 905)
Me.UcMessagerieCustomer.TabIndex = 0
'
'tabSponsorShip
'
Me.tabSponsorShip.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
Me.tabSponsorShip.Appearance.Header.Options.UseFont = true
Me.tabSponsorShip.AutoScroll = true
Me.tabSponsorShip.Controls.Add(Me.GCCodeLinked)
Me.tabSponsorShip.Controls.Add(Me.GCSponsonCard)
Me.tabSponsorShip.Controls.Add(Me.grpCustomersPoint)
Me.tabSponsorShip.Controls.Add(Me.GCGift)
Me.tabSponsorShip.Controls.Add(Me.GCSponsorShip)
Me.tabSponsorShip.Name = "tabSponsorShip"
Me.tabSponsorShip.Size = New System.Drawing.Size(1505, 905)
Me.tabSponsorShip.Text = "Sponsorship"
'
'GCCodeLinked
'
Me.GCCodeLinked.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCCodeLinked.Controls.Add(Me.GridCodeLinked)
Me.GCCodeLinked.Location = New System.Drawing.Point(1026, 22)
Me.GCCodeLinked.Name = "GCCodeLinked"
Me.GCCodeLinked.Size = New System.Drawing.Size(391, 437)
Me.GCCodeLinked.TabIndex = 16
Me.GCCodeLinked.Text = "Association Code"
'
'GridCodeLinked
'
Me.GridCodeLinked.EmbeddedNavigator.Name = ""
Me.GridCodeLinked.FormsUseDefaultLookAndFeel = false
Me.GridCodeLinked.Location = New System.Drawing.Point(11, 27)
Me.GridCodeLinked.MainView = Me.GridViewCodeLinked
Me.GridCodeLinked.Name = "GridCodeLinked"
Me.GridCodeLinked.Size = New System.Drawing.Size(374, 405)
Me.GridCodeLinked.TabIndex = 16
Me.GridCodeLinked.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCodeLinked})
'
'GridViewCodeLinked
'
Me.GridViewCodeLinked.GridControl = Me.GridCodeLinked
Me.GridViewCodeLinked.Name = "GridViewCodeLinked"
Me.GridViewCodeLinked.OptionsBehavior.Editable = false
Me.GridViewCodeLinked.OptionsView.ShowFooter = true
'
'GCSponsonCard
'
Me.GCSponsonCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCSponsonCard.Controls.Add(Me.BtnSaveSponsorCard)
Me.GCSponsonCard.Controls.Add(Me.lblCard5)
Me.GCSponsonCard.Controls.Add(Me.txtCard5)
Me.GCSponsonCard.Controls.Add(Me.lblCard4)
Me.GCSponsonCard.Controls.Add(Me.txtCard4)
Me.GCSponsonCard.Controls.Add(Me.lblCard3)
Me.GCSponsonCard.Controls.Add(Me.txtCard3)
Me.GCSponsonCard.Controls.Add(Me.lblCard2)
Me.GCSponsonCard.Controls.Add(Me.txtCard2)
Me.GCSponsonCard.Controls.Add(Me.lblCard1)
Me.GCSponsonCard.Controls.Add(Me.txtCard1)
Me.GCSponsonCard.Location = New System.Drawing.Point(769, 22)
Me.GCSponsonCard.Name = "GCSponsonCard"
Me.GCSponsonCard.Size = New System.Drawing.Size(250, 437)
Me.GCSponsonCard.TabIndex = 15
Me.GCSponsonCard.Text = "Sponsor Card"
'
'BtnSaveSponsorCard
'
Me.BtnSaveSponsorCard.Location = New System.Drawing.Point(60, 298)
Me.BtnSaveSponsorCard.Name = "BtnSaveSponsorCard"
Me.BtnSaveSponsorCard.Size = New System.Drawing.Size(116, 26)
Me.BtnSaveSponsorCard.TabIndex = 12
Me.BtnSaveSponsorCard.Text = "Save"
'
'lblCard5
'
Me.lblCard5.Location = New System.Drawing.Point(6, 247)
Me.lblCard5.Name = "lblCard5"
Me.lblCard5.Size = New System.Drawing.Size(38, 16)
Me.lblCard5.TabIndex = 11
Me.lblCard5.Text = "Card 5"
'
'txtCard5
'
Me.txtCard5.Location = New System.Drawing.Point(74, 243)
Me.txtCard5.Name = "txtCard5"
Me.txtCard5.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
Me.txtCard5.Size = New System.Drawing.Size(171, 22)
Me.txtCard5.TabIndex = 4
'
'lblCard4
'
Me.lblCard4.Location = New System.Drawing.Point(6, 193)
Me.lblCard4.Name = "lblCard4"
Me.lblCard4.Size = New System.Drawing.Size(38, 16)
Me.lblCard4.TabIndex = 9
Me.lblCard4.Text = "Card 4"
'
'txtCard4
'
Me.txtCard4.Location = New System.Drawing.Point(74, 189)
Me.txtCard4.Name = "txtCard4"
Me.txtCard4.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
Me.txtCard4.Size = New System.Drawing.Size(171, 22)
Me.txtCard4.TabIndex = 3
'
'lblCard3
'
Me.lblCard3.Location = New System.Drawing.Point(6, 134)
Me.lblCard3.Name = "lblCard3"
Me.lblCard3.Size = New System.Drawing.Size(38, 16)
Me.lblCard3.TabIndex = 7
Me.lblCard3.Text = "Card 3"
'
'txtCard3
'
Me.txtCard3.Location = New System.Drawing.Point(74, 130)
Me.txtCard3.Name = "txtCard3"
Me.txtCard3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
Me.txtCard3.Size = New System.Drawing.Size(171, 22)
Me.txtCard3.TabIndex = 2
'
'lblCard2
'
Me.lblCard2.Location = New System.Drawing.Point(6, 87)
Me.lblCard2.Name = "lblCard2"
Me.lblCard2.Size = New System.Drawing.Size(38, 16)
Me.lblCard2.TabIndex = 5
Me.lblCard2.Text = "Card 2"
'
'txtCard2
'
Me.txtCard2.Location = New System.Drawing.Point(74, 83)
Me.txtCard2.Name = "txtCard2"
Me.txtCard2.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
Me.txtCard2.Size = New System.Drawing.Size(171, 22)
Me.txtCard2.TabIndex = 1
'
'lblCard1
'
Me.lblCard1.Location = New System.Drawing.Point(6, 42)
Me.lblCard1.Name = "lblCard1"
Me.lblCard1.Size = New System.Drawing.Size(38, 16)
Me.lblCard1.TabIndex = 3
Me.lblCard1.Text = "Card 1"
'
'txtCard1
'
Me.txtCard1.EnterMoveNextControl = true
Me.txtCard1.Location = New System.Drawing.Point(74, 38)
Me.txtCard1.Name = "txtCard1"
Me.txtCard1.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
Me.txtCard1.Size = New System.Drawing.Size(171, 22)
Me.txtCard1.TabIndex = 0
'
'grpCustomersPoint
'
Me.grpCustomersPoint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.grpCustomersPoint.Controls.Add(Me.GridCustPointHistory)
Me.grpCustomersPoint.Location = New System.Drawing.Point(11, 771)
Me.grpCustomersPoint.Name = "grpCustomersPoint"
Me.grpCustomersPoint.Size = New System.Drawing.Size(1410, 244)
Me.grpCustomersPoint.TabIndex = 14
Me.grpCustomersPoint.Text = "Point History"
'
'GridCustPointHistory
'
Me.GridCustPointHistory.EmbeddedNavigator.Name = ""
Me.GridCustPointHistory.FormsUseDefaultLookAndFeel = false
Me.GridCustPointHistory.Location = New System.Drawing.Point(20, 51)
Me.GridCustPointHistory.MainView = Me.GridViewCustPointHistory
Me.GridCustPointHistory.Name = "GridCustPointHistory"
Me.GridCustPointHistory.Size = New System.Drawing.Size(1356, 183)
Me.GridCustPointHistory.TabIndex = 0
Me.GridCustPointHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCustPointHistory})
'
'GridViewCustPointHistory
'
Me.GridViewCustPointHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col2date_added, Me.customers_points_history, Me.customers_points_history_action_name, Me.customers_points_history_sub_action_name})
Me.GridViewCustPointHistory.CustomizationFormBounds = New System.Drawing.Rectangle(1022, 668, 208, 170)
Me.GridViewCustPointHistory.GridControl = Me.GridCustPointHistory
Me.GridViewCustPointHistory.Name = "GridViewCustPointHistory"
Me.GridViewCustPointHistory.OptionsCustomization.AllowColumnResizing = false
'
'col2date_added
'
Me.col2date_added.Caption = "date_added"
Me.col2date_added.FieldName = "date"
Me.col2date_added.Name = "col2date_added"
Me.col2date_added.OptionsColumn.AllowEdit = false
Me.col2date_added.OptionsColumn.FixedWidth = true
Me.col2date_added.OptionsColumn.ReadOnly = true
Me.col2date_added.Visible = true
Me.col2date_added.VisibleIndex = 0
'
'customers_points_history
'
Me.customers_points_history.Caption = "points"
Me.customers_points_history.FieldName = "points"
Me.customers_points_history.Name = "customers_points_history"
Me.customers_points_history.OptionsColumn.AllowEdit = false
Me.customers_points_history.OptionsColumn.FixedWidth = true
Me.customers_points_history.OptionsColumn.ReadOnly = true
Me.customers_points_history.Visible = true
Me.customers_points_history.VisibleIndex = 1
'
'customers_points_history_action_name
'
Me.customers_points_history_action_name.Caption = "action_name"
Me.customers_points_history_action_name.FieldName = "action_name"
Me.customers_points_history_action_name.Name = "customers_points_history_action_name"
Me.customers_points_history_action_name.OptionsColumn.AllowEdit = false
Me.customers_points_history_action_name.OptionsColumn.FixedWidth = true
Me.customers_points_history_action_name.OptionsColumn.ReadOnly = true
Me.customers_points_history_action_name.Visible = true
Me.customers_points_history_action_name.VisibleIndex = 2
'
'customers_points_history_sub_action_name
'
Me.customers_points_history_sub_action_name.Caption = "sub_action_name"
Me.customers_points_history_sub_action_name.FieldName = "sub_action_name"
Me.customers_points_history_sub_action_name.Name = "customers_points_history_sub_action_name"
Me.customers_points_history_sub_action_name.OptionsColumn.AllowEdit = false
Me.customers_points_history_sub_action_name.OptionsColumn.FixedWidth = true
Me.customers_points_history_sub_action_name.OptionsColumn.ReadOnly = true
Me.customers_points_history_sub_action_name.Visible = true
Me.customers_points_history_sub_action_name.VisibleIndex = 3
'
'GCGift
'
Me.GCGift.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCGift.Controls.Add(Me.GridGift)
Me.GCGift.Location = New System.Drawing.Point(11, 472)
Me.GCGift.Name = "GCGift"
Me.GCGift.Size = New System.Drawing.Size(1410, 292)
Me.GCGift.TabIndex = 13
Me.GCGift.Text = "Gift"
'
'GridGift
'
Me.GridGift.EmbeddedNavigator.Name = ""
Me.GridGift.FormsUseDefaultLookAndFeel = false
Me.GridGift.Location = New System.Drawing.Point(20, 51)
Me.GridGift.MainView = Me.GridViewGift
Me.GridGift.Name = "GridGift"
Me.GridGift.Size = New System.Drawing.Size(1356, 225)
Me.GridGift.TabIndex = 0
Me.GridGift.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewGift})
'
'GridViewGift
'
Me.GridViewGift.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.date_attribution, Me.gift_sent, Me.points_customers, Me.gift_sent_date, Me.products_id_gift, Me.gift_name_fr, Me.gift_name_nl, Me.gift_name_en, Me.points_gift})
Me.GridViewGift.CustomizationFormBounds = New System.Drawing.Rectangle(1022, 668, 208, 170)
Me.GridViewGift.GridControl = Me.GridGift
Me.GridViewGift.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewGift.Name = "GridViewGift"
Me.GridViewGift.OptionsCustomization.AllowColumnResizing = false
'
'date_attribution
'
Me.date_attribution.Caption = "date_attribution"
Me.date_attribution.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.date_attribution.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.date_attribution.FieldName = "date"
Me.date_attribution.Name = "date_attribution"
Me.date_attribution.OptionsColumn.AllowEdit = false
Me.date_attribution.OptionsColumn.FixedWidth = true
Me.date_attribution.OptionsColumn.ReadOnly = true
Me.date_attribution.Visible = true
Me.date_attribution.VisibleIndex = 0
'
'gift_sent
'
Me.gift_sent.Caption = "gift_sent"
Me.gift_sent.FieldName = "gift_sent"
Me.gift_sent.Name = "gift_sent"
Me.gift_sent.OptionsColumn.AllowEdit = false
Me.gift_sent.OptionsColumn.FixedWidth = true
Me.gift_sent.OptionsColumn.ReadOnly = true
Me.gift_sent.Visible = true
Me.gift_sent.VisibleIndex = 1
'
'points_customers
'
Me.points_customers.Caption = "points_customers"
Me.points_customers.FieldName = "customers_points"
Me.points_customers.Name = "points_customers"
Me.points_customers.OptionsColumn.AllowEdit = false
Me.points_customers.OptionsColumn.FixedWidth = true
Me.points_customers.OptionsColumn.ReadOnly = true
Me.points_customers.Visible = true
Me.points_customers.VisibleIndex = 2
'
'gift_sent_date
'
Me.gift_sent_date.Caption = "gift_sent_date"
Me.gift_sent_date.FieldName = "gift_sent_date"
Me.gift_sent_date.Name = "gift_sent_date"
Me.gift_sent_date.OptionsColumn.AllowEdit = false
Me.gift_sent_date.OptionsColumn.FixedWidth = true
Me.gift_sent_date.OptionsColumn.ReadOnly = true
Me.gift_sent_date.Visible = true
Me.gift_sent_date.VisibleIndex = 3
'
'products_id_gift
'
Me.products_id_gift.Caption = "products_id_gift"
Me.products_id_gift.FieldName = "products_id"
Me.products_id_gift.Name = "products_id_gift"
Me.products_id_gift.OptionsColumn.AllowEdit = false
Me.products_id_gift.OptionsColumn.FixedWidth = true
Me.products_id_gift.OptionsColumn.ReadOnly = true
Me.products_id_gift.Visible = true
Me.products_id_gift.VisibleIndex = 4
'
'gift_name_fr
'
Me.gift_name_fr.Caption = "gift_name_fr"
Me.gift_name_fr.FieldName = "gift_name_fr"
Me.gift_name_fr.Name = "gift_name_fr"
Me.gift_name_fr.OptionsColumn.AllowEdit = false
Me.gift_name_fr.OptionsColumn.FixedWidth = true
Me.gift_name_fr.OptionsColumn.ReadOnly = true
Me.gift_name_fr.Visible = true
Me.gift_name_fr.VisibleIndex = 5
'
'gift_name_nl
'
Me.gift_name_nl.Caption = "gift_name_nl"
Me.gift_name_nl.FieldName = "gift_name_nl"
Me.gift_name_nl.Name = "gift_name_nl"
Me.gift_name_nl.OptionsColumn.AllowEdit = false
Me.gift_name_nl.OptionsColumn.FixedWidth = true
Me.gift_name_nl.OptionsColumn.ReadOnly = true
Me.gift_name_nl.Visible = true
Me.gift_name_nl.VisibleIndex = 6
'
'gift_name_en
'
Me.gift_name_en.Caption = "gift_name_en"
Me.gift_name_en.FieldName = "gift_name_en"
Me.gift_name_en.Name = "gift_name_en"
Me.gift_name_en.OptionsColumn.AllowEdit = false
Me.gift_name_en.OptionsColumn.FixedWidth = true
Me.gift_name_en.OptionsColumn.ReadOnly = true
Me.gift_name_en.Visible = true
Me.gift_name_en.VisibleIndex = 7
'
'points_gift
'
Me.points_gift.Caption = "points_gift"
Me.points_gift.FieldName = "gift_points"
Me.points_gift.Name = "points_gift"
Me.points_gift.OptionsColumn.AllowEdit = false
Me.points_gift.OptionsColumn.FixedWidth = true
Me.points_gift.OptionsColumn.ReadOnly = true
Me.points_gift.Visible = true
Me.points_gift.VisibleIndex = 8
'
'GCSponsorShip
'
Me.GCSponsorShip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly
Me.GCSponsorShip.Controls.Add(Me.LabelControl33)
Me.GCSponsorShip.Controls.Add(Me.LabelControl25)
Me.GCSponsorShip.Controls.Add(Me.GridGodFather)
Me.GCSponsorShip.Controls.Add(Me.GridSon)
Me.GCSponsorShip.Location = New System.Drawing.Point(11, 22)
Me.GCSponsorShip.Name = "GCSponsorShip"
Me.GCSponsorShip.Size = New System.Drawing.Size(751, 443)
Me.GCSponsorShip.TabIndex = 12
Me.GCSponsorShip.Text = "Sponsorship"
'
'LabelControl33
'
Me.LabelControl33.Location = New System.Drawing.Point(6, 309)
Me.LabelControl33.Name = "LabelControl33"
Me.LabelControl33.Size = New System.Drawing.Size(59, 16)
Me.LabelControl33.TabIndex = 18
Me.LabelControl33.Text = "GodFather"
'
'LabelControl25
'
Me.LabelControl25.Location = New System.Drawing.Point(6, 27)
Me.LabelControl25.Name = "LabelControl25"
Me.LabelControl25.Size = New System.Drawing.Size(28, 16)
Me.LabelControl25.TabIndex = 17
Me.LabelControl25.Text = "Sons"
'
'GridGodFather
'
Me.GridGodFather.EmbeddedNavigator.Name = ""
Me.GridGodFather.FormsUseDefaultLookAndFeel = false
Me.GridGodFather.Location = New System.Drawing.Point(6, 322)
Me.GridGodFather.MainView = Me.GridviewGodFather
Me.GridGodFather.Name = "GridGodFather"
Me.GridGodFather.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryISponsorGodCustomers_id})
Me.GridGodFather.Size = New System.Drawing.Size(732, 121)
Me.GridGodFather.TabIndex = 12
Me.GridGodFather.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridviewGodFather})
'
'GridviewGodFather
'
Me.GridviewGodFather.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.coldate_used, Me.father_id, Me.colfather_abo_type, Me.col2customers_lastname, Me.col2customers_firstname})
Me.GridviewGodFather.CustomizationFormBounds = New System.Drawing.Rectangle(1382, 593, 218, 205)
Me.GridviewGodFather.GridControl = Me.GridGodFather
Me.GridviewGodFather.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridviewGodFather.Name = "GridviewGodFather"
'
'coldate_used
'
Me.coldate_used.Caption = "date_used"
Me.coldate_used.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.coldate_used.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.coldate_used.FieldName = "date"
Me.coldate_used.Name = "coldate_used"
Me.coldate_used.OptionsColumn.AllowEdit = false
Me.coldate_used.Visible = true
Me.coldate_used.VisibleIndex = 1
Me.coldate_used.Width = 277
'
'father_id
'
Me.father_id.Caption = "customers_id"
Me.father_id.ColumnEdit = Me.RepositoryISponsorGodCustomers_id
Me.father_id.FieldName = "father_id"
Me.father_id.Name = "father_id"
Me.father_id.OptionsColumn.AllowEdit = false
Me.father_id.Visible = true
Me.father_id.VisibleIndex = 0
Me.father_id.Width = 133
'
'RepositoryISponsorGodCustomers_id
'
Me.RepositoryISponsorGodCustomers_id.AutoHeight = false
Me.RepositoryISponsorGodCustomers_id.Name = "RepositoryISponsorGodCustomers_id"
'
'colfather_abo_type
'
Me.colfather_abo_type.Caption = "abo_type"
Me.colfather_abo_type.FieldName = "father_abo_type"
Me.colfather_abo_type.Name = "colfather_abo_type"
Me.colfather_abo_type.OptionsColumn.AllowEdit = false
Me.colfather_abo_type.Visible = true
Me.colfather_abo_type.VisibleIndex = 4
Me.colfather_abo_type.Width = 284
'
'col2customers_lastname
'
Me.col2customers_lastname.Caption = "customers_lastname"
Me.col2customers_lastname.FieldName = "customers_lastname"
Me.col2customers_lastname.Name = "col2customers_lastname"
Me.col2customers_lastname.OptionsColumn.AllowEdit = false
Me.col2customers_lastname.Visible = true
Me.col2customers_lastname.VisibleIndex = 2
Me.col2customers_lastname.Width = 277
'
'col2customers_firstname
'
Me.col2customers_firstname.Caption = "customers_firstname"
Me.col2customers_firstname.FieldName = "customers_firstname"
Me.col2customers_firstname.Name = "col2customers_firstname"
Me.col2customers_firstname.OptionsColumn.AllowEdit = false
Me.col2customers_firstname.Visible = true
Me.col2customers_firstname.VisibleIndex = 3
Me.col2customers_firstname.Width = 277
'
'tabAboprocess
'
Me.tabAboprocess.Controls.Add(Me.gridAboprocess)
Me.tabAboprocess.Name = "tabAboprocess"
Me.tabAboprocess.Size = New System.Drawing.Size(1505, 905)
Me.tabAboprocess.Text = "aboprocess"
'
'gridAboprocess
'
Me.gridAboprocess.Dock = System.Windows.Forms.DockStyle.Fill
Me.gridAboprocess.EmbeddedNavigator.Name = ""
Me.gridAboprocess.FormsUseDefaultLookAndFeel = false
Me.gridAboprocess.Location = New System.Drawing.Point(0, 0)
Me.gridAboprocess.MainView = Me.GridViewAboprocess
Me.gridAboprocess.Name = "gridAboprocess"
Me.gridAboprocess.Size = New System.Drawing.Size(1505, 905)
Me.gridAboprocess.TabIndex = 1
Me.gridAboprocess.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewAboprocess})
'
'GridViewAboprocess
'
Me.GridViewAboprocess.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProducts_type, Me.coldateStart, Me.colStatus, coldvd_to_send, Me.coldvdHigh, Me.coldvdmedium, Me.coldvdlow, Me.colDvd_Abo, Me.colDvd_Compensation, Me.colDvd_home, Me.colCredit, Me.colcustaborank, Me.colmsgerror, Me.colDvdFind, Me.colWishlist})
Me.GridViewAboprocess.GridControl = Me.gridAboprocess
Me.GridViewAboprocess.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewAboprocess.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
Me.GridViewAboprocess.Name = "GridViewAboprocess"
Me.GridViewAboprocess.OptionsView.ColumnAutoWidth = false
Me.GridViewAboprocess.OptionsView.ShowFooter = true
'
'colProducts_type
'
Me.colProducts_type.Caption = "type dvd"
Me.colProducts_type.FieldName = "products_type"
Me.colProducts_type.Name = "colProducts_type"
Me.colProducts_type.Visible = true
Me.colProducts_type.VisibleIndex = 0
'
'coldateStart
'
Me.coldateStart.Caption = "date_start"
Me.coldateStart.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.coldateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.coldateStart.FieldName = "date_start"
Me.coldateStart.Name = "coldateStart"
Me.coldateStart.OptionsColumn.AllowEdit = false
Me.coldateStart.OptionsColumn.FixedWidth = true
Me.coldateStart.OptionsColumn.ReadOnly = true
Me.coldateStart.Visible = true
Me.coldateStart.VisibleIndex = 1
'
'colStatus
'
Me.colStatus.Caption = "status"
Me.colStatus.FieldName = "label"
Me.colStatus.Name = "colStatus"
Me.colStatus.OptionsColumn.AllowEdit = false
Me.colStatus.OptionsColumn.FixedWidth = true
Me.colStatus.OptionsColumn.ReadOnly = true
Me.colStatus.Visible = true
Me.colStatus.VisibleIndex = 2
'
'coldvdHigh
'
Me.coldvdHigh.Caption = "dvd_highsent"
Me.coldvdHigh.FieldName = "dvd_highsent"
Me.coldvdHigh.Name = "coldvdHigh"
Me.coldvdHigh.OptionsColumn.AllowEdit = false
Me.coldvdHigh.OptionsColumn.FixedWidth = true
Me.coldvdHigh.OptionsColumn.ReadOnly = true
Me.coldvdHigh.Visible = true
Me.coldvdHigh.VisibleIndex = 4
Me.coldvdHigh.Width = 104
'
'coldvdmedium
'
Me.coldvdmedium.Caption = "dvd_mediumsent"
Me.coldvdmedium.FieldName = "dvd_mediumsent"
Me.coldvdmedium.Name = "coldvdmedium"
Me.coldvdmedium.OptionsColumn.AllowEdit = false
Me.coldvdmedium.OptionsColumn.FixedWidth = true
Me.coldvdmedium.OptionsColumn.ReadOnly = true
Me.coldvdmedium.Visible = true
Me.coldvdmedium.VisibleIndex = 5
Me.coldvdmedium.Width = 107
'
'coldvdlow
'
Me.coldvdlow.Caption = "dvd_lowsent"
Me.coldvdlow.FieldName = "dvd_lowsent"
Me.coldvdlow.Name = "coldvdlow"
Me.coldvdlow.OptionsColumn.AllowEdit = false
Me.coldvdlow.OptionsColumn.FixedWidth = true
Me.coldvdlow.OptionsColumn.ReadOnly = true
Me.coldvdlow.Visible = true
Me.coldvdlow.VisibleIndex = 6
Me.coldvdlow.Width = 89
'
'colDvd_Abo
'
Me.colDvd_Abo.Caption = "dvd_abo"
Me.colDvd_Abo.FieldName = "dvd_abo"
Me.colDvd_Abo.Name = "colDvd_Abo"
Me.colDvd_Abo.OptionsColumn.AllowEdit = false
Me.colDvd_Abo.OptionsColumn.FixedWidth = true
Me.colDvd_Abo.OptionsColumn.ReadOnly = true
Me.colDvd_Abo.Visible = true
Me.colDvd_Abo.VisibleIndex = 7
Me.colDvd_Abo.Width = 104
'
'colDvd_Compensation
'
Me.colDvd_Compensation.Caption = "dvd_compensation"
Me.colDvd_Compensation.FieldName = "dvd_compensation"
Me.colDvd_Compensation.Name = "colDvd_Compensation"
Me.colDvd_Compensation.OptionsColumn.AllowEdit = false
Me.colDvd_Compensation.OptionsColumn.FixedWidth = true
Me.colDvd_Compensation.OptionsColumn.ReadOnly = true
Me.colDvd_Compensation.Visible = true
Me.colDvd_Compensation.VisibleIndex = 8
Me.colDvd_Compensation.Width = 130
'
'colDvd_home
'
Me.colDvd_home.Caption = "dvd_home"
Me.colDvd_home.FieldName = "dvd_home"
Me.colDvd_home.Name = "colDvd_home"
Me.colDvd_home.OptionsColumn.AllowEdit = false
Me.colDvd_home.OptionsColumn.FixedWidth = true
Me.colDvd_home.OptionsColumn.ReadOnly = true
Me.colDvd_home.Visible = true
Me.colDvd_home.VisibleIndex = 9
Me.colDvd_home.Width = 97
'
'colCredit
'
Me.colCredit.Caption = " credit"
Me.colCredit.FieldName = " credit"
Me.colCredit.Name = "colCredit"
Me.colCredit.OptionsColumn.AllowEdit = false
Me.colCredit.OptionsColumn.FixedWidth = true
Me.colCredit.OptionsColumn.ReadOnly = true
Me.colCredit.UnboundType = DevExpress.Data.UnboundColumnType.[Integer]
'
'colcustaborank
'
Me.colcustaborank.Caption = "customer_abo_rank"
Me.colcustaborank.FieldName = "customer_abo_rank"
Me.colcustaborank.Name = "colcustaborank"
Me.colcustaborank.OptionsColumn.AllowEdit = false
Me.colcustaborank.OptionsColumn.FixedWidth = true
Me.colcustaborank.OptionsColumn.ReadOnly = true
Me.colcustaborank.Width = 123
'
'colmsgerror
'
Me.colmsgerror.Caption = "msgerror"
Me.colmsgerror.FieldName = "msgerror"
Me.colmsgerror.Name = "colmsgerror"
Me.colmsgerror.OptionsColumn.AllowEdit = false
Me.colmsgerror.OptionsColumn.FixedWidth = true
Me.colmsgerror.OptionsColumn.ReadOnly = true
Me.colmsgerror.Visible = true
Me.colmsgerror.VisibleIndex = 10
'
'colDvdFind
'
Me.colDvdFind.Caption = "DvdFound"
Me.colDvdFind.FieldName = "nbdvdfind"
Me.colDvdFind.Name = "colDvdFind"
Me.colDvdFind.OptionsColumn.AllowEdit = false
Me.colDvdFind.OptionsColumn.FixedWidth = true
Me.colDvdFind.OptionsColumn.ReadOnly = true
Me.colDvdFind.Visible = true
Me.colDvdFind.VisibleIndex = 11
Me.colDvdFind.Width = 94
'
'colWishlist
'
Me.colWishlist.Caption = "DvdWishlist"
Me.colWishlist.FieldName = "nbwishlist"
Me.colWishlist.Name = "colWishlist"
Me.colWishlist.OptionsColumn.AllowEdit = false
Me.colWishlist.OptionsColumn.FixedWidth = true
Me.colWishlist.OptionsColumn.ReadOnly = true
Me.colWishlist.Visible = true
Me.colWishlist.VisibleIndex = 12
Me.colWishlist.Width = 83
'
'tabPurchase
'
Me.tabPurchase.AutoScroll = true
Me.tabPurchase.Controls.Add(Me.GridShoppingOrders)
Me.tabPurchase.Name = "tabPurchase"
Me.tabPurchase.Size = New System.Drawing.Size(1505, 905)
Me.tabPurchase.Text = "Purchase"
'
'GridShoppingOrders
'
Me.GridShoppingOrders.EmbeddedNavigator.Name = ""
Me.GridShoppingOrders.FormsUseDefaultLookAndFeel = false
Me.GridShoppingOrders.Location = New System.Drawing.Point(0, 3)
Me.GridShoppingOrders.MainView = Me.GridViewShoppingOrders
Me.GridShoppingOrders.Name = "GridShoppingOrders"
Me.GridShoppingOrders.Size = New System.Drawing.Size(1680, 1055)
Me.GridShoppingOrders.TabIndex = 0
Me.GridShoppingOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewShoppingOrders})
'
'GridViewShoppingOrders
'
Me.GridViewShoppingOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.shopping_orders_id, Me.customers_id, Me.date_orders, Me.shopping_products_id, Me.quantity, Me.dvd_id, Me.price, Me.shopping_discount_code_id, Me.products_type, Me.products_state, Me.products_name, Me.products_description, Me.products_bonus, Me.products_url, Me.products_awards, Me.products_viewed, Me.products_image_big, Me.status_name, Me.shopping_discount_value})
Me.GridViewShoppingOrders.GridControl = Me.GridShoppingOrders
Me.GridViewShoppingOrders.GroupCount = 1
Me.GridViewShoppingOrders.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewShoppingOrders.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "products_type", Nothing, "")})
Me.GridViewShoppingOrders.Name = "GridViewShoppingOrders"
Me.GridViewShoppingOrders.OptionsView.ShowFooter = true
Me.GridViewShoppingOrders.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.products_type, DevExpress.Data.ColumnSortOrder.Ascending)})
'
'shopping_orders_id
'
Me.shopping_orders_id.Caption = "shopping_orders_id"
Me.shopping_orders_id.FieldName = "shopping_orders_id"
Me.shopping_orders_id.Name = "shopping_orders_id"
Me.shopping_orders_id.OptionsColumn.AllowEdit = false
Me.shopping_orders_id.OptionsColumn.FixedWidth = true
'
'customers_id
'
Me.customers_id.Caption = "customers_id"
Me.customers_id.FieldName = "customers_id"
Me.customers_id.Name = "customers_id"
Me.customers_id.OptionsColumn.AllowEdit = false
'
'date_orders
'
Me.date_orders.Caption = "date_orders"
Me.date_orders.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.date_orders.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.date_orders.FieldName = "date"
Me.date_orders.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
Me.date_orders.Name = "date_orders"
Me.date_orders.OptionsColumn.AllowEdit = false
Me.date_orders.OptionsColumn.FixedWidth = true
Me.date_orders.OptionsColumn.ReadOnly = true
Me.date_orders.Visible = true
Me.date_orders.VisibleIndex = 0
Me.date_orders.Width = 96
'
'shopping_products_id
'
Me.shopping_products_id.Caption = "products_id"
Me.shopping_products_id.FieldName = "products_id"
Me.shopping_products_id.Name = "shopping_products_id"
Me.shopping_products_id.OptionsColumn.AllowEdit = false
Me.shopping_products_id.OptionsColumn.FixedWidth = true
Me.shopping_products_id.OptionsColumn.ReadOnly = true
Me.shopping_products_id.Visible = true
Me.shopping_products_id.VisibleIndex = 1
'
'quantity
'
Me.quantity.Caption = "quantity"
Me.quantity.FieldName = "quantity"
Me.quantity.Name = "quantity"
Me.quantity.OptionsColumn.AllowEdit = false
Me.quantity.OptionsColumn.FixedWidth = true
Me.quantity.OptionsColumn.ReadOnly = true
Me.quantity.Visible = true
Me.quantity.VisibleIndex = 2
Me.quantity.Width = 77
'
'dvd_id
'
Me.dvd_id.Caption = "dvd_id"
Me.dvd_id.FieldName = "dvd_id"
Me.dvd_id.Name = "dvd_id"
Me.dvd_id.OptionsColumn.AllowEdit = false
Me.dvd_id.OptionsColumn.ReadOnly = true
Me.dvd_id.Width = 144
'
'price
'
Me.price.Caption = "price"
Me.price.FieldName = "price"
Me.price.Name = "price"
Me.price.OptionsColumn.AllowEdit = false
Me.price.OptionsColumn.FixedWidth = true
Me.price.OptionsColumn.ReadOnly = true
Me.price.Visible = true
Me.price.VisibleIndex = 3
Me.price.Width = 71
'
'shopping_discount_code_id
'
Me.shopping_discount_code_id.Caption = "shopping_discount_code"
Me.shopping_discount_code_id.FieldName = "discount_code"
Me.shopping_discount_code_id.Name = "shopping_discount_code_id"
Me.shopping_discount_code_id.OptionsColumn.AllowEdit = false
Me.shopping_discount_code_id.OptionsColumn.FixedWidth = true
Me.shopping_discount_code_id.OptionsColumn.ReadOnly = true
Me.shopping_discount_code_id.Visible = true
Me.shopping_discount_code_id.VisibleIndex = 7
Me.shopping_discount_code_id.Width = 184
'
'products_type
'
Me.products_type.Caption = "products_type"
Me.products_type.FieldName = "products_type"
Me.products_type.Name = "products_type"
Me.products_type.OptionsColumn.AllowEdit = false
Me.products_type.OptionsColumn.FixedWidth = true
Me.products_type.OptionsColumn.ReadOnly = true
Me.products_type.Width = 135
'
'products_state
'
Me.products_state.Caption = "products_state"
Me.products_state.FieldName = "products_state"
Me.products_state.Name = "products_state"
Me.products_state.OptionsColumn.AllowEdit = false
Me.products_state.OptionsColumn.FixedWidth = true
Me.products_state.OptionsColumn.ReadOnly = true
Me.products_state.Visible = true
Me.products_state.VisibleIndex = 5
Me.products_state.Width = 125
'
'products_name
'
Me.products_name.Caption = "products_name"
Me.products_name.FieldName = "products_name"
Me.products_name.Name = "products_name"
Me.products_name.OptionsColumn.AllowEdit = false
Me.products_name.OptionsColumn.FixedWidth = true
Me.products_name.OptionsColumn.ReadOnly = true
Me.products_name.Visible = true
Me.products_name.VisibleIndex = 6
Me.products_name.Width = 336
'
'products_description
'
Me.products_description.Caption = "products_description"
Me.products_description.FieldName = "products_description"
Me.products_description.Name = "products_description"
Me.products_description.OptionsColumn.AllowEdit = false
'
'products_bonus
'
Me.products_bonus.Caption = "products_bonus"
Me.products_bonus.FieldName = "products_bonus"
Me.products_bonus.Name = "products_bonus"
Me.products_bonus.OptionsColumn.AllowEdit = false
'
'products_url
'
Me.products_url.Caption = "products_url"
Me.products_url.FieldName = "products_url"
Me.products_url.Name = "products_url"
Me.products_url.OptionsColumn.AllowEdit = false
'
'products_awards
'
Me.products_awards.Caption = "products_awards"
Me.products_awards.FieldName = "products_awards"
Me.products_awards.Name = "products_awards"
Me.products_awards.OptionsColumn.AllowEdit = false
'
'products_viewed
'
Me.products_viewed.Caption = "products_viewed"
Me.products_viewed.FieldName = "products_viewed"
Me.products_viewed.Name = "products_viewed"
Me.products_viewed.OptionsColumn.AllowEdit = false
'
'products_image_big
'
Me.products_image_big.Caption = "products_image_big"
Me.products_image_big.FieldName = "products_image_big"
Me.products_image_big.Name = "products_image_big"
Me.products_image_big.OptionsColumn.AllowEdit = false
'
'status_name
'
Me.status_name.Caption = "status_name"
Me.status_name.FieldName = "status_name"
Me.status_name.Name = "status_name"
Me.status_name.OptionsColumn.AllowEdit = false
Me.status_name.OptionsColumn.FixedWidth = true
Me.status_name.OptionsColumn.ReadOnly = true
Me.status_name.Visible = true
Me.status_name.VisibleIndex = 4
Me.status_name.Width = 102
'
'shopping_discount_value
'
Me.shopping_discount_value.Caption = "shopping_discount_value"
Me.shopping_discount_value.FieldName = "discount_text_fr"
Me.shopping_discount_value.Name = "shopping_discount_value"
Me.shopping_discount_value.OptionsColumn.AllowEdit = false
Me.shopping_discount_value.OptionsColumn.FixedWidth = true
Me.shopping_discount_value.OptionsColumn.ReadOnly = true
Me.shopping_discount_value.Visible = true
Me.shopping_discount_value.VisibleIndex = 8
Me.shopping_discount_value.Width = 662
'
'tabCreditHist
'
Me.tabCreditHist.Controls.Add(Me.GridCreditHistory)
Me.tabCreditHist.Name = "tabCreditHist"
Me.tabCreditHist.Size = New System.Drawing.Size(1505, 905)
Me.tabCreditHist.Text = "Credit history"
'
'GridCreditHistory
'
Me.GridCreditHistory.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridCreditHistory.EmbeddedNavigator.Name = ""
Me.GridCreditHistory.FormsUseDefaultLookAndFeel = false
Me.GridCreditHistory.Location = New System.Drawing.Point(0, 0)
Me.GridCreditHistory.MainView = Me.GridViewCreditHistory
Me.GridCreditHistory.Name = "GridCreditHistory"
Me.GridCreditHistory.Size = New System.Drawing.Size(1505, 905)
Me.GridCreditHistory.TabIndex = 1
Me.GridCreditHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCreditHistory})
'
'GridViewCreditHistory
'
Me.GridViewCreditHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id, Me.credit, Me.quantity_paid, Me.date_added, Me.action_name, Me.quantity_free, Me.credit_free, Me.Col3Orders_id, Me.ColTotal, Me.ColTotalPaid, Me.colTotalFree})
Me.GridViewCreditHistory.CustomizationFormBounds = New System.Drawing.Rectangle(1384, 626, 216, 178)
Me.GridViewCreditHistory.GridControl = Me.GridCreditHistory
Me.GridViewCreditHistory.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewCreditHistory.Name = "GridViewCreditHistory"
Me.GridViewCreditHistory.OptionsView.ColumnAutoWidth = false
Me.GridViewCreditHistory.OptionsView.ShowFooter = true
'
'id
'
Me.id.Caption = "id"
Me.id.FieldName = "id"
Me.id.Name = "id"
Me.id.OptionsColumn.AllowEdit = false
Me.id.OptionsColumn.FixedWidth = true
Me.id.OptionsColumn.ReadOnly = true
'
'credit
'
Me.credit.Caption = "credit Paid"
Me.credit.FieldName = "credit"
Me.credit.Name = "credit"
Me.credit.OptionsColumn.AllowEdit = false
Me.credit.OptionsColumn.FixedWidth = true
Me.credit.OptionsColumn.ReadOnly = true
Me.credit.Width = 76
'
'quantity_paid
'
Me.quantity_paid.Caption = "quantity_paid"
Me.quantity_paid.FieldName = "quantity_paid"
Me.quantity_paid.Name = "quantity_paid"
Me.quantity_paid.OptionsColumn.AllowEdit = false
Me.quantity_paid.OptionsColumn.FixedWidth = true
Me.quantity_paid.OptionsColumn.ReadOnly = true
Me.quantity_paid.Visible = true
Me.quantity_paid.VisibleIndex = 4
Me.quantity_paid.Width = 90
'
'date_added
'
Me.date_added.Caption = "date_added"
Me.date_added.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.date_added.FieldName = "date_added"
Me.date_added.Name = "date_added"
Me.date_added.OptionsColumn.AllowEdit = false
Me.date_added.OptionsColumn.FixedWidth = true
Me.date_added.OptionsColumn.ReadOnly = true
Me.date_added.Visible = true
Me.date_added.VisibleIndex = 0
Me.date_added.Width = 135
'
'action_name
'
Me.action_name.Caption = "action_name"
Me.action_name.FieldName = "action_name"
Me.action_name.Name = "action_name"
Me.action_name.OptionsColumn.AllowEdit = false
Me.action_name.OptionsColumn.FixedWidth = true
Me.action_name.OptionsColumn.ReadOnly = true
Me.action_name.Visible = true
Me.action_name.VisibleIndex = 1
Me.action_name.Width = 131
'
'quantity_free
'
Me.quantity_free.Caption = "quantity_free"
Me.quantity_free.FieldName = "quantity_free"
Me.quantity_free.Name = "quantity_free"
Me.quantity_free.OptionsColumn.AllowEdit = false
Me.quantity_free.OptionsColumn.FixedWidth = true
Me.quantity_free.OptionsColumn.ReadOnly = true
Me.quantity_free.Visible = true
Me.quantity_free.VisibleIndex = 6
Me.quantity_free.Width = 99
'
'credit_free
'
Me.credit_free.Caption = "credit_free"
Me.credit_free.FieldName = "credit_free"
Me.credit_free.Name = "credit_free"
Me.credit_free.OptionsColumn.AllowEdit = false
Me.credit_free.OptionsColumn.FixedWidth = true
Me.credit_free.OptionsColumn.ReadOnly = true
Me.credit_free.Width = 96
'
'ColTotal
'
Me.ColTotal.Caption = "Total"
Me.ColTotal.FieldName = "total"
Me.ColTotal.Name = "ColTotal"
Me.ColTotal.Visible = true
Me.ColTotal.VisibleIndex = 2
'
'ColTotalPaid
'
Me.ColTotalPaid.Caption = "Total Paid"
Me.ColTotalPaid.FieldName = "total_paid"
Me.ColTotalPaid.Name = "ColTotalPaid"
Me.ColTotalPaid.Visible = true
Me.ColTotalPaid.VisibleIndex = 3
'
'colTotalFree
'
Me.colTotalFree.Caption = "Total Free"
Me.colTotalFree.FieldName = "total_free"
Me.colTotalFree.Name = "colTotalFree"
Me.colTotalFree.Visible = true
Me.colTotalFree.VisibleIndex = 5
'
'tabCompensation
'
Me.tabCompensation.Controls.Add(Me.GridCompensation)
Me.tabCompensation.Name = "tabCompensation"
Me.tabCompensation.PageEnabled = false
Me.tabCompensation.PageVisible = false
Me.tabCompensation.Size = New System.Drawing.Size(1505, 905)
Me.tabCompensation.Text = "Compensation"
'
'GridCompensation
'
Me.GridCompensation.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridCompensation.EmbeddedNavigator.Name = ""
Me.GridCompensation.FormsUseDefaultLookAndFeel = false
Me.GridCompensation.Location = New System.Drawing.Point(0, 0)
Me.GridCompensation.MainView = Me.GridViewCompensation
Me.GridCompensation.Name = "GridCompensation"
Me.GridCompensation.Size = New System.Drawing.Size(1505, 905)
Me.GridCompensation.TabIndex = 0
Me.GridCompensation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCompensation})
'
'GridViewCompensation
'
Me.GridViewCompensation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.compensation_date_given, Me.compensation_date_setback, Me.compensation_comment, Me.orders_id, Me.orders_id_given, Me.products_name_given, Me.colCompProducts_name})
Me.GridViewCompensation.GridControl = Me.GridCompensation
Me.GridViewCompensation.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewCompensation.Name = "GridViewCompensation"
Me.GridViewCompensation.OptionsView.ColumnAutoWidth = false
'
'compensation_date_given
'
Me.compensation_date_given.Caption = "compensation_date_given"
Me.compensation_date_given.FieldName = "compensation_date_given"
Me.compensation_date_given.Name = "compensation_date_given"
Me.compensation_date_given.OptionsColumn.AllowEdit = false
Me.compensation_date_given.OptionsColumn.FixedWidth = true
Me.compensation_date_given.OptionsColumn.ReadOnly = true
Me.compensation_date_given.Visible = true
Me.compensation_date_given.VisibleIndex = 3
Me.compensation_date_given.Width = 150
'
'compensation_date_setback
'
Me.compensation_date_setback.Caption = "compensation_date_setback"
Me.compensation_date_setback.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.compensation_date_setback.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.compensation_date_setback.FieldName = "compensation_date_setback"
Me.compensation_date_setback.Name = "compensation_date_setback"
Me.compensation_date_setback.OptionsColumn.AllowEdit = false
Me.compensation_date_setback.OptionsColumn.FixedWidth = true
Me.compensation_date_setback.OptionsColumn.ReadOnly = true
Me.compensation_date_setback.Visible = true
Me.compensation_date_setback.VisibleIndex = 0
Me.compensation_date_setback.Width = 150
'
'compensation_comment
'
Me.compensation_comment.Caption = "compensation_comment"
Me.compensation_comment.FieldName = "compensation_comment"
Me.compensation_comment.Name = "compensation_comment"
Me.compensation_comment.OptionsColumn.AllowEdit = false
Me.compensation_comment.OptionsColumn.FixedWidth = true
Me.compensation_comment.OptionsColumn.ReadOnly = true
Me.compensation_comment.Visible = true
Me.compensation_comment.VisibleIndex = 4
Me.compensation_comment.Width = 150
'
'orders_id
'
Me.orders_id.Caption = "orders_id"
Me.orders_id.FieldName = "orders_id"
Me.orders_id.Name = "orders_id"
Me.orders_id.OptionsColumn.AllowEdit = false
Me.orders_id.OptionsColumn.FixedWidth = true
Me.orders_id.OptionsColumn.ReadOnly = true
Me.orders_id.Visible = true
Me.orders_id.VisibleIndex = 5
Me.orders_id.Width = 150
'
'orders_id_given
'
Me.orders_id_given.Caption = "orders_id_given"
Me.orders_id_given.FieldName = "orders_id_given"
Me.orders_id_given.Name = "orders_id_given"
Me.orders_id_given.OptionsColumn.AllowEdit = false
Me.orders_id_given.OptionsColumn.FixedWidth = true
Me.orders_id_given.OptionsColumn.ReadOnly = true
Me.orders_id_given.Visible = true
Me.orders_id_given.VisibleIndex = 1
Me.orders_id_given.Width = 110
'
'products_name_given
'
Me.products_name_given.Caption = "products_name_given"
Me.products_name_given.FieldName = "products_name_given"
Me.products_name_given.Name = "products_name_given"
Me.products_name_given.OptionsColumn.AllowEdit = false
Me.products_name_given.OptionsColumn.FixedWidth = true
Me.products_name_given.OptionsColumn.ReadOnly = true
Me.products_name_given.Visible = true
Me.products_name_given.VisibleIndex = 2
Me.products_name_given.Width = 300
'
'colCompProducts_name
'
Me.colCompProducts_name.Caption = "products_name"
Me.colCompProducts_name.FieldName = "products_name"
Me.colCompProducts_name.Name = "colCompProducts_name"
Me.colCompProducts_name.OptionsColumn.AllowEdit = false
Me.colCompProducts_name.OptionsColumn.FixedWidth = true
Me.colCompProducts_name.OptionsColumn.ReadOnly = true
Me.colCompProducts_name.Visible = true
Me.colCompProducts_name.VisibleIndex = 6
Me.colCompProducts_name.Width = 300
'
'tabProductsRating
'
Me.tabProductsRating.Controls.Add(Me.GridProductsRating)
Me.tabProductsRating.Name = "tabProductsRating"
Me.tabProductsRating.Size = New System.Drawing.Size(1505, 905)
Me.tabProductsRating.Text = "Products rating"
'
'GridProductsRating
'
Me.GridProductsRating.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridProductsRating.EmbeddedNavigator.Name = ""
Me.GridProductsRating.FormsUseDefaultLookAndFeel = false
Me.GridProductsRating.Location = New System.Drawing.Point(0, 0)
Me.GridProductsRating.MainView = Me.GridViewProductsRating
Me.GridProductsRating.Name = "GridProductsRating"
Me.GridProductsRating.Size = New System.Drawing.Size(1505, 905)
Me.GridProductsRating.TabIndex = 2
Me.GridProductsRating.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewProductsRating})
'
'GridViewProductsRating
'
Me.GridViewProductsRating.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.products, Me.products_rating, Me.products_rating_date, Me.rating_type, Me.colRatingProducts_name})
Me.GridViewProductsRating.GridControl = Me.GridProductsRating
Me.GridViewProductsRating.GroupCount = 1
Me.GridViewProductsRating.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewProductsRating.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "products_rating", Nothing, "")})
Me.GridViewProductsRating.Name = "GridViewProductsRating"
Me.GridViewProductsRating.OptionsView.ColumnAutoWidth = false
Me.GridViewProductsRating.OptionsView.ShowFooter = true
Me.GridViewProductsRating.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.rating_type, DevExpress.Data.ColumnSortOrder.Ascending)})
'
'products
'
Me.products.Caption = "products_id"
Me.products.FieldName = "products_id"
Me.products.Name = "products"
Me.products.OptionsColumn.AllowEdit = false
Me.products.OptionsColumn.ReadOnly = true
Me.products.Visible = true
Me.products.VisibleIndex = 0
Me.products.Width = 92
'
'products_rating
'
Me.products_rating.Caption = "products_rating"
Me.products_rating.FieldName = "products_rating"
Me.products_rating.Name = "products_rating"
Me.products_rating.OptionsColumn.AllowEdit = false
Me.products_rating.OptionsColumn.ReadOnly = true
Me.products_rating.Visible = true
Me.products_rating.VisibleIndex = 2
Me.products_rating.Width = 129
'
'products_rating_date
'
Me.products_rating_date.Caption = "products_rating_date"
Me.products_rating_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.products_rating_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.products_rating_date.FieldName = "products_rating_date"
Me.products_rating_date.Name = "products_rating_date"
Me.products_rating_date.OptionsColumn.AllowEdit = false
Me.products_rating_date.OptionsColumn.ReadOnly = true
Me.products_rating_date.Visible = true
Me.products_rating_date.VisibleIndex = 1
Me.products_rating_date.Width = 162
'
'rating_type
'
Me.rating_type.Caption = "rating_type"
Me.rating_type.FieldName = "rating_type"
Me.rating_type.Name = "rating_type"
Me.rating_type.OptionsColumn.AllowEdit = false
Me.rating_type.OptionsColumn.ReadOnly = true
Me.rating_type.Visible = true
Me.rating_type.VisibleIndex = 3
Me.rating_type.Width = 196
'
'colRatingProducts_name
'
Me.colRatingProducts_name.Caption = "products_name"
Me.colRatingProducts_name.FieldName = "products_name"
Me.colRatingProducts_name.Name = "colRatingProducts_name"
Me.colRatingProducts_name.OptionsColumn.AllowEdit = false
Me.colRatingProducts_name.OptionsColumn.ReadOnly = true
Me.colRatingProducts_name.Visible = true
Me.colRatingProducts_name.VisibleIndex = 3
Me.colRatingProducts_name.Width = 249
'
'tabSuspendedHistory
'
Me.tabSuspendedHistory.Controls.Add(Me.GridSuspendedHistory)
Me.tabSuspendedHistory.Name = "tabSuspendedHistory"
Me.tabSuspendedHistory.Size = New System.Drawing.Size(1505, 905)
Me.tabSuspendedHistory.Text = "Suspended History"
'
'GridSuspendedHistory
'
Me.GridSuspendedHistory.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridSuspendedHistory.EmbeddedNavigator.Name = ""
Me.GridSuspendedHistory.FormsUseDefaultLookAndFeel = false
Me.GridSuspendedHistory.Location = New System.Drawing.Point(0, 0)
Me.GridSuspendedHistory.MainView = Me.GridViewSuspendedHistory
Me.GridSuspendedHistory.Name = "GridSuspendedHistory"
Me.GridSuspendedHistory.Size = New System.Drawing.Size(1505, 905)
Me.GridSuspendedHistory.TabIndex = 1
Me.GridSuspendedHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewSuspendedHistory})
'
'GridViewSuspendedHistory
'
Me.GridViewSuspendedHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.suspended_history_date, Me.suspended_history_date_end, Me.abosuspended_history_type})
Me.GridViewSuspendedHistory.GridControl = Me.GridSuspendedHistory
Me.GridViewSuspendedHistory.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridViewSuspendedHistory.Name = "GridViewSuspendedHistory"
Me.GridViewSuspendedHistory.OptionsView.ColumnAutoWidth = false
Me.GridViewSuspendedHistory.OptionsView.ShowFooter = true
'
'suspended_history_date
'
Me.suspended_history_date.Caption = "date_added"
Me.suspended_history_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.suspended_history_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.suspended_history_date.FieldName = "date_added"
Me.suspended_history_date.Name = "suspended_history_date"
Me.suspended_history_date.OptionsColumn.AllowEdit = false
Me.suspended_history_date.OptionsColumn.FixedWidth = true
Me.suspended_history_date.OptionsColumn.ReadOnly = true
Me.suspended_history_date.Visible = true
Me.suspended_history_date.VisibleIndex = 0
Me.suspended_history_date.Width = 150
'
'suspended_history_date_end
'
Me.suspended_history_date_end.Caption = "date_end"
Me.suspended_history_date_end.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.suspended_history_date_end.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.suspended_history_date_end.FieldName = "date_end"
Me.suspended_history_date_end.Name = "suspended_history_date_end"
Me.suspended_history_date_end.OptionsColumn.AllowEdit = false
Me.suspended_history_date_end.OptionsColumn.FixedWidth = true
Me.suspended_history_date_end.OptionsColumn.ReadOnly = true
Me.suspended_history_date_end.Visible = true
Me.suspended_history_date_end.VisibleIndex = 1
Me.suspended_history_date_end.Width = 150
'
'abosuspended_history_type
'
Me.abosuspended_history_type.Caption = "status"
Me.abosuspended_history_type.FieldName = "status"
Me.abosuspended_history_type.Name = "abosuspended_history_type"
Me.abosuspended_history_type.OptionsColumn.AllowEdit = false
Me.abosuspended_history_type.OptionsColumn.FixedWidth = true
Me.abosuspended_history_type.OptionsColumn.ReadOnly = true
Me.abosuspended_history_type.Visible = true
Me.abosuspended_history_type.VisibleIndex = 2
Me.abosuspended_history_type.Width = 161
'
'tabVodView
'
Me.tabVodView.Controls.Add(Me.GridViewVod)
Me.tabVodView.Name = "tabVodView"
Me.tabVodView.Size = New System.Drawing.Size(1505, 905)
Me.tabVodView.Text = "Vod Viewed"
'
'GridViewVod
'
Me.GridViewVod.Dock = System.Windows.Forms.DockStyle.Fill
Me.GridViewVod.EmbeddedNavigator.Name = ""
Me.GridViewVod.FormsUseDefaultLookAndFeel = false
Me.GridViewVod.Location = New System.Drawing.Point(0, 0)
Me.GridViewVod.MainView = Me.GridView1
Me.GridViewVod.Name = "GridViewVod"
Me.GridViewVod.Size = New System.Drawing.Size(1505, 905)
Me.GridViewVod.TabIndex = 2
Me.GridViewVod.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
'
'GridView1
'
Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcDate_added, Me.GCLast_modified, Me.GCProducts_title, Me.GCImdb_id, Me.GCCount_ip, Me.GCNb_viewed, Me.GCUsedIp})
Me.GridView1.GridControl = Me.GridViewVod
Me.GridView1.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridView1.Name = "GridView1"
Me.GridView1.OptionsView.ColumnAutoWidth = false
Me.GridView1.OptionsView.ShowFooter = true
'
'gcDate_added
'
Me.gcDate_added.Caption = "date_added"
Me.gcDate_added.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.gcDate_added.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.gcDate_added.FieldName = "created_at"
Me.gcDate_added.Name = "gcDate_added"
Me.gcDate_added.OptionsColumn.AllowEdit = false
Me.gcDate_added.OptionsColumn.FixedWidth = true
Me.gcDate_added.OptionsColumn.ReadOnly = true
Me.gcDate_added.Visible = true
Me.gcDate_added.VisibleIndex = 2
Me.gcDate_added.Width = 150
'
'GCLast_modified
'
Me.GCLast_modified.Caption = "last_modifed"
Me.GCLast_modified.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss"
Me.GCLast_modified.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
Me.GCLast_modified.FieldName = "updated_at"
Me.GCLast_modified.Name = "GCLast_modified"
Me.GCLast_modified.OptionsColumn.AllowEdit = false
Me.GCLast_modified.OptionsColumn.FixedWidth = true
Me.GCLast_modified.OptionsColumn.ReadOnly = true
Me.GCLast_modified.Visible = true
Me.GCLast_modified.VisibleIndex = 3
Me.GCLast_modified.Width = 150
'
'GCProducts_title
'
Me.GCProducts_title.Caption = "Title"
Me.GCProducts_title.FieldName = "products_title"
Me.GCProducts_title.Name = "GCProducts_title"
Me.GCProducts_title.OptionsColumn.AllowEdit = false
Me.GCProducts_title.OptionsColumn.FixedWidth = true
Me.GCProducts_title.OptionsColumn.ReadOnly = true
Me.GCProducts_title.Visible = true
Me.GCProducts_title.VisibleIndex = 1
Me.GCProducts_title.Width = 161
'
'GCImdb_id
'
Me.GCImdb_id.Caption = "imdb_id"
Me.GCImdb_id.FieldName = "imdb_id"
Me.GCImdb_id.Name = "GCImdb_id"
Me.GCImdb_id.Visible = true
Me.GCImdb_id.VisibleIndex = 0
'
'GCCount_ip
'
Me.GCCount_ip.Caption = "max_ip"
Me.GCCount_ip.FieldName = "count_ip"
Me.GCCount_ip.Name = "GCCount_ip"
Me.GCCount_ip.Visible = true
Me.GCCount_ip.VisibleIndex = 5
'
'GCNb_viewed
'
Me.GCNb_viewed.Caption = "nb_viewed"
Me.GCNb_viewed.FieldName = "nb_viewed"
Me.GCNb_viewed.Name = "GCNb_viewed"
Me.GCNb_viewed.Visible = true
Me.GCNb_viewed.VisibleIndex = 6
'
'GCUsedIp
'
Me.GCUsedIp.Caption = "used_ip"
Me.GCUsedIp.FieldName = "used_ip"
Me.GCUsedIp.Name = "GCUsedIp"
Me.GCUsedIp.Visible = true
Me.GCUsedIp.VisibleIndex = 4
'
'tabCritiques
'
Me.tabCritiques.Controls.Add(Me.lblValueRating)
Me.tabCritiques.Controls.Add(Me.lblRating)
Me.tabCritiques.Controls.Add(Me.lblValueAverageRatingDvdPost)
Me.tabCritiques.Controls.Add(Me.lblAverageRatingDvdPost)
Me.tabCritiques.Controls.Add(Me.lblValueNbCritiquePositive)
Me.tabCritiques.Controls.Add(Me.lblNbCritiquePositive)
Me.tabCritiques.Controls.Add(Me.lblValueNbCrtitiques)
Me.tabCritiques.Controls.Add(Me.lblNbCrtitiques)
Me.tabCritiques.Controls.Add(Me.lblValueRatingAverage)
Me.tabCritiques.Controls.Add(Me.lblRatingAverage)
Me.tabCritiques.Controls.Add(Me.GridCritiques)
Me.tabCritiques.Name = "tabCritiques"
Me.tabCritiques.Size = New System.Drawing.Size(1505, 905)
Me.tabCritiques.Text = "Critiques"
'
'lblValueRating
'
Me.lblValueRating.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblValueRating.Appearance.Options.UseFont = true
Me.lblValueRating.Location = New System.Drawing.Point(167, 69)
Me.lblValueRating.Name = "lblValueRating"
Me.lblValueRating.Size = New System.Drawing.Size(13, 28)
Me.lblValueRating.TabIndex = 10
Me.lblValueRating.Text = "0"
'
'lblRating
'
Me.lblRating.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblRating.Appearance.Options.UseFont = true
Me.lblRating.Location = New System.Drawing.Point(8, 75)
Me.lblRating.Name = "lblRating"
Me.lblRating.Size = New System.Drawing.Size(65, 21)
Me.lblRating.TabIndex = 9
Me.lblRating.Text = "# Rating"
'
'lblValueAverageRatingDvdPost
'
Me.lblValueAverageRatingDvdPost.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblValueAverageRatingDvdPost.Appearance.Options.UseFont = true
Me.lblValueAverageRatingDvdPost.Location = New System.Drawing.Point(346, 16)
Me.lblValueAverageRatingDvdPost.Name = "lblValueAverageRatingDvdPost"
Me.lblValueAverageRatingDvdPost.Size = New System.Drawing.Size(13, 28)
Me.lblValueAverageRatingDvdPost.TabIndex = 8
Me.lblValueAverageRatingDvdPost.Text = "0"
'
'lblAverageRatingDvdPost
'
Me.lblAverageRatingDvdPost.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblAverageRatingDvdPost.Appearance.Options.UseFont = true
Me.lblAverageRatingDvdPost.Location = New System.Drawing.Point(226, 21)
Me.lblAverageRatingDvdPost.Name = "lblAverageRatingDvdPost"
Me.lblAverageRatingDvdPost.Size = New System.Drawing.Size(114, 21)
Me.lblAverageRatingDvdPost.TabIndex = 7
Me.lblAverageRatingDvdPost.Text = "Rating DvdPost"
'
'lblValueNbCritiquePositive
'
Me.lblValueNbCritiquePositive.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblValueNbCritiquePositive.Appearance.Options.UseFont = true
Me.lblValueNbCritiquePositive.Location = New System.Drawing.Point(167, 14)
Me.lblValueNbCritiquePositive.Name = "lblValueNbCritiquePositive"
Me.lblValueNbCritiquePositive.Size = New System.Drawing.Size(13, 28)
Me.lblValueNbCritiquePositive.TabIndex = 6
Me.lblValueNbCritiquePositive.Text = "0"
'
'lblNbCritiquePositive
'
Me.lblNbCritiquePositive.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblNbCritiquePositive.Appearance.Options.UseFont = true
Me.lblNbCritiquePositive.Location = New System.Drawing.Point(8, 20)
Me.lblNbCritiquePositive.Name = "lblNbCritiquePositive"
Me.lblNbCritiquePositive.Size = New System.Drawing.Size(152, 21)
Me.lblNbCritiquePositive.TabIndex = 5
Me.lblNbCritiquePositive.Text = "# Critiques positives"
'
'lblValueNbCrtitiques
'
Me.lblValueNbCrtitiques.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblValueNbCrtitiques.Appearance.Options.UseFont = true
Me.lblValueNbCrtitiques.Location = New System.Drawing.Point(167, 42)
Me.lblValueNbCrtitiques.Name = "lblValueNbCrtitiques"
Me.lblValueNbCrtitiques.Size = New System.Drawing.Size(13, 28)
Me.lblValueNbCrtitiques.TabIndex = 4
Me.lblValueNbCrtitiques.Text = "0"
'
'lblNbCrtitiques
'
Me.lblNbCrtitiques.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblNbCrtitiques.Appearance.Options.UseFont = true
Me.lblNbCrtitiques.Location = New System.Drawing.Point(8, 47)
Me.lblNbCrtitiques.Name = "lblNbCrtitiques"
Me.lblNbCrtitiques.Size = New System.Drawing.Size(82, 21)
Me.lblNbCrtitiques.TabIndex = 3
Me.lblNbCrtitiques.Text = "# Critiques"
'
'lblValueRatingAverage
'
Me.lblValueRatingAverage.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblValueRatingAverage.Appearance.Options.UseFont = true
Me.lblValueRatingAverage.Cursor = System.Windows.Forms.Cursors.Default
Me.lblValueRatingAverage.Location = New System.Drawing.Point(512, 14)
Me.lblValueRatingAverage.Name = "lblValueRatingAverage"
Me.lblValueRatingAverage.Size = New System.Drawing.Size(13, 28)
Me.lblValueRatingAverage.TabIndex = 2
Me.lblValueRatingAverage.Text = "0"
'
'lblRatingAverage
'
Me.lblRatingAverage.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.lblRatingAverage.Appearance.Options.UseFont = true
Me.lblRatingAverage.Location = New System.Drawing.Point(391, 20)
Me.lblRatingAverage.Name = "lblRatingAverage"
Me.lblRatingAverage.Size = New System.Drawing.Size(101, 21)
Me.lblRatingAverage.TabIndex = 1
Me.lblRatingAverage.Text = "Rating Moyen"
'
'GridCritiques
'
Me.GridCritiques.EmbeddedNavigator.Name = ""
Me.GridCritiques.FormsUseDefaultLookAndFeel = false
Me.GridCritiques.Location = New System.Drawing.Point(8, 117)
Me.GridCritiques.MainView = Me.GridViewCritiques
Me.GridCritiques.Name = "GridCritiques"
Me.GridCritiques.Size = New System.Drawing.Size(1025, 467)
Me.GridCritiques.TabIndex = 0
Me.GridCritiques.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridViewCritiques})
'
'GridViewCritiques
'
Me.GridViewCritiques.GridControl = Me.GridCritiques
Me.GridViewCritiques.Name = "GridViewCritiques"
Me.GridViewCritiques.OptionsView.ShowFooter = true
'
'tabConfig
'
Me.tabConfig.Controls.Add(Me.btnRefreshTab)
Me.tabConfig.Controls.Add(Me.ChkListConfig)
Me.tabConfig.Name = "tabConfig"
Me.tabConfig.Size = New System.Drawing.Size(1505, 905)
Me.tabConfig.Text = "Config"
'
'btnRefreshTab
'
Me.btnRefreshTab.Location = New System.Drawing.Point(763, 39)
Me.btnRefreshTab.Name = "btnRefreshTab"
Me.btnRefreshTab.Size = New System.Drawing.Size(190, 48)
Me.btnRefreshTab.TabIndex = 1
Me.btnRefreshTab.Text = "refresh tab"
'
'ChkListConfig
'
Me.ChkListConfig.Appearance.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.ChkListConfig.Appearance.Options.UseFont = true
Me.ChkListConfig.CheckOnClick = true
Me.ChkListConfig.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("comment", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("calls", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("wishlist", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("abo history", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("orders history", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("messagerie", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("invoices", System.Windows.Forms.CheckState.Checked), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("payment movements"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("droselia"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("aboprocess"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("aboprocess old"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("mail history"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("purchase"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("credit history"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("sponsorship"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("products rating"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("suspended history"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("vod viewed"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("critiques")})
Me.ChkListConfig.LeftCoord = 0
Me.ChkListConfig.Location = New System.Drawing.Point(40, 50)
Me.ChkListConfig.MultiColumn = true
Me.ChkListConfig.Name = "ChkListConfig"
Me.ChkListConfig.Size = New System.Drawing.Size(654, 128)
Me.ChkListConfig.TabIndex = 0
'
'LabelControl39
'
Me.LabelControl39.Location = New System.Drawing.Point(19, 23)
Me.LabelControl39.Name = "LabelControl39"
Me.LabelControl39.Size = New System.Drawing.Size(131, 16)
Me.LabelControl39.TabIndex = 27
Me.LabelControl39.Text = "Nombre reconduction :"
'
'LabelControl40
'
Me.LabelControl40.Location = New System.Drawing.Point(161, 23)
Me.LabelControl40.Name = "LabelControl40"
Me.LabelControl40.Size = New System.Drawing.Size(7, 16)
Me.LabelControl40.TabIndex = 28
Me.LabelControl40.Text = "0"
'
'LabelControl41
'
Me.LabelControl41.Location = New System.Drawing.Point(952, 20)
Me.LabelControl41.Name = "LabelControl41"
Me.LabelControl41.Size = New System.Drawing.Size(57, 16)
Me.LabelControl41.TabIndex = 24
Me.LabelControl41.Text = "Next Price"
'
'LabelControl42
'
Me.LabelControl42.Location = New System.Drawing.Point(758, 20)
Me.LabelControl42.Name = "LabelControl42"
Me.LabelControl42.Size = New System.Drawing.Size(63, 16)
Me.LabelControl42.TabIndex = 22
Me.LabelControl42.Text = "Next Credit"
'
'TextEdit1
'
Me.TextEdit1.Enabled = false
Me.TextEdit1.Location = New System.Drawing.Point(1025, 16)
Me.TextEdit1.Name = "TextEdit1"
Me.TextEdit1.Properties.ReadOnly = true
Me.TextEdit1.Size = New System.Drawing.Size(95, 22)
Me.TextEdit1.TabIndex = 23
'
'TextEdit2
'
Me.TextEdit2.Enabled = false
Me.TextEdit2.Location = New System.Drawing.Point(836, 16)
Me.TextEdit2.Name = "TextEdit2"
Me.TextEdit2.Properties.ReadOnly = true
Me.TextEdit2.Size = New System.Drawing.Size(95, 22)
Me.TextEdit2.TabIndex = 21
'
'SimpleButton2
'
Me.SimpleButton2.Location = New System.Drawing.Point(1188, 46)
Me.SimpleButton2.Name = "SimpleButton2"
Me.SimpleButton2.Size = New System.Drawing.Size(173, 27)
Me.SimpleButton2.TabIndex = 13
Me.SimpleButton2.Text = "Reconduction"
'
'SimpleButton3
'
Me.SimpleButton3.Location = New System.Drawing.Point(1188, 283)
Me.SimpleButton3.Name = "SimpleButton3"
Me.SimpleButton3.Size = New System.Drawing.Size(173, 26)
Me.SimpleButton3.TabIndex = 12
Me.SimpleButton3.Text = "&Activate by Domiciliation"
'
'SimpleButton4
'
Me.SimpleButton4.Location = New System.Drawing.Point(1187, 338)
Me.SimpleButton4.Name = "SimpleButton4"
Me.SimpleButton4.Size = New System.Drawing.Size(173, 27)
Me.SimpleButton4.TabIndex = 11
Me.SimpleButton4.Text = "&Received domiciliation"
Me.ToolTip1.SetToolTip(Me.SimpleButton4, "received dom 70")
'
'MemoEdit2
'
Me.MemoEdit2.Enabled = false
Me.MemoEdit2.Location = New System.Drawing.Point(30, 151)
Me.MemoEdit2.Name = "MemoEdit2"
Me.MemoEdit2.Size = New System.Drawing.Size(278, 91)
Me.MemoEdit2.StyleController = Me.LayoutCustServ
Me.MemoEdit2.TabIndex = 43
'
'Label1
'
Me.Label1.AutoSize = true
Me.Label1.Location = New System.Drawing.Point(26, 134)
Me.Label1.Name = "Label1"
Me.Label1.Size = New System.Drawing.Size(67, 17)
Me.Label1.TabIndex = 42
Me.Label1.Text = "Comment"
'
'LookUpEdit1
'
Me.LookUpEdit1.Enabled = false
Me.LookUpEdit1.Location = New System.Drawing.Point(163, 81)
Me.LookUpEdit1.Name = "LookUpEdit1"
Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("reason", "reason", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("stop_phone_id", "stop_phone_id", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None)})
Me.LookUpEdit1.Properties.DisplayMember = "reason"
Me.LookUpEdit1.Properties.NullText = ""
Me.LookUpEdit1.Properties.ValueMember = "stop_phone_id"
Me.LookUpEdit1.Size = New System.Drawing.Size(145, 22)
Me.LookUpEdit1.TabIndex = 40
Me.LookUpEdit1.Visible = false
'
'Label3
'
Me.Label3.AutoSize = true
Me.Label3.Location = New System.Drawing.Point(26, 84)
Me.Label3.Name = "Label3"
Me.Label3.Size = New System.Drawing.Size(132, 17)
Me.Label3.TabIndex = 23
Me.Label3.Text = "Reason from delete"
Me.Label3.Visible = false
'
'DateEdit1
'
Me.DateEdit1.CausesValidation = false
Me.DateEdit1.EditValue = Nothing
Me.DateEdit1.Enabled = false
Me.DateEdit1.Location = New System.Drawing.Point(163, 48)
Me.DateEdit1.Name = "DateEdit1"
Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.DateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.DateEdit1.Size = New System.Drawing.Size(145, 22)
Me.DateEdit1.TabIndex = 18
'
'LabelControl43
'
Me.LabelControl43.Location = New System.Drawing.Point(30, 52)
Me.LabelControl43.Name = "LabelControl43"
Me.LabelControl43.Size = New System.Drawing.Size(70, 16)
Me.LabelControl43.TabIndex = 13
Me.LabelControl43.Text = "call me date"
'
'SimpleButton5
'
Me.SimpleButton5.Location = New System.Drawing.Point(1188, 465)
Me.SimpleButton5.Name = "SimpleButton5"
Me.SimpleButton5.Size = New System.Drawing.Size(173, 27)
Me.SimpleButton5.TabIndex = 20
Me.SimpleButton5.Text = "Delete Phone activation"
'
'SimpleButton6
'
Me.SimpleButton6.Location = New System.Drawing.Point(1188, 227)
Me.SimpleButton6.Name = "SimpleButton6"
Me.SimpleButton6.Size = New System.Drawing.Size(173, 27)
Me.SimpleButton6.TabIndex = 9
Me.SimpleButton6.Text = "&Activate by phone"
'
'SimpleButton7
'
Me.SimpleButton7.Location = New System.Drawing.Point(1188, 97)
Me.SimpleButton7.Name = "SimpleButton7"
Me.SimpleButton7.Size = New System.Drawing.Size(173, 26)
Me.SimpleButton7.TabIndex = 6
Me.SimpleButton7.Text = "Re-Activate"
'
'ComboBoxEdit1
'
Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.activation_discount_code_type", true))
Me.ComboBoxEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "customers.activation_discount_code_type", true))
Me.ComboBoxEdit1.Enabled = false
Me.ComboBoxEdit1.Location = New System.Drawing.Point(334, 306)
Me.ComboBoxEdit1.Name = "ComboBoxEdit1"
Me.ComboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.ComboBoxEdit1.Properties.Items.AddRange(New Object() {"A", "D", ""})
Me.ComboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
Me.ComboBoxEdit1.Size = New System.Drawing.Size(60, 22)
Me.ComboBoxEdit1.TabIndex = 59
'
'LabelControl44
'
Me.LabelControl44.Location = New System.Drawing.Point(10, 172)
Me.LabelControl44.Name = "LabelControl44"
Me.LabelControl44.Size = New System.Drawing.Size(132, 16)
Me.LabelControl44.TabIndex = 51
Me.LabelControl44.Text = "closing date of vacancy"
'
'DateEdit2
'
Me.DateEdit2.EditValue = Nothing
Me.DateEdit2.Enabled = false
Me.DateEdit2.Location = New System.Drawing.Point(192, 168)
Me.DateEdit2.Name = "DateEdit2"
Me.DateEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.DateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.DateEdit2.Size = New System.Drawing.Size(182, 22)
Me.DateEdit2.TabIndex = 50
'
'LookUpEdit3
'
Me.LookUpEdit3.Enabled = false
Me.LookUpEdit3.Location = New System.Drawing.Point(192, 142)
Me.LookUpEdit3.Name = "LookUpEdit3"
Me.LookUpEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.LookUpEdit3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Value", "Value", 75, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DisplayMember", "DisplayMember", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit3.Properties.DisplayMember = "DisplayMember"
Me.LookUpEdit3.Properties.NullText = ""
Me.LookUpEdit3.Properties.ValueMember = "Value"
Me.LookUpEdit3.Size = New System.Drawing.Size(182, 22)
Me.LookUpEdit3.TabIndex = 48
'
'Label4
'
Me.Label4.AutoSize = true
Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
Me.Label4.Location = New System.Drawing.Point(6, 33)
Me.Label4.Name = "Label4"
Me.Label4.Size = New System.Drawing.Size(185, 17)
Me.Label4.TabIndex = 47
Me.Label4.Text = "ABO 12 mois SummerPower"
'
'LabelControl45
'
Me.LabelControl45.Location = New System.Drawing.Point(10, 147)
Me.LabelControl45.Name = "LabelControl45"
Me.LabelControl45.Size = New System.Drawing.Size(63, 16)
Me.LabelControl45.TabIndex = 45
Me.LabelControl45.Text = "Suspended"
'
'SimpleButton8
'
Me.SimpleButton8.Enabled = false
Me.SimpleButton8.Location = New System.Drawing.Point(298, 389)
Me.SimpleButton8.Name = "SimpleButton8"
Me.SimpleButton8.Size = New System.Drawing.Size(76, 26)
Me.SimpleButton8.TabIndex = 44
Me.SimpleButton8.Text = "Goto 30"
Me.SimpleButton8.Visible = false
'
'TextEdit6
'
Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_registration_step", true))
Me.TextEdit6.Enabled = false
Me.TextEdit6.Location = New System.Drawing.Point(192, 389)
Me.TextEdit6.Name = "TextEdit6"
Me.TextEdit6.Size = New System.Drawing.Size(96, 22)
Me.TextEdit6.TabIndex = 43
'
'LabelControl46
'
Me.LabelControl46.Location = New System.Drawing.Point(10, 398)
Me.LabelControl46.Name = "LabelControl46"
Me.LabelControl46.Size = New System.Drawing.Size(98, 16)
Me.LabelControl46.TabIndex = 42
Me.LabelControl46.Text = "Registration Step"
'
'SpinEdit1
'
Me.SpinEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_adult", true))
Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.SpinEdit1.Enabled = false
Me.SpinEdit1.Location = New System.Drawing.Point(288, 278)
Me.SpinEdit1.Name = "SpinEdit1"
Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.SpinEdit1.Size = New System.Drawing.Size(86, 22)
Me.SpinEdit1.TabIndex = 41
'
'LabelControl47
'
Me.LabelControl47.Location = New System.Drawing.Point(10, 343)
Me.LabelControl47.Name = "LabelControl47"
Me.LabelControl47.Size = New System.Drawing.Size(107, 16)
Me.LabelControl47.TabIndex = 40
Me.LabelControl47.Text = "Discount Recurring"
'
'DateEdit3
'
Me.DateEdit3.AllowDrop = true
Me.DateEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_discount_recurring_to_date", true))
Me.DateEdit3.EditValue = Nothing
Me.DateEdit3.Enabled = false
Me.DateEdit3.Location = New System.Drawing.Point(192, 333)
Me.DateEdit3.Name = "DateEdit3"
Me.DateEdit3.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
Me.DateEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.DateEdit3.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.DateEdit3.Size = New System.Drawing.Size(182, 22)
Me.DateEdit3.TabIndex = 39
'
'CheckEdit1
'
Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_auto_stop_next_reconduction", true))
Me.CheckEdit1.Enabled = false
Me.CheckEdit1.Location = New System.Drawing.Point(144, 426)
Me.CheckEdit1.Name = "CheckEdit1"
Me.CheckEdit1.Properties.Caption = "Auto-Stop"
Me.CheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
Me.CheckEdit1.Properties.ValueChecked = 1
Me.CheckEdit1.Properties.ValueUnchecked = 0
Me.CheckEdit1.Size = New System.Drawing.Size(115, 21)
Me.CheckEdit1.TabIndex = 38
'
'TextEdit7
'
Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.activation_discount_code_id", true))
Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.objDS, "customers.activation_discount_code_id", true))
Me.TextEdit7.Enabled = false
Me.TextEdit7.Location = New System.Drawing.Point(192, 306)
Me.TextEdit7.Name = "TextEdit7"
Me.TextEdit7.Size = New System.Drawing.Size(134, 22)
Me.TextEdit7.TabIndex = 37
'
'LookUpEdit4
'
Me.LookUpEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_discount_code", true))
Me.LookUpEdit4.Enabled = false
Me.LookUpEdit4.Location = New System.Drawing.Point(192, 361)
Me.LookUpEdit4.Name = "LookUpEdit4"
Me.LookUpEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
Me.LookUpEdit4.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code_id", "discount_code_id", 102, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("discount_code", "discount_code", 75, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit4.Properties.DataSource = Me.objDS.discount_code
Me.LookUpEdit4.Properties.DisplayMember = "discount_code"
Me.LookUpEdit4.Properties.NullText = ""
Me.LookUpEdit4.Properties.ValueMember = "discount_code_id"
Me.LookUpEdit4.Size = New System.Drawing.Size(182, 22)
Me.LookUpEdit4.TabIndex = 36
'
'LabelControl59
'
Me.LabelControl59.Location = New System.Drawing.Point(10, 370)
Me.LabelControl59.Name = "LabelControl59"
Me.LabelControl59.Size = New System.Drawing.Size(89, 16)
Me.LabelControl59.TabIndex = 33
Me.LabelControl59.Text = "Next Disc. Code"
'
'LabelControl60
'
Me.LabelControl60.Location = New System.Drawing.Point(10, 315)
Me.LabelControl60.Name = "LabelControl60"
Me.LabelControl60.Size = New System.Drawing.Size(128, 16)
Me.LabelControl60.TabIndex = 31
Me.LabelControl60.Text = "Activation / Disc. Code"
'
'CheckEdit2
'
Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_multishipment", true))
Me.CheckEdit2.Enabled = false
Me.CheckEdit2.Location = New System.Drawing.Point(10, 426)
Me.CheckEdit2.Name = "CheckEdit2"
Me.CheckEdit2.Properties.Caption = "Multi-Shipment"
Me.CheckEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
Me.CheckEdit2.Properties.ValueChecked = 1
Me.CheckEdit2.Properties.ValueUnchecked = 0
Me.CheckEdit2.Size = New System.Drawing.Size(115, 21)
Me.CheckEdit2.TabIndex = 30
'
'LookUpEdit5
'
Me.LookUpEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_next_abo_type", true))
Me.LookUpEdit5.Enabled = false
Me.LookUpEdit5.Location = New System.Drawing.Point(192, 80)
Me.LookUpEdit5.Name = "LookUpEdit5"
Me.LookUpEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.LookUpEdit5.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit5.Properties.DataSource = Me.objDS.products_abo
Me.LookUpEdit5.Properties.DisplayMember = "products_title"
Me.LookUpEdit5.Properties.NullText = ""
Me.LookUpEdit5.Properties.ValueMember = "products_id"
Me.LookUpEdit5.Size = New System.Drawing.Size(182, 22)
Me.LookUpEdit5.TabIndex = 29
'
'SpinEdit2
'
Me.SpinEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_home_norm", true))
Me.SpinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.SpinEdit2.Enabled = false
Me.SpinEdit2.Location = New System.Drawing.Point(288, 250)
Me.SpinEdit2.Name = "SpinEdit2"
Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.SpinEdit2.Size = New System.Drawing.Size(86, 22)
Me.SpinEdit2.TabIndex = 27
'
'SpinEdit3
'
Me.SpinEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_adult", true))
Me.SpinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.SpinEdit3.Enabled = false
Me.SpinEdit3.Location = New System.Drawing.Point(192, 278)
Me.SpinEdit3.Name = "SpinEdit3"
Me.SpinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.SpinEdit3.Size = New System.Drawing.Size(86, 22)
Me.SpinEdit3.TabIndex = 26
'
'SpinEdit4
'
Me.SpinEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_norm", true))
Me.SpinEdit4.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.SpinEdit4.Enabled = false
Me.SpinEdit4.Location = New System.Drawing.Point(192, 250)
Me.SpinEdit4.Name = "SpinEdit4"
Me.SpinEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.SpinEdit4.Size = New System.Drawing.Size(86, 22)
Me.SpinEdit4.TabIndex = 25
'
'LabelControl61
'
Me.LabelControl61.Location = New System.Drawing.Point(10, 287)
Me.LabelControl61.Name = "LabelControl61"
Me.LabelControl61.Size = New System.Drawing.Size(38, 16)
Me.LabelControl61.TabIndex = 24
Me.LabelControl61.Text = "ADULT"
'
'LabelControl62
'
Me.LabelControl62.Location = New System.Drawing.Point(10, 260)
Me.LabelControl62.Name = "LabelControl62"
Me.LabelControl62.Size = New System.Drawing.Size(35, 16)
Me.LabelControl62.TabIndex = 23
Me.LabelControl62.Text = "NORM"
'
'LabelControl63
'
Me.LabelControl63.Location = New System.Drawing.Point(298, 232)
Me.LabelControl63.Name = "LabelControl63"
Me.LabelControl63.Size = New System.Drawing.Size(45, 16)
Me.LabelControl63.TabIndex = 22
Me.LabelControl63.Text = "@Home"
'
'LabelControl64
'
Me.LabelControl64.Location = New System.Drawing.Point(192, 232)
Me.LabelControl64.Name = "LabelControl64"
Me.LabelControl64.Size = New System.Drawing.Size(34, 16)
Me.LabelControl64.TabIndex = 21
Me.LabelControl64.Text = "Asked"
'
'SpinEdit5
'
Me.SpinEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_dvd_credit", true))
Me.SpinEdit5.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
Me.SpinEdit5.Enabled = false
Me.SpinEdit5.Location = New System.Drawing.Point(192, 204)
Me.SpinEdit5.Name = "SpinEdit5"
Me.SpinEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.SpinEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
Me.SpinEdit5.Properties.MaxLength = 1000
Me.SpinEdit5.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
Me.SpinEdit5.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
Me.SpinEdit5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
Me.SpinEdit5.Size = New System.Drawing.Size(182, 22)
Me.SpinEdit5.TabIndex = 20
'
'LabelControl65
'
Me.LabelControl65.Location = New System.Drawing.Point(10, 213)
Me.LabelControl65.Name = "LabelControl65"
Me.LabelControl65.Size = New System.Drawing.Size(40, 16)
Me.LabelControl65.TabIndex = 19
Me.LabelControl65.Text = "Credits"
'
'LabelControl66
'
Me.LabelControl66.Location = New System.Drawing.Point(10, 117)
Me.LabelControl66.Name = "LabelControl66"
Me.LabelControl66.Size = New System.Drawing.Size(41, 16)
Me.LabelControl66.TabIndex = 18
Me.LabelControl66.Text = "Validity"
'
'DateEdit4
'
Me.DateEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_validityto", true))
Me.DateEdit4.EditValue = Nothing
Me.DateEdit4.Enabled = false
Me.DateEdit4.Location = New System.Drawing.Point(192, 107)
Me.DateEdit4.Name = "DateEdit4"
Me.DateEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.DateEdit4.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.DateEdit4.Size = New System.Drawing.Size(182, 22)
Me.DateEdit4.TabIndex = 17
'
'LookUpEdit6
'
Me.LookUpEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo_type", true))
Me.LookUpEdit6.Enabled = false
Me.LookUpEdit6.Location = New System.Drawing.Point(192, 52)
Me.LookUpEdit6.Name = "LookUpEdit6"
Me.LookUpEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.LookUpEdit6.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_id", "products_id", 75, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_model", "products_model", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("products_title", "products_title", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit6.Properties.DataSource = Me.objDS.products_abo
Me.LookUpEdit6.Properties.DisplayMember = "products_title"
Me.LookUpEdit6.Properties.NullText = ""
Me.LookUpEdit6.Properties.ValueMember = "products_id"
Me.LookUpEdit6.Size = New System.Drawing.Size(182, 22)
Me.LookUpEdit6.TabIndex = 15
'
'LabelControl67
'
Me.LabelControl67.Location = New System.Drawing.Point(10, 89)
Me.LabelControl67.Name = "LabelControl67"
Me.LabelControl67.Size = New System.Drawing.Size(53, 16)
Me.LabelControl67.TabIndex = 14
Me.LabelControl67.Text = "Next ABO"
'
'LabelControl68
'
Me.LabelControl68.Location = New System.Drawing.Point(10, 61)
Me.LabelControl68.Name = "LabelControl68"
Me.LabelControl68.Size = New System.Drawing.Size(24, 16)
Me.LabelControl68.TabIndex = 12
Me.LabelControl68.Text = "ABO"
'
'GridControl2
'
Me.GridControl2.AllowDrop = true
Me.GridControl2.EmbeddedNavigator.Name = ""
Me.GridControl2.FormsUseDefaultLookAndFeel = false
Me.GridControl2.Location = New System.Drawing.Point(18, 153)
Me.GridControl2.MainView = Me.GridView2
Me.GridControl2.Name = "GridControl2"
Me.GridControl2.Size = New System.Drawing.Size(692, 169)
Me.GridControl2.TabIndex = 20
Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
'
'GridView2
'
Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
Me.GridView2.GridControl = Me.GridControl2
Me.GridView2.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways
Me.GridView2.Name = "GridView2"
Me.GridView2.OptionsNavigation.AutoMoveRowFocus = false
Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = false
Me.GridView2.OptionsSelection.EnableAppearanceFocusedRow = false
Me.GridView2.OptionsView.ColumnAutoWidth = false
Me.GridView2.OptionsView.ShowFooter = true
'
'GridColumn2
'
Me.GridColumn2.Caption = "entry_firstname"
Me.GridColumn2.FieldName = "entry_firstname"
Me.GridColumn2.Name = "GridColumn2"
Me.GridColumn2.OptionsColumn.AllowEdit = false
Me.GridColumn2.OptionsColumn.FixedWidth = true
Me.GridColumn2.Visible = true
Me.GridColumn2.VisibleIndex = 0
Me.GridColumn2.Width = 130
'
'GridColumn3
'
Me.GridColumn3.Caption = "entry_lastname"
Me.GridColumn3.FieldName = "entry_lastname"
Me.GridColumn3.Name = "GridColumn3"
Me.GridColumn3.OptionsColumn.AllowEdit = false
Me.GridColumn3.OptionsColumn.FixedWidth = true
Me.GridColumn3.Visible = true
Me.GridColumn3.VisibleIndex = 1
Me.GridColumn3.Width = 156
'
'GridColumn4
'
Me.GridColumn4.Caption = "entry_street_address"
Me.GridColumn4.FieldName = "entry_street_address"
Me.GridColumn4.Name = "GridColumn4"
Me.GridColumn4.OptionsColumn.AllowEdit = false
Me.GridColumn4.OptionsColumn.FixedWidth = true
Me.GridColumn4.Visible = true
Me.GridColumn4.VisibleIndex = 2
Me.GridColumn4.Width = 235
'
'GridColumn5
'
Me.GridColumn5.Caption = "entry_postcode"
Me.GridColumn5.FieldName = "entry_postcode"
Me.GridColumn5.Name = "GridColumn5"
Me.GridColumn5.OptionsColumn.AllowEdit = false
Me.GridColumn5.OptionsColumn.FixedWidth = true
Me.GridColumn5.Visible = true
Me.GridColumn5.VisibleIndex = 3
Me.GridColumn5.Width = 111
'
'GridColumn6
'
Me.GridColumn6.Caption = "entry_city"
Me.GridColumn6.FieldName = "entry_city"
Me.GridColumn6.Name = "GridColumn6"
Me.GridColumn6.OptionsColumn.AllowEdit = false
Me.GridColumn6.OptionsColumn.FixedWidth = true
Me.GridColumn6.Visible = true
Me.GridColumn6.VisibleIndex = 4
Me.GridColumn6.Width = 108
'
'GridColumn7
'
Me.GridColumn7.Caption = "countries_name"
Me.GridColumn7.FieldName = "countries_name"
Me.GridColumn7.Name = "GridColumn7"
Me.GridColumn7.OptionsColumn.AllowEdit = false
Me.GridColumn7.OptionsColumn.FixedWidth = true
Me.GridColumn7.Visible = true
Me.GridColumn7.VisibleIndex = 5
Me.GridColumn7.Width = 135
'
'TextEdit8
'
Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_firstname", true))
Me.TextEdit8.Enabled = false
Me.TextEdit8.Location = New System.Drawing.Point(461, 32)
Me.TextEdit8.Name = "TextEdit8"
Me.TextEdit8.Size = New System.Drawing.Size(249, 22)
Me.TextEdit8.TabIndex = 17
'
'TextEdit9
'
Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_lastname", true))
Me.TextEdit9.Enabled = false
Me.TextEdit9.Location = New System.Drawing.Point(182, 32)
Me.TextEdit9.Name = "TextEdit9"
Me.TextEdit9.Size = New System.Drawing.Size(269, 22)
Me.TextEdit9.TabIndex = 16
'
'LabelControl69
'
Me.LabelControl69.Location = New System.Drawing.Point(19, 42)
Me.LabelControl69.Name = "LabelControl69"
Me.LabelControl69.Size = New System.Drawing.Size(33, 16)
Me.LabelControl69.TabIndex = 15
Me.LabelControl69.Text = "Name"
'
'LookUpEdit7
'
Me.LookUpEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_country_id", true))
Me.LookUpEdit7.Enabled = false
Me.LookUpEdit7.Location = New System.Drawing.Point(184, 115)
Me.LookUpEdit7.Name = "LookUpEdit7"
Me.LookUpEdit7.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.LookUpEdit7.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_id", "countries_id", 77, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("countries_name", "countries_name", 82, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit7.Properties.DataSource = Me.objDS.country
Me.LookUpEdit7.Properties.DisplayMember = "countries_name"
Me.LookUpEdit7.Properties.NullText = ""
Me.LookUpEdit7.Properties.ValueMember = "countries_id"
Me.LookUpEdit7.Size = New System.Drawing.Size(528, 22)
Me.LookUpEdit7.TabIndex = 14
'
'TextEdit10
'
Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_city", true))
Me.TextEdit10.Enabled = false
Me.TextEdit10.Location = New System.Drawing.Point(336, 88)
Me.TextEdit10.Name = "TextEdit10"
Me.TextEdit10.Size = New System.Drawing.Size(374, 22)
Me.TextEdit10.TabIndex = 13
'
'TextEdit11
'
Me.TextEdit11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_postcode", true))
Me.TextEdit11.Enabled = false
Me.TextEdit11.Location = New System.Drawing.Point(182, 88)
Me.TextEdit11.Name = "TextEdit11"
Me.TextEdit11.Size = New System.Drawing.Size(144, 22)
Me.TextEdit11.TabIndex = 12
'
'TextEdit12
'
Me.TextEdit12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "address_book_default.entry_street_address", true))
Me.TextEdit12.Enabled = false
Me.TextEdit12.Location = New System.Drawing.Point(182, 60)
Me.TextEdit12.Name = "TextEdit12"
Me.TextEdit12.Size = New System.Drawing.Size(528, 22)
Me.TextEdit12.TabIndex = 10
'
'LabelControl70
'
Me.LabelControl70.Location = New System.Drawing.Point(19, 69)
Me.LabelControl70.Name = "LabelControl70"
Me.LabelControl70.Size = New System.Drawing.Size(46, 16)
Me.LabelControl70.TabIndex = 8
Me.LabelControl70.Text = "Address"
'
'TextEdit13
'
Me.TextEdit13.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customer_attributes.last_login_at", true))
Me.TextEdit13.Enabled = false
Me.TextEdit13.Location = New System.Drawing.Point(173, 335)
Me.TextEdit13.Name = "TextEdit13"
Me.TextEdit13.Size = New System.Drawing.Size(182, 22)
Me.TextEdit13.TabIndex = 59
'
'SpinEdit6
'
Me.SpinEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.mgm_points", true))
Me.SpinEdit6.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
Me.SpinEdit6.Enabled = false
Me.SpinEdit6.Location = New System.Drawing.Point(526, 329)
Me.SpinEdit6.Name = "SpinEdit6"
Me.SpinEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.SpinEdit6.Properties.MaxLength = 100000
Me.SpinEdit6.Properties.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 0})
Me.SpinEdit6.Size = New System.Drawing.Size(182, 22)
Me.SpinEdit6.TabIndex = 26
'
'LabelControl71
'
Me.LabelControl71.Location = New System.Drawing.Point(19, 270)
Me.LabelControl71.Name = "LabelControl71"
Me.LabelControl71.Size = New System.Drawing.Size(55, 16)
Me.LabelControl71.TabIndex = 58
Me.LabelControl71.Text = "Comment"
'
'CheckEdit3
'
Me.CheckEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.red_listed", true))
Me.CheckEdit3.Enabled = false
Me.CheckEdit3.Location = New System.Drawing.Point(427, 414)
Me.CheckEdit3.Name = "CheckEdit3"
Me.CheckEdit3.Properties.Caption = "Red Listed"
Me.CheckEdit3.Properties.ValueChecked = 1
Me.CheckEdit3.Properties.ValueUnchecked = 0
Me.CheckEdit3.Size = New System.Drawing.Size(154, 21)
Me.CheckEdit3.TabIndex = 54
'
'TextEdit14
'
Me.TextEdit14.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.comment", true))
Me.TextEdit14.Enabled = false
Me.TextEdit14.Location = New System.Drawing.Point(173, 267)
Me.TextEdit14.Name = "TextEdit14"
Me.TextEdit14.Size = New System.Drawing.Size(528, 22)
Me.TextEdit14.TabIndex = 57
'
'CheckEdit4
'
Me.CheckEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.black_listed", true))
Me.CheckEdit4.Enabled = false
Me.CheckEdit4.Location = New System.Drawing.Point(427, 443)
Me.CheckEdit4.Name = "CheckEdit4"
Me.CheckEdit4.Properties.Caption = "Black Listed"
Me.CheckEdit4.Properties.ValueChecked = 1
Me.CheckEdit4.Properties.ValueUnchecked = 0
Me.CheckEdit4.Size = New System.Drawing.Size(177, 21)
Me.CheckEdit4.TabIndex = 53
'
'TextEdit15
'
Me.TextEdit15.Enabled = false
Me.TextEdit15.Location = New System.Drawing.Point(355, 207)
Me.TextEdit15.Name = "TextEdit15"
Me.TextEdit15.Size = New System.Drawing.Size(34, 22)
Me.TextEdit15.TabIndex = 56
'
'CheckEdit5
'
Me.CheckEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_newsletterpartner", true))
Me.CheckEdit5.Enabled = false
Me.CheckEdit5.Location = New System.Drawing.Point(170, 443)
Me.CheckEdit5.Name = "CheckEdit5"
Me.CheckEdit5.Properties.Caption = "NewsLetter Partner"
Me.CheckEdit5.Properties.ValueChecked = 1
Me.CheckEdit5.Properties.ValueUnchecked = 0
Me.CheckEdit5.Size = New System.Drawing.Size(183, 21)
Me.CheckEdit5.TabIndex = 52
'
'LabelControl72
'
Me.LabelControl72.Location = New System.Drawing.Point(19, 240)
Me.LabelControl72.Name = "LabelControl72"
Me.LabelControl72.Size = New System.Drawing.Size(41, 16)
Me.LabelControl72.TabIndex = 55
Me.LabelControl72.Text = "Gender"
'
'CheckEdit6
'
Me.CheckEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_newsletter", true))
Me.CheckEdit6.Enabled = false
Me.CheckEdit6.Location = New System.Drawing.Point(170, 414)
Me.CheckEdit6.Name = "CheckEdit6"
Me.CheckEdit6.Properties.Caption = "NewsLetter"
Me.CheckEdit6.Properties.ValueChecked = 1
Me.CheckEdit6.Properties.ValueUnchecked = 0
Me.CheckEdit6.RightToLeft = System.Windows.Forms.RightToLeft.No
Me.CheckEdit6.Size = New System.Drawing.Size(154, 21)
Me.CheckEdit6.TabIndex = 51
'
'TextEdit16
'
Me.TextEdit16.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_gender", true))
Me.TextEdit16.Enabled = false
Me.TextEdit16.Location = New System.Drawing.Point(173, 237)
Me.TextEdit16.Name = "TextEdit16"
Me.TextEdit16.Size = New System.Drawing.Size(33, 22)
Me.TextEdit16.TabIndex = 54
'
'LabelControl73
'
Me.LabelControl73.Location = New System.Drawing.Point(396, 332)
Me.LabelControl73.Name = "LabelControl73"
Me.LabelControl73.Size = New System.Drawing.Size(95, 16)
Me.LabelControl73.TabIndex = 49
Me.LabelControl73.Text = "Points Parainage"
'
'LabelControl74
'
Me.LabelControl74.Location = New System.Drawing.Point(396, 210)
Me.LabelControl74.Name = "LabelControl74"
Me.LabelControl74.Size = New System.Drawing.Size(52, 16)
Me.LabelControl74.TabIndex = 53
Me.LabelControl74.Text = "years old"
'
'TextEdit17
'
Me.TextEdit17.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.wishlist_kind", true))
Me.TextEdit17.Enabled = false
Me.TextEdit17.Location = New System.Drawing.Point(526, 300)
Me.TextEdit17.Name = "TextEdit17"
Me.TextEdit17.Size = New System.Drawing.Size(182, 22)
Me.TextEdit17.TabIndex = 48
'
'LabelControl75
'
Me.LabelControl75.Appearance.ForeColor = System.Drawing.Color.DarkRed
Me.LabelControl75.Appearance.Options.UseForeColor = true
Me.LabelControl75.Cursor = System.Windows.Forms.Cursors.Hand
Me.LabelControl75.Location = New System.Drawing.Point(239, 33)
Me.LabelControl75.Name = "LabelControl75"
Me.LabelControl75.Size = New System.Drawing.Size(121, 16)
Me.LabelControl75.TabIndex = 51
Me.LabelControl75.Text = " Set a new password"
'
'LabelControl76
'
Me.LabelControl76.Location = New System.Drawing.Point(396, 303)
Me.LabelControl76.Name = "LabelControl76"
Me.LabelControl76.Size = New System.Drawing.Size(75, 16)
Me.LabelControl76.TabIndex = 47
Me.LabelControl76.Text = "WishList Kind"
'
'LabelControl77
'
Me.LabelControl77.Appearance.ForeColor = System.Drawing.Color.DarkRed
Me.LabelControl77.Appearance.Options.UseForeColor = true
Me.LabelControl77.Cursor = System.Windows.Forms.Cursors.Hand
Me.LabelControl77.Location = New System.Drawing.Point(173, 33)
Me.LabelControl77.Name = "LabelControl77"
Me.LabelControl77.Size = New System.Drawing.Size(33, 16)
Me.LabelControl77.TabIndex = 50
Me.LabelControl77.Text = "Logas"
'
'TextEdit18
'
Me.TextEdit18.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customer_attributes.number_of_logins", true))
Me.TextEdit18.Enabled = false
Me.TextEdit18.Location = New System.Drawing.Point(173, 363)
Me.TextEdit18.Name = "TextEdit18"
Me.TextEdit18.Size = New System.Drawing.Size(182, 22)
Me.TextEdit18.TabIndex = 46
'
'LabelControl78
'
Me.LabelControl78.Location = New System.Drawing.Point(19, 155)
Me.LabelControl78.Name = "LabelControl78"
Me.LabelControl78.Size = New System.Drawing.Size(35, 16)
Me.LabelControl78.TabIndex = 49
Me.LabelControl78.Text = "E-Mail"
'
'LabelControl79
'
Me.LabelControl79.Location = New System.Drawing.Point(17, 365)
Me.LabelControl79.Name = "LabelControl79"
Me.LabelControl79.Size = New System.Drawing.Size(79, 16)
Me.LabelControl79.TabIndex = 45
Me.LabelControl79.Text = "Nbr of Logons"
'
'LookUpEdit8
'
Me.LookUpEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.EntityID", true))
Me.LookUpEdit8.Enabled = false
Me.LookUpEdit8.Location = New System.Drawing.Point(173, 87)
Me.LookUpEdit8.Name = "LookUpEdit8"
Me.LookUpEdit8.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.LookUpEdit8.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit8.Properties.DataSource = Me.objDS.generalentity
Me.LookUpEdit8.Properties.DisplayMember = "Name"
Me.LookUpEdit8.Properties.NullText = ""
Me.LookUpEdit8.Properties.ValueMember = "EntityID"
Me.LookUpEdit8.Size = New System.Drawing.Size(269, 22)
Me.LookUpEdit8.TabIndex = 44
'
'LabelControl80
'
Me.LabelControl80.Location = New System.Drawing.Point(17, 337)
Me.LabelControl80.Name = "LabelControl80"
Me.LabelControl80.Size = New System.Drawing.Size(61, 16)
Me.LabelControl80.TabIndex = 44
Me.LabelControl80.Text = "Last Logon"
'
'LabelControl81
'
Me.LabelControl81.Location = New System.Drawing.Point(18, 90)
Me.LabelControl81.Name = "LabelControl81"
Me.LabelControl81.Size = New System.Drawing.Size(31, 16)
Me.LabelControl81.TabIndex = 43
Me.LabelControl81.Text = "Entity"
'
'LabelControl82
'
Me.LabelControl82.Location = New System.Drawing.Point(336, 59)
Me.LabelControl82.Name = "LabelControl82"
Me.LabelControl82.Size = New System.Drawing.Size(45, 16)
Me.LabelControl82.TabIndex = 42
Me.LabelControl82.Text = "Created"
'
'LookUpEdit9
'
Me.LookUpEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_language", true))
Me.LookUpEdit9.Enabled = false
Me.LookUpEdit9.Location = New System.Drawing.Point(173, 300)
Me.LookUpEdit9.Name = "LookUpEdit9"
Me.LookUpEdit9.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.LookUpEdit9.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
Me.LookUpEdit9.Properties.DataSource = Me.objDS.languages
Me.LookUpEdit9.Properties.DisplayMember = "name"
Me.LookUpEdit9.Properties.NullText = ""
Me.LookUpEdit9.Properties.ValueMember = "languages_id"
Me.LookUpEdit9.Size = New System.Drawing.Size(182, 22)
Me.LookUpEdit9.TabIndex = 17
'
'DateEdit5
'
Me.DateEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_info_date_account_created", true))
Me.DateEdit5.EditValue = Nothing
Me.DateEdit5.Enabled = false
Me.DateEdit5.Location = New System.Drawing.Point(451, 59)
Me.DateEdit5.Name = "DateEdit5"
Me.DateEdit5.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
Me.DateEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.DateEdit5.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.DateEdit5.Size = New System.Drawing.Size(173, 22)
Me.DateEdit5.TabIndex = 41
'
'LabelControl83
'
Me.LabelControl83.Location = New System.Drawing.Point(17, 309)
Me.LabelControl83.Name = "LabelControl83"
Me.LabelControl83.Size = New System.Drawing.Size(55, 16)
Me.LabelControl83.TabIndex = 16
Me.LabelControl83.Text = "Language"
'
'TextEdit19
'
Me.TextEdit19.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone", true))
Me.TextEdit19.Enabled = false
Me.TextEdit19.Location = New System.Drawing.Point(173, 179)
Me.TextEdit19.Name = "TextEdit19"
Me.TextEdit19.Size = New System.Drawing.Size(269, 22)
Me.TextEdit19.TabIndex = 20
'
'HyperLinkEdit1
'
Me.HyperLinkEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_email_address", true))
Me.HyperLinkEdit1.Enabled = false
Me.HyperLinkEdit1.Location = New System.Drawing.Point(173, 151)
Me.HyperLinkEdit1.Name = "HyperLinkEdit1"
Me.HyperLinkEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
Me.HyperLinkEdit1.Size = New System.Drawing.Size(528, 22)
Me.HyperLinkEdit1.TabIndex = 19
'
'TextEdit20
'
Me.TextEdit20.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_telephone_evening", true))
Me.TextEdit20.Enabled = false
Me.TextEdit20.Location = New System.Drawing.Point(451, 179)
Me.TextEdit20.Name = "TextEdit20"
Me.TextEdit20.Size = New System.Drawing.Size(250, 22)
Me.TextEdit20.TabIndex = 18
'
'LabelControl84
'
Me.LabelControl84.Location = New System.Drawing.Point(19, 181)
Me.LabelControl84.Name = "LabelControl84"
Me.LabelControl84.Size = New System.Drawing.Size(100, 16)
Me.LabelControl84.TabIndex = 16
Me.LabelControl84.Text = "Tel Day / Evening"
'
'CheckEdit7
'
Me.CheckEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_abo", true))
Me.CheckEdit7.Enabled = false
Me.CheckEdit7.Location = New System.Drawing.Point(634, 59)
Me.CheckEdit7.Name = "CheckEdit7"
Me.CheckEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Red
Me.CheckEdit7.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Bold)
Me.CheckEdit7.Properties.Appearance.Options.UseBackColor = true
Me.CheckEdit7.Properties.Appearance.Options.UseFont = true
Me.CheckEdit7.Properties.Caption = "ABO"
Me.CheckEdit7.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
Me.CheckEdit7.Properties.ValueChecked = 1
Me.CheckEdit7.Properties.ValueUnchecked = 0
Me.CheckEdit7.Size = New System.Drawing.Size(67, 26)
Me.CheckEdit7.TabIndex = 15
'
'LabelControl85
'
Me.LabelControl85.Location = New System.Drawing.Point(19, 210)
Me.LabelControl85.Name = "LabelControl85"
Me.LabelControl85.Size = New System.Drawing.Size(71, 16)
Me.LabelControl85.TabIndex = 11
Me.LabelControl85.Text = "Date of Birth"
'
'DateEdit6
'
Me.DateEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_dob", true))
Me.DateEdit6.EditValue = Nothing
Me.DateEdit6.Enabled = false
Me.DateEdit6.Location = New System.Drawing.Point(173, 207)
Me.DateEdit6.Name = "DateEdit6"
Me.DateEdit6.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
Me.DateEdit6.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
Me.DateEdit6.Size = New System.Drawing.Size(153, 22)
Me.DateEdit6.TabIndex = 10
'
'TextEdit21
'
Me.TextEdit21.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_firstname", true))
Me.TextEdit21.Enabled = false
Me.TextEdit21.Location = New System.Drawing.Point(451, 123)
Me.TextEdit21.Name = "TextEdit21"
Me.TextEdit21.Size = New System.Drawing.Size(250, 22)
Me.TextEdit21.TabIndex = 9
'
'TextEdit22
'
Me.TextEdit22.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_lastname", true))
Me.TextEdit22.Enabled = false
Me.TextEdit22.Location = New System.Drawing.Point(173, 123)
Me.TextEdit22.Name = "TextEdit22"
Me.TextEdit22.Size = New System.Drawing.Size(269, 22)
Me.TextEdit22.TabIndex = 7
'
'LabelControl86
'
Me.LabelControl86.Location = New System.Drawing.Point(19, 127)
Me.LabelControl86.Name = "LabelControl86"
Me.LabelControl86.Size = New System.Drawing.Size(33, 16)
Me.LabelControl86.TabIndex = 6
Me.LabelControl86.Text = "Name"
'
'TextEdit23
'
Me.TextEdit23.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.objDS, "customers.customers_id", true))
Me.TextEdit23.Enabled = false
Me.TextEdit23.Location = New System.Drawing.Point(173, 59)
Me.TextEdit23.Name = "TextEdit23"
Me.TextEdit23.Properties.ReadOnly = true
Me.TextEdit23.Size = New System.Drawing.Size(153, 22)
Me.TextEdit23.TabIndex = 5
'
'LabelControl87
'
Me.LabelControl87.Location = New System.Drawing.Point(19, 62)
Me.LabelControl87.Name = "LabelControl87"
Me.LabelControl87.Size = New System.Drawing.Size(71, 16)
Me.LabelControl87.TabIndex = 4
Me.LabelControl87.Text = "Customer ID"
'
'SimpleButton9
'
Me.SimpleButton9.Location = New System.Drawing.Point(1187, 417)
Me.SimpleButton9.Name = "SimpleButton9"
Me.SimpleButton9.Size = New System.Drawing.Size(173, 26)
Me.SimpleButton9.TabIndex = 2
Me.SimpleButton9.Text = "Stop NOW"
'
'SimpleButton10
'
Me.SimpleButton10.Location = New System.Drawing.Point(1187, 150)
Me.SimpleButton10.Name = "SimpleButton10"
Me.SimpleButton10.Size = New System.Drawing.Size(173, 27)
Me.SimpleButton10.TabIndex = 3
Me.SimpleButton10.Text = "Stop @ Reconduction"
'
'LabelControl12
'
Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.LabelControl12.Appearance.Options.UseFont = true
Me.LabelControl12.Location = New System.Drawing.Point(563, 26)
Me.LabelControl12.Name = "LabelControl12"
Me.LabelControl12.Size = New System.Drawing.Size(101, 21)
Me.LabelControl12.TabIndex = 1
Me.LabelControl12.Text = "Rating Moyen"
'
'LabelControl13
'
Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
Me.LabelControl13.Appearance.Options.UseFont = true
Me.LabelControl13.Location = New System.Drawing.Point(609, 53)
Me.LabelControl13.Name = "LabelControl13"
Me.LabelControl13.Size = New System.Drawing.Size(13, 28)
Me.LabelControl13.TabIndex = 2
Me.LabelControl13.Text = "0"
'
'GridControl3
'
Me.GridControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
Me.GridControl3.EmbeddedNavigator.Name = ""
Me.GridControl3.FormsUseDefaultLookAndFeel = false
Me.GridControl3.Location = New System.Drawing.Point(3, 3)
Me.GridControl3.MainView = Me.GridView3
Me.GridControl3.Name = "GridControl3"
Me.GridControl3.Size = New System.Drawing.Size(400, 286)
Me.GridControl3.TabIndex = 0
Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
'
'GridView3
'
Me.GridView3.GridControl = Me.GridControl3
Me.GridView3.Name = "GridView3"
'
'frmCustomers_Maint
'
Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
Me.AutoScroll = true
Me.ClientSize = New System.Drawing.Size(1262, 882)
Me.Controls.Add(Me.XTabCustomers)
Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
Me.Name = "frmCustomers_Maint"
Me.Text = ""
Me.Controls.SetChildIndex(Me.XTabCustomers, 0)
Me.Controls.SetChildIndex(Me.StatusBar1, 0)
CType(Me.PrintSystem1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MainDataSet,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbViewListRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtQuickSearchRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbReportListRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbFilterListRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDefaultListRepos,System.ComponentModel.ISupportInitialize).EndInit
CType(GridchkAbo,System.ComponentModel.ISupportInitialize).EndInit
CType(GridchkBlackList,System.ComponentModel.ISupportInitialize).EndInit
Me.tabAboProcessOld.ResumeLayout(false)
CType(Me.GridAboprocessOld,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewAboprocessOld,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNextCredit.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNextPrice.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.objDS,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewGodson,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridSon,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewSon,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryISponsorCustomers_id,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit5.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.tabMailHistory.ResumeLayout(false)
CType(Me.grpContEmail,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewMail,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridCustServ,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.gridViewCustServ,System.ComponentModel.ISupportInitialize).EndInit
Me.tabDroselia.ResumeLayout(false)
Me.tabDroselia.PerformLayout
CType(Me.txtDroselia.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridDroselia,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewDroselia,System.ComponentModel.ISupportInitialize).EndInit
Me.tabPaymentMovements.ResumeLayout(false)
CType(Me.GCBankAccountMovement,System.ComponentModel.ISupportInitialize).EndInit
Me.GCBankAccountMovement.ResumeLayout(false)
CType(Me.GridBankAccountMovements,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewBankAccountMovements,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryCmbMatching,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridOrders,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewOrders,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryIbtnCheckOrder,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridABO,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewABO,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryItemLookUpEdit5,System.ComponentModel.ISupportInitialize).EndInit
Me.tabPayment.ResumeLayout(false)
Me.tabPayment.PerformLayout
CType(Me.GridPayment,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewPayment,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.checkOpenPayment.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GroupOgone,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupOgone.ResumeLayout(false)
CType(Me.PanelOgone,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelOgone.ResumeLayout(false)
Me.PanelOgone.PerformLayout
CType(Me.txt_cc_expiration_date2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmb_cc_expiration_status2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txt_cc_card_type2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txt_cc_card_no2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txt_cc_owner2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GroupDomiciliation,System.ComponentModel.ISupportInitialize).EndInit
Me.GroupDomiciliation.ResumeLayout(false)
CType(Me.panelDomiciliation,System.ComponentModel.ISupportInitialize).EndInit
Me.panelDomiciliation.ResumeLayout(false)
Me.panelDomiciliation.PerformLayout
CType(Me.txtDomAcctNumber.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDomNumber.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDomDebiterName.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDomStatus.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.CalcEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.CalcEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbPayMethod.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridWishList,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewWishList,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.btnSendIt,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.checkAvailibility,System.ComponentModel.ISupportInitialize).EndInit
Me.tabCustServ.ResumeLayout(false)
CType(Me.PanelControl7,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl7.ResumeLayout(false)
CType(Me.PanelControl8,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl8.ResumeLayout(false)
CType(Me.LayoutCustServ,System.ComponentModel.ISupportInitialize).EndInit
Me.LayoutCustServ.ResumeLayout(false)
CType(Me.txtCustServ_Response_Message.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCustServ_DVD_ID.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCustServ_Products_id.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCustServ_OrderID.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCustServ_CustDate.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCustServ_CustDate.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MemoEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCustServ_Subject.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LayoutControlGroup1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LCGMisc,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LayoutControlItem7,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LayoutControlItem6,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LayoutControlItem8,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LayoutControlGroup3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LayoutControlItem5,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LayoutControlItem4,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LCGResponse,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LayoutControlItem11,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LayoutControlItem3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GCCustServ,System.ComponentModel.ISupportInitialize).EndInit
Me.GCCustServ.ResumeLayout(false)
CType(Me.chkCustServSendMail.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridWishListAssigned,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewWishListAssigned,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryIbtnAddDVD,System.ComponentModel.ISupportInitialize).EndInit
Me.tabOrdersHistor.ResumeLayout(false)
CType(Me.SplitContainerOrders,System.ComponentModel.ISupportInitialize).EndInit
Me.SplitContainerOrders.ResumeLayout(false)
CType(Me.GridOrdersStatusHistory,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewOrdersHistory,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewSearch,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryICustomersCustomers_id,System.ComponentModel.ISupportInitialize).EndInit
Me.tabAboHistory.ResumeLayout(false)
Me.tabWishList.ResumeLayout(false)
CType(Me.GCWishlistAssigned,System.ComponentModel.ISupportInitialize).EndInit
Me.GCWishlistAssigned.ResumeLayout(false)
CType(Me.PanelControl11,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl11.ResumeLayout(false)
CType(Me.PanelDetailWishlist,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelDetailWishlist.ResumeLayout(false)
CType(Me.gridInfoAdult,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewInfoAdult,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.gridInfoNorm,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewInfoNorm,System.ComponentModel.ISupportInitialize).EndInit
Me.tabMain.ResumeLayout(false)
Me.tabMain.PerformLayout
CType(Me.chksleep.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ChkCreditCombined.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkFt.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GCACtPhone,System.ComponentModel.ISupportInitialize).EndInit
Me.GCACtPhone.ResumeLayout(false)
Me.GCACtPhone.PerformLayout
CType(Me.MemoOtherReason.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbPhoneActivDelete.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateCallPhoneActivation.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateCallPhoneActivation.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GCAboInfo,System.ComponentModel.ISupportInitialize).EndInit
Me.GCAboInfo.ResumeLayout(false)
Me.GCAboInfo.PerformLayout
CType(Me.cmbDiscountActivation.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDiscType.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEndOfHoliday.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEndOfHoliday.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbSuspended.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtRegistrationStep.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDVDAdultAtHome.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDiscRecurring.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDiscRecurring.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkAutoStop.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbNextDiscCode.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkMultiShipment.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbNextABO.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDVDNormAtHome.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDVDAdult.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDVDNorm.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtABOCredit.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtAbo_ValidityTo.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtAbo_ValidityTo.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbABO.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GCadresse,System.ComponentModel.ISupportInitialize).EndInit
Me.GCadresse.ResumeLayout(false)
Me.GCadresse.PerformLayout
CType(Me.txtDate_added_Current.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridAddress,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewAddress,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDeliveryFirstName.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDeliveryLastName.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbDeliverycountry.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDeliveryCity.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDeliveryPostCode.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDeliveryAddr.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GCcustomersInfo,System.ComponentModel.ISupportInitialize).EndInit
Me.GCcustomersInfo.ResumeLayout(false)
Me.GCcustomersInfo.PerformLayout
CType(Me.chkCreditReceivedBySite.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkOnly_VOD.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtLast_logon.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtPtSponsorShip.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkRedListed.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtComment.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkBlackListed.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtYearsOld.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkNewsLetterPartner.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.chkNewsLetter.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtGender.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtWishListKind.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtNbrOfLogons.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbEntity.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.cmbLanguage.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDateCreated.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtDateCreated.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtTel.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtEMail.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtTelEvening.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtABO.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateBirthday.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateBirthday.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtFirstName.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtLastName.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCustomers_id.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.tabSearch.ResumeLayout(false)
CType(Me.PanelControl1,System.ComponentModel.ISupportInitialize).EndInit
Me.PanelControl1.ResumeLayout(false)
Me.PanelControl1.PerformLayout
CType(Me.TxtCustomers_NumComm.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtcustomers_domiciliation_number_search.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtcustomers_postcode_search.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtcustomers_address_street_search.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtcustomers_email_address_search.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtcustomers_name_search.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtcustomers_id_search.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.XTabCustomers,System.ComponentModel.ISupportInitialize).EndInit
Me.XTabCustomers.ResumeLayout(false)
Me.tabComment.ResumeLayout(false)
CType(Me.MemoCustomersComment.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridCustComment,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewCustComment,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MemoInsertComment.Properties,System.ComponentModel.ISupportInitialize).EndInit
Me.tabCalls.ResumeLayout(false)
Me.tabMessagerie.ResumeLayout(false)
Me.tabSponsorShip.ResumeLayout(false)
CType(Me.GCCodeLinked,System.ComponentModel.ISupportInitialize).EndInit
Me.GCCodeLinked.ResumeLayout(false)
CType(Me.GridCodeLinked,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewCodeLinked,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GCSponsonCard,System.ComponentModel.ISupportInitialize).EndInit
Me.GCSponsonCard.ResumeLayout(false)
Me.GCSponsonCard.PerformLayout
CType(Me.txtCard5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCard4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCard3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCard2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.txtCard1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.grpCustomersPoint,System.ComponentModel.ISupportInitialize).EndInit
Me.grpCustomersPoint.ResumeLayout(false)
CType(Me.GridCustPointHistory,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewCustPointHistory,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GCGift,System.ComponentModel.ISupportInitialize).EndInit
Me.GCGift.ResumeLayout(false)
CType(Me.GridGift,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewGift,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GCSponsorShip,System.ComponentModel.ISupportInitialize).EndInit
Me.GCSponsorShip.ResumeLayout(false)
Me.GCSponsorShip.PerformLayout
CType(Me.GridGodFather,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridviewGodFather,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.RepositoryISponsorGodCustomers_id,System.ComponentModel.ISupportInitialize).EndInit
Me.tabAboprocess.ResumeLayout(false)
CType(Me.gridAboprocess,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewAboprocess,System.ComponentModel.ISupportInitialize).EndInit
Me.tabPurchase.ResumeLayout(false)
CType(Me.GridShoppingOrders,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewShoppingOrders,System.ComponentModel.ISupportInitialize).EndInit
Me.tabCreditHist.ResumeLayout(false)
CType(Me.GridCreditHistory,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewCreditHistory,System.ComponentModel.ISupportInitialize).EndInit
Me.tabCompensation.ResumeLayout(false)
CType(Me.GridCompensation,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewCompensation,System.ComponentModel.ISupportInitialize).EndInit
Me.tabProductsRating.ResumeLayout(false)
CType(Me.GridProductsRating,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewProductsRating,System.ComponentModel.ISupportInitialize).EndInit
Me.tabSuspendedHistory.ResumeLayout(false)
CType(Me.GridSuspendedHistory,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewSuspendedHistory,System.ComponentModel.ISupportInitialize).EndInit
Me.tabVodView.ResumeLayout(false)
CType(Me.GridViewVod,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
Me.tabCritiques.ResumeLayout(false)
Me.tabCritiques.PerformLayout
CType(Me.GridCritiques,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridViewCritiques,System.ComponentModel.ISupportInitialize).EndInit
Me.tabConfig.ResumeLayout(false)
CType(Me.ChkListConfig,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.MemoEdit2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit1.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.ComboBoxEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit2.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SpinEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit3.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.CheckEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit7.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.CheckEdit2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SpinEdit2.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SpinEdit3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SpinEdit4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SpinEdit5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit4.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridControl2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView2,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit8.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit9.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit7.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit10.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit11.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit12.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit13.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.SpinEdit6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.CheckEdit3.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit14.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.CheckEdit4.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit15.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.CheckEdit5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.CheckEdit6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit16.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit17.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit18.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit8.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.LookUpEdit9.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit5.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit5.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit19.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.HyperLinkEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit20.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.CheckEdit7.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit6.Properties.VistaTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.DateEdit6.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit21.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit22.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.TextEdit23.Properties,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridControl3,System.ComponentModel.ISupportInitialize).EndInit
CType(Me.GridView3,System.ComponentModel.ISupportInitialize).EndInit
Me.ResumeLayout(false)

End Sub

#End Region
    Dim sSQL As String

    Private ReadOnly Property lang_id() As Integer
        Get
            Return cmbLanguage.EditValue
        End Get

    End Property
    Public Sub New(ByVal CurrentSessionInfo As BizzLib.clsSessionInfo)
        MyBase.New(CurrentSessionInfo)
        InitializeComponent()

    End Sub
    ' Dim KeyDataSet As String = "BizzLib.dsGeneral" 'The Dataset used 
    Public _CurrentCustomerID As Integer
    Dim MainData As ClsCustomersInfo.clsCustomer
    Dim modeEdit As Boolean = False
    Dim _dataSet As New DataSet()
    Dim refreshTab As New List(Of Boolean)
    Dim _saveCustomersComment As Boolean

    Dim _oldCredit As Integer
    Dim _newCredit As Integer
    Dim _oldMgm As Integer
    Dim _newMgm As Integer
    Dim _old_date_Holiday As Date
    Dim _oldSuspended As Integer
    Private _lstSuspended As New List(Of DVDPostBuziness.clsKeyCombo)
    Private _loadInfo As Boolean


    Public Sub Local_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim menuStrip As New DVDPostBuziness.contextMenu()

        'MemoInsertComment.Properties.WordWrap

        GridControl1.ContextMenuStrip = menuStrip
        GridAddress.ContextMenuStrip = menuStrip
        GridWishList.ContextMenuStrip = menuStrip
        GridWishListAssigned.ContextMenuStrip = menuStrip
        GridCustComment.ContextMenuStrip = menuStrip
        GridABO.ContextMenuStrip = menuStrip
        GridOrders.ContextMenuStrip = menuStrip
        GridOrdersStatusHistory.ContextMenuStrip = menuStrip
        GridCustServ.ContextMenuStrip = menuStrip
        GridPayment.ContextMenuStrip = menuStrip
        GridBankAccountMovements.ContextMenuStrip = menuStrip
        GridAboprocessOld.ContextMenuStrip = menuStrip
        grpContEmail.ContextMenuStrip = menuStrip
        GridShoppingOrders.ContextMenuStrip = menuStrip
        GridCreditHistory.ContextMenuStrip = menuStrip
        GridCodeLinked.ContextMenuStrip = menuStrip
        GridSon.ContextMenuStrip = menuStrip
        GridGodFather.ContextMenuStrip = menuStrip
        GridGift.ContextMenuStrip = menuStrip
        GridCustPointHistory.ContextMenuStrip = menuStrip
        GridCompensation.ContextMenuStrip = menuStrip
        GridProductsRating.ContextMenuStrip = menuStrip
        GridSuspendedHistory.ContextMenuStrip = menuStrip
        GridDroselia.ContextMenuStrip = menuStrip
        GridViewVod.ContextMenuStrip = menuStrip
        GridCritiques.ContextMenuStrip = menuStrip

        clsDevExpress.AddHyperlinkDynamic(GridWishList)
        clsDevExpress.AddHyperlinkDynamic(GridWishListAssigned)
        clsDevExpress.AddHyperlinkDynamic(GridOrders)
        clsDevExpress.AddHyperlinkDynamic(GridPayment)
        clsDevExpress.AddHyperlinkDynamic(GridBankAccountMovements)
        clsDevExpress.AddHyperlinkDynamic(gridAboprocess)
        clsDevExpress.AddHyperlinkDynamic(GridAboprocessOld)
        clsDevExpress.AddHyperlinkDynamic(GridSon)
        clsDevExpress.AddHyperlinkDynamic(GridGodFather)
        clsDevExpress.AddHyperlinkDynamic(GridCompensation)
        clsDevExpress.AddHyperlinkDynamic(GridProductsRating)
        clsDevExpress.AddHyperlinkDynamic(GridViewVod)


        Me._dataSet.Tables.Add("reason_to_stop") ' for stop the abo with the button "stop abo"

        Me.lblAboSumP.Visible = False
        GCACtPhone.Visible = False


        Try
            'SetUp of Variables
            KeyFieldName = "customers_lastname"
            IDField = "customers_id"
            TableName = "customers"
            MainDataSet = objDS
            MyBase.RaiseEventForReportDesigner = True
            HelpProvider1.HelpNamespace = ".\Help\" & SessionInfo.UserLang & "\BizzKeys.chm"
            'Attempt to load the dataset.
            Me.LoadBKComboSet()
            BKGlobal.LoadAssociatedMenu(Me.Tag, PopMenuAssociatedTasks, Me)
            btnNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            DefaultSet_Bar.Visible = False
            Filter_Bar.Visible = False
            Misc_Bar2.Visible = False
            GridViewWishList.ExpandAllGroups()
   
            XTabCustomers.SelectedTabPage = tabSearch
            btnForcedReconduction.Visible = DvdPostData.clsSession.isAdmin
            loadTypeMatching()
            EnablingEditFields(False)
            HideAllTab()

        Catch eLoad As System.Exception
            'Add your error handling code here.
            'Display error message, if any.
            System.Windows.Forms.MessageBox.Show(eLoad.Message)
        End Try
    End Sub

    Private Sub EditRecord(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuEdit.Click, MyBase.EventEditRecord
        If Me.BindingContext(objDS, TableName).Position < 0 Then
            Exit Sub
        End If
        _oldCredit = txtABOCredit.EditValue
        _newCredit = txtABOCredit.EditValue
        _oldMgm = txtPtSponsorShip.EditValue
        _newMgm = txtPtSponsorShip.EditValue
        _oldSuspended = cmbSuspended.EditValue
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
        If _CurrentCustomerID > 0 Then
            LoadCustomerInfo()
        End If
        OpenType = "BROWSE"

    End Sub
    Private Sub SaveChanges(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles PopMenuSave.Click, MyBase.EventSaveChanges

        Try
            
            Me.UpdateDataSet()
            SetState(BrowseState)
            PopMenuNew.Enabled = True
            PopMenuEdit.Enabled = True
            PopMenuSave.Enabled = False
            PopMenuDelete.Enabled = True
            PopMenuUndo.Enabled = False
            EnablingAll(False)
            OpenType = "BROWSE"
        Catch eUpdate As System.Exception
            MsgBox("Error Save Data " & eUpdate.Message, MsgBoxStyle.Critical)
        Finally
        End Try
    End Sub


    Private Function UpdateCreditHistory() As Boolean
        _newCredit = txtABOCredit.EditValue
        Dim update As Boolean = False
        If _oldCredit <> _newCredit Then

            If Math.Abs(calculCredit(_oldCredit, _newCredit)) >= 5 Then
                If MsgBox("Update Credit " & _oldCredit & " -> " & _newCredit, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    update = True
                End If
            Else
                update = True
            End If
        Else
           return True 
        End If

        If update Then
            addCreditToCustomers(calculCredit(_oldCredit, _newCredit), _CurrentCustomerID, DvdPostData.clsCreditHistory.ActionId.MANUAL_CREDIT, _oldCredit)
        End If

        Return update
    End Function
    Public Sub UpdateDataSet() Handles MyBase.EventUpdateDataset
        If objDS.Tables(TableName).Rows.Count = 0 Then Return
        Try
            DvdPostData.clsConnection.CreateTransaction(False)

            _newMgm = txtPtSponsorShip.EditValue
            If _newMgm <> _oldMgm Then
                DvdPostData.clsConnection.ExecuteNonQuery(DvdPostData.clsMemberGetMember.insertCustomersPointHist(_CurrentCustomerID, DvdPostData.clsMemberGetMember.PointsHistoryAction.ADD, DvdPostData.clsMemberGetMember.PointsHistorySubAction.POINT_MANUAL_ALLOCATION, calculCredit(_oldMgm, _newMgm)))
                refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            End If
            suspended()
            If Not UpdateCreditHistory() Then
                DvdPostData.clsConnection.CommitTransaction(False)
                refreshClient()
                Return
            End If
            updateInsertPhoneActivation(False)

            Me.BindingContext(objDS, TableName).EndCurrentEdit()
            Me.BindingContext(objDS, "address_book_default").EndCurrentEdit()
            Me.BindingContext(objDS, "customer_attributes").EndCurrentEdit()

            ' DvdPostData.clsConnection.UpdateDataTableInDB(objDS.Tables(TableName), "SELECT * FROM customers where customers_id = " & _CurrentCustomerID)
            MainData.Save()


            DvdPostData.clsConnection.CommitTransaction(True)

            refreshClient()

        Catch ex As Exception
            DvdPostData.clsConnection.CommitTransaction(False)
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.SignaletiqueCustomer, ex)
            Throw ex
        End Try
    End Sub




    Public Sub LoadBKComboSet()
        Try
            BKCombo.GetCombo(objDS, "country", "countries_name", "SELECT * FROM country")
            BKCombo.GetCombo(objDS, "products_abo", "products_id", "SELECT products_id, products_model, products_title FROM products where products_type = 'ABO' ")
            ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("abo_action"), "SELECT * FROM abo_action")
            ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_status"), "SELECT * FROM orders_status WHERE language_id = 1 ")
            ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("orders_products_status"), "SELECT * FROM orders_products_status")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("discount_code"), "SELECT discount_code code ,discount_code_id code_id,dc.* FROM discount_code dc ")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("languages"), "SELECT * FROM languages")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("generalentity"), "SELECT EntityID, name, description, currcode FROM generalentity")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("customers_abo_payment_method"), "SELECT * FROM customers_abo_payment_method c")
            If Not objDS.Tables.Contains("User_dvdPost") Then objDS.Tables.Add("User_dvdPost")
            DvdPostData.clsConnection.FillDataSet(objDS.Tables("User_dvdPost"), "SELECT customers_id FROM securityuser where not customers_id is null")

            '  DvdPostData.clsConnection.FillDataSet(objDS.Tables("domiciliation_status"), "SELECT * FROM domiciliation_status  where language_id = 1")
            '   DvdPostData.clsConnection.FillDataSet(objDS.Tables("payment_status"), "SELECT * FROM payment_status ")
            '   DvdPostData.clsConnection.FillDataSet(objDS.Tables("ogone_payment_status"), "SELECT * FROM ogone_payment_status ")
            ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("cc_expiration_status"), "SELECT * FROM cc_expiration_status  where language_id = 1 ")
            '  DvdPostData.clsConnection.FillDataSet(objDS.Tables("custserv_cat"), "SELECT * FROM custserv_cat  where language_id = 1 ")
            '  DvdPostData.clsConnection.FillDataSet(objDS.Tables("payment_offline_status"), "SELECT * FROM payment_offline_status ")
            LoadSuspended()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#Region "Search"
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        UndoChanges(sender, e)
        Search()
    End Sub
    Public Sub Search()
        ' SendMail()
        Dim sql As String

        Dim customers_id As String
        Dim email As String
        Dim NameCustomer As String
        Dim streetCustomer As String
        Dim PostCodeCustomer As String
        Dim NumDom As String
        Dim NumComm As String

        Dim param As DVDPostBuziness.clsSingleton
        param = DVDPostBuziness.clsSingleton.Instance()

        If param.CustomersId <> Nothing Then
            customers_id = param.CustomersId
            param.CustomersId = Nothing
        Else
            customers_id = txtcustomers_id_search.Text.Trim
        End If


        email = txtcustomers_email_address_search.Text.Trim
        NameCustomer = txtcustomers_name_search.Text.Trim
        NumDom = txtcustomers_domiciliation_number_search.Text.Trim
        streetCustomer = txtcustomers_address_street_search.Text.Trim
        PostCodeCustomer = txtcustomers_postcode_search.Text.Trim
        NumComm = TxtCustomers_NumComm.Text.Trim
        sql = DvdPostData.ClsCustomersData.GetSelectCustomersSearch(customers_id, email, NameCustomer, streetCustomer, PostCodeCustomer, NumDom, NumComm)

        Dim dt As DataTable
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub
    Public Sub searchPhoneAct()
        ' Dim sqlPA As String = "SELECT distinct c.customers_id, c.customers_firstname, c.customers_lastname, c.customers_email_address, c.customers_abo,c.customers_abo_payment_method,c.customers_language," & _
        '" c.black_listed, ab.entry_street_address, ab.entry_postcode, c.domiciliation_number " & _
        '" FROM customers c,address_book ab" & _
        '" where( c.customers_registration_step = 100 and c.customers_abo = 0 and  c.customers_default_address_id = ab.address_book_id And c.customers_id = ab.customers_id And c.customers_abo_payment_method = 20) "

        ' objDS.Tables("customers_search_result").Clear()
        ' DvdPostData.clsConnection.FillDataSet(objDS.Tables("customers_search_result"), sqlPA)


        ' Dim row As DataRow



        ' For Each row In objDS.Tables("customers_search_result").Rows

        '     Dim custid As Integer
        '     custid = row.Item("customers_id")
        '     Dim _dsHistPhone As New DataSet
        '     Dim existcust As Boolean = exist(custid)
        '     _dsHistPhone.Tables.Add("hist_Phone_acti")
        '     If existcust Then
        '         DvdPostData.clsConnection.FillDataSet(_dsHistPhone.Tables("hist_Phone_acti"), "select * from historique_phone_activation where customers_id = '" & custid.ToString & "' ")
        '         row.Item("call_phone") = _dsHistPhone.Tables("hist_Phone_acti").Rows(0).Item("call_phone").ToString
        '     End If
        ' Next
        ' GridControl1.DataSource = objDS.Tables("customers_search_result")

        Dim dt As DataTable
        Dim sql As String

        sql = DvdPostData.clsPhoneActivation.GetPhoneActivation()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt

    End Sub
    Private Sub btnPhoneActivation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoneActivation.Click
        searchPhoneAct()
        reasonStopActPhone()
    End Sub

    Private Sub txtcustomers_id_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_id_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    Private Sub txtcustomers_name_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_name_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    Private Sub txtcustomers_email_address_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_email_address_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    Private Sub txtcustomers_domiciliation_number_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub

    Private Sub txtcustomers_address_street_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_address_street_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub

    Private Sub txtcustomers_postcode_search_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtcustomers_postcode_search.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            Search()
        End If
    End Sub
    Public Sub refreshClient()
        refreshTab.Clear()
        For Each tab As DevExpress.XtraTab.XtraTabPage In XTabCustomers.TabPages
            refreshTab.Add(True)
            'ChkListConfig.Items(1).Value   
        Next
        _saveCustomersComment = True

        LoadCustomerInfo()

    End Sub

    'Private Sub GridViewSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
    '    If GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle) Is Nothing Then Return
    '    _CurrentCustomerID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("customers_id")
    '    refreshClient()

    '    XTabCustomers.SelectedTabPage = tabMain
    'End Sub
#End Region

    Private Sub loadVod(ByVal index As Integer, ByVal customers_id As Integer)
        Dim sql As String
        If refreshTab(index) Then
            Try
                Dim dt As DataTable

                sql = DvdPostData.ClsVod.getViewVod(customers_id)
                dt = DvdPostData.clsConnection.FillDataSet(sql)
                GridViewVod.DataSource = dt
            Catch ex As Exception
                MsgBox("Num client is not valid")
            End Try
            refreshTab(index) = False
        End If
    End Sub
    Private Sub loadMessagerie(ByVal index As Integer, ByVal customers_id As Integer)

        If refreshTab(index) Then
            UcMessagerieCustomer.LoadMessagerie()
            refreshTab(index) = False
        End If
    End Sub
    Private Sub loadPayment(ByVal index As Integer, ByVal customers_id As Integer)
        Dim sql As String
        If refreshTab(index) Then
            Try

                Dim dt As DataTable

                sql = DvdPostData.ClsMatching.GetDataPayment(customers_id, checkOpenPayment.Checked)
                dt = DvdPostData.clsConnection.FillDataSet(sql)
                GridPayment.DataSource = dt
            Catch ex As Exception
                MsgBox("Num client is not valid" & ex.Message)
            End Try
            refreshTab(index) = False
        End If
    End Sub
    Private Sub loadTypeMatching()
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.ClsMatching.GetTypeMatching()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        RepositoryCmbMatching.DataSource = dt
        ' RepositoryCmbMatching.DisplayMember = "name"
        ' RepositoryCmbMatching.ValueMember = "id"


    End Sub

    Private Sub loadBankAccountMovement(ByVal index As Integer, ByVal customers_id As Integer)
        Dim sql As String
        Dim dt As DataTable
        If refreshTab(index) Then
            loadTypeMatching()

            sql = DvdPostData.ClsMatching.GetMatchingByall(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)

            GridBankAccountMovements.DataSource = dt
            refreshTab(index) = False
        End If

    End Sub

    Private Sub loadCritique(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt_reviews As DataTable
            Dim dt As DataTable
            Dim dr As DataRow

            dt_reviews = DVDPostBuziness.clsReviews.GetReviewCustomer(customers_id)
            GridCritiques.DataSource = dt_reviews
            GridViewCritiques.Columns("critique").OptionsColumn.FixedWidth = True
            GridViewCritiques.Columns("critique").Width = 700
            GridViewCritiques.BestFitColumns()
            clsDevExpress.AddHyperlinkDynamic(GridCritiques)
            clsDevExpress.AddCountFooter(GridCritiques)
            dt = DVDPostBuziness.clsReviews.GetAverageCritiqueCustomers(customers_id)

            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                lblValueNbCritiquePositive.Text = dr("cpt_critiques_positive")
                lblValueRatingAverage.Text = String.Format("{0:##}", dr("average_rating_critique"))
            End If

            dt = DVDPostBuziness.clsReviews.GetCritiqueCustomers(customers_id)
            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                lblValueNbCrtitiques.Text = dr("cpt_critiques")
                If dr("average_rating") Is DBNull.Value Then
                    lblValueAverageRatingDvdPost.Text = 0
                Else
                    lblValueAverageRatingDvdPost.Text = String.Format("{0:##}", dr("average_rating"))
                End If


            End If

            dt = DVDPostBuziness.clsReviews.GetRating(customers_id)
            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                lblValueRating.Text = dr("cpt_rating")
            End If


            refreshTab(index) = False
        End If
    End Sub
    Private Sub loadwishlist(ByVal index As Integer, ByVal customers_id As Integer, ByVal lang_id As Integer)

        If refreshTab(index) Then

            Dim sql As String
            Dim dt As DataTable
            sql = DvdPostData.ClsCustomersData.GetSelectWishlist(customers_id, lang_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridWishList.DataSource = dt
            GridViewWishList.BestFitColumns()
            GridViewWishList.ExpandAllGroups()

            sql = DvdPostData.ClsCustomersData.GetSelectWishlistAssigned(customers_id, lang_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridWishListAssigned.DataSource = dt

            GridViewWishListAssigned.BestFitColumns()
            GridViewWishListAssigned.ExpandAllGroups()

            sql = DvdPostData.ClsCustomersData.getSelectInfoWishlist(customers_id, DvdPostData.clsProductDvd.Type_DVD.DVD_NORM)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            gridInfoNorm.DataSource = dt

            sql = DvdPostData.ClsCustomersData.getSelectInfoWishlist(customers_id, DvdPostData.clsProductDvd.Type_DVD.DVD_ADULT)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            gridInfoAdult.DataSource = dt


            refreshTab(index) = False
        End If
    End Sub

    Private Sub loadOrders(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then

            Dim dt As New DataTable
            Dim sql As String = DvdPostData.clsOdersStatusHistory.GetOrdersByCustomers(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridOrders.DataSource = dt
            GridViewOrders.BestFitColumns()
            GridViewOrders.ExpandAllGroups()


            refreshTab(index) = False
        End If

    End Sub

    Private Sub loadOrderHistory(ByVal orders_id As Integer)
        Dim dt As New DataTable
        Dim sql As String = DvdPostData.clsOdersStatusHistory.GetOrderHistory(orders_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridOrdersStatusHistory.DataSource = dt
    End Sub

    Public Sub GridViewOders_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewOrders.FocusedRowChanged
        If GridViewOrders.RowCount <> 0 Then
            Dim oders_id As Integer = GridViewOrders.GetDataRow(GridViewOrders.FocusedRowHandle)("orders_id")
            loadOrderHistory(oders_id)
        Else
            GridOrdersStatusHistory.DataSource = Nothing
        End If
    End Sub

    Private Sub LoadSuspended()

        _lstSuspended.Add(New DVDPostBuziness.clsKeyCombo("HOLIDAY", 1))
        _lstSuspended.Add(New DVDPostBuziness.clsKeyCombo("SUSPENDED", 2))
        _lstSuspended.Add(New DVDPostBuziness.clsKeyCombo("", 0))
        Me.cmbSuspended.Properties.DataSource = _lstSuspended
        cmbSuspended.Enabled = False

    End Sub

    Private Sub loadAboHist(ByVal index As Integer, ByVal customers_id As Integer)

        If refreshTab(index) Then
            'Dim mvarAbo As ClsCustomersInfo.clsCustomerABO
            'mvarAbo = New ClsCustomersInfo.clsCustomerABO(SessionInfo, objDS, customers_id)

            Dim sql As String
            Dim dt As DataTable
            sql = DvdPostData.ClsCustomersData.getSelectAboHistory(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)

            GridABO.DataSource = dt
            refreshTab(index) = False
        End If
    End Sub

    Private Sub loadAttributesCustomer(ByVal customers_id As Integer)
        Dim sql As String
        sql = DvdPostData.ClsCustomersData.getSelectAttributes(customers_id)
        DvdPostData.clsConnection.FillDataSet(objDS.Tables("customer_attributes"), sql)

    End Sub
    Private Sub loadDiscountActivation(ByVal drCust As DataRow)

        Dim dt As DataTable
        If drCust("activation_discount_code_type") Is DBNull.Value OrElse drCust("activation_discount_code_type") = String.Empty Then
            cmbDiscountActivation.Properties.DataSource = Nothing
            cmbDiscType.SelectedIndex = 2
        ElseIf drCust("activation_discount_code_type") = "A" Then

            Dim sql As String

            sql = DvdPostData.ClsCustomersData.GetSelectActivationCode(drCust("activation_discount_code_id"))
            dt = DvdPostData.clsConnection.FillDataSet(sql)

            DVDPostBuziness.ClsCombo.addRowEmpty(dt)
            cmbDiscountActivation.Properties.DataSource = dt
            cmbDiscType.SelectedIndex = 0
            cmbDiscountActivation.Refresh()
        Else
            Dim dr As dsCustomerMaint.discount_codeRow
            If objDS.discount_code.Select("discount_code_id = 0").Length = 0 Then
                dr = objDS.discount_code.Newdiscount_codeRow()
                dr.discount_code_id = 0
                dr.discount_code = "empty"

                objDS.discount_code.Rows.Add(dr)
            End If
            dt = objDS.discount_code.Copy()


            cmbDiscountActivation.Properties.DataSource = dt
            cmbDiscType.SelectedIndex = 1
            cmbDiscountActivation.Refresh()

            End If
    End Sub
    Public Sub LoadCustomerInfo()
        _loadInfo = True

        objDS.Tables("customers").Clear()
        MainData = New ClsCustomersInfo.clsCustomer(SessionInfo, objDS, _CurrentCustomerID)
        Dim lst_dr() As DataRow = objDS.Tables("User_dvdPost").Select("customers_id = " & _CurrentCustomerID)
        DvdPostData.clsSession.isDVDPostUser = lst_dr.Length > 0


        Dim _ds As New DataSet()
        If objDS.Tables("customers").Rows.Count = 0 Then
            MsgBox("Ce client n'existe pas", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim drCust As DataRow = objDS.Tables("customers").Rows(0)
        'do visible txt summer power abo 12 mois
        Me.displayLblSummer(_CurrentCustomerID)
        Dim credit As Integer
        Dim price As String = ""
        Dim clscustomers As New DVDPostBuziness.ClsCustomers
        'clscustomers.aboStopDebug()
        clscustomers.GetInfoNextReconduction(_CurrentCustomerID, credit, price)
        txtNextCredit.EditValue = credit
        txtNextPrice.EditValue = price
        'visble group control phone activation
        VisiblePhoneActivation(_CurrentCustomerID)
        ' loadVodAccess(_CurrentCustomerID)
        If txtABO.Checked Then
            txtABO.BackColor = Drawing.Color.GreenYellow
        Else
            txtABO.BackColor = Drawing.Color.Red
        End If
        cmbSuspended.EditValue = drCust("customers_abo_suspended")
       
        'calcul the Age
        If drCust("customers_dob") IsNot (DBNull.Value) Then
            txtYearsOld.Text = calculAge(DateBirthday.EditValue)
        End If

        'to suspend holiday
        DateEndOfHoliday.EditValue = DvdPostData.clsConnection.ExecuteScalar(DvdPostData.clsAboSuspended.GetDateEndHoliday(_CurrentCustomerID))
        _old_date_Holiday = DateEndOfHoliday.EditValue
        Dim dt As DataTable
        dt = clscustomers.GetInfoAttributesCustomer(_CurrentCustomerID)
        If dt.Rows.Count > 0 Then
            ChkCreditCombined.Checked = dt.Rows(0)("combined")
        Else
            MsgBox("Error Field Combined", MsgBoxStyle.Critical)
        End If
        ' change backcolor for chkAutoStop
        CheckboxColor()
        loadDiscountActivation(drCust)

        'display addressbook
        loadAddressBook(_CurrentCustomerID)
        loadAttributesCustomer(_CurrentCustomerID)
        loadCptReconduction(_CurrentCustomerID)
        chkFt.Checked = DVDPostBuziness.ClsCustomers.isFT(_CurrentCustomerID)
        HideTab()
        UcMessagerieCustomer.Customers_id = _CurrentCustomerID
        UcMessagerieCustomer.language_id = lang_id

        _loadInfo = False
    End Sub
    Private Function isrightAccess() As Boolean
        Return (Not DvdPostData.clsSession.isDVDPostUser Or DvdPostData.clsSession.isEnvTest)
    End Function

    Private Sub ChangeStatecheckBox(ByVal c As DevExpress.XtraEditors.CheckEdit, ByVal enabling As Boolean)
        c.Enabled = True
        c.Properties.ReadOnly = Not enabling
    End Sub
    Private Sub ChangeStateControl(ByVal c As Control, ByVal enabling As Boolean)

        c.Enabled = enabling
        If enabling = False Then
            c.ForeColor = Drawing.Color.Black
        End If

    End Sub
    Private Sub EnablingEditFields(ByVal Enabling As Boolean) Handles MyBase.EventEnablingEditFields


        ChangeStateControl(txtLastName, Enabling)
        ChangeStateControl(txtFirstName, Enabling)
        ChangeStateControl(txtEMail, Enabling)
        ChangeStateControl(txtTel, Enabling)
        ChangeStateControl(txtTelEvening, Enabling)


        ChangeStateControl(txtDeliveryFirstName, Enabling)
        ChangeStateControl(txtDeliveryLastName, Enabling)
        ChangeStateControl(txtDeliveryAddr, Enabling)
        ChangeStateControl(txtDeliveryCity, Enabling)
        ChangeStateControl(txtDeliveryPostCode, Enabling)
        ChangeStateControl(cmbDeliverycountry, Enabling)


        ChangeStateControl(cmbDiscountActivation, Enabling And isrightAccess())
        ChangeStateControl(cmbDiscType, Enabling And isrightAccess())
        ChangeStateControl(txtABO, Enabling And isrightAccess())
        ChangeStateControl(cmbSuspended, Enabling And isrightAccess())
        ChangeStateControl(cmbABO, Enabling And isrightAccess())
        ChangeStateControl(cmbNextABO, Enabling And isrightAccess())
        ChangeStateControl(txtABOCredit, Enabling And isrightAccess() And Not DVDPostBuziness.ClsInventory.isAboprocessRun())
        ChangeStateControl(cmbNextDiscCode, Enabling And isrightAccess())
        ChangeStateControl(txtAbo_ValidityTo, Enabling And isrightAccess())


        ChangeStateControl(txtComment, Enabling)
        ChangeStateControl(cmbSuspended, Enabling)
        ChangeStatecheckBox(chkMultiShipment, Enabling)
        ChangeStatecheckBox(chkAutoStop, Enabling)
        ChangeStatecheckBox(chksleep, Enabling)


        ChangeStateControl(txtWishListKind, Enabling)
        ChangeStateControl(cmbLanguage, Enabling)
        ChangeStatecheckBox(chkNewsLetter, Enabling)
        ChangeStatecheckBox(chkNewsLetterPartner, Enabling)
        ChangeStatecheckBox(chkBlackListed, Enabling)
        ChangeStatecheckBox(chkRedListed, Enabling)
        ChangeStateControl(btnGoto30, Enabling)


        ChangeStateControl(cmbPayMethod, Enabling)

        ChangeStateControl(cmbDomStatus, Enabling)
        ChangeStateControl(txtDomAcctNumber, Enabling)
        ChangeStateControl(txtDomDebiterName, Enabling)
        ChangeStateControl(txtDomNumber, Enabling)

        ChangeStateControl(txt_cc_card_no2, Enabling)
        ChangeStateControl(txt_cc_card_type2, Enabling)
        ChangeStateControl(txt_cc_expiration_date2, Enabling)
        ChangeStateControl(txt_cc_owner2, Enabling)
        ChangeStateControl(cmb_cc_expiration_status2, Enabling)


        ChangeStateControl(txtPtSponsorShip, Enabling)

        ChangeStateControl(DateEndOfHoliday, Enabling)


        'phone activation

        ChangeStateControl(DateCallPhoneActivation, Enabling)
        ChangeStateControl(cmbPhoneActivDelete, Enabling)
        ChangeStateControl(MemoOtherReason, Enabling)

        ChangeStateControl(txtCustServ_Subject, Enabling)
        ChangeStateControl(txtCustServ_Response_Message, Enabling)

        ChangeStatecheckBox(chkOnly_VOD, Enabling)
        ChangeStatecheckBox(chkCreditReceivedBySite, False)


        ChangeStateControl(txtCustomers_id, False)
        ChangeStateControl(txtDateCreated, False)
        ChangeStateControl(cmbEntity, False)
        ChangeStateControl(DateBirthday, False)
        ChangeStateControl(txtYearsOld, False)
        ChangeStateControl(txtGender, False)
        ChangeStateControl(txtLast_logon, False)
        ChangeStateControl(txtNbrOfLogons, False)
        ChangeStateControl(txtDVDNorm, False)
        ChangeStateControl(txtDVDNormAtHome, False)
        ChangeStateControl(txtDVDAdult, False)
        ChangeStateControl(txtDVDAdultAtHome, False)
        ChangeStateControl(txtRegistrationStep, False)
        ChangeStateControl(txtNextCredit, False)
        ChangeStateControl(txtNextPrice, False)
        ChangeStateControl(txtDiscRecurring, False)

        _saveCustomersComment = Enabling


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

    Public Overrides Sub btnQuickSearch_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuickSearch.ItemClick
        If IsNumeric(txtQuickSearch.EditValue) Then
            _CurrentCustomerID = txtQuickSearch.EditValue
            refreshClient()
            XTabCustomers.SelectedTabPage = tabMain

        End If
    End Sub

    Public Overloads Sub btnPrevious_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrevious.ItemClick
        _CurrentCustomerID -= 1
        LoadCustomerInfo()
    End Sub
    Public Overloads Sub btnNext_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        _CurrentCustomerID += 1
        LoadCustomerInfo()
    End Sub
    Public Overloads Sub btnFirst_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFirst.ItemClick
        _CurrentCustomerID = 0
        LoadCustomerInfo()
    End Sub
    Public Overloads Sub btnLast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnLast.ItemClick
        _CurrentCustomerID = BKGlobal.ExecuteFindFieldValueINT("customers_id", "select customers_id from customers order by customers_id desc limit 1")
        LoadCustomerInfo()
    End Sub

    Private Sub assignDVD()
        Dim productId As Integer
        Dim DVDId As Integer
        Dim WLId As Integer
        Dim _DS As New dsProducts
        Dim _objProductsDVD As clsProduct_DVD
        Dim sql As String
        Dim isIllimitedAbo As Boolean

        If DVDPostBuziness.ClsInventory.isAboprocessRun() Then
            MsgBox("Wait please but aboprocess run", MsgBoxStyle.Critical)
            Return
        End If
        If Not isrightAccess() Then
            MsgBox("Function Disabled !!!", MsgBoxStyle.Critical)
        Else

            isIllimitedAbo = DVDPostBuziness.ClsCustomers.isIllimitedaboByCustomers(_CurrentCustomerID)
            'Me.Enabled = False
            If txtABOCredit.EditValue > 0 Or isIllimitedAbo Then

                productId = GridViewWishList.GetDataRow(GridViewWishList.FocusedRowHandle)("product_id")
                WLId = GridViewWishList.GetDataRow(GridViewWishList.FocusedRowHandle)("wl_id")

                sql = DvdPostData.clsProductDvd.GetSelectProductsDvdToManualAssign(productId)
                DVDId = DvdPostData.clsConnection.ExecuteScalar(sql)

                If DVDId > 0 Then

                    _objProductsDVD = New clsProduct_DVD(SessionInfo, _DS, productId, DVDId)

                    _objProductsDVD.AssignDVD(isIllimitedAbo, False, WLId, _CurrentCustomerID, DvdPostData.clsCreditHistory.ActionId.MANUAL_ASSIGN, DvdPostData.ClsCustomersData.OrdersType.MANUAL)

                    MsgBox("This button will send the DVD : " & productId.ToString & " - " & DVDId, MsgBoxStyle.Information)
                    refreshTab(XTabCustomers.SelectedTabPageIndex) = True
                    loadwishlist(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID, lang_id)
                    txtABOCredit.EditValue -= 1
                Else
                    MsgBox("Cannot send DVD : " & productId.ToString & " (No Available DVD) ", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("No enough credit !!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub cmbNextDiscCode_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles cmbNextDiscCode.ButtonClick
        If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete Then
            cmbNextDiscCode.EditValue = 0

        End If
    End Sub
    Private Sub cmbNextDiscCode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNextDiscCode.EditValueChanged
        If cmbNextDiscCode.Enabled = False Then Exit Sub
        chkAutoStop.Checked = False
    End Sub
    Private Sub btnStopAtReconduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopAtReconduction.Click
        Dim _Return As Integer
        Dim _SQLTxt As String = "update customers set customers_abo_auto_stop_next_reconduction = 1 where customers_id = " & txtCustomers_id.EditValue
        _Return = DvdPostData.clsConnection.ExecuteNonQuery(_SQLTxt)
        If _Return = 1 Then
            MsgBox("Customer will be Auto-Stopped at next reconduction", MsgBoxStyle.Exclamation)
        Else
            MsgBox("An Error occure." & vbCrLf & _SQLTxt)
        End If
        LoadCustomerInfo()
    End Sub
    Private Sub btnStopNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopNow.Click

        ' the futur code to obligate the customers take off the dvd et home    
        'If (txtDVDNormAtHome.EditValue > 0 Or txtDVDAdultAtHome.EditValue > 0) Then
        '    MsgBox("It's not possible to stop this customer but he has " & txtDVDNormAtHome.EditValue & " DVD Norm " & vbNewLine & _
        '    txtDVDAdultAtHome.EditValue & " DVD Adult (Check the orders History)", MsgBoxStyle.Critical)
        'Else
        If MsgBox(" Confirmez votre demande de stop !", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            MsgBox("Demande Annulée ")
        Else
            Dim reasonStop As New frmChooseStop(SessionInfo)
            reasonStop.drCustomer = objDS.Tables("customers").Rows(0)
            reasonStop.customers_id = txtCustomers_id.EditValue
            reasonStop.typeAbo = cmbABO.EditValue
            reasonStop.ShowDialog()
            refreshClient()
        End If
        

        ' End If

    End Sub
    Private Sub btnReActivate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReActivate.Click

        Dim sql As String
        Dim cpt As Integer

        If (txtDVDNormAtHome.EditValue > 0 Or txtDVDAdultAtHome.EditValue > 0) Then
            MsgBox("It's not possible to activate this customer but he has " & txtDVDNormAtHome.EditValue & " DVD Norm " & vbNewLine & _
            txtDVDAdultAtHome.EditValue & " DVD Adult (Check the orders History)", MsgBoxStyle.Critical)
        Else

            sql = DvdPostData.ClsCustomersData.GetUpdateActivation(_CurrentCustomerID)
            cpt = DvdPostData.clsConnection.ExecuteNonQuery(sql)
            If cpt = 1 Then
                refreshClient()
            Else
                MsgBox("Activation Error", MsgBoxStyle.Critical)
            End If
        End If



    End Sub
    Private Sub btnGoto30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoto30.Click
        txtRegistrationStep.EditValue = 30
    End Sub



    'Private Sub chkViewNegativeBoxes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    _refreshData_wishlist = True
    '    loadwishlist(_CurrentCustomerID, lang_id)
    'End Sub

    Private Sub GridOrders_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridOrders.Click

    End Sub
   
    Public Sub loadCallHistory(ByVal index As Integer, ByVal customers_id As Integer)

        If refreshTab(index) Then
            UcCallsHistory1.loadHistory(customers_id)
            refreshTab(index) = False
        End If

    End Sub
    Public Sub loadDroselia(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sql As String

            sql = DvdPostData.ClsDroselia.GetDroselia(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            Me.GridDroselia.DataSource = dt

            refreshTab(index) = False

        End If
    End Sub


    Private Sub butGenCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butGenCode.Click
        If txtDroselia.EditValue > 0 Then
            Dim nbr As Integer
            Dim cls As New DVDPostBuziness.ClsCustomers
            Dim str As String
            Dim input As String

            nbr = txtDroselia.EditValue
            str = cls.GenerateDroseliaCode(nbr, _CurrentCustomerID)

            refreshClient()
            loadDroselia(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)

            input = InputBox("", "droselia code", str)
        End If

    End Sub



    Private Sub btnActPhone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActPhone.Click
        Dim typepayment As Integer

        If Me.txtABO.Checked = True Then
            MsgBox("member already activate")
            Exit Sub
        End If
        typepayment = objDS.Tables("customers").Rows(0)("customers_abo_payment_method")
        If typepayment <> DvdPostData.ClsCustomersData.Payment_Method.VIREMENT Then
            MsgBox("this is not an activation phone member, you cannot activate this abo ", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Dim cls As DVDPostBuziness.ClsCustomers = New DVDPostBuziness.ClsCustomers()

        Dim ok As Boolean
        ok = cls.Initialisation(_CurrentCustomerID, False)

        If ok Then
            ok = cls.ReconductionVirement(DvdPostData.ClsCustomersData.Country.BELGIUM, _CurrentCustomerID, False)
            'cls.UpdateParrainageSummer(_CurrentCustomerID)
            ' cls.UpdateParrainage(_CurrentCustomerID, txtcustomers_email_address_search.Text.Trim, cmbABO.EditValue)

            If ok Then
                MsgBox("Reconduction OK")
                ' Dim sql As String
                'sql = DvdPostData.ClsCustomersData.GetInsertVodAccess(_CurrentCustomerID)
                'DvdPostData.clsConnection.ExecuteNonQuery(sql)
                refreshClient()
            Else
                ' il faudrait annuler toutes les actions 
                MsgBox("Error Reconduction", MsgBoxStyle.Critical)
            End If

        Else
            MsgBox("Error activate phone", MsgBoxStyle.Critical)
        End If


    End Sub

    Private Sub btnDelPhoAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelPhoAct.Click


        If Me.cmbPhoneActivDelete.EditValue Is Nothing Then
            MsgBox("you must choose a reason to stop phone activation")
            Me.cmbPhoneActivDelete.ForeColor = Drawing.Color.SeaGreen

        Else
            updateInsertPhoneActivation(True)
            searchPhoneAct()
            refreshClient()
        End If

    End Sub


    Private Sub updateInsertPhoneActivation(ByVal date_delete As Boolean)

        Dim customers_abo As Integer
        Dim customers_id As Integer
        Dim other_reason As String
        Dim stop_phone_id As String
        Dim call_phone As String
        Dim count As Integer
        Dim sql As String
        Dim existCust As Boolean
        Dim registration_step As Integer
        Dim payment_method As Integer

        customers_abo = Me.objDS.Tables("customers").Rows(0)("customers_abo")
        registration_step = Me.objDS.Tables("customers").Rows(0)("customers_registration_step")
        payment_method = Me.objDS.Tables("customers").Rows(0)("customers_abo_payment_method")

        customers_id = _CurrentCustomerID



        If MemoOtherReason.EditValue IsNot Nothing Then
            other_reason = MemoOtherReason.EditValue.ToString
        Else
            other_reason = String.Empty
        End If


        If DateCallPhoneActivation.EditValue IsNot Nothing Then
            call_phone = DateCallPhoneActivation.EditValue.ToString
        Else
            call_phone = String.Empty
        End If

        If cmbPhoneActivDelete.EditValue IsNot Nothing Then
            stop_phone_id = cmbPhoneActivDelete.EditValue.ToString
        Else
            stop_phone_id = String.Empty
        End If

        If customers_abo = DvdPostData.ClsCustomersData.abo.UNVALID And registration_step = 100 And payment_method = DvdPostData.ClsCustomersData.Payment_Method.VIREMENT Then
            existCust = exist(customers_id)
            Try

                DvdPostData.clsConnection.CreateTransaction(True)

                If existCust Then
                    sql = DvdPostData.clsPhoneActivation.UpdatePhoneActivation(customers_id, stop_phone_id, other_reason, call_phone, date_delete)
                Else
                    sql = DvdPostData.clsPhoneActivation.insertPhoneActivation(customers_id, stop_phone_id, other_reason, call_phone, date_delete)
                End If

                count = DvdPostData.clsConnection.ExecuteNonQuery(sql)

                If date_delete Then
                    sql = DvdPostData.clsPhoneActivation.updateCustomerStep(customers_id)
                    count = DvdPostData.clsConnection.ExecuteNonQuery(sql)
                End If

                DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Phone_History, count)

            Catch ex As Exception
                DvdPostData.clsConnection.CancelBulkQuery()
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Phone_History, ex, customers_id)
            End Try
        End If


    End Sub

    Private Sub VisiblePhoneActivation(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sql As String
        'render visible groupcontrol
        If Me.txtRegistrationStep.Text = "100" And objDS.Tables("customers").Rows(0)("customers_abo") = 0 Then
            Me.GCACtPhone.Visible = True
            sql = DvdPostData.clsPhoneActivation.GetHistoriquePhoneActivation(customers_id)

            dt = DvdPostData.clsConnection.FillDataSet(sql)

            ' Dim existCust As Boolean = exist(customers_id, "historique_phone_activation")
            If dt.Rows.Count > 0 Then 'existCust = True Then
                Me.DateCallPhoneActivation.EditValue = dt.Rows(0)("call_phone")
                Me.MemoOtherReason.EditValue = dt.Rows(0)("other_reason")
                Me.cmbPhoneActivDelete.EditValue = dt.Rows(0)("stop_phone_id")

            Else
                'put blank 
                Me.DateCallPhoneActivation.EditValue = ""
                Me.MemoOtherReason.EditValue = ""
                Me.cmbPhoneActivDelete.EditValue = ""
            End If
        Else
            Me.GCACtPhone.Visible = False
        End If
    End Sub

    ''put the list of stop_phone_acti_reason in the dropdowlist (lookupedit1)
    Public Sub reasonStopActPhone()
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsPhoneActivation.GetStopPhoneActiReason()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Me.cmbPhoneActivDelete.Properties.DataSource = dt

    End Sub

    Private Sub SendMail()
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.ClsCustomersData.getSelectCustStopKeepdvdBacklog()
        dt = DvdPostData.clsConnection.FillDataSet(sql)


        For Each dr As DataRow In dt.Rows
            DVDPostBuziness.clsMail.SendMail(dr, DVDPostBuziness.clsMail.Mail.MAIL_DVDABOSTOPBACKLOG)
        Next

    End Sub
    Public Function exist(ByVal customers_id As Integer) As Boolean
        Dim sql As String
        sql = DvdPostData.clsPhoneActivation.GetExist(customers_id)
        Return DvdPostData.clsConnection.ExecuteScalar(sql)
    End Function

    Public Sub displayLblSummer(ByVal customers_id As Integer)
        Dim sqlSumWint As String = DvdPostData.ClsCustomersData.GetSelectAboSummerWinterPOwer(customers_id)
        Dim codeSummerWinter As String = BKGlobal.ExecuteFindFieldValue("discount_summer_winter", sqlSumWint)

        If codeSummerWinter <> "0" Then
            Me.lblAboSumP.Visible = True
            Me.lblAboSumP.Text = codeSummerWinter
        Else
            Me.lblAboSumP.Visible = False
        End If

    End Sub

    Private Sub reconductionForced(ByVal customers_id As Integer)

        Dim ok As Boolean
        Dim cls As DVDPostBuziness.ClsCustomers = New DVDPostBuziness.ClsCustomers()

        ok = cls.ReconductionForced(customers_id)
        ' warning check the batch_id in table payment and find replace in batch text 
        ' cls.ReplayReconduction_customers("2011-07-17", DvdPostData.ClsCustomersData.Country.BELGIQUE)
        'cls.ReplayReconductionNoInvoice_customers("2011-07-18", DvdPostData.ClsCustomersData.Country.BELGIQUE)
        If ok Then
            MsgBox("Reconduction OK")
            refreshClient()
        Else
            MsgBox("Error Reconduction", MsgBoxStyle.Critical)
        End If

    End Sub

    'Private Sub btnActivateDomiciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActivateDomiciliation.Click
    '    If Me.txtABO.Checked = True Then
    '        MsgBox("member already activate")



    '    ElseIf objDS.Tables("customers").Rows(0)("customers_abo_payment_method") <> DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION Then
    '        MsgBox("No domiciliation customer", MsgBoxStyle.Critical)

    '    Else

    '        Dim cls As DVDPostBuziness.ClsCustomers = New DVDPostBuziness.ClsCustomers()
    '        Dim numDom As String
    '        ' Dim numaccount As String

    '        numDom = InputBox("Enter number of domiciliation please ")
    '        'numaccount = InputBox("Enter bank account number(IBAN) please ")

    '        If (numDom <> String.Empty AndAlso numDom.Length = 12) Then
    '            cls.updateNumDom(_CurrentCustomerID, numDom)
    '            Dim ok As Boolean
    '            ok = cls.Initialisation(_CurrentCustomerID, True)

    '            If ok Then
    '                MsgBox("Domiciliation customer activated")
    '                ok = cls.ReconductionDomiciliation(DvdPostData.ClsCustomersData.Country.BELGIQUE, _CurrentCustomerID, False)
    '                If ok Then
    '                    DVDPostBuziness.clsMail.SendMail(_CurrentCustomerID, DVDPostBuziness.clsMail.Mail.MAIL_ACTIVATIONDOM)
    '                    MsgBox("Reconduction OK")
    '                    refreshClient()
    '                Else
    '                    MsgBox("Error Reconduction", MsgBoxStyle.Critical)
    '                End If
    '            Else
    '                MsgBox("Error activate domiciliation", MsgBoxStyle.Critical)
    '            End If
    '        Else
    '            MsgBox("data invalidated (length num domiciliation : 12)", MsgBoxStyle.Critical)
    '        End If

    '    End If
    'End Sub

    'Private Sub btnReceivedDomiciliation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivedDomiciliation.Click
    '    Dim sql As String

    '    sql = DvdPostData.ClsBatchDomiciliation.UpdateActivation _
    '                   (_CurrentCustomerID, _
    '                    DvdPostData.ClsCustomersData.Payment_Method.DOMICILIATION, _
    '                   DvdPostData.ClsCustomersData.Country.BELGIQUE, _
    '                   DvdPostData.ClsCustomersData.StepRegistrationStatus.CREATE_DOMICILIATION, _
    '                    DvdPostData.ClsCustomersData.DomiciliationStatus.RETRIEVELETTER, _
    '                   DvdPostData.ClsCustomersData.StepRegistrationStatus.RECEIVED_DOMICILIATION)

    '    Dim cpt As Integer
    '    cpt = DvdPostData.clsConnection.ExecuteNonQuery(sql)

    '    If cpt = 1 Then
    '        MsgBox("Received Domiciliation OK")
    '        DVDPostBuziness.clsMail.SendMail(_CurrentCustomerID, DVDPostBuziness.clsMail.Mail.MAIL_RECEIVEDDOM)
    '        refreshClient()
    '    Else
    '        MsgBox("Error Received Domiciliation", MsgBoxStyle.Critical)
    '    End If
    'End Sub

  

    Private Sub GridViewWishList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSendIt.Click 'Handles btnSendIt.Click
        If GridViewWishList.RowCount <> 0 Then
            assignDVD()
            refreshClient()
            ' loadwishlist(_CurrentCustomerID, lang_id)
        End If
    End Sub

    Private Sub btnForcedReconduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForcedReconduction.Click
        reconductionForced(_CurrentCustomerID)
    End Sub

    Private Sub XtraTabControl1_SelectedPageChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XTabCustomers.SelectedPageChanged
        Dim index As Integer = XTabCustomers.SelectedTabPageIndex
        If XTabCustomers.SelectedTabPage Is tabPaymentMovements Then
            loadBankAccountMovement(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabWishList Then
            loadwishlist(index, _CurrentCustomerID, lang_id)
        ElseIf XTabCustomers.SelectedTabPage Is tabOrdersHistor Then
            loadOrders(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabAboHistory Then
            loadAboHist(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabPayment Then
            loadPayment(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabMailHistory Then
            loadEmailHistory(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabPurchase Then
            loadShoppingOrders(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabCreditHist Then
            loadCreditHist(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabCustServ Then
            loadCustServ(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabAboProcessOld Then
            loadAboprocessOldStats(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabAboprocess Then
            loadAboprocessStats(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabSponsorShip Then
            loadSponsor(index, _CurrentCustomerID) ' DvdPostData.clsMemberGetMember.SponsorshipType.SPONSOR) ', DvdPostData.clsMemberGetMember.SponsorshipType.SPONSOR)
        ElseIf XTabCustomers.SelectedTabPage Is tabCompensation Then
            loadCompensation(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabComment Then
            loadCustComment(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabProductsRating Then
            loadProductsRating(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabSuspendedHistory Then
            loadSupendedHistory(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabDroselia Then
            loadDroselia(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabVodView Then
            loadVod(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabCalls Then
            loadCallHistory(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabMessagerie Then
            loadMessagerie(index, _CurrentCustomerID)
        ElseIf XTabCustomers.SelectedTabPage Is tabCritiques Then
            loadCritique(index, _CurrentCustomerID)
        End If

    End Sub

    Private Sub btnLoadPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadPayment.Click
        refreshTab(XTabCustomers.SelectedTabPageIndex) = True
        loadPayment(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
    End Sub
    Private Function ClosePayment(ByVal status As DvdPostData.PaymentOfflineData.StepPayment) As Boolean
        Dim id As Integer
        Dim strtype_payment As String

        Dim dr As DataRow
        Dim sql As String
        Dim last_status As DvdPostData.PaymentOfflineData.StepPayment


        dr = GridViewPayment.GetDataRow(GridViewPayment.FocusedRowHandle)
        id = dr("id")
        strtype_payment = dr("type_payment")
        last_status = dr("payment_status_id")

        If MsgBox("Are you sur to close (" & DVDPostTools.clsEnum.getNameStrEnum(status) & ") this payment ID = " & id, MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then

            sql = DvdPostData.ClsPayment.GetUpdateClosePayment(id, status, last_status)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

            refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            loadPayment(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
            Return True
        Else
            Return False
        End If


    End Function
    Private Sub btnCancelPayment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelPayment.Click

        If GridViewPayment.GetSelectedRows().Length = 0 Then
            MsgBox("Please select one payment before Cancel")
        End If

        If ClosePayment(DvdPostData.PaymentOfflineData.StepPayment.CANCEL) Then
            MsgBox("Cancel OK")
        Else
            MsgBox("Cancel Error")
        End If
    End Sub
    Private Sub BtnPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPaid.Click


        If GridViewPayment.GetSelectedRows().Length = 0 Then
            MsgBox("Please select one payment before paid")
        End If

        If ClosePayment(DvdPostData.PaymentOfflineData.StepPayment.PAID) Then
            MsgBox("Pay OK")
        Else
            MsgBox("Pay Error")
        End If

    End Sub

    ''' <summary>
    ''' insert in credit_history ' by gauthier
    ''' </summary>
    Private Sub addCreditToCustomers(ByVal quantity As Integer, ByVal customers_id As Integer, ByVal creditAction As DvdPostData.clsCreditHistory.ActionId, ByVal oldCredit As Integer)

        Dim sqlAddCredit As String = DvdPostData.clsCreditHistory.GetInsertCreditHistory(quantity, _CurrentCustomerID, creditAction, False, Nothing, oldCredit)
        DvdPostData.clsConnection.ExecuteNonQuery(sqlAddCredit)

    End Sub

    Private Function calculCredit(ByVal oldCredit As Integer, ByVal newCredit As Integer) As Integer
        Dim result As Integer
        result = newCredit - oldCredit
        Return result
    End Function

    Private Sub lblLogas_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblLogas.Click
        System.Diagnostics.Process.Start("http://www.dvdpost.be/logas.php?customers_id=" & _CurrentCustomerID & "")
    End Sub

    Private Sub lblSetPassWord_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSetPassWord.Click
        If MsgBox("change password", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok And _CurrentCustomerID > 0 Then
            Dim sql As String
            Dim code As String
            Dim count As Integer
            Try
                code = GenerateCode()
                sql = DvdPostData.ClsCustomersData.GetUpdatePassWord(_CurrentCustomerID, DVDPostBuziness.ClsCustomers.MD5Encrypt(code))

                DvdPostData.clsConnection.CreateTransaction(False)
                count = DvdPostData.clsConnection.ExecuteNonQuery(sql)
                If count = 1 Then
                    DvdPostData.clsConnection.CommitTransaction(True)
                    code = InputBox("New Password", "", code)
                Else
                    DvdPostData.clsConnection.CommitTransaction(False)
                    MsgBox(" Not new password ")
                End If
            Catch ex As Exception
                DvdPostData.clsConnection.CommitTransaction(False)
                DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.SignaletiqueCustomer, ex)
            End Try


        End If
    End Sub

    Private Function GenerateCode() As String
        Dim code As String

        code = Guid.NewGuid().ToString().GetHashCode.ToString("X")

        code = Replace(code, "0", "-")
        code = Replace(code, "O", "-")
        code.ToUpper()
        code = code.Substring(0, code.Length - 2)

        Return code
    End Function


    Private Function calculAge(ByVal birthday As DateTime) As Integer
        Dim result As Integer
        result = DateDiff(DateInterval.Year, birthday, Date.Now)
        Return result
    End Function
    ' Code permettant d'envoyer une copie d'un mail d'un client
    'Private Sub sendMail(ByVal strmessage As String, ByVal strSubject As String)
    '    Dim mymail As Net.Mail.MailMessage
    '    mymail = New Net.Mail.MailMessage("dvb@dvdpost.be", "ms@dvdpost.be")
    '    mymail.From = New Net.Mail.MailAddress("dvb@dvdpost.be", "IT")
    '    mymail.Subject = strSubject
    '    mymail.IsBodyHtml = True
    '    mymail.Body = strmessage

    '    DVDPostBuziness.clsMail.SendMail(mymail)


    'End Sub
    Private Sub loadEmailHistory(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sql As String = DvdPostData.clsMassEmail.GetemailHistory(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            Dim msg As String
            '  Dim bulk As String = ""
            For Each dr As DataRow In dt.Rows
                msg = dr("messages_html")
                If dr("lstvariable") IsNot DBNull.Value Then
                    dr("messages_html") = DVDPostBuziness.clsMail.replacevariableInMsg(msg, dr("lstvariable"))
                End If
                ' sendMail(dr("messages_html"), dr("messages_subject"))
                ' bulk = bulk + dr("messages_html")
            Next

            grpContEmail.DataSource = dt

            If dt.Rows.Count > 0 Then
                GridViewMail.SelectRow(0)
                displayDetailsMail()
            End If

            refreshTab(index) = False
        End If

    End Sub
    Private Sub displayDetailsMail()
        browser.DocumentText = GridViewMail.GetDataRow(GridViewMail.FocusedRowHandle)("messages_html").ToString()
    End Sub
    Private Sub GridViewMail_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewMail.FocusedRowChanged 'grpContEmail.DoubleClick
        displayDetailsMail()
    End Sub

    Private Sub loadShoppingOrders(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sqlShopping As String = DvdPostData.clsShopping.GetShoppingOrders(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlShopping)
            GridShoppingOrders.DataSource = dt

            GridViewShoppingOrders.BestFitColumns()
            GridViewShoppingOrders.ExpandAllGroups()

            refreshTab(index) = False
        End If
    End Sub

    Private Sub loadCreditHist(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sqlCreditHist As String = DvdPostData.clsCreditHistory.GetCreditHistoryByCust(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlCreditHist)
            GridCreditHistory.DataSource = dt

            refreshTab(index) = False
        End If

    End Sub

    Private Sub loadCustServ(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sqlCustServ As String = DvdPostData.ClsCustserv.GetCustservByCustomers(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlCustServ)
            GridCustServ.DataSource = dt

            gridViewCustServ.BestFitColumns()
            gridViewCustServ.ExpandAllGroups()

            displayInfoCustserv(index)

            refreshTab(index) = False
        End If
    End Sub

 
    Private Sub displayInfoCustserv(ByVal index As Integer)
        If gridViewCustServ.RowCount <> 0 Then
            If (refreshTab(index) Or _saveCustomersComment) Then
                Dim dr As System.Data.DataRow
                dr = gridViewCustServ.GetDataRow(gridViewCustServ.FocusedRowHandle)

                txtCustServ_CustDate.EditValue = dr("customer_date")
                txtCustServ_Subject.EditValue = dr("subject")
                'cmbCustServCat1.EditValue = dr("custserv_cat_name")
                MemoEdit1.EditValue = dr("message")
                txtCustServ_OrderID.EditValue = dr("orders_id")
                txtCustServ_Products_id.EditValue = dr("products_id")
                txtCustServ_DVD_ID.EditValue = dr("dvd_id")
                'txtCustServ_AdminDate.EditValue = dr("admindate")

                txtCustServ_Response_Message.EditValue = dr("adminmessage")
            End If
        Else
            txtCustServ_CustDate.EditValue = String.Empty
            txtCustServ_Subject.EditValue = String.Empty
            MemoEdit1.EditValue = String.Empty
            txtCustServ_OrderID.EditValue = String.Empty
            txtCustServ_Products_id.EditValue = String.Empty
            txtCustServ_DVD_ID.EditValue = String.Empty
            txtCustServ_Response_Message.EditValue = String.Empty

        End If
    End Sub

    Private Sub GridViewCustServ_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gridViewCustServ.FocusedRowChanged  'grpContEmail.DoubleClick
        displayInfoCustserv(XTabCustomers.SelectedTabPageIndex)
    End Sub

    Private Sub btnSaveCustServ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCustServ.Click
        Dim dr As DataRow
        Dim custservId As Integer
        Dim messageAdmin As String
        Dim sqlUpdate As String
        Dim subject As String
        Dim sendEmail As Boolean
        Try
            dr = gridViewCustServ.GetDataRow(gridViewCustServ.FocusedRowHandle)

            custservId = CType(dr("custserv_id"), Integer)
            messageAdmin = txtCustServ_Response_Message.Text.Trim
            messageAdmin = Replace(messageAdmin, "'", "\'")
            messageAdmin = Replace(messageAdmin, vbNewLine, "<br>")
            messageAdmin = Replace(messageAdmin, "’", "\'")

            subject = txtCustServ_Subject.Text.Trim
            subject = Replace(subject, "'", "\'")
            subject = Replace(subject, "’", "\'")
            sendEmail = chkCustServSendMail.Checked

            sqlUpdate = DvdPostData.ClsCustserv.upadeCustservByCustMaint(custservId, messageAdmin, subject, sendEmail)
            DvdPostData.clsConnection.ExecuteNonQuery(sqlUpdate)

            If sendEmail = True Then
                DVDPostBuziness.clsMail.SendMail(_CurrentCustomerID, DVDPostBuziness.clsMail.Mail.MAIL_CUST_SERV)
            End If

            refreshClient()
            loadCustServ(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)

            searchCustserv()
            _saveCustomersComment = True
        Catch ex As Exception
            DVDPostBuziness.clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Email, ex)
        End Try
    End Sub

    Private Sub GridViewABO_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridViewABO.DoubleClick
        Dim param As DVDPostBuziness.clsSingleton
        param = DVDPostBuziness.clsSingleton.Instance()
        'param.Activayion_Dscount_id = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("code_id"), Integer)

        Dim action_id As Integer = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("action"), Integer)

        If action_id = DvdPostData.ClsCustomersData.TypeAction.ACTION_FROM_ACTIVATION Then
            param.Activation_Discount_id = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("code_id"), Integer)
            Dim frmAct As New frmActivationCode(SessionInfo)
            frmAct.MdiParent = Me.ParentForm
            frmAct.Show()
            frmAct.search()
        End If

        If action_id = DvdPostData.ClsCustomersData.TypeAction.ACTION_FROM_DISCOUNT Then
            param.Activation_Discount_id = CType(GridViewABO.GetDataRow(GridViewABO.FocusedRowHandle)("code_id"), Integer)
            Dim frmDisc As New frmDiscountCode(SessionInfo)
            frmDisc.MdiParent = Me.ParentForm
            frmDisc.Show()
            frmDisc.search()
        End If
    End Sub
    Private Sub loadCptReconduction(ByVal customers_id As Integer)

        Dim sql As String
        Dim cpt As Integer
        sql = DvdPostData.ClsCustomersData.GetSelectCountReconduction(customers_id)
        cpt = DvdPostData.clsConnection.ExecuteScalar(sql)

        lblCpt_reconduction.Text = cpt
    End Sub
    Private Sub loadAboprocessStats(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As New DataTable
            Dim sqlStats As String

            sqlStats = DvdPostData.AboProcessData.GetAboprocessStatsByCust(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlStats)
            gridAboprocess.DataSource = dt
            refreshTab(index) = False
        End If

    End Sub

    Private Sub loadAboprocessOldStats(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As New DataTable
            Dim sqlStats As String

            sqlStats = DvdPostData.AboProcessData.GetAboprocessOldByCust(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlStats)
            GridAboprocessOld.DataSource = dt
            refreshTab(index) = False
        End If

    End Sub
    Private Sub loadSponsorCard(ByVal customers_id As Integer)
        Dim sql As String
        Dim dt As DataTable


        sql = DvdPostData.clsMemberGetMember.GetListCustToOrderCard(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        If dt.Rows.Count > 0 Then
            VisibleControl(dt.Rows(0)("cpt_card"))
        Else
            VisibleControl(0)
        End If
    End Sub
    Private Function getListCode(ByRef cpt_codeActivation As Integer) As String
        Dim result As String = String.Empty
        Dim ctrl_txt As Control
        cpt_codeActivation = 0
        For index As Integer = 1 To 5
            ctrl_txt = GCSponsonCard.Controls("txtCard" + index.ToString())
            If ctrl_txt.Visible = True Then
                If ctrl_txt.Text <> "" Then
                    result = result + ctrl_txt.Text + ";"
                End If
                cpt_codeActivation += 1
            End If
        Next
        result = result.Remove(result.Length - 1, 1)
        Return result
    End Function
    Private Sub VisibleControl(ByVal cpt As Integer)
        Dim label As Control
        Dim txt As Control
        Dim ok As Boolean = False

        For index As Integer = 1 To 5

            label = GCSponsonCard.Controls("lblCard" + index.ToString())
            txt = GCSponsonCard.Controls("txtCard" + index.ToString())

            If index > cpt Then
                label.Visible = False
                txt.Visible = False
            Else
                ok = True
                label.Visible = True
                txt.Visible = True
                txt.Text = String.Empty
            End If
        Next

        BtnSaveSponsorCard.Enabled = ok
    End Sub
    Private Sub loadSponsor(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim sql As String
            Dim dtSponsor As DataTable
            Dim dtGodson As DataTable
            Dim dtCode As DataTable

            sql = DvdPostData.clsMemberGetMember.GetSponsorUsed(customers_id, DvdPostData.clsMemberGetMember.SponsorshipType.SPONSOR)
            dtSponsor = DvdPostData.clsConnection.FillDataSet(sql)
            GridSon.DataSource = dtSponsor

            sql = DvdPostData.clsMemberGetMember.GetSponsorUsed(customers_id, DvdPostData.clsMemberGetMember.SponsorshipType.GODSON)
            dtGodson = DvdPostData.clsConnection.FillDataSet(sql)
            GridGodFather.DataSource = dtGodson

            sql = DvdPostData.clsMemberGetMember.GetCodeLinkCustomers(customers_id)
            dtCode = DvdPostData.clsConnection.FillDataSet(sql)
            GridCodeLinked.DataSource = dtCode


            loadMgmGift(customers_id)
            loadCustomersPointHistory(customers_id)
            loadSponsorCard(customers_id)

            refreshTab(index) = False
        End If


    End Sub

    Public Sub loadMgmGift(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sqlGift As String

        sqlGift = DvdPostData.clsMemberGetMember.GetMgmGift(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sqlGift)
        GridGift.DataSource = dt
    End Sub
    Public Sub loadCustomersPointHistory(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sql As String

        sql = DvdPostData.clsMemberGetMember.GetCustomersPointsHistory(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridCustPointHistory.DataSource = dt
    End Sub

    Public Function openFrmCustMaint(ByVal customers_id As Integer, ByVal frmParent As Form) As frmCustomers_Maint
        '  Dim objet1 As DVDPostBuziness.clsSingleton = Nothing
        '  objet1 = DVDPostBuziness.clsSingleton.Instance()
        '  objet1.CustomersId = customers_id
        Dim frm As New frmCustomers_Maint(SessionInfo)
        frm.MdiParent = frmParent
        frm.Text = "Customers Maint"
        frm.Show()
        frm.txtQuickSearch.EditValue = customers_id
        frm._CurrentCustomerID = frm.txtQuickSearch.EditValue
        frm.refreshClient()

        frm.XTabCustomers.SelectedTabPage = frm.tabMain
        Return frm
        'frm.Show()
        'frm.Search()
        'frm.Text = "Customers Maint"
        ''frm.Text
    End Function

    Private Sub loadCompensation(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then

            Dim dt As DataTable
            Dim sqlCompensation As String

            sqlCompensation = DvdPostData.clsCompensation.GetCompensationByCust(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sqlCompensation)

            GridCompensation.DataSource = dt

            refreshTab(index) = False
        End If

    End Sub

    Private Sub loadCustComment(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then

            Dim sql As String = DvdPostData.clsCustomersComment.GetCustomersComment(customers_id)
            Dim dt As DataTable
            MemoCustomersComment.Text = String.Empty
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridCustComment.DataSource = dt

            refreshTab(index) = False
        End If
    End Sub

    Private Sub GridViewCustComment_FocusedRowHandle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridViewCustComment.FocusedRowChanged 'grpContEmail.DoubleClick
        If GridViewCustComment.RowCount <> 0 Then
            MemoCustomersComment.Text = GridViewCustComment.GetDataRow(GridViewCustComment.FocusedRowHandle)("customers_comment_text").ToString()
        Else
            MemoCustomersComment.Text = String.Empty
        End If
    End Sub

    Private Sub btnAddCustomersComment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddCustomersComment.Click
        If MemoInsertComment.Text <> String.Empty Then
            Dim str As String
            str = MemoInsertComment.Text
            Dim sqlInsertComment As String = DvdPostData.clsCustomersComment.GetInsertCustomersComment(_CurrentCustomerID, str)
            DvdPostData.clsConnection.ExecuteNonQuery(sqlInsertComment)

            refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            loadCustComment(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
            MemoInsertComment.Text = String.Empty
        End If
    End Sub



    Private Sub btnViewCustserv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewCustserv.Click
        searchCustserv()
    End Sub

    Private Sub searchCustserv()
        Dim dt As DataTable
        Dim sql As String = DvdPostData.ClsCustserv.GetCustServCustomers()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub btnViewGift_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewGift.Click
        Dim dt As DataTable
        Dim sql As String = DvdPostData.clsMemberGetMember.GetCustomersWithGift()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub chkAutoStop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoStop.CheckedChanged
        CheckboxColor()
    End Sub

    Private Sub CheckboxColor()
        If chkAutoStop.Checked Then
            chkAutoStop.BackColor = Drawing.Color.Red
        Else
            chkAutoStop.BackColor = Drawing.Color.Transparent
        End If
    End Sub

    Private Sub loadAddressBook(ByVal customers_id As Integer)
        Dim dt As DataTable
        Dim sql As String = DvdPostData.clsAddressBook.GetAddressByCustomer(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridAddress.DataSource = dt

        If GridViewAddress.RowCount = 0 Then
            GridAddress.Visible = False
        Else
            GridAddress.Visible = True
        End If
    End Sub

    Private Sub loadProductsRating(ByVal index As Integer, ByVal customers_id As Integer)
        If refreshTab(index) Then
            Dim dt As DataTable
            Dim sql As String = DvdPostData.clsProductsRating.GetProductsRatingByCust(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridProductsRating.DataSource = dt
            GridViewProductsRating.ExpandAllGroups()
            refreshTab(index) = False
        End If
    End Sub

    Private Sub BtnSponsorCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSponsorCard.Click
        Dim dt As DataTable
        Dim sql As String = DvdPostData.clsMemberGetMember.GetListCustToOrderCard()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub BtnSaveSponsorCard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveSponsorCard.Click
        Dim result As String
        Dim ok As Boolean
        Dim cpt_card As Integer
        result = getListCode(cpt_card)
        Dim lst As String() = result.Split(";")
        Dim AllCards As Boolean = (cpt_card = lst.Length)
        Dim item As String = ""
        For Each item In lst
            ok = DVDPostBuziness.ClsWebServices.CallUrllinkCard(_CurrentCustomerID, item)
            If ok = False Then
                Exit For
            Else
                cpt_card -= 1
            End If
        Next

        ' (cpt_card = lst.Length) = encoder toutes les cartes que le client a besoin 
        If ok And AllCards Then
            BtnSaveSponsorCard.Enabled = False
            Dim sql As String
            sql = DvdPostData.clsMemberGetMember.GetUpdateSendFlag(_CurrentCustomerID)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
            MsgBox("ok")

        Else
            Dim sql As String
            sql = DvdPostData.clsMemberGetMember.GetUpdateNbCard(_CurrentCustomerID, cpt_card)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
            If (Not ok) Then
                MsgBox("Error code : " & item)
            Else
                MsgBox("You must filled " & cpt_card & " codes")
            End If

            refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            loadSponsor(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
        End If
    End Sub

    Private Sub loadRedBlackListed(ByVal redBlackList As DvdPostData.ClsCustomersData.RedBlackListed)
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsCustomersData.GetRedBlacklistedCustomers(redBlackList)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub

    Private Sub btnBlackListed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlackListed.Click
        loadRedBlackListed(DvdPostData.ClsCustomersData.RedBlackListed.BLACKLISTED)
    End Sub

    Private Sub btnRedlisted_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedlisted.Click
        loadRedBlackListed(DvdPostData.ClsCustomersData.RedBlackListed.REDLISTED)
    End Sub

    Private Sub BtnEmailError_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmailError.Click
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsOdersStatusHistory.GetListOrderHistory(True, True)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridControl1.DataSource = dt
    End Sub


    Private Sub loadSupendedHistory(ByVal index As Integer, ByVal customers_id As Integer)
        Dim sql As String
        Dim dt As DataTable

        If refreshTab(index) Then

            sql = DvdPostData.clsAboSuspended.GetSuspendedHistory(customers_id)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            GridSuspendedHistory.DataSource = dt

            refreshTab(index) = False
        End If
    End Sub

    Private Sub suspendedPayment(ByVal customers_id As Integer)

        If Not DVDPostBuziness.ClsWebServices.CallSuspended(customers_id, DateTime.Now, DVDPostBuziness.ClsWebServices.TypeSuspend.PAYMENT) Then
            MsgBox("Error Suspension Payment", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub unsuspendedPayment(ByVal customers_id As Integer)

        If Not DVDPostBuziness.ClsWebServices.CallUnSuspended(customers_id, DateTime.Now, DVDPostBuziness.ClsWebServices.TypeSuspend.PAYMENT) Then
            MsgBox("Error UnSuspension Payment", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub UnsuspendForHolidays(ByVal customers_id As Integer, ByVal date_end As Date, ByVal old_date_end As Date)

        If Not DVDPostBuziness.ClsWebServices.CallUnSuspended(customers_id, date_end, DVDPostBuziness.ClsWebServices.TypeSuspend.HOLIDAYS) Then
            MsgBox("Error UnSuspension Holidays", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub suspendForHolidays(ByVal customers_id As Integer, ByVal date_end As Date, ByVal old_date_end As Date)

        If Not DVDPostBuziness.ClsWebServices.CallSuspended(customers_id, date_end, DVDPostBuziness.ClsWebServices.TypeSuspend.HOLIDAYS) Then
            MsgBox("Error Suspension Holidays", MsgBoxStyle.Critical)
        End If
       
    End Sub

    Private Sub suspended()
        Dim newSuspended As Integer

        newSuspended = cmbSuspended.EditValue
        If _oldSuspended = newSuspended Then Return

        If Not IsNothing(DateEndOfHoliday.EditValue) And newSuspended = DvdPostData.ClsCustomersData.Suspended.HOLIDAY Then
            Dim new_date_end_holiday As Date = DateEndOfHoliday.EditValue
            suspendForHolidays(_CurrentCustomerID, new_date_end_holiday, _old_date_Holiday)
        ElseIf newSuspended = DvdPostData.ClsCustomersData.Suspended.RECONDUCTION Then
            suspendedPayment(_CurrentCustomerID)
        End If

        If _oldSuspended <> newSuspended And newSuspended = DvdPostData.ClsCustomersData.Suspended.OK Then
            If _oldSuspended = DvdPostData.ClsCustomersData.Suspended.RECONDUCTION Then
                unsuspendedPayment(_CurrentCustomerID)
            Else
                UnsuspendForHolidays(_CurrentCustomerID, DateTime.Now, _old_date_Holiday)
            End If
        End If

    End Sub
    Private Function getCheckItem(ByVal key As String, ByVal lst As DevExpress.XtraEditors.CheckedListBoxControl) As DevExpress.XtraEditors.Controls.CheckedListBoxItem
        Dim i As Integer
        i = 0
        While i < lst.Items.Count

            If lst.Items(i).Value = key.ToLower() Then
                Return lst.Items(i)
            End If
            i += 1
        End While

        Return Nothing
    End Function
    Private Sub HideAllTab()

        For Each tab As DevExpress.XtraTab.XtraTabPage In tabConfig.TabControl().TabPages
            tab.PageVisible = tab.Text = tabSearch.Text
            'ChkListConfig.Items(1).Value   
        Next

    End Sub


    Private Sub HideTab()
        Dim chkItem As DevExpress.XtraEditors.Controls.CheckedListBoxItem
        For Each tab As DevExpress.XtraTab.XtraTabPage In tabConfig.TabControl().TabPages
            chkItem = getCheckItem(tab.Text, ChkListConfig)
            If chkItem IsNot Nothing Then
                tab.PageVisible = chkItem.CheckState = CheckState.Checked
                'ChkListConfig.Items(1).Value   
            End If
        Next

        tabConfig.PageVisible = True
        tabMain.PageVisible = True

    End Sub

    '' to check the words Gauthier
    Private Function SpellChecker(ByVal str As String) As String
        Dim spellCheck As New SpellChecker
        spellCheck.Check(str)
        Return str
    End Function

    Private Sub btnRefreshTab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefreshTab.Click
        HideTab()
    End Sub

    'Private Sub BtnVodAccess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVodAccess.Click
    '    Dim sql As String

    '    sql = DvdPostData.ClsCustomersData.GetInsertVodAccess(_CurrentCustomerID)
    '    DvdPostData.clsConnection.ExecuteNonQuery(sql)
    '    ' loadVodAccess(_CurrentCustomerID)
    'End Sub

    Private Sub UcCallsHistory1_initUpdateValue() Handles UcCallsHistory1.initUpdateValue
        UcCallsHistory1.customers_id = _CurrentCustomerID
        UcCallsHistory1.Reconductions = Integer.Parse(lblCpt_reconduction.Text)
        UcCallsHistory1.FT = chkFt.Checked
    End Sub

    Private Sub RepositoryICustomersCustomers_id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryICustomersCustomers_id.Click
        If GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle) Is Nothing Then Return
        _CurrentCustomerID = GridViewSearch.GetDataRow(GridViewSearch.FocusedRowHandle)("customers_id")
        refreshClient()
        XTabCustomers.SelectedTabPage = tabMain
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

    Private Sub RepositoryIbtnAddDVD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryIbtnAddDVD.Click
        Dim products_id As Integer
        Dim objProductsDVD As clsProduct_DVD
        Dim check As Boolean

        check = GridViewWishListAssigned.GetDataRow(GridViewWishListAssigned.FocusedRowHandle)("order_check")
        products_id = GridViewWishListAssigned.GetDataRow(GridViewWishListAssigned.FocusedRowHandle)("products_id")
        If check Then

            objProductsDVD = New clsProduct_DVD(SessionInfo, New DVDPostLib.dsProducts(), products_id, 0)
            objProductsDVD.ReplaceDvdWishlist(_CurrentCustomerID, products_id)

            MsgBox(products_id & " est rajouté dans la wishlist")
            loadwishlist(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID, lang_id)
        Else
            MsgBox(products_id & " n'est pas une dvd associé à une commande qui doit être vérifier", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub RepositoryIbtnCheckOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepositoryIbtnCheckOrder.Click
        Dim orders_id As Integer
        Dim status As Integer

        status = GridViewOrders.GetDataRow(GridViewOrders.FocusedRowHandle)("orders_status_id")
        orders_id = GridViewOrders.GetDataRow(GridViewOrders.FocusedRowHandle)("orders_id")
        If status <> DvdPostData.clsOdersStatusHistory.OrderStatusNew.RETURNED Then
            If status = DvdPostData.clsOdersStatusHistory.OrderStatusNew.DELAYED_GO Then
                DVDPostBuziness.clsOrders.UpdateOrder(orders_id, DvdPostData.clsOdersStatusHistory.OrderStatusNew.EXPEDITED, status)
            Else

                Dim frm As frmStatusOrder = New frmStatusOrder()
                frm.orders_id = orders_id
                frm.customers_id = _CurrentCustomerID
                frm.oldstatus = status
                frm.ShowDialog()
            End If

            refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            loadOrders(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID)
            refreshTab(XTabCustomers.SelectedTabPageIndex) = True
            loadwishlist(XTabCustomers.SelectedTabPageIndex, _CurrentCustomerID, lang_id)

        End If
    End Sub

    Private Sub btnCreditHistoryReplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreditHistoryReplay.Click
        DvdPostData.clsCreditHistory.GetUpdateAllCreditHistory(_CurrentCustomerID, ChkCreditCombined.Checked)
    End Sub

    Private Sub btnReplayAllCreditHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReplayAllCreditHistory.Click
        Dim dt As DataTable
        Dim sql As String
        Dim index As Integer = 0
        Dim combined As Boolean
        Dim cpt_result As Integer
        sql = "select customers_id,combined from customers c left join customer_attributes ca on c.customers_id = ca.customer_id order by customers_id desc "
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        DvdPostData.clsConnection.CreateTransaction(True)

        For Each dr As DataRow In dt.Rows

            If dr("combined") Is DBNull.Value Then
                combined = False
            Else
                combined = dr("combined")
            End If

            DvdPostData.clsCreditHistory.GetUpdateAllCreditHistory(dr("customers_id"), combined)
            index += 1

            If index Mod 1000 = 0 Then
                DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Batch, cpt_result)
                DvdPostData.clsConnection.CreateTransaction(True)
            End If
        Next
        DvdPostData.clsConnection.ExecuteBulkQuery(DvdPostData.clsMsgError.processType.Batch, cpt_result)
    End Sub
    ''' <summary>
    ''' used to cancel if change manually in suspension payment
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub cmbSuspended_EditValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles cmbSuspended.EditValueChanging

        If e.NewValue = 2 And Not _loadInfo Then
            e.Cancel = True
            Return
        End If

        If e.NewValue = 1 Then
            cmbSuspended.BackColor = Drawing.Color.LightBlue
            cmbSuspended.ForeColor = Drawing.Color.White
        ElseIf e.NewValue = 2 Then
            cmbSuspended.BackColor = Drawing.Color.Red
            cmbSuspended.ForeColor = Drawing.Color.White
        Else
            cmbSuspended.BackColor = Nothing
        End If

    End Sub
End Class

