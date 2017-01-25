<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DashBoardUserManagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim GridUser_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashBoardUserManagement))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.BtnNewUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnChangePermission = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPermistion = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnRefresh = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnDeleteUser = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TreeProvince = New System.Windows.Forms.TreeView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridUser = New Janus.Windows.GridEX.GridEX
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewUser, Me.ToolStripSeparator1, Me.BtnChangePermission, Me.ToolStripSeparator5, Me.BtnPermistion, Me.ToolStripSeparator2, Me.BtnRefresh, Me.ToolStripSeparator3, Me.BtnDeleteUser, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1181, 32)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewUser
        '
        Me.BtnNewUser.ForeColor = System.Drawing.Color.Blue
        Me.BtnNewUser.Image = Global.IDCardVerificationPrint.My.Resources.Resources.social
        Me.BtnNewUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewUser.Name = "BtnNewUser"
        Me.BtnNewUser.Size = New System.Drawing.Size(107, 29)
        Me.BtnNewUser.Text = "New User"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BtnChangePermission
        '
        Me.BtnChangePermission.ForeColor = System.Drawing.Color.MediumBlue
        Me.BtnChangePermission.Image = Global.IDCardVerificationPrint.My.Resources.Resources.computer
        Me.BtnChangePermission.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnChangePermission.Name = "BtnChangePermission"
        Me.BtnChangePermission.Size = New System.Drawing.Size(173, 29)
        Me.BtnChangePermission.Text = "Change Permission"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 32)
        '
        'BtnPermistion
        '
        Me.BtnPermistion.ForeColor = System.Drawing.Color.Blue
        Me.BtnPermistion.Image = Global.IDCardVerificationPrint.My.Resources.Resources.people
        Me.BtnPermistion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPermistion.Name = "BtnPermistion"
        Me.BtnPermistion.Size = New System.Drawing.Size(148, 29)
        Me.BtnPermistion.Text = "Reset Password"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'BtnRefresh
        '
        Me.BtnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.BtnRefresh.Image = Global.IDCardVerificationPrint.My.Resources.Resources.arrow
        Me.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(92, 29)
        Me.BtnRefresh.Text = "Refresh"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 32)
        '
        'BtnDeleteUser
        '
        Me.BtnDeleteUser.ForeColor = System.Drawing.Color.Blue
        Me.BtnDeleteUser.Image = Global.IDCardVerificationPrint.My.Resources.Resources.close
        Me.BtnDeleteUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDeleteUser.Name = "BtnDeleteUser"
        Me.BtnDeleteUser.Size = New System.Drawing.Size(119, 29)
        Me.BtnDeleteUser.Text = "Delete User"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 32)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 32)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1181, 544)
        Me.SplitContainer1.SplitterDistance = 221
        Me.SplitContainer1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TreeProvince)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 544)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Province"
        '
        'TreeProvince
        '
        Me.TreeProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeProvince.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TreeProvince.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeProvince.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TreeProvince.Indent = 25
        Me.TreeProvince.ItemHeight = 25
        Me.TreeProvince.Location = New System.Drawing.Point(3, 28)
        Me.TreeProvince.Margin = New System.Windows.Forms.Padding(2)
        Me.TreeProvince.Name = "TreeProvince"
        Me.TreeProvince.Size = New System.Drawing.Size(215, 513)
        Me.TreeProvince.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridUser)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(956, 544)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of users"
        '
        'GridUser
        '
        Me.GridUser.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        GridUser_DesignTimeLayout.LayoutString = resources.GetString("GridUser_DesignTimeLayout.LayoutString")
        Me.GridUser.DesignTimeLayout = GridUser_DesignTimeLayout
        Me.GridUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUser.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridUser.GroupByBoxVisible = False
        Me.GridUser.HeaderFormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.GridUser.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridUser.Location = New System.Drawing.Point(3, 28)
        Me.GridUser.Name = "GridUser"
        Me.GridUser.RecordNavigator = True
        Me.GridUser.Size = New System.Drawing.Size(950, 513)
        Me.GridUser.TabIndex = 0
        '
        'DashBoardUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "DashBoardUserManagement"
        Me.Size = New System.Drawing.Size(1181, 576)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNewUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPermistion As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents GridUser As Janus.Windows.GridEX.GridEX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TreeProvince As System.Windows.Forms.TreeView
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnDeleteUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnChangePermission As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator

End Class
