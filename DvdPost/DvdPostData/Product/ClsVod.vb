Public Class ClsVod

    Public Enum ListField
        ID = 0
        IMDB_ID
        FILENAME
        AVAILABLE_FROM
        EXPIRE_AT
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
    End Enum
    Public Shared Function getViewVod(ByVal customers_id As Integer) As String

        Dim sql As String
        sql = "select t.customer_id,products_title,p.imdb_id,t.created_at,t.updated_at,ti.cpt used_ip, count_ip,count(svh.id) nb_viewed" & _
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
        sql = "select undertitles_id id,short_alpha code FROM products_undertitles where language_id = 1"
        Return sql
    End Function

    Public Shared Function GetAllLanguage() As String
        Dim sql As String
        sql = "select languages_id id,short_alpha code FROM products_languages where languagenav_id = 1"
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
                                        ByVal credit As Integer) As String
        Dim sql As String
        Dim strLanguageSubtitle As String
        Dim strlanguage As String
        Dim strQuality As String
        Dim strStatus As String

        If status = "" Then
            strStatus = "null"
        Else
            strStatus = status
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


        sql = "update streaming_products sp " & _
              " set filename = '" & filename & "'" & _
              ", available_from = '" & DVDPostTools.ClsDate.formatDateDB(available_from) & "'" & _
              ", expire_at = '" & DVDPostTools.ClsDate.formatDateDB(expire_at) & "'" & _
              ", available = " & available & _
              ", language_id = " & strlanguage & _
              ", subtitle_id = " & strLanguageSubtitle & _
              ", updated_at = now()" & _
              ", studio_id = " & studio_id & _
              ", status = '" & status & "'" & _
              ", quality = " & strQuality & _
              ", source = '" & source & "'" & _
              ", imdb_id = " & imdb_id & _
              ", credits = " & credit & _
              ", vod_support_id = " & support & _
              " where id = " & streaming_products_id

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
                                        ByVal credit As Integer) As String
        Dim sql As String
        Dim strLanguageSubtitle As String
        Dim strQuality As String
        Dim strlanguage As String
        Dim strStudio As String

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

        sql = "insert into streaming_products values (null," & imdb_id & ",'" & filename & "','" & DVDPostTools.ClsDate.formatDateDB(available_from) & _
              "','" & DVDPostTools.ClsDate.formatDateDB(expire_at) & "'," & available & "," & strlanguage & "," & strLanguageSubtitle & ",now(),now()," & strStudio & ",'" & status & "'," & strQuality & ",'" & source & "'," & support & "," & credit & ")"
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
