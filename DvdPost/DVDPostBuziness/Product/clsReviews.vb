Public Class clsReviews
    Public Shared Function GetReviewNoManaged() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectReviewsNoManaged()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

#Region "Customer"

    Public Shared Function GetCritiqueCustomers(ByVal customers_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectCritiqueCustomers(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetReviewCustomer(ByVal customers_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectReviewsCustomers(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetAverageCritiqueCustomers(ByVal customers_id) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectAverageCritiqueCustomers(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetRating(ByVal customers_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectRating(customers_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestNumberCritique(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectBestNumberCritique(isweek)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function getBestqualityDvdpostCritique(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectBestqualityDvdpostCritique(isweek)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestCritiqueCustomers(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectBestCritiqueCustomers(isweek)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestRating(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectBestRating(isweek)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function


#End Region
    Public Shared Function getValueReview() As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.getSelectValueRating()
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt

    End Function

#Region "Product"
 
    Public Shared Function GetReviewProduct(ByVal products_id As Integer) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectReviewsProducts(products_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetAverageCritiqueProducts(ByVal products_id) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectAverageCritiqueProducts(products_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetAverageRatingProducts(ByVal products_id As String) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectAverageRatingProducts(products_id)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestRatingProducts(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectBestRatingProducts(isweek)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

    Public Shared Function GetBestProductPolemique(Optional ByVal isweek As Boolean = False) As DataTable
        Dim sql As String
        Dim dt As DataTable

        sql = DvdPostData.clsReviews.GetSelectBestProductPolemique(isweek)
        dt = DvdPostData.clsConnection.FillDataSet(sql)
        Return dt
    End Function

#End Region

   


End Class
