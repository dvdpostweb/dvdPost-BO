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
   

End Class