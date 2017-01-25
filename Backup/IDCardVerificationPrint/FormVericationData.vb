Imports CrystalDecisions.Shared
Imports System.IO

Public Class FormVericationData
    Public DA_PeopleVerification As New DSIDVerificationTableAdapters.VIEW_PEOPLE_VERIFICATIONTableAdapter
    Public DataTablePeople As DataTable
    Dim DAVerification As New DSIDVerificationTableAdapters.tbl_verificationTableAdapter
    Public ReIndex As Long
    Public MaxRows As Long
    Public EnableButton As ToolStripButton
    Public Sub ViewVerification(ByVal ID As Double, ByVal DocumentNo As String, ByVal BarcodNo As String, ByVal NameKH1 As String, ByVal NameLatin1 As String, ByVal DateOB1 As String, _
                                ByVal Sex1 As String, ByVal DateRegis1 As String, ByVal Village1 As String, _
                                ByVal Commune1 As String, ByVal District1 As String, ByVal Province1 As String, _
                                ByVal CuVillage1 As String, ByVal CuCommune1 As String, ByVal CuDistrict1 As String, _
                                ByVal CuProvince1 As String, ByVal Pic1 As Image, ByVal PicSign1 As Image, _
                                ByVal NameKH2 As String, ByVal NameLatin2 As String, ByVal DateOB2 As String, _
                                ByVal Sex2 As String, ByVal DateRegis2 As String, ByVal Village2 As String, _
                                ByVal Commune2 As String, ByVal District2 As String, ByVal Province2 As String, _
                                ByVal CuVillage2 As String, ByVal CuCommune2 As String, ByVal CuDistrict2 As String, ByVal CuProvince2 As String, ByVal Pic2 As Image, ByVal PicSign2 As Image)
        LblIDPrintOut.Text = ID
        Me.textdocno.Text = DocumentNo
        Me.textbarcodeno.Text = BarcodNo
        name1.Text = NameKH1
        latin1.Text = NameLatin1
        dob1.Text = DateOB1
        Me.sex1.Text = Sex1
        Me.enrolldate1.Text = DateRegis1
        village.Text = Village1
        commune.Text = Commune1
        district.Text = District1
        province.Text = Province1
        polvillage.Text = CuVillage1
        polcommune.Text = CuCommune1
        poldistrict.Text = CuDistrict1
        polprovince.Text = CuProvince1
        pict1.Image = Pic1
        regisform1.Image = PicSign1

        'Verification Form

        name2.Text = NameKH2
        If name2.Text <> name1.Text Then
            name2.ForeColor = Color.Red
            Ch1.Checked = True
        Else
            name2.ForeColor = Color.Black
            Ch1.Checked = False
        End If

        latin2.Text = NameLatin2
        If latin2.Text <> latin1.Text Then
            latin2.ForeColor = Color.Red
            Ch2.Checked = True
        Else
            latin2.ForeColor = Color.Black
            Ch2.Checked = False
        End If
        dob2.Text = DateOB2
        If dob2.Text <> dob1.Text Then
            dob2.ForeColor = Color.Red
            Ch3.Checked = True
        Else
            dob2.ForeColor = Color.Black
            Ch3.Checked = False
        End If
        Me.sex2.Text = Sex2
        If Me.sex2.Text <> Me.sex1.Text Then
            Me.sex2.ForeColor = Color.Red
            Ch4.Checked = True
        Else
            Me.sex2.ForeColor = Color.Black
            Ch4.Checked = False
        End If
        Me.enrolldate2.Text = DateRegis2
        If Me.enrolldate2.Text <> Me.enrolldate1.Text Then
            Me.enrolldate2.ForeColor = Color.Red
            Ch5.Checked = True
        Else
            Me.enrolldate2.ForeColor = Color.Black
            Ch5.Checked = False
        End If
        Me.village2.Text = Village2
        If Me.village2.Text <> Me.village.Text Then
            Me.village2.ForeColor = Color.Red
            Ch5.Checked = True
        Else
            Me.village2.ForeColor = Color.Black
            Ch5.Checked = False
        End If
        Me.commune2.Text = Commune2
        If Me.commune2.Text <> Me.commune.Text Then
            Me.commune2.ForeColor = Color.Red
            Ch5.Checked = True
        Else
            Me.commune2.ForeColor = Color.Black
            Ch5.Checked = False
        End If
        Me.district2.Text = District2
        If Me.district2.Text <> Me.district.Text Then
            Me.district2.ForeColor = Color.Red
            Ch5.Checked = True
        Else
            Me.district2.ForeColor = Color.Black
            Ch5.Checked = False

        End If
        Me.province2.Text = Province2
        If Me.province2.Text <> Me.province.Text Then
            Me.province2.ForeColor = Color.Red
            Ch5.Checked = True
        Else
            Me.province2.ForeColor = Color.Black
            Ch5.Checked = False
        End If
        Me.polvillage2.Text = CuVillage2
        If Me.polvillage2.Text <> Me.polvillage.Text Then
            Me.polvillage2.ForeColor = Color.Red
            Ch6.Checked = True
        Else
            Me.polvillage2.ForeColor = Color.Black
            Ch6.Checked = False
        End If
        Me.polcommune2.Text = CuCommune2
        If Me.polcommune2.Text <> Me.polcommune.Text Then
            Me.polcommune2.ForeColor = Color.Red
            Ch6.Checked = True
        Else
            Me.polcommune2.ForeColor = Color.Black
            Ch6.Checked = False
        End If
        Me.poldistrict2.Text = CuDistrict2
        If Me.poldistrict2.Text <> Me.poldistrict.Text Then
            Me.poldistrict2.ForeColor = Color.Red
            Ch6.Checked = True
        Else
            Me.poldistrict2.ForeColor = Color.Black
            Ch6.Checked = False
        End If
        Me.polprovince2.Text = CuProvince2
        If Me.polprovince2.Text <> Me.polprovince.Text Then
            Me.polprovince2.ForeColor = Color.Red
            Ch6.Checked = True
        Else
            Me.polprovince2.ForeColor = Color.Black
            Ch6.Checked = False
        End If
        Me.pict2.Image = Pic2
        Me.regisform2.Image = PicSign2
        If Ch1.Checked = False And Ch2.Checked = False And Ch3.Checked = False And Ch4.Checked = False And Ch5.Checked = False And Ch6.Checked = False Then
            Ch7.Checked = True
        Else
            Ch7.Checked = False
        End If
        'Change Color Verivication


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
    Public Sub PreviousRecord()
        Try
            Me.LblIDPrintOut.Text = DataTablePeople.Rows(ReIndex).Item("afisid")
            Me.textdocno.Text = DataTablePeople.Rows(ReIndex).Item("documentno")
            Me.textbarcodeno.Text = DataTablePeople.Rows(ReIndex).Item("barcodeno")
            name1.Text = DataTablePeople.Rows(ReIndex).Item("KhmerName")
            latin1.Text = DataTablePeople.Rows(ReIndex).Item("LatinName")
            dob1.Text = DataTablePeople.Rows(ReIndex).Item("dateofbirth")
            Me.sex1.Text = DataTablePeople.Rows(ReIndex).Item("sex")
            Me.enrolldate1.Text = DataTablePeople.Rows(ReIndex).Item("date_of_registration")
            village.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("pobvillage")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("pobvillage"))
            commune.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("pobcommune")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("pobcommune"))
            district.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("pobdistrict")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("pobdistrict"))
            province.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("pobprovince")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("pobprovince"))
            polvillage.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("polvillage")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("polvillage"))
            polcommune.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("polcommune")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("polcommune"))
            poldistrict.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("poldistrict")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("poldistrict"))
            polprovince.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("polprovince")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("polprovince"))
            pict1.Image = ByteArrayToImage(IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("photo")) Is DBNull, Nothing, DataTablePeople.Rows(ReIndex).Item("photo")))
            regisform1.Image = ByteArrayToImage(IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("registrationform")) Is DBNull, Nothing, DataTablePeople.Rows(ReIndex).Item("registrationform")))

            'Verification Form

            name2.Text = DataTablePeople.Rows(ReIndex).Item("VerSurnameKhmer") & " " & DataTablePeople.Rows(ReIndex).Item("VerGiveNamekhmer")
            If name2.Text <> name1.Text Then
                name2.ForeColor = Color.Red
                Ch1.Checked = True
            Else
                name2.ForeColor = Color.Black
                Ch1.Checked = False
            End If

            latin2.Text = DataTablePeople.Rows(ReIndex).Item("VerSurnameLatin") & " " & DataTablePeople.Rows(ReIndex).Item("VerGiveNameLatin")
            If latin2.Text <> latin1.Text Then
                latin2.ForeColor = Color.Red
                Ch2.Checked = True
            Else
                latin2.ForeColor = Color.Black
                Ch2.Checked = False
            End If
            dob2.Text = DataTablePeople.Rows(ReIndex).Item("VerDateOfBirth")
            If dob2.Text <> dob1.Text Then
                dob2.ForeColor = Color.Red
                Ch3.Checked = True
            Else
                dob2.ForeColor = Color.Black
                Ch3.Checked = False
            End If
            Me.sex2.Text = DataTablePeople.Rows(ReIndex).Item("VerSex")
            If Me.sex2.Text <> Me.sex1.Text Then
                Me.sex2.ForeColor = Color.Red
                Ch4.Checked = True
            Else
                Me.sex2.ForeColor = Color.Black
                Ch4.Checked = False
            End If
            Me.enrolldate2.Text = DataTablePeople.Rows(ReIndex).Item("VerDateOfRegistration")
            If Me.enrolldate2.Text <> Me.enrolldate1.Text Then
                Me.enrolldate2.ForeColor = Color.Red
                Ch5.Checked = True
            Else
                Me.enrolldate2.ForeColor = Color.Black
                Ch5.Checked = False
            End If
            Me.village2.Text = DataTablePeople.Rows(ReIndex).Item("VerPobVillage")
            If Me.village2.Text <> Me.village.Text Then
                Me.village2.ForeColor = Color.Red
                Ch5.Checked = True
            Else
                Me.village2.ForeColor = Color.Black
                Ch5.Checked = False
            End If
            Me.commune2.Text = DataTablePeople.Rows(ReIndex).Item("VerPobCommune")
            If Me.commune2.Text <> Me.commune.Text Then
                Me.commune2.ForeColor = Color.Red
                Ch5.Checked = True
            Else
                Me.commune2.ForeColor = Color.Black
                Ch5.Checked = False
            End If
            Me.district2.Text = DataTablePeople.Rows(ReIndex).Item("VerDistrict")
            If Me.district2.Text <> Me.district.Text Then
                Me.district2.ForeColor = Color.Red
                Ch5.Checked = True
            Else
                Me.district2.ForeColor = Color.Black
                Ch5.Checked = False

            End If
            Me.province2.Text = DataTablePeople.Rows(ReIndex).Item("VerPobProvince")
            If Me.province2.Text <> Me.province.Text Then
                Me.province2.ForeColor = Color.Red
                Ch5.Checked = True
            Else
                Me.province2.ForeColor = Color.Black
                Ch5.Checked = False
            End If
            Me.polvillage2.Text = DataTablePeople.Rows(ReIndex).Item("VerPolVillage")
            If Me.polvillage2.Text <> Me.polvillage.Text Then
                Me.polvillage2.ForeColor = Color.Red
                Ch6.Checked = True
            Else
                Me.polvillage2.ForeColor = Color.Black
                Ch6.Checked = False
            End If
            Me.polcommune2.Text = DataTablePeople.Rows(ReIndex).Item("VerPolCommune")
            If Me.polcommune2.Text <> Me.polcommune.Text Then
                Me.polcommune2.ForeColor = Color.Red
                Ch6.Checked = True
            Else
                Me.polcommune2.ForeColor = Color.Black
                Ch6.Checked = False
            End If
            Me.poldistrict2.Text = DataTablePeople.Rows(ReIndex).Item("VerPolDistrict")
            If Me.poldistrict2.Text <> Me.poldistrict.Text Then
                Me.poldistrict2.ForeColor = Color.Red
                Ch6.Checked = True
            Else
                Me.poldistrict2.ForeColor = Color.Black
                Ch6.Checked = False
            End If
            Me.polprovince2.Text = DataTablePeople.Rows(ReIndex).Item("VerPolProvince")
            If Me.polprovince2.Text <> Me.polprovince.Text Then
                Me.polprovince2.ForeColor = Color.Red
                Ch6.Checked = True
            Else
                Me.polprovince2.ForeColor = Color.Black
                Ch6.Checked = False
            End If
            Me.pict2.Image = ByteArrayToImage(DataTablePeople.Rows(ReIndex).Item("VerPhoto"))
            Me.regisform2.Image = ByteArrayToImage(DataTablePeople.Rows(ReIndex).Item("VerRegistrationform"))
            ReIndex -= 1
            If Ch1.Checked = False And Ch2.Checked = False And Ch3.Checked = False And Ch4.Checked = False And Ch5.Checked = False And Ch6.Checked = False Then
                Ch7.Checked = True
            Else
                Ch7.Checked = False
            End If
        Catch ex As Exception
            ReIndex = 0
            'MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub NavegationRecord()


        Application.DoEvents()
        Me.LblIDPrintOut.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("afisid")) Is DBNull, "0", DataTablePeople.Rows(ReIndex).Item("afisid"))
        Me.textdocno.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("documentno")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("documentno"))
        Me.textbarcodeno.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("barcodeno")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("barcodeno"))
        name1.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("KhmerName")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("KhmerName"))
        latin1.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("LatinName")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("LatinName"))
        dob1.Text = CDate(IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("dateofbirth")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("dateofbirth"))).ToString("dd/MM/yyyy")
        Me.sex1.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("sex")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("sex"))
        Me.enrolldate1.Text = CDate(IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("date_of_registration")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("date_of_registration"))).ToString("dd/MM/yyyy")
        village.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("pobvillage")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("pobvillage"))
        commune.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("pobcommune")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("pobcommune"))
        district.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("pobdistrict")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("pobdistrict"))
        province.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("pobprovince")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("pobprovince"))
        polvillage.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("polvillage")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("polvillage"))
        polcommune.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("polcommune")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("polcommune"))
        poldistrict.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("poldistrict")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("poldistrict"))
        polprovince.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("polprovince")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("polprovince"))
        TxtVertBarcode.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerBarcode")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerBarcode"))


        'Verification Form

        name2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerSurnameKhmer")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerSurnameKhmer")) & " " & IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerGiveNamekhmer")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerGiveNamekhmer"))
        Dim IS_CHECK_1 As Boolean = False
        If name2.Text <> name1.Text Then
            name2.ForeColor = Color.Red
            IS_CHECK_1 = True
            'Ch1.Checked = True
        Else
            name2.ForeColor = Color.Black
            ' Ch1.Checked = False
        End If
        Ch1.Checked = IS_CHECK_1
        latin2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerSurnameLatin")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerSurnameLatin")) & " " & IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerGiveNameLatin")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerGiveNameLatin"))
        Dim IS_CHECH_2 As Boolean = False
        If latin2.Text <> latin1.Text Then
            latin2.ForeColor = Color.Red
            IS_CHECH_2 = True
            'Ch2.Checked = True
        Else
            latin2.ForeColor = Color.Black
            'Ch2.Checked = False
        End If
        Ch2.Checked = IS_CHECH_2

        dob2.Text = CDate(IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerDateOfBirth")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerDateOfBirth"))).ToString("dd/MM/yyyy")
        Dim IS_CHECK_3 As Boolean = False
        If dob2.Text.Trim <> dob1.Text.Trim Then
            dob2.ForeColor = Color.Red
            IS_CHECK_3 = True
            ' Ch3.Checked = True
        Else
            dob2.ForeColor = Color.Black
            'Ch3.Checked = False
        End If
        Ch3.Checked = IS_CHECK_3
        Me.sex2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerSex")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerSex"))
        Dim IS_CHECK_4 As Boolean = False
        If Me.sex2.Text.Trim <> Me.sex1.Text.Trim Then
            Me.sex2.ForeColor = Color.Red
            IS_CHECK_4 = True
            'Ch4.Checked = True
        Else
            Me.sex2.ForeColor = Color.Black
            'Ch4.Checked = False
        End If
        Ch4.Checked = IS_CHECK_4
        Me.enrolldate2.Text = CDate(IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerDateOfRegistration")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerDateOfRegistration"))).ToString("dd/MM/yyyy")
        If Me.enrolldate2.Text <> Me.enrolldate1.Text Then
            Me.enrolldate2.ForeColor = Color.Red
            'Ch5.Checked = True
        Else
            Me.enrolldate2.ForeColor = Color.Black
            'Ch5.Checked = False
        End If
        Me.village2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerPobVillage")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerPobVillage"))
        Me.commune2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerPobCommune")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerPobCommune"))
        Me.district2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerDistrict")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerDistrict"))
        Me.province2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerPobProvince")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerPobProvince"))
        Dim IS_CHECK_5 As Boolean = False
        If Me.village2.Text <> Me.village.Text Then
            Me.village2.ForeColor = Color.Red
            IS_CHECK_5 = True
            'Ch5.Checked = True
        Else
            Me.village2.ForeColor = Color.Black
            ' Ch5.Checked = False
        End If

        If Me.commune2.Text <> Me.commune.Text Then
            Me.commune2.ForeColor = Color.Red
            IS_CHECK_5 = True
            'Ch5.Checked = True
        Else
            Me.commune2.ForeColor = Color.Black
            'Ch5.Checked = False
        End If

        If Me.district2.Text <> Me.district.Text Then
            Me.district2.ForeColor = Color.Red
            IS_CHECK_5 = True
            'Ch5.Checked = True
        Else
            Me.district2.ForeColor = Color.Black
            'Ch5.Checked = False

        End If

        If Me.province2.Text <> Me.province.Text Then
            Me.province2.ForeColor = Color.Red
            IS_CHECK_5 = True
            'Ch5.Checked = True
        Else
            Me.province2.ForeColor = Color.Black
            'Ch5.Checked = False
        End If
        Ch5.Checked = IS_CHECK_5
        Me.polvillage2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerPolVillage")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerPolVillage"))
        Me.polcommune2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerPolCommune")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerPolCommune"))
        Me.poldistrict2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerPolDistrict")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerPolDistrict"))
        Me.polprovince2.Text = IIf(TypeOf (DataTablePeople.Rows(ReIndex).Item("VerPolProvince")) Is DBNull, "", DataTablePeople.Rows(ReIndex).Item("VerPolProvince"))
        Dim IS_CHECK6 As Boolean = False
        If Me.polvillage2.Text <> Me.polvillage.Text Then
            Me.polvillage2.ForeColor = Color.Red
            IS_CHECK6 = True
            ' Ch6.Checked = True
        Else
            Me.polvillage2.ForeColor = Color.Black
            'Ch6.Checked = False
        End If
        If Me.polcommune2.Text <> Me.polcommune.Text Then
            Me.polcommune2.ForeColor = Color.Red
            IS_CHECK6 = True
            'Ch6.Checked = True
        Else
            Me.polcommune2.ForeColor = Color.Black
            'Ch6.Checked = False
        End If

        If Me.poldistrict2.Text <> Me.poldistrict.Text Then
            Me.poldistrict2.ForeColor = Color.Red
            IS_CHECK6 = True
            'Ch6.Checked = True
        Else
            Me.poldistrict2.ForeColor = Color.Black
            'Ch6.Checked = False
        End If

        If Me.polprovince2.Text <> Me.polprovince.Text Then
            Me.polprovince2.ForeColor = Color.Red
            IS_CHECK6 = True
            'Ch6.Checked = True
        Else
            Me.polprovince2.ForeColor = Color.Black
            'IS_CHECK6 = True
            'Ch6.Checked = False
        End If
        Ch6.Checked = IS_CHECK6
        If Ch1.Checked = False And Ch2.Checked = False And Ch3.Checked = False And Ch4.Checked = False And Ch5.Checked = False And Ch6.Checked = False Then
            Ch7.Checked = True
        Else
            Ch7.Checked = False
        End If

        'The system proces get image
        Application.DoEvents()
        BgLoading.RunWorkerAsync()
        LblLoadingPic.Visible = True
        PictLoading.Visible = True
        Application.DoEvents()





    End Sub
    Private Sub LoadingPicture()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf LoadingPicture))
        Else
            EnableButton.Enabled = False
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            pict1.Refresh()
            pict1.Image = ByteArrayToImage(IIf(TypeOf (ModuleIDCard.GetImpage(textdocno.Text, "photo")) Is DBNull, Nothing, ModuleIDCard.GetImpage(textdocno.Text, "photo")))
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            regisform1.Refresh()
            regisform1.Image = ByteArrayToImage(IIf(TypeOf (ModuleIDCard.GetImpage(textdocno.Text, "registrationform")) Is DBNull, Nothing, ModuleIDCard.GetImpage(textdocno.Text, "registrationform")))
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            pict2.Refresh()
            Me.pict2.Image = ByteArrayToImage(IIf(TypeOf (ModuleIDCard.GetImpage(textdocno.Text, "VerPhoto")) Is DBNull, Nothing, ModuleIDCard.GetImpage(textdocno.Text, "VerPhoto")))
            Application.DoEvents()
            System.Threading.Thread.Sleep(100)
            regisform2.Refresh()
            Me.regisform2.Image = ByteArrayToImage(IIf(TypeOf (ModuleIDCard.GetImpage(textdocno.Text, "VerRegistrationform")) Is DBNull, Nothing, ModuleIDCard.GetImpage(textdocno.Text, "VerRegistrationform")))
            Application.DoEvents()
        End If

    End Sub

    Private Sub FormVericationData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ModUserMG.ISAdmin = True Then
            btnDelete.Enabled = True
        End If
        SplitContainer1.SplitterDistance = Me.Width / 2
    End Sub



    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        If ReIndex <> MaxRows - 1 Then
            ReIndex = ReIndex + 1
            EnableButton = BtnNext
            NavegationRecord()
        Else
            MessageBox.Show("The last record reached", "Serch", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim MsgVerification As String = ""
            If Ch1.Checked = True Then
                MsgVerification = MsgVerification & " 1.ឈ"
            End If
            If Ch2.Checked = True Then
                MsgVerification = MsgVerification & "  2.ឡា"
            End If
            If Ch3.Checked = True Then
                MsgVerification = MsgVerification & "  3.ថខឆ"
            End If
            If Ch4.Checked = True Then
                MsgVerification = MsgVerification & "  4.ភ"
            End If
            If Ch5.Checked = True Then
                MsgVerification = MsgVerification & "  5.ទកំ"
            End If
            If Ch6.Checked = True Then
                MsgVerification = MsgVerification & "  6.អដ្ឋ"
            End If
            'If Ch7.Checked = True Then
            '    MsgVerification = MsgVerification & ", hteee"
            'End If


            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim sql As String = "select * from VIEW_PEOPLE_VERIFICATIONForImage where afisid=" & LblIDPrintOut.Text
            Dim cnn As New SqlClient.SqlConnection(My.Settings.DBConnectionString)
            cnn.Open()
            Dim Da As New SqlClient.SqlDataAdapter(sql, cnn)
            Da.Fill(DS, "TblFormVerify")

            Dim RptName As String = Application.StartupPath & "\CRVVerificationv1.rpt"
            Dim myReport As New clsCrystalReport()
            Dim FReportViewer As New ReportPreview
            myReport.ReportPath(RptName)
            myReport.SetDataSource(DS, "TblFormVerify")
            myReport.DiscardSavedData()
            myReport.SetParameterValue("NotCorrect", MsgVerification)
            FReportViewer.ReportViewer.Refresh()
            FReportViewer.ReportViewer.ReportSource = myReport.Report
            FReportViewer.ReportViewer.ViewReport()
            FReportViewer.ReportViewer.Zoom(100)
            FReportViewer.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        


    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevias.Click
        If ReIndex > 0 Then
            ReIndex = ReIndex - 1
            EnableButton = BtnPrevias
            NavegationRecord()
        Else
            MessageBox.Show("The first record reached", "Serch", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        If ReIndex <> 0 Then
            ReIndex = 0
            EnableButton = BtnLast
            NavegationRecord()
        Else
            MessageBox.Show("You are already at the last record.", "ID Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        If ReIndex <> MaxRows - 1 Then
            ReIndex = MaxRows - 1
            EnableButton = BtnLast
            NavegationRecord()
        Else
            MessageBox.Show("You are already at the last record.", "ID Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub



    Private Sub BgPayment_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoading.DoWork

        Application.DoEvents()

        LoadingPicture()
    End Sub

    Private Sub BgPayment_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoading.RunWorkerCompleted
        Application.DoEvents()
        LblLoadingPic.Visible = False
        PictLoading.Visible = False
        EnableButton.Enabled = True
        LblFiger.Text = "0"
        LblFiger.Text = GetTotaFinger(textdocno.Text)
        Application.DoEvents()
        BtnNeedCorrect.Text = "មិនយល់ព្រម"
        BtnNeedCorrect.Text = GetStatusPrint(LblIDPrintOut.Text)
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub tblToCorrect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblToCorrect.Click
        If MessageBox.Show("Do you want to request to correct?", "National ID Card", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim MsgVerification As String = ""
            If Ch1.Checked = True Then
                MsgVerification = MsgVerification & "1.ឈ"
            End If
            If Ch2.Checked = True Then
                MsgVerification = MsgVerification & ",  2.ឡា"
            End If
            If Ch3.Checked = True Then
                MsgVerification = MsgVerification & ",  3.ថខឆ"
            End If
            If Ch4.Checked = True Then
                MsgVerification = MsgVerification & ",  4.ភ"
            End If
            If Ch5.Checked = True Then
                MsgVerification = MsgVerification & ",  5.ទកំ"
            End If
            If Ch6.Checked = True Then
                MsgVerification = MsgVerification & ",  6.អដ្ឋ"
            End If
            If ModuleIDCard.UpdateReqCorrect(LblIDPrintOut.Text, MsgVerification) = 1 Then
                BtnNeedCorrect.Text = GetStatusPrint(LblIDPrintOut.Text)
                MessageBox.Show("Successful request.", "National ID Card", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error request.", "National ID Card", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

   
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Do you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DeletePersiont(LblIDPrintOut.Text) = 1 Then
                MessageBox.Show("Delete successful!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ToolStripButton3_Click(sender, e)
            End If
        End If
    End Sub

   
End Class