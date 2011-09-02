Public Class ClsLandings

    Public Shared Function GetLastId() As Integer

        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsLandings.getInfoTable()

        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt.Rows(0)("Auto_increment")
    End Function

End Class
