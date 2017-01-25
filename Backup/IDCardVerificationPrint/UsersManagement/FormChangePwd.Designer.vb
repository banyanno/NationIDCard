<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChangePwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormChangePwd))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtConfirmPwd = New System.Windows.Forms.TextBox
        Me.TxtNewPwd = New System.Windows.Forms.TextBox
        Me.TxtUsers = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnReset = New System.Windows.Forms.Button
        Me.LblSave = New System.Windows.Forms.Label
        Me.ErrSetPwd = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrSetPwd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtConfirmPwd)
        Me.GroupBox1.Controls.Add(Me.TxtNewPwd)
        Me.GroupBox1.Controls.Add(Me.TxtUsers)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(2, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtConfirmPwd
        '
        Me.TxtConfirmPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtConfirmPwd.Location = New System.Drawing.Point(168, 97)
        Me.TxtConfirmPwd.Name = "TxtConfirmPwd"
        Me.TxtConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtConfirmPwd.Size = New System.Drawing.Size(209, 26)
        Me.TxtConfirmPwd.TabIndex = 5
        '
        'TxtNewPwd
        '
        Me.TxtNewPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNewPwd.Location = New System.Drawing.Point(168, 59)
        Me.TxtNewPwd.Name = "TxtNewPwd"
        Me.TxtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewPwd.Size = New System.Drawing.Size(209, 26)
        Me.TxtNewPwd.TabIndex = 4
        '
        'TxtUsers
        '
        Me.TxtUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUsers.Location = New System.Drawing.Point(168, 20)
        Me.TxtUsers.Name = "TxtUsers"
        Me.TxtUsers.ReadOnly = True
        Me.TxtUsers.Size = New System.Drawing.Size(209, 26)
        Me.TxtUsers.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirm Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "New Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name:"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(316, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Location = New System.Drawing.Point(216, 144)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(94, 32)
        Me.BtnReset.TabIndex = 2
        Me.BtnReset.Text = "Reset Password"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'LblSave
        '
        Me.LblSave.AutoSize = True
        Me.LblSave.Location = New System.Drawing.Point(16, 160)
        Me.LblSave.Name = "LblSave"
        Me.LblSave.Size = New System.Drawing.Size(13, 13)
        Me.LblSave.TabIndex = 3
        Me.LblSave.Text = "0"
        Me.LblSave.Visible = False
        '
        'ErrSetPwd
        '
        Me.ErrSetPwd.ContainerControl = Me
        '
        'FormChangePwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 181)
        Me.Controls.Add(Me.LblSave)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormChangePwd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrSetPwd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtConfirmPwd As System.Windows.Forms.TextBox
    Friend WithEvents TxtNewPwd As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsers As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents LblSave As System.Windows.Forms.Label
    Friend WithEvents ErrSetPwd As System.Windows.Forms.ErrorProvider
End Class
