Public Class clsCreditHistory

    Public Enum ActionId
        ABOPROCESS = 1
        PROCESSIN = 2
        DELETEORDER = 3
        FREERECONDUCTION = 4
        RECONDUCTION = 5
        FREEUPGRADE = 6
        INIT = 7
        MANUAL_CREDIT = 8
        PROMO_COMBINED = 9
        KDO = 10
        MANUAL_ASSIGN = 11
        VOD = 12
        VOD_MORE_IP = 13
        LONGTIME_DVD = 14
    End Enum

    Public Enum ActionValue
        ABOPROCESS = -1
        MANUAL_ASSIGN = -1
    End Enum



    Public Shared Function GetCreditHistory() 'ByVal startDate As DateTime, ByVal endDate As DateTime) As String
        Dim sql As String
        sql = " select ch.id, ch.customers_id,ch.credit + ch.quantity_paid + quantity_free + credit_free total," & _
              " ch.credit + ch.quantity_paid total_paid," & _
              " ch.credit, ch.quantity_paid, " & _
              " ch.user_modified, ch.date_added, ca.name as action_name," & _
              " quantity_free + credit_free total_free , quantity_free , credit_free , orders_id " & _
        "from credit_history ch left join credit_action ca on ca.id = ch.credit_action_id "
        Return sql
    End Function


    Public Shared Function GetInsertCreditHistory(ByVal quantity As Integer, ByVal customers_id As Integer, ByVal action As ActionId, Optional ByVal orders_id As Integer = Nothing, Optional ByVal oldCredit As Integer = Nothing) As String
        Dim sql As String
        '  Dim credit As String

        ' sql = "insert into credit_history (customers_id , credit_action_id ,credit , added_paid , user_modified , quantity_free , credit_free)" & _
        '                   "  values (" & customersId & ", " & action & " ,   ( " & GetCustomerCredit(customersId) & ")  , " & quantity & ", " & clsSession.user_id & ")"

        'If oldCredit = Nothing Then
        '    credit = GetCustomerCredit(customers_id)
        'Else
        '    credit = oldCredit
        'End If


        sql = "insert into credit_history (customers_id , credit_action_id , user_modified,credit , quantity_paid ,  quantity_free , credit_free , orders_id )" & _
              " select " & customers_id & " , " & action & " , " & clsSession.user_id & " , " & GetCreditPaidOrFree(customers_id, quantity, action, orders_id)


        If orders_id <> Nothing Then
            sql = sql + " , " & orders_id
        Else
            sql = sql + " , null "
        End If

        Return sql
    End Function
    Public Shared Function GetLastCreditHistory(ByVal customers_id As Integer) As String
        Dim sql As String

        sql = " select ch.* from credit_history ch join " & _
              "(select customers_id,max(id) id from credit_history where customers_id = " & customers_id & " group by customers_id) max_credit " & _
             " on ch.customers_id = max_credit.customers_id and ch.id = max_credit.id "

        Return sql
      
    End Function
    Public Shared Function GetCustomerCredit(ByVal customersId As Integer) As String
        'Dim credit As Object
        Dim sql As String = "select customers_abo_dvd_credit from customers where customers_id = " & customersId
        'credit = DvdPostData.clsConnection.ExecuteScalar(sql)
        Return sql 'CType(credit, Integer)
    End Function


    Public Shared Function GetCreditHistoryByCust(ByVal customers_id As Integer) As String
        Dim sql
        sql = GetCreditHistory() + " where customers_id  = " & customers_id & " order by ch.id desc"
        Return sql
    End Function

    Public Shared Function GetCreditPaidOrFree(ByVal customers_id As Integer, ByVal quantity_credit As Integer, ByVal action As ActionId, ByVal orders_id As Integer) As String
        Dim dt As DataTable
        Dim insertField As String = ""
        Dim SumCreditQuantFree As Integer
        Dim SumCreditPaid As Integer
        Dim credit_free As Integer
        Dim quantity_free As Integer
        Dim credit_Paid As Integer
        Dim quantity_Paid As Integer
        'dt = DvdPostData.clsConnection.FillDataSet(GetCreditHistoryByCust(customers_id) + " limit 1") '"select ( credit_free + quantity_free) from credit_history where customers_id = " & customers_id & " order by id desc limit 1 ")
        dt = DvdPostData.clsConnection.FillDataSet(GetLastCreditHistory(customers_id))

        If dt.Rows.Count = 0 Then
            credit_free = 0
            quantity_free = 0
        Else
            credit_free = dt.Rows(0)("credit_free")
            quantity_free = dt.Rows(0)("quantity_free")
            credit_Paid = dt.Rows(0)("credit")
            quantity_Paid = dt.Rows(0)("quantity_paid")
        End If

        SumCreditQuantFree = credit_free + quantity_free
        SumCreditPaid = credit_Paid + quantity_Paid

        Dim strFree As String = SumCreditPaid & ",0," & quantity_credit & "," & SumCreditQuantFree
        Dim strpaid As String = SumCreditPaid & "," & quantity_credit & ",0," & SumCreditQuantFree

        Select Case action
            Case ActionId.FREERECONDUCTION, ActionId.FREEUPGRADE
                insertField = strFree

            Case ActionId.DELETEORDER
                credit_free = GetOrdersFree(customers_id, orders_id)
                If credit_free > 0 Then
                    insertField = strFree
                Else
                    insertField = strpaid
                End If
            Case ActionId.MANUAL_CREDIT

                insertField = strFree

            Case ActionId.ABOPROCESS, ActionId.MANUAL_ASSIGN, ActionId.LONGTIME_DVD
                If SumCreditQuantFree > 0 Then
                    insertField = strFree
                Else
                    insertField = strpaid
                End If

            Case ActionId.RECONDUCTION
                insertField = strpaid
        End Select



        Return insertField
    End Function


    Public Shared Function GetOrdersIdCreditHistory(ByVal customers_id As Integer, ByVal orders_id As Integer) As String
        Dim sql As String = "select credit_free from credit_history where customers_id = " & customers_id & "  and orders_id = " & orders_id & " order by id desc limit 1 "
        Return sql
    End Function


    Private Shared Function GetOrdersFree(ByVal customers_id As Integer, ByVal orders_id As Integer) As Integer
        Dim credit_free As Integer
        credit_free = DvdPostData.clsConnection.ExecuteScalar(GetOrdersIdCreditHistory(customers_id, orders_id))

        If credit_free > 0 Then
            Return credit_free
        End If

        Return Nothing

    End Function


End Class
