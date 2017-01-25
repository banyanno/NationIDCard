Imports System.IO
Imports System.Data.SqlClient

Public Class ElectionComparetion
    Dim GenDAOStatisic As New DAOStatistic
    Dim MainAp As MainApplicationForm
    Dim myReport As New clsCrystalReport()
    Sub New(ByVal MainAp As MainApplicationForm)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.MainAp = MainAp

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Function GetImgAtack(ByVal ID_Name As String) As Object
        Dim SQL As String = "select PHOTO from PHOTOS WHERE FILE_NAME='" & ID_Name & "'"
        Return GenDAOStatisic.SelectDAOAsScalar(SQL)
    End Function

    Private Function CountTotalIdentify() As Double
        Return CDbl(GenDAOStatisic.SelectAsScalar("SELECT count(AFISID) from STATISTICT_DATA where STATUS=260 "))
    End Function
    Private Sub btnVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click
        LoadDataFromKJB()
    End Sub
    Private Sub LoadDataFromKJB()
        Dim SQL As String = "SELECT RegistrationId,IDNumber,FamilyName,GivenName,Gender,DateOfBirth,ProvinceCode,ProvinceKh,CommuneCode,CommuneKh FROM Registration "
        If ChProvince.Checked = True Then
            If cboProvince.Text <> "" Then
                SQL = SQL & " WHERE ProvinceKh=N'" & cboProvince.Text & "'"
            End If
        End If
        SQL = SQL & " ORDER BY FamilyName,ProvinceKh"
        GridKJB.DataSource = GenDAOStatisic.SelectDAOAsDataTatable(SQL)
        LblTotal.Text = "ទិន្នន័យពី គ-ជ-ព =" & GridKJB.RowCount & "នាក់ ,ទិន្នន័យក្នុងប្រព័ន្ធអត្ត.ប័ណ្ណ =" & CountTotalIdentify() & "នាក់"
        btnScan.Enabled = True
    End Sub
    Dim StyleFound As New Janus.Windows.GridEX.GridEXFormatStyle
    Dim StyleNoFoun As New Janus.Windows.GridEX.GridEXFormatStyle
    Dim TblResult As DataTable

    Dim TotalFound As Double = 0
    Dim TotalWrong As Double = 0
    Dim Index As Integer = 0
    Private WithEvents LazyBGW As New System.ComponentModel.BackgroundWorker
    Private Sub AccData()
        If Me.InvokeRequired Then
            GridKJB.Invoke(New MethodInvoker(AddressOf AccData))
            LblWatching.Invoke(New MethodInvoker(AddressOf AccData))
        Else
            If GridKJB.RowCount = 0 Then Exit Sub
            IsScaning = True
            For i As Integer = Index To GridKJB.RowCount - 1
                If IsScaning = True Then

                    GridKJB.Row = Index

                    'MsgBox(GridKJB.Row & " Index= " & i)
                    TblResult = GenDAOStatisic.SelectDAOAsDataTatable(SQLSearchMOI(ChIDCard.Checked, ChFamilyName.Checked, ChName.Checked, ChProvince.Checked, ChSex.Checked, ChDOB.Checked, _
                                                                          GridKJB.GetRow(Index).Cells("IDNumber").Value, GridKJB.GetRow(Index).Cells("FamilyName").Value, GridKJB.GetRow(Index).Cells("GivenName").Value, _
                                                                         IIf(GridKJB.GetRow(Index).Cells("Gender").Value = 1, "ប្រុស", "ស្រី"), GridKJB.GetRow(Index).Cells("DateOfBirth").Value, cboProvince.Text))

                    For Each RowResult As DataRow In TblResult.Rows
                        GenDAOStatisic.InsertDAO("INSERT INTO MOI_TEM_RESULT (AFISID,DOCUMENTNO,SURNAME_KHMER,GIVENNAME_KHMER,GENDER_TEXT,DATEOFBIRTH,ROW_POSITION,RegistrationId,DATE_SCAN) VALUES( " & _
                        RowResult("AFISID") & ",'" & RowResult("DOCUMENTNO") & "',N'" & RowResult("SURNAME_KHMER") & "',N'" & RowResult("GIVENNAME_KHMER") & "',N'" & RowResult("GENDER_TEXT") & "','" & RowResult("DATEOFBIRTH") & "'," & Index & "," & GridKJB.GetRow(i).Cells("RegistrationId").Value & "," & Now.Date & _
                                                 ")")
                        TotalFound = TotalFound + 1
                    Next
                    If TblResult.Rows.Count > 0 Then
                        'TotalFound = TotalFound + 1
                        StyleFound.BackColor = Color.Azure
                    Else
                        StyleFound.BackColor = Color.Empty
                    End If


                    'Else
                    '    a.BackColor = Color.CornflowerBlue
                    '    a.FontStrikeout = Janus.Windows.GridEX.TriState.True
                    'End If
                    'MessageBox.Show(GridKJB.GetRow(i).Cells("IDNumber").Value & " " & GridKJB.GetRow(i).Cells("FamilyName").Value & " " & GridKJB.GetRow(i).Cells("GivenName").Value & " " & GridKJB.GetRow(i).Cells("DateOfBirth").Value & " " & GridKJB.GetRow(i).Cells("Gender").Value)
                    GridKJB.GetRow(Index).Cells("IDNumber").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("FamilyName").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("GivenName").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("Gender").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("DateOfBirth").FormatStyle = StyleFound
                    Index = Index + 1
                    LblWatching.Text = "ចំនួរកឃើញ: " & TotalFound & " ចំនួនកំពុងស្វែងរក:  " & Index & " ធៀបនិង " & GridKJB.RowCount & "នាក់"
                    System.Threading.Thread.Sleep(10)
                    Application.DoEvents()
                Else
                    'LblWatching.Text = "ចំនួរកឃើញ: " & 0 & " ចំនួនកំពុងស្វែងរក:  " & 0 & " ធៀបនិង " & GridKJB.RowCount & "នាក់"
                    Exit For
                End If

            Next

        End If
    End Sub
    Private Sub LazyBGW_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles LazyBGW.DoWork
        AccData()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScan.Click
        If GridKJB.RowCount = 0 Then Exit Sub
        GridKJB.Focus()
        GridKJB.Select()
        If btnScan.Text = "ផ្តើម ផ្ទៀងផ្ទៀត" Then
            IsScaning = True
            PictureBox1.Visible = True
            btnScan.Text = "បញ្ឈប់ ផ្ទៀងផ្ទៀត"
            BtnCancel.Enabled = False
        Else
            IsScaning = False
            PictureBox1.Visible = False
            btnScan.Text = "ផ្តើម ផ្ទៀងផ្ទៀត"
            BtnCancel.Enabled = True
        End If

        For i As Integer = 0 To GridKJB.RowCount - 1
            If IsScaning = True Then
                Try
                    System.Threading.Thread.Sleep(10)
                    Application.DoEvents()
                    GridKJB.Row = Index
                    'MsgBox(GridKJB.Row & " Index= " & i)
                    'MessageBox.Show(IsExist1(GridKJB.GetRow.Cells("RegistrationId").Value))

                    TblResult = GenDAOStatisic.SelectDAOAsDataTatable(SQLSearchMOI(ChIDCard.Checked, ChFamilyName.Checked, ChName.Checked, ChProvince.Checked, ChSex.Checked, ChDOB.Checked, _
                                                                                                  GridKJB.GetRow(Index).Cells("IDNumber").Value, GridKJB.GetRow(Index).Cells("FamilyName").Value, GridKJB.GetRow(Index).Cells("GivenName").Value, _
                                                                                                 IIf(GridKJB.GetRow(Index).Cells("Gender").Value = 1, "ប្រុស", "ស្រី"), GridKJB.GetRow(Index).Cells("DateOfBirth").Value, GridKJB.GetRow(Index).Cells("ProvinceKh").Value))

                    For Each RowResult As DataRow In TblResult.Rows
                        If (IsExist1(GridKJB.GetRow.Cells("RegistrationId").Value) = 0) Then
                            Application.DoEvents()
                            GenDAOStatisic.InsertDAO("INSERT INTO MOI_TEM_RESULT " & _
                            "(AFISID,DOCUMENTNO,SURNAME_KHMER,GIVENNAME_KHMER,GENDER_TEXT,DATEOFBIRTH,POL_CAPITALPROVINCE_TEXT ,POL_SECTIONCITYDISTRICT_TEXT ,POL_COMMUNECITYQUARTER_TEXT,ROW_POSITION,RegistrationId,IDNumber,FamilyName,GivenName,Gender,DateOfBirthKJB,ProvinceCode,ProvinceKh,CommuneCode,CommuneKh,DATE_SCAN) VALUES( " & _
                            RowResult("AFISID") & ",'" & RowResult("DOCUMENTNO") & "',N'" & RowResult("SURNAME_KHMER") & "',N'" & RowResult("GIVENNAME_KHMER") & "',N'" & RowResult("GENDER_TEXT") & "','" & RowResult("DATEOFBIRTH") & "',N'" & _
                            RowResult("POL_CAPITALPROVINCE_TEXT") & "',N'" & RowResult("POL_SECTIONCITYDISTRICT_TEXT") & "',N'" & RowResult("POL_COMMUNECITYQUARTER_TEXT") & "'," & _
                            Index & "," & GridKJB.GetRow(i).Cells("RegistrationId").Value & ",'" & GridKJB.GetRow(Index).Cells("IDNumber").Value & "',N'" & GridKJB.GetRow(Index).Cells("FamilyName").Value & "',N'" & GridKJB.GetRow(Index).Cells("GivenName").Value & "'," & _
                            GridKJB.GetRow(Index).Cells("Gender").Value & ",'" & GridKJB.GetRow(Index).Cells("DateOfBirth").Value & _
                            "'," & GridKJB.GetRow(Index).Cells("ProvinceCode").Value & ",N'" & GridKJB.GetRow(Index).Cells("ProvinceKh").Value & "'," & GridKJB.GetRow(Index).Cells("CommuneCode").Value & ",N'" & GridKJB.GetRow(Index).Cells("CommuneKh").Value & _
                             "','" & Now.Date & "')")
                            TotalFound = TotalFound + 1
                        End If
                        
                    Next
                    
                    Application.DoEvents()
                    If IsExist2(GridKJB.GetRow.Cells("RegistrationId").Value) = 0 Then
                        GenDAOStatisic.InsertDAO("INSERT INTO MOI_TEM_RESULT_WRONG " & _
                     "(AFISID,DOCUMENTNO,SURNAME_KHMER,GIVENNAME_KHMER,GENDER_TEXT,DATEOFBIRTH,POL_CAPITALPROVINCE_TEXT ,POL_SECTIONCITYDISTRICT_TEXT ,POL_COMMUNECITYQUARTER_TEXT,ROW_POSITION,RegistrationId,IDNumber,FamilyName,GivenName,Gender,DateOfBirthKJB,ProvinceCode,ProvinceKh,CommuneCode,CommuneKh,DATE_SCAN) VALUES( " & _
                     0 & ",'-',N'-',N'-',N'-','" & Now.Date & "',N'-',N'-',N'-'," & _
                     Index & "," & GridKJB.GetRow(i).Cells("RegistrationId").Value & ",'" & GridKJB.GetRow(Index).Cells("IDNumber").Value & "',N'" & GridKJB.GetRow(Index).Cells("FamilyName").Value & "',N'" & GridKJB.GetRow(Index).Cells("GivenName").Value & "'," & _
                     GridKJB.GetRow(Index).Cells("Gender").Value & ",'" & GridKJB.GetRow(Index).Cells("DateOfBirth").Value & _
                     "'," & GridKJB.GetRow(Index).Cells("ProvinceCode").Value & ",N'" & GridKJB.GetRow(Index).Cells("ProvinceKh").Value & "'," & GridKJB.GetRow(Index).Cells("CommuneCode").Value & ",N'" & GridKJB.GetRow(Index).Cells("CommuneKh").Value & _
                      "','" & Now.Date & "')")
                        TotalWrong = TotalWrong + 1
                    End If




                    StyleFound.BackColor = Color.PapayaWhip


                    
                    GridKJB.GetRow(Index).Cells("IDNumber").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("FamilyName").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("GivenName").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("Gender").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("DateOfBirth").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("ProvinceKh").FormatStyle = StyleFound
                    GridKJB.GetRow(Index).Cells("CommuneKh").FormatStyle = StyleFound

                    Index = Index + 1
                    LblWatching.Text = "ចំនួនរកឃើញ:" & TotalFound & " ចំនួនខុស: " & TotalWrong & " ចំនួនកំពុងស្វែងរក:  " & Index & " ធៀបនិងទិន្នន័យក្នុងប្រព័ន្ធអត្ត.ប័ណ្ណ"
                    MainAp.Text = LblWatching.Text
                Catch ex As Exception
                    'LblWatching.Text = "System is connection time out to datbase. It will rescan a fiew second again. " & ex.Message
                    'Threading.Thread.Sleep(1000)
                    'ToolStripButton1_Click(sender, e)
                End Try

            Else
                ViewResult()
                Exit For
            End If

        Next
        PictureBox1.Visible = False
        ViewResult()
    End Sub

    Function IsExist1(ByVal regidID As Double) As Int16
        Return (GenDAOStatisic.SelectAsScalar("SELECT COUNT(*) FROM MOI_TEM_RESULT WHERE RegistrationId= " & regidID))
        '0 Or GenDAOStatisic.SelectAsScalar("SELECT COUNT(RegistrationId) FROM MOI_TEM_RESULT_WRONG WHERE RegistrationId= " & GridKJB.GetRow.Cells("RegistrationId").Value) > 0 Then

    End Function
    Function IsExist2(ByVal RegisID As Double) As Int16
        Return (GenDAOStatisic.SelectAsScalar("SELECT COUNT(*) FROM MOI_TEM_RESULT_WRONG WHERE RegistrationId= " & RegisID))
    End Function

    Private Function SQLSearchMOI(ByVal ChIDNo As Boolean, ByVal ChFamily As Boolean, ByVal ChName As Boolean, ByVal chProvince As Boolean, ByVal ChSex As Boolean, ByVal chDOB As Boolean, ByVal ValIDNo As String, ByVal ValFamilyName As String, ByVal ValName As String, ByVal ValSex As String, ByVal ValDbo As Date, ByVal Province As String) As String
        Dim SQL As String = "SELECT AFISID,DOCUMENTNO,SURNAME_KHMER,GIVENNAME_KHMER,GENDER_TEXT,POL_CAPITALPROVINCE_TEXT,POL_SECTIONCITYDISTRICT_TEXT,POL_COMMUNECITYQUARTER_TEXT,DATEOFBIRTH FROM STATISTICT_DATA WHERE STATUS=260 "
        If ChIDNo = True Then
            SQL = SQL & " AND DOCUMENTNO='" & ValIDNo & "'"
        End If

        If ChFamily = True Then
            SQL = SQL & " AND SURNAME_KHMER=N'" & ValFamilyName & "'"
        End If
        If ChName = True Then
            SQL = SQL & " AND GIVENNAME_KHMER=N'" & ValName & "'"
        End If
        If ChSex = True Then
            SQL = SQL & " AND GENDER_TEXT=N'" & ValSex & "'"
        End If
        If chDOB = True Then
            SQL = SQL & " AND DATEOFBIRTH='" & ValDbo & "'"
        End If
        'If chProvince = True Then
        '    SQL = SQL & " AND POL_CAPITALPROVINCE_TEXT=N'" & Province & "'"
        'End If
        Return SQL
    End Function

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        If MessageBox.Show("Do you want to cancel finding?.If you are click yest the record log will delte all.", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            IsScaning = False
            TotalFound = 0
            TotalWrong = 0
            Index = 0
            LblWatching.Text = ""
            'GenDAOStatisic.DeleteDAO("Delete FROM MOI_TEM_RESULT")
            'GenDAOStatisic.DeleteDAO("Delete FROM MOI_TEM_RESULT_WRONG")
            ViewResult()
        End If

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        IsScaning = False
        ViewResult()
    End Sub
    Private Sub ViewResult()
        GridResult.DataSource = GenDAOStatisic.SelectDAOAsDataTatable("SELECT AFISID,DOCUMENTNO,SURNAME_KHMER,GIVENNAME_KHMER,GENDER_TEXT,DATEOFBIRTH,POL_COMMUNECITYQUARTER_TEXT,POL_SECTIONCITYDISTRICT_TEXT,POL_CAPITALPROVINCE_TEXT,ROW_POSITION,RegistrationId,IDNumber,FamilyName,GivenName,ProvinceKh,CommuneKh,Gender,DateOfBirthKJB FROM MOI_TEM_RESULT ORDER BY SURNAME_KHMER,GIVENNAME_KHMER,POL_COMMUNECITYQUARTER_TEXT,POL_SECTIONCITYDISTRICT_TEXT,POL_CAPITALPROVINCE_TEXT")
        GridWrongResult.DataSource = GenDAOStatisic.SelectDAOAsDataTatable("SELECT AFISID,DOCUMENTNO,SURNAME_KHMER,GIVENNAME_KHMER,GENDER_TEXT,DATEOFBIRTH,POL_COMMUNECITYQUARTER_TEXT,POL_SECTIONCITYDISTRICT_TEXT,POL_CAPITALPROVINCE_TEXT,ROW_POSITION,RegistrationId,IDNumber,FamilyName,GivenName,ProvinceKh,CommuneKh,Gender,DateOfBirthKJB FROM MOI_TEM_RESULT_WRONG ORDER BY SURNAME_KHMER,GIVENNAME_KHMER,POL_COMMUNECITYQUARTER_TEXT,POL_SECTIONCITYDISTRICT_TEXT,POL_CAPITALPROVINCE_TEXT")
        'NumberAllRowHeaderDataGrid(GridResult)
        'NumberAllRowHeaderDataGrid(GridWrongResult)
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        ViewResult()
    End Sub



    Private Sub ElectionComparetion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TblProvKJB As DataTable = GenDAOStatisic.SelectDAOAsDataTatable("select distinct  ProvinceKh from Registration order by ProvinceKh")
        With cboProvince
            .DataSource = TblProvKJB
            .DisplayMember = "ProvinceKh"
            .ValueMember = "ProvinceKh"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub ChProvince_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChProvince.CheckedChanged
        cboProvince.Enabled = ChProvince.Checked
        cboProvince.SelectedIndex = -1
        'If ChProvince.Checked = True Then
        '    LoadDataFromKJB()
        'End If

    End Sub


    Dim FViewImg As ViewImg

    Private Sub GridResult_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridResult.RowDoubleClick
        FViewImg = New ViewImg(Me)
        FViewImg.Show()
        Me.GridResult.Focus()
        ViewDetialImg()

    End Sub

    Private Sub GridResult_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridResult.SelectionChanged

        ViewDetialImg()

    End Sub
    Private Sub ViewDetialImg()
        Try
            FViewImg.LblSaveOption.Text = GridResult.GetRow.Cells("AFISID").Value
            FViewImg.TxtRIDCard.Text = GridResult.GetRow.Cells("DOCUMENTNO").Value
            FViewImg.TxtKIDCard.Text = GridResult.GetRow.Cells("IDNumber").Value
            FViewImg.TxtRName.Text = GridResult.GetRow.Cells("SURNAME_KHMER").Value & " " & GridResult.GetRow.Cells("GIVENNAME_KHMER").Value
            FViewImg.TxtKName.Text = GridResult.GetRow.Cells("FamilyName").Value & " " & GridResult.GetRow.Cells("GivenName").Value
            FViewImg.TxtRDOB.Text = Format(GridResult.GetRow.Cells("DATEOFBIRTH").Value, "dd/MM/yyyy")
            FViewImg.TxtKDOB.Text = Format(GridResult.GetRow.Cells("DateOfBirthKJB").Value, "dd/MM/yyyy")

            FViewImg.TxtRSex.Text = GridResult.GetRow.Cells("GENDER_TEXT").Value
            FViewImg.TxtKSex.Text = GridResult.GetRow.Cells("Gender").Value

            FViewImg.PictAtack.Image = ByteArrayToImage(IIf(TypeOf (Me.GetImgAtack(GridResult.GetRow.Cells("AFISID").Value)) Is DBNull, Nothing, Me.GetImgAtack(GridResult.GetRow.Cells("AFISID").Value)))
            FViewImg.TxtRAddress.Text = GridResult.GetRow.Cells("POL_COMMUNECITYQUARTER_TEXT").Value & "," & GridResult.GetRow.Cells("POL_SECTIONCITYDISTRICT_TEXT").Value & "," & GridResult.GetRow.Cells("POL_CAPITALPROVINCE_TEXT").Value
            FViewImg.TxtKAddress.Text = GridResult.GetRow.Cells("CommuneKh").Value & " ," & GridResult.GetRow.Cells("ProvinceKh").Value
        Catch ex As Exception

        End Try

    End Sub
    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Try
            Dim ms As New MemoryStream(byteArrayIn)
            Dim returnImage As Image = Image.FromStream(ms)
            Return returnImage
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
    Private Sub UpdateVisiblePicLoading(ByVal v As Boolean)
        Application.DoEvents()
        PictureBox2.Visible = v
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

    Private Delegate Sub DelShowLabelStatus(ByVal txt As String, ByVal v As Boolean)
    Private Delegate Sub DelegatePicture(ByVal v As Boolean)
    Private Delegate Sub DelegateLoadingData()
    Public Sub CreateDelgateData()
        If Me.Created Then
            Me.Invoke(New DelegateLoadingData(AddressOf LoadingReport), New Object() {})
        End If
    End Sub
    Dim DS As New DataSet
    Dim dt As New DataTable
    Dim cnn As New SqlClient.SqlConnection(My.Settings.DBCnnStatistic)
    Sub LoadingReport()

        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingReport))
        Else

            Application.DoEvents()

            For Each foundFile As String In My.Computer.FileSystem.GetFiles(Application.StartupPath & "\Temp", FileIO.SearchOption.SearchAllSubDirectories, "*.*")
                My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Next
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            Dim Sql As String = "SELECT * FROM MOI_TEM_RESULT"



            Try



                Application.DoEvents()


                Dim da = New SqlDataAdapter()
                Dim cmd As SqlCommand = cnn.CreateCommand()
                cmd.CommandTimeout = 50000
                cmd.CommandText = Sql
                da.SelectCommand = cmd
                If cnn.State = ConnectionState.Closed Then
                    cnn.Open()
                End If



                da.Fill(DS, "MOI_TEM_RESULT")

                'da.Fill(ds);
                cnn.Close()



                Application.DoEvents()
                Dim RptName As String = Application.StartupPath & "\KGBStatistic.rpt"


                myReport.ReportPath(RptName)
                Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                myReport.SetDataSource(DS, "MOI_TEM_RESULT")
                myReport.DiscardSavedData()
                'myReport.SetParameterValue("Province", ShowProvince) 'cboPROVINCE.Text & " " & cboDISTRICT.Text & " " & cboCOMMUNE.Text & " " & cboVILLAGE.Text & vbCrLf & " ចាប់ពីថ្ងែ: " & Format(DFrom.Value, "dd-MM-yyyy") & " រហូតដល់: " & Format(DTo.Value, "dd-MM-yyyy"))
                'myReport.SetParameterValue("ShowDis", ShowDis)
                'myReport.SetParameterValue("ShowCom", ShowCom)
                'myReport.SetParameterValue("ShowVillage", ShowVill)
                cnn.Close()
                DS.Dispose()
                da.SelectCommand.Connection.Close()
                da.SelectCommand.Dispose()
              

            Catch ex As Exception
                MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

    End Sub

    Private Sub BgLoadingReport_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadingReport.DoWork
        CreateDelgateData()
    End Sub

    Private Sub BtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReport.Click
        UpdateVisiblePicLoading(True)

        System.Threading.Thread.Sleep(100)
        Application.DoEvents()
        BgLoadingReport.RunWorkerAsync()
    End Sub
End Class
