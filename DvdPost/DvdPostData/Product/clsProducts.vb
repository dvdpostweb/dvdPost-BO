Public Class clsProducts
    Public Shared Function GetSelectList() As String
        Dim sql As String

        sql = "select products_id id, products_name name from products_description where language_id = 1 order by products_name"

        Return sql
    End Function

    Public Shared Function GetProduct_id(ByVal imdb_id As Integer) As String
        Dim sql As String

        sql = "select products_id from products where products_status !=-1 and imdb_id = " & imdb_id & " limit 1"

        Return sql
    End Function

    Public Shared Function UpdateInCinema() As String
        Dim sql As String
        sql = " update products p set p.in_cinema_now = 0 where p.products_date_added < date_add(now(), interval -2 month) "
        Return sql
    End Function

End Class
