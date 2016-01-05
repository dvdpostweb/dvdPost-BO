

Public Class clsMemberGetMember

    Public Shared Function AddPointFather(ByVal son_id) As Boolean
        Dim sql As String
        Dim dt As DataTable
        Dim father_id As Integer
        Dim point As Integer
        Dim dtFatherInfo As DataTable
        Dim sqlFatherInfo As String

        sql = DvdPostData.clsMemberGetMember.GetRowFather(son_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        If dt.Rows.Count > 0 Then
            father_id = dt.Rows(0)("father_id")
            point = dt.Rows(0)("expected_points")


            sql = DvdPostData.clsMemberGetMember.updateAddPointCustomers(father_id, point)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)
            sql = DvdPostData.clsMemberGetMember.insertCustomersPointHist(father_id, DvdPostData.clsMemberGetMember.PointsHistoryAction.ADD, DvdPostData.clsMemberGetMember.PointsHistorySubAction.POINT_GIVEN_TO_SON, point)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

            sql = DvdPostData.clsMemberGetMember.updatePointSon(son_id, point)
            DvdPostData.clsConnection.ExecuteNonQuery(sql)

            sqlFatherInfo = DvdPostData.clsMemberGetMember.getGodsonAndSponsorInfo(son_id, point)
            dtFatherInfo = DvdPostData.clsConnection.FillDataSet(sqlFatherInfo)
            Try
                DVDPostBuziness.clsMail.SendMail(dtFatherInfo.Rows(0), clsMail.Mail.MAIL_SON_ACTIVATION, True, dtFatherInfo.Rows(0)("customers_email_address"), DvdPostData.clsMemberGetMember.MAIL_FROM_SPONSOR, DvdPostData.clsMemberGetMember.MAIL_FROM_SPONSOR_NAME)
            Catch ex As Exception
                Dim father As String = father_id.ToString()
                clsMsgError.InsertLogMsg(DvdPostData.clsMsgError.processType.Reconduction, ex, father)
            End Try


        Else
            Return False
        End If

    End Function


End Class
