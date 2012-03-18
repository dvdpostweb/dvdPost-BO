Public Class clsIPhoneIPad

    Public Shared Function GetSelectCustomersUseApplication(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " SELECT c.customers_id, c.customers_firstname, c.customers_lastname, case when l.device = 0 then 'iPhone' else 'iPad' end device, date(created_system) as usage_date " & _
                " FROM dvdpost_mobile_api_ws.mobile_log l join dvdpost_be_prod.customers c on l.customers_id = c.customers_id " & _
                " where date(created_system) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and  date(created_system) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' " & _
                " group by l.customers_id, usage_date " & _
                " order by c.customers_id, usage_date desc "

        Return sql
    End Function

    Public Shared Function GetSelectVODWatched(ByVal dateFrom As String, ByVal dateTo As String) As String
        Dim sql As String
        sql = " SELECT c.customers_id, c.customers_firstname, c.customers_lastname, case when l.device = 0 then 'iPhone' else 'iPad' end device, date(created_system) as usage_date , parameters Imdb_idDisk_idSeason_id, count(distinct parameters) watched_vod " & _
                " FROM dvdpost_mobile_api_ws.mobile_log l join dvdpost_be_prod.customers c on l.customers_id = c.customers_id " & _
                " WHERE date(created_system) >= '" & DVDPostTools.ClsDate.formatDate(dateFrom) & "' and  date(created_system) <= '" & DVDPostTools.ClsDate.formatDate(dateTo) & "' " & _
                " AND method like 'getVodTokenAndLngs 2%' group by l.customers_id, usage_date, device, parameters  order by c.customers_id, usage_date desc"

        Return sql
    End Function
End Class
