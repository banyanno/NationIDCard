<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UIReport
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboDISTRICT = New System.Windows.Forms.ComboBox
        Me.cboVILLAGE = New System.Windows.Forms.ComboBox
        Me.cboPROVINCE = New System.Windows.Forms.ComboBox
        Me.cboCOMMUNE = New System.Windows.Forms.ComboBox
        Me.BtnPrintPreview = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DFrom = New System.Windows.Forms.DateTimePicker
        Me.DTo = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.cboDISTRICT)
        Me.GroupBox2.Controls.Add(Me.cboVILLAGE)
        Me.GroupBox2.Controls.Add(Me.cboPROVINCE)
        Me.GroupBox2.Controls.Add(Me.cboCOMMUNE)
        Me.GroupBox2.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(11, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 210)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "អាសយដ្ឋាន"
        '
        'cboDISTRICT
        '
        Me.cboDISTRICT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDISTRICT.Enabled = False
        Me.cboDISTRICT.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDISTRICT.FormattingEnabled = True
        Me.cboDISTRICT.Location = New System.Drawing.Point(9, 80)
        Me.cboDISTRICT.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboDISTRICT.Name = "cboDISTRICT"
        Me.cboDISTRICT.Size = New System.Drawing.Size(425, 32)
        Me.cboDISTRICT.TabIndex = 21
        '
        'cboVILLAGE
        '
        Me.cboVILLAGE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboVILLAGE.Enabled = False
        Me.cboVILLAGE.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVILLAGE.FormattingEnabled = True
        Me.cboVILLAGE.Location = New System.Drawing.Point(6, 165)
        Me.cboVILLAGE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboVILLAGE.Name = "cboVILLAGE"
        Me.cboVILLAGE.Size = New System.Drawing.Size(425, 32)
        Me.cboVILLAGE.TabIndex = 23
        '
        'cboPROVINCE
        '
        Me.cboPROVINCE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPROVINCE.Enabled = False
        Me.cboPROVINCE.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPROVINCE.FormattingEnabled = True
        Me.cboPROVINCE.Location = New System.Drawing.Point(9, 38)
        Me.cboPROVINCE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboPROVINCE.Name = "cboPROVINCE"
        Me.cboPROVINCE.Size = New System.Drawing.Size(425, 32)
        Me.cboPROVINCE.TabIndex = 20
        '
        'cboCOMMUNE
        '
        Me.cboCOMMUNE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCOMMUNE.Enabled = False
        Me.cboCOMMUNE.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOMMUNE.FormattingEnabled = True
        Me.cboCOMMUNE.Location = New System.Drawing.Point(6, 122)
        Me.cboCOMMUNE.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cboCOMMUNE.Name = "cboCOMMUNE"
        Me.cboCOMMUNE.Size = New System.Drawing.Size(425, 32)
        Me.cboCOMMUNE.TabIndex = 22
        '
        'BtnPrintPreview
        '
        Me.BtnPrintPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPrintPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrintPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrintPreview.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrintPreview.ForeColor = System.Drawing.Color.Blue
        Me.BtnPrintPreview.Location = New System.Drawing.Point(315, 318)
        Me.BtnPrintPreview.Name = "BtnPrintPreview"
        Me.BtnPrintPreview.Size = New System.Drawing.Size(136, 33)
        Me.BtnPrintPreview.TabIndex = 42
        Me.BtnPrintPreview.Text = "Print របាយការណ៏"
        Me.BtnPrintPreview.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Khmer OS Bokor", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1046, 47)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "របាយការណ៏"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 24)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "ចាប់ពីថ្ងៃ:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Khmer OS Battambang", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(230, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 24)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "រហូតដល់:"
        '
        'DFrom
        '
        Me.DFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DFrom.CustomFormat = "dd/MM/yyyy"
        Me.DFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DFrom.Location = New System.Drawing.Point(75, 74)
        Me.DFrom.Name = "DFrom"
        Me.DFrom.Size = New System.Drawing.Size(149, 26)
        Me.DFrom.TabIndex = 46
        '
        'DTo
        '
        Me.DTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTo.CustomFormat = "dd/MM/yyyy"
        Me.DTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTo.Location = New System.Drawing.Point(299, 74)
        Me.DTo.Name = "DTo"
        Me.DTo.Size = New System.Drawing.Size(149, 26)
        Me.DTo.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DFrom)
        Me.GroupBox1.Controls.Add(Me.DTo)
        Me.GroupBox1.Controls.Add(Me.BtnPrintPreview)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Khmer OS Battambang", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(33, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 357)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "របាយការណ៏ សុំកែតម្រូវ"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 47)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1046, 525)
        Me.SplitContainer1.SplitterDistance = 338
        Me.SplitContainer1.TabIndex = 50
        '
        'UIReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UIReport"
        Me.Size = New System.Drawing.Size(1046, 572)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents cboDISTRICT As System.Windows.Forms.ComboBox
    Private WithEvents cboVILLAGE As System.Windows.Forms.ComboBox
    Private WithEvents cboPROVINCE As System.Windows.Forms.ComboBox
    Private WithEvents cboCOMMUNE As System.Windows.Forms.ComboBox
    Friend WithEvents BtnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer

End Class
