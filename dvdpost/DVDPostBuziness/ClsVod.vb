Public Class ClsVod

    Public Shared Sub InsertStatVod()
        Dim sql As String

        sql = DvdPostData.ClsVod.InsertStatVod()
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

    End Sub
 

End Class
