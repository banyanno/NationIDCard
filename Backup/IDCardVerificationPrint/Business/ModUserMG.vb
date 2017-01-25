Module ModUserMG
    Dim generalDAO As New GeneralDAO
    Public USERID As String
    Public PROVINCE_ID As Integer
    Public DISTRICT_ID As Integer
    Public COMMUNE_ID As String
    Public VILLAGE_ID As Integer
    Public UserName As String
    Public DataAccess As String
    Public DProvince As String
    Public DDistrict As String
    Public DCommune As String
    Public DVillage As String
    Public ISAdmin As Boolean
    Public Function CreateNewUser(ByVal UserName As String, ByVal Password As String, ByVal AC_Provice As String, ByVal AC_District As String, ByVal Ac_Commune As String, ByVal AC_Village As String, ByVal IS_Admin As String, ByVal PROVINCE_ID As Integer, ByVal DISTRICT_ID As Integer, ByVal COMMUNE_ID As Integer, ByVal VILLAGE_ID As Integer) As Integer
        Dim SQL As String = "INSERT INTO USER_MG (USER_NAME,PASSWORD,DATA_PROVICE_PM,DATA_DISTRICT_PM,DATA_COMMUNE,DATA_VILLAGE,IS_ADMIN,PROVINCE_ID,DISTRICT_ID,COMMUNE_ID,VILLAGE_ID) " & _
        "VALUES('" & UserName & "','" & Password & "',N'" & AC_Provice & "',N'" & AC_District & "',N'" & Ac_Commune & "',N'" & AC_Village & "','" & IS_Admin & "'," & PROVINCE_ID & "," & DISTRICT_ID & "," & COMMUNE_ID & "," & VILLAGE_ID & ")"
        Return generalDAO.InsertDAO(SQL)
    End Function
    Public Function SelectUserLogIn(ByVal UserName As String, ByVal Pwd As String) As DataTable
        Dim SQL As String = "SELECT * FROM USER_MG WHERE UPPER(USER_NAME)=UPPER('" & UserName & "') AND UPPER(PASSWORD)=UPPER('" & Pwd & "')"
        Return generalDAO.SelectAsDataTable(SQL)
    End Function
    Public Function SelectAllUser() As DataTable
        Dim SQL As String = "SELECT * FROM USER_MG"
        Return generalDAO.SelectAsDataTable(SQL)
    End Function
    Public Function ResetPassword(ByVal UserID As String, ByVal NewPssword As String) As Integer
        Dim SQL As String = "UPDATE USER_MG SET PASSWORD='" & NewPssword & "' WHERE USER_ID=" & UserID
        Return generalDAO.UpdateDAO(SQL)
    End Function
    Public Function ChangePermision(ByVal UserID As String, ByVal AccProvince As String, ByVal AccDistrict As String, ByVal AccCommune As String, ByVal AccVillage As String, ByVal IsAdmin As Boolean, ByVal PROVINCE_ID As Integer, ByVal DISTRICT_ID As Integer, ByVal COMMUNE_ID As Integer, ByVal VILLAGE_ID As Integer) As Integer
        Dim SQL As String = "UPDATE USER_MG SET DATA_PROVICE_PM=N'" & AccProvince & "',DATA_DISTRICT_PM=N'" & AccDistrict & "',DATA_COMMUNE=N'" & AccCommune & "',DATA_VILLAGE=N'" & AccVillage & "',IS_ADMIN='" & IsAdmin & "',PROVINCE_ID=" & PROVINCE_ID & ",DISTRICT_ID=" & DISTRICT_ID & ",COMMUNE_ID=" & COMMUNE_ID & ",VILLAGE_ID= " & VILLAGE_ID & " WHERE USER_ID=" & UserID
        Return generalDAO.UpdateDAO(SQL)
    End Function
    Public Function DeleteUser(ByVal userId As String) As Integer
        Dim SQl As String = "DELETE FROM USER_MG WHERE USER_ID=" & userId
        Return generalDAO.UpdateDAO(SQl)
    End Function
    Public Function SelectUserByProvince(ByVal Province As String) As DataTable
        Dim SQL As String = "SELECT * FROM USER_MG WHERE DATA_PROVICE_PM=N'" & Province & "'"
        Return generalDAO.SelectAsDataTable(SQL)
    End Function
End Module
