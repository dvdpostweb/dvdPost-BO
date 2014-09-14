Public Class frmStatVOD
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
        ' clsDevExpress.AddHyperlinkDynamic(Grid1)
    End Sub



    Private Sub btnTopWatchedVOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopWatchedVOD.Click
        Dim sql As String
        sql = DvdPostData.clsStatVOD.GetSelectTopWatcheVOD(txtFromDate.EditValue, txtToDate.EditValue)

        loadData(sql)
    End Sub
   

    Private Sub btnVodByChannels_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVodByChannels.Click
        Dim sql As String
        sql = DvdPostData.clsStatVOD.GetSelectVODbyChannels(txtFromDate.EditValue, txtToDate.EditValue)

        loadData(sql)
    End Sub

    Private Sub btnVodByChannelsPlush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVodByChannelsPlush.Click
        Dim sql As String
        sql = DvdPostData.clsStatVOD.GetSelectVODbyChannelsPlush(txtFromDate.EditValue, txtToDate.EditValue)

        loadData(sql)
    End Sub

    Private Sub btnCustomersNmbrWathed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomersNmbrWathed.Click
        Dim sql As String
        sql = "call reportCustomerNumberOfWatched('" & DVDPostTools.ClsDate.formatDate(txtFromDate.EditValue) & "','" & DVDPostTools.ClsDate.formatDate(txtToDate.EditValue) & "')"

        loadData(sql)
    End Sub

    Private Sub btnCustomersByWatchedPlush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomersByWatchedPlush.Click
        Dim sql As String
        sql = DvdPostData.clsStatVOD.GetSelectNumberCustByNumbWatchedPlush(txtFromDate.EditValue, txtToDate.EditValue)

        loadData(sql)
    End Sub

    Private Sub btnSpentCreditEarlier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpentCreditEarlier.Click
        Dim sql As String
        sql = DvdPostData.clsStatVOD.GetSelectSpentCreditBefore(txtFromDate.EditValue, txtToDate.EditValue, speCreditEarlier.EditValue)

        loadData(sql)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim sql As String
        sql = DvdPostData.clsStatVOD.GetSelectNotSpentCredit(txtFromDate.EditValue, txtToDate.EditValue, speCreditEarlier.EditValue)

        loadData(sql)
    End Sub

    Private Sub btnTopWatchedKPN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopWatchedKPN.Click
        Dim sql As String
        sql = DvdPostData.clsStatVOD.GetSelectTopWatcheVOD_KPN(txtFromDate.EditValue, txtToDate.EditValue)

        loadData(sql)
    End Sub

    Private Sub btnTopWatchedPrisons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopWatchedPrisons.Click
        Dim sql As String
        sql = DvdPostData.clsStatVOD.GetSelectTopWatcheVOD_PRISONS(txtFromDate.EditValue, txtToDate.EditValue)

        loadData(sql)
    End Sub
End Class