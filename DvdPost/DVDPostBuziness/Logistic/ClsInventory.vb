Public Class ClsInventory

    Public Shared Function isAboprocessRun() As Boolean
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.AboProcessData.IsAboprocessRun()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt.Rows.Count > 0

    End Function

    Public Shared Function isNPP(ByVal customers_id As String) As Boolean
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.ClsCustomersData.GetSelectNPPCreditByCustomer(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt.Rows(0)(0) > 0

    End Function

End Class
