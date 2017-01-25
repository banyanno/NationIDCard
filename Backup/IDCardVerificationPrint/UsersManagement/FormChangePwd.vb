Public Class FormChangePwd

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        If ValidateTextField(TxtNewPwd, "", ErrSetPwd) = False Then Exit Sub
        If ValidateTextField(TxtNewPwd, "", ErrSetPwd) = False Then Exit Sub
        If ValidateTextField(TxtConfirmPwd, "", ErrSetPwd) = False Then Exit Sub
        If TxtNewPwd.Text <> TxtConfirmPwd.Text Then
            MessageBox.Show("Not match password. Please try again", "Reset password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Do you want to reset password?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If ModUserMG.ResetPassword(LblSave.Text, TxtNewPwd.Text) = 1 Then
                MessageBox.Show("Reset successful", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else
                MessageBox.Show("Error reset password. Please contact sys administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class