Public Class ClsInventory

    Public Shared Function isAboprocessRun() As Boolean
        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.AboProcessData.IsAboprocessRun()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt.Rows.Count > 0

    End Function

End Class
