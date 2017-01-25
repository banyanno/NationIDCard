Module ModuleIDCard
    Dim generalDAO As New GeneralDAO

    Function GetImpage(ByVal autoID As String, ByVal Field As String) As Object
        Dim SQL As String = "select " & Field & " from VIEW_PEOPLE_VERIFICATIONForImage WHERE old_id='" & autoID & "'"
        Return generalDAO.SelectDAOAsScalar(SQL)
    End Function
    Function GetAllInfoPeopleByID(ByVal AutoID As Double) As DataTable
        Dim sql As String = "select * from VIEW_PEOPLE_VERIFICATIONForImage where afisid=" & AutoID
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function
    Function GetTotaFinger(ByVal DocID As String) As Integer
        Dim sql As String = "Select count(*) from VIEW_PEOPLE_VERIFICATION WHERE old_id='" & DocID & "'"
        Return CInt(generalDAO.SelectDAOAsScalar(sql))
    End Function
    Function GetStatusPrint(ByVal AutoID As Double) As String
        Dim SQL As String = "Select Printed from tbl_verification where afisid=" & AutoID
        Dim Result As String = IIf(TypeOf (generalDAO.SelectDAOAsScalar(SQL)) Is DBNull, "0", generalDAO.SelectDAOAsScalar(SQL))
        If Result = "1" Then
            Return "យល់ព្រម"
        Else
            Return "មិនយល់ព្រម"
        End If


    End Function
    Function GetInformationIDCard(ByVal SQL As String) As DataTable
        Return generalDAO.SelectDAOAsDataTatable(SQL)
    End Function
    Function UpdateReqCorrect(ByVal autoID As Double, ByVal CorrectOn As String) As Integer
        Dim sql As String = "UPDATE tbl_verification set Printed='1',PrintDate='" & Now.Date & "',Verification=N'" & CorrectOn & "' WHERE afisid=" & autoID
        Return generalDAO.UpdateDAO(sql)
    End Function
    Function DeletePersiont(ByVal autoNo As Double) As Integer
        Dim sql As String = "DELETE FROM tbl_verification WHERE afisid=" & autoNo
        Return generalDAO.DeleteDAO(sql)
    End Function
    Function GetAllPeopleInfo(ByVal sql)
        ' Dim sql As String = "select * from VIEW_PEOPLE_VERIFICATION"
        Return generalDAO.SelectDAOAsDataTatable(sql)
    End Function
End Module
