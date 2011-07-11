Public Class clsMsgError

    Const MAILTO As String = "dvb@dvdpost.be"
    Const Subject As String = "ERROR DVDPost Bo : "
    Const Author As String = " User : "
    Const PATHLOG As String = "Path_LOG"

    Public Shared Function InsertLogMsg(ByVal Type As DvdPostData.clsMsgError.processType, ByVal msgError As String, Optional ByVal customers_id As String = Nothing) As Boolean
        Dim sql As String
        Dim cpt As Integer
        Dim strsubject As String
        msgError = msgError + " version : " & DvdPostData.clsSession.Version
        strsubject = Subject & DVDPostTools.clsEnum.getNameStrEnum(Type) & Author & DvdPostData.clsSession.user_id
        sql = DvdPostData.clsMsgError.InsertLogMsg(Type, msgError, customers_id)
        cpt = DvdPostData.clsConnection.ExecuteNonQuery(sql, True)

        clsMail.SendMail(msgError, strsubject, MAILTO)
        Return cpt = 1
    End Function


    Public Shared Function InsertLogMsg(ByVal Type As DvdPostData.clsMsgError.processType, ByVal ex As Exception, Optional ByVal customers_id As String = Nothing) As Boolean
        Dim msgerror As String

        msgerror = ex.Message & " " & ex.StackTrace
        Return InsertLogMsg(Type, msgerror, customers_id)
    End Function

    Public Shared Function FileAppend(ByVal namefile As String, ByVal strmsg As String) As Boolean
        Dim path As String

        Try
            namefile = namefile + "_" + DateTime.Now.ToString("dd-MM-yy") & ".txt"
            strmsg = DateTime.Now.ToString() + " " + DvdPostData.clsConnection.typeEnv + " " + strmsg
            path = Configuration.ConfigurationManager.AppSettings(PATHLOG)
            path = path + namefile
            DVDPostTools.clsFile.WriteFileAppend(path, strmsg)

            Return True
        Catch ex As Exception
            Microsoft.VisualBasic.MsgBox(" Error File " & ex.Message & " " & strmsg)
            Return False
        End Try

    End Function

    Public Shared Function FileAppend(ByVal strmsg As String) As Boolean
        Dim path As String
        Dim namefile As String
        Try
            namefile = "Log_BO_DVDPOST_" + DateTime.Now.ToString("dd-MM-yy") & ".txt"
            strmsg = DateTime.Now.ToString() + " " + DvdPostData.clsConnection.typeEnv + " " + strmsg
            path = Configuration.ConfigurationManager.AppSettings(PATHLOG)
            path = path + namefile
            DVDPostTools.clsFile.WriteFileAppend(path, strmsg)

            Return True
        Catch ex As Exception
            Microsoft.VisualBasic.MsgBox(" Error File " & ex.Message & " " & strmsg)
            Return False
        End Try

    End Function
    Public Shared Function MsgBox(ByVal strMsg As String) As Object
        If Not DvdPostData.clsSession.isBatch Then
            Return Microsoft.VisualBasic.MsgBox(strMsg)
        Else
            FileAppend(strMsg)
            Return Nothing
        End If
    End Function

    Public Shared Function MsgBox(ByVal strMsg As String, ByVal msgBoxType As MsgBoxStyle) As MsgBoxResult

        If Not DvdPostData.clsSession.isBatch Then
            Return Microsoft.VisualBasic.MsgBox(strMsg, msgBoxType)
        Else

            FileAppend(strMsg)
            Return MsgBoxResult.Ok
        End If
    End Function
End Class
