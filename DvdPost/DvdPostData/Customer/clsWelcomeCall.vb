Public Class clsWelcomeCall

    Public Shared Function getselectWelcomeCall() As String
        Dim sql As String

        sql = " select c.customers_id customers_id , c.customers_firstname, c.customers_lastname, c.customers_language, c.customers_email_address, c.customers_telephone, c.customers_abo_validityto, " & _
              " c.welcomecall_hour, c.welcomecall_day, c.welcomecall_done, " & _
              " (select count(id) from tokens t where t.customer_id = a.customerid and t.created_at > date_add(now(), interval -30 day)) vodwatched, " & _
              " (select count(wl_id) from wishlist w where w.customers_id = a.customerid and w.date_added > date_add(now(), interval -30 day)) inwishlist, " & _
              " (SELECT sum(-1 * quantity_free) + sum(-1 * quantity_paid) spent_credit FROM credit_history where customers_Id = a.customerid and (quantity_free< 0 or quantity_paid < 0) and date_added > date_add(now(), interval -30 day))credit_used, " & _
              " c.customers_abo_dvd_credit " & _
              " FROM (select * from abo a WHERE a.Action in (1, 6, 8) and a.Date > date_add(now(), interval -30 day) " & _
              "        and not exists(select * from abo a1 where a1.customerid = a.customerid and a1.action in(6, 7, 8)    and a1.date < date_add(now(), interval -30 day)" & _
              " and a1.date > date_add(now(),interval -1 year) ) ) a " & _
              " join customers c on a.customerid = c.customers_id where c.welcomecall_done = 0 "

        Return sql
    End Function

    Public Shared Function getselectforUpdate() As String
        Dim sql As String

        sql = " select customers_id, welcomecall_hour, welcomecall_day, welcomecall_done FROM customers where welcomecall_done = 0 "
        Return sql
    End Function

    Public Shared Function getUpdateWelcomecall(ByVal id As Integer) As String
        Dim sql As String
        sql = "UPDATE customers set welcomecall_done = 1,customers_info_date_account_last_modified = now() " & _
               " WHERE customers_id = " & id
        Return sql
    End Function

End Class
