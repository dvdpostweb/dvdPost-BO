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

    Public Shared Sub UpdateSoonVod()

        Dim sql As String

        sql = DvdPostData.ClsVod.UpdateSoonVod()
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Public Shared Sub UpdateGeoIP()
        Dim sql As String

    End Sub


End Class
