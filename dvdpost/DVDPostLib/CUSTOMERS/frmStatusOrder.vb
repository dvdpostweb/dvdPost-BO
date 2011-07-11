Public Class frmStatusOrder




    Private _customers_id As Integer
    Public Property customers_id() As Integer
        Get
            Return _customers_id
        End Get
        Set(ByVal value As Integer)
            _customers_id = value
        End Set
    End Property


    Private _oldStatus As Integer
    Public Property oldstatus() As Integer
        Get
            Return _oldStatus
        End Get
        Set(ByVal value As Integer)
            _oldStatus = value
        End Set
    End Property


    Private _orders_id As Integer
    Public Property orders_id() As Integer
        Get
            Return _orders_id
        End Get
        Set(ByVal value As Integer)
            _orders_id = value
            lblValueOrder_id.Text = _orders_id
        End Set
    End Property
    Private Sub refreshform(ByVal current_status As DvdPostData.clsOdersStatusHistory.OrderStatusNew)

        Select Case current_status
            Case DvdPostData.clsOdersStatusHistory.OrderStatusNew.INTERCHANGE
                txtDVDid.Visible = True
                txtProducts_id.Visible = True
                lblDvdId.Visible = True
                lblProducts_id.Visible = True
                btnChangeOrderStatus.Visible = True
                btncreateInvoice.Visible = False
            Case DvdPostData.clsOdersStatusHistory.OrderStatusNew.BROKEN_CHARGE
                txtDVDid.Visible = False
                txtProducts_id.Visible = False
                txtDVDid.Text = Nothing
                txtProducts_id.Text = Nothing
                lblDvdId.Visible = False
                lblProducts_id.Visible = False
                btnChangeOrderStatus.Visible = False
                btncreateInvoice.Visible = True
            Case Else
                txtDVDid.Visible = False
                txtProducts_id.Visible = False
                txtDVDid.Text = Nothing
                txtProducts_id.Text = Nothing
                lblDvdId.Visible = False
                lblProducts_id.Visible = False
                btnChangeOrderStatus.Visible = True
                btncreateInvoice.Visible = False
        End Select

    End Sub

    Private Sub changeOrder(ByVal orders_id As Integer, ByVal status As DvdPostData.clsOdersStatusHistory.OrderStatusNew, ByVal oldstatus As DvdPostData.clsOdersStatusHistory.OrderStatusNew)
        Dim sql As String = ""
        DVDPostBuziness.clsOrders.UpdateOrder(orders_id, status, oldstatus)
        MsgBox("termin�")
    End Sub
    Private Sub changeOrderProduct(ByVal orders_id As Integer, ByVal status As DvdPostData.clsOdersStatusHistory.OrderStatusNew, ByVal oldstatus As DvdPostData.clsOdersStatusHistory.OrderStatusNew, ByVal products_id As String, ByVal dvdid As String)
        Dim sql As String = ""
        Dim dt As DataTable = Nothing
        Dim update As Boolean = True

        If products_id = Nothing Or dvdid = Nothing Then
            MsgBox("Entrez product_id et dvd_id avant de poursuivre")
            update = False
        Else
            sql = DvdPostData.clsOdersStatusHistory.getSelectSearchCustomers_id(products_id, dvdid)
            dt = DvdPostData.clsConnection.FillDataSet(sql)
            If dt.Rows.Count = 1 Then
                If MsgBox("interchange avec l'orders = " & dt.Rows(0)("orders_id") & " customers _id = " & dt.Rows(0)("customers_id") & " voulez vous continuer ? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    update = False
                End If
            ElseIf dt.Rows.Count = 0 Then
                If MsgBox("etes vous sur de l'identifiant du DVD ! voulez vous continuer ? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    update = False
                End If

            Else
                MsgBox("il semblerait que plusieurs personne possedent le meme dvd ! ceci est impossible", MsgBoxStyle.Critical)
                update = False
            End If

        End If
        If update Then
            DVDPostBuziness.clsOrders.UpdateOrder(orders_id, status, oldstatus, products_id, dvdid)
            If status = DvdPostData.clsOdersStatusHistory.OrderStatusNew.INTERCHANGE And dt IsNot Nothing Then
                DVDPostBuziness.clsOrders.UpdateOrder(dt.Rows(0)("orders_id"), DvdPostData.clsOdersStatusHistory.OrderStatusNew.TEMPORARY_INTERCHANGE, oldstatus)
            End If
            MsgBox("termin�")
        End If

    End Sub

    Private Sub btnChangeOrderStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangeOrderStatus.Click
        If txtProducts_id.Text = Nothing And txtDVDid.Text = Nothing Then
            changeOrder(_orders_id, cmbStatusOrder.EditValue, oldstatus)
        Else
            changeOrderProduct(_orders_id, cmbStatusOrder.EditValue, oldstatus, txtProducts_id.Text, txtDVDid.Text)
        End If
        Me.Close()
    End Sub

    Private Sub loadOrderStatus()
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsOdersStatusHistory.GetSelectStatusOrder()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        cmbStatusOrder.Properties.DisplayMember = "name"
        cmbStatusOrder.Properties.ValueMember = "id"
        cmbStatusOrder.Properties.DataSource = dt
        cmbStatusOrder.Undo()
        cmbStatusOrder.EditValue = Nothing
        cmbStatusOrder.ItemIndex = 0

    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
       
       
    End Sub

    Private Sub cmbStatusOrder_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatusOrder.EditValueChanged
        refreshform(cmbStatusOrder.EditValue)
    End Sub

    Private Sub btncreateInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncreateInvoice.Click
        DVDPostBuziness.ClsCustomers.CreateInvoiceDvd(_customers_id)
        changeOrder(_orders_id, cmbStatusOrder.EditValue, oldstatus)
        Me.Close()
    End Sub

    Private Sub frmStatusOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadOrderStatus()
        refreshform(0)
    End Sub
End Class