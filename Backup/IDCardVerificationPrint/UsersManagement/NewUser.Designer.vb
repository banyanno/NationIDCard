<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewUser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblSaveOption = New System.Windows.Forms.Label
        Me.cboVILLAGE = New System.Windows.Forms.ComboBox
        Me.ChAdministrator = New System.Windows.Forms.CheckBox
        Me.cboCOMMUNE = New System.Windows.Forms.ComboBox
        Me.cboDISTRICT = New System.Windows.Forms.ComboBox
        Me.cboPROVINCE = New System.Windows.Forms.ComboBox
        Me.TxtVerPassword = New System.Windows.Forms.TextBox
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.UserName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancelk = New System.Windows.Forms.Button
        Me.ErrCheck = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TxtVerPassword)
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.UserName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 354)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Info"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LblSaveOption)
        Me.GroupBox2.Controls.Add(Me.cboVILLAGE)
        Me.GroupBox2.Controls.Add(Me.ChAdministrator)
        Me.GroupBox2.Controls.Add(Me.cboCOMMUNE)
        Me.GroupBox2.Controls.Add(Me.cboDISTRICT)
        Me.GroupBox2.Controls.Add(Me.cboPROVINCE)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(5, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(409, 220)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Permision Data Access"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Village:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Commune:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "District:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Province:"
        '
        'LblSaveOption
        '
        Me.LblSaveOption.AutoSize = True
        Me.LblSaveOption.ForeColor = System.Drawing.Color.Blue
        Me.LblSaveOption.Location = New System.Drawing.Point(219, 19)
        Me.LblSaveOption.Name = "LblSaveOption"
        Me.LblSaveOption.Size = New System.Drawing.Size(16, 17)
        Me.LblSaveOption.TabIndex = 7
        Me.LblSaveOption.Text = "0"
        Me.LblSaveOption.Visible = False
        '
        'cboVILLAGE
        '
        Me.cboVILLAGE.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVILLAGE.FormattingEnabled = True
        Me.cboVILLAGE.Location = New System.Drawing.Point(106, 181)
        Me.cboVILLAGE.Name = "cboVILLAGE"
        Me.cboVILLAGE.Size = New System.Drawing.Size(283, 30)
        Me.cboVILLAGE.TabIndex = 8
        '
        'ChAdministrator
        '
        Me.ChAdministrator.AutoSize = True
        Me.ChAdministrator.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChAdministrator.ForeColor = System.Drawing.Color.Red
        Me.ChAdministrator.Location = New System.Drawing.Point(11, 28)
        Me.ChAdministrator.Name = "ChAdministrator"
        Me.ChAdministrator.Size = New System.Drawing.Size(139, 24)
        Me.ChAdministrator.TabIndex = 0
        Me.ChAdministrator.Text = "Is Administrator"
        Me.ChAdministrator.UseVisualStyleBackColor = True
        '
        'cboCOMMUNE
        '
        Me.cboCOMMUNE.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCOMMUNE.FormattingEnabled = True
        Me.cboCOMMUNE.Location = New System.Drawing.Point(106, 142)
        Me.cboCOMMUNE.Name = "cboCOMMUNE"
        Me.cboCOMMUNE.Size = New System.Drawing.Size(283, 30)
        Me.cboCOMMUNE.TabIndex = 7
        '
        'cboDISTRICT
        '
        Me.cboDISTRICT.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDISTRICT.FormattingEnabled = True
        Me.cboDISTRICT.Location = New System.Drawing.Point(106, 105)
        Me.cboDISTRICT.Name = "cboDISTRICT"
        Me.cboDISTRICT.Size = New System.Drawing.Size(283, 30)
        Me.cboDISTRICT.TabIndex = 6
        '
        'cboPROVINCE
        '
        Me.cboPROVINCE.Font = New System.Drawing.Font("Khmer OS Battambang", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPROVINCE.FormattingEnabled = True
        Me.cboPROVINCE.Location = New System.Drawing.Point(105, 66)
        Me.cboPROVINCE.Name = "cboPROVINCE"
        Me.cboPROVINCE.Size = New System.Drawing.Size(283, 30)
        Me.cboPROVINCE.TabIndex = 5
        '
        'TxtVerPassword
        '
        Me.TxtVerPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtVerPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtVerPassword.Location = New System.Drawing.Point(139, 90)
        Me.TxtVerPassword.Name = "TxtVerPassword"
        Me.TxtVerPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtVerPassword.Size = New System.Drawing.Size(275, 26)
        Me.TxtVerPassword.TabIndex = 5
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(139, 57)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(275, 26)
        Me.TxtPassword.TabIndex = 4
        '
        'UserName
        '
        Me.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.Location = New System.Drawing.Point(139, 25)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(275, 26)
        Me.UserName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(7, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(7, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name Log In:"
        '
        'BtnSave
        '
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Location = New System.Drawing.Point(256, 366)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(94, 30)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnCancelk
        '
        Me.BtnCancelk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelk.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelk.Location = New System.Drawing.Point(352, 366)
        Me.BtnCancelk.Name = "BtnCancelk"
        Me.BtnCancelk.Size = New System.Drawing.Size(89, 30)
        Me.BtnCancelk.TabIndex = 2
        Me.BtnCancelk.Text = "Cancel"
        Me.BtnCancelk.UseVisualStyleBackColor = True
        '
        'ErrCheck
        '
        Me.ErrCheck.ContainerControl = Me
        '
        'NewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 403)
        Me.Controls.Add(Me.BtnCancelk)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewUser"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtVerPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboVILLAGE As System.Windows.Forms.ComboBox
    Friend WithEvents cboCOMMUNE As System.Windows.Forms.ComboBox
    Friend WithEvents cboDISTRICT As System.Windows.Forms.ComboBox
    Friend WithEvents cboPROVINCE As System.Windows.Forms.ComboBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnCancelk As System.Windows.Forms.Button
    Friend WithEvents ChAdministrator As System.Windows.Forms.CheckBox
    Friend WithEvents ErrCheck As System.Windows.Forms.ErrorProvider
    Friend WithEvents LblSaveOption As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
