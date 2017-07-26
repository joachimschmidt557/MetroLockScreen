Public Class LogIn

    Private Sub LogIn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Logon
        PictureBoxUser.BackgroundImage = My.Resources.user

        LabelUserName.Text = My.Settings.Username

        Me.Size = Screen.PrimaryScreen.Bounds.Size
        Me.Location = New Point(0, 0)
        Me.Refresh()
    End Sub

    Private Sub ButtonOK_Click(sender As System.Object, e As System.EventArgs) Handles ButtonOK.Click
        If TextBoxPassword.Text = My.Settings.Password Then
            Application.Exit()
        End If
    End Sub
End Class