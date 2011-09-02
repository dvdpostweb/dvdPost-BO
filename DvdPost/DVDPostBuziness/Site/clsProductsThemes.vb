Public Class clsProductsThemes

    Public Shared Sub SwitchOrder(ByRef RowCurrent As DataRow, ByRef RowCompare As DataRow)

        Dim IdCurrent As Integer = RowCurrent("id")
        Dim IdCompare As Integer = RowCompare("id")

        Dim OrderCurrent As Integer = RowCurrent("order")
        Dim OrderCompare As Integer = RowCompare("order")

        updateOrder(RowCurrent, OrderCompare)
        updateOrder(RowCompare, OrderCurrent)

    End Sub

    Private Shared Sub updateOrder(ByRef Row As DataRow, ByVal order As Integer)

        Dim sql As String
        Dim Id As Integer = Row("id")

        sql = DvdPostData.clsProductsThemes.getUpdateOrderProduct(Id, order)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)
        Row("order") = order

    End Sub

    Public Shared Sub InsertProduct(ByVal product_list_id As Integer, ByVal product_id As Integer, ByVal order As Integer)
        Dim sql As String
        sql = DvdPostData.clsProductsThemes.getInsertProduct(product_list_id, product_id, order)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

    End Sub

    Public Shared Sub DeleteProduct(ByVal id As Integer)
        Dim sql As String
        sql = DvdPostData.clsProductsThemes.getDeleteProduct(id)
        DvdPostData.clsConnection.ExecuteNonQuery(sql)

    End Sub
End Class
