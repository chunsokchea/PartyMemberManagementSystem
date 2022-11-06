Imports System.Data.SqlClient

Imports System.Text.RegularExpressions


Public Class FormUserEditor

    Public PasswordMashText As String = "1234567890qwertyabcdefJ"

    Private Sub FormUserEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        UI.FormatDataGrid(Me.dgv)
        Me.dgv.ReadOnly = False
        Me.dgv.Columns("Active").ReadOnly = False
        Me.dgv.Columns("RoleName").ReadOnly = True

    End Sub
    Public Sub LoadRoleByUser(ByVal UserId As Int16)
        cmd.Parameters("@UserId") = UserId
        Dim sql = <xml>
                    SELECT Active, RoleId, RoleName from qrUserRole;
                </xml>
        Me.dgv.DataSource = cmd.ExecuteDataTable(sql)
        'Me.dgv.DataSource = cmd.ExecuteDataTable("SELECT Active=ISNULL(ur.Active,0),r.RoleId,r.RoleName FROM system.Role r LEFT JOIN system.UserRole ur ON r.RoleId=ur.RoleId AND ur.UserId=@UserId WHERE r.Active=1")
        'Me.dgv.DataSource = cmd.ExecuteDataTable("SELECT Active=ISNULL(ur.Active,0),r.RoleId,r.RoleName FROM [system_Role] r LEFT JOIN [system_UserRole] ur ON r.RoleId=ur.RoleId AND ur.UserId=@UserId WHERE r.Active=true")
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If Me.txtUserName.Text.Trim() = "" Then
            MsgBox("Please input user name!")
            Me.txtEmail.Focus()
            Exit Sub
        End If

        If Validator.IsEmail(Me.txtEmail.Text) = False Then
            MsgBox("Please input correct email!")
            Me.txtEmail.Focus()
            Exit Sub
        End If

        If Validator.IsStrongPassword(Me.txtPassword.Text) Then
            MessageBox.Show("Password must be strong!")
            txtPassword.Focus()
            Exit Sub
        End If
         
        Dim password = Crypto.PasswordHash(Me.txtUserName.Text, Me.txtPassword.Text)


        cmd.Parameters("@UserName") = Me.txtUserName.Text
        cmd.Parameters("@FullName") = Me.txtFullName.Text
        cmd.Parameters("@Email") = Me.txtEmail.Text
        cmd.Parameters("@Locked") = Me.chkLocked.Checked
        cmd.Parameters("@ChangePasswordAtLogOn") = Me.chkChangePasswordAtLogon.Checked
        ' cmd.Parameters("@Password") = password
        If Me.txtUserId.Text = "" Then
            cmd.Parameters("@Password") = password
            cmd.ExecuteNonQuery("INSERT INTO [system_User] ([UserName], [FullName], [Email], [Locked], [ChangePasswordAtLogOn],[Password], [Active]) VALUES(@UserName,@FullName,@Email,@Locked,@ChangePasswordAtLogOn,@Password,1);")
            Me.txtUserId.Text = cmd.ExecuteScalar("SELECT MAX(UserId) FROM [system_User]")
        Else
            ' not update password
            cmd.Parameters("@UserId") = Me.txtUserId.Text
            cmd.ExecuteNonQuery("UPDATE [system_User]  SET [UserName]=@UserName, [FullName]=@FullName, [Email]=@Email, [Locked]=@Locked, [ChangePasswordAtLogOn]= @ChangePasswordAtLogOn WHERE UserId=@UserId")
            If Me.txtPassword.Text <> Me.PasswordMashText Then
                cmd.Parameters("@Password") = password
                cmd.Parameters("@UserId") = Me.txtUserId.Text
                cmd.ExecuteNonQuery("UPDATE [system_User] SET [Password]=@Password WHERE UserId=@UserId")
            End If
        End If


        'save role

        For Each row As DataGridViewRow In Me.dgv.Rows
            cmd.Parameters("@UserId") = Me.txtUserId.Text
            cmd.Parameters("@RoleId") = row.Cells("RoleId").Value
            'cmd.Parameters("@Active") = row.Cells("Active").Value
            Dim sqlr = "SELECT COUNT(*) FROM [system_UserRole] WHERE UserId=@UserId AND RoleId=@RoleId"
            Dim result = cmd.ExecuteScalar(sqlr)
            If result = 0 Then
                cmd.Parameters("@UserId") = Me.txtUserId.Text
                cmd.Parameters("@RoleId") = row.Cells("RoleId").Value
                cmd.Parameters("@Active") = row.Cells("Active").Value
                Dim sqli = "INSERT INTO [system_UserRole] (UserId, RoleId, Active) VALUES(@UserId,@RoleId,@Active)"
                cmd.ExecuteNonQuery(sqli)
            Else
                cmd.Parameters("@Active") = row.Cells("Active").Value
                cmd.Parameters("@UserId") = Me.txtUserId.Text
                cmd.Parameters("@RoleId") = row.Cells("RoleId").Value
                Dim sqlu = "UPDATE [system_UserRole] SET [Active]=@Active WHERE UserId=@UserId AND RoleId=@RoleId;"
                cmd.ExecuteNonQuery(sqlu)
            End If

            ' cmd.ExecuteNonQuery("IF NOT EXISTS(SELECT * FROM [system_UserRole] WHERE UserId=@UserId AND RoleId=@RoleId) INSERT INTO [system_UserRole] VALUES(@UserId,@RoleId,@Active); ELSE  UPDATE [system_UserRole] SET Active=@Active WHERE UserId=@UserId AND RoleId=@RoleId;")
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

End Class