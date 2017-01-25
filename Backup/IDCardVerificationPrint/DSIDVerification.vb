Partial Class DSIDVerification
    Partial Class ResultKJBDataTable

    End Class

    Partial Class SelectAllProvinceDataTable

        Private Sub SelectAllProvinceDataTable_SelectAllProvinceRowChanging(ByVal sender As System.Object, ByVal e As SelectAllProvinceRowChangeEvent) Handles Me.SelectAllProvinceRowChanging

        End Sub

        Private Sub SelectAllProvinceDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.CountSexColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class StatisticPeopleDataTable



    End Class

End Class

Namespace DSIDVerificationTableAdapters
    
    Partial Public Class TBL_PROVINCETableAdapter
    End Class
End Namespace
