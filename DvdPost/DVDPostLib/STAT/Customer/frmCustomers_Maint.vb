Public Class frmStatCustomer
    Inherits BizzLib.frmGeneral_Browse

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MenuStrip As New DVDPostBuziness.contextMenu()

        Grid1.ContextMenuStrip = MenuStrip

        TabParameters.PageVisible = True
        txtFromDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        txtToDate.DateTime = Now().ToString(txtFromDate.Properties.EditFormat.FormatString)
        ' BKGlobal.SetToolBar(BarManager1, Me.Tag, CanNew, CanEdit, CanDelete, CanSave, , , , True, False, False, True)
        CurrentDefaultSetID = cmbDefaultList.EditValue
        Misc_Bar.Visible = True
        Me.BarManager1.Items("btnOK").Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        If CurrentDefaultSetID <> 0 Then
            BKDefaultSet.LoadDefaultSet(CurrentDefaultSetID, Me)
            TabControl1.SelectedTabPage = TabResult
        Else
            TabControl1.SelectedTabPage = TabParameters
        End If

        clsDevExpress.sessionInfo = SessionInfo
    End Sub

    Private Sub loadData(ByVal sql As String)

        Dim dt As DataTable
        dt = DvdPostData.clsConnection.FillDataSet(sql, DvdPostData.clsConnection.typeAccessDb.WRITE)
        ' dt = DvdPostData.clsConnection.FillDataSet(sql)
        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()


        Grid1.DataSource = dt
        TabControl1.SelectedTabPage = TabResult
        clsDevExpress.AddHyperlinkDynamic(Grid1)
    End Sub


    Private Sub BtnFreeTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFreeTrial.Click
        Dim sql As String
        sql = DvdPostData.ClsCustomersData.GetFreeTrial()
        loadData(sql)
    End Sub


    Private Sub BtnStep31_33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStep31_33.Click
        Dim sql As String
        sql = DvdPostData.ClsStatCustomer.GetCustomersWithNotFinalySubscription(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub BtnWelcomeCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWelcomeCall.Click
        Dim sql As String
        sql = DvdPostData.ClsStatCustomer.GetCustomersWelcomeCall(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub btnDVDNoDVDFound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDVDNoDVDFound.Click
        Dim sql As String
        sql = DvdPostData.ClsStatCustomer.GetListDVDCustomersNoServed10Days(DvdPostData.clsProductDvd.Type_DVD.DVD_NORM)
        DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub btnFtAboStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFtAboStop.Click
        Dim sql As String
        sql = DvdPostData.ClsStatCustomer.GetListAboStopFt(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub btnListCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListCustomers.Click
        Dim sql As String
        sql = DvdPostData.ClsStatCustomer.GetListCustomers()
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)

    End Sub


    Private Sub btnWishlistCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWishlistCustomer.Click
        Dim sql As String = DvdPostData.ClsCustomersData.getSelectWishlistSize()
        loadData(sql)
    End Sub

    Private Sub btnCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCredit.Click
        Dim sql As String
        sql = DvdPostData.ClsStatCustomer.GetDvdReceivedPerMonth(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub btnCustomerStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomerStop.Click
        Dim sql As String
        sql = DvdPostData.ClsStatCustomer.GetSelectCustomersStop(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub btnProspect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProspect.Click
        Dim sql As String
        sql = DvdPostData.ClsStatCustomer.GetSelectProspectCustomers()
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub btnEarlierReconduction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEarlierReconduction.Click
        Dim sql As String
        sql = DvdPostData.ClsStatCustomer.GetSelectEarlierReconduction(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub
End Class