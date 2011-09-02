Public Class ClsSurveys
    Public Shared Function GetLastIdDetail() As Integer

        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsSurveys.getInfoTableDetail()

        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt.Rows(0)("Auto_increment")
    End Function

    Public Shared Function GetLastId() As Integer

        Dim sql As String
        Dim dt As DataTable
        sql = DvdPostData.clsSurveys.getInfoTable()

        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt.Rows(0)("Auto_increment")
    End Function

End Class
