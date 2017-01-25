<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchPeople
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchPeople))
        Dim GridPeopleValiate_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Ch6 = New System.Windows.Forms.CheckBox
        Me.Ch5 = New System.Windows.Forms.CheckBox
        Me.Ch4 = New System.Windows.Forms.CheckBox
        Me.Ch3 = New System.Windows.Forms.CheckBox
        Me.Ch2 = New System.Windows.Forms.CheckBox
        Me.Ch1 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnFind = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboDISTRICT = New System.Windows.Forms.ComboBox
        Me.cboVILLAGE = New System.Windows.Forms.ComboBox
        Me.cboPROVINCE = New System.Windows.Forms.ComboBox
        Me.cboCOMMUNE = New System.Windows.Forms.ComboBox
        Me.PicValuce = New System.Windows.Forms.PictureBox
        Me.TxtSFirstLatinName = New System.Windows.Forms.TextBox
        Me.TxtFirstKhName = New System.Windows.Forms.TextBox
        Me.txtDocCode = New System.Windows.Forms.TextBox
        Me.GridPeopleValiate = New Janus.Windows.GridEX.GridEX
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.uiPanel1 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel1CaptionContainer = New Janus.Windows.UI.Dock.UIPanelCaptionContainer
        Me.uiPanel1Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.TxtLastLatin = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtKhLastName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Ch7 = New System.Windows.Forms.CheckBox
        Me.cboSex = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel0Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnCompare = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintReport = New System.Windows.Forms.ToolStripButton
        Me.BgPayment = New System.ComponentModel.BackgroundWorker
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicValuce, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPeopleValiate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel1.SuspendLayout()
        Me.uiPanel1Container.SuspendLayout()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        Me.uiPanel0Container.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Ch6
        '
        Me.Ch6.AutoSize = True
        Me.Ch6.BackColor = System.Drawing.Color.Transparent
        Me.Ch6.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch6.ForeColor = System.Drawing.Color.Blue
        Me.Ch6.Location = New System.Drawing.Point(911, 144)
        Me.Ch6.Name = "Ch6"
        Me.Ch6.Size = New System.Drawing.Size(153, 33)
        Me.Ch6.TabIndex = 60
        Me.Ch6.Text = "6. ខុសអាសយដ្ឋាន"
        Me.Ch6.UseVisualStyleBackColor = False
        '
        'Ch5
        '
        Me.Ch5.AutoSize = True
        Me.Ch5.BackColor = System.Drawing.Color.Transparent
        Me.Ch5.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch5.ForeColor = System.Drawing.Color.Blue
        Me.Ch5.Location = New System.Drawing.Point(734, 143)
        Me.Ch5.Name = "Ch5"
        Me.Ch5.Size = New System.Drawing.Size(175, 33)
        Me.Ch5.TabIndex = 59
        Me.Ch5.Text = "5. ខុសទីកន្លែងកំណើត"
        Me.Ch5.UseVisualStyleBackColor = False
        '
        'Ch4
        '
        Me.Ch4.AutoSize = True
        Me.Ch4.BackColor = System.Drawing.Color.Transparent
        Me.Ch4.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch4.ForeColor = System.Drawing.Color.Blue
        Me.Ch4.Location = New System.Drawing.Point(911, 106)
        Me.Ch4.Name = "Ch4"
        Me.Ch4.Size = New System.Drawing.Size(104, 33)
        Me.Ch4.TabIndex = 58
        Me.Ch4.Text = "4. ខុសភេទ"
        Me.Ch4.UseVisualStyleBackColor = False
        '
        'Ch3
        '
        Me.Ch3.AutoSize = True
        Me.Ch3.BackColor = System.Drawing.Color.Transparent
        Me.Ch3.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch3.ForeColor = System.Drawing.Color.Blue
        Me.Ch3.Location = New System.Drawing.Point(735, 105)
        Me.Ch3.Name = "Ch3"
        Me.Ch3.Size = New System.Drawing.Size(174, 33)
        Me.Ch3.TabIndex = 57
        Me.Ch3.Text = "3. ខុសថ្ងៃខែឆ្នាំកំណើត"
        Me.Ch3.UseVisualStyleBackColor = False
        '
        'Ch2
        '
        Me.Ch2.AutoSize = True
        Me.Ch2.BackColor = System.Drawing.Color.Transparent
        Me.Ch2.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch2.ForeColor = System.Drawing.Color.Blue
        Me.Ch2.Location = New System.Drawing.Point(911, 70)
        Me.Ch2.Name = "Ch2"
        Me.Ch2.Size = New System.Drawing.Size(126, 33)
        Me.Ch2.TabIndex = 56
        Me.Ch2.Text = "2. ខុសឡាតាំង"
        Me.Ch2.UseVisualStyleBackColor = False
        '
        'Ch1
        '
        Me.Ch1.AutoSize = True
        Me.Ch1.BackColor = System.Drawing.Color.Transparent
        Me.Ch1.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch1.ForeColor = System.Drawing.Color.Blue
        Me.Ch1.Location = New System.Drawing.Point(734, 70)
        Me.Ch1.Name = "Ch1"
        Me.Ch1.Size = New System.Drawing.Size(116, 33)
        Me.Ch1.TabIndex = 55
        Me.Ch1.Text = "1. ខុសឈ្មោះ"
        Me.Ch1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(5, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 25)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "គោត្តនាម ឡាតាំង"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(5, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 25)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "គោត្តនាម"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(239, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "អត្ត.ប័ណ្ណ"
        '
        'BtnFind
        '
        Me.BtnFind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFind.Font = New System.Drawing.Font("Khmer OS Battambang", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFind.ForeColor = System.Drawing.Color.Red
        Me.BtnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnFind.ImageIndex = 0
        Me.BtnFind.ImageList = Me.ImageList1
        Me.BtnFind.Location = New System.Drawing.Point(734, 225)
        Me.BtnFind.Name = "BtnFind"
        Me.BtnFind.Size = New System.Drawing.Size(330, 42)
        Me.BtnFind.TabIndex = 48
        Me.BtnFind.Text = "ស្វែង រក"
        Me.BtnFind.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "1454074318_icon-111-search.ico")
        Me.ImageList1.Images.SetKeyName(1, "1454074346_icon-136-document-edit.ico")
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cboDISTRICT)
        Me.GroupBox2.Controls.Add(Me.cboVILLAGE)
        Me.GroupBox2.Controls.Add(Me.cboPROVINCE)
        Me.GroupBox2.Controls.Add(Me.cboCOMMUNE)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(3, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(441, 238)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "អាសយដ្ឋាន"
        '
        'cboDISTRICT
        '
        Me.cboDISTRICT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDISTRICT.Enabled = False
        Me.cboDISTRICT.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDISTRICT.FormattingEnabled = True
        Me.cboDISTRICT.Location = New System.Drawing.Point(9, 77)
        Me.cboDISTRICT.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboDISTRICT.Name = "cboDISTRICT"
        Me.cboDISTRICT.Size = New System.Drawing.Size(426, 42)
        Me.cboDISTRICT.TabIndex = 21
        '
        'cboVILLAGE
        '
        Me.cboVILLAGE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboVILLAGE.Enabled = False
        Me.cboVILLAGE.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVILLAGE.FormattingEnabled = True
        Me.cboVILLAGE.Location = New System.Drawing.Point(9, 175)
        Me.cboVILLAGE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboVILLAGE.Name = "cboVILLAGE"
        Me.cboVILLAGE.Size = New System.Drawing.Size(426, 42)
        Me.cboVILLAGE.TabIndex = 23
        '
        'cboPROVINCE
        '
        Me.cboPROVINCE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPROVINCE.Enabled = False
        Me.cboPROVINCE.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPROVINCE.FormattingEnabled = True
        Me.cboPROVINCE.Location = New System.Drawing.Point(9, 30)
        Me.cboPROVINCE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboPROVINCE.Name = "cboPROVINCE"
        Me.cboPROVINCE.Size = New System.Drawing.Size(426, 42)
        Me.cboPROVINCE.TabIndex = 20
        '
        'cboCOMMUNE
        '
        Me.cboCOMMUNE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCOMMUNE.Enabled = False
        Me.cboCOMMUNE.Font = New System.Drawing.Font("Khmer OS Battambang", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOMMUNE.FormattingEnabled = True
        Me.cboCOMMUNE.Location = New System.Drawing.Point(9, 126)
        Me.cboCOMMUNE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboCOMMUNE.Name = "cboCOMMUNE"
        Me.cboCOMMUNE.Size = New System.Drawing.Size(426, 42)
        Me.cboCOMMUNE.TabIndex = 22
        '
        'PicValuce
        '
        Me.PicValuce.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicValuce.Location = New System.Drawing.Point(472, 13)
        Me.PicValuce.Name = "PicValuce"
        Me.PicValuce.Size = New System.Drawing.Size(215, 270)
        Me.PicValuce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicValuce.TabIndex = 47
        Me.PicValuce.TabStop = False
        '
        'TxtSFirstLatinName
        '
        Me.TxtSFirstLatinName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSFirstLatinName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSFirstLatinName.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSFirstLatinName.Location = New System.Drawing.Point(116, 129)
        Me.TxtSFirstLatinName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtSFirstLatinName.Name = "TxtSFirstLatinName"
        Me.TxtSFirstLatinName.Size = New System.Drawing.Size(328, 32)
        Me.TxtSFirstLatinName.TabIndex = 36
        '
        'TxtFirstKhName
        '
        Me.TxtFirstKhName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFirstKhName.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirstKhName.Location = New System.Drawing.Point(98, 51)
        Me.TxtFirstKhName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtFirstKhName.Name = "TxtFirstKhName"
        Me.TxtFirstKhName.Size = New System.Drawing.Size(346, 32)
        Me.TxtFirstKhName.TabIndex = 34
        '
        'txtDocCode
        '
        Me.txtDocCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocCode.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocCode.Location = New System.Drawing.Point(305, 14)
        Me.txtDocCode.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtDocCode.Name = "txtDocCode"
        Me.txtDocCode.Size = New System.Drawing.Size(139, 32)
        Me.txtDocCode.TabIndex = 32
        '
        'GridPeopleValiate
        '
        Me.GridPeopleValiate.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridPeopleValiate.DataSource = Me.GridPeopleValiate.Layouts
        GridPeopleValiate_DesignTimeLayout.LayoutString = resources.GetString("GridPeopleValiate_DesignTimeLayout.LayoutString")
        Me.GridPeopleValiate.DesignTimeLayout = GridPeopleValiate_DesignTimeLayout
        Me.GridPeopleValiate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPeopleValiate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GridPeopleValiate.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid
        Me.GridPeopleValiate.GroupByBoxVisible = False
        Me.GridPeopleValiate.HeaderFormatStyle.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.GridPeopleValiate.HeaderFormatStyle.FontSize = 12.0!
        Me.GridPeopleValiate.HeaderFormatStyle.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        Me.GridPeopleValiate.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridPeopleValiate.Location = New System.Drawing.Point(0, 34)
        Me.GridPeopleValiate.Name = "GridPeopleValiate"
        Me.GridPeopleValiate.RecordNavigator = True
        Me.GridPeopleValiate.Size = New System.Drawing.Size(1120, 131)
        Me.GridPeopleValiate.TabIndex = 0
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.AllowAutoHideAnimation = False
        Me.UiPanelManager1.AllowPanelDrag = False
        Me.UiPanelManager1.AllowPanelDrop = False
        Me.UiPanelManager1.ContainerControl = Me
        Me.uiPanel1.Id = New System.Guid("d920c8e0-33b0-4a69-9969-c5c7950e36b3")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel1)
        Me.uiPanel0.Id = New System.Guid("a147814b-6098-4a65-9e52-b457e80ecbae")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel0)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("a147814b-6098-4a65-9e52-b457e80ecbae"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, New System.Drawing.Size(1122, 167), True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("d920c8e0-33b0-4a69-9969-c5c7950e36b3"), Janus.Windows.UI.Dock.PanelDockStyle.Bottom, New System.Drawing.Size(1122, 530), True)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("d920c8e0-33b0-4a69-9969-c5c7950e36b3"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("a147814b-6098-4a65-9e52-b457e80ecbae"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'uiPanel1
        '
        Me.uiPanel1.CaptionFormatStyle.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uiPanel1.CaptionFormatStyle.FontSize = 12.0!
        Me.uiPanel1.CaptionFormatStyle.ForeColor = System.Drawing.Color.White
        Me.uiPanel1.CaptionHeight = 25
        Me.uiPanel1.CaptionStyle = Janus.Windows.UI.Dock.PanelCaptionStyle.Dark
        Me.uiPanel1.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel1.ContainerCaption = True
        Me.uiPanel1.ContainerCaptionControl = Me.uiPanel1CaptionContainer
        Me.uiPanel1.ForeColor = System.Drawing.Color.Red
        Me.uiPanel1.InnerContainer = Me.uiPanel1Container
        Me.uiPanel1.Location = New System.Drawing.Point(3, 170)
        Me.uiPanel1.Name = "uiPanel1"
        Me.uiPanel1.Size = New System.Drawing.Size(1122, 530)
        Me.uiPanel1.TabIndex = 4
        Me.uiPanel1.Text = "ស្វែងរក ទិន្នន័យកែតម្រូវ"
        '
        'uiPanel1CaptionContainer
        '
        Me.uiPanel1CaptionContainer.Location = New System.Drawing.Point(0, 4)
        Me.uiPanel1CaptionContainer.Name = "uiPanel1CaptionContainer"
        Me.uiPanel1CaptionContainer.Panel = Me.uiPanel1
        Me.uiPanel1CaptionContainer.Size = New System.Drawing.Size(1122, 25)
        Me.uiPanel1CaptionContainer.TabIndex = 1
        '
        'uiPanel1Container
        '
        Me.uiPanel1Container.AutoScroll = True
        Me.uiPanel1Container.Controls.Add(Me.TxtLastLatin)
        Me.uiPanel1Container.Controls.Add(Me.Label9)
        Me.uiPanel1Container.Controls.Add(Me.TxtKhLastName)
        Me.uiPanel1Container.Controls.Add(Me.Label8)
        Me.uiPanel1Container.Controls.Add(Me.Label7)
        Me.uiPanel1Container.Controls.Add(Me.txtBarcode)
        Me.uiPanel1Container.Controls.Add(Me.Ch7)
        Me.uiPanel1Container.Controls.Add(Me.cboSex)
        Me.uiPanel1Container.Controls.Add(Me.Label6)
        Me.uiPanel1Container.Controls.Add(Me.DTo)
        Me.uiPanel1Container.Controls.Add(Me.DFrom)
        Me.uiPanel1Container.Controls.Add(Me.Label5)
        Me.uiPanel1Container.Controls.Add(Me.Label4)
        Me.uiPanel1Container.Controls.Add(Me.Ch6)
        Me.uiPanel1Container.Controls.Add(Me.Ch5)
        Me.uiPanel1Container.Controls.Add(Me.Label1)
        Me.uiPanel1Container.Controls.Add(Me.Ch4)
        Me.uiPanel1Container.Controls.Add(Me.txtDocCode)
        Me.uiPanel1Container.Controls.Add(Me.Ch3)
        Me.uiPanel1Container.Controls.Add(Me.TxtFirstKhName)
        Me.uiPanel1Container.Controls.Add(Me.Ch2)
        Me.uiPanel1Container.Controls.Add(Me.TxtSFirstLatinName)
        Me.uiPanel1Container.Controls.Add(Me.Ch1)
        Me.uiPanel1Container.Controls.Add(Me.BtnFind)
        Me.uiPanel1Container.Controls.Add(Me.Label2)
        Me.uiPanel1Container.Controls.Add(Me.Label3)
        Me.uiPanel1Container.Controls.Add(Me.GroupBox2)
        Me.uiPanel1Container.Controls.Add(Me.PicValuce)
        Me.uiPanel1Container.Location = New System.Drawing.Point(1, 29)
        Me.uiPanel1Container.Name = "uiPanel1Container"
        Me.uiPanel1Container.Size = New System.Drawing.Size(1120, 500)
        Me.uiPanel1Container.TabIndex = 0
        '
        'TxtLastLatin
        '
        Me.TxtLastLatin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLastLatin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLastLatin.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLastLatin.Location = New System.Drawing.Point(98, 170)
        Me.TxtLastLatin.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtLastLatin.Name = "TxtLastLatin"
        Me.TxtLastLatin.Size = New System.Drawing.Size(346, 32)
        Me.TxtLastLatin.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(5, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 25)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "នាមឡាតាំង"
        '
        'TxtKhLastName
        '
        Me.TxtKhLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtKhLastName.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKhLastName.Location = New System.Drawing.Point(98, 88)
        Me.TxtKhLastName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TxtKhLastName.Name = "TxtKhLastName"
        Me.TxtKhLastName.Size = New System.Drawing.Size(346, 32)
        Me.TxtKhLastName.TabIndex = 71
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(5, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 25)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "នាម"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(5, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 25)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "សលាកបត្រ"
        '
        'txtBarcode
        '
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBarcode.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(98, 14)
        Me.txtBarcode.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(138, 32)
        Me.txtBarcode.TabIndex = 68
        '
        'Ch7
        '
        Me.Ch7.AutoSize = True
        Me.Ch7.BackColor = System.Drawing.Color.Transparent
        Me.Ch7.Font = New System.Drawing.Font("Khmer OS Battambang", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ch7.ForeColor = System.Drawing.Color.Blue
        Me.Ch7.Location = New System.Drawing.Point(911, 183)
        Me.Ch7.Name = "Ch7"
        Me.Ch7.Size = New System.Drawing.Size(138, 33)
        Me.Ch7.TabIndex = 67
        Me.Ch7.Text = "7. ទិន្នន័យដូចគ្នា"
        Me.Ch7.UseVisualStyleBackColor = False
        '
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"", "ស្រី", "ប្រុស"})
        Me.cboSex.Location = New System.Drawing.Point(98, 211)
        Me.cboSex.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(92, 32)
        Me.cboSex.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(46, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 25)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "ភេទ"
        '
        'DTo
        '
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(895, 33)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(144, 26)
        Me.DTo.TabIndex = 64
        '
        'DFrom
        '
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(736, 33)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(142, 26)
        Me.DFrom.TabIndex = 63
        Me.DFrom.Value = New Date(2000, 1, 1, 13, 31, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(934, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 27)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "រហូតដល់"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(735, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 27)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "ស្រង់ទិន្នន័យ"
        '
        'uiPanel0
        '
        Me.uiPanel0.CaptionFormatStyle.FontSize = 12.0!
        Me.uiPanel0.CaptionFormatStyle.ForeColor = System.Drawing.Color.Red
        Me.uiPanel0.CaptionVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel0.InfoTextFormatStyle.FontSize = 12.0!
        Me.uiPanel0.InnerContainer = Me.uiPanel0Container
        Me.uiPanel0.Location = New System.Drawing.Point(3, 3)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.Size = New System.Drawing.Size(1122, 167)
        Me.uiPanel0.TabIndex = 4
        Me.uiPanel0.TabStateStyles.DisabledFormatStyle.FontSize = 12.0!
        Me.uiPanel0.TabStateStyles.FormatStyle.ForeColor = System.Drawing.Color.Red
        Me.uiPanel0.Text = "People Information"
        '
        'uiPanel0Container
        '
        Me.uiPanel0Container.Controls.Add(Me.GridPeopleValiate)
        Me.uiPanel0Container.Controls.Add(Me.ToolStrip1)
        Me.uiPanel0Container.Location = New System.Drawing.Point(1, 1)
        Me.uiPanel0Container.Name = "uiPanel0Container"
        Me.uiPanel0Container.Size = New System.Drawing.Size(1120, 165)
        Me.uiPanel0Container.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCompare, Me.ToolStripSeparator1, Me.BtnPrintReport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1120, 34)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCompare
        '
        Me.btnCompare.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompare.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCompare.Image = Global.IDCardVerificationPrint.My.Resources.Resources.icon
        Me.btnCompare.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(106, 31)
        Me.btnCompare.Text = "ប្រៀបធៀប"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 34)
        '
        'BtnPrintReport
        '
        Me.BtnPrintReport.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!)
        Me.BtnPrintReport.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPrintReport.Image = Global.IDCardVerificationPrint.My.Resources.Resources.social
        Me.BtnPrintReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrintReport.Name = "BtnPrintReport"
        Me.BtnPrintReport.Size = New System.Drawing.Size(186, 31)
        Me.BtnPrintReport.Text = "របាយការណ៏ ប្រៀបធៀប"
        '
        'BgPayment
        '
        Me.BgPayment.WorkerReportsProgress = True
        Me.BgPayment.WorkerSupportsCancellation = True
        '
        'SearchPeople
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.uiPanel0)
        Me.Controls.Add(Me.uiPanel1)
        Me.Name = "SearchPeople"
        Me.Size = New System.Drawing.Size(1128, 703)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicValuce, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPeopleValiate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel1.ResumeLayout(False)
        Me.uiPanel1Container.ResumeLayout(False)
        Me.uiPanel1Container.PerformLayout()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        Me.uiPanel0Container.ResumeLayout(False)
        Me.uiPanel0Container.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtDocCode As System.Windows.Forms.TextBox
    Private WithEvents TxtFirstKhName As System.Windows.Forms.TextBox
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cboDISTRICT As System.Windows.Forms.ComboBox
    Private WithEvents cboVILLAGE As System.Windows.Forms.ComboBox
    Private WithEvents cboPROVINCE As System.Windows.Forms.ComboBox
    Private WithEvents cboCOMMUNE As System.Windows.Forms.ComboBox
    Friend WithEvents GridPeopleValiate As Janus.Windows.GridEX.GridEX
    Private WithEvents TxtSFirstLatinName As System.Windows.Forms.TextBox
    Friend WithEvents PicValuce As System.Windows.Forms.PictureBox
    Friend WithEvents BtnFind As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Ch6 As System.Windows.Forms.CheckBox
    Friend WithEvents Ch5 As System.Windows.Forms.CheckBox
    Friend WithEvents Ch4 As System.Windows.Forms.CheckBox
    Friend WithEvents Ch3 As System.Windows.Forms.CheckBox
    Friend WithEvents Ch2 As System.Windows.Forms.CheckBox
    Friend WithEvents Ch1 As System.Windows.Forms.CheckBox
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents uiPanel1 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel1Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Ch7 As System.Windows.Forms.CheckBox
    Friend WithEvents BgPayment As System.ComponentModel.BackgroundWorker
    Friend WithEvents uiPanel1CaptionContainer As Janus.Windows.UI.Dock.UIPanelCaptionContainer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtBarcode As System.Windows.Forms.TextBox
    Private WithEvents TxtLastLatin As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents TxtKhLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnCompare As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintReport As System.Windows.Forms.ToolStripButton

End Class
