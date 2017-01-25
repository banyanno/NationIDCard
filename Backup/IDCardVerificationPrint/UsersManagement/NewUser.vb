Public Class NewUser

    Dim DAProvince As New DSIDVerificationTableAdapters.TBL_PROVINCETableAdapter
    Dim DADistrict As New DSIDVerificationTableAdapters.TBL_DISTRICTTableAdapter
    Dim DACommune As New DSIDVerificationTableAdapters.TBL_COMMUNETableAdapter
    Dim DAVillage As New DSIDVerificationTableAdapters.TBL_VILLAGETableAdapter
    Dim TblPeopleSearch As DataTable
    Dim TblProvince As DataTable = DAProvince.GetData
    Dim TblDistrict As DataTable
    Dim TblCommune As DataTable
    Dim TblVillage As DataTable
    Public IS_CHANGE_PM As Boolean = False
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
   

   

   
   
    Private Sub BtnCancelk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelk.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(UserName, "", ErrCheck) = False Then Exit Sub
       
        If LblSaveOption.Text = "0" Then
            If ValidateTextField(TxtPassword, "", ErrCheck) = False Then Exit Sub
            If ValidateTextField(TxtVerPassword, "", ErrCheck) = False Then Exit Sub

            If TxtPassword.Text <> TxtVerPassword.Text Then
                MessageBox.Show("Not match password. Please try new password.", "New User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If MessageBox.Show("Do you want to create user?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If ModUserMG.CreateNewUser(UserName.Text, TxtPassword.Text, cboPROVINCE.Text, cboDISTRICT.Text, cboCOMMUNE.Text, cboVILLAGE.Text, ChAdministrator.Checked, cboPROVINCE.SelectedValue, cboDISTRICT.SelectedValue, cboCOMMUNE.SelectedValue, cboVILLAGE.SelectedValue) = 1 Then
                    MessageBox.Show("Create new user sucessfully!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error create user. Please contact system admin", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If MessageBox.Show("Do you want to change permission?", "Admin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If ModUserMG.ChangePermision(LblSaveOption.Text, cboPROVINCE.Text, cboDISTRICT.Text, cboCOMMUNE.Text, cboVILLAGE.Text, ChAdministrator.Checked, cboPROVINCE.SelectedValue, cboDISTRICT.SelectedValue, cboCOMMUNE.SelectedValue, cboVILLAGE.SelectedValue) = 1 Then
                    MessageBox.Show("Change permission sucessfully!", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error change password. Please contact system admin", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub cboPROVINCE_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPROVINCE.SelectionChangeCommitted
        ' If IS_CHANGE_PM = False Then
        Try
            TblDistrict = DADistrict.SelectByProvinceID(cboPROVINCE.SelectedValue)
            cboDISTRICT.DataSource = TblDistrict
            cboDISTRICT.Text = ""
            cboCOMMUNE.Text = ""
            cboVILLAGE.Text = ""
            cboDISTRICT.SelectedIndex = -1
        Catch ex As Exception
        End Try
        
        'End If
    End Sub

    Private Sub cboDISTRICT_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDISTRICT.SelectionChangeCommitted
        'If IS_CHANGE_PM = False Then
        Try
            TblCommune = DACommune.SelectByDISTRICTID(cboDISTRICT.SelectedValue)
            cboCOMMUNE.DataSource = TblCommune
            cboCOMMUNE.Text = ""
            cboVILLAGE.Text = ""
            cboCOMMUNE.SelectedIndex = -1
        Catch ex As Exception

        End Try
        
        'End If
    End Sub

    Private Sub cboCOMMUNE_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCOMMUNE.SelectionChangeCommitted
        'If IS_CHANGE_PM = False Then
        Try
            TblVillage = DAVillage.SelectByCOMMUNEID(cboCOMMUNE.SelectedValue)
            cboVILLAGE.DataSource = TblVillage
            cboVILLAGE.Text = ""
            cboVILLAGE.SelectedIndex = -1
        Catch ex As Exception
        End Try


        'End If
    End Sub

    Private Sub ChAdministrator_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChAdministrator.CheckedChanged
        If ChAdministrator.Checked = True Then
            cboPROVINCE.Enabled = False
            cboDISTRICT.Enabled = False
            cboCOMMUNE.Enabled = False
            cboVILLAGE.Enabled = False
        Else
            cboPROVINCE.Enabled = True
            cboDISTRICT.Enabled = True
            cboCOMMUNE.Enabled = True
            cboVILLAGE.Enabled = True
        End If
    End Sub
End Class