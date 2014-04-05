Public Class frmWelcomeCall
    Inherits BizzLib.frmBKForm
    Private _dt As DataTable

    'Dim WithEvents _user1 As DevExpress.XtraBars.BarButtonItem = btnUser1
    'Private WithEvents _btnok As DevExpress.XtraBars.BarButtonItem = btnOK

    Private Sub frmWelcomeCall_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadDataset()
        'ManageRepository()
    End Sub

    Private Sub loadDataset()
        Dim sql As String

        sql = DvdPostData.clsWelcomeCall.getselectWelcomeCall()
        _dt = DvdPostData.clsConnection.FillDataSet(sql)
        GridcallMeBrowse.DataSource = _dt.DefaultView
        clsDevExpress.AddHyperlinkDynamic(GridcallMeBrowse)
        '  GridViewCallMeBrowse.PopulateColumns()

    End Sub
End Class