Public Class ViewImg
    Dim ElectForm As ElectionComparetion
    Dim GenDAOStatisic As New DAOStatistic
    Sub New(ByVal ElectForm As ElectionComparetion)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.ElectForm = ElectForm
        ' Add any initialization after the InitializeComponent() call.

    End Sub

   
    Private Sub ViewImg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New System.Drawing.Point(0, 0)
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MessageBox.Show("Do you want to update is currect data?", "Correct", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If GenDAOStatisic.UpdateDAO("UPDATE MOI_TEM_RESULT SET IS_CURRECT='1' WHERE AFISID=" & LblSaveOption.Text) = 1 Then
                MessageBox.Show("Update successful.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class