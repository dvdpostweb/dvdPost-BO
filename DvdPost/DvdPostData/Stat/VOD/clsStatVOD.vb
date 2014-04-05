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

    Public Shared Function GetSelectVODbyChannels(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " select year(t.created_at) Y, month(t.created_at) M," & _
"case t.source_id " & _
"when 53 then 'IDEVICES' " & _
"when 54 then " & _
"(select " & _
"case s.device when 3 then 'LG' when 4 then 'Samsung' when 5 then 'Panasonic' when 6 then 'Sony' when 7 then 'Philips' else '' end " & _
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
"when 54 then " & _
"(select " & _
"case s.device when 3 then 'LG' when 4 then 'Samsung' when 5 then 'Panasonic' when 6 then 'Sony' when 7 then 'Philips' else '' end " & _
"from plush_mobile.mobile_log s " & _
"where t.customer_id = s.customers_id " & _
"and t.token = s.parameters " & _
"and s.method = 'getVodTokenAndLngs 4 token ' limit 1) " & _
"else 'WEBSITE' end source,  count(t.id) " & _
"from plush_production.tokens t " & _
"where date(t.created_at) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' " & _
" group by 1,2,3 order by 1, 2,3 "

        Return sql
    End Function

    Public Shared Function GetSelectNumberCustByNumbWatchedPlush()
        Dim sql As String
        sql = "SELECT report_year, report_month, count_watched_movies, count(customer_id) FROM studio_reporting.customers_counter group by 1,2,3 order by 1,2,3"

        Return sql
    End Function

    Public Shared Function GetSelectSpentCreditBefore(ByVal dateFrom As String, ByVal dateTo As String, ByVal nbdays As Integer)
        Dim sql As String
        sql = "select * from potential_upgrades where credit_spent_date >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and credit_spent_date <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' " & "and nb_days = " & nbdays

        Return sql
    End Function

    Public Shared Function GetSelectNotSpentCredit(ByVal dateFrom As String, ByVal dateTo As String, ByVal nbdays As Integer)
        Dim sql As String
        sql = "select * " & _
" from (select a1.customerid customers_id, a1.last_abo_start, a2.date last_abo_end " & _
" from (select a1.customerid, max(date) last_abo_start from abo a1 where a1.action in (6,7,8,17) and a1.date < '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' group by a1.customerid) a1 " & _
" join (select * from abo a1 where a1.action = 7 and a1.date between '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and '" & DVDPostTools.ClsDate.formatDate(dateTo) & "') a2 on a1.customerid = a2.customerid) tp " & _
" left join potential_upgrades pu on tp.customers_id = pu.customers_id " & _
"  and pu.credit_spent_date between tp.last_abo_start and tp.last_abo_end where  pu.nb_days is null"

        Return sql
    End Function

End Class
