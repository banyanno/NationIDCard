Imports System.Data.SqlClient
Imports System.Net
Imports System.Reflection.Assembly
Imports System.Threading

Public Class IDCardLogin
    'Dim UserInGroupDataAdapter As New DSUserManagementTableAdapters.VUsersInGroupTableAdapter
    ''Inherits System.Windows.Forms.Form
    '' TODO: Insert code to perform custom authentication using the provided username and password 
    '' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    '' The custom principal can then be attached to the current thread's principal as follows: 
    ''     My.User.CurrentPrincipal = CustomPrincipal
    '' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    '' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    '' such as the username, display name, etc.

    'Dim version As Version = GetExecutingAssembly.GetName.Version
    Dim MsgLogin As Integer
    'Dim DAParams_Inven As New DSDepartmentTableAdapters.PARAMS_INVENTableAdapter
    'Function LogIn() As Integer
    '    Return ModUserLogin.checkPassword(UCase(txtUserName.Text.Trim), UCase(txtPassword.Text.Trim))
    'End Function
    ' ------------------------Show status -------------------------------
    Private Delegate Sub DelShowLabelStatus(ByVal txt As String, ByVal v As Boolean)
    Private Delegate Sub DelegatePicture(ByVal v As Boolean)
    Private Sub UpdateStatus(ByVal txt As String, ByVal v As Boolean)
        LblStatus.Visible = v
        LblStatus.Text = txt
    End Sub
    Private Sub UpdateVisiblePicLoading(ByVal v As Boolean)
        PictLoading.Visible = v
    End Sub
    Public Sub UpdateLoaingPic(ByVal v As Boolean)
        If Me.Created Then
            PictLoading.Invoke(New DelegatePicture(AddressOf UpdateVisiblePicLoading), New Object() {v})
        End If
    End Sub
    Public Sub UpdateLabelStatus(ByVal txt As String, ByVal v As Boolean)
        If Me.Created Then
            LblStatus.Invoke(New DelShowLabelStatus(AddressOf UpdateStatus), New Object() {txt, v})
        End If
    End Sub
    Function CheckUseAndPwd(ByVal UserName As String, ByVal Pwd As String) As Integer
        ' Try
        Dim tblUser As DataTable = ModUserMG.SelectUserLogIn(UserName, Pwd)
        If tblUser.Rows.Count > 0 Then
            For Each row As DataRow In tblUser.Rows
                'MsgBox(row("UserName") & " " & row("Password") & "  " & row("DepartName") & " " & row("GroupNo"))
                ModUserMG.USERID = row("USER_ID")
                ModUserMG.UserName = row("USER_NAME")
                ModUserMG.DataAccess = "Data Access: " & row("DATA_PROVICE_PM") & "/" & row("DATA_DISTRICT_PM") & "/" & row("DATA_COMMUNE") & "/" & row("DATA_VILLAGE")
                ModUserMG.DProvince = row("DATA_PROVICE_PM")
                ModUserMG.DDistrict = row("DATA_DISTRICT_PM")
                ModUserMG.PROVINCE_ID = row("PROVINCE_ID")
                ModUserMG.DISTRICT_ID = row("DISTRICT_ID")
                ModUserMG.COMMUNE_ID = row("COMMUNE_ID")
                ModUserMG.VILLAGE_ID = row("VILLAGE_ID")


                ';;;;;;;;;;;;;;;;;;;p;;;;;;;;;;;;;pp;pp;;;;;;;;;;;;;;;pppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppppp                ModUserMG.DCommune = row("DATA_COMMUNE")
                ModUserMG.DVillage = row("DATA_VILLAGE")
                ModUserMG.ISAdmin = row("IS_ADMIN")
            Next
            Return 0
        Else
            Return 1
        End If



        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Connection")
        '    Me.UpdateLabelStatus("", False)
        'End Try

    End Function

    Sub DoLoginComplete()

        If MsgLogin = 0 Then   'Successfully login

            '--- Initial inventory parameters
            IntialPARAMS_INVEN()

            Dim StrWelcome As String = ""
            'TBLACCESS_ROLE = ModUserLogin.SelectRoles() '-------------Release table of User Access Roles-------
            'UserGlobleVariable.USER_NAME = Me.txtUserName.Text.ToUpper.Trim
            'UserGlobleVariable.USER_PWD = Me.txtPassword.Text.ToUpper.Trim
            'Me.UpdateLabelStatus("Log in successful.", True)
            Application.DoEvents()
            SubMain = New MainApplicationForm(Me)
            'SubMain.InitUserControl()
            Me.Hide()
            SubMain.Show()
           


        ElseIf MsgLogin = 4 Then
            MsgBox("Sorry, this user name is blocked.", MsgBoxStyle.Critical, "Login Confirm")
       
        ElseIf MsgLogin = 10 Then
            Exit Sub
        Else
            'Dim Num As Integer
            'Num = Convert.ToInt32(Me.txtPassword.Text)
            'MsgBox(Num)
            MsgBox("Sorry, this user name and password is not valid.", MsgBoxStyle.Critical, "Login Confirm")
            Me.txtUserName.Focus()
        End If
    End Sub
    Private Sub BgLogin_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLogin.DoWork
        MsgLogin = CheckUseAndPwd(txtUserName.Text, txtPassword.Text)   'LogIn()
    End Sub
    Private Sub BgLogin_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLogin.RunWorkerCompleted
        DoLoginComplete()
        BtnOk.Enabled = True
        BtnExit.Enabled = True
        Me.UpdateLabelStatus("", False)
        UpdateLoaingPic(False)
    End Sub


    Private Sub txtUserName_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUserName.GotFocus
        Me.txtUserName.SelectAll()
    End Sub

    Private Sub txtUserName_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtUserName.MouseClick
        Me.txtUserName.SelectAll()
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        Me.txtPassword.SelectAll()
    End Sub

    Private Sub txtPassword_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPassword.MouseClick
        Me.txtPassword.SelectAll()
    End Sub

    Private Sub frmLogin_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.Alt = True And e.KeyCode = Keys.U Then
            Me.txtUserName.Focus()
        ElseIf e.Alt = True And e.KeyCode = Keys.P Then
            Me.txtPassword.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            '----Expire Date-------------------------------------------------------------------
            'Dim obj As New EyeUnit.RegistryTrial
            'obj.SaveLastAceessDateTime()
            ''Me.Close()
            '----------------------------------------------------------------------------------
            'nFrmLogin.Close()
        End If
    End Sub


    'Private Sub RDKhmer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim winFont As New System.Drawing.Font("wat phnom T3", 8)
    '    Me.UsernameLabel.Font = winFont
    '    Me.PasswordLabel.Font = winFont
    '    Me.cmdOK.Font = winFont
    '    Me.cmdCancel.Font = winFont
    '    Me.UsernameLabel.Text = "e&QµaH"
    '    Me.PasswordLabel.Text = "e&lxsMgat;"
    '    Me.cmdOK.Text = "&yl;RBm"
    '    Me.cmdCancel.Text = "&cakecj"
    'End Sub

    'Private Sub RDEnglish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim winFont As New System.Drawing.Font("Microsoft Sans Serif", 8)
    '    Me.UsernameLabel.Font = winFont
    '    Me.PasswordLabel.Font = winFont
    '    Me.cmdOK.Font = winFont
    '    Me.cmdCancel.Font = winFont
    '    Me.UsernameLabel.Text = "&User name"
    '    Me.PasswordLabel.Text = "&Password;"
    '    Me.cmdOK.Text = "&OK"
    '    Me.cmdCancel.Text = "&Cancel"
    'End Sub
    Dim SubMain As MainApplicationForm
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        'If Me.txtUserName.Text.Trim.ToUpper = "" Then
        '    MsgBox("Please enter your username.", MsgBoxStyle.Information, "Login Confirm")
        '    Me.txtUserName.Focus()
        '    Exit Sub
        'ElseIf Me.txtPassword.Text.Trim.ToUpper = "" Then
        '    MsgBox("Please enter your password.", MsgBoxStyle.Information, "Login Confirm")
        '    Me.txtPassword.Focus()
        '    Exit Sub
        'Else
        '    'BtnOk.Enabled = False
        '    'BtnExit.Enabled = False
        '    PictLoading.Visible = True
        '    'LblConnecting.Visible = True
        '    'Me.UpdateLabelStatus("Connecting to database...", True)
        '    'Me.UpdateLoaingPic(True)
        '    Application.DoEvents()
        '    ' Me.Cursor = Cursors.WaitCursor
        '    BgLogin.RunWorkerAsync()
        'End If


        ''If CheckUseAndPwd(Me.txtUserName.Text, txtPassword.Text) = True Then
        ''    Me.UpdateLabelStatus("Connected to database successful...", True)
        ''    Application.DoEvents()
        ''    Me.Cursor = Cursors.WaitCursor
        ''    Dim SubMain As New MainTakeoInventory(Me)
        ''    Me.UpdateLabelStatus("Check user permission on form...", True)
        ''    SubMain.CheckPermistionOnForm()

        ''    Application.DoEvents()
        ''    Me.Hide()
        ''    SubMain.Show()
        ''    Me.Cursor = Cursors.Default
        ''    Me.UpdateLabelStatus("Connectiong to database...", False)
        ''Else
        ''    MessageBox.Show("Sorry, this user name and password is not valid.", "Login Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ''End If

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Me.UpdateLabelStatus("Checking user permission", False)
        'Label2.Text = "Copyright 2012. All rights reserved by KTG Version " & version.ToString & "  " & GetDateServer.Date.ToString("MMM-yyyy")

    End Sub

    Sub IntialPARAMS_INVEN()

        'Dim PARAM_INVEN As DataTable = DAParams_Inven.GetData
        ''--- Query all parameters
        'For Each row As DataRow In PARAM_INVEN.Rows
        '    Select Case row("ParamName")
        '        Case "MAIN_STOCK_DEPART_ID"
        '            MAIN_STOCK_DEPART_ID = row("Value")
        '        Case "PHARMACY_DEPART_ID"
        '            PHARMACY_DEPART_ID = row("Value")
        '        Case "OPTICALSHOP_DEPART_ID"
        '            OPTICALSHOP_DEPART_ID = row("Value")
        '        Case "OPEN"
        '            OPEN = row("Value")
        '        Case "SENT"
        '            SENT = row("Value")
        '        Case "RESPONSE"
        '            RESPONSE = row("Value")
        '        Case "RECEIVED"
        '            RECEIVED = row("Value")
        '        Case "APPROVED"
        '            APPROVED = row("Value")
        '    End Select
        'Next

    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.txtUserName.Text.Trim.ToUpper = "" Then
            MsgBox("Please enter your username.", MsgBoxStyle.Information, "Login Confirm")
            Me.txtUserName.Focus()
            Exit Sub
        ElseIf Me.txtPassword.Text.Trim.ToUpper = "" Then
            MsgBox("Please enter your password.", MsgBoxStyle.Information, "Login Confirm")
            Me.txtPassword.Focus()
            Exit Sub
        Else
            'BtnOk.Enabled = False
            'BtnExit.Enabled = False
            PictLoading.Visible = True
            'LblConnecting.Visible = True
            'Me.UpdateLabelStatus("Connecting to database...", True)
            'Me.UpdateLoaingPic(True)
            Application.DoEvents()
            ' Me.Cursor = Cursors.WaitCursor
            BgLogin.RunWorkerAsync()
        End If


        'If CheckUseAndPwd(Me.txtUserName.Text, txtPassword.Text) = True Then
        '    Me.UpdateLabelStatus("Connected to database successful...", True)
        '    Application.DoEvents()
        '    Me.Cursor = Cursors.WaitCursor
        '    Dim SubMain As New MainTakeoInventory(Me)
        '    Me.UpdateLabelStatus("Check user permission on form...", True)
        '    SubMain.CheckPermistionOnForm()

        '    Application.DoEvents()
        '    Me.Hide()
        '    SubMain.Show()
        '    Me.Cursor = Cursors.Default
        '    Me.UpdateLabelStatus("Connectiong to database...", False)
        'Else
        '    MessageBox.Show("Sorry, this user name and password is not valid.", "Login Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub
End Class
