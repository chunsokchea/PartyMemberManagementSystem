Public Class FormChangePassword

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel 
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            cmd.Parameters("@UserName") = Me.txtUserName.Text
            cmd.Parameters("@Password") = Crypto.PasswordHash(Me.txtUserName.Text, Me.txtPassword.Text)
            Dim dt = cmd.ExecuteDataTable("SELECT * FROM [system_User] WHERE [UserName]=@UserName AND [Password]=@Password AND Active=true")
            If dt.Rows.Count <> 1 Then
                MsgBox("Invalid old password!")
                Exit Sub
            End If

            If Me.txtNewPassswordConfirm.Text <> Me.txtNewPassword.Text Then
                MsgBox("New password is not correct!")
                Exit Sub
            End If

            cmd.Parameters("@Password") = Crypto.PasswordHash(Me.txtUserName.Text, Me.txtNewPassword.Text)
            'cmd.Parameters("@UserName") = Me.txtUserName.Text
            cmd.Parameters("@Id") = dt.Rows(0).Item("UserId")
            cmd.ExecuteNonQuery("UPDATE [system_User] SET [Password]=@Password,ChangePasswordAtLogOn=0 WHERE UserId=@Id")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        'MessageBox.Show("ABC")
    End Sub
End Class