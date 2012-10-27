Public Class ClsVod

    Public Enum ListField
        ID = 0
        IMDB_ID
        FILENAME
        AVAILABLE_FROM
        EXPIRE_AT
        AVAILABLE_BACKCATALOGUE_FROM
        EXPIRE_BACKKATALOGUE_AT
        AVAILABLE
        LANGUAGE
        SUBTITLE
        CREATED_AT
        UPDATED_AT
        STUDIO
        STATUS
        SOURCE
        VOD_SUPPORT
        CREDIT
        IS_PPV
        PPV_PRICE
    End Enum
    Public Shared Function getViewVod(ByVal customers_id As Integer) As String

        Dim sql As String
        sql = "select t.id, t.customer_id,products_title,p.imdb_id,t.created_at,t.updated_at,ti.cpt used_ip, count_ip,count(svh.id) nb_viewed,  If(t.compensed = 1, 'True', 'False')  as compensed " & _
              " from tokens t " & _
              " join (select imdb_id,products_title from products group by imdb_id) p on t.imdb_id = p.imdb_id " & _
              " left join streaming_viewing_histories svh on svh.token_id = t.id" & _
              " left join (SELECT token_id,count(*) cpt FROM token_ips t group by token_id) ti on ti.token_id = t.id " & _
              " where customer_id = " & customers_id & _
              " group by t.id " & _
              " order by customer_id,p.imdb_id "

        Return sql
    End Function

    Public Shared Function getSelectVodNoMovieInfo() As String

        Dim sql As String

        sql = " SELECT s.imdb_id, s.filename FROM streaming_products s where source = 'ALPHANETWORKS' and status <> 'deleted' and (select count(*) from products p where p.imdb_id = s.imdb_id ) = 0 "

        Return sql

    End Function

    Public Shared Function GetSelectVodWishlist(ByVal product_id As Integer)
        Dim sql As String
        sql = " SELECT vw.customer_id, vw.created_at FROM products p join vod_wishlists vw on p.imdb_id = vw.imdb_id " & _
                " join streaming_products sp on sp.imdb_id = p.imdb_id " & _
                " left join tokens t ON t.imdb_id = vw.imdb_id and t.updated_at < date_add(sysdate(), interval -2 DAY) " & _
                " and t.customer_id = vw.customer_id " & _
                " where p.products_id = " & product_id & _
                " and sp.status = 'online_test_ok' and p.products_status != -1 " & _
                " group by 1,2 " & _
                " order by vw.created_at "
        Return sql

    End Function

    Public Shared Function getSelectMovieData(ByVal imdb_id As Long)
        Dim sql As String

        sql = " select * from products where imdb_id = " & imdb_id 

        Return sql

    End Function
    Public Shared Function getSelectVod(ByVal imdb_id As Long, ByVal lang As Integer, ByVal subtitle As Integer, ByVal source As String, ByVal support As Integer) As String
        Dim sql As String
        Dim strLanguageSubtitle As String
        If subtitle = 0 Then
            strLanguageSubtitle = "subtitle_id is null"
        Else
            strLanguageSubtitle = "subtitle_id = " & subtitle
        End If

        sql = " select * from streaming_products where imdb_id = " & imdb_id & _
              " and language_id = " & lang & " and " & strLanguageSubtitle & _
              " and vod_support_id = " & support & _
              " and source = '" & source & "'" & " and status <> 'deleted' "

        Return sql
    End Function
    Public Shared Function getSelectVod(ByVal imdb_id As Long, ByVal lang As Integer, ByVal subtitle As Integer) As String
        Dim sql As String
        Dim strLanguageSubtitle As String
        If subtitle = 0 Then
            strLanguageSubtitle = "subtitle_id is null"
        Else
            strLanguageSubtitle = "subtitle_id = " & subtitle
        End If

        sql = " select * from streaming_products where imdb_id = " & imdb_id & _
              " and language_id = " & lang & " and " & strLanguageSubtitle & " and  status <> 'deleted' "

        Return sql
    End Function
    Public Shared Function SearchAllViewVod() As String
        Dim sql As String
        sql = " SELECT distinct sp.*, P.products_title products_name " & _
              " from (select imdb_id,products_title from products group by imdb_id) P " & _
              " join streaming_products sp on sp.imdb_id = P.imdb_id " & _
              " where sp.status <> 'deleted' "
        Return sql
    End Function

    Public Shared Function SearchViewVodpartTitle(ByVal partTitle As String) As String
        Dim sql As String
        sql = " SELECT distinct sp.*, P.products_title products_name " & _
              " from (select imdb_id,products_title from products group by imdb_id) P " & _
              " join streaming_products sp on sp.imdb_id = P.imdb_id " & _
              " where sp.status <> 'deleted' and products_title like '%" & partTitle.Trim & "%'  "
        Return sql
    End Function

    Private Shared Function SearchViewVodProductStatus(ByVal status As String) As String
        Dim sql As String
        sql = " SELECT distinct sp.*, P.products_title products_name " & _
              " from (select imdb_id,products_title from products group by imdb_id) P " & _
              " join streaming_products sp on sp.imdb_id = P.imdb_id " & _
              " where sp.status = '" & status & "'"
        Return sql
    End Function

    Public Shared Function SearchViewVodProductUploaded() As String
        Return SearchViewVodProductStatus("uploaded")
    End Function

    Public Shared Function SearchViewVodProductRipped() As String
        Return SearchViewVodProductStatus("ripped")
    End Function

    Public Shared Function SearchViewVodProduct(ByVal products_id As Integer) As String
        Dim sql As String
        sql = " SELECT distinct sp.*, P.products_title products_name " & _
              " from (select imdb_id,products_title,products_id from products group by imdb_id) P " & _
              " join streaming_products sp on sp.imdb_id = P.imdb_id " & _
              " where sp.status <> 'deleted' and P.products_id = " & products_id
        Return sql
    End Function

    Public Shared Function SearchViewVodImdb(ByVal imdb_id As Integer) As String
        Dim sql As String
        sql = " SELECT distinct sp.*, P.products_title products_name " & _
              " from (select imdb_id,products_title from products group by imdb_id) P " & _
              " join streaming_products sp on sp.imdb_id = P.imdb_id " & _
              " where status <> 'deleted' and P.imdb_id = " & imdb_id
        Return sql
    End Function

    Public Shared Function SearchViewVodId(ByVal streaming_products_id As Integer) As String
        Dim sql As String
        sql = "SELECT distinct sp.*, PD.language_id, PD.products_name" & _
              " FROM products_description PD " & _
              " join products P on P.products_id = PD.products_id and PD.language_id = 1" & _
              " join streaming_products sp on sp.imdb_id = P.imdb_id " & _
              " where sp.id = " & streaming_products_id
        Return sql
    End Function
    Public Shared Function GetEnumMysqlSource() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM streaming_products LIKE 'source' "
        Return sql
    End Function
    Public Shared Function GetSupportVod() As String
        Dim sql As String
        sql = "select id,name code from vod_support"
        Return sql
    End Function
    Public Shared Function GetStudio() As String
        Dim sql As String
        sql = "select studio_id,studio_name from studio"
        Return sql
    End Function



    Public Shared Function GetLanguage() As String
        Dim sql As String
        sql = "select languages_id id,code FROM languages"
        Return sql
    End Function

    Public Shared Function GetAllSubtitle() As String
        Dim sql As String
        sql = "select undertitles_id subtitle_id,short_alpha code, undertitles_description lngdsc FROM products_undertitles where language_id = 1"
        Return sql
    End Function

    Public Shared Function GetAllLanguage() As String
        Dim sql As String
        sql = "select languages_id id,short_alpha code, languages_description lngdsc FROM products_languages where languagenav_id = 1"
        Return sql
    End Function


    Public Shared Function GetUpdateVod(ByVal streaming_products_id As Integer, _
                                        ByVal imdb_id As Integer, _
                                        ByVal filename As String, _
                                        ByVal available_from As DateTime, _
                                        ByVal expire_at As DateTime, _
                                        ByVal available As Boolean, _
                                        ByVal language_id As Integer, _
                                        ByVal language_subtitle_id As Integer, _
                                        ByVal studio_id As Integer, _
                                        ByVal status As String, _
                                        ByVal quality As String, _
                                        ByVal source As String, _
                                        ByVal support As Integer, _
                                        ByVal credit As Integer, _
                                        ByVal available_backcatalogue_from As Date, _
                                        ByVal expire_backcatalogue_at As Date, _
                                        ByVal is_ppv As String, _
                                        ByVal ppv_price As String) As String
        Dim sql As String
        Dim strLanguageSubtitle As String
        Dim strlanguage As String
        Dim strQuality As String
        Dim strStatus As String
        Dim strStudio As String
        Dim strimbd_id As String
        Dim strSupport As String
        Dim stravailable_from As String
        Dim strexpire_at As String
        Dim strfilename As String
        Dim strBackcatalogue_from As String
        Dim strBackcatalogue_expire As String
        Dim str_is_ppv As String
        Dim str_ppv_price As String
        Dim IsSamePPVPriceForAllAudioSubtitle As Boolean = True

        If filename = "" Then
            strfilename = "null"
        Else
            strfilename = "'" & filename & "'"
        End If
        If available_from = DateTime.MinValue Then
            stravailable_from = "null"
        Else
            stravailable_from = "'" & DVDPostTools.ClsDate.formatDateDB(available_from) & "'"
        End If

        If expire_at = DateTime.MinValue Then
            strexpire_at = "null"
        Else
            strexpire_at = "'" & DVDPostTools.ClsDate.formatDateDB(expire_at) & "'"
        End If

        If support = 0 Then
            strSupport = "null"
        Else
            strSupport = support
        End If

        If imdb_id = 0 Then
            strimbd_id = "null"
        Else
            strimbd_id = imdb_id
        End If

        If studio_id = 0 Then
            strStudio = "null"
        Else
            strStudio = studio_id
        End If

        If status = "" Then
            strStatus = "null"
        Else
            strStatus = "'" & status & "'"
        End If
        If language_id = 0 Then
            strlanguage = "null"
        Else
            strlanguage = language_id
        End If

        If language_subtitle_id = 0 Then
            strLanguageSubtitle = "null"
        Else
            strLanguageSubtitle = language_subtitle_id
        End If

        If quality = "" Then
            strQuality = "null"
        Else
            strQuality = "'" & quality & "'"
        End If

        If available_backcatalogue_from = Date.MinValue Then
            strBackcatalogue_from = "null"
        Else
            strBackcatalogue_from = "'" & DVDPostTools.ClsDate.formatDateDB(available_backcatalogue_from) & "'"
        End If

        If expire_backcatalogue_at = Date.MinValue Then
            strBackcatalogue_expire = "null"
        Else
            strBackcatalogue_expire = "'" & DVDPostTools.ClsDate.formatDateDB(expire_backcatalogue_at) & "'"
        End If

        If is_ppv = "" Then
            str_is_ppv = "null"
        Else
            str_is_ppv = "'" & IIf(is_ppv, 1, 0) & "'"
        End If

        If ppv_price = "" Then
            str_ppv_price = "null"
        Else
            str_ppv_price = ppv_price.Replace(",", ".")
        End If

        If IsSamePPVPriceForAllAudioSubtitle Then

            sql = "update streaming_products sp " & _
                  " set filename = " & strfilename & "" & _
                  ", available_from = " & stravailable_from & "" & _
                  ", expire_at = " & strexpire_at & "" & _
                  ", available = " & available & _
                  ", available_backcatalogue_from = " & strBackcatalogue_from & _
                  ", expire_backcatalogue_at = " & strBackcatalogue_expire & _
                  ", language_id = " & strlanguage & _
                  ", subtitle_id = " & strLanguageSubtitle & _
                  ", updated_at = now()" & _
                  ", studio_id = " & strStudio & _
                  ", status = " & strStatus & "" & _
                  ", quality = " & strQuality & _
                  ", source = '" & source & "'" & _
                  ", imdb_id = " & strimbd_id & _
                  ", credits = " & credit & _
                  ", vod_support_id = " & strSupport & _
                  ", is_ppv = " & str_is_ppv & _
                  ", ppv_price = " & str_ppv_price & _
                  " where id = " & streaming_products_id

            sql = sql & " ; update streaming_products sp " & _
                  " set is_ppv = " & str_is_ppv & _
                  ", ppv_price = " & str_ppv_price & _
                  " where imdb_id = " & imdb_id & ";"
        Else
            sql = "update streaming_products sp " & _
                  " set filename = " & strfilename & "" & _
                  ", available_from = " & stravailable_from & "" & _
                  ", expire_at = " & strexpire_at & "" & _
                  ", available = " & available & _
                  ", available_backcatalogue_from = " & strBackcatalogue_from & _
                  ", expire_backcatalogue_at = " & strBackcatalogue_expire & _
                  ", language_id = " & strlanguage & _
                  ", subtitle_id = " & strLanguageSubtitle & _
                  ", updated_at = now()" & _
                  ", studio_id = " & strStudio & _
                  ", status = " & strStatus & "" & _
                  ", quality = " & strQuality & _
                  ", source = '" & source & "'" & _
                  ", imdb_id = " & strimbd_id & _
                  ", credits = " & credit & _
                  ", vod_support_id = " & strSupport & _
                  ", is_ppv = " & str_is_ppv & _
                  ", ppv_price = " & str_ppv_price & _
                  " where id = " & streaming_products_id

        End If
        Return sql
    End Function

    Public Shared Function GetDeleteVod(ByVal streaming_products_id As Integer) As String
        Dim sql As String

        sql = " update streaming_products sp " & _
              " set status = 'deleted' " & _
              " where id = " & streaming_products_id

        Return sql
    End Function

    Public Shared Function GetSelectCheckVod(ByVal imdb_id As Integer, _
                                            ByVal language_id As Integer, _
                                            ByVal language_subtitle_id As Integer, _
                                            ByVal support_id As Integer, _
                                            ByVal source As String) As String
        Dim sql As String

        sql = " select * from streaming_products " & _
                " where imdb_id = " & imdb_id & _
                " and language_id = " & language_id & _
                " and subtitle_id = " & language_subtitle_id & _
                " and support_id = " & support_id & _
                " and source = '" & source & "'"

        Return sql
    End Function
    Public Shared Function GetInsertVod(ByVal imdb_id As Integer, _
                                        ByVal filename As String, _
                                        ByVal available_from As DateTime, _
                                        ByVal expire_at As DateTime, _
                                        ByVal available As Boolean, _
                                        ByVal language_id As Integer, _
                                        ByVal language_subtitle_id As String, _
                                        ByVal studio_id As String, _
                                        ByVal status As String, _
                                        ByVal quality As String, _
                                        ByVal source As String, _
                                        ByVal support As Integer, _
                                        ByVal credit As Integer, _
                                        ByVal available_backcatalogue_from As Date, _
                                        ByVal expire_backcatalogue_at As Date, _
                                        ByVal is_ppv As String, _
                                        ByVal ppv_price As String) As String
        Dim sql As String
        Dim strLanguageSubtitle As String
        Dim strQuality As String
        Dim strlanguage As String
        Dim strStudio As String
        Dim strExpireAt As String
        Dim strAvailable_from As String
        Dim strBackcatalogue_from As String
        Dim strBackcatalogue_expire As String
        Dim str_is_ppv As String
        Dim str_ppv_price As String
        Dim IsSamePPVPriceForAllAudioSubtitle As Boolean = True

        If language_id <= 0 Then
            strlanguage = "null"
        Else
            strlanguage = language_id
        End If

        If language_subtitle_id Is Nothing OrElse language_subtitle_id <= 0 Then
            strLanguageSubtitle = "null"
        Else
            strLanguageSubtitle = language_subtitle_id
        End If

        If quality = "" Then
            strQuality = "null"
        Else
            strQuality = "'" & quality & "'"
        End If

        If studio_id = "" Then
            strStudio = "null"
        Else
            strStudio = "'" & studio_id & "'"
        End If

        If available_from = DateTime.MinValue Then
            strAvailable_from = "null"
        Else
            strAvailable_from = "'" & DVDPostTools.ClsDate.formatDateDB(available_from) & "'"
        End If

        If expire_at = DateTime.MinValue Then
            strExpireAt = "null"
        Else
            strExpireAt = "'" & DVDPostTools.ClsDate.formatDateDB(expire_at) & "'"
        End If

        If available_backcatalogue_from = Date.MinValue Then
            strBackcatalogue_from = "null"
        Else
            strBackcatalogue_from = "'" & DVDPostTools.ClsDate.formatDateDB(available_backcatalogue_from) & "'"
        End If

        If expire_backcatalogue_at = Date.MinValue Then
            strBackcatalogue_expire = "null"
        Else
            strBackcatalogue_expire = "'" & DVDPostTools.ClsDate.formatDateDB(expire_backcatalogue_at) & "'"
        End If

        If is_ppv = "" Then
            str_is_ppv = "0"
        Else
            str_is_ppv = "'" & IIf(is_ppv, 1, 0) & "'"
        End If

        If ppv_price = "" Then
            str_ppv_price = "null"
        Else
            str_ppv_price = ppv_price.Replace(",", ".")
        End If

        If (IsSamePPVPriceForAllAudioSubtitle) Then
            sql = "insert into streaming_products values (null," & imdb_id & ",'" & filename & "'," & strAvailable_from & _
                              "," & strExpireAt & ", " & strBackcatalogue_from & ", " & strBackcatalogue_expire & "," & available & "," & strlanguage & "," & strLanguageSubtitle & ",now(),now()," & strStudio & ",'" & status & "'," & strQuality & ",'" & source & "'," & support & "," & credit & "," & str_is_ppv & "," & str_ppv_price & ") ; " & _
                              " update streaming_products set  is_ppv = " & str_is_ppv & ", ppv_price = " & str_ppv_price & " where imdb_id = " & imdb_id & ";"
        Else

            sql = "insert into streaming_products values (null," & imdb_id & ",'" & filename & "'," & strAvailable_from & _
                  "," & strExpireAt & ", " & strBackcatalogue_from & ", " & strBackcatalogue_expire & "," & available & "," & strlanguage & "," & strLanguageSubtitle & ",now(),now()," & strStudio & ",'" & status & "'," & strQuality & ",'" & source & "'," & support & "," & credit & "," & str_is_ppv & "," & str_ppv_price & ")"
        End If
        Return sql
    End Function

    Public Shared Function InsertStatVod() As String
        Dim sql As String
        sql = " insert stat_vod " & _
"               select null,date(now()) created_at," & _
"               sum(if (status = 'uploaded',xx.cpt,null)) uploaded," & _
"               sum(if (status = 'online_test_ok' and xx.available = 1,xx.cpt,null)) ok_actif," & _
"               sum(if (status = 'online_test_ok' and xx.available = 0,xx.cpt,null)) ok_inactif," & _
"               sum(if (status = 'filename_incorrect',xx.cpt,null)) filename_incorrect," & _
"               sum(if (status = 'imdb_not_found',xx.cpt,null)) imdb_not_found," & _
"               sum(xx.cpt) total" & _
"               from (select status,available,count(*) cpt from streaming_products group by status,available) xx"
        Return sql
    End Function

    Public Shared Function UpdateVodCreditsAfterStartingPeriod() As String
        Dim sql As String
        sql = " update streaming_products sp join studio s on sp.studio_id = s.studio_id " & _
              " set sp.credits = s.cost, sp.updated_at = sysdate() " & _
              " where available_from < DATE_ADD(sysdate(), INTERVAL - 3 MONTH) " & _
              " and s.cost_for_new <> s.cost and sp.credits <> s.cost "

        Return sql
    End Function
    Public Shared Function UpdateSoonVod() As String
        Dim sql As String
        sql = " update products p join streaming_products sp on p.imdb_id = sp.imdb_id " & _
              " set p.vod_next = 0" & _
              " where p.vod_next = 1 and sp.status = 'online_test_ok' and sp.available = 1 and " & _
              " ( (sp.available_from < sysdate() and ( sysdate() < sp.expire_at or sp.expire_at is null ) ) or (sp.available_backcatalogue_from < sysdate() and sysdate() < sp.expire_backcatalogue_at) )"
        Return sql
    End Function

    Public Shared Function GetEnumMysqlQuality() As String
        Dim sql As String
        sql = "SHOW COLUMNS FROM streaming_products LIKE 'quality' "
        Return sql
    End Function

    Public Shared Function GetEnumMysqlStatus() As String
        Dim sql As String

        sql = "SHOW COLUMNS FROM streaming_products LIKE 'status' "
        Return sql
    End Function
End Class
