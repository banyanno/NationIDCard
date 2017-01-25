Imports System.IO
Imports System.Data.SqlClient

Public Class SearchPeople
    Dim DAPoepleSearch As New DSIDVerificationTableAdapters.VIEW_PEOPLE_VERIFICATIONTableAdapter
    Dim DAProvince As New DSIDVerificationTableAdapters.TBL_PROVINCETableAdapter
    Dim DADistrict As New DSIDVerificationTableAdapters.TBL_DISTRICTTableAdapter
    Dim DACommune As New DSIDVerificationTableAdapters.TBL_COMMUNETableAdapter
    Dim DAVillage As New DSIDVerificationTableAdapters.TBL_VILLAGETableAdapter

    Dim TblPeopleSearch As DataTable
    Dim TblProvince As DataTable = DAProvince.GetData
    Dim TblDistrict As DataTable
    Dim TblCommune As DataTable
    Dim TblVillage As DataTable
    Dim FVerification As New FormVericationData
    Dim Mform As MainApplicationForm
    Sub New(ByVal Mform As MainApplicationForm)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.Mform = Mform
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TblResultSearch As DataTable = DAPoepleSearch.SelectByLatinName(TxtSFirstLatinName.Text)
        GridPeopleValiate.DataSource = TblResultSearch
        'Dim FVerication As New FormVericationData
        'FVerication.ShowDialog()
    End Sub

  

    Private Sub GridPeopleValiate_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPeopleValiate.SelectionChanged


        Try
            PicValuce.Image = ByteArrayToImage(IIf(TypeOf (ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("old_id").Value, "photo")) Is DBNull, Nothing, ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("old_id").Value, "photo")))
            'PicValuce.Image = ByteArrayToImage(IIf(TypeOf (GridPeopleValiate.GetRow.Cells("photo").Value) Is DBNull, Nothing, GridPeopleValiate.GetRow.Cells("photo").Value))
        Catch ex As Exception
            PicValuce.Image = Nothing
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

   

   

 

    Private Sub GridPeopleValiate_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPeopleValiate.RowDoubleClick
        ViewCompare()
    End Sub

    Sub ViewCompare()
        If GridPeopleValiate.SelectedItems.Count = 0 Then Exit Sub
        Dim ID As Long = CLng(IIf(TypeOf (GridPeopleValiate.GetRow.Cells("afisid").Value) Is DBNull, 0, GridPeopleValiate.GetRow.Cells("afisid").Value))
        Dim textdocno As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("documentno").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("documentno").Value)
        Dim textbarcodeno As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("barcodeno").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("barcodeno").Value)
        Dim name1 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("KhmerName").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("KhmerName").Value)
        Dim latin As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("LatinName").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("LatinName").Value)
        Dim dob1 As String = GridPeopleValiate.GetRow.Cells("dateofbirth").Text
        Dim sex1 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("sex").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("sex").Value)
        Dim enrolldate1 As String = GridPeopleValiate.GetRow.Cells("date_of_registration").Text
        Dim village As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("pobvillage").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("pobvillage").Value)
        Dim commune As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("pobcommune").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("pobcommune").Value)
        Dim district As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("pobdistrict").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("pobdistrict").Value)
        Dim province As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("pobprovince").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("pobprovince").Value)
        Dim polvillage As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("polvillage").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("polvillage").Value)
        Dim polcommune As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("polcommune").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("polcommune").Value)
        Dim poldistrict As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("poldistrict").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("poldistrict").Value)
        Dim polprovince As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("polprovince").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("polprovince").Value)
        Dim pictureBox1 As Image = ByteArrayToImage(IIf(TypeOf (ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("afisid").Value, "photo")) Is DBNull, Nothing, ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("afisid").Value, "photo")))
        Dim regisform1 As Image = ByteArrayToImage(IIf(TypeOf (ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("afisid").Value, "registrationform")) Is DBNull, Nothing, ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("afisid").Value, "registrationform")))

        'Verification Form

        Dim name2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerSurnameKhmer").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerSurnameKhmer").Value) & " " & IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerGiveNamekhmer").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerGiveNamekhmer").Value)
        Dim latin2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerSurnameLatin").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerSurnameLatin").Value) & " " & IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerGiveNameLatin").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerGiveNameLatin").Value)
        Dim dob2 As String = GridPeopleValiate.GetRow.Cells("VerDateOfBirth").Text
        Dim sex2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerSex").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerSex").Value)
        Dim enrolldate2 As String = GridPeopleValiate.GetRow.Cells("VerDateOfRegistration").Text
        Dim village2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerPobVillage").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerPobVillage").Value)
        Dim commune2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerPobCommune").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerPobCommune").Value)
        Dim district2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerDistrict").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerDistrict").Value)
        Dim province2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerPobProvince").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerPobProvince").Value)
        Dim polVillage2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerPolCommune").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerPolCommune").Value)
        Dim polcommune2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerPolCommune").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerPolCommune").Value)
        Dim poldistrict2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerPolDistrict").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerPolDistrict").Value)
        Dim polprovince2 As String = IIf(TypeOf (GridPeopleValiate.GetRow.Cells("VerPolProvince").Value) Is DBNull, "", GridPeopleValiate.GetRow.Cells("VerPolProvince").Value)

        'Dim pictureBox2 As Image = ByteArrayToImage(IIf(TypeOf (ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("afisid").Value, "VerPhoto")) Is DBNull, Nothing, ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("afisid").Value, "VerPhoto")))

        'Dim regisform2 As Image = ByteArrayToImage(IIf(TypeOf (ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("afisid").Value, "VerRegistrationform")) Is DBNull, Nothing, ModuleIDCard.GetImpage(GridPeopleValiate.GetRow.Cells("afisid").Value, "VerRegistrationform")))

        'FVerification.ViewVerification(ID, textdocno, textbarcodeno, name1, latin, dob1, sex1, enrolldate1, village, commune, village, province, polvillage, polcommune, poldistrict, polprovince, pictureBox1, regisform1, _
        '                                name2, latin2, dob2, sex2, enrolldate2, village2, commune2, district2, province2, polVillage2, polcommune2, poldistrict2, polprovince2, pictureBox2, regisform2)
        FVerification.DataTablePeople = TblPeopleSearch
        FVerification.MaxRows = FVerification.DataTablePeople.Rows.Count

        FVerification.ReIndex = GridPeopleValiate.GetRow.RowIndex
        FVerification.EnableButton = FVerification.BtnFirst
        FVerification.LblTotal.Text = FVerification.DataTablePeople.Rows.Count
        FVerification.NavegationRecord()
        FVerification.ShowDialog()

    End Sub
    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If Not BgPayment.IsBusy Then
            Me.Cursor = Cursors.WaitCursor
            BgPayment.RunWorkerAsync()
            BtnFind.Text = "Cancel"
        Else
            BgPayment.CancelAsync()
        End If


       
        
    End Sub
    Private Sub FindingPeople()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf FindingPeople))
        Else
            'Dim SqlCmd As New SqlCommand
            'Dim SQLAdap As New SqlDataAdapter
            'Dim DSPeople As New DSIDVerification
            Mform.container1.Visible = True
            'Application.DoEvents()
            'SqlCmd.CommandText = SearchPeopl(txtDocCode.Text.Trim, "", "", _
            '                                 cboPROVINCE.Text, cboDISTRICT.Text, cboCOMMUNE.Text, cboVILLAGE.Text, _
            '                                 Ch1.Checked, Ch2.Checked, Ch3.Checked, Ch4.Checked, Ch5.Checked, Ch6.Checked, DFrom.Value.Date, DTo.Value.Date, cboSex.Text, Ch7.Checked, _
            '                                 txtBarcode.Text.Trim, TxtFirstKhName.Text.Trim, TxtKhLastName.Text.Trim, TxtSFirstLatinName.Text.Trim, TxtLastLatin.Text.Trim)
            'SqlCmd.Connection = DAPoepleSearch.Connection
            'SQLAdap.SelectCommand = SqlCmd
            'SQLAdap.Fill(DSPeople.VIEW_PEOPLE_VERIFICATION)
            Dim SQL = SearchPeopl(txtDocCode.Text.Trim, "", "", _
                                             cboPROVINCE.Text, cboDISTRICT.Text, cboCOMMUNE.Text, cboVILLAGE.Text, _
                                             Ch1.Checked, Ch2.Checked, Ch3.Checked, Ch4.Checked, Ch5.Checked, Ch6.Checked, DFrom.Value.Date, DTo.Value.Date, cboSex.Text, Ch7.Checked, _
                                             txtBarcode.Text.Trim, TxtFirstKhName.Text.Trim, TxtKhLastName.Text.Trim, TxtSFirstLatinName.Text.Trim, TxtLastLatin.Text.Trim)
            TblPeopleSearch = GetInformationIDCard(SQL) 'mDSPeople.VIEW_PEOPLE_VERIFICATION

        End If
    End Sub
    
    Private Function SearchPeopl(ByVal DocumentCod As String, ByVal NameKhmer As String, ByVal NameLatin As String, _
                                 ByVal Province As String, ByVal District As String, ByVal Commune As String, _
                                 ByVal Village As String, ByVal WrongNameKh As Boolean, _
                                 ByVal WrongNameLatin As Boolean, ByVal WrongDOB As Boolean, ByVal WrongSex As Boolean, _
                                 ByVal WrongPOB As Boolean, ByVal WrongAddress As Boolean, ByVal dateFrom As Date, ByVal dateTo As Date, _
                                 ByVal Sex As String, ByVal CorrectAll As Boolean, _
                                 ByVal VerBarcode As String, ByVal VerSurnameKhmer As String, ByVal VerGiveNamekhmer As String, ByVal VerSurnameLatin As String, ByVal VerGiveNameLatin As String) As String
        Dim sql As String = "SELECT * FROM VIEW_PEOPLE_VERIFICATION WHERE (documentno is not null) AND (OLD_ID IS NOT NULL) AND (VerDateOfRegistration between '" & dateFrom & "' and '" & dateTo & "')"
        If Sex <> "" Then
            sql = sql & " AND VerSex=N'" & Sex & "'"
        End If
        If DocumentCod <> "" Then
            sql = sql & " AND old_id='" & DocumentCod & "'"
        End If
        If VerBarcode <> "" Then
            sql = sql & " AND VerBarcode= '" & VerBarcode & "'"
        End If
        If VerSurnameKhmer <> "" Then
            sql = sql & " AND upper(VerSurnameKhmer) LIKE N'%" & VerSurnameKhmer & "%'"
        End If
        If VerGiveNamekhmer <> "" Then
            sql = sql & " AND UPPER(VerGiveNamekhmer) LIKE N'%" & VerGiveNamekhmer & "%'"
        End If
        If VerSurnameLatin <> "" Then
            sql = sql & " AND UPPER(VerSurnameLatin) LIKE N'%" & VerSurnameLatin & "%'"
        End If
        If VerGiveNameLatin <> "" Then
            sql = sql & " AND UPPER(VerGiveNameLatin) LIKE N'%" & VerGiveNameLatin & "%'"
        End If
        'If NameKhmer.Trim <> "" Then
        '    sql = sql & " AND UPPER(VerifKhmerName) LIKE N'%" & NameKhmer & "%'"
        'End If
        'If NameLatin <> "" Then
        '    sql = sql & " AND UPPER(VerifLatinName) LIKE '%" & NameLatin & "%'"
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
        If WrongNameKh = True Then
            sql = sql & " AND VerSurnameKhmer<>surname_khmer AND VerSurnameKhmer<>givenname_khmer"
        End If
        If WrongNameLatin = True Then
            sql = sql & " AND VerSurnameLatin<>surname_latin AND VerGiveNameLatin<>givenname_latin"
        End If
        If WrongDOB = True Then
            sql = sql & " AND VerDateOfBirth<>dateofbirth"
        End If
        If WrongSex = True Then
            sql = sql & " AND VerSex<>sex"
        End If
        If WrongPOB = True Then
            sql = sql & " AND VerPobVillage<>pobvillage AND VerPobCommune<>pobcommune AND VerDistrict<>pobdistrict AND VerPobProvince<>pobprovince"
        End If
        If WrongAddress = True Then
            sql = sql & " AND VerPolVillage<>polvillage AND VerPolCommune<>polcommune AND VerPolDistrict<>poldistrict AND VerPolProvince<>polprovince"
        End If
        If CorrectAll = True Then
            sql = sql & " AND VerSurnameKhmer=surname_khmer AND VerSurnameKhmer=givenname_khmer " & _
             " AND VerSurnameLatin=surname_latin AND VerGiveNameLatin=givenname_latin " & _
             " AND VerDateOfBirth=dateofbirth  " & _
             " AND VerSex=sex " & _
             " AND VerPobVillage=pobvillage  AND VerPobCommune=pobcommune AND VerDistrict=pobdistrict AND VerPobProvince=pobprovince" & _
            " AND VerPolVillage=polvillage AND VerPolCommune=polcommune AND VerPolDistrict=poldistrict AND VerPolProvince=polprovince"
        End If
        Return sql & " ORDER BY old_id"
    End Function

   
    Private Sub Ch7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch7.CheckedChanged
        If Ch7.Checked = True Then
            Ch1.Checked = False
            Ch2.Checked = False
            Ch3.Checked = False
            Ch4.Checked = False
            Ch5.Checked = False
            Ch6.Checked = False
        
        End If
        

    End Sub

    Private Sub Ch1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch1.CheckedChanged
        Ch7.Checked = False
    End Sub

    Private Sub Ch2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch2.CheckedChanged
        Ch7.Checked = False
    End Sub

    Private Sub Ch3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch3.CheckedChanged
        Ch7.Checked = False
    End Sub

    Private Sub Ch4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch4.CheckedChanged
        Ch7.Checked = False
    End Sub

    Private Sub Ch5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch5.CheckedChanged
        Ch7.Checked = False
    End Sub

    Private Sub Ch6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ch6.CheckedChanged
        Ch7.Checked = False
    End Sub

    Private Sub BgPayment_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgPayment.DoWork
        FindingPeople()
    End Sub
    Private Sub BgPayment_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgPayment.RunWorkerCompleted
        Me.Cursor = Cursors.Arrow
        Application.DoEvents()
        If e.Cancelled Then
            MessageBox.Show("Operation was canceled")
        ElseIf e.[Error] IsNot Nothing Then
            MessageBox.Show(e.[Error].Message)
        End If
        GridPeopleValiate.DataSource = TblPeopleSearch
        BtnFind.Text = "ស្វែង រក"
        Mform.container1.Visible = False
    End Sub
    
    Dim generalDAO As New GeneralDAO
   
   
    Private Sub btnCompare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompare.Click
        ViewCompare()
    End Sub

    Private Sub BtnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintReport.Click
        Try
          
            Dim sql As String = "select * from VIEW_PEOPLE_VERIFICATIONForImage where VerPolProvince=N'" & cboPROVINCE.Text & "'"
            Dim TPeopleBook As DataTable = generalDAO.SelectAsDataTable(sql)
            Dim CRVerificationBook As New CRVVerificationvBook
            CRVerificationBook.SetDataSource(TPeopleBook)
            Dim FReportViewer As New ReportViewer
            FReportViewer.CrystalReportViewer1.ReportSource = CRVerificationBook
            FReportViewer.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub cboPROVINCE_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPROVINCE.SelectionChangeCommitted
        Try
            TblDistrict = DADistrict.SelectByProvinceID(cboPROVINCE.SelectedValue)
            cboDISTRICT.DataSource = TblDistrict
            cboDISTRICT.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboDISTRICT_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDISTRICT.SelectionChangeCommitted
        Try
            TblCommune = DACommune.SelectByDISTRICTID(cboDISTRICT.SelectedValue)
            cboCOMMUNE.DataSource = TblCommune
            cboCOMMUNE.SelectedIndex = -1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboCOMMUNE_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCOMMUNE.SelectionChangeCommitted
        Try
            TblVillage = DAVillage.SelectByCOMMUNEID(cboCOMMUNE.SelectedValue)
            cboVILLAGE.DataSource = TblVillage
            cboVILLAGE.SelectedIndex = -1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchPeople_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
