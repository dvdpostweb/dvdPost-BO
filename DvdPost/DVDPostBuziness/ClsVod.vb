Public Class ClsVod

    Public Shared Sub InsertStatVod()
        Dim sql As String

        sql = DvdPostData.ClsVod.InsertStatVod()
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

    End Sub

    Public Shared Sub UpdateVodCreditsAfterStartPeriod()

        Dim sql As String

        sql = DvdPostData.ClsVod.UpdateVodCreditsAfterStartingPeriod()
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub

End Class
