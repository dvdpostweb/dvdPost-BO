Public Class frmStatPayment
    Inherits BizzLib.frmGeneral_Browse

    Private Sub This_frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MenuStrip As New dvdpostbuziness.contextMenu()

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
    End Sub

    Private Sub loadData(ByVal sql As String)

        Dim dt As DataTable
        dt = DvdPostData.clsConnection.FillDataSet(sql, DvdPostData.clsConnection.typeAccessDb.READ)
        ' dt = DvdPostData.clsConnection.FillDataSet(sql)
        Grid1.DataSource = Nothing
        Grid1.Views(0).PopulateColumns()

        Grid1.DataSource = dt
        TabControl1.SelectedTabPage = TabResult

        clsDevExpress.AddHyperlinkDynamic(Grid1)

    End Sub


    Private Sub btnStatOgone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStatOgone.Click
        Dim sql As String

        sql = DvdPostData.ClsStatPayment.getSelectCustPaidWithOgone(txtFromDate.EditValue, txtToDate.EditValue)
        loadData(sql)
    End Sub



    Private Sub BtnDomPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDomPaid.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.getSelectCustPaidWithDomiciliation(txtFromDate.EditValue, txtToDate.EditValue)
        loadData(sql)

    End Sub

    Private Sub BtnBankTransferPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBankTransferPaid.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.getSelectCustPaidWithBankTransfer(txtFromDate.EditValue, txtToDate.EditValue)
        loadData(sql)
    End Sub

    Private Sub btnUnpaidOgone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnpaidOgone.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.getSelectCustUnPaidWithOgone(txtFromDate.EditValue, txtToDate.EditValue)
        loadData(sql)
    End Sub

    Private Sub btnCancelOgone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelOgone.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.getSelectCustCancelWithOgone(txtFromDate.EditValue, txtToDate.EditValue)
        loadData(sql)
    End Sub


    Private Sub BtnUnusedCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnusedCredit.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.getSelectUnUsedCredit()
        loadData(sql)
    End Sub

    Private Sub BtnDroseliaSale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDroseliaSale.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.getSelectDroseliaSale(txtFromDate.EditValue, txtToDate.EditValue)
        loadData(sql)
    End Sub

    Private Sub btnCreditHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreditHistory.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.GetStatCustomersCreditHistory(txtFromDate.EditValue, txtToDate.EditValue)
        DvdPostData.clsConnection.timeoutMIN = 30
        loadData(sql)
    End Sub


    Private Sub btnViewStopCreditHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewStopCreditHistory.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.GetStatCustomersStopCreditHistory(txtFromDate.EditValue, txtToDate.EditValue)
        DvdPostData.clsConnection.timeoutMIN = 20
        loadData(sql)
    End Sub

    Private Sub btnViewVodHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewVodHistory.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.GetViewVodHistorique(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub BtnLongTimeCust_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLongTimeCust.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.GetViewCustomersLostMoreMonth(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub

    Private Sub btnVodStatusHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVodStatusHistory.Click
        Dim sql As String
        sql = DvdPostData.ClsStatPayment.GetViewStatVod(txtFromDate.EditValue, txtToDate.EditValue)
        'DvdPostData.clsConnection.timeoutMIN = 10
        loadData(sql)
    End Sub
End Class