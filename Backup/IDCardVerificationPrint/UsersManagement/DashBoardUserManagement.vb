Public Class DashBoardUserManagement
    Dim DAProvince As New DSIDVerificationTableAdapters.TBL_PROVINCETableAdapter
    Dim DADistrict As New DSIDVerificationTableAdapters.TBL_DISTRICTTableAdapter
    Dim DACommune As New DSIDVerificationTableAdapters.TBL_COMMUNETableAdapter
    Dim DAVillage As New DSIDVerificationTableAdapters.TBL_VILLAGETableAdapter
    Dim TblPeopleSearch As DataTable
    Dim TblProvince As DataTable = DAProvince.GetData
    Dim TblDistrict As DataTable
    Dim TblCommune As DataTable
    Dim TblVillage As DataTable
    Private Sub PopulateTreeNode(ByVal TableProvice As DataTable, ByVal MainTree As TreeView)
        MainTree.Nodes.Clear()
        Dim LI As New ImageList
        LI.ImageSize = New Size(30, 30)
        LI.ColorDepth = ColorDepth.Depth32Bit
        TreeProvince.ImageList = LI
        Dim imgIndex As Integer = 0

        'Populat Province

        For Each rows As DataRow In TableProvice.Rows
            Dim Tn As New TreeNode
            Tn.Name = rows("PROVINCEID").ToString
            Tn.Text = rows("PROV_KH").ToString
            Tn.Tag = rows("PROV_EN").ToString
            'Tn.ImageIndex = imgIndex
            TreeProvince.Nodes.Add(Tn)
            imgIndex = imgIndex + 1
            'TblDistrict = DADistrict.SelectByProvinceID(rows("PROVINCEID").ToString)
            ''Populate Distric
            'For Each RowsDistri As DataRow In TblDistrict.Rows
            '    Dim childnodeDistric As New TreeNode
            '    childnodeDistric.Name = RowsDistri("DISTRICTID").ToString
            '    childnodeDistric.Text = RowsDistri("DIST_KH").ToString
            '    childnodeDistric.Tag = RowsDistri("DIST_EN").ToString
            '    Tn.Nodes.Add(childnodeDistric)

            '    TblCommune = DACommune.SelectByDISTRICTID(RowsDistri("DISTRICTID").ToString)
            '    For Each rowsCommune As DataRow In TblCommune.Rows
            '        Dim chCommune As New TreeNode
            '        chCommune.Name = rowsCommune("COMMUNEID").ToString
            '        chCommune.Text = rowsCommune("COMM_KH").ToString
            '        chCommune.Tag = rowsCommune("COMM_EN").ToString
            '        childnodeDistric.Nodes.Add(chCommune)
            '        Dim TblVillage = DAVillage.SelectByCOMMUNEID(rowsCommune("COMMUNEID").ToString)
            '        For Each rowsVillage As DataRow In TblVillage
            '            Dim chVillage As New TreeNode
            '            chVillage.Name = rowsVillage("VILLAGEID")
            '            chVillage.Text = rowsVillage("VILL_KH")
            '            chVillage.Tag = rowsVillage("VILL_EN")
            '            chCommune.Nodes.Add(chVillage)
            '        Next
            '    Next

            'Next

        Next
    End Sub
    Private Sub RefreshUser()
        GridUser.DataSource = ModUserMG.SelectAllUser
    End Sub
    'Public Sub PopulateTreeView(ByVal inParentID As Integer, ByRef inTreeNode As TreeNode)

    '    Dim categories
    '    If categories.Count > 0 Then
    '        For Each cate In categories
    '            Dim parentnode As TreeNode
    '            'we'll provide some text for the tree node.
    '            Dim strLabel As String = cate.CateName & "(" & cate.ItemCount & ")"
    '            parentnode = New TreeNode(strLabel, 0, 0)
    '            parentnode.Tag = cate.CateID
    '            inTreeNode.Nodes.Add(parentnode)
    '            'set the tag property for the current node. This comes in useful if 
    '            'you want to pass the value of a specific record id.
    '            'since the tag value is not visible, in the TreeView1_AfterSelect event 
    '            'you could pass the value to another sub routine, for example:
    '            'FillDataGrid(TreeView1.SelectedNode.Tag)
    '            'parentnode.Tag = cate.CateID
    '            'call the routine again to find childern of this record.
    '            PopulateTreeView(cate.CateID, parentnode)
    '        Next
    '    End If
    'End Sub

    Private Sub DashBoardUserManagement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim TProvince As DataTable = DAProvince.GetData
        PopulateTreeNode(TProvince, TreeProvince)
        TreeProvince.Select()
        TreeProvince.Focus()
        RefreshUser()
    End Sub

    Private Sub BtnNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewUser.Click
        Dim User As New NewUser
        If User.ShowDialog() = DialogResult.OK Then
            RefreshUser()
        End If
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        RefreshUser()
    End Sub

    Private Sub BtnPermistion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPermistion.Click
        If GridUser.SelectedItems.Count = 0 Then Exit Sub
        Dim ResetPwd As New FormChangePwd
        ResetPwd.LblSave.Text = GridUser.GetRow.Cells("USER_ID").Value
        ResetPwd.TxtUsers.Text = GridUser.GetRow.Cells("USER_NAME").Value
        ResetPwd.ShowDialog()
    End Sub

    Private Sub BtnChangePermission_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangePermission.Click
        If GridUser.SelectedItems.Count = 0 Then Exit Sub
        Dim ChangePermission As New NewUser
        ChangePermission.IS_CHANGE_PM = True
        ChangePermission.LblSaveOption.Text = GridUser.GetRow.Cells("USER_ID").Value
        ChangePermission.UserName.Text = GridUser.GetRow.Cells("USER_NAME").Value
        ChangePermission.UserName.ReadOnly = True
        ChangePermission.TxtPassword.ReadOnly = True
        ChangePermission.TxtVerPassword.ReadOnly = True
        ChangePermission.ChAdministrator.Checked = GridUser.GetRow.Cells("IS_ADMIN").Value
        ChangePermission.cboPROVINCE.Text = GridUser.GetRow.Cells("DATA_PROVICE_PM").Value
        ChangePermission.cboDISTRICT.Text = GridUser.GetRow.Cells("DATA_DISTRICT_PM").Value
        ChangePermission.cboCOMMUNE.Text = GridUser.GetRow.Cells("DATA_COMMUNE").Value
        ChangePermission.cboVILLAGE.Text = GridUser.GetRow.Cells("DATA_VILLAGE").Value
        If ChangePermission.ShowDialog() = DialogResult.OK Then
            RefreshUser()
        End If
    End Sub

    Private Sub BtnDeleteUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteUser.Click
        If GridUser.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If ModUserMG.DeleteUser(GridUser.GetRow.Cells("USER_ID").Value) = 1 Then
                MessageBox.Show("Delete sucessfull!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshUser()
            Else
                MessageBox.Show("Error delete users!", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub TreeProvince_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeProvince.AfterSelect
        GridUser.DataSource = ModUserMG.SelectUserByProvince(e.Node.Text)
    End Sub

End Class
