<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ElectionComparetion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ElectionComparetion))
        Dim GridKJB_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridResult_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridWrongResult_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnVerify = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btnScan = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnReport = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PicLoadSearching = New System.Windows.Forms.PictureBox
        Me.LblWatching = New System.Windows.Forms.Label
        Me.LblTotal = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboProvince = New System.Windows.Forms.ComboBox
        Me.ChProvince = New System.Windows.Forms.CheckBox
        Me.ChDOB = New System.Windows.Forms.CheckBox
        Me.ChSex = New System.Windows.Forms.CheckBox
        Me.ChName = New System.Windows.Forms.CheckBox
        Me.ChFamilyName = New System.Windows.Forms.CheckBox
        Me.ChIDCard = New System.Windows.Forms.CheckBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridKJB = New Janus.Windows.GridEX.GridEX
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GridResult = New Janus.Windows.GridEX.GridEX
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GridWrongResult = New Janus.Windows.GridEX.GridEX
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLoadSearching, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridKJB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.GridWrongResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnVerify, Me.ToolStripSeparator3, Me.btnScan, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripSeparator4, Me.ToolStripButton4, Me.ToolStripSeparator2, Me.BtnCancel, Me.ToolStripSeparator5, Me.BtnReport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1203, 39)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnVerify
        '
        Me.btnVerify.ForeColor = System.Drawing.Color.Blue
        Me.btnVerify.Image = CType(resources.GetObject("btnVerify.Image"), System.Drawing.Image)
        Me.btnVerify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(181, 36)
        Me.btnVerify.Text = "ទាញទិន្នន័យពី គជប"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnScan
        '
        Me.btnScan.Enabled = False
        Me.btnScan.ForeColor = System.Drawing.Color.Blue
        Me.btnScan.Image = CType(resources.GetObject("btnScan.Image"), System.Drawing.Image)
        Me.btnScan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnScan.Name = "btnScan"
        Me.btnScan.Size = New System.Drawing.Size(145, 36)
        Me.btnScan.Text = "ផ្តើម ផ្ទៀងផ្ទៀត"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        Me.ToolStripSeparator1.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(161, 36)
        Me.ToolStripButton3.Text = "បញ្ឈប់ ផ្ទៀងផ្ទៀត"
        Me.ToolStripButton3.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Blue
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(149, 36)
        Me.ToolStripButton4.Text = "បង្ហាញ់លទ្ធផល"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        Me.ToolStripSeparator2.Visible = False
        '
        'BtnCancel
        '
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.ForeColor = System.Drawing.Color.Red
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(137, 36)
        Me.BtnCancel.Text = "បោះបង់ចោល"
        Me.BtnCancel.Visible = False
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'BtnReport
        '
        Me.BtnReport.ForeColor = System.Drawing.Color.Blue
        Me.BtnReport.Image = Global.IDCardVerificationPrint.My.Resources.Resources.up_arrow
        Me.BtnReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(145, 36)
        Me.BtnReport.Text = " របាយការណ៏​​  "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 39)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PicLoadSearching)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblWatching)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LblTotal)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1203, 772)
        Me.SplitContainer1.SplitterDistance = 127
        Me.SplitContainer1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.IDCardVerificationPrint.My.Resources.Resources.loading_bar11
        Me.PictureBox2.Location = New System.Drawing.Point(1029, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(167, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.IDCardVerificationPrint.My.Resources.Resources.searching
        Me.PictureBox1.Location = New System.Drawing.Point(1029, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(167, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PicLoadSearching
        '
        Me.PicLoadSearching.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicLoadSearching.Image = Global.IDCardVerificationPrint.My.Resources.Resources.searching
        Me.PicLoadSearching.Location = New System.Drawing.Point(2108, 3)
        Me.PicLoadSearching.Name = "PicLoadSearching"
        Me.PicLoadSearching.Size = New System.Drawing.Size(166, 50)
        Me.PicLoadSearching.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLoadSearching.TabIndex = 7
        Me.PicLoadSearching.TabStop = False
        Me.PicLoadSearching.Visible = False
        '
        'LblWatching
        '
        Me.LblWatching.AutoSize = True
        Me.LblWatching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblWatching.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblWatching.Font = New System.Drawing.Font("Khmer OS Battambang", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWatching.ForeColor = System.Drawing.Color.Chocolate
        Me.LblWatching.Location = New System.Drawing.Point(471, 77)
        Me.LblWatching.Name = "LblWatching"
        Me.LblWatching.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LblWatching.Size = New System.Drawing.Size(2, 42)
        Me.LblWatching.TabIndex = 5
        Me.LblWatching.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblTotal.Font = New System.Drawing.Font("Khmer OS Battambang", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Blue
        Me.LblTotal.Location = New System.Drawing.Point(471, 5)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(2, 36)
        Me.LblTotal.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboProvince)
        Me.GroupBox1.Controls.Add(Me.ChProvince)
        Me.GroupBox1.Controls.Add(Me.ChDOB)
        Me.GroupBox1.Controls.Add(Me.ChSex)
        Me.GroupBox1.Controls.Add(Me.ChName)
        Me.GroupBox1.Controls.Add(Me.ChFamilyName)
        Me.GroupBox1.Controls.Add(Me.ChIDCard)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(8, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 115)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "លក្ខ័ណ ផ្ទៀងផ្តៀត"
        '
        'cboProvince
        '
        Me.cboProvince.Enabled = False
        Me.cboProvince.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvince.FormattingEnabled = True
        Me.cboProvince.Location = New System.Drawing.Point(272, 67)
        Me.cboProvince.Name = "cboProvince"
        Me.cboProvince.Size = New System.Drawing.Size(142, 30)
        Me.cboProvince.TabIndex = 6
        '
        'ChProvince
        '
        Me.ChProvince.AutoSize = True
        Me.ChProvince.Location = New System.Drawing.Point(217, 70)
        Me.ChProvince.Name = "ChProvince"
        Me.ChProvince.Size = New System.Drawing.Size(59, 33)
        Me.ChProvince.TabIndex = 5
        Me.ChProvince.Text = "ខេត្ត"
        Me.ChProvince.UseVisualStyleBackColor = True
        '
        'ChDOB
        '
        Me.ChDOB.AutoSize = True
        Me.ChDOB.Checked = True
        Me.ChDOB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChDOB.Location = New System.Drawing.Point(77, 70)
        Me.ChDOB.Name = "ChDOB"
        Me.ChDOB.Size = New System.Drawing.Size(134, 33)
        Me.ChDOB.TabIndex = 4
        Me.ChDOB.Text = "ថ្ងៃខែឆ្នាំ កំណើត"
        Me.ChDOB.UseVisualStyleBackColor = True
        '
        'ChSex
        '
        Me.ChSex.AutoSize = True
        Me.ChSex.Checked = True
        Me.ChSex.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChSex.Location = New System.Drawing.Point(8, 70)
        Me.ChSex.Name = "ChSex"
        Me.ChSex.Size = New System.Drawing.Size(59, 33)
        Me.ChSex.TabIndex = 3
        Me.ChSex.Text = "ភេទ"
        Me.ChSex.UseVisualStyleBackColor = True
        '
        'ChName
        '
        Me.ChName.AutoSize = True
        Me.ChName.Checked = True
        Me.ChName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChName.Location = New System.Drawing.Point(336, 27)
        Me.ChName.Name = "ChName"
        Me.ChName.Size = New System.Drawing.Size(59, 33)
        Me.ChName.TabIndex = 2
        Me.ChName.Text = "នាម"
        Me.ChName.UseVisualStyleBackColor = True
        '
        'ChFamilyName
        '
        Me.ChFamilyName.AutoSize = True
        Me.ChFamilyName.Checked = True
        Me.ChFamilyName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChFamilyName.Location = New System.Drawing.Point(217, 27)
        Me.ChFamilyName.Name = "ChFamilyName"
        Me.ChFamilyName.Size = New System.Drawing.Size(91, 33)
        Me.ChFamilyName.TabIndex = 1
        Me.ChFamilyName.Text = "គោត្តនាម"
        Me.ChFamilyName.UseVisualStyleBackColor = True
        '
        'ChIDCard
        '
        Me.ChIDCard.AutoSize = True
        Me.ChIDCard.Checked = True
        Me.ChIDCard.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChIDCard.Location = New System.Drawing.Point(8, 27)
        Me.ChIDCard.Name = "ChIDCard"
        Me.ChIDCard.Size = New System.Drawing.Size(174, 33)
        Me.ChIDCard.TabIndex = 0
        Me.ChIDCard.Text = "លេខ អត្តសញ្ញាណកម្ម"
        Me.ChIDCard.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1203, 641)
        Me.SplitContainer2.SplitterDistance = 226
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridKJB)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1201, 224)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ទិន្នន័យរបស់ គ-ជ-ប "
        '
        'GridKJB
        '
        Me.GridKJB.AllowColumnDrag = False
        Me.GridKJB.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridKJB_DesignTimeLayout.LayoutString = resources.GetString("GridKJB_DesignTimeLayout.LayoutString")
        Me.GridKJB.DesignTimeLayout = GridKJB_DesignTimeLayout
        Me.GridKJB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridKJB.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.GridKJB.GroupByBoxVisible = False
        Me.GridKJB.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridKJB.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridKJB.KeepRowSettings = True
        Me.GridKJB.Location = New System.Drawing.Point(3, 33)
        Me.GridKJB.Name = "GridKJB"
        Me.GridKJB.RecordNavigator = True
        Me.GridKJB.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridKJB.Size = New System.Drawing.Size(1195, 188)
        Me.GridKJB.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1201, 409)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1193, 364)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ទិន្នន័យមានក្នុង អត្ត.ប័ណ្ណ"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GridResult)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1183, 354)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "លទ្ធផល ផ្ទៀងផ្ទៀត (Double click on the row to see picture)"
        '
        'GridResult
        '
        Me.GridResult.AllowColumnDrag = False
        Me.GridResult.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridResult.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridResult_DesignTimeLayout.LayoutString = resources.GetString("GridResult_DesignTimeLayout.LayoutString")
        Me.GridResult.DesignTimeLayout = GridResult_DesignTimeLayout
        Me.GridResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridResult.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.GridResult.GroupByBoxVisible = False
        Me.GridResult.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridResult.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridResult.KeepRowSettings = True
        Me.GridResult.Location = New System.Drawing.Point(3, 33)
        Me.GridResult.Name = "GridResult"
        Me.GridResult.RecordNavigator = True
        Me.GridResult.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridResult.Size = New System.Drawing.Size(1177, 318)
        Me.GridResult.TabIndex = 1
        Me.GridResult.ThemedAreas = CType((((Janus.Windows.GridEX.ThemedArea.ScrollBars Or Janus.Windows.GridEX.ThemedArea.EditControls) _
                    Or Janus.Windows.GridEX.ThemedArea.Headers) _
                    Or Janus.Windows.GridEX.ThemedArea.GroupByBox), Janus.Windows.GridEX.ThemedArea)
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1193, 364)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ទិន្នន័យ គ្មានក្នុង អត្ត.ប័ណ្ណ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GridWrongResult)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Red
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1183, 354)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "លទ្ធផល ផ្ទៀងផ្ទៀត"
        '
        'GridWrongResult
        '
        Me.GridWrongResult.AllowColumnDrag = False
        Me.GridWrongResult.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridWrongResult.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        GridWrongResult_DesignTimeLayout.LayoutString = resources.GetString("GridWrongResult_DesignTimeLayout.LayoutString")
        Me.GridWrongResult.DesignTimeLayout = GridWrongResult_DesignTimeLayout
        Me.GridWrongResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridWrongResult.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!)
        Me.GridWrongResult.GroupByBoxVisible = False
        Me.GridWrongResult.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridWrongResult.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridWrongResult.KeepRowSettings = True
        Me.GridWrongResult.Location = New System.Drawing.Point(3, 33)
        Me.GridWrongResult.Name = "GridWrongResult"
        Me.GridWrongResult.RecordNavigator = True
        Me.GridWrongResult.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridWrongResult.Size = New System.Drawing.Size(1177, 318)
        Me.GridWrongResult.TabIndex = 2
        Me.GridWrongResult.ThemedAreas = CType((((Janus.Windows.GridEX.ThemedArea.ScrollBars Or Janus.Windows.GridEX.ThemedArea.EditControls) _
                    Or Janus.Windows.GridEX.ThemedArea.Headers) _
                    Or Janus.Windows.GridEX.ThemedArea.GroupByBox), Janus.Windows.GridEX.ThemedArea)
        '
        'BgLoadingReport
        '
        Me.BgLoadingReport.WorkerReportsProgress = True
        Me.BgLoadingReport.WorkerSupportsCancellation = True
        '
        'ElectionComparetion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ElectionComparetion"
        Me.Size = New System.Drawing.Size(1203, 811)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLoadSearching, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridKJB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.GridWrongResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChDOB As System.Windows.Forms.CheckBox
    Friend WithEvents ChSex As System.Windows.Forms.CheckBox
    Friend WithEvents ChName As System.Windows.Forms.CheckBox
    Friend WithEvents ChFamilyName As System.Windows.Forms.CheckBox
    Friend WithEvents ChIDCard As System.Windows.Forms.CheckBox
    Friend WithEvents GridKJB As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnVerify As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnScan As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LblWatching As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PicLoadSearching As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboProvince As System.Windows.Forms.ComboBox
    Friend WithEvents ChProvince As System.Windows.Forms.CheckBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridResult As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridWrongResult As Janus.Windows.GridEX.GridEX
    Friend WithEvents BtnReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
