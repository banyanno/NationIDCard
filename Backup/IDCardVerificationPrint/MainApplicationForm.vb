Imports CrystalDecisions.Shared

Public Class MainApplicationForm
    Dim IDLogin As IDCardLogin
    Dim USearchPeopl As New SearchPeople(Me)
    Dim DashUserManagement As New DashBoardUserManagement
    Dim UReport As New UIReport
    Dim UIDStatistict As New IDCardStatistic(Me)
    Dim UIElection As New ElectionComparetion(Me)

    Sub New(ByVal IDLogin As IDCardLogin)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.IDLogin = IDLogin
        ' Add any initialization after the InitializeComponent() call.
        InitConfiguration()
    End Sub
    Private Sub InitConfiguration()
        IDLogin.UpdateLabelStatus("Log in successful...", True)
        Application.DoEvents()
        LblDataAccess.Text = ModUserMG.DataAccess
        If ModUserMG.ISAdmin = True Then
            BtnSystemManagement.Enabled = True
            LblISAdmin.Text = ModUserMG.UserName.ToUpper & " as user administrator"
        Else
            LblISAdmin.Text = ModUserMG.UserName.ToUpper & " as normal user"
        End If
        Application.DoEvents()
        IDLogin.UpdateLabelStatus("Checking Permission...", True)
        Application.DoEvents()
        IDLogin.UpdateLabelStatus("Configuration sucessfull", True)
    End Sub

    Sub GeneralAddControl(ByVal PMainContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer, ByVal UI As UserControl, ByVal Info As String)
        Me.Cursor = Cursors.WaitCursor
        PMainContainer.Controls.Clear()
        PMainContainer.AutoScroll = True
        'PMainContainer.AutoScrollMinSize = New Size(UI.Width, UI.Height)
        UI.Dock = DockStyle.Fill
        PMainContainer.Controls.Add(UI)
        Me.Cursor = Cursors.Default

    End Sub
    
   



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GeneralAddControl(uiPanel1Container, USearchPeopl, "Income Statement.")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        GeneralAddControl(uiPanel1Container, UReport, "Income Statement.")
    End Sub

    Private Sub MainApplicationForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        GeneralAddControl(uiPanel1Container, USearchPeopl, "Search People")
    End Sub

    Private Sub BtnSystemManagement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSystemManagement.Click
        GeneralAddControl(uiPanel1Container, DashUserManagement, "Income Statement.")
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
      
        ModValidation.IsScaning = False
        'Dim GenDAOStatisic As New DAOStatistic
        'GenDAOStatisic.DeleteDAO("Delete FROM MOI_TEM_RESULT")
        'GenDAOStatisic.DeleteDAO("Delete From MOI_TEM_RESULT_WRONG")
        Application.Exit()
    End Sub
    Sub CreateSwitchUser()
        IDLogin.txtUserName.Text = ""
        IDLogin.txtPassword.Text = ""

        ModUserMG.UserName = ""
        ModUserMG.DataAccess = ""
        ModUserMG.DProvince = ""
        ModUserMG.DDistrict = ""
        ModUserMG.DCommune = ""
        ModUserMG.DVillage = ""
        ModUserMG.ISAdmin = False
        IDLogin.txtUserName.Select()
        IDLogin.txtUserName.Focus()
        IDLogin.Cursor = Cursors.Default
        IDLogin.Show()

        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BtnLogoffUser_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnLogoffUser.Click
        CreateSwitchUser()
    End Sub

    Private Sub BtnResetPassword_Click(ByVal sender As System.Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles BtnResetPassword.Click

        Dim ResetPwd As New FormChangePwd
        ResetPwd.LblSave.Text = ModUserMG.USERID
        ResetPwd.TxtUsers.Text = ModUserMG.UserName
        If ResetPwd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CreateSwitchUser()
        End If
    End Sub

    Private Sub BtnStatistic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStatistic.Click
        GeneralAddControl(uiPanel1Container, UIDStatistict, "Statistic.")
    End Sub

    Private Sub BtnElection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnElection.Click
        GeneralAddControl(uiPanel1Container, UIElection, "Election Compair.")
        'Dim F As New FrmExection
        'F.Show()
    End Sub

    Private Sub MainApplicationForm_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        ModValidation.IsScaning = False
        'Dim GenDAOStatisic As New DAOStatistic
        'GenDAOStatisic.DeleteDAO("Delete FROM MOI_TEM_RESULT")
        Application.Exit()
    End Sub
End Class
