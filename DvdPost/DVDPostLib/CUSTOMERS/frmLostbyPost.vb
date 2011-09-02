Public Class frmLostbyPost

    Dim WithEvents _user1 As DevExpress.XtraBars.BarButtonItem = btnUser1

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Misc_Bar.Visible = True
        btnUser1.Caption = "status order : perdu par la poste"
        btnUser1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

    End Sub

    Private Sub loadDataset()
        Dim dt As DataTable
        dt = DVDPostBuziness.clsOrders.getOrderOneMonthkDelay()
        GridCheck.DataSource = dt.DefaultView
        clsDevExpress.AddHyperlinkDynamic(GridCheck)
        '  GridViewCallMeBrowse.PopulateColumns()

    End Sub

    Private Sub btnUser1_Click(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles _user1.ItemClick

        Dim orders_id As Integer
        Dim status As Integer

        If GridViewCheck.FocusedRowHandle < 0 Then Exit Sub
        orders_id = GridViewCheck.GetDataRow(GridViewCheck.FocusedRowHandle)("orders_id")
        status = GridViewCheck.GetDataRow(GridViewCheck.FocusedRowHandle)("orders_status")
        DVDPostBuziness.clsOrders.UpdateOrder(orders_id, DvdPostData.clsOdersStatusHistory.OrderStatusNew.LOST_BY_POST, status)
        loadDataset()
        MsgBox("termin�")
    End Sub



    Private Sub frmCheck_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadDataset()
    End Sub
End Class