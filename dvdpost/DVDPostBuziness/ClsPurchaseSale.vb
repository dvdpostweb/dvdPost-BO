Public Class ClsPurchaseSale

    Public Function CreatePrevisionAchat() As Boolean
        Dim sql As String

        sql = DvdPostData.ClsPurchaseSale.GetInsertCreateRateRotationAbo()
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

        sql = DvdPostData.ClsPurchaseSale.GetDeletePrevisionPurchaseCurrentdate()
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

        sql = DvdPostData.ClsPurchaseSale.getInsertCreatePrevisionAchat("DVD_NORM")
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

        Return True

    End Function

    Public Function ViewBreakSeries() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsPurchaseSale.GetSelectSeriesBreak()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
    Public Function ViewAlgoPurchasesOrderClosedCurrent() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsPurchaseSale.GetSelectCurrentOrdersClosedPurchase()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
    Public Function ViewAlgoPurchasesOrderCurrent() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsPurchaseSale.GetSelectCurrentOrdersPurchase()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt
    End Function

    Public Function ViewAlgoPurchasesSalesByProduct(ByVal product_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsPurchaseSale.GetSelectViewPurchaseSaleByProducts(product_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt
    End Function
    Public Function ViewAlgoPurchase() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsPurchaseSale.GetSelectViewPurchase()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt
    End Function

    Public Function ViewAlgoSale() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.ClsPurchaseSale.GetSelectViewSale()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt
    End Function

    'Public Function ViewAlgo() As DataTable
    '    Dim sql As String
    '    Dim dt As DataTable

    '    sql = DvdPostData.ClsPurchaseSale.GetSelectViewPurchase()
    '    dt = DvdPostData.clsConnection.FillDataSet(sql)

    '    Return dt
    'End Function
End Class
