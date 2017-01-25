Imports CrystalDecisions.Shared

Public Class UIReport
    Dim DAProvince As New DSIDVerificationTableAdapters.TBL_PROVINCETableAdapter
    Dim DADistrict As New DSIDVerificationTableAdapters.TBL_DISTRICTTableAdapter
    Dim DACommune As New DSIDVerificationTableAdapters.TBL_COMMUNETableAdapter
    Dim DAVillage As New DSIDVerificationTableAdapters.TBL_VILLAGETableAdapter

    Dim TblPeopleSearch As DataTable
    Dim TblProvince As DataTable = DAProvince.GetData
    Dim TblDistrict As DataTable
    Dim TblCommune As DataTable
    Dim TblVillage As DataTable
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With cboPROVINCE
            .DataSource = TblProvince
            .ValueMember = "PROVINCEID"
            .DisplayMember = "PROV_KH"
            .SelectedIndex = -1

        End With
        With cboDISTRICT
            .DataSource = TblDistrict
            .ValueMember = "DISTRICTID"
            .DisplayMember = "DIST_KH"
            .SelectedIndex = -1
        End With

        With cboCOMMUNE
            .DataSource = TblCommune
            .ValueMember = "COMMUNEID"
            .DisplayMember = "COMM_KH"
            .SelectedIndex = -1
        End With
        With cboVILLAGE
            .DataSource = TblVillage
            .ValueMember = "VILLAGEID"
            .DisplayMember = "VILL_KH"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Function SearchPeopl(ByVal DocumentCod As String, ByVal NameKhmer As String, ByVal NameLatin As String, _
                                 ByVal Province As String, ByVal District As String, ByVal Commune As String, _
                                 ByVal Village As String, ByVal WrongNameKh As Boolean, _
                                 ByVal WrongNameLatin As Boolean, ByVal WrongDOB As Boolean, ByVal WrongSex As Boolean, _
                                 ByVal WrongPOB As Boolean, ByVal WrongAddress As Boolean, ByVal DFrom As Date, ByVal DTo As Date) As String
        Dim sql As String = "SELECT * FROM VIEW_PEOPLE_VERIFICATION WHERE Printed='1' and (PrintDate BETWEEN '" & DFrom.Date & "' AND '" & DTo.Date & "')"
        'If DocumentCod <> "" Then
        '    sql = sql & " AND documentno='" & DocumentCod & "'"
        'End If
        'If NameKhmer.Trim <> "" Then
        '    sql = sql & " AND UPPER(KhmerName) LIKE N'%" & NameKhmer & "%'"
        'End If
        'If NameLatin <> "" Then
        '    sql = sql & " AND UPPER(LatinName) LIKE '%" & NameLatin & "%'"
        'End If
        If Province <> "" Then
            sql = sql & " AND UPPER(VerPolProvince) LIKE N'%" & Province & "%'"
        End If
        If District <> "" Then
            sql = sql & " AND UPPER(VerPolDistrict) LIKE N'%" & District & "%'"
        End If
        If Commune <> "" Then
            sql = sql & " AND UPPER(VerPolCommune) LIKE N'%" & Commune & "%'"
        End If
        If Village <> "" Then
            sql = sql & " AND UPPER(VerPolVillage) LIKE N'%" & Village & "%'"
        End If
        'If WrongNameKh = True Then
        '    sql = sql & " AND surname_khmer<>VerSurnameKhmer AND givenname_khmer<>VerSurnameKhmer"
        'End If
        'If WrongNameLatin = True Then
        '    sql = sql & " AND surname_latin<>VerSurnameLatin AND givenname_latin<>VerGiveNameLatin"
        'End If
        'If WrongDOB = True Then
        '    sql = sql & " AND dateofbirth<>VerDateOfBirth"
        'End If
        'If WrongSex = True Then
        '    sql = sql & " AND sex<>VerSex"
        'End If
        'If WrongPOB = True Then
        '    sql = sql & " AND pobvillage<>VerPobVillage AND pobcommune<>VerPobCommune AND pobdistrict<>VerDistrict AND pobprovince<>VerPobProvince"
        'End If
        'If WrongAddress = True Then
        '    sql = sql & " AND polvillage<>VerPolVillage AND polcommune<>VerPolCommune AND poldistrict<>VerPolDistrict AND polprovince<>VerPolProvince"
        'End If
        Return sql
    End Function

    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click


        Dim sql As String = SearchPeopl("", "", "", _
                                         cboPROVINCE.Text, cboDISTRICT.Text, cboCOMMUNE.Text, cboVILLAGE.Text, _
                                         False, False, False, False, False, False, DFrom.Value, DTo.Value)

        Try
            Dim DS As New DataSet
            Dim dt As New DataTable

            Dim cnn As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
            cnn.Open()
            Dim Da As New SqlClient.SqlDataAdapter(sql, cnn)
            Da.Fill(DS, "VIEW_PEOPLE_VERIFICATION")
            Dim RptName As String = Application.StartupPath & "\ReportPrintOutV1.rpt"
            Dim myReport As New clsCrystalReport()
            Dim FReportViewer As New ReportPreview
            myReport.ReportPath(RptName)
            myReport.SetDataSource(DS, "VIEW_PEOPLE_VERIFICATION")
            myReport.DiscardSavedData()
            myReport.SetParameterValue("Province", cboPROVINCE.Text & " " & cboDISTRICT.Text & " " & cboCOMMUNE.Text & " " & cboVILLAGE.Text & vbCrLf & " ចាប់ពីថ្ងែ: " & Format(DFrom.Value, "dd-MM-yyyy") & " រហូតដល់: " & Format(DTo.Value, "dd-MM-yyyy"))



            'AxCrystalActiveXReportViewer1.Refresh()
            'AxCrystalActiveXReportViewer1.ReportSource = myReport.Report
            'AxCrystalActiveXReportViewer1.ViewReport()
            'AxCrystalActiveXReportViewer1.Zoom(100)

            FReportViewer.ReportViewer.Refresh()
            FReportViewer.ReportViewer.ReportSource = myReport.Report
            FReportViewer.ReportViewer.ViewReport()
            FReportViewer.ReportViewer.Zoom(100)
            FReportViewer.ShowDialog()


            'Dim myReport As New clsCrystalReport()
            'Dim FReportViewer As New ReportPreview
            'myReport.ReportPath(RptName)
            'myReport.SetDataSource(DS, "TblFormVerify")
            'myReport.DiscardSavedData()
            'myReport.SetParameterValue("NotCorrect", MsgVerification)
            'FReportViewer.ReportViewer.Refresh()
            'FReportViewer.ReportViewer.ReportSource = myReport.Report
            'FReportViewer.ReportViewer.ViewReport()
            'FReportViewer.ReportViewer.Zoom(100)
            'FReportViewer.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cboPROVINCE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPROVINCE.SelectedIndexChanged
        Try
            TblDistrict = DADistrict.SelectByProvinceID(cboPROVINCE.SelectedValue)
            cboDISTRICT.DataSource = TblDistrict
            cboDISTRICT.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboDISTRICT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDISTRICT.SelectedIndexChanged
        Try
            TblCommune = DACommune.SelectByDISTRICTID(cboDISTRICT.SelectedValue)
            cboCOMMUNE.DataSource = TblCommune
            cboCOMMUNE.SelectedIndex = -1

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboCOMMUNE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCOMMUNE.SelectedIndexChanged
        Try
            TblVillage = DAVillage.SelectByCOMMUNEID(cboCOMMUNE.SelectedValue)
            cboVILLAGE.DataSource = TblVillage
            cboVILLAGE.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UIReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ModUserMG.ISAdmin = True Then
            cboPROVINCE.Enabled = True
            cboDISTRICT.Enabled = True
            cboCOMMUNE.Enabled = True
            cboVILLAGE.Enabled = True
        Else


            'cboPROVINCE.Text = ModUserMG.DProvince
            'cboPROVINCE.SelectedText = ModUserMG.DProvince
            cboPROVINCE.SelectedValue = ModUserMG.PROVINCE_ID
            Try
                TblDistrict = DADistrict.SelectByProvinceID(cboPROVINCE.SelectedValue)
                cboDISTRICT.DataSource = TblDistrict
                'cboDISTRICT.SelectedIndex = -1
            Catch ex As Exception

            End Try

            If ModUserMG.DDistrict = "" Then
                'cboDISTRICT.Text = ModUserMG.DDistrict
                cboDISTRICT.SelectedIndex = -1
                cboDISTRICT.Enabled = True
            Else

                cboDISTRICT.Enabled = True
                ' cboDISTRICT.SelectedText = ModUserMG.DDistrict
                'cboDISTRICT.Text = ModUserMG.DDistrict
                cboDISTRICT.SelectedValue = ModUserMG.DISTRICT_ID
                cboDISTRICT.Enabled = False
                Try
                    TblCommune = DACommune.SelectByDISTRICTID(cboDISTRICT.SelectedValue)
                    cboCOMMUNE.DataSource = TblCommune
                    'cboCOMMUNE.SelectedIndex = -1

                Catch ex As Exception
                End Try
            End If

            If ModUserMG.DCommune = "" Then
                cboCOMMUNE.SelectedIndex = -1
                'cboCOMMUNE.SelectedText = ModUserMG.DCommune
                ' cboCOMMUNE.Text = ModUserMG.COMMUNE_ID
                cboCOMMUNE.Enabled = True
            Else

                cboCOMMUNE.Enabled = True
                'cboCOMMUNE.SelectedText = ModUserMG.DCommune
                cboCOMMUNE.SelectedValue = ModUserMG.COMMUNE_ID
                cboCOMMUNE.Enabled = False
                Try
                    TblVillage = DAVillage.SelectByCOMMUNEID(cboCOMMUNE.SelectedValue)
                    cboVILLAGE.DataSource = TblVillage
                    'cboVILLAGE.SelectedIndex = -1
                Catch ex As Exception

                End Try
            End If
            If ModUserMG.DVillage = "" Then
                'cboVILLAGE.SelectedText = ModUserMG.DVillage
                cboVILLAGE.SelectedIndex = -1 'SelectedValue = ModUserMG.VILLAGE_ID
                cboVILLAGE.Enabled = True
            Else
                cboVILLAGE.Enabled = True
                ' cboVILLAGE.SelectedText = ModUserMG.DVillage
                cboVILLAGE.SelectedValue = ModUserMG.VILLAGE_ID
                cboVILLAGE.Enabled = False
            End If
        End If




    End Sub

   
End Class
