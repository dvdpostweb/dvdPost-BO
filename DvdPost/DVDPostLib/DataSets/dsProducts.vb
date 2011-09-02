Partial Class dsProducts
    
    Partial Class ReviewsDataTable

        Private Sub ReviewsDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Reviews_idColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
