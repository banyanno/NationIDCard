<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IDCardStatistic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IDCardStatistic))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.ChAllCondition = New System.Windows.Forms.CheckBox
        Me.TxtTotalRegis = New System.Windows.Forms.TextBox
        Me.BtnGiveData = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CboStatus = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateCalculate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.SexFemale = New System.Windows.Forms.RadioButton
        Me.SexMal = New System.Windows.Forms.RadioButton
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cboDISTRICT = New System.Windows.Forms.ComboBox
        Me.cboVILLAGE = New System.Windows.Forms.ComboBox
        Me.cboPROVINCE = New System.Windows.Forms.ComboBox
        Me.cboCOMMUNE = New System.Windows.Forms.ComboBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnPrintReport = New System.Windows.Forms.ToolStripButton
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ChDetail = New System.Windows.Forms.CheckBox
        Me.ChAll = New System.Windows.Forms.CheckBox
        Me.BgLoadingReport = New System.ComponentModel.BackgroundWorker
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChAllCondition)
        Me.GroupBox3.Controls.Add(Me.TxtTotalRegis)
        Me.GroupBox3.Controls.Add(Me.BtnGiveData)
        Me.GroupBox3.Controls.Add(Me.CboStatus)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.DateCalculate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(3, 14)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(525, 383)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "របាយការណ៍ ស្ថិតិ"
        '
        'ChAllCondition
        '
        Me.ChAllCondition.AutoSize = True
        Me.ChAllCondition.Location = New System.Drawing.Point(284, 30)
        Me.ChAllCondition.Name = "ChAllCondition"
        Me.ChAllCondition.Size = New System.Drawing.Size(112, 31)
        Me.ChAllCondition.TabIndex = 57
        Me.ChAllCondition.Text = "គ្រប់ល័ក្ខខ័ណ្ឌ"
        Me.ChAllCondition.UseVisualStyleBackColor = True
        '
        'TxtTotalRegis
        '
        Me.TxtTotalRegis.BackColor = System.Drawing.Color.White
        Me.TxtTotalRegis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotalRegis.Font = New System.Drawing.Font("Khmer OS Battambang", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalRegis.ForeColor = System.Drawing.Color.Red
        Me.TxtTotalRegis.Location = New System.Drawing.Point(18, 259)
        Me.TxtTotalRegis.Name = "TxtTotalRegis"
        Me.TxtTotalRegis.ReadOnly = True
        Me.TxtTotalRegis.Size = New System.Drawing.Size(489, 70)
        Me.TxtTotalRegis.TabIndex = 56
        Me.TxtTotalRegis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnGiveData
        '
        Me.BtnGiveData.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGiveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGiveData.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGiveData.ImageIndex = 0
        Me.BtnGiveData.ImageList = Me.ImageList1
        Me.BtnGiveData.Location = New System.Drawing.Point(18, 180)
        Me.BtnGiveData.Name = "BtnGiveData"
        Me.BtnGiveData.Size = New System.Drawing.Size(489, 73)
        Me.BtnGiveData.TabIndex = 54
        Me.BtnGiveData.Text = "ចំនួន ទិន្នន័យផ្តល់អត្តសញាញប័ណ្ណ"
        Me.BtnGiveData.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGiveData.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Hand Down-32.png")
        '
        'CboStatus
        '
        Me.CboStatus.FormattingEnabled = True
        Me.CboStatus.Items.AddRange(New Object() {"260", "220", "180", "160"})
        Me.CboStatus.Location = New System.Drawing.Point(398, 26)
        Me.CboStatus.Name = "CboStatus"
        Me.CboStatus.Size = New System.Drawing.Size(109, 35)
        Me.CboStatus.TabIndex = 53
        Me.CboStatus.Text = "260"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.DFrom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(18, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 98)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ថ្ងៃផ្តល់អត្តសញ្ញាណប័ណ្ណ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IDCardVerificationPrint.My.Resources.Resources.loading_bar11
        Me.PictureBox1.Location = New System.Drawing.Point(326, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 18)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'DFrom
        '
        Me.DFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(95, 37)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(149, 26)
        Me.DFrom.TabIndex = 46
        Me.DFrom.Value = New Date(2012, 6, 1, 9, 28, 0, 0)
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(31, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 24)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "ចាប់ពីថ្ងៃ:"
        '
        'DTo
        '
        Me.DTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(327, 37)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(149, 26)
        Me.DTo.TabIndex = 47
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(258, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 24)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "រហូតដល់:"
        '
        'DateCalculate
        '
        Me.DateCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateCalculate.CustomFormat = "dd/MM/yyyy"
        Me.DateCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCalculate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateCalculate.Location = New System.Drawing.Point(117, 35)
        Me.DateCalculate.Name = "DateCalculate"
        Me.DateCalculate.Size = New System.Drawing.Size(149, 26)
        Me.DateCalculate.TabIndex = 49
        Me.DateCalculate.Value = New Date(2017, 6, 4, 23, 15, 0, 0)
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(20, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 24)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "ថ្ងៃគណនាអាយុ"
        '
        'SexFemale
        '
        Me.SexFemale.AutoSize = True
        Me.SexFemale.Location = New System.Drawing.Point(616, 273)
        Me.SexFemale.Name = "SexFemale"
        Me.SexFemale.Size = New System.Drawing.Size(34, 17)
        Me.SexFemale.TabIndex = 52
        Me.SexFemale.Text = "ស្រី"
        Me.SexFemale.UseVisualStyleBackColor = True
        Me.SexFemale.Visible = False
        '
        'SexMal
        '
        Me.SexMal.AutoSize = True
        Me.SexMal.Checked = True
        Me.SexMal.Location = New System.Drawing.Point(569, 271)
        Me.SexMal.Name = "SexMal"
        Me.SexMal.Size = New System.Drawing.Size(41, 17)
        Me.SexMal.TabIndex = 51
        Me.SexMal.TabStop = True
        Me.SexMal.Text = "ប្រុស"
        Me.SexMal.UseVisualStyleBackColor = True
        Me.SexMal.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cboDISTRICT)
        Me.GroupBox4.Controls.Add(Me.cboVILLAGE)
        Me.GroupBox4.Controls.Add(Me.cboPROVINCE)
        Me.GroupBox4.Controls.Add(Me.cboCOMMUNE)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(545, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(489, 210)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "អាសយដ្ឋាន"
        '
        'cboDISTRICT
        '
        Me.cboDISTRICT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDISTRICT.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDISTRICT.FormattingEnabled = True
        Me.cboDISTRICT.Location = New System.Drawing.Point(9, 80)
        Me.cboDISTRICT.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboDISTRICT.Name = "cboDISTRICT"
        Me.cboDISTRICT.Size = New System.Drawing.Size(474, 32)
        Me.cboDISTRICT.TabIndex = 21
        '
        'cboVILLAGE
        '
        Me.cboVILLAGE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboVILLAGE.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVILLAGE.FormattingEnabled = True
        Me.cboVILLAGE.Location = New System.Drawing.Point(9, 165)
        Me.cboVILLAGE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboVILLAGE.Name = "cboVILLAGE"
        Me.cboVILLAGE.Size = New System.Drawing.Size(474, 32)
        Me.cboVILLAGE.TabIndex = 23
        '
        'cboPROVINCE
        '
        Me.cboPROVINCE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPROVINCE.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPROVINCE.FormattingEnabled = True
        Me.cboPROVINCE.Location = New System.Drawing.Point(9, 38)
        Me.cboPROVINCE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboPROVINCE.Name = "cboPROVINCE"
        Me.cboPROVINCE.Size = New System.Drawing.Size(474, 32)
        Me.cboPROVINCE.TabIndex = 20
        '
        'cboCOMMUNE
        '
        Me.cboCOMMUNE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCOMMUNE.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOMMUNE.FormattingEnabled = True
        Me.cboCOMMUNE.Location = New System.Drawing.Point(9, 122)
        Me.cboCOMMUNE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboCOMMUNE.Name = "cboCOMMUNE"
        Me.cboCOMMUNE.Size = New System.Drawing.Size(474, 32)
        Me.cboCOMMUNE.TabIndex = 22
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BtnPrintReport})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1044, 34)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
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
        Me.BtnPrintReport.Size = New System.Drawing.Size(151, 31)
        Me.BtnPrintReport.Text = "Print របាយការណ៍"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 34)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChDetail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ChAll)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SexFemale)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SexMal)
        Me.SplitContainer1.Size = New System.Drawing.Size(1044, 550)
        Me.SplitContainer1.SplitterDistance = 390
        Me.SplitContainer1.TabIndex = 52
        '
        'ChDetail
        '
        Me.ChDetail.AutoSize = True
        Me.ChDetail.Enabled = False
        Me.ChDetail.Location = New System.Drawing.Point(545, 49)
        Me.ChDetail.Name = "ChDetail"
        Me.ChDetail.Size = New System.Drawing.Size(86, 17)
        Me.ChDetail.TabIndex = 52
        Me.ChDetail.Text = "Show Detail "
        Me.ChDetail.UseVisualStyleBackColor = True
        '
        'ChAll
        '
        Me.ChAll.AutoSize = True
        Me.ChAll.Checked = True
        Me.ChAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChAll.Location = New System.Drawing.Point(545, 7)
        Me.ChAll.Name = "ChAll"
        Me.ChAll.Size = New System.Drawing.Size(112, 17)
        Me.ChAll.TabIndex = 51
        Me.ChAll.Text = "Show All Province"
        Me.ChAll.UseVisualStyleBackColor = True
        '
        'BgLoadingReport
        '
        Me.BgLoadingReport.WorkerReportsProgress = True
        Me.BgLoadingReport.WorkerSupportsCancellation = True
        '
        'IDCardStatistic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "IDCardStatistic"
        Me.Size = New System.Drawing.Size(1044, 584)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DateCalculate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents cboDISTRICT As System.Windows.Forms.ComboBox
    Private WithEvents cboVILLAGE As System.Windows.Forms.ComboBox
    Private WithEvents cboPROVINCE As System.Windows.Forms.ComboBox
    Private WithEvents cboCOMMUNE As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnPrintReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SexFemale As System.Windows.Forms.RadioButton
    Friend WithEvents SexMal As System.Windows.Forms.RadioButton
    Friend WithEvents BgLoadingReport As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents ChAll As System.Windows.Forms.CheckBox
    Friend WithEvents BtnGiveData As System.Windows.Forms.Button
    Friend WithEvents TxtTotalRegis As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ChAllCondition As System.Windows.Forms.CheckBox
    Friend WithEvents ChDetail As System.Windows.Forms.CheckBox

End Class
