<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainApplicationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApplicationForm))
        Me.Button1 = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel0Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.BtnElection = New System.Windows.Forms.Button
        Me.BtnStatistic = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnSystemManagement = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.uiPanel1 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel1Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.PicLoading = New System.Windows.Forms.PictureBox
        Me.RibbonStatusBar1 = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.DropDownCommand1 = New Janus.Windows.Ribbon.DropDownCommand
        Me.BtnResetPassword = New Janus.Windows.Ribbon.DropDownCommand
        Me.SeparatorCommand1 = New Janus.Windows.Ribbon.SeparatorCommand
        Me.BtnLogoffUser = New Janus.Windows.Ribbon.DropDownCommand
        Me.LblDataAccess = New Janus.Windows.Ribbon.LabelCommand
        Me.LblISAdmin = New Janus.Windows.Ribbon.LabelCommand
        Me.container1 = New Janus.Windows.Ribbon.ContainerControlCommand
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ContainerControlCommand1 = New Janus.Windows.Ribbon.ContainerControlCommand
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        Me.uiPanel0Container.SuspendLayout()
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel1.SuspendLayout()
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 0
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(3, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ទិន្នន័យស្ទួនខ្ចៅដៃ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1454074318_icon-111-search.ico")
        Me.ImageList1.Images.SetKeyName(1, "1454074346_icon-136-document-edit.ico")
        Me.ImageList1.Images.SetKeyName(2, "Officer.png")
        Me.ImageList1.Images.SetKeyName(3, "close.png")
        Me.ImageList1.Images.SetKeyName(4, "graph.png")
        Me.ImageList1.Images.SetKeyName(5, "Checking.png")
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.AllowAutoHideAnimation = False
        Me.UiPanelManager1.AllowPanelDrag = False
        Me.UiPanelManager1.AllowPanelDrop = False
        Me.UiPanelManager1.ContainerControl = Me
        Me.UiPanelManager1.DefaultTabGroupStyle = Janus.Windows.UI.Dock.TabGroupStyle.None
        Me.UiPanelManager1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.VS2005
        Me.uiPanel0.Id = New System.Guid("fe3731a9-fe1f-4509-8dd2-9b1bc3dcb0df")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel0)
        Me.uiPanel1.Id = New System.Guid("dd2f2218-4053-41d3-b520-f292a6ade578")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel1)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("fe3731a9-fe1f-4509-8dd2-9b1bc3dcb0df"), Janus.Windows.UI.Dock.PanelDockStyle.Left, New System.Drawing.Size(214, 583), True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("dd2f2218-4053-41d3-b520-f292a6ade578"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, New System.Drawing.Size(933, 583), True)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("fe3731a9-fe1f-4509-8dd2-9b1bc3dcb0df"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("dd2f2218-4053-41d3-b520-f292a6ade578"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'uiPanel0
        '
        Me.uiPanel0.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel0.InnerContainer = Me.uiPanel0Container
        Me.uiPanel0.Location = New System.Drawing.Point(3, 3)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.Size = New System.Drawing.Size(214, 583)
        Me.uiPanel0.TabIndex = 4
        Me.uiPanel0.Text = "Menu"
        '
        'uiPanel0Container
        '
        Me.uiPanel0Container.Controls.Add(Me.BtnElection)
        Me.uiPanel0Container.Controls.Add(Me.BtnStatistic)
        Me.uiPanel0Container.Controls.Add(Me.BtnClose)
        Me.uiPanel0Container.Controls.Add(Me.BtnSystemManagement)
        Me.uiPanel0Container.Controls.Add(Me.Button1)
        Me.uiPanel0Container.Controls.Add(Me.Button2)
        Me.uiPanel0Container.Location = New System.Drawing.Point(1, 18)
        Me.uiPanel0Container.Name = "uiPanel0Container"
        Me.uiPanel0Container.Size = New System.Drawing.Size(208, 564)
        Me.uiPanel0Container.TabIndex = 0
        '
        'BtnElection
        '
        Me.BtnElection.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnElection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnElection.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnElection.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnElection.ForeColor = System.Drawing.Color.Blue
        Me.BtnElection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnElection.ImageKey = "Checking.png"
        Me.BtnElection.ImageList = Me.ImageList1
        Me.BtnElection.Location = New System.Drawing.Point(4, 165)
        Me.BtnElection.Name = "BtnElection"
        Me.BtnElection.Size = New System.Drawing.Size(202, 44)
        Me.BtnElection.TabIndex = 5
        Me.BtnElection.Text = " ផ្ទៀងផ្ទៀត គ-ជ​-ប"
        Me.BtnElection.UseVisualStyleBackColor = True
        '
        'BtnStatistic
        '
        Me.BtnStatistic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnStatistic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStatistic.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStatistic.ForeColor = System.Drawing.Color.Blue
        Me.BtnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnStatistic.ImageKey = "graph.png"
        Me.BtnStatistic.ImageList = Me.ImageList1
        Me.BtnStatistic.Location = New System.Drawing.Point(4, 113)
        Me.BtnStatistic.Name = "BtnStatistic"
        Me.BtnStatistic.Size = New System.Drawing.Size(202, 38)
        Me.BtnStatistic.TabIndex = 4
        Me.BtnStatistic.Text = "​​​​​  ទិន្នន័យ អត្ត.ប័ណ្ណ"
        Me.BtnStatistic.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Blue
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.ImageKey = "close.png"
        Me.BtnClose.ImageList = Me.ImageList1
        Me.BtnClose.Location = New System.Drawing.Point(3, 276)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(202, 41)
        Me.BtnClose.TabIndex = 3
        Me.BtnClose.Text = "    Close App"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnSystemManagement
        '
        Me.BtnSystemManagement.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSystemManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSystemManagement.Enabled = False
        Me.BtnSystemManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSystemManagement.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSystemManagement.ForeColor = System.Drawing.Color.Blue
        Me.BtnSystemManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSystemManagement.ImageKey = "Officer.png"
        Me.BtnSystemManagement.ImageList = Me.ImageList1
        Me.BtnSystemManagement.Location = New System.Drawing.Point(4, 221)
        Me.BtnSystemManagement.Name = "BtnSystemManagement"
        Me.BtnSystemManagement.Size = New System.Drawing.Size(202, 41)
        Me.BtnSystemManagement.TabIndex = 2
        Me.BtnSystemManagement.Text = "    System Management"
        Me.BtnSystemManagement.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Blue
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageKey = "1454074346_icon-136-document-edit.ico"
        Me.Button2.ImageList = Me.ImageList1
        Me.Button2.Location = New System.Drawing.Point(3, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(202, 38)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "    របាយការណ៍ ខ្ចៅដៃ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'uiPanel1
        '
        Me.uiPanel1.CaptionVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel1.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel1.InnerContainer = Me.uiPanel1Container
        Me.uiPanel1.Location = New System.Drawing.Point(217, 3)
        Me.uiPanel1.Name = "uiPanel1"
        Me.uiPanel1.Size = New System.Drawing.Size(933, 583)
        Me.uiPanel1.TabIndex = 4
        Me.uiPanel1.Text = "Verfication"
        '
        'uiPanel1Container
        '
        Me.uiPanel1Container.Location = New System.Drawing.Point(1, 1)
        Me.uiPanel1Container.Name = "uiPanel1Container"
        Me.uiPanel1Container.Size = New System.Drawing.Size(931, 581)
        Me.uiPanel1Container.TabIndex = 0
        '
        'PicLoading
        '
        Me.PicLoading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PicLoading.Image = Global.IDCardVerificationPrint.My.Resources.Resources.loading_bar11
        Me.PicLoading.Location = New System.Drawing.Point(935, 0)
        Me.PicLoading.Name = "PicLoading"
        Me.PicLoading.Size = New System.Drawing.Size(200, 32)
        Me.PicLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLoading.TabIndex = 0
        Me.PicLoading.TabStop = False
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RibbonStatusBar1.ImageSize = New System.Drawing.Size(16, 16)
        Me.RibbonStatusBar1.LeftPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.DropDownCommand1, Me.LblDataAccess, Me.LblISAdmin})
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 589)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Office2007CustomColor = System.Drawing.Color.Empty
        Me.RibbonStatusBar1.RightPanelCommands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.container1})
        Me.RibbonStatusBar1.ShowToolTips = False
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(1153, 25)
        '
        '
        '
        Me.RibbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000
        Me.RibbonStatusBar1.SuperTipComponent.ImageList = Nothing
        Me.RibbonStatusBar1.TabIndex = 5
        Me.RibbonStatusBar1.Text = "RibbonStatusBar1"
        Me.RibbonStatusBar1.UseCompatibleTextRendering = False
        '
        'DropDownCommand1
        '
        Me.DropDownCommand1.Commands.AddRange(New Janus.Windows.Ribbon.CommandBase() {Me.BtnResetPassword, Me.SeparatorCommand1, Me.BtnLogoffUser})
        Me.DropDownCommand1.Image = CType(resources.GetObject("DropDownCommand1.Image"), System.Drawing.Image)
        Me.DropDownCommand1.Key = "DropDownCommand1"
        Me.DropDownCommand1.Name = "DropDownCommand1"
        Me.DropDownCommand1.SizeStyle = Janus.Windows.Ribbon.CommandSizeStyle.Small
        Me.DropDownCommand1.Text = "System Utility"
        '
        'BtnResetPassword
        '
        Me.BtnResetPassword.Image = CType(resources.GetObject("BtnResetPassword.Image"), System.Drawing.Image)
        Me.BtnResetPassword.Key = "DropDownCommand2"
        Me.BtnResetPassword.Name = "BtnResetPassword"
        Me.BtnResetPassword.Text = "Reset Password"
        '
        'SeparatorCommand1
        '
        Me.SeparatorCommand1.Key = "SeparatorCommand1"
        Me.SeparatorCommand1.Name = "SeparatorCommand1"
        '
        'BtnLogoffUser
        '
        Me.BtnLogoffUser.Image = CType(resources.GetObject("BtnLogoffUser.Image"), System.Drawing.Image)
        Me.BtnLogoffUser.Key = "DropDownCommand4"
        Me.BtnLogoffUser.Name = "BtnLogoffUser"
        Me.BtnLogoffUser.Text = "Lock Off System"
        '
        'LblDataAccess
        '
        Me.LblDataAccess.Image = CType(resources.GetObject("LblDataAccess.Image"), System.Drawing.Image)
        Me.LblDataAccess.Key = "LabelCommand1"
        Me.LblDataAccess.Name = "LblDataAccess"
        Me.LblDataAccess.Text = ""
        '
        'LblISAdmin
        '
        Me.LblISAdmin.Key = "LabelCommand2"
        Me.LblISAdmin.Name = "LblISAdmin"
        Me.LblISAdmin.Text = ""
        '
        'container1
        '
        Me.container1.Control = Me.PictureBox1
        Me.container1.ControlWidth = 150
        Me.container1.ForegroundStyle.ForeColor = System.Drawing.Color.Blue
        Me.container1.Key = "ContainerControlCommand2"
        Me.container1.Name = "container1"
        Me.container1.Text = ""
        Me.container1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IDCardVerificationPrint.My.Resources.Resources.loading_bar11
        Me.PictureBox1.Location = New System.Drawing.Point(985, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'ContainerControlCommand1
        '
        Me.ContainerControlCommand1.Image = CType(resources.GetObject("ContainerControlCommand1.Image"), System.Drawing.Image)
        Me.ContainerControlCommand1.Key = "ContainerControlCommand1"
        Me.ContainerControlCommand1.Name = "ContainerControlCommand1"
        Me.ContainerControlCommand1.Text = ""
        '
        'MainApplicationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1153, 614)
        Me.Controls.Add(Me.uiPanel1)
        Me.Controls.Add(Me.uiPanel0)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainApplicationForm"
        Me.Text = "Verification ID Card System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        Me.uiPanel0Container.ResumeLayout(False)
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel1.ResumeLayout(False)
        CType(Me.PicLoading, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents uiPanel1 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel1Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents RibbonStatusBar1 As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents ContainerControlCommand1 As Janus.Windows.Ribbon.ContainerControlCommand
    Friend WithEvents PicLoading As System.Windows.Forms.PictureBox
    Friend WithEvents container1 As Janus.Windows.Ribbon.ContainerControlCommand
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnSystemManagement As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents DropDownCommand1 As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnResetPassword As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents BtnLogoffUser As Janus.Windows.Ribbon.DropDownCommand
    Friend WithEvents SeparatorCommand1 As Janus.Windows.Ribbon.SeparatorCommand
    Friend WithEvents LblDataAccess As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents LblISAdmin As Janus.Windows.Ribbon.LabelCommand
    Friend WithEvents BtnStatistic As System.Windows.Forms.Button
    Friend WithEvents BtnElection As System.Windows.Forms.Button

End Class
