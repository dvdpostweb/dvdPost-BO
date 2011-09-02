Public Class clsProducts
    Public Shared Function GetSelectList() As String
        Dim sql As String

        sql = "select products_id id, products_name name from products_description where language_id = 1 order by products_name"

        Return sql
    End Function
End Class
