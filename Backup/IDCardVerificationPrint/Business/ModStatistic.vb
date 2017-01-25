Module ModStatistic
    Dim generalDAO As New GeneralDAO

    Function GetAllInfoPeople(ByVal DateCal As DateTime) As DataTable
        Dim sql As String = "SELECT *,DATEDIFF(YYYY,DATEOFBIRTH,'" & DateCal & "') as Age FROM STATISTICT_DATA  order by AFISID"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function
End Module
