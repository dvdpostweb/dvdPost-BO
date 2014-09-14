Public Class clsStatVOD


    Public Shared Function GetSelectTopWatcheVOD(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select cnt.imdb_id,p.products_id, p.products_title, cnt.watched, " & _
                " (select studio_name from studio s where s.studio_id = sp.studio_id) as studio, " & _
                " sp.expire_at " & _
                " from ( select t.imdb_id, count(*) watched from tokens t where date(t.created_at) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' group by imdb_id ) cnt " & _
                " join streaming_products sp on cnt.imdb_id = sp.imdb_id " & _
                " join products p on cnt.imdb_id = p.imdb_id where sp.status <> 'deleted' and sp.source = 'alphanetworks'" & _
                " group by cnt.imdb_id order by cnt.watched desc"
        Return sql
    End Function

    Public Shared Function GetSelectTopWatcheVOD_KPN(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select cnt.imdb_id,p.products_id, p.products_title, cnt.watched, " & _
                " (select studio_name from studio s where s.studio_id = sp.studio_id) as studio, " & _
                " sp.expire_at " & _
                " from ( select t.imdb_id, count(*) watched from an_kpn_reports t where date(t.date_achat) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.date_achat) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' group by imdb_id ) cnt " & _
                " join streaming_products sp on cnt.imdb_id = sp.imdb_id " & _
                " join products p on cnt.imdb_id = p.imdb_id where sp.status <> 'deleted' and sp.source = 'alphanetworks'" & _
                " group by cnt.imdb_id order by cnt.watched desc"
        Return sql
    End Function

    Public Shared Function GetSelectTopWatcheVOD_PRISONS(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select cnt.imdb_id,p.products_id, p.products_title, cnt.watched, " & _
                " (select studio_name from studio s where s.studio_id = sp.studio_id) as studio, " & _
                " sp.expire_at " & _
                " from ( select t.imdb_id, count(*) watched from prison_reports t where date(t.watched_date) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.watched_date) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' group by imdb_id ) cnt " & _
                " join streaming_products sp on cnt.imdb_id = sp.imdb_id " & _
                " join products p on cnt.imdb_id = p.imdb_id where sp.status <> 'deleted' and sp.source = 'alphanetworks'" & _
                " group by cnt.imdb_id order by cnt.watched desc"
        Return sql
    End Function

    Public Shared Function GetSelectVODbyChannels(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select year(t.created_at) Y, month(t.created_at) M," & _
"case t.source_id " & _
"when 53 then 'IDEVICES' " & _
"when 54 then " & _
"(select " & _
"case s.device when 3 then 'LG' when 4 then 'Samsung' when 5 then 'Panasonic' when 6 then 'Sony' when 7 then 'Philips' else 'Unknown' end " & _
"from dvdpost_smarttv.mobile_log s " & _
"where t.customer_id = s.customers_id " & _
"and t.token = s.parameters " & _
"and s.method = 'getVodTokenAndLngs 4 token ' limit 1) " & _
"else 'WEBSITE' end source,  count(t.id) " & _
"from tokens t " & _
"where date(t.created_at) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' " & _
" group by 1,2,3 order by 1, 2,3 "

        Return sql
    End Function

    Public Shared Function GetSelectVODbyChannelsPlush(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select year(t.created_at) Y, month(t.created_at) M," & _
"case t.source_id " & _
"when 53 then 'IDEVICES' " & _
"when 54 then 'Samsung' " & _
"else 'WEBSITE' end source,  count(t.id) " & _
"from plush_production.tokens t " & _
"where date(t.created_at) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' " & _
" group by 1,2,3 order by 1, 2,3 "

        Return sql
    End Function

    Public Shared Function GetSelectNumberCustByNumbWatchedPlush(ByVal dateFrom As String, ByVal dateTo As String)
        Dim sql As String
        sql = "call reportCustomerNumberOfWatchedPlush('" & DVDPostTools.ClsDate.formatDate(dateFrom) & "','" & DVDPostTools.ClsDate.formatDate(dateTo) & "')"

        Return sql
    End Function

    Public Shared Function GetSelectSpentCreditBefore(ByVal dateFrom As String, ByVal dateTo As String, ByVal nbdays As Integer)
        Dim sql As String
        sql = "select * from potential_upgrades where credit_spent_date >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and credit_spent_date <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' " & "and nb_days = " & nbdays

        Return sql
    End Function

    Public Shared Function GetSelectNotSpentCredit(ByVal dateFrom As String, ByVal dateTo As String, ByVal nbdays As Integer)
        Dim sql As String
        sql = "CALL reportCustomersNotSpendCredit('" & DVDPostTools.ClsDate.formatDate(dateFrom) & "', '" & DVDPostTools.ClsDate.formatDate(dateTo) & "') "

        Return sql
    End Function

End Class
