Imports System.Data.SqlClient

Public Class IDCardStatistic
    Dim GenDAOStatisic As New DAOStatistic
    Dim DAProvince As New DSIDVerificationTableAdapters.TBL_PROVINCETableAdapter
    Dim DADistrict As New DSIDVerificationTableAdapters.TBL_DISTRICTTableAdapter
    Dim DACommune As New DSIDVerificationTableAdapters.TBL_COMMUNETableAdapter
    Dim DAVillage As New DSIDVerificationTableAdapters.TBL_VILLAGETableAdapter

    Dim TblPeopleSearch As DataTable
    Dim TblProvince As DataTable = DAProvince.GetData
    Dim TblDistrict As DataTable
    Dim TblCommune As DataTable
    Dim TblVillage As DataTable

    Dim ShowProvince As Integer = 1
    Dim ShowDis As Integer = 1
    Dim ShowCom As Integer = 1
    Dim ShowVill As Integer = 1
    Dim Mform As MainApplicationForm

    Dim cnnStr As SqlClient.SqlConnection
    Sub New(ByVal Mform As MainApplicationForm)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Function SelectAsDataTable(ByVal objSQL As Object) As DataTable
        Dim dtbl As New DataTable
        Dim da As New SqlDataAdapter(CStr(objSQL), cnnStr)
        da.Fill(dtbl)
        dtbl.Dispose()
        da.Dispose()
        cnnStr.Dispose()
        cnnStr.Close()
        Return dtbl
    End Function
    Private Function SearchProvince(ByVal DFrom As Date, ByVal DTo As Date, ByVal status As String, ByVal DCal As Date)
        Dim sql As String
        If status = "" Then
            sql = " SELECT count(GENDER_TEXT) as CountSex,GENDER_TEXT ,POL_CAPITALPROVINCE_TEXT,POL_CAPITALPROVINCE_CODE," & _
                            "FLOOR((CAST (cast ('" & DCal & "' as datetime) AS INTEGER) - CAST(DATEOFBIRTH AS INTEGER)) / 365.25) as CalAge" & _
                            " FROM STATISTICT_DATA where (DOCUMENTNO <> '000000000') AND (DOCUMENTNO is not  null)" & _
                            " group by POL_CAPITALPROVINCE_TEXT,POL_CAPITALPROVINCE_CODE,GENDER_TEXT,(FLOOR((CAST (cast ('" & DCal & "' as datetime) AS INTEGER) - CAST(DATEOFBIRTH AS INTEGER)) / 365.25)) " & _
                            " order by POL_CAPITALPROVINCE_CODE,CalAge,CountSex"
        Else
            sql = " SELECT count(GENDER_TEXT) as CountSex,GENDER_TEXT ,POL_CAPITALPROVINCE_TEXT,POL_CAPITALPROVINCE_CODE," & _
                            "FLOOR((CAST (cast ('" & DCal & "' as datetime) AS INTEGER) - CAST(DATEOFBIRTH AS INTEGER)) / 365.25) as CalAge" & _
                            " FROM STATISTICT_DATA where (DOCUMENTNO <> '000000000') AND (STATUS='" & status & "' and DOCUMENTNO is not  null)" & _
                            " group by POL_CAPITALPROVINCE_TEXT,POL_CAPITALPROVINCE_CODE,GENDER_TEXT,(FLOOR((CAST (cast ('" & DCal & "' as datetime) AS INTEGER) - CAST(DATEOFBIRTH AS INTEGER)) / 365.25)) " & _
                            " order by POL_CAPITALPROVINCE_CODE,CalAge,CountSex"
        End If
         
        Return sql
    End Function
    Private Function ShowAllPeopleDetail(ByVal Province As String, ByVal District As String, ByVal Commune As String) As String
        Dim sql As String = "SELECT AFISID,BARCODENO,DOCUMENTNO,SURNAME_KHMER,GIVENNAME_KHMER,SURNAME_LATIN,GIVENNAME_LATIN,GENDER_TEXT,DATEOFBIRTH,DATE_OF_REGISTRATION," & _
        "POB_VILLAGE_TEXT,POB_COMMUNECITYQUARTER_TEXT,POB_SECTIONCITYDISTRICT_TEXT,POB_CAPITALPROVINCE_TEXT," & _
        "POL_VILLAGE_TEXT,POL_COMMUNECITYQUARTER_TEXT,POL_SECTIONCITYDISTRICT_TEXT,POL_CAPITALPROVINCE_TEXT," & _
        "POL_VILLAGE_CODE,POL_COMMUNECITYQUARTER_CODE,POL_SECTIONCITYDISTRICT_CODE,POL_CAPITALPROVINCE_CODE," & _
        "ISSUEDATE,EXPIRYDATE,NATIONALITY_TEXT,POL_SECTIONCITYDISTRICT_TYPE,RELIGION_TEXT,ADDRESS" & _
        " FROM STATISTICT_DATA WHERE (DOCUMENTNO <> '000000000') AND  (DOCUMENTNO is not  null)"

        If Province <> "" Then
            sql = sql & " AND POL_CAPITALPROVINCE_CODE=" & Province
        End If
        If District <> "" Then
            sql = sql & " AND POL_SECTIONCITYDISTRICT_CODE=" & District
        End If
        If Commune <> "" Then
            sql = sql & " AND POL_COMMUNECITYQUARTER_CODE=" & Commune
        End If


        Return sql & " ORDER BY GENDER_TEXT"

    End Function
    Private Function SearchPeopl(ByVal Province As String, ByVal District As String, ByVal Commune As String, ByVal DFrom As Date, ByVal DTo As Date, ByVal status As String, ByVal DCal As DateTime) As String
        Dim sql As String = "SELECT GENDER_TEXT,DATEOFBIRTH,DATE_OF_REGISTRATION," & _
        "POL_VILLAGE_TEXT,POL_COMMUNECITYQUARTER_TEXT,POL_SECTIONCITYDISTRICT_TEXT,POL_CAPITALPROVINCE_TEXT," & _
        "POL_VILLAGE_CODE,POL_COMMUNECITYQUARTER_CODE,POL_SECTIONCITYDISTRICT_CODE,POL_CAPITALPROVINCE_CODE," & _
        "ISSUEDATE,EXPIRYDATE,NATIONALITY_TEXT,POL_SECTIONCITYDISTRICT_TYPE," & _
        "FLOOR((CAST (cast ('" & DCal & "' as datetime) AS INTEGER) - CAST(DATEOFBIRTH AS INTEGER)) / 365.25) AS CalAge FROM STATISTICT_DATA WHERE (DOCUMENTNO <> '000000000') AND  (DOCUMENTNO is not  null)"
        If status <> "" Then
            sql = sql & " AND STATUS='" & status & "'"
        End If

        If Province <> "" Then
            sql = sql & " AND POL_CAPITALPROVINCE_CODE=" & Province
        End If
        If District <> "" Then
            sql = sql & " AND POL_SECTIONCITYDISTRICT_CODE=" & District
        End If
        If Commune <> "" Then
            sql = sql & " AND POL_COMMUNECITYQUARTER_CODE=" & Commune
        End If
        'If NameKhmer.Trim <> "" Then
        '    sql = sql & " AND UPPER(KhmerName) LIKE N'%" & NameKhmer & "%'"
        'End If
        'If NameLatin <> "" Then
        '    sql = sql & " AND UPPER(LatinName) LIKE '%" & NameLatin & "%'"
        'End If
        'If Province <> "" Then
        '    sql = sql & " AND UPPER(VerPolProvince) LIKE N'%" & Province & "%'"
        'End If
        'If District <> "" Then
        '    sql = sql & " AND UPPER(VerPolDistrict) LIKE N'%" & District & "%'"
        'End If
        'If Commune <> "" Then
        '    sql = sql & " AND UPPER(VerPolCommune) LIKE N'%" & Commune & "%'"
        'End If
        'If Village <> "" Then
        '    sql = sql & " AND UPPER(VerPolVillage) LIKE N'%" & Village & "%'"
        'End If

        Return sql
    End Function






    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub IDCardStatistic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnnStr = New SqlClient.SqlConnection(My.Settings.DBCnnStatistic)
        With cboPROVINCE
            .DataSource = TblProvince
            .ValueMember = "PROVINCEID"
            .DisplayMember = "PROV_KH"
            .SelectedIndex = -1

        End With
        Me.Mform = Mform
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




        'With CboStatus
        '    .DataSource = SelectAsDataTable("select distinct STATUS from STATISTICT_DATA order by STATUS desc")
        '    .DisplayMember = "STATUS"
        '    .ValueMember = "STATUS"
        'End With
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
    Dim myReport As New clsCrystalReport()
    Dim sql As String
    Dim CaptionPara As String = ""
    Dim Position1 As String = ""
    Dim Position2 As String = ""
    Dim Position3 As String = ""
    Dim DtoD As String = ""
    Dim Title As String = ""
    Dim DS As New DataSet
    Dim dt As New DataTable

    Dim cnn As New SqlClient.SqlConnection(My.Settings.DBCnnStatistic)
    Sub LoadingReport()
        CaptionPara = ""
        Position1 = ""
        Position2 = ""
        Position3 = ""
        DtoD = ""
        Title = ""
        sql = ""
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingReport))
        Else

            Application.DoEvents()
            If cboPROVINCE.Text.Trim <> "" Then
                ShowProvince = 1
                ShowDis = 0
                ShowCom = 1
                ShowVill = 1
                If cboPROVINCE.SelectedValue = 1 Then
                    CaptionPara = "ខ័ណ្ឌ"
                Else
                    CaptionPara = "ស្រុក"
                End If
            End If
            If cboPROVINCE.Text.Trim <> "" And cboDISTRICT.Text <> "" Then
                ShowProvince = 1
                ShowDis = 1
                ShowCom = 0
                ShowVill = 1
                If cboPROVINCE.SelectedValue = 1 Then
                    CaptionPara = "សង្កាត់"
                Else
                    CaptionPara = "ឃុំ"
                End If
            End If
            If cboPROVINCE.Text.Trim <> "" And cboDISTRICT.Text.Trim <> "" And cboCOMMUNE.Text.Trim <> "" Then
                ShowProvince = 1
                ShowDis = 1
                ShowCom = 1
                ShowVill = 0

            End If
            If cboPROVINCE.Text.Trim = "" And cboDISTRICT.Text.Trim = "" And cboCOMMUNE.Text.Trim = "" And cboVILLAGE.Text.Trim = "" Then
                ShowProvince = 0
                ShowDis = 1
                ShowCom = 1
                ShowVill = 1

            End If
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Temp", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Next
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            If ChAll.Checked = True Then
                sql = SearchProvince(DFrom.Value.Date, DTo.Value.Date, CboStatus.Text, DateCalculate.Value)
            Else
                If ChDetail.Checked = True Then
                    sql = ShowAllPeopleDetail(cboPROVINCE.SelectedValue, cboDISTRICT.SelectedValue, cboCOMMUNE.SelectedValue)
                Else
                    sql = Me.SearchPeopl(cboPROVINCE.SelectedValue, cboDISTRICT.SelectedValue, cboCOMMUNE.SelectedValue, DFrom.Value.Date, DTo.Value.Date, CboStatus.Text, DateCalculate.Value)
                End If

            End If


            Try


                DS.Clear()
                Application.DoEvents()


                Dim da = New SqlDataAdapter()
                Dim cmd As SqlCommand = cnn.CreateCommand()
                cmd.CommandTimeout = 50000
                cmd.CommandText = sql
                da.SelectCommand = cmd

                cnn.Open()

                If ChAll.Checked = True Then
                    Da.Fill(DS, "SelectAllProvince")
                Else
                    Da.Fill(DS, "StatisticPeople")
                End If
                'da.Fill(ds);
                cnn.Close()



                'Dim Da As New SqlClient.SqlDataAdapter(sql, cnn)


                'Application.DoEvents()
                'System.Threading.Thread.Sleep(100)
                'Application.DoEvents()

                'If ChAll.Checked = True Then
                '    Da.Fill(DS, "SelectAllProvince")
                'Else
                '    Da.Fill(DS, "StatisticPeople")
                'End If

                Application.DoEvents()
                Dim RptName As String
                If ChAll.Checked = True Then
                    RptName = Application.StartupPath & "\StatisticAllProv.rpt"
                Else
                    If SexMal.Checked = True Then
                        If ChDetail.Checked = True Then
                            RptName = Application.StartupPath & "\StatisticPeopleDetail.rpt"
                        Else
                            RptName = Application.StartupPath & "\StatisticPeople.rpt"
                        End If

                    Else
                        RptName = Application.StartupPath & "\StatisticPeopleFemale.rpt"
                    End If
                End If




                myReport.ReportPath(RptName)
                Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                myReport.SetDataSource(DS, "StatisticPeople")
                myReport.DiscardSavedData()
                myReport.SetParameterValue("Province", ShowProvince) 'cboPROVINCE.Text & " " & cboDISTRICT.Text & " " & cboCOMMUNE.Text & " " & cboVILLAGE.Text & vbCrLf & " ចាប់ពីថ្ងែ: " & Format(DFrom.Value, "dd-MM-yyyy") & " រហូតដល់: " & Format(DTo.Value, "dd-MM-yyyy"))
                myReport.SetParameterValue("ShowDis", ShowDis)
                myReport.SetParameterValue("ShowCom", ShowCom)
                myReport.SetParameterValue("ShowVillage", ShowVill)

                cnn.Close()
                DS.Dispose()
                Da.SelectCommand.Connection.Close()
                Da.SelectCommand.Dispose()
                ' Set Parameter Cystal
                ' Case 1  
                If cboPROVINCE.Text = "ភ្នំពេញ" Then
                    Title = "រាជធានី" & cboPROVINCE.Text
                    CaptionPara = "ខណ្ឌ"
                    Position1 = "អភិបាលរាជធានី"
                    Position2 = "ស្នងការនគរបាលរាជធានី"
                    Position3 = "នាយការិយាល័យអត្តសញ្ញាណប័ណ្ណសញ្ជាតិខ្មែរ"
                End If

                ' Case 2
                If cboPROVINCE.Text.Trim = "" And cboDISTRICT.Text.Trim = "" And cboCOMMUNE.Text.Trim = "" And cboVILLAGE.Text.Trim = "" Then
                    Title = ""
                    CaptionPara = "ខេត្ត"
                    Position1 = ""
                    Position2 = ""
                    Position3 = "ប្រធាននាយកដ្ឋានអត្ត-ប័ណ្ណសញ្ជាតិខ្មែរ"
                End If
                ' Case 3
                If cboPROVINCE.Text <> "ភ្នំពេញ" Then
                    Title = "ខេត្ត" & cboPROVINCE.Text
                    CaptionPara = "ស្រុក"
                    Position1 = "អភិបាលខេត្ត"
                    Position2 = "ស្នងការនគរបាលខេត្ត"
                    Position3 = "នាយការិយាល័យអត្តសញ្ញាណប័ណ្ណសញ្ជាតិខ្មែរ"
                End If


                'Case 4 

                If cboPROVINCE.Text = "ភ្នំពេញ" And cboDISTRICT.Text <> "" Then
                    Title = "រាជធានី" & cboPROVINCE.Text & "/ខណ្ឌ" & cboDISTRICT.Text
                    CaptionPara = "សង្កាត់"
                    Position1 = "អភិបាលខណ្ឌ"
                    Position2 = "អធិការនគរបាល"
                    Position3 = "នាយផ្នែកអត្តសញ្ញាណប័ណ្ណ"
                End If

                ' Case 5
                If cboPROVINCE.Text = "ភ្នំពេញ" And cboDISTRICT.Text <> "" And cboCOMMUNE.Text <> "" Then
                    Title = "រាជធានី" & cboPROVINCE.Text & "/ខណ្ឌ" & cboDISTRICT.Text & "/សង្កាត់" & cboCOMMUNE.Text
                    CaptionPara = "ភូមិ"
                    Position1 = ""
                    Position2 = "ចៅសង្កាត់"
                    Position3 = "នាយនគរបាលប៉ុស្តិ៍នរដ្ឋបាល"
                End If

                ' Case 6
                If cboPROVINCE.Text <> "ភ្នំពេញ" And cboDISTRICT.Text <> "" Then
                    Title = "ខេត្ត" & cboPROVINCE.Text & "/ស្រុក" & cboDISTRICT.Text
                    CaptionPara = "ឃុំ/សង្កាត់"
                    Position1 = "អភិបាលក្រុង/ស្រុក"
                    Position2 = "អធិការនគរបាល"
                    Position3 = "នាយផ្នែកអត្តសញាណប័ណ្ណ"
                End If

                ' Case 7 
                If cboPROVINCE.Text <> "ភ្នំពេញ" And cboDISTRICT.Text <> "" And cboCOMMUNE.Text <> "" Then
                    Title = "ខេត្ត" & cboPROVINCE.Text & "/ស្រុក" & cboDISTRICT.Text & "/ឃុំ" & cboCOMMUNE.Text
                    CaptionPara = "ភូមិ"
                    Position1 = ""
                    Position2 = "មេឃុំ/ចៅសង្កាត់"
                    Position3 = "នាយនគរបាលប៉ុស្តិ៍នរដ្ឋបាល"
                End If
                If ChAll.Checked = True Then
                    Title = ""
                    CaptionPara = "រាជធានី/ខេត្ត"
                    Position1 = ""
                    Position2 = ""
                    Position3 = "ប្រធាននាយកដ្ឋាន"
                End If

                myReport.SetParameterValue("Title", Title)
                myReport.SetParameterValue("CapAddress", CaptionPara)
                myReport.SetParameterValue("PolicePos", Position1)
                myReport.SetParameterValue("Postion2", Position2)
                myReport.SetParameterValue("Position3", Position3)
                'If ChAll.Checked = True Then
                myReport.SetParameterValue("DCompaie", Format(DateCalculate.Value.Date, "dd/MM/yyyy"))
                'End If
                myReport.SetParameterValue("DateToDate", "ចាប់ពីខែ មិថុនា 2012  ដល់ " & Format(DTo.Value.Date, "dd/MM/yyyy"))

                'AxCrystalActiveXReportViewer1.Refresh()
                'AxCrystalActiveXReportViewer1.ReportSource = myReport.Report
                'AxCrystalActiveXReportViewer1.ViewReport()
                'AxCrystalActiveXReportViewer1.Zoom(100)




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

        End If

    End Sub
    ' ------------------------Show status -------------------------------
    Private Delegate Sub DelShowLabelStatus(ByVal txt As String, ByVal v As Boolean)
    Private Delegate Sub DelegatePicture(ByVal v As Boolean)
    Private Delegate Sub DelegateLoadingData()
    'Private Sub UpdateStatus(ByVal txt As String, ByVal v As Boolean)
    '    LblStatus.Visible = v
    '    LblStatus.Text = txt
    'End Sub
    Private Sub UpdateVisiblePicLoading(ByVal v As Boolean)
        Application.DoEvents()
        PictureBox1.Visible = v
    End Sub
    Public Sub UpdateLoaingPic(ByVal v As Boolean)
        If Me.Created Then
            Me.Invoke(New DelegatePicture(AddressOf UpdateVisiblePicLoading), New Object() {v})
            'PictureBox1.Invoke(New DelegatePicture(AddressOf UpdateVisiblePicLoading), New Object() {v})
        End If
    End Sub
    Public Sub CreateDelgateData()
        If Me.Created Then
            Me.Invoke(New DelegateLoadingData(AddressOf LoadingReport), New Object() {})
        End If
    End Sub
    'Public Sub UpdateLabelStatus(ByVal txt As String, ByVal v As Boolean)
    '    If Me.Created Then
    '        LblStatus.Invoke(New DelShowLabelStatus(AddressOf UpdateStatus), New Object() {txt, v})
    '    End If
    'End Sub

    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        ' LoadingReport()
        CreateDelgateData()
    End Sub

    Private Sub BtnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReport.Click

        UpdateVisiblePicLoading(True)

        System.Threading.Thread.Sleep(100)
        Application.DoEvents()
        BgLoadingReport.RunWorkerAsync()

    End Sub

    Private Sub BgLoadingReport_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadingReport.RunWorkerCompleted
        Dim FReportViewer As New ReportPreview
        FReportViewer.ReportViewer.Refresh()
        FReportViewer.ReportViewer.ReportSource = myReport.Report

        FReportViewer.ReportViewer.ViewReport()
        FReportViewer.ReportViewer.Zoom(140)
        UpdateVisiblePicLoading(False)

        FReportViewer.ShowDialog()
        FReportViewer.ReportViewer.Refresh()
        myReport.Close()
        DS.Dispose()
        cnn.Close()
        FReportViewer.Close()
        FReportViewer.Dispose()

    End Sub

    Private Sub ChAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChAll.CheckedChanged
        If ChAll.Checked = False Then
            GroupBox4.Enabled = True
            ChDetail.Enabled = True
        Else
            GroupBox4.Enabled = False
            ChDetail.Enabled = False
        End If
    End Sub

    Private Sub BtnGiveData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGiveData.Click
        PictureBox1.Visible = True
        Application.DoEvents()
        Threading.Thread.Sleep(20)
        Dim sql As String
        If ChAllCondition.Checked = False Then
            sql = "Select count(*) FROM STATISTICT_DATA WHERE (DATE_OF_REGISTRATION BETWEEN '" & DFrom.Value.Date & "' AND '" & DTo.Value.Date & "') AND status='" & CboStatus.Text & "'"
        Else
            sql = "Select count(*) FROM STATISTICT_DATA WHERE (DATE_OF_REGISTRATION BETWEEN '" & DFrom.Value.Date & "' AND '" & DTo.Value.Date & "')"
        End If


        TxtTotalRegis.Text = GenDAOStatisic.SelectDAOAsScalar(sql)
        Application.DoEvents()
        PictureBox1.Visible = False
    End Sub

    Private Sub ChAllCondition_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChAllCondition.CheckedChanged
        If ChAllCondition.Checked = True Then
            CboStatus.SelectedIndex = -1
            CboStatus.Enabled = False
        Else
            CboStatus.Enabled = True
            CboStatus.Text = 260
        End If


    End Sub
End Class
