Public Class clsMessagerie

    Public Shared Function GetHistoryTicket(ByVal customers_id As Integer) As DataTable

        Dim dt As DataTable
        Dim sql As String


        sql = DvdPostData.clsMessagerie.GetHistoryTicket(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt


    End Function

    Public Shared Function GetHistoryMessage(ByVal ticket_id As Integer, ByVal language_id As Integer) As DataTable
        Dim dt As DataTable
        Dim sql As String


        sql = DvdPostData.clsMessagerie.GetHistoryMessage(ticket_id, language_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt

    End Function

    Public Shared Sub GetCreateTicket(ByVal customers_id As Integer, ByVal title As String, ByVal categorie_id As Integer)

        Dim sql As String
        Dim strCategorie As String

        If categorie_id > -1 Then
            strCategorie = categorie_id
        Else
            strCategorie = "null"
        End If

        
        sql = DvdPostData.clsMessagerie.GetCreateTicket(customers_id, title, strCategorie)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)



    End Sub


    Public Shared Function GetCategorieTicket() As DataTable
        Dim sql As String

        Dim dt As DataTable

        sql = DvdPostData.clsMessagerie.getCategorieTicket()
        dt = DvdPostData.clsConnection.FillDataSet(sql)

        Return dt

    End Function
    Public Shared Sub GetCreateFullMessage(ByVal customers_id As Integer, ByVal title As String, ByVal categorie_id As Integer, ByVal mail_id As Integer, ByVal variables As String, ByVal IdHistoryMail As Integer)

        Dim sql As String
        Dim last_id As Integer
        GetCreateTicket(customers_id, title, categorie_id)

        sql = DvdPostData.clsMessagerie.getLastId()
        last_id = DvdPostData.clsConnection.ExecuteScalar(sql)

        GetCreateMessage(last_id, mail_id, variables, IdHistoryMail)


    End Sub


    Public Shared Sub GetCreateMessage(ByVal ticket_id As Integer, ByVal mail_id As Integer, ByVal variables As String, ByVal IdHistoryMail As Integer)
        Dim sql As String

        sql = DvdPostData.clsMessagerie.GetCreateMessage(ticket_id, mail_id, variables, IdHistoryMail)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Public Shared Sub setFlagReadMessage(ByVal TicketMessage_id As Integer, ByVal read As Boolean)

        Dim sql As String

        sql = DvdPostData.clsMessagerie.getFlagReadMessage(ticketMessage_id, read)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub

    Public Shared Sub setFlagReadMessage(ByVal ticket_id)

        Dim sql As String

        sql = DvdPostData.clsMessagerie.getFlagReadMessage(ticket_id)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
    End Sub

End Class
