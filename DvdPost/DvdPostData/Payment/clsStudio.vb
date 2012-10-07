Public Class clsStudio

    Public Shared Function GetEnumMysqlStudioType() As String
        Dim sql As String

        sql = "SHOW COLUMNS FROM studio LIKE 'studio_type' "
        Return sql
    End Function
    Public Shared Function GetEnumMysqlBillingReportType() As String
        Dim sql As String

        sql = "SHOW COLUMNS FROM studio LIKE 'billing_report_type' "
        Return sql
    End Function

    Public Shared Function getSelectStudioByStudioID(ByVal studio_id As String) As String
        Dim sql As String

        sql = " select * from studio where studio_id = " & studio_id

        Return sql
    End Function

    Public Shared Function GetStudioBilling() As String
        Dim sql As String
        sql = "select studio_id,studio_name from studio where billing_reporting = 1 "
        Return sql
    End Function

    Public Shared Function getSelectStudioByStudioNameAndStudioType(ByVal studio_name As String, ByVal studio_type As String) As String
        Dim sql As String

        sql = " select * from studio where studio_name like '%" & studio_name & "%' and studio_type like '%" & studio_type & "%'"

        Return sql
    End Function

    Public Shared Function getSelectStudioAll() As String
        Dim sql As String

        sql = " select * from studio"

        Return sql
    End Function

    Public Shared Function getInsertStudio(ByVal studio_name As String, ByVal studio_type As String, ByVal cost_for_new As Int16, ByVal cost As Int16, _
                                            ByVal fee_new_vod As String, ByVal fee_back_catalogue As String, ByVal minimum_new_vod As String, _
                                            ByVal minimum_back_catalogue As String, ByVal minimum_global As String, ByVal billing_reporting As Boolean, ByVal billing_report_type As String) As String
        Dim sql As String

        sql = " insert into studio ( studio_name, studio_type, cost_for_new, cost, fee_new_vod, fee_back_catalogue,  minimum_new_vod, minimum_back_catalogue, minimum_global, billing_reporting, billing_report_type  ) " & _
        "values('" & studio_name & "', '" & studio_type & "', " & cost_for_new & ", " & cost & ", " & fee_new_vod & ", " & fee_back_catalogue & ", " & minimum_new_vod & ", " & minimum_back_catalogue & ", " & minimum_global & ", " & billing_reporting & ", " & billing_report_type & ")"

        Return sql
    End Function

    Public Shared Function getUpdateStudio(ByVal studio_id As Int16, ByVal studio_name As String, ByVal studio_type As String, ByVal cost_for_new As Int16, ByVal cost As Int16, _
                                            ByVal fee_new_vod As String, ByVal fee_back_catalogue As String, ByVal minimum_new_vod As String, _
                                            ByVal minimum_back_catalogue As String, ByVal minimum_global As String, ByVal billing_reporting As Boolean, ByVal billing_report_type As String) As String
        Dim sql As String
        Dim strStudioName = studio_name.Replace("'", "''")
        fee_new_vod = fee_new_vod.Replace(",", ".")
        fee_back_catalogue = fee_back_catalogue.Replace(",", ".")
        minimum_new_vod = minimum_new_vod.Replace(",", ".")
        minimum_back_catalogue = minimum_back_catalogue.Replace(",", ".")
        minimum_global = minimum_global.Replace(",", ".")

        sql = " update studio set studio_name = '" & strStudioName & _
                "', studio_type = '" & studio_type & _
                "', cost_for_new = " & cost_for_new & _
                ", cost = " & cost & _
                ", fee_new_vod = " & fee_new_vod & _
                ", fee_back_catalogue = " & fee_back_catalogue & _
                ", minimum_new_vod = " & minimum_new_vod & _
                ", minimum_back_catalogue = " & minimum_back_catalogue & _
                ", minimum_global = " & minimum_global & _
                ", billing_reporting = " & billing_reporting & _
                ", billing_report_type = 'STANDARD' where studio_id = " & studio_id

        Return sql
    End Function

    Public Shared Function GetCineartDetailedReportBackcatalogue(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer)
        Dim sql As String
        sql = " select " & _
 " x.vodstudio," & _
 " x.productstudio, " & _
 " x.products_title, " & _
 " x.imdb_id, " & _
 " x.products_type, " & _
 " x.customer_id, " & _
 " x.customers_abo_type, " & _
 " x.customers_lastname, " & _
 " x.customers_firstname, " & _
 " x.customers_language, " & _
 " x.created_at, " & _
 " x.products_date_available, " & _
 " x.available_from, " & _
 " x.expire_at, " & _
 " x.available_backcatalogue_from, " & _
 " x.expire_backcatalogue_at, " & _
 " x.catalogue_type , " & _
 " x.products_price, " & _
 " x.qty_credit, " & _
 " x.qty_at_home, " & _
 " x.credits, " & _
 " x.price_of_movie_tvac, " & _
 " x.price_of_movie_htva, " & _
 " case x.catalogue_type when 'N' then  if((x.price_of_movie_htva * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, (x.price_of_movie_htva * x.fee_new_vod))  when 'B' then  if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue))  end amount  " & _
 "       from " & _
 " ( " & _
 " select " & _
 " s.studio_name vodstudio, " & _
 " ps.studio_name as productstudio, " & _
 " p.products_title, " & _
 " customer_id, " & _
 "  (select fn_customers_abopackage(customers_id, t.created_at) )as customers_abo_type, " & _
 " c.customers_lastname, " & _
 " c.customers_firstname, " & _
 " ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language, " & _
 " t.imdb_id, " & _
 " p.products_type, " & _
 " t.created_at, " & _
 " p.products_date_available, " & _
 " sp.available_from, " & _
 " sp.expire_at, " & _
 " sp.available_backcatalogue_from, " & _
 " sp.expire_backcatalogue_at, " & _
 " if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
  " pabo.products_price, " & _
  " if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
   " pa.qty_at_home, " & _
   " if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
    " (pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1))) price_of_movie_tvac, " & _
     " (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
      " s.minimum_new_vod, " & _
       " s.fee_new_vod, " & _
       " s.minimum_back_catalogue, " & _
        " s.fee_back_catalogue " & _
       " from tokens t " & _
       " join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
       " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
                    " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id " & _
"                       from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' and month(available_backcatalogue_from) = month('" & DVDPostTools.ClsDate.formatDate(dateFrom) & "') and year(available_backcatalogue_from ) < year('" & DVDPostTools.ClsDate.formatDate(dateTo) & "') group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id " & _
  "      join customers c on t.customer_id = c.customers_id " & _
    "    join products pabo on pabo.products_id = c.customers_abo_type " & _
      "  join products_abo pa on pabo.products_id = pa.products_id " & _
       " left join studio s on s.studio_id = sp.studio_id " & _
       " left join studio ps on ps.studio_id = p.products_studio " & _
       " left join directors d on d.directors_id = p.products_directors_id " & _
        " where s.studio_id = " & studio_id & _
        " and t.created_at between date_add('" & DVDPostTools.ClsDate.formatDate(dateFrom) & "', interval -1 year) and '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' " & _
" group by s.studio_name, ps.studio_name, c.customers_id, t.created_at " & _
  "             order by s.studio_name, ps.studio_name,  p.products_title, t.created_at " & _
   " ) x " & _
 " where x.qty_credit <> 10000"

        Return sql
    End Function

    Public Shared Function GetCineartSummaryReportBackcatalogue(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer)
        Dim sql As String
        sql = "  select x.vodstudio, x.productstudio, x.products_title, count(x.imdb_id) number_titles, sum(x.price_of_movie_tvac)  tvac_sum, " & _
" sum(x.price_of_movie_htva) htvac_sum, " & _
" sum(case x.catalogue_type when 'N' then if((x.price_of_movie_htva * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, (x.price_of_movie_htva * x.fee_new_vod)) " & _
" when 'B' then " & _
 " if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue)) " & _
 " end ) amount_sum " & _
        " from " & _
 "( " & _
  " select " & _
  " s.studio_name vodstudio, " & _
"  ps.studio_name as productstudio, " & _
      " p.products_title, " & _
        " customer_id, " & _
      "   c.customers_abo_type, " & _
    "     c.customers_lastname, " & _
  "       c.customers_firstname, " & _
"   ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language,  " & _
        " t.imdb_id, " & _
      "   p.products_type, " & _
    "     t.created_at, " & _
  "       p.products_date_available, " & _
"         sp.available_from, " & _
       "  sp.expire_at, " & _
     "    sp.available_backcatalogue_from, " & _
   "      sp.expire_backcatalogue_at, " & _
 "  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type,  " & _
 "            pabo.products_price, " & _
 "  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit,  " & _
   "              pa.qty_at_home, " & _
"   if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits,  " & _
"  (pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1))) price_of_movie_tvac,  " & _
"  (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
                   "  s.minimum_new_vod, " & _
                   "  s.fee_new_vod, " & _
                   "  s.minimum_back_catalogue, " & _
                   "  s.fee_back_catalogue" & _
 "  from tokens t  " & _
"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id  " & _
 " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
 " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' and month(available_backcatalogue_from) = month('" & DVDPostTools.ClsDate.formatDate(dateFrom) & "') and year(available_backcatalogue_from ) < year('" & DVDPostTools.ClsDate.formatDate(dateFrom) & "')" & _
"  group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id " & _
 "  join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = c.customers_abo_type " & _
"   join products_abo pa on pabo.products_id = pa.products_id " & _
 "  left join studio s on s.studio_id = sp.studio_id  " & _
 "  left join studio ps on ps.studio_id = p.products_studio " & _
 "  left join directors d on d.directors_id = p.products_directors_id  " & _
"  where s.studio_id = " & studio_id & _
     " and t.created_at between date_add('" & DVDPostTools.ClsDate.formatDate(dateFrom) & "', interval -1 year) and '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' " & _
 " order by s.studio_name, ps.studio_name,  p.products_title " & _
 " ) x  where x.qty_credit <> 10000  " & _
" group by 1,2,3"
        Return sql
    End Function

    Public Shared Function GetCineartSummaryReportNew(ByVal dateFrom As String, ByVal dateTo As String, ByVal in_studio_id As Integer)
        Dim sql As String
        sql = "  select x.vodstudio, x.productstudio, x.products_title, count(x.imdb_id) number_titles, sum(x.price_of_movie_tvac)  tvac_sum, " & _
" sum(x.price_of_movie_htva) htvac_sum, " & _
" sum(case x.catalogue_type when 'N' then if((x.price_of_movie_htva * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, (x.price_of_movie_htva * x.fee_new_vod)) " & _
" when 'B' then " & _
 " if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue)) " & _
 " end ) amount_sum " & _
        " from " & _
 "( " & _
  " select " & _
  " s.studio_name vodstudio, " & _
"  ps.studio_name as productstudio, " & _
      " p.products_title, " & _
        " customer_id, " & _
      "   c.customers_abo_type, " & _
    "     c.customers_lastname, " & _
  "       c.customers_firstname, " & _
"   ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language,  " & _
        " t.imdb_id, " & _
      "   p.products_type, " & _
    "     t.created_at, " & _
  "       p.products_date_available, " & _
"         sp.available_from, " & _
       "  sp.expire_at, " & _
     "    sp.available_backcatalogue_from, " & _
   "      sp.expire_backcatalogue_at, " & _
 "  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type,  " & _
 "            pabo.products_price, " & _
 "  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit,  " & _
   "              pa.qty_at_home, " & _
"   if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits,  " & _
"  (pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1))) price_of_movie_tvac,  " & _
"  (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
                   "  s.minimum_new_vod, " & _
                   "  s.fee_new_vod, " & _
                   "  s.minimum_back_catalogue, " & _
                   "  s.fee_back_catalogue" & _
 "  from tokens t  " & _
"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id  " & _
 " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
 " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' " & _
"  group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and t.created_at between sp.available_from and sp.expire_at  " & _
 "  join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = c.customers_abo_type " & _
"   join products_abo pa on pabo.products_id = pa.products_id " & _
 "  left join studio s on s.studio_id = sp.studio_id  " & _
 "  left join studio ps on ps.studio_id = p.products_studio " & _
 "  left join directors d on d.directors_id = p.products_directors_id  " & _
"  where sp.expire_at between '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' " & _
     "      and s.studio_id = " & in_studio_id & _
 " order by s.studio_name, ps.studio_name,  p.products_title " & _
 " ) x  where x.qty_credit <> 10000  " & _
" group by 1,2,3"
        Return sql
    End Function

    Public Shared Function GetCineartDetailedReportNew(ByVal dateFrom As String, ByVal dateTo As String, ByVal in_studio_id As Integer) As String
        Dim sql As String

        sql = " select " & _
 " x.vodstudio, " & _
 "        x.productstudio, " & _
   "      x.products_title, " & _
     "    x.customer_id, " & _
       "  x.customers_abo_type, " & _
        " x.customers_lastname, " & _
        " x.customers_firstname, " & _
        " x.customers_language, " & _
        " x.imdb_id, " & _
        " x.products_type, " & _
        " x.created_at, " & _
        " x.products_date_available, " & _
        " x.available_from, " & _
        " x.expire_at, " & _
        " x.available_backcatalogue_from, " & _
        " x.expire_backcatalogue_at, " & _
        " x.catalogue_type, " & _
        " x.products_price, " & _
        " x.qty_credit, " & _
        " x.qty_at_home, " & _
        " x.credits, " & _
        " x.price_of_movie_tvac, " & _
        " x.price_of_movie_htva, " & _
 " case x.catalogue_type when 'N' then  if((x.price_of_movie_htva * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, (x.price_of_movie_htva * x.fee_new_vod))  when 'B' then  if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue))  end amount  " & _
        " from  " & _
" (  " & _
 " select " & _
   "      s.studio_name as vodstudio, " & _
 " ps.studio_name as productstudio, " & _
   "      p.products_title, " & _
     "    customer_id, " & _
 " (select fn_customers_abopackage(customers_id, t.created_at) )as customers_abo_type, " & _
   "      c.customers_lastname, " & _
     "    c.customers_firstname, " & _
 " ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language, " & _
   "      t.imdb_id, " & _
     "    p.products_type, " & _
       "  t.created_at, " & _
        " p.products_date_available, " & _
        " sp.available_from, " & _
        " sp.expire_at, " & _
        " sp.available_backcatalogue_from, " & _
   "     sp.expire_backcatalogue_at, " & _
 " if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
  " pabo.products_price, " & _
  " if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
    "         pa.qty_at_home, " & _
   " if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
    " (pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1))) price_of_movie_tvac, " & _
     " (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
       "  s.minimum_new_vod, " & _
        " s.fee_new_vod, " & _
        " s.minimum_back_catalogue, " & _
        " s.fee_back_catalogue " & _
"       from tokens t " & _
       " join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
       " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
         "            ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id " & _
                      " from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' and expire_at between '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and t.created_at between sp.available_from and sp.expire_at  " & _
       " join customers c on t.customer_id = c.customers_id " & _
       " join products pabo on pabo.products_id = c.customers_abo_type " & _
       " join products_abo pa on pabo.products_id = pa.products_id " & _
       " left join studio s on s.studio_id = sp.studio_id " & _
       " left join studio ps on ps.studio_id = p.products_studio " & _
       " left join directors d on d.directors_id = p.products_directors_id " & _
        "         where s.studio_id = " & in_studio_id & _
" group by s.studio_name, ps.studio_name, c.customers_id, t.created_at " & _
  "             order by s.studio_name, ps.studio_name,  p.products_title, t.created_at  " & _
  " ) x " & _
 " where x.qty_credit <> 10000"

        Return sql
    End Function

    Public Shared Function GetStudioDetailedReport(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer) As String

        Dim sql As String
        Dim allstudio As String = String.Empty

        If studio_id <> -1 Then
            allstudio = allstudio & " and s.studio_id = " & studio_id
        End If

        sql = " select  x.vodstudio, x.productstudio, x.products_title, x.customer_id, x.customers_abo_type, x.customers_lastname," & _
 " x.customers_firstname, x.customers_language, x.imdb_id, x.products_type, x.created_at, x.products_date_available, x.available_from, " & _
 " x.expire_at, x.available_backcatalogue_from, x.expire_backcatalogue_at, x.catalogue_type , x.products_price, x.qty_credit, " & _
 " x.qty_at_home, x.credits, x.price_of_movie_tvac, x.price_of_movie_htva, " & _
" case x.catalogue_type when 'N' then " & _
" if((x.price_of_movie_htva * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, (x.price_of_movie_htva * x.fee_new_vod)) " & _
" when 'B' then " & _
" if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue)) " & _
" end amount from " & _
" ( " & _
" select " & _
" s.studio_name vodstudio, " & _
" ps.studio_name as productstudio, " & _
" p.products_title, " & _
" customer_id,c.customers_abo_type, " & _
" c.customers_lastname, " & _
" c.customers_firstname, " & _
" ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language, " & _
" t.imdb_id, " & _
" p.products_type, " & _
" t.created_at, " & _
" p.products_date_available, " & _
" sp.available_from, " & _
" sp.expire_at," & _
" sp.available_backcatalogue_from, " & _
" sp.expire_backcatalogue_at, " & _
" if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
" pabo.products_price, " & _
" if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
" pa.qty_at_home, " & _
" if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
" (pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1))) price_of_movie_tvac, " & _
" (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
" from tokens t " & _
" join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
" join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
" ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.created_at between sp.available_from and expire_at ) or (t.created_at between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
" join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = c.customers_abo_type " & _
" join products_abo pa on pabo.products_id = pa.products_id " & _
" left join studio s on s.studio_id = sp.studio_id " & _
" left join studio ps on ps.studio_id = p.products_studio " & _
" left join directors d on d.directors_id = p.products_directors_id " & _
" where date(t.created_at) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "'" & _
allstudio & _
" order by s.studio_name, ps.studio_name,  p.products_title " & _
" ) x  where x.qty_credit <> 10000 "

        Return sql

    End Function

    Public Shared Function GetStudioSummaryReport(ByVal dateFrom As String, ByVal dateTo As String, ByVal studio_id As Integer) As String

        Dim sql As String

        Dim allstudio As String = String.Empty

        If studio_id <> -1 Then
            allstudio = allstudio & " and s.studio_id = " & studio_id
        End If

        sql = "  select x.vodstudio, x.productstudio, x.products_title, count(x.imdb_id) number_titles, sum(x.price_of_movie_tvac)  tvac_sum, " & _
        " sum(x.price_of_movie_htva) htvac_sum, " & _
        " sum(case x.catalogue_type when 'N' then " & _
" if((x.price_of_movie_htva * x.fee_new_vod) < x.minimum_new_vod, x.minimum_new_vod, (x.price_of_movie_htva * x.fee_new_vod))" & _
" when 'B' then " & _
" if((x.price_of_movie_htva * x.fee_back_catalogue) < x.minimum_back_catalogue, x.minimum_back_catalogue, (x.price_of_movie_htva * x.fee_back_catalogue)) " & _
" end ) amount_sum , date(sysdate()) date_created, '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' period_start , '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' period_end" & _
" from " & _
" ( " & _
"  select " & _
"  s.studio_name vodstudio, " & _
"  ps.studio_name as productstudio, " & _
"  p.products_title, " & _
"  customer_id,c.customers_abo_type, " & _
"  c.customers_lastname, " & _
"  c.customers_firstname, " & _
"  ( SELECT name FROM languages where languages_id = c.customers_language) as customers_language, " & _
"  t.imdb_id, " & _
"  p.products_type, " & _
"  t.created_at, " & _
"  p.products_date_available, " & _
"  sp.available_from, " & _
"  sp.expire_at, " & _
"  sp.available_backcatalogue_from, " & _
"  sp.expire_backcatalogue_at, " & _
"  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
"  pabo.products_price, " & _
"  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
"  pa.qty_at_home, " & _
"  if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
" (pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1))) price_of_movie_tvac, " & _
" (((pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11,fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
"  from tokens t  " & _
"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
 " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
 " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.created_at between sp.available_from and expire_at ) or (t.created_at between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
 " join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = c.customers_abo_type " & _
 " join products_abo pa on pabo.products_id = pa.products_id " & _
 " left join studio s on s.studio_id = sp.studio_id " & _
 " left join studio ps on ps.studio_id = p.products_studio " & _
 " left join directors d on d.directors_id = p.products_directors_id " & _
" where date(t.created_at) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "'" & _
allstudio & _
" order by s.studio_name, ps.studio_name,  p.products_title " & _
" ) x  where x.qty_credit <> 10000 " & _
" group by 1,2,3 "

        Return sql

    End Function

    Public Shared Function GetSABAMDetailedReport(ByVal productsType As String, ByVal dateFrom As String, ByVal dateTo As String) As String

        Dim sql As String

        sql = " select  x.vodstudio, x.productstudio, " & _
 " x.customer_id, x.customers_abo_type, " & _
 " (select d.directors_name from directors d where d.directors_id = x.products_directors_id) directors_name , x.imdb_id, x.products_title, x.products_type, x.created_at, x.products_date_available, x.available_from, " & _
 " x.expire_at, x.available_backcatalogue_from, x.expire_backcatalogue_at, x.catalogue_type , x.products_price, x.qty_credit, " & _
 " x.qty_at_home, x.price_of_movie_tvac 'Price per film', if( x.products_type = 'DVD_ADULT', '1.00%', '1.38%') 'SABAM%', " & _
 "x.price_of_movie_htva * if( x.products_type = 'DVD_ADULT', 0.01, 0.01375) 'Sabam Fee' " & _
" from " & _
" ( " & _
" select " & _
" s.studio_name vodstudio, " & _
" ps.studio_name as productstudio, " & _
" p.products_title, " & _
" customer_id,c.customers_abo_type, " & _
"  p.products_directors_id, " & _
" t.imdb_id, " & _
" p.products_type, " & _
" t.created_at, " & _
" p.products_date_available, " & _
" sp.available_from, " & _
" sp.expire_at," & _
" sp.available_backcatalogue_from, " & _
" sp.expire_backcatalogue_at, " & _
" if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
" pabo.products_price, " & _
" if(fn_customers_credit(customers_id, t.created_at) = 0,11, fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
" pa.qty_at_home, " & _
" if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
" (pabo.products_price /  if(fn_customers_credit(customers_id, t.created_at)=0,11, fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1))) price_of_movie_tvac, " & _
" (((pabo.products_price /  if( fn_customers_credit(customers_id, t.created_at)=0,11, fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
" from tokens t " & _
" join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products where products_type = '" & productsType & "' group by imdb_id) p on t.imdb_id = p.imdb_id " & _
" join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
" ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.created_at between sp.available_from and expire_at ) or (t.created_at between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
" join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = c.customers_abo_type " & _
" join products_abo pa on pabo.products_id = pa.products_id " & _
" left join studio s on s.studio_id = sp.studio_id " & _
" left join studio ps on ps.studio_id = p.products_studio " & _
" left join directors d on d.directors_id = p.products_directors_id " & _
" where date(t.created_at) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "'" & _
" order by s.studio_name, ps.studio_name,  p.products_title " & _
" ) x where x.qty_credit <> 10000 "

        Return sql

    End Function

    Public Shared Function GetSABAMSummaryReport(ByVal productsType As String, ByVal dateFrom As String, ByVal dateTo As String) As String

        Dim sql As String

        sql = "select x.products_title, (select d.directors_name from directors d where d.directors_id = x.products_directors_id) directors_name , " & _
        " count(x.imdb_id) 'Nombre de products_title', " & _
        " sum(x.price_of_movie_htva) 'Somme de Price per film', " & _
        " sum(x.price_of_movie_htva) * if( x.products_type = 'DVD_ADULT', 0.01, 0.01375) 'Somme de Sabam Fee' " & _
" from " & _
" ( " & _
"  select " & _
"  p.products_title, " & _
"  customer_id,c.customers_abo_type, " & _
"  t.imdb_id, " & _
"  p.products_type, " & _
"  p.products_directors_id, " & _
"  t.created_at, " & _
"  p.products_date_available, " & _
"  sp.available_from, " & _
"  sp.expire_at, " & _
"  sp.available_backcatalogue_from, " & _
"  sp.expire_backcatalogue_at, " & _
"  if(created_at between available_from and expire_at,'N',if(created_at between available_backcatalogue_from and expire_backcatalogue_at,'B','B')) as catalogue_type, " & _
"  pabo.products_price, " & _
"  if(fn_customers_credit(customers_id, t.created_at)=0,11, fn_customers_credit(customers_id, t.created_at)) qty_credit, " & _
"  pa.qty_at_home, " & _
"  if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)) credits, " & _
" (pabo.products_price /  if( fn_customers_credit(customers_id, t.created_at)=0,11, fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1))) price_of_movie_tvac, " & _
" (((pabo.products_price /  if( fn_customers_credit(customers_id, t.created_at)=0,11, fn_customers_credit(customers_id, t.created_at))) * (if(created_at between available_from and expire_at,s.cost_for_new,if(created_at between available_backcatalogue_from and expire_backcatalogue_at,s.cost,1)))) / 1.21) price_of_movie_htva, " & _
" s.minimum_new_vod, " & _
" s.fee_new_vod, " & _
" s.minimum_back_catalogue, " & _
" s.fee_back_catalogue " & _
"  from tokens t  " & _
"  join (select imdb_id,products_directors_id,products_date_available,products_title, products_studio, products_type from products where products_type = '" & productsType & "' group by imdb_id) p on t.imdb_id = p.imdb_id " & _
 " join (select s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at,s.credits, " & _
 " ( select studio_id from streaming_products sp1 where sp1.studio_id is not null and sp1.studio_id > 0 and sp1.imdb_id = s.imdb_id order by updated_at desc limit 1 ) as studio_id from streaming_products s where s.source = 'alphanetworks' and s.status = 'online_test_ok' group by s.imdb_id, s.available_from, s.expire_at, s.available_backcatalogue_from, s.expire_backcatalogue_at) sp on p.imdb_id = sp.imdb_id  and ( ( t.created_at between sp.available_from and expire_at ) or (t.created_at between sp.available_backcatalogue_from and expire_backcatalogue_at))" & _
 " join customers c on t.customer_id = c.customers_id  join products pabo on pabo.products_id = c.customers_abo_type " & _
 " join products_abo pa on pabo.products_id = pa.products_id " & _
 " left join studio s on s.studio_id = sp.studio_id " & _
 " left join studio ps on ps.studio_id = p.products_studio " & _
 " left join directors d on d.directors_id = p.products_directors_id " & _
" where date(t.created_at) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and date(t.created_at) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "'" & _
" order by s.studio_name, ps.studio_name,  p.products_title " & _
" ) x  where x.qty_credit <> 10000  " & _
" group by 1,2 "

        Return sql

    End Function
End Class
