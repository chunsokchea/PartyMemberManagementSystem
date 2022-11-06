Public Class FormLogin

    
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MessageBox.Show("Are you sure want to close ?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If 
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
       
        Cmd.Parameters("@UserName") = Me.txtUserName.Text
        Cmd.Parameters("@Password") = Crypto.PasswordHash(Me.txtUserName.Text, Me.txtPassword.Text)
        Dim dt = cmd.ExecuteDataTable("SELECT * FROM [system_User] WHERE [UserName]=@UserName AND [Password]=@Password AND Active=true")
        If dt.Rows.Count <> 1 Then
            MsgBox("Invalid user name or password!")
            Exit Sub
        End If

        Dim row = dt.Rows(0)
        If row("Locked") = True Then
            MsgBox("User is already locked~!")
            Exit Sub
        End If
 
        App.UserName = row("UserName")
        App.UserFullName = row("FullName")
        Cmd.Parameters("@UserId") = row("UserId")

        Dim sql = <xml>
                        SELECT DISTINCT PermissionId FROM (system_UserRole ur   
                        INNER JOIN system_Role r ON (ur.RoleId=r.RoleId AND ur.Active=true))
                        INNER JOIN system_RolePermission rp ON (rp.RoleId=r.RoleId AND rp.Active=true) 
                        WHERE ur.UserId=@UserId                       
                    </xml>
        '" SELECT DISTINCT  PermissionId FROM system_UserRole ur, system_Role r,system_RolePermission rp WHERE ur.RoleId = r.RoleId And rp.RoleId = r.RoleId And ur.Active = True And rp.Active = True AND ur.UserId=4;"
        'App.AuthorizedPermissions = Cmd.ExecuteDataTable("SELECT DISTINCT PermissionId FROM system.UserRole ur   INNER JOIN system.Role r ON ur.RoleId=r.RoleId AND ur.Active=1 INNER JOIN system.RolePermission rp ON rp.RoleId=r.RoleId AND rp.Active=1 WHERE ur.UserId=@UserId")
        App.AuthorizedPermissions = cmd.ExecuteDataTable(sql)
        If row("ChangePasswordAtLogOn") = True Then
            Dim frm = New FormChangePassword()
            frm.txtUserName.Text = Me.txtUserName.Text
            frm.txtPassword.Text = Me.txtPassword.Text
            frm.ShowDialog()
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql = <xml>
                        SELECT DISTINCT  PermissionId 
                        FROM system_UserRole ur, system_Role r,system_RolePermission rp
                        WHERE ur.RoleId=r.RoleId AND rp.RoleId=r.RoleId AND ur.Active=true AND rp.Active=true
                        AND ur.UserId=4;
                    </xml>
        Dim dt As New DataTable
        dt = Cmd.ExecuteDataTable(sql)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class